// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Management.Automation.Runspaces;
using System.Management.Automation.Tracing;
using System.Security;
using System.Threading;

namespace System.Management.Automation
{
    internal static class MshLog
    {
        private static ConcurrentDictionary<string, Collection<LogProvider>> s_logProviders;

        private const string
        _crimsonLogProviderAssemblyName = "MshCrimsonLog"
        ;

        private const string
        _crimsonLogProviderTypeName = "System.Management.Automation.Logging.CrimsonLogProvider"
        ;

        private static Collection<string> s_ignoredCommands;

        static MshLog()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1185, 3801, 3946);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 3326, 3415);
                s_logProviders = f_1185_3356_3415();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 3449, 3498);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 3530, 3617);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 3664, 3708);
                s_ignoredCommands = f_1185_3684_3708();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 44924, 44948);
                s_nextSequenceNumber = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 45462, 45497);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 45576, 45613);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 45696, 45737);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 45829, 45865);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 45967, 45999);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 46095, 46124);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 46198, 46230);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 46310, 46345);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 3841, 3881);

                f_1185_3841_3880(s_ignoredCommands, "Out-Lineoutput");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 3895, 3935);

                f_1185_3895_3934(s_ignoredCommands, "Format-Default");
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1185, 3801, 3946);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1185, 3801, 3946);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1185, 3801, 3946);
            }
        }

        private static IEnumerable<LogProvider> GetLogProvider(string shellId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1185, 4434, 4599);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 4529, 4588);

                return f_1185_4536_4587(s_logProviders, shellId, CreateLogProvider);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1185, 4434, 4599);

                System.Collections.ObjectModel.Collection<System.Management.Automation.LogProvider>
                f_1185_4536_4587(System.Collections.Concurrent.ConcurrentDictionary<string, System.Collections.ObjectModel.Collection<System.Management.Automation.LogProvider>>
                this_param, string
                key, System.Func<string, System.Collections.ObjectModel.Collection<System.Management.Automation.LogProvider>>
                valueFactory)
                {
                    var return_v = this_param.GetOrAdd(key, valueFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 4536, 4587);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1185, 4434, 4599);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1185, 4434, 4599);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<LogProvider> GetLogProvider(ExecutionContext executionContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1185, 4802, 5174);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 4916, 5058) || true) && (executionContext == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 4916, 5058);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 4978, 5043);

                    throw f_1185_4984_5042("executionContext");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 4916, 5058);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 5074, 5116);

                string
                shellId = f_1185_5091_5115(executionContext)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 5132, 5163);

                return f_1185_5139_5162(shellId);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1185, 4802, 5174);

                System.Management.Automation.PSArgumentNullException
                f_1185_4984_5042(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 4984, 5042);
                    return return_v;
                }


                string
                f_1185_5091_5115(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ShellID;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 5091, 5115);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.LogProvider>
                f_1185_5139_5162(string
                shellId)
                {
                    var return_v = GetLogProvider(shellId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 5139, 5162);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1185, 4802, 5174);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1185, 4802, 5174);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<LogProvider> GetLogProvider(LogContext logContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1185, 5365, 5677);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 5467, 5519);

                f_1185_5467_5518(logContext != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 5533, 5608);

                f_1185_5533_5607(!f_1185_5566_5606(f_1185_5587_5605(logContext)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 5624, 5666);

                return f_1185_5631_5665(f_1185_5646_5664(logContext));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1185, 5365, 5677);

                int
                f_1185_5467_5518(bool
                condition)
                {
                    System.Diagnostics.Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 5467, 5518);
                    return 0;
                }


                string
                f_1185_5587_5605(System.Management.Automation.LogContext
                this_param)
                {
                    var return_v = this_param.ShellId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 5587, 5605);
                    return return_v;
                }


                bool
                f_1185_5566_5606(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 5566, 5606);
                    return return_v;
                }


                int
                f_1185_5533_5607(bool
                condition)
                {
                    System.Diagnostics.Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 5533, 5607);
                    return 0;
                }


                string
                f_1185_5646_5664(System.Management.Automation.LogContext
                this_param)
                {
                    var return_v = this_param.ShellId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 5646, 5664);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.LogProvider>
                f_1185_5631_5665(string
                shellId)
                {
                    var return_v = GetLogProvider(shellId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 5631, 5665);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1185, 5365, 5677);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1185, 5365, 5677);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Collection<LogProvider> CreateLogProvider(string shellId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1185, 5869, 7232);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 5966, 6032);

                Collection<LogProvider>
                providers = f_1185_6002_6031()
                ;
                // Porting note: Linux does not support ETW

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 6493, 6545);

                    LogProvider
                    etwLogProvider = f_1185_6522_6544()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 6563, 6593);

                    f_1185_6563_6592(providers, etwLogProvider);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 6621, 6638);

                    return providers;
                }
                catch (ArgumentException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1185, 6667, 6722);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1185, 6667, 6722);
                }
                catch (InvalidOperationException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1185, 6736, 6799);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1185, 6736, 6799);
                }
                catch (SecurityException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1185, 6813, 7136);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1185, 6813, 7136);
                    // This exception will happen if we try to create an event source
                    // (corresponding to the current running minishell)
                    // when running as non-admin user. In that case, we will default
                    // to dummy log.
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 7152, 7190);

                f_1185_7152_7189(
                            providers, f_1185_7166_7188());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 7204, 7221);

                return providers;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1185, 5869, 7232);

                System.Collections.ObjectModel.Collection<System.Management.Automation.LogProvider>
                f_1185_6002_6031()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.LogProvider>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 6002, 6031);
                    return return_v;
                }


                System.Management.Automation.Tracing.PSEtwLogProvider
                f_1185_6522_6544()
                {
                    var return_v = new System.Management.Automation.Tracing.PSEtwLogProvider();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 6522, 6544);
                    return return_v;
                }


                int
                f_1185_6563_6592(System.Collections.ObjectModel.Collection<System.Management.Automation.LogProvider>
                this_param, System.Management.Automation.LogProvider
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 6563, 6592);
                    return 0;
                }


                System.Management.Automation.DummyLogProvider
                f_1185_7166_7188()
                {
                    var return_v = new System.Management.Automation.DummyLogProvider();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 7166, 7188);
                    return return_v;
                }


                int
                f_1185_7152_7189(System.Collections.ObjectModel.Collection<System.Management.Automation.LogProvider>
                this_param, System.Management.Automation.DummyLogProvider
                item)
                {
                    this_param.Add((System.Management.Automation.LogProvider)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 7152, 7189);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1185, 5869, 7232);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1185, 5869, 7232);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void SetDummyLog(string shellId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1185, 7404, 7667);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 7477, 7568);

                Collection<LogProvider>
                providers = new Collection<LogProvider> { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1185_7543_7565(), 1185, 7513, 7567) }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 7582, 7656);

                f_1185_7582_7655(s_logProviders, shellId, providers, (key, value) => providers);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1185, 7404, 7667);

                System.Management.Automation.DummyLogProvider
                f_1185_7543_7565()
                {
                    var return_v = new System.Management.Automation.DummyLogProvider();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 7543, 7565);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.LogProvider>
                f_1185_7582_7655(System.Collections.Concurrent.ConcurrentDictionary<string, System.Collections.ObjectModel.Collection<System.Management.Automation.LogProvider>>
                this_param, string
                key, System.Collections.ObjectModel.Collection<System.Management.Automation.LogProvider>
                addValue, System.Func<string, System.Collections.ObjectModel.Collection<System.Management.Automation.LogProvider>, System.Collections.ObjectModel.Collection<System.Management.Automation.LogProvider>>
                updateValueFactory)
                {
                    var return_v = this_param.AddOrUpdate(key, addValue, updateValueFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 7582, 7655);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1185, 7404, 7667);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1185, 7404, 7667);
            }
        }

        internal static void LogEngineHealthEvent(ExecutionContext executionContext,
                                                        int eventId,
                                                        Exception exception,
                                                        Severity severity,
                                                        Dictionary<string, string> additionalInfo,
                                                        EngineState newEngineState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1185, 8717, 10326);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 9187, 9348) || true) && (executionContext == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 9187, 9348);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 9249, 9308);

                    f_1185_9249_9307("executionContext");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 9326, 9333);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 9187, 9348);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 9364, 9511) || true) && (exception == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 9364, 9511);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 9419, 9471);

                    f_1185_9419_9470("exception");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 9489, 9496);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 9364, 9511);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 9527, 9564);

                InvocationInfo
                invocationInfo = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 9578, 9640);

                IContainsErrorRecord
                icer = exception as IContainsErrorRecord
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 9654, 9766) || true) && (icer != null && (DynAbs.Tracing.TraceSender.Expression_True(1185, 9658, 9698) && f_1185_9674_9690(icer) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 9654, 9766);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 9717, 9766);

                    invocationInfo = f_1185_9734_9765(f_1185_9734_9750(icer));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 9654, 9766);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 9780, 10138);
                    foreach (LogProvider provider in f_1185_9813_9845_I(f_1185_9813_9845(executionContext)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 9780, 10138);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 9879, 10123) || true) && (f_1185_9883_9937(provider, executionContext))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 9879, 10123);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 9979, 10104);

                            f_1185_9979_10103(provider, f_1185_10009_10066(executionContext, invocationInfo, severity), eventId, exception, additionalInfo);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 9879, 10123);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 9780, 10138);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1185, 1, 359);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1185, 1, 359);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 10154, 10315) || true) && (newEngineState != EngineState.None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 10154, 10315);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 10226, 10300);

                    f_1185_10226_10299(executionContext, newEngineState, invocationInfo);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 10154, 10315);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1185, 8717, 10326);

                System.Management.Automation.PSArgumentNullException
                f_1185_9249_9307(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 9249, 9307);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1185_9419_9470(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 9419, 9470);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1185_9674_9690(System.Management.Automation.IContainsErrorRecord
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 9674, 9690);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1185_9734_9750(System.Management.Automation.IContainsErrorRecord
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 9734, 9750);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1185_9734_9765(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 9734, 9765);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.LogProvider>
                f_1185_9813_9845(System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = GetLogProvider(executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 9813, 9845);
                    return return_v;
                }


                bool
                f_1185_9883_9937(System.Management.Automation.LogProvider
                logProvider, System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = NeedToLogEngineHealthEvent(logProvider, executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 9883, 9937);
                    return return_v;
                }


                System.Management.Automation.LogContext
                f_1185_10009_10066(System.Management.Automation.ExecutionContext
                executionContext, System.Management.Automation.InvocationInfo
                invocationInfo, System.Management.Automation.Severity
                severity)
                {
                    var return_v = GetLogContext(executionContext, invocationInfo, severity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 10009, 10066);
                    return return_v;
                }


                int
                f_1185_9979_10103(System.Management.Automation.LogProvider
                this_param, System.Management.Automation.LogContext
                logContext, int
                eventId, System.Exception
                exception, System.Collections.Generic.Dictionary<string, string>
                additionalInfo)
                {
                    this_param.LogEngineHealthEvent(logContext, eventId, exception, additionalInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 9979, 10103);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.LogProvider>
                f_1185_9813_9845_I(System.Collections.Generic.IEnumerable<System.Management.Automation.LogProvider>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 9813, 9845);
                    return return_v;
                }


                int
                f_1185_10226_10299(System.Management.Automation.ExecutionContext
                executionContext, System.Management.Automation.EngineState
                engineState, System.Management.Automation.InvocationInfo
                invocationInfo)
                {
                    LogEngineLifecycleEvent(executionContext, engineState, invocationInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 10226, 10299);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1185, 8717, 10326);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1185, 8717, 10326);
            }
        }

        internal static void LogEngineHealthEvent(ExecutionContext executionContext,
                                                        int eventId,
                                                        Exception exception,
                                                        Severity severity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1185, 10699, 11086);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 11000, 11075);

                f_1185_11000_11074(executionContext, eventId, exception, severity, null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1185, 10699, 11086);

                int
                f_1185_11000_11074(System.Management.Automation.ExecutionContext
                executionContext, int
                eventId, System.Exception
                exception, System.Management.Automation.Severity
                severity, System.Collections.Generic.Dictionary<string, string>
                additionalInfo)
                {
                    LogEngineHealthEvent(executionContext, eventId, exception, severity, additionalInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 11000, 11074);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1185, 10699, 11086);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1185, 10699, 11086);
            }
        }

        internal static void LogEngineHealthEvent(ExecutionContext executionContext,
                                                        Exception exception,
                                                        Severity severity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1185, 11507, 11828);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 11746, 11817);

                f_1185_11746_11816(executionContext, 100, exception, severity, null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1185, 11507, 11828);

                int
                f_1185_11746_11816(System.Management.Automation.ExecutionContext
                executionContext, int
                eventId, System.Exception
                exception, System.Management.Automation.Severity
                severity, System.Collections.Generic.Dictionary<string, string>
                additionalInfo)
                {
                    LogEngineHealthEvent(executionContext, eventId, exception, severity, additionalInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 11746, 11816);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1185, 11507, 11828);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1185, 11507, 11828);
            }
        }

        internal static void LogEngineHealthEvent(ExecutionContext executionContext,
                                                        int eventId,
                                                        Exception exception,
                                                        Severity severity,
                                                        Dictionary<string, string> additionalInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1185, 12233, 12740);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 12626, 12729);

                f_1185_12626_12728(executionContext, eventId, exception, severity, additionalInfo, EngineState.None);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1185, 12233, 12740);

                int
                f_1185_12626_12728(System.Management.Automation.ExecutionContext
                executionContext, int
                eventId, System.Exception
                exception, System.Management.Automation.Severity
                severity, System.Collections.Generic.Dictionary<string, string>
                additionalInfo, System.Management.Automation.EngineState
                newEngineState)
                {
                    LogEngineHealthEvent(executionContext, eventId, exception, severity, additionalInfo, newEngineState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 12626, 12728);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1185, 12233, 12740);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1185, 12233, 12740);
            }
        }

        internal static void LogEngineHealthEvent(ExecutionContext executionContext,
                                                        int eventId,
                                                        Exception exception,
                                                        Severity severity,
                                                        EngineState newEngineState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1185, 13145, 13625);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 13523, 13614);

                f_1185_13523_13613(executionContext, eventId, exception, severity, null, newEngineState);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1185, 13145, 13625);

                int
                f_1185_13523_13613(System.Management.Automation.ExecutionContext
                executionContext, int
                eventId, System.Exception
                exception, System.Management.Automation.Severity
                severity, System.Collections.Generic.Dictionary<string, string>
                additionalInfo, System.Management.Automation.EngineState
                newEngineState)
                {
                    LogEngineHealthEvent(executionContext, eventId, exception, severity, additionalInfo, newEngineState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 13523, 13613);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1185, 13145, 13625);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1185, 13145, 13625);
            }
        }

        internal static void LogEngineHealthEvent(LogContext logContext,
                                                        int eventId,
                                                        Exception exception,
                                                        Dictionary<string, string> additionalInfo
                                                        )
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1185, 14318, 15364);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 14681, 14830) || true) && (logContext == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 14681, 14830);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 14737, 14790);

                    f_1185_14737_14789("logContext");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 14808, 14815);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 14681, 14830);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 14846, 14993) || true) && (exception == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 14846, 14993);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 14901, 14953);

                    f_1185_14901_14952("exception");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 14971, 14978);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 14846, 14993);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 15167, 15353);
                    foreach (LogProvider provider in f_1185_15200_15226_I(f_1185_15200_15226(logContext)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 15167, 15353);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 15260, 15338);

                        f_1185_15260_15337(provider, logContext, eventId, exception, additionalInfo);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 15167, 15353);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1185, 1, 187);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1185, 1, 187);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1185, 14318, 15364);

                System.Management.Automation.PSArgumentNullException
                f_1185_14737_14789(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 14737, 14789);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1185_14901_14952(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 14901, 14952);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.LogProvider>
                f_1185_15200_15226(System.Management.Automation.LogContext
                logContext)
                {
                    var return_v = GetLogProvider(logContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 15200, 15226);
                    return return_v;
                }


                int
                f_1185_15260_15337(System.Management.Automation.LogProvider
                this_param, System.Management.Automation.LogContext
                logContext, int
                eventId, System.Exception
                exception, System.Collections.Generic.Dictionary<string, string>
                additionalInfo)
                {
                    this_param.LogEngineHealthEvent(logContext, eventId, exception, additionalInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 15260, 15337);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.LogProvider>
                f_1185_15200_15226_I(System.Collections.Generic.IEnumerable<System.Management.Automation.LogProvider>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 15200, 15226);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1185, 14318, 15364);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1185, 14318, 15364);
            }
        }

        internal static void LogEngineLifecycleEvent(ExecutionContext executionContext,
                                                        EngineState engineState,
                                                        InvocationInfo invocationInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1185, 16096, 17099);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 16354, 16515) || true) && (executionContext == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 16354, 16515);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 16416, 16475);

                    f_1185_16416_16474("executionContext");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 16493, 16500);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 16354, 16515);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 16531, 16592);

                EngineState
                previousState = f_1185_16559_16591(executionContext)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 16606, 16664) || true) && (engineState == previousState)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 16606, 16664);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 16657, 16664);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 16606, 16664);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 16680, 17026);
                    foreach (LogProvider provider in f_1185_16713_16745_I(f_1185_16713_16745(executionContext)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 16680, 17026);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 16779, 17011) || true) && (f_1185_16783_16840(provider, executionContext))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 16779, 17011);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 16882, 16992);

                            f_1185_16882_16991(provider, f_1185_16915_16962(executionContext, invocationInfo), engineState, previousState);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 16779, 17011);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 16680, 17026);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1185, 1, 347);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1185, 1, 347);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 17042, 17088);

                f_1185_17042_17087(executionContext, engineState);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1185, 16096, 17099);

                System.Management.Automation.PSArgumentNullException
                f_1185_16416_16474(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 16416, 16474);
                    return return_v;
                }


                System.Management.Automation.EngineState
                f_1185_16559_16591(System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = GetEngineState(executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 16559, 16591);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.LogProvider>
                f_1185_16713_16745(System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = GetLogProvider(executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 16713, 16745);
                    return return_v;
                }


                bool
                f_1185_16783_16840(System.Management.Automation.LogProvider
                logProvider, System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = NeedToLogEngineLifecycleEvent(logProvider, executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 16783, 16840);
                    return return_v;
                }


                System.Management.Automation.LogContext
                f_1185_16915_16962(System.Management.Automation.ExecutionContext
                executionContext, System.Management.Automation.InvocationInfo
                invocationInfo)
                {
                    var return_v = GetLogContext(executionContext, invocationInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 16915, 16962);
                    return return_v;
                }


                int
                f_1185_16882_16991(System.Management.Automation.LogProvider
                this_param, System.Management.Automation.LogContext
                logContext, System.Management.Automation.EngineState
                newState, System.Management.Automation.EngineState
                previousState)
                {
                    this_param.LogEngineLifecycleEvent(logContext, newState, previousState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 16882, 16991);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.LogProvider>
                f_1185_16713_16745_I(System.Collections.Generic.IEnumerable<System.Management.Automation.LogProvider>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 16713, 16745);
                    return return_v;
                }


                int
                f_1185_17042_17087(System.Management.Automation.ExecutionContext
                executionContext, System.Management.Automation.EngineState
                engineState)
                {
                    SetEngineState(executionContext, engineState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 17042, 17087);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1185, 16096, 17099);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1185, 16096, 17099);
            }
        }

        internal static void LogEngineLifecycleEvent(ExecutionContext executionContext,
                                                        EngineState engineState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1185, 17379, 17629);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 17557, 17618);

                f_1185_17557_17617(executionContext, engineState, null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1185, 17379, 17629);

                int
                f_1185_17557_17617(System.Management.Automation.ExecutionContext
                executionContext, System.Management.Automation.EngineState
                engineState, System.Management.Automation.InvocationInfo
                invocationInfo)
                {
                    LogEngineLifecycleEvent(executionContext, engineState, invocationInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 17557, 17617);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1185, 17379, 17629);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1185, 17379, 17629);
            }
        }

        internal static void LogCommandHealthEvent(ExecutionContext executionContext,
                                                        Exception exception,
                                                        Severity severity
                                                        )
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1185, 18080, 19309);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 18370, 18531) || true) && (executionContext == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 18370, 18531);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 18432, 18491);

                    f_1185_18432_18490("executionContext");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 18509, 18516);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 18370, 18531);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 18547, 18694) || true) && (exception == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 18547, 18694);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 18602, 18654);

                    f_1185_18602_18653("exception");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 18672, 18679);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 18547, 18694);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 18710, 18747);

                InvocationInfo
                invocationInfo = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 18761, 18823);

                IContainsErrorRecord
                icer = exception as IContainsErrorRecord
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 18837, 18949) || true) && (icer != null && (DynAbs.Tracing.TraceSender.Expression_True(1185, 18841, 18881) && f_1185_18857_18873(icer) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 18837, 18949);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 18900, 18949);

                    invocationInfo = f_1185_18917_18948(f_1185_18917_18933(icer));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 18837, 18949);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 18963, 19298);
                    foreach (LogProvider provider in f_1185_18996_19028_I(f_1185_18996_19028(executionContext)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 18963, 19298);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 19062, 19283) || true) && (f_1185_19066_19121(provider, executionContext))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 19062, 19283);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 19163, 19264);

                            f_1185_19163_19263(provider, f_1185_19194_19251(executionContext, invocationInfo, severity), exception);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 19062, 19283);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 18963, 19298);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1185, 1, 336);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1185, 1, 336);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1185, 18080, 19309);

                System.Management.Automation.PSArgumentNullException
                f_1185_18432_18490(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 18432, 18490);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1185_18602_18653(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 18602, 18653);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1185_18857_18873(System.Management.Automation.IContainsErrorRecord
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 18857, 18873);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1185_18917_18933(System.Management.Automation.IContainsErrorRecord
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 18917, 18933);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1185_18917_18948(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 18917, 18948);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.LogProvider>
                f_1185_18996_19028(System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = GetLogProvider(executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 18996, 19028);
                    return return_v;
                }


                bool
                f_1185_19066_19121(System.Management.Automation.LogProvider
                logProvider, System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = NeedToLogCommandHealthEvent(logProvider, executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 19066, 19121);
                    return return_v;
                }


                System.Management.Automation.LogContext
                f_1185_19194_19251(System.Management.Automation.ExecutionContext
                executionContext, System.Management.Automation.InvocationInfo
                invocationInfo, System.Management.Automation.Severity
                severity)
                {
                    var return_v = GetLogContext(executionContext, invocationInfo, severity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 19194, 19251);
                    return return_v;
                }


                int
                f_1185_19163_19263(System.Management.Automation.LogProvider
                this_param, System.Management.Automation.LogContext
                logContext, System.Exception
                exception)
                {
                    this_param.LogCommandHealthEvent(logContext, exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 19163, 19263);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.LogProvider>
                f_1185_18996_19028_I(System.Collections.Generic.IEnumerable<System.Management.Automation.LogProvider>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 18996, 19028);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1185, 18080, 19309);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1185, 18080, 19309);
            }
        }

        internal static void LogCommandLifecycleEvent(ExecutionContext executionContext,
                                                        CommandState commandState,
                                                        InvocationInfo invocationInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1185, 19873, 21066);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 20134, 20295) || true) && (executionContext == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 20134, 20295);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 20196, 20255);

                    f_1185_20196_20254("executionContext");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 20273, 20280);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 20134, 20295);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 20311, 20468) || true) && (invocationInfo == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 20311, 20468);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 20371, 20428);

                    f_1185_20371_20427("invocationInfo");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 20446, 20453);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 20311, 20468);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 20484, 20601) || true) && (f_1185_20488_20545(s_ignoredCommands, f_1185_20515_20544(f_1185_20515_20539(invocationInfo))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 20484, 20601);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 20579, 20586);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 20484, 20601);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 20617, 20646);

                LogContext
                logContext = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 20660, 21055);
                    foreach (LogProvider provider in f_1185_20693_20725_I(f_1185_20693_20725(executionContext)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 20660, 21055);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 20759, 21040) || true) && (f_1185_20763_20821(provider, executionContext))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 20759, 21040);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 20863, 21021);

                            f_1185_20863_21020(provider, () => logContext ?? (logContext = GetLogContext(executionContext, invocationInfo)), commandState);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 20759, 21040);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 20660, 21055);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1185, 1, 396);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1185, 1, 396);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1185, 19873, 21066);

                System.Management.Automation.PSArgumentNullException
                f_1185_20196_20254(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 20196, 20254);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1185_20371_20427(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 20371, 20427);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1185_20515_20539(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.MyCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 20515, 20539);
                    return return_v;
                }


                string
                f_1185_20515_20544(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 20515, 20544);
                    return return_v;
                }


                bool
                f_1185_20488_20545(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 20488, 20545);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.LogProvider>
                f_1185_20693_20725(System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = GetLogProvider(executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 20693, 20725);
                    return return_v;
                }


                bool
                f_1185_20763_20821(System.Management.Automation.LogProvider
                logProvider, System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = NeedToLogCommandLifecycleEvent(logProvider, executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 20763, 20821);
                    return return_v;
                }


                int
                f_1185_20863_21020(System.Management.Automation.LogProvider
                this_param, System.Func<System.Management.Automation.LogContext>
                getLogContext, System.Management.Automation.CommandState
                newState)
                {
                    this_param.LogCommandLifecycleEvent(getLogContext, newState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 20863, 21020);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.LogProvider>
                f_1185_20693_20725_I(System.Collections.Generic.IEnumerable<System.Management.Automation.LogProvider>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 20693, 20725);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1185, 19873, 21066);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1185, 19873, 21066);
            }
        }

        internal static void LogCommandLifecycleEvent(ExecutionContext executionContext,
                                                        CommandState commandState,
                                                        string commandName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1185, 21677, 22851);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 21927, 22088) || true) && (executionContext == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 21927, 22088);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 21989, 22048);

                    f_1185_21989_22047("executionContext");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 22066, 22073);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 21927, 22088);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 22104, 22133);

                LogContext
                logContext = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 22147, 22840);
                    foreach (LogProvider provider in f_1185_22180_22212_I(f_1185_22180_22212(executionContext)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 22147, 22840);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 22246, 22825) || true) && (f_1185_22250_22308(provider, executionContext))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 22246, 22825);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 22350, 22806);

                            f_1185_22350_22805(provider, () =>
                                {
                                    if (logContext == null)
                                    {
                                        logContext = GetLogContext(executionContext, null);
                                        logContext.CommandName = commandName;
                                    }

                                    return logContext;
                                }, commandState);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 22246, 22825);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 22147, 22840);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1185, 1, 694);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1185, 1, 694);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1185, 21677, 22851);

                System.Management.Automation.PSArgumentNullException
                f_1185_21989_22047(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 21989, 22047);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.LogProvider>
                f_1185_22180_22212(System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = GetLogProvider(executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 22180, 22212);
                    return return_v;
                }


                bool
                f_1185_22250_22308(System.Management.Automation.LogProvider
                logProvider, System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = NeedToLogCommandLifecycleEvent(logProvider, executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 22250, 22308);
                    return return_v;
                }


                int
                f_1185_22350_22805(System.Management.Automation.LogProvider
                this_param, System.Func<System.Management.Automation.LogContext>
                getLogContext, System.Management.Automation.CommandState
                newState)
                {
                    this_param.LogCommandLifecycleEvent(getLogContext, newState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 22350, 22805);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.LogProvider>
                f_1185_22180_22212_I(System.Collections.Generic.IEnumerable<System.Management.Automation.LogProvider>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 22180, 22212);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1185, 21677, 22851);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1185, 21677, 22851);
            }
        }

        internal static void LogPipelineExecutionDetailEvent(ExecutionContext executionContext,
                                                                    List<string> detail,
                                                                    InvocationInfo invocationInfo)
        {
            try

            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1185, 23383, 24201);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 23671, 23832) || true) && (executionContext == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 23671, 23832);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 23733, 23792);

                    f_1185_23733_23791("executionContext");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 23810, 23817);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 23671, 23832);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 23848, 24190);
                    foreach (LogProvider provider in f_1185_23881_23913_I(f_1185_23881_23913(executionContext)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 23848, 24190);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 23947, 24175) || true) && (f_1185_23951_24016(provider, executionContext))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 23947, 24175);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 24058, 24156);

                            f_1185_24058_24155(provider, f_1185_24099_24146(executionContext, invocationInfo), detail);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 23947, 24175);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 23848, 24190);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1185, 1, 343);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1185, 1, 343);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1185, 23383, 24201);

                System.Management.Automation.PSArgumentNullException
                f_1185_23733_23791(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 23733, 23791);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.LogProvider>
                f_1185_23881_23913(System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = GetLogProvider(executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 23881, 23913);
                    return return_v;
                }


                bool
                f_1185_23951_24016(System.Management.Automation.LogProvider
                logProvider, System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = NeedToLogPipelineExecutionDetailEvent(logProvider, executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 23951, 24016);
                    return return_v;
                }


                System.Management.Automation.LogContext
                f_1185_24099_24146(System.Management.Automation.ExecutionContext
                executionContext, System.Management.Automation.InvocationInfo
                invocationInfo)
                {
                    var return_v = GetLogContext(executionContext, invocationInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 24099, 24146);
                    return return_v;
                }


                int
                f_1185_24058_24155(System.Management.Automation.LogProvider
                this_param, System.Management.Automation.LogContext
                logContext, System.Collections.Generic.List<string>
                pipelineExecutionDetail)
                {
                    this_param.LogPipelineExecutionDetailEvent(logContext, pipelineExecutionDetail);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 24058, 24155);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.LogProvider>
                f_1185_23881_23913_I(System.Collections.Generic.IEnumerable<System.Management.Automation.LogProvider>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 23881, 23913);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1185, 23383, 24201);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1185, 23383, 24201);
            }
        }

        internal static void LogPipelineExecutionDetailEvent(ExecutionContext executionContext,
                                                                    List<string> detail,
                                                                    string scriptName,
                                                                    string commandLine)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1185, 24946, 25972);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 25301, 25462) || true) && (executionContext == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 25301, 25462);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 25363, 25422);

                    f_1185_25363_25421("executionContext");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 25440, 25447);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 25301, 25462);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 25478, 25540);

                LogContext
                logContext = f_1185_25502_25539(executionContext, null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 25554, 25591);

                logContext.CommandLine = commandLine;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 25605, 25640);

                logContext.ScriptName = scriptName;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 25656, 25961);
                    foreach (LogProvider provider in f_1185_25689_25721_I(f_1185_25689_25721(executionContext)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 25656, 25961);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 25755, 25946) || true) && (f_1185_25759_25824(provider, executionContext))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 25755, 25946);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 25866, 25927);

                            f_1185_25866_25926(provider, logContext, detail);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 25755, 25946);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 25656, 25961);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1185, 1, 306);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1185, 1, 306);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1185, 24946, 25972);

                System.Management.Automation.PSArgumentNullException
                f_1185_25363_25421(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 25363, 25421);
                    return return_v;
                }


                System.Management.Automation.LogContext
                f_1185_25502_25539(System.Management.Automation.ExecutionContext
                executionContext, System.Management.Automation.InvocationInfo
                invocationInfo)
                {
                    var return_v = GetLogContext(executionContext, invocationInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 25502, 25539);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.LogProvider>
                f_1185_25689_25721(System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = GetLogProvider(executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 25689, 25721);
                    return return_v;
                }


                bool
                f_1185_25759_25824(System.Management.Automation.LogProvider
                logProvider, System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = NeedToLogPipelineExecutionDetailEvent(logProvider, executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 25759, 25824);
                    return return_v;
                }


                int
                f_1185_25866_25926(System.Management.Automation.LogProvider
                this_param, System.Management.Automation.LogContext
                logContext, System.Collections.Generic.List<string>
                pipelineExecutionDetail)
                {
                    this_param.LogPipelineExecutionDetailEvent(logContext, pipelineExecutionDetail);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 25866, 25926);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.LogProvider>
                f_1185_25689_25721_I(System.Collections.Generic.IEnumerable<System.Management.Automation.LogProvider>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 25689, 25721);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1185, 24946, 25972);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1185, 24946, 25972);
            }
        }

        internal static void LogProviderHealthEvent(ExecutionContext executionContext,
                                                        string providerName,
                                                        Exception exception,
                                                        Severity severity
                                                        )
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1185, 26495, 27811);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 26856, 27017) || true) && (executionContext == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 26856, 27017);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 26918, 26977);

                    f_1185_26918_26976("executionContext");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 26995, 27002);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 26856, 27017);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 27033, 27180) || true) && (exception == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 27033, 27180);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 27088, 27140);

                    f_1185_27088_27139("exception");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 27158, 27165);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 27033, 27180);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 27196, 27233);

                InvocationInfo
                invocationInfo = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 27247, 27309);

                IContainsErrorRecord
                icer = exception as IContainsErrorRecord
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 27323, 27435) || true) && (icer != null && (DynAbs.Tracing.TraceSender.Expression_True(1185, 27327, 27367) && f_1185_27343_27359(icer) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 27323, 27435);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 27386, 27435);

                    invocationInfo = f_1185_27403_27434(f_1185_27403_27419(icer));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 27323, 27435);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 27449, 27800);
                    foreach (LogProvider provider in f_1185_27482_27514_I(f_1185_27482_27514(executionContext)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 27449, 27800);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 27548, 27785) || true) && (f_1185_27552_27608(provider, executionContext))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 27548, 27785);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 27650, 27766);

                            f_1185_27650_27765(provider, f_1185_27682_27739(executionContext, invocationInfo, severity), providerName, exception);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 27548, 27785);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 27449, 27800);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1185, 1, 352);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1185, 1, 352);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1185, 26495, 27811);

                System.Management.Automation.PSArgumentNullException
                f_1185_26918_26976(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 26918, 26976);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1185_27088_27139(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 27088, 27139);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1185_27343_27359(System.Management.Automation.IContainsErrorRecord
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 27343, 27359);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1185_27403_27419(System.Management.Automation.IContainsErrorRecord
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 27403, 27419);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1185_27403_27434(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 27403, 27434);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.LogProvider>
                f_1185_27482_27514(System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = GetLogProvider(executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 27482, 27514);
                    return return_v;
                }


                bool
                f_1185_27552_27608(System.Management.Automation.LogProvider
                logProvider, System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = NeedToLogProviderHealthEvent(logProvider, executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 27552, 27608);
                    return return_v;
                }


                System.Management.Automation.LogContext
                f_1185_27682_27739(System.Management.Automation.ExecutionContext
                executionContext, System.Management.Automation.InvocationInfo
                invocationInfo, System.Management.Automation.Severity
                severity)
                {
                    var return_v = GetLogContext(executionContext, invocationInfo, severity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 27682, 27739);
                    return return_v;
                }


                int
                f_1185_27650_27765(System.Management.Automation.LogProvider
                this_param, System.Management.Automation.LogContext
                logContext, string
                providerName, System.Exception
                exception)
                {
                    this_param.LogProviderHealthEvent(logContext, providerName, exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 27650, 27765);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.LogProvider>
                f_1185_27482_27514_I(System.Collections.Generic.IEnumerable<System.Management.Automation.LogProvider>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 27482, 27514);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1185, 26495, 27811);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1185, 26495, 27811);
            }
        }

        internal static void LogProviderLifecycleEvent(ExecutionContext executionContext,
                                                             string providerName,
                                                             ProviderState providerState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1185, 28345, 29138);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 28609, 28770) || true) && (executionContext == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 28609, 28770);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 28671, 28730);

                    f_1185_28671_28729("executionContext");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 28748, 28755);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 28609, 28770);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 28786, 29127);
                    foreach (LogProvider provider in f_1185_28819_28851_I(f_1185_28819_28851(executionContext)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 28786, 29127);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 28885, 29112) || true) && (f_1185_28889_28948(provider, executionContext))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 28885, 29112);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 28990, 29093);

                            f_1185_28990_29092(provider, f_1185_29025_29062(executionContext, null), providerName, providerState);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 28885, 29112);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 28786, 29127);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1185, 1, 342);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1185, 1, 342);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1185, 28345, 29138);

                System.Management.Automation.PSArgumentNullException
                f_1185_28671_28729(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 28671, 28729);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.LogProvider>
                f_1185_28819_28851(System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = GetLogProvider(executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 28819, 28851);
                    return return_v;
                }


                bool
                f_1185_28889_28948(System.Management.Automation.LogProvider
                logProvider, System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = NeedToLogProviderLifecycleEvent(logProvider, executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 28889, 28948);
                    return return_v;
                }


                System.Management.Automation.LogContext
                f_1185_29025_29062(System.Management.Automation.ExecutionContext
                executionContext, System.Management.Automation.InvocationInfo
                invocationInfo)
                {
                    var return_v = GetLogContext(executionContext, invocationInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 29025, 29062);
                    return return_v;
                }


                int
                f_1185_28990_29092(System.Management.Automation.LogProvider
                this_param, System.Management.Automation.LogContext
                logContext, string
                providerName, System.Management.Automation.ProviderState
                newState)
                {
                    this_param.LogProviderLifecycleEvent(logContext, providerName, newState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 28990, 29092);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.LogProvider>
                f_1185_28819_28851_I(System.Collections.Generic.IEnumerable<System.Management.Automation.LogProvider>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 28819, 28851);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1185, 28345, 29138);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1185, 28345, 29138);
            }
        }

        internal static void LogSettingsEvent(ExecutionContext executionContext,
                                                    string variableName,
                                                    string newValue,
                                                    string previousValue,
                                                    InvocationInfo invocationInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1185, 29918, 30817);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 30286, 30447) || true) && (executionContext == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 30286, 30447);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 30348, 30407);

                    f_1185_30348_30406("executionContext");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 30425, 30432);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 30286, 30447);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 30463, 30806);
                    foreach (LogProvider provider in f_1185_30496_30528_I(f_1185_30496_30528(executionContext)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 30463, 30806);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 30562, 30791) || true) && (f_1185_30566_30616(provider, executionContext))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 30562, 30791);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 30658, 30772);

                            f_1185_30658_30771(provider, f_1185_30684_30731(executionContext, invocationInfo), variableName, newValue, previousValue);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 30562, 30791);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 30463, 30806);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1185, 1, 344);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1185, 1, 344);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1185, 29918, 30817);

                System.Management.Automation.PSArgumentNullException
                f_1185_30348_30406(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 30348, 30406);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.LogProvider>
                f_1185_30496_30528(System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = GetLogProvider(executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 30496, 30528);
                    return return_v;
                }


                bool
                f_1185_30566_30616(System.Management.Automation.LogProvider
                logProvider, System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = NeedToLogSettingsEvent(logProvider, executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 30566, 30616);
                    return return_v;
                }


                System.Management.Automation.LogContext
                f_1185_30684_30731(System.Management.Automation.ExecutionContext
                executionContext, System.Management.Automation.InvocationInfo
                invocationInfo)
                {
                    var return_v = GetLogContext(executionContext, invocationInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 30684, 30731);
                    return return_v;
                }


                int
                f_1185_30658_30771(System.Management.Automation.LogProvider
                this_param, System.Management.Automation.LogContext
                logContext, string
                variableName, string
                value, string
                previousValue)
                {
                    this_param.LogSettingsEvent(logContext, variableName, value, previousValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 30658, 30771);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.LogProvider>
                f_1185_30496_30528_I(System.Collections.Generic.IEnumerable<System.Management.Automation.LogProvider>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 30496, 30528);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1185, 29918, 30817);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1185, 29918, 30817);
            }
        }

        internal static void LogSettingsEvent(ExecutionContext executionContext,
                                                    string variableName,
                                                    string newValue,
                                                    string previousValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1185, 31167, 31550);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 31459, 31539);

                f_1185_31459_31538(executionContext, variableName, newValue, previousValue, null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1185, 31167, 31550);

                int
                f_1185_31459_31538(System.Management.Automation.ExecutionContext
                executionContext, string
                variableName, string
                newValue, string
                previousValue, System.Management.Automation.InvocationInfo
                invocationInfo)
                {
                    LogSettingsEvent(executionContext, variableName, newValue, previousValue, invocationInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 31459, 31538);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1185, 31167, 31550);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1185, 31167, 31550);
            }
        }

        private static EngineState GetEngineState(ExecutionContext executionContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1185, 31943, 32091);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 32044, 32080);

                return f_1185_32051_32079(executionContext);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1185, 31943, 32091);

                System.Management.Automation.EngineState
                f_1185_32051_32079(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 32051, 32079);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1185, 31943, 32091);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1185, 31943, 32091);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void SetEngineState(ExecutionContext executionContext, EngineState engineState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1185, 32441, 32614);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 32560, 32603);

                executionContext.EngineState = engineState;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1185, 32441, 32614);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1185, 32441, 32614);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1185, 32441, 32614);
            }
        }

        internal static LogContext GetLogContext(ExecutionContext executionContext, InvocationInfo invocationInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1185, 32991, 33212);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 33122, 33201);

                return f_1185_33129_33200(executionContext, invocationInfo, Severity.Informational);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1185, 32991, 33212);

                System.Management.Automation.LogContext
                f_1185_33129_33200(System.Management.Automation.ExecutionContext
                executionContext, System.Management.Automation.InvocationInfo
                invocationInfo, System.Management.Automation.Severity
                severity)
                {
                    var return_v = GetLogContext(executionContext, invocationInfo, severity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 33129, 33200);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1185, 32991, 33212);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1185, 32991, 33212);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static LogContext GetLogContext(ExecutionContext executionContext, InvocationInfo invocationInfo, Severity severity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1185, 33634, 37299);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 33783, 33842) || true) && (executionContext == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 33783, 33842);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 33830, 33842);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 33783, 33842);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 33858, 33899);

                LogContext
                logContext = f_1185_33882_33898()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 33915, 33957);

                string
                shellId = f_1185_33932_33956(executionContext)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 33973, 34020);

                logContext.ExecutionContext = executionContext;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 34034, 34063);

                logContext.ShellId = shellId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 34077, 34119);

                logContext.Severity = f_1185_34099_34118(severity);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 34135, 34500) || true) && (f_1185_34139_34175(executionContext) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 34135, 34500);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 34217, 34281);

                    logContext.HostName = f_1185_34239_34280(f_1185_34239_34275(executionContext));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 34299, 34380);

                    logContext.HostVersion = f_1185_34324_34379(f_1185_34324_34368(f_1185_34324_34360(executionContext)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 34398, 34485);

                    logContext.HostId = (string)f_1185_34426_34462(executionContext).InstanceId.ToString();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 34135, 34500);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 34516, 34596);

                logContext.HostApplication = f_1185_34545_34595(" ", f_1185_34562_34594());

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 34612, 35201) || true) && (f_1185_34616_34648(executionContext) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 34612, 35201);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 34690, 34769);

                    logContext.EngineVersion = f_1185_34717_34768(f_1185_34717_34757(f_1185_34717_34749(executionContext)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 34787, 34866);

                    logContext.RunspaceId = f_1185_34811_34843(executionContext).InstanceId.ToString();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 34886, 34992);

                    Pipeline
                    currentPipeline = f_1185_34913_34991(((RunspaceBase)f_1185_34928_34960(executionContext)))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 35010, 35186) || true) && (currentPipeline != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 35010, 35186);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 35079, 35167);

                        logContext.PipelineId = f_1185_35103_35166(f_1185_35103_35129(currentPipeline), f_1185_35139_35165());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 35010, 35186);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 34612, 35201);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 35217, 35264);

                logContext.SequenceNumber = f_1185_35245_35263();

                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 35316, 35717) || true) && (f_1185_35320_35357(f_1185_35320_35352(executionContext)) == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 35316, 35717);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 35407, 35482);

                        logContext.User = f_1185_35425_35451() + "\\" + f_1185_35461_35481();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 35504, 35560);

                        f_1185_35504_35536(executionContext).User = f_1185_35544_35559(logContext);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 35316, 35717);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 35316, 35717);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 35642, 35698);

                        logContext.User = f_1185_35660_35697(f_1185_35660_35692(executionContext));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 35316, 35717);
                    }
                }
                catch (InvalidOperationException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1185, 35746, 35869);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 35812, 35854);

                    logContext.User = f_1185_35830_35853();
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1185, 35746, 35869);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 35885, 36092);

                System.Management.Automation.Remoting.PSSenderInfo
                psSenderInfo =
                f_1185_35972_36037(f_1185_35972_36012(f_1185_35972_36001(executionContext)), "PSSenderInfo") as System.Management.Automation.Remoting.PSSenderInfo
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 36106, 36242) || true) && (psSenderInfo != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 36106, 36242);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 36164, 36227);

                    logContext.ConnectedUser = f_1185_36191_36226(f_1185_36191_36221(f_1185_36191_36212(psSenderInfo)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 36106, 36242);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 36258, 36326);

                logContext.Time = DateTime.Now.ToString(f_1185_36298_36324());

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 36342, 36405) || true) && (invocationInfo == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 36342, 36405);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 36387, 36405);

                    return logContext;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 36342, 36405);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 36421, 36471);

                logContext.ScriptName = f_1185_36445_36470(invocationInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 36485, 36530);

                logContext.CommandLine = f_1185_36510_36529(invocationInfo);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 36546, 37254) || true) && (f_1185_36550_36574(invocationInfo) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 36546, 37254);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 36616, 36671);

                    logContext.CommandName = f_1185_36641_36670(f_1185_36641_36665(invocationInfo));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 36689, 36762);

                    logContext.CommandType = f_1185_36714_36761(f_1185_36714_36750(f_1185_36714_36738(invocationInfo)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 36782, 37239);

                    switch (f_1185_36790_36826(f_1185_36790_36814(invocationInfo)))
                    {

                        case CommandTypes.Application:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 36782, 37239);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 36924, 36998);

                            logContext.CommandPath = f_1185_36949_36997(((ApplicationInfo)f_1185_36967_36991(invocationInfo)));
                            DynAbs.Tracing.TraceSender.TraceBreak(1185, 37024, 37030);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 36782, 37239);

                        case CommandTypes.ExternalScript:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 36782, 37239);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 37111, 37188);

                            logContext.CommandPath = f_1185_37136_37187(((ExternalScriptInfo)f_1185_37157_37181(invocationInfo)));
                            DynAbs.Tracing.TraceSender.TraceBreak(1185, 37214, 37220);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 36782, 37239);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 36546, 37254);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 37270, 37288);

                return logContext;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1185, 33634, 37299);

                System.Management.Automation.LogContext
                f_1185_33882_33898()
                {
                    var return_v = new System.Management.Automation.LogContext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 33882, 33898);
                    return return_v;
                }


                string
                f_1185_33932_33956(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ShellID;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 33932, 33956);
                    return return_v;
                }


                string
                f_1185_34099_34118(System.Management.Automation.Severity
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 34099, 34118);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1185_34139_34175(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineHostInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 34139, 34175);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1185_34239_34275(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineHostInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 34239, 34275);
                    return return_v;
                }


                string
                f_1185_34239_34280(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 34239, 34280);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1185_34324_34360(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineHostInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 34324, 34360);
                    return return_v;
                }


                System.Version
                f_1185_34324_34368(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 34324, 34368);
                    return return_v;
                }


                string
                f_1185_34324_34379(System.Version
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 34324, 34379);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1185_34426_34462(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineHostInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 34426, 34462);
                    return return_v;
                }


                string[]
                f_1185_34562_34594()
                {
                    var return_v = Environment.GetCommandLineArgs();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 34562, 34594);
                    return return_v;
                }


                string
                f_1185_34545_34595(string
                separator, params string[]
                value)
                {
                    var return_v = string.Join(separator, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 34545, 34595);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1185_34616_34648(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 34616, 34648);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1185_34717_34749(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 34717, 34749);
                    return return_v;
                }


                System.Version
                f_1185_34717_34757(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 34717, 34757);
                    return return_v;
                }


                string
                f_1185_34717_34768(System.Version
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 34717, 34768);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1185_34811_34843(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 34811, 34843);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1185_34928_34960(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 34928, 34960);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Pipeline
                f_1185_34913_34991(System.Management.Automation.Runspaces.RunspaceBase
                this_param)
                {
                    var return_v = this_param.GetCurrentlyRunningPipeline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 34913, 34991);
                    return return_v;
                }


                long
                f_1185_35103_35129(System.Management.Automation.Runspaces.Pipeline
                this_param)
                {
                    var return_v = this_param.InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 35103, 35129);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1185_35139_35165()
                {
                    var return_v = CultureInfo.CurrentCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 35139, 35165);
                    return return_v;
                }


                string
                f_1185_35103_35166(long
                this_param, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = this_param.ToString((System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 35103, 35166);
                    return return_v;
                }


                string
                f_1185_35245_35263()
                {
                    var return_v = NextSequenceNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 35245, 35263);
                    return return_v;
                }


                System.Management.Automation.LogContextCache
                f_1185_35320_35352(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.LogContextCache;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 35320, 35352);
                    return return_v;
                }


                string
                f_1185_35320_35357(System.Management.Automation.LogContextCache
                this_param)
                {
                    var return_v = this_param.User;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 35320, 35357);
                    return return_v;
                }


                string
                f_1185_35425_35451()
                {
                    var return_v = Environment.UserDomainName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 35425, 35451);
                    return return_v;
                }


                string
                f_1185_35461_35481()
                {
                    var return_v = Environment.UserName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 35461, 35481);
                    return return_v;
                }


                System.Management.Automation.LogContextCache
                f_1185_35504_35536(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.LogContextCache;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 35504, 35536);
                    return return_v;
                }


                string
                f_1185_35544_35559(System.Management.Automation.LogContext
                this_param)
                {
                    var return_v = this_param.User;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 35544, 35559);
                    return return_v;
                }


                System.Management.Automation.LogContextCache
                f_1185_35660_35692(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.LogContextCache;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 35660, 35692);
                    return return_v;
                }


                string
                f_1185_35660_35697(System.Management.Automation.LogContextCache
                this_param)
                {
                    var return_v = this_param.User;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 35660, 35697);
                    return return_v;
                }


                string
                f_1185_35830_35853()
                {
                    var return_v = Logging.UnknownUserName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 35830, 35853);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1185_35972_36001(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 35972, 36001);
                    return return_v;
                }


                System.Management.Automation.PSVariableIntrinsics
                f_1185_35972_36012(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.PSVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 35972, 36012);
                    return return_v;
                }


                object
                f_1185_35972_36037(System.Management.Automation.PSVariableIntrinsics
                this_param, string
                name)
                {
                    var return_v = this_param.GetValue(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 35972, 36037);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSPrincipal
                f_1185_36191_36212(System.Management.Automation.Remoting.PSSenderInfo
                this_param)
                {
                    var return_v = this_param.UserInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 36191, 36212);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSIdentity
                f_1185_36191_36221(System.Management.Automation.Remoting.PSPrincipal
                this_param)
                {
                    var return_v = this_param.Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 36191, 36221);
                    return return_v;
                }


                string
                f_1185_36191_36226(System.Management.Automation.Remoting.PSIdentity
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 36191, 36226);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1185_36298_36324()
                {
                    var return_v = CultureInfo.CurrentCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 36298, 36324);
                    return return_v;
                }


                string
                f_1185_36445_36470(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.ScriptName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 36445, 36470);
                    return return_v;
                }


                string
                f_1185_36510_36529(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.Line;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 36510, 36529);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1185_36550_36574(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.MyCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 36550, 36574);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1185_36641_36665(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.MyCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 36641, 36665);
                    return return_v;
                }


                string
                f_1185_36641_36670(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 36641, 36670);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1185_36714_36738(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.MyCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 36714, 36738);
                    return return_v;
                }


                System.Management.Automation.CommandTypes
                f_1185_36714_36750(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.CommandType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 36714, 36750);
                    return return_v;
                }


                string
                f_1185_36714_36761(System.Management.Automation.CommandTypes
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 36714, 36761);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1185_36790_36814(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.MyCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 36790, 36814);
                    return return_v;
                }


                System.Management.Automation.CommandTypes
                f_1185_36790_36826(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.CommandType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 36790, 36826);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1185_36967_36991(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.MyCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 36967, 36991);
                    return return_v;
                }


                string
                f_1185_36949_36997(System.Management.Automation.ApplicationInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 36949, 36997);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1185_37157_37181(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.MyCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 37157, 37181);
                    return return_v;
                }


                string
                f_1185_37136_37187(System.Management.Automation.ExternalScriptInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 37136, 37187);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1185, 33634, 37299);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1185, 33634, 37299);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool NeedToLogEngineHealthEvent(LogProvider logProvider, ExecutionContext executionContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1185, 38302, 38679);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 38433, 38532) || true) && (!f_1185_38438_38471(logProvider))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 38433, 38532);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 38505, 38517);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 38433, 38532);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 38548, 38668);

                return f_1185_38555_38667(f_1185_38581_38666(executionContext, SpecialVariables.LogEngineHealthEventVarPath, true));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1185, 38302, 38679);

                bool
                f_1185_38438_38471(System.Management.Automation.LogProvider
                this_param)
                {
                    var return_v = this_param.UseLoggingVariables();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 38438, 38471);
                    return return_v;
                }


                object
                f_1185_38581_38666(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.VariablePath
                path, bool
                defaultValue)
                {
                    var return_v = this_param.GetVariableValue(path, (object)defaultValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 38581, 38666);
                    return return_v;
                }


                bool
                f_1185_38555_38667(object
                obj)
                {
                    var return_v = LanguagePrimitives.IsTrue(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 38555, 38667);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1185, 38302, 38679);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1185, 38302, 38679);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool NeedToLogEngineLifecycleEvent(LogProvider logProvider, ExecutionContext executionContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1185, 39147, 39530);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 39281, 39380) || true) && (!f_1185_39286_39319(logProvider))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 39281, 39380);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 39353, 39365);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 39281, 39380);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 39396, 39519);

                return f_1185_39403_39518(f_1185_39429_39517(executionContext, SpecialVariables.LogEngineLifecycleEventVarPath, true));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1185, 39147, 39530);

                bool
                f_1185_39286_39319(System.Management.Automation.LogProvider
                this_param)
                {
                    var return_v = this_param.UseLoggingVariables();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 39286, 39319);
                    return return_v;
                }


                object
                f_1185_39429_39517(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.VariablePath
                path, bool
                defaultValue)
                {
                    var return_v = this_param.GetVariableValue(path, (object)defaultValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 39429, 39517);
                    return return_v;
                }


                bool
                f_1185_39403_39518(object
                obj)
                {
                    var return_v = LanguagePrimitives.IsTrue(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 39403, 39518);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1185, 39147, 39530);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1185, 39147, 39530);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool NeedToLogCommandHealthEvent(LogProvider logProvider, ExecutionContext executionContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1185, 39990, 40370);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 40122, 40221) || true) && (!f_1185_40127_40160(logProvider))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 40122, 40221);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 40194, 40206);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 40122, 40221);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 40237, 40359);

                return f_1185_40244_40358(f_1185_40270_40357(executionContext, SpecialVariables.LogCommandHealthEventVarPath, false));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1185, 39990, 40370);

                bool
                f_1185_40127_40160(System.Management.Automation.LogProvider
                this_param)
                {
                    var return_v = this_param.UseLoggingVariables();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 40127, 40160);
                    return return_v;
                }


                object
                f_1185_40270_40357(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.VariablePath
                path, bool
                defaultValue)
                {
                    var return_v = this_param.GetVariableValue(path, (object)defaultValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 40270, 40357);
                    return return_v;
                }


                bool
                f_1185_40244_40358(object
                obj)
                {
                    var return_v = LanguagePrimitives.IsTrue(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 40244, 40358);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1185, 39990, 40370);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1185, 39990, 40370);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool NeedToLogCommandLifecycleEvent(LogProvider logProvider, ExecutionContext executionContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1185, 40832, 41218);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 40967, 41066) || true) && (!f_1185_40972_41005(logProvider))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 40967, 41066);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 41039, 41051);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 40967, 41066);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 41082, 41207);

                return f_1185_41089_41206(f_1185_41115_41205(executionContext, SpecialVariables.LogCommandLifecycleEventVarPath, false));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1185, 40832, 41218);

                bool
                f_1185_40972_41005(System.Management.Automation.LogProvider
                this_param)
                {
                    var return_v = this_param.UseLoggingVariables();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 40972, 41005);
                    return return_v;
                }


                object
                f_1185_41115_41205(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.VariablePath
                path, bool
                defaultValue)
                {
                    var return_v = this_param.GetVariableValue(path, (object)defaultValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 41115, 41205);
                    return return_v;
                }


                bool
                f_1185_41089_41206(object
                obj)
                {
                    var return_v = LanguagePrimitives.IsTrue(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 41089, 41206);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1185, 40832, 41218);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1185, 40832, 41218);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool NeedToLogPipelineExecutionDetailEvent(LogProvider logProvider, ExecutionContext executionContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1185, 41923, 42325);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 42065, 42164) || true) && (!f_1185_42070_42103(logProvider))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 42065, 42164);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 42137, 42149);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 42065, 42164);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 42180, 42192);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1185, 41923, 42325);

                bool
                f_1185_42070_42103(System.Management.Automation.LogProvider
                this_param)
                {
                    var return_v = this_param.UseLoggingVariables();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 42070, 42103);
                    return return_v;
                }

                // return LanguagePrimitives.IsTrue(executionContext.GetVariable("LogPipelineExecutionDetailEvent", false));
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1185, 41923, 42325);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1185, 41923, 42325);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool NeedToLogProviderHealthEvent(LogProvider logProvider, ExecutionContext executionContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1185, 42784, 43165);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 42917, 43016) || true) && (!f_1185_42922_42955(logProvider))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 42917, 43016);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 42989, 43001);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 42917, 43016);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 43032, 43154);

                return f_1185_43039_43153(f_1185_43065_43152(executionContext, SpecialVariables.LogProviderHealthEventVarPath, true));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1185, 42784, 43165);

                bool
                f_1185_42922_42955(System.Management.Automation.LogProvider
                this_param)
                {
                    var return_v = this_param.UseLoggingVariables();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 42922, 42955);
                    return return_v;
                }


                object
                f_1185_43065_43152(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.VariablePath
                path, bool
                defaultValue)
                {
                    var return_v = this_param.GetVariableValue(path, (object)defaultValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 43065, 43152);
                    return return_v;
                }


                bool
                f_1185_43039_43153(object
                obj)
                {
                    var return_v = LanguagePrimitives.IsTrue(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 43039, 43153);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1185, 42784, 43165);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1185, 42784, 43165);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool NeedToLogProviderLifecycleEvent(LogProvider logProvider, ExecutionContext executionContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1185, 43636, 44023);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 43772, 43871) || true) && (!f_1185_43777_43810(logProvider))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 43772, 43871);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 43844, 43856);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 43772, 43871);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 43887, 44012);

                return f_1185_43894_44011(f_1185_43920_44010(executionContext, SpecialVariables.LogProviderLifecycleEventVarPath, true));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1185, 43636, 44023);

                bool
                f_1185_43777_43810(System.Management.Automation.LogProvider
                this_param)
                {
                    var return_v = this_param.UseLoggingVariables();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 43777, 43810);
                    return return_v;
                }


                object
                f_1185_43920_44010(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.VariablePath
                path, bool
                defaultValue)
                {
                    var return_v = this_param.GetVariableValue(path, (object)defaultValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 43920, 44010);
                    return return_v;
                }


                bool
                f_1185_43894_44011(object
                obj)
                {
                    var return_v = LanguagePrimitives.IsTrue(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 43894, 44011);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1185, 43636, 44023);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1185, 43636, 44023);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool NeedToLogSettingsEvent(LogProvider logProvider, ExecutionContext executionContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1185, 44461, 44830);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 44588, 44687) || true) && (!f_1185_44593_44626(logProvider))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1185, 44588, 44687);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 44660, 44672);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1185, 44588, 44687);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 44703, 44819);

                return f_1185_44710_44818(f_1185_44736_44817(executionContext, SpecialVariables.LogSettingsEventVarPath, true));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1185, 44461, 44830);

                bool
                f_1185_44593_44626(System.Management.Automation.LogProvider
                this_param)
                {
                    var return_v = this_param.UseLoggingVariables();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 44593, 44626);
                    return return_v;
                }


                object
                f_1185_44736_44817(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.VariablePath
                path, bool
                defaultValue)
                {
                    var return_v = this_param.GetVariableValue(path, (object)defaultValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 44736, 44817);
                    return return_v;
                }


                bool
                f_1185_44710_44818(object
                obj)
                {
                    var return_v = LanguagePrimitives.IsTrue(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 44710, 44818);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1185, 44461, 44830);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1185, 44461, 44830);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int s_nextSequenceNumber;

        private static string NextSequenceNumber
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1185, 45174, 45326);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 45210, 45311);

                    return f_1185_45217_45310(f_1185_45234_45281(ref s_nextSequenceNumber), f_1185_45283_45309());
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1185, 45174, 45326);

                    int
                    f_1185_45234_45281(ref int
                    location)
                    {
                        var return_v = Interlocked.Increment(ref location);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 45234, 45281);
                        return return_v;
                    }


                    System.Globalization.CultureInfo
                    f_1185_45283_45309()
                    {
                        var return_v = CultureInfo.CurrentCulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1185, 45283, 45309);
                        return return_v;
                    }


                    string
                    f_1185_45217_45310(int
                    value, System.Globalization.CultureInfo
                    provider)
                    {
                        var return_v = Convert.ToString(value, (System.IFormatProvider)provider);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 45217, 45310);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1185, 45109, 45337);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1185, 45109, 45337);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal const int
        EVENT_ID_GENERAL_HEALTH_ISSUE = 100
        ;

        internal const int
        EVENT_ID_RESOURCE_NOT_AVAILABLE = 101
        ;

        internal const int
        EVENT_ID_NETWORK_CONNECTIVITY_ISSUE = 102
        ;

        internal const int
        EVENT_ID_CONFIGURATION_FAILURE = 103
        ;

        internal const int
        EVENT_ID_PERFORMANCE_ISSUE = 104
        ;

        internal const int
        EVENT_ID_SECURITY_ISSUE = 105
        ;

        internal const int
        EVENT_ID_SYSTEM_OVERLOADED = 106
        ;

        internal const int
        EVENT_ID_UNEXPECTED_EXCEPTION = 195
        ;

        static System.Collections.Concurrent.ConcurrentDictionary<string, System.Collections.ObjectModel.Collection<System.Management.Automation.LogProvider>>
        f_1185_3356_3415()
        {
            var return_v = new System.Collections.Concurrent.ConcurrentDictionary<string, System.Collections.ObjectModel.Collection<System.Management.Automation.LogProvider>>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 3356, 3415);
            return return_v;
        }


        static System.Collections.ObjectModel.Collection<string>
        f_1185_3684_3708()
        {
            var return_v = new System.Collections.ObjectModel.Collection<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 3684, 3708);
            return return_v;
        }


        static int
        f_1185_3841_3880(System.Collections.ObjectModel.Collection<string>
        this_param, string
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 3841, 3880);
            return 0;
        }


        static int
        f_1185_3895_3934(System.Collections.ObjectModel.Collection<string>
        this_param, string
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1185, 3895, 3934);
            return 0;
        }

    }
    internal class LogContextCache
    {
        internal string User { get; set; }

        public LogContextCache()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1185, 46468, 46564);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1185, 46515, 46557);
            this.User = null;
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1185, 46468, 46564);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1185, 46468, 46564);
        }


        static LogContextCache()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1185, 46468, 46564);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1185, 46468, 46564);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1185, 46468, 46564);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1185, 46468, 46564);
    }


    /// <summary>
    /// Severity of the event.
    /// </summary>
    internal enum Severity
    {
        /// <summary>
        /// Undefined severity.
        /// </summary>
        None,
        /// <summary>
        /// Critical event causing engine not to work.
        /// </summary>
        Critical,

        /// <summary>
        /// Error causing engine partially work.
        /// </summary>
        Error,

        /// <summary>
        /// Problem that may not cause an immediate problem.
        /// </summary>
        Warning,

        /// <summary>
        /// Informational.
        /// </summary>
        Informational
    };

    /// <summary>
    /// Enum for command states.
    /// </summary>
    internal enum CommandState
    {
        /// <summary>
        /// </summary>
        Started = 0,

        /// <summary>
        /// </summary>
        Stopped = 1,

        /// <summary>
        /// </summary>
        Terminated = 2
    };

    /// <summary>
    /// Enum for provider states.
    /// </summary>
    internal enum ProviderState
    {
        /// <summary>
        /// </summary>
        Started = 0,

        /// <summary>
        /// </summary>
        Stopped = 1,
    };

}
