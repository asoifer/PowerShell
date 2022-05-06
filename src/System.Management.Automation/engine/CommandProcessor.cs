// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Concurrent;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Management.Automation.Internal;

using Microsoft.PowerShell.Commands;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation
{
    internal class CommandProcessor : CommandProcessorBase
    {
        static CommandProcessor()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1251, 743, 2498);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 30461, 30485);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 793, 867);

                s_constructInstanceCache = f_1251_820_866();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 1107, 1205);

                f_1251_1107_1204(
                            // Avoid jitting constructors some of the more commonly used cmdlets in SMA.dll - not meant to be
                            // exhaustive b/c many cmdlets aren't called at all, so we'd never even need an entry in the cache.
                            s_constructInstanceCache, typeof(ForEachObjectCommand), () => new ForEachObjectCommand());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 1219, 1313);

                f_1251_1219_1312(s_constructInstanceCache, typeof(WhereObjectCommand), () => new WhereObjectCommand());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 1327, 1423);

                f_1251_1327_1422(s_constructInstanceCache, typeof(ImportModuleCommand), () => new ImportModuleCommand());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 1437, 1527);

                f_1251_1437_1526(s_constructInstanceCache, typeof(GetModuleCommand), () => new GetModuleCommand());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 1541, 1627);

                f_1251_1541_1626(s_constructInstanceCache, typeof(GetHelpCommand), () => new GetHelpCommand());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 1641, 1739);

                f_1251_1641_1738(s_constructInstanceCache, typeof(InvokeCommandCommand), () => new InvokeCommandCommand());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 1753, 1845);

                f_1251_1753_1844(s_constructInstanceCache, typeof(GetCommandCommand), () => new GetCommandCommand());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 1859, 1951);

                f_1251_1859_1950(s_constructInstanceCache, typeof(OutDefaultCommand), () => new OutDefaultCommand());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 1965, 2051);

                f_1251_1965_2050(s_constructInstanceCache, typeof(OutHostCommand), () => new OutHostCommand());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 2065, 2151);

                f_1251_2065_2150(s_constructInstanceCache, typeof(OutNullCommand), () => new OutNullCommand());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 2165, 2263);

                f_1251_2165_2262(s_constructInstanceCache, typeof(SetStrictModeCommand), () => new SetStrictModeCommand());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 2277, 2375);

                f_1251_2277_2374(s_constructInstanceCache, typeof(FormatDefaultCommand), () => new FormatDefaultCommand());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 2389, 2487);

                f_1251_2389_2486(s_constructInstanceCache, typeof(OutLineOutputCommand), () => new OutLineOutputCommand());
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1251, 743, 2498);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1251, 743, 2498);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1251, 743, 2498);
            }
        }

        internal CommandProcessor(CmdletInfo cmdletInfo, ExecutionContext context) : base(f_1251_3101_3111_C(cmdletInfo))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1251, 3019, 3203);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 6257, 6289);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 6573, 6591);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 20142, 20165);
                this._firstCallToRead = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 20303, 20318);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 3137, 3161);

                this._context = context;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 3175, 3192);

                f_1251_3175_3191(this, cmdletInfo);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1251, 3019, 3203);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1251, 3019, 3203);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1251, 3019, 3203);
            }
        }

        internal CommandProcessor(IScriptCommandInfo scriptCommandInfo, ExecutionContext context, bool useLocalScope, bool fromScriptFile, SessionStateInternal sessionState)
        : base(f_1251_3999_4031_C(scriptCommandInfo as CommandInfo))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1251, 3813, 4286);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 6257, 6289);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 6573, 6591);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 20142, 20165);
                this._firstCallToRead = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 20303, 20318);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 4057, 4081);

                this._context = context;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 4095, 4131);

                this._useLocalScope = useLocalScope;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 4145, 4183);

                this._fromScriptFile = fromScriptFile;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 4197, 4237);

                this.CommandSessionState = sessionState;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 4251, 4275);

                f_1251_4251_4274(this, scriptCommandInfo);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1251, 3813, 4286);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1251, 3813, 4286);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1251, 3813, 4286);
            }
        }

        internal ParameterBinderController NewParameterBinderController(InternalCommand command)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1251, 4844, 5826);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 4957, 4991);

                Cmdlet
                cmdlet = command as Cmdlet
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 5005, 5124) || true) && (cmdlet == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1251, 5005, 5124);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 5057, 5109);

                    throw f_1251_5063_5108("command");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1251, 5005, 5124);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 5140, 5176);

                ParameterBinderBase
                parameterBinder
                = default(ParameterBinderBase);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 5190, 5263);

                IScriptCommandInfo
                scriptCommandInfo = f_1251_5229_5240() as IScriptCommandInfo
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 5277, 5618) || true) && (scriptCommandInfo != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1251, 5277, 5618);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 5340, 5473);

                    parameterBinder = f_1251_5358_5472(f_1251_5384_5413(scriptCommandInfo), f_1251_5415_5434(cmdlet), this._context, cmdlet, f_1251_5459_5471());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1251, 5277, 5618);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1251, 5277, 5618);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 5539, 5603);

                    parameterBinder = f_1251_5557_5602(cmdlet, cmdlet);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1251, 5277, 5618);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 5634, 5759);

                _cmdletParameterBinderController = f_1251_5669_5758(cmdlet, f_1251_5713_5740(f_1251_5713_5724()), parameterBinder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 5775, 5815);

                return _cmdletParameterBinderController;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1251, 4844, 5826);

                System.Management.Automation.PSArgumentException
                f_1251_5063_5108(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 5063, 5108);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1251_5229_5240()
                {
                    var return_v = CommandInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 5229, 5240);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1251_5384_5413(System.Management.Automation.IScriptCommandInfo
                this_param)
                {
                    var return_v = this_param.ScriptBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 5384, 5413);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1251_5415_5434(System.Management.Automation.Cmdlet
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 5415, 5434);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1251_5459_5471()
                {
                    var return_v = CommandScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 5459, 5471);
                    return return_v;
                }


                System.Management.Automation.ScriptParameterBinder
                f_1251_5358_5472(System.Management.Automation.ScriptBlock
                script, System.Management.Automation.InvocationInfo
                invocationInfo, System.Management.Automation.ExecutionContext
                context, System.Management.Automation.Cmdlet
                command, System.Management.Automation.SessionStateScope
                localScope)
                {
                    var return_v = new System.Management.Automation.ScriptParameterBinder(script, invocationInfo, context, (System.Management.Automation.Internal.InternalCommand)command, localScope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 5358, 5472);
                    return return_v;
                }


                System.Management.Automation.ReflectionParameterBinder
                f_1251_5557_5602(System.Management.Automation.Cmdlet
                target, System.Management.Automation.Cmdlet
                command)
                {
                    var return_v = new System.Management.Automation.ReflectionParameterBinder((object)target, command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 5557, 5602);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1251_5713_5724()
                {
                    var return_v = CommandInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 5713, 5724);
                    return return_v;
                }


                System.Management.Automation.CommandMetadata
                f_1251_5713_5740(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.CommandMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 5713, 5740);
                    return return_v;
                }


                System.Management.Automation.CmdletParameterBinderController
                f_1251_5669_5758(System.Management.Automation.Cmdlet
                cmdlet, System.Management.Automation.CommandMetadata
                commandMetadata, System.Management.Automation.ParameterBinderBase
                parameterBinder)
                {
                    var return_v = new System.Management.Automation.CmdletParameterBinderController(cmdlet, commandMetadata, parameterBinder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 5669, 5758);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1251, 4844, 5826);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1251, 4844, 5826);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal CmdletParameterBinderController CmdletParameterBinderController
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1251, 5935, 6194);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 5971, 6119) || true) && (_cmdletParameterBinderController == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1251, 5971, 6119);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 6057, 6100);

                        f_1251_6057_6099(this, f_1251_6086_6098(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1251, 5971, 6119);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 6139, 6179);

                    return _cmdletParameterBinderController;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1251, 5935, 6194);

                    System.Management.Automation.Internal.InternalCommand
                    f_1251_6086_6098(System.Management.Automation.CommandProcessor
                    this_param)
                    {
                        var return_v = this_param.Command;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 6086, 6098);
                        return return_v;
                    }


                    System.Management.Automation.ParameterBinderController
                    f_1251_6057_6099(System.Management.Automation.CommandProcessor
                    this_param, System.Management.Automation.Internal.InternalCommand
                    command)
                    {
                        var return_v = this_param.NewParameterBinderController(command);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 6057, 6099);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1251, 5838, 6205);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1251, 5838, 6205);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private CmdletParameterBinderController _cmdletParameterBinderController;

        internal override ObsoleteAttribute ObsoleteAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1251, 6490, 6524);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 6496, 6522);

                    return _obsoleteAttribute;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1251, 6490, 6524);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1251, 6412, 6535);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1251, 6412, 6535);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ObsoleteAttribute _obsoleteAttribute;

        internal void BindCommandLineParameters()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1251, 7181, 8005);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 7247, 7994);
                using (f_1251_7254_7299(commandRuntime, false))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 7333, 7501);

                    f_1251_7333_7500(f_1251_7374_7410(this) != null, "A parameter binder controller should always be available");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 7676, 7783);

                    f_1251_7676_7782(f_1251_7676_7734(f_1251_7676_7712(this)), f_1251_7756_7781(f_1251_7756_7768(this)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 7801, 7885);

                    f_1251_7801_7826(f_1251_7801_7813(this)).UnboundArguments = f_1251_7846_7884();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 7905, 7979);

                    f_1251_7905_7978(f_1251_7905_7941(this), arguments);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1251, 7247, 7994);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1251, 7181, 8005);

                System.IDisposable
                f_1251_7254_7299(System.Management.Automation.MshCommandRuntime
                this_param, bool
                permittedToWriteToPipeline)
                {
                    var return_v = this_param.AllowThisCommandToWrite(permittedToWriteToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 7254, 7299);
                    return return_v;
                }


                System.Management.Automation.CmdletParameterBinderController
                f_1251_7374_7410(System.Management.Automation.CommandProcessor
                this_param)
                {
                    var return_v = this_param.CmdletParameterBinderController;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 7374, 7410);
                    return return_v;
                }


                int
                f_1251_7333_7500(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 7333, 7500);
                    return 0;
                }


                System.Management.Automation.CmdletParameterBinderController
                f_1251_7676_7712(System.Management.Automation.CommandProcessor
                this_param)
                {
                    var return_v = this_param.CmdletParameterBinderController;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 7676, 7712);
                    return return_v;
                }


                System.Management.Automation.CommandLineParameters
                f_1251_7676_7734(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    var return_v = this_param.CommandLineParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 7676, 7734);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1251_7756_7768(System.Management.Automation.CommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 7756, 7768);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1251_7756_7781(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 7756, 7781);
                    return return_v;
                }


                int
                f_1251_7676_7782(System.Management.Automation.CommandLineParameters
                this_param, System.Management.Automation.InvocationInfo
                invocationInfo)
                {
                    this_param.UpdateInvocationInfo(invocationInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 7676, 7782);
                    return 0;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1251_7801_7813(System.Management.Automation.CommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 7801, 7813);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1251_7801_7826(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 7801, 7826);
                    return return_v;
                }


                System.Collections.Generic.List<object>
                f_1251_7846_7884()
                {
                    var return_v = new System.Collections.Generic.List<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 7846, 7884);
                    return return_v;
                }


                System.Management.Automation.CmdletParameterBinderController
                f_1251_7905_7941(System.Management.Automation.CommandProcessor
                this_param)
                {
                    var return_v = this_param.CmdletParameterBinderController;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 7905, 7941);
                    return return_v;
                }


                int
                f_1251_7905_7978(System.Management.Automation.CmdletParameterBinderController
                this_param, System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                arguments)
                {
                    this_param.BindCommandLineParameters(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 7905, 7978);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1251, 7181, 8005);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1251, 7181, 8005);
            }
        }

        internal override void Prepare(IDictionary psDefaultParameterValues)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1251, 8546, 11742);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 9432, 9519);

                f_1251_9432_9468(this).DefaultParameterValues = psDefaultParameterValues;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 9535, 9684);

                f_1251_9535_9683(f_1251_9572_9584(this) != null, "CommandProcessor did not initialize Command\n" + f_1251_9661_9682(f_1251_9661_9677(this)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 9700, 9739);

                PSLanguageMode?
                oldLanguageMode = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 9753, 9794);

                bool?
                oldLangModeTransitionStatus = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 9844, 9906);

                    var
                    scriptCmdletInfo = f_1251_9867_9883(this) as IScriptCommandInfo
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 9924, 11065) || true) && (scriptCmdletInfo != null && (DynAbs.Tracing.TraceSender.Expression_True(1251, 9928, 10027) && f_1251_9977_10027(f_1251_9977_10018(f_1251_9977_10005(scriptCmdletInfo)))) && (DynAbs.Tracing.TraceSender.Expression_True(1251, 9928, 10117) && f_1251_10052_10093(f_1251_10052_10080(scriptCmdletInfo)) != f_1251_10097_10117(f_1251_10097_10104())))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1251, 9924, 11065);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 10408, 10447);

                        oldLanguageMode = f_1251_10426_10446(f_1251_10426_10433());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 10469, 10540);

                        f_1251_10469_10476().LanguageMode = f_1251_10492_10539(f_1251_10492_10533(f_1251_10492_10520(scriptCmdletInfo)));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 10700, 11046) || true) && (oldLanguageMode == PSLanguageMode.ConstrainedLanguage && (DynAbs.Tracing.TraceSender.Expression_True(1251, 10704, 10812) && f_1251_10761_10781(f_1251_10761_10768()) == PSLanguageMode.FullLanguage))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1251, 10700, 11046);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 10862, 10941);

                            oldLangModeTransitionStatus = f_1251_10892_10940(f_1251_10892_10899());
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 10967, 11023);

                            f_1251_10967_10974().LanguageModeTransitionInParameterBinding = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1251, 10700, 11046);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1251, 9924, 11065);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 11085, 11113);

                    f_1251_11085_11112(this);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1251, 11142, 11731);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 11182, 11411) || true) && (f_1251_11186_11210(oldLanguageMode))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1251, 11182, 11411);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 11347, 11392);

                        f_1251_11347_11354().LanguageMode = f_1251_11370_11391(oldLanguageMode);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1251, 11182, 11411);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 11431, 11716) || true) && (f_1251_11435_11471(oldLangModeTransitionStatus))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1251, 11431, 11716);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 11612, 11697);

                        f_1251_11612_11619().LanguageModeTransitionInParameterBinding = f_1251_11663_11696(oldLangModeTransitionStatus);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1251, 11431, 11716);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1251, 11142, 11731);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1251, 8546, 11742);

                System.Management.Automation.CmdletParameterBinderController
                f_1251_9432_9468(System.Management.Automation.CommandProcessor
                this_param)
                {
                    var return_v = this_param.CmdletParameterBinderController;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 9432, 9468);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1251_9572_9584(System.Management.Automation.CommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 9572, 9584);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1251_9661_9677(System.Management.Automation.CommandProcessor
                this_param)
                {
                    var return_v = this_param.CommandInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 9661, 9677);
                    return return_v;
                }


                string
                f_1251_9661_9682(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 9661, 9682);
                    return return_v;
                }


                int
                f_1251_9535_9683(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 9535, 9683);
                    return 0;
                }


                System.Management.Automation.CommandInfo
                f_1251_9867_9883(System.Management.Automation.CommandProcessor
                this_param)
                {
                    var return_v = this_param.CommandInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 9867, 9883);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1251_9977_10005(System.Management.Automation.IScriptCommandInfo
                this_param)
                {
                    var return_v = this_param.ScriptBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 9977, 10005);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode?
                f_1251_9977_10018(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 9977, 10018);
                    return return_v;
                }


                bool
                f_1251_9977_10027(System.Management.Automation.PSLanguageMode?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 9977, 10027);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1251_10052_10080(System.Management.Automation.IScriptCommandInfo
                this_param)
                {
                    var return_v = this_param.ScriptBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 10052, 10080);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode?
                f_1251_10052_10093(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 10052, 10093);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1251_10097_10104()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 10097, 10104);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1251_10097_10117(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 10097, 10117);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1251_10426_10433()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 10426, 10433);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1251_10426_10446(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 10426, 10446);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1251_10469_10476()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 10469, 10476);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1251_10492_10520(System.Management.Automation.IScriptCommandInfo
                this_param)
                {
                    var return_v = this_param.ScriptBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 10492, 10520);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode?
                f_1251_10492_10533(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 10492, 10533);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1251_10492_10539(System.Management.Automation.PSLanguageMode?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 10492, 10539);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1251_10761_10768()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 10761, 10768);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1251_10761_10781(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 10761, 10781);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1251_10892_10899()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 10892, 10899);
                    return return_v;
                }


                bool
                f_1251_10892_10940(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.LanguageModeTransitionInParameterBinding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 10892, 10940);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1251_10967_10974()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 10967, 10974);
                    return return_v;
                }


                int
                f_1251_11085_11112(System.Management.Automation.CommandProcessor
                this_param)
                {
                    this_param.BindCommandLineParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 11085, 11112);
                    return 0;
                }


                bool
                f_1251_11186_11210(System.Management.Automation.PSLanguageMode?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 11186, 11210);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1251_11347_11354()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 11347, 11354);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1251_11370_11391(System.Management.Automation.PSLanguageMode?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 11370, 11391);
                    return return_v;
                }


                bool
                f_1251_11435_11471(bool?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 11435, 11471);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1251_11612_11619()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 11612, 11619);
                    return return_v;
                }


                bool
                f_1251_11663_11696(bool?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 11663, 11696);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1251, 8546, 11742);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1251, 8546, 11742);
            }
        }

        protected override void OnSetCurrentScope()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1251, 11754, 12207);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 11967, 12028);

                PSScriptCmdlet
                scriptCmdlet = f_1251_11997_12009(this) as PSScriptCmdlet
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 12042, 12196) || true) && (scriptCmdlet != null && (DynAbs.Tracing.TraceSender.Expression_True(1251, 12046, 12084) && f_1251_12070_12084_M(!UseLocalScope)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1251, 12042, 12196);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 12118, 12181);

                    f_1251_12118_12180(scriptCmdlet, f_1251_12147_12179(f_1251_12147_12166()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1251, 12042, 12196);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1251, 11754, 12207);

                System.Management.Automation.Internal.InternalCommand
                f_1251_11997_12009(System.Management.Automation.CommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 11997, 12009);
                    return return_v;
                }


                bool
                f_1251_12070_12084_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 12070, 12084);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1251_12147_12166()
                {
                    var return_v = CommandSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 12147, 12166);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1251_12147_12179(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 12147, 12179);
                    return return_v;
                }


                int
                f_1251_12118_12180(System.Management.Automation.PSScriptCmdlet
                this_param, System.Management.Automation.SessionStateScope
                scope)
                {
                    this_param.PushDottedScope(scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 12118, 12180);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1251, 11754, 12207);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1251, 11754, 12207);
            }
        }

        protected override void OnRestorePreviousScope()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1251, 12219, 12677);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 12438, 12499);

                PSScriptCmdlet
                scriptCmdlet = f_1251_12468_12480(this) as PSScriptCmdlet
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 12513, 12666) || true) && (scriptCmdlet != null && (DynAbs.Tracing.TraceSender.Expression_True(1251, 12517, 12555) && f_1251_12541_12555_M(!UseLocalScope)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1251, 12513, 12666);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 12589, 12651);

                    f_1251_12589_12650(scriptCmdlet, f_1251_12617_12649(f_1251_12617_12636()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1251, 12513, 12666);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1251, 12219, 12677);

                System.Management.Automation.Internal.InternalCommand
                f_1251_12468_12480(System.Management.Automation.CommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 12468, 12480);
                    return return_v;
                }


                bool
                f_1251_12541_12555_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 12541, 12555);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1251_12617_12636()
                {
                    var return_v = CommandSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 12617, 12636);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1251_12617_12649(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 12617, 12649);
                    return return_v;
                }


                int
                f_1251_12589_12650(System.Management.Automation.PSScriptCmdlet
                this_param, System.Management.Automation.SessionStateScope
                scope)
                {
                    this_param.PopDottedScope(scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 12589, 12650);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1251, 12219, 12677);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1251, 12219, 12677);
            }
        }

        internal override void DoBegin()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1251, 12790, 13794);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 12847, 13752) || true) && (!RanBeginAlready && (DynAbs.Tracing.TraceSender.Expression_True(1251, 12851, 12939) && f_1251_12871_12931(f_1251_12871_12902()) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1251, 12847, 13752);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 12973, 13594);
                    using (f_1251_12980_13025(f_1251_12980_12994(), false))
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 13359, 13575);
                            foreach (WarningRecord warningRecord in f_1251_13399_13459_I(f_1251_13399_13459(f_1251_13399_13430())))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1251, 13359, 13575);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 13509, 13552);

                                f_1251_13509_13551(f_1251_13509_13523(), warningRecord);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1251, 13359, 13575);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1251, 1, 217);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1251, 1, 217);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitUsing(1251, 12973, 13594);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 13668, 13737);

                    f_1251_13668_13736(f_1251_13668_13728(f_1251_13668_13699()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1251, 12847, 13752);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 13768, 13783);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.DoBegin(), 1251, 13768, 13782);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1251, 12790, 13794);

                System.Management.Automation.CmdletParameterBinderController
                f_1251_12871_12902()
                {
                    var return_v = CmdletParameterBinderController;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 12871, 12902);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.WarningRecord>
                f_1251_12871_12931(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    var return_v = this_param.ObsoleteParameterWarningList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 12871, 12931);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1251_12980_12994()
                {
                    var return_v = CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 12980, 12994);
                    return return_v;
                }


                System.IDisposable
                f_1251_12980_13025(System.Management.Automation.MshCommandRuntime
                this_param, bool
                permittedToWriteToPipeline)
                {
                    var return_v = this_param.AllowThisCommandToWrite(permittedToWriteToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 12980, 13025);
                    return return_v;
                }


                System.Management.Automation.CmdletParameterBinderController
                f_1251_13399_13430()
                {
                    var return_v = CmdletParameterBinderController;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 13399, 13430);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.WarningRecord>
                f_1251_13399_13459(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    var return_v = this_param.ObsoleteParameterWarningList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 13399, 13459);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1251_13509_13523()
                {
                    var return_v = CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 13509, 13523);
                    return return_v;
                }


                int
                f_1251_13509_13551(System.Management.Automation.MshCommandRuntime
                this_param, System.Management.Automation.WarningRecord
                record)
                {
                    this_param.WriteWarning(record);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 13509, 13551);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.WarningRecord>
                f_1251_13399_13459_I(System.Collections.Generic.List<System.Management.Automation.WarningRecord>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 13399, 13459);
                    return return_v;
                }


                System.Management.Automation.CmdletParameterBinderController
                f_1251_13668_13699()
                {
                    var return_v = CmdletParameterBinderController;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 13668, 13699);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.WarningRecord>
                f_1251_13668_13728(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    var return_v = this_param.ObsoleteParameterWarningList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 13668, 13728);
                    return return_v;
                }


                int
                f_1251_13668_13736(System.Collections.Generic.List<System.Management.Automation.WarningRecord>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 13668, 13736);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1251, 12790, 13794);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1251, 12790, 13794);
            }
        }

        internal override void ProcessRecord()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1251, 14160, 19942);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 14291, 15307) || true) && (!this.RanBeginAlready)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1251, 14291, 15307);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 14350, 14373);

                    RanBeginAlready = true;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 14489, 14873);
                        using (f_1251_14496_14540(commandRuntime, true))
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 14590, 14794) || true) && (f_1251_14594_14601()._debuggingMode > 0 && (DynAbs.Tracing.TraceSender.Expression_True(1251, 14594, 14652) && !(f_1251_14626_14633() is PSScriptCmdlet)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1251, 14590, 14794);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 14710, 14767);

                                f_1251_14710_14766(f_1251_14710_14726(f_1251_14710_14717()), f_1251_14740_14765(f_1251_14740_14752(this)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1251, 14590, 14794);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 14822, 14850);

                            f_1251_14822_14849(f_1251_14822_14829());
                            DynAbs.Tracing.TraceSender.TraceExitUsing(1251, 14489, 14873);
                        }
                    }
                    // 2004/03/18-JonN This is understood to be
                    // an FXCOP violation, cleared by KCwalina.
                    catch (Exception e)  // Catch-all OK, 3rd party callout.
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1251, 15032, 15292);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 15238, 15273);

                        throw f_1251_15244_15272(this, e);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1251, 15032, 15292);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1251, 14291, 15307);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 15323, 15393);

                f_1251_15323_15392(f_1251_15336_15383(f_1251_15336_15361(f_1251_15336_15348(this))) != null);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 15474, 19931) || true) && (f_1251_15481_15487(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1251, 15474, 19931);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 15521, 15585);

                        Pipe
                        oldErrorOutputPipe = f_1251_15547_15584(_context)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 15603, 15637);

                        Exception
                        exceptionToThrow = null
                        ;
                        try
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 16840, 17075) || true) && (f_1251_16844_16877(this) || (DynAbs.Tracing.TraceSender.Expression_False(1251, 16844, 16926) || f_1251_16881_16918(_context) != null))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1251, 16840, 17075);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 16976, 17052);

                                _context.ShellFunctionErrorOutputPipe = f_1251_17016_17051(this.commandRuntime);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1251, 16840, 17075);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 17153, 18451);
                            using (f_1251_17160_17204(commandRuntime, true))
                            {

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 17254, 18252) || true) && (f_1251_17258_17318(f_1251_17258_17289()) != null && (DynAbs.Tracing.TraceSender.Expression_True(1251, 17258, 17429) && f_1251_17359_17425(f_1251_17359_17419(f_1251_17359_17390())) > 0))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1251, 17254, 18252);
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 17818, 18058);
                                        foreach (WarningRecord warningRecord in f_1251_17858_17918_I(f_1251_17858_17918(f_1251_17858_17889())))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1251, 17818, 18058);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 17984, 18027);

                                            f_1251_17984_18026(f_1251_17984_17998(), warningRecord);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1251, 17818, 18058);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1251, 1, 241);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(1251, 1, 241);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 18156, 18225);

                                    f_1251_18156_18224(f_1251_18156_18216(f_1251_18156_18187()));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1251, 17254, 18252);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 18280, 18374);

                                f_1251_18280_18327(f_1251_18280_18305(f_1251_18280_18292(this)))[f_1251_18328_18370(f_1251_18328_18353(f_1251_18328_18340(this)))]++;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 18402, 18428);

                                f_1251_18402_18427(f_1251_18402_18409());
                                DynAbs.Tracing.TraceSender.TraceExitUsing(1251, 17153, 18451);
                            }
                        }
                        catch (RuntimeException rte)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1251, 18488, 18923);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 18743, 18857) || true) && (f_1251_18747_18778(rte))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1251, 18743, 18857);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 18828, 18834);

                                throw;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1251, 18743, 18857);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 18881, 18904);

                            exceptionToThrow = rte;
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1251, 18488, 18923);
                        }
                        catch (LoopFlowException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1251, 18941, 19228);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 19203, 19209);

                            throw;
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1251, 18941, 19228);
                        }
                        // 2004/03/18-JonN This is understood to be
                        // an FXCOP violation, cleared by KCwalina.
                        catch (Exception e) // Catch-all OK, 3rd party callout.
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1251, 19368, 19504);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 19464, 19485);

                            exceptionToThrow = e;
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1251, 19368, 19504);
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinally(1251, 19522, 19648);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 19570, 19629);

                            _context.ShellFunctionErrorOutputPipe = oldErrorOutputPipe;
                            DynAbs.Tracing.TraceSender.TraceExitFinally(1251, 19522, 19648);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 19668, 19916) || true) && (exceptionToThrow != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1251, 19668, 19916);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 19847, 19897);

                            throw f_1251_19853_19896(this, exceptionToThrow);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1251, 19668, 19916);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1251, 15474, 19931);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1251, 15474, 19931);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1251, 15474, 19931);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1251, 14160, 19942);

                System.IDisposable
                f_1251_14496_14540(System.Management.Automation.MshCommandRuntime
                this_param, bool
                permittedToWriteToPipeline)
                {
                    var return_v = this_param.AllowThisCommandToWrite(permittedToWriteToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 14496, 14540);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1251_14594_14601()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 14594, 14601);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1251_14626_14633()
                {
                    var return_v = Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 14626, 14633);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1251_14710_14717()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 14710, 14717);
                    return return_v;
                }


                System.Management.Automation.ScriptDebugger
                f_1251_14710_14726(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Debugger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 14710, 14726);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1251_14740_14752(System.Management.Automation.CommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 14740, 14752);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1251_14740_14765(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 14740, 14765);
                    return return_v;
                }


                bool
                f_1251_14710_14766(System.Management.Automation.ScriptDebugger
                this_param, System.Management.Automation.InvocationInfo
                invocationInfo)
                {
                    var return_v = this_param.CheckCommand(invocationInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 14710, 14766);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1251_14822_14829()
                {
                    var return_v = Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 14822, 14829);
                    return return_v;
                }


                int
                f_1251_14822_14849(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    this_param.DoBeginProcessing();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 14822, 14849);
                    return 0;
                }


                System.Management.Automation.PipelineStoppedException
                f_1251_15244_15272(System.Management.Automation.CommandProcessor
                this_param, System.Exception
                e)
                {
                    var return_v = this_param.ManageInvocationException(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 15244, 15272);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1251_15336_15348(System.Management.Automation.CommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 15336, 15348);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1251_15336_15361(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 15336, 15361);
                    return return_v;
                }


                int[]
                f_1251_15336_15383(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.PipelineIterationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 15336, 15383);
                    return return_v;
                }


                int
                f_1251_15323_15392(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 15323, 15392);
                    return 0;
                }


                bool
                f_1251_15481_15487(System.Management.Automation.CommandProcessor
                this_param)
                {
                    var return_v = this_param.Read();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 15481, 15487);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1251_15547_15584(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ShellFunctionErrorOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 15547, 15584);
                    return return_v;
                }


                bool
                f_1251_16844_16877(System.Management.Automation.CommandProcessor
                this_param)
                {
                    var return_v = this_param.RedirectShellErrorOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 16844, 16877);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1251_16881_16918(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ShellFunctionErrorOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 16881, 16918);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1251_17016_17051(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.ErrorOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 17016, 17051);
                    return return_v;
                }


                System.IDisposable
                f_1251_17160_17204(System.Management.Automation.MshCommandRuntime
                this_param, bool
                permittedToWriteToPipeline)
                {
                    var return_v = this_param.AllowThisCommandToWrite(permittedToWriteToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 17160, 17204);
                    return return_v;
                }


                System.Management.Automation.CmdletParameterBinderController
                f_1251_17258_17289()
                {
                    var return_v = CmdletParameterBinderController;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 17258, 17289);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.WarningRecord>
                f_1251_17258_17318(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    var return_v = this_param.ObsoleteParameterWarningList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 17258, 17318);
                    return return_v;
                }


                System.Management.Automation.CmdletParameterBinderController
                f_1251_17359_17390()
                {
                    var return_v = CmdletParameterBinderController;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 17359, 17390);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.WarningRecord>
                f_1251_17359_17419(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    var return_v = this_param.ObsoleteParameterWarningList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 17359, 17419);
                    return return_v;
                }


                int
                f_1251_17359_17425(System.Collections.Generic.List<System.Management.Automation.WarningRecord>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 17359, 17425);
                    return return_v;
                }


                System.Management.Automation.CmdletParameterBinderController
                f_1251_17858_17889()
                {
                    var return_v = CmdletParameterBinderController;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 17858, 17889);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.WarningRecord>
                f_1251_17858_17918(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    var return_v = this_param.ObsoleteParameterWarningList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 17858, 17918);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1251_17984_17998()
                {
                    var return_v = CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 17984, 17998);
                    return return_v;
                }


                int
                f_1251_17984_18026(System.Management.Automation.MshCommandRuntime
                this_param, System.Management.Automation.WarningRecord
                record)
                {
                    this_param.WriteWarning(record);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 17984, 18026);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.WarningRecord>
                f_1251_17858_17918_I(System.Collections.Generic.List<System.Management.Automation.WarningRecord>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 17858, 17918);
                    return return_v;
                }


                System.Management.Automation.CmdletParameterBinderController
                f_1251_18156_18187()
                {
                    var return_v = CmdletParameterBinderController;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 18156, 18187);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.WarningRecord>
                f_1251_18156_18216(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    var return_v = this_param.ObsoleteParameterWarningList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 18156, 18216);
                    return return_v;
                }


                int
                f_1251_18156_18224(System.Collections.Generic.List<System.Management.Automation.WarningRecord>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 18156, 18224);
                    return 0;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1251_18280_18292(System.Management.Automation.CommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 18280, 18292);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1251_18280_18305(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 18280, 18305);
                    return return_v;
                }


                int[]
                f_1251_18280_18327(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.PipelineIterationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 18280, 18327);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1251_18328_18340(System.Management.Automation.CommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 18328, 18340);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1251_18328_18353(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 18328, 18353);
                    return return_v;
                }


                int
                f_1251_18328_18370(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.PipelinePosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 18328, 18370);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1251_18402_18409()
                {
                    var return_v = Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 18402, 18409);
                    return return_v;
                }


                int
                f_1251_18402_18427(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    this_param.DoProcessRecord();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 18402, 18427);
                    return 0;
                }


                bool
                f_1251_18747_18778(System.Management.Automation.RuntimeException
                this_param)
                {
                    var return_v = this_param.WasThrownFromThrowStatement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 18747, 18778);
                    return return_v;
                }


                System.Management.Automation.PipelineStoppedException
                f_1251_19853_19896(System.Management.Automation.CommandProcessor
                this_param, System.Exception
                e)
                {
                    var return_v = this_param.ManageInvocationException(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 19853, 19896);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1251, 14160, 19942);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1251, 14160, 19942);
            }
        }

        private bool _firstCallToRead;

        private bool _bailInNextCall;

        internal sealed override bool Read()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1251, 20923, 27169);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 22385, 22436) || true) && (_bailInNextCall)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1251, 22385, 22436);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 22423, 22436);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1251, 22385, 22436);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 22743, 22769);

                f_1251_22743_22768(f_1251_22743_22750());

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 22876, 23378) || true) && (_firstCallToRead)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1251, 22876, 23378);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 22930, 22955);

                    _firstCallToRead = false;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 22973, 23363) || true) && (!f_1251_22978_23003(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1251, 22973, 23363);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 23287, 23310);

                        _bailInNextCall = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 23332, 23344);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1251, 22973, 23363);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1251, 22876, 23378);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 23687, 23729);

                bool
                mandatoryParametersSpecified = false
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 23745, 27130) || true) && (!mandatoryParametersSpecified)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1251, 23745, 27130);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 23879, 23941);

                        object
                        inputObject = f_1251_23900_23940(f_1251_23900_23929(this.commandRuntime))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 23961, 24197) || true) && (inputObject == f_1251_23980_24000())
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1251, 23961, 24197);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 24106, 24143);

                            f_1251_24106_24113().CurrentPipelineObject = null;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 24165, 24178);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1251, 23961, 24197);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 24384, 24549) || true) && (f_1251_24388_24430(f_1251_24388_24413(f_1251_24388_24400(this))) == 1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1251, 24384, 24549);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 24477, 24530);

                            f_1251_24477_24524(f_1251_24477_24502(f_1251_24477_24489(this)))[0]++;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1251, 24384, 24549);
                        }

                        try
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 24671, 25240) || true) && (false == f_1251_24684_24723(this, inputObject))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1251, 24671, 25240);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 24992, 25182);

                                f_1251_24992_25181(this, inputObject, f_1251_25086_25128(), "InputObjectNotBound");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 25208, 25217);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1251, 24671, 25240);
                            }
                        }
                        catch (ParameterBindingException bindingError)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1251, 25277, 25800);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 25423, 25477);

                            f_1251_25423_25476(f_1251_25423_25447(bindingError), inputObject);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 25501, 25667);

                            ErrorRecord
                            errorRecord =
                            f_1251_25552_25666(f_1251_25598_25622(bindingError), bindingError)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 25691, 25750);

                            f_1251_25691_25749(
                                                this.commandRuntime, errorRecord);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 25772, 25781);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1251, 25277, 25800);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 25820, 25890);

                        Collection<MergedCompiledCommandParameter>
                        missingMandatoryParameters
                        = default(Collection<MergedCompiledCommandParameter>);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 25910, 26371);
                        using (f_1251_25917_26072(ParameterBinderBase.bindingTracer, "MANDATORY PARAMETER CHECK on cmdlet [{0}]", f_1251_26050_26071(f_1251_26050_26066(this))))
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 26194, 26352);

                            mandatoryParametersSpecified =
                            f_1251_26250_26351(f_1251_26250_26286(this), out missingMandatoryParameters);
                            DynAbs.Tracing.TraceSender.TraceExitUsing(1251, 25910, 26371);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 26391, 27115) || true) && (!mandatoryParametersSpecified)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1251, 26391, 27115);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 26466, 26603);

                            string
                            missingParameters =
                            f_1251_26518_26602(missingMandatoryParameters)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 26858, 27096);

                            f_1251_26858_27095(this, inputObject, f_1251_26944_26994(), "InputObjectMissingMandatory", missingParameters);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1251, 26391, 27115);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1251, 23745, 27130);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1251, 23745, 27130);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1251, 23745, 27130);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 27146, 27158);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1251, 20923, 27169);

                System.Management.Automation.Internal.InternalCommand
                f_1251_22743_22750()
                {
                    var return_v = Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 22743, 22750);
                    return return_v;
                }


                int
                f_1251_22743_22768(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    this_param.ThrowIfStopping();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 22743, 22768);
                    return 0;
                }


                bool
                f_1251_22978_23003(System.Management.Automation.CommandProcessor
                this_param)
                {
                    var return_v = this_param.IsPipelineInputExpected();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 22978, 23003);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1251_23900_23929(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.InputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 23900, 23929);
                    return return_v;
                }


                object
                f_1251_23900_23940(System.Management.Automation.Internal.Pipe
                this_param)
                {
                    var return_v = this_param.Retrieve();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 23900, 23940);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1251_23980_24000()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 23980, 24000);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1251_24106_24113()
                {
                    var return_v = Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 24106, 24113);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1251_24388_24400(System.Management.Automation.CommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 24388, 24400);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1251_24388_24413(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 24388, 24413);
                    return return_v;
                }


                int
                f_1251_24388_24430(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.PipelinePosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 24388, 24430);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1251_24477_24489(System.Management.Automation.CommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 24477, 24489);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1251_24477_24502(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 24477, 24502);
                    return return_v;
                }


                int[]
                f_1251_24477_24524(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.PipelineIterationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 24477, 24524);
                    return return_v;
                }


                bool
                f_1251_24684_24723(System.Management.Automation.CommandProcessor
                this_param, object
                inputObject)
                {
                    var return_v = this_param.ProcessInputPipelineObject(inputObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 24684, 24723);
                    return return_v;
                }


                string
                f_1251_25086_25128()
                {
                    var return_v = ParameterBinderStrings.InputObjectNotBound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 25086, 25128);
                    return return_v;
                }


                int
                f_1251_24992_25181(System.Management.Automation.CommandProcessor
                this_param, object
                inputObject, string
                resourceString, string
                errorId, params object[]
                args)
                {
                    this_param.WriteInputObjectError(inputObject, resourceString, errorId, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 24992, 25181);
                    return 0;
                }


                System.Management.Automation.ErrorRecord
                f_1251_25423_25447(System.Management.Automation.ParameterBindingException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 25423, 25447);
                    return return_v;
                }


                int
                f_1251_25423_25476(System.Management.Automation.ErrorRecord
                this_param, object
                target)
                {
                    this_param.SetTargetObject(target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 25423, 25476);
                    return 0;
                }


                System.Management.Automation.ErrorRecord
                f_1251_25598_25622(System.Management.Automation.ParameterBindingException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 25598, 25622);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1251_25552_25666(System.Management.Automation.ErrorRecord
                errorRecord, System.Management.Automation.ParameterBindingException
                replaceParentContainsErrorRecordException)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(errorRecord, (System.Exception)replaceParentContainsErrorRecordException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 25552, 25666);
                    return return_v;
                }


                int
                f_1251_25691_25749(System.Management.Automation.MshCommandRuntime
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param._WriteErrorSkipAllowCheck(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 25691, 25749);
                    return 0;
                }


                System.Management.Automation.CommandInfo
                f_1251_26050_26066(System.Management.Automation.CommandProcessor
                this_param)
                {
                    var return_v = this_param.CommandInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 26050, 26066);
                    return return_v;
                }


                string
                f_1251_26050_26071(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 26050, 26071);
                    return return_v;
                }


                System.IDisposable
                f_1251_25917_26072(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    var return_v = this_param.TraceScope(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 25917, 26072);
                    return return_v;
                }


                System.Management.Automation.CmdletParameterBinderController
                f_1251_26250_26286(System.Management.Automation.CommandProcessor
                this_param)
                {
                    var return_v = this_param.CmdletParameterBinderController;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 26250, 26286);
                    return return_v;
                }


                bool
                f_1251_26250_26351(System.Management.Automation.CmdletParameterBinderController
                this_param, out System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                missingMandatoryParameters)
                {
                    var return_v = this_param.HandleUnboundMandatoryParameters(out missingMandatoryParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 26250, 26351);
                    return return_v;
                }


                string
                f_1251_26518_26602(System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                missingMandatoryParameters)
                {
                    var return_v = CmdletParameterBinderController.BuildMissingParamsString(missingMandatoryParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 26518, 26602);
                    return return_v;
                }


                string
                f_1251_26944_26994()
                {
                    var return_v = ParameterBinderStrings.InputObjectMissingMandatory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 26944, 26994);
                    return return_v;
                }


                int
                f_1251_26858_27095(System.Management.Automation.CommandProcessor
                this_param, object
                inputObject, string
                resourceString, string
                errorId, params object[]
                args)
                {
                    this_param.WriteInputObjectError(inputObject, resourceString, errorId, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 26858, 27095);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1251, 20923, 27169);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1251, 20923, 27169);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void WriteInputObjectError(
                    object inputObject,
                    string resourceString,
                    string errorId,
                    params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1251, 27935, 28963);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 28128, 28204);

                Type
                inputObjectType = (DynAbs.Tracing.TraceSender.Conditional_F1(1251, 28151, 28172) || (((inputObject == null) && DynAbs.Tracing.TraceSender.Conditional_F2(1251, 28175, 28179)) || DynAbs.Tracing.TraceSender.Conditional_F3(1251, 28182, 28203))) ? null : f_1251_28182_28203(inputObject)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 28220, 28573);

                ParameterBindingException
                bindingException = f_1251_28265_28572(ErrorCategory.InvalidArgument, f_1251_28361_28386(f_1251_28361_28373(this)), null, null, null, inputObjectType, resourceString, errorId, args)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 28589, 28804);

                ErrorRecord
                errorRecord =
                f_1251_28632_28803(bindingException, errorId, ErrorCategory.InvalidArgument, inputObject)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 28820, 28877);

                f_1251_28820_28876(
                            errorRecord, f_1251_28850_28875(f_1251_28850_28862(this)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 28893, 28952);

                f_1251_28893_28951(
                            this.commandRuntime, errorRecord);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1251, 27935, 28963);

                System.Type
                f_1251_28182_28203(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 28182, 28203);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1251_28361_28373(System.Management.Automation.CommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 28361, 28373);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1251_28361_28386(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 28361, 28386);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingException
                f_1251_28265_28572(System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.InvocationInfo
                invocationInfo, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                parameterName, System.Type
                parameterType, System.Type
                typeSpecified, string
                resourceString, string
                errorId, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.ParameterBindingException(errorCategory, invocationInfo, errorPosition, parameterName, parameterType, typeSpecified, resourceString, errorId, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 28265, 28572);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1251_28632_28803(System.Management.Automation.ParameterBindingException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 28632, 28803);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1251_28850_28862(System.Management.Automation.CommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 28850, 28862);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1251_28850_28875(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 28850, 28875);
                    return return_v;
                }


                int
                f_1251_28820_28876(System.Management.Automation.ErrorRecord
                this_param, System.Management.Automation.InvocationInfo
                invocationInfo)
                {
                    this_param.SetInvocationInfo(invocationInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 28820, 28876);
                    return 0;
                }


                int
                f_1251_28893_28951(System.Management.Automation.MshCommandRuntime
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param._WriteErrorSkipAllowCheck(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 28893, 28951);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1251, 27935, 28963);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1251, 27935, 28963);
            }
        }

        private bool ProcessInputPipelineObject(object inputObject)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1251, 29664, 30384);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 29748, 29781);

                PSObject
                inputToOperateOn = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 30083, 30207) || true) && (inputObject != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1251, 30083, 30207);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 30140, 30192);

                    inputToOperateOn = f_1251_30159_30191(inputObject);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1251, 30083, 30207);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 30223, 30272);

                f_1251_30223_30230().CurrentPipelineObject = inputToOperateOn;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 30288, 30373);

                return f_1251_30295_30372(f_1251_30295_30331(this), inputToOperateOn);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1251, 29664, 30384);

                System.Management.Automation.PSObject
                f_1251_30159_30191(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 30159, 30191);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1251_30223_30230()
                {
                    var return_v = Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 30223, 30230);
                    return return_v;
                }


                System.Management.Automation.CmdletParameterBinderController
                f_1251_30295_30331(System.Management.Automation.CommandProcessor
                this_param)
                {
                    var return_v = this_param.CmdletParameterBinderController;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 30295, 30331);
                    return return_v;
                }


                bool
                f_1251_30295_30372(System.Management.Automation.CmdletParameterBinderController
                this_param, System.Management.Automation.PSObject
                inputToOperateOn)
                {
                    var return_v = this_param.BindPipelineParameters(inputToOperateOn);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 30295, 30372);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1251, 29664, 30384);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1251, 29664, 30384);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly ConcurrentDictionary<Type, Func<Cmdlet>> s_constructInstanceCache;

        private static Cmdlet ConstructInstance(Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1251, 30496, 31186);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 30876, 31175);

                // LAFHIS
                //return f_1251_30883_31174(f_1251_30883_31172(s_constructInstanceCache, type, t => Expression.Lambda<Func<Cmdlet>>(
                //                     typeof(Cmdlet).IsAssignableFrom(t)
                //                        ? (Expression)Expression.New(t)
                //                        : Expression.Constant(null, typeof(Cmdlet))).Compile())());

                var temp = f_1251_30883_31172(s_constructInstanceCache, type, t => Expression.Lambda<Func<Cmdlet>>(
                                     typeof(Cmdlet).IsAssignableFrom(t)
                                        ? (Expression)Expression.New(t)
                                        : Expression.Constant(null, typeof(Cmdlet))).Compile())();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 30883, 31174);
                return temp;

                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1251, 30496, 31186);

                System.Func<System.Management.Automation.Cmdlet>
                f_1251_30883_31172(System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Func<System.Management.Automation.Cmdlet>>
                this_param, System.Type
                key, System.Func<System.Type, System.Func<System.Management.Automation.Cmdlet>>
                valueFactory)
                {
                    var return_v = this_param.GetOrAdd(key, valueFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 30883, 31172);
                    return return_v;
                }


                //System.Func<System.Management.Automation.Cmdlet>
                //f_1251_30883_31174(System.Func<System.Management.Automation.Cmdlet>
                //this_param)
                //{
                //    var return_v = this_param.Invoke();
                //    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 30883, 31174);
                //    return return_v;
                //}

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1251, 30496, 31186);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1251, 30496, 31186);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void Init(CmdletInfo cmdletInformation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1251, 31980, 34693);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 32052, 32168);

                f_1251_32052_32167(cmdletInformation != null, "Constructor should throw exception if LookupCommand returned null.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 32184, 32208);

                Cmdlet
                newCmdlet = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 32222, 32249);

                Exception
                initError = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 32263, 32298);

                string
                errorIdAndResourceId = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 32312, 32338);

                string
                resourceStr = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 32434, 32500);

                    newCmdlet = f_1251_32446_32499(f_1251_32464_32498(cmdletInformation));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 32518, 32969) || true) && (newCmdlet == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1251, 32518, 32969);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 32740, 32779);

                        initError = f_1251_32752_32778();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 32801, 32860);

                        errorIdAndResourceId = "CmdletDoesNotDeriveFromCmdletType";
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 32882, 32950);

                        resourceStr = f_1251_32896_32949();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1251, 32518, 32969);
                    }
                }
                catch (MemberAccessException memberAccessException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1251, 32998, 33131);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 33082, 33116);

                    initError = memberAccessException;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1251, 32998, 33131);
                }
                catch (TypeLoadException typeLoadException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1251, 33145, 33266);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 33221, 33251);

                    initError = typeLoadException;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1251, 33145, 33266);
                }
                catch (Exception e) // Catch-all OK, 3rd party callout.
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1251, 33280, 33836);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 33505, 33567);

                    var
                    commandException = f_1251_33528_33566(e, null)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 33634, 33778);

                    f_1251_33634_33777(this._context, commandException, Severity.Warning);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 33798, 33821);

                    throw commandException;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1251, 33280, 33836);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 33852, 34538) || true) && (initError != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1251, 33852, 34538);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 33954, 34091);

                    f_1251_33954_34090(this._context, initError, Severity.Warning);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 34111, 34489);

                    CommandNotFoundException
                    exception =
                    f_1251_34169_34488(f_1251_34224_34246(cmdletInformation), initError, errorIdAndResourceId ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1251, 34309, 34358) ?? "CmdletNotFoundException"), resourceStr ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1251, 34385, 34443) ?? f_1251_34400_34443()), f_1251_34470_34487(initError))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 34507, 34523);

                    throw exception;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1251, 33852, 34538);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 34554, 34579);

                this.Command = newCmdlet;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 34593, 34653);

                this.CommandScope = f_1251_34613_34652(f_1251_34613_34639(f_1251_34613_34620()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 34669, 34682);

                f_1251_34669_34681(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1251, 31980, 34693);

                int
                f_1251_32052_32167(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 32052, 32167);
                    return 0;
                }


                System.Type
                f_1251_32464_32498(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.ImplementingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 32464, 32498);
                    return return_v;
                }


                System.Management.Automation.Cmdlet
                f_1251_32446_32499(System.Type
                type)
                {
                    var return_v = ConstructInstance(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 32446, 32499);
                    return return_v;
                }


                System.InvalidCastException
                f_1251_32752_32778()
                {
                    var return_v = new System.InvalidCastException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 32752, 32778);
                    return return_v;
                }


                string
                f_1251_32896_32949()
                {
                    var return_v = DiscoveryExceptions.CmdletDoesNotDeriveFromCmdletType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 32896, 32949);
                    return return_v;
                }


                System.Management.Automation.CmdletInvocationException
                f_1251_33528_33566(System.Exception
                innerException, System.Management.Automation.InvocationInfo
                invocationInfo)
                {
                    var return_v = new System.Management.Automation.CmdletInvocationException(innerException, invocationInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 33528, 33566);
                    return return_v;
                }


                int
                f_1251_33634_33777(System.Management.Automation.ExecutionContext
                executionContext, System.Management.Automation.CmdletInvocationException
                exception, System.Management.Automation.Severity
                severity)
                {
                    MshLog.LogCommandHealthEvent(executionContext, (System.Exception)exception, severity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 33634, 33777);
                    return 0;
                }


                int
                f_1251_33954_34090(System.Management.Automation.ExecutionContext
                executionContext, System.Exception
                exception, System.Management.Automation.Severity
                severity)
                {
                    MshLog.LogCommandHealthEvent(executionContext, exception, severity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 33954, 34090);
                    return 0;
                }


                string
                f_1251_34224_34246(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 34224, 34246);
                    return return_v;
                }


                string
                f_1251_34400_34443()
                {
                    var return_v = DiscoveryExceptions.CmdletNotFoundException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 34400, 34443);
                    return return_v;
                }


                string
                f_1251_34470_34487(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 34470, 34487);
                    return return_v;
                }


                System.Management.Automation.CommandNotFoundException
                f_1251_34169_34488(string
                commandName, System.Exception
                innerException, string
                errorIdAndResourceId, string
                resourceStr, params object[]
                messageArgs)
                {
                    var return_v = new System.Management.Automation.CommandNotFoundException(commandName, innerException, errorIdAndResourceId, resourceStr, messageArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 34169, 34488);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1251_34613_34620()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 34613, 34620);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1251_34613_34639(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 34613, 34639);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1251_34613_34652(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 34613, 34652);
                    return return_v;
                }


                int
                f_1251_34669_34681(System.Management.Automation.CommandProcessor
                this_param)
                {
                    this_param.InitCommon();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 34669, 34681);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1251, 31980, 34693);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1251, 31980, 34693);
            }
        }

        private void Init(IScriptCommandInfo scriptCommandInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1251, 34705, 35711);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 34785, 34895);

                var
                scriptCmdlet = f_1251_34804_34894(f_1251_34823_34852(scriptCommandInfo), f_1251_34854_34867(), f_1251_34869_34883(), _context)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 34909, 34937);

                this.Command = scriptCmdlet;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 34951, 35152);

                this.CommandScope = (DynAbs.Tracing.TraceSender.Conditional_F1(1251, 34971, 34984) || ((f_1251_34971_34984() && DynAbs.Tracing.TraceSender.Conditional_F2(1251, 35024, 35074)) || DynAbs.Tracing.TraceSender.Conditional_F3(1251, 35114, 35151))) ? f_1251_35024_35074(f_1251_35024_35048(this), _fromScriptFile) : f_1251_35114_35151(f_1251_35114_35138(this));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 35168, 35374) || true) && (f_1251_35172_35185())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1251, 35168, 35374);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 35306, 35359);

                    f_1251_35306_35358(                // Set the 'LocalsTuple' of the new scope to that of the scriptCmdlet
                                    scriptCmdlet, f_1251_35345_35357());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1251, 35168, 35374);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 35390, 35403);

                f_1251_35390_35402(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 35521, 35700) || true) && (f_1251_35525_35544_M(!this.UseLocalScope))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1251, 35521, 35700);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 35578, 35685);

                    f_1251_35578_35684(f_1251_35609_35638(scriptCommandInfo), f_1251_35640_35661(_context), f_1251_35663_35683(f_1251_35663_35670()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1251, 35521, 35700);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1251, 34705, 35711);

                System.Management.Automation.ScriptBlock
                f_1251_34823_34852(System.Management.Automation.IScriptCommandInfo
                this_param)
                {
                    var return_v = this_param.ScriptBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 34823, 34852);
                    return return_v;
                }


                bool
                f_1251_34854_34867()
                {
                    var return_v = UseLocalScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 34854, 34867);
                    return return_v;
                }


                bool
                f_1251_34869_34883()
                {
                    var return_v = FromScriptFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 34869, 34883);
                    return return_v;
                }


                System.Management.Automation.PSScriptCmdlet
                f_1251_34804_34894(System.Management.Automation.ScriptBlock
                scriptBlock, bool
                useNewScope, bool
                fromScriptFile, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new System.Management.Automation.PSScriptCmdlet(scriptBlock, useNewScope, fromScriptFile, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 34804, 34894);
                    return return_v;
                }


                bool
                f_1251_34971_34984()
                {
                    var return_v = UseLocalScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 34971, 34984);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1251_35024_35048(System.Management.Automation.CommandProcessor
                this_param)
                {
                    var return_v = this_param.CommandSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 35024, 35048);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1251_35024_35074(System.Management.Automation.SessionStateInternal
                this_param, bool
                isScriptScope)
                {
                    var return_v = this_param.NewScope(isScriptScope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 35024, 35074);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1251_35114_35138(System.Management.Automation.CommandProcessor
                this_param)
                {
                    var return_v = this_param.CommandSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 35114, 35138);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1251_35114_35151(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 35114, 35151);
                    return return_v;
                }


                bool
                f_1251_35172_35185()
                {
                    var return_v = UseLocalScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 35172, 35185);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1251_35345_35357()
                {
                    var return_v = CommandScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 35345, 35357);
                    return return_v;
                }


                int
                f_1251_35306_35358(System.Management.Automation.PSScriptCmdlet
                this_param, System.Management.Automation.SessionStateScope
                scope)
                {
                    this_param.SetLocalsTupleForNewScope(scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 35306, 35358);
                    return 0;
                }


                int
                f_1251_35390_35402(System.Management.Automation.CommandProcessor
                this_param)
                {
                    this_param.InitCommon();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 35390, 35402);
                    return 0;
                }


                bool
                f_1251_35525_35544_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 35525, 35544);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1251_35609_35638(System.Management.Automation.IScriptCommandInfo
                this_param)
                {
                    var return_v = this_param.ScriptBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 35609, 35638);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1251_35640_35661(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 35640, 35661);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1251_35663_35670()
                {
                    var return_v = Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 35663, 35670);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1251_35663_35683(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 35663, 35683);
                    return return_v;
                }


                int
                f_1251_35578_35684(System.Management.Automation.ScriptBlock
                scriptBlock, System.Management.Automation.PSLanguageMode
                languageMode, System.Management.Automation.InvocationInfo
                invocationInfo)
                {
                    ValidateCompatibleLanguageMode(scriptBlock, languageMode, invocationInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 35578, 35684);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1251, 34705, 35711);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1251, 34705, 35711);
            }
        }

        private void InitCommon()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1251, 35723, 36707);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 35806, 35850);

                f_1251_35806_35818(this).CommandInfo = f_1251_35833_35849(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 35931, 35994);

                _obsoleteAttribute = f_1251_35952_35993(f_1251_35952_35984(f_1251_35952_35968(this)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 36052, 36089);

                f_1251_36052_36064(this).Context = this._context;

                // Now set up the command runtime for this command.
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 36206, 36292);

                    this.commandRuntime = f_1251_36228_36291(_context, f_1251_36260_36276(this), f_1251_36278_36290(this));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 36310, 36360);

                    f_1251_36310_36322(this).commandRuntime = this.commandRuntime;
                }
                catch (Exception e) // Catch-all OK, 3rd party callout.
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1251, 36389, 36696);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 36526, 36655);

                    f_1251_36526_36654(this._context, e, Severity.Warning);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 36675, 36681);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1251, 36389, 36696);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1251, 35723, 36707);

                System.Management.Automation.Internal.InternalCommand
                f_1251_35806_35818(System.Management.Automation.CommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 35806, 35818);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1251_35833_35849(System.Management.Automation.CommandProcessor
                this_param)
                {
                    var return_v = this_param.CommandInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 35833, 35849);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1251_35952_35968(System.Management.Automation.CommandProcessor
                this_param)
                {
                    var return_v = this_param.CommandInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 35952, 35968);
                    return return_v;
                }


                System.Management.Automation.CommandMetadata
                f_1251_35952_35984(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.CommandMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 35952, 35984);
                    return return_v;
                }


                System.ObsoleteAttribute
                f_1251_35952_35993(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.Obsolete;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 35952, 35993);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1251_36052_36064(System.Management.Automation.CommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 36052, 36064);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1251_36260_36276(System.Management.Automation.CommandProcessor
                this_param)
                {
                    var return_v = this_param.CommandInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 36260, 36276);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1251_36278_36290(System.Management.Automation.CommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 36278, 36290);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1251_36228_36291(System.Management.Automation.ExecutionContext
                context, System.Management.Automation.CommandInfo
                commandInfo, System.Management.Automation.Internal.InternalCommand
                thisCommand)
                {
                    var return_v = new System.Management.Automation.MshCommandRuntime(context, commandInfo, thisCommand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 36228, 36291);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1251_36310_36322(System.Management.Automation.CommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 36310, 36322);
                    return return_v;
                }


                int
                f_1251_36526_36654(System.Management.Automation.ExecutionContext
                executionContext, System.Exception
                exception, System.Management.Automation.Severity
                severity)
                {
                    MshLog.LogCommandHealthEvent(executionContext, exception, severity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 36526, 36654);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1251, 35723, 36707);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1251, 35723, 36707);
            }
        }

        internal override bool IsHelpRequested(out string helpTarget, out HelpCategory helpCategory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1251, 37165, 39450);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 37282, 39361) || true) && (this.arguments != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1251, 37282, 39361);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 37342, 39346);
                        foreach (CommandParameterInternal parameter in f_1251_37389_37403_I(this.arguments))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1251, 37342, 39346);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 37445, 37539);

                            f_1251_37445_37538(parameter != null, "CommandProcessor.arguments shouldn't have any null arguments");

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 37561, 39327) || true) && (f_1251_37565_37591(parameter))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1251, 37561, 39327);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 37641, 37673);

                                helpCategory = HelpCategory.All;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 37985, 39264) || true) && ((f_1251_37990_38002(this) != null) && (DynAbs.Tracing.TraceSender.Expression_True(1251, 37989, 38050) && (f_1251_38016_38041(f_1251_38016_38028(this)) != null)) && (DynAbs.Tracing.TraceSender.Expression_True(1251, 37989, 38148) && (!f_1251_38085_38147(f_1251_38106_38146(f_1251_38106_38131(f_1251_38106_38118(this)))))))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1251, 37985, 39264);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 38206, 38260);

                                    helpTarget = f_1251_38219_38259(f_1251_38219_38244(f_1251_38219_38231(this)));

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 38753, 39013) || true) && (f_1251_38757_38871(f_1251_38771_38811(f_1251_38771_38796(f_1251_38771_38783(this))), f_1251_38813_38834(f_1251_38813_38829(this)), StringComparison.OrdinalIgnoreCase))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1251, 38753, 39013);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 38937, 38982);

                                        helpCategory = f_1251_38952_38981(f_1251_38952_38968(this));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1251, 38753, 39013);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1251, 37985, 39264);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1251, 37985, 39264);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 39127, 39162);

                                    helpTarget = f_1251_39140_39161(f_1251_39140_39156(this));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 39192, 39237);

                                    helpCategory = f_1251_39207_39236(f_1251_39207_39223(this));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1251, 37985, 39264);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 39292, 39304);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1251, 37561, 39327);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1251, 37342, 39346);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1251, 1, 2005);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1251, 1, 2005);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1251, 37282, 39361);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1251, 39377, 39439);

                // LAFHIS
                //return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.IsHelpRequested(out helpTarget, out helpCategory), 1251, 39384, 39438);

                var temp = base.IsHelpRequested(out helpTarget, out helpCategory);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 39384, 39438);
                return temp;

                DynAbs.Tracing.TraceSender.TraceExitMethod(1251, 37165, 39450);

                int
                f_1251_37445_37538(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 37445, 37538);
                    return 0;
                }


                bool
                f_1251_37565_37591(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.IsDashQuestion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 37565, 37591);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1251_37990_38002(System.Management.Automation.CommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 37990, 38002);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1251_38016_38028(System.Management.Automation.CommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 38016, 38028);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1251_38016_38041(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 38016, 38041);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1251_38106_38118(System.Management.Automation.CommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 38106, 38118);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1251_38106_38131(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 38106, 38131);
                    return return_v;
                }


                string
                f_1251_38106_38146(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.InvocationName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 38106, 38146);
                    return return_v;
                }


                bool
                f_1251_38085_38147(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 38085, 38147);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1251_38219_38231(System.Management.Automation.CommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 38219, 38231);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1251_38219_38244(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 38219, 38244);
                    return return_v;
                }


                string
                f_1251_38219_38259(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.InvocationName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 38219, 38259);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1251_38771_38783(System.Management.Automation.CommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 38771, 38783);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1251_38771_38796(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 38771, 38796);
                    return return_v;
                }


                string
                f_1251_38771_38811(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.InvocationName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 38771, 38811);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1251_38813_38829(System.Management.Automation.CommandProcessor
                this_param)
                {
                    var return_v = this_param.CommandInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 38813, 38829);
                    return return_v;
                }


                string
                f_1251_38813_38834(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 38813, 38834);
                    return return_v;
                }


                bool
                f_1251_38757_38871(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 38757, 38871);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1251_38952_38968(System.Management.Automation.CommandProcessor
                this_param)
                {
                    var return_v = this_param.CommandInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 38952, 38968);
                    return return_v;
                }


                System.Management.Automation.HelpCategory
                f_1251_38952_38981(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.HelpCategory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 38952, 38981);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1251_39140_39156(System.Management.Automation.CommandProcessor
                this_param)
                {
                    var return_v = this_param.CommandInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 39140, 39156);
                    return return_v;
                }


                string
                f_1251_39140_39161(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 39140, 39161);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1251_39207_39223(System.Management.Automation.CommandProcessor
                this_param)
                {
                    var return_v = this_param.CommandInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 39207, 39223);
                    return return_v;
                }


                System.Management.Automation.HelpCategory
                f_1251_39207_39236(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.HelpCategory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1251, 39207, 39236);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                f_1251_37389_37403_I(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 37389, 37403);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1251, 37165, 39450);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1251, 37165, 39450);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1251, 648, 39494);

        static System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Func<System.Management.Automation.Cmdlet>>
        f_1251_820_866()
        {
            var return_v = new System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Func<System.Management.Automation.Cmdlet>>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 820, 866);
            return return_v;
        }


        static System.Func<System.Management.Automation.Cmdlet>
        f_1251_1107_1204(System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Func<System.Management.Automation.Cmdlet>>
        this_param, System.Type
        key, System.Func<System.Management.Automation.Cmdlet>
        value)
        {
            var return_v = this_param.GetOrAdd(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 1107, 1204);
            return return_v;
        }


        static System.Func<System.Management.Automation.Cmdlet>
        f_1251_1219_1312(System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Func<System.Management.Automation.Cmdlet>>
        this_param, System.Type
        key, System.Func<System.Management.Automation.Cmdlet>
        value)
        {
            var return_v = this_param.GetOrAdd(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 1219, 1312);
            return return_v;
        }


        static System.Func<System.Management.Automation.Cmdlet>
        f_1251_1327_1422(System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Func<System.Management.Automation.Cmdlet>>
        this_param, System.Type
        key, System.Func<System.Management.Automation.Cmdlet>
        value)
        {
            var return_v = this_param.GetOrAdd(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 1327, 1422);
            return return_v;
        }


        static System.Func<System.Management.Automation.Cmdlet>
        f_1251_1437_1526(System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Func<System.Management.Automation.Cmdlet>>
        this_param, System.Type
        key, System.Func<System.Management.Automation.Cmdlet>
        value)
        {
            var return_v = this_param.GetOrAdd(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 1437, 1526);
            return return_v;
        }


        static System.Func<System.Management.Automation.Cmdlet>
        f_1251_1541_1626(System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Func<System.Management.Automation.Cmdlet>>
        this_param, System.Type
        key, System.Func<System.Management.Automation.Cmdlet>
        value)
        {
            var return_v = this_param.GetOrAdd(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 1541, 1626);
            return return_v;
        }


        static System.Func<System.Management.Automation.Cmdlet>
        f_1251_1641_1738(System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Func<System.Management.Automation.Cmdlet>>
        this_param, System.Type
        key, System.Func<System.Management.Automation.Cmdlet>
        value)
        {
            var return_v = this_param.GetOrAdd(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 1641, 1738);
            return return_v;
        }


        static System.Func<System.Management.Automation.Cmdlet>
        f_1251_1753_1844(System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Func<System.Management.Automation.Cmdlet>>
        this_param, System.Type
        key, System.Func<System.Management.Automation.Cmdlet>
        value)
        {
            var return_v = this_param.GetOrAdd(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 1753, 1844);
            return return_v;
        }


        static System.Func<System.Management.Automation.Cmdlet>
        f_1251_1859_1950(System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Func<System.Management.Automation.Cmdlet>>
        this_param, System.Type
        key, System.Func<System.Management.Automation.Cmdlet>
        value)
        {
            var return_v = this_param.GetOrAdd(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 1859, 1950);
            return return_v;
        }


        static System.Func<System.Management.Automation.Cmdlet>
        f_1251_1965_2050(System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Func<System.Management.Automation.Cmdlet>>
        this_param, System.Type
        key, System.Func<System.Management.Automation.Cmdlet>
        value)
        {
            var return_v = this_param.GetOrAdd(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 1965, 2050);
            return return_v;
        }


        static System.Func<System.Management.Automation.Cmdlet>
        f_1251_2065_2150(System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Func<System.Management.Automation.Cmdlet>>
        this_param, System.Type
        key, System.Func<System.Management.Automation.Cmdlet>
        value)
        {
            var return_v = this_param.GetOrAdd(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 2065, 2150);
            return return_v;
        }


        static System.Func<System.Management.Automation.Cmdlet>
        f_1251_2165_2262(System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Func<System.Management.Automation.Cmdlet>>
        this_param, System.Type
        key, System.Func<System.Management.Automation.Cmdlet>
        value)
        {
            var return_v = this_param.GetOrAdd(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 2165, 2262);
            return return_v;
        }


        static System.Func<System.Management.Automation.Cmdlet>
        f_1251_2277_2374(System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Func<System.Management.Automation.Cmdlet>>
        this_param, System.Type
        key, System.Func<System.Management.Automation.Cmdlet>
        value)
        {
            var return_v = this_param.GetOrAdd(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 2277, 2374);
            return return_v;
        }


        static System.Func<System.Management.Automation.Cmdlet>
        f_1251_2389_2486(System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Func<System.Management.Automation.Cmdlet>>
        this_param, System.Type
        key, System.Func<System.Management.Automation.Cmdlet>
        value)
        {
            var return_v = this_param.GetOrAdd(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 2389, 2486);
            return return_v;
        }


        static int
        f_1251_3175_3191(System.Management.Automation.CommandProcessor
        this_param, System.Management.Automation.CmdletInfo
        cmdletInformation)
        {
            this_param.Init(cmdletInformation);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 3175, 3191);
            return 0;
        }


        static System.Management.Automation.CommandInfo
        f_1251_3101_3111_C(System.Management.Automation.CommandInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1251, 3019, 3203);
            return return_v;
        }


        int
        f_1251_4251_4274(System.Management.Automation.CommandProcessor
        this_param, System.Management.Automation.IScriptCommandInfo
        scriptCommandInfo)
        {
            this_param.Init(scriptCommandInfo);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1251, 4251, 4274);
            return 0;
        }


        static System.Management.Automation.CommandInfo
        f_1251_3999_4031_C(System.Management.Automation.CommandInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1251, 3813, 4286);
            return return_v;
        }

    }
}

