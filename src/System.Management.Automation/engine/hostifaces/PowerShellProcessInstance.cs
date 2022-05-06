// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Management.Automation.Remoting;
using System.Text;

namespace System.Management.Automation.Runspaces
{
    public sealed class PowerShellProcessInstance : IDisposable
    {
        private readonly ProcessStartInfo _startInfo;

        private RunspacePool _runspacePool;

        private readonly object _syncObject;

        private bool _started;

        private bool _isDisposed;

        private bool _processExited;

        internal static readonly string PwshExePath;

        internal static readonly string WinPwshExePath;

        static PowerShellProcessInstance()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1478, 959, 1440);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 770, 781);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 824, 838);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 1116, 1187);

                PwshExePath = f_1478_1130_1186(f_1478_1143_1173(), "pwsh.exe");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 1201, 1293);

                var
                winPowerShellDir = f_1478_1224_1292(Utils.DefaultPowerShellShellID)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 1307, 1421);

                WinPwshExePath = (DynAbs.Tracing.TraceSender.Conditional_F1(1478, 1324, 1362) || ((f_1478_1324_1362(winPowerShellDir) && DynAbs.Tracing.TraceSender.Conditional_F2(1478, 1365, 1369)) || DynAbs.Tracing.TraceSender.Conditional_F3(1478, 1372, 1420))) ? null : f_1478_1372_1420(winPowerShellDir, "powershell.exe");
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1478, 959, 1440);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1478, 959, 1440);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1478, 959, 1440);
            }
        }

        public PowerShellProcessInstance(Version powerShellVersion, PSCredential credential, ScriptBlock initializationScript, bool useWow64, string workingDirectory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1478, 2177, 6334);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 504, 514);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 546, 559);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 594, 620);
                this._syncObject = f_1478_608_620();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 644, 652);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 676, 687);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 711, 725);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 9272, 9303);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 9790, 9847);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 2360, 2389);

                string
                exePath = PwshExePath
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 2403, 2444);

                bool
                startingWindowsPowerShell51 = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 2563, 2689);

                startingWindowsPowerShell51 = (powerShellVersion != null) && (DynAbs.Tracing.TraceSender.Expression_True(1478, 2593, 2654) && (f_1478_2625_2648(powerShellVersion) == 5)) && (DynAbs.Tracing.TraceSender.Expression_True(1478, 2593, 2688) && (f_1478_2659_2682(powerShellVersion) == 1));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 2703, 3884) || true) && (startingWindowsPowerShell51)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1478, 2703, 3884);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 2768, 2945) || true) && (WinPwshExePath == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1478, 2768, 2945);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 2836, 2926);

                        throw f_1478_2842_2925(f_1478_2874_2924());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1478, 2768, 2945);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 2965, 2990);

                    exePath = WinPwshExePath;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 3010, 3869) || true) && (useWow64)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1478, 3010, 3869);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 3064, 3143);

                        string
                        procArch = f_1478_3082_3142("PROCESSOR_ARCHITECTURE")
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 3167, 3850) || true) && ((!f_1478_3173_3203(procArch)) && (DynAbs.Tracing.TraceSender.Expression_True(1478, 3171, 3358) && (f_1478_3209_3269(procArch, "amd64", StringComparison.OrdinalIgnoreCase) || (DynAbs.Tracing.TraceSender.Expression_False(1478, 3209, 3357) || f_1478_3298_3357(procArch, "ia64", StringComparison.OrdinalIgnoreCase)))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1478, 3167, 3850);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 3408, 3492);

                            exePath = f_1478_3418_3491(f_1478_3418_3451(WinPwshExePath), "\\system32\\", "\\syswow64\\");

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 3520, 3827) || true) && (!f_1478_3525_3545(exePath))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1478, 3520, 3827);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 3603, 3723);

                                string
                                message = f_1478_3620_3722(f_1478_3667_3712(), exePath)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 3753, 3800);

                                throw f_1478_3759_3799(message);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1478, 3520, 3827);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1478, 3167, 3850);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1478, 3010, 3869);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1478, 2703, 3884);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 4120, 4505);

                _startInfo = new ProcessStartInfo
                {
                    FileName = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => exePath, 1478, 4133, 4504),
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true,
                    LoadUserProfile = true
                };

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 4530, 4926) || true) && (startingWindowsPowerShell51)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1478, 4530, 4926);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 4595, 4635);

                    f_1478_4595_4634(f_1478_4595_4618(_startInfo), "-Version");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 4653, 4688);

                    f_1478_4653_4687(f_1478_4653_4676(_startInfo), "5.1");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 4820, 4911);

                    f_1478_4820_4842(_startInfo)["PSModulePath"] = f_1478_4861_4910();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1478, 4530, 4926);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 4948, 4982);

                f_1478_4948_4981(f_1478_4948_4971(_startInfo), "-s");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 4996, 5035);

                f_1478_4996_5034(f_1478_4996_5019(_startInfo), "-NoLogo");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 5049, 5091);

                f_1478_5049_5090(f_1478_5049_5072(_startInfo), "-NoProfile");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 5107, 5335) || true) && (!f_1478_5112_5155(workingDirectory) && (DynAbs.Tracing.TraceSender.Expression_True(1478, 5111, 5187) && !startingWindowsPowerShell51))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1478, 5107, 5335);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 5221, 5256);

                    f_1478_5221_5255(f_1478_5221_5244(_startInfo), "-wd");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 5274, 5320);

                    f_1478_5274_5319(f_1478_5274_5297(_startInfo), workingDirectory);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1478, 5107, 5335);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 5351, 5836) || true) && (initializationScript != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1478, 5351, 5836);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 5417, 5473);

                    var
                    scriptBlockString = f_1478_5441_5472(initializationScript)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 5491, 5821) || true) && (!f_1478_5496_5535(scriptBlockString))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1478, 5491, 5821);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 5577, 5667);

                        var
                        encodedCommand = f_1478_5598_5666(f_1478_5621_5665(f_1478_5621_5637(), scriptBlockString))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 5689, 5736);

                        f_1478_5689_5735(f_1478_5689_5712(_startInfo), "-EncodedCommand");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 5758, 5802);

                        f_1478_5758_5801(f_1478_5758_5781(_startInfo), encodedCommand);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1478, 5491, 5821);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1478, 5351, 5836);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 5852, 6230) || true) && (credential != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1478, 5852, 6230);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 5908, 5980);

                    Net.NetworkCredential
                    netCredential = f_1478_5946_5979(credential)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 6000, 6045);

                    _startInfo.UserName = f_1478_6022_6044(netCredential);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 6063, 6155);

                    _startInfo.Domain = (DynAbs.Tracing.TraceSender.Conditional_F1(1478, 6083, 6125) || ((f_1478_6083_6125(f_1478_6104_6124(netCredential)) && DynAbs.Tracing.TraceSender.Conditional_F2(1478, 6128, 6131)) || DynAbs.Tracing.TraceSender.Conditional_F3(1478, 6134, 6154))) ? "." : f_1478_6134_6154(netCredential);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 6173, 6215);

                    _startInfo.Password = f_1478_6195_6214(credential);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1478, 5852, 6230);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 6246, 6323);

                Process = new Process { StartInfo = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => _startInfo, 1478, 6256, 6322), EnableRaisingEvents = true };
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1478, 2177, 6334);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1478, 2177, 6334);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1478, 2177, 6334);
            }
        }

        public PowerShellProcessInstance(Version powerShellVersion, PSCredential credential, ScriptBlock initializationScript, bool useWow64) : this(f_1478_6880_6897_C(powerShellVersion), credential, initializationScript, useWow64, workingDirectory: null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1478, 6739, 6988);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1478, 6739, 6988);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1478, 6739, 6988);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1478, 6739, 6988);
            }
        }

        public PowerShellProcessInstance() : this(powerShellVersion: f_1478_7240_7263_C(null), credential: null, initializationScript: null, useWow64: false, workingDirectory: null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1478, 7198, 7373);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1478, 7198, 7373);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1478, 7198, 7373);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1478, 7198, 7373);
            }
        }

        public bool HasExited
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1478, 7687, 8091);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 8000, 8076);

                    return _processExited || (DynAbs.Tracing.TraceSender.Expression_False(1478, 8007, 8075) || (_started && (DynAbs.Tracing.TraceSender.Expression_True(1478, 8026, 8053) && f_1478_8038_8045() != null) && (DynAbs.Tracing.TraceSender.Expression_True(1478, 8026, 8074) && f_1478_8057_8074(f_1478_8057_8064()))));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1478, 7687, 8091);

                    System.Diagnostics.Process
                    f_1478_8038_8045()
                    {
                        var return_v = Process;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1478, 8038, 8045);
                        return return_v;
                    }


                    System.Diagnostics.Process
                    f_1478_8057_8064()
                    {
                        var return_v = Process;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1478, 8057, 8064);
                        return return_v;
                    }


                    bool
                    f_1478_8057_8074(System.Diagnostics.Process
                    this_param)
                    {
                        var return_v = this_param.HasExited;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1478, 8057, 8074);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1478, 7641, 8102);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1478, 7641, 8102);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1478, 8221, 8332);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 8267, 8281);

                f_1478_8267_8280(this, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 8295, 8321);

                f_1478_8295_8320(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1478, 8221, 8332);

                int
                f_1478_8267_8280(System.Management.Automation.Runspaces.PowerShellProcessInstance
                this_param, bool
                disposing)
                {
                    this_param.Dispose(disposing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1478, 8267, 8280);
                    return 0;
                }


                int
                f_1478_8295_8320(System.Management.Automation.Runspaces.PowerShellProcessInstance
                obj)
                {
                    GC.SuppressFinalize((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1478, 8295, 8320);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1478, 8221, 8332);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1478, 8221, 8332);
            }
        }

        private void Dispose(bool disposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1478, 8435, 9148);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 8496, 8520) || true) && (_isDisposed)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1478, 8496, 8520);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 8513, 8520);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1478, 8496, 8520);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 8540, 8551);
                lock (_syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 8585, 8609) || true) && (_isDisposed)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1478, 8585, 8609);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 8602, 8609);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1478, 8585, 8609);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 8627, 8646);

                    _isDisposed = true;
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 8677, 9137) || true) && (disposing)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1478, 8677, 9137);
                    try
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 8768, 8851) || true) && (f_1478_8772_8779() != null && (DynAbs.Tracing.TraceSender.Expression_True(1478, 8772, 8809) && f_1478_8791_8809_M(!f_1478_8792_8799().HasExited)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1478, 8768, 8851);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 8836, 8851);

                            f_1478_8836_8850(f_1478_8836_8843());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1478, 8768, 8851);
                        }
                    }
                    catch (InvalidOperationException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1478, 8888, 8959);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1478, 8888, 8959);
                    }
                    catch (Win32Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1478, 8977, 9037);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1478, 8977, 9037);
                    }
                    catch (NotSupportedException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1478, 9055, 9122);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1478, 9055, 9122);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1478, 8677, 9137);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1478, 8435, 9148);

                System.Diagnostics.Process
                f_1478_8772_8779()
                {
                    var return_v = Process;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1478, 8772, 8779);
                    return return_v;
                }


                System.Diagnostics.Process
                f_1478_8792_8799()
                {
                    var return_v = Process;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1478, 8792, 8799);
                    return return_v;
                }


                bool
                f_1478_8791_8809_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1478, 8791, 8809);
                    return return_v;
                }


                System.Diagnostics.Process
                f_1478_8836_8843()
                {
                    var return_v = Process;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1478, 8836, 8843);
                    return return_v;
                }


                int
                f_1478_8836_8850(System.Diagnostics.Process
                this_param)
                {
                    this_param.Kill();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1478, 8836, 8850);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1478, 8435, 9148);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1478, 8435, 9148);
            }
        }

        public Process Process { get; }

        internal RunspacePool RunspacePool
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1478, 9450, 9600);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 9492, 9503);
                    lock (_syncObject)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 9545, 9566);

                        return _runspacePool;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1478, 9450, 9600);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1478, 9391, 9778);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1478, 9391, 9778);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1478, 9616, 9767);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 9658, 9669);
                    lock (_syncObject)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 9711, 9733);

                        _runspacePool = value;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1478, 9616, 9767);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1478, 9391, 9778);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1478, 9391, 9778);
                }
            }
        }

        internal OutOfProcessTextWriter StdInWriter { get; set; }

        internal void Start()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1478, 9859, 10462);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 10071, 10171) || true) && (f_1478_10075_10084())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1478, 10071, 10171);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 10118, 10156);

                    throw f_1478_10124_10155();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1478, 10071, 10171);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 10193, 10204);

                lock (_syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 10238, 10318) || true) && (_started)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1478, 10238, 10318);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 10292, 10299);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1478, 10238, 10318);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 10338, 10354);

                    _started = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 10372, 10404);

                    f_1478_10372_10379().Exited += ProcessExited;
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 10435, 10451);

                f_1478_10435_10450(f_1478_10435_10442());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1478, 9859, 10462);

                bool
                f_1478_10075_10084()
                {
                    var return_v = HasExited;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1478, 10075, 10084);
                    return return_v;
                }


                System.InvalidOperationException
                f_1478_10124_10155()
                {
                    var return_v = new System.InvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1478, 10124, 10155);
                    return return_v;
                }


                System.Diagnostics.Process
                f_1478_10372_10379()
                {
                    var return_v = Process;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1478, 10372, 10379);
                    return return_v;
                }


                System.Diagnostics.Process
                f_1478_10435_10442()
                {
                    var return_v = Process;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1478, 10435, 10442);
                    return return_v;
                }


                bool
                f_1478_10435_10450(System.Diagnostics.Process
                this_param)
                {
                    var return_v = this_param.Start();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1478, 10435, 10450);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1478, 9859, 10462);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1478, 9859, 10462);
            }
        }

        private void ProcessExited(object sender, EventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1478, 10474, 10652);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 10559, 10570);
                lock (_syncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1478, 10604, 10626);

                    _processExited = true;
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1478, 10474, 10652);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1478, 10474, 10652);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1478, 10474, 10652);
            }
        }
        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1478, 368, 10698);

        static object
        f_1478_608_620()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1478, 608, 620);
            return return_v;
        }


        static string
        f_1478_1143_1173()
        {
            var return_v = Utils.DefaultPowerShellAppBase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1478, 1143, 1173);
            return return_v;
        }


        static string
        f_1478_1130_1186(string
        path1, string
        path2)
        {
            var return_v = Path.Combine(path1, path2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1478, 1130, 1186);
            return return_v;
        }


        static string
        f_1478_1224_1292(string
        shellId)
        {
            var return_v = Utils.GetApplicationBaseFromRegistry(shellId);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1478, 1224, 1292);
            return return_v;
        }


        static bool
        f_1478_1324_1362(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1478, 1324, 1362);
            return return_v;
        }


        static string
        f_1478_1372_1420(string
        path1, string
        path2)
        {
            var return_v = Path.Combine(path1, path2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1478, 1372, 1420);
            return return_v;
        }


        int
        f_1478_2625_2648(System.Version
        this_param)
        {
            var return_v = this_param.Major;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1478, 2625, 2648);
            return return_v;
        }


        int
        f_1478_2659_2682(System.Version
        this_param)
        {
            var return_v = this_param.Minor;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1478, 2659, 2682);
            return return_v;
        }


        string
        f_1478_2874_2924()
        {
            var return_v = RemotingErrorIdStrings.WindowsPowerShellNotPresent;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1478, 2874, 2924);
            return return_v;
        }


        System.Management.Automation.PSInvalidOperationException
        f_1478_2842_2925(string
        message)
        {
            var return_v = new System.Management.Automation.PSInvalidOperationException(message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1478, 2842, 2925);
            return return_v;
        }


        string?
        f_1478_3082_3142(string
        variable)
        {
            var return_v = Environment.GetEnvironmentVariable(variable);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1478, 3082, 3142);
            return return_v;
        }


        bool
        f_1478_3173_3203(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1478, 3173, 3203);
            return return_v;
        }


        bool
        f_1478_3209_3269(string
        this_param, string
        value, System.StringComparison
        comparisonType)
        {
            var return_v = this_param.Equals(value, comparisonType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1478, 3209, 3269);
            return return_v;
        }


        bool
        f_1478_3298_3357(string
        this_param, string
        value, System.StringComparison
        comparisonType)
        {
            var return_v = this_param.Equals(value, comparisonType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1478, 3298, 3357);
            return return_v;
        }


        string
        f_1478_3418_3451(string
        this_param)
        {
            var return_v = this_param.ToLowerInvariant();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1478, 3418, 3451);
            return return_v;
        }


        string
        f_1478_3418_3491(string
        this_param, string
        oldValue, string
        newValue)
        {
            var return_v = this_param.Replace(oldValue, newValue);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1478, 3418, 3491);
            return return_v;
        }


        bool
        f_1478_3525_3545(string
        path)
        {
            var return_v = File.Exists(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1478, 3525, 3545);
            return return_v;
        }


        string
        f_1478_3667_3712()
        {
            var return_v = RemotingErrorIdStrings.WowComponentNotPresent;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1478, 3667, 3712);
            return return_v;
        }


        string
        f_1478_3620_3722(string
        resourceString, params object[]
        args)
        {
            var return_v = PSRemotingErrorInvariants.FormatResourceString(resourceString, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1478, 3620, 3722);
            return return_v;
        }


        System.Management.Automation.PSInvalidOperationException
        f_1478_3759_3799(string
        message)
        {
            var return_v = new System.Management.Automation.PSInvalidOperationException(message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1478, 3759, 3799);
            return return_v;
        }


        System.Collections.ObjectModel.Collection<string>
        f_1478_4595_4618(System.Diagnostics.ProcessStartInfo
        this_param)
        {
            var return_v = this_param.ArgumentList;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1478, 4595, 4618);
            return return_v;
        }


        int
        f_1478_4595_4634(System.Collections.ObjectModel.Collection<string>
        this_param, string
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1478, 4595, 4634);
            return 0;
        }


        System.Collections.ObjectModel.Collection<string>
        f_1478_4653_4676(System.Diagnostics.ProcessStartInfo
        this_param)
        {
            var return_v = this_param.ArgumentList;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1478, 4653, 4676);
            return return_v;
        }


        int
        f_1478_4653_4687(System.Collections.ObjectModel.Collection<string>
        this_param, string
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1478, 4653, 4687);
            return 0;
        }


        System.Collections.Generic.IDictionary<string, string>
        f_1478_4820_4842(System.Diagnostics.ProcessStartInfo
        this_param)
        {
            var return_v = this_param.Environment;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1478, 4820, 4842);
            return return_v;
        }


        string
        f_1478_4861_4910()
        {
            var return_v = ModuleIntrinsics.GetWindowsPowerShellModulePath();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1478, 4861, 4910);
            return return_v;
        }


        System.Collections.ObjectModel.Collection<string>
        f_1478_4948_4971(System.Diagnostics.ProcessStartInfo
        this_param)
        {
            var return_v = this_param.ArgumentList;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1478, 4948, 4971);
            return return_v;
        }


        int
        f_1478_4948_4981(System.Collections.ObjectModel.Collection<string>
        this_param, string
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1478, 4948, 4981);
            return 0;
        }


        System.Collections.ObjectModel.Collection<string>
        f_1478_4996_5019(System.Diagnostics.ProcessStartInfo
        this_param)
        {
            var return_v = this_param.ArgumentList;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1478, 4996, 5019);
            return return_v;
        }


        int
        f_1478_4996_5034(System.Collections.ObjectModel.Collection<string>
        this_param, string
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1478, 4996, 5034);
            return 0;
        }


        System.Collections.ObjectModel.Collection<string>
        f_1478_5049_5072(System.Diagnostics.ProcessStartInfo
        this_param)
        {
            var return_v = this_param.ArgumentList;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1478, 5049, 5072);
            return return_v;
        }


        int
        f_1478_5049_5090(System.Collections.ObjectModel.Collection<string>
        this_param, string
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1478, 5049, 5090);
            return 0;
        }


        bool
        f_1478_5112_5155(string
        value)
        {
            var return_v = string.IsNullOrWhiteSpace(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1478, 5112, 5155);
            return return_v;
        }


        System.Collections.ObjectModel.Collection<string>
        f_1478_5221_5244(System.Diagnostics.ProcessStartInfo
        this_param)
        {
            var return_v = this_param.ArgumentList;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1478, 5221, 5244);
            return return_v;
        }


        int
        f_1478_5221_5255(System.Collections.ObjectModel.Collection<string>
        this_param, string
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1478, 5221, 5255);
            return 0;
        }


        System.Collections.ObjectModel.Collection<string>
        f_1478_5274_5297(System.Diagnostics.ProcessStartInfo
        this_param)
        {
            var return_v = this_param.ArgumentList;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1478, 5274, 5297);
            return return_v;
        }


        int
        f_1478_5274_5319(System.Collections.ObjectModel.Collection<string>
        this_param, string
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1478, 5274, 5319);
            return 0;
        }


        string
        f_1478_5441_5472(System.Management.Automation.ScriptBlock
        this_param)
        {
            var return_v = this_param.ToString();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1478, 5441, 5472);
            return return_v;
        }


        bool
        f_1478_5496_5535(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1478, 5496, 5535);
            return return_v;
        }


        System.Text.Encoding
        f_1478_5621_5637()
        {
            var return_v = Encoding.Unicode;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1478, 5621, 5637);
            return return_v;
        }


        byte[]
        f_1478_5621_5665(System.Text.Encoding
        this_param, string
        s)
        {
            var return_v = this_param.GetBytes(s);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1478, 5621, 5665);
            return return_v;
        }


        string
        f_1478_5598_5666(byte[]
        inArray)
        {
            var return_v = Convert.ToBase64String(inArray);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1478, 5598, 5666);
            return return_v;
        }


        System.Collections.ObjectModel.Collection<string>
        f_1478_5689_5712(System.Diagnostics.ProcessStartInfo
        this_param)
        {
            var return_v = this_param.ArgumentList;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1478, 5689, 5712);
            return return_v;
        }


        int
        f_1478_5689_5735(System.Collections.ObjectModel.Collection<string>
        this_param, string
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1478, 5689, 5735);
            return 0;
        }


        System.Collections.ObjectModel.Collection<string>
        f_1478_5758_5781(System.Diagnostics.ProcessStartInfo
        this_param)
        {
            var return_v = this_param.ArgumentList;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1478, 5758, 5781);
            return return_v;
        }


        int
        f_1478_5758_5801(System.Collections.ObjectModel.Collection<string>
        this_param, string
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1478, 5758, 5801);
            return 0;
        }


        System.Net.NetworkCredential
        f_1478_5946_5979(System.Management.Automation.PSCredential
        this_param)
        {
            var return_v = this_param.GetNetworkCredential();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1478, 5946, 5979);
            return return_v;
        }


        string
        f_1478_6022_6044(System.Net.NetworkCredential
        this_param)
        {
            var return_v = this_param.UserName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1478, 6022, 6044);
            return return_v;
        }


        string
        f_1478_6104_6124(System.Net.NetworkCredential
        this_param)
        {
            var return_v = this_param.Domain;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1478, 6104, 6124);
            return return_v;
        }


        bool
        f_1478_6083_6125(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1478, 6083, 6125);
            return return_v;
        }


        string
        f_1478_6134_6154(System.Net.NetworkCredential
        this_param)
        {
            var return_v = this_param.Domain;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1478, 6134, 6154);
            return return_v;
        }


        System.Security.SecureString
        f_1478_6195_6214(System.Management.Automation.PSCredential
        this_param)
        {
            var return_v = this_param.Password;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1478, 6195, 6214);
            return return_v;
        }


        static System.Version
        f_1478_6880_6897_C(System.Version
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1478, 6739, 6988);
            return return_v;
        }


        static System.Version
        f_1478_7240_7263_C(System.Version
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1478, 7198, 7373);
            return return_v;
        }

    }
}
