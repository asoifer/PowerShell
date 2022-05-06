// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Diagnostics.Eventing;
using System.Management.Automation.Internal;
using System.Text;
using System.Collections.Generic;

namespace System.Management.Automation.Tracing
{
    internal class PSEtwLogProvider : LogProvider
    {
        private static EventProvider etwProvider;

        internal static readonly Guid ProviderGuid;

        private static EventDescriptor _xferEventDescriptor;

        static PSEtwLogProvider()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1056, 829, 936);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 477, 488);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 529, 592);
                ProviderGuid = f_1056_544_592("F90714A8-5509-434A-BF6D-B1624C8A19A2");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 634, 737);
                _xferEventDescriptor = f_1056_657_737(0x1f05, 0x1, 0x11, 0x5, 0x14, 0x0, (long)0x4000000000000000);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 879, 925);

                etwProvider = f_1056_893_924(ProviderGuid);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1056, 829, 936);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1056, 829, 936);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1056, 829, 936);
            }
        }

        internal bool IsEnabled(PSLevel level, PSKeyword keywords)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1056, 1755, 1907);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 1838, 1896);

                return f_1056_1845_1895(etwProvider, level, keywords);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1056, 1755, 1907);

                bool
                f_1056_1845_1895(System.Diagnostics.Eventing.EventProvider
                this_param, System.Management.Automation.Internal.PSLevel
                level, System.Management.Automation.Internal.PSKeyword
                keywords)
                {
                    var return_v = this_param.IsEnabled((byte)level, (long)keywords);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 1845, 1895);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1056, 1755, 1907);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1056, 1755, 1907);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void LogEngineHealthEvent(LogContext logContext, int eventId, Exception exception, Dictionary<string, string> additionalInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1056, 2221, 2742);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 2389, 2433);

                StringBuilder
                payload = f_1056_2413_2432()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 2449, 2485);

                f_1056_2449_2484(payload, exception);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 2499, 2520);

                f_1056_2499_2519(payload);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 2534, 2580);

                f_1056_2534_2579(payload, additionalInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 2596, 2731);

                f_1056_2596_2730(this, PSEventId.Engine_Health, PSChannel.Operational, PSOpcode.Exception, PSTask.ExecutePipeline, logContext, f_1056_2711_2729(payload));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1056, 2221, 2742);

                System.Text.StringBuilder
                f_1056_2413_2432()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 2413, 2432);
                    return return_v;
                }


                int
                f_1056_2449_2484(System.Text.StringBuilder
                sb, System.Exception
                except)
                {
                    AppendException(sb, except);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 2449, 2484);
                    return 0;
                }


                System.Text.StringBuilder
                f_1056_2499_2519(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.AppendLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 2499, 2519);
                    return return_v;
                }


                int
                f_1056_2534_2579(System.Text.StringBuilder
                sb, System.Collections.Generic.Dictionary<string, string>
                additionalInfo)
                {
                    AppendAdditionalInfo(sb, additionalInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 2534, 2579);
                    return 0;
                }


                string
                f_1056_2711_2729(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 2711, 2729);
                    return return_v;
                }


                int
                f_1056_2596_2730(System.Management.Automation.Tracing.PSEtwLogProvider
                this_param, System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSChannel
                channel, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.LogContext
                logContext, string
                payLoad)
                {
                    this_param.WriteEvent(id, channel, opcode, task, logContext, payLoad);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 2596, 2730);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1056, 2221, 2742);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1056, 2221, 2742);
            }
        }

        internal override void LogEngineLifecycleEvent(LogContext logContext, EngineState newState, EngineState previousState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1056, 3020, 3993);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 3163, 3982) || true) && (f_1056_3167_3248(this, PSLevel.Informational, PSKeyword.Cmdlets | PSKeyword.UseAlwaysAnalytic))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1056, 3163, 3982);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 3282, 3326);

                    StringBuilder
                    payload = f_1056_3306_3325()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 3346, 3468);

                    f_1056_3346_3467(
                                    payload, f_1056_3365_3466(f_1056_3383_3418(), f_1056_3420_3444(previousState), f_1056_3446_3465(newState)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 3488, 3521);

                    PSTask
                    task = PSTask.EngineStart
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 3541, 3833) || true) && (newState == EngineState.Stopped || (DynAbs.Tracing.TraceSender.Expression_False(1056, 3545, 3637) || newState == EngineState.OutOfService) || (DynAbs.Tracing.TraceSender.Expression_False(1056, 3545, 3690) || newState == EngineState.None) || (DynAbs.Tracing.TraceSender.Expression_False(1056, 3545, 3747) || newState == EngineState.Degraded))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1056, 3541, 3833);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 3789, 3814);

                        task = PSTask.EngineStop;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1056, 3541, 3833);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 3853, 3967);

                    f_1056_3853_3966(this, PSEventId.Engine_Lifecycle, PSChannel.Analytic, PSOpcode.Method, task, logContext, f_1056_3947_3965(payload));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1056, 3163, 3982);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1056, 3020, 3993);

                bool
                f_1056_3167_3248(System.Management.Automation.Tracing.PSEtwLogProvider
                this_param, System.Management.Automation.Internal.PSLevel
                level, System.Management.Automation.Internal.PSKeyword
                keywords)
                {
                    var return_v = this_param.IsEnabled(level, keywords);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 3167, 3248);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1056_3306_3325()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 3306, 3325);
                    return return_v;
                }


                string
                f_1056_3383_3418()
                {
                    var return_v = EtwLoggingStrings.EngineStateChange;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1056, 3383, 3418);
                    return return_v;
                }


                string
                f_1056_3420_3444(System.Management.Automation.EngineState
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 3420, 3444);
                    return return_v;
                }


                string
                f_1056_3446_3465(System.Management.Automation.EngineState
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 3446, 3465);
                    return return_v;
                }


                string
                f_1056_3365_3466(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 3365, 3466);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1056_3346_3467(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 3346, 3467);
                    return return_v;
                }


                string
                f_1056_3947_3965(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 3947, 3965);
                    return return_v;
                }


                int
                f_1056_3853_3966(System.Management.Automation.Tracing.PSEtwLogProvider
                this_param, System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSChannel
                channel, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.LogContext
                logContext, string
                payLoad)
                {
                    this_param.WriteEvent(id, channel, opcode, task, logContext, payLoad);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 3853, 3966);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1056, 3020, 3993);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1056, 3020, 3993);
            }
        }

        internal override void LogCommandHealthEvent(LogContext logContext, Exception exception)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1056, 4220, 4592);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 4333, 4377);

                StringBuilder
                payload = f_1056_4357_4376()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 4393, 4429);

                f_1056_4393_4428(payload, exception);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 4445, 4581);

                f_1056_4445_4580(this, PSEventId.Command_Health, PSChannel.Operational, PSOpcode.Exception, PSTask.ExecutePipeline, logContext, f_1056_4561_4579(payload));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1056, 4220, 4592);

                System.Text.StringBuilder
                f_1056_4357_4376()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 4357, 4376);
                    return return_v;
                }


                int
                f_1056_4393_4428(System.Text.StringBuilder
                sb, System.Exception
                except)
                {
                    AppendException(sb, except);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 4393, 4428);
                    return 0;
                }


                string
                f_1056_4561_4579(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 4561, 4579);
                    return return_v;
                }


                int
                f_1056_4445_4580(System.Management.Automation.Tracing.PSEtwLogProvider
                this_param, System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSChannel
                channel, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.LogContext
                logContext, string
                payLoad)
                {
                    this_param.WriteEvent(id, channel, opcode, task, logContext, payLoad);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 4445, 4580);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1056, 4220, 4592);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1056, 4220, 4592);
            }
        }

        internal override void LogCommandLifecycleEvent(Func<LogContext> getLogContext, CommandState newState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1056, 4824, 6185);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 4951, 6174) || true) && (f_1056_4955_5036(this, PSLevel.Informational, PSKeyword.Cmdlets | PSKeyword.UseAlwaysAnalytic))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1056, 4951, 6174);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 5070, 5110);

                    LogContext
                    logContext = f_1056_5094_5109(getLogContext)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 5128, 5172);

                    StringBuilder
                    payload = f_1056_5152_5171()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 5192, 5767) || true) && (f_1056_5196_5218(logContext) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1056, 5192, 5767);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 5268, 5748) || true) && (f_1056_5272_5360(f_1056_5272_5294(logContext), StringLiterals.Script, StringComparison.OrdinalIgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1056, 5268, 5748);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 5410, 5506);

                            f_1056_5410_5505(payload, f_1056_5429_5504(f_1056_5447_5482(), f_1056_5484_5503(newState)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1056, 5268, 5748);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1056, 5268, 5748);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 5604, 5725);

                            f_1056_5604_5724(payload, f_1056_5623_5723(f_1056_5641_5677(), f_1056_5679_5701(logContext), f_1056_5703_5722(newState)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1056, 5268, 5748);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1056, 5192, 5767);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 5787, 5821);

                    PSTask
                    task = PSTask.CommandStart
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 5841, 6024) || true) && (newState == CommandState.Stopped || (DynAbs.Tracing.TraceSender.Expression_False(1056, 5845, 5937) || newState == CommandState.Terminated))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1056, 5841, 6024);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 5979, 6005);

                        task = PSTask.CommandStop;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1056, 5841, 6024);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 6044, 6159);

                    f_1056_6044_6158(this, PSEventId.Command_Lifecycle, PSChannel.Analytic, PSOpcode.Method, task, logContext, f_1056_6139_6157(payload));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1056, 4951, 6174);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1056, 4824, 6185);

                bool
                f_1056_4955_5036(System.Management.Automation.Tracing.PSEtwLogProvider
                this_param, System.Management.Automation.Internal.PSLevel
                level, System.Management.Automation.Internal.PSKeyword
                keywords)
                {
                    var return_v = this_param.IsEnabled(level, keywords);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 4955, 5036);
                    return return_v;
                }


                System.Management.Automation.LogContext
                f_1056_5094_5109(System.Func<System.Management.Automation.LogContext>
                this_param)
                {
                    var return_v = this_param.Invoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 5094, 5109);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1056_5152_5171()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 5152, 5171);
                    return return_v;
                }


                string
                f_1056_5196_5218(System.Management.Automation.LogContext
                this_param)
                {
                    var return_v = this_param.CommandType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1056, 5196, 5218);
                    return return_v;
                }


                string
                f_1056_5272_5294(System.Management.Automation.LogContext
                this_param)
                {
                    var return_v = this_param.CommandType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1056, 5272, 5294);
                    return return_v;
                }


                bool
                f_1056_5272_5360(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 5272, 5360);
                    return return_v;
                }


                string
                f_1056_5447_5482()
                {
                    var return_v = EtwLoggingStrings.ScriptStateChange;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1056, 5447, 5482);
                    return return_v;
                }


                string
                f_1056_5484_5503(System.Management.Automation.CommandState
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 5484, 5503);
                    return return_v;
                }


                string
                f_1056_5429_5504(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 5429, 5504);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1056_5410_5505(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 5410, 5505);
                    return return_v;
                }


                string
                f_1056_5641_5677()
                {
                    var return_v = EtwLoggingStrings.CommandStateChange;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1056, 5641, 5677);
                    return return_v;
                }


                string
                f_1056_5679_5701(System.Management.Automation.LogContext
                this_param)
                {
                    var return_v = this_param.CommandName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1056, 5679, 5701);
                    return return_v;
                }


                string
                f_1056_5703_5722(System.Management.Automation.CommandState
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 5703, 5722);
                    return return_v;
                }


                string
                f_1056_5623_5723(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 5623, 5723);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1056_5604_5724(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 5604, 5724);
                    return return_v;
                }


                string
                f_1056_6139_6157(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 6139, 6157);
                    return return_v;
                }


                int
                f_1056_6044_6158(System.Management.Automation.Tracing.PSEtwLogProvider
                this_param, System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSChannel
                channel, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.LogContext
                logContext, string
                payLoad)
                {
                    this_param.WriteEvent(id, channel, opcode, task, logContext, payLoad);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 6044, 6158);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1056, 4824, 6185);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1056, 4824, 6185);
            }
        }

        internal override void LogPipelineExecutionDetailEvent(LogContext logContext, List<string> pipelineExecutionDetail)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1056, 6431, 7013);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 6571, 6615);

                StringBuilder
                payload = f_1056_6595_6614()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 6631, 6852) || true) && (pipelineExecutionDetail != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1056, 6631, 6852);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 6700, 6837);
                        foreach (string detail in f_1056_6726_6749_I(pipelineExecutionDetail))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1056, 6700, 6837);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 6791, 6818);

                            f_1056_6791_6817(payload, detail);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1056, 6700, 6837);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1056, 1, 138);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1056, 1, 138);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1056, 6631, 6852);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 6868, 7002);

                f_1056_6868_7001(this, PSEventId.Pipeline_Detail, PSChannel.Operational, PSOpcode.Method, PSTask.ExecutePipeline, logContext, f_1056_6982_7000(payload));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1056, 6431, 7013);

                System.Text.StringBuilder
                f_1056_6595_6614()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 6595, 6614);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1056_6791_6817(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 6791, 6817);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1056_6726_6749_I(System.Collections.Generic.List<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 6726, 6749);
                    return return_v;
                }


                string
                f_1056_6982_7000(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 6982, 7000);
                    return return_v;
                }


                int
                f_1056_6868_7001(System.Management.Automation.Tracing.PSEtwLogProvider
                this_param, System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSChannel
                channel, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.LogContext
                logContext, string
                payLoad)
                {
                    this_param.WriteEvent(id, channel, opcode, task, logContext, payLoad);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 6868, 7001);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1056, 6431, 7013);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1056, 6431, 7013);
            }
        }

        internal override void LogProviderHealthEvent(LogContext logContext, string providerName, Exception exception)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1056, 7290, 7962);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 7425, 7469);

                StringBuilder
                payload = f_1056_7449_7468()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 7485, 7521);

                f_1056_7485_7520(payload, exception);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 7535, 7556);

                f_1056_7535_7555(payload);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 7572, 7649);

                Dictionary<string, string>
                additionalInfo = f_1056_7616_7648()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 7665, 7736);

                f_1056_7665_7735(
                            additionalInfo, f_1056_7684_7720(), providerName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 7752, 7798);

                f_1056_7752_7797(payload, additionalInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 7814, 7951);

                f_1056_7814_7950(this, PSEventId.Provider_Health, PSChannel.Operational, PSOpcode.Exception, PSTask.ExecutePipeline, logContext, f_1056_7931_7949(payload));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1056, 7290, 7962);

                System.Text.StringBuilder
                f_1056_7449_7468()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 7449, 7468);
                    return return_v;
                }


                int
                f_1056_7485_7520(System.Text.StringBuilder
                sb, System.Exception
                except)
                {
                    AppendException(sb, except);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 7485, 7520);
                    return 0;
                }


                System.Text.StringBuilder
                f_1056_7535_7555(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.AppendLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 7535, 7555);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, string>
                f_1056_7616_7648()
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 7616, 7648);
                    return return_v;
                }


                string
                f_1056_7684_7720()
                {
                    var return_v = EtwLoggingStrings.ProviderNameString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1056, 7684, 7720);
                    return return_v;
                }


                int
                f_1056_7665_7735(System.Collections.Generic.Dictionary<string, string>
                this_param, string
                key, string
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 7665, 7735);
                    return 0;
                }


                int
                f_1056_7752_7797(System.Text.StringBuilder
                sb, System.Collections.Generic.Dictionary<string, string>
                additionalInfo)
                {
                    AppendAdditionalInfo(sb, additionalInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 7752, 7797);
                    return 0;
                }


                string
                f_1056_7931_7949(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 7931, 7949);
                    return return_v;
                }


                int
                f_1056_7814_7950(System.Management.Automation.Tracing.PSEtwLogProvider
                this_param, System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSChannel
                channel, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.LogContext
                logContext, string
                payLoad)
                {
                    this_param.WriteEvent(id, channel, opcode, task, logContext, payLoad);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 7814, 7950);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1056, 7290, 7962);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1056, 7290, 7962);
            }
        }

        internal override void LogProviderLifecycleEvent(LogContext logContext, string providerName, ProviderState newState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1056, 8241, 9039);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 8382, 9028) || true) && (f_1056_8386_8467(this, PSLevel.Informational, PSKeyword.Cmdlets | PSKeyword.UseAlwaysAnalytic))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1056, 8382, 9028);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 8501, 8545);

                    StringBuilder
                    payload = f_1056_8525_8544()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 8565, 8677);

                    f_1056_8565_8676(
                                    payload, f_1056_8584_8675(f_1056_8602_8639(), providerName, f_1056_8655_8674(newState)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 8697, 8732);

                    PSTask
                    task = PSTask.ProviderStart
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 8752, 8877) || true) && (newState == ProviderState.Stopped)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1056, 8752, 8877);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 8831, 8858);

                        task = PSTask.ProviderStop;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1056, 8752, 8877);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 8897, 9013);

                    f_1056_8897_9012(this, PSEventId.Provider_Lifecycle, PSChannel.Analytic, PSOpcode.Method, task, logContext, f_1056_8993_9011(payload));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1056, 8382, 9028);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1056, 8241, 9039);

                bool
                f_1056_8386_8467(System.Management.Automation.Tracing.PSEtwLogProvider
                this_param, System.Management.Automation.Internal.PSLevel
                level, System.Management.Automation.Internal.PSKeyword
                keywords)
                {
                    var return_v = this_param.IsEnabled(level, keywords);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 8386, 8467);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1056_8525_8544()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 8525, 8544);
                    return return_v;
                }


                string
                f_1056_8602_8639()
                {
                    var return_v = EtwLoggingStrings.ProviderStateChange;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1056, 8602, 8639);
                    return return_v;
                }


                string
                f_1056_8655_8674(System.Management.Automation.ProviderState
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 8655, 8674);
                    return return_v;
                }


                string
                f_1056_8584_8675(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 8584, 8675);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1056_8565_8676(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 8565, 8676);
                    return return_v;
                }


                string
                f_1056_8993_9011(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 8993, 9011);
                    return return_v;
                }


                int
                f_1056_8897_9012(System.Management.Automation.Tracing.PSEtwLogProvider
                this_param, System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSChannel
                channel, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.LogContext
                logContext, string
                payLoad)
                {
                    this_param.WriteEvent(id, channel, opcode, task, logContext, payLoad);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 8897, 9012);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1056, 8241, 9039);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1056, 8241, 9039);
            }
        }

        internal override void LogSettingsEvent(LogContext logContext, string variableName, string value, string previousValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1056, 9355, 10229);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 9499, 10218) || true) && (f_1056_9503_9584(this, PSLevel.Informational, PSKeyword.Cmdlets | PSKeyword.UseAlwaysAnalytic))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1056, 9499, 10218);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 9618, 9662);

                    StringBuilder
                    payload = f_1056_9642_9661()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 9682, 10059) || true) && (previousValue == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1056, 9682, 10059);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 9749, 9851);

                        f_1056_9749_9850(payload, f_1056_9768_9849(f_1056_9786_9827(), variableName, value));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1056, 9682, 10059);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1056, 9682, 10059);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 9933, 10040);

                        f_1056_9933_10039(payload, f_1056_9952_10038(f_1056_9970_10001(), variableName, previousValue, value));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1056, 9682, 10059);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 10079, 10203);

                    f_1056_10079_10202(this, PSEventId.Settings, PSChannel.Analytic, PSOpcode.Method, PSTask.ExecutePipeline, logContext, f_1056_10183_10201(payload));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1056, 9499, 10218);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1056, 9355, 10229);

                bool
                f_1056_9503_9584(System.Management.Automation.Tracing.PSEtwLogProvider
                this_param, System.Management.Automation.Internal.PSLevel
                level, System.Management.Automation.Internal.PSKeyword
                keywords)
                {
                    var return_v = this_param.IsEnabled(level, keywords);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 9503, 9584);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1056_9642_9661()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 9642, 9661);
                    return return_v;
                }


                string
                f_1056_9786_9827()
                {
                    var return_v = EtwLoggingStrings.SettingChangeNoPrevious;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1056, 9786, 9827);
                    return return_v;
                }


                string
                f_1056_9768_9849(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 9768, 9849);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1056_9749_9850(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 9749, 9850);
                    return return_v;
                }


                string
                f_1056_9970_10001()
                {
                    var return_v = EtwLoggingStrings.SettingChange;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1056, 9970, 10001);
                    return return_v;
                }


                string
                f_1056_9952_10038(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 9952, 10038);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1056_9933_10039(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 9933, 10039);
                    return return_v;
                }


                string
                f_1056_10183_10201(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 10183, 10201);
                    return return_v;
                }


                int
                f_1056_10079_10202(System.Management.Automation.Tracing.PSEtwLogProvider
                this_param, System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSChannel
                channel, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.LogContext
                logContext, string
                payLoad)
                {
                    this_param.WriteEvent(id, channel, opcode, task, logContext, payLoad);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 10079, 10202);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1056, 9355, 10229);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1056, 9355, 10229);
            }
        }

        internal override bool UseLoggingVariables()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1056, 10383, 10476);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 10452, 10465);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1056, 10383, 10476);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1056, 10383, 10476);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1056, 10383, 10476);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void WriteEvent(PSEventId id, PSChannel channel, PSOpcode opcode, PSTask task, LogContext logContext, string payLoad)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1056, 10850, 11216);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 11001, 11205);

                f_1056_11001_11204(this, id, channel, opcode, f_1056_11033_11076(f_1056_11056_11075(logContext)), task, 0x0, f_1056_11117_11147(logContext), f_1056_11149_11194(f_1056_11166_11193(logContext)), payLoad);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1056, 10850, 11216);

                string
                f_1056_11056_11075(System.Management.Automation.LogContext
                this_param)
                {
                    var return_v = this_param.Severity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1056, 11056, 11075);
                    return return_v;
                }


                System.Management.Automation.Internal.PSLevel
                f_1056_11033_11076(string
                severity)
                {
                    var return_v = GetPSLevelFromSeverity(severity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 11033, 11076);
                    return return_v;
                }


                string
                f_1056_11117_11147(System.Management.Automation.LogContext
                context)
                {
                    var return_v = LogContextToString(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 11117, 11147);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1056_11166_11193(System.Management.Automation.LogContext
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1056, 11166, 11193);
                    return return_v;
                }


                string
                f_1056_11149_11194(System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = GetPSLogUserData(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 11149, 11194);
                    return return_v;
                }


                int
                f_1056_11001_11204(System.Management.Automation.Tracing.PSEtwLogProvider
                this_param, System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSChannel
                channel, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSLevel
                level, System.Management.Automation.Internal.PSTask
                task, int
                keyword, params object[]
                args)
                {
                    this_param.WriteEvent(id, channel, opcode, level, task, (System.Management.Automation.Internal.PSKeyword)keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 11001, 11204);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1056, 10850, 11216);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1056, 10850, 11216);
            }
        }

        internal void WriteEvent(PSEventId id, PSChannel channel, PSOpcode opcode, PSLevel level, PSTask task, PSKeyword keyword, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1056, 11599, 12316);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 11767, 11791);

                long
                longKeyword = 0x00
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 11807, 12073) || true) && (keyword == PSKeyword.UseAlwaysAnalytic || (DynAbs.Tracing.TraceSender.Expression_False(1056, 11811, 11911) || keyword == PSKeyword.UseAlwaysOperational))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1056, 11807, 12073);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 11945, 11964);

                    longKeyword = 0x00;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1056, 11807, 12073);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1056, 11807, 12073);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 12030, 12058);

                    longKeyword = (long)keyword;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1056, 11807, 12073);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 12089, 12250);

                EventDescriptor
                desc = f_1056_12112_12249(id, PSEventVersion.One, channel, level, opcode, task, longKeyword)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 12266, 12305);

                f_1056_12266_12304(
                            etwProvider, ref desc, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1056, 11599, 12316);

                System.Diagnostics.Eventing.EventDescriptor
                f_1056_12112_12249(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSEventVersion
                version, System.Management.Automation.Internal.PSChannel
                channel, System.Management.Automation.Internal.PSLevel
                level, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, long
                keywords)
                {
                    var return_v = new System.Diagnostics.Eventing.EventDescriptor((int)id, (byte)version, (byte)channel, (byte)level, (byte)opcode, (int)task, keywords);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 12112, 12249);
                    return return_v;
                }


                bool
                f_1056_12266_12304(System.Diagnostics.Eventing.EventProvider
                this_param, ref System.Diagnostics.Eventing.EventDescriptor
                eventDescriptor, params object[]
                eventPayload)
                {
                    var return_v = this_param.WriteEvent(ref eventDescriptor, eventPayload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 12266, 12304);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1056, 11599, 12316);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1056, 11599, 12316);
            }
        }

        internal void WriteTransferEvent(Guid parentActivityId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1056, 12423, 12636);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 12503, 12625);

                f_1056_12503_12624(etwProvider, ref _xferEventDescriptor, parentActivityId, f_1056_12578_12605(), parentActivityId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1056, 12423, 12636);

                System.Guid
                f_1056_12578_12605()
                {
                    var return_v = EtwActivity.GetActivityId();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 12578, 12605);
                    return return_v;
                }


                bool
                f_1056_12503_12624(System.Diagnostics.Eventing.EventProvider
                this_param, ref System.Diagnostics.Eventing.EventDescriptor
                eventDescriptor, System.Guid
                relatedActivityId, params object[]
                eventPayload)
                {
                    var return_v = this_param.WriteTransferEvent(ref eventDescriptor, relatedActivityId, eventPayload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 12503, 12624);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1056, 12423, 12636);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1056, 12423, 12636);
            }
        }

        internal void SetActivityIdForCurrentThread(Guid newActivityId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1056, 12745, 12926);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 12833, 12861);

                Guid
                result = newActivityId
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1056, 12875, 12915);

                f_1056_12875_12914(ref result);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1056, 12745, 12926);

                int
                f_1056_12875_12914(ref System.Guid
                id)
                {
                    EventProvider.SetActivityId(ref id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 12875, 12914);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1056, 12745, 12926);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1056, 12745, 12926);
            }
        }

        public PSEtwLogProvider()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1056, 386, 12933);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1056, 386, 12933);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1056, 386, 12933);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1056, 386, 12933);

        static System.Guid
        f_1056_544_592(string
        g)
        {
            var return_v = new System.Guid(g);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 544, 592);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1056_657_737(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 657, 737);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventProvider
        f_1056_893_924(System.Guid
        providerGuid)
        {
            var return_v = new System.Diagnostics.Eventing.EventProvider(providerGuid);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1056, 893, 924);
            return return_v;
        }

    }
}

