// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Management.Automation.Internal;
using System.Management.Automation.Remoting;
using System.Management.Automation.Runspaces;
using System.Security.Principal;
using System.Threading;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation
{
    internal class ServerPowerShellDriver
    {
        private bool _extraPowerShellAlreadyScheduled;

        private PowerShell _extraPowerShell;

        private PSDataCollection<PSObject> _localPowerShellOutput;

        private bool[] _datasent;

        private object _syncObject;

        private bool _noInput;

        private bool _addToHistory;

        private ServerRemoteHost _remoteHost;

        private ApartmentState apartmentState;

        private IRSPDriverInvoke _psDriverInvoker;

        internal ServerPowerShellDriver(PowerShell powershell, PowerShell extraPowerShell, bool noInput, Guid clientPowerShellId,
                    Guid clientRunspacePoolId, ServerRunspacePoolDriver runspacePoolDriver,
                    ApartmentState apartmentState, HostInfo hostInfo, RemoteStreamOptions streamOptions,
                    bool addToHistory, Runspace rsToUse)
        : this(f_1648_3738_3748_C(powershell), extraPowerShell, noInput, clientPowerShellId, clientRunspacePoolId, runspacePoolDriver, apartmentState, hostInfo, streamOptions, addToHistory, rsToUse, null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1648, 3363, 3949);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1648, 3363, 3949);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1648, 3363, 3949);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1648, 3363, 3949);
            }
        }

        internal ServerPowerShellDriver(PowerShell powershell, PowerShell extraPowerShell, bool noInput, Guid clientPowerShellId,
                    Guid clientRunspacePoolId, ServerRunspacePoolDriver runspacePoolDriver,
                    ApartmentState apartmentState, HostInfo hostInfo, RemoteStreamOptions streamOptions,
                    bool addToHistory, Runspace rsToUse, PSDataCollection<PSObject> output)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1648, 5518, 8689);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 688, 720);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 827, 843);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 1108, 1130);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 1253, 1276);
                this._datasent = new bool[2];
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 1369, 1395);
                this._syncObject = f_1648_1383_1395();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 1480, 1488);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 1512, 1525);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 1651, 1662);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 1746, 1760);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 1851, 1867);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 8862, 8920);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 9019, 9063);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 9448, 9505);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 10013, 10088);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 5932, 5964);

                InstanceId = clientPowerShellId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 5978, 6016);

                RunspacePoolId = clientRunspacePoolId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 6030, 6066);

                RemoteStreamOptions = streamOptions;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 6080, 6117);

                this.apartmentState = apartmentState;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 6131, 6160);

                LocalPowerShell = powershell;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 6174, 6209);

                _extraPowerShell = extraPowerShell;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 6223, 6281);

                _localPowerShellOutput = f_1648_6248_6280();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 6295, 6314);

                _noInput = noInput;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 6328, 6357);

                _addToHistory = addToHistory;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 6371, 6409);

                _psDriverInvoker = runspacePoolDriver;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 6425, 6605);

                DataStructureHandler = f_1648_6448_6604(f_1648_6448_6487(runspacePoolDriver), clientPowerShellId, clientRunspacePoolId, f_1648_6567_6586(), f_1648_6588_6603());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 6619, 6733);

                _remoteHost = f_1648_6633_6732(f_1648_6633_6653(), hostInfo, f_1648_6696_6731(runspacePoolDriver));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 6749, 7013) || true) && (!noInput)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1648, 6749, 7013);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 6795, 6844);

                    InputCollection = f_1648_6813_6843();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 6862, 6906);

                    f_1648_6862_6877().ReleaseOnEnumeration = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 6924, 6998);

                    f_1648_6924_6939().IdleEvent += new EventHandler<EventArgs>(HandleIdleEvent);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1648, 6749, 7013);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 7029, 7089);

                f_1648_7029_7088(this, _localPowerShellOutput);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 7105, 7269) || true) && (f_1648_7109_7124() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1648, 7105, 7269);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 7166, 7215);

                    f_1648_7166_7214(this, f_1648_7198_7213());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 7233, 7254);

                    _datasent[0] = false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1648, 7105, 7269);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 7285, 7449) || true) && (extraPowerShell != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1648, 7285, 7449);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 7346, 7395);

                    f_1648_7346_7394(this, extraPowerShell);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 7413, 7434);

                    _datasent[1] = false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1648, 7285, 7449);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 7465, 7529);

                f_1648_7465_7528(this, f_1648_7507_7527());

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 7610, 8152) || true) && (rsToUse != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1648, 7610, 8152);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 7663, 7698);

                    f_1648_7663_7678().Runspace = rsToUse;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 7716, 7839) || true) && (extraPowerShell != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1648, 7716, 7839);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 7785, 7820);

                        extraPowerShell.Runspace = rsToUse;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1648, 7716, 7839);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1648, 7610, 8152);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1648, 7610, 8152);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 7905, 7968);

                    f_1648_7905_7920().RunspacePool = f_1648_7936_7967(runspacePoolDriver);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 7986, 8137) || true) && (extraPowerShell != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1648, 7986, 8137);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 8055, 8118);

                        extraPowerShell.RunspacePool = f_1648_8086_8117(runspacePoolDriver);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1648, 7986, 8137);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1648, 7610, 8152);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 8168, 8678) || true) && (output != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1648, 8168, 8678);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 8220, 8663);

                    output.DataAdded += (sender, args) =>
                                        {
                                            if (_localPowerShellOutput.IsOpen)
                                            {
                                                var items = output.ReadAll();
                                                foreach (var item in items)
                                                {
                                                    _localPowerShellOutput.Add(item);
                                                }
                                            }
                                        };
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1648, 8168, 8678);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1648, 5518, 8689);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1648, 5518, 8689);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1648, 5518, 8689);
            }
        }

        internal PSDataCollection<object> InputCollection { get; }

        internal PowerShell LocalPowerShell { get; }

        internal Guid InstanceId { get; }

        internal RemoteStreamOptions RemoteStreamOptions { get; }

        internal Guid RunspacePoolId { get; }

        internal ServerPowerShellDataStructureHandler DataStructureHandler { get; }

        private PSInvocationSettings PrepInvoke(bool startMainPowerShell)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1648, 10100, 11556);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 10190, 10371) || true) && (startMainPowerShell)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1648, 10190, 10371);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 10325, 10356);

                    f_1648_10325_10355(f_1648_10325_10345());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1648, 10190, 10371);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 10387, 10446);

                PSInvocationSettings
                settings = f_1648_10419_10445()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 10460, 10501);

                settings.ApartmentState = apartmentState;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 10515, 10543);

                settings.Host = _remoteHost;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 10755, 11461) || true) && (f_1648_10759_10777())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1648, 10755, 11461);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 10811, 10880);

                    WindowsIdentity
                    currentThreadIdentity = f_1648_10851_10879()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 10898, 11339);

                    switch (f_1648_10906_10946(currentThreadIdentity))
                    {

                        case TokenImpersonationLevel.Impersonation:
                        case TokenImpersonationLevel.Delegation:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1648, 10898, 11339);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 11119, 11159);

                            settings.FlowImpersonationPolicy = true;
                            DynAbs.Tracing.TraceSender.TraceBreak(1648, 11185, 11191);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1648, 10898, 11339);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1648, 10898, 11339);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 11247, 11288);

                            settings.FlowImpersonationPolicy = false;
                            DynAbs.Tracing.TraceSender.TraceBreak(1648, 11314, 11320);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1648, 10898, 11339);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1648, 10755, 11461);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1648, 10755, 11461);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 11405, 11446);

                    settings.FlowImpersonationPolicy = false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1648, 10755, 11461);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 11477, 11515);

                settings.AddToHistory = _addToHistory;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 11529, 11545);

                return settings;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1648, 10100, 11556);

                System.Management.Automation.ServerPowerShellDataStructureHandler
                f_1648_10325_10345()
                {
                    var return_v = DataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 10325, 10345);
                    return return_v;
                }


                int
                f_1648_10325_10355(System.Management.Automation.ServerPowerShellDataStructureHandler
                this_param)
                {
                    this_param.Prepare();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 10325, 10355);
                    return 0;
                }


                System.Management.Automation.PSInvocationSettings
                f_1648_10419_10445()
                {
                    var return_v = new System.Management.Automation.PSInvocationSettings();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 10419, 10445);
                    return return_v;
                }


                bool
                f_1648_10759_10777()
                {
                    var return_v = Platform.IsWindows;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 10759, 10777);
                    return return_v;
                }


                System.Security.Principal.WindowsIdentity
                f_1648_10851_10879()
                {
                    var return_v = WindowsIdentity.GetCurrent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 10851, 10879);
                    return return_v;
                }


                System.Security.Principal.TokenImpersonationLevel
                f_1648_10906_10946(System.Security.Principal.WindowsIdentity
                this_param)
                {
                    var return_v = this_param.ImpersonationLevel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 10906, 10946);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1648, 10100, 11556);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1648, 10100, 11556);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private IAsyncResult Start(bool startMainPowerShell)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1648, 11568, 12107);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 11645, 11709);

                PSInvocationSettings
                settings = f_1648_11677_11708(this, startMainPowerShell)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 11725, 12096) || true) && (startMainPowerShell)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1648, 11725, 12096);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 11782, 11898);

                    return f_1648_11789_11897(f_1648_11789_11804(), f_1648_11835_11850(), _localPowerShellOutput, settings, null, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1648, 11725, 12096);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1648, 11725, 12096);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 11964, 12081);

                    return f_1648_11971_12080(_extraPowerShell, f_1648_12018_12033(), _localPowerShellOutput, settings, null, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1648, 11725, 12096);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1648, 11568, 12107);

                System.Management.Automation.PSInvocationSettings
                f_1648_11677_11708(System.Management.Automation.ServerPowerShellDriver
                this_param, bool
                startMainPowerShell)
                {
                    var return_v = this_param.PrepInvoke(startMainPowerShell);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 11677, 11708);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1648_11789_11804()
                {
                    var return_v = LocalPowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 11789, 11804);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<object>
                f_1648_11835_11850()
                {
                    var return_v = InputCollection;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 11835, 11850);
                    return return_v;
                }


                System.IAsyncResult
                f_1648_11789_11897(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.PSDataCollection<object>
                input, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                output, System.Management.Automation.PSInvocationSettings
                settings, System.AsyncCallback
                callback, object
                state)
                {
                    var return_v = this_param.BeginInvoke<object, System.Management.Automation.PSObject>(input, output, settings, callback, state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 11789, 11897);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<object>
                f_1648_12018_12033()
                {
                    var return_v = InputCollection;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 12018, 12033);
                    return return_v;
                }


                System.IAsyncResult
                f_1648_11971_12080(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.PSDataCollection<object>
                input, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                output, System.Management.Automation.PSInvocationSettings
                settings, System.AsyncCallback
                callback, object
                state)
                {
                    var return_v = this_param.BeginInvoke<object, System.Management.Automation.PSObject>(input, output, settings, callback, state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 11971, 12080);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1648, 11568, 12107);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1648, 11568, 12107);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal IAsyncResult Start()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1648, 12218, 12302);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 12272, 12291);

                return f_1648_12279_12290(this, true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1648, 12218, 12302);

                System.IAsyncResult
                f_1648_12279_12290(System.Management.Automation.ServerPowerShellDriver
                this_param, bool
                startMainPowerShell)
                {
                    var return_v = this_param.Start(startMainPowerShell);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 12279, 12290);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1648, 12218, 12302);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1648, 12218, 12302);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void RunNoOpCommand(IReadOnlyCollection<object> output)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1648, 12732, 13769);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 12821, 13758) || true) && (f_1648_12825_12840() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1648, 12821, 13758);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 12882, 13743);

                    f_1648_12882_13742((state) =>
                                            {
                                                LocalPowerShell.SetStateChanged(
                                                    new PSInvocationStateInfo(
                                                        PSInvocationState.Running, null));

                                                foreach (var item in output)
                                                {
                                                    if (item != null)
                                                    {
                                                        _localPowerShellOutput.Add(PSObject.AsPSObject(item));
                                                    }
                                                }

                                                LocalPowerShell.SetStateChanged(
                                                    new PSInvocationStateInfo(
                                                        PSInvocationState.Completed, null));
                                            });
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1648, 12821, 13758);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1648, 12732, 13769);

                System.Management.Automation.PowerShell
                f_1648_12825_12840()
                {
                    var return_v = LocalPowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 12825, 12840);
                    return return_v;
                }


                bool
                f_1648_12882_13742(System.Threading.WaitCallback
                callBack)
                {
                    var return_v = System.Threading.ThreadPool.QueueUserWorkItem(callBack);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 12882, 13742);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1648, 12732, 13769);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1648, 12732, 13769);
            }
        }

        internal void InvokeMain()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1648, 13891, 15116);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 13942, 13991);

                PSInvocationSettings
                settings = f_1648_13974_13990(this, true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 14007, 14027);

                Exception
                ex = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 14077, 14169);

                    f_1648_14077_14168(f_1648_14077_14092(), f_1648_14112_14127(), _localPowerShellOutput, settings, true);
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1648, 14198, 14272);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 14250, 14257);

                    ex = e;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1648, 14198, 14272);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 14288, 15105) || true) && (ex != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1648, 14288, 15105);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 14613, 14685);

                    string
                    failedCommand = f_1648_14636_14684(f_1648_14636_14672(f_1648_14636_14669(f_1648_14636_14660(f_1648_14636_14651())), 0))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 14703, 14736);

                    f_1648_14703_14735(f_1648_14703_14727(f_1648_14703_14718()));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 14754, 14968);

                    string
                    msg = f_1648_14767_14967(f_1648_14807_14865(), failedCommand ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1648, 14888, 14917) ?? string.Empty), f_1648_14940_14950(ex) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1648, 14940, 14966) ?? string.Empty))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 14988, 15047);

                    f_1648_14988_15046(f_1648_14988_15029(f_1648_14988_15003(), "Write-Error"), msg);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 15065, 15090);

                    f_1648_15065_15089(f_1648_15065_15080());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1648, 14288, 15105);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1648, 13891, 15116);

                System.Management.Automation.PSInvocationSettings
                f_1648_13974_13990(System.Management.Automation.ServerPowerShellDriver
                this_param, bool
                startMainPowerShell)
                {
                    var return_v = this_param.PrepInvoke(startMainPowerShell);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 13974, 13990);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1648_14077_14092()
                {
                    var return_v = LocalPowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 14077, 14092);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<object>
                f_1648_14112_14127()
                {
                    var return_v = InputCollection;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 14112, 14127);
                    return return_v;
                }


                int
                f_1648_14077_14168(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.PSDataCollection<object>
                input, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                output, System.Management.Automation.PSInvocationSettings
                settings, bool
                invokeMustRun)
                {
                    this_param.InvokeWithDebugger((System.Collections.Generic.IEnumerable<object>)input, (System.Collections.Generic.IList<System.Management.Automation.PSObject>)output, settings, invokeMustRun);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 14077, 14168);
                    return 0;
                }


                System.Management.Automation.PowerShell
                f_1648_14636_14651()
                {
                    var return_v = LocalPowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 14636, 14651);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1648_14636_14660(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 14636, 14660);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandCollection
                f_1648_14636_14669(System.Management.Automation.PSCommand
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 14636, 14669);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Command
                f_1648_14636_14672(System.Management.Automation.Runspaces.CommandCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 14636, 14672);
                    return return_v;
                }


                string
                f_1648_14636_14684(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.CommandText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 14636, 14684);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1648_14703_14718()
                {
                    var return_v = LocalPowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 14703, 14718);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1648_14703_14727(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 14703, 14727);
                    return return_v;
                }


                int
                f_1648_14703_14735(System.Management.Automation.PSCommand
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 14703, 14735);
                    return 0;
                }


                string
                f_1648_14807_14865()
                {
                    var return_v = RemotingErrorIdStrings.ServerSideNestedCommandInvokeFailed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 14807, 14865);
                    return return_v;
                }


                string
                f_1648_14940_14950(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 14940, 14950);
                    return return_v;
                }


                string
                f_1648_14767_14967(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 14767, 14967);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1648_14988_15003()
                {
                    var return_v = LocalPowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 14988, 15003);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1648_14988_15029(System.Management.Automation.PowerShell
                this_param, string
                cmdlet)
                {
                    var return_v = this_param.AddCommand(cmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 14988, 15029);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1648_14988_15046(System.Management.Automation.PowerShell
                this_param, string
                value)
                {
                    var return_v = this_param.AddArgument((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 14988, 15046);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1648_15065_15080()
                {
                    var return_v = LocalPowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 15065, 15080);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1648_15065_15089(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Invoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 15065, 15089);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1648, 13891, 15116);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1648, 13891, 15116);
            }
        }

        private void RegisterPowerShellEventHandlers(PowerShell powerShell)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1648, 15202, 15827);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 15294, 15370);

                powerShell.InvocationStateChanged += HandlePowerShellInvocationStateChanged;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 15386, 15445);

                f_1648_15386_15410(f_1648_15386_15404(powerShell)).DataAdded += HandleErrorDataAdded;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 15459, 15514);

                f_1648_15459_15483(f_1648_15459_15477(powerShell)).DataAdded += HandleDebugAdded;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 15528, 15587);

                f_1648_15528_15554(f_1648_15528_15546(powerShell)).DataAdded += HandleVerboseAdded;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 15601, 15660);

                f_1648_15601_15627(f_1648_15601_15619(powerShell)).DataAdded += HandleWarningAdded;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 15674, 15735);

                f_1648_15674_15701(f_1648_15674_15692(powerShell)).DataAdded += HandleProgressAdded;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 15749, 15816);

                f_1648_15749_15779(f_1648_15749_15767(powerShell)).DataAdded += HandleInformationAdded;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1648, 15202, 15827);

                System.Management.Automation.PSDataStreams
                f_1648_15386_15404(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 15386, 15404);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                f_1648_15386_15410(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Error;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 15386, 15410);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1648_15459_15477(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 15459, 15477);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.DebugRecord>
                f_1648_15459_15483(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Debug;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 15459, 15483);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1648_15528_15546(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 15528, 15546);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.VerboseRecord>
                f_1648_15528_15554(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Verbose;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 15528, 15554);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1648_15601_15619(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 15601, 15619);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.WarningRecord>
                f_1648_15601_15627(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Warning;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 15601, 15627);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1648_15674_15692(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 15674, 15692);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ProgressRecord>
                f_1648_15674_15701(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Progress;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 15674, 15701);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1648_15749_15767(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 15749, 15767);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.InformationRecord>
                f_1648_15749_15779(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Information;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 15749, 15779);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1648, 15202, 15827);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1648, 15202, 15827);
            }
        }

        private void UnregisterPowerShellEventHandlers(PowerShell powerShell)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1648, 15839, 16466);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 15933, 16009);

                powerShell.InvocationStateChanged -= HandlePowerShellInvocationStateChanged;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 16025, 16084);

                f_1648_16025_16049(f_1648_16025_16043(powerShell)).DataAdded -= HandleErrorDataAdded;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 16098, 16153);

                f_1648_16098_16122(f_1648_16098_16116(powerShell)).DataAdded -= HandleDebugAdded;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 16167, 16226);

                f_1648_16167_16193(f_1648_16167_16185(powerShell)).DataAdded -= HandleVerboseAdded;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 16240, 16299);

                f_1648_16240_16266(f_1648_16240_16258(powerShell)).DataAdded -= HandleWarningAdded;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 16313, 16374);

                f_1648_16313_16340(f_1648_16313_16331(powerShell)).DataAdded -= HandleProgressAdded;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 16388, 16455);

                f_1648_16388_16418(f_1648_16388_16406(powerShell)).DataAdded -= HandleInformationAdded;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1648, 15839, 16466);

                System.Management.Automation.PSDataStreams
                f_1648_16025_16043(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 16025, 16043);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                f_1648_16025_16049(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Error;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 16025, 16049);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1648_16098_16116(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 16098, 16116);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.DebugRecord>
                f_1648_16098_16122(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Debug;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 16098, 16122);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1648_16167_16185(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 16167, 16185);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.VerboseRecord>
                f_1648_16167_16193(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Verbose;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 16167, 16193);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1648_16240_16258(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 16240, 16258);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.WarningRecord>
                f_1648_16240_16266(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Warning;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 16240, 16266);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1648_16313_16331(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 16313, 16331);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ProgressRecord>
                f_1648_16313_16340(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Progress;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 16313, 16340);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1648_16388_16406(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 16388, 16406);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.InformationRecord>
                f_1648_16388_16418(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Information;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 16388, 16418);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1648, 15839, 16466);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1648, 15839, 16466);
            }
        }

        private void RegisterDataStructureHandlerEventHandlers(ServerPowerShellDataStructureHandler dsHandler)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1648, 16478, 16943);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 16605, 16658);

                dsHandler.InputEndReceived += HandleInputEndReceived;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 16672, 16719);

                dsHandler.InputReceived += HandleInputReceived;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 16733, 16788);

                dsHandler.StopPowerShellReceived += HandleStopReceived;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 16802, 16863);

                dsHandler.HostResponseReceived += HandleHostResponseReceived;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 16877, 16932);

                dsHandler.OnSessionConnected += HandleSessionConnected;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1648, 16478, 16943);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1648, 16478, 16943);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1648, 16478, 16943);
            }
        }

        private void UnregisterDataStructureHandlerEventHandlers(ServerPowerShellDataStructureHandler dsHandler)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1648, 16955, 17422);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 17084, 17137);

                dsHandler.InputEndReceived -= HandleInputEndReceived;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 17151, 17198);

                dsHandler.InputReceived -= HandleInputReceived;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 17212, 17267);

                dsHandler.StopPowerShellReceived -= HandleStopReceived;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 17281, 17342);

                dsHandler.HostResponseReceived -= HandleHostResponseReceived;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 17356, 17411);

                dsHandler.OnSessionConnected -= HandleSessionConnected;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1648, 16955, 17422);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1648, 16955, 17422);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1648, 16955, 17422);
            }
        }

        private void RegisterPipelineOutputEventHandlers(PSDataCollection<PSObject> pipelineOutput)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1648, 17434, 17611);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 17550, 17600);

                pipelineOutput.DataAdded += HandleOutputDataAdded;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1648, 17434, 17611);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1648, 17434, 17611);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1648, 17434, 17611);
            }
        }

        private void UnregisterPipelineOutputEventHandlers(PSDataCollection<PSObject> pipelineOutput)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1648, 17623, 17802);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 17741, 17791);

                pipelineOutput.DataAdded -= HandleOutputDataAdded;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1648, 17623, 17802);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1648, 17623, 17802);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1648, 17623, 17802);
            }
        }

        private void HandlePowerShellInvocationStateChanged(object sender,
                    PSInvocationStateChangedEventArgs eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1648, 18152, 21615);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 18301, 18363);

                PSInvocationState
                state = f_1648_18327_18362(f_1648_18327_18356(eventArgs))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 18377, 21604);

                switch (state)
                {

                    case PSInvocationState.Completed:
                    case PSInvocationState.Failed:
                    case PSInvocationState.Stopped:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1648, 18377, 21604);
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 18603, 19042) || true) && (f_1648_18607_18643(f_1648_18607_18622()))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1648, 18603, 19042);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 18793, 18846) || true) && (state == PSInvocationState.Completed)
                                )
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1648, 18793, 18846);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 18837, 18844);

                                    return;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1648, 18793, 18846);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1648, 18603, 19042);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 19665, 19685);

                            f_1648_19665_19684(this);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 19713, 21276) || true) && (state == PSInvocationState.Completed && (DynAbs.Tracing.TraceSender.Expression_True(1648, 19717, 19812) && (_extraPowerShell != null)) && (DynAbs.Tracing.TraceSender.Expression_True(1648, 19717, 19878) && !_extraPowerShellAlreadyScheduled))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1648, 19713, 21276);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 19936, 19976);

                                _extraPowerShellAlreadyScheduled = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 20006, 20019);

                                f_1648_20006_20018(this, false);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1648, 19713, 21276);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1648, 19713, 21276);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 20133, 20184);

                                f_1648_20133_20183(f_1648_20133_20153());
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 20297, 20419);

                                f_1648_20297_20418(f_1648_20297_20317(), f_1648_20388_20417(eventArgs));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 20451, 20502);

                                f_1648_20451_20501(this, f_1648_20485_20500());

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 20532, 20709) || true) && (_extraPowerShell != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1648, 20532, 20709);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 20626, 20678);

                                    f_1648_20626_20677(this, _extraPowerShell);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1648, 20532, 20709);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 20741, 20807);

                                f_1648_20741_20806(this, f_1648_20785_20805());
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 20837, 20899);

                                f_1648_20837_20898(this, _localPowerShellOutput);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1648, 19713, 21276);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1648, 21323, 21329);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1648, 18377, 21604);

                    case PSInvocationState.Stopping:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1648, 18377, 21604);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 21487, 21536);

                            f_1648_21487_21535(f_1648_21487_21519(_remoteHost));
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1648, 21583, 21589);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1648, 18377, 21604);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1648, 18152, 21615);

                System.Management.Automation.PSInvocationStateInfo
                f_1648_18327_18356(System.Management.Automation.PSInvocationStateChangedEventArgs
                this_param)
                {
                    var return_v = this_param.InvocationStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 18327, 18356);
                    return return_v;
                }


                System.Management.Automation.PSInvocationState
                f_1648_18327_18362(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 18327, 18362);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1648_18607_18622()
                {
                    var return_v = LocalPowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 18607, 18622);
                    return return_v;
                }


                bool
                f_1648_18607_18643(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.RunningExtraCommands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 18607, 18643);
                    return return_v;
                }


                int
                f_1648_19665_19684(System.Management.Automation.ServerPowerShellDriver
                this_param)
                {
                    this_param.SendRemainingData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 19665, 19684);
                    return 0;
                }


                System.IAsyncResult
                f_1648_20006_20018(System.Management.Automation.ServerPowerShellDriver
                this_param, bool
                startMainPowerShell)
                {
                    var return_v = this_param.Start(startMainPowerShell);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 20006, 20018);
                    return return_v;
                }


                System.Management.Automation.ServerPowerShellDataStructureHandler
                f_1648_20133_20153()
                {
                    var return_v = DataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 20133, 20153);
                    return return_v;
                }


                int
                f_1648_20133_20183(System.Management.Automation.ServerPowerShellDataStructureHandler
                this_param)
                {
                    this_param.RaiseRemoveAssociationEvent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 20133, 20183);
                    return 0;
                }


                System.Management.Automation.ServerPowerShellDataStructureHandler
                f_1648_20297_20317()
                {
                    var return_v = DataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 20297, 20317);
                    return return_v;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1648_20388_20417(System.Management.Automation.PSInvocationStateChangedEventArgs
                this_param)
                {
                    var return_v = this_param.InvocationStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 20388, 20417);
                    return return_v;
                }


                int
                f_1648_20297_20418(System.Management.Automation.ServerPowerShellDataStructureHandler
                this_param, System.Management.Automation.PSInvocationStateInfo
                stateInfo)
                {
                    this_param.SendStateChangedInformationToClient(stateInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 20297, 20418);
                    return 0;
                }


                System.Management.Automation.PowerShell
                f_1648_20485_20500()
                {
                    var return_v = LocalPowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 20485, 20500);
                    return return_v;
                }


                int
                f_1648_20451_20501(System.Management.Automation.ServerPowerShellDriver
                this_param, System.Management.Automation.PowerShell
                powerShell)
                {
                    this_param.UnregisterPowerShellEventHandlers(powerShell);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 20451, 20501);
                    return 0;
                }


                int
                f_1648_20626_20677(System.Management.Automation.ServerPowerShellDriver
                this_param, System.Management.Automation.PowerShell
                powerShell)
                {
                    this_param.UnregisterPowerShellEventHandlers(powerShell);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 20626, 20677);
                    return 0;
                }


                System.Management.Automation.ServerPowerShellDataStructureHandler
                f_1648_20785_20805()
                {
                    var return_v = DataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 20785, 20805);
                    return return_v;
                }


                int
                f_1648_20741_20806(System.Management.Automation.ServerPowerShellDriver
                this_param, System.Management.Automation.ServerPowerShellDataStructureHandler
                dsHandler)
                {
                    this_param.UnregisterDataStructureHandlerEventHandlers(dsHandler);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 20741, 20806);
                    return 0;
                }


                int
                f_1648_20837_20898(System.Management.Automation.ServerPowerShellDriver
                this_param, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                pipelineOutput)
                {
                    this_param.UnregisterPipelineOutputEventHandlers(pipelineOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 20837, 20898);
                    return 0;
                }


                System.Management.Automation.Remoting.ServerMethodExecutor
                f_1648_21487_21519(System.Management.Automation.Remoting.ServerRemoteHost
                this_param)
                {
                    var return_v = this_param.ServerMethodExecutor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 21487, 21519);
                    return return_v;
                }


                int
                f_1648_21487_21535(System.Management.Automation.Remoting.ServerMethodExecutor
                this_param)
                {
                    this_param.AbortAllCalls();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 21487, 21535);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1648, 18152, 21615);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1648, 18152, 21615);
            }
        }

        private void HandleOutputDataAdded(object sender, DataAddedEventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1648, 21886, 22660);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 21982, 22002);

                int
                index = f_1648_21994_22001(e)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 22024, 22035);

                lock (_syncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 22069, 22137);

                    int
                    indexIntoDataSent = (DynAbs.Tracing.TraceSender.Conditional_F1(1648, 22093, 22128) || (((!_extraPowerShellAlreadyScheduled) && DynAbs.Tracing.TraceSender.Conditional_F2(1648, 22131, 22132)) || DynAbs.Tracing.TraceSender.Conditional_F3(1648, 22135, 22136))) ? 0 : 1
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 22155, 22634) || true) && (!_datasent[indexIntoDataSent])
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1648, 22155, 22634);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 22230, 22276);

                        PSObject
                        data = f_1648_22246_22275(_localPowerShellOutput, index)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 22443, 22482);

                        f_1648_22443_22481(                    // once send the output is removed so that the same
                                                               // is not sent again by SendRemainingData() method
                                            _localPowerShellOutput, index);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 22565, 22615);

                        f_1648_22565_22614(f_1648_22565_22585(), data);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1648, 22155, 22634);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1648, 21886, 22660);

                int
                f_1648_21994_22001(System.Management.Automation.DataAddedEventArgs
                this_param)
                {
                    var return_v = this_param.Index;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 21994, 22001);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1648_22246_22275(System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 22246, 22275);
                    return return_v;
                }


                int
                f_1648_22443_22481(System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                this_param, int
                index)
                {
                    this_param.RemoveAt(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 22443, 22481);
                    return 0;
                }


                System.Management.Automation.ServerPowerShellDataStructureHandler
                f_1648_22565_22585()
                {
                    var return_v = DataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 22565, 22585);
                    return return_v;
                }


                int
                f_1648_22565_22614(System.Management.Automation.ServerPowerShellDataStructureHandler
                this_param, System.Management.Automation.PSObject
                data)
                {
                    this_param.SendOutputDataToClient(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 22565, 22614);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1648, 21886, 22660);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1648, 21886, 22660);
            }
        }

        private void HandleErrorDataAdded(object sender, DataAddedEventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1648, 22920, 23762);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 23015, 23035);

                int
                index = f_1648_23027_23034(e)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 23057, 23068);

                lock (_syncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 23102, 23170);

                    int
                    indexIntoDataSent = (DynAbs.Tracing.TraceSender.Conditional_F1(1648, 23126, 23161) || (((!_extraPowerShellAlreadyScheduled) && DynAbs.Tracing.TraceSender.Conditional_F2(1648, 23164, 23165)) || DynAbs.Tracing.TraceSender.Conditional_F3(1648, 23168, 23169))) ? 0 : 1
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 23188, 23736) || true) && ((indexIntoDataSent == 0) && (DynAbs.Tracing.TraceSender.Expression_True(1648, 23192, 23251) && (!_datasent[indexIntoDataSent])))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1648, 23188, 23736);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 23293, 23356);

                        ErrorRecord
                        errorRecord = f_1648_23319_23355(f_1648_23319_23348(f_1648_23319_23342(f_1648_23319_23334())), index)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 23529, 23575);

                        f_1648_23529_23574(f_1648_23529_23558(f_1648_23529_23552(f_1648_23529_23544())), index);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 23659, 23717);

                        f_1648_23659_23716(f_1648_23659_23679(), errorRecord);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1648, 23188, 23736);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1648, 22920, 23762);

                int
                f_1648_23027_23034(System.Management.Automation.DataAddedEventArgs
                this_param)
                {
                    var return_v = this_param.Index;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 23027, 23034);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1648_23319_23334()
                {
                    var return_v = LocalPowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 23319, 23334);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1648_23319_23342(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 23319, 23342);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                f_1648_23319_23348(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Error;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 23319, 23348);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1648_23319_23355(System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 23319, 23355);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1648_23529_23544()
                {
                    var return_v = LocalPowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 23529, 23544);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1648_23529_23552(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 23529, 23552);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                f_1648_23529_23558(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Error;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 23529, 23558);
                    return return_v;
                }


                int
                f_1648_23529_23574(System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                this_param, int
                index)
                {
                    this_param.RemoveAt(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 23529, 23574);
                    return 0;
                }


                System.Management.Automation.ServerPowerShellDataStructureHandler
                f_1648_23659_23679()
                {
                    var return_v = DataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 23659, 23679);
                    return return_v;
                }


                int
                f_1648_23659_23716(System.Management.Automation.ServerPowerShellDataStructureHandler
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.SendErrorRecordToClient(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 23659, 23716);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1648, 22920, 23762);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1648, 22920, 23762);
            }
        }

        private void HandleProgressAdded(object sender, DataAddedEventArgs eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1648, 24043, 24905);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 24145, 24173);

                int
                index = f_1648_24157_24172(eventArgs)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 24195, 24206);

                lock (_syncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 24240, 24308);

                    int
                    indexIntoDataSent = (DynAbs.Tracing.TraceSender.Conditional_F1(1648, 24264, 24299) || (((!_extraPowerShellAlreadyScheduled) && DynAbs.Tracing.TraceSender.Conditional_F2(1648, 24302, 24303)) || DynAbs.Tracing.TraceSender.Conditional_F3(1648, 24306, 24307))) ? 0 : 1
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 24326, 24879) || true) && ((indexIntoDataSent == 0) && (DynAbs.Tracing.TraceSender.Expression_True(1648, 24330, 24389) && (!_datasent[indexIntoDataSent])))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1648, 24326, 24879);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 24431, 24493);

                        ProgressRecord
                        data = f_1648_24453_24492(f_1648_24453_24485(f_1648_24453_24476(f_1648_24453_24468())), index)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 24674, 24723);

                        f_1648_24674_24722(f_1648_24674_24706(f_1648_24674_24697(f_1648_24674_24689())), index);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 24806, 24860);

                        f_1648_24806_24859(f_1648_24806_24826(), data);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1648, 24326, 24879);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1648, 24043, 24905);

                int
                f_1648_24157_24172(System.Management.Automation.DataAddedEventArgs
                this_param)
                {
                    var return_v = this_param.Index;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 24157, 24172);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1648_24453_24468()
                {
                    var return_v = LocalPowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 24453, 24468);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1648_24453_24476(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 24453, 24476);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ProgressRecord>
                f_1648_24453_24485(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Progress;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 24453, 24485);
                    return return_v;
                }


                System.Management.Automation.ProgressRecord
                f_1648_24453_24492(System.Management.Automation.PSDataCollection<System.Management.Automation.ProgressRecord>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 24453, 24492);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1648_24674_24689()
                {
                    var return_v = LocalPowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 24674, 24689);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1648_24674_24697(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 24674, 24697);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ProgressRecord>
                f_1648_24674_24706(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Progress;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 24674, 24706);
                    return return_v;
                }


                int
                f_1648_24674_24722(System.Management.Automation.PSDataCollection<System.Management.Automation.ProgressRecord>
                this_param, int
                index)
                {
                    this_param.RemoveAt(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 24674, 24722);
                    return 0;
                }


                System.Management.Automation.ServerPowerShellDataStructureHandler
                f_1648_24806_24826()
                {
                    var return_v = DataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 24806, 24826);
                    return return_v;
                }


                int
                f_1648_24806_24859(System.Management.Automation.ServerPowerShellDataStructureHandler
                this_param, System.Management.Automation.ProgressRecord
                record)
                {
                    this_param.SendProgressRecordToClient(record);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 24806, 24859);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1648, 24043, 24905);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1648, 24043, 24905);
            }
        }

        private void HandleWarningAdded(object sender, DataAddedEventArgs eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1648, 25185, 26042);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 25286, 25314);

                int
                index = f_1648_25298_25313(eventArgs)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 25336, 25347);

                lock (_syncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 25381, 25449);

                    int
                    indexIntoDataSent = (DynAbs.Tracing.TraceSender.Conditional_F1(1648, 25405, 25440) || (((!_extraPowerShellAlreadyScheduled) && DynAbs.Tracing.TraceSender.Conditional_F2(1648, 25443, 25444)) || DynAbs.Tracing.TraceSender.Conditional_F3(1648, 25447, 25448))) ? 0 : 1
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 25467, 26016) || true) && ((indexIntoDataSent == 0) && (DynAbs.Tracing.TraceSender.Expression_True(1648, 25471, 25530) && (!_datasent[indexIntoDataSent])))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1648, 25467, 26016);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 25572, 25632);

                        WarningRecord
                        data = f_1648_25593_25631(f_1648_25593_25624(f_1648_25593_25616(f_1648_25593_25608())), index)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 25813, 25861);

                        f_1648_25813_25860(f_1648_25813_25844(f_1648_25813_25836(f_1648_25813_25828())), index);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 25944, 25997);

                        f_1648_25944_25996(f_1648_25944_25964(), data);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1648, 25467, 26016);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1648, 25185, 26042);

                int
                f_1648_25298_25313(System.Management.Automation.DataAddedEventArgs
                this_param)
                {
                    var return_v = this_param.Index;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 25298, 25313);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1648_25593_25608()
                {
                    var return_v = LocalPowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 25593, 25608);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1648_25593_25616(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 25593, 25616);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.WarningRecord>
                f_1648_25593_25624(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Warning;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 25593, 25624);
                    return return_v;
                }


                System.Management.Automation.WarningRecord
                f_1648_25593_25631(System.Management.Automation.PSDataCollection<System.Management.Automation.WarningRecord>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 25593, 25631);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1648_25813_25828()
                {
                    var return_v = LocalPowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 25813, 25828);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1648_25813_25836(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 25813, 25836);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.WarningRecord>
                f_1648_25813_25844(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Warning;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 25813, 25844);
                    return return_v;
                }


                int
                f_1648_25813_25860(System.Management.Automation.PSDataCollection<System.Management.Automation.WarningRecord>
                this_param, int
                index)
                {
                    this_param.RemoveAt(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 25813, 25860);
                    return 0;
                }


                System.Management.Automation.ServerPowerShellDataStructureHandler
                f_1648_25944_25964()
                {
                    var return_v = DataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 25944, 25964);
                    return return_v;
                }


                int
                f_1648_25944_25996(System.Management.Automation.ServerPowerShellDataStructureHandler
                this_param, System.Management.Automation.WarningRecord
                record)
                {
                    this_param.SendWarningRecordToClient(record);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 25944, 25996);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1648, 25185, 26042);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1648, 25185, 26042);
            }
        }

        private void HandleVerboseAdded(object sender, DataAddedEventArgs eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1648, 26311, 27168);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 26412, 26440);

                int
                index = f_1648_26424_26439(eventArgs)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 26462, 26473);

                lock (_syncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 26507, 26575);

                    int
                    indexIntoDataSent = (DynAbs.Tracing.TraceSender.Conditional_F1(1648, 26531, 26566) || (((!_extraPowerShellAlreadyScheduled) && DynAbs.Tracing.TraceSender.Conditional_F2(1648, 26569, 26570)) || DynAbs.Tracing.TraceSender.Conditional_F3(1648, 26573, 26574))) ? 0 : 1
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 26593, 27142) || true) && ((indexIntoDataSent == 0) && (DynAbs.Tracing.TraceSender.Expression_True(1648, 26597, 26656) && (!_datasent[indexIntoDataSent])))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1648, 26593, 27142);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 26698, 26758);

                        VerboseRecord
                        data = f_1648_26719_26757(f_1648_26719_26750(f_1648_26719_26742(f_1648_26719_26734())), index)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 26939, 26987);

                        f_1648_26939_26986(f_1648_26939_26970(f_1648_26939_26962(f_1648_26939_26954())), index);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 27070, 27123);

                        f_1648_27070_27122(f_1648_27070_27090(), data);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1648, 26593, 27142);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1648, 26311, 27168);

                int
                f_1648_26424_26439(System.Management.Automation.DataAddedEventArgs
                this_param)
                {
                    var return_v = this_param.Index;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 26424, 26439);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1648_26719_26734()
                {
                    var return_v = LocalPowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 26719, 26734);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1648_26719_26742(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 26719, 26742);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.VerboseRecord>
                f_1648_26719_26750(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Verbose;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 26719, 26750);
                    return return_v;
                }


                System.Management.Automation.VerboseRecord
                f_1648_26719_26757(System.Management.Automation.PSDataCollection<System.Management.Automation.VerboseRecord>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 26719, 26757);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1648_26939_26954()
                {
                    var return_v = LocalPowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 26939, 26954);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1648_26939_26962(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 26939, 26962);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.VerboseRecord>
                f_1648_26939_26970(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Verbose;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 26939, 26970);
                    return return_v;
                }


                int
                f_1648_26939_26986(System.Management.Automation.PSDataCollection<System.Management.Automation.VerboseRecord>
                this_param, int
                index)
                {
                    this_param.RemoveAt(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 26939, 26986);
                    return 0;
                }


                System.Management.Automation.ServerPowerShellDataStructureHandler
                f_1648_27070_27090()
                {
                    var return_v = DataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 27070, 27090);
                    return return_v;
                }


                int
                f_1648_27070_27122(System.Management.Automation.ServerPowerShellDataStructureHandler
                this_param, System.Management.Automation.VerboseRecord
                record)
                {
                    this_param.SendVerboseRecordToClient(record);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 27070, 27122);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1648, 26311, 27168);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1648, 26311, 27168);
            }
        }

        private void HandleDebugAdded(object sender, DataAddedEventArgs eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1648, 27435, 28282);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 27534, 27562);

                int
                index = f_1648_27546_27561(eventArgs)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 27584, 27595);

                lock (_syncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 27629, 27697);

                    int
                    indexIntoDataSent = (DynAbs.Tracing.TraceSender.Conditional_F1(1648, 27653, 27688) || (((!_extraPowerShellAlreadyScheduled) && DynAbs.Tracing.TraceSender.Conditional_F2(1648, 27691, 27692)) || DynAbs.Tracing.TraceSender.Conditional_F3(1648, 27695, 27696))) ? 0 : 1
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 27715, 28256) || true) && ((indexIntoDataSent == 0) && (DynAbs.Tracing.TraceSender.Expression_True(1648, 27719, 27778) && (!_datasent[indexIntoDataSent])))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1648, 27715, 28256);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 27820, 27876);

                        DebugRecord
                        data = f_1648_27839_27875(f_1648_27839_27868(f_1648_27839_27862(f_1648_27839_27854())), index)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 28057, 28103);

                        f_1648_28057_28102(f_1648_28057_28086(f_1648_28057_28080(f_1648_28057_28072())), index);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 28186, 28237);

                        f_1648_28186_28236(f_1648_28186_28206(), data);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1648, 27715, 28256);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1648, 27435, 28282);

                int
                f_1648_27546_27561(System.Management.Automation.DataAddedEventArgs
                this_param)
                {
                    var return_v = this_param.Index;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 27546, 27561);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1648_27839_27854()
                {
                    var return_v = LocalPowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 27839, 27854);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1648_27839_27862(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 27839, 27862);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.DebugRecord>
                f_1648_27839_27868(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Debug;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 27839, 27868);
                    return return_v;
                }


                System.Management.Automation.DebugRecord
                f_1648_27839_27875(System.Management.Automation.PSDataCollection<System.Management.Automation.DebugRecord>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 27839, 27875);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1648_28057_28072()
                {
                    var return_v = LocalPowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 28057, 28072);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1648_28057_28080(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 28057, 28080);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.DebugRecord>
                f_1648_28057_28086(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Debug;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 28057, 28086);
                    return return_v;
                }


                int
                f_1648_28057_28102(System.Management.Automation.PSDataCollection<System.Management.Automation.DebugRecord>
                this_param, int
                index)
                {
                    this_param.RemoveAt(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 28057, 28102);
                    return 0;
                }


                System.Management.Automation.ServerPowerShellDataStructureHandler
                f_1648_28186_28206()
                {
                    var return_v = DataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 28186, 28206);
                    return return_v;
                }


                int
                f_1648_28186_28236(System.Management.Automation.ServerPowerShellDataStructureHandler
                this_param, System.Management.Automation.DebugRecord
                record)
                {
                    this_param.SendDebugRecordToClient(record);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 28186, 28236);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1648, 27435, 28282);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1648, 27435, 28282);
            }
        }

        private void HandleInformationAdded(object sender, DataAddedEventArgs eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1648, 28555, 29438);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 28660, 28688);

                int
                index = f_1648_28672_28687(eventArgs)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 28710, 28721);

                lock (_syncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 28755, 28823);

                    int
                    indexIntoDataSent = (DynAbs.Tracing.TraceSender.Conditional_F1(1648, 28779, 28814) || (((!_extraPowerShellAlreadyScheduled) && DynAbs.Tracing.TraceSender.Conditional_F2(1648, 28817, 28818)) || DynAbs.Tracing.TraceSender.Conditional_F3(1648, 28821, 28822))) ? 0 : 1
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 28841, 29412) || true) && ((indexIntoDataSent == 0) && (DynAbs.Tracing.TraceSender.Expression_True(1648, 28845, 28904) && (!_datasent[indexIntoDataSent])))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1648, 28841, 29412);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 28946, 29014);

                        InformationRecord
                        data = f_1648_28971_29013(f_1648_28971_29006(f_1648_28971_28994(f_1648_28971_28986())), index)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 29201, 29253);

                        f_1648_29201_29252(f_1648_29201_29236(f_1648_29201_29224(f_1648_29201_29216())), index);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 29336, 29393);

                        f_1648_29336_29392(f_1648_29336_29356(), data);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1648, 28841, 29412);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1648, 28555, 29438);

                int
                f_1648_28672_28687(System.Management.Automation.DataAddedEventArgs
                this_param)
                {
                    var return_v = this_param.Index;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 28672, 28687);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1648_28971_28986()
                {
                    var return_v = LocalPowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 28971, 28986);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1648_28971_28994(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 28971, 28994);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.InformationRecord>
                f_1648_28971_29006(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Information;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 28971, 29006);
                    return return_v;
                }


                System.Management.Automation.InformationRecord
                f_1648_28971_29013(System.Management.Automation.PSDataCollection<System.Management.Automation.InformationRecord>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 28971, 29013);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1648_29201_29216()
                {
                    var return_v = LocalPowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 29201, 29216);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1648_29201_29224(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 29201, 29224);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.InformationRecord>
                f_1648_29201_29236(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Information;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 29201, 29236);
                    return return_v;
                }


                int
                f_1648_29201_29252(System.Management.Automation.PSDataCollection<System.Management.Automation.InformationRecord>
                this_param, int
                index)
                {
                    this_param.RemoveAt(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 29201, 29252);
                    return 0;
                }


                System.Management.Automation.ServerPowerShellDataStructureHandler
                f_1648_29336_29356()
                {
                    var return_v = DataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 29336, 29356);
                    return return_v;
                }


                int
                f_1648_29336_29392(System.Management.Automation.ServerPowerShellDataStructureHandler
                this_param, System.Management.Automation.InformationRecord
                record)
                {
                    this_param.SendInformationRecordToClient(record);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 29336, 29392);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1648, 28555, 29438);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1648, 28555, 29438);
            }
        }

        private void SendRemainingData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1648, 29977, 31383);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 30034, 30102);

                int
                indexIntoDataSent = (DynAbs.Tracing.TraceSender.Conditional_F1(1648, 30058, 30093) || (((!_extraPowerShellAlreadyScheduled) && DynAbs.Tracing.TraceSender.Conditional_F2(1648, 30096, 30097)) || DynAbs.Tracing.TraceSender.Conditional_F3(1648, 30100, 30101))) ? 0 : 1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 30122, 30133);
                lock (_syncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 30167, 30203);

                    _datasent[indexIntoDataSent] = true;
                }

                try
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 30408, 30413);
                        // BUGBUG: change this code to use enumerator
                        // blocked on bug #108824, to be fixed by Kriscv
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 30399, 30627) || true) && (i < f_1648_30419_30447(_localPowerShellOutput))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 30449, 30452)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1648, 30399, 30627))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1648, 30399, 30627);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 30494, 30536);

                            PSObject
                            data = f_1648_30510_30535(_localPowerShellOutput, i)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 30558, 30608);

                            f_1648_30558_30607(f_1648_30558_30578(), data);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1648, 1, 229);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1648, 1, 229);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 30647, 30678);

                    f_1648_30647_30677(
                                    _localPowerShellOutput);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 30786, 30791);

                        // foreach (ErrorRecord errorRecord in localPowerShell.Error)
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 30777, 31037) || true) && (i < f_1648_30797_30832(f_1648_30797_30826(f_1648_30797_30820(f_1648_30797_30812()))))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 30834, 30837)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1648, 30777, 31037))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1648, 30777, 31037);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 30879, 30938);

                            ErrorRecord
                            errorRecord = f_1648_30905_30937(f_1648_30905_30934(f_1648_30905_30928(f_1648_30905_30920())), i)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 30960, 31018);

                            f_1648_30960_31017(f_1648_30960_30980(), errorRecord);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1648, 1, 261);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1648, 1, 261);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 31057, 31095);

                    f_1648_31057_31094(f_1648_31057_31086(f_1648_31057_31080(f_1648_31057_31072())));
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1648, 31124, 31372);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 31170, 31181);
                    lock (_syncObject)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 31302, 31338);

                        _datasent[indexIntoDataSent] = true;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1648, 31124, 31372);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1648, 29977, 31383);

                int
                f_1648_30419_30447(System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 30419, 30447);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1648_30510_30535(System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 30510, 30535);
                    return return_v;
                }


                System.Management.Automation.ServerPowerShellDataStructureHandler
                f_1648_30558_30578()
                {
                    var return_v = DataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 30558, 30578);
                    return return_v;
                }


                int
                f_1648_30558_30607(System.Management.Automation.ServerPowerShellDataStructureHandler
                this_param, System.Management.Automation.PSObject
                data)
                {
                    this_param.SendOutputDataToClient(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 30558, 30607);
                    return 0;
                }


                int
                f_1648_30647_30677(System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 30647, 30677);
                    return 0;
                }


                System.Management.Automation.PowerShell
                f_1648_30797_30812()
                {
                    var return_v = LocalPowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 30797, 30812);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1648_30797_30820(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 30797, 30820);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                f_1648_30797_30826(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Error;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 30797, 30826);
                    return return_v;
                }


                int
                f_1648_30797_30832(System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 30797, 30832);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1648_30905_30920()
                {
                    var return_v = LocalPowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 30905, 30920);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1648_30905_30928(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 30905, 30928);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                f_1648_30905_30934(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Error;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 30905, 30934);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1648_30905_30937(System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 30905, 30937);
                    return return_v;
                }


                System.Management.Automation.ServerPowerShellDataStructureHandler
                f_1648_30960_30980()
                {
                    var return_v = DataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 30960, 30980);
                    return return_v;
                }


                int
                f_1648_30960_31017(System.Management.Automation.ServerPowerShellDataStructureHandler
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.SendErrorRecordToClient(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 30960, 31017);
                    return 0;
                }


                System.Management.Automation.PowerShell
                f_1648_31057_31072()
                {
                    var return_v = LocalPowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 31057, 31072);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1648_31057_31080(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 31057, 31080);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                f_1648_31057_31086(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Error;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 31057, 31086);
                    return return_v;
                }


                int
                f_1648_31057_31094(System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 31057, 31094);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1648, 29977, 31383);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1648, 29977, 31383);
            }
        }

        private void HandleStopReceived(object sender, EventArgs eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1648, 31607, 33562);
                {
                    try
                    {
                        do // false loop

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1648, 31699, 32789);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 31748, 32759) || true) && (f_1648_31752_31793(f_1648_31752_31787(f_1648_31752_31767())) == PSInvocationState.Stopped || (DynAbs.Tracing.TraceSender.Expression_False(1648, 31752, 31919) || f_1648_31847_31888(f_1648_31847_31882(f_1648_31847_31862())) == PSInvocationState.Completed) || (DynAbs.Tracing.TraceSender.Expression_False(1648, 31752, 32013) || f_1648_31944_31985(f_1648_31944_31979(f_1648_31944_31959())) == PSInvocationState.Failed) || (DynAbs.Tracing.TraceSender.Expression_False(1648, 31752, 32109) || f_1648_32038_32079(f_1648_32038_32073(f_1648_32038_32053())) == PSInvocationState.Stopping))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1648, 31748, 32759);
                                DynAbs.Tracing.TraceSender.TraceBreak(1648, 32151, 32157);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1648, 31748, 32759);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1648, 31748, 32759);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 32334, 32365);

                                bool
                                handledByDebugger = false
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 32387, 32598) || true) && (f_1648_32391_32416_M(!f_1648_32392_32407().IsNested) && (DynAbs.Tracing.TraceSender.Expression_True(1648, 32391, 32469) && _psDriverInvoker != null))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1648, 32387, 32598);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 32519, 32575);

                                    handledByDebugger = f_1648_32539_32574(_psDriverInvoker);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1648, 32387, 32598);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 32622, 32740) || true) && (!handledByDebugger)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1648, 32622, 32740);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 32694, 32717);

                                    f_1648_32694_32716(f_1648_32694_32709());
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1648, 32622, 32740);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1648, 31748, 32759);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1648, 31699, 32789);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 31699, 32789) || true) && (false)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1648, 31699, 32789);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1648, 31699, 32789);
                    }
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 32805, 33551) || true) && (_extraPowerShell != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1648, 32805, 33551);
                    {
                        try
                        {
                            do // false loop

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1648, 32867, 33536);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 32924, 33502) || true) && (f_1648_32928_32970(f_1648_32928_32964(_extraPowerShell)) == PSInvocationState.Stopped || (DynAbs.Tracing.TraceSender.Expression_False(1648, 32928, 33101) || f_1648_33028_33070(f_1648_33028_33064(_extraPowerShell)) == PSInvocationState.Completed) || (DynAbs.Tracing.TraceSender.Expression_False(1648, 32928, 33200) || f_1648_33130_33172(f_1648_33130_33166(_extraPowerShell)) == PSInvocationState.Failed) || (DynAbs.Tracing.TraceSender.Expression_False(1648, 32928, 33301) || f_1648_33229_33271(f_1648_33229_33265(_extraPowerShell)) == PSInvocationState.Stopping))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1648, 32924, 33502);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1648, 33351, 33357);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1648, 32924, 33502);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1648, 32924, 33502);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 33455, 33479);

                                    f_1648_33455_33478(_extraPowerShell);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1648, 32924, 33502);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1648, 32867, 33536);
                            }
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 32867, 33536) || true) && (false)
                            );
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1648, 32867, 33536);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1648, 32867, 33536);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1648, 32805, 33551);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1648, 31607, 33562);

                System.Management.Automation.PowerShell
                f_1648_31752_31767()
                {
                    var return_v = LocalPowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 31752, 31767);
                    return return_v;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1648_31752_31787(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.InvocationStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 31752, 31787);
                    return return_v;
                }


                System.Management.Automation.PSInvocationState
                f_1648_31752_31793(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 31752, 31793);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1648_31847_31862()
                {
                    var return_v = LocalPowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 31847, 31862);
                    return return_v;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1648_31847_31882(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.InvocationStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 31847, 31882);
                    return return_v;
                }


                System.Management.Automation.PSInvocationState
                f_1648_31847_31888(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 31847, 31888);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1648_31944_31959()
                {
                    var return_v = LocalPowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 31944, 31959);
                    return return_v;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1648_31944_31979(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.InvocationStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 31944, 31979);
                    return return_v;
                }


                System.Management.Automation.PSInvocationState
                f_1648_31944_31985(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 31944, 31985);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1648_32038_32053()
                {
                    var return_v = LocalPowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 32038, 32053);
                    return return_v;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1648_32038_32073(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.InvocationStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 32038, 32073);
                    return return_v;
                }


                System.Management.Automation.PSInvocationState
                f_1648_32038_32079(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 32038, 32079);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1648_32392_32407()
                {
                    var return_v = LocalPowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 32392, 32407);
                    return return_v;
                }


                bool
                f_1648_32391_32416_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 32391, 32416);
                    return return_v;
                }


                bool
                f_1648_32539_32574(System.Management.Automation.IRSPDriverInvoke
                this_param)
                {
                    var return_v = this_param.HandleStopSignal();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 32539, 32574);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1648_32694_32709()
                {
                    var return_v = LocalPowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 32694, 32709);
                    return return_v;
                }


                int
                f_1648_32694_32716(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.Stop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 32694, 32716);
                    return 0;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1648_32928_32964(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.InvocationStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 32928, 32964);
                    return return_v;
                }


                System.Management.Automation.PSInvocationState
                f_1648_32928_32970(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 32928, 32970);
                    return return_v;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1648_33028_33064(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.InvocationStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 33028, 33064);
                    return return_v;
                }


                System.Management.Automation.PSInvocationState
                f_1648_33028_33070(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 33028, 33070);
                    return return_v;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1648_33130_33166(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.InvocationStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 33130, 33166);
                    return return_v;
                }


                System.Management.Automation.PSInvocationState
                f_1648_33130_33172(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 33130, 33172);
                    return return_v;
                }


                System.Management.Automation.PSInvocationStateInfo
                f_1648_33229_33265(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.InvocationStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 33229, 33265);
                    return return_v;
                }


                System.Management.Automation.PSInvocationState
                f_1648_33229_33271(System.Management.Automation.PSInvocationStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 33229, 33271);
                    return return_v;
                }


                int
                f_1648_33455_33478(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.Stop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 33455, 33478);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1648, 31607, 33562);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1648, 31607, 33562);
            }
        }

        private void HandleInputReceived(object sender, RemoteDataEventArgs<object> eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1648, 33838, 34227);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 34089, 34216) || true) && (!_noInput && (DynAbs.Tracing.TraceSender.Expression_True(1648, 34093, 34131) && (f_1648_34107_34122() != null)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1648, 34089, 34216);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 34165, 34201);

                    f_1648_34165_34200(f_1648_34165_34180(), f_1648_34185_34199(eventArgs));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1648, 34089, 34216);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1648, 33838, 34227);

                System.Management.Automation.PSDataCollection<object>
                f_1648_34107_34122()
                {
                    var return_v = InputCollection;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 34107, 34122);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<object>
                f_1648_34165_34180()
                {
                    var return_v = InputCollection;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 34165, 34180);
                    return return_v;
                }


                object
                f_1648_34185_34199(System.Management.Automation.RemoteDataEventArgs<object>
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 34185, 34199);
                    return return_v;
                }


                int
                f_1648_34165_34200(System.Management.Automation.PSDataCollection<object>
                this_param, object
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 34165, 34200);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1648, 33838, 34227);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1648, 33838, 34227);
            }
        }

        private void HandleInputEndReceived(object sender, EventArgs eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1648, 34501, 34866);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 34737, 34855) || true) && (!_noInput && (DynAbs.Tracing.TraceSender.Expression_True(1648, 34741, 34779) && (f_1648_34755_34770() != null)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1648, 34737, 34855);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 34813, 34840);

                    f_1648_34813_34839(f_1648_34813_34828());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1648, 34737, 34855);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1648, 34501, 34866);

                System.Management.Automation.PSDataCollection<object>
                f_1648_34755_34770()
                {
                    var return_v = InputCollection;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 34755, 34770);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<object>
                f_1648_34813_34828()
                {
                    var return_v = InputCollection;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 34813, 34828);
                    return return_v;
                }


                int
                f_1648_34813_34839(System.Management.Automation.PSDataCollection<object>
                this_param)
                {
                    this_param.Complete();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 34813, 34839);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1648, 34501, 34866);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1648, 34501, 34866);
            }
        }

        private void HandleSessionConnected(object sender, EventArgs eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1648, 34878, 35302);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 35144, 35291) || true) && (f_1648_35148_35163() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1648, 35144, 35291);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 35249, 35276);

                    f_1648_35249_35275(f_1648_35249_35264());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1648, 35144, 35291);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1648, 34878, 35302);

                System.Management.Automation.PSDataCollection<object>
                f_1648_35148_35163()
                {
                    var return_v = InputCollection;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 35148, 35163);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<object>
                f_1648_35249_35264()
                {
                    var return_v = InputCollection;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 35249, 35264);
                    return return_v;
                }


                int
                f_1648_35249_35275(System.Management.Automation.PSDataCollection<object>
                this_param)
                {
                    this_param.Complete();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 35249, 35275);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1648, 34878, 35302);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1648, 34878, 35302);
            }
        }

        private void HandleHostResponseReceived(object sender, RemoteDataEventArgs<RemoteHostResponse> eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1648, 35565, 35790);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 35695, 35779);

                f_1648_35695_35778(f_1648_35695_35727(_remoteHost), f_1648_35763_35777(eventArgs));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1648, 35565, 35790);

                System.Management.Automation.Remoting.ServerMethodExecutor
                f_1648_35695_35727(System.Management.Automation.Remoting.ServerRemoteHost
                this_param)
                {
                    var return_v = this_param.ServerMethodExecutor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 35695, 35727);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostResponse
                f_1648_35763_35777(System.Management.Automation.RemoteDataEventArgs<System.Management.Automation.Remoting.RemoteHostResponse>
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 35763, 35777);
                    return return_v;
                }


                int
                f_1648_35695_35778(System.Management.Automation.Remoting.ServerMethodExecutor
                this_param, System.Management.Automation.Remoting.RemoteHostResponse
                remoteHostResponse)
                {
                    this_param.HandleRemoteHostResponseFromClient(remoteHostResponse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 35695, 35778);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1648, 35565, 35790);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1648, 35565, 35790);
            }
        }

        private void HandleIdleEvent(object sender, EventArgs args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1648, 35987, 36621);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 36071, 36137);

                Runspace
                rs = f_1648_36085_36136(f_1648_36085_36105())
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 36151, 36610) || true) && (rs != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1648, 36151, 36610);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 36199, 36269);

                    PSLocalEventManager
                    events = (object)f_1648_36236_36245(rs) as PSLocalEventManager
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 36289, 36595) || true) && (events != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1648, 36289, 36595);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 36349, 36576);
                            foreach (PSEventSubscriber subscriber in f_1648_36390_36408_I(f_1648_36390_36408(events)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1648, 36349, 36576);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1648, 36514, 36553);

                                f_1648_36514_36552(                        // Use the synchronous version
                                                        events, subscriber);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1648, 36349, 36576);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1648, 1, 228);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1648, 1, 228);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1648, 36289, 36595);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1648, 36151, 36610);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1648, 35987, 36621);

                System.Management.Automation.ServerPowerShellDataStructureHandler
                f_1648_36085_36105()
                {
                    var return_v = DataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 36085, 36105);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1648_36085_36136(System.Management.Automation.ServerPowerShellDataStructureHandler
                this_param)
                {
                    var return_v = this_param.RunspaceUsedToInvokePowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 36085, 36136);
                    return return_v;
                }


                System.Management.Automation.PSEventManager
                f_1648_36236_36245(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.Events;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 36236, 36245);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSEventSubscriber>
                f_1648_36390_36408(System.Management.Automation.PSLocalEventManager
                this_param)
                {
                    var return_v = this_param.Subscribers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 36390, 36408);
                    return return_v;
                }


                int
                f_1648_36514_36552(System.Management.Automation.PSLocalEventManager
                this_param, System.Management.Automation.PSEventSubscriber
                subscriber)
                {
                    this_param.DrainPendingActions(subscriber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 36514, 36552);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.PSEventSubscriber>
                f_1648_36390_36408_I(System.Collections.Generic.List<System.Management.Automation.PSEventSubscriber>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 36390, 36408);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1648, 35987, 36621);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1648, 35987, 36621);
            }
        }

        static ServerPowerShellDriver()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1648, 586, 36666);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1648, 586, 36666);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1648, 586, 36666);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1648, 586, 36666);

        object
        f_1648_1383_1395()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 1383, 1395);
            return return_v;
        }


        static System.Management.Automation.PowerShell
        f_1648_3738_3748_C(System.Management.Automation.PowerShell
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1648, 3363, 3949);
            return return_v;
        }


        System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
        f_1648_6248_6280()
        {
            var return_v = new System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 6248, 6280);
            return return_v;
        }


        System.Management.Automation.ServerRunspacePoolDataStructureHandler
        f_1648_6448_6487(System.Management.Automation.ServerRunspacePoolDriver
        this_param)
        {
            var return_v = this_param.DataStructureHandler;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 6448, 6487);
            return return_v;
        }


        System.Management.Automation.RemoteStreamOptions
        f_1648_6567_6586()
        {
            var return_v = RemoteStreamOptions;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 6567, 6586);
            return return_v;
        }


        System.Management.Automation.PowerShell
        f_1648_6588_6603()
        {
            var return_v = LocalPowerShell;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 6588, 6603);
            return return_v;
        }


        System.Management.Automation.ServerPowerShellDataStructureHandler
        f_1648_6448_6604(System.Management.Automation.ServerRunspacePoolDataStructureHandler
        this_param, System.Guid
        instanceId, System.Guid
        runspacePoolId, System.Management.Automation.RemoteStreamOptions
        remoteStreamOptions, System.Management.Automation.PowerShell
        localPowerShell)
        {
            var return_v = this_param.CreatePowerShellDataStructureHandler(instanceId, runspacePoolId, remoteStreamOptions, localPowerShell);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 6448, 6604);
            return return_v;
        }


        System.Management.Automation.ServerPowerShellDataStructureHandler
        f_1648_6633_6653()
        {
            var return_v = DataStructureHandler;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 6633, 6653);
            return return_v;
        }


        System.Management.Automation.Remoting.ServerRemoteHost
        f_1648_6696_6731(System.Management.Automation.ServerRunspacePoolDriver
        this_param)
        {
            var return_v = this_param.ServerRemoteHost;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 6696, 6731);
            return return_v;
        }


        System.Management.Automation.Remoting.ServerRemoteHost
        f_1648_6633_6732(System.Management.Automation.ServerPowerShellDataStructureHandler
        this_param, System.Management.Automation.Remoting.HostInfo
        powerShellHostInfo, System.Management.Automation.Remoting.ServerRemoteHost
        runspaceServerRemoteHost)
        {
            var return_v = this_param.GetHostAssociatedWithPowerShell(powerShellHostInfo, runspaceServerRemoteHost);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 6633, 6732);
            return return_v;
        }


        System.Management.Automation.PSDataCollection<object>
        f_1648_6813_6843()
        {
            var return_v = new System.Management.Automation.PSDataCollection<object>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 6813, 6843);
            return return_v;
        }


        System.Management.Automation.PSDataCollection<object>
        f_1648_6862_6877()
        {
            var return_v = InputCollection;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 6862, 6877);
            return return_v;
        }


        System.Management.Automation.PSDataCollection<object>
        f_1648_6924_6939()
        {
            var return_v = InputCollection;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 6924, 6939);
            return return_v;
        }


        int
        f_1648_7029_7088(System.Management.Automation.ServerPowerShellDriver
        this_param, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
        pipelineOutput)
        {
            this_param.RegisterPipelineOutputEventHandlers(pipelineOutput);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 7029, 7088);
            return 0;
        }


        System.Management.Automation.PowerShell
        f_1648_7109_7124()
        {
            var return_v = LocalPowerShell;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 7109, 7124);
            return return_v;
        }


        System.Management.Automation.PowerShell
        f_1648_7198_7213()
        {
            var return_v = LocalPowerShell;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 7198, 7213);
            return return_v;
        }


        int
        f_1648_7166_7214(System.Management.Automation.ServerPowerShellDriver
        this_param, System.Management.Automation.PowerShell
        powerShell)
        {
            this_param.RegisterPowerShellEventHandlers(powerShell);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 7166, 7214);
            return 0;
        }


        int
        f_1648_7346_7394(System.Management.Automation.ServerPowerShellDriver
        this_param, System.Management.Automation.PowerShell
        powerShell)
        {
            this_param.RegisterPowerShellEventHandlers(powerShell);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 7346, 7394);
            return 0;
        }


        System.Management.Automation.ServerPowerShellDataStructureHandler
        f_1648_7507_7527()
        {
            var return_v = DataStructureHandler;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 7507, 7527);
            return return_v;
        }


        int
        f_1648_7465_7528(System.Management.Automation.ServerPowerShellDriver
        this_param, System.Management.Automation.ServerPowerShellDataStructureHandler
        dsHandler)
        {
            this_param.RegisterDataStructureHandlerEventHandlers(dsHandler);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1648, 7465, 7528);
            return 0;
        }


        System.Management.Automation.PowerShell
        f_1648_7663_7678()
        {
            var return_v = LocalPowerShell;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 7663, 7678);
            return return_v;
        }


        System.Management.Automation.PowerShell
        f_1648_7905_7920()
        {
            var return_v = LocalPowerShell;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 7905, 7920);
            return return_v;
        }


        System.Management.Automation.Runspaces.RunspacePool
        f_1648_7936_7967(System.Management.Automation.ServerRunspacePoolDriver
        this_param)
        {
            var return_v = this_param.RunspacePool;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 7936, 7967);
            return return_v;
        }


        System.Management.Automation.Runspaces.RunspacePool
        f_1648_8086_8117(System.Management.Automation.ServerRunspacePoolDriver
        this_param)
        {
            var return_v = this_param.RunspacePool;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1648, 8086, 8117);
            return return_v;
        }

    }
}
