// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Management.Automation.Internal;
using System.Management.Automation.Language;
using System.Reflection;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation
{
    internal abstract class ScriptCommandProcessorBase : CommandProcessorBase
    {
        protected ScriptCommandProcessorBase(ScriptBlock scriptBlock, ExecutionContext context, bool useLocalScope, CommandOrigin origin, SessionStateInternal sessionState)
        : base(f_1332_849_899_C(f_1332_849_899(string.Empty, scriptBlock, context)))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1332, 664, 1115);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 2269, 2295);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 2470, 2491);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 2962, 2976);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 3011, 3023);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 3076, 3108);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 925, 965);

                this._dontUseScopeCommandOrigin = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 979, 1008);

                this._fromScriptFile = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 1024, 1104);

                f_1332_1024_1103(this, scriptBlock, context, useLocalScope, origin, sessionState);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1332, 664, 1115);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1332, 664, 1115);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1332, 664, 1115);
            }
        }

        protected ScriptCommandProcessorBase(IScriptCommandInfo commandInfo, ExecutionContext context, bool useLocalScope, SessionStateInternal sessionState)
        : base(f_1332_1297_1321_C((CommandInfo)commandInfo))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1332, 1127, 1815);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 2269, 2295);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 2470, 2491);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 2962, 2976);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 3011, 3023);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 3076, 3108);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 1347, 1417);

                f_1332_1347_1416(commandInfo != null, "commandInfo cannot be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 1431, 1513);

                f_1332_1431_1512(f_1332_1450_1473(commandInfo) != null, "scriptblock cannot be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 1529, 1627);

                this._fromScriptFile = (f_1332_1553_1569(this) is ExternalScriptInfo || (DynAbs.Tracing.TraceSender.Expression_False(1332, 1553, 1625) || f_1332_1595_1611(this) is ScriptInfo));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 1641, 1680);

                this._dontUseScopeCommandOrigin = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 1696, 1804);

                f_1332_1696_1803(this, f_1332_1717_1740(commandInfo), context, useLocalScope, CommandOrigin.Internal, sessionState);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1332, 1127, 1815);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1332, 1127, 1815);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1332, 1127, 1815);
            }
        }

        protected bool _dontUseScopeCommandOrigin;

        protected bool _rethrowExitException;

        protected bool _exitWasCalled;

        protected ScriptBlock _scriptBlock;

        private ScriptParameterBinderController _scriptParameterBinderController;

        internal ScriptParameterBinderController ScriptParameterBinderController
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1332, 3216, 3996);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 3252, 3921) || true) && (_scriptParameterBinderController == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1332, 3252, 3921);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 3440, 3666);

                        _scriptParameterBinderController =
                        f_1332_3500_3665(f_1332_3536_3581(((IScriptCommandInfo)f_1332_3557_3568())), f_1332_3612_3632(f_1332_3612_3619()), f_1332_3634_3641(), f_1332_3643_3650(), f_1332_3652_3664());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 3688, 3791);

                        f_1332_3688_3790(f_1332_3688_3742(_scriptParameterBinderController), f_1332_3764_3789(f_1332_3764_3776(this)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 3813, 3902);

                        f_1332_3813_3838(f_1332_3813_3825(this)).UnboundArguments = f_1332_3858_3901(_scriptParameterBinderController);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1332, 3252, 3921);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 3941, 3981);

                    return _scriptParameterBinderController;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1332, 3216, 3996);

                    System.Management.Automation.CommandInfo
                    f_1332_3557_3568()
                    {
                        var return_v = CommandInfo;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 3557, 3568);
                        return return_v;
                    }


                    System.Management.Automation.ScriptBlock
                    f_1332_3536_3581(System.Management.Automation.IScriptCommandInfo
                    this_param)
                    {
                        var return_v = this_param.ScriptBlock;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 3536, 3581);
                        return return_v;
                    }


                    System.Management.Automation.Internal.InternalCommand
                    f_1332_3612_3619()
                    {
                        var return_v = Command;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 3612, 3619);
                        return return_v;
                    }


                    System.Management.Automation.InvocationInfo
                    f_1332_3612_3632(System.Management.Automation.Internal.InternalCommand
                    this_param)
                    {
                        var return_v = this_param.MyInvocation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 3612, 3632);
                        return return_v;
                    }


                    System.Management.Automation.ExecutionContext
                    f_1332_3634_3641()
                    {
                        var return_v = Context;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 3634, 3641);
                        return return_v;
                    }


                    System.Management.Automation.Internal.InternalCommand
                    f_1332_3643_3650()
                    {
                        var return_v = Command;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 3643, 3650);
                        return return_v;
                    }


                    System.Management.Automation.SessionStateScope
                    f_1332_3652_3664()
                    {
                        var return_v = CommandScope;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 3652, 3664);
                        return return_v;
                    }


                    System.Management.Automation.ScriptParameterBinderController
                    f_1332_3500_3665(System.Management.Automation.ScriptBlock
                    script, System.Management.Automation.InvocationInfo
                    invocationInfo, System.Management.Automation.ExecutionContext
                    context, System.Management.Automation.Internal.InternalCommand
                    command, System.Management.Automation.SessionStateScope
                    localScope)
                    {
                        var return_v = new System.Management.Automation.ScriptParameterBinderController(script, invocationInfo, context, command, localScope);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 3500, 3665);
                        return return_v;
                    }


                    System.Management.Automation.CommandLineParameters
                    f_1332_3688_3742(System.Management.Automation.ScriptParameterBinderController
                    this_param)
                    {
                        var return_v = this_param.CommandLineParameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 3688, 3742);
                        return return_v;
                    }


                    System.Management.Automation.Internal.InternalCommand
                    f_1332_3764_3776(System.Management.Automation.ScriptCommandProcessorBase
                    this_param)
                    {
                        var return_v = this_param.Command;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 3764, 3776);
                        return return_v;
                    }


                    System.Management.Automation.InvocationInfo
                    f_1332_3764_3789(System.Management.Automation.Internal.InternalCommand
                    this_param)
                    {
                        var return_v = this_param.MyInvocation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 3764, 3789);
                        return return_v;
                    }


                    int
                    f_1332_3688_3790(System.Management.Automation.CommandLineParameters
                    this_param, System.Management.Automation.InvocationInfo
                    invocationInfo)
                    {
                        this_param.UpdateInvocationInfo(invocationInfo);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 3688, 3790);
                        return 0;
                    }


                    System.Management.Automation.Internal.InternalCommand
                    f_1332_3813_3825(System.Management.Automation.ScriptCommandProcessorBase
                    this_param)
                    {
                        var return_v = this_param.Command;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 3813, 3825);
                        return return_v;
                    }


                    System.Management.Automation.InvocationInfo
                    f_1332_3813_3838(System.Management.Automation.Internal.InternalCommand
                    this_param)
                    {
                        var return_v = this_param.MyInvocation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 3813, 3838);
                        return return_v;
                    }


                    System.Collections.Generic.List<object>
                    f_1332_3858_3901(System.Management.Automation.ScriptParameterBinderController
                    this_param)
                    {
                        var return_v = this_param.DollarArgs;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 3858, 3901);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1332, 3119, 4007);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1332, 3119, 4007);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected void CommonInitialization(ScriptBlock scriptBlock, ExecutionContext context, bool useLocalScope, CommandOrigin origin, SessionStateInternal sessionState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1332, 4194, 6172);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 4382, 4454);

                f_1332_4382_4453(context != null, "execution context cannot be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 4468, 4544);

                f_1332_4468_4543(f_1332_4487_4501(context) != null, "context.engine cannot be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 4560, 4600);

                this.CommandSessionState = sessionState;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 4614, 4638);

                this._context = context;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 4652, 4734);

                this._rethrowExitException = f_1332_4681_4733(f_1332_4681_4693(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 4748, 4810);

                this._context.ScriptCommandProcessorShouldRethrowExit = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 4826, 4909);

                ScriptCommand
                scriptCommand = new ScriptCommand { CommandInfo = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1332_4890_4906(this), 1332, 4856, 4908) }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 4925, 4954);

                this.Command = scriptCommand;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 5165, 5209);

                f_1332_5165_5177(this).CommandOriginInternal = origin;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 5223, 5344);

                f_1332_5223_5235(this).commandRuntime = this.commandRuntime = f_1332_5275_5343(f_1332_5297_5309(this), f_1332_5311_5327(this), scriptCommand);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 5360, 5555);

                this.CommandScope = (DynAbs.Tracing.TraceSender.Conditional_F1(1332, 5380, 5393) || ((useLocalScope
                && DynAbs.Tracing.TraceSender.Conditional_F2(1332, 5433, 5482)) || DynAbs.Tracing.TraceSender.Conditional_F3(1332, 5522, 5554))) ? f_1332_5433_5482(f_1332_5433_5452(), f_1332_5462_5481(this)) : f_1332_5522_5554(f_1332_5522_5541());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 5571, 5606);

                this.UseLocalScope = useLocalScope;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 5622, 5649);

                _scriptBlock = scriptBlock;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 5965, 6161) || true) && ((f_1332_5970_5989_M(!this.UseLocalScope)) && (DynAbs.Tracing.TraceSender.Expression_True(1332, 5969, 6023) && (!this._rethrowExitException)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1332, 5965, 6161);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 6057, 6146);

                    f_1332_6057_6145(_scriptBlock, f_1332_6102_6122(context), f_1332_6124_6144(f_1332_6124_6131()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1332, 5965, 6161);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1332, 4194, 6172);

                int
                f_1332_4382_4453(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 4382, 4453);
                    return 0;
                }


                System.Management.Automation.AutomationEngine
                f_1332_4487_4501(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Engine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 4487, 4501);
                    return return_v;
                }


                int
                f_1332_4468_4543(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 4468, 4543);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1332_4681_4693(System.Management.Automation.ScriptCommandProcessorBase
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 4681, 4693);
                    return return_v;
                }


                bool
                f_1332_4681_4733(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ScriptCommandProcessorShouldRethrowExit;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 4681, 4733);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1332_4890_4906(System.Management.Automation.ScriptCommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 4890, 4906);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1332_5165_5177(System.Management.Automation.ScriptCommandProcessorBase
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 5165, 5177);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1332_5223_5235(System.Management.Automation.ScriptCommandProcessorBase
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 5223, 5235);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1332_5297_5309(System.Management.Automation.ScriptCommandProcessorBase
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 5297, 5309);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1332_5311_5327(System.Management.Automation.ScriptCommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 5311, 5327);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1332_5275_5343(System.Management.Automation.ExecutionContext
                context, System.Management.Automation.CommandInfo
                commandInfo, System.Management.Automation.ScriptCommand
                thisCommand)
                {
                    var return_v = new System.Management.Automation.MshCommandRuntime(context, commandInfo, (System.Management.Automation.Internal.InternalCommand)thisCommand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 5275, 5343);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1332_5433_5452()
                {
                    var return_v = CommandSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 5433, 5452);
                    return return_v;
                }


                bool
                f_1332_5462_5481(System.Management.Automation.ScriptCommandProcessorBase
                this_param)
                {
                    var return_v = this_param.FromScriptFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 5462, 5481);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1332_5433_5482(System.Management.Automation.SessionStateInternal
                this_param, bool
                isScriptScope)
                {
                    var return_v = this_param.NewScope(isScriptScope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 5433, 5482);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1332_5522_5541()
                {
                    var return_v = CommandSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 5522, 5541);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1332_5522_5554(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 5522, 5554);
                    return return_v;
                }


                bool
                f_1332_5970_5989_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 5970, 5989);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1332_6102_6122(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 6102, 6122);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1332_6124_6131()
                {
                    var return_v = Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 6124, 6131);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1332_6124_6144(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 6124, 6144);
                    return return_v;
                }


                int
                f_1332_6057_6145(System.Management.Automation.ScriptBlock
                scriptBlock, System.Management.Automation.PSLanguageMode
                languageMode, System.Management.Automation.InvocationInfo
                invocationInfo)
                {
                    ValidateCompatibleLanguageMode(scriptBlock, languageMode, invocationInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 6057, 6145);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1332, 4194, 6172);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1332, 4194, 6172);
            }
        }

        internal override bool IsHelpRequested(out string helpTarget, out HelpCategory helpCategory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1332, 6630, 8029);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 6747, 7940) || true) && (arguments != null && (DynAbs.Tracing.TraceSender.Expression_True(1332, 6751, 6791) && f_1332_6772_6783() != null) && (DynAbs.Tracing.TraceSender.Expression_True(1332, 6751, 6834) && !f_1332_6796_6834(f_1332_6817_6833(f_1332_6817_6828()))) && (DynAbs.Tracing.TraceSender.Expression_True(1332, 6751, 6858) && _scriptBlock != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1332, 6747, 7940);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 6892, 7925);
                        foreach (CommandParameterInternal parameter in f_1332_6939_6953_I(this.arguments))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1332, 6892, 7925);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 6995, 7089);

                            f_1332_6995_7088(parameter != null, "CommandProcessor.arguments shouldn't have any null arguments");

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 7111, 7906) || true) && (f_1332_7115_7141(parameter))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1332, 7111, 7906);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 7191, 7271);

                                Dictionary<Ast, Token[]>
                                scriptBlockTokenCache = f_1332_7240_7270()
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 7297, 7311);

                                string
                                unused
                                = default(string);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 7337, 7590);

                                HelpInfo
                                helpInfo = f_1332_7357_7589(_scriptBlock, context: f_1332_7391_7398(), commandInfo: f_1332_7413_7424(), dontSearchOnRemoteComputer: false, scriptBlockTokenCache: scriptBlockTokenCache, helpFile: out unused, helpUriFromDotLink: out unused)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 7616, 7727) || true) && (helpInfo == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1332, 7616, 7727);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1332, 7694, 7700);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1332, 7616, 7727);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 7755, 7782);

                                helpTarget = f_1332_7768_7781(helpInfo);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 7808, 7845);

                                helpCategory = f_1332_7823_7844(helpInfo);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 7871, 7883);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1332, 7111, 7906);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1332, 6892, 7925);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1332, 1, 1034);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1332, 1, 1034);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1332, 6747, 7940);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 7956, 8018);

                // LAFHIS
                //return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.IsHelpRequested(out helpTarget, out helpCategory), 1332, 7963, 8017);
                var temp = base.IsHelpRequested(out helpTarget, out helpCategory);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 7963, 8017);
                return temp;

                DynAbs.Tracing.TraceSender.TraceExitMethod(1332, 6630, 8029);

                System.Management.Automation.CommandInfo
                f_1332_6772_6783()
                {
                    var return_v = CommandInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 6772, 6783);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1332_6817_6828()
                {
                    var return_v = CommandInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 6817, 6828);
                    return return_v;
                }


                string
                f_1332_6817_6833(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 6817, 6833);
                    return return_v;
                }


                bool
                f_1332_6796_6834(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 6796, 6834);
                    return return_v;
                }


                int
                f_1332_6995_7088(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 6995, 7088);
                    return 0;
                }


                bool
                f_1332_7115_7141(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.IsDashQuestion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 7115, 7141);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.Language.Ast, System.Management.Automation.Language.Token[]>
                f_1332_7240_7270()
                {
                    var return_v = new System.Collections.Generic.Dictionary<System.Management.Automation.Language.Ast, System.Management.Automation.Language.Token[]>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 7240, 7270);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1332_7391_7398()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 7391, 7398);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1332_7413_7424()
                {
                    var return_v = CommandInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 7413, 7424);
                    return return_v;
                }


                System.Management.Automation.HelpInfo
                f_1332_7357_7589(System.Management.Automation.ScriptBlock
                this_param, System.Management.Automation.ExecutionContext
                context, System.Management.Automation.CommandInfo
                commandInfo, bool
                dontSearchOnRemoteComputer, System.Collections.Generic.Dictionary<System.Management.Automation.Language.Ast, System.Management.Automation.Language.Token[]>
                scriptBlockTokenCache, out string
                helpFile, out string
                helpUriFromDotLink)
                {
                    var return_v = this_param.GetHelpInfo(context: context, commandInfo: commandInfo, dontSearchOnRemoteComputer: dontSearchOnRemoteComputer, scriptBlockTokenCache: scriptBlockTokenCache, out helpFile, out helpUriFromDotLink);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 7357, 7589);
                    return return_v;
                }


                string
                f_1332_7768_7781(System.Management.Automation.HelpInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 7768, 7781);
                    return return_v;
                }


                System.Management.Automation.HelpCategory
                f_1332_7823_7844(System.Management.Automation.HelpInfo
                this_param)
                {
                    var return_v = this_param.HelpCategory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 7823, 7844);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                f_1332_6939_6953_I(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 6939, 6953);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1332, 6630, 8029);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1332, 6630, 8029);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ScriptCommandProcessorBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1332, 574, 8036);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1332, 574, 8036);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1332, 574, 8036);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1332, 574, 8036);

        static System.Management.Automation.ScriptInfo
        f_1332_849_899(string
        name, System.Management.Automation.ScriptBlock
        script, System.Management.Automation.ExecutionContext
        context)
        {
            var return_v = new System.Management.Automation.ScriptInfo(name, script, context);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 849, 899);
            return return_v;
        }


        int
        f_1332_1024_1103(System.Management.Automation.ScriptCommandProcessorBase
        this_param, System.Management.Automation.ScriptBlock
        scriptBlock, System.Management.Automation.ExecutionContext
        context, bool
        useLocalScope, System.Management.Automation.CommandOrigin
        origin, System.Management.Automation.SessionStateInternal
        sessionState)
        {
            this_param.CommonInitialization(scriptBlock, context, useLocalScope, origin, sessionState);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 1024, 1103);
            return 0;
        }


        static System.Management.Automation.CommandInfo
        f_1332_849_899_C(System.Management.Automation.CommandInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1332, 664, 1115);
            return return_v;
        }


        int
        f_1332_1347_1416(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 1347, 1416);
            return 0;
        }


        System.Management.Automation.ScriptBlock
        f_1332_1450_1473(System.Management.Automation.IScriptCommandInfo
        this_param)
        {
            var return_v = this_param.ScriptBlock;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 1450, 1473);
            return return_v;
        }


        int
        f_1332_1431_1512(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 1431, 1512);
            return 0;
        }


        System.Management.Automation.CommandInfo
        f_1332_1553_1569(System.Management.Automation.ScriptCommandProcessorBase
        this_param)
        {
            var return_v = this_param.CommandInfo;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 1553, 1569);
            return return_v;
        }


        System.Management.Automation.CommandInfo
        f_1332_1595_1611(System.Management.Automation.ScriptCommandProcessorBase
        this_param)
        {
            var return_v = this_param.CommandInfo;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 1595, 1611);
            return return_v;
        }


        System.Management.Automation.ScriptBlock
        f_1332_1717_1740(System.Management.Automation.IScriptCommandInfo
        this_param)
        {
            var return_v = this_param.ScriptBlock;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 1717, 1740);
            return return_v;
        }


        int
        f_1332_1696_1803(System.Management.Automation.ScriptCommandProcessorBase
        this_param, System.Management.Automation.ScriptBlock
        scriptBlock, System.Management.Automation.ExecutionContext
        context, bool
        useLocalScope, System.Management.Automation.CommandOrigin
        origin, System.Management.Automation.SessionStateInternal
        sessionState)
        {
            this_param.CommonInitialization(scriptBlock, context, useLocalScope, origin, sessionState);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 1696, 1803);
            return 0;
        }


        static System.Management.Automation.CommandInfo
        f_1332_1297_1321_C(System.Management.Automation.CommandInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1332, 1127, 1815);
            return return_v;
        }

    }
    internal sealed class DlrScriptCommandProcessor : ScriptCommandProcessorBase
    {
        private readonly ArrayList _input;

        private readonly object _dollarUnderbar;

        private new ScriptBlock _scriptBlock;

        private MutableTuple _localsTuple;

        private bool _runOptimizedCode;

        private bool _argsBound;

        private FunctionContext _functionContext;

        internal DlrScriptCommandProcessor(ScriptBlock scriptBlock, ExecutionContext context, bool useNewScope, CommandOrigin origin, SessionStateInternal sessionState, object dollarUnderbar)
        : base(f_1332_10931_10942_C(scriptBlock), context, useNewScope, origin, sessionState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1332, 10727, 11077);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 10400, 10424);
                this._input = f_1332_10409_10424();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 10459, 10497);
                this._dollarUnderbar = f_1332_10477_10497();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 10532, 10544);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 10576, 10588);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 10612, 10629);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 10653, 10663);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 10698, 10714);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 13054, 13072);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 11012, 11019);

                f_1332_11012_11018(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 11033, 11066);

                _dollarUnderbar = dollarUnderbar;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1332, 10727, 11077);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1332, 10727, 11077);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1332, 10727, 11077);
            }
        }

        internal DlrScriptCommandProcessor(ScriptBlock scriptBlock, ExecutionContext context, bool useNewScope, CommandOrigin origin, SessionStateInternal sessionState)
        : base(f_1332_11270_11281_C(scriptBlock), context, useNewScope, origin, sessionState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1332, 11089, 11369);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 10400, 10424);
                this._input = f_1332_10409_10424();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 10459, 10497);
                this._dollarUnderbar = f_1332_10477_10497();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 10532, 10544);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 10576, 10588);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 10612, 10629);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 10653, 10663);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 10698, 10714);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 13054, 13072);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 11351, 11358);

                f_1332_11351_11357(this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1332, 11089, 11369);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1332, 11089, 11369);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1332, 11089, 11369);
            }
        }

        internal DlrScriptCommandProcessor(FunctionInfo functionInfo, ExecutionContext context, bool useNewScope, SessionStateInternal sessionState)
        : base(f_1332_11542_11554_C(functionInfo), context, useNewScope, sessionState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1332, 11381, 11634);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 10400, 10424);
                this._input = f_1332_10409_10424();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 10459, 10497);
                this._dollarUnderbar = f_1332_10477_10497();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 10532, 10544);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 10576, 10588);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 10612, 10629);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 10653, 10663);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 10698, 10714);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 13054, 13072);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 11616, 11623);

                f_1332_11616_11622(this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1332, 11381, 11634);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1332, 11381, 11634);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1332, 11381, 11634);
            }
        }

        internal DlrScriptCommandProcessor(ScriptInfo scriptInfo, ExecutionContext context, bool useNewScope, SessionStateInternal sessionState)
        : base(f_1332_11803_11813_C(scriptInfo), context, useNewScope, sessionState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1332, 11646, 11893);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 10400, 10424);
                this._input = f_1332_10409_10424();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 10459, 10497);
                this._dollarUnderbar = f_1332_10477_10497();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 10532, 10544);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 10576, 10588);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 10612, 10629);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 10653, 10663);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 10698, 10714);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 13054, 13072);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 11875, 11882);

                f_1332_11875_11881(this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1332, 11646, 11893);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1332, 11646, 11893);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1332, 11646, 11893);
            }
        }

        internal DlrScriptCommandProcessor(ExternalScriptInfo scriptInfo, ExecutionContext context, bool useNewScope, SessionStateInternal sessionState)
        : base(f_1332_12070_12080_C(scriptInfo), context, useNewScope, sessionState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1332, 11905, 12160);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 10400, 10424);
                this._input = f_1332_10409_10424();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 10459, 10497);
                this._dollarUnderbar = f_1332_10477_10497();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 10532, 10544);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 10576, 10588);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 10612, 10629);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 10653, 10663);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 10698, 10714);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 13054, 13072);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 12142, 12149);

                f_1332_12142_12148(this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1332, 11905, 12160);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1332, 11905, 12160);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1332, 11905, 12160);
            }
        }

        private void Init()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1332, 12172, 12771);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 12216, 12249);

                _scriptBlock = DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base._scriptBlock, 1332, 12231, 12248);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 12263, 12315);

                _obsoleteAttribute = f_1332_12284_12314(_scriptBlock);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 12329, 12434);

                _runOptimizedCode = f_1332_12349_12433(_scriptBlock, optimized: (DynAbs.Tracing.TraceSender.Conditional_F1(1332, 12381, 12408) || ((_context._debuggingMode > 0 && DynAbs.Tracing.TraceSender.Conditional_F2(1332, 12411, 12416)) || DynAbs.Tracing.TraceSender.Conditional_F3(1332, 12419, 12432))) ? false : f_1332_12419_12432());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 12448, 12511);

                _localsTuple = f_1332_12463_12510(_scriptBlock, _runOptimizedCode);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 12527, 12760) || true) && (f_1332_12531_12544())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1332, 12527, 12760);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 12578, 12687);

                    f_1332_12578_12686(f_1332_12597_12621(f_1332_12597_12609()) == null, "a newly created scope shouldn't have it's tuple set.");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 12705, 12745);

                    f_1332_12705_12717().LocalsTuple = _localsTuple;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1332, 12527, 12760);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1332, 12172, 12771);

                System.ObsoleteAttribute
                f_1332_12284_12314(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.ObsoleteAttribute;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 12284, 12314);
                    return return_v;
                }


                bool
                f_1332_12419_12432()
                {
                    var return_v = UseLocalScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 12419, 12432);
                    return return_v;
                }


                bool
                f_1332_12349_12433(System.Management.Automation.ScriptBlock
                this_param, bool
                optimized)
                {
                    var return_v = this_param.Compile(optimized: optimized);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 12349, 12433);
                    return return_v;
                }


                System.Management.Automation.MutableTuple
                f_1332_12463_12510(System.Management.Automation.ScriptBlock
                this_param, bool
                createLocalScope)
                {
                    var return_v = this_param.MakeLocalsTuple(createLocalScope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 12463, 12510);
                    return return_v;
                }


                bool
                f_1332_12531_12544()
                {
                    var return_v = UseLocalScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 12531, 12544);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1332_12597_12609()
                {
                    var return_v = CommandScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 12597, 12609);
                    return return_v;
                }


                System.Management.Automation.MutableTuple
                f_1332_12597_12621(System.Management.Automation.SessionStateScope
                this_param)
                {
                    var return_v = this_param.LocalsTuple;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 12597, 12621);
                    return return_v;
                }


                int
                f_1332_12578_12686(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 12578, 12686);
                    return 0;
                }


                System.Management.Automation.SessionStateScope
                f_1332_12705_12717()
                {
                    var return_v = CommandScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 12705, 12717);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1332, 12172, 12771);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1332, 12172, 12771);
            }
        }

        internal override ObsoleteAttribute ObsoleteAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1332, 12971, 13005);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 12977, 13003);

                    return _obsoleteAttribute;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1332, 12971, 13005);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1332, 12893, 13016);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1332, 12893, 13016);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ObsoleteAttribute _obsoleteAttribute;

        internal override void Prepare(IDictionary psDefaultParameterValues)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1332, 13085, 13901);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 13178, 13281);

                f_1332_13178_13280(_localsTuple, AutomaticVariable.MyInvocation, f_1332_13244_13269(f_1332_13244_13256(this)), _context);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 13295, 13364);

                f_1332_13295_13363(_scriptBlock, _localsTuple, _context);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 13378, 13890);

                _functionContext = new FunctionContext
                {
                    _executionContext = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => _context, 1332, 13397, 13889),
                    _outputPipe = f_1332_13510_13535(commandRuntime),
                    _localsTuple = _localsTuple,
                    _scriptBlock = _scriptBlock,
                    _file = f_1332_13654_13671(_scriptBlock),
                    _debuggerHidden = f_1332_13708_13735(_scriptBlock),
                    _debuggerStepThrough = f_1332_13777_13809(_scriptBlock),
                    _sequencePoints = f_1332_13846_13873(_scriptBlock)
                };
                DynAbs.Tracing.TraceSender.TraceExitMethod(1332, 13085, 13901);

                System.Management.Automation.Internal.InternalCommand
                f_1332_13244_13256(System.Management.Automation.DlrScriptCommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 13244, 13256);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1332_13244_13269(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 13244, 13269);
                    return return_v;
                }


                int
                f_1332_13178_13280(System.Management.Automation.MutableTuple
                this_param, System.Management.Automation.AutomaticVariable
                auto, System.Management.Automation.InvocationInfo
                value, System.Management.Automation.ExecutionContext
                context)
                {
                    this_param.SetAutomaticVariable(auto, (object)value, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 13178, 13280);
                    return 0;
                }


                int
                f_1332_13295_13363(System.Management.Automation.ScriptBlock
                this_param, System.Management.Automation.MutableTuple
                locals, System.Management.Automation.ExecutionContext
                context)
                {
                    this_param.SetPSScriptRootAndPSCommandPath(locals, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 13295, 13363);
                    return 0;
                }


                System.Management.Automation.Internal.Pipe
                f_1332_13510_13535(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.OutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 13510, 13535);
                    return return_v;
                }


                string
                f_1332_13654_13671(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.File;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 13654, 13671);
                    return return_v;
                }


                bool
                f_1332_13708_13735(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.DebuggerHidden;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 13708, 13735);
                    return return_v;
                }


                bool
                f_1332_13777_13809(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.DebuggerStepThrough;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 13777, 13809);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent[]
                f_1332_13846_13873(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.SequencePoints;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 13846, 13873);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1332, 13085, 13901);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1332, 13085, 13901);
            }
        }

        internal override void DoBegin()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1332, 14322, 15457);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 14379, 15446) || true) && (!RanBeginAlready)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1332, 14379, 15446);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 14433, 14456);

                    RanBeginAlready = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 14476, 14558);

                    f_1332_14476_14557(_scriptBlock, f_1332_14522_14556(f_1332_14522_14545(f_1332_14522_14529())));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 14702, 14736);

                    f_1332_14702_14735(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 14754, 14836);

                    CommandProcessorBase
                    oldCurrentCommandProcessor = f_1332_14804_14835(f_1332_14804_14811())
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 14898, 14937);

                        f_1332_14898_14905().CurrentCommandProcessor = this;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 14961, 15221) || true) && (f_1332_14965_14991(_scriptBlock))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1332, 14961, 15221);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 15041, 15198);

                            f_1332_15041_15197(this, (DynAbs.Tracing.TraceSender.Conditional_F1(1332, 15051, 15068) || ((_runOptimizedCode && DynAbs.Tracing.TraceSender.Conditional_F2(1332, 15071, 15094)) || DynAbs.Tracing.TraceSender.Conditional_F3(1332, 15097, 15131))) ? f_1332_15071_15094(_scriptBlock) : f_1332_15097_15131(_scriptBlock), f_1332_15168_15188(), _input);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1332, 14961, 15221);
                        }
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1332, 15258, 15431);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 15306, 15367);

                        f_1332_15306_15313().CurrentCommandProcessor = oldCurrentCommandProcessor;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 15389, 15412);

                        f_1332_15389_15411(this);
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1332, 15258, 15431);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1332, 14379, 15446);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1332, 14322, 15457);

                System.Management.Automation.ExecutionContext
                f_1332_14522_14529()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 14522, 14529);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1332_14522_14545(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 14522, 14545);
                    return return_v;
                }


                System.Guid
                f_1332_14522_14556(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 14522, 14556);
                    return return_v;
                }


                int
                f_1332_14476_14557(System.Management.Automation.ScriptBlock
                scriptBlock, System.Guid
                runspaceId)
                {
                    ScriptBlock.LogScriptBlockStart(scriptBlock, runspaceId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 14476, 14557);
                    return 0;
                }


                int
                f_1332_14702_14735(System.Management.Automation.DlrScriptCommandProcessor
                this_param)
                {
                    this_param.SetCurrentScopeToExecutionScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 14702, 14735);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1332_14804_14811()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 14804, 14811);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1332_14804_14835(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentCommandProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 14804, 14835);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1332_14898_14905()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 14898, 14905);
                    return return_v;
                }


                bool
                f_1332_14965_14991(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.HasBeginBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 14965, 14991);
                    return return_v;
                }


                System.Action<System.Management.Automation.Language.FunctionContext>
                f_1332_15071_15094(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.BeginBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 15071, 15094);
                    return return_v;
                }


                System.Action<System.Management.Automation.Language.FunctionContext>
                f_1332_15097_15131(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.UnoptimizedBeginBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 15097, 15131);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1332_15168_15188()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 15168, 15188);
                    return return_v;
                }


                int
                f_1332_15041_15197(System.Management.Automation.DlrScriptCommandProcessor
                this_param, System.Action<System.Management.Automation.Language.FunctionContext>
                clause, System.Management.Automation.PSObject
                dollarUnderbar, System.Collections.ArrayList
                inputToProcess)
                {
                    this_param.RunClause(clause, (object)dollarUnderbar, (object)inputToProcess);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 15041, 15197);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1332_15306_15313()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 15306, 15313);
                    return return_v;
                }


                int
                f_1332_15389_15411(System.Management.Automation.DlrScriptCommandProcessor
                this_param)
                {
                    this_param.RestorePreviousScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 15389, 15411);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1332, 14322, 15457);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1332, 14322, 15457);
            }
        }

        internal override void ProcessRecord()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1332, 15469, 17019);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 15532, 15606) || true) && (_exitWasCalled)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1332, 15532, 15606);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 15584, 15591);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1332, 15532, 15606);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 15622, 15952) || true) && (!this.RanBeginAlready)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1332, 15622, 15952);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 15681, 15704);

                    RanBeginAlready = true;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 15724, 15937) || true) && (f_1332_15728_15754(_scriptBlock))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1332, 15724, 15937);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 15796, 15918);

                        f_1332_15796_15917(this, (DynAbs.Tracing.TraceSender.Conditional_F1(1332, 15806, 15823) || ((_runOptimizedCode && DynAbs.Tracing.TraceSender.Conditional_F2(1332, 15826, 15849)) || DynAbs.Tracing.TraceSender.Conditional_F3(1332, 15852, 15886))) ? f_1332_15826_15849(_scriptBlock) : f_1332_15852_15886(_scriptBlock), f_1332_15888_15908(), _input);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1332, 15724, 15937);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1332, 15622, 15952);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 15968, 17008) || true) && (f_1332_15972_16000(_scriptBlock))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1332, 15968, 17008);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 16034, 16344) || true) && (!f_1332_16039_16064(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1332, 16034, 16344);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 16106, 16216);

                        f_1332_16106_16215(this, (DynAbs.Tracing.TraceSender.Conditional_F1(1332, 16116, 16133) || ((_runOptimizedCode && DynAbs.Tracing.TraceSender.Conditional_F2(1332, 16136, 16161)) || DynAbs.Tracing.TraceSender.Conditional_F3(1332, 16164, 16200))) ? f_1332_16136_16161(_scriptBlock) : f_1332_16164_16200(_scriptBlock), null, _input);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1332, 16034, 16344);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1332, 16034, 16344);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 16298, 16325);

                        f_1332_16298_16324(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1332, 16034, 16344);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1332, 15968, 17008);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1332, 15968, 17008);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 16378, 17008) || true) && (f_1332_16382_16407(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1332, 16378, 17008);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 16517, 16587);

                        f_1332_16517_16586(f_1332_16530_16577(f_1332_16530_16555(f_1332_16530_16542(this))) != null);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 16666, 16993) || true) && (f_1332_16670_16714(f_1332_16670_16699(f_1332_16670_16689(this))) == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1332, 16666, 16993);
                            try
                            {
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 16764, 16974) || true) && (f_1332_16771_16777(this))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1332, 16764, 16974);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 16909, 16951);

                                    f_1332_16909_16950(                        // accumulate all of the objects and execute at the end.
                                                            _input, f_1332_16920_16949(f_1332_16920_16927()));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1332, 16764, 16974);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1332, 16764, 16974);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1332, 16764, 16974);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1332, 16666, 16993);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1332, 16378, 17008);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1332, 15968, 17008);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1332, 15469, 17019);

                bool
                f_1332_15728_15754(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.HasBeginBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 15728, 15754);
                    return return_v;
                }


                System.Action<System.Management.Automation.Language.FunctionContext>
                f_1332_15826_15849(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.BeginBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 15826, 15849);
                    return return_v;
                }


                System.Action<System.Management.Automation.Language.FunctionContext>
                f_1332_15852_15886(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.UnoptimizedBeginBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 15852, 15886);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1332_15888_15908()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 15888, 15908);
                    return return_v;
                }


                int
                f_1332_15796_15917(System.Management.Automation.DlrScriptCommandProcessor
                this_param, System.Action<System.Management.Automation.Language.FunctionContext>
                clause, System.Management.Automation.PSObject
                dollarUnderbar, System.Collections.ArrayList
                inputToProcess)
                {
                    this_param.RunClause(clause, (object)dollarUnderbar, (object)inputToProcess);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 15796, 15917);
                    return 0;
                }


                bool
                f_1332_15972_16000(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.HasProcessBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 15972, 16000);
                    return return_v;
                }


                bool
                f_1332_16039_16064(System.Management.Automation.DlrScriptCommandProcessor
                this_param)
                {
                    var return_v = this_param.IsPipelineInputExpected();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 16039, 16064);
                    return return_v;
                }


                System.Action<System.Management.Automation.Language.FunctionContext>
                f_1332_16136_16161(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.ProcessBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 16136, 16161);
                    return return_v;
                }


                System.Action<System.Management.Automation.Language.FunctionContext>
                f_1332_16164_16200(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.UnoptimizedProcessBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 16164, 16200);
                    return return_v;
                }


                int
                f_1332_16106_16215(System.Management.Automation.DlrScriptCommandProcessor
                this_param, System.Action<System.Management.Automation.Language.FunctionContext>
                clause, object
                dollarUnderbar, System.Collections.ArrayList
                inputToProcess)
                {
                    this_param.RunClause(clause, dollarUnderbar, (object)inputToProcess);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 16106, 16215);
                    return 0;
                }


                int
                f_1332_16298_16324(System.Management.Automation.DlrScriptCommandProcessor
                this_param)
                {
                    this_param.DoProcessRecordWithInput();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 16298, 16324);
                    return 0;
                }


                bool
                f_1332_16382_16407(System.Management.Automation.DlrScriptCommandProcessor
                this_param)
                {
                    var return_v = this_param.IsPipelineInputExpected();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 16382, 16407);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1332_16530_16542(System.Management.Automation.DlrScriptCommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 16530, 16542);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1332_16530_16555(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 16530, 16555);
                    return return_v;
                }


                int[]
                f_1332_16530_16577(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.PipelineIterationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 16530, 16577);
                    return return_v;
                }


                int
                f_1332_16517_16586(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 16517, 16586);
                    return 0;
                }


                System.Management.Automation.MshCommandRuntime
                f_1332_16670_16689(System.Management.Automation.DlrScriptCommandProcessor
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 16670, 16689);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1332_16670_16699(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.InputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 16670, 16699);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineReader<object>
                f_1332_16670_16714(System.Management.Automation.Internal.Pipe
                this_param)
                {
                    var return_v = this_param.ExternalReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 16670, 16714);
                    return return_v;
                }


                bool
                f_1332_16771_16777(System.Management.Automation.DlrScriptCommandProcessor
                this_param)
                {
                    var return_v = this_param.Read();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 16771, 16777);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1332_16920_16927()
                {
                    var return_v = Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 16920, 16927);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1332_16920_16949(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.CurrentPipelineObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 16920, 16949);
                    return return_v;
                }


                int
                f_1332_16909_16950(System.Collections.ArrayList
                this_param, System.Management.Automation.PSObject
                value)
                {
                    var return_v = this_param.Add((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 16909, 16950);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1332, 15469, 17019);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1332, 15469, 17019);
            }
        }

        internal override void Complete()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1332, 17031, 18751);
                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 17125, 17211) || true) && (_exitWasCalled)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1332, 17125, 17211);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 17185, 17192);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1332, 17125, 17211);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 17309, 17458) || true) && (f_1332_17313_17341(_scriptBlock) && (DynAbs.Tracing.TraceSender.Expression_True(1332, 17313, 17370) && f_1332_17345_17370(this)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1332, 17309, 17458);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 17412, 17439);

                        f_1332_17412_17438(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1332, 17309, 17458);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 17478, 18576) || true) && (f_1332_17482_17506(_scriptBlock))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1332, 17478, 18576);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 17548, 17640);

                        var
                        endBlock = (DynAbs.Tracing.TraceSender.Conditional_F1(1332, 17563, 17580) || ((_runOptimizedCode && DynAbs.Tracing.TraceSender.Conditional_F2(1332, 17583, 17604)) || DynAbs.Tracing.TraceSender.Conditional_F3(1332, 17607, 17639))) ? f_1332_17583_17604(_scriptBlock) : f_1332_17607_17639(_scriptBlock)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 17662, 18557) || true) && (f_1332_17666_17710(f_1332_17666_17695(f_1332_17666_17685(this))) == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1332, 17662, 18557);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 17768, 18117) || true) && (f_1332_17772_17797(this))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1332, 17768, 18117);
                                try
                                {
                                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 17938, 18090) || true) && (f_1332_17945_17951(this))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1332, 17938, 18090);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 18017, 18059);

                                        f_1332_18017_18058(_input, f_1332_18028_18057(f_1332_18028_18035()));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1332, 17938, 18090);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1332, 17938, 18090);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1332, 17938, 18090);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1332, 17768, 18117);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 18200, 18250);

                            f_1332_18200_18249(this, endBlock, f_1332_18220_18240(), _input);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1332, 17662, 18557);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1332, 17662, 18557);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 18426, 18534);

                            f_1332_18426_18533(this, endBlock, f_1332_18446_18466(), f_1332_18468_18532(f_1332_18468_18512(f_1332_18468_18497(f_1332_18468_18487(this)))));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1332, 17662, 18557);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1332, 17478, 18576);
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1332, 18605, 18740);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 18645, 18725);

                    f_1332_18645_18724(_scriptBlock, f_1332_18689_18723(f_1332_18689_18712(f_1332_18689_18696())));
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1332, 18605, 18740);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1332, 17031, 18751);

                bool
                f_1332_17313_17341(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.HasProcessBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 17313, 17341);
                    return return_v;
                }


                bool
                f_1332_17345_17370(System.Management.Automation.DlrScriptCommandProcessor
                this_param)
                {
                    var return_v = this_param.IsPipelineInputExpected();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 17345, 17370);
                    return return_v;
                }


                int
                f_1332_17412_17438(System.Management.Automation.DlrScriptCommandProcessor
                this_param)
                {
                    this_param.DoProcessRecordWithInput();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 17412, 17438);
                    return 0;
                }


                bool
                f_1332_17482_17506(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.HasEndBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 17482, 17506);
                    return return_v;
                }


                System.Action<System.Management.Automation.Language.FunctionContext>
                f_1332_17583_17604(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.EndBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 17583, 17604);
                    return return_v;
                }


                System.Action<System.Management.Automation.Language.FunctionContext>
                f_1332_17607_17639(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.UnoptimizedEndBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 17607, 17639);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1332_17666_17685(System.Management.Automation.DlrScriptCommandProcessor
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 17666, 17685);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1332_17666_17695(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.InputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 17666, 17695);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineReader<object>
                f_1332_17666_17710(System.Management.Automation.Internal.Pipe
                this_param)
                {
                    var return_v = this_param.ExternalReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 17666, 17710);
                    return return_v;
                }


                bool
                f_1332_17772_17797(System.Management.Automation.DlrScriptCommandProcessor
                this_param)
                {
                    var return_v = this_param.IsPipelineInputExpected();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 17772, 17797);
                    return return_v;
                }


                bool
                f_1332_17945_17951(System.Management.Automation.DlrScriptCommandProcessor
                this_param)
                {
                    var return_v = this_param.Read();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 17945, 17951);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1332_18028_18035()
                {
                    var return_v = Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 18028, 18035);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1332_18028_18057(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.CurrentPipelineObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 18028, 18057);
                    return return_v;
                }


                int
                f_1332_18017_18058(System.Collections.ArrayList
                this_param, System.Management.Automation.PSObject
                value)
                {
                    var return_v = this_param.Add((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 18017, 18058);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1332_18220_18240()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 18220, 18240);
                    return return_v;
                }


                int
                f_1332_18200_18249(System.Management.Automation.DlrScriptCommandProcessor
                this_param, System.Action<System.Management.Automation.Language.FunctionContext>
                clause, System.Management.Automation.PSObject
                dollarUnderbar, System.Collections.ArrayList
                inputToProcess)
                {
                    this_param.RunClause(clause, (object)dollarUnderbar, (object)inputToProcess);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 18200, 18249);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1332_18446_18466()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 18446, 18466);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1332_18468_18487(System.Management.Automation.DlrScriptCommandProcessor
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 18468, 18487);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1332_18468_18497(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.InputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 18468, 18497);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineReader<object>
                f_1332_18468_18512(System.Management.Automation.Internal.Pipe
                this_param)
                {
                    var return_v = this_param.ExternalReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 18468, 18512);
                    return return_v;
                }


                System.Collections.Generic.IEnumerator<object>
                f_1332_18468_18532(System.Management.Automation.Runspaces.PipelineReader<object>
                this_param)
                {
                    var return_v = this_param.GetReadEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 18468, 18532);
                    return return_v;
                }


                int
                f_1332_18426_18533(System.Management.Automation.DlrScriptCommandProcessor
                this_param, System.Action<System.Management.Automation.Language.FunctionContext>
                clause, System.Management.Automation.PSObject
                dollarUnderbar, System.Collections.Generic.IEnumerator<object>
                inputToProcess)
                {
                    this_param.RunClause(clause, (object)dollarUnderbar, (object)inputToProcess);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 18426, 18533);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1332_18689_18696()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 18689, 18696);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1332_18689_18712(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 18689, 18712);
                    return return_v;
                }


                System.Guid
                f_1332_18689_18723(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 18689, 18723);
                    return return_v;
                }


                int
                f_1332_18645_18724(System.Management.Automation.ScriptBlock
                scriptBlock, System.Guid
                runspaceId)
                {
                    ScriptBlock.LogScriptBlockEnd(scriptBlock, runspaceId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 18645, 18724);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1332, 17031, 18751);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1332, 17031, 18751);
            }
        }

        private void DoProcessRecordWithInput()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1332, 18763, 19615);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 18909, 18979);

                f_1332_18909_18978(f_1332_18922_18969(f_1332_18922_18947(f_1332_18922_18934(this))) != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 19054, 19158);

                var
                processBlock = (DynAbs.Tracing.TraceSender.Conditional_F1(1332, 19073, 19090) || ((_runOptimizedCode && DynAbs.Tracing.TraceSender.Conditional_F2(1332, 19093, 19118)) || DynAbs.Tracing.TraceSender.Conditional_F3(1332, 19121, 19157))) ? f_1332_19093_19118(_scriptBlock) : f_1332_19121_19157(_scriptBlock)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 19172, 19604) || true) && (f_1332_19179_19185(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1332, 19172, 19604);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 19219, 19261);

                        f_1332_19219_19260(_input, f_1332_19230_19259(f_1332_19230_19237()));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 19281, 19375);

                        f_1332_19281_19328(f_1332_19281_19306(f_1332_19281_19293(this)))[f_1332_19329_19371(f_1332_19329_19354(f_1332_19329_19341(this)))]++;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 19395, 19458);

                        f_1332_19395_19457(this, processBlock, f_1332_19419_19448(f_1332_19419_19426()), _input);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 19574, 19589);

                        f_1332_19574_19588(
                                        // now clear input for next iteration; also makes it clear for the end clause.
                                        _input);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1332, 19172, 19604);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1332, 19172, 19604);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1332, 19172, 19604);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1332, 18763, 19615);

                System.Management.Automation.Internal.InternalCommand
                f_1332_18922_18934(System.Management.Automation.DlrScriptCommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 18922, 18934);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1332_18922_18947(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 18922, 18947);
                    return return_v;
                }


                int[]
                f_1332_18922_18969(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.PipelineIterationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 18922, 18969);
                    return return_v;
                }


                int
                f_1332_18909_18978(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 18909, 18978);
                    return 0;
                }


                System.Action<System.Management.Automation.Language.FunctionContext>
                f_1332_19093_19118(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.ProcessBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 19093, 19118);
                    return return_v;
                }


                System.Action<System.Management.Automation.Language.FunctionContext>
                f_1332_19121_19157(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.UnoptimizedProcessBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 19121, 19157);
                    return return_v;
                }


                bool
                f_1332_19179_19185(System.Management.Automation.DlrScriptCommandProcessor
                this_param)
                {
                    var return_v = this_param.Read();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 19179, 19185);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1332_19230_19237()
                {
                    var return_v = Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 19230, 19237);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1332_19230_19259(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.CurrentPipelineObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 19230, 19259);
                    return return_v;
                }


                int
                f_1332_19219_19260(System.Collections.ArrayList
                this_param, System.Management.Automation.PSObject
                value)
                {
                    var return_v = this_param.Add((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 19219, 19260);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1332_19281_19293(System.Management.Automation.DlrScriptCommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 19281, 19293);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1332_19281_19306(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 19281, 19306);
                    return return_v;
                }


                int[]
                f_1332_19281_19328(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.PipelineIterationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 19281, 19328);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1332_19329_19341(System.Management.Automation.DlrScriptCommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 19329, 19341);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1332_19329_19354(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 19329, 19354);
                    return return_v;
                }


                int
                f_1332_19329_19371(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.PipelinePosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 19329, 19371);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1332_19419_19426()
                {
                    var return_v = Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 19419, 19426);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1332_19419_19448(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.CurrentPipelineObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 19419, 19448);
                    return return_v;
                }


                int
                f_1332_19395_19457(System.Management.Automation.DlrScriptCommandProcessor
                this_param, System.Action<System.Management.Automation.Language.FunctionContext>
                clause, System.Management.Automation.PSObject
                dollarUnderbar, System.Collections.ArrayList
                inputToProcess)
                {
                    this_param.RunClause(clause, (object)dollarUnderbar, (object)inputToProcess);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 19395, 19457);
                    return 0;
                }


                int
                f_1332_19574_19588(System.Collections.ArrayList
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 19574, 19588);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1332, 18763, 19615);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1332, 18763, 19615);
            }
        }

        private void RunClause(Action<FunctionContext> clause, object dollarUnderbar, object inputToProcess)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1332, 19627, 25740);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 19752, 19787);

                f_1332_19752_19786();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 19803, 19871);

                Pipe
                oldErrorOutputPipe = f_1332_19829_19870(f_1332_19829_19841(this))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 20013, 20052);

                PSLanguageMode?
                oldLanguageMode = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 20066, 20105);

                PSLanguageMode?
                newLanguageMode = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 20119, 20381) || true) && ((f_1332_20124_20158(f_1332_20124_20149(_scriptBlock))) && (DynAbs.Tracing.TraceSender.Expression_True(1332, 20123, 20231) && (f_1332_20181_20206(_scriptBlock) != f_1332_20210_20230(f_1332_20210_20217()))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1332, 20119, 20381);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 20265, 20304);

                    oldLanguageMode = f_1332_20283_20303(f_1332_20283_20290());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 20322, 20366);

                    newLanguageMode = f_1332_20340_20365(_scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1332, 20119, 20381);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 20433, 20511);

                    var
                    oldScopeOrigin = f_1332_20454_20510(f_1332_20454_20498(f_1332_20454_20485(f_1332_20454_20466(this))))
                    ;

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 20575, 20745);

                        f_1332_20575_20619(f_1332_20575_20606(f_1332_20575_20587(this))).ScopeOrigin =
                        (DynAbs.Tracing.TraceSender.Conditional_F1(1332, 20659, 20690) || ((this._dontUseScopeCommandOrigin && DynAbs.Tracing.TraceSender.Conditional_F2(1332, 20693, 20715)) || DynAbs.Tracing.TraceSender.Conditional_F3(1332, 20718, 20744))) ? CommandOrigin.Internal : f_1332_20718_20744(f_1332_20718_20730(this));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 20958, 21104) || true) && (f_1332_20962_20986(newLanguageMode))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1332, 20958, 21104);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 21036, 21081);

                            f_1332_21036_21043().LanguageMode = f_1332_21059_21080(newLanguageMode);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1332, 20958, 21104);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 21128, 21169);

                        bool?
                        oldLangModeTransitionStatus = null
                        ;
                        try
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 21383, 21740) || true) && (oldLanguageMode == PSLanguageMode.ConstrainedLanguage && (DynAbs.Tracing.TraceSender.Expression_True(1332, 21387, 21490) && newLanguageMode == PSLanguageMode.FullLanguage))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1332, 21383, 21740);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 21548, 21627);

                                oldLangModeTransitionStatus = f_1332_21578_21626(f_1332_21578_21585());
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 21657, 21713);

                                f_1332_21657_21664().LanguageModeTransitionInParameterBinding = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1332, 21383, 21740);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 21768, 21781);

                            f_1332_21768_21780(this);
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinally(1332, 21826, 22222);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 21882, 22199) || true) && (f_1332_21886_21922(oldLangModeTransitionStatus))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1332, 21882, 22199);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 22087, 22172);

                                f_1332_22087_22094().LanguageModeTransitionInParameterBinding = f_1332_22138_22171(oldLangModeTransitionStatus);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1332, 21882, 22199);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitFinally(1332, 21826, 22222);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 22246, 22652) || true) && (f_1332_22250_22277(commandRuntime) == MshCommandRuntime.MergeDataStream.Output)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1332, 22246, 22652);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 22371, 22424);

                            f_1332_22371_22423(f_1332_22371_22378(), f_1332_22397_22422(commandRuntime));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1332, 22246, 22652);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1332, 22246, 22652);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 22474, 22652) || true) && (f_1332_22478_22521(f_1332_22478_22508(commandRuntime)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1332, 22474, 22652);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 22571, 22629);

                                f_1332_22571_22628(f_1332_22571_22578(), f_1332_22597_22627(commandRuntime));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1332, 22474, 22652);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1332, 22246, 22652);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 22676, 23111) || true) && (dollarUnderbar != f_1332_22698_22718())
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1332, 22676, 23111);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 22768, 22856);

                            f_1332_22768_22855(_localsTuple, AutomaticVariable.Underbar, dollarUnderbar, _context);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1332, 22676, 23111);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1332, 22676, 23111);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 22906, 23111) || true) && (_dollarUnderbar != f_1332_22929_22949())
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1332, 22906, 23111);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 22999, 23088);

                                f_1332_22999_23087(_localsTuple, AutomaticVariable.Underbar, _dollarUnderbar, _context);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1332, 22906, 23111);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1332, 22676, 23111);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 23135, 23929) || true) && (inputToProcess != f_1332_23157_23177())
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1332, 23135, 23929);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 23227, 23793) || true) && (inputToProcess == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1332, 23227, 23793);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 23311, 23379);

                                inputToProcess = f_1332_23328_23378(MshCommandRuntime.StaticEmptyArray);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1332, 23227, 23793);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1332, 23227, 23793);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 23493, 23530);

                                IList
                                list = inputToProcess as IList
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 23560, 23766);

                                inputToProcess = (DynAbs.Tracing.TraceSender.Conditional_F1(1332, 23577, 23591) || (((list != null)
                                && DynAbs.Tracing.TraceSender.Conditional_F2(1332, 23644, 23664)) || DynAbs.Tracing.TraceSender.Conditional_F3(1332, 23717, 23765))) ? f_1332_23644_23664(list) : f_1332_23717_23765(inputToProcess);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1332, 23227, 23793);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 23821, 23906);

                            f_1332_23821_23905(
                                                    _localsTuple, AutomaticVariable.Input, inputToProcess, _context);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1332, 23135, 23929);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 23953, 23978);

                        f_1332_23953_23977(clause, _functionContext);
                    }
                    catch (TargetInvocationException tie)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1332, 24015, 24211);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 24167, 24192);

                        throw f_1332_24173_24191(tie);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1332, 24015, 24211);
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1332, 24229, 24609);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 24277, 24327);

                        f_1332_24277_24326(f_1332_24277_24289(this), oldErrorOutputPipe);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 24351, 24497) || true) && (f_1332_24355_24379(oldLanguageMode))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1332, 24351, 24497);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 24429, 24474);

                            f_1332_24429_24436().LanguageMode = f_1332_24452_24473(oldLanguageMode);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1332, 24351, 24497);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 24521, 24590);

                        f_1332_24521_24560(f_1332_24521_24547(f_1332_24521_24528())).ScopeOrigin = oldScopeOrigin;
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1332, 24229, 24609);
                    }
                }
                catch (ExitException ee)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1332, 24638, 25145);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 24695, 24811) || true) && (f_1332_24699_24719_M(!this.FromScriptFile) || (DynAbs.Tracing.TraceSender.Expression_False(1332, 24699, 24744) || _rethrowExitException))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1332, 24695, 24811);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 24786, 24792);

                        throw;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1332, 24695, 24811);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 24831, 24858);

                    this._exitWasCalled = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 24878, 24910);

                    int
                    exitCode = (int)f_1332_24898_24909(ee)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 24928, 25009);

                    f_1332_24928_25008(f_1332_24928_24948(f_1332_24928_24940(this)), SpecialVariables.LastExitCodeVarPath, exitCode);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 25029, 25130) || true) && (exitCode != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1332, 25029, 25130);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 25069, 25130);

                        f_1332_25069_25106(this.commandRuntime).ExecutionFailed = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1332, 25029, 25130);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1332, 24638, 25145);
                }
                catch (FlowControlException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1332, 25159, 25241);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 25220, 25226);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1332, 25159, 25241);
                }
                catch (RuntimeException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1332, 25255, 25512);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 25314, 25339);

                    f_1332_25314_25338(this, e);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 25491, 25497);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1332, 25255, 25512);
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1332, 25526, 25729);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 25679, 25714);

                    throw f_1332_25685_25713(this, e);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1332, 25526, 25729);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1332, 19627, 25740);

                int
                f_1332_19752_19786()
                {
                    ExecutionContext.CheckStackDepth();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 19752, 19786);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1332_19829_19841(System.Management.Automation.DlrScriptCommandProcessor
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 19829, 19841);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1332_19829_19870(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ShellFunctionErrorOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 19829, 19870);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode?
                f_1332_20124_20149(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 20124, 20149);
                    return return_v;
                }


                bool
                f_1332_20124_20158(System.Management.Automation.PSLanguageMode?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 20124, 20158);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode?
                f_1332_20181_20206(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 20181, 20206);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1332_20210_20217()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 20210, 20217);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1332_20210_20230(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 20210, 20230);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1332_20283_20290()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 20283, 20290);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1332_20283_20303(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 20283, 20303);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode?
                f_1332_20340_20365(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 20340, 20365);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1332_20454_20466(System.Management.Automation.DlrScriptCommandProcessor
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 20454, 20466);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1332_20454_20485(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 20454, 20485);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1332_20454_20498(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 20454, 20498);
                    return return_v;
                }


                System.Management.Automation.CommandOrigin
                f_1332_20454_20510(System.Management.Automation.SessionStateScope
                this_param)
                {
                    var return_v = this_param.ScopeOrigin;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 20454, 20510);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1332_20575_20587(System.Management.Automation.DlrScriptCommandProcessor
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 20575, 20587);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1332_20575_20606(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 20575, 20606);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1332_20575_20619(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 20575, 20619);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1332_20718_20730(System.Management.Automation.DlrScriptCommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 20718, 20730);
                    return return_v;
                }


                System.Management.Automation.CommandOrigin
                f_1332_20718_20744(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.CommandOrigin;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 20718, 20744);
                    return return_v;
                }


                bool
                f_1332_20962_20986(System.Management.Automation.PSLanguageMode?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 20962, 20986);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1332_21036_21043()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 21036, 21043);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1332_21059_21080(System.Management.Automation.PSLanguageMode?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 21059, 21080);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1332_21578_21585()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 21578, 21585);
                    return return_v;
                }


                bool
                f_1332_21578_21626(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.LanguageModeTransitionInParameterBinding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 21578, 21626);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1332_21657_21664()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 21657, 21664);
                    return return_v;
                }


                int
                f_1332_21768_21780(System.Management.Automation.DlrScriptCommandProcessor
                this_param)
                {
                    this_param.EnterScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 21768, 21780);
                    return 0;
                }


                bool
                f_1332_21886_21922(bool?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 21886, 21922);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1332_22087_22094()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 22087, 22094);
                    return return_v;
                }


                bool
                f_1332_22138_22171(bool?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 22138, 22171);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime.MergeDataStream
                f_1332_22250_22277(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.ErrorMergeTo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 22250, 22277);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1332_22371_22378()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 22371, 22378);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1332_22397_22422(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.OutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 22397, 22422);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1332_22371_22423(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.Internal.Pipe
                newPipe)
                {
                    var return_v = this_param.RedirectErrorPipe(newPipe);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 22371, 22423);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1332_22478_22508(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.ErrorOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 22478, 22508);
                    return return_v;
                }


                bool
                f_1332_22478_22521(System.Management.Automation.Internal.Pipe
                this_param)
                {
                    var return_v = this_param.IsRedirected;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 22478, 22521);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1332_22571_22578()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 22571, 22578);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1332_22597_22627(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.ErrorOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 22597, 22627);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1332_22571_22628(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.Internal.Pipe
                newPipe)
                {
                    var return_v = this_param.RedirectErrorPipe(newPipe);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 22571, 22628);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1332_22698_22718()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 22698, 22718);
                    return return_v;
                }


                int
                f_1332_22768_22855(System.Management.Automation.MutableTuple
                this_param, System.Management.Automation.AutomaticVariable
                auto, object
                value, System.Management.Automation.ExecutionContext
                context)
                {
                    this_param.SetAutomaticVariable(auto, value, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 22768, 22855);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1332_22929_22949()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 22929, 22949);
                    return return_v;
                }


                int
                f_1332_22999_23087(System.Management.Automation.MutableTuple
                this_param, System.Management.Automation.AutomaticVariable
                auto, object
                value, System.Management.Automation.ExecutionContext
                context)
                {
                    this_param.SetAutomaticVariable(auto, value, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 22999, 23087);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1332_23157_23177()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 23157, 23177);
                    return return_v;
                }


                System.Collections.IEnumerator
                f_1332_23328_23378(object[]
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 23328, 23378);
                    return return_v;
                }


                System.Collections.IEnumerator
                f_1332_23644_23664(System.Collections.IList
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 23644, 23664);
                    return return_v;
                }


                System.Collections.IEnumerator
                f_1332_23717_23765(object
                obj)
                {
                    var return_v = LanguagePrimitives.GetEnumerator(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 23717, 23765);
                    return return_v;
                }


                int
                f_1332_23821_23905(System.Management.Automation.MutableTuple
                this_param, System.Management.Automation.AutomaticVariable
                auto, object
                value, System.Management.Automation.ExecutionContext
                context)
                {
                    this_param.SetAutomaticVariable(auto, value, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 23821, 23905);
                    return 0;
                }


                int
                f_1332_23953_23977(System.Action<System.Management.Automation.Language.FunctionContext>
                this_param, System.Management.Automation.Language.FunctionContext
                obj)
                {
                    this_param.Invoke(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 23953, 23977);
                    return 0;
                }


                System.Exception
                f_1332_24173_24191(System.Reflection.TargetInvocationException
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 24173, 24191);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1332_24277_24289(System.Management.Automation.DlrScriptCommandProcessor
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 24277, 24289);
                    return return_v;
                }


                int
                f_1332_24277_24326(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.Internal.Pipe
                pipe)
                {
                    this_param.RestoreErrorPipe(pipe);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 24277, 24326);
                    return 0;
                }


                bool
                f_1332_24355_24379(System.Management.Automation.PSLanguageMode?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 24355, 24379);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1332_24429_24436()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 24429, 24436);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1332_24452_24473(System.Management.Automation.PSLanguageMode?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 24452, 24473);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1332_24521_24528()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 24521, 24528);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1332_24521_24547(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 24521, 24547);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1332_24521_24560(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 24521, 24560);
                    return return_v;
                }


                bool
                f_1332_24699_24719_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 24699, 24719);
                    return return_v;
                }


                object
                f_1332_24898_24909(System.Management.Automation.ExitException
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 24898, 24909);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1332_24928_24940(System.Management.Automation.DlrScriptCommandProcessor
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 24928, 24940);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1332_24928_24948(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 24928, 24948);
                    return return_v;
                }


                int
                f_1332_24928_25008(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.VariablePath
                path, int
                newValue)
                {
                    this_param.SetVariable(path, (object)newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 24928, 25008);
                    return 0;
                }


                System.Management.Automation.Internal.PipelineProcessor
                f_1332_25069_25106(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.PipelineProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 25069, 25106);
                    return return_v;
                }


                int
                f_1332_25314_25338(System.Management.Automation.DlrScriptCommandProcessor
                this_param, System.Management.Automation.RuntimeException
                e)
                {
                    this_param.ManageScriptException(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 25314, 25338);
                    return 0;
                }


                System.Management.Automation.PipelineStoppedException
                f_1332_25685_25713(System.Management.Automation.DlrScriptCommandProcessor
                this_param, System.Exception
                e)
                {
                    var return_v = this_param.ManageInvocationException(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 25685, 25713);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1332, 19627, 25740);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1332, 19627, 25740);
            }
        }

        private void EnterScope()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1332, 25752, 26446);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 25802, 26435) || true) && (!_argsBound)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1332, 25802, 26435);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 25851, 25869);

                    _argsBound = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 25985, 26172);
                    using (f_1332_25992_26037(commandRuntime, false))
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 26079, 26153);

                        f_1332_26079_26152(f_1332_26079_26115(this), arguments);
                        DynAbs.Tracing.TraceSender.TraceExitUsing(1332, 25985, 26172);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 26192, 26420);

                    f_1332_26192_26419(
                                    _localsTuple, AutomaticVariable.PSBoundParameters, f_1332_26314_26408(f_1332_26314_26372(f_1332_26314_26350(this))), _context);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1332, 25802, 26435);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1332, 25752, 26446);

                System.IDisposable
                f_1332_25992_26037(System.Management.Automation.MshCommandRuntime
                this_param, bool
                permittedToWriteToPipeline)
                {
                    var return_v = this_param.AllowThisCommandToWrite(permittedToWriteToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 25992, 26037);
                    return return_v;
                }


                System.Management.Automation.ScriptParameterBinderController
                f_1332_26079_26115(System.Management.Automation.DlrScriptCommandProcessor
                this_param)
                {
                    var return_v = this_param.ScriptParameterBinderController;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 26079, 26115);
                    return return_v;
                }


                int
                f_1332_26079_26152(System.Management.Automation.ScriptParameterBinderController
                this_param, System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                arguments)
                {
                    this_param.BindCommandLineParameters(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 26079, 26152);
                    return 0;
                }


                System.Management.Automation.ScriptParameterBinderController
                f_1332_26314_26350(System.Management.Automation.DlrScriptCommandProcessor
                this_param)
                {
                    var return_v = this_param.ScriptParameterBinderController;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 26314, 26350);
                    return return_v;
                }


                System.Management.Automation.CommandLineParameters
                f_1332_26314_26372(System.Management.Automation.ScriptParameterBinderController
                this_param)
                {
                    var return_v = this_param.CommandLineParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 26314, 26372);
                    return return_v;
                }


                object
                f_1332_26314_26408(System.Management.Automation.CommandLineParameters
                this_param)
                {
                    var return_v = this_param.GetValueToBindToPSBoundParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 26314, 26408);
                    return return_v;
                }


                int
                f_1332_26192_26419(System.Management.Automation.MutableTuple
                this_param, System.Management.Automation.AutomaticVariable
                auto, object
                value, System.Management.Automation.ExecutionContext
                context)
                {
                    this_param.SetAutomaticVariable(auto, value, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 26192, 26419);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1332, 25752, 26446);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1332, 25752, 26446);
            }
        }

        protected override void OnSetCurrentScope()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1332, 26458, 26807);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 26664, 26796) || true) && (f_1332_26668_26682_M(!UseLocalScope))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1332, 26664, 26796);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 26716, 26781);

                    f_1332_26716_26780(f_1332_26716_26761(f_1332_26716_26748(f_1332_26716_26735())), _localsTuple);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1332, 26664, 26796);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1332, 26458, 26807);

                bool
                f_1332_26668_26682_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 26668, 26682);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1332_26716_26735()
                {
                    var return_v = CommandSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 26716, 26735);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1332_26716_26748(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 26716, 26748);
                    return return_v;
                }


                System.Collections.Generic.Stack<System.Management.Automation.MutableTuple>
                f_1332_26716_26761(System.Management.Automation.SessionStateScope
                this_param)
                {
                    var return_v = this_param.DottedScopes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 26716, 26761);
                    return return_v;
                }


                int
                f_1332_26716_26780(System.Collections.Generic.Stack<System.Management.Automation.MutableTuple>
                this_param, System.Management.Automation.MutableTuple
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 26716, 26780);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1332, 26458, 26807);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1332, 26458, 26807);
            }
        }

        protected override void OnRestorePreviousScope()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1332, 26819, 27161);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 27031, 27150) || true) && (f_1332_27035_27049_M(!UseLocalScope))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1332, 27031, 27150);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1332, 27083, 27135);

                    f_1332_27083_27134(f_1332_27083_27128(f_1332_27083_27115(f_1332_27083_27102())));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1332, 27031, 27150);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1332, 26819, 27161);

                bool
                f_1332_27035_27049_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 27035, 27049);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1332_27083_27102()
                {
                    var return_v = CommandSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 27083, 27102);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1332_27083_27115(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 27083, 27115);
                    return return_v;
                }


                System.Collections.Generic.Stack<System.Management.Automation.MutableTuple>
                f_1332_27083_27128(System.Management.Automation.SessionStateScope
                this_param)
                {
                    var return_v = this_param.DottedScopes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 27083, 27128);
                    return return_v;
                }


                System.Management.Automation.MutableTuple
                f_1332_27083_27134(System.Collections.Generic.Stack<System.Management.Automation.MutableTuple>
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 27083, 27134);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1332, 26819, 27161);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1332, 26819, 27161);
            }
        }

        static DlrScriptCommandProcessor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1332, 10280, 27168);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1332, 10280, 27168);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1332, 10280, 27168);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1332, 10280, 27168);

        System.Collections.ArrayList
        f_1332_10409_10424()
        {
            var return_v = new System.Collections.ArrayList();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 10409, 10424);
            return return_v;
        }


        System.Management.Automation.PSObject
        f_1332_10477_10497()
        {
            var return_v = AutomationNull.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1332, 10477, 10497);
            return return_v;
        }


        int
        f_1332_11012_11018(System.Management.Automation.DlrScriptCommandProcessor
        this_param)
        {
            this_param.Init();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 11012, 11018);
            return 0;
        }


        static System.Management.Automation.ScriptBlock
        f_1332_10931_10942_C(System.Management.Automation.ScriptBlock
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1332, 10727, 11077);
            return return_v;
        }


        int
        f_1332_11351_11357(System.Management.Automation.DlrScriptCommandProcessor
        this_param)
        {
            this_param.Init();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 11351, 11357);
            return 0;
        }


        static System.Management.Automation.ScriptBlock
        f_1332_11270_11281_C(System.Management.Automation.ScriptBlock
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1332, 11089, 11369);
            return return_v;
        }


        int
        f_1332_11616_11622(System.Management.Automation.DlrScriptCommandProcessor
        this_param)
        {
            this_param.Init();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 11616, 11622);
            return 0;
        }


        static System.Management.Automation.IScriptCommandInfo
        f_1332_11542_11554_C(System.Management.Automation.IScriptCommandInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1332, 11381, 11634);
            return return_v;
        }


        int
        f_1332_11875_11881(System.Management.Automation.DlrScriptCommandProcessor
        this_param)
        {
            this_param.Init();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 11875, 11881);
            return 0;
        }


        static System.Management.Automation.IScriptCommandInfo
        f_1332_11803_11813_C(System.Management.Automation.IScriptCommandInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1332, 11646, 11893);
            return return_v;
        }


        int
        f_1332_12142_12148(System.Management.Automation.DlrScriptCommandProcessor
        this_param)
        {
            this_param.Init();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1332, 12142, 12148);
            return 0;
        }


        static System.Management.Automation.IScriptCommandInfo
        f_1332_12070_12080_C(System.Management.Automation.IScriptCommandInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1332, 11905, 12160);
            return return_v;
        }

    }
}
