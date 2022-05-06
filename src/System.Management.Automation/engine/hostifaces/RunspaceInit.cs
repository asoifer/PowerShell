// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Dbg = System.Management.Automation.Diagnostics;
using DWORD = System.UInt32;

namespace System.Management.Automation.Runspaces
{
    internal sealed partial
        class LocalRunspace : RunspaceBase
    {
        private void InitializeDefaults()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1482, 572, 883);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1482, 630, 691);

                SessionStateInternal
                ss = f_1482_656_690(f_1482_656_671(_engine))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1482, 705, 763);

                f_1482_705_762(ss != null, "SessionState should not be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1482, 842, 872);

                f_1482_842_871(
                            // Add the variables that must always be there...
                            ss);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1482, 572, 883);

                System.Management.Automation.ExecutionContext
                f_1482_656_671(System.Management.Automation.AutomationEngine
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1482, 656, 671);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1482_656_690(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1482, 656, 690);
                    return return_v;
                }


                int
                f_1482_705_762(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1482, 705, 762);
                    return 0;
                }


                int
                f_1482_842_871(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    this_param.InitializeFixedVariables();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1482, 842, 871);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1482, 572, 883);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1482, 572, 883);
            }
        }
    }
}

