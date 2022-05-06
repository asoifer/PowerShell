// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Reflection;
using System.Resources;

namespace System.Management.Automation
{
    internal static class ResourceManagerCache
    {
        private static Dictionary<string, Dictionary<string, ResourceManager>> s_resourceManagerCache;

        private static object s_syncRoot;

        internal static ResourceManager GetResourceManager(
                    Assembly assembly,
                    string baseName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1039, 1724, 4328);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1039, 1862, 1988) || true) && (assembly == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1039, 1862, 1988);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1039, 1916, 1973);

                    throw f_1039_1922_1972("assembly");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1039, 1862, 1988);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1039, 2004, 2140) || true) && (f_1039_2008_2038(baseName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1039, 2004, 2140);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1039, 2072, 2125);

                    throw f_1039_2078_2124("baseName");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1039, 2004, 2140);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1039, 2226, 2257);

                ResourceManager
                manager = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1039, 2271, 2321);

                Dictionary<string, ResourceManager>
                baseNameCache
                = default(Dictionary<string, ResourceManager>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1039, 2337, 2393);

                string
                assemblyManifestFileLocation = f_1039_2375_2392(assembly)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1039, 2413, 2423);
                lock (s_syncRoot)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1039, 2530, 2826) || true) && (f_1039_2534_2617(s_resourceManagerCache, assemblyManifestFileLocation, out baseNameCache) && (DynAbs.Tracing.TraceSender.Expression_True(1039, 2534, 2642) && baseNameCache != null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1039, 2530, 2826);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1039, 2758, 2807);

                        f_1039_2758_2806(                    // Now do the lookup based on the resource base name
                                            baseNameCache, baseName, out manager);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1039, 2530, 2826);
                    }
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1039, 2920, 4076) || true) && (manager == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1039, 2920, 4076);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1039, 2973, 3022);

                    manager = f_1039_2983_3021(baseName, assembly);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1039, 3105, 4061) || true) && (baseNameCache != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1039, 3105, 4061);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1039, 3178, 3188);
                        lock (s_syncRoot)
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1039, 3376, 3410);

                            baseNameCache[baseName] = manager;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1039, 3105, 4061);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1039, 3105, 4061);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1039, 3725, 3792);

                        var
                        baseNameCacheEntry = f_1039_3750_3791()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1039, 3816, 3855);

                        baseNameCacheEntry[baseName] = manager;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1039, 3885, 3895);

                        lock (s_syncRoot)
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1039, 3945, 4019);

                            s_resourceManagerCache[assemblyManifestFileLocation] = baseNameCacheEntry;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1039, 3105, 4061);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1039, 2920, 4076);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1039, 4092, 4286);

                f_1039_4092_4285(manager != null, "If the manager was not already created, it should have been dynamically created or an exception should have been thrown");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1039, 4302, 4317);

                return manager;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1039, 1724, 4328);

                System.Management.Automation.PSArgumentNullException
                f_1039_1922_1972(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1039, 1922, 1972);
                    return return_v;
                }


                bool
                f_1039_2008_2038(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1039, 2008, 2038);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1039_2078_2124(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1039, 2078, 2124);
                    return return_v;
                }


                string
                f_1039_2375_2392(System.Reflection.Assembly
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1039, 2375, 2392);
                    return return_v;
                }


                bool
                f_1039_2534_2617(System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Resources.ResourceManager>>
                this_param, string
                key, out System.Collections.Generic.Dictionary<string, System.Resources.ResourceManager>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1039, 2534, 2617);
                    return return_v;
                }


                bool
                f_1039_2758_2806(System.Collections.Generic.Dictionary<string, System.Resources.ResourceManager>
                this_param, string
                key, out System.Resources.ResourceManager
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1039, 2758, 2806);
                    return return_v;
                }


                System.Resources.ResourceManager
                f_1039_2983_3021(string
                baseName, System.Reflection.Assembly
                assemblyToUse)
                {
                    var return_v = InitRMWithAssembly(baseName, assemblyToUse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1039, 2983, 3021);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Resources.ResourceManager>
                f_1039_3750_3791()
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, System.Resources.ResourceManager>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1039, 3750, 3791);
                    return return_v;
                }


                int
                f_1039_4092_4285(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1039, 4092, 4285);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1039, 1724, 4328);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1039, 1724, 4328);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool s_DFT_monitorFailingResourceLookup;

        internal static bool DFT_DoMonitorFailingResourceLookup
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1039, 4612, 4683);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1039, 4618, 4681);

                    return ResourceManagerCache.s_DFT_monitorFailingResourceLookup;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1039, 4612, 4683);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1039, 4532, 4782);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1039, 4532, 4782);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1039, 4699, 4771);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1039, 4705, 4769);

                    ResourceManagerCache.s_DFT_monitorFailingResourceLookup = value;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1039, 4699, 4771);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1039, 4532, 4782);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1039, 4532, 4782);
                }
            }
        }

        internal static string GetResourceString(
                    Assembly assembly,
                    string baseName,
                    string resourceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1039, 6018, 8571);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1039, 6178, 6304) || true) && (assembly == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1039, 6178, 6304);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1039, 6232, 6289);

                    throw f_1039_6238_6288("assembly");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1039, 6178, 6304);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1039, 6320, 6456) || true) && (f_1039_6324_6354(baseName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1039, 6320, 6456);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1039, 6388, 6441);

                    throw f_1039_6394_6440("baseName");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1039, 6320, 6456);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1039, 6472, 6612) || true) && (f_1039_6476_6508(resourceId))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1039, 6472, 6612);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1039, 6542, 6597);

                    throw f_1039_6548_6596("resourceId");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1039, 6472, 6612);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1039, 6628, 6667);

                ResourceManager
                resourceManager = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1039, 6681, 6708);

                string
                text = string.Empty
                ;

                // For a non-existing resource defined by {assembly,baseName,resourceId}
                // MissingManifestResourceException is thrown only at the time when resource retrieval method
                // such as ResourceManager.GetString or ResourceManager.GetObject is called,
                // not when you instantiate a ResourceManager object.
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1039, 7242, 7299);

                    resourceManager = f_1039_7260_7298(assembly, baseName);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1039, 7317, 7362);

                    text = f_1039_7324_7361(resourceManager, resourceId);
                }
                catch (MissingManifestResourceException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1039, 7391, 8282);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1039, 7464, 7512);

                    const string
                    resourcesSubstring = ".resources."
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1039, 7530, 7597);

                    int
                    resourcesSubstringIndex = f_1039_7560_7596(baseName, resourcesSubstring)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1039, 7615, 7649);

                    string
                    newBaseName = string.Empty
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1039, 7667, 8124) || true) && (resourcesSubstringIndex != -1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1039, 7667, 8124);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1039, 7742, 7828);

                        newBaseName = f_1039_7756_7827(baseName, resourcesSubstringIndex + f_1039_7801_7826(resourcesSubstring));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1039, 7667, 8124);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1039, 7667, 8124);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1039, 7947, 8030);

                        newBaseName = f_1039_7961_8029(f_1039_7975_7998(f_1039_7975_7993(assembly)), resourcesSubstring, baseName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1039, 7667, 8124);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1039, 8144, 8204);

                    resourceManager = f_1039_8162_8203(assembly, newBaseName);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1039, 8222, 8267);

                    text = f_1039_8229_8266(resourceManager, resourceId);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1039, 7391, 8282);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1039, 8298, 8532) || true) && (f_1039_8302_8328(text) && (DynAbs.Tracing.TraceSender.Expression_True(1039, 8302, 8366) && s_DFT_monitorFailingResourceLookup))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1039, 8298, 8532);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1039, 8400, 8517);

                    f_1039_8400_8516(false, "Lookup failure: baseName " + baseName + " resourceId " + resourceId);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1039, 8298, 8532);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1039, 8548, 8560);

                return text;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1039, 6018, 8571);

                System.Management.Automation.PSArgumentNullException
                f_1039_6238_6288(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1039, 6238, 6288);
                    return return_v;
                }


                bool
                f_1039_6324_6354(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1039, 6324, 6354);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1039_6394_6440(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1039, 6394, 6440);
                    return return_v;
                }


                bool
                f_1039_6476_6508(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1039, 6476, 6508);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1039_6548_6596(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1039, 6548, 6596);
                    return return_v;
                }


                System.Resources.ResourceManager
                f_1039_7260_7298(System.Reflection.Assembly
                assembly, string
                baseName)
                {
                    var return_v = GetResourceManager(assembly, baseName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1039, 7260, 7298);
                    return return_v;
                }


                string?
                f_1039_7324_7361(System.Resources.ResourceManager
                this_param, string
                name)
                {
                    var return_v = this_param.GetString(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1039, 7324, 7361);
                    return return_v;
                }


                int
                f_1039_7560_7596(string
                this_param, string
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1039, 7560, 7596);
                    return return_v;
                }


                int
                f_1039_7801_7826(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1039, 7801, 7826);
                    return return_v;
                }


                string
                f_1039_7756_7827(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1039, 7756, 7827);
                    return return_v;
                }


                System.Reflection.AssemblyName
                f_1039_7975_7993(System.Reflection.Assembly
                this_param)
                {
                    var return_v = this_param.GetName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1039, 7975, 7993);
                    return return_v;
                }


                string
                f_1039_7975_7998(System.Reflection.AssemblyName
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1039, 7975, 7998);
                    return return_v;
                }


                string
                f_1039_7961_8029(string
                str0, string
                str1, string
                str2)
                {
                    var return_v = string.Concat(str0, str1, str2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1039, 7961, 8029);
                    return return_v;
                }


                System.Resources.ResourceManager
                f_1039_8162_8203(System.Reflection.Assembly
                assembly, string
                baseName)
                {
                    var return_v = GetResourceManager(assembly, baseName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1039, 8162, 8203);
                    return return_v;
                }


                string?
                f_1039_8229_8266(System.Resources.ResourceManager
                this_param, string
                name)
                {
                    var return_v = this_param.GetString(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1039, 8229, 8266);
                    return return_v;
                }


                bool
                f_1039_8302_8328(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1039, 8302, 8328);
                    return return_v;
                }


                int
                f_1039_8400_8516(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1039, 8400, 8516);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1039, 6018, 8571);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1039, 6018, 8571);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ResourceManager InitRMWithAssembly(string baseName, Assembly assemblyToUse)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1039, 9265, 9860);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1039, 9380, 9406);

                ResourceManager
                rm = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1039, 9422, 9823) || true) && (baseName != null && (DynAbs.Tracing.TraceSender.Expression_True(1039, 9426, 9467) && assemblyToUse != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1039, 9422, 9823);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1039, 9501, 9551);

                    rm = f_1039_9506_9550(baseName, assemblyToUse);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1039, 9422, 9823);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1039, 9422, 9823);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1039, 9750, 9808);

                    throw f_1039_9756_9807("assemblyToUse");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1039, 9422, 9823);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1039, 9839, 9849);

                return rm;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1039, 9265, 9860);

                System.Resources.ResourceManager
                f_1039_9506_9550(string
                baseName, System.Reflection.Assembly
                assembly)
                {
                    var return_v = new System.Resources.ResourceManager(baseName, assembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1039, 9506, 9550);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1039_9756_9807(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1039, 9756, 9807);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1039, 9265, 9860);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1039, 9265, 9860);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ResourceManagerCache()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1039, 274, 9867);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1039, 788, 919);
            s_resourceManagerCache = f_1039_826_919(f_1039_886_918());
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1039, 1070, 1095);
            s_syncRoot = f_1039_1083_1095();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1039, 4480, 4521);
            s_DFT_monitorFailingResourceLookup = true;
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1039, 274, 9867);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1039, 274, 9867);
        }


        static System.StringComparer
        f_1039_886_918()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1039, 886, 918);
            return return_v;
        }


        static System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Resources.ResourceManager>>
        f_1039_826_919(System.StringComparer
        comparer)
        {
            var return_v = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Resources.ResourceManager>>((System.Collections.Generic.IEqualityComparer<string>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1039, 826, 919);
            return return_v;
        }


        static object
        f_1039_1083_1095()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1039, 1083, 1095);
            return return_v;
        }

    }
}

