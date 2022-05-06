// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Host;
using System.Management.Automation.Internal;
using System.Management.Automation.Internal.Host;
using System.Management.Automation.Provider;
using System.Management.Automation.Runspaces;
using System.Reflection;
using System.Reflection.Metadata;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.PowerShell;
using Microsoft.PowerShell.Commands;
using Xunit;

namespace PSTests.Parallel
{
    public class FileSystemProviderTests : IDisposable
    {
        private string testPath;

        private string testContent;

        public FileSystemProviderTests()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(955, 889, 1203);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 831, 839);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 865, 876);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 946, 980);

                testPath = f_955_957_979();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 994, 1024);

                testContent = "test content!";

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 1038, 1134) || true) && (f_955_1042_1063(testPath))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(955, 1038, 1134);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 1097, 1119);

                    f_955_1097_1118(testPath);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(955, 1038, 1134);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 1150, 1192);

                f_955_1150_1191(testPath, testContent);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(955, 889, 1203);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(955, 889, 1203);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(955, 889, 1203);
            }
        }

        void IDisposable.Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(955, 1215, 1299);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 1266, 1288);

                f_955_1266_1287(testPath);
                DynAbs.Tracing.TraceSender.TraceExitMethod(955, 1215, 1299);

                int
                f_955_1266_1287(string
                path)
                {
                    File.Delete(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 1266, 1287);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(955, 1215, 1299);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(955, 1215, 1299);
            }
        }

        private ExecutionContext GetExecutionContext()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(955, 1311, 1829);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 1382, 1438);

                CultureInfo
                currentCulture = f_955_1411_1437()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 1452, 1523);

                PSHost
                hostInterface = f_955_1475_1522(currentCulture, currentCulture)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 1537, 1600);

                InitialSessionState
                iss = f_955_1563_1599()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 1614, 1681);

                AutomationEngine
                engine = f_955_1640_1680(hostInterface, iss)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 1695, 1780);

                ExecutionContext
                executionContext = f_955_1731_1779(engine, hostInterface, iss)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 1794, 1818);

                return executionContext;
                DynAbs.Tracing.TraceSender.TraceExitMethod(955, 1311, 1829);

                System.Globalization.CultureInfo
                f_955_1411_1437()
                {
                    var return_v = CultureInfo.CurrentCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(955, 1411, 1437);
                    return return_v;
                }


                Microsoft.PowerShell.DefaultHost
                f_955_1475_1522(System.Globalization.CultureInfo
                currentCulture, System.Globalization.CultureInfo
                currentUICulture)
                {
                    var return_v = new Microsoft.PowerShell.DefaultHost(currentCulture, currentUICulture);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 1475, 1522);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InitialSessionState
                f_955_1563_1599()
                {
                    var return_v = InitialSessionState.CreateDefault2();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 1563, 1599);
                    return return_v;
                }


                System.Management.Automation.AutomationEngine
                f_955_1640_1680(System.Management.Automation.Host.PSHost
                hostInterface, System.Management.Automation.Runspaces.InitialSessionState
                iss)
                {
                    var return_v = new System.Management.Automation.AutomationEngine(hostInterface, iss);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 1640, 1680);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_955_1731_1779(System.Management.Automation.AutomationEngine
                engine, System.Management.Automation.Host.PSHost
                hostInterface, System.Management.Automation.Runspaces.InitialSessionState
                initialSessionState)
                {
                    var return_v = new System.Management.Automation.ExecutionContext(engine, hostInterface, initialSessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 1731, 1779);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(955, 1311, 1829);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(955, 1311, 1829);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ProviderInfo GetProvider()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(955, 1841, 2385);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 1900, 1958);

                ExecutionContext
                executionContext = f_955_1936_1957(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 1972, 2051);

                SessionStateInternal
                sessionState = f_955_2008_2050(executionContext)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 2067, 2187);

                SessionStateProviderEntry
                providerEntry = f_955_2109_2186("FileSystem", typeof(FileSystemProvider), null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 2201, 2250);

                f_955_2201_2249(sessionState, providerEntry);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 2264, 2334);

                ProviderInfo
                matchingProvider = f_955_2296_2333(f_955_2296_2330(f_955_2296_2321(sessionState)), 0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 2350, 2374);

                return matchingProvider;
                DynAbs.Tracing.TraceSender.TraceExitMethod(955, 1841, 2385);

                System.Management.Automation.ExecutionContext
                f_955_1936_1957(PSTests.Parallel.FileSystemProviderTests
                this_param)
                {
                    var return_v = this_param.GetExecutionContext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 1936, 1957);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_955_2008_2050(System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new System.Management.Automation.SessionStateInternal(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 2008, 2050);
                    return return_v;
                }


                System.Management.Automation.Runspaces.SessionStateProviderEntry
                f_955_2109_2186(string
                name, System.Type
                implementingType, string
                helpFileName)
                {
                    var return_v = new System.Management.Automation.Runspaces.SessionStateProviderEntry(name, implementingType, helpFileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 2109, 2186);
                    return return_v;
                }


                int
                f_955_2201_2249(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.Runspaces.SessionStateProviderEntry
                providerEntry)
                {
                    this_param.AddSessionStateEntry(providerEntry);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 2201, 2249);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.ProviderInfo>
                f_955_2296_2321(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ProviderList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(955, 2296, 2321);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.ProviderInfo>
                f_955_2296_2330(System.Collections.Generic.IEnumerable<System.Management.Automation.ProviderInfo>
                source)
                {
                    var return_v = source.ToList<System.Management.Automation.ProviderInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 2296, 2330);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_955_2296_2333(System.Collections.Generic.List<System.Management.Automation.ProviderInfo>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(955, 2296, 2333);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(955, 1841, 2385);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(955, 1841, 2385);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [Fact]
        public void TestCreateJunctionFails()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(955, 2397, 2867);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 2475, 2856) || true) && (f_955_2479_2498_M(!Platform.IsWindows))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(955, 2475, 2856);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 2532, 2631);

                    f_955_2532_2630(f_955_2551_2629(string.Empty, string.Empty));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(955, 2475, 2856);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(955, 2475, 2856);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 2697, 2841);

                    f_955_2697_2840(delegate
                    { InternalSymbolicLinkLinkCodeMethods.CreateJunction(string.Empty, string.Empty); });
                    DynAbs.Tracing.TraceSender.TraceExitCondition(955, 2475, 2856);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(955, 2397, 2867);

                bool
                f_955_2479_2498_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(955, 2479, 2498);
                    return return_v;
                }


                bool
                f_955_2551_2629(string
                path, string
                target)
                {
                    var return_v = InternalSymbolicLinkLinkCodeMethods.CreateJunction(path, target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 2551, 2629);
                    return return_v;
                }


                bool
                f_955_2532_2630(bool
                condition)
                {
                    var return_v = CustomAssert.False(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 2532, 2630);
                    return return_v;
                }


                System.ArgumentNullException
                f_955_2697_2840(System.Action
                testCode)
                {
                    var return_v = CustomAssert.Throws<System.ArgumentNullException>(testCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 2697, 2840);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(955, 2397, 2867);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(955, 2397, 2867);
            }
        }

        [Fact]
        public void TestGetHelpMaml()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(955, 2879, 3342);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 2949, 3014);

                FileSystemProvider
                fileSystemProvider = f_955_2989_3013()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 3028, 3121);

                f_955_3028_3120(f_955_3047_3105(fileSystemProvider, string.Empty, string.Empty), string.Empty);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 3135, 3230);

                f_955_3135_3229(f_955_3154_3214(fileSystemProvider, "helpItemName", string.Empty), string.Empty);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 3244, 3331);

                f_955_3244_3330(f_955_3263_3315(fileSystemProvider, string.Empty, "path"), string.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(955, 2879, 3342);

                Microsoft.PowerShell.Commands.FileSystemProvider
                f_955_2989_3013()
                {
                    var return_v = new Microsoft.PowerShell.Commands.FileSystemProvider();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 2989, 3013);
                    return return_v;
                }


                string
                f_955_3047_3105(Microsoft.PowerShell.Commands.FileSystemProvider
                this_param, string
                helpItemName, string
                path)
                {
                    var return_v = this_param.GetHelpMaml(helpItemName, path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 3047, 3105);
                    return return_v;
                }


                bool
                f_955_3028_3120(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 3028, 3120);
                    return return_v;
                }


                string
                f_955_3154_3214(Microsoft.PowerShell.Commands.FileSystemProvider
                this_param, string
                helpItemName, string
                path)
                {
                    var return_v = this_param.GetHelpMaml(helpItemName, path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 3154, 3214);
                    return return_v;
                }


                bool
                f_955_3135_3229(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 3135, 3229);
                    return return_v;
                }


                string
                f_955_3263_3315(Microsoft.PowerShell.Commands.FileSystemProvider
                this_param, string
                helpItemName, string
                path)
                {
                    var return_v = this_param.GetHelpMaml(helpItemName, path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 3263, 3315);
                    return return_v;
                }


                bool
                f_955_3244_3330(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 3244, 3330);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(955, 2879, 3342);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(955, 2879, 3342);
            }
        }

        [Fact]
        public void TestMode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(955, 3354, 4657);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 3417, 3481);

                f_955_3417_3480(f_955_3436_3465(null), string.Empty);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 3495, 3533);

                FileSystemInfo
                directoryObject = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 3547, 3580);

                FileSystemInfo
                fileObject = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 3594, 3633);

                FileSystemInfo
                executableObject = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 3649, 4243) || true) && (f_955_3653_3672_M(!Platform.IsWindows))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(955, 3649, 4243);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 3706, 3748);

                    directoryObject = f_955_3724_3747(@"/");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 3766, 3807);

                    fileObject = f_955_3779_3806(@"/etc/hosts");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 3825, 3871);

                    executableObject = f_955_3844_3870(@"/bin/echo");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(955, 3649, 4243);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(955, 3649, 4243);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 3937, 4010);

                    directoryObject = f_955_3955_4009(f_955_3973_4008());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 4028, 4110);

                    fileObject = f_955_4041_4109(f_955_4054_4108(f_955_4054_4099()));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 4128, 4228);

                    executableObject = f_955_4147_4227(f_955_4160_4226(f_955_4160_4217(f_955_4160_4206())));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(955, 3649, 4243);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 4259, 4368);

                f_955_4259_4367("d----", f_955_4287_4366(f_955_4287_4348(f_955_4311_4347(directoryObject)), "r", "-"));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 4382, 4504);

                f_955_4382_4503("-----", f_955_4410_4502(f_955_4410_4484(f_955_4410_4466(f_955_4434_4465(fileObject)), "r", "-"), "a", "-"));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 4518, 4646);

                f_955_4518_4645("-----", f_955_4546_4644(f_955_4546_4626(f_955_4546_4608(f_955_4570_4607(executableObject)), "r", "-"), "a", "-"));
                DynAbs.Tracing.TraceSender.TraceExitMethod(955, 3354, 4657);

                string
                f_955_3436_3465(System.Management.Automation.PSObject
                instance)
                {
                    var return_v = FileSystemProvider.Mode(instance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 3436, 3465);
                    return return_v;
                }


                bool
                f_955_3417_3480(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 3417, 3480);
                    return return_v;
                }


                bool
                f_955_3653_3672_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(955, 3653, 3672);
                    return return_v;
                }


                System.IO.DirectoryInfo
                f_955_3724_3747(string
                path)
                {
                    var return_v = new System.IO.DirectoryInfo(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 3724, 3747);
                    return return_v;
                }


                System.IO.FileInfo
                f_955_3779_3806(string
                fileName)
                {
                    var return_v = new System.IO.FileInfo(fileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 3779, 3806);
                    return return_v;
                }


                System.IO.FileInfo
                f_955_3844_3870(string
                fileName)
                {
                    var return_v = new System.IO.FileInfo(fileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 3844, 3870);
                    return return_v;
                }


                string
                f_955_3973_4008()
                {
                    var return_v = System.Environment.CurrentDirectory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(955, 3973, 4008);
                    return return_v;
                }


                System.IO.DirectoryInfo
                f_955_3955_4009(string
                path)
                {
                    var return_v = new System.IO.DirectoryInfo(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 3955, 4009);
                    return return_v;
                }


                System.Reflection.Assembly?
                f_955_4054_4099()
                {
                    var return_v = System.Reflection.Assembly.GetEntryAssembly();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 4054, 4099);
                    return return_v;
                }


                string
                f_955_4054_4108(System.Reflection.Assembly
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(955, 4054, 4108);
                    return return_v;
                }


                System.IO.FileInfo
                f_955_4041_4109(string
                fileName)
                {
                    var return_v = new System.IO.FileInfo(fileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 4041, 4109);
                    return return_v;
                }


                System.Diagnostics.Process
                f_955_4160_4206()
                {
                    var return_v = System.Diagnostics.Process.GetCurrentProcess();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 4160, 4206);
                    return return_v;
                }


                System.Diagnostics.ProcessModule
                f_955_4160_4217(System.Diagnostics.Process
                this_param)
                {
                    var return_v = this_param.MainModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(955, 4160, 4217);
                    return return_v;
                }


                string
                f_955_4160_4226(System.Diagnostics.ProcessModule
                this_param)
                {
                    var return_v = this_param.FileName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(955, 4160, 4226);
                    return return_v;
                }


                System.IO.FileInfo
                f_955_4147_4227(string
                fileName)
                {
                    var return_v = new System.IO.FileInfo(fileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 4147, 4227);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_955_4311_4347(System.IO.FileSystemInfo
                obj)
                {
                    var return_v = PSObject.AsPSObject((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 4311, 4347);
                    return return_v;
                }


                string
                f_955_4287_4348(System.Management.Automation.PSObject
                instance)
                {
                    var return_v = FileSystemProvider.Mode(instance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 4287, 4348);
                    return return_v;
                }


                string
                f_955_4287_4366(string
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 4287, 4366);
                    return return_v;
                }


                bool
                f_955_4259_4367(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 4259, 4367);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_955_4434_4465(System.IO.FileSystemInfo
                obj)
                {
                    var return_v = PSObject.AsPSObject((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 4434, 4465);
                    return return_v;
                }


                string
                f_955_4410_4466(System.Management.Automation.PSObject
                instance)
                {
                    var return_v = FileSystemProvider.Mode(instance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 4410, 4466);
                    return return_v;
                }


                string
                f_955_4410_4484(string
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 4410, 4484);
                    return return_v;
                }


                string
                f_955_4410_4502(string
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 4410, 4502);
                    return return_v;
                }


                bool
                f_955_4382_4503(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 4382, 4503);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_955_4570_4607(System.IO.FileSystemInfo
                obj)
                {
                    var return_v = PSObject.AsPSObject((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 4570, 4607);
                    return return_v;
                }


                string
                f_955_4546_4608(System.Management.Automation.PSObject
                instance)
                {
                    var return_v = FileSystemProvider.Mode(instance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 4546, 4608);
                    return return_v;
                }


                string
                f_955_4546_4626(string
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 4546, 4626);
                    return return_v;
                }


                string
                f_955_4546_4644(string
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 4546, 4644);
                    return return_v;
                }


                bool
                f_955_4518_4645(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 4518, 4645);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(955, 3354, 4657);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(955, 3354, 4657);
            }
        }

        [Fact]
        public void TestGetProperty()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(955, 4669, 5570);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 4739, 4804);

                FileSystemProvider
                fileSystemProvider = f_955_4779_4803()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 4818, 4865);

                ProviderInfo
                providerInfoToSet = f_955_4851_4864(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 4879, 4940);

                f_955_4879_4939(fileSystemProvider, providerInfoToSet);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 4954, 5032);

                fileSystemProvider.Context = f_955_4983_5031(f_955_5009_5030(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 5046, 5076);

                PSObject
                pso = f_955_5061_5075()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 5090, 5132);

                f_955_5090_5131(pso, "IsReadOnly", false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 5146, 5192);

                f_955_5146_5191(fileSystemProvider, testPath, pso);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 5206, 5289);

                f_955_5206_5288(fileSystemProvider, testPath, new Collection<string>() { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => "IsReadOnly", 955, 5247, 5287) });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 5303, 5355);

                FileInfo
                fileSystemObject1 = f_955_5332_5354(testPath)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 5369, 5429);

                PSObject
                psobject1 = f_955_5390_5428(fileSystemObject1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 5443, 5504);

                PSPropertyInfo
                property = f_955_5469_5503(f_955_5469_5489(psobject1), "IsReadOnly")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 5518, 5559);

                f_955_5518_5558(f_955_5543_5557(property));
                DynAbs.Tracing.TraceSender.TraceExitMethod(955, 4669, 5570);

                Microsoft.PowerShell.Commands.FileSystemProvider
                f_955_4779_4803()
                {
                    var return_v = new Microsoft.PowerShell.Commands.FileSystemProvider();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 4779, 4803);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_955_4851_4864(PSTests.Parallel.FileSystemProviderTests
                this_param)
                {
                    var return_v = this_param.GetProvider();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 4851, 4864);
                    return return_v;
                }


                int
                f_955_4879_4939(Microsoft.PowerShell.Commands.FileSystemProvider
                this_param, System.Management.Automation.ProviderInfo
                providerInfoToSet)
                {
                    this_param.SetProviderInformation(providerInfoToSet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 4879, 4939);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_955_5009_5030(PSTests.Parallel.FileSystemProviderTests
                this_param)
                {
                    var return_v = this_param.GetExecutionContext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 5009, 5030);
                    return return_v;
                }


                System.Management.Automation.CmdletProviderContext
                f_955_4983_5031(System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = new System.Management.Automation.CmdletProviderContext(executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 4983, 5031);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_955_5061_5075()
                {
                    var return_v = new System.Management.Automation.PSObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 5061, 5075);
                    return return_v;
                }


                int
                f_955_5090_5131(System.Management.Automation.PSObject
                this_param, string
                memberName, bool
                value)
                {
                    this_param.AddOrSetProperty(memberName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 5090, 5131);
                    return 0;
                }


                int
                f_955_5146_5191(Microsoft.PowerShell.Commands.FileSystemProvider
                this_param, string
                path, System.Management.Automation.PSObject
                propertyToSet)
                {
                    this_param.SetProperty(path, propertyToSet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 5146, 5191);
                    return 0;
                }


                int
                f_955_5206_5288(Microsoft.PowerShell.Commands.FileSystemProvider
                this_param, string
                path, System.Collections.ObjectModel.Collection<string>
                providerSpecificPickList)
                {
                    this_param.GetProperty(path, providerSpecificPickList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 5206, 5288);
                    return 0;
                }


                System.IO.FileInfo
                f_955_5332_5354(string
                fileName)
                {
                    var return_v = new System.IO.FileInfo(fileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 5332, 5354);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_955_5390_5428(System.IO.FileInfo
                obj)
                {
                    var return_v = PSObject.AsPSObject((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 5390, 5428);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_955_5469_5489(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(955, 5469, 5489);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_955_5469_5503(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(955, 5469, 5503);
                    return return_v;
                }


                object
                f_955_5543_5557(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(955, 5543, 5557);
                    return return_v;
                }


                bool
                f_955_5518_5558(object
                condition)
                {
                    var return_v = CustomAssert.False((bool)condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 5518, 5558);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(955, 4669, 5570);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(955, 4669, 5570);
            }
        }

        [Fact]
        public void TestSetProperty()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(955, 5582, 6321);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 5652, 5717);

                FileSystemProvider
                fileSystemProvider = f_955_5692_5716()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 5731, 5778);

                ProviderInfo
                providerInfoToSet = f_955_5764_5777(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 5792, 5853);

                f_955_5792_5852(fileSystemProvider, providerInfoToSet);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 5867, 5945);

                fileSystemProvider.Context = f_955_5896_5944(f_955_5922_5943(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 5959, 6036);

                f_955_5959_6035(fileSystemProvider, testPath, new Collection<string>() { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => "Name", 955, 6000, 6034) });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 6050, 6102);

                FileInfo
                fileSystemObject1 = f_955_6079_6101(testPath)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 6116, 6176);

                PSObject
                psobject1 = f_955_6137_6175(fileSystemObject1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 6190, 6249);

                PSPropertyInfo
                property = f_955_6216_6248(f_955_6216_6236(psobject1), "FullName")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 6265, 6310);

                f_955_6265_6309(testPath, f_955_6294_6308(property));
                DynAbs.Tracing.TraceSender.TraceExitMethod(955, 5582, 6321);

                Microsoft.PowerShell.Commands.FileSystemProvider
                f_955_5692_5716()
                {
                    var return_v = new Microsoft.PowerShell.Commands.FileSystemProvider();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 5692, 5716);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_955_5764_5777(PSTests.Parallel.FileSystemProviderTests
                this_param)
                {
                    var return_v = this_param.GetProvider();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 5764, 5777);
                    return return_v;
                }


                int
                f_955_5792_5852(Microsoft.PowerShell.Commands.FileSystemProvider
                this_param, System.Management.Automation.ProviderInfo
                providerInfoToSet)
                {
                    this_param.SetProviderInformation(providerInfoToSet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 5792, 5852);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_955_5922_5943(PSTests.Parallel.FileSystemProviderTests
                this_param)
                {
                    var return_v = this_param.GetExecutionContext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 5922, 5943);
                    return return_v;
                }


                System.Management.Automation.CmdletProviderContext
                f_955_5896_5944(System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = new System.Management.Automation.CmdletProviderContext(executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 5896, 5944);
                    return return_v;
                }


                int
                f_955_5959_6035(Microsoft.PowerShell.Commands.FileSystemProvider
                this_param, string
                path, System.Collections.ObjectModel.Collection<string>
                providerSpecificPickList)
                {
                    this_param.GetProperty(path, providerSpecificPickList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 5959, 6035);
                    return 0;
                }


                System.IO.FileInfo
                f_955_6079_6101(string
                fileName)
                {
                    var return_v = new System.IO.FileInfo(fileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 6079, 6101);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_955_6137_6175(System.IO.FileInfo
                obj)
                {
                    var return_v = PSObject.AsPSObject((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 6137, 6175);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_955_6216_6236(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(955, 6216, 6236);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_955_6216_6248(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(955, 6216, 6248);
                    return return_v;
                }


                object
                f_955_6294_6308(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(955, 6294, 6308);
                    return return_v;
                }


                bool
                f_955_6265_6309(string
                expected, object
                actual)
                {
                    var return_v = CustomAssert.Equal((object)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 6265, 6309);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(955, 5582, 6321);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(955, 5582, 6321);
            }
        }

        [Fact]
        public void TestClearProperty()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(955, 6333, 6808);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 6405, 6470);

                FileSystemProvider
                fileSystemProvider = f_955_6445_6469()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 6484, 6531);

                ProviderInfo
                providerInfoToSet = f_955_6517_6530(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 6545, 6606);

                f_955_6545_6605(fileSystemProvider, providerInfoToSet);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 6620, 6698);

                fileSystemProvider.Context = f_955_6649_6697(f_955_6675_6696(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 6712, 6797);

                f_955_6712_6796(fileSystemProvider, testPath, new Collection<string>() { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => "Attributes", 955, 6755, 6795) });
                DynAbs.Tracing.TraceSender.TraceExitMethod(955, 6333, 6808);

                Microsoft.PowerShell.Commands.FileSystemProvider
                f_955_6445_6469()
                {
                    var return_v = new Microsoft.PowerShell.Commands.FileSystemProvider();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 6445, 6469);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_955_6517_6530(PSTests.Parallel.FileSystemProviderTests
                this_param)
                {
                    var return_v = this_param.GetProvider();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 6517, 6530);
                    return return_v;
                }


                int
                f_955_6545_6605(Microsoft.PowerShell.Commands.FileSystemProvider
                this_param, System.Management.Automation.ProviderInfo
                providerInfoToSet)
                {
                    this_param.SetProviderInformation(providerInfoToSet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 6545, 6605);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_955_6675_6696(PSTests.Parallel.FileSystemProviderTests
                this_param)
                {
                    var return_v = this_param.GetExecutionContext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 6675, 6696);
                    return return_v;
                }


                System.Management.Automation.CmdletProviderContext
                f_955_6649_6697(System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = new System.Management.Automation.CmdletProviderContext(executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 6649, 6697);
                    return return_v;
                }


                int
                f_955_6712_6796(Microsoft.PowerShell.Commands.FileSystemProvider
                this_param, string
                path, System.Collections.ObjectModel.Collection<string>
                propertiesToClear)
                {
                    this_param.ClearProperty(path, propertiesToClear);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 6712, 6796);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(955, 6333, 6808);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(955, 6333, 6808);
            }
        }

        [Fact]
        public void TestGetContentReader()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(955, 6820, 7400);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 6895, 6960);

                FileSystemProvider
                fileSystemProvider = f_955_6935_6959()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 6974, 7021);

                ProviderInfo
                providerInfoToSet = f_955_7007_7020(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 7035, 7096);

                f_955_7035_7095(fileSystemProvider, providerInfoToSet);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 7110, 7188);

                fileSystemProvider.Context = f_955_7139_7187(f_955_7165_7186(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 7204, 7281);

                IContentReader
                contentReader = f_955_7235_7280(fileSystemProvider, testPath)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 7295, 7353);

                f_955_7295_7352(f_955_7314_7338(f_955_7314_7335(contentReader, 1), 0), testContent);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 7367, 7389);

                f_955_7367_7388(contentReader);
                DynAbs.Tracing.TraceSender.TraceExitMethod(955, 6820, 7400);

                Microsoft.PowerShell.Commands.FileSystemProvider
                f_955_6935_6959()
                {
                    var return_v = new Microsoft.PowerShell.Commands.FileSystemProvider();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 6935, 6959);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_955_7007_7020(PSTests.Parallel.FileSystemProviderTests
                this_param)
                {
                    var return_v = this_param.GetProvider();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 7007, 7020);
                    return return_v;
                }


                int
                f_955_7035_7095(Microsoft.PowerShell.Commands.FileSystemProvider
                this_param, System.Management.Automation.ProviderInfo
                providerInfoToSet)
                {
                    this_param.SetProviderInformation(providerInfoToSet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 7035, 7095);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_955_7165_7186(PSTests.Parallel.FileSystemProviderTests
                this_param)
                {
                    var return_v = this_param.GetExecutionContext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 7165, 7186);
                    return return_v;
                }


                System.Management.Automation.CmdletProviderContext
                f_955_7139_7187(System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = new System.Management.Automation.CmdletProviderContext(executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 7139, 7187);
                    return return_v;
                }


                System.Management.Automation.Provider.IContentReader
                f_955_7235_7280(Microsoft.PowerShell.Commands.FileSystemProvider
                this_param, string
                path)
                {
                    var return_v = this_param.GetContentReader(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 7235, 7280);
                    return return_v;
                }


                System.Collections.IList
                f_955_7314_7335(System.Management.Automation.Provider.IContentReader
                this_param, int
                readCount)
                {
                    var return_v = this_param.Read((long)readCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 7314, 7335);
                    return return_v;
                }


                object
                f_955_7314_7338(System.Collections.IList
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(955, 7314, 7338);
                    return return_v;
                }


                bool
                f_955_7295_7352(object
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 7295, 7352);
                    return return_v;
                }


                int
                f_955_7367_7388(System.Management.Automation.Provider.IContentReader
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 7367, 7388);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(955, 6820, 7400);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(955, 6820, 7400);
            }
        }

        [Fact]
        public void TestGetContentWriter()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(955, 7412, 8137);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 7487, 7552);

                FileSystemProvider
                fileSystemProvider = f_955_7527_7551()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 7566, 7613);

                ProviderInfo
                providerInfoToSet = f_955_7599_7612(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 7627, 7688);

                f_955_7627_7687(fileSystemProvider, providerInfoToSet);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 7702, 7780);

                fileSystemProvider.Context = f_955_7731_7779(f_955_7757_7778(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 7796, 7873);

                IContentWriter
                contentWriter = f_955_7827_7872(fileSystemProvider, testPath)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 7887, 7957);

                f_955_7887_7956(contentWriter, new List<string>() { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => "contentWriterTestContent", 955, 7907, 7955) });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 7971, 7993);

                f_955_7971_7992(contentWriter);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 8007, 8126);

                f_955_8007_8125(f_955_8026_8052(testPath), testContent + @"contentWriterTestContent" + f_955_8098_8124());
                DynAbs.Tracing.TraceSender.TraceExitMethod(955, 7412, 8137);

                Microsoft.PowerShell.Commands.FileSystemProvider
                f_955_7527_7551()
                {
                    var return_v = new Microsoft.PowerShell.Commands.FileSystemProvider();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 7527, 7551);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_955_7599_7612(PSTests.Parallel.FileSystemProviderTests
                this_param)
                {
                    var return_v = this_param.GetProvider();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 7599, 7612);
                    return return_v;
                }


                int
                f_955_7627_7687(Microsoft.PowerShell.Commands.FileSystemProvider
                this_param, System.Management.Automation.ProviderInfo
                providerInfoToSet)
                {
                    this_param.SetProviderInformation(providerInfoToSet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 7627, 7687);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_955_7757_7778(PSTests.Parallel.FileSystemProviderTests
                this_param)
                {
                    var return_v = this_param.GetExecutionContext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 7757, 7778);
                    return return_v;
                }


                System.Management.Automation.CmdletProviderContext
                f_955_7731_7779(System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = new System.Management.Automation.CmdletProviderContext(executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 7731, 7779);
                    return return_v;
                }


                System.Management.Automation.Provider.IContentWriter
                f_955_7827_7872(Microsoft.PowerShell.Commands.FileSystemProvider
                this_param, string
                path)
                {
                    var return_v = this_param.GetContentWriter(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 7827, 7872);
                    return return_v;
                }


                System.Collections.IList
                f_955_7887_7956(System.Management.Automation.Provider.IContentWriter
                this_param, System.Collections.Generic.List<string>
                content)
                {
                    var return_v = this_param.Write((System.Collections.IList)content);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 7887, 7956);
                    return return_v;
                }


                int
                f_955_7971_7992(System.Management.Automation.Provider.IContentWriter
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 7971, 7992);
                    return 0;
                }


                string
                f_955_8026_8052(string
                path)
                {
                    var return_v = File.ReadAllText(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 8026, 8052);
                    return return_v;
                }


                string
                f_955_8098_8124()
                {
                    var return_v = System.Environment.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(955, 8098, 8124);
                    return return_v;
                }


                bool
                f_955_8007_8125(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 8007, 8125);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(955, 7412, 8137);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(955, 7412, 8137);
            }
        }

        [Fact]
        public void TestClearContent()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(955, 8149, 8641);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 8220, 8285);

                FileSystemProvider
                fileSystemProvider = f_955_8260_8284()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 8299, 8346);

                ProviderInfo
                providerInfoToSet = f_955_8332_8345(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 8360, 8421);

                f_955_8360_8420(fileSystemProvider, providerInfoToSet);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 8435, 8513);

                fileSystemProvider.Context = f_955_8464_8512(f_955_8490_8511(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 8527, 8569);

                f_955_8527_8568(fileSystemProvider, testPath);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(955, 8583, 8630);

                f_955_8583_8629(f_955_8602_8628(testPath));
                DynAbs.Tracing.TraceSender.TraceExitMethod(955, 8149, 8641);

                Microsoft.PowerShell.Commands.FileSystemProvider
                f_955_8260_8284()
                {
                    var return_v = new Microsoft.PowerShell.Commands.FileSystemProvider();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 8260, 8284);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_955_8332_8345(PSTests.Parallel.FileSystemProviderTests
                this_param)
                {
                    var return_v = this_param.GetProvider();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 8332, 8345);
                    return return_v;
                }


                int
                f_955_8360_8420(Microsoft.PowerShell.Commands.FileSystemProvider
                this_param, System.Management.Automation.ProviderInfo
                providerInfoToSet)
                {
                    this_param.SetProviderInformation(providerInfoToSet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 8360, 8420);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_955_8490_8511(PSTests.Parallel.FileSystemProviderTests
                this_param)
                {
                    var return_v = this_param.GetExecutionContext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 8490, 8511);
                    return return_v;
                }


                System.Management.Automation.CmdletProviderContext
                f_955_8464_8512(System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = new System.Management.Automation.CmdletProviderContext(executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 8464, 8512);
                    return return_v;
                }


                int
                f_955_8527_8568(Microsoft.PowerShell.Commands.FileSystemProvider
                this_param, string
                path)
                {
                    this_param.ClearContent(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 8527, 8568);
                    return 0;
                }


                string
                f_955_8602_8628(string
                path)
                {
                    var return_v = File.ReadAllText(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 8602, 8628);
                    return return_v;
                }


                bool
                f_955_8583_8629(string
                enumerable)
                {
                    var return_v = CustomAssert.Empty((System.Collections.IEnumerable)enumerable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 8583, 8629);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(955, 8149, 8641);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(955, 8149, 8641);
            }
        }

        static FileSystemProviderTests()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(955, 749, 8648);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(955, 749, 8648);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(955, 749, 8648);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(955, 749, 8648);

        static string
        f_955_957_979()
        {
            var return_v = Path.GetTempFileName();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 957, 979);
            return return_v;
        }


        static bool
        f_955_1042_1063(string
        path)
        {
            var return_v = File.Exists(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 1042, 1063);
            return return_v;
        }


        static int
        f_955_1097_1118(string
        path)
        {
            File.Delete(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 1097, 1118);
            return 0;
        }


        static int
        f_955_1150_1191(string
        path, string
        contents)
        {
            File.AppendAllText(path, contents);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(955, 1150, 1191);
            return 0;
        }

    }
}
