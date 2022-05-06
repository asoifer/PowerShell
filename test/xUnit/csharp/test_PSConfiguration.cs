// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.IO;
using System.Management.Automation;
using System.Management.Automation.Configuration;
using System.Management.Automation.Internal;
using System.Reflection;
using System.Threading;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Xunit;

namespace PSTests.Sequential
{
    [TestCaseOrderer("TestOrder.TestCaseOrdering.PriorityOrderer", "powershell-tests")]
    public class PowerShellPolicyFixture : IDisposable
    {
        private const string
        ConfigFileName = "powershell.config.json"
        ;

        private readonly string systemWideConfigFile;

        private readonly string currentUserConfigFile;

        private readonly string systemWideConfigBackupFile;

        private readonly string currentUserConfigBackupFile;

        private readonly string systemWideConfigDirectory;

        private readonly string currentUserConfigDirectory;

        private readonly JsonSerializer serializer;

        private readonly PowerShellPolicies systemWidePolicies;

        private readonly PowerShellPolicies currentUserPolicies;

        private readonly bool originalTestHookValue;

        public PowerShellPolicyFixture()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(959, 1258, 4549);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 677, 697);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 732, 753);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 790, 816);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 851, 878);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 915, 940);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 975, 1001);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 1046, 1056);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 1105, 1123);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 1170, 1189);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 1224, 1245);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 1315, 1374);

                systemWideConfigDirectory = f_959_1343_1373();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 1388, 1442);

                currentUserConfigDirectory = Platform.ConfigDirectory;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 1458, 1690) || true) && (!f_959_1463_1507(currentUserConfigDirectory))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(959, 1458, 1690);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 1621, 1675);

                    f_959_1621_1674(currentUserConfigDirectory);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(959, 1458, 1690);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 1706, 1785);

                systemWideConfigFile = f_959_1729_1784(systemWideConfigDirectory, ConfigFileName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 1799, 1880);

                currentUserConfigFile = f_959_1823_1879(currentUserConfigDirectory, ConfigFileName);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 1896, 2149) || true) && (f_959_1900_1933(systemWideConfigFile))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(959, 1896, 2149);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 1967, 2056);

                    systemWideConfigBackupFile = f_959_1996_2055(f_959_2009_2027(), Guid.NewGuid().ToString());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 2074, 2134);

                    f_959_2074_2133(systemWideConfigFile, systemWideConfigBackupFile);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(959, 1896, 2149);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 2165, 2422) || true) && (f_959_2169_2203(currentUserConfigFile))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(959, 2165, 2422);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 2237, 2327);

                    currentUserConfigBackupFile = f_959_2267_2326(f_959_2280_2298(), Guid.NewGuid().ToString());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 2345, 2407);

                    f_959_2345_2406(currentUserConfigFile, currentUserConfigBackupFile);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(959, 2165, 2422);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 2438, 2716);

                var
                settings = new JsonSerializerSettings()
                {
                    TypeNameHandling = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => TypeNameHandling.None, 959, 2453, 2715),
                    MaxDepth = 10,
                    Formatting = Formatting.Indented,
                    NullValueHandling = NullValueHandling.Ignore
                }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 2730, 2775);

                serializer = f_959_2743_2774(settings);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 2791, 3836);

                systemWidePolicies = new PowerShellPolicies()
                {
                    ScriptExecution = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => new ScriptExecution() { ExecutionPolicy = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => "RemoteSigned", 959, 2887, 2967), EnableScripts = true }, 959, 2812, 3835),
                    ScriptBlockLogging = new ScriptBlockLogging() { EnableScriptBlockInvocationLogging = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 959, 3007, 3111), EnableScriptBlockLogging = false },
                    ModuleLogging = new ModuleLogging() { EnableModuleLogging = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => false, 959, 3146, 3259), ModuleNames = new string[] { "PSReadline", "PowerShellGet" } },
                    ProtectedEventLogging = new ProtectedEventLogging() { EnableProtectedEventLogging = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => false, 959, 3302, 3417), EncryptionCertificate = new string[] { "Joe" } },
                    Transcription = new Transcription() { EnableInvocationHeader = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 959, 3452, 3562), EnableTranscripting = true, OutputDirectory = @"c:\tmp" },
                    UpdatableHelp = new UpdatableHelp() { DefaultSourcePath = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => @"f:\temp", 959, 3597, 3651) },
                    ConsoleSessionConfiguration = new ConsoleSessionConfiguration() { EnableConsoleSessionConfiguration = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 959, 3700, 3820), ConsoleSessionConfigurationName = "name" }
                };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 3852, 4331);

                currentUserPolicies = new PowerShellPolicies()
                {
                    ScriptExecution = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => new ScriptExecution() { ExecutionPolicy = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => "RemoteSigned", 959, 3949, 4007) }, 959, 3874, 4330),
                    ScriptBlockLogging = new ScriptBlockLogging() { EnableScriptBlockLogging = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => false, 959, 4047, 4108) },
                    ModuleLogging = new ModuleLogging() { EnableModuleLogging = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => false, 959, 4143, 4194) },
                    ProtectedEventLogging = new ProtectedEventLogging() { EncryptionCertificate = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => new string[] { "Joe" }, 959, 4237, 4315) }
                };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 4407, 4474);

                originalTestHookValue = InternalTestHooks.BypassGroupPolicyCaching;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 4488, 4538);

                InternalTestHooks.BypassGroupPolicyCaching = true;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(959, 1258, 4549);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(959, 1258, 4549);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(959, 1258, 4549);
            }
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(959, 4561, 5049);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 4607, 4628);

                f_959_4607_4627(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 4642, 4789) || true) && (systemWideConfigBackupFile != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(959, 4642, 4789);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 4714, 4774);

                    f_959_4714_4773(systemWideConfigBackupFile, systemWideConfigFile);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(959, 4642, 4789);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 4805, 4955) || true) && (currentUserConfigBackupFile != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(959, 4805, 4955);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 4878, 4940);

                    f_959_4878_4939(currentUserConfigBackupFile, currentUserConfigFile);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(959, 4805, 4955);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 4971, 5038);

                InternalTestHooks.BypassGroupPolicyCaching = originalTestHookValue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(959, 4561, 5049);

                int
                f_959_4607_4627(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    this_param.CleanupConfigFiles();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 4607, 4627);
                    return 0;
                }


                int
                f_959_4714_4773(string
                sourceFileName, string
                destFileName)
                {
                    File.Move(sourceFileName, destFileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 4714, 4773);
                    return 0;
                }


                int
                f_959_4878_4939(string
                sourceFileName, string
                destFileName)
                {
                    File.Move(sourceFileName, destFileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 4878, 4939);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(959, 4561, 5049);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(959, 4561, 5049);
            }
        }

        internal PowerShellPolicies SystemWidePolicies
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(959, 5132, 5166);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 5138, 5164);

                    return systemWidePolicies;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(959, 5132, 5166);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(959, 5061, 5177);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(959, 5061, 5177);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal PowerShellPolicies CurrentUserPolicies
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(959, 5261, 5296);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 5267, 5294);

                    return currentUserPolicies;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(959, 5261, 5296);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(959, 5189, 5307);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(959, 5189, 5307);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal void CompareScriptExecution(ScriptExecution a, ScriptExecution b)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(959, 5362, 5749);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 5461, 5738) || true) && (a == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(959, 5461, 5738);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 5508, 5529);

                    f_959_5508_5528(b);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(959, 5461, 5738);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(959, 5461, 5738);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 5595, 5648);

                    f_959_5595_5647(f_959_5614_5629(a), f_959_5631_5646(b));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 5666, 5723);

                    f_959_5666_5722(f_959_5685_5702(a), f_959_5704_5721(b));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(959, 5461, 5738);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(959, 5362, 5749);

                bool
                f_959_5508_5528(System.Management.Automation.Configuration.ScriptExecution
                @object)
                {
                    var return_v = CustomAssert.Null((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 5508, 5528);
                    return return_v;
                }


                bool?
                f_959_5614_5629(System.Management.Automation.Configuration.ScriptExecution
                this_param)
                {
                    var return_v = this_param.EnableScripts;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 5614, 5629);
                    return return_v;
                }


                bool?
                f_959_5631_5646(System.Management.Automation.Configuration.ScriptExecution
                this_param)
                {
                    var return_v = this_param.EnableScripts;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 5631, 5646);
                    return return_v;
                }


                bool
                f_959_5595_5647(bool?
                expected, bool?
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 5595, 5647);
                    return return_v;
                }


                string
                f_959_5685_5702(System.Management.Automation.Configuration.ScriptExecution
                this_param)
                {
                    var return_v = this_param.ExecutionPolicy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 5685, 5702);
                    return return_v;
                }


                string
                f_959_5704_5721(System.Management.Automation.Configuration.ScriptExecution
                this_param)
                {
                    var return_v = this_param.ExecutionPolicy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 5704, 5721);
                    return return_v;
                }


                bool
                f_959_5666_5722(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 5666, 5722);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(959, 5362, 5749);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(959, 5362, 5749);
            }
        }

        internal void CompareScriptBlockLogging(ScriptBlockLogging a, ScriptBlockLogging b)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(959, 5761, 6217);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 5869, 6206) || true) && (a == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(959, 5869, 6206);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 5916, 5937);

                    f_959_5916_5936(b);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(959, 5869, 6206);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(959, 5869, 6206);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 6003, 6098);

                    f_959_6003_6097(f_959_6022_6058(a), f_959_6060_6096(b));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 6116, 6191);

                    f_959_6116_6190(f_959_6135_6161(a), f_959_6163_6189(b));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(959, 5869, 6206);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(959, 5761, 6217);

                bool
                f_959_5916_5936(System.Management.Automation.Configuration.ScriptBlockLogging
                @object)
                {
                    var return_v = CustomAssert.Null((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 5916, 5936);
                    return return_v;
                }


                bool?
                f_959_6022_6058(System.Management.Automation.Configuration.ScriptBlockLogging
                this_param)
                {
                    var return_v = this_param.EnableScriptBlockInvocationLogging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 6022, 6058);
                    return return_v;
                }


                bool?
                f_959_6060_6096(System.Management.Automation.Configuration.ScriptBlockLogging
                this_param)
                {
                    var return_v = this_param.EnableScriptBlockInvocationLogging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 6060, 6096);
                    return return_v;
                }


                bool
                f_959_6003_6097(bool?
                expected, bool?
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 6003, 6097);
                    return return_v;
                }


                bool?
                f_959_6135_6161(System.Management.Automation.Configuration.ScriptBlockLogging
                this_param)
                {
                    var return_v = this_param.EnableScriptBlockLogging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 6135, 6161);
                    return return_v;
                }


                bool?
                f_959_6163_6189(System.Management.Automation.Configuration.ScriptBlockLogging
                this_param)
                {
                    var return_v = this_param.EnableScriptBlockLogging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 6163, 6189);
                    return return_v;
                }


                bool
                f_959_6116_6190(bool?
                expected, bool?
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 6116, 6190);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(959, 5761, 6217);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(959, 5761, 6217);
            }
        }

        internal void CompareModuleLogging(ModuleLogging a, ModuleLogging b)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(959, 6229, 7024);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 6322, 7013) || true) && (a == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(959, 6322, 7013);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 6369, 6390);

                    f_959_6369_6389(b);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(959, 6322, 7013);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(959, 6322, 7013);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 6456, 6521);

                    f_959_6456_6520(f_959_6475_6496(a), f_959_6498_6519(b));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 6539, 6998) || true) && (f_959_6543_6556(a) == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(959, 6539, 6998);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 6606, 6639);

                        f_959_6606_6638(f_959_6624_6637(b));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(959, 6539, 6998);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(959, 6539, 6998);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 6721, 6784);

                        f_959_6721_6783(f_959_6740_6760(f_959_6740_6753(a)), f_959_6762_6782(f_959_6762_6775(b)));
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 6815, 6820);
                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 6806, 6979) || true) && (i < f_959_6826_6846(f_959_6826_6839(a)))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 6848, 6851)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(959, 6806, 6979))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(959, 6806, 6979);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 6901, 6956);

                                f_959_6901_6955(f_959_6920_6933(a)[i], f_959_6938_6951(b)[i]);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(959, 1, 174);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(959, 1, 174);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(959, 6539, 6998);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(959, 6322, 7013);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(959, 6229, 7024);

                bool
                f_959_6369_6389(System.Management.Automation.Configuration.ModuleLogging
                @object)
                {
                    var return_v = CustomAssert.Null((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 6369, 6389);
                    return return_v;
                }


                bool?
                f_959_6475_6496(System.Management.Automation.Configuration.ModuleLogging
                this_param)
                {
                    var return_v = this_param.EnableModuleLogging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 6475, 6496);
                    return return_v;
                }


                bool?
                f_959_6498_6519(System.Management.Automation.Configuration.ModuleLogging
                this_param)
                {
                    var return_v = this_param.EnableModuleLogging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 6498, 6519);
                    return return_v;
                }


                bool
                f_959_6456_6520(bool?
                expected, bool?
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 6456, 6520);
                    return return_v;
                }


                string[]
                f_959_6543_6556(System.Management.Automation.Configuration.ModuleLogging
                this_param)
                {
                    var return_v = this_param.ModuleNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 6543, 6556);
                    return return_v;
                }


                string[]
                f_959_6624_6637(System.Management.Automation.Configuration.ModuleLogging
                this_param)
                {
                    var return_v = this_param.ModuleNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 6624, 6637);
                    return return_v;
                }


                bool
                f_959_6606_6638(string[]
                @object)
                {
                    var return_v = CustomAssert.Null((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 6606, 6638);
                    return return_v;
                }


                string[]
                f_959_6740_6753(System.Management.Automation.Configuration.ModuleLogging
                this_param)
                {
                    var return_v = this_param.ModuleNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 6740, 6753);
                    return return_v;
                }


                int
                f_959_6740_6760(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 6740, 6760);
                    return return_v;
                }


                string[]
                f_959_6762_6775(System.Management.Automation.Configuration.ModuleLogging
                this_param)
                {
                    var return_v = this_param.ModuleNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 6762, 6775);
                    return return_v;
                }


                int
                f_959_6762_6782(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 6762, 6782);
                    return return_v;
                }


                bool
                f_959_6721_6783(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 6721, 6783);
                    return return_v;
                }


                string[]
                f_959_6826_6839(System.Management.Automation.Configuration.ModuleLogging
                this_param)
                {
                    var return_v = this_param.ModuleNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 6826, 6839);
                    return return_v;
                }


                int
                f_959_6826_6846(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 6826, 6846);
                    return return_v;
                }


                string[]
                f_959_6920_6933(System.Management.Automation.Configuration.ModuleLogging
                this_param)
                {
                    var return_v = this_param.ModuleNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 6920, 6933);
                    return return_v;
                }


                string[]
                f_959_6938_6951(System.Management.Automation.Configuration.ModuleLogging
                this_param)
                {
                    var return_v = this_param.ModuleNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 6938, 6951);
                    return return_v;
                }


                bool
                f_959_6901_6955(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 6901, 6955);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(959, 6229, 7024);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(959, 6229, 7024);
            }
        }

        internal void CompareProtectedEventLogging(ProtectedEventLogging a, ProtectedEventLogging b)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(959, 7036, 7941);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 7153, 7930) || true) && (a == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(959, 7153, 7930);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 7200, 7221);

                    f_959_7200_7220(b);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(959, 7153, 7930);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(959, 7153, 7930);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 7287, 7368);

                    f_959_7287_7367(f_959_7306_7335(a), f_959_7337_7366(b));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 7386, 7915) || true) && (f_959_7390_7413(a) == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(959, 7386, 7915);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 7463, 7506);

                        f_959_7463_7505(f_959_7481_7504(b));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(959, 7386, 7915);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(959, 7386, 7915);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 7588, 7671);

                        f_959_7588_7670(f_959_7607_7637(f_959_7607_7630(a)), f_959_7639_7669(f_959_7639_7662(b)));
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 7702, 7707);
                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 7693, 7896) || true) && (i < f_959_7713_7743(f_959_7713_7736(a)))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 7745, 7748)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(959, 7693, 7896))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(959, 7693, 7896);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 7798, 7873);

                                f_959_7798_7872(f_959_7817_7840(a)[i], f_959_7845_7868(b)[i]);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(959, 1, 204);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(959, 1, 204);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(959, 7386, 7915);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(959, 7153, 7930);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(959, 7036, 7941);

                bool
                f_959_7200_7220(System.Management.Automation.Configuration.ProtectedEventLogging
                @object)
                {
                    var return_v = CustomAssert.Null((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 7200, 7220);
                    return return_v;
                }


                bool?
                f_959_7306_7335(System.Management.Automation.Configuration.ProtectedEventLogging
                this_param)
                {
                    var return_v = this_param.EnableProtectedEventLogging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 7306, 7335);
                    return return_v;
                }


                bool?
                f_959_7337_7366(System.Management.Automation.Configuration.ProtectedEventLogging
                this_param)
                {
                    var return_v = this_param.EnableProtectedEventLogging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 7337, 7366);
                    return return_v;
                }


                bool
                f_959_7287_7367(bool?
                expected, bool?
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 7287, 7367);
                    return return_v;
                }


                string[]
                f_959_7390_7413(System.Management.Automation.Configuration.ProtectedEventLogging
                this_param)
                {
                    var return_v = this_param.EncryptionCertificate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 7390, 7413);
                    return return_v;
                }


                string[]
                f_959_7481_7504(System.Management.Automation.Configuration.ProtectedEventLogging
                this_param)
                {
                    var return_v = this_param.EncryptionCertificate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 7481, 7504);
                    return return_v;
                }


                bool
                f_959_7463_7505(string[]
                @object)
                {
                    var return_v = CustomAssert.Null((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 7463, 7505);
                    return return_v;
                }


                string[]
                f_959_7607_7630(System.Management.Automation.Configuration.ProtectedEventLogging
                this_param)
                {
                    var return_v = this_param.EncryptionCertificate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 7607, 7630);
                    return return_v;
                }


                int
                f_959_7607_7637(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 7607, 7637);
                    return return_v;
                }


                string[]
                f_959_7639_7662(System.Management.Automation.Configuration.ProtectedEventLogging
                this_param)
                {
                    var return_v = this_param.EncryptionCertificate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 7639, 7662);
                    return return_v;
                }


                int
                f_959_7639_7669(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 7639, 7669);
                    return return_v;
                }


                bool
                f_959_7588_7670(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 7588, 7670);
                    return return_v;
                }


                string[]
                f_959_7713_7736(System.Management.Automation.Configuration.ProtectedEventLogging
                this_param)
                {
                    var return_v = this_param.EncryptionCertificate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 7713, 7736);
                    return return_v;
                }


                int
                f_959_7713_7743(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 7713, 7743);
                    return return_v;
                }


                string[]
                f_959_7817_7840(System.Management.Automation.Configuration.ProtectedEventLogging
                this_param)
                {
                    var return_v = this_param.EncryptionCertificate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 7817, 7840);
                    return return_v;
                }


                string[]
                f_959_7845_7868(System.Management.Automation.Configuration.ProtectedEventLogging
                this_param)
                {
                    var return_v = this_param.EncryptionCertificate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 7845, 7868);
                    return return_v;
                }


                bool
                f_959_7798_7872(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 7798, 7872);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(959, 7036, 7941);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(959, 7036, 7941);
            }
        }

        internal void CompareTranscription(Transcription a, Transcription b)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(959, 7953, 8435);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 8046, 8424) || true) && (a == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(959, 8046, 8424);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 8093, 8114);

                    f_959_8093_8113(b);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(959, 8046, 8424);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(959, 8046, 8424);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 8180, 8245);

                    f_959_8180_8244(f_959_8199_8220(a), f_959_8222_8243(b));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 8263, 8334);

                    f_959_8263_8333(f_959_8282_8306(a), f_959_8308_8332(b));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 8352, 8409);

                    f_959_8352_8408(f_959_8371_8388(a), f_959_8390_8407(b));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(959, 8046, 8424);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(959, 7953, 8435);

                bool
                f_959_8093_8113(System.Management.Automation.Configuration.Transcription
                @object)
                {
                    var return_v = CustomAssert.Null((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 8093, 8113);
                    return return_v;
                }


                bool?
                f_959_8199_8220(System.Management.Automation.Configuration.Transcription
                this_param)
                {
                    var return_v = this_param.EnableTranscripting;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 8199, 8220);
                    return return_v;
                }


                bool?
                f_959_8222_8243(System.Management.Automation.Configuration.Transcription
                this_param)
                {
                    var return_v = this_param.EnableTranscripting;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 8222, 8243);
                    return return_v;
                }


                bool
                f_959_8180_8244(bool?
                expected, bool?
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 8180, 8244);
                    return return_v;
                }


                bool?
                f_959_8282_8306(System.Management.Automation.Configuration.Transcription
                this_param)
                {
                    var return_v = this_param.EnableInvocationHeader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 8282, 8306);
                    return return_v;
                }


                bool?
                f_959_8308_8332(System.Management.Automation.Configuration.Transcription
                this_param)
                {
                    var return_v = this_param.EnableInvocationHeader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 8308, 8332);
                    return return_v;
                }


                bool
                f_959_8263_8333(bool?
                expected, bool?
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 8263, 8333);
                    return return_v;
                }


                string
                f_959_8371_8388(System.Management.Automation.Configuration.Transcription
                this_param)
                {
                    var return_v = this_param.OutputDirectory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 8371, 8388);
                    return return_v;
                }


                string
                f_959_8390_8407(System.Management.Automation.Configuration.Transcription
                this_param)
                {
                    var return_v = this_param.OutputDirectory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 8390, 8407);
                    return return_v;
                }


                bool
                f_959_8352_8408(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 8352, 8408);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(959, 7953, 8435);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(959, 7953, 8435);
            }
        }

        internal void CompareUpdatableHelp(UpdatableHelp a, UpdatableHelp b)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(959, 8447, 8761);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 8540, 8750) || true) && (a == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(959, 8540, 8750);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 8587, 8608);

                    f_959_8587_8607(b);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(959, 8540, 8750);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(959, 8540, 8750);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 8674, 8735);

                    f_959_8674_8734(f_959_8693_8712(a), f_959_8714_8733(b));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(959, 8540, 8750);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(959, 8447, 8761);

                bool
                f_959_8587_8607(System.Management.Automation.Configuration.UpdatableHelp
                @object)
                {
                    var return_v = CustomAssert.Null((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 8587, 8607);
                    return return_v;
                }


                string
                f_959_8693_8712(System.Management.Automation.Configuration.UpdatableHelp
                this_param)
                {
                    var return_v = this_param.DefaultSourcePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 8693, 8712);
                    return return_v;
                }


                string
                f_959_8714_8733(System.Management.Automation.Configuration.UpdatableHelp
                this_param)
                {
                    var return_v = this_param.DefaultSourcePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 8714, 8733);
                    return return_v;
                }


                bool
                f_959_8674_8734(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 8674, 8734);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(959, 8447, 8761);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(959, 8447, 8761);
            }
        }

        internal void CompareConsoleSessionConfiguration(ConsoleSessionConfiguration a, ConsoleSessionConfiguration b)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(959, 8773, 9268);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 8908, 9257) || true) && (a == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(959, 8908, 9257);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 8955, 8976);

                    f_959_8955_8975(b);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(959, 8908, 9257);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(959, 8908, 9257);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 9042, 9135);

                    f_959_9042_9134(f_959_9061_9096(a), f_959_9098_9133(b));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 9153, 9242);

                    f_959_9153_9241(f_959_9172_9205(a), f_959_9207_9240(b));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(959, 8908, 9257);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(959, 8773, 9268);

                bool
                f_959_8955_8975(System.Management.Automation.Configuration.ConsoleSessionConfiguration
                @object)
                {
                    var return_v = CustomAssert.Null((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 8955, 8975);
                    return return_v;
                }


                bool?
                f_959_9061_9096(System.Management.Automation.Configuration.ConsoleSessionConfiguration
                this_param)
                {
                    var return_v = this_param.EnableConsoleSessionConfiguration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 9061, 9096);
                    return return_v;
                }


                bool?
                f_959_9098_9133(System.Management.Automation.Configuration.ConsoleSessionConfiguration
                this_param)
                {
                    var return_v = this_param.EnableConsoleSessionConfiguration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 9098, 9133);
                    return return_v;
                }


                bool
                f_959_9042_9134(bool?
                expected, bool?
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 9042, 9134);
                    return return_v;
                }


                string
                f_959_9172_9205(System.Management.Automation.Configuration.ConsoleSessionConfiguration
                this_param)
                {
                    var return_v = this_param.ConsoleSessionConfigurationName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 9172, 9205);
                    return return_v;
                }


                string
                f_959_9207_9240(System.Management.Automation.Configuration.ConsoleSessionConfiguration
                this_param)
                {
                    var return_v = this_param.ConsoleSessionConfigurationName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 9207, 9240);
                    return return_v;
                }


                bool
                f_959_9153_9241(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 9153, 9241);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(959, 8773, 9268);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(959, 8773, 9268);
            }
        }

        internal void CompareTwoPolicies(PowerShellPolicies a, PowerShellPolicies b)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(959, 9280, 10332);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 9432, 9493);

                f_959_9432_9492(this, f_959_9455_9472(a), f_959_9474_9491(b));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 9563, 9633);

                f_959_9563_9632(this, f_959_9589_9609(a), f_959_9611_9631(b));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 9698, 9753);

                f_959_9698_9752(this, f_959_9719_9734(a), f_959_9736_9751(b));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 9826, 9905);

                f_959_9826_9904(this, f_959_9855_9878(a), f_959_9880_9903(b));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 9970, 10025);

                f_959_9970_10024(this, f_959_9991_10006(a), f_959_10008_10023(b));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 10090, 10145);

                f_959_10090_10144(this, f_959_10111_10126(a), f_959_10128_10143(b));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 10224, 10321);

                f_959_10224_10320(this, f_959_10259_10288(a), f_959_10290_10319(b));
                DynAbs.Tracing.TraceSender.TraceExitMethod(959, 9280, 10332);

                System.Management.Automation.Configuration.ScriptExecution
                f_959_9455_9472(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ScriptExecution;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 9455, 9472);
                    return return_v;
                }


                System.Management.Automation.Configuration.ScriptExecution
                f_959_9474_9491(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ScriptExecution;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 9474, 9491);
                    return return_v;
                }


                int
                f_959_9432_9492(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ScriptExecution
                a, System.Management.Automation.Configuration.ScriptExecution
                b)
                {
                    this_param.CompareScriptExecution(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 9432, 9492);
                    return 0;
                }


                System.Management.Automation.Configuration.ScriptBlockLogging
                f_959_9589_9609(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ScriptBlockLogging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 9589, 9609);
                    return return_v;
                }


                System.Management.Automation.Configuration.ScriptBlockLogging
                f_959_9611_9631(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ScriptBlockLogging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 9611, 9631);
                    return return_v;
                }


                int
                f_959_9563_9632(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ScriptBlockLogging
                a, System.Management.Automation.Configuration.ScriptBlockLogging
                b)
                {
                    this_param.CompareScriptBlockLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 9563, 9632);
                    return 0;
                }


                System.Management.Automation.Configuration.ModuleLogging
                f_959_9719_9734(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ModuleLogging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 9719, 9734);
                    return return_v;
                }


                System.Management.Automation.Configuration.ModuleLogging
                f_959_9736_9751(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ModuleLogging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 9736, 9751);
                    return return_v;
                }


                int
                f_959_9698_9752(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ModuleLogging
                a, System.Management.Automation.Configuration.ModuleLogging
                b)
                {
                    this_param.CompareModuleLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 9698, 9752);
                    return 0;
                }


                System.Management.Automation.Configuration.ProtectedEventLogging
                f_959_9855_9878(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ProtectedEventLogging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 9855, 9878);
                    return return_v;
                }


                System.Management.Automation.Configuration.ProtectedEventLogging
                f_959_9880_9903(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ProtectedEventLogging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 9880, 9903);
                    return return_v;
                }


                int
                f_959_9826_9904(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ProtectedEventLogging
                a, System.Management.Automation.Configuration.ProtectedEventLogging
                b)
                {
                    this_param.CompareProtectedEventLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 9826, 9904);
                    return 0;
                }


                System.Management.Automation.Configuration.Transcription
                f_959_9991_10006(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.Transcription;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 9991, 10006);
                    return return_v;
                }


                System.Management.Automation.Configuration.Transcription
                f_959_10008_10023(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.Transcription;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 10008, 10023);
                    return return_v;
                }


                int
                f_959_9970_10024(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.Transcription
                a, System.Management.Automation.Configuration.Transcription
                b)
                {
                    this_param.CompareTranscription(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 9970, 10024);
                    return 0;
                }


                System.Management.Automation.Configuration.UpdatableHelp
                f_959_10111_10126(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.UpdatableHelp;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 10111, 10126);
                    return return_v;
                }


                System.Management.Automation.Configuration.UpdatableHelp
                f_959_10128_10143(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.UpdatableHelp;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 10128, 10143);
                    return return_v;
                }


                int
                f_959_10090_10144(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.UpdatableHelp
                a, System.Management.Automation.Configuration.UpdatableHelp
                b)
                {
                    this_param.CompareUpdatableHelp(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 10090, 10144);
                    return 0;
                }


                System.Management.Automation.Configuration.ConsoleSessionConfiguration
                f_959_10259_10288(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ConsoleSessionConfiguration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 10259, 10288);
                    return return_v;
                }


                System.Management.Automation.Configuration.ConsoleSessionConfiguration
                f_959_10290_10319(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ConsoleSessionConfiguration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 10290, 10319);
                    return return_v;
                }


                int
                f_959_10224_10320(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ConsoleSessionConfiguration
                a, System.Management.Automation.Configuration.ConsoleSessionConfiguration
                b)
                {
                    this_param.CompareConsoleSessionConfiguration(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 10224, 10320);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(959, 9280, 10332);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(959, 9280, 10332);
            }
        }

        public void CleanupConfigFiles()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(959, 10410, 11239);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 10467, 10485);

                var
                maxPause = 10
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 10501, 11228) || true) && (maxPause-- != 0 && (DynAbs.Tracing.TraceSender.Expression_True(959, 10508, 10600) && (f_959_10528_10561(systemWideConfigFile) || (DynAbs.Tracing.TraceSender.Expression_False(959, 10528, 10599) || f_959_10565_10599(currentUserConfigFile)))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(959, 10501, 11228);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 10634, 10652);

                        var
                        pause = false
                        ;

                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 10716, 10750);

                            f_959_10716_10749(systemWideConfigFile);
                        }
                        catch (IOException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(959, 10787, 10879);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 10847, 10860);

                            pause = true;
                            DynAbs.Tracing.TraceSender.TraceExitCatch(959, 10787, 10879);
                        }

                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 10943, 10978);

                            f_959_10943_10977(currentUserConfigFile);
                        }
                        catch (IOException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(959, 11015, 11107);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 11075, 11088);

                            pause = true;
                            DynAbs.Tracing.TraceSender.TraceExitCatch(959, 11015, 11107);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 11127, 11213) || true) && (pause)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(959, 11127, 11213);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 11178, 11194);

                            f_959_11178_11193(5);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(959, 11127, 11213);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(959, 10501, 11228);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(959, 10501, 11228);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(959, 10501, 11228);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(959, 10410, 11239);

                bool
                f_959_10528_10561(string
                path)
                {
                    var return_v = File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 10528, 10561);
                    return return_v;
                }


                bool
                f_959_10565_10599(string
                path)
                {
                    var return_v = File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 10565, 10599);
                    return return_v;
                }


                int
                f_959_10716_10749(string
                path)
                {
                    File.Delete(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 10716, 10749);
                    return 0;
                }


                int
                f_959_10943_10977(string
                path)
                {
                    File.Delete(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 10943, 10977);
                    return 0;
                }


                int
                f_959_11178_11193(int
                millisecondsTimeout)
                {
                    Thread.Sleep(millisecondsTimeout);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 11178, 11193);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(959, 10410, 11239);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(959, 10410, 11239);
            }
        }

        public void SetupConfigFile1()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(959, 11251, 12069);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 11306, 11327);

                f_959_11306_11326(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 11407, 11503);

                var
                systemWideConfig = new { ConsolePrompting = true, PowerShellPolicies = systemWidePolicies }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 11517, 11683);
                using (var
                streamWriter = f_959_11543_11581(systemWideConfigFile)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 11615, 11668);

                    f_959_11615_11667(serializer, streamWriter, systemWideConfig);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(959, 11517, 11683);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 11768, 11876);

                var
                currentUserConfig = new { DisablePromptToUpdateHelp = false, PowerShellPolicies = currentUserPolicies }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 11890, 12058);
                using (var
                streamWriter = f_959_11916_11955(currentUserConfigFile)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 11989, 12043);

                    f_959_11989_12042(serializer, streamWriter, currentUserConfig);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(959, 11890, 12058);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(959, 11251, 12069);

                int
                f_959_11306_11326(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    this_param.CleanupConfigFiles();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 11306, 11326);
                    return 0;
                }


                System.IO.StreamWriter
                f_959_11543_11581(string
                path)
                {
                    var return_v = new System.IO.StreamWriter(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 11543, 11581);
                    return return_v;
                }


                int
                f_959_11615_11667(Newtonsoft.Json.JsonSerializer
                this_param, System.IO.StreamWriter
                textWriter, dynamic
                value)
                {
                    this_param.Serialize((System.IO.TextWriter)textWriter, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 11615, 11667);
                    return 0;
                }


                System.IO.StreamWriter
                f_959_11916_11955(string
                path)
                {
                    var return_v = new System.IO.StreamWriter(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 11916, 11955);
                    return return_v;
                }


                int
                f_959_11989_12042(Newtonsoft.Json.JsonSerializer
                this_param, System.IO.StreamWriter
                textWriter, dynamic
                value)
                {
                    this_param.Serialize((System.IO.TextWriter)textWriter, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 11989, 12042);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(959, 11251, 12069);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(959, 11251, 12069);
            }
        }

        public void SetupConfigFile2()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(959, 12081, 12629);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 12136, 12157);

                f_959_12136_12156(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 12237, 12333);

                var
                systemWideConfig = new { ConsolePrompting = true, PowerShellPolicies = systemWidePolicies }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 12347, 12513);
                using (var
                streamWriter = f_959_12373_12411(systemWideConfigFile)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 12445, 12498);

                    f_959_12445_12497(serializer, streamWriter, systemWideConfig);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(959, 12347, 12513);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 12579, 12618);

                f_959_12579_12617(this, currentUserConfigFile);
                DynAbs.Tracing.TraceSender.TraceExitMethod(959, 12081, 12629);

                int
                f_959_12136_12156(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    this_param.CleanupConfigFiles();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 12136, 12156);
                    return 0;
                }


                System.IO.StreamWriter
                f_959_12373_12411(string
                path)
                {
                    var return_v = new System.IO.StreamWriter(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 12373, 12411);
                    return return_v;
                }


                int
                f_959_12445_12497(Newtonsoft.Json.JsonSerializer
                this_param, System.IO.StreamWriter
                textWriter, dynamic
                value)
                {
                    this_param.Serialize((System.IO.TextWriter)textWriter, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 12445, 12497);
                    return 0;
                }


                int
                f_959_12579_12617(PSTests.Sequential.PowerShellPolicyFixture
                this_param, string
                fileName)
                {
                    this_param.CreateEmptyFile(fileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 12579, 12617);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(959, 12081, 12629);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(959, 12081, 12629);
            }
        }

        public void SetupConfigFile3()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(959, 12641, 13206);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 12696, 12717);

                f_959_12696_12716(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 12782, 12820);

                f_959_12782_12819(this, systemWideConfigFile);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 12905, 13013);

                var
                currentUserConfig = new { DisablePromptToUpdateHelp = false, PowerShellPolicies = currentUserPolicies }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 13027, 13195);
                using (var
                streamWriter = f_959_13053_13092(currentUserConfigFile)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 13126, 13180);

                    f_959_13126_13179(serializer, streamWriter, currentUserConfig);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(959, 13027, 13195);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(959, 12641, 13206);

                int
                f_959_12696_12716(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    this_param.CleanupConfigFiles();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 12696, 12716);
                    return 0;
                }


                int
                f_959_12782_12819(PSTests.Sequential.PowerShellPolicyFixture
                this_param, string
                fileName)
                {
                    this_param.CreateEmptyFile(fileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 12782, 12819);
                    return 0;
                }


                System.IO.StreamWriter
                f_959_13053_13092(string
                path)
                {
                    var return_v = new System.IO.StreamWriter(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 13053, 13092);
                    return return_v;
                }


                int
                f_959_13126_13179(Newtonsoft.Json.JsonSerializer
                this_param, System.IO.StreamWriter
                textWriter, dynamic
                value)
                {
                    this_param.Serialize((System.IO.TextWriter)textWriter, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 13126, 13179);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(959, 12641, 13206);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(959, 12641, 13206);
            }
        }

        public void SetupConfigFile4()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(959, 13218, 13513);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 13273, 13294);

                f_959_13273_13293(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 13359, 13397);

                f_959_13359_13396(this, systemWideConfigFile);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 13463, 13502);

                f_959_13463_13501(this, currentUserConfigFile);
                DynAbs.Tracing.TraceSender.TraceExitMethod(959, 13218, 13513);

                int
                f_959_13273_13293(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    this_param.CleanupConfigFiles();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 13273, 13293);
                    return 0;
                }


                int
                f_959_13359_13396(PSTests.Sequential.PowerShellPolicyFixture
                this_param, string
                fileName)
                {
                    this_param.CreateEmptyFile(fileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 13359, 13396);
                    return 0;
                }


                int
                f_959_13463_13501(PSTests.Sequential.PowerShellPolicyFixture
                this_param, string
                fileName)
                {
                    this_param.CreateEmptyFile(fileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 13463, 13501);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(959, 13218, 13513);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(959, 13218, 13513);
            }
        }

        private void CreateEmptyFile(string fileName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(959, 13525, 13638);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 13595, 13627);

                f_959_13595_13626(f_959_13595_13616(fileName));
                DynAbs.Tracing.TraceSender.TraceExitMethod(959, 13525, 13638);

                System.IO.FileStream
                f_959_13595_13616(string
                path)
                {
                    var return_v = File.Create(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 13595, 13616);
                    return return_v;
                }


                int
                f_959_13595_13626(System.IO.FileStream
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 13595, 13626);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(959, 13525, 13638);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(959, 13525, 13638);
            }
        }

        internal void ForceReadingFromFile()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(959, 13650, 14022);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 13751, 13866);

                FieldInfo
                roots = f_959_13769_13865(typeof(PowerShellConfig), "configRoots", BindingFlags.NonPublic | BindingFlags.Instance)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 13880, 13951);

                JObject[]
                value = (JObject[])f_959_13909_13950(roots, PowerShellConfig.Instance)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 13965, 13981);

                value[0] = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 13995, 14011);

                value[1] = null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(959, 13650, 14022);

                System.Reflection.FieldInfo?
                f_959_13769_13865(System.Type
                this_param, string
                name, System.Reflection.BindingFlags
                bindingAttr)
                {
                    var return_v = this_param.GetField(name, bindingAttr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 13769, 13865);
                    return return_v;
                }


                object?
                f_959_13909_13950(System.Reflection.FieldInfo
                this_param, System.Management.Automation.Configuration.PowerShellConfig
                obj)
                {
                    var return_v = this_param.GetValue((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 13909, 13950);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(959, 13650, 14022);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(959, 13650, 14022);
            }
        }

        static PowerShellPolicyFixture()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(959, 424, 14051);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 601, 642);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(959, 424, 14051);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(959, 424, 14051);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(959, 424, 14051);

        static string
        f_959_1343_1373()
        {
            var return_v = Utils.DefaultPowerShellAppBase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 1343, 1373);
            return return_v;
        }


        static bool
        f_959_1463_1507(string
        path)
        {
            var return_v = Directory.Exists(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 1463, 1507);
            return return_v;
        }


        static System.IO.DirectoryInfo
        f_959_1621_1674(string
        path)
        {
            var return_v = Directory.CreateDirectory(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 1621, 1674);
            return return_v;
        }


        static string
        f_959_1729_1784(string
        path1, string
        path2)
        {
            var return_v = Path.Combine(path1, path2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 1729, 1784);
            return return_v;
        }


        static string
        f_959_1823_1879(string
        path1, string
        path2)
        {
            var return_v = Path.Combine(path1, path2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 1823, 1879);
            return return_v;
        }


        static bool
        f_959_1900_1933(string
        path)
        {
            var return_v = File.Exists(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 1900, 1933);
            return return_v;
        }


        static string
        f_959_2009_2027()
        {
            var return_v = Path.GetTempPath();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 2009, 2027);
            return return_v;
        }


        static string
        f_959_1996_2055(string
        path1, string
        path2)
        {
            var return_v = Path.Combine(path1, path2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 1996, 2055);
            return return_v;
        }


        static int
        f_959_2074_2133(string
        sourceFileName, string
        destFileName)
        {
            File.Move(sourceFileName, destFileName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 2074, 2133);
            return 0;
        }


        static bool
        f_959_2169_2203(string
        path)
        {
            var return_v = File.Exists(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 2169, 2203);
            return return_v;
        }


        static string
        f_959_2280_2298()
        {
            var return_v = Path.GetTempPath();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 2280, 2298);
            return return_v;
        }


        static string
        f_959_2267_2326(string
        path1, string
        path2)
        {
            var return_v = Path.Combine(path1, path2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 2267, 2326);
            return return_v;
        }


        static int
        f_959_2345_2406(string
        sourceFileName, string
        destFileName)
        {
            File.Move(sourceFileName, destFileName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 2345, 2406);
            return 0;
        }


        static Newtonsoft.Json.JsonSerializer
        f_959_2743_2774(Newtonsoft.Json.JsonSerializerSettings
        settings)
        {
            var return_v = JsonSerializer.Create(settings);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 2743, 2774);
            return return_v;
        }

    }
    public class PowerShellPolicyTests : IClassFixture<PowerShellPolicyFixture>
    {
        private PowerShellPolicyFixture fixture;

        public PowerShellPolicyTests(PowerShellPolicyFixture fixture)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(959, 14203, 14323);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 14183, 14190);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 14289, 14312);

                this.fixture = fixture;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(959, 14203, 14323);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(959, 14203, 14323);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(959, 14203, 14323);
            }
        }

        [Fact, TestPriority(1)]
        public void PowerShellConfig_GetPowerShellPolicies_BothConfigFilesNotEmpty()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(959, 14335, 15029);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 14469, 14496);

                f_959_14469_14495(fixture);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 14510, 14541);

                f_959_14510_14540(fixture);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 14557, 14645);

                var
                sysPolicies = f_959_14575_14644(PowerShellConfig.Instance, ConfigScope.AllUsers)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 14659, 14751);

                var
                userPolicies = f_959_14678_14750(PowerShellConfig.Instance, ConfigScope.CurrentUser)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 14767, 14801);

                f_959_14767_14800(sysPolicies);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 14815, 14850);

                f_959_14815_14849(userPolicies);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 14866, 14934);

                f_959_14866_14933(
                            fixture, sysPolicies, f_959_14906_14932(fixture));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 14948, 15018);

                f_959_14948_15017(fixture, userPolicies, f_959_14989_15016(fixture));
                DynAbs.Tracing.TraceSender.TraceExitMethod(959, 14335, 15029);

                int
                f_959_14469_14495(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    this_param.SetupConfigFile1();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 14469, 14495);
                    return 0;
                }


                int
                f_959_14510_14540(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    this_param.ForceReadingFromFile();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 14510, 14540);
                    return 0;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_14575_14644(System.Management.Automation.Configuration.PowerShellConfig
                this_param, System.Management.Automation.Configuration.ConfigScope
                scope)
                {
                    var return_v = this_param.GetPowerShellPolicies(scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 14575, 14644);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_14678_14750(System.Management.Automation.Configuration.PowerShellConfig
                this_param, System.Management.Automation.Configuration.ConfigScope
                scope)
                {
                    var return_v = this_param.GetPowerShellPolicies(scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 14678, 14750);
                    return return_v;
                }


                bool
                f_959_14767_14800(System.Management.Automation.Configuration.PowerShellPolicies
                @object)
                {
                    var return_v = CustomAssert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 14767, 14800);
                    return return_v;
                }


                bool
                f_959_14815_14849(System.Management.Automation.Configuration.PowerShellPolicies
                @object)
                {
                    var return_v = CustomAssert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 14815, 14849);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_14906_14932(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.SystemWidePolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 14906, 14932);
                    return return_v;
                }


                int
                f_959_14866_14933(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.PowerShellPolicies
                a, System.Management.Automation.Configuration.PowerShellPolicies
                b)
                {
                    this_param.CompareTwoPolicies(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 14866, 14933);
                    return 0;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_14989_15016(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.CurrentUserPolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 14989, 15016);
                    return return_v;
                }


                int
                f_959_14948_15017(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.PowerShellPolicies
                a, System.Management.Automation.Configuration.PowerShellPolicies
                b)
                {
                    this_param.CompareTwoPolicies(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 14948, 15017);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(959, 14335, 15029);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(959, 14335, 15029);
            }
        }

        [Fact, TestPriority(2)]
        public void PowerShellConfig_GetPowerShellPolicies_EmptyUserConfig()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(959, 15041, 15640);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 15167, 15194);

                f_959_15167_15193(fixture);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 15208, 15239);

                f_959_15208_15238(fixture);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 15255, 15343);

                var
                sysPolicies = f_959_15273_15342(PowerShellConfig.Instance, ConfigScope.AllUsers)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 15357, 15449);

                var
                userPolicies = f_959_15376_15448(PowerShellConfig.Instance, ConfigScope.CurrentUser)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 15465, 15499);

                f_959_15465_15498(sysPolicies);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 15513, 15545);

                f_959_15513_15544(userPolicies);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 15561, 15629);

                f_959_15561_15628(
                            fixture, sysPolicies, f_959_15601_15627(fixture));
                DynAbs.Tracing.TraceSender.TraceExitMethod(959, 15041, 15640);

                int
                f_959_15167_15193(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    this_param.SetupConfigFile2();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 15167, 15193);
                    return 0;
                }


                int
                f_959_15208_15238(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    this_param.ForceReadingFromFile();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 15208, 15238);
                    return 0;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_15273_15342(System.Management.Automation.Configuration.PowerShellConfig
                this_param, System.Management.Automation.Configuration.ConfigScope
                scope)
                {
                    var return_v = this_param.GetPowerShellPolicies(scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 15273, 15342);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_15376_15448(System.Management.Automation.Configuration.PowerShellConfig
                this_param, System.Management.Automation.Configuration.ConfigScope
                scope)
                {
                    var return_v = this_param.GetPowerShellPolicies(scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 15376, 15448);
                    return return_v;
                }


                bool
                f_959_15465_15498(System.Management.Automation.Configuration.PowerShellPolicies
                @object)
                {
                    var return_v = CustomAssert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 15465, 15498);
                    return return_v;
                }


                bool
                f_959_15513_15544(System.Management.Automation.Configuration.PowerShellPolicies
                @object)
                {
                    var return_v = CustomAssert.Null((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 15513, 15544);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_15601_15627(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.SystemWidePolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 15601, 15627);
                    return return_v;
                }


                int
                f_959_15561_15628(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.PowerShellPolicies
                a, System.Management.Automation.Configuration.PowerShellPolicies
                b)
                {
                    this_param.CompareTwoPolicies(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 15561, 15628);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(959, 15041, 15640);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(959, 15041, 15640);
            }
        }

        [Fact, TestPriority(3)]
        public void PowerShellConfig_GetPowerShellPolicies_EmptySystemConfig()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(959, 15652, 16255);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 15780, 15807);

                f_959_15780_15806(fixture);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 15821, 15852);

                f_959_15821_15851(fixture);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 15868, 15956);

                var
                sysPolicies = f_959_15886_15955(PowerShellConfig.Instance, ConfigScope.AllUsers)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 15970, 16062);

                var
                userPolicies = f_959_15989_16061(PowerShellConfig.Instance, ConfigScope.CurrentUser)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 16078, 16109);

                f_959_16078_16108(sysPolicies);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 16123, 16158);

                f_959_16123_16157(userPolicies);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 16174, 16244);

                f_959_16174_16243(
                            fixture, userPolicies, f_959_16215_16242(fixture));
                DynAbs.Tracing.TraceSender.TraceExitMethod(959, 15652, 16255);

                int
                f_959_15780_15806(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    this_param.SetupConfigFile3();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 15780, 15806);
                    return 0;
                }


                int
                f_959_15821_15851(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    this_param.ForceReadingFromFile();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 15821, 15851);
                    return 0;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_15886_15955(System.Management.Automation.Configuration.PowerShellConfig
                this_param, System.Management.Automation.Configuration.ConfigScope
                scope)
                {
                    var return_v = this_param.GetPowerShellPolicies(scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 15886, 15955);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_15989_16061(System.Management.Automation.Configuration.PowerShellConfig
                this_param, System.Management.Automation.Configuration.ConfigScope
                scope)
                {
                    var return_v = this_param.GetPowerShellPolicies(scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 15989, 16061);
                    return return_v;
                }


                bool
                f_959_16078_16108(System.Management.Automation.Configuration.PowerShellPolicies
                @object)
                {
                    var return_v = CustomAssert.Null((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 16078, 16108);
                    return return_v;
                }


                bool
                f_959_16123_16157(System.Management.Automation.Configuration.PowerShellPolicies
                @object)
                {
                    var return_v = CustomAssert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 16123, 16157);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_16215_16242(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.CurrentUserPolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 16215, 16242);
                    return return_v;
                }


                int
                f_959_16174_16243(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.PowerShellPolicies
                a, System.Management.Automation.Configuration.PowerShellPolicies
                b)
                {
                    this_param.CompareTwoPolicies(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 16174, 16243);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(959, 15652, 16255);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(959, 15652, 16255);
            }
        }

        [Fact, TestPriority(4)]
        public void PowerShellConfig_GetPowerShellPolicies_BothConfigFilesEmpty()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(959, 16267, 16784);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 16398, 16425);

                f_959_16398_16424(fixture);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 16439, 16470);

                f_959_16439_16469(fixture);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 16486, 16574);

                var
                sysPolicies = f_959_16504_16573(PowerShellConfig.Instance, ConfigScope.AllUsers)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 16588, 16680);

                var
                userPolicies = f_959_16607_16679(PowerShellConfig.Instance, ConfigScope.CurrentUser)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 16696, 16727);

                f_959_16696_16726(sysPolicies);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 16741, 16773);

                f_959_16741_16772(userPolicies);
                DynAbs.Tracing.TraceSender.TraceExitMethod(959, 16267, 16784);

                int
                f_959_16398_16424(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    this_param.SetupConfigFile4();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 16398, 16424);
                    return 0;
                }


                int
                f_959_16439_16469(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    this_param.ForceReadingFromFile();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 16439, 16469);
                    return 0;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_16504_16573(System.Management.Automation.Configuration.PowerShellConfig
                this_param, System.Management.Automation.Configuration.ConfigScope
                scope)
                {
                    var return_v = this_param.GetPowerShellPolicies(scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 16504, 16573);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_16607_16679(System.Management.Automation.Configuration.PowerShellConfig
                this_param, System.Management.Automation.Configuration.ConfigScope
                scope)
                {
                    var return_v = this_param.GetPowerShellPolicies(scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 16607, 16679);
                    return return_v;
                }


                bool
                f_959_16696_16726(System.Management.Automation.Configuration.PowerShellPolicies
                @object)
                {
                    var return_v = CustomAssert.Null((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 16696, 16726);
                    return return_v;
                }


                bool
                f_959_16741_16772(System.Management.Automation.Configuration.PowerShellPolicies
                @object)
                {
                    var return_v = CustomAssert.Null((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 16741, 16772);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(959, 16267, 16784);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(959, 16267, 16784);
            }
        }

        [Fact, TestPriority(5)]
        public void PowerShellConfig_GetPowerShellPolicies_BothConfigFilesNotExist()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(959, 16796, 17318);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 16930, 16959);

                f_959_16930_16958(fixture);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 16973, 17004);

                f_959_16973_17003(fixture);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 17020, 17108);

                var
                sysPolicies = f_959_17038_17107(PowerShellConfig.Instance, ConfigScope.AllUsers)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 17122, 17214);

                var
                userPolicies = f_959_17141_17213(PowerShellConfig.Instance, ConfigScope.CurrentUser)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 17230, 17261);

                f_959_17230_17260(sysPolicies);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 17275, 17307);

                f_959_17275_17306(userPolicies);
                DynAbs.Tracing.TraceSender.TraceExitMethod(959, 16796, 17318);

                int
                f_959_16930_16958(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    this_param.CleanupConfigFiles();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 16930, 16958);
                    return 0;
                }


                int
                f_959_16973_17003(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    this_param.ForceReadingFromFile();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 16973, 17003);
                    return 0;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_17038_17107(System.Management.Automation.Configuration.PowerShellConfig
                this_param, System.Management.Automation.Configuration.ConfigScope
                scope)
                {
                    var return_v = this_param.GetPowerShellPolicies(scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 17038, 17107);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_17141_17213(System.Management.Automation.Configuration.PowerShellConfig
                this_param, System.Management.Automation.Configuration.ConfigScope
                scope)
                {
                    var return_v = this_param.GetPowerShellPolicies(scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 17141, 17213);
                    return return_v;
                }


                bool
                f_959_17230_17260(System.Management.Automation.Configuration.PowerShellPolicies
                @object)
                {
                    var return_v = CustomAssert.Null((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 17230, 17260);
                    return return_v;
                }


                bool
                f_959_17275_17306(System.Management.Automation.Configuration.PowerShellPolicies
                @object)
                {
                    var return_v = CustomAssert.Null((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 17275, 17306);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(959, 16796, 17318);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(959, 16796, 17318);
            }
        }

        [Fact, TestPriority(6)]
        public void Utils_GetPolicySetting_BothConfigFilesNotEmpty()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(959, 17330, 24193);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 17448, 17475);

                f_959_17448_17474(fixture);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 17489, 17520);

                f_959_17489_17519(fixture);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 17536, 17568);

                ScriptExecution
                scriptExecution
                = default(ScriptExecution);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 17582, 17668);

                scriptExecution = f_959_17600_17667(Utils.SystemWideOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 17682, 17774);

                f_959_17682_17773(fixture, scriptExecution, f_959_17730_17772(f_959_17730_17756(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 17790, 17877);

                scriptExecution = f_959_17808_17876(Utils.CurrentUserOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 17891, 17984);

                f_959_17891_17983(fixture, scriptExecution, f_959_17939_17982(f_959_17939_17966(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 18000, 18097);

                scriptExecution = f_959_18018_18096(Utils.SystemWideThenCurrentUserConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 18111, 18203);

                f_959_18111_18202(fixture, scriptExecution, f_959_18159_18201(f_959_18159_18185(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 18219, 18316);

                scriptExecution = f_959_18237_18315(Utils.CurrentUserThenSystemWideConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 18330, 18423);

                f_959_18330_18422(fixture, scriptExecution, f_959_18378_18421(f_959_18378_18405(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 18439, 18477);

                ScriptBlockLogging
                scriptBlockLogging
                = default(ScriptBlockLogging);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 18491, 18583);

                scriptBlockLogging = f_959_18512_18582(Utils.SystemWideOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 18597, 18698);

                f_959_18597_18697(fixture, scriptBlockLogging, f_959_18651_18696(f_959_18651_18677(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 18714, 18807);

                scriptBlockLogging = f_959_18735_18806(Utils.CurrentUserOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 18821, 18923);

                f_959_18821_18922(fixture, scriptBlockLogging, f_959_18875_18921(f_959_18875_18902(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 18939, 19042);

                scriptBlockLogging = f_959_18960_19041(Utils.SystemWideThenCurrentUserConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 19056, 19157);

                f_959_19056_19156(fixture, scriptBlockLogging, f_959_19110_19155(f_959_19110_19136(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 19173, 19276);

                scriptBlockLogging = f_959_19194_19275(Utils.CurrentUserThenSystemWideConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 19290, 19392);

                f_959_19290_19391(fixture, scriptBlockLogging, f_959_19344_19390(f_959_19344_19371(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 19408, 19436);

                ModuleLogging
                moduleLogging
                = default(ModuleLogging);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 19450, 19532);

                moduleLogging = f_959_19466_19531(Utils.SystemWideOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 19546, 19632);

                f_959_19546_19631(fixture, moduleLogging, f_959_19590_19630(f_959_19590_19616(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 19648, 19731);

                moduleLogging = f_959_19664_19730(Utils.CurrentUserOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 19745, 19832);

                f_959_19745_19831(fixture, moduleLogging, f_959_19789_19830(f_959_19789_19816(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 19848, 19941);

                moduleLogging = f_959_19864_19940(Utils.SystemWideThenCurrentUserConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 19955, 20041);

                f_959_19955_20040(fixture, moduleLogging, f_959_19999_20039(f_959_19999_20025(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 20057, 20150);

                moduleLogging = f_959_20073_20149(Utils.CurrentUserThenSystemWideConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 20164, 20251);

                f_959_20164_20250(fixture, moduleLogging, f_959_20208_20249(f_959_20208_20235(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 20267, 20311);

                ProtectedEventLogging
                protectedEventLogging
                = default(ProtectedEventLogging);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 20325, 20423);

                protectedEventLogging = f_959_20349_20422(Utils.SystemWideOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 20437, 20547);

                f_959_20437_20546(fixture, protectedEventLogging, f_959_20497_20545(f_959_20497_20523(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 20563, 20662);

                protectedEventLogging = f_959_20587_20661(Utils.CurrentUserOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 20676, 20787);

                f_959_20676_20786(fixture, protectedEventLogging, f_959_20736_20785(f_959_20736_20763(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 20803, 20912);

                protectedEventLogging = f_959_20827_20911(Utils.SystemWideThenCurrentUserConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 20926, 21036);

                f_959_20926_21035(fixture, protectedEventLogging, f_959_20986_21034(f_959_20986_21012(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 21052, 21161);

                protectedEventLogging = f_959_21076_21160(Utils.CurrentUserThenSystemWideConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 21175, 21286);

                f_959_21175_21285(fixture, protectedEventLogging, f_959_21235_21284(f_959_21235_21262(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 21441, 21469);

                Transcription
                transcription
                = default(Transcription);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 21483, 21565);

                transcription = f_959_21499_21564(Utils.SystemWideOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 21579, 21665);

                f_959_21579_21664(fixture, transcription, f_959_21623_21663(f_959_21623_21649(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 21681, 21764);

                transcription = f_959_21697_21763(Utils.CurrentUserOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 21778, 21828);

                f_959_21778_21827(fixture, transcription, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 21844, 21937);

                transcription = f_959_21860_21936(Utils.SystemWideThenCurrentUserConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 21951, 22037);

                f_959_21951_22036(fixture, transcription, f_959_21995_22035(f_959_21995_22021(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 22053, 22146);

                transcription = f_959_22069_22145(Utils.CurrentUserThenSystemWideConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 22160, 22246);

                f_959_22160_22245(fixture, transcription, f_959_22204_22244(f_959_22204_22230(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 22262, 22290);

                UpdatableHelp
                updatableHelp
                = default(UpdatableHelp);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 22304, 22386);

                updatableHelp = f_959_22320_22385(Utils.SystemWideOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 22400, 22486);

                f_959_22400_22485(fixture, updatableHelp, f_959_22444_22484(f_959_22444_22470(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 22502, 22585);

                updatableHelp = f_959_22518_22584(Utils.CurrentUserOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 22599, 22649);

                f_959_22599_22648(fixture, updatableHelp, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 22665, 22758);

                updatableHelp = f_959_22681_22757(Utils.SystemWideThenCurrentUserConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 22772, 22858);

                f_959_22772_22857(fixture, updatableHelp, f_959_22816_22856(f_959_22816_22842(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 22874, 22967);

                updatableHelp = f_959_22890_22966(Utils.CurrentUserThenSystemWideConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 22981, 23067);

                f_959_22981_23066(fixture, updatableHelp, f_959_23025_23065(f_959_23025_23051(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 23083, 23139);

                ConsoleSessionConfiguration
                consoleSessionConfiguration
                = default(ConsoleSessionConfiguration);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 23153, 23263);

                consoleSessionConfiguration = f_959_23183_23262(Utils.SystemWideOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 23277, 23405);

                f_959_23277_23404(fixture, consoleSessionConfiguration, f_959_23349_23403(f_959_23349_23375(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 23421, 23532);

                consoleSessionConfiguration = f_959_23451_23531(Utils.CurrentUserOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 23546, 23624);

                f_959_23546_23623(fixture, consoleSessionConfiguration, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 23640, 23761);

                consoleSessionConfiguration = f_959_23670_23760(Utils.SystemWideThenCurrentUserConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 23775, 23903);

                f_959_23775_23902(fixture, consoleSessionConfiguration, f_959_23847_23901(f_959_23847_23873(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 23919, 24040);

                consoleSessionConfiguration = f_959_23949_24039(Utils.CurrentUserThenSystemWideConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 24054, 24182);

                f_959_24054_24181(fixture, consoleSessionConfiguration, f_959_24126_24180(f_959_24126_24152(fixture)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(959, 17330, 24193);

                int
                f_959_17448_17474(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    this_param.SetupConfigFile1();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 17448, 17474);
                    return 0;
                }


                int
                f_959_17489_17519(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    this_param.ForceReadingFromFile();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 17489, 17519);
                    return 0;
                }


                System.Management.Automation.Configuration.ScriptExecution
                f_959_17600_17667(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ScriptExecution>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 17600, 17667);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_17730_17756(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.SystemWidePolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 17730, 17756);
                    return return_v;
                }


                System.Management.Automation.Configuration.ScriptExecution
                f_959_17730_17772(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ScriptExecution;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 17730, 17772);
                    return return_v;
                }


                int
                f_959_17682_17773(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ScriptExecution
                a, System.Management.Automation.Configuration.ScriptExecution
                b)
                {
                    this_param.CompareScriptExecution(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 17682, 17773);
                    return 0;
                }


                System.Management.Automation.Configuration.ScriptExecution
                f_959_17808_17876(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ScriptExecution>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 17808, 17876);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_17939_17966(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.CurrentUserPolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 17939, 17966);
                    return return_v;
                }


                System.Management.Automation.Configuration.ScriptExecution
                f_959_17939_17982(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ScriptExecution;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 17939, 17982);
                    return return_v;
                }


                int
                f_959_17891_17983(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ScriptExecution
                a, System.Management.Automation.Configuration.ScriptExecution
                b)
                {
                    this_param.CompareScriptExecution(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 17891, 17983);
                    return 0;
                }


                System.Management.Automation.Configuration.ScriptExecution
                f_959_18018_18096(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ScriptExecution>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 18018, 18096);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_18159_18185(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.SystemWidePolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 18159, 18185);
                    return return_v;
                }


                System.Management.Automation.Configuration.ScriptExecution
                f_959_18159_18201(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ScriptExecution;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 18159, 18201);
                    return return_v;
                }


                int
                f_959_18111_18202(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ScriptExecution
                a, System.Management.Automation.Configuration.ScriptExecution
                b)
                {
                    this_param.CompareScriptExecution(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 18111, 18202);
                    return 0;
                }


                System.Management.Automation.Configuration.ScriptExecution
                f_959_18237_18315(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ScriptExecution>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 18237, 18315);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_18378_18405(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.CurrentUserPolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 18378, 18405);
                    return return_v;
                }


                System.Management.Automation.Configuration.ScriptExecution
                f_959_18378_18421(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ScriptExecution;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 18378, 18421);
                    return return_v;
                }


                int
                f_959_18330_18422(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ScriptExecution
                a, System.Management.Automation.Configuration.ScriptExecution
                b)
                {
                    this_param.CompareScriptExecution(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 18330, 18422);
                    return 0;
                }


                System.Management.Automation.Configuration.ScriptBlockLogging
                f_959_18512_18582(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ScriptBlockLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 18512, 18582);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_18651_18677(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.SystemWidePolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 18651, 18677);
                    return return_v;
                }


                System.Management.Automation.Configuration.ScriptBlockLogging
                f_959_18651_18696(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ScriptBlockLogging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 18651, 18696);
                    return return_v;
                }


                int
                f_959_18597_18697(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ScriptBlockLogging
                a, System.Management.Automation.Configuration.ScriptBlockLogging
                b)
                {
                    this_param.CompareScriptBlockLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 18597, 18697);
                    return 0;
                }


                System.Management.Automation.Configuration.ScriptBlockLogging
                f_959_18735_18806(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ScriptBlockLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 18735, 18806);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_18875_18902(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.CurrentUserPolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 18875, 18902);
                    return return_v;
                }


                System.Management.Automation.Configuration.ScriptBlockLogging
                f_959_18875_18921(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ScriptBlockLogging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 18875, 18921);
                    return return_v;
                }


                int
                f_959_18821_18922(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ScriptBlockLogging
                a, System.Management.Automation.Configuration.ScriptBlockLogging
                b)
                {
                    this_param.CompareScriptBlockLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 18821, 18922);
                    return 0;
                }


                System.Management.Automation.Configuration.ScriptBlockLogging
                f_959_18960_19041(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ScriptBlockLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 18960, 19041);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_19110_19136(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.SystemWidePolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 19110, 19136);
                    return return_v;
                }


                System.Management.Automation.Configuration.ScriptBlockLogging
                f_959_19110_19155(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ScriptBlockLogging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 19110, 19155);
                    return return_v;
                }


                int
                f_959_19056_19156(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ScriptBlockLogging
                a, System.Management.Automation.Configuration.ScriptBlockLogging
                b)
                {
                    this_param.CompareScriptBlockLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 19056, 19156);
                    return 0;
                }


                System.Management.Automation.Configuration.ScriptBlockLogging
                f_959_19194_19275(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ScriptBlockLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 19194, 19275);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_19344_19371(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.CurrentUserPolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 19344, 19371);
                    return return_v;
                }


                System.Management.Automation.Configuration.ScriptBlockLogging
                f_959_19344_19390(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ScriptBlockLogging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 19344, 19390);
                    return return_v;
                }


                int
                f_959_19290_19391(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ScriptBlockLogging
                a, System.Management.Automation.Configuration.ScriptBlockLogging
                b)
                {
                    this_param.CompareScriptBlockLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 19290, 19391);
                    return 0;
                }


                System.Management.Automation.Configuration.ModuleLogging
                f_959_19466_19531(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ModuleLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 19466, 19531);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_19590_19616(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.SystemWidePolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 19590, 19616);
                    return return_v;
                }


                System.Management.Automation.Configuration.ModuleLogging
                f_959_19590_19630(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ModuleLogging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 19590, 19630);
                    return return_v;
                }


                int
                f_959_19546_19631(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ModuleLogging
                a, System.Management.Automation.Configuration.ModuleLogging
                b)
                {
                    this_param.CompareModuleLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 19546, 19631);
                    return 0;
                }


                System.Management.Automation.Configuration.ModuleLogging
                f_959_19664_19730(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ModuleLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 19664, 19730);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_19789_19816(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.CurrentUserPolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 19789, 19816);
                    return return_v;
                }


                System.Management.Automation.Configuration.ModuleLogging
                f_959_19789_19830(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ModuleLogging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 19789, 19830);
                    return return_v;
                }


                int
                f_959_19745_19831(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ModuleLogging
                a, System.Management.Automation.Configuration.ModuleLogging
                b)
                {
                    this_param.CompareModuleLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 19745, 19831);
                    return 0;
                }


                System.Management.Automation.Configuration.ModuleLogging
                f_959_19864_19940(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ModuleLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 19864, 19940);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_19999_20025(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.SystemWidePolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 19999, 20025);
                    return return_v;
                }


                System.Management.Automation.Configuration.ModuleLogging
                f_959_19999_20039(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ModuleLogging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 19999, 20039);
                    return return_v;
                }


                int
                f_959_19955_20040(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ModuleLogging
                a, System.Management.Automation.Configuration.ModuleLogging
                b)
                {
                    this_param.CompareModuleLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 19955, 20040);
                    return 0;
                }


                System.Management.Automation.Configuration.ModuleLogging
                f_959_20073_20149(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ModuleLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 20073, 20149);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_20208_20235(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.CurrentUserPolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 20208, 20235);
                    return return_v;
                }


                System.Management.Automation.Configuration.ModuleLogging
                f_959_20208_20249(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ModuleLogging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 20208, 20249);
                    return return_v;
                }


                int
                f_959_20164_20250(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ModuleLogging
                a, System.Management.Automation.Configuration.ModuleLogging
                b)
                {
                    this_param.CompareModuleLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 20164, 20250);
                    return 0;
                }


                System.Management.Automation.Configuration.ProtectedEventLogging
                f_959_20349_20422(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ProtectedEventLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 20349, 20422);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_20497_20523(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.SystemWidePolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 20497, 20523);
                    return return_v;
                }


                System.Management.Automation.Configuration.ProtectedEventLogging
                f_959_20497_20545(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ProtectedEventLogging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 20497, 20545);
                    return return_v;
                }


                int
                f_959_20437_20546(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ProtectedEventLogging
                a, System.Management.Automation.Configuration.ProtectedEventLogging
                b)
                {
                    this_param.CompareProtectedEventLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 20437, 20546);
                    return 0;
                }


                System.Management.Automation.Configuration.ProtectedEventLogging
                f_959_20587_20661(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ProtectedEventLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 20587, 20661);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_20736_20763(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.CurrentUserPolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 20736, 20763);
                    return return_v;
                }


                System.Management.Automation.Configuration.ProtectedEventLogging
                f_959_20736_20785(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ProtectedEventLogging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 20736, 20785);
                    return return_v;
                }


                int
                f_959_20676_20786(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ProtectedEventLogging
                a, System.Management.Automation.Configuration.ProtectedEventLogging
                b)
                {
                    this_param.CompareProtectedEventLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 20676, 20786);
                    return 0;
                }


                System.Management.Automation.Configuration.ProtectedEventLogging
                f_959_20827_20911(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ProtectedEventLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 20827, 20911);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_20986_21012(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.SystemWidePolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 20986, 21012);
                    return return_v;
                }


                System.Management.Automation.Configuration.ProtectedEventLogging
                f_959_20986_21034(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ProtectedEventLogging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 20986, 21034);
                    return return_v;
                }


                int
                f_959_20926_21035(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ProtectedEventLogging
                a, System.Management.Automation.Configuration.ProtectedEventLogging
                b)
                {
                    this_param.CompareProtectedEventLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 20926, 21035);
                    return 0;
                }


                System.Management.Automation.Configuration.ProtectedEventLogging
                f_959_21076_21160(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ProtectedEventLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 21076, 21160);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_21235_21262(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.CurrentUserPolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 21235, 21262);
                    return return_v;
                }


                System.Management.Automation.Configuration.ProtectedEventLogging
                f_959_21235_21284(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ProtectedEventLogging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 21235, 21284);
                    return return_v;
                }


                int
                f_959_21175_21285(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ProtectedEventLogging
                a, System.Management.Automation.Configuration.ProtectedEventLogging
                b)
                {
                    this_param.CompareProtectedEventLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 21175, 21285);
                    return 0;
                }


                System.Management.Automation.Configuration.Transcription
                f_959_21499_21564(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<Transcription>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 21499, 21564);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_21623_21649(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.SystemWidePolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 21623, 21649);
                    return return_v;
                }


                System.Management.Automation.Configuration.Transcription
                f_959_21623_21663(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.Transcription;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 21623, 21663);
                    return return_v;
                }


                int
                f_959_21579_21664(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.Transcription
                a, System.Management.Automation.Configuration.Transcription
                b)
                {
                    this_param.CompareTranscription(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 21579, 21664);
                    return 0;
                }


                System.Management.Automation.Configuration.Transcription
                f_959_21697_21763(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<Transcription>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 21697, 21763);
                    return return_v;
                }


                int
                f_959_21778_21827(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.Transcription
                a, System.Management.Automation.Configuration.Transcription
                b)
                {
                    this_param.CompareTranscription(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 21778, 21827);
                    return 0;
                }


                System.Management.Automation.Configuration.Transcription
                f_959_21860_21936(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<Transcription>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 21860, 21936);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_21995_22021(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.SystemWidePolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 21995, 22021);
                    return return_v;
                }


                System.Management.Automation.Configuration.Transcription
                f_959_21995_22035(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.Transcription;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 21995, 22035);
                    return return_v;
                }


                int
                f_959_21951_22036(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.Transcription
                a, System.Management.Automation.Configuration.Transcription
                b)
                {
                    this_param.CompareTranscription(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 21951, 22036);
                    return 0;
                }


                System.Management.Automation.Configuration.Transcription
                f_959_22069_22145(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<Transcription>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 22069, 22145);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_22204_22230(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.SystemWidePolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 22204, 22230);
                    return return_v;
                }


                System.Management.Automation.Configuration.Transcription
                f_959_22204_22244(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.Transcription;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 22204, 22244);
                    return return_v;
                }


                int
                f_959_22160_22245(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.Transcription
                a, System.Management.Automation.Configuration.Transcription
                b)
                {
                    this_param.CompareTranscription(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 22160, 22245);
                    return 0;
                }


                System.Management.Automation.Configuration.UpdatableHelp
                f_959_22320_22385(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<UpdatableHelp>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 22320, 22385);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_22444_22470(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.SystemWidePolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 22444, 22470);
                    return return_v;
                }


                System.Management.Automation.Configuration.UpdatableHelp
                f_959_22444_22484(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.UpdatableHelp;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 22444, 22484);
                    return return_v;
                }


                int
                f_959_22400_22485(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.UpdatableHelp
                a, System.Management.Automation.Configuration.UpdatableHelp
                b)
                {
                    this_param.CompareUpdatableHelp(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 22400, 22485);
                    return 0;
                }


                System.Management.Automation.Configuration.UpdatableHelp
                f_959_22518_22584(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<UpdatableHelp>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 22518, 22584);
                    return return_v;
                }


                int
                f_959_22599_22648(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.UpdatableHelp
                a, System.Management.Automation.Configuration.UpdatableHelp
                b)
                {
                    this_param.CompareUpdatableHelp(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 22599, 22648);
                    return 0;
                }


                System.Management.Automation.Configuration.UpdatableHelp
                f_959_22681_22757(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<UpdatableHelp>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 22681, 22757);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_22816_22842(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.SystemWidePolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 22816, 22842);
                    return return_v;
                }


                System.Management.Automation.Configuration.UpdatableHelp
                f_959_22816_22856(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.UpdatableHelp;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 22816, 22856);
                    return return_v;
                }


                int
                f_959_22772_22857(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.UpdatableHelp
                a, System.Management.Automation.Configuration.UpdatableHelp
                b)
                {
                    this_param.CompareUpdatableHelp(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 22772, 22857);
                    return 0;
                }


                System.Management.Automation.Configuration.UpdatableHelp
                f_959_22890_22966(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<UpdatableHelp>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 22890, 22966);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_23025_23051(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.SystemWidePolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 23025, 23051);
                    return return_v;
                }


                System.Management.Automation.Configuration.UpdatableHelp
                f_959_23025_23065(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.UpdatableHelp;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 23025, 23065);
                    return return_v;
                }


                int
                f_959_22981_23066(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.UpdatableHelp
                a, System.Management.Automation.Configuration.UpdatableHelp
                b)
                {
                    this_param.CompareUpdatableHelp(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 22981, 23066);
                    return 0;
                }


                System.Management.Automation.Configuration.ConsoleSessionConfiguration
                f_959_23183_23262(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ConsoleSessionConfiguration>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 23183, 23262);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_23349_23375(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.SystemWidePolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 23349, 23375);
                    return return_v;
                }


                System.Management.Automation.Configuration.ConsoleSessionConfiguration
                f_959_23349_23403(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ConsoleSessionConfiguration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 23349, 23403);
                    return return_v;
                }


                int
                f_959_23277_23404(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ConsoleSessionConfiguration
                a, System.Management.Automation.Configuration.ConsoleSessionConfiguration
                b)
                {
                    this_param.CompareConsoleSessionConfiguration(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 23277, 23404);
                    return 0;
                }


                System.Management.Automation.Configuration.ConsoleSessionConfiguration
                f_959_23451_23531(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ConsoleSessionConfiguration>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 23451, 23531);
                    return return_v;
                }


                int
                f_959_23546_23623(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ConsoleSessionConfiguration
                a, System.Management.Automation.Configuration.ConsoleSessionConfiguration
                b)
                {
                    this_param.CompareConsoleSessionConfiguration(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 23546, 23623);
                    return 0;
                }


                System.Management.Automation.Configuration.ConsoleSessionConfiguration
                f_959_23670_23760(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ConsoleSessionConfiguration>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 23670, 23760);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_23847_23873(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.SystemWidePolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 23847, 23873);
                    return return_v;
                }


                System.Management.Automation.Configuration.ConsoleSessionConfiguration
                f_959_23847_23901(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ConsoleSessionConfiguration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 23847, 23901);
                    return return_v;
                }


                int
                f_959_23775_23902(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ConsoleSessionConfiguration
                a, System.Management.Automation.Configuration.ConsoleSessionConfiguration
                b)
                {
                    this_param.CompareConsoleSessionConfiguration(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 23775, 23902);
                    return 0;
                }


                System.Management.Automation.Configuration.ConsoleSessionConfiguration
                f_959_23949_24039(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ConsoleSessionConfiguration>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 23949, 24039);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_24126_24152(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.SystemWidePolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 24126, 24152);
                    return return_v;
                }


                System.Management.Automation.Configuration.ConsoleSessionConfiguration
                f_959_24126_24180(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ConsoleSessionConfiguration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 24126, 24180);
                    return return_v;
                }


                int
                f_959_24054_24181(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ConsoleSessionConfiguration
                a, System.Management.Automation.Configuration.ConsoleSessionConfiguration
                b)
                {
                    this_param.CompareConsoleSessionConfiguration(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 24054, 24181);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(959, 17330, 24193);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(959, 17330, 24193);
            }
        }

        [Fact, TestPriority(7)]
        public void Utils_GetPolicySetting_EmptyUserConfig()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(959, 24205, 30802);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 24315, 24342);

                f_959_24315_24341(fixture);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 24356, 24387);

                f_959_24356_24386(fixture);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 24451, 24483);

                ScriptExecution
                scriptExecution
                = default(ScriptExecution);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 24497, 24583);

                scriptExecution = f_959_24515_24582(Utils.SystemWideOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 24597, 24689);

                f_959_24597_24688(fixture, scriptExecution, f_959_24645_24687(f_959_24645_24671(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 24705, 24792);

                scriptExecution = f_959_24723_24791(Utils.CurrentUserOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 24806, 24860);

                f_959_24806_24859(fixture, scriptExecution, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 24876, 24973);

                scriptExecution = f_959_24894_24972(Utils.SystemWideThenCurrentUserConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 24987, 25079);

                f_959_24987_25078(fixture, scriptExecution, f_959_25035_25077(f_959_25035_25061(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 25095, 25192);

                scriptExecution = f_959_25113_25191(Utils.CurrentUserThenSystemWideConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 25206, 25298);

                f_959_25206_25297(fixture, scriptExecution, f_959_25254_25296(f_959_25254_25280(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 25314, 25352);

                ScriptBlockLogging
                scriptBlockLogging
                = default(ScriptBlockLogging);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 25366, 25458);

                scriptBlockLogging = f_959_25387_25457(Utils.SystemWideOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 25472, 25573);

                f_959_25472_25572(fixture, scriptBlockLogging, f_959_25526_25571(f_959_25526_25552(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 25589, 25682);

                scriptBlockLogging = f_959_25610_25681(Utils.CurrentUserOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 25696, 25756);

                f_959_25696_25755(fixture, scriptBlockLogging, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 25772, 25875);

                scriptBlockLogging = f_959_25793_25874(Utils.SystemWideThenCurrentUserConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 25889, 25990);

                f_959_25889_25989(fixture, scriptBlockLogging, f_959_25943_25988(f_959_25943_25969(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 26006, 26109);

                scriptBlockLogging = f_959_26027_26108(Utils.CurrentUserThenSystemWideConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 26123, 26224);

                f_959_26123_26223(fixture, scriptBlockLogging, f_959_26177_26222(f_959_26177_26203(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 26240, 26268);

                ModuleLogging
                moduleLogging
                = default(ModuleLogging);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 26282, 26364);

                moduleLogging = f_959_26298_26363(Utils.SystemWideOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 26378, 26464);

                f_959_26378_26463(fixture, moduleLogging, f_959_26422_26462(f_959_26422_26448(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 26480, 26563);

                moduleLogging = f_959_26496_26562(Utils.CurrentUserOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 26577, 26627);

                f_959_26577_26626(fixture, moduleLogging, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 26643, 26736);

                moduleLogging = f_959_26659_26735(Utils.SystemWideThenCurrentUserConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 26750, 26836);

                f_959_26750_26835(fixture, moduleLogging, f_959_26794_26834(f_959_26794_26820(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 26852, 26945);

                moduleLogging = f_959_26868_26944(Utils.CurrentUserThenSystemWideConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 26959, 27045);

                f_959_26959_27044(fixture, moduleLogging, f_959_27003_27043(f_959_27003_27029(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 27061, 27105);

                ProtectedEventLogging
                protectedEventLogging
                = default(ProtectedEventLogging);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 27119, 27217);

                protectedEventLogging = f_959_27143_27216(Utils.SystemWideOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 27231, 27341);

                f_959_27231_27340(fixture, protectedEventLogging, f_959_27291_27339(f_959_27291_27317(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 27357, 27456);

                protectedEventLogging = f_959_27381_27455(Utils.CurrentUserOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 27470, 27536);

                f_959_27470_27535(fixture, protectedEventLogging, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 27552, 27661);

                protectedEventLogging = f_959_27576_27660(Utils.SystemWideThenCurrentUserConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 27675, 27785);

                f_959_27675_27784(fixture, protectedEventLogging, f_959_27735_27783(f_959_27735_27761(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 27801, 27910);

                protectedEventLogging = f_959_27825_27909(Utils.CurrentUserThenSystemWideConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 27924, 28034);

                f_959_27924_28033(fixture, protectedEventLogging, f_959_27984_28032(f_959_27984_28010(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 28050, 28078);

                Transcription
                transcription
                = default(Transcription);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 28092, 28174);

                transcription = f_959_28108_28173(Utils.SystemWideOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 28188, 28274);

                f_959_28188_28273(fixture, transcription, f_959_28232_28272(f_959_28232_28258(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 28290, 28373);

                transcription = f_959_28306_28372(Utils.CurrentUserOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 28387, 28437);

                f_959_28387_28436(fixture, transcription, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 28453, 28546);

                transcription = f_959_28469_28545(Utils.SystemWideThenCurrentUserConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 28560, 28646);

                f_959_28560_28645(fixture, transcription, f_959_28604_28644(f_959_28604_28630(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 28662, 28755);

                transcription = f_959_28678_28754(Utils.CurrentUserThenSystemWideConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 28769, 28855);

                f_959_28769_28854(fixture, transcription, f_959_28813_28853(f_959_28813_28839(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 28871, 28899);

                UpdatableHelp
                updatableHelp
                = default(UpdatableHelp);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 28913, 28995);

                updatableHelp = f_959_28929_28994(Utils.SystemWideOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 29009, 29095);

                f_959_29009_29094(fixture, updatableHelp, f_959_29053_29093(f_959_29053_29079(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 29111, 29194);

                updatableHelp = f_959_29127_29193(Utils.CurrentUserOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 29208, 29258);

                f_959_29208_29257(fixture, updatableHelp, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 29274, 29367);

                updatableHelp = f_959_29290_29366(Utils.SystemWideThenCurrentUserConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 29381, 29467);

                f_959_29381_29466(fixture, updatableHelp, f_959_29425_29465(f_959_29425_29451(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 29483, 29576);

                updatableHelp = f_959_29499_29575(Utils.CurrentUserThenSystemWideConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 29590, 29676);

                f_959_29590_29675(fixture, updatableHelp, f_959_29634_29674(f_959_29634_29660(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 29692, 29748);

                ConsoleSessionConfiguration
                consoleSessionConfiguration
                = default(ConsoleSessionConfiguration);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 29762, 29872);

                consoleSessionConfiguration = f_959_29792_29871(Utils.SystemWideOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 29886, 30014);

                f_959_29886_30013(fixture, consoleSessionConfiguration, f_959_29958_30012(f_959_29958_29984(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 30030, 30141);

                consoleSessionConfiguration = f_959_30060_30140(Utils.CurrentUserOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 30155, 30233);

                f_959_30155_30232(fixture, consoleSessionConfiguration, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 30249, 30370);

                consoleSessionConfiguration = f_959_30279_30369(Utils.SystemWideThenCurrentUserConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 30384, 30512);

                f_959_30384_30511(fixture, consoleSessionConfiguration, f_959_30456_30510(f_959_30456_30482(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 30528, 30649);

                consoleSessionConfiguration = f_959_30558_30648(Utils.CurrentUserThenSystemWideConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 30663, 30791);

                f_959_30663_30790(fixture, consoleSessionConfiguration, f_959_30735_30789(f_959_30735_30761(fixture)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(959, 24205, 30802);

                int
                f_959_24315_24341(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    this_param.SetupConfigFile2();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 24315, 24341);
                    return 0;
                }


                int
                f_959_24356_24386(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    this_param.ForceReadingFromFile();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 24356, 24386);
                    return 0;
                }


                System.Management.Automation.Configuration.ScriptExecution
                f_959_24515_24582(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ScriptExecution>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 24515, 24582);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_24645_24671(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.SystemWidePolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 24645, 24671);
                    return return_v;
                }


                System.Management.Automation.Configuration.ScriptExecution
                f_959_24645_24687(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ScriptExecution;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 24645, 24687);
                    return return_v;
                }


                int
                f_959_24597_24688(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ScriptExecution
                a, System.Management.Automation.Configuration.ScriptExecution
                b)
                {
                    this_param.CompareScriptExecution(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 24597, 24688);
                    return 0;
                }


                System.Management.Automation.Configuration.ScriptExecution
                f_959_24723_24791(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ScriptExecution>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 24723, 24791);
                    return return_v;
                }


                int
                f_959_24806_24859(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ScriptExecution
                a, System.Management.Automation.Configuration.ScriptExecution
                b)
                {
                    this_param.CompareScriptExecution(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 24806, 24859);
                    return 0;
                }


                System.Management.Automation.Configuration.ScriptExecution
                f_959_24894_24972(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ScriptExecution>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 24894, 24972);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_25035_25061(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.SystemWidePolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 25035, 25061);
                    return return_v;
                }


                System.Management.Automation.Configuration.ScriptExecution
                f_959_25035_25077(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ScriptExecution;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 25035, 25077);
                    return return_v;
                }


                int
                f_959_24987_25078(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ScriptExecution
                a, System.Management.Automation.Configuration.ScriptExecution
                b)
                {
                    this_param.CompareScriptExecution(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 24987, 25078);
                    return 0;
                }


                System.Management.Automation.Configuration.ScriptExecution
                f_959_25113_25191(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ScriptExecution>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 25113, 25191);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_25254_25280(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.SystemWidePolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 25254, 25280);
                    return return_v;
                }


                System.Management.Automation.Configuration.ScriptExecution
                f_959_25254_25296(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ScriptExecution;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 25254, 25296);
                    return return_v;
                }


                int
                f_959_25206_25297(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ScriptExecution
                a, System.Management.Automation.Configuration.ScriptExecution
                b)
                {
                    this_param.CompareScriptExecution(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 25206, 25297);
                    return 0;
                }


                System.Management.Automation.Configuration.ScriptBlockLogging
                f_959_25387_25457(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ScriptBlockLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 25387, 25457);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_25526_25552(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.SystemWidePolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 25526, 25552);
                    return return_v;
                }


                System.Management.Automation.Configuration.ScriptBlockLogging
                f_959_25526_25571(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ScriptBlockLogging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 25526, 25571);
                    return return_v;
                }


                int
                f_959_25472_25572(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ScriptBlockLogging
                a, System.Management.Automation.Configuration.ScriptBlockLogging
                b)
                {
                    this_param.CompareScriptBlockLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 25472, 25572);
                    return 0;
                }


                System.Management.Automation.Configuration.ScriptBlockLogging
                f_959_25610_25681(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ScriptBlockLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 25610, 25681);
                    return return_v;
                }


                int
                f_959_25696_25755(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ScriptBlockLogging
                a, System.Management.Automation.Configuration.ScriptBlockLogging
                b)
                {
                    this_param.CompareScriptBlockLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 25696, 25755);
                    return 0;
                }


                System.Management.Automation.Configuration.ScriptBlockLogging
                f_959_25793_25874(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ScriptBlockLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 25793, 25874);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_25943_25969(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.SystemWidePolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 25943, 25969);
                    return return_v;
                }


                System.Management.Automation.Configuration.ScriptBlockLogging
                f_959_25943_25988(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ScriptBlockLogging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 25943, 25988);
                    return return_v;
                }


                int
                f_959_25889_25989(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ScriptBlockLogging
                a, System.Management.Automation.Configuration.ScriptBlockLogging
                b)
                {
                    this_param.CompareScriptBlockLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 25889, 25989);
                    return 0;
                }


                System.Management.Automation.Configuration.ScriptBlockLogging
                f_959_26027_26108(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ScriptBlockLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 26027, 26108);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_26177_26203(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.SystemWidePolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 26177, 26203);
                    return return_v;
                }


                System.Management.Automation.Configuration.ScriptBlockLogging
                f_959_26177_26222(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ScriptBlockLogging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 26177, 26222);
                    return return_v;
                }


                int
                f_959_26123_26223(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ScriptBlockLogging
                a, System.Management.Automation.Configuration.ScriptBlockLogging
                b)
                {
                    this_param.CompareScriptBlockLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 26123, 26223);
                    return 0;
                }


                System.Management.Automation.Configuration.ModuleLogging
                f_959_26298_26363(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ModuleLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 26298, 26363);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_26422_26448(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.SystemWidePolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 26422, 26448);
                    return return_v;
                }


                System.Management.Automation.Configuration.ModuleLogging
                f_959_26422_26462(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ModuleLogging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 26422, 26462);
                    return return_v;
                }


                int
                f_959_26378_26463(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ModuleLogging
                a, System.Management.Automation.Configuration.ModuleLogging
                b)
                {
                    this_param.CompareModuleLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 26378, 26463);
                    return 0;
                }


                System.Management.Automation.Configuration.ModuleLogging
                f_959_26496_26562(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ModuleLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 26496, 26562);
                    return return_v;
                }


                int
                f_959_26577_26626(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ModuleLogging
                a, System.Management.Automation.Configuration.ModuleLogging
                b)
                {
                    this_param.CompareModuleLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 26577, 26626);
                    return 0;
                }


                System.Management.Automation.Configuration.ModuleLogging
                f_959_26659_26735(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ModuleLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 26659, 26735);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_26794_26820(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.SystemWidePolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 26794, 26820);
                    return return_v;
                }


                System.Management.Automation.Configuration.ModuleLogging
                f_959_26794_26834(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ModuleLogging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 26794, 26834);
                    return return_v;
                }


                int
                f_959_26750_26835(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ModuleLogging
                a, System.Management.Automation.Configuration.ModuleLogging
                b)
                {
                    this_param.CompareModuleLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 26750, 26835);
                    return 0;
                }


                System.Management.Automation.Configuration.ModuleLogging
                f_959_26868_26944(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ModuleLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 26868, 26944);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_27003_27029(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.SystemWidePolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 27003, 27029);
                    return return_v;
                }


                System.Management.Automation.Configuration.ModuleLogging
                f_959_27003_27043(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ModuleLogging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 27003, 27043);
                    return return_v;
                }


                int
                f_959_26959_27044(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ModuleLogging
                a, System.Management.Automation.Configuration.ModuleLogging
                b)
                {
                    this_param.CompareModuleLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 26959, 27044);
                    return 0;
                }


                System.Management.Automation.Configuration.ProtectedEventLogging
                f_959_27143_27216(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ProtectedEventLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 27143, 27216);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_27291_27317(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.SystemWidePolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 27291, 27317);
                    return return_v;
                }


                System.Management.Automation.Configuration.ProtectedEventLogging
                f_959_27291_27339(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ProtectedEventLogging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 27291, 27339);
                    return return_v;
                }


                int
                f_959_27231_27340(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ProtectedEventLogging
                a, System.Management.Automation.Configuration.ProtectedEventLogging
                b)
                {
                    this_param.CompareProtectedEventLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 27231, 27340);
                    return 0;
                }


                System.Management.Automation.Configuration.ProtectedEventLogging
                f_959_27381_27455(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ProtectedEventLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 27381, 27455);
                    return return_v;
                }


                int
                f_959_27470_27535(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ProtectedEventLogging
                a, System.Management.Automation.Configuration.ProtectedEventLogging
                b)
                {
                    this_param.CompareProtectedEventLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 27470, 27535);
                    return 0;
                }


                System.Management.Automation.Configuration.ProtectedEventLogging
                f_959_27576_27660(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ProtectedEventLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 27576, 27660);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_27735_27761(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.SystemWidePolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 27735, 27761);
                    return return_v;
                }


                System.Management.Automation.Configuration.ProtectedEventLogging
                f_959_27735_27783(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ProtectedEventLogging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 27735, 27783);
                    return return_v;
                }


                int
                f_959_27675_27784(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ProtectedEventLogging
                a, System.Management.Automation.Configuration.ProtectedEventLogging
                b)
                {
                    this_param.CompareProtectedEventLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 27675, 27784);
                    return 0;
                }


                System.Management.Automation.Configuration.ProtectedEventLogging
                f_959_27825_27909(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ProtectedEventLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 27825, 27909);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_27984_28010(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.SystemWidePolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 27984, 28010);
                    return return_v;
                }


                System.Management.Automation.Configuration.ProtectedEventLogging
                f_959_27984_28032(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ProtectedEventLogging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 27984, 28032);
                    return return_v;
                }


                int
                f_959_27924_28033(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ProtectedEventLogging
                a, System.Management.Automation.Configuration.ProtectedEventLogging
                b)
                {
                    this_param.CompareProtectedEventLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 27924, 28033);
                    return 0;
                }


                System.Management.Automation.Configuration.Transcription
                f_959_28108_28173(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<Transcription>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 28108, 28173);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_28232_28258(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.SystemWidePolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 28232, 28258);
                    return return_v;
                }


                System.Management.Automation.Configuration.Transcription
                f_959_28232_28272(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.Transcription;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 28232, 28272);
                    return return_v;
                }


                int
                f_959_28188_28273(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.Transcription
                a, System.Management.Automation.Configuration.Transcription
                b)
                {
                    this_param.CompareTranscription(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 28188, 28273);
                    return 0;
                }


                System.Management.Automation.Configuration.Transcription
                f_959_28306_28372(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<Transcription>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 28306, 28372);
                    return return_v;
                }


                int
                f_959_28387_28436(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.Transcription
                a, System.Management.Automation.Configuration.Transcription
                b)
                {
                    this_param.CompareTranscription(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 28387, 28436);
                    return 0;
                }


                System.Management.Automation.Configuration.Transcription
                f_959_28469_28545(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<Transcription>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 28469, 28545);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_28604_28630(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.SystemWidePolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 28604, 28630);
                    return return_v;
                }


                System.Management.Automation.Configuration.Transcription
                f_959_28604_28644(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.Transcription;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 28604, 28644);
                    return return_v;
                }


                int
                f_959_28560_28645(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.Transcription
                a, System.Management.Automation.Configuration.Transcription
                b)
                {
                    this_param.CompareTranscription(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 28560, 28645);
                    return 0;
                }


                System.Management.Automation.Configuration.Transcription
                f_959_28678_28754(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<Transcription>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 28678, 28754);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_28813_28839(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.SystemWidePolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 28813, 28839);
                    return return_v;
                }


                System.Management.Automation.Configuration.Transcription
                f_959_28813_28853(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.Transcription;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 28813, 28853);
                    return return_v;
                }


                int
                f_959_28769_28854(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.Transcription
                a, System.Management.Automation.Configuration.Transcription
                b)
                {
                    this_param.CompareTranscription(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 28769, 28854);
                    return 0;
                }


                System.Management.Automation.Configuration.UpdatableHelp
                f_959_28929_28994(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<UpdatableHelp>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 28929, 28994);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_29053_29079(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.SystemWidePolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 29053, 29079);
                    return return_v;
                }


                System.Management.Automation.Configuration.UpdatableHelp
                f_959_29053_29093(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.UpdatableHelp;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 29053, 29093);
                    return return_v;
                }


                int
                f_959_29009_29094(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.UpdatableHelp
                a, System.Management.Automation.Configuration.UpdatableHelp
                b)
                {
                    this_param.CompareUpdatableHelp(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 29009, 29094);
                    return 0;
                }


                System.Management.Automation.Configuration.UpdatableHelp
                f_959_29127_29193(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<UpdatableHelp>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 29127, 29193);
                    return return_v;
                }


                int
                f_959_29208_29257(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.UpdatableHelp
                a, System.Management.Automation.Configuration.UpdatableHelp
                b)
                {
                    this_param.CompareUpdatableHelp(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 29208, 29257);
                    return 0;
                }


                System.Management.Automation.Configuration.UpdatableHelp
                f_959_29290_29366(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<UpdatableHelp>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 29290, 29366);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_29425_29451(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.SystemWidePolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 29425, 29451);
                    return return_v;
                }


                System.Management.Automation.Configuration.UpdatableHelp
                f_959_29425_29465(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.UpdatableHelp;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 29425, 29465);
                    return return_v;
                }


                int
                f_959_29381_29466(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.UpdatableHelp
                a, System.Management.Automation.Configuration.UpdatableHelp
                b)
                {
                    this_param.CompareUpdatableHelp(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 29381, 29466);
                    return 0;
                }


                System.Management.Automation.Configuration.UpdatableHelp
                f_959_29499_29575(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<UpdatableHelp>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 29499, 29575);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_29634_29660(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.SystemWidePolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 29634, 29660);
                    return return_v;
                }


                System.Management.Automation.Configuration.UpdatableHelp
                f_959_29634_29674(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.UpdatableHelp;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 29634, 29674);
                    return return_v;
                }


                int
                f_959_29590_29675(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.UpdatableHelp
                a, System.Management.Automation.Configuration.UpdatableHelp
                b)
                {
                    this_param.CompareUpdatableHelp(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 29590, 29675);
                    return 0;
                }


                System.Management.Automation.Configuration.ConsoleSessionConfiguration
                f_959_29792_29871(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ConsoleSessionConfiguration>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 29792, 29871);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_29958_29984(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.SystemWidePolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 29958, 29984);
                    return return_v;
                }


                System.Management.Automation.Configuration.ConsoleSessionConfiguration
                f_959_29958_30012(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ConsoleSessionConfiguration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 29958, 30012);
                    return return_v;
                }


                int
                f_959_29886_30013(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ConsoleSessionConfiguration
                a, System.Management.Automation.Configuration.ConsoleSessionConfiguration
                b)
                {
                    this_param.CompareConsoleSessionConfiguration(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 29886, 30013);
                    return 0;
                }


                System.Management.Automation.Configuration.ConsoleSessionConfiguration
                f_959_30060_30140(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ConsoleSessionConfiguration>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 30060, 30140);
                    return return_v;
                }


                int
                f_959_30155_30232(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ConsoleSessionConfiguration
                a, System.Management.Automation.Configuration.ConsoleSessionConfiguration
                b)
                {
                    this_param.CompareConsoleSessionConfiguration(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 30155, 30232);
                    return 0;
                }


                System.Management.Automation.Configuration.ConsoleSessionConfiguration
                f_959_30279_30369(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ConsoleSessionConfiguration>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 30279, 30369);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_30456_30482(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.SystemWidePolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 30456, 30482);
                    return return_v;
                }


                System.Management.Automation.Configuration.ConsoleSessionConfiguration
                f_959_30456_30510(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ConsoleSessionConfiguration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 30456, 30510);
                    return return_v;
                }


                int
                f_959_30384_30511(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ConsoleSessionConfiguration
                a, System.Management.Automation.Configuration.ConsoleSessionConfiguration
                b)
                {
                    this_param.CompareConsoleSessionConfiguration(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 30384, 30511);
                    return 0;
                }


                System.Management.Automation.Configuration.ConsoleSessionConfiguration
                f_959_30558_30648(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ConsoleSessionConfiguration>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 30558, 30648);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_30735_30761(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.SystemWidePolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 30735, 30761);
                    return return_v;
                }


                System.Management.Automation.Configuration.ConsoleSessionConfiguration
                f_959_30735_30789(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ConsoleSessionConfiguration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 30735, 30789);
                    return return_v;
                }


                int
                f_959_30663_30790(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ConsoleSessionConfiguration
                a, System.Management.Automation.Configuration.ConsoleSessionConfiguration
                b)
                {
                    this_param.CompareConsoleSessionConfiguration(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 30663, 30790);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(959, 24205, 30802);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(959, 24205, 30802);
            }
        }

        [Fact, TestPriority(8)]
        public void Utils_GetPolicySetting_EmptySystemConfig()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(959, 30814, 37197);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 30926, 30953);

                f_959_30926_30952(fixture);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 30967, 30998);

                f_959_30967_30997(fixture);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 31061, 31093);

                ScriptExecution
                scriptExecution
                = default(ScriptExecution);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 31107, 31193);

                scriptExecution = f_959_31125_31192(Utils.SystemWideOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 31207, 31261);

                f_959_31207_31260(fixture, scriptExecution, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 31277, 31364);

                scriptExecution = f_959_31295_31363(Utils.CurrentUserOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 31378, 31471);

                f_959_31378_31470(fixture, scriptExecution, f_959_31426_31469(f_959_31426_31453(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 31487, 31584);

                scriptExecution = f_959_31505_31583(Utils.SystemWideThenCurrentUserConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 31598, 31691);

                f_959_31598_31690(fixture, scriptExecution, f_959_31646_31689(f_959_31646_31673(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 31707, 31804);

                scriptExecution = f_959_31725_31803(Utils.CurrentUserThenSystemWideConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 31818, 31911);

                f_959_31818_31910(fixture, scriptExecution, f_959_31866_31909(f_959_31866_31893(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 31927, 31965);

                ScriptBlockLogging
                scriptBlockLogging
                = default(ScriptBlockLogging);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 31979, 32071);

                scriptBlockLogging = f_959_32000_32070(Utils.SystemWideOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 32085, 32145);

                f_959_32085_32144(fixture, scriptBlockLogging, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 32161, 32254);

                scriptBlockLogging = f_959_32182_32253(Utils.CurrentUserOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 32268, 32370);

                f_959_32268_32369(fixture, scriptBlockLogging, f_959_32322_32368(f_959_32322_32349(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 32386, 32489);

                scriptBlockLogging = f_959_32407_32488(Utils.SystemWideThenCurrentUserConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 32503, 32605);

                f_959_32503_32604(fixture, scriptBlockLogging, f_959_32557_32603(f_959_32557_32584(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 32621, 32724);

                scriptBlockLogging = f_959_32642_32723(Utils.CurrentUserThenSystemWideConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 32738, 32840);

                f_959_32738_32839(fixture, scriptBlockLogging, f_959_32792_32838(f_959_32792_32819(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 32856, 32884);

                ModuleLogging
                moduleLogging
                = default(ModuleLogging);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 32898, 32980);

                moduleLogging = f_959_32914_32979(Utils.SystemWideOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 32994, 33044);

                f_959_32994_33043(fixture, moduleLogging, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 33060, 33143);

                moduleLogging = f_959_33076_33142(Utils.CurrentUserOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 33157, 33244);

                f_959_33157_33243(fixture, moduleLogging, f_959_33201_33242(f_959_33201_33228(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 33260, 33353);

                moduleLogging = f_959_33276_33352(Utils.SystemWideThenCurrentUserConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 33367, 33454);

                f_959_33367_33453(fixture, moduleLogging, f_959_33411_33452(f_959_33411_33438(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 33470, 33563);

                moduleLogging = f_959_33486_33562(Utils.CurrentUserThenSystemWideConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 33577, 33664);

                f_959_33577_33663(fixture, moduleLogging, f_959_33621_33662(f_959_33621_33648(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 33680, 33724);

                ProtectedEventLogging
                protectedEventLogging
                = default(ProtectedEventLogging);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 33738, 33836);

                protectedEventLogging = f_959_33762_33835(Utils.SystemWideOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 33850, 33916);

                f_959_33850_33915(fixture, protectedEventLogging, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 33932, 34031);

                protectedEventLogging = f_959_33956_34030(Utils.CurrentUserOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 34045, 34156);

                f_959_34045_34155(fixture, protectedEventLogging, f_959_34105_34154(f_959_34105_34132(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 34172, 34281);

                protectedEventLogging = f_959_34196_34280(Utils.SystemWideThenCurrentUserConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 34295, 34406);

                f_959_34295_34405(fixture, protectedEventLogging, f_959_34355_34404(f_959_34355_34382(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 34422, 34531);

                protectedEventLogging = f_959_34446_34530(Utils.CurrentUserThenSystemWideConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 34545, 34656);

                f_959_34545_34655(fixture, protectedEventLogging, f_959_34605_34654(f_959_34605_34632(fixture)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 34811, 34839);

                Transcription
                transcription
                = default(Transcription);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 34853, 34935);

                transcription = f_959_34869_34934(Utils.SystemWideOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 34949, 34999);

                f_959_34949_34998(fixture, transcription, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 35015, 35098);

                transcription = f_959_35031_35097(Utils.CurrentUserOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 35112, 35162);

                f_959_35112_35161(fixture, transcription, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 35178, 35271);

                transcription = f_959_35194_35270(Utils.SystemWideThenCurrentUserConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 35285, 35335);

                f_959_35285_35334(fixture, transcription, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 35351, 35444);

                transcription = f_959_35367_35443(Utils.CurrentUserThenSystemWideConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 35458, 35508);

                f_959_35458_35507(fixture, transcription, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 35524, 35552);

                UpdatableHelp
                updatableHelp
                = default(UpdatableHelp);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 35566, 35648);

                updatableHelp = f_959_35582_35647(Utils.SystemWideOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 35662, 35712);

                f_959_35662_35711(fixture, updatableHelp, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 35728, 35811);

                updatableHelp = f_959_35744_35810(Utils.CurrentUserOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 35825, 35875);

                f_959_35825_35874(fixture, updatableHelp, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 35891, 35984);

                updatableHelp = f_959_35907_35983(Utils.SystemWideThenCurrentUserConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 35998, 36048);

                f_959_35998_36047(fixture, updatableHelp, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 36064, 36157);

                updatableHelp = f_959_36080_36156(Utils.CurrentUserThenSystemWideConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 36171, 36221);

                f_959_36171_36220(fixture, updatableHelp, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 36237, 36293);

                ConsoleSessionConfiguration
                consoleSessionConfiguration
                = default(ConsoleSessionConfiguration);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 36307, 36417);

                consoleSessionConfiguration = f_959_36337_36416(Utils.SystemWideOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 36431, 36509);

                f_959_36431_36508(fixture, consoleSessionConfiguration, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 36525, 36636);

                consoleSessionConfiguration = f_959_36555_36635(Utils.CurrentUserOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 36650, 36728);

                f_959_36650_36727(fixture, consoleSessionConfiguration, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 36744, 36865);

                consoleSessionConfiguration = f_959_36774_36864(Utils.SystemWideThenCurrentUserConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 36879, 36957);

                f_959_36879_36956(fixture, consoleSessionConfiguration, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 36973, 37094);

                consoleSessionConfiguration = f_959_37003_37093(Utils.CurrentUserThenSystemWideConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 37108, 37186);

                f_959_37108_37185(fixture, consoleSessionConfiguration, null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(959, 30814, 37197);

                int
                f_959_30926_30952(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    this_param.SetupConfigFile3();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 30926, 30952);
                    return 0;
                }


                int
                f_959_30967_30997(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    this_param.ForceReadingFromFile();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 30967, 30997);
                    return 0;
                }


                System.Management.Automation.Configuration.ScriptExecution
                f_959_31125_31192(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ScriptExecution>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 31125, 31192);
                    return return_v;
                }


                int
                f_959_31207_31260(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ScriptExecution
                a, System.Management.Automation.Configuration.ScriptExecution
                b)
                {
                    this_param.CompareScriptExecution(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 31207, 31260);
                    return 0;
                }


                System.Management.Automation.Configuration.ScriptExecution
                f_959_31295_31363(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ScriptExecution>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 31295, 31363);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_31426_31453(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.CurrentUserPolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 31426, 31453);
                    return return_v;
                }


                System.Management.Automation.Configuration.ScriptExecution
                f_959_31426_31469(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ScriptExecution;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 31426, 31469);
                    return return_v;
                }


                int
                f_959_31378_31470(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ScriptExecution
                a, System.Management.Automation.Configuration.ScriptExecution
                b)
                {
                    this_param.CompareScriptExecution(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 31378, 31470);
                    return 0;
                }


                System.Management.Automation.Configuration.ScriptExecution
                f_959_31505_31583(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ScriptExecution>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 31505, 31583);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_31646_31673(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.CurrentUserPolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 31646, 31673);
                    return return_v;
                }


                System.Management.Automation.Configuration.ScriptExecution
                f_959_31646_31689(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ScriptExecution;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 31646, 31689);
                    return return_v;
                }


                int
                f_959_31598_31690(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ScriptExecution
                a, System.Management.Automation.Configuration.ScriptExecution
                b)
                {
                    this_param.CompareScriptExecution(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 31598, 31690);
                    return 0;
                }


                System.Management.Automation.Configuration.ScriptExecution
                f_959_31725_31803(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ScriptExecution>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 31725, 31803);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_31866_31893(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.CurrentUserPolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 31866, 31893);
                    return return_v;
                }


                System.Management.Automation.Configuration.ScriptExecution
                f_959_31866_31909(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ScriptExecution;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 31866, 31909);
                    return return_v;
                }


                int
                f_959_31818_31910(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ScriptExecution
                a, System.Management.Automation.Configuration.ScriptExecution
                b)
                {
                    this_param.CompareScriptExecution(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 31818, 31910);
                    return 0;
                }


                System.Management.Automation.Configuration.ScriptBlockLogging
                f_959_32000_32070(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ScriptBlockLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 32000, 32070);
                    return return_v;
                }


                int
                f_959_32085_32144(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ScriptBlockLogging
                a, System.Management.Automation.Configuration.ScriptBlockLogging
                b)
                {
                    this_param.CompareScriptBlockLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 32085, 32144);
                    return 0;
                }


                System.Management.Automation.Configuration.ScriptBlockLogging
                f_959_32182_32253(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ScriptBlockLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 32182, 32253);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_32322_32349(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.CurrentUserPolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 32322, 32349);
                    return return_v;
                }


                System.Management.Automation.Configuration.ScriptBlockLogging
                f_959_32322_32368(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ScriptBlockLogging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 32322, 32368);
                    return return_v;
                }


                int
                f_959_32268_32369(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ScriptBlockLogging
                a, System.Management.Automation.Configuration.ScriptBlockLogging
                b)
                {
                    this_param.CompareScriptBlockLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 32268, 32369);
                    return 0;
                }


                System.Management.Automation.Configuration.ScriptBlockLogging
                f_959_32407_32488(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ScriptBlockLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 32407, 32488);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_32557_32584(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.CurrentUserPolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 32557, 32584);
                    return return_v;
                }


                System.Management.Automation.Configuration.ScriptBlockLogging
                f_959_32557_32603(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ScriptBlockLogging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 32557, 32603);
                    return return_v;
                }


                int
                f_959_32503_32604(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ScriptBlockLogging
                a, System.Management.Automation.Configuration.ScriptBlockLogging
                b)
                {
                    this_param.CompareScriptBlockLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 32503, 32604);
                    return 0;
                }


                System.Management.Automation.Configuration.ScriptBlockLogging
                f_959_32642_32723(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ScriptBlockLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 32642, 32723);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_32792_32819(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.CurrentUserPolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 32792, 32819);
                    return return_v;
                }


                System.Management.Automation.Configuration.ScriptBlockLogging
                f_959_32792_32838(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ScriptBlockLogging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 32792, 32838);
                    return return_v;
                }


                int
                f_959_32738_32839(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ScriptBlockLogging
                a, System.Management.Automation.Configuration.ScriptBlockLogging
                b)
                {
                    this_param.CompareScriptBlockLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 32738, 32839);
                    return 0;
                }


                System.Management.Automation.Configuration.ModuleLogging
                f_959_32914_32979(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ModuleLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 32914, 32979);
                    return return_v;
                }


                int
                f_959_32994_33043(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ModuleLogging
                a, System.Management.Automation.Configuration.ModuleLogging
                b)
                {
                    this_param.CompareModuleLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 32994, 33043);
                    return 0;
                }


                System.Management.Automation.Configuration.ModuleLogging
                f_959_33076_33142(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ModuleLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 33076, 33142);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_33201_33228(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.CurrentUserPolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 33201, 33228);
                    return return_v;
                }


                System.Management.Automation.Configuration.ModuleLogging
                f_959_33201_33242(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ModuleLogging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 33201, 33242);
                    return return_v;
                }


                int
                f_959_33157_33243(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ModuleLogging
                a, System.Management.Automation.Configuration.ModuleLogging
                b)
                {
                    this_param.CompareModuleLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 33157, 33243);
                    return 0;
                }


                System.Management.Automation.Configuration.ModuleLogging
                f_959_33276_33352(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ModuleLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 33276, 33352);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_33411_33438(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.CurrentUserPolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 33411, 33438);
                    return return_v;
                }


                System.Management.Automation.Configuration.ModuleLogging
                f_959_33411_33452(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ModuleLogging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 33411, 33452);
                    return return_v;
                }


                int
                f_959_33367_33453(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ModuleLogging
                a, System.Management.Automation.Configuration.ModuleLogging
                b)
                {
                    this_param.CompareModuleLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 33367, 33453);
                    return 0;
                }


                System.Management.Automation.Configuration.ModuleLogging
                f_959_33486_33562(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ModuleLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 33486, 33562);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_33621_33648(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.CurrentUserPolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 33621, 33648);
                    return return_v;
                }


                System.Management.Automation.Configuration.ModuleLogging
                f_959_33621_33662(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ModuleLogging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 33621, 33662);
                    return return_v;
                }


                int
                f_959_33577_33663(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ModuleLogging
                a, System.Management.Automation.Configuration.ModuleLogging
                b)
                {
                    this_param.CompareModuleLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 33577, 33663);
                    return 0;
                }


                System.Management.Automation.Configuration.ProtectedEventLogging
                f_959_33762_33835(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ProtectedEventLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 33762, 33835);
                    return return_v;
                }


                int
                f_959_33850_33915(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ProtectedEventLogging
                a, System.Management.Automation.Configuration.ProtectedEventLogging
                b)
                {
                    this_param.CompareProtectedEventLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 33850, 33915);
                    return 0;
                }


                System.Management.Automation.Configuration.ProtectedEventLogging
                f_959_33956_34030(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ProtectedEventLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 33956, 34030);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_34105_34132(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.CurrentUserPolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 34105, 34132);
                    return return_v;
                }


                System.Management.Automation.Configuration.ProtectedEventLogging
                f_959_34105_34154(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ProtectedEventLogging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 34105, 34154);
                    return return_v;
                }


                int
                f_959_34045_34155(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ProtectedEventLogging
                a, System.Management.Automation.Configuration.ProtectedEventLogging
                b)
                {
                    this_param.CompareProtectedEventLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 34045, 34155);
                    return 0;
                }


                System.Management.Automation.Configuration.ProtectedEventLogging
                f_959_34196_34280(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ProtectedEventLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 34196, 34280);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_34355_34382(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.CurrentUserPolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 34355, 34382);
                    return return_v;
                }


                System.Management.Automation.Configuration.ProtectedEventLogging
                f_959_34355_34404(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ProtectedEventLogging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 34355, 34404);
                    return return_v;
                }


                int
                f_959_34295_34405(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ProtectedEventLogging
                a, System.Management.Automation.Configuration.ProtectedEventLogging
                b)
                {
                    this_param.CompareProtectedEventLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 34295, 34405);
                    return 0;
                }


                System.Management.Automation.Configuration.ProtectedEventLogging
                f_959_34446_34530(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ProtectedEventLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 34446, 34530);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_959_34605_34632(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    var return_v = this_param.CurrentUserPolicies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 34605, 34632);
                    return return_v;
                }


                System.Management.Automation.Configuration.ProtectedEventLogging
                f_959_34605_34654(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ProtectedEventLogging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(959, 34605, 34654);
                    return return_v;
                }


                int
                f_959_34545_34655(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ProtectedEventLogging
                a, System.Management.Automation.Configuration.ProtectedEventLogging
                b)
                {
                    this_param.CompareProtectedEventLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 34545, 34655);
                    return 0;
                }


                System.Management.Automation.Configuration.Transcription
                f_959_34869_34934(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<Transcription>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 34869, 34934);
                    return return_v;
                }


                int
                f_959_34949_34998(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.Transcription
                a, System.Management.Automation.Configuration.Transcription
                b)
                {
                    this_param.CompareTranscription(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 34949, 34998);
                    return 0;
                }


                System.Management.Automation.Configuration.Transcription
                f_959_35031_35097(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<Transcription>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 35031, 35097);
                    return return_v;
                }


                int
                f_959_35112_35161(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.Transcription
                a, System.Management.Automation.Configuration.Transcription
                b)
                {
                    this_param.CompareTranscription(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 35112, 35161);
                    return 0;
                }


                System.Management.Automation.Configuration.Transcription
                f_959_35194_35270(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<Transcription>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 35194, 35270);
                    return return_v;
                }


                int
                f_959_35285_35334(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.Transcription
                a, System.Management.Automation.Configuration.Transcription
                b)
                {
                    this_param.CompareTranscription(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 35285, 35334);
                    return 0;
                }


                System.Management.Automation.Configuration.Transcription
                f_959_35367_35443(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<Transcription>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 35367, 35443);
                    return return_v;
                }


                int
                f_959_35458_35507(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.Transcription
                a, System.Management.Automation.Configuration.Transcription
                b)
                {
                    this_param.CompareTranscription(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 35458, 35507);
                    return 0;
                }


                System.Management.Automation.Configuration.UpdatableHelp
                f_959_35582_35647(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<UpdatableHelp>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 35582, 35647);
                    return return_v;
                }


                int
                f_959_35662_35711(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.UpdatableHelp
                a, System.Management.Automation.Configuration.UpdatableHelp
                b)
                {
                    this_param.CompareUpdatableHelp(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 35662, 35711);
                    return 0;
                }


                System.Management.Automation.Configuration.UpdatableHelp
                f_959_35744_35810(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<UpdatableHelp>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 35744, 35810);
                    return return_v;
                }


                int
                f_959_35825_35874(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.UpdatableHelp
                a, System.Management.Automation.Configuration.UpdatableHelp
                b)
                {
                    this_param.CompareUpdatableHelp(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 35825, 35874);
                    return 0;
                }


                System.Management.Automation.Configuration.UpdatableHelp
                f_959_35907_35983(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<UpdatableHelp>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 35907, 35983);
                    return return_v;
                }


                int
                f_959_35998_36047(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.UpdatableHelp
                a, System.Management.Automation.Configuration.UpdatableHelp
                b)
                {
                    this_param.CompareUpdatableHelp(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 35998, 36047);
                    return 0;
                }


                System.Management.Automation.Configuration.UpdatableHelp
                f_959_36080_36156(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<UpdatableHelp>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 36080, 36156);
                    return return_v;
                }


                int
                f_959_36171_36220(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.UpdatableHelp
                a, System.Management.Automation.Configuration.UpdatableHelp
                b)
                {
                    this_param.CompareUpdatableHelp(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 36171, 36220);
                    return 0;
                }


                System.Management.Automation.Configuration.ConsoleSessionConfiguration
                f_959_36337_36416(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ConsoleSessionConfiguration>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 36337, 36416);
                    return return_v;
                }


                int
                f_959_36431_36508(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ConsoleSessionConfiguration
                a, System.Management.Automation.Configuration.ConsoleSessionConfiguration
                b)
                {
                    this_param.CompareConsoleSessionConfiguration(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 36431, 36508);
                    return 0;
                }


                System.Management.Automation.Configuration.ConsoleSessionConfiguration
                f_959_36555_36635(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ConsoleSessionConfiguration>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 36555, 36635);
                    return return_v;
                }


                int
                f_959_36650_36727(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ConsoleSessionConfiguration
                a, System.Management.Automation.Configuration.ConsoleSessionConfiguration
                b)
                {
                    this_param.CompareConsoleSessionConfiguration(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 36650, 36727);
                    return 0;
                }


                System.Management.Automation.Configuration.ConsoleSessionConfiguration
                f_959_36774_36864(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ConsoleSessionConfiguration>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 36774, 36864);
                    return return_v;
                }


                int
                f_959_36879_36956(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ConsoleSessionConfiguration
                a, System.Management.Automation.Configuration.ConsoleSessionConfiguration
                b)
                {
                    this_param.CompareConsoleSessionConfiguration(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 36879, 36956);
                    return 0;
                }


                System.Management.Automation.Configuration.ConsoleSessionConfiguration
                f_959_37003_37093(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ConsoleSessionConfiguration>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 37003, 37093);
                    return return_v;
                }


                int
                f_959_37108_37185(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ConsoleSessionConfiguration
                a, System.Management.Automation.Configuration.ConsoleSessionConfiguration
                b)
                {
                    this_param.CompareConsoleSessionConfiguration(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 37108, 37185);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(959, 30814, 37197);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(959, 30814, 37197);
            }
        }

        [Fact, TestPriority(9)]
        public void Utils_GetPolicySetting_BothConfigFilesEmpty()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(959, 37209, 43103);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 37324, 37351);

                f_959_37324_37350(fixture);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 37365, 37396);

                f_959_37365_37395(fixture);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 37456, 37488);

                ScriptExecution
                scriptExecution
                = default(ScriptExecution);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 37502, 37588);

                scriptExecution = f_959_37520_37587(Utils.SystemWideOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 37602, 37656);

                f_959_37602_37655(fixture, scriptExecution, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 37672, 37759);

                scriptExecution = f_959_37690_37758(Utils.CurrentUserOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 37773, 37827);

                f_959_37773_37826(fixture, scriptExecution, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 37843, 37940);

                scriptExecution = f_959_37861_37939(Utils.SystemWideThenCurrentUserConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 37954, 38008);

                f_959_37954_38007(fixture, scriptExecution, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 38024, 38121);

                scriptExecution = f_959_38042_38120(Utils.CurrentUserThenSystemWideConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 38135, 38189);

                f_959_38135_38188(fixture, scriptExecution, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 38205, 38243);

                ScriptBlockLogging
                scriptBlockLogging
                = default(ScriptBlockLogging);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 38257, 38349);

                scriptBlockLogging = f_959_38278_38348(Utils.SystemWideOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 38363, 38423);

                f_959_38363_38422(fixture, scriptBlockLogging, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 38439, 38532);

                scriptBlockLogging = f_959_38460_38531(Utils.CurrentUserOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 38546, 38606);

                f_959_38546_38605(fixture, scriptBlockLogging, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 38622, 38725);

                scriptBlockLogging = f_959_38643_38724(Utils.SystemWideThenCurrentUserConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 38739, 38799);

                f_959_38739_38798(fixture, scriptBlockLogging, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 38815, 38918);

                scriptBlockLogging = f_959_38836_38917(Utils.CurrentUserThenSystemWideConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 38932, 38992);

                f_959_38932_38991(fixture, scriptBlockLogging, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 39008, 39036);

                ModuleLogging
                moduleLogging
                = default(ModuleLogging);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 39050, 39132);

                moduleLogging = f_959_39066_39131(Utils.SystemWideOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 39146, 39196);

                f_959_39146_39195(fixture, moduleLogging, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 39212, 39295);

                moduleLogging = f_959_39228_39294(Utils.CurrentUserOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 39309, 39359);

                f_959_39309_39358(fixture, moduleLogging, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 39375, 39468);

                moduleLogging = f_959_39391_39467(Utils.SystemWideThenCurrentUserConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 39482, 39532);

                f_959_39482_39531(fixture, moduleLogging, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 39548, 39641);

                moduleLogging = f_959_39564_39640(Utils.CurrentUserThenSystemWideConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 39655, 39705);

                f_959_39655_39704(fixture, moduleLogging, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 39721, 39765);

                ProtectedEventLogging
                protectedEventLogging
                = default(ProtectedEventLogging);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 39779, 39877);

                protectedEventLogging = f_959_39803_39876(Utils.SystemWideOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 39891, 39957);

                f_959_39891_39956(fixture, protectedEventLogging, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 39973, 40072);

                protectedEventLogging = f_959_39997_40071(Utils.CurrentUserOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 40086, 40152);

                f_959_40086_40151(fixture, protectedEventLogging, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 40168, 40277);

                protectedEventLogging = f_959_40192_40276(Utils.SystemWideThenCurrentUserConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 40291, 40357);

                f_959_40291_40356(fixture, protectedEventLogging, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 40373, 40482);

                protectedEventLogging = f_959_40397_40481(Utils.CurrentUserThenSystemWideConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 40496, 40562);

                f_959_40496_40561(fixture, protectedEventLogging, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 40717, 40745);

                Transcription
                transcription
                = default(Transcription);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 40759, 40841);

                transcription = f_959_40775_40840(Utils.SystemWideOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 40855, 40905);

                f_959_40855_40904(fixture, transcription, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 40921, 41004);

                transcription = f_959_40937_41003(Utils.CurrentUserOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 41018, 41068);

                f_959_41018_41067(fixture, transcription, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 41084, 41177);

                transcription = f_959_41100_41176(Utils.SystemWideThenCurrentUserConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 41191, 41241);

                f_959_41191_41240(fixture, transcription, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 41257, 41350);

                transcription = f_959_41273_41349(Utils.CurrentUserThenSystemWideConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 41364, 41414);

                f_959_41364_41413(fixture, transcription, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 41430, 41458);

                UpdatableHelp
                updatableHelp
                = default(UpdatableHelp);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 41472, 41554);

                updatableHelp = f_959_41488_41553(Utils.SystemWideOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 41568, 41618);

                f_959_41568_41617(fixture, updatableHelp, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 41634, 41717);

                updatableHelp = f_959_41650_41716(Utils.CurrentUserOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 41731, 41781);

                f_959_41731_41780(fixture, updatableHelp, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 41797, 41890);

                updatableHelp = f_959_41813_41889(Utils.SystemWideThenCurrentUserConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 41904, 41954);

                f_959_41904_41953(fixture, updatableHelp, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 41970, 42063);

                updatableHelp = f_959_41986_42062(Utils.CurrentUserThenSystemWideConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 42077, 42127);

                f_959_42077_42126(fixture, updatableHelp, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 42143, 42199);

                ConsoleSessionConfiguration
                consoleSessionConfiguration
                = default(ConsoleSessionConfiguration);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 42213, 42323);

                consoleSessionConfiguration = f_959_42243_42322(Utils.SystemWideOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 42337, 42415);

                f_959_42337_42414(fixture, consoleSessionConfiguration, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 42431, 42542);

                consoleSessionConfiguration = f_959_42461_42541(Utils.CurrentUserOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 42556, 42634);

                f_959_42556_42633(fixture, consoleSessionConfiguration, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 42650, 42771);

                consoleSessionConfiguration = f_959_42680_42770(Utils.SystemWideThenCurrentUserConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 42785, 42863);

                f_959_42785_42862(fixture, consoleSessionConfiguration, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 42879, 43000);

                consoleSessionConfiguration = f_959_42909_42999(Utils.CurrentUserThenSystemWideConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 43014, 43092);

                f_959_43014_43091(fixture, consoleSessionConfiguration, null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(959, 37209, 43103);

                int
                f_959_37324_37350(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    this_param.SetupConfigFile4();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 37324, 37350);
                    return 0;
                }


                int
                f_959_37365_37395(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    this_param.ForceReadingFromFile();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 37365, 37395);
                    return 0;
                }


                System.Management.Automation.Configuration.ScriptExecution
                f_959_37520_37587(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ScriptExecution>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 37520, 37587);
                    return return_v;
                }


                int
                f_959_37602_37655(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ScriptExecution
                a, System.Management.Automation.Configuration.ScriptExecution
                b)
                {
                    this_param.CompareScriptExecution(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 37602, 37655);
                    return 0;
                }


                System.Management.Automation.Configuration.ScriptExecution
                f_959_37690_37758(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ScriptExecution>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 37690, 37758);
                    return return_v;
                }


                int
                f_959_37773_37826(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ScriptExecution
                a, System.Management.Automation.Configuration.ScriptExecution
                b)
                {
                    this_param.CompareScriptExecution(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 37773, 37826);
                    return 0;
                }


                System.Management.Automation.Configuration.ScriptExecution
                f_959_37861_37939(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ScriptExecution>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 37861, 37939);
                    return return_v;
                }


                int
                f_959_37954_38007(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ScriptExecution
                a, System.Management.Automation.Configuration.ScriptExecution
                b)
                {
                    this_param.CompareScriptExecution(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 37954, 38007);
                    return 0;
                }


                System.Management.Automation.Configuration.ScriptExecution
                f_959_38042_38120(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ScriptExecution>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 38042, 38120);
                    return return_v;
                }


                int
                f_959_38135_38188(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ScriptExecution
                a, System.Management.Automation.Configuration.ScriptExecution
                b)
                {
                    this_param.CompareScriptExecution(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 38135, 38188);
                    return 0;
                }


                System.Management.Automation.Configuration.ScriptBlockLogging
                f_959_38278_38348(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ScriptBlockLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 38278, 38348);
                    return return_v;
                }


                int
                f_959_38363_38422(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ScriptBlockLogging
                a, System.Management.Automation.Configuration.ScriptBlockLogging
                b)
                {
                    this_param.CompareScriptBlockLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 38363, 38422);
                    return 0;
                }


                System.Management.Automation.Configuration.ScriptBlockLogging
                f_959_38460_38531(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ScriptBlockLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 38460, 38531);
                    return return_v;
                }


                int
                f_959_38546_38605(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ScriptBlockLogging
                a, System.Management.Automation.Configuration.ScriptBlockLogging
                b)
                {
                    this_param.CompareScriptBlockLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 38546, 38605);
                    return 0;
                }


                System.Management.Automation.Configuration.ScriptBlockLogging
                f_959_38643_38724(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ScriptBlockLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 38643, 38724);
                    return return_v;
                }


                int
                f_959_38739_38798(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ScriptBlockLogging
                a, System.Management.Automation.Configuration.ScriptBlockLogging
                b)
                {
                    this_param.CompareScriptBlockLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 38739, 38798);
                    return 0;
                }


                System.Management.Automation.Configuration.ScriptBlockLogging
                f_959_38836_38917(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ScriptBlockLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 38836, 38917);
                    return return_v;
                }


                int
                f_959_38932_38991(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ScriptBlockLogging
                a, System.Management.Automation.Configuration.ScriptBlockLogging
                b)
                {
                    this_param.CompareScriptBlockLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 38932, 38991);
                    return 0;
                }


                System.Management.Automation.Configuration.ModuleLogging
                f_959_39066_39131(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ModuleLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 39066, 39131);
                    return return_v;
                }


                int
                f_959_39146_39195(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ModuleLogging
                a, System.Management.Automation.Configuration.ModuleLogging
                b)
                {
                    this_param.CompareModuleLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 39146, 39195);
                    return 0;
                }


                System.Management.Automation.Configuration.ModuleLogging
                f_959_39228_39294(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ModuleLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 39228, 39294);
                    return return_v;
                }


                int
                f_959_39309_39358(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ModuleLogging
                a, System.Management.Automation.Configuration.ModuleLogging
                b)
                {
                    this_param.CompareModuleLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 39309, 39358);
                    return 0;
                }


                System.Management.Automation.Configuration.ModuleLogging
                f_959_39391_39467(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ModuleLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 39391, 39467);
                    return return_v;
                }


                int
                f_959_39482_39531(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ModuleLogging
                a, System.Management.Automation.Configuration.ModuleLogging
                b)
                {
                    this_param.CompareModuleLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 39482, 39531);
                    return 0;
                }


                System.Management.Automation.Configuration.ModuleLogging
                f_959_39564_39640(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ModuleLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 39564, 39640);
                    return return_v;
                }


                int
                f_959_39655_39704(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ModuleLogging
                a, System.Management.Automation.Configuration.ModuleLogging
                b)
                {
                    this_param.CompareModuleLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 39655, 39704);
                    return 0;
                }


                System.Management.Automation.Configuration.ProtectedEventLogging
                f_959_39803_39876(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ProtectedEventLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 39803, 39876);
                    return return_v;
                }


                int
                f_959_39891_39956(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ProtectedEventLogging
                a, System.Management.Automation.Configuration.ProtectedEventLogging
                b)
                {
                    this_param.CompareProtectedEventLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 39891, 39956);
                    return 0;
                }


                System.Management.Automation.Configuration.ProtectedEventLogging
                f_959_39997_40071(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ProtectedEventLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 39997, 40071);
                    return return_v;
                }


                int
                f_959_40086_40151(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ProtectedEventLogging
                a, System.Management.Automation.Configuration.ProtectedEventLogging
                b)
                {
                    this_param.CompareProtectedEventLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 40086, 40151);
                    return 0;
                }


                System.Management.Automation.Configuration.ProtectedEventLogging
                f_959_40192_40276(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ProtectedEventLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 40192, 40276);
                    return return_v;
                }


                int
                f_959_40291_40356(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ProtectedEventLogging
                a, System.Management.Automation.Configuration.ProtectedEventLogging
                b)
                {
                    this_param.CompareProtectedEventLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 40291, 40356);
                    return 0;
                }


                System.Management.Automation.Configuration.ProtectedEventLogging
                f_959_40397_40481(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ProtectedEventLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 40397, 40481);
                    return return_v;
                }


                int
                f_959_40496_40561(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ProtectedEventLogging
                a, System.Management.Automation.Configuration.ProtectedEventLogging
                b)
                {
                    this_param.CompareProtectedEventLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 40496, 40561);
                    return 0;
                }


                System.Management.Automation.Configuration.Transcription
                f_959_40775_40840(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<Transcription>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 40775, 40840);
                    return return_v;
                }


                int
                f_959_40855_40904(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.Transcription
                a, System.Management.Automation.Configuration.Transcription
                b)
                {
                    this_param.CompareTranscription(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 40855, 40904);
                    return 0;
                }


                System.Management.Automation.Configuration.Transcription
                f_959_40937_41003(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<Transcription>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 40937, 41003);
                    return return_v;
                }


                int
                f_959_41018_41067(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.Transcription
                a, System.Management.Automation.Configuration.Transcription
                b)
                {
                    this_param.CompareTranscription(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 41018, 41067);
                    return 0;
                }


                System.Management.Automation.Configuration.Transcription
                f_959_41100_41176(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<Transcription>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 41100, 41176);
                    return return_v;
                }


                int
                f_959_41191_41240(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.Transcription
                a, System.Management.Automation.Configuration.Transcription
                b)
                {
                    this_param.CompareTranscription(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 41191, 41240);
                    return 0;
                }


                System.Management.Automation.Configuration.Transcription
                f_959_41273_41349(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<Transcription>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 41273, 41349);
                    return return_v;
                }


                int
                f_959_41364_41413(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.Transcription
                a, System.Management.Automation.Configuration.Transcription
                b)
                {
                    this_param.CompareTranscription(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 41364, 41413);
                    return 0;
                }


                System.Management.Automation.Configuration.UpdatableHelp
                f_959_41488_41553(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<UpdatableHelp>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 41488, 41553);
                    return return_v;
                }


                int
                f_959_41568_41617(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.UpdatableHelp
                a, System.Management.Automation.Configuration.UpdatableHelp
                b)
                {
                    this_param.CompareUpdatableHelp(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 41568, 41617);
                    return 0;
                }


                System.Management.Automation.Configuration.UpdatableHelp
                f_959_41650_41716(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<UpdatableHelp>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 41650, 41716);
                    return return_v;
                }


                int
                f_959_41731_41780(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.UpdatableHelp
                a, System.Management.Automation.Configuration.UpdatableHelp
                b)
                {
                    this_param.CompareUpdatableHelp(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 41731, 41780);
                    return 0;
                }


                System.Management.Automation.Configuration.UpdatableHelp
                f_959_41813_41889(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<UpdatableHelp>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 41813, 41889);
                    return return_v;
                }


                int
                f_959_41904_41953(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.UpdatableHelp
                a, System.Management.Automation.Configuration.UpdatableHelp
                b)
                {
                    this_param.CompareUpdatableHelp(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 41904, 41953);
                    return 0;
                }


                System.Management.Automation.Configuration.UpdatableHelp
                f_959_41986_42062(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<UpdatableHelp>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 41986, 42062);
                    return return_v;
                }


                int
                f_959_42077_42126(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.UpdatableHelp
                a, System.Management.Automation.Configuration.UpdatableHelp
                b)
                {
                    this_param.CompareUpdatableHelp(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 42077, 42126);
                    return 0;
                }


                System.Management.Automation.Configuration.ConsoleSessionConfiguration
                f_959_42243_42322(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ConsoleSessionConfiguration>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 42243, 42322);
                    return return_v;
                }


                int
                f_959_42337_42414(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ConsoleSessionConfiguration
                a, System.Management.Automation.Configuration.ConsoleSessionConfiguration
                b)
                {
                    this_param.CompareConsoleSessionConfiguration(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 42337, 42414);
                    return 0;
                }


                System.Management.Automation.Configuration.ConsoleSessionConfiguration
                f_959_42461_42541(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ConsoleSessionConfiguration>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 42461, 42541);
                    return return_v;
                }


                int
                f_959_42556_42633(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ConsoleSessionConfiguration
                a, System.Management.Automation.Configuration.ConsoleSessionConfiguration
                b)
                {
                    this_param.CompareConsoleSessionConfiguration(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 42556, 42633);
                    return 0;
                }


                System.Management.Automation.Configuration.ConsoleSessionConfiguration
                f_959_42680_42770(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ConsoleSessionConfiguration>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 42680, 42770);
                    return return_v;
                }


                int
                f_959_42785_42862(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ConsoleSessionConfiguration
                a, System.Management.Automation.Configuration.ConsoleSessionConfiguration
                b)
                {
                    this_param.CompareConsoleSessionConfiguration(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 42785, 42862);
                    return 0;
                }


                System.Management.Automation.Configuration.ConsoleSessionConfiguration
                f_959_42909_42999(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ConsoleSessionConfiguration>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 42909, 42999);
                    return return_v;
                }


                int
                f_959_43014_43091(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ConsoleSessionConfiguration
                a, System.Management.Automation.Configuration.ConsoleSessionConfiguration
                b)
                {
                    this_param.CompareConsoleSessionConfiguration(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 43014, 43091);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(959, 37209, 43103);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(959, 37209, 43103);
            }
        }

        [Fact, TestPriority(10)]
        public void Utils_GetPolicySetting_BothConfigFilesNotExist()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(959, 43115, 49017);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 43234, 43263);

                f_959_43234_43262(fixture);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 43277, 43308);

                f_959_43277_43307(fixture);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 43370, 43402);

                ScriptExecution
                scriptExecution
                = default(ScriptExecution);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 43416, 43502);

                scriptExecution = f_959_43434_43501(Utils.SystemWideOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 43516, 43570);

                f_959_43516_43569(fixture, scriptExecution, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 43586, 43673);

                scriptExecution = f_959_43604_43672(Utils.CurrentUserOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 43687, 43741);

                f_959_43687_43740(fixture, scriptExecution, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 43757, 43854);

                scriptExecution = f_959_43775_43853(Utils.SystemWideThenCurrentUserConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 43868, 43922);

                f_959_43868_43921(fixture, scriptExecution, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 43938, 44035);

                scriptExecution = f_959_43956_44034(Utils.CurrentUserThenSystemWideConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 44049, 44103);

                f_959_44049_44102(fixture, scriptExecution, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 44119, 44157);

                ScriptBlockLogging
                scriptBlockLogging
                = default(ScriptBlockLogging);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 44171, 44263);

                scriptBlockLogging = f_959_44192_44262(Utils.SystemWideOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 44277, 44337);

                f_959_44277_44336(fixture, scriptBlockLogging, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 44353, 44446);

                scriptBlockLogging = f_959_44374_44445(Utils.CurrentUserOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 44460, 44520);

                f_959_44460_44519(fixture, scriptBlockLogging, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 44536, 44639);

                scriptBlockLogging = f_959_44557_44638(Utils.SystemWideThenCurrentUserConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 44653, 44713);

                f_959_44653_44712(fixture, scriptBlockLogging, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 44729, 44832);

                scriptBlockLogging = f_959_44750_44831(Utils.CurrentUserThenSystemWideConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 44846, 44906);

                f_959_44846_44905(fixture, scriptBlockLogging, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 44922, 44950);

                ModuleLogging
                moduleLogging
                = default(ModuleLogging);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 44964, 45046);

                moduleLogging = f_959_44980_45045(Utils.SystemWideOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 45060, 45110);

                f_959_45060_45109(fixture, moduleLogging, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 45126, 45209);

                moduleLogging = f_959_45142_45208(Utils.CurrentUserOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 45223, 45273);

                f_959_45223_45272(fixture, moduleLogging, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 45289, 45382);

                moduleLogging = f_959_45305_45381(Utils.SystemWideThenCurrentUserConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 45396, 45446);

                f_959_45396_45445(fixture, moduleLogging, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 45462, 45555);

                moduleLogging = f_959_45478_45554(Utils.CurrentUserThenSystemWideConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 45569, 45619);

                f_959_45569_45618(fixture, moduleLogging, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 45635, 45679);

                ProtectedEventLogging
                protectedEventLogging
                = default(ProtectedEventLogging);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 45693, 45791);

                protectedEventLogging = f_959_45717_45790(Utils.SystemWideOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 45805, 45871);

                f_959_45805_45870(fixture, protectedEventLogging, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 45887, 45986);

                protectedEventLogging = f_959_45911_45985(Utils.CurrentUserOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 46000, 46066);

                f_959_46000_46065(fixture, protectedEventLogging, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 46082, 46191);

                protectedEventLogging = f_959_46106_46190(Utils.SystemWideThenCurrentUserConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 46205, 46271);

                f_959_46205_46270(fixture, protectedEventLogging, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 46287, 46396);

                protectedEventLogging = f_959_46311_46395(Utils.CurrentUserThenSystemWideConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 46410, 46476);

                f_959_46410_46475(fixture, protectedEventLogging, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 46631, 46659);

                Transcription
                transcription
                = default(Transcription);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 46673, 46755);

                transcription = f_959_46689_46754(Utils.SystemWideOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 46769, 46819);

                f_959_46769_46818(fixture, transcription, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 46835, 46918);

                transcription = f_959_46851_46917(Utils.CurrentUserOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 46932, 46982);

                f_959_46932_46981(fixture, transcription, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 46998, 47091);

                transcription = f_959_47014_47090(Utils.SystemWideThenCurrentUserConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 47105, 47155);

                f_959_47105_47154(fixture, transcription, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 47171, 47264);

                transcription = f_959_47187_47263(Utils.CurrentUserThenSystemWideConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 47278, 47328);

                f_959_47278_47327(fixture, transcription, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 47344, 47372);

                UpdatableHelp
                updatableHelp
                = default(UpdatableHelp);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 47386, 47468);

                updatableHelp = f_959_47402_47467(Utils.SystemWideOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 47482, 47532);

                f_959_47482_47531(fixture, updatableHelp, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 47548, 47631);

                updatableHelp = f_959_47564_47630(Utils.CurrentUserOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 47645, 47695);

                f_959_47645_47694(fixture, updatableHelp, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 47711, 47804);

                updatableHelp = f_959_47727_47803(Utils.SystemWideThenCurrentUserConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 47818, 47868);

                f_959_47818_47867(fixture, updatableHelp, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 47884, 47977);

                updatableHelp = f_959_47900_47976(Utils.CurrentUserThenSystemWideConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 47991, 48041);

                f_959_47991_48040(fixture, updatableHelp, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 48057, 48113);

                ConsoleSessionConfiguration
                consoleSessionConfiguration
                = default(ConsoleSessionConfiguration);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 48127, 48237);

                consoleSessionConfiguration = f_959_48157_48236(Utils.SystemWideOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 48251, 48329);

                f_959_48251_48328(fixture, consoleSessionConfiguration, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 48345, 48456);

                consoleSessionConfiguration = f_959_48375_48455(Utils.CurrentUserOnlyConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 48470, 48548);

                f_959_48470_48547(fixture, consoleSessionConfiguration, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 48564, 48685);

                consoleSessionConfiguration = f_959_48594_48684(Utils.SystemWideThenCurrentUserConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 48699, 48777);

                f_959_48699_48776(fixture, consoleSessionConfiguration, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 48793, 48914);

                consoleSessionConfiguration = f_959_48823_48913(Utils.CurrentUserThenSystemWideConfig);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(959, 48928, 49006);

                f_959_48928_49005(fixture, consoleSessionConfiguration, null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(959, 43115, 49017);

                int
                f_959_43234_43262(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    this_param.CleanupConfigFiles();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 43234, 43262);
                    return 0;
                }


                int
                f_959_43277_43307(PSTests.Sequential.PowerShellPolicyFixture
                this_param)
                {
                    this_param.ForceReadingFromFile();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 43277, 43307);
                    return 0;
                }


                System.Management.Automation.Configuration.ScriptExecution
                f_959_43434_43501(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ScriptExecution>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 43434, 43501);
                    return return_v;
                }


                int
                f_959_43516_43569(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ScriptExecution
                a, System.Management.Automation.Configuration.ScriptExecution
                b)
                {
                    this_param.CompareScriptExecution(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 43516, 43569);
                    return 0;
                }


                System.Management.Automation.Configuration.ScriptExecution
                f_959_43604_43672(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ScriptExecution>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 43604, 43672);
                    return return_v;
                }


                int
                f_959_43687_43740(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ScriptExecution
                a, System.Management.Automation.Configuration.ScriptExecution
                b)
                {
                    this_param.CompareScriptExecution(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 43687, 43740);
                    return 0;
                }


                System.Management.Automation.Configuration.ScriptExecution
                f_959_43775_43853(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ScriptExecution>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 43775, 43853);
                    return return_v;
                }


                int
                f_959_43868_43921(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ScriptExecution
                a, System.Management.Automation.Configuration.ScriptExecution
                b)
                {
                    this_param.CompareScriptExecution(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 43868, 43921);
                    return 0;
                }


                System.Management.Automation.Configuration.ScriptExecution
                f_959_43956_44034(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ScriptExecution>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 43956, 44034);
                    return return_v;
                }


                int
                f_959_44049_44102(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ScriptExecution
                a, System.Management.Automation.Configuration.ScriptExecution
                b)
                {
                    this_param.CompareScriptExecution(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 44049, 44102);
                    return 0;
                }


                System.Management.Automation.Configuration.ScriptBlockLogging
                f_959_44192_44262(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ScriptBlockLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 44192, 44262);
                    return return_v;
                }


                int
                f_959_44277_44336(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ScriptBlockLogging
                a, System.Management.Automation.Configuration.ScriptBlockLogging
                b)
                {
                    this_param.CompareScriptBlockLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 44277, 44336);
                    return 0;
                }


                System.Management.Automation.Configuration.ScriptBlockLogging
                f_959_44374_44445(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ScriptBlockLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 44374, 44445);
                    return return_v;
                }


                int
                f_959_44460_44519(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ScriptBlockLogging
                a, System.Management.Automation.Configuration.ScriptBlockLogging
                b)
                {
                    this_param.CompareScriptBlockLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 44460, 44519);
                    return 0;
                }


                System.Management.Automation.Configuration.ScriptBlockLogging
                f_959_44557_44638(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ScriptBlockLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 44557, 44638);
                    return return_v;
                }


                int
                f_959_44653_44712(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ScriptBlockLogging
                a, System.Management.Automation.Configuration.ScriptBlockLogging
                b)
                {
                    this_param.CompareScriptBlockLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 44653, 44712);
                    return 0;
                }


                System.Management.Automation.Configuration.ScriptBlockLogging
                f_959_44750_44831(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ScriptBlockLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 44750, 44831);
                    return return_v;
                }


                int
                f_959_44846_44905(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ScriptBlockLogging
                a, System.Management.Automation.Configuration.ScriptBlockLogging
                b)
                {
                    this_param.CompareScriptBlockLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 44846, 44905);
                    return 0;
                }


                System.Management.Automation.Configuration.ModuleLogging
                f_959_44980_45045(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ModuleLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 44980, 45045);
                    return return_v;
                }


                int
                f_959_45060_45109(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ModuleLogging
                a, System.Management.Automation.Configuration.ModuleLogging
                b)
                {
                    this_param.CompareModuleLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 45060, 45109);
                    return 0;
                }


                System.Management.Automation.Configuration.ModuleLogging
                f_959_45142_45208(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ModuleLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 45142, 45208);
                    return return_v;
                }


                int
                f_959_45223_45272(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ModuleLogging
                a, System.Management.Automation.Configuration.ModuleLogging
                b)
                {
                    this_param.CompareModuleLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 45223, 45272);
                    return 0;
                }


                System.Management.Automation.Configuration.ModuleLogging
                f_959_45305_45381(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ModuleLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 45305, 45381);
                    return return_v;
                }


                int
                f_959_45396_45445(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ModuleLogging
                a, System.Management.Automation.Configuration.ModuleLogging
                b)
                {
                    this_param.CompareModuleLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 45396, 45445);
                    return 0;
                }


                System.Management.Automation.Configuration.ModuleLogging
                f_959_45478_45554(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ModuleLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 45478, 45554);
                    return return_v;
                }


                int
                f_959_45569_45618(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ModuleLogging
                a, System.Management.Automation.Configuration.ModuleLogging
                b)
                {
                    this_param.CompareModuleLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 45569, 45618);
                    return 0;
                }


                System.Management.Automation.Configuration.ProtectedEventLogging
                f_959_45717_45790(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ProtectedEventLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 45717, 45790);
                    return return_v;
                }


                int
                f_959_45805_45870(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ProtectedEventLogging
                a, System.Management.Automation.Configuration.ProtectedEventLogging
                b)
                {
                    this_param.CompareProtectedEventLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 45805, 45870);
                    return 0;
                }


                System.Management.Automation.Configuration.ProtectedEventLogging
                f_959_45911_45985(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ProtectedEventLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 45911, 45985);
                    return return_v;
                }


                int
                f_959_46000_46065(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ProtectedEventLogging
                a, System.Management.Automation.Configuration.ProtectedEventLogging
                b)
                {
                    this_param.CompareProtectedEventLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 46000, 46065);
                    return 0;
                }


                System.Management.Automation.Configuration.ProtectedEventLogging
                f_959_46106_46190(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ProtectedEventLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 46106, 46190);
                    return return_v;
                }


                int
                f_959_46205_46270(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ProtectedEventLogging
                a, System.Management.Automation.Configuration.ProtectedEventLogging
                b)
                {
                    this_param.CompareProtectedEventLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 46205, 46270);
                    return 0;
                }


                System.Management.Automation.Configuration.ProtectedEventLogging
                f_959_46311_46395(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ProtectedEventLogging>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 46311, 46395);
                    return return_v;
                }


                int
                f_959_46410_46475(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ProtectedEventLogging
                a, System.Management.Automation.Configuration.ProtectedEventLogging
                b)
                {
                    this_param.CompareProtectedEventLogging(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 46410, 46475);
                    return 0;
                }


                System.Management.Automation.Configuration.Transcription
                f_959_46689_46754(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<Transcription>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 46689, 46754);
                    return return_v;
                }


                int
                f_959_46769_46818(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.Transcription
                a, System.Management.Automation.Configuration.Transcription
                b)
                {
                    this_param.CompareTranscription(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 46769, 46818);
                    return 0;
                }


                System.Management.Automation.Configuration.Transcription
                f_959_46851_46917(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<Transcription>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 46851, 46917);
                    return return_v;
                }


                int
                f_959_46932_46981(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.Transcription
                a, System.Management.Automation.Configuration.Transcription
                b)
                {
                    this_param.CompareTranscription(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 46932, 46981);
                    return 0;
                }


                System.Management.Automation.Configuration.Transcription
                f_959_47014_47090(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<Transcription>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 47014, 47090);
                    return return_v;
                }


                int
                f_959_47105_47154(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.Transcription
                a, System.Management.Automation.Configuration.Transcription
                b)
                {
                    this_param.CompareTranscription(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 47105, 47154);
                    return 0;
                }


                System.Management.Automation.Configuration.Transcription
                f_959_47187_47263(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<Transcription>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 47187, 47263);
                    return return_v;
                }


                int
                f_959_47278_47327(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.Transcription
                a, System.Management.Automation.Configuration.Transcription
                b)
                {
                    this_param.CompareTranscription(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 47278, 47327);
                    return 0;
                }


                System.Management.Automation.Configuration.UpdatableHelp
                f_959_47402_47467(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<UpdatableHelp>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 47402, 47467);
                    return return_v;
                }


                int
                f_959_47482_47531(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.UpdatableHelp
                a, System.Management.Automation.Configuration.UpdatableHelp
                b)
                {
                    this_param.CompareUpdatableHelp(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 47482, 47531);
                    return 0;
                }


                System.Management.Automation.Configuration.UpdatableHelp
                f_959_47564_47630(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<UpdatableHelp>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 47564, 47630);
                    return return_v;
                }


                int
                f_959_47645_47694(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.UpdatableHelp
                a, System.Management.Automation.Configuration.UpdatableHelp
                b)
                {
                    this_param.CompareUpdatableHelp(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 47645, 47694);
                    return 0;
                }


                System.Management.Automation.Configuration.UpdatableHelp
                f_959_47727_47803(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<UpdatableHelp>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 47727, 47803);
                    return return_v;
                }


                int
                f_959_47818_47867(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.UpdatableHelp
                a, System.Management.Automation.Configuration.UpdatableHelp
                b)
                {
                    this_param.CompareUpdatableHelp(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 47818, 47867);
                    return 0;
                }


                System.Management.Automation.Configuration.UpdatableHelp
                f_959_47900_47976(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<UpdatableHelp>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 47900, 47976);
                    return return_v;
                }


                int
                f_959_47991_48040(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.UpdatableHelp
                a, System.Management.Automation.Configuration.UpdatableHelp
                b)
                {
                    this_param.CompareUpdatableHelp(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 47991, 48040);
                    return 0;
                }


                System.Management.Automation.Configuration.ConsoleSessionConfiguration
                f_959_48157_48236(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ConsoleSessionConfiguration>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 48157, 48236);
                    return return_v;
                }


                int
                f_959_48251_48328(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ConsoleSessionConfiguration
                a, System.Management.Automation.Configuration.ConsoleSessionConfiguration
                b)
                {
                    this_param.CompareConsoleSessionConfiguration(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 48251, 48328);
                    return 0;
                }


                System.Management.Automation.Configuration.ConsoleSessionConfiguration
                f_959_48375_48455(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ConsoleSessionConfiguration>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 48375, 48455);
                    return return_v;
                }


                int
                f_959_48470_48547(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ConsoleSessionConfiguration
                a, System.Management.Automation.Configuration.ConsoleSessionConfiguration
                b)
                {
                    this_param.CompareConsoleSessionConfiguration(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 48470, 48547);
                    return 0;
                }


                System.Management.Automation.Configuration.ConsoleSessionConfiguration
                f_959_48594_48684(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ConsoleSessionConfiguration>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 48594, 48684);
                    return return_v;
                }


                int
                f_959_48699_48776(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ConsoleSessionConfiguration
                a, System.Management.Automation.Configuration.ConsoleSessionConfiguration
                b)
                {
                    this_param.CompareConsoleSessionConfiguration(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 48699, 48776);
                    return 0;
                }


                System.Management.Automation.Configuration.ConsoleSessionConfiguration
                f_959_48823_48913(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ConsoleSessionConfiguration>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 48823, 48913);
                    return return_v;
                }


                int
                f_959_48928_49005(PSTests.Sequential.PowerShellPolicyFixture
                this_param, System.Management.Automation.Configuration.ConsoleSessionConfiguration
                a, System.Management.Automation.Configuration.ConsoleSessionConfiguration
                b)
                {
                    this_param.CompareConsoleSessionConfiguration(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(959, 48928, 49005);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(959, 43115, 49017);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(959, 43115, 49017);
            }
        }

        static PowerShellPolicyTests()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(959, 14059, 49024);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(959, 14059, 49024);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(959, 14059, 49024);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(959, 14059, 49024);
    }
}
