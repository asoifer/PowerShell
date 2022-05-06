// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Management.Automation.Language;
using System.Reflection;

namespace System.Management.Automation.Runspaces
{
    public sealed partial class TypeTable
    {
        private void Process_GetEvent_Types_Ps1Xml(string filePath, ConcurrentBag<string> errors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1368, 358, 7812);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1368, 472, 523);

                f_1368_472_522(typesInfo, f_1368_486_521(filePath));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1368, 539, 562);

                string
                typeName = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1368, 576, 640);

                PSMemberInfoInternalCollection<PSMemberInfo>
                typeMembers = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1368, 654, 723);

                PSMemberInfoInternalCollection<PSMemberInfo>
                memberSetMembers = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1368, 737, 820);

                HashSet<string>
                newMembers = f_1368_766_819(f_1368_786_818())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1368, 916, 987);

                typeName = @"System.Diagnostics.Eventing.Reader.EventLogConfiguration";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1368, 1001, 1100);

                typeMembers = f_1368_1015_1099(_extendedMembers, typeName, f_1368_1051_1098(capacity: 1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1368, 1158, 1239);

                memberSetMembers = f_1368_1177_1238(capacity: 1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1368, 1253, 1576);

                f_1368_1253_1575(errors, typeName, f_1368_1333_1503(@"DefaultDisplayPropertySet", new List<string> { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => "LogName", 1368, 1424, 1502), "MaximumSizeInBytes", "RecordCount", "LogMode" }), memberSetMembers, isOverride: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1368, 1592, 1769);

                f_1368_1592_1768(errors, typeName, memberSetMembers, typeMembers, isOverride: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1368, 1941, 2005);

                typeName = @"System.Diagnostics.Eventing.Reader.EventLogRecord";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1368, 2019, 2118);

                typeMembers = f_1368_2033_2117(_extendedMembers, typeName, f_1368_2069_2116(capacity: 1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1368, 2176, 2257);

                memberSetMembers = f_1368_2195_2256(capacity: 1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1368, 2271, 2583);

                f_1368_2271_2582(errors, typeName, f_1368_2351_2510(@"DefaultDisplayPropertySet", new List<string> { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => "TimeCreated", 1368, 2442, 2509), "ProviderName", "Id", "Message" }), memberSetMembers, isOverride: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1368, 2599, 2776);

                f_1368_2599_2775(errors, typeName, memberSetMembers, typeMembers, isOverride: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1368, 2943, 3009);

                typeName = @"System.Diagnostics.Eventing.Reader.ProviderMetadata";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1368, 3023, 3122);

                typeMembers = f_1368_3037_3121(_extendedMembers, typeName, f_1368_3073_3120(capacity: 2));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1368, 3179, 3211);

                f_1368_3179_3210(
                            // Process regular members.
                            newMembers, @"ProviderName");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1368, 3225, 3440);

                f_1368_3225_3439(errors, typeName, f_1368_3305_3372(@"ProviderName", @"Name", conversionType: null), typeMembers, isOverride: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1368, 3498, 3579);

                memberSetMembers = f_1368_3517_3578(capacity: 1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1368, 3593, 3877);

                f_1368_3593_3876(errors, typeName, f_1368_3673_3804(@"DefaultDisplayPropertySet", new List<string> { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => "Name", 1368, 3764, 3803), "LogLinks" }), memberSetMembers, isOverride: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1368, 3893, 4070);

                f_1368_3893_4069(errors, typeName, memberSetMembers, typeMembers, isOverride: false);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1368, 7661, 7801);
                    foreach (string memberName in f_1368_7691_7701_I(newMembers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1368, 7661, 7801);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1368, 7735, 7786);

                        f_1368_7735_7785(memberName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1368, 7661, 7801);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1368, 1, 141);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1368, 1, 141);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1368, 358, 7812);

                System.Management.Automation.Runspaces.SessionStateTypeEntry
                f_1368_486_521(string
                fileName)
                {
                    var return_v = new System.Management.Automation.Runspaces.SessionStateTypeEntry(fileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1368, 486, 521);
                    return return_v;
                }


                int
                f_1368_472_522(System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateTypeEntry>
                this_param, System.Management.Automation.Runspaces.SessionStateTypeEntry
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1368, 472, 522);
                    return 0;
                }


                System.StringComparer
                f_1368_786_818()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1368, 786, 818);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_1368_766_819(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.HashSet<string>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1368, 766, 819);
                    return return_v;
                }


                System.Func<string, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                f_1368_1051_1098(int
                capacity)
                {
                    var return_v = GetValueFactoryBasedOnInitCapacity(capacity: capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1368, 1051, 1098);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1368_1015_1099(System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                this_param, string
                key, System.Func<string, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                valueFactory)
                {
                    var return_v = this_param.GetOrAdd(key, valueFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1368, 1015, 1099);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1368_1177_1238(int
                capacity)
                {
                    var return_v = new System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>(capacity: capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1368, 1177, 1238);
                    return return_v;
                }


                System.Management.Automation.PSPropertySet
                f_1368_1333_1503(string
                name, System.Collections.Generic.List<string>
                referencedPropertyNameList)
                {
                    var return_v = new System.Management.Automation.PSPropertySet(name, referencedPropertyNameList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1368, 1333, 1503);
                    return return_v;
                }


                int
                f_1368_1253_1575(System.Collections.Concurrent.ConcurrentBag<string>
                errors, string
                typeName, System.Management.Automation.PSPropertySet
                member, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                membersCollection, bool
                isOverride)
                {
                    AddMember(errors, typeName, (System.Management.Automation.PSMemberInfo)member, membersCollection, isOverride: isOverride);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1368, 1253, 1575);
                    return 0;
                }


                int
                f_1368_1592_1768(System.Collections.Concurrent.ConcurrentBag<string>
                errors, string
                typeName, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                memberSetMembers, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                typeMemberCollection, bool
                isOverride)
                {
                    ProcessStandardMembers(errors, typeName, memberSetMembers, typeMemberCollection, isOverride: isOverride);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1368, 1592, 1768);
                    return 0;
                }


                System.Func<string, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                f_1368_2069_2116(int
                capacity)
                {
                    var return_v = GetValueFactoryBasedOnInitCapacity(capacity: capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1368, 2069, 2116);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1368_2033_2117(System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                this_param, string
                key, System.Func<string, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                valueFactory)
                {
                    var return_v = this_param.GetOrAdd(key, valueFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1368, 2033, 2117);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1368_2195_2256(int
                capacity)
                {
                    var return_v = new System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>(capacity: capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1368, 2195, 2256);
                    return return_v;
                }


                System.Management.Automation.PSPropertySet
                f_1368_2351_2510(string
                name, System.Collections.Generic.List<string>
                referencedPropertyNameList)
                {
                    var return_v = new System.Management.Automation.PSPropertySet(name, referencedPropertyNameList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1368, 2351, 2510);
                    return return_v;
                }


                int
                f_1368_2271_2582(System.Collections.Concurrent.ConcurrentBag<string>
                errors, string
                typeName, System.Management.Automation.PSPropertySet
                member, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                membersCollection, bool
                isOverride)
                {
                    AddMember(errors, typeName, (System.Management.Automation.PSMemberInfo)member, membersCollection, isOverride: isOverride);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1368, 2271, 2582);
                    return 0;
                }


                int
                f_1368_2599_2775(System.Collections.Concurrent.ConcurrentBag<string>
                errors, string
                typeName, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                memberSetMembers, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                typeMemberCollection, bool
                isOverride)
                {
                    ProcessStandardMembers(errors, typeName, memberSetMembers, typeMemberCollection, isOverride: isOverride);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1368, 2599, 2775);
                    return 0;
                }


                System.Func<string, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                f_1368_3073_3120(int
                capacity)
                {
                    var return_v = GetValueFactoryBasedOnInitCapacity(capacity: capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1368, 3073, 3120);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1368_3037_3121(System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                this_param, string
                key, System.Func<string, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                valueFactory)
                {
                    var return_v = this_param.GetOrAdd(key, valueFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1368, 3037, 3121);
                    return return_v;
                }


                bool
                f_1368_3179_3210(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1368, 3179, 3210);
                    return return_v;
                }


                System.Management.Automation.PSAliasProperty
                f_1368_3305_3372(string
                name, string
                referencedMemberName, System.Type
                conversionType)
                {
                    var return_v = new System.Management.Automation.PSAliasProperty(name, referencedMemberName, conversionType: conversionType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1368, 3305, 3372);
                    return return_v;
                }


                int
                f_1368_3225_3439(System.Collections.Concurrent.ConcurrentBag<string>
                errors, string
                typeName, System.Management.Automation.PSAliasProperty
                member, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                membersCollection, bool
                isOverride)
                {
                    AddMember(errors, typeName, (System.Management.Automation.PSMemberInfo)member, membersCollection, isOverride: isOverride);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1368, 3225, 3439);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1368_3517_3578(int
                capacity)
                {
                    var return_v = new System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>(capacity: capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1368, 3517, 3578);
                    return return_v;
                }


                System.Management.Automation.PSPropertySet
                f_1368_3673_3804(string
                name, System.Collections.Generic.List<string>
                referencedPropertyNameList)
                {
                    var return_v = new System.Management.Automation.PSPropertySet(name, referencedPropertyNameList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1368, 3673, 3804);
                    return return_v;
                }


                int
                f_1368_3593_3876(System.Collections.Concurrent.ConcurrentBag<string>
                errors, string
                typeName, System.Management.Automation.PSPropertySet
                member, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                membersCollection, bool
                isOverride)
                {
                    AddMember(errors, typeName, (System.Management.Automation.PSMemberInfo)member, membersCollection, isOverride: isOverride);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1368, 3593, 3876);
                    return 0;
                }


                int
                f_1368_3893_4069(System.Collections.Concurrent.ConcurrentBag<string>
                errors, string
                typeName, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                memberSetMembers, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                typeMemberCollection, bool
                isOverride)
                {
                    ProcessStandardMembers(errors, typeName, memberSetMembers, typeMemberCollection, isOverride: isOverride);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1368, 3893, 4069);
                    return 0;
                }


                int
                f_1368_7735_7785(string
                memberName)
                {
                    PSGetMemberBinder.TypeTableMemberAdded(memberName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1368, 7735, 7785);
                    return 0;
                }


                System.Collections.Generic.HashSet<string>
                f_1368_7691_7701_I(System.Collections.Generic.HashSet<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1368, 7691, 7701);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1368, 358, 7812);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1368, 358, 7812);
            }
        }
    }
}
