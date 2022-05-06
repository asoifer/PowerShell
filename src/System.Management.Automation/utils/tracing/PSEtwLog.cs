// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Globalization;
using System.Management.Automation.Internal;

namespace System.Management.Automation.Tracing
{
    internal static class PSEtwLog
    {
        private static PSEtwLogProvider provider;

        static PSEtwLog()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1055, 587, 747);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1055, 479, 487);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1055, 694, 728);

                provider = f_1055_705_727();
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1055, 587, 747);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1055, 587, 747);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1055, 587, 747);
            }
        }

        internal static void LogConsoleStartup()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1055, 759, 1225);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1055, 824, 870);

                Guid
                activityId = f_1055_842_869()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1055, 886, 1021) || true) && (activityId == Guid.Empty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1055, 886, 1021);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1055, 948, 1006);

                    f_1055_948_1005(f_1055_974_1004());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1055, 886, 1021);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1055, 1037, 1214);

                f_1055_1037_1213(PSEventId.Perftrack_ConsoleStartupStart, PSOpcode.WinStart, PSTask.PowershellConsoleStartup, PSKeyword.UseAlwaysOperational);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1055, 759, 1225);

                System.Guid
                f_1055_842_869()
                {
                    var return_v = EtwActivity.GetActivityId();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1055, 842, 869);
                    return return_v;
                }


                System.Guid
                f_1055_974_1004()
                {
                    var return_v = EtwActivity.CreateActivityId();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1055, 974, 1004);
                    return return_v;
                }


                bool
                f_1055_948_1005(System.Guid
                activityId)
                {
                    var return_v = EtwActivity.SetActivityId(activityId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1055, 948, 1005);
                    return return_v;
                }


                int
                f_1055_1037_1213(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogOperationalInformation(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1055, 1037, 1213);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1055, 759, 1225);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1055, 759, 1225);
            }
        }

        internal static void LogEngineHealthEvent(LogContext logContext, int eventId, Exception exception, Dictionary<string, string> additionalInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1055, 1539, 1794);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1055, 1705, 1783);

                f_1055_1705_1782(provider, logContext, eventId, exception, additionalInfo);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1055, 1539, 1794);

                int
                f_1055_1705_1782(System.Management.Automation.Tracing.PSEtwLogProvider
                this_param, System.Management.Automation.LogContext
                logContext, int
                eventId, System.Exception
                exception, System.Collections.Generic.Dictionary<string, string>
                additionalInfo)
                {
                    this_param.LogEngineHealthEvent(logContext, eventId, exception, additionalInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1055, 1705, 1782);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1055, 1539, 1794);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1055, 1539, 1794);
            }
        }

        internal static void LogEngineLifecycleEvent(LogContext logContext, EngineState newState, EngineState previousState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1055, 2072, 2294);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1055, 2213, 2283);

                f_1055_2213_2282(provider, logContext, newState, previousState);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1055, 2072, 2294);

                int
                f_1055_2213_2282(System.Management.Automation.Tracing.PSEtwLogProvider
                this_param, System.Management.Automation.LogContext
                logContext, System.Management.Automation.EngineState
                newState, System.Management.Automation.EngineState
                previousState)
                {
                    this_param.LogEngineLifecycleEvent(logContext, newState, previousState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1055, 2213, 2282);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1055, 2072, 2294);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1055, 2072, 2294);
            }
        }

        internal static void LogCommandHealthEvent(LogContext logContext, Exception exception)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1055, 2521, 2697);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1055, 2632, 2686);

                f_1055_2632_2685(provider, logContext, exception);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1055, 2521, 2697);

                int
                f_1055_2632_2685(System.Management.Automation.Tracing.PSEtwLogProvider
                this_param, System.Management.Automation.LogContext
                logContext, System.Exception
                exception)
                {
                    this_param.LogCommandHealthEvent(logContext, exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1055, 2632, 2685);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1055, 2521, 2697);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1055, 2521, 2697);
            }
        }

        internal static void LogCommandLifecycleEvent(LogContext logContext, CommandState newState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1055, 2926, 3115);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1055, 3042, 3104);

                f_1055_3042_3103(provider, () => logContext, newState);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1055, 2926, 3115);

                int
                f_1055_3042_3103(System.Management.Automation.Tracing.PSEtwLogProvider
                this_param, System.Func<System.Management.Automation.LogContext>
                getLogContext, System.Management.Automation.CommandState
                newState)
                {
                    this_param.LogCommandLifecycleEvent(getLogContext, newState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1055, 3042, 3103);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1055, 2926, 3115);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1055, 2926, 3115);
            }
        }

        internal static void LogPipelineExecutionDetailEvent(LogContext logContext, List<string> pipelineExecutionDetail)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1055, 3361, 3588);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1055, 3499, 3577);

                f_1055_3499_3576(provider, logContext, pipelineExecutionDetail);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1055, 3361, 3588);

                int
                f_1055_3499_3576(System.Management.Automation.Tracing.PSEtwLogProvider
                this_param, System.Management.Automation.LogContext
                logContext, System.Collections.Generic.List<string>
                pipelineExecutionDetail)
                {
                    this_param.LogPipelineExecutionDetailEvent(logContext, pipelineExecutionDetail);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1055, 3499, 3576);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1055, 3361, 3588);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1055, 3361, 3588);
            }
        }

        internal static void LogProviderHealthEvent(LogContext logContext, string providerName, Exception exception)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1055, 3865, 4078);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1055, 3998, 4067);

                f_1055_3998_4066(provider, logContext, providerName, exception);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1055, 3865, 4078);

                int
                f_1055_3998_4066(System.Management.Automation.Tracing.PSEtwLogProvider
                this_param, System.Management.Automation.LogContext
                logContext, string
                providerName, System.Exception
                exception)
                {
                    this_param.LogProviderHealthEvent(logContext, providerName, exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1055, 3998, 4066);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1055, 3865, 4078);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1055, 3865, 4078);
            }
        }

        internal static void LogProviderLifecycleEvent(LogContext logContext, string providerName, ProviderState newState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1055, 4357, 4578);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1055, 4496, 4567);

                f_1055_4496_4566(provider, logContext, providerName, newState);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1055, 4357, 4578);

                int
                f_1055_4496_4566(System.Management.Automation.Tracing.PSEtwLogProvider
                this_param, System.Management.Automation.LogContext
                logContext, string
                providerName, System.Management.Automation.ProviderState
                newState)
                {
                    this_param.LogProviderLifecycleEvent(logContext, providerName, newState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1055, 4496, 4566);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1055, 4357, 4578);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1055, 4357, 4578);
            }
        }

        internal static void LogSettingsEvent(LogContext logContext, string variableName, string value, string previousValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1055, 4894, 5121);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1055, 5036, 5110);

                f_1055_5036_5109(provider, logContext, variableName, value, previousValue);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1055, 4894, 5121);

                int
                f_1055_5036_5109(System.Management.Automation.Tracing.PSEtwLogProvider
                this_param, System.Management.Automation.LogContext
                logContext, string
                variableName, string
                value, string
                previousValue)
                {
                    this_param.LogSettingsEvent(logContext, variableName, value, previousValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1055, 5036, 5109);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1055, 4894, 5121);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1055, 4894, 5121);
            }
        }

        internal static void LogOperationalInformation(PSEventId id, PSOpcode opcode, PSTask task, PSKeyword keyword, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1055, 5446, 5712);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1055, 5602, 5701);

                f_1055_5602_5700(provider, id, PSChannel.Operational, opcode, PSLevel.Informational, task, keyword, args);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1055, 5446, 5712);

                int
                f_1055_5602_5700(System.Management.Automation.Tracing.PSEtwLogProvider
                this_param, System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSChannel
                channel, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSLevel
                level, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    this_param.WriteEvent(id, channel, opcode, level, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1055, 5602, 5700);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1055, 5446, 5712);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1055, 5446, 5712);
            }
        }

        internal static void LogOperationalWarning(PSEventId id, PSOpcode opcode, PSTask task, PSKeyword keyword, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1055, 6037, 6293);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1055, 6189, 6282);

                f_1055_6189_6281(provider, id, PSChannel.Operational, opcode, PSLevel.Warning, task, keyword, args);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1055, 6037, 6293);

                int
                f_1055_6189_6281(System.Management.Automation.Tracing.PSEtwLogProvider
                this_param, System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSChannel
                channel, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSLevel
                level, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    this_param.WriteEvent(id, channel, opcode, level, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1055, 6189, 6281);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1055, 6037, 6293);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1055, 6037, 6293);
            }
        }

        internal static void LogOperationalVerbose(PSEventId id, PSOpcode opcode, PSTask task, PSKeyword keyword, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1055, 6614, 6870);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1055, 6766, 6859);

                f_1055_6766_6858(provider, id, PSChannel.Operational, opcode, PSLevel.Verbose, task, keyword, args);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1055, 6614, 6870);

                int
                f_1055_6766_6858(System.Management.Automation.Tracing.PSEtwLogProvider
                this_param, System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSChannel
                channel, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSLevel
                level, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    this_param.WriteEvent(id, channel, opcode, level, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1055, 6766, 6858);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1055, 6614, 6870);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1055, 6614, 6870);
            }
        }

        internal static void LogAnalyticError(PSEventId id, PSOpcode opcode, PSTask task, PSKeyword keyword, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1055, 7194, 7440);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1055, 7341, 7429);

                f_1055_7341_7428(provider, id, PSChannel.Analytic, opcode, PSLevel.Error, task, keyword, args);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1055, 7194, 7440);

                int
                f_1055_7341_7428(System.Management.Automation.Tracing.PSEtwLogProvider
                this_param, System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSChannel
                channel, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSLevel
                level, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    this_param.WriteEvent(id, channel, opcode, level, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1055, 7341, 7428);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1055, 7194, 7440);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1055, 7194, 7440);
            }
        }

        internal static void LogAnalyticWarning(PSEventId id, PSOpcode opcode, PSTask task, PSKeyword keyword, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1055, 7766, 8016);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1055, 7915, 8005);

                f_1055_7915_8004(provider, id, PSChannel.Analytic, opcode, PSLevel.Warning, task, keyword, args);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1055, 7766, 8016);

                int
                f_1055_7915_8004(System.Management.Automation.Tracing.PSEtwLogProvider
                this_param, System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSChannel
                channel, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSLevel
                level, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    this_param.WriteEvent(id, channel, opcode, level, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1055, 7915, 8004);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1055, 7766, 8016);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1055, 7766, 8016);
            }
        }

        internal static void LogAnalyticVerbose(PSEventId id, PSOpcode opcode, PSTask task, PSKeyword keyword,
                    Int64 objectId,
                    Int64 fragmentId,
                    int isStartFragment,
                    int isEndFragment,
                    UInt32 fragmentLength,
                    PSETWBinaryBlob fragmentData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1055, 8597, 9527);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1055, 8929, 9516) || true) && (f_1055_8933_8977(provider, PSLevel.Verbose, keyword))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1055, 8929, 9516);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1055, 9011, 9115);

                    string
                    payLoadData = f_1055_9032_9114(fragmentData.blob, fragmentData.offset, fragmentData.length)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1055, 9133, 9240);

                    payLoadData = f_1055_9147_9239(f_1055_9161_9189(), "0x{0}", f_1055_9200_9238(payLoadData, "-", string.Empty));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1055, 9260, 9501);

                    f_1055_9260_9500(
                                    provider, id, PSChannel.Analytic, opcode, PSLevel.Verbose, task, keyword, objectId, fragmentId, isStartFragment, isEndFragment, fragmentLength, payLoadData);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1055, 8929, 9516);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1055, 8597, 9527);

                bool
                f_1055_8933_8977(System.Management.Automation.Tracing.PSEtwLogProvider
                this_param, System.Management.Automation.Internal.PSLevel
                level, System.Management.Automation.Internal.PSKeyword
                keywords)
                {
                    var return_v = this_param.IsEnabled(level, keywords);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1055, 8933, 8977);
                    return return_v;
                }


                string
                f_1055_9032_9114(byte[]
                value, int
                startIndex, int
                length)
                {
                    var return_v = BitConverter.ToString(value, startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1055, 9032, 9114);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1055_9161_9189()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1055, 9161, 9189);
                    return return_v;
                }


                string
                f_1055_9200_9238(string
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1055, 9200, 9238);
                    return return_v;
                }


                string
                f_1055_9147_9239(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1055, 9147, 9239);
                    return return_v;
                }


                int
                f_1055_9260_9500(System.Management.Automation.Tracing.PSEtwLogProvider
                this_param, System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSChannel
                channel, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSLevel
                level, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    this_param.WriteEvent(id, channel, opcode, level, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1055, 9260, 9500);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1055, 8597, 9527);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1055, 8597, 9527);
            }
        }

        internal static void LogAnalyticVerbose(PSEventId id, PSOpcode opcode, PSTask task, PSKeyword keyword, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1055, 9853, 10103);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1055, 10002, 10092);

                f_1055_10002_10091(provider, id, PSChannel.Analytic, opcode, PSLevel.Verbose, task, keyword, args);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1055, 9853, 10103);

                int
                f_1055_10002_10091(System.Management.Automation.Tracing.PSEtwLogProvider
                this_param, System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSChannel
                channel, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSLevel
                level, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    this_param.WriteEvent(id, channel, opcode, level, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1055, 10002, 10091);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1055, 9853, 10103);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1055, 9853, 10103);
            }
        }

        internal static void LogAnalyticInformational(PSEventId id, PSOpcode opcode, PSTask task, PSKeyword keyword, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1055, 10435, 10697);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1055, 10590, 10686);

                f_1055_10590_10685(provider, id, PSChannel.Analytic, opcode, PSLevel.Informational, task, keyword, args);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1055, 10435, 10697);

                int
                f_1055_10590_10685(System.Management.Automation.Tracing.PSEtwLogProvider
                this_param, System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSChannel
                channel, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSLevel
                level, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    this_param.WriteEvent(id, channel, opcode, level, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1055, 10590, 10685);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1055, 10435, 10697);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1055, 10435, 10697);
            }
        }

        internal static void LogOperationalError(PSEventId id, PSOpcode opcode, PSTask task, PSKeyword keyword, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1055, 11018, 11270);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1055, 11168, 11259);

                f_1055_11168_11258(provider, id, PSChannel.Operational, opcode, PSLevel.Error, task, keyword, args);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1055, 11018, 11270);

                int
                f_1055_11168_11258(System.Management.Automation.Tracing.PSEtwLogProvider
                this_param, System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSChannel
                channel, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSLevel
                level, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    this_param.WriteEvent(id, channel, opcode, level, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1055, 11168, 11258);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1055, 11018, 11270);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1055, 11018, 11270);
            }
        }

        internal static void LogOperationalError(PSEventId id, PSOpcode opcode, PSTask task, LogContext logContext, string payLoad)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1055, 11603, 11844);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1055, 11751, 11833);

                f_1055_11751_11832(provider, id, PSChannel.Operational, opcode, task, logContext, payLoad);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1055, 11603, 11844);

                int
                f_1055_11751_11832(System.Management.Automation.Tracing.PSEtwLogProvider
                this_param, System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSChannel
                channel, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.LogContext
                logContext, string
                payLoad)
                {
                    this_param.WriteEvent(id, channel, opcode, task, logContext, payLoad);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1055, 11751, 11832);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1055, 11603, 11844);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1055, 11603, 11844);
            }
        }

        internal static void SetActivityIdForCurrentThread(Guid newActivityId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1055, 11856, 12016);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1055, 11951, 12005);

                f_1055_11951_12004(provider, newActivityId);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1055, 11856, 12016);

                int
                f_1055_11951_12004(System.Management.Automation.Tracing.PSEtwLogProvider
                this_param, System.Guid
                newActivityId)
                {
                    this_param.SetActivityIdForCurrentThread(newActivityId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1055, 11951, 12004);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1055, 11856, 12016);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1055, 11856, 12016);
            }
        }

        internal static void ReplaceActivityIdForCurrentThread(Guid newActivityId,
                    PSEventId eventForOperationalChannel, PSEventId eventForAnalyticChannel, PSKeyword keyword, PSTask task)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1055, 12028, 12538);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1055, 12285, 12339);

                f_1055_12285_12338(            // set the new activity id
                            provider, newActivityId);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1055, 12425, 12527);

                f_1055_12425_12526(newActivityId, eventForOperationalChannel, eventForAnalyticChannel, keyword, task);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1055, 12028, 12538);

                int
                f_1055_12285_12338(System.Management.Automation.Tracing.PSEtwLogProvider
                this_param, System.Guid
                newActivityId)
                {
                    this_param.SetActivityIdForCurrentThread(newActivityId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1055, 12285, 12338);
                    return 0;
                }


                int
                f_1055_12425_12526(System.Guid
                relatedActivityId, System.Management.Automation.Internal.PSEventId
                eventForOperationalChannel, System.Management.Automation.Internal.PSEventId
                eventForAnalyticChannel, System.Management.Automation.Internal.PSKeyword
                keyword, System.Management.Automation.Internal.PSTask
                task)
                {
                    WriteTransferEvent(relatedActivityId, eventForOperationalChannel, eventForAnalyticChannel, keyword, task);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1055, 12425, 12526);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1055, 12028, 12538);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1055, 12028, 12538);
            }
        }

        internal static void WriteTransferEvent(Guid relatedActivityId, PSEventId eventForOperationalChannel,
                                    PSEventId eventForAnalyticChannel, PSKeyword keyword, PSTask task)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1055, 13076, 13648);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1055, 13298, 13464);

                f_1055_13298_13463(provider, eventForOperationalChannel, PSChannel.Operational, PSOpcode.Method, PSLevel.Informational, task, PSKeyword.UseAlwaysOperational);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1055, 13480, 13637);

                f_1055_13480_13636(
                            provider, eventForAnalyticChannel, PSChannel.Analytic, PSOpcode.Method, PSLevel.Informational, task, PSKeyword.UseAlwaysAnalytic);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1055, 13076, 13648);

                int
                f_1055_13298_13463(System.Management.Automation.Tracing.PSEtwLogProvider
                this_param, System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSChannel
                channel, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSLevel
                level, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    this_param.WriteEvent(id, channel, opcode, level, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1055, 13298, 13463);
                    return 0;
                }


                int
                f_1055_13480_13636(System.Management.Automation.Tracing.PSEtwLogProvider
                this_param, System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSChannel
                channel, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSLevel
                level, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    this_param.WriteEvent(id, channel, opcode, level, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1055, 13480, 13636);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1055, 13076, 13648);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1055, 13076, 13648);
            }
        }

        internal static void WriteTransferEvent(Guid parentActivityId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1055, 13798, 13942);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1055, 13885, 13931);

                f_1055_13885_13930(provider, parentActivityId);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1055, 13798, 13942);

                int
                f_1055_13885_13930(System.Management.Automation.Tracing.PSEtwLogProvider
                this_param, System.Guid
                parentActivityId)
                {
                    this_param.WriteTransferEvent(parentActivityId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1055, 13885, 13930);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1055, 13798, 13942);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1055, 13798, 13942);
            }
        }

        static System.Management.Automation.Tracing.PSEtwLogProvider
f_1055_705_727()
        {
            var return_v = new System.Management.Automation.Tracing.PSEtwLogProvider();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1055, 705, 727);
            return return_v;
        }

    }
}
