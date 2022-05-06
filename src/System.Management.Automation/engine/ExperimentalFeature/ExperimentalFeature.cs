// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Automation.Configuration;
using System.Management.Automation.Internal;
using System.Management.Automation.Tracing;
using System.Runtime.CompilerServices;
using Microsoft.PowerShell.Telemetry;

namespace System.Management.Automation
{
    public class ExperimentalFeature
    {
        internal const string
        EngineSource = "PSEngine"
        ;

        public string Name { get; }

        public string Description { get; }

        public string Source { get; }

        public bool Enabled { get; private set; }

        internal ExperimentalFeature(string name, string description, string source, bool isEnabled)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1450, 1850, 2094);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 877, 904);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 1016, 1050);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 1157, 1186);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 1299, 1340);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 1967, 1979);

                Name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 1993, 2019);

                Description = description;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 2033, 2049);

                Source = source;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 2063, 2083);

                Enabled = isEnabled;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1450, 1850, 2094);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1450, 1850, 2094);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1450, 1850, 2094);
            }
        }

        private ExperimentalFeature(string name, string description)
        : this(f_1450_2596_2600_C(name), description, source: EngineSource, isEnabled: false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1450, 2515, 2676);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1450, 2515, 2676);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1450, 2515, 2676);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1450, 2515, 2676);
            }
        }

        internal static readonly ReadOnlyCollection<ExperimentalFeature> EngineExperimentalFeatures;

        internal static readonly ReadOnlyDictionary<string, ExperimentalFeature> EngineExperimentalFeatureMap;

        internal static readonly ReadOnlyBag<string> EnabledExperimentalFeatureNames;

        static ExperimentalFeature()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1450, 3551, 6364);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 688, 713);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 2913, 2939);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 3170, 3198);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 3380, 3411);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 3685, 4913);

                var
                engineFeatures = new ExperimentalFeature[] {
f_1450_4079_4259(name: "PSImplicitRemotingBatching", description: "Batch implicit remoting proxy commands to improve performance"),
f_1450_4278_4478(name: "PSCommandNotFoundSuggestion", description: "Recommend potential commands based on fuzzy search on a CommandNotFoundException"),
f_1450_4702_4896(name: "PSNullConditionalOperators", description: "Support the null conditional member access operators in PowerShell language"),
                            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 4927, 5016);

                EngineExperimentalFeatures = f_1450_4956_5015(engineFeatures);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 5115, 5216);

                var
                engineExpFeatureMap = f_1450_5141_5215(engineFeatures, f => f.Name, f_1450_5182_5214())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 5230, 5334);

                EngineExperimentalFeatureMap = f_1450_5261_5333(engineExpFeatureMap);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 6019, 6068);

                string[]
                enabledFeatures = f_1450_6046_6067()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 6118, 6188);

                    enabledFeatures = f_1450_6136_6187(PowerShellConfig.Instance);
                }
                catch (Exception e) when (f_1450_6243_6258(e))
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1450, 6217, 6263);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1450, 6217, 6263);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 6279, 6353);

                EnabledExperimentalFeatureNames = f_1450_6313_6352(enabledFeatures);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1450, 3551, 6364);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1450, 3551, 6364);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1450, 3551, 6364);
            }
        }

        private static ReadOnlyBag<string> ProcessEnabledFeatures(string[] enabledFeatures)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1450, 6664, 8356);
                System.Management.Automation.ExperimentalFeature feature = default(System.Management.Automation.ExperimentalFeature);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 6772, 6842) || true) && (f_1450_6776_6798(enabledFeatures) == 0)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1450, 6772, 6842);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 6807, 6840);

                    return ReadOnlyBag<string>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1450, 6772, 6842);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 6858, 6910);

                var
                list = f_1450_6869_6909(f_1450_6886_6908(enabledFeatures))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 6924, 8237);
                    foreach (string name in f_1450_6948_6963_I(enabledFeatures))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1450, 6924, 8237);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 6997, 8222) || true) && (f_1450_7001_7026(name))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1450, 6997, 8222);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 7068, 7083);

                            f_1450_7068_7082(list, name);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 7105, 7211);

                            f_1450_7105_7210(TelemetryType.ExperimentalModuleFeatureActivation, name);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1450, 6997, 8222);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1450, 6997, 8222);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 7253, 8222) || true) && (f_1450_7257_7282(name))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1450, 7253, 8222);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 7324, 7951) || true) && (f_1450_7328_7407(EngineExperimentalFeatureMap, name, out feature))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1450, 7324, 7951);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 7457, 7480);

                                    feature.Enabled = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 7506, 7521);

                                    f_1450_7506_7520(list, name);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 7547, 7653);

                                    f_1450_7547_7652(TelemetryType.ExperimentalEngineFeatureActivation, name);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1450, 7324, 7951);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1450, 7324, 7951);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 7751, 7835);

                                    string
                                    message = f_1450_7768_7834(f_1450_7786_7827(), name)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 7861, 7928);

                                    f_1450_7861_7927(PSEventId.ExperimentalFeature_InvalidName, name, message);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1450, 7324, 7951);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1450, 7253, 8222);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1450, 7253, 8222);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 8033, 8114);

                                string
                                message = f_1450_8050_8113(f_1450_8068_8106(), name)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 8136, 8203);

                                f_1450_8136_8202(PSEventId.ExperimentalFeature_InvalidName, name, message);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1450, 7253, 8222);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1450, 6997, 8222);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1450, 6924, 8237);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1450, 1, 1314);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1450, 1, 1314);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 8253, 8345);

                return f_1450_8260_8344(f_1450_8284_8343(list, f_1450_8310_8342()));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1450, 6664, 8356);

                int
                f_1450_6776_6798(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1450, 6776, 6798);
                    return return_v;
                }


                int
                f_1450_6886_6908(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1450, 6886, 6908);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1450_6869_6909(int
                capacity)
                {
                    var return_v = new System.Collections.Generic.List<string>(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1450, 6869, 6909);
                    return return_v;
                }


                bool
                f_1450_7001_7026(string
                featureName)
                {
                    var return_v = IsModuleFeatureName(featureName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1450, 7001, 7026);
                    return return_v;
                }


                int
                f_1450_7068_7082(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1450, 7068, 7082);
                    return 0;
                }


                int
                f_1450_7105_7210(Microsoft.PowerShell.Telemetry.TelemetryType
                metricId, string
                data)
                {
                    ApplicationInsightsTelemetry.SendTelemetryMetric(metricId, data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1450, 7105, 7210);
                    return 0;
                }


                bool
                f_1450_7257_7282(string
                featureName)
                {
                    var return_v = IsEngineFeatureName(featureName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1450, 7257, 7282);
                    return return_v;
                }


                bool
                f_1450_7328_7407(System.Collections.ObjectModel.ReadOnlyDictionary<string, System.Management.Automation.ExperimentalFeature>
                this_param, string
                key, out System.Management.Automation.ExperimentalFeature
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1450, 7328, 7407);
                    return return_v;
                }


                int
                f_1450_7506_7520(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1450, 7506, 7520);
                    return 0;
                }


                int
                f_1450_7547_7652(Microsoft.PowerShell.Telemetry.TelemetryType
                metricId, string
                data)
                {
                    ApplicationInsightsTelemetry.SendTelemetryMetric(metricId, data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1450, 7547, 7652);
                    return 0;
                }


                string
                f_1450_7786_7827()
                {
                    var return_v = Logging.EngineExperimentalFeatureNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1450, 7786, 7827);
                    return return_v;
                }


                string
                f_1450_7768_7834(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1450, 7768, 7834);
                    return return_v;
                }


                int
                f_1450_7861_7927(System.Management.Automation.Internal.PSEventId
                eventId, params object[]
                args)
                {
                    LogError(eventId, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1450, 7861, 7927);
                    return 0;
                }


                string
                f_1450_8068_8106()
                {
                    var return_v = Logging.InvalidExperimentalFeatureName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1450, 8068, 8106);
                    return return_v;
                }


                string
                f_1450_8050_8113(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1450, 8050, 8113);
                    return return_v;
                }


                int
                f_1450_8136_8202(System.Management.Automation.Internal.PSEventId
                eventId, params object[]
                args)
                {
                    LogError(eventId, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1450, 8136, 8202);
                    return 0;
                }


                string[]
                f_1450_6948_6963_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1450, 6948, 6963);
                    return return_v;
                }


                System.StringComparer
                f_1450_8310_8342()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1450, 8310, 8342);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_1450_8284_8343(System.Collections.Generic.List<string>
                collection, System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.HashSet<string>((System.Collections.Generic.IEnumerable<string>)collection, (System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1450, 8284, 8343);
                    return return_v;
                }


                System.Management.Automation.Internal.ReadOnlyBag<string>
                f_1450_8260_8344(System.Collections.Generic.HashSet<string>
                hashset)
                {
                    var return_v = new System.Management.Automation.Internal.ReadOnlyBag<string>(hashset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1450, 8260, 8344);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1450, 6664, 8356);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1450, 6664, 8356);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool LogException(Exception e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1450, 8475, 8687);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 8545, 8649);

                f_1450_8545_8648(PSEventId.ExperimentalFeature_ReadConfig_Error, f_1450_8602_8622(f_1450_8602_8613(e)), f_1450_8624_8633(e), f_1450_8635_8647(e));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 8663, 8676);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1450, 8475, 8687);

                System.Type
                f_1450_8602_8613(System.Exception
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1450, 8602, 8613);
                    return return_v;
                }


                string
                f_1450_8602_8622(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1450, 8602, 8622);
                    return return_v;
                }


                string
                f_1450_8624_8633(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1450, 8624, 8633);
                    return return_v;
                }


                string
                f_1450_8635_8647(System.Exception
                this_param)
                {
                    var return_v = this_param.StackTrace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1450, 8635, 8647);
                    return return_v;
                }


                int
                f_1450_8545_8648(System.Management.Automation.Internal.PSEventId
                eventId, params object[]
                args)
                {
                    LogError(eventId, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1450, 8545, 8648);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1450, 8475, 8687);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1450, 8475, 8687);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void LogError(PSEventId eventId, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1450, 8781, 9012);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 8875, 9001);

                f_1450_8875_9000(eventId, PSOpcode.Constructor, PSTask.ExperimentalFeature, PSKeyword.UseAlwaysOperational, args);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1450, 8781, 9012);

                int
                f_1450_8875_9000(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogOperationalError(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1450, 8875, 9000);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1450, 8781, 9012);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1450, 8781, 9012);
            }
        }

        internal static bool IsEngineFeatureName(string featureName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1450, 9236, 9454);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 9321, 9443);

                return f_1450_9328_9346(featureName) > 2 && (DynAbs.Tracing.TraceSender.Expression_True(1450, 9328, 9384) && f_1450_9354_9378(featureName, '.') == -1) && (DynAbs.Tracing.TraceSender.Expression_True(1450, 9328, 9442) && f_1450_9388_9442(featureName, "PS", StringComparison.Ordinal));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1450, 9236, 9454);

                int
                f_1450_9328_9346(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1450, 9328, 9346);
                    return return_v;
                }


                int
                f_1450_9354_9378(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1450, 9354, 9378);
                    return return_v;
                }


                bool
                f_1450_9388_9442(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1450, 9388, 9442);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1450, 9236, 9454);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1450, 9236, 9454);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsModuleFeatureName(string featureName, string moduleName = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1450, 9888, 10814);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 10053, 10146) || true) && (f_1450_10057_10084(featureName, '.'))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1450, 10053, 10146);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 10118, 10131);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1450, 10053, 10146);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 10231, 10279);

                int
                lastDotIndex = f_1450_10250_10278(featureName, '.')
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 10293, 10419) || true) && (lastDotIndex == -1 || (DynAbs.Tracing.TraceSender.Expression_False(1450, 10297, 10357) || lastDotIndex == f_1450_10335_10353(featureName) - 1))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1450, 10293, 10419);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 10391, 10404);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1450, 10293, 10419);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 10435, 10518) || true) && (moduleName == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1450, 10435, 10518);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 10491, 10503);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1450, 10435, 10518);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 10646, 10703);

                var
                moduleNamePart = f_1450_10667_10702(featureName, 0, lastDotIndex)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 10717, 10803);

                return moduleNamePart.Equals(f_1450_10746_10765(moduleName), StringComparison.OrdinalIgnoreCase);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1450, 9888, 10814);

                bool
                f_1450_10057_10084(string
                this_param, char
                value)
                {
                    var return_v = this_param.StartsWith(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1450, 10057, 10084);
                    return return_v;
                }


                int
                f_1450_10250_10278(string
                this_param, char
                value)
                {
                    var return_v = this_param.LastIndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1450, 10250, 10278);
                    return return_v;
                }


                int
                f_1450_10335_10353(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1450, 10335, 10353);
                    return return_v;
                }


                System.ReadOnlySpan<char>
                f_1450_10667_10702(string
                text, int
                start, int
                length)
                {
                    var return_v = text.AsSpan(start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1450, 10667, 10702);
                    return return_v;
                }


                System.ReadOnlySpan<char>
                f_1450_10746_10765(string
                text)
                {
                    var return_v = text.AsSpan();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1450, 10746, 10765);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1450, 9888, 10814);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1450, 9888, 10814);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ExperimentAction GetActionToTake(string experimentName, ExperimentAction experimentAction)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1450, 10961, 11742);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 11092, 11458) || true) && (experimentName == null || (DynAbs.Tracing.TraceSender.Expression_False(1450, 11096, 11163) || experimentAction == ExperimentAction.None))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1450, 11092, 11458);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 11414, 11443);

                    return ExperimentAction.Show;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1450, 11092, 11458);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 11474, 11517);

                ExperimentAction
                action = experimentAction
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 11531, 11701) || true) && (!f_1450_11536_11561(experimentName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1450, 11531, 11701);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 11595, 11686);

                    action = (DynAbs.Tracing.TraceSender.Conditional_F1(1450, 11604, 11637) || (((action == ExperimentAction.Hide) && DynAbs.Tracing.TraceSender.Conditional_F2(1450, 11640, 11661)) || DynAbs.Tracing.TraceSender.Conditional_F3(1450, 11664, 11685))) ? ExperimentAction.Show : ExperimentAction.Hide;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1450, 11531, 11701);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 11717, 11731);

                return action;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1450, 10961, 11742);

                bool
                f_1450_11536_11561(string
                featureName)
                {
                    var return_v = IsEnabled(featureName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1450, 11536, 11561);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1450, 10961, 11742);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1450, 10961, 11742);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEnabled(string featureName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1450, 11876, 12081);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 12009, 12070);

                return f_1450_12016_12069(EnabledExperimentalFeatureNames, featureName);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1450, 11876, 12081);

                bool
                f_1450_12016_12069(System.Management.Automation.Internal.ReadOnlyBag<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1450, 12016, 12069);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1450, 11876, 12081);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1450, 11876, 12081);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1450, 584, 12110);

        static string
        f_1450_2596_2600_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1450, 2515, 2676);
            return return_v;
        }


        static System.Management.Automation.ExperimentalFeature
        f_1450_4079_4259(string
        name, string
        description)
        {
            var return_v = new System.Management.Automation.ExperimentalFeature(name: name, description: description);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1450, 4079, 4259);
            return return_v;
        }


        static System.Management.Automation.ExperimentalFeature
        f_1450_4278_4478(string
        name, string
        description)
        {
            var return_v = new System.Management.Automation.ExperimentalFeature(name: name, description: description);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1450, 4278, 4478);
            return return_v;
        }


        static System.Management.Automation.ExperimentalFeature
        f_1450_4702_4896(string
        name, string
        description)
        {
            var return_v = new System.Management.Automation.ExperimentalFeature(name: name, description: description);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1450, 4702, 4896);
            return return_v;
        }


        static System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.ExperimentalFeature>
        f_1450_4956_5015(System.Management.Automation.ExperimentalFeature[]
        list)
        {
            var return_v = new System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.ExperimentalFeature>((System.Collections.Generic.IList<System.Management.Automation.ExperimentalFeature>)list);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1450, 4956, 5015);
            return return_v;
        }


        static System.StringComparer
        f_1450_5182_5214()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1450, 5182, 5214);
            return return_v;
        }


        static System.Collections.Generic.Dictionary<string, System.Management.Automation.ExperimentalFeature>
        f_1450_5141_5215(System.Management.Automation.ExperimentalFeature[]
        source, System.Func<System.Management.Automation.ExperimentalFeature, string>
        keySelector, System.StringComparer
        comparer)
        {
            var return_v = source.ToDictionary<System.Management.Automation.ExperimentalFeature, string>(keySelector, (System.Collections.Generic.IEqualityComparer<string>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1450, 5141, 5215);
            return return_v;
        }


        static System.Collections.ObjectModel.ReadOnlyDictionary<string, System.Management.Automation.ExperimentalFeature>
        f_1450_5261_5333(System.Collections.Generic.Dictionary<string, System.Management.Automation.ExperimentalFeature>
        dictionary)
        {
            var return_v = new System.Collections.ObjectModel.ReadOnlyDictionary<string, System.Management.Automation.ExperimentalFeature>((System.Collections.Generic.IDictionary<string, System.Management.Automation.ExperimentalFeature>)dictionary);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1450, 5261, 5333);
            return return_v;
        }


        static string[]
        f_1450_6046_6067()
        {
            var return_v = Array.Empty<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1450, 6046, 6067);
            return return_v;
        }


        static string[]
        f_1450_6136_6187(System.Management.Automation.Configuration.PowerShellConfig
        this_param)
        {
            var return_v = this_param.GetExperimentalFeatures();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1450, 6136, 6187);
            return return_v;
        }


        static bool
        f_1450_6243_6258(System.Exception
        e)
        {
            var return_v = LogException(e);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1450, 6243, 6258);
            return return_v;
        }


        static System.Management.Automation.Internal.ReadOnlyBag<string>
        f_1450_6313_6352(string[]
        enabledFeatures)
        {
            var return_v = ProcessEnabledFeatures(enabledFeatures);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1450, 6313, 6352);
            return return_v;
        }

    }

    /// <summary>
    /// Indicates the action to take on the cmdlet/parameter that has the attribute declared.
    /// </summary>
    public enum ExperimentAction
    {
        /// <summary>
        /// Represent an undefined action, used as the default value.
        /// </summary>
        None = 0,

        /// <summary>
        /// Hide the cmdlet/parameter when the corresponding experimental feature is enabled.
        /// </summary>
        Hide = 1,

        /// <summary>
        /// Show the cmdlet/parameter when the corresponding experimental feature is enabled.
        /// </summary>
        Show = 2
    }
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class ExperimentalAttribute : ParsingBaseAttribute
    {
        public string ExperimentName { get; }

        public ExperimentAction ExperimentAction { get; }

        public ExperimentalAttribute(string experimentName, ExperimentAction experimentAction)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1450, 13590, 13860);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 13225, 13262);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 13406, 13455);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 15863, 15903);
                this._effectiveAction = ExperimentAction.None;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 13701, 13753);

                f_1450_13701_13752(experimentName, experimentAction);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 13767, 13799);

                ExperimentName = experimentName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 13813, 13849);

                ExperimentAction = experimentAction;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1450, 13590, 13860);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1450, 13590, 13860);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1450, 13590, 13860);
            }
        }

        private ExperimentalAttribute()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1450, 13987, 14022);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 13225, 13262);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 13406, 13455);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 15863, 15903);
                this._effectiveAction = ExperimentAction.None;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1450, 13987, 14022);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1450, 13987, 14022);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1450, 13987, 14022);
            }
        }

        internal static readonly ExperimentalAttribute None;

        internal static void ValidateArguments(string experimentName, ExperimentAction experimentAction)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1450, 14332, 15194);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 14453, 14699) || true) && (f_1450_14457_14493(experimentName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1450, 14453, 14699);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 14527, 14569);

                    string
                    paramName = nameof(experimentName)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 14587, 14684);

                    throw f_1450_14593_14683(paramName, f_1450_14643_14671(), paramName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1450, 14453, 14699);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 14715, 15183) || true) && (experimentAction == ExperimentAction.None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1450, 14715, 15183);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 14794, 14838);

                    string
                    paramName = nameof(experimentAction)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 14856, 14912);

                    string
                    invalidMember = f_1450_14879_14911(ExperimentAction.None)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 14930, 15028);

                    string
                    validMembers = f_1450_14952_15027("{0}, {1}", ExperimentAction.Hide, ExperimentAction.Show)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 15046, 15168);

                    throw f_1450_15052_15167(paramName, f_1450_15098_15126(), invalidMember, paramName, validMembers);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1450, 14715, 15183);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1450, 14332, 15194);

                bool
                f_1450_14457_14493(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1450, 14457, 14493);
                    return return_v;
                }


                string
                f_1450_14643_14671()
                {
                    var return_v = Metadata.ArgumentNullOrEmpty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1450, 14643, 14671);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1450_14593_14683(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1450, 14593, 14683);
                    return return_v;
                }


                string
                f_1450_14879_14911(System.Management.Automation.ExperimentAction
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1450, 14879, 14911);
                    return return_v;
                }


                string
                f_1450_14952_15027(string
                formatSpec, System.Management.Automation.ExperimentAction
                o1, System.Management.Automation.ExperimentAction
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1450, 14952, 15027);
                    return return_v;
                }


                string
                f_1450_15098_15126()
                {
                    var return_v = Metadata.InvalidEnumArgument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1450, 15098, 15126);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1450_15052_15167(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1450, 15052, 15167);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1450, 14332, 15194);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1450, 14332, 15194);
            }
        }

        internal bool ToHide
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1450, 15227, 15270);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 15230, 15270);
                    return f_1450_15230_15245() == ExperimentAction.Hide;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1450, 15227, 15270);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1450, 15227, 15270);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1450, 15227, 15270);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool ToShow
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1450, 15302, 15345);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 15305, 15345);
                    return f_1450_15305_15320() == ExperimentAction.Show;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1450, 15302, 15345);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1450, 15302, 15345);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1450, 15302, 15345);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ExperimentAction EffectiveAction
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1450, 15525, 15815);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 15561, 15756) || true) && (_effectiveAction == ExperimentAction.None)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1450, 15561, 15756);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 15648, 15737);

                        _effectiveAction = f_1450_15667_15736(f_1450_15703_15717(), f_1450_15719_15735());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1450, 15561, 15756);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 15776, 15800);

                    return _effectiveAction;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1450, 15525, 15815);

                    string
                    f_1450_15703_15717()
                    {
                        var return_v = ExperimentName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1450, 15703, 15717);
                        return return_v;
                    }


                    System.Management.Automation.ExperimentAction
                    f_1450_15719_15735()
                    {
                        var return_v = ExperimentAction;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1450, 15719, 15735);
                        return return_v;
                    }


                    System.Management.Automation.ExperimentAction
                    f_1450_15667_15736(string
                    experimentName, System.Management.Automation.ExperimentAction
                    experimentAction)
                    {
                        var return_v = ExperimentalFeature.GetActionToTake(experimentName, experimentAction);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1450, 15667, 15736);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1450, 15460, 15826);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1450, 15460, 15826);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ExperimentAction _effectiveAction;

        static ExperimentalAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1450, 12913, 15911);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1450, 14185, 14219);
            None = f_1450_14192_14219();
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1450, 12913, 15911);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1450, 12913, 15911);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1450, 12913, 15911);

        int
        f_1450_13701_13752(string
        experimentName, System.Management.Automation.ExperimentAction
        experimentAction)
        {
            ValidateArguments(experimentName, experimentAction);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1450, 13701, 13752);
            return 0;
        }


        static System.Management.Automation.ExperimentalAttribute
        f_1450_14192_14219()
        {
            var return_v = new System.Management.Automation.ExperimentalAttribute();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1450, 14192, 14219);
            return return_v;
        }


        System.Management.Automation.ExperimentAction
        f_1450_15230_15245()
        {
            var return_v = EffectiveAction;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1450, 15230, 15245);
            return return_v;
        }


        System.Management.Automation.ExperimentAction
        f_1450_15305_15320()
        {
            var return_v = EffectiveAction;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1450, 15305, 15320);
            return return_v;
        }

    }
}
