// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

using Microsoft.Win32;

namespace System.Management.Automation
{
    public class PSVersionInfo
    {
        internal const string
        PSVersionTableName = "PSVersionTable"
        ;

        internal const string
        PSRemotingProtocolVersionName = "PSRemotingProtocolVersion"
        ;

        internal const string
        PSVersionName = "PSVersion"
        ;

        internal const string
        PSEditionName = "PSEdition"
        ;

        internal const string
        PSGitCommitIdName = "GitCommitId"
        ;

        internal const string
        PSCompatibleVersionsName = "PSCompatibleVersions"
        ;

        internal const string
        PSPlatformName = "Platform"
        ;

        internal const string
        PSOSName = "OS"
        ;

        internal const string
        SerializationVersionName = "SerializationVersion"
        ;

        internal const string
        WSManStackVersionName = "WSManStackVersion"
        ;

        private static readonly PSVersionHashTable s_psVersionTable;

        private static readonly Version s_psV1Version;

        private static readonly Version s_psV2Version;

        private static readonly Version s_psV3Version;

        private static readonly Version s_psV4Version;

        private static readonly Version s_psV5Version;

        private static readonly Version s_psV51Version;

        private static readonly SemanticVersion s_psV6Version;

        private static readonly SemanticVersion s_psV61Version;

        private static readonly SemanticVersion s_psV62Version;

        private static readonly SemanticVersion s_psV7Version;

        private static readonly SemanticVersion s_psSemVersion;

        private static readonly Version s_psVersion;

        internal const string
        PSEditionValue = "Core"
        ;

