// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.Management.Automation.Internal;

namespace System.Management.Automation
{
    internal class AliasHelpProvider : HelpProvider
    {
        internal AliasHelpProvider(HelpSystem helpSystem) : base(f_1141_1066_1076_C(helpSystem))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1141, 1009, 1302);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 1348, 1356);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 1747, 1760);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 2148, 2165);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 1102, 1159);

                _sessionState = f_1141_1118_1158(f_1141_1118_1145(helpSystem));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 1173, 1238);

                _commandDiscovery = f_1141_1193_1237(f_1141_1193_1220(helpSystem));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 1252, 1291);

                _context = f_1141_1263_1290(helpSystem);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1141, 1009, 1302);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1141, 1009, 1302);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1141, 1009, 1302);
            }
        }

        private readonly ExecutionContext _context;

        private SessionState _sessionState;

        private CommandDiscovery _commandDiscovery;

        internal override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1141, 2414, 2494);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 2450, 2479);

                    return "Alias Help Provider";
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1141, 2414, 2494);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1141, 2360, 2505);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1141, 2360, 2505);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1141, 2790, 2867);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 2826, 2852);

                    return HelpCategory.Alias;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1141, 2790, 2867);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1141, 2722, 2878);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1141, 2722, 2878);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override IEnumerable<HelpInfo> ExactMatchHelp(HelpRequest helpRequest)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1141, 3389, 4295);

                var listYield = new List<HelpInfo>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 3493, 3524);

                CommandInfo
                commandInfo = null
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 3576, 3646);

                    commandInfo = f_1141_3590_3645(_commandDiscovery, f_1141_3626_3644(helpRequest));
                }
                catch (CommandNotFoundException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1141, 3675, 3900);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1141, 3675, 3900);
                    // CommandNotFoundException is expected here if target doesn't match any
                    // commandlet. Just ignore this exception and bail out.
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 3916, 4284) || true) && ((commandInfo != null) && (DynAbs.Tracing.TraceSender.Expression_True(1141, 3920, 3992) && (f_1141_3946_3969(commandInfo) == CommandTypes.Alias)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1141, 3916, 4284);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 4026, 4071);

                    AliasInfo
                    aliasInfo = (AliasInfo)commandInfo
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 4091, 4148);

                    HelpInfo
                    helpInfo = f_1141_4111_4147(aliasInfo)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 4166, 4269) || true) && (helpInfo != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1141, 4166, 4269);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 4228, 4250);

                        listYield.Add(helpInfo);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1141, 4166, 4269);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1141, 3916, 4284);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1141, 3389, 4295);

                return listYield;

                string
                f_1141_3626_3644(System.Management.Automation.HelpRequest
                this_param)
                {
                    var return_v = this_param.Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1141, 3626, 3644);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1141_3590_3645(System.Management.Automation.CommandDiscovery
                this_param, string
                commandName)
                {
                    var return_v = this_param.LookupCommandInfo(commandName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1141, 3590, 3645);
                    return return_v;
                }


                System.Management.Automation.CommandTypes
                f_1141_3946_3969(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.CommandType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1141, 3946, 3969);
                    return return_v;
                }


                System.Management.Automation.AliasHelpInfo
                f_1141_4111_4147(System.Management.Automation.AliasInfo
                aliasInfo)
                {
                    var return_v = AliasHelpInfo.GetHelpInfo(aliasInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1141, 4111, 4147);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1141, 3389, 4295);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1141, 3389, 4295);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override IEnumerable<HelpInfo> SearchHelp(HelpRequest helpRequest, bool searchOnlyContent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1141, 5052, 9912);

                var listYield = new List<HelpInfo>();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 5257, 9901) || true) && (!searchOnlyContent)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1141, 5257, 9901);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 5313, 5348);

                    string
                    target = f_1141_5329_5347(helpRequest)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 5366, 5390);

                    string
                    pattern = target
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 5408, 5478);

                    Hashtable
                    hashtable = f_1141_5430_5477(f_1141_5444_5476())
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 5498, 5629) || true) && (!f_1141_5503_5553(target))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1141, 5498, 5629);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 5595, 5610);

                        pattern += "*";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1141, 5498, 5629);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 5649, 5732);

                    WildcardPattern
                    matcher = f_1141_5675_5731(pattern, WildcardOptions.IgnoreCase)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 5750, 5833);

                    IDictionary<string, AliasInfo>
                    aliasTable = f_1141_5794_5832(f_1141_5794_5816(_sessionState))
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 5853, 7136);
                        foreach (string name in f_1141_5877_5892_I(f_1141_5877_5892(aliasTable)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1141, 5853, 7136);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 5934, 7117) || true) && (f_1141_5938_5959(matcher, name))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1141, 5934, 7117);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 6009, 6065);

                                HelpRequest
                                exactMatchHelpRequest = f_1141_6045_6064(helpRequest)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 6091, 6127);

                                exactMatchHelpRequest.Target = name;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 6194, 7094);
                                    foreach (HelpInfo helpInfo in f_1141_6224_6261_I(f_1141_6224_6261(this, exactMatchHelpRequest)))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1141, 6194, 7094);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 6647, 6786) || true) && (!f_1141_6652_6680(helpInfo, helpRequest))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1141, 6647, 6786);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 6746, 6755);

                                            continue;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1141, 6647, 6786);
                                        }

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 6818, 6955) || true) && (f_1141_6822_6849(hashtable, name))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1141, 6818, 6955);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 6915, 6924);

                                            continue;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1141, 6818, 6955);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 6987, 7013);

                                        f_1141_6987_7012(
                                                                    hashtable, name, null);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 7045, 7067);

                                        listYield.Add(helpInfo);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1141, 6194, 7094);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1141, 1, 901);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1141, 1, 901);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1141, 5934, 7117);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1141, 5853, 7136);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1141, 1, 1284);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1141, 1, 1284);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 7156, 7401);

                    CommandSearcher
                    searcher =
                    f_1141_7208_7400(pattern, SearchResolutionOptions.ResolveAliasPatterns, CommandTypes.Alias, _context)
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 7421, 9035) || true) && (f_1141_7428_7447(searcher))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1141, 7421, 9035);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 7489, 7556);

                            CommandInfo
                            current = f_1141_7511_7555(((IEnumerator<CommandInfo>)searcher))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 7580, 7701) || true) && (f_1141_7584_7616(_context))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1141, 7580, 7701);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 7666, 7678);

                                return listYield;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1141, 7580, 7701);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 7725, 7764);

                            AliasInfo
                            alias = current as AliasInfo
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 7788, 9016) || true) && (alias != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1141, 7788, 9016);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 7855, 7880);

                                string
                                name = f_1141_7869_7879(alias)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 7906, 7962);

                                HelpRequest
                                exactMatchHelpRequest = f_1141_7942_7961(helpRequest)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 7988, 8024);

                                exactMatchHelpRequest.Target = name;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 8093, 8993);
                                    foreach (HelpInfo helpInfo in f_1141_8123_8160_I(f_1141_8123_8160(this, exactMatchHelpRequest)))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1141, 8093, 8993);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 8546, 8685) || true) && (!f_1141_8551_8579(helpInfo, helpRequest))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1141, 8546, 8685);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 8645, 8654);

                                            continue;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1141, 8546, 8685);
                                        }

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 8717, 8854) || true) && (f_1141_8721_8748(hashtable, name))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1141, 8717, 8854);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 8814, 8823);

                                            continue;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1141, 8717, 8854);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 8886, 8912);

                                        f_1141_8886_8911(
                                                                    hashtable, name, null);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 8944, 8966);

                                        listYield.Add(helpInfo);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1141, 8093, 8993);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1141, 1, 901);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1141, 1, 901);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1141, 7788, 9016);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1141, 7421, 9035);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1141, 7421, 9035);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1141, 7421, 9035);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 9055, 9886);
                        foreach (CommandInfo current in f_1141_9087_9164_I(f_1141_9087_9164(pattern, _context, f_1141_9138_9163(helpRequest))))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1141, 9055, 9886);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 9206, 9327) || true) && (f_1141_9210_9242(_context))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1141, 9206, 9327);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 9292, 9304);

                                return listYield;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1141, 9206, 9327);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 9351, 9390);

                            AliasInfo
                            alias = current as AliasInfo
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 9414, 9867) || true) && (alias != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1141, 9414, 9867);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 9481, 9506);

                                string
                                name = f_1141_9495_9505(alias)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 9534, 9587);

                                HelpInfo
                                helpInfo = f_1141_9554_9586(alias)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 9615, 9740) || true) && (f_1141_9619_9646(hashtable, name))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1141, 9615, 9740);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 9704, 9713);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1141, 9615, 9740);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 9768, 9794);

                                f_1141_9768_9793(
                                                        hashtable, name, null);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 9822, 9844);

                                listYield.Add(helpInfo);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1141, 9414, 9867);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1141, 9055, 9886);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1141, 1, 832);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1141, 1, 832);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1141, 5257, 9901);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1141, 5052, 9912);

                return listYield;

                string
                f_1141_5329_5347(System.Management.Automation.HelpRequest
                this_param)
                {
                    var return_v = this_param.Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1141, 5329, 5347);
                    return return_v;
                }


                System.StringComparer
                f_1141_5444_5476()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1141, 5444, 5476);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1141_5430_5477(System.StringComparer
                equalityComparer)
                {
                    var return_v = new System.Collections.Hashtable((System.Collections.IEqualityComparer)equalityComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1141, 5430, 5477);
                    return return_v;
                }


                bool
                f_1141_5503_5553(string
                pattern)
                {
                    var return_v = WildcardPattern.ContainsWildcardCharacters(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1141, 5503, 5553);
                    return return_v;
                }


                System.Management.Automation.WildcardPattern
                f_1141_5675_5731(string
                pattern, System.Management.Automation.WildcardOptions
                options)
                {
                    var return_v = WildcardPattern.Get(pattern, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1141, 5675, 5731);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1141_5794_5816(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1141, 5794, 5816);
                    return return_v;
                }


                System.Collections.Generic.IDictionary<string, System.Management.Automation.AliasInfo>
                f_1141_5794_5832(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.GetAliasTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1141, 5794, 5832);
                    return return_v;
                }


                System.Collections.Generic.ICollection<string>
                f_1141_5877_5892(System.Collections.Generic.IDictionary<string, System.Management.Automation.AliasInfo>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1141, 5877, 5892);
                    return return_v;
                }


                bool
                f_1141_5938_5959(System.Management.Automation.WildcardPattern
                this_param, string
                input)
                {
                    var return_v = this_param.IsMatch(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1141, 5938, 5959);
                    return return_v;
                }


                System.Management.Automation.HelpRequest
                f_1141_6045_6064(System.Management.Automation.HelpRequest
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1141, 6045, 6064);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.HelpInfo>
                f_1141_6224_6261(System.Management.Automation.AliasHelpProvider
                this_param, System.Management.Automation.HelpRequest
                helpRequest)
                {
                    var return_v = this_param.ExactMatchHelp(helpRequest);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1141, 6224, 6261);
                    return return_v;
                }


                bool
                f_1141_6652_6680(System.Management.Automation.HelpInfo
                helpInfo, System.Management.Automation.HelpRequest
                helpRequest)
                {
                    var return_v = Match(helpInfo, helpRequest);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1141, 6652, 6680);
                    return return_v;
                }


                bool
                f_1141_6822_6849(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1141, 6822, 6849);
                    return return_v;
                }


                int
                f_1141_6987_7012(System.Collections.Hashtable
                this_param, string
                key, object?
                value)
                {
                    this_param.Add((object)key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1141, 6987, 7012);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.HelpInfo>
                f_1141_6224_6261_I(System.Collections.Generic.IEnumerable<System.Management.Automation.HelpInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1141, 6224, 6261);
                    return return_v;
                }


                System.Collections.Generic.ICollection<string>
                f_1141_5877_5892_I(System.Collections.Generic.ICollection<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1141, 5877, 5892);
                    return return_v;
                }


                System.Management.Automation.CommandSearcher
                f_1141_7208_7400(string
                commandName, System.Management.Automation.SearchResolutionOptions
                options, System.Management.Automation.CommandTypes
                commandTypes, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new System.Management.Automation.CommandSearcher(commandName, options, commandTypes, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1141, 7208, 7400);
                    return return_v;
                }


                bool
                f_1141_7428_7447(System.Management.Automation.CommandSearcher
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1141, 7428, 7447);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1141_7511_7555(System.Collections.Generic.IEnumerator<System.Management.Automation.CommandInfo>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1141, 7511, 7555);
                    return return_v;
                }


                bool
                f_1141_7584_7616(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentPipelineStopping;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1141, 7584, 7616);
                    return return_v;
                }


                string
                f_1141_7869_7879(System.Management.Automation.AliasInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1141, 7869, 7879);
                    return return_v;
                }


                System.Management.Automation.HelpRequest
                f_1141_7942_7961(System.Management.Automation.HelpRequest
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1141, 7942, 7961);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.HelpInfo>
                f_1141_8123_8160(System.Management.Automation.AliasHelpProvider
                this_param, System.Management.Automation.HelpRequest
                helpRequest)
                {
                    var return_v = this_param.ExactMatchHelp(helpRequest);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1141, 8123, 8160);
                    return return_v;
                }


                bool
                f_1141_8551_8579(System.Management.Automation.HelpInfo
                helpInfo, System.Management.Automation.HelpRequest
                helpRequest)
                {
                    var return_v = Match(helpInfo, helpRequest);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1141, 8551, 8579);
                    return return_v;
                }


                bool
                f_1141_8721_8748(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1141, 8721, 8748);
                    return return_v;
                }


                int
                f_1141_8886_8911(System.Collections.Hashtable
                this_param, string
                key, object?
                value)
                {
                    this_param.Add((object)key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1141, 8886, 8911);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.HelpInfo>
                f_1141_8123_8160_I(System.Collections.Generic.IEnumerable<System.Management.Automation.HelpInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1141, 8123, 8160);
                    return return_v;
                }


                System.Management.Automation.CommandOrigin
                f_1141_9138_9163(System.Management.Automation.HelpRequest
                this_param)
                {
                    var return_v = this_param.CommandOrigin;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1141, 9138, 9163);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.CommandInfo>
                f_1141_9087_9164(string
                pattern, System.Management.Automation.ExecutionContext
                context, System.Management.Automation.CommandOrigin
                commandOrigin)
                {
                    var return_v = ModuleUtils.GetMatchingCommands(pattern, context, commandOrigin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1141, 9087, 9164);
                    return return_v;
                }


                bool
                f_1141_9210_9242(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentPipelineStopping;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1141, 9210, 9242);
                    return return_v;
                }


                string
                f_1141_9495_9505(System.Management.Automation.AliasInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1141, 9495, 9505);
                    return return_v;
                }


                System.Management.Automation.AliasHelpInfo
                f_1141_9554_9586(System.Management.Automation.AliasInfo
                aliasInfo)
                {
                    var return_v = AliasHelpInfo.GetHelpInfo(aliasInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1141, 9554, 9586);
                    return return_v;
                }


                bool
                f_1141_9619_9646(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1141, 9619, 9646);
                    return return_v;
                }


                int
                f_1141_9768_9793(System.Collections.Hashtable
                this_param, string
                key, object?
                value)
                {
                    this_param.Add((object)key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1141, 9768, 9793);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.CommandInfo>
                f_1141_9087_9164_I(System.Collections.Generic.IEnumerable<System.Management.Automation.CommandInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1141, 9087, 9164);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1141, 5052, 9912);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1141, 5052, 9912);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool Match(HelpInfo helpInfo, HelpRequest helpRequest)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1141, 9924, 10639);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 10018, 10072) || true) && (helpRequest == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1141, 10018, 10072);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 10060, 10072);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1141, 10018, 10072);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 10088, 10209) || true) && (0 == (f_1141_10098_10122(helpRequest) & f_1141_10125_10146(helpInfo)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1141, 10088, 10209);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 10181, 10194);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1141, 10088, 10209);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 10225, 10340) || true) && (!f_1141_10230_10278(f_1141_10236_10254(helpInfo), f_1141_10256_10277(helpRequest)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1141, 10225, 10340);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 10312, 10325);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1141, 10225, 10340);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 10356, 10461) || true) && (!f_1141_10361_10399(f_1141_10367_10380(helpInfo), f_1141_10382_10398(helpRequest)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1141, 10356, 10461);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 10433, 10446);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1141, 10356, 10461);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 10477, 10600) || true) && (!f_1141_10482_10538(f_1141_10488_10510(helpInfo), f_1141_10512_10537(helpRequest)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1141, 10477, 10600);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 10572, 10585);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1141, 10477, 10600);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 10616, 10628);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1141, 9924, 10639);

                System.Management.Automation.HelpCategory
                f_1141_10098_10122(System.Management.Automation.HelpRequest
                this_param)
                {
                    var return_v = this_param.HelpCategory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1141, 10098, 10122);
                    return return_v;
                }


                System.Management.Automation.HelpCategory
                f_1141_10125_10146(System.Management.Automation.HelpInfo
                this_param)
                {
                    var return_v = this_param.HelpCategory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1141, 10125, 10146);
                    return return_v;
                }


                string
                f_1141_10236_10254(System.Management.Automation.HelpInfo
                this_param)
                {
                    var return_v = this_param.Component;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1141, 10236, 10254);
                    return return_v;
                }


                string[]
                f_1141_10256_10277(System.Management.Automation.HelpRequest
                this_param)
                {
                    var return_v = this_param.Component;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1141, 10256, 10277);
                    return return_v;
                }


                bool
                f_1141_10230_10278(string
                target, string[]
                patterns)
                {
                    var return_v = Match(target, patterns);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1141, 10230, 10278);
                    return return_v;
                }


                string
                f_1141_10367_10380(System.Management.Automation.HelpInfo
                this_param)
                {
                    var return_v = this_param.Role;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1141, 10367, 10380);
                    return return_v;
                }


                string[]
                f_1141_10382_10398(System.Management.Automation.HelpRequest
                this_param)
                {
                    var return_v = this_param.Role;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1141, 10382, 10398);
                    return return_v;
                }


                bool
                f_1141_10361_10399(string
                target, string[]
                patterns)
                {
                    var return_v = Match(target, patterns);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1141, 10361, 10399);
                    return return_v;
                }


                string
                f_1141_10488_10510(System.Management.Automation.HelpInfo
                this_param)
                {
                    var return_v = this_param.Functionality;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1141, 10488, 10510);
                    return return_v;
                }


                string[]
                f_1141_10512_10537(System.Management.Automation.HelpRequest
                this_param)
                {
                    var return_v = this_param.Functionality;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1141, 10512, 10537);
                    return return_v;
                }


                bool
                f_1141_10482_10538(string
                target, string[]
                patterns)
                {
                    var return_v = Match(target, patterns);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1141, 10482, 10538);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1141, 9924, 10639);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1141, 9924, 10639);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool Match(string target, string[] patterns)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1141, 10651, 11302);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 10872, 10947) || true) && (patterns == null || (DynAbs.Tracing.TraceSender.Expression_False(1141, 10876, 10916) || f_1141_10896_10911(patterns) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1141, 10872, 10947);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 10935, 10947);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1141, 10872, 10947);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 10963, 11201);
                    foreach (string pattern in f_1141_10990_10998_I(patterns))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1141, 10963, 11201);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 11032, 11186) || true) && (f_1141_11036_11058(target, pattern))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1141, 11032, 11186);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 11155, 11167);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1141, 11032, 11186);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1141, 10963, 11201);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1141, 1, 239);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1141, 1, 239);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 11278, 11291);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1141, 10651, 11302);

                int
                f_1141_10896_10911(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1141, 10896, 10911);
                    return return_v;
                }


                bool
                f_1141_11036_11058(string
                target, string
                pattern)
                {
                    var return_v = Match(target, pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1141, 11036, 11058);
                    return return_v;
                }


                string[]
                f_1141_10990_10998_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1141, 10990, 10998);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1141, 10651, 11302);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1141, 10651, 11302);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool Match(string target, string pattern)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1141, 11314, 11705);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 11395, 11459) || true) && (f_1141_11399_11428(pattern))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1141, 11395, 11459);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 11447, 11459);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1141, 11395, 11459);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 11475, 11548) || true) && (f_1141_11479_11507(target))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1141, 11475, 11548);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 11526, 11548);

                    target = string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1141, 11475, 11548);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 11564, 11647);

                WildcardPattern
                matcher = f_1141_11590_11646(pattern, WildcardOptions.IgnoreCase)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1141, 11663, 11694);

                return f_1141_11670_11693(matcher, target);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1141, 11314, 11705);

                bool
                f_1141_11399_11428(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1141, 11399, 11428);
                    return return_v;
                }


                bool
                f_1141_11479_11507(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1141, 11479, 11507);
                    return return_v;
                }


                System.Management.Automation.WildcardPattern
                f_1141_11590_11646(string
                pattern, System.Management.Automation.WildcardOptions
                options)
                {
                    var return_v = WildcardPattern.Get(pattern, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1141, 11590, 11646);
                    return return_v;
                }


                bool
                f_1141_11670_11693(System.Management.Automation.WildcardPattern
                this_param, string
                input)
                {
                    var return_v = this_param.IsMatch(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1141, 11670, 11693);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1141, 11314, 11705);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1141, 11314, 11705);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static AliasHelpProvider()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1141, 830, 11734);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1141, 830, 11734);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1141, 830, 11734);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1141, 830, 11734);

        System.Management.Automation.ExecutionContext
        f_1141_1118_1145(System.Management.Automation.HelpSystem
        this_param)
        {
            var return_v = this_param.ExecutionContext;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1141, 1118, 1145);
            return return_v;
        }


        System.Management.Automation.SessionState
        f_1141_1118_1158(System.Management.Automation.ExecutionContext
        this_param)
        {
            var return_v = this_param.SessionState;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1141, 1118, 1158);
            return return_v;
        }


        System.Management.Automation.ExecutionContext
        f_1141_1193_1220(System.Management.Automation.HelpSystem
        this_param)
        {
            var return_v = this_param.ExecutionContext;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1141, 1193, 1220);
            return return_v;
        }


        System.Management.Automation.CommandDiscovery
        f_1141_1193_1237(System.Management.Automation.ExecutionContext
        this_param)
        {
            var return_v = this_param.CommandDiscovery;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1141, 1193, 1237);
            return return_v;
        }


        System.Management.Automation.ExecutionContext
        f_1141_1263_1290(System.Management.Automation.HelpSystem
        this_param)
        {
            var return_v = this_param.ExecutionContext;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1141, 1263, 1290);
            return return_v;
        }


        static System.Management.Automation.HelpSystem
        f_1141_1066_1076_C(System.Management.Automation.HelpSystem
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1141, 1009, 1302);
            return return_v;
        }

    }
}
