// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Management.Automation.Internal;
using System.Management.Automation.Language;
using System.Management.Automation.Runspaces;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.PowerShell.Commands;

namespace System.Management.Automation
{
    internal class AnalysisCache
    {
        private static AnalysisCacheData s_cacheData;

        private static ConcurrentDictionary<string, string> s_modulesBeingAnalyzed;

        internal static char[] InvalidCommandNameCharacters;

        internal static ConcurrentDictionary<string, CommandTypes> GetExportedCommands(string modulePath, bool testOnly, ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1527, 1818, 4484);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 1981, 2043);

                bool
                etwEnabled = f_1527_1999_2042(CommandDiscoveryEventSource.Log)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 2057, 2148) || true) && (etwEnabled)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 2057, 2148);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 2073, 2148);

                    f_1527_2073_2147(CommandDiscoveryEventSource.Log, modulePath);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 2057, 2148);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 2164, 2187);

                DateTime
                lastWriteTime
                = default(DateTime);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 2201, 2235);

                ModuleCacheEntry
                moduleCacheEntry
                = default(ModuleCacheEntry);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 2249, 2519) || true) && (f_1527_2253_2329(modulePath, out lastWriteTime, out moduleCacheEntry))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 2249, 2519);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 2363, 2453) || true) && (etwEnabled)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 2363, 2453);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 2379, 2453);

                        f_1527_2379_2452(CommandDiscoveryEventSource.Log, modulePath);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 2363, 2453);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 2471, 2504);

                    return moduleCacheEntry.Commands;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 2249, 2519);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 2535, 2592);

                ConcurrentDictionary<string, CommandTypes>
                result = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 2608, 3980) || true) && (!testOnly)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 2608, 3980);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 2655, 2701);

                    var
                    extension = f_1527_2671_2700(modulePath)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 2719, 3965) || true) && (f_1527_2723_2819(extension, StringLiterals.PowerShellDataFileExtension, StringComparison.OrdinalIgnoreCase))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 2719, 3965);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 2861, 2940);

                        result = f_1527_2870_2939(modulePath, context, lastWriteTime, etwEnabled);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 2719, 3965);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 2719, 3965);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 2982, 3965) || true) && (f_1527_2986_3084(extension, StringLiterals.PowerShellModuleFileExtension, StringComparison.OrdinalIgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 2982, 3965);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 3126, 3191);

                            result = f_1527_3135_3190(modulePath, context, lastWriteTime);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 2982, 3965);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 2982, 3965);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 3233, 3965) || true) && (f_1527_3237_3342(extension, StringLiterals.PowerShellCmdletizationFileExtension, StringComparison.OrdinalIgnoreCase))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 3233, 3965);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 3384, 3448);

                                result = f_1527_3393_3447(modulePath, context, lastWriteTime);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 3233, 3965);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 3233, 3965);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 3490, 3965) || true) && (f_1527_3494_3592(extension, StringLiterals.PowerShellILAssemblyExtension, StringComparison.OrdinalIgnoreCase))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 3490, 3965);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 3634, 3696);

                                    result = f_1527_3643_3695(modulePath, context, lastWriteTime);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 3490, 3965);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 3490, 3965);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 3738, 3965) || true) && (f_1527_3742_3842(extension, StringLiterals.PowerShellILExecutableExtension, StringComparison.OrdinalIgnoreCase))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 3738, 3965);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 3884, 3946);

                                        result = f_1527_3893_3945(modulePath, context, lastWriteTime);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 3738, 3965);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 3490, 3965);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 3233, 3965);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 2982, 3965);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 2719, 3965);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 2608, 3980);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 3996, 4339) || true) && (result != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 3996, 4339);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 4048, 4081);

                    f_1527_4048_4080(s_cacheData);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 4099, 4183);

                    f_1527_4099_4182(ModuleIntrinsics.Tracer, "Returning {0} exported commands.", f_1527_4169_4181(result));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 3996, 4339);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 3996, 4339);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 4249, 4324);

                    f_1527_4249_4323(ModuleIntrinsics.Tracer, "Returning NULL for exported commands.");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 3996, 4339);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 4355, 4445) || true) && (etwEnabled)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 4355, 4445);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 4371, 4445);

                    f_1527_4371_4444(CommandDiscoveryEventSource.Log, modulePath);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 4355, 4445);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 4459, 4473);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1527, 1818, 4484);

                bool
                f_1527_1999_2042(System.Management.Automation.CommandDiscoveryEventSource
                this_param)
                {
                    var return_v = this_param.IsEnabled();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 1999, 2042);
                    return return_v;
                }


                int
                f_1527_2073_2147(System.Management.Automation.CommandDiscoveryEventSource
                this_param, string
                ModulePath)
                {
                    this_param.GetModuleExportedCommandsStart(ModulePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 2073, 2147);
                    return 0;
                }


                bool
                f_1527_2253_2329(string
                modulePath, out System.DateTime
                lastWriteTime, out System.Management.Automation.ModuleCacheEntry
                moduleCacheEntry)
                {
                    var return_v = GetModuleEntryFromCache(modulePath, out lastWriteTime, out moduleCacheEntry);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 2253, 2329);
                    return return_v;
                }


                int
                f_1527_2379_2452(System.Management.Automation.CommandDiscoveryEventSource
                this_param, string
                ModulePath)
                {
                    this_param.GetModuleExportedCommandsStop(ModulePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 2379, 2452);
                    return 0;
                }


                string?
                f_1527_2671_2700(string
                path)
                {
                    var return_v = Path.GetExtension(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 2671, 2700);
                    return return_v;
                }


                bool
                f_1527_2723_2819(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 2723, 2819);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.CommandTypes>
                f_1527_2870_2939(string
                modulePath, System.Management.Automation.ExecutionContext
                context, System.DateTime
                lastWriteTime, bool
                etwEnabled)
                {
                    var return_v = AnalyzeManifestModule(modulePath, context, lastWriteTime, etwEnabled);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 2870, 2939);
                    return return_v;
                }


                bool
                f_1527_2986_3084(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 2986, 3084);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.CommandTypes>
                f_1527_3135_3190(string
                modulePath, System.Management.Automation.ExecutionContext
                context, System.DateTime
                lastWriteTime)
                {
                    var return_v = AnalyzeScriptModule(modulePath, context, lastWriteTime);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 3135, 3190);
                    return return_v;
                }


                bool
                f_1527_3237_3342(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 3237, 3342);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.CommandTypes>
                f_1527_3393_3447(string
                modulePath, System.Management.Automation.ExecutionContext
                context, System.DateTime
                lastWriteTime)
                {
                    var return_v = AnalyzeCdxmlModule(modulePath, context, lastWriteTime);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 3393, 3447);
                    return return_v;
                }


                bool
                f_1527_3494_3592(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 3494, 3592);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.CommandTypes>
                f_1527_3643_3695(string
                modulePath, System.Management.Automation.ExecutionContext
                context, System.DateTime
                lastWriteTime)
                {
                    var return_v = AnalyzeDllModule(modulePath, context, lastWriteTime);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 3643, 3695);
                    return return_v;
                }


                bool
                f_1527_3742_3842(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 3742, 3842);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.CommandTypes>
                f_1527_3893_3945(string
                modulePath, System.Management.Automation.ExecutionContext
                context, System.DateTime
                lastWriteTime)
                {
                    var return_v = AnalyzeDllModule(modulePath, context, lastWriteTime);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 3893, 3945);
                    return return_v;
                }


                int
                f_1527_4048_4080(System.Management.Automation.AnalysisCacheData
                this_param)
                {
                    this_param.QueueSerialization();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 4048, 4080);
                    return 0;
                }


                int
                f_1527_4169_4181(System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.CommandTypes>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 4169, 4181);
                    return return_v;
                }


                int
                f_1527_4099_4182(System.Management.Automation.PSTraceSource
                this_param, string
                format, int
                arg1)
                {
                    this_param.WriteLine(format, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 4099, 4182);
                    return 0;
                }


                int
                f_1527_4249_4323(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 4249, 4323);
                    return 0;
                }


                int
                f_1527_4371_4444(System.Management.Automation.CommandDiscoveryEventSource
                this_param, string
                ModulePath)
                {
                    this_param.GetModuleExportedCommandsStop(ModulePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 4371, 4444);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1527, 1818, 4484);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1527, 1818, 4484);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ConcurrentDictionary<string, CommandTypes> AnalyzeManifestModule(string modulePath, ExecutionContext context, DateTime lastWriteTime, bool etwEnabled)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1527, 4496, 8753);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 4686, 4743);

                ConcurrentDictionary<string, CommandTypes>
                result = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 4793, 4921);

                    var
                    moduleManifestProperties = f_1527_4824_4920(modulePath, PsUtils.FastModuleManifestAnalysisPropertyNames)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 4939, 8145) || true) && (moduleManifestProperties != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 4939, 8145);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 5017, 5446) || true) && (!f_1527_5022_5090(Configuration.PowerShellConfig.Instance) && (DynAbs.Tracing.TraceSender.Expression_True(1527, 5021, 5159) && f_1527_5094_5159(modulePath, moduleManifestProperties)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 5017, 5446);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 5209, 5385);

                            f_1527_5209_5384(ModuleIntrinsics.Tracer, $"Module lies on the Windows System32 legacy module path and is incompatible with current PowerShell edition, skipping module: {modulePath}");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 5411, 5423);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 5017, 5446);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 5470, 5486);

                        Version
                        version
                        = default(Version);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 5508, 6080) || true) && (f_1527_5512_5578(modulePath, out version))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 5508, 6080);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 5628, 5733);

                            var
                            versionInManifest = f_1527_5652_5732(f_1527_5690_5731(moduleManifestProperties, "ModuleVersion"))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 5759, 6057) || true) && (version != versionInManifest)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 5759, 6057);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 5849, 5988);

                                f_1527_5849_5987(ModuleIntrinsics.Tracer, "ModuleVersion in manifest does not match versioned module directory, skipping module: {0}", modulePath);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 6018, 6030);

                                return null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 5759, 6057);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 5508, 6080);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 6104, 6229);

                        result = f_1527_6113_6228(3, f_1527_6163_6193(moduleManifestProperties), f_1527_6195_6227());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 6253, 6277);

                        var
                        sawWildcard = false
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 6299, 6428);

                        var
                        hadCmdlets = f_1527_6316_6427(result, f_1527_6345_6388(moduleManifestProperties, "CmdletsToExport"), CommandTypes.Cmdlet, ref sawWildcard)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 6450, 6585);

                        var
                        hadFunctions = f_1527_6469_6584(result, f_1527_6498_6543(moduleManifestProperties, "FunctionsToExport"), CommandTypes.Function, ref sawWildcard)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 6607, 6735);

                        var
                        hadAliases = f_1527_6624_6734(result, f_1527_6653_6696(moduleManifestProperties, "AliasesToExport"), CommandTypes.Alias, ref sawWildcard)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 6759, 6824);

                        var
                        analysisSucceeded = hadCmdlets && (DynAbs.Tracing.TraceSender.Expression_True(1527, 6783, 6809) && hadFunctions) && (DynAbs.Tracing.TraceSender.Expression_True(1527, 6783, 6823) && hadAliases)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 6848, 7381) || true) && (!analysisSucceeded && (DynAbs.Tracing.TraceSender.Expression_True(1527, 6852, 6886) && !sawWildcard) && (DynAbs.Tracing.TraceSender.Expression_True(1527, 6852, 6918) && (hadCmdlets || (DynAbs.Tracing.TraceSender.Expression_False(1527, 6891, 6917) || hadFunctions))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 6848, 7381);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 7222, 7358);

                            analysisSucceeded = !f_1527_7243_7357(moduleManifestProperties, hadCmdlets, hadFunctions, hadAliases);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 6848, 7381);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 7405, 8126) || true) && (analysisSucceeded)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 7405, 8126);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 7476, 7914);

                            var
                            moduleCacheEntry = new ModuleCacheEntry
                            {
                                ModulePath = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => modulePath, 1527, 7499, 7913),
                                LastWriteTime = lastWriteTime,
                                Commands = result,
                                TypesAnalyzed = false,
                                Types = f_1527_7798_7886(1, 8, f_1527_7853_7885())
                            }
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 7940, 7991);

                            f_1527_7940_7959(s_cacheData)[modulePath] = moduleCacheEntry;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 7405, 8126);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 7405, 8126);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 8089, 8103);

                            result = null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 7405, 8126);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 4939, 8145);
                    }
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1527, 8174, 8535);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 8226, 8329) || true) && (etwEnabled)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 8226, 8329);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 8242, 8329);

                        f_1527_8242_8328(CommandDiscoveryEventSource.Log, modulePath, f_1527_8318_8327(e));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 8226, 8329);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 8425, 8520);

                    f_1527_8425_8519(                // Ignore the errors, proceed with the usual module analysis
                                    ModuleIntrinsics.Tracer, "Exception on fast-path analysis of module {0}", modulePath);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1527, 8174, 8535);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 8551, 8656) || true) && (etwEnabled)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 8551, 8656);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 8567, 8656);

                    f_1527_8567_8655(CommandDiscoveryEventSource.Log, modulePath, result != null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 8551, 8656);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 8672, 8742);

                return result ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.CommandTypes>>(1527, 8679, 8741) ?? f_1527_8689_8741(modulePath, context, lastWriteTime));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1527, 4496, 8753);

                System.Collections.Hashtable
                f_1527_4824_4920(string
                psDataFilePath, string[]
                keys)
                {
                    var return_v = PsUtils.GetModuleManifestProperties(psDataFilePath, keys);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 4824, 4920);
                    return return_v;
                }


                bool
                f_1527_5022_5090(System.Management.Automation.Configuration.PowerShellConfig
                this_param)
                {
                    var return_v = this_param.IsImplicitWinCompatEnabled();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 5022, 5090);
                    return return_v;
                }


                bool
                f_1527_5094_5159(string
                modulePath, System.Collections.Hashtable
                moduleManifestProperties)
                {
                    var return_v = ModuleIsEditionIncompatible(modulePath, moduleManifestProperties);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 5094, 5159);
                    return return_v;
                }


                int
                f_1527_5209_5384(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 5209, 5384);
                    return 0;
                }


                bool
                f_1527_5512_5578(string
                modulePath, out System.Version
                version)
                {
                    var return_v = ModuleUtils.IsModuleInVersionSubdirectory(modulePath, out version);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 5512, 5578);
                    return return_v;
                }


                object
                f_1527_5690_5731(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 5690, 5731);
                    return return_v;
                }


                System.Version
                f_1527_5652_5732(object
                valueToConvert)
                {
                    var return_v = LanguagePrimitives.ConvertTo<Version>(valueToConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 5652, 5732);
                    return return_v;
                }


                int
                f_1527_5849_5987(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 5849, 5987);
                    return 0;
                }


                int
                f_1527_6163_6193(System.Collections.Hashtable
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 6163, 6193);
                    return return_v;
                }


                System.StringComparer
                f_1527_6195_6227()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 6195, 6227);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.CommandTypes>
                f_1527_6113_6228(int
                concurrencyLevel, int
                capacity, System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.CommandTypes>(concurrencyLevel, capacity, (System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 6113, 6228);
                    return return_v;
                }


                object
                f_1527_6345_6388(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 6345, 6388);
                    return return_v;
                }


                bool
                f_1527_6316_6427(System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.CommandTypes>
                result, object
                value, System.Management.Automation.CommandTypes
                commandTypeToAdd, ref bool
                sawWildcard)
                {
                    var return_v = AddPsd1EntryToResult(result, value, commandTypeToAdd, ref sawWildcard);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 6316, 6427);
                    return return_v;
                }


                object
                f_1527_6498_6543(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 6498, 6543);
                    return return_v;
                }


                bool
                f_1527_6469_6584(System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.CommandTypes>
                result, object
                value, System.Management.Automation.CommandTypes
                commandTypeToAdd, ref bool
                sawWildcard)
                {
                    var return_v = AddPsd1EntryToResult(result, value, commandTypeToAdd, ref sawWildcard);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 6469, 6584);
                    return return_v;
                }


                object
                f_1527_6653_6696(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 6653, 6696);
                    return return_v;
                }


                bool
                f_1527_6624_6734(System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.CommandTypes>
                result, object
                value, System.Management.Automation.CommandTypes
                commandTypeToAdd, ref bool
                sawWildcard)
                {
                    var return_v = AddPsd1EntryToResult(result, value, commandTypeToAdd, ref sawWildcard);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 6624, 6734);
                    return return_v;
                }


                bool
                f_1527_7243_7357(System.Collections.Hashtable
                moduleManifestProperties, bool
                hadCmdlets, bool
                hadFunctions, bool
                hadAliases)
                {
                    var return_v = CheckModulesTypesInManifestAgainstExportedCommands(moduleManifestProperties, hadCmdlets, hadFunctions, hadAliases);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 7243, 7357);
                    return return_v;
                }


                System.StringComparer
                f_1527_7853_7885()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 7853, 7885);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.Language.TypeAttributes>
                f_1527_7798_7886(int
                concurrencyLevel, int
                capacity, System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.Language.TypeAttributes>(concurrencyLevel, capacity, (System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 7798, 7886);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.ModuleCacheEntry>
                f_1527_7940_7959(System.Management.Automation.AnalysisCacheData
                this_param)
                {
                    var return_v = this_param.Entries;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 7940, 7959);
                    return return_v;
                }


                string
                f_1527_8318_8327(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 8318, 8327);
                    return return_v;
                }


                int
                f_1527_8242_8328(System.Management.Automation.CommandDiscoveryEventSource
                this_param, string
                ModulePath, string
                Exception)
                {
                    this_param.ModuleManifestAnalysisException(ModulePath, Exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 8242, 8328);
                    return 0;
                }


                int
                f_1527_8425_8519(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 8425, 8519);
                    return 0;
                }


                int
                f_1527_8567_8655(System.Management.Automation.CommandDiscoveryEventSource
                this_param, string
                ModulePath, bool
                Success)
                {
                    this_param.ModuleManifestAnalysisResult(ModulePath, Success);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 8567, 8655);
                    return 0;
                }


                System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.CommandTypes>
                f_1527_8689_8741(string
                modulePath, System.Management.Automation.ExecutionContext
                context, System.DateTime
                lastWriteTime)
                {
                    var return_v = AnalyzeTheOldWay(modulePath, context, lastWriteTime);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 8689, 8741);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1527, 4496, 8753);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1527, 4496, 8753);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool ModuleIsEditionIncompatible(string modulePath, Hashtable moduleManifestProperties)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1527, 9132, 9719);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 9304, 9417) || true) && (!f_1527_9309_9355(modulePath))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 9304, 9417);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 9389, 9402);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 9304, 9417);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 9433, 9559) || true) && (!f_1527_9438_9498(moduleManifestProperties, "CompatiblePSEditions"))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 9433, 9559);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 9532, 9544);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 9433, 9559);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 9575, 9700);

                return !f_1527_9583_9699(f_1527_9610_9698(f_1527_9649_9697(moduleManifestProperties, "CompatiblePSEditions")));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1527, 9132, 9719);

                bool
                f_1527_9309_9355(string
                path)
                {
                    var return_v = ModuleUtils.IsOnSystem32ModulePath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 9309, 9355);
                    return return_v;
                }


                bool
                f_1527_9438_9498(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 9438, 9498);
                    return return_v;
                }


                object
                f_1527_9649_9697(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 9649, 9697);
                    return return_v;
                }


                string[]
                f_1527_9610_9698(object
                valueToConvert)
                {
                    var return_v = LanguagePrimitives.ConvertTo<string[]>(valueToConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 9610, 9698);
                    return return_v;
                }


                bool
                f_1527_9583_9699(string[]
                editions)
                {
                    var return_v = Utils.IsPSEditionSupported((System.Collections.Generic.IEnumerable<string>)editions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 9583, 9699);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1527, 9132, 9719);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1527, 9132, 9719);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool ModuleAnalysisViaGetModuleRequired(object modulePathObj, bool hadCmdlets, bool hadFunctions, bool hadAliases)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1527, 9731, 12007);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 9886, 9927);

                var
                modulePath = modulePathObj as string
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 9941, 9994) || true) && (modulePath == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 9941, 9994);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 9982, 9994);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 9941, 9994);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 10010, 10497) || true) && (f_1527_10014_10115(modulePath, StringLiterals.PowerShellModuleFileExtension, StringComparison.OrdinalIgnoreCase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 10010, 10497);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 10470, 10482);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 10010, 10497);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 10513, 10834) || true) && (f_1527_10517_10625(modulePath, StringLiterals.PowerShellCmdletizationFileExtension, StringComparison.OrdinalIgnoreCase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 10513, 10834);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 10783, 10819);

                    return !hadFunctions || (DynAbs.Tracing.TraceSender.Expression_False(1527, 10790, 10818) || !hadAliases);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 10513, 10834);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 10850, 11350) || true) && (f_1527_10854_10955(modulePath, StringLiterals.PowerShellILAssemblyExtension, StringComparison.OrdinalIgnoreCase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 10850, 11350);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 11316, 11335);

                    return !hadCmdlets;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 10850, 11350);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 11366, 11868) || true) && (f_1527_11370_11473(modulePath, StringLiterals.PowerShellILExecutableExtension, StringComparison.OrdinalIgnoreCase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 11366, 11868);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 11834, 11853);

                    return !hadCmdlets;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 11366, 11868);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 11984, 11996);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1527, 9731, 12007);

                bool
                f_1527_10014_10115(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.EndsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 10014, 10115);
                    return return_v;
                }


                bool
                f_1527_10517_10625(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.EndsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 10517, 10625);
                    return return_v;
                }


                bool
                f_1527_10854_10955(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.EndsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 10854, 10955);
                    return return_v;
                }


                bool
                f_1527_11370_11473(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.EndsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 11370, 11473);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1527, 9731, 12007);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1527, 9731, 12007);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool CheckModulesTypesInManifestAgainstExportedCommands(Hashtable moduleManifestProperties, bool hadCmdlets, bool hadFunctions, bool hadAliases)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1527, 12402, 13888);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 12586, 12642);

                var
                rootModule = f_1527_12603_12641(moduleManifestProperties, "RootModule")
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 12656, 12797) || true) && (rootModule != null && (DynAbs.Tracing.TraceSender.Expression_True(1527, 12660, 12766) && f_1527_12682_12766(rootModule, hadCmdlets, hadFunctions, hadAliases)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 12656, 12797);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 12785, 12797);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 12656, 12797);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 12813, 12879);

                var
                moduleToProcess = f_1527_12835_12878(moduleManifestProperties, "ModuleToProcess")
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 12893, 13044) || true) && (moduleToProcess != null && (DynAbs.Tracing.TraceSender.Expression_True(1527, 12897, 13013) && f_1527_12924_13013(moduleToProcess, hadCmdlets, hadFunctions, hadAliases)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 12893, 13044);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 13032, 13044);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 12893, 13044);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 13060, 13122);

                var
                nestedModules = f_1527_13080_13121(moduleManifestProperties, "NestedModules")
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 13136, 13848) || true) && (nestedModules != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 13136, 13848);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 13195, 13238);

                    var
                    nestedModule = nestedModules as string
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 13256, 13435) || true) && (nestedModule != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 13256, 13435);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 13322, 13416);

                        return f_1527_13329_13415(nestedModule, hadCmdlets, hadFunctions, hadAliases);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 13256, 13435);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 13455, 13505);

                    var
                    nestedModuleArray = nestedModules as object[]
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 13523, 13587) || true) && (nestedModuleArray == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 13523, 13587);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 13575, 13587);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 13523, 13587);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 13607, 13833);
                        foreach (var element in f_1527_13631_13648_I(nestedModuleArray))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 13607, 13833);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 13690, 13814) || true) && (f_1527_13694_13775(element, hadCmdlets, hadFunctions, hadAliases))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 13690, 13814);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 13802, 13814);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 13690, 13814);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 13607, 13833);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1527, 1, 227);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1527, 1, 227);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 13136, 13848);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 13864, 13877);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1527, 12402, 13888);

                object
                f_1527_12603_12641(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 12603, 12641);
                    return return_v;
                }


                bool
                f_1527_12682_12766(object
                modulePathObj, bool
                hadCmdlets, bool
                hadFunctions, bool
                hadAliases)
                {
                    var return_v = ModuleAnalysisViaGetModuleRequired(modulePathObj, hadCmdlets, hadFunctions, hadAliases);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 12682, 12766);
                    return return_v;
                }


                object
                f_1527_12835_12878(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 12835, 12878);
                    return return_v;
                }


                bool
                f_1527_12924_13013(object
                modulePathObj, bool
                hadCmdlets, bool
                hadFunctions, bool
                hadAliases)
                {
                    var return_v = ModuleAnalysisViaGetModuleRequired(modulePathObj, hadCmdlets, hadFunctions, hadAliases);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 12924, 13013);
                    return return_v;
                }


                object
                f_1527_13080_13121(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 13080, 13121);
                    return return_v;
                }


                bool
                f_1527_13329_13415(string
                modulePathObj, bool
                hadCmdlets, bool
                hadFunctions, bool
                hadAliases)
                {
                    var return_v = ModuleAnalysisViaGetModuleRequired((object)modulePathObj, hadCmdlets, hadFunctions, hadAliases);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 13329, 13415);
                    return return_v;
                }


                bool
                f_1527_13694_13775(object
                modulePathObj, bool
                hadCmdlets, bool
                hadFunctions, bool
                hadAliases)
                {
                    var return_v = ModuleAnalysisViaGetModuleRequired(modulePathObj, hadCmdlets, hadFunctions, hadAliases);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 13694, 13775);
                    return return_v;
                }


                object[]
                f_1527_13631_13648_I(object[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 13631, 13648);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1527, 12402, 13888);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1527, 12402, 13888);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool AddPsd1EntryToResult(ConcurrentDictionary<string, CommandTypes> result, string command, CommandTypes commandTypeToAdd, ref bool sawWildcard)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1527, 13900, 14795);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 14085, 14239) || true) && (f_1527_14089_14140(command))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 14085, 14239);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 14174, 14193);

                    sawWildcard = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 14211, 14224);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 14085, 14239);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 14332, 14756) || true) && (f_1527_14336_14350(command) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 14332, 14756);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 14389, 14415);

                    CommandTypes
                    commandTypes
                    = default(CommandTypes);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 14433, 14690) || true) && (f_1527_14437_14482(result, command, out commandTypes))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 14433, 14690);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 14524, 14557);

                        commandTypes |= commandTypeToAdd;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 14433, 14690);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 14433, 14690);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 14639, 14671);

                        commandTypes = commandTypeToAdd;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 14433, 14690);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 14710, 14741);

                    result[command] = commandTypes;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 14332, 14756);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 14772, 14784);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1527, 13900, 14795);

                bool
                f_1527_14089_14140(string
                pattern)
                {
                    var return_v = WildcardPattern.ContainsWildcardCharacters(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 14089, 14140);
                    return return_v;
                }


                int
                f_1527_14336_14350(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 14336, 14350);
                    return return_v;
                }


                bool
                f_1527_14437_14482(System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.CommandTypes>
                this_param, string
                key, out System.Management.Automation.CommandTypes
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 14437, 14482);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1527, 13900, 14795);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1527, 13900, 14795);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool AddPsd1EntryToResult(ConcurrentDictionary<string, CommandTypes> result, object value, CommandTypes commandTypeToAdd, ref bool sawWildcard)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1527, 14807, 15841);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 14990, 15023);

                string
                command = value as string
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 15037, 15185) || true) && (command != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 15037, 15185);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 15090, 15170);

                    return f_1527_15097_15169(result, command, commandTypeToAdd, ref sawWildcard);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 15037, 15185);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 15201, 15239);

                object[]
                commands = value as object[]
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 15253, 15726) || true) && (commands != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 15253, 15726);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 15307, 15505);
                        foreach (var o in f_1527_15325_15333_I(commands))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 15307, 15505);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 15375, 15486) || true) && (!f_1527_15380_15446(result, o, commandTypeToAdd, ref sawWildcard))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 15375, 15486);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 15473, 15486);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 15375, 15486);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 15307, 15505);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1527, 1, 199);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1527, 1, 199);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 15699, 15711);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 15253, 15726);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 15817, 15830);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1527, 14807, 15841);

                bool
                f_1527_15097_15169(System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.CommandTypes>
                result, string
                command, System.Management.Automation.CommandTypes
                commandTypeToAdd, ref bool
                sawWildcard)
                {
                    var return_v = AddPsd1EntryToResult(result, command, commandTypeToAdd, ref sawWildcard);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 15097, 15169);
                    return return_v;
                }


                bool
                f_1527_15380_15446(System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.CommandTypes>
                result, object
                value, System.Management.Automation.CommandTypes
                commandTypeToAdd, ref bool
                sawWildcard)
                {
                    var return_v = AddPsd1EntryToResult(result, value, commandTypeToAdd, ref sawWildcard);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 15380, 15446);
                    return return_v;
                }


                object[]
                f_1527_15325_15333_I(object[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 15325, 15333);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1527, 14807, 15841);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1527, 14807, 15841);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ConcurrentDictionary<string, CommandTypes> AnalyzeScriptModule(string modulePath, ExecutionContext context, DateTime lastWriteTime)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1527, 15853, 19374);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 16024, 16089);

                var
                scriptAnalysis = f_1527_16045_16088(modulePath, context)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 16103, 16190) || true) && (scriptAnalysis == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 16103, 16190);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 16163, 16175);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 16103, 16190);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 16206, 16281);

                List<WildcardPattern>
                scriptAnalysisPatterns = f_1527_16253_16280()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 16295, 16499);
                    foreach (string discoveredCommandFilter in f_1527_16338_16377_I(f_1527_16338_16377(scriptAnalysis)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 16295, 16499);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 16411, 16484);

                        f_1527_16411_16483(scriptAnalysisPatterns, f_1527_16438_16482(discoveredCommandFilter));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 16295, 16499);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1527, 1, 205);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1527, 1, 205);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 16515, 16727);

                var
                result = f_1527_16528_16726(3, f_1527_16595_16633(f_1527_16595_16627(scriptAnalysis)) + f_1527_16636_16674(f_1527_16636_16668(scriptAnalysis)), f_1527_16693_16725())
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 16795, 17220);
                    foreach (var command in f_1527_16819_16851_I(f_1527_16819_16851(scriptAnalysis)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 16795, 17220);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 16885, 17205) || true) && (f_1527_16889_16975(command, scriptAnalysisPatterns, true))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 16885, 17205);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 17017, 17186) || true) && (f_1527_17021_17069(command, InvalidCommandNameCharacters) < 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 17017, 17186);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 17123, 17163);

                                result[command] = CommandTypes.Function;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 17017, 17186);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 16885, 17205);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 16795, 17220);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1527, 1, 426);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1527, 1, 426);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 17279, 17741);
                    foreach (var pair in f_1527_17300_17332_I(f_1527_17300_17332(scriptAnalysis)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 17279, 17741);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 17366, 17393);

                        var
                        commandName = pair.Key
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 17458, 17726) || true) && (f_1527_17462_17514(commandName, InvalidCommandNameCharacters) < 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 17458, 17726);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 17560, 17707);

                            f_1527_17560_17706(result, commandName, CommandTypes.Alias, (_, existingCommandType) => existingCommandType | CommandTypes.Alias);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 17458, 17726);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 17279, 17741);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1527, 1, 463);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1527, 1, 463);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 17834, 18582) || true) && (f_1527_17838_17867(scriptAnalysis))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 17834, 18582);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 17901, 17958);

                    string
                    baseDirectory = f_1527_17924_17957(modulePath)
                    ;

                    try
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 18022, 18405);
                            foreach (string item in f_1527_18046_18088_I(f_1527_18046_18088(baseDirectory, "*.ps1")))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 18022, 18405);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 18138, 18191);

                                var
                                command = f_1527_18152_18190(item)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 18217, 18382);

                                f_1527_18217_18381(result, command, CommandTypes.ExternalScript, (_, existingCommandType) => existingCommandType | CommandTypes.ExternalScript);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 18022, 18405);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1527, 1, 384);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1527, 1, 384);
                        }
                    }
                    catch (UnauthorizedAccessException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1527, 18442, 18567);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1527, 18442, 18567);
                        // Consume this exception here
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 17834, 18582);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 18598, 18780);

                var
                exportedClasses = f_1527_18620_18779(1, f_1527_18706_18744(f_1527_18706_18738(scriptAnalysis)), f_1527_18746_18778())
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 18794, 18972);
                    foreach (var exportedClass in f_1527_18824_18856_I(f_1527_18824_18856(scriptAnalysis)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 18794, 18972);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 18890, 18957);

                        exportedClasses[f_1527_18906_18924(exportedClass)] = f_1527_18928_18956(exportedClass);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 18794, 18972);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1527, 1, 179);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1527, 1, 179);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 18988, 19268);

                var
                moduleCacheEntry = new ModuleCacheEntry
                {
                    ModulePath = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => modulePath, 1527, 19011, 19267),
                    LastWriteTime = lastWriteTime,
                    Commands = result,
                    TypesAnalyzed = true,
                    Types = exportedClasses
                }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 19282, 19333);

                f_1527_19282_19301(s_cacheData)[modulePath] = moduleCacheEntry;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 19349, 19363);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1527, 15853, 19374);

                System.Management.Automation.ScriptAnalysis
                f_1527_16045_16088(string
                path, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = ScriptAnalysis.Analyze(path, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 16045, 16088);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                f_1527_16253_16280()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.WildcardPattern>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 16253, 16280);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1527_16338_16377(System.Management.Automation.ScriptAnalysis
                this_param)
                {
                    var return_v = this_param.DiscoveredCommandFilters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 16338, 16377);
                    return return_v;
                }


                System.Management.Automation.WildcardPattern
                f_1527_16438_16482(string
                pattern)
                {
                    var return_v = new System.Management.Automation.WildcardPattern(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 16438, 16482);
                    return return_v;
                }


                int
                f_1527_16411_16483(System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                this_param, System.Management.Automation.WildcardPattern
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 16411, 16483);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_1527_16338_16377_I(System.Collections.Generic.List<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 16338, 16377);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1527_16595_16627(System.Management.Automation.ScriptAnalysis
                this_param)
                {
                    var return_v = this_param.DiscoveredExports;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 16595, 16627);
                    return return_v;
                }


                int
                f_1527_16595_16633(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 16595, 16633);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, string>
                f_1527_16636_16668(System.Management.Automation.ScriptAnalysis
                this_param)
                {
                    var return_v = this_param.DiscoveredAliases;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 16636, 16668);
                    return return_v;
                }


                int
                f_1527_16636_16674(System.Collections.Generic.Dictionary<string, string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 16636, 16674);
                    return return_v;
                }


                System.StringComparer
                f_1527_16693_16725()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 16693, 16725);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.CommandTypes>
                f_1527_16528_16726(int
                concurrencyLevel, int
                capacity, System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.CommandTypes>(concurrencyLevel, capacity, (System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 16528, 16726);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1527_16819_16851(System.Management.Automation.ScriptAnalysis
                this_param)
                {
                    var return_v = this_param.DiscoveredExports;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 16819, 16851);
                    return return_v;
                }


                bool
                f_1527_16889_16975(string
                text, System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                patterns, bool
                defaultValue)
                {
                    var return_v = SessionStateUtilities.MatchesAnyWildcardPattern(text, (System.Collections.Generic.IEnumerable<System.Management.Automation.WildcardPattern>)patterns, defaultValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 16889, 16975);
                    return return_v;
                }


                int
                f_1527_17021_17069(string
                this_param, char[]
                anyOf)
                {
                    var return_v = this_param.IndexOfAny(anyOf);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 17021, 17069);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1527_16819_16851_I(System.Collections.Generic.List<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 16819, 16851);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, string>
                f_1527_17300_17332(System.Management.Automation.ScriptAnalysis
                this_param)
                {
                    var return_v = this_param.DiscoveredAliases;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 17300, 17332);
                    return return_v;
                }


                int
                f_1527_17462_17514(string
                this_param, char[]
                anyOf)
                {
                    var return_v = this_param.IndexOfAny(anyOf);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 17462, 17514);
                    return return_v;
                }


                System.Management.Automation.CommandTypes
                f_1527_17560_17706(System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.CommandTypes>
                this_param, string
                key, System.Management.Automation.CommandTypes
                addValue, System.Func<string, System.Management.Automation.CommandTypes, System.Management.Automation.CommandTypes>
                updateValueFactory)
                {
                    var return_v = this_param.AddOrUpdate(key, addValue, updateValueFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 17560, 17706);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, string>
                f_1527_17300_17332_I(System.Collections.Generic.Dictionary<string, string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 17300, 17332);
                    return return_v;
                }


                bool
                f_1527_17838_17867(System.Management.Automation.ScriptAnalysis
                this_param)
                {
                    var return_v = this_param.AddsSelfToPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 17838, 17867);
                    return return_v;
                }


                string?
                f_1527_17924_17957(string
                path)
                {
                    var return_v = Path.GetDirectoryName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 17924, 17957);
                    return return_v;
                }


                string[]
                f_1527_18046_18088(string
                path, string
                searchPattern)
                {
                    var return_v = Directory.GetFiles(path, searchPattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 18046, 18088);
                    return return_v;
                }


                string?
                f_1527_18152_18190(string
                path)
                {
                    var return_v = Path.GetFileNameWithoutExtension(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 18152, 18190);
                    return return_v;
                }


                System.Management.Automation.CommandTypes
                f_1527_18217_18381(System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.CommandTypes>
                this_param, string
                key, System.Management.Automation.CommandTypes
                addValue, System.Func<string, System.Management.Automation.CommandTypes, System.Management.Automation.CommandTypes>
                updateValueFactory)
                {
                    var return_v = this_param.AddOrUpdate(key, addValue, updateValueFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 18217, 18381);
                    return return_v;
                }


                string[]
                f_1527_18046_18088_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 18046, 18088);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.TypeDefinitionAst>
                f_1527_18706_18738(System.Management.Automation.ScriptAnalysis
                this_param)
                {
                    var return_v = this_param.DiscoveredClasses;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 18706, 18738);
                    return return_v;
                }


                int
                f_1527_18706_18744(System.Collections.Generic.List<System.Management.Automation.Language.TypeDefinitionAst>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 18706, 18744);
                    return return_v;
                }


                System.StringComparer
                f_1527_18746_18778()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 18746, 18778);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.Language.TypeAttributes>
                f_1527_18620_18779(int
                concurrencyLevel, int
                capacity, System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.Language.TypeAttributes>(concurrencyLevel, capacity, (System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 18620, 18779);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.TypeDefinitionAst>
                f_1527_18824_18856(System.Management.Automation.ScriptAnalysis
                this_param)
                {
                    var return_v = this_param.DiscoveredClasses;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 18824, 18856);
                    return return_v;
                }


                string
                f_1527_18906_18924(System.Management.Automation.Language.TypeDefinitionAst
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 18906, 18924);
                    return return_v;
                }


                System.Management.Automation.Language.TypeAttributes
                f_1527_18928_18956(System.Management.Automation.Language.TypeDefinitionAst
                this_param)
                {
                    var return_v = this_param.TypeAttributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 18928, 18956);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.TypeDefinitionAst>
                f_1527_18824_18856_I(System.Collections.Generic.List<System.Management.Automation.Language.TypeDefinitionAst>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 18824, 18856);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.ModuleCacheEntry>
                f_1527_19282_19301(System.Management.Automation.AnalysisCacheData
                this_param)
                {
                    var return_v = this_param.Entries;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 19282, 19301);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1527, 15853, 19374);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1527, 15853, 19374);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ConcurrentDictionary<string, CommandTypes> AnalyzeCdxmlModule(string modulePath, ExecutionContext context, DateTime lastWriteTime)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1527, 19386, 19627);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 19556, 19616);

                return f_1527_19563_19615(modulePath, context, lastWriteTime);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1527, 19386, 19627);

                System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.CommandTypes>
                f_1527_19563_19615(string
                modulePath, System.Management.Automation.ExecutionContext
                context, System.DateTime
                lastWriteTime)
                {
                    var return_v = AnalyzeTheOldWay(modulePath, context, lastWriteTime);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 19563, 19615);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1527, 19386, 19627);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1527, 19386, 19627);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ConcurrentDictionary<string, CommandTypes> AnalyzeDllModule(string modulePath, ExecutionContext context, DateTime lastWriteTime)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1527, 19639, 19878);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 19807, 19867);

                return f_1527_19814_19866(modulePath, context, lastWriteTime);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1527, 19639, 19878);

                System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.CommandTypes>
                f_1527_19814_19866(string
                modulePath, System.Management.Automation.ExecutionContext
                context, System.DateTime
                lastWriteTime)
                {
                    var return_v = AnalyzeTheOldWay(modulePath, context, lastWriteTime);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 19814, 19866);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1527, 19639, 19878);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1527, 19639, 19878);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ConcurrentDictionary<string, CommandTypes> AnalyzeTheOldWay(string modulePath, ExecutionContext context, DateTime lastWriteTime)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1527, 19890, 21430);
                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 20184, 20426) || true) && (!f_1527_20189_20242(s_modulesBeingAnalyzed, modulePath, modulePath))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 20184, 20426);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 20284, 20373);

                        f_1527_20284_20372(ModuleIntrinsics.Tracer, "{0} is already being analyzed. Exiting.", modulePath);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 20395, 20407);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 20184, 20426);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 20555, 20626);

                    f_1527_20555_20625(
                                    // Record that we're analyzing this specific module so that we don't get stuck in recursion
                                    ModuleIntrinsics.Tracer, "Started analysis: {0}", modulePath);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 20644, 20687);

                    f_1527_20644_20686(context, modulePath);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 20707, 20741);

                    ModuleCacheEntry
                    moduleCacheEntry
                    = default(ModuleCacheEntry);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 20759, 20933) || true) && (f_1527_20763_20839(modulePath, out lastWriteTime, out moduleCacheEntry))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 20759, 20933);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 20881, 20914);

                        return moduleCacheEntry.Commands;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 20759, 20933);
                    }
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1527, 20962, 21171);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 21014, 21098);

                    f_1527_21014_21097(ModuleIntrinsics.Tracer, "Module analysis generated an exception: {0}", e);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1527, 20962, 21171);

                    // Catch-all OK, third-party call-out.
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1527, 21185, 21391);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 21225, 21297);

                    f_1527_21225_21296(ModuleIntrinsics.Tracer, "Finished analysis: {0}", modulePath);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 21315, 21376);

                    f_1527_21315_21375(s_modulesBeingAnalyzed, modulePath, out modulePath);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1527, 21185, 21391);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 21407, 21419);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1527, 19890, 21430);

                bool
                f_1527_20189_20242(System.Collections.Concurrent.ConcurrentDictionary<string, string>
                this_param, string
                key, string
                value)
                {
                    var return_v = this_param.TryAdd(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 20189, 20242);
                    return return_v;
                }


                int
                f_1527_20284_20372(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 20284, 20372);
                    return 0;
                }


                int
                f_1527_20555_20625(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 20555, 20625);
                    return 0;
                }


                int
                f_1527_20644_20686(System.Management.Automation.ExecutionContext
                context, string
                modulePath)
                {
                    CallGetModuleDashList(context, modulePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 20644, 20686);
                    return 0;
                }


                bool
                f_1527_20763_20839(string
                modulePath, out System.DateTime
                lastWriteTime, out System.Management.Automation.ModuleCacheEntry
                moduleCacheEntry)
                {
                    var return_v = GetModuleEntryFromCache(modulePath, out lastWriteTime, out moduleCacheEntry);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 20763, 20839);
                    return return_v;
                }


                int
                f_1527_21014_21097(System.Management.Automation.PSTraceSource
                this_param, string
                format, System.Exception
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 21014, 21097);
                    return 0;
                }


                int
                f_1527_21225_21296(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 21225, 21296);
                    return 0;
                }


                bool
                f_1527_21315_21375(System.Collections.Concurrent.ConcurrentDictionary<string, string>
                this_param, string
                key, out string
                value)
                {
                    var return_v = this_param.TryRemove(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 21315, 21375);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1527, 19890, 21430);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1527, 19890, 21430);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ConcurrentDictionary<string, TypeAttributes> GetExportedClasses(string modulePath, ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1527, 21891, 22879);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 22040, 22063);

                DateTime
                lastWriteTime
                = default(DateTime);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 22077, 22111);

                ModuleCacheEntry
                moduleCacheEntry
                = default(ModuleCacheEntry);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 22125, 22318) || true) && (f_1527_22129_22205(modulePath, out lastWriteTime, out moduleCacheEntry) && (DynAbs.Tracing.TraceSender.Expression_True(1527, 22129, 22239) && moduleCacheEntry.TypesAnalyzed))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 22125, 22318);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 22273, 22303);

                    return moduleCacheEntry.Types;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 22125, 22318);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 22370, 22413);

                    f_1527_22370_22412(context, modulePath);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 22431, 22602) || true) && (f_1527_22435_22511(modulePath, out lastWriteTime, out moduleCacheEntry))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 22431, 22602);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 22553, 22583);

                        return moduleCacheEntry.Types;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 22431, 22602);
                    }
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1527, 22631, 22840);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 22683, 22767);

                    f_1527_22683_22766(ModuleIntrinsics.Tracer, "Module analysis generated an exception: {0}", e);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1527, 22631, 22840);

                    // Catch-all OK, third-party call-out.
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 22856, 22868);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1527, 21891, 22879);

                bool
                f_1527_22129_22205(string
                modulePath, out System.DateTime
                lastWriteTime, out System.Management.Automation.ModuleCacheEntry
                moduleCacheEntry)
                {
                    var return_v = GetModuleEntryFromCache(modulePath, out lastWriteTime, out moduleCacheEntry);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 22129, 22205);
                    return return_v;
                }


                int
                f_1527_22370_22412(System.Management.Automation.ExecutionContext
                context, string
                modulePath)
                {
                    CallGetModuleDashList(context, modulePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 22370, 22412);
                    return 0;
                }


                bool
                f_1527_22435_22511(string
                modulePath, out System.DateTime
                lastWriteTime, out System.Management.Automation.ModuleCacheEntry
                moduleCacheEntry)
                {
                    var return_v = GetModuleEntryFromCache(modulePath, out lastWriteTime, out moduleCacheEntry);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 22435, 22511);
                    return return_v;
                }


                int
                f_1527_22683_22766(System.Management.Automation.PSTraceSource
                this_param, string
                format, System.Exception
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 22683, 22766);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1527, 21891, 22879);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1527, 21891, 22879);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void CacheModuleExports(PSModuleInfo module, ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1527, 22891, 27581);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 23002, 23078);

                f_1527_23002_23077(ModuleIntrinsics.Tracer, "Requested caching for {0}", f_1527_23065_23076(module));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 23266, 23554) || true) && (!f_1527_23271_23339(Configuration.PowerShellConfig.Instance) && (DynAbs.Tracing.TraceSender.Expression_True(1527, 23270, 23380) && f_1527_23343_23380_M(!module.IsConsideredEditionCompatible)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 23266, 23554);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 23414, 23514);

                    f_1527_23414_23513(ModuleIntrinsics.Tracer, $"Module '{f_1527_23459_23470(module)}' not edition compatible and not cached.");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 23532, 23539);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 23266, 23554);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 23570, 23593);

                DateTime
                lastWriteTime
                = default(DateTime);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 23607, 23641);

                ModuleCacheEntry
                moduleCacheEntry
                = default(ModuleCacheEntry);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 23655, 23733);

                f_1527_23655_23732(f_1527_23679_23690(module), out lastWriteTime, out moduleCacheEntry);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 23749, 23800);

                var
                realExportedCommands = f_1527_23776_23799(module)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 23814, 23876);

                var
                realExportedClasses = f_1527_23840_23875(module)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 23890, 23950);

                ConcurrentDictionary<string, CommandTypes>
                exportedCommands
                = default(ConcurrentDictionary<string, CommandTypes>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 23964, 24025);

                ConcurrentDictionary<string, TypeAttributes>
                exportedClasses
                = default(ConcurrentDictionary<string, TypeAttributes>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 24256, 26857) || true) && (moduleCacheEntry != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 24256, 26857);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 24318, 24344);

                    bool
                    needToUpdate = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 24485, 24530);

                    exportedCommands = moduleCacheEntry.Commands;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 24548, 25035);
                        foreach (var pair in f_1527_24569_24589_I(realExportedCommands))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 24548, 25035);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 24631, 24658);

                            var
                            commandName = pair.Key
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 24680, 24725);

                            var
                            realCommandType = f_1527_24702_24724(pair.Value)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 24747, 24772);

                            CommandTypes
                            commandType
                            = default(CommandTypes);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 24794, 25016) || true) && (!f_1527_24799_24857(exportedCommands, commandName, out commandType) || (DynAbs.Tracing.TraceSender.Expression_False(1527, 24798, 24891) || commandType != realCommandType))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 24794, 25016);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 24941, 24961);

                                needToUpdate = true;
                                DynAbs.Tracing.TraceSender.TraceBreak(1527, 24987, 24993);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 24794, 25016);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 24548, 25035);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1527, 1, 488);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1527, 1, 488);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 25055, 25096);

                    exportedClasses = moduleCacheEntry.Types;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 25114, 25640);
                        foreach (var pair in f_1527_25135_25154_I(realExportedClasses))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 25114, 25640);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 25196, 25221);

                            var
                            className = pair.Key
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 25243, 25294);

                            var
                            realTypeAttributes = f_1527_25268_25293(pair.Value)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 25316, 25346);

                            TypeAttributes
                            typeAttributes
                            = default(TypeAttributes);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 25368, 25621) || true) && (!f_1527_25373_25431(exportedClasses, className, out typeAttributes) || (DynAbs.Tracing.TraceSender.Expression_False(1527, 25372, 25496) || typeAttributes != realTypeAttributes))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 25368, 25621);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 25546, 25566);

                                needToUpdate = true;
                                DynAbs.Tracing.TraceSender.TraceBreak(1527, 25592, 25598);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 25368, 25621);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 25114, 25640);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1527, 1, 527);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1527, 1, 527);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 25734, 25772);

                    moduleCacheEntry.TypesAnalyzed = true;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 25792, 25979) || true) && (!needToUpdate)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 25792, 25979);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 25851, 25931);

                        f_1527_25851_25930(ModuleIntrinsics.Tracer, "Existing cached info up-to-date. Skipping.");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 25953, 25960);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 25792, 25979);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 25999, 26024);

                    f_1527_25999_26023(
                                    exportedCommands);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 26042, 26066);

                    f_1527_26042_26065(exportedClasses);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 24256, 26857);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 24256, 26857);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 26132, 26263);

                    exportedCommands = f_1527_26151_26262(3, f_1527_26201_26227(realExportedCommands), f_1527_26229_26261());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 26281, 26412);

                    exportedClasses = f_1527_26299_26411(1, f_1527_26351_26376(realExportedClasses), f_1527_26378_26410());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 26430, 26745);

                    moduleCacheEntry = new ModuleCacheEntry
                    {
                        ModulePath = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1527_26523_26534(module), 1527, 26449, 26744),
                        LastWriteTime = lastWriteTime,
                        Commands = exportedCommands,
                        TypesAnalyzed = true,
                        Types = exportedClasses
                    };
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 26763, 26842);

                    moduleCacheEntry = f_1527_26782_26841(f_1527_26782_26801(s_cacheData), f_1527_26811_26822(module), moduleCacheEntry);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 24256, 26857);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 26917, 27200);
                    foreach (var exportedCommand in f_1527_26949_26976_I(f_1527_26949_26976(realExportedCommands)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 26917, 27200);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 27010, 27090);

                        f_1527_27010_27089(ModuleIntrinsics.Tracer, "Caching command: {0}", f_1527_27068_27088(exportedCommand));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 27108, 27185);

                        f_1527_27108_27184(exportedCommands, f_1527_27134_27154(exportedCommand), f_1527_27156_27183(exportedCommand));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 26917, 27200);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1527, 1, 284);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1527, 1, 284);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 27216, 27521);
                    foreach (var pair in f_1527_27237_27256_I(realExportedClasses))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 27216, 27521);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 27290, 27315);

                        var
                        className = pair.Key
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 27333, 27402);

                        f_1527_27333_27401(ModuleIntrinsics.Tracer, "Caching command: {0}", className);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 27420, 27506);

                        f_1527_27420_27505(moduleCacheEntry.Types, className, f_1527_27466_27491(pair.Value), (k, t) => t);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 27216, 27521);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1527, 1, 306);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1527, 1, 306);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 27537, 27570);

                f_1527_27537_27569(
                            s_cacheData);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1527, 22891, 27581);

                string
                f_1527_23065_23076(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 23065, 23076);
                    return return_v;
                }


                int
                f_1527_23002_23077(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 23002, 23077);
                    return 0;
                }


                bool
                f_1527_23271_23339(System.Management.Automation.Configuration.PowerShellConfig
                this_param)
                {
                    var return_v = this_param.IsImplicitWinCompatEnabled();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 23271, 23339);
                    return return_v;
                }


                bool
                f_1527_23343_23380_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 23343, 23380);
                    return return_v;
                }


                string
                f_1527_23459_23470(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 23459, 23470);
                    return return_v;
                }


                int
                f_1527_23414_23513(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 23414, 23513);
                    return 0;
                }


                string
                f_1527_23679_23690(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 23679, 23690);
                    return return_v;
                }


                bool
                f_1527_23655_23732(string
                modulePath, out System.DateTime
                lastWriteTime, out System.Management.Automation.ModuleCacheEntry
                moduleCacheEntry)
                {
                    var return_v = GetModuleEntryFromCache(modulePath, out lastWriteTime, out moduleCacheEntry);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 23655, 23732);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.CommandInfo>
                f_1527_23776_23799(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.ExportedCommands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 23776, 23799);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyDictionary<string, System.Management.Automation.Language.TypeDefinitionAst>
                f_1527_23840_23875(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.GetExportedTypeDefinitions();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 23840, 23875);
                    return return_v;
                }


                System.Management.Automation.CommandTypes
                f_1527_24702_24724(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.CommandType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 24702, 24724);
                    return return_v;
                }


                bool
                f_1527_24799_24857(System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.CommandTypes>
                this_param, string
                key, out System.Management.Automation.CommandTypes
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 24799, 24857);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.CommandInfo>
                f_1527_24569_24589_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.CommandInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 24569, 24589);
                    return return_v;
                }


                System.Management.Automation.Language.TypeAttributes
                f_1527_25268_25293(System.Management.Automation.Language.TypeDefinitionAst
                this_param)
                {
                    var return_v = this_param.TypeAttributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 25268, 25293);
                    return return_v;
                }


                bool
                f_1527_25373_25431(System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.Language.TypeAttributes>
                this_param, string
                key, out System.Management.Automation.Language.TypeAttributes
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 25373, 25431);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyDictionary<string, System.Management.Automation.Language.TypeDefinitionAst>
                f_1527_25135_25154_I(System.Collections.ObjectModel.ReadOnlyDictionary<string, System.Management.Automation.Language.TypeDefinitionAst>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 25135, 25154);
                    return return_v;
                }


                int
                f_1527_25851_25930(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 25851, 25930);
                    return 0;
                }


                int
                f_1527_25999_26023(System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.CommandTypes>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 25999, 26023);
                    return 0;
                }


                int
                f_1527_26042_26065(System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.Language.TypeAttributes>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 26042, 26065);
                    return 0;
                }


                int
                f_1527_26201_26227(System.Collections.Generic.Dictionary<string, System.Management.Automation.CommandInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 26201, 26227);
                    return return_v;
                }


                System.StringComparer
                f_1527_26229_26261()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 26229, 26261);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.CommandTypes>
                f_1527_26151_26262(int
                concurrencyLevel, int
                capacity, System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.CommandTypes>(concurrencyLevel, capacity, (System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 26151, 26262);
                    return return_v;
                }


                int
                f_1527_26351_26376(System.Collections.ObjectModel.ReadOnlyDictionary<string, System.Management.Automation.Language.TypeDefinitionAst>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 26351, 26376);
                    return return_v;
                }


                System.StringComparer
                f_1527_26378_26410()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 26378, 26410);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.Language.TypeAttributes>
                f_1527_26299_26411(int
                concurrencyLevel, int
                capacity, System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.Language.TypeAttributes>(concurrencyLevel, capacity, (System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 26299, 26411);
                    return return_v;
                }


                string
                f_1527_26523_26534(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 26523, 26534);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.ModuleCacheEntry>
                f_1527_26782_26801(System.Management.Automation.AnalysisCacheData
                this_param)
                {
                    var return_v = this_param.Entries;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 26782, 26801);
                    return return_v;
                }


                string
                f_1527_26811_26822(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 26811, 26822);
                    return return_v;
                }


                System.Management.Automation.ModuleCacheEntry
                f_1527_26782_26841(System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.ModuleCacheEntry>
                this_param, string
                key, System.Management.Automation.ModuleCacheEntry
                value)
                {
                    var return_v = this_param.GetOrAdd(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 26782, 26841);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.CommandInfo>.ValueCollection
                f_1527_26949_26976(System.Collections.Generic.Dictionary<string, System.Management.Automation.CommandInfo>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 26949, 26976);
                    return return_v;
                }


                string
                f_1527_27068_27088(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 27068, 27088);
                    return return_v;
                }


                int
                f_1527_27010_27089(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 27010, 27089);
                    return 0;
                }


                string
                f_1527_27134_27154(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 27134, 27154);
                    return return_v;
                }


                System.Management.Automation.CommandTypes
                f_1527_27156_27183(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.CommandType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 27156, 27183);
                    return return_v;
                }


                System.Management.Automation.CommandTypes
                f_1527_27108_27184(System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.CommandTypes>
                this_param, string
                key, System.Management.Automation.CommandTypes
                value)
                {
                    var return_v = this_param.GetOrAdd(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 27108, 27184);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.CommandInfo>.ValueCollection
                f_1527_26949_26976_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.CommandInfo>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 26949, 26976);
                    return return_v;
                }


                int
                f_1527_27333_27401(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 27333, 27401);
                    return 0;
                }


                System.Management.Automation.Language.TypeAttributes
                f_1527_27466_27491(System.Management.Automation.Language.TypeDefinitionAst
                this_param)
                {
                    var return_v = this_param.TypeAttributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 27466, 27491);
                    return return_v;
                }


                System.Management.Automation.Language.TypeAttributes
                f_1527_27420_27505(System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.Language.TypeAttributes>
                this_param, string
                key, System.Management.Automation.Language.TypeAttributes
                addValue, System.Func<string, System.Management.Automation.Language.TypeAttributes, System.Management.Automation.Language.TypeAttributes>
                updateValueFactory)
                {
                    var return_v = this_param.AddOrUpdate(key, addValue, updateValueFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 27420, 27505);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyDictionary<string, System.Management.Automation.Language.TypeDefinitionAst>
                f_1527_27237_27256_I(System.Collections.ObjectModel.ReadOnlyDictionary<string, System.Management.Automation.Language.TypeDefinitionAst>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 27237, 27256);
                    return return_v;
                }


                int
                f_1527_27537_27569(System.Management.Automation.AnalysisCacheData
                this_param)
                {
                    this_param.QueueSerialization();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 27537, 27569);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1527, 22891, 27581);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1527, 22891, 27581);
            }
        }

        private static void CallGetModuleDashList(ExecutionContext context, string modulePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1527, 27593, 28772);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 27704, 27806);

                CommandInfo
                commandInfo = f_1527_27730_27805("Get-Module", typeof(GetModuleCommand), null, null, context)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 27820, 27872);

                Command
                getModuleCommand = f_1527_27847_27871(commandInfo)
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 27924, 28523);

                    f_1527_27924_28522(f_1527_27924_28491(f_1527_27924_28432(f_1527_27924_28377(f_1527_27924_28320(f_1527_27924_28235(f_1527_27924_28154(f_1527_27924_28075(f_1527_27924_28022(f_1527_27924_27971(RunspaceMode.CurrentRunspace), getModuleCommand), "List", true), "ErrorAction", ActionPreference.Ignore), "WarningAction", ActionPreference.Ignore), "InformationAction", ActionPreference.Ignore), "Verbose", false), "Debug", false), "Name", modulePath));
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1527, 28552, 28761);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 28604, 28688);

                    f_1527_28604_28687(ModuleIntrinsics.Tracer, "Module analysis generated an exception: {0}", e);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1527, 28552, 28761);

                    // Catch-all OK, third-party call-out.
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1527, 27593, 28772);

                System.Management.Automation.CmdletInfo
                f_1527_27730_27805(string
                name, System.Type
                implementingType, string
                helpFile, System.Management.Automation.PSSnapInInfo
                PSSnapin, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new System.Management.Automation.CmdletInfo(name, implementingType, helpFile, PSSnapin, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 27730, 27805);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Command
                f_1527_27847_27871(System.Management.Automation.CommandInfo
                commandInfo)
                {
                    var return_v = new System.Management.Automation.Runspaces.Command(commandInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 27847, 27871);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1527_27924_27971(System.Management.Automation.RunspaceMode
                runspace)
                {
                    var return_v = PowerShell.Create(runspace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 27924, 27971);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1527_27924_28022(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.Runspaces.Command
                command)
                {
                    var return_v = this_param.AddCommand(command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 27924, 28022);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1527_27924_28075(System.Management.Automation.PowerShell
                this_param, string
                parameterName, bool
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 27924, 28075);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1527_27924_28154(System.Management.Automation.PowerShell
                this_param, string
                parameterName, System.Management.Automation.ActionPreference
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 27924, 28154);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1527_27924_28235(System.Management.Automation.PowerShell
                this_param, string
                parameterName, System.Management.Automation.ActionPreference
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 27924, 28235);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1527_27924_28320(System.Management.Automation.PowerShell
                this_param, string
                parameterName, System.Management.Automation.ActionPreference
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 27924, 28320);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1527_27924_28377(System.Management.Automation.PowerShell
                this_param, string
                parameterName, bool
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 27924, 28377);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1527_27924_28432(System.Management.Automation.PowerShell
                this_param, string
                parameterName, bool
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 27924, 28432);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1527_27924_28491(System.Management.Automation.PowerShell
                this_param, string
                parameterName, string
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 27924, 28491);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1527_27924_28522(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Invoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 27924, 28522);
                    return return_v;
                }


                int
                f_1527_28604_28687(System.Management.Automation.PSTraceSource
                this_param, string
                format, System.Exception
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 28604, 28687);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1527, 27593, 28772);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1527, 27593, 28772);
            }
        }

        private static bool GetModuleEntryFromCache(string modulePath, out DateTime lastWriteTime, out ModuleCacheEntry moduleCacheEntry)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1527, 28784, 29911);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 28974, 29029);

                    lastWriteTime = f_1527_28990_29028(f_1527_28990_29014(modulePath));
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1527, 29058, 29289);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 29110, 29222);

                    f_1527_29110_29221(ModuleIntrinsics.Tracer, "Exception checking LastWriteTime on module {0}: {1}", modulePath, f_1527_29211_29220(e));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 29240, 29274);

                    lastWriteTime = DateTime.MinValue;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1527, 29058, 29289);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 29305, 29833) || true) && (f_1527_29309_29374(f_1527_29309_29328(s_cacheData), modulePath, out moduleCacheEntry))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 29305, 29833);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 29408, 29532) || true) && (lastWriteTime == moduleCacheEntry.LastWriteTime)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 29408, 29532);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 29501, 29513);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 29408, 29532);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 29552, 29734);

                    f_1527_29552_29733(
                                    ModuleIntrinsics.Tracer, "{0}: cache entry out of date, cached on {1}, last updated on {2}", modulePath, moduleCacheEntry.LastWriteTime, lastWriteTime);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 29754, 29818);

                    f_1527_29754_29817(f_1527_29754_29773(s_cacheData), modulePath, out moduleCacheEntry);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 29305, 29833);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 29849, 29873);

                moduleCacheEntry = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 29887, 29900);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1527, 28784, 29911);

                System.IO.FileInfo
                f_1527_28990_29014(string
                fileName)
                {
                    var return_v = new System.IO.FileInfo(fileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 28990, 29014);
                    return return_v;
                }


                System.DateTime
                f_1527_28990_29028(System.IO.FileInfo
                this_param)
                {
                    var return_v = this_param.LastWriteTime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 28990, 29028);
                    return return_v;
                }


                string
                f_1527_29211_29220(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 29211, 29220);
                    return return_v;
                }


                int
                f_1527_29110_29221(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1, string
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 29110, 29221);
                    return 0;
                }


                System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.ModuleCacheEntry>
                f_1527_29309_29328(System.Management.Automation.AnalysisCacheData
                this_param)
                {
                    var return_v = this_param.Entries;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 29309, 29328);
                    return return_v;
                }


                bool
                f_1527_29309_29374(System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.ModuleCacheEntry>
                this_param, string
                key, out System.Management.Automation.ModuleCacheEntry
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 29309, 29374);
                    return return_v;
                }


                int
                f_1527_29552_29733(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1, System.DateTime
                arg2, System.DateTime
                arg3)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2, (object)arg3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 29552, 29733);
                    return 0;
                }


                System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.ModuleCacheEntry>
                f_1527_29754_29773(System.Management.Automation.AnalysisCacheData
                this_param)
                {
                    var return_v = this_param.Entries;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 29754, 29773);
                    return return_v;
                }


                bool
                f_1527_29754_29817(System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.ModuleCacheEntry>
                this_param, string
                key, out System.Management.Automation.ModuleCacheEntry
                value)
                {
                    var return_v = this_param.TryRemove(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 29754, 29817);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1527, 28784, 29911);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1527, 28784, 29911);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public AnalysisCache()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1527, 1134, 29918);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1527, 1134, 29918);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1527, 1134, 29918);
        }


        static AnalysisCache()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1527, 1134, 29918);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 1212, 1249);
            s_cacheData = f_1527_1226_1249();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 1398, 1544);
            s_modulesBeingAnalyzed = f_1527_1436_1544(1, 2, f_1527_1511_1543());
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 1580, 1805);
            InvalidCommandNameCharacters = new[]
                    {
            '#', ',', '(', ')', '{', '}', '[', ']', '&', '/', '\\', '$', '^', ';', ':',
            '"', '\'', '<', '>', '|', '?', '@', '`', '*', '%', '+', '=', '~'
        };
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1527, 1134, 29918);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1527, 1134, 29918);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1527, 1134, 29918);

        static System.Management.Automation.AnalysisCacheData
        f_1527_1226_1249()
        {
            var return_v = AnalysisCacheData.Get();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 1226, 1249);
            return return_v;
        }


        static System.StringComparer
        f_1527_1511_1543()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 1511, 1543);
            return return_v;
        }


        static System.Collections.Concurrent.ConcurrentDictionary<string, string>
        f_1527_1436_1544(int
        concurrencyLevel, int
        capacity, System.StringComparer
        comparer)
        {
            var return_v = new System.Collections.Concurrent.ConcurrentDictionary<string, string>(concurrencyLevel, capacity, (System.Collections.Generic.IEqualityComparer<string>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 1436, 1544);
            return return_v;
        }

    }
    internal class AnalysisCacheData
    {
        private static byte[] GetHeader()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1527, 29975, 30239);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 30033, 30228);

                return new byte[]
                            {
                0x50, 0x53, 0x4d, 0x4f, 0x44, 0x55, 0x4c, 0x45, 0x43, 0x41, 0x43, 0x48, 0x45, // PSMODULECACHE
                0x01 // version #
                            };
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1527, 29975, 30239);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1527, 29975, 30239);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1527, 29975, 30239);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public DateTime LastReadTime { get; set; }

        public ConcurrentDictionary<string, ModuleCacheEntry> Entries { get; set; }

        private int _saveCacheToDiskQueued;

        private bool _saveCacheToDisk;

        public void QueueSerialization()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1527, 30540, 32034);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 30990, 32023) || true) && (_saveCacheToDisk && (DynAbs.Tracing.TraceSender.Expression_True(1527, 30994, 31068) && f_1527_31014_31063(ref _saveCacheToDiskQueued) == 1))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 30990, 32023);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 31469, 31492);

                    int
                    counter1
                    = default(int),
                    counter2
                    = default(int);
                    {
                        try
                        {
                            do

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 31514, 31931);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 31711, 31745);

                                counter1 = _saveCacheToDiskQueued;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 31844, 31878);

                                counter2 = _saveCacheToDiskQueued;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 31514, 31931);
                            }
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 31514, 31931) || true) && (counter1 != counter2)
                            );
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1527, 31514, 31931);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1527, 31514, 31931);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 31953, 31985);

                    f_1527_31953_31984(this, s_cacheStoreLocation);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 30990, 32023);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1527, 30540, 32034);

                int
                f_1527_31014_31063(ref int
                location)
                {
                    var return_v = Interlocked.Increment(ref location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 31014, 31063);
                    return return_v;
                }


                int
                f_1527_31953_31984(System.Management.Automation.AnalysisCacheData
                this_param, string
                filename)
                {
                    this_param.Serialize(filename);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 31953, 31984);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1527, 30540, 32034);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1527, 30540, 32034);
            }
        }

        private void Cleanup()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1527, 32184, 32842);
                System.Management.Automation.ModuleCacheEntry _ = default(System.Management.Automation.ModuleCacheEntry);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 32231, 32405);

                f_1527_32231_32404(f_1527_32250_32323("PSDisableModuleAnalysisCacheCleanup") == null, "Caller to check environment variable before calling");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 32421, 32451);

                bool
                removedSomething = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 32465, 32489);

                var
                keys = f_1527_32476_32488(f_1527_32476_32483())
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 32503, 32725);
                    foreach (var key in f_1527_32523_32527_I(keys))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 32503, 32725);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 32561, 32710) || true) && (!f_1527_32566_32582(key))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 32561, 32710);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 32624, 32691);

                            removedSomething |= f_1527_32644_32690(f_1527_32644_32651(), key, out _);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 32561, 32710);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 32503, 32725);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1527, 1, 223);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1527, 1, 223);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 32741, 32831) || true) && (removedSomething)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 32741, 32831);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 32795, 32816);

                    f_1527_32795_32815(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 32741, 32831);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1527, 32184, 32842);

                string?
                f_1527_32250_32323(string
                variable)
                {
                    var return_v = Environment.GetEnvironmentVariable(variable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 32250, 32323);
                    return return_v;
                }


                int
                f_1527_32231_32404(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 32231, 32404);
                    return 0;
                }


                System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.ModuleCacheEntry>
                f_1527_32476_32483()
                {
                    var return_v = Entries;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 32476, 32483);
                    return return_v;
                }


                System.Collections.Generic.ICollection<string>
                f_1527_32476_32488(System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.ModuleCacheEntry>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 32476, 32488);
                    return return_v;
                }


                bool
                f_1527_32566_32582(string
                path)
                {
                    var return_v = File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 32566, 32582);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.ModuleCacheEntry>
                f_1527_32644_32651()
                {
                    var return_v = Entries;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 32644, 32651);
                    return return_v;
                }


                bool
                f_1527_32644_32690(System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.ModuleCacheEntry>
                this_param, string
                key, out System.Management.Automation.ModuleCacheEntry
                value)
                {
                    var return_v = this_param.TryRemove(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 32644, 32690);
                    return return_v;
                }


                System.Collections.Generic.ICollection<string>
                f_1527_32523_32527_I(System.Collections.Generic.ICollection<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 32523, 32527);
                    return return_v;
                }


                int
                f_1527_32795_32815(System.Management.Automation.AnalysisCacheData
                this_param)
                {
                    this_param.QueueSerialization();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 32795, 32815);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1527, 32184, 32842);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1527, 32184, 32842);
            }
        }

        private static unsafe void Write(int val, byte[] bytes, FileStream stream)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1527, 32854, 33136);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 32953, 33030);

                f_1527_32953_33029(f_1527_32972_32984(bytes) >= 4, "Must pass a large enough byte array");
                fixed (byte*
    b = bytes
    )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 33068, 33085);

                    *((int*)b) = val;
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 33099, 33125);

                f_1527_33099_33124(stream, bytes, 0, 4);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1527, 32854, 33136);

                int
                f_1527_32972_32984(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 32972, 32984);
                    return return_v;
                }


                int
                f_1527_32953_33029(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 32953, 33029);
                    return 0;
                }


                int
                f_1527_33099_33124(System.IO.FileStream
                this_param, byte[]
                array, int
                offset, int
                count)
                {
                    this_param.Write(array, offset, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 33099, 33124);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1527, 32854, 33136);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1527, 32854, 33136);
            }
        }

        private static unsafe void Write(long val, byte[] bytes, FileStream stream)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1527, 33148, 33432);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 33248, 33325);

                f_1527_33248_33324(f_1527_33267_33279(bytes) >= 8, "Must pass a large enough byte array");
                fixed (byte*
    b = bytes
    )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 33363, 33381);

                    *((long*)b) = val;
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 33395, 33421);

                f_1527_33395_33420(stream, bytes, 0, 8);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1527, 33148, 33432);

                int
                f_1527_33267_33279(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 33267, 33279);
                    return return_v;
                }


                int
                f_1527_33248_33324(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 33248, 33324);
                    return 0;
                }


                int
                f_1527_33395_33420(System.IO.FileStream
                this_param, byte[]
                array, int
                offset, int
                count)
                {
                    this_param.Write(array, offset, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 33395, 33420);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1527, 33148, 33432);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1527, 33148, 33432);
            }
        }

        private static void Write(string val, byte[] bytes, FileStream stream)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1527, 33444, 33684);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 33539, 33572);

                f_1527_33539_33571(f_1527_33545_33555(val), bytes, stream);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 33586, 33622);

                bytes = f_1527_33594_33621(f_1527_33594_33607(), val);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 33636, 33673);

                f_1527_33636_33672(stream, bytes, 0, f_1527_33659_33671(bytes));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1527, 33444, 33684);

                int
                f_1527_33545_33555(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 33545, 33555);
                    return return_v;
                }


                int
                f_1527_33539_33571(int
                val, byte[]
                bytes, System.IO.FileStream
                stream)
                {
                    Write(val, bytes, stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 33539, 33571);
                    return 0;
                }


                System.Text.Encoding
                f_1527_33594_33607()
                {
                    var return_v = Encoding.UTF8;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 33594, 33607);
                    return return_v;
                }


                byte[]
                f_1527_33594_33621(System.Text.Encoding
                this_param, string
                s)
                {
                    var return_v = this_param.GetBytes(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 33594, 33621);
                    return return_v;
                }


                int
                f_1527_33659_33671(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 33659, 33671);
                    return return_v;
                }


                int
                f_1527_33636_33672(System.IO.FileStream
                this_param, byte[]
                array, int
                offset, int
                count)
                {
                    this_param.Write(array, offset, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 33636, 33672);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1527, 33444, 33684);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1527, 33444, 33684);
            }
        }

        private void Serialize(string filename)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1527, 33696, 39618);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 33760, 33802);

                AnalysisCacheData
                fromOtherProcess = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 33816, 33957);

                f_1527_33816_33956(_saveCacheToDisk != false, "Serialize should never be called without going through QueueSerialization which has a check");

                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 34009, 35047) || true) && (f_1527_34013_34034(filename))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 34009, 35047);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 34076, 34137);

                        var
                        fileLastWriteTime = f_1527_34100_34136(f_1527_34100_34122(filename))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 34159, 34314) || true) && (fileLastWriteTime > f_1527_34183_34200(this))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 34159, 34314);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 34250, 34291);

                            fromOtherProcess = f_1527_34269_34290(filename);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 34159, 34314);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 34009, 35047);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 34009, 35047);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 34448, 34493);

                        var
                        folder = f_1527_34461_34492(filename)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 34515, 35028) || true) && (!f_1527_34520_34544(folder))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 34515, 35028);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 34654, 34688);

                                f_1527_34654_34687(folder);
                            }
                            catch (UnauthorizedAccessException)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1527, 34741, 35005);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 34916, 34941);

                                _saveCacheToDisk = false;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 34971, 34978);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1527, 34741, 35005);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 34515, 35028);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 34009, 35047);
                    }
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1527, 35076, 35252);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 35128, 35237);

                    f_1527_35128_35236(ModuleIntrinsics.Tracer, "Exception checking module analysis cache {0}: {1} ", filename, f_1527_35226_35235(e));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1527, 35076, 35252);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 35268, 36254) || true) && (fromOtherProcess != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 35268, 36254);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 35434, 36239);
                        foreach (var otherEntryPair in f_1527_35465_35489_I(f_1527_35465_35489(fromOtherProcess)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 35434, 36239);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 35531, 35572);

                            var
                            otherModuleName = otherEntryPair.Key
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 35594, 35632);

                            var
                            otherEntry = otherEntryPair.Value
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 35654, 35681);

                            ModuleCacheEntry
                            thisEntry
                            = default(ModuleCacheEntry);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 35703, 36220) || true) && (f_1527_35707_35758(f_1527_35707_35714(), otherModuleName, out thisEntry))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 35703, 36220);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 35808, 36061) || true) && (otherEntry.LastWriteTime > thisEntry.LastWriteTime)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 35808, 36061);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 35996, 36034);

                                    f_1527_35996_36003()[otherModuleName] = otherEntry;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 35808, 36061);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 35703, 36220);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 35703, 36220);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 36159, 36197);

                                f_1527_36159_36166()[otherModuleName] = otherEntry;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 35703, 36220);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 35434, 36239);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1527, 1, 806);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1527, 1, 806);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 35268, 36254);
                }

                // "PSMODULECACHE"     -> 13 bytes
                // byte     ( 1 byte)  -> version
                // int      ( 4 bytes) -> count of entries
                // entries  (?? bytes) -> all entries
                //
                // each entry is
                //   DateTime ( 8 bytes) -> last write time for module file
                //   int      ( 4 bytes) -> path length
                //   string   (?? bytes) -> utf8 encoded path
                //   int      ( 4 bytes) -> count of commands
                //   commands (?? bytes) -> all commands
                //   int      ( 4 bytes) -> count of types, -1 means unanalyzed (and 0 items serialized)
                //   types    (?? bytes) -> all types
                //
                // each command is
                //   int      ( 4 bytes) -> command name length
                //   string   (?? bytes) -> utf8 encoded command name
                //   int      ( 4 bytes) -> CommandTypes enum
                //
                // each type is
                //   int     ( 4 bytes) -> type name length
                //   string  (?? bytes) -> utf8 encoded type name
                //   int     ( 4 bytes) -> type attributes
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 37461, 37485);

                    var
                    bytes = new byte[8]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 37505, 39100);
                    using (var
                    stream = f_1527_37525_37546(filename)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 37588, 37618);

                        var
                        headerBytes = f_1527_37606_37617()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 37640, 37689);

                        f_1527_37640_37688(stream, headerBytes, 0, f_1527_37669_37687(headerBytes));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 37754, 37790);

                        f_1527_37754_37789(f_1527_37760_37773(f_1527_37760_37767()), bytes, stream);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 37814, 39081);
                            foreach (var pair in f_1527_37835_37852_I(f_1527_37835_37852(f_1527_37835_37842())))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 37814, 39081);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 37902, 37922);

                                var
                                path = pair.Key
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 37948, 37971);

                                var
                                entry = pair.Value
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 38050, 38098);

                                f_1527_38050_38097(entry.LastWriteTime.Ticks, bytes, stream);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 38166, 38193);

                                f_1527_38166_38192(path, bytes, stream);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 38258, 38302);

                                var
                                commandPairs = f_1527_38277_38301(entry.Commands)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 38328, 38370);

                                f_1527_38328_38369(f_1527_38334_38353(commandPairs), bytes, stream);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 38398, 38624);
                                    foreach (var command in f_1527_38422_38434_I(commandPairs))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 38398, 38624);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 38492, 38526);

                                        f_1527_38492_38525(command.Key, bytes, stream);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 38556, 38597);

                                        f_1527_38556_38596(command.Value, bytes, stream);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 38398, 38624);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1527, 1, 227);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1527, 1, 227);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 38686, 38724);

                                var
                                typePairs = f_1527_38702_38723(entry.Types)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 38750, 38816);

                                f_1527_38750_38815((DynAbs.Tracing.TraceSender.Conditional_F1(1527, 38756, 38775) || ((entry.TypesAnalyzed && DynAbs.Tracing.TraceSender.Conditional_F2(1527, 38778, 38794)) || DynAbs.Tracing.TraceSender.Conditional_F3(1527, 38797, 38799))) ? f_1527_38778_38794(typePairs) : -1, bytes, stream);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 38844, 39058);
                                    foreach (var type in f_1527_38865_38874_I(typePairs))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 38844, 39058);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 38932, 38963);

                                        f_1527_38932_38962(type.Key, bytes, stream);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 38993, 39031);

                                        f_1527_38993_39030(type.Value, bytes, stream);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 38844, 39058);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1527, 1, 215);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1527, 1, 215);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 37814, 39081);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1527, 1, 1268);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1527, 1, 1268);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitUsing(1527, 37505, 39100);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 39217, 39269);

                    LastReadTime = f_1527_39232_39268(f_1527_39232_39254(filename));
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1527, 39298, 39473);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 39350, 39458);

                    f_1527_39350_39457(ModuleIntrinsics.Tracer, "Exception writing module analysis cache {0}: {1} ", filename, f_1527_39447_39456(e));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1527, 39298, 39473);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 39555, 39607);

                f_1527_39555_39606(ref _saveCacheToDiskQueued, 0);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1527, 33696, 39618);

                int
                f_1527_33816_33956(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 33816, 33956);
                    return 0;
                }


                bool
                f_1527_34013_34034(string
                path)
                {
                    var return_v = File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 34013, 34034);
                    return return_v;
                }


                System.IO.FileInfo
                f_1527_34100_34122(string
                fileName)
                {
                    var return_v = new System.IO.FileInfo(fileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 34100, 34122);
                    return return_v;
                }


                System.DateTime
                f_1527_34100_34136(System.IO.FileInfo
                this_param)
                {
                    var return_v = this_param.LastWriteTime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 34100, 34136);
                    return return_v;
                }


                System.DateTime
                f_1527_34183_34200(System.Management.Automation.AnalysisCacheData
                this_param)
                {
                    var return_v = this_param.LastReadTime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 34183, 34200);
                    return return_v;
                }


                System.Management.Automation.AnalysisCacheData
                f_1527_34269_34290(string
                filename)
                {
                    var return_v = Deserialize(filename);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 34269, 34290);
                    return return_v;
                }


                string?
                f_1527_34461_34492(string
                path)
                {
                    var return_v = Path.GetDirectoryName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 34461, 34492);
                    return return_v;
                }


                bool
                f_1527_34520_34544(string
                path)
                {
                    var return_v = Directory.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 34520, 34544);
                    return return_v;
                }


                System.IO.DirectoryInfo
                f_1527_34654_34687(string
                path)
                {
                    var return_v = Directory.CreateDirectory(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 34654, 34687);
                    return return_v;
                }


                string
                f_1527_35226_35235(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 35226, 35235);
                    return return_v;
                }


                int
                f_1527_35128_35236(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1, string
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 35128, 35236);
                    return 0;
                }


                System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.ModuleCacheEntry>
                f_1527_35465_35489(System.Management.Automation.AnalysisCacheData
                this_param)
                {
                    var return_v = this_param.Entries;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 35465, 35489);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.ModuleCacheEntry>
                f_1527_35707_35714()
                {
                    var return_v = Entries;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 35707, 35714);
                    return return_v;
                }


                bool
                f_1527_35707_35758(System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.ModuleCacheEntry>
                this_param, string
                key, out System.Management.Automation.ModuleCacheEntry
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 35707, 35758);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.ModuleCacheEntry>
                f_1527_35996_36003()
                {
                    var return_v = Entries;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 35996, 36003);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.ModuleCacheEntry>
                f_1527_36159_36166()
                {
                    var return_v = Entries;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 36159, 36166);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.ModuleCacheEntry>
                f_1527_35465_35489_I(System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.ModuleCacheEntry>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 35465, 35489);
                    return return_v;
                }


                System.IO.FileStream
                f_1527_37525_37546(string
                path)
                {
                    var return_v = File.Create(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 37525, 37546);
                    return return_v;
                }


                byte[]
                f_1527_37606_37617()
                {
                    var return_v = GetHeader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 37606, 37617);
                    return return_v;
                }


                int
                f_1527_37669_37687(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 37669, 37687);
                    return return_v;
                }


                int
                f_1527_37640_37688(System.IO.FileStream
                this_param, byte[]
                array, int
                offset, int
                count)
                {
                    this_param.Write(array, offset, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 37640, 37688);
                    return 0;
                }


                System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.ModuleCacheEntry>
                f_1527_37760_37767()
                {
                    var return_v = Entries;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 37760, 37767);
                    return return_v;
                }


                int
                f_1527_37760_37773(System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.ModuleCacheEntry>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 37760, 37773);
                    return return_v;
                }


                int
                f_1527_37754_37789(int
                val, byte[]
                bytes, System.IO.FileStream
                stream)
                {
                    Write(val, bytes, stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 37754, 37789);
                    return 0;
                }


                System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.ModuleCacheEntry>
                f_1527_37835_37842()
                {
                    var return_v = Entries;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 37835, 37842);
                    return return_v;
                }


                System.Collections.Generic.KeyValuePair<string, System.Management.Automation.ModuleCacheEntry>[]
                f_1527_37835_37852(System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.ModuleCacheEntry>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 37835, 37852);
                    return return_v;
                }


                int
                f_1527_38050_38097(long
                val, byte[]
                bytes, System.IO.FileStream
                stream)
                {
                    Write(val, bytes, stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 38050, 38097);
                    return 0;
                }


                int
                f_1527_38166_38192(string
                val, byte[]
                bytes, System.IO.FileStream
                stream)
                {
                    Write(val, bytes, stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 38166, 38192);
                    return 0;
                }


                System.Collections.Generic.KeyValuePair<string, System.Management.Automation.CommandTypes>[]
                f_1527_38277_38301(System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.CommandTypes>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 38277, 38301);
                    return return_v;
                }


                int
                f_1527_38334_38353(System.Collections.Generic.KeyValuePair<string, System.Management.Automation.CommandTypes>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 38334, 38353);
                    return return_v;
                }


                int
                f_1527_38328_38369(int
                val, byte[]
                bytes, System.IO.FileStream
                stream)
                {
                    Write(val, bytes, stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 38328, 38369);
                    return 0;
                }


                int
                f_1527_38492_38525(string
                val, byte[]
                bytes, System.IO.FileStream
                stream)
                {
                    Write(val, bytes, stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 38492, 38525);
                    return 0;
                }


                int
                f_1527_38556_38596(System.Management.Automation.CommandTypes
                val, byte[]
                bytes, System.IO.FileStream
                stream)
                {
                    Write((int)val, bytes, stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 38556, 38596);
                    return 0;
                }


                System.Collections.Generic.KeyValuePair<string, System.Management.Automation.CommandTypes>[]
                f_1527_38422_38434_I(System.Collections.Generic.KeyValuePair<string, System.Management.Automation.CommandTypes>[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 38422, 38434);
                    return return_v;
                }


                System.Collections.Generic.KeyValuePair<string, System.Management.Automation.Language.TypeAttributes>[]
                f_1527_38702_38723(System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.Language.TypeAttributes>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 38702, 38723);
                    return return_v;
                }


                int
                f_1527_38778_38794(System.Collections.Generic.KeyValuePair<string, System.Management.Automation.Language.TypeAttributes>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 38778, 38794);
                    return return_v;
                }


                int
                f_1527_38750_38815(int
                val, byte[]
                bytes, System.IO.FileStream
                stream)
                {
                    Write(val, bytes, stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 38750, 38815);
                    return 0;
                }


                int
                f_1527_38932_38962(string
                val, byte[]
                bytes, System.IO.FileStream
                stream)
                {
                    Write(val, bytes, stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 38932, 38962);
                    return 0;
                }


                int
                f_1527_38993_39030(System.Management.Automation.Language.TypeAttributes
                val, byte[]
                bytes, System.IO.FileStream
                stream)
                {
                    Write((int)val, bytes, stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 38993, 39030);
                    return 0;
                }


                System.Collections.Generic.KeyValuePair<string, System.Management.Automation.Language.TypeAttributes>[]
                f_1527_38865_38874_I(System.Collections.Generic.KeyValuePair<string, System.Management.Automation.Language.TypeAttributes>[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 38865, 38874);
                    return return_v;
                }


                System.Collections.Generic.KeyValuePair<string, System.Management.Automation.ModuleCacheEntry>[]
                f_1527_37835_37852_I(System.Collections.Generic.KeyValuePair<string, System.Management.Automation.ModuleCacheEntry>[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 37835, 37852);
                    return return_v;
                }


                System.IO.FileInfo
                f_1527_39232_39254(string
                fileName)
                {
                    var return_v = new System.IO.FileInfo(fileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 39232, 39254);
                    return return_v;
                }


                System.DateTime
                f_1527_39232_39268(System.IO.FileInfo
                this_param)
                {
                    var return_v = this_param.LastWriteTime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 39232, 39268);
                    return return_v;
                }


                string
                f_1527_39447_39456(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 39447, 39456);
                    return return_v;
                }


                int
                f_1527_39350_39457(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1, string
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 39350, 39457);
                    return 0;
                }


                int
                f_1527_39555_39606(ref int
                location1, int
                value)
                {
                    var return_v = Interlocked.Exchange(ref location1, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 39555, 39606);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1527, 33696, 39618);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1527, 33696, 39618);
            }
        }

        private const string
        TruncatedErrorMessage = "module cache file appears truncated"
        ;

        private const string
        InvalidSignatureErrorMessage = "module cache signature not valid"
        ;

        private const string
        PossibleCorruptionErrorMessage = "possible corruption in module cache"
        ;

        private static unsafe long ReadLong(FileStream stream, byte[] bytes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1527, 39924, 40286);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 40017, 40094);

                f_1527_40017_40093(f_1527_40036_40048(bytes) >= 8, "Must pass a large enough byte array");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 40108, 40203) || true) && (f_1527_40112_40136(stream, bytes, 0, 8) != 8)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 40108, 40203);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 40160, 40203);

                    throw f_1527_40166_40202(TruncatedErrorMessage);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 40108, 40203);
                }
                fixed (byte*
    b = bytes
    )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 40258, 40275);

                    return *(long*)b;
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1527, 39924, 40286);

                int
                f_1527_40036_40048(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 40036, 40048);
                    return return_v;
                }


                int
                f_1527_40017_40093(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 40017, 40093);
                    return 0;
                }


                int
                f_1527_40112_40136(System.IO.FileStream
                this_param, byte[]
                array, int
                offset, int
                count)
                {
                    var return_v = this_param.Read(array, offset, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 40112, 40136);
                    return return_v;
                }


                System.Exception
                f_1527_40166_40202(string
                message)
                {
                    var return_v = new System.Exception(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 40166, 40202);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1527, 39924, 40286);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1527, 39924, 40286);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static unsafe int ReadInt(FileStream stream, byte[] bytes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1527, 40298, 40657);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 40389, 40466);

                f_1527_40389_40465(f_1527_40408_40420(bytes) >= 4, "Must pass a large enough byte array");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 40480, 40575) || true) && (f_1527_40484_40508(stream, bytes, 0, 4) != 4)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 40480, 40575);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 40532, 40575);

                    throw f_1527_40538_40574(TruncatedErrorMessage);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 40480, 40575);
                }
                fixed (byte*
    b = bytes
    )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 40630, 40646);

                    return *(int*)b;
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1527, 40298, 40657);

                int
                f_1527_40408_40420(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 40408, 40420);
                    return return_v;
                }


                int
                f_1527_40389_40465(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 40389, 40465);
                    return 0;
                }


                int
                f_1527_40484_40508(System.IO.FileStream
                this_param, byte[]
                array, int
                offset, int
                count)
                {
                    var return_v = this_param.Read(array, offset, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 40484, 40508);
                    return return_v;
                }


                System.Exception
                f_1527_40538_40574(string
                message)
                {
                    var return_v = new System.Exception(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 40538, 40574);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1527, 40298, 40657);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1527, 40298, 40657);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string ReadString(FileStream stream, ref byte[] bytes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1527, 40669, 41182);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 40763, 40799);

                int
                length = f_1527_40776_40798(stream, bytes)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 40813, 40906) || true) && (length > 10 * 1024)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 40813, 40906);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 40854, 40906);

                    throw f_1527_40860_40905(PossibleCorruptionErrorMessage);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 40813, 40906);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 40920, 40989) || true) && (length > f_1527_40933_40945(bytes))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 40920, 40989);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 40964, 40989);

                    bytes = new byte[length];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 40920, 40989);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 41003, 41108) || true) && (f_1527_41007_41036(stream, bytes, 0, length) != length)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 41003, 41108);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 41065, 41108);

                    throw f_1527_41071_41107(TruncatedErrorMessage);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 41003, 41108);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 41122, 41171);

                return f_1527_41129_41170(f_1527_41129_41142(), bytes, 0, length);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1527, 40669, 41182);

                int
                f_1527_40776_40798(System.IO.FileStream
                stream, byte[]
                bytes)
                {
                    var return_v = ReadInt(stream, bytes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 40776, 40798);
                    return return_v;
                }


                System.Exception
                f_1527_40860_40905(string
                message)
                {
                    var return_v = new System.Exception(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 40860, 40905);
                    return return_v;
                }


                int
                f_1527_40933_40945(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 40933, 40945);
                    return return_v;
                }


                int
                f_1527_41007_41036(System.IO.FileStream
                this_param, byte[]
                array, int
                offset, int
                count)
                {
                    var return_v = this_param.Read(array, offset, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 41007, 41036);
                    return return_v;
                }


                System.Exception
                f_1527_41071_41107(string
                message)
                {
                    var return_v = new System.Exception(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 41071, 41107);
                    return return_v;
                }


                System.Text.Encoding
                f_1527_41129_41142()
                {
                    var return_v = Encoding.UTF8;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 41129, 41142);
                    return return_v;
                }


                string
                f_1527_41129_41170(System.Text.Encoding
                this_param, byte[]
                bytes, int
                index, int
                count)
                {
                    var return_v = this_param.GetString(bytes, index, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 41129, 41170);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1527, 40669, 41182);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1527, 40669, 41182);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void ReadHeader(FileStream stream, byte[] bytes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1527, 41194, 41918);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 41282, 41312);

                var
                headerBytes = f_1527_41300_41311()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 41326, 41358);

                var
                length = f_1527_41339_41357(headerBytes)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 41372, 41454);

                f_1527_41372_41453(f_1527_41391_41403(bytes) >= length, "must pass a large enough byte array");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 41468, 41573) || true) && (f_1527_41472_41501(stream, bytes, 0, length) != length)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 41468, 41573);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 41530, 41573);

                    throw f_1527_41536_41572(TruncatedErrorMessage);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 41468, 41573);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 41598, 41603);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 41589, 41810) || true) && (i < length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 41617, 41620)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 41589, 41810))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 41589, 41810);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 41654, 41795) || true) && (bytes[i] != headerBytes[i])
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 41654, 41795);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 41726, 41776);

                            throw f_1527_41732_41775(InvalidSignatureErrorMessage);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 41654, 41795);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1527, 1, 222);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1527, 1, 222);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1527, 41194, 41918);

                byte[]
                f_1527_41300_41311()
                {
                    var return_v = GetHeader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 41300, 41311);
                    return return_v;
                }


                int
                f_1527_41339_41357(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 41339, 41357);
                    return return_v;
                }


                int
                f_1527_41391_41403(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 41391, 41403);
                    return return_v;
                }


                int
                f_1527_41372_41453(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 41372, 41453);
                    return 0;
                }


                int
                f_1527_41472_41501(System.IO.FileStream
                this_param, byte[]
                array, int
                offset, int
                count)
                {
                    var return_v = this_param.Read(array, offset, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 41472, 41501);
                    return return_v;
                }


                System.Exception
                f_1527_41536_41572(string
                message)
                {
                    var return_v = new System.Exception(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 41536, 41572);
                    return return_v;
                }


                System.Exception
                f_1527_41732_41775(string
                message)
                {
                    var return_v = new System.Exception(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 41732, 41775);
                    return return_v;
                }

                // No need to return - we don't use it other than to detect the correct file format
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1527, 41194, 41918);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1527, 41194, 41918);
            }
        }

        public static AnalysisCacheData Deserialize(string filename)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1527, 41930, 46499);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 42015, 46488);
                using (var
                stream = f_1527_42035_42058(filename)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 42092, 42159);

                    var
                    result = new AnalysisCacheData { LastReadTime = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => DateTime.Now, 1527, 42105, 42158) }
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 42179, 42206);

                    var
                    bytes = new byte[1024]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 42356, 42382);

                    f_1527_42356_42381(stream, bytes);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 42462, 42499);

                    int
                    entries = f_1527_42476_42498(stream, bytes)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 42517, 42615) || true) && (entries > 20 * 1024)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 42517, 42615);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 42563, 42615);

                        throw f_1527_42569_42614(PossibleCorruptionErrorMessage);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 42517, 42615);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 42635, 42764);

                    result.Entries = f_1527_42652_42763(3, entries, f_1527_42730_42762());
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 42839, 46219) || true) && (entries > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 42839, 46219);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 42980, 43038);

                            var
                            lastWriteTime = f_1527_43000_43037(f_1527_43013_43036(stream, bytes))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 43190, 43231);

                            var
                            path = f_1527_43201_43230(stream, ref bytes)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 43322, 43362);

                            var
                            countItems = f_1527_43339_43361(stream, bytes)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 43384, 43489) || true) && (countItems > 20 * 1024)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 43384, 43489);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 43437, 43489);

                                throw f_1527_43443_43488(PossibleCorruptionErrorMessage);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 43384, 43489);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 43513, 43639);

                            var
                            commands = f_1527_43528_43638(3, countItems, f_1527_43605_43637())
                            ;
                            try
                            {
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 43725, 44449) || true) && (countItems > 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 43725, 44449);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 43948, 43996);

                                    var
                                    commandName = f_1527_43966_43995(stream, ref bytes)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 44095, 44151);

                                    var
                                    commandTypes = (CommandTypes)f_1527_44128_44150(stream, bytes)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 44271, 44382) || true) && (!f_1527_44276_44314(commandName))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 44271, 44382);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 44345, 44382);

                                        commands[commandName] = commandTypes;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 44271, 44382);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 44410, 44426);

                                    countItems -= 1;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 43725, 44449);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1527, 43725, 44449);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1527, 43725, 44449);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 44537, 44573);

                            countItems = f_1527_44550_44572(stream, bytes);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 44597, 44635);

                            bool
                            typesAnalyzed = countItems != -1
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 44657, 44717) || true) && (!typesAnalyzed)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 44657, 44717);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 44702, 44717);

                                countItems = 0;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 44657, 44717);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 44739, 44844) || true) && (countItems > 20 * 1024)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 44739, 44844);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 44792, 44844);

                                throw f_1527_44798_44843(PossibleCorruptionErrorMessage);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 44739, 44844);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 44868, 44978);

                            var
                            types = f_1527_44880_44977(1, countItems, f_1527_44944_44976())
                            ;
                            try
                            {
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 45061, 45768) || true) && (countItems > 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 45061, 45768);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 45276, 45321);

                                    var
                                    typeName = f_1527_45291_45320(stream, ref bytes)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 45417, 45477);

                                    var
                                    typeAttributes = (TypeAttributes)f_1527_45454_45476(stream, bytes)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 45597, 45701) || true) && (!f_1527_45602_45637(typeName))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 45597, 45701);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 45668, 45701);

                                        types[typeName] = typeAttributes;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 45597, 45701);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 45729, 45745);

                                    countItems -= 1;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 45061, 45768);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1527, 45061, 45768);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1527, 45061, 45768);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 45792, 46112);

                            var
                            entry = new ModuleCacheEntry
                            {
                                ModulePath = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => path, 1527, 45804, 46111),
                                LastWriteTime = lastWriteTime,
                                Commands = commands,
                                TypesAnalyzed = typesAnalyzed,
                                Types = types
                            }
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 46134, 46163);

                            f_1527_46134_46148(result)[path] = entry;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 46187, 46200);

                            entries -= 1;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 42839, 46219);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1527, 42839, 46219);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1527, 42839, 46219);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 46239, 46439) || true) && (f_1527_46243_46316("PSDisableModuleAnalysisCacheCleanup") == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 46239, 46439);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 46366, 46420);

                        f_1527_46366_46419(f_1527_46366_46383(10000), _ => result.Cleanup());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 46239, 46439);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 46459, 46473);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1527, 42015, 46488);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1527, 41930, 46499);

                System.IO.FileStream
                f_1527_42035_42058(string
                path)
                {
                    var return_v = File.OpenRead(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 42035, 42058);
                    return return_v;
                }


                int
                f_1527_42356_42381(System.IO.FileStream
                stream, byte[]
                bytes)
                {
                    ReadHeader(stream, bytes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 42356, 42381);
                    return 0;
                }


                int
                f_1527_42476_42498(System.IO.FileStream
                stream, byte[]
                bytes)
                {
                    var return_v = ReadInt(stream, bytes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 42476, 42498);
                    return return_v;
                }


                System.Exception
                f_1527_42569_42614(string
                message)
                {
                    var return_v = new System.Exception(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 42569, 42614);
                    return return_v;
                }


                System.StringComparer
                f_1527_42730_42762()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 42730, 42762);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.ModuleCacheEntry>
                f_1527_42652_42763(int
                concurrencyLevel, int
                capacity, System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.ModuleCacheEntry>(concurrencyLevel, capacity, (System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 42652, 42763);
                    return return_v;
                }


                long
                f_1527_43013_43036(System.IO.FileStream
                stream, byte[]
                bytes)
                {
                    var return_v = ReadLong(stream, bytes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 43013, 43036);
                    return return_v;
                }


                System.DateTime
                f_1527_43000_43037(long
                ticks)
                {
                    var return_v = new System.DateTime(ticks);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 43000, 43037);
                    return return_v;
                }


                string
                f_1527_43201_43230(System.IO.FileStream
                stream, ref byte[]
                bytes)
                {
                    var return_v = ReadString(stream, ref bytes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 43201, 43230);
                    return return_v;
                }


                int
                f_1527_43339_43361(System.IO.FileStream
                stream, byte[]
                bytes)
                {
                    var return_v = ReadInt(stream, bytes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 43339, 43361);
                    return return_v;
                }


                System.Exception
                f_1527_43443_43488(string
                message)
                {
                    var return_v = new System.Exception(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 43443, 43488);
                    return return_v;
                }


                System.StringComparer
                f_1527_43605_43637()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 43605, 43637);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.CommandTypes>
                f_1527_43528_43638(int
                concurrencyLevel, int
                capacity, System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.CommandTypes>(concurrencyLevel, capacity, (System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 43528, 43638);
                    return return_v;
                }


                string
                f_1527_43966_43995(System.IO.FileStream
                stream, ref byte[]
                bytes)
                {
                    var return_v = ReadString(stream, ref bytes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 43966, 43995);
                    return return_v;
                }


                int
                f_1527_44128_44150(System.IO.FileStream
                stream, byte[]
                bytes)
                {
                    var return_v = ReadInt(stream, bytes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 44128, 44150);
                    return return_v;
                }


                bool
                f_1527_44276_44314(string
                value)
                {
                    var return_v = string.IsNullOrWhiteSpace(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 44276, 44314);
                    return return_v;
                }


                int
                f_1527_44550_44572(System.IO.FileStream
                stream, byte[]
                bytes)
                {
                    var return_v = ReadInt(stream, bytes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 44550, 44572);
                    return return_v;
                }


                System.Exception
                f_1527_44798_44843(string
                message)
                {
                    var return_v = new System.Exception(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 44798, 44843);
                    return return_v;
                }


                System.StringComparer
                f_1527_44944_44976()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 44944, 44976);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.Language.TypeAttributes>
                f_1527_44880_44977(int
                concurrencyLevel, int
                capacity, System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.Language.TypeAttributes>(concurrencyLevel, capacity, (System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 44880, 44977);
                    return return_v;
                }


                string
                f_1527_45291_45320(System.IO.FileStream
                stream, ref byte[]
                bytes)
                {
                    var return_v = ReadString(stream, ref bytes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 45291, 45320);
                    return return_v;
                }


                int
                f_1527_45454_45476(System.IO.FileStream
                stream, byte[]
                bytes)
                {
                    var return_v = ReadInt(stream, bytes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 45454, 45476);
                    return return_v;
                }


                bool
                f_1527_45602_45637(string
                value)
                {
                    var return_v = string.IsNullOrWhiteSpace(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 45602, 45637);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.ModuleCacheEntry>
                f_1527_46134_46148(System.Management.Automation.AnalysisCacheData
                this_param)
                {
                    var return_v = this_param.Entries;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 46134, 46148);
                    return return_v;
                }


                string?
                f_1527_46243_46316(string
                variable)
                {
                    var return_v = Environment.GetEnvironmentVariable(variable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 46243, 46316);
                    return return_v;
                }


                System.Threading.Tasks.Task
                f_1527_46366_46383(int
                millisecondsDelay)
                {
                    var return_v = Task.Delay(millisecondsDelay);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 46366, 46383);
                    return return_v;
                }


                System.Threading.Tasks.Task
                f_1527_46366_46419(System.Threading.Tasks.Task
                this_param, System.Action<System.Threading.Tasks.Task>
                continuationAction)
                {
                    var return_v = this_param.ContinueWith(continuationAction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 46366, 46419);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1527, 41930, 46499);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1527, 41930, 46499);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static AnalysisCacheData Get()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1527, 46511, 48247);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 46575, 46594);

                int
                retryCount = 3
                ;
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 46610, 47735);
                            try
                            {

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 46689, 46840) || true) && (f_1527_46693_46726(s_cacheStoreLocation))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 46689, 46840);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 46776, 46817);

                                    return f_1527_46783_46816(s_cacheStoreLocation);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 46689, 46840);
                                }
                            }
                            catch (Exception e)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1527, 46877, 47549);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 46937, 47029);

                                f_1527_46937_47028(ModuleIntrinsics.Tracer, "Exception checking module analysis cache: " + f_1527_47018_47027(e));

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 47051, 47530) || true) && ((object)f_1527_47063_47072(e) == (object)TruncatedErrorMessage
                                || (DynAbs.Tracing.TraceSender.Expression_False(1527, 47055, 47191) || (object)f_1527_47142_47151(e) == (object)InvalidSignatureErrorMessage
                                ) || (DynAbs.Tracing.TraceSender.Expression_False(1527, 47055, 47279) || (object)f_1527_47228_47237(e) == (object)PossibleCorruptionErrorMessage))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 47051, 47530);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1527, 47501, 47507);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 47051, 47530);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1527, 46877, 47549);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 47569, 47585);

                            retryCount -= 1;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 47603, 47620);

                            f_1527_47603_47619(25);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 46610, 47735);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 46610, 47735) || true) && (retryCount > 0)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1527, 46610, 47735);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1527, 46610, 47735);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 47751, 48236);

                return new AnalysisCacheData
                {
                    LastReadTime = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => DateTime.Now, 1527, 47758, 48235),                // Capacity set to 100 - a bit bigger than the # of modules on a default Win10 client machine
                                                                                                                                                 // Concurrency=3 to not create too many locks, contention is unclear, but the old code had a single lock
                    Entries = f_1527_48101_48220(3, 100, f_1527_48187_48219())
                };
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1527, 46511, 48247);

                bool
                f_1527_46693_46726(string
                path)
                {
                    var return_v = File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 46693, 46726);
                    return return_v;
                }


                System.Management.Automation.AnalysisCacheData
                f_1527_46783_46816(string
                filename)
                {
                    var return_v = Deserialize(filename);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 46783, 46816);
                    return return_v;
                }


                string
                f_1527_47018_47027(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 47018, 47027);
                    return return_v;
                }


                int
                f_1527_46937_47028(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 46937, 47028);
                    return 0;
                }


                string
                f_1527_47063_47072(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 47063, 47072);
                    return return_v;
                }


                string
                f_1527_47142_47151(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 47142, 47151);
                    return return_v;
                }


                string
                f_1527_47228_47237(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 47228, 47237);
                    return return_v;
                }


                int
                f_1527_47603_47619(int
                millisecondsTimeout)
                {
                    Thread.Sleep(millisecondsTimeout);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 47603, 47619);
                    return 0;
                }


                System.StringComparer
                f_1527_48187_48219()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 48187, 48219);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.ModuleCacheEntry>
                f_1527_48101_48220(int
                concurrencyLevel, int
                capacity, System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.ModuleCacheEntry>(concurrencyLevel, capacity, (System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 48101, 48220);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1527, 46511, 48247);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1527, 46511, 48247);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private AnalysisCacheData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1527, 48259, 48308);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 30357, 30432);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 30456, 30478);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 30504, 30527);
                this._saveCacheToDisk = true;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1527, 48259, 48308);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1527, 48259, 48308);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1527, 48259, 48308);
            }
        }

        private static readonly string s_cacheStoreLocation;

        static AnalysisCacheData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1527, 48384, 51112);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 39651, 39712);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 39744, 39809);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 39841, 39911);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 48351, 48371);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 48503, 48597);

                string
                userDefinedCachePath = f_1527_48533_48596("PSModuleAnalysisCachePath")
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 48611, 48776) || true) && (!f_1527_48616_48658(userDefinedCachePath))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 48611, 48776);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 48692, 48736);

                    s_cacheStoreLocation = userDefinedCachePath;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 48754, 48761);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 48611, 48776);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 48792, 48837);

                string
                cacheFileName = "ModuleAnalysisCache"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 49021, 49095);

                string
                hashString = f_1527_49041_49094(f_1527_49063_49093())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 49109, 49207);

                cacheFileName = f_1527_49125_49206(f_1527_49139_49167(), "{0}-{1}", cacheFileName, hashString);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 49223, 51009) || true) && (f_1527_49227_49284(ExperimentalFeature.EnabledExperimentalFeatureNames) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 49223, 51009);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 50179, 50193);

                    int
                    index = 0
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 50211, 50305);

                    string[]
                    featureNames = new string[f_1527_50246_50303(ExperimentalFeature.EnabledExperimentalFeatureNames)]
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 50323, 50521);
                        foreach (string featureName in f_1527_50354_50405_I(ExperimentalFeature.EnabledExperimentalFeatureNames))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1527, 50323, 50521);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 50447, 50502);

                            featureNames[index++] = f_1527_50471_50501(featureName);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 50323, 50521);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1527, 1, 199);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1527, 1, 199);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 50541, 50566);

                    f_1527_50541_50565(featureNames);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 50584, 50649);

                    string
                    allNames = f_1527_50602_50648(f_1527_50614_50633(), featureNames)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 50833, 50878);

                    hashString = f_1527_50846_50877(allNames);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 50896, 50994);

                    cacheFileName = f_1527_50912_50993(f_1527_50926_50954(), "{0}-{1}", cacheFileName, hashString);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1527, 49223, 51009);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 51025, 51101);

                s_cacheStoreLocation = f_1527_51048_51100(Platform.CacheDirectory, cacheFileName);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1527, 48384, 51112);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1527, 48384, 51112);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1527, 48384, 51112);
            }
        }
        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1527, 29926, 51119);

        static string?
        f_1527_48533_48596(string
        variable)
        {
            var return_v = Environment.GetEnvironmentVariable(variable);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 48533, 48596);
            return return_v;
        }


        static bool
        f_1527_48616_48658(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 48616, 48658);
            return return_v;
        }


        static string
        f_1527_49063_49093()
        {
            var return_v = Utils.DefaultPowerShellAppBase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 49063, 49093);
            return return_v;
        }


        static string
        f_1527_49041_49094(string
        input)
        {
            var return_v = CRC32Hash.ComputeHash(input);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 49041, 49094);
            return return_v;
        }


        static System.Globalization.CultureInfo
        f_1527_49139_49167()
        {
            var return_v = CultureInfo.InvariantCulture;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 49139, 49167);
            return return_v;
        }


        static string
        f_1527_49125_49206(System.Globalization.CultureInfo
        provider, string
        format, string
        arg0, string
        arg1)
        {
            var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 49125, 49206);
            return return_v;
        }


        static int
        f_1527_49227_49284(System.Management.Automation.Internal.ReadOnlyBag<string>
        this_param)
        {
            var return_v = this_param.Count;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 49227, 49284);
            return return_v;
        }


        static int
        f_1527_50246_50303(System.Management.Automation.Internal.ReadOnlyBag<string>
        this_param)
        {
            var return_v = this_param.Count;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 50246, 50303);
            return return_v;
        }


        static string
        f_1527_50471_50501(string
        this_param)
        {
            var return_v = this_param.ToLowerInvariant();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 50471, 50501);
            return return_v;
        }


        static System.Management.Automation.Internal.ReadOnlyBag<string>
        f_1527_50354_50405_I(System.Management.Automation.Internal.ReadOnlyBag<string>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 50354, 50405);
            return return_v;
        }


        static int
        f_1527_50541_50565(string[]
        array)
        {
            Array.Sort(array);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 50541, 50565);
            return 0;
        }


        static string
        f_1527_50614_50633()
        {
            var return_v = Environment.NewLine;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 50614, 50633);
            return return_v;
        }


        static string
        f_1527_50602_50648(string
        separator, params string[]
        value)
        {
            var return_v = string.Join(separator, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 50602, 50648);
            return return_v;
        }


        static string
        f_1527_50846_50877(string
        input)
        {
            var return_v = CRC32Hash.ComputeHash(input);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 50846, 50877);
            return return_v;
        }


        static System.Globalization.CultureInfo
        f_1527_50926_50954()
        {
            var return_v = CultureInfo.InvariantCulture;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1527, 50926, 50954);
            return return_v;
        }


        static string
        f_1527_50912_50993(System.Globalization.CultureInfo
        provider, string
        format, string
        arg0, string
        arg1)
        {
            var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 50912, 50993);
            return return_v;
        }


        static string
        f_1527_51048_51100(string
        path1, string
        path2)
        {
            var return_v = Path.Combine(path1, path2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1527, 51048, 51100);
            return return_v;
        }

    }
    [DebuggerDisplay("ModulePath = {ModulePath}")]
    internal class ModuleCacheEntry
    {
        public DateTime LastWriteTime;

        public string ModulePath;

        public bool TypesAnalyzed;

        public ConcurrentDictionary<string, CommandTypes> Commands;

        public ConcurrentDictionary<string, TypeAttributes> Types;

        public ModuleCacheEntry()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1527, 51127, 51472);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 51281, 51291);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 51314, 51327);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 51388, 51396);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1527, 51459, 51464);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1527, 51127, 51472);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1527, 51127, 51472);
        }


        static ModuleCacheEntry()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1527, 51127, 51472);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1527, 51127, 51472);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1527, 51127, 51472);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1527, 51127, 51472);
    }
}
