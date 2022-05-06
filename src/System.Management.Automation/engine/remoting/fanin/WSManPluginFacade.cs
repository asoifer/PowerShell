// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
// ----------------------------------------------------------------------
//  Contents:  Entry points for managed PowerShell plugin worker used to
//  host powershell in a WSMan service.
// ----------------------------------------------------------------------

using System.Threading;
using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using System.Management.Automation.Internal;
using System.Globalization;

namespace System.Management.Automation.Remoting
{
    // TODO: Does this comment still apply?
    // The following complex delegate + native function pointer model is used
    // because of a problem with GCRoot. GCRoots cannot hold reference to the
    // AppDomain that created it. In the IIS hosting scenario, there may be
    // cases where multiple AppDomains exist in the same hosting process. In such
    // cases if GCRoot is used, CLR will pick up the first AppDomain in the list
    // to get the managed handle. Delegates are not just function pointers, they
    // also contain a reference to the AppDomain that created it. However the catch
    // is that delegates must be marshalled into their respective unmanaged function
    // pointers (otherwise we end up storing the delegate into a GCRoot).

    /// <summary>
    /// </summary>
    /// <param name="pluginContext">PVOID.</param>
    /// <param name="requestDetails">WSMAN_PLUGIN_REQUEST*.</param>
    /// <param name="flags">DWORD.</param>
    /// <param name="extraInfo">PCWSTR.</param>
    /// <param name="startupInfo">WSMAN_SHELL_STARTUP_INFO*.</param>
    /// <param name="inboundShellInformation">WSMAN_DATA*.</param>
    internal delegate void WSMPluginShellDelegate( // TODO: Rename to WSManPluginShellDelegate once I remove the MC++ module.
        IntPtr pluginContext,
        IntPtr requestDetails,
        int flags,
        [MarshalAs(UnmanagedType.LPWStr)] string extraInfo,
        IntPtr startupInfo,
        IntPtr inboundShellInformation);

    /// <summary>
    /// </summary>
    /// <param name="pluginContext">PVOID.</param>
    /// <param name="shellContext">PVOID.</param>
    internal delegate void WSMPluginReleaseShellContextDelegate(
        IntPtr pluginContext,
        IntPtr shellContext);

    /// <summary>
    /// </summary>
    /// <param name="pluginContext">PVOID.</param>
    /// <param name="requestDetails">WSMAN_PLUGIN_REQUEST*.</param>
    /// <param name="flags">DWORD.</param>
    /// <param name="shellContext">PVOID.</param>
    /// <param name="commandContext">PVOID optional.</param>
    /// <param name="inboundConnectInformation">WSMAN_DATA* optional.</param>
    internal delegate void WSMPluginConnectDelegate(
        IntPtr pluginContext,
        IntPtr requestDetails,
        int flags,
        IntPtr shellContext,
        IntPtr commandContext,
        IntPtr inboundConnectInformation);

    /// <summary>
    /// </summary>
    /// <param name="pluginContext">PVOID.</param>
    /// <param name="requestDetails">WSMAN_PLUGIN_REQUEST*.</param>
    /// <param name="flags">DWORD.</param>
    /// <param name="shellContext">PVOID.</param>
    /// <param name="commandLine">PCWSTR.</param>
    /// <param name="arguments">WSMAN_COMMAND_ARG_SET*.</param>
    internal delegate void WSMPluginCommandDelegate(
        IntPtr pluginContext,
        IntPtr requestDetails,
        int flags,
        IntPtr shellContext,
        [MarshalAs(UnmanagedType.LPWStr)] string commandLine,
        IntPtr arguments);

    /// <summary>
    /// Delegate that is passed to native layer for callback on operation shutdown notifications.
    /// </summary>
    /// <param name="shutdownContext">IntPtr.</param>
    internal delegate void WSMPluginOperationShutdownDelegate(
           IntPtr shutdownContext);

    /// <summary>
    /// </summary>
    /// <param name="pluginContext">PVOID.</param>
    /// <param name="shellContext">PVOID.</param>
    /// <param name="commandContext">PVOID.</param>
    internal delegate void WSMPluginReleaseCommandContextDelegate(
        IntPtr pluginContext,
        IntPtr shellContext,
        IntPtr commandContext);

    /// <summary>
    /// </summary>
    /// <param name="pluginContext">PVOID.</param>
    /// <param name="requestDetails">WSMAN_PLUGIN_REQUEST*.</param>
    /// <param name="flags">DWORD.</param>
    /// <param name="shellContext">PVOID.</param>
    /// <param name="commandContext">PVOID.</param>
    /// <param name="stream">PCWSTR.</param>
    /// <param name="inboundData">WSMAN_DATA*.</param>
    internal delegate void WSMPluginSendDelegate(
        IntPtr pluginContext,
        IntPtr requestDetails,
        int flags,
        IntPtr shellContext,
        IntPtr commandContext,
        [MarshalAs(UnmanagedType.LPWStr)] string stream,
        IntPtr inboundData);

    /// <summary>
    /// </summary>
    /// <param name="pluginContext">PVOID.</param>
    /// <param name="requestDetails">WSMAN_PLUGIN_REQUEST*.</param>
    /// <param name="flags">DWORD.</param>
    /// <param name="shellContext">PVOID.</param>
    /// <param name="commandContext">PVOID optional.</param>
    /// <param name="streamSet">WSMAN_STREAM_ID_SET* optional.</param>
    internal delegate void WSMPluginReceiveDelegate(
        IntPtr pluginContext,
        IntPtr requestDetails,
        int flags,
        IntPtr shellContext,
        IntPtr commandContext,
        IntPtr streamSet);

