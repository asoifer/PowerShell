// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management.Automation.Host;
using System.Management.Automation.Internal;
using System.Management.Automation.Runspaces;
using System.Security;

using Microsoft.PowerShell.Commands;
using Microsoft.Win32;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation
{
    public class CommandLookupEventArgs : EventArgs
    {
        internal CommandLookupEventArgs(string commandName, CommandOrigin commandOrigin, ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1246, 1147, 1392);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 1429, 1437);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 1553, 1587);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 1717, 1760);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 1893, 1929);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 2056, 2096);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 2980, 2992);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 1278, 1304);

                CommandName = commandName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 1318, 1348);

                CommandOrigin = commandOrigin;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 1362, 1381);

                _context = context;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1246, 1147, 1392);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 1147, 1392);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 1147, 1392);
            }
        }

        private ExecutionContext _context;

        public string CommandName { get; }

        public CommandOrigin CommandOrigin { get; }

        public bool StopSearch { get; set; }

        public CommandInfo Command { get; set; }

        public ScriptBlock CommandScriptBlock
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1246, 2380, 2408);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 2386, 2406);

                    return _scriptBlock;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1246, 2380, 2408);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 2318, 2948);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 2318, 2948);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1246, 2424, 2937);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 2460, 2481);

                    _scriptBlock = value;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 2499, 2922) || true) && (_scriptBlock != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 2499, 2922);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 2565, 2639);

                        string
                        dynamicName = "LookupHandlerReplacementFor<<" + f_1246_2620_2631() + ">>"
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 2661, 2725);

                        Command = f_1246_2671_2724(dynamicName, _scriptBlock, _context);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 2747, 2765);

                        StopSearch = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 2499, 2922);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 2499, 2922);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 2847, 2862);

                        Command = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 2884, 2903);

                        StopSearch = false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 2499, 2922);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1246, 2424, 2937);

                    string
                    f_1246_2620_2631()
                    {
                        var return_v = CommandName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 2620, 2631);
                        return return_v;
                    }


                    System.Management.Automation.FunctionInfo
                    f_1246_2671_2724(string
                    name, System.Management.Automation.ScriptBlock
                    function, System.Management.Automation.ExecutionContext
                    context)
                    {
                        var return_v = new System.Management.Automation.FunctionInfo(name, function, context);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 2671, 2724);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 2318, 2948);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 2318, 2948);
                }
            }
        }

        private ScriptBlock _scriptBlock;

        static CommandLookupEventArgs()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1246, 705, 3000);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1246, 705, 3000);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 705, 3000);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1246, 705, 3000);
    }

    /// <summary>
    /// Defines the preference options for the Module Auto-loading feature.
    /// </summary>
    public enum PSModuleAutoLoadingPreference
    {
        /// <summary>
        /// Do not auto-load modules when a command is not found.
        /// </summary>
        None = 0,

        /// <summary>
        /// Only auto-load modules when a command is not found, and the command
        /// is module-qualified.
        /// </summary>
        ModuleQualified = 1,

        /// <summary>
        /// Auto-load modules when a command is not found.
        /// </summary>
        All = 2
    }
    internal class CommandDiscovery
    {
        [TraceSource("CommandDiscovery", "Traces the discovery of cmdlets, scripts, functions, applications, etc.")]
        internal static PSTraceSource discoveryTracer;

        internal CommandDiscovery(ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1246, 4364, 4659);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 60482, 60554);
                this._activePreLookup = f_1246_60501_60554(f_1246_60521_60553());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 60589, 60664);
                this._activeModuleSearch = f_1246_60611_60664(f_1246_60631_60663());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 60699, 60777);
                this._activeCommandNotFound = f_1246_60724_60777(f_1246_60744_60776());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 60812, 60886);
                this._activePostCommand = f_1246_60833_60886(f_1246_60853_60885());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 64568, 64586);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 64730, 64743);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 64888, 64899);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 71386, 71428);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 4440, 4564) || true) && (context == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 4440, 4564);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 4493, 4549);

                    throw f_1246_4499_4548("context");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 4440, 4564);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 4580, 4598);

                Context = context;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 4612, 4648);

                discoveryTracer.ShowHeaders = false;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1246, 4364, 4659);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 4364, 4659);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 4364, 4659);
            }
        }

        private bool IsSpecialCmdlet(Type implementingType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1246, 5083, 5566);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 5447, 5555);

                return implementingType == typeof(OutLineOutputCommand) || (DynAbs.Tracing.TraceSender.Expression_False(1246, 5454, 5554) || implementingType == typeof(FormatDefaultCommand));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1246, 5083, 5566);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 5083, 5566);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 5083, 5566);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private CmdletInfo NewCmdletInfo(SessionStateCmdletEntry entry)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1246, 5578, 5714);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 5666, 5703);

                return f_1246_5673_5702(entry, f_1246_5694_5701());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1246, 5578, 5714);

                System.Management.Automation.ExecutionContext
                f_1246_5694_5701()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 5694, 5701);
                    return return_v;
                }


                System.Management.Automation.CmdletInfo
                f_1246_5673_5702(System.Management.Automation.Runspaces.SessionStateCmdletEntry
                entry, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = NewCmdletInfo(entry, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 5673, 5702);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 5578, 5714);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 5578, 5714);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static CmdletInfo NewCmdletInfo(SessionStateCmdletEntry entry, ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1246, 5726, 6112);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 5848, 6077);

                CmdletInfo
                ci = new CmdletInfo(f_1246_5879_5889(entry), f_1246_5891_5913(entry), f_1246_5915_5933(entry), f_1246_5935_5949(entry), context)
                {
                    Visibility = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1246_6005_6021(entry), 1246, 5864, 6076),
                    Module = f_1246_6049_6061(entry)
                }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 6091, 6101);

                return ci;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1246, 5726, 6112);

                string
                f_1246_5879_5889(System.Management.Automation.Runspaces.SessionStateCmdletEntry
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 5879, 5889);
                    return return_v;
                }


                System.Type
                f_1246_5891_5913(System.Management.Automation.Runspaces.SessionStateCmdletEntry
                this_param)
                {
                    var return_v = this_param.ImplementingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 5891, 5913);
                    return return_v;
                }


                string
                f_1246_5915_5933(System.Management.Automation.Runspaces.SessionStateCmdletEntry
                this_param)
                {
                    var return_v = this_param.HelpFileName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 5915, 5933);
                    return return_v;
                }


                System.Management.Automation.PSSnapInInfo
                f_1246_5935_5949(System.Management.Automation.Runspaces.SessionStateCmdletEntry
                this_param)
                {
                    var return_v = this_param.PSSnapIn;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 5935, 5949);
                    return return_v;
                }


                System.Management.Automation.SessionStateEntryVisibility
                f_1246_6005_6021(System.Management.Automation.Runspaces.SessionStateCmdletEntry
                this_param)
                {
                    var return_v = this_param.Visibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 6005, 6021);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1246_6049_6061(System.Management.Automation.Runspaces.SessionStateCmdletEntry
                this_param)
                {
                    var return_v = this_param.Module
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 6049, 6061);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 5726, 6112);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 5726, 6112);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static AliasInfo NewAliasInfo(SessionStateAliasEntry entry, ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1246, 6124, 6478);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 6243, 6443);

                AliasInfo
                ci = new AliasInfo(f_1246_6272_6282(entry), f_1246_6284_6300(entry), context, f_1246_6311_6324(entry))
                {
                    Visibility = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1246_6371_6387(entry), 1246, 6258, 6442),
                    Module = f_1246_6415_6427(entry)
                }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 6457, 6467);

                return ci;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1246, 6124, 6478);

                string
                f_1246_6272_6282(System.Management.Automation.Runspaces.SessionStateAliasEntry
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 6272, 6282);
                    return return_v;
                }


                string
                f_1246_6284_6300(System.Management.Automation.Runspaces.SessionStateAliasEntry
                this_param)
                {
                    var return_v = this_param.Definition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 6284, 6300);
                    return return_v;
                }


                System.Management.Automation.ScopedItemOptions
                f_1246_6311_6324(System.Management.Automation.Runspaces.SessionStateAliasEntry
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 6311, 6324);
                    return return_v;
                }


                System.Management.Automation.SessionStateEntryVisibility
                f_1246_6371_6387(System.Management.Automation.Runspaces.SessionStateAliasEntry
                this_param)
                {
                    var return_v = this_param.Visibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 6371, 6387);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1246_6415_6427(System.Management.Automation.Runspaces.SessionStateAliasEntry
                this_param)
                {
                    var return_v = this_param.Module
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 6415, 6427);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 6124, 6478);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 6124, 6478);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal CmdletInfo AddCmdletInfoToCache(string name, CmdletInfo newCmdletInfo, bool isGlobal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1246, 7172, 8165);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 7291, 7419) || true) && (f_1246_7295_7321(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 7291, 7419);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 7355, 7404);

                    throw f_1246_7361_7403("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 7291, 7419);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 7435, 7564) || true) && (newCmdletInfo == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 7435, 7564);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 7494, 7549);

                    throw f_1246_7500_7548("cmdlet");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 7435, 7564);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 7580, 8006) || true) && (isGlobal)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 7580, 8006);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 7860, 7991);

                    return f_1246_7867_7990(f_1246_7867_7905(f_1246_7867_7893(f_1246_7867_7874())), f_1246_7923_7941(newCmdletInfo), newCmdletInfo, CommandOrigin.Internal, f_1246_7982_7989());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 7580, 8006);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 8022, 8154);

                return f_1246_8029_8153(f_1246_8029_8068(f_1246_8029_8055(f_1246_8029_8036())), f_1246_8086_8104(newCmdletInfo), newCmdletInfo, CommandOrigin.Internal, f_1246_8145_8152());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1246, 7172, 8165);

                bool
                f_1246_7295_7321(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 7295, 7321);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1246_7361_7403(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 7361, 7403);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1246_7500_7548(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 7500, 7548);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1246_7867_7874()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 7867, 7874);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1246_7867_7893(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 7867, 7893);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1246_7867_7905(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ModuleScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 7867, 7905);
                    return return_v;
                }


                string
                f_1246_7923_7941(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 7923, 7941);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1246_7982_7989()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 7982, 7989);
                    return return_v;
                }


                System.Management.Automation.CmdletInfo
                f_1246_7867_7990(System.Management.Automation.SessionStateScope
                this_param, string
                name, System.Management.Automation.CmdletInfo
                cmdlet, System.Management.Automation.CommandOrigin
                origin, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = this_param.AddCmdletToCache(name, cmdlet, origin, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 7867, 7990);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1246_8029_8036()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 8029, 8036);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1246_8029_8055(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 8029, 8055);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1246_8029_8068(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 8029, 8068);
                    return return_v;
                }


                string
                f_1246_8086_8104(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 8086, 8104);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1246_8145_8152()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 8145, 8152);
                    return return_v;
                }


                System.Management.Automation.CmdletInfo
                f_1246_8029_8153(System.Management.Automation.SessionStateScope
                this_param, string
                name, System.Management.Automation.CmdletInfo
                cmdlet, System.Management.Automation.CommandOrigin
                origin, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = this_param.AddCmdletToCache(name, cmdlet, origin, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 8029, 8153);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 7172, 8165);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 7172, 8165);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void AddSessionStateCmdletEntryToCache(SessionStateCmdletEntry entry)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1246, 8332, 8503);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 8435, 8492);

                f_1246_8435_8491(this, entry, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1246, 8332, 8503);

                int
                f_1246_8435_8491(System.Management.Automation.CommandDiscovery
                this_param, System.Management.Automation.Runspaces.SessionStateCmdletEntry
                entry, bool
                local)
                {
                    this_param.AddSessionStateCmdletEntryToCache(entry, local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 8435, 8491);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 8332, 8503);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 8332, 8503);
            }
        }

        internal void AddSessionStateCmdletEntryToCache(SessionStateCmdletEntry entry, bool local)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1246, 8712, 9031);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 8827, 9020) || true) && (!f_1246_8832_8871(this, f_1246_8848_8870(entry)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 8827, 9020);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 8905, 8943);

                    CmdletInfo
                    nci = f_1246_8922_8942(this, entry)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 8961, 9005);

                    f_1246_8961_9004(this, f_1246_8982_8990(nci), nci, !local);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 8827, 9020);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1246, 8712, 9031);

                System.Type
                f_1246_8848_8870(System.Management.Automation.Runspaces.SessionStateCmdletEntry
                this_param)
                {
                    var return_v = this_param.ImplementingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 8848, 8870);
                    return return_v;
                }


                bool
                f_1246_8832_8871(System.Management.Automation.CommandDiscovery
                this_param, System.Type
                implementingType)
                {
                    var return_v = this_param.IsSpecialCmdlet(implementingType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 8832, 8871);
                    return return_v;
                }


                System.Management.Automation.CmdletInfo
                f_1246_8922_8942(System.Management.Automation.CommandDiscovery
                this_param, System.Management.Automation.Runspaces.SessionStateCmdletEntry
                entry)
                {
                    var return_v = this_param.NewCmdletInfo(entry);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 8922, 8942);
                    return return_v;
                }


                string
                f_1246_8982_8990(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 8982, 8990);
                    return return_v;
                }


                System.Management.Automation.CmdletInfo
                f_1246_8961_9004(System.Management.Automation.CommandDiscovery
                this_param, string
                name, System.Management.Automation.CmdletInfo
                newCmdletInfo, bool
                isGlobal)
                {
                    var return_v = this_param.AddCmdletInfoToCache(name, newCmdletInfo, isGlobal);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 8961, 9004);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 8712, 9031);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 8712, 9031);
            }
        }

        internal CommandProcessorBase LookupCommandProcessor(string commandName,
                    CommandOrigin commandOrigin, bool? useLocalScope)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1246, 10114, 10804);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 10274, 10312);

                CommandProcessorBase
                processor = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 10326, 10398);

                CommandInfo
                commandInfo = f_1246_10352_10397(this, commandName, commandOrigin)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 10414, 10760) || true) && (commandInfo != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 10414, 10760);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 10471, 10555);

                    processor = f_1246_10483_10554(this, commandInfo, commandOrigin, useLocalScope, null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 10685, 10745);

                    f_1246_10685_10715(f_1246_10685_10702(processor)).InvocationName = commandName;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 10414, 10760);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 10776, 10793);

                return processor;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1246, 10114, 10804);

                System.Management.Automation.CommandInfo
                f_1246_10352_10397(System.Management.Automation.CommandDiscovery
                this_param, string
                commandName, System.Management.Automation.CommandOrigin
                commandOrigin)
                {
                    var return_v = this_param.LookupCommandInfo(commandName, commandOrigin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 10352, 10397);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1246_10483_10554(System.Management.Automation.CommandDiscovery
                this_param, System.Management.Automation.CommandInfo
                commandInfo, System.Management.Automation.CommandOrigin
                commandOrigin, bool?
                useLocalScope, System.Management.Automation.SessionStateInternal
                sessionState)
                {
                    var return_v = this_param.LookupCommandProcessor(commandInfo, commandOrigin, useLocalScope, sessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 10483, 10554);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1246_10685_10702(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 10685, 10702);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1246_10685_10715(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 10685, 10715);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 10114, 10804);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 10114, 10804);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void VerifyRequiredModules(ExternalScriptInfo scriptInfo, ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1246, 10816, 12244);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 10979, 12233) || true) && (f_1246_10983_11009(scriptInfo) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 10979, 12233);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 11051, 12218);
                        foreach (var requiredModule in f_1246_11082_11108_I(f_1246_11082_11108(scriptInfo)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 11051, 12218);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 11150, 11175);

                            ErrorRecord
                            error = null
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 11197, 11647);

                            f_1246_11197_11646(context: context, currentModule: null, requiredModuleSpecification: requiredModule, moduleManifestPath: null, manifestProcessingFlags: ModuleCmdletBase.ManifestProcessingFlags.LoadElements | ModuleCmdletBase.ManifestProcessingFlags.WriteErrors, error: out error);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 11669, 12199) || true) && (error != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 11669, 12199);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 11736, 12120);

                                ScriptRequiresException
                                scriptRequiresException =
                                f_1246_11815_12119(f_1246_11877_11892(scriptInfo), new Collection<string> { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1246_11952_11971(requiredModule), 1246, 11927, 11973) }, "ScriptRequiresMissingModules", false, error)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 12146, 12176);

                                throw scriptRequiresException;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 11669, 12199);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 11051, 12218);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1246, 1, 1168);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1246, 1, 1168);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 10979, 12233);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1246, 10816, 12244);

                System.Collections.Generic.IEnumerable<Microsoft.PowerShell.Commands.ModuleSpecification>
                f_1246_10983_11009(System.Management.Automation.ExternalScriptInfo
                this_param)
                {
                    var return_v = this_param.RequiresModules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 10983, 11009);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.PowerShell.Commands.ModuleSpecification>
                f_1246_11082_11108(System.Management.Automation.ExternalScriptInfo
                this_param)
                {
                    var return_v = this_param.RequiresModules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 11082, 11108);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1246_11197_11646(System.Management.Automation.ExecutionContext
                context, System.Management.Automation.PSModuleInfo
                currentModule, Microsoft.PowerShell.Commands.ModuleSpecification
                requiredModuleSpecification, string
                moduleManifestPath, Microsoft.PowerShell.Commands.ModuleCmdletBase.ManifestProcessingFlags
                manifestProcessingFlags, out System.Management.Automation.ErrorRecord
                error)
                {
                    var return_v = ModuleCmdletBase.LoadRequiredModule(context: context, currentModule: currentModule, requiredModuleSpecification: requiredModuleSpecification, moduleManifestPath: moduleManifestPath, manifestProcessingFlags: manifestProcessingFlags, out error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 11197, 11646);
                    return return_v;
                }


                string
                f_1246_11877_11892(System.Management.Automation.ExternalScriptInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 11877, 11892);
                    return return_v;
                }


                string
                f_1246_11952_11971(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 11952, 11971);
                    return return_v;
                }


                System.Management.Automation.ScriptRequiresException
                f_1246_11815_12119(string
                commandName, System.Collections.ObjectModel.Collection<string>
                missingItems, string
                errorId, bool
                forSnapins, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    var return_v = new System.Management.Automation.ScriptRequiresException(commandName, missingItems, errorId, forSnapins, errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 11815, 12119);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.PowerShell.Commands.ModuleSpecification>
                f_1246_11082_11108_I(System.Collections.Generic.IEnumerable<Microsoft.PowerShell.Commands.ModuleSpecification>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 11082, 11108);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 10816, 12244);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 10816, 12244);
            }
        }

        private static Collection<string> GetPSSnapinNames(IEnumerable<PSSnapInSpecification> PSSnapins)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1246, 12256, 12617);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 12377, 12430);

                Collection<string>
                result = f_1246_12405_12429()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 12446, 12576);
                    foreach (var PSSnapin in f_1246_12471_12480_I(PSSnapins))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 12446, 12576);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 12514, 12561);

                        f_1246_12514_12560(result, f_1246_12525_12559(PSSnapin));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 12446, 12576);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1246, 1, 131);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1246, 1, 131);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 12592, 12606);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1246, 12256, 12617);

                System.Collections.ObjectModel.Collection<string>
                f_1246_12405_12429()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 12405, 12429);
                    return return_v;
                }


                string
                f_1246_12525_12559(System.Management.Automation.PSSnapInSpecification
                PSSnapin)
                {
                    var return_v = BuildPSSnapInDisplayName(PSSnapin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 12525, 12559);
                    return return_v;
                }


                int
                f_1246_12514_12560(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 12514, 12560);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSSnapInSpecification>
                f_1246_12471_12480_I(System.Collections.Generic.IEnumerable<System.Management.Automation.PSSnapInSpecification>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 12471, 12480);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 12256, 12617);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 12256, 12617);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private CommandProcessorBase CreateScriptProcessorForSingleShell(ExternalScriptInfo scriptInfo, ExecutionContext context, bool useLocalScope, SessionStateInternal sessionState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1246, 12629, 14458);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 12830, 12876);

                f_1246_12830_12875(scriptInfo, f_1246_12867_12874());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 12892, 12976);

                IEnumerable<PSSnapInSpecification>
                requiresPSSnapIns = f_1246_12947_12975(scriptInfo)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 12990, 14342) || true) && (requiresPSSnapIns != null && (DynAbs.Tracing.TraceSender.Expression_True(1246, 12994, 13046) && f_1246_13023_13046(requiresPSSnapIns)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 12990, 14342);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 13080, 13131);

                    Collection<string>
                    requiresMissingPSSnapIns = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 13149, 13229);

                    f_1246_13149_13228(requiresPSSnapIns, context, out requiresMissingPSSnapIns);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 13247, 13699) || true) && (requiresMissingPSSnapIns != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 13247, 13699);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 13325, 13628);

                        ScriptRequiresException
                        scriptRequiresException =
                        f_1246_13400_13627(f_1246_13458_13473(scriptInfo), requiresMissingPSSnapIns, "ScriptRequiresMissingPSSnapIns", true)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 13650, 13680);

                        throw scriptRequiresException;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 13247, 13699);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 12990, 14342);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 12990, 14342);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 13898, 14327) || true) && (!f_1246_13903_13957(f_1246_13924_13956(scriptInfo)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 13898, 14327);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 13999, 14274);

                        ScriptRequiresException
                        sre =
                        f_1246_14052_14273(f_1246_14108_14123(scriptInfo), string.Empty, string.Empty, "RequiresShellIDInvalidForSingleShell")
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 14298, 14308);

                        throw sre;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 13898, 14327);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 12990, 14342);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 14358, 14447);

                return f_1246_14365_14446(scriptInfo, f_1246_14409_14416(), useLocalScope, sessionState);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1246, 12629, 14458);

                System.Management.Automation.ExecutionContext
                f_1246_12867_12874()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 12867, 12874);
                    return return_v;
                }


                int
                f_1246_12830_12875(System.Management.Automation.ExternalScriptInfo
                scriptInfo, System.Management.Automation.ExecutionContext
                context)
                {
                    VerifyScriptRequirements(scriptInfo, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 12830, 12875);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSSnapInSpecification>
                f_1246_12947_12975(System.Management.Automation.ExternalScriptInfo
                this_param)
                {
                    var return_v = this_param.RequiresPSSnapIns;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 12947, 12975);
                    return return_v;
                }


                bool
                f_1246_13023_13046(System.Collections.Generic.IEnumerable<System.Management.Automation.PSSnapInSpecification>
                source)
                {
                    var return_v = source.Any<System.Management.Automation.PSSnapInSpecification>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 13023, 13046);
                    return return_v;
                }


                int
                f_1246_13149_13228(System.Collections.Generic.IEnumerable<System.Management.Automation.PSSnapInSpecification>
                requiresPSSnapIns, System.Management.Automation.ExecutionContext
                context, out System.Collections.ObjectModel.Collection<string>
                requiresMissingPSSnapIns)
                {
                    VerifyRequiredSnapins(requiresPSSnapIns, context, out requiresMissingPSSnapIns);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 13149, 13228);
                    return 0;
                }


                string
                f_1246_13458_13473(System.Management.Automation.ExternalScriptInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 13458, 13473);
                    return return_v;
                }


                System.Management.Automation.ScriptRequiresException
                f_1246_13400_13627(string
                commandName, System.Collections.ObjectModel.Collection<string>
                missingItems, string
                errorId, bool
                forSnapins)
                {
                    var return_v = new System.Management.Automation.ScriptRequiresException(commandName, missingItems, errorId, forSnapins);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 13400, 13627);
                    return return_v;
                }


                string
                f_1246_13924_13956(System.Management.Automation.ExternalScriptInfo
                this_param)
                {
                    var return_v = this_param.RequiresApplicationID;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 13924, 13956);
                    return return_v;
                }


                bool
                f_1246_13903_13957(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 13903, 13957);
                    return return_v;
                }


                string
                f_1246_14108_14123(System.Management.Automation.ExternalScriptInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 14108, 14123);
                    return return_v;
                }


                System.Management.Automation.ScriptRequiresException
                f_1246_14052_14273(string
                commandName, string
                requiresShellId, string
                requiresShellPath, string
                errorId)
                {
                    var return_v = new System.Management.Automation.ScriptRequiresException(commandName, requiresShellId, requiresShellPath, errorId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 14052, 14273);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1246_14409_14416()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 14409, 14416);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1246_14365_14446(System.Management.Automation.ExternalScriptInfo
                scriptInfo, System.Management.Automation.ExecutionContext
                context, bool
                useNewScope, System.Management.Automation.SessionStateInternal
                sessionState)
                {
                    var return_v = CreateCommandProcessorForScript(scriptInfo, context, useNewScope, sessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 14365, 14446);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 12629, 14458);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 12629, 14458);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void VerifyRequiredSnapins(IEnumerable<PSSnapInSpecification> requiresPSSnapIns, ExecutionContext context, out Collection<string> requiresMissingPSSnapIns)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1246, 14470, 16600);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 14665, 14697);

                requiresMissingPSSnapIns = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 14711, 14815);

                f_1246_14711_14814(f_1246_14722_14749(context) != null, "PowerShell should be hosted with InitialSessionState");
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 14831, 16589);
                    foreach (var requiresPSSnapIn in f_1246_14864_14881_I(requiresPSSnapIns))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 14831, 16589);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 14915, 14964);

                        IEnumerable<PSSnapInInfo>
                        loadedPSSnapIns = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 14982, 15063);

                        loadedPSSnapIns = f_1246_15000_15062(f_1246_15000_15027(context), f_1246_15040_15061(requiresPSSnapIn));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 15081, 16574) || true) && (loadedPSSnapIns == null || (DynAbs.Tracing.TraceSender.Expression_False(1246, 15085, 15140) || f_1246_15112_15135(loadedPSSnapIns) == 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 15081, 16574);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 15182, 15343) || true) && (requiresMissingPSSnapIns == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 15182, 15343);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 15268, 15320);

                                requiresMissingPSSnapIns = f_1246_15295_15319();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 15182, 15343);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 15367, 15440);

                            f_1246_15367_15439(
                                                requiresMissingPSSnapIns, f_1246_15396_15438(requiresPSSnapIn));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 15081, 16574);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 15081, 16574);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 15610, 15664);

                            PSSnapInInfo
                            loadedPSSnapIn = f_1246_15640_15663(loadedPSSnapIns)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 15686, 15926);

                            f_1246_15686_15925(f_1246_15705_15727(loadedPSSnapIn) != null, f_1246_15762_15924(f_1246_15806_15834(), "Version is null for loaded PSSnapin {0}.", loadedPSSnapIn));

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 15948, 16555) || true) && (f_1246_15952_15976(requiresPSSnapIn) != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 15948, 16555);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 16034, 16532) || true) && (!f_1246_16039_16157(f_1246_16108_16132(requiresPSSnapIn), f_1246_16134_16156(loadedPSSnapIn)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 16034, 16532);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 16215, 16400) || true) && (requiresMissingPSSnapIns == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 16215, 16400);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 16317, 16369);

                                        requiresMissingPSSnapIns = f_1246_16344_16368();
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 16215, 16400);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 16432, 16505);

                                    f_1246_16432_16504(
                                                                requiresMissingPSSnapIns, f_1246_16461_16503(requiresPSSnapIn));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 16034, 16532);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 15948, 16555);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 15081, 16574);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 14831, 16589);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1246, 1, 1759);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1246, 1, 1759);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1246, 14470, 16600);

                System.Management.Automation.Runspaces.InitialSessionState
                f_1246_14722_14749(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.InitialSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 14722, 14749);
                    return return_v;
                }


                int
                f_1246_14711_14814(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 14711, 14814);
                    return 0;
                }


                System.Management.Automation.Runspaces.InitialSessionState
                f_1246_15000_15027(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.InitialSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 15000, 15027);
                    return return_v;
                }


                string
                f_1246_15040_15061(System.Management.Automation.PSSnapInSpecification
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 15040, 15061);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSSnapInInfo>
                f_1246_15000_15062(System.Management.Automation.Runspaces.InitialSessionState
                this_param, string
                psSnapinName)
                {
                    var return_v = this_param.GetPSSnapIn(psSnapinName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 15000, 15062);
                    return return_v;
                }


                int
                f_1246_15112_15135(System.Collections.Generic.IEnumerable<System.Management.Automation.PSSnapInInfo>
                source)
                {
                    var return_v = source.Count<System.Management.Automation.PSSnapInInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 15112, 15135);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1246_15295_15319()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 15295, 15319);
                    return return_v;
                }


                string
                f_1246_15396_15438(System.Management.Automation.PSSnapInSpecification
                PSSnapin)
                {
                    var return_v = BuildPSSnapInDisplayName(PSSnapin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 15396, 15438);
                    return return_v;
                }


                int
                f_1246_15367_15439(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 15367, 15439);
                    return 0;
                }


                System.Management.Automation.PSSnapInInfo
                f_1246_15640_15663(System.Collections.Generic.IEnumerable<System.Management.Automation.PSSnapInInfo>
                source)
                {
                    var return_v = source.First<System.Management.Automation.PSSnapInInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 15640, 15663);
                    return return_v;
                }


                System.Version
                f_1246_15705_15727(System.Management.Automation.PSSnapInInfo
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 15705, 15727);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1246_15806_15834()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 15806, 15834);
                    return return_v;
                }


                string
                f_1246_15762_15924(System.Globalization.CultureInfo
                provider, string
                format, System.Management.Automation.PSSnapInInfo
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 15762, 15924);
                    return return_v;
                }


                int
                f_1246_15686_15925(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 15686, 15925);
                    return 0;
                }


                System.Version
                f_1246_15952_15976(System.Management.Automation.PSSnapInSpecification
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 15952, 15976);
                    return return_v;
                }


                System.Version
                f_1246_16108_16132(System.Management.Automation.PSSnapInSpecification
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 16108, 16132);
                    return return_v;
                }


                System.Version
                f_1246_16134_16156(System.Management.Automation.PSSnapInInfo
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 16134, 16156);
                    return return_v;
                }


                bool
                f_1246_16039_16157(System.Version
                requires, System.Version
                installed)
                {
                    var return_v = AreInstalledRequiresVersionsCompatible(requires, installed);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 16039, 16157);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1246_16344_16368()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 16344, 16368);
                    return return_v;
                }


                string
                f_1246_16461_16503(System.Management.Automation.PSSnapInSpecification
                PSSnapin)
                {
                    var return_v = BuildPSSnapInDisplayName(PSSnapin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 16461, 16503);
                    return return_v;
                }


                int
                f_1246_16432_16504(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 16432, 16504);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSSnapInSpecification>
                f_1246_14864_14881_I(System.Collections.Generic.IEnumerable<System.Management.Automation.PSSnapInSpecification>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 14864, 14881);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 14470, 16600);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 14470, 16600);
            }
        }

        internal static void VerifyScriptRequirements(ExternalScriptInfo scriptInfo, ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1246, 16831, 17147);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 16958, 16995);

                f_1246_16958_16994(scriptInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 17009, 17037);

                f_1246_17009_17036(scriptInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 17051, 17079);

                f_1246_17051_17078(scriptInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 17093, 17136);

                f_1246_17093_17135(scriptInfo, context);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1246, 16831, 17147);

                int
                f_1246_16958_16994(System.Management.Automation.ExternalScriptInfo
                scriptInfo)
                {
                    VerifyElevatedPrivileges(scriptInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 16958, 16994);
                    return 0;
                }


                int
                f_1246_17009_17036(System.Management.Automation.ExternalScriptInfo
                scriptInfo)
                {
                    VerifyPSVersion(scriptInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 17009, 17036);
                    return 0;
                }


                int
                f_1246_17051_17078(System.Management.Automation.ExternalScriptInfo
                scriptInfo)
                {
                    VerifyPSEdition(scriptInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 17051, 17078);
                    return 0;
                }


                int
                f_1246_17093_17135(System.Management.Automation.ExternalScriptInfo
                scriptInfo, System.Management.Automation.ExecutionContext
                context)
                {
                    VerifyRequiredModules(scriptInfo, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 17093, 17135);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 16831, 17147);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 16831, 17147);
            }
        }

        internal static void VerifyPSVersion(ExternalScriptInfo scriptInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1246, 17159, 17939);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 17251, 17308);

                Version
                requiresPSVersion = f_1246_17279_17307(scriptInfo)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 17359, 17928) || true) && (requiresPSVersion != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 17359, 17928);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 17422, 17913) || true) && (!f_1246_17427_17472(requiresPSVersion))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 17422, 17913);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 17514, 17842);

                        ScriptRequiresException
                        scriptRequiresException =
                        f_1246_17589_17841(f_1246_17647_17662(scriptInfo), requiresPSVersion, f_1246_17741_17775(f_1246_17741_17764()), "ScriptRequiresUnmatchedPSVersion")
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 17864, 17894);

                        throw scriptRequiresException;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 17422, 17913);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 17359, 17928);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1246, 17159, 17939);

                System.Version
                f_1246_17279_17307(System.Management.Automation.ExternalScriptInfo
                this_param)
                {
                    var return_v = this_param.RequiresPSVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 17279, 17307);
                    return return_v;
                }


                bool
                f_1246_17427_17472(System.Version
                checkVersion)
                {
                    var return_v = Utils.IsPSVersionSupported(checkVersion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 17427, 17472);
                    return return_v;
                }


                string
                f_1246_17647_17662(System.Management.Automation.ExternalScriptInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 17647, 17662);
                    return return_v;
                }


                System.Version
                f_1246_17741_17764()
                {
                    var return_v = PSVersionInfo.PSVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 17741, 17764);
                    return return_v;
                }


                string
                f_1246_17741_17775(System.Version
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 17741, 17775);
                    return return_v;
                }


                System.Management.Automation.ScriptRequiresException
                f_1246_17589_17841(string
                commandName, System.Version
                requiresPSVersion, string
                currentPSVersion, string
                errorId)
                {
                    var return_v = new System.Management.Automation.ScriptRequiresException(commandName, requiresPSVersion, currentPSVersion, errorId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 17589, 17841);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 17159, 17939);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 17159, 17939);
            }
        }

        internal static void VerifyPSEdition(ExternalScriptInfo scriptInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1246, 17951, 19449);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 18043, 19438) || true) && (f_1246_18047_18076(scriptInfo) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 18043, 19438);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 18118, 18153);

                    var
                    isCurrentEditionListed = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 18171, 18212);

                    var
                    isRequiresPSEditionSpecified = false
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 18230, 18590);
                        foreach (var edition in f_1246_18254_18283_I(f_1246_18254_18283(scriptInfo)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 18230, 18590);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 18325, 18361);

                            isRequiresPSEditionSpecified = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 18383, 18444);

                            isCurrentEditionListed = f_1246_18408_18443(edition);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 18466, 18571) || true) && (isCurrentEditionListed)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 18466, 18571);
                                DynAbs.Tracing.TraceSender.TraceBreak(1246, 18542, 18548);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 18466, 18571);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 18230, 18590);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1246, 1, 361);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1246, 1, 361);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 18755, 19423) || true) && (isRequiresPSEditionSpecified && (DynAbs.Tracing.TraceSender.Expression_True(1246, 18759, 18814) && !isCurrentEditionListed))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 18755, 19423);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 18856, 18934);

                        var
                        specifiedEditionsString = f_1246_18886_18933(",", f_1246_18903_18932(scriptInfo))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 18956, 19182);

                        var
                        message = f_1246_18970_19181(f_1246_18988_19038(), f_1246_19065_19080(scriptInfo), specifiedEditionsString, f_1246_19157_19180())
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 19204, 19243);

                        var
                        ex = f_1246_19213_19242(message)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 19265, 19315);

                        f_1246_19265_19314(ex, "ScriptRequiresUnmatchedPSEdition");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 19337, 19373);

                        f_1246_19337_19372(ex, f_1246_19356_19371(scriptInfo));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 19395, 19404);

                        throw ex;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 18755, 19423);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 18043, 19438);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1246, 17951, 19449);

                System.Collections.Generic.IEnumerable<string>
                f_1246_18047_18076(System.Management.Automation.ExternalScriptInfo
                this_param)
                {
                    var return_v = this_param.RequiresPSEditions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 18047, 18076);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1246_18254_18283(System.Management.Automation.ExternalScriptInfo
                this_param)
                {
                    var return_v = this_param.RequiresPSEditions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 18254, 18283);
                    return return_v;
                }


                bool
                f_1246_18408_18443(string
                checkEdition)
                {
                    var return_v = Utils.IsPSEditionSupported(checkEdition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 18408, 18443);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1246_18254_18283_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 18254, 18283);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1246_18903_18932(System.Management.Automation.ExternalScriptInfo
                this_param)
                {
                    var return_v = this_param.RequiresPSEditions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 18903, 18932);
                    return return_v;
                }


                string
                f_1246_18886_18933(string
                separator, System.Collections.Generic.IEnumerable<string>
                values)
                {
                    var return_v = string.Join(separator, values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 18886, 18933);
                    return return_v;
                }


                string
                f_1246_18988_19038()
                {
                    var return_v = DiscoveryExceptions.RequiresPSEditionNotCompatible;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 18988, 19038);
                    return return_v;
                }


                string
                f_1246_19065_19080(System.Management.Automation.ExternalScriptInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 19065, 19080);
                    return return_v;
                }


                string
                f_1246_19157_19180()
                {
                    var return_v = PSVersionInfo.PSEdition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 19157, 19180);
                    return return_v;
                }


                string
                f_1246_18970_19181(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 18970, 19181);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1246_19213_19242(string
                message)
                {
                    var return_v = new System.Management.Automation.RuntimeException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 19213, 19242);
                    return return_v;
                }


                int
                f_1246_19265_19314(System.Management.Automation.RuntimeException
                this_param, string
                errorId)
                {
                    this_param.SetErrorId(errorId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 19265, 19314);
                    return 0;
                }


                string
                f_1246_19356_19371(System.Management.Automation.ExternalScriptInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 19356, 19371);
                    return return_v;
                }


                int
                f_1246_19337_19372(System.Management.Automation.RuntimeException
                this_param, string
                targetObject)
                {
                    this_param.SetTargetObject((object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 19337, 19372);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 17951, 19449);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 17951, 19449);
            }
        }

        internal static void VerifyElevatedPrivileges(ExternalScriptInfo scriptInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1246, 19461, 20046);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 19562, 19616);

                bool
                requiresElevation = f_1246_19587_19615(scriptInfo)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 19630, 19677);

                bool
                isAdministrator = f_1246_19653_19676()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 19691, 20035) || true) && (requiresElevation && (DynAbs.Tracing.TraceSender.Expression_True(1246, 19695, 19732) && !isAdministrator))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 19691, 20035);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 19766, 19972);

                    ScriptRequiresException
                    scriptRequiresException =
                    f_1246_19841_19971(f_1246_19899_19914(scriptInfo), "ScriptRequiresElevation")
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 19990, 20020);

                    throw scriptRequiresException;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 19691, 20035);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1246, 19461, 20046);

                bool
                f_1246_19587_19615(System.Management.Automation.ExternalScriptInfo
                this_param)
                {
                    var return_v = this_param.RequiresElevation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 19587, 19615);
                    return return_v;
                }


                bool
                f_1246_19653_19676()
                {
                    var return_v = Utils.IsAdministrator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 19653, 19676);
                    return return_v;
                }


                string
                f_1246_19899_19914(System.Management.Automation.ExternalScriptInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 19899, 19914);
                    return return_v;
                }


                System.Management.Automation.ScriptRequiresException
                f_1246_19841_19971(string
                commandName, string
                errorId)
                {
                    var return_v = new System.Management.Automation.ScriptRequiresException(commandName, errorId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 19841, 19971);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 19461, 20046);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 19461, 20046);
            }
        }

        private static bool AreInstalledRequiresVersionsCompatible(Version requires, Version installed)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1246, 20732, 20941);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 20852, 20930);

                return f_1246_20859_20873(requires) == f_1246_20877_20892(installed) && (DynAbs.Tracing.TraceSender.Expression_True(1246, 20859, 20929) && f_1246_20896_20910(requires) <= f_1246_20914_20929(installed));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1246, 20732, 20941);

                int
                f_1246_20859_20873(System.Version
                this_param)
                {
                    var return_v = this_param.Major;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 20859, 20873);
                    return return_v;
                }


                int
                f_1246_20877_20892(System.Version
                this_param)
                {
                    var return_v = this_param.Major;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 20877, 20892);
                    return return_v;
                }


                int
                f_1246_20896_20910(System.Version
                this_param)
                {
                    var return_v = this_param.Minor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 20896, 20910);
                    return return_v;
                }


                int
                f_1246_20914_20929(System.Version
                this_param)
                {
                    var return_v = this_param.Minor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 20914, 20929);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 20732, 20941);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 20732, 20941);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string BuildPSSnapInDisplayName(PSSnapInSpecification PSSnapin)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1246, 20953, 21268);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 21056, 21257);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1246, 21063, 21087) || ((f_1246_21063_21079(PSSnapin) == null && DynAbs.Tracing.TraceSender.Conditional_F2(1246, 21107, 21120)) || DynAbs.Tracing.TraceSender.Conditional_F3(1246, 21140, 21256))) ? f_1246_21107_21120(PSSnapin) : f_1246_21140_21256(f_1246_21158_21197(), f_1246_21224_21237(PSSnapin), f_1246_21239_21255(PSSnapin));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1246, 20953, 21268);

                System.Version
                f_1246_21063_21079(System.Management.Automation.PSSnapInSpecification
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 21063, 21079);
                    return return_v;
                }


                string
                f_1246_21107_21120(System.Management.Automation.PSSnapInSpecification
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 21107, 21120);
                    return return_v;
                }


                string
                f_1246_21158_21197()
                {
                    var return_v = DiscoveryExceptions.PSSnapInNameVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 21158, 21197);
                    return return_v;
                }


                string
                f_1246_21224_21237(System.Management.Automation.PSSnapInSpecification
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 21224, 21237);
                    return return_v;
                }


                System.Version
                f_1246_21239_21255(System.Management.Automation.PSSnapInSpecification
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 21239, 21255);
                    return return_v;
                }


                string
                f_1246_21140_21256(string
                formatSpec, string
                o1, System.Version
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 21140, 21256);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 20953, 21268);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 20953, 21268);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal CommandProcessorBase LookupCommandProcessor(CommandInfo commandInfo,
                    CommandOrigin commandOrigin, bool? useLocalScope, SessionStateInternal sessionState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1246, 22416, 26569);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 22616, 22654);

                CommandProcessorBase
                processor = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 22670, 22759);

                HashSet<string>
                processedAliases = f_1246_22705_22758(f_1246_22725_22757())
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 22775, 23958) || true) && (f_1246_22782_22805(commandInfo) == CommandTypes.Alias && (DynAbs.Tracing.TraceSender.Expression_True(1246, 22782, 22894) && (!f_1246_22850_22893(processedAliases, f_1246_22876_22892(commandInfo)))) && (DynAbs.Tracing.TraceSender.Expression_True(1246, 22782, 23020) && (commandOrigin == CommandOrigin.Internal || (DynAbs.Tracing.TraceSender.Expression_False(1246, 22916, 23019) || f_1246_22959_22981(commandInfo) == SessionStateEntryVisibility.Public))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 22775, 23958);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 23054, 23093);

                        f_1246_23054_23092(processedAliases, f_1246_23075_23091(commandInfo));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 23113, 23165);

                        AliasInfo
                        aliasCommandInfo = (AliasInfo)commandInfo
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 23183, 23335);

                        commandInfo = f_1246_23197_23229(aliasCommandInfo) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.CommandInfo>(1246, 23197, 23334) ?? f_1246_23264_23334(f_1246_23282_23309(aliasCommandInfo), commandOrigin, f_1246_23326_23333()));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 23455, 23943) || true) && (commandInfo == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 23455, 23943);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 23520, 23894);

                            CommandNotFoundException
                            e =
                            f_1246_23574_23893(f_1246_23633_23654(aliasCommandInfo), null, "AliasNotResolvedException", f_1246_23778_23823(), f_1246_23854_23892(aliasCommandInfo))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 23916, 23924);

                            throw e;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 23455, 23943);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 22775, 23958);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1246, 22775, 23958);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1246, 22775, 23958);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 23974, 24050);

                f_1246_23974_24049(f_1246_23984_23991(), f_1246_23993_24020(f_1246_23993_24000()), commandInfo, commandOrigin);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 24066, 26278);

                switch (f_1246_24074_24097(commandInfo))
                {

                    case CommandTypes.Application:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 24066, 26278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 24183, 24261);

                        processor = f_1246_24195_24260((ApplicationInfo)commandInfo, f_1246_24252_24259());
                        DynAbs.Tracing.TraceSender.TraceBreak(1246, 24283, 24289);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 24066, 26278);

                    case CommandTypes.Cmdlet:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 24066, 26278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 24354, 24421);

                        processor = f_1246_24366_24420((CmdletInfo)commandInfo, f_1246_24412_24419());
                        DynAbs.Tracing.TraceSender.TraceBreak(1246, 24443, 24449);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 24066, 26278);

                    case CommandTypes.ExternalScript:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 24066, 26278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 24522, 24586);

                        ExternalScriptInfo
                        scriptInfo = (ExternalScriptInfo)commandInfo
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 24608, 24643);

                        scriptInfo.SignatureChecked = true;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 24717, 24823);

                            processor = f_1246_24729_24822(this, scriptInfo, f_1246_24777_24784(), useLocalScope ?? (DynAbs.Tracing.TraceSender.Expression_Null<bool?>(1246, 24786, 24807) ?? true), sessionState);
                        }
                        catch (ScriptRequiresSyntaxException reqSyntaxException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1246, 24868, 25165);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 24973, 25108);

                            CommandNotFoundException
                            e =
                            f_1246_25031_25107(f_1246_25060_25086(reqSyntaxException), reqSyntaxException)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 25134, 25142);

                            throw e;
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1246, 24868, 25165);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1246, 25189, 25195);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 24066, 26278);

                    case CommandTypes.Filter:
                    case CommandTypes.Function:
                    case CommandTypes.Configuration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 24066, 26278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 25355, 25409);

                        FunctionInfo
                        functionInfo = (FunctionInfo)commandInfo
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 25431, 25535);

                        processor = f_1246_25443_25534(functionInfo, f_1246_25489_25496(), useLocalScope ?? (DynAbs.Tracing.TraceSender.Expression_Null<bool?>(1246, 25498, 25519) ?? true), sessionState);
                        DynAbs.Tracing.TraceSender.TraceBreak(1246, 25557, 25563);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 24066, 26278);

                    case CommandTypes.Script:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 24066, 26278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 25628, 25743);

                        processor = f_1246_25640_25742(commandInfo, f_1246_25697_25704(), useLocalScope ?? (DynAbs.Tracing.TraceSender.Expression_Null<bool?>(1246, 25706, 25727) ?? true), sessionState);
                        DynAbs.Tracing.TraceSender.TraceBreak(1246, 25765, 25771);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 24066, 26278);

                    case CommandTypes.Alias:
                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 24066, 26278);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 25888, 26206);

                            CommandNotFoundException
                            e =
                            f_1246_25946_26205(f_1246_26009_26025(commandInfo), null, "CommandNotFoundException", f_1246_26160_26204())
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 26232, 26240);

                            throw e;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 24066, 26278);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 26388, 26444);

                f_1246_26388_26405(processor).CommandOriginInternal = commandOrigin;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 26460, 26525);

                f_1246_26460_26490(f_1246_26460_26477(processor)).InvocationName = f_1246_26508_26524(commandInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 26541, 26558);

                return processor;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1246, 22416, 26569);

                System.StringComparer
                f_1246_22725_22757()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 22725, 22757);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_1246_22705_22758(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.HashSet<string>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 22705, 22758);
                    return return_v;
                }


                System.Management.Automation.CommandTypes
                f_1246_22782_22805(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.CommandType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 22782, 22805);
                    return return_v;
                }


                string
                f_1246_22876_22892(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 22876, 22892);
                    return return_v;
                }


                bool
                f_1246_22850_22893(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 22850, 22893);
                    return return_v;
                }


                System.Management.Automation.SessionStateEntryVisibility
                f_1246_22959_22981(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Visibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 22959, 22981);
                    return return_v;
                }


                string
                f_1246_23075_23091(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 23075, 23091);
                    return return_v;
                }


                bool
                f_1246_23054_23092(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 23054, 23092);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1246_23197_23229(System.Management.Automation.AliasInfo
                this_param)
                {
                    var return_v = this_param.ResolvedCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 23197, 23229);
                    return return_v;
                }


                string
                f_1246_23282_23309(System.Management.Automation.AliasInfo
                this_param)
                {
                    var return_v = this_param.Definition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 23282, 23309);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1246_23326_23333()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 23326, 23333);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1246_23264_23334(string
                commandName, System.Management.Automation.CommandOrigin
                commandOrigin, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = LookupCommandInfo(commandName, commandOrigin, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 23264, 23334);
                    return return_v;
                }


                string
                f_1246_23633_23654(System.Management.Automation.AliasInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 23633, 23654);
                    return return_v;
                }


                string
                f_1246_23778_23823()
                {
                    var return_v = DiscoveryExceptions.AliasNotResolvedException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 23778, 23823);
                    return return_v;
                }


                string
                f_1246_23854_23892(System.Management.Automation.AliasInfo
                this_param)
                {
                    var return_v = this_param.UnresolvedCommandName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 23854, 23892);
                    return return_v;
                }


                System.Management.Automation.CommandNotFoundException
                f_1246_23574_23893(string
                commandName, System.Exception
                innerException, string
                errorIdAndResourceId, string
                resourceStr, params object[]
                messageArgs)
                {
                    var return_v = new System.Management.Automation.CommandNotFoundException(commandName, innerException, errorIdAndResourceId, resourceStr, messageArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 23574, 23893);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1246_23984_23991()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 23984, 23991);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1246_23993_24000()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 23993, 24000);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1246_23993_24020(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineHostInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 23993, 24020);
                    return return_v;
                }


                int
                f_1246_23974_24049(System.Management.Automation.ExecutionContext
                context, System.Management.Automation.Internal.Host.InternalHost
                host, System.Management.Automation.CommandInfo
                commandInfo, System.Management.Automation.CommandOrigin
                commandOrigin)
                {
                    ShouldRun(context, (System.Management.Automation.Host.PSHost)host, commandInfo, commandOrigin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 23974, 24049);
                    return 0;
                }


                System.Management.Automation.CommandTypes
                f_1246_24074_24097(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.CommandType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 24074, 24097);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1246_24252_24259()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 24252, 24259);
                    return return_v;
                }


                System.Management.Automation.NativeCommandProcessor
                f_1246_24195_24260(System.Management.Automation.CommandInfo
                applicationInfo, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new System.Management.Automation.NativeCommandProcessor((System.Management.Automation.ApplicationInfo)applicationInfo, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 24195, 24260);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1246_24412_24419()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 24412, 24419);
                    return return_v;
                }


                System.Management.Automation.CommandProcessor
                f_1246_24366_24420(System.Management.Automation.CommandInfo
                cmdletInfo, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new System.Management.Automation.CommandProcessor((System.Management.Automation.CmdletInfo)cmdletInfo, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 24366, 24420);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1246_24777_24784()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 24777, 24784);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1246_24729_24822(System.Management.Automation.CommandDiscovery
                this_param, System.Management.Automation.ExternalScriptInfo
                scriptInfo, System.Management.Automation.ExecutionContext
                context, bool
                useLocalScope, System.Management.Automation.SessionStateInternal
                sessionState)
                {
                    var return_v = this_param.CreateScriptProcessorForSingleShell(scriptInfo, context, useLocalScope, sessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 24729, 24822);
                    return return_v;
                }


                string
                f_1246_25060_25086(System.Management.Automation.ScriptRequiresSyntaxException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 25060, 25086);
                    return return_v;
                }


                System.Management.Automation.CommandNotFoundException
                f_1246_25031_25107(string
                message, System.Management.Automation.ScriptRequiresSyntaxException
                innerException)
                {
                    var return_v = new System.Management.Automation.CommandNotFoundException(message, (System.Exception)innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 25031, 25107);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1246_25489_25496()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 25489, 25496);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1246_25443_25534(System.Management.Automation.FunctionInfo
                functionInfo, System.Management.Automation.ExecutionContext
                context, bool
                useNewScope, System.Management.Automation.SessionStateInternal
                sessionState)
                {
                    var return_v = CreateCommandProcessorForScript(functionInfo, context, useNewScope, sessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 25443, 25534);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1246_25697_25704()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 25697, 25704);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1246_25640_25742(System.Management.Automation.CommandInfo
                scriptInfo, System.Management.Automation.ExecutionContext
                context, bool
                useNewScope, System.Management.Automation.SessionStateInternal
                sessionState)
                {
                    var return_v = CreateCommandProcessorForScript((System.Management.Automation.ScriptInfo)scriptInfo, context, useNewScope, sessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 25640, 25742);
                    return return_v;
                }


                string
                f_1246_26009_26025(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 26009, 26025);
                    return return_v;
                }


                string
                f_1246_26160_26204()
                {
                    var return_v = DiscoveryExceptions.CommandNotFoundException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 26160, 26204);
                    return return_v;
                }


                System.Management.Automation.CommandNotFoundException
                f_1246_25946_26205(string
                commandName, System.Exception
                innerException, string
                errorIdAndResourceId, string
                resourceStr, params object[]
                messageArgs)
                {
                    var return_v = new System.Management.Automation.CommandNotFoundException(commandName, innerException, errorIdAndResourceId, resourceStr, messageArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 25946, 26205);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1246_26388_26405(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 26388, 26405);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1246_26460_26477(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 26460, 26477);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1246_26460_26490(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 26460, 26490);
                    return return_v;
                }


                string
                f_1246_26508_26524(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 26508, 26524);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 22416, 26569);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 22416, 26569);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void ShouldRun(ExecutionContext context, PSHost host, CommandInfo commandInfo, CommandOrigin commandOrigin)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1246, 26581, 27777);
                // ShouldRunInternal throws PSSecurityException if run is not allowed
                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 26848, 27228) || true) && (commandOrigin == CommandOrigin.Runspace && (DynAbs.Tracing.TraceSender.Expression_True(1246, 26852, 26955) && f_1246_26895_26917(commandInfo) != SessionStateEntryVisibility.Public))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 26848, 27228);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 26997, 27179);

                        CommandNotFoundException
                        e = f_1246_27026_27178(f_1246_27081_27097(commandInfo), null, "CommandNotFoundException", f_1246_27133_27177())
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 27201, 27209);

                        throw e;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 26848, 27228);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 27248, 27329);

                    f_1246_27248_27328(f_1246_27248_27276(context), commandInfo, commandOrigin, host);
                }
                catch (PSSecurityException reason)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1246, 27358, 27766);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 27425, 27555);

                    f_1246_27425_27554(context, reason, Severity.Warning);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 27575, 27725);

                    f_1246_27575_27724(context, CommandState.Terminated, f_1246_27707_27723(commandInfo));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 27745, 27751);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1246, 27358, 27766);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1246, 26581, 27777);

                System.Management.Automation.SessionStateEntryVisibility
                f_1246_26895_26917(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Visibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 26895, 26917);
                    return return_v;
                }


                string
                f_1246_27081_27097(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 27081, 27097);
                    return return_v;
                }


                string
                f_1246_27133_27177()
                {
                    var return_v = DiscoveryExceptions.CommandNotFoundException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 27133, 27177);
                    return return_v;
                }


                System.Management.Automation.CommandNotFoundException
                f_1246_27026_27178(string
                commandName, System.Exception
                innerException, string
                errorIdAndResourceId, string
                resourceStr, params object[]
                messageArgs)
                {
                    var return_v = new System.Management.Automation.CommandNotFoundException(commandName, innerException, errorIdAndResourceId, resourceStr, messageArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 27026, 27178);
                    return return_v;
                }


                System.Management.Automation.AuthorizationManager
                f_1246_27248_27276(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.AuthorizationManager;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 27248, 27276);
                    return return_v;
                }


                int
                f_1246_27248_27328(System.Management.Automation.AuthorizationManager
                this_param, System.Management.Automation.CommandInfo
                commandInfo, System.Management.Automation.CommandOrigin
                origin, System.Management.Automation.Host.PSHost
                host)
                {
                    this_param.ShouldRunInternal(commandInfo, origin, host);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 27248, 27328);
                    return 0;
                }


                int
                f_1246_27425_27554(System.Management.Automation.ExecutionContext
                executionContext, System.Management.Automation.PSSecurityException
                exception, System.Management.Automation.Severity
                severity)
                {
                    MshLog.LogCommandHealthEvent(executionContext, (System.Exception)exception, severity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 27425, 27554);
                    return 0;
                }


                string
                f_1246_27707_27723(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 27707, 27723);
                    return return_v;
                }


                int
                f_1246_27575_27724(System.Management.Automation.ExecutionContext
                executionContext, System.Management.Automation.CommandState
                commandState, string
                commandName)
                {
                    MshLog.LogCommandLifecycleEvent(executionContext, commandState, commandName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 27575, 27724);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 26581, 27777);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 26581, 27777);
            }
        }

        private static CommandProcessorBase CreateCommandProcessorForScript(ScriptInfo scriptInfo, ExecutionContext context, bool useNewScope, SessionStateInternal sessionState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1246, 27789, 28471);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 27983, 28088);

                sessionState = sessionState ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.SessionStateInternal>(1246, 27998, 28087) ?? f_1246_28014_28057(f_1246_28014_28036(scriptInfo)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.SessionStateInternal>(1246, 28014, 28087) ?? f_1246_28061_28087(context)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 28102, 28230);

                CommandProcessorBase
                scriptAsCmdletProcessor = f_1246_28149_28229(scriptInfo, context, useNewScope, true, sessionState)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 28244, 28359) || true) && (scriptAsCmdletProcessor != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 28244, 28359);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 28313, 28344);

                    return scriptAsCmdletProcessor;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 28244, 28359);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 28375, 28460);

                return f_1246_28382_28459(scriptInfo, context, useNewScope, sessionState);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1246, 27789, 28471);

                System.Management.Automation.ScriptBlock
                f_1246_28014_28036(System.Management.Automation.ScriptInfo
                this_param)
                {
                    var return_v = this_param.ScriptBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 28014, 28036);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1246_28014_28057(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.SessionStateInternal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 28014, 28057);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1246_28061_28087(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 28061, 28087);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1246_28149_28229(System.Management.Automation.ScriptInfo
                scriptCommandInfo, System.Management.Automation.ExecutionContext
                context, bool
                useNewScope, bool
                fromScriptFile, System.Management.Automation.SessionStateInternal
                sessionState)
                {
                    var return_v = GetScriptAsCmdletProcessor((System.Management.Automation.IScriptCommandInfo)scriptCommandInfo, context, useNewScope, fromScriptFile, sessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 28149, 28229);
                    return return_v;
                }


                System.Management.Automation.DlrScriptCommandProcessor
                f_1246_28382_28459(System.Management.Automation.ScriptInfo
                scriptInfo, System.Management.Automation.ExecutionContext
                context, bool
                useNewScope, System.Management.Automation.SessionStateInternal
                sessionState)
                {
                    var return_v = new System.Management.Automation.DlrScriptCommandProcessor(scriptInfo, context, useNewScope, sessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 28382, 28459);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 27789, 28471);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 27789, 28471);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static CommandProcessorBase CreateCommandProcessorForScript(ExternalScriptInfo scriptInfo, ExecutionContext context, bool useNewScope, SessionStateInternal sessionState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1246, 28483, 29173);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 28685, 28790);

                sessionState = sessionState ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.SessionStateInternal>(1246, 28700, 28789) ?? f_1246_28716_28759(f_1246_28716_28738(scriptInfo)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.SessionStateInternal>(1246, 28716, 28789) ?? f_1246_28763_28789(context)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 28804, 28932);

                CommandProcessorBase
                scriptAsCmdletProcessor = f_1246_28851_28931(scriptInfo, context, useNewScope, true, sessionState)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 28946, 29061) || true) && (scriptAsCmdletProcessor != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 28946, 29061);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 29015, 29046);

                    return scriptAsCmdletProcessor;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 28946, 29061);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 29077, 29162);

                return f_1246_29084_29161(scriptInfo, context, useNewScope, sessionState);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1246, 28483, 29173);

                System.Management.Automation.ScriptBlock
                f_1246_28716_28738(System.Management.Automation.ExternalScriptInfo
                this_param)
                {
                    var return_v = this_param.ScriptBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 28716, 28738);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1246_28716_28759(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.SessionStateInternal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 28716, 28759);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1246_28763_28789(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 28763, 28789);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1246_28851_28931(System.Management.Automation.ExternalScriptInfo
                scriptCommandInfo, System.Management.Automation.ExecutionContext
                context, bool
                useNewScope, bool
                fromScriptFile, System.Management.Automation.SessionStateInternal
                sessionState)
                {
                    var return_v = GetScriptAsCmdletProcessor((System.Management.Automation.IScriptCommandInfo)scriptCommandInfo, context, useNewScope, fromScriptFile, sessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 28851, 28931);
                    return return_v;
                }


                System.Management.Automation.DlrScriptCommandProcessor
                f_1246_29084_29161(System.Management.Automation.ExternalScriptInfo
                scriptInfo, System.Management.Automation.ExecutionContext
                context, bool
                useNewScope, System.Management.Automation.SessionStateInternal
                sessionState)
                {
                    var return_v = new System.Management.Automation.DlrScriptCommandProcessor(scriptInfo, context, useNewScope, sessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 29084, 29161);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 28483, 29173);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 28483, 29173);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static CommandProcessorBase CreateCommandProcessorForScript(FunctionInfo functionInfo, ExecutionContext context, bool useNewScope, SessionStateInternal sessionState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1246, 29185, 29879);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 29384, 29491);

                sessionState = sessionState ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.SessionStateInternal>(1246, 29399, 29490) ?? f_1246_29415_29460(f_1246_29415_29439(functionInfo)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.SessionStateInternal>(1246, 29415, 29490) ?? f_1246_29464_29490(context)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 29505, 29636);

                CommandProcessorBase
                scriptAsCmdletProcessor = f_1246_29552_29635(functionInfo, context, useNewScope, false, sessionState)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 29650, 29765) || true) && (scriptAsCmdletProcessor != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 29650, 29765);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 29719, 29750);

                    return scriptAsCmdletProcessor;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 29650, 29765);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 29781, 29868);

                return f_1246_29788_29867(functionInfo, context, useNewScope, sessionState);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1246, 29185, 29879);

                System.Management.Automation.ScriptBlock
                f_1246_29415_29439(System.Management.Automation.FunctionInfo
                this_param)
                {
                    var return_v = this_param.ScriptBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 29415, 29439);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1246_29415_29460(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.SessionStateInternal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 29415, 29460);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1246_29464_29490(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 29464, 29490);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1246_29552_29635(System.Management.Automation.FunctionInfo
                scriptCommandInfo, System.Management.Automation.ExecutionContext
                context, bool
                useNewScope, bool
                fromScriptFile, System.Management.Automation.SessionStateInternal
                sessionState)
                {
                    var return_v = GetScriptAsCmdletProcessor((System.Management.Automation.IScriptCommandInfo)scriptCommandInfo, context, useNewScope, fromScriptFile, sessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 29552, 29635);
                    return return_v;
                }


                System.Management.Automation.DlrScriptCommandProcessor
                f_1246_29788_29867(System.Management.Automation.FunctionInfo
                functionInfo, System.Management.Automation.ExecutionContext
                context, bool
                useNewScope, System.Management.Automation.SessionStateInternal
                sessionState)
                {
                    var return_v = new System.Management.Automation.DlrScriptCommandProcessor(functionInfo, context, useNewScope, sessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 29788, 29867);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 29185, 29879);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 29185, 29879);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static CommandProcessorBase CreateCommandProcessorForScript(ScriptBlock scriptblock, ExecutionContext context, bool useNewScope, SessionStateInternal sessionState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1246, 29891, 30587);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 30088, 30182);

                sessionState = sessionState ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.SessionStateInternal>(1246, 30103, 30181) ?? f_1246_30119_30151(scriptblock) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.SessionStateInternal>(1246, 30119, 30181) ?? f_1246_30155_30181(context)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 30198, 30450) || true) && (f_1246_30202_30231(scriptblock))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 30198, 30450);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 30265, 30336);

                    FunctionInfo
                    fi = f_1246_30283_30335(string.Empty, scriptblock, context)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 30354, 30435);

                    return f_1246_30361_30434(fi, context, useNewScope, false, sessionState);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 30198, 30450);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 30466, 30576);

                return f_1246_30473_30575(scriptblock, context, useNewScope, CommandOrigin.Internal, sessionState);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1246, 29891, 30587);

                System.Management.Automation.SessionStateInternal
                f_1246_30119_30151(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.SessionStateInternal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 30119, 30151);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1246_30155_30181(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 30155, 30181);
                    return return_v;
                }


                bool
                f_1246_30202_30231(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.UsesCmdletBinding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 30202, 30231);
                    return return_v;
                }


                System.Management.Automation.FunctionInfo
                f_1246_30283_30335(string
                name, System.Management.Automation.ScriptBlock
                function, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new System.Management.Automation.FunctionInfo(name, function, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 30283, 30335);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1246_30361_30434(System.Management.Automation.FunctionInfo
                scriptCommandInfo, System.Management.Automation.ExecutionContext
                context, bool
                useNewScope, bool
                fromScriptFile, System.Management.Automation.SessionStateInternal
                sessionState)
                {
                    var return_v = GetScriptAsCmdletProcessor((System.Management.Automation.IScriptCommandInfo)scriptCommandInfo, context, useNewScope, fromScriptFile, sessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 30361, 30434);
                    return return_v;
                }


                System.Management.Automation.DlrScriptCommandProcessor
                f_1246_30473_30575(System.Management.Automation.ScriptBlock
                scriptBlock, System.Management.Automation.ExecutionContext
                context, bool
                useNewScope, System.Management.Automation.CommandOrigin
                origin, System.Management.Automation.SessionStateInternal
                sessionState)
                {
                    var return_v = new System.Management.Automation.DlrScriptCommandProcessor(scriptBlock, context, useNewScope, origin, sessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 30473, 30575);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 29891, 30587);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 29891, 30587);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static CommandProcessorBase GetScriptAsCmdletProcessor(IScriptCommandInfo scriptCommandInfo, ExecutionContext context, bool useNewScope, bool fromScriptFile, SessionStateInternal sessionState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1246, 30599, 31232);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 30824, 30978) || true) && (f_1246_30828_30857(scriptCommandInfo) == null || (DynAbs.Tracing.TraceSender.Expression_False(1246, 30828, 30917) || f_1246_30869_30917_M(!f_1246_30870_30899(scriptCommandInfo).UsesCmdletBinding)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 30824, 30978);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 30951, 30963);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 30824, 30978);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 30994, 31106);

                sessionState = sessionState ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.SessionStateInternal>(1246, 31009, 31105) ?? f_1246_31025_31075(f_1246_31025_31054(scriptCommandInfo)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.SessionStateInternal>(1246, 31025, 31105) ?? f_1246_31079_31105(context)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 31122, 31221);

                return f_1246_31129_31220(scriptCommandInfo, context, useNewScope, fromScriptFile, sessionState);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1246, 30599, 31232);

                System.Management.Automation.ScriptBlock
                f_1246_30828_30857(System.Management.Automation.IScriptCommandInfo
                this_param)
                {
                    var return_v = this_param.ScriptBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 30828, 30857);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1246_30870_30899(System.Management.Automation.IScriptCommandInfo
                this_param)
                {
                    var return_v = this_param.ScriptBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 30870, 30899);
                    return return_v;
                }


                bool
                f_1246_30869_30917_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 30869, 30917);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1246_31025_31054(System.Management.Automation.IScriptCommandInfo
                this_param)
                {
                    var return_v = this_param.ScriptBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 31025, 31054);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1246_31025_31075(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.SessionStateInternal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 31025, 31075);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1246_31079_31105(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 31079, 31105);
                    return return_v;
                }


                System.Management.Automation.CommandProcessor
                f_1246_31129_31220(System.Management.Automation.IScriptCommandInfo
                scriptCommandInfo, System.Management.Automation.ExecutionContext
                context, bool
                useLocalScope, bool
                fromScriptFile, System.Management.Automation.SessionStateInternal
                sessionState)
                {
                    var return_v = new System.Management.Automation.CommandProcessor(scriptCommandInfo, context, useLocalScope, fromScriptFile, sessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 31129, 31220);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 30599, 31232);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 30599, 31232);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal CommandInfo LookupCommandInfo(string commandName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1246, 31873, 32029);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 31956, 32018);

                return f_1246_31963_32017(this, commandName, CommandOrigin.Internal);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1246, 31873, 32029);

                System.Management.Automation.CommandInfo
                f_1246_31963_32017(System.Management.Automation.CommandDiscovery
                this_param, string
                commandName, System.Management.Automation.CommandOrigin
                commandOrigin)
                {
                    var return_v = this_param.LookupCommandInfo(commandName, commandOrigin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 31963, 32017);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 31873, 32029);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 31873, 32029);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal CommandInfo LookupCommandInfo(string commandName, CommandOrigin commandOrigin)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1246, 32041, 32226);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 32153, 32215);

                return f_1246_32160_32214(commandName, commandOrigin, f_1246_32206_32213());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1246, 32041, 32226);

                System.Management.Automation.ExecutionContext
                f_1246_32206_32213()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 32206, 32213);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1246_32160_32214(string
                commandName, System.Management.Automation.CommandOrigin
                commandOrigin, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = LookupCommandInfo(commandName, commandOrigin, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 32160, 32214);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 32041, 32226);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 32041, 32226);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static CommandInfo LookupCommandInfo(string commandName, CommandOrigin commandOrigin, ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1246, 32238, 32530);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 32383, 32519);

                return f_1246_32390_32518(commandName, CommandTypes.All, SearchResolutionOptions.ResolveLiteralThenPathPatterns, commandOrigin, context);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1246, 32238, 32530);

                System.Management.Automation.CommandInfo
                f_1246_32390_32518(string
                commandName, System.Management.Automation.CommandTypes
                commandTypes, System.Management.Automation.SearchResolutionOptions
                searchResolutionOptions, System.Management.Automation.CommandOrigin
                commandOrigin, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = LookupCommandInfo(commandName, commandTypes, searchResolutionOptions, commandOrigin, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 32390, 32518);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 32238, 32530);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 32238, 32530);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static CommandInfo LookupCommandInfo(
                    string commandName,
                    CommandTypes commandTypes,
                    SearchResolutionOptions searchResolutionOptions,
                    CommandOrigin commandOrigin,
                    ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1246, 32542, 39031);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 32829, 32927) || true) && (f_1246_32833_32866(commandName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 32829, 32927);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 32900, 32912);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 32829, 32927);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 32943, 33005);

                bool
                etwEnabled = f_1246_32961_33004(CommandDiscoveryEventSource.Log)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 33019, 33099) || true) && (etwEnabled)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 33019, 33099);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 33035, 33099);

                    f_1246_33035_33098(CommandDiscoveryEventSource.Log, commandName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 33019, 33099);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 33115, 33141);

                CommandInfo
                result = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 33155, 33196);

                string
                originalCommandName = commandName
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 33212, 33239);

                Exception
                lastError = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 33334, 33374);

                CommandLookupEventArgs
                eventArgs = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 33388, 33511);

                EventHandler<CommandLookupEventArgs>
                preCommandLookupEvent = f_1246_33449_33510(f_1246_33449_33487(f_1246_33449_33473(context)))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 33527, 34359) || true) && (preCommandLookupEvent != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 33527, 34359);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 33594, 33674);

                    f_1246_33594_33673(discoveryTracer, "Executing PreCommandLookupAction: {0}", commandName);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 33736, 33833);

                        f_1246_33736_33832(f_1246_33736_33760(context), "ActivePreLookup", originalCommandName);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 33855, 33939);

                        eventArgs = f_1246_33867_33938(originalCommandName, commandOrigin, context);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 33961, 34022);

                        f_1246_33961_34021(preCommandLookupEvent, originalCommandName, eventArgs);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 34046, 34131);

                        f_1246_34046_34130(
                                            discoveryTracer, "PreCommandLookupAction returned: {0}", f_1246_34112_34129(eventArgs));
                    }
                    catch (Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1246, 34168, 34223);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1246, 34168, 34223);
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1246, 34241, 34344);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 34251, 34342);

                        f_1246_34251_34341(f_1246_34251_34275(context), "ActivePreLookup", commandName);
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1246, 34241, 34344);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 33527, 34359);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 34432, 34619);

                PSModuleAutoLoadingPreference
                moduleAutoLoadingPreference = f_1246_34492_34618(context, SpecialVariables.PSModuleAutoLoadingPreferenceVarPath, "PSModuleAutoLoadingPreference")
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 34635, 36734) || true) && (eventArgs == null || (DynAbs.Tracing.TraceSender.Expression_False(1246, 34639, 34688) || f_1246_34660_34680(eventArgs) != true))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 34635, 36734);
                    {
                        try
                        {
                            do

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 34722, 36536);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 34765, 34831);

                                f_1246_34765_34830(discoveryTracer, "Looking up command: {0}", commandName);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 35021, 35137);

                                result = f_1246_35030_35136(commandName, context, commandOrigin, searchResolutionOptions, commandTypes, ref lastError);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 35161, 35212) || true) && (result != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 35161, 35212);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1246, 35206, 35212);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 35161, 35212);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 35354, 35599) || true) && (moduleAutoLoadingPreference != PSModuleAutoLoadingPreference.None)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 35354, 35599);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 35473, 35576);

                                    result = f_1246_35482_35575(commandName, context, originalCommandName, commandOrigin, ref lastError);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 35354, 35599);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 35623, 35674) || true) && (result != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 35623, 35674);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1246, 35668, 35674);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 35623, 35674);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 35879, 36221) || true) && (moduleAutoLoadingPreference == PSModuleAutoLoadingPreference.All)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 35879, 36221);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 35997, 36198);

                                    result = f_1246_36006_36197(commandName, context, originalCommandName, commandOrigin, searchResolutionOptions, commandTypes, ref lastError);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 35879, 36221);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 36315, 36502) || true) && (result == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 36315, 36502);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 36383, 36479);

                                    result = f_1246_36392_36478(commandName, context, originalCommandName, commandOrigin);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 36315, 36502);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 34722, 36536);
                            }
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 34722, 36536) || true) && (false)
                            );
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1246, 34722, 36536);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1246, 34722, 36536);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 34635, 36734);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 34635, 36734);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 36602, 36719) || true) && (f_1246_36606_36623(eventArgs) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 36602, 36719);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 36673, 36700);

                        result = f_1246_36682_36699(eventArgs);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 36602, 36719);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 34635, 36734);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 36841, 38218) || true) && (result != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 36841, 38218);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 36893, 37013);

                    System.EventHandler<CommandLookupEventArgs>
                    postAction = f_1246_36950_37012(f_1246_36950_36988(f_1246_36950_36974(context)))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 37031, 38203) || true) && (postAction != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 37031, 38203);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 37095, 37184);

                        f_1246_37095_37183(discoveryTracer, "Executing PostCommandLookupAction: {0}", originalCommandName);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 37258, 37357);

                            f_1246_37258_37356(f_1246_37258_37282(context), "ActivePostCommand", originalCommandName);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 37385, 37469);

                            eventArgs = f_1246_37397_37468(originalCommandName, commandOrigin, context);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 37495, 37522);

                            eventArgs.Command = result;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 37548, 37598);

                            f_1246_37548_37597(postAction, originalCommandName, eventArgs);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 37626, 37874) || true) && (eventArgs != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 37626, 37874);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 37705, 37732);

                                result = f_1246_37714_37731(eventArgs);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 37762, 37847);

                                f_1246_37762_37846(discoveryTracer, "PreCommandLookupAction returned: {0}", f_1246_37828_37845(eventArgs));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 37626, 37874);
                            }
                        }
                        catch (Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1246, 37919, 37982);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1246, 37919, 37982);
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinally(1246, 38004, 38184);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 38060, 38161);

                            f_1246_38060_38160(f_1246_38060_38084(context), "ActivePostCommand", originalCommandName);
                            DynAbs.Tracing.TraceSender.TraceExitFinally(1246, 38004, 38184);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 37031, 38203);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 36841, 38218);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 38330, 38895) || true) && (result == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 38330, 38895);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 38382, 38548);

                    f_1246_38382_38547(discoveryTracer, "'{0}' is not recognized as a cmdlet, function, operable program or script file.", commandName);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 38568, 38854);

                    CommandNotFoundException
                    e =
                    f_1246_38618_38853(originalCommandName, lastError, "CommandNotFoundException", f_1246_38808_38852())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 38872, 38880);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 38330, 38895);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 38911, 38990) || true) && (etwEnabled)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 38911, 38990);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 38927, 38990);

                    f_1246_38927_38989(CommandDiscoveryEventSource.Log, commandName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 38911, 38990);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 39006, 39020);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1246, 32542, 39031);

                bool
                f_1246_32833_32866(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 32833, 32866);
                    return return_v;
                }


                bool
                f_1246_32961_33004(System.Management.Automation.CommandDiscoveryEventSource
                this_param)
                {
                    var return_v = this_param.IsEnabled();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 32961, 33004);
                    return return_v;
                }


                int
                f_1246_33035_33098(System.Management.Automation.CommandDiscoveryEventSource
                this_param, string
                CommandName)
                {
                    this_param.CommandLookupStart(CommandName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 33035, 33098);
                    return 0;
                }


                System.Management.Automation.EngineIntrinsics
                f_1246_33449_33473(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineIntrinsics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 33449, 33473);
                    return return_v;
                }


                System.Management.Automation.CommandInvocationIntrinsics
                f_1246_33449_33487(System.Management.Automation.EngineIntrinsics
                this_param)
                {
                    var return_v = this_param.InvokeCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 33449, 33487);
                    return return_v;
                }


                System.EventHandler<System.Management.Automation.CommandLookupEventArgs>
                f_1246_33449_33510(System.Management.Automation.CommandInvocationIntrinsics
                this_param)
                {
                    var return_v = this_param.PreCommandLookupAction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 33449, 33510);
                    return return_v;
                }


                int
                f_1246_33594_33673(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 33594, 33673);
                    return 0;
                }


                System.Management.Automation.CommandDiscovery
                f_1246_33736_33760(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CommandDiscovery;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 33736, 33760);
                    return return_v;
                }


                int
                f_1246_33736_33832(System.Management.Automation.CommandDiscovery
                this_param, string
                currentAction, string
                command)
                {
                    this_param.RegisterLookupCommandInfoAction(currentAction, command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 33736, 33832);
                    return 0;
                }


                System.Management.Automation.CommandLookupEventArgs
                f_1246_33867_33938(string
                commandName, System.Management.Automation.CommandOrigin
                commandOrigin, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new System.Management.Automation.CommandLookupEventArgs(commandName, commandOrigin, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 33867, 33938);
                    return return_v;
                }


                int
                f_1246_33961_34021(System.EventHandler<System.Management.Automation.CommandLookupEventArgs>
                this_param, string
                sender, System.Management.Automation.CommandLookupEventArgs
                e)
                {
                    this_param.Invoke((object)sender, e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 33961, 34021);
                    return 0;
                }


                System.Management.Automation.CommandInfo
                f_1246_34112_34129(System.Management.Automation.CommandLookupEventArgs
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 34112, 34129);
                    return return_v;
                }


                int
                f_1246_34046_34130(System.Management.Automation.PSTraceSource
                this_param, string
                format, System.Management.Automation.CommandInfo
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 34046, 34130);
                    return 0;
                }


                System.Management.Automation.CommandDiscovery
                f_1246_34251_34275(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CommandDiscovery;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 34251, 34275);
                    return return_v;
                }


                int
                f_1246_34251_34341(System.Management.Automation.CommandDiscovery
                this_param, string
                currentAction, string
                command)
                {
                    this_param.UnregisterLookupCommandInfoAction(currentAction, command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 34251, 34341);
                    return 0;
                }


                System.Management.Automation.PSModuleAutoLoadingPreference
                f_1246_34492_34618(System.Management.Automation.ExecutionContext
                context, System.Management.Automation.VariablePath
                variablePath, string
                environmentVariable)
                {
                    var return_v = GetCommandDiscoveryPreference(context, variablePath, environmentVariable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 34492, 34618);
                    return return_v;
                }


                bool
                f_1246_34660_34680(System.Management.Automation.CommandLookupEventArgs
                this_param)
                {
                    var return_v = this_param.StopSearch;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 34660, 34680);
                    return return_v;
                }


                int
                f_1246_34765_34830(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 34765, 34830);
                    return 0;
                }


                System.Management.Automation.CommandInfo
                f_1246_35030_35136(string
                commandName, System.Management.Automation.ExecutionContext
                context, System.Management.Automation.CommandOrigin
                commandOrigin, System.Management.Automation.SearchResolutionOptions
                searchResolutionOptions, System.Management.Automation.CommandTypes
                commandTypes, ref System.Exception
                lastError)
                {
                    var return_v = TryNormalSearch(commandName, context, commandOrigin, searchResolutionOptions, commandTypes, ref lastError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 35030, 35136);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1246_35482_35575(string
                commandName, System.Management.Automation.ExecutionContext
                context, string
                originalCommandName, System.Management.Automation.CommandOrigin
                commandOrigin, ref System.Exception
                lastError)
                {
                    var return_v = TryModuleAutoLoading(commandName, context, originalCommandName, commandOrigin, ref lastError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 35482, 35575);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1246_36006_36197(string
                commandName, System.Management.Automation.ExecutionContext
                context, string
                originalCommandName, System.Management.Automation.CommandOrigin
                commandOrigin, System.Management.Automation.SearchResolutionOptions
                searchResolutionOptions, System.Management.Automation.CommandTypes
                commandTypes, ref System.Exception
                lastError)
                {
                    var return_v = TryModuleAutoDiscovery(commandName, context, originalCommandName, commandOrigin, searchResolutionOptions, commandTypes, ref lastError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 36006, 36197);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1246_36392_36478(string
                commandName, System.Management.Automation.ExecutionContext
                context, string
                originalCommandName, System.Management.Automation.CommandOrigin
                commandOrigin)
                {
                    var return_v = InvokeCommandNotFoundHandler(commandName, context, originalCommandName, commandOrigin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 36392, 36478);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1246_36606_36623(System.Management.Automation.CommandLookupEventArgs
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 36606, 36623);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1246_36682_36699(System.Management.Automation.CommandLookupEventArgs
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 36682, 36699);
                    return return_v;
                }


                System.Management.Automation.EngineIntrinsics
                f_1246_36950_36974(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineIntrinsics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 36950, 36974);
                    return return_v;
                }


                System.Management.Automation.CommandInvocationIntrinsics
                f_1246_36950_36988(System.Management.Automation.EngineIntrinsics
                this_param)
                {
                    var return_v = this_param.InvokeCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 36950, 36988);
                    return return_v;
                }


                System.EventHandler<System.Management.Automation.CommandLookupEventArgs>
                f_1246_36950_37012(System.Management.Automation.CommandInvocationIntrinsics
                this_param)
                {
                    var return_v = this_param.PostCommandLookupAction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 36950, 37012);
                    return return_v;
                }


                int
                f_1246_37095_37183(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 37095, 37183);
                    return 0;
                }


                System.Management.Automation.CommandDiscovery
                f_1246_37258_37282(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CommandDiscovery;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 37258, 37282);
                    return return_v;
                }


                int
                f_1246_37258_37356(System.Management.Automation.CommandDiscovery
                this_param, string
                currentAction, string
                command)
                {
                    this_param.RegisterLookupCommandInfoAction(currentAction, command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 37258, 37356);
                    return 0;
                }


                System.Management.Automation.CommandLookupEventArgs
                f_1246_37397_37468(string
                commandName, System.Management.Automation.CommandOrigin
                commandOrigin, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new System.Management.Automation.CommandLookupEventArgs(commandName, commandOrigin, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 37397, 37468);
                    return return_v;
                }


                int
                f_1246_37548_37597(System.EventHandler<System.Management.Automation.CommandLookupEventArgs>
                this_param, string
                sender, System.Management.Automation.CommandLookupEventArgs
                e)
                {
                    this_param.Invoke((object)sender, e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 37548, 37597);
                    return 0;
                }


                System.Management.Automation.CommandInfo
                f_1246_37714_37731(System.Management.Automation.CommandLookupEventArgs
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 37714, 37731);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1246_37828_37845(System.Management.Automation.CommandLookupEventArgs
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 37828, 37845);
                    return return_v;
                }


                int
                f_1246_37762_37846(System.Management.Automation.PSTraceSource
                this_param, string
                format, System.Management.Automation.CommandInfo
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 37762, 37846);
                    return 0;
                }


                System.Management.Automation.CommandDiscovery
                f_1246_38060_38084(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CommandDiscovery;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 38060, 38084);
                    return return_v;
                }


                int
                f_1246_38060_38160(System.Management.Automation.CommandDiscovery
                this_param, string
                currentAction, string
                command)
                {
                    this_param.UnregisterLookupCommandInfoAction(currentAction, command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 38060, 38160);
                    return 0;
                }


                int
                f_1246_38382_38547(System.Management.Automation.PSTraceSource
                this_param, string
                errorMessageFormat, params object[]
                args)
                {
                    this_param.TraceError(errorMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 38382, 38547);
                    return 0;
                }


                string
                f_1246_38808_38852()
                {
                    var return_v = DiscoveryExceptions.CommandNotFoundException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 38808, 38852);
                    return return_v;
                }


                System.Management.Automation.CommandNotFoundException
                f_1246_38618_38853(string
                commandName, System.Exception
                innerException, string
                errorIdAndResourceId, string
                resourceStr, params object[]
                messageArgs)
                {
                    var return_v = new System.Management.Automation.CommandNotFoundException(commandName, innerException, errorIdAndResourceId, resourceStr, messageArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 38618, 38853);
                    return return_v;
                }


                int
                f_1246_38927_38989(System.Management.Automation.CommandDiscoveryEventSource
                this_param, string
                CommandName)
                {
                    this_param.CommandLookupStop(CommandName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 38927, 38989);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 32542, 39031);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 32542, 39031);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void AutoloadModulesWithJobSourceAdapters(System.Management.Automation.ExecutionContext context, CommandOrigin commandOrigin)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1246, 39043, 41297);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1246, 39043, 41297);
                /* This function is used by *-Job cmdlets (JobCmdletBase.BeginProcessing(), StartJobCommand.BeginProcessing())
                It attempts to load modules from a fixed ModulesWithJobSourceAdapters list that currently has only `PSScheduledJob` module that is not PS-Core compatible.
                Because this function does not check the result of a (currently failing) `PSScheduledJob` module autoload, it provides no value.
                After discussion it was decided to comment out this code as it may be useful if ModulesWithJobSourceAdapters list changes in the future.

                if (!context.IsModuleWithJobSourceAdapterLoaded)
                {
                    PSModuleAutoLoadingPreference moduleAutoLoadingPreference = GetCommandDiscoveryPreference(context, SpecialVariables.PSModuleAutoLoadingPreferenceVarPath, "PSModuleAutoLoadingPreference");
                    if (moduleAutoLoadingPreference != PSModuleAutoLoadingPreference.None)
                    {
                        CmdletInfo cmdletInfo = context.SessionState.InvokeCommand.GetCmdlet("Microsoft.PowerShell.Core\\Import-Module");
                        if ((commandOrigin == CommandOrigin.Internal) ||
                            ((cmdletInfo != null) && (cmdletInfo.Visibility == SessionStateEntryVisibility.Public)))
                        {
                            foreach (var module in System.Management.Automation.ExecutionContext.ModulesWithJobSourceAdapters)
                            {
                                List<PSModuleInfo> existingModule = context.Modules.GetModules(new string[] { module }, false);
                                if (existingModule == null || existingModule.Count == 0)
                                {
                                    Exception unUsedException = null;
                                    AutoloadSpecifiedModule(module, context, cmdletInfo.Visibility, out unUsedException);
                                }
                            }

                            context.IsModuleWithJobSourceAdapterLoaded = true;
                        }
                    }
                }*/
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 39043, 41297);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 39043, 41297);
            }
        }

        internal static Collection<PSModuleInfo> AutoloadSpecifiedModule(string moduleName, ExecutionContext context, SessionStateEntryVisibility visibility, out Exception exception)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1246, 41309, 43025);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 41508, 41525);

                exception = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 41539, 41587);

                Collection<PSModuleInfo>
                matchingModules = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 41601, 41709);

                CommandInfo
                commandInfo = f_1246_41627_41708("Import-Module", typeof(ImportModuleCommand), null, null, context)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 41723, 41759);

                commandInfo.Visibility = visibility;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 41773, 41828);

                Command
                importModuleCommand = f_1246_41803_41827(commandInfo)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 41844, 41916);

                f_1246_41844_41915(
                            discoveryTracer, "Attempting to load module: {0}", moduleName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 41932, 41953);

                PowerShell
                ps = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 42003, 42623);

                    ps = f_1246_42008_42622(f_1246_42008_42570(f_1246_42008_42516(f_1246_42008_42434(f_1246_42008_42356(f_1246_42008_42280(f_1246_42008_42232(f_1246_42008_42164(f_1246_42008_42109(f_1246_42008_42055(RunspaceMode.CurrentRunspace), importModuleCommand), "Name", moduleName), "Scope", StringLiterals.Global), "PassThru"), "ErrorAction", ActionPreference.Ignore), "WarningAction", ActionPreference.Ignore), "InformationAction", ActionPreference.Ignore), "Verbose", false), "Debug", false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 42641, 42711);

                    matchingModules = (Collection<PSModuleInfo>)f_1246_42685_42710(ps);
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1246, 42740, 42975);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 42792, 42806);

                    exception = e;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 42824, 42904);

                    f_1246_42824_42903(discoveryTracer, "Encountered error importing module: {0}", f_1246_42893_42902(e));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1246, 42740, 42975);
                    // Call-out to user code, catch-all OK
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 42991, 43014);

                return matchingModules;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1246, 41309, 43025);

                System.Management.Automation.CmdletInfo
                f_1246_41627_41708(string
                name, System.Type
                implementingType, string
                helpFile, System.Management.Automation.PSSnapInInfo
                PSSnapin, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new System.Management.Automation.CmdletInfo(name, implementingType, helpFile, PSSnapin, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 41627, 41708);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Command
                f_1246_41803_41827(System.Management.Automation.CommandInfo
                commandInfo)
                {
                    var return_v = new System.Management.Automation.Runspaces.Command(commandInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 41803, 41827);
                    return return_v;
                }


                int
                f_1246_41844_41915(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 41844, 41915);
                    return 0;
                }


                System.Management.Automation.PowerShell
                f_1246_42008_42055(System.Management.Automation.RunspaceMode
                runspace)
                {
                    var return_v = PowerShell.Create(runspace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 42008, 42055);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1246_42008_42109(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.Runspaces.Command
                command)
                {
                    var return_v = this_param.AddCommand(command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 42008, 42109);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1246_42008_42164(System.Management.Automation.PowerShell
                this_param, string
                parameterName, string
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 42008, 42164);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1246_42008_42232(System.Management.Automation.PowerShell
                this_param, string
                parameterName, string
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 42008, 42232);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1246_42008_42280(System.Management.Automation.PowerShell
                this_param, string
                parameterName)
                {
                    var return_v = this_param.AddParameter(parameterName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 42008, 42280);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1246_42008_42356(System.Management.Automation.PowerShell
                this_param, string
                parameterName, System.Management.Automation.ActionPreference
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 42008, 42356);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1246_42008_42434(System.Management.Automation.PowerShell
                this_param, string
                parameterName, System.Management.Automation.ActionPreference
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 42008, 42434);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1246_42008_42516(System.Management.Automation.PowerShell
                this_param, string
                parameterName, System.Management.Automation.ActionPreference
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 42008, 42516);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1246_42008_42570(System.Management.Automation.PowerShell
                this_param, string
                parameterName, bool
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 42008, 42570);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1246_42008_42622(System.Management.Automation.PowerShell
                this_param, string
                parameterName, bool
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 42008, 42622);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSModuleInfo>
                f_1246_42685_42710(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Invoke<System.Management.Automation.PSModuleInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 42685, 42710);
                    return return_v;
                }


                string
                f_1246_42893_42902(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 42893, 42902);
                    return return_v;
                }


                int
                f_1246_42824_42903(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 42824, 42903);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 41309, 43025);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 41309, 43025);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static CommandInfo InvokeCommandNotFoundHandler(string commandName, ExecutionContext context, string originalCommandName, CommandOrigin commandOrigin)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1246, 43037, 44273);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 43220, 43246);

                CommandInfo
                result = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 43260, 43293);

                CommandLookupEventArgs
                eventArgs
                = default(CommandLookupEventArgs);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 43307, 43433);

                System.EventHandler<CommandLookupEventArgs>
                cmdNotFoundHandler = f_1246_43372_43432(f_1246_43372_43410(f_1246_43372_43396(context)))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 43447, 44232) || true) && (cmdNotFoundHandler != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 43447, 44232);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 43511, 43590);

                    f_1246_43511_43589(discoveryTracer, "Executing CommandNotFoundAction: {0}", commandName);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 43652, 43755);

                        f_1246_43652_43754(f_1246_43652_43676(context), "ActiveCommandNotFound", originalCommandName);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 43777, 43861);

                        eventArgs = f_1246_43789_43860(originalCommandName, commandOrigin, context);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 43883, 43941);

                        f_1246_43883_43940(cmdNotFoundHandler, originalCommandName, eventArgs);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 43963, 43990);

                        result = f_1246_43972_43989(eventArgs);
                    }
                    catch (Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1246, 44027, 44082);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1246, 44027, 44082);
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1246, 44100, 44217);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 44110, 44215);

                        f_1246_44110_44214(f_1246_44110_44134(context), "ActiveCommandNotFound", originalCommandName);
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1246, 44100, 44217);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 43447, 44232);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 44248, 44262);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1246, 43037, 44273);

                System.Management.Automation.EngineIntrinsics
                f_1246_43372_43396(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineIntrinsics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 43372, 43396);
                    return return_v;
                }


                System.Management.Automation.CommandInvocationIntrinsics
                f_1246_43372_43410(System.Management.Automation.EngineIntrinsics
                this_param)
                {
                    var return_v = this_param.InvokeCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 43372, 43410);
                    return return_v;
                }


                System.EventHandler<System.Management.Automation.CommandLookupEventArgs>
                f_1246_43372_43432(System.Management.Automation.CommandInvocationIntrinsics
                this_param)
                {
                    var return_v = this_param.CommandNotFoundAction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 43372, 43432);
                    return return_v;
                }


                int
                f_1246_43511_43589(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 43511, 43589);
                    return 0;
                }


                System.Management.Automation.CommandDiscovery
                f_1246_43652_43676(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CommandDiscovery;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 43652, 43676);
                    return return_v;
                }


                int
                f_1246_43652_43754(System.Management.Automation.CommandDiscovery
                this_param, string
                currentAction, string
                command)
                {
                    this_param.RegisterLookupCommandInfoAction(currentAction, command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 43652, 43754);
                    return 0;
                }


                System.Management.Automation.CommandLookupEventArgs
                f_1246_43789_43860(string
                commandName, System.Management.Automation.CommandOrigin
                commandOrigin, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new System.Management.Automation.CommandLookupEventArgs(commandName, commandOrigin, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 43789, 43860);
                    return return_v;
                }


                int
                f_1246_43883_43940(System.EventHandler<System.Management.Automation.CommandLookupEventArgs>
                this_param, string
                sender, System.Management.Automation.CommandLookupEventArgs
                e)
                {
                    this_param.Invoke((object)sender, e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 43883, 43940);
                    return 0;
                }


                System.Management.Automation.CommandInfo
                f_1246_43972_43989(System.Management.Automation.CommandLookupEventArgs
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 43972, 43989);
                    return return_v;
                }


                System.Management.Automation.CommandDiscovery
                f_1246_44110_44134(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CommandDiscovery;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 44110, 44134);
                    return return_v;
                }


                int
                f_1246_44110_44214(System.Management.Automation.CommandDiscovery
                this_param, string
                currentAction, string
                command)
                {
                    this_param.UnregisterLookupCommandInfoAction(currentAction, command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 44110, 44214);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 43037, 44273);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 43037, 44273);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static CommandInfo TryNormalSearch(string commandName,
                                                           ExecutionContext context,
                                                           CommandOrigin commandOrigin,
                                                           SearchResolutionOptions searchResolutionOptions,
                                                           CommandTypes commandTypes,
                                                           ref Exception lastError)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1246, 44285, 46785);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 44788, 44814);

                CommandInfo
                result = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 44830, 45040);

                CommandSearcher
                searcher =
                f_1246_44874_45039(commandName, searchResolutionOptions, commandTypes, context)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 45054, 45093);

                searcher.CommandOrigin = commandOrigin;

                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 45145, 46079) || true) && (!f_1246_45150_45169(searcher))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 45145, 46079);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 45211, 45924) || true) && (!f_1246_45216_45241(commandName, "-") && (DynAbs.Tracing.TraceSender.Expression_True(1246, 45215, 45272) && !f_1246_45246_45272(commandName, "\\")))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 45211, 45924);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 45322, 45489);

                            f_1246_45322_45488(discoveryTracer, "The command [{0}] was not found, trying again with get- prepended", commandName);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 45517, 45621);

                            commandName = StringLiterals.DefaultCommandVerb + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (StringLiterals.CommandVerbNounSeparator).ToString(), 1246, 45567, 45606) + commandName;

                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 45709, 45812);

                                result = f_1246_45718_45811(commandName, commandTypes, searchResolutionOptions, commandOrigin, context);
                            }
                            catch (CommandNotFoundException)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1246, 45865, 45901);
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1246, 45865, 45901);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 45211, 45924);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 45145, 46079);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 45145, 46079);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 46006, 46060);

                        result = f_1246_46015_46059(((IEnumerator<CommandInfo>)searcher));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 45145, 46079);
                    }
                }
                catch (ArgumentException argException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1246, 46108, 46219);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 46179, 46204);

                    lastError = argException;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1246, 46108, 46219);
                }
                catch (PathTooLongException pathTooLong)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1246, 46233, 46345);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 46306, 46330);

                    lastError = pathTooLong;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1246, 46233, 46345);
                }
                catch (FileLoadException fileLoadException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1246, 46359, 46480);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 46435, 46465);

                    lastError = fileLoadException;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1246, 46359, 46480);
                }
                catch (FormatException formatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1246, 46494, 46609);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 46566, 46594);

                    lastError = formatException;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1246, 46494, 46609);
                }
                catch (MetadataException metadataException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1246, 46623, 46744);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 46699, 46729);

                    lastError = metadataException;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1246, 46623, 46744);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 46760, 46774);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1246, 44285, 46785);

                System.Management.Automation.CommandSearcher
                f_1246_44874_45039(string
                commandName, System.Management.Automation.SearchResolutionOptions
                options, System.Management.Automation.CommandTypes
                commandTypes, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new System.Management.Automation.CommandSearcher(commandName, options, commandTypes, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 44874, 45039);
                    return return_v;
                }


                bool
                f_1246_45150_45169(System.Management.Automation.CommandSearcher
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 45150, 45169);
                    return return_v;
                }


                bool
                f_1246_45216_45241(string
                this_param, string
                value)
                {
                    var return_v = this_param.Contains(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 45216, 45241);
                    return return_v;
                }


                bool
                f_1246_45246_45272(string
                this_param, string
                value)
                {
                    var return_v = this_param.Contains(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 45246, 45272);
                    return return_v;
                }


                int
                f_1246_45322_45488(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 45322, 45488);
                    return 0;
                }


                System.Management.Automation.CommandInfo
                f_1246_45718_45811(string
                commandName, System.Management.Automation.CommandTypes
                commandTypes, System.Management.Automation.SearchResolutionOptions
                searchResolutionOptions, System.Management.Automation.CommandOrigin
                commandOrigin, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = LookupCommandInfo(commandName, commandTypes, searchResolutionOptions, commandOrigin, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 45718, 45811);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1246_46015_46059(System.Collections.Generic.IEnumerator<System.Management.Automation.CommandInfo>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 46015, 46059);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 44285, 46785);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 44285, 46785);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static CommandInfo TryModuleAutoDiscovery(string commandName,
                                                                  ExecutionContext context,
                                                                  string originalCommandName,
                                                                  CommandOrigin commandOrigin,
                                                                  SearchResolutionOptions searchResolutionOptions,
                                                                  CommandTypes commandTypes,
                                                                  ref Exception lastError)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1246, 46797, 53689);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 47429, 47491);

                bool
                etwEnabled = f_1246_47447_47490(CommandDiscoveryEventSource.Log)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 47505, 47591) || true) && (etwEnabled)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 47505, 47591);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 47521, 47591);

                    f_1246_47521_47590(CommandDiscoveryEventSource.Log, commandName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 47505, 47591);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 47607, 47633);

                CommandInfo
                result = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 47647, 47691);

                bool
                cleanupModuleAnalysisAppDomain = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 47993, 48074);

                    int
                    colonOrBackslash = f_1246_48016_48073(commandName, Utils.Separators.ColonOrBackslash)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 48092, 48153) || true) && (colonOrBackslash != -1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 48092, 48153);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 48141, 48153);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 48092, 48153);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 48173, 48283);

                    CmdletInfo
                    cmdletInfo = f_1246_48197_48282(f_1246_48197_48231(f_1246_48197_48217(context)), "Microsoft.PowerShell.Core\\Get-Module")
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 48301, 53080) || true) && ((commandOrigin == CommandOrigin.Internal) || (DynAbs.Tracing.TraceSender.Expression_False(1246, 48305, 48458) || ((cmdletInfo != null) && (DynAbs.Tracing.TraceSender.Expression_True(1246, 48372, 48457) && (f_1246_48397_48418(cmdletInfo) == SessionStateEntryVisibility.Public)))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 48301, 53080);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 48658, 48760);

                        cmdletInfo = f_1246_48671_48759(f_1246_48671_48705(f_1246_48671_48691(context)), "Microsoft.PowerShell.Core\\Import-Module");

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 48782, 53061) || true) && (((commandOrigin == CommandOrigin.Internal) || (DynAbs.Tracing.TraceSender.Expression_False(1246, 48787, 48945) || ((cmdletInfo != null) && (DynAbs.Tracing.TraceSender.Expression_True(1246, 48859, 48944) && (f_1246_48884_48905(cmdletInfo) == SessionStateEntryVisibility.Public))))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 48782, 53061);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 48996, 49081);

                            f_1246_48996_49080(discoveryTracer, "Executing non module-qualified search: {0}", commandName);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 49107, 49199);

                            f_1246_49107_49198(f_1246_49107_49131(context), "ActiveModuleSearch", commandName);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 49227, 49315);

                            cleanupModuleAnalysisAppDomain = f_1246_49260_49314(context);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 49534, 49613) || true) && (etwEnabled)
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 49534, 49613);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 49550, 49613);

                                f_1246_49550_49612(CommandDiscoveryEventSource.Log);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 49534, 49613);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 49639, 49751);

                            var
                            defaultAvailableModuleFiles = f_1246_49673_49750(isForAutoDiscovery: true, context)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 49777, 49855) || true) && (etwEnabled)
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 49777, 49855);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 49793, 49855);

                                f_1246_49793_49854(CommandDiscoveryEventSource.Log);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 49777, 49855);
                            }
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 49883, 52466);
                                foreach (string modulePath in f_1246_49913_49940_I(defaultAvailableModuleFiles))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 49883, 52466);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 50243, 50303);

                                    string
                                    expandedModulePath = f_1246_50271_50302(modulePath)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 50333, 50421);

                                    string
                                    moduleShortName = f_1246_50358_50420(expandedModulePath)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 50451, 50544);

                                    var
                                    exportedCommands = f_1246_50474_50543(expandedModulePath, false, context)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 50576, 50619) || true) && (exportedCommands == null)
                                    )
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 50576, 50619);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 50608, 50617);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 50576, 50619);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 50651, 50685);

                                    CommandTypes
                                    exportedCommandTypes
                                    = default(CommandTypes);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 50809, 52286) || true) && (f_1246_50813_50880(exportedCommands, commandName, out exportedCommandTypes))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 50809, 52286);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 50946, 50966);

                                        Exception
                                        exception
                                        = default(Exception);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 51000, 51070);

                                        f_1246_51000_51069(discoveryTracer, "Found in module: {0}", expandedModulePath);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 51104, 51374);

                                        Collection<PSModuleInfo>
                                        matchingModule = f_1246_51146_51373(expandedModulePath, context, (DynAbs.Tracing.TraceSender.Conditional_F1(1246, 51236, 51254) || ((cmdletInfo != null && DynAbs.Tracing.TraceSender.Conditional_F2(1246, 51257, 51278)) || DynAbs.Tracing.TraceSender.Conditional_F3(1246, 51281, 51316))) ? f_1246_51257_51278(cmdletInfo) : SessionStateEntryVisibility.Private, out exception)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 51408, 51430);

                                        lastError = exception;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 51464, 52116) || true) && ((matchingModule == null) || (DynAbs.Tracing.TraceSender.Expression_False(1246, 51468, 51523) || (f_1246_51497_51517(matchingModule) == 0)))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 51464, 52116);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 51597, 51714);

                                            string
                                            error = f_1246_51612_51713(f_1246_51630_51682(), commandName, moduleShortName)
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 51752, 52021);

                                            CommandNotFoundException
                                            commandNotFound = f_1246_51795_52020(originalCommandName, lastError, "CouldNotAutoloadMatchingModule", error)
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 52059, 52081);

                                            throw commandNotFound;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 51464, 52116);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 52152, 52255);

                                        result = f_1246_52161_52254(commandName, commandTypes, searchResolutionOptions, commandOrigin, context);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 50809, 52286);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 52318, 52439) || true) && (result != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 52318, 52439);
                                        DynAbs.Tracing.TraceSender.TraceBreak(1246, 52402, 52408);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 52318, 52439);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 49883, 52466);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1246, 1, 2584);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1246, 1, 2584);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 48782, 53061);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 48301, 53080);
                    }
                }
                catch (CommandNotFoundException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1246, 53109, 53152);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 53144, 53150);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1246, 53109, 53152);
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1246, 53166, 53213);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1246, 53166, 53213);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1246, 53227, 53547);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 53267, 53361);

                    f_1246_53267_53360(f_1246_53267_53291(context), "ActiveModuleSearch", commandName);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 53379, 53532) || true) && (cleanupModuleAnalysisAppDomain)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 53379, 53532);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 53455, 53513);

                        f_1246_53455_53512(context);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 53379, 53532);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1246, 53227, 53547);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 53563, 53648) || true) && (etwEnabled)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 53563, 53648);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 53579, 53648);

                    f_1246_53579_53647(CommandDiscoveryEventSource.Log, commandName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 53563, 53648);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 53664, 53678);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1246, 46797, 53689);

                bool
                f_1246_47447_47490(System.Management.Automation.CommandDiscoveryEventSource
                this_param)
                {
                    var return_v = this_param.IsEnabled();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 47447, 47490);
                    return return_v;
                }


                int
                f_1246_47521_47590(System.Management.Automation.CommandDiscoveryEventSource
                this_param, string
                CommandName)
                {
                    this_param.ModuleAutoDiscoveryStart(CommandName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 47521, 47590);
                    return 0;
                }


                int
                f_1246_48016_48073(string
                this_param, char[]
                anyOf)
                {
                    var return_v = this_param.IndexOfAny(anyOf);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 48016, 48073);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1246_48197_48217(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 48197, 48217);
                    return return_v;
                }


                System.Management.Automation.CommandInvocationIntrinsics
                f_1246_48197_48231(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.InvokeCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 48197, 48231);
                    return return_v;
                }


                System.Management.Automation.CmdletInfo
                f_1246_48197_48282(System.Management.Automation.CommandInvocationIntrinsics
                this_param, string
                commandName)
                {
                    var return_v = this_param.GetCmdlet(commandName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 48197, 48282);
                    return return_v;
                }


                System.Management.Automation.SessionStateEntryVisibility
                f_1246_48397_48418(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.Visibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 48397, 48418);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1246_48671_48691(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 48671, 48691);
                    return return_v;
                }


                System.Management.Automation.CommandInvocationIntrinsics
                f_1246_48671_48705(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.InvokeCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 48671, 48705);
                    return return_v;
                }


                System.Management.Automation.CmdletInfo
                f_1246_48671_48759(System.Management.Automation.CommandInvocationIntrinsics
                this_param, string
                commandName)
                {
                    var return_v = this_param.GetCmdlet(commandName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 48671, 48759);
                    return return_v;
                }


                System.Management.Automation.SessionStateEntryVisibility
                f_1246_48884_48905(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.Visibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 48884, 48905);
                    return return_v;
                }


                int
                f_1246_48996_49080(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 48996, 49080);
                    return 0;
                }


                System.Management.Automation.CommandDiscovery
                f_1246_49107_49131(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CommandDiscovery;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 49107, 49131);
                    return return_v;
                }


                int
                f_1246_49107_49198(System.Management.Automation.CommandDiscovery
                this_param, string
                currentAction, string
                command)
                {
                    this_param.RegisterLookupCommandInfoAction(currentAction, command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 49107, 49198);
                    return 0;
                }


                bool
                f_1246_49260_49314(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.TakeResponsibilityForModuleAnalysisAppDomain();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 49260, 49314);
                    return return_v;
                }


                int
                f_1246_49550_49612(System.Management.Automation.CommandDiscoveryEventSource
                this_param)
                {
                    this_param.SearchingForModuleFilesStart();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 49550, 49612);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1246_49673_49750(bool
                isForAutoDiscovery, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = ModuleUtils.GetDefaultAvailableModuleFiles(isForAutoDiscovery: isForAutoDiscovery, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 49673, 49750);
                    return return_v;
                }


                int
                f_1246_49793_49854(System.Management.Automation.CommandDiscoveryEventSource
                this_param)
                {
                    this_param.SearchingForModuleFilesStop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 49793, 49854);
                    return 0;
                }


                string
                f_1246_50271_50302(string
                path)
                {
                    var return_v = IO.Path.GetFullPath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 50271, 50302);
                    return return_v;
                }


                string?
                f_1246_50358_50420(string
                path)
                {
                    var return_v = System.IO.Path.GetFileNameWithoutExtension(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 50358, 50420);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.CommandTypes>
                f_1246_50474_50543(string
                modulePath, bool
                testOnly, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = AnalysisCache.GetExportedCommands(modulePath, testOnly, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 50474, 50543);
                    return return_v;
                }


                bool
                f_1246_50813_50880(System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.CommandTypes>
                this_param, string
                key, out System.Management.Automation.CommandTypes
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 50813, 50880);
                    return return_v;
                }


                int
                f_1246_51000_51069(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 51000, 51069);
                    return 0;
                }


                System.Management.Automation.SessionStateEntryVisibility
                f_1246_51257_51278(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.Visibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 51257, 51278);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSModuleInfo>
                f_1246_51146_51373(string
                moduleName, System.Management.Automation.ExecutionContext
                context, System.Management.Automation.SessionStateEntryVisibility
                visibility, out System.Exception
                exception)
                {
                    var return_v = AutoloadSpecifiedModule(moduleName, context, visibility, out exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 51146, 51373);
                    return return_v;
                }


                int
                f_1246_51497_51517(System.Collections.ObjectModel.Collection<System.Management.Automation.PSModuleInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 51497, 51517);
                    return return_v;
                }


                string
                f_1246_51630_51682()
                {
                    var return_v = DiscoveryExceptions.CouldNotAutoImportMatchingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 51630, 51682);
                    return return_v;
                }


                string
                f_1246_51612_51713(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 51612, 51713);
                    return return_v;
                }


                System.Management.Automation.CommandNotFoundException
                f_1246_51795_52020(string
                commandName, System.Exception
                innerException, string
                errorIdAndResourceId, string
                resourceStr, params object[]
                messageArgs)
                {
                    var return_v = new System.Management.Automation.CommandNotFoundException(commandName, innerException, errorIdAndResourceId, resourceStr, messageArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 51795, 52020);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1246_52161_52254(string
                commandName, System.Management.Automation.CommandTypes
                commandTypes, System.Management.Automation.SearchResolutionOptions
                searchResolutionOptions, System.Management.Automation.CommandOrigin
                commandOrigin, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = LookupCommandInfo(commandName, commandTypes, searchResolutionOptions, commandOrigin, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 52161, 52254);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1246_49913_49940_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 49913, 49940);
                    return return_v;
                }


                System.Management.Automation.CommandDiscovery
                f_1246_53267_53291(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CommandDiscovery;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 53267, 53291);
                    return return_v;
                }


                int
                f_1246_53267_53360(System.Management.Automation.CommandDiscovery
                this_param, string
                currentAction, string
                command)
                {
                    this_param.UnregisterLookupCommandInfoAction(currentAction, command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 53267, 53360);
                    return 0;
                }


                int
                f_1246_53455_53512(System.Management.Automation.ExecutionContext
                this_param)
                {
                    this_param.ReleaseResponsibilityForModuleAnalysisAppDomain();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 53455, 53512);
                    return 0;
                }


                int
                f_1246_53579_53647(System.Management.Automation.CommandDiscoveryEventSource
                this_param, string
                CommandName)
                {
                    this_param.ModuleAutoDiscoveryStop(CommandName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 53579, 53647);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 46797, 53689);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 46797, 53689);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static CommandInfo TryModuleAutoLoading(string commandName, ExecutionContext context, string originalCommandName, CommandOrigin commandOrigin, ref Exception lastError)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1246, 53701, 58963);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 53901, 53927);

                CommandInfo
                result = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 54037, 54118);

                var
                colonOrBackslash = f_1246_54060_54117(commandName, Utils.Separators.ColonOrBackslash)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 54329, 54426) || true) && (colonOrBackslash == -1 || (DynAbs.Tracing.TraceSender.Expression_False(1246, 54333, 54395) || f_1246_54359_54388(commandName, colonOrBackslash) == ':'))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 54329, 54426);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 54414, 54426);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 54329, 54426);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 54442, 54556);

                string
                moduleCommandName = f_1246_54469_54555(commandName, colonOrBackslash + 1, f_1246_54513_54531(commandName) - colonOrBackslash - 1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 54570, 54588);

                string
                moduleName
                = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 54664, 54743);

                var
                secondBackslash = f_1246_54686_54742(moduleCommandName, Utils.Separators.Backslash)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 54757, 55760) || true) && (secondBackslash == -1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 54757, 55760);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 54816, 54872);

                    moduleName = f_1246_54829_54871(commandName, 0, colonOrBackslash);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 54757, 55760);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 54757, 55760);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 54938, 55009);

                    string
                    versionString = f_1246_54961_55008(moduleCommandName, 0, secondBackslash)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 55184, 55200);

                    Version
                    version
                    = default(Version);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 55218, 55745) || true) && (f_1246_55222_55266(versionString, out version))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 55218, 55745);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 55308, 55425);

                        moduleCommandName = f_1246_55328_55424(moduleCommandName, secondBackslash + 1, f_1246_55377_55401(moduleCommandName) - secondBackslash - 1);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 55447, 55588);

                        moduleName = f_1246_55460_55502(commandName, 0, colonOrBackslash) + "\\" + versionString + "\\" + f_1246_55535_55577(commandName, 0, colonOrBackslash) + ".psd1";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 55218, 55745);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 55218, 55745);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 55670, 55726);

                        moduleName = f_1246_55683_55725(commandName, 0, colonOrBackslash);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 55218, 55745);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 54757, 55760);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 55776, 55914) || true) && (f_1246_55780_55812(moduleName) || (DynAbs.Tracing.TraceSender.Expression_False(1246, 55780, 55855) || f_1246_55816_55855(moduleCommandName)) || (DynAbs.Tracing.TraceSender.Expression_False(1246, 55780, 55883) || f_1246_55859_55883(moduleName, '.')))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 55776, 55914);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 55902, 55914);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 55776, 55914);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 55930, 55992);

                bool
                etwEnabled = f_1246_55948_55991(CommandDiscoveryEventSource.Log)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 56006, 56090) || true) && (etwEnabled)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 56006, 56090);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 56022, 56090);

                    f_1246_56022_56089(CommandDiscoveryEventSource.Log, commandName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 56006, 56090);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 56142, 56223);

                    f_1246_56142_56222(discoveryTracer, "Executing module-qualified search: {0}", commandName);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 56241, 56333);

                    f_1246_56241_56332(f_1246_56241_56265(context), "ActiveModuleSearch", commandName);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 56455, 56568);

                    CmdletInfo
                    cmdletInfo = f_1246_56479_56567(f_1246_56479_56513(f_1246_56479_56499(context)), "Microsoft.PowerShell.Core\\Import-Module")
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 56586, 58572) || true) && ((commandOrigin == CommandOrigin.Internal) || (DynAbs.Tracing.TraceSender.Expression_False(1246, 56590, 56743) || ((cmdletInfo != null) && (DynAbs.Tracing.TraceSender.Expression_True(1246, 56657, 56742) && (f_1246_56682_56703(cmdletInfo) == SessionStateEntryVisibility.Public)))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 56586, 58572);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 56785, 56884);

                        List<PSModuleInfo>
                        existingModule = f_1246_56821_56883(f_1246_56821_56836(context), new string[] { moduleName }, false)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 56906, 56943);

                        PSModuleInfo
                        discoveredModule = null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 56967, 58227) || true) && (existingModule == null || (DynAbs.Tracing.TraceSender.Expression_False(1246, 56971, 57022) || f_1246_56997_57017(existingModule) == 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 56967, 58227);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 57072, 57144);

                            f_1246_57072_57143(discoveryTracer, "Attempting to load module: {0}", moduleName);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 57170, 57190);

                            Exception
                            exception
                            = default(Exception);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 57216, 57341);

                            Collection<PSModuleInfo>
                            importedModule = f_1246_57258_57340(moduleName, context, f_1246_57303_57324(cmdletInfo), out exception)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 57367, 57389);

                            lastError = exception;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 57417, 58004) || true) && ((importedModule == null) || (DynAbs.Tracing.TraceSender.Expression_False(1246, 57421, 57476) || (f_1246_57450_57470(importedModule) == 0)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 57417, 58004);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 57534, 57625);

                                string
                                error = f_1246_57549_57624(f_1246_57567_57611(), moduleName)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 57655, 57925);

                                CommandNotFoundException
                                commandNotFound = f_1246_57698_57924(originalCommandName, lastError, "CouldNotAutoLoadModule", error)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 57955, 57977);

                                throw commandNotFound;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 57417, 58004);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 58032, 58069);

                            discoveredModule = f_1246_58051_58068(importedModule, 0);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 56967, 58227);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 56967, 58227);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 58167, 58204);

                            discoveredModule = f_1246_58186_58203(existingModule, 0);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 56967, 58227);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 58251, 58278);

                        CommandInfo
                        exportedResult
                        = default(CommandInfo);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 58300, 58553) || true) && (f_1246_58304_58388(f_1246_58304_58337(discoveredModule), moduleCommandName, out exportedResult))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 58300, 58553);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 58506, 58530);

                            result = exportedResult;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 58300, 58553);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 56586, 58572);
                    }
                }
                catch (CommandNotFoundException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1246, 58601, 58644);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 58636, 58642);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1246, 58601, 58644);
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1246, 58658, 58705);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1246, 58658, 58705);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1246, 58719, 58825);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 58729, 58823);

                    f_1246_58729_58822(f_1246_58729_58753(context), "ActiveModuleSearch", commandName);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1246, 58719, 58825);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 58841, 58924) || true) && (etwEnabled)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 58841, 58924);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 58857, 58924);

                    f_1246_58857_58923(CommandDiscoveryEventSource.Log, commandName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 58841, 58924);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 58938, 58952);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1246, 53701, 58963);

                int
                f_1246_54060_54117(string
                this_param, char[]
                anyOf)
                {
                    var return_v = this_param.IndexOfAny(anyOf);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 54060, 54117);
                    return return_v;
                }


                char
                f_1246_54359_54388(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 54359, 54388);
                    return return_v;
                }


                int
                f_1246_54513_54531(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 54513, 54531);
                    return return_v;
                }


                string
                f_1246_54469_54555(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 54469, 54555);
                    return return_v;
                }


                int
                f_1246_54686_54742(string
                this_param, char[]
                anyOf)
                {
                    var return_v = this_param.IndexOfAny(anyOf);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 54686, 54742);
                    return return_v;
                }


                string
                f_1246_54829_54871(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 54829, 54871);
                    return return_v;
                }


                string
                f_1246_54961_55008(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 54961, 55008);
                    return return_v;
                }


                bool
                f_1246_55222_55266(string
                input, out System.Version
                result)
                {
                    var return_v = Version.TryParse(input, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 55222, 55266);
                    return return_v;
                }


                int
                f_1246_55377_55401(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 55377, 55401);
                    return return_v;
                }


                string
                f_1246_55328_55424(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 55328, 55424);
                    return return_v;
                }


                string
                f_1246_55460_55502(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 55460, 55502);
                    return return_v;
                }


                string
                f_1246_55535_55577(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 55535, 55577);
                    return return_v;
                }


                string
                f_1246_55683_55725(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 55683, 55725);
                    return return_v;
                }


                bool
                f_1246_55780_55812(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 55780, 55812);
                    return return_v;
                }


                bool
                f_1246_55816_55855(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 55816, 55855);
                    return return_v;
                }


                bool
                f_1246_55859_55883(string
                this_param, char
                value)
                {
                    var return_v = this_param.EndsWith(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 55859, 55883);
                    return return_v;
                }


                bool
                f_1246_55948_55991(System.Management.Automation.CommandDiscoveryEventSource
                this_param)
                {
                    var return_v = this_param.IsEnabled();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 55948, 55991);
                    return return_v;
                }


                int
                f_1246_56022_56089(System.Management.Automation.CommandDiscoveryEventSource
                this_param, string
                CommandName)
                {
                    this_param.ModuleAutoLoadingStart(CommandName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 56022, 56089);
                    return 0;
                }


                int
                f_1246_56142_56222(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 56142, 56222);
                    return 0;
                }


                System.Management.Automation.CommandDiscovery
                f_1246_56241_56265(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CommandDiscovery;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 56241, 56265);
                    return return_v;
                }


                int
                f_1246_56241_56332(System.Management.Automation.CommandDiscovery
                this_param, string
                currentAction, string
                command)
                {
                    this_param.RegisterLookupCommandInfoAction(currentAction, command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 56241, 56332);
                    return 0;
                }


                System.Management.Automation.SessionState
                f_1246_56479_56499(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 56479, 56499);
                    return return_v;
                }


                System.Management.Automation.CommandInvocationIntrinsics
                f_1246_56479_56513(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.InvokeCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 56479, 56513);
                    return return_v;
                }


                System.Management.Automation.CmdletInfo
                f_1246_56479_56567(System.Management.Automation.CommandInvocationIntrinsics
                this_param, string
                commandName)
                {
                    var return_v = this_param.GetCmdlet(commandName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 56479, 56567);
                    return return_v;
                }


                System.Management.Automation.SessionStateEntryVisibility
                f_1246_56682_56703(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.Visibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 56682, 56703);
                    return return_v;
                }


                System.Management.Automation.ModuleIntrinsics
                f_1246_56821_56836(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Modules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 56821, 56836);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                f_1246_56821_56883(System.Management.Automation.ModuleIntrinsics
                this_param, string[]
                patterns, bool
                all)
                {
                    var return_v = this_param.GetModules(patterns, all);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 56821, 56883);
                    return return_v;
                }


                int
                f_1246_56997_57017(System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 56997, 57017);
                    return return_v;
                }


                int
                f_1246_57072_57143(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 57072, 57143);
                    return 0;
                }


                System.Management.Automation.SessionStateEntryVisibility
                f_1246_57303_57324(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.Visibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 57303, 57324);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSModuleInfo>
                f_1246_57258_57340(string
                moduleName, System.Management.Automation.ExecutionContext
                context, System.Management.Automation.SessionStateEntryVisibility
                visibility, out System.Exception
                exception)
                {
                    var return_v = AutoloadSpecifiedModule(moduleName, context, visibility, out exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 57258, 57340);
                    return return_v;
                }


                int
                f_1246_57450_57470(System.Collections.ObjectModel.Collection<System.Management.Automation.PSModuleInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 57450, 57470);
                    return return_v;
                }


                string
                f_1246_57567_57611()
                {
                    var return_v = DiscoveryExceptions.CouldNotAutoImportModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 57567, 57611);
                    return return_v;
                }


                string
                f_1246_57549_57624(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 57549, 57624);
                    return return_v;
                }


                System.Management.Automation.CommandNotFoundException
                f_1246_57698_57924(string
                commandName, System.Exception
                innerException, string
                errorIdAndResourceId, string
                resourceStr, params object[]
                messageArgs)
                {
                    var return_v = new System.Management.Automation.CommandNotFoundException(commandName, innerException, errorIdAndResourceId, resourceStr, messageArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 57698, 57924);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1246_58051_58068(System.Collections.ObjectModel.Collection<System.Management.Automation.PSModuleInfo>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 58051, 58068);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1246_58186_58203(System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 58186, 58203);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.CommandInfo>
                f_1246_58304_58337(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.ExportedCommands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 58304, 58337);
                    return return_v;
                }


                bool
                f_1246_58304_58388(System.Collections.Generic.Dictionary<string, System.Management.Automation.CommandInfo>
                this_param, string
                key, out System.Management.Automation.CommandInfo
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 58304, 58388);
                    return return_v;
                }


                System.Management.Automation.CommandDiscovery
                f_1246_58729_58753(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CommandDiscovery;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 58729, 58753);
                    return return_v;
                }


                int
                f_1246_58729_58822(System.Management.Automation.CommandDiscovery
                this_param, string
                currentAction, string
                command)
                {
                    this_param.UnregisterLookupCommandInfoAction(currentAction, command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 58729, 58822);
                    return 0;
                }


                int
                f_1246_58857_58923(System.Management.Automation.CommandDiscoveryEventSource
                this_param, string
                CommandName)
                {
                    this_param.ModuleAutoLoadingStop(CommandName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 58857, 58923);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 53701, 58963);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 53701, 58963);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void RegisterLookupCommandInfoAction(string currentAction, string command)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1246, 58975, 59739);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 59083, 59123);

                HashSet<string>
                currentActionSet = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 59137, 59551);

                switch (currentAction)
                {

                    case "ActivePreLookup":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 59137, 59551);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 59216, 59252);

                        currentActionSet = _activePreLookup;
                        DynAbs.Tracing.TraceSender.TraceBreak(1246, 59253, 59259);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 59137, 59551);

                    case "ActiveModuleSearch":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 59137, 59551);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 59304, 59343);

                        currentActionSet = _activeModuleSearch;
                        DynAbs.Tracing.TraceSender.TraceBreak(1246, 59344, 59350);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 59137, 59551);

                    case "ActiveCommandNotFound":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 59137, 59551);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 59398, 59440);

                        currentActionSet = _activeCommandNotFound;
                        DynAbs.Tracing.TraceSender.TraceBreak(1246, 59441, 59447);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 59137, 59551);

                    case "ActivePostCommand":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 59137, 59551);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 59491, 59529);

                        currentActionSet = _activePostCommand;
                        DynAbs.Tracing.TraceSender.TraceBreak(1246, 59530, 59536);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 59137, 59551);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 59567, 59728) || true) && (f_1246_59571_59605(currentActionSet, command))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 59567, 59728);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 59624, 59662);

                    throw f_1246_59630_59661();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 59567, 59728);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 59567, 59728);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 59698, 59728);

                    f_1246_59698_59727(currentActionSet, command);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 59567, 59728);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1246, 58975, 59739);

                bool
                f_1246_59571_59605(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 59571, 59605);
                    return return_v;
                }


                System.InvalidOperationException
                f_1246_59630_59661()
                {
                    var return_v = new System.InvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 59630, 59661);
                    return return_v;
                }


                bool
                f_1246_59698_59727(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 59698, 59727);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 58975, 59739);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 58975, 59739);
            }
        }

        internal void UnregisterLookupCommandInfoAction(string currentAction, string command)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1246, 59751, 60446);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 59861, 59901);

                HashSet<string>
                currentActionSet = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 59915, 60329);

                switch (currentAction)
                {

                    case "ActivePreLookup":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 59915, 60329);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 59994, 60030);

                        currentActionSet = _activePreLookup;
                        DynAbs.Tracing.TraceSender.TraceBreak(1246, 60031, 60037);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 59915, 60329);

                    case "ActiveModuleSearch":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 59915, 60329);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 60082, 60121);

                        currentActionSet = _activeModuleSearch;
                        DynAbs.Tracing.TraceSender.TraceBreak(1246, 60122, 60128);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 59915, 60329);

                    case "ActiveCommandNotFound":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 59915, 60329);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 60176, 60218);

                        currentActionSet = _activeCommandNotFound;
                        DynAbs.Tracing.TraceSender.TraceBreak(1246, 60219, 60225);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 59915, 60329);

                    case "ActivePostCommand":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 59915, 60329);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 60269, 60307);

                        currentActionSet = _activePostCommand;
                        DynAbs.Tracing.TraceSender.TraceBreak(1246, 60308, 60314);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 59915, 60329);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 60345, 60435) || true) && (f_1246_60349_60383(currentActionSet, command))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 60345, 60435);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 60402, 60435);

                    f_1246_60402_60434(currentActionSet, command);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 60345, 60435);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1246, 59751, 60446);

                bool
                f_1246_60349_60383(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 60349, 60383);
                    return return_v;
                }


                bool
                f_1246_60402_60434(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Remove(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 60402, 60434);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 59751, 60446);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 59751, 60446);
            }
        }

        private HashSet<string> _activePreLookup;

        private HashSet<string> _activeModuleSearch;

        private HashSet<string> _activeCommandNotFound;

        private HashSet<string> _activePostCommand;

        internal IEnumerable<string> GetCommandPathSearcher(IEnumerable<string> patterns)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1246, 61466, 61848);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 61622, 61686);

                IEnumerable<string>
                lookupPathArray = f_1246_61660_61685(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 61772, 61837);

                return f_1246_61779_61836(patterns, lookupPathArray, f_1246_61828_61835());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1246, 61466, 61848);

                System.Collections.Generic.IEnumerable<string>
                f_1246_61660_61685(System.Management.Automation.CommandDiscovery
                this_param)
                {
                    var return_v = this_param.GetLookupDirectoryPaths();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 61660, 61685);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1246_61828_61835()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 61828, 61835);
                    return return_v;
                }


                System.Management.Automation.CommandPathSearch
                f_1246_61779_61836(System.Collections.Generic.IEnumerable<string>
                patterns, System.Collections.Generic.IEnumerable<string>
                lookupPaths, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new System.Management.Automation.CommandPathSearch(patterns, lookupPaths, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 61779, 61836);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 61466, 61848);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 61466, 61848);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal IEnumerable<string> GetLookupDirectoryPaths()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1246, 62304, 64377);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 62383, 62440);

                LookupPathCollection
                result = f_1246_62413_62439()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 62456, 62513);

                string
                path = f_1246_62470_62512("PATH")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 62529, 62609);

                f_1246_62529_62608(
                            discoveryTracer, "PATH: {0}", path);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 62625, 62810);

                bool
                isPathCacheValid =
                                path != null && (DynAbs.Tracing.TraceSender.Expression_True(1246, 62666, 62769) && f_1246_62699_62769(_pathCacheKey, path, StringComparison.OrdinalIgnoreCase)) && (DynAbs.Tracing.TraceSender.Expression_True(1246, 62666, 62809) && _cachedPath != null)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 62826, 64248) || true) && (!isPathCacheValid)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 62826, 64248);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 62931, 62957);

                    _cachedLookupPaths = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 63030, 63051);

                    _pathCacheKey = path;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 63071, 64138) || true) && (_pathCacheKey != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 63071, 64138);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 63138, 63254);

                        string[]
                        tokenizedPath = f_1246_63163_63253(_pathCacheKey, Utils.Separators.PathSeparator, StringSplitOptions.RemoveEmptyEntries)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 63276, 63315);

                        _cachedPath = f_1246_63290_63314();
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 63339, 64119);
                            foreach (string directory in f_1246_63368_63381_I(tokenizedPath))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 63339, 64119);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 63431, 63470);

                                string
                                tempDir = f_1246_63448_63469(directory)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 63496, 63997) || true) && (f_1246_63500_63536(tempDir, "~"))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 63496, 63997);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 63594, 63669);

                                    tempDir = f_1246_63604_63668(Environment.SpecialFolder.UserProfile);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 63496, 63997);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 63496, 63997);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 63727, 63997) || true) && (f_1246_63731_63784(tempDir, "~" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (Path.DirectorySeparatorChar).ToString(), 1246, 63756, 63783)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 63727, 63997);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 63842, 63970);

                                        tempDir = f_1246_63852_63916(Environment.SpecialFolder.UserProfile) + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (Path.DirectorySeparatorChar).ToString(), 1246, 63919, 63946) + f_1246_63949_63969(tempDir, 2);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 63727, 63997);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 63496, 63997);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 64025, 64050);

                                f_1246_64025_64049(
                                                        _cachedPath, tempDir);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 64076, 64096);

                                f_1246_64076_64095(result, tempDir);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 63339, 64119);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1246, 1, 781);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1246, 1, 781);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 63071, 64138);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 62826, 64248);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 62826, 64248);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 64204, 64233);

                    f_1246_64204_64232(result, _cachedPath);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 62826, 64248);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 64307, 64366);

                return _cachedLookupPaths ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.LookupPathCollection>(1246, 64314, 64365) ?? (_cachedLookupPaths = result));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1246, 62304, 64377);

                System.Management.Automation.LookupPathCollection
                f_1246_62413_62439()
                {
                    var return_v = new System.Management.Automation.LookupPathCollection();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 62413, 62439);
                    return return_v;
                }


                string?
                f_1246_62470_62512(string
                variable)
                {
                    var return_v = Environment.GetEnvironmentVariable(variable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 62470, 62512);
                    return return_v;
                }


                int
                f_1246_62529_62608(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 62529, 62608);
                    return 0;
                }


                bool
                f_1246_62699_62769(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 62699, 62769);
                    return return_v;
                }


                string[]
                f_1246_63163_63253(string
                this_param, char[]
                separator, System.StringSplitOptions
                options)
                {
                    var return_v = this_param.Split(separator, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 63163, 63253);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1246_63290_63314()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 63290, 63314);
                    return return_v;
                }


                string
                f_1246_63448_63469(string
                this_param)
                {
                    var return_v = this_param.TrimStart();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 63448, 63469);
                    return return_v;
                }


                bool
                f_1246_63500_63536(string
                s, string
                t)
                {
                    var return_v = s.EqualsOrdinalIgnoreCase(t);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 63500, 63536);
                    return return_v;
                }


                string
                f_1246_63604_63668(System.Environment.SpecialFolder
                folder)
                {
                    var return_v = Environment.GetFolderPath(folder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 63604, 63668);
                    return return_v;
                }


                bool
                f_1246_63731_63784(string
                this_param, string
                value)
                {
                    var return_v = this_param.StartsWith(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 63731, 63784);
                    return return_v;
                }


                string
                f_1246_63852_63916(System.Environment.SpecialFolder
                folder)
                {
                    var return_v = Environment.GetFolderPath(folder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 63852, 63916);
                    return return_v;
                }


                string
                f_1246_63949_63969(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 63949, 63969);
                    return return_v;
                }


                int
                f_1246_64025_64049(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 64025, 64049);
                    return 0;
                }


                int
                f_1246_64076_64095(System.Management.Automation.LookupPathCollection
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 64076, 64095);
                    return return_v;
                }


                string[]
                f_1246_63368_63381_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 63368, 63381);
                    return return_v;
                }


                int
                f_1246_64204_64232(System.Management.Automation.LookupPathCollection
                this_param, System.Collections.ObjectModel.Collection<string>
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.ICollection<string>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 64204, 64232);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 62304, 64377);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 62304, 64377);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private LookupPathCollection _cachedLookupPaths;

        private string _pathCacheKey;

        private Collection<string> _cachedPath;

        internal static string[] PathExtensionsWithPs1Prepended
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1246, 65208, 65626);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 65244, 65304);

                    var
                    pathExt = f_1246_65258_65303("PATHEXT")
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 65324, 65551) || true) && (!f_1246_65329_65406(pathExt, s_pathExtCacheKey, StringComparison.OrdinalIgnoreCase) || (DynAbs.Tracing.TraceSender.Expression_False(1246, 65328, 65464) || s_cachedPathExtCollection == null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 65324, 65551);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 65506, 65532);

                        f_1246_65506_65531(pathExt);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 65324, 65551);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 65571, 65611);

                    return s_cachedPathExtCollectionWithPs1;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1246, 65208, 65626);

                    string?
                    f_1246_65258_65303(string
                    variable)
                    {
                        var return_v = Environment.GetEnvironmentVariable(variable);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 65258, 65303);
                        return return_v;
                    }


                    bool
                    f_1246_65329_65406(string
                    a, string
                    b, System.StringComparison
                    comparisonType)
                    {
                        var return_v = string.Equals(a, b, comparisonType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 65329, 65406);
                        return return_v;
                    }


                    int
                    f_1246_65506_65531(string
                    pathExt)
                    {
                        InitPathExtCache(pathExt);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 65506, 65531);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 65128, 65637);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 65128, 65637);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static string[] PathExtensions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1246, 65842, 66253);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 65878, 65938);

                    var
                    pathExt = f_1246_65892_65937("PATHEXT")
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 65958, 66185) || true) && (!f_1246_65963_66040(pathExt, s_pathExtCacheKey, StringComparison.OrdinalIgnoreCase) || (DynAbs.Tracing.TraceSender.Expression_False(1246, 65962, 66098) || s_cachedPathExtCollection == null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 65958, 66185);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 66140, 66166);

                        f_1246_66140_66165(pathExt);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 65958, 66185);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 66205, 66238);

                    return s_cachedPathExtCollection;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1246, 65842, 66253);

                    string?
                    f_1246_65892_65937(string
                    variable)
                    {
                        var return_v = Environment.GetEnvironmentVariable(variable);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 65892, 65937);
                        return return_v;
                    }


                    bool
                    f_1246_65963_66040(string
                    a, string
                    b, System.StringComparison
                    comparisonType)
                    {
                        var return_v = string.Equals(a, b, comparisonType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 65963, 66040);
                        return return_v;
                    }


                    int
                    f_1246_66140_66165(string
                    pathExt)
                    {
                        InitPathExtCache(pathExt);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 66140, 66165);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 65778, 66264);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 65778, 66264);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static void InitPathExtCache(string pathExt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1246, 66276, 67009);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 66359, 66371);
                lock (s_lockObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 66405, 66602);

                    s_cachedPathExtCollection = (DynAbs.Tracing.TraceSender.Conditional_F1(1246, 66433, 66448) || ((pathExt != null
                    && DynAbs.Tracing.TraceSender.Conditional_F2(1246, 66472, 66556)) || DynAbs.Tracing.TraceSender.Conditional_F3(1246, 66580, 66601))) ? f_1246_66472_66556(pathExt, Utils.Separators.PathSeparator, StringSplitOptions.RemoveEmptyEntries) : f_1246_66580_66601();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 66620, 66704);

                    s_cachedPathExtCollectionWithPs1 = new string[f_1246_66666_66698(s_cachedPathExtCollection) + 1];
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 66722, 66805);

                    s_cachedPathExtCollectionWithPs1[0] = StringLiterals.PowerShellScriptFileExtension;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 66823, 66935);

                    f_1246_66823_66934(s_cachedPathExtCollection, 0, s_cachedPathExtCollectionWithPs1, 1, f_1246_66901_66933(s_cachedPathExtCollection));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 66955, 66983);

                    s_pathExtCacheKey = pathExt;
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1246, 66276, 67009);

                string[]
                f_1246_66472_66556(string
                this_param, char[]
                separator, System.StringSplitOptions
                options)
                {
                    var return_v = this_param.Split(separator, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 66472, 66556);
                    return return_v;
                }


                string[]
                f_1246_66580_66601()
                {
                    var return_v = Array.Empty<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 66580, 66601);
                    return return_v;
                }


                int
                f_1246_66666_66698(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 66666, 66698);
                    return return_v;
                }


                int
                f_1246_66901_66933(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 66901, 66933);
                    return return_v;
                }


                int
                f_1246_66823_66934(string[]
                sourceArray, int
                sourceIndex, string[]
                destinationArray, int
                destinationIndex, int
                length)
                {
                    Array.Copy((System.Array)sourceArray, sourceIndex, (System.Array)destinationArray, destinationIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 66823, 66934);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 66276, 67009);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 66276, 67009);
            }
        }

        private static object s_lockObject;

        private static string s_pathExtCacheKey;

        private static string[] s_cachedPathExtCollection;

        private static string[] s_cachedPathExtCollectionWithPs1;

        internal IEnumerator<CmdletInfo> GetCmdletInfo(string cmdletName, bool searchAllScopes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1246, 68026, 71374);

                var listYield = new List<CmdletInfo>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 68138, 68223);

                f_1246_68138_68222(!f_1246_68150_68182(cmdletName), "Caller should verify the cmdletName");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 68239, 68321);

                PSSnapinQualifiedName
                commandName = f_1246_68275_68320(cmdletName)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 68337, 68421) || true) && (commandName == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 68337, 68421);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 68394, 68406);

                    return listYield.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 68337, 68421);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 68564, 68700);

                SessionStateScopeEnumerator
                scopeEnumerator =
                f_1246_68627_68699(f_1246_68659_68698(f_1246_68659_68685(f_1246_68659_68666())))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 68716, 71363);
                    foreach (SessionStateScope scope in f_1246_68752_68767_I(scopeEnumerator))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 68716, 71363);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 68801, 68826);

                        List<CmdletInfo>
                        cmdlets
                        = default(List<CmdletInfo>);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 68844, 68984) || true) && (!f_1246_68849_68914(f_1246_68849_68866(scope), f_1246_68879_68900(commandName), out cmdlets))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 68844, 68984);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 68956, 68965);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 68844, 68984);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 69004, 71348);
                            foreach (var cmdletInfo in f_1246_69031_69038_I(cmdlets))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 69004, 71348);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 69080, 71329) || true) && (!f_1246_69085_69131(f_1246_69106_69130(commandName)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 69080, 71329);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 69181, 71041) || true) && (f_1246_69185_69283(f_1246_69199_69220(cmdletInfo), f_1246_69222_69246(commandName), StringComparison.OrdinalIgnoreCase))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 69181, 71041);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 69341, 69365);

                                        listYield.Add(cmdletInfo);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 69395, 69524) || true) && (!searchAllScopes)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 69395, 69524);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 69481, 69493);

                                            return listYield.GetEnumerator();
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 69395, 69524);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 69181, 71041);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 69181, 71041);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 70353, 71041) || true) && (f_1246_70357_70414(f_1246_70392_70413(cmdletInfo)))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 70353, 71041);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 70472, 71014) || true) && (f_1246_70476_70718(f_1246_70524_70545(cmdletInfo), f_1246_70580_70648(f_1246_70623_70647(commandName)), StringComparison.OrdinalIgnoreCase))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 70472, 71014);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 70784, 70808);

                                                listYield.Add(cmdletInfo);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 70842, 70983) || true) && (!searchAllScopes)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 70842, 70983);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 70936, 70948);

                                                    return listYield.GetEnumerator();
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 70842, 70983);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 70472, 71014);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 70353, 71041);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 69181, 71041);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 69080, 71329);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 69080, 71329);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 71139, 71163);

                                    listYield.Add(cmdletInfo);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 71189, 71306) || true) && (!searchAllScopes)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 71189, 71306);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 71267, 71279);

                                        return listYield.GetEnumerator();
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 71189, 71306);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 69080, 71329);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 69004, 71348);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1246, 1, 2345);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1246, 1, 2345);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 68716, 71363);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1246, 1, 2648);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1246, 1, 2648);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1246, 68026, 71374);

                return listYield.GetEnumerator();

                bool
                f_1246_68150_68182(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 68150, 68182);
                    return return_v;
                }


                int
                f_1246_68138_68222(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 68138, 68222);
                    return 0;
                }


                System.Management.Automation.PSSnapinQualifiedName
                f_1246_68275_68320(string
                name)
                {
                    var return_v = PSSnapinQualifiedName.GetInstance(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 68275, 68320);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1246_68659_68666()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 68659, 68666);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1246_68659_68685(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 68659, 68685);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1246_68659_68698(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 68659, 68698);
                    return return_v;
                }


                System.Management.Automation.SessionStateScopeEnumerator
                f_1246_68627_68699(System.Management.Automation.SessionStateScope
                scope)
                {
                    var return_v = new System.Management.Automation.SessionStateScopeEnumerator(scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 68627, 68699);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.CmdletInfo>>
                f_1246_68849_68866(System.Management.Automation.SessionStateScope
                this_param)
                {
                    var return_v = this_param.CmdletTable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 68849, 68866);
                    return return_v;
                }


                string
                f_1246_68879_68900(System.Management.Automation.PSSnapinQualifiedName
                this_param)
                {
                    var return_v = this_param.ShortName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 68879, 68900);
                    return return_v;
                }


                bool
                f_1246_68849_68914(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.CmdletInfo>>
                this_param, string
                key, out System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 68849, 68914);
                    return return_v;
                }


                string
                f_1246_69106_69130(System.Management.Automation.PSSnapinQualifiedName
                this_param)
                {
                    var return_v = this_param.PSSnapInName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 69106, 69130);
                    return return_v;
                }


                bool
                f_1246_69085_69131(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 69085, 69131);
                    return return_v;
                }


                string
                f_1246_69199_69220(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 69199, 69220);
                    return return_v;
                }


                string
                f_1246_69222_69246(System.Management.Automation.PSSnapinQualifiedName
                this_param)
                {
                    var return_v = this_param.PSSnapInName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 69222, 69246);
                    return return_v;
                }


                bool
                f_1246_69185_69283(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 69185, 69283);
                    return return_v;
                }


                string
                f_1246_70392_70413(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 70392, 70413);
                    return return_v;
                }


                bool
                f_1246_70357_70414(string
                moduleName)
                {
                    var return_v = InitialSessionState.IsEngineModule(moduleName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 70357, 70414);
                    return return_v;
                }


                string
                f_1246_70524_70545(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 70524, 70545);
                    return return_v;
                }


                string
                f_1246_70623_70647(System.Management.Automation.PSSnapinQualifiedName
                this_param)
                {
                    var return_v = this_param.PSSnapInName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 70623, 70647);
                    return return_v;
                }


                string
                f_1246_70580_70648(string
                moduleName)
                {
                    var return_v = InitialSessionState.GetNestedModuleDllName(moduleName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 70580, 70648);
                    return return_v;
                }


                bool
                f_1246_70476_70718(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 70476, 70718);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
                f_1246_69031_69038_I(System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 69031, 69038);
                    return return_v;
                }


                System.Management.Automation.SessionStateScopeEnumerator
                f_1246_68752_68767_I(System.Management.Automation.SessionStateScopeEnumerator
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 68752, 68767);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 68026, 71374);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 68026, 71374);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ExecutionContext Context { get; }

        internal static PSModuleAutoLoadingPreference GetCommandDiscoveryPreference(ExecutionContext context, VariablePath variablePath, string environmentVariable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1246, 71440, 72898);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 71621, 71675);

                f_1246_71621_71674(context != null, "context cannot be Null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 71689, 71756);

                f_1246_71689_71755(variablePath != null, "variablePath must be non empty");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 71770, 71866);

                f_1246_71770_71865(!f_1246_71782_71823(environmentVariable), "environmentVariable must be non empty");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 71882, 72006) || true) && (context == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 71882, 72006);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 71935, 71991);

                    throw f_1246_71941_71990("context");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 71882, 72006);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 72059, 72114);

                object
                result = f_1246_72075_72113(context, variablePath)
                ;

                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 72166, 72320) || true) && (result != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 72166, 72320);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 72226, 72301);

                        return f_1246_72233_72300(result);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 72166, 72320);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 72391, 72478);

                    string
                    psEnvironmentVariable = f_1246_72422_72477(environmentVariable)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 72496, 72695) || true) && (!f_1246_72501_72544(psEnvironmentVariable))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 72496, 72695);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 72586, 72676);

                        return f_1246_72593_72675(psEnvironmentVariable);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 72496, 72695);
                    }
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1246, 72724, 72830);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 72774, 72815);

                    return PSModuleAutoLoadingPreference.All;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1246, 72724, 72830);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 72846, 72887);

                return PSModuleAutoLoadingPreference.All;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1246, 71440, 72898);

                int
                f_1246_71621_71674(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 71621, 71674);
                    return 0;
                }


                int
                f_1246_71689_71755(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 71689, 71755);
                    return 0;
                }


                bool
                f_1246_71782_71823(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 71782, 71823);
                    return return_v;
                }


                int
                f_1246_71770_71865(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 71770, 71865);
                    return 0;
                }


                System.Management.Automation.PSArgumentNullException
                f_1246_71941_71990(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 71941, 71990);
                    return return_v;
                }


                object
                f_1246_72075_72113(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.VariablePath
                path)
                {
                    var return_v = this_param.GetVariableValue(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 72075, 72113);
                    return return_v;
                }


                System.Management.Automation.PSModuleAutoLoadingPreference
                f_1246_72233_72300(object
                valueToConvert)
                {
                    var return_v = LanguagePrimitives.ConvertTo<PSModuleAutoLoadingPreference>(valueToConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 72233, 72300);
                    return return_v;
                }


                string?
                f_1246_72422_72477(string
                variable)
                {
                    var return_v = Environment.GetEnvironmentVariable(variable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 72422, 72477);
                    return return_v;
                }


                bool
                f_1246_72501_72544(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 72501, 72544);
                    return return_v;
                }


                System.Management.Automation.PSModuleAutoLoadingPreference
                f_1246_72593_72675(string
                valueToConvert)
                {
                    var return_v = LanguagePrimitives.ConvertTo<PSModuleAutoLoadingPreference>((object)valueToConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 72593, 72675);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 71440, 72898);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 71440, 72898);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CommandDiscovery()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1246, 3708, 72927);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 3904, 4112);
            discoveryTracer = f_1246_3935_4112("CommandDiscovery", "Traces the discovery of cmdlets, scripts, functions, applications, etc.", false);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 67129, 67156);
            s_lockObject = f_1246_67144_67156();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 67189, 67206);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 67241, 67266);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 67301, 67333);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1246, 3708, 72927);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 3708, 72927);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1246, 3708, 72927);

        static System.Management.Automation.PSTraceSource
        f_1246_3935_4112(string
        name, string
        description, bool
        traceHeaders)
        {
            var return_v = PSTraceSource.GetTracer(name, description, traceHeaders);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 3935, 4112);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1246_4499_4548(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 4499, 4548);
            return return_v;
        }


        System.StringComparer
        f_1246_60521_60553()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 60521, 60553);
            return return_v;
        }


        System.Collections.Generic.HashSet<string>
        f_1246_60501_60554(System.StringComparer
        comparer)
        {
            var return_v = new System.Collections.Generic.HashSet<string>((System.Collections.Generic.IEqualityComparer<string>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 60501, 60554);
            return return_v;
        }


        System.StringComparer
        f_1246_60631_60663()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 60631, 60663);
            return return_v;
        }


        System.Collections.Generic.HashSet<string>
        f_1246_60611_60664(System.StringComparer
        comparer)
        {
            var return_v = new System.Collections.Generic.HashSet<string>((System.Collections.Generic.IEqualityComparer<string>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 60611, 60664);
            return return_v;
        }


        System.StringComparer
        f_1246_60744_60776()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 60744, 60776);
            return return_v;
        }


        System.Collections.Generic.HashSet<string>
        f_1246_60724_60777(System.StringComparer
        comparer)
        {
            var return_v = new System.Collections.Generic.HashSet<string>((System.Collections.Generic.IEqualityComparer<string>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 60724, 60777);
            return return_v;
        }


        System.StringComparer
        f_1246_60853_60885()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 60853, 60885);
            return return_v;
        }


        System.Collections.Generic.HashSet<string>
        f_1246_60833_60886(System.StringComparer
        comparer)
        {
            var return_v = new System.Collections.Generic.HashSet<string>((System.Collections.Generic.IEqualityComparer<string>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 60833, 60886);
            return return_v;
        }


        static object
        f_1246_67144_67156()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 67144, 67156);
            return return_v;
        }

    }
    internal class LookupPathCollection : Collection<string>
    {
        internal LookupPathCollection() : base()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1246, 73281, 73325);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1246, 73281, 73325);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 73281, 73325);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 73281, 73325);
            }
        }

        internal LookupPathCollection(IEnumerable<string> collection) : base()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1246, 73628, 73827);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 73723, 73816);
                    foreach (string item in f_1246_73747_73757_I(collection))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 73723, 73816);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 73791, 73801);

                        f_1246_73791_73800(this, item);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 73723, 73816);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1246, 1, 94);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1246, 1, 94);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1246, 73628, 73827);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 73628, 73827);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 73628, 73827);
            }
        }

        public new int Add(string item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1246, 74235, 74491);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 74291, 74307);

                int
                result = -1
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 74321, 74450) || true) && (!f_1246_74326_74340(this, item))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 74321, 74450);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 74374, 74389);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Add(item), 1246, 74374, 74388);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 74407, 74435);

                    result = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.IndexOf(item), 1246, 74416, 74434);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 74321, 74450);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 74466, 74480);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1246, 74235, 74491);

                bool
                f_1246_74326_74340(System.Management.Automation.LookupPathCollection
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 74326, 74340);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 74235, 74491);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 74235, 74491);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void AddRange(ICollection<string> collection)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1246, 74871, 75054);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 74950, 75043);
                    foreach (string name in f_1246_74974_74984_I(collection))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 74950, 75043);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 75018, 75028);

                        f_1246_75018_75027(this, name);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 74950, 75043);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1246, 1, 94);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1246, 1, 94);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1246, 74871, 75054);

                int
                f_1246_75018_75027(System.Management.Automation.LookupPathCollection
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 75018, 75027);
                    return return_v;
                }


                System.Collections.Generic.ICollection<string>
                f_1246_74974_74984_I(System.Collections.Generic.ICollection<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 74974, 74984);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 74871, 75054);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 74871, 75054);
            }
        }

        public new bool Contains(string item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1246, 75469, 75853);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 75531, 75551);

                bool
                result = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 75567, 75812);
                    foreach (string name in f_1246_75591_75595_I(this))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 75567, 75812);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 75629, 75797) || true) && (f_1246_75633_75694(item, name, StringComparison.OrdinalIgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 75629, 75797);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 75736, 75750);

                            result = true;
                            DynAbs.Tracing.TraceSender.TraceBreak(1246, 75772, 75778);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 75629, 75797);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 75567, 75812);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1246, 1, 246);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1246, 1, 246);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 75828, 75842);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1246, 75469, 75853);

                bool
                f_1246_75633_75694(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 75633, 75694);
                    return return_v;
                }


                System.Management.Automation.LookupPathCollection
                f_1246_75591_75595_I(System.Management.Automation.LookupPathCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 75591, 75595);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 75469, 75853);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 75469, 75853);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Collection<int> IndexOfRelativePath()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1246, 76107, 76577);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 76178, 76225);

                Collection<int>
                result = f_1246_76203_76224()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 76250, 76259);

                    for (int
        index = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 76241, 76536) || true) && (index < f_1246_76269_76279(this))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 76281, 76288)
        , ++index, DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 76241, 76536))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 76241, 76536);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 76322, 76348);

                        string
                        path = f_1246_76336_76347(this, index)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 76366, 76521) || true) && (!f_1246_76371_76397(path) && (DynAbs.Tracing.TraceSender.Expression_True(1246, 76370, 76442) && f_1246_76422_76442(path, '.')))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 76366, 76521);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 76484, 76502);

                            f_1246_76484_76501(result, index);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 76366, 76521);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1246, 1, 296);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1246, 1, 296);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 76552, 76566);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1246, 76107, 76577);

                System.Collections.ObjectModel.Collection<int>
                f_1246_76203_76224()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<int>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 76203, 76224);
                    return return_v;
                }


                int
                f_1246_76269_76279(System.Management.Automation.LookupPathCollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 76269, 76279);
                    return return_v;
                }


                string
                f_1246_76336_76347(System.Management.Automation.LookupPathCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 76336, 76347);
                    return return_v;
                }


                bool
                f_1246_76371_76397(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 76371, 76397);
                    return return_v;
                }


                bool
                f_1246_76422_76442(string
                this_param, char
                value)
                {
                    var return_v = this_param.StartsWith(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 76422, 76442);
                    return return_v;
                }


                int
                f_1246_76484_76501(System.Collections.ObjectModel.Collection<int>
                this_param, int
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 76484, 76501);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 76107, 76577);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 76107, 76577);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public new int IndexOf(string item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1246, 77149, 77698);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 77209, 77337) || true) && (f_1246_77213_77239(item))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 77209, 77337);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 77273, 77322);

                    throw f_1246_77279_77321("item");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 77209, 77337);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 77353, 77369);

                int
                result = -1
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 77394, 77403);

                    for (int
        index = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 77385, 77657) || true) && (index < f_1246_77413_77423(this))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 77425, 77432)
        , ++index, DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 77385, 77657))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 77385, 77657);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 77466, 77642) || true) && (f_1246_77470_77538(f_1246_77484_77495(this, index), item, StringComparison.OrdinalIgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1246, 77466, 77642);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 77580, 77595);

                            result = index;
                            DynAbs.Tracing.TraceSender.TraceBreak(1246, 77617, 77623);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1246, 77466, 77642);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1246, 1, 273);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1246, 1, 273);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 77673, 77687);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1246, 77149, 77698);

                bool
                f_1246_77213_77239(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 77213, 77239);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1246_77279_77321(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 77279, 77321);
                    return return_v;
                }


                int
                f_1246_77413_77423(System.Management.Automation.LookupPathCollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 77413, 77423);
                    return return_v;
                }


                string
                f_1246_77484_77495(System.Management.Automation.LookupPathCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1246, 77484, 77495);
                    return return_v;
                }


                bool
                f_1246_77470_77538(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 77470, 77538);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 77149, 77698);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 77149, 77698);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static LookupPathCollection()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1246, 73127, 77705);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1246, 73127, 77705);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 73127, 77705);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1246, 73127, 77705);

        int
        f_1246_73791_73800(System.Management.Automation.LookupPathCollection
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 73791, 73800);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<string>
        f_1246_73747_73757_I(System.Collections.Generic.IEnumerable<string>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 73747, 73757);
            return return_v;
        }

    }
    [EventSource(Name = "Microsoft-PowerShell-CommandDiscovery")]
    internal class CommandDiscoveryEventSource : EventSource
    {
        internal static CommandDiscoveryEventSource Log;

        public void CommandLookupStart(string CommandName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1246, 78006, 78088);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 78059, 78086);

                f_1246_78059_78085(this, 1, CommandName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1246, 78006, 78088);

                int
                f_1246_78059_78085(System.Management.Automation.CommandDiscoveryEventSource
                this_param, int
                eventId, string
                arg1)
                {
                    this_param.WriteEvent(eventId, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 78059, 78085);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 78006, 78088);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 78006, 78088);
            }
        }

        public void CommandLookupStop(string CommandName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1246, 78100, 78181);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 78152, 78179);

                f_1246_78152_78178(this, 2, CommandName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1246, 78100, 78181);

                int
                f_1246_78152_78178(System.Management.Automation.CommandDiscoveryEventSource
                this_param, int
                eventId, string
                arg1)
                {
                    this_param.WriteEvent(eventId, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 78152, 78178);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 78100, 78181);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 78100, 78181);
            }
        }

        public void ModuleAutoLoadingStart(string CommandName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1246, 78193, 78279);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 78250, 78277);

                f_1246_78250_78276(this, 3, CommandName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1246, 78193, 78279);

                int
                f_1246_78250_78276(System.Management.Automation.CommandDiscoveryEventSource
                this_param, int
                eventId, string
                arg1)
                {
                    this_param.WriteEvent(eventId, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 78250, 78276);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 78193, 78279);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 78193, 78279);
            }
        }

        public void ModuleAutoLoadingStop(string CommandName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1246, 78291, 78376);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 78347, 78374);

                f_1246_78347_78373(this, 4, CommandName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1246, 78291, 78376);

                int
                f_1246_78347_78373(System.Management.Automation.CommandDiscoveryEventSource
                this_param, int
                eventId, string
                arg1)
                {
                    this_param.WriteEvent(eventId, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 78347, 78373);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 78291, 78376);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 78291, 78376);
            }
        }

        public void ModuleAutoDiscoveryStart(string CommandName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1246, 78388, 78476);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 78447, 78474);

                f_1246_78447_78473(this, 5, CommandName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1246, 78388, 78476);

                int
                f_1246_78447_78473(System.Management.Automation.CommandDiscoveryEventSource
                this_param, int
                eventId, string
                arg1)
                {
                    this_param.WriteEvent(eventId, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 78447, 78473);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 78388, 78476);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 78388, 78476);
            }
        }

        public void ModuleAutoDiscoveryStop(string CommandName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1246, 78488, 78575);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 78546, 78573);

                f_1246_78546_78572(this, 6, CommandName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1246, 78488, 78575);

                int
                f_1246_78546_78572(System.Management.Automation.CommandDiscoveryEventSource
                this_param, int
                eventId, string
                arg1)
                {
                    this_param.WriteEvent(eventId, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 78546, 78572);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 78488, 78575);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 78488, 78575);
            }
        }

        public void SearchingForModuleFilesStart()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1246, 78587, 78648);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 78632, 78646);

                f_1246_78632_78645(this, 7);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1246, 78587, 78648);

                int
                f_1246_78632_78645(System.Management.Automation.CommandDiscoveryEventSource
                this_param, int
                eventId)
                {
                    this_param.WriteEvent(eventId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 78632, 78645);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 78587, 78648);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 78587, 78648);
            }
        }

        public void SearchingForModuleFilesStop()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1246, 78660, 78720);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 78704, 78718);

                f_1246_78704_78717(this, 8);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1246, 78660, 78720);

                int
                f_1246_78704_78717(System.Management.Automation.CommandDiscoveryEventSource
                this_param, int
                eventId)
                {
                    this_param.WriteEvent(eventId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 78704, 78717);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 78660, 78720);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 78660, 78720);
            }
        }

        public void GetModuleExportedCommandsStart(string ModulePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1246, 78732, 78824);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 78796, 78822);

                f_1246_78796_78821(this, 9, ModulePath);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1246, 78732, 78824);

                int
                f_1246_78796_78821(System.Management.Automation.CommandDiscoveryEventSource
                this_param, int
                eventId, string
                arg1)
                {
                    this_param.WriteEvent(eventId, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 78796, 78821);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 78732, 78824);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 78732, 78824);
            }
        }

        public void GetModuleExportedCommandsStop(string ModulePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1246, 78836, 78928);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 78899, 78926);

                f_1246_78899_78925(this, 10, ModulePath);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1246, 78836, 78928);

                int
                f_1246_78899_78925(System.Management.Automation.CommandDiscoveryEventSource
                this_param, int
                eventId, string
                arg1)
                {
                    this_param.WriteEvent(eventId, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 78899, 78925);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 78836, 78928);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 78836, 78928);
            }
        }

        public void ModuleManifestAnalysisResult(string ModulePath, bool Success)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1246, 78940, 79054);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 79016, 79052);

                f_1246_79016_79051(this, 11, ModulePath, Success);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1246, 78940, 79054);

                int
                f_1246_79016_79051(System.Management.Automation.CommandDiscoveryEventSource
                this_param, int
                eventId, params object?[]
                args)
                {
                    this_param.WriteEvent(eventId, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 79016, 79051);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 78940, 79054);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 78940, 79054);
            }
        }

        public void ModuleManifestAnalysisException(string ModulePath, string Exception)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1246, 79066, 79189);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 79149, 79187);

                f_1246_79149_79186(this, 12, ModulePath, Exception);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1246, 79066, 79189);

                int
                f_1246_79149_79186(System.Management.Automation.CommandDiscoveryEventSource
                this_param, int
                eventId, string
                arg1, string
                arg2)
                {
                    this_param.WriteEvent(eventId, arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 79149, 79186);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1246, 79066, 79189);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 79066, 79189);
            }
        }

        public CommandDiscoveryEventSource()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1246, 77770, 79196);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1246, 77770, 79196);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 77770, 79196);
        }


        static CommandDiscoveryEventSource()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1246, 77770, 79196);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1246, 77954, 77993);
            Log = f_1246_77960_77993();
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1246, 77770, 79196);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1246, 77770, 79196);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1246, 77770, 79196);

        static System.Management.Automation.CommandDiscoveryEventSource
        f_1246_77960_77993()
        {
            var return_v = new System.Management.Automation.CommandDiscoveryEventSource();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1246, 77960, 77993);
            return return_v;
        }

    }
}

