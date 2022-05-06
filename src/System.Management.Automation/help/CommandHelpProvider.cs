// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Management.Automation.Internal;
using System.Management.Automation.Runspaces;
using System.Xml;

using Dbg = System.Management.Automation.Diagnostics;
using System.Management.Automation.Help;
using System.Reflection;

namespace System.Management.Automation
{
    internal class CommandHelpProvider : HelpProviderWithCache
    {
        internal CommandHelpProvider(HelpSystem helpSystem) : base(f_1145_1142_1152_C(helpSystem))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1145, 1083, 1228);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 2398, 2406);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 21519, 21547);
                this._helpFiles = f_1145_21532_21547();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 1178, 1217);

                _context = f_1145_1189_1216(helpSystem);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1145, 1083, 1228);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1145, 1083, 1228);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1145, 1083, 1228);
            }
        }

        static CommandHelpProvider()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1145, 1287, 2235);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 2289, 2351);
                s_engineModuleHelpFileCache = f_1145_2319_2351();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 58644, 58724);
                s_tracer = f_1145_58655_58724("CommandHelpProvider", "CommandHelpProvider");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 1340, 1466);

                f_1145_1340_1465(s_engineModuleHelpFileCache, "Microsoft.PowerShell.Diagnostics", "Microsoft.PowerShell.Commands.Diagnostics.dll-Help.xml");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 1480, 1586);

                f_1145_1480_1585(s_engineModuleHelpFileCache, "Microsoft.PowerShell.Core", "System.Management.Automation.dll-Help.xml");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 1600, 1718);

                f_1145_1600_1717(s_engineModuleHelpFileCache, "Microsoft.PowerShell.Utility", "Microsoft.PowerShell.Commands.Utility.dll-Help.xml");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 1732, 1842);

                f_1145_1732_1841(s_engineModuleHelpFileCache, "Microsoft.PowerShell.Host", "Microsoft.PowerShell.ConsoleHost.dll-Help.xml");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 1856, 1980);

                f_1145_1856_1979(s_engineModuleHelpFileCache, "Microsoft.PowerShell.Management", "Microsoft.PowerShell.Commands.Management.dll-Help.xml");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 1994, 2105);

                f_1145_1994_2104(s_engineModuleHelpFileCache, "Microsoft.PowerShell.Security", "Microsoft.PowerShell.Security.dll-Help.xml");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 2119, 2224);

                f_1145_2119_2223(s_engineModuleHelpFileCache, "Microsoft.WSMan.Management", "Microsoft.Wsman.Management.dll-Help.xml");
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1145, 1287, 2235);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1145, 1287, 2235);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1145, 1287, 2235);
            }
        }

        private static Dictionary<string, string> s_engineModuleHelpFileCache;

        private readonly ExecutionContext _context;

        internal override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1145, 2643, 2725);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 2679, 2710);

                    return "Command Help Provider";
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1145, 2643, 2725);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1145, 2589, 2736);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1145, 2589, 2736);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override HelpCategory HelpCategory
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1145, 3012, 3153);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 3048, 3138);

                    return
                                        HelpCategory.Alias |
                                        HelpCategory.Cmdlet;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1145, 3012, 3153);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1145, 2944, 3164);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1145, 2944, 3164);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private void GetModulePaths(CommandInfo commandInfo, out string moduleName, out string moduleDir, out string nestedModulePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1145, 3241, 5447);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 3392, 3473);

                f_1145_3392_3472(commandInfo != null, "Caller should verify that commandInfo != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 3489, 3539);

                CmdletInfo
                cmdletInfo = commandInfo as CmdletInfo
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 3553, 3626);

                IScriptCommandInfo
                scriptCommandInfo = commandInfo as IScriptCommandInfo
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 3642, 3677);

                string
                cmdNameWithoutPrefix = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 3691, 3722);

                bool
                testWithoutPrefix = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 3738, 3756);

                moduleName = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 3770, 3787);

                moduleDir = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 3801, 3825);

                nestedModulePath = null;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 3841, 5436) || true) && (f_1145_3845_3863(commandInfo) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 3841, 5436);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 3905, 3942);

                    moduleName = f_1145_3918_3941(f_1145_3918_3936(commandInfo));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 3960, 4002);

                    moduleDir = f_1145_3972_4001(f_1145_3972_3990(commandInfo));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 4022, 4311) || true) && (!f_1145_4027_4067(f_1145_4048_4066(commandInfo)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 4022, 4311);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 4109, 4134);

                        testWithoutPrefix = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 4156, 4292);

                        cmdNameWithoutPrefix = f_1145_4179_4291(f_1145_4254_4270(commandInfo), f_1145_4272_4290(commandInfo));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 4022, 4311);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 4331, 5421) || true) && (f_1145_4335_4367(f_1145_4335_4353(commandInfo)) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 4331, 5421);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 4417, 5402);
                            foreach (PSModuleInfo nestedModule in f_1145_4455_4487_I(f_1145_4455_4487(f_1145_4455_4473(commandInfo))))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 4417, 5402);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 4537, 5379) || true) && (cmdletInfo != null && (DynAbs.Tracing.TraceSender.Expression_True(1145, 4541, 4774) && (f_1145_4594_4652(f_1145_4594_4622(nestedModule), f_1145_4635_4651(commandInfo)) || (DynAbs.Tracing.TraceSender.Expression_False(1145, 4594, 4773) || (testWithoutPrefix && (DynAbs.Tracing.TraceSender.Expression_True(1145, 4689, 4772) && f_1145_4710_4772(f_1145_4710_4738(nestedModule), cmdNameWithoutPrefix)))))))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 4537, 5379);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 4832, 4869);

                                    nestedModulePath = f_1145_4851_4868(nestedModule);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1145, 4899, 4905);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 4537, 5379);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 4537, 5379);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 4963, 5379) || true) && (scriptCommandInfo != null && (DynAbs.Tracing.TraceSender.Expression_True(1145, 4967, 5221) && (f_1145_5032_5092(f_1145_5032_5062(nestedModule), f_1145_5075_5091(commandInfo)) || (DynAbs.Tracing.TraceSender.Expression_False(1145, 5032, 5220) || (testWithoutPrefix && (DynAbs.Tracing.TraceSender.Expression_True(1145, 5134, 5219) && f_1145_5155_5219(f_1145_5155_5185(nestedModule), cmdNameWithoutPrefix)))))))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 4963, 5379);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 5279, 5316);

                                        nestedModulePath = f_1145_5298_5315(nestedModule);
                                        DynAbs.Tracing.TraceSender.TraceBreak(1145, 5346, 5352);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 4963, 5379);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 4537, 5379);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 4417, 5402);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1145, 1, 986);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1145, 1, 986);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 4331, 5421);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 3841, 5436);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1145, 3241, 5447);

                int
                f_1145_3392_3472(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 3392, 3472);
                    return 0;
                }


                System.Management.Automation.PSModuleInfo
                f_1145_3845_3863(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 3845, 3863);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1145_3918_3936(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 3918, 3936);
                    return return_v;
                }


                string
                f_1145_3918_3941(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 3918, 3941);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1145_3972_3990(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 3972, 3990);
                    return return_v;
                }


                string
                f_1145_3972_4001(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.ModuleBase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 3972, 4001);
                    return return_v;
                }


                string
                f_1145_4048_4066(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Prefix;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 4048, 4066);
                    return return_v;
                }


                bool
                f_1145_4027_4067(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 4027, 4067);
                    return return_v;
                }


                string
                f_1145_4254_4270(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 4254, 4270);
                    return return_v;
                }


                string
                f_1145_4272_4290(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Prefix;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 4272, 4290);
                    return return_v;
                }


                string
                f_1145_4179_4291(string
                commandName, string
                prefix)
                {
                    var return_v = Microsoft.PowerShell.Commands.ModuleCmdletBase.RemovePrefixFromCommandName(commandName, prefix);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 4179, 4291);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1145_4335_4353(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 4335, 4353);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSModuleInfo>
                f_1145_4335_4367(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.NestedModules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 4335, 4367);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1145_4455_4473(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 4455, 4473);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSModuleInfo>
                f_1145_4455_4487(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.NestedModules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 4455, 4487);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.CmdletInfo>
                f_1145_4594_4622(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.ExportedCmdlets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 4594, 4622);
                    return return_v;
                }


                string
                f_1145_4635_4651(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 4635, 4651);
                    return return_v;
                }


                bool
                f_1145_4594_4652(System.Collections.Generic.Dictionary<string, System.Management.Automation.CmdletInfo>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 4594, 4652);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.CmdletInfo>
                f_1145_4710_4738(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.ExportedCmdlets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 4710, 4738);
                    return return_v;
                }


                bool
                f_1145_4710_4772(System.Collections.Generic.Dictionary<string, System.Management.Automation.CmdletInfo>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 4710, 4772);
                    return return_v;
                }


                string
                f_1145_4851_4868(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 4851, 4868);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>
                f_1145_5032_5062(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.ExportedFunctions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 5032, 5062);
                    return return_v;
                }


                string
                f_1145_5075_5091(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 5075, 5091);
                    return return_v;
                }


                bool
                f_1145_5032_5092(System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 5032, 5092);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>
                f_1145_5155_5185(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.ExportedFunctions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 5155, 5185);
                    return return_v;
                }


                bool
                f_1145_5155_5219(System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 5155, 5219);
                    return return_v;
                }


                string
                f_1145_5298_5315(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 5298, 5315);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSModuleInfo>
                f_1145_4455_4487_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSModuleInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 4455, 4487);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1145, 3241, 5447);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1145, 3241, 5447);
            }
        }

        private string GetHelpName(CommandInfo commandInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1145, 5459, 5847);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 5535, 5616);

                f_1145_5535_5615(commandInfo != null, "Caller should verify that commandInfo != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 5632, 5682);

                CmdletInfo
                cmdletInfo = commandInfo as CmdletInfo
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 5698, 5796) || true) && (cmdletInfo != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 5698, 5796);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 5754, 5781);

                    return f_1145_5761_5780(cmdletInfo);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 5698, 5796);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 5812, 5836);

                return f_1145_5819_5835(commandInfo);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1145, 5459, 5847);

                int
                f_1145_5535_5615(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 5535, 5615);
                    return 0;
                }


                string
                f_1145_5761_5780(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 5761, 5780);
                    return return_v;
                }


                string
                f_1145_5819_5835(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 5819, 5835);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1145, 5459, 5847);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1145, 5459, 5847);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private HelpInfo GetHelpInfoFromHelpFile(CommandInfo commandInfo, string helpFileToFind, Collection<string> searchPaths, bool reportErrors, out string helpFile)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1145, 5859, 7424);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 6044, 6125);

                f_1145_6044_6124(commandInfo != null, "Caller should verify that commandInfo != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 6139, 6226);

                f_1145_6139_6225(helpFileToFind != null, "Caller should verify that helpFileToFind != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 6242, 6292);

                CmdletInfo
                cmdletInfo = commandInfo as CmdletInfo
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 6306, 6379);

                IScriptCommandInfo
                scriptCommandInfo = commandInfo as IScriptCommandInfo
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 6395, 6418);

                HelpInfo
                result = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 6434, 6501);

                helpFile = f_1145_6445_6500(helpFileToFind, searchPaths);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 6517, 7383) || true) && (!f_1145_6522_6552(helpFile))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 6517, 7383);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 6586, 7047) || true) && (!f_1145_6591_6620(_helpFiles, helpFile))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 6586, 7047);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 6662, 7028) || true) && (cmdletInfo != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 6662, 7028);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 6734, 6811);

                            f_1145_6734_6810(this, helpFile, f_1145_6757_6778(cmdletInfo), f_1145_6780_6795(cmdletInfo), reportErrors);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 6662, 7028);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 6662, 7028);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 6861, 7028) || true) && (scriptCommandInfo != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 6861, 7028);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 6940, 7005);

                                f_1145_6940_7004(this, helpFile, helpFile, f_1145_6973_6989(commandInfo), reportErrors);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 6861, 7028);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 6662, 7028);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 6586, 7047);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 7067, 7368) || true) && (cmdletInfo != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 7067, 7368);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 7131, 7184);

                        result = f_1145_7140_7183(this, cmdletInfo);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 7067, 7368);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 7067, 7368);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 7226, 7368) || true) && (scriptCommandInfo != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 7226, 7368);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 7297, 7349);

                            result = f_1145_7306_7348(this, helpFile, commandInfo);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 7226, 7368);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 7067, 7368);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 6517, 7383);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 7399, 7413);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1145, 5859, 7424);

                int
                f_1145_6044_6124(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 6044, 6124);
                    return 0;
                }


                int
                f_1145_6139_6225(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 6139, 6225);
                    return 0;
                }


                string
                f_1145_6445_6500(string
                file, System.Collections.ObjectModel.Collection<string>
                searchPaths)
                {
                    var return_v = MUIFileSearcher.LocateFile(file, searchPaths);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 6445, 6500);
                    return return_v;
                }


                bool
                f_1145_6522_6552(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 6522, 6552);
                    return return_v;
                }


                bool
                f_1145_6591_6620(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.Contains((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 6591, 6620);
                    return return_v;
                }


                string
                f_1145_6757_6778(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 6757, 6778);
                    return return_v;
                }


                string
                f_1145_6780_6795(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 6780, 6795);
                    return return_v;
                }


                int
                f_1145_6734_6810(System.Management.Automation.CommandHelpProvider
                this_param, string
                helpFile, string
                helpFileIdentifier, string
                commandName, bool
                reportErrors)
                {
                    this_param.LoadHelpFile(helpFile, helpFileIdentifier, commandName, reportErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 6734, 6810);
                    return 0;
                }


                string
                f_1145_6973_6989(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 6973, 6989);
                    return return_v;
                }


                int
                f_1145_6940_7004(System.Management.Automation.CommandHelpProvider
                this_param, string
                helpFile, string
                helpFileIdentifier, string
                commandName, bool
                reportErrors)
                {
                    this_param.LoadHelpFile(helpFile, helpFileIdentifier, commandName, reportErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 6940, 7004);
                    return 0;
                }


                System.Management.Automation.HelpInfo
                f_1145_7140_7183(System.Management.Automation.CommandHelpProvider
                this_param, System.Management.Automation.CmdletInfo
                cmdletInfo)
                {
                    var return_v = this_param.GetFromCommandCacheOrCmdletInfo(cmdletInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 7140, 7183);
                    return return_v;
                }


                System.Management.Automation.HelpInfo
                f_1145_7306_7348(System.Management.Automation.CommandHelpProvider
                this_param, string
                helpFileIdentifier, System.Management.Automation.CommandInfo
                commandInfo)
                {
                    var return_v = this_param.GetFromCommandCache(helpFileIdentifier, commandInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 7306, 7348);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1145, 5859, 7424);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1145, 5859, 7424);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [SuppressMessage("Microsoft.Usage", "CA1806:DoNotIgnoreMethodResults", Justification = "TestUri is created only to check for source helpUriFromDotLink errors.")]
        private HelpInfo GetHelpInfo(CommandInfo commandInfo, bool reportErrors, bool searchOnlyContent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1145, 7436, 17974);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 7728, 7809);

                f_1145_7728_7808(commandInfo != null, "Caller should verify that commandInfo != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 7825, 7848);

                HelpInfo
                result = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 7881, 7904);

                string
                helpFile = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 7958, 7980);

                string
                helpUri = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 7994, 8027);

                string
                helpUriFromDotLink = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 8043, 8093);

                CmdletInfo
                cmdletInfo = commandInfo as CmdletInfo
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 8107, 8180);

                IScriptCommandInfo
                scriptCommandInfo = commandInfo as IScriptCommandInfo
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 8194, 8250);

                FunctionInfo
                functionInfo = commandInfo as FunctionInfo
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 8264, 8299);

                bool
                isCmdlet = cmdletInfo != null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 8313, 8362);

                bool
                isScriptCommand = scriptCommandInfo != null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 8376, 8415);

                bool
                isFunction = functionInfo != null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 8431, 8456);

                string
                moduleName = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 8470, 8494);

                string
                moduleDir = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 8508, 8539);

                string
                nestedModulePath = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 9007, 9071) || true) && (!isCmdlet && (DynAbs.Tracing.TraceSender.Expression_True(1145, 9011, 9040) && !isScriptCommand))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 9007, 9071);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 9059, 9071);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 9007, 9071);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 9253, 10562) || true) && (isCmdlet && (DynAbs.Tracing.TraceSender.Expression_True(1145, 9257, 9313) && !InternalTestHooks.BypassOnlineHelpRetrieval))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 9253, 10562);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 9347, 9441);

                    result = f_1145_9356_9440(this, f_1145_9376_9397(cmdletInfo), f_1145_9399_9414(cmdletInfo), f_1145_9416_9439(cmdletInfo));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 9461, 9983) || true) && (result == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 9461, 9983);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 9610, 9646);

                        helpFile = f_1145_9621_9645(this, cmdletInfo);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 9668, 9887) || true) && (!f_1145_9673_9703(helpFile) && (DynAbs.Tracing.TraceSender.Expression_True(1145, 9672, 9737) && !f_1145_9708_9737(_helpFiles, helpFile)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 9668, 9887);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 9787, 9864);

                            f_1145_9787_9863(this, helpFile, f_1145_9810_9831(cmdletInfo), f_1145_9833_9848(cmdletInfo), reportErrors);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 9668, 9887);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 9911, 9964);

                        result = f_1145_9920_9963(this, cmdletInfo);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 9461, 9983);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 9253, 10562);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 9253, 10562);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 10017, 10562) || true) && (isFunction)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 10017, 10562);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 10152, 10185);

                        helpFile = f_1145_10163_10184(functionInfo);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 10203, 10547) || true) && (!f_1145_10208_10238(helpFile))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 10203, 10547);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 10280, 10452) || true) && (!f_1145_10285_10314(_helpFiles, helpFile))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 10280, 10452);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 10364, 10429);

                                f_1145_10364_10428(this, helpFile, helpFile, f_1145_10397_10413(commandInfo), reportErrors);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 10280, 10452);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 10476, 10528);

                            result = f_1145_10485_10527(this, helpFile, commandInfo);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 10203, 10547);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 10017, 10562);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 9253, 10562);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 10683, 13106) || true) && (result == null && (DynAbs.Tracing.TraceSender.Expression_True(1145, 10687, 10720) && isScriptCommand))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 10683, 13106);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 10754, 10776);

                    ScriptBlock
                    sb = null
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 10838, 10873);

                        sb = f_1145_10843_10872(scriptCommandInfo);
                    }
                    catch (RuntimeException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1145, 10910, 11081);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 11050, 11062);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1145, 10910, 11081);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 11101, 13091) || true) && (sb != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 11101, 13091);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 11157, 11173);

                        helpFile = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 11634, 11797);

                        result = f_1145_11643_11796(sb, _context, commandInfo, searchOnlyContent, f_1145_11700_11732(f_1145_11700_11710()), out helpFile, out helpUriFromDotLink);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 11821, 12311) || true) && (!f_1145_11826_11866(helpUriFromDotLink))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 11821, 12311);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 11976, 12018);

                                Uri
                                testUri = f_1145_11990_12017(helpUriFromDotLink)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 12048, 12077);

                                helpUri = helpUriFromDotLink;
                            }
                            catch (UriFormatException)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1145, 12130, 12288);
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1145, 12130, 12288);
                                // Do not add if helpUriFromDotLink is not a URI
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 11821, 12311);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 12335, 12618) || true) && (result != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 12335, 12618);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 12403, 12442);

                            Uri
                            uri = f_1145_12413_12441(result)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 12470, 12595) || true) && (uri != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 12470, 12595);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 12543, 12568);

                                helpUri = f_1145_12553_12567(uri);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 12470, 12595);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 12335, 12618);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 12642, 13072) || true) && (!f_1145_12647_12677(helpFile) && (DynAbs.Tracing.TraceSender.Expression_True(1145, 12646, 12725) && !InternalTestHooks.BypassOnlineHelpRetrieval))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 12642, 13072);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 12775, 12959) || true) && (!f_1145_12780_12809(_helpFiles, helpFile))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 12775, 12959);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 12867, 12932);

                                f_1145_12867_12931(this, helpFile, helpFile, f_1145_12900_12916(commandInfo), reportErrors);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 12775, 12959);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 12987, 13049);

                            result = f_1145_12996_13038(this, helpFile, commandInfo) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.HelpInfo>(1145, 12996, 13048) ?? result);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 12642, 13072);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 11101, 13091);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 10683, 13106);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 13503, 15338) || true) && (result == null && (DynAbs.Tracing.TraceSender.Expression_True(1145, 13507, 13569) && !InternalTestHooks.BypassOnlineHelpRetrieval))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 13503, 15338);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 13755, 13836);

                    f_1145_13755_13835(this, commandInfo, out moduleName, out moduleDir, out nestedModulePath);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 13856, 13917);

                    var
                    userHomeHelpPath = f_1145_13879_13916()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 13937, 14016);

                    Collection<string>
                    searchPaths = new Collection<string>() { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => userHomeHelpPath, 1145, 13970, 14015) }
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 14036, 14160) || true) && (!f_1145_14041_14072(moduleDir))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 14036, 14160);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 14114, 14141);

                        f_1145_14114_14140(searchPaths, moduleDir);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 14036, 14160);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 14180, 14381) || true) && (!f_1145_14185_14223(userHomeHelpPath) && (DynAbs.Tracing.TraceSender.Expression_True(1145, 14184, 14260) && !f_1145_14228_14260(moduleName)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 14180, 14381);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 14302, 14362);

                        f_1145_14302_14361(searchPaths, f_1145_14318_14360(userHomeHelpPath, moduleName));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 14180, 14381);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 14401, 14790) || true) && (!f_1145_14406_14438(moduleName) && (DynAbs.Tracing.TraceSender.Expression_True(1145, 14405, 14474) && !f_1145_14443_14474(moduleDir)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 14401, 14790);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 14597, 14646);

                        string
                        helpFileToFind = moduleName + "-Help.xml"
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 14668, 14771);

                        result = f_1145_14677_14770(this, commandInfo, helpFileToFind, searchPaths, reportErrors, out helpFile);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 14401, 14790);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 14810, 15323) || true) && (result == null && (DynAbs.Tracing.TraceSender.Expression_True(1145, 14814, 14871) && !f_1145_14833_14871(nestedModulePath)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 14810, 15323);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 15027, 15084);

                        f_1145_15027_15083(                    // Search for <NestedModuleName>-Help.xml under both ModuleBase and NestedModule's directory
                                            searchPaths, f_1145_15043_15082(nestedModulePath));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 15106, 15179);

                        string
                        helpFileToFind = f_1145_15130_15164(nestedModulePath) + "-Help.xml"
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 15201, 15304);

                        result = f_1145_15210_15303(this, commandInfo, helpFileToFind, searchPaths, reportErrors, out helpFile);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 14810, 15323);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 13503, 15338);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 15439, 15776) || true) && (result != null && (DynAbs.Tracing.TraceSender.Expression_True(1145, 15443, 15492) && !f_1145_15462_15492(helpFile)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 15439, 15776);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 15526, 15761) || true) && (isCmdlet)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 15526, 15761);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 15580, 15611);

                        cmdletInfo.HelpFile = helpFile;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 15526, 15761);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 15526, 15761);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 15653, 15761) || true) && (isFunction)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 15653, 15761);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 15709, 15742);

                            functionInfo.HelpFile = helpFile;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 15653, 15761);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 15526, 15761);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 15439, 15776);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 15916, 16816) || true) && (result == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 15916, 16816);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 15968, 16801) || true) && (f_1145_15972_15995(commandInfo) == CommandTypes.ExternalScript || (DynAbs.Tracing.TraceSender.Expression_False(1145, 15972, 16097) || f_1145_16051_16074(commandInfo) == CommandTypes.Script))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 15968, 16801);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 16139, 16239);

                        result = f_1145_16148_16238(f_1145_16175_16191(commandInfo), f_1145_16193_16211(commandInfo), f_1145_16213_16237(commandInfo));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 15968, 16801);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 15968, 16801);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 16321, 16417);

                        PSObject
                        helpInfo = f_1145_16341_16416(commandInfo)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 16441, 16468);

                        f_1145_16441_16467(f_1145_16441_16459(helpInfo));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 16490, 16569);

                        f_1145_16490_16568(f_1145_16490_16508(helpInfo), DefaultCommandHelpObjectBuilder.TypeNameForDefaultHelp);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 16591, 16632);

                        f_1145_16591_16631(f_1145_16591_16609(helpInfo), "CmdletHelpInfo");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 16654, 16689);

                        f_1145_16654_16688(f_1145_16654_16672(helpInfo), "HelpInfo");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 16713, 16782);

                        result = f_1145_16722_16781(helpInfo, f_1145_16756_16780(commandInfo));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 15968, 16801);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 15916, 16816);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 16832, 17933) || true) && (result != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 16832, 17933);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 16884, 17469) || true) && (isScriptCommand && (DynAbs.Tracing.TraceSender.Expression_True(1145, 16888, 16943) && f_1145_16907_16935(result) == null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 16884, 17469);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 16985, 17450) || true) && (!f_1145_16990_17047(f_1145_17011_17046(f_1145_17011_17038(commandInfo))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 16985, 17450);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 17097, 17209);

                            f_1145_17097_17208(f_1145_17155_17170(result), f_1145_17172_17207(f_1145_17172_17199(commandInfo)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 16985, 17450);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 16985, 17450);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 17259, 17450) || true) && (!f_1145_17264_17293(helpUri))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 17259, 17450);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 17343, 17427);

                                f_1145_17343_17426(f_1145_17401_17416(result), helpUri);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 17259, 17450);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 16985, 17450);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 16884, 17469);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 17489, 17696) || true) && (isCmdlet && (DynAbs.Tracing.TraceSender.Expression_True(1145, 17493, 17551) && f_1145_17505_17543(f_1145_17505_17531(f_1145_17505_17520(result)), "PSSnapIn") == null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 17489, 17696);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 17593, 17677);

                        f_1145_17593_17676(f_1145_17593_17619(f_1145_17593_17608(result)), f_1145_17624_17675("PSSnapIn", f_1145_17655_17674(cmdletInfo)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 17489, 17696);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 17716, 17918) || true) && (f_1145_17720_17760(f_1145_17720_17746(f_1145_17720_17735(result)), "ModuleName") == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 17716, 17918);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 17810, 17899);

                        f_1145_17810_17898(f_1145_17810_17836(f_1145_17810_17825(result)), f_1145_17841_17897("ModuleName", f_1145_17874_17896(commandInfo)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 17716, 17918);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 16832, 17933);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 17949, 17963);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1145, 7436, 17974);

                int
                f_1145_7728_7808(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 7728, 7808);
                    return 0;
                }


                string
                f_1145_9376_9397(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 9376, 9397);
                    return return_v;
                }


                string
                f_1145_9399_9414(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 9399, 9414);
                    return return_v;
                }


                System.Management.Automation.HelpCategory
                f_1145_9416_9439(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.HelpCategory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 9416, 9439);
                    return return_v;
                }


                System.Management.Automation.HelpInfo
                f_1145_9356_9440(System.Management.Automation.CommandHelpProvider
                this_param, string
                helpFileIdentifier, string
                commandName, System.Management.Automation.HelpCategory
                helpCategory)
                {
                    var return_v = this_param.GetFromCommandCache(helpFileIdentifier, commandName, helpCategory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 9356, 9440);
                    return return_v;
                }


                string
                f_1145_9621_9645(System.Management.Automation.CommandHelpProvider
                this_param, System.Management.Automation.CmdletInfo
                cmdletInfo)
                {
                    var return_v = this_param.FindHelpFile(cmdletInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 9621, 9645);
                    return return_v;
                }


                bool
                f_1145_9673_9703(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 9673, 9703);
                    return return_v;
                }


                bool
                f_1145_9708_9737(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.Contains((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 9708, 9737);
                    return return_v;
                }


                string
                f_1145_9810_9831(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 9810, 9831);
                    return return_v;
                }


                string
                f_1145_9833_9848(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 9833, 9848);
                    return return_v;
                }


                int
                f_1145_9787_9863(System.Management.Automation.CommandHelpProvider
                this_param, string
                helpFile, string
                helpFileIdentifier, string
                commandName, bool
                reportErrors)
                {
                    this_param.LoadHelpFile(helpFile, helpFileIdentifier, commandName, reportErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 9787, 9863);
                    return 0;
                }


                System.Management.Automation.HelpInfo
                f_1145_9920_9963(System.Management.Automation.CommandHelpProvider
                this_param, System.Management.Automation.CmdletInfo
                cmdletInfo)
                {
                    var return_v = this_param.GetFromCommandCacheOrCmdletInfo(cmdletInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 9920, 9963);
                    return return_v;
                }


                string
                f_1145_10163_10184(System.Management.Automation.FunctionInfo
                this_param)
                {
                    var return_v = this_param.HelpFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 10163, 10184);
                    return return_v;
                }


                bool
                f_1145_10208_10238(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 10208, 10238);
                    return return_v;
                }


                bool
                f_1145_10285_10314(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.Contains((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 10285, 10314);
                    return return_v;
                }


                string
                f_1145_10397_10413(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 10397, 10413);
                    return return_v;
                }


                int
                f_1145_10364_10428(System.Management.Automation.CommandHelpProvider
                this_param, string
                helpFile, string
                helpFileIdentifier, string
                commandName, bool
                reportErrors)
                {
                    this_param.LoadHelpFile(helpFile, helpFileIdentifier, commandName, reportErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 10364, 10428);
                    return 0;
                }


                System.Management.Automation.HelpInfo
                f_1145_10485_10527(System.Management.Automation.CommandHelpProvider
                this_param, string
                helpFileIdentifier, System.Management.Automation.CommandInfo
                commandInfo)
                {
                    var return_v = this_param.GetFromCommandCache(helpFileIdentifier, commandInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 10485, 10527);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1145_10843_10872(System.Management.Automation.IScriptCommandInfo
                this_param)
                {
                    var return_v = this_param.ScriptBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 10843, 10872);
                    return return_v;
                }


                System.Management.Automation.HelpSystem
                f_1145_11700_11710()
                {
                    var return_v = HelpSystem;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 11700, 11710);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.Language.Ast, System.Management.Automation.Language.Token[]>
                f_1145_11700_11732(System.Management.Automation.HelpSystem
                this_param)
                {
                    var return_v = this_param.ScriptBlockTokenCache;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 11700, 11732);
                    return return_v;
                }


                System.Management.Automation.HelpInfo
                f_1145_11643_11796(System.Management.Automation.ScriptBlock
                this_param, System.Management.Automation.ExecutionContext
                context, System.Management.Automation.CommandInfo
                commandInfo, bool
                dontSearchOnRemoteComputer, System.Collections.Generic.Dictionary<System.Management.Automation.Language.Ast, System.Management.Automation.Language.Token[]>
                scriptBlockTokenCache, out string
                helpFile, out string
                helpUriFromDotLink)
                {
                    var return_v = this_param.GetHelpInfo(context, commandInfo, dontSearchOnRemoteComputer, scriptBlockTokenCache, out helpFile, out helpUriFromDotLink);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 11643, 11796);
                    return return_v;
                }


                bool
                f_1145_11826_11866(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 11826, 11866);
                    return return_v;
                }


                System.Uri
                f_1145_11990_12017(string
                uriString)
                {
                    var return_v = new System.Uri(uriString);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 11990, 12017);
                    return return_v;
                }


                System.Uri
                f_1145_12413_12441(System.Management.Automation.HelpInfo
                this_param)
                {
                    var return_v = this_param.GetUriForOnlineHelp();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 12413, 12441);
                    return return_v;
                }


                string
                f_1145_12553_12567(System.Uri
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 12553, 12567);
                    return return_v;
                }


                bool
                f_1145_12647_12677(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 12647, 12677);
                    return return_v;
                }


                bool
                f_1145_12780_12809(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.Contains((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 12780, 12809);
                    return return_v;
                }


                string
                f_1145_12900_12916(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 12900, 12916);
                    return return_v;
                }


                int
                f_1145_12867_12931(System.Management.Automation.CommandHelpProvider
                this_param, string
                helpFile, string
                helpFileIdentifier, string
                commandName, bool
                reportErrors)
                {
                    this_param.LoadHelpFile(helpFile, helpFileIdentifier, commandName, reportErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 12867, 12931);
                    return 0;
                }


                System.Management.Automation.HelpInfo
                f_1145_12996_13038(System.Management.Automation.CommandHelpProvider
                this_param, string
                helpFileIdentifier, System.Management.Automation.CommandInfo
                commandInfo)
                {
                    var return_v = this_param.GetFromCommandCache(helpFileIdentifier, commandInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 12996, 13038);
                    return return_v;
                }


                int
                f_1145_13755_13835(System.Management.Automation.CommandHelpProvider
                this_param, System.Management.Automation.CommandInfo
                commandInfo, out string
                moduleName, out string
                moduleDir, out string
                nestedModulePath)
                {
                    this_param.GetModulePaths(commandInfo, out moduleName, out moduleDir, out nestedModulePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 13755, 13835);
                    return 0;
                }


                string
                f_1145_13879_13916()
                {
                    var return_v = HelpUtils.GetUserHomeHelpSearchPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 13879, 13916);
                    return return_v;
                }


                bool
                f_1145_14041_14072(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 14041, 14072);
                    return return_v;
                }


                int
                f_1145_14114_14140(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 14114, 14140);
                    return 0;
                }


                bool
                f_1145_14185_14223(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 14185, 14223);
                    return return_v;
                }


                bool
                f_1145_14228_14260(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 14228, 14260);
                    return return_v;
                }


                string
                f_1145_14318_14360(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 14318, 14360);
                    return return_v;
                }


                int
                f_1145_14302_14361(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 14302, 14361);
                    return 0;
                }


                bool
                f_1145_14406_14438(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 14406, 14438);
                    return return_v;
                }


                bool
                f_1145_14443_14474(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 14443, 14474);
                    return return_v;
                }


                System.Management.Automation.HelpInfo
                f_1145_14677_14770(System.Management.Automation.CommandHelpProvider
                this_param, System.Management.Automation.CommandInfo
                commandInfo, string
                helpFileToFind, System.Collections.ObjectModel.Collection<string>
                searchPaths, bool
                reportErrors, out string
                helpFile)
                {
                    var return_v = this_param.GetHelpInfoFromHelpFile(commandInfo, helpFileToFind, searchPaths, reportErrors, out helpFile);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 14677, 14770);
                    return return_v;
                }


                bool
                f_1145_14833_14871(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 14833, 14871);
                    return return_v;
                }


                string?
                f_1145_15043_15082(string
                path)
                {
                    var return_v = Path.GetDirectoryName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 15043, 15082);
                    return return_v;
                }


                int
                f_1145_15027_15083(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 15027, 15083);
                    return 0;
                }


                string?
                f_1145_15130_15164(string
                path)
                {
                    var return_v = Path.GetFileName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 15130, 15164);
                    return return_v;
                }


                System.Management.Automation.HelpInfo
                f_1145_15210_15303(System.Management.Automation.CommandHelpProvider
                this_param, System.Management.Automation.CommandInfo
                commandInfo, string
                helpFileToFind, System.Collections.ObjectModel.Collection<string>
                searchPaths, bool
                reportErrors, out string
                helpFile)
                {
                    var return_v = this_param.GetHelpInfoFromHelpFile(commandInfo, helpFileToFind, searchPaths, reportErrors, out helpFile);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 15210, 15303);
                    return return_v;
                }


                bool
                f_1145_15462_15492(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 15462, 15492);
                    return return_v;
                }


                System.Management.Automation.CommandTypes
                f_1145_15972_15995(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.CommandType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 15972, 15995);
                    return return_v;
                }


                System.Management.Automation.CommandTypes
                f_1145_16051_16074(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.CommandType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 16051, 16074);
                    return return_v;
                }


                string
                f_1145_16175_16191(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 16175, 16191);
                    return return_v;
                }


                string
                f_1145_16193_16211(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 16193, 16211);
                    return return_v;
                }


                System.Management.Automation.HelpCategory
                f_1145_16213_16237(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.HelpCategory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 16213, 16237);
                    return return_v;
                }


                System.Management.Automation.SyntaxHelpInfo
                f_1145_16148_16238(string
                name, string
                text, System.Management.Automation.HelpCategory
                category)
                {
                    var return_v = SyntaxHelpInfo.GetHelpInfo(name, text, category);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 16148, 16238);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1145_16341_16416(System.Management.Automation.CommandInfo
                input)
                {
                    var return_v = Help.DefaultCommandHelpObjectBuilder.GetPSObjectFromCmdletInfo(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 16341, 16416);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1145_16441_16459(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.TypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 16441, 16459);
                    return return_v;
                }


                int
                f_1145_16441_16467(System.Collections.ObjectModel.Collection<string>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 16441, 16467);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1145_16490_16508(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.TypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 16490, 16508);
                    return return_v;
                }


                int
                f_1145_16490_16568(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 16490, 16568);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1145_16591_16609(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.TypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 16591, 16609);
                    return return_v;
                }


                int
                f_1145_16591_16631(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 16591, 16631);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1145_16654_16672(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.TypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 16654, 16672);
                    return return_v;
                }


                int
                f_1145_16654_16688(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 16654, 16688);
                    return 0;
                }


                System.Management.Automation.HelpCategory
                f_1145_16756_16780(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.HelpCategory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 16756, 16780);
                    return return_v;
                }


                System.Management.Automation.MamlCommandHelpInfo
                f_1145_16722_16781(System.Management.Automation.PSObject
                helpObject, System.Management.Automation.HelpCategory
                helpCategory)
                {
                    var return_v = new System.Management.Automation.MamlCommandHelpInfo(helpObject, helpCategory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 16722, 16781);
                    return return_v;
                }


                System.Uri
                f_1145_16907_16935(System.Management.Automation.HelpInfo
                this_param)
                {
                    var return_v = this_param.GetUriForOnlineHelp();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 16907, 16935);
                    return return_v;
                }


                System.Management.Automation.CommandMetadata
                f_1145_17011_17038(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.CommandMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 17011, 17038);
                    return return_v;
                }


                string
                f_1145_17011_17046(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.HelpUri;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 17011, 17046);
                    return return_v;
                }


                bool
                f_1145_16990_17047(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 16990, 17047);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1145_17155_17170(System.Management.Automation.HelpInfo
                this_param)
                {
                    var return_v = this_param.FullHelp;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 17155, 17170);
                    return return_v;
                }


                System.Management.Automation.CommandMetadata
                f_1145_17172_17199(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.CommandMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 17172, 17199);
                    return return_v;
                }


                string
                f_1145_17172_17207(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.HelpUri;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 17172, 17207);
                    return return_v;
                }


                int
                f_1145_17097_17208(System.Management.Automation.PSObject
                obj, string
                relatedLink)
                {
                    DefaultCommandHelpObjectBuilder.AddRelatedLinksProperties(obj, relatedLink);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 17097, 17208);
                    return 0;
                }


                bool
                f_1145_17264_17293(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 17264, 17293);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1145_17401_17416(System.Management.Automation.HelpInfo
                this_param)
                {
                    var return_v = this_param.FullHelp;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 17401, 17416);
                    return return_v;
                }


                int
                f_1145_17343_17426(System.Management.Automation.PSObject
                obj, string
                relatedLink)
                {
                    DefaultCommandHelpObjectBuilder.AddRelatedLinksProperties(obj, relatedLink);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 17343, 17426);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1145_17505_17520(System.Management.Automation.HelpInfo
                this_param)
                {
                    var return_v = this_param.FullHelp;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 17505, 17520);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1145_17505_17531(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 17505, 17531);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1145_17505_17543(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 17505, 17543);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1145_17593_17608(System.Management.Automation.HelpInfo
                this_param)
                {
                    var return_v = this_param.FullHelp;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 17593, 17608);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1145_17593_17619(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 17593, 17619);
                    return return_v;
                }


                System.Management.Automation.PSSnapInInfo
                f_1145_17655_17674(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.PSSnapIn;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 17655, 17674);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1145_17624_17675(string
                name, System.Management.Automation.PSSnapInInfo
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 17624, 17675);
                    return return_v;
                }


                int
                f_1145_17593_17676(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 17593, 17676);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1145_17720_17735(System.Management.Automation.HelpInfo
                this_param)
                {
                    var return_v = this_param.FullHelp;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 17720, 17735);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1145_17720_17746(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 17720, 17746);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1145_17720_17760(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 17720, 17760);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1145_17810_17825(System.Management.Automation.HelpInfo
                this_param)
                {
                    var return_v = this_param.FullHelp;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 17810, 17825);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1145_17810_17836(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 17810, 17836);
                    return return_v;
                }


                string
                f_1145_17874_17896(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 17874, 17896);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1145_17841_17897(string
                name, string
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 17841, 17897);
                    return return_v;
                }


                int
                f_1145_17810_17898(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 17810, 17898);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1145, 7436, 17974);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1145, 7436, 17974);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override IEnumerable<HelpInfo> ExactMatchHelp(HelpRequest helpRequest)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1145, 18749, 20772);

                var listYield = new List<HelpInfo>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 18853, 18881);

                int
                countHelpInfosFound = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 18895, 18930);

                string
                target = f_1145_18911_18929(helpRequest)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 19016, 19086);

                Hashtable
                hashtable = f_1145_19038_19085(f_1145_19052_19084())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 19102, 19179);

                CommandSearcher
                searcher = f_1145_19129_19178(this, target, _context)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 19195, 20761) || true) && (f_1145_19202_19221(searcher))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 19195, 20761);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 19255, 19322);

                        CommandInfo
                        current = f_1145_19277_19321(((IEnumerator<CommandInfo>)searcher))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 19342, 19616) || true) && (!f_1145_19347_19405(f_1145_19370_19395(helpRequest), current))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 19342, 19616);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 19588, 19597);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 19342, 19616);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 19636, 19690);

                        HelpInfo
                        helpInfo = f_1145_19656_19689(this, current, true, false)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 19708, 19747);

                        string
                        helpName = f_1145_19726_19746(this, current)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 19767, 20746) || true) && (helpInfo != null && (DynAbs.Tracing.TraceSender.Expression_True(1145, 19771, 19822) && !f_1145_19792_19822(helpName)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 19767, 20746);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 19864, 20196) || true) && (f_1145_19868_19896(helpInfo) == f_1145_19900_19924(helpRequest) && (DynAbs.Tracing.TraceSender.Expression_True(1145, 19868, 20038) && f_1145_19953_20038(f_1145_19953_19975(helpInfo), f_1145_19983_20001(helpRequest), StringComparison.OrdinalIgnoreCase)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 19864, 20196);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 20088, 20173);

                                throw f_1145_20094_20172(f_1145_20126_20171());
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 19864, 20196);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 20220, 20291) || true) && (f_1145_20224_20255(hashtable, helpName))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 20220, 20291);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 20282, 20291);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 20220, 20291);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 20315, 20439) || true) && (!f_1145_20320_20357(helpInfo, helpRequest, current))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 20315, 20439);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 20407, 20416);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 20315, 20439);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 20463, 20485);

                            countHelpInfosFound++;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 20507, 20537);

                            f_1145_20507_20536(hashtable, helpName, null);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 20559, 20581);

                            listYield.Add(helpInfo);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 20605, 20727) || true) && ((countHelpInfosFound >= f_1145_20633_20655(helpRequest)) && (DynAbs.Tracing.TraceSender.Expression_True(1145, 20609, 20688) && (f_1145_20661_20683(helpRequest) > 0)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 20605, 20727);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 20715, 20727);

                                return listYield;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 20605, 20727);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 19767, 20746);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 19195, 20761);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1145, 19195, 20761);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1145, 19195, 20761);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1145, 18749, 20772);

                return listYield;

                string
                f_1145_18911_18929(System.Management.Automation.HelpRequest
                this_param)
                {
                    var return_v = this_param.Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 18911, 18929);
                    return return_v;
                }


                System.StringComparer
                f_1145_19052_19084()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 19052, 19084);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1145_19038_19085(System.StringComparer
                equalityComparer)
                {
                    var return_v = new System.Collections.Hashtable((System.Collections.IEqualityComparer)equalityComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 19038, 19085);
                    return return_v;
                }


                System.Management.Automation.CommandSearcher
                f_1145_19129_19178(System.Management.Automation.CommandHelpProvider
                this_param, string
                commandName, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = this_param.GetCommandSearcherForExactMatch(commandName, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 19129, 19178);
                    return return_v;
                }


                bool
                f_1145_19202_19221(System.Management.Automation.CommandSearcher
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 19202, 19221);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1145_19277_19321(System.Collections.Generic.IEnumerator<System.Management.Automation.CommandInfo>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 19277, 19321);
                    return return_v;
                }


                System.Management.Automation.CommandOrigin
                f_1145_19370_19395(System.Management.Automation.HelpRequest
                this_param)
                {
                    var return_v = this_param.CommandOrigin;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 19370, 19395);
                    return return_v;
                }


                bool
                f_1145_19347_19405(System.Management.Automation.CommandOrigin
                origin, System.Management.Automation.CommandInfo
                commandInfo)
                {
                    var return_v = SessionState.IsVisible(origin, commandInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 19347, 19405);
                    return return_v;
                }


                System.Management.Automation.HelpInfo
                f_1145_19656_19689(System.Management.Automation.CommandHelpProvider
                this_param, System.Management.Automation.CommandInfo
                commandInfo, bool
                reportErrors, bool
                searchOnlyContent)
                {
                    var return_v = this_param.GetHelpInfo(commandInfo, reportErrors, searchOnlyContent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 19656, 19689);
                    return return_v;
                }


                string
                f_1145_19726_19746(System.Management.Automation.CommandHelpProvider
                this_param, System.Management.Automation.CommandInfo
                commandInfo)
                {
                    var return_v = this_param.GetHelpName(commandInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 19726, 19746);
                    return return_v;
                }


                bool
                f_1145_19792_19822(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 19792, 19822);
                    return return_v;
                }


                System.Management.Automation.HelpCategory
                f_1145_19868_19896(System.Management.Automation.HelpInfo
                this_param)
                {
                    var return_v = this_param.ForwardHelpCategory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 19868, 19896);
                    return return_v;
                }


                System.Management.Automation.HelpCategory
                f_1145_19900_19924(System.Management.Automation.HelpRequest
                this_param)
                {
                    var return_v = this_param.HelpCategory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 19900, 19924);
                    return return_v;
                }


                string
                f_1145_19953_19975(System.Management.Automation.HelpInfo
                this_param)
                {
                    var return_v = this_param.ForwardTarget;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 19953, 19975);
                    return return_v;
                }


                string
                f_1145_19983_20001(System.Management.Automation.HelpRequest
                this_param)
                {
                    var return_v = this_param.Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 19983, 20001);
                    return return_v;
                }


                bool
                f_1145_19953_20038(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 19953, 20038);
                    return return_v;
                }


                string
                f_1145_20126_20171()
                {
                    var return_v = HelpErrors.CircularDependencyInHelpForwarding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 20126, 20171);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1145_20094_20172(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 20094, 20172);
                    return return_v;
                }


                bool
                f_1145_20224_20255(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 20224, 20255);
                    return return_v;
                }


                bool
                f_1145_20320_20357(System.Management.Automation.HelpInfo
                helpInfo, System.Management.Automation.HelpRequest
                helpRequest, System.Management.Automation.CommandInfo
                commandInfo)
                {
                    var return_v = Match(helpInfo, helpRequest, commandInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 20320, 20357);
                    return return_v;
                }


                int
                f_1145_20507_20536(System.Collections.Hashtable
                this_param, string
                key, object?
                value)
                {
                    this_param.Add((object)key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 20507, 20536);
                    return 0;
                }


                int
                f_1145_20633_20655(System.Management.Automation.HelpRequest
                this_param)
                {
                    var return_v = this_param.MaxResults;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 20633, 20655);
                    return return_v;
                }


                int
                f_1145_20661_20683(System.Management.Automation.HelpRequest
                this_param)
                {
                    var return_v = this_param.MaxResults;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 20661, 20683);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1145, 18749, 20772);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1145, 18749, 20772);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string GetCmdletAssemblyPath(CmdletInfo cmdletInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1145, 20784, 21117);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 20875, 20928) || true) && (cmdletInfo == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 20875, 20928);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 20916, 20928);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 20875, 20928);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 20944, 21014) || true) && (f_1145_20948_20975(cmdletInfo) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 20944, 21014);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 21002, 21014);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 20944, 21014);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 21030, 21106);

                return f_1145_21037_21105(f_1145_21059_21104(f_1145_21059_21095(f_1145_21059_21086(cmdletInfo))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1145, 20784, 21117);

                System.Type
                f_1145_20948_20975(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.ImplementingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 20948, 20975);
                    return return_v;
                }


                System.Type
                f_1145_21059_21086(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.ImplementingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 21059, 21086);
                    return return_v;
                }


                System.Reflection.Assembly
                f_1145_21059_21095(System.Type
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 21059, 21095);
                    return return_v;
                }


                string
                f_1145_21059_21104(System.Reflection.Assembly
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 21059, 21104);
                    return return_v;
                }


                string?
                f_1145_21037_21105(string
                path)
                {
                    var return_v = Path.GetDirectoryName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 21037, 21105);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1145, 20784, 21117);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1145, 20784, 21117);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private readonly Hashtable _helpFiles;

        private string GetHelpFile(string helpFile, CmdletInfo cmdletInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1145, 21560, 24234);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 21651, 21684);

                string
                helpFileToLoad = helpFile
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 21760, 21809);

                PSSnapInInfo
                mshSnapInInfo = f_1145_21789_21808(cmdletInfo)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 22163, 22221);

                Collection<string>
                searchPaths = f_1145_22196_22220()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 22237, 23820) || true) && (!f_1145_22242_22269(helpFileToLoad))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 22237, 23820);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 22303, 22353);

                    helpFileToLoad = f_1145_22320_22352(helpFileToLoad);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 22373, 23689) || true) && (mshSnapInInfo != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 22373, 23689);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 22440, 22576);

                        f_1145_22440_22575(!f_1145_22460_22511(f_1145_22481_22510(mshSnapInInfo)), "Application Base is null or empty.");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 22878, 22933);

                        f_1145_22878_22932(                    // not minishell case..
                                                               // we have to search only in the application base for a mshsnapin...
                                                               // if you create an absolute path for helpfile, then MUIFileSearcher
                                                               // will look only in that path.

                                            searchPaths, f_1145_22894_22931());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 22955, 23002);

                        f_1145_22955_23001(searchPaths, f_1145_22971_23000(mshSnapInInfo));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 22373, 23689);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 22373, 23689);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 23044, 23689) || true) && (f_1145_23048_23065(cmdletInfo) != null && (DynAbs.Tracing.TraceSender.Expression_True(1145, 23048, 23122) && !f_1145_23078_23122(f_1145_23099_23121(f_1145_23099_23116(cmdletInfo)))) && (DynAbs.Tracing.TraceSender.Expression_True(1145, 23048, 23177) && !f_1145_23127_23177(f_1145_23148_23176(f_1145_23148_23165(cmdletInfo)))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 23044, 23689);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 23219, 23325);

                            f_1145_23219_23324(searchPaths, f_1145_23235_23323(f_1145_23270_23298(f_1145_23270_23287(cmdletInfo)), f_1145_23300_23322(f_1145_23300_23317(cmdletInfo))));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 23347, 23393);

                            f_1145_23347_23392(searchPaths, f_1145_23363_23391(f_1145_23363_23380(cmdletInfo)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 23044, 23689);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 23044, 23689);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 23475, 23530);

                            f_1145_23475_23529(searchPaths, f_1145_23491_23528());
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 23552, 23597);

                            f_1145_23552_23596(searchPaths, f_1145_23568_23595(this));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 23619, 23670);

                            f_1145_23619_23669(searchPaths, f_1145_23635_23668(cmdletInfo));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 23044, 23689);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 22373, 23689);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 22237, 23820);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 22237, 23820);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 23755, 23805);

                    helpFileToLoad = f_1145_23772_23804(helpFileToLoad);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 22237, 23820);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 23836, 23910);

                string
                location = f_1145_23854_23909(helpFileToLoad, searchPaths)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 24046, 24191) || true) && (f_1145_24050_24080(location))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 24046, 24191);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 24114, 24176);

                    f_1145_24114_24175(s_tracer, "Unable to load file {0}", helpFileToLoad);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 24046, 24191);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 24207, 24223);

                return location;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1145, 21560, 24234);

                System.Management.Automation.PSSnapInInfo
                f_1145_21789_21808(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.PSSnapIn;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 21789, 21808);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1145_22196_22220()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 22196, 22220);
                    return return_v;
                }


                bool
                f_1145_22242_22269(string
                path)
                {
                    var return_v = File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 22242, 22269);
                    return return_v;
                }


                string?
                f_1145_22320_22352(string
                path)
                {
                    var return_v = Path.GetFileName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 22320, 22352);
                    return return_v;
                }


                string
                f_1145_22481_22510(System.Management.Automation.PSSnapInInfo
                this_param)
                {
                    var return_v = this_param.ApplicationBase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 22481, 22510);
                    return return_v;
                }


                bool
                f_1145_22460_22511(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 22460, 22511);
                    return return_v;
                }


                int
                f_1145_22440_22575(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 22440, 22575);
                    return 0;
                }


                string
                f_1145_22894_22931()
                {
                    var return_v = HelpUtils.GetUserHomeHelpSearchPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 22894, 22931);
                    return return_v;
                }


                int
                f_1145_22878_22932(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 22878, 22932);
                    return 0;
                }


                string
                f_1145_22971_23000(System.Management.Automation.PSSnapInInfo
                this_param)
                {
                    var return_v = this_param.ApplicationBase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 22971, 23000);
                    return return_v;
                }


                int
                f_1145_22955_23001(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 22955, 23001);
                    return 0;
                }


                System.Management.Automation.PSModuleInfo
                f_1145_23048_23065(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 23048, 23065);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1145_23099_23116(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 23099, 23116);
                    return return_v;
                }


                string
                f_1145_23099_23121(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 23099, 23121);
                    return return_v;
                }


                bool
                f_1145_23078_23122(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 23078, 23122);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1145_23148_23165(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 23148, 23165);
                    return return_v;
                }


                string
                f_1145_23148_23176(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.ModuleBase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 23148, 23176);
                    return return_v;
                }


                bool
                f_1145_23127_23177(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 23127, 23177);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1145_23270_23287(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 23270, 23287);
                    return return_v;
                }


                string
                f_1145_23270_23298(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.ModuleBase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 23270, 23298);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1145_23300_23317(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 23300, 23317);
                    return return_v;
                }


                string
                f_1145_23300_23322(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 23300, 23322);
                    return return_v;
                }


                string
                f_1145_23235_23323(string
                moduleBase, string
                moduleName)
                {
                    var return_v = HelpUtils.GetModuleBaseForUserHelp(moduleBase, moduleName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 23235, 23323);
                    return return_v;
                }


                int
                f_1145_23219_23324(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 23219, 23324);
                    return 0;
                }


                System.Management.Automation.PSModuleInfo
                f_1145_23363_23380(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 23363, 23380);
                    return return_v;
                }


                string
                f_1145_23363_23391(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.ModuleBase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 23363, 23391);
                    return return_v;
                }


                int
                f_1145_23347_23392(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 23347, 23392);
                    return 0;
                }


                string
                f_1145_23491_23528()
                {
                    var return_v = HelpUtils.GetUserHomeHelpSearchPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 23491, 23528);
                    return return_v;
                }


                int
                f_1145_23475_23529(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 23475, 23529);
                    return 0;
                }


                string
                f_1145_23568_23595(System.Management.Automation.CommandHelpProvider
                this_param)
                {
                    var return_v = this_param.GetDefaultShellSearchPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 23568, 23595);
                    return return_v;
                }


                int
                f_1145_23552_23596(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 23552, 23596);
                    return 0;
                }


                string
                f_1145_23635_23668(System.Management.Automation.CmdletInfo
                cmdletInfo)
                {
                    var return_v = GetCmdletAssemblyPath(cmdletInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 23635, 23668);
                    return return_v;
                }


                int
                f_1145_23619_23669(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 23619, 23669);
                    return 0;
                }


                string
                f_1145_23772_23804(string
                path)
                {
                    var return_v = Path.GetFullPath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 23772, 23804);
                    return return_v;
                }


                string
                f_1145_23854_23909(string
                file, System.Collections.ObjectModel.Collection<string>
                searchPaths)
                {
                    var return_v = MUIFileSearcher.LocateFile(file, searchPaths);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 23854, 23909);
                    return return_v;
                }


                bool
                f_1145_24050_24080(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 24050, 24080);
                    return return_v;
                }


                int
                f_1145_24114_24175(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 24114, 24175);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1145, 21560, 24234);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1145, 21560, 24234);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string FindHelpFile(CmdletInfo cmdletInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1145, 24438, 28113);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 24513, 24820) || true) && (InternalTestHooks.BypassOnlineHelpRetrieval)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 24513, 24820);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 24793, 24805);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 24513, 24820);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 24836, 24966) || true) && (cmdletInfo == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 24836, 24966);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 24892, 24951);

                    throw f_1145_24898_24950("cmdletInfo");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 24836, 24966);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 25046, 25084);

                string
                helpFile = f_1145_25064_25083(cmdletInfo)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 25100, 25590) || true) && (f_1145_25104_25134(helpFile))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 25100, 25590);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 25168, 25539) || true) && (f_1145_25172_25189(cmdletInfo) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 25168, 25539);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 25239, 25520) || true) && (f_1145_25243_25301(f_1145_25278_25300(f_1145_25278_25295(cmdletInfo))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 25239, 25520);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 25351, 25497);

                            return f_1145_25358_25496(f_1145_25381_25409(f_1145_25381_25398(cmdletInfo)), f_1145_25411_25442(f_1145_25411_25437()), f_1145_25444_25495(s_engineModuleHelpFileCache, f_1145_25472_25494(f_1145_25472_25489(cmdletInfo))));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 25239, 25520);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 25168, 25539);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 25559, 25575);

                    return helpFile;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 25100, 25590);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 25657, 25680);

                string
                location = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 25696, 28070) || true) && (f_1145_25700_25773(helpFile, ".ni.dll-Help.xml", StringComparison.OrdinalIgnoreCase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 25696, 28070);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 26823, 26896);

                    string
                    assemblyName = f_1145_26845_26895(helpFile, ".ni.dll-Help.xml", string.Empty)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 26916, 27944) || true) && (!f_1145_26921_26955(assemblyName))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 26916, 27944);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 27130, 27217);

                        string
                        helpFileName = f_1145_27152_27216(f_1145_27152_27171(cmdletInfo), ".ni.dll-Help.xml", ".dll-Help.xml")
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 27239, 27288);

                        location = f_1145_27250_27287(this, helpFileName, cmdletInfo);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 27312, 27733) || true) && (f_1145_27316_27346(location))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 27312, 27733);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 27665, 27710);

                            location = f_1145_27676_27709(this, helpFile, cmdletInfo);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 27312, 27733);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 26916, 27944);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 26916, 27944);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 27880, 27925);

                        location = f_1145_27891_27924(this, helpFile, cmdletInfo);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 26916, 27944);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 25696, 28070);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 25696, 28070);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 28010, 28055);

                    location = f_1145_28021_28054(this, helpFile, cmdletInfo);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 25696, 28070);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 28086, 28102);

                return location;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1145, 24438, 28113);

                System.Management.Automation.PSArgumentNullException
                f_1145_24898_24950(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 24898, 24950);
                    return return_v;
                }


                string
                f_1145_25064_25083(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.HelpFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 25064, 25083);
                    return return_v;
                }


                bool
                f_1145_25104_25134(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 25104, 25134);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1145_25172_25189(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 25172, 25189);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1145_25278_25295(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 25278, 25295);
                    return return_v;
                }


                string
                f_1145_25278_25300(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 25278, 25300);
                    return return_v;
                }


                bool
                f_1145_25243_25301(string
                moduleName)
                {
                    var return_v = InitialSessionState.IsEngineModule(moduleName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 25243, 25301);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1145_25381_25398(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 25381, 25398);
                    return return_v;
                }


                string
                f_1145_25381_25409(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.ModuleBase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 25381, 25409);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1145_25411_25437()
                {
                    var return_v = CultureInfo.CurrentCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 25411, 25437);
                    return return_v;
                }


                string
                f_1145_25411_25442(System.Globalization.CultureInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 25411, 25442);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1145_25472_25489(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 25472, 25489);
                    return return_v;
                }


                string
                f_1145_25472_25494(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 25472, 25494);
                    return return_v;
                }


                string
                f_1145_25444_25495(System.Collections.Generic.Dictionary<string, string>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 25444, 25495);
                    return return_v;
                }


                string
                f_1145_25358_25496(string
                path1, string
                path2, string
                path3)
                {
                    var return_v = System.IO.Path.Combine(path1, path2, path3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 25358, 25496);
                    return return_v;
                }


                bool
                f_1145_25700_25773(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.EndsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 25700, 25773);
                    return return_v;
                }


                string
                f_1145_26845_26895(string
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 26845, 26895);
                    return return_v;
                }


                bool
                f_1145_26921_26955(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 26921, 26955);
                    return return_v;
                }


                string
                f_1145_27152_27171(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.HelpFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 27152, 27171);
                    return return_v;
                }


                string
                f_1145_27152_27216(string
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 27152, 27216);
                    return return_v;
                }


                string
                f_1145_27250_27287(System.Management.Automation.CommandHelpProvider
                this_param, string
                helpFile, System.Management.Automation.CmdletInfo
                cmdletInfo)
                {
                    var return_v = this_param.GetHelpFile(helpFile, cmdletInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 27250, 27287);
                    return return_v;
                }


                bool
                f_1145_27316_27346(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 27316, 27346);
                    return return_v;
                }


                string
                f_1145_27676_27709(System.Management.Automation.CommandHelpProvider
                this_param, string
                helpFile, System.Management.Automation.CmdletInfo
                cmdletInfo)
                {
                    var return_v = this_param.GetHelpFile(helpFile, cmdletInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 27676, 27709);
                    return return_v;
                }


                string
                f_1145_27891_27924(System.Management.Automation.CommandHelpProvider
                this_param, string
                helpFile, System.Management.Automation.CmdletInfo
                cmdletInfo)
                {
                    var return_v = this_param.GetHelpFile(helpFile, cmdletInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 27891, 27924);
                    return return_v;
                }


                string
                f_1145_28021_28054(System.Management.Automation.CommandHelpProvider
                this_param, string
                helpFile, System.Management.Automation.CmdletInfo
                cmdletInfo)
                {
                    var return_v = this_param.GetHelpFile(helpFile, cmdletInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 28021, 28054);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1145, 24438, 28113);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1145, 24438, 28113);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void LoadHelpFile(string helpFile, string helpFileIdentifier, string commandName, bool reportErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1145, 28125, 29349);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 28258, 28277);

                Exception
                e = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 28327, 28370);

                    f_1145_28327_28369(this, helpFile, helpFileIdentifier);
                }
                catch (IOException ioException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1145, 28399, 28494);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 28463, 28479);

                    e = ioException;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1145, 28399, 28494);
                }
                catch (System.Security.SecurityException securityException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1145, 28508, 28637);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 28600, 28622);

                    e = securityException;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1145, 28508, 28637);
                }
                catch (XmlException xmlException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1145, 28651, 28749);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 28717, 28734);

                    e = xmlException;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1145, 28651, 28749);
                }
                catch (NotSupportedException notSupportedException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1145, 28763, 28888);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 28847, 28873);

                    e = notSupportedException;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1145, 28763, 28888);
                }
                catch (UnauthorizedAccessException unauthorizedAccessException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1145, 28902, 29045);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 28998, 29030);

                    e = unauthorizedAccessException;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1145, 28902, 29045);
                }
                catch (InvalidOperationException invalidOperationException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1145, 29059, 29196);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 29151, 29181);

                    e = invalidOperationException;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1145, 29059, 29196);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 29212, 29338) || true) && (reportErrors && (DynAbs.Tracing.TraceSender.Expression_True(1145, 29216, 29243) && (e != null)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 29212, 29338);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 29277, 29323);

                    f_1145_29277_29322(this, e, commandName, helpFile);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 29212, 29338);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1145, 28125, 29349);

                int
                f_1145_28327_28369(System.Management.Automation.CommandHelpProvider
                this_param, string
                helpFile, string
                helpFileIdentifier)
                {
                    this_param.LoadHelpFile(helpFile, helpFileIdentifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 28327, 28369);
                    return 0;
                }


                int
                f_1145_29277_29322(System.Management.Automation.CommandHelpProvider
                this_param, System.Exception
                exception, string
                target, string
                helpFile)
                {
                    this_param.ReportHelpFileError(exception, target, helpFile);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 29277, 29322);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1145, 28125, 29349);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1145, 28125, 29349);
            }
        }

        private void LoadHelpFile(string helpFile, string helpFileIdentifier)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1145, 29877, 32694);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 29971, 30161);

                XmlDocument
                doc = f_1145_29989_30160(f_1145_30050_30072(helpFile), false, null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 30305, 30330);

                _helpFiles[helpFile] = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 30346, 30375);

                XmlNode
                helpItemsNode = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 30391, 30876) || true) && (f_1145_30395_30412(doc))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 30391, 30876);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 30455, 30460);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 30446, 30861) || true) && (i < f_1145_30466_30486(f_1145_30466_30480(doc)))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 30488, 30491)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 30446, 30861))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 30446, 30861);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 30533, 30566);

                            XmlNode
                            node = f_1145_30548_30565(f_1145_30548_30562(doc), i)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 30588, 30842) || true) && (f_1145_30592_30605(node) == XmlNodeType.Element && (DynAbs.Tracing.TraceSender.Expression_True(1145, 30592, 30716) && f_1145_30632_30711(f_1145_30647_30661(node), "helpItems", StringComparison.OrdinalIgnoreCase) == 0))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 30588, 30842);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 30766, 30787);

                                helpItemsNode = node;
                                DynAbs.Tracing.TraceSender.TraceBreak(1145, 30813, 30819);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 30588, 30842);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1145, 1, 416);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1145, 1, 416);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 30391, 30876);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 30892, 31070) || true) && (helpItemsNode == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 30892, 31070);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 30951, 31030);

                    f_1145_30951_31029(s_tracer, "Unable to find 'helpItems' element in file {0}", helpFile);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 31048, 31055);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 30892, 31070);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 31086, 31136);

                bool
                isMaml = f_1145_31100_31135(helpFile, helpItemsNode)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 31152, 32683);
                using (f_1145_31159_31190(f_1145_31159_31174(this), helpFile))
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 31224, 32668) || true) && (f_1145_31228_31255(helpItemsNode))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 31224, 32668);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 31306, 31311);
                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 31297, 32649) || true) && (i < f_1145_31317_31347(f_1145_31317_31341(helpItemsNode)))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 31349, 31352)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 31297, 32649))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 31297, 32649);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 31402, 31445);

                                XmlNode
                                node = f_1145_31417_31444(f_1145_31417_31441(helpItemsNode), i)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 31471, 32211) || true) && (f_1145_31475_31488(node) == XmlNodeType.Element && (DynAbs.Tracing.TraceSender.Expression_True(1145, 31475, 31597) && f_1145_31515_31592(f_1145_31530_31544(node), "command", StringComparison.OrdinalIgnoreCase) == 0))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 31471, 32211);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 31655, 31691);

                                    MamlCommandHelpInfo
                                    helpInfo = null
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 31723, 31893) || true) && (isMaml)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 31723, 31893);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 31799, 31862);

                                        helpInfo = f_1145_31810_31861(node, HelpCategory.Cmdlet);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 31723, 31893);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 31925, 32184) || true) && (helpInfo != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 31925, 32184);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 32011, 32056);

                                        f_1145_32011_32055(f_1145_32011_32026(this), f_1145_32039_32054(helpInfo));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 32090, 32153);

                                        f_1145_32090_32152(this, helpFileIdentifier, f_1145_32128_32141(helpInfo), helpInfo);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 31925, 32184);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 31471, 32211);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 32239, 32626) || true) && (f_1145_32243_32256(node) == XmlNodeType.Element && (DynAbs.Tracing.TraceSender.Expression_True(1145, 32243, 32368) && f_1145_32283_32363(f_1145_32298_32307(node), "UserDefinedData", StringComparison.OrdinalIgnoreCase) == 0))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 32239, 32626);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 32426, 32499);

                                    UserDefinedHelpData
                                    userDefinedHelpData = f_1145_32468_32498(node)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 32531, 32599);

                                    f_1145_32531_32598(this, helpFileIdentifier, userDefinedHelpData);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 32239, 32626);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1145, 1, 1353);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1145, 1, 1353);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 31224, 32668);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1145, 31152, 32683);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1145, 29877, 32694);

                System.IO.FileInfo
                f_1145_30050_30072(string
                fileName)
                {
                    var return_v = new System.IO.FileInfo(fileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 30050, 30072);
                    return return_v;
                }


                System.Xml.XmlDocument
                f_1145_29989_30160(System.IO.FileInfo
                xmlPath, bool
                preserveNonElements, int?
                maxCharactersInDocument)
                {
                    var return_v = InternalDeserializer.LoadUnsafeXmlDocument(xmlPath, preserveNonElements, maxCharactersInDocument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 29989, 30160);
                    return return_v;
                }


                bool
                f_1145_30395_30412(System.Xml.XmlDocument
                this_param)
                {
                    var return_v = this_param.HasChildNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 30395, 30412);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_1145_30466_30480(System.Xml.XmlDocument
                this_param)
                {
                    var return_v = this_param.ChildNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 30466, 30480);
                    return return_v;
                }


                int
                f_1145_30466_30486(System.Xml.XmlNodeList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 30466, 30486);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_1145_30548_30562(System.Xml.XmlDocument
                this_param)
                {
                    var return_v = this_param.ChildNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 30548, 30562);
                    return return_v;
                }


                System.Xml.XmlNode
                f_1145_30548_30565(System.Xml.XmlNodeList
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 30548, 30565);
                    return return_v;
                }


                System.Xml.XmlNodeType
                f_1145_30592_30605(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.NodeType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 30592, 30605);
                    return return_v;
                }


                string
                f_1145_30647_30661(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.LocalName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 30647, 30661);
                    return return_v;
                }


                int
                f_1145_30632_30711(string
                strA, string
                strB, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Compare(strA, strB, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 30632, 30711);
                    return return_v;
                }


                int
                f_1145_30951_31029(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 30951, 31029);
                    return 0;
                }


                bool
                f_1145_31100_31135(string
                helpFile, System.Xml.XmlNode
                helpItemsNode)
                {
                    var return_v = IsMamlHelp(helpFile, helpItemsNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 31100, 31135);
                    return return_v;
                }


                System.Management.Automation.HelpSystem
                f_1145_31159_31174(System.Management.Automation.CommandHelpProvider
                this_param)
                {
                    var return_v = this_param.HelpSystem;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 31159, 31174);
                    return return_v;
                }


                System.IDisposable
                f_1145_31159_31190(System.Management.Automation.HelpSystem
                this_param, string
                helpFile)
                {
                    var return_v = this_param.Trace(helpFile);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 31159, 31190);
                    return return_v;
                }


                bool
                f_1145_31228_31255(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.HasChildNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 31228, 31255);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_1145_31317_31341(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.ChildNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 31317, 31341);
                    return return_v;
                }


                int
                f_1145_31317_31347(System.Xml.XmlNodeList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 31317, 31347);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_1145_31417_31441(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.ChildNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 31417, 31441);
                    return return_v;
                }


                System.Xml.XmlNode
                f_1145_31417_31444(System.Xml.XmlNodeList
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 31417, 31444);
                    return return_v;
                }


                System.Xml.XmlNodeType
                f_1145_31475_31488(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.NodeType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 31475, 31488);
                    return return_v;
                }


                string
                f_1145_31530_31544(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.LocalName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 31530, 31544);
                    return return_v;
                }


                int
                f_1145_31515_31592(string
                strA, string
                strB, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Compare(strA, strB, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 31515, 31592);
                    return return_v;
                }


                System.Management.Automation.MamlCommandHelpInfo
                f_1145_31810_31861(System.Xml.XmlNode
                xmlNode, System.Management.Automation.HelpCategory
                helpCategory)
                {
                    var return_v = MamlCommandHelpInfo.Load(xmlNode, helpCategory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 31810, 31861);
                    return return_v;
                }


                System.Management.Automation.HelpSystem
                f_1145_32011_32026(System.Management.Automation.CommandHelpProvider
                this_param)
                {
                    var return_v = this_param.HelpSystem;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 32011, 32026);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
                f_1145_32039_32054(System.Management.Automation.MamlCommandHelpInfo
                this_param)
                {
                    var return_v = this_param.Errors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 32039, 32054);
                    return return_v;
                }


                int
                f_1145_32011_32055(System.Management.Automation.HelpSystem
                this_param, System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
                errorRecords)
                {
                    this_param.TraceErrors(errorRecords);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 32011, 32055);
                    return 0;
                }


                string
                f_1145_32128_32141(System.Management.Automation.MamlCommandHelpInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 32128, 32141);
                    return return_v;
                }


                int
                f_1145_32090_32152(System.Management.Automation.CommandHelpProvider
                this_param, string
                mshSnapInId, string
                cmdletName, System.Management.Automation.MamlCommandHelpInfo
                helpInfo)
                {
                    this_param.AddToCommandCache(mshSnapInId, cmdletName, helpInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 32090, 32152);
                    return 0;
                }


                System.Xml.XmlNodeType
                f_1145_32243_32256(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.NodeType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 32243, 32256);
                    return return_v;
                }


                string
                f_1145_32298_32307(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 32298, 32307);
                    return return_v;
                }


                int
                f_1145_32283_32363(string
                strA, string
                strB, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Compare(strA, strB, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 32283, 32363);
                    return return_v;
                }


                System.Management.Automation.UserDefinedHelpData
                f_1145_32468_32498(System.Xml.XmlNode
                dataNode)
                {
                    var return_v = UserDefinedHelpData.Load(dataNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 32468, 32498);
                    return return_v;
                }


                int
                f_1145_32531_32598(System.Management.Automation.CommandHelpProvider
                this_param, string
                mshSnapInId, System.Management.Automation.UserDefinedHelpData
                userDefinedHelpData)
                {
                    this_param.ProcessUserDefinedHelpData(mshSnapInId, userDefinedHelpData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 32531, 32598);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1145, 29877, 32694);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1145, 29877, 32694);
            }
        }

        private void ProcessUserDefinedHelpData(string mshSnapInId, UserDefinedHelpData userDefinedHelpData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1145, 33047, 33760);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 33172, 33229) || true) && (userDefinedHelpData == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 33172, 33229);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 33222, 33229);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 33172, 33229);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 33245, 33321) || true) && (f_1145_33249_33295(f_1145_33270_33294(userDefinedHelpData)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 33245, 33321);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 33314, 33321);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 33245, 33321);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 33337, 33437);

                HelpInfo
                helpInfo = f_1145_33357_33436(this, mshSnapInId, f_1145_33390_33414(userDefinedHelpData), HelpCategory.Cmdlet)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 33453, 33499) || true) && (helpInfo == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 33453, 33499);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 33492, 33499);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 33453, 33499);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 33515, 33585);

                MamlCommandHelpInfo
                commandHelpInfo = helpInfo as MamlCommandHelpInfo
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 33601, 33654) || true) && (commandHelpInfo == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 33601, 33654);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 33647, 33654);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 33601, 33654);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 33670, 33726);

                f_1145_33670_33725(
                            commandHelpInfo, userDefinedHelpData);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 33742, 33749);

                return;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1145, 33047, 33760);

                string
                f_1145_33270_33294(System.Management.Automation.UserDefinedHelpData
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 33270, 33294);
                    return return_v;
                }


                bool
                f_1145_33249_33295(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 33249, 33295);
                    return return_v;
                }


                string
                f_1145_33390_33414(System.Management.Automation.UserDefinedHelpData
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 33390, 33414);
                    return return_v;
                }


                System.Management.Automation.HelpInfo
                f_1145_33357_33436(System.Management.Automation.CommandHelpProvider
                this_param, string
                helpFileIdentifier, string
                commandName, System.Management.Automation.HelpCategory
                helpCategory)
                {
                    var return_v = this_param.GetFromCommandCache(helpFileIdentifier, commandName, helpCategory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 33357, 33436);
                    return return_v;
                }


                int
                f_1145_33670_33725(System.Management.Automation.MamlCommandHelpInfo
                this_param, System.Management.Automation.UserDefinedHelpData
                userDefinedData)
                {
                    this_param.AddUserDefinedData(userDefinedData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 33670, 33725);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1145, 33047, 33760);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1145, 33047, 33760);
            }
        }

        private HelpInfo GetFromCommandCache(string helpFileIdentifier, string commandName, HelpCategory helpCategory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1145, 34188, 35039);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 34323, 34416);

                f_1145_34323_34415(!f_1145_34337_34370(commandName), "Cmdlet Name should not be null or empty.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 34432, 34457);

                string
                key = commandName
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 34471, 34603) || true) && (!f_1145_34476_34516(helpFileIdentifier))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 34471, 34603);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 34550, 34588);

                    key = helpFileIdentifier + "\\" + key;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 34471, 34603);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 34619, 34651);

                HelpInfo
                result = f_1145_34637_34650(this, key)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 34774, 34998) || true) && ((result != null) && (DynAbs.Tracing.TraceSender.Expression_True(1145, 34778, 34835) && (f_1145_34799_34818(result) != helpCategory)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 34774, 34998);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 34869, 34928);

                    MamlCommandHelpInfo
                    original = (MamlCommandHelpInfo)result
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 34946, 34983);

                    result = f_1145_34955_34982(original, helpCategory);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 34774, 34998);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 35014, 35028);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1145, 34188, 35039);

                bool
                f_1145_34337_34370(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 34337, 34370);
                    return return_v;
                }


                int
                f_1145_34323_34415(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 34323, 34415);
                    return 0;
                }


                bool
                f_1145_34476_34516(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 34476, 34516);
                    return return_v;
                }


                System.Management.Automation.HelpInfo
                f_1145_34637_34650(System.Management.Automation.CommandHelpProvider
                this_param, string
                target)
                {
                    var return_v = this_param.GetCache(target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 34637, 34650);
                    return return_v;
                }


                System.Management.Automation.HelpCategory
                f_1145_34799_34818(System.Management.Automation.HelpInfo
                this_param)
                {
                    var return_v = this_param.HelpCategory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 34799, 34818);
                    return return_v;
                }


                System.Management.Automation.MamlCommandHelpInfo
                f_1145_34955_34982(System.Management.Automation.MamlCommandHelpInfo
                this_param, System.Management.Automation.HelpCategory
                newCategoryToUse)
                {
                    var return_v = this_param.Copy(newCategoryToUse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 34955, 34982);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1145, 34188, 35039);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1145, 34188, 35039);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private HelpInfo GetFromCommandCache(string helpFileIdentifier, CommandInfo commandInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1145, 35375, 36522);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 35488, 35552);

                f_1145_35488_35551(commandInfo != null, "commandInfo cannot be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 35566, 35668);

                HelpInfo
                result = f_1145_35584_35667(this, helpFileIdentifier, f_1145_35624_35640(commandInfo), f_1145_35642_35666(commandInfo))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 35682, 36481) || true) && (result == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 35682, 36481);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 35834, 36466) || true) && ((f_1145_35839_35857(commandInfo) != null) && (DynAbs.Tracing.TraceSender.Expression_True(1145, 35838, 35913) && (!f_1145_35872_35912(f_1145_35893_35911(commandInfo)))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 35834, 36466);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 35955, 36062);

                        MamlCommandHelpInfo
                        newMamlHelpInfo = f_1145_35993_36061(this, helpFileIdentifier, commandInfo)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 36084, 36447) || true) && (newMamlHelpInfo != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 36084, 36447);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 36302, 36375);

                            f_1145_36302_36374(this, helpFileIdentifier, f_1145_36340_36356(commandInfo), newMamlHelpInfo);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 36401, 36424);

                            return newMamlHelpInfo;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 36084, 36447);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 35834, 36466);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 35682, 36481);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 36497, 36511);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1145, 35375, 36522);

                int
                f_1145_35488_35551(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 35488, 35551);
                    return 0;
                }


                string
                f_1145_35624_35640(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 35624, 35640);
                    return return_v;
                }


                System.Management.Automation.HelpCategory
                f_1145_35642_35666(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.HelpCategory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 35642, 35666);
                    return return_v;
                }


                System.Management.Automation.HelpInfo
                f_1145_35584_35667(System.Management.Automation.CommandHelpProvider
                this_param, string
                helpFileIdentifier, string
                commandName, System.Management.Automation.HelpCategory
                helpCategory)
                {
                    var return_v = this_param.GetFromCommandCache(helpFileIdentifier, commandName, helpCategory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 35584, 35667);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1145_35839_35857(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 35839, 35857);
                    return return_v;
                }


                string
                f_1145_35893_35911(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Prefix;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 35893, 35911);
                    return return_v;
                }


                bool
                f_1145_35872_35912(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 35872, 35912);
                    return return_v;
                }


                System.Management.Automation.MamlCommandHelpInfo
                f_1145_35993_36061(System.Management.Automation.CommandHelpProvider
                this_param, string
                helpIdentifier, System.Management.Automation.CommandInfo
                cmdInfo)
                {
                    var return_v = this_param.GetFromCommandCacheByRemovingPrefix(helpIdentifier, cmdInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 35993, 36061);
                    return return_v;
                }


                string
                f_1145_36340_36356(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 36340, 36356);
                    return return_v;
                }


                int
                f_1145_36302_36374(System.Management.Automation.CommandHelpProvider
                this_param, string
                mshSnapInId, string
                cmdletName, System.Management.Automation.MamlCommandHelpInfo
                helpInfo)
                {
                    this_param.AddToCommandCache(mshSnapInId, cmdletName, helpInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 36302, 36374);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1145, 35375, 36522);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1145, 35375, 36522);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private HelpInfo GetFromCommandCacheOrCmdletInfo(CmdletInfo cmdletInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1145, 36801, 38778);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 36897, 36959);

                f_1145_36897_36958(cmdletInfo != null, "cmdletInfo cannot be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 36973, 37076);

                HelpInfo
                result = f_1145_36991_37075(this, f_1145_37011_37032(cmdletInfo), f_1145_37034_37049(cmdletInfo), f_1145_37051_37074(cmdletInfo))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 37090, 38737) || true) && (result == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 37090, 38737);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 37242, 38722) || true) && ((f_1145_37247_37264(cmdletInfo) != null) && (DynAbs.Tracing.TraceSender.Expression_True(1145, 37246, 37319) && (!f_1145_37279_37318(f_1145_37300_37317(cmdletInfo)))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 37242, 38722);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 37361, 37470);

                        MamlCommandHelpInfo
                        newMamlHelpInfo = f_1145_37399_37469(this, f_1145_37435_37456(cmdletInfo), cmdletInfo)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 37494, 38703) || true) && (newMamlHelpInfo != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 37494, 38703);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 37731, 38387) || true) && (f_1145_37735_37781(f_1145_37735_37770(f_1145_37735_37759(newMamlHelpInfo)), "Details") != null && (DynAbs.Tracing.TraceSender.Expression_True(1145, 37735, 37882) && f_1145_37822_37874(f_1145_37822_37868(f_1145_37822_37857(f_1145_37822_37846(newMamlHelpInfo)), "Details")) != null))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 37731, 38387);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 37940, 38040);

                                PSObject
                                commandDetails = f_1145_37966_38039(f_1145_37986_38038(f_1145_37986_38032(f_1145_37986_38021(f_1145_37986_38010(newMamlHelpInfo)), "Details")))
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 38070, 38253) || true) && (f_1145_38074_38107(f_1145_38074_38099(commandDetails), "Noun") != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 38070, 38253);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 38181, 38222);

                                    f_1145_38181_38221(f_1145_38181_38206(commandDetails), "Noun");
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 38070, 38253);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 38285, 38360);

                                f_1145_38285_38359(f_1145_38285_38310(commandDetails), f_1145_38315_38358("Noun", f_1145_38342_38357(cmdletInfo)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 37731, 38387);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 38556, 38631);

                            f_1145_38556_38630(this, f_1145_38574_38595(cmdletInfo), f_1145_38597_38612(cmdletInfo), newMamlHelpInfo);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 38657, 38680);

                            return newMamlHelpInfo;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 37494, 38703);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 37242, 38722);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 37090, 38737);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 38753, 38767);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1145, 36801, 38778);

                int
                f_1145_36897_36958(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 36897, 36958);
                    return 0;
                }


                string
                f_1145_37011_37032(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 37011, 37032);
                    return return_v;
                }


                string
                f_1145_37034_37049(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 37034, 37049);
                    return return_v;
                }


                System.Management.Automation.HelpCategory
                f_1145_37051_37074(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.HelpCategory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 37051, 37074);
                    return return_v;
                }


                System.Management.Automation.HelpInfo
                f_1145_36991_37075(System.Management.Automation.CommandHelpProvider
                this_param, string
                helpFileIdentifier, string
                commandName, System.Management.Automation.HelpCategory
                helpCategory)
                {
                    var return_v = this_param.GetFromCommandCache(helpFileIdentifier, commandName, helpCategory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 36991, 37075);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1145_37247_37264(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 37247, 37264);
                    return return_v;
                }


                string
                f_1145_37300_37317(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.Prefix;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 37300, 37317);
                    return return_v;
                }


                bool
                f_1145_37279_37318(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 37279, 37318);
                    return return_v;
                }


                string
                f_1145_37435_37456(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 37435, 37456);
                    return return_v;
                }


                System.Management.Automation.MamlCommandHelpInfo
                f_1145_37399_37469(System.Management.Automation.CommandHelpProvider
                this_param, string
                helpIdentifier, System.Management.Automation.CmdletInfo
                cmdInfo)
                {
                    var return_v = this_param.GetFromCommandCacheByRemovingPrefix(helpIdentifier, (System.Management.Automation.CommandInfo)cmdInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 37399, 37469);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1145_37735_37759(System.Management.Automation.MamlCommandHelpInfo
                this_param)
                {
                    var return_v = this_param.FullHelp;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 37735, 37759);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1145_37735_37770(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 37735, 37770);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1145_37735_37781(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 37735, 37781);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1145_37822_37846(System.Management.Automation.MamlCommandHelpInfo
                this_param)
                {
                    var return_v = this_param.FullHelp;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 37822, 37846);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1145_37822_37857(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 37822, 37857);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1145_37822_37868(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 37822, 37868);
                    return return_v;
                }


                object
                f_1145_37822_37874(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 37822, 37874);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1145_37986_38010(System.Management.Automation.MamlCommandHelpInfo
                this_param)
                {
                    var return_v = this_param.FullHelp;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 37986, 38010);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1145_37986_38021(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 37986, 38021);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1145_37986_38032(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 37986, 38032);
                    return return_v;
                }


                object
                f_1145_37986_38038(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 37986, 38038);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1145_37966_38039(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 37966, 38039);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1145_38074_38099(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 38074, 38099);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1145_38074_38107(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 38074, 38107);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1145_38181_38206(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 38181, 38206);
                    return return_v;
                }


                int
                f_1145_38181_38221(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                name)
                {
                    this_param.Remove(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 38181, 38221);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1145_38285_38310(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 38285, 38310);
                    return return_v;
                }


                string
                f_1145_38342_38357(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.Noun;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 38342, 38357);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1145_38315_38358(string
                name, string
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 38315, 38358);
                    return return_v;
                }


                int
                f_1145_38285_38359(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 38285, 38359);
                    return 0;
                }


                string
                f_1145_38574_38595(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 38574, 38595);
                    return return_v;
                }


                string
                f_1145_38597_38612(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 38597, 38612);
                    return return_v;
                }


                int
                f_1145_38556_38630(System.Management.Automation.CommandHelpProvider
                this_param, string
                mshSnapInId, string
                cmdletName, System.Management.Automation.MamlCommandHelpInfo
                helpInfo)
                {
                    this_param.AddToCommandCache(mshSnapInId, cmdletName, helpInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 38556, 38630);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1145, 36801, 38778);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1145, 36801, 38778);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private MamlCommandHelpInfo GetFromCommandCacheByRemovingPrefix(string helpIdentifier, CommandInfo cmdInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1145, 39609, 41860);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 39741, 39795);

                f_1145_39741_39794(cmdInfo != null, "cmdInfo cannot be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 39811, 39845);

                MamlCommandHelpInfo
                result = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 39859, 40135);

                MamlCommandHelpInfo
                originalHelpInfo = f_1145_39898_40111(this, helpIdentifier, f_1145_39959_40063(f_1145_40034_40046(cmdInfo), f_1145_40048_40062(cmdInfo)), f_1145_40090_40110(cmdInfo)) as MamlCommandHelpInfo
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 40151, 41819) || true) && (originalHelpInfo != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 40151, 41819);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 40213, 40246);

                    result = f_1145_40222_40245(originalHelpInfo);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 40532, 40681) || true) && (f_1145_40536_40570(f_1145_40536_40562(f_1145_40536_40551(result)), "Name") != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 40532, 40681);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 40620, 40662);

                        f_1145_40620_40661(f_1145_40620_40646(f_1145_40620_40635(result)), "Name");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 40532, 40681);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 40701, 40774);

                    f_1145_40701_40773(f_1145_40701_40727(f_1145_40701_40716(result)), f_1145_40732_40772("Name", f_1145_40759_40771(cmdInfo)));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 40794, 41804) || true) && (f_1145_40798_40835(f_1145_40798_40824(f_1145_40798_40813(result)), "Details") != null && (DynAbs.Tracing.TraceSender.Expression_True(1145, 40798, 40919) && f_1145_40868_40911(f_1145_40868_40905(f_1145_40868_40894(f_1145_40868_40883(result)), "Details")) != null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 40794, 41804);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 41137, 41261);

                        PSObject
                        commandDetails = f_1145_41163_41260(f_1145_41163_41253(f_1145_41209_41252(f_1145_41209_41246(f_1145_41209_41235(f_1145_41209_41224(result)), "Details"))))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 41285, 41444) || true) && (f_1145_41289_41322(f_1145_41289_41314(commandDetails), "Name") != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 41285, 41444);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 41380, 41421);

                            f_1145_41380_41420(f_1145_41380_41405(commandDetails), "Name");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 41285, 41444);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 41468, 41540);

                        f_1145_41468_41539(f_1145_41468_41493(commandDetails), f_1145_41498_41538("Name", f_1145_41525_41537(cmdInfo)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 41724, 41785);

                        f_1145_41724_41761(f_1145_41724_41750(f_1145_41724_41739(result)), "Details").Value = commandDetails;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 40794, 41804);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 40151, 41819);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 41835, 41849);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1145, 39609, 41860);

                int
                f_1145_39741_39794(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 39741, 39794);
                    return 0;
                }


                string
                f_1145_40034_40046(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 40034, 40046);
                    return return_v;
                }


                string
                f_1145_40048_40062(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Prefix;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 40048, 40062);
                    return return_v;
                }


                string
                f_1145_39959_40063(string
                commandName, string
                prefix)
                {
                    var return_v = Microsoft.PowerShell.Commands.ModuleCmdletBase.RemovePrefixFromCommandName(commandName, prefix);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 39959, 40063);
                    return return_v;
                }


                System.Management.Automation.HelpCategory
                f_1145_40090_40110(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.HelpCategory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 40090, 40110);
                    return return_v;
                }


                System.Management.Automation.HelpInfo
                f_1145_39898_40111(System.Management.Automation.CommandHelpProvider
                this_param, string
                helpFileIdentifier, string
                commandName, System.Management.Automation.HelpCategory
                helpCategory)
                {
                    var return_v = this_param.GetFromCommandCache(helpFileIdentifier, commandName, helpCategory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 39898, 40111);
                    return return_v;
                }


                System.Management.Automation.MamlCommandHelpInfo
                f_1145_40222_40245(System.Management.Automation.MamlCommandHelpInfo
                this_param)
                {
                    var return_v = this_param.Copy();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 40222, 40245);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1145_40536_40551(System.Management.Automation.MamlCommandHelpInfo
                this_param)
                {
                    var return_v = this_param.FullHelp;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 40536, 40551);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1145_40536_40562(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 40536, 40562);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1145_40536_40570(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 40536, 40570);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1145_40620_40635(System.Management.Automation.MamlCommandHelpInfo
                this_param)
                {
                    var return_v = this_param.FullHelp;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 40620, 40635);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1145_40620_40646(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 40620, 40646);
                    return return_v;
                }


                int
                f_1145_40620_40661(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                name)
                {
                    this_param.Remove(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 40620, 40661);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1145_40701_40716(System.Management.Automation.MamlCommandHelpInfo
                this_param)
                {
                    var return_v = this_param.FullHelp;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 40701, 40716);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1145_40701_40727(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 40701, 40727);
                    return return_v;
                }


                string
                f_1145_40759_40771(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 40759, 40771);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1145_40732_40772(string
                name, string
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 40732, 40772);
                    return return_v;
                }


                int
                f_1145_40701_40773(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 40701, 40773);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1145_40798_40813(System.Management.Automation.MamlCommandHelpInfo
                this_param)
                {
                    var return_v = this_param.FullHelp;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 40798, 40813);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1145_40798_40824(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 40798, 40824);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1145_40798_40835(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 40798, 40835);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1145_40868_40883(System.Management.Automation.MamlCommandHelpInfo
                this_param)
                {
                    var return_v = this_param.FullHelp;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 40868, 40883);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1145_40868_40894(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 40868, 40894);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1145_40868_40905(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 40868, 40905);
                    return return_v;
                }


                object
                f_1145_40868_40911(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 40868, 40911);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1145_41209_41224(System.Management.Automation.MamlCommandHelpInfo
                this_param)
                {
                    var return_v = this_param.FullHelp;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 41209, 41224);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1145_41209_41235(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 41209, 41235);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1145_41209_41246(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 41209, 41246);
                    return return_v;
                }


                object
                f_1145_41209_41252(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 41209, 41252);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1145_41163_41253(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 41163, 41253);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1145_41163_41260(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Copy();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 41163, 41260);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1145_41289_41314(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 41289, 41314);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1145_41289_41322(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 41289, 41322);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1145_41380_41405(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 41380, 41405);
                    return return_v;
                }


                int
                f_1145_41380_41420(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                name)
                {
                    this_param.Remove(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 41380, 41420);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1145_41468_41493(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 41468, 41493);
                    return return_v;
                }


                string
                f_1145_41525_41537(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 41525, 41537);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1145_41498_41538(string
                name, string
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 41498, 41538);
                    return return_v;
                }


                int
                f_1145_41468_41539(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 41468, 41539);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1145_41724_41739(System.Management.Automation.MamlCommandHelpInfo
                this_param)
                {
                    var return_v = this_param.FullHelp;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 41724, 41739);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1145_41724_41750(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 41724, 41750);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1145_41724_41761(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 41724, 41761);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1145, 39609, 41860);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1145, 39609, 41860);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void AddToCommandCache(string mshSnapInId, string cmdletName, MamlCommandHelpInfo helpInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1145, 42236, 43224);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 42360, 42452);

                f_1145_42360_42451(!f_1145_42374_42406(cmdletName), "Cmdlet Name should not be null or empty.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 42468, 42492);

                string
                key = cmdletName
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 42653, 42809);

                f_1145_42653_42808(f_1145_42653_42680(f_1145_42653_42670(helpInfo)), 0, f_1145_42691_42807(f_1145_42705_42733(), "MamlCommandHelpInfo#{0}#{1}", mshSnapInId, cmdletName));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 42825, 43173) || true) && (!f_1145_42830_42863(mshSnapInId))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 42825, 43173);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 42897, 42928);

                    key = mshSnapInId + "\\" + key;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 43014, 43158);

                    f_1145_43014_43157(f_1145_43014_43041(f_1145_43014_43031(helpInfo)), 1, f_1145_43052_43156(f_1145_43066_43094(), "MamlCommandHelpInfo#{0}", mshSnapInId));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 42825, 43173);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 43189, 43213);

                f_1145_43189_43212(this, key, helpInfo);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1145, 42236, 43224);

                bool
                f_1145_42374_42406(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 42374, 42406);
                    return return_v;
                }


                int
                f_1145_42360_42451(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 42360, 42451);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1145_42653_42670(System.Management.Automation.MamlCommandHelpInfo
                this_param)
                {
                    var return_v = this_param.FullHelp;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 42653, 42670);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1145_42653_42680(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.TypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 42653, 42680);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1145_42705_42733()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 42705, 42733);
                    return return_v;
                }


                string
                f_1145_42691_42807(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 42691, 42807);
                    return return_v;
                }


                int
                f_1145_42653_42808(System.Collections.ObjectModel.Collection<string>
                this_param, int
                index, string
                item)
                {
                    this_param.Insert(index, item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 42653, 42808);
                    return 0;
                }


                bool
                f_1145_42830_42863(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 42830, 42863);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1145_43014_43031(System.Management.Automation.MamlCommandHelpInfo
                this_param)
                {
                    var return_v = this_param.FullHelp;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 43014, 43031);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1145_43014_43041(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.TypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 43014, 43041);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1145_43066_43094()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 43066, 43094);
                    return return_v;
                }


                string
                f_1145_43052_43156(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 43052, 43156);
                    return return_v;
                }


                int
                f_1145_43014_43157(System.Collections.ObjectModel.Collection<string>
                this_param, int
                index, string
                item)
                {
                    this_param.Insert(index, item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 43014, 43157);
                    return 0;
                }


                int
                f_1145_43189_43212(System.Management.Automation.CommandHelpProvider
                this_param, string
                target, System.Management.Automation.MamlCommandHelpInfo
                helpInfo)
                {
                    this_param.AddCache(target, (System.Management.Automation.HelpInfo)helpInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 43189, 43212);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1145, 42236, 43224);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1145, 42236, 43224);
            }
        }

        internal static bool IsMamlHelp(string helpFile, XmlNode helpItemsNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1145, 43851, 44522);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 43947, 44044) || true) && (f_1145_43951_44013(helpFile, ".maml", StringComparison.OrdinalIgnoreCase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 43947, 44044);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 44032, 44044);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 43947, 44044);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 44060, 44128) || true) && (f_1145_44064_44088(helpItemsNode) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 44060, 44128);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 44115, 44128);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 44060, 44128);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 44144, 44482);
                    foreach (XmlNode attribute in f_1145_44174_44198_I(f_1145_44174_44198(helpItemsNode)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 44144, 44482);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 44232, 44467) || true) && (f_1145_44236_44303(f_1145_44236_44250(attribute), "schema", StringComparison.OrdinalIgnoreCase) && (DynAbs.Tracing.TraceSender.Expression_True(1145, 44236, 44394) && f_1145_44328_44394(f_1145_44328_44343(attribute), "maml", StringComparison.OrdinalIgnoreCase)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 44232, 44467);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 44436, 44448);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 44232, 44467);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 44144, 44482);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1145, 1, 339);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1145, 1, 339);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 44498, 44511);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1145, 43851, 44522);

                bool
                f_1145_43951_44013(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.EndsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 43951, 44013);
                    return return_v;
                }


                System.Xml.XmlAttributeCollection
                f_1145_44064_44088(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 44064, 44088);
                    return return_v;
                }


                System.Xml.XmlAttributeCollection
                f_1145_44174_44198(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 44174, 44198);
                    return return_v;
                }


                string
                f_1145_44236_44250(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 44236, 44250);
                    return return_v;
                }


                bool
                f_1145_44236_44303(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 44236, 44303);
                    return return_v;
                }


                string
                f_1145_44328_44343(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 44328, 44343);
                    return return_v;
                }


                bool
                f_1145_44328_44394(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 44328, 44394);
                    return return_v;
                }


                System.Xml.XmlAttributeCollection
                f_1145_44174_44198_I(System.Xml.XmlAttributeCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 44174, 44198);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1145, 43851, 44522);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1145, 43851, 44522);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override IEnumerable<HelpInfo> SearchHelp(HelpRequest helpRequest, bool searchOnlyContent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1145, 44943, 51475);

                var listYield = new List<HelpInfo>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 45067, 45102);

                string
                target = f_1145_45083_45101(helpRequest)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 45116, 45174);

                Collection<string>
                patternList = f_1145_45149_45173()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 45258, 45297);

                WildcardPattern
                wildCardPattern = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 45595, 45682);

                bool
                decoratedSearch = !f_1145_45619_45681(f_1145_45662_45680(helpRequest))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 45698, 46719) || true) && (!searchOnlyContent)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 45698, 46719);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 45754, 46241) || true) && (decoratedSearch)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 45754, 46241);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 45815, 46116) || true) && (f_1145_45819_45874(target, StringLiterals.CommandVerbNounSeparator) >= 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 45815, 46116);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 45929, 45959);

                            f_1145_45929_45958(patternList, target + "*");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 45815, 46116);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 45815, 46116);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 46057, 46093);

                            f_1145_46057_46092(patternList, "*" + target + "*");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 45815, 46116);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 45754, 46241);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 45754, 46241);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 46198, 46222);

                        f_1145_46198_46221(patternList, target);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 45754, 46241);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 45698, 46719);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 45698, 46719);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 46353, 46374);

                    f_1145_46353_46373(                // get help for all cmdlets.
                                    patternList, "*");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 46392, 46433);

                    string
                    searchTarget = f_1145_46414_46432(helpRequest)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 46451, 46577) || true) && (decoratedSearch)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 46451, 46577);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 46512, 46558);

                        searchTarget = "*" + f_1145_46533_46551(helpRequest) + "*";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 46451, 46577);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 46597, 46704);

                    wildCardPattern = f_1145_46615_46703(searchTarget, WildcardOptions.Compiled | WildcardOptions.IgnoreCase);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 45698, 46719);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 46735, 46771);

                int
                countOfHelpInfoObjectsFound = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 46857, 46927);

                Hashtable
                hashtable = f_1145_46879_46926(f_1145_46893_46925())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 46941, 47016);

                Hashtable
                hiddenCommands = f_1145_46968_47015(f_1145_46982_47014())
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 47030, 51464);
                    foreach (string pattern in f_1145_47057_47068_I(patternList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 47030, 51464);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 47102, 47176);

                        CommandSearcher
                        searcher = f_1145_47129_47175(this, pattern, _context)
                        ;
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 47196, 49241) || true) && (f_1145_47203_47222(searcher))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 47196, 49241);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 47264, 47385) || true) && (f_1145_47268_47300(_context))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 47264, 47385);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 47350, 47362);

                                    return listYield;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 47264, 47385);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 47409, 47476);

                                CommandInfo
                                current = f_1145_47431_47475(((IEnumerator<CommandInfo>)searcher))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 47500, 47578);

                                HelpInfo
                                helpInfo = f_1145_47520_47577(this, current, !decoratedSearch, searchOnlyContent)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 47600, 47639);

                                string
                                helpName = f_1145_47618_47638(this, current)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 47663, 49222) || true) && (helpInfo != null && (DynAbs.Tracing.TraceSender.Expression_True(1145, 47667, 47718) && !f_1145_47688_47718(helpName)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 47663, 49222);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 47768, 48287) || true) && (!f_1145_47773_47831(f_1145_47796_47821(helpRequest), current))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 47768, 48287);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 48046, 48219) || true) && (!f_1145_48051_48087(hiddenCommands, helpName))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 48046, 48219);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 48153, 48188);

                                            f_1145_48153_48187(hiddenCommands, helpName, null);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 48046, 48219);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 48251, 48260);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 47768, 48287);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 48315, 48390) || true) && (f_1145_48319_48350(hashtable, helpName))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 48315, 48390);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 48381, 48390);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 48315, 48390);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 48503, 48639) || true) && (!f_1145_48508_48545(helpInfo, helpRequest, current))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 48503, 48639);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 48603, 48612);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 48503, 48639);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 48710, 48879) || true) && (searchOnlyContent && (DynAbs.Tracing.TraceSender.Expression_True(1145, 48714, 48785) && (!f_1145_48737_48784(helpInfo, wildCardPattern))))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 48710, 48879);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 48843, 48852);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 48710, 48879);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 48907, 48937);

                                    f_1145_48907_48936(
                                                            hashtable, helpName, null);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 48963, 48993);

                                    countOfHelpInfoObjectsFound++;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 49019, 49041);

                                    listYield.Add(helpInfo);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 49069, 49199) || true) && (countOfHelpInfoObjectsFound >= f_1145_49104_49126(helpRequest) && (DynAbs.Tracing.TraceSender.Expression_True(1145, 49073, 49156) && f_1145_49130_49152(helpRequest) > 0))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 49069, 49199);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 49187, 49199);

                                        return listYield;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 49069, 49199);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 47663, 49222);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 47196, 49241);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1145, 47196, 49241);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1145, 47196, 49241);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 49261, 51449) || true) && (f_1145_49265_49282(this) == (HelpCategory.Alias | HelpCategory.Cmdlet))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 49261, 51449);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 49370, 51430);
                                foreach (CommandInfo current in f_1145_49402_49479_I(f_1145_49402_49479(pattern, _context, f_1145_49453_49478(helpRequest))))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 49370, 51430);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 49529, 49662) || true) && (f_1145_49533_49565(_context))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 49529, 49662);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 49623, 49635);

                                        return listYield;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 49529, 49662);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 49690, 50004) || true) && (!f_1145_49695_49753(f_1145_49718_49743(helpRequest), current))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 49690, 50004);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 49968, 49977);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 49690, 50004);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 50032, 50110);

                                    HelpInfo
                                    helpInfo = f_1145_50052_50109(this, current, !decoratedSearch, searchOnlyContent)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 50136, 50175);

                                    string
                                    helpName = f_1145_50154_50174(this, current)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 50203, 51407) || true) && (helpInfo != null && (DynAbs.Tracing.TraceSender.Expression_True(1145, 50207, 50258) && !f_1145_50228_50258(helpName)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 50203, 51407);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 50316, 50395) || true) && (f_1145_50320_50351(hashtable, helpName))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 50316, 50395);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 50386, 50395);

                                            continue;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 50316, 50395);
                                        }

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 50427, 50511) || true) && (f_1145_50431_50467(hiddenCommands, helpName))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 50427, 50511);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 50502, 50511);

                                            continue;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 50427, 50511);
                                        }

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 50632, 50780) || true) && (!f_1145_50637_50674(helpInfo, helpRequest, current))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 50632, 50780);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 50740, 50749);

                                            continue;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 50632, 50780);
                                        }

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 50859, 51040) || true) && (searchOnlyContent && (DynAbs.Tracing.TraceSender.Expression_True(1145, 50863, 50934) && (!f_1145_50886_50933(helpInfo, wildCardPattern))))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 50859, 51040);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 51000, 51009);

                                            continue;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 50859, 51040);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 51072, 51102);

                                        f_1145_51072_51101(
                                                                    hashtable, helpName, null);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 51132, 51162);

                                        countOfHelpInfoObjectsFound++;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 51192, 51214);

                                        listYield.Add(helpInfo);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 51246, 51380) || true) && (countOfHelpInfoObjectsFound >= f_1145_51281_51303(helpRequest) && (DynAbs.Tracing.TraceSender.Expression_True(1145, 51250, 51333) && f_1145_51307_51329(helpRequest) > 0))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 51246, 51380);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 51368, 51380);

                                            return listYield;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 51246, 51380);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 50203, 51407);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 49370, 51430);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1145, 1, 2061);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1145, 1, 2061);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 49261, 51449);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 47030, 51464);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1145, 1, 4435);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1145, 1, 4435);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1145, 44943, 51475);

                return listYield;

                string
                f_1145_45083_45101(System.Management.Automation.HelpRequest
                this_param)
                {
                    var return_v = this_param.Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 45083, 45101);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1145_45149_45173()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 45149, 45173);
                    return return_v;
                }


                string
                f_1145_45662_45680(System.Management.Automation.HelpRequest
                this_param)
                {
                    var return_v = this_param.Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 45662, 45680);
                    return return_v;
                }


                bool
                f_1145_45619_45681(string
                pattern)
                {
                    var return_v = WildcardPattern.ContainsWildcardCharacters(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 45619, 45681);
                    return return_v;
                }


                int
                f_1145_45819_45874(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 45819, 45874);
                    return return_v;
                }


                int
                f_1145_45929_45958(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 45929, 45958);
                    return 0;
                }


                int
                f_1145_46057_46092(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 46057, 46092);
                    return 0;
                }


                int
                f_1145_46198_46221(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 46198, 46221);
                    return 0;
                }


                int
                f_1145_46353_46373(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 46353, 46373);
                    return 0;
                }


                string
                f_1145_46414_46432(System.Management.Automation.HelpRequest
                this_param)
                {
                    var return_v = this_param.Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 46414, 46432);
                    return return_v;
                }


                string
                f_1145_46533_46551(System.Management.Automation.HelpRequest
                this_param)
                {
                    var return_v = this_param.Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 46533, 46551);
                    return return_v;
                }


                System.Management.Automation.WildcardPattern
                f_1145_46615_46703(string
                pattern, System.Management.Automation.WildcardOptions
                options)
                {
                    var return_v = WildcardPattern.Get(pattern, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 46615, 46703);
                    return return_v;
                }


                System.StringComparer
                f_1145_46893_46925()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 46893, 46925);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1145_46879_46926(System.StringComparer
                equalityComparer)
                {
                    var return_v = new System.Collections.Hashtable((System.Collections.IEqualityComparer)equalityComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 46879, 46926);
                    return return_v;
                }


                System.StringComparer
                f_1145_46982_47014()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 46982, 47014);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1145_46968_47015(System.StringComparer
                equalityComparer)
                {
                    var return_v = new System.Collections.Hashtable((System.Collections.IEqualityComparer)equalityComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 46968, 47015);
                    return return_v;
                }


                System.Management.Automation.CommandSearcher
                f_1145_47129_47175(System.Management.Automation.CommandHelpProvider
                this_param, string
                pattern, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = this_param.GetCommandSearcherForSearch(pattern, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 47129, 47175);
                    return return_v;
                }


                bool
                f_1145_47203_47222(System.Management.Automation.CommandSearcher
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 47203, 47222);
                    return return_v;
                }


                bool
                f_1145_47268_47300(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentPipelineStopping;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 47268, 47300);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1145_47431_47475(System.Collections.Generic.IEnumerator<System.Management.Automation.CommandInfo>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 47431, 47475);
                    return return_v;
                }


                System.Management.Automation.HelpInfo
                f_1145_47520_47577(System.Management.Automation.CommandHelpProvider
                this_param, System.Management.Automation.CommandInfo
                commandInfo, bool
                reportErrors, bool
                searchOnlyContent)
                {
                    var return_v = this_param.GetHelpInfo(commandInfo, reportErrors, searchOnlyContent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 47520, 47577);
                    return return_v;
                }


                string
                f_1145_47618_47638(System.Management.Automation.CommandHelpProvider
                this_param, System.Management.Automation.CommandInfo
                commandInfo)
                {
                    var return_v = this_param.GetHelpName(commandInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 47618, 47638);
                    return return_v;
                }


                bool
                f_1145_47688_47718(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 47688, 47718);
                    return return_v;
                }


                System.Management.Automation.CommandOrigin
                f_1145_47796_47821(System.Management.Automation.HelpRequest
                this_param)
                {
                    var return_v = this_param.CommandOrigin;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 47796, 47821);
                    return return_v;
                }


                bool
                f_1145_47773_47831(System.Management.Automation.CommandOrigin
                origin, System.Management.Automation.CommandInfo
                commandInfo)
                {
                    var return_v = SessionState.IsVisible(origin, commandInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 47773, 47831);
                    return return_v;
                }


                bool
                f_1145_48051_48087(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 48051, 48087);
                    return return_v;
                }


                int
                f_1145_48153_48187(System.Collections.Hashtable
                this_param, string
                key, object?
                value)
                {
                    this_param.Add((object)key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 48153, 48187);
                    return 0;
                }


                bool
                f_1145_48319_48350(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 48319, 48350);
                    return return_v;
                }


                bool
                f_1145_48508_48545(System.Management.Automation.HelpInfo
                helpInfo, System.Management.Automation.HelpRequest
                helpRequest, System.Management.Automation.CommandInfo
                commandInfo)
                {
                    var return_v = Match(helpInfo, helpRequest, commandInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 48508, 48545);
                    return return_v;
                }


                bool
                f_1145_48737_48784(System.Management.Automation.HelpInfo
                this_param, System.Management.Automation.WildcardPattern
                pattern)
                {
                    var return_v = this_param.MatchPatternInContent(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 48737, 48784);
                    return return_v;
                }


                int
                f_1145_48907_48936(System.Collections.Hashtable
                this_param, string
                key, object?
                value)
                {
                    this_param.Add((object)key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 48907, 48936);
                    return 0;
                }


                int
                f_1145_49104_49126(System.Management.Automation.HelpRequest
                this_param)
                {
                    var return_v = this_param.MaxResults;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 49104, 49126);
                    return return_v;
                }


                int
                f_1145_49130_49152(System.Management.Automation.HelpRequest
                this_param)
                {
                    var return_v = this_param.MaxResults;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 49130, 49152);
                    return return_v;
                }


                System.Management.Automation.HelpCategory
                f_1145_49265_49282(System.Management.Automation.CommandHelpProvider
                this_param)
                {
                    var return_v = this_param.HelpCategory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 49265, 49282);
                    return return_v;
                }


                System.Management.Automation.CommandOrigin
                f_1145_49453_49478(System.Management.Automation.HelpRequest
                this_param)
                {
                    var return_v = this_param.CommandOrigin;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 49453, 49478);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.CommandInfo>
                f_1145_49402_49479(string
                pattern, System.Management.Automation.ExecutionContext
                context, System.Management.Automation.CommandOrigin
                commandOrigin)
                {
                    var return_v = ModuleUtils.GetMatchingCommands(pattern, context, commandOrigin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 49402, 49479);
                    return return_v;
                }


                bool
                f_1145_49533_49565(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentPipelineStopping;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 49533, 49565);
                    return return_v;
                }


                System.Management.Automation.CommandOrigin
                f_1145_49718_49743(System.Management.Automation.HelpRequest
                this_param)
                {
                    var return_v = this_param.CommandOrigin;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 49718, 49743);
                    return return_v;
                }


                bool
                f_1145_49695_49753(System.Management.Automation.CommandOrigin
                origin, System.Management.Automation.CommandInfo
                commandInfo)
                {
                    var return_v = SessionState.IsVisible(origin, commandInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 49695, 49753);
                    return return_v;
                }


                System.Management.Automation.HelpInfo
                f_1145_50052_50109(System.Management.Automation.CommandHelpProvider
                this_param, System.Management.Automation.CommandInfo
                commandInfo, bool
                reportErrors, bool
                searchOnlyContent)
                {
                    var return_v = this_param.GetHelpInfo(commandInfo, reportErrors, searchOnlyContent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 50052, 50109);
                    return return_v;
                }


                string
                f_1145_50154_50174(System.Management.Automation.CommandHelpProvider
                this_param, System.Management.Automation.CommandInfo
                commandInfo)
                {
                    var return_v = this_param.GetHelpName(commandInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 50154, 50174);
                    return return_v;
                }


                bool
                f_1145_50228_50258(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 50228, 50258);
                    return return_v;
                }


                bool
                f_1145_50320_50351(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 50320, 50351);
                    return return_v;
                }


                bool
                f_1145_50431_50467(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 50431, 50467);
                    return return_v;
                }


                bool
                f_1145_50637_50674(System.Management.Automation.HelpInfo
                helpInfo, System.Management.Automation.HelpRequest
                helpRequest, System.Management.Automation.CommandInfo
                commandInfo)
                {
                    var return_v = Match(helpInfo, helpRequest, commandInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 50637, 50674);
                    return return_v;
                }


                bool
                f_1145_50886_50933(System.Management.Automation.HelpInfo
                this_param, System.Management.Automation.WildcardPattern
                pattern)
                {
                    var return_v = this_param.MatchPatternInContent(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 50886, 50933);
                    return return_v;
                }


                int
                f_1145_51072_51101(System.Collections.Hashtable
                this_param, string
                key, object?
                value)
                {
                    this_param.Add((object)key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 51072, 51101);
                    return 0;
                }


                int
                f_1145_51281_51303(System.Management.Automation.HelpRequest
                this_param)
                {
                    var return_v = this_param.MaxResults;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 51281, 51303);
                    return return_v;
                }


                int
                f_1145_51307_51329(System.Management.Automation.HelpRequest
                this_param)
                {
                    var return_v = this_param.MaxResults;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 51307, 51329);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.CommandInfo>
                f_1145_49402_49479_I(System.Collections.Generic.IEnumerable<System.Management.Automation.CommandInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 49402, 49479);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1145_47057_47068_I(System.Collections.ObjectModel.Collection<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 47057, 47068);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1145, 44943, 51475);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1145, 44943, 51475);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool Match(HelpInfo helpInfo, HelpRequest helpRequest, CommandInfo commandInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1145, 51829, 52658);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 51948, 52002) || true) && (helpRequest == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 51948, 52002);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 51990, 52002);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 51948, 52002);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 52018, 52142) || true) && (0 == (f_1145_52028_52052(helpRequest) & f_1145_52055_52079(commandInfo)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 52018, 52142);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 52114, 52127);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 52018, 52142);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 52158, 52228) || true) && (!(helpInfo is BaseCommandHelpInfo))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 52158, 52228);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 52215, 52228);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 52158, 52228);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 52244, 52359) || true) && (!f_1145_52249_52297(f_1145_52255_52273(helpInfo), f_1145_52275_52296(helpRequest)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 52244, 52359);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 52331, 52344);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 52244, 52359);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 52375, 52480) || true) && (!f_1145_52380_52418(f_1145_52386_52399(helpInfo), f_1145_52401_52417(helpRequest)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 52375, 52480);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 52452, 52465);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 52375, 52480);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 52496, 52619) || true) && (!f_1145_52501_52557(f_1145_52507_52529(helpInfo), f_1145_52531_52556(helpRequest)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 52496, 52619);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 52591, 52604);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 52496, 52619);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 52635, 52647);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1145, 51829, 52658);

                System.Management.Automation.HelpCategory
                f_1145_52028_52052(System.Management.Automation.HelpRequest
                this_param)
                {
                    var return_v = this_param.HelpCategory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 52028, 52052);
                    return return_v;
                }


                System.Management.Automation.HelpCategory
                f_1145_52055_52079(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.HelpCategory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 52055, 52079);
                    return return_v;
                }


                string
                f_1145_52255_52273(System.Management.Automation.HelpInfo
                this_param)
                {
                    var return_v = this_param.Component;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 52255, 52273);
                    return return_v;
                }


                string[]
                f_1145_52275_52296(System.Management.Automation.HelpRequest
                this_param)
                {
                    var return_v = this_param.Component;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 52275, 52296);
                    return return_v;
                }


                bool
                f_1145_52249_52297(string
                target, string[]
                patterns)
                {
                    var return_v = Match(target, (System.Collections.Generic.ICollection<string>)patterns);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 52249, 52297);
                    return return_v;
                }


                string
                f_1145_52386_52399(System.Management.Automation.HelpInfo
                this_param)
                {
                    var return_v = this_param.Role;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 52386, 52399);
                    return return_v;
                }


                string[]
                f_1145_52401_52417(System.Management.Automation.HelpRequest
                this_param)
                {
                    var return_v = this_param.Role;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 52401, 52417);
                    return return_v;
                }


                bool
                f_1145_52380_52418(string
                target, string[]
                patterns)
                {
                    var return_v = Match(target, (System.Collections.Generic.ICollection<string>)patterns);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 52380, 52418);
                    return return_v;
                }


                string
                f_1145_52507_52529(System.Management.Automation.HelpInfo
                this_param)
                {
                    var return_v = this_param.Functionality;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 52507, 52529);
                    return return_v;
                }


                string[]
                f_1145_52531_52556(System.Management.Automation.HelpRequest
                this_param)
                {
                    var return_v = this_param.Functionality;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 52531, 52556);
                    return return_v;
                }


                bool
                f_1145_52501_52557(string
                target, string[]
                patterns)
                {
                    var return_v = Match(target, (System.Collections.Generic.ICollection<string>)patterns);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 52501, 52557);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1145, 51829, 52658);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1145, 51829, 52658);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool Match(string target, string pattern)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1145, 52670, 53061);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 52751, 52815) || true) && (f_1145_52755_52784(pattern))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 52751, 52815);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 52803, 52815);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 52751, 52815);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 52831, 52904) || true) && (f_1145_52835_52863(target))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 52831, 52904);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 52882, 52904);

                    target = string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 52831, 52904);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 52920, 53003);

                WildcardPattern
                matcher = f_1145_52946_53002(pattern, WildcardOptions.IgnoreCase)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 53019, 53050);

                return f_1145_53026_53049(matcher, target);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1145, 52670, 53061);

                bool
                f_1145_52755_52784(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 52755, 52784);
                    return return_v;
                }


                bool
                f_1145_52835_52863(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 52835, 52863);
                    return return_v;
                }


                System.Management.Automation.WildcardPattern
                f_1145_52946_53002(string
                pattern, System.Management.Automation.WildcardOptions
                options)
                {
                    var return_v = WildcardPattern.Get(pattern, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 52946, 53002);
                    return return_v;
                }


                bool
                f_1145_53026_53049(System.Management.Automation.WildcardPattern
                this_param, string
                input)
                {
                    var return_v = this_param.IsMatch(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 53026, 53049);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1145, 52670, 53061);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1145, 52670, 53061);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool Match(string target, ICollection<string> patterns)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1145, 53596, 54257);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 53828, 53902) || true) && (patterns == null || (DynAbs.Tracing.TraceSender.Expression_False(1145, 53832, 53871) || f_1145_53852_53866(patterns) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 53828, 53902);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 53890, 53902);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 53828, 53902);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 53918, 54156);
                    foreach (string pattern in f_1145_53945_53953_I(patterns))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 53918, 54156);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 53987, 54141) || true) && (f_1145_53991_54013(target, pattern))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 53987, 54141);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 54110, 54122);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 53987, 54141);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 53918, 54156);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1145, 1, 239);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1145, 1, 239);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 54233, 54246);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1145, 53596, 54257);

                int
                f_1145_53852_53866(System.Collections.Generic.ICollection<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 53852, 53866);
                    return return_v;
                }


                bool
                f_1145_53991_54013(string
                target, string
                pattern)
                {
                    var return_v = Match(target, pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 53991, 54013);
                    return return_v;
                }


                System.Collections.Generic.ICollection<string>
                f_1145_53945_53953_I(System.Collections.Generic.ICollection<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 53945, 53953);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1145, 53596, 54257);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1145, 53596, 54257);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override IEnumerable<HelpInfo> ProcessForwardedHelp(HelpInfo helpInfo, HelpRequest helpRequest)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1145, 54700, 56855);

                var listYield = new List<HelpInfo>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 54829, 55005);

                HelpCategory
                categoriesHandled = (HelpCategory.Alias
                                | HelpCategory.ExternalScript | HelpCategory.Filter | HelpCategory.Function | HelpCategory.ScriptCommand)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 55021, 56844) || true) && ((f_1145_55026_55047(helpInfo) & categoriesHandled) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 55021, 56844);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 55107, 55160);

                    HelpRequest
                    commandHelpRequest = f_1145_55140_55159(helpRequest)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 55178, 55229);

                    commandHelpRequest.Target = f_1145_55206_55228(helpInfo);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 55247, 55305);

                    commandHelpRequest.CommandOrigin = CommandOrigin.Internal;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 55655, 56410) || true) && (f_1145_55659_55687(helpInfo) != HelpCategory.None && (DynAbs.Tracing.TraceSender.Expression_True(1145, 55659, 55755) && f_1145_55712_55733(helpInfo) != HelpCategory.Alias))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 55655, 56410);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 55797, 55860);

                        commandHelpRequest.HelpCategory = f_1145_55831_55859(helpInfo);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 55655, 56410);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 55655, 56410);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 55994, 56093);

                            CommandInfo
                            targetCommand = f_1145_56022_56092(f_1145_56022_56047(_context), f_1145_56066_56091(commandHelpRequest))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 56119, 56180);

                            commandHelpRequest.HelpCategory = f_1145_56153_56179(targetCommand);
                        }
                        catch (CommandNotFoundException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1145, 56225, 56391);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1145, 56225, 56391);
                            // ignore errors for aliases pointing to non-existant commands
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 55655, 56410);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 56430, 56593);
                        foreach (HelpInfo helpInfoToReturn in f_1145_56468_56502_I(f_1145_56468_56502(this, commandHelpRequest)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 56430, 56593);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 56544, 56574);

                            listYield.Add(helpInfoToReturn);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 56430, 56593);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1145, 1, 164);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1145, 1, 164);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 55021, 56844);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 55021, 56844);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 56807, 56829);

                    listYield.Add(helpInfo);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 55021, 56844);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1145, 54700, 56855);

                return listYield;

                System.Management.Automation.HelpCategory
                f_1145_55026_55047(System.Management.Automation.HelpInfo
                this_param)
                {
                    var return_v = this_param.HelpCategory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 55026, 55047);
                    return return_v;
                }


                System.Management.Automation.HelpRequest
                f_1145_55140_55159(System.Management.Automation.HelpRequest
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 55140, 55159);
                    return return_v;
                }


                string
                f_1145_55206_55228(System.Management.Automation.HelpInfo
                this_param)
                {
                    var return_v = this_param.ForwardTarget;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 55206, 55228);
                    return return_v;
                }


                System.Management.Automation.HelpCategory
                f_1145_55659_55687(System.Management.Automation.HelpInfo
                this_param)
                {
                    var return_v = this_param.ForwardHelpCategory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 55659, 55687);
                    return return_v;
                }


                System.Management.Automation.HelpCategory
                f_1145_55712_55733(System.Management.Automation.HelpInfo
                this_param)
                {
                    var return_v = this_param.HelpCategory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 55712, 55733);
                    return return_v;
                }


                System.Management.Automation.HelpCategory
                f_1145_55831_55859(System.Management.Automation.HelpInfo
                this_param)
                {
                    var return_v = this_param.ForwardHelpCategory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 55831, 55859);
                    return return_v;
                }


                System.Management.Automation.CommandDiscovery
                f_1145_56022_56047(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CommandDiscovery;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 56022, 56047);
                    return return_v;
                }


                string
                f_1145_56066_56091(System.Management.Automation.HelpRequest
                this_param)
                {
                    var return_v = this_param.Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 56066, 56091);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1145_56022_56092(System.Management.Automation.CommandDiscovery
                this_param, string
                commandName)
                {
                    var return_v = this_param.LookupCommandInfo(commandName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 56022, 56092);
                    return return_v;
                }


                System.Management.Automation.HelpCategory
                f_1145_56153_56179(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.HelpCategory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 56153, 56179);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.HelpInfo>
                f_1145_56468_56502(System.Management.Automation.CommandHelpProvider
                this_param, System.Management.Automation.HelpRequest
                helpRequest)
                {
                    var return_v = this_param.ExactMatchHelp(helpRequest);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 56468, 56502);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.HelpInfo>
                f_1145_56468_56502_I(System.Collections.Generic.IEnumerable<System.Management.Automation.HelpInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 56468, 56502);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1145, 54700, 56855);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1145, 54700, 56855);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void Reset()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1145, 57024, 57138);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 57079, 57092);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Reset(), 1145, 57079, 57091);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 57108, 57127);

                f_1145_57108_57126(
                            _helpFiles);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1145, 57024, 57138);

                int
                f_1145_57108_57126(System.Collections.Hashtable
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 57108, 57126);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1145, 57024, 57138);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1145, 57024, 57138);
            }
        }

        internal virtual CommandSearcher GetCommandSearcherForExactMatch(string commandName, ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1145, 57444, 57811);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 57579, 57768);

                CommandSearcher
                searcher = f_1145_57606_57767(commandName, SearchResolutionOptions.None, CommandTypes.Cmdlet, context)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 57784, 57800);

                return searcher;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1145, 57444, 57811);

                System.Management.Automation.CommandSearcher
                f_1145_57606_57767(string
                commandName, System.Management.Automation.SearchResolutionOptions
                options, System.Management.Automation.CommandTypes
                commandTypes, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new System.Management.Automation.CommandSearcher(commandName, options, commandTypes, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 57606, 57767);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1145, 57444, 57811);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1145, 57444, 57811);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual CommandSearcher GetCommandSearcherForSearch(string pattern, ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1145, 58053, 58477);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 58180, 58434);

                CommandSearcher
                searcher =
                f_1145_58228_58433(pattern, SearchResolutionOptions.CommandNameIsPattern, CommandTypes.Cmdlet, context)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 58450, 58466);

                return searcher;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1145, 58053, 58477);

                System.Management.Automation.CommandSearcher
                f_1145_58228_58433(string
                commandName, System.Management.Automation.SearchResolutionOptions
                options, System.Management.Automation.CommandTypes
                commandTypes, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new System.Management.Automation.CommandSearcher(commandName, options, commandTypes, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 58228, 58433);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1145, 58053, 58477);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1145, 58053, 58477);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [TraceSource("CommandHelpProvider", "CommandHelpProvider")]
        private static readonly PSTraceSource s_tracer;
        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1145, 911, 58761);

        System.Management.Automation.ExecutionContext
        f_1145_1189_1216(System.Management.Automation.HelpSystem
        this_param)
        {
            var return_v = this_param.ExecutionContext;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 1189, 1216);
            return return_v;
        }


        static System.Management.Automation.HelpSystem
        f_1145_1142_1152_C(System.Management.Automation.HelpSystem
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1145, 1083, 1228);
            return return_v;
        }


        static int
        f_1145_1340_1465(System.Collections.Generic.Dictionary<string, string>
        this_param, string
        key, string
        value)
        {
            this_param.Add(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 1340, 1465);
            return 0;
        }


        static int
        f_1145_1480_1585(System.Collections.Generic.Dictionary<string, string>
        this_param, string
        key, string
        value)
        {
            this_param.Add(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 1480, 1585);
            return 0;
        }


        static int
        f_1145_1600_1717(System.Collections.Generic.Dictionary<string, string>
        this_param, string
        key, string
        value)
        {
            this_param.Add(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 1600, 1717);
            return 0;
        }


        static int
        f_1145_1732_1841(System.Collections.Generic.Dictionary<string, string>
        this_param, string
        key, string
        value)
        {
            this_param.Add(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 1732, 1841);
            return 0;
        }


        static int
        f_1145_1856_1979(System.Collections.Generic.Dictionary<string, string>
        this_param, string
        key, string
        value)
        {
            this_param.Add(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 1856, 1979);
            return 0;
        }


        static int
        f_1145_1994_2104(System.Collections.Generic.Dictionary<string, string>
        this_param, string
        key, string
        value)
        {
            this_param.Add(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 1994, 2104);
            return 0;
        }


        static int
        f_1145_2119_2223(System.Collections.Generic.Dictionary<string, string>
        this_param, string
        key, string
        value)
        {
            this_param.Add(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 2119, 2223);
            return 0;
        }


        static System.Collections.Generic.Dictionary<string, string>
        f_1145_2319_2351()
        {
            var return_v = new System.Collections.Generic.Dictionary<string, string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 2319, 2351);
            return return_v;
        }


        System.Collections.Hashtable
        f_1145_21532_21547()
        {
            var return_v = new System.Collections.Hashtable();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 21532, 21547);
            return return_v;
        }


        static System.Management.Automation.PSTraceSource
        f_1145_58655_58724(string
        name, string
        description)
        {
            var return_v = PSTraceSource.GetTracer(name, description);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 58655, 58724);
            return return_v;
        }

    }
    internal class UserDefinedHelpData
    {
        private UserDefinedHelpData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1145, 59145, 59196);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 59208, 59331);
                this.Properties = f_1145_59266_59330(f_1145_59297_59329());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 59358, 59370);
                this._name = null;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1145, 59145, 59196);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1145, 59145, 59196);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1145, 59145, 59196);
            }
        }

        internal Dictionary<string, string> Properties { get; }

        private string _name;

        internal string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1145, 59428, 59492);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 59464, 59477);

                    return _name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1145, 59428, 59492);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1145, 59383, 59503);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1145, 59383, 59503);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static UserDefinedHelpData Load(XmlNode dataNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1145, 59515, 60439);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 59598, 59649) || true) && (dataNode == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 59598, 59649);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 59637, 59649);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 59598, 59649);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 59665, 59733);

                UserDefinedHelpData
                userDefinedHelpData = f_1145_59707_59732()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 59758, 59763);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 59749, 60071) || true) && (i < f_1145_59769_59794(f_1145_59769_59788(dataNode)))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 59796, 59799)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 59749, 60071))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 59749, 60071);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 59833, 59871);

                        XmlNode
                        node = f_1145_59848_59870(f_1145_59848_59867(dataNode), i)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 59889, 60056) || true) && (f_1145_59893_59906(node) == XmlNodeType.Element)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 59889, 60056);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 59971, 60037);

                            f_1145_59971_60001(userDefinedHelpData)[f_1145_60002_60011(node)] = f_1145_60015_60036(f_1145_60015_60029(node));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 59889, 60056);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1145, 1, 323);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1145, 1, 323);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 60087, 60099);

                string
                name
                = default(string);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 60113, 60239) || true) && (!f_1145_60118_60178(f_1145_60118_60148(userDefinedHelpData), "name", out name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 60113, 60239);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 60212, 60224);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 60113, 60239);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 60255, 60288);

                userDefinedHelpData._name = name;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 60304, 60385) || true) && (f_1145_60308_60354(f_1145_60329_60353(userDefinedHelpData)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1145, 60304, 60385);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 60373, 60385);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1145, 60304, 60385);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1145, 60401, 60428);

                return userDefinedHelpData;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1145, 59515, 60439);

                System.Management.Automation.UserDefinedHelpData
                f_1145_59707_59732()
                {
                    var return_v = new System.Management.Automation.UserDefinedHelpData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 59707, 59732);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_1145_59769_59788(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.ChildNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 59769, 59788);
                    return return_v;
                }


                int
                f_1145_59769_59794(System.Xml.XmlNodeList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 59769, 59794);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_1145_59848_59867(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.ChildNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 59848, 59867);
                    return return_v;
                }


                System.Xml.XmlNode
                f_1145_59848_59870(System.Xml.XmlNodeList
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 59848, 59870);
                    return return_v;
                }


                System.Xml.XmlNodeType
                f_1145_59893_59906(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.NodeType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 59893, 59906);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, string>
                f_1145_59971_60001(System.Management.Automation.UserDefinedHelpData
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 59971, 60001);
                    return return_v;
                }


                string
                f_1145_60002_60011(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 60002, 60011);
                    return return_v;
                }


                string
                f_1145_60015_60029(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.InnerText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 60015, 60029);
                    return return_v;
                }


                string
                f_1145_60015_60036(string
                this_param)
                {
                    var return_v = this_param.Trim();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 60015, 60036);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, string>
                f_1145_60118_60148(System.Management.Automation.UserDefinedHelpData
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 60118, 60148);
                    return return_v;
                }


                bool
                f_1145_60118_60178(System.Collections.Generic.Dictionary<string, string>
                this_param, string
                key, out string
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 60118, 60178);
                    return return_v;
                }


                string
                f_1145_60329_60353(System.Management.Automation.UserDefinedHelpData
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 60329, 60353);
                    return return_v;
                }


                bool
                f_1145_60308_60354(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 60308, 60354);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1145, 59515, 60439);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1145, 59515, 60439);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static UserDefinedHelpData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1145, 59094, 60446);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1145, 59094, 60446);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1145, 59094, 60446);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1145, 59094, 60446);

        System.StringComparer
        f_1145_59297_59329()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1145, 59297, 59329);
            return return_v;
        }


        System.Collections.Generic.Dictionary<string, string>
        f_1145_59266_59330(System.StringComparer
        comparer)
        {
            var return_v = new System.Collections.Generic.Dictionary<string, string>((System.Collections.Generic.IEqualityComparer<string>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1145, 59266, 59330);
            return return_v;
        }

    }
}
