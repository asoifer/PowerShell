// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Management.Automation.Internal;
using System.Text;

namespace System.Management.Automation
{
    internal abstract class LogProvider
    {
        internal LogProvider()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1184, 1371, 1415);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1184, 1371, 1415);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1184, 1371, 1415);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1184, 1371, 1415);
            }
        }

        internal abstract void LogEngineHealthEvent(LogContext logContext, int eventId, Exception exception, Dictionary<string, string> additionalInfo);

        internal abstract void LogEngineLifecycleEvent(LogContext logContext, EngineState newState, EngineState previousState);

        internal abstract void LogCommandHealthEvent(LogContext logContext, Exception exception);

        internal abstract void LogCommandLifecycleEvent(Func<LogContext> getLogContext, CommandState newState);

        internal abstract void LogPipelineExecutionDetailEvent(LogContext logContext, List<string> pipelineExecutionDetail);

        internal abstract void LogProviderHealthEvent(LogContext logContext, string providerName, Exception exception);

        internal abstract void LogProviderLifecycleEvent(LogContext logContext, string providerName, ProviderState newState);

        internal abstract void LogSettingsEvent(LogContext logContext, string variableName, string value, string previousValue);

        internal virtual bool UseLoggingVariables()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1184, 4697, 4788);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 4765, 4777);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1184, 4697, 4788);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1184, 4697, 4788);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1184, 4697, 4788);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private static class Strings
        {
            internal static readonly string LogContextSeverity;

            internal static readonly string LogContextHostName;

            internal static readonly string LogContextHostVersion;

            internal static readonly string LogContextHostId;

            internal static readonly string LogContextHostApplication;

            internal static readonly string LogContextEngineVersion;

            internal static readonly string LogContextRunspaceId;

            internal static readonly string LogContextPipelineId;

            internal static readonly string LogContextCommandName;

            internal static readonly string LogContextCommandType;

            internal static readonly string LogContextScriptName;

            internal static readonly string LogContextCommandPath;

            internal static readonly string LogContextSequenceNumber;

            internal static readonly string LogContextUser;

            internal static readonly string LogContextConnectedUser;

            internal static readonly string LogContextTime;

            internal static readonly string LogContextShellId;

            static Strings()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1184, 4858, 6930);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 5137, 5194);
                LogContextSeverity = f_1184_5158_5194();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 5241, 5298);
                LogContextHostName = f_1184_5262_5298();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 5345, 5408);
                LogContextHostVersion = f_1184_5369_5408();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 5455, 5508);
                LogContextHostId = f_1184_5474_5508();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 5555, 5626);
                LogContextHostApplication = f_1184_5583_5626();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 5673, 5740);
                LogContextEngineVersion = f_1184_5699_5740();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 5787, 5848);
                LogContextRunspaceId = f_1184_5810_5848();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 5895, 5956);
                LogContextPipelineId = f_1184_5918_5956();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 6003, 6066);
                LogContextCommandName = f_1184_6027_6066();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 6113, 6176);
                LogContextCommandType = f_1184_6137_6176();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 6223, 6284);
                LogContextScriptName = f_1184_6246_6284();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 6331, 6394);
                LogContextCommandPath = f_1184_6355_6394();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 6441, 6510);
                LogContextSequenceNumber = f_1184_6468_6510();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 6557, 6606);
                LogContextUser = f_1184_6574_6606();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 6653, 6720);
                LogContextConnectedUser = f_1184_6679_6720();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 6767, 6816);
                LogContextTime = f_1184_6784_6816();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 6863, 6918);
                LogContextShellId = f_1184_6883_6918();
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1184, 4858, 6930);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1184, 4858, 6930);
            }


            static string
            f_1184_5158_5194()
            {
                var return_v = EtwLoggingStrings.LogContextSeverity;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1184, 5158, 5194);
                return return_v;
            }


            static string
            f_1184_5262_5298()
            {
                var return_v = EtwLoggingStrings.LogContextHostName;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1184, 5262, 5298);
                return return_v;
            }


            static string
            f_1184_5369_5408()
            {
                var return_v = EtwLoggingStrings.LogContextHostVersion;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1184, 5369, 5408);
                return return_v;
            }


            static string
            f_1184_5474_5508()
            {
                var return_v = EtwLoggingStrings.LogContextHostId;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1184, 5474, 5508);
                return return_v;
            }


            static string
            f_1184_5583_5626()
            {
                var return_v = EtwLoggingStrings.LogContextHostApplication;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1184, 5583, 5626);
                return return_v;
            }


            static string
            f_1184_5699_5740()
            {
                var return_v = EtwLoggingStrings.LogContextEngineVersion;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1184, 5699, 5740);
                return return_v;
            }


            static string
            f_1184_5810_5848()
            {
                var return_v = EtwLoggingStrings.LogContextRunspaceId;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1184, 5810, 5848);
                return return_v;
            }


            static string
            f_1184_5918_5956()
            {
                var return_v = EtwLoggingStrings.LogContextPipelineId;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1184, 5918, 5956);
                return return_v;
            }


            static string
            f_1184_6027_6066()
            {
                var return_v = EtwLoggingStrings.LogContextCommandName;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1184, 6027, 6066);
                return return_v;
            }


            static string
            f_1184_6137_6176()
            {
                var return_v = EtwLoggingStrings.LogContextCommandType;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1184, 6137, 6176);
                return return_v;
            }


            static string
            f_1184_6246_6284()
            {
                var return_v = EtwLoggingStrings.LogContextScriptName;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1184, 6246, 6284);
                return return_v;
            }


            static string
            f_1184_6355_6394()
            {
                var return_v = EtwLoggingStrings.LogContextCommandPath;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1184, 6355, 6394);
                return return_v;
            }


            static string
            f_1184_6468_6510()
            {
                var return_v = EtwLoggingStrings.LogContextSequenceNumber;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1184, 6468, 6510);
                return return_v;
            }


            static string
            f_1184_6574_6606()
            {
                var return_v = EtwLoggingStrings.LogContextUser;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1184, 6574, 6606);
                return return_v;
            }


            static string
            f_1184_6679_6720()
            {
                var return_v = EtwLoggingStrings.LogContextConnectedUser;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1184, 6679, 6720);
                return return_v;
            }


            static string
            f_1184_6784_6816()
            {
                var return_v = EtwLoggingStrings.LogContextTime;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1184, 6784, 6816);
                return return_v;
            }


            static string
            f_1184_6883_6918()
            {
                var return_v = EtwLoggingStrings.LogContextShellId;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1184, 6883, 6918);
                return return_v;
            }

        }

        protected static string GetPSLogUserData(ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1184, 7122, 7552);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 7213, 7301) || true) && (context == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1184, 7213, 7301);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 7266, 7286);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1184, 7213, 7301);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 7317, 7395);

                object
                logData = f_1184_7334_7394(context, SpecialVariables.PSLogUserDataPath)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 7411, 7499) || true) && (logData == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1184, 7411, 7499);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 7464, 7484);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1184, 7411, 7499);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 7515, 7541);

                return f_1184_7522_7540(logData);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1184, 7122, 7552);

                object
                f_1184_7334_7394(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.VariablePath
                path)
                {
                    var return_v = this_param.GetVariableValue(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1184, 7334, 7394);
                    return return_v;
                }


                string?
                f_1184_7522_7540(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1184, 7522, 7540);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1184, 7122, 7552);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1184, 7122, 7552);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected static void AppendException(StringBuilder sb, Exception except)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1184, 7762, 8619);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 7860, 7947);

                f_1184_7860_7946(sb, f_1184_7874_7945(f_1184_7892_7928(), f_1184_7930_7944(except)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 7963, 8021);

                IContainsErrorRecord
                ier = except as IContainsErrorRecord
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 8037, 8608) || true) && (ier != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1184, 8037, 8608);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 8086, 8119);

                    ErrorRecord
                    er = f_1184_8103_8118(ier)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 8139, 8593) || true) && (er != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1184, 8139, 8593);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 8195, 8287);

                        f_1184_8195_8286(sb, f_1184_8209_8285(f_1184_8227_8258(), f_1184_8260_8284(er)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 8311, 8350);

                        ErrorDetails
                        details = f_1184_8334_8349(er)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 8374, 8574) || true) && (details != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1184, 8374, 8574);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 8443, 8551);

                            f_1184_8443_8550(sb, f_1184_8457_8549(f_1184_8475_8521(), f_1184_8523_8548(details)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1184, 8374, 8574);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1184, 8139, 8593);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1184, 8037, 8608);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1184, 7762, 8619);

                string
                f_1184_7892_7928()
                {
                    var return_v = EtwLoggingStrings.ErrorRecordMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1184, 7892, 7928);
                    return return_v;
                }


                string
                f_1184_7930_7944(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1184, 7930, 7944);
                    return return_v;
                }


                string
                f_1184_7874_7945(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1184, 7874, 7945);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1184_7860_7946(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1184, 7860, 7946);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1184_8103_8118(System.Management.Automation.IContainsErrorRecord
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1184, 8103, 8118);
                    return return_v;
                }


                string
                f_1184_8227_8258()
                {
                    var return_v = EtwLoggingStrings.ErrorRecordId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1184, 8227, 8258);
                    return return_v;
                }


                string
                f_1184_8260_8284(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.FullyQualifiedErrorId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1184, 8260, 8284);
                    return return_v;
                }


                string
                f_1184_8209_8285(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1184, 8209, 8285);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1184_8195_8286(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1184, 8195, 8286);
                    return return_v;
                }


                System.Management.Automation.ErrorDetails
                f_1184_8334_8349(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.ErrorDetails;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1184, 8334, 8349);
                    return return_v;
                }


                string
                f_1184_8475_8521()
                {
                    var return_v = EtwLoggingStrings.ErrorRecordRecommendedAction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1184, 8475, 8521);
                    return return_v;
                }


                string
                f_1184_8523_8548(System.Management.Automation.ErrorDetails
                this_param)
                {
                    var return_v = this_param.RecommendedAction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1184, 8523, 8548);
                    return return_v;
                }


                string
                f_1184_8457_8549(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1184, 8457, 8549);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1184_8443_8550(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1184, 8443, 8550);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1184, 7762, 8619);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1184, 7762, 8619);
            }
        }

        protected static void AppendAdditionalInfo(StringBuilder sb, Dictionary<string, string> additionalInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1184, 8851, 9257);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 8979, 9246) || true) && (additionalInfo != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1184, 8979, 9246);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 9039, 9231);
                        foreach (KeyValuePair<string, string> value in f_1184_9086_9100_I(additionalInfo))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1184, 9039, 9231);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 9142, 9212);

                            f_1184_9142_9211(sb, f_1184_9156_9210("{0} = {1}", value.Key, value.Value));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1184, 9039, 9231);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1184, 1, 193);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1184, 1, 193);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1184, 8979, 9246);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1184, 8851, 9257);

                string
                f_1184_9156_9210(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1184, 9156, 9210);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1184_9142_9211(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1184, 9142, 9211);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, string>
                f_1184_9086_9100_I(System.Collections.Generic.Dictionary<string, string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1184, 9086, 9100);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1184, 8851, 9257);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1184, 8851, 9257);
            }
        }

        protected static PSLevel GetPSLevelFromSeverity(string severity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1184, 9463, 9873);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 9552, 9862);

                switch (severity)
                {

                    case "Critical":
                    case "Error":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1184, 9552, 9862);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 9671, 9692);

                        return PSLevel.Error;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1184, 9552, 9862);

                    case "Warning":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1184, 9552, 9862);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 9747, 9770);

                        return PSLevel.Warning;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1184, 9552, 9862);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1184, 9552, 9862);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 9818, 9847);

                        return PSLevel.Informational;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1184, 9552, 9862);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1184, 9463, 9873);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1184, 9463, 9873);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1184, 9463, 9873);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        const int
        LogContextInitialSize = 30 * 16 + 13 * 20 + 255
        ;

        protected static string LogContextToString(LogContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1184, 10378, 12211);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 10465, 10525);

                StringBuilder
                sb = f_1184_10484_10524(LogContextInitialSize)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 10541, 10579);

                f_1184_10541_10578(
                            sb, Strings.LogContextSeverity);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 10593, 10625);

                f_1184_10593_10624(sb, f_1184_10607_10623(context));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 10639, 10677);

                f_1184_10639_10676(sb, Strings.LogContextHostName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 10691, 10723);

                f_1184_10691_10722(sb, f_1184_10705_10721(context));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 10737, 10778);

                f_1184_10737_10777(sb, Strings.LogContextHostVersion);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 10792, 10827);

                f_1184_10792_10826(sb, f_1184_10806_10825(context));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 10841, 10877);

                f_1184_10841_10876(sb, Strings.LogContextHostId);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 10891, 10921);

                f_1184_10891_10920(sb, f_1184_10905_10919(context));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 10935, 10980);

                f_1184_10935_10979(sb, Strings.LogContextHostApplication);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 10994, 11033);

                f_1184_10994_11032(sb, f_1184_11008_11031(context));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 11047, 11090);

                f_1184_11047_11089(sb, Strings.LogContextEngineVersion);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 11104, 11141);

                f_1184_11104_11140(sb, f_1184_11118_11139(context));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 11155, 11195);

                f_1184_11155_11194(sb, Strings.LogContextRunspaceId);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 11209, 11243);

                f_1184_11209_11242(sb, f_1184_11223_11241(context));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 11257, 11297);

                f_1184_11257_11296(sb, Strings.LogContextPipelineId);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 11311, 11345);

                f_1184_11311_11344(sb, f_1184_11325_11343(context));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 11359, 11400);

                f_1184_11359_11399(sb, Strings.LogContextCommandName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 11414, 11449);

                f_1184_11414_11448(sb, f_1184_11428_11447(context));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 11463, 11504);

                f_1184_11463_11503(sb, Strings.LogContextCommandType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 11518, 11553);

                f_1184_11518_11552(sb, f_1184_11532_11551(context));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 11567, 11607);

                f_1184_11567_11606(sb, Strings.LogContextScriptName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 11621, 11655);

                f_1184_11621_11654(sb, f_1184_11635_11653(context));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 11669, 11710);

                f_1184_11669_11709(sb, Strings.LogContextCommandPath);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 11724, 11759);

                f_1184_11724_11758(sb, f_1184_11738_11757(context));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 11773, 11817);

                f_1184_11773_11816(sb, Strings.LogContextSequenceNumber);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 11831, 11869);

                f_1184_11831_11868(sb, f_1184_11845_11867(context));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 11883, 11917);

                f_1184_11883_11916(sb, Strings.LogContextUser);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 11931, 11959);

                f_1184_11931_11958(sb, f_1184_11945_11957(context));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 11973, 12016);

                f_1184_11973_12015(sb, Strings.LogContextConnectedUser);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 12030, 12067);

                f_1184_12030_12066(sb, f_1184_12044_12065(context));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 12081, 12118);

                f_1184_12081_12117(sb, Strings.LogContextShellId);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 12132, 12163);

                f_1184_12132_12162(sb, f_1184_12146_12161(context));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 12179, 12200);

                return f_1184_12186_12199(sb);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1184, 10378, 12211);

                System.Text.StringBuilder
                f_1184_10484_10524(int
                capacity)
                {
                    var return_v = new System.Text.StringBuilder(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1184, 10484, 10524);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1184_10541_10578(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1184, 10541, 10578);
                    return return_v;
                }


                string
                f_1184_10607_10623(System.Management.Automation.LogContext
                this_param)
                {
                    var return_v = this_param.Severity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1184, 10607, 10623);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1184_10593_10624(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1184, 10593, 10624);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1184_10639_10676(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1184, 10639, 10676);
                    return return_v;
                }


                string
                f_1184_10705_10721(System.Management.Automation.LogContext
                this_param)
                {
                    var return_v = this_param.HostName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1184, 10705, 10721);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1184_10691_10722(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1184, 10691, 10722);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1184_10737_10777(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1184, 10737, 10777);
                    return return_v;
                }


                string
                f_1184_10806_10825(System.Management.Automation.LogContext
                this_param)
                {
                    var return_v = this_param.HostVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1184, 10806, 10825);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1184_10792_10826(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1184, 10792, 10826);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1184_10841_10876(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1184, 10841, 10876);
                    return return_v;
                }


                string
                f_1184_10905_10919(System.Management.Automation.LogContext
                this_param)
                {
                    var return_v = this_param.HostId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1184, 10905, 10919);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1184_10891_10920(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1184, 10891, 10920);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1184_10935_10979(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1184, 10935, 10979);
                    return return_v;
                }


                string
                f_1184_11008_11031(System.Management.Automation.LogContext
                this_param)
                {
                    var return_v = this_param.HostApplication;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1184, 11008, 11031);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1184_10994_11032(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1184, 10994, 11032);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1184_11047_11089(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1184, 11047, 11089);
                    return return_v;
                }


                string
                f_1184_11118_11139(System.Management.Automation.LogContext
                this_param)
                {
                    var return_v = this_param.EngineVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1184, 11118, 11139);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1184_11104_11140(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1184, 11104, 11140);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1184_11155_11194(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1184, 11155, 11194);
                    return return_v;
                }


                string
                f_1184_11223_11241(System.Management.Automation.LogContext
                this_param)
                {
                    var return_v = this_param.RunspaceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1184, 11223, 11241);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1184_11209_11242(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1184, 11209, 11242);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1184_11257_11296(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1184, 11257, 11296);
                    return return_v;
                }


                string
                f_1184_11325_11343(System.Management.Automation.LogContext
                this_param)
                {
                    var return_v = this_param.PipelineId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1184, 11325, 11343);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1184_11311_11344(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1184, 11311, 11344);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1184_11359_11399(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1184, 11359, 11399);
                    return return_v;
                }


                string
                f_1184_11428_11447(System.Management.Automation.LogContext
                this_param)
                {
                    var return_v = this_param.CommandName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1184, 11428, 11447);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1184_11414_11448(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1184, 11414, 11448);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1184_11463_11503(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1184, 11463, 11503);
                    return return_v;
                }


                string
                f_1184_11532_11551(System.Management.Automation.LogContext
                this_param)
                {
                    var return_v = this_param.CommandType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1184, 11532, 11551);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1184_11518_11552(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1184, 11518, 11552);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1184_11567_11606(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1184, 11567, 11606);
                    return return_v;
                }


                string
                f_1184_11635_11653(System.Management.Automation.LogContext
                this_param)
                {
                    var return_v = this_param.ScriptName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1184, 11635, 11653);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1184_11621_11654(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1184, 11621, 11654);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1184_11669_11709(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1184, 11669, 11709);
                    return return_v;
                }


                string
                f_1184_11738_11757(System.Management.Automation.LogContext
                this_param)
                {
                    var return_v = this_param.CommandPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1184, 11738, 11757);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1184_11724_11758(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1184, 11724, 11758);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1184_11773_11816(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1184, 11773, 11816);
                    return return_v;
                }


                string
                f_1184_11845_11867(System.Management.Automation.LogContext
                this_param)
                {
                    var return_v = this_param.SequenceNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1184, 11845, 11867);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1184_11831_11868(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1184, 11831, 11868);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1184_11883_11916(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1184, 11883, 11916);
                    return return_v;
                }


                string
                f_1184_11945_11957(System.Management.Automation.LogContext
                this_param)
                {
                    var return_v = this_param.User;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1184, 11945, 11957);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1184_11931_11958(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1184, 11931, 11958);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1184_11973_12015(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1184, 11973, 12015);
                    return return_v;
                }


                string
                f_1184_12044_12065(System.Management.Automation.LogContext
                this_param)
                {
                    var return_v = this_param.ConnectedUser;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1184, 12044, 12065);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1184_12030_12066(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1184, 12030, 12066);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1184_12081_12117(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1184, 12081, 12117);
                    return return_v;
                }


                string
                f_1184_12146_12161(System.Management.Automation.LogContext
                this_param)
                {
                    var return_v = this_param.ShellId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1184, 12146, 12161);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1184_12132_12162(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1184, 12132, 12162);
                    return return_v;
                }


                string
                f_1184_12186_12199(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1184, 12186, 12199);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1184, 10378, 12211);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1184, 10378, 12211);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static LogProvider()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1184, 1246, 12240);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1184, 10115, 10162);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1184, 1246, 12240);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1184, 1246, 12240);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1184, 1246, 12240);
    }
    internal class DummyLogProvider : LogProvider
    {
        internal DummyLogProvider()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1184, 12422, 12471);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1184, 12422, 12471);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1184, 12422, 12471);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1184, 12422, 12471);
            }
        }

        internal override void LogEngineHealthEvent(LogContext logContext, int eventId, Exception exception, Dictionary<string, string> additionalInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1184, 12823, 12988);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1184, 12823, 12988);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1184, 12823, 12988);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1184, 12823, 12988);
            }
        }

        internal override void LogEngineLifecycleEvent(LogContext logContext, EngineState newState, EngineState previousState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1184, 13265, 13405);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1184, 13265, 13405);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1184, 13265, 13405);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1184, 13265, 13405);
            }
        }

        internal override void LogCommandHealthEvent(LogContext logContext, Exception exception)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1184, 13632, 13742);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1184, 13632, 13742);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1184, 13632, 13742);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1184, 13632, 13742);
            }
        }

        internal override void LogCommandLifecycleEvent(Func<LogContext> getLogContext, CommandState newState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1184, 13973, 14097);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1184, 13973, 14097);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1184, 13973, 14097);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1184, 13973, 14097);
            }
        }

        internal override void LogPipelineExecutionDetailEvent(LogContext logContext, List<string> pipelineExecutionDetail)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1184, 14347, 14484);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1184, 14347, 14484);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1184, 14347, 14484);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1184, 14347, 14484);
            }
        }

        internal override void LogProviderHealthEvent(LogContext logContext, string providerName, Exception exception)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1184, 14761, 14893);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1184, 14761, 14893);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1184, 14761, 14893);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1184, 14761, 14893);
            }
        }

        internal override void LogProviderLifecycleEvent(LogContext logContext, string providerName, ProviderState newState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1184, 15171, 15309);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1184, 15171, 15309);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1184, 15171, 15309);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1184, 15171, 15309);
            }
        }

        internal override void LogSettingsEvent(LogContext logContext, string variableName, string value, string previousValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1184, 15625, 15766);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1184, 15625, 15766);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1184, 15625, 15766);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1184, 15625, 15766);
            }
        }

        static DummyLogProvider()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1184, 12287, 15795);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1184, 12287, 15795);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1184, 12287, 15795);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1184, 12287, 15795);
    }
}
