// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Management.Automation.Runspaces;
using System.Text;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation.Internal
{
    internal static class ModuleUtils
    {
        private static readonly System.IO.EnumerationOptions s_defaultEnumerationOptions;

        private static readonly System.IO.EnumerationOptions s_uncPathEnumerationOptions;

        private static readonly string EnCulturePath;

        private static readonly string EnUsCulturePath;

        internal static bool IsPossibleResourceDirectory(string dir)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1534, 1906, 3141);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 2057, 2271) || true) && (f_1534_2061_2124(dir, EnCulturePath, StringComparison.OrdinalIgnoreCase) || (DynAbs.Tracing.TraceSender.Expression_False(1534, 2061, 2210) || f_1534_2145_2210(dir, EnUsCulturePath, StringComparison.OrdinalIgnoreCase)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 2057, 2271);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 2244, 2256);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 2057, 2271);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 2287, 2315);

                dir = f_1534_2293_2314(dir);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 2457, 3101) || true) && ((f_1534_2462_2472(dir) == 2 && (DynAbs.Tracing.TraceSender.Expression_True(1534, 2462, 2502) && f_1534_2481_2502(f_1534_2495_2501(dir, 0))) && (DynAbs.Tracing.TraceSender.Expression_True(1534, 2462, 2527) && f_1534_2506_2527(f_1534_2520_2526(dir, 1))))
                || (DynAbs.Tracing.TraceSender.Expression_False(1534, 2461, 2702) || (f_1534_2567_2577(dir) == 5 && (DynAbs.Tracing.TraceSender.Expression_True(1534, 2567, 2607) && f_1534_2586_2607(f_1534_2600_2606(dir, 0))) && (DynAbs.Tracing.TraceSender.Expression_True(1534, 2567, 2632) && f_1534_2611_2632(f_1534_2625_2631(dir, 1))) && (DynAbs.Tracing.TraceSender.Expression_True(1534, 2567, 2651) && (f_1534_2637_2643(dir, 2) == '-')) && (DynAbs.Tracing.TraceSender.Expression_True(1534, 2567, 2676) && f_1534_2655_2676(f_1534_2669_2675(dir, 3))) && (DynAbs.Tracing.TraceSender.Expression_True(1534, 2567, 2701) && f_1534_2680_2701(f_1534_2694_2700(dir, 4))))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 2457, 3101);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 2947, 2986);

                        var
                        cultureInfo = f_1534_2965_2985(dir)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 3008, 3040);

                        return f_1534_3015_3031(cultureInfo) != 4096;
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1534, 3077, 3086);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1534, 3077, 3086);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 2457, 3101);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 3117, 3130);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1534, 1906, 3141);

                bool
                f_1534_2061_2124(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.EndsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 2061, 2124);
                    return return_v;
                }


                bool
                f_1534_2145_2210(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.EndsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 2145, 2210);
                    return return_v;
                }


                string?
                f_1534_2293_2314(string
                path)
                {
                    var return_v = Path.GetFileName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 2293, 2314);
                    return return_v;
                }


                int
                f_1534_2462_2472(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 2462, 2472);
                    return return_v;
                }


                char
                f_1534_2495_2501(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 2495, 2501);
                    return return_v;
                }


                bool
                f_1534_2481_2502(char
                c)
                {
                    var return_v = char.IsLetter(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 2481, 2502);
                    return return_v;
                }


                char
                f_1534_2520_2526(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 2520, 2526);
                    return return_v;
                }


                bool
                f_1534_2506_2527(char
                c)
                {
                    var return_v = char.IsLetter(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 2506, 2527);
                    return return_v;
                }


                int
                f_1534_2567_2577(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 2567, 2577);
                    return return_v;
                }


                char
                f_1534_2600_2606(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 2600, 2606);
                    return return_v;
                }


                bool
                f_1534_2586_2607(char
                c)
                {
                    var return_v = char.IsLetter(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 2586, 2607);
                    return return_v;
                }


                char
                f_1534_2625_2631(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 2625, 2631);
                    return return_v;
                }


                bool
                f_1534_2611_2632(char
                c)
                {
                    var return_v = char.IsLetter(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 2611, 2632);
                    return return_v;
                }


                char
                f_1534_2637_2643(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 2637, 2643);
                    return return_v;
                }


                char
                f_1534_2669_2675(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 2669, 2675);
                    return return_v;
                }


                bool
                f_1534_2655_2676(char
                c)
                {
                    var return_v = char.IsLetter(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 2655, 2676);
                    return return_v;
                }


                char
                f_1534_2694_2700(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 2694, 2700);
                    return return_v;
                }


                bool
                f_1534_2680_2701(char
                c)
                {
                    var return_v = char.IsLetter(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 2680, 2701);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1534_2965_2985(string
                name)
                {
                    var return_v = new System.Globalization.CultureInfo(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 2965, 2985);
                    return return_v;
                }


                int
                f_1534_3015_3031(System.Globalization.CultureInfo
                this_param)
                {
                    var return_v = this_param.LCID;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 3015, 3031);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1534, 1906, 3141);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1534, 1906, 3141);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static IEnumerable<string> GetAllAvailableModuleFiles(string topDirectoryToCheck)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1534, 3361, 5190);

                var listYield = new List<String>();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 3476, 3536) || true) && (!f_1534_3481_3518(topDirectoryToCheck))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 3476, 3536);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 3522, 3534);

                    return listYield;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 3476, 3536);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 3552, 3663);

                var
                options = (DynAbs.Tracing.TraceSender.Conditional_F1(1534, 3566, 3602) || ((f_1534_3566_3602(topDirectoryToCheck) && DynAbs.Tracing.TraceSender.Conditional_F2(1534, 3605, 3632)) || DynAbs.Tracing.TraceSender.Conditional_F3(1534, 3635, 3662))) ? s_uncPathEnumerationOptions : s_defaultEnumerationOptions
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 3677, 3732);

                Queue<string>
                directoriesToCheck = f_1534_3712_3731()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 3746, 3794);

                f_1534_3746_3793(directoriesToCheck, topDirectoryToCheck);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 3810, 3835);

                bool
                firstSubDirs = true
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 3849, 5179) || true) && (f_1534_3856_3880(directoriesToCheck) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 3849, 5179);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 3918, 3973);

                        string
                        directoryToCheck = f_1534_3944_3972(directoriesToCheck)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 4035, 4118);

                            string[]
                            subDirectories = f_1534_4061_4117(directoryToCheck, "*", options)
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 4140, 4426);
                                foreach (string toAdd in f_1534_4165_4179_I(subDirectories))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 4140, 4426);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 4229, 4403) || true) && (firstSubDirs || (DynAbs.Tracing.TraceSender.Expression_False(1534, 4233, 4284) || !f_1534_4250_4284(toAdd)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 4229, 4403);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 4342, 4376);

                                        f_1534_4342_4375(directoriesToCheck, toAdd);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 4229, 4403);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 4140, 4426);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1534, 1, 287);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1534, 1, 287);
                            }
                        }
                        catch (IOException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1534, 4463, 4486);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1534, 4463, 4486);
                        }
                        catch (UnauthorizedAccessException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1534, 4504, 4543);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1534, 4504, 4543);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 4563, 4584);

                        firstSubDirs = false;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 4602, 4670);

                        string[]
                        files = f_1534_4619_4669(directoryToCheck, "*", options)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 4688, 5164);
                            foreach (string moduleFile in f_1534_4718_4723_I(files))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 4688, 5164);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 4765, 5145);
                                    foreach (string ext in f_1534_4788_4823_I(ModuleIntrinsics.PSModuleExtensions))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 4765, 5145);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 4873, 5122) || true) && (f_1534_4877_4937(moduleFile, ext, StringComparison.OrdinalIgnoreCase))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 4873, 5122);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 4995, 5019);

                                            listYield.Add(moduleFile);
                                            DynAbs.Tracing.TraceSender.TraceBreak(1534, 5049, 5055);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 4873, 5122);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 4765, 5145);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1534, 1, 381);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1534, 1, 381);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 4688, 5164);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1534, 1, 477);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1534, 1, 477);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 3849, 5179);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1534, 3849, 5179);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1534, 3849, 5179);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1534, 3361, 5190);

                return listYield;

                bool
                f_1534_3481_3518(string
                path)
                {
                    var return_v = Directory.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 3481, 3518);
                    return return_v;
                }


                bool
                f_1534_3566_3602(string
                path)
                {
                    var return_v = Utils.PathIsUnc(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 3566, 3602);
                    return return_v;
                }


                System.Collections.Generic.Queue<string>
                f_1534_3712_3731()
                {
                    var return_v = new System.Collections.Generic.Queue<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 3712, 3731);
                    return return_v;
                }


                int
                f_1534_3746_3793(System.Collections.Generic.Queue<string>
                this_param, string
                item)
                {
                    this_param.Enqueue(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 3746, 3793);
                    return 0;
                }


                int
                f_1534_3856_3880(System.Collections.Generic.Queue<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 3856, 3880);
                    return return_v;
                }


                string
                f_1534_3944_3972(System.Collections.Generic.Queue<string>
                this_param)
                {
                    var return_v = this_param.Dequeue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 3944, 3972);
                    return return_v;
                }


                string[]
                f_1534_4061_4117(string
                path, string
                searchPattern, System.IO.EnumerationOptions
                enumerationOptions)
                {
                    var return_v = Directory.GetDirectories(path, searchPattern, enumerationOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 4061, 4117);
                    return return_v;
                }


                bool
                f_1534_4250_4284(string
                dir)
                {
                    var return_v = IsPossibleResourceDirectory(dir);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 4250, 4284);
                    return return_v;
                }


                int
                f_1534_4342_4375(System.Collections.Generic.Queue<string>
                this_param, string
                item)
                {
                    this_param.Enqueue(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 4342, 4375);
                    return 0;
                }


                string[]
                f_1534_4165_4179_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 4165, 4179);
                    return return_v;
                }


                string[]
                f_1534_4619_4669(string
                path, string
                searchPattern, System.IO.EnumerationOptions
                enumerationOptions)
                {
                    var return_v = Directory.GetFiles(path, searchPattern, enumerationOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 4619, 4669);
                    return return_v;
                }


                bool
                f_1534_4877_4937(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.EndsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 4877, 4937);
                    return return_v;
                }


                string[]
                f_1534_4788_4823_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 4788, 4823);
                    return return_v;
                }


                string[]
                f_1534_4718_4723_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 4718, 4723);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1534, 3361, 5190);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1534, 3361, 5190);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsPSEditionCompatible(
                    string moduleManifestPath,
                    IEnumerable<string> compatiblePSEditions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1534, 5737, 6154);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 5943, 6063) || true) && (!f_1534_5948_6002(moduleManifestPath))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 5943, 6063);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 6036, 6048);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 5943, 6063);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 6079, 6135);

                return f_1534_6086_6134(compatiblePSEditions);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1534, 5737, 6154);

                bool
                f_1534_5948_6002(string
                path)
                {
                    var return_v = ModuleUtils.IsOnSystem32ModulePath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 5948, 6002);
                    return return_v;
                }


                bool
                f_1534_6086_6134(System.Collections.Generic.IEnumerable<string>
                editions)
                {
                    var return_v = Utils.IsPSEditionSupported(editions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 6086, 6134);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1534, 5737, 6154);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1534, 5737, 6154);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static IEnumerable<string> GetDefaultAvailableModuleFiles(bool isForAutoDiscovery, ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1534, 6166, 8463);

                var listYield = new List<String>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 6308, 6398);

                HashSet<string>
                uniqueModuleFiles = f_1534_6344_6397(f_1534_6364_6396())
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 6414, 8452);
                    foreach (string directory in f_1534_6443_6502_I(f_1534_6443_6502(isForAutoDiscovery, context)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 6414, 8452);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 6536, 6575);

                        var
                        needWriteProgressCompleted = false
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 6593, 6632);

                        ProgressRecord
                        analysisProgress = null
                        ;

                        // Write a progress message for UNC paths, so that users know what is happening
                        try
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 6793, 7453) || true) && ((f_1534_6798_6829(context) != null) && (DynAbs.Tracing.TraceSender.Expression_True(1534, 6797, 6868) && f_1534_6842_6868(directory)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 6793, 7453);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 6918, 7263);

                                analysisProgress = new ProgressRecord(0,
                                f_1534_6988_7023(),
                                f_1534_7054_7135(f_1534_7068_7096(), f_1534_7098_7123(), directory))
                                {
                                    RecordType = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => ProgressRecordType.Processing, 1534, 6937, 7262)
                                };
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 7291, 7370);

                                f_1534_7291_7369(f_1534_7291_7337(f_1534_7291_7322(context)), analysisProgress);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 7396, 7430);

                                needWriteProgressCompleted = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 6793, 7453);
                            }
                        }
                        catch (InvalidOperationException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1534, 7490, 7700);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1534, 7490, 7700);
                            // This may be called when we are not allowed to write progress,
                            // So eat the invalid operation
                        }

                        try
                        {
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 7764, 8066);
                                foreach (string moduleFile in f_1534_7794_7847_I(f_1534_7794_7847(directory)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 7764, 8066);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 7897, 8043) || true) && (f_1534_7901_7934(uniqueModuleFiles, moduleFile))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 7897, 8043);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 7992, 8016);

                                        listYield.Add(moduleFile);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 7897, 8043);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 7764, 8066);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1534, 1, 303);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1534, 1, 303);
                            }
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinally(1534, 8103, 8437);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 8151, 8418) || true) && (needWriteProgressCompleted)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 8151, 8418);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 8231, 8290);

                                analysisProgress.RecordType = ProgressRecordType.Completed;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 8316, 8395);

                                f_1534_8316_8394(f_1534_8316_8362(f_1534_8316_8347(context)), analysisProgress);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 8151, 8418);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitFinally(1534, 8103, 8437);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 6414, 8452);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1534, 1, 2039);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1534, 1, 2039);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1534, 6166, 8463);

                return listYield;

                System.StringComparer
                f_1534_6364_6396()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 6364, 6396);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_1534_6344_6397(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.HashSet<string>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 6344, 6397);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1534_6443_6502(bool
                includeSystemModulePath, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = ModuleIntrinsics.GetModulePath(includeSystemModulePath, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 6443, 6502);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1534_6798_6829(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentCommandProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 6798, 6829);
                    return return_v;
                }


                bool
                f_1534_6842_6868(string
                path)
                {
                    var return_v = Utils.PathIsUnc(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 6842, 6868);
                    return return_v;
                }


                string
                f_1534_6988_7023()
                {
                    var return_v = Modules.DeterminingAvailableModules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 6988, 7023);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1534_7068_7096()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 7068, 7096);
                    return return_v;
                }


                string
                f_1534_7098_7123()
                {
                    var return_v = Modules.SearchingUncShare;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 7098, 7123);
                    return return_v;
                }


                string
                f_1534_7054_7135(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 7054, 7135);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1534_7291_7322(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentCommandProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 7291, 7322);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1534_7291_7337(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 7291, 7337);
                    return return_v;
                }


                int
                f_1534_7291_7369(System.Management.Automation.MshCommandRuntime
                this_param, System.Management.Automation.ProgressRecord
                progressRecord)
                {
                    this_param.WriteProgress(progressRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 7291, 7369);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1534_7794_7847(string
                topDirectoryToCheck)
                {
                    var return_v = ModuleUtils.GetDefaultAvailableModuleFiles(topDirectoryToCheck);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 7794, 7847);
                    return return_v;
                }


                bool
                f_1534_7901_7934(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 7901, 7934);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1534_7794_7847_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 7794, 7847);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1534_8316_8347(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentCommandProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 8316, 8347);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1534_8316_8362(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 8316, 8362);
                    return return_v;
                }


                int
                f_1534_8316_8394(System.Management.Automation.MshCommandRuntime
                this_param, System.Management.Automation.ProgressRecord
                progressRecord)
                {
                    this_param.WriteProgress(progressRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 8316, 8394);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1534_6443_6502_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 6443, 6502);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1534, 6166, 8463);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1534, 6166, 8463);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static List<string> GetModuleFilesFromAbsolutePath(string directory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1534, 8757, 11351);
                System.Version? ver = default(System.Version?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 8859, 8900);

                List<string>
                result = f_1534_8881_8899()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 8914, 8960);

                string
                fileName = f_1534_8932_8959(directory)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 9081, 9167) || true) && (!f_1534_9086_9113(directory) || (DynAbs.Tracing.TraceSender.Expression_False(1534, 9085, 9147) || f_1534_9117_9147(fileName)))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 9081, 9167);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 9151, 9165);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 9081, 9167);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 9300, 10150) || true) && (f_1534_9304_9347(fileName, out ver))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 9300, 10150);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 9381, 9437);

                    string
                    parentDirPath = f_1534_9404_9436(directory)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 9455, 9510);

                    string
                    parentDirName = f_1534_9478_9509(parentDirPath)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 9632, 10135) || true) && (!f_1534_9637_9672(parentDirName))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 9632, 10135);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 9714, 9775);

                        string
                        manifestPath = f_1534_9736_9774(directory, parentDirName)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 9797, 9856);

                        manifestPath += StringLiterals.PowerShellDataFileExtension;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 9878, 10116) || true) && (f_1534_9882_9907(manifestPath) && (DynAbs.Tracing.TraceSender.Expression_True(1534, 9882, 9978) && f_1534_9911_9978(ver, f_1534_9922_9977(manifestPath))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 9878, 10116);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 10028, 10053);

                            f_1534_10028_10052(result, manifestPath);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 10079, 10093);

                            return result;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 9878, 10116);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 9632, 10135);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 9300, 10150);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 10251, 10726);
                    foreach (Version version in f_1534_10279_10316_I(f_1534_10279_10316(directory)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 10251, 10726);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 10350, 10426);

                        string
                        manifestPath = f_1534_10372_10425(directory, f_1534_10396_10414(version), fileName)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 10444, 10503);

                        manifestPath += StringLiterals.PowerShellDataFileExtension;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 10521, 10711) || true) && (f_1534_10525_10550(manifestPath) && (DynAbs.Tracing.TraceSender.Expression_True(1534, 10525, 10625) && f_1534_10554_10625(version, f_1534_10569_10624(manifestPath))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 10521, 10711);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 10667, 10692);

                            f_1534_10667_10691(result, manifestPath);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 10521, 10711);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 10251, 10726);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1534, 1, 476);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1534, 1, 476);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 10742, 11310);
                    foreach (string ext in f_1534_10765_10800_I(ModuleIntrinsics.PSModuleExtensions))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 10742, 11310);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 10834, 10894);

                        string
                        moduleFile = f_1534_10854_10887(directory, fileName) + ext
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 10912, 11295) || true) && (f_1534_10916_10939(moduleFile))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 10912, 11295);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 10981, 11004);

                            f_1534_10981_11003(result, moduleFile);
                            DynAbs.Tracing.TraceSender.TraceBreak(1534, 11270, 11276);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 10912, 11295);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 10742, 11310);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1534, 1, 569);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1534, 1, 569);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 11326, 11340);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1534, 8757, 11351);

                System.Collections.Generic.List<string>
                f_1534_8881_8899()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 8881, 8899);
                    return return_v;
                }


                string?
                f_1534_8932_8959(string
                path)
                {
                    var return_v = Path.GetFileName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 8932, 8959);
                    return return_v;
                }


                bool
                f_1534_9086_9113(string
                path)
                {
                    var return_v = Directory.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 9086, 9113);
                    return return_v;
                }


                bool
                f_1534_9117_9147(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 9117, 9147);
                    return return_v;
                }


                bool
                f_1534_9304_9347(string
                input, out System.Version
                result)
                {
                    var return_v = Version.TryParse(input, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 9304, 9347);
                    return return_v;
                }


                string?
                f_1534_9404_9436(string
                path)
                {
                    var return_v = Path.GetDirectoryName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 9404, 9436);
                    return return_v;
                }


                string?
                f_1534_9478_9509(string
                path)
                {
                    var return_v = Path.GetFileName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 9478, 9509);
                    return return_v;
                }


                bool
                f_1534_9637_9672(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 9637, 9672);
                    return return_v;
                }


                string
                f_1534_9736_9774(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 9736, 9774);
                    return return_v;
                }


                bool
                f_1534_9882_9907(string
                path)
                {
                    var return_v = File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 9882, 9907);
                    return return_v;
                }


                System.Version
                f_1534_9922_9977(string
                manifestPath)
                {
                    var return_v = ModuleIntrinsics.GetManifestModuleVersion(manifestPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 9922, 9977);
                    return return_v;
                }


                bool
                f_1534_9911_9978(System.Version
                this_param, System.Version
                obj)
                {
                    var return_v = this_param.Equals(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 9911, 9978);
                    return return_v;
                }


                int
                f_1534_10028_10052(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 10028, 10052);
                    return 0;
                }


                System.Collections.Generic.List<System.Version>
                f_1534_10279_10316(string
                moduleBase)
                {
                    var return_v = GetModuleVersionSubfolders(moduleBase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 10279, 10316);
                    return return_v;
                }


                string
                f_1534_10396_10414(System.Version
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 10396, 10414);
                    return return_v;
                }


                string
                f_1534_10372_10425(string
                path1, string
                path2, string
                path3)
                {
                    var return_v = Path.Combine(path1, path2, path3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 10372, 10425);
                    return return_v;
                }


                bool
                f_1534_10525_10550(string
                path)
                {
                    var return_v = File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 10525, 10550);
                    return return_v;
                }


                System.Version
                f_1534_10569_10624(string
                manifestPath)
                {
                    var return_v = ModuleIntrinsics.GetManifestModuleVersion(manifestPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 10569, 10624);
                    return return_v;
                }


                bool
                f_1534_10554_10625(System.Version
                this_param, System.Version
                obj)
                {
                    var return_v = this_param.Equals(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 10554, 10625);
                    return return_v;
                }


                int
                f_1534_10667_10691(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 10667, 10691);
                    return 0;
                }


                System.Collections.Generic.List<System.Version>
                f_1534_10279_10316_I(System.Collections.Generic.List<System.Version>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 10279, 10316);
                    return return_v;
                }


                string
                f_1534_10854_10887(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 10854, 10887);
                    return return_v;
                }


                bool
                f_1534_10916_10939(string
                path)
                {
                    var return_v = File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 10916, 10939);
                    return return_v;
                }


                int
                f_1534_10981_11003(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 10981, 11003);
                    return 0;
                }


                string[]
                f_1534_10765_10800_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 10765, 10800);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1534, 8757, 11351);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1534, 8757, 11351);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static IEnumerable<string> GetDefaultAvailableModuleFiles(string topDirectoryToCheck)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1534, 11617, 15086);

                var listYield = new List<String>();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 11736, 11796) || true) && (!f_1534_11741_11778(topDirectoryToCheck))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 11736, 11796);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 11782, 11794);

                    return listYield;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 11736, 11796);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 11812, 11923);

                var
                options = (DynAbs.Tracing.TraceSender.Conditional_F1(1534, 11826, 11862) || ((f_1534_11826_11862(topDirectoryToCheck) && DynAbs.Tracing.TraceSender.Conditional_F2(1534, 11865, 11892)) || DynAbs.Tracing.TraceSender.Conditional_F3(1534, 11895, 11922))) ? s_uncPathEnumerationOptions : s_defaultEnumerationOptions
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 11937, 11992);

                List<Version>
                versionDirectories = f_1534_11972_11991()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 12006, 12071);

                LinkedList<string>
                directoriesToCheck = f_1534_12046_12070()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 12085, 12133);

                f_1534_12085_12132(directoriesToCheck, topDirectoryToCheck);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 12149, 15075) || true) && (f_1534_12156_12180(directoriesToCheck) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 12149, 15075);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 12218, 12245);

                        f_1534_12218_12244(versionDirectories);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 12263, 12287);

                        string[]
                        subdirectories
                        = default(string[]);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 12305, 12362);

                        string
                        directoryToCheck = f_1534_12331_12361(f_1534_12331_12355(directoriesToCheck))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 12380, 12413);

                        f_1534_12380_12412(directoriesToCheck);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 12475, 12549);

                            subdirectories = f_1534_12492_12548(directoryToCheck, "*", options);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 12571, 12644);

                            f_1534_12571_12643(subdirectories, versionDirectories);
                        }
                        catch (IOException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1534, 12681, 12744);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 12703, 12742);

                            subdirectories = f_1534_12720_12741();
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1534, 12681, 12744);
                        }
                        catch (UnauthorizedAccessException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1534, 12762, 12841);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 12800, 12839);

                            subdirectories = f_1534_12817_12838();
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1534, 12762, 12841);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 12861, 12892);

                        bool
                        isModuleDirectory = false
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 12910, 12973);

                        string
                        proposedModuleName = f_1534_12938_12972(directoryToCheck)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 12991, 13473);
                            foreach (Version version in f_1534_13019_13037_I(versionDirectories))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 12991, 13473);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 13079, 13172);

                                string
                                manifestPath = f_1534_13101_13171(directoryToCheck, f_1534_13132_13150(version), proposedModuleName)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 13194, 13253);

                                manifestPath += StringLiterals.PowerShellDataFileExtension;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 13275, 13454) || true) && (f_1534_13279_13304(manifestPath))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 13275, 13454);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 13354, 13379);

                                    isModuleDirectory = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 13405, 13431);

                                    listYield.Add(manifestPath);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 13275, 13454);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 12991, 13473);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1534, 1, 483);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1534, 1, 483);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 13493, 14341) || true) && (!isModuleDirectory)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 13493, 14341);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 13557, 14322);
                                foreach (string ext in f_1534_13580_13615_I(ModuleIntrinsics.PSModuleExtensions))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 13557, 14322);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 13665, 13742);

                                    string
                                    moduleFile = f_1534_13685_13735(directoryToCheck, proposedModuleName) + ext
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 13768, 14299) || true) && (f_1534_13772_13795(moduleFile))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 13768, 14299);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 13853, 13878);

                                        isModuleDirectory = true;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 13908, 13932);

                                        listYield.Add(moduleFile);
                                        DynAbs.Tracing.TraceSender.TraceBreak(1534, 14266, 14272);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 13768, 14299);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 13557, 14322);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1534, 1, 766);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1534, 1, 766);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 13493, 14341);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 14361, 15060) || true) && (!isModuleDirectory)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 14361, 15060);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 14425, 15041);
                                foreach (var subdirectory in f_1534_14454_14468_I(subdirectories))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 14425, 15041);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 14518, 15018) || true) && (f_1534_14522_14614(subdirectory, "Microsoft.PowerShell.Management", StringComparison.OrdinalIgnoreCase) || (DynAbs.Tracing.TraceSender.Expression_False(1534, 14522, 14736) || f_1534_14647_14736(subdirectory, "Microsoft.PowerShell.Utility", StringComparison.OrdinalIgnoreCase)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 14518, 15018);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 14794, 14836);

                                        f_1534_14794_14835(directoriesToCheck, subdirectory);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 14518, 15018);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 14518, 15018);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 14950, 14991);

                                        f_1534_14950_14990(directoriesToCheck, subdirectory);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 14518, 15018);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 14425, 15041);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1534, 1, 617);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1534, 1, 617);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 14361, 15060);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 12149, 15075);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1534, 12149, 15075);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1534, 12149, 15075);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1534, 11617, 15086);

                return listYield;

                bool
                f_1534_11741_11778(string
                path)
                {
                    var return_v = Directory.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 11741, 11778);
                    return return_v;
                }


                bool
                f_1534_11826_11862(string
                path)
                {
                    var return_v = Utils.PathIsUnc(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 11826, 11862);
                    return return_v;
                }


                System.Collections.Generic.List<System.Version>
                f_1534_11972_11991()
                {
                    var return_v = new System.Collections.Generic.List<System.Version>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 11972, 11991);
                    return return_v;
                }


                System.Collections.Generic.LinkedList<string>
                f_1534_12046_12070()
                {
                    var return_v = new System.Collections.Generic.LinkedList<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 12046, 12070);
                    return return_v;
                }


                System.Collections.Generic.LinkedListNode<string>
                f_1534_12085_12132(System.Collections.Generic.LinkedList<string>
                this_param, string
                value)
                {
                    var return_v = this_param.AddLast(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 12085, 12132);
                    return return_v;
                }


                int
                f_1534_12156_12180(System.Collections.Generic.LinkedList<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 12156, 12180);
                    return return_v;
                }


                int
                f_1534_12218_12244(System.Collections.Generic.List<System.Version>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 12218, 12244);
                    return 0;
                }


                System.Collections.Generic.LinkedListNode<string>
                f_1534_12331_12355(System.Collections.Generic.LinkedList<string>
                this_param)
                {
                    var return_v = this_param.First;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 12331, 12355);
                    return return_v;
                }


                string
                f_1534_12331_12361(System.Collections.Generic.LinkedListNode<string>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 12331, 12361);
                    return return_v;
                }


                int
                f_1534_12380_12412(System.Collections.Generic.LinkedList<string>
                this_param)
                {
                    this_param.RemoveFirst();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 12380, 12412);
                    return 0;
                }


                string[]
                f_1534_12492_12548(string
                path, string
                searchPattern, System.IO.EnumerationOptions
                enumerationOptions)
                {
                    var return_v = Directory.GetDirectories(path, searchPattern, enumerationOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 12492, 12548);
                    return return_v;
                }


                int
                f_1534_12571_12643(string[]
                subdirectories, System.Collections.Generic.List<System.Version>
                versionFolders)
                {
                    ProcessPossibleVersionSubdirectories(subdirectories, versionFolders);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 12571, 12643);
                    return 0;
                }


                string[]
                f_1534_12720_12741()
                {
                    var return_v = Array.Empty<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 12720, 12741);
                    return return_v;
                }


                string[]
                f_1534_12817_12838()
                {
                    var return_v = Array.Empty<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 12817, 12838);
                    return return_v;
                }


                string?
                f_1534_12938_12972(string
                path)
                {
                    var return_v = Path.GetFileName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 12938, 12972);
                    return return_v;
                }


                string
                f_1534_13132_13150(System.Version
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 13132, 13150);
                    return return_v;
                }


                string
                f_1534_13101_13171(string
                path1, string
                path2, string
                path3)
                {
                    var return_v = Path.Combine(path1, path2, path3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 13101, 13171);
                    return return_v;
                }


                bool
                f_1534_13279_13304(string
                path)
                {
                    var return_v = File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 13279, 13304);
                    return return_v;
                }


                System.Collections.Generic.List<System.Version>
                f_1534_13019_13037_I(System.Collections.Generic.List<System.Version>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 13019, 13037);
                    return return_v;
                }


                string
                f_1534_13685_13735(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 13685, 13735);
                    return return_v;
                }


                bool
                f_1534_13772_13795(string
                path)
                {
                    var return_v = File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 13772, 13795);
                    return return_v;
                }


                string[]
                f_1534_13580_13615_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 13580, 13615);
                    return return_v;
                }


                bool
                f_1534_14522_14614(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.EndsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 14522, 14614);
                    return return_v;
                }


                bool
                f_1534_14647_14736(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.EndsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 14647, 14736);
                    return return_v;
                }


                System.Collections.Generic.LinkedListNode<string>
                f_1534_14794_14835(System.Collections.Generic.LinkedList<string>
                this_param, string
                value)
                {
                    var return_v = this_param.AddFirst(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 14794, 14835);
                    return return_v;
                }


                System.Collections.Generic.LinkedListNode<string>
                f_1534_14950_14990(System.Collections.Generic.LinkedList<string>
                this_param, string
                value)
                {
                    var return_v = this_param.AddLast(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 14950, 14990);
                    return return_v;
                }


                string[]
                f_1534_14454_14468_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 14454, 14468);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1534, 11617, 15086);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1534, 11617, 15086);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static List<Version> GetModuleVersionSubfolders(string moduleBase)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1534, 15370, 15983);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 15470, 15511);

                var
                versionFolders = f_1534_15491_15510()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 15527, 15934) || true) && (!f_1534_15532_15569(moduleBase) && (DynAbs.Tracing.TraceSender.Expression_True(1534, 15531, 15601) && f_1534_15573_15601(moduleBase)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 15527, 15934);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 15635, 15737);

                    var
                    options = (DynAbs.Tracing.TraceSender.Conditional_F1(1534, 15649, 15676) || ((f_1534_15649_15676(moduleBase) && DynAbs.Tracing.TraceSender.Conditional_F2(1534, 15679, 15706)) || DynAbs.Tracing.TraceSender.Conditional_F3(1534, 15709, 15736))) ? s_uncPathEnumerationOptions : s_defaultEnumerationOptions
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 15755, 15832);

                    string[]
                    subdirectories = f_1534_15781_15831(moduleBase, "*", options)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 15850, 15919);

                    f_1534_15850_15918(subdirectories, versionFolders);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 15527, 15934);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 15950, 15972);

                return versionFolders;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1534, 15370, 15983);

                System.Collections.Generic.List<System.Version>
                f_1534_15491_15510()
                {
                    var return_v = new System.Collections.Generic.List<System.Version>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 15491, 15510);
                    return return_v;
                }


                bool
                f_1534_15532_15569(string
                value)
                {
                    var return_v = string.IsNullOrWhiteSpace(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 15532, 15569);
                    return return_v;
                }


                bool
                f_1534_15573_15601(string
                path)
                {
                    var return_v = Directory.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 15573, 15601);
                    return return_v;
                }


                bool
                f_1534_15649_15676(string
                path)
                {
                    var return_v = Utils.PathIsUnc(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 15649, 15676);
                    return return_v;
                }


                string[]
                f_1534_15781_15831(string
                path, string
                searchPattern, System.IO.EnumerationOptions
                enumerationOptions)
                {
                    var return_v = Directory.GetDirectories(path, searchPattern, enumerationOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 15781, 15831);
                    return return_v;
                }


                int
                f_1534_15850_15918(string[]
                subdirectories, System.Collections.Generic.List<System.Version>
                versionFolders)
                {
                    ProcessPossibleVersionSubdirectories(subdirectories, versionFolders);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 15850, 15918);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1534, 15370, 15983);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1534, 15370, 15983);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void ProcessPossibleVersionSubdirectories(string[] subdirectories, List<Version> versionFolders)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1534, 15995, 16575);
                System.Version? version = default(System.Version?);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 16131, 16425);
                    foreach (string subdir in f_1534_16157_16171_I(subdirectories))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 16131, 16425);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 16205, 16250);

                        string
                        subdirName = f_1534_16225_16249(subdir)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 16268, 16410) || true) && (f_1534_16272_16321(subdirName, out version))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 16268, 16410);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 16363, 16391);

                            f_1534_16363_16390(versionFolders, version);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 16268, 16410);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 16131, 16425);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1534, 1, 295);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1534, 1, 295);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 16441, 16564) || true) && (f_1534_16445_16465(versionFolders) > 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 16441, 16564);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 16503, 16549);

                    f_1534_16503_16548(versionFolders, (x, y) => y.CompareTo(x));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 16441, 16564);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1534, 15995, 16575);

                string?
                f_1534_16225_16249(string
                path)
                {
                    var return_v = Path.GetFileName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 16225, 16249);
                    return return_v;
                }


                bool
                f_1534_16272_16321(string
                input, out System.Version
                result)
                {
                    var return_v = Version.TryParse(input, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 16272, 16321);
                    return return_v;
                }


                int
                f_1534_16363_16390(System.Collections.Generic.List<System.Version>
                this_param, System.Version
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 16363, 16390);
                    return 0;
                }


                string[]
                f_1534_16157_16171_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 16157, 16171);
                    return return_v;
                }


                int
                f_1534_16445_16465(System.Collections.Generic.List<System.Version>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 16445, 16465);
                    return return_v;
                }


                int
                f_1534_16503_16548(System.Collections.Generic.List<System.Version>
                this_param, System.Comparison<System.Version>
                comparison)
                {
                    this_param.Sort(comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 16503, 16548);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1534, 15995, 16575);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1534, 15995, 16575);
            }
        }

        internal static bool IsModuleInVersionSubdirectory(string modulePath, out Version version)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1534, 16587, 17019);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 16702, 16717);

                version = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 16731, 16785);

                string
                folderName = f_1534_16751_16784(modulePath)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 16799, 16979) || true) && (folderName != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 16799, 16979);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 16855, 16897);

                    folderName = f_1534_16868_16896(folderName);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 16915, 16964);

                    return f_1534_16922_16963(folderName, out version);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 16799, 16979);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 16995, 17008);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1534, 16587, 17019);

                string?
                f_1534_16751_16784(string
                path)
                {
                    var return_v = Path.GetDirectoryName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 16751, 16784);
                    return return_v;
                }


                string?
                f_1534_16868_16896(string
                path)
                {
                    var return_v = Path.GetFileName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 16868, 16896);
                    return return_v;
                }


                bool
                f_1534_16922_16963(string
                input, out System.Version
                result)
                {
                    var return_v = Version.TryParse(input, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 16922, 16963);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1534, 16587, 17019);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1534, 16587, 17019);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsOnSystem32ModulePath(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1534, 17031, 17488);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 17156, 17258);

                f_1534_17156_17257(!f_1534_17168_17194(path), $"Caller to verify that {nameof(path)} is not null or empty");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 17274, 17367);

                string
                windowsPowerShellPSHomePath = f_1534_17311_17366()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 17381, 17469);

                return f_1534_17388_17468(path, windowsPowerShellPSHomePath, StringComparison.OrdinalIgnoreCase);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1534, 17031, 17488);

                bool
                f_1534_17168_17194(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 17168, 17194);
                    return return_v;
                }


                int
                f_1534_17156_17257(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 17156, 17257);
                    return 0;
                }


                string
                f_1534_17311_17366()
                {
                    var return_v = ModuleIntrinsics.GetWindowsPowerShellPSHomeModulePath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 17311, 17366);
                    return return_v;
                }


                bool
                f_1534_17388_17468(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 17388, 17468);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1534, 17031, 17488);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1534, 17031, 17488);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static IEnumerable<CommandScore> GetFuzzyMatchingCommands(string pattern, ExecutionContext context, CommandOrigin commandOrigin, bool rediscoverImportedModules = false, bool moduleVersionRequired = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1534, 18099, 18799);

                var listYield = new List<CommandScore>();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 18337, 18788);
                    foreach (CommandInfo command in f_1534_18369_18495_I(f_1534_18369_18495(pattern, context, commandOrigin, rediscoverImportedModules, moduleVersionRequired, useFuzzyMatching: true)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 18337, 18788);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 18529, 18607);

                        int
                        score = f_1534_18541_18606(f_1534_18584_18596(command), pattern)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 18625, 18773) || true) && (score <= FuzzyMatcher.MinimumDistance)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 18625, 18773);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 18708, 18754);

                            listYield.Add(f_1534_18721_18753(command, score));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 18625, 18773);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 18337, 18788);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1534, 1, 452);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1534, 1, 452);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1534, 18099, 18799);

                return listYield;

                System.Collections.Generic.IEnumerable<System.Management.Automation.CommandInfo>
                f_1534_18369_18495(string
                pattern, System.Management.Automation.ExecutionContext
                context, System.Management.Automation.CommandOrigin
                commandOrigin, bool
                rediscoverImportedModules, bool
                moduleVersionRequired, bool
                useFuzzyMatching)
                {
                    var return_v = GetMatchingCommands(pattern, context, commandOrigin, rediscoverImportedModules, moduleVersionRequired, useFuzzyMatching: useFuzzyMatching);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 18369, 18495);
                    return return_v;
                }


                string
                f_1534_18584_18596(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 18584, 18596);
                    return return_v;
                }


                int
                f_1534_18541_18606(string
                string1, string
                string2)
                {
                    var return_v = FuzzyMatcher.GetDamerauLevenshteinDistance(string1, string2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 18541, 18606);
                    return return_v;
                }


                System.Management.Automation.Internal.CommandScore
                f_1534_18721_18753(System.Management.Automation.CommandInfo
                command, int
                score)
                {
                    var return_v = new System.Management.Automation.Internal.CommandScore(command, score);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 18721, 18753);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.CommandInfo>
                f_1534_18369_18495_I(System.Collections.Generic.IEnumerable<System.Management.Automation.CommandInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 18369, 18495);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1534, 18099, 18799);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1534, 18099, 18799);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static IEnumerable<CommandInfo> GetMatchingCommands(string pattern, ExecutionContext context, CommandOrigin commandOrigin, bool rediscoverImportedModules = false, bool moduleVersionRequired = false, bool useFuzzyMatching = false, bool useAbbreviationExpansion = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1534, 19536, 29943);

                var listYield = new List<CommandInfo>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 19959, 20049);

                WildcardPattern
                commandPattern = f_1534_19992_20048(pattern, WildcardOptions.IgnoreCase)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 20065, 20175);

                CmdletInfo
                cmdletInfo = f_1534_20089_20174(f_1534_20089_20123(f_1534_20089_20109(context)), "Microsoft.PowerShell.Core\\Get-Module")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 20189, 20393);

                PSModuleAutoLoadingPreference
                moduleAutoLoadingPreference = f_1534_20249_20392(context, SpecialVariables.PSModuleAutoLoadingPreferenceVarPath, "PSModuleAutoLoadingPreference")
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 20409, 29932) || true) && ((moduleAutoLoadingPreference != PSModuleAutoLoadingPreference.None) && (DynAbs.Tracing.TraceSender.Expression_True(1534, 20413, 20635) && ((commandOrigin == CommandOrigin.Internal) || (DynAbs.Tracing.TraceSender.Expression_False(1534, 20502, 20634) || ((cmdletInfo != null) && (DynAbs.Tracing.TraceSender.Expression_True(1534, 20548, 20633) && (f_1534_20573_20594(cmdletInfo) == SessionStateEntryVisibility.Public)))))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 20409, 29932);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 20669, 29917);
                        foreach (string modulePath in f_1534_20699_20765_I(f_1534_20699_20765(isForAutoDiscovery: false, context)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 20669, 29917);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 20916, 20981);

                            string
                            moduleName = f_1534_20936_20980(modulePath)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 21003, 21111);

                            List<PSModuleInfo>
                            modules = f_1534_21032_21110(f_1534_21032_21047(context), moduleName, all: false, exactMatch: true)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 21133, 21168);

                            PSModuleInfo
                            tempModuleInfo = null
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 21192, 24604) || true) && (f_1534_21196_21209(modules) != 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 21192, 24604);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 21586, 21770) || true) && (!rediscoverImportedModules || (DynAbs.Tracing.TraceSender.Expression_False(1534, 21590, 21676) || f_1534_21620_21676(modules, module => module.ModuleHasPrivateMembers)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 21586, 21770);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 21734, 21743);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 21586, 21770);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 21798, 24581) || true) && (f_1534_21802_21815(modules) == 1)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 21798, 24581);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 21878, 21913);

                                    PSModuleInfo
                                    psModule = f_1534_21902_21912(modules, 0)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 21943, 22042);

                                    tempModuleInfo = f_1534_21960_22041(f_1534_21977_21990(psModule), f_1534_21992_22005(psModule), context: null, sessionState: null);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 22072, 22122);

                                    f_1534_22072_22121(tempModuleInfo, f_1534_22101_22120(psModule));
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 22154, 24513);
                                        foreach (KeyValuePair<string, CommandInfo> entry in f_1534_22206_22231_I(f_1534_22206_22231(psModule)))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 22154, 24513);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 22297, 24482) || true) && (f_1534_22301_22341(commandPattern, f_1534_22324_22340(entry.Value)) || (DynAbs.Tracing.TraceSender.Expression_False(1534, 22301, 22456) || (useFuzzyMatching && (DynAbs.Tracing.TraceSender.Expression_True(1534, 22383, 22455) && f_1534_22403_22455(f_1534_22429_22445(entry.Value), pattern)))) || (DynAbs.Tracing.TraceSender.Expression_False(1534, 22301, 22619) || (useAbbreviationExpansion && (DynAbs.Tracing.TraceSender.Expression_True(1534, 22498, 22618) && f_1534_22526_22618(pattern, f_1534_22549_22581(f_1534_22564_22580(entry.Value)), StringComparison.OrdinalIgnoreCase)))))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 22297, 24482);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 22693, 22720);

                                                CommandInfo
                                                current = null
                                                ;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 22758, 24316);

                                                switch (f_1534_22766_22789(entry.Value))
                                                {

                                                    case CommandTypes.Alias:
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 22758, 24316);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 22941, 23010);

                                                        current = f_1534_22951_23009(f_1534_22965_22981(entry.Value), definition: null, context);
                                                        DynAbs.Tracing.TraceSender.TraceBreak(1534, 23056, 23062);

                                                        break;
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 22758, 24316);

                                                    case CommandTypes.Function:
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 22758, 24316);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 23177, 23261);

                                                        current = f_1534_23187_23260(f_1534_23204_23220(entry.Value), ScriptBlock.EmptyScriptBlock, context);
                                                        DynAbs.Tracing.TraceSender.TraceBreak(1534, 23307, 23313);

                                                        break;
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 22758, 24316);

                                                    case CommandTypes.Filter:
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 22758, 24316);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 23426, 23508);

                                                        current = f_1534_23436_23507(f_1534_23451_23467(entry.Value), ScriptBlock.EmptyScriptBlock, context);
                                                        DynAbs.Tracing.TraceSender.TraceBreak(1534, 23554, 23560);

                                                        break;
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 22758, 24316);

                                                    case CommandTypes.Configuration:
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 22758, 24316);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 23680, 23769);

                                                        current = f_1534_23690_23768(f_1534_23712_23728(entry.Value), ScriptBlock.EmptyScriptBlock, context);
                                                        DynAbs.Tracing.TraceSender.TraceBreak(1534, 23815, 23821);

                                                        break;
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 22758, 24316);

                                                    case CommandTypes.Cmdlet:
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 22758, 24316);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 23934, 24042);

                                                        current = f_1534_23944_24041(f_1534_23959_23975(entry.Value), implementingType: null, helpFile: null, PSSnapin: null, context);
                                                        DynAbs.Tracing.TraceSender.TraceBreak(1534, 24088, 24094);

                                                        break;
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 22758, 24316);

                                                    default:
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 22758, 24316);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 24190, 24225);

                                                        f_1534_24190_24224(false, "cannot be hit");
                                                        DynAbs.Tracing.TraceSender.TraceBreak(1534, 24271, 24277);

                                                        break;
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 22758, 24316);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 24356, 24388);

                                                current.Module = tempModuleInfo;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 24426, 24447);

                                                listYield.Add(current);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 22297, 24482);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 22154, 24513);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1534, 1, 2360);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(1534, 1, 2360);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 24545, 24554);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 21798, 24581);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 21192, 24604);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 24628, 24698);

                            string
                            moduleShortName = f_1534_24653_24697(modulePath)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 24722, 24847);

                            IDictionary<string, CommandTypes>
                            exportedCommands = f_1534_24775_24846(modulePath, testOnly: false, context)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 24871, 24914) || true) && (exportedCommands == null)
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 24871, 24914);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 24903, 24912);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 24871, 24914);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 24938, 25036);

                            tempModuleInfo = f_1534_24955_25035(moduleShortName, modulePath, sessionState: null, context: null);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 25058, 25247) || true) && (f_1534_25062_25113(moduleShortName))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 25058, 25247);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 25163, 25224);

                                f_1534_25163_25223(tempModuleInfo, f_1534_25192_25222());
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 25058, 25247);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 25426, 25803) || true) && (moduleVersionRequired && (DynAbs.Tracing.TraceSender.Expression_True(1534, 25430, 25554) && f_1534_25455_25554(modulePath, StringLiterals.PowerShellDataFileExtension, StringComparison.OrdinalIgnoreCase)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 25426, 25803);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 25604, 25685);

                                f_1534_25604_25684(tempModuleInfo, f_1534_25630_25683(modulePath));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 25711, 25780);

                                f_1534_25711_25779(tempModuleInfo, f_1534_25734_25778(modulePath));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 25426, 25803);
                            }
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 25827, 29898);
                                foreach (KeyValuePair<string, CommandTypes> pair in f_1534_25879_25895_I(exportedCommands))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 25827, 29898);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 25945, 25975);

                                    string
                                    commandName = pair.Key
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 26001, 26040);

                                    CommandTypes
                                    commandTypes = pair.Value
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 26068, 29875) || true) && (f_1534_26072_26107(commandPattern, commandName) || (DynAbs.Tracing.TraceSender.Expression_False(1534, 26072, 26209) || (useFuzzyMatching && (DynAbs.Tracing.TraceSender.Expression_True(1534, 26141, 26208) && f_1534_26161_26208(commandName, pattern)))) || (DynAbs.Tracing.TraceSender.Expression_False(1534, 26072, 26359) || (useAbbreviationExpansion && (DynAbs.Tracing.TraceSender.Expression_True(1534, 26243, 26358) && f_1534_26271_26358(pattern, f_1534_26294_26321(commandName), StringComparison.OrdinalIgnoreCase)))))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 26068, 29875);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 26417, 26449);

                                        bool
                                        shouldExportCommand = true
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 26592, 27973) || true) && ((f_1534_26597_26624(context) != null) && (DynAbs.Tracing.TraceSender.Expression_True(1534, 26596, 26678) && (commandOrigin == CommandOrigin.Runspace)))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 26592, 27973);
                                            try
                                            {
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 26744, 27942);
                                                foreach (SessionStateCommandEntry commandEntry in f_1534_26794_26843_I(f_1534_26794_26843(f_1534_26794_26830(f_1534_26794_26821(context)), commandName)))
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 26744, 27942);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 26917, 26949);

                                                    string
                                                    moduleCompareName = null
                                                    ;

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 26989, 27430) || true) && (f_1534_26993_27012(commandEntry) != null)
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 26989, 27430);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 27102, 27147);

                                                        moduleCompareName = f_1534_27122_27146(f_1534_27122_27141(commandEntry));
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 26989, 27430);
                                                    }

                                                    else
                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 26989, 27430);

                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 27229, 27430) || true) && (f_1534_27233_27254(commandEntry) != null)
                                                        )

                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 27229, 27430);
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 27344, 27391);

                                                            moduleCompareName = f_1534_27364_27390(f_1534_27364_27385(commandEntry));
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 27229, 27430);
                                                        }
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 26989, 27430);
                                                    }

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 27470, 27907) || true) && (f_1534_27474_27559(moduleShortName, moduleCompareName, StringComparison.OrdinalIgnoreCase))
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 27470, 27907);

                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 27641, 27868) || true) && (f_1534_27645_27668(commandEntry) == SessionStateEntryVisibility.Private)
                                                        )

                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 27641, 27868);
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 27797, 27825);

                                                            shouldExportCommand = false;
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 27641, 27868);
                                                        }
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 27470, 27907);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 26744, 27942);
                                                }
                                            }
                                            catch (System.Exception)
                                            {
                                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1534, 1, 1199);
                                                throw;
                                            }
                                            finally
                                            {
                                                DynAbs.Tracing.TraceSender.TraceExitLoop(1534, 1, 1199);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 26592, 27973);
                                        }

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 28005, 29848) || true) && (shouldExportCommand)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 28005, 29848);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 28094, 28462) || true) && ((commandTypes & CommandTypes.Alias) == CommandTypes.Alias)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 28094, 28462);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 28229, 28427);

                                                listYield.Add(new AliasInfo(commandName, null, context)
                                                {
                                                    Module = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => tempModuleInfo, 1534, 28242, 28426)
                                                });
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 28094, 28462);
                                            }

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 28498, 28928) || true) && ((commandTypes & CommandTypes.Cmdlet) == CommandTypes.Cmdlet)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 28498, 28928);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 28635, 28893);

                                                listYield.Add(new CmdletInfo(commandName, implementingType: null, helpFile: null, PSSnapin: null, context: context)
                                                {
                                                    Module = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => tempModuleInfo, 1534, 28648, 28892)
                                                });
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 28498, 28928);
                                            }

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 28964, 29365) || true) && ((commandTypes & CommandTypes.Function) == CommandTypes.Function)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 28964, 29365);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 29105, 29330);

                                                listYield.Add(new FunctionInfo(commandName, ScriptBlock.EmptyScriptBlock, context)
                                                {
                                                    Module = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => tempModuleInfo, 1534, 29118, 29329)
                                                });
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 28964, 29365);
                                            }

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 29401, 29817) || true) && ((commandTypes & CommandTypes.Configuration) == CommandTypes.Configuration)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 29401, 29817);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 29552, 29782);

                                                listYield.Add(new ConfigurationInfo(commandName, ScriptBlock.EmptyScriptBlock, context)
                                                {
                                                    Module = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => tempModuleInfo, 1534, 29565, 29781)
                                                });
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 29401, 29817);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 28005, 29848);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 26068, 29875);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 25827, 29898);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1534, 1, 4072);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1534, 1, 4072);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 20669, 29917);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1534, 1, 9249);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1534, 1, 9249);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 20409, 29932);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1534, 19536, 29943);

                return listYield;

                System.Management.Automation.WildcardPattern
                f_1534_19992_20048(string
                pattern, System.Management.Automation.WildcardOptions
                options)
                {
                    var return_v = WildcardPattern.Get(pattern, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 19992, 20048);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1534_20089_20109(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 20089, 20109);
                    return return_v;
                }


                System.Management.Automation.CommandInvocationIntrinsics
                f_1534_20089_20123(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.InvokeCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 20089, 20123);
                    return return_v;
                }


                System.Management.Automation.CmdletInfo
                f_1534_20089_20174(System.Management.Automation.CommandInvocationIntrinsics
                this_param, string
                commandName)
                {
                    var return_v = this_param.GetCmdlet(commandName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 20089, 20174);
                    return return_v;
                }


                System.Management.Automation.PSModuleAutoLoadingPreference
                f_1534_20249_20392(System.Management.Automation.ExecutionContext
                context, System.Management.Automation.VariablePath
                variablePath, string
                environmentVariable)
                {
                    var return_v = CommandDiscovery.GetCommandDiscoveryPreference(context, variablePath, environmentVariable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 20249, 20392);
                    return return_v;
                }


                System.Management.Automation.SessionStateEntryVisibility
                f_1534_20573_20594(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.Visibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 20573, 20594);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1534_20699_20765(bool
                isForAutoDiscovery, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = GetDefaultAvailableModuleFiles(isForAutoDiscovery: isForAutoDiscovery, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 20699, 20765);
                    return return_v;
                }


                string?
                f_1534_20936_20980(string
                path)
                {
                    var return_v = Path.GetFileNameWithoutExtension(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 20936, 20980);
                    return return_v;
                }


                System.Management.Automation.ModuleIntrinsics
                f_1534_21032_21047(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Modules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 21032, 21047);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                f_1534_21032_21110(System.Management.Automation.ModuleIntrinsics
                this_param, string
                moduleName, bool
                all, bool
                exactMatch)
                {
                    var return_v = this_param.GetExactMatchModules(moduleName, all: all, exactMatch: exactMatch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 21032, 21110);
                    return return_v;
                }


                int
                f_1534_21196_21209(System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 21196, 21209);
                    return return_v;
                }


                bool
                f_1534_21620_21676(System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                this_param, System.Predicate<System.Management.Automation.PSModuleInfo>
                match)
                {
                    var return_v = this_param.Exists(match);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 21620, 21676);
                    return return_v;
                }


                int
                f_1534_21802_21815(System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 21802, 21815);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1534_21902_21912(System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 21902, 21912);
                    return return_v;
                }


                string
                f_1534_21977_21990(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 21977, 21990);
                    return return_v;
                }


                string
                f_1534_21992_22005(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 21992, 22005);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1534_21960_22041(string
                name, string
                path, System.Management.Automation.ExecutionContext
                context, System.Management.Automation.SessionState
                sessionState)
                {
                    var return_v = new System.Management.Automation.PSModuleInfo(name, path, context: context, sessionState: sessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 21960, 22041);
                    return return_v;
                }


                string
                f_1534_22101_22120(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.ModuleBase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 22101, 22120);
                    return return_v;
                }


                int
                f_1534_22072_22121(System.Management.Automation.PSModuleInfo
                this_param, string
                moduleBase)
                {
                    this_param.SetModuleBase(moduleBase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 22072, 22121);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.CommandInfo>
                f_1534_22206_22231(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.ExportedCommands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 22206, 22231);
                    return return_v;
                }


                string
                f_1534_22324_22340(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 22324, 22340);
                    return return_v;
                }


                bool
                f_1534_22301_22341(System.Management.Automation.WildcardPattern
                this_param, string
                input)
                {
                    var return_v = this_param.IsMatch(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 22301, 22341);
                    return return_v;
                }


                string
                f_1534_22429_22445(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 22429, 22445);
                    return return_v;
                }


                bool
                f_1534_22403_22455(string
                string1, string
                string2)
                {
                    var return_v = FuzzyMatcher.IsFuzzyMatch(string1, string2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 22403, 22455);
                    return return_v;
                }


                string
                f_1534_22564_22580(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 22564, 22580);
                    return return_v;
                }


                string
                f_1534_22549_22581(string
                commandName)
                {
                    var return_v = AbbreviateName(commandName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 22549, 22581);
                    return return_v;
                }


                bool
                f_1534_22526_22618(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 22526, 22618);
                    return return_v;
                }


                System.Management.Automation.CommandTypes
                f_1534_22766_22789(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.CommandType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 22766, 22789);
                    return return_v;
                }


                string
                f_1534_22965_22981(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 22965, 22981);
                    return return_v;
                }


                System.Management.Automation.AliasInfo
                f_1534_22951_23009(string
                name, string
                definition, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new System.Management.Automation.AliasInfo(name, definition: definition, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 22951, 23009);
                    return return_v;
                }


                string
                f_1534_23204_23220(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 23204, 23220);
                    return return_v;
                }


                System.Management.Automation.FunctionInfo
                f_1534_23187_23260(string
                name, System.Management.Automation.ScriptBlock
                function, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new System.Management.Automation.FunctionInfo(name, function, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 23187, 23260);
                    return return_v;
                }


                string
                f_1534_23451_23467(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 23451, 23467);
                    return return_v;
                }


                System.Management.Automation.FilterInfo
                f_1534_23436_23507(string
                name, System.Management.Automation.ScriptBlock
                filter, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new System.Management.Automation.FilterInfo(name, filter, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 23436, 23507);
                    return return_v;
                }


                string
                f_1534_23712_23728(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 23712, 23728);
                    return return_v;
                }


                System.Management.Automation.ConfigurationInfo
                f_1534_23690_23768(string
                name, System.Management.Automation.ScriptBlock
                configuration, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new System.Management.Automation.ConfigurationInfo(name, configuration, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 23690, 23768);
                    return return_v;
                }


                string
                f_1534_23959_23975(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 23959, 23975);
                    return return_v;
                }


                System.Management.Automation.CmdletInfo
                f_1534_23944_24041(string
                name, System.Type
                implementingType, string
                helpFile, System.Management.Automation.PSSnapInInfo
                PSSnapin, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new System.Management.Automation.CmdletInfo(name, implementingType: implementingType, helpFile: helpFile, PSSnapin: PSSnapin, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 23944, 24041);
                    return return_v;
                }


                int
                f_1534_24190_24224(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 24190, 24224);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.CommandInfo>
                f_1534_22206_22231_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.CommandInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 22206, 22231);
                    return return_v;
                }


                string?
                f_1534_24653_24697(string
                path)
                {
                    var return_v = Path.GetFileNameWithoutExtension(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 24653, 24697);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.CommandTypes>
                f_1534_24775_24846(string
                modulePath, bool
                testOnly, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = AnalysisCache.GetExportedCommands(modulePath, testOnly: testOnly, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 24775, 24846);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1534_24955_25035(string
                name, string
                path, System.Management.Automation.SessionState
                sessionState, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new System.Management.Automation.PSModuleInfo(name, path, sessionState: sessionState, context: context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 24955, 25035);
                    return return_v;
                }


                bool
                f_1534_25062_25113(string
                moduleName)
                {
                    var return_v = InitialSessionState.IsEngineModule(moduleName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 25062, 25113);
                    return return_v;
                }


                string
                f_1534_25192_25222()
                {
                    var return_v = Utils.DefaultPowerShellAppBase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 25192, 25222);
                    return return_v;
                }


                int
                f_1534_25163_25223(System.Management.Automation.PSModuleInfo
                this_param, string
                moduleBase)
                {
                    this_param.SetModuleBase(moduleBase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 25163, 25223);
                    return 0;
                }


                bool
                f_1534_25455_25554(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.EndsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 25455, 25554);
                    return return_v;
                }


                System.Version
                f_1534_25630_25683(string
                manifestPath)
                {
                    var return_v = ModuleIntrinsics.GetManifestModuleVersion(manifestPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 25630, 25683);
                    return return_v;
                }


                int
                f_1534_25604_25684(System.Management.Automation.PSModuleInfo
                this_param, System.Version
                version)
                {
                    this_param.SetVersion(version);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 25604, 25684);
                    return 0;
                }


                System.Guid
                f_1534_25734_25778(string
                manifestPath)
                {
                    var return_v = ModuleIntrinsics.GetManifestGuid(manifestPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 25734, 25778);
                    return return_v;
                }


                int
                f_1534_25711_25779(System.Management.Automation.PSModuleInfo
                this_param, System.Guid
                guid)
                {
                    this_param.SetGuid(guid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 25711, 25779);
                    return 0;
                }


                bool
                f_1534_26072_26107(System.Management.Automation.WildcardPattern
                this_param, string
                input)
                {
                    var return_v = this_param.IsMatch(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 26072, 26107);
                    return return_v;
                }


                bool
                f_1534_26161_26208(string
                string1, string
                string2)
                {
                    var return_v = FuzzyMatcher.IsFuzzyMatch(string1, string2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 26161, 26208);
                    return return_v;
                }


                string
                f_1534_26294_26321(string
                commandName)
                {
                    var return_v = AbbreviateName(commandName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 26294, 26321);
                    return return_v;
                }


                bool
                f_1534_26271_26358(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 26271, 26358);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InitialSessionState
                f_1534_26597_26624(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.InitialSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 26597, 26624);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InitialSessionState
                f_1534_26794_26821(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.InitialSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 26794, 26821);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                f_1534_26794_26830(System.Management.Automation.Runspaces.InitialSessionState
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 26794, 26830);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                f_1534_26794_26843(System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 26794, 26843);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1534_26993_27012(System.Management.Automation.Runspaces.SessionStateCommandEntry
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 26993, 27012);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1534_27122_27141(System.Management.Automation.Runspaces.SessionStateCommandEntry
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 27122, 27141);
                    return return_v;
                }


                string
                f_1534_27122_27146(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 27122, 27146);
                    return return_v;
                }


                System.Management.Automation.PSSnapInInfo
                f_1534_27233_27254(System.Management.Automation.Runspaces.SessionStateCommandEntry
                this_param)
                {
                    var return_v = this_param.PSSnapIn;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 27233, 27254);
                    return return_v;
                }


                System.Management.Automation.PSSnapInInfo
                f_1534_27364_27385(System.Management.Automation.Runspaces.SessionStateCommandEntry
                this_param)
                {
                    var return_v = this_param.PSSnapIn;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 27364, 27385);
                    return return_v;
                }


                string
                f_1534_27364_27390(System.Management.Automation.PSSnapInInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 27364, 27390);
                    return return_v;
                }


                bool
                f_1534_27474_27559(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 27474, 27559);
                    return return_v;
                }


                System.Management.Automation.SessionStateEntryVisibility
                f_1534_27645_27668(System.Management.Automation.Runspaces.SessionStateCommandEntry
                this_param)
                {
                    var return_v = this_param.Visibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1534, 27645, 27668);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                f_1534_26794_26843_I(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 26794, 26843);
                    return return_v;
                }


                System.Collections.Generic.IDictionary<string, System.Management.Automation.CommandTypes>
                f_1534_25879_25895_I(System.Collections.Generic.IDictionary<string, System.Management.Automation.CommandTypes>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 25879, 25895);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1534_20699_20765_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 20699, 20765);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1534, 19536, 29943);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1534, 19536, 29943);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string AbbreviateName(string commandName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1534, 30216, 30706);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 30390, 30440);

                StringBuilder
                abbreviation = f_1534_30419_30439(6)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 30454, 30648);
                    foreach (char c in f_1534_30473_30484_I(commandName))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 30454, 30648);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 30518, 30633) || true) && (f_1534_30522_30537(c) || (DynAbs.Tracing.TraceSender.Expression_False(1534, 30522, 30549) || c == '-'))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1534, 30518, 30633);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 30591, 30614);

                            f_1534_30591_30613(abbreviation, c);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 30518, 30633);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1534, 30454, 30648);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1534, 1, 195);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1534, 1, 195);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 30664, 30695);

                return f_1534_30671_30694(abbreviation);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1534, 30216, 30706);

                System.Text.StringBuilder
                f_1534_30419_30439(int
                capacity)
                {
                    var return_v = new System.Text.StringBuilder(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 30419, 30439);
                    return return_v;
                }


                bool
                f_1534_30522_30537(char
                c)
                {
                    var return_v = char.IsUpper(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 30522, 30537);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1534_30591_30613(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 30591, 30613);
                    return return_v;
                }


                string
                f_1534_30473_30484_I(string
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 30473, 30484);
                    return return_v;
                }


                string
                f_1534_30671_30694(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1534, 30671, 30694);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1534, 30216, 30706);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1534, 30216, 30706);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ModuleUtils()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1534, 364, 30713);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 634, 784);
            s_defaultEnumerationOptions = new System.IO.EnumerationOptions() { AttributesToSkip = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => FileAttributes.Hidden, 1534, 705, 784) };
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 1238, 1408);
            s_uncPathEnumerationOptions = new System.IO.EnumerationOptions() { AttributesToSkip = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => FileAttributes.Hidden, 1534, 1309, 1408), BufferSize = 16384 };
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 1452, 1502);
            EnCulturePath = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (Path.DirectorySeparatorChar).ToString(), 1534, 1468, 1495) + "en";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 1544, 1599);
            EnUsCulturePath = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (Path.DirectorySeparatorChar).ToString(), 1534, 1562, 1589) + "en-us";
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1534, 364, 30713);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1534, 364, 30713);
        }

    }

    internal struct CommandScore
    {

        public CommandScore(CommandInfo command, int score)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1534, 30766, 30899);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 30842, 30860);

                Command = command;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1534, 30874, 30888);

                Score = score;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1534, 30766, 30899);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1534, 30766, 30899);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1534, 30766, 30899);
            }
        }

        public CommandInfo Command;

        public int Score;
        static CommandScore()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1534, 30721, 30972);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1534, 30721, 30972);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1534, 30721, 30972);
        }
    }
}

