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
        private void Process_TypesV3_Ps1Xml(string filePath, ConcurrentBag<string> errors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1369, 358, 17600);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 465, 516);

                f_1369_465_515(typesInfo, f_1369_479_514(filePath));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 532, 555);

                string
                typeName = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 569, 633);

                PSMemberInfoInternalCollection<PSMemberInfo>
                typeMembers = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 647, 716);

                PSMemberInfoInternalCollection<PSMemberInfo>
                memberSetMembers = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 730, 813);

                HashSet<string>
                newMembers = f_1369_759_812(f_1369_779_811())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 915, 992);

                typeName = @"System.Security.Cryptography.X509Certificates.X509Certificate2";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 1006, 1105);

                typeMembers = f_1369_1020_1104(_extendedMembers, typeName, f_1369_1056_1103(capacity: 3));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 1162, 1202);

                f_1369_1162_1201(
                            // Process regular members.
                            newMembers, @"EnhancedKeyUsageList");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 1216, 1672);

                f_1369_1216_1671(errors, typeName, f_1369_1296_1604(@"EnhancedKeyUsageList", f_1369_1385_1514(@",(new-object Microsoft.Powershell.Commands.EnhancedKeyUsageProperty -argumentlist $this).EnhancedKeyUsageList;"), setterScript: null, shouldCloneOnAccess: true), typeMembers, isOverride: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 1688, 1719);

                f_1369_1688_1718(
                            newMembers, @"DnsNameList");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 1733, 2162);

                f_1369_1733_2161(errors, typeName, f_1369_1813_2094(@"DnsNameList", f_1369_1893_2004(@",(new-object Microsoft.Powershell.Commands.DnsNameProperty -argumentlist $this).DnsNameList;"), setterScript: null, shouldCloneOnAccess: true), typeMembers, isOverride: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 2178, 2217);

                f_1369_2178_2216(
                            newMembers, @"SendAsTrustedIssuer");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 2231, 2863);

                f_1369_2231_2862(errors, typeName, f_1369_2311_2795(@"SendAsTrustedIssuer", f_1369_2399_2517(@"[Microsoft.Powershell.Commands.SendAsTrustedIssuerProperty]::ReadSendAsTrustedIssuerProperty($this)"), f_1369_2540_2746(@"$sendAsTrustedIssuer = $args[0]
                    [Microsoft.Powershell.Commands.SendAsTrustedIssuerProperty]::WriteSendAsTrustedIssuerProperty($this,$this.PsPath,$sendAsTrustedIssuer)"), shouldCloneOnAccess: true), typeMembers, isOverride: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 3042, 3107);

                typeName = @"System.Management.Automation.Remoting.PSSenderInfo";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 3121, 3220);

                typeMembers = f_1369_3135_3219(_extendedMembers, typeName, f_1369_3171_3218(capacity: 2));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 3277, 3310);

                f_1369_3277_3309(
                            // Process regular members.
                            newMembers, @"ConnectedUser");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 3324, 3691);

                f_1369_3324_3690(errors, typeName, f_1369_3404_3623(@"ConnectedUser", f_1369_3486_3533(@"$this.UserInfo.Identity.Name"), setterScript: null, shouldCloneOnAccess: true), typeMembers, isOverride: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 3707, 3736);

                f_1369_3707_3735(
                            newMembers, @"RunAsUser");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 3750, 4212);

                f_1369_3750_4211(errors, typeName, f_1369_3830_4144(@"RunAsUser", f_1369_3908_4054(@"if($null -ne $this.UserInfo.WindowsIdentity)
            {
                $this.UserInfo.WindowsIdentity.Name
            }"), setterScript: null, shouldCloneOnAccess: true), typeMembers, isOverride: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 4374, 4434);

                typeName = @"System.Management.Automation.CompletionResult";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 4448, 4547);

                typeMembers = f_1369_4462_4546(_extendedMembers, typeName, f_1369_4498_4545(capacity: 1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 4605, 4686);

                memberSetMembers = f_1369_4624_4685(capacity: 1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 4700, 4897);

                f_1369_4700_4896(errors, typeName, f_1369_4780_4824(@"SerializationDepth", 1), memberSetMembers, isOverride: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 4913, 5090);

                f_1369_4913_5089(errors, typeName, memberSetMembers, typeMembers, isOverride: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 5260, 5333);

                typeName = @"Deserialized.System.Management.Automation.CompletionResult";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 5347, 5446);

                typeMembers = f_1369_5361_5445(_extendedMembers, typeName, f_1369_5397_5444(capacity: 1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 5504, 5585);

                memberSetMembers = f_1369_5523_5584(capacity: 1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 5599, 5860);

                f_1369_5599_5859(errors, typeName, f_1369_5679_5787(@"TargetTypeForDeserialization", typeof(Microsoft.PowerShell.DeserializingTypeConverter)), memberSetMembers, isOverride: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 5876, 6053);

                f_1369_5876_6052(errors, typeName, memberSetMembers, typeMembers, isOverride: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 6224, 6285);

                typeName = @"System.Management.Automation.CommandCompletion";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 6299, 6398);

                typeMembers = f_1369_6313_6397(_extendedMembers, typeName, f_1369_6349_6396(capacity: 1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 6456, 6537);

                memberSetMembers = f_1369_6475_6536(capacity: 1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 6551, 6748);

                f_1369_6551_6747(errors, typeName, f_1369_6631_6675(@"SerializationDepth", 1), memberSetMembers, isOverride: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 6764, 6941);

                f_1369_6764_6940(errors, typeName, memberSetMembers, typeMembers, isOverride: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 7113, 7187);

                typeName = @"Deserialized.System.Management.Automation.CommandCompletion";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 7201, 7300);

                typeMembers = f_1369_7215_7299(_extendedMembers, typeName, f_1369_7251_7298(capacity: 1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 7358, 7439);

                memberSetMembers = f_1369_7377_7438(capacity: 1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 7453, 7714);

                f_1369_7453_7713(errors, typeName, f_1369_7533_7641(@"TargetTypeForDeserialization", typeof(Microsoft.PowerShell.DeserializingTypeConverter)), memberSetMembers, isOverride: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 7730, 7907);

                f_1369_7730_7906(errors, typeName, memberSetMembers, typeMembers, isOverride: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 8082, 8146);

                typeName = @"Microsoft.PowerShell.Commands.ModuleSpecification";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 8160, 8259);

                typeMembers = f_1369_8174_8258(_extendedMembers, typeName, f_1369_8210_8257(capacity: 1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 8317, 8398);

                memberSetMembers = f_1369_8336_8397(capacity: 1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 8412, 8609);

                f_1369_8412_8608(errors, typeName, f_1369_8492_8536(@"SerializationDepth", 1), memberSetMembers, isOverride: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 8625, 8802);

                f_1369_8625_8801(errors, typeName, memberSetMembers, typeMembers, isOverride: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 8980, 9057);

                typeName = @"Deserialized.Microsoft.PowerShell.Commands.ModuleSpecification";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 9071, 9170);

                typeMembers = f_1369_9085_9169(_extendedMembers, typeName, f_1369_9121_9168(capacity: 1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 9228, 9309);

                memberSetMembers = f_1369_9247_9308(capacity: 1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 9323, 9584);

                f_1369_9323_9583(errors, typeName, f_1369_9403_9511(@"TargetTypeForDeserialization", typeof(Microsoft.PowerShell.DeserializingTypeConverter)), memberSetMembers, isOverride: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 9600, 9777);

                f_1369_9600_9776(errors, typeName, memberSetMembers, typeMembers, isOverride: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 9952, 10013);

                typeName = @"System.Management.Automation.JobStateEventArgs";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 10027, 10126);

                typeMembers = f_1369_10041_10125(_extendedMembers, typeName, f_1369_10077_10124(capacity: 1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 10184, 10265);

                memberSetMembers = f_1369_10203_10264(capacity: 1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 10279, 10476);

                f_1369_10279_10475(errors, typeName, f_1369_10359_10403(@"SerializationDepth", 2), memberSetMembers, isOverride: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 10492, 10669);

                f_1369_10492_10668(errors, typeName, memberSetMembers, typeMembers, isOverride: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 10841, 10915);

                typeName = @"Deserialized.System.Management.Automation.JobStateEventArgs";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 10929, 11028);

                typeMembers = f_1369_10943_11027(_extendedMembers, typeName, f_1369_10979_11026(capacity: 1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 11086, 11167);

                memberSetMembers = f_1369_11105_11166(capacity: 1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 11181, 11442);

                f_1369_11181_11441(errors, typeName, f_1369_11261_11369(@"TargetTypeForDeserialization", typeof(Microsoft.PowerShell.DeserializingTypeConverter)), memberSetMembers, isOverride: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 11458, 11635);

                f_1369_11458_11634(errors, typeName, memberSetMembers, typeMembers, isOverride: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 11777, 11808);

                typeName = @"System.Exception";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 11822, 11921);

                typeMembers = f_1369_11836_11920(_extendedMembers, typeName, f_1369_11872_11919(capacity: 1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 11979, 12060);

                memberSetMembers = f_1369_11998_12059(capacity: 1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 12074, 12271);

                f_1369_12074_12270(errors, typeName, f_1369_12154_12198(@"SerializationDepth", 1), memberSetMembers, isOverride: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 12287, 12464);

                f_1369_12287_12463(errors, typeName, memberSetMembers, typeMembers, isOverride: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 12600, 12668);

                typeName = @"System.Management.Automation.Remoting.PSSessionOption";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 12682, 12781);

                typeMembers = f_1369_12696_12780(_extendedMembers, typeName, f_1369_12732_12779(capacity: 1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 12839, 12920);

                memberSetMembers = f_1369_12858_12919(capacity: 1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 12934, 13131);

                f_1369_12934_13130(errors, typeName, f_1369_13014_13058(@"SerializationDepth", 1), memberSetMembers, isOverride: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 13147, 13324);

                f_1369_13147_13323(errors, typeName, memberSetMembers, typeMembers, isOverride: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 13510, 13591);

                typeName = @"Deserialized.System.Management.Automation.Remoting.PSSessionOption";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 13605, 13704);

                typeMembers = f_1369_13619_13703(_extendedMembers, typeName, f_1369_13655_13702(capacity: 1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 13762, 13843);

                memberSetMembers = f_1369_13781_13842(capacity: 1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 13857, 14118);

                f_1369_13857_14117(errors, typeName, f_1369_13937_14045(@"TargetTypeForDeserialization", typeof(Microsoft.PowerShell.DeserializingTypeConverter)), memberSetMembers, isOverride: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 14134, 14311);

                f_1369_14134_14310(errors, typeName, memberSetMembers, typeMembers, isOverride: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 14494, 14559);

                typeName = @"System.Management.Automation.DebuggerStopEventArgs";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 14573, 14672);

                typeMembers = f_1369_14587_14671(_extendedMembers, typeName, f_1369_14623_14670(capacity: 2));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 14729, 14773);

                f_1369_14729_14772(
                            // Process regular members.
                            newMembers, @"SerializedInvocationInfo");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 14787, 15187);

                f_1369_14787_15186(errors, typeName, new PSCodeProperty(
                                    @"SerializedInvocationInfo",
                f_1369_14958_15050(typeof(Microsoft.PowerShell.DeserializingTypeConverter), @"GetInvocationInfo"),
                                    setterCodeReference: null)
                { IsHidden = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 1369, 14867, 15119) }, typeMembers, isOverride: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 15245, 15326);

                memberSetMembers = f_1369_15264_15325(capacity: 3);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 15340, 15558);

                f_1369_15340_15557(errors, typeName, f_1369_15420_15485(@"SerializationMethod", @"SpecificProperties"), memberSetMembers, isOverride: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 15574, 15771);

                f_1369_15574_15770(errors, typeName, f_1369_15654_15698(@"SerializationDepth", 2), memberSetMembers, isOverride: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 15787, 16109);

                f_1369_15787_16108(errors, typeName, f_1369_15867_16036(@"PropertySerializationSet", new List<string> { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => "Breakpoints", 1369, 15957, 16035), "ResumeAction", "SerializedInvocationInfo" }), memberSetMembers, isOverride: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 16125, 16302);

                f_1369_16125_16301(errors, typeName, memberSetMembers, typeMembers, isOverride: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 16482, 16560);

                typeName = @"Deserialized.System.Management.Automation.DebuggerStopEventArgs";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 16574, 16673);

                typeMembers = f_1369_16588_16672(_extendedMembers, typeName, f_1369_16624_16671(capacity: 1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 16731, 16812);

                memberSetMembers = f_1369_16750_16811(capacity: 1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 16826, 17087);

                f_1369_16826_17086(errors, typeName, f_1369_16906_17014(@"TargetTypeForDeserialization", typeof(Microsoft.PowerShell.DeserializingTypeConverter)), memberSetMembers, isOverride: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 17103, 17280);

                f_1369_17103_17279(errors, typeName, memberSetMembers, typeMembers, isOverride: false);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 17449, 17589);
                    foreach (string memberName in f_1369_17479_17489_I(newMembers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1369, 17449, 17589);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1369, 17523, 17574);

                        f_1369_17523_17573(memberName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1369, 17449, 17589);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1369, 1, 141);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1369, 1, 141);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1369, 358, 17600);

                System.Management.Automation.Runspaces.SessionStateTypeEntry
                f_1369_479_514(string
                fileName)
                {
                    var return_v = new System.Management.Automation.Runspaces.SessionStateTypeEntry(fileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 479, 514);
                    return return_v;
                }


                int
                f_1369_465_515(System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateTypeEntry>
                this_param, System.Management.Automation.Runspaces.SessionStateTypeEntry
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 465, 515);
                    return 0;
                }


                System.StringComparer
                f_1369_779_811()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1369, 779, 811);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_1369_759_812(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.HashSet<string>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 759, 812);
                    return return_v;
                }


                System.Func<string, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                f_1369_1056_1103(int
                capacity)
                {
                    var return_v = GetValueFactoryBasedOnInitCapacity(capacity: capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 1056, 1103);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1369_1020_1104(System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                this_param, string
                key, System.Func<string, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                valueFactory)
                {
                    var return_v = this_param.GetOrAdd(key, valueFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 1020, 1104);
                    return return_v;
                }


                bool
                f_1369_1162_1201(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 1162, 1201);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1369_1385_1514(string
                s)
                {
                    var return_v = GetScriptBlock(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 1385, 1514);
                    return return_v;
                }


                System.Management.Automation.PSScriptProperty
                f_1369_1296_1604(string
                name, System.Management.Automation.ScriptBlock
                getterScript, System.Management.Automation.ScriptBlock
                setterScript, bool
                shouldCloneOnAccess)
                {
                    var return_v = new System.Management.Automation.PSScriptProperty(name, getterScript, setterScript: setterScript, shouldCloneOnAccess: shouldCloneOnAccess);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 1296, 1604);
                    return return_v;
                }


                int
                f_1369_1216_1671(System.Collections.Concurrent.ConcurrentBag<string>
                errors, string
                typeName, System.Management.Automation.PSScriptProperty
                member, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                membersCollection, bool
                isOverride)
                {
                    AddMember(errors, typeName, (System.Management.Automation.PSMemberInfo)member, membersCollection, isOverride: isOverride);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 1216, 1671);
                    return 0;
                }


                bool
                f_1369_1688_1718(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 1688, 1718);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1369_1893_2004(string
                s)
                {
                    var return_v = GetScriptBlock(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 1893, 2004);
                    return return_v;
                }


                System.Management.Automation.PSScriptProperty
                f_1369_1813_2094(string
                name, System.Management.Automation.ScriptBlock
                getterScript, System.Management.Automation.ScriptBlock
                setterScript, bool
                shouldCloneOnAccess)
                {
                    var return_v = new System.Management.Automation.PSScriptProperty(name, getterScript, setterScript: setterScript, shouldCloneOnAccess: shouldCloneOnAccess);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 1813, 2094);
                    return return_v;
                }


                int
                f_1369_1733_2161(System.Collections.Concurrent.ConcurrentBag<string>
                errors, string
                typeName, System.Management.Automation.PSScriptProperty
                member, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                membersCollection, bool
                isOverride)
                {
                    AddMember(errors, typeName, (System.Management.Automation.PSMemberInfo)member, membersCollection, isOverride: isOverride);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 1733, 2161);
                    return 0;
                }


                bool
                f_1369_2178_2216(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 2178, 2216);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1369_2399_2517(string
                s)
                {
                    var return_v = GetScriptBlock(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 2399, 2517);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1369_2540_2746(string
                s)
                {
                    var return_v = GetScriptBlock(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 2540, 2746);
                    return return_v;
                }


                System.Management.Automation.PSScriptProperty
                f_1369_2311_2795(string
                name, System.Management.Automation.ScriptBlock
                getterScript, System.Management.Automation.ScriptBlock
                setterScript, bool
                shouldCloneOnAccess)
                {
                    var return_v = new System.Management.Automation.PSScriptProperty(name, getterScript, setterScript, shouldCloneOnAccess: shouldCloneOnAccess);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 2311, 2795);
                    return return_v;
                }


                int
                f_1369_2231_2862(System.Collections.Concurrent.ConcurrentBag<string>
                errors, string
                typeName, System.Management.Automation.PSScriptProperty
                member, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                membersCollection, bool
                isOverride)
                {
                    AddMember(errors, typeName, (System.Management.Automation.PSMemberInfo)member, membersCollection, isOverride: isOverride);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 2231, 2862);
                    return 0;
                }


                System.Func<string, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                f_1369_3171_3218(int
                capacity)
                {
                    var return_v = GetValueFactoryBasedOnInitCapacity(capacity: capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 3171, 3218);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1369_3135_3219(System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                this_param, string
                key, System.Func<string, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                valueFactory)
                {
                    var return_v = this_param.GetOrAdd(key, valueFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 3135, 3219);
                    return return_v;
                }


                bool
                f_1369_3277_3309(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 3277, 3309);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1369_3486_3533(string
                s)
                {
                    var return_v = GetScriptBlock(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 3486, 3533);
                    return return_v;
                }


                System.Management.Automation.PSScriptProperty
                f_1369_3404_3623(string
                name, System.Management.Automation.ScriptBlock
                getterScript, System.Management.Automation.ScriptBlock
                setterScript, bool
                shouldCloneOnAccess)
                {
                    var return_v = new System.Management.Automation.PSScriptProperty(name, getterScript, setterScript: setterScript, shouldCloneOnAccess: shouldCloneOnAccess);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 3404, 3623);
                    return return_v;
                }


                int
                f_1369_3324_3690(System.Collections.Concurrent.ConcurrentBag<string>
                errors, string
                typeName, System.Management.Automation.PSScriptProperty
                member, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                membersCollection, bool
                isOverride)
                {
                    AddMember(errors, typeName, (System.Management.Automation.PSMemberInfo)member, membersCollection, isOverride: isOverride);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 3324, 3690);
                    return 0;
                }


                bool
                f_1369_3707_3735(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 3707, 3735);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1369_3908_4054(string
                s)
                {
                    var return_v = GetScriptBlock(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 3908, 4054);
                    return return_v;
                }


                System.Management.Automation.PSScriptProperty
                f_1369_3830_4144(string
                name, System.Management.Automation.ScriptBlock
                getterScript, System.Management.Automation.ScriptBlock
                setterScript, bool
                shouldCloneOnAccess)
                {
                    var return_v = new System.Management.Automation.PSScriptProperty(name, getterScript, setterScript: setterScript, shouldCloneOnAccess: shouldCloneOnAccess);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 3830, 4144);
                    return return_v;
                }


                int
                f_1369_3750_4211(System.Collections.Concurrent.ConcurrentBag<string>
                errors, string
                typeName, System.Management.Automation.PSScriptProperty
                member, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                membersCollection, bool
                isOverride)
                {
                    AddMember(errors, typeName, (System.Management.Automation.PSMemberInfo)member, membersCollection, isOverride: isOverride);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 3750, 4211);
                    return 0;
                }


                System.Func<string, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                f_1369_4498_4545(int
                capacity)
                {
                    var return_v = GetValueFactoryBasedOnInitCapacity(capacity: capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 4498, 4545);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1369_4462_4546(System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                this_param, string
                key, System.Func<string, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                valueFactory)
                {
                    var return_v = this_param.GetOrAdd(key, valueFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 4462, 4546);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1369_4624_4685(int
                capacity)
                {
                    var return_v = new System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>(capacity: capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 4624, 4685);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1369_4780_4824(string
                name, int
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 4780, 4824);
                    return return_v;
                }


                int
                f_1369_4700_4896(System.Collections.Concurrent.ConcurrentBag<string>
                errors, string
                typeName, System.Management.Automation.PSNoteProperty
                member, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                membersCollection, bool
                isOverride)
                {
                    AddMember(errors, typeName, (System.Management.Automation.PSMemberInfo)member, membersCollection, isOverride: isOverride);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 4700, 4896);
                    return 0;
                }


                int
                f_1369_4913_5089(System.Collections.Concurrent.ConcurrentBag<string>
                errors, string
                typeName, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                memberSetMembers, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                typeMemberCollection, bool
                isOverride)
                {
                    ProcessStandardMembers(errors, typeName, memberSetMembers, typeMemberCollection, isOverride: isOverride);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 4913, 5089);
                    return 0;
                }


                System.Func<string, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                f_1369_5397_5444(int
                capacity)
                {
                    var return_v = GetValueFactoryBasedOnInitCapacity(capacity: capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 5397, 5444);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1369_5361_5445(System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                this_param, string
                key, System.Func<string, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                valueFactory)
                {
                    var return_v = this_param.GetOrAdd(key, valueFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 5361, 5445);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1369_5523_5584(int
                capacity)
                {
                    var return_v = new System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>(capacity: capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 5523, 5584);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1369_5679_5787(string
                name, System.Type
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 5679, 5787);
                    return return_v;
                }


                int
                f_1369_5599_5859(System.Collections.Concurrent.ConcurrentBag<string>
                errors, string
                typeName, System.Management.Automation.PSNoteProperty
                member, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                membersCollection, bool
                isOverride)
                {
                    AddMember(errors, typeName, (System.Management.Automation.PSMemberInfo)member, membersCollection, isOverride: isOverride);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 5599, 5859);
                    return 0;
                }


                int
                f_1369_5876_6052(System.Collections.Concurrent.ConcurrentBag<string>
                errors, string
                typeName, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                memberSetMembers, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                typeMemberCollection, bool
                isOverride)
                {
                    ProcessStandardMembers(errors, typeName, memberSetMembers, typeMemberCollection, isOverride: isOverride);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 5876, 6052);
                    return 0;
                }


                System.Func<string, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                f_1369_6349_6396(int
                capacity)
                {
                    var return_v = GetValueFactoryBasedOnInitCapacity(capacity: capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 6349, 6396);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1369_6313_6397(System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                this_param, string
                key, System.Func<string, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                valueFactory)
                {
                    var return_v = this_param.GetOrAdd(key, valueFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 6313, 6397);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1369_6475_6536(int
                capacity)
                {
                    var return_v = new System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>(capacity: capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 6475, 6536);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1369_6631_6675(string
                name, int
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 6631, 6675);
                    return return_v;
                }


                int
                f_1369_6551_6747(System.Collections.Concurrent.ConcurrentBag<string>
                errors, string
                typeName, System.Management.Automation.PSNoteProperty
                member, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                membersCollection, bool
                isOverride)
                {
                    AddMember(errors, typeName, (System.Management.Automation.PSMemberInfo)member, membersCollection, isOverride: isOverride);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 6551, 6747);
                    return 0;
                }


                int
                f_1369_6764_6940(System.Collections.Concurrent.ConcurrentBag<string>
                errors, string
                typeName, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                memberSetMembers, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                typeMemberCollection, bool
                isOverride)
                {
                    ProcessStandardMembers(errors, typeName, memberSetMembers, typeMemberCollection, isOverride: isOverride);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 6764, 6940);
                    return 0;
                }


                System.Func<string, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                f_1369_7251_7298(int
                capacity)
                {
                    var return_v = GetValueFactoryBasedOnInitCapacity(capacity: capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 7251, 7298);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1369_7215_7299(System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                this_param, string
                key, System.Func<string, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                valueFactory)
                {
                    var return_v = this_param.GetOrAdd(key, valueFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 7215, 7299);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1369_7377_7438(int
                capacity)
                {
                    var return_v = new System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>(capacity: capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 7377, 7438);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1369_7533_7641(string
                name, System.Type
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 7533, 7641);
                    return return_v;
                }


                int
                f_1369_7453_7713(System.Collections.Concurrent.ConcurrentBag<string>
                errors, string
                typeName, System.Management.Automation.PSNoteProperty
                member, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                membersCollection, bool
                isOverride)
                {
                    AddMember(errors, typeName, (System.Management.Automation.PSMemberInfo)member, membersCollection, isOverride: isOverride);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 7453, 7713);
                    return 0;
                }


                int
                f_1369_7730_7906(System.Collections.Concurrent.ConcurrentBag<string>
                errors, string
                typeName, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                memberSetMembers, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                typeMemberCollection, bool
                isOverride)
                {
                    ProcessStandardMembers(errors, typeName, memberSetMembers, typeMemberCollection, isOverride: isOverride);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 7730, 7906);
                    return 0;
                }


                System.Func<string, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                f_1369_8210_8257(int
                capacity)
                {
                    var return_v = GetValueFactoryBasedOnInitCapacity(capacity: capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 8210, 8257);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1369_8174_8258(System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                this_param, string
                key, System.Func<string, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                valueFactory)
                {
                    var return_v = this_param.GetOrAdd(key, valueFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 8174, 8258);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1369_8336_8397(int
                capacity)
                {
                    var return_v = new System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>(capacity: capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 8336, 8397);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1369_8492_8536(string
                name, int
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 8492, 8536);
                    return return_v;
                }


                int
                f_1369_8412_8608(System.Collections.Concurrent.ConcurrentBag<string>
                errors, string
                typeName, System.Management.Automation.PSNoteProperty
                member, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                membersCollection, bool
                isOverride)
                {
                    AddMember(errors, typeName, (System.Management.Automation.PSMemberInfo)member, membersCollection, isOverride: isOverride);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 8412, 8608);
                    return 0;
                }


                int
                f_1369_8625_8801(System.Collections.Concurrent.ConcurrentBag<string>
                errors, string
                typeName, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                memberSetMembers, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                typeMemberCollection, bool
                isOverride)
                {
                    ProcessStandardMembers(errors, typeName, memberSetMembers, typeMemberCollection, isOverride: isOverride);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 8625, 8801);
                    return 0;
                }


                System.Func<string, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                f_1369_9121_9168(int
                capacity)
                {
                    var return_v = GetValueFactoryBasedOnInitCapacity(capacity: capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 9121, 9168);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1369_9085_9169(System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                this_param, string
                key, System.Func<string, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                valueFactory)
                {
                    var return_v = this_param.GetOrAdd(key, valueFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 9085, 9169);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1369_9247_9308(int
                capacity)
                {
                    var return_v = new System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>(capacity: capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 9247, 9308);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1369_9403_9511(string
                name, System.Type
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 9403, 9511);
                    return return_v;
                }


                int
                f_1369_9323_9583(System.Collections.Concurrent.ConcurrentBag<string>
                errors, string
                typeName, System.Management.Automation.PSNoteProperty
                member, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                membersCollection, bool
                isOverride)
                {
                    AddMember(errors, typeName, (System.Management.Automation.PSMemberInfo)member, membersCollection, isOverride: isOverride);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 9323, 9583);
                    return 0;
                }


                int
                f_1369_9600_9776(System.Collections.Concurrent.ConcurrentBag<string>
                errors, string
                typeName, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                memberSetMembers, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                typeMemberCollection, bool
                isOverride)
                {
                    ProcessStandardMembers(errors, typeName, memberSetMembers, typeMemberCollection, isOverride: isOverride);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 9600, 9776);
                    return 0;
                }


                System.Func<string, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                f_1369_10077_10124(int
                capacity)
                {
                    var return_v = GetValueFactoryBasedOnInitCapacity(capacity: capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 10077, 10124);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1369_10041_10125(System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                this_param, string
                key, System.Func<string, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                valueFactory)
                {
                    var return_v = this_param.GetOrAdd(key, valueFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 10041, 10125);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1369_10203_10264(int
                capacity)
                {
                    var return_v = new System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>(capacity: capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 10203, 10264);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1369_10359_10403(string
                name, int
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 10359, 10403);
                    return return_v;
                }


                int
                f_1369_10279_10475(System.Collections.Concurrent.ConcurrentBag<string>
                errors, string
                typeName, System.Management.Automation.PSNoteProperty
                member, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                membersCollection, bool
                isOverride)
                {
                    AddMember(errors, typeName, (System.Management.Automation.PSMemberInfo)member, membersCollection, isOverride: isOverride);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 10279, 10475);
                    return 0;
                }


                int
                f_1369_10492_10668(System.Collections.Concurrent.ConcurrentBag<string>
                errors, string
                typeName, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                memberSetMembers, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                typeMemberCollection, bool
                isOverride)
                {
                    ProcessStandardMembers(errors, typeName, memberSetMembers, typeMemberCollection, isOverride: isOverride);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 10492, 10668);
                    return 0;
                }


                System.Func<string, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                f_1369_10979_11026(int
                capacity)
                {
                    var return_v = GetValueFactoryBasedOnInitCapacity(capacity: capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 10979, 11026);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1369_10943_11027(System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                this_param, string
                key, System.Func<string, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                valueFactory)
                {
                    var return_v = this_param.GetOrAdd(key, valueFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 10943, 11027);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1369_11105_11166(int
                capacity)
                {
                    var return_v = new System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>(capacity: capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 11105, 11166);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1369_11261_11369(string
                name, System.Type
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 11261, 11369);
                    return return_v;
                }


                int
                f_1369_11181_11441(System.Collections.Concurrent.ConcurrentBag<string>
                errors, string
                typeName, System.Management.Automation.PSNoteProperty
                member, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                membersCollection, bool
                isOverride)
                {
                    AddMember(errors, typeName, (System.Management.Automation.PSMemberInfo)member, membersCollection, isOverride: isOverride);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 11181, 11441);
                    return 0;
                }


                int
                f_1369_11458_11634(System.Collections.Concurrent.ConcurrentBag<string>
                errors, string
                typeName, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                memberSetMembers, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                typeMemberCollection, bool
                isOverride)
                {
                    ProcessStandardMembers(errors, typeName, memberSetMembers, typeMemberCollection, isOverride: isOverride);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 11458, 11634);
                    return 0;
                }


                System.Func<string, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                f_1369_11872_11919(int
                capacity)
                {
                    var return_v = GetValueFactoryBasedOnInitCapacity(capacity: capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 11872, 11919);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1369_11836_11920(System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                this_param, string
                key, System.Func<string, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                valueFactory)
                {
                    var return_v = this_param.GetOrAdd(key, valueFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 11836, 11920);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1369_11998_12059(int
                capacity)
                {
                    var return_v = new System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>(capacity: capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 11998, 12059);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1369_12154_12198(string
                name, int
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 12154, 12198);
                    return return_v;
                }


                int
                f_1369_12074_12270(System.Collections.Concurrent.ConcurrentBag<string>
                errors, string
                typeName, System.Management.Automation.PSNoteProperty
                member, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                membersCollection, bool
                isOverride)
                {
                    AddMember(errors, typeName, (System.Management.Automation.PSMemberInfo)member, membersCollection, isOverride: isOverride);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 12074, 12270);
                    return 0;
                }


                int
                f_1369_12287_12463(System.Collections.Concurrent.ConcurrentBag<string>
                errors, string
                typeName, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                memberSetMembers, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                typeMemberCollection, bool
                isOverride)
                {
                    ProcessStandardMembers(errors, typeName, memberSetMembers, typeMemberCollection, isOverride: isOverride);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 12287, 12463);
                    return 0;
                }


                System.Func<string, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                f_1369_12732_12779(int
                capacity)
                {
                    var return_v = GetValueFactoryBasedOnInitCapacity(capacity: capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 12732, 12779);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1369_12696_12780(System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                this_param, string
                key, System.Func<string, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                valueFactory)
                {
                    var return_v = this_param.GetOrAdd(key, valueFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 12696, 12780);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1369_12858_12919(int
                capacity)
                {
                    var return_v = new System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>(capacity: capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 12858, 12919);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1369_13014_13058(string
                name, int
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 13014, 13058);
                    return return_v;
                }


                int
                f_1369_12934_13130(System.Collections.Concurrent.ConcurrentBag<string>
                errors, string
                typeName, System.Management.Automation.PSNoteProperty
                member, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                membersCollection, bool
                isOverride)
                {
                    AddMember(errors, typeName, (System.Management.Automation.PSMemberInfo)member, membersCollection, isOverride: isOverride);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 12934, 13130);
                    return 0;
                }


                int
                f_1369_13147_13323(System.Collections.Concurrent.ConcurrentBag<string>
                errors, string
                typeName, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                memberSetMembers, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                typeMemberCollection, bool
                isOverride)
                {
                    ProcessStandardMembers(errors, typeName, memberSetMembers, typeMemberCollection, isOverride: isOverride);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 13147, 13323);
                    return 0;
                }


                System.Func<string, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                f_1369_13655_13702(int
                capacity)
                {
                    var return_v = GetValueFactoryBasedOnInitCapacity(capacity: capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 13655, 13702);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1369_13619_13703(System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                this_param, string
                key, System.Func<string, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                valueFactory)
                {
                    var return_v = this_param.GetOrAdd(key, valueFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 13619, 13703);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1369_13781_13842(int
                capacity)
                {
                    var return_v = new System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>(capacity: capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 13781, 13842);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1369_13937_14045(string
                name, System.Type
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 13937, 14045);
                    return return_v;
                }


                int
                f_1369_13857_14117(System.Collections.Concurrent.ConcurrentBag<string>
                errors, string
                typeName, System.Management.Automation.PSNoteProperty
                member, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                membersCollection, bool
                isOverride)
                {
                    AddMember(errors, typeName, (System.Management.Automation.PSMemberInfo)member, membersCollection, isOverride: isOverride);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 13857, 14117);
                    return 0;
                }


                int
                f_1369_14134_14310(System.Collections.Concurrent.ConcurrentBag<string>
                errors, string
                typeName, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                memberSetMembers, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                typeMemberCollection, bool
                isOverride)
                {
                    ProcessStandardMembers(errors, typeName, memberSetMembers, typeMemberCollection, isOverride: isOverride);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 14134, 14310);
                    return 0;
                }


                System.Func<string, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                f_1369_14623_14670(int
                capacity)
                {
                    var return_v = GetValueFactoryBasedOnInitCapacity(capacity: capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 14623, 14670);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1369_14587_14671(System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                this_param, string
                key, System.Func<string, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                valueFactory)
                {
                    var return_v = this_param.GetOrAdd(key, valueFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 14587, 14671);
                    return return_v;
                }


                bool
                f_1369_14729_14772(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 14729, 14772);
                    return return_v;
                }


                System.Reflection.MethodInfo
                f_1369_14958_15050(System.Type
                type, string
                method)
                {
                    var return_v = GetMethodInfo(type, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 14958, 15050);
                    return return_v;
                }


                int
                f_1369_14787_15186(System.Collections.Concurrent.ConcurrentBag<string>
                errors, string
                typeName, System.Management.Automation.PSCodeProperty
                member, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                membersCollection, bool
                isOverride)
                {
                    AddMember(errors, typeName, (System.Management.Automation.PSMemberInfo)member, membersCollection, isOverride: isOverride);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 14787, 15186);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1369_15264_15325(int
                capacity)
                {
                    var return_v = new System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>(capacity: capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 15264, 15325);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1369_15420_15485(string
                name, string
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 15420, 15485);
                    return return_v;
                }


                int
                f_1369_15340_15557(System.Collections.Concurrent.ConcurrentBag<string>
                errors, string
                typeName, System.Management.Automation.PSNoteProperty
                member, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                membersCollection, bool
                isOverride)
                {
                    AddMember(errors, typeName, (System.Management.Automation.PSMemberInfo)member, membersCollection, isOverride: isOverride);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 15340, 15557);
                    return 0;
                }


                System.Management.Automation.PSNoteProperty
                f_1369_15654_15698(string
                name, int
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 15654, 15698);
                    return return_v;
                }


                int
                f_1369_15574_15770(System.Collections.Concurrent.ConcurrentBag<string>
                errors, string
                typeName, System.Management.Automation.PSNoteProperty
                member, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                membersCollection, bool
                isOverride)
                {
                    AddMember(errors, typeName, (System.Management.Automation.PSMemberInfo)member, membersCollection, isOverride: isOverride);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 15574, 15770);
                    return 0;
                }


                System.Management.Automation.PSPropertySet
                f_1369_15867_16036(string
                name, System.Collections.Generic.List<string>
                referencedPropertyNameList)
                {
                    var return_v = new System.Management.Automation.PSPropertySet(name, referencedPropertyNameList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 15867, 16036);
                    return return_v;
                }


                int
                f_1369_15787_16108(System.Collections.Concurrent.ConcurrentBag<string>
                errors, string
                typeName, System.Management.Automation.PSPropertySet
                member, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                membersCollection, bool
                isOverride)
                {
                    AddMember(errors, typeName, (System.Management.Automation.PSMemberInfo)member, membersCollection, isOverride: isOverride);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 15787, 16108);
                    return 0;
                }


                int
                f_1369_16125_16301(System.Collections.Concurrent.ConcurrentBag<string>
                errors, string
                typeName, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                memberSetMembers, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                typeMemberCollection, bool
                isOverride)
                {
                    ProcessStandardMembers(errors, typeName, memberSetMembers, typeMemberCollection, isOverride: isOverride);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 16125, 16301);
                    return 0;
                }


                System.Func<string, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                f_1369_16624_16671(int
                capacity)
                {
                    var return_v = GetValueFactoryBasedOnInitCapacity(capacity: capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 16624, 16671);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1369_16588_16672(System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                this_param, string
                key, System.Func<string, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                valueFactory)
                {
                    var return_v = this_param.GetOrAdd(key, valueFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 16588, 16672);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1369_16750_16811(int
                capacity)
                {
                    var return_v = new System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>(capacity: capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 16750, 16811);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1369_16906_17014(string
                name, System.Type
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 16906, 17014);
                    return return_v;
                }


                int
                f_1369_16826_17086(System.Collections.Concurrent.ConcurrentBag<string>
                errors, string
                typeName, System.Management.Automation.PSNoteProperty
                member, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                membersCollection, bool
                isOverride)
                {
                    AddMember(errors, typeName, (System.Management.Automation.PSMemberInfo)member, membersCollection, isOverride: isOverride);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 16826, 17086);
                    return 0;
                }


                int
                f_1369_17103_17279(System.Collections.Concurrent.ConcurrentBag<string>
                errors, string
                typeName, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                memberSetMembers, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                typeMemberCollection, bool
                isOverride)
                {
                    ProcessStandardMembers(errors, typeName, memberSetMembers, typeMemberCollection, isOverride: isOverride);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 17103, 17279);
                    return 0;
                }


                int
                f_1369_17523_17573(string
                memberName)
                {
                    PSGetMemberBinder.TypeTableMemberAdded(memberName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 17523, 17573);
                    return 0;
                }


                System.Collections.Generic.HashSet<string>
                f_1369_17479_17489_I(System.Collections.Generic.HashSet<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1369, 17479, 17489);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1369, 358, 17600);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1369, 358, 17600);
            }
        }
    }
}
