// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Management.Automation.Language;
using System.Text;
using System.Text.RegularExpressions;

namespace System.Management.Automation
{
    [Serializable]
    internal class ScriptAnalysis
    {
        internal static ScriptAnalysis Analyze(string path, ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1540, 517, 3908);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 619, 682);

                f_1540_619_681(ModuleIntrinsics.Tracer, "Analyzing path: {0}", path);

                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 734, 1518) || true) && (f_1540_738_759(path) && (DynAbs.Tracing.TraceSender.Expression_True(1540, 738, 819) && (f_1540_764_810(f_1540_764_795(context)) != null)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1540, 734, 1518);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 861, 1081);

                        ProgressRecord
                        analysisProgress = f_1540_895_1080(0, f_1540_942_973(), f_1540_1000_1079(f_1540_1014_1042(), f_1540_1044_1072(), path))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 1103, 1163);

                        analysisProgress.RecordType = ProgressRecordType.Processing;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 1373, 1499);

                        f_1540_1373_1498(f_1540_1373_1419(f_1540_1373_1404(context)), f_1540_1434_1479(f_1540_1434_1465(typeof(ScriptAnalysis))), analysisProgress);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1540, 734, 1518);
                    }
                }
                catch (InvalidOperationException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1540, 1547, 1741);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1540, 1547, 1741);
                    // This may be called when we are not allowed to write progress,
                    // So eat the invalid operation
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 1757, 1797);

                string
                scriptContent = f_1540_1780_1796(path)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 1813, 1833);

                ParseError[]
                errors
                = default(ParseError[]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 1847, 1949);

                var
                moduleAst = f_1540_1863_1948((f_1540_1864_1876()), path, scriptContent, null, out errors, ParseMode.ModuleAnalysis)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 2165, 2217) || true) && (f_1540_2169_2182(errors) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1540, 2165, 2217);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 2205, 2217);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1540, 2165, 2217);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 2233, 2303);

                ExportVisitor
                exportVisitor = f_1540_2263_2302(forCompletion: false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 2317, 2348);

                f_1540_2317_2347(moduleAst, exportVisitor);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 2364, 2854);

                var
                result = new ScriptAnalysis
                {
                    DiscoveredClasses = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1540_2448_2479(exportVisitor), 1540, 2377, 2853),
                    DiscoveredExports = f_1540_2518_2549(exportVisitor),
                    DiscoveredAliases = f_1540_2588_2620(),
                    DiscoveredModules = f_1540_2659_2690(exportVisitor),
                    DiscoveredCommandFilters = f_1540_2736_2774(exportVisitor),
                    AddsSelfToPath = f_1540_2810_2838(exportVisitor)
                }
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 2870, 3867) || true) && (f_1540_2874_2911(f_1540_2874_2905(result)) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1540, 2870, 3867);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 2950, 2991);

                    f_1540_2950_2990(f_1540_2950_2981(result), "*");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1540, 2870, 3867);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1540, 2870, 3867);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 3135, 3196);

                    List<WildcardPattern>
                    patterns = f_1540_3168_3195()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 3214, 3436);
                        foreach (string discoveredCommandFilter in f_1540_3257_3288_I(f_1540_3257_3288(result)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1540, 3214, 3436);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 3330, 3417);

                            f_1540_3330_3416(patterns, f_1540_3343_3415(discoveredCommandFilter, WildcardOptions.IgnoreCase));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1540, 3214, 3436);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1540, 1, 223);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1540, 1, 223);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 3456, 3852);
                        foreach (var pair in f_1540_3477_3508_I(f_1540_3477_3508(exportVisitor)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1540, 3456, 3852);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 3550, 3584);

                            string
                            discoveredAlias = pair.Key
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 3606, 3833) || true) && (f_1540_3610_3705(discoveredAlias, patterns, defaultValue: false))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1540, 3606, 3833);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 3755, 3810);

                                f_1540_3755_3779(result)[discoveredAlias] = pair.Value;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1540, 3606, 3833);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1540, 3456, 3852);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1540, 1, 397);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1540, 1, 397);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1540, 2870, 3867);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 3883, 3897);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1540, 517, 3908);

                int
                f_1540_619_681(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 619, 681);
                    return 0;
                }


                bool
                f_1540_738_759(string
                path)
                {
                    var return_v = Utils.PathIsUnc(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 738, 759);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1540_764_795(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentCommandProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 764, 795);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1540_764_810(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 764, 810);
                    return return_v;
                }


                string
                f_1540_942_973()
                {
                    var return_v = Modules.ScriptAnalysisPreparing;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 942, 973);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1540_1014_1042()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 1014, 1042);
                    return return_v;
                }


                string
                f_1540_1044_1072()
                {
                    var return_v = Modules.ScriptAnalysisModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 1044, 1072);
                    return return_v;
                }


                string
                f_1540_1000_1079(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 1000, 1079);
                    return return_v;
                }


                System.Management.Automation.ProgressRecord
                f_1540_895_1080(int
                activityId, string
                activity, string
                statusDescription)
                {
                    var return_v = new System.Management.Automation.ProgressRecord(activityId, activity, statusDescription);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 895, 1080);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1540_1373_1404(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentCommandProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 1373, 1404);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1540_1373_1419(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 1373, 1419);
                    return return_v;
                }


                string
                f_1540_1434_1465(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 1434, 1465);
                    return return_v;
                }


                int
                f_1540_1434_1479(string
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 1434, 1479);
                    return return_v;
                }


                int
                f_1540_1373_1498(System.Management.Automation.MshCommandRuntime
                this_param, int
                sourceId, System.Management.Automation.ProgressRecord
                progressRecord)
                {
                    this_param.WriteProgress((long)sourceId, progressRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 1373, 1498);
                    return 0;
                }


                string
                f_1540_1780_1796(string
                path)
                {
                    var return_v = ReadScript(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 1780, 1796);
                    return return_v;
                }


                System.Management.Automation.Language.Parser
                f_1540_1864_1876()
                {
                    var return_v = new System.Management.Automation.Language.Parser();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 1864, 1876);
                    return return_v;
                }


                System.Management.Automation.Language.ScriptBlockAst
                f_1540_1863_1948(System.Management.Automation.Language.Parser
                this_param, string
                fileName, string
                input, System.Collections.Generic.List<System.Management.Automation.Language.Token>
                tokenList, out System.Management.Automation.Language.ParseError[]
                errors, System.Management.Automation.Language.ParseMode
                parseMode)
                {
                    var return_v = this_param.Parse(fileName, input, tokenList, out errors, parseMode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 1863, 1948);
                    return return_v;
                }


                int
                f_1540_2169_2182(System.Management.Automation.Language.ParseError[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 2169, 2182);
                    return return_v;
                }


                System.Management.Automation.ExportVisitor
                f_1540_2263_2302(bool
                forCompletion)
                {
                    var return_v = new System.Management.Automation.ExportVisitor(forCompletion: forCompletion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 2263, 2302);
                    return return_v;
                }


                int
                f_1540_2317_2347(System.Management.Automation.Language.ScriptBlockAst
                this_param, System.Management.Automation.ExportVisitor
                astVisitor)
                {
                    this_param.Visit((System.Management.Automation.Language.AstVisitor)astVisitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 2317, 2347);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.TypeDefinitionAst>
                f_1540_2448_2479(System.Management.Automation.ExportVisitor
                this_param)
                {
                    var return_v = this_param.DiscoveredClasses;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 2448, 2479);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1540_2518_2549(System.Management.Automation.ExportVisitor
                this_param)
                {
                    var return_v = this_param.DiscoveredExports;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 2518, 2549);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, string>
                f_1540_2588_2620()
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 2588, 2620);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.RequiredModuleInfo>
                f_1540_2659_2690(System.Management.Automation.ExportVisitor
                this_param)
                {
                    var return_v = this_param.DiscoveredModules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 2659, 2690);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1540_2736_2774(System.Management.Automation.ExportVisitor
                this_param)
                {
                    var return_v = this_param.DiscoveredCommandFilters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 2736, 2774);
                    return return_v;
                }


                bool
                f_1540_2810_2838(System.Management.Automation.ExportVisitor
                this_param)
                {
                    var return_v = this_param.AddsSelfToPath
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 2810, 2838);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1540_2874_2905(System.Management.Automation.ScriptAnalysis
                this_param)
                {
                    var return_v = this_param.DiscoveredCommandFilters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 2874, 2905);
                    return return_v;
                }


                int
                f_1540_2874_2911(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 2874, 2911);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1540_2950_2981(System.Management.Automation.ScriptAnalysis
                this_param)
                {
                    var return_v = this_param.DiscoveredCommandFilters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 2950, 2981);
                    return return_v;
                }


                int
                f_1540_2950_2990(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 2950, 2990);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                f_1540_3168_3195()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.WildcardPattern>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 3168, 3195);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1540_3257_3288(System.Management.Automation.ScriptAnalysis
                this_param)
                {
                    var return_v = this_param.DiscoveredCommandFilters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 3257, 3288);
                    return return_v;
                }


                System.Management.Automation.WildcardPattern
                f_1540_3343_3415(string
                pattern, System.Management.Automation.WildcardOptions
                options)
                {
                    var return_v = WildcardPattern.Get(pattern, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 3343, 3415);
                    return return_v;
                }


                int
                f_1540_3330_3416(System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                this_param, System.Management.Automation.WildcardPattern
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 3330, 3416);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_1540_3257_3288_I(System.Collections.Generic.List<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 3257, 3288);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, string>
                f_1540_3477_3508(System.Management.Automation.ExportVisitor
                this_param)
                {
                    var return_v = this_param.DiscoveredAliases;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 3477, 3508);
                    return return_v;
                }


                bool
                f_1540_3610_3705(string
                text, System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                patterns, bool
                defaultValue)
                {
                    var return_v = SessionStateUtilities.MatchesAnyWildcardPattern(text, (System.Collections.Generic.IEnumerable<System.Management.Automation.WildcardPattern>)patterns, defaultValue: defaultValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 3610, 3705);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, string>
                f_1540_3755_3779(System.Management.Automation.ScriptAnalysis
                this_param)
                {
                    var return_v = this_param.DiscoveredAliases;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 3755, 3779);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, string>
                f_1540_3477_3508_I(System.Collections.Generic.Dictionary<string, string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 3477, 3508);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1540, 517, 3908);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1540, 517, 3908);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string ReadScript(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1540, 3920, 4495);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 3991, 4484);
                using (FileStream
                readerStream = f_1540_4024_4076(path, FileMode.Open, FileAccess.Read)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 4110, 4168);

                    Encoding
                    defaultEncoding = f_1540_4137_4167()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 4186, 4274);

                    Microsoft.Win32.SafeHandles.SafeFileHandle
                    safeFileHandle = f_1540_4246_4273(readerStream)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 4294, 4469);
                    using (StreamReader
                    scriptReader = f_1540_4329_4376(readerStream, defaultEncoding)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 4418, 4450);

                        return f_1540_4425_4449(scriptReader);
                        DynAbs.Tracing.TraceSender.TraceExitUsing(1540, 4294, 4469);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1540, 3991, 4484);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1540, 3920, 4495);

                System.IO.FileStream
                f_1540_4024_4076(string
                path, System.IO.FileMode
                mode, System.IO.FileAccess
                access)
                {
                    var return_v = new System.IO.FileStream(path, mode, access);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 4024, 4076);
                    return return_v;
                }


                System.Text.Encoding
                f_1540_4137_4167()
                {
                    var return_v = ClrFacade.GetDefaultEncoding();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 4137, 4167);
                    return return_v;
                }


                Microsoft.Win32.SafeHandles.SafeFileHandle
                f_1540_4246_4273(System.IO.FileStream
                this_param)
                {
                    var return_v = this_param.SafeFileHandle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 4246, 4273);
                    return return_v;
                }


                System.IO.StreamReader
                f_1540_4329_4376(System.IO.FileStream
                stream, System.Text.Encoding
                encoding)
                {
                    var return_v = new System.IO.StreamReader((System.IO.Stream)stream, encoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 4329, 4376);
                    return return_v;
                }


                string
                f_1540_4425_4449(System.IO.StreamReader
                this_param)
                {
                    var return_v = this_param.ReadToEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 4425, 4449);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1540, 3920, 4495);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1540, 3920, 4495);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal List<string> DiscoveredExports { get; set; }

        internal Dictionary<string, string> DiscoveredAliases { get; set; }

        internal List<RequiredModuleInfo> DiscoveredModules { get; set; }

        internal List<string> DiscoveredCommandFilters { get; set; }

        internal bool AddsSelfToPath { get; set; }

        internal List<TypeDefinitionAst> DiscoveredClasses { get; set; }

        public ScriptAnalysis()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1540, 451, 4915);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 4507, 4560);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 4570, 4637);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 4647, 4712);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 4722, 4782);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 4792, 4834);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 4844, 4908);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1540, 451, 4915);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1540, 451, 4915);
        }


        static ScriptAnalysis()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1540, 451, 4915);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1540, 451, 4915);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1540, 451, 4915);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1540, 451, 4915);
    }
    internal class ExportVisitor : AstVisitor2
    {
        internal ExportVisitor(bool forCompletion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1540, 5084, 5650);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 7781, 7795);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 7806, 7859);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 7869, 7934);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 7944, 8028);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 8038, 8105);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 8115, 8175);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 8185, 8227);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 8237, 8301);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 5151, 5182);

                _forCompletion = forCompletion;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 5196, 5235);

                DiscoveredExports = f_1540_5216_5234();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 5249, 5351);

                DiscoveredFunctions = f_1540_5271_5350(f_1540_5317_5349());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 5365, 5450);

                DiscoveredAliases = f_1540_5385_5449(f_1540_5416_5448());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 5464, 5515);

                DiscoveredModules = f_1540_5484_5514();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 5529, 5575);

                DiscoveredCommandFilters = f_1540_5556_5574();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 5589, 5639);

                DiscoveredClasses = f_1540_5609_5638();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1540, 5084, 5650);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1540, 5084, 5650);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1540, 5084, 5650);
            }
        }

        static ExportVisitor()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1540, 5662, 7747);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 27406, 27433);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 5709, 5775);

                var
                nameParam = new ParameterInfo { name = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => "Name", 1540, 5725, 5774), position = 0 }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 5789, 5857);

                var
                valueParam = new ParameterInfo { name = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => "Value", 1540, 5806, 5856), position = 1 }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 5871, 5973);

                var
                aliasParameterInfo = new ParameterBindingInfo { parameterInfo = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => new[] { nameParam, valueParam }, 1540, 5896, 5972) }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 5989, 6064);

                var
                functionParam = new ParameterInfo { name = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => "Function", 1540, 6009, 6063), position = -1 }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 6078, 6149);

                var
                cmdletParam = new ParameterInfo { name = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => "Cmdlet", 1540, 6096, 6148), position = -1 }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 6163, 6232);

                var
                aliasParam = new ParameterInfo { name = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => "Alias", 1540, 6180, 6231), position = -1 }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 6246, 6375);

                var
                ipmoParameterInfo = new ParameterBindingInfo { parameterInfo = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => new[] { nameParam, functionParam, cmdletParam, aliasParam }, 1540, 6270, 6374) }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 6391, 6461);

                functionParam = new ParameterInfo { name = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => "Function", 1540, 6407, 6460), position = 0 };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 6475, 6598);

                var
                exportModuleMemberInfo = new ParameterBindingInfo { parameterInfo = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => new[] { functionParam, cmdletParam, aliasParam }, 1540, 6504, 6597) }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 6614, 7736);

                s_parameterBindingInfoTable = new Dictionary<string, ParameterBindingInfo>(f_1540_6689_6721())
            {
                {DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => "New-Alias",1540,6644,7735),aliasParameterInfo},                {@"Microsoft.PowerShell.Utility\New-Alias",        aliasParameterInfo},                {"Set-Alias",                                      aliasParameterInfo},                {@"Microsoft.PowerShell.Utility\Set-Alias",        aliasParameterInfo},                {"nal",                                            aliasParameterInfo},                {"sal",                                            aliasParameterInfo},                {"Import-Module",                                  ipmoParameterInfo},                {@"Microsoft.PowerShell.Core\Import-Module",       ipmoParameterInfo},                {"ipmo",                                           ipmoParameterInfo},                {"Export-ModuleMember",                            exportModuleMemberInfo},                {@"Microsoft.PowerShell.Core\Export-ModuleMember", exportModuleMemberInfo}
            };
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1540, 5662, 7747);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1540, 5662, 7747);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1540, 5662, 7747);
            }
        }

        private readonly bool _forCompletion;

        internal List<string> DiscoveredExports { get; set; }

        internal List<RequiredModuleInfo> DiscoveredModules { get; set; }

        internal Dictionary<string, FunctionDefinitionAst> DiscoveredFunctions { get; set; }

        internal Dictionary<string, string> DiscoveredAliases { get; set; }

        internal List<string> DiscoveredCommandFilters { get; set; }

        internal bool AddsSelfToPath { get; set; }

        internal List<TypeDefinitionAst> DiscoveredClasses { get; set; }

        public override AstVisitAction VisitTypeDefinition(TypeDefinitionAst typeDefinitionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1540, 8313, 8569);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 8425, 8466);

                f_1540_8425_8465(f_1540_8425_8442(), typeDefinitionAst);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 8480, 8558);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1540, 8487, 8501) || ((_forCompletion && DynAbs.Tracing.TraceSender.Conditional_F2(1540, 8504, 8527)) || DynAbs.Tracing.TraceSender.Conditional_F3(1540, 8530, 8557))) ? AstVisitAction.Continue : AstVisitAction.SkipChildren;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1540, 8313, 8569);

                System.Collections.Generic.List<System.Management.Automation.Language.TypeDefinitionAst>
                f_1540_8425_8442()
                {
                    var return_v = DiscoveredClasses;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 8425, 8442);
                    return return_v;
                }


                int
                f_1540_8425_8465(System.Collections.Generic.List<System.Management.Automation.Language.TypeDefinitionAst>
                this_param, System.Management.Automation.Language.TypeDefinitionAst
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 8425, 8465);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1540, 8313, 8569);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1540, 8313, 8569);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override AstVisitAction VisitFunctionDefinition(FunctionDefinitionAst functionDefinitionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1540, 8629, 10806);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 8945, 8991);

                var
                functionName = f_1540_8964_8990(functionDefinitionAst)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 9005, 9063);

                f_1540_9005_9024()[functionName] = functionDefinitionAst;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 9077, 9164);

                f_1540_9077_9163(ModuleIntrinsics.Tracer, "Discovered function definition: {0}", functionName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 9309, 9355);

                var
                functionBody = f_1540_9328_9354(functionDefinitionAst)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 9369, 10387) || true) && ((f_1540_9374_9397(functionBody) != null) && (DynAbs.Tracing.TraceSender.Expression_True(1540, 9373, 9454) && (f_1540_9411_9445(f_1540_9411_9434(functionBody)) != null)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1540, 9369, 10387);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 9488, 10372);
                        foreach (AttributeAst attribute in f_1540_9523_9557_I(f_1540_9523_9557(f_1540_9523_9546(functionBody))))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1540, 9488, 10372);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 9599, 10353) || true) && (f_1540_9603_9650(f_1540_9603_9621(attribute)) == typeof(AliasAttribute))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1540, 9599, 10353);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 9726, 10330);
                                    foreach (ExpressionAst aliasAst in f_1540_9761_9790_I(f_1540_9761_9790(attribute)))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1540, 9726, 10330);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 9848, 9910);

                                        var
                                        aliasExpression = aliasAst as StringConstantExpressionAst
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 9940, 10303) || true) && (aliasExpression != null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1540, 9940, 10303);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 10033, 10070);

                                            string
                                            alias = f_1540_10048_10069(aliasExpression)
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 10106, 10146);

                                            f_1540_10106_10123()[alias] = functionName;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 10180, 10272);

                                            f_1540_10180_10271(ModuleIntrinsics.Tracer, "Function defines alias: {0} = {1}", alias, functionName);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1540, 9940, 10303);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1540, 9726, 10330);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1540, 1, 605);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1540, 1, 605);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1540, 9599, 10353);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1540, 9488, 10372);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1540, 1, 885);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1540, 1, 885);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1540, 9369, 10387);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 10403, 10694) || true) && (_forCompletion)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1540, 10403, 10694);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 10455, 10628) || true) && (f_1540_10459_10523(f_1540_10459_10516(functionDefinitionAst)) == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1540, 10455, 10628);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 10573, 10609);

                        f_1540_10573_10608(f_1540_10573_10590(), functionName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1540, 10455, 10628);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 10648, 10679);

                    return AstVisitAction.Continue;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1540, 10403, 10694);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 10710, 10746);

                f_1540_10710_10745(f_1540_10710_10727(), functionName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 10760, 10795);

                return AstVisitAction.SkipChildren;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1540, 8629, 10806);

                string
                f_1540_8964_8990(System.Management.Automation.Language.FunctionDefinitionAst
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 8964, 8990);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.FunctionDefinitionAst>
                f_1540_9005_9024()
                {
                    var return_v = DiscoveredFunctions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 9005, 9024);
                    return return_v;
                }


                int
                f_1540_9077_9163(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 9077, 9163);
                    return 0;
                }


                System.Management.Automation.Language.ScriptBlockAst
                f_1540_9328_9354(System.Management.Automation.Language.FunctionDefinitionAst
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 9328, 9354);
                    return return_v;
                }


                System.Management.Automation.Language.ParamBlockAst
                f_1540_9374_9397(System.Management.Automation.Language.ScriptBlockAst
                this_param)
                {
                    var return_v = this_param.ParamBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 9374, 9397);
                    return return_v;
                }


                System.Management.Automation.Language.ParamBlockAst
                f_1540_9411_9434(System.Management.Automation.Language.ScriptBlockAst
                this_param)
                {
                    var return_v = this_param.ParamBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 9411, 9434);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeAst>
                f_1540_9411_9445(System.Management.Automation.Language.ParamBlockAst
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 9411, 9445);
                    return return_v;
                }


                System.Management.Automation.Language.ParamBlockAst
                f_1540_9523_9546(System.Management.Automation.Language.ScriptBlockAst
                this_param)
                {
                    var return_v = this_param.ParamBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 9523, 9546);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeAst>
                f_1540_9523_9557(System.Management.Automation.Language.ParamBlockAst
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 9523, 9557);
                    return return_v;
                }


                System.Management.Automation.Language.ITypeName
                f_1540_9603_9621(System.Management.Automation.Language.AttributeAst
                this_param)
                {
                    var return_v = this_param.TypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 9603, 9621);
                    return return_v;
                }


                System.Type
                f_1540_9603_9650(System.Management.Automation.Language.ITypeName
                this_param)
                {
                    var return_v = this_param.GetReflectionAttributeType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 9603, 9650);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
                f_1540_9761_9790(System.Management.Automation.Language.AttributeAst
                this_param)
                {
                    var return_v = this_param.PositionalArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 9761, 9790);
                    return return_v;
                }


                string
                f_1540_10048_10069(System.Management.Automation.Language.StringConstantExpressionAst
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 10048, 10069);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, string>
                f_1540_10106_10123()
                {
                    var return_v = DiscoveredAliases;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 10106, 10123);
                    return return_v;
                }


                int
                f_1540_10180_10271(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1, string
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 10180, 10271);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
                f_1540_9761_9790_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 9761, 9790);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeAst>
                f_1540_9523_9557_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeAst>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 9523, 9557);
                    return return_v;
                }


                System.Management.Automation.Language.ScriptBlockAst
                f_1540_10459_10516(System.Management.Automation.Language.FunctionDefinitionAst
                ast)
                {
                    var return_v = Ast.GetAncestorAst<ScriptBlockAst>((System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 10459, 10516);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1540_10459_10523(System.Management.Automation.Language.ScriptBlockAst
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 10459, 10523);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1540_10573_10590()
                {
                    var return_v = DiscoveredExports;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 10573, 10590);
                    return return_v;
                }


                int
                f_1540_10573_10608(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 10573, 10608);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_1540_10710_10727()
                {
                    var return_v = DiscoveredExports;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 10710, 10727);
                    return return_v;
                }


                int
                f_1540_10710_10745(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 10710, 10745);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1540, 8629, 10806);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1540, 8629, 10806);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override AstVisitAction VisitAssignmentStatement(AssignmentStatementAst assignmentStatementAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1540, 10957, 11577);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 11132, 11515) || true) && (f_1540_11136_11238("$env:PATH", f_1540_11163_11201(f_1540_11163_11190(assignmentStatementAst)), StringComparison.OrdinalIgnoreCase) && (DynAbs.Tracing.TraceSender.Expression_True(1540, 11136, 11357) && f_1540_11259_11357(f_1540_11273_11312(f_1540_11273_11301(assignmentStatementAst)), "\\$psScriptRoot", RegexOptions.IgnoreCase)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1540, 11132, 11515);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 11391, 11460);

                    f_1540_11391_11459(ModuleIntrinsics.Tracer, "Module adds itself to the path.");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 11478, 11500);

                    AddsSelfToPath = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1540, 11132, 11515);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 11531, 11566);

                return AstVisitAction.SkipChildren;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1540, 10957, 11577);

                System.Management.Automation.Language.ExpressionAst
                f_1540_11163_11190(System.Management.Automation.Language.AssignmentStatementAst
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 11163, 11190);
                    return return_v;
                }


                string
                f_1540_11163_11201(System.Management.Automation.Language.ExpressionAst
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 11163, 11201);
                    return return_v;
                }


                bool
                f_1540_11136_11238(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 11136, 11238);
                    return return_v;
                }


                System.Management.Automation.Language.StatementAst
                f_1540_11273_11301(System.Management.Automation.Language.AssignmentStatementAst
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 11273, 11301);
                    return return_v;
                }


                string
                f_1540_11273_11312(System.Management.Automation.Language.StatementAst
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 11273, 11312);
                    return return_v;
                }


                bool
                f_1540_11259_11357(string
                input, string
                pattern, System.Text.RegularExpressions.RegexOptions
                options)
                {
                    var return_v = Regex.IsMatch(input, pattern, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 11259, 11357);
                    return return_v;
                }


                int
                f_1540_11391_11459(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 11391, 11459);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1540, 10957, 11577);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1540, 10957, 11577);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override AstVisitAction VisitIfStatement(IfStatementAst ifStmtAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1540, 11751, 11864);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 11827, 11862);

                return AstVisitAction.SkipChildren;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1540, 11751, 11864);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1540, 11751, 11864);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1540, 11751, 11864);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override AstVisitAction VisitDataStatement(DataStatementAst dataStatementAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1540, 11876, 12000);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 11963, 11998);

                return AstVisitAction.SkipChildren;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1540, 11876, 12000);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1540, 11876, 12000);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1540, 11876, 12000);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override AstVisitAction VisitForEachStatement(ForEachStatementAst forEachStatementAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1540, 12012, 12145);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 12108, 12143);

                return AstVisitAction.SkipChildren;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1540, 12012, 12145);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1540, 12012, 12145);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1540, 12012, 12145);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override AstVisitAction VisitForStatement(ForStatementAst forStatementAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1540, 12157, 12278);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 12241, 12276);

                return AstVisitAction.SkipChildren;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1540, 12157, 12278);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1540, 12157, 12278);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1540, 12157, 12278);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override AstVisitAction VisitDoUntilStatement(DoUntilStatementAst doUntilStatementAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1540, 12290, 12423);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 12386, 12421);

                return AstVisitAction.SkipChildren;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1540, 12290, 12423);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1540, 12290, 12423);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1540, 12290, 12423);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override AstVisitAction VisitDoWhileStatement(DoWhileStatementAst doWhileStatementAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1540, 12435, 12568);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 12531, 12566);

                return AstVisitAction.SkipChildren;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1540, 12435, 12568);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1540, 12435, 12568);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1540, 12435, 12568);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override AstVisitAction VisitWhileStatement(WhileStatementAst whileStatementAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1540, 12580, 12707);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 12670, 12705);

                return AstVisitAction.SkipChildren;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1540, 12580, 12707);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1540, 12580, 12707);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1540, 12580, 12707);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override AstVisitAction VisitInvokeMemberExpression(InvokeMemberExpressionAst methodCallAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1540, 12719, 12858);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 12821, 12856);

                return AstVisitAction.SkipChildren;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1540, 12719, 12858);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1540, 12719, 12858);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1540, 12719, 12858);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override AstVisitAction VisitSwitchStatement(SwitchStatementAst switchStatementAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1540, 12870, 13000);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 12963, 12998);

                return AstVisitAction.SkipChildren;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1540, 12870, 13000);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1540, 12870, 13000);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1540, 12870, 13000);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override AstVisitAction VisitTernaryExpression(TernaryExpressionAst ternaryExpressionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1540, 13012, 13148);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 13111, 13146);

                return AstVisitAction.SkipChildren;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1540, 13012, 13148);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1540, 13012, 13148);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1540, 13012, 13148);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override AstVisitAction VisitCommand(CommandAst commandAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1540, 13339, 21582);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 13430, 13649);

                string
                commandName =
                f_1540_13468_13495(commandAst) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1540, 13468, 13648) ?? f_1540_13516_13638(f_1540_13549_13578(f_1540_13549_13575(commandAst), 0), null, GetSafeValueVisitor.SafeValueContext.ModuleAnalysis) as string)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 13665, 13742) || true) && (commandName == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1540, 13665, 13742);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 13707, 13742);

                    return AstVisitAction.SkipChildren;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1540, 13665, 13742);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 13806, 14370) || true) && (f_1540_13810_13839(commandAst) == TokenKind.Dot)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1540, 13806, 14370);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 14137, 14271);

                    f_1540_14137_14270(f_1540_14137_14154(), new RequiredModuleInfo { Name = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => commandName, 1540, 14181, 14269), CommandsToPostFilter = f_1540_14249_14267() });
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 14289, 14355);

                    f_1540_14289_14354(ModuleIntrinsics.Tracer, "Module dots {0}", commandName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1540, 13806, 14370);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 14429, 16071) || true) && (f_1540_14433_14508(commandName, "New-Alias", StringComparison.OrdinalIgnoreCase) || (DynAbs.Tracing.TraceSender.Expression_False(1540, 14433, 14634) || f_1540_14529_14634(commandName, "Microsoft.PowerShell.Utility\\New-Alias", StringComparison.OrdinalIgnoreCase)) || (DynAbs.Tracing.TraceSender.Expression_False(1540, 14433, 14730) || f_1540_14655_14730(commandName, "Set-Alias", StringComparison.OrdinalIgnoreCase)) || (DynAbs.Tracing.TraceSender.Expression_False(1540, 14433, 14856) || f_1540_14751_14856(commandName, "Microsoft.PowerShell.Utility\\Set-Alias", StringComparison.OrdinalIgnoreCase)) || (DynAbs.Tracing.TraceSender.Expression_False(1540, 14433, 14946) || f_1540_14877_14946(commandName, "nal", StringComparison.OrdinalIgnoreCase)) || (DynAbs.Tracing.TraceSender.Expression_False(1540, 14433, 15036) || f_1540_14967_15036(commandName, "sal", StringComparison.OrdinalIgnoreCase)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1540, 14429, 16071);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 15274, 15346);

                    var
                    boundParameters = f_1540_15296_15345(this, commandAst, commandName)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 15366, 15411);

                    var
                    name = f_1540_15377_15400(boundParameters, "Name") as string
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 15429, 16001) || true) && (!f_1540_15434_15460(name))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1540, 15429, 16001);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 15502, 15549);

                        var
                        value = f_1540_15514_15538(boundParameters, "Value") as string
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 15571, 15982) || true) && (!f_1540_15576_15603(value))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1540, 15571, 15982);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 15819, 15851);

                            f_1540_15819_15836()[name] = value;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 15877, 15959);

                            f_1540_15877_15958(ModuleIntrinsics.Tracer, "Module defines alias: {0} = {1}", name, value);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1540, 15571, 15982);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1540, 15429, 16001);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 16021, 16056);

                    return AstVisitAction.SkipChildren;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1540, 14429, 16071);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 16131, 18260) || true) && (f_1540_16135_16214(commandName, "Import-Module", StringComparison.OrdinalIgnoreCase) || (DynAbs.Tracing.TraceSender.Expression_False(1540, 16135, 16305) || f_1540_16235_16305(commandName, "ipmo", StringComparison.OrdinalIgnoreCase)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1540, 16131, 18260);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 16768, 16840);

                    var
                    boundParameters = f_1540_16790_16839(this, commandAst, commandName)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 16860, 16915);

                    List<string>
                    commandsToPostFilter = f_1540_16896_16914()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 16935, 17095);

                    Action<string>
                    onEachCommand = importedCommandName =>
                                    {
                                        commandsToPostFilter.Add(importedCommandName);
                                    }
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 17259, 17326);

                    f_1540_17259_17325(this, f_1540_17282_17309(boundParameters, "Function"), onEachCommand);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 17344, 17409);

                    f_1540_17344_17408(this, f_1540_17367_17392(boundParameters, "Cmdlet"), onEachCommand);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 17427, 17491);

                    f_1540_17427_17490(this, f_1540_17450_17474(boundParameters, "Alias"), onEachCommand);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 17658, 18110);

                    Action<string>
                    onEachModule = moduleName =>
                                    {
                                        ModuleIntrinsics.Tracer.WriteLine("Discovered module import: {0}", moduleName);
                                        DiscoveredModules.Add(
                                            new RequiredModuleInfo
                                            {
                                                Name = moduleName,
                                                CommandsToPostFilter = commandsToPostFilter
                                            });
                                    }
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 18128, 18190);

                    f_1540_18128_18189(this, f_1540_18151_18174(boundParameters, "Name"), onEachModule);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 18210, 18245);

                    return AstVisitAction.SkipChildren;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1540, 16131, 18260);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 18327, 20861) || true) && (f_1540_18331_18416(commandName, "Export-ModuleMember", StringComparison.OrdinalIgnoreCase) || (DynAbs.Tracing.TraceSender.Expression_False(1540, 18331, 18549) || f_1540_18437_18549(commandName, "Microsoft.PowerShell.Core\\Export-ModuleMember", StringComparison.OrdinalIgnoreCase)) || (DynAbs.Tracing.TraceSender.Expression_False(1540, 18331, 18662) || f_1540_18570_18662(commandName, "$script:ExportModuleMember", StringComparison.OrdinalIgnoreCase)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1540, 18327, 20861);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 19082, 19154);

                    var
                    boundParameters = f_1540_19104_19153(this, commandAst, commandName)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 19174, 19956);

                    Action<string>
                    onEachFunction = exportedCommandName =>
                                    {
                                        DiscoveredCommandFilters.Add(exportedCommandName);
                                        ModuleIntrinsics.Tracer.WriteLine("Discovered explicit export: {0}", exportedCommandName);

                    // If the export doesn't contain wildcards, then add it to the
                    // discovered commands as well. It is likely that they created
                    // the command dynamically
                    if ((!WildcardPattern.ContainsWildcardCharacters(exportedCommandName)) &&
                                            (!DiscoveredExports.Contains(exportedCommandName)))
                                        {
                                            DiscoveredExports.Add(exportedCommandName);
                                        }
                                    }
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 19974, 20042);

                    f_1540_19974_20041(this, f_1540_19997_20024(boundParameters, "Function"), onEachFunction);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 20060, 20126);

                    f_1540_20060_20125(this, f_1540_20083_20108(boundParameters, "Cmdlet"), onEachFunction);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 20146, 20711);

                    Action<string>
                    onEachAlias = exportedAlias =>
                                    {
                                        DiscoveredCommandFilters.Add(exportedAlias);

                    // If the export doesn't contain wildcards, then add it to the
                    // discovered commands as well. It is likely that they created
                    // the command dynamically
                    if (!WildcardPattern.ContainsWildcardCharacters(exportedAlias))
                                        {
                                            DiscoveredAliases[exportedAlias] = null;
                                        }
                                    }
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 20729, 20791);

                    f_1540_20729_20790(this, f_1540_20752_20776(boundParameters, "Alias"), onEachAlias);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 20811, 20846);

                    return AstVisitAction.SkipChildren;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1540, 18327, 20861);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 21016, 21520) || true) && ((f_1540_21021_21093(commandName, "public", StringComparison.OrdinalIgnoreCase)) && (DynAbs.Tracing.TraceSender.Expression_True(1540, 21020, 21153) && (f_1540_21116_21148(f_1540_21116_21142(commandAst)) > 2)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1540, 21016, 21520);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 21305, 21380);

                    string
                    publicCommandName = f_1540_21332_21379(f_1540_21332_21372(f_1540_21332_21361(f_1540_21332_21358(commandAst), 2)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 21398, 21439);

                    f_1540_21398_21438(f_1540_21398_21415(), publicCommandName);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 21457, 21505);

                    f_1540_21457_21504(f_1540_21457_21481(), publicCommandName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1540, 21016, 21520);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 21536, 21571);

                return AstVisitAction.SkipChildren;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1540, 13339, 21582);

                string
                f_1540_13468_13495(System.Management.Automation.Language.CommandAst
                this_param)
                {
                    var return_v = this_param.GetCommandName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 13468, 13495);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                f_1540_13549_13575(System.Management.Automation.Language.CommandAst
                this_param)
                {
                    var return_v = this_param.CommandElements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 13549, 13575);
                    return return_v;
                }


                System.Management.Automation.Language.CommandElementAst
                f_1540_13549_13578(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 13549, 13578);
                    return return_v;
                }


                object
                f_1540_13516_13638(System.Management.Automation.Language.CommandElementAst
                ast, System.Management.Automation.ExecutionContext
                context, System.Management.Automation.Language.GetSafeValueVisitor.SafeValueContext
                safeValueContext)
                {
                    var return_v = GetSafeValueVisitor.GetSafeValue((System.Management.Automation.Language.Ast)ast, context, safeValueContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 13516, 13638);
                    return return_v;
                }


                System.Management.Automation.Language.TokenKind
                f_1540_13810_13839(System.Management.Automation.Language.CommandAst
                this_param)
                {
                    var return_v = this_param.InvocationOperator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 13810, 13839);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.RequiredModuleInfo>
                f_1540_14137_14154()
                {
                    var return_v = DiscoveredModules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 14137, 14154);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1540_14249_14267()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 14249, 14267);
                    return return_v;
                }


                int
                f_1540_14137_14270(System.Collections.Generic.List<System.Management.Automation.RequiredModuleInfo>
                this_param, System.Management.Automation.RequiredModuleInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 14137, 14270);
                    return 0;
                }


                int
                f_1540_14289_14354(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 14289, 14354);
                    return 0;
                }


                bool
                f_1540_14433_14508(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 14433, 14508);
                    return return_v;
                }


                bool
                f_1540_14529_14634(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 14529, 14634);
                    return return_v;
                }


                bool
                f_1540_14655_14730(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 14655, 14730);
                    return return_v;
                }


                bool
                f_1540_14751_14856(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 14751, 14856);
                    return return_v;
                }


                bool
                f_1540_14877_14946(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 14877, 14946);
                    return return_v;
                }


                bool
                f_1540_14967_15036(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 14967, 15036);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1540_15296_15345(System.Management.Automation.ExportVisitor
                this_param, System.Management.Automation.Language.CommandAst
                commandAst, string
                commandName)
                {
                    var return_v = this_param.DoPsuedoParameterBinding(commandAst, commandName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 15296, 15345);
                    return return_v;
                }


                object
                f_1540_15377_15400(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 15377, 15400);
                    return return_v;
                }


                bool
                f_1540_15434_15460(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 15434, 15460);
                    return return_v;
                }


                object
                f_1540_15514_15538(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 15514, 15538);
                    return return_v;
                }


                bool
                f_1540_15576_15603(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 15576, 15603);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, string>
                f_1540_15819_15836()
                {
                    var return_v = DiscoveredAliases;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 15819, 15836);
                    return return_v;
                }


                int
                f_1540_15877_15958(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1, string
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 15877, 15958);
                    return 0;
                }


                bool
                f_1540_16135_16214(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 16135, 16214);
                    return return_v;
                }


                bool
                f_1540_16235_16305(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 16235, 16305);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1540_16790_16839(System.Management.Automation.ExportVisitor
                this_param, System.Management.Automation.Language.CommandAst
                commandAst, string
                commandName)
                {
                    var return_v = this_param.DoPsuedoParameterBinding(commandAst, commandName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 16790, 16839);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1540_16896_16914()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 16896, 16914);
                    return return_v;
                }


                object
                f_1540_17282_17309(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 17282, 17309);
                    return return_v;
                }


                int
                f_1540_17259_17325(System.Management.Automation.ExportVisitor
                this_param, object
                value, System.Action<string>
                onEachArgument)
                {
                    this_param.ProcessCmdletArguments(value, onEachArgument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 17259, 17325);
                    return 0;
                }


                object
                f_1540_17367_17392(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 17367, 17392);
                    return return_v;
                }


                int
                f_1540_17344_17408(System.Management.Automation.ExportVisitor
                this_param, object
                value, System.Action<string>
                onEachArgument)
                {
                    this_param.ProcessCmdletArguments(value, onEachArgument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 17344, 17408);
                    return 0;
                }


                object
                f_1540_17450_17474(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 17450, 17474);
                    return return_v;
                }


                int
                f_1540_17427_17490(System.Management.Automation.ExportVisitor
                this_param, object
                value, System.Action<string>
                onEachArgument)
                {
                    this_param.ProcessCmdletArguments(value, onEachArgument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 17427, 17490);
                    return 0;
                }


                object
                f_1540_18151_18174(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 18151, 18174);
                    return return_v;
                }


                int
                f_1540_18128_18189(System.Management.Automation.ExportVisitor
                this_param, object
                value, System.Action<string>
                onEachArgument)
                {
                    this_param.ProcessCmdletArguments(value, onEachArgument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 18128, 18189);
                    return 0;
                }


                bool
                f_1540_18331_18416(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 18331, 18416);
                    return return_v;
                }


                bool
                f_1540_18437_18549(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 18437, 18549);
                    return return_v;
                }


                bool
                f_1540_18570_18662(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 18570, 18662);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1540_19104_19153(System.Management.Automation.ExportVisitor
                this_param, System.Management.Automation.Language.CommandAst
                commandAst, string
                commandName)
                {
                    var return_v = this_param.DoPsuedoParameterBinding(commandAst, commandName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 19104, 19153);
                    return return_v;
                }


                object
                f_1540_19997_20024(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 19997, 20024);
                    return return_v;
                }


                int
                f_1540_19974_20041(System.Management.Automation.ExportVisitor
                this_param, object
                value, System.Action<string>
                onEachArgument)
                {
                    this_param.ProcessCmdletArguments(value, onEachArgument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 19974, 20041);
                    return 0;
                }


                object
                f_1540_20083_20108(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 20083, 20108);
                    return return_v;
                }


                int
                f_1540_20060_20125(System.Management.Automation.ExportVisitor
                this_param, object
                value, System.Action<string>
                onEachArgument)
                {
                    this_param.ProcessCmdletArguments(value, onEachArgument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 20060, 20125);
                    return 0;
                }


                object
                f_1540_20752_20776(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 20752, 20776);
                    return return_v;
                }


                int
                f_1540_20729_20790(System.Management.Automation.ExportVisitor
                this_param, object
                value, System.Action<string>
                onEachArgument)
                {
                    this_param.ProcessCmdletArguments(value, onEachArgument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 20729, 20790);
                    return 0;
                }


                bool
                f_1540_21021_21093(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 21021, 21093);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                f_1540_21116_21142(System.Management.Automation.Language.CommandAst
                this_param)
                {
                    var return_v = this_param.CommandElements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 21116, 21142);
                    return return_v;
                }


                int
                f_1540_21116_21148(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 21116, 21148);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                f_1540_21332_21358(System.Management.Automation.Language.CommandAst
                this_param)
                {
                    var return_v = this_param.CommandElements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 21332, 21358);
                    return return_v;
                }


                System.Management.Automation.Language.CommandElementAst
                f_1540_21332_21361(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 21332, 21361);
                    return return_v;
                }


                string
                f_1540_21332_21372(System.Management.Automation.Language.CommandElementAst
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 21332, 21372);
                    return return_v;
                }


                string
                f_1540_21332_21379(string
                this_param)
                {
                    var return_v = this_param.Trim();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 21332, 21379);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1540_21398_21415()
                {
                    var return_v = DiscoveredExports;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 21398, 21415);
                    return return_v;
                }


                int
                f_1540_21398_21438(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 21398, 21438);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_1540_21457_21481()
                {
                    var return_v = DiscoveredCommandFilters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 21457, 21481);
                    return return_v;
                }


                int
                f_1540_21457_21504(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 21457, 21504);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1540, 13339, 21582);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1540, 13339, 21582);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ProcessCmdletArguments(object value, Action<string> onEachArgument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1540, 21594, 22384);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 21699, 21725) || true) && (value == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1540, 21699, 21725);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 21718, 21725);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1540, 21699, 21725);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 21741, 21775);

                var
                commandName = value as string
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 21789, 21914) || true) && (commandName != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1540, 21789, 21914);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 21846, 21874);

                    f_1540_21846_21873(onEachArgument, commandName);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 21892, 21899);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1540, 21789, 21914);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 21930, 21960);

                var
                names = value as object[]
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 21974, 22373) || true) && (names != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1540, 21974, 22373);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 22025, 22358);
                        foreach (var n in f_1540_22043_22048_I(names))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1540, 22025, 22358);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 22297, 22339);

                            f_1540_22297_22338(this, n, onEachArgument);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1540, 22025, 22358);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1540, 1, 334);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1540, 1, 334);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1540, 21974, 22373);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1540, 21594, 22384);

                int
                f_1540_21846_21873(System.Action<string>
                this_param, string
                obj)
                {
                    this_param.Invoke(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 21846, 21873);
                    return 0;
                }


                int
                f_1540_22297_22338(System.Management.Automation.ExportVisitor
                this_param, object
                value, System.Action<string>
                onEachArgument)
                {
                    this_param.ProcessCmdletArguments(value, onEachArgument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 22297, 22338);
                    return 0;
                }


                object[]
                f_1540_22043_22048_I(object[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 22043, 22048);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1540, 21594, 22384);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1540, 21594, 22384);
            }
        }

        private Hashtable DoPsuedoParameterBinding(CommandAst commandAst, string commandName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1540, 22802, 27338);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 22912, 22973);

                var
                result = f_1540_22925_22972(f_1540_22939_22971())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 22989, 23071);

                var
                parameterBindingInfo = f_1540_23016_23056(s_parameterBindingInfoTable, commandName).parameterInfo
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 23087, 23110);

                int
                positionsBound = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 23135, 23140);

                    for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 23126, 27297) || true) && (i < f_1540_23146_23178(f_1540_23146_23172(commandAst)))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 23180, 23183)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1540, 23126, 27297))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1540, 23126, 27297);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 23217, 23261);

                        var
                        element = f_1540_23231_23260(f_1540_23231_23257(commandAst), i)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 23279, 23335);

                        var
                        specifiedParameter = element as CommandParameterAst
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 23353, 27282) || true) && (specifiedParameter != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1540, 23353, 27282);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 23425, 23453);

                            bool
                            boundParameter = false
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 23475, 23533);

                            var
                            specifiedParamName = f_1540_23500_23532(specifiedParameter)
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 23555, 24906);
                                foreach (var parameterInfo in f_1540_23585_23605_I(parameterBindingInfo))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1540, 23555, 24906);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 23655, 24883) || true) && (f_1540_23659_23744(parameterInfo.name, specifiedParamName, StringComparison.OrdinalIgnoreCase))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1540, 23655, 24883);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 23802, 23977) || true) && (parameterInfo.position != -1)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1540, 23802, 23977);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 23900, 23946);

                                            positionsBound |= 1 << parameterInfo.position;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1540, 23802, 23977);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 24009, 24055);

                                        var
                                        argumentAst = f_1540_24027_24054(specifiedParameter)
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 24085, 24439) || true) && (argumentAst == null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1540, 24085, 24439);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 24174, 24235);

                                            argumentAst = f_1540_24188_24217(f_1540_24188_24214(commandAst), i) as ExpressionAst;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 24269, 24408) || true) && (argumentAst != null)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1540, 24269, 24408);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 24366, 24373);

                                                i += 1;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1540, 24269, 24408);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1540, 24085, 24439);
                                        }

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 24471, 24818) || true) && (argumentAst != null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1540, 24471, 24818);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 24560, 24582);

                                            boundParameter = true;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 24616, 24787);

                                            result[parameterInfo.name] =
                                            f_1540_24682_24786(argumentAst, null, GetSafeValueVisitor.SafeValueContext.ModuleAnalysis);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1540, 24471, 24818);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceBreak(1540, 24850, 24856);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1540, 23655, 24883);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1540, 23555, 24906);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1540, 1, 1352);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1540, 1, 1352);
                            }
                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 24930, 25069) || true) && (boundParameter || (DynAbs.Tracing.TraceSender.Expression_False(1540, 24934, 24987) || f_1540_24952_24979(specifiedParameter) != null))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1540, 24930, 25069);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 25037, 25046);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1540, 24930, 25069);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 25093, 26221) || true) && (!f_1540_25098_25175("PassThru", specifiedParamName, StringComparison.OrdinalIgnoreCase) && (DynAbs.Tracing.TraceSender.Expression_True(1540, 25097, 25279) && !f_1540_25205_25279("Force", specifiedParamName, StringComparison.OrdinalIgnoreCase)) && (DynAbs.Tracing.TraceSender.Expression_True(1540, 25097, 25385) && !f_1540_25309_25385("Confirm", specifiedParamName, StringComparison.OrdinalIgnoreCase)) && (DynAbs.Tracing.TraceSender.Expression_True(1540, 25097, 25490) && !f_1540_25415_25490("Global", specifiedParamName, StringComparison.OrdinalIgnoreCase)) && (DynAbs.Tracing.TraceSender.Expression_True(1540, 25097, 25603) && !f_1540_25520_25603("AsCustomObject", specifiedParamName, StringComparison.OrdinalIgnoreCase)) && (DynAbs.Tracing.TraceSender.Expression_True(1540, 25097, 25709) && !f_1540_25633_25709("Verbose", specifiedParamName, StringComparison.OrdinalIgnoreCase)) && (DynAbs.Tracing.TraceSender.Expression_True(1540, 25097, 25813) && !f_1540_25739_25813("Debug", specifiedParamName, StringComparison.OrdinalIgnoreCase)) && (DynAbs.Tracing.TraceSender.Expression_True(1540, 25097, 25931) && !f_1540_25843_25931("DisableNameChecking", specifiedParamName, StringComparison.OrdinalIgnoreCase)) && (DynAbs.Tracing.TraceSender.Expression_True(1540, 25097, 26039) && !f_1540_25961_26039("NoClobber", specifiedParamName, StringComparison.OrdinalIgnoreCase)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1540, 25093, 26221);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 26191, 26198);

                                i += 1;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1540, 25093, 26221);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1540, 23353, 27282);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1540, 23353, 27282);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 26384, 26396);

                            int
                            pos = 0
                            ;
                            try
                            {
                                for (; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 26418, 26588) || true) && (pos < 10)
       ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 26435, 26440)
       , pos++, DynAbs.Tracing.TraceSender.TraceExitCondition(1540, 26418, 26588))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1540, 26418, 26588);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 26490, 26565) || true) && ((positionsBound & (1 << pos)) == 0)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1540, 26490, 26565);
                                        DynAbs.Tracing.TraceSender.TraceBreak(1540, 26559, 26565);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1540, 26490, 26565);
                                    }
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1540, 1, 171);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1540, 1, 171);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 26612, 26639);

                            positionsBound |= 1 << pos;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 26803, 27263);
                                foreach (var parameterInfo in f_1540_26833_26853_I(parameterBindingInfo))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1540, 26803, 27263);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 26903, 27240) || true) && (parameterInfo.position == pos)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1540, 26903, 27240);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 26994, 27213);

                                        result[parameterInfo.name] = f_1540_27023_27212(f_1540_27090_27119(f_1540_27090_27116(commandAst), i), null, GetSafeValueVisitor.SafeValueContext.ModuleAnalysis);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1540, 26903, 27240);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1540, 26803, 27263);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1540, 1, 461);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1540, 1, 461);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1540, 23353, 27282);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1540, 1, 4172);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1540, 1, 4172);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 27313, 27327);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1540, 22802, 27338);

                System.StringComparer
                f_1540_22939_22971()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 22939, 22971);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1540_22925_22972(System.StringComparer
                equalityComparer)
                {
                    var return_v = new System.Collections.Hashtable((System.Collections.IEqualityComparer)equalityComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 22925, 22972);
                    return return_v;
                }


                System.Management.Automation.ExportVisitor.ParameterBindingInfo
                f_1540_23016_23056(System.Collections.Generic.Dictionary<string, System.Management.Automation.ExportVisitor.ParameterBindingInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 23016, 23056);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                f_1540_23146_23172(System.Management.Automation.Language.CommandAst
                this_param)
                {
                    var return_v = this_param.CommandElements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 23146, 23172);
                    return return_v;
                }


                int
                f_1540_23146_23178(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 23146, 23178);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                f_1540_23231_23257(System.Management.Automation.Language.CommandAst
                this_param)
                {
                    var return_v = this_param.CommandElements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 23231, 23257);
                    return return_v;
                }


                System.Management.Automation.Language.CommandElementAst
                f_1540_23231_23260(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 23231, 23260);
                    return return_v;
                }


                string
                f_1540_23500_23532(System.Management.Automation.Language.CommandParameterAst
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 23500, 23532);
                    return return_v;
                }


                bool
                f_1540_23659_23744(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 23659, 23744);
                    return return_v;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1540_24027_24054(System.Management.Automation.Language.CommandParameterAst
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 24027, 24054);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                f_1540_24188_24214(System.Management.Automation.Language.CommandAst
                this_param)
                {
                    var return_v = this_param.CommandElements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 24188, 24214);
                    return return_v;
                }


                System.Management.Automation.Language.CommandElementAst
                f_1540_24188_24217(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 24188, 24217);
                    return return_v;
                }


                object
                f_1540_24682_24786(System.Management.Automation.Language.ExpressionAst
                ast, System.Management.Automation.ExecutionContext
                context, System.Management.Automation.Language.GetSafeValueVisitor.SafeValueContext
                safeValueContext)
                {
                    var return_v = GetSafeValueVisitor.GetSafeValue((System.Management.Automation.Language.Ast)ast, context, safeValueContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 24682, 24786);
                    return return_v;
                }


                System.Management.Automation.ExportVisitor.ParameterInfo[]
                f_1540_23585_23605_I(System.Management.Automation.ExportVisitor.ParameterInfo[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 23585, 23605);
                    return return_v;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1540_24952_24979(System.Management.Automation.Language.CommandParameterAst
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 24952, 24979);
                    return return_v;
                }


                bool
                f_1540_25098_25175(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 25098, 25175);
                    return return_v;
                }


                bool
                f_1540_25205_25279(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 25205, 25279);
                    return return_v;
                }


                bool
                f_1540_25309_25385(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 25309, 25385);
                    return return_v;
                }


                bool
                f_1540_25415_25490(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 25415, 25490);
                    return return_v;
                }


                bool
                f_1540_25520_25603(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 25520, 25603);
                    return return_v;
                }


                bool
                f_1540_25633_25709(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 25633, 25709);
                    return return_v;
                }


                bool
                f_1540_25739_25813(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 25739, 25813);
                    return return_v;
                }


                bool
                f_1540_25843_25931(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 25843, 25931);
                    return return_v;
                }


                bool
                f_1540_25961_26039(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 25961, 26039);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                f_1540_27090_27116(System.Management.Automation.Language.CommandAst
                this_param)
                {
                    var return_v = this_param.CommandElements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 27090, 27116);
                    return return_v;
                }


                System.Management.Automation.Language.CommandElementAst
                f_1540_27090_27119(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 27090, 27119);
                    return return_v;
                }


                object
                f_1540_27023_27212(System.Management.Automation.Language.CommandElementAst
                ast, System.Management.Automation.ExecutionContext
                context, System.Management.Automation.Language.GetSafeValueVisitor.SafeValueContext
                safeValueContext)
                {
                    var return_v = GetSafeValueVisitor.GetSafeValue((System.Management.Automation.Language.Ast)ast, context, safeValueContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 27023, 27212);
                    return return_v;
                }


                System.Management.Automation.ExportVisitor.ParameterInfo[]
                f_1540_26833_26853_I(System.Management.Automation.ExportVisitor.ParameterInfo[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 26833, 26853);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1540, 22802, 27338);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1540, 22802, 27338);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Dictionary<string, ParameterBindingInfo> s_parameterBindingInfoTable;
        private class ParameterBindingInfo
        {
            internal ParameterInfo[] parameterInfo;

            public ParameterBindingInfo()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1540, 27446, 27555);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 27530, 27543);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1540, 27446, 27555);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1540, 27446, 27555);
            }


            static ParameterBindingInfo()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1540, 27446, 27555);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1540, 27446, 27555);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1540, 27446, 27555);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1540, 27446, 27555);
        }

        private struct ParameterInfo
        {

            internal string name;

            internal int position;
            static ParameterInfo()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1540, 27567, 27688);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1540, 27567, 27688);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1540, 27567, 27688);
            }
        }
        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1540, 5025, 27695);

        System.Collections.Generic.List<string>
        f_1540_5216_5234()
        {
            var return_v = new System.Collections.Generic.List<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 5216, 5234);
            return return_v;
        }


        System.StringComparer
        f_1540_5317_5349()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 5317, 5349);
            return return_v;
        }


        System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.FunctionDefinitionAst>
        f_1540_5271_5350(System.StringComparer
        comparer)
        {
            var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.FunctionDefinitionAst>((System.Collections.Generic.IEqualityComparer<string>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 5271, 5350);
            return return_v;
        }


        System.StringComparer
        f_1540_5416_5448()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 5416, 5448);
            return return_v;
        }


        System.Collections.Generic.Dictionary<string, string>
        f_1540_5385_5449(System.StringComparer
        comparer)
        {
            var return_v = new System.Collections.Generic.Dictionary<string, string>((System.Collections.Generic.IEqualityComparer<string>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 5385, 5449);
            return return_v;
        }


        System.Collections.Generic.List<System.Management.Automation.RequiredModuleInfo>
        f_1540_5484_5514()
        {
            var return_v = new System.Collections.Generic.List<System.Management.Automation.RequiredModuleInfo>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 5484, 5514);
            return return_v;
        }


        System.Collections.Generic.List<string>
        f_1540_5556_5574()
        {
            var return_v = new System.Collections.Generic.List<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 5556, 5574);
            return return_v;
        }


        System.Collections.Generic.List<System.Management.Automation.Language.TypeDefinitionAst>
        f_1540_5609_5638()
        {
            var return_v = new System.Collections.Generic.List<System.Management.Automation.Language.TypeDefinitionAst>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1540, 5609, 5638);
            return return_v;
        }


        static System.StringComparer
        f_1540_6689_6721()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1540, 6689, 6721);
            return return_v;
        }

    }
    [Serializable]
    internal class RequiredModuleInfo
    {
        internal string Name { get; set; }

        internal List<string> CommandsToPostFilter { get; set; }

        public RequiredModuleInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1540, 27819, 27996);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 27889, 27923);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1540, 27933, 27989);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1540, 27819, 27996);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1540, 27819, 27996);
        }


        static RequiredModuleInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1540, 27819, 27996);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1540, 27819, 27996);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1540, 27819, 27996);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1540, 27819, 27996);
    }
}
