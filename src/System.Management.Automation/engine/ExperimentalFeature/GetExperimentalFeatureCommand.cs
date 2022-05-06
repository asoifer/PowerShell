// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Internal;

namespace Microsoft.PowerShell.Commands
{
    [Cmdlet(VerbsCommon.Get, "ExperimentalFeature", HelpUri = "https://go.microsoft.com/fwlink/?linkid=2096786")]
    public class GetExperimentalFeatureCommand : PSCmdlet
    {
        [Parameter(ValueFromPipeline = true, Position = 0)]
        [ArgumentCompleter(typeof(ExperimentalFeatureNameCompleter))]
        [ValidateNotNullOrEmpty]
        public string[] Name { get; set; }

        protected override void ProcessRecord()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1451, 997, 1502);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1451, 1061, 1163);

                const WildcardOptions
                wildcardOptions = WildcardOptions.IgnoreCase | WildcardOptions.CultureInvariant
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1451, 1177, 1293);

                IEnumerable<WildcardPattern>
                namePatterns = f_1451_1221_1292(f_1451_1270_1274(), wildcardOptions)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1451, 1309, 1491);
                    foreach (ExperimentalFeature feature in f_1451_1349_1421_I(f_1451_1349_1421(f_1451_1349_1395(this, namePatterns), GetSortingString)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1451, 1309, 1491);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1451, 1455, 1476);

                        f_1451_1455_1475(this, feature);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1451, 1309, 1491);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1451, 1, 183);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1451, 1, 183);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1451, 997, 1502);

                string[]
                f_1451_1270_1274()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1451, 1270, 1274);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.WildcardPattern>
                f_1451_1221_1292(string[]
                globPatterns, System.Management.Automation.WildcardOptions
                options)
                {
                    var return_v = SessionStateUtilities.CreateWildcardsFromStrings((System.Collections.Generic.IEnumerable<string>)globPatterns, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1451, 1221, 1292);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.ExperimentalFeature>
                f_1451_1349_1395(Microsoft.PowerShell.Commands.GetExperimentalFeatureCommand
                this_param, System.Collections.Generic.IEnumerable<System.Management.Automation.WildcardPattern>
                namePatterns)
                {
                    var return_v = this_param.GetAvailableExperimentalFeatures(namePatterns);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1451, 1349, 1395);
                    return return_v;
                }


                System.Linq.IOrderedEnumerable<System.Management.Automation.ExperimentalFeature>
                f_1451_1349_1421(System.Collections.Generic.IEnumerable<System.Management.Automation.ExperimentalFeature>
                source, System.Func<System.Management.Automation.ExperimentalFeature, (int, string)>
                keySelector)
                {
                    var return_v = source.OrderBy<System.Management.Automation.ExperimentalFeature, (int, string)>(keySelector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1451, 1349, 1421);
                    return return_v;
                }


                int
                f_1451_1455_1475(Microsoft.PowerShell.Commands.GetExperimentalFeatureCommand
                this_param, System.Management.Automation.ExperimentalFeature
                sendToPipeline)
                {
                    this_param.WriteObject((object)sendToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1451, 1455, 1475);
                    return 0;
                }


                System.Linq.IOrderedEnumerable<System.Management.Automation.ExperimentalFeature>
                f_1451_1349_1421_I(System.Linq.IOrderedEnumerable<System.Management.Automation.ExperimentalFeature>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1451, 1349, 1421);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1451, 997, 1502);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1451, 997, 1502);
            }
        }

        private static (int, string) GetSortingString(ExperimentalFeature feature)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1451, 1829, 2128);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1451, 1928, 2117);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1451, 1935, 2026) || ((f_1451_1935_2026(ExperimentalFeature.EngineSource, f_1451_1975_1989(feature), StringComparison.OrdinalIgnoreCase) && DynAbs.Tracing.TraceSender.Conditional_F2(1451, 2054, 2071)) || DynAbs.Tracing.TraceSender.Conditional_F3(1451, 2099, 2116))) ? (0, f_1451_2058_2070(feature))
                : (1, f_1451_2103_2115(feature));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1451, 1829, 2128);

                string
                f_1451_1975_1989(System.Management.Automation.ExperimentalFeature
                this_param)
                {
                    var return_v = this_param.Source;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1451, 1975, 1989);
                    return return_v;
                }


                bool
                f_1451_1935_2026(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1451, 1935, 2026);
                    return return_v;
                }


                string
                f_1451_2058_2070(System.Management.Automation.ExperimentalFeature
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1451, 2058, 2070);
                    return return_v;
                }


                string
                f_1451_2103_2115(System.Management.Automation.ExperimentalFeature
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1451, 2103, 2115);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1451, 1829, 2128);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1451, 1829, 2128);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal IEnumerable<ExperimentalFeature> GetAvailableExperimentalFeatures(IEnumerable<WildcardPattern> namePatterns)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1451, 2274, 3271);

                var listYield = new List<ExperimentalFeature>();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1451, 2416, 2732);
                    foreach (ExperimentalFeature feature in f_1451_2456_2502_I(ExperimentalFeature.EngineExperimentalFeatures))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1451, 2416, 2732);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1451, 2536, 2717) || true) && (f_1451_2540_2635(f_1451_2588_2600(feature), namePatterns, defaultValue: true))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1451, 2536, 2717);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1451, 2677, 2698);

                            listYield.Add(feature);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1451, 2536, 2717);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1451, 2416, 2732);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1451, 1, 317);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1451, 1, 317);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1451, 2748, 3260);
                    foreach (string moduleFile in f_1451_2778_2822_I(f_1451_2778_2822(this, moduleNamesToFind: null)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1451, 2748, 3260);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1451, 2856, 2941);

                        ExperimentalFeature[]
                        features = f_1451_2889_2940(moduleFile)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1451, 2959, 3245);
                            foreach (var feature in f_1451_2983_2991_I(features))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1451, 2959, 3245);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1451, 3033, 3226) || true) && (f_1451_3037_3132(f_1451_3085_3097(feature), namePatterns, defaultValue: true))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1451, 3033, 3226);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1451, 3182, 3203);

                                    listYield.Add(feature);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1451, 3033, 3226);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1451, 2959, 3245);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1451, 1, 287);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1451, 1, 287);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1451, 2748, 3260);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1451, 1, 513);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1451, 1, 513);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1451, 2274, 3271);

                return listYield;

                string
                f_1451_2588_2600(System.Management.Automation.ExperimentalFeature
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1451, 2588, 2600);
                    return return_v;
                }


                bool
                f_1451_2540_2635(string
                text, System.Collections.Generic.IEnumerable<System.Management.Automation.WildcardPattern>
                patterns, bool
                defaultValue)
                {
                    var return_v = SessionStateUtilities.MatchesAnyWildcardPattern(text, patterns, defaultValue: defaultValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1451, 2540, 2635);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.ExperimentalFeature>
                f_1451_2456_2502_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.ExperimentalFeature>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1451, 2456, 2502);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1451_2778_2822(Microsoft.PowerShell.Commands.GetExperimentalFeatureCommand
                this_param, System.Collections.Generic.HashSet<string>
                moduleNamesToFind)
                {
                    var return_v = this_param.GetValidModuleFiles(moduleNamesToFind: moduleNamesToFind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1451, 2778, 2822);
                    return return_v;
                }


                System.Management.Automation.ExperimentalFeature[]
                f_1451_2889_2940(string
                manifestPath)
                {
                    var return_v = ModuleIntrinsics.GetExperimentalFeature(manifestPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1451, 2889, 2940);
                    return return_v;
                }


                string
                f_1451_3085_3097(System.Management.Automation.ExperimentalFeature
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1451, 3085, 3097);
                    return return_v;
                }


                bool
                f_1451_3037_3132(string
                text, System.Collections.Generic.IEnumerable<System.Management.Automation.WildcardPattern>
                patterns, bool
                defaultValue)
                {
                    var return_v = SessionStateUtilities.MatchesAnyWildcardPattern(text, patterns, defaultValue: defaultValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1451, 3037, 3132);
                    return return_v;
                }


                System.Management.Automation.ExperimentalFeature[]
                f_1451_2983_2991_I(System.Management.Automation.ExperimentalFeature[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1451, 2983, 2991);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1451_2778_2822_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1451, 2778, 2822);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1451, 2274, 3271);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1451, 2274, 3271);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private IEnumerable<string> GetValidModuleFiles(HashSet<string> moduleNamesToFind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1451, 3385, 4600);

                var listYield = new List<String>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1451, 3492, 3564);

                var
                modulePaths = f_1451_3510_3563(f_1451_3530_3562())
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1451, 3578, 4589);
                    foreach (string path in f_1451_3602_3673_I(f_1451_3602_3673(includeSystemModulePath: false, f_1451_3665_3672())))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1451, 3578, 4589);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1451, 3707, 3768);

                        string
                        uniquePath = f_1451_3727_3767(path, Utils.Separators.Directory)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1451, 3786, 3833) || true) && (!f_1451_3791_3818(modulePaths, uniquePath))
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1451, 3786, 3833);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1451, 3822, 3831);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1451, 3786, 3833);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1451, 3853, 4574);
                            foreach (string moduleFile in f_1451_3883_3937_I(f_1451_3883_3937(uniquePath)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1451, 3853, 4574);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1451, 4101, 4220) || true) && (!f_1451_4106_4205(moduleFile, StringLiterals.PowerShellDataFileExtension, StringComparison.OrdinalIgnoreCase))
                                )
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1451, 4101, 4220);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1451, 4209, 4218);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1451, 4101, 4220);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1451, 4244, 4507) || true) && (moduleNamesToFind != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1451, 4244, 4507);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1451, 4323, 4393);

                                    string
                                    currentModuleName = f_1451_4350_4392(moduleFile)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1451, 4419, 4484) || true) && (!f_1451_4424_4469(moduleNamesToFind, currentModuleName))
                                    )
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1451, 4419, 4484);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1451, 4473, 4482);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1451, 4419, 4484);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1451, 4244, 4507);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1451, 4531, 4555);

                                listYield.Add(moduleFile);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1451, 3853, 4574);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1451, 1, 722);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1451, 1, 722);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1451, 3578, 4589);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1451, 1, 1012);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1451, 1, 1012);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1451, 3385, 4600);

                return listYield;

                System.StringComparer
                f_1451_3530_3562()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1451, 3530, 3562);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_1451_3510_3563(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.HashSet<string>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1451, 3510, 3563);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1451_3665_3672()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1451, 3665, 3672);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1451_3602_3673(bool
                includeSystemModulePath, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = ModuleIntrinsics.GetModulePath(includeSystemModulePath: includeSystemModulePath, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1451, 3602, 3673);
                    return return_v;
                }


                string
                f_1451_3727_3767(string
                this_param, params char[]
                trimChars)
                {
                    var return_v = this_param.TrimEnd(trimChars);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1451, 3727, 3767);
                    return return_v;
                }


                bool
                f_1451_3791_3818(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1451, 3791, 3818);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1451_3883_3937(string
                topDirectoryToCheck)
                {
                    var return_v = ModuleUtils.GetDefaultAvailableModuleFiles(topDirectoryToCheck);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1451, 3883, 3937);
                    return return_v;
                }


                bool
                f_1451_4106_4205(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.EndsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1451, 4106, 4205);
                    return return_v;
                }


                string
                f_1451_4350_4392(string
                path)
                {
                    var return_v = ModuleIntrinsics.GetModuleName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1451, 4350, 4392);
                    return return_v;
                }


                bool
                f_1451_4424_4469(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1451, 4424, 4469);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1451_3883_3937_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1451, 3883, 3937);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1451_3602_3673_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1451, 3602, 3673);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1451, 3385, 4600);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1451, 3385, 4600);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public GetExperimentalFeatureCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1451, 412, 4607);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1451, 688, 888);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1451, 412, 4607);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1451, 412, 4607);
        }


        static GetExperimentalFeatureCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1451, 412, 4607);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1451, 412, 4607);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1451, 412, 4607);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1451, 412, 4607);
    }
}
