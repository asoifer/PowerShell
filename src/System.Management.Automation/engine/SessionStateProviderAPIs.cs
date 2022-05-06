// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Management.Automation.Provider;
using System.Management.Automation.Runspaces;
using System.Text;

using Dbg = System.Management.Automation;

#pragma warning disable 1634, 1691 // Stops compiler from warning about unknown warnings
#pragma warning disable 56500

namespace System.Management.Automation
{
    internal sealed partial class SessionStateInternal
    {
        internal Dictionary<string, List<ProviderInfo>> Providers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1352, 925, 1139);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 961, 1051) || true) && (this == f_1352_973_1010(f_1352_973_989()))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 961, 1051);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 1033, 1051);

                        return _providers;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 961, 1051);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 1069, 1124);

                    return f_1352_1076_1123(f_1352_1076_1113(f_1352_1076_1092()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1352, 925, 1139);

                    System.Management.Automation.ExecutionContext
                    f_1352_973_989()
                    {
                        var return_v = ExecutionContext;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 973, 989);
                        return return_v;
                    }


                    System.Management.Automation.SessionStateInternal
                    f_1352_973_1010(System.Management.Automation.ExecutionContext
                    this_param)
                    {
                        var return_v = this_param.TopLevelSessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 973, 1010);
                        return return_v;
                    }


                    System.Management.Automation.ExecutionContext
                    f_1352_1076_1092()
                    {
                        var return_v = ExecutionContext;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 1076, 1092);
                        return return_v;
                    }


                    System.Management.Automation.SessionStateInternal
                    f_1352_1076_1113(System.Management.Automation.ExecutionContext
                    this_param)
                    {
                        var return_v = this_param.TopLevelSessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 1076, 1113);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.ProviderInfo>>
                    f_1352_1076_1123(System.Management.Automation.SessionStateInternal
                    this_param)
                    {
                        var return_v = this_param.Providers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 1076, 1123);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1352, 843, 1150);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1352, 843, 1150);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private Dictionary<string, List<ProviderInfo>> _providers;

        internal Dictionary<ProviderInfo, PSDriveInfo> ProvidersCurrentWorkingDrive
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1352, 1720, 1972);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 1756, 1865) || true) && (this == f_1352_1768_1805(f_1352_1768_1784()))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 1756, 1865);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 1828, 1865);

                        return _providersCurrentWorkingDrive;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 1756, 1865);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 1883, 1957);

                    return f_1352_1890_1956(f_1352_1890_1927(f_1352_1890_1906()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1352, 1720, 1972);

                    System.Management.Automation.ExecutionContext
                    f_1352_1768_1784()
                    {
                        var return_v = ExecutionContext;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 1768, 1784);
                        return return_v;
                    }


                    System.Management.Automation.SessionStateInternal
                    f_1352_1768_1805(System.Management.Automation.ExecutionContext
                    this_param)
                    {
                        var return_v = this_param.TopLevelSessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 1768, 1805);
                        return return_v;
                    }


                    System.Management.Automation.ExecutionContext
                    f_1352_1890_1906()
                    {
                        var return_v = ExecutionContext;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 1890, 1906);
                        return return_v;
                    }


                    System.Management.Automation.SessionStateInternal
                    f_1352_1890_1927(System.Management.Automation.ExecutionContext
                    this_param)
                    {
                        var return_v = this_param.TopLevelSessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 1890, 1927);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<System.Management.Automation.ProviderInfo, System.Management.Automation.PSDriveInfo>
                    f_1352_1890_1956(System.Management.Automation.SessionStateInternal
                    this_param)
                    {
                        var return_v = this_param.ProvidersCurrentWorkingDrive;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 1890, 1956);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1352, 1620, 1983);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1352, 1620, 1983);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private Dictionary<ProviderInfo, PSDriveInfo> _providersCurrentWorkingDrive;

        internal void AddSessionStateEntry(SessionStateProviderEntry providerEntry)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1352, 2356, 2705);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 2456, 2694);

                f_1352_2456_2693(this, f_1352_2468_2498(providerEntry), f_1352_2525_2543(providerEntry), f_1352_2570_2596(providerEntry), f_1352_2623_2645(providerEntry), f_1352_2672_2692(providerEntry));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1352, 2356, 2705);

                System.Type
                f_1352_2468_2498(System.Management.Automation.Runspaces.SessionStateProviderEntry
                this_param)
                {
                    var return_v = this_param.ImplementingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 2468, 2498);
                    return return_v;
                }


                string
                f_1352_2525_2543(System.Management.Automation.Runspaces.SessionStateProviderEntry
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 2525, 2543);
                    return return_v;
                }


                string
                f_1352_2570_2596(System.Management.Automation.Runspaces.SessionStateProviderEntry
                this_param)
                {
                    var return_v = this_param.HelpFileName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 2570, 2596);
                    return return_v;
                }


                System.Management.Automation.PSSnapInInfo
                f_1352_2623_2645(System.Management.Automation.Runspaces.SessionStateProviderEntry
                this_param)
                {
                    var return_v = this_param.PSSnapIn;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 2623, 2645);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1352_2672_2692(System.Management.Automation.Runspaces.SessionStateProviderEntry
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 2672, 2692);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_1352_2456_2693(System.Management.Automation.SessionStateInternal
                this_param, System.Type
                implementingType, string
                name, string
                helpFileName, System.Management.Automation.PSSnapInInfo
                psSnapIn, System.Management.Automation.PSModuleInfo
                module)
                {
                    var return_v = this_param.AddProvider(implementingType, name, helpFileName, psSnapIn, module);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 2456, 2693);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1352, 2356, 2705);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1352, 2356, 2705);
            }
        }

        private ProviderInfo AddProvider(Type implementingType, string name, string helpFileName, PSSnapInInfo psSnapIn, PSModuleInfo module)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1352, 2717, 4585);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 2875, 2904);

                ProviderInfo
                provider = null
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 2956, 3203);

                    provider =
                    f_1352_2988_3202(f_1352_3031_3053(this), implementingType, name, helpFileName, psSnapIn);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 3221, 3248);

                    f_1352_3221_3247(provider, module);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 3268, 3290);

                    f_1352_3268_3289(this, provider);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 3361, 3519);

                    f_1352_3361_3518(f_1352_3416_3437(this), f_1352_3460_3473(provider), ProviderState.Started);
                }
                catch (LoopFlowException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1352, 3548, 3627);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 3606, 3612);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1352, 3548, 3627);
                }
                catch (PipelineStoppedException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1352, 3641, 3727);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 3706, 3712);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1352, 3641, 3727);
                }
                catch (ActionPreferenceStopException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1352, 3741, 3832);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 3811, 3817);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1352, 3741, 3832);
                }
                catch (SessionStateException sessionStateException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1352, 3846, 4306);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 3930, 4291) || true) && (f_1352_3934_3965(sessionStateException) == typeof(SessionStateException))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 3930, 4291);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 4040, 4046);

                        throw;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 3930, 4291);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 3930, 4291);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 4202, 4272);

                        f_1352_4202_4271(f_1352_4202_4223(this), sessionStateException);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 3930, 4291);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1352, 3846, 4306);
                }
                catch (Exception e) // Catch-all OK, 3rd party callout
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1352, 4320, 4542);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 4477, 4527);

                    f_1352_4477_4526(f_1352_4477_4498(this), e);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1352, 4320, 4542);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 4558, 4574);

                return provider;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1352, 2717, 4585);

                System.Management.Automation.SessionState
                f_1352_3031_3053(System.Management.Automation.SessionStateInternal
                sessionState)
                {
                    var return_v = new System.Management.Automation.SessionState(sessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 3031, 3053);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_1352_2988_3202(System.Management.Automation.SessionState
                sessionState, System.Type
                implementingType, string
                name, string
                helpFile, System.Management.Automation.PSSnapInInfo
                psSnapIn)
                {
                    var return_v = new System.Management.Automation.ProviderInfo(sessionState, implementingType, name, helpFile, psSnapIn);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 2988, 3202);
                    return return_v;
                }


                int
                f_1352_3221_3247(System.Management.Automation.ProviderInfo
                this_param, System.Management.Automation.PSModuleInfo
                module)
                {
                    this_param.SetModule(module);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 3221, 3247);
                    return 0;
                }


                System.Management.Automation.ProviderInfo
                f_1352_3268_3289(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.ProviderInfo
                provider)
                {
                    var return_v = this_param.NewProvider(provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 3268, 3289);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1352_3416_3437(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 3416, 3437);
                    return return_v;
                }


                string
                f_1352_3460_3473(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 3460, 3473);
                    return return_v;
                }


                int
                f_1352_3361_3518(System.Management.Automation.ExecutionContext
                executionContext, string
                providerName, System.Management.Automation.ProviderState
                providerState)
                {
                    MshLog.LogProviderLifecycleEvent(executionContext, providerName, providerState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 3361, 3518);
                    return 0;
                }


                System.Type
                f_1352_3934_3965(System.Management.Automation.SessionStateException
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 3934, 3965);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1352_4202_4223(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 4202, 4223);
                    return return_v;
                }


                int
                f_1352_4202_4271(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.SessionStateException
                e)
                {
                    this_param.ReportEngineStartupError((System.Exception)e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 4202, 4271);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1352_4477_4498(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 4477, 4498);
                    return return_v;
                }


                int
                f_1352_4477_4526(System.Management.Automation.ExecutionContext
                this_param, System.Exception
                e)
                {
                    this_param.ReportEngineStartupError(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 4477, 4526);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1352, 2717, 4585);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1352, 2717, 4585);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private PSDriveInfo ValidateDriveWithProvider(PSDriveInfo drive, CmdletProviderContext context, bool resolvePathIfPossible)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1352, 5854, 6357);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 6002, 6125);

                f_1352_6002_6124(drive != null, "drive should have been validated by the caller");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 6141, 6239);

                DriveCmdletProvider
                namespaceProvider =
                f_1352_6198_6238(this, f_1352_6223_6237(drive))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 6255, 6346);

                return f_1352_6262_6345(this, namespaceProvider, drive, context, resolvePathIfPossible);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1352, 5854, 6357);

                int
                f_1352_6002_6124(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 6002, 6124);
                    return 0;
                }


                System.Management.Automation.ProviderInfo
                f_1352_6223_6237(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Provider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 6223, 6237);
                    return return_v;
                }


                System.Management.Automation.Provider.DriveCmdletProvider
                f_1352_6198_6238(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.ProviderInfo
                provider)
                {
                    var return_v = this_param.GetDriveProviderInstance(provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 6198, 6238);
                    return return_v;
                }


                System.Management.Automation.PSDriveInfo
                f_1352_6262_6345(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.Provider.DriveCmdletProvider
                driveProvider, System.Management.Automation.PSDriveInfo
                drive, System.Management.Automation.CmdletProviderContext
                context, bool
                resolvePathIfPossible)
                {
                    var return_v = this_param.ValidateDriveWithProvider(driveProvider, drive, context, resolvePathIfPossible);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 6262, 6345);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1352, 5854, 6357);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1352, 5854, 6357);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private PSDriveInfo ValidateDriveWithProvider(
                    DriveCmdletProvider driveProvider,
                    PSDriveInfo drive,
                    CmdletProviderContext context,
                    bool resolvePathIfPossible)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1352, 6369, 8649);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 6605, 6728);

                f_1352_6605_6727(drive != null, "drive should have been validated by the caller");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 6744, 6883);

                f_1352_6744_6882(driveProvider != null, "driveProvider should have been validated by the caller");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 7019, 7050);

                drive.DriveBeingCreated = true;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 7157, 7456) || true) && (f_1352_7161_7173() != null && (DynAbs.Tracing.TraceSender.Expression_True(1352, 7161, 7206) && resolvePathIfPossible))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 7157, 7456);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 7240, 7318);

                    string
                    newRoot = f_1352_7257_7317(this, f_1352_7290_7300(drive), f_1352_7302_7316(drive))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 7338, 7441) || true) && (newRoot != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 7338, 7441);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 7399, 7422);

                        f_1352_7399_7421(drive, newRoot);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 7338, 7441);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 7157, 7456);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 7472, 7498);

                PSDriveInfo
                result = null
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 7550, 7598);

                    result = f_1352_7559_7597(driveProvider, drive, context);
                }
                catch (LoopFlowException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1352, 7627, 7706);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 7685, 7691);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1352, 7627, 7706);
                }
                catch (PipelineStoppedException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1352, 7720, 7806);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 7785, 7791);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1352, 7720, 7806);
                }
                catch (ActionPreferenceStopException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1352, 7820, 7911);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 7890, 7896);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1352, 7820, 7911);
                }
                catch (Exception e) // Catch-all OK, 3rd party callout
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1352, 7925, 8507);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 8012, 8343);

                    ProviderInvocationException
                    pie =
                    f_1352_8067_8342(this, "NewDriveProviderException", f_1352_8178_8223(), f_1352_8250_8276(driveProvider), f_1352_8303_8313(drive), e)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 8361, 8492);

                    f_1352_8361_8491(context, f_1352_8402_8490(f_1352_8444_8459(pie), pie));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1352, 7925, 8507);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1352, 8521, 8608);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 8561, 8593);

                    drive.DriveBeingCreated = false;
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1352, 8521, 8608);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 8624, 8638);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1352, 6369, 8649);

                int
                f_1352_6605_6727(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 6605, 6727);
                    return 0;
                }


                int
                f_1352_6744_6882(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 6744, 6882);
                    return 0;
                }


                System.Management.Automation.PSDriveInfo
                f_1352_7161_7173()
                {
                    var return_v = CurrentDrive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 7161, 7173);
                    return return_v;
                }


                string
                f_1352_7290_7300(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 7290, 7300);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_1352_7302_7316(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Provider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 7302, 7316);
                    return return_v;
                }


                string
                f_1352_7257_7317(System.Management.Automation.SessionStateInternal
                this_param, string
                root, System.Management.Automation.ProviderInfo
                provider)
                {
                    var return_v = this_param.GetProviderRootFromSpecifiedRoot(root, provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 7257, 7317);
                    return return_v;
                }


                int
                f_1352_7399_7421(System.Management.Automation.PSDriveInfo
                this_param, string
                path)
                {
                    this_param.SetRoot(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 7399, 7421);
                    return 0;
                }


                System.Management.Automation.PSDriveInfo
                f_1352_7559_7597(System.Management.Automation.Provider.DriveCmdletProvider
                this_param, System.Management.Automation.PSDriveInfo
                drive, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.NewDrive(drive, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 7559, 7597);
                    return return_v;
                }


                string
                f_1352_8178_8223()
                {
                    var return_v = SessionStateStrings.NewDriveProviderException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 8178, 8223);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_1352_8250_8276(System.Management.Automation.Provider.DriveCmdletProvider
                this_param)
                {
                    var return_v = this_param.ProviderInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 8250, 8276);
                    return return_v;
                }


                string
                f_1352_8303_8313(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 8303, 8313);
                    return return_v;
                }


                System.Management.Automation.ProviderInvocationException
                f_1352_8067_8342(System.Management.Automation.SessionStateInternal
                this_param, string
                resourceId, string
                resourceStr, System.Management.Automation.ProviderInfo
                provider, string
                path, System.Exception
                e)
                {
                    var return_v = this_param.NewProviderInvocationException(resourceId, resourceStr, provider, path, e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 8067, 8342);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1352_8444_8459(System.Management.Automation.ProviderInvocationException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 8444, 8459);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1352_8402_8490(System.Management.Automation.ErrorRecord
                errorRecord, System.Management.Automation.ProviderInvocationException
                replaceParentContainsErrorRecordException)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(errorRecord, (System.Exception)replaceParentContainsErrorRecordException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 8402, 8490);
                    return return_v;
                }


                int
                f_1352_8361_8491(System.Management.Automation.CmdletProviderContext
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 8361, 8491);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1352, 6369, 8649);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1352, 6369, 8649);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Provider.CmdletProvider GetProviderInstance(string providerId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1352, 9375, 9735);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 9471, 9601) || true) && (providerId == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 9471, 9601);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 9527, 9586);

                    throw f_1352_9533_9585("providerId");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 9471, 9601);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 9617, 9671);

                ProviderInfo
                provider = f_1352_9641_9670(this, providerId)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 9687, 9724);

                return f_1352_9694_9723(this, provider);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1352, 9375, 9735);

                System.Management.Automation.PSArgumentNullException
                f_1352_9533_9585(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 9533, 9585);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_1352_9641_9670(System.Management.Automation.SessionStateInternal
                this_param, string
                name)
                {
                    var return_v = this_param.GetSingleProvider(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 9641, 9670);
                    return return_v;
                }


                System.Management.Automation.Provider.CmdletProvider
                f_1352_9694_9723(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.ProviderInfo
                provider)
                {
                    var return_v = this_param.GetProviderInstance(provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 9694, 9723);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1352, 9375, 9735);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1352, 9375, 9735);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Provider.CmdletProvider GetProviderInstance(ProviderInfo provider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1352, 10213, 10499);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 10313, 10439) || true) && (provider == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 10313, 10439);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 10367, 10424);

                    throw f_1352_10373_10423("provider");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 10313, 10439);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 10455, 10488);

                return f_1352_10462_10487(provider);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1352, 10213, 10499);

                System.Management.Automation.PSArgumentNullException
                f_1352_10373_10423(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 10373, 10423);
                    return return_v;
                }


                System.Management.Automation.Provider.CmdletProvider
                f_1352_10462_10487(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.CreateInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 10462, 10487);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1352, 10213, 10499);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1352, 10213, 10499);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ProviderNameAmbiguousException NewAmbiguousProviderName(string name, Collection<ProviderInfo> matchingProviders)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1352, 11031, 11602);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 11184, 11247);

                string
                possibleMatches = f_1352_11209_11246(matchingProviders)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 11263, 11566);

                ProviderNameAmbiguousException
                e =
                f_1352_11315_11565(name, "ProviderNameAmbiguous", f_1352_11445_11486(), matchingProviders, possibleMatches)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 11582, 11591);

                return e;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1352, 11031, 11602);

                string
                f_1352_11209_11246(System.Collections.ObjectModel.Collection<System.Management.Automation.ProviderInfo>
                matchingProviders)
                {
                    var return_v = GetPossibleMatches(matchingProviders);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 11209, 11246);
                    return return_v;
                }


                string
                f_1352_11445_11486()
                {
                    var return_v = SessionStateStrings.ProviderNameAmbiguous;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 11445, 11486);
                    return return_v;
                }


                System.Management.Automation.ProviderNameAmbiguousException
                f_1352_11315_11565(string
                providerName, string
                errorIdAndResourceId, string
                resourceStr, System.Collections.ObjectModel.Collection<System.Management.Automation.ProviderInfo>
                possibleMatches, params object[]
                messageArgs)
                {
                    var return_v = new System.Management.Automation.ProviderNameAmbiguousException(providerName, errorIdAndResourceId, resourceStr, possibleMatches, messageArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 11315, 11565);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1352, 11031, 11602);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1352, 11031, 11602);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string GetPossibleMatches(Collection<ProviderInfo> matchingProviders)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1352, 11614, 12056);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 11723, 11775);

                StringBuilder
                possibleMatches = f_1352_11755_11774()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 11791, 11995);
                    foreach (ProviderInfo matchingProvider in f_1352_11833_11850_I(matchingProviders))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 11791, 11995);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 11884, 11912);

                        f_1352_11884_11911(possibleMatches, " ");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 11930, 11980);

                        f_1352_11930_11979(possibleMatches, f_1352_11953_11978(matchingProvider));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 11791, 11995);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1352, 1, 205);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1352, 1, 205);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 12011, 12045);

                return f_1352_12018_12044(possibleMatches);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1352, 11614, 12056);

                System.Text.StringBuilder
                f_1352_11755_11774()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 11755, 11774);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1352_11884_11911(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 11884, 11911);
                    return return_v;
                }


                string
                f_1352_11953_11978(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 11953, 11978);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1352_11930_11979(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 11930, 11979);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.ProviderInfo>
                f_1352_11833_11850_I(System.Collections.ObjectModel.Collection<System.Management.Automation.ProviderInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 11833, 11850);
                    return return_v;
                }


                string
                f_1352_12018_12044(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 12018, 12044);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1352, 11614, 12056);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1352, 11614, 12056);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal DriveCmdletProvider GetDriveProviderInstance(string providerId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1352, 12973, 13600);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 13070, 13200) || true) && (providerId == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 13070, 13200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 13126, 13185);

                    throw f_1352_13132_13184("providerId");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 13070, 13200);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 13216, 13330);

                DriveCmdletProvider
                driveCmdletProvider =
                f_1352_13275_13306(this, providerId) as DriveCmdletProvider
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 13346, 13546) || true) && (driveCmdletProvider == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 13346, 13546);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 13411, 13531);

                    throw
                    f_1352_13438_13530(f_1352_13477_13529());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 13346, 13546);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 13562, 13589);

                return driveCmdletProvider;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1352, 12973, 13600);

                System.Management.Automation.PSArgumentNullException
                f_1352_13132_13184(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 13132, 13184);
                    return return_v;
                }


                System.Management.Automation.Provider.CmdletProvider
                f_1352_13275_13306(System.Management.Automation.SessionStateInternal
                this_param, string
                providerId)
                {
                    var return_v = this_param.GetProviderInstance(providerId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 13275, 13306);
                    return return_v;
                }


                string
                f_1352_13477_13529()
                {
                    var return_v = SessionStateStrings.DriveCmdletProvider_NotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 13477, 13529);
                    return return_v;
                }


                System.Management.Automation.PSNotSupportedException
                f_1352_13438_13530(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewNotSupportedException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 13438, 13530);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1352, 12973, 13600);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1352, 12973, 13600);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal DriveCmdletProvider GetDriveProviderInstance(ProviderInfo provider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1352, 14323, 14948);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 14424, 14550) || true) && (provider == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 14424, 14550);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 14478, 14535);

                    throw f_1352_14484_14534("provider");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 14424, 14550);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 14566, 14678);

                DriveCmdletProvider
                driveCmdletProvider =
                f_1352_14625_14654(this, provider) as DriveCmdletProvider
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 14694, 14894) || true) && (driveCmdletProvider == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 14694, 14894);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 14759, 14879);

                    throw
                    f_1352_14786_14878(f_1352_14825_14877());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 14694, 14894);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 14910, 14937);

                return driveCmdletProvider;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1352, 14323, 14948);

                System.Management.Automation.PSArgumentNullException
                f_1352_14484_14534(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 14484, 14534);
                    return return_v;
                }


                System.Management.Automation.Provider.CmdletProvider
                f_1352_14625_14654(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.ProviderInfo
                provider)
                {
                    var return_v = this_param.GetProviderInstance(provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 14625, 14654);
                    return return_v;
                }


                string
                f_1352_14825_14877()
                {
                    var return_v = SessionStateStrings.DriveCmdletProvider_NotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 14825, 14877);
                    return return_v;
                }


                System.Management.Automation.PSNotSupportedException
                f_1352_14786_14878(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewNotSupportedException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 14786, 14878);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1352, 14323, 14948);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1352, 14323, 14948);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static DriveCmdletProvider GetDriveProviderInstance(CmdletProvider providerInstance)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1352, 15685, 16329);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 15802, 15944) || true) && (providerInstance == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 15802, 15944);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 15864, 15929);

                    throw f_1352_15870_15928("providerInstance");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 15802, 15944);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 15960, 16059);

                DriveCmdletProvider
                driveCmdletProvider =
                                providerInstance as DriveCmdletProvider
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 16075, 16275) || true) && (driveCmdletProvider == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 16075, 16275);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 16140, 16260);

                    throw
                    f_1352_16167_16259(f_1352_16206_16258());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 16075, 16275);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 16291, 16318);

                return driveCmdletProvider;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1352, 15685, 16329);

                System.Management.Automation.PSArgumentNullException
                f_1352_15870_15928(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 15870, 15928);
                    return return_v;
                }


                string
                f_1352_16206_16258()
                {
                    var return_v = SessionStateStrings.DriveCmdletProvider_NotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 16206, 16258);
                    return return_v;
                }


                System.Management.Automation.PSNotSupportedException
                f_1352_16167_16259(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewNotSupportedException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 16167, 16259);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1352, 15685, 16329);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1352, 15685, 16329);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ItemCmdletProvider GetItemProviderInstance(string providerId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1352, 17244, 17863);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 17339, 17469) || true) && (providerId == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 17339, 17469);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 17395, 17454);

                    throw f_1352_17401_17453("providerId");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 17339, 17469);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 17485, 17596);

                ItemCmdletProvider
                itemCmdletProvider =
                f_1352_17542_17573(this, providerId) as ItemCmdletProvider
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 17612, 17810) || true) && (itemCmdletProvider == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 17612, 17810);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 17676, 17795);

                    throw
                    f_1352_17703_17794(f_1352_17742_17793());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 17612, 17810);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 17826, 17852);

                return itemCmdletProvider;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1352, 17244, 17863);

                System.Management.Automation.PSArgumentNullException
                f_1352_17401_17453(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 17401, 17453);
                    return return_v;
                }


                System.Management.Automation.Provider.CmdletProvider
                f_1352_17542_17573(System.Management.Automation.SessionStateInternal
                this_param, string
                providerId)
                {
                    var return_v = this_param.GetProviderInstance(providerId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 17542, 17573);
                    return return_v;
                }


                string
                f_1352_17742_17793()
                {
                    var return_v = SessionStateStrings.ItemCmdletProvider_NotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 17742, 17793);
                    return return_v;
                }


                System.Management.Automation.PSNotSupportedException
                f_1352_17703_17794(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewNotSupportedException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 17703, 17794);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1352, 17244, 17863);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1352, 17244, 17863);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ItemCmdletProvider GetItemProviderInstance(ProviderInfo provider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1352, 18572, 19189);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 18671, 18797) || true) && (provider == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 18671, 18797);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 18725, 18782);

                    throw f_1352_18731_18781("provider");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 18671, 18797);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 18813, 18922);

                ItemCmdletProvider
                itemCmdletProvider =
                f_1352_18870_18899(this, provider) as ItemCmdletProvider
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 18938, 19136) || true) && (itemCmdletProvider == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 18938, 19136);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 19002, 19121);

                    throw
                    f_1352_19029_19120(f_1352_19068_19119());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 18938, 19136);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 19152, 19178);

                return itemCmdletProvider;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1352, 18572, 19189);

                System.Management.Automation.PSArgumentNullException
                f_1352_18731_18781(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 18731, 18781);
                    return return_v;
                }


                System.Management.Automation.Provider.CmdletProvider
                f_1352_18870_18899(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.ProviderInfo
                provider)
                {
                    var return_v = this_param.GetProviderInstance(provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 18870, 18899);
                    return return_v;
                }


                string
                f_1352_19068_19119()
                {
                    var return_v = SessionStateStrings.ItemCmdletProvider_NotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 19068, 19119);
                    return return_v;
                }


                System.Management.Automation.PSNotSupportedException
                f_1352_19029_19120(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewNotSupportedException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 19029, 19120);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1352, 18572, 19189);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1352, 18572, 19189);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ItemCmdletProvider GetItemProviderInstance(CmdletProvider providerInstance)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1352, 19923, 20559);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 20038, 20180) || true) && (providerInstance == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 20038, 20180);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 20100, 20165);

                    throw f_1352_20106_20164("providerInstance");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 20038, 20180);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 20196, 20292);

                ItemCmdletProvider
                itemCmdletProvider =
                                providerInstance as ItemCmdletProvider
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 20308, 20506) || true) && (itemCmdletProvider == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 20308, 20506);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 20372, 20491);

                    throw
                    f_1352_20399_20490(f_1352_20438_20489());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 20308, 20506);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 20522, 20548);

                return itemCmdletProvider;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1352, 19923, 20559);

                System.Management.Automation.PSArgumentNullException
                f_1352_20106_20164(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 20106, 20164);
                    return return_v;
                }


                string
                f_1352_20438_20489()
                {
                    var return_v = SessionStateStrings.ItemCmdletProvider_NotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 20438, 20489);
                    return return_v;
                }


                System.Management.Automation.PSNotSupportedException
                f_1352_20399_20490(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewNotSupportedException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 20399, 20490);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1352, 19923, 20559);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1352, 19923, 20559);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ContainerCmdletProvider GetContainerProviderInstance(string providerId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1352, 21484, 22143);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 21589, 21719) || true) && (providerId == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 21589, 21719);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 21645, 21704);

                    throw f_1352_21651_21703("providerId");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 21589, 21719);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 21735, 21861);

                ContainerCmdletProvider
                containerCmdletProvider =
                f_1352_21802_21833(this, providerId) as ContainerCmdletProvider
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 21877, 22085) || true) && (containerCmdletProvider == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 21877, 22085);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 21946, 22070);

                    throw
                    f_1352_21973_22069(f_1352_22012_22068());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 21877, 22085);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 22101, 22132);

                return containerCmdletProvider;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1352, 21484, 22143);

                System.Management.Automation.PSArgumentNullException
                f_1352_21651_21703(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 21651, 21703);
                    return return_v;
                }


                System.Management.Automation.Provider.CmdletProvider
                f_1352_21802_21833(System.Management.Automation.SessionStateInternal
                this_param, string
                providerId)
                {
                    var return_v = this_param.GetProviderInstance(providerId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 21802, 21833);
                    return return_v;
                }


                string
                f_1352_22012_22068()
                {
                    var return_v = SessionStateStrings.ContainerCmdletProvider_NotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 22012, 22068);
                    return return_v;
                }


                System.Management.Automation.PSNotSupportedException
                f_1352_21973_22069(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewNotSupportedException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 21973, 22069);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1352, 21484, 22143);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1352, 21484, 22143);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ContainerCmdletProvider GetContainerProviderInstance(ProviderInfo provider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1352, 22862, 23519);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 22971, 23097) || true) && (provider == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 22971, 23097);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 23025, 23082);

                    throw f_1352_23031_23081("provider");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 22971, 23097);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 23113, 23237);

                ContainerCmdletProvider
                containerCmdletProvider =
                f_1352_23180_23209(this, provider) as ContainerCmdletProvider
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 23253, 23461) || true) && (containerCmdletProvider == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 23253, 23461);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 23322, 23446);

                    throw
                    f_1352_23349_23445(f_1352_23388_23444());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 23253, 23461);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 23477, 23508);

                return containerCmdletProvider;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1352, 22862, 23519);

                System.Management.Automation.PSArgumentNullException
                f_1352_23031_23081(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 23031, 23081);
                    return return_v;
                }


                System.Management.Automation.Provider.CmdletProvider
                f_1352_23180_23209(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.ProviderInfo
                provider)
                {
                    var return_v = this_param.GetProviderInstance(provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 23180, 23209);
                    return return_v;
                }


                string
                f_1352_23388_23444()
                {
                    var return_v = SessionStateStrings.ContainerCmdletProvider_NotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 23388, 23444);
                    return return_v;
                }


                System.Management.Automation.PSNotSupportedException
                f_1352_23349_23445(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewNotSupportedException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 23349, 23445);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1352, 22862, 23519);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1352, 22862, 23519);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ContainerCmdletProvider GetContainerProviderInstance(CmdletProvider providerInstance)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1352, 24268, 24944);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 24393, 24535) || true) && (providerInstance == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 24393, 24535);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 24455, 24520);

                    throw f_1352_24461_24519("providerInstance");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 24393, 24535);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 24551, 24662);

                ContainerCmdletProvider
                containerCmdletProvider =
                                providerInstance as ContainerCmdletProvider
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 24678, 24886) || true) && (containerCmdletProvider == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 24678, 24886);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 24747, 24871);

                    throw
                    f_1352_24774_24870(f_1352_24813_24869());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 24678, 24886);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 24902, 24933);

                return containerCmdletProvider;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1352, 24268, 24944);

                System.Management.Automation.PSArgumentNullException
                f_1352_24461_24519(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 24461, 24519);
                    return return_v;
                }


                string
                f_1352_24813_24869()
                {
                    var return_v = SessionStateStrings.ContainerCmdletProvider_NotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 24813, 24869);
                    return return_v;
                }


                System.Management.Automation.PSNotSupportedException
                f_1352_24774_24870(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewNotSupportedException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 24774, 24870);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1352, 24268, 24944);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1352, 24268, 24944);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal NavigationCmdletProvider GetNavigationProviderInstance(ProviderInfo provider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1352, 25668, 26333);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 25779, 25905) || true) && (provider == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 25779, 25905);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 25833, 25890);

                    throw f_1352_25839_25889("provider");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 25779, 25905);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 25921, 26048);

                NavigationCmdletProvider
                navigationCmdletProvider =
                f_1352_25990_26019(this, provider) as NavigationCmdletProvider
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 26064, 26274) || true) && (navigationCmdletProvider == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 26064, 26274);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 26134, 26259);

                    throw
                    f_1352_26161_26258(f_1352_26200_26257());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 26064, 26274);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 26290, 26322);

                return navigationCmdletProvider;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1352, 25668, 26333);

                System.Management.Automation.PSArgumentNullException
                f_1352_25839_25889(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 25839, 25889);
                    return return_v;
                }


                System.Management.Automation.Provider.CmdletProvider
                f_1352_25990_26019(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.ProviderInfo
                provider)
                {
                    var return_v = this_param.GetProviderInstance(provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 25990, 26019);
                    return return_v;
                }


                string
                f_1352_26200_26257()
                {
                    var return_v = SessionStateStrings.NavigationCmdletProvider_NotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 26200, 26257);
                    return return_v;
                }


                System.Management.Automation.PSNotSupportedException
                f_1352_26161_26258(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewNotSupportedException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 26161, 26258);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1352, 25668, 26333);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1352, 25668, 26333);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static NavigationCmdletProvider GetNavigationProviderInstance(CmdletProvider providerInstance, bool acceptNonContainerProviders)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1352, 27297, 28051);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 27458, 27600) || true) && (providerInstance == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 27458, 27600);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 27520, 27585);

                    throw f_1352_27526_27584("providerInstance");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 27458, 27600);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 27616, 27730);

                NavigationCmdletProvider
                navigationCmdletProvider =
                                providerInstance as NavigationCmdletProvider
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 27746, 27992) || true) && ((navigationCmdletProvider == null) && (DynAbs.Tracing.TraceSender.Expression_True(1352, 27750, 27818) && (!acceptNonContainerProviders)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 27746, 27992);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 27852, 27977);

                    throw
                    f_1352_27879_27976(f_1352_27918_27975());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 27746, 27992);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 28008, 28040);

                return navigationCmdletProvider;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1352, 27297, 28051);

                System.Management.Automation.PSArgumentNullException
                f_1352_27526_27584(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 27526, 27584);
                    return return_v;
                }


                string
                f_1352_27918_27975()
                {
                    var return_v = SessionStateStrings.NavigationCmdletProvider_NotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 27918, 27975);
                    return return_v;
                }


                System.Management.Automation.PSNotSupportedException
                f_1352_27879_27976(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewNotSupportedException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 27879, 27976);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1352, 27297, 28051);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1352, 27297, 28051);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsProviderLoaded(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1352, 28560, 29143);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 28628, 28648);

                bool
                result = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 28664, 28792) || true) && (f_1352_28668_28694(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 28664, 28792);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 28728, 28777);

                    throw f_1352_28734_28776("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 28664, 28792);
                }

                // Get the provider from the providers container

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 28908, 28960);

                    ProviderInfo
                    providerInfo = f_1352_28936_28959(this, name)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 28980, 29010);

                    result = providerInfo != null;
                }
                catch (ProviderNotFoundException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1352, 29039, 29102);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1352, 29039, 29102);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 29118, 29132);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1352, 28560, 29143);

                bool
                f_1352_28668_28694(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 28668, 28694);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1352_28734_28776(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 28734, 28776);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_1352_28936_28959(System.Management.Automation.SessionStateInternal
                this_param, string
                name)
                {
                    var return_v = this_param.GetSingleProvider(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 28936, 28959);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1352, 28560, 29143);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1352, 28560, 29143);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Collection<ProviderInfo> GetProvider(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1352, 29772, 30539);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 29855, 29983) || true) && (f_1352_29859_29885(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 29855, 29983);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 29919, 29968);

                    throw f_1352_29925_29967("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 29855, 29983);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 29999, 30076);

                PSSnapinQualifiedName
                providerName = f_1352_30036_30075(name)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 30092, 30479) || true) && (providerName == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 30092, 30479);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 30150, 30436);

                    ProviderNotFoundException
                    e =
                    f_1352_30198_30435(name, SessionStateCategory.CmdletProvider, "ProviderNotFoundBadFormat", f_1352_30389_30434())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 30456, 30464);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 30092, 30479);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 30495, 30528);

                return f_1352_30502_30527(this, providerName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1352, 29772, 30539);

                bool
                f_1352_29859_29885(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 29859, 29885);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1352_29925_29967(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 29925, 29967);
                    return return_v;
                }


                System.Management.Automation.PSSnapinQualifiedName
                f_1352_30036_30075(string
                name)
                {
                    var return_v = PSSnapinQualifiedName.GetInstance(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 30036, 30075);
                    return return_v;
                }


                string
                f_1352_30389_30434()
                {
                    var return_v = SessionStateStrings.ProviderNotFoundBadFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 30389, 30434);
                    return return_v;
                }


                System.Management.Automation.ProviderNotFoundException
                f_1352_30198_30435(string
                itemName, System.Management.Automation.SessionStateCategory
                sessionStateCategory, string
                errorIdAndResourceId, string
                resourceStr, params object[]
                messageArgs)
                {
                    var return_v = new System.Management.Automation.ProviderNotFoundException(itemName, sessionStateCategory, errorIdAndResourceId, resourceStr, messageArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 30198, 30435);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.ProviderInfo>
                f_1352_30502_30527(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.PSSnapinQualifiedName
                providerName)
                {
                    var return_v = this_param.GetProvider(providerName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 30502, 30527);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1352, 29772, 30539);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1352, 29772, 30539);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ProviderInfo GetSingleProvider(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1352, 31297, 32155);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 31374, 31437);

                Collection<ProviderInfo>
                matchingProviders = f_1352_31419_31436(this, name)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 31453, 32100) || true) && (f_1352_31457_31480(matchingProviders) != 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 31453, 32100);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 31519, 32085) || true) && (f_1352_31523_31546(matchingProviders) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 31519, 32085);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 31593, 31896);

                        ProviderNotFoundException
                        e =
                        f_1352_31648_31895(name, SessionStateCategory.CmdletProvider, "ProviderNotFound", f_1352_31858_31894())
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 31920, 31928);

                        throw e;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 31519, 32085);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 31519, 32085);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 32010, 32066);

                        throw f_1352_32016_32065(name, matchingProviders);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 31519, 32085);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 31453, 32100);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 32116, 32144);

                return f_1352_32123_32143(matchingProviders, 0);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1352, 31297, 32155);

                System.Collections.ObjectModel.Collection<System.Management.Automation.ProviderInfo>
                f_1352_31419_31436(System.Management.Automation.SessionStateInternal
                this_param, string
                name)
                {
                    var return_v = this_param.GetProvider(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 31419, 31436);
                    return return_v;
                }


                int
                f_1352_31457_31480(System.Collections.ObjectModel.Collection<System.Management.Automation.ProviderInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 31457, 31480);
                    return return_v;
                }


                int
                f_1352_31523_31546(System.Collections.ObjectModel.Collection<System.Management.Automation.ProviderInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 31523, 31546);
                    return return_v;
                }


                string
                f_1352_31858_31894()
                {
                    var return_v = SessionStateStrings.ProviderNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 31858, 31894);
                    return return_v;
                }


                System.Management.Automation.ProviderNotFoundException
                f_1352_31648_31895(string
                itemName, System.Management.Automation.SessionStateCategory
                sessionStateCategory, string
                errorIdAndResourceId, string
                resourceStr, params object[]
                messageArgs)
                {
                    var return_v = new System.Management.Automation.ProviderNotFoundException(itemName, sessionStateCategory, errorIdAndResourceId, resourceStr, messageArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 31648, 31895);
                    return return_v;
                }


                System.Management.Automation.ProviderNameAmbiguousException
                f_1352_32016_32065(string
                name, System.Collections.ObjectModel.Collection<System.Management.Automation.ProviderInfo>
                matchingProviders)
                {
                    var return_v = NewAmbiguousProviderName(name, matchingProviders);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 32016, 32065);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_1352_32123_32143(System.Collections.ObjectModel.Collection<System.Management.Automation.ProviderInfo>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 32123, 32143);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1352, 31297, 32155);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1352, 31297, 32155);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Collection<ProviderInfo> GetProvider(PSSnapinQualifiedName providerName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1352, 32167, 34702);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 32273, 32338);

                Collection<ProviderInfo>
                result = f_1352_32307_32337()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 32354, 32740) || true) && (providerName == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 32354, 32740);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 32412, 32697);

                    ProviderNotFoundException
                    e =
                    f_1352_32463_32696("null", SessionStateCategory.CmdletProvider, "ProviderNotFound", f_1352_32659_32695())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 32717, 32725);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 32354, 32740);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 32820, 32864);

                List<ProviderInfo>
                matchingProviders = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 32880, 33672) || true) && (!f_1352_32885_32953(f_1352_32885_32894(), f_1352_32907_32929(providerName), out matchingProviders))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 32880, 33672);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 33068, 33149);

                    f_1352_33068_33148(f_1352_33107_33129(providerName), f_1352_33131_33147());

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 33169, 33657) || true) && (!f_1352_33174_33242(f_1352_33174_33183(), f_1352_33196_33218(providerName), out matchingProviders))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 33169, 33657);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 33284, 33606);

                        ProviderNotFoundException
                        e =
                        f_1352_33339_33605(f_1352_33399_33422(providerName), SessionStateCategory.CmdletProvider, "ProviderNotFound", f_1352_33568_33604())
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 33630, 33638);

                        throw e;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 33169, 33657);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 32880, 33672);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 33688, 34661) || true) && (!f_1352_33693_33740(f_1352_33714_33739(providerName)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 33688, 34661);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 33837, 34447);
                        foreach (ProviderInfo provider in f_1352_33871_33888_I(matchingProviders))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 33837, 34447);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 33930, 34428) || true) && (f_1352_33934_34120(f_1352_33978_33999(provider), f_1352_34030_34055(providerName), StringComparison.OrdinalIgnoreCase) || (DynAbs.Tracing.TraceSender.Expression_False(1352, 33934, 34334) || f_1352_34149_34334(f_1352_34193_34212(provider), f_1352_34243_34268(providerName), StringComparison.OrdinalIgnoreCase)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 33930, 34428);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 34384, 34405);

                                f_1352_34384_34404(result, provider);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 33930, 34428);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 33837, 34447);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1352, 1, 611);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1352, 1, 611);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 33688, 34661);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 33688, 34661);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 34513, 34646);
                        foreach (ProviderInfo provider in f_1352_34547_34564_I(matchingProviders))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 34513, 34646);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 34606, 34627);

                            f_1352_34606_34626(result, provider);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 34513, 34646);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1352, 1, 134);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1352, 1, 134);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 33688, 34661);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 34677, 34691);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1352, 32167, 34702);

                System.Collections.ObjectModel.Collection<System.Management.Automation.ProviderInfo>
                f_1352_32307_32337()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.ProviderInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 32307, 32337);
                    return return_v;
                }


                string
                f_1352_32659_32695()
                {
                    var return_v = SessionStateStrings.ProviderNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 32659, 32695);
                    return return_v;
                }


                System.Management.Automation.ProviderNotFoundException
                f_1352_32463_32696(string
                itemName, System.Management.Automation.SessionStateCategory
                sessionStateCategory, string
                errorIdAndResourceId, string
                resourceStr, params object[]
                messageArgs)
                {
                    var return_v = new System.Management.Automation.ProviderNotFoundException(itemName, sessionStateCategory, errorIdAndResourceId, resourceStr, messageArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 32463, 32696);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.ProviderInfo>>
                f_1352_32885_32894()
                {
                    var return_v = Providers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 32885, 32894);
                    return return_v;
                }


                string
                f_1352_32907_32929(System.Management.Automation.PSSnapinQualifiedName
                this_param)
                {
                    var return_v = this_param.ShortName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 32907, 32929);
                    return return_v;
                }


                bool
                f_1352_32885_32953(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.ProviderInfo>>
                this_param, string
                key, out System.Collections.Generic.List<System.Management.Automation.ProviderInfo>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 32885, 32953);
                    return return_v;
                }


                string
                f_1352_33107_33129(System.Management.Automation.PSSnapinQualifiedName
                this_param)
                {
                    var return_v = this_param.ShortName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 33107, 33129);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1352_33131_33147()
                {
                    var return_v = ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 33131, 33147);
                    return return_v;
                }


                int
                f_1352_33068_33148(string
                name, System.Management.Automation.ExecutionContext
                context)
                {
                    SessionStateInternal.MountDefaultDrive(name, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 33068, 33148);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.ProviderInfo>>
                f_1352_33174_33183()
                {
                    var return_v = Providers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 33174, 33183);
                    return return_v;
                }


                string
                f_1352_33196_33218(System.Management.Automation.PSSnapinQualifiedName
                this_param)
                {
                    var return_v = this_param.ShortName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 33196, 33218);
                    return return_v;
                }


                bool
                f_1352_33174_33242(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.ProviderInfo>>
                this_param, string
                key, out System.Collections.Generic.List<System.Management.Automation.ProviderInfo>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 33174, 33242);
                    return return_v;
                }


                string
                f_1352_33399_33422(System.Management.Automation.PSSnapinQualifiedName
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 33399, 33422);
                    return return_v;
                }


                string
                f_1352_33568_33604()
                {
                    var return_v = SessionStateStrings.ProviderNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 33568, 33604);
                    return return_v;
                }


                System.Management.Automation.ProviderNotFoundException
                f_1352_33339_33605(string
                itemName, System.Management.Automation.SessionStateCategory
                sessionStateCategory, string
                errorIdAndResourceId, string
                resourceStr, params object[]
                messageArgs)
                {
                    var return_v = new System.Management.Automation.ProviderNotFoundException(itemName, sessionStateCategory, errorIdAndResourceId, resourceStr, messageArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 33339, 33605);
                    return return_v;
                }


                string
                f_1352_33714_33739(System.Management.Automation.PSSnapinQualifiedName
                this_param)
                {
                    var return_v = this_param.PSSnapInName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 33714, 33739);
                    return return_v;
                }


                bool
                f_1352_33693_33740(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 33693, 33740);
                    return return_v;
                }


                string
                f_1352_33978_33999(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.PSSnapInName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 33978, 33999);
                    return return_v;
                }


                string
                f_1352_34030_34055(System.Management.Automation.PSSnapinQualifiedName
                this_param)
                {
                    var return_v = this_param.PSSnapInName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 34030, 34055);
                    return return_v;
                }


                bool
                f_1352_33934_34120(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 33934, 34120);
                    return return_v;
                }


                string
                f_1352_34193_34212(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 34193, 34212);
                    return return_v;
                }


                string
                f_1352_34243_34268(System.Management.Automation.PSSnapinQualifiedName
                this_param)
                {
                    var return_v = this_param.PSSnapInName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 34243, 34268);
                    return return_v;
                }


                bool
                f_1352_34149_34334(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 34149, 34334);
                    return return_v;
                }


                int
                f_1352_34384_34404(System.Collections.ObjectModel.Collection<System.Management.Automation.ProviderInfo>
                this_param, System.Management.Automation.ProviderInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 34384, 34404);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.ProviderInfo>
                f_1352_33871_33888_I(System.Collections.Generic.List<System.Management.Automation.ProviderInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 33871, 33888);
                    return return_v;
                }


                int
                f_1352_34606_34626(System.Collections.ObjectModel.Collection<System.Management.Automation.ProviderInfo>
                this_param, System.Management.Automation.ProviderInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 34606, 34626);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.ProviderInfo>
                f_1352_34547_34564_I(System.Collections.Generic.List<System.Management.Automation.ProviderInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 34547, 34564);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1352, 32167, 34702);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1352, 32167, 34702);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal IEnumerable<ProviderInfo> ProviderList
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1352, 34881, 35316);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 34917, 34982);

                    Collection<ProviderInfo>
                    result = f_1352_34951_34981()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 35002, 35267);
                        foreach (List<ProviderInfo> providerValues in f_1352_35048_35064_I(f_1352_35048_35064(f_1352_35048_35057())))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 35002, 35267);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 35106, 35248);
                                foreach (ProviderInfo provider in f_1352_35140_35154_I(providerValues))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 35106, 35248);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 35204, 35225);

                                    f_1352_35204_35224(result, provider);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 35106, 35248);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1352, 1, 143);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1352, 1, 143);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 35002, 35267);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1352, 1, 266);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1352, 1, 266);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 35287, 35301);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1352, 34881, 35316);

                    System.Collections.ObjectModel.Collection<System.Management.Automation.ProviderInfo>
                    f_1352_34951_34981()
                    {
                        var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.ProviderInfo>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 34951, 34981);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.ProviderInfo>>
                    f_1352_35048_35057()
                    {
                        var return_v = Providers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 35048, 35057);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.ProviderInfo>>.ValueCollection
                    f_1352_35048_35064(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.ProviderInfo>>
                    this_param)
                    {
                        var return_v = this_param.Values;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 35048, 35064);
                        return return_v;
                    }


                    int
                    f_1352_35204_35224(System.Collections.ObjectModel.Collection<System.Management.Automation.ProviderInfo>
                    this_param, System.Management.Automation.ProviderInfo
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 35204, 35224);
                        return 0;
                    }


                    System.Collections.Generic.List<System.Management.Automation.ProviderInfo>
                    f_1352_35140_35154_I(System.Collections.Generic.List<System.Management.Automation.ProviderInfo>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 35140, 35154);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.ProviderInfo>>.ValueCollection
                    f_1352_35048_35064_I(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.ProviderInfo>>.ValueCollection
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 35048, 35064);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1352, 34809, 35327);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1352, 34809, 35327);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal void CopyProviders(SessionStateInternal ss)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1352, 35538, 36002);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 35615, 35679) || true) && (ss == null || (DynAbs.Tracing.TraceSender.Expression_False(1352, 35619, 35653) || f_1352_35633_35645(ss) == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 35615, 35679);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 35672, 35679);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 35615, 35679);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 35769, 35827);

                _providers = f_1352_35782_35826();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 35843, 35991);
                    foreach (KeyValuePair<string, List<ProviderInfo>> e in f_1352_35898_35911_I(ss._providers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 35843, 35991);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 35945, 35976);

                        f_1352_35945_35975(_providers, e.Key, e.Value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 35843, 35991);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1352, 1, 149);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1352, 1, 149);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1352, 35538, 36002);

                System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.ProviderInfo>>
                f_1352_35633_35645(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.Providers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 35633, 35645);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.ProviderInfo>>
                f_1352_35782_35826()
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.ProviderInfo>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 35782, 35826);
                    return return_v;
                }


                int
                f_1352_35945_35975(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.ProviderInfo>>
                this_param, string
                key, System.Collections.Generic.List<System.Management.Automation.ProviderInfo>
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 35945, 35975);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.ProviderInfo>>
                f_1352_35898_35911_I(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.ProviderInfo>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 35898, 35911);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1352, 35538, 36002);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1352, 35538, 36002);
            }
        }

        internal void InitializeProvider(
                    Provider.CmdletProvider providerInstance,
                    ProviderInfo provider,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1352, 37385, 41062);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 37578, 37704) || true) && (provider == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 37578, 37704);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 37632, 37689);

                    throw f_1352_37638_37688("provider");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 37578, 37704);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 37720, 37847) || true) && (context == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 37720, 37847);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 37773, 37832);

                    context = f_1352_37783_37831(f_1352_37809_37830(this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 37720, 37847);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 37966, 38020);

                List<PSDriveInfo>
                newDrives = f_1352_37996_38019()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 38034, 38130);

                DriveCmdletProvider
                driveProvider =
                f_1352_38087_38129(providerInstance)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 38146, 39745) || true) && (driveProvider != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 38146, 39745);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 38249, 38329);

                        Collection<PSDriveInfo>
                        drives = f_1352_38282_38328(driveProvider, context)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 38351, 38566) || true) && (drives != null && (DynAbs.Tracing.TraceSender.Expression_True(1352, 38355, 38389) && f_1352_38373_38385(drives) > 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 38351, 38566);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 38439, 38466);

                            f_1352_38439_38465(newDrives, drives);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 38492, 38543);

                            f_1352_38492_38520()[provider] = f_1352_38533_38542(drives, 0);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 38351, 38566);
                        }
                    }
                    catch (LoopFlowException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1352, 38603, 38694);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 38669, 38675);

                        throw;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1352, 38603, 38694);
                    }
                    catch (PipelineStoppedException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1352, 38712, 38810);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 38785, 38791);

                        throw;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1352, 38712, 38810);
                    }
                    catch (ActionPreferenceStopException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1352, 38828, 38931);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 38906, 38912);

                        throw;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1352, 38828, 38931);
                    }
                    catch (Exception e) // Catch-all OK, 3rd party callout
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1352, 38949, 39730);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 39044, 39411);

                        ProviderInvocationException
                        providerException =
                        f_1352_39117_39410(this, "InitializeDefaultDrivesException", f_1352_39243_39295(), provider, string.Empty, e)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 39435, 39711);

                        f_1352_39435_39710(
                                            context, f_1352_39480_39709(providerException, "InitializeDefaultDrivesException", ErrorCategory.InvalidOperation, provider));
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1352, 38949, 39730);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 38146, 39745);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 39761, 41051) || true) && (newDrives != null && (DynAbs.Tracing.TraceSender.Expression_True(1352, 39765, 39805) && f_1352_39786_39801(newDrives) > 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 39761, 41051);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 39877, 41036);
                        foreach (PSDriveInfo newDrive in f_1352_39910_39919_I(newDrives))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 39877, 41036);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 39961, 40063) || true) && (newDrive == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 39961, 40063);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 40031, 40040);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 39961, 40063);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 40156, 40290) || true) && (!f_1352_40161_40208(provider, f_1352_40181_40207(f_1352_40181_40198(newDrive))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 40156, 40290);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 40258, 40267);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 40156, 40290);
                            }

                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 40366, 40465);

                                PSDriveInfo
                                validatedNewDrive = f_1352_40398_40464(this, driveProvider, newDrive, context, false)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 40493, 40819) || true) && (validatedNewDrive != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 40493, 40819);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 40752, 40792);

                                    f_1352_40752_40791(f_1352_40752_40763(), validatedNewDrive);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 40493, 40819);
                                }
                            }
                            catch (SessionStateException exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1352, 40864, 41017);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 40952, 40994);

                                f_1352_40952_40993(context, f_1352_40971_40992(exception));
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1352, 40864, 41017);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 39877, 41036);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1352, 1, 1160);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1352, 1, 1160);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 39761, 41051);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1352, 37385, 41062);

                System.Management.Automation.PSArgumentNullException
                f_1352_37638_37688(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 37638, 37688);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1352_37809_37830(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 37809, 37830);
                    return return_v;
                }


                System.Management.Automation.CmdletProviderContext
                f_1352_37783_37831(System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = new System.Management.Automation.CmdletProviderContext(executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 37783, 37831);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSDriveInfo>
                f_1352_37996_38019()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.PSDriveInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 37996, 38019);
                    return return_v;
                }


                System.Management.Automation.Provider.DriveCmdletProvider
                f_1352_38087_38129(System.Management.Automation.Provider.CmdletProvider
                providerInstance)
                {
                    var return_v = GetDriveProviderInstance(providerInstance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 38087, 38129);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSDriveInfo>
                f_1352_38282_38328(System.Management.Automation.Provider.DriveCmdletProvider
                this_param, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.InitializeDefaultDrives(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 38282, 38328);
                    return return_v;
                }


                int
                f_1352_38373_38385(System.Collections.ObjectModel.Collection<System.Management.Automation.PSDriveInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 38373, 38385);
                    return return_v;
                }


                int
                f_1352_38439_38465(System.Collections.Generic.List<System.Management.Automation.PSDriveInfo>
                this_param, System.Collections.ObjectModel.Collection<System.Management.Automation.PSDriveInfo>
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<System.Management.Automation.PSDriveInfo>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 38439, 38465);
                    return 0;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.ProviderInfo, System.Management.Automation.PSDriveInfo>
                f_1352_38492_38520()
                {
                    var return_v = ProvidersCurrentWorkingDrive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 38492, 38520);
                    return return_v;
                }


                System.Management.Automation.PSDriveInfo
                f_1352_38533_38542(System.Collections.ObjectModel.Collection<System.Management.Automation.PSDriveInfo>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 38533, 38542);
                    return return_v;
                }


                string
                f_1352_39243_39295()
                {
                    var return_v = SessionStateStrings.InitializeDefaultDrivesException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 39243, 39295);
                    return return_v;
                }


                System.Management.Automation.ProviderInvocationException
                f_1352_39117_39410(System.Management.Automation.SessionStateInternal
                this_param, string
                resourceId, string
                resourceStr, System.Management.Automation.ProviderInfo
                provider, string
                path, System.Exception
                e)
                {
                    var return_v = this_param.NewProviderInvocationException(resourceId, resourceStr, provider, path, e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 39117, 39410);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1352_39480_39709(System.Management.Automation.ProviderInvocationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.ProviderInfo
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 39480, 39709);
                    return return_v;
                }


                int
                f_1352_39435_39710(System.Management.Automation.CmdletProviderContext
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 39435, 39710);
                    return 0;
                }


                int
                f_1352_39786_39801(System.Collections.Generic.List<System.Management.Automation.PSDriveInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 39786, 39801);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_1352_40181_40198(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Provider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 40181, 40198);
                    return return_v;
                }


                string
                f_1352_40181_40207(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 40181, 40207);
                    return return_v;
                }


                bool
                f_1352_40161_40208(System.Management.Automation.ProviderInfo
                this_param, string
                providerName)
                {
                    var return_v = this_param.NameEquals(providerName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 40161, 40208);
                    return return_v;
                }


                System.Management.Automation.PSDriveInfo
                f_1352_40398_40464(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.Provider.DriveCmdletProvider
                driveProvider, System.Management.Automation.PSDriveInfo
                drive, System.Management.Automation.CmdletProviderContext
                context, bool
                resolvePathIfPossible)
                {
                    var return_v = this_param.ValidateDriveWithProvider(driveProvider, drive, context, resolvePathIfPossible);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 40398, 40464);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1352_40752_40763()
                {
                    var return_v = GlobalScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 40752, 40763);
                    return return_v;
                }


                int
                f_1352_40752_40791(System.Management.Automation.SessionStateScope
                this_param, System.Management.Automation.PSDriveInfo
                newDrive)
                {
                    this_param.NewDrive(newDrive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 40752, 40791);
                    return 0;
                }


                System.Management.Automation.ErrorRecord
                f_1352_40971_40992(System.Management.Automation.SessionStateException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 40971, 40992);
                    return return_v;
                }


                int
                f_1352_40952_40993(System.Management.Automation.CmdletProviderContext
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 40952, 40993);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.PSDriveInfo>
                f_1352_39910_39919_I(System.Collections.Generic.List<System.Management.Automation.PSDriveInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 39910, 39919);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1352, 37385, 41062);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1352, 37385, 41062);
            }
        }

        internal ProviderInfo NewProvider(ProviderInfo provider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1352, 41864, 48235);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 41945, 42071) || true) && (provider == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 41945, 42071);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 41999, 42056);

                    throw f_1352_42005_42055("provider");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 41945, 42071);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 42309, 42366);

                ProviderInfo
                existingProvider = f_1352_42341_42365(this, provider)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 42380, 43100) || true) && (existingProvider != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 42380, 43100);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 42523, 42636) || true) && (f_1352_42527_42560(existingProvider) == f_1352_42564_42589(provider))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 42523, 42636);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 42612, 42636);

                        return existingProvider;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 42523, 42636);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 42656, 43037);

                    SessionStateException
                    sessionStateException =
                    f_1352_42723_43036(f_1352_42775_42788(provider), SessionStateCategory.CmdletProvider, "CmdletProviderAlreadyExists", f_1352_42933_42980(), ErrorCategory.ResourceExists)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 43057, 43085);

                    throw sessionStateException;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 42380, 43100);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 43302, 43371);

                Provider.CmdletProvider
                providerInstance = f_1352_43345_43370(provider)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 43456, 43537);

                CmdletProviderContext
                context = f_1352_43488_43536(f_1352_43514_43535(this))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 43551, 43587);

                ProviderInfo
                newProviderInfo = null
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 43639, 43699);

                    newProviderInfo = f_1352_43657_43698(providerInstance, provider, context);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 43842, 43899);

                    f_1352_43842_43898(
                                    // Set the new provider info in the instance in case the provider
                                    // derived a new one

                                    providerInstance, newProviderInfo);
                }
                catch (LoopFlowException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1352, 43928, 44007);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 43986, 43992);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1352, 43928, 44007);
                }
                catch (PipelineStoppedException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1352, 44021, 44107);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 44086, 44092);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1352, 44021, 44107);
                }
                catch (ActionPreferenceStopException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1352, 44121, 44212);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 44191, 44197);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1352, 44121, 44212);
                }
                catch (InvalidOperationException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1352, 44226, 44313);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 44292, 44298);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1352, 44226, 44313);
                }
                catch (Exception e) // Catch-call OK, 3rd party callout
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1352, 44327, 44703);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 44415, 44688);

                    throw
                    f_1352_44442_44687(this, "ProviderStartException", f_1352_44550_44592(), provider, null, e);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1352, 44327, 44703);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 44719, 44760);

                f_1352_44719_44759(
                            context, true);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 44776, 44993) || true) && (newProviderInfo == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 44776, 44993);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 44837, 44978);

                    throw
                    f_1352_44864_44977(f_1352_44933_44976());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 44776, 44993);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 45009, 45611) || true) && (newProviderInfo != provider)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 45009, 45611);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 45198, 45495) || true) && (!f_1352_45203_45289(f_1352_45217_45237(newProviderInfo), f_1352_45239_45252(provider), StringComparison.OrdinalIgnoreCase))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 45198, 45495);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 45331, 45476);

                        throw
                        f_1352_45362_45475(f_1352_45435_45474());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 45198, 45495);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 45569, 45596);

                    provider = newProviderInfo;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 45009, 45611);
                }

                // Add the newly create provider to the providers container

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 45738, 45765);

                    f_1352_45738_45764(this, provider);
                }
                catch (ArgumentException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1352, 45794, 46296);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 45852, 46233);

                    SessionStateException
                    sessionStateException =
                    f_1352_45919_46232(f_1352_45971_45984(provider), SessionStateCategory.CmdletProvider, "CmdletProviderAlreadyExists", f_1352_46129_46176(), ErrorCategory.ResourceExists)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 46253, 46281);

                    throw sessionStateException;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1352, 45794, 46296);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 46485, 46534);

                f_1352_46485_46533(f_1352_46485_46513(), provider, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 46550, 46587);

                bool
                initializeProviderError = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 46746, 46802);

                    f_1352_46746_46801(this, providerInstance, provider, context);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 46820, 46861);

                    f_1352_46820_46860(context, true);
                }
                catch (LoopFlowException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1352, 46890, 46969);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 46948, 46954);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1352, 46890, 46969);
                }
                catch (PipelineStoppedException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1352, 46983, 47118);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 47048, 47079);

                    initializeProviderError = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 47097, 47103);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1352, 46983, 47118);
                }
                catch (ActionPreferenceStopException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1352, 47132, 47272);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 47202, 47233);

                    initializeProviderError = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 47251, 47257);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1352, 47132, 47272);
                }
                catch (NotSupportedException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1352, 47286, 47565);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 47518, 47550);

                    initializeProviderError = false;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1352, 47286, 47565);
                }
                catch (SessionStateException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1352, 47579, 47711);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 47641, 47672);

                    initializeProviderError = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 47690, 47696);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1352, 47579, 47711);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1352, 47725, 48149);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 47765, 48134) || true) && (initializeProviderError)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 47765, 48134);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 47966, 48009);

                        f_1352_47966_48008(f_1352_47966_47975(), f_1352_47983_48007(f_1352_47983_47996(provider)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 48031, 48077);

                        f_1352_48031_48076(f_1352_48031_48059(), provider);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 48099, 48115);

                        provider = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 47765, 48134);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1352, 47725, 48149);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 48208, 48224);

                return provider;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1352, 41864, 48235);

                System.Management.Automation.PSArgumentNullException
                f_1352_42005_42055(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 42005, 42055);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_1352_42341_42365(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.ProviderInfo
                provider)
                {
                    var return_v = this_param.ProviderExists(provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 42341, 42365);
                    return return_v;
                }


                System.Type
                f_1352_42527_42560(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.ImplementingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 42527, 42560);
                    return return_v;
                }


                System.Type
                f_1352_42564_42589(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.ImplementingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 42564, 42589);
                    return return_v;
                }


                string
                f_1352_42775_42788(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 42775, 42788);
                    return return_v;
                }


                string
                f_1352_42933_42980()
                {
                    var return_v = SessionStateStrings.CmdletProviderAlreadyExists;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 42933, 42980);
                    return return_v;
                }


                System.Management.Automation.SessionStateException
                f_1352_42723_43036(string
                itemName, System.Management.Automation.SessionStateCategory
                sessionStateCategory, string
                errorIdAndResourceId, string
                resourceStr, System.Management.Automation.ErrorCategory
                errorCategory, params object[]
                messageArgs)
                {
                    var return_v = new System.Management.Automation.SessionStateException(itemName, sessionStateCategory, errorIdAndResourceId, resourceStr, errorCategory, messageArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 42723, 43036);
                    return return_v;
                }


                System.Management.Automation.Provider.CmdletProvider
                f_1352_43345_43370(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.CreateInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 43345, 43370);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1352_43514_43535(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 43514, 43535);
                    return return_v;
                }


                System.Management.Automation.CmdletProviderContext
                f_1352_43488_43536(System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = new System.Management.Automation.CmdletProviderContext(executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 43488, 43536);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_1352_43657_43698(System.Management.Automation.Provider.CmdletProvider
                this_param, System.Management.Automation.ProviderInfo
                providerInfo, System.Management.Automation.CmdletProviderContext
                cmdletProviderContext)
                {
                    var return_v = this_param.Start(providerInfo, cmdletProviderContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 43657, 43698);
                    return return_v;
                }


                int
                f_1352_43842_43898(System.Management.Automation.Provider.CmdletProvider
                this_param, System.Management.Automation.ProviderInfo
                providerInfoToSet)
                {
                    this_param.SetProviderInformation(providerInfoToSet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 43842, 43898);
                    return 0;
                }


                string
                f_1352_44550_44592()
                {
                    var return_v = SessionStateStrings.ProviderStartException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 44550, 44592);
                    return return_v;
                }


                System.Management.Automation.ProviderInvocationException
                f_1352_44442_44687(System.Management.Automation.SessionStateInternal
                this_param, string
                resourceId, string
                resourceStr, System.Management.Automation.ProviderInfo
                provider, string
                path, System.Exception
                e)
                {
                    var return_v = this_param.NewProviderInvocationException(resourceId, resourceStr, provider, path, e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 44442, 44687);
                    return return_v;
                }


                int
                f_1352_44719_44759(System.Management.Automation.CmdletProviderContext
                this_param, bool
                wrapExceptionInProviderException)
                {
                    this_param.ThrowFirstErrorOrDoNothing(wrapExceptionInProviderException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 44719, 44759);
                    return 0;
                }


                string
                f_1352_44933_44976()
                {
                    var return_v = SessionStateStrings.InvalidProviderInfoNull;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 44933, 44976);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1352_44864_44977(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 44864, 44977);
                    return return_v;
                }


                string
                f_1352_45217_45237(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 45217, 45237);
                    return return_v;
                }


                string
                f_1352_45239_45252(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 45239, 45252);
                    return return_v;
                }


                bool
                f_1352_45203_45289(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 45203, 45289);
                    return return_v;
                }


                string
                f_1352_45435_45474()
                {
                    var return_v = SessionStateStrings.InvalidProviderInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 45435, 45474);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1352_45362_45475(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 45362, 45475);
                    return return_v;
                }


                int
                f_1352_45738_45764(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.ProviderInfo
                provider)
                {
                    this_param.NewProviderEntry(provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 45738, 45764);
                    return 0;
                }


                string
                f_1352_45971_45984(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 45971, 45984);
                    return return_v;
                }


                string
                f_1352_46129_46176()
                {
                    var return_v = SessionStateStrings.CmdletProviderAlreadyExists;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 46129, 46176);
                    return return_v;
                }


                System.Management.Automation.SessionStateException
                f_1352_45919_46232(string
                itemName, System.Management.Automation.SessionStateCategory
                sessionStateCategory, string
                errorIdAndResourceId, string
                resourceStr, System.Management.Automation.ErrorCategory
                errorCategory, params object[]
                messageArgs)
                {
                    var return_v = new System.Management.Automation.SessionStateException(itemName, sessionStateCategory, errorIdAndResourceId, resourceStr, errorCategory, messageArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 45919, 46232);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.ProviderInfo, System.Management.Automation.PSDriveInfo>
                f_1352_46485_46513()
                {
                    var return_v = ProvidersCurrentWorkingDrive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 46485, 46513);
                    return return_v;
                }


                int
                f_1352_46485_46533(System.Collections.Generic.Dictionary<System.Management.Automation.ProviderInfo, System.Management.Automation.PSDriveInfo>
                this_param, System.Management.Automation.ProviderInfo
                key, System.Management.Automation.PSDriveInfo
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 46485, 46533);
                    return 0;
                }


                int
                f_1352_46746_46801(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.Provider.CmdletProvider
                providerInstance, System.Management.Automation.ProviderInfo
                provider, System.Management.Automation.CmdletProviderContext
                context)
                {
                    this_param.InitializeProvider(providerInstance, provider, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 46746, 46801);
                    return 0;
                }


                int
                f_1352_46820_46860(System.Management.Automation.CmdletProviderContext
                this_param, bool
                wrapExceptionInProviderException)
                {
                    this_param.ThrowFirstErrorOrDoNothing(wrapExceptionInProviderException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 46820, 46860);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.ProviderInfo>>
                f_1352_47966_47975()
                {
                    var return_v = Providers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 47966, 47975);
                    return return_v;
                }


                string
                f_1352_47983_47996(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 47983, 47996);
                    return return_v;
                }


                string
                f_1352_47983_48007(string
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 47983, 48007);
                    return return_v;
                }


                bool
                f_1352_47966_48008(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.ProviderInfo>>
                this_param, string
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 47966, 48008);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.ProviderInfo, System.Management.Automation.PSDriveInfo>
                f_1352_48031_48059()
                {
                    var return_v = ProvidersCurrentWorkingDrive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 48031, 48059);
                    return return_v;
                }


                bool
                f_1352_48031_48076(System.Collections.Generic.Dictionary<System.Management.Automation.ProviderInfo, System.Management.Automation.PSDriveInfo>
                this_param, System.Management.Automation.ProviderInfo
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 48031, 48076);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1352, 41864, 48235);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1352, 41864, 48235);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ProviderInfo ProviderExists(ProviderInfo provider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1352, 48247, 48799);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 48330, 48374);

                List<ProviderInfo>
                matchingProviders = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 48390, 48760) || true) && (f_1352_48394_48453(f_1352_48394_48403(), f_1352_48416_48429(provider), out matchingProviders))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 48390, 48760);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 48487, 48745);
                        foreach (ProviderInfo possibleMatch in f_1352_48526_48543_I(matchingProviders))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 48487, 48745);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 48585, 48726) || true) && (f_1352_48589_48632(provider, f_1352_48609_48631(possibleMatch)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 48585, 48726);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 48682, 48703);

                                return possibleMatch;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 48585, 48726);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 48487, 48745);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1352, 1, 259);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1352, 1, 259);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 48390, 48760);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 48776, 48788);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1352, 48247, 48799);

                System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.ProviderInfo>>
                f_1352_48394_48403()
                {
                    var return_v = Providers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 48394, 48403);
                    return return_v;
                }


                string
                f_1352_48416_48429(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 48416, 48429);
                    return return_v;
                }


                bool
                f_1352_48394_48453(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.ProviderInfo>>
                this_param, string
                key, out System.Collections.Generic.List<System.Management.Automation.ProviderInfo>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 48394, 48453);
                    return return_v;
                }


                string
                f_1352_48609_48631(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 48609, 48631);
                    return return_v;
                }


                bool
                f_1352_48589_48632(System.Management.Automation.ProviderInfo
                this_param, string
                providerName)
                {
                    var return_v = this_param.NameEquals(providerName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 48589, 48632);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.ProviderInfo>
                f_1352_48526_48543_I(System.Collections.Generic.List<System.Management.Automation.ProviderInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 48526, 48543);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1352, 48247, 48799);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1352, 48247, 48799);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void NewProviderEntry(ProviderInfo provider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1352, 49195, 50902);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 49272, 49305);

                bool
                isDuplicateProvider = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 49391, 50763) || true) && (!f_1352_49396_49432(f_1352_49396_49405(), f_1352_49418_49431(provider)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 49391, 50763);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 49466, 49521);

                    f_1352_49466_49520(f_1352_49466_49475(), f_1352_49480_49493(provider), f_1352_49495_49519());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 49391, 50763);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 49391, 50763);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 49680, 49744);

                    List<ProviderInfo>
                    existingProviders = f_1352_49719_49743(f_1352_49719_49728(), f_1352_49729_49742(provider))
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 49764, 50748);
                        foreach (ProviderInfo existingProvider in f_1352_49806_49823_I(existingProviders))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 49764, 50748);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 50021, 50729) || true) && (f_1352_50025_50068(f_1352_50046_50067(provider)) && (DynAbs.Tracing.TraceSender.Expression_True(1352, 50025, 50245) && (f_1352_50073_50160(f_1352_50087_50108(existingProvider), f_1352_50110_50123(provider), StringComparison.OrdinalIgnoreCase) && (DynAbs.Tracing.TraceSender.Expression_True(1352, 50073, 50244) && (f_1352_50190_50243(f_1352_50190_50216(existingProvider), f_1352_50224_50242(provider)))))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 50021, 50729);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 50295, 50322);

                                isDuplicateProvider = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 50021, 50729);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 50021, 50729);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 50522, 50729) || true) && (f_1352_50526_50629(f_1352_50540_50569(existingProvider), f_1352_50571_50592(provider), StringComparison.OrdinalIgnoreCase))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 50522, 50729);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 50679, 50706);

                                    isDuplicateProvider = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 50522, 50729);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 50021, 50729);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 49764, 50748);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1352, 1, 985);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1352, 1, 985);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 49391, 50763);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 50779, 50891) || true) && (!isDuplicateProvider)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 50779, 50891);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 50837, 50876);

                    f_1352_50837_50875(f_1352_50837_50861(f_1352_50837_50846(), f_1352_50847_50860(provider)), provider);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 50779, 50891);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1352, 49195, 50902);

                System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.ProviderInfo>>
                f_1352_49396_49405()
                {
                    var return_v = Providers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 49396, 49405);
                    return return_v;
                }


                string
                f_1352_49418_49431(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 49418, 49431);
                    return return_v;
                }


                bool
                f_1352_49396_49432(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.ProviderInfo>>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 49396, 49432);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.ProviderInfo>>
                f_1352_49466_49475()
                {
                    var return_v = Providers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 49466, 49475);
                    return return_v;
                }


                string
                f_1352_49480_49493(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 49480, 49493);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.ProviderInfo>
                f_1352_49495_49519()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.ProviderInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 49495, 49519);
                    return return_v;
                }


                int
                f_1352_49466_49520(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.ProviderInfo>>
                this_param, string
                key, System.Collections.Generic.List<System.Management.Automation.ProviderInfo>
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 49466, 49520);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.ProviderInfo>>
                f_1352_49719_49728()
                {
                    var return_v = Providers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 49719, 49728);
                    return return_v;
                }


                string
                f_1352_49729_49742(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 49729, 49742);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.ProviderInfo>
                f_1352_49719_49743(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.ProviderInfo>>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 49719, 49743);
                    return return_v;
                }


                string
                f_1352_50046_50067(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.PSSnapInName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 50046, 50067);
                    return return_v;
                }


                bool
                f_1352_50025_50068(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 50025, 50068);
                    return return_v;
                }


                string
                f_1352_50087_50108(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 50087, 50108);
                    return return_v;
                }


                string
                f_1352_50110_50123(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 50110, 50123);
                    return return_v;
                }


                bool
                f_1352_50073_50160(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 50073, 50160);
                    return return_v;
                }


                System.Type
                f_1352_50190_50216(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 50190, 50216);
                    return return_v;
                }


                System.Type
                f_1352_50224_50242(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 50224, 50242);
                    return return_v;
                }


                bool
                f_1352_50190_50243(System.Type
                this_param, System.Type
                o)
                {
                    var return_v = this_param.Equals(o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 50190, 50243);
                    return return_v;
                }


                string
                f_1352_50540_50569(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.PSSnapInName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 50540, 50569);
                    return return_v;
                }


                string
                f_1352_50571_50592(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.PSSnapInName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 50571, 50592);
                    return return_v;
                }


                bool
                f_1352_50526_50629(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 50526, 50629);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.ProviderInfo>
                f_1352_49806_49823_I(System.Collections.Generic.List<System.Management.Automation.ProviderInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 49806, 49823);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.ProviderInfo>>
                f_1352_50837_50846()
                {
                    var return_v = Providers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 50837, 50846);
                    return return_v;
                }


                string
                f_1352_50847_50860(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 50847, 50860);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.ProviderInfo>
                f_1352_50837_50861(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.ProviderInfo>>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 50837, 50861);
                    return return_v;
                }


                int
                f_1352_50837_50875(System.Collections.Generic.List<System.Management.Automation.ProviderInfo>
                this_param, System.Management.Automation.ProviderInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 50837, 50875);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1352, 49195, 50902);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1352, 49195, 50902);
            }
        }

        internal void RemoveProvider(
                    string providerName,
                    bool force,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1352, 52782, 57965);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 52939, 53063) || true) && (context == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 52939, 53063);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 52992, 53048);

                    throw f_1352_52998_53047("context");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 52939, 53063);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 53079, 53223) || true) && (f_1352_53083_53117(providerName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 53079, 53223);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 53151, 53208);

                    throw f_1352_53157_53207("providerName");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 53079, 53223);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 53239, 53259);

                bool
                errors = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 53275, 53304);

                ProviderInfo
                provider = null
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 53356, 53399);

                    provider = f_1352_53367_53398(this, providerName);
                }
                catch (ProviderNotFoundException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1352, 53428, 53516);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 53494, 53501);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1352, 53428, 53516);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 53649, 53718);

                    Provider.CmdletProvider
                    providerBase = f_1352_53688_53717(this, provider)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 53738, 56777) || true) && (providerBase == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 53738, 56777);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 53804, 54074);

                        ProviderNotFoundException
                        e = f_1352_53834_54073(providerName, SessionStateCategory.CmdletProvider, "ProviderNotFound", f_1352_54036_54072())
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 54096, 54150);

                        f_1352_54096_54149(context, f_1352_54115_54148(f_1352_54131_54144(e), e));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 54174, 54188);

                        errors = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 53738, 56777);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 53738, 56777);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 54349, 54368);

                        int
                        driveCount = 0
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 54390, 54678);
                            foreach (PSDriveInfo drive in f_1352_54420_54454_I(f_1352_54420_54454(this, providerName)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 54390, 54678);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 54504, 54655) || true) && (drive != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 54504, 54655);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 54579, 54592);

                                    ++driveCount;
                                    DynAbs.Tracing.TraceSender.TraceBreak(1352, 54622, 54628);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 54504, 54655);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 54390, 54678);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1352, 1, 289);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1352, 1, 289);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 54702, 56105) || true) && (driveCount > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 54702, 56105);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 54770, 56082) || true) && (force)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 54770, 56082);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 54904, 55222);
                                    foreach (PSDriveInfo drive in f_1352_54934_54968_I(f_1352_54934_54968(this, providerName)))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 54904, 55222);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 55034, 55191) || true) && (drive != null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 55034, 55191);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 55125, 55156);

                                            f_1352_55125_55155(this, drive, true, null);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 55034, 55191);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 54904, 55222);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1352, 1, 319);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1352, 1, 319);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 54770, 56082);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 54770, 56082);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 55336, 55350);

                                errors = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 55537, 55932);

                                SessionStateException
                                e = f_1352_55563_55931(providerName, SessionStateCategory.CmdletProvider, "RemoveDrivesBeforeRemovingProvider", f_1352_55811_55865(), ErrorCategory.InvalidOperation)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 55962, 56016);

                                f_1352_55962_56015(context, f_1352_55981_56014(f_1352_55997_56010(e), e));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 56048, 56055);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 54770, 56082);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 54702, 56105);
                        }

                        // Now tell the provider that they are going to be removed by
                        // calling the Stop method

                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 56314, 56341);

                            f_1352_56314_56340(providerBase, context);
                        }
                        catch (LoopFlowException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1352, 56386, 56489);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 56460, 56466);

                            throw;
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1352, 56386, 56489);
                        }
                        catch (PipelineStoppedException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1352, 56511, 56621);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 56592, 56598);

                            throw;
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1352, 56511, 56621);
                        }
                        catch (ActionPreferenceStopException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1352, 56643, 56758);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 56729, 56735);

                            throw;
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1352, 56643, 56758);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 53738, 56777);
                    }
                }
                catch (LoopFlowException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1352, 56806, 56885);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 56864, 56870);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1352, 56806, 56885);
                }
                catch (PipelineStoppedException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1352, 56899, 56985);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 56964, 56970);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1352, 56899, 56985);
                }
                catch (ActionPreferenceStopException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1352, 56999, 57090);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 57069, 57075);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1352, 56999, 57090);
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1352, 57104, 57447);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 57156, 57170);

                    errors = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 57188, 57432);

                    f_1352_57188_57431(context, f_1352_57229_57430(e, "RemoveProviderUnexpectedException", ErrorCategory.InvalidArgument, providerName));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1352, 57104, 57447);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1352, 57461, 57954);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 57501, 57939) || true) && (force || (DynAbs.Tracing.TraceSender.Expression_False(1352, 57505, 57521) || !errors))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 57501, 57939);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 57620, 57789);

                        f_1352_57620_57788(f_1352_57679_57700(this), providerName, ProviderState.Stopped);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 57813, 57852);

                        f_1352_57813_57851(this, provider);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 57874, 57920);

                        f_1352_57874_57919(f_1352_57874_57902(), provider);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 57501, 57939);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1352, 57461, 57954);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1352, 52782, 57965);

                System.Management.Automation.PSArgumentNullException
                f_1352_52998_53047(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 52998, 53047);
                    return return_v;
                }


                bool
                f_1352_53083_53117(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 53083, 53117);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1352_53157_53207(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 53157, 53207);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_1352_53367_53398(System.Management.Automation.SessionStateInternal
                this_param, string
                name)
                {
                    var return_v = this_param.GetSingleProvider(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 53367, 53398);
                    return return_v;
                }


                System.Management.Automation.Provider.CmdletProvider
                f_1352_53688_53717(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.ProviderInfo
                provider)
                {
                    var return_v = this_param.GetProviderInstance(provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 53688, 53717);
                    return return_v;
                }


                string
                f_1352_54036_54072()
                {
                    var return_v = SessionStateStrings.ProviderNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 54036, 54072);
                    return return_v;
                }


                System.Management.Automation.ProviderNotFoundException
                f_1352_53834_54073(string
                itemName, System.Management.Automation.SessionStateCategory
                sessionStateCategory, string
                errorIdAndResourceId, string
                resourceStr, params object[]
                messageArgs)
                {
                    var return_v = new System.Management.Automation.ProviderNotFoundException(itemName, sessionStateCategory, errorIdAndResourceId, resourceStr, messageArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 53834, 54073);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1352_54131_54144(System.Management.Automation.ProviderNotFoundException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 54131, 54144);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1352_54115_54148(System.Management.Automation.ErrorRecord
                errorRecord, System.Management.Automation.ProviderNotFoundException
                replaceParentContainsErrorRecordException)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(errorRecord, (System.Exception)replaceParentContainsErrorRecordException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 54115, 54148);
                    return return_v;
                }


                int
                f_1352_54096_54149(System.Management.Automation.CmdletProviderContext
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 54096, 54149);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSDriveInfo>
                f_1352_54420_54454(System.Management.Automation.SessionStateInternal
                this_param, string
                providerId)
                {
                    var return_v = this_param.GetDrivesForProvider(providerId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 54420, 54454);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSDriveInfo>
                f_1352_54420_54454_I(System.Collections.ObjectModel.Collection<System.Management.Automation.PSDriveInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 54420, 54454);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSDriveInfo>
                f_1352_54934_54968(System.Management.Automation.SessionStateInternal
                this_param, string
                providerId)
                {
                    var return_v = this_param.GetDrivesForProvider(providerId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 54934, 54968);
                    return return_v;
                }


                int
                f_1352_55125_55155(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.PSDriveInfo
                drive, bool
                force, string
                scopeID)
                {
                    this_param.RemoveDrive(drive, force, scopeID);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 55125, 55155);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSDriveInfo>
                f_1352_54934_54968_I(System.Collections.ObjectModel.Collection<System.Management.Automation.PSDriveInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 54934, 54968);
                    return return_v;
                }


                string
                f_1352_55811_55865()
                {
                    var return_v = SessionStateStrings.RemoveDrivesBeforeRemovingProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 55811, 55865);
                    return return_v;
                }


                System.Management.Automation.SessionStateException
                f_1352_55563_55931(string
                itemName, System.Management.Automation.SessionStateCategory
                sessionStateCategory, string
                errorIdAndResourceId, string
                resourceStr, System.Management.Automation.ErrorCategory
                errorCategory, params object[]
                messageArgs)
                {
                    var return_v = new System.Management.Automation.SessionStateException(itemName, sessionStateCategory, errorIdAndResourceId, resourceStr, errorCategory, messageArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 55563, 55931);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1352_55997_56010(System.Management.Automation.SessionStateException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 55997, 56010);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1352_55981_56014(System.Management.Automation.ErrorRecord
                errorRecord, System.Management.Automation.SessionStateException
                replaceParentContainsErrorRecordException)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(errorRecord, (System.Exception)replaceParentContainsErrorRecordException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 55981, 56014);
                    return return_v;
                }


                int
                f_1352_55962_56015(System.Management.Automation.CmdletProviderContext
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 55962, 56015);
                    return 0;
                }


                int
                f_1352_56314_56340(System.Management.Automation.Provider.CmdletProvider
                this_param, System.Management.Automation.CmdletProviderContext
                cmdletProviderContext)
                {
                    this_param.Stop(cmdletProviderContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 56314, 56340);
                    return 0;
                }


                System.Management.Automation.ErrorRecord
                f_1352_57229_57430(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, string
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 57229, 57430);
                    return return_v;
                }


                int
                f_1352_57188_57431(System.Management.Automation.CmdletProviderContext
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 57188, 57431);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1352_57679_57700(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 57679, 57700);
                    return return_v;
                }


                int
                f_1352_57620_57788(System.Management.Automation.ExecutionContext
                executionContext, string
                providerName, System.Management.Automation.ProviderState
                providerState)
                {
                    MshLog.LogProviderLifecycleEvent(executionContext, providerName, providerState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 57620, 57788);
                    return 0;
                }


                int
                f_1352_57813_57851(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.ProviderInfo
                provider)
                {
                    this_param.RemoveProviderFromCollection(provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 57813, 57851);
                    return 0;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.ProviderInfo, System.Management.Automation.PSDriveInfo>
                f_1352_57874_57902()
                {
                    var return_v = ProvidersCurrentWorkingDrive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 57874, 57902);
                    return return_v;
                }


                bool
                f_1352_57874_57919(System.Collections.Generic.Dictionary<System.Management.Automation.ProviderInfo, System.Management.Automation.PSDriveInfo>
                this_param, System.Management.Automation.ProviderInfo
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 57874, 57919);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1352, 52782, 57965);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1352, 52782, 57965);
            }
        }

        private void RemoveProviderFromCollection(ProviderInfo provider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1352, 58476, 59056);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 58565, 58602);

                List<ProviderInfo>
                matchingProviders
                = default(List<ProviderInfo>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 58616, 59045) || true) && (f_1352_58620_58679(f_1352_58620_58629(), f_1352_58642_58655(provider), out matchingProviders))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 58616, 59045);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 58713, 59030) || true) && (f_1352_58717_58740(matchingProviders) == 1 && (DynAbs.Tracing.TraceSender.Expression_True(1352, 58717, 58820) && f_1352_58770_58820(f_1352_58770_58790(matchingProviders, 0), f_1352_58802_58819(provider))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 58713, 59030);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 58862, 58894);

                        f_1352_58862_58893(f_1352_58862_58871(), f_1352_58879_58892(provider));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 58713, 59030);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 58713, 59030);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 58976, 59011);

                        f_1352_58976_59010(matchingProviders, provider);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 58713, 59030);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 58616, 59045);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1352, 58476, 59056);

                System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.ProviderInfo>>
                f_1352_58620_58629()
                {
                    var return_v = Providers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 58620, 58629);
                    return return_v;
                }


                string
                f_1352_58642_58655(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 58642, 58655);
                    return return_v;
                }


                bool
                f_1352_58620_58679(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.ProviderInfo>>
                this_param, string
                key, out System.Collections.Generic.List<System.Management.Automation.ProviderInfo>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 58620, 58679);
                    return return_v;
                }


                int
                f_1352_58717_58740(System.Collections.Generic.List<System.Management.Automation.ProviderInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 58717, 58740);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_1352_58770_58790(System.Collections.Generic.List<System.Management.Automation.ProviderInfo>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 58770, 58790);
                    return return_v;
                }


                string
                f_1352_58802_58819(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 58802, 58819);
                    return return_v;
                }


                bool
                f_1352_58770_58820(System.Management.Automation.ProviderInfo
                this_param, string
                providerName)
                {
                    var return_v = this_param.NameEquals(providerName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 58770, 58820);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.ProviderInfo>>
                f_1352_58862_58871()
                {
                    var return_v = Providers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 58862, 58871);
                    return return_v;
                }


                string
                f_1352_58879_58892(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 58879, 58892);
                    return return_v;
                }


                bool
                f_1352_58862_58893(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.ProviderInfo>>
                this_param, string
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 58862, 58893);
                    return return_v;
                }


                bool
                f_1352_58976_59010(System.Collections.Generic.List<System.Management.Automation.ProviderInfo>
                this_param, System.Management.Automation.ProviderInfo
                item)
                {
                    var return_v = this_param.Remove(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 58976, 59010);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1352, 58476, 59056);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1352, 58476, 59056);
            }
        }

        internal int ProviderCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1352, 59273, 59548);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 59309, 59323);

                    int
                    count = 0
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 59341, 59500);
                        foreach (List<ProviderInfo> matchingProviders in f_1352_59390_59406_I(f_1352_59390_59406(f_1352_59390_59399())))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1352, 59341, 59500);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 59448, 59481);

                            count += f_1352_59457_59480(matchingProviders);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1352, 59341, 59500);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1352, 1, 160);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1352, 1, 160);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 59520, 59533);

                    return count;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1352, 59273, 59548);

                    System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.ProviderInfo>>
                    f_1352_59390_59399()
                    {
                        var return_v = Providers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 59390, 59399);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.ProviderInfo>>.ValueCollection
                    f_1352_59390_59406(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.ProviderInfo>>
                    this_param)
                    {
                        var return_v = this_param.Values;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 59390, 59406);
                        return return_v;
                    }


                    int
                    f_1352_59457_59480(System.Collections.Generic.List<System.Management.Automation.ProviderInfo>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1352, 59457, 59480);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.ProviderInfo>>.ValueCollection
                    f_1352_59390_59406_I(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.ProviderInfo>>.ValueCollection
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 59390, 59406);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1352, 59222, 59559);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1352, 59222, 59559);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }
    }
}

#pragma warning restore 56500
