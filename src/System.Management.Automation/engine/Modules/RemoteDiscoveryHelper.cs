// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management.Automation.Language;
using System.Management.Automation.Runspaces;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Xml;

using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using Microsoft.PowerShell;
using Microsoft.PowerShell.Commands;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation
{
    internal class RemoteDiscoveryHelper
    {
        private static Collection<string> RehydrateHashtableKeys(PSObject pso, string propertyName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1538, 889, 1820);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 1005, 1184);

                var
                rehydrationFlags = DeserializingTypeConverter.RehydrationFlags.NullValueOk |
                                                   DeserializingTypeConverter.RehydrationFlags.MissingPropertyOk
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 1198, 1312);

                Hashtable
                hashtable = f_1538_1220_1311(pso, propertyName, rehydrationFlags)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 1326, 1809) || true) && (hashtable == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 1326, 1809);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 1381, 1413);

                    return f_1538_1388_1412();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 1326, 1809);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 1326, 1809);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 1479, 1740);

                    List<string>
                    list = f_1538_1499_1739(f_1538_1499_1708(f_1538_1499_1664(f_1538_1499_1616(f_1538_1499_1572(f_1538_1499_1535(hashtable)), k => k != null), k => k.ToString()), s => s != null))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 1758, 1794);

                    return f_1538_1765_1793(list);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 1326, 1809);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1538, 889, 1820);

                System.Collections.Hashtable
                f_1538_1220_1311(System.Management.Automation.PSObject
                pso, string
                propertyName, Microsoft.PowerShell.DeserializingTypeConverter.RehydrationFlags
                flags)
                {
                    var return_v = DeserializingTypeConverter.GetPropertyValue<Hashtable>(pso, propertyName, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 1220, 1311);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1538_1388_1412()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 1388, 1412);
                    return return_v;
                }


                System.Collections.ICollection
                f_1538_1499_1535(System.Collections.Hashtable
                this_param)
                {
                    var return_v = this_param.Keys
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 1499, 1535);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<object>
                f_1538_1499_1572(System.Collections.ICollection
                source)
                {
                    var return_v = source.Cast<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 1499, 1572);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<object>
                f_1538_1499_1616(System.Collections.Generic.IEnumerable<object>
                source, System.Func<object, bool>
                predicate)
                {
                    var return_v = source.Where<object>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 1499, 1616);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1538_1499_1664(System.Collections.Generic.IEnumerable<object>
                source, System.Func<object, string>
                selector)
                {
                    var return_v = source.Select<object, string>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 1499, 1664);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1538_1499_1708(System.Collections.Generic.IEnumerable<string>
                source, System.Func<string, bool>
                predicate)
                {
                    var return_v = source.Where<string>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 1499, 1708);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1538_1499_1739(System.Collections.Generic.IEnumerable<string>
                source)
                {
                    var return_v = source.ToList<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 1499, 1739);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1538_1765_1793(System.Collections.Generic.List<string>
                list)
                {
                    var return_v = new System.Collections.ObjectModel.Collection<string>((System.Collections.Generic.IList<string>)list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 1765, 1793);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1538, 889, 1820);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1538, 889, 1820);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static PSModuleInfo RehydratePSModuleInfo(PSObject deserializedModuleInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1538, 1832, 6887);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 1940, 2119);

                var
                rehydrationFlags = DeserializingTypeConverter.RehydrationFlags.NullValueOk |
                                                   DeserializingTypeConverter.RehydrationFlags.MissingPropertyOk
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 2133, 2249);

                string
                name = f_1538_2147_2248(deserializedModuleInfo, "Name", rehydrationFlags)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 2263, 2379);

                string
                path = f_1538_2277_2378(deserializedModuleInfo, "Path", rehydrationFlags)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 2393, 2483);

                PSModuleInfo
                moduleInfo = f_1538_2419_2482(name, path, context: null, sessionState: null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 2499, 2619);

                f_1538_2499_2618(
                            moduleInfo, f_1538_2518_2617(deserializedModuleInfo, "Guid", rehydrationFlags));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 2633, 2771);

                f_1538_2633_2770(moduleInfo, f_1538_2658_2769(deserializedModuleInfo, "ModuleType", rehydrationFlags));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 2785, 2914);

                f_1538_2785_2913(moduleInfo, f_1538_2807_2912(deserializedModuleInfo, "Version", rehydrationFlags));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 2928, 3064);

                f_1538_2928_3063(moduleInfo, f_1538_2954_3062(deserializedModuleInfo, "HelpInfoUri", rehydrationFlags));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 3080, 3222);

                moduleInfo.AccessMode = f_1538_3104_3221(deserializedModuleInfo, "AccessMode", rehydrationFlags);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 3236, 3360);

                moduleInfo.Author = f_1538_3256_3359(deserializedModuleInfo, "Author", rehydrationFlags);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 3374, 3507);

                moduleInfo.ClrVersion = f_1538_3398_3506(deserializedModuleInfo, "ClrVersion", rehydrationFlags);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 3521, 3655);

                moduleInfo.CompanyName = f_1538_3546_3654(deserializedModuleInfo, "CompanyName", rehydrationFlags);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 3669, 3799);

                moduleInfo.Copyright = f_1538_3692_3798(deserializedModuleInfo, "Copyright", rehydrationFlags);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 3813, 3947);

                moduleInfo.Description = f_1538_3838_3946(deserializedModuleInfo, "Description", rehydrationFlags);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 3961, 4118);

                moduleInfo.DotNetFrameworkVersion = f_1538_3997_4117(deserializedModuleInfo, "DotNetFrameworkVersion", rehydrationFlags);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 4132, 4280);

                moduleInfo.PowerShellHostName = f_1538_4164_4279(deserializedModuleInfo, "PowerShellHostName", rehydrationFlags);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 4294, 4449);

                moduleInfo.PowerShellHostVersion = f_1538_4329_4448(deserializedModuleInfo, "PowerShellHostVersion", rehydrationFlags);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 4463, 4610);

                moduleInfo.PowerShellVersion = f_1538_4494_4609(deserializedModuleInfo, "PowerShellVersion", rehydrationFlags);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 4624, 4804);

                moduleInfo.ProcessorArchitecture = f_1538_4659_4803(deserializedModuleInfo, "ProcessorArchitecture", rehydrationFlags);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 4820, 4920);

                moduleInfo.DeclaredAliasExports = f_1538_4854_4919(deserializedModuleInfo, "ExportedAliases");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 4934, 5035);

                moduleInfo.DeclaredCmdletExports = f_1538_4969_5034(deserializedModuleInfo, "ExportedCmdlets");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 5049, 5154);

                moduleInfo.DeclaredFunctionExports = f_1538_5086_5153(deserializedModuleInfo, "ExportedFunctions");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 5168, 5273);

                moduleInfo.DeclaredVariableExports = f_1538_5205_5272(deserializedModuleInfo, "ExportedVariables");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 5289, 5436);

                var
                compatiblePSEditions = f_1538_5316_5435(deserializedModuleInfo, "CompatiblePSEditions", rehydrationFlags)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 5450, 5712) || true) && (compatiblePSEditions != null && (DynAbs.Tracing.TraceSender.Expression_True(1538, 5454, 5512) && f_1538_5486_5512(compatiblePSEditions)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 5450, 5712);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 5546, 5697);
                        foreach (var edition in f_1538_5570_5590_I(compatiblePSEditions))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 5546, 5697);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 5632, 5678);

                            f_1538_5632_5677(moduleInfo, edition);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 5546, 5697);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1538, 1, 152);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1538, 1, 152);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 5450, 5712);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 5777, 5892);

                var
                tags = f_1538_5788_5891(deserializedModuleInfo, "Tags", rehydrationFlags)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 5906, 6096) || true) && (tags != null && (DynAbs.Tracing.TraceSender.Expression_True(1538, 5910, 5936) && f_1538_5926_5936(tags)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 5906, 6096);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 5970, 6081);
                        foreach (var tag in f_1538_5990_5994_I(tags))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 5970, 6081);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 6036, 6062);

                            f_1538_6036_6061(moduleInfo, tag);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 5970, 6081);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1538, 1, 112);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1538, 1, 112);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 5906, 6096);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 6112, 6248);

                moduleInfo.ReleaseNotes = f_1538_6138_6247(deserializedModuleInfo, "ReleaseNotes", rehydrationFlags);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 6262, 6391);

                moduleInfo.ProjectUri = f_1538_6286_6390(deserializedModuleInfo, "ProjectUri", rehydrationFlags);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 6405, 6534);

                moduleInfo.LicenseUri = f_1538_6429_6533(deserializedModuleInfo, "LicenseUri", rehydrationFlags);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 6548, 6671);

                moduleInfo.IconUri = f_1538_6569_6670(deserializedModuleInfo, "IconUri", rehydrationFlags);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 6685, 6842);

                moduleInfo.RepositorySourceLocation = f_1538_6723_6841(deserializedModuleInfo, "RepositorySourceLocation", rehydrationFlags);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 6858, 6876);

                return moduleInfo;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1538, 1832, 6887);

                string
                f_1538_2147_2248(System.Management.Automation.PSObject
                pso, string
                propertyName, Microsoft.PowerShell.DeserializingTypeConverter.RehydrationFlags
                flags)
                {
                    var return_v = DeserializingTypeConverter.GetPropertyValue<string>(pso, propertyName, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 2147, 2248);
                    return return_v;
                }


                string
                f_1538_2277_2378(System.Management.Automation.PSObject
                pso, string
                propertyName, Microsoft.PowerShell.DeserializingTypeConverter.RehydrationFlags
                flags)
                {
                    var return_v = DeserializingTypeConverter.GetPropertyValue<string>(pso, propertyName, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 2277, 2378);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1538_2419_2482(string
                name, string
                path, System.Management.Automation.ExecutionContext
                context, System.Management.Automation.SessionState
                sessionState)
                {
                    var return_v = new System.Management.Automation.PSModuleInfo(name, path, context: context, sessionState: sessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 2419, 2482);
                    return return_v;
                }


                System.Guid
                f_1538_2518_2617(System.Management.Automation.PSObject
                pso, string
                propertyName, Microsoft.PowerShell.DeserializingTypeConverter.RehydrationFlags
                flags)
                {
                    var return_v = DeserializingTypeConverter.GetPropertyValue<Guid>(pso, propertyName, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 2518, 2617);
                    return return_v;
                }


                int
                f_1538_2499_2618(System.Management.Automation.PSModuleInfo
                this_param, System.Guid
                guid)
                {
                    this_param.SetGuid(guid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 2499, 2618);
                    return 0;
                }


                System.Management.Automation.ModuleType
                f_1538_2658_2769(System.Management.Automation.PSObject
                pso, string
                propertyName, Microsoft.PowerShell.DeserializingTypeConverter.RehydrationFlags
                flags)
                {
                    var return_v = DeserializingTypeConverter.GetPropertyValue<ModuleType>(pso, propertyName, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 2658, 2769);
                    return return_v;
                }


                int
                f_1538_2633_2770(System.Management.Automation.PSModuleInfo
                this_param, System.Management.Automation.ModuleType
                moduleType)
                {
                    this_param.SetModuleType(moduleType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 2633, 2770);
                    return 0;
                }


                System.Version
                f_1538_2807_2912(System.Management.Automation.PSObject
                pso, string
                propertyName, Microsoft.PowerShell.DeserializingTypeConverter.RehydrationFlags
                flags)
                {
                    var return_v = DeserializingTypeConverter.GetPropertyValue<Version>(pso, propertyName, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 2807, 2912);
                    return return_v;
                }


                int
                f_1538_2785_2913(System.Management.Automation.PSModuleInfo
                this_param, System.Version
                version)
                {
                    this_param.SetVersion(version);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 2785, 2913);
                    return 0;
                }


                string
                f_1538_2954_3062(System.Management.Automation.PSObject
                pso, string
                propertyName, Microsoft.PowerShell.DeserializingTypeConverter.RehydrationFlags
                flags)
                {
                    var return_v = DeserializingTypeConverter.GetPropertyValue<string>(pso, propertyName, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 2954, 3062);
                    return return_v;
                }


                int
                f_1538_2928_3063(System.Management.Automation.PSModuleInfo
                this_param, string
                uri)
                {
                    this_param.SetHelpInfoUri(uri);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 2928, 3063);
                    return 0;
                }


                System.Management.Automation.ModuleAccessMode
                f_1538_3104_3221(System.Management.Automation.PSObject
                pso, string
                propertyName, Microsoft.PowerShell.DeserializingTypeConverter.RehydrationFlags
                flags)
                {
                    var return_v = DeserializingTypeConverter.GetPropertyValue<ModuleAccessMode>(pso, propertyName, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 3104, 3221);
                    return return_v;
                }


                string
                f_1538_3256_3359(System.Management.Automation.PSObject
                pso, string
                propertyName, Microsoft.PowerShell.DeserializingTypeConverter.RehydrationFlags
                flags)
                {
                    var return_v = DeserializingTypeConverter.GetPropertyValue<string>(pso, propertyName, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 3256, 3359);
                    return return_v;
                }


                System.Version
                f_1538_3398_3506(System.Management.Automation.PSObject
                pso, string
                propertyName, Microsoft.PowerShell.DeserializingTypeConverter.RehydrationFlags
                flags)
                {
                    var return_v = DeserializingTypeConverter.GetPropertyValue<Version>(pso, propertyName, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 3398, 3506);
                    return return_v;
                }


                string
                f_1538_3546_3654(System.Management.Automation.PSObject
                pso, string
                propertyName, Microsoft.PowerShell.DeserializingTypeConverter.RehydrationFlags
                flags)
                {
                    var return_v = DeserializingTypeConverter.GetPropertyValue<string>(pso, propertyName, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 3546, 3654);
                    return return_v;
                }


                string
                f_1538_3692_3798(System.Management.Automation.PSObject
                pso, string
                propertyName, Microsoft.PowerShell.DeserializingTypeConverter.RehydrationFlags
                flags)
                {
                    var return_v = DeserializingTypeConverter.GetPropertyValue<string>(pso, propertyName, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 3692, 3798);
                    return return_v;
                }


                string
                f_1538_3838_3946(System.Management.Automation.PSObject
                pso, string
                propertyName, Microsoft.PowerShell.DeserializingTypeConverter.RehydrationFlags
                flags)
                {
                    var return_v = DeserializingTypeConverter.GetPropertyValue<string>(pso, propertyName, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 3838, 3946);
                    return return_v;
                }


                System.Version
                f_1538_3997_4117(System.Management.Automation.PSObject
                pso, string
                propertyName, Microsoft.PowerShell.DeserializingTypeConverter.RehydrationFlags
                flags)
                {
                    var return_v = DeserializingTypeConverter.GetPropertyValue<Version>(pso, propertyName, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 3997, 4117);
                    return return_v;
                }


                string
                f_1538_4164_4279(System.Management.Automation.PSObject
                pso, string
                propertyName, Microsoft.PowerShell.DeserializingTypeConverter.RehydrationFlags
                flags)
                {
                    var return_v = DeserializingTypeConverter.GetPropertyValue<string>(pso, propertyName, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 4164, 4279);
                    return return_v;
                }


                System.Version
                f_1538_4329_4448(System.Management.Automation.PSObject
                pso, string
                propertyName, Microsoft.PowerShell.DeserializingTypeConverter.RehydrationFlags
                flags)
                {
                    var return_v = DeserializingTypeConverter.GetPropertyValue<Version>(pso, propertyName, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 4329, 4448);
                    return return_v;
                }


                System.Version
                f_1538_4494_4609(System.Management.Automation.PSObject
                pso, string
                propertyName, Microsoft.PowerShell.DeserializingTypeConverter.RehydrationFlags
                flags)
                {
                    var return_v = DeserializingTypeConverter.GetPropertyValue<Version>(pso, propertyName, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 4494, 4609);
                    return return_v;
                }


                System.Reflection.ProcessorArchitecture
                f_1538_4659_4803(System.Management.Automation.PSObject
                pso, string
                propertyName, Microsoft.PowerShell.DeserializingTypeConverter.RehydrationFlags
                flags)
                {
                    var return_v = DeserializingTypeConverter.GetPropertyValue<Reflection.ProcessorArchitecture>(pso, propertyName, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 4659, 4803);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1538_4854_4919(System.Management.Automation.PSObject
                pso, string
                propertyName)
                {
                    var return_v = RehydrateHashtableKeys(pso, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 4854, 4919);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1538_4969_5034(System.Management.Automation.PSObject
                pso, string
                propertyName)
                {
                    var return_v = RehydrateHashtableKeys(pso, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 4969, 5034);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1538_5086_5153(System.Management.Automation.PSObject
                pso, string
                propertyName)
                {
                    var return_v = RehydrateHashtableKeys(pso, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 5086, 5153);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1538_5205_5272(System.Management.Automation.PSObject
                pso, string
                propertyName)
                {
                    var return_v = RehydrateHashtableKeys(pso, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 5205, 5272);
                    return return_v;
                }


                string[]
                f_1538_5316_5435(System.Management.Automation.PSObject
                pso, string
                propertyName, Microsoft.PowerShell.DeserializingTypeConverter.RehydrationFlags
                flags)
                {
                    var return_v = DeserializingTypeConverter.GetPropertyValue<string[]>(pso, propertyName, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 5316, 5435);
                    return return_v;
                }


                bool
                f_1538_5486_5512(string[]
                source)
                {
                    var return_v = source.Any<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 5486, 5512);
                    return return_v;
                }


                int
                f_1538_5632_5677(System.Management.Automation.PSModuleInfo
                this_param, string
                psEdition)
                {
                    this_param.AddToCompatiblePSEditions(psEdition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 5632, 5677);
                    return 0;
                }


                string[]
                f_1538_5570_5590_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 5570, 5590);
                    return return_v;
                }


                string[]
                f_1538_5788_5891(System.Management.Automation.PSObject
                pso, string
                propertyName, Microsoft.PowerShell.DeserializingTypeConverter.RehydrationFlags
                flags)
                {
                    var return_v = DeserializingTypeConverter.GetPropertyValue<string[]>(pso, propertyName, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 5788, 5891);
                    return return_v;
                }


                bool
                f_1538_5926_5936(string[]
                source)
                {
                    var return_v = source.Any<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 5926, 5936);
                    return return_v;
                }


                int
                f_1538_6036_6061(System.Management.Automation.PSModuleInfo
                this_param, string
                tag)
                {
                    this_param.AddToTags(tag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 6036, 6061);
                    return 0;
                }


                string[]
                f_1538_5990_5994_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 5990, 5994);
                    return return_v;
                }


                string
                f_1538_6138_6247(System.Management.Automation.PSObject
                pso, string
                propertyName, Microsoft.PowerShell.DeserializingTypeConverter.RehydrationFlags
                flags)
                {
                    var return_v = DeserializingTypeConverter.GetPropertyValue<string>(pso, propertyName, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 6138, 6247);
                    return return_v;
                }


                System.Uri
                f_1538_6286_6390(System.Management.Automation.PSObject
                pso, string
                propertyName, Microsoft.PowerShell.DeserializingTypeConverter.RehydrationFlags
                flags)
                {
                    var return_v = DeserializingTypeConverter.GetPropertyValue<Uri>(pso, propertyName, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 6286, 6390);
                    return return_v;
                }


                System.Uri
                f_1538_6429_6533(System.Management.Automation.PSObject
                pso, string
                propertyName, Microsoft.PowerShell.DeserializingTypeConverter.RehydrationFlags
                flags)
                {
                    var return_v = DeserializingTypeConverter.GetPropertyValue<Uri>(pso, propertyName, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 6429, 6533);
                    return return_v;
                }


                System.Uri
                f_1538_6569_6670(System.Management.Automation.PSObject
                pso, string
                propertyName, Microsoft.PowerShell.DeserializingTypeConverter.RehydrationFlags
                flags)
                {
                    var return_v = DeserializingTypeConverter.GetPropertyValue<Uri>(pso, propertyName, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 6569, 6670);
                    return return_v;
                }


                System.Uri
                f_1538_6723_6841(System.Management.Automation.PSObject
                pso, string
                propertyName, Microsoft.PowerShell.DeserializingTypeConverter.RehydrationFlags
                flags)
                {
                    var return_v = DeserializingTypeConverter.GetPropertyValue<Uri>(pso, propertyName, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 6723, 6841);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1538, 1832, 6887);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1538, 1832, 6887);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static EventHandler<DataAddedEventArgs> GetStreamForwarder<T>(Action<T> forwardingAction, bool swallowInvalidOperationExceptions = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1538, 6899, 7969);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 7138, 7958);

                return delegate (object sender, DataAddedEventArgs eventArgs)
                                       {
                                           var psDataCollection = (PSDataCollection<T>)sender;
                                           foreach (T t in psDataCollection.ReadAll())
                                           {
                                               try
                                               {
                                                   forwardingAction(t);
                                               }
                                               catch (InvalidOperationException)
                                               {
                                                   if (!swallowInvalidOperationExceptions)
                                                   {
                                                       throw;
                                                   }
                                               }
                                           }
                                       };
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1538, 6899, 7969);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1538, 6899, 7969);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1538, 6899, 7969);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly int s_blockingCollectionCapacity;

        private static IEnumerable<PSObject> InvokeTopLevelPowerShell(
                    PowerShell powerShell,
                    CancellationToken cancellationToken,
                    PSCmdlet cmdlet,
                    PSInvocationSettings invocationSettings,
                    string errorMessageTemplate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1538, 8206, 14155);

                var listYield = new List<PSObject>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 8505, 14144);
                using (var
                mergedOutput = f_1538_8531_8622(s_blockingCollectionCapacity)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 8656, 8707);

                    var
                    asyncOutput = f_1538_8674_8706()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 8725, 8938);

                    EventHandler<DataAddedEventArgs>
                    outputHandler = f_1538_8774_8937(output => mergedOutput.Add(_ => new[] { output }), swallowInvalidOperationExceptions: true)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 8958, 9528);

                    EventHandler<DataAddedEventArgs>
                    errorHandler = f_1538_9006_9527(errorRecord => mergedOutput.Add(
                                            delegate (PSCmdlet c)
                                            {
                                                errorRecord = GetErrorRecordForRemotePipelineInvocation(errorRecord, errorMessageTemplate);
                                                HandleErrorFromPipeline(c, errorRecord, powerShell);
                                                return Enumerable.Empty<PSObject>();
                                            }), swallowInvalidOperationExceptions: true)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 9548, 9989);

                    EventHandler<DataAddedEventArgs>
                    warningHandler = f_1538_9598_9988(warningRecord => mergedOutput.Add(
                                            delegate (PSCmdlet c)
                                            {
                                                c.WriteWarning(warningRecord.Message);
                                                return Enumerable.Empty<PSObject>();
                                            }), swallowInvalidOperationExceptions: true)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 10009, 10450);

                    EventHandler<DataAddedEventArgs>
                    verboseHandler = f_1538_10059_10449(verboseRecord => mergedOutput.Add(
                                            delegate (PSCmdlet c)
                                            {
                                                c.WriteVerbose(verboseRecord.Message);
                                                return Enumerable.Empty<PSObject>();
                                            }), swallowInvalidOperationExceptions: true)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 10470, 10901);

                    EventHandler<DataAddedEventArgs>
                    debugHandler = f_1538_10518_10900(debugRecord => mergedOutput.Add(
                                            delegate (PSCmdlet c)
                                            {
                                                c.WriteDebug(debugRecord.Message);
                                                return Enumerable.Empty<PSObject>();
                                            }), swallowInvalidOperationExceptions: true)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 10921, 11374);

                    EventHandler<DataAddedEventArgs>
                    informationHandler = f_1538_10975_11373(informationRecord => mergedOutput.Add(
                                            delegate (PSCmdlet c)
                                            {
                                                c.WriteInformation(informationRecord);
                                                return Enumerable.Empty<PSObject>();
                                            }), swallowInvalidOperationExceptions: true)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 11394, 11433);

                    asyncOutput.DataAdded += outputHandler;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 11451, 11502);

                    f_1538_11451_11475(f_1538_11451_11469(powerShell)).DataAdded += errorHandler;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 11520, 11575);

                    f_1538_11520_11546(f_1538_11520_11538(powerShell)).DataAdded += warningHandler;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 11593, 11648);

                    f_1538_11593_11619(f_1538_11593_11611(powerShell)).DataAdded += verboseHandler;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 11666, 11717);

                    f_1538_11666_11690(f_1538_11666_11684(powerShell)).DataAdded += debugHandler;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 11735, 11798);

                    f_1538_11735_11765(f_1538_11735_11753(powerShell)).DataAdded += informationHandler;

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 11936, 12762);

                        var
                        asyncResult = f_1538_11954_12761(powerShell, input: null, output: asyncOutput, settings: invocationSettings, callback: delegate
                                                          {
                                                              try
                                                              {
                                                                  mergedOutput.CompleteAdding();
                                                              }
                                                              catch (InvalidOperationException)
                                      // ignore exceptions thrown because mergedOutput.CompleteAdding was called
                                      {
                                                              }
                                                          }, state: null)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 12786, 13601);
                        using (cancellationToken.Register(powerShell.Stop))
                        {
                            try
                            {
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 12946, 13340);
                                    foreach (Func<PSCmdlet, IEnumerable<PSObject>> mergedOutputItem in f_1538_13013_13050_I(f_1538_13013_13050(mergedOutput)))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 12946, 13340);
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 13116, 13309);
                                            foreach (PSObject outputObject in f_1538_13150_13174_I(f_1538_13150_13174(mergedOutputItem, cmdlet)))
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 13116, 13309);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 13248, 13274);

                                                listYield.Add(outputObject);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 13116, 13309);
                                            }
                                        }
                                        catch (System.Exception)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1538, 1, 194);
                                            throw;
                                        }
                                        finally
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoop(1538, 1, 194);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 12946, 13340);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1538, 1, 395);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1538, 1, 395);
                                }
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinally(1538, 13393, 13578);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 13457, 13487);

                                f_1538_13457_13486(mergedOutput);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 13517, 13551);

                                f_1538_13517_13550(powerShell, asyncResult);
                                DynAbs.Tracing.TraceSender.TraceExitFinally(1538, 13393, 13578);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitUsing(1538, 12786, 13601);
                        }
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1538, 13638, 14129);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 13686, 13725);

                        asyncOutput.DataAdded -= outputHandler;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 13747, 13798);

                        f_1538_13747_13771(f_1538_13747_13765(powerShell)).DataAdded -= errorHandler;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 13820, 13875);

                        f_1538_13820_13846(f_1538_13820_13838(powerShell)).DataAdded -= warningHandler;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 13897, 13952);

                        f_1538_13897_13923(f_1538_13897_13915(powerShell)).DataAdded -= verboseHandler;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 13974, 14025);

                        f_1538_13974_13998(f_1538_13974_13992(powerShell)).DataAdded -= debugHandler;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 14047, 14110);

                        f_1538_14047_14077(f_1538_14047_14065(powerShell)).DataAdded -= informationHandler;
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1538, 13638, 14129);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1538, 8505, 14144);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1538, 8206, 14155);

                return listYield;

                System.Collections.Concurrent.BlockingCollection<System.Func<System.Management.Automation.PSCmdlet, System.Collections.Generic.IEnumerable<System.Management.Automation.PSObject>>>
                f_1538_8531_8622(int
                boundedCapacity)
                {
                    var return_v = new System.Collections.Concurrent.BlockingCollection<System.Func<System.Management.Automation.PSCmdlet, System.Collections.Generic.IEnumerable<System.Management.Automation.PSObject>>>(boundedCapacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 8531, 8622);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                f_1538_8674_8706()
                {
                    var return_v = new System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 8674, 8706);
                    return return_v;
                }


                System.EventHandler<System.Management.Automation.DataAddedEventArgs>
                f_1538_8774_8937(System.Action<System.Management.Automation.PSObject>
                forwardingAction, bool
                swallowInvalidOperationExceptions)
                {
                    var return_v = GetStreamForwarder<PSObject>(forwardingAction, swallowInvalidOperationExceptions: swallowInvalidOperationExceptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 8774, 8937);
                    return return_v;
                }


                System.EventHandler<System.Management.Automation.DataAddedEventArgs>
                f_1538_9006_9527(System.Action<System.Management.Automation.ErrorRecord>
                forwardingAction, bool
                swallowInvalidOperationExceptions)
                {
                    var return_v = GetStreamForwarder<ErrorRecord>(forwardingAction, swallowInvalidOperationExceptions: swallowInvalidOperationExceptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 9006, 9527);
                    return return_v;
                }


                System.EventHandler<System.Management.Automation.DataAddedEventArgs>
                f_1538_9598_9988(System.Action<System.Management.Automation.WarningRecord>
                forwardingAction, bool
                swallowInvalidOperationExceptions)
                {
                    var return_v = GetStreamForwarder<WarningRecord>(forwardingAction, swallowInvalidOperationExceptions: swallowInvalidOperationExceptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 9598, 9988);
                    return return_v;
                }


                System.EventHandler<System.Management.Automation.DataAddedEventArgs>
                f_1538_10059_10449(System.Action<System.Management.Automation.VerboseRecord>
                forwardingAction, bool
                swallowInvalidOperationExceptions)
                {
                    var return_v = GetStreamForwarder<VerboseRecord>(forwardingAction, swallowInvalidOperationExceptions: swallowInvalidOperationExceptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 10059, 10449);
                    return return_v;
                }


                System.EventHandler<System.Management.Automation.DataAddedEventArgs>
                f_1538_10518_10900(System.Action<System.Management.Automation.DebugRecord>
                forwardingAction, bool
                swallowInvalidOperationExceptions)
                {
                    var return_v = GetStreamForwarder<DebugRecord>(forwardingAction, swallowInvalidOperationExceptions: swallowInvalidOperationExceptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 10518, 10900);
                    return return_v;
                }


                System.EventHandler<System.Management.Automation.DataAddedEventArgs>
                f_1538_10975_11373(System.Action<System.Management.Automation.InformationRecord>
                forwardingAction, bool
                swallowInvalidOperationExceptions)
                {
                    var return_v = GetStreamForwarder<InformationRecord>(forwardingAction, swallowInvalidOperationExceptions: swallowInvalidOperationExceptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 10975, 11373);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1538_11451_11469(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 11451, 11469);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                f_1538_11451_11475(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Error;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 11451, 11475);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1538_11520_11538(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 11520, 11538);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.WarningRecord>
                f_1538_11520_11546(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Warning;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 11520, 11546);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1538_11593_11611(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 11593, 11611);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.VerboseRecord>
                f_1538_11593_11619(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Verbose;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 11593, 11619);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1538_11666_11684(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 11666, 11684);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.DebugRecord>
                f_1538_11666_11690(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Debug;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 11666, 11690);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1538_11735_11753(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 11735, 11753);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.InformationRecord>
                f_1538_11735_11765(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Information;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 11735, 11765);
                    return return_v;
                }


                System.IAsyncResult
                f_1538_11954_12761(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                input, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                output, System.Management.Automation.PSInvocationSettings
                settings, System.AsyncCallback
                callback, object
                state)
                {
                    var return_v = this_param.BeginInvoke<System.Management.Automation.PSObject, System.Management.Automation.PSObject>(input: input, output: output, settings: settings, callback: callback, state: state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 11954, 12761);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Func<System.Management.Automation.PSCmdlet, System.Collections.Generic.IEnumerable<System.Management.Automation.PSObject>>>
                f_1538_13013_13050(System.Collections.Concurrent.BlockingCollection<System.Func<System.Management.Automation.PSCmdlet, System.Collections.Generic.IEnumerable<System.Management.Automation.PSObject>>>
                this_param)
                {
                    var return_v = this_param.GetConsumingEnumerable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 13013, 13050);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSObject>
                f_1538_13150_13174(System.Func<System.Management.Automation.PSCmdlet, System.Collections.Generic.IEnumerable<System.Management.Automation.PSObject>>
                this_param, System.Management.Automation.PSCmdlet
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 13150, 13174);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSObject>
                f_1538_13150_13174_I(System.Collections.Generic.IEnumerable<System.Management.Automation.PSObject>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 13150, 13174);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Func<System.Management.Automation.PSCmdlet, System.Collections.Generic.IEnumerable<System.Management.Automation.PSObject>>>
                f_1538_13013_13050_I(System.Collections.Generic.IEnumerable<System.Func<System.Management.Automation.PSCmdlet, System.Collections.Generic.IEnumerable<System.Management.Automation.PSObject>>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 13013, 13050);
                    return return_v;
                }


                int
                f_1538_13457_13486(System.Collections.Concurrent.BlockingCollection<System.Func<System.Management.Automation.PSCmdlet, System.Collections.Generic.IEnumerable<System.Management.Automation.PSObject>>>
                this_param)
                {
                    this_param.CompleteAdding();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 13457, 13486);
                    return 0;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                f_1538_13517_13550(System.Management.Automation.PowerShell
                this_param, System.IAsyncResult
                asyncResult)
                {
                    var return_v = this_param.EndInvoke(asyncResult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 13517, 13550);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1538_13747_13765(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 13747, 13765);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                f_1538_13747_13771(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Error;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 13747, 13771);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1538_13820_13838(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 13820, 13838);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.WarningRecord>
                f_1538_13820_13846(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Warning;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 13820, 13846);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1538_13897_13915(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 13897, 13915);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.VerboseRecord>
                f_1538_13897_13923(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Verbose;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 13897, 13923);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1538_13974_13992(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 13974, 13992);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.DebugRecord>
                f_1538_13974_13998(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Debug;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 13974, 13998);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1538_14047_14065(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 14047, 14065);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.InformationRecord>
                f_1538_14047_14077(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Information;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 14047, 14077);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1538, 8206, 14155);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1538, 8206, 14155);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<PSObject> InvokeNestedPowerShell(
                    PowerShell powerShell,
                    CancellationToken cancellationToken,
                    PSCmdlet cmdlet,
                    PSInvocationSettings invocationSettings,
                    string errorMessageTemplate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1538, 14167, 15462);

                var listYield = new List<PSObject>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 14464, 14828);

                EventHandler<DataAddedEventArgs>
                errorHandler = f_1538_14512_14827(delegate (ErrorRecord errorRecord)
                                {
                                    errorRecord = GetErrorRecordForRemotePipelineInvocation(errorRecord, errorMessageTemplate);
                                    HandleErrorFromPipeline(cmdlet, errorRecord, powerShell);
                                })
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 14842, 14893);

                f_1538_14842_14866(f_1538_14842_14860(powerShell)).DataAdded += errorHandler;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 14945, 15316);
                    using (cancellationToken.Register(powerShell.Stop))
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 15111, 15297);
                            foreach (PSObject outputObject in f_1538_15145_15198_I(f_1538_15145_15198(powerShell, null, invocationSettings)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 15111, 15297);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 15248, 15274);

                                listYield.Add(outputObject);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 15111, 15297);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1538, 1, 187);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1538, 1, 187);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitUsing(1538, 14945, 15316);
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1538, 15345, 15451);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 15385, 15436);

                    f_1538_15385_15409(f_1538_15385_15403(powerShell)).DataAdded -= errorHandler;
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1538, 15345, 15451);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1538, 14167, 15462);

                return listYield;

                System.EventHandler<System.Management.Automation.DataAddedEventArgs>
                f_1538_14512_14827(System.Action<System.Management.Automation.ErrorRecord>
                forwardingAction)
                {
                    var return_v = GetStreamForwarder<ErrorRecord>(forwardingAction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 14512, 14827);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1538_14842_14860(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 14842, 14860);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                f_1538_14842_14866(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Error;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 14842, 14866);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1538_15145_15198(System.Management.Automation.PowerShell
                this_param, System.Collections.IEnumerable
                input, System.Management.Automation.PSInvocationSettings
                settings)
                {
                    var return_v = this_param.Invoke<System.Management.Automation.PSObject>(input, settings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 15145, 15198);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1538_15145_15198_I(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 15145, 15198);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1538_15385_15403(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 15385, 15403);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                f_1538_15385_15409(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Error;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 15385, 15409);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1538, 14167, 15462);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1538, 14167, 15462);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void CopyParameterFromCmdletToPowerShell(Cmdlet cmdlet, PowerShell powerShell, string parameterName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1538, 15474, 16270);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 15614, 15636);

                object
                parameterValue
                = default(object);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 15650, 15793) || true) && (!f_1538_15655_15737(f_1538_15655_15690(f_1538_15655_15674(cmdlet)), parameterName, out parameterValue))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 15650, 15793);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 15771, 15778);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 15650, 15793);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 15809, 15884);

                var
                commandParameter = f_1538_15832_15883(parameterName, parameterValue)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 15898, 16259);
                    foreach (var command in f_1538_15922_15950_I(f_1538_15922_15950(f_1538_15922_15941(powerShell))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 15898, 16259);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 15984, 16183) || true) && (f_1538_15988_16113(f_1538_15988_16006(command), existingParameter => existingParameter.Name.Equals(parameterName, StringComparison.OrdinalIgnoreCase)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 15984, 16183);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 16155, 16164);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 15984, 16183);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 16203, 16244);

                        f_1538_16203_16243(f_1538_16203_16221(command), commandParameter);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 15898, 16259);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1538, 1, 362);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1538, 1, 362);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1538, 15474, 16270);

                System.Management.Automation.InvocationInfo
                f_1538_15655_15674(System.Management.Automation.Cmdlet
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 15655, 15674);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, object>
                f_1538_15655_15690(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.BoundParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 15655, 15690);
                    return return_v;
                }


                bool
                f_1538_15655_15737(System.Collections.Generic.Dictionary<string, object>
                this_param, string
                key, out object
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 15655, 15737);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandParameter
                f_1538_15832_15883(string
                name, object
                value)
                {
                    var return_v = new System.Management.Automation.Runspaces.CommandParameter(name, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 15832, 15883);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1538_15922_15941(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 15922, 15941);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandCollection
                f_1538_15922_15950(System.Management.Automation.PSCommand
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 15922, 15950);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandParameterCollection
                f_1538_15988_16006(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 15988, 16006);
                    return return_v;
                }


                bool
                f_1538_15988_16113(System.Management.Automation.Runspaces.CommandParameterCollection
                source, System.Func<System.Management.Automation.Runspaces.CommandParameter, bool>
                predicate)
                {
                    var return_v = source.Any<System.Management.Automation.Runspaces.CommandParameter>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 15988, 16113);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandParameterCollection
                f_1538_16203_16221(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 16203, 16221);
                    return return_v;
                }


                int
                f_1538_16203_16243(System.Management.Automation.Runspaces.CommandParameterCollection
                this_param, System.Management.Automation.Runspaces.CommandParameter
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 16203, 16243);
                    return 0;
                }


                System.Management.Automation.Runspaces.CommandCollection
                f_1538_15922_15950_I(System.Management.Automation.Runspaces.CommandCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 15922, 15950);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1538, 15474, 16270);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1538, 15474, 16270);
            }
        }

        internal static ErrorRecord GetErrorRecordForProcessingOfCimModule(Exception innerException, string moduleName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1538, 16282, 16931);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 16418, 16641);

                string
                errorMessage = f_1538_16440_16640(f_1538_16472_16500(), f_1538_16519_16569(), moduleName, f_1538_16617_16639(innerException))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 16657, 16744);

                Exception
                outerException = f_1538_16684_16743(errorMessage, innerException)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 16758, 16887);

                ErrorRecord
                errorRecord = f_1538_16784_16886(outerException, f_1538_16816_16845(f_1538_16816_16840(innerException)), ErrorCategory.NotSpecified, moduleName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 16901, 16920);

                return errorRecord;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1538, 16282, 16931);

                System.Globalization.CultureInfo
                f_1538_16472_16500()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 16472, 16500);
                    return return_v;
                }


                string
                f_1538_16519_16569()
                {
                    var return_v = Modules.RemoteDiscoveryFailedToProcessRemoteModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 16519, 16569);
                    return return_v;
                }


                string
                f_1538_16617_16639(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 16617, 16639);
                    return return_v;
                }


                string
                f_1538_16440_16640(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 16440, 16640);
                    return return_v;
                }


                System.InvalidOperationException
                f_1538_16684_16743(string
                message, System.Exception
                innerException)
                {
                    var return_v = new System.InvalidOperationException(message, innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 16684, 16743);
                    return return_v;
                }


                System.Type
                f_1538_16816_16840(System.Exception
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 16816, 16840);
                    return return_v;
                }


                string
                f_1538_16816_16845(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 16816, 16845);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1538_16784_16886(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, string
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 16784, 16886);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1538, 16282, 16931);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1538, 16282, 16931);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private const string
        DiscoveryProviderNotFoundErrorId = "DiscoveryProviderNotFound"
        ;

        private static ErrorRecord GetErrorRecordForRemoteDiscoveryProvider(Exception innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1538, 17039, 18701);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 17157, 17216);

                CimException
                cimException = innerException as CimException
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 17230, 18690) || true) && ((cimException != null) && (DynAbs.Tracing.TraceSender.Expression_True(1538, 17234, 17605) && ((f_1538_17279_17307(cimException) == NativeErrorCode.InvalidNamespace) || (DynAbs.Tracing.TraceSender.Expression_False(1538, 17278, 17428) || (f_1538_17367_17395(cimException) == NativeErrorCode.InvalidClass)) || (DynAbs.Tracing.TraceSender.Expression_False(1538, 17278, 17514) || (f_1538_17451_17479(cimException) == NativeErrorCode.MethodNotFound)) || (DynAbs.Tracing.TraceSender.Expression_False(1538, 17278, 17604) || (f_1538_17537_17565(cimException) == NativeErrorCode.MethodNotAvailable)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 17230, 18690);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 17639, 17834);

                    string
                    errorMessage = f_1538_17661_17833(f_1538_17697_17725(), f_1538_17748_17787(), f_1538_17810_17832(innerException))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 17852, 17939);

                    Exception
                    outerException = f_1538_17879_17938(errorMessage, innerException)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 17957, 18085);

                    ErrorRecord
                    errorRecord = f_1538_17983_18084(outerException, DiscoveryProviderNotFoundErrorId, ErrorCategory.NotImplemented, null)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 18103, 18122);

                    return errorRecord;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 17230, 18690);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 17230, 18690);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 18188, 18395);

                    string
                    errorMessage = f_1538_18210_18394(f_1538_18246_18274(), f_1538_18297_18348(), f_1538_18371_18393(innerException))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 18413, 18500);

                    Exception
                    outerException = f_1538_18440_18499(errorMessage, innerException)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 18518, 18638);

                    ErrorRecord
                    errorRecord = f_1538_18544_18637(outerException, "DiscoveryProviderFailure", ErrorCategory.NotSpecified, null)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 18656, 18675);

                    return errorRecord;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 17230, 18690);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1538, 17039, 18701);

                Microsoft.Management.Infrastructure.NativeErrorCode
                f_1538_17279_17307(Microsoft.Management.Infrastructure.CimException
                this_param)
                {
                    var return_v = this_param.NativeErrorCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 17279, 17307);
                    return return_v;
                }


                Microsoft.Management.Infrastructure.NativeErrorCode
                f_1538_17367_17395(Microsoft.Management.Infrastructure.CimException
                this_param)
                {
                    var return_v = this_param.NativeErrorCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 17367, 17395);
                    return return_v;
                }


                Microsoft.Management.Infrastructure.NativeErrorCode
                f_1538_17451_17479(Microsoft.Management.Infrastructure.CimException
                this_param)
                {
                    var return_v = this_param.NativeErrorCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 17451, 17479);
                    return return_v;
                }


                Microsoft.Management.Infrastructure.NativeErrorCode
                f_1538_17537_17565(Microsoft.Management.Infrastructure.CimException
                this_param)
                {
                    var return_v = this_param.NativeErrorCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 17537, 17565);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1538_17697_17725()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 17697, 17725);
                    return return_v;
                }


                string
                f_1538_17748_17787()
                {
                    var return_v = Modules.RemoteDiscoveryProviderNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 17748, 17787);
                    return return_v;
                }


                string
                f_1538_17810_17832(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 17810, 17832);
                    return return_v;
                }


                string
                f_1538_17661_17833(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 17661, 17833);
                    return return_v;
                }


                System.InvalidOperationException
                f_1538_17879_17938(string
                message, System.Exception
                innerException)
                {
                    var return_v = new System.InvalidOperationException(message, innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 17879, 17938);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1538_17983_18084(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 17983, 18084);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1538_18246_18274()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 18246, 18274);
                    return return_v;
                }


                string
                f_1538_18297_18348()
                {
                    var return_v = Modules.RemoteDiscoveryFailureFromDiscoveryProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 18297, 18348);
                    return return_v;
                }


                string
                f_1538_18371_18393(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 18371, 18393);
                    return return_v;
                }


                string
                f_1538_18210_18394(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 18210, 18394);
                    return return_v;
                }


                System.InvalidOperationException
                f_1538_18440_18499(string
                message, System.Exception
                innerException)
                {
                    var return_v = new System.InvalidOperationException(message, innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 18440, 18499);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1538_18544_18637(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 18544, 18637);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1538, 17039, 18701);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1538, 17039, 18701);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ErrorRecord GetErrorRecordForRemotePipelineInvocation(Exception innerException, string errorMessageTemplate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1538, 18713, 19737);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 18861, 19025);

                string
                errorMessage = f_1538_18883_19024(f_1538_18915_18943(), errorMessageTemplate, f_1538_19001_19023(innerException))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 19039, 19126);

                Exception
                outerException = f_1538_19066_19125(errorMessage, innerException)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 19142, 19210);

                RemoteException
                remoteException = innerException as RemoteException
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 19224, 19317);

                ErrorRecord
                remoteErrorRecord = (DynAbs.Tracing.TraceSender.Conditional_F1(1538, 19256, 19279) || ((remoteException != null && DynAbs.Tracing.TraceSender.Conditional_F2(1538, 19282, 19309)) || DynAbs.Tracing.TraceSender.Conditional_F3(1538, 19312, 19316))) ? f_1538_19282_19309(remoteException) : null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 19331, 19448);

                string
                errorId = (DynAbs.Tracing.TraceSender.Conditional_F1(1538, 19348, 19373) || ((remoteErrorRecord != null && DynAbs.Tracing.TraceSender.Conditional_F2(1538, 19376, 19415)) || DynAbs.Tracing.TraceSender.Conditional_F3(1538, 19418, 19447))) ? f_1538_19376_19415(remoteErrorRecord) : f_1538_19418_19447(f_1538_19418_19442(innerException))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 19462, 19589);

                ErrorCategory
                errorCategory = (DynAbs.Tracing.TraceSender.Conditional_F1(1538, 19492, 19517) || ((remoteErrorRecord != null && DynAbs.Tracing.TraceSender.Conditional_F2(1538, 19520, 19559)) || DynAbs.Tracing.TraceSender.Conditional_F3(1538, 19562, 19588))) ? f_1538_19520_19559(f_1538_19520_19550(remoteErrorRecord)) : ErrorCategory.NotSpecified
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 19603, 19691);

                ErrorRecord
                errorRecord = f_1538_19629_19690(outerException, errorId, errorCategory, null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 19707, 19726);

                return errorRecord;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1538, 18713, 19737);

                System.Globalization.CultureInfo
                f_1538_18915_18943()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 18915, 18943);
                    return return_v;
                }


                string
                f_1538_19001_19023(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 19001, 19023);
                    return return_v;
                }


                string
                f_1538_18883_19024(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 18883, 19024);
                    return return_v;
                }


                System.InvalidOperationException
                f_1538_19066_19125(string
                message, System.Exception
                innerException)
                {
                    var return_v = new System.InvalidOperationException(message, innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 19066, 19125);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1538_19282_19309(System.Management.Automation.RemoteException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 19282, 19309);
                    return return_v;
                }


                string
                f_1538_19376_19415(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.FullyQualifiedErrorId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 19376, 19415);
                    return return_v;
                }


                System.Type
                f_1538_19418_19442(System.Exception
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 19418, 19442);
                    return return_v;
                }


                string
                f_1538_19418_19447(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 19418, 19447);
                    return return_v;
                }


                System.Management.Automation.ErrorCategoryInfo
                f_1538_19520_19550(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.CategoryInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 19520, 19550);
                    return return_v;
                }


                System.Management.Automation.ErrorCategory
                f_1538_19520_19559(System.Management.Automation.ErrorCategoryInfo
                this_param)
                {
                    var return_v = this_param.Category;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 19520, 19559);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1538_19629_19690(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 19629, 19690);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1538, 18713, 19737);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1538, 18713, 19737);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ErrorRecord GetErrorRecordForRemotePipelineInvocation(ErrorRecord innerErrorRecord, string errorMessageTemplate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1538, 19749, 20960);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 19901, 19926);

                string
                innerErrorMessage
                = default(string);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 19940, 20458) || true) && (f_1538_19944_19973(innerErrorRecord) != null && (DynAbs.Tracing.TraceSender.Expression_True(1538, 19944, 20030) && f_1538_19985_20022(f_1538_19985_20014(innerErrorRecord)) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 19940, 20458);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 20064, 20122);

                    innerErrorMessage = f_1538_20084_20121(f_1538_20084_20113(innerErrorRecord));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 19940, 20458);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 19940, 20458);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 20156, 20458) || true) && (f_1538_20160_20186(innerErrorRecord) != null && (DynAbs.Tracing.TraceSender.Expression_True(1538, 20160, 20240) && f_1538_20198_20232(f_1538_20198_20224(innerErrorRecord)) != null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 20156, 20458);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 20274, 20329);

                        innerErrorMessage = f_1538_20294_20328(f_1538_20294_20320(innerErrorRecord));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 20156, 20458);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 20156, 20458);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 20395, 20443);

                        innerErrorMessage = f_1538_20415_20442(innerErrorRecord);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 20156, 20458);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 19940, 20458);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 20474, 20633);

                string
                errorMessage = f_1538_20496_20632(f_1538_20528_20556(), errorMessageTemplate, innerErrorMessage)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 20649, 20767);

                ErrorRecord
                outerErrorRecord = f_1538_20680_20766(innerErrorRecord, null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 20781, 20845);

                ErrorDetails
                outerErrorDetails = f_1538_20814_20844(errorMessage)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 20859, 20909);

                outerErrorRecord.ErrorDetails = outerErrorDetails;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 20925, 20949);

                return outerErrorRecord;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1538, 19749, 20960);

                System.Management.Automation.ErrorDetails
                f_1538_19944_19973(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.ErrorDetails;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 19944, 19973);
                    return return_v;
                }


                System.Management.Automation.ErrorDetails
                f_1538_19985_20014(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.ErrorDetails;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 19985, 20014);
                    return return_v;
                }


                string
                f_1538_19985_20022(System.Management.Automation.ErrorDetails
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 19985, 20022);
                    return return_v;
                }


                System.Management.Automation.ErrorDetails
                f_1538_20084_20113(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.ErrorDetails;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 20084, 20113);
                    return return_v;
                }


                string
                f_1538_20084_20121(System.Management.Automation.ErrorDetails
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 20084, 20121);
                    return return_v;
                }


                System.Exception
                f_1538_20160_20186(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 20160, 20186);
                    return return_v;
                }


                System.Exception
                f_1538_20198_20224(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 20198, 20224);
                    return return_v;
                }


                string
                f_1538_20198_20232(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 20198, 20232);
                    return return_v;
                }


                System.Exception
                f_1538_20294_20320(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 20294, 20320);
                    return return_v;
                }


                string
                f_1538_20294_20328(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 20294, 20328);
                    return return_v;
                }


                string
                f_1538_20415_20442(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 20415, 20442);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1538_20528_20556()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 20528, 20556);
                    return return_v;
                }


                string
                f_1538_20496_20632(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 20496, 20632);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1538_20680_20766(System.Management.Automation.ErrorRecord
                errorRecord, System.Exception
                replaceParentContainsErrorRecordException)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(errorRecord, replaceParentContainsErrorRecordException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 20680, 20766);
                    return return_v;
                }


                System.Management.Automation.ErrorDetails
                f_1538_20814_20844(string
                message)
                {
                    var return_v = new System.Management.Automation.ErrorDetails(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 20814, 20844);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1538, 19749, 20960);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1538, 19749, 20960);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<T> EnumerateWithCatch<T>(IEnumerable<T> enumerable, Action<Exception> exceptionHandler)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1538, 20972, 22865);

                var listYield = new List<T>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 21111, 21144);

                IEnumerator<T>
                enumerator = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 21194, 21234);

                    enumerator = f_1538_21207_21233(enumerable);
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1538, 21263, 21350);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 21315, 21335);

                    f_1538_21315_21334(exceptionHandler, e);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1538, 21263, 21350);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 21366, 22854) || true) && (enumerator != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 21366, 22854);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 21407, 22854);
                    using (enumerator)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 21466, 21490);

                        bool
                        gotResults = false
                        ;
                        {
                            try
                            {
                                do

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 21512, 22835);
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 21623, 21642);

                                        gotResults = false;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 21672, 21707);

                                        gotResults = f_1538_21685_21706(enumerator);
                                    }
                                    catch (Exception e)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1538, 21760, 21883);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 21836, 21856);

                                        f_1538_21836_21855(exceptionHandler, e);
                                        DynAbs.Tracing.TraceSender.TraceExitCatch(1538, 21760, 21883);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 21911, 22792) || true) && (gotResults)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 21911, 22792);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 21983, 22010);

                                        T
                                        currentItem = default(T)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 22040, 22068);

                                        bool
                                        gotCurrentItem = false
                                        ;
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 22166, 22199);

                                            currentItem = f_1538_22180_22198(enumerator);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 22233, 22255);

                                            gotCurrentItem = true;
                                        }
                                        catch (Exception e)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1538, 22316, 22451);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 22400, 22420);

                                            f_1538_22400_22419(exceptionHandler, e);
                                            DynAbs.Tracing.TraceSender.TraceExitCatch(1538, 22316, 22451);
                                        }

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 22483, 22765) || true) && (gotCurrentItem)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 22483, 22765);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 22567, 22592);

                                            listYield.Add(currentItem);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 22483, 22765);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 22483, 22765);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 22722, 22734);

                                            return listYield;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 22483, 22765);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 21911, 22792);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 21512, 22835);
                                }
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 21512, 22835) || true) && (gotResults)
                                );
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1538, 21512, 22835);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1538, 21512, 22835);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceExitUsing(1538, 21407, 22854);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 21366, 22854);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1538, 20972, 22865);

                return listYield;

                System.Collections.Generic.IEnumerator<T>
                f_1538_21207_21233(System.Collections.Generic.IEnumerable<T>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 21207, 21233);
                    return return_v;
                }


                int
                f_1538_21315_21334(System.Action<System.Exception>
                this_param, System.Exception
                obj)
                {
                    this_param.Invoke(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 21315, 21334);
                    return 0;
                }


                bool
                f_1538_21685_21706(System.Collections.Generic.IEnumerator<T>
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 21685, 21706);
                    return return_v;
                }


                int
                f_1538_21836_21855(System.Action<System.Exception>
                this_param, System.Exception
                obj)
                {
                    this_param.Invoke(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 21836, 21855);
                    return 0;
                }


                T
                f_1538_22180_22198(System.Collections.Generic.IEnumerator<T>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 22180, 22198);
                    return return_v;
                }


                int
                f_1538_22400_22419(System.Action<System.Exception>
                this_param, System.Exception
                obj)
                {
                    this_param.Invoke(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 22400, 22419);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1538, 20972, 22865);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1538, 20972, 22865);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void HandleErrorFromPipeline(Cmdlet cmdlet, ErrorRecord errorRecord, PowerShell powerShell)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1538, 22877, 23510);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 23008, 23452) || true) && (f_1538_23012_23047_M(!f_1538_23013_23032(cmdlet).ExpectingInput))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 23008, 23452);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 23081, 23437) || true) && (((f_1538_23087_23106(powerShell) != null) && (DynAbs.Tracing.TraceSender.Expression_True(1538, 23086, 23188) && (f_1538_23120_23163(f_1538_23120_23157(f_1538_23120_23139(powerShell))) != RunspaceState.Opened))) || (DynAbs.Tracing.TraceSender.Expression_False(1538, 23085, 23334) || ((f_1538_23216_23239(powerShell) != null) && (DynAbs.Tracing.TraceSender.Expression_True(1538, 23215, 23333) && (f_1538_23253_23304(f_1538_23253_23298(f_1538_23253_23276(powerShell))) != RunspacePoolState.Opened)))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 23081, 23437);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 23376, 23418);

                        f_1538_23376_23417(cmdlet, errorRecord);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 23081, 23437);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 23008, 23452);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 23468, 23499);

                f_1538_23468_23498(
                            cmdlet, errorRecord);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1538, 22877, 23510);

                System.Management.Automation.InvocationInfo
                f_1538_23013_23032(System.Management.Automation.Cmdlet
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 23013, 23032);
                    return return_v;
                }


                bool
                f_1538_23012_23047_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 23012, 23047);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1538_23087_23106(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 23087, 23106);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1538_23120_23139(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 23120, 23139);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceStateInfo
                f_1538_23120_23157(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.RunspaceStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 23120, 23157);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceState
                f_1538_23120_23163(System.Management.Automation.Runspaces.RunspaceStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 23120, 23163);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspacePool
                f_1538_23216_23239(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.RunspacePool;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 23216, 23239);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspacePool
                f_1538_23253_23276(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.RunspacePool;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 23253, 23276);
                    return return_v;
                }


                System.Management.Automation.RunspacePoolStateInfo
                f_1538_23253_23298(System.Management.Automation.Runspaces.RunspacePool
                this_param)
                {
                    var return_v = this_param.RunspacePoolStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 23253, 23298);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspacePoolState
                f_1538_23253_23304(System.Management.Automation.RunspacePoolStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 23253, 23304);
                    return return_v;
                }


                int
                f_1538_23376_23417(System.Management.Automation.Cmdlet
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 23376, 23417);
                    return 0;
                }


                int
                f_1538_23468_23498(System.Management.Automation.Cmdlet
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 23468, 23498);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1538, 22877, 23510);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1538, 22877, 23510);
            }
        }

        internal static IEnumerable<PSObject> InvokePowerShell(
                    PowerShell powerShell,
                    CancellationToken cancellationToken,
                    PSCmdlet cmdlet,
                    string errorMessageTemplate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1538, 23522, 25014);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 23760, 23831);

                f_1538_23760_23830(cmdlet, powerShell, "ErrorAction");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 23845, 23918);

                f_1538_23845_23917(cmdlet, powerShell, "WarningAction");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 23932, 24009);

                f_1538_23932_24008(cmdlet, powerShell, "InformationAction");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 24023, 24090);

                f_1538_24023_24089(cmdlet, powerShell, "Verbose");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 24104, 24169);

                f_1538_24104_24168(cmdlet, powerShell, "Debug");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 24185, 24258);

                var
                invocationSettings = new PSInvocationSettings { Host = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1538_24244_24255(cmdlet), 1538, 24210, 24257) }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 24335, 24640);

                IEnumerable<PSObject>
                outputStream = (DynAbs.Tracing.TraceSender.Conditional_F1(1538, 24372, 24391) || ((f_1538_24372_24391(powerShell) && DynAbs.Tracing.TraceSender.Conditional_F2(1538, 24411, 24514)) || DynAbs.Tracing.TraceSender.Conditional_F3(1538, 24534, 24639))) ? f_1538_24411_24514(powerShell, cancellationToken, cmdlet, invocationSettings, errorMessageTemplate) : f_1538_24534_24639(powerShell, cancellationToken, cmdlet, invocationSettings, errorMessageTemplate)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 24656, 25003);

                return f_1538_24663_25002(outputStream, delegate (Exception exception)
                                {
                                    ErrorRecord errorRecord = GetErrorRecordForRemotePipelineInvocation(exception, errorMessageTemplate);
                                    HandleErrorFromPipeline(cmdlet, errorRecord, powerShell);
                                });
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1538, 23522, 25014);

                int
                f_1538_23760_23830(System.Management.Automation.PSCmdlet
                cmdlet, System.Management.Automation.PowerShell
                powerShell, string
                parameterName)
                {
                    CopyParameterFromCmdletToPowerShell((System.Management.Automation.Cmdlet)cmdlet, powerShell, parameterName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 23760, 23830);
                    return 0;
                }


                int
                f_1538_23845_23917(System.Management.Automation.PSCmdlet
                cmdlet, System.Management.Automation.PowerShell
                powerShell, string
                parameterName)
                {
                    CopyParameterFromCmdletToPowerShell((System.Management.Automation.Cmdlet)cmdlet, powerShell, parameterName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 23845, 23917);
                    return 0;
                }


                int
                f_1538_23932_24008(System.Management.Automation.PSCmdlet
                cmdlet, System.Management.Automation.PowerShell
                powerShell, string
                parameterName)
                {
                    CopyParameterFromCmdletToPowerShell((System.Management.Automation.Cmdlet)cmdlet, powerShell, parameterName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 23932, 24008);
                    return 0;
                }


                int
                f_1538_24023_24089(System.Management.Automation.PSCmdlet
                cmdlet, System.Management.Automation.PowerShell
                powerShell, string
                parameterName)
                {
                    CopyParameterFromCmdletToPowerShell((System.Management.Automation.Cmdlet)cmdlet, powerShell, parameterName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 24023, 24089);
                    return 0;
                }


                int
                f_1538_24104_24168(System.Management.Automation.PSCmdlet
                cmdlet, System.Management.Automation.PowerShell
                powerShell, string
                parameterName)
                {
                    CopyParameterFromCmdletToPowerShell((System.Management.Automation.Cmdlet)cmdlet, powerShell, parameterName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 24104, 24168);
                    return 0;
                }


                System.Management.Automation.Host.PSHost
                f_1538_24244_24255(System.Management.Automation.PSCmdlet
                this_param)
                {
                    var return_v = this_param.Host;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 24244, 24255);
                    return return_v;
                }


                bool
                f_1538_24372_24391(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.IsNested
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 24372, 24391);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSObject>
                f_1538_24411_24514(System.Management.Automation.PowerShell
                powerShell, System.Threading.CancellationToken
                cancellationToken, System.Management.Automation.PSCmdlet
                cmdlet, System.Management.Automation.PSInvocationSettings
                invocationSettings, string
                errorMessageTemplate)
                {
                    var return_v = InvokeNestedPowerShell(powerShell, cancellationToken, cmdlet, invocationSettings, errorMessageTemplate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 24411, 24514);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSObject>
                f_1538_24534_24639(System.Management.Automation.PowerShell
                powerShell, System.Threading.CancellationToken
                cancellationToken, System.Management.Automation.PSCmdlet
                cmdlet, System.Management.Automation.PSInvocationSettings
                invocationSettings, string
                errorMessageTemplate)
                {
                    var return_v = InvokeTopLevelPowerShell(powerShell, cancellationToken, cmdlet, invocationSettings, errorMessageTemplate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 24534, 24639);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSObject>
                f_1538_24663_25002(System.Collections.Generic.IEnumerable<System.Management.Automation.PSObject>
                enumerable, System.Action<System.Exception>
                exceptionHandler)
                {
                    var return_v = EnumerateWithCatch(enumerable, exceptionHandler);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 24663, 25002);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1538, 23522, 25014);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1538, 23522, 25014);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private const string
        DiscoveryProviderNamespace = "root/Microsoft/Windows/Powershellv3"
        ;

        private const string
        DiscoveryProviderModuleClass = "PS_Module"
        ;

        private const string
        DiscoveryProviderFileClass = "PS_ModuleFile"
        ;

        private const string
        DiscoveryProviderAssociationClass = "PS_ModuleToModuleFile"
        ;

        private static T GetPropertyValue<T>(CimInstance cimInstance, string propertyName, T defaultValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1538, 25417, 27168);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 25540, 25614);

                CimProperty
                cimProperty = f_1538_25566_25613(f_1538_25566_25599(cimInstance), propertyName)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 25628, 25720) || true) && (cimProperty == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 25628, 25720);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 25685, 25705);

                    return defaultValue;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 25628, 25720);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 25736, 25777);

                object
                propertyValue = f_1538_25759_25776(cimProperty)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 25791, 25886) || true) && (propertyValue is T)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 25791, 25886);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 25847, 25871);

                    return (T)propertyValue;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 25791, 25886);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 25902, 27121) || true) && (propertyValue is string)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 25902, 27121);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 25963, 26006);

                    string
                    stringValue = (string)propertyValue
                    ;
                    try
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 26068, 26972) || true) && (typeof(T) == typeof(bool))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 26068, 26972);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 26147, 26199);

                            return (T)(object)f_1538_26165_26198(stringValue);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 26068, 26972);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 26068, 26972);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 26249, 26972) || true) && (typeof(T) == typeof(UInt16))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 26249, 26972);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 26330, 26404);

                                return (T)(object)f_1538_26348_26403(stringValue, f_1538_26374_26402());
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 26249, 26972);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 26249, 26972);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 26454, 26972) || true) && (typeof(T) == typeof(byte[]))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 26454, 26972);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 26535, 26595);

                                    byte[]
                                    contentBytes = f_1538_26557_26594(stringValue)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 26621, 26689);

                                    byte[]
                                    lengthBytes = f_1538_26642_26688(f_1538_26664_26683(contentBytes) + 4)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 26715, 26858) || true) && (BitConverter.IsLittleEndian)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 26715, 26858);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 26804, 26831);

                                        f_1538_26804_26830(lengthBytes);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 26715, 26858);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 26886, 26949);

                                    return (T)(object)(f_1538_26905_26947(f_1538_26905_26937(lengthBytes, contentBytes)));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 26454, 26972);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 26249, 26972);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 26068, 26972);
                        }
                    }
                    catch (Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1538, 27009, 27106);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 27067, 27087);

                        return defaultValue;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1538, 27009, 27106);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 25902, 27121);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 27137, 27157);

                return defaultValue;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1538, 25417, 27168);

                Microsoft.Management.Infrastructure.Generic.CimKeyedCollection<Microsoft.Management.Infrastructure.CimProperty>
                f_1538_25566_25599(Microsoft.Management.Infrastructure.CimInstance
                this_param)
                {
                    var return_v = this_param.CimInstanceProperties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 25566, 25599);
                    return return_v;
                }


                Microsoft.Management.Infrastructure.CimProperty
                f_1538_25566_25613(Microsoft.Management.Infrastructure.Generic.CimKeyedCollection<Microsoft.Management.Infrastructure.CimProperty>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 25566, 25613);
                    return return_v;
                }


                object
                f_1538_25759_25776(Microsoft.Management.Infrastructure.CimProperty
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 25759, 25776);
                    return return_v;
                }


                bool
                f_1538_26165_26198(string
                s)
                {
                    var return_v = XmlConvert.ToBoolean(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 26165, 26198);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1538_26374_26402()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 26374, 26402);
                    return return_v;
                }


                ushort
                f_1538_26348_26403(string
                s, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = UInt16.Parse(s, (System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 26348, 26403);
                    return return_v;
                }


                byte[]
                f_1538_26557_26594(string
                s)
                {
                    var return_v = Convert.FromBase64String(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 26557, 26594);
                    return return_v;
                }


                int
                f_1538_26664_26683(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 26664, 26683);
                    return return_v;
                }


                byte[]
                f_1538_26642_26688(int
                value)
                {
                    var return_v = BitConverter.GetBytes(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 26642, 26688);
                    return return_v;
                }


                int
                f_1538_26804_26830(byte[]
                array)
                {
                    Array.Reverse(array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 26804, 26830);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<byte>
                f_1538_26905_26937(byte[]
                first, byte[]
                second)
                {
                    var return_v = first.Concat<byte>((System.Collections.Generic.IEnumerable<byte>)second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 26905, 26937);
                    return return_v;
                }


                byte[]
                f_1538_26905_26947(System.Collections.Generic.IEnumerable<byte>
                source)
                {
                    var return_v = source.ToArray<byte>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 26905, 26947);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1538, 25417, 27168);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1538, 25417, 27168);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal enum CimFileCode
        {
            Unknown = 0,
            PsdV1,
            TypesV1,
            FormatV1,
            CmdletizationV1,
        }
        internal abstract class CimModuleFile
        {
            public CimFileCode FileCode
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1538, 27482, 28377);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 27526, 27695) || true) && (f_1538_27530_27597(f_1538_27530_27543(this), ".psd1", StringComparison.OrdinalIgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 27526, 27695);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 27647, 27672);

                            return CimFileCode.PsdV1;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 27526, 27695);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 27719, 27899) || true) && (f_1538_27723_27791(f_1538_27723_27736(this), ".cdxml", StringComparison.OrdinalIgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 27719, 27899);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 27841, 27876);

                            return CimFileCode.CmdletizationV1;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 27719, 27899);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 27923, 28102) || true) && (f_1538_27927_28002(f_1538_27927_27940(this), ".types.ps1xml", StringComparison.OrdinalIgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 27923, 28102);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 28052, 28079);

                            return CimFileCode.TypesV1;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 27923, 28102);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 28126, 28307) || true) && (f_1538_28130_28206(f_1538_28130_28143(this), ".format.ps1xml", StringComparison.OrdinalIgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 28126, 28307);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 28256, 28284);

                            return CimFileCode.FormatV1;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 28126, 28307);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 28331, 28358);

                        return CimFileCode.Unknown;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1538, 27482, 28377);

                        string
                        f_1538_27530_27543(System.Management.Automation.RemoteDiscoveryHelper.CimModuleFile
                        this_param)
                        {
                            var return_v = this_param.FileName;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 27530, 27543);
                            return return_v;
                        }


                        bool
                        f_1538_27530_27597(string
                        this_param, string
                        value, System.StringComparison
                        comparisonType)
                        {
                            var return_v = this_param.EndsWith(value, comparisonType);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 27530, 27597);
                            return return_v;
                        }


                        string
                        f_1538_27723_27736(System.Management.Automation.RemoteDiscoveryHelper.CimModuleFile
                        this_param)
                        {
                            var return_v = this_param.FileName;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 27723, 27736);
                            return return_v;
                        }


                        bool
                        f_1538_27723_27791(string
                        this_param, string
                        value, System.StringComparison
                        comparisonType)
                        {
                            var return_v = this_param.EndsWith(value, comparisonType);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 27723, 27791);
                            return return_v;
                        }


                        string
                        f_1538_27927_27940(System.Management.Automation.RemoteDiscoveryHelper.CimModuleFile
                        this_param)
                        {
                            var return_v = this_param.FileName;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 27927, 27940);
                            return return_v;
                        }


                        bool
                        f_1538_27927_28002(string
                        this_param, string
                        value, System.StringComparison
                        comparisonType)
                        {
                            var return_v = this_param.EndsWith(value, comparisonType);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 27927, 28002);
                            return return_v;
                        }


                        string
                        f_1538_28130_28143(System.Management.Automation.RemoteDiscoveryHelper.CimModuleFile
                        this_param)
                        {
                            var return_v = this_param.FileName;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 28130, 28143);
                            return return_v;
                        }


                        bool
                        f_1538_28130_28206(string
                        this_param, string
                        value, System.StringComparison
                        comparisonType)
                        {
                            var return_v = this_param.EndsWith(value, comparisonType);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 28130, 28206);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1538, 27422, 28392);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1538, 27422, 28392);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public abstract string FileName { get; }

            internal abstract byte[] RawFileDataCore { get; }

            public byte[] RawFileData
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1538, 28587, 28641);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 28593, 28639);

                        return f_1538_28600_28638(f_1538_28600_28628(f_1538_28600_28620(this), 4));
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1538, 28587, 28641);

                        byte[]
                        f_1538_28600_28620(System.Management.Automation.RemoteDiscoveryHelper.CimModuleFile
                        this_param)
                        {
                            var return_v = this_param.RawFileDataCore;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 28600, 28620);
                            return return_v;
                        }


                        System.Collections.Generic.IEnumerable<byte>
                        f_1538_28600_28628(byte[]
                        source, int
                        count)
                        {
                            var return_v = source.Skip<byte>(count);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 28600, 28628);
                            return return_v;
                        }


                        byte[]
                        f_1538_28600_28638(System.Collections.Generic.IEnumerable<byte>
                        source)
                        {
                            var return_v = source.ToArray<byte>();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 28600, 28638);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1538, 28529, 28656);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1538, 28529, 28656);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public string FileData
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1538, 28727, 29190);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 28771, 29130) || true) && (_fileData == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 28771, 29130);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 28842, 29107);
                            using (var
                            ms = f_1538_28858_28892(f_1538_28875_28891(this))
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 28919, 29107);
                                using (var
                                sr = f_1538_28935_28995(ms, detectEncodingFromByteOrderMarks: true)
                                )
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 29053, 29080);

                                    _fileData = f_1538_29065_29079(sr);
                                    DynAbs.Tracing.TraceSender.TraceExitUsing(1538, 28919, 29107);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitUsing(1538, 28842, 29107);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 28771, 29130);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 29154, 29171);

                        return _fileData;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1538, 28727, 29190);

                        byte[]
                        f_1538_28875_28891(System.Management.Automation.RemoteDiscoveryHelper.CimModuleFile
                        this_param)
                        {
                            var return_v = this_param.RawFileData;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 28875, 28891);
                            return return_v;
                        }


                        System.IO.MemoryStream
                        f_1538_28858_28892(byte[]
                        buffer)
                        {
                            var return_v = new System.IO.MemoryStream(buffer);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 28858, 28892);
                            return return_v;
                        }


                        System.IO.StreamReader
                        f_1538_28935_28995(System.IO.MemoryStream
                        stream, bool
                        detectEncodingFromByteOrderMarks)
                        {
                            var return_v = new System.IO.StreamReader((System.IO.Stream)stream, detectEncodingFromByteOrderMarks: detectEncodingFromByteOrderMarks);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 28935, 28995);
                            return return_v;
                        }


                        string
                        f_1538_29065_29079(System.IO.StreamReader
                        this_param)
                        {
                            var return_v = this_param.ReadToEnd();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 29065, 29079);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1538, 28672, 29205);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1538, 28672, 29205);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private string _fileData;

            public CimModuleFile()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1538, 27360, 29257);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 29236, 29245);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1538, 27360, 29257);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1538, 27360, 29257);
            }


            static CimModuleFile()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1538, 27360, 29257);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1538, 27360, 29257);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1538, 27360, 29257);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1538, 27360, 29257);
        }
        internal class CimModule
        {
            private readonly CimInstance _baseObject;

            internal CimModule(CimInstance baseObject)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1538, 29375, 29850);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 29347, 29358);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 32023, 32035);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 29450, 29527);

                    f_1538_29450_29526(baseObject != null, "Caller should make sure baseObject != null");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 29545, 29790);

                    f_1538_29545_29789(f_1538_29578_29691(f_1538_29578_29618(f_1538_29578_29608(baseObject)), DiscoveryProviderModuleClass, StringComparison.OrdinalIgnoreCase), "Caller should make sure baseObject is an instance of the right CIM class");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 29810, 29835);

                    _baseObject = baseObject;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1538, 29375, 29850);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1538, 29375, 29850);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1538, 29375, 29850);
                }
            }

            public string ModuleName
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1538, 29923, 30133);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 29967, 30053);

                        var
                        rawModuleName = f_1538_29987_30052(_baseObject, "ModuleName", string.Empty)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 30075, 30114);

                        return f_1538_30082_30113(rawModuleName);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1538, 29923, 30133);

                        string
                        f_1538_29987_30052(Microsoft.Management.Infrastructure.CimInstance
                        cimInstance, string
                        propertyName, string
                        defaultValue)
                        {
                            var return_v = GetPropertyValue<string>(cimInstance, propertyName, defaultValue);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 29987, 30052);
                            return return_v;
                        }


                        string?
                        f_1538_30082_30113(string
                        path)
                        {
                            var return_v = Path.GetFileName(path);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 30082, 30113);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1538, 29866, 30148);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1538, 29866, 30148);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private enum DiscoveredModuleType : ushort
            {
                Unknown = 0,
                Cim = 1,
            }

            public bool IsPsCimModule
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1538, 30366, 30726);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 30410, 30488);

                        UInt16
                        moduleTypeInt = f_1538_30433_30487(_baseObject, "ModuleType", 0)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 30510, 30580);

                        DiscoveredModuleType
                        moduleType = (DiscoveredModuleType)moduleTypeInt
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 30602, 30664);

                        bool
                        isPsCimModule = (moduleType == DiscoveredModuleType.Cim)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 30686, 30707);

                        return isPsCimModule;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1538, 30366, 30726);

                        ushort
                        f_1538_30433_30487(Microsoft.Management.Infrastructure.CimInstance
                        cimInstance, string
                        propertyName, int
                        defaultValue)
                        {
                            var return_v = GetPropertyValue<UInt16>(cimInstance, propertyName, (ushort)defaultValue);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 30433, 30487);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1538, 30308, 30741);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1538, 30308, 30741);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public CimModuleFile MainManifest
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1538, 30823, 31087);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 30867, 30973);

                        byte[]
                        rawFileData = f_1538_30888_30972(_baseObject, "moduleManifestFileData", f_1538_30952_30971())
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 30995, 31068);

                        return f_1538_31002_31067(f_1538_31028_31043(this) + ".psd1", rawFileData);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1538, 30823, 31087);

                        byte[]
                        f_1538_30952_30971()
                        {
                            var return_v = Array.Empty<byte>();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 30952, 30971);
                            return return_v;
                        }


                        byte[]
                        f_1538_30888_30972(Microsoft.Management.Infrastructure.CimInstance
                        cimInstance, string
                        propertyName, byte[]
                        defaultValue)
                        {
                            var return_v = GetPropertyValue<byte[]>(cimInstance, propertyName, defaultValue);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 30888, 30972);
                            return return_v;
                        }


                        string
                        f_1538_31028_31043(System.Management.Automation.RemoteDiscoveryHelper.CimModule
                        this_param)
                        {
                            var return_v = this_param.ModuleName;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 31028, 31043);
                            return return_v;
                        }


                        System.Management.Automation.RemoteDiscoveryHelper.CimModule.CimModuleManifestFile
                        f_1538_31002_31067(string
                        fileName, byte[]
                        rawFileData)
                        {
                            var return_v = new System.Management.Automation.RemoteDiscoveryHelper.CimModule.CimModuleManifestFile(fileName, rawFileData);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 31002, 31067);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1538, 30757, 31102);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1538, 30757, 31102);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public IEnumerable<CimModuleFile> ModuleFiles
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1538, 31196, 31224);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 31202, 31222);

                        return _moduleFiles;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1538, 31196, 31224);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1538, 31118, 31239);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1538, 31118, 31239);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal void FetchAllModuleFiles(CimSession cimSession, string cimNamespace, CimOperationOptions operationOptions)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1538, 31255, 31979);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 31403, 31773);

                    IEnumerable<CimInstance>
                    associatedInstances = f_1538_31450_31772(cimSession, cimNamespace, _baseObject, DiscoveryProviderAssociationClass, DiscoveryProviderFileClass, "Antecedent", "Dependent", operationOptions)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 31793, 31906);

                    IEnumerable<CimModuleFile>
                    associatedFiles = f_1538_31838_31905(associatedInstances, i => new CimModuleImplementationFile(i))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 31924, 31964);

                    _moduleFiles = f_1538_31939_31963(associatedFiles);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1538, 31255, 31979);

                    System.Collections.Generic.IEnumerable<Microsoft.Management.Infrastructure.CimInstance>
                    f_1538_31450_31772(Microsoft.Management.Infrastructure.CimSession
                    this_param, string
                    namespaceName, Microsoft.Management.Infrastructure.CimInstance
                    sourceInstance, string
                    associationClassName, string
                    resultClassName, string
                    sourceRole, string
                    resultRole, Microsoft.Management.Infrastructure.Options.CimOperationOptions
                    options)
                    {
                        var return_v = this_param.EnumerateAssociatedInstances(namespaceName, sourceInstance, associationClassName, resultClassName, sourceRole, resultRole, options);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 31450, 31772);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<System.Management.Automation.RemoteDiscoveryHelper.CimModule.CimModuleImplementationFile>
                    f_1538_31838_31905(System.Collections.Generic.IEnumerable<Microsoft.Management.Infrastructure.CimInstance>
                    source, System.Func<Microsoft.Management.Infrastructure.CimInstance, System.Management.Automation.RemoteDiscoveryHelper.CimModule.CimModuleImplementationFile>
                    selector)
                    {
                        var return_v = source.Select<Microsoft.Management.Infrastructure.CimInstance, System.Management.Automation.RemoteDiscoveryHelper.CimModule.CimModuleImplementationFile>(selector);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 31838, 31905);
                        return return_v;
                    }


                    System.Collections.Generic.List<System.Management.Automation.RemoteDiscoveryHelper.CimModuleFile>
                    f_1538_31939_31963(System.Collections.Generic.IEnumerable<System.Management.Automation.RemoteDiscoveryHelper.CimModuleFile>
                    source)
                    {
                        var return_v = source.ToList<System.Management.Automation.RemoteDiscoveryHelper.CimModuleFile>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 31939, 31963);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1538, 31255, 31979);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1538, 31255, 31979);
                }
            }

            private List<CimModuleFile> _moduleFiles;
            private class CimModuleManifestFile : CimModuleFile
            {
                internal CimModuleManifestFile(string fileName, byte[] rawFileData)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(1538, 32136, 32533);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 32553, 32593);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 32613, 32662);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 32244, 32317);

                        f_1538_32244_32316(fileName != null, "Caller should make sure fileName != null");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 32339, 32418);

                        f_1538_32339_32417(rawFileData != null, "Caller should make sure rawFileData != null");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 32442, 32462);

                        FileName = fileName;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 32484, 32514);

                        RawFileDataCore = rawFileData;
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(1538, 32136, 32533);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1538, 32136, 32533);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1538, 32136, 32533);
                    }
                }

                public override string FileName { get; }

                internal override byte[] RawFileDataCore { get; }

                static CimModuleManifestFile()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1538, 32052, 32677);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1538, 32052, 32677);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1538, 32052, 32677);
                }

                int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1538, 32052, 32677);

                int
                f_1538_32244_32316(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 32244, 32316);
                    return 0;
                }


                int
                f_1538_32339_32417(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 32339, 32417);
                    return 0;
                }

            }
            private class CimModuleImplementationFile : CimModuleFile
            {
                private readonly CimInstance _baseObject;

                internal CimModuleImplementationFile(CimInstance baseObject)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(1538, 32844, 33363);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 32812, 32823);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 32945, 33022);

                        f_1538_32945_33021(baseObject != null, "Caller should make sure baseObject != null");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 33044, 33295);

                        f_1538_33044_33294(f_1538_33081_33192(f_1538_33081_33121(f_1538_33081_33111(baseObject)), DiscoveryProviderFileClass, StringComparison.OrdinalIgnoreCase), "Caller should make sure baseObject is an instance of the right CIM class");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 33319, 33344);

                        _baseObject = baseObject;
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(1538, 32844, 33363);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1538, 32844, 33363);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1538, 32844, 33363);
                    }
                }

                public override string FileName
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(1538, 33455, 33678);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 33507, 33592);

                            string
                            rawFileName = f_1538_33528_33591(_baseObject, "FileName", string.Empty)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 33618, 33655);

                            return f_1538_33625_33654(rawFileName);
                            DynAbs.Tracing.TraceSender.TraceExitMethod(1538, 33455, 33678);

                            string
                            f_1538_33528_33591(Microsoft.Management.Infrastructure.CimInstance
                            cimInstance, string
                            propertyName, string
                            defaultValue)
                            {
                                var return_v = GetPropertyValue<string>(cimInstance, propertyName, defaultValue);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 33528, 33591);
                                return return_v;
                            }


                            string?
                            f_1538_33625_33654(string
                            path)
                            {
                                var return_v = Path.GetFileName(path);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 33625, 33654);
                                return return_v;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1538, 33383, 33697);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1538, 33383, 33697);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                internal override byte[] RawFileDataCore
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(1538, 33798, 33884);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 33804, 33882);

                            return f_1538_33811_33881(_baseObject, "FileData", f_1538_33861_33880());
                            DynAbs.Tracing.TraceSender.TraceExitMethod(1538, 33798, 33884);

                            byte[]
                            f_1538_33861_33880()
                            {
                                var return_v = Array.Empty<byte>();
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 33861, 33880);
                                return return_v;
                            }


                            byte[]
                            f_1538_33811_33881(Microsoft.Management.Infrastructure.CimInstance
                            cimInstance, string
                            propertyName, byte[]
                            defaultValue)
                            {
                                var return_v = GetPropertyValue<byte[]>(cimInstance, propertyName, defaultValue);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 33811, 33881);
                                return return_v;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1538, 33717, 33903);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1538, 33717, 33903);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                static CimModuleImplementationFile()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1538, 32693, 33918);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1538, 32693, 33918);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1538, 32693, 33918);
                }

                int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1538, 32693, 33918);

                int
                f_1538_32945_33021(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 32945, 33021);
                    return 0;
                }


                Microsoft.Management.Infrastructure.CimSystemProperties
                f_1538_33081_33111(Microsoft.Management.Infrastructure.CimInstance
                this_param)
                {
                    var return_v = this_param.CimSystemProperties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 33081, 33111);
                    return return_v;
                }


                string
                f_1538_33081_33121(Microsoft.Management.Infrastructure.CimSystemProperties
                this_param)
                {
                    var return_v = this_param.ClassName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 33081, 33121);
                    return return_v;
                }


                bool
                f_1538_33081_33192(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 33081, 33192);
                    return return_v;
                }


                int
                f_1538_33044_33294(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 33044, 33294);
                    return 0;
                }

            }

            static CimModule()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1538, 29269, 33929);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1538, 29269, 33929);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1538, 29269, 33929);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1538, 29269, 33929);

            int
            f_1538_29450_29526(bool
            condition, string
            whyThisShouldNeverHappen)
            {
                Dbg.Assert(condition, whyThisShouldNeverHappen);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 29450, 29526);
                return 0;
            }


            Microsoft.Management.Infrastructure.CimSystemProperties
            f_1538_29578_29608(Microsoft.Management.Infrastructure.CimInstance
            this_param)
            {
                var return_v = this_param.CimSystemProperties;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 29578, 29608);
                return return_v;
            }


            string
            f_1538_29578_29618(Microsoft.Management.Infrastructure.CimSystemProperties
            this_param)
            {
                var return_v = this_param.ClassName;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 29578, 29618);
                return return_v;
            }


            bool
            f_1538_29578_29691(string
            this_param, string
            value, System.StringComparison
            comparisonType)
            {
                var return_v = this_param.Equals(value, comparisonType);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 29578, 29691);
                return return_v;
            }


            int
            f_1538_29545_29789(bool
            condition, string
            whyThisShouldNeverHappen)
            {
                Dbg.Assert(condition, whyThisShouldNeverHappen);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 29545, 29789);
                return 0;
            }

        }

        internal static IEnumerable<CimModule> GetCimModules(
                    CimSession cimSession,
                    Uri resourceUri,
                    string cimNamespace,
                    IEnumerable<string> moduleNamePatterns,
                    bool onlyManifests,
                    Cmdlet cmdlet,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1538, 33941, 35102);

                var listYield = new List<CimModule>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 34283, 34340);

                moduleNamePatterns = moduleNamePatterns ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.IEnumerable<string>>(1538, 34304, 34339) ?? new[] { "*" });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 34354, 34458);

                HashSet<string>
                alreadyEmittedNamesOfCimModules = f_1538_34404_34457(f_1538_34424_34456())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 34474, 34740);

                IEnumerable<CimModule>
                remoteModules = f_1538_34513_34739(moduleNamePatterns
                , moduleNamePattern =>
                                    RemoteDiscoveryHelper.GetCimModules(cimSession, resourceUri, cimNamespace, moduleNamePattern, onlyManifests, cmdlet, cancellationToken))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 34754, 35091);
                    foreach (CimModule remoteModule in f_1538_34789_34802_I(remoteModules))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 34754, 35091);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 34836, 35076) || true) && (!f_1538_34841_34906(alreadyEmittedNamesOfCimModules, f_1538_34882_34905(remoteModule)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 34836, 35076);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 34948, 35009);

                            f_1538_34948_35008(alreadyEmittedNamesOfCimModules, f_1538_34984_35007(remoteModule));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 35031, 35057);

                            listYield.Add(remoteModule);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 34836, 35076);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 34754, 35091);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1538, 1, 338);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1538, 1, 338);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1538, 33941, 35102);

                return listYield;

                System.StringComparer
                f_1538_34424_34456()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 34424, 34456);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_1538_34404_34457(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.HashSet<string>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 34404, 34457);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.RemoteDiscoveryHelper.CimModule>
                f_1538_34513_34739(System.Collections.Generic.IEnumerable<string>
                source, System.Func<string, System.Collections.Generic.IEnumerable<System.Management.Automation.RemoteDiscoveryHelper.CimModule>>
                selector)
                {
                    var return_v = source.SelectMany<string, System.Management.Automation.RemoteDiscoveryHelper.CimModule>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 34513, 34739);
                    return return_v;
                }


                string
                f_1538_34882_34905(System.Management.Automation.RemoteDiscoveryHelper.CimModule
                this_param)
                {
                    var return_v = this_param.ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 34882, 34905);
                    return return_v;
                }


                bool
                f_1538_34841_34906(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 34841, 34906);
                    return return_v;
                }


                string
                f_1538_34984_35007(System.Management.Automation.RemoteDiscoveryHelper.CimModule
                this_param)
                {
                    var return_v = this_param.ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 34984, 35007);
                    return return_v;
                }


                bool
                f_1538_34948_35008(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 34948, 35008);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.RemoteDiscoveryHelper.CimModule>
                f_1538_34789_34802_I(System.Collections.Generic.IEnumerable<System.Management.Automation.RemoteDiscoveryHelper.CimModule>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 34789, 34802);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1538, 33941, 35102);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1538, 33941, 35102);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<CimModule> GetCimModules(
                    CimSession cimSession,
                    Uri resourceUri,
                    string cimNamespace,
                    string moduleNamePattern,
                    bool onlyManifests,
                    Cmdlet cmdlet,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1538, 35114, 38157);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 35441, 35515);

                f_1538_35441_35514(cimSession != null, "Caller should verify cimSession != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 35529, 35622);

                f_1538_35529_35621(moduleNamePattern != null, "Caller should verify that moduleNamePattern != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 35638, 35740);

                const WildcardOptions
                wildcardOptions = WildcardOptions.IgnoreCase | WildcardOptions.CultureInvariant
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 35754, 35832);

                var
                wildcardPattern = f_1538_35776_35831(moduleNamePattern, wildcardOptions)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 35846, 35925);

                string
                dosWildcard = f_1538_35867_35924(wildcardPattern)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 35941, 36021);

                var
                options = new CimOperationOptions { CancellationToken = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => cancellationToken, 1538, 35955, 36020) }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 36035, 36115);

                f_1538_36035_36114(options, "PS_ModuleNamePattern", dosWildcard, mustComply: false);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 36129, 36235) || true) && (resourceUri != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 36129, 36235);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 36186, 36220);

                    options.ResourceUri = resourceUri;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 36129, 36235);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 36251, 36405) || true) && (f_1538_36255_36289(cimNamespace) && (DynAbs.Tracing.TraceSender.Expression_True(1538, 36255, 36314) && (resourceUri == null)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 36251, 36405);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 36348, 36390);

                    cimNamespace = DiscoveryProviderNamespace;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 36251, 36405);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 36475, 36649);

                IEnumerable<CimInstance>
                syncResults = f_1538_36514_36648(cimSession, cimNamespace, DiscoveryProviderModuleClass, options)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 36714, 36914);

                IEnumerable<CimModule>
                cimModules = f_1538_36750_36913(f_1538_36750_36829(syncResults
                , cimInstance => new CimModule(cimInstance)), cimModule => wildcardPattern.IsMatch(cimModule.ModuleName))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 36930, 37262) || true) && (!onlyManifests)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 36930, 37262);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 36982, 37247);

                    cimModules = f_1538_36995_37246(cimModules, delegate (CimModule cimModule)
                                        {
                                            cimModule.FetchAllModuleFiles(cimSession, cimNamespace, options);
                                            return cimModule;
                                        });
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 36930, 37262);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 37278, 38146);

                return f_1538_37285_38145(cimModules, delegate (Exception exception)
                                {
                                    ErrorRecord errorRecord = GetErrorRecordForRemoteDiscoveryProvider(exception);
                                    if (!cmdlet.MyInvocation.ExpectingInput)
                                    {
                                        if (((-1) != errorRecord.FullyQualifiedErrorId.IndexOf(DiscoveryProviderNotFoundErrorId, StringComparison.OrdinalIgnoreCase)) ||
                                            (cancellationToken.IsCancellationRequested || (exception is OperationCanceledException)) ||
                                            (!cimSession.TestConnection()))
                                        {
                                            cmdlet.ThrowTerminatingError(errorRecord);
                                        }
                                    }

                                    cmdlet.WriteError(errorRecord);
                                });
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1538, 35114, 38157);

                int
                f_1538_35441_35514(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 35441, 35514);
                    return 0;
                }


                int
                f_1538_35529_35621(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 35529, 35621);
                    return 0;
                }


                System.Management.Automation.WildcardPattern
                f_1538_35776_35831(string
                pattern, System.Management.Automation.WildcardOptions
                options)
                {
                    var return_v = WildcardPattern.Get(pattern, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 35776, 35831);
                    return return_v;
                }


                string
                f_1538_35867_35924(System.Management.Automation.WildcardPattern
                wildcardPattern)
                {
                    var return_v = WildcardPatternToDosWildcardParser.Parse(wildcardPattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 35867, 35924);
                    return return_v;
                }


                int
                f_1538_36035_36114(Microsoft.Management.Infrastructure.Options.CimOperationOptions
                this_param, string
                optionName, string
                optionValue, bool
                mustComply)
                {
                    this_param.SetCustomOption(optionName, optionValue, mustComply: mustComply);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 36035, 36114);
                    return 0;
                }


                bool
                f_1538_36255_36289(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 36255, 36289);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Management.Infrastructure.CimInstance>
                f_1538_36514_36648(Microsoft.Management.Infrastructure.CimSession
                this_param, string
                namespaceName, string
                className, Microsoft.Management.Infrastructure.Options.CimOperationOptions
                options)
                {
                    var return_v = this_param.EnumerateInstances(namespaceName, className, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 36514, 36648);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.RemoteDiscoveryHelper.CimModule>
                f_1538_36750_36829(System.Collections.Generic.IEnumerable<Microsoft.Management.Infrastructure.CimInstance>
                source, System.Func<Microsoft.Management.Infrastructure.CimInstance, System.Management.Automation.RemoteDiscoveryHelper.CimModule>
                selector)
                {
                    var return_v = source.Select<Microsoft.Management.Infrastructure.CimInstance, System.Management.Automation.RemoteDiscoveryHelper.CimModule>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 36750, 36829);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.RemoteDiscoveryHelper.CimModule>
                f_1538_36750_36913(System.Collections.Generic.IEnumerable<System.Management.Automation.RemoteDiscoveryHelper.CimModule>
                source, System.Func<System.Management.Automation.RemoteDiscoveryHelper.CimModule, bool>
                predicate)
                {
                    var return_v = source.Where<System.Management.Automation.RemoteDiscoveryHelper.CimModule>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 36750, 36913);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.RemoteDiscoveryHelper.CimModule>
                f_1538_36995_37246(System.Collections.Generic.IEnumerable<System.Management.Automation.RemoteDiscoveryHelper.CimModule>
                source, System.Func<System.Management.Automation.RemoteDiscoveryHelper.CimModule, System.Management.Automation.RemoteDiscoveryHelper.CimModule>
                selector)
                {
                    var return_v = source.Select<System.Management.Automation.RemoteDiscoveryHelper.CimModule, System.Management.Automation.RemoteDiscoveryHelper.CimModule>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 36995, 37246);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.RemoteDiscoveryHelper.CimModule>
                f_1538_37285_38145(System.Collections.Generic.IEnumerable<System.Management.Automation.RemoteDiscoveryHelper.CimModule>
                enumerable, System.Action<System.Exception>
                exceptionHandler)
                {
                    var return_v = EnumerateWithCatch(enumerable, exceptionHandler);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 37285, 38145);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1538, 35114, 38157);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1538, 35114, 38157);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Hashtable RewriteManifest(Hashtable originalManifest)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1538, 38169, 38333);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 38263, 38322);

                return f_1538_38270_38321(originalManifest, null, null, null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1538, 38169, 38333);

                System.Collections.Hashtable
                f_1538_38270_38321(System.Collections.Hashtable
                originalManifest, System.Collections.Generic.IEnumerable<string>
                nestedModules, System.Collections.Generic.IEnumerable<string>
                typesToProcess, System.Collections.Generic.IEnumerable<string>
                formatsToProcess)
                {
                    var return_v = RewriteManifest(originalManifest, nestedModules, typesToProcess, formatsToProcess);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 38270, 38321);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1538, 38169, 38333);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1538, 38169, 38333);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly string[] s_manifestEntriesToKeepAsString;

        private static readonly string[] s_manifestEntriesToKeepAsStringArray;

        internal static Hashtable RewriteManifest(
                    Hashtable originalManifest,
                    IEnumerable<string> nestedModules,
                    IEnumerable<string> typesToProcess,
                    IEnumerable<string> formatsToProcess)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1538, 38858, 40494);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 39114, 39169);

                nestedModules = nestedModules ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.IEnumerable<string>>(1538, 39130, 39168) ?? f_1538_39147_39168());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 39183, 39240);

                typesToProcess = typesToProcess ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.IEnumerable<string>>(1538, 39200, 39239) ?? f_1538_39218_39239());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 39254, 39315);

                formatsToProcess = formatsToProcess ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.IEnumerable<string>>(1538, 39273, 39314) ?? f_1538_39293_39314());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 39331, 39397);

                var
                newManifest = f_1538_39349_39396(f_1538_39363_39395())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 39411, 39456);

                newManifest["NestedModules"] = nestedModules;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 39470, 39517);

                newManifest["TypesToProcess"] = typesToProcess;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 39531, 39582);

                newManifest["FormatsToProcess"] = formatsToProcess;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 39596, 39657);

                newManifest["PrivateData"] = f_1538_39625_39656(originalManifest, "PrivateData");
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 39673, 40448);
                    foreach (DictionaryEntry entry in f_1538_39707_39723_I(originalManifest))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 39673, 40448);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 39757, 40433) || true) && (f_1538_39761_39856(s_manifestEntriesToKeepAsString, entry.Key as string, f_1538_39823_39855()))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 39757, 40433);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 39898, 40006);

                            var
                            value = (string)f_1538_39918_40005(entry.Value, typeof(string), f_1538_39976_40004())
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 40028, 40059);

                            newManifest[entry.Key] = value;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 39757, 40433);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 39757, 40433);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 40101, 40433) || true) && (f_1538_40105_40205(s_manifestEntriesToKeepAsStringArray, entry.Key as string, f_1538_40172_40204()))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 40101, 40433);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 40247, 40360);

                                var
                                values = (string[])f_1538_40270_40359(entry.Value, typeof(string[]), f_1538_40330_40358())
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 40382, 40414);

                                newManifest[entry.Key] = values;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 40101, 40433);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 39757, 40433);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 39673, 40448);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1538, 1, 776);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1538, 1, 776);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 40464, 40483);

                return newManifest;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1538, 38858, 40494);

                string[]
                f_1538_39147_39168()
                {
                    var return_v = Array.Empty<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 39147, 39168);
                    return return_v;
                }


                string[]
                f_1538_39218_39239()
                {
                    var return_v = Array.Empty<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 39218, 39239);
                    return return_v;
                }


                string[]
                f_1538_39293_39314()
                {
                    var return_v = Array.Empty<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 39293, 39314);
                    return return_v;
                }


                System.StringComparer
                f_1538_39363_39395()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 39363, 39395);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1538_39349_39396(System.StringComparer
                equalityComparer)
                {
                    var return_v = new System.Collections.Hashtable((System.Collections.IEqualityComparer)equalityComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 39349, 39396);
                    return return_v;
                }


                object
                f_1538_39625_39656(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 39625, 39656);
                    return return_v;
                }


                System.StringComparer
                f_1538_39823_39855()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 39823, 39855);
                    return return_v;
                }


                bool
                f_1538_39761_39856(string[]
                source, object
                value, System.StringComparer
                comparer)
                {
                    var return_v = source.Contains<string>((string)value, (System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 39761, 39856);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1538_39976_40004()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 39976, 40004);
                    return return_v;
                }


                object
                f_1538_39918_40005(object
                valueToConvert, System.Type
                resultType, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = LanguagePrimitives.ConvertTo(valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 39918, 40005);
                    return return_v;
                }


                System.StringComparer
                f_1538_40172_40204()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 40172, 40204);
                    return return_v;
                }


                bool
                f_1538_40105_40205(string[]
                source, object
                value, System.StringComparer
                comparer)
                {
                    var return_v = source.Contains<string>((string)value, (System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 40105, 40205);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1538_40330_40358()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 40330, 40358);
                    return return_v;
                }


                object
                f_1538_40270_40359(object
                valueToConvert, System.Type
                resultType, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = LanguagePrimitives.ConvertTo(valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 40270, 40359);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1538_39707_39723_I(System.Collections.Hashtable
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 39707, 39723);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1538, 38858, 40494);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1538, 38858, 40494);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static CimCredential GetCimCredentials(PasswordAuthenticationMechanism authenticationMechanism, PSCredential credential)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1538, 40506, 40881);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 40659, 40731);

                NetworkCredential
                networkCredential = f_1538_40697_40730(credential)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 40745, 40870);

                return f_1538_40752_40869(authenticationMechanism, f_1538_40795_40819(networkCredential), f_1538_40821_40847(networkCredential), f_1538_40849_40868(credential));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1538, 40506, 40881);

                System.Net.NetworkCredential
                f_1538_40697_40730(System.Management.Automation.PSCredential
                this_param)
                {
                    var return_v = this_param.GetNetworkCredential();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 40697, 40730);
                    return return_v;
                }


                string
                f_1538_40795_40819(System.Net.NetworkCredential
                this_param)
                {
                    var return_v = this_param.Domain;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 40795, 40819);
                    return return_v;
                }


                string
                f_1538_40821_40847(System.Net.NetworkCredential
                this_param)
                {
                    var return_v = this_param.UserName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 40821, 40847);
                    return return_v;
                }


                System.Security.SecureString
                f_1538_40849_40868(System.Management.Automation.PSCredential
                this_param)
                {
                    var return_v = this_param.Password;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 40849, 40868);
                    return return_v;
                }


                Microsoft.Management.Infrastructure.Options.CimCredential
                f_1538_40752_40869(Microsoft.Management.Infrastructure.Options.PasswordAuthenticationMechanism
                authenticationMechanism, string
                domain, string
                userName, System.Security.SecureString
                password)
                {
                    var return_v = new Microsoft.Management.Infrastructure.Options.CimCredential(authenticationMechanism, domain, userName, password);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 40752, 40869);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1538, 40506, 40881);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1538, 40506, 40881);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Exception GetExceptionWhenAuthenticationRequiresCredential(string authentication)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1538, 40893, 41281);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 41014, 41214);

                string
                errorMessage = f_1538_41036_41213(f_1538_41068_41096(), f_1538_41115_41179(), authentication)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 41228, 41270);

                throw f_1538_41234_41269(errorMessage);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1538, 40893, 41281);

                System.Globalization.CultureInfo
                f_1538_41068_41096()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 41068, 41096);
                    return return_v;
                }


                string
                f_1538_41115_41179()
                {
                    var return_v = RemotingErrorIdStrings.AuthenticationMechanismRequiresCredential;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 41115, 41179);
                    return return_v;
                }


                string
                f_1538_41036_41213(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 41036, 41213);
                    return return_v;
                }


                System.ArgumentException
                f_1538_41234_41269(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 41234, 41269);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1538, 40893, 41281);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1538, 40893, 41281);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static CimCredential GetCimCredentials(string authentication, PSCredential credential)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1538, 41293, 44277);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 41412, 41816) || true) && (authentication == null || (DynAbs.Tracing.TraceSender.Expression_False(1538, 41416, 41512) || (f_1538_41443_41511(authentication, "Default", StringComparison.OrdinalIgnoreCase))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 41412, 41816);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 41546, 41801) || true) && (credential == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 41546, 41801);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 41610, 41622);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 41546, 41801);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 41546, 41801);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 41704, 41782);

                        return f_1538_41711_41781(PasswordAuthenticationMechanism.Default, credential);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 41546, 41801);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 41412, 41816);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 41832, 42263) || true) && (f_1538_41836_41902(authentication, "Basic", StringComparison.OrdinalIgnoreCase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 41832, 42263);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 41936, 42248) || true) && (credential == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 41936, 42248);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 42000, 42071);

                        throw f_1538_42006_42070(authentication);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 41936, 42248);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 41936, 42248);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 42153, 42229);

                        return f_1538_42160_42228(PasswordAuthenticationMechanism.Basic, credential);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 41936, 42248);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 41832, 42263);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 42279, 42719) || true) && (f_1538_42283_42353(authentication, "Negotiate", StringComparison.OrdinalIgnoreCase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 42279, 42719);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 42387, 42704) || true) && (credential == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 42387, 42704);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 42451, 42523);

                        return f_1538_42458_42522(ImpersonatedAuthenticationMechanism.Negotiate);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 42387, 42704);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 42387, 42704);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 42605, 42685);

                        return f_1538_42612_42684(PasswordAuthenticationMechanism.Negotiate, credential);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 42387, 42704);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 42279, 42719);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 42735, 43170) || true) && (f_1538_42739_42807(authentication, "CredSSP", StringComparison.OrdinalIgnoreCase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 42735, 43170);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 42841, 43155) || true) && (credential == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 42841, 43155);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 42905, 42976);

                        throw f_1538_42911_42975(authentication);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 42841, 43155);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 42841, 43155);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 43058, 43136);

                        return f_1538_43065_43135(PasswordAuthenticationMechanism.CredSsp, credential);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 42841, 43155);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 42735, 43170);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 43186, 43619) || true) && (f_1538_43190_43257(authentication, "Digest", StringComparison.OrdinalIgnoreCase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 43186, 43619);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 43291, 43604) || true) && (credential == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 43291, 43604);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 43355, 43426);

                        throw f_1538_43361_43425(authentication);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 43291, 43604);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 43291, 43604);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 43508, 43585);

                        return f_1538_43515_43584(PasswordAuthenticationMechanism.Digest, credential);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 43291, 43604);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 43186, 43619);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 43635, 44072) || true) && (f_1538_43639_43708(authentication, "Kerberos", StringComparison.OrdinalIgnoreCase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 43635, 44072);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 43742, 44057) || true) && (credential == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 43742, 44057);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 43806, 43877);

                        return f_1538_43813_43876(ImpersonatedAuthenticationMechanism.Kerberos);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 43742, 44057);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 43742, 44057);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 43959, 44038);

                        return f_1538_43966_44037(PasswordAuthenticationMechanism.Kerberos, credential);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 43742, 44057);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 43635, 44072);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 44088, 44196);

                f_1538_44088_44195(false, "Unrecognized authentication mechanism [ValidateSet should prevent that from happening]");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 44210, 44266);

                throw f_1538_44216_44265("authentication");
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1538, 41293, 44277);

                bool
                f_1538_41443_41511(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 41443, 41511);
                    return return_v;
                }


                Microsoft.Management.Infrastructure.Options.CimCredential
                f_1538_41711_41781(Microsoft.Management.Infrastructure.Options.PasswordAuthenticationMechanism
                authenticationMechanism, System.Management.Automation.PSCredential
                credential)
                {
                    var return_v = GetCimCredentials(authenticationMechanism, credential);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 41711, 41781);
                    return return_v;
                }


                bool
                f_1538_41836_41902(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 41836, 41902);
                    return return_v;
                }


                System.Exception
                f_1538_42006_42070(string
                authentication)
                {
                    var return_v = GetExceptionWhenAuthenticationRequiresCredential(authentication);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 42006, 42070);
                    return return_v;
                }


                Microsoft.Management.Infrastructure.Options.CimCredential
                f_1538_42160_42228(Microsoft.Management.Infrastructure.Options.PasswordAuthenticationMechanism
                authenticationMechanism, System.Management.Automation.PSCredential
                credential)
                {
                    var return_v = GetCimCredentials(authenticationMechanism, credential);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 42160, 42228);
                    return return_v;
                }


                bool
                f_1538_42283_42353(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 42283, 42353);
                    return return_v;
                }


                Microsoft.Management.Infrastructure.Options.CimCredential
                f_1538_42458_42522(Microsoft.Management.Infrastructure.Options.ImpersonatedAuthenticationMechanism
                authenticationMechanism)
                {
                    var return_v = new Microsoft.Management.Infrastructure.Options.CimCredential(authenticationMechanism);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 42458, 42522);
                    return return_v;
                }


                Microsoft.Management.Infrastructure.Options.CimCredential
                f_1538_42612_42684(Microsoft.Management.Infrastructure.Options.PasswordAuthenticationMechanism
                authenticationMechanism, System.Management.Automation.PSCredential
                credential)
                {
                    var return_v = GetCimCredentials(authenticationMechanism, credential);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 42612, 42684);
                    return return_v;
                }


                bool
                f_1538_42739_42807(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 42739, 42807);
                    return return_v;
                }


                System.Exception
                f_1538_42911_42975(string
                authentication)
                {
                    var return_v = GetExceptionWhenAuthenticationRequiresCredential(authentication);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 42911, 42975);
                    return return_v;
                }


                Microsoft.Management.Infrastructure.Options.CimCredential
                f_1538_43065_43135(Microsoft.Management.Infrastructure.Options.PasswordAuthenticationMechanism
                authenticationMechanism, System.Management.Automation.PSCredential
                credential)
                {
                    var return_v = GetCimCredentials(authenticationMechanism, credential);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 43065, 43135);
                    return return_v;
                }


                bool
                f_1538_43190_43257(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 43190, 43257);
                    return return_v;
                }


                System.Exception
                f_1538_43361_43425(string
                authentication)
                {
                    var return_v = GetExceptionWhenAuthenticationRequiresCredential(authentication);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 43361, 43425);
                    return return_v;
                }


                Microsoft.Management.Infrastructure.Options.CimCredential
                f_1538_43515_43584(Microsoft.Management.Infrastructure.Options.PasswordAuthenticationMechanism
                authenticationMechanism, System.Management.Automation.PSCredential
                credential)
                {
                    var return_v = GetCimCredentials(authenticationMechanism, credential);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 43515, 43584);
                    return return_v;
                }


                bool
                f_1538_43639_43708(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 43639, 43708);
                    return return_v;
                }


                Microsoft.Management.Infrastructure.Options.CimCredential
                f_1538_43813_43876(Microsoft.Management.Infrastructure.Options.ImpersonatedAuthenticationMechanism
                authenticationMechanism)
                {
                    var return_v = new Microsoft.Management.Infrastructure.Options.CimCredential(authenticationMechanism);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 43813, 43876);
                    return return_v;
                }


                Microsoft.Management.Infrastructure.Options.CimCredential
                f_1538_43966_44037(Microsoft.Management.Infrastructure.Options.PasswordAuthenticationMechanism
                authenticationMechanism, System.Management.Automation.PSCredential
                credential)
                {
                    var return_v = GetCimCredentials(authenticationMechanism, credential);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 43966, 44037);
                    return return_v;
                }


                int
                f_1538_44088_44195(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 44088, 44195);
                    return 0;
                }


                System.ArgumentOutOfRangeException
                f_1538_44216_44265(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 44216, 44265);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1538, 41293, 44277);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1538, 41293, 44277);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static CimSession CreateCimSession(
                    string computerName,
                    PSCredential credential,
                    string authentication,
                    bool isLocalHost,
                    CancellationToken cancellationToken,
                    PSCmdlet cmdlet)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1538, 44289, 45103);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 44577, 44672) || true) && (isLocalHost)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 44577, 44672);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 44626, 44657);

                    return f_1538_44633_44656(null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 44577, 44672);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 44688, 44733);

                var
                sessionOptions = f_1538_44709_44732()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 44749, 44826);

                CimCredential
                cimCredentials = f_1538_44780_44825(authentication, credential)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 44840, 44972) || true) && (cimCredentials != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 44840, 44972);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 44900, 44957);

                    f_1538_44900_44956(sessionOptions, cimCredentials);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 44840, 44972);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 44988, 45060);

                CimSession
                cimSession = f_1538_45012_45059(computerName, sessionOptions)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 45074, 45092);

                return cimSession;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1538, 44289, 45103);

                Microsoft.Management.Infrastructure.CimSession
                f_1538_44633_44656(string
                computerName)
                {
                    var return_v = CimSession.Create(computerName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 44633, 44656);
                    return return_v;
                }


                Microsoft.Management.Infrastructure.Options.CimSessionOptions
                f_1538_44709_44732()
                {
                    var return_v = new Microsoft.Management.Infrastructure.Options.CimSessionOptions();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 44709, 44732);
                    return return_v;
                }


                Microsoft.Management.Infrastructure.Options.CimCredential
                f_1538_44780_44825(string
                authentication, System.Management.Automation.PSCredential
                credential)
                {
                    var return_v = GetCimCredentials(authentication, credential);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 44780, 44825);
                    return return_v;
                }


                int
                f_1538_44900_44956(Microsoft.Management.Infrastructure.Options.CimSessionOptions
                this_param, Microsoft.Management.Infrastructure.Options.CimCredential
                credential)
                {
                    this_param.AddDestinationCredentials(credential);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 44900, 44956);
                    return 0;
                }


                Microsoft.Management.Infrastructure.CimSession
                f_1538_45012_45059(string
                computerName, Microsoft.Management.Infrastructure.Options.CimSessionOptions
                sessionOptions)
                {
                    var return_v = CimSession.Create(computerName, sessionOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 45012, 45059);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1538, 44289, 45103);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1538, 44289, 45103);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Hashtable ConvertCimModuleFileToManifestHashtable(RemoteDiscoveryHelper.CimModuleFile cimModuleFile, string temporaryModuleManifestPath, ModuleCmdletBase cmdlet, ref bool containedErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1538, 45115, 46663);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 45343, 45475);

                f_1538_45343_45474(f_1538_45354_45376(cimModuleFile) == RemoteDiscoveryHelper.CimFileCode.PsdV1, "Caller should verify the file is of the right type");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 45491, 45528);

                ScriptBlockAst
                scriptBlockAst = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 45542, 46079) || true) && (!containedErrors)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 45542, 46079);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 45596, 45658);

                    System.Management.Automation.Language.Token[]
                    throwAwayTokens
                    = default(System.Management.Automation.Language.Token[]);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 45676, 45701);

                    ParseError[]
                    parseErrors
                    = default(ParseError[]);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 45719, 45883);

                    scriptBlockAst = f_1538_45736_45882(f_1538_45792_45814(cimModuleFile), temporaryModuleManifestPath, out throwAwayTokens, out parseErrors);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 45901, 46064) || true) && ((scriptBlockAst == null) || (DynAbs.Tracing.TraceSender.Expression_False(1538, 45905, 45980) || (parseErrors != null && (DynAbs.Tracing.TraceSender.Expression_True(1538, 45934, 45979) && f_1538_45957_45975(parseErrors) > 0))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 45901, 46064);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 46022, 46045);

                        containedErrors = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 45901, 46064);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 45542, 46079);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 46095, 46117);

                Hashtable
                data = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 46131, 46624) || true) && (!containedErrors)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 46131, 46624);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 46185, 46260);

                    ScriptBlock
                    scriptBlock = f_1538_46211_46259(scriptBlockAst, isFilter: false)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 46278, 46609);

                    data = f_1538_46285_46608(cmdlet, temporaryModuleManifestPath, scriptBlock, ModuleCmdletBase.ModuleManifestMembers, 0, ref containedErrors);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 46131, 46624);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 46640, 46652);

                return data;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1538, 45115, 46663);

                System.Management.Automation.RemoteDiscoveryHelper.CimFileCode
                f_1538_45354_45376(System.Management.Automation.RemoteDiscoveryHelper.CimModuleFile
                this_param)
                {
                    var return_v = this_param.FileCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 45354, 45376);
                    return return_v;
                }


                int
                f_1538_45343_45474(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 45343, 45474);
                    return 0;
                }


                string
                f_1538_45792_45814(System.Management.Automation.RemoteDiscoveryHelper.CimModuleFile
                this_param)
                {
                    var return_v = this_param.FileData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 45792, 45814);
                    return return_v;
                }


                System.Management.Automation.Language.ScriptBlockAst
                f_1538_45736_45882(string
                input, string
                fileName, out System.Management.Automation.Language.Token[]
                tokens, out System.Management.Automation.Language.ParseError[]
                errors)
                {
                    var return_v = System.Management.Automation.Language.Parser.ParseInput(input, fileName, out tokens, out errors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 45736, 45882);
                    return return_v;
                }


                int
                f_1538_45957_45975(System.Management.Automation.Language.ParseError[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 45957, 45975);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1538_46211_46259(System.Management.Automation.Language.ScriptBlockAst
                ast, bool
                isFilter)
                {
                    var return_v = new System.Management.Automation.ScriptBlock((System.Management.Automation.Language.IParameterMetadataProvider)ast, isFilter: isFilter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 46211, 46259);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1538_46285_46608(Microsoft.PowerShell.Commands.ModuleCmdletBase
                this_param, string
                moduleManifestPath, System.Management.Automation.ScriptBlock
                scriptBlock, string[]
                validMembers, int
                manifestProcessingFlags, ref bool
                containedErrors)
                {
                    var return_v = this_param.LoadModuleManifestData(moduleManifestPath, scriptBlock, validMembers, (Microsoft.PowerShell.Commands.ModuleCmdletBase.ManifestProcessingFlags)manifestProcessingFlags, ref containedErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 46285, 46608);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1538, 45115, 46663);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1538, 45115, 46663);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string GetModulePath(string remoteModuleName, Version remoteModuleVersion, string computerName, Runspace localRunspace)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1538, 46762, 47737);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 46922, 46966);

                computerName = computerName ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1538, 46937, 46965) ?? string.Empty);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 46982, 47079);

                string
                sanitizedRemoteModuleName = f_1538_47017_47078(remoteModuleName, "[^a-zA-Z0-9]", string.Empty)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 47093, 47182);

                string
                sanitizedComputerName = f_1538_47124_47181(computerName, "[^a-zA-Z0-9]", string.Empty)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 47196, 47615);

                string
                moduleName = f_1538_47216_47614(f_1538_47248_47276(), "remoteIpMoProxy_{0}_{1}_{2}_{3}", f_1538_47347_47434(sanitizedRemoteModuleName, 0, f_1538_47386_47433(f_1538_47395_47427(sanitizedRemoteModuleName), 100)), remoteModuleVersion, f_1538_47491_47570(sanitizedComputerName, 0, f_1538_47526_47569(f_1538_47535_47563(sanitizedComputerName), 100)), f_1538_47589_47613(localRunspace))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 47629, 47694);

                string
                modulePath = f_1538_47649_47693(f_1538_47662_47680(), moduleName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 47708, 47726);

                return modulePath;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1538, 46762, 47737);

                string
                f_1538_47017_47078(string
                input, string
                pattern, string
                replacement)
                {
                    var return_v = Regex.Replace(input, pattern, replacement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 47017, 47078);
                    return return_v;
                }


                string
                f_1538_47124_47181(string
                input, string
                pattern, string
                replacement)
                {
                    var return_v = Regex.Replace(input, pattern, replacement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 47124, 47181);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1538_47248_47276()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 47248, 47276);
                    return return_v;
                }


                int
                f_1538_47395_47427(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 47395, 47427);
                    return return_v;
                }


                int
                f_1538_47386_47433(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 47386, 47433);
                    return return_v;
                }


                string
                f_1538_47347_47434(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 47347, 47434);
                    return return_v;
                }


                int
                f_1538_47535_47563(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 47535, 47563);
                    return return_v;
                }


                int
                f_1538_47526_47569(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 47526, 47569);
                    return return_v;
                }


                string
                f_1538_47491_47570(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 47491, 47570);
                    return return_v;
                }


                System.Guid
                f_1538_47589_47613(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 47589, 47613);
                    return return_v;
                }


                string
                f_1538_47216_47614(System.Globalization.CultureInfo
                provider, string
                format, params object?[]
                args)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 47216, 47614);
                    return return_v;
                }


                string
                f_1538_47662_47680()
                {
                    var return_v = Path.GetTempPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 47662, 47680);
                    return return_v;
                }


                string
                f_1538_47649_47693(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 47649, 47693);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1538, 46762, 47737);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1538, 46762, 47737);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void AssociatePSModuleInfoWithSession(PSModuleInfo moduleInfo, CimSession cimSession, Uri resourceUri, string cimNamespace)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1538, 47749, 48052);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 47913, 48041);

                f_1538_47913_48040(moduleInfo, f_1538_47966_48039(cimSession, resourceUri, cimNamespace));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1538, 47749, 48052);

                System.Tuple<Microsoft.Management.Infrastructure.CimSession, System.Uri, string>
                f_1538_47966_48039(Microsoft.Management.Infrastructure.CimSession
                item1, System.Uri
                item2, string
                item3)
                {
                    var return_v = new System.Tuple<Microsoft.Management.Infrastructure.CimSession, System.Uri, string>(item1, item2, item3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 47966, 48039);
                    return return_v;
                }


                int
                f_1538_47913_48040(System.Management.Automation.PSModuleInfo
                moduleInfo, System.Tuple<Microsoft.Management.Infrastructure.CimSession, System.Uri, string>
                weaklyTypedSession)
                {
                    AssociatePSModuleInfoWithSession(moduleInfo, (object)weaklyTypedSession);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 47913, 48040);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1538, 47749, 48052);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1538, 47749, 48052);
            }
        }

        internal static void AssociatePSModuleInfoWithSession(PSModuleInfo moduleInfo, PSSession psSession)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1538, 48064, 48263);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 48188, 48252);

                f_1538_48188_48251(moduleInfo, psSession);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1538, 48064, 48263);

                int
                f_1538_48188_48251(System.Management.Automation.PSModuleInfo
                moduleInfo, System.Management.Automation.Runspaces.PSSession
                weaklyTypedSession)
                {
                    AssociatePSModuleInfoWithSession(moduleInfo, (object)weaklyTypedSession);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 48188, 48251);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1538, 48064, 48263);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1538, 48064, 48263);
            }
        }

        private static void AssociatePSModuleInfoWithSession(PSModuleInfo moduleInfo, object weaklyTypedSession)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1538, 48275, 48473);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 48404, 48462);

                f_1538_48404_48461(s_moduleInfoToSession, moduleInfo, weaklyTypedSession);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1538, 48275, 48473);

                int
                f_1538_48404_48461(System.Runtime.CompilerServices.ConditionalWeakTable<System.Management.Automation.PSModuleInfo, object>
                this_param, System.Management.Automation.PSModuleInfo
                key, object
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 48404, 48461);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1538, 48275, 48473);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1538, 48275, 48473);
            }
        }

        private static readonly ConditionalWeakTable<PSModuleInfo, object> s_moduleInfoToSession;

        internal static void DispatchModuleInfoProcessing(
                    PSModuleInfo moduleInfo,
                    Action localAction,
                    Action<CimSession, Uri, string> cimSessionAction,
                    Action<PSSession> psSessionAction)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1538, 48637, 49722);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 48894, 48919);

                object
                weaklyTypeSession
                = default(object);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 48933, 49094) || true) && (!f_1538_48938_49006(s_moduleInfoToSession, moduleInfo, out weaklyTypeSession))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 48933, 49094);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 49040, 49054);

                    f_1538_49040_49053(localAction);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 49072, 49079);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 48933, 49094);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 49110, 49210);

                Tuple<CimSession, Uri, string>
                cimSessionInfo = weaklyTypeSession as Tuple<CimSession, Uri, string>
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 49224, 49407) || true) && (cimSessionInfo != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 49224, 49407);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 49284, 49367);

                    f_1538_49284_49366(cimSessionAction, f_1538_49301_49321(cimSessionInfo), f_1538_49323_49343(cimSessionInfo), f_1538_49345_49365(cimSessionInfo));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 49385, 49392);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 49224, 49407);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 49423, 49476);

                PSSession
                psSession = weaklyTypeSession as PSSession
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 49490, 49612) || true) && (psSession != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1538, 49490, 49612);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 49545, 49572);

                    f_1538_49545_49571(psSessionAction, psSession);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 49590, 49597);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1538, 49490, 49612);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 49628, 49711);

                f_1538_49628_49710(false, "PSModuleInfo was associated with an unrecognized session type");
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1538, 48637, 49722);

                bool
                f_1538_48938_49006(System.Runtime.CompilerServices.ConditionalWeakTable<System.Management.Automation.PSModuleInfo, object>
                this_param, System.Management.Automation.PSModuleInfo
                key, out object
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 48938, 49006);
                    return return_v;
                }


                int
                f_1538_49040_49053(System.Action
                this_param)
                {
                    this_param.Invoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 49040, 49053);
                    return 0;
                }


                Microsoft.Management.Infrastructure.CimSession
                f_1538_49301_49321(System.Tuple<Microsoft.Management.Infrastructure.CimSession, System.Uri, string>
                this_param)
                {
                    var return_v = this_param.Item1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 49301, 49321);
                    return return_v;
                }


                System.Uri
                f_1538_49323_49343(System.Tuple<Microsoft.Management.Infrastructure.CimSession, System.Uri, string>
                this_param)
                {
                    var return_v = this_param.Item2;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 49323, 49343);
                    return return_v;
                }


                string
                f_1538_49345_49365(System.Tuple<Microsoft.Management.Infrastructure.CimSession, System.Uri, string>
                this_param)
                {
                    var return_v = this_param.Item3;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1538, 49345, 49365);
                    return return_v;
                }


                int
                f_1538_49284_49366(System.Action<Microsoft.Management.Infrastructure.CimSession, System.Uri, string>
                this_param, Microsoft.Management.Infrastructure.CimSession
                arg1, System.Uri
                arg2, string
                arg3)
                {
                    this_param.Invoke(arg1, arg2, arg3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 49284, 49366);
                    return 0;
                }


                int
                f_1538_49545_49571(System.Action<System.Management.Automation.Runspaces.PSSession>
                this_param, System.Management.Automation.Runspaces.PSSession
                obj)
                {
                    this_param.Invoke(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 49545, 49571);
                    return 0;
                }


                int
                f_1538_49628_49710(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 49628, 49710);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1538, 48637, 49722);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1538, 48637, 49722);
            }
        }

        public RemoteDiscoveryHelper()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1538, 812, 49751);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1538, 812, 49751);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1538, 812, 49751);
        }


        static RemoteDiscoveryHelper()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1538, 812, 49751);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 8158, 8193);
            s_blockingCollectionCapacity = 1000;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 16964, 17026);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 25097, 25163);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 25195, 25237);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 25269, 25313);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 25345, 25404);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 38378, 38614);
            s_manifestEntriesToKeepAsString = new[] {
            "GUID",
            "Author",
            "CompanyName",
            "Copyright",
            "ModuleVersion",
            "Description",
            "HelpInfoURI",
        };
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 38658, 38847);
            s_manifestEntriesToKeepAsStringArray = new[] {
            "FunctionsToExport",
            "VariablesToExport",
            "AliasesToExport",
            "CmdletsToExport",
        };
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1538, 48552, 48624);
            s_moduleInfoToSession = f_1538_48576_48624();
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1538, 812, 49751);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1538, 812, 49751);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1538, 812, 49751);

        static System.Runtime.CompilerServices.ConditionalWeakTable<System.Management.Automation.PSModuleInfo, object>
        f_1538_48576_48624()
        {
            var return_v = new System.Runtime.CompilerServices.ConditionalWeakTable<System.Management.Automation.PSModuleInfo, object>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1538, 48576, 48624);
            return return_v;
        }

    }
}