    /// <summary>
    /// </summary>
    /// <param name="pluginContext">PVOID.</param>
    /// <param name="requestDetails">WSMAN_PLUGIN_REQUEST*.</param>
    /// <param name="flags">DWORD.</param>
    /// <param name="shellContext">PVOID.</param>
    /// <param name="commandContext">PVOID optional.</param>
    /// <param name="code">PCWSTR.</param>
    internal delegate void WSMPluginSignalDelegate(
        IntPtr pluginContext,
        IntPtr requestDetails,
        int flags,
        IntPtr shellContext,
        IntPtr commandContext,
        [MarshalAs(UnmanagedType.LPWStr)] string code);

    /// <summary>
    /// Callback that handles shell shutdown notification events.
    /// </summary>
    /// <param name="state"></param>
    /// <param name="timedOut"></param>
    internal delegate void WaitOrTimerCallbackDelegate(
        IntPtr state,
        bool timedOut);

    /// <summary>
    /// </summary>
    /// <param name="pluginContext">PVOID.</param>
    internal delegate void WSMShutdownPluginDelegate(
        IntPtr pluginContext);
    internal sealed class WSManPluginEntryDelegates : IDisposable
    {
        private WSManPluginEntryDelegatesInternal _unmanagedStruct;

        internal WSManPluginEntryDelegatesInternal UnmanagedStruct
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1641, 7167, 7199);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 7173, 7197);

                    return _unmanagedStruct;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1641, 7167, 7199);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1641, 7084, 7210);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1641, 7084, 7210);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool _disposed;

        private GCHandle _pluginShellGCHandle;

        private GCHandle _pluginReleaseShellContextGCHandle;

        private GCHandle _pluginCommandGCHandle;

        private GCHandle _pluginReleaseCommandContextGCHandle;

        private GCHandle _pluginSendGCHandle;

        private GCHandle _pluginReceiveGCHandle;

        private GCHandle _pluginSignalGCHandle;

        private GCHandle _pluginConnectGCHandle;

        private GCHandle _shutdownPluginGCHandle;

        private GCHandle _WSMPluginOperationShutdownGCHandle;

        internal WSManPluginEntryDelegates()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1641, 8144, 8236);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 7015, 7073);
                this._unmanagedStruct = f_1641_7034_7073();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 7286, 7303);
                this._disposed = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 8205, 8225);

                f_1641_8205_8224(this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1641, 8144, 8236);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1641, 8144, 8236);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1641, 8144, 8236);
            }
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1641, 8435, 8546);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 8481, 8495);

                f_1641_8481_8494(this, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 8509, 8535);

                f_1641_8509_8534(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1641, 8435, 8546);

                int
                f_1641_8481_8494(System.Management.Automation.Remoting.WSManPluginEntryDelegates
                this_param, bool
                disposing)
                {
                    this_param.Dispose(disposing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1641, 8481, 8494);
                    return 0;
                }


                int
                f_1641_8509_8534(System.Management.Automation.Remoting.WSManPluginEntryDelegates
                obj)
                {
                    GC.SuppressFinalize((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1641, 8509, 8534);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1641, 8435, 8546);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1641, 8435, 8546);
            }
        }

        private void Dispose(bool disposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1641, 8709, 8942);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 8770, 8809) || true) && (_disposed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1641, 8770, 8809);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 8802, 8809);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1641, 8770, 8809);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 8874, 8898);

                f_1641_8874_8897(
                            // Free any unmanaged objects here.
                            this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 8914, 8931);

                _disposed = true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1641, 8709, 8942);

                int
                f_1641_8874_8897(System.Management.Automation.Remoting.WSManPluginEntryDelegates
                this_param)
                {
                    this_param.CleanUpDelegates();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1641, 8874, 8897);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1641, 8709, 8942);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1641, 8709, 8942);
            }
        }

        /// <summary>
        /// Use C# destructor syntax for finalization code.
        /// This destructor will run only if the Dispose method
        /// does not get called.
        /// It gives your base class the opportunity to finalize.
        /// Do not provide destructors in types derived from this class.
        /// </summary>
        ~WSManPluginEntryDelegates()
        {
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 9355, 9370);

            f_1641_9355_9369(this, false);
        }

        private void populateDelegates()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1641, 9619, 14194);
                // if a delegate is re-located by a garbage collection, it will not affect
                // the underlaying managed callback, so Alloc is used to add a reference
                // to the delegate, allowing relocation of the delegate, but preventing
                // disposal. Using GCHandle without pinning reduces fragmentation potential
                // of the managed heap.
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 10080, 10193);

                    WSMPluginShellDelegate
                    pluginShell = new WSMPluginShellDelegate(WSManPluginManagedEntryWrapper.WSManPluginShell)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 10211, 10262);

                    _pluginShellGCHandle = GCHandle.Alloc(pluginShell);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 10499, 10600);

                    _unmanagedStruct.wsManPluginShellCallbackNative = f_1641_10549_10599(pluginShell);
                }
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 10648, 10817);

                    WSMPluginReleaseShellContextDelegate
                    pluginReleaseShellContext = new WSMPluginReleaseShellContextDelegate(WSManPluginManagedEntryWrapper.WSManPluginReleaseShellContext)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 10835, 10914);

                    _pluginReleaseShellContextGCHandle = GCHandle.Alloc(pluginReleaseShellContext);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 10932, 11061);

                    _unmanagedStruct.wsManPluginReleaseShellContextCallbackNative = f_1641_10996_11060(pluginReleaseShellContext);
                }
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 11109, 11230);

                    WSMPluginCommandDelegate
                    pluginCommand = new WSMPluginCommandDelegate(WSManPluginManagedEntryWrapper.WSManPluginCommand)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 11248, 11303);

                    _pluginCommandGCHandle = GCHandle.Alloc(pluginCommand);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 11321, 11426);

                    _unmanagedStruct.wsManPluginCommandCallbackNative = f_1641_11373_11425(pluginCommand);
                }
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 11474, 11651);

                    WSMPluginReleaseCommandContextDelegate
                    pluginReleaseCommandContext = new WSMPluginReleaseCommandContextDelegate(WSManPluginManagedEntryWrapper.WSManPluginReleaseCommandContext)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 11669, 11752);

                    _pluginReleaseCommandContextGCHandle = GCHandle.Alloc(pluginReleaseCommandContext);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 11770, 11903);

                    _unmanagedStruct.wsManPluginReleaseCommandContextCallbackNative = f_1641_11836_11902(pluginReleaseCommandContext);
                }
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 11951, 12060);

                    WSMPluginSendDelegate
                    pluginSend = new WSMPluginSendDelegate(WSManPluginManagedEntryWrapper.WSManPluginSend)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 12078, 12127);

                    _pluginSendGCHandle = GCHandle.Alloc(pluginSend);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 12145, 12244);

                    _unmanagedStruct.wsManPluginSendCallbackNative = f_1641_12194_12243(pluginSend);
                }
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 12292, 12413);

                    WSMPluginReceiveDelegate
                    pluginReceive = new WSMPluginReceiveDelegate(WSManPluginManagedEntryWrapper.WSManPluginReceive)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 12431, 12486);

                    _pluginReceiveGCHandle = GCHandle.Alloc(pluginReceive);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 12504, 12609);

                    _unmanagedStruct.wsManPluginReceiveCallbackNative = f_1641_12556_12608(pluginReceive);
                }
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 12657, 12774);

                    WSMPluginSignalDelegate
                    pluginSignal = new WSMPluginSignalDelegate(WSManPluginManagedEntryWrapper.WSManPluginSignal)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 12792, 12845);

                    _pluginSignalGCHandle = GCHandle.Alloc(pluginSignal);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 12863, 12966);

                    _unmanagedStruct.wsManPluginSignalCallbackNative = f_1641_12914_12965(pluginSignal);
                }
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 13014, 13135);

                    WSMPluginConnectDelegate
                    pluginConnect = new WSMPluginConnectDelegate(WSManPluginManagedEntryWrapper.WSManPluginConnect)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 13153, 13208);

                    _pluginConnectGCHandle = GCHandle.Alloc(pluginConnect);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 13226, 13331);

                    _unmanagedStruct.wsManPluginConnectCallbackNative = f_1641_13278_13330(pluginConnect);
                }
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 13379, 13499);

                    WSMShutdownPluginDelegate
                    shutdownPlugin = new WSMShutdownPluginDelegate(WSManPluginManagedEntryWrapper.ShutdownPlugin)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 13517, 13574);

                    _shutdownPluginGCHandle = GCHandle.Alloc(shutdownPlugin);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 13592, 13705);

                    _unmanagedStruct.wsManPluginShutdownPluginCallbackNative = f_1641_13651_13704(shutdownPlugin);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 13736, 14183) || true) && (f_1641_13740_13759_M(!Platform.IsWindows))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1641, 13736, 14183);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 13793, 13940);

                    WSMPluginOperationShutdownDelegate
                    pluginShutDownDelegate = new WSMPluginOperationShutdownDelegate(WSManPluginManagedEntryWrapper.WSManPSShutdown)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 13958, 14035);

                    _WSMPluginOperationShutdownGCHandle = GCHandle.Alloc(pluginShutDownDelegate);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 14053, 14168);

                    _unmanagedStruct.wsManPluginShutdownCallbackNative = f_1641_14106_14167(pluginShutDownDelegate);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1641, 13736, 14183);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1641, 9619, 14194);

                System.IntPtr
                f_1641_10549_10599(System.Management.Automation.Remoting.WSMPluginShellDelegate
                d)
                {
                    var return_v = Marshal.GetFunctionPointerForDelegate(d);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1641, 10549, 10599);
                    return return_v;
                }


                System.IntPtr
                f_1641_10996_11060(System.Management.Automation.Remoting.WSMPluginReleaseShellContextDelegate
                d)
                {
                    var return_v = Marshal.GetFunctionPointerForDelegate(d);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1641, 10996, 11060);
                    return return_v;
                }


                System.IntPtr
                f_1641_11373_11425(System.Management.Automation.Remoting.WSMPluginCommandDelegate
                d)
                {
                    var return_v = Marshal.GetFunctionPointerForDelegate(d);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1641, 11373, 11425);
                    return return_v;
                }


                System.IntPtr
                f_1641_11836_11902(System.Management.Automation.Remoting.WSMPluginReleaseCommandContextDelegate
                d)
                {
                    var return_v = Marshal.GetFunctionPointerForDelegate(d);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1641, 11836, 11902);
                    return return_v;
                }


                System.IntPtr
                f_1641_12194_12243(System.Management.Automation.Remoting.WSMPluginSendDelegate
                d)
                {
                    var return_v = Marshal.GetFunctionPointerForDelegate(d);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1641, 12194, 12243);
                    return return_v;
                }


                System.IntPtr
                f_1641_12556_12608(System.Management.Automation.Remoting.WSMPluginReceiveDelegate
                d)
                {
                    var return_v = Marshal.GetFunctionPointerForDelegate(d);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1641, 12556, 12608);
                    return return_v;
                }


                System.IntPtr
                f_1641_12914_12965(System.Management.Automation.Remoting.WSMPluginSignalDelegate
                d)
                {
                    var return_v = Marshal.GetFunctionPointerForDelegate(d);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1641, 12914, 12965);
                    return return_v;
                }


                System.IntPtr
                f_1641_13278_13330(System.Management.Automation.Remoting.WSMPluginConnectDelegate
                d)
                {
                    var return_v = Marshal.GetFunctionPointerForDelegate(d);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1641, 13278, 13330);
                    return return_v;
                }


                System.IntPtr
                f_1641_13651_13704(System.Management.Automation.Remoting.WSMShutdownPluginDelegate
                d)
                {
                    var return_v = Marshal.GetFunctionPointerForDelegate(d);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1641, 13651, 13704);
                    return return_v;
                }


                bool
                f_1641_13740_13759_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1641, 13740, 13759);
                    return return_v;
                }


                System.IntPtr
                f_1641_14106_14167(System.Management.Automation.Remoting.WSMPluginOperationShutdownDelegate
                d)
                {
                    var return_v = Marshal.GetFunctionPointerForDelegate(d);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1641, 14106, 14167);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1641, 9619, 14194);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1641, 9619, 14194);
            }
        }

        private void CleanUpDelegates()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1641, 14253, 15081);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 14409, 15070) || true) && (_pluginShellGCHandle != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1641, 14409, 15070);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 14475, 14503);

                    _pluginShellGCHandle.Free();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 14521, 14563);

                    _pluginReleaseShellContextGCHandle.Free();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 14581, 14611);

                    _pluginCommandGCHandle.Free();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 14629, 14673);

                    _pluginReleaseCommandContextGCHandle.Free();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 14691, 14718);

                    _pluginSendGCHandle.Free();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 14736, 14766);

                    _pluginReceiveGCHandle.Free();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 14784, 14813);

                    _pluginSignalGCHandle.Free();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 14831, 14861);

                    _pluginConnectGCHandle.Free();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 14879, 14910);

                    _shutdownPluginGCHandle.Free();

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 14928, 15055) || true) && (f_1641_14932_14951_M(!Platform.IsWindows))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1641, 14928, 15055);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 14993, 15036);

                        _WSMPluginOperationShutdownGCHandle.Free();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1641, 14928, 15055);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1641, 14409, 15070);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1641, 14253, 15081);

                bool
                f_1641_14932_14951_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1641, 14932, 14951);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1641, 14253, 15081);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1641, 14253, 15081);
            }
        }
        [StructLayout(LayoutKind.Sequential)]
        internal class WSManPluginEntryDelegatesInternal
        {
            [SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources")]
            internal IntPtr wsManPluginShutdownPluginCallbackNative;

            [SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources")]
            internal IntPtr wsManPluginShellCallbackNative;

            [SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources")]
            internal IntPtr wsManPluginReleaseShellContextCallbackNative;

            [SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources")]
            internal IntPtr wsManPluginCommandCallbackNative;

            [SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources")]
            internal IntPtr wsManPluginReleaseCommandContextCallbackNative;

            [SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources")]
            internal IntPtr wsManPluginSendCallbackNative;

            [SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources")]
            internal IntPtr wsManPluginReceiveCallbackNative;

            [SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources")]
            internal IntPtr wsManPluginSignalCallbackNative;

            [SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources")]
            internal IntPtr wsManPluginConnectCallbackNative;

            [SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources")]
            internal IntPtr wsManPluginShutdownCallbackNative;

            public WSManPluginEntryDelegatesInternal()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1641, 15324, 18284);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1641, 15324, 18284);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1641, 15324, 18284);
            }


            static WSManPluginEntryDelegatesInternal()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1641, 15324, 18284);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1641, 15324, 18284);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1641, 15324, 18284);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1641, 15324, 18284);
        }

        static WSManPluginEntryDelegates()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1641, 6754, 18291);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1641, 6754, 18291);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1641, 6754, 18291);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1641, 6754, 18291);

        System.Management.Automation.Remoting.WSManPluginEntryDelegates.WSManPluginEntryDelegatesInternal
        f_1641_7034_7073()
        {
            var return_v = new System.Management.Automation.Remoting.WSManPluginEntryDelegates.WSManPluginEntryDelegatesInternal();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1641, 7034, 7073);
            return return_v;
        }


        int
        f_1641_8205_8224(System.Management.Automation.Remoting.WSManPluginEntryDelegates
        this_param)
        {
            this_param.populateDelegates();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1641, 8205, 8224);
            return 0;
        }


        int
        f_1641_9355_9369(System.Management.Automation.Remoting.WSManPluginEntryDelegates
        this_param, bool
        disposing)
        {
            this_param.Dispose(disposing);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1641, 9355, 9369);
            return 0;
        }

    }
    public sealed class WSManPluginManagedEntryWrapper
    {
        private WSManPluginManagedEntryWrapper()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1641, 18664, 18708);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1641, 18664, 18708);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1641, 18664, 18708);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1641, 18664, 18708);
            }
        }

        internal static WSManPluginEntryDelegates workerPtrs;

        public static int InitPlugin(
                    IntPtr wkrPtrs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1641, 19335, 21468);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 19418, 19537) || true) && (IntPtr.Zero == wkrPtrs)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1641, 19418, 19537);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 19478, 19522);

                    return WSManPluginConstants.ExitCodeFailure;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1641, 19418, 19537);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 21271, 21399);

                f_1641_21271_21398(f_1641_21355_21381(workerPtrs), wkrPtrs, false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 21413, 21457);

                return WSManPluginConstants.ExitCodeSuccess;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1641, 19335, 21468);

                System.Management.Automation.Remoting.WSManPluginEntryDelegates.WSManPluginEntryDelegatesInternal
                f_1641_21355_21381(System.Management.Automation.Remoting.WSManPluginEntryDelegates
                this_param)
                {
                    var return_v = this_param.UnmanagedStruct;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1641, 21355, 21381);
                    return return_v;
                }


                int
                f_1641_21271_21398(System.Management.Automation.Remoting.WSManPluginEntryDelegates.WSManPluginEntryDelegatesInternal
                structure, System.IntPtr
                ptr, bool
                fDeleteOld)
                {
                    Marshal.StructureToPtr<WSManPluginEntryDelegates.WSManPluginEntryDelegatesInternal>(structure, ptr, fDeleteOld);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1641, 21271, 21398);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1641, 19335, 21468);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1641, 19335, 21468);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static void ShutdownPlugin(
                    IntPtr pluginContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1641, 21681, 21945);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 21775, 21826);

                f_1641_21775_21825(pluginContext);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 21842, 21934) || true) && (workerPtrs != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1641, 21842, 21934);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 21898, 21919);

                    f_1641_21898_21918(workerPtrs);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1641, 21842, 21934);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1641, 21681, 21945);

                int
                f_1641_21775_21825(System.IntPtr
                pluginContext)
                {
                    WSManPluginInstance.PerformShutdown(pluginContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1641, 21775, 21825);
                    return 0;
                }


                int
                f_1641_21898_21918(System.Management.Automation.Remoting.WSManPluginEntryDelegates
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1641, 21898, 21918);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1641, 21681, 21945);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1641, 21681, 21945);
            }
        }

        public static void WSManPluginConnect(
                    IntPtr pluginContext,
                    IntPtr requestDetails,
                    int flags,
                    IntPtr shellContext,
                    IntPtr commandContext,
                    IntPtr inboundConnectInformation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1641, 22385, 23308);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 22660, 23140) || true) && (IntPtr.Zero == pluginContext)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1641, 22660, 23140);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 22726, 23100);

                    f_1641_22726_23099(requestDetails, WSManPluginErrorCodes.NullPluginContext, f_1641_22891_23076(f_1641_22935_22986(), "pluginContext", "WSManPluginConnect"));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 23118, 23125);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1641, 22660, 23140);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 23156, 23297);

                f_1641_23156_23296(pluginContext, requestDetails, flags, shellContext, commandContext, inboundConnectInformation);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1641, 22385, 23308);

                string
                f_1641_22935_22986()
                {
                    var return_v = RemotingErrorIdStrings.WSManPluginNullPluginContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1641, 22935, 22986);
                    return return_v;
                }


                string
                f_1641_22891_23076(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1641, 22891, 23076);
                    return return_v;
                }


                int
                f_1641_22726_23099(System.IntPtr
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode, string
                errorMessage)
                {
                    WSManPluginInstance.ReportOperationComplete(requestDetails, errorCode, errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1641, 22726, 23099);
                    return 0;
                }


                int
                f_1641_23156_23296(System.IntPtr
                pluginContext, System.IntPtr
                requestDetails, int
                flags, System.IntPtr
                shellContext, System.IntPtr
                commandContext, System.IntPtr
                inboundConnectInformation)
                {
                    WSManPluginInstance.PerformWSManPluginConnect(pluginContext, requestDetails, flags, shellContext, commandContext, inboundConnectInformation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1641, 23156, 23296);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1641, 22385, 23308);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1641, 22385, 23308);
            }
        }

        public static void WSManPluginShell(
                    IntPtr pluginContext,
                    IntPtr requestDetails,
                    int flags,
                    [MarshalAs(UnmanagedType.LPWStr)] string extraInfo,
                    IntPtr startupInfo,
                    IntPtr inboundShellInformation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1641, 23743, 25133);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 24042, 24520) || true) && (IntPtr.Zero == pluginContext)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1641, 24042, 24520);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 24108, 24480);

                    f_1641_24108_24479(requestDetails, WSManPluginErrorCodes.NullPluginContext, f_1641_24273_24456(f_1641_24317_24368(), "pluginContext", "WSManPluginShell"));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 24498, 24505);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1641, 24042, 24520);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 24632, 24967) || true) && (f_1641_24636_24742("__PSRemoteRunspaceWaitForDebugger", EnvironmentVariableTarget.Machine) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1641, 24632, 24967);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 24784, 24814);

                    bool
                    debuggerAttached = false
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 24832, 24952) || true) && (!debuggerAttached)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1641, 24832, 24952);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 24898, 24933);

                            f_1641_24898_24932(100);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1641, 24832, 24952);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1641, 24832, 24952);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1641, 24832, 24952);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1641, 24632, 24967);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 24991, 25122);

                f_1641_24991_25121(pluginContext, requestDetails, flags, extraInfo, startupInfo, inboundShellInformation);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1641, 23743, 25133);

                string
                f_1641_24317_24368()
                {
                    var return_v = RemotingErrorIdStrings.WSManPluginNullPluginContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1641, 24317, 24368);
                    return return_v;
                }


                string
                f_1641_24273_24456(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1641, 24273, 24456);
                    return return_v;
                }


                int
                f_1641_24108_24479(System.IntPtr
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode, string
                errorMessage)
                {
                    WSManPluginInstance.ReportOperationComplete(requestDetails, errorCode, errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1641, 24108, 24479);
                    return 0;
                }


                string?
                f_1641_24636_24742(string
                variable, System.EnvironmentVariableTarget
                target)
                {
                    var return_v = Environment.GetEnvironmentVariable(variable, target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1641, 24636, 24742);
                    return return_v;
                }


                int
                f_1641_24898_24932(int
                millisecondsTimeout)
                {
                    System.Threading.Thread.Sleep(millisecondsTimeout);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1641, 24898, 24932);
                    return 0;
                }


                int
                f_1641_24991_25121(System.IntPtr
                pluginContext, System.IntPtr
                requestDetails, int
                flags, string
                extraInfo, System.IntPtr
                startupInfo, System.IntPtr
                inboundShellInformation)
                {
                    WSManPluginInstance.PerformWSManPluginShell(pluginContext, requestDetails, flags, extraInfo, startupInfo, inboundShellInformation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1641, 24991, 25121);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1641, 23743, 25133);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1641, 23743, 25133);
            }
        }

        public static void WSManPluginReleaseShellContext(
                    IntPtr pluginContext,
                    IntPtr shellContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1641, 25303, 25580);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1641, 25303, 25580);
                // NO-OP..as our plugin does not own the memory related
                // to shellContext and so there is nothing to release
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1641, 25303, 25580);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1641, 25303, 25580);
            }
        }

        public static void WSManPluginCommand(
                    IntPtr pluginContext,
                    IntPtr requestDetails,
                    int flags,
                    IntPtr shellContext,
                    [MarshalAs(UnmanagedType.LPWStr)] string commandLine,
                    IntPtr arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1641, 26004, 26924);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 26294, 26775) || true) && (IntPtr.Zero == pluginContext)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1641, 26294, 26775);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 26360, 26735);

                    f_1641_26360_26734(requestDetails, WSManPluginErrorCodes.NullPluginContext, f_1641_26525_26711(f_1641_26569_26620(), "Plugin Context", "WSManPluginCommand"));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 26753, 26760);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1641, 26294, 26775);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 26791, 26913);

                f_1641_26791_26912(pluginContext, requestDetails, flags, shellContext, commandLine, arguments);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1641, 26004, 26924);

                string
                f_1641_26569_26620()
                {
                    var return_v = RemotingErrorIdStrings.WSManPluginNullPluginContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1641, 26569, 26620);
                    return return_v;
                }


                string
                f_1641_26525_26711(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1641, 26525, 26711);
                    return return_v;
                }


                int
                f_1641_26360_26734(System.IntPtr
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode, string
                errorMessage)
                {
                    WSManPluginInstance.ReportOperationComplete(requestDetails, errorCode, errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1641, 26360, 26734);
                    return 0;
                }


                int
                f_1641_26791_26912(System.IntPtr
                pluginContext, System.IntPtr
                requestDetails, int
                flags, System.IntPtr
                shellContext, string
                commandLine, System.IntPtr
                arguments)
                {
                    WSManPluginInstance.PerformWSManPluginCommand(pluginContext, requestDetails, flags, shellContext, commandLine, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1641, 26791, 26912);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1641, 26004, 26924);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1641, 26004, 26924);
            }
        }

        public static void WSManPSShutdown(
                    IntPtr shutdownContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1641, 27169, 27458);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 27266, 27318);

                GCHandle
                gch = GCHandle.FromIntPtr(shutdownContext)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 27332, 27390);

                EventWaitHandle
                eventHandle = (EventWaitHandle)gch.Target
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 27404, 27422);

                f_1641_27404_27421(eventHandle);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 27436, 27447);

                gch.Free();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1641, 27169, 27458);

                bool
                f_1641_27404_27421(System.Threading.EventWaitHandle
                this_param)
                {
                    var return_v = this_param.Set();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1641, 27404, 27421);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1641, 27169, 27458);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1641, 27169, 27458);
            }
        }

        public static void WSManPluginReleaseCommandContext(
                    IntPtr pluginContext,
                    IntPtr shellContext,
                    IntPtr commandContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1641, 27685, 28003);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1641, 27685, 28003);
                // NO-OP..as our plugin does not own the memory related
                // to commandContext and so there is nothing to release.
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1641, 27685, 28003);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1641, 27685, 28003);
            }
        }

        public static void WSManPluginSend(
                    IntPtr pluginContext,
                    IntPtr requestDetails,
                    int flags,
                    IntPtr shellContext,
                    IntPtr commandContext,
                    [MarshalAs(UnmanagedType.LPWStr)] string stream,
                    IntPtr inboundData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1641, 28461, 29418);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 28781, 29259) || true) && (IntPtr.Zero == pluginContext)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1641, 28781, 29259);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 28847, 29219);

                    f_1641_28847_29218(requestDetails, WSManPluginErrorCodes.NullPluginContext, f_1641_29012_29195(f_1641_29056_29107(), "Plugin Context", "WSManPluginSend"));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 29237, 29244);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1641, 28781, 29259);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 29275, 29407);

                f_1641_29275_29406(pluginContext, requestDetails, flags, shellContext, commandContext, stream, inboundData);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1641, 28461, 29418);

                string
                f_1641_29056_29107()
                {
                    var return_v = RemotingErrorIdStrings.WSManPluginNullPluginContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1641, 29056, 29107);
                    return return_v;
                }


                string
                f_1641_29012_29195(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1641, 29012, 29195);
                    return return_v;
                }


                int
                f_1641_28847_29218(System.IntPtr
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode, string
                errorMessage)
                {
                    WSManPluginInstance.ReportOperationComplete(requestDetails, errorCode, errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1641, 28847, 29218);
                    return 0;
                }


                int
                f_1641_29275_29406(System.IntPtr
                pluginContext, System.IntPtr
                requestDetails, int
                flags, System.IntPtr
                shellContext, System.IntPtr
                commandContext, string
                stream, System.IntPtr
                inboundData)
                {
                    WSManPluginInstance.PerformWSManPluginSend(pluginContext, requestDetails, flags, shellContext, commandContext, stream, inboundData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1641, 29275, 29406);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1641, 28461, 29418);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1641, 28461, 29418);
            }
        }

        public static void WSManPluginReceive(
                    IntPtr pluginContext,
                    IntPtr requestDetails,
                    int flags,
                    IntPtr shellContext,
                    IntPtr commandContext,
                    IntPtr streamSet)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1641, 29851, 30743);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 30110, 30591) || true) && (IntPtr.Zero == pluginContext)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1641, 30110, 30591);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 30176, 30551);

                    f_1641_30176_30550(requestDetails, WSManPluginErrorCodes.NullPluginContext, f_1641_30341_30527(f_1641_30385_30436(), "Plugin Context", "WSManPluginReceive"));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 30569, 30576);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1641, 30110, 30591);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 30607, 30732);

                f_1641_30607_30731(pluginContext, requestDetails, flags, shellContext, commandContext, streamSet);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1641, 29851, 30743);

                string
                f_1641_30385_30436()
                {
                    var return_v = RemotingErrorIdStrings.WSManPluginNullPluginContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1641, 30385, 30436);
                    return return_v;
                }


                string
                f_1641_30341_30527(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1641, 30341, 30527);
                    return return_v;
                }


                int
                f_1641_30176_30550(System.IntPtr
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode, string
                errorMessage)
                {
                    WSManPluginInstance.ReportOperationComplete(requestDetails, errorCode, errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1641, 30176, 30550);
                    return 0;
                }


                int
                f_1641_30607_30731(System.IntPtr
                pluginContext, System.IntPtr
                requestDetails, int
                flags, System.IntPtr
                shellContext, System.IntPtr
                commandContext, System.IntPtr
                streamSet)
                {
                    WSManPluginInstance.PerformWSManPluginReceive(pluginContext, requestDetails, flags, shellContext, commandContext, streamSet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1641, 30607, 30731);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1641, 29851, 30743);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1641, 29851, 30743);
            }
        }

        public static void WSManPluginSignal(
                    IntPtr pluginContext,
                    IntPtr requestDetails,
                    int flags,
                    IntPtr shellContext,
                    IntPtr commandContext,
                    [MarshalAs(UnmanagedType.LPWStr)] string code)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1641, 31148, 32096);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 31435, 31950) || true) && ((IntPtr.Zero == pluginContext) || (DynAbs.Tracing.TraceSender.Expression_False(1641, 31439, 31502) || (IntPtr.Zero == shellContext)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1641, 31435, 31950);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 31536, 31910);

                    f_1641_31536_31909(requestDetails, WSManPluginErrorCodes.NullPluginContext, f_1641_31701_31886(f_1641_31745_31796(), "Plugin Context", "WSManPluginSignal"));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 31928, 31935);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1641, 31435, 31950);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 31966, 32085);

                f_1641_31966_32084(pluginContext, requestDetails, flags, shellContext, commandContext, code);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1641, 31148, 32096);

                string
                f_1641_31745_31796()
                {
                    var return_v = RemotingErrorIdStrings.WSManPluginNullPluginContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1641, 31745, 31796);
                    return return_v;
                }


                string
                f_1641_31701_31886(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1641, 31701, 31886);
                    return return_v;
                }


                int
                f_1641_31536_31909(System.IntPtr
                requestDetails, System.Management.Automation.Remoting.WSManPluginErrorCodes
                errorCode, string
                errorMessage)
                {
                    WSManPluginInstance.ReportOperationComplete(requestDetails, errorCode, errorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1641, 31536, 31909);
                    return 0;
                }


                int
                f_1641_31966_32084(System.IntPtr
                pluginContext, System.IntPtr
                requestDetails, int
                flags, System.IntPtr
                shellContext, System.IntPtr
                commandContext, string
                code)
                {
                    WSManPluginInstance.PerformWSManPluginSignal(pluginContext, requestDetails, flags, shellContext, commandContext, code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1641, 31966, 32084);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1641, 31148, 32096);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1641, 31148, 32096);
            }
        }

        public static void PSPluginOperationShutdownCallback(
                    object operationContext,
                    bool timedOut)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1641, 32517, 32983);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 32661, 32745) || true) && (operationContext == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1641, 32661, 32745);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 32723, 32730);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1641, 32661, 32745);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 32761, 32861);

                WSManPluginOperationShutdownContext
                context = (WSManPluginOperationShutdownContext)operationContext
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 32875, 32905);

                context.isShuttingDown = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 32921, 32972);

                f_1641_32921_32971(context);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1641, 32517, 32983);

                int
                f_1641_32921_32971(System.Management.Automation.Remoting.WSManPluginOperationShutdownContext
                context)
                {
                    WSManPluginInstance.PerformCloseOperation(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1641, 32921, 32971);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1641, 32517, 32983);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1641, 32517, 32983);
            }
        }

        static WSManPluginManagedEntryWrapper()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1641, 18458, 33012);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 18897, 18941);
            workerPtrs = f_1641_18910_18941();
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1641, 18458, 33012);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1641, 18458, 33012);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1641, 18458, 33012);

        static System.Management.Automation.Remoting.WSManPluginEntryDelegates
        f_1641_18910_18941()
        {
            var return_v = new System.Management.Automation.Remoting.WSManPluginEntryDelegates();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1641, 18910, 18941);
            return return_v;
        }

    }
    public sealed class WSManPluginManagedEntryInstanceWrapper : IDisposable
    {
        private bool _disposed;

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1641, 33661, 33772);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 33707, 33721);

                f_1641_33707_33720(this, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 33735, 33761);

                f_1641_33735_33760(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1641, 33661, 33772);

                int
                f_1641_33707_33720(System.Management.Automation.Remoting.WSManPluginManagedEntryInstanceWrapper
                this_param, bool
                disposing)
                {
                    this_param.Dispose(disposing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1641, 33707, 33720);
                    return 0;
                }


                int
                f_1641_33735_33760(System.Management.Automation.Remoting.WSManPluginManagedEntryInstanceWrapper
                obj)
                {
                    GC.SuppressFinalize((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1641, 33735, 33760);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1641, 33661, 33772);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1641, 33661, 33772);
            }
        }

        private void Dispose(bool disposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1641, 33935, 34171);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 33996, 34035) || true) && (_disposed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1641, 33996, 34035);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 34028, 34035);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1641, 33996, 34035);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 34100, 34127);

                _initDelegateHandle.Free();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 34143, 34160);

                _disposed = true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1641, 33935, 34171);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1641, 33935, 34171);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1641, 33935, 34171);
            }
        }

        /// <summary>
        /// Use C# destructor syntax for finalization code.
        /// This destructor will run only if the Dispose method
        /// does not get called.
        /// It gives your base class the opportunity to finalize.
        /// Do not provide destructors in types derived from this class.
        /// </summary>
        ~WSManPluginManagedEntryInstanceWrapper()
        {
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 34597, 34612);

            f_1641_34597_34611(this, false);
        }



        /// <summary>
        /// Matches signature for WSManPluginManagedEntryWrapper.InitPlugin.
        /// </summary>
        /// <param name="wkrPtrs"></param>
        /// <returns></returns>
        private delegate int InitPluginDelegate(
            IntPtr wkrPtrs);

        private GCHandle _initDelegateHandle;

        public IntPtr GetEntryDelegate()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1641, 35429, 35735);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 35486, 35586);

                InitPluginDelegate
                initDelegate = new InitPluginDelegate(WSManPluginManagedEntryWrapper.InitPlugin)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 35600, 35651);

                _initDelegateHandle = GCHandle.Alloc(initDelegate);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 35665, 35724);

                return f_1641_35672_35723(initDelegate);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1641, 35429, 35735);

                System.IntPtr
                f_1641_35672_35723(System.Management.Automation.Remoting.WSManPluginManagedEntryInstanceWrapper.InitPluginDelegate
                d)
                {
                    var return_v = Marshal.GetFunctionPointerForDelegate(d);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1641, 35672, 35723);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1641, 35429, 35735);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1641, 35429, 35735);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public WSManPluginManagedEntryInstanceWrapper()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1641, 33321, 35764);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1641, 33505, 33522);
            this._disposed = false;
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1641, 33321, 35764);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1641, 33321, 35764);
        }


        static WSManPluginManagedEntryInstanceWrapper()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1641, 33321, 35764);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1641, 33321, 35764);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1641, 33321, 35764);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1641, 33321, 35764);

        int
        f_1641_34597_34611(System.Management.Automation.Remoting.WSManPluginManagedEntryInstanceWrapper
        this_param, bool
        disposing)
        {
            this_param.Dispose(disposing);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1641, 34597, 34611);
            return 0;
        }

    }
}
