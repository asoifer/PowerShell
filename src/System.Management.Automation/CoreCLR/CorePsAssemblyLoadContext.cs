// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Runtime.Loader;

namespace System.Management.Automation
{
    internal partial class PowerShellAssemblyLoadContext
    {
        private const string
        BaseFolderDoesNotExist = "The base directory '{0}' does not exist."
        ;

        private const string
        ManifestDefinitionDoesNotMatch = "Could not load file or assembly '{0}' or one of its dependencies. The located assembly's manifest definition does not match the assembly reference."
        ;

        private const string
        SingletonAlreadyInitialized = "The singleton of PowerShellAssemblyLoadContext has already been initialized."
        ;

        internal static PowerShellAssemblyLoadContext InitializeSingleton(string basePaths)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1074, 2320, 2759);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 2434, 2443);
                lock (s_syncObj)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 2477, 2623) || true) && (f_1074_2481_2489() != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1074, 2477, 2623);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 2539, 2604);

                        throw f_1074_2545_2603(SingletonAlreadyInitialized);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1074, 2477, 2623);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 2643, 2699);

                    Instance = f_1074_2654_2698(basePaths);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 2717, 2733);

                    return f_1074_2724_2732();
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1074, 2320, 2759);

                System.Management.Automation.PowerShellAssemblyLoadContext
                f_1074_2481_2489()
                {
                    var return_v = Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1074, 2481, 2489);
                    return return_v;
                }


                System.InvalidOperationException
                f_1074_2545_2603(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 2545, 2603);
                    return return_v;
                }


                System.Management.Automation.PowerShellAssemblyLoadContext
                f_1074_2654_2698(string
                basePaths)
                {
                    var return_v = new System.Management.Automation.PowerShellAssemblyLoadContext(basePaths);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 2654, 2698);
                    return return_v;
                }


                System.Management.Automation.PowerShellAssemblyLoadContext
                f_1074_2724_2732()
                {
                    var return_v = Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1074, 2724, 2732);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1074, 2320, 2759);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1074, 2320, 2759);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private PowerShellAssemblyLoadContext(string basePaths)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1074, 3158, 5156);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 5320, 5333);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 5370, 5418);
                this._extensions = new string[] { ".ni.dll", ".dll" };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 5666, 5685);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 5735, 5764);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 5808, 5941);
                this._denyListedAssemblies = new HashSet<string>(f_1074_5852_5884()){
                DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => "System.Windows.Forms",1074,5832,5941)
            };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 5980, 5987);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 6013, 6025);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 6051, 6061);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 6087, 6097);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 3306, 3362);

                _winDir = _gacPath32 = _gacPath64 = _gacPathMSIL = null;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 3445, 4237) || true) && (f_1074_3449_3480(basePaths))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1074, 3445, 4237);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 3514, 3552);

                    _probingPaths = f_1074_3530_3551();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1074, 3445, 4237);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1074, 3445, 4237);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 3618, 3709);

                    _probingPaths = f_1074_3634_3708(basePaths, new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 3736, 3741);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 3727, 4222) || true) && (i < f_1074_3747_3767(_probingPaths))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 3769, 3772)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1074, 3727, 4222))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1074, 3727, 4222);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 3814, 3849);

                            string
                            basePath = _probingPaths[i]
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 3871, 4144) || true) && (!f_1074_3876_3902(basePath))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1074, 3871, 4144);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 3952, 4045);

                                string
                                message = f_1074_3969_4044(f_1074_3983_4009(), BaseFolderDoesNotExist, basePath)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 4071, 4121);

                                throw f_1074_4077_4120(message, "basePaths");
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1074, 3871, 4144);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 4168, 4203);

                            _probingPaths[i] = f_1074_4187_4202(basePath);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1074, 1, 496);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1074, 1, 496);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1074, 3445, 4237);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 4342, 4388);

                _coreClrTypeCatalog = f_1074_4364_4387(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 4402, 4561);

                _availableDotNetAssemblyNames = f_1074_4434_4560(() => new HashSet<string>(_coreClrTypeCatalog.Values, StringComparer.Ordinal));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 4697, 4746);

                f_1074_4697_4724().Resolving += Resolve;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 5075, 5145);

                f_1074_5075_5102().ResolvingUnmanagedDll += NativeDllHandler;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1074, 3158, 5156);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1074, 3158, 5156);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1074, 3158, 5156);
            }
        }

        private static readonly object s_syncObj;

        private readonly string[] _probingPaths;

        private readonly string[] _extensions;

        private readonly Dictionary<string, string> _coreClrTypeCatalog;

        private readonly Lazy<HashSet<string>> _availableDotNetAssemblyNames;

        private readonly HashSet<string> _denyListedAssemblies;

        private string _winDir;

        private string _gacPathMSIL;

        private string _gacPath32;

        private string _gacPath64;

        private static readonly ConcurrentDictionary<string, Assembly> s_assemblyCache;

        internal static PowerShellAssemblyLoadContext Instance
        {
            get; private set;
        }

        internal IEnumerable<string> AvailableDotNetTypeNames
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1074, 7972, 8012);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 7978, 8010);

                    return f_1074_7985_8009(_coreClrTypeCatalog);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1074, 7972, 8012);

                    System.Collections.Generic.Dictionary<string, string>.KeyCollection
                    f_1074_7985_8009(System.Collections.Generic.Dictionary<string, string>
                    this_param)
                    {
                        var return_v = this_param.Keys;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1074, 7985, 8009);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1074, 7894, 8023);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1074, 7894, 8023);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal HashSet<string> AvailableDotNetAssemblyNames
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1074, 8329, 8380);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 8335, 8378);

                    return f_1074_8342_8377(_availableDotNetAssemblyNames);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1074, 8329, 8380);

                    System.Collections.Generic.HashSet<string>
                    f_1074_8342_8377(System.Lazy<System.Collections.Generic.HashSet<string>>
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1074, 8342, 8377);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1074, 8251, 8391);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1074, 8251, 8391);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal IEnumerable<Assembly> GetAssembly(string namespaceQualifiedTypeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1074, 8567, 9360);
                string tpaStrongName = default(string);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 8829, 9279) || true) && (!f_1074_8834_8882(namespaceQualifiedTypeName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1074, 8829, 9279);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 8916, 9264) || true) && (f_1074_8920_9005(_coreClrTypeCatalog, namespaceQualifiedTypeName, out tpaStrongName))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1074, 8916, 9264);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 9099, 9167);

                            return new Assembly[] { f_1074_9123_9164(this, tpaStrongName) };
                        }
                        catch (FileNotFoundException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1074, 9212, 9245);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1074, 9212, 9245);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1074, 8916, 9264);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1074, 8829, 9279);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 9337, 9349);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1074, 8567, 9360);

                bool
                f_1074_8834_8882(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 8834, 8882);
                    return return_v;
                }


                bool
                f_1074_8920_9005(System.Collections.Generic.Dictionary<string, string>
                this_param, string
                key, out string
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 8920, 9005);
                    return return_v;
                }


                System.Reflection.Assembly
                f_1074_9123_9164(System.Management.Automation.PowerShellAssemblyLoadContext
                this_param, string
                tpaStrongName)
                {
                    var return_v = this_param.GetTrustedPlatformAssembly(tpaStrongName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 9123, 9164);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1074, 8567, 9360);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1074, 8567, 9360);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static IntPtr NativeDllHandler(Assembly assembly, string libraryName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1074, 11156, 11628);
                System.IntPtr pointer = default(System.IntPtr);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 11259, 11336);

                s_nativeDllSubFolder ??= f_1074_11284_11335(out s_nativeDllExtension);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 11350, 11407);

                string
                folder = f_1074_11366_11406(f_1074_11388_11405(assembly))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 11421, 11518);

                string
                fullName = f_1074_11439_11494(folder, s_nativeDllSubFolder, libraryName) + s_nativeDllExtension
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 11534, 11617);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1074, 11541, 11592) || ((f_1074_11541_11592(fullName, out pointer) && DynAbs.Tracing.TraceSender.Conditional_F2(1074, 11595, 11602)) || DynAbs.Tracing.TraceSender.Conditional_F3(1074, 11605, 11616))) ? pointer : IntPtr.Zero;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1074, 11156, 11628);

                string
                f_1074_11284_11335(out string
                ext)
                {
                    var return_v = GetNativeDllSubFolderName(out ext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 11284, 11335);
                    return return_v;
                }


                string
                f_1074_11388_11405(System.Reflection.Assembly
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1074, 11388, 11405);
                    return return_v;
                }


                string?
                f_1074_11366_11406(string
                path)
                {
                    var return_v = Path.GetDirectoryName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 11366, 11406);
                    return return_v;
                }


                string
                f_1074_11439_11494(string
                path1, string
                path2, string
                path3)
                {
                    var return_v = Path.Combine(path1, path2, path3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 11439, 11494);
                    return return_v;
                }


                bool
                f_1074_11541_11592(string
                libraryPath, out System.IntPtr
                handle)
                {
                    var return_v = NativeLibrary.TryLoad(libraryPath, out handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 11541, 11592);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1074, 11156, 11628);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1074, 11156, 11628);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Assembly Resolve(AssemblyLoadContext loadContext, AssemblyName assemblyName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1074, 11811, 15276);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 11961, 11980);

                Assembly
                asmLoaded
                = default(Assembly);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 11994, 12086) || true) && (f_1074_11998_12050(this, assemblyName, out asmLoaded))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1074, 11994, 12086);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 12069, 12086);

                    return asmLoaded;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1074, 11994, 12086);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 12153, 12162);

                // Prepare to load the assembly
                lock (s_syncObj)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 12266, 12362) || true) && (f_1074_12270_12322(this, assemblyName, out asmLoaded))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1074, 12266, 12362);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 12345, 12362);

                        return asmLoaded;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1074, 12266, 12362);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 12719, 12784);

                    bool
                    isAssemblyFileFound = false
                    ,
                    isAssemblyFileMatching = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 12802, 12867);

                    string
                    asmCultureName = f_1074_12826_12850(assemblyName) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1074, 12826, 12866) ?? string.Empty)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 12885, 12911);

                    string
                    asmFilePath = null
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 12940, 12945);

                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 12931, 14113) || true) && (i < f_1074_12951_12971(_probingPaths))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 12973, 12976)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1074, 12931, 14113))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1074, 12931, 14113);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 13018, 13056);

                            string
                            probingPath = _probingPaths[i]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 13078, 13144);

                            string
                            asmCulturePath = f_1074_13102_13143(probingPath, asmCultureName)
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 13175, 13180);
                                for (int
            k = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 13166, 13942) || true) && (k < f_1074_13186_13204(_extensions))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 13206, 13209)
            , k++, DynAbs.Tracing.TraceSender.TraceExitCondition(1074, 13166, 13942))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1074, 13166, 13942);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 13259, 13315);

                                    string
                                    asmFileName = f_1074_13280_13297(assemblyName) + _extensions[k]
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 13341, 13397);

                                    asmFilePath = f_1074_13355_13396(asmCulturePath, asmFileName);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 13425, 13919) || true) && (f_1074_13429_13453(asmFilePath))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1074, 13425, 13919);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 13511, 13538);

                                        isAssemblyFileFound = true;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 13568, 13645);

                                        AssemblyName
                                        asmNameFound = f_1074_13596_13644(asmFilePath)
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 13675, 13892) || true) && (f_1074_13679_13725(this, assemblyName, asmNameFound))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1074, 13675, 13892);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 13791, 13821);

                                            isAssemblyFileMatching = true;
                                            DynAbs.Tracing.TraceSender.TraceBreak(1074, 13855, 13861);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1074, 13675, 13892);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1074, 13425, 13919);
                                    }
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1074, 1, 777);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1074, 1, 777);
                            }
                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 13966, 14094) || true) && (isAssemblyFileFound && (DynAbs.Tracing.TraceSender.Expression_True(1074, 13970, 14015) && isAssemblyFileMatching))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1074, 13966, 14094);
                                DynAbs.Tracing.TraceSender.TraceBreak(1074, 14065, 14071);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1074, 13966, 14094);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1074, 1, 1183);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1074, 1, 1183);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 14382, 14732) || true) && (!isAssemblyFileFound || (DynAbs.Tracing.TraceSender.Expression_False(1074, 14386, 14433) || !isAssemblyFileMatching))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1074, 14382, 14732);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 14531, 14664) || true) && (!f_1074_14536_14579(this, assemblyName, out asmFilePath))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1074, 14531, 14664);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 14629, 14641);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1074, 14531, 14664);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1074, 14382, 14732);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 14752, 15003);

                    asmLoaded = (DynAbs.Tracing.TraceSender.Conditional_F1(1074, 14764, 14831) || ((f_1074_14764_14831(asmFilePath, ".ni.dll", StringComparison.OrdinalIgnoreCase) && DynAbs.Tracing.TraceSender.Conditional_F2(1074, 14867, 14921)) || DynAbs.Tracing.TraceSender.Conditional_F3(1074, 14957, 15002))) ? f_1074_14867_14921(loadContext, asmFilePath, null) : f_1074_14957_15002(loadContext, asmFilePath);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 15021, 15217) || true) && (asmLoaded != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1074, 15021, 15217);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 15145, 15198);

                        f_1074_15145_15197(                    // Add the loaded assembly to the cache
                                            s_assemblyCache, f_1074_15168_15185(assemblyName), asmLoaded);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1074, 15021, 15217);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 15248, 15265);

                return asmLoaded;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1074, 11811, 15276);

                bool
                f_1074_11998_12050(System.Management.Automation.PowerShellAssemblyLoadContext
                this_param, System.Reflection.AssemblyName
                assemblyName, out System.Reflection.Assembly
                asmLoaded)
                {
                    var return_v = this_param.TryGetAssemblyFromCache(assemblyName, out asmLoaded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 11998, 12050);
                    return return_v;
                }


                bool
                f_1074_12270_12322(System.Management.Automation.PowerShellAssemblyLoadContext
                this_param, System.Reflection.AssemblyName
                assemblyName, out System.Reflection.Assembly
                asmLoaded)
                {
                    var return_v = this_param.TryGetAssemblyFromCache(assemblyName, out asmLoaded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 12270, 12322);
                    return return_v;
                }


                string
                f_1074_12826_12850(System.Reflection.AssemblyName
                this_param)
                {
                    var return_v = this_param.CultureName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1074, 12826, 12850);
                    return return_v;
                }


                int
                f_1074_12951_12971(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1074, 12951, 12971);
                    return return_v;
                }


                string
                f_1074_13102_13143(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 13102, 13143);
                    return return_v;
                }


                int
                f_1074_13186_13204(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1074, 13186, 13204);
                    return return_v;
                }


                string
                f_1074_13280_13297(System.Reflection.AssemblyName
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1074, 13280, 13297);
                    return return_v;
                }


                string
                f_1074_13355_13396(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 13355, 13396);
                    return return_v;
                }


                bool
                f_1074_13429_13453(string
                path)
                {
                    var return_v = File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 13429, 13453);
                    return return_v;
                }


                System.Reflection.AssemblyName
                f_1074_13596_13644(string
                assemblyPath)
                {
                    var return_v = AssemblyLoadContext.GetAssemblyName(assemblyPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 13596, 13644);
                    return return_v;
                }


                bool
                f_1074_13679_13725(System.Management.Automation.PowerShellAssemblyLoadContext
                this_param, System.Reflection.AssemblyName
                requestedAssembly, System.Reflection.AssemblyName
                loadedAssembly)
                {
                    var return_v = this_param.IsAssemblyMatching(requestedAssembly, loadedAssembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 13679, 13725);
                    return return_v;
                }


                bool
                f_1074_14536_14579(System.Management.Automation.PowerShellAssemblyLoadContext
                this_param, System.Reflection.AssemblyName
                assemblyName, out string
                assemblyFilePath)
                {
                    var return_v = this_param.TryFindInGAC(assemblyName, out assemblyFilePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 14536, 14579);
                    return return_v;
                }


                bool
                f_1074_14764_14831(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.EndsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 14764, 14831);
                    return return_v;
                }


                System.Reflection.Assembly
                f_1074_14867_14921(System.Runtime.Loader.AssemblyLoadContext
                this_param, string
                nativeImagePath, string?
                assemblyPath)
                {
                    var return_v = this_param.LoadFromNativeImagePath(nativeImagePath, assemblyPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 14867, 14921);
                    return return_v;
                }


                System.Reflection.Assembly
                f_1074_14957_15002(System.Runtime.Loader.AssemblyLoadContext
                this_param, string
                assemblyPath)
                {
                    var return_v = this_param.LoadFromAssemblyPath(assemblyPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 14957, 15002);
                    return return_v;
                }


                string
                f_1074_15168_15185(System.Reflection.AssemblyName
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1074, 15168, 15185);
                    return return_v;
                }


                bool
                f_1074_15145_15197(System.Collections.Concurrent.ConcurrentDictionary<string, System.Reflection.Assembly>
                this_param, string
                key, System.Reflection.Assembly
                value)
                {
                    var return_v = this_param.TryAdd(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 15145, 15197);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1074, 11811, 15276);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1074, 11811, 15276);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool TryFindInGAC(AssemblyName assemblyName, out string assemblyFilePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1074, 15568, 17957);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 15674, 15698);

                assemblyFilePath = null;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 15712, 15978) || true) && (f_1074_15716_15765(_denyListedAssemblies, f_1074_15747_15764(assemblyName)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1074, 15712, 15978);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 15950, 15963);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1074, 15712, 15978);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 15994, 16104) || true) && (Internal.InternalTestHooks.DisableGACLoading)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1074, 15994, 16104);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 16076, 16089);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1074, 15994, 16104);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 16120, 16147);

                bool
                assemblyFound = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 16161, 16212);

                char
                dirSeparator = IO.Path.DirectorySeparatorChar
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 16228, 16437) || true) && (f_1074_16232_16261(_winDir))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1074, 16228, 16437);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 16367, 16422);

                    _winDir = f_1074_16377_16421("winDir");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1074, 16228, 16437);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 16453, 16716) || true) && (f_1074_16457_16491(_gacPathMSIL))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1074, 16453, 16716);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 16602, 16701);

                    _gacPathMSIL = $"{_winDir}{dirSeparator}Microsoft.NET{dirSeparator}assembly{dirSeparator}GAC_MSIL";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1074, 16453, 16716);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 16732, 16808);

                assemblyFound = f_1074_16748_16807(this, _gacPathMSIL, assemblyName, out assemblyFilePath);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 16824, 17909) || true) && (!assemblyFound)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1074, 16824, 17909);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 16876, 16910);

                    string
                    gacBitnessAwarePath = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 16930, 17791) || true) && (f_1074_16934_16960())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1074, 16930, 17791);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 17002, 17289) || true) && (f_1074_17006_17038(_gacPath64))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1074, 17002, 17289);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 17171, 17266);

                            _gacPath64 = $"{_winDir}{dirSeparator}Microsoft.NET{dirSeparator}assembly{dirSeparator}GAC_64";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1074, 17002, 17289);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 17313, 17346);

                        gacBitnessAwarePath = _gacPath64;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1074, 16930, 17791);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1074, 16930, 17791);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 17428, 17715) || true) && (f_1074_17432_17464(_gacPath32))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1074, 17428, 17715);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 17597, 17692);

                            _gacPath32 = $"{_winDir}{dirSeparator}Microsoft.NET{dirSeparator}assembly{dirSeparator}GAC_32";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1074, 17428, 17715);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 17739, 17772);

                        gacBitnessAwarePath = _gacPath32;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1074, 16930, 17791);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 17811, 17894);

                    assemblyFound = f_1074_17827_17893(this, gacBitnessAwarePath, assemblyName, out assemblyFilePath);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1074, 16824, 17909);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 17925, 17946);

                return assemblyFound;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1074, 15568, 17957);

                string
                f_1074_15747_15764(System.Reflection.AssemblyName
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1074, 15747, 15764);
                    return return_v;
                }


                bool
                f_1074_15716_15765(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 15716, 15765);
                    return return_v;
                }


                bool
                f_1074_16232_16261(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 16232, 16261);
                    return return_v;
                }


                string?
                f_1074_16377_16421(string
                variable)
                {
                    var return_v = Environment.GetEnvironmentVariable(variable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 16377, 16421);
                    return return_v;
                }


                bool
                f_1074_16457_16491(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 16457, 16491);
                    return return_v;
                }


                bool
                f_1074_16748_16807(System.Management.Automation.PowerShellAssemblyLoadContext
                this_param, string
                gacRoot, System.Reflection.AssemblyName
                assemblyName, out string
                assemblyPath)
                {
                    var return_v = this_param.FindInGac(gacRoot, assemblyName, out assemblyPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 16748, 16807);
                    return return_v;
                }


                bool
                f_1074_16934_16960()
                {
                    var return_v = Environment.Is64BitProcess;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1074, 16934, 16960);
                    return return_v;
                }


                bool
                f_1074_17006_17038(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 17006, 17038);
                    return return_v;
                }


                bool
                f_1074_17432_17464(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 17432, 17464);
                    return return_v;
                }


                bool
                f_1074_17827_17893(System.Management.Automation.PowerShellAssemblyLoadContext
                this_param, string
                gacRoot, System.Reflection.AssemblyName
                assemblyName, out string
                assemblyPath)
                {
                    var return_v = this_param.FindInGac(gacRoot, assemblyName, out assemblyPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 17827, 17893);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1074, 15568, 17957);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1074, 15568, 17957);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool FindInGac(string gacRoot, AssemblyName assemblyName, out string assemblyPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1074, 18046, 19591);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 18161, 18188);

                bool
                assemblyFound = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 18202, 18222);

                assemblyPath = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 18238, 18289);

                char
                dirSeparator = IO.Path.DirectorySeparatorChar
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 18303, 18378);

                string
                tempAssemblyDirPath = $"{gacRoot}{dirSeparator}{f_1074_18358_18375(assemblyName)}"
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 18394, 19543) || true) && (f_1074_18398_18435(tempAssemblyDirPath))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1074, 18394, 19543);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 18583, 18690);

                    var
                    chosenVersionDirectory = f_1074_18612_18689(f_1074_18612_18673(f_1074_18612_18657(tempAssemblyDirPath), d => d))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 18710, 19528) || true) && (!f_1074_18715_18759(chosenVersionDirectory))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1074, 18710, 19528);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 18931, 19040);

                        var
                        foundAssemblyPath = f_1074_18955_19039(f_1074_18955_19022(chosenVersionDirectory, $"{f_1074_19001_19018(assemblyName)}*"))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 19064, 19509) || true) && (!f_1074_19069_19108(foundAssemblyPath))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1074, 19064, 19509);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 19158, 19241);

                            AssemblyName
                            asmNameFound = f_1074_19186_19240(foundAssemblyPath)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 19267, 19486) || true) && (f_1074_19271_19317(this, assemblyName, asmNameFound))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1074, 19267, 19486);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 19375, 19408);

                                assemblyPath = foundAssemblyPath;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 19438, 19459);

                                assemblyFound = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1074, 19267, 19486);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1074, 19064, 19509);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1074, 18710, 19528);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1074, 18394, 19543);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 19559, 19580);

                return assemblyFound;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1074, 18046, 19591);

                string
                f_1074_18358_18375(System.Reflection.AssemblyName
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1074, 18358, 18375);
                    return return_v;
                }


                bool
                f_1074_18398_18435(string
                path)
                {
                    var return_v = Directory.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 18398, 18435);
                    return return_v;
                }


                string[]
                f_1074_18612_18657(string
                path)
                {
                    var return_v = Directory.GetDirectories(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 18612, 18657);
                    return return_v;
                }


                System.Linq.IOrderedEnumerable<string>
                f_1074_18612_18673(string[]
                source, System.Func<string, string>
                keySelector)
                {
                    var return_v = source.OrderBy<string, string>(keySelector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 18612, 18673);
                    return return_v;
                }


                string
                f_1074_18612_18689(System.Linq.IOrderedEnumerable<string>
                source)
                {
                    var return_v = source.LastOrDefault<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 18612, 18689);
                    return return_v;
                }


                bool
                f_1074_18715_18759(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 18715, 18759);
                    return return_v;
                }


                string
                f_1074_19001_19018(System.Reflection.AssemblyName
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1074, 19001, 19018);
                    return return_v;
                }


                string[]
                f_1074_18955_19022(string
                path, string
                searchPattern)
                {
                    var return_v = Directory.GetFiles(path, searchPattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 18955, 19022);
                    return return_v;
                }


                string
                f_1074_18955_19039(string[]
                source)
                {
                    var return_v = source.FirstOrDefault<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 18955, 19039);
                    return return_v;
                }


                bool
                f_1074_19069_19108(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 19069, 19108);
                    return return_v;
                }


                System.Reflection.AssemblyName
                f_1074_19186_19240(string
                assemblyPath)
                {
                    var return_v = AssemblyLoadContext.GetAssemblyName(assemblyPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 19186, 19240);
                    return return_v;
                }


                bool
                f_1074_19271_19317(System.Management.Automation.PowerShellAssemblyLoadContext
                this_param, System.Reflection.AssemblyName
                requestedAssembly, System.Reflection.AssemblyName
                loadedAssembly)
                {
                    var return_v = this_param.IsAssemblyMatching(requestedAssembly, loadedAssembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 19271, 19317);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1074, 18046, 19591);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1074, 18046, 19591);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool TryGetAssemblyFromCache(AssemblyName assemblyName, out Assembly asmLoaded)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1074, 19717, 20493);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 19829, 20453) || true) && (f_1074_19833_19894(s_assemblyCache, f_1074_19861_19878(assemblyName), out asmLoaded))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1074, 19829, 20453);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 19993, 20085) || true) && (f_1074_19997_20050(this, assemblyName, f_1074_20030_20049(asmLoaded)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1074, 19993, 20085);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 20073, 20085);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1074, 19993, 20085);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 20317, 20438);

                    f_1074_20317_20437(this, ManifestDefinitionDoesNotMatch, f_1074_20415_20436(assemblyName));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1074, 19829, 20453);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 20469, 20482);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1074, 19717, 20493);

                string
                f_1074_19861_19878(System.Reflection.AssemblyName
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1074, 19861, 19878);
                    return return_v;
                }


                bool
                f_1074_19833_19894(System.Collections.Concurrent.ConcurrentDictionary<string, System.Reflection.Assembly>
                this_param, string
                key, out System.Reflection.Assembly
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 19833, 19894);
                    return return_v;
                }


                System.Reflection.AssemblyName
                f_1074_20030_20049(System.Reflection.Assembly
                this_param)
                {
                    var return_v = this_param.GetName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 20030, 20049);
                    return return_v;
                }


                bool
                f_1074_19997_20050(System.Management.Automation.PowerShellAssemblyLoadContext
                this_param, System.Reflection.AssemblyName
                requestedAssembly, System.Reflection.AssemblyName
                loadedAssembly)
                {
                    var return_v = this_param.IsAssemblyMatching(requestedAssembly, loadedAssembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 19997, 20050);
                    return return_v;
                }


                string
                f_1074_20415_20436(System.Reflection.AssemblyName
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1074, 20415, 20436);
                    return return_v;
                }


                int
                f_1074_20317_20437(System.Management.Automation.PowerShellAssemblyLoadContext
                this_param, string
                errorTemplate, params object[]
                args)
                {
                    this_param.ThrowFileLoadException(errorTemplate, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 20317, 20437);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1074, 19717, 20493);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1074, 19717, 20493);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsAssemblyMatching(AssemblyName requestedAssembly, AssemblyName loadedAssembly)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1074, 20828, 23040);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 21678, 21844) || true) && (f_1074_21682_21707(requestedAssembly) != null && (DynAbs.Tracing.TraceSender.Expression_True(1074, 21682, 21782) && f_1074_21719_21778(f_1074_21719_21744(requestedAssembly), f_1074_21755_21777(loadedAssembly)) > 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1074, 21678, 21844);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 21816, 21829);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1074, 21678, 21844);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 21949, 22009);

                string
                requestedCultureName = f_1074_21979_22008(requestedAssembly)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 22023, 22228) || true) && (!f_1074_22028_22070(requestedCultureName) && (DynAbs.Tracing.TraceSender.Expression_True(1074, 22027, 22166) && !f_1074_22075_22166(requestedCultureName, f_1074_22103_22129(loadedAssembly), StringComparison.OrdinalIgnoreCase)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1074, 22023, 22228);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 22200, 22213);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1074, 22023, 22228);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 22347, 22418);

                byte[]
                requestedPublicKeyToken = f_1074_22380_22417(requestedAssembly)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 22432, 22497);

                byte[]
                loadedPublicKeyToken = f_1074_22462_22496(loadedAssembly)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 22513, 23001) || true) && (requestedPublicKeyToken != null && (DynAbs.Tracing.TraceSender.Expression_True(1074, 22517, 22586) && f_1074_22552_22582(requestedPublicKeyToken) > 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1074, 22513, 23001);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 22620, 22753) || true) && (loadedPublicKeyToken == null || (DynAbs.Tracing.TraceSender.Expression_False(1074, 22624, 22717) || f_1074_22656_22686(requestedPublicKeyToken) != f_1074_22690_22717(loadedPublicKeyToken)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1074, 22620, 22753);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 22740, 22753);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1074, 22620, 22753);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 22782, 22787);

                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 22773, 22986) || true) && (i < f_1074_22793_22823(requestedPublicKeyToken))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 22825, 22828)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1074, 22773, 22986))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1074, 22773, 22986);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 22870, 22967) || true) && (requestedPublicKeyToken[i] != loadedPublicKeyToken[i])
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1074, 22870, 22967);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 22954, 22967);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1074, 22870, 22967);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1074, 1, 214);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1074, 1, 214);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1074, 22513, 23001);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 23017, 23029);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1074, 20828, 23040);

                System.Version
                f_1074_21682_21707(System.Reflection.AssemblyName
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1074, 21682, 21707);
                    return return_v;
                }


                System.Version
                f_1074_21719_21744(System.Reflection.AssemblyName
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1074, 21719, 21744);
                    return return_v;
                }


                System.Version
                f_1074_21755_21777(System.Reflection.AssemblyName
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1074, 21755, 21777);
                    return return_v;
                }


                int
                f_1074_21719_21778(System.Version
                this_param, System.Version
                value)
                {
                    var return_v = this_param.CompareTo(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 21719, 21778);
                    return return_v;
                }


                string
                f_1074_21979_22008(System.Reflection.AssemblyName
                this_param)
                {
                    var return_v = this_param.CultureName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1074, 21979, 22008);
                    return return_v;
                }


                bool
                f_1074_22028_22070(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 22028, 22070);
                    return return_v;
                }


                string
                f_1074_22103_22129(System.Reflection.AssemblyName
                this_param)
                {
                    var return_v = this_param.CultureName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1074, 22103, 22129);
                    return return_v;
                }


                bool
                f_1074_22075_22166(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 22075, 22166);
                    return return_v;
                }


                byte[]?
                f_1074_22380_22417(System.Reflection.AssemblyName
                this_param)
                {
                    var return_v = this_param.GetPublicKeyToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 22380, 22417);
                    return return_v;
                }


                byte[]?
                f_1074_22462_22496(System.Reflection.AssemblyName
                this_param)
                {
                    var return_v = this_param.GetPublicKeyToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 22462, 22496);
                    return return_v;
                }


                int
                f_1074_22552_22582(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1074, 22552, 22582);
                    return return_v;
                }


                int
                f_1074_22656_22686(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1074, 22656, 22686);
                    return return_v;
                }


                int
                f_1074_22690_22717(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1074, 22690, 22717);
                    return return_v;
                }


                int
                f_1074_22793_22823(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1074, 22793, 22823);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1074, 20828, 23040);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1074, 20828, 23040);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Assembly GetTrustedPlatformAssembly(string tpaStrongName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1074, 23324, 24007);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 23842, 23902);

                AssemblyName
                assemblyName = f_1074_23870_23901(tpaStrongName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 23916, 23965);

                Assembly
                asmLoaded = f_1074_23937_23964(assemblyName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 23979, 23996);

                return asmLoaded;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1074, 23324, 24007);

                System.Reflection.AssemblyName
                f_1074_23870_23901(string
                assemblyName)
                {
                    var return_v = new System.Reflection.AssemblyName(assemblyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 23870, 23901);
                    return return_v;
                }


                System.Reflection.Assembly
                f_1074_23937_23964(System.Reflection.AssemblyName
                assemblyRef)
                {
                    var return_v = Assembly.Load(assemblyRef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 23937, 23964);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1074, 23324, 24007);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1074, 23324, 24007);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ThrowFileLoadException(string errorTemplate, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1074, 24104, 24350);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 24208, 24288);

                string
                message = f_1074_24225_24287(f_1074_24239_24265(), errorTemplate, args)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 24302, 24339);

                throw f_1074_24308_24338(message);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1074, 24104, 24350);

                System.Globalization.CultureInfo
                f_1074_24239_24265()
                {
                    var return_v = CultureInfo.CurrentCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1074, 24239, 24265);
                    return return_v;
                }


                string
                f_1074_24225_24287(System.Globalization.CultureInfo
                provider, string
                format, params object[]
                args)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 24225, 24287);
                    return return_v;
                }


                System.IO.FileLoadException
                f_1074_24308_24338(string
                message)
                {
                    var return_v = new System.IO.FileLoadException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 24308, 24338);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1074, 24104, 24350);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1074, 24104, 24350);
            }
        }

        private void ThrowFileNotFoundException(string errorTemplate, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1074, 24451, 24705);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 24559, 24639);

                string
                message = f_1074_24576_24638(f_1074_24590_24616(), errorTemplate, args)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 24653, 24694);

                throw f_1074_24659_24693(message);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1074, 24451, 24705);

                System.Globalization.CultureInfo
                f_1074_24590_24616()
                {
                    var return_v = CultureInfo.CurrentCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1074, 24590, 24616);
                    return return_v;
                }


                string
                f_1074_24576_24638(System.Globalization.CultureInfo
                provider, string
                format, params object[]
                args)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 24576, 24638);
                    return return_v;
                }


                System.IO.FileNotFoundException
                f_1074_24659_24693(string
                message)
                {
                    var return_v = new System.IO.FileNotFoundException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 24659, 24693);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1074, 24451, 24705);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1074, 24451, 24705);
            }
        }

        private static string s_nativeDllSubFolder;

        private static string s_nativeDllExtension;

        private static string GetNativeDllSubFolderName(out string ext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1074, 24825, 25672);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 24913, 24946);

                string
                folderName = string.Empty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 24960, 24979);

                ext = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 24993, 25080);

                var
                processArch = f_1074_25011_25079(f_1074_25011_25060(f_1074_25011_25049()))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 25096, 25627) || true) && (f_1074_25100_25151(OSPlatform.Windows))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1074, 25096, 25627);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 25185, 25219);

                    folderName = "win-" + processArch;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 25237, 25250);

                    ext = ".dll";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1074, 25096, 25627);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1074, 25096, 25627);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 25284, 25627) || true) && (f_1074_25288_25337(OSPlatform.Linux))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1074, 25284, 25627);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 25371, 25407);

                        folderName = "linux-" + processArch;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 25425, 25437);

                        ext = ".so";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1074, 25284, 25627);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1074, 25284, 25627);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 25471, 25627) || true) && (f_1074_25475_25522(OSPlatform.OSX))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1074, 25471, 25627);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 25556, 25579);

                            folderName = "osx-x64";
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 25597, 25612);

                            ext = ".dylib";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1074, 25471, 25627);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1074, 25284, 25627);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1074, 25096, 25627);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 25643, 25661);

                return folderName;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1074, 24825, 25672);

                System.Runtime.InteropServices.Architecture
                f_1074_25011_25049()
                {
                    var return_v = RuntimeInformation.ProcessArchitecture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1074, 25011, 25049);
                    return return_v;
                }


                string
                f_1074_25011_25060(System.Runtime.InteropServices.Architecture
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 25011, 25060);
                    return return_v;
                }


                string
                f_1074_25011_25079(string
                this_param)
                {
                    var return_v = this_param.ToLowerInvariant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 25011, 25079);
                    return return_v;
                }


                bool
                f_1074_25100_25151(System.Runtime.InteropServices.OSPlatform
                osPlatform)
                {
                    var return_v = RuntimeInformation.IsOSPlatform(osPlatform);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 25100, 25151);
                    return return_v;
                }


                bool
                f_1074_25288_25337(System.Runtime.InteropServices.OSPlatform
                osPlatform)
                {
                    var return_v = RuntimeInformation.IsOSPlatform(osPlatform);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 25288, 25337);
                    return return_v;
                }


                bool
                f_1074_25475_25522(System.Runtime.InteropServices.OSPlatform
                osPlatform)
                {
                    var return_v = RuntimeInformation.IsOSPlatform(osPlatform);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 25475, 25522);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1074, 24825, 25672);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1074, 24825, 25672);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PowerShellAssemblyLoadContext()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1074, 490, 25717);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 1699, 1766);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 1798, 1980);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 2012, 2120);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 5259, 5283);
            s_syncObj = f_1074_5271_5283();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 7256, 7363);
            s_assemblyCache = f_1074_7287_7363(f_1074_7330_7362());
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 7548, 7655);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 24739, 24759);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 24792, 24812);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1074, 490, 25717);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1074, 490, 25717);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1074, 490, 25717);

        bool
        f_1074_3449_3480(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 3449, 3480);
            return return_v;
        }


        string[]
        f_1074_3530_3551()
        {
            var return_v = Array.Empty<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 3530, 3551);
            return return_v;
        }


        string[]
        f_1074_3634_3708(string
        this_param, char[]
        separator, System.StringSplitOptions
        options)
        {
            var return_v = this_param.Split(separator, options);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 3634, 3708);
            return return_v;
        }


        int
        f_1074_3747_3767(string[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1074, 3747, 3767);
            return return_v;
        }


        bool
        f_1074_3876_3902(string
        path)
        {
            var return_v = Directory.Exists(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 3876, 3902);
            return return_v;
        }


        System.Globalization.CultureInfo
        f_1074_3983_4009()
        {
            var return_v = CultureInfo.CurrentCulture;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1074, 3983, 4009);
            return return_v;
        }


        string
        f_1074_3969_4044(System.Globalization.CultureInfo
        provider, string
        format, string
        arg0)
        {
            var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 3969, 4044);
            return return_v;
        }


        System.ArgumentException
        f_1074_4077_4120(string
        message, string
        paramName)
        {
            var return_v = new System.ArgumentException(message, paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 4077, 4120);
            return return_v;
        }


        string
        f_1074_4187_4202(string
        this_param)
        {
            var return_v = this_param.Trim();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 4187, 4202);
            return return_v;
        }


        System.Collections.Generic.Dictionary<string, string>
        f_1074_4364_4387(System.Management.Automation.PowerShellAssemblyLoadContext
        this_param)
        {
            var return_v = this_param.InitializeTypeCatalog();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 4364, 4387);
            return return_v;
        }


        System.Lazy<System.Collections.Generic.HashSet<string>>
        f_1074_4434_4560(System.Func<System.Collections.Generic.HashSet<string>>
        valueFactory)
        {
            var return_v = new System.Lazy<System.Collections.Generic.HashSet<string>>(valueFactory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 4434, 4560);
            return return_v;
        }


        System.Runtime.Loader.AssemblyLoadContext
        f_1074_4697_4724()
        {
            var return_v =
                        // LAST: Register the 'Resolving' handler and 'ResolvingUnmanagedDll' handler on the default load context.
                        AssemblyLoadContext.Default;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1074, 4697, 4724);
            return return_v;
        }


        System.Runtime.Loader.AssemblyLoadContext
        f_1074_5075_5102()
        {
            var return_v =
                        // Add last resort native dll resolver.
                        // Default order:
                        //      1. System.Runtime.InteropServices.DllImportResolver callbacks
                        //      2. AssemblyLoadContext.LoadUnmanagedDll()
                        //      3. AssemblyLoadContext.Default.ResolvingUnmanagedDll handlers
                        AssemblyLoadContext.Default;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1074, 5075, 5102);
            return return_v;
        }


        static object
        f_1074_5271_5283()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 5271, 5283);
            return return_v;
        }


        System.StringComparer
        f_1074_5852_5884()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1074, 5852, 5884);
            return return_v;
        }


        static System.StringComparer
        f_1074_7330_7362()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1074, 7330, 7362);
            return return_v;
        }


        static System.Collections.Concurrent.ConcurrentDictionary<string, System.Reflection.Assembly>
        f_1074_7287_7363(System.StringComparer
        comparer)
        {
            var return_v = new System.Collections.Concurrent.ConcurrentDictionary<string, System.Reflection.Assembly>((System.Collections.Generic.IEqualityComparer<string>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 7287, 7363);
            return return_v;
        }

    }
    public class PowerShellAssemblyLoadContextInitializer
    {
        public static void SetPowerShellAssemblyLoadContext([MarshalAs(UnmanagedType.LPWStr)] string basePaths)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1074, 26606, 26920);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 26733, 26832) || true) && (f_1074_26737_26768(basePaths))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1074, 26733, 26832);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 26787, 26832);

                    throw f_1074_26793_26831("basePaths");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1074, 26733, 26832);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1074, 26848, 26909);

                f_1074_26848_26908(basePaths);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1074, 26606, 26920);

                bool
                f_1074_26737_26768(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 26737, 26768);
                    return return_v;
                }


                System.ArgumentNullException
                f_1074_26793_26831(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 26793, 26831);
                    return return_v;
                }


                System.Management.Automation.PowerShellAssemblyLoadContext
                f_1074_26848_26908(string
                basePaths)
                {
                    var return_v = PowerShellAssemblyLoadContext.InitializeSingleton(basePaths);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1074, 26848, 26908);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1074, 26606, 26920);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1074, 26606, 26920);
            }
        }

        public PowerShellAssemblyLoadContextInitializer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1074, 25863, 26927);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1074, 25863, 26927);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1074, 25863, 26927);
        }


        static PowerShellAssemblyLoadContextInitializer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1074, 25863, 26927);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1074, 25863, 26927);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1074, 25863, 26927);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1074, 25863, 26927);
    }
}