        static PSVersionInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1326, 3455, 6370);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 884, 921);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 954, 1013);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 1046, 1073);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 1106, 1133);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 1166, 1199);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 1232, 1281);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 1314, 1341);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 1374, 1389);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 1422, 1471);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 1504, 1547);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 1601, 1617);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 2111, 2144);
                s_psV1Version = f_1326_2127_2144(1, 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 2187, 2220);
                s_psV2Version = f_1326_2203_2220(2, 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 2263, 2296);
                s_psV3Version = f_1326_2279_2296(3, 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 2339, 2372);
                s_psV4Version = f_1326_2355_2372(4, 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 2415, 2448);
                s_psV5Version = f_1326_2431_2448(5, 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 2491, 2579);
                s_psV51Version = f_1326_2508_2579(5, 1, NTVerpVars.PRODUCTBUILD, NTVerpVars.PRODUCTBUILD_QFE);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 2630, 2715);
                s_psV6Version = f_1326_2646_2715(6, 0, 0, preReleaseLabel: null, buildLabel: null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 2766, 2852);
                s_psV61Version = f_1326_2783_2852(6, 1, 0, preReleaseLabel: null, buildLabel: null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 2903, 2989);
                s_psV62Version = f_1326_2920_2989(6, 2, 0, preReleaseLabel: null, buildLabel: null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 3040, 3125);
                s_psV7Version = f_1326_3056_3125(7, 0, 0, preReleaseLabel: null, buildLabel: null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 3176, 3190);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 3233, 3244);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 3387, 3410);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 3502, 3578);

                s_psVersionTable = f_1326_3521_3577(f_1326_3544_3576());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 3594, 3656);

                string
                assemblyPath = f_1326_3616_3655(f_1326_3616_3646(typeof(PSVersionInfo)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 3670, 3754);

                string
                productVersion = f_1326_3694_3753(f_1326_3694_3738(assemblyPath))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 4866, 4888);

                string
                rawGitCommitId
                = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 4902, 4980);

                string
                mainVersion = f_1326_4923_4979(productVersion, 0, f_1326_4951_4978(productVersion, ' '))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 4996, 5264) || true) && (f_1326_5000_5037(productVersion, " Commits: "))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 4996, 5264);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 5071, 5154);

                    rawGitCommitId = f_1326_5088_5153(f_1326_5088_5129(productVersion, " Commits: ", "-"), " SHA: ", "-g");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 4996, 5264);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 4996, 5264);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 5220, 5249);

                    rawGitCommitId = mainVersion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 4996, 5264);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 5280, 5330);

                s_psSemVersion = f_1326_5297_5329(mainVersion);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 5344, 5382);

                s_psVersion = (Version)s_psSemVersion;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 5398, 5461);

                s_psVersionTable[PSVersionInfo.PSVersionName] = s_psSemVersion;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 5475, 5538);

                s_psVersionTable[PSVersionInfo.PSEditionName] = PSEditionValue;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 5552, 5605);

                s_psVersionTable[PSGitCommitIdName] = rawGitCommitId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 5619, 5832);

                s_psVersionTable[PSCompatibleVersionsName] = new Version[] { s_psV1Version, s_psV2Version, s_psV3Version, s_psV4Version, s_psV5Version, s_psV51Version, s_psV6Version, s_psV61Version, s_psV62Version, s_psVersion };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 5846, 5952);

                s_psVersionTable[PSVersionInfo.SerializationVersionName] = f_1326_5905_5951(InternalSerializer.DefaultVersion);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 5966, 6064);

                s_psVersionTable[PSVersionInfo.PSRemotingProtocolVersionName] = RemotingConstants.ProtocolVersion;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 6078, 6157);

                s_psVersionTable[PSVersionInfo.WSManStackVersionName] = f_1326_6134_6156();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 6171, 6248);

                s_psVersionTable[PSPlatformName] = f_1326_6206_6247(f_1326_6206_6236(f_1326_6206_6227()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 6262, 6359);

                s_psVersionTable[PSOSName] = f_1326_6291_6358(f_1326_6291_6347());
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1326, 3455, 6370);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1326, 3455, 6370);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 3455, 6370);
            }
        }

        internal static PSVersionHashTable GetPSVersionTable()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1326, 6382, 6496);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 6461, 6485);

                return s_psVersionTable;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1326, 6382, 6496);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1326, 6382, 6496);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 6382, 6496);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Hashtable GetPSVersionTableForDownLevel()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1326, 6508, 6854);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 6590, 6639);

                var
                result = (Hashtable)f_1326_6614_6638(s_psVersionTable)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 6765, 6815);

                result[PSVersionInfo.PSVersionName] = s_psVersion;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 6829, 6843);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1326, 6508, 6854);

                object
                f_1326_6614_6638(System.Management.Automation.PSVersionHashTable
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 6614, 6638);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1326, 6508, 6854);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 6508, 6854);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Version GetWSManStackVersion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1326, 6976, 8361);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 7046, 7069);

                Version
                version = null
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 7132, 7832);
                    using (RegistryKey
                    wsManStackVersionKey = f_1326_7174_7258(Registry.LocalMachine, @"Software\Microsoft\Windows\CurrentVersion\WSMAN")
                    )
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 7300, 7813) || true) && (wsManStackVersionKey != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 7300, 7813);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 7382, 7465);

                            object
                            wsManStackVersionObj = f_1326_7412_7464(wsManStackVersionKey, "ServiceStackVersion")
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 7491, 7587);

                            string
                            wsManStackVersion = (DynAbs.Tracing.TraceSender.Conditional_F1(1326, 7518, 7548) || (((wsManStackVersionObj != null) && DynAbs.Tracing.TraceSender.Conditional_F2(1326, 7551, 7579)) || DynAbs.Tracing.TraceSender.Conditional_F3(1326, 7582, 7586))) ? (string)wsManStackVersionObj : null
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 7613, 7790) || true) && (!f_1326_7618_7657(wsManStackVersion))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 7613, 7790);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 7715, 7763);

                                version = f_1326_7725_7762(f_1326_7737_7761(wsManStackVersion));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 7613, 7790);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 7300, 7813);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitUsing(1326, 7132, 7832);
                    }
                }
                catch (ObjectDisposedException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1326, 7861, 7896);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1326, 7861, 7896);
                }
                catch (System.Security.SecurityException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1326, 7910, 7955);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1326, 7910, 7955);
                }
                catch (ArgumentException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1326, 7969, 7998);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1326, 7969, 7998);
                }
                catch (System.IO.IOException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1326, 8012, 8045);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1326, 8012, 8045);
                }
                catch (UnauthorizedAccessException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1326, 8059, 8098);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1326, 8059, 8098);
                }
                catch (FormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1326, 8112, 8139);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1326, 8112, 8139);
                }
                catch (OverflowException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1326, 8153, 8182);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1326, 8153, 8182);
                }
                catch (InvalidCastException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1326, 8196, 8228);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1326, 8196, 8228);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 8252, 8350);

                return version ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Version>(1326, 8259, 8349) ?? System.Management.Automation.Remoting.Client.WSManNativeApi.WSMAN_STACK_VERSION);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1326, 6976, 8361);

                Microsoft.Win32.RegistryKey
                f_1326_7174_7258(Microsoft.Win32.RegistryKey
                this_param, string
                name)
                {
                    var return_v = this_param.OpenSubKey(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 7174, 7258);
                    return return_v;
                }


                object
                f_1326_7412_7464(Microsoft.Win32.RegistryKey
                this_param, string
                name)
                {
                    var return_v = this_param.GetValue(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 7412, 7464);
                    return return_v;
                }


                bool
                f_1326_7618_7657(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 7618, 7657);
                    return return_v;
                }


                string
                f_1326_7737_7761(string
                this_param)
                {
                    var return_v = this_param.Trim();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 7737, 7761);
                    return return_v;
                }


                System.Version
                f_1326_7725_7762(string
                version)
                {
                    var return_v = new System.Version(version);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 7725, 7762);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1326, 6976, 8361);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 6976, 8361);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Version PSVersion
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1326, 8578, 8648);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 8614, 8633);

                    return s_psVersion;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1326, 8578, 8648);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1326, 8522, 8659);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 8522, 8659);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static string GitCommitId
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1326, 8730, 8832);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 8766, 8817);

                    return (string)f_1326_8781_8816(s_psVersionTable, PSGitCommitIdName);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1326, 8730, 8832);

                    object
                    f_1326_8781_8816(System.Management.Automation.PSVersionHashTable
                    this_param, object
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 8781, 8816);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1326, 8671, 8843);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 8671, 8843);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static Version[] PSCompatibleVersions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1326, 8926, 9038);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 8962, 9023);

                    return (Version[])f_1326_8980_9022(s_psVersionTable, PSCompatibleVersionsName);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1326, 8926, 9038);

                    object
                    f_1326_8980_9022(System.Management.Automation.PSVersionHashTable
                    this_param, object
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 8980, 9022);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1326, 8855, 9049);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 8855, 9049);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static string PSEdition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1326, 9208, 9320);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 9244, 9305);

                    return (string)f_1326_9259_9304(s_psVersionTable, PSVersionInfo.PSEditionName);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1326, 9208, 9320);

                    object
                    f_1326_9259_9304(System.Management.Automation.PSVersionHashTable
                    this_param, object
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 9259, 9304);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1326, 9153, 9331);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 9153, 9331);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static Version SerializationVersion
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1326, 9412, 9522);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 9448, 9507);

                    return (Version)f_1326_9464_9506(s_psVersionTable, SerializationVersionName);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1326, 9412, 9522);

                    object
                    f_1326_9464_9506(System.Management.Automation.PSVersionHashTable
                    this_param, object
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 9464, 9506);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1326, 9343, 9533);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 9343, 9533);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static string RegistryVersion1Key
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1326, 9924, 9986);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 9960, 9971);

                    return "1";
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1326, 9924, 9986);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1326, 9857, 9997);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 9857, 9997);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static string RegistryVersionKey
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1326, 10442, 10595);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 10569, 10580);

                    return "3";
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1326, 10442, 10595);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1326, 10376, 10606);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 10376, 10606);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static string GetRegistryVersionKeyForSnapinDiscovery(string majorVersion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1326, 10618, 11385);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 10726, 10751);

                int
                tempMajorVersion = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 10765, 10838);

                f_1326_10765_10837(majorVersion, out tempMajorVersion);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 10854, 11346) || true) && ((tempMajorVersion >= 1) && (DynAbs.Tracing.TraceSender.Expression_True(1326, 10858, 10936) && (tempMajorVersion <= f_1326_10906_10935(f_1326_10906_10929()))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 10854, 11346);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 11320, 11331);

                    return "1";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 10854, 11346);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 11362, 11374);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1326, 10618, 11385);

                bool
                f_1326_10765_10837(string
                valueToConvert, out int
                result)
                {
                    var return_v = LanguagePrimitives.TryConvertTo<int>((object)valueToConvert, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 10765, 10837);
                    return return_v;
                }


                System.Version
                f_1326_10906_10929()
                {
                    var return_v = PSVersionInfo.PSVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 10906, 10929);
                    return return_v;
                }


                int
                f_1326_10906_10935(System.Version
                this_param)
                {
                    var return_v = this_param.Major;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 10906, 10935);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1326, 10618, 11385);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 10618, 11385);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string FeatureVersionString
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1326, 11465, 11661);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 11501, 11646);

                    return f_1326_11508_11645(f_1326_11522_11571(), "{0}.{1}", f_1326_11584_11613(f_1326_11584_11607()), f_1326_11615_11644(f_1326_11615_11638()));
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1326, 11465, 11661);

                    System.Globalization.CultureInfo
                    f_1326_11522_11571()
                    {
                        var return_v = System.Globalization.CultureInfo.InvariantCulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 11522, 11571);
                        return return_v;
                    }


                    System.Version
                    f_1326_11584_11607()
                    {
                        var return_v = PSVersionInfo.PSVersion;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 11584, 11607);
                        return return_v;
                    }


                    int
                    f_1326_11584_11613(System.Version
                    this_param)
                    {
                        var return_v = this_param.Major;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 11584, 11613);
                        return return_v;
                    }


                    System.Version
                    f_1326_11615_11638()
                    {
                        var return_v = PSVersionInfo.PSVersion;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 11615, 11638);
                        return return_v;
                    }


                    int
                    f_1326_11615_11644(System.Version
                    this_param)
                    {
                        var return_v = this_param.Minor;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 11615, 11644);
                        return return_v;
                    }


                    string
                    f_1326_11508_11645(System.Globalization.CultureInfo
                    provider, string
                    format, int
                    arg0, int
                    arg1)
                    {
                        var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 11508, 11645);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1326, 11397, 11672);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 11397, 11672);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static bool IsValidPSVersion(Version version)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1326, 11684, 12886);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 11763, 11898) || true) && (f_1326_11767_11780(version) == f_1326_11784_11804(s_psSemVersion))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 11763, 11898);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 11838, 11883);

                    return f_1326_11845_11858(version) == f_1326_11862_11882(s_psSemVersion);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 11763, 11898);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 11914, 12047) || true) && (f_1326_11918_11931(version) == f_1326_11935_11954(s_psV6Version))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 11914, 12047);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 11988, 12032);

                    return f_1326_11995_12008(version) == f_1326_12012_12031(s_psV6Version);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 11914, 12047);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 12063, 12239) || true) && (f_1326_12067_12080(version) == f_1326_12084_12103(s_psV5Version))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 12063, 12239);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 12137, 12224);

                    return (f_1326_12145_12158(version) == f_1326_12162_12181(s_psV5Version) || (DynAbs.Tracing.TraceSender.Expression_False(1326, 12145, 12222) || f_1326_12185_12198(version) == f_1326_12202_12222(s_psV51Version)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 12063, 12239);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 12255, 12846) || true) && (f_1326_12259_12272(version) == f_1326_12276_12295(s_psV4Version))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 12255, 12846);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 12329, 12375);

                    return (f_1326_12337_12350(version) == f_1326_12354_12373(s_psV4Version));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 12255, 12846);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 12255, 12846);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 12409, 12846) || true) && (f_1326_12413_12426(version) == f_1326_12430_12449(s_psV3Version))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 12409, 12846);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 12483, 12527);

                        return f_1326_12490_12503(version) == f_1326_12507_12526(s_psV3Version);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 12409, 12846);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 12409, 12846);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 12561, 12846) || true) && (f_1326_12565_12578(version) == f_1326_12582_12601(s_psV2Version))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 12561, 12846);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 12635, 12679);

                            return f_1326_12642_12655(version) == f_1326_12659_12678(s_psV2Version);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 12561, 12846);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 12561, 12846);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 12713, 12846) || true) && (f_1326_12717_12730(version) == f_1326_12734_12753(s_psV1Version))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 12713, 12846);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 12787, 12831);

                                return f_1326_12794_12807(version) == f_1326_12811_12830(s_psV1Version);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 12713, 12846);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 12561, 12846);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 12409, 12846);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 12255, 12846);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 12862, 12875);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1326, 11684, 12886);

                int
                f_1326_11767_11780(System.Version
                this_param)
                {
                    var return_v = this_param.Major;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 11767, 11780);
                    return return_v;
                }


                int
                f_1326_11784_11804(System.Management.Automation.SemanticVersion
                this_param)
                {
                    var return_v = this_param.Major;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 11784, 11804);
                    return return_v;
                }


                int
                f_1326_11845_11858(System.Version
                this_param)
                {
                    var return_v = this_param.Minor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 11845, 11858);
                    return return_v;
                }


                int
                f_1326_11862_11882(System.Management.Automation.SemanticVersion
                this_param)
                {
                    var return_v = this_param.Minor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 11862, 11882);
                    return return_v;
                }


                int
                f_1326_11918_11931(System.Version
                this_param)
                {
                    var return_v = this_param.Major;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 11918, 11931);
                    return return_v;
                }


                int
                f_1326_11935_11954(System.Management.Automation.SemanticVersion
                this_param)
                {
                    var return_v = this_param.Major;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 11935, 11954);
                    return return_v;
                }


                int
                f_1326_11995_12008(System.Version
                this_param)
                {
                    var return_v = this_param.Minor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 11995, 12008);
                    return return_v;
                }


                int
                f_1326_12012_12031(System.Management.Automation.SemanticVersion
                this_param)
                {
                    var return_v = this_param.Minor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 12012, 12031);
                    return return_v;
                }


                int
                f_1326_12067_12080(System.Version
                this_param)
                {
                    var return_v = this_param.Major;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 12067, 12080);
                    return return_v;
                }


                int
                f_1326_12084_12103(System.Version
                this_param)
                {
                    var return_v = this_param.Major;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 12084, 12103);
                    return return_v;
                }


                int
                f_1326_12145_12158(System.Version
                this_param)
                {
                    var return_v = this_param.Minor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 12145, 12158);
                    return return_v;
                }


                int
                f_1326_12162_12181(System.Version
                this_param)
                {
                    var return_v = this_param.Minor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 12162, 12181);
                    return return_v;
                }


                int
                f_1326_12185_12198(System.Version
                this_param)
                {
                    var return_v = this_param.Minor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 12185, 12198);
                    return return_v;
                }


                int
                f_1326_12202_12222(System.Version
                this_param)
                {
                    var return_v = this_param.Minor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 12202, 12222);
                    return return_v;
                }


                int
                f_1326_12259_12272(System.Version
                this_param)
                {
                    var return_v = this_param.Major;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 12259, 12272);
                    return return_v;
                }


                int
                f_1326_12276_12295(System.Version
                this_param)
                {
                    var return_v = this_param.Major;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 12276, 12295);
                    return return_v;
                }


                int
                f_1326_12337_12350(System.Version
                this_param)
                {
                    var return_v = this_param.Minor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 12337, 12350);
                    return return_v;
                }


                int
                f_1326_12354_12373(System.Version
                this_param)
                {
                    var return_v = this_param.Minor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 12354, 12373);
                    return return_v;
                }


                int
                f_1326_12413_12426(System.Version
                this_param)
                {
                    var return_v = this_param.Major;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 12413, 12426);
                    return return_v;
                }


                int
                f_1326_12430_12449(System.Version
                this_param)
                {
                    var return_v = this_param.Major;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 12430, 12449);
                    return return_v;
                }


                int
                f_1326_12490_12503(System.Version
                this_param)
                {
                    var return_v = this_param.Minor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 12490, 12503);
                    return return_v;
                }


                int
                f_1326_12507_12526(System.Version
                this_param)
                {
                    var return_v = this_param.Minor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 12507, 12526);
                    return return_v;
                }


                int
                f_1326_12565_12578(System.Version
                this_param)
                {
                    var return_v = this_param.Major;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 12565, 12578);
                    return return_v;
                }


                int
                f_1326_12582_12601(System.Version
                this_param)
                {
                    var return_v = this_param.Major;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 12582, 12601);
                    return return_v;
                }


                int
                f_1326_12642_12655(System.Version
                this_param)
                {
                    var return_v = this_param.Minor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 12642, 12655);
                    return return_v;
                }


                int
                f_1326_12659_12678(System.Version
                this_param)
                {
                    var return_v = this_param.Minor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 12659, 12678);
                    return return_v;
                }


                int
                f_1326_12717_12730(System.Version
                this_param)
                {
                    var return_v = this_param.Major;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 12717, 12730);
                    return return_v;
                }


                int
                f_1326_12734_12753(System.Version
                this_param)
                {
                    var return_v = this_param.Major;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 12734, 12753);
                    return return_v;
                }


                int
                f_1326_12794_12807(System.Version
                this_param)
                {
                    var return_v = this_param.Minor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 12794, 12807);
                    return return_v;
                }


                int
                f_1326_12811_12830(System.Version
                this_param)
                {
                    var return_v = this_param.Minor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 12811, 12830);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1326, 11684, 12886);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 11684, 12886);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Version PSV4Version
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1326, 12958, 12987);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 12964, 12985);

                    return s_psV4Version;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1326, 12958, 12987);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1326, 12898, 12998);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 12898, 12998);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static Version PSV5Version
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1326, 13070, 13099);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 13076, 13097);

                    return s_psV5Version;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1326, 13070, 13099);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1326, 13010, 13110);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 13010, 13110);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static Version PSV51Version
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1326, 13183, 13213);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 13189, 13211);

                    return s_psV51Version;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1326, 13183, 13213);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1326, 13122, 13224);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 13122, 13224);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static SemanticVersion PSV6Version
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1326, 13304, 13333);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 13310, 13331);

                    return s_psV6Version;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1326, 13304, 13333);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1326, 13236, 13344);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 13236, 13344);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static SemanticVersion PSV7Version
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1326, 13424, 13453);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 13430, 13451);

                    return s_psV7Version;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1326, 13424, 13453);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1326, 13356, 13464);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 13356, 13464);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static SemanticVersion PSCurrentVersion
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1326, 13549, 13579);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 13555, 13577);

                    return s_psSemVersion;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1326, 13549, 13579);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1326, 13476, 13590);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 13476, 13590);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public PSVersionInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1326, 819, 13619);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1326, 819, 13619);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 819, 13619);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1326, 819, 13619);

        static System.Version
        f_1326_2127_2144(int
        major, int
        minor)
        {
            var return_v = new System.Version(major, minor);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 2127, 2144);
            return return_v;
        }


        static System.Version
        f_1326_2203_2220(int
        major, int
        minor)
        {
            var return_v = new System.Version(major, minor);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 2203, 2220);
            return return_v;
        }


        static System.Version
        f_1326_2279_2296(int
        major, int
        minor)
        {
            var return_v = new System.Version(major, minor);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 2279, 2296);
            return return_v;
        }


        static System.Version
        f_1326_2355_2372(int
        major, int
        minor)
        {
            var return_v = new System.Version(major, minor);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 2355, 2372);
            return return_v;
        }


        static System.Version
        f_1326_2431_2448(int
        major, int
        minor)
        {
            var return_v = new System.Version(major, minor);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 2431, 2448);
            return return_v;
        }


        static System.Version
        f_1326_2508_2579(int
        major, int
        minor, int
        build, int
        revision)
        {
            var return_v = new System.Version(major, minor, build, revision);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 2508, 2579);
            return return_v;
        }


        static System.Management.Automation.SemanticVersion
        f_1326_2646_2715(int
        major, int
        minor, int
        patch, string
        preReleaseLabel, string
        buildLabel)
        {
            var return_v = new System.Management.Automation.SemanticVersion(major, minor, patch, preReleaseLabel: preReleaseLabel, buildLabel: buildLabel);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 2646, 2715);
            return return_v;
        }


        static System.Management.Automation.SemanticVersion
        f_1326_2783_2852(int
        major, int
        minor, int
        patch, string
        preReleaseLabel, string
        buildLabel)
        {
            var return_v = new System.Management.Automation.SemanticVersion(major, minor, patch, preReleaseLabel: preReleaseLabel, buildLabel: buildLabel);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 2783, 2852);
            return return_v;
        }


        static System.Management.Automation.SemanticVersion
        f_1326_2920_2989(int
        major, int
        minor, int
        patch, string
        preReleaseLabel, string
        buildLabel)
        {
            var return_v = new System.Management.Automation.SemanticVersion(major, minor, patch, preReleaseLabel: preReleaseLabel, buildLabel: buildLabel);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 2920, 2989);
            return return_v;
        }


        static System.Management.Automation.SemanticVersion
        f_1326_3056_3125(int
        major, int
        minor, int
        patch, string
        preReleaseLabel, string
        buildLabel)
        {
            var return_v = new System.Management.Automation.SemanticVersion(major, minor, patch, preReleaseLabel: preReleaseLabel, buildLabel: buildLabel);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 3056, 3125);
            return return_v;
        }


        static System.StringComparer
        f_1326_3544_3576()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 3544, 3576);
            return return_v;
        }


        static System.Management.Automation.PSVersionHashTable
        f_1326_3521_3577(System.StringComparer
        equalityComparer)
        {
            var return_v = new System.Management.Automation.PSVersionHashTable((System.Collections.IEqualityComparer)equalityComparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 3521, 3577);
            return return_v;
        }


        static System.Reflection.Assembly
        f_1326_3616_3646(System.Type
        this_param)
        {
            var return_v = this_param.Assembly;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 3616, 3646);
            return return_v;
        }


        static string
        f_1326_3616_3655(System.Reflection.Assembly
        this_param)
        {
            var return_v = this_param.Location;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 3616, 3655);
            return return_v;
        }


        static System.Diagnostics.FileVersionInfo
        f_1326_3694_3738(string
        fileName)
        {
            var return_v = FileVersionInfo.GetVersionInfo(fileName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 3694, 3738);
            return return_v;
        }


        static string
        f_1326_3694_3753(System.Diagnostics.FileVersionInfo
        this_param)
        {
            var return_v = this_param.ProductVersion;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 3694, 3753);
            return return_v;
        }


        static int
        f_1326_4951_4978(string
        this_param, char
        value)
        {
            var return_v = this_param.IndexOf(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 4951, 4978);
            return return_v;
        }


        static string
        f_1326_4923_4979(string
        this_param, int
        startIndex, int
        length)
        {
            var return_v = this_param.Substring(startIndex, length);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 4923, 4979);
            return return_v;
        }


        static bool
        f_1326_5000_5037(string
        this_param, string
        value)
        {
            var return_v = this_param.Contains(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 5000, 5037);
            return return_v;
        }


        static string
        f_1326_5088_5129(string
        this_param, string
        oldValue, string
        newValue)
        {
            var return_v = this_param.Replace(oldValue, newValue);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 5088, 5129);
            return return_v;
        }


        static string
        f_1326_5088_5153(string
        this_param, string
        oldValue, string
        newValue)
        {
            var return_v = this_param.Replace(oldValue, newValue);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 5088, 5153);
            return return_v;
        }


        static System.Management.Automation.SemanticVersion
        f_1326_5297_5329(string
        version)
        {
            var return_v = new System.Management.Automation.SemanticVersion(version);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 5297, 5329);
            return return_v;
        }


        static System.Version
        f_1326_5905_5951(string
        version)
        {
            var return_v = new System.Version(version);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 5905, 5951);
            return return_v;
        }


        static System.Version
        f_1326_6134_6156()
        {
            var return_v = GetWSManStackVersion();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 6134, 6156);
            return return_v;
        }


        static System.OperatingSystem
        f_1326_6206_6227()
        {
            var return_v = Environment.OSVersion;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 6206, 6227);
            return return_v;
        }


        static System.PlatformID
        f_1326_6206_6236(System.OperatingSystem
        this_param)
        {
            var return_v = this_param.Platform;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 6206, 6236);
            return return_v;
        }


        static string
        f_1326_6206_6247(System.PlatformID
        this_param)
        {
            var return_v = this_param.ToString();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 6206, 6247);
            return return_v;
        }


        static string
        f_1326_6291_6347()
        {
            var return_v = Runtime.InteropServices.RuntimeInformation.OSDescription;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 6291, 6347);
            return return_v;
        }


        static string
        f_1326_6291_6358(string
        this_param)
        {
            var return_v = this_param.ToString();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 6291, 6358);
            return return_v;
        }

    }
    public sealed class PSVersionHashTable : Hashtable, IEnumerable
    {
        private static readonly PSVersionTableComparer s_keysComparer;

        internal PSVersionHashTable(IEqualityComparer equalityComparer) : base(f_1326_14090_14106_C(equalityComparer))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1326, 14019, 14129);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1326, 14019, 14129);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1326, 14019, 14129);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 14019, 14129);
            }
        }

        public override ICollection Keys
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1326, 14491, 14667);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 14527, 14572);

                    ArrayList
                    keyList = f_1326_14547_14571(DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.Keys, 1326, 14561, 14570))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 14590, 14619);

                    f_1326_14590_14618(keyList, s_keysComparer);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 14637, 14652);

                    return keyList;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1326, 14491, 14667);

                    System.Collections.ArrayList
                    f_1326_14547_14571(System.Collections.ICollection
                    c)
                    {
                        var return_v = new System.Collections.ArrayList(c);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 14547, 14571);
                        return return_v;
                    }


                    int
                    f_1326_14590_14618(System.Collections.ArrayList
                    this_param, System.Management.Automation.PSVersionHashTable.PSVersionTableComparer
                    comparer)
                    {
                        this_param.Sort((System.Collections.IComparer)comparer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 14590, 14618);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1326, 14434, 14678);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 14434, 14678);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }
        private class PSVersionTableComparer : IComparer
        {
            public int Compare(object x, object y)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1326, 14763, 15928);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 14834, 14935);

                    string
                    xString = (string)f_1326_14859_14934(x, typeof(string), f_1326_14907_14933())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 14953, 15054);

                    string
                    yString = (string)f_1326_14978_15053(y, typeof(string), f_1326_15026_15052())
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 15072, 15913) || true) && (f_1326_15076_15155(PSVersionInfo.PSVersionName, xString, StringComparison.OrdinalIgnoreCase))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 15072, 15913);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 15197, 15207);

                        return -1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 15072, 15913);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 15072, 15913);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 15249, 15913) || true) && (f_1326_15253_15332(PSVersionInfo.PSVersionName, yString, StringComparison.OrdinalIgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 15249, 15913);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 15374, 15383);

                            return 1;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 15249, 15913);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 15249, 15913);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 15425, 15913) || true) && (f_1326_15429_15508(PSVersionInfo.PSEditionName, xString, StringComparison.OrdinalIgnoreCase))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 15425, 15913);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 15550, 15560);

                                return -1;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 15425, 15913);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 15425, 15913);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 15602, 15913) || true) && (f_1326_15606_15685(PSVersionInfo.PSEditionName, yString, StringComparison.OrdinalIgnoreCase))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 15602, 15913);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 15727, 15736);

                                    return 1;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 15602, 15913);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 15602, 15913);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 15818, 15894);

                                    return f_1326_15825_15893(xString, yString, StringComparison.OrdinalIgnoreCase);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 15602, 15913);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 15425, 15913);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 15249, 15913);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 15072, 15913);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1326, 14763, 15928);

                    System.Globalization.CultureInfo
                    f_1326_14907_14933()
                    {
                        var return_v = CultureInfo.CurrentCulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 14907, 14933);
                        return return_v;
                    }


                    object
                    f_1326_14859_14934(object
                    valueToConvert, System.Type
                    resultType, System.Globalization.CultureInfo
                    formatProvider)
                    {
                        var return_v = LanguagePrimitives.ConvertTo(valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 14859, 14934);
                        return return_v;
                    }


                    System.Globalization.CultureInfo
                    f_1326_15026_15052()
                    {
                        var return_v = CultureInfo.CurrentCulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 15026, 15052);
                        return return_v;
                    }


                    object
                    f_1326_14978_15053(object
                    valueToConvert, System.Type
                    resultType, System.Globalization.CultureInfo
                    formatProvider)
                    {
                        var return_v = LanguagePrimitives.ConvertTo(valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 14978, 15053);
                        return return_v;
                    }


                    bool
                    f_1326_15076_15155(string
                    this_param, string
                    value, System.StringComparison
                    comparisonType)
                    {
                        var return_v = this_param.Equals(value, comparisonType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 15076, 15155);
                        return return_v;
                    }


                    bool
                    f_1326_15253_15332(string
                    this_param, string
                    value, System.StringComparison
                    comparisonType)
                    {
                        var return_v = this_param.Equals(value, comparisonType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 15253, 15332);
                        return return_v;
                    }


                    bool
                    f_1326_15429_15508(string
                    this_param, string
                    value, System.StringComparison
                    comparisonType)
                    {
                        var return_v = this_param.Equals(value, comparisonType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 15429, 15508);
                        return return_v;
                    }


                    bool
                    f_1326_15606_15685(string
                    this_param, string
                    value, System.StringComparison
                    comparisonType)
                    {
                        var return_v = this_param.Equals(value, comparisonType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 15606, 15685);
                        return return_v;
                    }


                    int
                    f_1326_15825_15893(string
                    strA, string
                    strB, System.StringComparison
                    comparisonType)
                    {
                        var return_v = string.Compare(strA, strB, comparisonType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 15825, 15893);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1326, 14763, 15928);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 14763, 15928);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public PSVersionTableComparer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1326, 14690, 15939);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1326, 14690, 15939);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 14690, 15939);
            }


            static PSVersionTableComparer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1326, 14690, 15939);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1326, 14690, 15939);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 14690, 15939);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1326, 14690, 15939);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1326, 16137, 16337);

                var listYield = new Collections.Generic.List<object>();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 16201, 16326);
                    foreach (object key in f_1326_16224_16228_I(f_1326_16224_16228()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 16201, 16326);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 16262, 16311);

                        listYield.Add(f_1326_16275_16310(key, f_1326_16300_16309(this, key)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 16201, 16326);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1326, 1, 126);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1326, 1, 126);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1326, 16137, 16337);

                return listYield.GetEnumerator();

                System.Collections.ICollection
                f_1326_16224_16228()
                {
                    var return_v = Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 16224, 16228);
                    return return_v;
                }


                object
                f_1326_16300_16309(System.Management.Automation.PSVersionHashTable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 16300, 16309);
                    return return_v;
                }


                System.Collections.DictionaryEntry
                f_1326_16275_16310(object
                key, object
                value)
                {
                    var return_v = new System.Collections.DictionaryEntry(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 16275, 16310);
                    return return_v;
                }


                System.Collections.ICollection
                f_1326_16224_16228_I(System.Collections.ICollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 16224, 16228);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1326, 16137, 16337);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 16137, 16337);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PSVersionHashTable()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1326, 13836, 16344);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 13963, 14008);
            s_keysComparer = f_1326_13980_14008();
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1326, 13836, 16344);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 13836, 16344);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1326, 13836, 16344);

        static System.Management.Automation.PSVersionHashTable.PSVersionTableComparer
        f_1326_13980_14008()
        {
            var return_v = new System.Management.Automation.PSVersionHashTable.PSVersionTableComparer();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 13980, 14008);
            return return_v;
        }


        static System.Collections.IEqualityComparer
        f_1326_14090_14106_C(System.Collections.IEqualityComparer
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1326, 14019, 14129);
            return return_v;
        }

    }
    public sealed class SemanticVersion : IComparable, IComparable<SemanticVersion>, IEquatable<SemanticVersion>
    {
        private const string
        VersionSansRegEx = @"^(?<major>\d+)(\.(?<minor>\d+))?(\.(?<patch>\d+))?$"
        ;

        private const string
        LabelRegEx = @"^((?<preLabel>[0-9A-Za-z][0-9A-Za-z\-\.]*))?(\+(?<buildLabel>[0-9A-Za-z][0-9A-Za-z\-\.]*))?$"
        ;

        private const string
        LabelUnitRegEx = @"^[0-9A-Za-z][0-9A-Za-z\-\.]*$"
        ;

        private const string
        PreLabelPropertyName = "PSSemVerPreReleaseLabel"
        ;

        private const string
        BuildLabelPropertyName = "PSSemVerBuildLabel"
        ;

        private const string
        TypeNameForVersionWithLabel = "System.Version#IncludeLabel"
        ;

        private string versionString;

        public SemanticVersion(string version)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1326, 17782, 18095);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 17466, 17479);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 25298, 25323);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 25437, 25462);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 25574, 25599);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 25765, 25803);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 25964, 25997);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 17845, 17884);

                var
                v = f_1326_17853_17883(version)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 17900, 17916);

                Major = f_1326_17908_17915(v);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 17930, 17946);

                Minor = f_1326_17938_17945(v);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 17960, 17994);

                Patch = (DynAbs.Tracing.TraceSender.Conditional_F1(1326, 17968, 17979) || ((f_1326_17968_17975(v) < 0 && DynAbs.Tracing.TraceSender.Conditional_F2(1326, 17982, 17983)) || DynAbs.Tracing.TraceSender.Conditional_F3(1326, 17986, 17993))) ? 0 : f_1326_17986_17993(v);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 18008, 18044);

                PreReleaseLabel = f_1326_18026_18043(v);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 18058, 18084);

                BuildLabel = f_1326_18071_18083(v);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1326, 17782, 18095);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1326, 17782, 18095);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 17782, 18095);
            }
        }

        public SemanticVersion(int major, int minor, int patch, string preReleaseLabel, string buildLabel)
        : this(f_1326_18898_18903_C(major), minor, patch)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1326, 18779, 19443);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 18943, 19192) || true) && (!f_1326_18948_18985(preReleaseLabel))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 18943, 19192);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 19019, 19123) || true) && (!f_1326_19024_19070(preReleaseLabel, LabelUnitRegEx))
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 19019, 19123);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 19072, 19123);

                        throw f_1326_19078_19122(nameof(preReleaseLabel));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 19019, 19123);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 19143, 19177);

                    PreReleaseLabel = preReleaseLabel;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 18943, 19192);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 19208, 19432) || true) && (!f_1326_19213_19245(buildLabel))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 19208, 19432);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 19279, 19373) || true) && (!f_1326_19284_19325(buildLabel, LabelUnitRegEx))
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 19279, 19373);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 19327, 19373);

                        throw f_1326_19333_19372(nameof(buildLabel));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 19279, 19373);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 19393, 19417);

                    BuildLabel = buildLabel;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 19208, 19432);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1326, 18779, 19443);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1326, 18779, 19443);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 18779, 19443);
            }
        }

        public SemanticVersion(int major, int minor, int patch, string label)
        : this(f_1326_20075_20080_C(major), minor, patch)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1326, 19985, 20606);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 20259, 20595) || true) && (!f_1326_20264_20291(label))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 20259, 20595);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 20325, 20368);

                    var
                    match = f_1326_20337_20367(label, LabelRegEx)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 20386, 20447) || true) && (f_1326_20390_20404_M(!match.Success))
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 20386, 20447);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 20406, 20447);

                        throw f_1326_20412_20446(nameof(label));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 20386, 20447);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 20467, 20516);

                    PreReleaseLabel = f_1326_20485_20515(f_1326_20485_20509(f_1326_20485_20497(match), "preLabel"));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 20534, 20580);

                    BuildLabel = f_1326_20547_20579(f_1326_20547_20573(f_1326_20547_20559(match), "buildLabel"));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 20259, 20595);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1326, 19985, 20606);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1326, 19985, 20606);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 19985, 20606);
            }
        }

        public SemanticVersion(int major, int minor, int patch)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1326, 21077, 21598);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 17466, 17479);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 25298, 25323);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 25437, 25462);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 25574, 25599);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 25765, 25803);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 25964, 25997);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 21157, 21228) || true) && (major < 0)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 21157, 21228);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 21172, 21228);

                    throw f_1326_21178_21227(nameof(major));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 21157, 21228);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 21242, 21313) || true) && (minor < 0)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 21242, 21313);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 21257, 21313);

                    throw f_1326_21263_21312(nameof(minor));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 21242, 21313);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 21327, 21398) || true) && (patch < 0)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 21327, 21398);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 21342, 21398);

                    throw f_1326_21348_21397(nameof(patch));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 21327, 21398);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 21414, 21428);

                Major = major;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 21442, 21456);

                Minor = minor;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 21470, 21484);

                Patch = patch;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1326, 21077, 21598);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1326, 21077, 21598);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 21077, 21598);
            }
        }

        public SemanticVersion(int major, int minor) : this(f_1326_22034_22039_C(major), minor, 0)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1326, 21982, 22054);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1326, 21982, 22054);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1326, 21982, 22054);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 21982, 22054);
            }
        }

        public SemanticVersion(int major) : this(f_1326_22391_22396_C(major), 0, 0)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1326, 22350, 22407);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1326, 22350, 22407);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1326, 22350, 22407);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 22350, 22407);
            }
        }

        public SemanticVersion(Version version)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1326, 22974, 23831);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 17466, 17479);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 25298, 25323);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 25437, 25462);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 25574, 25599);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 25765, 25803);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 25964, 25997);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 23038, 23121) || true) && (version == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 23038, 23121);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 23059, 23121);

                    throw f_1326_23065_23120(nameof(version));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 23038, 23121);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 23135, 23219) || true) && (f_1326_23139_23155(version) > 0)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 23135, 23219);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 23161, 23219);

                    throw f_1326_23167_23218(nameof(version));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 23135, 23219);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 23235, 23257);

                Major = f_1326_23243_23256(version);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 23271, 23293);

                Minor = f_1326_23279_23292(version);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 23307, 23355);

                Patch = (DynAbs.Tracing.TraceSender.Conditional_F1(1326, 23315, 23334) || ((f_1326_23315_23328(version) == -1 && DynAbs.Tracing.TraceSender.Conditional_F2(1326, 23337, 23338)) || DynAbs.Tracing.TraceSender.Conditional_F3(1326, 23341, 23354))) ? 0 : f_1326_23341_23354(version);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 23369, 23403);

                var
                psobj = f_1326_23381_23402(version)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 23417, 23475);

                var
                preLabelNote = f_1326_23436_23474(f_1326_23436_23452(psobj), PreLabelPropertyName)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 23489, 23609) || true) && (preLabelNote != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 23489, 23609);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 23547, 23594);

                    PreReleaseLabel = f_1326_23565_23583(preLabelNote) as string;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 23489, 23609);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 23625, 23687);

                var
                buildLabelNote = f_1326_23646_23686(f_1326_23646_23662(psobj), BuildLabelPropertyName)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 23701, 23820) || true) && (buildLabelNote != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 23701, 23820);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 23761, 23805);

                    BuildLabel = f_1326_23774_23794(buildLabelNote) as string;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 23701, 23820);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1326, 22974, 23831);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1326, 22974, 23831);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 22974, 23831);
            }
        }

        /// <summary>
        /// Convert a <see cref="SemanticVersion"/> to a <see cref="Version"/>.
        /// If there is a <see cref="PreReleaseLabel"/> or/and a <see cref="BuildLabel"/>,
        /// it is added as a NoteProperty to the result so that you can round trip
        /// back to a <see cref="SemanticVersion"/> without losing the label.
        /// </summary>
        /// <param name="semver"></param>
        public static implicit operator Version(SemanticVersion semver)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1326, 24269, 25184);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 24357, 24372);

                PSObject
                psobj
                = default(PSObject);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 24388, 24455);

                var
                result = f_1326_24401_24454(f_1326_24413_24425(semver), f_1326_24427_24439(semver), f_1326_24441_24453(semver))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 24471, 25143) || true) && (!f_1326_24476_24520(f_1326_24497_24519(semver)) || (DynAbs.Tracing.TraceSender.Expression_False(1326, 24475, 24564) || !f_1326_24525_24564(f_1326_24546_24563(semver))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 24471, 25143);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 24598, 24627);

                    psobj = f_1326_24606_24626(result);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 24647, 24844) || true) && (!f_1326_24652_24696(f_1326_24673_24695(semver)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 24647, 24844);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 24738, 24825);

                        f_1326_24738_24824(f_1326_24738_24754(psobj), f_1326_24759_24823(PreLabelPropertyName, f_1326_24800_24822(semver)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 24647, 24844);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 24864, 25053) || true) && (!f_1326_24869_24908(f_1326_24890_24907(semver)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 24864, 25053);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 24950, 25034);

                        f_1326_24950_25033(f_1326_24950_24966(psobj), f_1326_24971_25032(BuildLabelPropertyName, f_1326_25014_25031(semver)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 24864, 25053);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 25073, 25128);

                    f_1326_25073_25127(f_1326_25073_25088(psobj), 0, TypeNameForVersionWithLabel);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 24471, 25143);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 25159, 25173);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1326, 24269, 25184);

                int
                f_1326_24413_24425(System.Management.Automation.SemanticVersion
                this_param)
                {
                    var return_v = this_param.Major;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 24413, 24425);
                    return return_v;
                }


                int
                f_1326_24427_24439(System.Management.Automation.SemanticVersion
                this_param)
                {
                    var return_v = this_param.Minor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 24427, 24439);
                    return return_v;
                }


                int
                f_1326_24441_24453(System.Management.Automation.SemanticVersion
                this_param)
                {
                    var return_v = this_param.Patch;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 24441, 24453);
                    return return_v;
                }


                System.Version
                f_1326_24401_24454(int
                major, int
                minor, int
                build)
                {
                    var return_v = new System.Version(major, minor, build);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 24401, 24454);
                    return return_v;
                }


                string
                f_1326_24497_24519(System.Management.Automation.SemanticVersion
                this_param)
                {
                    var return_v = this_param.PreReleaseLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 24497, 24519);
                    return return_v;
                }


                bool
                f_1326_24476_24520(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 24476, 24520);
                    return return_v;
                }


                string
                f_1326_24546_24563(System.Management.Automation.SemanticVersion
                this_param)
                {
                    var return_v = this_param.BuildLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 24546, 24563);
                    return return_v;
                }


                bool
                f_1326_24525_24564(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 24525, 24564);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1326_24606_24626(System.Version
                obj)
                {
                    var return_v = new System.Management.Automation.PSObject((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 24606, 24626);
                    return return_v;
                }


                string
                f_1326_24673_24695(System.Management.Automation.SemanticVersion
                this_param)
                {
                    var return_v = this_param.PreReleaseLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 24673, 24695);
                    return return_v;
                }


                bool
                f_1326_24652_24696(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 24652, 24696);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1326_24738_24754(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 24738, 24754);
                    return return_v;
                }


                string
                f_1326_24800_24822(System.Management.Automation.SemanticVersion
                this_param)
                {
                    var return_v = this_param.PreReleaseLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 24800, 24822);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1326_24759_24823(string
                name, string
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 24759, 24823);
                    return return_v;
                }


                int
                f_1326_24738_24824(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 24738, 24824);
                    return 0;
                }


                string
                f_1326_24890_24907(System.Management.Automation.SemanticVersion
                this_param)
                {
                    var return_v = this_param.BuildLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 24890, 24907);
                    return return_v;
                }


                bool
                f_1326_24869_24908(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 24869, 24908);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1326_24950_24966(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 24950, 24966);
                    return return_v;
                }


                string
                f_1326_25014_25031(System.Management.Automation.SemanticVersion
                this_param)
                {
                    var return_v = this_param.BuildLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 25014, 25031);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1326_24971_25032(string
                name, string
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 24971, 25032);
                    return return_v;
                }


                int
                f_1326_24950_25033(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 24950, 25033);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1326_25073_25088(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.TypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 25073, 25088);
                    return return_v;
                }


                int
                f_1326_25073_25127(System.Collections.ObjectModel.Collection<string>
                this_param, int
                index, string
                item)
                {
                    this_param.Insert(index, item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 25073, 25127);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1326, 24269, 25184);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 24269, 25184);
            }
        }
        public int Major { get; }

        public int Minor { get; }

        public int Patch { get; }

        public string PreReleaseLabel { get; }

        public string BuildLabel { get; }

        public static SemanticVersion Parse(string version)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1326, 26486, 26899);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 26562, 26645) || true) && (version == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 26562, 26645);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 26583, 26645);

                    throw f_1326_26589_26644(nameof(version));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 26562, 26645);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 26659, 26731) || true) && (version == string.Empty)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 26659, 26731);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 26688, 26731);

                    throw f_1326_26694_26730(nameof(version));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 26659, 26731);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 26747, 26775);

                var
                r = f_1326_26755_26774()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 26789, 26802);

                r.Init(true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 26816, 26848);

                f_1326_26816_26847(version, ref r);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 26864, 26888);

                return r._parsedVersion;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1326, 26486, 26899);

                System.Management.Automation.PSArgumentNullException
                f_1326_26589_26644(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 26589, 26644);
                    return return_v;
                }


                System.FormatException
                f_1326_26694_26730(string
                message)
                {
                    var return_v = new System.FormatException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 26694, 26730);
                    return return_v;
                }


                System.Management.Automation.SemanticVersion.VersionResult
                f_1326_26755_26774()
                {
                    var return_v = new System.Management.Automation.SemanticVersion.VersionResult();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 26755, 26774);
                    return return_v;
                }


                bool
                f_1326_26816_26847(string
                version, ref System.Management.Automation.SemanticVersion.VersionResult
                result)
                {
                    var return_v = TryParseVersion(version, ref result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 26816, 26847);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1326, 26486, 26899);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 26486, 26899);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool TryParse(string version, out SemanticVersion result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1326, 27311, 27779);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 27407, 27711) || true) && (version != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 27407, 27711);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 27460, 27488);

                    var
                    r = f_1326_27468_27487()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 27506, 27520);

                    r.Init(false);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 27540, 27696) || true) && (f_1326_27544_27575(version, ref r))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 27540, 27696);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 27617, 27643);

                        result = r._parsedVersion;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 27665, 27677);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 27540, 27696);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 27407, 27711);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 27727, 27741);

                result = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 27755, 27768);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1326, 27311, 27779);

                System.Management.Automation.SemanticVersion.VersionResult
                f_1326_27468_27487()
                {
                    var return_v = new System.Management.Automation.SemanticVersion.VersionResult();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 27468, 27487);
                    return return_v;
                }


                bool
                f_1326_27544_27575(string
                version, ref System.Management.Automation.SemanticVersion.VersionResult
                result)
                {
                    var return_v = TryParseVersion(version, ref result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 27544, 27575);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1326, 27311, 27779);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 27311, 27779);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool TryParseVersion(string version, ref VersionResult result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1326, 27791, 32009);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 27893, 28100) || true) && (f_1326_27897_27918(version, '-') || (DynAbs.Tracing.TraceSender.Expression_False(1326, 27897, 27943) || f_1326_27922_27943(version, '+')) || (DynAbs.Tracing.TraceSender.Expression_False(1326, 27897, 27968) || f_1326_27947_27968(version, '.')))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 27893, 28100);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 28002, 28054);

                    result.SetFailure(ParseFailureKind.FormatException);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 28072, 28085);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 27893, 28100);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 28116, 28147);

                string
                versionSansLabel = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 28161, 28175);

                var
                major = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 28189, 28203);

                var
                minor = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 28217, 28231);

                var
                patch = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 28245, 28268);

                string
                preLabel = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 28282, 28307);

                string
                buildLabel = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 28424, 28461);

                var
                dashIndex = f_1326_28440_28460(version, '-')
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 28475, 28512);

                var
                plusIndex = f_1326_28491_28511(version, '+')
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 28528, 30126) || true) && (dashIndex > plusIndex)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 28528, 30126);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 28646, 29335) || true) && (plusIndex == -1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 28646, 29335);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 28835, 28879);

                        preLabel = f_1326_28846_28878(version, dashIndex + 1);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 28901, 28952);

                        versionSansLabel = f_1326_28920_28951(version, 0, dashIndex);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 28646, 29335);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 28646, 29335);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 29160, 29206);

                        buildLabel = f_1326_29173_29205(version, plusIndex + 1);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 29228, 29279);

                        versionSansLabel = f_1326_29247_29278(version, 0, plusIndex);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 29301, 29316);

                        dashIndex = -1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 28646, 29335);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 28528, 30126);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 28528, 30126);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 29401, 30111) || true) && (dashIndex == -1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 29401, 30111);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 29690, 29717);

                        versionSansLabel = version;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 29401, 30111);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 29401, 30111);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 29880, 29951);

                        preLabel = f_1326_29891_29950(version, dashIndex + 1, plusIndex - dashIndex - 1);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 29973, 30019);

                        buildLabel = f_1326_29986_30018(version, plusIndex + 1);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 30041, 30092);

                        versionSansLabel = f_1326_30060_30091(version, 0, dashIndex);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 29401, 30111);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 28528, 30126);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 30142, 30650) || true) && ((dashIndex != -1 && (DynAbs.Tracing.TraceSender.Expression_True(1326, 30147, 30196) && f_1326_30166_30196(preLabel))) || (DynAbs.Tracing.TraceSender.Expression_False(1326, 30146, 30271) || (plusIndex != -1 && (DynAbs.Tracing.TraceSender.Expression_True(1326, 30219, 30270) && f_1326_30238_30270(buildLabel)))) || (DynAbs.Tracing.TraceSender.Expression_False(1326, 30146, 30330) || f_1326_30292_30330(versionSansLabel)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 30142, 30650);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 30552, 30604);

                    result.SetFailure(ParseFailureKind.FormatException);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 30622, 30635);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 30142, 30650);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 30666, 30726);

                var
                match = f_1326_30678_30725(versionSansLabel, VersionSansRegEx)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 30740, 30890) || true) && (f_1326_30744_30758_M(!match.Success))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 30740, 30890);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 30792, 30844);

                    result.SetFailure(ParseFailureKind.FormatException);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 30862, 30875);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 30740, 30890);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 30906, 31095) || true) && (!f_1326_30911_30963(f_1326_30924_30951(f_1326_30924_30945(f_1326_30924_30936(match), "major")), out major))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 30906, 31095);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 30997, 31049);

                    result.SetFailure(ParseFailureKind.FormatException);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 31067, 31080);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 30906, 31095);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 31111, 31333) || true) && (f_1326_31115_31144(f_1326_31115_31136(f_1326_31115_31127(match), "minor")) && (DynAbs.Tracing.TraceSender.Expression_True(1326, 31115, 31201) && !f_1326_31149_31201(f_1326_31162_31189(f_1326_31162_31183(f_1326_31162_31174(match), "minor")), out minor)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 31111, 31333);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 31235, 31287);

                    result.SetFailure(ParseFailureKind.FormatException);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 31305, 31318);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 31111, 31333);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 31349, 31571) || true) && (f_1326_31353_31382(f_1326_31353_31374(f_1326_31353_31365(match), "patch")) && (DynAbs.Tracing.TraceSender.Expression_True(1326, 31353, 31439) && !f_1326_31387_31439(f_1326_31400_31427(f_1326_31400_31421(f_1326_31400_31412(match), "patch")), out patch)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 31349, 31571);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 31473, 31525);

                    result.SetFailure(ParseFailureKind.FormatException);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 31543, 31556);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 31349, 31571);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 31587, 31869) || true) && (preLabel != null && (DynAbs.Tracing.TraceSender.Expression_True(1326, 31591, 31651) && !f_1326_31612_31651(preLabel, LabelUnitRegEx)) || (DynAbs.Tracing.TraceSender.Expression_False(1326, 31591, 31737) || (buildLabel != null && (DynAbs.Tracing.TraceSender.Expression_True(1326, 31672, 31736) && !f_1326_31695_31736(buildLabel, LabelUnitRegEx)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 31587, 31869);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 31771, 31823);

                    result.SetFailure(ParseFailureKind.FormatException);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 31841, 31854);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 31587, 31869);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 31885, 31972);

                result._parsedVersion = f_1326_31909_31971(major, minor, patch, preLabel, buildLabel);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 31986, 31998);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1326, 27791, 32009);

                bool
                f_1326_27897_27918(string
                this_param, char
                value)
                {
                    var return_v = this_param.EndsWith(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 27897, 27918);
                    return return_v;
                }


                bool
                f_1326_27922_27943(string
                this_param, char
                value)
                {
                    var return_v = this_param.EndsWith(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 27922, 27943);
                    return return_v;
                }


                bool
                f_1326_27947_27968(string
                this_param, char
                value)
                {
                    var return_v = this_param.EndsWith(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 27947, 27968);
                    return return_v;
                }


                int
                f_1326_28440_28460(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 28440, 28460);
                    return return_v;
                }


                int
                f_1326_28491_28511(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 28491, 28511);
                    return return_v;
                }


                string
                f_1326_28846_28878(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 28846, 28878);
                    return return_v;
                }


                string
                f_1326_28920_28951(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 28920, 28951);
                    return return_v;
                }


                string
                f_1326_29173_29205(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 29173, 29205);
                    return return_v;
                }


                string
                f_1326_29247_29278(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 29247, 29278);
                    return return_v;
                }


                string
                f_1326_29891_29950(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 29891, 29950);
                    return return_v;
                }


                string
                f_1326_29986_30018(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 29986, 30018);
                    return return_v;
                }


                string
                f_1326_30060_30091(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 30060, 30091);
                    return return_v;
                }


                bool
                f_1326_30166_30196(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 30166, 30196);
                    return return_v;
                }


                bool
                f_1326_30238_30270(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 30238, 30270);
                    return return_v;
                }


                bool
                f_1326_30292_30330(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 30292, 30330);
                    return return_v;
                }


                System.Text.RegularExpressions.Match
                f_1326_30678_30725(string
                input, string
                pattern)
                {
                    var return_v = Regex.Match(input, pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 30678, 30725);
                    return return_v;
                }


                bool
                f_1326_30744_30758_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 30744, 30758);
                    return return_v;
                }


                System.Text.RegularExpressions.GroupCollection
                f_1326_30924_30936(System.Text.RegularExpressions.Match
                this_param)
                {
                    var return_v = this_param.Groups;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 30924, 30936);
                    return return_v;
                }


                System.Text.RegularExpressions.Group
                f_1326_30924_30945(System.Text.RegularExpressions.GroupCollection
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 30924, 30945);
                    return return_v;
                }


                string
                f_1326_30924_30951(System.Text.RegularExpressions.Group
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 30924, 30951);
                    return return_v;
                }


                bool
                f_1326_30911_30963(string
                s, out int
                result)
                {
                    var return_v = int.TryParse(s, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 30911, 30963);
                    return return_v;
                }


                System.Text.RegularExpressions.GroupCollection
                f_1326_31115_31127(System.Text.RegularExpressions.Match
                this_param)
                {
                    var return_v = this_param.Groups;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 31115, 31127);
                    return return_v;
                }


                System.Text.RegularExpressions.Group
                f_1326_31115_31136(System.Text.RegularExpressions.GroupCollection
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 31115, 31136);
                    return return_v;
                }


                bool
                f_1326_31115_31144(System.Text.RegularExpressions.Group
                this_param)
                {
                    var return_v = this_param.Success;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 31115, 31144);
                    return return_v;
                }


                System.Text.RegularExpressions.GroupCollection
                f_1326_31162_31174(System.Text.RegularExpressions.Match
                this_param)
                {
                    var return_v = this_param.Groups;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 31162, 31174);
                    return return_v;
                }


                System.Text.RegularExpressions.Group
                f_1326_31162_31183(System.Text.RegularExpressions.GroupCollection
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 31162, 31183);
                    return return_v;
                }


                string
                f_1326_31162_31189(System.Text.RegularExpressions.Group
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 31162, 31189);
                    return return_v;
                }


                bool
                f_1326_31149_31201(string
                s, out int
                result)
                {
                    var return_v = int.TryParse(s, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 31149, 31201);
                    return return_v;
                }


                System.Text.RegularExpressions.GroupCollection
                f_1326_31353_31365(System.Text.RegularExpressions.Match
                this_param)
                {
                    var return_v = this_param.Groups;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 31353, 31365);
                    return return_v;
                }


                System.Text.RegularExpressions.Group
                f_1326_31353_31374(System.Text.RegularExpressions.GroupCollection
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 31353, 31374);
                    return return_v;
                }


                bool
                f_1326_31353_31382(System.Text.RegularExpressions.Group
                this_param)
                {
                    var return_v = this_param.Success;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 31353, 31382);
                    return return_v;
                }


                System.Text.RegularExpressions.GroupCollection
                f_1326_31400_31412(System.Text.RegularExpressions.Match
                this_param)
                {
                    var return_v = this_param.Groups;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 31400, 31412);
                    return return_v;
                }


                System.Text.RegularExpressions.Group
                f_1326_31400_31421(System.Text.RegularExpressions.GroupCollection
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 31400, 31421);
                    return return_v;
                }


                string
                f_1326_31400_31427(System.Text.RegularExpressions.Group
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 31400, 31427);
                    return return_v;
                }


                bool
                f_1326_31387_31439(string
                s, out int
                result)
                {
                    var return_v = int.TryParse(s, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 31387, 31439);
                    return return_v;
                }


                bool
                f_1326_31612_31651(string
                input, string
                pattern)
                {
                    var return_v = Regex.IsMatch(input, pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 31612, 31651);
                    return return_v;
                }


                bool
                f_1326_31695_31736(string
                input, string
                pattern)
                {
                    var return_v = Regex.IsMatch(input, pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 31695, 31736);
                    return return_v;
                }


                System.Management.Automation.SemanticVersion
                f_1326_31909_31971(int
                major, int
                minor, int
                patch, string
                preReleaseLabel, string
                buildLabel)
                {
                    var return_v = new System.Management.Automation.SemanticVersion(major, minor, patch, preReleaseLabel, buildLabel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 31909, 31971);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1326, 27791, 32009);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 27791, 32009);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1326, 32102, 32828);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 32160, 32780) || true) && (versionString == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 32160, 32780);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 32219, 32262);

                    StringBuilder
                    result = f_1326_32242_32261()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 32282, 32389);

                    f_1326_32282_32388(f_1326_32282_32374(f_1326_32282_32345(f_1326_32282_32331(f_1326_32282_32302(
                                    result, f_1326_32296_32301()), Utils.Separators.Dot), f_1326_32339_32344()), Utils.Separators.Dot), f_1326_32382_32387());

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 32409, 32555) || true) && (!f_1326_32414_32451(f_1326_32435_32450()))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 32409, 32555);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 32493, 32536);

                        f_1326_32493_32535(f_1326_32493_32511(result, "-"), f_1326_32519_32534());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 32409, 32555);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 32575, 32711) || true) && (!f_1326_32580_32612(f_1326_32601_32611()))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 32575, 32711);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 32654, 32692);

                        f_1326_32654_32691(f_1326_32654_32672(result, "+"), f_1326_32680_32690());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 32575, 32711);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 32731, 32765);

                    versionString = f_1326_32747_32764(result);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 32160, 32780);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 32796, 32817);

                return versionString;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1326, 32102, 32828);

                System.Text.StringBuilder
                f_1326_32242_32261()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 32242, 32261);
                    return return_v;
                }


                int
                f_1326_32296_32301()
                {
                    var return_v = Major;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 32296, 32301);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1326_32282_32302(System.Text.StringBuilder
                this_param, int
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 32282, 32302);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1326_32282_32331(System.Text.StringBuilder
                this_param, char[]
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 32282, 32331);
                    return return_v;
                }


                int
                f_1326_32339_32344()
                {
                    var return_v = Minor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 32339, 32344);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1326_32282_32345(System.Text.StringBuilder
                this_param, int
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 32282, 32345);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1326_32282_32374(System.Text.StringBuilder
                this_param, char[]
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 32282, 32374);
                    return return_v;
                }


                int
                f_1326_32382_32387()
                {
                    var return_v = Patch;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 32382, 32387);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1326_32282_32388(System.Text.StringBuilder
                this_param, int
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 32282, 32388);
                    return return_v;
                }


                string
                f_1326_32435_32450()
                {
                    var return_v = PreReleaseLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 32435, 32450);
                    return return_v;
                }


                bool
                f_1326_32414_32451(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 32414, 32451);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1326_32493_32511(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 32493, 32511);
                    return return_v;
                }


                string
                f_1326_32519_32534()
                {
                    var return_v = PreReleaseLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 32519, 32534);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1326_32493_32535(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 32493, 32535);
                    return return_v;
                }


                string
                f_1326_32601_32611()
                {
                    var return_v = BuildLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 32601, 32611);
                    return return_v;
                }


                bool
                f_1326_32580_32612(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 32580, 32612);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1326_32654_32672(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 32654, 32672);
                    return return_v;
                }


                string
                f_1326_32680_32690()
                {
                    var return_v = BuildLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 32680, 32690);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1326_32654_32691(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 32654, 32691);
                    return return_v;
                }


                string
                f_1326_32747_32764(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 32747, 32764);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1326, 32102, 32828);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 32102, 32828);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static int Compare(SemanticVersion versionA, SemanticVersion versionB)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1326, 32919, 33257);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 33021, 33126) || true) && (versionA != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 33021, 33126);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 33075, 33111);

                    return f_1326_33082_33110(versionA, versionB);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 33021, 33126);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 33142, 33221) || true) && (versionB != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 33142, 33221);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 33196, 33206);

                    return -1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 33142, 33221);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 33237, 33246);

                return 0;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1326, 32919, 33257);

                int
                f_1326_33082_33110(System.Management.Automation.SemanticVersion
                this_param, System.Management.Automation.SemanticVersion
                value)
                {
                    var return_v = this_param.CompareTo(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 33082, 33110);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1326, 32919, 33257);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 32919, 33257);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int CompareTo(object version)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1326, 33375, 33745);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 33436, 33513) || true) && (version == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 33436, 33513);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 33489, 33498);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 33436, 33513);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 33529, 33564);

                var
                v = version as SemanticVersion
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 33578, 33698) || true) && (v == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 33578, 33698);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 33625, 33683);

                    throw f_1326_33631_33682(nameof(version));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 33578, 33698);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 33714, 33734);

                return f_1326_33721_33733(this, v);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1326, 33375, 33745);

                System.Management.Automation.PSArgumentException
                f_1326_33631_33682(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 33631, 33682);
                    return return_v;
                }


                int
                f_1326_33721_33733(System.Management.Automation.SemanticVersion
                this_param, System.Management.Automation.SemanticVersion
                value)
                {
                    var return_v = this_param.CompareTo(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 33721, 33733);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1326, 33375, 33745);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 33375, 33745);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int CompareTo(SemanticVersion value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1326, 33922, 34509);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 33990, 34043) || true) && ((object)value == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 33990, 34043);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 34034, 34043);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 33990, 34043);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 34059, 34138) || true) && (f_1326_34063_34068() != f_1326_34072_34083(value))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 34059, 34138);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 34102, 34138);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1326, 34109, 34128) || ((f_1326_34109_34114() > f_1326_34117_34128(value) && DynAbs.Tracing.TraceSender.Conditional_F2(1326, 34131, 34132)) || DynAbs.Tracing.TraceSender.Conditional_F3(1326, 34135, 34137))) ? 1 : -1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 34059, 34138);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 34154, 34233) || true) && (f_1326_34158_34163() != f_1326_34167_34178(value))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 34154, 34233);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 34197, 34233);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1326, 34204, 34223) || ((f_1326_34204_34209() > f_1326_34212_34223(value) && DynAbs.Tracing.TraceSender.Conditional_F2(1326, 34226, 34227)) || DynAbs.Tracing.TraceSender.Conditional_F3(1326, 34230, 34232))) ? 1 : -1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 34154, 34233);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 34249, 34328) || true) && (f_1326_34253_34258() != f_1326_34262_34273(value))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 34249, 34328);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 34292, 34328);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1326, 34299, 34318) || ((f_1326_34299_34304() > f_1326_34307_34318(value) && DynAbs.Tracing.TraceSender.Conditional_F2(1326, 34321, 34322)) || DynAbs.Tracing.TraceSender.Conditional_F3(1326, 34325, 34327))) ? 1 : -1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 34249, 34328);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 34430, 34498);

                return f_1326_34437_34497(f_1326_34453_34473(this), f_1326_34475_34496(value));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1326, 33922, 34509);

                int
                f_1326_34063_34068()
                {
                    var return_v = Major;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 34063, 34068);
                    return return_v;
                }


                int
                f_1326_34072_34083(System.Management.Automation.SemanticVersion
                this_param)
                {
                    var return_v = this_param.Major;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 34072, 34083);
                    return return_v;
                }


                int
                f_1326_34109_34114()
                {
                    var return_v = Major;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 34109, 34114);
                    return return_v;
                }


                int
                f_1326_34117_34128(System.Management.Automation.SemanticVersion
                this_param)
                {
                    var return_v = this_param.Major;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 34117, 34128);
                    return return_v;
                }


                int
                f_1326_34158_34163()
                {
                    var return_v = Minor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 34158, 34163);
                    return return_v;
                }


                int
                f_1326_34167_34178(System.Management.Automation.SemanticVersion
                this_param)
                {
                    var return_v = this_param.Minor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 34167, 34178);
                    return return_v;
                }


                int
                f_1326_34204_34209()
                {
                    var return_v = Minor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 34204, 34209);
                    return return_v;
                }


                int
                f_1326_34212_34223(System.Management.Automation.SemanticVersion
                this_param)
                {
                    var return_v = this_param.Minor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 34212, 34223);
                    return return_v;
                }


                int
                f_1326_34253_34258()
                {
                    var return_v = Patch;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 34253, 34258);
                    return return_v;
                }


                int
                f_1326_34262_34273(System.Management.Automation.SemanticVersion
                this_param)
                {
                    var return_v = this_param.Patch;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 34262, 34273);
                    return return_v;
                }


                int
                f_1326_34299_34304()
                {
                    var return_v = Patch;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 34299, 34304);
                    return return_v;
                }


                int
                f_1326_34307_34318(System.Management.Automation.SemanticVersion
                this_param)
                {
                    var return_v = this_param.Patch;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 34307, 34318);
                    return return_v;
                }


                string
                f_1326_34453_34473(System.Management.Automation.SemanticVersion
                this_param)
                {
                    var return_v = this_param.PreReleaseLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 34453, 34473);
                    return return_v;
                }


                string
                f_1326_34475_34496(System.Management.Automation.SemanticVersion
                this_param)
                {
                    var return_v = this_param.PreReleaseLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 34475, 34496);
                    return return_v;
                }


                int
                f_1326_34437_34497(string
                preLabel1, string
                preLabel2)
                {
                    var return_v = ComparePreLabel(preLabel1, preLabel2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 34437, 34497);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1326, 33922, 34509);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 33922, 34509);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1326, 34626, 34739);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 34690, 34728);

                return f_1326_34697_34727(this, obj as SemanticVersion);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1326, 34626, 34739);

                bool
                f_1326_34697_34727(System.Management.Automation.SemanticVersion
                this_param, object
                other)
                {
                    var return_v = this_param.Equals((System.Management.Automation.SemanticVersion)other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 34697, 34727);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1326, 34626, 34739);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 34626, 34739);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Equals(SemanticVersion other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1326, 34859, 35244);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 35011, 35233);

                return other != null && (DynAbs.Tracing.TraceSender.Expression_True(1326, 35018, 35077) && (f_1326_35056_35061() == f_1326_35065_35076(other))) && (DynAbs.Tracing.TraceSender.Expression_True(1326, 35018, 35103) && (f_1326_35082_35087() == f_1326_35091_35102(other))) && (DynAbs.Tracing.TraceSender.Expression_True(1326, 35018, 35129) && (f_1326_35108_35113() == f_1326_35117_35128(other))) && (DynAbs.Tracing.TraceSender.Expression_True(1326, 35018, 35232) && f_1326_35153_35232(f_1326_35167_35182(), f_1326_35184_35205(other), StringComparison.Ordinal));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1326, 34859, 35244);

                int
                f_1326_35056_35061()
                {
                    var return_v = Major;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 35056, 35061);
                    return return_v;
                }


                int
                f_1326_35065_35076(System.Management.Automation.SemanticVersion
                this_param)
                {
                    var return_v = this_param.Major;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 35065, 35076);
                    return return_v;
                }


                int
                f_1326_35082_35087()
                {
                    var return_v = Minor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 35082, 35087);
                    return return_v;
                }


                int
                f_1326_35091_35102(System.Management.Automation.SemanticVersion
                this_param)
                {
                    var return_v = this_param.Minor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 35091, 35102);
                    return return_v;
                }


                int
                f_1326_35108_35113()
                {
                    var return_v = Patch;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 35108, 35113);
                    return return_v;
                }


                int
                f_1326_35117_35128(System.Management.Automation.SemanticVersion
                this_param)
                {
                    var return_v = this_param.Patch;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 35117, 35128);
                    return return_v;
                }


                string
                f_1326_35167_35182()
                {
                    var return_v = PreReleaseLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 35167, 35182);
                    return return_v;
                }


                string
                f_1326_35184_35205(System.Management.Automation.SemanticVersion
                this_param)
                {
                    var return_v = this_param.PreReleaseLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 35184, 35205);
                    return return_v;
                }


                bool
                f_1326_35153_35232(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 35153, 35232);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1326, 34859, 35244);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 34859, 35244);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1326, 35360, 35466);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 35418, 35455);

                return f_1326_35425_35454(f_1326_35425_35440(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1326, 35360, 35466);

                string
                f_1326_35425_35440(System.Management.Automation.SemanticVersion
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 35425, 35440);
                    return return_v;
                }


                int
                f_1326_35425_35454(string
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 35425, 35454);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1326, 35360, 35466);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 35360, 35466);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool operator ==(SemanticVersion v1, SemanticVersion v2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1326, 35562, 35830);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 35657, 35782) || true) && (f_1326_35661_35693(v1, null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 35657, 35782);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 35727, 35767);

                    return f_1326_35734_35766(v2, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 35657, 35782);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 35798, 35819);

                return f_1326_35805_35818(v1, v2);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1326, 35562, 35830);

                bool
                f_1326_35661_35693(System.Management.Automation.SemanticVersion
                objA, object?
                objB)
                {
                    var return_v = object.ReferenceEquals((object)objA, objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 35661, 35693);
                    return return_v;
                }


                bool
                f_1326_35734_35766(System.Management.Automation.SemanticVersion
                objA, object?
                objB)
                {
                    var return_v = object.ReferenceEquals((object)objA, objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 35734, 35766);
                    return return_v;
                }


                bool
                f_1326_35805_35818(System.Management.Automation.SemanticVersion
                this_param, System.Management.Automation.SemanticVersion
                other)
                {
                    var return_v = this_param.Equals(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 35805, 35818);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1326, 35562, 35830);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 35562, 35830);
            }
        }

        public static bool operator !=(SemanticVersion v1, SemanticVersion v2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1326, 35926, 36051);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 36021, 36040);

                return !(v1 == v2);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1326, 35926, 36051);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1326, 35926, 36051);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 35926, 36051);
            }
        }

        public static bool operator <(SemanticVersion v1, SemanticVersion v2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1326, 36149, 36283);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 36243, 36272);

                return (f_1326_36251_36266(v1, v2) < 0);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1326, 36149, 36283);

                int
                f_1326_36251_36266(System.Management.Automation.SemanticVersion
                versionA, System.Management.Automation.SemanticVersion
                versionB)
                {
                    var return_v = Compare(versionA, versionB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 36251, 36266);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1326, 36149, 36283);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 36149, 36283);
            }
        }

        public static bool operator <=(SemanticVersion v1, SemanticVersion v2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1326, 36382, 36518);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 36477, 36507);

                return (f_1326_36485_36500(v1, v2) <= 0);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1326, 36382, 36518);

                int
                f_1326_36485_36500(System.Management.Automation.SemanticVersion
                versionA, System.Management.Automation.SemanticVersion
                versionB)
                {
                    var return_v = Compare(versionA, versionB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 36485, 36500);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1326, 36382, 36518);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 36382, 36518);
            }
        }

        public static bool operator >(SemanticVersion v1, SemanticVersion v2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1326, 36616, 36750);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 36710, 36739);

                return (f_1326_36718_36733(v1, v2) > 0);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1326, 36616, 36750);

                int
                f_1326_36718_36733(System.Management.Automation.SemanticVersion
                versionA, System.Management.Automation.SemanticVersion
                versionB)
                {
                    var return_v = Compare(versionA, versionB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 36718, 36733);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1326, 36616, 36750);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 36616, 36750);
            }
        }

        public static bool operator >=(SemanticVersion v1, SemanticVersion v2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1326, 36849, 36985);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 36944, 36974);

                return (f_1326_36952_36967(v1, v2) >= 0);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1326, 36849, 36985);

                int
                f_1326_36952_36967(System.Management.Automation.SemanticVersion
                versionA, System.Management.Automation.SemanticVersion
                versionB)
                {
                    var return_v = Compare(versionA, versionB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 36952, 36967);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1326, 36849, 36985);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 36849, 36985);
            }
        }

        private static int ComparePreLabel(string preLabel1, string preLabel2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1326, 36997, 39002);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 37800, 37888) || true) && (f_1326_37804_37835(preLabel1))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 37800, 37888);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 37839, 37886);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1326, 37846, 37877) || ((f_1326_37846_37877(preLabel2) && DynAbs.Tracing.TraceSender.Conditional_F2(1326, 37880, 37881)) || DynAbs.Tracing.TraceSender.Conditional_F3(1326, 37884, 37885))) ? 0 : 1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 37800, 37888);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 37904, 37955) || true) && (f_1326_37908_37939(preLabel2))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 37904, 37955);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 37943, 37953);

                    return -1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 37904, 37955);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 37971, 38005);

                var
                units1 = f_1326_37984_38004(preLabel1, '.')
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 38019, 38053);

                var
                units2 = f_1326_38032_38052(preLabel2, '.')
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 38069, 38147);

                var
                minLength = (DynAbs.Tracing.TraceSender.Conditional_F1(1326, 38085, 38114) || ((f_1326_38085_38098(units1) < f_1326_38101_38114(units2) && DynAbs.Tracing.TraceSender.Conditional_F2(1326, 38117, 38130)) || DynAbs.Tracing.TraceSender.Conditional_F3(1326, 38133, 38146))) ? f_1326_38117_38130(units1) : f_1326_38133_38146(units2)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 38172, 38177);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 38163, 38929) || true) && (i < minLength)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 38194, 38197)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 38163, 38929))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 38163, 38929);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 38231, 38250);

                        var
                        ac = units1[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 38268, 38287);

                        var
                        bc = units2[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 38305, 38326);

                        int
                        number1
                        = default(int),
                        number2
                        = default(int);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 38344, 38392);

                        var
                        isNumber1 = f_1326_38360_38391(ac, out number1)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 38410, 38458);

                        var
                        isNumber2 = f_1326_38426_38457(bc, out number2)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 38478, 38914) || true) && (isNumber1 && (DynAbs.Tracing.TraceSender.Expression_True(1326, 38482, 38504) && isNumber2))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 38478, 38914);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 38546, 38608) || true) && (number1 != number2)
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 38546, 38608);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 38572, 38606);

                                return (DynAbs.Tracing.TraceSender.Conditional_F1(1326, 38579, 38596) || ((number1 < number2 && DynAbs.Tracing.TraceSender.Conditional_F2(1326, 38599, 38601)) || DynAbs.Tracing.TraceSender.Conditional_F3(1326, 38604, 38605))) ? -1 : 1;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 38546, 38608);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 38478, 38914);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 38478, 38914);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 38690, 38719) || true) && (isNumber1)
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 38690, 38719);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 38707, 38717);

                                return -1;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 38690, 38719);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 38743, 38771) || true) && (isNumber2)
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 38743, 38771);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 38760, 38769);

                                return 1;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 38743, 38771);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 38795, 38838);

                            int
                            result = f_1326_38808_38837(ac, bc)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 38860, 38895) || true) && (result != 0)
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 38860, 38895);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 38879, 38893);

                                return result;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 38860, 38895);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 38478, 38914);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1326, 1, 767);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1326, 1, 767);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 38945, 38991);

                return f_1326_38952_38990(f_1326_38952_38965(units1), f_1326_38976_38989(units2));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1326, 36997, 39002);

                bool
                f_1326_37804_37835(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 37804, 37835);
                    return return_v;
                }


                bool
                f_1326_37846_37877(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 37846, 37877);
                    return return_v;
                }


                bool
                f_1326_37908_37939(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 37908, 37939);
                    return return_v;
                }


                string[]
                f_1326_37984_38004(string
                this_param, char
                separator)
                {
                    var return_v = this_param.Split(separator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 37984, 38004);
                    return return_v;
                }


                string[]
                f_1326_38032_38052(string
                this_param, char
                separator)
                {
                    var return_v = this_param.Split(separator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 38032, 38052);
                    return return_v;
                }


                int
                f_1326_38085_38098(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 38085, 38098);
                    return return_v;
                }


                int
                f_1326_38101_38114(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 38101, 38114);
                    return return_v;
                }


                int
                f_1326_38117_38130(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 38117, 38130);
                    return return_v;
                }


                int
                f_1326_38133_38146(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 38133, 38146);
                    return return_v;
                }


                bool
                f_1326_38360_38391(string
                s, out int
                result)
                {
                    var return_v = Int32.TryParse(s, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 38360, 38391);
                    return return_v;
                }


                bool
                f_1326_38426_38457(string
                s, out int
                result)
                {
                    var return_v = Int32.TryParse(s, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 38426, 38457);
                    return return_v;
                }


                int
                f_1326_38808_38837(string
                strA, string
                strB)
                {
                    var return_v = string.CompareOrdinal(strA, strB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 38808, 38837);
                    return return_v;
                }


                int
                f_1326_38952_38965(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 38952, 38965);
                    return return_v;
                }


                int
                f_1326_38976_38989(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 38976, 38989);
                    return return_v;
                }


                int
                f_1326_38952_38990(int
                this_param, int
                value)
                {
                    var return_v = this_param.CompareTo(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 38952, 38990);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1326, 36997, 39002);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 36997, 39002);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal enum ParseFailureKind
        {
            ArgumentException,
            ArgumentOutOfRangeException,
            FormatException
        }

        internal struct VersionResult
        {

            internal SemanticVersion _parsedVersion;

            internal ParseFailureKind _failure;

            internal string _exceptionArgument;

            internal bool _canThrow;

            internal void Init(bool canThrow)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1326, 39427, 39529);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 39493, 39514);

                    _canThrow = canThrow;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1326, 39427, 39529);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1326, 39427, 39529);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 39427, 39529);
                }
            }

            internal void SetFailure(ParseFailureKind failure)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1326, 39545, 39677);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 39628, 39662);

                    SetFailure(failure, string.Empty);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1326, 39545, 39677);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1326, 39545, 39677);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 39545, 39677);
                }
            }

            internal void SetFailure(ParseFailureKind failure, string argument)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1326, 39693, 40000);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 39793, 39812);

                    _failure = failure;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 39830, 39860);

                    _exceptionArgument = argument;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 39878, 39985) || true) && (_canThrow)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 39878, 39985);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 39933, 39966);

                        throw GetVersionParseException();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 39878, 39985);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1326, 39693, 40000);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1326, 39693, 40000);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 39693, 40000);
                }
            }

            internal Exception GetVersionParseException()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1326, 40016, 41332);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 40094, 41244);

                    switch (_failure)
                    {

                        case ParseFailureKind.ArgumentException:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 40094, 41244);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 40218, 40271);

                            return f_1326_40225_40270("version");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 40094, 41244);

                        case ParseFailureKind.ArgumentOutOfRangeException:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 40094, 41244);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 40369, 40571);

                            throw f_1326_40375_40570("ValidateRangeTooSmall", null, f_1326_40467_40515(), _exceptionArgument, "0");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 40094, 41244);

                        case ParseFailureKind.FormatException:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1326, 40094, 41244);
                            // Regenerate the FormatException as would be thrown by Int32.Parse()
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 40812, 40874);

                                f_1326_40812_40873(_exceptionArgument, f_1326_40844_40872());
                            }
                            catch (FormatException e)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1326, 40927, 41045);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 41009, 41018);

                                return e;
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1326, 40927, 41045);
                            }
                            catch (OverflowException e)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1326, 41071, 41191);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 41155, 41164);

                                return e;
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1326, 41071, 41191);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(1326, 41219, 41225);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1326, 40094, 41244);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 41264, 41317);

                    return f_1326_41271_41316("version");
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1326, 40016, 41332);

                    System.Management.Automation.PSArgumentException
                    f_1326_40225_40270(string
                    paramName)
                    {
                        var return_v = PSTraceSource.NewArgumentException(paramName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 40225, 40270);
                        return return_v;
                    }


                    string
                    f_1326_40467_40515()
                    {
                        var return_v = Metadata.ValidateRangeSmallerThanMinRangeFailure;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 40467, 40515);
                        return return_v;
                    }


                    System.Management.Automation.ValidationMetadataException
                    f_1326_40375_40570(string
                    errorId, System.Exception
                    innerException, string
                    resourceStr, params object[]
                    arguments)
                    {
                        var return_v = new System.Management.Automation.ValidationMetadataException(errorId, innerException, resourceStr, arguments);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 40375, 40570);
                        return return_v;
                    }


                    System.Globalization.CultureInfo
                    f_1326_40844_40872()
                    {
                        var return_v = CultureInfo.InvariantCulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 40844, 40872);
                        return return_v;
                    }


                    int
                    f_1326_40812_40873(string
                    s, System.Globalization.CultureInfo
                    provider)
                    {
                        var return_v = Int32.Parse(s, (System.IFormatProvider)provider);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 40812, 40873);
                        return return_v;
                    }


                    System.Management.Automation.PSArgumentException
                    f_1326_41271_41316(string
                    paramName)
                    {
                        var return_v = PSTraceSource.NewArgumentException(paramName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 41271, 41316);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1326, 40016, 41332);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 40016, 41332);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            static VersionResult()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1326, 39181, 41343);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1326, 39181, 41343);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 39181, 41343);
            }
        }

        static SemanticVersion()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1326, 16752, 41350);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 16898, 16971);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 17003, 17111);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 17143, 17192);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 17224, 17272);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 17304, 17349);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1326, 17381, 17440);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1326, 16752, 41350);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1326, 16752, 41350);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1326, 16752, 41350);

        static System.Management.Automation.SemanticVersion
        f_1326_17853_17883(string
        version)
        {
            var return_v = SemanticVersion.Parse(version);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 17853, 17883);
            return return_v;
        }


        static int
        f_1326_17908_17915(System.Management.Automation.SemanticVersion
        this_param)
        {
            var return_v = this_param.Major;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 17908, 17915);
            return return_v;
        }


        static int
        f_1326_17938_17945(System.Management.Automation.SemanticVersion
        this_param)
        {
            var return_v = this_param.Minor;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 17938, 17945);
            return return_v;
        }


        static int
        f_1326_17968_17975(System.Management.Automation.SemanticVersion
        this_param)
        {
            var return_v = this_param.Patch;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 17968, 17975);
            return return_v;
        }


        static int
        f_1326_17986_17993(System.Management.Automation.SemanticVersion
        this_param)
        {
            var return_v = this_param.Patch;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 17986, 17993);
            return return_v;
        }


        static string
        f_1326_18026_18043(System.Management.Automation.SemanticVersion
        this_param)
        {
            var return_v = this_param.PreReleaseLabel;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 18026, 18043);
            return return_v;
        }


        static string
        f_1326_18071_18083(System.Management.Automation.SemanticVersion
        this_param)
        {
            var return_v = this_param.BuildLabel;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 18071, 18083);
            return return_v;
        }


        static bool
        f_1326_18948_18985(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 18948, 18985);
            return return_v;
        }


        static bool
        f_1326_19024_19070(string
        input, string
        pattern)
        {
            var return_v = Regex.IsMatch(input, pattern);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 19024, 19070);
            return return_v;
        }


        static System.FormatException
        f_1326_19078_19122(string
        message)
        {
            var return_v = new System.FormatException(message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 19078, 19122);
            return return_v;
        }


        static bool
        f_1326_19213_19245(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 19213, 19245);
            return return_v;
        }


        static bool
        f_1326_19284_19325(string
        input, string
        pattern)
        {
            var return_v = Regex.IsMatch(input, pattern);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 19284, 19325);
            return return_v;
        }


        static System.FormatException
        f_1326_19333_19372(string
        message)
        {
            var return_v = new System.FormatException(message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 19333, 19372);
            return return_v;
        }


        static int
        f_1326_18898_18903_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1326, 18779, 19443);
            return return_v;
        }


        static bool
        f_1326_20264_20291(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 20264, 20291);
            return return_v;
        }


        static System.Text.RegularExpressions.Match
        f_1326_20337_20367(string
        input, string
        pattern)
        {
            var return_v = Regex.Match(input, pattern);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 20337, 20367);
            return return_v;
        }


        bool
        f_1326_20390_20404_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 20390, 20404);
            return return_v;
        }


        static System.FormatException
        f_1326_20412_20446(string
        message)
        {
            var return_v = new System.FormatException(message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 20412, 20446);
            return return_v;
        }


        static System.Text.RegularExpressions.GroupCollection
        f_1326_20485_20497(System.Text.RegularExpressions.Match
        this_param)
        {
            var return_v = this_param.Groups;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 20485, 20497);
            return return_v;
        }


        static System.Text.RegularExpressions.Group
        f_1326_20485_20509(System.Text.RegularExpressions.GroupCollection
        this_param, string
        i0)
        {
            var return_v = this_param[i0];
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 20485, 20509);
            return return_v;
        }


        static string
        f_1326_20485_20515(System.Text.RegularExpressions.Group
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 20485, 20515);
            return return_v;
        }


        static System.Text.RegularExpressions.GroupCollection
        f_1326_20547_20559(System.Text.RegularExpressions.Match
        this_param)
        {
            var return_v = this_param.Groups;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 20547, 20559);
            return return_v;
        }


        static System.Text.RegularExpressions.Group
        f_1326_20547_20573(System.Text.RegularExpressions.GroupCollection
        this_param, string
        i0)
        {
            var return_v = this_param[i0];
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 20547, 20573);
            return return_v;
        }


        static string
        f_1326_20547_20579(System.Text.RegularExpressions.Group
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 20547, 20579);
            return return_v;
        }


        static int
        f_1326_20075_20080_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1326, 19985, 20606);
            return return_v;
        }


        static System.Management.Automation.PSArgumentException
        f_1326_21178_21227(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 21178, 21227);
            return return_v;
        }


        static System.Management.Automation.PSArgumentException
        f_1326_21263_21312(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 21263, 21312);
            return return_v;
        }


        static System.Management.Automation.PSArgumentException
        f_1326_21348_21397(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 21348, 21397);
            return return_v;
        }


        static int
        f_1326_22034_22039_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1326, 21982, 22054);
            return return_v;
        }


        static int
        f_1326_22391_22396_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1326, 22350, 22407);
            return return_v;
        }


        static System.Management.Automation.PSArgumentNullException
        f_1326_23065_23120(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 23065, 23120);
            return return_v;
        }


        static int
        f_1326_23139_23155(System.Version
        this_param)
        {
            var return_v = this_param.Revision;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 23139, 23155);
            return return_v;
        }


        static System.Management.Automation.PSArgumentException
        f_1326_23167_23218(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 23167, 23218);
            return return_v;
        }


        static int
        f_1326_23243_23256(System.Version
        this_param)
        {
            var return_v = this_param.Major;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 23243, 23256);
            return return_v;
        }


        static int
        f_1326_23279_23292(System.Version
        this_param)
        {
            var return_v = this_param.Minor;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 23279, 23292);
            return return_v;
        }


        static int
        f_1326_23315_23328(System.Version
        this_param)
        {
            var return_v = this_param.Build;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 23315, 23328);
            return return_v;
        }


        static int
        f_1326_23341_23354(System.Version
        this_param)
        {
            var return_v = this_param.Build;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 23341, 23354);
            return return_v;
        }


        static System.Management.Automation.PSObject
        f_1326_23381_23402(System.Version
        obj)
        {
            var return_v = new System.Management.Automation.PSObject((object)obj);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1326, 23381, 23402);
            return return_v;
        }


        static System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
        f_1326_23436_23452(System.Management.Automation.PSObject
        this_param)
        {
            var return_v = this_param.Properties;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 23436, 23452);
            return return_v;
        }


        static System.Management.Automation.PSPropertyInfo
        f_1326_23436_23474(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
        this_param, string
        i0)
        {
            var return_v = this_param[i0];
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 23436, 23474);
            return return_v;
        }


        static object
        f_1326_23565_23583(System.Management.Automation.PSPropertyInfo
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 23565, 23583);
            return return_v;
        }


        static System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
        f_1326_23646_23662(System.Management.Automation.PSObject
        this_param)
        {
            var return_v = this_param.Properties;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 23646, 23662);
            return return_v;
        }


        static System.Management.Automation.PSPropertyInfo
        f_1326_23646_23686(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
        this_param, string
        i0)
        {
            var return_v = this_param[i0];
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 23646, 23686);
            return return_v;
        }


        static object
        f_1326_23774_23794(System.Management.Automation.PSPropertyInfo
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1326, 23774, 23794);
            return return_v;
        }

    }
}
