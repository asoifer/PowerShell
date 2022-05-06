// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;

using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.Management.Automation
{
    public static class Platform
    {
        private static string _tempDirectory;

        public static bool IsLinux
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1075, 703, 811);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 739, 796);

                    return f_1075_746_795(OSPlatform.Linux);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1075, 703, 811);

                    bool
                    f_1075_746_795(System.Runtime.InteropServices.OSPlatform
                    osPlatform)
                    {
                        var return_v = RuntimeInformation.IsOSPlatform(osPlatform);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 746, 795);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1075, 652, 822);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1075, 652, 822);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static bool IsMacOS
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1075, 984, 1090);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 1020, 1075);

                    return f_1075_1027_1074(OSPlatform.OSX);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1075, 984, 1090);

                    bool
                    f_1075_1027_1074(System.Runtime.InteropServices.OSPlatform
                    osPlatform)
                    {
                        var return_v = RuntimeInformation.IsOSPlatform(osPlatform);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 1027, 1074);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1075, 933, 1101);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1075, 933, 1101);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static bool IsWindows
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1075, 1267, 1377);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 1303, 1362);

                    return f_1075_1310_1361(OSPlatform.Windows);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1075, 1267, 1377);

                    bool
                    f_1075_1310_1361(System.Runtime.InteropServices.OSPlatform
                    osPlatform)
                    {
                        var return_v = RuntimeInformation.IsOSPlatform(osPlatform);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 1310, 1361);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1075, 1214, 1388);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1075, 1214, 1388);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static bool IsCoreCLR
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1075, 1563, 1626);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 1599, 1611);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1075, 1563, 1626);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1075, 1510, 1637);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1075, 1510, 1637);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static bool IsNanoServer
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1075, 1810, 2633);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 1894, 1953) || true) && (f_1075_1898_1920(_isNanoServer))
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1075, 1894, 1953);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 1924, 1951);

                        return f_1075_1931_1950(_isNanoServer);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1075, 1894, 1953);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 1973, 1995);

                    _isNanoServer = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 2013, 2563);
                    using (RegistryKey
                    regKey = f_1075_2041_2142(Registry.LocalMachine, @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Server\ServerLevels")
                    )
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 2184, 2544) || true) && (regKey != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1075, 2184, 2544);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 2252, 2297);

                            object
                            value = f_1075_2267_2296(regKey, "NanoServer")
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 2323, 2521) || true) && (value != null && (DynAbs.Tracing.TraceSender.Expression_True(1075, 2327, 2404) && f_1075_2344_2377(regKey, "NanoServer") == RegistryValueKind.DWord))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1075, 2323, 2521);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 2462, 2494);

                                _isNanoServer = (int)value == 1;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1075, 2323, 2521);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1075, 2184, 2544);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitUsing(1075, 2013, 2563);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 2583, 2610);

                    return f_1075_2590_2609(_isNanoServer);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1075, 1810, 2633);

                    bool
                    f_1075_1898_1920(bool?
                    this_param)
                    {
                        var return_v = this_param.HasValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1075, 1898, 1920);
                        return return_v;
                    }


                    bool
                    f_1075_1931_1950(bool?
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1075, 1931, 1950);
                        return return_v;
                    }


                    Microsoft.Win32.RegistryKey
                    f_1075_2041_2142(Microsoft.Win32.RegistryKey
                    this_param, string
                    name)
                    {
                        var return_v = this_param.OpenSubKey(name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 2041, 2142);
                        return return_v;
                    }


                    object
                    f_1075_2267_2296(Microsoft.Win32.RegistryKey
                    this_param, string
                    name)
                    {
                        var return_v = this_param.GetValue(name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 2267, 2296);
                        return return_v;
                    }


                    Microsoft.Win32.RegistryValueKind
                    f_1075_2344_2377(Microsoft.Win32.RegistryKey
                    this_param, string
                    name)
                    {
                        var return_v = this_param.GetValueKind(name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 2344, 2377);
                        return return_v;
                    }


                    bool
                    f_1075_2590_2609(bool?
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1075, 2590, 2609);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1075, 1754, 2644);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1075, 1754, 2644);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static bool IsIoT
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1075, 2803, 3633);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 2887, 2932) || true) && (f_1075_2891_2906(_isIoT))
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1075, 2887, 2932);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 2910, 2930);

                        return f_1075_2917_2929(_isIoT);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1075, 2887, 2932);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 2952, 2967);

                    _isIoT = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 2985, 3570);
                    using (RegistryKey
                    regKey = f_1075_3013_3094(Registry.LocalMachine, @"SOFTWARE\Microsoft\Windows NT\CurrentVersion")
                    )
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 3136, 3551) || true) && (regKey != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1075, 3136, 3551);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 3204, 3250);

                            object
                            value = f_1075_3219_3249(regKey, "ProductName")
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 3276, 3528) || true) && (value != null && (DynAbs.Tracing.TraceSender.Expression_True(1075, 3280, 3359) && f_1075_3297_3331(regKey, "ProductName") == RegistryValueKind.String))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1075, 3276, 3528);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 3417, 3501);

                                _isIoT = f_1075_3426_3500("IoTUAP", value, StringComparison.OrdinalIgnoreCase);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1075, 3276, 3528);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1075, 3136, 3551);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitUsing(1075, 2985, 3570);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 3590, 3610);

                    return f_1075_3597_3609(_isIoT);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1075, 2803, 3633);

                    bool
                    f_1075_2891_2906(bool?
                    this_param)
                    {
                        var return_v = this_param.HasValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1075, 2891, 2906);
                        return return_v;
                    }


                    bool
                    f_1075_2917_2929(bool?
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1075, 2917, 2929);
                        return return_v;
                    }


                    Microsoft.Win32.RegistryKey
                    f_1075_3013_3094(Microsoft.Win32.RegistryKey
                    this_param, string
                    name)
                    {
                        var return_v = this_param.OpenSubKey(name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 3013, 3094);
                        return return_v;
                    }


                    object
                    f_1075_3219_3249(Microsoft.Win32.RegistryKey
                    this_param, string
                    name)
                    {
                        var return_v = this_param.GetValue(name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 3219, 3249);
                        return return_v;
                    }


                    Microsoft.Win32.RegistryValueKind
                    f_1075_3297_3331(Microsoft.Win32.RegistryKey
                    this_param, string
                    name)
                    {
                        var return_v = this_param.GetValueKind(name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 3297, 3331);
                        return return_v;
                    }


                    bool
                    f_1075_3426_3500(string
                    a, object
                    b, System.StringComparison
                    comparisonType)
                    {
                        var return_v = string.Equals(a, (string)b, comparisonType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 3426, 3500);
                        return return_v;
                    }


                    bool
                    f_1075_3597_3609(bool?
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1075, 3597, 3609);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1075, 2754, 3644);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1075, 2754, 3644);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static bool IsWindowsDesktop
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1075, 3822, 4109);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 3906, 3973) || true) && (f_1075_3910_3936(_isWindowsDesktop))
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1075, 3906, 3973);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 3940, 3971);

                        return f_1075_3947_3970(_isWindowsDesktop);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1075, 3906, 3973);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 3993, 4037);

                    _isWindowsDesktop = f_1075_4013_4026_M(!IsNanoServer) && (DynAbs.Tracing.TraceSender.Expression_True(1075, 4013, 4036) && f_1075_4030_4036_M(!IsIoT));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 4055, 4086);

                    return f_1075_4062_4085(_isWindowsDesktop);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1075, 3822, 4109);

                    bool
                    f_1075_3910_3936(bool?
                    this_param)
                    {
                        var return_v = this_param.HasValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1075, 3910, 3936);
                        return return_v;
                    }


                    bool
                    f_1075_3947_3970(bool?
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1075, 3947, 3970);
                        return return_v;
                    }


                    bool
                    f_1075_4013_4026_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1075, 4013, 4026);
                        return return_v;
                    }


                    bool
                    f_1075_4030_4036_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1075, 4030, 4036);
                        return return_v;
                    }


                    bool
                    f_1075_4062_4085(bool?
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1075, 4062, 4085);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1075, 3762, 4120);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1075, 3762, 4120);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static readonly string CacheDirectory;

        internal static readonly string ConfigDirectory;

        private static bool? _isNanoServer;

        private static bool? _isIoT;

        private static bool? _isWindowsDesktop;

        internal static List<string> FormatFileNames;
        internal static class CommonEnvVariableNames
        {
            internal const string
            Home = "USERPROFILE"
            ;

            static CommonEnvVariableNames()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1075, 5762, 5960);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 5920, 5940);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1075, 5762, 5960);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1075, 5762, 5960);
            }

        }

        internal static void RemoveTemporaryDirectory()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1075, 6096, 6503);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 6168, 6250) || true) && (_tempDirectory == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1075, 6168, 6250);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 6228, 6235);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1075, 6168, 6250);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 6302, 6341);

                    f_1075_6302_6340(_tempDirectory, true);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1075, 6370, 6454);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1075, 6370, 6454);
                    // ignore if there is a failure
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 6470, 6492);

                _tempDirectory = null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1075, 6096, 6503);

                int
                f_1075_6302_6340(string
                path, bool
                recursive)
                {
                    Directory.Delete(path, recursive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 6302, 6340);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1075, 6096, 6503);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1075, 6096, 6503);
            }
        }

        internal static string GetTemporaryDirectory()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1075, 6633, 6913);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 6704, 6801) || true) && (_tempDirectory != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1075, 6704, 6801);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 6764, 6786);

                    return _tempDirectory;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1075, 6704, 6801);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 6817, 6866);

                _tempDirectory = f_1075_6834_6865();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 6880, 6902);

                return _tempDirectory;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1075, 6633, 6913);

                string
                f_1075_6834_6865()
                {
                    var return_v = PsUtils.GetTemporaryDirectory();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 6834, 6865);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1075, 6633, 6913);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1075, 6633, 6913);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string GetFolderPath(System.Environment.SpecialFolder folder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1075, 14630, 14780);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 14732, 14769);

                return f_1075_14739_14768(folder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1075, 14630, 14780);

                string
                f_1075_14739_14768(System.Environment.SpecialFolder
                folder)
                {
                    var return_v = InternalGetFolderPath(folder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 14739, 14768);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1075, 14630, 14780);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1075, 14630, 14780);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string InternalGetFolderPath(System.Environment.SpecialFolder folder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1075, 15333, 17661);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 15442, 15467);

                string
                folderPath = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 17540, 17594);

                folderPath = f_1075_17553_17593(folder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 17616, 17650);

                return folderPath ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1075, 17623, 17649) ?? string.Empty);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1075, 15333, 17661);

                string
                f_1075_17553_17593(System.Environment.SpecialFolder
                folder)
                {
                    var return_v = System.Environment.GetFolderPath(folder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 17553, 17593);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1075, 15333, 17661);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1075, 15333, 17661);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool NonWindowsIsHardLink(ref IntPtr handle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1075, 18269, 18400);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 18354, 18389);

                return f_1075_18361_18388(ref handle);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1075, 18269, 18400);

                bool
                f_1075_18361_18388(ref System.IntPtr
                handle)
                {
                    var return_v = Unix.IsHardLink(ref handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 18361, 18388);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1075, 18269, 18400);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1075, 18269, 18400);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool NonWindowsIsHardLink(FileSystemInfo fileInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1075, 18412, 18547);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 18503, 18536);

                return f_1075_18510_18535(fileInfo);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1075, 18412, 18547);

                bool
                f_1075_18510_18535(System.IO.FileSystemInfo
                fs)
                {
                    var return_v = Unix.IsHardLink(fs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 18510, 18535);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1075, 18412, 18547);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1075, 18412, 18547);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string NonWindowsInternalGetTarget(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1075, 18559, 18704);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 18647, 18693);

                return f_1075_18654_18692(path);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1075, 18559, 18704);

                string
                f_1075_18654_18692(string
                filePath)
                {
                    var return_v = Unix.NativeMethods.FollowSymLink(filePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 18654, 18692);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1075, 18559, 18704);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1075, 18559, 18704);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string NonWindowsGetUserFromPid(int path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1075, 18716, 18856);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 18798, 18845);

                return f_1075_18805_18844(path);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1075, 18716, 18856);

                string
                f_1075_18805_18844(int
                pid)
                {
                    var return_v = Unix.NativeMethods.GetUserFromPid(pid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 18805, 18844);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1075, 18716, 18856);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1075, 18716, 18856);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string NonWindowsInternalGetLinkType(FileSystemInfo fileInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1075, 18868, 19267);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 18970, 19111) || true) && (f_1075_18974_19040(f_1075_18974_18993(fileInfo), System.IO.FileAttributes.ReparsePoint))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1075, 18970, 19111);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 19074, 19096);

                    return "SymbolicLink";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1075, 18970, 19111);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 19127, 19228) || true) && (f_1075_19131_19161(fileInfo))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1075, 19127, 19228);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 19195, 19213);

                    return "HardLink";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1075, 19127, 19228);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 19244, 19256);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1075, 18868, 19267);

                System.IO.FileAttributes
                f_1075_18974_18993(System.IO.FileSystemInfo
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1075, 18974, 18993);
                    return return_v;
                }


                bool
                f_1075_18974_19040(System.IO.FileAttributes
                this_param, System.IO.FileAttributes
                flag)
                {
                    var return_v = this_param.HasFlag((System.Enum)flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 18974, 19040);
                    return return_v;
                }


                bool
                f_1075_19131_19161(System.IO.FileSystemInfo
                fileInfo)
                {
                    var return_v = NonWindowsIsHardLink(fileInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 19131, 19161);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1075, 18868, 19267);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1075, 18868, 19267);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool NonWindowsCreateSymbolicLink(string path, string target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1075, 19279, 19518);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 19448, 19507);

                return f_1075_19455_19501(path, target) == 0;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1075, 19279, 19518);

                int
                f_1075_19455_19501(string
                filePath, string
                target)
                {
                    var return_v = Unix.NativeMethods.CreateSymLink(filePath, target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 19455, 19501);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1075, 19279, 19518);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1075, 19279, 19518);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool NonWindowsCreateHardLink(string path, string strTargetPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1075, 19530, 19713);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 19635, 19702);

                return f_1075_19642_19696(path, strTargetPath) == 0;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1075, 19530, 19713);

                int
                f_1075_19642_19696(string
                filePath, string
                target)
                {
                    var return_v = Unix.NativeMethods.CreateHardLink(filePath, target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 19642, 19696);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1075, 19530, 19713);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1075, 19530, 19713);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static unsafe bool NonWindowsSetDate(DateTime dateToUse)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1075, 19725, 19962);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 19815, 19893);

                Unix.NativeMethods.UnixTm
                tm = f_1075_19846_19892(dateToUse)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 19907, 19951);

                return f_1075_19914_19945(&tm) == 0;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1075, 19725, 19962);

                System.Management.Automation.Platform.Unix.NativeMethods.UnixTm
                f_1075_19846_19892(System.DateTime
                date)
                {
                    var return_v = Unix.NativeMethods.DateTimeToUnixTm(date);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 19846, 19892);
                    return return_v;
                }


                unsafe int
                f_1075_19914_19945(System.Management.Automation.Platform.Unix.NativeMethods.UnixTm*
                tm)
                {
                    var return_v = Unix.NativeMethods.SetDate(tm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 19914, 19945);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1075, 19725, 19962);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1075, 19725, 19962);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool NonWindowsIsSameFileSystemItem(string pathOne, string pathTwo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1075, 19974, 20158);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 20082, 20147);

                return f_1075_20089_20146(pathOne, pathTwo);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1075, 19974, 20158);

                bool
                f_1075_20089_20146(string
                filePathOne, string
                filePathTwo)
                {
                    var return_v = Unix.NativeMethods.IsSameFileSystemItem(filePathOne, filePathTwo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 20089, 20146);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1075, 19974, 20158);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1075, 19974, 20158);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool NonWindowsGetInodeData(string path, out System.ValueTuple<UInt64, UInt64> inodeData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1075, 20170, 20529);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 20300, 20320);

                UInt64
                device = 0UL
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 20334, 20353);

                UInt64
                inode = 0UL
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 20367, 20441);

                var
                result = f_1075_20380_20440(path, out device, out inode)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 20457, 20485);

                inodeData = (device, inode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 20499, 20518);

                return result == 0;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1075, 20170, 20529);

                int
                f_1075_20380_20440(string
                path, out ulong
                device, out ulong
                inode)
                {
                    var return_v = Unix.NativeMethods.GetInodeData(path, out device, out inode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 20380, 20440);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1075, 20170, 20529);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1075, 20170, 20529);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool NonWindowsIsExecutable(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1075, 20541, 20678);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 20622, 20667);

                return f_1075_20629_20666(path);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1075, 20541, 20678);

                bool
                f_1075_20629_20666(string
                filePath)
                {
                    var return_v = Unix.NativeMethods.IsExecutable(filePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 20629, 20666);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1075, 20541, 20678);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1075, 20541, 20678);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static uint NonWindowsGetThreadId()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1075, 20690, 20817);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 20759, 20806);

                return f_1075_20766_20805();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1075, 20690, 20817);

                uint
                f_1075_20766_20805()
                {
                    var return_v = Unix.NativeMethods.GetCurrentThreadId();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 20766, 20805);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1075, 20690, 20817);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1075, 20690, 20817);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int NonWindowsGetProcessParentPid(int pid)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1075, 20829, 21003);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 20912, 20992);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1075, 20919, 20926) || ((f_1075_20919_20926() && DynAbs.Tracing.TraceSender.Conditional_F2(1075, 20929, 20960)) || DynAbs.Tracing.TraceSender.Conditional_F3(1075, 20963, 20991))) ? f_1075_20929_20960(pid) : f_1075_20963_20991(pid);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1075, 20829, 21003);

                bool
                f_1075_20919_20926()
                {
                    var return_v = IsMacOS;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1075, 20919, 20926);
                    return return_v;
                }


                int
                f_1075_20929_20960(int
                pid)
                {
                    var return_v = Unix.NativeMethods.GetPPid(pid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 20929, 20960);
                    return return_v;
                }


                int
                f_1075_20963_20991(int
                pid)
                {
                    var return_v = Unix.GetProcFSParentPid(pid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 20963, 20991);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1075, 20829, 21003);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1075, 20829, 21003);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        internal static class Unix
        {
            private static Dictionary<int, string> usernameCache;

            private static Dictionary<int, string> groupnameCache;

            /// <summary>The type of a Unix file system item.</summary>
            public enum ItemType
            {
                /// <summary>The item is a Directory.</summary>
                Directory,

                /// <summary>The item is a File.</summary>
                File,

                /// <summary>The item is a Symbolic Link.</summary>
                SymbolicLink,

                /// <summary>The item is a Block Device.</summary>
                BlockDevice,

                /// <summary>The item is a Character Device.</summary>
                CharacterDevice,

                /// <summary>The item is a Named Pipe.</summary>
                NamedPipe,

                /// <summary>The item is a Socket.</summary>
                Socket,
            }

            /// <summary>The mask to use to retrieve specific mode bits from the mode value in the stat class.</summary>
            public enum StatMask
            {
                /// <summary>The mask to collect the owner mode.</summary>
                OwnerModeMask = 0x1C0,

                /// <summary>The mask to get the owners read bit.</summary>
                OwnerRead = 0x100,

                /// <summary>The mask to get the owners write bit.</summary>
                OwnerWrite = 0x080,

                /// <summary>The mask to get the owners execute bit.</summary>
                OwnerExecute = 0x040,

                /// <summary>The mask to get the group mode.</summary>
                GroupModeMask = 0x038,

                /// <summary>The mask to get the group mode.</summary>
                GroupRead = 0x20,

                /// <summary>The mask to get the group mode.</summary>
                GroupWrite = 0x10,

                /// <summary>The mask to get the group mode.</summary>
                GroupExecute = 0x8,

                /// <summary>The mask to get the "other" mode.</summary>
                OtherModeMask = 0x007,

                /// <summary>The mask to get the "other" read bit.</summary>
                OtherRead = 0x004,

                /// <summary>The mask to get the "other" write bit.</summary>
                OtherWrite = 0x002,

                /// <summary>The mask to get the "other" execute bit.</summary>
                OtherExecute = 0x001,

                /// <summary>The mask to retrieve the sticky bit.</summary>
                SetStickyMask = 0x200,

                /// <summary>The mask to retrieve the setgid bit.</summary>
                SetGidMask = 0x400,

                /// <summary>The mask to retrieve the setuid bit.</summary>
                SetUidMask = 0x800,
            }
            public class CommonStat
            {
                public long Inode;

                public int Mode;

                public int UserId;

                public int GroupId;

                public int HardlinkCount;

                public long Size;

                public DateTime AccessTime;

                public DateTime ModifiedTime;

                public DateTime StatusChangeTime;

                public long BlockSize;

                public int DeviceId;

                public int NumberOfBlocks;

                public ItemType ItemType;

                public bool IsSetUid;

                public bool IsSetGid;

                public bool IsSticky;

                private const char
                CanRead = 'r'
                ;

                private const char
                CanWrite = 'w'
                ;

                private const char
                CanExecute = 'x'
                ;

                private Dictionary<StatMask, char> modeMap;

                private StatMask[] permissions;

                private Dictionary<ItemType, char> itemTypeTable;

                public string GetModeString()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1075, 29077, 30709);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 29147, 29162);

                        int
                        offset = 0
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 29184, 29221);

                        char[]
                        modeCharacters = new char[10]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 29243, 29294);

                        modeCharacters[offset++] = f_1075_29270_29293(itemTypeTable, ItemType);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 29318, 30632);
                            foreach (StatMask permission in f_1075_29350_29361_I(permissions))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1075, 29318, 30632);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 29498, 30572) || true) && ((Mode & (int)permission) == (int)permission)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1075, 29498, 30572);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 29603, 30402) || true) && ((permission == StatMask.OwnerExecute && (DynAbs.Tracing.TraceSender.Expression_True(1075, 29608, 29655) && IsSetUid)) || (DynAbs.Tracing.TraceSender.Expression_False(1075, 29607, 29709) || (permission == StatMask.GroupExecute && (DynAbs.Tracing.TraceSender.Expression_True(1075, 29661, 29708) && IsSetGid))))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1075, 29603, 30402);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 29840, 29869);

                                        modeCharacters[offset] = 's';
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1075, 29603, 30402);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1075, 29603, 30402);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 29935, 30402) || true) && (permission == StatMask.OtherExecute && (DynAbs.Tracing.TraceSender.Expression_True(1075, 29939, 29986) && IsSticky) && (DynAbs.Tracing.TraceSender.Expression_True(1075, 29939, 30022) && (ItemType == ItemType.Directory)))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1075, 29935, 30402);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 30167, 30196);

                                            modeCharacters[offset] = 't';
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1075, 29935, 30402);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1075, 29935, 30402);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 30326, 30371);

                                            modeCharacters[offset] = f_1075_30351_30370(modeMap, permission);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1075, 29935, 30402);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1075, 29603, 30402);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1075, 29498, 30572);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1075, 29498, 30572);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 30516, 30545);

                                    modeCharacters[offset] = '-';
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1075, 29498, 30572);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 30600, 30609);

                                offset++;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1075, 29318, 30632);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1075, 1, 1315);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1075, 1, 1315);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 30656, 30690);

                        return f_1075_30663_30689(modeCharacters);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1075, 29077, 30709);

                        char
                        f_1075_29270_29293(System.Collections.Generic.Dictionary<System.Management.Automation.Platform.Unix.ItemType, char>
                        this_param, System.Management.Automation.Platform.Unix.ItemType
                        i0)
                        {
                            var return_v = this_param[i0];
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1075, 29270, 29293);
                            return return_v;
                        }


                        char
                        f_1075_30351_30370(System.Collections.Generic.Dictionary<System.Management.Automation.Platform.Unix.StatMask, char>
                        this_param, System.Management.Automation.Platform.Unix.StatMask
                        i0)
                        {
                            var return_v = this_param[i0];
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1075, 30351, 30370);
                            return return_v;
                        }


                        System.Management.Automation.Platform.Unix.StatMask[]
                        f_1075_29350_29361_I(System.Management.Automation.Platform.Unix.StatMask[]
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 29350, 29361);
                            return return_v;
                        }


                        string
                        f_1075_30663_30689(char[]
                        value)
                        {
                            var return_v = new string(value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 30663, 30689);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1075, 29077, 30709);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1075, 29077, 30709);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public string GetUserName()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1075, 31019, 31555);
                        string username = default(string);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 31087, 31234) || true) && (f_1075_31091_31145(usernameCache, UserId, out username))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1075, 31087, 31234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 31195, 31211);

                            return username;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1075, 31087, 31234);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 31396, 31438);

                        username = f_1075_31407_31437(UserId);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 31460, 31496);

                        f_1075_31460_31495(usernameCache, UserId, username);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 31520, 31536);

                        return username;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1075, 31019, 31555);

                        bool
                        f_1075_31091_31145(System.Collections.Generic.Dictionary<int, string>
                        this_param, int
                        key, out string
                        value)
                        {
                            var return_v = this_param.TryGetValue(key, out value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 31091, 31145);
                            return return_v;
                        }


                        string
                        f_1075_31407_31437(int
                        id)
                        {
                            var return_v = NativeMethods.GetPwUid(id);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 31407, 31437);
                            return return_v;
                        }


                        int
                        f_1075_31460_31495(System.Collections.Generic.Dictionary<int, string>
                        this_param, int
                        key, string
                        value)
                        {
                            this_param.Add(key, value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 31460, 31495);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1075, 31019, 31555);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1075, 31019, 31555);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public string GetGroupName()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1075, 31874, 32422);
                        string groupname = default(string);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 31943, 32094) || true) && (f_1075_31947_32004(groupnameCache, GroupId, out groupname))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1075, 31943, 32094);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 32054, 32071);

                            return groupname;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1075, 31943, 32094);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 32257, 32301);

                        groupname = f_1075_32269_32300(GroupId);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 32323, 32362);

                        f_1075_32323_32361(groupnameCache, GroupId, groupname);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 32386, 32403);

                        return groupname;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1075, 31874, 32422);

                        bool
                        f_1075_31947_32004(System.Collections.Generic.Dictionary<int, string>
                        this_param, int
                        key, out string
                        value)
                        {
                            var return_v = this_param.TryGetValue(key, out value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 31947, 32004);
                            return return_v;
                        }


                        string
                        f_1075_32269_32300(int
                        id)
                        {
                            var return_v = NativeMethods.GetGrGid(id);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 32269, 32300);
                            return return_v;
                        }


                        int
                        f_1075_32323_32361(System.Collections.Generic.Dictionary<int, string>
                        this_param, int
                        key, string
                        value)
                        {
                            this_param.Add(key, value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 32323, 32361);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1075, 31874, 32422);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1075, 31874, 32422);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public CommonStat()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1075, 24761, 32437);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 24903, 24908);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 25013, 25017);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 25125, 25131);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 25240, 25247);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 25369, 25382);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 25497, 25501);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 26028, 26037);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 26147, 26155);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 26277, 26291);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 26401, 26409);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 26538, 26546);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 26675, 26683);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 26852, 26860);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 27124, 27750);
                    this.modeMap = new Dictionary<StatMask, char>()
                {
                        { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => StatMask.OwnerRead,1075,27134,27750),CanRead },                        { StatMask.OwnerWrite, CanWrite },                        { StatMask.OwnerExecute, CanExecute },                        { StatMask.GroupRead, CanRead },                        { StatMask.GroupWrite, CanWrite },                        { StatMask.GroupExecute, CanExecute },                        { StatMask.OtherRead, CanRead },                        { StatMask.OtherWrite, CanWrite },                        { StatMask.OtherExecute, CanExecute }                };
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 27790, 28236);
                    this.permissions = new StatMask[]
                                    {
                    StatMask.OwnerRead,
                    StatMask.OwnerWrite,
                    StatMask.OwnerExecute,
                    StatMask.GroupRead,
                    StatMask.GroupWrite,
                    StatMask.GroupExecute,
                    StatMask.OtherRead,
                    StatMask.OtherWrite,
                    StatMask.OtherExecute
                                    };
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 28400, 28839);
                    this.itemTypeTable = new Dictionary<ItemType, char>()
                {
                    { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => ItemType.BlockDevice,1075,28416,28839),'b' },                    { ItemType.CharacterDevice, 'c' },                    { ItemType.Directory, 'd' },                    { ItemType.File, '-' },                    { ItemType.NamedPipe, 'p' },                    { ItemType.Socket, 's' },                    { ItemType.SymbolicLink, 'l' }                };
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1075, 24761, 32437);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1075, 24761, 32437);
                }


                static CommonStat()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1075, 24761, 32437);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 26900, 26913);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 26951, 26965);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 27003, 27019);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1075, 24761, 32437);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1075, 24761, 32437);
                }

                int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1075, 24761, 32437);
            }

            internal static ErrorCategory GetErrorCategory(int errno)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1075, 32545, 32715);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 32635, 32700);

                    return (ErrorCategory)f_1075_32657_32699(errno);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1075, 32545, 32715);

                    int
                    f_1075_32657_32699(int
                    errno)
                    {
                        var return_v = Unix.NativeMethods.GetErrorCategory(errno);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 32657, 32699);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1075, 32545, 32715);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1075, 32545, 32715);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public static bool IsHardLink(ref IntPtr handle)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1075, 32949, 33161);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 33133, 33146);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1075, 32949, 33161);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1075, 32949, 33161);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1075, 32949, 33161);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public static bool IsHardLink(FileSystemInfo fs)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1075, 33446, 34040);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 33527, 33689) || true) && (f_1075_33531_33541_M(!fs.Exists) || (DynAbs.Tracing.TraceSender.Expression_False(1075, 33531, 33615) || (f_1075_33546_33559(fs) & FileAttributes.Directory) == FileAttributes.Directory))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1075, 33527, 33689);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 33657, 33670);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1075, 33527, 33689);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 33709, 33719);

                    int
                    count
                    = default(int);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 33737, 33767);

                    string
                    filePath = f_1075_33755_33766(fs)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 33785, 33843);

                    int
                    ret = f_1075_33795_33842(filePath, out count)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 33861, 33951) || true) && (ret == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1075, 33861, 33951);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 33915, 33932);

                        return count > 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1075, 33861, 33951);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 33971, 34025);

                    throw f_1075_33977_34024(f_1075_33996_34023());
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1075, 33446, 34040);

                    bool
                    f_1075_33531_33541_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1075, 33531, 33541);
                        return return_v;
                    }


                    System.IO.FileAttributes
                    f_1075_33546_33559(System.IO.FileSystemInfo
                    this_param)
                    {
                        var return_v = this_param.Attributes;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1075, 33546, 33559);
                        return return_v;
                    }


                    string
                    f_1075_33755_33766(System.IO.FileSystemInfo
                    this_param)
                    {
                        var return_v = this_param.FullName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1075, 33755, 33766);
                        return return_v;
                    }


                    int
                    f_1075_33795_33842(string
                    filePath, out int
                    linkCount)
                    {
                        var return_v = NativeMethods.GetLinkCount(filePath, out linkCount);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 33795, 33842);
                        return return_v;
                    }


                    int
                    f_1075_33996_34023()
                    {
                        var return_v = Marshal.GetLastWin32Error();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 33996, 34023);
                        return return_v;
                    }


                    System.ComponentModel.Win32Exception
                    f_1075_33977_34024(int
                    error)
                    {
                        var return_v = new System.ComponentModel.Win32Exception(error);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 33977, 34024);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1075, 33446, 34040);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1075, 33446, 34040);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static CommonStat CopyStatStruct(NativeMethods.CommonStatStruct css)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1075, 34346, 37385);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 34459, 34492);

                    CommonStat
                    cs = f_1075_34475_34491()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 34514, 34535);

                    cs.Inode = css.Inode;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 34557, 34576);

                    cs.Mode = css.Mode;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 34598, 34621);

                    cs.UserId = css.UserId;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 34643, 34668);

                    cs.GroupId = css.GroupId;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 34690, 34727);

                    cs.HardlinkCount = css.HardlinkCount;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 34749, 34768);

                    cs.Size = css.Size;

                    // These can sometime throw if we get too large a number back (seen on Raspbian).
                    // As a fallback, set the time to UnixEpoch.
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 35013, 35089);

                        cs.AccessTime = DateTime.UnixEpoch.AddSeconds(css.AccessTime).ToLocalTime();
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1075, 35134, 35260);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 35188, 35237);

                        cs.AccessTime = DateTime.UnixEpoch.ToLocalTime();
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1075, 35134, 35260);
                    }

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 35336, 35416);

                        cs.ModifiedTime = DateTime.UnixEpoch.AddSeconds(css.ModifiedTime).ToLocalTime();
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1075, 35461, 35589);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 35515, 35566);

                        cs.ModifiedTime = DateTime.UnixEpoch.ToLocalTime();
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1075, 35461, 35589);
                    }

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 35665, 35753);

                        cs.StatusChangeTime = DateTime.UnixEpoch.AddSeconds(css.StatusChangeTime).ToLocalTime();
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1075, 35798, 35930);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 35852, 35907);

                        cs.StatusChangeTime = DateTime.UnixEpoch.ToLocalTime();
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1075, 35798, 35930);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 35954, 35983);

                    cs.BlockSize = css.BlockSize;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 36005, 36032);

                    cs.DeviceId = css.DeviceId;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 36054, 36093);

                    cs.NumberOfBlocks = css.NumberOfBlocks;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 36117, 37172) || true) && (css.IsDirectory == 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1075, 36117, 37172);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 36191, 36224);

                        cs.ItemType = ItemType.Directory;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1075, 36117, 37172);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1075, 36117, 37172);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 36274, 37172) || true) && (css.IsFile == 1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1075, 36274, 37172);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 36343, 36371);

                            cs.ItemType = ItemType.File;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1075, 36274, 37172);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1075, 36274, 37172);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 36421, 37172) || true) && (css.IsSymbolicLink == 1)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1075, 36421, 37172);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 36498, 36534);

                                cs.ItemType = ItemType.SymbolicLink;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1075, 36421, 37172);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1075, 36421, 37172);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 36584, 37172) || true) && (css.IsBlockDevice == 1)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1075, 36584, 37172);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 36660, 36695);

                                    cs.ItemType = ItemType.BlockDevice;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1075, 36584, 37172);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1075, 36584, 37172);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 36745, 37172) || true) && (css.IsCharacterDevice == 1)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1075, 36745, 37172);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 36825, 36864);

                                        cs.ItemType = ItemType.CharacterDevice;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1075, 36745, 37172);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1075, 36745, 37172);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 36914, 37172) || true) && (css.IsNamedPipe == 1)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1075, 36914, 37172);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 36988, 37021);

                                            cs.ItemType = ItemType.NamedPipe;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1075, 36914, 37172);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1075, 36914, 37172);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 37119, 37149);

                                            cs.ItemType = ItemType.Socket;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1075, 36914, 37172);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1075, 36745, 37172);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1075, 36584, 37172);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1075, 36421, 37172);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1075, 36274, 37172);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1075, 36117, 37172);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 37196, 37228);

                    cs.IsSetUid = css.IsSetUid == 1;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 37250, 37282);

                    cs.IsSetGid = css.IsSetGid == 1;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 37304, 37336);

                    cs.IsSticky = css.IsSticky == 1;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 37360, 37370);

                    return cs;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1075, 34346, 37385);

                    System.Management.Automation.Platform.Unix.CommonStat
                    f_1075_34475_34491()
                    {
                        var return_v = new System.Management.Automation.Platform.Unix.CommonStat();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 34475, 34491);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1075, 34346, 37385);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1075, 34346, 37385);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public static CommonStat GetLStat(string path)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1075, 37628, 37989);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 37707, 37742);

                    NativeMethods.CommonStatStruct
                    css
                    = default(NativeMethods.CommonStatStruct);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 37760, 37900) || true) && (f_1075_37764_37807(path, out css) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1075, 37760, 37900);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 37854, 37881);

                        return f_1075_37861_37880(css);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1075, 37760, 37900);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 37920, 37974);

                    throw f_1075_37926_37973(f_1075_37945_37972());
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1075, 37628, 37989);

                    int
                    f_1075_37764_37807(string
                    filePath, out System.Management.Automation.Platform.Unix.NativeMethods.CommonStatStruct
                    cs)
                    {
                        var return_v = NativeMethods.GetCommonLStat(filePath, out cs);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 37764, 37807);
                        return return_v;
                    }


                    System.Management.Automation.Platform.Unix.CommonStat
                    f_1075_37861_37880(System.Management.Automation.Platform.Unix.NativeMethods.CommonStatStruct
                    css)
                    {
                        var return_v = CopyStatStruct(css);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 37861, 37880);
                        return return_v;
                    }


                    int
                    f_1075_37945_37972()
                    {
                        var return_v = Marshal.GetLastWin32Error();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 37945, 37972);
                        return return_v;
                    }


                    System.ComponentModel.Win32Exception
                    f_1075_37926_37973(int
                    error)
                    {
                        var return_v = new System.ComponentModel.Win32Exception(error);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 37926, 37973);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1075, 37628, 37989);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1075, 37628, 37989);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public static CommonStat GetStat(string path)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1075, 38230, 38589);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 38308, 38343);

                    NativeMethods.CommonStatStruct
                    css
                    = default(NativeMethods.CommonStatStruct);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 38361, 38500) || true) && (f_1075_38365_38407(path, out css) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1075, 38361, 38500);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 38454, 38481);

                        return f_1075_38461_38480(css);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1075, 38361, 38500);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 38520, 38574);

                    throw f_1075_38526_38573(f_1075_38545_38572());
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1075, 38230, 38589);

                    int
                    f_1075_38365_38407(string
                    filePath, out System.Management.Automation.Platform.Unix.NativeMethods.CommonStatStruct
                    cs)
                    {
                        var return_v = NativeMethods.GetCommonStat(filePath, out cs);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 38365, 38407);
                        return return_v;
                    }


                    System.Management.Automation.Platform.Unix.CommonStat
                    f_1075_38461_38480(System.Management.Automation.Platform.Unix.NativeMethods.CommonStatStruct
                    css)
                    {
                        var return_v = CopyStatStruct(css);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 38461, 38480);
                        return return_v;
                    }


                    int
                    f_1075_38545_38572()
                    {
                        var return_v = Marshal.GetLastWin32Error();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 38545, 38572);
                        return return_v;
                    }


                    System.ComponentModel.Win32Exception
                    f_1075_38526_38573(int
                    error)
                    {
                        var return_v = new System.ComponentModel.Win32Exception(error);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 38526, 38573);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1075, 38230, 38589);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1075, 38230, 38589);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public static int GetProcFSParentPid(int pid)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1075, 38844, 39680);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 38922, 38948);

                    const int
                    invalidPid = -1
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 39147, 39178);

                    var
                    path = $"/proc/{pid}/stat"
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 39240, 39284);

                        var
                        stat = f_1075_39251_39283(path)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 39306, 39347);

                        var
                        parts = f_1075_39318_39346(stat, new[] { ' ' }, 5)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 39369, 39480) || true) && (f_1075_39373_39385(parts) < 5)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1075, 39369, 39480);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 39439, 39457);

                            return invalidPid;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1075, 39369, 39480);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 39504, 39533);

                        return f_1075_39511_39532(parts[3]);
                    }
                    catch (Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1075, 39570, 39665);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 39628, 39646);

                        return invalidPid;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1075, 39570, 39665);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1075, 38844, 39680);

                    string
                    f_1075_39251_39283(string
                    path)
                    {
                        var return_v = System.IO.File.ReadAllText(path);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 39251, 39283);
                        return return_v;
                    }


                    string[]
                    f_1075_39318_39346(string
                    this_param, char[]
                    separator, int
                    count)
                    {
                        var return_v = this_param.Split(separator, count);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 39318, 39346);
                        return return_v;
                    }


                    int
                    f_1075_39373_39385(string[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1075, 39373, 39385);
                        return return_v;
                    }


                    int
                    f_1075_39511_39532(string
                    s)
                    {
                        var return_v = Int32.Parse(s);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 39511, 39532);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1075, 38844, 39680);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1075, 38844, 39680);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            internal static class NativeMethods
            {
                private const string
                psLib = "libpsl-native"
                ;

                [DllImport(psLib, CharSet = CharSet.Ansi)]
                internal static extern int GetErrorCategory(int errno);

                [DllImport(psLib)]
                internal static extern int GetPPid(int pid);

                [DllImport(psLib, CharSet = CharSet.Ansi, SetLastError = true)]
                internal static extern int GetLinkCount([MarshalAs(UnmanagedType.LPStr)] string filePath, out int linkCount);

                [DllImport(psLib, CharSet = CharSet.Ansi, SetLastError = true)]
                [return: MarshalAs(UnmanagedType.I1)]
                internal static extern bool IsExecutable([MarshalAs(UnmanagedType.LPStr)] string filePath);

                [DllImport(psLib, CharSet = CharSet.Ansi)]
                internal static extern uint GetCurrentThreadId();

                [StructLayout(LayoutKind.Sequential)]
                internal unsafe struct UnixTm
                {

                    internal int tm_sec;

                    internal int tm_min;

                    internal int tm_hour;

                    internal int tm_mday;

                    internal int tm_mon;

                    internal int tm_year;

                    internal int tm_wday;

                    internal int tm_yday;

                    internal int tm_isdst;
                    static UnixTm()
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1075, 40921, 42035);
                        DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1075, 40921, 42035);

                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1075, 40921, 42035);
                    }
                }

                internal static UnixTm DateTimeToUnixTm(DateTime date)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1075, 42127, 42809);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 42222, 42232);

                        UnixTm
                        tm
                        = default(UnixTm);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 42254, 42278);

                        tm.tm_sec = date.Second;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 42300, 42324);

                        tm.tm_min = date.Minute;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 42346, 42369);

                        tm.tm_hour = date.Hour;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 42391, 42413);

                        tm.tm_mday = date.Day;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 42435, 42462);

                        tm.tm_mon = date.Month - 1;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 42509, 42539);

                        tm.tm_year = date.Year - 1900;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 42581, 42596);

                        tm.tm_wday = 0;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 42647, 42662);

                        tm.tm_yday = 0;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 42708, 42758);

                        tm.tm_isdst = (DynAbs.Tracing.TraceSender.Conditional_F1(1075, 42722, 42749) || ((date.IsDaylightSavingTime() && DynAbs.Tracing.TraceSender.Conditional_F2(1075, 42752, 42753)) || DynAbs.Tracing.TraceSender.Conditional_F3(1075, 42756, 42757))) ? 1 : 0;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 42780, 42790);

                        return tm;
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1075, 42127, 42809);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1075, 42127, 42809);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1075, 42127, 42809);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                [DllImport(psLib, CharSet = CharSet.Ansi, SetLastError = true)]
                internal static extern unsafe int SetDate(UnixTm* tm);

                [DllImport(psLib, CharSet = CharSet.Ansi, SetLastError = true)]
                internal static extern int CreateSymLink([MarshalAs(UnmanagedType.LPStr)] string filePath,
                                                                         [MarshalAs(UnmanagedType.LPStr)] string target);

                [DllImport(psLib, CharSet = CharSet.Ansi, SetLastError = true)]
                internal static extern int CreateHardLink([MarshalAs(UnmanagedType.LPStr)] string filePath,
                                                                          [MarshalAs(UnmanagedType.LPStr)] string target);

                [DllImport(psLib, CharSet = CharSet.Ansi, SetLastError = true)]
                [return: MarshalAs(UnmanagedType.LPStr)]
                internal static extern string FollowSymLink([MarshalAs(UnmanagedType.LPStr)] string filePath);

                [DllImport(psLib, CharSet = CharSet.Ansi, SetLastError = true)]
                [return: MarshalAs(UnmanagedType.LPStr)]
                internal static extern string GetUserFromPid(int pid);

                [DllImport(psLib, CharSet = CharSet.Ansi, SetLastError = true)]
                [return: MarshalAs(UnmanagedType.I1)]
                internal static extern bool IsSameFileSystemItem([MarshalAs(UnmanagedType.LPStr)] string filePathOne,
                                                                                 [MarshalAs(UnmanagedType.LPStr)] string filePathTwo);

                [DllImport(psLib, CharSet = CharSet.Ansi, SetLastError = true)]
                internal static extern int GetInodeData([MarshalAs(UnmanagedType.LPStr)] string path,
                                                                        out UInt64 device, out UInt64 inode);

                [StructLayout(LayoutKind.Sequential)]
                internal struct CommonStatStruct
                {

                    internal long Inode;

                    internal int Mode;

                    internal int UserId;

                    internal int GroupId;

                    internal int HardlinkCount;

                    internal long Size;

                    internal long AccessTime;

                    internal long ModifiedTime;

                    internal long StatusChangeTime;

                    internal long BlockSize;

                    internal int DeviceId;

                    internal int NumberOfBlocks;

                    internal int IsDirectory;

                    internal int IsFile;

                    internal int IsSymbolicLink;

                    internal int IsBlockDevice;

                    internal int IsCharacterDevice;

                    internal int IsNamedPipe;

                    internal int IsSocket;

                    internal int IsSetUid;

                    internal int IsSetGid;

                    internal int IsSticky;
                    static CommonStatStruct()
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1075, 45118, 48265);
                        DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1075, 45118, 48265);

                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1075, 45118, 48265);
                    }
                }

                [DllImport(psLib, CharSet = CharSet.Ansi, SetLastError = true)]
                internal static extern unsafe int GetCommonLStat(string filePath, [Out] out CommonStatStruct cs);

                [DllImport(psLib, CharSet = CharSet.Ansi, SetLastError = true)]
                internal static extern unsafe int GetCommonStat(string filePath, [Out] out CommonStatStruct cs);

                [DllImport(psLib, CharSet = CharSet.Ansi, SetLastError = true)]
                internal static extern string GetPwUid(int id);

                [DllImport(psLib, CharSet = CharSet.Ansi, SetLastError = true)]
                internal static extern string GetGrGid(int id);

                static NativeMethods()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1075, 39758, 48971);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 39847, 39870);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1075, 39758, 48971);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1075, 39758, 48971);
                }

            }

            static Unix()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1075, 21493, 48982);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 21583, 21628);
                usernameCache = f_1075_21599_21628();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 21682, 21728);
                groupnameCache = f_1075_21699_21728();
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1075, 21493, 48982);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1075, 21493, 48982);
            }


            static System.Collections.Generic.Dictionary<int, string>
            f_1075_21599_21628()
            {
                var return_v = new System.Collections.Generic.Dictionary<int, string>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 21599, 21628);
                return return_v;
            }


            static System.Collections.Generic.Dictionary<int, string>
            f_1075_21699_21728()
            {
                var return_v = new System.Collections.Generic.Dictionary<int, string>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 21699, 21728);
                return return_v;
            }

        }

        static Platform()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1075, 452, 48989);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 519, 540);
            _tempDirectory = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 4549, 4666);
            CacheDirectory = f_1075_4566_4639(Environment.SpecialFolder.LocalApplicationData) + @"\Microsoft\PowerShell";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 4709, 4805);
            ConfigDirectory = f_1075_4727_4788(Environment.SpecialFolder.Personal) + @"\PowerShell";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 4839, 4859);
            _isNanoServer = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 4891, 4904);
            _isIoT = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 4936, 4960);
            _isWindowsDesktop = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1075, 5035, 5583);
            FormatFileNames = new List<string>
            {
                DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => "Certificate.format.ps1xml",1075,5053,5583),                "Diagnostics.format.ps1xml",                "DotNetTypes.format.ps1xml",                "Event.format.ps1xml",                "FileSystem.format.ps1xml",                "Help.format.ps1xml",                "HelpV3.format.ps1xml",                "PowerShellCore.format.ps1xml",                "PowerShellTrace.format.ps1xml",                "Registry.format.ps1xml",                "WSMan.format.ps1xml"
            };
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1075, 452, 48989);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1075, 452, 48989);
        }


        static string
        f_1075_4566_4639(System.Environment.SpecialFolder
        folder)
        {
            var return_v = Environment.GetFolderPath(folder);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 4566, 4639);
            return return_v;
        }


        static string
        f_1075_4727_4788(System.Environment.SpecialFolder
        folder)
        {
            var return_v = Environment.GetFolderPath(folder);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1075, 4727, 4788);
            return return_v;
        }

    }
}
