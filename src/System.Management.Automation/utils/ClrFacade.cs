// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management.Automation.Internal;
using System.Management.Automation.Language;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Loader;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

using Microsoft.Win32.SafeHandles;

namespace System.Management.Automation
{
    internal static class ClrFacade
    {
        static ClrFacade()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1003, 1342, 1559);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 5273, 5290);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 6029, 6042);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 1385, 1548) || true) && (f_1003_1389_1427() == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1003, 1385, 1548);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 1469, 1533);

                    f_1003_1469_1532(string.Empty);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1003, 1385, 1548);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1003, 1342, 1559);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1003, 1342, 1559);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1003, 1342, 1559);
            }
        }

        internal static IEnumerable<Assembly> GetAssemblies(TypeResolutionState typeResolutionState, TypeName typeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1003, 1599, 1898);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 1735, 1834);

                string
                typeNameToSearch = f_1003_1761_1816(typeResolutionState, f_1003_1802_1815(typeName)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1003, 1761, 1833) ?? f_1003_1820_1833(typeName))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 1848, 1887);

                return f_1003_1855_1886(typeNameToSearch);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1003, 1599, 1898);

                string
                f_1003_1802_1815(System.Management.Automation.Language.TypeName
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1003, 1802, 1815);
                    return return_v;
                }


                string
                f_1003_1761_1816(System.Management.Automation.Language.TypeResolutionState
                this_param, string
                typeName)
                {
                    var return_v = this_param.GetAlternateTypeName(typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 1761, 1816);
                    return return_v;
                }


                string
                f_1003_1820_1833(System.Management.Automation.Language.TypeName
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1003, 1820, 1833);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Reflection.Assembly>
                f_1003_1855_1886(string
                namespaceQualifiedTypeName)
                {
                    var return_v = GetAssemblies(namespaceQualifiedTypeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 1855, 1886);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1003, 1599, 1898);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1003, 1599, 1898);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static IEnumerable<Assembly> GetAssemblies(string namespaceQualifiedTypeName = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1003, 2316, 2542);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 2434, 2531);

                return f_1003_2441_2502(f_1003_2441_2462(), namespaceQualifiedTypeName) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.IEnumerable<System.Reflection.Assembly>>(1003, 2441, 2530) ?? f_1003_2506_2530());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1003, 2316, 2542);

                System.Management.Automation.PowerShellAssemblyLoadContext
                f_1003_2441_2462()
                {
                    var return_v = PSAssemblyLoadContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1003, 2441, 2462);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Reflection.Assembly>
                f_1003_2441_2502(System.Management.Automation.PowerShellAssemblyLoadContext
                this_param, string
                namespaceQualifiedTypeName)
                {
                    var return_v = this_param.GetAssembly(namespaceQualifiedTypeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 2441, 2502);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Reflection.Assembly>
                f_1003_2506_2530()
                {
                    var return_v = GetPSVisibleAssemblies();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 2506, 2530);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1003, 2316, 2542);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1003, 2316, 2542);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<Assembly> GetPSVisibleAssemblies()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1003, 2963, 3908);

                var listYield = new List<Assembly>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 3049, 3148);

                const string
                IndividualAssemblyLoadContext = "System.Runtime.Loader.IndividualAssemblyLoadContext"
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 3164, 3471);
                    foreach (Assembly assembly in f_1003_3194_3232_I(f_1003_3194_3232(f_1003_3194_3221())))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1003, 3164, 3471);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 3266, 3456) || true) && (!f_1003_3271_3373(f_1003_3271_3288(assembly), TypeDefiner.DynamicClassAssemblyFullNamePrefix, StringComparison.Ordinal))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1003, 3266, 3456);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 3415, 3437);

                            listYield.Add(assembly);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1003, 3266, 3456);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1003, 3164, 3471);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1003, 1, 308);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1003, 1, 308);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 3487, 3897);
                    foreach (AssemblyLoadContext context in f_1003_3527_3550_I(f_1003_3527_3550()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1003, 3487, 3897);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 3584, 3882) || true) && (f_1003_3588_3678(IndividualAssemblyLoadContext, f_1003_3625_3651(f_1003_3625_3642(context)), StringComparison.Ordinal))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1003, 3584, 3882);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 3720, 3863);
                                foreach (Assembly assembly in f_1003_3750_3768_I(f_1003_3750_3768(context)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1003, 3720, 3863);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 3818, 3840);

                                    listYield.Add(assembly);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1003, 3720, 3863);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1003, 1, 144);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1003, 1, 144);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1003, 3584, 3882);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1003, 3487, 3897);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1003, 1, 411);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1003, 1, 411);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1003, 2963, 3908);

                return listYield;

                System.Runtime.Loader.AssemblyLoadContext
                f_1003_3194_3221()
                {
                    var return_v = AssemblyLoadContext.Default;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1003, 3194, 3221);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Reflection.Assembly>
                f_1003_3194_3232(System.Runtime.Loader.AssemblyLoadContext
                this_param)
                {
                    var return_v = this_param.Assemblies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1003, 3194, 3232);
                    return return_v;
                }


                string
                f_1003_3271_3288(System.Reflection.Assembly
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1003, 3271, 3288);
                    return return_v;
                }


                bool
                f_1003_3271_3373(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 3271, 3373);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Reflection.Assembly>
                f_1003_3194_3232_I(System.Collections.Generic.IEnumerable<System.Reflection.Assembly>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 3194, 3232);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Runtime.Loader.AssemblyLoadContext>
                f_1003_3527_3550()
                {
                    var return_v = AssemblyLoadContext.All;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1003, 3527, 3550);
                    return return_v;
                }


                System.Type
                f_1003_3625_3642(System.Runtime.Loader.AssemblyLoadContext
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 3625, 3642);
                    return return_v;
                }


                string
                f_1003_3625_3651(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1003, 3625, 3651);
                    return return_v;
                }


                bool
                f_1003_3588_3678(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 3588, 3678);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Reflection.Assembly>
                f_1003_3750_3768(System.Runtime.Loader.AssemblyLoadContext
                this_param)
                {
                    var return_v = this_param.Assemblies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1003, 3750, 3768);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Reflection.Assembly>
                f_1003_3750_3768_I(System.Collections.Generic.IEnumerable<System.Reflection.Assembly>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 3750, 3768);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Runtime.Loader.AssemblyLoadContext>
                f_1003_3527_3550_I(System.Collections.Generic.IEnumerable<System.Runtime.Loader.AssemblyLoadContext>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 3527, 3550);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1003, 2963, 3908);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1003, 2963, 3908);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static IEnumerable<string> AvailableDotNetTypeNames
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1003, 4208, 4257);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 4211, 4257);
                    return f_1003_4211_4257(f_1003_4211_4232());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1003, 4208, 4257);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1003, 4208, 4257);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1003, 4208, 4257);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static HashSet<string> AvailableDotNetAssemblyNames
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1003, 4547, 4600);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 4550, 4600);
                    return f_1003_4550_4600(f_1003_4550_4571());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1003, 4547, 4600);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1003, 4547, 4600);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1003, 4547, 4600);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static PowerShellAssemblyLoadContext PSAssemblyLoadContext
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1003, 4680, 4721);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 4683, 4721);
                    return f_1003_4683_4721();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1003, 4680, 4721);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1003, 4680, 4721);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1003, 4680, 4721);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static Encoding GetDefaultEncoding()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1003, 4890, 5228);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 4960, 5176) || true) && (s_defaultEncoding == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1003, 4960, 5176);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 5072, 5099);

                    f_1003_5072_5098();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 5117, 5161);

                    s_defaultEncoding = f_1003_5137_5160(false);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1003, 4960, 5176);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 5192, 5217);

                return s_defaultEncoding;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1003, 4890, 5228);

                int
                f_1003_5072_5098()
                {
                    EncodingRegisterProvider();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 5072, 5098);
                    return 0;
                }


                System.Text.UTF8Encoding
                f_1003_5137_5160(bool
                encoderShouldEmitUTF8Identifier)
                {
                    var return_v = new System.Text.UTF8Encoding(encoderShouldEmitUTF8Identifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 5137, 5160);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1003, 4890, 5228);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1003, 4890, 5228);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static volatile Encoding s_defaultEncoding;

        internal static Encoding GetOEMEncoding()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1003, 5514, 5984);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 5580, 5936) || true) && (s_oemEncoding == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1003, 5580, 5936);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 5688, 5715);

                    f_1003_5688_5714();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 5808, 5846);

                    uint
                    oemCp = f_1003_5821_5845()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 5864, 5913);

                    s_oemEncoding = f_1003_5880_5912(oemCp);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1003, 5580, 5936);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 5952, 5973);

                return s_oemEncoding;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1003, 5514, 5984);

                int
                f_1003_5688_5714()
                {
                    EncodingRegisterProvider();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 5688, 5714);
                    return 0;
                }


                uint
                f_1003_5821_5845()
                {
                    var return_v = NativeMethods.GetOEMCP();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 5821, 5845);
                    return return_v;
                }


                System.Text.Encoding
                f_1003_5880_5912(uint
                codepage)
                {
                    var return_v = Encoding.GetEncoding((int)codepage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 5880, 5912);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1003, 5514, 5984);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1003, 5514, 5984);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static volatile Encoding s_oemEncoding;

        private static void EncodingRegisterProvider()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1003, 6055, 6302);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 6126, 6291) || true) && (s_defaultEncoding == null && (DynAbs.Tracing.TraceSender.Expression_True(1003, 6130, 6180) && s_oemEncoding == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1003, 6126, 6291);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 6214, 6276);

                    f_1003_6214_6275(f_1003_6240_6274());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1003, 6126, 6291);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1003, 6055, 6302);

                System.Text.EncodingProvider
                f_1003_6240_6274()
                {
                    var return_v = CodePagesEncodingProvider.Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1003, 6240, 6274);
                    return return_v;
                }


                int
                f_1003_6214_6275(System.Text.EncodingProvider
                provider)
                {
                    Encoding.RegisterProvider(provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 6214, 6275);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1003, 6055, 6302);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1003, 6055, 6302);
            }
        }

        internal static SecurityZone GetFileSecurityZone(string filePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1003, 6498, 6829);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 6588, 6677);

                f_1003_6588_6676(f_1003_6607_6634(filePath), "Caller makes sure the path is rooted.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 6691, 6771);

                f_1003_6691_6770(f_1003_6710_6731(filePath), "Caller makes sure the file exists.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 6785, 6818);

                return f_1003_6792_6817(filePath);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1003, 6498, 6829);

                bool
                f_1003_6607_6634(string
                path)
                {
                    var return_v = Path.IsPathRooted(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 6607, 6634);
                    return return_v;
                }


                int
                f_1003_6588_6676(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 6588, 6676);
                    return 0;
                }


                bool
                f_1003_6710_6731(string
                path)
                {
                    var return_v = File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 6710, 6731);
                    return return_v;
                }


                int
                f_1003_6691_6770(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 6691, 6770);
                    return 0;
                }


                System.Security.SecurityZone
                f_1003_6792_6817(string
                filePath)
                {
                    var return_v = MapSecurityZone(filePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 6792, 6817);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1003, 6498, 6829);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1003, 6498, 6829);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static SecurityZone MapSecurityZone(string filePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1003, 9627, 11446);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 9712, 9776);

                SecurityZone
                reval = f_1003_9733_9775(filePath)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 9790, 9841) || true) && (reval != SecurityZone.NoZone)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1003, 9790, 9841);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 9826, 9839);

                    return reval;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1003, 9790, 9841);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 10064, 10092);

                Uri
                uri = f_1003_10074_10091(filePath)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 10106, 10906) || true) && (f_1003_10110_10119(uri))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1003, 10106, 10906);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 10153, 10263) || true) && (f_1003_10157_10171(uri))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1003, 10153, 10263);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 10213, 10244);

                        return SecurityZone.MyComputer;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1003, 10153, 10263);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 10283, 10482) || true) && (f_1003_10287_10303(uri) == UriHostNameType.IPv4 || (DynAbs.Tracing.TraceSender.Expression_False(1003, 10287, 10392) || f_1003_10352_10368(uri) == UriHostNameType.IPv6))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1003, 10283, 10482);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 10434, 10463);

                        return SecurityZone.Internet;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1003, 10283, 10482);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 10763, 10790);

                    string
                    hostName = f_1003_10781_10789(uri)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 10808, 10891);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1003, 10815, 10842) || ((f_1003_10815_10836(hostName, '.') == -1 && DynAbs.Tracing.TraceSender.Conditional_F2(1003, 10845, 10866)) || DynAbs.Tracing.TraceSender.Conditional_F3(1003, 10869, 10890))) ? SecurityZone.Intranet : SecurityZone.Internet;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1003, 10106, 10906);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 10922, 10963);

                string
                root = f_1003_10936_10962(filePath)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 10977, 11015);

                DriveInfo
                drive = f_1003_10995_11014(root)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 11029, 11435);

                switch (f_1003_11037_11052(drive))
                {

                    case DriveType.NoRootDirectory:
                    case DriveType.Unknown:
                    case DriveType.CDRom:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1003, 11029, 11435);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 11219, 11249);

                        return SecurityZone.Untrusted;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1003, 11029, 11435);

                    case DriveType.Network:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1003, 11029, 11435);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 11312, 11341);

                        return SecurityZone.Intranet;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1003, 11029, 11435);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1003, 11029, 11435);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 11389, 11420);

                        return SecurityZone.MyComputer;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1003, 11029, 11435);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1003, 9627, 11446);

                System.Security.SecurityZone
                f_1003_9733_9775(string
                filePath)
                {
                    var return_v = ReadFromZoneIdentifierDataStream(filePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 9733, 9775);
                    return return_v;
                }


                System.Uri
                f_1003_10074_10091(string
                uriString)
                {
                    var return_v = new System.Uri(uriString);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 10074, 10091);
                    return return_v;
                }


                bool
                f_1003_10110_10119(System.Uri
                this_param)
                {
                    var return_v = this_param.IsUnc;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1003, 10110, 10119);
                    return return_v;
                }


                bool
                f_1003_10157_10171(System.Uri
                this_param)
                {
                    var return_v = this_param.IsLoopback;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1003, 10157, 10171);
                    return return_v;
                }


                System.UriHostNameType
                f_1003_10287_10303(System.Uri
                this_param)
                {
                    var return_v = this_param.HostNameType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1003, 10287, 10303);
                    return return_v;
                }


                System.UriHostNameType
                f_1003_10352_10368(System.Uri
                this_param)
                {
                    var return_v = this_param.HostNameType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1003, 10352, 10368);
                    return return_v;
                }


                string
                f_1003_10781_10789(System.Uri
                this_param)
                {
                    var return_v = this_param.Host;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1003, 10781, 10789);
                    return return_v;
                }


                int
                f_1003_10815_10836(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 10815, 10836);
                    return return_v;
                }


                string?
                f_1003_10936_10962(string
                path)
                {
                    var return_v = Path.GetPathRoot(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 10936, 10962);
                    return return_v;
                }


                System.IO.DriveInfo
                f_1003_10995_11014(string
                driveName)
                {
                    var return_v = new System.IO.DriveInfo(driveName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 10995, 11014);
                    return return_v;
                }


                System.IO.DriveType
                f_1003_11037_11052(System.IO.DriveInfo
                this_param)
                {
                    var return_v = this_param.DriveType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1003, 11037, 11052);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1003, 9627, 11446);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1003, 9627, 11446);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static SecurityZone ReadFromZoneIdentifierDataStream(string filePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1003, 11605, 14397);
                System.IO.FileStream zoneDataStream = default(System.IO.FileStream);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 11707, 11937) || true) && (!f_1003_11712_11861(filePath, "Zone.Identifier", FileMode.Open, FileAccess.Read, FileShare.Read, out zoneDataStream))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1003, 11707, 11937);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 11895, 11922);

                    return SecurityZone.NoZone;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1003, 11707, 11937);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 12049, 14343);
                using (StreamReader
                zoneDataReader = f_1003_12086_12140(zoneDataStream, f_1003_12119_12139())
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 12174, 12193);

                    string
                    line = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 12211, 12244);

                    bool
                    zoneTransferMatched = false
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 13210, 14328) || true) && ((line = f_1003_13225_13250(zoneDataReader)) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1003, 13210, 14328);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 13301, 13320);

                            line = f_1003_13308_13319(line);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 13342, 14309) || true) && (!zoneTransferMatched)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1003, 13342, 14309);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 13416, 13505);

                                zoneTransferMatched = f_1003_13438_13504(line, @"^\[ZoneTransfer\]", RegexOptions.IgnoreCase);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1003, 13342, 14309);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1003, 13342, 14309);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 13603, 13683);

                                Match
                                match = f_1003_13617_13682(line, @"^ZoneId\s*=\s*(.*)", RegexOptions.IgnoreCase)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 13709, 13742) || true) && (f_1003_13713_13727_M(!match.Success))
                                )
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1003, 13709, 13742);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 13731, 13740);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1003, 13709, 13742);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 13834, 13880);

                                string
                                zoneIdRawValue = f_1003_13858_13879(f_1003_13858_13873(f_1003_13858_13870(match), 1))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 13906, 13981);

                                match = f_1003_13914_13980(zoneIdRawValue, @"^[+-]?\d+", RegexOptions.IgnoreCase);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 14007, 14058) || true) && (f_1003_14011_14025_M(!match.Success))
                                )
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1003, 14007, 14058);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 14029, 14056);

                                    return SecurityZone.NoZone;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1003, 14007, 14058);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 14086, 14124);

                                string
                                zoneId = f_1003_14102_14123(f_1003_14102_14117(f_1003_14102_14114(match), 0))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 14150, 14170);

                                SecurityZone
                                result
                                = default(SecurityZone);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 14196, 14286);

                                return (DynAbs.Tracing.TraceSender.Conditional_F1(1003, 14203, 14254) || ((f_1003_14203_14254(zoneId, out result) && DynAbs.Tracing.TraceSender.Conditional_F2(1003, 14257, 14263)) || DynAbs.Tracing.TraceSender.Conditional_F3(1003, 14266, 14285))) ? result : SecurityZone.NoZone;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1003, 13342, 14309);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1003, 13210, 14328);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1003, 13210, 14328);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1003, 13210, 14328);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1003, 12049, 14343);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 14359, 14386);

                return SecurityZone.NoZone;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1003, 11605, 14397);

                bool
                f_1003_11712_11861(string
                path, string
                streamName, System.IO.FileMode
                mode, System.IO.FileAccess
                access, System.IO.FileShare
                share, out System.IO.FileStream
                stream)
                {
                    var return_v = AlternateDataStreamUtilities.TryCreateFileStream(path, streamName, mode, access, share, out stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 11712, 11861);
                    return return_v;
                }


                System.Text.Encoding
                f_1003_12119_12139()
                {
                    var return_v = GetDefaultEncoding();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 12119, 12139);
                    return return_v;
                }


                System.IO.StreamReader
                f_1003_12086_12140(System.IO.FileStream
                stream, System.Text.Encoding
                encoding)
                {
                    var return_v = new System.IO.StreamReader((System.IO.Stream)stream, encoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 12086, 12140);
                    return return_v;
                }


                string?
                f_1003_13225_13250(System.IO.StreamReader
                this_param)
                {
                    var return_v = this_param.ReadLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 13225, 13250);
                    return return_v;
                }


                string
                f_1003_13308_13319(string
                this_param)
                {
                    var return_v = this_param.Trim();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 13308, 13319);
                    return return_v;
                }


                bool
                f_1003_13438_13504(string
                input, string
                pattern, System.Text.RegularExpressions.RegexOptions
                options)
                {
                    var return_v = Regex.IsMatch(input, pattern, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 13438, 13504);
                    return return_v;
                }


                System.Text.RegularExpressions.Match
                f_1003_13617_13682(string
                input, string
                pattern, System.Text.RegularExpressions.RegexOptions
                options)
                {
                    var return_v = Regex.Match(input, pattern, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 13617, 13682);
                    return return_v;
                }


                bool
                f_1003_13713_13727_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1003, 13713, 13727);
                    return return_v;
                }


                System.Text.RegularExpressions.GroupCollection
                f_1003_13858_13870(System.Text.RegularExpressions.Match
                this_param)
                {
                    var return_v = this_param.Groups;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1003, 13858, 13870);
                    return return_v;
                }


                System.Text.RegularExpressions.Group
                f_1003_13858_13873(System.Text.RegularExpressions.GroupCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1003, 13858, 13873);
                    return return_v;
                }


                string
                f_1003_13858_13879(System.Text.RegularExpressions.Group
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1003, 13858, 13879);
                    return return_v;
                }


                System.Text.RegularExpressions.Match
                f_1003_13914_13980(string
                input, string
                pattern, System.Text.RegularExpressions.RegexOptions
                options)
                {
                    var return_v = Regex.Match(input, pattern, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 13914, 13980);
                    return return_v;
                }


                bool
                f_1003_14011_14025_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1003, 14011, 14025);
                    return return_v;
                }


                System.Text.RegularExpressions.GroupCollection
                f_1003_14102_14114(System.Text.RegularExpressions.Match
                this_param)
                {
                    var return_v = this_param.Groups;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1003, 14102, 14114);
                    return return_v;
                }


                System.Text.RegularExpressions.Group
                f_1003_14102_14117(System.Text.RegularExpressions.GroupCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1003, 14102, 14117);
                    return return_v;
                }


                string
                f_1003_14102_14123(System.Text.RegularExpressions.Group
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1003, 14102, 14123);
                    return return_v;
                }


                bool
                f_1003_14203_14254(string
                valueToConvert, out System.Security.SecurityZone
                result)
                {
                    var return_v = LanguagePrimitives.TryConvertTo((object)valueToConvert, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 14203, 14254);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1003, 11605, 14397);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1003, 11605, 14397);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string ToDmtfDateTime(DateTime date)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1003, 14596, 17932);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 15123, 15154);

                const int
                maxsizeUtcDmtf = 999
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 15168, 15200);

                string
                UtcString = string.Empty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 15302, 15344);

                TimeZoneInfo
                curZone = f_1003_15325_15343()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 15358, 15407);

                TimeSpan
                tickOffset = f_1003_15380_15406(curZone, date)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 15421, 15484);

                long
                OffsetMins = (tickOffset.Ticks / TimeSpan.TicksPerMinute)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 15498, 15594);

                IFormatProvider
                frmInt32 = (IFormatProvider)f_1003_15542_15593(f_1003_15542_15570(), typeof(int))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 15751, 16326) || true) && (f_1003_15755_15775(OffsetMins) > maxsizeUtcDmtf)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1003, 15751, 16326);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 15826, 15856);

                    date = date.ToUniversalTime();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 15874, 15893);

                    UtcString = "+000";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1003, 15751, 16326);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1003, 15751, 16326);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 15944, 16326) || true) && ((tickOffset.Ticks >= 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1003, 15944, 16326);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 16005, 16105);

                        UtcString = "+" + f_1003_16023_16104(f_1003_16023_16088(((tickOffset.Ticks / TimeSpan.TicksPerMinute)), frmInt32), 3, '0');
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1003, 15944, 16326);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1003, 15944, 16326);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 16171, 16218);

                        string
                        strTemp = f_1003_16188_16217(OffsetMins, frmInt32)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 16236, 16311);

                        UtcString = "-" + f_1003_16254_16310(f_1003_16254_16294(strTemp, 1, f_1003_16275_16289(strTemp) - 1), 3, '0');
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1003, 15944, 16326);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1003, 15751, 16326);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 16342, 16409);

                string
                dmtfDateTime = f_1003_16364_16408(f_1003_16364_16392(date.Year, frmInt32), 4, '0')
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 16425, 16503);

                dmtfDateTime = (dmtfDateTime + f_1003_16456_16501(f_1003_16456_16485(date.Month, frmInt32), 2, '0'));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 16517, 16593);

                dmtfDateTime = (dmtfDateTime + f_1003_16548_16591(f_1003_16548_16575(date.Day, frmInt32), 2, '0'));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 16607, 16684);

                dmtfDateTime = (dmtfDateTime + f_1003_16638_16682(f_1003_16638_16666(date.Hour, frmInt32), 2, '0'));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 16698, 16777);

                dmtfDateTime = (dmtfDateTime + f_1003_16729_16775(f_1003_16729_16759(date.Minute, frmInt32), 2, '0'));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 16791, 16870);

                dmtfDateTime = (dmtfDateTime + f_1003_16822_16868(f_1003_16822_16852(date.Second, frmInt32), 2, '0'));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 16884, 16920);

                dmtfDateTime = (dmtfDateTime + ".");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 17129, 17233);

                DateTime
                dtTemp = f_1003_17147_17232(date.Year, date.Month, date.Day, date.Hour, date.Minute, date.Second, 0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 17247, 17332);

                Int64
                microsec = ((date.Ticks - dtTemp.Ticks) * 1000) / TimeSpan.TicksPerMillisecond
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 17392, 17503);

                string
                strMicrosec = f_1003_17413_17502(microsec, f_1003_17448_17501(f_1003_17448_17476(), typeof(Int64)))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 17517, 17634) || true) && (f_1003_17521_17539(strMicrosec) > 6)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1003, 17517, 17634);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 17577, 17619);

                    strMicrosec = f_1003_17591_17618(strMicrosec, 0, 6);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1003, 17517, 17634);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 17650, 17708);

                dmtfDateTime = dmtfDateTime + f_1003_17680_17707(strMicrosec, 6, '0');
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 17760, 17800);

                dmtfDateTime = dmtfDateTime + UtcString;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1003, 17816, 17836);

                return dmtfDateTime;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1003, 14596, 17932);

                System.TimeZoneInfo
                f_1003_15325_15343()
                {
                    var return_v = TimeZoneInfo.Local;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1003, 15325, 15343);
                    return return_v;
                }


                System.TimeSpan
                f_1003_15380_15406(System.TimeZoneInfo
                this_param, System.DateTime
                dateTime)
                {
                    var return_v = this_param.GetUtcOffset(dateTime);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 15380, 15406);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1003_15542_15570()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1003, 15542, 15570);
                    return return_v;
                }


                object?
                f_1003_15542_15593(System.Globalization.CultureInfo
                this_param, System.Type
                formatType)
                {
                    var return_v = this_param.GetFormat(formatType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 15542, 15593);
                    return return_v;
                }


                long
                f_1003_15755_15775(long
                value)
                {
                    var return_v = Math.Abs(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 15755, 15775);
                    return return_v;
                }


                string
                f_1003_16023_16088(long
                this_param, System.IFormatProvider
                provider)
                {
                    var return_v = this_param.ToString(provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 16023, 16088);
                    return return_v;
                }


                string
                f_1003_16023_16104(string
                this_param, int
                totalWidth, char
                paddingChar)
                {
                    var return_v = this_param.PadLeft(totalWidth, paddingChar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 16023, 16104);
                    return return_v;
                }


                string
                f_1003_16188_16217(long
                this_param, System.IFormatProvider
                provider)
                {
                    var return_v = this_param.ToString(provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 16188, 16217);
                    return return_v;
                }


                int
                f_1003_16275_16289(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1003, 16275, 16289);
                    return return_v;
                }


                string
                f_1003_16254_16294(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 16254, 16294);
                    return return_v;
                }


                string
                f_1003_16254_16310(string
                this_param, int
                totalWidth, char
                paddingChar)
                {
                    var return_v = this_param.PadLeft(totalWidth, paddingChar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 16254, 16310);
                    return return_v;
                }


                string
                f_1003_16364_16392(int
                this_param, System.IFormatProvider
                provider)
                {
                    var return_v = this_param.ToString(provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 16364, 16392);
                    return return_v;
                }


                string
                f_1003_16364_16408(string
                this_param, int
                totalWidth, char
                paddingChar)
                {
                    var return_v = this_param.PadLeft(totalWidth, paddingChar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 16364, 16408);
                    return return_v;
                }


                string
                f_1003_16456_16485(int
                this_param, System.IFormatProvider
                provider)
                {
                    var return_v = this_param.ToString(provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 16456, 16485);
                    return return_v;
                }


                string
                f_1003_16456_16501(string
                this_param, int
                totalWidth, char
                paddingChar)
                {
                    var return_v = this_param.PadLeft(totalWidth, paddingChar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 16456, 16501);
                    return return_v;
                }


                string
                f_1003_16548_16575(int
                this_param, System.IFormatProvider
                provider)
                {
                    var return_v = this_param.ToString(provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 16548, 16575);
                    return return_v;
                }


                string
                f_1003_16548_16591(string
                this_param, int
                totalWidth, char
                paddingChar)
                {
                    var return_v = this_param.PadLeft(totalWidth, paddingChar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 16548, 16591);
                    return return_v;
                }


                string
                f_1003_16638_16666(int
                this_param, System.IFormatProvider
                provider)
                {
                    var return_v = this_param.ToString(provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 16638, 16666);
                    return return_v;
                }


                string
                f_1003_16638_16682(string
                this_param, int
                totalWidth, char
                paddingChar)
                {
                    var return_v = this_param.PadLeft(totalWidth, paddingChar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 16638, 16682);
                    return return_v;
                }


                string
                f_1003_16729_16759(int
                this_param, System.IFormatProvider
                provider)
                {
                    var return_v = this_param.ToString(provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 16729, 16759);
                    return return_v;
                }


                string
                f_1003_16729_16775(string
                this_param, int
                totalWidth, char
                paddingChar)
                {
                    var return_v = this_param.PadLeft(totalWidth, paddingChar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 16729, 16775);
                    return return_v;
                }


                string
                f_1003_16822_16852(int
                this_param, System.IFormatProvider
                provider)
                {
                    var return_v = this_param.ToString(provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 16822, 16852);
                    return return_v;
                }


                string
                f_1003_16822_16868(string
                this_param, int
                totalWidth, char
                paddingChar)
                {
                    var return_v = this_param.PadLeft(totalWidth, paddingChar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 16822, 16868);
                    return return_v;
                }


                System.DateTime
                f_1003_17147_17232(int
                year, int
                month, int
                day, int
                hour, int
                minute, int
                second, int
                millisecond)
                {
                    var return_v = new System.DateTime(year, month, day, hour, minute, second, millisecond);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 17147, 17232);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1003_17448_17476()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1003, 17448, 17476);
                    return return_v;
                }


                object?
                f_1003_17448_17501(System.Globalization.CultureInfo
                this_param, System.Type
                formatType)
                {
                    var return_v = this_param.GetFormat(formatType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 17448, 17501);
                    return return_v;
                }


                string
                f_1003_17413_17502(long
                this_param, object
                provider)
                {
                    var return_v = this_param.ToString((System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 17413, 17502);
                    return return_v;
                }


                int
                f_1003_17521_17539(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1003, 17521, 17539);
                    return return_v;
                }


                string
                f_1003_17591_17618(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 17591, 17618);
                    return return_v;
                }


                string
                f_1003_17680_17707(string
                this_param, int
                totalWidth, char
                paddingChar)
                {
                    var return_v = this_param.PadLeft(totalWidth, paddingChar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 17680, 17707);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1003, 14596, 17932);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1003, 14596, 17932);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private static class NativeMethods
        {
            [DllImport(PinvokeDllNames.GetOEMCPDllName, SetLastError = false, CharSet = CharSet.Unicode)]
            internal static extern uint GetOEMCP();

            static NativeMethods()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1003, 18079, 18414);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1003, 18079, 18414);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1003, 18079, 18414);
            }

        }

        static System.Management.Automation.PowerShellAssemblyLoadContext
        f_1003_1389_1427()
        {
            var return_v = PowerShellAssemblyLoadContext.Instance;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1003, 1389, 1427);
            return return_v;
        }


        static System.Management.Automation.PowerShellAssemblyLoadContext
        f_1003_1469_1532(string
        basePaths)
        {
            var return_v = PowerShellAssemblyLoadContext.InitializeSingleton(basePaths);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1003, 1469, 1532);
            return return_v;
        }


        static System.Management.Automation.PowerShellAssemblyLoadContext
        f_1003_4211_4232()
        {
            var return_v = PSAssemblyLoadContext;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1003, 4211, 4232);
            return return_v;
        }


        static System.Collections.Generic.IEnumerable<string>
        f_1003_4211_4257(System.Management.Automation.PowerShellAssemblyLoadContext
        this_param)
        {
            var return_v = this_param.AvailableDotNetTypeNames;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1003, 4211, 4257);
            return return_v;
        }


        static System.Management.Automation.PowerShellAssemblyLoadContext
        f_1003_4550_4571()
        {
            var return_v = PSAssemblyLoadContext;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1003, 4550, 4571);
            return return_v;
        }


        static System.Collections.Generic.HashSet<string>
        f_1003_4550_4600(System.Management.Automation.PowerShellAssemblyLoadContext
        this_param)
        {
            var return_v = this_param.AvailableDotNetAssemblyNames;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1003, 4550, 4600);
            return return_v;
        }


        static System.Management.Automation.PowerShellAssemblyLoadContext
        f_1003_4683_4721()
        {
            var return_v = PowerShellAssemblyLoadContext.Instance;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1003, 4683, 4721);
            return return_v;
        }

    }
}
