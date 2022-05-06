// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Management.Automation.Host;
using System.Management.Automation.Internal;
using System.Management.Automation.Language;
using System.Management.Automation.Runspaces;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;

using Microsoft.PowerShell.Commands;
using Microsoft.PowerShell.Commands.Internal.Format;

namespace System.Management.Automation
{
    internal enum SuggestionMatchType
    {
        /// <summary>Match on a command.</summary>
        Command = 0,
        /// <summary>Match based on exception message.</summary>
        Error = 1,
        /// <summary>Match by running a script block.</summary>
        Dynamic = 2,

        /// <summary>Match by fully qualified ErrorId.</summary>
        ErrorId = 3
    }
    public static class HostUtilities
    {
        private static string s_checkForCommandInCurrentDirectoryScript;

        private static string s_createCommandExistsInCurrentDirectoryScript;

        private static string s_getFuzzyMatchedCommands;

        private static List<Hashtable> s_suggestions;

        private static List<Hashtable> InitializeSuggestions()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1461, 2704, 5035);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 2783, 4285);

                var
                suggestions = f_1461_2801_4284(new Hashtable[]
                                {
f_1461_2895_3234(id: 1, category: "Transactions", matchType: SuggestionMatchType.Command, rule: "^Start-Transaction", suggestion: f_1461_3148_3193(), enabled: true),
f_1461_3257_3592(id: 2, category: "Transactions", matchType: SuggestionMatchType.Command, rule: "^Use-Transaction", suggestion: f_1461_3508_3551(), enabled: true),
f_1461_3615_4264(id: 3, category: "General", matchType: SuggestionMatchType.Dynamic, rule: f_1461_3804_3908(s_checkForCommandInCurrentDirectoryScript, isProductCode: true), suggestion: f_1461_3947_4055(s_createCommandExistsInCurrentDirectoryScript, isProductCode: true), suggestionArgs: new object[] { f_1461_4113_4221(f_1461_4160_4220())}, enabled: true)                })
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 4301, 4989) || true) && (f_1461_4305_4365("PSCommandNotFoundSuggestion"))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1461, 4301, 4989);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 4399, 4974);

                    f_1461_4399_4973(suggestions, f_1461_4437_4972(id: 4, category: "General", matchType: SuggestionMatchType.ErrorId, rule: "CommandNotFoundException", suggestion: f_1461_4691_4779(s_getFuzzyMatchedCommands, isProductCode: true), suggestionArgs: new object[] { f_1461_4837_4929(f_1461_4884_4928()) }, enabled: true));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1461, 4301, 4989);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 5005, 5024);

                return suggestions;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1461, 2704, 5035);

                string
                f_1461_3148_3193()
                {
                    var return_v = SuggestionStrings.Suggestion_StartTransaction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 3148, 3193);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1461_2895_3234(int
                id, string
                category, System.Management.Automation.SuggestionMatchType
                matchType, string
                rule, string
                suggestion, bool
                enabled)
                {
                    var return_v = NewSuggestion(id: id, category: category, matchType: matchType, rule: rule, suggestion: suggestion, enabled: enabled);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 2895, 3234);
                    return return_v;
                }


                string
                f_1461_3508_3551()
                {
                    var return_v = SuggestionStrings.Suggestion_UseTransaction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 3508, 3551);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1461_3257_3592(int
                id, string
                category, System.Management.Automation.SuggestionMatchType
                matchType, string
                rule, string
                suggestion, bool
                enabled)
                {
                    var return_v = NewSuggestion(id: id, category: category, matchType: matchType, rule: rule, suggestion: suggestion, enabled: enabled);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 3257, 3592);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1461_3804_3908(string
                script, bool
                isProductCode)
                {
                    var return_v = ScriptBlock.CreateDelayParsedScriptBlock(script, isProductCode: isProductCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 3804, 3908);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1461_3947_4055(string
                script, bool
                isProductCode)
                {
                    var return_v = ScriptBlock.CreateDelayParsedScriptBlock(script, isProductCode: isProductCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 3947, 4055);
                    return return_v;
                }


                string
                f_1461_4160_4220()
                {
                    var return_v = SuggestionStrings.Suggestion_CommandExistsInCurrentDirectory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 4160, 4220);
                    return return_v;
                }


                string
                f_1461_4113_4221(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 4113, 4221);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1461_3615_4264(int
                id, string
                category, System.Management.Automation.SuggestionMatchType
                matchType, System.Management.Automation.ScriptBlock
                rule, System.Management.Automation.ScriptBlock
                suggestion, object[]
                suggestionArgs, bool
                enabled)
                {
                    var return_v = NewSuggestion(id: id, category: category, matchType: matchType, rule: rule, suggestion: suggestion, suggestionArgs: suggestionArgs, enabled: enabled);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 3615, 4264);
                    return return_v;
                }


                System.Collections.Generic.List<System.Collections.Hashtable>
                f_1461_2801_4284(System.Collections.Hashtable[]
                collection)
                {
                    var return_v = new System.Collections.Generic.List<System.Collections.Hashtable>((System.Collections.Generic.IEnumerable<System.Collections.Hashtable>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 2801, 4284);
                    return return_v;
                }


                bool
                f_1461_4305_4365(string
                featureName)
                {
                    var return_v = ExperimentalFeature.IsEnabled(featureName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 4305, 4365);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1461_4691_4779(string
                script, bool
                isProductCode)
                {
                    var return_v = ScriptBlock.CreateDelayParsedScriptBlock(script, isProductCode: isProductCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 4691, 4779);
                    return return_v;
                }


                string
                f_1461_4884_4928()
                {
                    var return_v = SuggestionStrings.Suggestion_CommandNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 4884, 4928);
                    return return_v;
                }


                string
                f_1461_4837_4929(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 4837, 4929);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1461_4437_4972(int
                id, string
                category, System.Management.Automation.SuggestionMatchType
                matchType, string
                rule, System.Management.Automation.ScriptBlock
                suggestion, object[]
                suggestionArgs, bool
                enabled)
                {
                    var return_v = NewSuggestion(id: id, category: category, matchType: matchType, rule: rule, suggestion: suggestion, suggestionArgs: suggestionArgs, enabled: enabled);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 4437, 4972);
                    return return_v;
                }


                int
                f_1461_4399_4973(System.Collections.Generic.List<System.Collections.Hashtable>
                this_param, System.Collections.Hashtable
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 4399, 4973);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1461, 2704, 5035);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1461, 2704, 5035);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static PSObject GetDollarProfile(string allUsersAllHosts, string allUsersCurrentHost, string currentUserAllHosts, string currentUserCurrentHost)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1461, 5807, 6509);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 5985, 6045);

                PSObject
                returnValue = f_1461_6008_6044(currentUserCurrentHost)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 6059, 6144);

                f_1461_6059_6143(f_1461_6059_6081(returnValue), f_1461_6086_6142("AllUsersAllHosts", allUsersAllHosts));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 6158, 6249);

                f_1461_6158_6248(f_1461_6158_6180(returnValue), f_1461_6185_6247("AllUsersCurrentHost", allUsersCurrentHost));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 6263, 6354);

                f_1461_6263_6353(f_1461_6263_6285(returnValue), f_1461_6290_6352("CurrentUserAllHosts", currentUserAllHosts));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 6368, 6465);

                f_1461_6368_6464(f_1461_6368_6390(returnValue), f_1461_6395_6463("CurrentUserCurrentHost", currentUserCurrentHost));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 6479, 6498);

                return returnValue;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1461, 5807, 6509);

                System.Management.Automation.PSObject
                f_1461_6008_6044(string
                obj)
                {
                    var return_v = new System.Management.Automation.PSObject((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 6008, 6044);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1461_6059_6081(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 6059, 6081);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1461_6086_6142(string
                name, string
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 6086, 6142);
                    return return_v;
                }


                int
                f_1461_6059_6143(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 6059, 6143);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1461_6158_6180(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 6158, 6180);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1461_6185_6247(string
                name, string
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 6185, 6247);
                    return return_v;
                }


                int
                f_1461_6158_6248(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 6158, 6248);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1461_6263_6285(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 6263, 6285);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1461_6290_6352(string
                name, string
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 6290, 6352);
                    return return_v;
                }


                int
                f_1461_6263_6353(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 6263, 6353);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1461_6368_6390(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 6368, 6390);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1461_6395_6463(string
                name, string
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 6395, 6463);
                    return return_v;
                }


                int
                f_1461_6368_6464(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 6368, 6464);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1461, 5807, 6509);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1461, 5807, 6509);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static PSCommand[] GetProfileCommands(string shellId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1461, 6823, 6977);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 6910, 6966);

                return f_1461_6917_6965(shellId, false);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1461, 6823, 6977);

                System.Management.Automation.PSCommand[]
                f_1461_6917_6965(string
                shellId, bool
                useTestProfile)
                {
                    var return_v = HostUtilities.GetProfileCommands(shellId, useTestProfile);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 6917, 6965);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1461, 6823, 6977);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1461, 6823, 6977);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void GetProfileObjectData(string shellId, bool useTestProfile, out string allUsersAllHosts, out string allUsersCurrentHost, out string currentUserAllHosts, out string currentUserCurrentHost, out PSObject dollarProfile)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1461, 7851, 8664);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 8110, 8195);

                allUsersAllHosts = f_1461_8129_8194(null, false, useTestProfile);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 8209, 8300);

                allUsersCurrentHost = f_1461_8231_8299(shellId, false, useTestProfile);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 8314, 8401);

                currentUserAllHosts = f_1461_8336_8400(null, true, useTestProfile);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 8415, 8508);

                currentUserCurrentHost = f_1461_8440_8507(shellId, true, useTestProfile);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 8522, 8653);

                dollarProfile = f_1461_8538_8652(allUsersAllHosts, allUsersCurrentHost, currentUserAllHosts, currentUserCurrentHost);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1461, 7851, 8664);

                string
                f_1461_8129_8194(string
                shellId, bool
                forCurrentUser, bool
                useTestProfile)
                {
                    var return_v = HostUtilities.GetFullProfileFileName(shellId, forCurrentUser, useTestProfile);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 8129, 8194);
                    return return_v;
                }


                string
                f_1461_8231_8299(string
                shellId, bool
                forCurrentUser, bool
                useTestProfile)
                {
                    var return_v = HostUtilities.GetFullProfileFileName(shellId, forCurrentUser, useTestProfile);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 8231, 8299);
                    return return_v;
                }


                string
                f_1461_8336_8400(string
                shellId, bool
                forCurrentUser, bool
                useTestProfile)
                {
                    var return_v = HostUtilities.GetFullProfileFileName(shellId, forCurrentUser, useTestProfile);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 8336, 8400);
                    return return_v;
                }


                string
                f_1461_8440_8507(string
                shellId, bool
                forCurrentUser, bool
                useTestProfile)
                {
                    var return_v = HostUtilities.GetFullProfileFileName(shellId, forCurrentUser, useTestProfile);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 8440, 8507);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1461_8538_8652(string
                allUsersAllHosts, string
                allUsersCurrentHost, string
                currentUserAllHosts, string
                currentUserCurrentHost)
                {
                    var return_v = HostUtilities.GetDollarProfile(allUsersAllHosts, allUsersCurrentHost, currentUserAllHosts, currentUserCurrentHost);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 8538, 8652);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1461, 7851, 8664);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1461, 7851, 8664);
            }
        }

        internal static PSCommand[] GetProfileCommands(string shellId, bool useTestProfile)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1461, 9107, 10468);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 9215, 9264);

                List<PSCommand>
                commands = f_1461_9242_9263()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 9278, 9368);

                string
                allUsersAllHosts
                = default(string),
                allUsersCurrentHost
                = default(string),
                currentUserAllHosts
                = default(string),
                currentUserCurrentHost
                = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 9382, 9405);

                PSObject
                dollarProfile
                = default(PSObject);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 9419, 9598);

                f_1461_9419_9597(shellId, useTestProfile, out allUsersAllHosts, out allUsersCurrentHost, out currentUserAllHosts, out currentUserCurrentHost, out dollarProfile);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 9614, 9650);

                PSCommand
                command = f_1461_9634_9649()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 9664, 9699);

                f_1461_9664_9698(command, "set-variable");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 9713, 9753);

                f_1461_9713_9752(command, "Name", "profile");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 9767, 9812);

                f_1461_9767_9811(command, "Value", dollarProfile);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 9826, 9881);

                f_1461_9826_9880(command, "Option", ScopedItemOptions.None);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 9895, 9917);

                f_1461_9895_9916(commands, command);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 9933, 10057);

                string[]
                profilePaths = new string[] { allUsersAllHosts, allUsersCurrentHost, currentUserAllHosts, currentUserCurrentHost }
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 10071, 10415);
                    foreach (string profilePath in f_1461_10102_10114_I(profilePaths))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1461, 10071, 10415);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 10148, 10257) || true) && (!f_1461_10153_10187(profilePath))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1461, 10148, 10257);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 10229, 10238);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1461, 10148, 10257);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 10277, 10303);

                        command = f_1461_10287_10302();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 10321, 10360);

                        f_1461_10321_10359(command, profilePath, false);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 10378, 10400);

                        f_1461_10378_10399(commands, command);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1461, 10071, 10415);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1461, 1, 345);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1461, 1, 345);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 10431, 10457);

                return f_1461_10438_10456(commands);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1461, 9107, 10468);

                System.Collections.Generic.List<System.Management.Automation.PSCommand>
                f_1461_9242_9263()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.PSCommand>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 9242, 9263);
                    return return_v;
                }


                int
                f_1461_9419_9597(string
                shellId, bool
                useTestProfile, out string
                allUsersAllHosts, out string
                allUsersCurrentHost, out string
                currentUserAllHosts, out string
                currentUserCurrentHost, out System.Management.Automation.PSObject
                dollarProfile)
                {
                    HostUtilities.GetProfileObjectData(shellId, useTestProfile, out allUsersAllHosts, out allUsersCurrentHost, out currentUserAllHosts, out currentUserCurrentHost, out dollarProfile);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 9419, 9597);
                    return 0;
                }


                System.Management.Automation.PSCommand
                f_1461_9634_9649()
                {
                    var return_v = new System.Management.Automation.PSCommand();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 9634, 9649);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1461_9664_9698(System.Management.Automation.PSCommand
                this_param, string
                command)
                {
                    var return_v = this_param.AddCommand(command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 9664, 9698);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1461_9713_9752(System.Management.Automation.PSCommand
                this_param, string
                parameterName, string
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 9713, 9752);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1461_9767_9811(System.Management.Automation.PSCommand
                this_param, string
                parameterName, System.Management.Automation.PSObject
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 9767, 9811);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1461_9826_9880(System.Management.Automation.PSCommand
                this_param, string
                parameterName, System.Management.Automation.ScopedItemOptions
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 9826, 9880);
                    return return_v;
                }


                int
                f_1461_9895_9916(System.Collections.Generic.List<System.Management.Automation.PSCommand>
                this_param, System.Management.Automation.PSCommand
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 9895, 9916);
                    return 0;
                }


                bool
                f_1461_10153_10187(string
                path)
                {
                    var return_v = System.IO.File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 10153, 10187);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1461_10287_10302()
                {
                    var return_v = new System.Management.Automation.PSCommand();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 10287, 10302);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1461_10321_10359(System.Management.Automation.PSCommand
                this_param, string
                cmdlet, bool
                useLocalScope)
                {
                    var return_v = this_param.AddCommand(cmdlet, useLocalScope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 10321, 10359);
                    return return_v;
                }


                int
                f_1461_10378_10399(System.Collections.Generic.List<System.Management.Automation.PSCommand>
                this_param, System.Management.Automation.PSCommand
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 10378, 10399);
                    return 0;
                }


                string[]
                f_1461_10102_10114_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 10102, 10114);
                    return return_v;
                }


                System.Management.Automation.PSCommand[]
                f_1461_10438_10456(System.Collections.Generic.List<System.Management.Automation.PSCommand>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 10438, 10456);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1461, 9107, 10468);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1461, 9107, 10468);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string GetFullProfileFileName(string shellId, bool forCurrentUser)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1461, 10911, 11105);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 11018, 11094);

                return f_1461_11025_11093(shellId, forCurrentUser, false);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1461, 10911, 11105);

                string
                f_1461_11025_11093(string
                shellId, bool
                forCurrentUser, bool
                useTestProfile)
                {
                    var return_v = HostUtilities.GetFullProfileFileName(shellId, forCurrentUser, useTestProfile);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 11025, 11093);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1461, 10911, 11105);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1461, 10911, 11105);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string GetFullProfileFileName(string shellId, bool forCurrentUser, bool useTestProfile)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1461, 11677, 12545);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 11805, 11828);

                string
                basePath = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 11844, 12188) || true) && (forCurrentUser)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1461, 11844, 12188);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 11896, 11932);

                    basePath = Platform.ConfigDirectory;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1461, 11844, 12188);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1461, 11844, 12188);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 11998, 12040);

                    basePath = f_1461_12009_12039(shellId);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 12058, 12173) || true) && (f_1461_12062_12092(basePath))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1461, 12058, 12173);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 12134, 12154);

                        return string.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1461, 12058, 12173);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1461, 11844, 12188);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 12204, 12277);

                string
                profileName = (DynAbs.Tracing.TraceSender.Conditional_F1(1461, 12225, 12239) || ((useTestProfile && DynAbs.Tracing.TraceSender.Conditional_F2(1461, 12242, 12260)) || DynAbs.Tracing.TraceSender.Conditional_F3(1461, 12263, 12276))) ? "profile_test.ps1" : "profile.ps1"
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 12293, 12418) || true) && (!f_1461_12298_12327(shellId))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1461, 12293, 12418);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 12361, 12403);

                    profileName = shellId + "_" + profileName;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1461, 12293, 12418);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 12434, 12502);

                string
                fullPath = basePath = f_1461_12463_12501(basePath, profileName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 12518, 12534);

                return fullPath;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1461, 11677, 12545);

                string
                f_1461_12009_12039(string
                shellId)
                {
                    var return_v = GetAllUsersFolderPath(shellId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 12009, 12039);
                    return return_v;
                }


                bool
                f_1461_12062_12092(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 12062, 12092);
                    return return_v;
                }


                bool
                f_1461_12298_12327(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 12298, 12327);
                    return return_v;
                }


                string
                f_1461_12463_12501(string
                path1, string
                path2)
                {
                    var return_v = IO.Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 12463, 12501);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1461, 11677, 12545);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1461, 11677, 12545);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string GetAllUsersFolderPath(string shellId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1461, 12837, 13196);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 12921, 12954);

                string
                folderPath = string.Empty
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 13004, 13051);

                    folderPath = f_1461_13017_13050(shellId);
                }
                catch (System.Security.SecurityException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1461, 13080, 13151);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1461, 13080, 13151);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 13167, 13185);

                return folderPath;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1461, 12837, 13196);

                string
                f_1461_13017_13050(string
                shellId)
                {
                    var return_v = Utils.GetApplicationBase(shellId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 13017, 13050);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1461, 12837, 13196);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1461, 12837, 13196);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string GetMaxLines(string source, int maxLines)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1461, 13635, 14408);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 13723, 13824) || true) && (f_1461_13727_13755(source))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1461, 13723, 13824);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 13789, 13809);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1461, 13723, 13824);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 13840, 13888);

                StringBuilder
                returnValue = f_1461_13868_13887()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 13913, 13918);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 13920, 13933);

                    for (int
        i = 0
        ,
        lineCount = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 13904, 14351) || true) && (i < f_1461_13939_13952(source))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 13954, 13957)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1461, 13904, 14351))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1461, 13904, 14351);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 13991, 14010);

                        char
                        c = f_1461_14000_14009(source, i)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 14030, 14116) || true) && (c == '\n')
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1461, 14030, 14116);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 14085, 14097);

                            lineCount++;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1461, 14030, 14116);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 14136, 14158);

                        f_1461_14136_14157(
                                        returnValue, c);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 14178, 14336) || true) && (lineCount == maxLines)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1461, 14178, 14336);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 14245, 14289);

                            f_1461_14245_14288(returnValue, PSObjectHelper.Ellipsis);
                            DynAbs.Tracing.TraceSender.TraceBreak(1461, 14311, 14317);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1461, 14178, 14336);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1461, 1, 448);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1461, 1, 448);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 14367, 14397);

                return f_1461_14374_14396(returnValue);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1461, 13635, 14408);

                bool
                f_1461_13727_13755(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 13727, 13755);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1461_13868_13887()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 13868, 13887);
                    return return_v;
                }


                int
                f_1461_13939_13952(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 13939, 13952);
                    return return_v;
                }


                char
                f_1461_14000_14009(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 14000, 14009);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1461_14136_14157(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 14136, 14157);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1461_14245_14288(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 14245, 14288);
                    return return_v;
                }


                string
                f_1461_14374_14396(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 14374, 14396);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1461, 13635, 14408);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1461, 13635, 14408);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static List<string> GetSuggestion(Runspace runspace)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1461, 14420, 17160);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 14506, 14562);

                LocalRunspace
                localRunspace = runspace as LocalRunspace
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 14576, 14633) || true) && (localRunspace == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1461, 14576, 14633);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 14605, 14631);

                    return f_1461_14612_14630();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1461, 14576, 14633);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 14690, 14780);

                bool
                questionMarkVariableValue = f_1461_14723_14779(f_1461_14723_14753(localRunspace))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 14838, 14878);

                History
                history = f_1461_14856_14877(localRunspace)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 14892, 14948);

                HistoryInfo[]
                entries = f_1461_14916_14947(history, -1, 1, true)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 14964, 15032) || true) && (f_1461_14968_14982(entries) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1461, 14964, 15032);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 15006, 15032);

                    return f_1461_15013_15031();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1461, 14964, 15032);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 15048, 15085);

                HistoryInfo
                lastHistory = entries[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 15136, 15223);

                ArrayList
                errorList = (ArrayList)f_1461_15169_15222(f_1461_15169_15202(localRunspace))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 15237, 15261);

                object
                lastError = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 15277, 16304) || true) && (f_1461_15281_15296(errorList) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1461, 15277, 16304);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 15334, 15372);

                    lastError = f_1461_15346_15358(errorList, 0) as Exception;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 15390, 15425);

                    ErrorRecord
                    lastErrorRecord = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 15501, 15806) || true) && (lastError == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1461, 15501, 15806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 15564, 15610);

                        lastErrorRecord = f_1461_15582_15594(errorList, 0) as ErrorRecord;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1461, 15501, 15806);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1461, 15501, 15806);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 15652, 15806) || true) && (lastError is RuntimeException)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1461, 15652, 15806);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 15727, 15787);

                            lastErrorRecord = f_1461_15745_15786(((RuntimeException)lastError));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1461, 15652, 15806);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1461, 15501, 15806);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 15969, 16289) || true) && ((lastErrorRecord != null) && (DynAbs.Tracing.TraceSender.Expression_True(1461, 15973, 16042) && (f_1461_16003_16033(lastErrorRecord) != null)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1461, 15969, 16289);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 16084, 16270) || true) && (f_1461_16088_16128(f_1461_16088_16118(lastErrorRecord)) == f_1461_16132_16146(lastHistory))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1461, 16084, 16270);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 16173, 16201);

                            lastError = lastErrorRecord;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1461, 16084, 16270);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1461, 16084, 16270);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 16253, 16270);

                            lastError = null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1461, 16084, 16270);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1461, 15969, 16289);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1461, 15277, 16304);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 16320, 16347);

                Runspace
                oldDefault = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 16361, 16389);

                bool
                changedDefault = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 16403, 16624) || true) && (f_1461_16407_16431() != runspace)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1461, 16403, 16624);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 16477, 16515);

                    oldDefault = f_1461_16490_16514();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 16533, 16555);

                    changedDefault = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 16573, 16609);

                    Runspace.DefaultRunspace = runspace;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1461, 16403, 16624);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 16640, 16672);

                List<string>
                suggestions = null
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 16724, 16787);

                    suggestions = f_1461_16738_16786(lastHistory, lastError, errorList);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1461, 16816, 16988);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 16856, 16973) || true) && (changedDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1461, 16856, 16973);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 16916, 16954);

                        Runspace.DefaultRunspace = oldDefault;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1461, 16856, 16973);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1461, 16816, 16988);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 17031, 17116);

                f_1461_17031_17061(localRunspace).QuestionMarkVariableValue = questionMarkVariableValue;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 17130, 17149);

                return suggestions;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1461, 14420, 17160);

                System.Collections.Generic.List<string>
                f_1461_14612_14630()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 14612, 14630);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1461_14723_14753(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 14723, 14753);
                    return return_v;
                }


                bool
                f_1461_14723_14779(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.QuestionMarkVariableValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 14723, 14779);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.History
                f_1461_14856_14877(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.History;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 14856, 14877);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.HistoryInfo[]
                f_1461_14916_14947(Microsoft.PowerShell.Commands.History
                this_param, int
                id, int
                count, bool
                newest)
                {
                    var return_v = this_param.GetEntries((long)id, (long)count, (System.Management.Automation.SwitchParameter)newest);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 14916, 14947);
                    return return_v;
                }


                int
                f_1461_14968_14982(Microsoft.PowerShell.Commands.HistoryInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 14968, 14982);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1461_15013_15031()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 15013, 15031);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1461_15169_15202(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.GetExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 15169, 15202);
                    return return_v;
                }


                object
                f_1461_15169_15222(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.DollarErrorVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 15169, 15222);
                    return return_v;
                }


                int
                f_1461_15281_15296(System.Collections.ArrayList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 15281, 15296);
                    return return_v;
                }


                object
                f_1461_15346_15358(System.Collections.ArrayList
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 15346, 15358);
                    return return_v;
                }


                object
                f_1461_15582_15594(System.Collections.ArrayList
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 15582, 15594);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1461_15745_15786(System.Management.Automation.RuntimeException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 15745, 15786);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1461_16003_16033(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 16003, 16033);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1461_16088_16118(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 16088, 16118);
                    return return_v;
                }


                long
                f_1461_16088_16128(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.HistoryId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 16088, 16128);
                    return return_v;
                }


                long
                f_1461_16132_16146(Microsoft.PowerShell.Commands.HistoryInfo
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 16132, 16146);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1461_16407_16431()
                {
                    var return_v = Runspace.DefaultRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 16407, 16431);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1461_16490_16514()
                {
                    var return_v = Runspace.DefaultRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 16490, 16514);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1461_16738_16786(Microsoft.PowerShell.Commands.HistoryInfo
                lastHistory, object
                lastError, System.Collections.ArrayList
                errorList)
                {
                    var return_v = GetSuggestion(lastHistory, lastError, errorList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 16738, 16786);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1461_17031_17061(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 17031, 17061);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1461, 14420, 17160);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1461, 14420, 17160);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly")]
        internal static List<string> GetSuggestion(HistoryInfo lastHistory, object lastError, ArrayList errorList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1461, 17172, 23057);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 17398, 17441);

                var
                returnSuggestions = f_1461_17422_17440()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 17457, 17512);

                PSModuleInfo
                invocationModule = f_1461_17489_17511(true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 17526, 17599);

                f_1461_17526_17598(f_1461_17526_17566(f_1461_17526_17555(invocationModule)), "lastHistory", lastHistory);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 17613, 17682);

                f_1461_17613_17681(f_1461_17613_17653(f_1461_17613_17642(invocationModule)), "lastError", lastError);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 17698, 17724);

                int
                initialErrorCount = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 17790, 23005);
                    foreach (Hashtable suggestion in f_1461_17823_17836_I(s_suggestions))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1461, 17790, 23005);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 17870, 17906);

                        initialErrorCount = f_1461_17890_17905(errorList);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 17976, 18061) || true) && (!f_1461_17981_18029(f_1461_18007_18028(suggestion, "Enabled")))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1461, 17976, 18061);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 18052, 18061);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1461, 17976, 18061);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 18081, 18311);

                        SuggestionMatchType
                        matchType = (SuggestionMatchType)f_1461_18134_18310(f_1461_18185_18208(suggestion, "MatchType"), typeof(SuggestionMatchType), f_1461_18281_18309())
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 18404, 22776) || true) && (matchType == SuggestionMatchType.Dynamic)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1461, 18404, 22776);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 18490, 18511);

                            object
                            result = null
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 18535, 18593);

                            ScriptBlock
                            evaluator = f_1461_18559_18577(suggestion, "Rule") as ScriptBlock
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 18615, 18874) || true) && (evaluator == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1461, 18615, 18874);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 18686, 18716);

                                suggestion["Enabled"] = false;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 18744, 18851);

                                throw f_1461_18750_18850(f_1461_18802_18841(), "Rule");
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1461, 18615, 18874);
                            }

                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 18950, 19000);

                                result = f_1461_18959_18999(invocationModule, evaluator, null);
                            }
                            catch (Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1461, 19045, 19273);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 19185, 19215);

                                suggestion["Enabled"] = false;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 19241, 19250);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1461, 19045, 19273);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 19369, 20157) || true) && (f_1461_19373_19406(result))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1461, 19369, 20157);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 19456, 19582);

                                string
                                suggestionText = f_1461_19480_19581(f_1461_19498_19522(suggestion, "Suggestion"), f_1461_19534_19562(suggestion, "SuggestionArgs"), invocationModule)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 19610, 20134) || true) && (!f_1461_19615_19651(suggestionText))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1461, 19610, 20134);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 19709, 20039);

                                    string
                                    returnString = f_1461_19731_20038(f_1461_19779_19805(), "Suggestion [{0},{1}]: {2}", (int)f_1461_19907_19923(suggestion, "Id"), (string)f_1461_19966_19988(suggestion, "Category"), suggestionText)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 20071, 20107);

                                    f_1461_20071_20106(
                                                                returnSuggestions, returnString);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1461, 19610, 20134);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1461, 19369, 20157);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1461, 18404, 22776);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1461, 18404, 22776);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 20239, 20271);

                            string
                            matchText = string.Empty
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 20405, 21832) || true) && (matchType == SuggestionMatchType.Command)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1461, 20405, 21832);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 20499, 20535);

                                matchText = f_1461_20511_20534(lastHistory);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1461, 20405, 21832);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1461, 20405, 21832);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 20585, 21832) || true) && (matchType == SuggestionMatchType.Error)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1461, 20585, 21832);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 20677, 21181) || true) && (lastError != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1461, 20677, 21181);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 20756, 20805);

                                        Exception
                                        lastException = lastError as Exception
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 20835, 21154) || true) && (lastException != null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1461, 20835, 21154);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 20926, 20960);

                                            matchText = f_1461_20938_20959(lastException);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1461, 20835, 21154);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1461, 20835, 21154);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 21090, 21123);

                                            matchText = f_1461_21102_21122(lastError);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1461, 20835, 21154);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1461, 20677, 21181);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1461, 20585, 21832);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1461, 20585, 21832);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 21231, 21832) || true) && (matchType == SuggestionMatchType.ErrorId)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1461, 21231, 21832);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 21325, 21517) || true) && (lastError != null && (DynAbs.Tracing.TraceSender.Expression_True(1461, 21329, 21386) && lastError is ErrorRecord errorRecord))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1461, 21325, 21517);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 21444, 21490);

                                            matchText = f_1461_21456_21489(errorRecord);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1461, 21325, 21517);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1461, 21231, 21832);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1461, 21231, 21832);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 21615, 21645);

                                        suggestion["Enabled"] = false;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 21673, 21809);

                                        throw f_1461_21679_21808(f_1461_21731_21765(), "MatchType");
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1461, 21231, 21832);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1461, 20585, 21832);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1461, 20405, 21832);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 21925, 22757) || true) && (f_1461_21929_22006(matchText, f_1461_21962_21980(suggestion, "Rule"), RegexOptions.IgnoreCase))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1461, 21925, 22757);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 22056, 22182);

                                string
                                suggestionText = f_1461_22080_22181(f_1461_22098_22122(suggestion, "Suggestion"), f_1461_22134_22162(suggestion, "SuggestionArgs"), invocationModule)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 22210, 22734) || true) && (!f_1461_22215_22251(suggestionText))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1461, 22210, 22734);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 22309, 22639);

                                    string
                                    returnString = f_1461_22331_22638(f_1461_22379_22405(), "Suggestion [{0},{1}]: {2}", (int)f_1461_22507_22523(suggestion, "Id"), (string)f_1461_22566_22588(suggestion, "Category"), suggestionText)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 22671, 22707);

                                    f_1461_22671_22706(
                                                                returnSuggestions, returnString);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1461, 22210, 22734);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1461, 21925, 22757);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1461, 18404, 22776);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 22859, 22990) || true) && (f_1461_22863_22878(errorList) != initialErrorCount)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1461, 22859, 22990);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 22941, 22971);

                            suggestion["Enabled"] = false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1461, 22859, 22990);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1461, 17790, 23005);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1461, 1, 5216);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1461, 1, 5216);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 23021, 23046);

                return returnSuggestions;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1461, 17172, 23057);

                System.Collections.Generic.List<string>
                f_1461_17422_17440()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 17422, 17440);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1461_17489_17511(bool
                linkToGlobal)
                {
                    var return_v = new System.Management.Automation.PSModuleInfo(linkToGlobal);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 17489, 17511);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1461_17526_17555(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 17526, 17555);
                    return return_v;
                }


                System.Management.Automation.PSVariableIntrinsics
                f_1461_17526_17566(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.PSVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 17526, 17566);
                    return return_v;
                }


                int
                f_1461_17526_17598(System.Management.Automation.PSVariableIntrinsics
                this_param, string
                name, Microsoft.PowerShell.Commands.HistoryInfo
                value)
                {
                    this_param.Set(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 17526, 17598);
                    return 0;
                }


                System.Management.Automation.SessionState
                f_1461_17613_17642(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 17613, 17642);
                    return return_v;
                }


                System.Management.Automation.PSVariableIntrinsics
                f_1461_17613_17653(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.PSVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 17613, 17653);
                    return return_v;
                }


                int
                f_1461_17613_17681(System.Management.Automation.PSVariableIntrinsics
                this_param, string
                name, object
                value)
                {
                    this_param.Set(name, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 17613, 17681);
                    return 0;
                }


                int
                f_1461_17890_17905(System.Collections.ArrayList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 17890, 17905);
                    return return_v;
                }


                object
                f_1461_18007_18028(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 18007, 18028);
                    return return_v;
                }


                bool
                f_1461_17981_18029(object
                obj)
                {
                    var return_v = LanguagePrimitives.IsTrue(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 17981, 18029);
                    return return_v;
                }


                object
                f_1461_18185_18208(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 18185, 18208);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1461_18281_18309()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 18281, 18309);
                    return return_v;
                }


                object
                f_1461_18134_18310(object
                valueToConvert, System.Type
                resultType, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = LanguagePrimitives.ConvertTo(valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 18134, 18310);
                    return return_v;
                }


                object
                f_1461_18559_18577(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 18559, 18577);
                    return return_v;
                }


                string
                f_1461_18802_18841()
                {
                    var return_v = SuggestionStrings.RuleMustBeScriptBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 18802, 18841);
                    return return_v;
                }


                System.ArgumentException
                f_1461_18750_18850(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 18750, 18850);
                    return return_v;
                }


                object
                f_1461_18959_18999(System.Management.Automation.PSModuleInfo
                this_param, System.Management.Automation.ScriptBlock
                sb, params object[]
                args)
                {
                    var return_v = this_param.Invoke(sb, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 18959, 18999);
                    return return_v;
                }


                bool
                f_1461_19373_19406(object
                obj)
                {
                    var return_v = LanguagePrimitives.IsTrue(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 19373, 19406);
                    return return_v;
                }


                object
                f_1461_19498_19522(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 19498, 19522);
                    return return_v;
                }


                object
                f_1461_19534_19562(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 19534, 19562);
                    return return_v;
                }


                string
                f_1461_19480_19581(object
                suggestion, object
                suggestionArgs, System.Management.Automation.PSModuleInfo
                invocationModule)
                {
                    var return_v = GetSuggestionText(suggestion, (object[])suggestionArgs, invocationModule);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 19480, 19581);
                    return return_v;
                }


                bool
                f_1461_19615_19651(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 19615, 19651);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1461_19779_19805()
                {
                    var return_v = CultureInfo.CurrentCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 19779, 19805);
                    return return_v;
                }


                object
                f_1461_19907_19923(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 19907, 19923);
                    return return_v;
                }


                object
                f_1461_19966_19988(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 19966, 19988);
                    return return_v;
                }


                string
                f_1461_19731_20038(System.Globalization.CultureInfo
                provider, string
                format, int
                arg0, string
                arg1, string
                arg2)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 19731, 20038);
                    return return_v;
                }


                int
                f_1461_20071_20106(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 20071, 20106);
                    return 0;
                }


                string
                f_1461_20511_20534(Microsoft.PowerShell.Commands.HistoryInfo
                this_param)
                {
                    var return_v = this_param.CommandLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 20511, 20534);
                    return return_v;
                }


                string
                f_1461_20938_20959(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 20938, 20959);
                    return return_v;
                }


                string?
                f_1461_21102_21122(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 21102, 21122);
                    return return_v;
                }


                string
                f_1461_21456_21489(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.FullyQualifiedErrorId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 21456, 21489);
                    return return_v;
                }


                string
                f_1461_21731_21765()
                {
                    var return_v = SuggestionStrings.InvalidMatchType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 21731, 21765);
                    return return_v;
                }


                System.ArgumentException
                f_1461_21679_21808(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 21679, 21808);
                    return return_v;
                }


                object
                f_1461_21962_21980(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 21962, 21980);
                    return return_v;
                }


                bool
                f_1461_21929_22006(string
                input, object
                pattern, System.Text.RegularExpressions.RegexOptions
                options)
                {
                    var return_v = Regex.IsMatch(input, (string)pattern, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 21929, 22006);
                    return return_v;
                }


                object
                f_1461_22098_22122(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 22098, 22122);
                    return return_v;
                }


                object
                f_1461_22134_22162(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 22134, 22162);
                    return return_v;
                }


                string
                f_1461_22080_22181(object
                suggestion, object
                suggestionArgs, System.Management.Automation.PSModuleInfo
                invocationModule)
                {
                    var return_v = GetSuggestionText(suggestion, (object[])suggestionArgs, invocationModule);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 22080, 22181);
                    return return_v;
                }


                bool
                f_1461_22215_22251(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 22215, 22251);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1461_22379_22405()
                {
                    var return_v = CultureInfo.CurrentCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 22379, 22405);
                    return return_v;
                }


                object
                f_1461_22507_22523(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 22507, 22523);
                    return return_v;
                }


                object
                f_1461_22566_22588(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 22566, 22588);
                    return return_v;
                }


                string
                f_1461_22331_22638(System.Globalization.CultureInfo
                provider, string
                format, int
                arg0, string
                arg1, string
                arg2)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 22331, 22638);
                    return return_v;
                }


                int
                f_1461_22671_22706(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 22671, 22706);
                    return 0;
                }


                int
                f_1461_22863_22878(System.Collections.ArrayList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 22863, 22878);
                    return return_v;
                }


                System.Collections.Generic.List<System.Collections.Hashtable>
                f_1461_17823_17836_I(System.Collections.Generic.List<System.Collections.Hashtable>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 17823, 17836);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1461, 17172, 23057);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1461, 17172, 23057);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string RemoveGuidFromMessage(string message, out bool matchPattern)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1461, 23333, 24005);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 23441, 23462);

                matchPattern = false;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 23476, 23543) || true) && (f_1461_23480_23509(message))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1461, 23476, 23543);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 23528, 23543);

                    return message;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1461, 23476, 23543);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 23559, 23646);

                const string
                pattern = @"^([\d\w]{8}\-[\d\w]{4}\-[\d\w]{4}\-[\d\w]{4}\-[\d\w]{12}:).*"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 23660, 23710);

                Match
                matchResult = f_1461_23680_23709(message, pattern)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 23724, 23963) || true) && (f_1461_23728_23747(matchResult))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1461, 23724, 23963);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 23781, 23843);

                    string
                    partToRemove = f_1461_23803_23842(f_1461_23803_23836(f_1461_23803_23833(f_1461_23803_23824(f_1461_23803_23821(matchResult), 1)), 0))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 23861, 23910);

                    message = f_1461_23871_23909(message, 0, f_1461_23889_23908(partToRemove));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 23928, 23948);

                    matchPattern = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1461, 23724, 23963);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 23979, 23994);

                return message;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1461, 23333, 24005);

                bool
                f_1461_23480_23509(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 23480, 23509);
                    return return_v;
                }


                System.Text.RegularExpressions.Match
                f_1461_23680_23709(string
                input, string
                pattern)
                {
                    var return_v = Regex.Match(input, pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 23680, 23709);
                    return return_v;
                }


                bool
                f_1461_23728_23747(System.Text.RegularExpressions.Match
                this_param)
                {
                    var return_v = this_param.Success;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 23728, 23747);
                    return return_v;
                }


                System.Text.RegularExpressions.GroupCollection
                f_1461_23803_23821(System.Text.RegularExpressions.Match
                this_param)
                {
                    var return_v = this_param.Groups;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 23803, 23821);
                    return return_v;
                }


                System.Text.RegularExpressions.Group
                f_1461_23803_23824(System.Text.RegularExpressions.GroupCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 23803, 23824);
                    return return_v;
                }


                System.Text.RegularExpressions.CaptureCollection
                f_1461_23803_23833(System.Text.RegularExpressions.Group
                this_param)
                {
                    var return_v = this_param.Captures;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 23803, 23833);
                    return return_v;
                }


                System.Text.RegularExpressions.Capture
                f_1461_23803_23836(System.Text.RegularExpressions.CaptureCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 23803, 23836);
                    return return_v;
                }


                string
                f_1461_23803_23842(System.Text.RegularExpressions.Capture
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 23803, 23842);
                    return return_v;
                }


                int
                f_1461_23889_23908(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 23889, 23908);
                    return return_v;
                }


                string
                f_1461_23871_23909(string
                this_param, int
                startIndex, int
                count)
                {
                    var return_v = this_param.Remove(startIndex, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 23871, 23909);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1461, 23333, 24005);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1461, 23333, 24005);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string RemoveIdentifierInfoFromMessage(string message, out bool matchPattern)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1461, 24017, 24706);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 24135, 24156);

                matchPattern = false;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 24170, 24237) || true) && (f_1461_24174_24203(message))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1461, 24170, 24237);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 24222, 24237);

                    return message;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1461, 24170, 24237);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 24253, 24347);

                const string
                pattern = @"^([\d\w]{8}\-[\d\w]{4}\-[\d\w]{4}\-[\d\w]{4}\-[\d\w]{12}:\[.*\]:).*"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 24361, 24411);

                Match
                matchResult = f_1461_24381_24410(message, pattern)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 24425, 24664) || true) && (f_1461_24429_24448(matchResult))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1461, 24425, 24664);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 24482, 24544);

                    string
                    partToRemove = f_1461_24504_24543(f_1461_24504_24537(f_1461_24504_24534(f_1461_24504_24525(f_1461_24504_24522(matchResult), 1)), 0))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 24562, 24611);

                    message = f_1461_24572_24610(message, 0, f_1461_24590_24609(partToRemove));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 24629, 24649);

                    matchPattern = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1461, 24425, 24664);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 24680, 24695);

                return message;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1461, 24017, 24706);

                bool
                f_1461_24174_24203(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 24174, 24203);
                    return return_v;
                }


                System.Text.RegularExpressions.Match
                f_1461_24381_24410(string
                input, string
                pattern)
                {
                    var return_v = Regex.Match(input, pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 24381, 24410);
                    return return_v;
                }


                bool
                f_1461_24429_24448(System.Text.RegularExpressions.Match
                this_param)
                {
                    var return_v = this_param.Success;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 24429, 24448);
                    return return_v;
                }


                System.Text.RegularExpressions.GroupCollection
                f_1461_24504_24522(System.Text.RegularExpressions.Match
                this_param)
                {
                    var return_v = this_param.Groups;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 24504, 24522);
                    return return_v;
                }


                System.Text.RegularExpressions.Group
                f_1461_24504_24525(System.Text.RegularExpressions.GroupCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 24504, 24525);
                    return return_v;
                }


                System.Text.RegularExpressions.CaptureCollection
                f_1461_24504_24534(System.Text.RegularExpressions.Group
                this_param)
                {
                    var return_v = this_param.Captures;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 24504, 24534);
                    return return_v;
                }


                System.Text.RegularExpressions.Capture
                f_1461_24504_24537(System.Text.RegularExpressions.CaptureCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 24504, 24537);
                    return return_v;
                }


                string
                f_1461_24504_24543(System.Text.RegularExpressions.Capture
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 24504, 24543);
                    return return_v;
                }


                int
                f_1461_24590_24609(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 24590, 24609);
                    return return_v;
                }


                string
                f_1461_24572_24610(string
                this_param, int
                startIndex, int
                count)
                {
                    var return_v = this_param.Remove(startIndex, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 24572, 24610);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1461, 24017, 24706);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1461, 24017, 24706);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Hashtable NewSuggestion(int id, string category, SuggestionMatchType matchType, string rule, string suggestion, bool enabled)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1461, 25311, 25841);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 25476, 25550);

                Hashtable
                result = f_1461_25495_25549(f_1461_25509_25548())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 25566, 25584);

                result["Id"] = id;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 25598, 25628);

                result["Category"] = category;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 25642, 25674);

                result["MatchType"] = matchType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 25688, 25710);

                result["Rule"] = rule;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 25724, 25758);

                result["Suggestion"] = suggestion;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 25772, 25800);

                result["Enabled"] = enabled;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 25816, 25830);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1461, 25311, 25841);

                System.StringComparer
                f_1461_25509_25548()
                {
                    var return_v = StringComparer.CurrentCultureIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 25509, 25548);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1461_25495_25549(System.StringComparer
                equalityComparer)
                {
                    var return_v = new System.Collections.Hashtable((System.Collections.IEqualityComparer)equalityComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 25495, 25549);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1461, 25311, 25841);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1461, 25311, 25841);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Hashtable NewSuggestion(int id, string category, SuggestionMatchType matchType, string rule, ScriptBlock suggestion, object[] suggestionArgs, bool enabled)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1461, 26579, 27195);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 26774, 26848);

                Hashtable
                result = f_1461_26793_26847(f_1461_26807_26846())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 26864, 26882);

                result["Id"] = id;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 26896, 26926);

                result["Category"] = category;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 26940, 26972);

                result["MatchType"] = matchType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 26986, 27008);

                result["Rule"] = rule;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 27022, 27056);

                result["Suggestion"] = suggestion;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 27070, 27112);

                result["SuggestionArgs"] = suggestionArgs;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 27126, 27154);

                result["Enabled"] = enabled;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 27170, 27184);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1461, 26579, 27195);

                System.StringComparer
                f_1461_26807_26846()
                {
                    var return_v = StringComparer.CurrentCultureIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 26807, 26846);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1461_26793_26847(System.StringComparer
                equalityComparer)
                {
                    var return_v = new System.Collections.Hashtable((System.Collections.IEqualityComparer)equalityComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 26793, 26847);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1461, 26579, 27195);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1461, 26579, 27195);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Hashtable NewSuggestion(int id, string category, SuggestionMatchType matchType, ScriptBlock rule, ScriptBlock suggestion, bool enabled)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1461, 27323, 27863);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 27498, 27572);

                Hashtable
                result = f_1461_27517_27571(f_1461_27531_27570())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 27588, 27606);

                result["Id"] = id;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 27620, 27650);

                result["Category"] = category;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 27664, 27696);

                result["MatchType"] = matchType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 27710, 27732);

                result["Rule"] = rule;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 27746, 27780);

                result["Suggestion"] = suggestion;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 27794, 27822);

                result["Enabled"] = enabled;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 27838, 27852);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1461, 27323, 27863);

                System.StringComparer
                f_1461_27531_27570()
                {
                    var return_v = StringComparer.CurrentCultureIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 27531, 27570);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1461_27517_27571(System.StringComparer
                equalityComparer)
                {
                    var return_v = new System.Collections.Hashtable((System.Collections.IEqualityComparer)equalityComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 27517, 27571);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1461, 27323, 27863);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1461, 27323, 27863);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Hashtable NewSuggestion(int id, string category, SuggestionMatchType matchType, ScriptBlock rule, ScriptBlock suggestion, object[] suggestionArgs, bool enabled)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1461, 28018, 28403);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 28218, 28303);

                Hashtable
                result = f_1461_28237_28302(id, category, matchType, rule, suggestion, enabled)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 28317, 28362);

                f_1461_28317_28361(result, "SuggestionArgs", suggestionArgs);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 28378, 28392);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1461, 28018, 28403);

                System.Collections.Hashtable
                f_1461_28237_28302(int
                id, string
                category, System.Management.Automation.SuggestionMatchType
                matchType, System.Management.Automation.ScriptBlock
                rule, System.Management.Automation.ScriptBlock
                suggestion, bool
                enabled)
                {
                    var return_v = NewSuggestion(id, category, matchType, rule, suggestion, enabled);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 28237, 28302);
                    return return_v;
                }


                int
                f_1461_28317_28361(System.Collections.Hashtable
                this_param, string
                key, object[]
                value)
                {
                    this_param.Add((object)key, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 28317, 28361);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1461, 28018, 28403);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1461, 28018, 28403);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = "Need to keep this for legacy reflection based use")]
        private static string GetSuggestionText(object suggestion, PSModuleInfo invocationModule)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1461, 28524, 28866);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 28794, 28855);

                return f_1461_28801_28854(suggestion, null, invocationModule);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1461, 28524, 28866);

                string
                f_1461_28801_28854(object
                suggestion, object[]
                suggestionArgs, System.Management.Automation.PSModuleInfo
                invocationModule)
                {
                    var return_v = GetSuggestionText(suggestion, suggestionArgs, invocationModule);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 28801, 28854);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1461, 28524, 28866);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1461, 28524, 28866);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string GetSuggestionText(object suggestion, object[] suggestionArgs, PSModuleInfo invocationModule)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1461, 29002, 29941);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 29141, 29930) || true) && (suggestion is ScriptBlock)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1461, 29141, 29930);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 29204, 29259);

                    ScriptBlock
                    suggestionScript = (ScriptBlock)suggestion
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 29279, 29300);

                    object
                    result = null
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 29362, 29429);

                        result = f_1461_29371_29428(invocationModule, suggestionScript, suggestionArgs);
                    }
                    catch (Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1461, 29466, 29633);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 29594, 29614);

                        return string.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1461, 29466, 29633);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 29653, 29749);

                    return (string)f_1461_29668_29748(result, typeof(string), f_1461_29721_29747());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1461, 29141, 29930);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1461, 29141, 29930);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 29815, 29915);

                    return (string)f_1461_29830_29914(suggestion, typeof(string), f_1461_29887_29913());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1461, 29141, 29930);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1461, 29002, 29941);

                object
                f_1461_29371_29428(System.Management.Automation.PSModuleInfo
                this_param, System.Management.Automation.ScriptBlock
                sb, params object[]
                args)
                {
                    var return_v = this_param.Invoke(sb, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 29371, 29428);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1461_29721_29747()
                {
                    var return_v = CultureInfo.CurrentCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 29721, 29747);
                    return return_v;
                }


                object
                f_1461_29668_29748(object
                valueToConvert, System.Type
                resultType, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = LanguagePrimitives.ConvertTo(valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 29668, 29748);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1461_29887_29913()
                {
                    var return_v = CultureInfo.CurrentCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 29887, 29913);
                    return return_v;
                }


                object
                f_1461_29830_29914(object
                valueToConvert, System.Type
                resultType, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = LanguagePrimitives.ConvertTo(valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 29830, 29914);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1461, 29002, 29941);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1461, 29002, 29941);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string GetRemotePrompt(RemoteRunspace runspace, string basePrompt, bool configuredSession = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1461, 30081, 31231);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 30220, 30514) || true) && (configuredSession || (DynAbs.Tracing.TraceSender.Expression_False(1461, 30224, 30312) || f_1461_30262_30285(runspace) is NamedPipeConnectionInfo) || (DynAbs.Tracing.TraceSender.Expression_False(1461, 30224, 30376) || f_1461_30333_30356(runspace) is VMConnectionInfo) || (DynAbs.Tracing.TraceSender.Expression_False(1461, 30224, 30447) || f_1461_30397_30420(runspace) is ContainerConnectionInfo))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1461, 30220, 30514);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 30481, 30499);

                    return basePrompt;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1461, 30220, 30514);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 30530, 30613);

                SSHConnectionInfo
                sshConnectionInfo = f_1461_30568_30591(runspace) as SSHConnectionInfo
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 30690, 31089) || true) && (sshConnectionInfo != null && (DynAbs.Tracing.TraceSender.Expression_True(1461, 30694, 30789) && !f_1461_30741_30789(f_1461_30762_30788(sshConnectionInfo))) && (DynAbs.Tracing.TraceSender.Expression_True(1461, 30694, 30899) && !f_1461_30811_30899(f_1461_30811_30838(), f_1461_30846_30872(sshConnectionInfo), StringComparison.Ordinal)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1461, 30690, 31089);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 30933, 31074);

                    return f_1461_30940_31073(f_1461_30954_30982(), "[{0}@{1}]: {2}", f_1461_31002_31028(sshConnectionInfo), f_1461_31030_31060(sshConnectionInfo), basePrompt);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1461, 30690, 31089);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 31105, 31220);

                return f_1461_31112_31219(f_1461_31126_31154(), "[{0}]: {1}", f_1461_31170_31206(f_1461_31170_31193(runspace)), basePrompt);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1461, 30081, 31231);

                System.Management.Automation.Runspaces.RunspaceConnectionInfo
                f_1461_30262_30285(System.Management.Automation.RemoteRunspace
                this_param)
                {
                    var return_v = this_param.ConnectionInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 30262, 30285);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceConnectionInfo
                f_1461_30333_30356(System.Management.Automation.RemoteRunspace
                this_param)
                {
                    var return_v = this_param.ConnectionInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 30333, 30356);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceConnectionInfo
                f_1461_30397_30420(System.Management.Automation.RemoteRunspace
                this_param)
                {
                    var return_v = this_param.ConnectionInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 30397, 30420);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceConnectionInfo
                f_1461_30568_30591(System.Management.Automation.RemoteRunspace
                this_param)
                {
                    var return_v = this_param.ConnectionInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 30568, 30591);
                    return return_v;
                }


                string
                f_1461_30762_30788(System.Management.Automation.Runspaces.SSHConnectionInfo
                this_param)
                {
                    var return_v = this_param.UserName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 30762, 30788);
                    return return_v;
                }


                bool
                f_1461_30741_30789(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 30741, 30789);
                    return return_v;
                }


                string
                f_1461_30811_30838()
                {
                    var return_v = System.Environment.UserName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 30811, 30838);
                    return return_v;
                }


                string
                f_1461_30846_30872(System.Management.Automation.Runspaces.SSHConnectionInfo
                this_param)
                {
                    var return_v = this_param.UserName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 30846, 30872);
                    return return_v;
                }


                bool
                f_1461_30811_30899(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 30811, 30899);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1461_30954_30982()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 30954, 30982);
                    return return_v;
                }


                string
                f_1461_31002_31028(System.Management.Automation.Runspaces.SSHConnectionInfo
                this_param)
                {
                    var return_v = this_param.UserName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 31002, 31028);
                    return return_v;
                }


                string
                f_1461_31030_31060(System.Management.Automation.Runspaces.SSHConnectionInfo
                this_param)
                {
                    var return_v = this_param.ComputerName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 31030, 31060);
                    return return_v;
                }


                string
                f_1461_30940_31073(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1, string
                arg2)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 30940, 31073);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1461_31126_31154()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 31126, 31154);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceConnectionInfo
                f_1461_31170_31193(System.Management.Automation.RemoteRunspace
                this_param)
                {
                    var return_v = this_param.ConnectionInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 31170, 31193);
                    return return_v;
                }


                string
                f_1461_31170_31206(System.Management.Automation.Runspaces.RunspaceConnectionInfo
                this_param)
                {
                    var return_v = this_param.ComputerName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 31170, 31206);
                    return return_v;
                }


                string
                f_1461_31112_31219(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 31112, 31219);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1461, 30081, 31231);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1461, 30081, 31231);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsProcessInteractive(InvocationInfo invocationInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1461, 31243, 32738);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 31353, 31366);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1461, 31243, 32738);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1461, 31243, 32738);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1461, 31243, 32738);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static RemoteRunspace CreateConfiguredRunspace(
                    string configurationName,
                    PSHost host)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1461, 32994, 34130);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 33286, 33341);

                TypeTable
                typeTable = f_1461_33308_33340()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 33355, 33399);

                var
                connectInfo = f_1461_33373_33398()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 33413, 33461);

                connectInfo.ShellUri = f_1461_33436_33460(configurationName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 33475, 33514);

                connectInfo.EnableNetworkAccess = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 33530, 33567);

                RemoteRunspace
                remoteRunspace = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 33617, 33711);

                    remoteRunspace = (RemoteRunspace)f_1461_33650_33710(connectInfo, host, typeTable);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 33729, 33751);

                    f_1461_33729_33750(remoteRunspace);
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1461, 33780, 34024);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 33832, 34009);

                    throw f_1461_33838_34008(f_1461_33892_33983(f_1461_33910_33963(), configurationName), e);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1461, 33780, 34024);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 34040, 34083);

                remoteRunspace.IsConfiguredLoopBack = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 34097, 34119);

                return remoteRunspace;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1461, 32994, 34130);

                System.Management.Automation.Runspaces.TypeTable
                f_1461_33308_33340()
                {
                    var return_v = TypeTable.LoadDefaultTypeFiles();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 33308, 33340);
                    return return_v;
                }


                System.Management.Automation.Runspaces.WSManConnectionInfo
                f_1461_33373_33398()
                {
                    var return_v = new System.Management.Automation.Runspaces.WSManConnectionInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 33373, 33398);
                    return return_v;
                }


                string
                f_1461_33436_33460(string
                this_param)
                {
                    var return_v = this_param.Trim();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 33436, 33460);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1461_33650_33710(System.Management.Automation.Runspaces.WSManConnectionInfo
                connectionInfo, System.Management.Automation.Host.PSHost
                host, System.Management.Automation.Runspaces.TypeTable
                typeTable)
                {
                    var return_v = RunspaceFactory.CreateRunspace((System.Management.Automation.Runspaces.RunspaceConnectionInfo)connectionInfo, host, typeTable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 33650, 33710);
                    return return_v;
                }


                int
                f_1461_33729_33750(System.Management.Automation.RemoteRunspace
                this_param)
                {
                    this_param.Open();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 33729, 33750);
                    return 0;
                }


                string
                f_1461_33910_33963()
                {
                    var return_v = RemotingErrorIdStrings.CannotCreateConfiguredRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 33910, 33963);
                    return return_v;
                }


                string
                f_1461_33892_33983(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 33892, 33983);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1461_33838_34008(string
                message, System.Exception
                innerException)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message, innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 33838, 34008);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1461, 32994, 34130);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1461, 32994, 34130);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Collection<PSObject> InvokeOnRunspace(PSCommand command, Runspace runspace)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1461, 35259, 36676);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 35373, 35486) || true) && (command == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1461, 35373, 35486);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 35426, 35471);

                    throw f_1461_35432_35470("command");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1461, 35373, 35486);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 35502, 35617) || true) && (runspace == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1461, 35502, 35617);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 35556, 35602);

                    throw f_1461_35562_35601("runspace");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1461, 35502, 35617);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 35633, 36091) || true) && ((f_1461_35638_35655(runspace) != null) && (DynAbs.Tracing.TraceSender.Expression_True(1461, 35637, 35698) && f_1461_35668_35698(f_1461_35668_35685(runspace))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1461, 35633, 36091);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 35836, 35905);

                    PSDataCollection<PSObject>
                    output = f_1461_35872_35904()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 35923, 36016);

                    f_1461_35923_36015(f_1461_35923_35940(runspace), command, output);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 36036, 36076);

                    return f_1461_36043_36075(output);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1461, 35633, 36091);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 36167, 36203);

                PowerShell
                ps = f_1461_36183_36202()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 36217, 36240);

                ps.Runspace = runspace;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 36254, 36281);

                ps.IsRunspaceOwner = false;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 36295, 36522) || true) && (f_1461_36299_36322(runspace) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1461, 36295, 36522);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 36444, 36507);

                    f_1461_36444_36506(                // Local runspace.  Make a nested PowerShell object as needed.
                                    ps, f_1461_36459_36497(runspace) != null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1461, 36295, 36522);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 36538, 36665);
                using (ps)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 36581, 36603);

                    ps.Commands = command;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 36621, 36650);

                    return f_1461_36628_36649(ps);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1461, 36538, 36665);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1461, 35259, 36676);

                System.Management.Automation.PSArgumentNullException
                f_1461_35432_35470(string
                paramName)
                {
                    var return_v = new System.Management.Automation.PSArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 35432, 35470);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1461_35562_35601(string
                paramName)
                {
                    var return_v = new System.Management.Automation.PSArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 35562, 35601);
                    return return_v;
                }


                System.Management.Automation.Debugger
                f_1461_35638_35655(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.Debugger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 35638, 35655);
                    return return_v;
                }


                System.Management.Automation.Debugger
                f_1461_35668_35685(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.Debugger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 35668, 35685);
                    return return_v;
                }


                bool
                f_1461_35668_35698(System.Management.Automation.Debugger
                this_param)
                {
                    var return_v = this_param.InBreakpoint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 35668, 35698);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                f_1461_35872_35904()
                {
                    var return_v = new System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 35872, 35904);
                    return return_v;
                }


                System.Management.Automation.Debugger
                f_1461_35923_35940(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.Debugger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 35923, 35940);
                    return return_v;
                }


                System.Management.Automation.DebuggerCommandResults
                f_1461_35923_36015(System.Management.Automation.Debugger
                this_param, System.Management.Automation.PSCommand
                command, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                output)
                {
                    var return_v = this_param.ProcessCommand(command, output);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 35923, 36015);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1461_36043_36075(System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                list)
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>((System.Collections.Generic.IList<System.Management.Automation.PSObject>)list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 36043, 36075);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1461_36183_36202()
                {
                    var return_v = PowerShell.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 36183, 36202);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceConnectionInfo
                f_1461_36299_36322(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.ConnectionInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1461, 36299, 36322);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Pipeline
                f_1461_36459_36497(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.GetCurrentlyRunningPipeline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 36459, 36497);
                    return return_v;
                }


                int
                f_1461_36444_36506(System.Management.Automation.PowerShell
                this_param, bool
                isNested)
                {
                    this_param.SetIsNested(isNested);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 36444, 36506);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1461_36628_36649(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Invoke<System.Management.Automation.PSObject>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 36628, 36649);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1461, 35259, 36676);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1461, 35259, 36676);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public const string
        PSEditFunction = @"
            param (
                [Parameter(Mandatory=$true)] [string[]] $FileName
            )

            foreach ($file in $FileName)
            {
                Get-ChildItem $file -File | ForEach-Object {
                    $filePathName = $_.FullName

                    # Get file contents
                    $contentBytes = Get-Content -Path $filePathName -Raw -Encoding Byte

                    # Notify client for file open.
                    New-Event -SourceIdentifier PSISERemoteSessionOpenFile -EventArguments @($filePathName, $contentBytes) > $null
                }
            }
        "
        ;

        public const string
        CreatePSEditFunction = @"
            param (
                [string] $PSEditFunction
            )

            Register-EngineEvent -SourceIdentifier PSISERemoteSessionOpenFile -Forward -SupportEvent

            if ((Test-Path -Path 'function:\global:PSEdit') -eq $false)
            {
                Set-Item -Path 'function:\global:PSEdit' -Value $PSEditFunction
            }
        "
        ;

        public const string
        RemovePSEditFunction = @"
            if ((Test-Path -Path 'function:\global:PSEdit') -eq $true)
            {
                Remove-Item -Path 'function:\global:PSEdit' -Force
            }

            Unregister-Event -SourceIdentifier PSISERemoteSessionOpenFile -Force -ErrorAction Ignore
        "
        ;

        public const string
        RemoteSessionOpenFileEvent = "PSISERemoteSessionOpenFile"
        ;

        static HostUtilities()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1461, 1253, 38700);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 1360, 1997);
            s_checkForCommandInCurrentDirectoryScript = @"
            [System.Diagnostics.DebuggerHidden()]
            param()

            $foundSuggestion = $false

            if($lastError -and
                ($lastError.Exception -is ""System.Management.Automation.CommandNotFoundException""))
            {
                $escapedCommand = [System.Management.Automation.WildcardPattern]::Escape($lastError.TargetObject)
                $foundSuggestion = @(Get-Command ($ExecutionContext.SessionState.Path.Combine(""."", $escapedCommand)) -ErrorAction Ignore).Count -gt 0
            }

            $foundSuggestion
        ";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 2032, 2276);
            s_createCommandExistsInCurrentDirectoryScript = @"
            [System.Diagnostics.DebuggerHidden()]
            param([string] $formatString)

            $formatString -f $lastError.TargetObject,"".\$($lastError.TargetObject)""
        ";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 2311, 2608);
            s_getFuzzyMatchedCommands = @"
            [System.Diagnostics.DebuggerHidden()]
            param([string] $formatString)

            $formatString -f [string]::Join(', ', (Get-Command $lastError.TargetObject -UseFuzzyMatch | Select-Object -First 10 -Unique -ExpandProperty Name))
        ";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 2652, 2691);
            s_suggestions = f_1461_2668_2691();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 36854, 37509);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 37638, 38042);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 38171, 38481);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1461, 38591, 38648);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1461, 1253, 38700);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1461, 1253, 38700);
        }


        static System.Collections.Generic.List<System.Collections.Hashtable>
        f_1461_2668_2691()
        {
            var return_v = InitializeSuggestions();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1461, 2668, 2691);
            return return_v;
        }

    }

}
