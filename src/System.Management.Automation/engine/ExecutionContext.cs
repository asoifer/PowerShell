// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Management.Automation.Host;
using System.Management.Automation.Internal;
using System.Management.Automation.Internal.Host;
using System.Management.Automation.Language;
using System.Management.Automation.Runspaces;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

using Microsoft.PowerShell;
using Microsoft.PowerShell.Commands.Internal.Format;

namespace System.Management.Automation
{
    internal class ExecutionContext
    {
        internal PSLocalEventManager Events { get; private set; }

        internal HashSet<string> AutoLoadingModuleInProgress { get; }

        internal ScriptDebugger Debugger
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 1467, 1492);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 1473, 1490);

                    return _debugger;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 1467, 1492);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 1410, 1503);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 1410, 1503);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal ScriptDebugger _debugger;

        internal int _debuggingMode;

        internal void ResetManagers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 1758, 2275);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 1812, 1908) || true) && (_debugger != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 1812, 1908);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 1867, 1893);

                    f_1273_1867_1892(_debugger);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 1812, 1908);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 1924, 2008) || true) && (f_1273_1928_1934() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 1924, 2008);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 1976, 1993);

                    f_1273_1976_1992(f_1273_1976_1982());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 1924, 2008);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 2024, 2063);

                Events = f_1273_2033_2062(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 2077, 2195) || true) && (this.transactionManager != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 2077, 2195);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 2146, 2180);

                    f_1273_2146_2179(this.transactionManager);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 2077, 2195);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 2211, 2264);

                this.transactionManager = f_1273_2237_2263();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 1758, 2275);

                int
                f_1273_1867_1892(System.Management.Automation.ScriptDebugger
                this_param)
                {
                    this_param.ResetDebugger();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 1867, 1892);
                    return 0;
                }


                System.Management.Automation.PSLocalEventManager
                f_1273_1928_1934()
                {
                    var return_v = Events;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 1928, 1934);
                    return return_v;
                }


                System.Management.Automation.PSLocalEventManager
                f_1273_1976_1982()
                {
                    var return_v = Events;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 1976, 1982);
                    return return_v;
                }


                int
                f_1273_1976_1992(System.Management.Automation.PSLocalEventManager
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 1976, 1992);
                    return 0;
                }


                System.Management.Automation.PSLocalEventManager
                f_1273_2033_2062(System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new System.Management.Automation.PSLocalEventManager(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 2033, 2062);
                    return return_v;
                }


                int
                f_1273_2146_2179(System.Management.Automation.Internal.PSTransactionManager
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 2146, 2179);
                    return 0;
                }


                System.Management.Automation.Internal.PSTransactionManager
                f_1273_2237_2263()
                {
                    var return_v = new System.Management.Automation.Internal.PSTransactionManager();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 2237, 2263);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 1758, 2275);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 1758, 2275);
            }
        }

        internal int PSDebugTraceLevel
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 2522, 2698);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 2635, 2683);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1273, 2642, 2659) || ((f_1273_2642_2659() && DynAbs.Tracing.TraceSender.Conditional_F2(1273, 2662, 2663)) || DynAbs.Tracing.TraceSender.Conditional_F3(1273, 2666, 2682))) ? 0 : _debugTraceLevel;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 2522, 2698);

                    bool
                    f_1273_2642_2659()
                    {
                        var return_v = IgnoreScriptDebug;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 2642, 2659);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 2467, 2758);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 2467, 2758);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 2714, 2747);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 2720, 2745);

                    _debugTraceLevel = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 2714, 2747);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 2467, 2758);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 2467, 2758);
                }
            }
        }

        private int _debugTraceLevel;

        internal bool PSDebugTraceStep
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 3046, 3219);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 3159, 3204);

                    return f_1273_3166_3184_M(!IgnoreScriptDebug) && (DynAbs.Tracing.TraceSender.Expression_True(1273, 3166, 3203) && _debugTraceStep);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 3046, 3219);

                    bool
                    f_1273_3166_3184_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 3166, 3184);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 2991, 3278);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 2991, 3278);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 3235, 3267);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 3241, 3265);

                    _debugTraceStep = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 3235, 3267);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 2991, 3278);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 2991, 3278);
                }
            }
        }

        private bool _debugTraceStep;

        internal static bool IsStrictVersion(ExecutionContext context, int majorVersion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1273, 3411, 3785);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 3516, 3637) || true) && (context == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 3516, 3637);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 3569, 3622);

                    context = f_1273_3579_3621();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 3516, 3637);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 3653, 3774);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1273, 3660, 3677) || (((context != null)
                && DynAbs.Tracing.TraceSender.Conditional_F2(1273, 3704, 3741)) || DynAbs.Tracing.TraceSender.Conditional_F3(1273, 3768, 3773))) ? f_1273_3704_3741(context, majorVersion) : false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1273, 3411, 3785);

                System.Management.Automation.ExecutionContext
                f_1273_3579_3621()
                {
                    var return_v = LocalPipeline.GetExecutionContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 3579, 3621);
                    return return_v;
                }


                bool
                f_1273_3704_3741(System.Management.Automation.ExecutionContext
                this_param, int
                majorVersion)
                {
                    var return_v = this_param.IsStrictVersion(majorVersion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 3704, 3741);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 3411, 3785);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 3411, 3785);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsStrictVersion(int majorVersion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 4143, 5126);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 4215, 4273);

                SessionStateScope
                scope = f_1273_4241_4272(f_1273_4241_4259())
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 4287, 5037) || true) && (scope != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 4287, 5037);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 4450, 4777) || true) && (f_1273_4454_4477(scope) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 4450, 4777);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 4703, 4758);

                            return (f_1273_4711_4740(f_1273_4711_4734(scope)) >= majorVersion);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 4450, 4777);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 4871, 4981) || true) && (scope == f_1273_4884_4914(f_1273_4884_4902()))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 4871, 4981);
                            DynAbs.Tracing.TraceSender.TraceBreak(1273, 4956, 4962);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 4871, 4981);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 5001, 5022);

                        scope = f_1273_5009_5021(scope);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 4287, 5037);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1273, 4287, 5037);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1273, 4287, 5037);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 5102, 5115);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 4143, 5126);

                System.Management.Automation.SessionStateInternal
                f_1273_4241_4259()
                {
                    var return_v = EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 4241, 4259);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1273_4241_4272(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 4241, 4272);
                    return return_v;
                }


                System.Version
                f_1273_4454_4477(System.Management.Automation.SessionStateScope
                this_param)
                {
                    var return_v = this_param.StrictModeVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 4454, 4477);
                    return return_v;
                }


                System.Version
                f_1273_4711_4734(System.Management.Automation.SessionStateScope
                this_param)
                {
                    var return_v = this_param.StrictModeVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 4711, 4734);
                    return return_v;
                }


                int
                f_1273_4711_4740(System.Version
                this_param)
                {
                    var return_v = this_param.Major;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 4711, 4740);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1273_4884_4902()
                {
                    var return_v = EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 4884, 4902);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1273_4884_4914(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ModuleScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 4884, 4914);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1273_5009_5021(System.Management.Automation.SessionStateScope
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 5009, 5021);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 4143, 5126);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 4143, 5126);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool ShouldTraceStatement
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 5329, 5528);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 5442, 5513);

                    return f_1273_5449_5467_M(!IgnoreScriptDebug) && (DynAbs.Tracing.TraceSender.Expression_True(1273, 5449, 5512) && (_debugTraceLevel > 0 || (DynAbs.Tracing.TraceSender.Expression_False(1273, 5472, 5511) || _debugTraceStep)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 5329, 5528);

                    bool
                    f_1273_5449_5467_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 5449, 5467);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 5270, 5539);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 5270, 5539);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool ScriptCommandProcessorShouldRethrowExit { get; set; }

        internal bool IgnoreScriptDebug { set; get; }

        internal AutomationEngine Engine { get; private set; }

        internal InitialSessionState InitialSessionState { get; }

        internal string PreviousModuleProcessed { get; set; }

        internal Hashtable previousModuleImported { get; set; }

        internal string ModuleBeingProcessed { get; set; }

        private bool _responsibilityForModuleAnalysisAppDomainOwned;

        internal bool TakeResponsibilityForModuleAnalysisAppDomain()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 7450, 7867);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 7535, 7647) || true) && (_responsibilityForModuleAnalysisAppDomainOwned)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 7535, 7647);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 7619, 7632);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 7535, 7647);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 7663, 7762);

                f_1273_7663_7761(f_1273_7682_7708() == null, "Invalid module analysis app domain state");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 7776, 7830);

                _responsibilityForModuleAnalysisAppDomainOwned = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 7844, 7856);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 7450, 7867);

                System.AppDomain
                f_1273_7682_7708()
                {
                    var return_v = AppDomainForModuleAnalysis;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 7682, 7708);
                    return return_v;
                }


                int
                f_1273_7663_7761(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 7663, 7761);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 7450, 7867);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 7450, 7867);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void ReleaseResponsibilityForModuleAnalysisAppDomain()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 7879, 8360);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 7967, 8078);

                f_1273_7967_8077(_responsibilityForModuleAnalysisAppDomainOwned, "Invalid module analysis app domain state");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 8094, 8278) || true) && (f_1273_8098_8124() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 8094, 8278);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 8166, 8211);

                    f_1273_8166_8210(f_1273_8183_8209());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 8229, 8263);

                    AppDomainForModuleAnalysis = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 8094, 8278);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 8294, 8349);

                _responsibilityForModuleAnalysisAppDomainOwned = false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 7879, 8360);

                int
                f_1273_7967_8077(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 7967, 8077);
                    return 0;
                }


                System.AppDomain
                f_1273_8098_8124()
                {
                    var return_v = AppDomainForModuleAnalysis;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 8098, 8124);
                    return return_v;
                }


                System.AppDomain
                f_1273_8183_8209()
                {
                    var return_v = AppDomainForModuleAnalysis;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 8183, 8209);
                    return return_v;
                }


                int
                f_1273_8166_8210(System.AppDomain
                domain)
                {
                    AppDomain.Unload(domain);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 8166, 8210);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 7879, 8360);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 7879, 8360);
            }
        }

        internal AppDomain AppDomainForModuleAnalysis { get; set; }

        internal AuthorizationManager AuthorizationManager { get; private set; }

        internal ProviderNames ProviderNames
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 9207, 9435);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 9243, 9378) || true) && (_providerNames == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 9243, 9378);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 9311, 9359);

                        _providerNames = f_1273_9328_9358();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 9243, 9378);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 9398, 9420);

                    return _providerNames;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 9207, 9435);

                    System.Management.Automation.SingleShellProviderNames
                    f_1273_9328_9358()
                    {
                        var return_v = new System.Management.Automation.SingleShellProviderNames();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 9328, 9358);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 9146, 9446);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 9146, 9446);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ProviderNames _providerNames;

        internal ModuleIntrinsics Modules { get; private set; }

        internal string ShellID
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 9821, 10591);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 9857, 10540) || true) && (_shellId == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 9857, 10540);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 10090, 10521) || true) && (f_1273_10094_10114() is PSAuthorizationManager && (DynAbs.Tracing.TraceSender.Expression_True(1273, 10094, 10195) && !f_1273_10145_10195(f_1273_10166_10194(f_1273_10166_10186()))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 10090, 10521);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 10245, 10285);

                            _shellId = f_1273_10256_10284(f_1273_10256_10276());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 10090, 10521);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 10090, 10521);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 10456, 10498);

                            _shellId = Utils.DefaultPowerShellShellID;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 10090, 10521);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 9857, 10540);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 10560, 10576);

                    return _shellId;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 9821, 10591);

                    System.Management.Automation.AuthorizationManager
                    f_1273_10094_10114()
                    {
                        var return_v = AuthorizationManager;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 10094, 10114);
                        return return_v;
                    }


                    System.Management.Automation.AuthorizationManager
                    f_1273_10166_10186()
                    {
                        var return_v = AuthorizationManager;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 10166, 10186);
                        return return_v;
                    }


                    string
                    f_1273_10166_10194(System.Management.Automation.AuthorizationManager
                    this_param)
                    {
                        var return_v = this_param.ShellId;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 10166, 10194);
                        return return_v;
                    }


                    bool
                    f_1273_10145_10195(string
                    value)
                    {
                        var return_v = string.IsNullOrEmpty(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 10145, 10195);
                        return return_v;
                    }


                    System.Management.Automation.AuthorizationManager
                    f_1273_10256_10276()
                    {
                        var return_v = AuthorizationManager;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 10256, 10276);
                        return return_v;
                    }


                    string
                    f_1273_10256_10284(System.Management.Automation.AuthorizationManager
                    this_param)
                    {
                        var return_v = this_param.ShellId;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 10256, 10284);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 9773, 10602);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 9773, 10602);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private string _shellId;

        internal SessionStateInternal EngineSessionState { get; set; }

        internal SessionStateInternal TopLevelSessionState { get; private set; }

        internal SessionState SessionState
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 11245, 11341);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 11281, 11326);

                    return f_1273_11288_11325(f_1273_11288_11306());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 11245, 11341);

                    System.Management.Automation.SessionStateInternal
                    f_1273_11288_11306()
                    {
                        var return_v = EngineSessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 11288, 11306);
                        return return_v;
                    }


                    System.Management.Automation.SessionState
                    f_1273_11288_11325(System.Management.Automation.SessionStateInternal
                    this_param)
                    {
                        var return_v = this_param.PublicSessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 11288, 11325);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 11186, 11352);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 11186, 11352);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal PSLanguageMode LanguageMode
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 11537, 11609);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 11573, 11594);

                    return _languageMode;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 11537, 11609);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 11476, 14421);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 11476, 14421);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 11625, 14410);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 11828, 14159) || true) && (value == PSLanguageMode.ConstrainedLanguage)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 11828, 14159);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 11917, 11967);

                        HasRunspaceEverUsedConstrainedLanguageMode = true;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 12695, 14140) || true) && (f_1273_12699_12747_M(!ExecutionContext.HasEverUsedConstrainedLanguage))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 12695, 14140);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 12803, 12813);
                            lock (lockObject)
                            {

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 13084, 14090) || true) && (f_1273_13088_13136_M(!ExecutionContext.HasEverUsedConstrainedLanguage))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 13084, 14090);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 13202, 13238);

                                    f_1273_13202_13237();
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 13272, 13311);

                                    f_1273_13272_13310();
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 13345, 13379);

                                    f_1273_13345_13378();
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 13413, 13455);

                                    f_1273_13413_13454();
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 13489, 13524);

                                    f_1273_13489_13523();
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 13558, 13593);

                                    f_1273_13558_13592();
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 13627, 13668);

                                    f_1273_13627_13667();
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 13908, 13970);

                                    UntrustedObjects = f_1273_13927_13969();
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 14004, 14059);

                                    ExecutionContext.HasEverUsedConstrainedLanguage = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 13084, 14090);
                                }
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 12695, 14140);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 11828, 14159);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 14309, 14353);

                    f_1273_14309_14352();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 14373, 14395);

                    _languageMode = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 11625, 14410);

                    bool
                    f_1273_12699_12747_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 12699, 12747);
                        return return_v;
                    }


                    bool
                    f_1273_13088_13136_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 13088, 13136);
                        return return_v;
                    }


                    int
                    f_1273_13202_13237()
                    {
                        PSSetMemberBinder.InvalidateCache();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 13202, 13237);
                        return 0;
                    }


                    int
                    f_1273_13272_13310()
                    {
                        PSInvokeMemberBinder.InvalidateCache();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 13272, 13310);
                        return 0;
                    }


                    int
                    f_1273_13345_13378()
                    {
                        PSConvertBinder.InvalidateCache();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 13345, 13378);
                        return 0;
                    }


                    int
                    f_1273_13413_13454()
                    {
                        PSBinaryOperationBinder.InvalidateCache();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 13413, 13454);
                        return 0;
                    }


                    int
                    f_1273_13489_13523()
                    {
                        PSGetIndexBinder.InvalidateCache();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 13489, 13523);
                        return 0;
                    }


                    int
                    f_1273_13558_13592()
                    {
                        PSSetIndexBinder.InvalidateCache();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 13558, 13592);
                        return 0;
                    }


                    int
                    f_1273_13627_13667()
                    {
                        PSCreateInstanceBinder.InvalidateCache();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 13627, 13667);
                        return 0;
                    }


                    System.Runtime.CompilerServices.ConditionalWeakTable<object, object>
                    f_1273_13927_13969()
                    {
                        var return_v = new System.Runtime.CompilerServices.ConditionalWeakTable<object, object>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 13927, 13969);
                        return return_v;
                    }


                    int
                    f_1273_14309_14352()
                    {
                        LanguagePrimitives.RebuildConversionCache();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 14309, 14352);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 11476, 14421);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 11476, 14421);
                }
            }
        }

        private PSLanguageMode _languageMode;

        internal bool HasRunspaceEverUsedConstrainedLanguageMode { get; private set; }

        internal bool LanguageModeTransitionInParameterBinding { get; set; }

        internal static bool HasEverUsedConstrainedLanguage { get; private set; }

        private static ConditionalWeakTable<object, object> UntrustedObjects { get; set; }

        internal static bool IsMarkedAsUntrusted(object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1273, 15768, 16169);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 15847, 15867);

                bool
                result = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 15881, 15918);

                var
                baseValue = f_1273_15897_15917(value)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 15932, 16128) || true) && (baseValue != null && (DynAbs.Tracing.TraceSender.Expression_True(1273, 15936, 15986) && baseValue != f_1273_15970_15986()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 15932, 16128);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 16020, 16034);

                    object
                    unused
                    = default(object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 16052, 16113);

                    result = f_1273_16061_16112(f_1273_16061_16077(), baseValue, out unused);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 15932, 16128);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 16144, 16158);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1273, 15768, 16169);

                object
                f_1273_15897_15917(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 15897, 15917);
                    return return_v;
                }


                System.Management.Automation.Language.NullString
                f_1273_15970_15986()
                {
                    var return_v = NullString.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 15970, 15986);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConditionalWeakTable<object, object>
                f_1273_16061_16077()
                {
                    var return_v = UntrustedObjects;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 16061, 16077);
                    return return_v;
                }


                bool
                f_1273_16061_16112(System.Runtime.CompilerServices.ConditionalWeakTable<object, object>
                this_param, object
                key, out object
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 16061, 16112);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 15768, 16169);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 15768, 16169);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void MarkObjectAsUntrusted(object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1273, 16282, 17623);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 16446, 16483);

                var
                baseValue = f_1273_16462_16482(value)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 16497, 17612) || true) && (baseValue != null && (DynAbs.Tracing.TraceSender.Expression_True(1273, 16501, 16551) && baseValue != f_1273_16535_16551()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 16497, 17612);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 16671, 16721);

                    f_1273_16671_16720(f_1273_16671_16687(), baseValue, key => null);

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 17234, 17271);

                        var
                        psRef = baseValue as PSReference
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 17293, 17455) || true) && (psRef != null && (DynAbs.Tracing.TraceSender.Expression_True(1273, 17297, 17347) && !f_1273_17315_17347(f_1273_17335_17346(psRef))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 17293, 17455);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 17397, 17432);

                            f_1273_17397_17431(f_1273_17419_17430(psRef));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 17293, 17455);
                        }
                    }
                    catch
                    { /* psRef.Value may call PSVariable.Value under the hood, which may throw arbitrary exception */
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1273, 17492, 17597);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1273, 17492, 17597);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 16497, 17612);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1273, 16282, 17623);

                object
                f_1273_16462_16482(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 16462, 16482);
                    return return_v;
                }


                System.Management.Automation.Language.NullString
                f_1273_16535_16551()
                {
                    var return_v = NullString.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 16535, 16551);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConditionalWeakTable<object, object>
                f_1273_16671_16687()
                {
                    var return_v =                 // It's actually setting a key value pair when the key doesn't exist
                                    UntrustedObjects;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 16671, 16687);
                    return return_v;
                }


                object
                f_1273_16671_16720(System.Runtime.CompilerServices.ConditionalWeakTable<object, object>
                this_param, object
                key, System.Runtime.CompilerServices.ConditionalWeakTable<object, object>.CreateValueCallback
                createValueCallback)
                {
                    var return_v = this_param.GetValue(key, createValueCallback);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 16671, 16720);
                    return return_v;
                }


                object
                f_1273_17335_17346(System.Management.Automation.PSReference
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 17335, 17346);
                    return return_v;
                }


                bool
                f_1273_17315_17347(object
                value)
                {
                    var return_v = IsMarkedAsUntrusted(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 17315, 17347);
                    return return_v;
                }


                object
                f_1273_17419_17430(System.Management.Automation.PSReference
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 17419, 17430);
                    return return_v;
                }


                int
                f_1273_17397_17431(object
                value)
                {
                    MarkObjectAsUntrusted(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 17397, 17431);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 16282, 17623);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 16282, 17623);
            }
        }

        internal static void MarkObjectAsUntrustedForVariableAssignment(PSVariable variable, SessionStateScope scope, SessionStateInternal sessionState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1273, 18318, 19406);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 18487, 19395) || true) && (f_1273_18491_18503(scope) == null || (DynAbs.Tracing.TraceSender.Expression_False(1273, 18491, 18706) || (f_1273_18566_18585(sessionState) != null && (DynAbs.Tracing.TraceSender.Expression_True(1273, 18566, 18674) && f_1273_18648_18665(scope) == scope) && (DynAbs.Tracing.TraceSender.Expression_True(1273, 18566, 18705) && f_1273_18678_18697(f_1273_18678_18690(scope)) == null))))
                ) // it's the module's script scope (scope.Parent is global scope and scope.ScriptScope points to itself)

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 18487, 19395);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 19342, 19380);

                    f_1273_19342_19379(f_1273_19364_19378(variable));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 18487, 19395);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1273, 18318, 19406);

                System.Management.Automation.SessionStateScope
                f_1273_18491_18503(System.Management.Automation.SessionStateScope
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 18491, 18503);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1273_18566_18585(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 18566, 18585);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1273_18648_18665(System.Management.Automation.SessionStateScope
                this_param)
                {
                    var return_v = this_param.ScriptScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 18648, 18665);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1273_18678_18690(System.Management.Automation.SessionStateScope
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 18678, 18690);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1273_18678_18697(System.Management.Automation.SessionStateScope
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 18678, 18697);
                    return return_v;
                }


                object
                f_1273_19364_19378(System.Management.Automation.PSVariable
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 19364, 19378);
                    return return_v;
                }


                int
                f_1273_19342_19379(object
                value)
                {
                    MarkObjectAsUntrusted(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 19342, 19379);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 18318, 19406);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 18318, 19406);
            }
        }

        internal static void PropagateInputSource(object originalObject, object resultObject, PSLanguageMode currentLanguageMode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1273, 19668, 20189);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 19949, 20178) || true) && (f_1273_19953_20000() && (DynAbs.Tracing.TraceSender.Expression_True(1273, 19953, 20054) && currentLanguageMode == PSLanguageMode.FullLanguage) && (DynAbs.Tracing.TraceSender.Expression_True(1273, 19953, 20093) && f_1273_20058_20093(originalObject)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 19949, 20178);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 20127, 20163);

                    f_1273_20127_20162(resultObject);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 19949, 20178);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1273, 19668, 20189);

                bool
                f_1273_19953_20000()
                {
                    var return_v = ExecutionContext.HasEverUsedConstrainedLanguage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 19953, 20000);
                    return return_v;
                }


                bool
                f_1273_20058_20093(object
                value)
                {
                    var return_v = IsMarkedAsUntrusted(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 20058, 20093);
                    return return_v;
                }


                int
                f_1273_20127_20162(object
                value)
                {
                    MarkObjectAsUntrusted(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 20127, 20162);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 19668, 20189);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 19668, 20189);
            }
        }

        internal bool UseFullLanguageModeInDebugger
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 20460, 20606);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 20496, 20591);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1273, 20503, 20530) || ((f_1273_20503_20522() != null && DynAbs.Tracing.TraceSender.Conditional_F2(1273, 20533, 20582)) || DynAbs.Tracing.TraceSender.Conditional_F3(1273, 20585, 20590))) ? f_1273_20533_20582(f_1273_20533_20552()) : false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 20460, 20606);

                    System.Management.Automation.Runspaces.InitialSessionState
                    f_1273_20503_20522()
                    {
                        var return_v = InitialSessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 20503, 20522);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.InitialSessionState
                    f_1273_20533_20552()
                    {
                        var return_v = InitialSessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 20533, 20552);
                        return return_v;
                    }


                    bool
                    f_1273_20533_20582(System.Management.Automation.Runspaces.InitialSessionState
                    this_param)
                    {
                        var return_v = this_param.UseFullLanguageModeInDebugger;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 20533, 20582);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 20392, 20617);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 20392, 20617);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static List<string> ModulesWithJobSourceAdapters;

        internal bool IsModuleWithJobSourceAdapterLoaded
        {
            get; set;
        }

        internal LocationGlobber LocationGlobber
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 21247, 21398);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 21283, 21341);

                    _locationGlobber = f_1273_21302_21340(f_1273_21322_21339(this));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 21359, 21383);

                    return _locationGlobber;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 21247, 21398);

                    System.Management.Automation.SessionState
                    f_1273_21322_21339(System.Management.Automation.ExecutionContext
                    this_param)
                    {
                        var return_v = this_param.SessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 21322, 21339);
                        return return_v;
                    }


                    System.Management.Automation.LocationGlobber
                    f_1273_21302_21340(System.Management.Automation.SessionState
                    sessionState)
                    {
                        var return_v = new System.Management.Automation.LocationGlobber(sessionState);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 21302, 21340);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 21182, 21409);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 21182, 21409);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private LocationGlobber _locationGlobber;

        internal Dictionary<string, Assembly> AssemblyCache { get; private set; }

        internal EngineState EngineState { get; set; }

        internal object GetVariableValue(VariablePath path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 22114, 22356);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 22190, 22220);

                CmdletProviderContext
                context
                = default(CmdletProviderContext);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 22234, 22258);

                SessionStateScope
                scope
                = default(SessionStateScope);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 22272, 22345);

                return f_1273_22279_22344(f_1273_22279_22297(), path, out context, out scope);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 22114, 22356);

                System.Management.Automation.SessionStateInternal
                f_1273_22279_22297()
                {
                    var return_v = EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 22279, 22297);
                    return return_v;
                }


                object
                f_1273_22279_22344(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.VariablePath
                variablePath, out System.Management.Automation.CmdletProviderContext
                context, out System.Management.Automation.SessionStateScope
                scope)
                {
                    var return_v = this_param.GetVariableValue(variablePath, out context, out scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 22279, 22344);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 22114, 22356);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 22114, 22356);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal object GetVariableValue(VariablePath path, object defaultValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 22613, 22892);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 22710, 22740);

                CmdletProviderContext
                context
                = default(CmdletProviderContext);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 22754, 22778);

                SessionStateScope
                scope
                = default(SessionStateScope);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 22792, 22881);

                return f_1273_22799_22864(f_1273_22799_22817(), path, out context, out scope) ?? (DynAbs.Tracing.TraceSender.Expression_Null<object>(1273, 22799, 22880) ?? defaultValue);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 22613, 22892);

                System.Management.Automation.SessionStateInternal
                f_1273_22799_22817()
                {
                    var return_v = EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 22799, 22817);
                    return return_v;
                }


                object
                f_1273_22799_22864(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.VariablePath
                variablePath, out System.Management.Automation.CmdletProviderContext
                context, out System.Management.Automation.SessionStateScope
                scope)
                {
                    var return_v = this_param.GetVariableValue(variablePath, out context, out scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 22799, 22864);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 22613, 22892);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 22613, 22892);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void SetVariable(VariablePath path, object newValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 22997, 23171);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 23083, 23160);

                f_1273_23083_23159(f_1273_23083_23101(), path, newValue, true, CommandOrigin.Internal);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 22997, 23171);

                System.Management.Automation.SessionStateInternal
                f_1273_23083_23101()
                {
                    var return_v = EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 23083, 23101);
                    return return_v;
                }


                object
                f_1273_23083_23159(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.VariablePath
                variablePath, object
                newValue, bool
                asValue, System.Management.Automation.CommandOrigin
                origin)
                {
                    var return_v = this_param.SetVariable(variablePath, newValue, asValue, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 23083, 23159);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 22997, 23171);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 22997, 23171);
            }
        }

        internal T GetEnumPreference<T>(VariablePath preferenceVariablePath, T defaultPref, out bool defaultUsed)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 23183, 24960);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 23313, 23400);

                object
                val = f_1273_23326_23399(f_1273_23326_23344(), preferenceVariablePath, out _, out _)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 23414, 23795) || true) && (val is T)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 23414, 23795);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 23460, 23652) || true) && (val is ActionPreference actionPreferenceValue)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 23460, 23652);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 23551, 23633);

                        f_1273_23551_23632(this, preferenceVariablePath, actionPreferenceValue, defaultPref);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 23460, 23652);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 23672, 23699);

                    T
                    convertedResult = (T)val
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 23719, 23739);

                    defaultUsed = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 23757, 23780);

                    return convertedResult;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 23414, 23795);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 23811, 23830);

                defaultUsed = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 23844, 23867);

                T
                result = defaultPref
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 23883, 24919) || true) && (val != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 23883, 24919);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 23976, 24009);

                        string
                        valString = val as string
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 24031, 24397) || true) && (valString != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 24031, 24397);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 24102, 24153);

                            result = (T)f_1273_24114_24152(typeof(T), valString, true);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 24179, 24199);

                            defaultUsed = false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 24031, 24397);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 24031, 24397);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 24297, 24328);

                            result = (T)f_1273_24309_24327(val);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 24354, 24374);

                            defaultUsed = false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 24031, 24397);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 24421, 24628) || true) && (result is ActionPreference actionPreferenceValue)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 24421, 24628);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 24523, 24605);

                            f_1273_24523_24604(this, preferenceVariablePath, actionPreferenceValue, defaultPref);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 24421, 24628);
                        }
                    }
                    catch (InvalidCastException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1273, 24665, 24777);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1273, 24665, 24777);
                        // default value is used
                    }
                    catch (ArgumentException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1273, 24795, 24904);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1273, 24795, 24904);
                        // default value is used
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 23883, 24919);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 24935, 24949);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 23183, 24960);

                System.Management.Automation.SessionStateInternal
                f_1273_23326_23344()
                {
                    var return_v = EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 23326, 23344);
                    return return_v;
                }


                object
                f_1273_23326_23399(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.VariablePath
                variablePath, out System.Management.Automation.CmdletProviderContext
                context, out System.Management.Automation.SessionStateScope
                scope)
                {
                    var return_v = this_param.GetVariableValue(variablePath, out context, out scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 23326, 23399);
                    return return_v;
                }


                int
                f_1273_23551_23632(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.VariablePath
                preferenceVariablePath, System.Management.Automation.ActionPreference
                preference, T
                defaultValue)
                {
                    this_param.CheckActionPreference(preferenceVariablePath, preference, (object)defaultValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 23551, 23632);
                    return 0;
                }


                object
                f_1273_24114_24152(System.Type
                enumType, string
                value, bool
                ignoreCase)
                {
                    var return_v = Enum.Parse(enumType, value, ignoreCase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 24114, 24152);
                    return return_v;
                }


                object
                f_1273_24309_24327(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 24309, 24327);
                    return return_v;
                }


                int
                f_1273_24523_24604(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.VariablePath
                preferenceVariablePath, System.Management.Automation.ActionPreference
                preference, T
                defaultValue)
                {
                    this_param.CheckActionPreference(preferenceVariablePath, preference, (object)defaultValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 24523, 24604);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 23183, 24960);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 23183, 24960);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void CheckActionPreference(VariablePath preferenceVariablePath, ActionPreference preference, object defaultValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 24972, 25687);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 25118, 25676) || true) && (preference == ActionPreference.Suspend)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 25118, 25676);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 25339, 25485);

                    string
                    message = f_1273_25356_25484(f_1273_25374_25424(), preference, f_1273_25438_25469(preferenceVariablePath), defaultValue)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 25503, 25602);

                    f_1273_25503_25601(f_1273_25503_25521(), preferenceVariablePath, defaultValue, true, CommandOrigin.Internal);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 25620, 25661);

                    throw f_1273_25626_25660(message);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 25118, 25676);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 24972, 25687);

                string
                f_1273_25374_25424()
                {
                    var return_v = ErrorPackage.ReservedActionPreferenceReplacedError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 25374, 25424);
                    return return_v;
                }


                string
                f_1273_25438_25469(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.UserPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 25438, 25469);
                    return return_v;
                }


                string
                f_1273_25356_25484(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 25356, 25484);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1273_25503_25521()
                {
                    var return_v = EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 25503, 25521);
                    return return_v;
                }


                object
                f_1273_25503_25601(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.VariablePath
                variablePath, object
                newValue, bool
                asValue, System.Management.Automation.CommandOrigin
                origin)
                {
                    var return_v = this_param.SetVariable(variablePath, newValue, asValue, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 25503, 25601);
                    return return_v;
                }


                System.NotSupportedException
                f_1273_25626_25660(string
                message)
                {
                    var return_v = new System.NotSupportedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 25626, 25660);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 24972, 25687);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 24972, 25687);
            }
        }

        internal bool GetBooleanPreference(VariablePath preferenceVariablePath, bool defaultPref, out bool defaultUsed)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 25998, 26683);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 26134, 26171);

                CmdletProviderContext
                context = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 26185, 26216);

                SessionStateScope
                scope = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 26230, 26327);

                object
                val = f_1273_26243_26326(f_1273_26243_26261(), preferenceVariablePath, out context, out scope)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 26341, 26461) || true) && (val == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 26341, 26461);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 26390, 26409);

                    defaultUsed = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 26427, 26446);

                    return defaultPref;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 26341, 26461);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 26477, 26506);

                bool
                converted = defaultPref
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 26520, 26611);

                defaultUsed = !f_1273_26535_26610(val, out converted);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 26625, 26672);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1273, 26632, 26645) || (((defaultUsed) && DynAbs.Tracing.TraceSender.Conditional_F2(1273, 26648, 26659)) || DynAbs.Tracing.TraceSender.Conditional_F3(1273, 26662, 26671))) ? defaultPref : converted;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 25998, 26683);

                System.Management.Automation.SessionStateInternal
                f_1273_26243_26261()
                {
                    var return_v = EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 26243, 26261);
                    return return_v;
                }


                object
                f_1273_26243_26326(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.VariablePath
                variablePath, out System.Management.Automation.CmdletProviderContext
                context, out System.Management.Automation.SessionStateScope
                scope)
                {
                    var return_v = this_param.GetVariableValue(variablePath, out context, out scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 26243, 26326);
                    return return_v;
                }


                bool
                f_1273_26535_26610(object
                valueToConvert, out bool
                result)
                {
                    var return_v = LanguagePrimitives.TryConvertTo<bool>(valueToConvert, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 26535, 26610);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 25998, 26683);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 25998, 26683);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal HelpSystem HelpSystem
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 26949, 27016);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 26955, 27014);

                    return _helpSystem ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.HelpSystem>(1273, 26962, 27013) ?? (_helpSystem = f_1273_26992_27012(this)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 26949, 27016);

                    System.Management.Automation.HelpSystem
                    f_1273_26992_27012(System.Management.Automation.ExecutionContext
                    context)
                    {
                        var return_v = new System.Management.Automation.HelpSystem(context);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 26992, 27012);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 26894, 27027);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 26894, 27027);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private HelpSystem _helpSystem;

        internal object FormatInfo { get; set; }

        internal Dictionary<string, ScriptBlock> CustomArgumentCompleters { get; set; }

        internal Dictionary<string, ScriptBlock> NativeArgumentCompleters { get; set; }

        internal CommandProcessorBase CreateCommand(string command, bool dotSource)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 27704, 28418);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 27804, 27883);

                CommandOrigin
                commandOrigin = f_1273_27834_27882(f_1273_27834_27870(f_1273_27834_27857(this)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 27897, 28030);

                CommandProcessorBase
                commandProcessor =
                f_1273_27954_28029(f_1273_27954_27970(), command, commandOrigin, !dotSource)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 28168, 28367) || true) && (commandProcessor != null && (DynAbs.Tracing.TraceSender.Expression_True(1273, 28172, 28246) && commandProcessor is ScriptCommandProcessorBase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 28168, 28367);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 28280, 28352);

                    f_1273_28280_28304(commandProcessor).CommandOriginInternal = CommandOrigin.Internal;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 28168, 28367);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 28383, 28407);

                return commandProcessor;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 27704, 28418);

                System.Management.Automation.SessionStateInternal
                f_1273_27834_27857(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 27834, 27857);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1273_27834_27870(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 27834, 27870);
                    return return_v;
                }


                System.Management.Automation.CommandOrigin
                f_1273_27834_27882(System.Management.Automation.SessionStateScope
                this_param)
                {
                    var return_v = this_param.ScopeOrigin;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 27834, 27882);
                    return return_v;
                }


                System.Management.Automation.CommandDiscovery
                f_1273_27954_27970()
                {
                    var return_v = CommandDiscovery;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 27954, 27970);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1273_27954_28029(System.Management.Automation.CommandDiscovery
                this_param, string
                commandName, System.Management.Automation.CommandOrigin
                commandOrigin, bool
                useLocalScope)
                {
                    var return_v = this_param.LookupCommandProcessor(commandName, commandOrigin, (bool?)useLocalScope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 27954, 28029);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1273_28280_28304(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 28280, 28304);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 27704, 28418);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 27704, 28418);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal CommandProcessorBase CurrentCommandProcessor { get; set; }

        internal CommandDiscovery CommandDiscovery
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 28888, 28970);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 28924, 28955);

                    return f_1273_28931_28954(f_1273_28931_28937());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 28888, 28970);

                    System.Management.Automation.AutomationEngine
                    f_1273_28931_28937()
                    {
                        var return_v = Engine;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 28931, 28937);
                        return return_v;
                    }


                    System.Management.Automation.CommandDiscovery
                    f_1273_28931_28954(System.Management.Automation.AutomationEngine
                    this_param)
                    {
                        var return_v = this_param.CommandDiscovery;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 28931, 28954);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 28821, 28981);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 28821, 28981);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal InternalHost EngineHostInterface
        {            // set not provided: it's not meaningful to change the host post-construction.
            get; private set;
        }

        internal InternalHost InternalHost
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 29648, 29683);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 29654, 29681);

                    return f_1273_29661_29680();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 29648, 29683);

                    System.Management.Automation.Internal.Host.InternalHost
                    f_1273_29661_29680()
                    {
                        var return_v = EngineHostInterface;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 29661, 29680);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 29589, 29694);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 29589, 29694);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal EngineIntrinsics EngineIntrinsics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 29877, 29962);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 29883, 29960);

                    return _engineIntrinsics ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.EngineIntrinsics>(1273, 29890, 29959) ?? (_engineIntrinsics = f_1273_29932_29958(this)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 29877, 29962);

                    System.Management.Automation.EngineIntrinsics
                    f_1273_29932_29958(System.Management.Automation.ExecutionContext
                    context)
                    {
                        var return_v = new System.Management.Automation.EngineIntrinsics(context);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 29932, 29958);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 29810, 29973);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 29810, 29973);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private EngineIntrinsics _engineIntrinsics;

        internal LogContextCache LogContextCache { get; }

        internal PipelineWriter ExternalSuccessOutput { get; set; }

        internal PipelineWriter ExternalErrorOutput { get; set; }

        internal PipelineWriter ExternalProgressOutput { get; set; }
        internal class SavedContextData
        {
            private bool _stepScript;

            private bool _ignoreScriptDebug;

            private int _PSDebug;

            private Pipe _shellFunctionErrorOutputPipe;

            public SavedContextData(ExecutionContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1273, 31082, 31427);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 30914, 30925);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 30953, 30971);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 30998, 31006);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 31036, 31065);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 31164, 31203);

                    _stepScript = f_1273_31178_31202(context);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 31221, 31268);

                    _ignoreScriptDebug = f_1273_31242_31267(context);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 31286, 31323);

                    _PSDebug = f_1273_31297_31322(context);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 31343, 31412);

                    _shellFunctionErrorOutputPipe = f_1273_31375_31411(context);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1273, 31082, 31427);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 31082, 31427);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 31082, 31427);
                }
            }

            public void RestoreContextData(ExecutionContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 31443, 31795);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 31532, 31571);

                    context.PSDebugTraceStep = _stepScript;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 31589, 31636);

                    context.IgnoreScriptDebug = _ignoreScriptDebug;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 31654, 31691);

                    context.PSDebugTraceLevel = _PSDebug;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 31711, 31780);

                    context.ShellFunctionErrorOutputPipe = _shellFunctionErrorOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 31443, 31795);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 31443, 31795);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 31443, 31795);
                }
            }

            static SavedContextData()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1273, 30845, 31806);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1273, 30845, 31806);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 30845, 31806);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1273, 30845, 31806);

            bool
            f_1273_31178_31202(System.Management.Automation.ExecutionContext
            this_param)
            {
                var return_v = this_param.PSDebugTraceStep;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 31178, 31202);
                return return_v;
            }


            bool
            f_1273_31242_31267(System.Management.Automation.ExecutionContext
            this_param)
            {
                var return_v = this_param.IgnoreScriptDebug;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 31242, 31267);
                return return_v;
            }


            int
            f_1273_31297_31322(System.Management.Automation.ExecutionContext
            this_param)
            {
                var return_v = this_param.PSDebugTraceLevel;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 31297, 31322);
                return return_v;
            }


            System.Management.Automation.Internal.Pipe
            f_1273_31375_31411(System.Management.Automation.ExecutionContext
            this_param)
            {
                var return_v = this_param.ShellFunctionErrorOutputPipe;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 31375, 31411);
                return return_v;
            }

        }

        internal SavedContextData SaveContextData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 31979, 32092);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 32047, 32081);

                return f_1273_32054_32080(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 31979, 32092);

                System.Management.Automation.ExecutionContext.SavedContextData
                f_1273_32054_32080(System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new System.Management.Automation.ExecutionContext.SavedContextData(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 32054, 32080);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 31979, 32092);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 31979, 32092);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void ResetShellFunctionErrorOutputPipe()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 32104, 32225);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 32178, 32214);

                ShellFunctionErrorOutputPipe = null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 32104, 32225);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 32104, 32225);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 32104, 32225);
            }
        }

        internal Pipe RedirectErrorPipe(Pipe newPipe)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 32237, 32444);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 32307, 32351);

                Pipe
                oldPipe = f_1273_32322_32350()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 32365, 32404);

                ShellFunctionErrorOutputPipe = newPipe;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 32418, 32433);

                return oldPipe;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 32237, 32444);

                System.Management.Automation.Internal.Pipe
                f_1273_32322_32350()
                {
                    var return_v = ShellFunctionErrorOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 32322, 32350);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 32237, 32444);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 32237, 32444);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void RestoreErrorPipe(Pipe pipe)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 32456, 32569);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 32522, 32558);

                ShellFunctionErrorOutputPipe = pipe;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 32456, 32569);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 32456, 32569);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 32456, 32569);
            }
        }

        internal void ResetRedirection()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 32772, 32876);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 32829, 32865);

                ShellFunctionErrorOutputPipe = null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 32772, 32876);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 32772, 32876);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 32772, 32876);
            }
        }

        internal Pipe ShellFunctionErrorOutputPipe { get; set; }

        internal Pipe ExpressionWarningOutputPipe { get; set; }

        internal Pipe ExpressionVerboseOutputPipe { get; set; }

        internal Pipe ExpressionDebugOutputPipe { get; set; }

        internal Pipe ExpressionInformationOutputPipe { get; set; }

        internal void AppendDollarError(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 34470, 36107);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 34538, 34588);

                ErrorRecord
                objAsErrorRecord = obj as ErrorRecord
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 34602, 34855) || true) && (objAsErrorRecord == null && (DynAbs.Tracing.TraceSender.Expression_True(1273, 34606, 34653) && !(obj is Exception)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 34602, 34855);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 34687, 34815);

                    f_1273_34687_34814(false, "Object to append was neither an ErrorRecord nor an Exception in ExecutionContext.AppendDollarError");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 34833, 34840);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 34602, 34855);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 34871, 34909);

                object
                old = f_1273_34884_34908(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 34923, 34962);

                ArrayList
                arraylist = old as ArrayList
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 34976, 35145) || true) && (arraylist == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 34976, 35145);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 35031, 35105);

                    f_1273_35031_35104(false, "$error should be a global constant ArrayList");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 35123, 35130);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 34976, 35145);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 35215, 35761) || true) && (f_1273_35219_35234(arraylist) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 35215, 35761);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 35407, 35460) || true) && (f_1273_35411_35423(arraylist, 0) == obj)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 35407, 35460);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 35453, 35460);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 35407, 35460);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 35560, 35606);

                    ErrorRecord
                    er1 = f_1273_35578_35590(arraylist, 0) as ErrorRecord
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 35626, 35746) || true) && (er1 != null && (DynAbs.Tracing.TraceSender.Expression_True(1273, 35630, 35669) && objAsErrorRecord != null) && (DynAbs.Tracing.TraceSender.Expression_True(1273, 35630, 35716) && f_1273_35673_35686(er1) == f_1273_35690_35716(objAsErrorRecord)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 35626, 35746);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 35739, 35746);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 35626, 35746);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 35215, 35761);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 35777, 35807);

                const int
                maxErrorCount = 256
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 35823, 35878);

                int
                numToErase = f_1273_35840_35855(arraylist) - (maxErrorCount - 1)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 35892, 36055) || true) && (0 < numToErase)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 35892, 36055);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 35944, 36040);

                    f_1273_35944_36039(arraylist, maxErrorCount - 1, numToErase);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 35892, 36055);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 36071, 36096);

                f_1273_36071_36095(
                            arraylist, 0, obj);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 34470, 36107);

                int
                f_1273_34687_34814(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 34687, 34814);
                    return 0;
                }


                object
                f_1273_34884_34908(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.DollarErrorVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 34884, 34908);
                    return return_v;
                }


                int
                f_1273_35031_35104(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 35031, 35104);
                    return 0;
                }


                int
                f_1273_35219_35234(System.Collections.ArrayList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 35219, 35234);
                    return return_v;
                }


                object
                f_1273_35411_35423(System.Collections.ArrayList
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 35411, 35423);
                    return return_v;
                }


                object
                f_1273_35578_35590(System.Collections.ArrayList
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 35578, 35590);
                    return return_v;
                }


                System.Exception
                f_1273_35673_35686(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 35673, 35686);
                    return return_v;
                }


                System.Exception
                f_1273_35690_35716(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 35690, 35716);
                    return return_v;
                }


                int
                f_1273_35840_35855(System.Collections.ArrayList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 35840, 35855);
                    return return_v;
                }


                int
                f_1273_35944_36039(System.Collections.ArrayList
                this_param, int
                index, int
                count)
                {
                    this_param.RemoveRange(index, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 35944, 36039);
                    return 0;
                }


                int
                f_1273_36071_36095(System.Collections.ArrayList
                this_param, int
                index, object
                value)
                {
                    this_param.Insert(index, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 36071, 36095);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 34470, 36107);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 34470, 36107);
            }
        }

        internal static void CheckStackDepth()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1273, 36471, 36786);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 36570, 36618);

                    f_1273_36570_36617();
                }
                catch (InsufficientExecutionStackException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1273, 36647, 36775);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 36723, 36760);

                    throw f_1273_36729_36759();
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1273, 36647, 36775);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1273, 36471, 36786);

                int
                f_1273_36570_36617()
                {
                    RuntimeHelpers.EnsureSufficientExecutionStack();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 36570, 36617);
                    return 0;
                }


                System.Management.Automation.ScriptCallDepthException
                f_1273_36729_36759()
                {
                    var return_v = new System.Management.Automation.ScriptCallDepthException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 36729, 36759);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 36471, 36786);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 36471, 36786);
            }
        }

        private Runspace _currentRunspace;

        internal Runspace CurrentRunspace
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 37183, 37215);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 37189, 37213);

                    return _currentRunspace;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 37183, 37215);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 37125, 37275);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 37125, 37275);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 37231, 37264);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 37237, 37262);

                    _currentRunspace = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 37231, 37264);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 37125, 37275);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 37125, 37275);
                }
            }
        }

        internal void PushPipelineProcessor(PipelineProcessor pp)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 37516, 37865);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 37598, 37652) || true) && (_currentRunspace == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 37598, 37652);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 37645, 37652);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 37598, 37652);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 37666, 37764);

                LocalPipeline
                lpl = (LocalPipeline)f_1273_37701_37763(((RunspaceBase)_currentRunspace))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 37778, 37819) || true) && (lpl == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 37778, 37819);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 37812, 37819);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 37778, 37819);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 37833, 37854);

                f_1273_37833_37853(f_1273_37833_37844(lpl), pp);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 37516, 37865);

                System.Management.Automation.Runspaces.Pipeline
                f_1273_37701_37763(System.Management.Automation.Runspaces.RunspaceBase
                this_param)
                {
                    var return_v = this_param.GetCurrentlyRunningPipeline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 37701, 37763);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineStopper
                f_1273_37833_37844(System.Management.Automation.Runspaces.LocalPipeline
                this_param)
                {
                    var return_v = this_param.Stopper;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 37833, 37844);
                    return return_v;
                }


                int
                f_1273_37833_37853(System.Management.Automation.Runspaces.PipelineStopper
                this_param, System.Management.Automation.Internal.PipelineProcessor
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 37833, 37853);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 37516, 37865);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 37516, 37865);
            }
        }

        internal void PopPipelineProcessor(bool fromSteppablePipeline)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 38045, 38417);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 38132, 38186) || true) && (_currentRunspace == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 38132, 38186);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 38179, 38186);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 38132, 38186);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 38200, 38298);

                LocalPipeline
                lpl = (LocalPipeline)f_1273_38235_38297(((RunspaceBase)_currentRunspace))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 38312, 38353) || true) && (lpl == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 38312, 38353);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 38346, 38353);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 38312, 38353);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 38367, 38406);

                f_1273_38367_38405(f_1273_38367_38378(lpl), fromSteppablePipeline);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 38045, 38417);

                System.Management.Automation.Runspaces.Pipeline
                f_1273_38235_38297(System.Management.Automation.Runspaces.RunspaceBase
                this_param)
                {
                    var return_v = this_param.GetCurrentlyRunningPipeline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 38235, 38297);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineStopper
                f_1273_38367_38378(System.Management.Automation.Runspaces.LocalPipeline
                this_param)
                {
                    var return_v = this_param.Stopper;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 38367, 38378);
                    return return_v;
                }


                int
                f_1273_38367_38405(System.Management.Automation.Runspaces.PipelineStopper
                this_param, bool
                fromSteppablePipeline)
                {
                    this_param.Pop(fromSteppablePipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 38367, 38405);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 38045, 38417);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 38045, 38417);
            }
        }

        internal bool CurrentPipelineStopping
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 38634, 38974);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 38670, 38734) || true) && (_currentRunspace == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 38670, 38734);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 38721, 38734);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 38670, 38734);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 38752, 38850);

                    LocalPipeline
                    lpl = (LocalPipeline)f_1273_38787_38849(((RunspaceBase)_currentRunspace))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 38868, 38919) || true) && (lpl == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 38868, 38919);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 38906, 38919);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 38868, 38919);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 38937, 38959);

                    return f_1273_38944_38958(lpl);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 38634, 38974);

                    System.Management.Automation.Runspaces.Pipeline
                    f_1273_38787_38849(System.Management.Automation.Runspaces.RunspaceBase
                    this_param)
                    {
                        var return_v = this_param.GetCurrentlyRunningPipeline();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 38787, 38849);
                        return return_v;
                    }


                    bool
                    f_1273_38944_38958(System.Management.Automation.Runspaces.LocalPipeline
                    this_param)
                    {
                        var return_v = this_param.IsStopping;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 38944, 38958);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 38572, 38985);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 38572, 38985);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool PropagateExceptionsToEnclosingStatementBlock { get; set; }

        internal RuntimeException CurrentExceptionBeingHandled { get; set; }

        internal bool QuestionMarkVariableValue { get; set; }

        internal object DollarErrorVariable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 39963, 40643);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 39999, 40036);

                    CmdletProviderContext
                    context = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 40054, 40085);

                    SessionStateScope
                    scope = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 40103, 40128);

                    object
                    resultItem = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 40148, 40590) || true) && (f_1273_40152_40182_M(!f_1273_40153_40159().IsExecutingEventAction))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 40148, 40590);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 40224, 40354);

                        resultItem = f_1273_40237_40353(f_1273_40237_40255(), SpecialVariables.ErrorVarPath, out context, out scope);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 40148, 40590);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 40148, 40590);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 40436, 40571);

                        resultItem = f_1273_40449_40570(f_1273_40449_40467(), SpecialVariables.EventErrorVarPath, out context, out scope);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 40148, 40590);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 40610, 40628);

                    return resultItem;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 39963, 40643);

                    System.Management.Automation.PSLocalEventManager
                    f_1273_40153_40159()
                    {
                        var return_v = Events;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 40153, 40159);
                        return return_v;
                    }


                    bool
                    f_1273_40152_40182_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 40152, 40182);
                        return return_v;
                    }


                    System.Management.Automation.SessionStateInternal
                    f_1273_40237_40255()
                    {
                        var return_v = EngineSessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 40237, 40255);
                        return return_v;
                    }


                    object
                    f_1273_40237_40353(System.Management.Automation.SessionStateInternal
                    this_param, System.Management.Automation.VariablePath
                    variablePath, out System.Management.Automation.CmdletProviderContext
                    context, out System.Management.Automation.SessionStateScope
                    scope)
                    {
                        var return_v = this_param.GetVariableValue(variablePath, out context, out scope);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 40237, 40353);
                        return return_v;
                    }


                    System.Management.Automation.SessionStateInternal
                    f_1273_40449_40467()
                    {
                        var return_v = EngineSessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 40449, 40467);
                        return return_v;
                    }


                    object
                    f_1273_40449_40570(System.Management.Automation.SessionStateInternal
                    this_param, System.Management.Automation.VariablePath
                    variablePath, out System.Management.Automation.CmdletProviderContext
                    context, out System.Management.Automation.SessionStateScope
                    scope)
                    {
                        var return_v = this_param.GetVariableValue(variablePath, out context, out scope);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 40449, 40570);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 39903, 40842);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 39903, 40842);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 40659, 40831);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 40695, 40816);

                    f_1273_40695_40815(f_1273_40695_40713(), SpecialVariables.ErrorVarPath, value, true, CommandOrigin.Internal);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 40659, 40831);

                    System.Management.Automation.SessionStateInternal
                    f_1273_40695_40713()
                    {
                        var return_v = EngineSessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 40695, 40713);
                        return return_v;
                    }


                    object
                    f_1273_40695_40815(System.Management.Automation.SessionStateInternal
                    this_param, System.Management.Automation.VariablePath
                    variablePath, object
                    newValue, bool
                    asValue, System.Management.Automation.CommandOrigin
                    origin)
                    {
                        var return_v = this_param.SetVariable(variablePath, newValue, asValue, origin);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 40695, 40815);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 39903, 40842);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 39903, 40842);
                }
            }
        }

        internal ActionPreference DebugPreferenceVariable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 40928, 41218);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 40964, 40989);

                    bool
                    defaultUsed = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 41007, 41203);

                    return f_1273_41014_41202(this, SpecialVariables.DebugPreferenceVarPath, InitialSessionState.DefaultDebugPreference, out defaultUsed);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 40928, 41218);

                    System.Management.Automation.ActionPreference
                    f_1273_41014_41202(System.Management.Automation.ExecutionContext
                    this_param, System.Management.Automation.VariablePath
                    preferenceVariablePath, System.Management.Automation.ActionPreference
                    defaultPref, out bool
                    defaultUsed)
                    {
                        var return_v = this_param.GetEnumPreference<System.Management.Automation.ActionPreference>(preferenceVariablePath, defaultPref, out defaultUsed);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 41014, 41202);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 40854, 41581);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 40854, 41581);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 41234, 41570);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 41270, 41555);

                    f_1273_41270_41554(f_1273_41270_41293(this), SpecialVariables.DebugPreferenceVarPath, f_1273_41390_41481(value, typeof(ActionPreference), f_1273_41452_41480()), true, CommandOrigin.Internal);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 41234, 41570);

                    System.Management.Automation.SessionStateInternal
                    f_1273_41270_41293(System.Management.Automation.ExecutionContext
                    this_param)
                    {
                        var return_v = this_param.EngineSessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 41270, 41293);
                        return return_v;
                    }


                    System.Globalization.CultureInfo
                    f_1273_41452_41480()
                    {
                        var return_v = CultureInfo.InvariantCulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 41452, 41480);
                        return return_v;
                    }


                    object
                    f_1273_41390_41481(System.Management.Automation.ActionPreference
                    valueToConvert, System.Type
                    resultType, System.Globalization.CultureInfo
                    formatProvider)
                    {
                        var return_v = LanguagePrimitives.ConvertTo((object)valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 41390, 41481);
                        return return_v;
                    }


                    object
                    f_1273_41270_41554(System.Management.Automation.SessionStateInternal
                    this_param, System.Management.Automation.VariablePath
                    variablePath, object
                    newValue, bool
                    asValue, System.Management.Automation.CommandOrigin
                    origin)
                    {
                        var return_v = this_param.SetVariable(variablePath, newValue, asValue, origin);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 41270, 41554);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 40854, 41581);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 40854, 41581);
                }
            }
        }

        internal ActionPreference VerbosePreferenceVariable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 41669, 41963);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 41705, 41730);

                    bool
                    defaultUsed = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 41748, 41948);

                    return f_1273_41755_41947(this, SpecialVariables.VerbosePreferenceVarPath, InitialSessionState.DefaultVerbosePreference, out defaultUsed);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 41669, 41963);

                    System.Management.Automation.ActionPreference
                    f_1273_41755_41947(System.Management.Automation.ExecutionContext
                    this_param, System.Management.Automation.VariablePath
                    preferenceVariablePath, System.Management.Automation.ActionPreference
                    defaultPref, out bool
                    defaultUsed)
                    {
                        var return_v = this_param.GetEnumPreference<System.Management.Automation.ActionPreference>(preferenceVariablePath, defaultPref, out defaultUsed);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 41755, 41947);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 41593, 42328);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 41593, 42328);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 41979, 42317);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 42015, 42302);

                    f_1273_42015_42301(f_1273_42015_42038(this), SpecialVariables.VerbosePreferenceVarPath, f_1273_42137_42228(value, typeof(ActionPreference), f_1273_42199_42227()), true, CommandOrigin.Internal);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 41979, 42317);

                    System.Management.Automation.SessionStateInternal
                    f_1273_42015_42038(System.Management.Automation.ExecutionContext
                    this_param)
                    {
                        var return_v = this_param.EngineSessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 42015, 42038);
                        return return_v;
                    }


                    System.Globalization.CultureInfo
                    f_1273_42199_42227()
                    {
                        var return_v = CultureInfo.InvariantCulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 42199, 42227);
                        return return_v;
                    }


                    object
                    f_1273_42137_42228(System.Management.Automation.ActionPreference
                    valueToConvert, System.Type
                    resultType, System.Globalization.CultureInfo
                    formatProvider)
                    {
                        var return_v = LanguagePrimitives.ConvertTo((object)valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 42137, 42228);
                        return return_v;
                    }


                    object
                    f_1273_42015_42301(System.Management.Automation.SessionStateInternal
                    this_param, System.Management.Automation.VariablePath
                    variablePath, object
                    newValue, bool
                    asValue, System.Management.Automation.CommandOrigin
                    origin)
                    {
                        var return_v = this_param.SetVariable(variablePath, newValue, asValue, origin);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 42015, 42301);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 41593, 42328);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 41593, 42328);
                }
            }
        }

        internal ActionPreference ErrorActionPreferenceVariable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 42420, 42722);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 42456, 42481);

                    bool
                    defaultUsed = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 42499, 42707);

                    return f_1273_42506_42706(this, SpecialVariables.ErrorActionPreferenceVarPath, InitialSessionState.DefaultErrorActionPreference, out defaultUsed);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 42420, 42722);

                    System.Management.Automation.ActionPreference
                    f_1273_42506_42706(System.Management.Automation.ExecutionContext
                    this_param, System.Management.Automation.VariablePath
                    preferenceVariablePath, System.Management.Automation.ActionPreference
                    defaultPref, out bool
                    defaultUsed)
                    {
                        var return_v = this_param.GetEnumPreference<System.Management.Automation.ActionPreference>(preferenceVariablePath, defaultPref, out defaultUsed);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 42506, 42706);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 42340, 43091);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 42340, 43091);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 42738, 43080);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 42774, 43065);

                    f_1273_42774_43064(f_1273_42774_42797(this), SpecialVariables.ErrorActionPreferenceVarPath, f_1273_42900_42991(value, typeof(ActionPreference), f_1273_42962_42990()), true, CommandOrigin.Internal);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 42738, 43080);

                    System.Management.Automation.SessionStateInternal
                    f_1273_42774_42797(System.Management.Automation.ExecutionContext
                    this_param)
                    {
                        var return_v = this_param.EngineSessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 42774, 42797);
                        return return_v;
                    }


                    System.Globalization.CultureInfo
                    f_1273_42962_42990()
                    {
                        var return_v = CultureInfo.InvariantCulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 42962, 42990);
                        return return_v;
                    }


                    object
                    f_1273_42900_42991(System.Management.Automation.ActionPreference
                    valueToConvert, System.Type
                    resultType, System.Globalization.CultureInfo
                    formatProvider)
                    {
                        var return_v = LanguagePrimitives.ConvertTo((object)valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 42900, 42991);
                        return return_v;
                    }


                    object
                    f_1273_42774_43064(System.Management.Automation.SessionStateInternal
                    this_param, System.Management.Automation.VariablePath
                    variablePath, object
                    newValue, bool
                    asValue, System.Management.Automation.CommandOrigin
                    origin)
                    {
                        var return_v = this_param.SetVariable(variablePath, newValue, asValue, origin);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 42774, 43064);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 42340, 43091);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 42340, 43091);
                }
            }
        }

        internal ActionPreference WarningActionPreferenceVariable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 43185, 43479);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 43221, 43246);

                    bool
                    defaultUsed = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 43264, 43464);

                    return f_1273_43271_43463(this, SpecialVariables.WarningPreferenceVarPath, InitialSessionState.DefaultWarningPreference, out defaultUsed);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 43185, 43479);

                    System.Management.Automation.ActionPreference
                    f_1273_43271_43463(System.Management.Automation.ExecutionContext
                    this_param, System.Management.Automation.VariablePath
                    preferenceVariablePath, System.Management.Automation.ActionPreference
                    defaultPref, out bool
                    defaultUsed)
                    {
                        var return_v = this_param.GetEnumPreference<System.Management.Automation.ActionPreference>(preferenceVariablePath, defaultPref, out defaultUsed);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 43271, 43463);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 43103, 43844);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 43103, 43844);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 43495, 43833);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 43531, 43818);

                    f_1273_43531_43817(f_1273_43531_43554(this), SpecialVariables.WarningPreferenceVarPath, f_1273_43653_43744(value, typeof(ActionPreference), f_1273_43715_43743()), true, CommandOrigin.Internal);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 43495, 43833);

                    System.Management.Automation.SessionStateInternal
                    f_1273_43531_43554(System.Management.Automation.ExecutionContext
                    this_param)
                    {
                        var return_v = this_param.EngineSessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 43531, 43554);
                        return return_v;
                    }


                    System.Globalization.CultureInfo
                    f_1273_43715_43743()
                    {
                        var return_v = CultureInfo.InvariantCulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 43715, 43743);
                        return return_v;
                    }


                    object
                    f_1273_43653_43744(System.Management.Automation.ActionPreference
                    valueToConvert, System.Type
                    resultType, System.Globalization.CultureInfo
                    formatProvider)
                    {
                        var return_v = LanguagePrimitives.ConvertTo((object)valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 43653, 43744);
                        return return_v;
                    }


                    object
                    f_1273_43531_43817(System.Management.Automation.SessionStateInternal
                    this_param, System.Management.Automation.VariablePath
                    variablePath, object
                    newValue, bool
                    asValue, System.Management.Automation.CommandOrigin
                    origin)
                    {
                        var return_v = this_param.SetVariable(variablePath, newValue, asValue, origin);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 43531, 43817);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 43103, 43844);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 43103, 43844);
                }
            }
        }

        internal ActionPreference InformationActionPreferenceVariable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 43942, 44244);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 43978, 44003);

                    bool
                    defaultUsed = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 44021, 44229);

                    return f_1273_44028_44228(this, SpecialVariables.InformationPreferenceVarPath, InitialSessionState.DefaultInformationPreference, out defaultUsed);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 43942, 44244);

                    System.Management.Automation.ActionPreference
                    f_1273_44028_44228(System.Management.Automation.ExecutionContext
                    this_param, System.Management.Automation.VariablePath
                    preferenceVariablePath, System.Management.Automation.ActionPreference
                    defaultPref, out bool
                    defaultUsed)
                    {
                        var return_v = this_param.GetEnumPreference<System.Management.Automation.ActionPreference>(preferenceVariablePath, defaultPref, out defaultUsed);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 44028, 44228);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 43856, 44613);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 43856, 44613);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 44260, 44602);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 44296, 44587);

                    f_1273_44296_44586(f_1273_44296_44319(this), SpecialVariables.InformationPreferenceVarPath, f_1273_44422_44513(value, typeof(ActionPreference), f_1273_44484_44512()), true, CommandOrigin.Internal);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 44260, 44602);

                    System.Management.Automation.SessionStateInternal
                    f_1273_44296_44319(System.Management.Automation.ExecutionContext
                    this_param)
                    {
                        var return_v = this_param.EngineSessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 44296, 44319);
                        return return_v;
                    }


                    System.Globalization.CultureInfo
                    f_1273_44484_44512()
                    {
                        var return_v = CultureInfo.InvariantCulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 44484, 44512);
                        return return_v;
                    }


                    object
                    f_1273_44422_44513(System.Management.Automation.ActionPreference
                    valueToConvert, System.Type
                    resultType, System.Globalization.CultureInfo
                    formatProvider)
                    {
                        var return_v = LanguagePrimitives.ConvertTo((object)valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 44422, 44513);
                        return return_v;
                    }


                    object
                    f_1273_44296_44586(System.Management.Automation.SessionStateInternal
                    this_param, System.Management.Automation.VariablePath
                    variablePath, object
                    newValue, bool
                    asValue, System.Management.Automation.CommandOrigin
                    origin)
                    {
                        var return_v = this_param.SetVariable(variablePath, newValue, asValue, origin);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 44296, 44586);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 43856, 44613);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 43856, 44613);
                }
            }
        }

        internal object WhatIfPreferenceVariable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 44690, 45076);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 44726, 44763);

                    CmdletProviderContext
                    context = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 44781, 44812);

                    SessionStateScope
                    scope = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 44832, 45023);

                    object
                    resultItem = f_1273_44852_45022(f_1273_44852_44875(this), SpecialVariables.WhatIfPreferenceVarPath, out context, out scope)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 45043, 45061);

                    return resultItem;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 44690, 45076);

                    System.Management.Automation.SessionStateInternal
                    f_1273_44852_44875(System.Management.Automation.ExecutionContext
                    this_param)
                    {
                        var return_v = this_param.EngineSessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 44852, 44875);
                        return return_v;
                    }


                    object
                    f_1273_44852_45022(System.Management.Automation.SessionStateInternal
                    this_param, System.Management.Automation.VariablePath
                    variablePath, out System.Management.Automation.CmdletProviderContext
                    context, out System.Management.Automation.SessionStateScope
                    scope)
                    {
                        var return_v = this_param.GetVariableValue(variablePath, out context, out scope);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 44852, 45022);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 44625, 45354);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 44625, 45354);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 45092, 45343);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 45128, 45328);

                    f_1273_45128_45327(f_1273_45128_45151(this), SpecialVariables.WhatIfPreferenceVarPath, value, true, CommandOrigin.Internal);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 45092, 45343);

                    System.Management.Automation.SessionStateInternal
                    f_1273_45128_45151(System.Management.Automation.ExecutionContext
                    this_param)
                    {
                        var return_v = this_param.EngineSessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 45128, 45151);
                        return return_v;
                    }


                    object
                    f_1273_45128_45327(System.Management.Automation.SessionStateInternal
                    this_param, System.Management.Automation.VariablePath
                    variablePath, object
                    newValue, bool
                    asValue, System.Management.Automation.CommandOrigin
                    origin)
                    {
                        var return_v = this_param.SetVariable(variablePath, newValue, asValue, origin);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 45128, 45327);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 44625, 45354);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 44625, 45354);
                }
            }
        }

        internal ConfirmImpact ConfirmPreferenceVariable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 45439, 45733);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 45475, 45500);

                    bool
                    defaultUsed = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 45518, 45718);

                    return f_1273_45525_45717(this, SpecialVariables.ConfirmPreferenceVarPath, InitialSessionState.DefaultConfirmPreference, out defaultUsed);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 45439, 45733);

                    System.Management.Automation.ConfirmImpact
                    f_1273_45525_45717(System.Management.Automation.ExecutionContext
                    this_param, System.Management.Automation.VariablePath
                    preferenceVariablePath, System.Management.Automation.ConfirmImpact
                    defaultPref, out bool
                    defaultUsed)
                    {
                        var return_v = this_param.GetEnumPreference<System.Management.Automation.ConfirmImpact>(preferenceVariablePath, defaultPref, out defaultUsed);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 45525, 45717);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 45366, 46095);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 45366, 46095);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 45749, 46084);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 45785, 46069);

                    f_1273_45785_46068(f_1273_45785_45808(this), SpecialVariables.ConfirmPreferenceVarPath, f_1273_45907_45995(value, typeof(ConfirmImpact), f_1273_45966_45994()), true, CommandOrigin.Internal);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 45749, 46084);

                    System.Management.Automation.SessionStateInternal
                    f_1273_45785_45808(System.Management.Automation.ExecutionContext
                    this_param)
                    {
                        var return_v = this_param.EngineSessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 45785, 45808);
                        return return_v;
                    }


                    System.Globalization.CultureInfo
                    f_1273_45966_45994()
                    {
                        var return_v = CultureInfo.InvariantCulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 45966, 45994);
                        return return_v;
                    }


                    object
                    f_1273_45907_45995(System.Management.Automation.ConfirmImpact
                    valueToConvert, System.Type
                    resultType, System.Globalization.CultureInfo
                    formatProvider)
                    {
                        var return_v = LanguagePrimitives.ConvertTo((object)valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 45907, 45995);
                        return return_v;
                    }


                    object
                    f_1273_45785_46068(System.Management.Automation.SessionStateInternal
                    this_param, System.Management.Automation.VariablePath
                    variablePath, object
                    newValue, bool
                    asValue, System.Management.Automation.CommandOrigin
                    origin)
                    {
                        var return_v = this_param.SetVariable(variablePath, newValue, asValue, origin);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 45785, 46068);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 45366, 46095);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 45366, 46095);
                }
            }
        }

        internal void RunspaceClosingNotification()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 46107, 46650);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 46175, 46224);

                f_1273_46175_46223(f_1273_46175_46193());

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 46240, 46330) || true) && (_debugger != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 46240, 46330);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 46295, 46315);

                    f_1273_46295_46314(_debugger);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 46240, 46330);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 46346, 46430) || true) && (f_1273_46350_46356() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 46346, 46430);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 46398, 46415);

                    f_1273_46398_46414(f_1273_46398_46404());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 46346, 46430);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 46446, 46460);

                Events = null;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 46474, 46592) || true) && (this.transactionManager != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 46474, 46592);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 46543, 46577);

                    f_1273_46543_46576(this.transactionManager);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 46474, 46592);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 46608, 46639);

                this.transactionManager = null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 46107, 46650);

                System.Management.Automation.SessionStateInternal
                f_1273_46175_46193()
                {
                    var return_v = EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 46175, 46193);
                    return return_v;
                }


                int
                f_1273_46175_46223(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    this_param.RunspaceClosingNotification();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 46175, 46223);
                    return 0;
                }


                int
                f_1273_46295_46314(System.Management.Automation.ScriptDebugger
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 46295, 46314);
                    return 0;
                }


                System.Management.Automation.PSLocalEventManager
                f_1273_46350_46356()
                {
                    var return_v = Events;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 46350, 46356);
                    return return_v;
                }


                System.Management.Automation.PSLocalEventManager
                f_1273_46398_46404()
                {
                    var return_v = Events;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 46398, 46404);
                    return return_v;
                }


                int
                f_1273_46398_46414(System.Management.Automation.PSLocalEventManager
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 46398, 46414);
                    return 0;
                }


                int
                f_1273_46543_46576(System.Management.Automation.Internal.PSTransactionManager
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 46543, 46576);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 46107, 46650);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 46107, 46650);
            }
        }

        internal TypeTable TypeTable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 46821, 47111);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 46857, 47058) || true) && (_typeTable == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 46857, 47058);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 46921, 46950);

                        _typeTable = f_1273_46934_46949();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 46972, 47039);

                        _typeTableWeakReference = f_1273_46998_47038(_typeTable);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 46857, 47058);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 47078, 47096);

                    return _typeTable;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 46821, 47111);

                    System.Management.Automation.Runspaces.TypeTable
                    f_1273_46934_46949()
                    {
                        var return_v = new System.Management.Automation.Runspaces.TypeTable();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 46934, 46949);
                        return return_v;
                    }


                    System.WeakReference<System.Management.Automation.Runspaces.TypeTable>
                    f_1273_46998_47038(System.Management.Automation.Runspaces.TypeTable
                    target)
                    {
                        var return_v = new System.WeakReference<System.Management.Automation.Runspaces.TypeTable>(target);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 46998, 47038);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 46768, 47313);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 46768, 47313);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 47127, 47302);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 47163, 47182);

                    _typeTable = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 47200, 47287);

                    _typeTableWeakReference = (DynAbs.Tracing.TraceSender.Conditional_F1(1273, 47226, 47241) || (((value != null) && DynAbs.Tracing.TraceSender.Conditional_F2(1273, 47244, 47279)) || DynAbs.Tracing.TraceSender.Conditional_F3(1273, 47282, 47286))) ? f_1273_47244_47279(value) : null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 47127, 47302);

                    System.WeakReference<System.Management.Automation.Runspaces.TypeTable>
                    f_1273_47244_47279(System.Management.Automation.Runspaces.TypeTable
                    target)
                    {
                        var return_v = new System.WeakReference<System.Management.Automation.Runspaces.TypeTable>(target);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 47244, 47279);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 46768, 47313);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 46768, 47313);
                }
            }
        }

        internal WeakReference<TypeTable> TypeTableWeakReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 47552, 47760);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 47588, 47694) || true) && (_typeTable == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 47588, 47694);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 47652, 47675);

                        var
                        unused = f_1273_47665_47674()
                        ;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 47588, 47694);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 47714, 47745);

                    return _typeTableWeakReference;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 47552, 47760);

                    System.Management.Automation.Runspaces.TypeTable
                    f_1273_47665_47674()
                    {
                        var return_v = TypeTable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 47665, 47674);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 47471, 47771);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 47471, 47771);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private TypeTable _typeTable;

        private WeakReference<TypeTable> _typeTableWeakReference;

        internal TypeInfoDataBaseManager FormatDBManager
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 48071, 48947);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 48107, 48888) || true) && (_formatDBManager == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 48107, 48888);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 48309, 48358);

                        _formatDBManager = f_1273_48328_48357();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 48380, 48457);

                        f_1273_48380_48456(_formatDBManager, f_1273_48404_48429(this), f_1273_48431_48455(this));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 48479, 48869) || true) && (f_1273_48483_48507(this) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 48479, 48869);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 48755, 48846);

                            _formatDBManager.DisableFormatTableUpdates = f_1273_48800_48845(f_1273_48800_48824(this));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 48479, 48869);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 48107, 48888);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 48908, 48932);

                    return _formatDBManager;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 48071, 48947);

                    Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager
                    f_1273_48328_48357()
                    {
                        var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 48328, 48357);
                        return return_v;
                    }


                    System.Management.Automation.AuthorizationManager
                    f_1273_48404_48429(System.Management.Automation.ExecutionContext
                    this_param)
                    {
                        var return_v = this_param.AuthorizationManager;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 48404, 48429);
                        return return_v;
                    }


                    System.Management.Automation.Internal.Host.InternalHost
                    f_1273_48431_48455(System.Management.Automation.ExecutionContext
                    this_param)
                    {
                        var return_v = this_param.EngineHostInterface;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 48431, 48455);
                        return return_v;
                    }


                    int
                    f_1273_48380_48456(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager
                    this_param, System.Management.Automation.AuthorizationManager
                    authorizationManager, System.Management.Automation.Internal.Host.InternalHost
                    host)
                    {
                        this_param.Update(authorizationManager, (System.Management.Automation.Host.PSHost)host);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 48380, 48456);
                        return 0;
                    }


                    System.Management.Automation.Runspaces.InitialSessionState
                    f_1273_48483_48507(System.Management.Automation.ExecutionContext
                    this_param)
                    {
                        var return_v = this_param.InitialSessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 48483, 48507);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.InitialSessionState
                    f_1273_48800_48824(System.Management.Automation.ExecutionContext
                    this_param)
                    {
                        var return_v = this_param.InitialSessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 48800, 48824);
                        return return_v;
                    }


                    bool
                    f_1273_48800_48845(System.Management.Automation.Runspaces.InitialSessionState
                    this_param)
                    {
                        var return_v = this_param.DisableFormatUpdates;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 48800, 48845);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 47998, 49050);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 47998, 49050);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 48963, 49039);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 48999, 49024);

                    _formatDBManager = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 48963, 49039);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 47998, 49050);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 47998, 49050);
                }
            }
        }

        private TypeInfoDataBaseManager _formatDBManager;

        internal PSTransactionManager TransactionManager
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 49358, 49435);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 49394, 49420);

                    return transactionManager;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 49358, 49435);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 49285, 49446);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 49285, 49446);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal PSTransactionManager transactionManager;

        internal Assembly AddAssembly(string name, string filename, out Exception error)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 49519, 50447);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 49624, 49690);

                Assembly
                loadedAssembly = f_1273_49650_49689(name, filename, out error)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 49706, 49763) || true) && (loadedAssembly == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 49706, 49763);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 49751, 49763);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 49706, 49763);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 49779, 49956) || true) && (f_1273_49783_49833(f_1273_49783_49796(), f_1273_49809_49832(loadedAssembly)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 49779, 49956);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 49919, 49941);

                    return loadedAssembly;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 49779, 49956);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 50061, 50120);

                f_1273_50061_50119(f_1273_50061_50074(), f_1273_50079_50102(loadedAssembly), loadedAssembly);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 50136, 50319) || true) && (f_1273_50140_50196(f_1273_50140_50153(), f_1273_50166_50195(f_1273_50166_50190(loadedAssembly))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 50136, 50319);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 50282, 50304);

                    return loadedAssembly;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 50136, 50319);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 50335, 50400);

                f_1273_50335_50399(f_1273_50335_50348(), f_1273_50353_50382(f_1273_50353_50377(loadedAssembly)), loadedAssembly);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 50414, 50436);

                return loadedAssembly;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 49519, 50447);

                System.Reflection.Assembly
                f_1273_49650_49689(string
                name, string
                filename, out System.Exception
                error)
                {
                    var return_v = LoadAssembly(name, filename, out error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 49650, 49689);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Reflection.Assembly>
                f_1273_49783_49796()
                {
                    var return_v = AssemblyCache;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 49783, 49796);
                    return return_v;
                }


                string
                f_1273_49809_49832(System.Reflection.Assembly
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 49809, 49832);
                    return return_v;
                }


                bool
                f_1273_49783_49833(System.Collections.Generic.Dictionary<string, System.Reflection.Assembly>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 49783, 49833);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Reflection.Assembly>
                f_1273_50061_50074()
                {
                    var return_v = AssemblyCache;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 50061, 50074);
                    return return_v;
                }


                string
                f_1273_50079_50102(System.Reflection.Assembly
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 50079, 50102);
                    return return_v;
                }


                int
                f_1273_50061_50119(System.Collections.Generic.Dictionary<string, System.Reflection.Assembly>
                this_param, string
                key, System.Reflection.Assembly
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 50061, 50119);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Reflection.Assembly>
                f_1273_50140_50153()
                {
                    var return_v = AssemblyCache;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 50140, 50153);
                    return return_v;
                }


                System.Reflection.AssemblyName
                f_1273_50166_50190(System.Reflection.Assembly
                this_param)
                {
                    var return_v = this_param.GetName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 50166, 50190);
                    return return_v;
                }


                string
                f_1273_50166_50195(System.Reflection.AssemblyName
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 50166, 50195);
                    return return_v;
                }


                bool
                f_1273_50140_50196(System.Collections.Generic.Dictionary<string, System.Reflection.Assembly>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 50140, 50196);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Reflection.Assembly>
                f_1273_50335_50348()
                {
                    var return_v = AssemblyCache;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 50335, 50348);
                    return return_v;
                }


                System.Reflection.AssemblyName
                f_1273_50353_50377(System.Reflection.Assembly
                this_param)
                {
                    var return_v = this_param.GetName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 50353, 50377);
                    return return_v;
                }


                string
                f_1273_50353_50382(System.Reflection.AssemblyName
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 50353, 50382);
                    return return_v;
                }


                int
                f_1273_50335_50399(System.Collections.Generic.Dictionary<string, System.Reflection.Assembly>
                this_param, string
                key, System.Reflection.Assembly
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 50335, 50399);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 49519, 50447);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 49519, 50447);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void RemoveAssembly(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 50459, 50803);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 50525, 50549);

                Assembly
                loadedAssembly
                = default(Assembly);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 50563, 50792) || true) && (f_1273_50567_50618(f_1273_50567_50580(), name, out loadedAssembly) && (DynAbs.Tracing.TraceSender.Expression_True(1273, 50567, 50644) && loadedAssembly != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 50563, 50792);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 50678, 50705);

                    f_1273_50678_50704(f_1273_50678_50691(), name);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 50725, 50777);

                    f_1273_50725_50776(f_1273_50725_50738(), f_1273_50746_50775(f_1273_50746_50770(loadedAssembly)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 50563, 50792);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 50459, 50803);

                System.Collections.Generic.Dictionary<string, System.Reflection.Assembly>
                f_1273_50567_50580()
                {
                    var return_v = AssemblyCache;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 50567, 50580);
                    return return_v;
                }


                bool
                f_1273_50567_50618(System.Collections.Generic.Dictionary<string, System.Reflection.Assembly>
                this_param, string
                key, out System.Reflection.Assembly
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 50567, 50618);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Reflection.Assembly>
                f_1273_50678_50691()
                {
                    var return_v = AssemblyCache;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 50678, 50691);
                    return return_v;
                }


                bool
                f_1273_50678_50704(System.Collections.Generic.Dictionary<string, System.Reflection.Assembly>
                this_param, string
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 50678, 50704);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Reflection.Assembly>
                f_1273_50725_50738()
                {
                    var return_v = AssemblyCache;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 50725, 50738);
                    return return_v;
                }


                System.Reflection.AssemblyName
                f_1273_50746_50770(System.Reflection.Assembly
                this_param)
                {
                    var return_v = this_param.GetName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 50746, 50770);
                    return return_v;
                }


                string
                f_1273_50746_50775(System.Reflection.AssemblyName
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 50746, 50775);
                    return return_v;
                }


                bool
                f_1273_50725_50776(System.Collections.Generic.Dictionary<string, System.Reflection.Assembly>
                this_param, string
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 50725, 50776);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 50459, 50803);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 50459, 50803);
            }
        }

        [SuppressMessage("Microsoft.Reliability", "CA2001:AvoidCallingProblematicMethods", MessageId = "System.Reflection.Assembly.LoadWithPartialName")]
        [SuppressMessage("Microsoft.Reliability", "CA2001:AvoidCallingProblematicMethods", MessageId = "System.Reflection.Assembly.LoadFrom")]
        internal static Assembly LoadAssembly(string name, string filename, out Exception error)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1273, 50815, 53927);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 51299, 51330);

                Assembly
                loadedAssembly = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 51344, 51357);

                error = null;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 51371, 52279) || true) && (!f_1273_51376_51406(filename))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 51371, 52279);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 51484, 51529);

                        loadedAssembly = f_1273_51501_51528(filename);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 51551, 51573);

                        return loadedAssembly;
                    }
                    catch (FileNotFoundException fileNotFound)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1273, 51610, 51733);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 51693, 51714);

                        error = fileNotFound;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1273, 51610, 51733);
                    }
                    catch (FileLoadException fileLoadException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1273, 51751, 51914);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 51835, 51861);

                        error = fileLoadException;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 51883, 51895);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1273, 51751, 51914);
                    }
                    catch (BadImageFormatException badImage)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1273, 51932, 52083);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 52013, 52030);

                        error = badImage;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 52052, 52064);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1273, 51932, 52083);
                    }
                    catch (SecurityException securityException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1273, 52101, 52264);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 52185, 52211);

                        error = securityException;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 52233, 52245);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1273, 52101, 52264);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 51371, 52279);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 52368, 53673) || true) && (!f_1273_52373_52399(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 52368, 53673);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 52433, 52457);

                    string
                    fixedName = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 52530, 52714);

                    fixedName = (DynAbs.Tracing.TraceSender.Conditional_F1(1273, 52542, 52599) || ((f_1273_52542_52599(name, ".dll", StringComparison.OrdinalIgnoreCase) && DynAbs.Tracing.TraceSender.Conditional_F2(1273, 52635, 52673)) || DynAbs.Tracing.TraceSender.Conditional_F3(1273, 52709, 52713))) ? f_1273_52635_52673(name) : name;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 52734, 52940);

                    var
                    assemblyString = (DynAbs.Tracing.TraceSender.Conditional_F1(1273, 52755, 52792) || ((f_1273_52755_52792(fixedName) && DynAbs.Tracing.TraceSender.Conditional_F2(1273, 52837, 52885)) || DynAbs.Tracing.TraceSender.Conditional_F3(1273, 52930, 52939))) ? f_1273_52837_52885(fixedName) : fixedName
                    ;

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 53004, 53069);

                        loadedAssembly = f_1273_53021_53068(f_1273_53035_53067(assemblyString));
                    }
                    catch (FileNotFoundException fileNotFound)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1273, 53106, 53229);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 53189, 53210);

                        error = fileNotFound;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1273, 53106, 53229);
                    }
                    catch (FileLoadException fileLoadException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1273, 53247, 53376);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 53331, 53357);

                        error = fileLoadException;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1273, 53247, 53376);
                    }
                    catch (BadImageFormatException badImage)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1273, 53394, 53511);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 53475, 53492);

                        error = badImage;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1273, 53394, 53511);
                    }
                    catch (SecurityException securityException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1273, 53529, 53658);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 53613, 53639);

                        error = securityException;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1273, 53529, 53658);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 52368, 53673);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 53790, 53878) || true) && (loadedAssembly != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 53790, 53878);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 53850, 53863);

                    error = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 53790, 53878);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 53894, 53916);

                return loadedAssembly;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1273, 50815, 53927);

                bool
                f_1273_51376_51406(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 51376, 51406);
                    return return_v;
                }


                System.Reflection.Assembly
                f_1273_51501_51528(string
                assemblyFile)
                {
                    var return_v = Assembly.LoadFrom(assemblyFile);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 51501, 51528);
                    return return_v;
                }


                bool
                f_1273_52373_52399(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 52373, 52399);
                    return return_v;
                }


                bool
                f_1273_52542_52599(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.EndsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 52542, 52599);
                    return return_v;
                }


                string?
                f_1273_52635_52673(string
                path)
                {
                    var return_v = Path.GetFileNameWithoutExtension(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 52635, 52673);
                    return return_v;
                }


                bool
                f_1273_52755_52792(string
                assemblyName)
                {
                    var return_v = Utils.IsPowerShellAssembly(assemblyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 52755, 52792);
                    return return_v;
                }


                string
                f_1273_52837_52885(string
                assemblyName)
                {
                    var return_v = Utils.GetPowerShellAssemblyStrongName(assemblyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 52837, 52885);
                    return return_v;
                }


                System.Reflection.AssemblyName
                f_1273_53035_53067(string
                assemblyName)
                {
                    var return_v = new System.Reflection.AssemblyName(assemblyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 53035, 53067);
                    return return_v;
                }


                System.Reflection.Assembly
                f_1273_53021_53068(System.Reflection.AssemblyName
                assemblyRef)
                {
                    var return_v = Assembly.Load(assemblyRef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 53021, 53068);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 50815, 53927);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 50815, 53927);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void ReportEngineStartupError(string resourceString, params object[] arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 54159, 55262);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 54308, 54343);

                    Cmdlet
                    currentRunningModuleCommand
                    = default(Cmdlet);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 54361, 54376);

                    string
                    errorId
                    = default(string);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 54394, 55149) || true) && (f_1273_54398_54475(this, out currentRunningModuleCommand, out errorId))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 54394, 55149);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 54517, 54655);

                        RuntimeException
                        rte = f_1273_54540_54654(null, typeof(RuntimeException), null, errorId, resourceString, arguments)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 54677, 54755);

                        f_1273_54677_54754(currentRunningModuleCommand, f_1273_54716_54753(f_1273_54732_54747(rte), rte));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 54394, 55149);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 54394, 55149);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 54837, 54871);

                        PSHost
                        host = f_1273_54851_54870()
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 54893, 54918) || true) && (host == null)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 54893, 54918);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 54911, 54918);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 54893, 54918);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 54940, 54973);

                        PSHostUserInterface
                        ui = f_1273_54965_54972(host)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 54995, 55018) || true) && (ui == null)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 54995, 55018);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 55011, 55018);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 54995, 55018);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 55040, 55130);

                        f_1273_55040_55129(ui, f_1273_55084_55128(resourceString, arguments));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 54394, 55149);
                    }
                }
                catch (Exception) // swallow all exceptions
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1273, 55178, 55251);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1273, 55178, 55251);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 54159, 55262);

                bool
                f_1273_54398_54475(System.Management.Automation.ExecutionContext
                this_param, out System.Management.Automation.Cmdlet
                command, out string
                errorId)
                {
                    var return_v = this_param.IsModuleCommandCurrentlyRunning(out command, out errorId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 54398, 54475);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1273_54540_54654(object
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException(targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 54540, 54654);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1273_54732_54747(System.Management.Automation.RuntimeException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 54732, 54747);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1273_54716_54753(System.Management.Automation.ErrorRecord
                errorRecord, System.Management.Automation.RuntimeException
                replaceParentContainsErrorRecordException)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(errorRecord, (System.Exception)replaceParentContainsErrorRecordException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 54716, 54753);
                    return return_v;
                }


                int
                f_1273_54677_54754(System.Management.Automation.Cmdlet
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 54677, 54754);
                    return 0;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1273_54851_54870()
                {
                    var return_v = EngineHostInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 54851, 54870);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostUserInterface
                f_1273_54965_54972(System.Management.Automation.Host.PSHost
                this_param)
                {
                    var return_v = this_param.UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 54965, 54972);
                    return return_v;
                }


                string
                f_1273_55084_55128(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 55084, 55128);
                    return return_v;
                }


                int
                f_1273_55040_55129(System.Management.Automation.Host.PSHostUserInterface
                this_param, string
                value)
                {
                    this_param.WriteErrorLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 55040, 55129);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 54159, 55262);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 54159, 55262);
            }
        }

        internal void ReportEngineStartupError(string error)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 55429, 56418);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 55542, 55577);

                    Cmdlet
                    currentRunningModuleCommand
                    = default(Cmdlet);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 55595, 55610);

                    string
                    errorId
                    = default(string);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 55628, 56305) || true) && (f_1273_55632_55709(this, out currentRunningModuleCommand, out errorId))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 55628, 56305);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 55751, 55876);

                        RuntimeException
                        rte = f_1273_55774_55875(null, typeof(RuntimeException), null, errorId, "{0}", error)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 55898, 55976);

                        f_1273_55898_55975(currentRunningModuleCommand, f_1273_55937_55974(f_1273_55953_55968(rte), rte));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 55628, 56305);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 55628, 56305);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 56058, 56092);

                        PSHost
                        host = f_1273_56072_56091()
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 56114, 56139) || true) && (host == null)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 56114, 56139);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 56132, 56139);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 56114, 56139);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 56161, 56194);

                        PSHostUserInterface
                        ui = f_1273_56186_56193(host)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 56216, 56239) || true) && (ui == null)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 56216, 56239);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 56232, 56239);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 56216, 56239);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 56261, 56286);

                        f_1273_56261_56285(ui, error);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 55628, 56305);
                    }
                }
                catch (Exception) // swallow all exceptions
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1273, 56334, 56407);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1273, 56334, 56407);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 55429, 56418);

                bool
                f_1273_55632_55709(System.Management.Automation.ExecutionContext
                this_param, out System.Management.Automation.Cmdlet
                command, out string
                errorId)
                {
                    var return_v = this_param.IsModuleCommandCurrentlyRunning(out command, out errorId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 55632, 55709);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1273_55774_55875(object
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException(targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 55774, 55875);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1273_55953_55968(System.Management.Automation.RuntimeException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 55953, 55968);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1273_55937_55974(System.Management.Automation.ErrorRecord
                errorRecord, System.Management.Automation.RuntimeException
                replaceParentContainsErrorRecordException)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(errorRecord, (System.Exception)replaceParentContainsErrorRecordException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 55937, 55974);
                    return return_v;
                }


                int
                f_1273_55898_55975(System.Management.Automation.Cmdlet
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 55898, 55975);
                    return 0;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1273_56072_56091()
                {
                    var return_v = EngineHostInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 56072, 56091);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostUserInterface
                f_1273_56186_56193(System.Management.Automation.Host.PSHost
                this_param)
                {
                    var return_v = this_param.UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 56186, 56193);
                    return return_v;
                }


                int
                f_1273_56261_56285(System.Management.Automation.Host.PSHostUserInterface
                this_param, string
                value)
                {
                    this_param.WriteErrorLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 56261, 56285);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 55429, 56418);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 55429, 56418);
            }
        }

        internal void ReportEngineStartupError(Exception e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 56565, 57683);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 56677, 56712);

                    Cmdlet
                    currentRunningModuleCommand
                    = default(Cmdlet);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 56730, 56745);

                    string
                    errorId
                    = default(string);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 56763, 57570) || true) && (f_1273_56767_56844(this, out currentRunningModuleCommand, out errorId))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 56763, 57570);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 56886, 56911);

                        ErrorRecord
                        error = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 56933, 56965);

                        var
                        rte = e as RuntimeException
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 56989, 57167);

                        error = (DynAbs.Tracing.TraceSender.Conditional_F1(1273, 56997, 57008) || ((rte != null
                        && DynAbs.Tracing.TraceSender.Conditional_F2(1273, 57036, 57073)) || DynAbs.Tracing.TraceSender.Conditional_F3(1273, 57101, 57166))) ? f_1273_57036_57073(f_1273_57052_57067(rte), rte) : f_1273_57101_57166(e, errorId, ErrorCategory.OperationStopped, null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 57191, 57237);

                        f_1273_57191_57236(
                                            currentRunningModuleCommand, error);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 56763, 57570);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 56763, 57570);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 57319, 57353);

                        PSHost
                        host = f_1273_57333_57352()
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 57375, 57400) || true) && (host == null)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 57375, 57400);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 57393, 57400);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 57375, 57400);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 57422, 57455);

                        PSHostUserInterface
                        ui = f_1273_57447_57454(host)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 57477, 57500) || true) && (ui == null)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 57477, 57500);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 57493, 57500);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 57477, 57500);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 57522, 57551);

                        f_1273_57522_57550(ui, f_1273_57540_57549(e));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 56763, 57570);
                    }
                }
                catch (Exception) // swallow all exceptions
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1273, 57599, 57672);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1273, 57599, 57672);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 56565, 57683);

                bool
                f_1273_56767_56844(System.Management.Automation.ExecutionContext
                this_param, out System.Management.Automation.Cmdlet
                command, out string
                errorId)
                {
                    var return_v = this_param.IsModuleCommandCurrentlyRunning(out command, out errorId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 56767, 56844);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1273_57052_57067(System.Management.Automation.RuntimeException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 57052, 57067);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1273_57036_57073(System.Management.Automation.ErrorRecord
                errorRecord, System.Management.Automation.RuntimeException
                replaceParentContainsErrorRecordException)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(errorRecord, (System.Exception)replaceParentContainsErrorRecordException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 57036, 57073);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1273_57101_57166(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 57101, 57166);
                    return return_v;
                }


                int
                f_1273_57191_57236(System.Management.Automation.Cmdlet
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 57191, 57236);
                    return 0;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1273_57333_57352()
                {
                    var return_v = EngineHostInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 57333, 57352);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostUserInterface
                f_1273_57447_57454(System.Management.Automation.Host.PSHost
                this_param)
                {
                    var return_v = this_param.UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 57447, 57454);
                    return return_v;
                }


                string
                f_1273_57540_57549(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 57540, 57549);
                    return return_v;
                }


                int
                f_1273_57522_57550(System.Management.Automation.Host.PSHostUserInterface
                this_param, string
                value)
                {
                    this_param.WriteErrorLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 57522, 57550);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 56565, 57683);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 56565, 57683);
            }
        }

        internal void ReportEngineStartupError(ErrorRecord errorRecord)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 57840, 58682);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 57964, 57999);

                    Cmdlet
                    currentRunningModuleCommand
                    = default(Cmdlet);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 58017, 58031);

                    string
                    unused
                    = default(string);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 58049, 58569) || true) && (f_1273_58053_58129(this, out currentRunningModuleCommand, out unused))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 58049, 58569);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 58171, 58223);

                        f_1273_58171_58222(currentRunningModuleCommand, errorRecord);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 58049, 58569);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 58049, 58569);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 58305, 58339);

                        PSHost
                        host = f_1273_58319_58338()
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 58361, 58386) || true) && (host == null)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 58361, 58386);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 58379, 58386);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 58361, 58386);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 58408, 58441);

                        PSHostUserInterface
                        ui = f_1273_58433_58440(host)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 58463, 58486) || true) && (ui == null)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 58463, 58486);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 58479, 58486);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 58463, 58486);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 58508, 58550);

                        f_1273_58508_58549(ui, f_1273_58526_58548(errorRecord));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 58049, 58569);
                    }
                }
                catch (Exception) // swallow all exceptions
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1273, 58598, 58671);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1273, 58598, 58671);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 57840, 58682);

                bool
                f_1273_58053_58129(System.Management.Automation.ExecutionContext
                this_param, out System.Management.Automation.Cmdlet
                command, out string
                errorId)
                {
                    var return_v = this_param.IsModuleCommandCurrentlyRunning(out command, out errorId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 58053, 58129);
                    return return_v;
                }


                int
                f_1273_58171_58222(System.Management.Automation.Cmdlet
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 58171, 58222);
                    return 0;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1273_58319_58338()
                {
                    var return_v = EngineHostInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 58319, 58338);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostUserInterface
                f_1273_58433_58440(System.Management.Automation.Host.PSHost
                this_param)
                {
                    var return_v = this_param.UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 58433, 58440);
                    return return_v;
                }


                string
                f_1273_58526_58548(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 58526, 58548);
                    return return_v;
                }


                int
                f_1273_58508_58549(System.Management.Automation.Host.PSHostUserInterface
                this_param, string
                value)
                {
                    this_param.WriteErrorLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 58508, 58549);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 57840, 58682);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 57840, 58682);
            }
        }

        private bool IsModuleCommandCurrentlyRunning(out Cmdlet command, out string errorId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 58694, 59899);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 58803, 58818);

                command = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 58832, 58847);

                errorId = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 58861, 58881);

                bool
                result = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 58895, 59858) || true) && (f_1273_58899_58927(this) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 58895, 59858);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 58969, 59035);

                    CommandInfo
                    cmdletInfo = f_1273_58994_59034(f_1273_58994_59022(this))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 59053, 59843) || true) && ((f_1273_59058_59141(f_1273_59072_59087(cmdletInfo), "Import-Module", StringComparison.OrdinalIgnoreCase) || (DynAbs.Tracing.TraceSender.Expression_False(1273, 59058, 59250) || f_1273_59167_59250(f_1273_59181_59196(cmdletInfo), "Remove-Module", StringComparison.OrdinalIgnoreCase))) && (DynAbs.Tracing.TraceSender.Expression_True(1273, 59057, 59326) && f_1273_59276_59326(f_1273_59276_59298(cmdletInfo), CommandTypes.Cmdlet)) && (DynAbs.Tracing.TraceSender.Expression_True(1273, 59057, 59447) && f_1273_59351_59447(InitialSessionState.CoreModule, f_1273_59389_59410(cmdletInfo), StringComparison.OrdinalIgnoreCase)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 59053, 59843);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 59489, 59503);

                        result = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 59525, 59580);

                        command = (Cmdlet)f_1273_59543_59579(f_1273_59543_59571(this));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 59602, 59824);

                        errorId = (DynAbs.Tracing.TraceSender.Conditional_F1(1273, 59612, 59695) || ((f_1273_59612_59695(f_1273_59626_59641(cmdletInfo), "Import-Module", StringComparison.OrdinalIgnoreCase) && DynAbs.Tracing.TraceSender.Conditional_F2(1273, 59733, 59759)) || DynAbs.Tracing.TraceSender.Conditional_F3(1273, 59797, 59823))) ? "Module_ImportModuleError"
                        : "Module_RemoveModuleError";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 59053, 59843);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 58895, 59858);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 59874, 59888);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 58694, 59899);

                System.Management.Automation.CommandProcessorBase
                f_1273_58899_58927(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentCommandProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 58899, 58927);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1273_58994_59022(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentCommandProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 58994, 59022);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1273_58994_59034(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 58994, 59034);
                    return return_v;
                }


                string
                f_1273_59072_59087(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 59072, 59087);
                    return return_v;
                }


                bool
                f_1273_59058_59141(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 59058, 59141);
                    return return_v;
                }


                string
                f_1273_59181_59196(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 59181, 59196);
                    return return_v;
                }


                bool
                f_1273_59167_59250(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 59167, 59250);
                    return return_v;
                }


                System.Management.Automation.CommandTypes
                f_1273_59276_59298(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.CommandType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 59276, 59298);
                    return return_v;
                }


                bool
                f_1273_59276_59326(System.Management.Automation.CommandTypes
                this_param, System.Management.Automation.CommandTypes
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 59276, 59326);
                    return return_v;
                }


                string
                f_1273_59389_59410(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 59389, 59410);
                    return return_v;
                }


                bool
                f_1273_59351_59447(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 59351, 59447);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1273_59543_59571(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentCommandProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 59543, 59571);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1273_59543_59579(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 59543, 59579);
                    return return_v;
                }


                string
                f_1273_59626_59641(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 59626, 59641);
                    return return_v;
                }


                bool
                f_1273_59612_59695(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 59612, 59695);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 58694, 59899);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 58694, 59899);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ExecutionContext(AutomationEngine engine, PSHost hostInterface, InitialSessionState initialSessionState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1273, 60392, 60717);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 1117, 1174);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 1186, 1304);
                this.AutoLoadingModuleInProgress = f_1273_1250_1303(f_1273_1270_1302());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 1539, 1548);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 1574, 1588);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 2782, 2798);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 3303, 3318);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 5785, 5861);
                this.ScriptCommandProcessorShouldRethrowExit = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 6150, 6203);
                this.IgnoreScriptDebug = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 6312, 6366);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 6378, 6435);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 6674, 6727);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 7041, 7115);
                this.previousModuleImported = f_1273_7099_7114();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 7316, 7366);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 7391, 7437);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 8679, 8738);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 8851, 8923);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 9480, 9494);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 9609, 9664);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 10629, 10637);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 10766, 10828);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 10977, 11049);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 14456, 14499);
                this._languageMode = PSLanguageMode.FullLanguage;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 14635, 14713);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 14939, 15007);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 20921, 21014);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 21445, 21461);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 21590, 21663);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 21875, 21941);
                this.EngineState = EngineState.None;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 27058, 27069);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 27137, 27177);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 27211, 27290);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 27300, 27379);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 28575, 28642);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 29110, 29296);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 30010, 30027);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 30119, 30193);
                this.LogContextCache = f_1273_30171_30192();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 30368, 30427);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 30570, 30627);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 30773, 30833);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 33224, 33280);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 33400, 33455);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 33575, 33630);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 33750, 33803);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 33927, 33986);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 36928, 36944);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 39380, 39452);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 39464, 39532);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 39679, 39740);
                this.QuestionMarkVariableValue = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 47801, 47811);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 47855, 47878);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 49094, 49110);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 49488, 49506);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 60530, 60572);

                InitialSessionState = initialSessionState;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 60586, 60650);

                AuthorizationManager = f_1273_60609_60649(initialSessionState);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 60666, 60706);

                f_1273_60666_60705(this, engine, hostInterface);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1273, 60392, 60717);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 60392, 60717);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 60392, 60717);
            }
        }

        private void InitializeCommon(AutomationEngine engine, PSHost hostInterface)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1273, 60729, 62653);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 60830, 60846);

                Engine = engine;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 61691, 61730);

                Events = f_1273_61700_61729(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 61744, 61792);

                transactionManager = f_1273_61765_61791();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 61806, 61843);

                _debugger = f_1273_61818_61842(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 61859, 61952);

                EngineHostInterface = hostInterface as InternalHost ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Internal.Host.InternalHost>(1273, 61881, 61951) ?? f_1273_61914_61951(hostInterface, this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 62011, 62062);

                AssemblyCache = f_1273_62027_62061();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 62168, 62243);

                TopLevelSessionState = EngineSessionState = f_1273_62212_62242(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 62259, 62544) || true) && (f_1273_62263_62283() == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1273, 62259, 62544);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 62475, 62529);

                    AuthorizationManager = f_1273_62498_62528(null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1273, 62259, 62544);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 62605, 62642);

                Modules = f_1273_62615_62641(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1273, 60729, 62653);

                System.Management.Automation.PSLocalEventManager
                f_1273_61700_61729(System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new System.Management.Automation.PSLocalEventManager(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 61700, 61729);
                    return return_v;
                }


                System.Management.Automation.Internal.PSTransactionManager
                f_1273_61765_61791()
                {
                    var return_v = new System.Management.Automation.Internal.PSTransactionManager();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 61765, 61791);
                    return return_v;
                }


                System.Management.Automation.ScriptDebugger
                f_1273_61818_61842(System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new System.Management.Automation.ScriptDebugger(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 61818, 61842);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1273_61914_61951(System.Management.Automation.Host.PSHost
                externalHost, System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = new System.Management.Automation.Internal.Host.InternalHost(externalHost, executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 61914, 61951);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Reflection.Assembly>
                f_1273_62027_62061()
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, System.Reflection.Assembly>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 62027, 62061);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1273_62212_62242(System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new System.Management.Automation.SessionStateInternal(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 62212, 62242);
                    return return_v;
                }


                System.Management.Automation.AuthorizationManager
                f_1273_62263_62283()
                {
                    var return_v = AuthorizationManager;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 62263, 62283);
                    return return_v;
                }


                System.Management.Automation.AuthorizationManager
                f_1273_62498_62528(string
                shellId)
                {
                    var return_v = new System.Management.Automation.AuthorizationManager(shellId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 62498, 62528);
                    return return_v;
                }


                System.Management.Automation.ModuleIntrinsics
                f_1273_62615_62641(System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new System.Management.Automation.ModuleIntrinsics(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 62615, 62641);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1273, 60729, 62653);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 60729, 62653);
            }
        }

        private static object lockObject;

        static ExecutionContext()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1273, 941, 63965);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 15237, 15310);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 15551, 15633);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 20658, 20782);
            ModulesWithJobSourceAdapters = new List<string>
            {
                DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => Utils.ScheduledJobModuleName,1273,20689,20782)            };
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1273, 62687, 62712);
            lockObject = f_1273_62700_62712();
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1273, 941, 63965);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1273, 941, 63965);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1273, 941, 63965);

        System.StringComparer
        f_1273_1270_1302()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 1270, 1302);
            return return_v;
        }


        System.Collections.Generic.HashSet<string>
        f_1273_1250_1303(System.StringComparer
        comparer)
        {
            var return_v = new System.Collections.Generic.HashSet<string>((System.Collections.Generic.IEqualityComparer<string>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 1250, 1303);
            return return_v;
        }


        System.Collections.Hashtable
        f_1273_7099_7114()
        {
            var return_v = new System.Collections.Hashtable();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 7099, 7114);
            return return_v;
        }


        System.Management.Automation.LogContextCache
        f_1273_30171_30192()
        {
            var return_v = new System.Management.Automation.LogContextCache();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 30171, 30192);
            return return_v;
        }


        System.Management.Automation.AuthorizationManager
        f_1273_60609_60649(System.Management.Automation.Runspaces.InitialSessionState
        this_param)
        {
            var return_v = this_param.AuthorizationManager;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1273, 60609, 60649);
            return return_v;
        }


        int
        f_1273_60666_60705(System.Management.Automation.ExecutionContext
        this_param, System.Management.Automation.AutomationEngine
        engine, System.Management.Automation.Host.PSHost
        hostInterface)
        {
            this_param.InitializeCommon(engine, hostInterface);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 60666, 60705);
            return 0;
        }


        static object
        f_1273_62700_62712()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1273, 62700, 62712);
            return return_v;
        }

    }

    /// <summary>
    /// Enum that defines state of monad engine.
    /// </summary>
    internal enum EngineState
    {
        /// <summary>
        /// Engine state is not defined or initialized.
        /// </summary>
        None = 0,

        /// <summary>
        /// Engine available.
        /// </summary>
        Available = 1,

        /// <summary>
        /// Engine service is degraded.
        /// </summary>
        Degraded = 2,

        /// <summary>
        /// Engine is out of service.
        /// </summary>
        OutOfService = 3,

        /// <summary>
        /// Engine is stopped.
        /// </summary>
        Stopped = 4
    };
}
