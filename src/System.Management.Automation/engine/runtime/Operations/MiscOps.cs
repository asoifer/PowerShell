// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management.Automation.Host;
using System.Management.Automation.Internal;
using System.Management.Automation.Internal.Host;
using System.Management.Automation.Language;
using System.Management.Automation.Runspaces;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

using Microsoft.PowerShell.Commands;
using Microsoft.PowerShell.Commands.Internal.Format;

// ReSharper disable UnusedMember.Global

namespace System.Management.Automation
{
    internal static class PipelineOps
    {
        private static CommandProcessorBase AddCommand(PipelineProcessor pipe,
                                                               CommandParameterInternal[] commandElements,
                                                               CommandBaseAst commandBaseAst,
                                                               CommandRedirection[] redirections,
                                                               ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 881, 14514);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 1336, 1382);

                var
                commandAst = commandBaseAst as CommandAst
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 1396, 1489);

                var
                invocationToken = (DynAbs.Tracing.TraceSender.Conditional_F1(1664, 1418, 1436) || ((commandAst != null && DynAbs.Tracing.TraceSender.Conditional_F2(1664, 1439, 1468)) || DynAbs.Tracing.TraceSender.Conditional_F3(1664, 1471, 1488))) ? f_1664_1439_1468(commandAst) : TokenKind.Unknown
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 1503, 1553);

                bool
                dotSource = invocationToken == TokenKind.Dot
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 1567, 1615);

                SessionStateInternal
                commandSessionState = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 1629, 1650);

                int
                commandIndex = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 1666, 1840);

                f_1664_1666_1839(f_1664_1685_1721(commandElements[0]) && (DynAbs.Tracing.TraceSender.Expression_True(1664, 1685, 1767) && f_1664_1725_1767_M(!commandElements[0].ParameterNameSpecified)), "Compiler will pass first parameter as an argument.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 1854, 1927);

                var
                mi = f_1664_1863_1910(f_1664_1877_1909(commandElements[0])) as PSModuleInfo
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 1941, 3508) || true) && (mi != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 1941, 3508);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 1989, 3390) || true) && (f_1664_1993_2006(mi) == ModuleType.Binary && (DynAbs.Tracing.TraceSender.Expression_True(1664, 1993, 2054) && f_1664_2031_2046(mi) == null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 1989, 3390);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 2096, 2283);

                        throw f_1664_2102_2282(null, typeof(RuntimeException), null, "CantInvokeInBinaryModule", f_1664_2234_2272(), f_1664_2274_2281(mi));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 1989, 3390);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 1989, 3390);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 2325, 3390) || true) && (f_1664_2329_2344(mi) == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 2325, 3390);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 2394, 2591);

                            throw f_1664_2400_2590(null, typeof(RuntimeException), null, "CantInvokeInNonImportedModule", f_1664_2537_2580(), f_1664_2582_2589(mi));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 2325, 3390);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 2325, 3390);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 2633, 3390) || true) && (((invocationToken == TokenKind.Ampersand) || (DynAbs.Tracing.TraceSender.Expression_False(1664, 2638, 2716) || (invocationToken == TokenKind.Dot))) && (DynAbs.Tracing.TraceSender.Expression_True(1664, 2637, 2762) && (f_1664_2722_2737(mi) != f_1664_2741_2761(context))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 2633, 3390);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 3149, 3371);

                                throw f_1664_3155_3370(null, typeof(RuntimeException), null, "CantInvokeCallOperatorAcrossLanguageBoundaries", f_1664_3309_3369());
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 2633, 3390);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 2325, 3390);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 1989, 3390);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 3410, 3457);

                    commandSessionState = f_1664_3432_3456(f_1664_3432_3447(mi));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 3475, 3493);

                    commandIndex += 1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 1941, 3508);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 3524, 3539);

                object
                command
                = default(object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 3553, 3581);

                IScriptExtent
                commandExtent
                = default(IScriptExtent);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 3595, 3642);

                var
                cpiCommand = commandElements[commandIndex]
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 3656, 4391) || true) && (f_1664_3660_3693(cpiCommand))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 3656, 4391);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 3727, 3762);

                    command = f_1664_3737_3761(cpiCommand);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 3780, 3823);

                    commandExtent = f_1664_3796_3822(cpiCommand);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 3841, 4200) || true) && (f_1664_3845_3873(cpiCommand))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 3841, 4200);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 3841, 4200);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 3656, 4391);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 3656, 4391);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 4266, 4316);

                    command = f_1664_4276_4315(f_1664_4290_4314(cpiCommand));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 4334, 4376);

                    commandExtent = f_1664_4350_4375(cpiCommand);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 3656, 4391);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 4407, 4503);

                string
                invocationName = (DynAbs.Tracing.TraceSender.Conditional_F1(1664, 4431, 4442) || (((dotSource) && DynAbs.Tracing.TraceSender.Conditional_F2(1664, 4445, 4448)) || DynAbs.Tracing.TraceSender.Conditional_F3(1664, 4451, 4502))) ? "." : (DynAbs.Tracing.TraceSender.Conditional_F1(1664, 4451, 4489) || ((invocationToken == TokenKind.Ampersand && DynAbs.Tracing.TraceSender.Conditional_F2(1664, 4492, 4495)) || DynAbs.Tracing.TraceSender.Conditional_F3(1664, 4498, 4502))) ? "&" : null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 4517, 4555);

                CommandProcessorBase
                commandProcessor
                = default(CommandProcessorBase);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 4569, 4610);

                var
                scriptBlock = command as ScriptBlock
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 4624, 7763) || true) && (scriptBlock != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 4624, 7763);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 4681, 4804);

                    commandProcessor = f_1664_4700_4803(scriptBlock, context, !dotSource, commandSessionState);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 4624, 7763);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 4624, 7763);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 4870, 4911);

                    var
                    commandInfo = command as CommandInfo
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 4929, 7748) || true) && (commandInfo != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 4929, 7748);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 4994, 5160);

                        commandProcessor = f_1664_5013_5159(f_1664_5013_5037(context), commandInfo, f_1664_5074_5125(f_1664_5074_5113(f_1664_5074_5100(context))), !dotSource, commandSessionState);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 4929, 7748);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 4929, 7748);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 5242, 5323);

                        var
                        commandName = command as string ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1664, 5260, 5322) ?? f_1664_5281_5322(context, command))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 5345, 5392);

                        invocationName = invocationName ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1664, 5362, 5391) ?? commandName);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 5416, 5867) || true) && (f_1664_5420_5453(commandName))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 5416, 5867);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 5503, 5844);

                            throw f_1664_5509_5843(command, typeof(RuntimeException), commandExtent, "BadExpression", f_1664_5763_5790(), (DynAbs.Tracing.TraceSender.Conditional_F1(1664, 5821, 5830) || ((dotSource && DynAbs.Tracing.TraceSender.Conditional_F2(1664, 5833, 5836)) || DynAbs.Tracing.TraceSender.Conditional_F3(1664, 5839, 5842))) ? "." : "&");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 5416, 5867);
                        }

                        try
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 6224, 7040) || true) && (commandSessionState != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 6224, 7040);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 6313, 6379);

                                SessionStateInternal
                                oldSessionState = f_1664_6352_6378(context)
                                ;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 6477, 6526);

                                    context.EngineSessionState = commandSessionState;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 6560, 6625);

                                    commandProcessor = f_1664_6579_6624(context, commandName, dotSource);
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1664, 6686, 6834);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 6758, 6803);

                                    context.EngineSessionState = oldSessionState;
                                    DynAbs.Tracing.TraceSender.TraceExitFinally(1664, 6686, 6834);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 6224, 7040);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 6224, 7040);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 6948, 7013);

                                commandProcessor = f_1664_6967_7012(context, commandName, dotSource);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 6224, 7040);
                            }
                        }
                        catch (RuntimeException rte)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1664, 7085, 7729);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 7319, 7672) || true) && (f_1664_7323_7353(f_1664_7323_7338(rte)) == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 7319, 7672);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 7419, 7565);

                                InvocationInfo
                                invocationInfo = new InvocationInfo(null, commandExtent, context)
                                { InvocationName = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => invocationName, 1664, 7451, 7564) }
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 7595, 7645);

                                f_1664_7595_7644(f_1664_7595_7610(rte), invocationInfo);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 7319, 7672);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 7700, 7706);

                            throw;
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1664, 7085, 7729);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 4929, 7748);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 4624, 7763);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 7779, 7826);

                InternalCommand
                cmd = f_1664_7801_7825(commandProcessor)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 7840, 7981);

                commandProcessor.UseLocalScope = !dotSource && (DynAbs.Tracing.TraceSender.Expression_True(1664, 7873, 7980) && (cmd is ScriptCommand || (DynAbs.Tracing.TraceSender.Expression_False(1664, 7934, 7979) || cmd is PSScriptCmdlet)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 7997, 8063);

                bool
                isNativeCommand = commandProcessor is NativeCommandProcessor
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 8086, 8106);
                    for (int
        i = commandIndex + 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 8077, 9007) || true) && (i < f_1664_8112_8134(commandElements))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 8136, 8139)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 8077, 9007))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 8077, 9007);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 8173, 8202);

                        var
                        cpi = commandElements[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 8222, 8585) || true) && (f_1664_8226_8252(cpi))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 8222, 8585);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 8395, 8566) || true) && (f_1664_8399_8464(f_1664_8399_8416(cpi), "-", StringComparison.OrdinalIgnoreCase) && (DynAbs.Tracing.TraceSender.Expression_True(1664, 8399, 8484) && !isNativeCommand))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 8395, 8566);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 8534, 8543);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 8395, 8566);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 8222, 8585);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 8605, 8992) || true) && (f_1664_8609_8629(cpi))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 8605, 8992);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 8671, 8856);
                                foreach (var splattedCpi in f_1664_8699_8740_I(f_1664_8699_8740(f_1664_8705_8722(cpi), f_1664_8724_8739(cpi))))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 8671, 8856);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 8790, 8833);

                                    f_1664_8790_8832(commandProcessor, splattedCpi);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 8671, 8856);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 1, 186);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 1, 186);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 8605, 8992);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 8605, 8992);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 8938, 8973);

                            f_1664_8938_8972(commandProcessor, cpi);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 8605, 8992);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 1, 931);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 1, 931);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 9023, 9041);

                string
                helpTarget
                = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 9055, 9081);

                HelpCategory
                helpCategory
                = default(HelpCategory);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 9095, 9319) || true) && (f_1664_9099_9165(commandProcessor, out helpTarget, out helpCategory))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 9095, 9319);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 9199, 9304);

                    commandProcessor = f_1664_9218_9303(context, helpTarget, helpCategory);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 9095, 9319);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 9335, 9401);

                f_1664_9335_9359(commandProcessor).InvocationExtent = f_1664_9379_9400(commandBaseAst);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 9415, 9492);

                f_1664_9415_9452(f_1664_9415_9439(commandProcessor)).ScriptPosition = f_1664_9470_9491(commandBaseAst);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 9506, 9576);

                f_1664_9506_9543(f_1664_9506_9530(commandProcessor)).InvocationName = invocationName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 9592, 9619);

                f_1664_9592_9618(
                            pipe, commandProcessor);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 9635, 9664);

                bool
                redirectedError = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 9678, 9709);

                bool
                redirectedWarning = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 9723, 9754);

                bool
                redirectedVerbose = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 9768, 9797);

                bool
                redirectedDebug = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 9811, 9846);

                bool
                redirectedInformation = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 9860, 11297) || true) && (redirections != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 9860, 11297);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 9918, 11282);
                        foreach (var redirection in f_1664_9946_9958_I(redirections))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 9918, 11282);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 10000, 10050);

                            f_1664_10000_10049(redirection, pipe, commandProcessor, context);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 10072, 11263);

                            switch (f_1664_10080_10102(redirection))
                            {

                                case RedirectionStream.Error:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 10072, 11263);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 10211, 10234);

                                    redirectedError = true;
                                    DynAbs.Tracing.TraceSender.TraceBreak(1664, 10264, 10270);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 10072, 11263);

                                case RedirectionStream.Warning:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 10072, 11263);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 10359, 10384);

                                    redirectedWarning = true;
                                    DynAbs.Tracing.TraceSender.TraceBreak(1664, 10414, 10420);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 10072, 11263);

                                case RedirectionStream.Verbose:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 10072, 11263);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 10509, 10534);

                                    redirectedVerbose = true;
                                    DynAbs.Tracing.TraceSender.TraceBreak(1664, 10564, 10570);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 10072, 11263);

                                case RedirectionStream.Debug:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 10072, 11263);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 10657, 10680);

                                    redirectedDebug = true;
                                    DynAbs.Tracing.TraceSender.TraceBreak(1664, 10710, 10716);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 10072, 11263);

                                case RedirectionStream.Information:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 10072, 11263);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 10809, 10838);

                                    redirectedInformation = true;
                                    DynAbs.Tracing.TraceSender.TraceBreak(1664, 10868, 10874);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 10072, 11263);

                                case RedirectionStream.All:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 10072, 11263);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 10959, 10982);

                                    redirectedError = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 11012, 11037);

                                    redirectedWarning = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 11067, 11092);

                                    redirectedVerbose = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 11122, 11145);

                                    redirectedDebug = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 11175, 11204);

                                    redirectedInformation = true;
                                    DynAbs.Tracing.TraceSender.TraceBreak(1664, 11234, 11240);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 10072, 11263);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 9918, 11282);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 1, 1365);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 1, 1365);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 9860, 11297);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 11400, 11840) || true) && (!redirectedError)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 11400, 11840);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 11454, 11825) || true) && (f_1664_11458_11494(context) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 11454, 11825);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 11544, 11631);

                        f_1664_11544_11575(commandProcessor).ErrorOutputPipe = f_1664_11594_11630(context);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 11454, 11825);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 11454, 11825);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 11713, 11806);

                        f_1664_11713_11760(f_1664_11713_11744(commandProcessor)).ExternalWriter = f_1664_11778_11805(context);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 11454, 11825);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 11400, 11840);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 11856, 12107) || true) && (!redirectedWarning && (DynAbs.Tracing.TraceSender.Expression_True(1664, 11860, 11927) && (f_1664_11883_11918(context) != null)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 11856, 12107);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 11961, 12049);

                    f_1664_11961_11992(commandProcessor).WarningOutputPipe = f_1664_12013_12048(context);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 12067, 12092);

                    redirectedWarning = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 11856, 12107);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 12123, 12374) || true) && (!redirectedVerbose && (DynAbs.Tracing.TraceSender.Expression_True(1664, 12127, 12194) && (f_1664_12150_12185(context) != null)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 12123, 12374);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 12228, 12316);

                    f_1664_12228_12259(commandProcessor).VerboseOutputPipe = f_1664_12280_12315(context);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 12334, 12359);

                    redirectedVerbose = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 12123, 12374);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 12390, 12631) || true) && (!redirectedDebug && (DynAbs.Tracing.TraceSender.Expression_True(1664, 12394, 12457) && (f_1664_12415_12448(context) != null)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 12390, 12631);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 12491, 12575);

                    f_1664_12491_12522(commandProcessor).DebugOutputPipe = f_1664_12541_12574(context);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 12593, 12616);

                    redirectedDebug = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 12390, 12631);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 12647, 12918) || true) && (!redirectedInformation && (DynAbs.Tracing.TraceSender.Expression_True(1664, 12651, 12726) && (f_1664_12678_12717(context) != null)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 12647, 12918);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 12760, 12856);

                    f_1664_12760_12791(commandProcessor).InformationOutputPipe = f_1664_12816_12855(context);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 12874, 12903);

                    redirectedInformation = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 12647, 12918);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 13057, 14463) || true) && (f_1664_13061_13092(context) != null && (DynAbs.Tracing.TraceSender.Expression_True(1664, 13061, 13158) && f_1664_13104_13150(f_1664_13104_13135(context)) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 13057, 14463);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 13192, 13489) || true) && (!redirectedWarning && (DynAbs.Tracing.TraceSender.Expression_True(1664, 13196, 13311) && f_1664_13239_13303(f_1664_13239_13285(f_1664_13239_13270(context))) != null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 13192, 13489);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 13353, 13470);

                        f_1664_13353_13384(commandProcessor).WarningOutputPipe = f_1664_13405_13469(f_1664_13405_13451(f_1664_13405_13436(context)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 13192, 13489);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 13509, 13806) || true) && (!redirectedVerbose && (DynAbs.Tracing.TraceSender.Expression_True(1664, 13513, 13628) && f_1664_13556_13620(f_1664_13556_13602(f_1664_13556_13587(context))) != null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 13509, 13806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 13670, 13787);

                        f_1664_13670_13701(commandProcessor).VerboseOutputPipe = f_1664_13722_13786(f_1664_13722_13768(f_1664_13722_13753(context)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 13509, 13806);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 13826, 14115) || true) && (!redirectedDebug && (DynAbs.Tracing.TraceSender.Expression_True(1664, 13830, 13941) && f_1664_13871_13933(f_1664_13871_13917(f_1664_13871_13902(context))) != null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 13826, 14115);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 13983, 14096);

                        f_1664_13983_14014(commandProcessor).DebugOutputPipe = f_1664_14033_14095(f_1664_14033_14079(f_1664_14033_14064(context)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 13826, 14115);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 14135, 14448) || true) && (!redirectedInformation && (DynAbs.Tracing.TraceSender.Expression_True(1664, 14139, 14262) && f_1664_14186_14254(f_1664_14186_14232(f_1664_14186_14217(context))) != null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 14135, 14448);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 14304, 14429);

                        f_1664_14304_14335(commandProcessor).InformationOutputPipe = f_1664_14360_14428(f_1664_14360_14406(f_1664_14360_14391(context)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 14135, 14448);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 13057, 14463);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 14479, 14503);

                return commandProcessor;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 881, 14514);

                System.Management.Automation.Language.TokenKind
                f_1664_1439_1468(System.Management.Automation.Language.CommandAst
                this_param)
                {
                    var return_v = this_param.InvocationOperator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 1439, 1468);
                    return return_v;
                }


                bool
                f_1664_1685_1721(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ArgumentSpecified;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 1685, 1721);
                    return return_v;
                }


                bool
                f_1664_1725_1767_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 1725, 1767);
                    return return_v;
                }


                int
                f_1664_1666_1839(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 1666, 1839);
                    return 0;
                }


                object
                f_1664_1877_1909(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ArgumentValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 1877, 1909);
                    return return_v;
                }


                object
                f_1664_1863_1910(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 1863, 1910);
                    return return_v;
                }


                System.Management.Automation.ModuleType
                f_1664_1993_2006(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.ModuleType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 1993, 2006);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1664_2031_2046(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 2031, 2046);
                    return return_v;
                }


                string
                f_1664_2234_2272()
                {
                    var return_v = ParserStrings.CantInvokeInBinaryModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 2234, 2272);
                    return return_v;
                }


                string
                f_1664_2274_2281(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 2274, 2281);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1664_2102_2282(object
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException(targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 2102, 2282);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1664_2329_2344(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 2329, 2344);
                    return return_v;
                }


                string
                f_1664_2537_2580()
                {
                    var return_v = ParserStrings.CantInvokeInNonImportedModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 2537, 2580);
                    return return_v;
                }


                string
                f_1664_2582_2589(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 2582, 2589);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1664_2400_2590(object
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException(targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 2400, 2590);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode?
                f_1664_2722_2737(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 2722, 2737);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1664_2741_2761(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 2741, 2761);
                    return return_v;
                }


                string
                f_1664_3309_3369()
                {
                    var return_v = ParserStrings.CantInvokeCallOperatorAcrossLanguageBoundaries;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 3309, 3369);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1664_3155_3370(object
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException(targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 3155, 3370);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1664_3432_3447(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 3432, 3447);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1664_3432_3456(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 3432, 3456);
                    return return_v;
                }


                bool
                f_1664_3660_3693(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ParameterNameSpecified;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 3660, 3693);
                    return return_v;
                }


                string
                f_1664_3737_3761(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ParameterText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 3737, 3761);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1664_3796_3822(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ParameterExtent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 3796, 3822);
                    return return_v;
                }


                bool
                f_1664_3845_3873(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ArgumentSpecified;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 3845, 3873);
                    return return_v;
                }


                object
                f_1664_4290_4314(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ArgumentValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 4290, 4314);
                    return return_v;
                }


                object
                f_1664_4276_4315(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 4276, 4315);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1664_4350_4375(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ArgumentExtent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 4350, 4375);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1664_4700_4803(System.Management.Automation.ScriptBlock
                scriptblock, System.Management.Automation.ExecutionContext
                context, bool
                useNewScope, System.Management.Automation.SessionStateInternal
                sessionState)
                {
                    var return_v = CommandDiscovery.CreateCommandProcessorForScript(scriptblock, context, useNewScope, sessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 4700, 4803);
                    return return_v;
                }


                System.Management.Automation.CommandDiscovery
                f_1664_5013_5037(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CommandDiscovery;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 5013, 5037);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1664_5074_5100(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 5074, 5100);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1664_5074_5113(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 5074, 5113);
                    return return_v;
                }


                System.Management.Automation.CommandOrigin
                f_1664_5074_5125(System.Management.Automation.SessionStateScope
                this_param)
                {
                    var return_v = this_param.ScopeOrigin;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 5074, 5125);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1664_5013_5159(System.Management.Automation.CommandDiscovery
                this_param, System.Management.Automation.CommandInfo
                commandInfo, System.Management.Automation.CommandOrigin
                commandOrigin, bool
                useLocalScope, System.Management.Automation.SessionStateInternal
                sessionState)
                {
                    var return_v = this_param.LookupCommandProcessor(commandInfo, commandOrigin, (bool?)useLocalScope, sessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 5013, 5159);
                    return return_v;
                }


                string
                f_1664_5281_5322(System.Management.Automation.ExecutionContext
                context, object
                obj)
                {
                    var return_v = PSObject.ToStringParser(context, obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 5281, 5322);
                    return return_v;
                }


                bool
                f_1664_5420_5453(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 5420, 5453);
                    return return_v;
                }


                string
                f_1664_5763_5790()
                {
                    var return_v = ParserStrings.BadExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 5763, 5790);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1664_5509_5843(object
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException(targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 5509, 5843);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1664_6352_6378(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 6352, 6378);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1664_6579_6624(System.Management.Automation.ExecutionContext
                this_param, string
                command, bool
                dotSource)
                {
                    var return_v = this_param.CreateCommand(command, dotSource);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 6579, 6624);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1664_6967_7012(System.Management.Automation.ExecutionContext
                this_param, string
                command, bool
                dotSource)
                {
                    var return_v = this_param.CreateCommand(command, dotSource);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 6967, 7012);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1664_7323_7338(System.Management.Automation.RuntimeException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 7323, 7338);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1664_7323_7353(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 7323, 7353);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1664_7595_7610(System.Management.Automation.RuntimeException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 7595, 7610);
                    return return_v;
                }


                int
                f_1664_7595_7644(System.Management.Automation.ErrorRecord
                this_param, System.Management.Automation.InvocationInfo
                invocationInfo)
                {
                    this_param.SetInvocationInfo(invocationInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 7595, 7644);
                    return 0;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1664_7801_7825(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 7801, 7825);
                    return return_v;
                }


                int
                f_1664_8112_8134(System.Management.Automation.CommandParameterInternal[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 8112, 8134);
                    return return_v;
                }


                bool
                f_1664_8226_8252(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ParameterNameSpecified;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 8226, 8252);
                    return return_v;
                }


                string
                f_1664_8399_8416(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 8399, 8416);
                    return return_v;
                }


                bool
                f_1664_8399_8464(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 8399, 8464);
                    return return_v;
                }


                bool
                f_1664_8609_8629(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ArgumentSplatted;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 8609, 8629);
                    return return_v;
                }


                object
                f_1664_8705_8722(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ArgumentValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 8705, 8722);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1664_8724_8739(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ArgumentAst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 8724, 8739);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.CommandParameterInternal>
                f_1664_8699_8740(object
                splattedValue, System.Management.Automation.Language.Ast
                splatAst)
                {
                    var return_v = Splat(splattedValue, splatAst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 8699, 8740);
                    return return_v;
                }


                int
                f_1664_8790_8832(System.Management.Automation.CommandProcessorBase
                this_param, System.Management.Automation.CommandParameterInternal
                parameter)
                {
                    this_param.AddParameter(parameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 8790, 8832);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.CommandParameterInternal>
                f_1664_8699_8740_I(System.Collections.Generic.IEnumerable<System.Management.Automation.CommandParameterInternal>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 8699, 8740);
                    return return_v;
                }


                int
                f_1664_8938_8972(System.Management.Automation.CommandProcessorBase
                this_param, System.Management.Automation.CommandParameterInternal
                parameter)
                {
                    this_param.AddParameter(parameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 8938, 8972);
                    return 0;
                }


                bool
                f_1664_9099_9165(System.Management.Automation.CommandProcessorBase
                this_param, out string
                helpTarget, out System.Management.Automation.HelpCategory
                helpCategory)
                {
                    var return_v = this_param.IsHelpRequested(out helpTarget, out helpCategory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 9099, 9165);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1664_9218_9303(System.Management.Automation.ExecutionContext
                context, string
                helpTarget, System.Management.Automation.HelpCategory
                helpCategory)
                {
                    var return_v = CommandProcessorBase.CreateGetHelpCommandProcessor(context, helpTarget, helpCategory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 9218, 9303);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1664_9335_9359(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 9335, 9359);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1664_9379_9400(System.Management.Automation.Language.CommandBaseAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 9379, 9400);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1664_9415_9439(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 9415, 9439);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1664_9415_9452(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 9415, 9452);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1664_9470_9491(System.Management.Automation.Language.CommandBaseAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 9470, 9491);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1664_9506_9530(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 9506, 9530);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1664_9506_9543(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 9506, 9543);
                    return return_v;
                }


                int
                f_1664_9592_9618(System.Management.Automation.Internal.PipelineProcessor
                this_param, System.Management.Automation.CommandProcessorBase
                commandProcessor)
                {
                    var return_v = this_param.Add(commandProcessor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 9592, 9618);
                    return return_v;
                }


                int
                f_1664_10000_10049(System.Management.Automation.CommandRedirection
                this_param, System.Management.Automation.Internal.PipelineProcessor
                pipelineProcessor, System.Management.Automation.CommandProcessorBase
                commandProcessor, System.Management.Automation.ExecutionContext
                context)
                {
                    this_param.Bind(pipelineProcessor, commandProcessor, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 10000, 10049);
                    return 0;
                }


                System.Management.Automation.Language.RedirectionStream
                f_1664_10080_10102(System.Management.Automation.CommandRedirection
                this_param)
                {
                    var return_v = this_param.FromStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 10080, 10102);
                    return return_v;
                }


                System.Management.Automation.CommandRedirection[]
                f_1664_9946_9958_I(System.Management.Automation.CommandRedirection[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 9946, 9958);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1664_11458_11494(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ShellFunctionErrorOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 11458, 11494);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1664_11544_11575(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 11544, 11575);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1664_11594_11630(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ShellFunctionErrorOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 11594, 11630);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1664_11713_11744(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 11713, 11744);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1664_11713_11760(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.ErrorOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 11713, 11760);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineWriter
                f_1664_11778_11805(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ExternalErrorOutput;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 11778, 11805);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1664_11883_11918(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ExpressionWarningOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 11883, 11918);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1664_11961_11992(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 11961, 11992);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1664_12013_12048(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ExpressionWarningOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 12013, 12048);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1664_12150_12185(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ExpressionVerboseOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 12150, 12185);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1664_12228_12259(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 12228, 12259);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1664_12280_12315(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ExpressionVerboseOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 12280, 12315);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1664_12415_12448(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ExpressionDebugOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 12415, 12448);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1664_12491_12522(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 12491, 12522);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1664_12541_12574(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ExpressionDebugOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 12541, 12574);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1664_12678_12717(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ExpressionInformationOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 12678, 12717);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1664_12760_12791(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 12760, 12791);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1664_12816_12855(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ExpressionInformationOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 12816, 12855);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1664_13061_13092(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentCommandProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 13061, 13092);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1664_13104_13135(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentCommandProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 13104, 13135);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1664_13104_13150(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 13104, 13150);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1664_13239_13270(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentCommandProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 13239, 13270);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1664_13239_13285(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 13239, 13285);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1664_13239_13303(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.WarningOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 13239, 13303);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1664_13353_13384(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 13353, 13384);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1664_13405_13436(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentCommandProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 13405, 13436);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1664_13405_13451(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 13405, 13451);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1664_13405_13469(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.WarningOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 13405, 13469);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1664_13556_13587(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentCommandProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 13556, 13587);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1664_13556_13602(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 13556, 13602);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1664_13556_13620(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.VerboseOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 13556, 13620);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1664_13670_13701(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 13670, 13701);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1664_13722_13753(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentCommandProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 13722, 13753);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1664_13722_13768(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 13722, 13768);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1664_13722_13786(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.VerboseOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 13722, 13786);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1664_13871_13902(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentCommandProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 13871, 13902);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1664_13871_13917(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 13871, 13917);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1664_13871_13933(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.DebugOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 13871, 13933);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1664_13983_14014(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 13983, 14014);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1664_14033_14064(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentCommandProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 14033, 14064);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1664_14033_14079(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 14033, 14079);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1664_14033_14095(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.DebugOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 14033, 14095);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1664_14186_14217(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentCommandProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 14186, 14217);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1664_14186_14232(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 14186, 14232);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1664_14186_14254(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.InformationOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 14186, 14254);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1664_14304_14335(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 14304, 14335);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1664_14360_14391(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentCommandProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 14360, 14391);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1664_14360_14406(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 14360, 14406);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1664_14360_14428(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.InformationOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 14360, 14428);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 881, 14514);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 881, 14514);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static IEnumerable<CommandParameterInternal> Splat(object splattedValue, Ast splatAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 14526, 16623);

                var listYield = new List<CommandParameterInternal>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 14646, 14691);

                splattedValue = f_1664_14662_14690(splattedValue);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 14707, 14737);

                var
                markUntrustedData = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 14751, 15072) || true) && (f_1664_14755_14802())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 14751, 15072);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 14985, 15057);

                    markUntrustedData = f_1664_15005_15056(splattedValue);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 14751, 15072);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 15088, 15145);

                IDictionary
                splattedTable = splattedValue as IDictionary
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 15159, 16612) || true) && (splattedTable != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 15159, 16612);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 15218, 15883);
                        foreach (DictionaryEntry de in f_1664_15249_15262_I(splattedTable))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 15218, 15883);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 15304, 15345);

                            string
                            parameterName = f_1664_15327_15344(de.Key)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 15367, 15400);

                            object
                            parameterValue = de.Value
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 15422, 15477);

                            string
                            parameterText = f_1664_15445_15476(parameterName)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 15501, 15650) || true) && (markUntrustedData)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 15501, 15650);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 15572, 15627);

                                f_1664_15572_15626(parameterValue);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 15501, 15650);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 15674, 15864);

                            listYield.Add(f_1664_15687_15863(splatAst, parameterName, parameterText, splatAst, parameterValue, false));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 15218, 15883);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 1, 666);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 1, 666);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 15159, 16612);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 15159, 16612);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 15949, 16008);

                    IEnumerable
                    enumerableValue = splattedValue as IEnumerable
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 16026, 16597) || true) && (enumerableValue != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 16026, 16597);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 16095, 16435);
                            foreach (object obj in f_1664_16118_16133_I(enumerableValue))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 16095, 16435);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 16183, 16333) || true) && (markUntrustedData)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 16183, 16333);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 16262, 16306);

                                    f_1664_16262_16305(obj);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 16183, 16333);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 16361, 16412);

                                listYield.Add(f_1664_16374_16411(obj, splatAst));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 16095, 16435);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 1, 341);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 1, 341);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 16026, 16597);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 16026, 16597);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 16517, 16578);

                        listYield.Add(f_1664_16530_16577(splattedValue, splatAst));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 16026, 16597);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 15159, 16612);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 14526, 16623);

                return listYield;

                object
                f_1664_14662_14690(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 14662, 14690);
                    return return_v;
                }


                bool
                f_1664_14755_14802()
                {
                    var return_v = ExecutionContext.HasEverUsedConstrainedLanguage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 14755, 14802);
                    return return_v;
                }


                bool
                f_1664_15005_15056(object
                value)
                {
                    var return_v = ExecutionContext.IsMarkedAsUntrusted(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 15005, 15056);
                    return return_v;
                }


                string?
                f_1664_15327_15344(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 15327, 15344);
                    return return_v;
                }


                string
                f_1664_15445_15476(string
                parameterName)
                {
                    var return_v = GetParameterText(parameterName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 15445, 15476);
                    return return_v;
                }


                int
                f_1664_15572_15626(object
                value)
                {
                    ExecutionContext.MarkObjectAsUntrusted(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 15572, 15626);
                    return 0;
                }


                System.Management.Automation.CommandParameterInternal
                f_1664_15687_15863(System.Management.Automation.Language.Ast
                parameterAst, string
                parameterName, string
                parameterText, System.Management.Automation.Language.Ast
                argumentAst, object
                value, bool
                spaceAfterParameter)
                {
                    var return_v = CommandParameterInternal.CreateParameterWithArgument(parameterAst, parameterName, parameterText, argumentAst, value, spaceAfterParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 15687, 15863);
                    return return_v;
                }


                System.Collections.IDictionary
                f_1664_15249_15262_I(System.Collections.IDictionary
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 15249, 15262);
                    return return_v;
                }


                int
                f_1664_16262_16305(object
                value)
                {
                    ExecutionContext.MarkObjectAsUntrusted(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 16262, 16305);
                    return 0;
                }


                System.Management.Automation.CommandParameterInternal
                f_1664_16374_16411(object
                splattedArgument, System.Management.Automation.Language.Ast
                splatAst)
                {
                    var return_v = SplatEnumerableElement(splattedArgument, splatAst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 16374, 16411);
                    return return_v;
                }


                System.Collections.IEnumerable
                f_1664_16118_16133_I(System.Collections.IEnumerable
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 16118, 16133);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1664_16530_16577(object
                splattedArgument, System.Management.Automation.Language.Ast
                splatAst)
                {
                    var return_v = SplatEnumerableElement(splattedArgument, splatAst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 16530, 16577);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 14526, 16623);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 14526, 16623);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static CommandParameterInternal SplatEnumerableElement(object splattedArgument, Ast splatAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 16635, 17386);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 16761, 16805);

                var
                psObject = splattedArgument as PSObject
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 16819, 17284) || true) && (psObject != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 16819, 17284);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 16873, 16982);

                    var
                    prop = f_1664_16884_16981(f_1664_16884_16903(psObject), ScriptParameterBinderController.NotePropertyNameForSplattingParametersInArgs)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 17000, 17034);

                    var
                    baseObj = f_1664_17014_17033(psObject)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 17052, 17269) || true) && (prop != null && (DynAbs.Tracing.TraceSender.Expression_True(1664, 17056, 17092) && f_1664_17072_17082(prop) is string) && (DynAbs.Tracing.TraceSender.Expression_True(1664, 17056, 17113) && baseObj is string))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 17052, 17269);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 17155, 17250);

                        return f_1664_17162_17249(f_1664_17211_17221(prop), baseObj, splatAst);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 17052, 17269);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 16819, 17284);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 17300, 17375);

                return f_1664_17307_17374(splattedArgument, splatAst);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 16635, 17386);

                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1664_16884_16903(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 16884, 16903);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1664_16884_16981(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 16884, 16981);
                    return return_v;
                }


                object
                f_1664_17014_17033(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 17014, 17033);
                    return return_v;
                }


                object
                f_1664_17072_17082(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 17072, 17082);
                    return return_v;
                }


                object
                f_1664_17211_17221(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 17211, 17221);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1664_17162_17249(object
                parameterName, object
                parameterText, System.Management.Automation.Language.Ast
                ast)
                {
                    var return_v = CommandParameterInternal.CreateParameter((string)parameterName, (string)parameterText, ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 17162, 17249);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1664_17307_17374(object
                value, System.Management.Automation.Language.Ast
                ast)
                {
                    var return_v = CommandParameterInternal.CreateArgument(value, ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 17307, 17374);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 16635, 17386);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 16635, 17386);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string GetParameterText(string parameterName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 17398, 18389);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 17483, 17576);

                f_1664_17483_17575(parameterName != null, "caller makes sure the parameterName is not null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 17590, 17629);

                int
                endPosition = f_1664_17608_17628(parameterName)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 17643, 17783) || true) && ((endPosition > 0) && (DynAbs.Tracing.TraceSender.Expression_True(1664, 17650, 17720) && f_1664_17671_17720(f_1664_17689_17719(parameterName, endPosition - 1))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 17643, 17783);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 17754, 17768);

                        endPosition--;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 17643, 17783);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 17643, 17783);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 17643, 17783);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 17799, 17936) || true) && (endPosition == 0 || (DynAbs.Tracing.TraceSender.Expression_False(1664, 17803, 17860) || f_1664_17823_17853(parameterName, endPosition - 1) == ':'))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 17799, 17936);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 17894, 17921);

                    return "-" + parameterName;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 17799, 17936);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 17952, 17973);

                string
                parameterText
                = default(string);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 17987, 18341) || true) && (endPosition == f_1664_18006_18026(parameterName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 17987, 18341);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 18060, 18102);

                    parameterText = "-" + parameterName + ":";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 17987, 18341);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 17987, 18341);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 18168, 18226);

                    string
                    whitespaces = f_1664_18189_18225(parameterName, endPosition)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 18244, 18326);

                    parameterText = "-" + f_1664_18266_18305(parameterName, 0, endPosition) + ":" + whitespaces;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 17987, 18341);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 18357, 18378);

                return parameterText;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 17398, 18389);

                int
                f_1664_17483_17575(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 17483, 17575);
                    return 0;
                }


                int
                f_1664_17608_17628(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 17608, 17628);
                    return return_v;
                }


                char
                f_1664_17689_17719(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 17689, 17719);
                    return return_v;
                }


                bool
                f_1664_17671_17720(char
                c)
                {
                    var return_v = char.IsWhiteSpace(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 17671, 17720);
                    return return_v;
                }


                char
                f_1664_17823_17853(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 17823, 17853);
                    return return_v;
                }


                int
                f_1664_18006_18026(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 18006, 18026);
                    return return_v;
                }


                string
                f_1664_18189_18225(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 18189, 18225);
                    return return_v;
                }


                string
                f_1664_18266_18305(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 18266, 18305);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 17398, 18389);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 17398, 18389);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void InvokePipeline(object input,
                                                    bool ignoreInput,
                                                    CommandParameterInternal[][] pipeElements,
                                                    CommandBaseAst[] pipeElementAsts,
                                                    CommandRedirection[][] commandRedirections,
                                                    FunctionContext funcContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 18401, 23006);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 18868, 18930);

                PipelineProcessor
                pipelineProcessor = f_1664_18906_18929()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 18944, 19001);

                ExecutionContext
                context = funcContext._executionContext
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 19015, 19057);

                Pipe
                outputPipe = funcContext._outputPipe
                ;

                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 19109, 19235) || true) && (f_1664_19113_19127(context) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 19109, 19235);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 19177, 19216);

                        f_1664_19177_19215(f_1664_19177_19191(context));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 19109, 19235);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 19255, 19979) || true) && (input == f_1664_19268_19288() && (DynAbs.Tracing.TraceSender.Expression_True(1664, 19259, 19304) && !ignoreInput))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 19255, 19979);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 19908, 19960);

                        f_1664_19908_19959(pipelineProcessor, context);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 19255, 19979);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 19999, 20044);

                    CommandProcessorBase
                    commandProcessor = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 20062, 20109);

                    CommandRedirection[]
                    commandRedirection = null
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 20138, 20143);

                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 20129, 20503) || true) && (i < f_1664_20149_20168(pipeElements))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 20170, 20173)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 20129, 20503))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 20129, 20503);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 20215, 20296);

                            commandRedirection = (DynAbs.Tracing.TraceSender.Conditional_F1(1664, 20236, 20263) || ((commandRedirections != null && DynAbs.Tracing.TraceSender.Conditional_F2(1664, 20266, 20288)) || DynAbs.Tracing.TraceSender.Conditional_F3(1664, 20291, 20295))) ? commandRedirections[i] : null;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 20318, 20484);

                            commandProcessor = f_1664_20337_20483(pipelineProcessor, pipeElements[i], pipeElementAsts[i], commandRedirection, context);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 1, 375);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 1, 375);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 20523, 20584);

                    var
                    cmdletInfo = f_1664_20540_20569_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(commandProcessor, 1664, 20540, 20569)?.CommandInfo) as CmdletInfo
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 20602, 21658) || true) && (f_1664_20606_20634_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(cmdletInfo, 1664, 20606, 20634)?.ImplementingType) == typeof(OutNullCommand))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 20602, 21658);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 20702, 20755);

                        var
                        commandsCount = f_1664_20722_20754(f_1664_20722_20748(pipelineProcessor))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 20777, 20967) || true) && (commandsCount == 1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 20777, 20967);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 20937, 20944);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 20777, 20967);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 21194, 21264);

                        var
                        nextToLastCommand = f_1664_21218_21263(f_1664_21218_21244(pipelineProcessor), commandsCount - 2)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 21286, 21639) || true) && (f_1664_21290_21347_M(!f_1664_21291_21334(f_1664_21291_21323(nextToLastCommand)).IsRedirected))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 21286, 21639);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 21397, 21452);

                            f_1664_21397_21451(f_1664_21397_21423(pipelineProcessor), commandsCount - 1);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 21478, 21515);

                            commandProcessor = nextToLastCommand;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 21541, 21616);

                            f_1664_21541_21573(nextToLastCommand).OutputPipe = new Pipe { NullPipe = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 1664, 21587, 21615) };
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 21286, 21639);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 20602, 21658);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 21678, 22470) || true) && (commandProcessor != null && (DynAbs.Tracing.TraceSender.Expression_True(1664, 21682, 21766) && f_1664_21710_21766_M(!f_1664_21711_21753(f_1664_21711_21742(commandProcessor)).IsRedirected)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 21678, 22470);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 21808, 21896);

                        f_1664_21808_21895(pipelineProcessor, outputPipe ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Internal.Pipe>(1664, 21852, 21894) ?? f_1664_21866_21894(f_1664_21875_21893())));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 22005, 22451) || true) && (commandRedirection != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 22005, 22451);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 22085, 22428);
                                foreach (CommandRedirection redirection in f_1664_22128_22146_I(commandRedirection))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 22085, 22428);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 22204, 22401) || true) && (redirection is MergingRedirection)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 22204, 22401);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 22307, 22370);

                                        f_1664_22307_22369(redirection, pipelineProcessor, commandProcessor, context);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 22204, 22401);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 22085, 22428);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 1, 344);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 1, 344);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 22005, 22451);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 21678, 22470);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 22490, 22539);

                    f_1664_22490_22538(
                                    context, pipelineProcessor);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 22601, 22654);

                        f_1664_22601_22653(pipelineProcessor, input);
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1664, 22691, 22794);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 22739, 22775);

                        f_1664_22739_22774(context, false);
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1664, 22691, 22794);
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1664, 22823, 22995);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 22863, 22934);

                    context.QuestionMarkVariableValue = f_1664_22899_22933_M(!pipelineProcessor.ExecutionFailed);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 22952, 22980);

                    f_1664_22952_22979(pipelineProcessor);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1664, 22823, 22995);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 18401, 23006);

                System.Management.Automation.Internal.PipelineProcessor
                f_1664_18906_18929()
                {
                    var return_v = new System.Management.Automation.Internal.PipelineProcessor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 18906, 18929);
                    return return_v;
                }


                System.Management.Automation.PSLocalEventManager
                f_1664_19113_19127(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Events;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 19113, 19127);
                    return return_v;
                }


                System.Management.Automation.PSLocalEventManager
                f_1664_19177_19191(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Events;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 19177, 19191);
                    return return_v;
                }


                int
                f_1664_19177_19215(System.Management.Automation.PSLocalEventManager
                this_param)
                {
                    this_param.ProcessPendingActions();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 19177, 19215);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1664_19268_19288()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 19268, 19288);
                    return return_v;
                }


                int
                f_1664_19908_19959(System.Management.Automation.Internal.PipelineProcessor
                pipelineProcessor, System.Management.Automation.ExecutionContext
                context)
                {
                    AddNoopCommandProcessor(pipelineProcessor, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 19908, 19959);
                    return 0;
                }


                int
                f_1664_20149_20168(System.Management.Automation.CommandParameterInternal[][]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 20149, 20168);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1664_20337_20483(System.Management.Automation.Internal.PipelineProcessor
                pipe, System.Management.Automation.CommandParameterInternal[]
                commandElements, System.Management.Automation.Language.CommandBaseAst
                commandBaseAst, System.Management.Automation.CommandRedirection[]
                redirections, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = AddCommand(pipe, commandElements, commandBaseAst, redirections, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 20337, 20483);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1664_20540_20569_M(System.Management.Automation.CommandInfo
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 20540, 20569);
                    return return_v;
                }


                System.Type
                f_1664_20606_20634_M(System.Type
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 20606, 20634);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
                f_1664_20722_20748(System.Management.Automation.Internal.PipelineProcessor
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 20722, 20748);
                    return return_v;
                }


                int
                f_1664_20722_20754(System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 20722, 20754);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
                f_1664_21218_21244(System.Management.Automation.Internal.PipelineProcessor
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 21218, 21244);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1664_21218_21263(System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 21218, 21263);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1664_21291_21323(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 21291, 21323);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1664_21291_21334(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.OutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 21291, 21334);
                    return return_v;
                }


                bool
                f_1664_21290_21347_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 21290, 21347);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
                f_1664_21397_21423(System.Management.Automation.Internal.PipelineProcessor
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 21397, 21423);
                    return return_v;
                }


                int
                f_1664_21397_21451(System.Collections.Generic.List<System.Management.Automation.CommandProcessorBase>
                this_param, int
                index)
                {
                    this_param.RemoveAt(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 21397, 21451);
                    return 0;
                }


                System.Management.Automation.MshCommandRuntime
                f_1664_21541_21573(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 21541, 21573);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1664_21711_21742(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 21711, 21742);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1664_21711_21753(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.OutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 21711, 21753);
                    return return_v;
                }


                bool
                f_1664_21710_21766_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 21710, 21766);
                    return return_v;
                }


                System.Collections.Generic.List<object>
                f_1664_21875_21893()
                {
                    var return_v = new System.Collections.Generic.List<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 21875, 21893);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1664_21866_21894(System.Collections.Generic.List<object>
                resultList)
                {
                    var return_v = new System.Management.Automation.Internal.Pipe(resultList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 21866, 21894);
                    return return_v;
                }


                int
                f_1664_21808_21895(System.Management.Automation.Internal.PipelineProcessor
                this_param, System.Management.Automation.Internal.Pipe
                pipeToUse)
                {
                    this_param.LinkPipelineSuccessOutput(pipeToUse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 21808, 21895);
                    return 0;
                }


                int
                f_1664_22307_22369(System.Management.Automation.CommandRedirection
                this_param, System.Management.Automation.Internal.PipelineProcessor
                pipelineProcessor, System.Management.Automation.CommandProcessorBase
                commandProcessor, System.Management.Automation.ExecutionContext
                context)
                {
                    this_param.Bind(pipelineProcessor, commandProcessor, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 22307, 22369);
                    return 0;
                }


                System.Management.Automation.CommandRedirection[]
                f_1664_22128_22146_I(System.Management.Automation.CommandRedirection[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 22128, 22146);
                    return return_v;
                }


                int
                f_1664_22490_22538(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.Internal.PipelineProcessor
                pp)
                {
                    this_param.PushPipelineProcessor(pp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 22490, 22538);
                    return 0;
                }


                System.Array
                f_1664_22601_22653(System.Management.Automation.Internal.PipelineProcessor
                this_param, object
                input)
                {
                    var return_v = this_param.SynchronousExecuteEnumerate(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 22601, 22653);
                    return return_v;
                }


                int
                f_1664_22739_22774(System.Management.Automation.ExecutionContext
                this_param, bool
                fromSteppablePipeline)
                {
                    this_param.PopPipelineProcessor(fromSteppablePipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 22739, 22774);
                    return 0;
                }


                bool
                f_1664_22899_22933_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 22899, 22933);
                    return return_v;
                }


                int
                f_1664_22952_22979(System.Management.Automation.Internal.PipelineProcessor
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 22952, 22979);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 18401, 23006);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 18401, 23006);
            }
        }

        internal static void InvokePipelineInBackground(
                                                    PipelineBaseAst pipelineAst,
                                                    FunctionContext funcContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 23018, 27389);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 23239, 23301);

                PipelineProcessor
                pipelineProcessor = f_1664_23277_23300()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 23315, 23372);

                ExecutionContext
                context = funcContext._executionContext
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 23386, 23428);

                Pipe
                outputPipe = funcContext._outputPipe
                ;

                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 23480, 23606) || true) && (f_1664_23484_23498(context) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 23480, 23606);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 23548, 23587);

                        f_1664_23548_23586(f_1664_23548_23562(context));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 23480, 23606);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 23626, 23671);

                    CommandProcessorBase
                    commandProcessor = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 23775, 23827);

                    var
                    scriptblockBodyString = f_1664_23803_23826(f_1664_23803_23821(pipelineAst))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 23845, 23897);

                    var
                    pipelineOffset = f_1664_23866_23896(f_1664_23866_23884(pipelineAst))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 23915, 23990);

                    var
                    variables = f_1664_23931_23989(pipelineAst, x => x is VariableExpressionAst, true)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 24091, 24191);

                    const string
                    cmdPrefix = @"Microsoft.PowerShell.Management\Set-Location -LiteralPath $using:pwd ; "
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 24354, 24485);

                    System.Text.StringBuilder
                    updatedScriptblock = f_1664_24401_24484(f_1664_24431_24447(cmdPrefix) + f_1664_24450_24478(scriptblockBodyString) + 18)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 24503, 24540);

                    f_1664_24503_24539(updatedScriptblock, cmdPrefix);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 24558, 24575);

                    int
                    position = 0
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 24664, 25904);
                        foreach (var v in f_1664_24682_24691_I(variables))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 24664, 25904);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 24733, 24801);

                            var
                            variableName = f_1664_24752_24800(f_1664_24752_24791(((VariableExpressionAst)v)))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 24881, 25049) || true) && (f_1664_24885_24959(f_1664_24885_24933(funcContext._executionContext), variableName) == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 24881, 25049);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 25017, 25026);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 24881, 25049);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 25129, 25885) || true) && (f_1664_25133_25389(f_1664_25133_25381(variableName, "^(global:){0,1}(PID|PSVersionTable|PSEdition|PSHOME|HOST|TRUE|FALSE|NULL)$", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant)) == false)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 25129, 25885);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 25448, 25567);

                                f_1664_25448_25566(updatedScriptblock, f_1664_25474_25565(scriptblockBodyString, position, f_1664_25516_25536(f_1664_25516_25524(v)) - pipelineOffset - position));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 25593, 25631);

                                f_1664_25593_25630(updatedScriptblock, "${using:");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 25657, 25732);

                                f_1664_25657_25731(updatedScriptblock, f_1664_25683_25730(variableName));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 25758, 25789);

                                f_1664_25758_25788(updatedScriptblock, '}');
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 25815, 25862);

                                position = f_1664_25826_25844(f_1664_25826_25834(v)) - pipelineOffset;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 25129, 25885);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 24664, 25904);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 1, 1241);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 1, 1241);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 25924, 25993);

                    f_1664_25924_25992(
                                    updatedScriptblock, f_1664_25950_25991(scriptblockBodyString, position));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 26011, 26070);

                    var
                    sb = f_1664_26020_26069(f_1664_26039_26068(updatedScriptblock))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 26088, 26159);

                    var
                    commandInfo = f_1664_26106_26158("Start-Job", typeof(StartJobCommand))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 26177, 26316);

                    commandProcessor = f_1664_26196_26315(f_1664_26196_26220(context), commandInfo, CommandOrigin.Internal, false, f_1664_26288_26314(context));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 26334, 26615);

                    var
                    parameter = f_1664_26350_26614(parameterAst: pipelineAst, "ScriptBlock", null, argumentAst: pipelineAst, sb, false)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 26633, 26674);

                    f_1664_26633_26673(commandProcessor, parameter);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 26692, 26732);

                    f_1664_26692_26731(pipelineProcessor, commandProcessor);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 26750, 26838);

                    f_1664_26750_26837(pipelineProcessor, outputPipe ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Internal.Pipe>(1664, 26794, 26836) ?? f_1664_26808_26836(f_1664_26817_26835())));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 26858, 26907);

                    f_1664_26858_26906(
                                    context, pipelineProcessor);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 26969, 27037);

                        f_1664_26969_27036(pipelineProcessor, f_1664_27015_27035());
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1664, 27074, 27177);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 27122, 27158);

                        f_1664_27122_27157(context, false);
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1664, 27074, 27177);
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1664, 27206, 27378);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 27246, 27317);

                    context.QuestionMarkVariableValue = f_1664_27282_27316_M(!pipelineProcessor.ExecutionFailed);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 27335, 27363);

                    f_1664_27335_27362(pipelineProcessor);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1664, 27206, 27378);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 23018, 27389);

                System.Management.Automation.Internal.PipelineProcessor
                f_1664_23277_23300()
                {
                    var return_v = new System.Management.Automation.Internal.PipelineProcessor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 23277, 23300);
                    return return_v;
                }


                System.Management.Automation.PSLocalEventManager
                f_1664_23484_23498(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Events;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 23484, 23498);
                    return return_v;
                }


                System.Management.Automation.PSLocalEventManager
                f_1664_23548_23562(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Events;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 23548, 23562);
                    return return_v;
                }


                int
                f_1664_23548_23586(System.Management.Automation.PSLocalEventManager
                this_param)
                {
                    this_param.ProcessPendingActions();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 23548, 23586);
                    return 0;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1664_23803_23821(System.Management.Automation.Language.PipelineBaseAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 23803, 23821);
                    return return_v;
                }


                string
                f_1664_23803_23826(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 23803, 23826);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1664_23866_23884(System.Management.Automation.Language.PipelineBaseAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 23866, 23884);
                    return return_v;
                }


                int
                f_1664_23866_23896(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 23866, 23896);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.Language.Ast>
                f_1664_23931_23989(System.Management.Automation.Language.PipelineBaseAst
                this_param, System.Func<System.Management.Automation.Language.Ast, bool>
                predicate, bool
                searchNestedScriptBlocks)
                {
                    var return_v = this_param.FindAll(predicate, searchNestedScriptBlocks);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 23931, 23989);
                    return return_v;
                }


                int
                f_1664_24431_24447(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 24431, 24447);
                    return return_v;
                }


                int
                f_1664_24450_24478(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 24450, 24478);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1664_24401_24484(int
                capacity)
                {
                    var return_v = new System.Text.StringBuilder(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 24401, 24484);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1664_24503_24539(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 24503, 24539);
                    return return_v;
                }


                System.Management.Automation.VariablePath
                f_1664_24752_24791(System.Management.Automation.Language.VariableExpressionAst
                this_param)
                {
                    var return_v = this_param.VariablePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 24752, 24791);
                    return return_v;
                }


                string
                f_1664_24752_24800(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.UserPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 24752, 24800);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1664_24885_24933(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 24885, 24933);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1664_24885_24959(System.Management.Automation.SessionStateInternal
                this_param, string
                name)
                {
                    var return_v = this_param.GetVariable(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 24885, 24959);
                    return return_v;
                }


                System.Text.RegularExpressions.Match
                f_1664_25133_25381(string
                input, string
                pattern, System.Text.RegularExpressions.RegexOptions
                options)
                {
                    var return_v = Regex.Match(input, pattern, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 25133, 25381);
                    return return_v;
                }


                bool
                f_1664_25133_25389(System.Text.RegularExpressions.Match
                this_param)
                {
                    var return_v = this_param.Success;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 25133, 25389);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1664_25516_25524(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 25516, 25524);
                    return return_v;
                }


                int
                f_1664_25516_25536(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 25516, 25536);
                    return return_v;
                }


                string
                f_1664_25474_25565(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 25474, 25565);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1664_25448_25566(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 25448, 25566);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1664_25593_25630(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 25593, 25630);
                    return return_v;
                }


                string
                f_1664_25683_25730(string
                value)
                {
                    var return_v = CodeGeneration.EscapeVariableName(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 25683, 25730);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1664_25657_25731(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 25657, 25731);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1664_25758_25788(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 25758, 25788);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1664_25826_25834(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 25826, 25834);
                    return return_v;
                }


                int
                f_1664_25826_25844(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 25826, 25844);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.Language.Ast>
                f_1664_24682_24691_I(System.Collections.Generic.IEnumerable<System.Management.Automation.Language.Ast>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 24682, 24691);
                    return return_v;
                }


                string
                f_1664_25950_25991(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 25950, 25991);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1664_25924_25992(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 25924, 25992);
                    return return_v;
                }


                string
                f_1664_26039_26068(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 26039, 26068);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1664_26020_26069(string
                script)
                {
                    var return_v = ScriptBlock.Create(script);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 26020, 26069);
                    return return_v;
                }


                System.Management.Automation.CmdletInfo
                f_1664_26106_26158(string
                name, System.Type
                implementingType)
                {
                    var return_v = new System.Management.Automation.CmdletInfo(name, implementingType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 26106, 26158);
                    return return_v;
                }


                System.Management.Automation.CommandDiscovery
                f_1664_26196_26220(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CommandDiscovery;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 26196, 26220);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1664_26288_26314(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 26288, 26314);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1664_26196_26315(System.Management.Automation.CommandDiscovery
                this_param, System.Management.Automation.CmdletInfo
                commandInfo, System.Management.Automation.CommandOrigin
                commandOrigin, bool
                useLocalScope, System.Management.Automation.SessionStateInternal
                sessionState)
                {
                    var return_v = this_param.LookupCommandProcessor((System.Management.Automation.CommandInfo)commandInfo, commandOrigin, (bool?)useLocalScope, sessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 26196, 26315);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1664_26350_26614(System.Management.Automation.Language.PipelineBaseAst
                parameterAst, string
                parameterName, string
                parameterText, System.Management.Automation.Language.PipelineBaseAst
                argumentAst, System.Management.Automation.ScriptBlock
                value, bool
                spaceAfterParameter)
                {
                    var return_v = CommandParameterInternal.CreateParameterWithArgument(parameterAst: (System.Management.Automation.Language.Ast)parameterAst, parameterName, parameterText, argumentAst: (System.Management.Automation.Language.Ast)argumentAst, (object)value, spaceAfterParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 26350, 26614);
                    return return_v;
                }


                int
                f_1664_26633_26673(System.Management.Automation.CommandProcessorBase
                this_param, System.Management.Automation.CommandParameterInternal
                parameter)
                {
                    this_param.AddParameter(parameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 26633, 26673);
                    return 0;
                }


                int
                f_1664_26692_26731(System.Management.Automation.Internal.PipelineProcessor
                this_param, System.Management.Automation.CommandProcessorBase
                commandProcessor)
                {
                    var return_v = this_param.Add(commandProcessor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 26692, 26731);
                    return return_v;
                }


                System.Collections.Generic.List<object>
                f_1664_26817_26835()
                {
                    var return_v = new System.Collections.Generic.List<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 26817, 26835);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1664_26808_26836(System.Collections.Generic.List<object>
                resultList)
                {
                    var return_v = new System.Management.Automation.Internal.Pipe(resultList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 26808, 26836);
                    return return_v;
                }


                int
                f_1664_26750_26837(System.Management.Automation.Internal.PipelineProcessor
                this_param, System.Management.Automation.Internal.Pipe
                pipeToUse)
                {
                    this_param.LinkPipelineSuccessOutput(pipeToUse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 26750, 26837);
                    return 0;
                }


                int
                f_1664_26858_26906(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.Internal.PipelineProcessor
                pp)
                {
                    this_param.PushPipelineProcessor(pp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 26858, 26906);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1664_27015_27035()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 27015, 27035);
                    return return_v;
                }


                System.Array
                f_1664_26969_27036(System.Management.Automation.Internal.PipelineProcessor
                this_param, System.Management.Automation.PSObject
                input)
                {
                    var return_v = this_param.SynchronousExecuteEnumerate((object)input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 26969, 27036);
                    return return_v;
                }


                int
                f_1664_27122_27157(System.Management.Automation.ExecutionContext
                this_param, bool
                fromSteppablePipeline)
                {
                    this_param.PopPipelineProcessor(fromSteppablePipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 27122, 27157);
                    return 0;
                }


                bool
                f_1664_27282_27316_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 27282, 27316);
                    return return_v;
                }


                int
                f_1664_27335_27362(System.Management.Automation.Internal.PipelineProcessor
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 27335, 27362);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 23018, 27389);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 23018, 27389);
            }
        }

        private static void AddNoopCommandProcessor(PipelineProcessor pipelineProcessor, ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 27401, 28111);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 27532, 27601);

                var
                commandInfo = f_1664_27550_27600("Out-Null", typeof(OutNullCommand))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 27615, 28046);

                var
                commandProcessor = f_1664_27638_28045(f_1664_27638_27662(context), commandInfo, f_1664_27783_27834(f_1664_27783_27822(f_1664_27783_27809(context))), useLocalScope: false, sessionState: null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 28060, 28100);

                f_1664_28060_28099(pipelineProcessor, commandProcessor);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 27401, 28111);

                System.Management.Automation.CmdletInfo
                f_1664_27550_27600(string
                name, System.Type
                implementingType)
                {
                    var return_v = new System.Management.Automation.CmdletInfo(name, implementingType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 27550, 27600);
                    return return_v;
                }


                System.Management.Automation.CommandDiscovery
                f_1664_27638_27662(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CommandDiscovery;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 27638, 27662);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1664_27783_27809(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 27783, 27809);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1664_27783_27822(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 27783, 27822);
                    return return_v;
                }


                System.Management.Automation.CommandOrigin
                f_1664_27783_27834(System.Management.Automation.SessionStateScope
                this_param)
                {
                    var return_v = this_param.ScopeOrigin;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 27783, 27834);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1664_27638_28045(System.Management.Automation.CommandDiscovery
                this_param, System.Management.Automation.CmdletInfo
                commandInfo, System.Management.Automation.CommandOrigin
                commandOrigin, bool
                useLocalScope, System.Management.Automation.SessionStateInternal
                sessionState)
                {
                    var return_v = this_param.LookupCommandProcessor((System.Management.Automation.CommandInfo)commandInfo, commandOrigin, useLocalScope: (bool?)useLocalScope, sessionState: sessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 27638, 28045);
                    return return_v;
                }


                int
                f_1664_28060_28099(System.Management.Automation.Internal.PipelineProcessor
                this_param, System.Management.Automation.CommandProcessorBase
                commandProcessor)
                {
                    var return_v = this_param.Add(commandProcessor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 28060, 28099);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 27401, 28111);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 27401, 28111);
            }
        }

        internal static object CheckAutomationNullInCommandArgument(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 28123, 28473);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 28219, 28311) || true) && (obj == f_1664_28230_28250())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 28219, 28311);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 28284, 28296);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 28219, 28311);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 28327, 28360);

                var
                objAsArray = obj as object[]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 28374, 28462);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1664, 28381, 28399) || ((objAsArray != null && DynAbs.Tracing.TraceSender.Conditional_F2(1664, 28402, 28455)) || DynAbs.Tracing.TraceSender.Conditional_F3(1664, 28458, 28461))) ? f_1664_28402_28455(objAsArray) : obj;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 28123, 28473);

                System.Management.Automation.PSObject
                f_1664_28230_28250()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 28230, 28250);
                    return return_v;
                }


                object[]
                f_1664_28402_28455(object[]
                objArray)
                {
                    var return_v = CheckAutomationNullInCommandArgumentArray(objArray);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 28402, 28455);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 28123, 28473);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 28123, 28473);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object[] CheckAutomationNullInCommandArgumentArray(object[] objArray)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 28485, 28939);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 28595, 28896) || true) && (objArray != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 28595, 28896);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 28658, 28663);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 28649, 28881) || true) && (i < f_1664_28669_28684(objArray))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 28686, 28689)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 28649, 28881))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 28649, 28881);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 28731, 28862) || true) && (objArray[i] == f_1664_28750_28770())
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 28731, 28862);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 28820, 28839);

                                objArray[i] = null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 28731, 28862);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 1, 233);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 1, 233);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 28595, 28896);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 28912, 28928);

                return objArray;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 28485, 28939);

                int
                f_1664_28669_28684(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 28669, 28684);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1664_28750_28770()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 28750, 28770);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 28485, 28939);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 28485, 28939);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SteppablePipeline GetSteppablePipeline(PipelineAst pipelineAst, CommandOrigin commandOrigin, ScriptBlock scriptBlock, object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 28951, 35971);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 29124, 29172);

                var
                pipelineProcessor = f_1664_29148_29171()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 29186, 29294);

                var
                commandTuples = f_1664_29206_29293()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 29310, 29380);

                ExecutionContext
                context = f_1664_29337_29379()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 29394, 30007) || true) && (context == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 29394, 30007);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 29549, 29592);

                    string
                    scriptText = f_1664_29569_29591(scriptBlock)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 29610, 29693);

                    scriptText = f_1664_29623_29692(f_1664_29651_29679(), scriptText);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 29713, 29894);

                    PSInvalidOperationException
                    e = f_1664_29745_29893(f_1664_29810_29859(), scriptText)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 29914, 29966);

                    f_1664_29914_29965(
                                    e, "GetSteppablePipelineFromWrongThread");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 29984, 29992);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 29394, 30007);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 30356, 30578);

                bool
                useParameter = (args != null && (DynAbs.Tracing.TraceSender.Expression_True(1664, 30377, 30408) && f_1664_30393_30404(args) > 0)) && (DynAbs.Tracing.TraceSender.Expression_True(1664, 30376, 30577) && f_1664_30446_30487(f_1664_30446_30482(scriptBlock)) !=
                                                RuntimeDefinedParameterDictionary.EmptyParameterArray)
                ;
                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 30628, 31653) || true) && (useParameter)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 30628, 31653);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 30787, 30845);

                        var
                        newScope = f_1664_30802_30844(f_1664_30802_30828(context), false)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 30867, 30918);

                        f_1664_30867_30893(context).CurrentScope = newScope;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 30940, 31017);

                        f_1664_30940_30979(f_1664_30940_30966(context)).ScopeOrigin = CommandOrigin.Internal;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 31041, 31201);

                        var
                        locals = f_1664_31054_31200(Compiler.DottedLocalsTupleType, Compiler.DottedLocalsNameIndexMap)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 31223, 31484);

                        object[]
                        remainingArgs =
                        f_1664_31273_31483(f_1664_31376_31417(f_1664_31376_31412(scriptBlock)), args, context, false, null, locals)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 31506, 31582);

                        f_1664_31506_31581(locals, AutomaticVariable.Args, remainingArgs, context);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 31604, 31634);

                        newScope.LocalsTuple = locals;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 30628, 31653);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 31924, 31997);

                    bool
                    isTrusted = f_1664_31941_31965(scriptBlock) == PSLanguageMode.FullLanguage
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 32017, 33499);
                        foreach (var commandAst in f_1664_32044_32091_I(f_1664_32044_32091(f_1664_32044_32072(pipelineAst))))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 32017, 33499);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 32133, 32194);

                            var
                            commandParameters = f_1664_32157_32193()
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 32216, 33086);
                                foreach (var commandElement in f_1664_32247_32273_I(f_1664_32247_32273(commandAst)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 32216, 33086);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 32323, 32387);

                                    var
                                    commandParameterAst = commandElement as CommandParameterAst
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 32413, 32652) || true) && (commandParameterAst != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 32413, 32652);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 32502, 32586);

                                        f_1664_32502_32585(commandParameters, f_1664_32524_32584(commandParameterAst, isTrusted, context));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 32616, 32625);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 32413, 32652);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 32680, 32724);

                                    var
                                    exprAst = (ExpressionAst)commandElement
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 32750, 32822);

                                    var
                                    argument = f_1664_32765_32821(exprAst, isTrusted, context)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 32848, 32944);

                                    var
                                    splatting = (exprAst is VariableExpressionAst && (DynAbs.Tracing.TraceSender.Expression_True(1664, 32865, 32942) && f_1664_32901_32942(((VariableExpressionAst)exprAst))))
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 32970, 33063);

                                    f_1664_32970_33062(commandParameters, f_1664_32992_33061(argument, exprAst, splatting));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 32216, 33086);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 1, 871);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 1, 871);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 33110, 33160);

                            var
                            redirections = f_1664_33129_33159()
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 33182, 33379);
                                foreach (var redirection in f_1664_33210_33233_I(f_1664_33210_33233(commandAst)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 33182, 33379);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 33283, 33356);

                                    f_1664_33283_33355(redirections, f_1664_33300_33354(redirection, isTrusted, context));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 33182, 33379);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 1, 198);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 1, 198);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 33403, 33480);

                            f_1664_33403_33479(
                                                commandTuples, f_1664_33421_33478(commandAst, commandParameters, redirections));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 32017, 33499);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 1, 1483);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 1, 1483);
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1664, 33528, 33740);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 33568, 33725) || true) && (useParameter)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 33568, 33725);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 33626, 33706);

                        f_1664_33626_33705(f_1664_33626_33652(context), f_1664_33665_33704(f_1664_33665_33691(context)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 33568, 33725);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1664, 33528, 33740);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 33756, 35887);
                    foreach (var commandTuple in f_1664_33785_33798_I(commandTuples))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 33756, 35887);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 33832, 33974);

                        var
                        commandProcessor = f_1664_33855_33973(pipelineProcessor, f_1664_33885_33913(f_1664_33885_33903(commandTuple)), f_1664_33915_33933(commandTuple), f_1664_33935_33963(f_1664_33935_33953(commandTuple)), context)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 33992, 34055);

                        f_1664_33992_34016(commandProcessor).CommandOriginInternal = commandOrigin;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 34073, 34131);

                        f_1664_34073_34102(commandProcessor).ScopeOrigin = commandOrigin;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 34149, 34217);

                        f_1664_34149_34186(f_1664_34149_34173(commandProcessor)).CommandOrigin = commandOrigin;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 34693, 34751);

                        var
                        callStack = f_1664_34709_34750(f_1664_34709_34740(f_1664_34709_34725(context)))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 34769, 35506) || true) && (f_1664_34773_34789(callStack) > 0 && (DynAbs.Tracing.TraceSender.Expression_True(1664, 34773, 34887) && f_1664_34797_34887(f_1664_34811_34837(f_1664_34811_34832(callStack[0])), "GetSteppablePipeline", RegexOptions.IgnoreCase)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 34769, 35506);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 34929, 34986);

                            var
                            myInvocation = f_1664_34948_34985(f_1664_34948_34972(commandProcessor))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 35008, 35081);

                            myInvocation.InvocationName = f_1664_35038_35080(f_1664_35038_35065(callStack[0]));

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 35103, 35487) || true) && (f_1664_35107_35123(callStack) > 1)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 35103, 35487);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 35177, 35221);

                                var
                                displayPosition = f_1664_35199_35220(callStack[1])
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 35247, 35464) || true) && (displayPosition != null && (DynAbs.Tracing.TraceSender.Expression_True(1664, 35251, 35326) && displayPosition != f_1664_35297_35326()))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 35247, 35464);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 35384, 35437);

                                    myInvocation.DisplayScriptPosition = displayPosition;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 35247, 35464);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 35103, 35487);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 34769, 35506);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 35610, 35872) || true) && (f_1664_35614_35645(context) != null && (DynAbs.Tracing.TraceSender.Expression_True(1664, 35614, 35711) && f_1664_35657_35703(f_1664_35657_35688(context)) != null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 35610, 35872);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 35753, 35853);

                            f_1664_35753_35852(f_1664_35753_35784(commandProcessor), f_1664_35805_35851(f_1664_35805_35836(context)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 35610, 35872);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 33756, 35887);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 1, 2132);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 1, 2132);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 35903, 35960);

                return f_1664_35910_35959(context, pipelineProcessor);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 28951, 35971);

                System.Management.Automation.Internal.PipelineProcessor
                f_1664_29148_29171()
                {
                    var return_v = new System.Management.Automation.Internal.PipelineProcessor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 29148, 29171);
                    return return_v;
                }


                System.Collections.Generic.List<System.Tuple<System.Management.Automation.Language.CommandAst, System.Collections.Generic.List<System.Management.Automation.CommandParameterInternal>, System.Collections.Generic.List<System.Management.Automation.CommandRedirection>>>
                f_1664_29206_29293()
                {
                    var return_v = new System.Collections.Generic.List<System.Tuple<System.Management.Automation.Language.CommandAst, System.Collections.Generic.List<System.Management.Automation.CommandParameterInternal>, System.Collections.Generic.List<System.Management.Automation.CommandRedirection>>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 29206, 29293);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1664_29337_29379()
                {
                    var return_v = LocalPipeline.GetExecutionContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 29337, 29379);
                    return return_v;
                }


                string
                f_1664_29569_29591(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 29569, 29591);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1664_29651_29679()
                {
                    var return_v = CultureInfo.CurrentUICulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 29651, 29679);
                    return return_v;
                }


                string
                f_1664_29623_29692(System.Globalization.CultureInfo
                uiCultureInfo, string
                original)
                {
                    var return_v = ErrorCategoryInfo.Ellipsize(uiCultureInfo, original);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 29623, 29692);
                    return return_v;
                }


                string
                f_1664_29810_29859()
                {
                    var return_v = ParserStrings.GetSteppablePipelineFromWrongThread;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 29810, 29859);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1664_29745_29893(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 29745, 29893);
                    return return_v;
                }


                int
                f_1664_29914_29965(System.Management.Automation.PSInvalidOperationException
                this_param, string
                errorId)
                {
                    this_param.SetErrorId(errorId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 29914, 29965);
                    return 0;
                }


                int
                f_1664_30393_30404(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 30393, 30404);
                    return return_v;
                }


                System.Management.Automation.RuntimeDefinedParameterDictionary
                f_1664_30446_30482(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.RuntimeDefinedParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 30446, 30482);
                    return return_v;
                }


                object
                f_1664_30446_30487(System.Management.Automation.RuntimeDefinedParameterDictionary
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 30446, 30487);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1664_30802_30828(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 30802, 30828);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1664_30802_30844(System.Management.Automation.SessionStateInternal
                this_param, bool
                isScriptScope)
                {
                    var return_v = this_param.NewScope(isScriptScope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 30802, 30844);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1664_30867_30893(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 30867, 30893);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1664_30940_30966(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 30940, 30966);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1664_30940_30979(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 30940, 30979);
                    return return_v;
                }


                System.Management.Automation.MutableTuple
                f_1664_31054_31200(System.Type
                tupleType, System.Collections.Generic.Dictionary<string, int>
                nameToIndexMap)
                {
                    var return_v = MutableTuple.MakeTuple(tupleType, nameToIndexMap);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 31054, 31200);
                    return return_v;
                }


                System.Management.Automation.RuntimeDefinedParameterDictionary
                f_1664_31376_31412(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.RuntimeDefinedParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 31376, 31412);
                    return return_v;
                }


                object
                f_1664_31376_31417(System.Management.Automation.RuntimeDefinedParameterDictionary
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 31376, 31417);
                    return return_v;
                }


                object[]
                f_1664_31273_31483(object
                parameters, object[]
                args, System.Management.Automation.ExecutionContext
                context, bool
                dotting, System.Collections.Generic.Dictionary<string, System.Management.Automation.PSVariable>
                backupWhenDotting, System.Management.Automation.MutableTuple
                locals)
                {
                    var return_v = ScriptBlock.BindArgumentsForScriptblockInvoke((System.Management.Automation.RuntimeDefinedParameter[])parameters, args, context, dotting, backupWhenDotting, locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 31273, 31483);
                    return return_v;
                }


                int
                f_1664_31506_31581(System.Management.Automation.MutableTuple
                this_param, System.Management.Automation.AutomaticVariable
                auto, object[]
                value, System.Management.Automation.ExecutionContext
                context)
                {
                    this_param.SetAutomaticVariable(auto, (object)value, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 31506, 31581);
                    return 0;
                }


                System.Management.Automation.PSLanguageMode?
                f_1664_31941_31965(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 31941, 31965);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandBaseAst>
                f_1664_32044_32072(System.Management.Automation.Language.PipelineAst
                this_param)
                {
                    var return_v = this_param.PipelineElements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 32044, 32072);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.Language.CommandAst>
                f_1664_32044_32091(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandBaseAst>
                source)
                {
                    var return_v = source.Cast<System.Management.Automation.Language.CommandAst>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 32044, 32091);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CommandParameterInternal>
                f_1664_32157_32193()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.CommandParameterInternal>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 32157, 32193);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                f_1664_32247_32273(System.Management.Automation.Language.CommandAst
                this_param)
                {
                    var return_v = this_param.CommandElements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 32247, 32273);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1664_32524_32584(System.Management.Automation.Language.CommandParameterAst
                commandParameterAst, bool
                isTrusted, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = GetCommandParameter(commandParameterAst, isTrusted, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 32524, 32584);
                    return return_v;
                }


                int
                f_1664_32502_32585(System.Collections.Generic.List<System.Management.Automation.CommandParameterInternal>
                this_param, System.Management.Automation.CommandParameterInternal
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 32502, 32585);
                    return 0;
                }


                object
                f_1664_32765_32821(System.Management.Automation.Language.ExpressionAst
                expressionAst, bool
                isTrustedInput, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = Compiler.GetExpressionValue(expressionAst, isTrustedInput, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 32765, 32821);
                    return return_v;
                }


                bool
                f_1664_32901_32942(System.Management.Automation.Language.VariableExpressionAst
                this_param)
                {
                    var return_v = this_param.Splatted;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 32901, 32942);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1664_32992_33061(object
                value, System.Management.Automation.Language.ExpressionAst
                ast, bool
                splatted)
                {
                    var return_v = CommandParameterInternal.CreateArgument(value, (System.Management.Automation.Language.Ast)ast, splatted);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 32992, 33061);
                    return return_v;
                }


                int
                f_1664_32970_33062(System.Collections.Generic.List<System.Management.Automation.CommandParameterInternal>
                this_param, System.Management.Automation.CommandParameterInternal
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 32970, 33062);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                f_1664_32247_32273_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 32247, 32273);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CommandRedirection>
                f_1664_33129_33159()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.CommandRedirection>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 33129, 33159);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.RedirectionAst>
                f_1664_33210_33233(System.Management.Automation.Language.CommandAst
                this_param)
                {
                    var return_v = this_param.Redirections;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 33210, 33233);
                    return return_v;
                }


                System.Management.Automation.CommandRedirection
                f_1664_33300_33354(System.Management.Automation.Language.RedirectionAst
                redirectionAst, bool
                isTrusted, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = GetCommandRedirection(redirectionAst, isTrusted, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 33300, 33354);
                    return return_v;
                }


                int
                f_1664_33283_33355(System.Collections.Generic.List<System.Management.Automation.CommandRedirection>
                this_param, System.Management.Automation.CommandRedirection
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 33283, 33355);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.RedirectionAst>
                f_1664_33210_33233_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.RedirectionAst>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 33210, 33233);
                    return return_v;
                }


                System.Tuple<System.Management.Automation.Language.CommandAst, System.Collections.Generic.List<System.Management.Automation.CommandParameterInternal>, System.Collections.Generic.List<System.Management.Automation.CommandRedirection>>
                f_1664_33421_33478(System.Management.Automation.Language.CommandAst
                item1, System.Collections.Generic.List<System.Management.Automation.CommandParameterInternal>
                item2, System.Collections.Generic.List<System.Management.Automation.CommandRedirection>
                item3)
                {
                    var return_v = Tuple.Create(item1, item2, item3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 33421, 33478);
                    return return_v;
                }


                int
                f_1664_33403_33479(System.Collections.Generic.List<System.Tuple<System.Management.Automation.Language.CommandAst, System.Collections.Generic.List<System.Management.Automation.CommandParameterInternal>, System.Collections.Generic.List<System.Management.Automation.CommandRedirection>>>
                this_param, System.Tuple<System.Management.Automation.Language.CommandAst, System.Collections.Generic.List<System.Management.Automation.CommandParameterInternal>, System.Collections.Generic.List<System.Management.Automation.CommandRedirection>>
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 33403, 33479);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.Language.CommandAst>
                f_1664_32044_32091_I(System.Collections.Generic.IEnumerable<System.Management.Automation.Language.CommandAst>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 32044, 32091);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1664_33626_33652(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 33626, 33652);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1664_33665_33691(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 33665, 33691);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1664_33665_33704(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 33665, 33704);
                    return return_v;
                }


                int
                f_1664_33626_33705(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.SessionStateScope
                scope)
                {
                    this_param.RemoveScope(scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 33626, 33705);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.CommandParameterInternal>
                f_1664_33885_33903(System.Tuple<System.Management.Automation.Language.CommandAst, System.Collections.Generic.List<System.Management.Automation.CommandParameterInternal>, System.Collections.Generic.List<System.Management.Automation.CommandRedirection>>
                this_param)
                {
                    var return_v = this_param.Item2;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 33885, 33903);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal[]
                f_1664_33885_33913(System.Collections.Generic.List<System.Management.Automation.CommandParameterInternal>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 33885, 33913);
                    return return_v;
                }


                System.Management.Automation.Language.CommandAst
                f_1664_33915_33933(System.Tuple<System.Management.Automation.Language.CommandAst, System.Collections.Generic.List<System.Management.Automation.CommandParameterInternal>, System.Collections.Generic.List<System.Management.Automation.CommandRedirection>>
                this_param)
                {
                    var return_v = this_param.Item1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 33915, 33933);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CommandRedirection>
                f_1664_33935_33953(System.Tuple<System.Management.Automation.Language.CommandAst, System.Collections.Generic.List<System.Management.Automation.CommandParameterInternal>, System.Collections.Generic.List<System.Management.Automation.CommandRedirection>>
                this_param)
                {
                    var return_v = this_param.Item3;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 33935, 33953);
                    return return_v;
                }


                System.Management.Automation.CommandRedirection[]
                f_1664_33935_33963(System.Collections.Generic.List<System.Management.Automation.CommandRedirection>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 33935, 33963);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1664_33855_33973(System.Management.Automation.Internal.PipelineProcessor
                pipe, System.Management.Automation.CommandParameterInternal[]
                commandElements, System.Management.Automation.Language.CommandAst
                commandBaseAst, System.Management.Automation.CommandRedirection[]
                redirections, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = AddCommand(pipe, commandElements, (System.Management.Automation.Language.CommandBaseAst)commandBaseAst, redirections, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 33855, 33973);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1664_33992_34016(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 33992, 34016);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1664_34073_34102(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 34073, 34102);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1664_34149_34173(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 34149, 34173);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1664_34149_34186(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 34149, 34186);
                    return return_v;
                }


                System.Management.Automation.ScriptDebugger
                f_1664_34709_34725(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Debugger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 34709, 34725);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.CallStackFrame>
                f_1664_34709_34740(System.Management.Automation.ScriptDebugger
                this_param)
                {
                    var return_v = this_param.GetCallStack();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 34709, 34740);
                    return return_v;
                }


                System.Management.Automation.CallStackFrame[]
                f_1664_34709_34750(System.Collections.Generic.IEnumerable<System.Management.Automation.CallStackFrame>
                source)
                {
                    var return_v = source.ToArray<System.Management.Automation.CallStackFrame>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 34709, 34750);
                    return return_v;
                }


                int
                f_1664_34773_34789(System.Management.Automation.CallStackFrame[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 34773, 34789);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1664_34811_34832(System.Management.Automation.CallStackFrame
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 34811, 34832);
                    return return_v;
                }


                string
                f_1664_34811_34837(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 34811, 34837);
                    return return_v;
                }


                bool
                f_1664_34797_34887(string
                input, string
                pattern, System.Text.RegularExpressions.RegexOptions
                options)
                {
                    var return_v = Regex.IsMatch(input, pattern, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 34797, 34887);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1664_34948_34972(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 34948, 34972);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1664_34948_34985(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 34948, 34985);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1664_35038_35065(System.Management.Automation.CallStackFrame
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 35038, 35065);
                    return return_v;
                }


                string
                f_1664_35038_35080(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.InvocationName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 35038, 35080);
                    return return_v;
                }


                int
                f_1664_35107_35123(System.Management.Automation.CallStackFrame[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 35107, 35123);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1664_35199_35220(System.Management.Automation.CallStackFrame
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 35199, 35220);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1664_35297_35326()
                {
                    var return_v = PositionUtilities.EmptyExtent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 35297, 35326);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1664_35614_35645(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentCommandProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 35614, 35645);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1664_35657_35688(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentCommandProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 35657, 35688);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1664_35657_35703(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 35657, 35703);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1664_35753_35784(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 35753, 35784);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1664_35805_35836(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentCommandProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 35805, 35836);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1664_35805_35851(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 35805, 35851);
                    return return_v;
                }


                int
                f_1664_35753_35852(System.Management.Automation.MshCommandRuntime
                this_param, System.Management.Automation.MshCommandRuntime
                fromRuntime)
                {
                    this_param.SetMergeFromRuntime(fromRuntime);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 35753, 35852);
                    return 0;
                }


                System.Collections.Generic.List<System.Tuple<System.Management.Automation.Language.CommandAst, System.Collections.Generic.List<System.Management.Automation.CommandParameterInternal>, System.Collections.Generic.List<System.Management.Automation.CommandRedirection>>>
                f_1664_33785_33798_I(System.Collections.Generic.List<System.Tuple<System.Management.Automation.Language.CommandAst, System.Collections.Generic.List<System.Management.Automation.CommandParameterInternal>, System.Collections.Generic.List<System.Management.Automation.CommandRedirection>>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 33785, 33798);
                    return return_v;
                }


                System.Management.Automation.SteppablePipeline
                f_1664_35910_35959(System.Management.Automation.ExecutionContext
                context, System.Management.Automation.Internal.PipelineProcessor
                pipeline)
                {
                    var return_v = new System.Management.Automation.SteppablePipeline(context, pipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 35910, 35959);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 28951, 35971);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 28951, 35971);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static CommandParameterInternal GetCommandParameter(CommandParameterAst commandParameterAst, bool isTrusted, ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 35983, 37131);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 36150, 36197);

                var
                argumentAst = f_1664_36168_36196(commandParameterAst)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 36211, 36260);

                var
                errorPos = f_1664_36226_36259(commandParameterAst)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 36276, 36467) || true) && (argumentAst == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 36276, 36467);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 36333, 36452);

                    return f_1664_36340_36451(f_1664_36381_36414(commandParameterAst), f_1664_36416_36429(errorPos), commandParameterAst);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 36276, 36467);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 36483, 36567);

                object
                argumentValue = f_1664_36506_36566(argumentAst, isTrusted, context)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 36581, 36780);

                bool
                spaceAfterParameter = (f_1664_36609_36631(errorPos) != f_1664_36635_36669(f_1664_36635_36653(argumentAst)) || (DynAbs.Tracing.TraceSender.Expression_False(1664, 36609, 36778) || f_1664_36714_36738(errorPos) != f_1664_36742_36778(f_1664_36742_36760(argumentAst))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 36794, 37120);

                return f_1664_36801_37119(commandParameterAst, f_1664_36875_36908(commandParameterAst), f_1664_36983_36996(errorPos), argumentAst, argumentValue, spaceAfterParameter);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 35983, 37131);

                System.Management.Automation.Language.ExpressionAst
                f_1664_36168_36196(System.Management.Automation.Language.CommandParameterAst
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 36168, 36196);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1664_36226_36259(System.Management.Automation.Language.CommandParameterAst
                this_param)
                {
                    var return_v = this_param.ErrorPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 36226, 36259);
                    return return_v;
                }


                string
                f_1664_36381_36414(System.Management.Automation.Language.CommandParameterAst
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 36381, 36414);
                    return return_v;
                }


                string
                f_1664_36416_36429(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 36416, 36429);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1664_36340_36451(string
                parameterName, string
                parameterText, System.Management.Automation.Language.CommandParameterAst
                ast)
                {
                    var return_v = CommandParameterInternal.CreateParameter(parameterName, parameterText, (System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 36340, 36451);
                    return return_v;
                }


                object
                f_1664_36506_36566(System.Management.Automation.Language.ExpressionAst
                expressionAst, bool
                isTrustedInput, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = Compiler.GetExpressionValue(expressionAst, isTrustedInput, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 36506, 36566);
                    return return_v;
                }


                int
                f_1664_36609_36631(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndLineNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 36609, 36631);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1664_36635_36653(System.Management.Automation.Language.ExpressionAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 36635, 36653);
                    return return_v;
                }


                int
                f_1664_36635_36669(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartLineNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 36635, 36669);
                    return return_v;
                }


                int
                f_1664_36714_36738(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndColumnNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 36714, 36738);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1664_36742_36760(System.Management.Automation.Language.ExpressionAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 36742, 36760);
                    return return_v;
                }


                int
                f_1664_36742_36778(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartColumnNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 36742, 36778);
                    return return_v;
                }


                string
                f_1664_36875_36908(System.Management.Automation.Language.CommandParameterAst
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 36875, 36908);
                    return return_v;
                }


                string
                f_1664_36983_36996(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 36983, 36996);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1664_36801_37119(System.Management.Automation.Language.CommandParameterAst
                parameterAst, string
                parameterName, string
                parameterText, System.Management.Automation.Language.ExpressionAst
                argumentAst, object
                value, bool
                spaceAfterParameter)
                {
                    var return_v = CommandParameterInternal.CreateParameterWithArgument((System.Management.Automation.Language.Ast)parameterAst, parameterName, parameterText, (System.Management.Automation.Language.Ast)argumentAst, value, spaceAfterParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 36801, 37119);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 35983, 37131);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 35983, 37131);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static CommandRedirection GetCommandRedirection(RedirectionAst redirectionAst, bool isTrusted, ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 37143, 37858);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 37296, 37355);

                var
                fileRedirection = redirectionAst as FileRedirectionAst
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 37369, 37655) || true) && (fileRedirection != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 37369, 37655);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 37430, 37522);

                    object
                    fileName = f_1664_37448_37521(f_1664_37476_37500(fileRedirection), isTrusted, context)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 37540, 37640);

                    return f_1664_37547_37639(f_1664_37567_37593(fileRedirection), f_1664_37595_37617(fileRedirection), f_1664_37619_37638(fileName));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 37369, 37655);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 37671, 37737);

                var
                mergingRedirectionAst = (MergingRedirectionAst)redirectionAst
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 37751, 37847);

                return f_1664_37758_37846(f_1664_37781_37813(mergingRedirectionAst), f_1664_37815_37845(mergingRedirectionAst));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 37143, 37858);

                System.Management.Automation.Language.ExpressionAst
                f_1664_37476_37500(System.Management.Automation.Language.FileRedirectionAst
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 37476, 37500);
                    return return_v;
                }


                object
                f_1664_37448_37521(System.Management.Automation.Language.ExpressionAst
                expressionAst, bool
                isTrustedInput, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = Compiler.GetExpressionValue(expressionAst, isTrustedInput, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 37448, 37521);
                    return return_v;
                }


                System.Management.Automation.Language.RedirectionStream
                f_1664_37567_37593(System.Management.Automation.Language.FileRedirectionAst
                this_param)
                {
                    var return_v = this_param.FromStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 37567, 37593);
                    return return_v;
                }


                bool
                f_1664_37595_37617(System.Management.Automation.Language.FileRedirectionAst
                this_param)
                {
                    var return_v = this_param.Append;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 37595, 37617);
                    return return_v;
                }


                string?
                f_1664_37619_37638(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 37619, 37638);
                    return return_v;
                }


                System.Management.Automation.FileRedirection
                f_1664_37547_37639(System.Management.Automation.Language.RedirectionStream
                from, bool
                appending, string
                file)
                {
                    var return_v = new System.Management.Automation.FileRedirection(from, appending, file);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 37547, 37639);
                    return return_v;
                }


                System.Management.Automation.Language.RedirectionStream
                f_1664_37781_37813(System.Management.Automation.Language.MergingRedirectionAst
                this_param)
                {
                    var return_v = this_param.FromStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 37781, 37813);
                    return return_v;
                }


                System.Management.Automation.Language.RedirectionStream
                f_1664_37815_37845(System.Management.Automation.Language.MergingRedirectionAst
                this_param)
                {
                    var return_v = this_param.ToStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 37815, 37845);
                    return return_v;
                }


                System.Management.Automation.MergingRedirection
                f_1664_37758_37846(System.Management.Automation.Language.RedirectionStream
                from, System.Management.Automation.Language.RedirectionStream
                to)
                {
                    var return_v = new System.Management.Automation.MergingRedirection(from, to);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 37758, 37846);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 37143, 37858);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 37143, 37858);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object PipelineResult(List<object> resultList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 37870, 38368);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 37957, 37992);

                var
                resultCount = f_1664_37975_37991(resultList)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 38006, 38103) || true) && (resultCount == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 38006, 38103);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 38060, 38088);

                    return f_1664_38067_38087();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 38006, 38103);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 38119, 38188);

                var
                result = (DynAbs.Tracing.TraceSender.Conditional_F1(1664, 38132, 38148) || ((resultCount == 1 && DynAbs.Tracing.TraceSender.Conditional_F2(1664, 38151, 38164)) || DynAbs.Tracing.TraceSender.Conditional_F3(1664, 38167, 38187))) ? f_1664_38151_38164(resultList, 0) : f_1664_38167_38187(resultList)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 38310, 38329);

                f_1664_38310_38328(            // Clear the array list so that we don't write the results of the pipe when flushing the pipe.
                            resultList);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 38343, 38357);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 37870, 38368);

                int
                f_1664_37975_37991(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 37975, 37991);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1664_38067_38087()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 38067, 38087);
                    return return_v;
                }


                object
                f_1664_38151_38164(System.Collections.Generic.List<object>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 38151, 38164);
                    return return_v;
                }


                object[]
                f_1664_38167_38187(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 38167, 38187);
                    return return_v;
                }


                int
                f_1664_38310_38328(System.Collections.Generic.List<object>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 38310, 38328);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 37870, 38368);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 37870, 38368);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void FlushPipe(Pipe oldPipe, List<object> resultList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 38380, 38602);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 38483, 38488);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 38474, 38591) || true) && (i < f_1664_38494_38510(resultList))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 38512, 38515)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 38474, 38591))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 38474, 38591);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 38549, 38576);

                        f_1664_38549_38575(oldPipe, f_1664_38561_38574(resultList, i));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 1, 118);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 1, 118);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 38380, 38602);

                int
                f_1664_38494_38510(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 38494, 38510);
                    return return_v;
                }


                object
                f_1664_38561_38574(System.Collections.Generic.List<object>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 38561, 38574);
                    return return_v;
                }


                int
                f_1664_38549_38575(System.Management.Automation.Internal.Pipe
                this_param, object
                obj)
                {
                    this_param.Add(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 38549, 38575);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 38380, 38602);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 38380, 38602);
            }
        }

        internal static void ClearPipe(List<object> resultList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 38614, 38724);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 38694, 38713);

                f_1664_38694_38712(resultList);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 38614, 38724);

                int
                f_1664_38694_38712(System.Collections.Generic.List<object>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 38694, 38712);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 38614, 38724);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 38614, 38724);
            }
        }

        internal static ExitException GetExitException(object exitCodeObj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 38736, 39250);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 38827, 38844);

                int
                exitCode = 0
                ;

                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 38896, 39080) || true) && (!f_1664_38901_38939(exitCodeObj))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 38896, 39080);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 38981, 39061);

                        exitCode = f_1664_38992_39060(exitCodeObj, f_1664_39030_39059());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 38896, 39080);
                    }
                }
                catch (Exception) // ignore non-severe exceptions
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1664, 39109, 39188);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1664, 39109, 39188);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 39204, 39239);

                return f_1664_39211_39238(exitCode);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 38736, 39250);

                bool
                f_1664_38901_38939(object
                obj)
                {
                    var return_v = LanguagePrimitives.IsNull(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 38901, 38939);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1664_39030_39059()
                {
                    var return_v = PositionUtilities.EmptyExtent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 39030, 39059);
                    return return_v;
                }


                int
                f_1664_38992_39060(object
                obj, System.Management.Automation.Language.IScriptExtent
                errorPosition)
                {
                    var return_v = ParserOps.ConvertTo<int>(obj, errorPosition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 38992, 39060);
                    return return_v;
                }


                System.Management.Automation.ExitException
                f_1664_39211_39238(int
                argument)
                {
                    var return_v = new System.Management.Automation.ExitException((object)argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 39211, 39238);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 38736, 39250);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 38736, 39250);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void CheckForInterrupts(ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 39262, 39614);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 39352, 39466) || true) && (f_1664_39356_39370(context) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 39352, 39466);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 39412, 39451);

                    f_1664_39412_39450(f_1664_39412_39426(context));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 39352, 39466);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 39482, 39603) || true) && (f_1664_39486_39517(context))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 39482, 39603);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 39551, 39588);

                    throw f_1664_39557_39587();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 39482, 39603);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 39262, 39614);

                System.Management.Automation.PSLocalEventManager
                f_1664_39356_39370(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Events;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 39356, 39370);
                    return return_v;
                }


                System.Management.Automation.PSLocalEventManager
                f_1664_39412_39426(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Events;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 39412, 39426);
                    return return_v;
                }


                int
                f_1664_39412_39450(System.Management.Automation.PSLocalEventManager
                this_param)
                {
                    this_param.ProcessPendingActions();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 39412, 39450);
                    return 0;
                }


                bool
                f_1664_39486_39517(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentPipelineStopping;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 39486, 39517);
                    return return_v;
                }


                System.Management.Automation.PipelineStoppedException
                f_1664_39557_39587()
                {
                    var return_v = new System.Management.Automation.PipelineStoppedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 39557, 39587);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 39262, 39614);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 39262, 39614);
            }
        }

        internal static void Nop()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 39723, 39753);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 39723, 39753);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 39723, 39753);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 39723, 39753);
            }
        }

        static PipelineOps()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1664, 831, 39760);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1664, 831, 39760);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 831, 39760);
        }

    }
    internal abstract class CommandRedirection
    {
        protected CommandRedirection(RedirectionStream from)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1664, 39855, 39966);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 39978, 40037);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 39932, 39955);

                this.FromStream = from;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1664, 39855, 39966);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 39855, 39966);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 39855, 39966);
            }
        }

        internal RedirectionStream FromStream { get; private set; }

        internal abstract void Bind(PipelineProcessor pipelineProcessor, CommandProcessorBase commandProcessor, ExecutionContext context);

        internal void UnbindForExpression(FunctionContext funcContext, Pipe[] pipes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1664, 40191, 42297);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 40292, 40548) || true) && (pipes == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 40292, 40548);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 40526, 40533);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 40292, 40548);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 40564, 40608);

                var
                context = funcContext._executionContext
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 40622, 42286);

                switch (f_1664_40630_40640())
                {

                    case RedirectionStream.All:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 40622, 42286);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 40723, 40786);

                        funcContext._outputPipe = pipes[(int)RedirectionStream.Output];
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 40808, 40883);

                        context.ShellFunctionErrorOutputPipe = pipes[(int)RedirectionStream.Error];
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 40905, 40981);

                        context.ExpressionWarningOutputPipe = pipes[(int)RedirectionStream.Warning];
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 41003, 41079);

                        context.ExpressionVerboseOutputPipe = pipes[(int)RedirectionStream.Verbose];
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 41101, 41173);

                        context.ExpressionDebugOutputPipe = pipes[(int)RedirectionStream.Debug];
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 41195, 41279);

                        context.ExpressionInformationOutputPipe = pipes[(int)RedirectionStream.Information];
                        DynAbs.Tracing.TraceSender.TraceBreak(1664, 41301, 41307);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 40622, 42286);

                    case RedirectionStream.Output:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 40622, 42286);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 41377, 41440);

                        funcContext._outputPipe = pipes[(int)RedirectionStream.Output];
                        DynAbs.Tracing.TraceSender.TraceBreak(1664, 41462, 41468);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 40622, 42286);

                    case RedirectionStream.Error:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 40622, 42286);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 41537, 41599);

                        context.ShellFunctionErrorOutputPipe = pipes[(int)f_1664_41587_41597()];
                        DynAbs.Tracing.TraceSender.TraceBreak(1664, 41621, 41627);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 40622, 42286);

                    case RedirectionStream.Warning:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 40622, 42286);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 41698, 41759);

                        context.ExpressionWarningOutputPipe = pipes[(int)f_1664_41747_41757()];
                        DynAbs.Tracing.TraceSender.TraceBreak(1664, 41781, 41787);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 40622, 42286);

                    case RedirectionStream.Verbose:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 40622, 42286);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 41858, 41919);

                        context.ExpressionVerboseOutputPipe = pipes[(int)f_1664_41907_41917()];
                        DynAbs.Tracing.TraceSender.TraceBreak(1664, 41941, 41947);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 40622, 42286);

                    case RedirectionStream.Debug:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 40622, 42286);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 42016, 42075);

                        context.ExpressionDebugOutputPipe = pipes[(int)f_1664_42063_42073()];
                        DynAbs.Tracing.TraceSender.TraceBreak(1664, 42097, 42103);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 40622, 42286);

                    case RedirectionStream.Information:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 40622, 42286);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 42178, 42243);

                        context.ExpressionInformationOutputPipe = pipes[(int)f_1664_42231_42241()];
                        DynAbs.Tracing.TraceSender.TraceBreak(1664, 42265, 42271);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 40622, 42286);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1664, 40191, 42297);

                System.Management.Automation.Language.RedirectionStream
                f_1664_40630_40640()
                {
                    var return_v = FromStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 40630, 40640);
                    return return_v;
                }


                System.Management.Automation.Language.RedirectionStream
                f_1664_41587_41597()
                {
                    var return_v = FromStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 41587, 41597);
                    return return_v;
                }


                System.Management.Automation.Language.RedirectionStream
                f_1664_41747_41757()
                {
                    var return_v = FromStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 41747, 41757);
                    return return_v;
                }


                System.Management.Automation.Language.RedirectionStream
                f_1664_41907_41917()
                {
                    var return_v = FromStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 41907, 41917);
                    return return_v;
                }


                System.Management.Automation.Language.RedirectionStream
                f_1664_42063_42073()
                {
                    var return_v = FromStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 42063, 42073);
                    return return_v;
                }


                System.Management.Automation.Language.RedirectionStream
                f_1664_42231_42241()
                {
                    var return_v = FromStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 42231, 42241);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 40191, 42297);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 40191, 42297);
            }
        }

        static CommandRedirection()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1664, 39796, 42304);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1664, 39796, 42304);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 39796, 42304);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1664, 39796, 42304);
    }
    internal class MergingRedirection : CommandRedirection
    {
        internal MergingRedirection(RedirectionStream from, RedirectionStream to)
        : base(f_1664_42477_42481_C(from))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1664, 42383, 42925);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 42507, 42876) || true) && (to != RedirectionStream.Output)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 42507, 42876);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 42575, 42861);

                    throw f_1664_42581_42860(to, typeof(ArgumentException), null, "RedirectionStreamCanOnlyMergeToOutputStream", f_1664_42802_42859());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 42507, 42876);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1664, 42383, 42925);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 42383, 42925);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 42383, 42925);
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1664, 42937, 43179);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 42995, 43168);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1664, 43002, 43037) || ((f_1664_43002_43012() == RedirectionStream.All
                && DynAbs.Tracing.TraceSender.Conditional_F2(1664, 43064, 43070)) || DynAbs.Tracing.TraceSender.Conditional_F3(1664, 43097, 43167))) ? "*>&1"
                : f_1664_43097_43167(f_1664_43111_43139(), "{0}>&1", (int)f_1664_43156_43166());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1664, 42937, 43179);

                System.Management.Automation.Language.RedirectionStream
                f_1664_43002_43012()
                {
                    var return_v = FromStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 43002, 43012);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1664_43111_43139()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 43111, 43139);
                    return return_v;
                }


                System.Management.Automation.Language.RedirectionStream
                f_1664_43156_43166()
                {
                    var return_v = FromStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 43156, 43166);
                    return return_v;
                }


                string
                f_1664_43097_43167(System.Globalization.CultureInfo
                provider, string
                format, int
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 43097, 43167);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 42937, 43179);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 42937, 43179);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void Bind(PipelineProcessor pipelineProcessor, CommandProcessorBase commandProcessor, ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1664, 43404, 45079);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 43558, 43613);

                Pipe
                pipe = f_1664_43570_43612(f_1664_43570_43601(commandProcessor))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 43629, 45068);

                switch (f_1664_43637_43647())
                {

                    case RedirectionStream.All:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 43629, 45068);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 43730, 43818);

                        f_1664_43730_43761(commandProcessor).ErrorMergeTo = MshCommandRuntime.MergeDataStream.Output;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 43840, 43897);

                        f_1664_43840_43871(commandProcessor).WarningOutputPipe = pipe;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 43919, 43976);

                        f_1664_43919_43950(commandProcessor).VerboseOutputPipe = pipe;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 43998, 44053);

                        f_1664_43998_44029(commandProcessor).DebugOutputPipe = pipe;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 44075, 44136);

                        f_1664_44075_44106(commandProcessor).InformationOutputPipe = pipe;
                        DynAbs.Tracing.TraceSender.TraceBreak(1664, 44158, 44164);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 43629, 45068);

                    case RedirectionStream.Output:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 43629, 45068);
                        DynAbs.Tracing.TraceSender.TraceBreak(1664, 44234, 44240);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 43629, 45068);

                    case RedirectionStream.Error:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 43629, 45068);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 44309, 44397);

                        f_1664_44309_44340(commandProcessor).ErrorMergeTo = MshCommandRuntime.MergeDataStream.Output;
                        DynAbs.Tracing.TraceSender.TraceBreak(1664, 44419, 44425);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 43629, 45068);

                    case RedirectionStream.Warning:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 43629, 45068);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 44496, 44553);

                        f_1664_44496_44527(commandProcessor).WarningOutputPipe = pipe;
                        DynAbs.Tracing.TraceSender.TraceBreak(1664, 44575, 44581);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 43629, 45068);

                    case RedirectionStream.Verbose:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 43629, 45068);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 44652, 44709);

                        f_1664_44652_44683(commandProcessor).VerboseOutputPipe = pipe;
                        DynAbs.Tracing.TraceSender.TraceBreak(1664, 44731, 44737);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 43629, 45068);

                    case RedirectionStream.Debug:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 43629, 45068);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 44806, 44861);

                        f_1664_44806_44837(commandProcessor).DebugOutputPipe = pipe;
                        DynAbs.Tracing.TraceSender.TraceBreak(1664, 44883, 44889);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 43629, 45068);

                    case RedirectionStream.Information:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 43629, 45068);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 44964, 45025);

                        f_1664_44964_44995(commandProcessor).InformationOutputPipe = pipe;
                        DynAbs.Tracing.TraceSender.TraceBreak(1664, 45047, 45053);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 43629, 45068);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1664, 43404, 45079);

                System.Management.Automation.MshCommandRuntime
                f_1664_43570_43601(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 43570, 43601);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1664_43570_43612(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.OutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 43570, 43612);
                    return return_v;
                }


                System.Management.Automation.Language.RedirectionStream
                f_1664_43637_43647()
                {
                    var return_v = FromStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 43637, 43647);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1664_43730_43761(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 43730, 43761);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1664_43840_43871(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 43840, 43871);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1664_43919_43950(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 43919, 43950);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1664_43998_44029(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 43998, 44029);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1664_44075_44106(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 44075, 44106);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1664_44309_44340(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 44309, 44340);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1664_44496_44527(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 44496, 44527);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1664_44652_44683(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 44652, 44683);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1664_44806_44837(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 44806, 44837);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1664_44964_44995(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 44964, 44995);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 43404, 45079);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 43404, 45079);
            }
        }

        internal Pipe[] BindForExpression(ExecutionContext context, FunctionContext funcContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1664, 45266, 48084);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 45379, 45446);

                Pipe[]
                oldPipes = new Pipe[(int)RedirectionStream.Information + 1]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 45460, 45496);

                Pipe
                pipe = funcContext._outputPipe
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 45685, 48041);

                switch (f_1664_45693_45703())
                {

                    case RedirectionStream.All:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 45685, 48041);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 45786, 45852);

                        oldPipes[(int)RedirectionStream.Output] = funcContext._outputPipe;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 45874, 45952);

                        oldPipes[(int)RedirectionStream.Error] = f_1664_45915_45951(context);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 45974, 46018);

                        context.ShellFunctionErrorOutputPipe = pipe;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 46040, 46119);

                        oldPipes[(int)RedirectionStream.Warning] = f_1664_46083_46118(context);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 46141, 46184);

                        context.ExpressionWarningOutputPipe = pipe;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 46206, 46285);

                        oldPipes[(int)RedirectionStream.Verbose] = f_1664_46249_46284(context);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 46307, 46350);

                        context.ExpressionVerboseOutputPipe = pipe;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 46372, 46447);

                        oldPipes[(int)RedirectionStream.Debug] = f_1664_46413_46446(context);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 46469, 46510);

                        context.ExpressionDebugOutputPipe = pipe;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 46532, 46619);

                        oldPipes[(int)RedirectionStream.Information] = f_1664_46579_46618(context);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 46641, 46688);

                        context.ExpressionInformationOutputPipe = pipe;
                        DynAbs.Tracing.TraceSender.TraceBreak(1664, 46710, 46716);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 45685, 48041);

                    case RedirectionStream.Output:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 45685, 48041);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 46786, 46852);

                        oldPipes[(int)RedirectionStream.Output] = funcContext._outputPipe;
                        DynAbs.Tracing.TraceSender.TraceBreak(1664, 46874, 46880);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 45685, 48041);

                    case RedirectionStream.Error:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 45685, 48041);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 46949, 47014);

                        oldPipes[(int)f_1664_46963_46973()] = f_1664_46977_47013(context);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 47036, 47080);

                        context.ShellFunctionErrorOutputPipe = pipe;
                        DynAbs.Tracing.TraceSender.TraceBreak(1664, 47102, 47108);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 45685, 48041);

                    case RedirectionStream.Warning:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 45685, 48041);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 47179, 47243);

                        oldPipes[(int)f_1664_47193_47203()] = f_1664_47207_47242(context);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 47265, 47308);

                        context.ExpressionWarningOutputPipe = pipe;
                        DynAbs.Tracing.TraceSender.TraceBreak(1664, 47330, 47336);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 45685, 48041);

                    case RedirectionStream.Verbose:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 45685, 48041);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 47407, 47471);

                        oldPipes[(int)f_1664_47421_47431()] = f_1664_47435_47470(context);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 47493, 47536);

                        context.ExpressionVerboseOutputPipe = pipe;
                        DynAbs.Tracing.TraceSender.TraceBreak(1664, 47558, 47564);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 45685, 48041);

                    case RedirectionStream.Debug:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 45685, 48041);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 47633, 47695);

                        oldPipes[(int)f_1664_47647_47657()] = f_1664_47661_47694(context);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 47717, 47758);

                        context.ExpressionDebugOutputPipe = pipe;
                        DynAbs.Tracing.TraceSender.TraceBreak(1664, 47780, 47786);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 45685, 48041);

                    case RedirectionStream.Information:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 45685, 48041);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 47861, 47929);

                        oldPipes[(int)f_1664_47875_47885()] = f_1664_47889_47928(context);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 47951, 47998);

                        context.ExpressionInformationOutputPipe = pipe;
                        DynAbs.Tracing.TraceSender.TraceBreak(1664, 48020, 48026);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 45685, 48041);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 48057, 48073);

                return oldPipes;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1664, 45266, 48084);

                System.Management.Automation.Language.RedirectionStream
                f_1664_45693_45703()
                {
                    var return_v = FromStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 45693, 45703);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1664_45915_45951(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ShellFunctionErrorOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 45915, 45951);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1664_46083_46118(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ExpressionWarningOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 46083, 46118);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1664_46249_46284(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ExpressionVerboseOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 46249, 46284);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1664_46413_46446(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ExpressionDebugOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 46413, 46446);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1664_46579_46618(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ExpressionInformationOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 46579, 46618);
                    return return_v;
                }


                System.Management.Automation.Language.RedirectionStream
                f_1664_46963_46973()
                {
                    var return_v = FromStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 46963, 46973);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1664_46977_47013(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ShellFunctionErrorOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 46977, 47013);
                    return return_v;
                }


                System.Management.Automation.Language.RedirectionStream
                f_1664_47193_47203()
                {
                    var return_v = FromStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 47193, 47203);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1664_47207_47242(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ExpressionWarningOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 47207, 47242);
                    return return_v;
                }


                System.Management.Automation.Language.RedirectionStream
                f_1664_47421_47431()
                {
                    var return_v = FromStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 47421, 47431);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1664_47435_47470(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ExpressionVerboseOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 47435, 47470);
                    return return_v;
                }


                System.Management.Automation.Language.RedirectionStream
                f_1664_47647_47657()
                {
                    var return_v = FromStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 47647, 47657);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1664_47661_47694(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ExpressionDebugOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 47661, 47694);
                    return return_v;
                }


                System.Management.Automation.Language.RedirectionStream
                f_1664_47875_47885()
                {
                    var return_v = FromStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 47875, 47885);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1664_47889_47928(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ExpressionInformationOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 47889, 47928);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 45266, 48084);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 45266, 48084);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static MergingRedirection()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1664, 42312, 48091);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1664, 42312, 48091);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 42312, 48091);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1664, 42312, 48091);

        string
        f_1664_42802_42859()
        {
            var return_v = ParserStrings.RedirectionStreamCanOnlyMergeToOutputStream;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 42802, 42859);
            return return_v;
        }


        System.Management.Automation.RuntimeException
        f_1664_42581_42860(System.Management.Automation.Language.RedirectionStream
        targetObject, System.Type
        exceptionType, System.Management.Automation.Language.IScriptExtent
        errorPosition, string
        resourceIdAndErrorId, string
        resourceString, params object[]
        args)
        {
            var return_v = InterpreterError.NewInterpreterException((object)targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 42581, 42860);
            return return_v;
        }


        static System.Management.Automation.Language.RedirectionStream
        f_1664_42477_42481_C(System.Management.Automation.Language.RedirectionStream
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1664, 42383, 42925);
            return return_v;
        }

    }
    internal class FileRedirection : CommandRedirection, IDisposable
    {
        internal FileRedirection(RedirectionStream from, bool appending, string file)
        : base(f_1664_48278_48282_C(from))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1664, 48180, 48377);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 48785, 48827);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 48839, 48884);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 48896, 48953);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 58712, 58721);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 48308, 48325);

                this.File = file;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 48339, 48366);

                this.Appending = appending;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1664, 48180, 48377);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 48180, 48377);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 48180, 48377);
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1664, 48389, 48773);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 48447, 48762);

                return f_1664_48454_48761(f_1664_48468_48496(), "{0}> {1}", (DynAbs.Tracing.TraceSender.Conditional_F1(1664, 48544, 48579) || ((f_1664_48544_48554() == RedirectionStream.All
                && DynAbs.Tracing.TraceSender.Conditional_F2(1664, 48620, 48623)) || DynAbs.Tracing.TraceSender.Conditional_F3(1664, 48664, 48720))) ? "*"
                : f_1664_48664_48720(((int)f_1664_48670_48680()), f_1664_48691_48719()), f_1664_48756_48760());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1664, 48389, 48773);

                System.Globalization.CultureInfo
                f_1664_48468_48496()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 48468, 48496);
                    return return_v;
                }


                System.Management.Automation.Language.RedirectionStream
                f_1664_48544_48554()
                {
                    var return_v = FromStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 48544, 48554);
                    return return_v;
                }


                System.Management.Automation.Language.RedirectionStream
                f_1664_48670_48680()
                {
                    var return_v = FromStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 48670, 48680);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1664_48691_48719()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 48691, 48719);
                    return return_v;
                }


                string
                f_1664_48664_48720(int
                this_param, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = this_param.ToString((System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 48664, 48720);
                    return return_v;
                }


                string
                f_1664_48756_48760()
                {
                    var return_v = File;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 48756, 48760);
                    return return_v;
                }


                string
                f_1664_48454_48761(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 48454, 48761);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 48389, 48773);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 48389, 48773);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string File { get; private set; }

        internal bool Appending { get; private set; }

        private PipelineProcessor PipelineProcessor { get; set; }

        internal override void Bind(PipelineProcessor pipelineProcessor, CommandProcessorBase commandProcessor, ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1664, 49054, 51907);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 49208, 49267);

                Pipe
                pipe = f_1664_49220_49266(this, context, pipelineProcessor)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 49283, 51896);

                switch (f_1664_49291_49301())
                {

                    case RedirectionStream.All:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 49283, 51896);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 49880, 50092) || true) && (f_1664_49884_49915(context) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 49880, 50092);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 49973, 50069);

                            f_1664_49973_50068(f_1664_49973_50030(f_1664_49973_50019(f_1664_49973_50004(context))), pipe);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 49880, 50092);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 50116, 50166);

                        f_1664_50116_50147(commandProcessor).OutputPipe = pipe;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 50188, 50243);

                        f_1664_50188_50219(commandProcessor).ErrorOutputPipe = pipe;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 50265, 50322);

                        f_1664_50265_50296(commandProcessor).WarningOutputPipe = pipe;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 50344, 50401);

                        f_1664_50344_50375(commandProcessor).VerboseOutputPipe = pipe;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 50423, 50478);

                        f_1664_50423_50454(commandProcessor).DebugOutputPipe = pipe;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 50500, 50561);

                        f_1664_50500_50531(commandProcessor).InformationOutputPipe = pipe;
                        DynAbs.Tracing.TraceSender.TraceBreak(1664, 50583, 50589);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 49283, 51896);

                    case RedirectionStream.Output:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 49283, 51896);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 50787, 50999) || true) && (f_1664_50791_50822(context) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 50787, 50999);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 50880, 50976);

                            f_1664_50880_50975(f_1664_50880_50937(f_1664_50880_50926(f_1664_50880_50911(context))), pipe);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 50787, 50999);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 51023, 51073);

                        f_1664_51023_51054(commandProcessor).OutputPipe = pipe;
                        DynAbs.Tracing.TraceSender.TraceBreak(1664, 51095, 51101);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 49283, 51896);

                    case RedirectionStream.Error:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 49283, 51896);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 51170, 51225);

                        f_1664_51170_51201(commandProcessor).ErrorOutputPipe = pipe;
                        DynAbs.Tracing.TraceSender.TraceBreak(1664, 51247, 51253);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 49283, 51896);

                    case RedirectionStream.Warning:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 49283, 51896);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 51324, 51381);

                        f_1664_51324_51355(commandProcessor).WarningOutputPipe = pipe;
                        DynAbs.Tracing.TraceSender.TraceBreak(1664, 51403, 51409);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 49283, 51896);

                    case RedirectionStream.Verbose:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 49283, 51896);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 51480, 51537);

                        f_1664_51480_51511(commandProcessor).VerboseOutputPipe = pipe;
                        DynAbs.Tracing.TraceSender.TraceBreak(1664, 51559, 51565);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 49283, 51896);

                    case RedirectionStream.Debug:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 49283, 51896);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 51634, 51689);

                        f_1664_51634_51665(commandProcessor).DebugOutputPipe = pipe;
                        DynAbs.Tracing.TraceSender.TraceBreak(1664, 51711, 51717);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 49283, 51896);

                    case RedirectionStream.Information:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 49283, 51896);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 51792, 51853);

                        f_1664_51792_51823(commandProcessor).InformationOutputPipe = pipe;
                        DynAbs.Tracing.TraceSender.TraceBreak(1664, 51875, 51881);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 49283, 51896);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1664, 49054, 51907);

                System.Management.Automation.Internal.Pipe
                f_1664_49220_49266(System.Management.Automation.FileRedirection
                this_param, System.Management.Automation.ExecutionContext
                context, System.Management.Automation.Internal.PipelineProcessor
                parentPipelineProcessor)
                {
                    var return_v = this_param.GetRedirectionPipe(context, parentPipelineProcessor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 49220, 49266);
                    return return_v;
                }


                System.Management.Automation.Language.RedirectionStream
                f_1664_49291_49301()
                {
                    var return_v = FromStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 49291, 49301);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1664_49884_49915(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentCommandProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 49884, 49915);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1664_49973_50004(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentCommandProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 49973, 50004);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1664_49973_50019(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 49973, 50019);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1664_49973_50030(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.OutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 49973, 50030);
                    return return_v;
                }


                int
                f_1664_49973_50068(System.Management.Automation.Internal.Pipe
                this_param, System.Management.Automation.Internal.Pipe
                tempPipe)
                {
                    this_param.SetVariableListForTemporaryPipe(tempPipe);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 49973, 50068);
                    return 0;
                }


                System.Management.Automation.MshCommandRuntime
                f_1664_50116_50147(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 50116, 50147);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1664_50188_50219(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 50188, 50219);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1664_50265_50296(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 50265, 50296);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1664_50344_50375(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 50344, 50375);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1664_50423_50454(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 50423, 50454);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1664_50500_50531(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 50500, 50531);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1664_50791_50822(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentCommandProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 50791, 50822);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1664_50880_50911(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentCommandProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 50880, 50911);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1664_50880_50926(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 50880, 50926);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1664_50880_50937(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.OutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 50880, 50937);
                    return return_v;
                }


                int
                f_1664_50880_50975(System.Management.Automation.Internal.Pipe
                this_param, System.Management.Automation.Internal.Pipe
                tempPipe)
                {
                    this_param.SetVariableListForTemporaryPipe(tempPipe);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 50880, 50975);
                    return 0;
                }


                System.Management.Automation.MshCommandRuntime
                f_1664_51023_51054(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 51023, 51054);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1664_51170_51201(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 51170, 51201);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1664_51324_51355(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 51324, 51355);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1664_51480_51511(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 51480, 51511);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1664_51634_51665(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 51634, 51665);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1664_51792_51823(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 51792, 51823);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 49054, 51907);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 49054, 51907);
            }
        }

        internal Pipe[] BindForExpression(FunctionContext funcContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1664, 52030, 55431);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 52117, 52161);

                var
                context = funcContext._executionContext
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 52360, 52406);

                Pipe
                pipe = f_1664_52372_52405(this, context, null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 52420, 52484);

                var
                oldPipes = new Pipe[(int)RedirectionStream.Information + 1]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 52500, 55388);

                switch (f_1664_52508_52518())
                {

                    case RedirectionStream.All:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 52500, 55388);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 52601, 52667);

                        oldPipes[(int)RedirectionStream.Output] = funcContext._outputPipe;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 52689, 52767);

                        oldPipes[(int)RedirectionStream.Error] = f_1664_52730_52766(context);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 52789, 52868);

                        oldPipes[(int)RedirectionStream.Warning] = f_1664_52832_52867(context);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 52890, 52969);

                        oldPipes[(int)RedirectionStream.Verbose] = f_1664_52933_52968(context);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 52991, 53066);

                        oldPipes[(int)RedirectionStream.Debug] = f_1664_53032_53065(context);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 53088, 53175);

                        oldPipes[(int)RedirectionStream.Information] = f_1664_53135_53174(context);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 53327, 53389);

                        f_1664_53327_53388(
                                            // Since a temp output pipe is going to be used, we should pass along the error and warning variable list.
                                            funcContext._outputPipe, pipe);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 53411, 53442);

                        funcContext._outputPipe = pipe;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 53464, 53508);

                        context.ShellFunctionErrorOutputPipe = pipe;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 53530, 53573);

                        context.ExpressionWarningOutputPipe = pipe;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 53595, 53638);

                        context.ExpressionVerboseOutputPipe = pipe;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 53660, 53701);

                        context.ExpressionDebugOutputPipe = pipe;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 53723, 53770);

                        context.ExpressionInformationOutputPipe = pipe;
                        DynAbs.Tracing.TraceSender.TraceBreak(1664, 53792, 53798);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 52500, 55388);

                    case RedirectionStream.Output:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 52500, 55388);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 53868, 53934);

                        oldPipes[(int)RedirectionStream.Output] = funcContext._outputPipe;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 54084, 54146);

                        f_1664_54084_54145(                    // Since a temp output pipe is going to be used, we should pass along the error and warning variable list.
                                            funcContext._outputPipe, pipe);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 54168, 54199);

                        funcContext._outputPipe = pipe;
                        DynAbs.Tracing.TraceSender.TraceBreak(1664, 54221, 54227);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 52500, 55388);

                    case RedirectionStream.Error:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 52500, 55388);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 54296, 54361);

                        oldPipes[(int)f_1664_54310_54320()] = f_1664_54324_54360(context);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 54383, 54427);

                        context.ShellFunctionErrorOutputPipe = pipe;
                        DynAbs.Tracing.TraceSender.TraceBreak(1664, 54449, 54455);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 52500, 55388);

                    case RedirectionStream.Warning:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 52500, 55388);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 54526, 54590);

                        oldPipes[(int)f_1664_54540_54550()] = f_1664_54554_54589(context);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 54612, 54655);

                        context.ExpressionWarningOutputPipe = pipe;
                        DynAbs.Tracing.TraceSender.TraceBreak(1664, 54677, 54683);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 52500, 55388);

                    case RedirectionStream.Verbose:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 52500, 55388);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 54754, 54818);

                        oldPipes[(int)f_1664_54768_54778()] = f_1664_54782_54817(context);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 54840, 54883);

                        context.ExpressionVerboseOutputPipe = pipe;
                        DynAbs.Tracing.TraceSender.TraceBreak(1664, 54905, 54911);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 52500, 55388);

                    case RedirectionStream.Debug:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 52500, 55388);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 54980, 55042);

                        oldPipes[(int)f_1664_54994_55004()] = f_1664_55008_55041(context);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 55064, 55105);

                        context.ExpressionDebugOutputPipe = pipe;
                        DynAbs.Tracing.TraceSender.TraceBreak(1664, 55127, 55133);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 52500, 55388);

                    case RedirectionStream.Information:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 52500, 55388);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 55208, 55276);

                        oldPipes[(int)f_1664_55222_55232()] = f_1664_55236_55275(context);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 55298, 55345);

                        context.ExpressionInformationOutputPipe = pipe;
                        DynAbs.Tracing.TraceSender.TraceBreak(1664, 55367, 55373);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 52500, 55388);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 55404, 55420);

                return oldPipes;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1664, 52030, 55431);

                System.Management.Automation.Internal.Pipe
                f_1664_52372_52405(System.Management.Automation.FileRedirection
                this_param, System.Management.Automation.ExecutionContext
                context, System.Management.Automation.Internal.PipelineProcessor
                parentPipelineProcessor)
                {
                    var return_v = this_param.GetRedirectionPipe(context, parentPipelineProcessor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 52372, 52405);
                    return return_v;
                }


                System.Management.Automation.Language.RedirectionStream
                f_1664_52508_52518()
                {
                    var return_v = FromStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 52508, 52518);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1664_52730_52766(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ShellFunctionErrorOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 52730, 52766);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1664_52832_52867(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ExpressionWarningOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 52832, 52867);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1664_52933_52968(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ExpressionVerboseOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 52933, 52968);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1664_53032_53065(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ExpressionDebugOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 53032, 53065);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1664_53135_53174(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ExpressionInformationOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 53135, 53174);
                    return return_v;
                }


                int
                f_1664_53327_53388(System.Management.Automation.Internal.Pipe
                this_param, System.Management.Automation.Internal.Pipe
                tempPipe)
                {
                    this_param.SetVariableListForTemporaryPipe(tempPipe);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 53327, 53388);
                    return 0;
                }


                int
                f_1664_54084_54145(System.Management.Automation.Internal.Pipe
                this_param, System.Management.Automation.Internal.Pipe
                tempPipe)
                {
                    this_param.SetVariableListForTemporaryPipe(tempPipe);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 54084, 54145);
                    return 0;
                }


                System.Management.Automation.Language.RedirectionStream
                f_1664_54310_54320()
                {
                    var return_v = FromStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 54310, 54320);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1664_54324_54360(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ShellFunctionErrorOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 54324, 54360);
                    return return_v;
                }


                System.Management.Automation.Language.RedirectionStream
                f_1664_54540_54550()
                {
                    var return_v = FromStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 54540, 54550);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1664_54554_54589(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ExpressionWarningOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 54554, 54589);
                    return return_v;
                }


                System.Management.Automation.Language.RedirectionStream
                f_1664_54768_54778()
                {
                    var return_v = FromStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 54768, 54778);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1664_54782_54817(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ExpressionVerboseOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 54782, 54817);
                    return return_v;
                }


                System.Management.Automation.Language.RedirectionStream
                f_1664_54994_55004()
                {
                    var return_v = FromStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 54994, 55004);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1664_55008_55041(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ExpressionDebugOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 55008, 55041);
                    return return_v;
                }


                System.Management.Automation.Language.RedirectionStream
                f_1664_55222_55232()
                {
                    var return_v = FromStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 55222, 55232);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1664_55236_55275(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ExpressionInformationOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 55236, 55275);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 52030, 55431);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 52030, 55431);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Pipe GetRedirectionPipe(ExecutionContext context, PipelineProcessor parentPipelineProcessor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1664, 55443, 57933);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 55569, 55689) || true) && (f_1664_55573_55604(f_1664_55599_55603()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 55569, 55689);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 55638, 55674);

                    return new Pipe { NullPipe = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 1664, 55645, 55673) };
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 55569, 55689);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 55705, 55786);

                CommandProcessorBase
                commandProcessor = f_1664_55745_55785(context, "out-file", false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 55800, 55876);

                f_1664_55800_55875(commandProcessor != null, "CreateCommand returned null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 56112, 56309);

                var
                cpi = f_1664_56122_56308(null, "Filepath", "-Filepath:", null, f_1664_56279_56283(), false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 56323, 56358);

                f_1664_56323_56357(commandProcessor, cpi);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 56374, 56695) || true) && (f_1664_56378_56392(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 56374, 56695);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 56426, 56627);

                    cpi = f_1664_56432_56626(null, "Append", "-Append:", null, true, false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 56645, 56680);

                    f_1664_56645_56679(commandProcessor, cpi);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 56374, 56695);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 56711, 56755);

                PipelineProcessor = f_1664_56731_56754();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 56769, 56809);

                f_1664_56769_56808(f_1664_56769_56786(), commandProcessor);

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 56861, 56899);

                    f_1664_56861_56898(f_1664_56861_56878(), true);
                }
                catch (RuntimeException rte)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1664, 56928, 57588);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 57150, 57547) || true) && (f_1664_57154_57179(f_1664_57154_57169(rte)) is System.ArgumentException)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 57150, 57547);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 57249, 57528);

                        throw f_1664_57255_57527(null, typeof(RuntimeException), null, "RedirectionFailed", f_1664_57398_57429(), f_1664_57460_57485(f_1664_57460_57475(rte)), f_1664_57487_57491(), f_1664_57493_57526(f_1664_57493_57518(f_1664_57493_57508(rte))));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 57150, 57547);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 57567, 57573);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1664, 56928, 57588);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 57604, 57862) || true) && (parentPipelineProcessor != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 57604, 57862);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 57785, 57847);

                    f_1664_57785_57846(                // I think this is only necessary for calling Dispose on the commands in the redirection pipe.
                                    parentPipelineProcessor, f_1664_57828_57845());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 57604, 57862);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 57878, 57922);

                return f_1664_57885_57921(context, f_1664_57903_57920());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1664, 55443, 57933);

                string
                f_1664_55599_55603()
                {
                    var return_v = File;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 55599, 55603);
                    return return_v;
                }


                bool
                f_1664_55573_55604(string
                value)
                {
                    var return_v = string.IsNullOrWhiteSpace(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 55573, 55604);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1664_55745_55785(System.Management.Automation.ExecutionContext
                this_param, string
                command, bool
                dotSource)
                {
                    var return_v = this_param.CreateCommand(command, dotSource);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 55745, 55785);
                    return return_v;
                }


                int
                f_1664_55800_55875(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 55800, 55875);
                    return 0;
                }


                string
                f_1664_56279_56283()
                {
                    var return_v = File;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 56279, 56283);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1664_56122_56308(System.Management.Automation.Language.Ast
                parameterAst, string
                parameterName, string
                parameterText, System.Management.Automation.Language.Ast
                argumentAst, string
                value, bool
                spaceAfterParameter)
                {
                    var return_v = CommandParameterInternal.CreateParameterWithArgument(parameterAst, parameterName, parameterText, argumentAst, (object)value, spaceAfterParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 56122, 56308);
                    return return_v;
                }


                int
                f_1664_56323_56357(System.Management.Automation.CommandProcessorBase
                this_param, System.Management.Automation.CommandParameterInternal
                parameter)
                {
                    this_param.AddParameter(parameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 56323, 56357);
                    return 0;
                }


                bool
                f_1664_56378_56392(System.Management.Automation.FileRedirection
                this_param)
                {
                    var return_v = this_param.Appending;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 56378, 56392);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1664_56432_56626(System.Management.Automation.Language.Ast
                parameterAst, string
                parameterName, string
                parameterText, System.Management.Automation.Language.Ast
                argumentAst, bool
                value, bool
                spaceAfterParameter)
                {
                    var return_v = CommandParameterInternal.CreateParameterWithArgument(parameterAst, parameterName, parameterText, argumentAst, (object)value, spaceAfterParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 56432, 56626);
                    return return_v;
                }


                int
                f_1664_56645_56679(System.Management.Automation.CommandProcessorBase
                this_param, System.Management.Automation.CommandParameterInternal
                parameter)
                {
                    this_param.AddParameter(parameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 56645, 56679);
                    return 0;
                }


                System.Management.Automation.Internal.PipelineProcessor
                f_1664_56731_56754()
                {
                    var return_v = new System.Management.Automation.Internal.PipelineProcessor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 56731, 56754);
                    return return_v;
                }


                System.Management.Automation.Internal.PipelineProcessor
                f_1664_56769_56786()
                {
                    var return_v = PipelineProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 56769, 56786);
                    return return_v;
                }


                int
                f_1664_56769_56808(System.Management.Automation.Internal.PipelineProcessor
                this_param, System.Management.Automation.CommandProcessorBase
                commandProcessor)
                {
                    var return_v = this_param.Add(commandProcessor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 56769, 56808);
                    return return_v;
                }


                System.Management.Automation.Internal.PipelineProcessor
                f_1664_56861_56878()
                {
                    var return_v = PipelineProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 56861, 56878);
                    return return_v;
                }


                int
                f_1664_56861_56898(System.Management.Automation.Internal.PipelineProcessor
                this_param, bool
                expectInput)
                {
                    this_param.StartStepping(expectInput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 56861, 56898);
                    return 0;
                }


                System.Management.Automation.ErrorRecord
                f_1664_57154_57169(System.Management.Automation.RuntimeException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 57154, 57169);
                    return return_v;
                }


                System.Exception
                f_1664_57154_57179(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 57154, 57179);
                    return return_v;
                }


                string
                f_1664_57398_57429()
                {
                    var return_v = ParserStrings.RedirectionFailed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 57398, 57429);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1664_57460_57475(System.Management.Automation.RuntimeException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 57460, 57475);
                    return return_v;
                }


                System.Exception
                f_1664_57460_57485(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 57460, 57485);
                    return return_v;
                }


                string
                f_1664_57487_57491()
                {
                    var return_v = File;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 57487, 57491);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1664_57493_57508(System.Management.Automation.RuntimeException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 57493, 57508);
                    return return_v;
                }


                System.Exception
                f_1664_57493_57518(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 57493, 57518);
                    return return_v;
                }


                string
                f_1664_57493_57526(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 57493, 57526);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1664_57255_57527(object
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, System.Exception
                innerException, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterExceptionWithInnerException(targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, innerException, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 57255, 57527);
                    return return_v;
                }


                System.Management.Automation.Internal.PipelineProcessor
                f_1664_57828_57845()
                {
                    var return_v = PipelineProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 57828, 57845);
                    return return_v;
                }


                int
                f_1664_57785_57846(System.Management.Automation.Internal.PipelineProcessor
                this_param, System.Management.Automation.Internal.PipelineProcessor
                pipelineProcessor)
                {
                    this_param.AddRedirectionPipe(pipelineProcessor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 57785, 57846);
                    return 0;
                }


                System.Management.Automation.Internal.PipelineProcessor
                f_1664_57903_57920()
                {
                    var return_v = PipelineProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 57903, 57920);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1664_57885_57921(System.Management.Automation.ExecutionContext
                context, System.Management.Automation.Internal.PipelineProcessor
                outputPipeline)
                {
                    var return_v = new System.Management.Automation.Internal.Pipe(context, outputPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 57885, 57921);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 55443, 57933);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 55443, 57933);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void CallDoCompleteForExpression()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1664, 58419, 58687);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 58567, 58676) || true) && (f_1664_58571_58588() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 58567, 58676);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 58630, 58661);

                    f_1664_58630_58660(f_1664_58630_58647());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 58567, 58676);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1664, 58419, 58687);

                System.Management.Automation.Internal.PipelineProcessor
                f_1664_58571_58588()
                {
                    var return_v = PipelineProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 58571, 58588);
                    return return_v;
                }


                System.Management.Automation.Internal.PipelineProcessor
                f_1664_58630_58647()
                {
                    var return_v = PipelineProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 58630, 58647);
                    return return_v;
                }


                System.Array
                f_1664_58630_58660(System.Management.Automation.Internal.PipelineProcessor
                this_param)
                {
                    var return_v = this_param.DoComplete();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 58630, 58660);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 58419, 58687);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 58419, 58687);
            }
        }

        private bool _disposed;

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1664, 58734, 58845);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 58780, 58794);

                f_1664_58780_58793(this, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 58808, 58834);

                f_1664_58808_58833(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1664, 58734, 58845);

                int
                f_1664_58780_58793(System.Management.Automation.FileRedirection
                this_param, bool
                disposing)
                {
                    this_param.Dispose(disposing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 58780, 58793);
                    return 0;
                }


                int
                f_1664_58808_58833(System.Management.Automation.FileRedirection
                obj)
                {
                    GC.SuppressFinalize((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 58808, 58833);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 58734, 58845);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 58734, 58845);
            }
        }

        private void Dispose(bool disposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1664, 58857, 59197);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 58918, 58957) || true) && (_disposed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 58918, 58957);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 58950, 58957);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 58918, 58957);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 58973, 59153) || true) && (disposing)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 58973, 59153);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 59020, 59138) || true) && (f_1664_59024_59041() != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 59020, 59138);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 59091, 59119);

                        f_1664_59091_59118(f_1664_59091_59108());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 59020, 59138);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 58973, 59153);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 59169, 59186);

                _disposed = true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1664, 58857, 59197);

                System.Management.Automation.Internal.PipelineProcessor
                f_1664_59024_59041()
                {
                    var return_v = PipelineProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 59024, 59041);
                    return return_v;
                }


                System.Management.Automation.Internal.PipelineProcessor
                f_1664_59091_59108()
                {
                    var return_v = PipelineProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 59091, 59108);
                    return return_v;
                }


                int
                f_1664_59091_59118(System.Management.Automation.Internal.PipelineProcessor
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 59091, 59118);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 58857, 59197);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 58857, 59197);
            }
        }

        static FileRedirection()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1664, 48099, 59204);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1664, 48099, 59204);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 48099, 59204);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1664, 48099, 59204);

        static System.Management.Automation.Language.RedirectionStream
        f_1664_48278_48282_C(System.Management.Automation.Language.RedirectionStream
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1664, 48180, 48377);
            return return_v;
        }

    }
    internal static class FunctionOps
    {
        internal static void DefineFunction(ExecutionContext context,
                                                    FunctionDefinitionAst functionDefinitionAst,
                                                    ScriptBlockExpressionWrapper scriptBlockExpressionWrapper)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 59293, 60576);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 59609, 59742);

                    ScriptBlock
                    scriptBlock = f_1664_59635_59741(scriptBlockExpressionWrapper, context, f_1664_59710_59740(functionDefinitionAst))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 59762, 59815);

                    var
                    expAttribute = f_1664_59781_59814(scriptBlock)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 59833, 60102) || true) && (expAttribute == null || (DynAbs.Tracing.TraceSender.Expression_False(1664, 59837, 59880) || f_1664_59861_59880(expAttribute)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 59833, 60102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 59922, 60083);

                        f_1664_59922_60082(f_1664_59922_59948(context), f_1664_59964_59990(functionDefinitionAst), scriptBlock, f_1664_60030_60081(f_1664_60030_60069(f_1664_60030_60056(context))));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 59833, 60102);
                    }
                }
                catch (Exception exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1664, 60131, 60565);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 60191, 60231);

                    var
                    rte = exception as RuntimeException
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 60249, 60419) || true) && (rte == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 60249, 60419);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 60306, 60400);

                        throw f_1664_60312_60399(exception, f_1664_60370_60398(functionDefinitionAst));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 60249, 60419);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 60439, 60526);

                    f_1664_60439_60525(rte, f_1664_60496_60524(functionDefinitionAst));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 60544, 60550);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1664, 60131, 60565);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 59293, 60576);

                bool
                f_1664_59710_59740(System.Management.Automation.Language.FunctionDefinitionAst
                this_param)
                {
                    var return_v = this_param.IsFilter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 59710, 59740);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1664_59635_59741(System.Management.Automation.ScriptBlockExpressionWrapper
                this_param, System.Management.Automation.ExecutionContext
                context, bool
                isFilter)
                {
                    var return_v = this_param.GetScriptBlock(context, isFilter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 59635, 59741);
                    return return_v;
                }


                System.Management.Automation.ExperimentalAttribute
                f_1664_59781_59814(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.ExperimentalAttribute;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 59781, 59814);
                    return return_v;
                }


                bool
                f_1664_59861_59880(System.Management.Automation.ExperimentalAttribute
                this_param)
                {
                    var return_v = this_param.ToShow;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 59861, 59880);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1664_59922_59948(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 59922, 59948);
                    return return_v;
                }


                string
                f_1664_59964_59990(System.Management.Automation.Language.FunctionDefinitionAst
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 59964, 59990);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1664_60030_60056(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 60030, 60056);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1664_60030_60069(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 60030, 60069);
                    return return_v;
                }


                System.Management.Automation.CommandOrigin
                f_1664_60030_60081(System.Management.Automation.SessionStateScope
                this_param)
                {
                    var return_v = this_param.ScopeOrigin;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 60030, 60081);
                    return return_v;
                }


                System.Management.Automation.FunctionInfo
                f_1664_59922_60082(System.Management.Automation.SessionStateInternal
                this_param, string
                name, System.Management.Automation.ScriptBlock
                function, System.Management.Automation.CommandOrigin
                origin)
                {
                    var return_v = this_param.SetFunctionRaw(name, function, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 59922, 60082);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1664_60370_60398(System.Management.Automation.Language.FunctionDefinitionAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 60370, 60398);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1664_60312_60399(System.Exception
                exception, System.Management.Automation.Language.IScriptExtent
                extent)
                {
                    var return_v = ExceptionHandlingOps.ConvertToRuntimeException(exception, extent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 60312, 60399);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1664_60496_60524(System.Management.Automation.Language.FunctionDefinitionAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 60496, 60524);
                    return return_v;
                }


                int
                f_1664_60439_60525(System.Management.Automation.RuntimeException
                exception, System.Management.Automation.Language.IScriptExtent
                extent)
                {
                    InterpreterError.UpdateExceptionErrorRecordPosition((System.Exception)exception, extent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 60439, 60525);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 59293, 60576);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 59293, 60576);
            }
        }

        static FunctionOps()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1664, 59243, 60583);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1664, 59243, 60583);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 59243, 60583);
        }

    }
    internal class ScriptBlockExpressionWrapper
    {
        private ScriptBlock _scriptBlock;

        private readonly IParameterMetadataProvider _ast;

        internal ScriptBlockExpressionWrapper(IParameterMetadataProvider ast)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1664, 60755, 60871);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 60671, 60683);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 60738, 60742);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 60849, 60860);

                _ast = ast;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1664, 60755, 60871);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 60755, 60871);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 60755, 60871);
            }
        }

        internal ScriptBlock GetScriptBlock(ExecutionContext context, bool isFilter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1664, 60883, 61522);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 61146, 61308);

                f_1664_61146_61307(_scriptBlock == null || (DynAbs.Tracing.TraceSender.Expression_False(1664, 61165, 61230) || f_1664_61189_61222(_scriptBlock) == null), "Cached script block should not hold on to session state");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 61324, 61412);

                var
                result = f_1664_61337_61411((_scriptBlock ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.ScriptBlock>(1664, 61338, 61402) ?? (_scriptBlock = f_1664_61370_61401(_ast, isFilter)))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 61426, 61483);

                result.SessionStateInternal = f_1664_61456_61482(context);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 61497, 61511);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1664, 60883, 61522);

                System.Management.Automation.SessionStateInternal
                f_1664_61189_61222(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.SessionStateInternal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 61189, 61222);
                    return return_v;
                }


                int
                f_1664_61146_61307(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 61146, 61307);
                    return 0;
                }


                System.Management.Automation.ScriptBlock
                f_1664_61370_61401(System.Management.Automation.Language.IParameterMetadataProvider
                ast, bool
                isFilter)
                {
                    var return_v = new System.Management.Automation.ScriptBlock(ast, isFilter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 61370, 61401);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1664_61337_61411(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 61337, 61411);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1664_61456_61482(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 61456, 61482);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 60883, 61522);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 60883, 61522);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ScriptBlockExpressionWrapper()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1664, 60591, 61529);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1664, 60591, 61529);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 60591, 61529);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1664, 60591, 61529);
    }
    internal static class HashtableOps
    {
        internal static void AddKeyValuePair(IDictionary hashtable, object key, object value, IScriptExtent errorExtent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 61588, 62840);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 61725, 61750);

                key = f_1664_61731_61749(key);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 61764, 62037) || true) && (key == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 61764, 62037);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 61813, 62022);

                    throw f_1664_61819_62021(hashtable, typeof(RuntimeException), errorExtent, "InvalidNullKey", f_1664_61992_62020());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 61764, 62037);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 62053, 62787) || true) && (f_1664_62057_62080(hashtable, key))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 62053, 62787);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 62303, 62362);

                    string
                    errorKeyString = f_1664_62327_62361(null, key)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 62382, 62548) || true) && (f_1664_62386_62407(errorKeyString) > 40)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 62382, 62548);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 62454, 62529);

                        errorKeyString = f_1664_62471_62502(errorKeyString, 0, 40) + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (PSObjectHelper.Ellipsis).ToString(), 1664, 62505, 62528);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 62382, 62548);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 62568, 62772);

                    throw f_1664_62574_62771(hashtable, typeof(RuntimeException), errorExtent, "DuplicateKeyInHashLiteral", f_1664_62715_62754(), errorKeyString);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 62053, 62787);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 62803, 62829);

                f_1664_62803_62828(
                            hashtable, key, value);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 61588, 62840);

                object
                f_1664_61731_61749(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 61731, 61749);
                    return return_v;
                }


                string
                f_1664_61992_62020()
                {
                    var return_v = ParserStrings.InvalidNullKey;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 61992, 62020);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1664_61819_62021(System.Collections.IDictionary
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException((object)targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 61819, 62021);
                    return return_v;
                }


                bool
                f_1664_62057_62080(System.Collections.IDictionary
                this_param, object
                key)
                {
                    var return_v = this_param.Contains(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 62057, 62080);
                    return return_v;
                }


                string
                f_1664_62327_62361(System.Management.Automation.ExecutionContext
                context, object
                obj)
                {
                    var return_v = PSObject.ToStringParser(context, obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 62327, 62361);
                    return return_v;
                }


                int
                f_1664_62386_62407(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 62386, 62407);
                    return return_v;
                }


                string
                f_1664_62471_62502(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 62471, 62502);
                    return return_v;
                }


                string
                f_1664_62715_62754()
                {
                    var return_v = ParserStrings.DuplicateKeyInHashLiteral;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 62715, 62754);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1664_62574_62771(System.Collections.IDictionary
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException((object)targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 62574, 62771);
                    return return_v;
                }


                int
                f_1664_62803_62828(System.Collections.IDictionary
                this_param, object
                key, object
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 62803, 62828);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 61588, 62840);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 61588, 62840);
            }
        }

        internal static object Add(IDictionary lvalDict, IDictionary rvalDict)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 62852, 63793);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 62947, 62973);

                IDictionary
                newDictionary
                = default(IDictionary);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 62987, 63369) || true) && (lvalDict is OrderedDictionary)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 62987, 63369);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 63138, 63217);

                    newDictionary = f_1664_63154_63216(f_1664_63176_63215());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 62987, 63369);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 62987, 63369);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 63283, 63354);

                    newDictionary = f_1664_63299_63353(f_1664_63313_63352());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 62987, 63369);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 63443, 63566);
                    foreach (object key in f_1664_63466_63479_I(f_1664_63466_63479(lvalDict)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 63443, 63566);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 63513, 63551);

                        f_1664_63513_63550(newDictionary, key, f_1664_63536_63549(lvalDict, key));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 63443, 63566);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 1, 124);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 1, 124);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 63622, 63745);
                    foreach (object key in f_1664_63645_63658_I(f_1664_63645_63658(rvalDict)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 63622, 63745);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 63692, 63730);

                        f_1664_63692_63729(newDictionary, key, f_1664_63715_63728(rvalDict, key));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 63622, 63745);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 1, 124);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 1, 124);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 63761, 63782);

                return newDictionary;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 62852, 63793);

                System.StringComparer
                f_1664_63176_63215()
                {
                    var return_v = StringComparer.CurrentCultureIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 63176, 63215);
                    return return_v;
                }


                System.Collections.Specialized.OrderedDictionary
                f_1664_63154_63216(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Specialized.OrderedDictionary((System.Collections.IEqualityComparer)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 63154, 63216);
                    return return_v;
                }


                System.StringComparer
                f_1664_63313_63352()
                {
                    var return_v = StringComparer.CurrentCultureIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 63313, 63352);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1664_63299_63353(System.StringComparer
                equalityComparer)
                {
                    var return_v = new System.Collections.Hashtable((System.Collections.IEqualityComparer)equalityComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 63299, 63353);
                    return return_v;
                }


                System.Collections.ICollection
                f_1664_63466_63479(System.Collections.IDictionary
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 63466, 63479);
                    return return_v;
                }


                object
                f_1664_63536_63549(System.Collections.IDictionary
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 63536, 63549);
                    return return_v;
                }


                int
                f_1664_63513_63550(System.Collections.IDictionary
                this_param, object
                key, object
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 63513, 63550);
                    return 0;
                }


                System.Collections.ICollection
                f_1664_63466_63479_I(System.Collections.ICollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 63466, 63479);
                    return return_v;
                }


                System.Collections.ICollection
                f_1664_63645_63658(System.Collections.IDictionary
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 63645, 63658);
                    return return_v;
                }


                object
                f_1664_63715_63728(System.Collections.IDictionary
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 63715, 63728);
                    return return_v;
                }


                int
                f_1664_63692_63729(System.Collections.IDictionary
                this_param, object
                key, object
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 63692, 63729);
                    return 0;
                }


                System.Collections.ICollection
                f_1664_63645_63658_I(System.Collections.ICollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 63645, 63658);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 62852, 63793);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 62852, 63793);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static HashtableOps()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1664, 61537, 63800);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1664, 61537, 63800);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 61537, 63800);
        }

    }
    internal static class ExceptionHandlingOps
    {
        internal class CatchAll
        {
            public CatchAll()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1664, 63867, 63894);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1664, 63867, 63894);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 63867, 63894);
            }


            static CatchAll()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1664, 63867, 63894);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1664, 63867, 63894);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 63867, 63894);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1664, 63867, 63894);
        }
        private class HandlerSearchResult
        {
            internal HandlerSearchResult()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1664, 64059, 64272);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 64301, 64308);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 64336, 64340);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 64374, 64389);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 64425, 64442);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 64122, 64135);

                    Handler = -1;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 64153, 64173);

                    Rank = int.MaxValue;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 64191, 64214);

                    ExceptionToPass = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 64232, 64257);

                    ErrorRecordToPass = null;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1664, 64059, 64272);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 64059, 64272);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 64059, 64272);
                }
            }

            internal int Handler;

            internal int Rank;

            internal Exception ExceptionToPass;

            internal ErrorRecord ErrorRecordToPass;

            static HandlerSearchResult()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1664, 64001, 64454);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1664, 64001, 64454);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 64001, 64454);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1664, 64001, 64454);
        }

        private static int[] RankExceptionTypes(Type[] types)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 65123, 66163);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 65201, 65237);

                int[]
                ranks = new int[f_1664_65223_65235(types)]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 65251, 65277);

                int
                length = f_1664_65264_65276(types)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 65517, 65681) || true) && (f_1664_65521_65563(types[length - 1], typeof(CatchAll)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 65517, 65681);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 65597, 65628);

                    ranks[length - 1] = length - 1;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 65646, 65666);

                    length = length - 1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 65517, 65681);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 65879, 65884);

                    // For each type check if it's a sub-class of any types after it.
                    // The ordering of the type array guarantees the more specific type comes first.
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 65870, 66123) || true) && (i < length - 1)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 65902, 65905)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 65870, 66123))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 65870, 66123);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 65948, 65957);
                            for (int
            j = i + 1
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 65939, 66108) || true) && (j < length)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 65971, 65974)
            , j++, DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 65939, 66108))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 65939, 66108);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 66016, 66089) || true) && (f_1664_66020_66051(types[i], types[j]))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 66016, 66089);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 66078, 66089);

                                    ranks[j]++;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 66016, 66089);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 1, 170);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 1, 170);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 1, 254);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 1, 254);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 66139, 66152);

                return ranks;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 65123, 66163);

                int
                f_1664_65223_65235(System.Type[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 65223, 65235);
                    return return_v;
                }


                int
                f_1664_65264_65276(System.Type[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 65264, 65276);
                    return return_v;
                }


                bool
                f_1664_65521_65563(System.Type
                this_param, System.Type
                o)
                {
                    var return_v = this_param.Equals(o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 65521, 65563);
                    return return_v;
                }


                bool
                f_1664_66020_66051(System.Type
                this_param, System.Type
                c)
                {
                    var return_v = this_param.IsSubclassOf(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 66020, 66051);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 65123, 66163);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 65123, 66163);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void FindAndProcessHandler(Type[] types, int[] ranks,
                                                          HandlerSearchResult current,
                                                          Exception exception,
                                                          ErrorRecord errorRecord)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 66306, 68064);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 66627, 66707);

                f_1664_66627_66706(current != null, "Caller makes sure 'current' is not null.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 66721, 66789);

                int
                handler = f_1664_66735_66788(f_1664_66761_66780(exception), types)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 66890, 66920) || true) && (handler == -1)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 66890, 66920);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 66911, 66918);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 66890, 66920);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 67654, 67680);

                int
                rank = ranks[handler]
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 67694, 68053) || true) && (rank < current.Rank || (DynAbs.Tracing.TraceSender.Expression_False(1664, 67698, 67811) || (rank == current.Rank && (DynAbs.Tracing.TraceSender.Expression_True(1664, 67739, 67810) && f_1664_67763_67810(types[current.Handler], typeof(CatchAll))))
                ))
                               )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 67694, 68053);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 67862, 67888);

                    current.Handler = handler;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 67906, 67926);

                    current.Rank = rank;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 67944, 67980);

                    current.ExceptionToPass = exception;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 67998, 68038);

                    current.ErrorRecordToPass = errorRecord;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 67694, 68053);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 66306, 68064);

                int
                f_1664_66627_66706(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 66627, 66706);
                    return 0;
                }


                System.Type
                f_1664_66761_66780(System.Exception
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 66761, 66780);
                    return return_v;
                }


                int
                f_1664_66735_66788(System.Type
                exceptionType, System.Type[]
                types)
                {
                    var return_v = FindMatchingHandlerByType(exceptionType, types);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 66735, 66788);
                    return return_v;
                }


                bool
                f_1664_67763_67810(System.Type
                this_param, System.Type
                o)
                {
                    var return_v = this_param.Equals(o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 67763, 67810);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 66306, 68064);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 66306, 68064);
            }
        }

        internal static int FindMatchingHandler(MutableTuple tuple, RuntimeException rte, Type[] types, ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 68188, 71586);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 68334, 68364);

                bool
                continueToSearch = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 68378, 68418);

                int[]
                ranks = f_1664_68392_68417(types)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 68432, 68472);

                var
                current = f_1664_68446_68471()
                ;
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 68488, 71265);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 68609, 68634);

                            continueToSearch = false;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 68744, 68792);

                            ErrorRecord
                            errorRecordToPass = f_1664_68776_68791(rte)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 68812, 68849);

                            Exception
                            inner = f_1664_68830_68848(rte)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 68867, 69016) || true) && (inner != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 68867, 69016);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 68926, 68997);

                                f_1664_68926_68996(types, ranks, current, inner, errorRecordToPass);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 68867, 69016);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 69430, 69580) || true) && (current.Rank > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 69430, 69580);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 69492, 69561);

                                f_1664_69492_69560(types, ranks, current, rte, errorRecordToPass);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 69430, 69580);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 70043, 71224) || true) && (current.Rank > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 70043, 71224);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 70105, 70153);

                                var
                                apse = rte as ActionPreferenceStopException
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 70175, 71205) || true) && (apse != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 70175, 71205);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 70241, 70290);

                                    var
                                    exceptionToPass = f_1664_70263_70289(f_1664_70263_70279(apse))
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 70410, 70452);

                                    rte = exceptionToPass as RuntimeException;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 70478, 70826) || true) && (rte != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 70478, 70826);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 70551, 70575);

                                        continueToSearch = true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 70478, 70826);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 70478, 70826);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 70633, 70826) || true) && (exceptionToPass != null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 70633, 70826);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 70718, 70799);

                                            f_1664_70718_70798(types, ranks, current, exceptionToPass, errorRecordToPass);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 70633, 70826);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 70478, 70826);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 70175, 71205);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 70175, 71205);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 70876, 71205) || true) && (rte is CmdletInvocationException && (DynAbs.Tracing.TraceSender.Expression_True(1664, 70880, 70929) && inner != null))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 70876, 71205);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 70979, 71182) || true) && (f_1664_70983_71003(inner) != null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 70979, 71182);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 71069, 71155);

                                            f_1664_71069_71154(types, ranks, current, f_1664_71114_71134(inner), errorRecordToPass);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 70979, 71182);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 70876, 71205);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 70175, 71205);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 70043, 71224);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 68488, 71265);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 68488, 71265) || true) && (continueToSearch)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 68488, 71265);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 68488, 71265);
                    }
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 71281, 71536) || true) && (current.Handler != -1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 71281, 71536);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 71340, 71426);

                    var
                    errorRecord = f_1664_71358_71425(current.ErrorRecordToPass, current.ExceptionToPass)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 71444, 71521);

                    f_1664_71444_71520(tuple, AutomaticVariable.Underbar, errorRecord, context);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 71281, 71536);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 71552, 71575);

                return current.Handler;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 68188, 71586);

                int[]
                f_1664_68392_68417(System.Type[]
                types)
                {
                    var return_v = RankExceptionTypes(types);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 68392, 68417);
                    return return_v;
                }


                System.Management.Automation.ExceptionHandlingOps.HandlerSearchResult
                f_1664_68446_68471()
                {
                    var return_v = new System.Management.Automation.ExceptionHandlingOps.HandlerSearchResult();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 68446, 68471);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1664_68776_68791(System.Management.Automation.RuntimeException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 68776, 68791);
                    return return_v;
                }


                System.Exception
                f_1664_68830_68848(System.Management.Automation.RuntimeException
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 68830, 68848);
                    return return_v;
                }


                int
                f_1664_68926_68996(System.Type[]
                types, int[]
                ranks, System.Management.Automation.ExceptionHandlingOps.HandlerSearchResult
                current, System.Exception
                exception, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    FindAndProcessHandler(types, ranks, current, exception, errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 68926, 68996);
                    return 0;
                }


                int
                f_1664_69492_69560(System.Type[]
                types, int[]
                ranks, System.Management.Automation.ExceptionHandlingOps.HandlerSearchResult
                current, System.Management.Automation.RuntimeException
                exception, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    FindAndProcessHandler(types, ranks, current, (System.Exception)exception, errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 69492, 69560);
                    return 0;
                }


                System.Management.Automation.ErrorRecord
                f_1664_70263_70279(System.Management.Automation.ActionPreferenceStopException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 70263, 70279);
                    return return_v;
                }


                System.Exception
                f_1664_70263_70289(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 70263, 70289);
                    return return_v;
                }


                int
                f_1664_70718_70798(System.Type[]
                types, int[]
                ranks, System.Management.Automation.ExceptionHandlingOps.HandlerSearchResult
                current, System.Exception
                exception, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    FindAndProcessHandler(types, ranks, current, exception, errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 70718, 70798);
                    return 0;
                }


                System.Exception
                f_1664_70983_71003(System.Exception
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 70983, 71003);
                    return return_v;
                }


                System.Exception
                f_1664_71114_71134(System.Exception
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 71114, 71134);
                    return return_v;
                }


                int
                f_1664_71069_71154(System.Type[]
                types, int[]
                ranks, System.Management.Automation.ExceptionHandlingOps.HandlerSearchResult
                current, System.Exception
                exception, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    FindAndProcessHandler(types, ranks, current, exception, errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 71069, 71154);
                    return 0;
                }


                System.Management.Automation.ErrorRecord
                f_1664_71358_71425(System.Management.Automation.ErrorRecord
                errorRecord, System.Exception
                replaceParentContainsErrorRecordException)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(errorRecord, replaceParentContainsErrorRecordException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 71358, 71425);
                    return return_v;
                }


                int
                f_1664_71444_71520(System.Management.Automation.MutableTuple
                this_param, System.Management.Automation.AutomaticVariable
                auto, System.Management.Automation.ErrorRecord
                value, System.Management.Automation.ExecutionContext
                context)
                {
                    this_param.SetAutomaticVariable(auto, (object)value, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 71444, 71520);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 68188, 71586);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 68188, 71586);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int FindMatchingHandlerByType(Type exceptionType, Type[] types)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 71707, 72776);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 71810, 71816);

                int
                i
                = default(int);
                try
                {
                    // pass 1 - exact match (this pass isn't needed for catch handlers because the ordering
                    // guarantees more specific handlers come first.)
                    for (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 72001, 72006)
        , i = 0; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 71996, 72144) || true) && (i < f_1664_72012_72024(types))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 72026, 72029)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 71996, 72144))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 71996, 72144);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 72063, 72129) || true) && (f_1664_72067_72097(exceptionType, types[i]))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 72063, 72129);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 72120, 72129);

                            return i;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 72063, 72129);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 1, 149);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 1, 149);
                }
                try
                {
                    // pass 2 - subclass
                    for (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 72199, 72204)
        , i = 0; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 72194, 72348) || true) && (i < f_1664_72210_72222(types))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 72224, 72227)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 72194, 72348))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 72194, 72348);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 72261, 72333) || true) && (f_1664_72265_72301(exceptionType, types[i]))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 72261, 72333);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 72324, 72333);

                            return i;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 72261, 72333);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 1, 155);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 1, 155);
                }
                try
                {
                    // pass 3 - untyped catchall handler...
                    //   if there is more than one (can only happen with traps), return the first.
                    //   it might be nice to enforce a single default in strict mode.
                    for (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 72593, 72598)
        , i = 0; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 72588, 72739) || true) && (i < f_1664_72604_72616(types))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 72618, 72621)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 72588, 72739))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 72588, 72739);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 72655, 72724) || true) && (f_1664_72659_72692(types[i], typeof(CatchAll)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 72655, 72724);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 72715, 72724);

                            return i;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 72655, 72724);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 1, 152);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 1, 152);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 72755, 72765);

                return -1;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 71707, 72776);

                int
                f_1664_72012_72024(System.Type[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 72012, 72024);
                    return return_v;
                }


                bool
                f_1664_72067_72097(System.Type
                this_param, System.Type
                o)
                {
                    var return_v = this_param.Equals(o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 72067, 72097);
                    return return_v;
                }


                int
                f_1664_72210_72222(System.Type[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 72210, 72222);
                    return return_v;
                }


                bool
                f_1664_72265_72301(System.Type
                this_param, System.Type
                c)
                {
                    var return_v = this_param.IsSubclassOf(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 72265, 72301);
                    return return_v;
                }


                int
                f_1664_72604_72616(System.Type[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 72604, 72616);
                    return return_v;
                }


                bool
                f_1664_72659_72692(System.Type
                this_param, System.Type
                o)
                {
                    var return_v = this_param.Equals(o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 72659, 72692);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 71707, 72776);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 71707, 72776);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool SuspendStoppingPipeline(ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 72788, 73121);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 72883, 72972);

                LocalPipeline
                lpl = (LocalPipeline)f_1664_72918_72971(f_1664_72918_72941(context))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 72986, 73030);

                bool
                oldIsStopping = f_1664_73007_73029(f_1664_73007_73018(lpl))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 73044, 73075);

                f_1664_73044_73055(lpl).IsStopping = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 73089, 73110);

                return oldIsStopping;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 72788, 73121);

                System.Management.Automation.Runspaces.Runspace
                f_1664_72918_72941(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 72918, 72941);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Pipeline
                f_1664_72918_72971(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.GetCurrentlyRunningPipeline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 72918, 72971);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineStopper
                f_1664_73007_73018(System.Management.Automation.Runspaces.LocalPipeline
                this_param)
                {
                    var return_v = this_param.Stopper;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 73007, 73018);
                    return return_v;
                }


                bool
                f_1664_73007_73029(System.Management.Automation.Runspaces.PipelineStopper
                this_param)
                {
                    var return_v = this_param.IsStopping;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 73007, 73029);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineStopper
                f_1664_73044_73055(System.Management.Automation.Runspaces.LocalPipeline
                this_param)
                {
                    var return_v = this_param.Stopper;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 73044, 73055);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 72788, 73121);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 72788, 73121);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void RestoreStoppingPipeline(ExecutionContext context, bool oldIsStopping)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 73133, 73401);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 73248, 73337);

                LocalPipeline
                lpl = (LocalPipeline)f_1664_73283_73336(f_1664_73283_73306(context))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 73351, 73390);

                f_1664_73351_73362(lpl).IsStopping = oldIsStopping;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 73133, 73401);

                System.Management.Automation.Runspaces.Runspace
                f_1664_73283_73306(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 73283, 73306);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Pipeline
                f_1664_73283_73336(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.GetCurrentlyRunningPipeline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 73283, 73336);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineStopper
                f_1664_73351_73362(System.Management.Automation.Runspaces.LocalPipeline
                this_param)
                {
                    var return_v = this_param.Stopper;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 73351, 73362);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 73133, 73401);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 73133, 73401);
            }
        }

        internal static void CheckActionPreference(FunctionContext funcContext, Exception exception)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 73413, 76919);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 73530, 73719) || true) && (exception is TargetInvocationException)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 73530, 73719);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 73667, 73704);

                    exception = f_1664_73679_73703(exception);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 73530, 73719);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 73735, 73775);

                var
                rte = exception as RuntimeException
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 73789, 74077) || true) && (rte == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 73789, 74077);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 73838, 73910);

                    rte = f_1664_73844_73909(exception, f_1664_73881_73908(funcContext));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 73789, 74077);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 73789, 74077);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 73976, 74062);

                    f_1664_73976_74061(rte, f_1664_74033_74060(funcContext));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 73789, 74077);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 74093, 74137);

                var
                context = funcContext._executionContext
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 74151, 74192);

                var
                outputPipe = funcContext._outputPipe
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 74208, 74267);

                var
                extent = f_1664_74221_74266(f_1664_74221_74251(f_1664_74221_74236(rte)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 74281, 74333);

                f_1664_74281_74332(extent, rte, context, outputPipe);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 74401, 74443);

                context.QuestionMarkVariableValue = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 74459, 74523);

                ActionPreference
                preference = f_1664_74489_74522(context)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 74733, 74953) || true) && (f_1664_74737_74753_M(!rte.WasRethrown) && (DynAbs.Tracing.TraceSender.Expression_True(1664, 74737, 74818) && f_1664_74774_74810(context) == null) && (DynAbs.Tracing.TraceSender.Expression_True(1664, 74737, 74875) && preference == ActionPreference.Break))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 74733, 74953);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 74909, 74938);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_1664_74909_74925(context), 1664, 74909, 74937).Break(rte), 1664, 74926, 74937);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 74733, 74953);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 75265, 75383);

                bool
                anyTrapHandlers = f_1664_75288_75312(funcContext._traps) > 0 && (DynAbs.Tracing.TraceSender.Expression_True(1664, 75288, 75382) && f_1664_75320_75374(f_1664_75320_75368(funcContext._traps, f_1664_75339_75363(funcContext._traps) - 1)) != null)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 75399, 75994) || true) && (anyTrapHandlers)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 75399, 75994);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 75589, 75633);

                    preference = f_1664_75602_75632(funcContext, rte);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 75399, 75994);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 75399, 75994);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 75667, 75994) || true) && (f_1664_75671_75727(rte, context))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 75667, 75994);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 75761, 75771);

                        throw rte;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 75667, 75994);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 75667, 75994);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 75805, 75994) || true) && (preference == ActionPreference.Inquire && (DynAbs.Tracing.TraceSender.Expression_True(1664, 75809, 75883) && f_1664_75851_75883_M(!rte.SuppressPromptInInterpreter)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 75805, 75994);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 75917, 75979);

                            preference = f_1664_75930_75978(f_1664_75957_75968(rte), context);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 75805, 75994);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 75667, 75994);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 75399, 75994);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 76010, 76179) || true) && ((preference == ActionPreference.SilentlyContinue) || (DynAbs.Tracing.TraceSender.Expression_False(1664, 76014, 76123) || (preference == ActionPreference.Ignore)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 76010, 76179);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 76157, 76164);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 76010, 76179);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 76195, 76659) || true) && (preference == ActionPreference.Stop)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 76195, 76659);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 76575, 76614);

                    rte.SuppressPromptInInterpreter = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 76634, 76644);

                    throw rte;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 76195, 76659);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 76675, 76789) || true) && (!anyTrapHandlers && (DynAbs.Tracing.TraceSender.Expression_True(1664, 76679, 76730) && f_1664_76699_76730(rte)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 76675, 76789);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 76764, 76774);

                    throw rte;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 76675, 76789);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 76805, 76908) || true) && (!f_1664_76810_76849(extent, rte, context))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 76805, 76908);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 76883, 76893);

                    throw rte;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 76805, 76908);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 73413, 76919);

                System.Exception
                f_1664_73679_73703(System.Exception
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 73679, 73703);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1664_73881_73908(System.Management.Automation.Language.FunctionContext
                this_param)
                {
                    var return_v = this_param.CurrentPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 73881, 73908);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1664_73844_73909(System.Exception
                exception, System.Management.Automation.Language.IScriptExtent
                extent)
                {
                    var return_v = ConvertToRuntimeException(exception, extent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 73844, 73909);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1664_74033_74060(System.Management.Automation.Language.FunctionContext
                this_param)
                {
                    var return_v = this_param.CurrentPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 74033, 74060);
                    return return_v;
                }


                int
                f_1664_73976_74061(System.Management.Automation.RuntimeException
                exception, System.Management.Automation.Language.IScriptExtent
                extent)
                {
                    InterpreterError.UpdateExceptionErrorRecordPosition((System.Exception)exception, extent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 73976, 74061);
                    return 0;
                }


                System.Management.Automation.ErrorRecord
                f_1664_74221_74236(System.Management.Automation.RuntimeException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 74221, 74236);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1664_74221_74251(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 74221, 74251);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1664_74221_74266(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.ScriptPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 74221, 74266);
                    return return_v;
                }


                int
                f_1664_74281_74332(System.Management.Automation.Language.IScriptExtent
                extent, System.Management.Automation.RuntimeException
                rte, System.Management.Automation.ExecutionContext
                context, System.Management.Automation.Internal.Pipe
                outputPipe)
                {
                    SetErrorVariables(extent, rte, context, outputPipe);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 74281, 74332);
                    return 0;
                }


                System.Management.Automation.ActionPreference
                f_1664_74489_74522(System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = GetErrorActionPreference(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 74489, 74522);
                    return return_v;
                }


                bool
                f_1664_74737_74753_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 74737, 74753);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1664_74774_74810(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentExceptionBeingHandled;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 74774, 74810);
                    return return_v;
                }


                System.Management.Automation.ScriptDebugger
                f_1664_74909_74925(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Debugger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 74909, 74925);
                    return return_v;
                }


                int
                f_1664_75288_75312(System.Collections.Generic.List<System.Tuple<System.Type[], System.Action<System.Management.Automation.Language.FunctionContext>[], System.Type[]>>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 75288, 75312);
                    return return_v;
                }


                int
                f_1664_75339_75363(System.Collections.Generic.List<System.Tuple<System.Type[], System.Action<System.Management.Automation.Language.FunctionContext>[], System.Type[]>>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 75339, 75363);
                    return return_v;
                }


                System.Tuple<System.Type[], System.Action<System.Management.Automation.Language.FunctionContext>[], System.Type[]>
                f_1664_75320_75368(System.Collections.Generic.List<System.Tuple<System.Type[], System.Action<System.Management.Automation.Language.FunctionContext>[], System.Type[]>>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 75320, 75368);
                    return return_v;
                }


                System.Action<System.Management.Automation.Language.FunctionContext>[]
                f_1664_75320_75374(System.Tuple<System.Type[], System.Action<System.Management.Automation.Language.FunctionContext>[], System.Type[]>
                this_param)
                {
                    var return_v = this_param.Item2;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 75320, 75374);
                    return return_v;
                }


                System.Management.Automation.ActionPreference
                f_1664_75602_75632(System.Management.Automation.Language.FunctionContext
                funcContext, System.Management.Automation.RuntimeException
                rte)
                {
                    var return_v = ProcessTraps(funcContext, rte);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 75602, 75632);
                    return return_v;
                }


                bool
                f_1664_75671_75727(System.Management.Automation.RuntimeException
                rte, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = ExceptionCannotBeStoppedContinuedOrIgnored(rte, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 75671, 75727);
                    return return_v;
                }


                bool
                f_1664_75851_75883_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 75851, 75883);
                    return return_v;
                }


                string
                f_1664_75957_75968(System.Management.Automation.RuntimeException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 75957, 75968);
                    return return_v;
                }


                System.Management.Automation.ActionPreference
                f_1664_75930_75978(string
                message, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = InquireForActionPreference(message, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 75930, 75978);
                    return return_v;
                }


                bool
                f_1664_76699_76730(System.Management.Automation.RuntimeException
                this_param)
                {
                    var return_v = this_param.WasThrownFromThrowStatement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 76699, 76730);
                    return return_v;
                }


                bool
                f_1664_76810_76849(System.Management.Automation.Language.IScriptExtent
                extent, System.Management.Automation.RuntimeException
                rte, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = ReportErrorRecord(extent, rte, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 76810, 76849);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 73413, 76919);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 73413, 76919);
            }
        }

        private static ActionPreference ProcessTraps(FunctionContext funcContext,
                                                             RuntimeException rte)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 76931, 82306);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 77105, 77122);

                int
                handler = -1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 77136, 77163);

                Exception
                exception = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 77177, 77214);

                Exception
                inner = f_1664_77195_77213(rte)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 77230, 77274);

                var
                types = f_1664_77242_77273(f_1664_77242_77267(funcContext._traps))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 77288, 77335);

                var
                handlers = f_1664_77303_77334(f_1664_77303_77328(funcContext._traps))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 77351, 77513) || true) && (inner != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 77351, 77513);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 77402, 77462);

                    handler = f_1664_77412_77461(f_1664_77438_77453(inner), types);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 77480, 77498);

                    exception = inner;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 77351, 77513);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 77825, 78168) || true) && (handler == -1 || (DynAbs.Tracing.TraceSender.Expression_False(1664, 77829, 77885) || f_1664_77846_77885(types[handler], typeof(CatchAll))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 77825, 78168);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 77919, 77986);

                    int
                    outerHandler = f_1664_77938_77985(f_1664_77964_77977(rte), types)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 78004, 78153) || true) && (outerHandler != handler)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 78004, 78153);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 78073, 78096);

                        handler = outerHandler;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 78118, 78134);

                        exception = rte;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 78004, 78153);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 77825, 78168);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 78184, 82250) || true) && (handler != -1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 78184, 82250);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 78235, 78308);

                    f_1664_78235_78307(exception != null, "Exception object can't be null.");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 78328, 78372);

                    var
                    context = funcContext._executionContext
                    ;

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 78436, 78470);

                        ErrorRecord
                        err = f_1664_78454_78469(rte)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 78652, 78824) || true) && (f_1664_78656_78687(context) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 78652, 78824);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 78745, 78801);

                            f_1664_78745_78800(f_1664_78745_78776(context));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 78652, 78824);
                        }

                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 78988, 79101);

                            var
                            locals = f_1664_79001_79100(f_1664_79024_79055(f_1664_79024_79049(funcContext._traps))[handler], Compiler.DottedLocalsNameIndexMap)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 79409, 79512);

                            f_1664_79409_79511(AutomaticVariable.Underbar == 0, "Code below relies on this assertion being true.");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 79538, 79636);

                            f_1664_79538_79635(locals, AutomaticVariable.Underbar, f_1664_79594_79625(err, exception), context);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 79671, 79676);
                                for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 79662, 79878) || true) && (i < (int)AutomaticVariable.NumberOfAutomaticVariables)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 79733, 79736)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 79662, 79878))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 79662, 79878);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 79794, 79851);

                                    f_1664_79794_79850(locals, i, f_1664_79813_79849(funcContext._localsTuple, i));
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 1, 217);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 1, 217);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 79906, 79964);

                            var
                            newScope = f_1664_79921_79963(f_1664_79921_79947(context), false)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 79990, 80041);

                            f_1664_79990_80016(context).CurrentScope = newScope;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 80067, 80097);

                            newScope.LocalsTuple = locals;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 80125, 80935);

                            var
                            trapFuncContext = new FunctionContext
                            {
                                _file = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => funcContext._file, 1664, 80147, 80934),
                                _scriptBlock = funcContext._scriptBlock,
                                _sequencePoints = funcContext._sequencePoints,
                                _debuggerHidden = funcContext._debuggerHidden,
                                _debuggerStepThrough = funcContext._debuggerStepThrough,
                                _executionContext = funcContext._executionContext,
                                _boundBreakpoints = funcContext._boundBreakpoints,
                                _outputPipe = funcContext._outputPipe,
                                _breakPoints = funcContext._breakPoints,
                                _localsTuple = locals
                            }
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 80963, 80998);

                            // LAFHIS
                            //f_1664_80963_80997(handlers[handler](trapFuncContext), trapFuncContext);
                            handlers[handler].Invoke(trapFuncContext);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 80963, 80997);
                        }
                        catch (TargetInvocationException tie)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1664, 81043, 81177);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 81129, 81154);

                            throw f_1664_81135_81153(tie);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1664, 81043, 81177);
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinally(1664, 81199, 81358);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 81255, 81335);

                            f_1664_81255_81334(f_1664_81255_81281(context), f_1664_81294_81333(f_1664_81294_81320(context)));
                            DynAbs.Tracing.TraceSender.TraceExitFinally(1664, 81199, 81358);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 81382, 81458);

                        return f_1664_81389_81457(rte, f_1664_81430_81447(exception), context);
                    }
                    catch (ContinueException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1664, 81495, 81685);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 81625, 81666);

                        return ActionPreference.SilentlyContinue;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1664, 81495, 81685);
                    }
                    catch (BreakException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1664, 81703, 81874);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 81826, 81855);

                        return ActionPreference.Stop;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1664, 81703, 81874);
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1664, 81892, 82235);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 82174, 82216);

                        context.QuestionMarkVariableValue = false;
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1664, 81892, 82235);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 78184, 82250);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 82266, 82295);

                return ActionPreference.Stop;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 76931, 82306);

                System.Exception
                f_1664_77195_77213(System.Management.Automation.RuntimeException
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 77195, 77213);
                    return return_v;
                }


                System.Tuple<System.Type[], System.Action<System.Management.Automation.Language.FunctionContext>[], System.Type[]>
                f_1664_77242_77267(System.Collections.Generic.List<System.Tuple<System.Type[], System.Action<System.Management.Automation.Language.FunctionContext>[], System.Type[]>>
                source)
                {
                    var return_v = source.Last<System.Tuple<System.Type[], System.Action<System.Management.Automation.Language.FunctionContext>[], System.Type[]>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 77242, 77267);
                    return return_v;
                }


                System.Type[]
                f_1664_77242_77273(System.Tuple<System.Type[], System.Action<System.Management.Automation.Language.FunctionContext>[], System.Type[]>
                this_param)
                {
                    var return_v = this_param.Item1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 77242, 77273);
                    return return_v;
                }


                System.Tuple<System.Type[], System.Action<System.Management.Automation.Language.FunctionContext>[], System.Type[]>
                f_1664_77303_77328(System.Collections.Generic.List<System.Tuple<System.Type[], System.Action<System.Management.Automation.Language.FunctionContext>[], System.Type[]>>
                source)
                {
                    var return_v = source.Last<System.Tuple<System.Type[], System.Action<System.Management.Automation.Language.FunctionContext>[], System.Type[]>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 77303, 77328);
                    return return_v;
                }


                System.Action<System.Management.Automation.Language.FunctionContext>[]
                f_1664_77303_77334(System.Tuple<System.Type[], System.Action<System.Management.Automation.Language.FunctionContext>[], System.Type[]>
                this_param)
                {
                    var return_v = this_param.Item2;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 77303, 77334);
                    return return_v;
                }


                System.Type
                f_1664_77438_77453(System.Exception
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 77438, 77453);
                    return return_v;
                }


                int
                f_1664_77412_77461(System.Type
                exceptionType, System.Type[]
                types)
                {
                    var return_v = FindMatchingHandlerByType(exceptionType, types);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 77412, 77461);
                    return return_v;
                }


                bool
                f_1664_77846_77885(System.Type
                this_param, System.Type
                o)
                {
                    var return_v = this_param.Equals(o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 77846, 77885);
                    return return_v;
                }


                System.Type
                f_1664_77964_77977(System.Management.Automation.RuntimeException
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 77964, 77977);
                    return return_v;
                }


                int
                f_1664_77938_77985(System.Type
                exceptionType, System.Type[]
                types)
                {
                    var return_v = FindMatchingHandlerByType(exceptionType, types);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 77938, 77985);
                    return return_v;
                }


                int
                f_1664_78235_78307(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 78235, 78307);
                    return 0;
                }


                System.Management.Automation.ErrorRecord
                f_1664_78454_78469(System.Management.Automation.RuntimeException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 78454, 78469);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1664_78656_78687(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentCommandProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 78656, 78687);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1664_78745_78776(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentCommandProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 78745, 78776);
                    return return_v;
                }


                int
                f_1664_78745_78800(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    this_param.ForgetScriptException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 78745, 78800);
                    return 0;
                }


                System.Tuple<System.Type[], System.Action<System.Management.Automation.Language.FunctionContext>[], System.Type[]>
                f_1664_79024_79049(System.Collections.Generic.List<System.Tuple<System.Type[], System.Action<System.Management.Automation.Language.FunctionContext>[], System.Type[]>>
                source)
                {
                    var return_v = source.Last<System.Tuple<System.Type[], System.Action<System.Management.Automation.Language.FunctionContext>[], System.Type[]>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 79024, 79049);
                    return return_v;
                }


                System.Type[]
                f_1664_79024_79055(System.Tuple<System.Type[], System.Action<System.Management.Automation.Language.FunctionContext>[], System.Type[]>
                this_param)
                {
                    var return_v = this_param.Item3;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 79024, 79055);
                    return return_v;
                }


                System.Management.Automation.MutableTuple
                f_1664_79001_79100(System.Type
                tupleType, System.Collections.Generic.Dictionary<string, int>
                nameToIndexMap)
                {
                    var return_v = MutableTuple.MakeTuple(tupleType, nameToIndexMap);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 79001, 79100);
                    return return_v;
                }


                int
                f_1664_79409_79511(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 79409, 79511);
                    return 0;
                }


                System.Management.Automation.ErrorRecord
                f_1664_79594_79625(System.Management.Automation.ErrorRecord
                errorRecord, System.Exception
                replaceParentContainsErrorRecordException)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(errorRecord, replaceParentContainsErrorRecordException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 79594, 79625);
                    return return_v;
                }


                int
                f_1664_79538_79635(System.Management.Automation.MutableTuple
                this_param, System.Management.Automation.AutomaticVariable
                auto, System.Management.Automation.ErrorRecord
                value, System.Management.Automation.ExecutionContext
                context)
                {
                    this_param.SetAutomaticVariable(auto, (object)value, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 79538, 79635);
                    return 0;
                }


                object
                f_1664_79813_79849(System.Management.Automation.MutableTuple
                this_param, int
                index)
                {
                    var return_v = this_param.GetValue(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 79813, 79849);
                    return return_v;
                }


                int
                f_1664_79794_79850(System.Management.Automation.MutableTuple
                this_param, int
                index, object
                value)
                {
                    this_param.SetValue(index, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 79794, 79850);
                    return 0;
                }


                System.Management.Automation.SessionStateInternal
                f_1664_79921_79947(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 79921, 79947);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1664_79921_79963(System.Management.Automation.SessionStateInternal
                this_param, bool
                isScriptScope)
                {
                    var return_v = this_param.NewScope(isScriptScope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 79921, 79963);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1664_79990_80016(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 79990, 80016);
                    return return_v;
                }


                int
                f_1664_80963_80997(System.Action<System.Management.Automation.Language.FunctionContext>
                this_param, System.Management.Automation.Language.FunctionContext
                obj)
                {
                    this_param.Invoke(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 80963, 80997);
                    return 0;
                }


                System.Exception
                f_1664_81135_81153(System.Reflection.TargetInvocationException
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 81135, 81153);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1664_81255_81281(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 81255, 81281);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1664_81294_81320(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 81294, 81320);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1664_81294_81333(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 81294, 81333);
                    return return_v;
                }


                int
                f_1664_81255_81334(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.SessionStateScope
                scope)
                {
                    this_param.RemoveScope(scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 81255, 81334);
                    return 0;
                }


                string
                f_1664_81430_81447(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 81430, 81447);
                    return return_v;
                }


                System.Management.Automation.ActionPreference
                f_1664_81389_81457(System.Management.Automation.RuntimeException
                rte, string
                message, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = ExceptionHandlingOps.QueryForAction(rte, message, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 81389, 81457);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 76931, 82306);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 76931, 82306);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ActionPreference GetErrorActionPreference(ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 82751, 83036);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 82859, 83025);

                return f_1664_82866_83024(context, SpecialVariables.ErrorActionPreferenceVarPath, ActionPreference.Continue, out _);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 82751, 83036);

                System.Management.Automation.ActionPreference
                f_1664_82866_83024(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.VariablePath
                preferenceVariablePath, System.Management.Automation.ActionPreference
                defaultPref, out bool
                defaultUsed)
                {
                    var return_v = this_param.GetEnumPreference<System.Management.Automation.ActionPreference>(preferenceVariablePath, defaultPref, out defaultUsed);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 82866, 83024);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 82751, 83036);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 82751, 83036);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ActionPreference QueryForAction(RuntimeException rte, string message, ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 83648, 84339);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 83912, 84130);

                ActionPreference
                preference =
                f_1664_83959_84129(context, SpecialVariables.ErrorActionPreferenceVarPath, ActionPreference.Continue, out _)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 84146, 84260) || true) && (preference != ActionPreference.Inquire || (DynAbs.Tracing.TraceSender.Expression_False(1664, 84150, 84223) || f_1664_84192_84223(rte)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 84146, 84260);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 84242, 84260);

                    return preference;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 84146, 84260);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 84276, 84328);

                return f_1664_84283_84327(message, context);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 83648, 84339);

                System.Management.Automation.ActionPreference
                f_1664_83959_84129(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.VariablePath
                preferenceVariablePath, System.Management.Automation.ActionPreference
                defaultPref, out bool
                defaultUsed)
                {
                    var return_v = this_param.GetEnumPreference<System.Management.Automation.ActionPreference>(preferenceVariablePath, defaultPref, out defaultUsed);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 83959, 84129);
                    return return_v;
                }


                bool
                f_1664_84192_84223(System.Management.Automation.RuntimeException
                this_param)
                {
                    var return_v = this_param.SuppressPromptInInterpreter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 84192, 84223);
                    return return_v;
                }


                System.Management.Automation.ActionPreference
                f_1664_84283_84327(string
                message, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = InquireForActionPreference(message, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 84283, 84327);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 83648, 84339);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 83648, 84339);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ActionPreference InquireForActionPreference(string message, ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 84726, 86638);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 84852, 84941);

                InternalHostUserInterface
                ui = (InternalHostUserInterface)f_1664_84910_84940(f_1664_84910_84937(context))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 84957, 85033);

                Collection<ChoiceDescription>
                choices = f_1664_84997_85032()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 85049, 85100);

                string
                continueLabel = f_1664_85072_85099()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 85114, 85173);

                string
                continueHelpMsg = f_1664_85139_85172()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 85187, 85254);

                string
                silentlyContinueLabel = f_1664_85218_85253()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 85268, 85343);

                string
                silentlyContinueHelpMsg = f_1664_85301_85342()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 85357, 85402);

                string
                breakLabel = f_1664_85377_85401()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 85416, 85469);

                string
                breakHelpMsg = f_1664_85438_85468()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 85483, 85532);

                string
                suspendLabel = f_1664_85505_85531()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 85546, 85622);

                string
                suspendHelpMsg = f_1664_85570_85621(f_1664_85588_85620())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 85638, 85705);

                f_1664_85638_85704(
                            choices, f_1664_85650_85703(continueLabel, continueHelpMsg));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 85719, 85802);

                f_1664_85719_85801(choices, f_1664_85731_85800(silentlyContinueLabel, silentlyContinueHelpMsg));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 85816, 85877);

                f_1664_85816_85876(choices, f_1664_85828_85875(breakLabel, breakHelpMsg));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 85891, 85956);

                f_1664_85891_85955(choices, f_1664_85903_85954(suspendLabel, suspendHelpMsg));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 85972, 86032);

                string
                caption = f_1664_85989_86031()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 86048, 86118);

                bool
                oldQuestionMarkVariableValue = f_1664_86084_86117(context)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 86134, 86145);

                int
                choice
                = default(int);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 86159, 86327) || true) && ((choice = f_1664_86176_86224(ui, caption, message, choices, 0)) == 3)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 86159, 86327);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 86264, 86312);

                        f_1664_86264_86311(f_1664_86264_86291(context));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 86159, 86327);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 86159, 86327);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 86159, 86327);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 86343, 86408);

                context.QuestionMarkVariableValue = oldQuestionMarkVariableValue;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 86424, 86491) || true) && (choice == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 86424, 86491);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 86458, 86491);

                    return ActionPreference.Continue;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 86424, 86491);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 86507, 86582) || true) && (choice == 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 86507, 86582);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 86541, 86582);

                    return ActionPreference.SilentlyContinue;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 86507, 86582);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 86598, 86627);

                return ActionPreference.Stop;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 84726, 86638);

                System.Management.Automation.Internal.Host.InternalHost
                f_1664_84910_84937(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineHostInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 84910, 84937);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostUserInterface
                f_1664_84910_84940(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 84910, 84940);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
                f_1664_84997_85032()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 84997, 85032);
                    return return_v;
                }


                string
                f_1664_85072_85099()
                {
                    var return_v = ParserStrings.ContinueLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 85072, 85099);
                    return return_v;
                }


                string
                f_1664_85139_85172()
                {
                    var return_v = ParserStrings.ContinueHelpMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 85139, 85172);
                    return return_v;
                }


                string
                f_1664_85218_85253()
                {
                    var return_v = ParserStrings.SilentlyContinueLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 85218, 85253);
                    return return_v;
                }


                string
                f_1664_85301_85342()
                {
                    var return_v = ParserStrings.SilentlyContinueHelpMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 85301, 85342);
                    return return_v;
                }


                string
                f_1664_85377_85401()
                {
                    var return_v = ParserStrings.BreakLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 85377, 85401);
                    return return_v;
                }


                string
                f_1664_85438_85468()
                {
                    var return_v = ParserStrings.BreakHelpMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 85438, 85468);
                    return return_v;
                }


                string
                f_1664_85505_85531()
                {
                    var return_v = ParserStrings.SuspendLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 85505, 85531);
                    return return_v;
                }


                string
                f_1664_85588_85620()
                {
                    var return_v = ParserStrings.SuspendHelpMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 85588, 85620);
                    return return_v;
                }


                string
                f_1664_85570_85621(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 85570, 85621);
                    return return_v;
                }


                System.Management.Automation.Host.ChoiceDescription
                f_1664_85650_85703(string
                label, string
                helpMessage)
                {
                    var return_v = new System.Management.Automation.Host.ChoiceDescription(label, helpMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 85650, 85703);
                    return return_v;
                }


                int
                f_1664_85638_85704(System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
                this_param, System.Management.Automation.Host.ChoiceDescription
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 85638, 85704);
                    return 0;
                }


                System.Management.Automation.Host.ChoiceDescription
                f_1664_85731_85800(string
                label, string
                helpMessage)
                {
                    var return_v = new System.Management.Automation.Host.ChoiceDescription(label, helpMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 85731, 85800);
                    return return_v;
                }


                int
                f_1664_85719_85801(System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
                this_param, System.Management.Automation.Host.ChoiceDescription
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 85719, 85801);
                    return 0;
                }


                System.Management.Automation.Host.ChoiceDescription
                f_1664_85828_85875(string
                label, string
                helpMessage)
                {
                    var return_v = new System.Management.Automation.Host.ChoiceDescription(label, helpMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 85828, 85875);
                    return return_v;
                }


                int
                f_1664_85816_85876(System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
                this_param, System.Management.Automation.Host.ChoiceDescription
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 85816, 85876);
                    return 0;
                }


                System.Management.Automation.Host.ChoiceDescription
                f_1664_85903_85954(string
                label, string
                helpMessage)
                {
                    var return_v = new System.Management.Automation.Host.ChoiceDescription(label, helpMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 85903, 85954);
                    return return_v;
                }


                int
                f_1664_85891_85955(System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
                this_param, System.Management.Automation.Host.ChoiceDescription
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 85891, 85955);
                    return 0;
                }


                string
                f_1664_85989_86031()
                {
                    var return_v = ParserStrings.ExceptionActionPromptCaption;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 85989, 86031);
                    return return_v;
                }


                bool
                f_1664_86084_86117(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.QuestionMarkVariableValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 86084, 86117);
                    return return_v;
                }


                int
                f_1664_86176_86224(System.Management.Automation.Internal.Host.InternalHostUserInterface
                this_param, string
                caption, string
                message, System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
                choices, int
                defaultChoice)
                {
                    var return_v = this_param.PromptForChoice(caption, message, choices, defaultChoice);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 86176, 86224);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1664_86264_86291(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineHostInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 86264, 86291);
                    return return_v;
                }


                int
                f_1664_86264_86311(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    this_param.EnterNestedPrompt();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 86264, 86311);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 84726, 86638);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 84726, 86638);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void SetErrorVariables(IScriptExtent extent, RuntimeException rte, ExecutionContext context, Pipe outputPipe)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 86988, 88121);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 87138, 87158);

                string
                stack = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 87172, 87190);

                Exception
                e = rte
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 87206, 87216);

                int
                i = 0
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 87230, 87469) || true) && (e != null && (DynAbs.Tracing.TraceSender.Expression_True(1664, 87237, 87258) && i++ < 10))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 87230, 87469);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 87292, 87413) || true) && (!f_1664_87297_87331(f_1664_87318_87330(e)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 87292, 87413);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 87373, 87394);

                            stack = f_1664_87381_87393(e);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 87292, 87413);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 87433, 87454);

                        e = f_1664_87437_87453(e);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 87230, 87469);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 87230, 87469);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 87230, 87469);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 87485, 87548);

                f_1664_87485_87547(
                            context, SpecialVariables.StackTraceVarPath, stack);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 87564, 87657);

                f_1664_87564_87656(f_1664_87583_87598(rte) != null, "The runtime exception's error record was null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 87671, 87736);

                f_1664_87671_87735(rte, extent);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 87750, 87806);

                ErrorRecord
                errRec = f_1664_87771_87805(f_1664_87771_87786(rte), rte)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 87822, 88110) || true) && (!(rte is PipelineStoppedException))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 87822, 88110);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 87894, 88041) || true) && (outputPipe != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 87894, 88041);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 87958, 88022);

                        f_1664_87958_88021(outputPipe, VariableStreamKind.Error, errRec);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 87894, 88041);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 88061, 88095);

                    f_1664_88061_88094(
                                    context, errRec);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 87822, 88110);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 86988, 88121);

                string
                f_1664_87318_87330(System.Exception
                this_param)
                {
                    var return_v = this_param.StackTrace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 87318, 87330);
                    return return_v;
                }


                bool
                f_1664_87297_87331(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 87297, 87331);
                    return return_v;
                }


                string
                f_1664_87381_87393(System.Exception
                this_param)
                {
                    var return_v = this_param.StackTrace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 87381, 87393);
                    return return_v;
                }


                System.Exception
                f_1664_87437_87453(System.Exception
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 87437, 87453);
                    return return_v;
                }


                int
                f_1664_87485_87547(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.VariablePath
                path, string
                newValue)
                {
                    this_param.SetVariable(path, (object)newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 87485, 87547);
                    return 0;
                }


                System.Management.Automation.ErrorRecord
                f_1664_87583_87598(System.Management.Automation.RuntimeException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 87583, 87598);
                    return return_v;
                }


                int
                f_1664_87564_87656(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 87564, 87656);
                    return 0;
                }


                int
                f_1664_87671_87735(System.Management.Automation.RuntimeException
                exception, System.Management.Automation.Language.IScriptExtent
                extent)
                {
                    InterpreterError.UpdateExceptionErrorRecordPosition((System.Exception)exception, extent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 87671, 87735);
                    return 0;
                }


                System.Management.Automation.ErrorRecord
                f_1664_87771_87786(System.Management.Automation.RuntimeException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 87771, 87786);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1664_87771_87805(System.Management.Automation.ErrorRecord
                this_param, System.Management.Automation.RuntimeException
                replaceParentContainsErrorRecordException)
                {
                    var return_v = this_param.WrapException((System.Exception)replaceParentContainsErrorRecordException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 87771, 87805);
                    return return_v;
                }


                int
                f_1664_87958_88021(System.Management.Automation.Internal.Pipe
                this_param, System.Management.Automation.Internal.VariableStreamKind
                kind, System.Management.Automation.ErrorRecord
                obj)
                {
                    this_param.AppendVariableList(kind, (object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 87958, 88021);
                    return 0;
                }


                int
                f_1664_88061_88094(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.ErrorRecord
                obj)
                {
                    this_param.AppendDollarError((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 88061, 88094);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 86988, 88121);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 86988, 88121);
            }
        }

        internal static bool ExceptionCannotBeStoppedContinuedOrIgnored(RuntimeException rte, ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 88133, 88573);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 88269, 88562);

                return f_1664_88276_88328(context) || (DynAbs.Tracing.TraceSender.Expression_False(1664, 88276, 88396) || f_1664_88352_88388(context) == null
                ) || (DynAbs.Tracing.TraceSender.Expression_False(1664, 88276, 88451) || f_1664_88420_88451(context)) || (DynAbs.Tracing.TraceSender.Expression_False(1664, 88276, 88506) || f_1664_88475_88506(rte)) || (DynAbs.Tracing.TraceSender.Expression_False(1664, 88276, 88561) || rte is PipelineStoppedException);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 88133, 88573);

                bool
                f_1664_88276_88328(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.PropagateExceptionsToEnclosingStatementBlock
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 88276, 88328);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1664_88352_88388(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ShellFunctionErrorOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 88352, 88388);
                    return return_v;
                }


                bool
                f_1664_88420_88451(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentPipelineStopping
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 88420, 88451);
                    return return_v;
                }


                bool
                f_1664_88475_88506(System.Management.Automation.RuntimeException
                this_param)
                {
                    var return_v = this_param.SuppressPromptInInterpreter
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 88475, 88506);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 88133, 88573);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 88133, 88573);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool ReportErrorRecord(IScriptExtent extent, RuntimeException rte, ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 88925, 90249);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 89058, 89138) || true) && (f_1664_89062_89098(context) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 89058, 89138);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 89125, 89138);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 89058, 89138);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 89154, 89247);

                f_1664_89154_89246(f_1664_89173_89188(rte) != null, "The runtime exception's error record was null");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 89263, 89462) || true) && (f_1664_89267_89297(f_1664_89267_89282(rte)) == null && (DynAbs.Tracing.TraceSender.Expression_True(1664, 89267, 89323) && extent != null) && (DynAbs.Tracing.TraceSender.Expression_True(1664, 89267, 89366) && extent != f_1664_89337_89366()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 89263, 89462);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 89385, 89462);

                    f_1664_89385_89461(f_1664_89385_89400(rte), f_1664_89419_89460(null, extent, context));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 89263, 89462);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 89476, 89556);

                PSObject
                errorWrap = f_1664_89497_89555(f_1664_89517_89554(f_1664_89533_89548(rte), rte))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 89572, 89618);

                errorWrap.WriteStream = WriteStreamType.Error;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 89820, 90003) || true) && (f_1664_89824_89862(f_1664_89824_89847(f_1664_89824_89844(context))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 89820, 90003);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 89896, 89988);

                    f_1664_89896_89987(f_1664_89896_89919(f_1664_89896_89916(context)), context, f_1664_89945_89975(f_1664_89945_89960(rte)), errorWrap);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 89820, 90003);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 90019, 90071);

                f_1664_90019_90070(f_1664_90019_90055(context), errorWrap);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 90168, 90210);

                context.QuestionMarkVariableValue = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 90226, 90238);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 88925, 90249);

                System.Management.Automation.Internal.Pipe
                f_1664_89062_89098(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ShellFunctionErrorOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 89062, 89098);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1664_89173_89188(System.Management.Automation.RuntimeException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 89173, 89188);
                    return return_v;
                }


                int
                f_1664_89154_89246(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 89154, 89246);
                    return 0;
                }


                System.Management.Automation.ErrorRecord
                f_1664_89267_89282(System.Management.Automation.RuntimeException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 89267, 89282);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1664_89267_89297(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 89267, 89297);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1664_89337_89366()
                {
                    var return_v = PositionUtilities.EmptyExtent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 89337, 89366);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1664_89385_89400(System.Management.Automation.RuntimeException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 89385, 89400);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1664_89419_89460(System.Management.Automation.CommandInfo
                commandInfo, System.Management.Automation.Language.IScriptExtent
                scriptPosition, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new System.Management.Automation.InvocationInfo(commandInfo, scriptPosition, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 89419, 89460);
                    return return_v;
                }


                int
                f_1664_89385_89461(System.Management.Automation.ErrorRecord
                this_param, System.Management.Automation.InvocationInfo
                invocationInfo)
                {
                    this_param.SetInvocationInfo(invocationInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 89385, 89461);
                    return 0;
                }


                System.Management.Automation.ErrorRecord
                f_1664_89533_89548(System.Management.Automation.RuntimeException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 89533, 89548);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1664_89517_89554(System.Management.Automation.ErrorRecord
                errorRecord, System.Management.Automation.RuntimeException
                replaceParentContainsErrorRecordException)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(errorRecord, (System.Exception)replaceParentContainsErrorRecordException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 89517, 89554);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1664_89497_89555(System.Management.Automation.ErrorRecord
                obj)
                {
                    var return_v = PSObject.AsPSObject((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 89497, 89555);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1664_89824_89844(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.InternalHost;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 89824, 89844);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostUserInterface
                f_1664_89824_89847(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 89824, 89847);
                    return return_v;
                }


                bool
                f_1664_89824_89862(System.Management.Automation.Host.PSHostUserInterface
                this_param)
                {
                    var return_v = this_param.IsTranscribing;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 89824, 89862);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1664_89896_89916(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.InternalHost;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 89896, 89916);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostUserInterface
                f_1664_89896_89919(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 89896, 89919);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1664_89945_89960(System.Management.Automation.RuntimeException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 89945, 89960);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1664_89945_89975(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 89945, 89975);
                    return return_v;
                }


                int
                f_1664_89896_89987(System.Management.Automation.Host.PSHostUserInterface
                this_param, System.Management.Automation.ExecutionContext
                context, System.Management.Automation.InvocationInfo
                invocation, System.Management.Automation.PSObject
                errorWrap)
                {
                    this_param.TranscribeError(context, invocation, errorWrap);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 89896, 89987);
                    return 0;
                }


                System.Management.Automation.Internal.Pipe
                f_1664_90019_90055(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ShellFunctionErrorOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 90019, 90055);
                    return return_v;
                }


                int
                f_1664_90019_90070(System.Management.Automation.Internal.Pipe
                this_param, System.Management.Automation.PSObject
                obj)
                {
                    this_param.Add((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 90019, 90070);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 88925, 90249);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 88925, 90249);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static RuntimeException ConvertToException(object result, IScriptExtent extent, bool rethrow)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 90261, 92448);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 90388, 90419);

                result = f_1664_90397_90418(result);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 90435, 90498);

                RuntimeException
                runtimeException = result as RuntimeException
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 90512, 90836) || true) && (runtimeException != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 90512, 90836);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 90574, 90652);

                    f_1664_90574_90651(runtimeException, extent);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 90670, 90722);

                    runtimeException.WasThrownFromThrowStatement = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 90740, 90779);

                    runtimeException.WasRethrown = rethrow;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 90797, 90821);

                    return runtimeException;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 90512, 90836);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 90852, 90891);

                ErrorRecord
                er = result as ErrorRecord
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 90905, 91243) || true) && (er != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 90905, 91243);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 90953, 91088);

                    runtimeException = new RuntimeException(f_1664_90993_91006(er), f_1664_91008_91020(er), er) { WasThrownFromThrowStatement = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 1664, 90972, 91087), WasRethrown = rethrow };
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 91106, 91184);

                    f_1664_91106_91183(runtimeException, extent);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 91204, 91228);

                    return runtimeException;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 90905, 91243);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 91259, 91301);

                Exception
                exception = result as Exception
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 91315, 91766) || true) && (exception != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 91315, 91766);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 91370, 91459);

                    er = f_1664_91375_91458(exception, f_1664_91402_91419(exception), ErrorCategory.OperationStopped, null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 91477, 91613);

                    runtimeException = new RuntimeException(f_1664_91517_91534(exception), exception, er) { WasThrownFromThrowStatement = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 1664, 91496, 91612), WasRethrown = rethrow };
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 91631, 91709);

                    f_1664_91631_91708(runtimeException, extent);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 91727, 91751);

                    return runtimeException;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 91315, 91766);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 91782, 91953);

                string
                message = (DynAbs.Tracing.TraceSender.Conditional_F1(1664, 91799, 91832) || ((f_1664_91799_91832(result) && DynAbs.Tracing.TraceSender.Conditional_F2(1664, 91852, 91866)) || DynAbs.Tracing.TraceSender.Conditional_F3(1664, 91886, 91952))) ? "ScriptHalted"
                : f_1664_91886_91952(result, f_1664_91922_91951())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 91967, 92015);

                exception = f_1664_91979_92014(message, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 92031, 92110);

                er = f_1664_92036_92109(exception, message, ErrorCategory.OperationStopped, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 92124, 92250);

                runtimeException = new RuntimeException(message, exception, er) { WasThrownFromThrowStatement = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 1664, 92143, 92249), WasRethrown = rethrow };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 92264, 92305);

                f_1664_92264_92304(runtimeException, result);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 92319, 92397);

                f_1664_92319_92396(runtimeException, extent);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 92413, 92437);

                return runtimeException;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 90261, 92448);

                object
                f_1664_90397_90418(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 90397, 90418);
                    return return_v;
                }


                int
                f_1664_90574_90651(System.Management.Automation.RuntimeException
                exception, System.Management.Automation.Language.IScriptExtent
                extent)
                {
                    InterpreterError.UpdateExceptionErrorRecordPosition((System.Exception)exception, extent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 90574, 90651);
                    return 0;
                }


                string
                f_1664_90993_91006(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 90993, 91006);
                    return return_v;
                }


                System.Exception
                f_1664_91008_91020(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 91008, 91020);
                    return return_v;
                }


                int
                f_1664_91106_91183(System.Management.Automation.RuntimeException
                exception, System.Management.Automation.Language.IScriptExtent
                extent)
                {
                    InterpreterError.UpdateExceptionErrorRecordPosition((System.Exception)exception, extent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 91106, 91183);
                    return 0;
                }


                string
                f_1664_91402_91419(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 91402, 91419);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1664_91375_91458(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 91375, 91458);
                    return return_v;
                }


                string
                f_1664_91517_91534(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 91517, 91534);
                    return return_v;
                }


                int
                f_1664_91631_91708(System.Management.Automation.RuntimeException
                exception, System.Management.Automation.Language.IScriptExtent
                extent)
                {
                    InterpreterError.UpdateExceptionErrorRecordPosition((System.Exception)exception, extent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 91631, 91708);
                    return 0;
                }


                bool
                f_1664_91799_91832(object
                obj)
                {
                    var return_v = LanguagePrimitives.IsNull(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 91799, 91832);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1664_91922_91951()
                {
                    var return_v = PositionUtilities.EmptyExtent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 91922, 91951);
                    return return_v;
                }


                string
                f_1664_91886_91952(object
                obj, System.Management.Automation.Language.IScriptExtent
                errorPosition)
                {
                    var return_v = ParserOps.ConvertTo<string>(obj, errorPosition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 91886, 91952);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1664_91979_92014(string
                message, System.Exception
                innerException)
                {
                    var return_v = new System.Management.Automation.RuntimeException(message, innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 91979, 92014);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1664_92036_92109(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 92036, 92109);
                    return return_v;
                }


                int
                f_1664_92264_92304(System.Management.Automation.RuntimeException
                this_param, object
                targetObject)
                {
                    this_param.SetTargetObject(targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 92264, 92304);
                    return 0;
                }


                int
                f_1664_92319_92396(System.Management.Automation.RuntimeException
                exception, System.Management.Automation.Language.IScriptExtent
                extent)
                {
                    InterpreterError.UpdateExceptionErrorRecordPosition((System.Exception)exception, extent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 92319, 92396);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 90261, 92448);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 90261, 92448);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static RuntimeException ConvertToRuntimeException(Exception exception, IScriptExtent extent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 92460, 93239);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 92586, 92652);

                RuntimeException
                runtimeException = exception as RuntimeException
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 92666, 93096) || true) && (runtimeException == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 92666, 93096);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 92728, 92773);

                    var
                    icer = exception as IContainsErrorRecord
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 92791, 92989);

                    var
                    er = (DynAbs.Tracing.TraceSender.Conditional_F1(1664, 92800, 92812) || ((icer != null
                    && DynAbs.Tracing.TraceSender.Conditional_F2(1664, 92845, 92861)) || DynAbs.Tracing.TraceSender.Conditional_F3(1664, 92894, 92988))) ? f_1664_92845_92861(icer) : f_1664_92894_92988(exception, f_1664_92921_92949(f_1664_92921_92940(exception)), ErrorCategory.OperationStopped, null)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 93007, 93081);

                    runtimeException = f_1664_93026_93080(f_1664_93047_93064(exception), exception, er);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 92666, 93096);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 93112, 93190);

                f_1664_93112_93189(runtimeException, extent);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 93204, 93228);

                return runtimeException;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 92460, 93239);

                System.Management.Automation.ErrorRecord
                f_1664_92845_92861(System.Management.Automation.IContainsErrorRecord
                this_param)
                {
                    var return_v = this_param.ErrorRecord
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 92845, 92861);
                    return return_v;
                }


                System.Type
                f_1664_92921_92940(System.Exception
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 92921, 92940);
                    return return_v;
                }


                string
                f_1664_92921_92949(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 92921, 92949);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1664_92894_92988(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 92894, 92988);
                    return return_v;
                }


                string
                f_1664_93047_93064(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 93047, 93064);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1664_93026_93080(string
                message, System.Exception
                innerException, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    var return_v = new System.Management.Automation.RuntimeException(message, innerException, errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 93026, 93080);
                    return return_v;
                }


                int
                f_1664_93112_93189(System.Management.Automation.RuntimeException
                exception, System.Management.Automation.Language.IScriptExtent
                extent)
                {
                    InterpreterError.UpdateExceptionErrorRecordPosition((System.Exception)exception, extent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 93112, 93189);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 92460, 93239);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 92460, 93239);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void ConvertToArgumentConversionException(Exception exception, string parameterName, object argument, string method, Type toType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 93251, 93665);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 93421, 93654);

                throw f_1664_93427_93653("MethodArgumentConversionInvalidCastArgument", exception, f_1664_93540_93592(), parameterName, argument, method, toType, f_1664_93635_93652(exception));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 93251, 93665);

                string
                f_1664_93540_93592()
                {
                    var return_v = ExtendedTypeSystem.MethodArgumentConversionException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 93540, 93592);
                    return return_v;
                }


                string
                f_1664_93635_93652(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 93635, 93652);
                    return return_v;
                }


                System.Management.Automation.MethodException
                f_1664_93427_93653(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.MethodException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 93427, 93653);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 93251, 93665);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 93251, 93665);
            }
        }

        internal static void ConvertToMethodInvocationException(Exception exception, Type typeToThrow, string methodName, int numArgs, MemberInfo memberInfo = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 93677, 96038);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 93858, 93986) || true) && (exception is TargetInvocationException)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 93858, 93986);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 93934, 93971);

                    exception = f_1664_93946_93970(exception);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 93858, 93986);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 94097, 94455) || true) && ((exception is FlowControlException || (DynAbs.Tracing.TraceSender.Expression_False(1664, 94102, 94193) || exception is ScriptCallDepthException) || (DynAbs.Tracing.TraceSender.Expression_False(1664, 94102, 94251) || exception is PipelineStoppedException)) && (DynAbs.Tracing.TraceSender.Expression_True(1664, 94101, 94399) && ((memberInfo == null) || (DynAbs.Tracing.TraceSender.Expression_False(1664, 94274, 94398) || ((f_1664_94300_94324(memberInfo) != typeof(PowerShell)) && (DynAbs.Tracing.TraceSender.Expression_True(1664, 94299, 94397) && (f_1664_94352_94376(memberInfo) != typeof(Pipeline))))))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 94097, 94455);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 94433, 94440);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 94097, 94455);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 94471, 94904) || true) && (typeToThrow == typeof(MethodException))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 94471, 94904);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 94547, 94609) || true) && (exception is MethodException)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 94547, 94609);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 94602, 94609);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 94547, 94609);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 94629, 94889);

                    throw f_1664_94635_94888(f_1664_94691_94715(f_1664_94691_94710(exception)), exception, f_1664_94778_94822(), methodName, numArgs, f_1664_94870_94887(exception));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 94471, 94904);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 94920, 95124) || true) && (f_1664_94924_94979(methodName, "set_", StringComparison.Ordinal) || (DynAbs.Tracing.TraceSender.Expression_False(1664, 94924, 95038) || f_1664_94983_95038(methodName, "get_", StringComparison.Ordinal)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 94920, 95124);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 95072, 95109);

                    methodName = f_1664_95085_95108(methodName, 4);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 94920, 95124);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 95140, 95557) || true) && (typeToThrow == typeof(GetValueInvocationException))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 95140, 95557);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 95228, 95292) || true) && (exception is GetValueException)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 95228, 95292);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 95285, 95292);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 95228, 95292);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 95312, 95542);

                    throw f_1664_95318_95541("ExceptionWhenGetting", exception, f_1664_95449_95488(), methodName, f_1664_95523_95540(exception));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 95140, 95557);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 95573, 95723);

                f_1664_95573_95722(typeToThrow == typeof(SetValueInvocationException), "caller to verify exception is expected type");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 95737, 95797) || true) && (exception is SetValueException)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 95737, 95797);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 95790, 95797);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 95737, 95797);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 95813, 96027);

                throw f_1664_95819_96026("ExceptionWhenSetting", exception, f_1664_95938_95977(), methodName, f_1664_96008_96025(exception));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 93677, 96038);

                System.Exception
                f_1664_93946_93970(System.Exception
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 93946, 93970);
                    return return_v;
                }


                System.Type
                f_1664_94300_94324(System.Reflection.MemberInfo
                this_param)
                {
                    var return_v = this_param.DeclaringType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 94300, 94324);
                    return return_v;
                }


                System.Type
                f_1664_94352_94376(System.Reflection.MemberInfo
                this_param)
                {
                    var return_v = this_param.DeclaringType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 94352, 94376);
                    return return_v;
                }


                System.Type
                f_1664_94691_94710(System.Exception
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 94691, 94710);
                    return return_v;
                }


                string
                f_1664_94691_94715(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 94691, 94715);
                    return return_v;
                }


                string
                f_1664_94778_94822()
                {
                    var return_v = ExtendedTypeSystem.MethodInvocationException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 94778, 94822);
                    return return_v;
                }


                string
                f_1664_94870_94887(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 94870, 94887);
                    return return_v;
                }


                System.Management.Automation.MethodInvocationException
                f_1664_94635_94888(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.MethodInvocationException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 94635, 94888);
                    return return_v;
                }


                bool
                f_1664_94924_94979(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 94924, 94979);
                    return return_v;
                }


                bool
                f_1664_94983_95038(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 94983, 95038);
                    return return_v;
                }


                string
                f_1664_95085_95108(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 95085, 95108);
                    return return_v;
                }


                string
                f_1664_95449_95488()
                {
                    var return_v = ExtendedTypeSystem.ExceptionWhenGetting;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 95449, 95488);
                    return return_v;
                }


                string
                f_1664_95523_95540(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 95523, 95540);
                    return return_v;
                }


                System.Management.Automation.GetValueInvocationException
                f_1664_95318_95541(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.GetValueInvocationException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 95318, 95541);
                    return return_v;
                }


                int
                f_1664_95573_95722(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 95573, 95722);
                    return 0;
                }


                string
                f_1664_95938_95977()
                {
                    var return_v = ExtendedTypeSystem.ExceptionWhenSetting;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 95938, 95977);
                    return return_v;
                }


                string
                f_1664_96008_96025(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 96008, 96025);
                    return return_v;
                }


                System.Management.Automation.SetValueInvocationException
                f_1664_95819_96026(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.SetValueInvocationException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 95819, 96026);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 93677, 96038);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 93677, 96038);
            }
        }

        static ExceptionHandlingOps()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1664, 63808, 96045);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1664, 63808, 96045);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 63808, 96045);
        }

    }
    internal static class TypeOps
    {
        internal static Type ResolveTypeName(ITypeName typeName, IScriptExtent errorPos)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 96099, 99153);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 96204, 96224);

                Exception
                exception
                = default(Exception);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 96238, 96306);

                var
                result = f_1664_96251_96305(typeName, out exception)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 96322, 99112) || true) && (result == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 96322, 99112);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 96374, 97160) || true) && (exception != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 96374, 97160);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 96437, 96716) || true) && (exception is InvalidCastException && (DynAbs.Tracing.TraceSender.Expression_True(1664, 96441, 96535) && f_1664_96503_96527(exception) != null) && (DynAbs.Tracing.TraceSender.Expression_True(1664, 96441, 96627) && f_1664_96564_96588(exception) is TypeResolver.AmbiguousTypeException))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 96437, 96716);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 96677, 96693);

                            throw exception;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 96437, 96716);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 96740, 97141);

                        throw f_1664_96746_97140(typeName, typeof(RuntimeException), errorPos, "TypeNotFoundWithMessage", f_1664_96996_97033(), f_1664_97103_97120(typeName), f_1664_97122_97139(exception));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 96374, 97160);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 97444, 97494);

                    var
                    genericTypeName = typeName as GenericTypeName
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 97512, 98568) || true) && (genericTypeName != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 97512, 98568);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 97581, 97679);

                        var
                        generic = f_1664_97595_97678(genericTypeName, f_1664_97626_97677(f_1664_97642_97666(genericTypeName), errorPos))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 97701, 97811);

                        var
                        typeArgs = f_1664_97716_97810((DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => from arg in genericTypeName.GenericArguments select ResolveTypeName(arg, errorPos), 1664, 97717, 97799)))
                        ;

                        try
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 97887, 98008) || true) && (generic != null && (DynAbs.Tracing.TraceSender.Expression_True(1664, 97891, 97943) && f_1664_97910_97943(generic)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 97887, 98008);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 97974, 98008);

                                f_1664_97974_98007(generic, typeArgs);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 97887, 98008);
                            }
                        }
                        catch (Exception e)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1664, 98053, 98549);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 98121, 98526);

                            throw f_1664_98127_98525(typeName, typeof(RuntimeException), errorPos, "TypeNotFoundWithMessage", f_1664_98385_98422(), f_1664_98496_98513(typeName), f_1664_98515_98524(e));
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1664, 98053, 98549);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 97512, 98568);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 98588, 98634);

                    var
                    arrayTypeName = typeName as ArrayTypeName
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 98654, 98793) || true) && (arrayTypeName != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 98654, 98793);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 98721, 98774);

                        f_1664_98721_98773(f_1664_98737_98762(arrayTypeName), errorPos);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 98654, 98793);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 98813, 99097);

                    throw f_1664_98819_99096(typeName, typeof(RuntimeException), errorPos, "TypeNotFound", f_1664_98986_99012(), f_1664_99078_99095(typeName));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 96322, 99112);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 99128, 99142);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 96099, 99153);

                System.Type
                f_1664_96251_96305(System.Management.Automation.Language.ITypeName
                iTypeName, out System.Exception
                exception)
                {
                    var return_v = TypeResolver.ResolveITypeName(iTypeName, out exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 96251, 96305);
                    return return_v;
                }


                System.Exception
                f_1664_96503_96527(System.Exception
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 96503, 96527);
                    return return_v;
                }


                System.Exception
                f_1664_96564_96588(System.Exception
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 96564, 96588);
                    return return_v;
                }


                string
                f_1664_96996_97033()
                {
                    var return_v = ParserStrings.TypeNotFoundWithMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 96996, 97033);
                    return return_v;
                }


                string
                f_1664_97103_97120(System.Management.Automation.Language.ITypeName
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 97103, 97120);
                    return return_v;
                }


                string
                f_1664_97122_97139(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 97122, 97139);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1664_96746_97140(System.Management.Automation.Language.ITypeName
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException((object)targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 96746, 97140);
                    return return_v;
                }


                System.Management.Automation.Language.ITypeName
                f_1664_97642_97666(System.Management.Automation.Language.GenericTypeName
                this_param)
                {
                    var return_v = this_param.TypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 97642, 97666);
                    return return_v;
                }


                System.Type
                f_1664_97626_97677(System.Management.Automation.Language.ITypeName
                typeName, System.Management.Automation.Language.IScriptExtent
                errorPos)
                {
                    var return_v = ResolveTypeName(typeName, errorPos);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 97626, 97677);
                    return return_v;
                }


                System.Type
                f_1664_97595_97678(System.Management.Automation.Language.GenericTypeName
                this_param, System.Type
                generic)
                {
                    var return_v = this_param.GetGenericType(generic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 97595, 97678);
                    return return_v;
                }


                System.Type[]
                f_1664_97716_97810(System.Collections.Generic.IEnumerable<System.Type>
                source)
                {
                    var return_v = source.ToArray<System.Type>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 97716, 97810);
                    return return_v;
                }


                bool
                f_1664_97910_97943(System.Type
                this_param)
                {
                    var return_v = this_param.ContainsGenericParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 97910, 97943);
                    return return_v;
                }


                System.Type
                f_1664_97974_98007(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 97974, 98007);
                    return return_v;
                }


                string
                f_1664_98385_98422()
                {
                    var return_v = ParserStrings.TypeNotFoundWithMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 98385, 98422);
                    return return_v;
                }


                string
                f_1664_98496_98513(System.Management.Automation.Language.ITypeName
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 98496, 98513);
                    return return_v;
                }


                string
                f_1664_98515_98524(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 98515, 98524);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1664_98127_98525(System.Management.Automation.Language.ITypeName
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException((object)targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 98127, 98525);
                    return return_v;
                }


                System.Management.Automation.Language.ITypeName
                f_1664_98737_98762(System.Management.Automation.Language.ArrayTypeName
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 98737, 98762);
                    return return_v;
                }


                System.Type
                f_1664_98721_98773(System.Management.Automation.Language.ITypeName
                typeName, System.Management.Automation.Language.IScriptExtent
                errorPos)
                {
                    var return_v = ResolveTypeName(typeName, errorPos);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 98721, 98773);
                    return return_v;
                }


                string
                f_1664_98986_99012()
                {
                    var return_v = ParserStrings.TypeNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 98986, 99012);
                    return return_v;
                }


                string
                f_1664_99078_99095(System.Management.Automation.Language.ITypeName
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 99078, 99095);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1664_98819_99096(System.Management.Automation.Language.ITypeName
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException((object)targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 98819, 99096);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 96099, 99153);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 96099, 99153);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsInstance(object left, object right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 99165, 100287);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 99248, 99282);

                object
                lval = f_1664_99262_99281(left)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 99296, 99331);

                object
                rval = f_1664_99310_99330(right)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 99347, 99373);

                Type
                rType = rval as Type
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 99389, 99841) || true) && (rType == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 99389, 99841);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 99440, 99486);

                    rType = f_1664_99448_99485(rval, null);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 99506, 99826) || true) && (rType == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 99506, 99826);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 99633, 99807);

                        throw f_1664_99639_99806(rval, typeof(RuntimeException), null, "IsOperatorRequiresType", f_1664_99769_99805());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 99506, 99826);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 99389, 99841);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 99857, 100093) || true) && (rType == typeof(PSCustomObject) && (DynAbs.Tracing.TraceSender.Expression_True(1664, 99861, 99912) && lval is PSObject))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 99857, 100093);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 99946, 100048);

                    f_1664_99946_100047(f_1664_99965_100025(rType, f_1664_99988_100024(((PSObject)lval))), "Unexpect PSObject");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 100066, 100078);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 99857, 100093);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 100109, 100224) || true) && (f_1664_100113_100143(rType, typeof(PSObject)) && (DynAbs.Tracing.TraceSender.Expression_True(1664, 100113, 100163) && left is PSObject))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 100109, 100224);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 100197, 100209);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 100109, 100224);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 100240, 100276);

                return f_1664_100247_100275(rType, lval);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 99165, 100287);

                object
                f_1664_99262_99281(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 99262, 99281);
                    return return_v;
                }


                object
                f_1664_99310_99330(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 99310, 99330);
                    return return_v;
                }


                System.Type
                f_1664_99448_99485(object
                obj, System.Management.Automation.Language.IScriptExtent
                errorPosition)
                {
                    var return_v = ParserOps.ConvertTo<Type>(obj, errorPosition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 99448, 99485);
                    return return_v;
                }


                string
                f_1664_99769_99805()
                {
                    var return_v = ParserStrings.IsOperatorRequiresType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 99769, 99805);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1664_99639_99806(object
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException(targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 99639, 99806);
                    return return_v;
                }


                object
                f_1664_99988_100024(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.ImmediateBaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 99988, 100024);
                    return return_v;
                }


                bool
                f_1664_99965_100025(System.Type
                this_param, object
                o)
                {
                    var return_v = this_param.IsInstanceOfType(o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 99965, 100025);
                    return return_v;
                }


                int
                f_1664_99946_100047(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 99946, 100047);
                    return 0;
                }


                bool
                f_1664_100113_100143(System.Type
                this_param, System.Type
                o)
                {
                    var return_v = this_param.Equals(o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 100113, 100143);
                    return return_v;
                }


                bool
                f_1664_100247_100275(System.Type
                this_param, object
                o)
                {
                    var return_v = this_param.IsInstanceOfType(o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 100247, 100275);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 99165, 100287);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 99165, 100287);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object AsOperator(object left, Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 100299, 101729);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 100381, 100659) || true) && (type == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 100381, 100659);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 100431, 100644);

                    throw f_1664_100437_100643(null, typeof(RuntimeException), null, "AsOperatorRequiresType", f_1664_100606_100642());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 100381, 100659);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 100888, 100900);

                bool
                debase
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 101036, 101113);

                var
                conversion = f_1664_101053_101112(left, type, out debase)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 101127, 101230) || true) && (f_1664_101131_101146(conversion) == ConversionRank.None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 101127, 101230);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 101203, 101215);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 101127, 101230);
                }

                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 101282, 101491) || true) && (debase)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 101282, 101491);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 101334, 101472);

                        return f_1664_101341_101471(conversion, f_1664_101359_101378(left), type, false, left, f_1664_101434_101464(), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 101282, 101491);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 101511, 101599);

                    return f_1664_101518_101598(conversion, left, type, false, null, f_1664_101561_101591(), null);
                }
                catch (PSInvalidCastException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1664, 101628, 101718);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 101691, 101703);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1664, 101628, 101718);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 100299, 101729);

                string
                f_1664_100606_100642()
                {
                    var return_v = ParserStrings.AsOperatorRequiresType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 100606, 100642);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1664_100437_100643(object
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException(targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 100437, 100643);
                    return return_v;
                }


                System.Management.Automation.LanguagePrimitives.IConversionData
                f_1664_101053_101112(object
                valueToConvert, System.Type
                resultType, out bool
                debase)
                {
                    var return_v = LanguagePrimitives.FigureConversion(valueToConvert, resultType, out debase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 101053, 101112);
                    return return_v;
                }


                System.Management.Automation.ConversionRank
                f_1664_101131_101146(System.Management.Automation.LanguagePrimitives.IConversionData
                this_param)
                {
                    var return_v = this_param.Rank;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 101131, 101146);
                    return return_v;
                }


                object
                f_1664_101359_101378(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 101359, 101378);
                    return return_v;
                }


                System.Globalization.NumberFormatInfo
                f_1664_101434_101464()
                {
                    var return_v = NumberFormatInfo.InvariantInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 101434, 101464);
                    return return_v;
                }


                object
                f_1664_101341_101471(System.Management.Automation.LanguagePrimitives.IConversionData
                this_param, object
                valueToConvert, System.Type
                resultType, bool
                recurse, object
                originalValueToConvert, System.Globalization.NumberFormatInfo
                formatProvider, System.Management.Automation.Runspaces.TypeTable
                backupTable)
                {
                    var return_v = this_param.Invoke(valueToConvert, resultType, recurse, (System.Management.Automation.PSObject)originalValueToConvert, (System.IFormatProvider)formatProvider, backupTable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 101341, 101471);
                    return return_v;
                }


                System.Globalization.NumberFormatInfo
                f_1664_101561_101591()
                {
                    var return_v = NumberFormatInfo.InvariantInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 101561, 101591);
                    return return_v;
                }


                object
                f_1664_101518_101598(System.Management.Automation.LanguagePrimitives.IConversionData
                this_param, object
                valueToConvert, System.Type
                resultType, bool
                recurse, System.Management.Automation.PSObject
                originalValueToConvert, System.Globalization.NumberFormatInfo
                formatProvider, System.Management.Automation.Runspaces.TypeTable
                backupTable)
                {
                    var return_v = this_param.Invoke(valueToConvert, resultType, recurse, originalValueToConvert, (System.IFormatProvider)formatProvider, backupTable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 101518, 101598);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 100299, 101729);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 100299, 101729);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string[] GetNamespacesForTypeResolutionState(IEnumerable<UsingStatementAst> usingAsts)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 101741, 102576);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 101868, 101891);

                var
                usedSystem = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 101905, 101941);

                var
                namespaces = f_1664_101922_101940()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 101957, 102410);
                    foreach (var usingStmt in f_1664_101983_101992_I(usingAsts))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 101957, 102410);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 102026, 102395) || true) && (f_1664_102030_102058(usingStmt) == UsingStatementKind.Namespace)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 102026, 102395);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 102132, 102315) || true) && (!usedSystem && (DynAbs.Tracing.TraceSender.Expression_True(1664, 102136, 102224) && f_1664_102151_102224(f_1664_102151_102171(f_1664_102151_102165(usingStmt)), "System", StringComparison.OrdinalIgnoreCase)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 102132, 102315);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 102274, 102292);

                                usedSystem = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 102132, 102315);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 102339, 102376);

                            f_1664_102339_102375(
                                                namespaces, f_1664_102354_102374(f_1664_102354_102368(usingStmt)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 102026, 102395);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 101957, 102410);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 1, 454);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 1, 454);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 102426, 102521) || true) && (!usedSystem)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 102426, 102521);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 102475, 102506);

                    f_1664_102475_102505(namespaces, 0, "System");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 102426, 102521);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 102537, 102565);

                return f_1664_102544_102564(namespaces);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 101741, 102576);

                System.Collections.Generic.List<string>
                f_1664_101922_101940()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 101922, 101940);
                    return return_v;
                }


                System.Management.Automation.Language.UsingStatementKind
                f_1664_102030_102058(System.Management.Automation.Language.UsingStatementAst
                this_param)
                {
                    var return_v = this_param.UsingStatementKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 102030, 102058);
                    return return_v;
                }


                System.Management.Automation.Language.StringConstantExpressionAst
                f_1664_102151_102165(System.Management.Automation.Language.UsingStatementAst
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 102151, 102165);
                    return return_v;
                }


                string
                f_1664_102151_102171(System.Management.Automation.Language.StringConstantExpressionAst
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 102151, 102171);
                    return return_v;
                }


                bool
                f_1664_102151_102224(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 102151, 102224);
                    return return_v;
                }


                System.Management.Automation.Language.StringConstantExpressionAst
                f_1664_102354_102368(System.Management.Automation.Language.UsingStatementAst
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 102354, 102368);
                    return return_v;
                }


                string
                f_1664_102354_102374(System.Management.Automation.Language.StringConstantExpressionAst
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 102354, 102374);
                    return return_v;
                }


                int
                f_1664_102339_102375(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 102339, 102375);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.Language.UsingStatementAst>
                f_1664_101983_101992_I(System.Collections.Generic.IEnumerable<System.Management.Automation.Language.UsingStatementAst>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 101983, 101992);
                    return return_v;
                }


                int
                f_1664_102475_102505(System.Collections.Generic.List<string>
                this_param, int
                index, string
                item)
                {
                    this_param.Insert(index, item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 102475, 102505);
                    return 0;
                }


                string[]
                f_1664_102544_102564(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 102544, 102564);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 101741, 102576);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 101741, 102576);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void AddPowerShellTypesToTheScope(Dictionary<string, TypeDefinitionAst> types, ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 103629, 104231);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 103774, 103844);

                var
                trs = f_1664_103784_103843(f_1664_103784_103823(f_1664_103784_103810(context)))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 103860, 104101);
                    foreach (var t in f_1664_103878_103883_I(types))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 103860, 104101);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 103917, 103999);

                        f_1664_103917_103998(f_1664_103936_103948(t.Value) != null, "TypeDefinitionAst.Type cannot be null");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 104017, 104086);

                        f_1664_104017_104085(f_1664_104017_104056(f_1664_104017_104043(context)), t.Key, f_1664_104072_104084(t.Value));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 103860, 104101);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 1, 242);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 1, 242);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 104117, 104220);

                f_1664_104117_104156(f_1664_104117_104143(context)).TypeResolutionState = f_1664_104179_104219(trs, f_1664_104208_104218(types));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 103629, 104231);

                System.Management.Automation.SessionStateInternal
                f_1664_103784_103810(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 103784, 103810);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1664_103784_103823(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 103784, 103823);
                    return return_v;
                }


                System.Management.Automation.Language.TypeResolutionState
                f_1664_103784_103843(System.Management.Automation.SessionStateScope
                this_param)
                {
                    var return_v = this_param.TypeResolutionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 103784, 103843);
                    return return_v;
                }


                System.Type
                f_1664_103936_103948(System.Management.Automation.Language.TypeDefinitionAst
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 103936, 103948);
                    return return_v;
                }


                int
                f_1664_103917_103998(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 103917, 103998);
                    return 0;
                }


                System.Management.Automation.SessionStateInternal
                f_1664_104017_104043(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 104017, 104043);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1664_104017_104056(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 104017, 104056);
                    return return_v;
                }


                System.Type
                f_1664_104072_104084(System.Management.Automation.Language.TypeDefinitionAst
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 104072, 104084);
                    return return_v;
                }


                int
                f_1664_104017_104085(System.Management.Automation.SessionStateScope
                this_param, string
                name, System.Type
                type)
                {
                    this_param.AddType(name, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 104017, 104085);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.TypeDefinitionAst>
                f_1664_103878_103883_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.TypeDefinitionAst>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 103878, 103883);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1664_104117_104143(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 104117, 104143);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1664_104117_104156(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 104117, 104156);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.TypeDefinitionAst>.KeyCollection
                f_1664_104208_104218(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.TypeDefinitionAst>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 104208, 104218);
                    return return_v;
                }


                System.Management.Automation.Language.TypeResolutionState
                f_1664_104179_104219(System.Management.Automation.Language.TypeResolutionState
                this_param, System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.TypeDefinitionAst>.KeyCollection
                types)
                {
                    var return_v = this_param.CloneWithAddTypesDefined((System.Collections.Generic.IEnumerable<string>)types);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 104179, 104219);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 103629, 104231);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 103629, 104231);
            }
        }

        internal static void InitPowerShellTypesAtRuntime(TypeDefinitionAst[] types)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 104442, 105763);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 104543, 105752);
                    foreach (var t in f_1664_104561_104566_I(types))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 104543, 105752);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 104600, 104676);

                        f_1664_104600_104675(f_1664_104619_104625(t) != null, "TypeDefinitionAst.Type cannot be null");

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 104694, 105737) || true) && (f_1664_104698_104707(t))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 104694, 105737);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 104749, 104853);

                            var
                            helperType =
                            f_1664_104791_104852(f_1664_104791_104806(f_1664_104791_104797(t)), f_1664_104815_104830(f_1664_104815_104821(t)) + "_<staticHelpers>")
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 104875, 104985);

                            f_1664_104875_104984(helperType != null, "no corresponding " + f_1664_104936_104951(f_1664_104936_104942(t)) + "_<staticHelpers> type found");
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 105007, 105718);
                                foreach (var p in f_1664_105025_105091_I(f_1664_105025_105091(helperType, BindingFlags.Static | BindingFlags.NonPublic)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 105007, 105718);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 105141, 105170);

                                    var
                                    field = f_1664_105153_105169(p, null)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 105308, 105368);

                                    var
                                    methodWrapper = field as ScriptBlockMemberMethodWrapper
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 105394, 105695) || true) && (methodWrapper != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 105394, 105695);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 105477, 105507);

                                        f_1664_105477_105506(methodWrapper);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 105394, 105695);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 105394, 105695);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 105621, 105668);

                                        f_1664_105621_105667(((SessionStateKeeper)field));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 105394, 105695);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 105007, 105718);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 1, 712);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 1, 712);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 104694, 105737);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 104543, 105752);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 1, 1210);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 1, 1210);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 104442, 105763);

                System.Type
                f_1664_104619_104625(System.Management.Automation.Language.TypeDefinitionAst
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 104619, 104625);
                    return return_v;
                }


                int
                f_1664_104600_104675(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 104600, 104675);
                    return 0;
                }


                bool
                f_1664_104698_104707(System.Management.Automation.Language.TypeDefinitionAst
                this_param)
                {
                    var return_v = this_param.IsClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 104698, 104707);
                    return return_v;
                }


                System.Type
                f_1664_104791_104797(System.Management.Automation.Language.TypeDefinitionAst
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 104791, 104797);
                    return return_v;
                }


                System.Reflection.Assembly
                f_1664_104791_104806(System.Type
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 104791, 104806);
                    return return_v;
                }


                System.Type
                f_1664_104815_104821(System.Management.Automation.Language.TypeDefinitionAst
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 104815, 104821);
                    return return_v;
                }


                string
                f_1664_104815_104830(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 104815, 104830);
                    return return_v;
                }


                System.Type?
                f_1664_104791_104852(System.Reflection.Assembly
                this_param, string
                name)
                {
                    var return_v = this_param.GetType(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 104791, 104852);
                    return return_v;
                }


                System.Type
                f_1664_104936_104942(System.Management.Automation.Language.TypeDefinitionAst
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 104936, 104942);
                    return return_v;
                }


                string
                f_1664_104936_104951(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 104936, 104951);
                    return return_v;
                }


                int
                f_1664_104875_104984(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 104875, 104984);
                    return 0;
                }


                System.Reflection.FieldInfo[]
                f_1664_105025_105091(System.Type
                this_param, System.Reflection.BindingFlags
                bindingAttr)
                {
                    var return_v = this_param.GetFields(bindingAttr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 105025, 105091);
                    return return_v;
                }


                object?
                f_1664_105153_105169(System.Reflection.FieldInfo
                this_param, object?
                obj)
                {
                    var return_v = this_param.GetValue(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 105153, 105169);
                    return return_v;
                }


                int
                f_1664_105477_105506(System.Management.Automation.Internal.ScriptBlockMemberMethodWrapper
                this_param)
                {
                    this_param.InitAtRuntime();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 105477, 105506);
                    return 0;
                }


                int
                f_1664_105621_105667(System.Management.Automation.Internal.SessionStateKeeper
                this_param)
                {
                    this_param.RegisterRunspace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 105621, 105667);
                    return 0;
                }


                System.Reflection.FieldInfo[]
                f_1664_105025_105091_I(System.Reflection.FieldInfo[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 105025, 105091);
                    return return_v;
                }


                System.Management.Automation.Language.TypeDefinitionAst[]
                f_1664_104561_104566_I(System.Management.Automation.Language.TypeDefinitionAst[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 104561, 104566);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 104442, 105763);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 104442, 105763);
            }
        }

        internal static void SetCurrentTypeResolutionState(TypeResolutionState trs, ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 105775, 105978);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 105901, 105967);

                f_1664_105901_105940(f_1664_105901_105927(context)).TypeResolutionState = trs;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 105775, 105978);

                System.Management.Automation.SessionStateInternal
                f_1664_105901_105927(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 105901, 105927);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1664_105901_105940(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 105901, 105940);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 105775, 105978);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 105775, 105978);
            }
        }

        internal static void SetAssemblyDefiningPSTypes(FunctionContext functionContext, Assembly assembly)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 105990, 106189);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 106114, 106178);

                functionContext._scriptBlock.AssemblyDefiningPSTypes = assembly;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 105990, 106189);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 105990, 106189);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 105990, 106189);
            }
        }

        static TypeOps()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1664, 96053, 106196);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1664, 96053, 106196);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 96053, 106196);
        }

    }
    internal static class SwitchOps
    {
        internal static bool ConditionSatisfiedWildcard(bool caseSensitive,
                                                                object condition,
                                                                string str,
                                                                ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 106252, 107525);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 106571, 106627);

                WildcardPattern
                wildcard = condition as WildcardPattern
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 106641, 107469) || true) && (wildcard != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 106641, 107469);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 106885, 107193) || true) && (((f_1664_106891_106907(wildcard) & WildcardOptions.IgnoreCase) == 0) != caseSensitive)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 106885, 107193);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 107002, 107094);

                        WildcardOptions
                        options = (DynAbs.Tracing.TraceSender.Conditional_F1(1664, 107028, 107041) || ((caseSensitive && DynAbs.Tracing.TraceSender.Conditional_F2(1664, 107044, 107064)) || DynAbs.Tracing.TraceSender.Conditional_F3(1664, 107067, 107093))) ? WildcardOptions.None : WildcardOptions.IgnoreCase
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 107116, 107174);

                        wildcard = f_1664_107127_107173(f_1664_107147_107163(wildcard), options);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 106885, 107193);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 106641, 107469);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 106641, 107469);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 107259, 107351);

                    WildcardOptions
                    options = (DynAbs.Tracing.TraceSender.Conditional_F1(1664, 107285, 107298) || ((caseSensitive && DynAbs.Tracing.TraceSender.Conditional_F2(1664, 107301, 107321)) || DynAbs.Tracing.TraceSender.Conditional_F3(1664, 107324, 107350))) ? WildcardOptions.None : WildcardOptions.IgnoreCase
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 107369, 107454);

                    wildcard = f_1664_107380_107453(f_1664_107400_107443(context, condition), options);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 106641, 107469);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 107485, 107514);

                return f_1664_107492_107513(wildcard, str);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 106252, 107525);

                System.Management.Automation.WildcardOptions
                f_1664_106891_106907(System.Management.Automation.WildcardPattern
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 106891, 106907);
                    return return_v;
                }


                string
                f_1664_107147_107163(System.Management.Automation.WildcardPattern
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 107147, 107163);
                    return return_v;
                }


                System.Management.Automation.WildcardPattern
                f_1664_107127_107173(string
                pattern, System.Management.Automation.WildcardOptions
                options)
                {
                    var return_v = WildcardPattern.Get(pattern, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 107127, 107173);
                    return return_v;
                }


                string
                f_1664_107400_107443(System.Management.Automation.ExecutionContext
                context, object
                obj)
                {
                    var return_v = PSObject.ToStringParser(context, obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 107400, 107443);
                    return return_v;
                }


                System.Management.Automation.WildcardPattern
                f_1664_107380_107453(string
                pattern, System.Management.Automation.WildcardOptions
                options)
                {
                    var return_v = WildcardPattern.Get(pattern, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 107380, 107453);
                    return return_v;
                }


                bool
                f_1664_107492_107513(System.Management.Automation.WildcardPattern
                this_param, string
                input)
                {
                    var return_v = this_param.IsMatch(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 107492, 107513);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 106252, 107525);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 106252, 107525);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool ConditionSatisfiedRegex(bool caseSensitive,
                                                             object condition,
                                                             IScriptExtent errorPosition,
                                                             string str,
                                                             ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 107537, 110713);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 107927, 107942);

                string
                pattern
                = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 107958, 108041);

                RegexOptions
                options = (DynAbs.Tracing.TraceSender.Conditional_F1(1664, 107981, 107994) || ((caseSensitive && DynAbs.Tracing.TraceSender.Conditional_F2(1664, 107997, 108014)) || DynAbs.Tracing.TraceSender.Conditional_F3(1664, 108017, 108040))) ? RegexOptions.None : RegexOptions.IgnoreCase
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 108093, 108101);

                    Match
                    m
                    = default(Match);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 108121, 108154);

                    Regex
                    regex = condition as Regex
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 108314, 109116) || true) && (regex != null && (DynAbs.Tracing.TraceSender.Expression_True(1664, 108318, 108402) && (((f_1664_108338_108351(regex) & RegexOptions.IgnoreCase) != 0) != caseSensitive)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 108314, 109116);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 108444, 108465);

                        m = f_1664_108448_108464(regex, str);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 108314, 109116);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 108314, 109116);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 108547, 108601);

                        pattern = f_1664_108557_108600(context, condition);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 108623, 108662);

                        m = f_1664_108627_108661(str, pattern, options);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 108686, 109097) || true) && (f_1664_108690_108699(m) && (DynAbs.Tracing.TraceSender.Expression_True(1664, 108690, 108721) && f_1664_108703_108717(f_1664_108703_108711(m)) > 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 108686, 109097);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 109038, 109074);

                            regex = f_1664_109046_109073(pattern, options);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 108686, 109097);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 108314, 109116);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 109136, 110211) || true) && (f_1664_109140_109149(m))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 109136, 110211);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 109191, 109225);

                        GroupCollection
                        groups = f_1664_109216_109224(m)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 109249, 110192) || true) && (f_1664_109253_109265(groups) > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 109249, 110192);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 109319, 109395);

                            f_1664_109319_109394(regex != null, "Logic above ensures regex is not null.");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 109423, 109492);

                            Hashtable
                            h = f_1664_109437_109491(f_1664_109451_109490())
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 109520, 110085);
                                foreach (string groupName in f_1664_109549_109570_I(f_1664_109549_109570(regex)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 109520, 110085);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 109628, 109656);

                                    Group
                                    g = f_1664_109638_109655(groups, groupName)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 109686, 110058) || true) && (f_1664_109690_109699(g))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 109686, 110058);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 109765, 109776);

                                        int
                                        keyInt
                                        = default(int);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 109812, 110027) || true) && (f_1664_109816_109853(groupName, out keyInt))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 109812, 110027);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 109892, 109920);

                                            f_1664_109892_109919(h, keyInt, f_1664_109906_109918(g));
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 109812, 110027);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 109812, 110027);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 109996, 110027);

                                            f_1664_109996_110026(h, groupName, f_1664_110013_110025(g));
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 109812, 110027);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 109686, 110058);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 109520, 110085);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 1, 566);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 1, 566);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 110113, 110169);

                            f_1664_110113_110168(
                                                    context, SpecialVariables.MatchesVarPath, h);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 109249, 110192);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 109136, 110211);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 110231, 110248);

                    return f_1664_110238_110247(m);
                }
                catch (ArgumentException ae)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1664, 110277, 110702);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 110398, 110452);

                    pattern = f_1664_110408_110451(context, condition);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 110470, 110687);

                    throw f_1664_110476_110686(pattern, typeof(RuntimeException), errorPosition, "InvalidRegularExpression", f_1664_110634_110672(), ae, pattern);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1664, 110277, 110702);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 107537, 110713);

                System.Text.RegularExpressions.RegexOptions
                f_1664_108338_108351(System.Text.RegularExpressions.Regex
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 108338, 108351);
                    return return_v;
                }


                System.Text.RegularExpressions.Match
                f_1664_108448_108464(System.Text.RegularExpressions.Regex
                this_param, string
                input)
                {
                    var return_v = this_param.Match(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 108448, 108464);
                    return return_v;
                }


                string
                f_1664_108557_108600(System.Management.Automation.ExecutionContext
                context, object
                obj)
                {
                    var return_v = PSObject.ToStringParser(context, obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 108557, 108600);
                    return return_v;
                }


                System.Text.RegularExpressions.Match
                f_1664_108627_108661(string
                input, string
                pattern, System.Text.RegularExpressions.RegexOptions
                options)
                {
                    var return_v = Regex.Match(input, pattern, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 108627, 108661);
                    return return_v;
                }


                bool
                f_1664_108690_108699(System.Text.RegularExpressions.Match
                this_param)
                {
                    var return_v = this_param.Success;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 108690, 108699);
                    return return_v;
                }


                System.Text.RegularExpressions.GroupCollection
                f_1664_108703_108711(System.Text.RegularExpressions.Match
                this_param)
                {
                    var return_v = this_param.Groups;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 108703, 108711);
                    return return_v;
                }


                int
                f_1664_108703_108717(System.Text.RegularExpressions.GroupCollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 108703, 108717);
                    return return_v;
                }


                System.Text.RegularExpressions.Regex
                f_1664_109046_109073(string
                pattern, System.Text.RegularExpressions.RegexOptions
                options)
                {
                    var return_v = new System.Text.RegularExpressions.Regex(pattern, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 109046, 109073);
                    return return_v;
                }


                bool
                f_1664_109140_109149(System.Text.RegularExpressions.Match
                this_param)
                {
                    var return_v = this_param.Success;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 109140, 109149);
                    return return_v;
                }


                System.Text.RegularExpressions.GroupCollection
                f_1664_109216_109224(System.Text.RegularExpressions.Match
                this_param)
                {
                    var return_v = this_param.Groups;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 109216, 109224);
                    return return_v;
                }


                int
                f_1664_109253_109265(System.Text.RegularExpressions.GroupCollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 109253, 109265);
                    return return_v;
                }


                int
                f_1664_109319_109394(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 109319, 109394);
                    return 0;
                }


                System.StringComparer
                f_1664_109451_109490()
                {
                    var return_v = StringComparer.CurrentCultureIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 109451, 109490);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1664_109437_109491(System.StringComparer
                equalityComparer)
                {
                    var return_v = new System.Collections.Hashtable((System.Collections.IEqualityComparer)equalityComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 109437, 109491);
                    return return_v;
                }


                string[]
                f_1664_109549_109570(System.Text.RegularExpressions.Regex
                this_param)
                {
                    var return_v = this_param.GetGroupNames();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 109549, 109570);
                    return return_v;
                }


                System.Text.RegularExpressions.Group
                f_1664_109638_109655(System.Text.RegularExpressions.GroupCollection
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 109638, 109655);
                    return return_v;
                }


                bool
                f_1664_109690_109699(System.Text.RegularExpressions.Group
                this_param)
                {
                    var return_v = this_param.Success;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 109690, 109699);
                    return return_v;
                }


                bool
                f_1664_109816_109853(string
                s, out int
                result)
                {
                    var return_v = Int32.TryParse(s, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 109816, 109853);
                    return return_v;
                }


                string
                f_1664_109906_109918(System.Text.RegularExpressions.Group
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 109906, 109918);
                    return return_v;
                }


                int
                f_1664_109892_109919(System.Collections.Hashtable
                this_param, int
                key, string
                value)
                {
                    this_param.Add((object)key, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 109892, 109919);
                    return 0;
                }


                string
                f_1664_110013_110025(System.Text.RegularExpressions.Group
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 110013, 110025);
                    return return_v;
                }


                int
                f_1664_109996_110026(System.Collections.Hashtable
                this_param, string
                key, string
                value)
                {
                    this_param.Add((object)key, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 109996, 110026);
                    return 0;
                }


                string[]
                f_1664_109549_109570_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 109549, 109570);
                    return return_v;
                }


                int
                f_1664_110113_110168(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.VariablePath
                path, System.Collections.Hashtable
                newValue)
                {
                    this_param.SetVariable(path, (object)newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 110113, 110168);
                    return 0;
                }


                bool
                f_1664_110238_110247(System.Text.RegularExpressions.Match
                this_param)
                {
                    var return_v = this_param.Success;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 110238, 110247);
                    return return_v;
                }


                string
                f_1664_110408_110451(System.Management.Automation.ExecutionContext
                context, object
                obj)
                {
                    var return_v = PSObject.ToStringParser(context, obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 110408, 110451);
                    return return_v;
                }


                string
                f_1664_110634_110672()
                {
                    var return_v = ParserStrings.InvalidRegularExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 110634, 110672);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1664_110476_110686(string
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, System.ArgumentException
                innerException, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterExceptionWithInnerException((object)targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, (System.Exception)innerException, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 110476, 110686);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 107537, 110713);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 107537, 110713);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string ResolveFilePath(IScriptExtent errorExtent, object obj, ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 110725, 113522);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 110889, 110921);

                    FileInfo
                    file = obj as FileInfo
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 110939, 111026);

                    string
                    filePath = (DynAbs.Tracing.TraceSender.Conditional_F1(1664, 110957, 110969) || ((file != null && DynAbs.Tracing.TraceSender.Conditional_F2(1664, 110972, 110985)) || DynAbs.Tracing.TraceSender.Conditional_F3(1664, 110988, 111025))) ? f_1664_110972_110985(file) : f_1664_110988_111025(context, obj)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 111046, 111324) || true) && (f_1664_111050_111080(filePath))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 111046, 111324);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 111122, 111305);

                        throw f_1664_111128_111304(filePath, typeof(RuntimeException), errorExtent, "InvalidFilenameOption", f_1664_111268_111303());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 111046, 111324);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 111344, 111366);

                    ProviderInfo
                    provider
                    = default(ProviderInfo);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 111384, 111457);

                    SessionState
                    sessionState = f_1664_111412_111456(f_1664_111429_111455(context))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 111477, 111605);

                    Collection<string>
                    filePaths =
                    f_1664_111529_111604(f_1664_111529_111546(sessionState), filePath, out provider)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 111731, 112219) || true) && (!f_1664_111736_111789(provider, f_1664_111756_111788(f_1664_111756_111777(context))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 111731, 112219);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 111903, 112200);

                        throw f_1664_111909_112199(filePath, typeof(RuntimeException), errorExtent, "FileOpenError", f_1664_112084_112111(), f_1664_112181_112198(provider));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 111731, 112219);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 112300, 112686) || true) && (filePaths == null || (DynAbs.Tracing.TraceSender.Expression_False(1664, 112304, 112344) || f_1664_112325_112340(filePaths) < 1))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 112300, 112686);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 112449, 112667);

                        throw f_1664_112455_112666(filePath, typeof(RuntimeException), errorExtent, "FileNotFound", f_1664_112629_112655(), filePath);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 112300, 112686);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 112706, 113105) || true) && (f_1664_112710_112725(filePaths) > 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 112706, 113105);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 112875, 113086);

                        throw f_1664_112881_113085(filePaths, typeof(RuntimeException), errorExtent, "AmbiguousPath", f_1664_113057_113084());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 112706, 113105);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 113125, 113145);

                    return f_1664_113132_113144(filePaths, 0);
                }
                catch (RuntimeException rte)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1664, 113174, 113511);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 113298, 113472) || true) && (f_1664_113302_113317(rte) != null && (DynAbs.Tracing.TraceSender.Expression_True(1664, 113302, 113367) && f_1664_113329_113359(f_1664_113329_113344(rte)) == null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 113298, 113472);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 113390, 113472);

                        f_1664_113390_113471(f_1664_113390_113405(rte), f_1664_113424_113470(null, errorExtent, context));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 113298, 113472);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 113490, 113496);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1664, 113174, 113511);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 110725, 113522);

                string
                f_1664_110972_110985(System.IO.FileInfo
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 110972, 110985);
                    return return_v;
                }


                string
                f_1664_110988_111025(System.Management.Automation.ExecutionContext
                context, object
                obj)
                {
                    var return_v = PSObject.ToStringParser(context, obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 110988, 111025);
                    return return_v;
                }


                bool
                f_1664_111050_111080(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 111050, 111080);
                    return return_v;
                }


                string
                f_1664_111268_111303()
                {
                    var return_v = ParserStrings.InvalidFilenameOption;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 111268, 111303);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1664_111128_111304(string
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException((object)targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 111128, 111304);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1664_111429_111455(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 111429, 111455);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1664_111412_111456(System.Management.Automation.SessionStateInternal
                sessionState)
                {
                    var return_v = new System.Management.Automation.SessionState(sessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 111412, 111456);
                    return return_v;
                }


                System.Management.Automation.PathIntrinsics
                f_1664_111529_111546(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 111529, 111546);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1664_111529_111604(System.Management.Automation.PathIntrinsics
                this_param, string
                path, out System.Management.Automation.ProviderInfo
                provider)
                {
                    var return_v = this_param.GetResolvedProviderPathFromPSPath(path, out provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 111529, 111604);
                    return return_v;
                }


                System.Management.Automation.ProviderNames
                f_1664_111756_111777(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ProviderNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 111756, 111777);
                    return return_v;
                }


                string
                f_1664_111756_111788(System.Management.Automation.ProviderNames
                this_param)
                {
                    var return_v = this_param.FileSystem;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 111756, 111788);
                    return return_v;
                }


                bool
                f_1664_111736_111789(System.Management.Automation.ProviderInfo
                this_param, string
                providerName)
                {
                    var return_v = this_param.NameEquals(providerName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 111736, 111789);
                    return return_v;
                }


                string
                f_1664_112084_112111()
                {
                    var return_v = ParserStrings.FileOpenError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 112084, 112111);
                    return return_v;
                }


                string
                f_1664_112181_112198(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 112181, 112198);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1664_111909_112199(string
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException((object)targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 111909, 112199);
                    return return_v;
                }


                int
                f_1664_112325_112340(System.Collections.ObjectModel.Collection<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 112325, 112340);
                    return return_v;
                }


                string
                f_1664_112629_112655()
                {
                    var return_v = ParserStrings.FileNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 112629, 112655);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1664_112455_112666(string
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException((object)targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 112455, 112666);
                    return return_v;
                }


                int
                f_1664_112710_112725(System.Collections.ObjectModel.Collection<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 112710, 112725);
                    return return_v;
                }


                string
                f_1664_113057_113084()
                {
                    var return_v = ParserStrings.AmbiguousPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 113057, 113084);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1664_112881_113085(System.Collections.ObjectModel.Collection<string>
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException((object)targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 112881, 113085);
                    return return_v;
                }


                string
                f_1664_113132_113144(System.Collections.ObjectModel.Collection<string>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 113132, 113144);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1664_113302_113317(System.Management.Automation.RuntimeException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 113302, 113317);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1664_113329_113344(System.Management.Automation.RuntimeException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 113329, 113344);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1664_113329_113359(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 113329, 113359);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1664_113390_113405(System.Management.Automation.RuntimeException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 113390, 113405);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1664_113424_113470(System.Management.Automation.CommandInfo
                commandInfo, System.Management.Automation.Language.IScriptExtent
                scriptPosition, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new System.Management.Automation.InvocationInfo(commandInfo, scriptPosition, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 113424, 113470);
                    return return_v;
                }


                int
                f_1664_113390_113471(System.Management.Automation.ErrorRecord
                this_param, System.Management.Automation.InvocationInfo
                invocationInfo)
                {
                    this_param.SetInvocationInfo(invocationInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 113390, 113471);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 110725, 113522);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 110725, 113522);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SwitchOps()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1664, 106204, 113529);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1664, 106204, 113529);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 106204, 113529);
        }

    }

    /// <summary>
    /// Controls the matching behaviour of the Where() operator.
    /// </summary>
    public enum WhereOperatorSelectionMode
    {
        /// <summary>
        /// Return all matches.
        /// </summary>
        Default = 0,
        /// <summary>
        /// Stop processing after the first match.
        /// </summary>
        First = 1,
        /// <summary>
        /// Return the last matching element.
        /// </summary>
        Last = 2,       // return last match
        /// <summary>
        /// Skip until the condition is true, then return the rest.
        /// </summary>
        SkipUntil = 3,
        /// <summary>
        /// Return elements until the condition is true then skip the rest.
        /// </summary>
        Until = 4,
        /// <summary>
        /// Return an array of two elements, first index is matched elements, second index is the remaining elements.
        /// </summary>
        Split = 5,
    }
    internal static class EnumerableOps
    {
        internal static object Where(IEnumerator enumerator, ScriptBlock expressionSB, WhereOperatorSelectionMode selectionMode, int numberToReturn)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 115365, 124528);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 115530, 115656);

                f_1664_115530_115655(enumerator != null, "The Where() operator should never receive a null enumerator value from the runtime.");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 115672, 115866) || true) && (numberToReturn < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 115672, 115866);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 115728, 115851);

                    throw f_1664_115734_115850("numberToReturn", numberToReturn, f_1664_115800_115849());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 115672, 115866);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 115882, 115938);

                var
                context = f_1664_115896_115937(f_1664_115896_115920())
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 116154, 119406) || true) && (expressionSB == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 116154, 119406);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 116212, 116418) || true) && (selectionMode == WhereOperatorSelectionMode.Default)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 116212, 116418);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 116309, 116399);

                        throw f_1664_116315_116398(f_1664_116345_116397());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 116212, 116418);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 116438, 116468);

                    var
                    rest = f_1664_116449_116467()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 116486, 116508);

                    object
                    current = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 116528, 116542);

                    int
                    index = 0
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 116560, 116663) || true) && (numberToReturn == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 116560, 116663);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 116625, 116644);

                        numberToReturn = 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 116560, 116663);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 116749, 117214) || true) && (selectionMode == WhereOperatorSelectionMode.SkipUntil)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 116749, 117214);
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 116848, 116988) || true) && (index < numberToReturn && (DynAbs.Tracing.TraceSender.Expression_True(1664, 116855, 116907) && f_1664_116881_116907(null, enumerator)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 116848, 116988);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 116957, 116965);

                                index++;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 116848, 116988);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 116848, 116988);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 116848, 116988);
                        }
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 117010, 117149) || true) && (f_1664_117017_117046(context, enumerator))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 117010, 117149);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 117096, 117126);

                                f_1664_117096_117125(rest, f_1664_117105_117124(enumerator));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 117010, 117149);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 117010, 117149);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 117010, 117149);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 117173, 117195);

                        return f_1664_117180_117194(rest);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 116749, 117214);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 117281, 118057) || true) && (selectionMode == WhereOperatorSelectionMode.Last)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 117281, 118057);
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 117375, 117840) || true) && (f_1664_117382_117411(context, enumerator))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 117375, 117840);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 117461, 117491);

                                current = f_1664_117471_117490(enumerator);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 117517, 117817) || true) && (numberToReturn > 1)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 117517, 117817);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 117597, 117615);

                                    f_1664_117597_117614(rest, current);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 117645, 117790) || true) && (f_1664_117649_117659(rest) > numberToReturn)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 117645, 117790);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 117742, 117759);

                                        f_1664_117742_117758(rest, 0);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 117645, 117790);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 117517, 117817);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 117375, 117840);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 117375, 117840);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 117375, 117840);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 117864, 117992) || true) && (numberToReturn == 1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 117864, 117992);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 117937, 117969);

                            return new object[] { current };
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 117864, 117992);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 118016, 118038);

                        return f_1664_118023_118037(rest);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 117281, 118057);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 118077, 118121);

                    object[]
                    first = new object[numberToReturn]
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 118139, 118815) || true) && (f_1664_118146_118175(context, enumerator))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 118139, 118815);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 118217, 118247);

                            current = f_1664_118227_118246(enumerator);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 118269, 118294);

                            first[index++] = current;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 118316, 118796) || true) && (index >= numberToReturn)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 118316, 118796);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 118449, 118773) || true) && (selectionMode == WhereOperatorSelectionMode.First || (DynAbs.Tracing.TraceSender.Expression_False(1664, 118453, 118555) || selectionMode == WhereOperatorSelectionMode.Until))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 118449, 118773);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 118613, 118626);

                                    return first;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 118449, 118773);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 118449, 118773);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1664, 118740, 118746);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 118449, 118773);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 118316, 118796);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 118139, 118815);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 118139, 118815);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 118139, 118815);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 118999, 119358) || true) && (selectionMode == WhereOperatorSelectionMode.Split)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 118999, 119358);
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 119094, 119269) || true) && (f_1664_119101_119130(context, enumerator))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 119094, 119269);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 119180, 119208);

                                var
                                e = f_1664_119188_119207(enumerator)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 119234, 119246);

                                f_1664_119234_119245(rest, e);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 119094, 119269);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 119094, 119269);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 119094, 119269);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 119293, 119339);

                        return new object[] { first, f_1664_119322_119336(rest) };
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 118999, 119358);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 119378, 119391);

                    return first;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 116154, 119406);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 119422, 119480);

                Collection<PSObject>
                matches = f_1664_119453_119479()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 119494, 119533);

                Collection<PSObject>
                notMatched = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 119547, 119689) || true) && (selectionMode == WhereOperatorSelectionMode.Split)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 119547, 119689);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 119634, 119674);

                    notMatched = f_1664_119647_119673();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 119547, 119689);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 119705, 119747);

                var
                resultCollection = f_1664_119728_119746()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 119761, 119806);

                Pipe
                outputPipe = f_1664_119779_119805(resultCollection)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 119820, 119847);

                bool
                returnTheRest = false
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 119863, 123771) || true) && (f_1664_119870_119899(context, enumerator))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 119863, 123771);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 119933, 119962);

                        var
                        ie = f_1664_119942_119961(enumerator)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 119982, 120382) || true) && (returnTheRest)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 119982, 120382);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 120041, 120098);

                            f_1664_120041_120097(matches, (DynAbs.Tracing.TraceSender.Conditional_F1(1664, 120053, 120063) || ((ie == null && DynAbs.Tracing.TraceSender.Conditional_F2(1664, 120066, 120070)) || DynAbs.Tracing.TraceSender.Conditional_F3(1664, 120073, 120096))) ? null : f_1664_120073_120096(ie));

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 120120, 120363) || true) && (numberToReturn > 0 && (DynAbs.Tracing.TraceSender.Expression_True(1664, 120124, 120177) && f_1664_120146_120159(matches) >= numberToReturn))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 120120, 120363);
                                DynAbs.Tracing.TraceSender.TraceBreak(1664, 120227, 120233);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 120120, 120363);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 120120, 120363);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 120331, 120340);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 120120, 120363);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 119982, 120382);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 120402, 120427);

                        f_1664_120402_120426(
                                        resultCollection);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 120445, 120621);

                        f_1664_120445_120620(expressionSB, false, null, null, ScriptBlock.ErrorHandlingBehavior.WriteToCurrentErrorPipe, ie, f_1664_120559_120579(), f_1664_120581_120601(), outputPipe, null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 120639, 120705);

                        bool
                        elementMatched = f_1664_120661_120704(resultCollection)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 120725, 123756) || true) && (elementMatched)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 120725, 123756);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 120785, 122411) || true) && (selectionMode == WhereOperatorSelectionMode.Until)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 120785, 122411);
                                DynAbs.Tracing.TraceSender.TraceBreak(1664, 120888, 120894);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 120785, 122411);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 120785, 122411);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 120944, 122411) || true) && (selectionMode == WhereOperatorSelectionMode.Last)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 120944, 122411);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 121046, 121173) || true) && (numberToReturn == 0)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 121046, 121173);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 121127, 121146);

                                        numberToReturn = 1;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 121046, 121173);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 121201, 121972) || true) && (f_1664_121205_121218(matches) < numberToReturn)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 121201, 121972);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 121293, 121350);

                                        f_1664_121293_121349(matches, (DynAbs.Tracing.TraceSender.Conditional_F1(1664, 121305, 121315) || ((ie == null && DynAbs.Tracing.TraceSender.Conditional_F2(1664, 121318, 121322)) || DynAbs.Tracing.TraceSender.Conditional_F3(1664, 121325, 121348))) ? null : f_1664_121325_121348(ie));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 121201, 121972);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 121201, 121972);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 121464, 121945) || true) && (numberToReturn == 1)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 121464, 121945);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 121553, 121610);

                                            matches[0] = (DynAbs.Tracing.TraceSender.Conditional_F1(1664, 121566, 121576) || ((ie == null && DynAbs.Tracing.TraceSender.Conditional_F2(1664, 121579, 121583)) || DynAbs.Tracing.TraceSender.Conditional_F3(1664, 121586, 121609))) ? null : f_1664_121586_121609(ie);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 121464, 121945);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 121464, 121945);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 121803, 121823);

                                            f_1664_121803_121822(                                // Maintains a sliding window
                                                                            matches, 0);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 121857, 121914);

                                            f_1664_121857_121913(matches, (DynAbs.Tracing.TraceSender.Conditional_F1(1664, 121869, 121879) || ((ie == null && DynAbs.Tracing.TraceSender.Conditional_F2(1664, 121882, 121886)) || DynAbs.Tracing.TraceSender.Conditional_F3(1664, 121889, 121912))) ? null : f_1664_121889_121912(ie));
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 121464, 121945);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 121201, 121972);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 120944, 122411);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 120944, 122411);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 122022, 122411) || true) && (selectionMode == WhereOperatorSelectionMode.SkipUntil)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 122022, 122411);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 122129, 122186);

                                        f_1664_122129_122185(matches, (DynAbs.Tracing.TraceSender.Conditional_F1(1664, 122141, 122151) || ((ie == null && DynAbs.Tracing.TraceSender.Conditional_F2(1664, 122154, 122158)) || DynAbs.Tracing.TraceSender.Conditional_F3(1664, 122161, 122184))) ? null : f_1664_122161_122184(ie));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 122212, 122233);

                                        returnTheRest = true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 122022, 122411);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 122022, 122411);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 122331, 122388);

                                        f_1664_122331_122387(matches, (DynAbs.Tracing.TraceSender.Conditional_F1(1664, 122343, 122353) || ((ie == null && DynAbs.Tracing.TraceSender.Conditional_F2(1664, 122356, 122360)) || DynAbs.Tracing.TraceSender.Conditional_F3(1664, 122363, 122386))) ? null : f_1664_122363_122386(ie));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 122022, 122411);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 120944, 122411);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 120785, 122411);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 122435, 123001) || true) && (selectionMode != WhereOperatorSelectionMode.Last)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 122435, 123001);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 122537, 122704) || true) && (numberToReturn == 0 && (DynAbs.Tracing.TraceSender.Expression_True(1664, 122541, 122613) && selectionMode == WhereOperatorSelectionMode.First))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 122537, 122704);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1664, 122671, 122677);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 122537, 122704);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 122829, 122978) || true) && (numberToReturn != 0 && (DynAbs.Tracing.TraceSender.Expression_True(1664, 122833, 122887) && numberToReturn == f_1664_122874_122887(matches)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 122829, 122978);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1664, 122945, 122951);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 122829, 122978);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 122435, 123001);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 120725, 123756);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 120725, 123756);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 123043, 123756) || true) && (selectionMode == WhereOperatorSelectionMode.Until)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 123043, 123756);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 123237, 123294);

                                f_1664_123237_123293(                    // no match so in the until case, we add the value until the count is reached
                                                    matches, (DynAbs.Tracing.TraceSender.Conditional_F1(1664, 123249, 123259) || ((ie == null && DynAbs.Tracing.TraceSender.Conditional_F2(1664, 123262, 123266)) || DynAbs.Tracing.TraceSender.Conditional_F3(1664, 123269, 123292))) ? null : f_1664_123269_123292(ie));

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 123316, 123452) || true) && (numberToReturn > 0 && (DynAbs.Tracing.TraceSender.Expression_True(1664, 123320, 123373) && f_1664_123342_123355(matches) >= numberToReturn))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 123316, 123452);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1664, 123423, 123429);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 123316, 123452);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 123043, 123756);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 123043, 123756);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 123494, 123756) || true) && (selectionMode == WhereOperatorSelectionMode.Split)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 123494, 123756);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 123677, 123737);

                                    f_1664_123677_123736(                    // If in split mode, record both matched and noteMatched elements.
                                                        notMatched, (DynAbs.Tracing.TraceSender.Conditional_F1(1664, 123692, 123702) || ((ie == null && DynAbs.Tracing.TraceSender.Conditional_F2(1664, 123705, 123709)) || DynAbs.Tracing.TraceSender.Conditional_F3(1664, 123712, 123735))) ? null : f_1664_123712_123735(ie));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 123494, 123756);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 123043, 123756);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 120725, 123756);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 119863, 123771);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 119863, 123771);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 119863, 123771);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 123855, 124486) || true) && (selectionMode == WhereOperatorSelectionMode.Split)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 123855, 124486);
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 124199, 124407) || true) && (f_1664_124206_124235(context, enumerator))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 124199, 124407);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 124277, 124306);

                            var
                            ie = f_1664_124286_124305(enumerator)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 124328, 124388);

                            f_1664_124328_124387(notMatched, (DynAbs.Tracing.TraceSender.Conditional_F1(1664, 124343, 124353) || ((ie == null && DynAbs.Tracing.TraceSender.Conditional_F2(1664, 124356, 124360)) || DynAbs.Tracing.TraceSender.Conditional_F3(1664, 124363, 124386))) ? null : f_1664_124363_124386(ie));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 124199, 124407);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 124199, 124407);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 124199, 124407);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 124427, 124471);

                    return new object[] { matches, notMatched };
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 123855, 124486);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 124502, 124517);

                return matches;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 115365, 124528);

                int
                f_1664_115530_115655(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 115530, 115655);
                    return 0;
                }


                string
                f_1664_115800_115849()
                {
                    var return_v = ParserStrings.NumberToReturnMustBeGreaterThanZero;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 115800, 115849);
                    return return_v;
                }


                System.ArgumentOutOfRangeException
                f_1664_115734_115850(string
                paramName, int
                actualValue, string
                message)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName, (object)actualValue, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 115734, 115850);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1664_115896_115920()
                {
                    var return_v = Runspace.DefaultRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 115896, 115920);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1664_115896_115937(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 115896, 115937);
                    return return_v;
                }


                string
                f_1664_116345_116397()
                {
                    var return_v = ParserStrings.EmptyExpressionRequiresANonDefaultMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 116345, 116397);
                    return return_v;
                }


                System.InvalidOperationException
                f_1664_116315_116398(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 116315, 116398);
                    return return_v;
                }


                System.Collections.Generic.List<object>
                f_1664_116449_116467()
                {
                    var return_v = new System.Collections.Generic.List<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 116449, 116467);
                    return return_v;
                }


                bool
                f_1664_116881_116907(System.Management.Automation.ExecutionContext
                context, System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = MoveNext(context, enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 116881, 116907);
                    return return_v;
                }


                bool
                f_1664_117017_117046(System.Management.Automation.ExecutionContext
                context, System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = MoveNext(context, enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 117017, 117046);
                    return return_v;
                }


                object
                f_1664_117105_117124(System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = Current(enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 117105, 117124);
                    return return_v;
                }


                int
                f_1664_117096_117125(System.Collections.Generic.List<object>
                this_param, object
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 117096, 117125);
                    return 0;
                }


                object[]
                f_1664_117180_117194(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 117180, 117194);
                    return return_v;
                }


                bool
                f_1664_117382_117411(System.Management.Automation.ExecutionContext
                context, System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = MoveNext(context, enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 117382, 117411);
                    return return_v;
                }


                object
                f_1664_117471_117490(System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = Current(enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 117471, 117490);
                    return return_v;
                }


                int
                f_1664_117597_117614(System.Collections.Generic.List<object>
                this_param, object
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 117597, 117614);
                    return 0;
                }


                int
                f_1664_117649_117659(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 117649, 117659);
                    return return_v;
                }


                int
                f_1664_117742_117758(System.Collections.Generic.List<object>
                this_param, int
                index)
                {
                    this_param.RemoveAt(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 117742, 117758);
                    return 0;
                }


                object[]
                f_1664_118023_118037(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 118023, 118037);
                    return return_v;
                }


                bool
                f_1664_118146_118175(System.Management.Automation.ExecutionContext
                context, System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = MoveNext(context, enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 118146, 118175);
                    return return_v;
                }


                object
                f_1664_118227_118246(System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = Current(enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 118227, 118246);
                    return return_v;
                }


                bool
                f_1664_119101_119130(System.Management.Automation.ExecutionContext
                context, System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = MoveNext(context, enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 119101, 119130);
                    return return_v;
                }


                object
                f_1664_119188_119207(System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = Current(enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 119188, 119207);
                    return return_v;
                }


                int
                f_1664_119234_119245(System.Collections.Generic.List<object>
                this_param, object
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 119234, 119245);
                    return 0;
                }


                object[]
                f_1664_119322_119336(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 119322, 119336);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1664_119453_119479()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 119453, 119479);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1664_119647_119673()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 119647, 119673);
                    return return_v;
                }


                System.Collections.Generic.List<object>
                f_1664_119728_119746()
                {
                    var return_v = new System.Collections.Generic.List<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 119728, 119746);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1664_119779_119805(System.Collections.Generic.List<object>
                resultList)
                {
                    var return_v = new System.Management.Automation.Internal.Pipe(resultList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 119779, 119805);
                    return return_v;
                }


                bool
                f_1664_119870_119899(System.Management.Automation.ExecutionContext
                context, System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = MoveNext(context, enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 119870, 119899);
                    return return_v;
                }


                object
                f_1664_119942_119961(System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = Current(enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 119942, 119961);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1664_120073_120096(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 120073, 120096);
                    return return_v;
                }


                int
                f_1664_120041_120097(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                this_param, System.Management.Automation.PSObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 120041, 120097);
                    return 0;
                }


                int
                f_1664_120146_120159(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 120146, 120159);
                    return return_v;
                }


                int
                f_1664_120402_120426(System.Collections.Generic.List<object>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 120402, 120426);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1664_120559_120579()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 120559, 120579);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1664_120581_120601()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 120581, 120601);
                    return return_v;
                }


                int
                f_1664_120445_120620(System.Management.Automation.ScriptBlock
                this_param, bool
                createLocalScope, System.Collections.Generic.Dictionary<string, System.Management.Automation.ScriptBlock>
                functionsToDefine, System.Collections.Generic.List<System.Management.Automation.PSVariable>
                variablesToDefine, System.Management.Automation.ScriptBlock.ErrorHandlingBehavior
                errorHandlingBehavior, object
                dollarUnder, System.Management.Automation.PSObject
                input, System.Management.Automation.PSObject
                scriptThis, System.Management.Automation.Internal.Pipe
                outputPipe, System.Management.Automation.InvocationInfo
                invocationInfo, params object[]
                args)
                {
                    this_param.InvokeWithPipeImpl(createLocalScope, functionsToDefine, variablesToDefine, errorHandlingBehavior, dollarUnder, (object)input, (object)scriptThis, outputPipe, invocationInfo, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 120445, 120620);
                    return 0;
                }


                bool
                f_1664_120661_120704(System.Collections.Generic.List<object>
                objectArray)
                {
                    var return_v = LanguagePrimitives.IsTrue((System.Collections.IList)objectArray);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 120661, 120704);
                    return return_v;
                }


                int
                f_1664_121205_121218(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 121205, 121218);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1664_121325_121348(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 121325, 121348);
                    return return_v;
                }


                int
                f_1664_121293_121349(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                this_param, System.Management.Automation.PSObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 121293, 121349);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1664_121586_121609(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 121586, 121609);
                    return return_v;
                }


                int
                f_1664_121803_121822(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                this_param, int
                index)
                {
                    this_param.RemoveAt(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 121803, 121822);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1664_121889_121912(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 121889, 121912);
                    return return_v;
                }


                int
                f_1664_121857_121913(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                this_param, System.Management.Automation.PSObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 121857, 121913);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1664_122161_122184(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 122161, 122184);
                    return return_v;
                }


                int
                f_1664_122129_122185(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                this_param, System.Management.Automation.PSObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 122129, 122185);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1664_122363_122386(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 122363, 122386);
                    return return_v;
                }


                int
                f_1664_122331_122387(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                this_param, System.Management.Automation.PSObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 122331, 122387);
                    return 0;
                }


                int
                f_1664_122874_122887(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 122874, 122887);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1664_123269_123292(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 123269, 123292);
                    return return_v;
                }


                int
                f_1664_123237_123293(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                this_param, System.Management.Automation.PSObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 123237, 123293);
                    return 0;
                }


                int
                f_1664_123342_123355(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 123342, 123355);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1664_123712_123735(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 123712, 123735);
                    return return_v;
                }


                int
                f_1664_123677_123736(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                this_param, System.Management.Automation.PSObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 123677, 123736);
                    return 0;
                }


                bool
                f_1664_124206_124235(System.Management.Automation.ExecutionContext
                context, System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = MoveNext(context, enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 124206, 124235);
                    return return_v;
                }


                object
                f_1664_124286_124305(System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = Current(enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 124286, 124305);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1664_124363_124386(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 124363, 124386);
                    return return_v;
                }


                int
                f_1664_124328_124387(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                this_param, System.Management.Automation.PSObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 124328, 124387);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 115365, 124528);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 115365, 124528);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object ForEach(IEnumerator enumerator, object expression, object[] arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 124921, 137754);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 125039, 125167);

                f_1664_125039_125166(enumerator != null, "The ForEach() operator should never receive a null enumerator value from the runtime.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 125181, 125327);

                f_1664_125181_125326(arguments != null, "The ForEach() operator should never receive a null value for the 'arguments' parameter from the runtime.");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 125341, 125458) || true) && (expression == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 125341, 125458);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 125397, 125443);

                    throw f_1664_125403_125442("expression");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 125341, 125458);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 125474, 125530);

                var
                context = f_1664_125488_125529(f_1664_125488_125512())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 125868, 125905);

                Type
                targetType = expression as Type
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 125919, 129134) || true) && (targetType != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 125919, 129134);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 125975, 126007);

                    dynamic
                    resultCollection = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 126027, 128729) || true) && (f_1664_126031_126088(targetType, "System.Collections.ICollection") != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 126027, 128729);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 126355, 126821) || true) && (f_1664_126359_126377(targetType))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 126355, 126821);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 126427, 126457);

                            var
                            list = f_1664_126438_126456()
                            ;
                            try
                            {
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 126483, 126686) || true) && (f_1664_126490_126516(null, enumerator))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 126483, 126686);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 126574, 126611);

                                    object
                                    current = f_1664_126591_126610(enumerator)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 126641, 126659);

                                    f_1664_126641_126658(list, current);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 126483, 126686);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 126483, 126686);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 126483, 126686);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 126714, 126798);

                            return f_1664_126721_126797(list, targetType, f_1664_126768_126796());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 126355, 126821);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 126937, 127985) || true) && (f_1664_126941_126965(targetType))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 126937, 127985);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 127015, 127060);

                            Type[]
                            ta = f_1664_127027_127059(targetType)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 127086, 127460) || true) && (f_1664_127090_127099(ta) != 1)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 127086, 127460);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 127162, 127433);

                                throw f_1664_127168_127432(expression, typeof(RuntimeException), null, "ForEachBadGenericConversionTypeSpecified", f_1664_127330_127384(), f_1664_127386_127431(targetType, null));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 127086, 127460);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 127488, 127565);

                            resultCollection = f_1664_127507_127564(f_1664_127527_127563(targetType));
                            try
                            {
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 127591, 127962) || true) && (f_1664_127598_127627(context, enumerator))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 127591, 127962);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 127685, 127722);

                                    object
                                    current = f_1664_127702_127721(enumerator)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 127905, 127935);

                                    f_1664_127905_127934(                            // Let the PSObject method invocation mechanism take care of
                                                                                     // any required conversions, etc.
                                                                resultCollection, current);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 127591, 127962);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 127591, 127962);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 127591, 127962);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 126937, 127985);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 126027, 128729);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 126027, 128729);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 128153, 128230);

                        Type
                        resultCollectionType = f_1664_128181_128229(typeof(Collection<>), targetType)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 128252, 128339);

                        resultCollection = f_1664_128271_128338(f_1664_128291_128337(resultCollectionType));
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 128363, 128710) || true) && (f_1664_128370_128399(context, enumerator))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 128363, 128710);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 128449, 128486);

                                object
                                current = f_1664_128466_128485(enumerator)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 128657, 128687);

                                f_1664_128657_128686(                        // Let the PSObject method invocation mechanism take care of
                                                                             // any required conversions, etc.
                                                        resultCollection, current);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 128363, 128710);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 128363, 128710);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 128363, 128710);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 126027, 128729);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 128749, 129075) || true) && (resultCollection == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 128749, 129075);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 128819, 129056);

                        throw f_1664_128825_129055(expression, typeof(RuntimeException), null, "ForEachTypeConversionFailed", f_1664_128966_129007(), f_1664_129009_129054(targetType, null));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 128749, 129075);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 129095, 129119);

                    return resultCollection;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 125919, 129134);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 129282, 129322);

                var
                result = f_1664_129295_129321()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 129336, 129379);

                ScriptBlock
                sb = expression as ScriptBlock
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 129393, 137713) || true) && (sb != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 129393, 137713);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 129441, 129476);

                    Pipe
                    outputPipe = f_1664_129459_129475(result)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 129494, 129803) || true) && (f_1664_129498_129514(sb))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 129494, 129803);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 129556, 129784);

                        f_1664_129556_129783(sb, ScriptBlockClauseToInvoke.Begin, false, null, null, ScriptBlock.ErrorHandlingBehavior.WriteToCurrentErrorPipe, f_1664_129689_129709(), f_1664_129711_129731(), f_1664_129733_129753(), outputPipe, null, arguments);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 129494, 129803);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 129823, 129954);

                    ScriptBlockClauseToInvoke
                    processClause = (DynAbs.Tracing.TraceSender.Conditional_F1(1664, 129865, 129885) || (((f_1664_129866_129884(sb)) && DynAbs.Tracing.TraceSender.Conditional_F2(1664, 129888, 129921)) || DynAbs.Tracing.TraceSender.Conditional_F3(1664, 129924, 129953))) ? ScriptBlockClauseToInvoke.Process : ScriptBlockClauseToInvoke.End
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 129972, 129989);

                    object
                    ie = null
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 130007, 130446) || true) && (f_1664_130014_130043(context, enumerator))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 130007, 130446);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 130085, 130110);

                            ie = f_1664_130090_130109(enumerator);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 130132, 130427) || true) && (ie != f_1664_130142_130162())
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 130132, 130427);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 130212, 130404);

                                f_1664_130212_130403(sb, processClause, false, null, null, ScriptBlock.ErrorHandlingBehavior.WriteToCurrentErrorPipe, ie, f_1664_130331_130351(), f_1664_130353_130373(), outputPipe, null, arguments);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 130132, 130427);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 130007, 130446);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 130007, 130446);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 130007, 130446);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 130466, 130905) || true) && (processClause == ScriptBlockClauseToInvoke.Process && (DynAbs.Tracing.TraceSender.Expression_True(1664, 130470, 130538) && f_1664_130524_130538(sb)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 130466, 130905);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 130678, 130886);

                        f_1664_130678_130885(                    // $_ has the same value as it did in the last iteration of the process loop
                                            sb, ScriptBlockClauseToInvoke.End, false, null, null, ScriptBlock.ErrorHandlingBehavior.WriteToCurrentErrorPipe, ie, f_1664_130813_130833(), f_1664_130835_130855(), outputPipe, null, arguments);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 130466, 130905);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 129393, 137713);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 129393, 137713);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 131031, 131091);

                    string
                    name = f_1664_131045_131090(expression, null)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 131109, 131140);

                    var
                    numArgs = f_1664_131123_131139(arguments)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 131158, 131198);

                    var
                    languageMode = f_1664_131177_131197(context)
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 131218, 137698) || true) && (f_1664_131225_131254(context, enumerator))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 131218, 137698);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 131296, 131333);

                            object
                            current = f_1664_131313_131332(enumerator)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 131355, 131400);

                            object
                            basedCurrent = f_1664_131377_131399(current)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 131422, 131463);

                            Hashtable
                            ht = basedCurrent as Hashtable
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 131485, 137679) || true) && (ht != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 131485, 137679);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 131642, 132412);

                                switch (numArgs)
                                {

                                    case 0:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 131642, 132412);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 131812, 131838);

                                        object
                                        element = f_1664_131829_131837(ht, name)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 131872, 131938);

                                        f_1664_131872_131937(result, (DynAbs.Tracing.TraceSender.Conditional_F1(1664, 131883, 131898) || ((element != null && DynAbs.Tracing.TraceSender.Conditional_F2(1664, 131901, 131929)) || DynAbs.Tracing.TraceSender.Conditional_F3(1664, 131932, 131936))) ? f_1664_131901_131929(element) : null);
                                        DynAbs.Tracing.TraceSender.TraceBreak(1664, 131972, 131978);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 131642, 132412);

                                    case 1:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 131642, 132412);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 132113, 132137);

                                        ht[name] = arguments[0];
                                        DynAbs.Tracing.TraceSender.TraceBreak(1664, 132171, 132177);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 131642, 132412);

                                    default:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 131642, 132412);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 132324, 132345);

                                        ht[name] = arguments;
                                        DynAbs.Tracing.TraceSender.TraceBreak(1664, 132379, 132385);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 131642, 132412);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 131485, 137679);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 131485, 137679);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 132774, 133606) || true) && (current == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 132774, 133606);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 132851, 133538) || true) && (f_1664_132855_132871(arguments) == 0)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 132851, 133538);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 132942, 132959);

                                        f_1664_132942_132958(result, null);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 132851, 133538);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 132851, 133538);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 133089, 133141);

                                        var
                                        nullRefException = f_1664_133112_133140()
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 133175, 133507);

                                        throw f_1664_133181_133506(f_1664_133249_133280(f_1664_133249_133275(nullRefException)), nullRefException, f_1664_133374_133418(), name, f_1664_133463_133479(arguments), f_1664_133481_133505(nullRefException));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 132851, 133538);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 133570, 133579);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 132774, 133606);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 133634, 133672);

                                var
                                ie = f_1664_133643_133671(current)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 133698, 137656) || true) && (ie != f_1664_133708_133728())
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 133698, 137656);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 133786, 133825);

                                    PSMemberInfo
                                    member = f_1664_133808_133824(f_1664_133808_133818(ie), name)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 133941, 134984) || true) && (member == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 133941, 134984);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 134025, 134360) || true) && (f_1664_134029_134055(context, 2))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 134025, 134360);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 134129, 134325);

                                            throw f_1664_134135_134324(null, typeof(RuntimeException), null, "PropertyNotFoundStrict", f_1664_134281_134317(), name);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 134025, 134360);
                                        }

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 134396, 134953) || true) && (numArgs == 0)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 134396, 134953);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 134486, 134503);

                                            f_1664_134486_134502(result, null);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 134541, 134550);

                                            continue;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 134396, 134953);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 134396, 134953);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 134696, 134918);

                                            throw f_1664_134702_134917(ie, typeof(NullReferenceException), null, "ForEachNonexistentMemberReference", f_1664_134863_134910(), name);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 134396, 134953);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 133941, 134984);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 135016, 135052);

                                    var
                                    method = member as PSMethodInfo
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 135082, 137629) || true) && (method != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 135082, 137629);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 135352, 135767) || true) && (languageMode == PSLanguageMode.RestrictedLanguage)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 135352, 135767);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 135479, 135732);

                                            throw f_1664_135485_135731(current, typeof(PSInvalidOperationException), null, "NoMethodInvocationInRestrictedLanguageMode", f_1664_135665_135730());
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 135352, 135767);
                                        }

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 135912, 136487) || true) && (languageMode == PSLanguageMode.ConstrainedLanguage)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 135912, 136487);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 136040, 136452) || true) && (!f_1664_136045_136087(f_1664_136064_136086(basedCurrent)))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 136040, 136452);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 136169, 136413);

                                                throw f_1664_136175_136412(current, typeof(PSInvalidOperationException), null, "MethodInvocationNotSupportedInConstrainedLanguage", f_1664_136366_136411());
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 136040, 136452);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 135912, 136487);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 136523, 136581);

                                        f_1664_136523_136580(
                                                                        result, f_1664_136534_136579(f_1664_136554_136578(method, arguments)));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 135082, 137629);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 135082, 137629);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 136711, 136751);

                                        var
                                        property = member as PSPropertyInfo
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 136787, 137598);

                                        switch (numArgs)
                                        {

                                            case 0:
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 136787, 137598);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 136987, 137035);

                                                f_1664_136987_137034(                                        // No args: do a get
                                                                                        result, f_1664_136998_137033(f_1664_137018_137032(property)));
                                                DynAbs.Tracing.TraceSender.TraceBreak(1664, 137077, 137083);

                                                break;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 136787, 137598);

                                            case 1:
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 136787, 137598);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 137239, 137269);

                                                property.Value = arguments[0];
                                                DynAbs.Tracing.TraceSender.TraceBreak(1664, 137311, 137317);

                                                break;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 136787, 137598);

                                            default:
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 136787, 137598);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 137488, 137515);

                                                property.Value = arguments;
                                                DynAbs.Tracing.TraceSender.TraceBreak(1664, 137557, 137563);

                                                break;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 136787, 137598);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 135082, 137629);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 133698, 137656);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 131485, 137679);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 131218, 137698);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 131218, 137698);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 131218, 137698);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 129393, 137713);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 137729, 137743);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 124921, 137754);

                int
                f_1664_125039_125166(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 125039, 125166);
                    return 0;
                }


                int
                f_1664_125181_125326(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 125181, 125326);
                    return 0;
                }


                System.ArgumentNullException
                f_1664_125403_125442(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 125403, 125442);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1664_125488_125512()
                {
                    var return_v = Runspace.DefaultRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 125488, 125512);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1664_125488_125529(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 125488, 125529);
                    return return_v;
                }


                System.Type?
                f_1664_126031_126088(System.Type
                this_param, string
                name)
                {
                    var return_v = this_param.GetInterface(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 126031, 126088);
                    return return_v;
                }


                bool
                f_1664_126359_126377(System.Type
                this_param)
                {
                    var return_v = this_param.IsArray;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 126359, 126377);
                    return return_v;
                }


                System.Collections.Generic.List<object>
                f_1664_126438_126456()
                {
                    var return_v = new System.Collections.Generic.List<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 126438, 126456);
                    return return_v;
                }


                bool
                f_1664_126490_126516(System.Management.Automation.ExecutionContext
                context, System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = MoveNext(context, enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 126490, 126516);
                    return return_v;
                }


                object
                f_1664_126591_126610(System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = Current(enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 126591, 126610);
                    return return_v;
                }


                int
                f_1664_126641_126658(System.Collections.Generic.List<object>
                this_param, object
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 126641, 126658);
                    return 0;
                }


                System.Globalization.CultureInfo
                f_1664_126768_126796()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 126768, 126796);
                    return return_v;
                }


                object
                f_1664_126721_126797(System.Collections.Generic.List<object>
                valueToConvert, System.Type
                resultType, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = LanguagePrimitives.ConvertTo((object)valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 126721, 126797);
                    return return_v;
                }


                bool
                f_1664_126941_126965(System.Type
                this_param)
                {
                    var return_v = this_param.IsGenericType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 126941, 126965);
                    return return_v;
                }


                System.Type[]
                f_1664_127027_127059(System.Type
                this_param)
                {
                    var return_v = this_param.GetGenericArguments();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 127027, 127059);
                    return return_v;
                }


                int
                f_1664_127090_127099(System.Type[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 127090, 127099);
                    return return_v;
                }


                string
                f_1664_127330_127384()
                {
                    var return_v = ParserStrings.ForEachBadGenericConversionTypeSpecified;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 127330, 127384);
                    return return_v;
                }


                string
                f_1664_127386_127431(System.Type
                obj, System.Management.Automation.Language.IScriptExtent
                errorPosition)
                {
                    var return_v = ParserOps.ConvertTo<string>((object)obj, errorPosition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 127386, 127431);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1664_127168_127432(object
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException(targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 127168, 127432);
                    return return_v;
                }


                object?
                f_1664_127527_127563(System.Type
                type)
                {
                    var return_v = Activator.CreateInstance(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 127527, 127563);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1664_127507_127564(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 127507, 127564);
                    return return_v;
                }


                bool
                f_1664_127598_127627(System.Management.Automation.ExecutionContext
                context, System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = MoveNext(context, enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 127598, 127627);
                    return return_v;
                }


                object
                f_1664_127702_127721(System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = Current(enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 127702, 127721);
                    return return_v;
                }


                dynamic
                f_1664_127905_127934(dynamic
                this_param, object
                i0)
                {
                    var return_v = this_param.Add(i0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 127905, 127934);
                    return return_v;
                }


                System.Type
                f_1664_128181_128229(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 128181, 128229);
                    return return_v;
                }


                object?
                f_1664_128291_128337(System.Type
                type)
                {
                    var return_v = Activator.CreateInstance(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 128291, 128337);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1664_128271_128338(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 128271, 128338);
                    return return_v;
                }


                bool
                f_1664_128370_128399(System.Management.Automation.ExecutionContext
                context, System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = MoveNext(context, enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 128370, 128399);
                    return return_v;
                }


                object
                f_1664_128466_128485(System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = Current(enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 128466, 128485);
                    return return_v;
                }


                dynamic
                f_1664_128657_128686(dynamic
                this_param, object
                i0)
                {
                    var return_v = this_param.Add(i0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 128657, 128686);
                    return return_v;
                }


                string
                f_1664_128966_129007()
                {
                    var return_v = ParserStrings.ForEachTypeConversionFailed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 128966, 129007);
                    return return_v;
                }


                string
                f_1664_129009_129054(System.Type
                obj, System.Management.Automation.Language.IScriptExtent
                errorPosition)
                {
                    var return_v = ParserOps.ConvertTo<string>((object)obj, errorPosition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 129009, 129054);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1664_128825_129055(object
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException(targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 128825, 129055);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1664_129295_129321()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 129295, 129321);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1664_129459_129475(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                resultCollection)
                {
                    var return_v = new System.Management.Automation.Internal.Pipe(resultCollection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 129459, 129475);
                    return return_v;
                }


                bool
                f_1664_129498_129514(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.HasBeginBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 129498, 129514);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1664_129689_129709()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 129689, 129709);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1664_129711_129731()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 129711, 129731);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1664_129733_129753()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 129733, 129753);
                    return return_v;
                }


                int
                f_1664_129556_129783(System.Management.Automation.ScriptBlock
                this_param, System.Management.Automation.ScriptBlockClauseToInvoke
                clauseToInvoke, bool
                createLocalScope, System.Collections.Generic.Dictionary<string, System.Management.Automation.ScriptBlock>
                functionsToDefine, System.Collections.Generic.List<System.Management.Automation.PSVariable>
                variablesToDefine, System.Management.Automation.ScriptBlock.ErrorHandlingBehavior
                errorHandlingBehavior, System.Management.Automation.PSObject
                dollarUnder, System.Management.Automation.PSObject
                input, System.Management.Automation.PSObject
                scriptThis, System.Management.Automation.Internal.Pipe
                outputPipe, System.Management.Automation.InvocationInfo
                invocationInfo, params object[]
                args)
                {
                    this_param.InvokeWithPipeImpl(clauseToInvoke, createLocalScope, functionsToDefine, variablesToDefine, errorHandlingBehavior, (object)dollarUnder, (object)input, (object)scriptThis, outputPipe, invocationInfo, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 129556, 129783);
                    return 0;
                }


                bool
                f_1664_129866_129884(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.HasProcessBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 129866, 129884);
                    return return_v;
                }


                bool
                f_1664_130014_130043(System.Management.Automation.ExecutionContext
                context, System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = MoveNext(context, enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 130014, 130043);
                    return return_v;
                }


                object
                f_1664_130090_130109(System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = Current(enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 130090, 130109);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1664_130142_130162()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 130142, 130162);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1664_130331_130351()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 130331, 130351);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1664_130353_130373()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 130353, 130373);
                    return return_v;
                }


                int
                f_1664_130212_130403(System.Management.Automation.ScriptBlock
                this_param, System.Management.Automation.ScriptBlockClauseToInvoke
                clauseToInvoke, bool
                createLocalScope, System.Collections.Generic.Dictionary<string, System.Management.Automation.ScriptBlock>
                functionsToDefine, System.Collections.Generic.List<System.Management.Automation.PSVariable>
                variablesToDefine, System.Management.Automation.ScriptBlock.ErrorHandlingBehavior
                errorHandlingBehavior, object
                dollarUnder, System.Management.Automation.PSObject
                input, System.Management.Automation.PSObject
                scriptThis, System.Management.Automation.Internal.Pipe
                outputPipe, System.Management.Automation.InvocationInfo
                invocationInfo, params object[]
                args)
                {
                    this_param.InvokeWithPipeImpl(clauseToInvoke, createLocalScope, functionsToDefine, variablesToDefine, errorHandlingBehavior, dollarUnder, (object)input, (object)scriptThis, outputPipe, invocationInfo, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 130212, 130403);
                    return 0;
                }


                bool
                f_1664_130524_130538(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.HasEndBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 130524, 130538);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1664_130813_130833()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 130813, 130833);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1664_130835_130855()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 130835, 130855);
                    return return_v;
                }


                int
                f_1664_130678_130885(System.Management.Automation.ScriptBlock
                this_param, System.Management.Automation.ScriptBlockClauseToInvoke
                clauseToInvoke, bool
                createLocalScope, System.Collections.Generic.Dictionary<string, System.Management.Automation.ScriptBlock>
                functionsToDefine, System.Collections.Generic.List<System.Management.Automation.PSVariable>
                variablesToDefine, System.Management.Automation.ScriptBlock.ErrorHandlingBehavior
                errorHandlingBehavior, object
                dollarUnder, System.Management.Automation.PSObject
                input, System.Management.Automation.PSObject
                scriptThis, System.Management.Automation.Internal.Pipe
                outputPipe, System.Management.Automation.InvocationInfo
                invocationInfo, params object[]
                args)
                {
                    this_param.InvokeWithPipeImpl(clauseToInvoke, createLocalScope, functionsToDefine, variablesToDefine, errorHandlingBehavior, dollarUnder, (object)input, (object)scriptThis, outputPipe, invocationInfo, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 130678, 130885);
                    return 0;
                }


                string
                f_1664_131045_131090(object
                obj, System.Management.Automation.Language.IScriptExtent
                errorPosition)
                {
                    var return_v = ParserOps.ConvertTo<string>(obj, errorPosition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 131045, 131090);
                    return return_v;
                }


                int
                f_1664_131123_131139(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 131123, 131139);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1664_131177_131197(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 131177, 131197);
                    return return_v;
                }


                bool
                f_1664_131225_131254(System.Management.Automation.ExecutionContext
                context, System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = MoveNext(context, enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 131225, 131254);
                    return return_v;
                }


                object
                f_1664_131313_131332(System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = Current(enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 131313, 131332);
                    return return_v;
                }


                object
                f_1664_131377_131399(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 131377, 131399);
                    return return_v;
                }


                object
                f_1664_131829_131837(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 131829, 131837);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1664_131901_131929(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 131901, 131929);
                    return return_v;
                }


                int
                f_1664_131872_131937(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                this_param, System.Management.Automation.PSObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 131872, 131937);
                    return 0;
                }


                int
                f_1664_132855_132871(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 132855, 132871);
                    return return_v;
                }


                int
                f_1664_132942_132958(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                this_param, System.Management.Automation.PSObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 132942, 132958);
                    return 0;
                }


                System.NullReferenceException
                f_1664_133112_133140()
                {
                    var return_v = new System.NullReferenceException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 133112, 133140);
                    return return_v;
                }


                System.Type
                f_1664_133249_133275(System.NullReferenceException
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 133249, 133275);
                    return return_v;
                }


                string
                f_1664_133249_133280(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 133249, 133280);
                    return return_v;
                }


                string
                f_1664_133374_133418()
                {
                    var return_v = ExtendedTypeSystem.MethodInvocationException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 133374, 133418);
                    return return_v;
                }


                int
                f_1664_133463_133479(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 133463, 133479);
                    return return_v;
                }


                string
                f_1664_133481_133505(System.NullReferenceException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 133481, 133505);
                    return return_v;
                }


                System.Management.Automation.MethodInvocationException
                f_1664_133181_133506(string
                errorId, System.NullReferenceException
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.MethodInvocationException(errorId, (System.Exception)innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 133181, 133506);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1664_133643_133671(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 133643, 133671);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1664_133708_133728()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 133708, 133728);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                f_1664_133808_133818(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Members;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 133808, 133818);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfo
                f_1664_133808_133824(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 133808, 133824);
                    return return_v;
                }


                bool
                f_1664_134029_134055(System.Management.Automation.ExecutionContext
                this_param, int
                majorVersion)
                {
                    var return_v = this_param.IsStrictVersion(majorVersion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 134029, 134055);
                    return return_v;
                }


                string
                f_1664_134281_134317()
                {
                    var return_v = ParserStrings.PropertyNotFoundStrict;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 134281, 134317);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1664_134135_134324(object
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException(targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 134135, 134324);
                    return return_v;
                }


                int
                f_1664_134486_134502(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                this_param, System.Management.Automation.PSObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 134486, 134502);
                    return 0;
                }


                string
                f_1664_134863_134910()
                {
                    var return_v = ParserStrings.ForEachNonexistentMemberReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 134863, 134910);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1664_134702_134917(System.Management.Automation.PSObject
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException((object)targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 134702, 134917);
                    return return_v;
                }


                string
                f_1664_135665_135730()
                {
                    var return_v = InternalCommandStrings.NoMethodInvocationInRestrictedLanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 135665, 135730);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1664_135485_135731(object
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException(targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 135485, 135731);
                    return return_v;
                }


                System.Type
                f_1664_136064_136086(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 136064, 136086);
                    return return_v;
                }


                bool
                f_1664_136045_136087(System.Type
                inputType)
                {
                    var return_v = CoreTypes.Contains(inputType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 136045, 136087);
                    return return_v;
                }


                string
                f_1664_136366_136411()
                {
                    var return_v = ParserStrings.InvokeMethodConstrainedLanguage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 136366, 136411);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1664_136175_136412(object
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException(targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 136175, 136412);
                    return return_v;
                }


                object
                f_1664_136554_136578(System.Management.Automation.PSMethodInfo
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.Invoke(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 136554, 136578);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1664_136534_136579(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 136534, 136579);
                    return return_v;
                }


                int
                f_1664_136523_136580(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                this_param, System.Management.Automation.PSObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 136523, 136580);
                    return 0;
                }


                object
                f_1664_137018_137032(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 137018, 137032);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1664_136998_137033(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 136998, 137033);
                    return return_v;
                }


                int
                f_1664_136987_137034(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                this_param, System.Management.Automation.PSObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 136987, 137034);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 124921, 137754);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 124921, 137754);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object SlicingIndex(object target, IEnumerator indexes, Func<object, object, object> indexer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 137766, 138716);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 137900, 137962);

                var
                fakeEnumerator = indexes as NonEnumerableObjectEnumerator
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 137976, 138348) || true) && (fakeEnumerator != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 137976, 138348);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 138269, 138333);

                    return f_1664_138276_138332(indexer, target, f_1664_138292_138331(fakeEnumerator));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 137976, 138348);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 138364, 138396);

                var
                result = f_1664_138377_138395()
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 138410, 138665) || true) && (f_1664_138417_138440(null, indexes))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 138410, 138665);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 138474, 138520);

                        var
                        value = f_1664_138486_138519(indexer, target, f_1664_138502_138518(indexes))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 138538, 138650) || true) && (value != f_1664_138551_138571())
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 138538, 138650);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 138613, 138631);

                            f_1664_138613_138630(result, value);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 138538, 138650);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 138410, 138665);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 138410, 138665);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 138410, 138665);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 138681, 138705);

                return f_1664_138688_138704(result);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 137766, 138716);

                object
                f_1664_138292_138331(System.Management.Automation.EnumerableOps.NonEnumerableObjectEnumerator
                this_param)
                {
                    var return_v = this_param.GetNonEnumerableObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 138292, 138331);
                    return return_v;
                }


                object
                f_1664_138276_138332(System.Func<object, object, object>
                this_param, object
                arg1, object
                arg2)
                {
                    var return_v = this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 138276, 138332);
                    return return_v;
                }


                System.Collections.Generic.List<object>
                f_1664_138377_138395()
                {
                    var return_v = new System.Collections.Generic.List<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 138377, 138395);
                    return return_v;
                }


                bool
                f_1664_138417_138440(System.Management.Automation.ExecutionContext
                context, System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = MoveNext(context, enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 138417, 138440);
                    return return_v;
                }


                object
                f_1664_138502_138518(System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = Current(enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 138502, 138518);
                    return return_v;
                }


                object
                f_1664_138486_138519(System.Func<object, object, object>
                this_param, object
                arg1, object
                arg2)
                {
                    var return_v = this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 138486, 138519);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1664_138551_138571()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 138551, 138571);
                    return return_v;
                }


                int
                f_1664_138613_138630(System.Collections.Generic.List<object>
                this_param, object
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 138613, 138630);
                    return 0;
                }


                object[]
                f_1664_138688_138704(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 138688, 138704);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 137766, 138716);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 137766, 138716);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void FlattenResults(object o, List<object> result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 138728, 139261);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 138818, 138862);

                var
                e = f_1664_138826_138861(o)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 138876, 139250) || true) && (e != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 138876, 139250);
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 138923, 139155) || true) && (f_1664_138930_138942(e))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 138923, 139155);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 138984, 138998);

                            o = f_1664_138988_138997(e);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 139020, 139136) || true) && (o != f_1664_139029_139049())
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 139020, 139136);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 139099, 139113);

                                f_1664_139099_139112(result, o);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 139020, 139136);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 138923, 139155);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 138923, 139155);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 138923, 139155);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 138876, 139250);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 138876, 139250);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 139221, 139235);

                    f_1664_139221_139234(result, o);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 138876, 139250);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 138728, 139261);

                System.Collections.IEnumerator
                f_1664_138826_138861(object
                obj)
                {
                    var return_v = LanguagePrimitives.GetEnumerator(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 138826, 138861);
                    return return_v;
                }


                bool
                f_1664_138930_138942(System.Collections.IEnumerator
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 138930, 138942);
                    return return_v;
                }


                object
                f_1664_138988_138997(System.Collections.IEnumerator
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 138988, 138997);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1664_139029_139049()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 139029, 139049);
                    return return_v;
                }


                int
                f_1664_139099_139112(System.Collections.Generic.List<object>
                this_param, object
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 139099, 139112);
                    return 0;
                }


                int
                f_1664_139221_139234(System.Collections.Generic.List<object>
                this_param, object
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 139221, 139234);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 138728, 139261);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 138728, 139261);
            }
        }

        private static void PropertyGetterWorker(CallSite<Func<CallSite, object, object>> getMemberBinderSite,
                                                         IEnumerator enumerator,
                                                         ExecutionContext context,
                                                         List<object> result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 139273, 140473);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 139621, 139669);

                f_1664_139621_139668();
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 139683, 140462) || true) && (f_1664_139690_139719(context, enumerator))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 139683, 140462);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 139753, 139787);

                        var
                        current = f_1664_139767_139786(enumerator)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 139805, 139877);

                        // LAFHIS
                        //var o = f_1664_139813_139876(getMemberBinderSite.Target, getMemberBinderSite, current);
                        var o = getMemberBinderSite.Target.Invoke(getMemberBinderSite, current);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 139813, 139876);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 139895, 140447) || true) && (o != f_1664_139904_139924())
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 139895, 140447);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 139966, 139992);

                            f_1664_139966_139991(o, result);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 139895, 140447);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 139895, 140447);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 140163, 140228);

                            var
                            nestedEnumerator = f_1664_140186_140227(current)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 140250, 140428) || true) && (nestedEnumerator != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 140250, 140428);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 140328, 140405);

                                f_1664_140328_140404(getMemberBinderSite, nestedEnumerator, context, result);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 140250, 140428);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 139895, 140447);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 139683, 140462);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 139683, 140462);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 139683, 140462);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 139273, 140473);

                int
                f_1664_139621_139668()
                {
                    RuntimeHelpers.EnsureSufficientExecutionStack();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 139621, 139668);
                    return 0;
                }


                bool
                f_1664_139690_139719(System.Management.Automation.ExecutionContext
                context, System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = MoveNext(context, enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 139690, 139719);
                    return return_v;
                }


                object
                f_1664_139767_139786(System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = Current(enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 139767, 139786);
                    return return_v;
                }


                object
                f_1664_139813_139876(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, object>>
                this_param, System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, object>>
                arg1, object
                arg2)
                {
                    var return_v = this_param.Target((System.Runtime.CompilerServices.CallSite)arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 139813, 139876);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1664_139904_139924()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 139904, 139924);
                    return return_v;
                }


                int
                f_1664_139966_139991(object
                o, System.Collections.Generic.List<object>
                result)
                {
                    FlattenResults(o, result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 139966, 139991);
                    return 0;
                }


                System.Collections.IEnumerator
                f_1664_140186_140227(object
                obj)
                {
                    var return_v = LanguagePrimitives.GetEnumerator(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 140186, 140227);
                    return return_v;
                }


                int
                f_1664_140328_140404(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, object>>
                getMemberBinderSite, System.Collections.IEnumerator
                enumerator, System.Management.Automation.ExecutionContext
                context, System.Collections.Generic.List<object>
                result)
                {
                    PropertyGetterWorker(getMemberBinderSite, enumerator, context, result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 140328, 140404);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 139273, 140473);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 139273, 140473);
            }
        }

        internal static object PropertyGetter(PSGetMemberBinder binder, IEnumerator enumerator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 140485, 141433);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 140597, 140679);

                var
                getMemberBinderSite = f_1664_140623_140678(binder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 140693, 140725);

                var
                result = f_1664_140706_140724()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 140739, 140796);

                var
                context = f_1664_140753_140795()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 140812, 140883);

                f_1664_140812_140882(getMemberBinderSite, enumerator, context, result);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 140899, 140986) || true) && (f_1664_140903_140915(result) == 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 140899, 140986);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 140954, 140971);

                    return f_1664_140961_140970(result, 0);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 140899, 140986);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 141002, 141382) || true) && (f_1664_141006_141018(result) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 141002, 141382);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 141057, 141335) || true) && (f_1664_141061_141087(context, 2))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 141057, 141335);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 141129, 141316);

                        throw f_1664_141135_141315(null, typeof(RuntimeException), null, "PropertyNotFoundStrict", f_1664_141265_141301(), f_1664_141303_141314(binder));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 141057, 141335);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 141355, 141367);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 141002, 141382);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 141398, 141422);

                return f_1664_141405_141421(result);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 140485, 141433);

                System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, object>>
                f_1664_140623_140678(System.Management.Automation.Language.PSGetMemberBinder
                binder)
                {
                    var return_v = CallSite<Func<CallSite, object, object>>.Create((System.Runtime.CompilerServices.CallSiteBinder)binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 140623, 140678);
                    return return_v;
                }


                System.Collections.Generic.List<object>
                f_1664_140706_140724()
                {
                    var return_v = new System.Collections.Generic.List<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 140706, 140724);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1664_140753_140795()
                {
                    var return_v = LocalPipeline.GetExecutionContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 140753, 140795);
                    return return_v;
                }


                int
                f_1664_140812_140882(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, object>>
                getMemberBinderSite, System.Collections.IEnumerator
                enumerator, System.Management.Automation.ExecutionContext
                context, System.Collections.Generic.List<object>
                result)
                {
                    PropertyGetterWorker(getMemberBinderSite, enumerator, context, result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 140812, 140882);
                    return 0;
                }


                int
                f_1664_140903_140915(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 140903, 140915);
                    return return_v;
                }


                object
                f_1664_140961_140970(System.Collections.Generic.List<object>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 140961, 140970);
                    return return_v;
                }


                int
                f_1664_141006_141018(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 141006, 141018);
                    return return_v;
                }


                bool
                f_1664_141061_141087(System.Management.Automation.ExecutionContext
                this_param, int
                majorVersion)
                {
                    var return_v = this_param.IsStrictVersion(majorVersion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 141061, 141087);
                    return return_v;
                }


                string
                f_1664_141265_141301()
                {
                    var return_v = ParserStrings.PropertyNotFoundStrict;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 141265, 141301);
                    return return_v;
                }


                string
                f_1664_141303_141314(System.Management.Automation.Language.PSGetMemberBinder
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 141303, 141314);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1664_141135_141315(object
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException(targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 141135, 141315);
                    return return_v;
                }


                object[]
                f_1664_141405_141421(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 141405, 141421);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 140485, 141433);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 140485, 141433);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void MethodInvokerWorker(CallSite invokeMemberSite,
                                                        IEnumerator enumerator,
                                                        object[] args,
                                                        ExecutionContext context,
                                                        List<object> result,
                                                        ref bool foundMethod)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 141445, 144826);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 141889, 141937);

                f_1664_141889_141936();
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 141951, 144815) || true) && (f_1664_141958_141987(context, enumerator))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 141951, 144815);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 142021, 142055);

                        var
                        current = f_1664_142035_142054(enumerator)
                        ;

                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 142850, 142882);

                            dynamic
                            site = invokeMemberSite
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 142904, 143000);

                            object
                            o = f_1664_142915_142999(f_1664_142915_142926(site), f_1664_142941_142998(f_1664_142941_142988(f_1664_142941_142962(args, current), invokeMemberSite)))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 143391, 143410);

                            foundMethod = true;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 143516, 143644) || true) && (o != f_1664_143525_143545())
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 143516, 143644);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 143595, 143621);

                                f_1664_143595_143620(o, result);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 143516, 143644);
                            }
                        }
                        catch (TargetInvocationException tie)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1664, 143681, 144800);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 143908, 143970);

                            RuntimeException
                            rte = f_1664_143931_143949(tie) as RuntimeException
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 143992, 144526) || true) && (rte != null && (DynAbs.Tracing.TraceSender.Expression_True(1664, 143996, 144114) && f_1664_144011_144114(f_1664_144011_144048(f_1664_144011_144026(rte)), ParserOps.MethodNotFoundErrorId, StringComparison.Ordinal)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 143992, 144526);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 144164, 144229);

                                var
                                nestedEnumerator = f_1664_144187_144228(current)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 144255, 144503) || true) && (nestedEnumerator != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 144255, 144503);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 144341, 144437);

                                    f_1664_144341_144436(invokeMemberSite, nestedEnumerator, args, context, result, ref foundMethod);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 144467, 144476);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 144255, 144503);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 143992, 144526);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 144756, 144781);

                            throw f_1664_144762_144780(tie);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1664, 143681, 144800);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 141951, 144815);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 141951, 144815);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 141951, 144815);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 141445, 144826);

                int
                f_1664_141889_141936()
                {
                    RuntimeHelpers.EnsureSufficientExecutionStack();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 141889, 141936);
                    return 0;
                }


                bool
                f_1664_141958_141987(System.Management.Automation.ExecutionContext
                context, System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = MoveNext(context, enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 141958, 141987);
                    return return_v;
                }


                object
                f_1664_142035_142054(System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = Current(enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 142035, 142054);
                    return return_v;
                }


                dynamic
                f_1664_142915_142926(dynamic
                this_param)
                {
                    var return_v = this_param.Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 142915, 142926);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<object>
                f_1664_142941_142962(object[]
                collection, object
                element)
                {
                    var return_v = collection.Prepend<object>(element);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 142941, 142962);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<object>
                f_1664_142941_142988(System.Collections.Generic.IEnumerable<object>
                collection, System.Runtime.CompilerServices.CallSite
                element)
                {
                    var return_v = collection.Prepend<object>((object)element);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 142941, 142988);
                    return return_v;
                }


                object[]
                f_1664_142941_142998(System.Collections.Generic.IEnumerable<object>
                source)
                {
                    var return_v = source.ToArray<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 142941, 142998);
                    return return_v;
                }


                dynamic
                f_1664_142915_142999(dynamic
                this_param, object[]
                i0)
                {
                    var return_v = this_param.DynamicInvoke(i0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 142915, 142999);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1664_143525_143545()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 143525, 143545);
                    return return_v;
                }


                int
                f_1664_143595_143620(object
                o, System.Collections.Generic.List<object>
                result)
                {
                    FlattenResults(o, result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 143595, 143620);
                    return 0;
                }


                System.Exception
                f_1664_143931_143949(System.Reflection.TargetInvocationException
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 143931, 143949);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1664_144011_144026(System.Management.Automation.RuntimeException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 144011, 144026);
                    return return_v;
                }


                string
                f_1664_144011_144048(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.FullyQualifiedErrorId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 144011, 144048);
                    return return_v;
                }


                bool
                f_1664_144011_144114(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 144011, 144114);
                    return return_v;
                }


                System.Collections.IEnumerator
                f_1664_144187_144228(object
                obj)
                {
                    var return_v = LanguagePrimitives.GetEnumerator(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 144187, 144228);
                    return return_v;
                }


                int
                f_1664_144341_144436(System.Runtime.CompilerServices.CallSite
                invokeMemberSite, System.Collections.IEnumerator
                enumerator, object[]
                args, System.Management.Automation.ExecutionContext
                context, System.Collections.Generic.List<object>
                result, ref bool
                foundMethod)
                {
                    MethodInvokerWorker(invokeMemberSite, enumerator, args, context, result, ref foundMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 144341, 144436);
                    return 0;
                }


                System.Exception
                f_1664_144762_144780(System.Reflection.TargetInvocationException
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 144762, 144780);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 141445, 144826);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 141445, 144826);
            }
        }

        internal static object MethodInvoker(PSInvokeMemberBinder binder,
                                                     Type delegateType,
                                                     IEnumerator enumerator,
                                                     object[] args,
                                                     Type typeForMessage)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 145112, 146651);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 145465, 145526);

                var
                invokeMemberSite = f_1664_145488_145525(delegateType, binder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 145540, 145572);

                var
                result = f_1664_145553_145571()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 145586, 145643);

                var
                context = f_1664_145600_145642()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 145659, 145684);

                bool
                foundMethod = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 145698, 145788);

                f_1664_145698_145787(invokeMemberSite, enumerator, args, context, result, ref foundMethod);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 145804, 145891) || true) && (f_1664_145808_145820(result) == 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 145804, 145891);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 145859, 145876);

                    return f_1664_145866_145875(result, 0);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 145804, 145891);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 145907, 146425) || true) && (!foundMethod)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 145907, 146425);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 146032, 146410);

                    throw f_1664_146038_146409(null, typeof(RuntimeException), null, ParserOps.MethodNotFoundErrorId, f_1664_146278_146306(), f_1664_146308_146331(typeForMessage), f_1664_146397_146408(binder));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 145907, 146425);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 146441, 146600) || true) && (f_1664_146445_146457(result) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 146441, 146600);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 146557, 146585);

                    return f_1664_146564_146584();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 146441, 146600);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 146616, 146640);

                return f_1664_146623_146639(result);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 145112, 146651);

                System.Runtime.CompilerServices.CallSite
                f_1664_145488_145525(System.Type
                delegateType, System.Management.Automation.Language.PSInvokeMemberBinder
                binder)
                {
                    var return_v = CallSite.Create(delegateType, (System.Runtime.CompilerServices.CallSiteBinder)binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 145488, 145525);
                    return return_v;
                }


                System.Collections.Generic.List<object>
                f_1664_145553_145571()
                {
                    var return_v = new System.Collections.Generic.List<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 145553, 145571);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1664_145600_145642()
                {
                    var return_v = LocalPipeline.GetExecutionContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 145600, 145642);
                    return return_v;
                }


                int
                f_1664_145698_145787(System.Runtime.CompilerServices.CallSite
                invokeMemberSite, System.Collections.IEnumerator
                enumerator, object[]
                args, System.Management.Automation.ExecutionContext
                context, System.Collections.Generic.List<object>
                result, ref bool
                foundMethod)
                {
                    MethodInvokerWorker(invokeMemberSite, enumerator, args, context, result, ref foundMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 145698, 145787);
                    return 0;
                }


                int
                f_1664_145808_145820(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 145808, 145820);
                    return return_v;
                }


                object
                f_1664_145866_145875(System.Collections.Generic.List<object>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 145866, 145875);
                    return return_v;
                }


                string
                f_1664_146278_146306()
                {
                    var return_v = ParserStrings.MethodNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 146278, 146306);
                    return return_v;
                }


                string
                f_1664_146308_146331(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 146308, 146331);
                    return return_v;
                }


                string
                f_1664_146397_146408(System.Management.Automation.Language.PSInvokeMemberBinder
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 146397, 146408);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1664_146038_146409(object
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException(targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 146038, 146409);
                    return return_v;
                }


                int
                f_1664_146445_146457(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 146445, 146457);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1664_146564_146584()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 146564, 146584);
                    return return_v;
                }


                object[]
                f_1664_146623_146639(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 146623, 146639);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 145112, 146651);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 145112, 146651);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object Multiply(IEnumerator enumerator, uint times)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 146663, 147740);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 146755, 146820);

                var
                fakeEnumerator = enumerator as NonEnumerableObjectEnumerator
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 146834, 147299) || true) && (fakeEnumerator != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 146834, 147299);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 147092, 147284);

                    return f_1664_147099_147283(f_1664_147120_147159(fakeEnumerator), times, "op_Multiply", null, "*");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 146834, 147299);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 147315, 147353);

                var
                originalList = f_1664_147334_147352()
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 147367, 147487) || true) && (f_1664_147374_147400(null, enumerator))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 147367, 147487);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 147434, 147472);

                        f_1664_147434_147471(originalList, f_1664_147451_147470(enumerator));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 147367, 147487);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 147367, 147487);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 147367, 147487);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 147503, 147657) || true) && (f_1664_147507_147525(originalList) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 147503, 147657);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 147564, 147585);

                    return new object[0];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 147503, 147657);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 147673, 147729);

                return f_1664_147680_147728(f_1664_147698_147720(originalList), times);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 146663, 147740);

                object
                f_1664_147120_147159(System.Management.Automation.EnumerableOps.NonEnumerableObjectEnumerator
                this_param)
                {
                    var return_v = this_param.GetNonEnumerableObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 147120, 147159);
                    return return_v;
                }


                object
                f_1664_147099_147283(object
                lval, uint
                rval, string
                op, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                errorOp)
                {
                    var return_v = ParserOps.ImplicitOp(lval, (object)rval, op, errorPosition, errorOp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 147099, 147283);
                    return return_v;
                }


                System.Collections.Generic.List<object>
                f_1664_147334_147352()
                {
                    var return_v = new System.Collections.Generic.List<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 147334, 147352);
                    return return_v;
                }


                bool
                f_1664_147374_147400(System.Management.Automation.ExecutionContext
                context, System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = MoveNext(context, enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 147374, 147400);
                    return return_v;
                }


                object
                f_1664_147451_147470(System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = Current(enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 147451, 147470);
                    return return_v;
                }


                int
                f_1664_147434_147471(System.Collections.Generic.List<object>
                this_param, object
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 147434, 147471);
                    return 0;
                }


                int
                f_1664_147507_147525(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 147507, 147525);
                    return return_v;
                }


                object[]
                f_1664_147698_147720(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 147698, 147720);
                    return return_v;
                }


                object[]
                f_1664_147680_147728(object[]
                array, uint
                times)
                {
                    var return_v = ArrayOps.Multiply(array, times);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 147680, 147728);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 146663, 147740);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 146663, 147740);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static IEnumerator GetEnumerator(IEnumerable enumerable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 147752, 148372);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 147878, 147912);

                    return f_1664_147885_147911(enumerable);
                }
                catch (RuntimeException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1664, 147941, 148074);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 148053, 148059);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1664, 147941, 148074);
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1664, 148088, 148361);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 148140, 148346);

                    throw f_1664_148146_148345("ExceptionInGetEnumerator", e, f_1664_148273_148312(), f_1664_148335_148344(e));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1664, 148088, 148361);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 147752, 148372);

                System.Collections.IEnumerator
                f_1664_147885_147911(System.Collections.IEnumerable
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 147885, 147911);
                    return return_v;
                }


                string
                f_1664_148273_148312()
                {
                    var return_v = ExtendedTypeSystem.EnumerationException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 148273, 148312);
                    return return_v;
                }


                string
                f_1664_148335_148344(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 148335, 148344);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeSystemException
                f_1664_148146_148345(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeSystemException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 148146, 148345);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 147752, 148372);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 147752, 148372);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        internal class NonEnumerableObjectEnumerator : IEnumerator
        {
            internal static IEnumerator Create(object obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 149352, 149629);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 149431, 149614);

                    return new NonEnumerableObjectEnumerator
                    {
                        _obj = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => obj, 1664, 149438, 149613),
                        _realEnumerator = f_1664_149563_149594((new[] { obj }))
                    };
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 149352, 149629);

                    System.Collections.IEnumerator
                    f_1664_149563_149594(object[]
                    this_param)
                    {
                        var return_v = this_param.GetEnumerator();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 149563, 149594);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 149352, 149629);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 149352, 149629);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private object _obj;

            private IEnumerator _realEnumerator;

            bool IEnumerator.MoveNext()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1664, 149731, 149840);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 149791, 149825);

                    return f_1664_149798_149824(_realEnumerator);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1664, 149731, 149840);

                    bool
                    f_1664_149798_149824(System.Collections.IEnumerator
                    this_param)
                    {
                        var return_v = this_param.MoveNext();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 149798, 149824);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 149731, 149840);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 149731, 149840);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            void IEnumerator.Reset()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1664, 149856, 149952);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 149913, 149937);

                    f_1664_149913_149936(_realEnumerator);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1664, 149856, 149952);

                    int
                    f_1664_149913_149936(System.Collections.IEnumerator
                    this_param)
                    {
                        this_param.Reset();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 149913, 149936);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 149856, 149952);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 149856, 149952);
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1664, 150027, 150066);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 150033, 150064);

                        return f_1664_150040_150063(_realEnumerator);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1664, 150027, 150066);

                        object
                        f_1664_150040_150063(System.Collections.IEnumerator
                        this_param)
                        {
                            var return_v = this_param.Current;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 150040, 150063);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 149968, 150081);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 149968, 150081);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal object GetNonEnumerableObject()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1664, 150097, 150197);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 150170, 150182);

                    return _obj;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1664, 150097, 150197);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 150097, 150197);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 150097, 150197);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public NonEnumerableObjectEnumerator()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1664, 149269, 150208);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 149660, 149664);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 149699, 149714);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1664, 149269, 150208);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 149269, 150208);
            }


            static NonEnumerableObjectEnumerator()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1664, 149269, 150208);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1664, 149269, 150208);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 149269, 150208);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1664, 149269, 150208);
        }

        internal static IEnumerator GetCOMEnumerator(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 150220, 151499);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 150301, 150341);

                object
                targetValue = f_1664_150322_150340(obj)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 150418, 150458);

                    var
                    temp = (targetValue as IEnumerable)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 150476, 150537);

                    var
                    enumerator = (DynAbs.Tracing.TraceSender.Conditional_F1(1664, 150493, 150506) || ((temp != null && DynAbs.Tracing.TraceSender.Conditional_F2(1664, 150509, 150529)) || DynAbs.Tracing.TraceSender.Conditional_F3(1664, 150532, 150536))) ? f_1664_150509_150529(temp) : null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 150555, 150656) || true) && (enumerator != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 150555, 150656);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 150619, 150637);

                        return enumerator;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 150555, 150656);
                    }
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1664, 150685, 150732);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1664, 150685, 150732);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 151402, 151488);

                return f_1664_151409_151442(targetValue) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.ComEnumerator>(1664, 151409, 151487) ?? f_1664_151446_151487(obj));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 150220, 151499);

                object
                f_1664_150322_150340(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 150322, 150340);
                    return return_v;
                }


                System.Collections.IEnumerator
                f_1664_150509_150529(System.Collections.IEnumerable
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 150509, 150529);
                    return return_v;
                }


                System.Management.Automation.ComEnumerator
                f_1664_151409_151442(object
                comObject)
                {
                    var return_v = ComEnumerator.Create(comObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 151409, 151442);
                    return return_v;
                }


                System.Collections.IEnumerator
                f_1664_151446_151487(object
                obj)
                {
                    var return_v = NonEnumerableObjectEnumerator.Create(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 151446, 151487);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 150220, 151499);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 150220, 151499);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static IEnumerator GetGenericEnumerator<T>(IEnumerable<T> enumerable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 151511, 152144);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 151650, 151684);

                    return f_1664_151657_151683(enumerable);
                }
                catch (RuntimeException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1664, 151713, 151846);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 151825, 151831);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1664, 151713, 151846);
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1664, 151860, 152133);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 151912, 152118);

                    throw f_1664_151918_152117("ExceptionInGetEnumerator", e, f_1664_152045_152084(), f_1664_152107_152116(e));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1664, 151860, 152133);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 151511, 152144);

                System.Collections.Generic.IEnumerator<T>
                f_1664_151657_151683(System.Collections.Generic.IEnumerable<T>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 151657, 151683);
                    return return_v;
                }


                string
                f_1664_152045_152084()
                {
                    var return_v = ExtendedTypeSystem.EnumerationException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 152045, 152084);
                    return return_v;
                }


                string
                f_1664_152107_152116(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 152107, 152116);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeSystemException
                f_1664_151918_152117(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeSystemException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 151918, 152117);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 151511, 152144);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 151511, 152144);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool MoveNext(ExecutionContext context, IEnumerator enumerator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 152693, 153637);
                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 152887, 153001) || true) && (context != null && (DynAbs.Tracing.TraceSender.Expression_True(1664, 152891, 152941) && f_1664_152910_152941(context)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 152887, 153001);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 152964, 153001);

                        throw f_1664_152970_153000();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 152887, 153001);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 153021, 153050);

                    return f_1664_153028_153049(enumerator);
                }
                catch (RuntimeException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1664, 153079, 153157);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 153136, 153142);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1664, 153079, 153157);
                }
                catch (FlowControlException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1664, 153171, 153253);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 153232, 153238);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1664, 153171, 153253);
                }
                catch (ScriptCallDepthException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1664, 153267, 153353);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 153332, 153338);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1664, 153267, 153353);
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1664, 153367, 153626);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 153419, 153611);

                    throw f_1664_153425_153610(enumerator, typeof(RuntimeException), null, "BadEnumeration", f_1664_153567_153595(), e, f_1664_153600_153609(e));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1664, 153367, 153626);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 152693, 153637);

                bool
                f_1664_152910_152941(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentPipelineStopping;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 152910, 152941);
                    return return_v;
                }


                System.Management.Automation.PipelineStoppedException
                f_1664_152970_153000()
                {
                    var return_v = new System.Management.Automation.PipelineStoppedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 152970, 153000);
                    return return_v;
                }


                bool
                f_1664_153028_153049(System.Collections.IEnumerator
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 153028, 153049);
                    return return_v;
                }


                string
                f_1664_153567_153595()
                {
                    var return_v = ParserStrings.BadEnumeration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 153567, 153595);
                    return return_v;
                }


                string
                f_1664_153600_153609(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 153600, 153609);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1664_153425_153610(System.Collections.IEnumerator
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, System.Exception
                innerException, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterExceptionWithInnerException((object)targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, innerException, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 153425, 153610);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 152693, 153637);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 152693, 153637);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object Current(IEnumerator enumerator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 153891, 154619);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 154006, 154032);

                    return f_1664_154013_154031(enumerator);
                }
                catch (RuntimeException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1664, 154061, 154139);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 154118, 154124);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1664, 154061, 154139);
                }
                catch (ScriptCallDepthException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1664, 154153, 154239);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 154218, 154224);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1664, 154153, 154239);
                }
                catch (FlowControlException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1664, 154253, 154335);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 154314, 154320);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1664, 154253, 154335);
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1664, 154349, 154608);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 154401, 154593);

                    throw f_1664_154407_154592(enumerator, typeof(RuntimeException), null, "BadEnumeration", f_1664_154549_154577(), e, f_1664_154582_154591(e));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1664, 154349, 154608);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 153891, 154619);

                object
                f_1664_154013_154031(System.Collections.IEnumerator
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 154013, 154031);
                    return return_v;
                }


                string
                f_1664_154549_154577()
                {
                    var return_v = ParserStrings.BadEnumeration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 154549, 154577);
                    return return_v;
                }


                string
                f_1664_154582_154591(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 154582, 154591);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1664_154407_154592(System.Collections.IEnumerator
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, System.Exception
                innerException, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterExceptionWithInnerException((object)targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, innerException, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 154407, 154592);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 153891, 154619);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 153891, 154619);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object AddFakeEnumerable(NonEnumerableObjectEnumerator fakeEnumerator, object rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 154631, 155274);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 154939, 154998);

                var
                fakeEnumerator2 = rhs as NonEnumerableObjectEnumerator
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 155012, 155263);

                return f_1664_155019_155262(f_1664_155040_155079(fakeEnumerator), (DynAbs.Tracing.TraceSender.Conditional_F1(1664, 155122, 155145) || ((fakeEnumerator2 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1664, 155148, 155188)) || DynAbs.Tracing.TraceSender.Conditional_F3(1664, 155191, 155194))) ? f_1664_155148_155188(fakeEnumerator2) : rhs, "op_Addition", null, "+");
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 154631, 155274);

                object
                f_1664_155040_155079(System.Management.Automation.EnumerableOps.NonEnumerableObjectEnumerator
                this_param)
                {
                    var return_v = this_param.GetNonEnumerableObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 155040, 155079);
                    return return_v;
                }


                object
                f_1664_155148_155188(System.Management.Automation.EnumerableOps.NonEnumerableObjectEnumerator
                this_param)
                {
                    var return_v = this_param.GetNonEnumerableObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 155148, 155188);
                    return return_v;
                }


                object
                f_1664_155019_155262(object
                lval, object
                rval, string
                op, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                errorOp)
                {
                    var return_v = ParserOps.ImplicitOp(lval, rval, op, errorPosition, errorOp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 155019, 155262);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 154631, 155274);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 154631, 155274);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object AddEnumerable(ExecutionContext context, IEnumerator lhs, IEnumerator rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 155286, 155937);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 155407, 155465);

                var
                fakeEnumerator = lhs as NonEnumerableObjectEnumerator
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 155479, 155600) || true) && (fakeEnumerator != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 155479, 155600);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 155539, 155585);

                    return f_1664_155546_155584(fakeEnumerator, rhs);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 155479, 155600);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 155616, 155648);

                var
                result = f_1664_155629_155647()
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 155664, 155767) || true) && (f_1664_155671_155693(context, lhs))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 155664, 155767);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 155727, 155752);

                        f_1664_155727_155751(result, f_1664_155738_155750(lhs));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 155664, 155767);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 155664, 155767);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 155664, 155767);
                }
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 155783, 155886) || true) && (f_1664_155790_155812(context, rhs))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 155783, 155886);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 155846, 155871);

                        f_1664_155846_155870(result, f_1664_155857_155869(rhs));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 155783, 155886);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 155783, 155886);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 155783, 155886);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 155902, 155926);

                return f_1664_155909_155925(result);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 155286, 155937);

                object
                f_1664_155546_155584(System.Management.Automation.EnumerableOps.NonEnumerableObjectEnumerator
                fakeEnumerator, System.Collections.IEnumerator
                rhs)
                {
                    var return_v = AddFakeEnumerable(fakeEnumerator, (object)rhs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 155546, 155584);
                    return return_v;
                }


                System.Collections.Generic.List<object>
                f_1664_155629_155647()
                {
                    var return_v = new System.Collections.Generic.List<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 155629, 155647);
                    return return_v;
                }


                bool
                f_1664_155671_155693(System.Management.Automation.ExecutionContext
                context, System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = MoveNext(context, enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 155671, 155693);
                    return return_v;
                }


                object
                f_1664_155738_155750(System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = Current(enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 155738, 155750);
                    return return_v;
                }


                int
                f_1664_155727_155751(System.Collections.Generic.List<object>
                this_param, object
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 155727, 155751);
                    return 0;
                }


                bool
                f_1664_155790_155812(System.Management.Automation.ExecutionContext
                context, System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = MoveNext(context, enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 155790, 155812);
                    return return_v;
                }


                object
                f_1664_155857_155869(System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = Current(enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 155857, 155869);
                    return return_v;
                }


                int
                f_1664_155846_155870(System.Collections.Generic.List<object>
                this_param, object
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 155846, 155870);
                    return 0;
                }


                object[]
                f_1664_155909_155925(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 155909, 155925);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 155286, 155937);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 155286, 155937);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object AddObject(ExecutionContext context, IEnumerator lhs, object rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 155949, 156504);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 156061, 156119);

                var
                fakeEnumerator = lhs as NonEnumerableObjectEnumerator
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 156133, 156254) || true) && (fakeEnumerator != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 156133, 156254);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 156193, 156239);

                    return f_1664_156200_156238(fakeEnumerator, rhs);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 156133, 156254);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 156270, 156302);

                var
                result = f_1664_156283_156301()
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 156318, 156421) || true) && (f_1664_156325_156347(context, lhs))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 156318, 156421);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 156381, 156406);

                        f_1664_156381_156405(result, f_1664_156392_156404(lhs));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 156318, 156421);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 156318, 156421);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 156318, 156421);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 156437, 156453);

                f_1664_156437_156452(
                            result, rhs);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 156469, 156493);

                return f_1664_156476_156492(result);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 155949, 156504);

                object
                f_1664_156200_156238(System.Management.Automation.EnumerableOps.NonEnumerableObjectEnumerator
                fakeEnumerator, object
                rhs)
                {
                    var return_v = AddFakeEnumerable(fakeEnumerator, rhs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 156200, 156238);
                    return return_v;
                }


                System.Collections.Generic.List<object>
                f_1664_156283_156301()
                {
                    var return_v = new System.Collections.Generic.List<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 156283, 156301);
                    return return_v;
                }


                bool
                f_1664_156325_156347(System.Management.Automation.ExecutionContext
                context, System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = MoveNext(context, enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 156325, 156347);
                    return return_v;
                }


                object
                f_1664_156392_156404(System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = Current(enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 156392, 156404);
                    return return_v;
                }


                int
                f_1664_156381_156405(System.Collections.Generic.List<object>
                this_param, object
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 156381, 156405);
                    return 0;
                }


                int
                f_1664_156437_156452(System.Collections.Generic.List<object>
                this_param, object
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 156437, 156452);
                    return 0;
                }


                object[]
                f_1664_156476_156492(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 156476, 156492);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 155949, 156504);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 155949, 156504);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object Compare(IEnumerator enumerator, object valueToCompareTo, Func<object, object, bool> compareDelegate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 156516, 157307);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 156664, 156729);

                var
                fakeEnumerator = enumerator as NonEnumerableObjectEnumerator
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 156743, 156927) || true) && (fakeEnumerator != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 156743, 156927);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 156803, 156912);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1664, 156810, 156884) || ((f_1664_156810_156884(compareDelegate, f_1664_156826_156865(fakeEnumerator), valueToCompareTo) && DynAbs.Tracing.TraceSender.Conditional_F2(1664, 156887, 156897)) || DynAbs.Tracing.TraceSender.Conditional_F3(1664, 156900, 156911))) ? Boxed.True : Boxed.False;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 156743, 156927);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 156943, 156980);

                var
                resultArray = f_1664_156961_156979()
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 156994, 157251) || true) && (f_1664_157001_157027(null, enumerator))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 156994, 157251);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 157061, 157094);

                        object
                        val = f_1664_157074_157093(enumerator)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 157112, 157236) || true) && (f_1664_157116_157154(compareDelegate, val, valueToCompareTo))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 157112, 157236);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 157196, 157217);

                            f_1664_157196_157216(resultArray, val);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 157112, 157236);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 156994, 157251);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 156994, 157251);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 156994, 157251);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 157267, 157296);

                return f_1664_157274_157295(resultArray);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 156516, 157307);

                object
                f_1664_156826_156865(System.Management.Automation.EnumerableOps.NonEnumerableObjectEnumerator
                this_param)
                {
                    var return_v = this_param.GetNonEnumerableObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 156826, 156865);
                    return return_v;
                }


                bool
                f_1664_156810_156884(System.Func<object, object, bool>
                this_param, object
                arg1, object
                arg2)
                {
                    var return_v = this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 156810, 156884);
                    return return_v;
                }


                System.Collections.Generic.List<object>
                f_1664_156961_156979()
                {
                    var return_v = new System.Collections.Generic.List<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 156961, 156979);
                    return return_v;
                }


                bool
                f_1664_157001_157027(System.Management.Automation.ExecutionContext
                context, System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = MoveNext(context, enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 157001, 157027);
                    return return_v;
                }


                object
                f_1664_157074_157093(System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = Current(enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 157074, 157093);
                    return return_v;
                }


                bool
                f_1664_157116_157154(System.Func<object, object, bool>
                this_param, object
                arg1, object
                arg2)
                {
                    var return_v = this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 157116, 157154);
                    return return_v;
                }


                int
                f_1664_157196_157216(System.Collections.Generic.List<object>
                this_param, object
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 157196, 157216);
                    return 0;
                }


                object[]
                f_1664_157274_157295(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 157274, 157295);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 156516, 157307);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 156516, 157307);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void WriteEnumerableToPipe(IEnumerator enumerator, Pipe pipe, ExecutionContext context, bool dispose)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 157319, 157972);
                try
                {
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 157497, 157624) || true) && (f_1664_157504_157533(context, enumerator))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 157497, 157624);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 157575, 157605);

                            f_1664_157575_157604(pipe, f_1664_157584_157603(enumerator));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 157497, 157624);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 157497, 157624);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 157497, 157624);
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1664, 157653, 157961);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 157693, 157946) || true) && (dispose)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 157693, 157946);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 157746, 157789);

                        var
                        disposable = enumerator as IDisposable
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 157811, 157927) || true) && (disposable != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 157811, 157927);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 157883, 157904);

                            f_1664_157883_157903(disposable);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 157811, 157927);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 157693, 157946);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1664, 157653, 157961);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 157319, 157972);

                bool
                f_1664_157504_157533(System.Management.Automation.ExecutionContext
                context, System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = MoveNext(context, enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 157504, 157533);
                    return return_v;
                }


                object
                f_1664_157584_157603(System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = Current(enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 157584, 157603);
                    return return_v;
                }


                int
                f_1664_157575_157604(System.Management.Automation.Internal.Pipe
                this_param, object
                obj)
                {
                    this_param.Add(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 157575, 157604);
                    return 0;
                }


                int
                f_1664_157883_157903(System.IDisposable
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 157883, 157903);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 157319, 157972);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 157319, 157972);
            }
        }

        internal static object[] ToArray(IEnumerator enumerator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 157984, 158276);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 158065, 158097);

                var
                result = f_1664_158078_158096()
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 158111, 158225) || true) && (f_1664_158118_158144(null, enumerator))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 158111, 158225);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 158178, 158210);

                        f_1664_158178_158209(result, f_1664_158189_158208(enumerator));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 158111, 158225);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 158111, 158225);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 158111, 158225);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 158241, 158265);

                return f_1664_158248_158264(result);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 157984, 158276);

                System.Collections.Generic.List<object>
                f_1664_158078_158096()
                {
                    var return_v = new System.Collections.Generic.List<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 158078, 158096);
                    return return_v;
                }


                bool
                f_1664_158118_158144(System.Management.Automation.ExecutionContext
                context, System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = MoveNext(context, enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 158118, 158144);
                    return return_v;
                }


                object
                f_1664_158189_158208(System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = Current(enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 158189, 158208);
                    return return_v;
                }


                int
                f_1664_158178_158209(System.Collections.Generic.List<object>
                this_param, object
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 158178, 158209);
                    return 0;
                }


                object[]
                f_1664_158248_158264(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1664, 158248, 158264);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 157984, 158276);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 157984, 158276);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object[] GetSlice(IList list, int startIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1664, 158288, 158687);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 158374, 158418);

                int
                countElements = f_1664_158394_158404(list) - startIndex
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 158432, 158476);

                object[]
                result = new object[countElements]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 158492, 158511);

                int
                i = startIndex
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 158525, 158535);

                int
                j = 0
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 158549, 158646) || true) && (j < countElements)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1664, 158549, 158646);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 158607, 158631);

                        result[j++] = f_1664_158621_158630(list, i++);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1664, 158549, 158646);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1664, 158549, 158646);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1664, 158549, 158646);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1664, 158662, 158676);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1664, 158288, 158687);

                int
                f_1664_158394_158404(System.Collections.IList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 158394, 158404);
                    return return_v;
                }


                object
                f_1664_158621_158630(System.Collections.IList
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1664, 158621, 158630);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1664, 158288, 158687);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 158288, 158687);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static EnumerableOps()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1664, 114533, 158694);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1664, 114533, 158694);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1664, 114533, 158694);
        }

    }
}
