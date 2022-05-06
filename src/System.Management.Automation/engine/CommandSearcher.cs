// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Management.Automation.Internal;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation
{
    internal class CommandSearcher : IEnumerable<CommandInfo>, IEnumerator<CommandInfo>
    {
        internal CommandSearcher(
                    string commandName,
                    SearchResolutionOptions options,
                    CommandTypes commandTypes,
                    ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1253, 1568, 2214);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 40502, 40517);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 56823, 56835);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 56988, 57013);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 57155, 57187);
                this._commandTypes = CommandTypes.All;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 57357, 57370);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 57525, 57533);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 64187, 64226);
                this._commandOrigin = CommandOrigin.Internal;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 64369, 64383);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 64530, 64557);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 64720, 64733);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 64759, 64775);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 64816, 64866);
                this._canDoPathLookupResult = CanDoPathLookupResult.Yes;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 64996, 65040);
                this._currentState = SearchState.SearchingAliases;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 1776, 1852);

                f_1253_1776_1851(context != null, "caller to verify context is not null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 1866, 1962);

                f_1253_1866_1961(!f_1253_1886_1919(commandName), "caller to verify commandName is valid");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 1978, 2005);

                _commandName = commandName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 2019, 2038);

                _context = context;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 2052, 2088);

                _commandResolutionOptions = options;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 2102, 2131);

                _commandTypes = commandTypes;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 2190, 2203);

                f_1253_2190_2202(
                            // Initialize the enumerators
                            this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1253, 1568, 2214);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1253, 1568, 2214);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1253, 1568, 2214);
            }
        }

        IEnumerator<CommandInfo> IEnumerable<CommandInfo>.GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1253, 2430, 2543);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 2520, 2532);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1253, 2430, 2543);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1253, 2430, 2543);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1253, 2430, 2543);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1253, 2555, 2642);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 2619, 2631);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1253, 2555, 2642);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1253, 2555, 2642);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1253, 2555, 2642);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool MoveNext()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1253, 2911, 9199);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 2958, 2979);

                _currentMatch = null;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 2995, 3602) || true) && (_currentState == SearchState.SearchingAliases)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 2995, 3602);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 3078, 3113);

                    _currentMatch = f_1253_3094_3112(this);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 3205, 3360) || true) && (_currentMatch != null && (DynAbs.Tracing.TraceSender.Expression_True(1253, 3209, 3287) && f_1253_3234_3287(_commandOrigin, _currentMatch)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 3205, 3360);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 3329, 3341);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 3205, 3360);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 3461, 3482);

                    _currentMatch = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 3540, 3587);

                    _currentState = SearchState.SearchingFunctions;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 2995, 3602);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 3618, 4120) || true) && (_currentState == SearchState.SearchingFunctions)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 3618, 4120);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 3703, 3740);

                    _currentMatch = f_1253_3719_3739(this);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 3904, 4002) || true) && (_currentMatch != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 3904, 4002);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 3971, 3983);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 3904, 4002);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 4060, 4105);

                    _currentState = SearchState.SearchingCmdlets;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 3618, 4120);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 4136, 4505) || true) && (_currentState == SearchState.SearchingCmdlets)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 4136, 4505);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 4219, 4254);

                    _currentMatch = f_1253_4235_4253(this);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 4272, 4370) || true) && (_currentMatch != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 4272, 4370);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 4339, 4351);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 4272, 4370);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 4428, 4490);

                    _currentState = SearchState.StartSearchingForExternalCommands;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 4136, 4505);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 4521, 8062) || true) && (_currentState == SearchState.StartSearchingForExternalCommands)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 4521, 8062);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 4621, 4958) || true) && ((_commandTypes & (CommandTypes.Application | CommandTypes.ExternalScript)) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 4621, 4958);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 4926, 4939);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 4621, 4958);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 5198, 7439) || true) && (_commandOrigin == CommandOrigin.Runspace && (DynAbs.Tracing.TraceSender.Expression_True(1253, 5202, 5309) && f_1253_5246_5304(_commandName, Utils.Separators.DirectoryOrDrive) >= 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 5198, 7439);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 5351, 5372);

                        bool
                        allowed = false
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 5764, 7298) || true) && ((f_1253_5769_5815(f_1253_5769_5809(f_1253_5769_5796(_context))) == 1 && (DynAbs.Tracing.TraceSender.Expression_True(1253, 5769, 5940) && f_1253_5849_5940(f_1253_5849_5892(f_1253_5849_5889(f_1253_5849_5876(_context)), 0), "*", StringComparison.OrdinalIgnoreCase))) || (DynAbs.Tracing.TraceSender.Expression_False(1253, 5768, 6133) || (f_1253_5971_6012(f_1253_5971_6006(f_1253_5971_5998(_context))) == 1 && (DynAbs.Tracing.TraceSender.Expression_True(1253, 5971, 6132) && f_1253_6046_6132(f_1253_6046_6084(f_1253_6046_6081(f_1253_6046_6073(_context)), 0), "*", StringComparison.OrdinalIgnoreCase)))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 5764, 7298);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 6183, 6198);

                            allowed = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 5764, 7298);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 5764, 7298);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 6364, 6698);
                                foreach (string path in f_1253_6388_6428_I(f_1253_6388_6428(f_1253_6388_6415(_context))))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 6364, 6698);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 6486, 6671) || true) && (f_1253_6490_6519(path, _commandName))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 6486, 6671);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 6585, 6600);

                                        allowed = true;
                                        DynAbs.Tracing.TraceSender.TraceBreak(1253, 6634, 6640);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 6486, 6671);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 6364, 6698);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1253, 1, 335);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1253, 1, 335);
                            }
                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 6821, 7275) || true) && (!allowed)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 6821, 7275);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 6891, 7248);
                                    foreach (string path in f_1253_6915_6950_I(f_1253_6915_6950(f_1253_6915_6942(_context))))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 6891, 7248);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 7016, 7217) || true) && (f_1253_7020_7049(path, _commandName))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 7016, 7217);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 7123, 7138);

                                            allowed = true;
                                            DynAbs.Tracing.TraceSender.TraceBreak(1253, 7176, 7182);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 7016, 7217);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 6891, 7248);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1253, 1, 358);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1253, 1, 358);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 6821, 7275);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 5764, 7298);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 7322, 7420) || true) && (!allowed)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 7322, 7420);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 7384, 7397);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 7322, 7420);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 5198, 7439);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 7499, 7552);

                    _currentState = SearchState.PowerShellPathResolution;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 7572, 7616);

                    _currentMatch = f_1253_7588_7615(this);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 7636, 8047) || true) && (_currentMatch != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 7636, 8047);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 7942, 7994);

                        _currentState = SearchState.QualifiedFileSystemPath;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 8016, 8028);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 7636, 8047);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 4521, 8062);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 8078, 8419) || true) && (_currentState == SearchState.PowerShellPathResolution)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 8078, 8419);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 8169, 8221);

                    _currentState = SearchState.QualifiedFileSystemPath;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 8241, 8286);

                    _currentMatch = f_1253_8257_8285(this);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 8306, 8404) || true) && (_currentMatch != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 8306, 8404);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 8373, 8385);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 8306, 8404);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 8078, 8419);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 8484, 8821) || true) && (_currentState == SearchState.QualifiedFileSystemPath || (DynAbs.Tracing.TraceSender.Expression_False(1253, 8488, 8604) || _currentState == SearchState.PathSearch))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 8484, 8821);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 8638, 8688);

                    _currentMatch = f_1253_8654_8687(this);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 8708, 8806) || true) && (_currentMatch != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 8708, 8806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 8775, 8787);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 8708, 8806);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 8484, 8821);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 8837, 9159) || true) && (_currentState == SearchState.PathSearch)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 8837, 9159);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 8914, 8965);

                    _currentState = SearchState.PowerShellRelativePath;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 8985, 9026);

                    _currentMatch = f_1253_9001_9025(this);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 9046, 9144) || true) && (_currentMatch != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 9046, 9144);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 9113, 9125);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 9046, 9144);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 8837, 9159);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 9175, 9188);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1253, 2911, 9199);

                System.Management.Automation.CommandInfo
                f_1253_3094_3112(System.Management.Automation.CommandSearcher
                this_param)
                {
                    var return_v = this_param.SearchForAliases();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 3094, 3112);
                    return return_v;
                }


                bool
                f_1253_3234_3287(System.Management.Automation.CommandOrigin
                origin, System.Management.Automation.CommandInfo
                commandInfo)
                {
                    var return_v = SessionState.IsVisible(origin, commandInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 3234, 3287);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1253_3719_3739(System.Management.Automation.CommandSearcher
                this_param)
                {
                    var return_v = this_param.SearchForFunctions();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 3719, 3739);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1253_4235_4253(System.Management.Automation.CommandSearcher
                this_param)
                {
                    var return_v = this_param.SearchForCmdlets();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 4235, 4253);
                    return return_v;
                }


                int
                f_1253_5246_5304(string
                this_param, char[]
                anyOf)
                {
                    var return_v = this_param.IndexOfAny(anyOf);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 5246, 5304);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1253_5769_5796(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 5769, 5796);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1253_5769_5809(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.Applications;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 5769, 5809);
                    return return_v;
                }


                int
                f_1253_5769_5815(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 5769, 5815);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1253_5849_5876(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 5849, 5876);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1253_5849_5889(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.Applications;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 5849, 5889);
                    return return_v;
                }


                string
                f_1253_5849_5892(System.Collections.Generic.List<string>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 5849, 5892);
                    return return_v;
                }


                bool
                f_1253_5849_5940(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 5849, 5940);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1253_5971_5998(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 5971, 5998);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1253_5971_6006(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.Scripts;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 5971, 6006);
                    return return_v;
                }


                int
                f_1253_5971_6012(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 5971, 6012);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1253_6046_6073(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 6046, 6073);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1253_6046_6081(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.Scripts;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 6046, 6081);
                    return return_v;
                }


                string
                f_1253_6046_6084(System.Collections.Generic.List<string>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 6046, 6084);
                    return return_v;
                }


                bool
                f_1253_6046_6132(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 6046, 6132);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1253_6388_6415(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 6388, 6415);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1253_6388_6428(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.Applications;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 6388, 6428);
                    return return_v;
                }


                bool
                f_1253_6490_6519(string
                path, string
                commandName)
                {
                    var return_v = checkPath(path, commandName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 6490, 6519);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1253_6388_6428_I(System.Collections.Generic.List<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 6388, 6428);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1253_6915_6942(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 6915, 6942);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1253_6915_6950(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.Scripts;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 6915, 6950);
                    return return_v;
                }


                bool
                f_1253_7020_7049(string
                path, string
                commandName)
                {
                    var return_v = checkPath(path, commandName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 7020, 7049);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1253_6915_6950_I(System.Collections.Generic.List<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 6915, 6950);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1253_7588_7615(System.Management.Automation.CommandSearcher
                this_param)
                {
                    var return_v = this_param.ProcessBuiltinScriptState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 7588, 7615);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1253_8257_8285(System.Management.Automation.CommandSearcher
                this_param)
                {
                    var return_v = this_param.ProcessPathResolutionState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 8257, 8285);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1253_8654_8687(System.Management.Automation.CommandSearcher
                this_param)
                {
                    var return_v = this_param.ProcessQualifiedFileSystemState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 8654, 8687);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1253_9001_9025(System.Management.Automation.CommandSearcher
                this_param)
                {
                    var return_v = this_param.ProcessPathSearchState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 9001, 9025);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1253, 2911, 9199);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1253, 2911, 9199);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private CommandInfo SearchForAliases()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1253, 9211, 9549);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 9274, 9306);

                CommandInfo
                currentMatch = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 9322, 9502) || true) && (f_1253_9326_9353(_context) != null && (DynAbs.Tracing.TraceSender.Expression_True(1253, 9326, 9423) && (_commandTypes & CommandTypes.Alias) != 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 9322, 9502);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 9457, 9487);

                    currentMatch = f_1253_9472_9486(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 9322, 9502);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 9518, 9538);

                return currentMatch;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1253, 9211, 9549);

                System.Management.Automation.SessionStateInternal
                f_1253_9326_9353(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 9326, 9353);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1253_9472_9486(System.Management.Automation.CommandSearcher
                this_param)
                {
                    var return_v = this_param.GetNextAlias();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 9472, 9486);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1253, 9211, 9549);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1253, 9211, 9549);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private CommandInfo SearchForFunctions()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1253, 9561, 9960);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 9626, 9658);

                CommandInfo
                currentMatch = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 9674, 9913) || true) && (f_1253_9678_9705(_context) != null && (DynAbs.Tracing.TraceSender.Expression_True(1253, 9678, 9831) && (_commandTypes & (CommandTypes.Function | CommandTypes.Filter | CommandTypes.Configuration)) != 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 9674, 9913);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 9865, 9898);

                    currentMatch = f_1253_9880_9897(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 9674, 9913);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 9929, 9949);

                return currentMatch;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1253, 9561, 9960);

                System.Management.Automation.SessionStateInternal
                f_1253_9678_9705(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 9678, 9705);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1253_9880_9897(System.Management.Automation.CommandSearcher
                this_param)
                {
                    var return_v = this_param.GetNextFunction();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 9880, 9897);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1253, 9561, 9960);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1253, 9561, 9960);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private CommandInfo SearchForCmdlets()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1253, 9972, 10256);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 10035, 10067);

                CommandInfo
                currentMatch = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 10083, 10209) || true) && ((_commandTypes & CommandTypes.Cmdlet) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 10083, 10209);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 10163, 10194);

                    currentMatch = f_1253_10178_10193(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 10083, 10209);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 10225, 10245);

                return currentMatch;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1253, 9972, 10256);

                System.Management.Automation.CmdletInfo
                f_1253_10178_10193(System.Management.Automation.CommandSearcher
                this_param)
                {
                    var return_v = this_param.GetNextCmdlet();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 10178, 10193);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1253, 9972, 10256);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1253, 9972, 10256);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private CommandInfo ProcessBuiltinScriptState()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1253, 10268, 10730);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 10340, 10372);

                CommandInfo
                currentMatch = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 10444, 10683) || true) && (f_1253_10448_10475(_context) != null && (DynAbs.Tracing.TraceSender.Expression_True(1253, 10448, 10549) && f_1253_10504_10545(f_1253_10504_10531(_context)) > 0) && (DynAbs.Tracing.TraceSender.Expression_True(1253, 10448, 10601) && f_1253_10570_10601(_commandName)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 10444, 10683);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 10635, 10668);

                    currentMatch = f_1253_10650_10667(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 10444, 10683);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 10699, 10719);

                return currentMatch;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1253, 10268, 10730);

                System.Management.Automation.SessionStateInternal
                f_1253_10448_10475(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 10448, 10475);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1253_10504_10531(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 10504, 10531);
                    return return_v;
                }


                int
                f_1253_10504_10545(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ProviderCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 10504, 10545);
                    return return_v;
                }


                bool
                f_1253_10570_10601(string
                commandName)
                {
                    var return_v = IsQualifiedPSPath(commandName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 10570, 10601);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1253_10650_10667(System.Management.Automation.CommandSearcher
                this_param)
                {
                    var return_v = this_param.GetNextFromPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 10650, 10667);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1253, 10268, 10730);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1253, 10268, 10730);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private CommandInfo ProcessPathResolutionState()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1253, 10742, 12229);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 10815, 10847);

                CommandInfo
                currentMatch = null
                ;

                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 11032, 11575) || true) && (f_1253_11036_11067(_commandName) && (DynAbs.Tracing.TraceSender.Expression_True(1253, 11036, 11117) && f_1253_11092_11117(_commandName)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 11032, 11575);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 11211, 11256);

                            currentMatch = f_1253_11226_11255(this, _commandName);
                        }
                        catch (FileLoadException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1253, 11301, 11372);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1253, 11301, 11372);
                        }
                        catch (FormatException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1253, 11394, 11463);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1253, 11394, 11463);
                        }
                        catch (MetadataException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1253, 11485, 11556);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1253, 11485, 11556);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 11032, 11575);
                    }
                }
                catch (ArgumentException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1253, 11604, 12182);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1253, 11604, 12182);
                    // If the path contains illegal characters that
                    // weren't caught by the other APIs, IsPathRooted
                    // will throw an exception.
                    // For example, looking for a command called
                    // `abcdef
                    // The `a will be translated into the beep control character
                    // which is not a legal file system character, though
                    // Path.InvalidPathChars does not contain it as an invalid
                    // character.
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 12198, 12218);

                return currentMatch;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1253, 10742, 12229);

                bool
                f_1253_11036_11067(string
                path)
                {
                    var return_v = Path.IsPathRooted(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 11036, 11067);
                    return return_v;
                }


                bool
                f_1253_11092_11117(string
                path)
                {
                    var return_v = File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 11092, 11117);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1253_11226_11255(System.Management.Automation.CommandSearcher
                this_param, string
                path)
                {
                    var return_v = this_param.GetInfoFromPath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 11226, 11255);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1253, 10742, 12229);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1253, 10742, 12229);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private CommandInfo ProcessQualifiedFileSystemState()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1253, 12241, 13365);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 12355, 12375);

                    f_1253_12355_12374(this);
                }
                catch (ArgumentException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1253, 12404, 12543);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 12462, 12504);

                    _currentState = SearchState.NoMoreMatches;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 12522, 12528);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1253, 12404, 12543);
                }
                catch (PathTooLongException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1253, 12557, 12699);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 12618, 12660);

                    _currentState = SearchState.NoMoreMatches;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 12678, 12684);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1253, 12557, 12699);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 12715, 12747);

                CommandInfo
                currentMatch = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 12761, 12800);

                _currentState = SearchState.PathSearch;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 12814, 13318) || true) && (_canDoPathLookup)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 12814, 13318);
                    try
                    {
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 12912, 13117) || true) && (currentMatch == null && (DynAbs.Tracing.TraceSender.Expression_True(1253, 12919, 12967) && f_1253_12943_12967(_pathSearcher)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 12912, 13117);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 13017, 13094);

                                currentMatch = f_1253_13032_13093(this, f_1253_13048_13092(((IEnumerator<string>)_pathSearcher)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 12912, 13117);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1253, 12912, 13117);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1253, 12912, 13117);
                        }
                    }
                    catch (InvalidOperationException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1253, 13154, 13303);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1253, 13154, 13303);
                        // The enumerator may throw if there are no more matches
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 12814, 13318);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 13334, 13354);

                return currentMatch;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1253, 12241, 13365);

                int
                f_1253_12355_12374(System.Management.Automation.CommandSearcher
                this_param)
                {
                    this_param.setupPathSearcher();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 12355, 12374);
                    return 0;
                }


                bool
                f_1253_12943_12967(System.Management.Automation.CommandPathSearch
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 12943, 12967);
                    return return_v;
                }


                string
                f_1253_13048_13092(System.Collections.Generic.IEnumerator<string>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 13048, 13092);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1253_13032_13093(System.Management.Automation.CommandSearcher
                this_param, string
                path)
                {
                    var return_v = this_param.GetInfoFromPath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 13032, 13093);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1253, 12241, 13365);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1253, 12241, 13365);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private CommandInfo ProcessPathSearchState()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1253, 13377, 13719);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 13446, 13478);

                CommandInfo
                currentMatch = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 13492, 13539);

                string
                path = f_1253_13506_13538(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 13555, 13672) || true) && (!f_1253_13560_13586(path))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 13555, 13672);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 13620, 13657);

                    currentMatch = f_1253_13635_13656(this, path);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 13555, 13672);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 13688, 13708);

                return currentMatch;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1253, 13377, 13719);

                string
                f_1253_13506_13538(System.Management.Automation.CommandSearcher
                this_param)
                {
                    var return_v = this_param.DoPowerShellRelativePathLookup();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 13506, 13538);
                    return return_v;
                }


                bool
                f_1253_13560_13586(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 13560, 13586);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1253_13635_13656(System.Management.Automation.CommandSearcher
                this_param, string
                path)
                {
                    var return_v = this_param.GetInfoFromPath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 13635, 13656);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1253, 13377, 13719);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1253, 13377, 13719);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        CommandInfo IEnumerator<CommandInfo>.Current
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1253, 14159, 14552);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 14195, 14496) || true) && ((_currentState == SearchState.SearchingAliases && (DynAbs.Tracing.TraceSender.Expression_True(1253, 14200, 14270) && _currentMatch == null)) || (DynAbs.Tracing.TraceSender.Expression_False(1253, 14199, 14338) || _currentState == SearchState.NoMoreMatches) || (DynAbs.Tracing.TraceSender.Expression_False(1253, 14199, 14384) || _currentMatch == null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 14195, 14496);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 14426, 14477);

                        throw f_1253_14432_14476();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 14195, 14496);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 14516, 14537);

                    return _currentMatch;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1253, 14159, 14552);

                    System.Management.Automation.PSInvalidOperationException
                    f_1253_14432_14476()
                    {
                        var return_v = PSTraceSource.NewInvalidOperationException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 14432, 14476);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1253, 14090, 14563);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1253, 14090, 14563);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        object IEnumerator.Current
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1253, 14626, 14725);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 14662, 14710);

                    return f_1253_14669_14709(((IEnumerator<CommandInfo>)this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1253, 14626, 14725);

                    System.Management.Automation.CommandInfo
                    f_1253_14669_14709(System.Collections.Generic.IEnumerator<System.Management.Automation.CommandInfo>
                    this_param)
                    {
                        var return_v = this_param.Current;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 14669, 14709);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1253, 14575, 14736);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1253, 14575, 14736);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1253, 14889, 15147);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 14935, 15072) || true) && (_pathSearcher != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 14935, 15072);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 14994, 15018);

                    f_1253_14994_15017(_pathSearcher);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 15036, 15057);

                    _pathSearcher = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 14935, 15072);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 15088, 15096);

                f_1253_15088_15095(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 15110, 15136);

                f_1253_15110_15135(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1253, 14889, 15147);

                int
                f_1253_14994_15017(System.Management.Automation.CommandPathSearch
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 14994, 15017);
                    return 0;
                }


                int
                f_1253_15088_15095(System.Management.Automation.CommandSearcher
                this_param)
                {
                    this_param.Reset();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 15088, 15095);
                    return 0;
                }


                int
                f_1253_15110_15135(System.Management.Automation.CommandSearcher
                obj)
                {
                    GC.SuppressFinalize((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 15110, 15135);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1253, 14889, 15147);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1253, 14889, 15147);
            }
        }

        private CommandInfo GetNextFromPath()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1253, 15453, 18046);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 15515, 15541);

                CommandInfo
                result = null
                ;
                {
                    try
                    {
                        do // false loop

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 15557, 18005);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 15606, 15754);

                            f_1253_15606_15753(CommandDiscovery.discoveryTracer, "The name appears to be a qualified path: {0}", _commandName);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 15774, 15882);

                            f_1253_15774_15881(
                                            CommandDiscovery.discoveryTracer, "Trying to resolve the path as an PSPath");

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 16021, 16397) || true) && (f_1253_16025_16114(_commandResolutionOptions, SearchResolutionOptions.ResolveLiteralThenPathPatterns))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 16021, 16397);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 16156, 16236);

                                var
                                path = f_1253_16167_16235(this, _commandName, out _)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 16260, 16378) || true) && (path != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 16260, 16378);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 16326, 16355);

                                    return f_1253_16333_16354(this, path);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 16260, 16378);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 16021, 16397);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 16417, 16477);

                            Collection<string>
                            resolvedPaths = f_1253_16452_16476()
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 16495, 16683) || true) && (f_1253_16499_16555(_commandName))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 16495, 16683);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 16597, 16664);

                                resolvedPaths = f_1253_16613_16663(this, _commandName, out _);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 16495, 16683);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 16808, 17237) || true) && (!f_1253_16813_16902(_commandResolutionOptions, SearchResolutionOptions.ResolveLiteralThenPathPatterns) && (DynAbs.Tracing.TraceSender.Expression_True(1253, 16812, 16951) && f_1253_16927_16946(resolvedPaths) == 0))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 16808, 17237);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 16993, 17076);

                                string
                                path = f_1253_17007_17075(this, _commandName, out _)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 17100, 17218) || true) && (path != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 17100, 17218);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 17166, 17195);

                                    return f_1253_17173_17194(this, path);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 17100, 17218);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 16808, 17237);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 17257, 17517) || true) && (f_1253_17261_17280(resolvedPaths) > 1)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 17257, 17517);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 17326, 17470);

                                f_1253_17326_17469(CommandDiscovery.discoveryTracer, "The path resolved to more than one result so this path cannot be used.");
                                DynAbs.Tracing.TraceSender.TraceBreak(1253, 17492, 17498);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 17257, 17517);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 17597, 17975) || true) && (f_1253_17601_17620(resolvedPaths) == 1 && (DynAbs.Tracing.TraceSender.Expression_True(1253, 17601, 17679) && f_1253_17650_17679(f_1253_17662_17678(resolvedPaths, 0))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 17597, 17975);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 17721, 17752);

                                string
                                path = f_1253_17735_17751(resolvedPaths, 0)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 17776, 17901);

                                f_1253_17776_17900(
                                                    CommandDiscovery.discoveryTracer, "Path resolved to: {0}", path);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 17925, 17956);

                                result = f_1253_17934_17955(this, path);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 17597, 17975);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 15557, 18005);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 15557, 18005) || true) && (false)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1253, 15557, 18005);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1253, 15557, 18005);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 18021, 18035);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1253, 15453, 18046);

                int
                f_1253_15606_15753(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 15606, 15753);
                    return 0;
                }


                int
                f_1253_15774_15881(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 15774, 15881);
                    return 0;
                }


                bool
                f_1253_16025_16114(System.Management.Automation.SearchResolutionOptions
                this_param, System.Management.Automation.SearchResolutionOptions
                flag)
                {
                    var return_v = this_param.HasFlag((System.Enum)flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 16025, 16114);
                    return return_v;
                }


                string
                f_1253_16167_16235(System.Management.Automation.CommandSearcher
                this_param, string
                command, out System.Management.Automation.ProviderInfo
                provider)
                {
                    var return_v = this_param.GetNextLiteralPathThatExistsAndHandleExceptions(command, out provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 16167, 16235);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1253_16333_16354(System.Management.Automation.CommandSearcher
                this_param, string
                path)
                {
                    var return_v = this_param.GetInfoFromPath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 16333, 16354);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1253_16452_16476()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 16452, 16476);
                    return return_v;
                }


                bool
                f_1253_16499_16555(string
                pattern)
                {
                    var return_v = WildcardPattern.ContainsWildcardCharacters(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 16499, 16555);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1253_16613_16663(System.Management.Automation.CommandSearcher
                this_param, string
                command, out System.Management.Automation.ProviderInfo
                provider)
                {
                    var return_v = this_param.GetNextFromPathUsingWildcards(command, out provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 16613, 16663);
                    return return_v;
                }


                bool
                f_1253_16813_16902(System.Management.Automation.SearchResolutionOptions
                this_param, System.Management.Automation.SearchResolutionOptions
                flag)
                {
                    var return_v = this_param.HasFlag((System.Enum)flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 16813, 16902);
                    return return_v;
                }


                int
                f_1253_16927_16946(System.Collections.ObjectModel.Collection<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 16927, 16946);
                    return return_v;
                }


                string
                f_1253_17007_17075(System.Management.Automation.CommandSearcher
                this_param, string
                command, out System.Management.Automation.ProviderInfo
                provider)
                {
                    var return_v = this_param.GetNextLiteralPathThatExistsAndHandleExceptions(command, out provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 17007, 17075);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1253_17173_17194(System.Management.Automation.CommandSearcher
                this_param, string
                path)
                {
                    var return_v = this_param.GetInfoFromPath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 17173, 17194);
                    return return_v;
                }


                int
                f_1253_17261_17280(System.Collections.ObjectModel.Collection<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 17261, 17280);
                    return return_v;
                }


                int
                f_1253_17326_17469(System.Management.Automation.PSTraceSource
                this_param, string
                errorMessageFormat, params object[]
                args)
                {
                    this_param.TraceError(errorMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 17326, 17469);
                    return 0;
                }


                int
                f_1253_17601_17620(System.Collections.ObjectModel.Collection<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 17601, 17620);
                    return return_v;
                }


                string
                f_1253_17662_17678(System.Collections.ObjectModel.Collection<string>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 17662, 17678);
                    return return_v;
                }


                bool
                f_1253_17650_17679(string
                path)
                {
                    var return_v = File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 17650, 17679);
                    return return_v;
                }


                string
                f_1253_17735_17751(System.Collections.ObjectModel.Collection<string>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 17735, 17751);
                    return return_v;
                }


                int
                f_1253_17776_17900(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 17776, 17900);
                    return 0;
                }


                System.Management.Automation.CommandInfo
                f_1253_17934_17955(System.Management.Automation.CommandSearcher
                this_param, string
                path)
                {
                    var return_v = this_param.GetInfoFromPath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 17934, 17955);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1253, 15453, 18046);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1253, 15453, 18046);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Collection<string> GetNextFromPathUsingWildcards(string command, out ProviderInfo provider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1253, 18461, 20480);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 18621, 18784);

                    return f_1253_18628_18783(f_1253_18628_18652(_context), path: command, allowNonexistingPaths: false, provider: out provider, providerInstance: out _);
                }
                catch (ItemNotFoundException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1253, 18813, 19022);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 18875, 19007);

                    f_1253_18875_19006(CommandDiscovery.discoveryTracer, "The path could not be found: {0}", command);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1253, 18813, 19022);
                }
                catch (DriveNotFoundException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1253, 19036, 19258);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 19099, 19243);

                    f_1253_19099_19242(CommandDiscovery.discoveryTracer, "A drive could not be found for the path: {0}", command);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1253, 19036, 19258);
                }
                catch (ProviderNotFoundException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1253, 19272, 19500);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 19338, 19485);

                    f_1253_19338_19484(CommandDiscovery.discoveryTracer, "A provider could not be found for the path: {0}", command);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1253, 19272, 19500);
                }
                catch (InvalidOperationException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1253, 19514, 19780);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 19580, 19765);

                    f_1253_19580_19764(CommandDiscovery.discoveryTracer, "The path specified a home directory, but the provider home directory was not set. {0}", command);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1253, 19514, 19780);
                }
                catch (ProviderInvocationException providerException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1253, 19794, 20112);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 19880, 20097);

                    f_1253_19880_20096(CommandDiscovery.discoveryTracer, "The provider associated with the path '{0}' encountered an error: {1}", command, f_1253_20070_20095(providerException));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1253, 19794, 20112);
                }
                catch (PSNotSupportedException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1253, 20126, 20391);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 20190, 20376);

                    f_1253_20190_20375(CommandDiscovery.discoveryTracer, "The provider associated with the path '{0}' does not implement ContainerCmdletProvider", command);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1253, 20126, 20391);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 20407, 20423);

                provider = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 20437, 20469);

                return f_1253_20444_20468();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1253, 18461, 20480);

                System.Management.Automation.LocationGlobber
                f_1253_18628_18652(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.LocationGlobber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 18628, 18652);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1253_18628_18783(System.Management.Automation.LocationGlobber
                this_param, string
                path, bool
                allowNonexistingPaths, out System.Management.Automation.ProviderInfo
                provider, out System.Management.Automation.Provider.CmdletProvider
                providerInstance)
                {
                    var return_v = this_param.GetGlobbedProviderPathsFromMonadPath(path: path, allowNonexistingPaths: allowNonexistingPaths, out provider, out providerInstance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 18628, 18783);
                    return return_v;
                }


                int
                f_1253_18875_19006(System.Management.Automation.PSTraceSource
                this_param, string
                errorMessageFormat, params object[]
                args)
                {
                    this_param.TraceError(errorMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 18875, 19006);
                    return 0;
                }


                int
                f_1253_19099_19242(System.Management.Automation.PSTraceSource
                this_param, string
                errorMessageFormat, params object[]
                args)
                {
                    this_param.TraceError(errorMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 19099, 19242);
                    return 0;
                }


                int
                f_1253_19338_19484(System.Management.Automation.PSTraceSource
                this_param, string
                errorMessageFormat, params object[]
                args)
                {
                    this_param.TraceError(errorMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 19338, 19484);
                    return 0;
                }


                int
                f_1253_19580_19764(System.Management.Automation.PSTraceSource
                this_param, string
                errorMessageFormat, params object[]
                args)
                {
                    this_param.TraceError(errorMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 19580, 19764);
                    return 0;
                }


                string
                f_1253_20070_20095(System.Management.Automation.ProviderInvocationException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 20070, 20095);
                    return return_v;
                }


                int
                f_1253_19880_20096(System.Management.Automation.PSTraceSource
                this_param, string
                errorMessageFormat, params object[]
                args)
                {
                    this_param.TraceError(errorMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 19880, 20096);
                    return 0;
                }


                int
                f_1253_20190_20375(System.Management.Automation.PSTraceSource
                this_param, string
                errorMessageFormat, params object[]
                args)
                {
                    this_param.TraceError(errorMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 20190, 20375);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1253_20444_20468()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 20444, 20468);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1253, 18461, 20480);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1253, 18461, 20480);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool checkPath(string path, string commandName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1253, 20492, 20662);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 20579, 20651);

                return f_1253_20586_20650(path, commandName, StringComparison.OrdinalIgnoreCase);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1253, 20492, 20662);

                bool
                f_1253_20586_20650(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 20586, 20650);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1253, 20492, 20662);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1253, 20492, 20662);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private CommandInfo GetInfoFromPath(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1253, 21687, 24631);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 21760, 21786);

                CommandInfo
                result = null
                ;
                {
                    try
                    {
                        do // false loop

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 21802, 24356);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 21851, 22044) || true) && (!f_1253_21856_21873(path))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 21851, 22044);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 21915, 21997);

                                f_1253_21915_21996(CommandDiscovery.discoveryTracer, "The path does not exist: {0}", path);
                                DynAbs.Tracing.TraceSender.TraceBreak(1253, 22019, 22025);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 21851, 22044);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 22143, 22167);

                            string
                            extension = null
                            ;

                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 22231, 22267);

                                extension = f_1253_22243_22266(path);
                            }
                            catch (ArgumentException)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1253, 22304, 22804);
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1253, 22304, 22804);
                                // If the path contains illegal characters that
                                // weren't caught by the other APIs, GetExtension
                                // will throw an exception.
                                // For example, looking for a command called
                                // `abcdef
                                // The `a will be translated into the beep control character
                                // which is not a legal file system character.
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 22824, 22948) || true) && (extension == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 22824, 22948);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 22887, 22901);

                                result = null;
                                DynAbs.Tracing.TraceSender.TraceBreak(1253, 22923, 22929);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 22824, 22948);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 22968, 23757) || true) && (f_1253_22972_23078(extension, StringLiterals.PowerShellScriptFileExtension, StringComparison.OrdinalIgnoreCase))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 22968, 23757);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 23120, 23708) || true) && ((_commandTypes & CommandTypes.ExternalScript) != 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 23120, 23708);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 23224, 23267);

                                    string
                                    scriptName = f_1253_23244_23266(path)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 23295, 23500);

                                    f_1253_23295_23499(
                                                            CommandDiscovery.discoveryTracer, "Command Found: path ({0}) is a script with name: {1}", path, scriptName);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 23593, 23653);

                                    result = f_1253_23602_23652(scriptName, path, _context);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1253, 23679, 23685);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 23120, 23708);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(1253, 23732, 23738);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 22968, 23757);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 23777, 24326) || true) && ((_commandTypes & CommandTypes.Application) != 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 23777, 24326);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 23941, 23981);

                                string
                                appName = f_1253_23958_23980(path)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 24005, 24201);

                                f_1253_24005_24200(
                                                    CommandDiscovery.discoveryTracer, "Command Found: path ({0}) is an application with name: {1}", path, appName);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 24225, 24279);

                                result = f_1253_24234_24278(appName, path, _context);
                                DynAbs.Tracing.TraceSender.TraceBreak(1253, 24301, 24307);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 23777, 24326);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 21802, 24356);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 21802, 24356) || true) && (false)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1253, 21802, 24356);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1253, 21802, 24356);
                    }
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 24456, 24590) || true) && (f_1253_24460_24527(this, result, _context))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 24456, 24590);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 24561, 24575);

                    result = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 24456, 24590);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 24606, 24620);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1253, 21687, 24631);

                bool
                f_1253_21856_21873(string
                path)
                {
                    var return_v = File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 21856, 21873);
                    return return_v;
                }


                int
                f_1253_21915_21996(System.Management.Automation.PSTraceSource
                this_param, string
                errorMessageFormat, params object[]
                args)
                {
                    this_param.TraceError(errorMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 21915, 21996);
                    return 0;
                }


                string?
                f_1253_22243_22266(string
                path)
                {
                    var return_v = Path.GetExtension(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 22243, 22266);
                    return return_v;
                }


                bool
                f_1253_22972_23078(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 22972, 23078);
                    return return_v;
                }


                string?
                f_1253_23244_23266(string
                path)
                {
                    var return_v = Path.GetFileName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 23244, 23266);
                    return return_v;
                }


                int
                f_1253_23295_23499(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1, string
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 23295, 23499);
                    return 0;
                }


                System.Management.Automation.ExternalScriptInfo
                f_1253_23602_23652(string
                name, string
                path, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new System.Management.Automation.ExternalScriptInfo(name, path, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 23602, 23652);
                    return return_v;
                }


                string?
                f_1253_23958_23980(string
                path)
                {
                    var return_v = Path.GetFileName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 23958, 23980);
                    return return_v;
                }


                int
                f_1253_24005_24200(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1, string
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 24005, 24200);
                    return 0;
                }


                System.Management.Automation.ApplicationInfo
                f_1253_24234_24278(string
                name, string
                path, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new System.Management.Automation.ApplicationInfo(name, path, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 24234, 24278);
                    return return_v;
                }


                bool
                f_1253_24460_24527(System.Management.Automation.CommandSearcher
                this_param, System.Management.Automation.CommandInfo
                result, System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = this_param.ShouldSkipCommandResolutionForConstrainedLanguage(result, executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 24460, 24527);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1253, 21687, 24631);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1253, 21687, 24631);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private CommandInfo GetNextAlias()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1253, 24870, 27611);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 24929, 24955);

                CommandInfo
                result = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 24971, 27038) || true) && ((_commandResolutionOptions & SearchResolutionOptions.ResolveAliasPatterns) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 24971, 27038);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 25088, 26395) || true) && (_matchingAlias == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 25088, 26395);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 25230, 25298);

                        Collection<AliasInfo>
                        matchingAliases = f_1253_25270_25297()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 25322, 25499);

                        WildcardPattern
                        aliasMatcher =
                        f_1253_25378_25498(_commandName, WildcardOptions.IgnoreCase)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 25523, 26049);
                            foreach (KeyValuePair<string, AliasInfo> aliasEntry in f_1253_25578_25621_I(f_1253_25578_25621(f_1253_25578_25605(_context))))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 25523, 26049);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 25671, 26026) || true) && (f_1253_25675_25711(aliasMatcher, aliasEntry.Key) || (DynAbs.Tracing.TraceSender.Expression_False(1253, 25675, 25903) || (f_1253_25745_25814(_commandResolutionOptions, SearchResolutionOptions.FuzzyMatch) && (DynAbs.Tracing.TraceSender.Expression_True(1253, 25745, 25902) && f_1253_25847_25902(aliasEntry.Key, _commandName)))))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 25671, 26026);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 25961, 25999);

                                    f_1253_25961_25998(matchingAliases, aliasEntry.Value);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 25671, 26026);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 25523, 26049);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1253, 1, 527);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1253, 1, 527);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 26124, 26172);

                        AliasInfo
                        c = f_1253_26138_26171(this, _commandName)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 26194, 26303) || true) && (c != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 26194, 26303);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 26257, 26280);

                            f_1253_26257_26279(matchingAliases, c);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 26194, 26303);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 26327, 26376);

                        _matchingAlias = f_1253_26344_26375(matchingAliases);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 25088, 26395);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 26415, 26755) || true) && (!f_1253_26420_26445(_matchingAlias))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 26415, 26755);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 26529, 26576);

                        _currentState = SearchState.SearchingFunctions;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 26600, 26622);

                        _matchingAlias = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 26415, 26755);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 26415, 26755);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 26704, 26736);

                        result = f_1253_26713_26735(_matchingAlias);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 26415, 26755);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 24971, 27038);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 24971, 27038);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 26859, 26906);

                    _currentState = SearchState.SearchingFunctions;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 26926, 27023);

                    result = f_1253_26935_26985(f_1253_26935_26962(_context), _commandName) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.AliasInfo>(1253, 26935, 27022) ?? f_1253_26989_27022(this, _commandName));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 24971, 27038);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 27189, 27323) || true) && (f_1253_27193_27260(this, result, _context))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 27189, 27323);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 27294, 27308);

                    result = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 27189, 27323);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 27339, 27570) || true) && (result != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 27339, 27570);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 27391, 27555);

                    f_1253_27391_27554(CommandDiscovery.discoveryTracer, "Alias found: {0}  {1}", f_1253_27502_27513(result), f_1253_27536_27553(result));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 27339, 27570);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 27586, 27600);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1253, 24870, 27611);

                System.Collections.ObjectModel.Collection<System.Management.Automation.AliasInfo>
                f_1253_25270_25297()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.AliasInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 25270, 25297);
                    return return_v;
                }


                System.Management.Automation.WildcardPattern
                f_1253_25378_25498(string
                pattern, System.Management.Automation.WildcardOptions
                options)
                {
                    var return_v = WildcardPattern.Get(pattern, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 25378, 25498);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1253_25578_25605(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 25578, 25605);
                    return return_v;
                }


                System.Collections.Generic.IDictionary<string, System.Management.Automation.AliasInfo>
                f_1253_25578_25621(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.GetAliasTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 25578, 25621);
                    return return_v;
                }


                bool
                f_1253_25675_25711(System.Management.Automation.WildcardPattern
                this_param, string
                input)
                {
                    var return_v = this_param.IsMatch(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 25675, 25711);
                    return return_v;
                }


                bool
                f_1253_25745_25814(System.Management.Automation.SearchResolutionOptions
                this_param, System.Management.Automation.SearchResolutionOptions
                flag)
                {
                    var return_v = this_param.HasFlag((System.Enum)flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 25745, 25814);
                    return return_v;
                }


                bool
                f_1253_25847_25902(string
                string1, string
                string2)
                {
                    var return_v = FuzzyMatcher.IsFuzzyMatch(string1, string2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 25847, 25902);
                    return return_v;
                }


                int
                f_1253_25961_25998(System.Collections.ObjectModel.Collection<System.Management.Automation.AliasInfo>
                this_param, System.Management.Automation.AliasInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 25961, 25998);
                    return 0;
                }


                System.Collections.Generic.IDictionary<string, System.Management.Automation.AliasInfo>
                f_1253_25578_25621_I(System.Collections.Generic.IDictionary<string, System.Management.Automation.AliasInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 25578, 25621);
                    return return_v;
                }


                System.Management.Automation.AliasInfo
                f_1253_26138_26171(System.Management.Automation.CommandSearcher
                this_param, string
                command)
                {
                    var return_v = this_param.GetAliasFromModules(command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 26138, 26171);
                    return return_v;
                }


                int
                f_1253_26257_26279(System.Collections.ObjectModel.Collection<System.Management.Automation.AliasInfo>
                this_param, System.Management.Automation.AliasInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 26257, 26279);
                    return 0;
                }


                System.Collections.Generic.IEnumerator<System.Management.Automation.AliasInfo>
                f_1253_26344_26375(System.Collections.ObjectModel.Collection<System.Management.Automation.AliasInfo>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 26344, 26375);
                    return return_v;
                }


                bool
                f_1253_26420_26445(System.Collections.Generic.IEnumerator<System.Management.Automation.AliasInfo>
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 26420, 26445);
                    return return_v;
                }


                System.Management.Automation.AliasInfo
                f_1253_26713_26735(System.Collections.Generic.IEnumerator<System.Management.Automation.AliasInfo>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 26713, 26735);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1253_26935_26962(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 26935, 26962);
                    return return_v;
                }


                System.Management.Automation.AliasInfo
                f_1253_26935_26985(System.Management.Automation.SessionStateInternal
                this_param, string
                aliasName)
                {
                    var return_v = this_param.GetAlias(aliasName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 26935, 26985);
                    return return_v;
                }


                System.Management.Automation.AliasInfo
                f_1253_26989_27022(System.Management.Automation.CommandSearcher
                this_param, string
                command)
                {
                    var return_v = this_param.GetAliasFromModules(command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 26989, 27022);
                    return return_v;
                }


                bool
                f_1253_27193_27260(System.Management.Automation.CommandSearcher
                this_param, System.Management.Automation.CommandInfo
                result, System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = this_param.ShouldSkipCommandResolutionForConstrainedLanguage(result, executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 27193, 27260);
                    return return_v;
                }


                string
                f_1253_27502_27513(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 27502, 27513);
                    return return_v;
                }


                string
                f_1253_27536_27553(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Definition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 27536, 27553);
                    return return_v;
                }


                int
                f_1253_27391_27554(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1, string
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 27391, 27554);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1253, 24870, 27611);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1253, 24870, 27611);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private CommandInfo GetNextFunction()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1253, 27856, 30900);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 27918, 27944);

                CommandInfo
                result = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 27960, 30571) || true) && (f_1253_27964_28046(_commandResolutionOptions, SearchResolutionOptions.ResolveFunctionPatterns))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 27960, 30571);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 28080, 29955) || true) && (_matchingFunctionEnumerator == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 28080, 29955);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 28161, 28234);

                        Collection<CommandInfo>
                        matchingFunction = f_1253_28204_28233()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 28333, 28513);

                        WildcardPattern
                        functionMatcher =
                        f_1253_28392_28512(_commandName, WildcardOptions.IgnoreCase)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 28537, 29567);
                            foreach (DictionaryEntry functionEntry in f_1253_28579_28625_I(f_1253_28579_28625(f_1253_28579_28606(_context))))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 28537, 29567);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 28675, 29544) || true) && (f_1253_28679_28729(functionMatcher, functionEntry.Key) || (DynAbs.Tracing.TraceSender.Expression_False(1253, 28679, 28935) || (f_1253_28763_28832(_commandResolutionOptions, SearchResolutionOptions.FuzzyMatch) && (DynAbs.Tracing.TraceSender.Expression_True(1253, 28763, 28934) && f_1253_28865_28934(f_1253_28891_28919(functionEntry.Key), _commandName)))))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 28675, 29544);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 28993, 29048);

                                    f_1253_28993_29047(matchingFunction, functionEntry.Value);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 28675, 29544);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 28675, 29544);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 29106, 29544) || true) && (f_1253_29110_29193(_commandResolutionOptions, SearchResolutionOptions.UseAbbreviationExpansion))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 29106, 29544);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 29251, 29517) || true) && (f_1253_29255_29365(_commandName, f_1253_29275_29328(functionEntry.Key), StringComparison.OrdinalIgnoreCase))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 29251, 29517);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 29431, 29486);

                                            f_1253_29431_29485(matchingFunction, functionEntry.Value);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 29251, 29517);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 29106, 29544);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 28675, 29544);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 28537, 29567);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1253, 1, 1031);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1253, 1, 1031);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 29646, 29705);

                        CommandInfo
                        cmdInfo = f_1253_29668_29704(this, _commandName)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 29727, 29849) || true) && (cmdInfo != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 29727, 29849);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 29796, 29826);

                            f_1253_29796_29825(matchingFunction, cmdInfo);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 29727, 29849);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 29873, 29936);

                        _matchingFunctionEnumerator = f_1253_29903_29935(matchingFunction);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 28080, 29955);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 29975, 30352) || true) && (!f_1253_29980_30018(_matchingFunctionEnumerator))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 29975, 30352);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 30102, 30147);

                        _currentState = SearchState.SearchingCmdlets;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 30171, 30206);

                        _matchingFunctionEnumerator = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 29975, 30352);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 29975, 30352);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 30288, 30333);

                        result = f_1253_30297_30332(_matchingFunctionEnumerator);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 29975, 30352);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 27960, 30571);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 27960, 30571);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 30456, 30501);

                    _currentState = SearchState.SearchingCmdlets;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 30521, 30556);

                    result = f_1253_30530_30555(this, _commandName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 27960, 30571);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 30725, 30859) || true) && (f_1253_30729_30796(this, result, _context))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 30725, 30859);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 30830, 30844);

                    result = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 30725, 30859);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 30875, 30889);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1253, 27856, 30900);

                bool
                f_1253_27964_28046(System.Management.Automation.SearchResolutionOptions
                this_param, System.Management.Automation.SearchResolutionOptions
                flag)
                {
                    var return_v = this_param.HasFlag((System.Enum)flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 27964, 28046);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.CommandInfo>
                f_1253_28204_28233()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.CommandInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 28204, 28233);
                    return return_v;
                }


                System.Management.Automation.WildcardPattern
                f_1253_28392_28512(string
                pattern, System.Management.Automation.WildcardOptions
                options)
                {
                    var return_v = WildcardPattern.Get(pattern, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 28392, 28512);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1253_28579_28606(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 28579, 28606);
                    return return_v;
                }


                System.Collections.IDictionary
                f_1253_28579_28625(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.GetFunctionTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 28579, 28625);
                    return return_v;
                }


                bool
                f_1253_28679_28729(System.Management.Automation.WildcardPattern
                this_param, object
                input)
                {
                    var return_v = this_param.IsMatch((string)input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 28679, 28729);
                    return return_v;
                }


                bool
                f_1253_28763_28832(System.Management.Automation.SearchResolutionOptions
                this_param, System.Management.Automation.SearchResolutionOptions
                flag)
                {
                    var return_v = this_param.HasFlag((System.Enum)flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 28763, 28832);
                    return return_v;
                }


                string?
                f_1253_28891_28919(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 28891, 28919);
                    return return_v;
                }


                bool
                f_1253_28865_28934(string
                string1, string
                string2)
                {
                    var return_v = FuzzyMatcher.IsFuzzyMatch(string1, string2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 28865, 28934);
                    return return_v;
                }


                int
                f_1253_28993_29047(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandInfo>
                this_param, object
                item)
                {
                    this_param.Add((System.Management.Automation.CommandInfo)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 28993, 29047);
                    return 0;
                }


                bool
                f_1253_29110_29193(System.Management.Automation.SearchResolutionOptions
                this_param, System.Management.Automation.SearchResolutionOptions
                flag)
                {
                    var return_v = this_param.HasFlag((System.Enum)flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 29110, 29193);
                    return return_v;
                }


                string
                f_1253_29275_29328(object
                commandName)
                {
                    var return_v = ModuleUtils.AbbreviateName((string)commandName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 29275, 29328);
                    return return_v;
                }


                bool
                f_1253_29255_29365(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 29255, 29365);
                    return return_v;
                }


                int
                f_1253_29431_29485(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandInfo>
                this_param, object
                item)
                {
                    this_param.Add((System.Management.Automation.CommandInfo)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 29431, 29485);
                    return 0;
                }


                System.Collections.IDictionary
                f_1253_28579_28625_I(System.Collections.IDictionary
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 28579, 28625);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1253_29668_29704(System.Management.Automation.CommandSearcher
                this_param, string
                command)
                {
                    var return_v = this_param.GetFunctionFromModules(command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 29668, 29704);
                    return return_v;
                }


                int
                f_1253_29796_29825(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandInfo>
                this_param, System.Management.Automation.CommandInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 29796, 29825);
                    return 0;
                }


                System.Collections.Generic.IEnumerator<System.Management.Automation.CommandInfo>
                f_1253_29903_29935(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandInfo>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 29903, 29935);
                    return return_v;
                }


                bool
                f_1253_29980_30018(System.Collections.Generic.IEnumerator<System.Management.Automation.CommandInfo>
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 29980, 30018);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1253_30297_30332(System.Collections.Generic.IEnumerator<System.Management.Automation.CommandInfo>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 30297, 30332);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1253_30530_30555(System.Management.Automation.CommandSearcher
                this_param, string
                function)
                {
                    var return_v = this_param.GetFunction(function);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 30530, 30555);
                    return return_v;
                }


                bool
                f_1253_30729_30796(System.Management.Automation.CommandSearcher
                this_param, System.Management.Automation.CommandInfo
                result, System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = this_param.ShouldSkipCommandResolutionForConstrainedLanguage(result, executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 30729, 30796);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1253, 27856, 30900);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1253, 27856, 30900);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool ShouldSkipCommandResolutionForConstrainedLanguage(CommandInfo result, ExecutionContext executionContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1253, 31173, 32642);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 31315, 31395) || true) && (result == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 31315, 31395);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 31367, 31380);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 31315, 31395);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 31480, 31695) || true) && ((f_1253_31485_31512(result) == PSLanguageMode.ConstrainedLanguage) && (DynAbs.Tracing.TraceSender.Expression_True(1253, 31484, 31634) && (f_1253_31573_31602(executionContext) == PSLanguageMode.FullLanguage)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 31480, 31695);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 31668, 31680);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 31480, 31695);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 32103, 32602) || true) && ((result is FunctionInfo) && (DynAbs.Tracing.TraceSender.Expression_True(1253, 32107, 32221) && (f_1253_32153_32182(executionContext) == PSLanguageMode.ConstrainedLanguage)) && (DynAbs.Tracing.TraceSender.Expression_True(1253, 32107, 32302) && (f_1253_32243_32270(result) == PSLanguageMode.FullLanguage)) && (DynAbs.Tracing.TraceSender.Expression_True(1253, 32107, 32358) && (f_1253_32324_32349(executionContext) != null)) && (DynAbs.Tracing.TraceSender.Expression_True(1253, 32107, 32419) && (f_1253_32380_32418(f_1253_32380_32405(executionContext)))) && (DynAbs.Tracing.TraceSender.Expression_True(1253, 32107, 32541) && (!(f_1253_32443_32539(f_1253_32443_32514(f_1253_32443_32480(executionContext), "GLOBAL"), f_1253_32527_32538(result))))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 32103, 32602);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 32575, 32587);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 32103, 32602);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 32618, 32631);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1253, 31173, 32642);

                System.Management.Automation.PSLanguageMode?
                f_1253_31485_31512(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.DefiningLanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 31485, 31512);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1253_31573_31602(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 31573, 31602);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1253_32153_32182(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 32153, 32182);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode?
                f_1253_32243_32270(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.DefiningLanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 32243, 32270);
                    return return_v;
                }


                System.Management.Automation.ScriptDebugger
                f_1253_32324_32349(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Debugger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 32324, 32349);
                    return return_v;
                }


                System.Management.Automation.ScriptDebugger
                f_1253_32380_32405(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Debugger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 32380, 32405);
                    return return_v;
                }


                bool
                f_1253_32380_32418(System.Management.Automation.ScriptDebugger
                this_param)
                {
                    var return_v = this_param.InBreakpoint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 32380, 32418);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1253_32443_32480(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.TopLevelSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 32443, 32480);
                    return return_v;
                }


                System.Collections.Generic.IDictionary<string, System.Management.Automation.FunctionInfo>
                f_1253_32443_32514(System.Management.Automation.SessionStateInternal
                this_param, string
                scopeID)
                {
                    var return_v = this_param.GetFunctionTableAtScope(scopeID);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 32443, 32514);
                    return return_v;
                }


                string
                f_1253_32527_32538(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 32527, 32538);
                    return return_v;
                }


                bool
                f_1253_32443_32539(System.Collections.Generic.IDictionary<string, System.Management.Automation.FunctionInfo>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 32443, 32539);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1253, 31173, 32642);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1253, 31173, 32642);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private AliasInfo GetAliasFromModules(string command)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1253, 32654, 33450);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 32732, 32756);

                AliasInfo
                result = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 32772, 33409) || true) && (f_1253_32776_32797(command, '\\') > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 32772, 33409);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 32895, 32976);

                    PSSnapinQualifiedName
                    qualifiedName = f_1253_32933_32975(command)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 32994, 33394) || true) && (qualifiedName != null && (DynAbs.Tracing.TraceSender.Expression_True(1253, 32998, 33072) && !f_1253_33024_33072(f_1253_33045_33071(qualifiedName))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 32994, 33394);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 33114, 33188);

                        PSModuleInfo
                        module = f_1253_33136_33187(this, f_1253_33160_33186(qualifiedName))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 33212, 33375) || true) && (module != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 33212, 33375);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 33280, 33352);

                            f_1253_33280_33351(f_1253_33280_33302(module), f_1253_33315_33338(qualifiedName), out result);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 33212, 33375);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 32994, 33394);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 32772, 33409);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 33425, 33439);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1253, 32654, 33450);

                int
                f_1253_32776_32797(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 32776, 32797);
                    return return_v;
                }


                System.Management.Automation.PSSnapinQualifiedName
                f_1253_32933_32975(string
                name)
                {
                    var return_v = PSSnapinQualifiedName.GetInstance(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 32933, 32975);
                    return return_v;
                }


                string
                f_1253_33045_33071(System.Management.Automation.PSSnapinQualifiedName
                this_param)
                {
                    var return_v = this_param.PSSnapInName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 33045, 33071);
                    return return_v;
                }


                bool
                f_1253_33024_33072(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 33024, 33072);
                    return return_v;
                }


                string
                f_1253_33160_33186(System.Management.Automation.PSSnapinQualifiedName
                this_param)
                {
                    var return_v = this_param.PSSnapInName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 33160, 33186);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1253_33136_33187(System.Management.Automation.CommandSearcher
                this_param, string
                moduleName)
                {
                    var return_v = this_param.GetImportedModuleByName(moduleName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 33136, 33187);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.AliasInfo>
                f_1253_33280_33302(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.ExportedAliases;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 33280, 33302);
                    return return_v;
                }


                string
                f_1253_33315_33338(System.Management.Automation.PSSnapinQualifiedName
                this_param)
                {
                    var return_v = this_param.ShortName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 33315, 33338);
                    return return_v;
                }


                bool
                f_1253_33280_33351(System.Collections.Generic.Dictionary<string, System.Management.Automation.AliasInfo>
                this_param, string
                key, out System.Management.Automation.AliasInfo
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 33280, 33351);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1253, 32654, 33450);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1253, 32654, 33450);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private CommandInfo GetFunctionFromModules(string command)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1253, 33462, 34276);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 33545, 33572);

                FunctionInfo
                result = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 33588, 34235) || true) && (f_1253_33592_33613(command, '\\') > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 33588, 34235);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 33719, 33800);

                    PSSnapinQualifiedName
                    qualifiedName = f_1253_33757_33799(command)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 33818, 34220) || true) && (qualifiedName != null && (DynAbs.Tracing.TraceSender.Expression_True(1253, 33822, 33896) && !f_1253_33848_33896(f_1253_33869_33895(qualifiedName))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 33818, 34220);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 33938, 34012);

                        PSModuleInfo
                        module = f_1253_33960_34011(this, f_1253_33984_34010(qualifiedName))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 34036, 34201) || true) && (module != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 34036, 34201);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 34104, 34178);

                            f_1253_34104_34177(f_1253_34104_34128(module), f_1253_34141_34164(qualifiedName), out result);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 34036, 34201);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 33818, 34220);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 33588, 34235);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 34251, 34265);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1253, 33462, 34276);

                int
                f_1253_33592_33613(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 33592, 33613);
                    return return_v;
                }


                System.Management.Automation.PSSnapinQualifiedName
                f_1253_33757_33799(string
                name)
                {
                    var return_v = PSSnapinQualifiedName.GetInstance(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 33757, 33799);
                    return return_v;
                }


                string
                f_1253_33869_33895(System.Management.Automation.PSSnapinQualifiedName
                this_param)
                {
                    var return_v = this_param.PSSnapInName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 33869, 33895);
                    return return_v;
                }


                bool
                f_1253_33848_33896(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 33848, 33896);
                    return return_v;
                }


                string
                f_1253_33984_34010(System.Management.Automation.PSSnapinQualifiedName
                this_param)
                {
                    var return_v = this_param.PSSnapInName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 33984, 34010);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1253_33960_34011(System.Management.Automation.CommandSearcher
                this_param, string
                moduleName)
                {
                    var return_v = this_param.GetImportedModuleByName(moduleName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 33960, 34011);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>
                f_1253_34104_34128(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.ExportedFunctions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 34104, 34128);
                    return return_v;
                }


                string
                f_1253_34141_34164(System.Management.Automation.PSSnapinQualifiedName
                this_param)
                {
                    var return_v = this_param.ShortName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 34141, 34164);
                    return return_v;
                }


                bool
                f_1253_34104_34177(System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>
                this_param, string
                key, out System.Management.Automation.FunctionInfo
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 34104, 34177);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1253, 33462, 34276);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1253, 33462, 34276);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private PSModuleInfo GetImportedModuleByName(string moduleName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1253, 34288, 35104);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 34376, 34403);

                PSModuleInfo
                module = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 34417, 34510);

                List<PSModuleInfo>
                modules = f_1253_34446_34509(f_1253_34446_34462(_context), new string[] { moduleName }, false)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 34526, 35063) || true) && (modules != null && (DynAbs.Tracing.TraceSender.Expression_True(1253, 34530, 34566) && f_1253_34549_34562(modules) > 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 34526, 35063);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 34600, 34929);
                        foreach (PSModuleInfo m in f_1253_34627_34634_I(modules))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 34600, 34929);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 34676, 34910) || true) && (f_1253_34680_34731(f_1253_34680_34711(_context), f_1253_34724_34730(m)) && (DynAbs.Tracing.TraceSender.Expression_True(1253, 34680, 34794) && ((string)f_1253_34744_34783(f_1253_34744_34775(_context), f_1253_34776_34782(m)) == f_1253_34787_34793(m))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 34676, 34910);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 34844, 34855);

                                module = m;
                                DynAbs.Tracing.TraceSender.TraceBreak(1253, 34881, 34887);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 34676, 34910);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 34600, 34929);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1253, 1, 330);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1253, 1, 330);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 34949, 35048) || true) && (module == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 34949, 35048);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 35009, 35029);

                        module = f_1253_35018_35028(modules, 0);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 34949, 35048);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 34526, 35063);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 35079, 35093);

                return module;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1253, 34288, 35104);

                System.Management.Automation.ModuleIntrinsics
                f_1253_34446_34462(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Modules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 34446, 34462);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                f_1253_34446_34509(System.Management.Automation.ModuleIntrinsics
                this_param, string[]
                patterns, bool
                all)
                {
                    var return_v = this_param.GetModules(patterns, all);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 34446, 34509);
                    return return_v;
                }


                int
                f_1253_34549_34562(System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 34549, 34562);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1253_34680_34711(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.previousModuleImported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 34680, 34711);
                    return return_v;
                }


                string
                f_1253_34724_34730(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 34724, 34730);
                    return return_v;
                }


                bool
                f_1253_34680_34731(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 34680, 34731);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1253_34744_34775(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.previousModuleImported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 34744, 34775);
                    return return_v;
                }


                string
                f_1253_34776_34782(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 34776, 34782);
                    return return_v;
                }


                object
                f_1253_34744_34783(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 34744, 34783);
                    return return_v;
                }


                string
                f_1253_34787_34793(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 34787, 34793);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                f_1253_34627_34634_I(System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 34627, 34634);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1253_35018_35028(System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 35018, 35028);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1253, 34288, 35104);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1253, 34288, 35104);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private CommandInfo GetFunction(string function)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1253, 35572, 36619);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 35645, 35716);

                CommandInfo
                result = f_1253_35666_35715(f_1253_35666_35693(_context), function)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 35732, 36578) || true) && (result != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 35732, 36578);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 35784, 36455) || true) && (result is FilterInfo)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 35784, 36455);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 35850, 35975);

                        f_1253_35850_35974(CommandDiscovery.discoveryTracer, "Filter found: {0}", function);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 35784, 36455);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 35784, 36455);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 36017, 36455) || true) && (result is ConfigurationInfo)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 36017, 36455);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 36090, 36222);

                            f_1253_36090_36221(CommandDiscovery.discoveryTracer, "Configuration found: {0}", function);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 36017, 36455);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 36017, 36455);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 36304, 36436);

                            f_1253_36304_36435(CommandDiscovery.discoveryTracer, "Function found: {0}  {1}", function);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 36017, 36455);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 35784, 36455);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 35732, 36578);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 35732, 36578);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 36521, 36563);

                    result = f_1253_36530_36562(this, function);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 35732, 36578);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 36594, 36608);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1253, 35572, 36619);

                System.Management.Automation.SessionStateInternal
                f_1253_35666_35693(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 35666, 35693);
                    return return_v;
                }


                System.Management.Automation.FunctionInfo
                f_1253_35666_35715(System.Management.Automation.SessionStateInternal
                this_param, string
                name)
                {
                    var return_v = this_param.GetFunction(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 35666, 35715);
                    return return_v;
                }


                int
                f_1253_35850_35974(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 35850, 35974);
                    return 0;
                }


                int
                f_1253_36090_36221(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 36090, 36221);
                    return 0;
                }


                int
                f_1253_36304_36435(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 36304, 36435);
                    return 0;
                }


                System.Management.Automation.CommandInfo
                f_1253_36530_36562(System.Management.Automation.CommandSearcher
                this_param, string
                command)
                {
                    var return_v = this_param.GetFunctionFromModules(command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 36530, 36562);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1253, 35572, 36619);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1253, 35572, 36619);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private CmdletInfo GetNextCmdlet()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1253, 37047, 40458);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 37106, 37131);

                CmdletInfo
                result = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 37145, 37261);

                bool
                useAbbreviationExpansion = f_1253_37177_37260(_commandResolutionOptions, SearchResolutionOptions.UseAbbreviationExpansion)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 37277, 40066) || true) && (_matchingCmdlet == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 37277, 40066);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 37338, 40051) || true) && (f_1253_37342_37421(_commandResolutionOptions, SearchResolutionOptions.CommandNameIsPattern) || (DynAbs.Tracing.TraceSender.Expression_False(1253, 37342, 37449) || useAbbreviationExpansion))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 37338, 40051);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 37491, 37564);

                        Collection<CmdletInfo>
                        matchingCmdletInfo = f_1253_37535_37563()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 37588, 37714);

                        PSSnapinQualifiedName
                        PSSnapinQualifiedCommandName =
                        f_1253_37666_37713(_commandName)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 37738, 37892) || true) && (!useAbbreviationExpansion && (DynAbs.Tracing.TraceSender.Expression_True(1253, 37742, 37807) && PSSnapinQualifiedCommandName == null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 37738, 37892);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 37857, 37869);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 37738, 37892);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 37916, 38120);

                        WildcardPattern
                        cmdletMatcher =
                        f_1253_37973_38119(f_1253_38023_38061(PSSnapinQualifiedCommandName), WildcardOptions.IgnoreCase)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 38144, 38198);

                        SessionStateInternal
                        ss = f_1253_38170_38197(_context)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 38222, 39700);
                            foreach (List<CmdletInfo> cmdletList in f_1253_38262_38288_I(f_1253_38262_38288(f_1253_38262_38281(ss))))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 38222, 39700);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 38338, 39677);
                                    foreach (CmdletInfo cmdlet in f_1253_38368_38378_I(cmdletList))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 38338, 39677);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 38436, 39650) || true) && (f_1253_38440_38474(cmdletMatcher, f_1253_38462_38473(cmdlet)) || (DynAbs.Tracing.TraceSender.Expression_False(1253, 38440, 38671) || (f_1253_38512_38581(_commandResolutionOptions, SearchResolutionOptions.FuzzyMatch) && (DynAbs.Tracing.TraceSender.Expression_True(1253, 38512, 38670) && f_1253_38618_38670(f_1253_38644_38655(cmdlet), _commandName)))))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 38436, 39650);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 38737, 39219) || true) && (f_1253_38741_38804(f_1253_38762_38803(PSSnapinQualifiedCommandName)) || (DynAbs.Tracing.TraceSender.Expression_False(1253, 38741, 38992) || (f_1253_38846_38991(f_1253_38846_38887(PSSnapinQualifiedCommandName), f_1253_38937_38954(cmdlet), StringComparison.OrdinalIgnoreCase))))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 38737, 39219);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 39153, 39184);

                                                f_1253_39153_39183(                                    // If PSSnapin is specified, make sure they match
                                                                                    matchingCmdletInfo, cmdlet);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 38737, 39219);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 38436, 39650);
                                        }

                                        else
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 38436, 39650);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 39285, 39650) || true) && (useAbbreviationExpansion)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 39285, 39650);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 39379, 39619) || true) && (f_1253_39383_39479(_commandName, f_1253_39403_39442(f_1253_39430_39441(cmdlet)), StringComparison.OrdinalIgnoreCase))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 39379, 39619);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 39553, 39584);

                                                    f_1253_39553_39583(matchingCmdletInfo, cmdlet);
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 39379, 39619);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 39285, 39650);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 38436, 39650);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 38338, 39677);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1253, 1, 1340);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1253, 1, 1340);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 38222, 39700);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1253, 1, 1479);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1253, 1, 1479);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 39724, 39777);

                        _matchingCmdlet = f_1253_39742_39776(matchingCmdletInfo);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 37338, 40051);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 37338, 40051);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 39859, 40032);

                        _matchingCmdlet = f_1253_39877_40031(f_1253_39877_39902(_context), _commandName, f_1253_39956_40030(_commandResolutionOptions, SearchResolutionOptions.SearchAllScopes));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 37338, 40051);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 37277, 40066);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 40082, 40404) || true) && (!f_1253_40087_40113(_matchingCmdlet))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 40082, 40404);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 40185, 40247);

                    _currentState = SearchState.StartSearchingForExternalCommands;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 40267, 40290);

                    _matchingCmdlet = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 40082, 40404);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 40082, 40404);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 40356, 40389);

                    result = f_1253_40365_40388(_matchingCmdlet);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 40082, 40404);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 40420, 40447);

                return f_1253_40427_40446(result);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1253, 37047, 40458);

                bool
                f_1253_37177_37260(System.Management.Automation.SearchResolutionOptions
                this_param, System.Management.Automation.SearchResolutionOptions
                flag)
                {
                    var return_v = this_param.HasFlag((System.Enum)flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 37177, 37260);
                    return return_v;
                }


                bool
                f_1253_37342_37421(System.Management.Automation.SearchResolutionOptions
                this_param, System.Management.Automation.SearchResolutionOptions
                flag)
                {
                    var return_v = this_param.HasFlag((System.Enum)flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 37342, 37421);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.CmdletInfo>
                f_1253_37535_37563()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.CmdletInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 37535, 37563);
                    return return_v;
                }


                System.Management.Automation.PSSnapinQualifiedName
                f_1253_37666_37713(string
                name)
                {
                    var return_v = PSSnapinQualifiedName.GetInstance(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 37666, 37713);
                    return return_v;
                }


                string
                f_1253_38023_38061(System.Management.Automation.PSSnapinQualifiedName
                this_param)
                {
                    var return_v = this_param.ShortName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 38023, 38061);
                    return return_v;
                }


                System.Management.Automation.WildcardPattern
                f_1253_37973_38119(string
                pattern, System.Management.Automation.WildcardOptions
                options)
                {
                    var return_v = WildcardPattern.Get(pattern, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 37973, 38119);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1253_38170_38197(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 38170, 38197);
                    return return_v;
                }


                System.Collections.Generic.IDictionary<string, System.Collections.Generic.List<System.Management.Automation.CmdletInfo>>
                f_1253_38262_38281(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.GetCmdletTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 38262, 38281);
                    return return_v;
                }


                System.Collections.Generic.ICollection<System.Collections.Generic.List<System.Management.Automation.CmdletInfo>>
                f_1253_38262_38288(System.Collections.Generic.IDictionary<string, System.Collections.Generic.List<System.Management.Automation.CmdletInfo>>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 38262, 38288);
                    return return_v;
                }


                string
                f_1253_38462_38473(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 38462, 38473);
                    return return_v;
                }


                bool
                f_1253_38440_38474(System.Management.Automation.WildcardPattern
                this_param, string
                input)
                {
                    var return_v = this_param.IsMatch(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 38440, 38474);
                    return return_v;
                }


                bool
                f_1253_38512_38581(System.Management.Automation.SearchResolutionOptions
                this_param, System.Management.Automation.SearchResolutionOptions
                flag)
                {
                    var return_v = this_param.HasFlag((System.Enum)flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 38512, 38581);
                    return return_v;
                }


                string
                f_1253_38644_38655(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 38644, 38655);
                    return return_v;
                }


                bool
                f_1253_38618_38670(string
                string1, string
                string2)
                {
                    var return_v = FuzzyMatcher.IsFuzzyMatch(string1, string2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 38618, 38670);
                    return return_v;
                }


                string
                f_1253_38762_38803(System.Management.Automation.PSSnapinQualifiedName
                this_param)
                {
                    var return_v = this_param.PSSnapInName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 38762, 38803);
                    return return_v;
                }


                bool
                f_1253_38741_38804(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 38741, 38804);
                    return return_v;
                }


                string
                f_1253_38846_38887(System.Management.Automation.PSSnapinQualifiedName
                this_param)
                {
                    var return_v = this_param.PSSnapInName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 38846, 38887);
                    return return_v;
                }


                string
                f_1253_38937_38954(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 38937, 38954);
                    return return_v;
                }


                bool
                f_1253_38846_38991(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 38846, 38991);
                    return return_v;
                }


                int
                f_1253_39153_39183(System.Collections.ObjectModel.Collection<System.Management.Automation.CmdletInfo>
                this_param, System.Management.Automation.CmdletInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 39153, 39183);
                    return 0;
                }


                string
                f_1253_39430_39441(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 39430, 39441);
                    return return_v;
                }


                string
                f_1253_39403_39442(string
                commandName)
                {
                    var return_v = ModuleUtils.AbbreviateName(commandName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 39403, 39442);
                    return return_v;
                }


                bool
                f_1253_39383_39479(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 39383, 39479);
                    return return_v;
                }


                int
                f_1253_39553_39583(System.Collections.ObjectModel.Collection<System.Management.Automation.CmdletInfo>
                this_param, System.Management.Automation.CmdletInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 39553, 39583);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
                f_1253_38368_38378_I(System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 38368, 38378);
                    return return_v;
                }


                System.Collections.Generic.ICollection<System.Collections.Generic.List<System.Management.Automation.CmdletInfo>>
                f_1253_38262_38288_I(System.Collections.Generic.ICollection<System.Collections.Generic.List<System.Management.Automation.CmdletInfo>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 38262, 38288);
                    return return_v;
                }


                System.Collections.Generic.IEnumerator<System.Management.Automation.CmdletInfo>
                f_1253_39742_39776(System.Collections.ObjectModel.Collection<System.Management.Automation.CmdletInfo>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 39742, 39776);
                    return return_v;
                }


                System.Management.Automation.CommandDiscovery
                f_1253_39877_39902(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CommandDiscovery;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 39877, 39902);
                    return return_v;
                }


                bool
                f_1253_39956_40030(System.Management.Automation.SearchResolutionOptions
                this_param, System.Management.Automation.SearchResolutionOptions
                flag)
                {
                    var return_v = this_param.HasFlag((System.Enum)flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 39956, 40030);
                    return return_v;
                }


                System.Collections.Generic.IEnumerator<System.Management.Automation.CmdletInfo>
                f_1253_39877_40031(System.Management.Automation.CommandDiscovery
                this_param, string
                cmdletName, bool
                searchAllScopes)
                {
                    var return_v = this_param.GetCmdletInfo(cmdletName, searchAllScopes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 39877, 40031);
                    return return_v;
                }


                bool
                f_1253_40087_40113(System.Collections.Generic.IEnumerator<System.Management.Automation.CmdletInfo>
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 40087, 40113);
                    return return_v;
                }


                System.Management.Automation.CmdletInfo
                f_1253_40365_40388(System.Collections.Generic.IEnumerator<System.Management.Automation.CmdletInfo>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 40365, 40388);
                    return return_v;
                }


                System.Management.Automation.CmdletInfo
                f_1253_40427_40446(System.Management.Automation.CmdletInfo
                result)
                {
                    var return_v = traceResult(result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 40427, 40446);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1253, 37047, 40458);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1253, 37047, 40458);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private IEnumerator<CmdletInfo> _matchingCmdlet;

        private static CmdletInfo traceResult(CmdletInfo result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1253, 40530, 40890);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 40611, 40849) || true) && (result != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 40611, 40849);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 40663, 40834);

                    f_1253_40663_40833(CommandDiscovery.discoveryTracer, "Cmdlet found: {0}  {1}", f_1253_40775_40786(result), f_1253_40809_40832(result));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 40611, 40849);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 40865, 40879);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1253, 40530, 40890);

                string
                f_1253_40775_40786(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 40775, 40786);
                    return return_v;
                }


                System.Type
                f_1253_40809_40832(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.ImplementingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 40809, 40832);
                    return return_v;
                }


                int
                f_1253_40663_40833(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1, System.Type
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 40663, 40833);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1253, 40530, 40890);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1253, 40530, 40890);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string DoPowerShellRelativePathLookup()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1253, 40902, 42298);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 40974, 40995);

                string
                result = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 41011, 42257) || true) && (f_1253_41015_41042(_context) != null && (DynAbs.Tracing.TraceSender.Expression_True(1253, 41015, 41116) && f_1253_41071_41112(f_1253_41071_41098(_context)) > 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 41011, 42257);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 41807, 42242) || true) && (f_1253_41811_41826(_commandName, 0) == '.' || (DynAbs.Tracing.TraceSender.Expression_False(1253, 41811, 41859) || f_1253_41837_41852(_commandName, 0) == '~') || (DynAbs.Tracing.TraceSender.Expression_False(1253, 41811, 41886) || f_1253_41863_41878(_commandName, 0) == '\\'))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 41807, 42242);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 41928, 42223);
                        using (f_1253_41935_42113(CommandDiscovery.discoveryTracer, "{0} appears to be a relative path. Trying to resolve relative path", _commandName))
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 42163, 42200);

                            result = f_1253_42172_42199(this, _commandName);
                            DynAbs.Tracing.TraceSender.TraceExitUsing(1253, 41928, 42223);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 41807, 42242);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 41011, 42257);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 42273, 42287);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1253, 40902, 42298);

                System.Management.Automation.SessionStateInternal
                f_1253_41015_41042(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 41015, 41042);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1253_41071_41098(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 41071, 41098);
                    return return_v;
                }


                int
                f_1253_41071_41112(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ProviderCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 41071, 41112);
                    return return_v;
                }


                char
                f_1253_41811_41826(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 41811, 41826);
                    return return_v;
                }


                char
                f_1253_41837_41852(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 41837, 41852);
                    return return_v;
                }


                char
                f_1253_41863_41878(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 41863, 41878);
                    return return_v;
                }


                System.IDisposable
                f_1253_41935_42113(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    var return_v = this_param.TraceScope(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 41935, 42113);
                    return return_v;
                }


                string
                f_1253_42172_42199(System.Management.Automation.CommandSearcher
                this_param, string
                path)
                {
                    var return_v = this_param.ResolvePSPath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 42172, 42199);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1253, 40902, 42298);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1253, 40902, 42298);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string ResolvePSPath(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1253, 42755, 46940);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 42821, 42842);

                string
                result = null
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 42894, 42923);

                    ProviderInfo
                    provider = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 42941, 42968);

                    string
                    resolvedPath = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 43062, 43492) || true) && (f_1253_43066_43155(_commandResolutionOptions, SearchResolutionOptions.ResolveLiteralThenPathPatterns))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 43062, 43492);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 43409, 43473);

                        resolvedPath = f_1253_43424_43472(this, path, out provider);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 43062, 43492);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 43512, 44681) || true) && (f_1253_43516_43564(path) && (DynAbs.Tracing.TraceSender.Expression_True(1253, 43516, 43635) && ((resolvedPath == null) || (DynAbs.Tracing.TraceSender.Expression_False(1253, 43590, 43634) || (provider == null)))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 43512, 44681);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 43754, 43839);

                        Collection<string>
                        resolvedPaths = f_1253_43789_43838(this, path, out provider)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 43863, 44662) || true) && (f_1253_43867_43886(resolvedPaths) == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 43863, 44662);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 43941, 43961);

                            resolvedPath = null;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 43989, 44166);

                            f_1253_43989_44165(
                                                    CommandDiscovery.discoveryTracer, "The relative path with wildcard did not resolve to valid path. {0}", path);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 43863, 44662);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 43863, 44662);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 44216, 44662) || true) && (f_1253_44220_44239(resolvedPaths) > 1)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 44216, 44662);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 44293, 44313);

                                resolvedPath = null;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 44341, 44509);

                                f_1253_44341_44508(
                                                        CommandDiscovery.discoveryTracer, "The relative path with wildcard resolved to multiple paths. {0}", path);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 44216, 44662);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 44216, 44662);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 44607, 44639);

                                resolvedPath = f_1253_44622_44638(resolvedPaths, 0);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 44216, 44662);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 43863, 44662);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 43512, 44681);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 44807, 45097) || true) && (!f_1253_44812_44901(_commandResolutionOptions, SearchResolutionOptions.ResolveLiteralThenPathPatterns) && (DynAbs.Tracing.TraceSender.Expression_True(1253, 44811, 44972) && ((resolvedPath == null) || (DynAbs.Tracing.TraceSender.Expression_False(1253, 44927, 44971) || (provider == null)))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 44807, 45097);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 45014, 45078);

                        resolvedPath = f_1253_45029_45077(this, path, out provider);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 44807, 45097);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 45188, 45813) || true) && (provider != null && (DynAbs.Tracing.TraceSender.Expression_True(1253, 45192, 45266) && f_1253_45212_45266(provider, f_1253_45232_45265(f_1253_45232_45254(_context)))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 45188, 45813);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 45308, 45330);

                        result = resolvedPath;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 45354, 45498);

                        f_1253_45354_45497(
                                            CommandDiscovery.discoveryTracer, "The relative path was resolved to: {0}", result);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 45188, 45813);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 45188, 45813);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 45640, 45794);

                        f_1253_45640_45793(                    // The path was not to the file system
                                            CommandDiscovery.discoveryTracer, "The relative path was not a file system path. {0}", path);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 45188, 45813);
                    }
                }
                catch (InvalidOperationException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1253, 45842, 46073);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 45908, 46058);

                    f_1253_45908_46057(CommandDiscovery.discoveryTracer, "The home path was not specified for the provider. {0}", path);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1253, 45842, 46073);
                }
                catch (ProviderInvocationException providerInvocationException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1253, 46087, 46433);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 46183, 46418);

                    f_1253_46183_46417(CommandDiscovery.discoveryTracer, "While resolving the path, \"{0}\", an error was encountered by the provider: {1}", path, f_1253_46381_46416(providerInvocationException));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1253, 46087, 46433);
                }
                catch (ItemNotFoundException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1253, 46447, 46649);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 46509, 46634);

                    f_1253_46509_46633(CommandDiscovery.discoveryTracer, "The path does not exist: {0}", path);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1253, 46447, 46649);
                }
                catch (DriveNotFoundException driveNotFound)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1253, 46663, 46899);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 46740, 46884);

                    f_1253_46740_46883(CommandDiscovery.discoveryTracer, "The drive does not exist: {0}", f_1253_46860_46882(driveNotFound));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1253, 46663, 46899);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 46915, 46929);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1253, 42755, 46940);

                bool
                f_1253_43066_43155(System.Management.Automation.SearchResolutionOptions
                this_param, System.Management.Automation.SearchResolutionOptions
                flag)
                {
                    var return_v = this_param.HasFlag((System.Enum)flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 43066, 43155);
                    return return_v;
                }


                string
                f_1253_43424_43472(System.Management.Automation.CommandSearcher
                this_param, string
                command, out System.Management.Automation.ProviderInfo
                provider)
                {
                    var return_v = this_param.GetNextLiteralPathThatExists(command, out provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 43424, 43472);
                    return return_v;
                }


                bool
                f_1253_43516_43564(string
                pattern)
                {
                    var return_v = WildcardPattern.ContainsWildcardCharacters(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 43516, 43564);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1253_43789_43838(System.Management.Automation.CommandSearcher
                this_param, string
                command, out System.Management.Automation.ProviderInfo
                provider)
                {
                    var return_v = this_param.GetNextFromPathUsingWildcards(command, out provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 43789, 43838);
                    return return_v;
                }


                int
                f_1253_43867_43886(System.Collections.ObjectModel.Collection<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 43867, 43886);
                    return return_v;
                }


                int
                f_1253_43989_44165(System.Management.Automation.PSTraceSource
                this_param, string
                errorMessageFormat, params object[]
                args)
                {
                    this_param.TraceError(errorMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 43989, 44165);
                    return 0;
                }


                int
                f_1253_44220_44239(System.Collections.ObjectModel.Collection<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 44220, 44239);
                    return return_v;
                }


                int
                f_1253_44341_44508(System.Management.Automation.PSTraceSource
                this_param, string
                errorMessageFormat, params object[]
                args)
                {
                    this_param.TraceError(errorMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 44341, 44508);
                    return 0;
                }


                string
                f_1253_44622_44638(System.Collections.ObjectModel.Collection<string>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 44622, 44638);
                    return return_v;
                }


                bool
                f_1253_44812_44901(System.Management.Automation.SearchResolutionOptions
                this_param, System.Management.Automation.SearchResolutionOptions
                flag)
                {
                    var return_v = this_param.HasFlag((System.Enum)flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 44812, 44901);
                    return return_v;
                }


                string
                f_1253_45029_45077(System.Management.Automation.CommandSearcher
                this_param, string
                command, out System.Management.Automation.ProviderInfo
                provider)
                {
                    var return_v = this_param.GetNextLiteralPathThatExists(command, out provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 45029, 45077);
                    return return_v;
                }


                System.Management.Automation.ProviderNames
                f_1253_45232_45254(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ProviderNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 45232, 45254);
                    return return_v;
                }


                string
                f_1253_45232_45265(System.Management.Automation.ProviderNames
                this_param)
                {
                    var return_v = this_param.FileSystem;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 45232, 45265);
                    return return_v;
                }


                bool
                f_1253_45212_45266(System.Management.Automation.ProviderInfo
                this_param, string
                providerName)
                {
                    var return_v = this_param.NameEquals(providerName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 45212, 45266);
                    return return_v;
                }


                int
                f_1253_45354_45497(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 45354, 45497);
                    return 0;
                }


                int
                f_1253_45640_45793(System.Management.Automation.PSTraceSource
                this_param, string
                errorMessageFormat, params object[]
                args)
                {
                    this_param.TraceError(errorMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 45640, 45793);
                    return 0;
                }


                int
                f_1253_45908_46057(System.Management.Automation.PSTraceSource
                this_param, string
                errorMessageFormat, params object[]
                args)
                {
                    this_param.TraceError(errorMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 45908, 46057);
                    return 0;
                }


                string
                f_1253_46381_46416(System.Management.Automation.ProviderInvocationException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 46381, 46416);
                    return return_v;
                }


                int
                f_1253_46183_46417(System.Management.Automation.PSTraceSource
                this_param, string
                errorMessageFormat, params object[]
                args)
                {
                    this_param.TraceError(errorMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 46183, 46417);
                    return 0;
                }


                int
                f_1253_46509_46633(System.Management.Automation.PSTraceSource
                this_param, string
                errorMessageFormat, params object[]
                args)
                {
                    this_param.TraceError(errorMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 46509, 46633);
                    return 0;
                }


                string
                f_1253_46860_46882(System.Management.Automation.DriveNotFoundException
                this_param)
                {
                    var return_v = this_param.ItemName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 46860, 46882);
                    return return_v;
                }


                int
                f_1253_46740_46883(System.Management.Automation.PSTraceSource
                this_param, string
                errorMessageFormat, params object[]
                args)
                {
                    this_param.TraceError(errorMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 46740, 46883);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1253, 42755, 46940);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1253, 42755, 46940);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string GetNextLiteralPathThatExistsAndHandleExceptions(string command, out ProviderInfo provider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1253, 47404, 49534);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 47570, 47629);

                    return f_1253_47577_47628(this, command, out provider);
                }
                catch (ItemNotFoundException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1253, 47658, 47872);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 47720, 47857);

                    f_1253_47720_47856(CommandDiscovery.discoveryTracer, "The path could not be found: {0}", _commandName);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1253, 47658, 47872);
                }
                catch (DriveNotFoundException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1253, 47886, 48312);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 48148, 48297);

                    f_1253_48148_48296(                // This can be because we think a scope or a url is a drive
                                                       // and need to continue searching.
                                                       // Although, scope does not work through get-command
                                    CommandDiscovery.discoveryTracer, "A drive could not be found for the path: {0}", _commandName);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1253, 47886, 48312);
                }
                catch (ProviderNotFoundException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1253, 48326, 48559);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 48392, 48544);

                    f_1253_48392_48543(CommandDiscovery.discoveryTracer, "A provider could not be found for the path: {0}", _commandName);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1253, 48326, 48559);
                }
                catch (InvalidOperationException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1253, 48573, 48844);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 48639, 48829);

                    f_1253_48639_48828(CommandDiscovery.discoveryTracer, "The path specified a home directory, but the provider home directory was not set. {0}", _commandName);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1253, 48573, 48844);
                }
                catch (ProviderInvocationException providerException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1253, 48858, 49181);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 48944, 49166);

                    f_1253_48944_49165(CommandDiscovery.discoveryTracer, "The provider associated with the path '{0}' encountered an error: {1}", _commandName, f_1253_49139_49164(providerException));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1253, 48858, 49181);
                }
                catch (PSNotSupportedException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1253, 49195, 49465);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 49259, 49450);

                    f_1253_49259_49449(CommandDiscovery.discoveryTracer, "The provider associated with the path '{0}' does not implement ContainerCmdletProvider", _commandName);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1253, 49195, 49465);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 49481, 49497);

                provider = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 49511, 49523);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1253, 47404, 49534);

                string
                f_1253_47577_47628(System.Management.Automation.CommandSearcher
                this_param, string
                command, out System.Management.Automation.ProviderInfo
                provider)
                {
                    var return_v = this_param.GetNextLiteralPathThatExists(command, out provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 47577, 47628);
                    return return_v;
                }


                int
                f_1253_47720_47856(System.Management.Automation.PSTraceSource
                this_param, string
                errorMessageFormat, params object[]
                args)
                {
                    this_param.TraceError(errorMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 47720, 47856);
                    return 0;
                }


                int
                f_1253_48148_48296(System.Management.Automation.PSTraceSource
                this_param, string
                errorMessageFormat, params object[]
                args)
                {
                    this_param.TraceError(errorMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 48148, 48296);
                    return 0;
                }


                int
                f_1253_48392_48543(System.Management.Automation.PSTraceSource
                this_param, string
                errorMessageFormat, params object[]
                args)
                {
                    this_param.TraceError(errorMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 48392, 48543);
                    return 0;
                }


                int
                f_1253_48639_48828(System.Management.Automation.PSTraceSource
                this_param, string
                errorMessageFormat, params object[]
                args)
                {
                    this_param.TraceError(errorMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 48639, 48828);
                    return 0;
                }


                string
                f_1253_49139_49164(System.Management.Automation.ProviderInvocationException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 49139, 49164);
                    return return_v;
                }


                int
                f_1253_48944_49165(System.Management.Automation.PSTraceSource
                this_param, string
                errorMessageFormat, params object[]
                args)
                {
                    this_param.TraceError(errorMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 48944, 49165);
                    return 0;
                }


                int
                f_1253_49259_49449(System.Management.Automation.PSTraceSource
                this_param, string
                errorMessageFormat, params object[]
                args)
                {
                    this_param.TraceError(errorMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 49259, 49449);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1253, 47404, 49534);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1253, 47404, 49534);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string GetNextLiteralPathThatExists(string command, out ProviderInfo provider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1253, 49968, 50480);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 50079, 50165);

                string
                resolvedPath = f_1253_50101_50164(f_1253_50101_50125(_context), command, out provider)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 50181, 50433) || true) && (f_1253_50185_50239(provider, f_1253_50205_50238(f_1253_50205_50227(_context))) && (DynAbs.Tracing.TraceSender.Expression_True(1253, 50185, 50286) && !f_1253_50261_50286(resolvedPath)) && (DynAbs.Tracing.TraceSender.Expression_True(1253, 50185, 50338) && !f_1253_50308_50338(resolvedPath)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 50181, 50433);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 50372, 50388);

                    provider = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 50406, 50418);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 50181, 50433);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 50449, 50469);

                return resolvedPath;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1253, 49968, 50480);

                System.Management.Automation.LocationGlobber
                f_1253_50101_50125(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.LocationGlobber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 50101, 50125);
                    return return_v;
                }


                string
                f_1253_50101_50164(System.Management.Automation.LocationGlobber
                this_param, string
                path, out System.Management.Automation.ProviderInfo
                provider)
                {
                    var return_v = this_param.GetProviderPath(path, out provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 50101, 50164);
                    return return_v;
                }


                System.Management.Automation.ProviderNames
                f_1253_50205_50227(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ProviderNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 50205, 50227);
                    return return_v;
                }


                string
                f_1253_50205_50238(System.Management.Automation.ProviderNames
                this_param)
                {
                    var return_v = this_param.FileSystem;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 50205, 50238);
                    return return_v;
                }


                bool
                f_1253_50185_50239(System.Management.Automation.ProviderInfo
                this_param, string
                providerName)
                {
                    var return_v = this_param.NameEquals(providerName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 50185, 50239);
                    return return_v;
                }


                bool
                f_1253_50261_50286(string
                path)
                {
                    var return_v = File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 50261, 50286);
                    return return_v;
                }


                bool
                f_1253_50308_50338(string
                path)
                {
                    var return_v = Directory.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 50308, 50338);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1253, 49968, 50480);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1253, 49968, 50480);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Collection<string> ConstructSearchPatternsFromName(string name, bool commandDiscovery = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1253, 51405, 53251);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 51533, 51637);

                f_1253_51533_51636(!f_1253_51563_51589(name), "Caller should verify name");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 51653, 51706);

                Collection<string>
                result = f_1253_51681_51705()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 51838, 51873);

                bool
                commandNameAddedFirst = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 51889, 52052) || true) && (!f_1253_51894_51939(f_1253_51915_51938(name)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 51889, 52052);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 51973, 51990);

                    f_1253_51973_51989(result, name);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 52008, 52037);

                    commandNameAddedFirst = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 51889, 52052);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 52154, 52645) || true) && ((_commandTypes & CommandTypes.ExternalScript) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 52154, 52645);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 52242, 52306);

                    f_1253_52242_52305(result, name + StringLiterals.PowerShellScriptFileExtension);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 52324, 52630) || true) && (!commandDiscovery)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 52324, 52630);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 52463, 52527);

                        f_1253_52463_52526(                    // psd1 and psm1 are not executable, so don't add them
                                            result, name + StringLiterals.PowerShellModuleFileExtension);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 52549, 52611);

                        f_1253_52549_52610(result, name + StringLiterals.PowerShellDataFileExtension);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 52324, 52630);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 52154, 52645);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 52661, 52994) || true) && ((_commandTypes & CommandTypes.Application) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 52661, 52994);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 52829, 52979);
                        foreach (string extension in f_1253_52858_52889_I(f_1253_52858_52889()))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 52829, 52979);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 52931, 52960);

                            f_1253_52931_52959(result, name + extension);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 52829, 52979);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1253, 1, 151);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1253, 1, 151);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 52661, 52994);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 53118, 53210) || true) && (!commandNameAddedFirst)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 53118, 53210);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 53178, 53195);

                    f_1253_53178_53194(result, name);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 53118, 53210);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 53226, 53240);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1253, 51405, 53251);

                bool
                f_1253_51563_51589(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 51563, 51589);
                    return return_v;
                }


                int
                f_1253_51533_51636(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 51533, 51636);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1253_51681_51705()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 51681, 51705);
                    return return_v;
                }


                string?
                f_1253_51915_51938(string
                path)
                {
                    var return_v = Path.GetExtension(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 51915, 51938);
                    return return_v;
                }


                bool
                f_1253_51894_51939(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 51894, 51939);
                    return return_v;
                }


                int
                f_1253_51973_51989(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 51973, 51989);
                    return 0;
                }


                int
                f_1253_52242_52305(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 52242, 52305);
                    return 0;
                }


                int
                f_1253_52463_52526(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 52463, 52526);
                    return 0;
                }


                int
                f_1253_52549_52610(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 52549, 52610);
                    return 0;
                }


                string[]
                f_1253_52858_52889()
                {
                    var return_v = CommandDiscovery.PathExtensions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 52858, 52889);
                    return return_v;
                }


                int
                f_1253_52931_52959(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 52931, 52959);
                    return 0;
                }


                string[]
                f_1253_52858_52889_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 52858, 52889);
                    return return_v;
                }


                int
                f_1253_53178_53194(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 53178, 53194);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1253, 51405, 53251);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1253, 51405, 53251);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsQualifiedPSPath(string commandName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1253, 53674, 54224);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 53756, 53889);

                f_1253_53756_53888(!f_1253_53786_53819(commandName), "The caller should have verified the commandName");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 53905, 54183);

                bool
                result =
                f_1253_53936_53979(commandName) || (DynAbs.Tracing.TraceSender.Expression_False(1253, 53936, 54052) || f_1253_54000_54052(commandName)) || (DynAbs.Tracing.TraceSender.Expression_False(1253, 53936, 54112) || f_1253_54073_54112(commandName)) || (DynAbs.Tracing.TraceSender.Expression_False(1253, 53936, 54182) || f_1253_54133_54182(commandName))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 54199, 54213);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1253, 53674, 54224);

                bool
                f_1253_53786_53819(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 53786, 53819);
                    return return_v;
                }


                int
                f_1253_53756_53888(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 53756, 53888);
                    return 0;
                }


                bool
                f_1253_53936_53979(string
                path)
                {
                    var return_v = LocationGlobber.IsAbsolutePath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 53936, 53979);
                    return return_v;
                }


                bool
                f_1253_54000_54052(string
                path)
                {
                    var return_v = LocationGlobber.IsProviderQualifiedPath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 54000, 54052);
                    return return_v;
                }


                bool
                f_1253_54073_54112(string
                path)
                {
                    var return_v = LocationGlobber.IsHomePath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 54073, 54112);
                    return return_v;
                }


                bool
                f_1253_54133_54182(string
                path)
                {
                    var return_v = LocationGlobber.IsProviderDirectPath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 54133, 54182);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1253, 53674, 54224);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1253, 53674, 54224);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private enum CanDoPathLookupResult
        {
            Yes,
            PathIsRooted,
            WildcardCharacters,
            DirectorySeparator,
            IllegalCharacters
        }

        private static CanDoPathLookupResult CanDoPathLookup(string possiblePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1253, 54969, 56704);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 55067, 55124);

                CanDoPathLookupResult
                result = CanDoPathLookupResult.Yes
                ;
                {
                    try
                    {
                        do // false loop

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 55140, 56663);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 55312, 55511) || true) && (f_1253_55316_55372(possiblePath))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 55312, 55511);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 55414, 55464);

                                result = CanDoPathLookupResult.WildcardCharacters;
                                DynAbs.Tracing.TraceSender.TraceBreak(1253, 55486, 55492);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 55312, 55511);
                            }

                            try
                            {

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 55575, 55759) || true) && (f_1253_55579_55610(possiblePath))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 55575, 55759);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 55660, 55704);

                                    result = CanDoPathLookupResult.PathIsRooted;
                                    DynAbs.Tracing.TraceSender.TraceBreak(1253, 55730, 55736);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 55575, 55759);
                                }
                            }
                            catch (ArgumentException)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1253, 55796, 55958);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 55862, 55911);

                                result = CanDoPathLookupResult.IllegalCharacters;
                                DynAbs.Tracing.TraceSender.TraceBreak(1253, 55933, 55939);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1253, 55796, 55958);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 56091, 56291) || true) && (f_1253_56095_56146(possiblePath, Utils.Separators.Directory) != -1)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 56091, 56291);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 56194, 56244);

                                result = CanDoPathLookupResult.DirectorySeparator;
                                DynAbs.Tracing.TraceSender.TraceBreak(1253, 56266, 56272);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 56091, 56291);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 56434, 56633) || true) && (f_1253_56438_56489(possiblePath, f_1253_56462_56488()) != -1)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 56434, 56633);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 56537, 56586);

                                result = CanDoPathLookupResult.IllegalCharacters;
                                DynAbs.Tracing.TraceSender.TraceBreak(1253, 56608, 56614);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 56434, 56633);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 55140, 56663);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 55140, 56663) || true) && (false)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1253, 55140, 56663);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1253, 55140, 56663);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 56679, 56693);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1253, 54969, 56704);

                bool
                f_1253_55316_55372(string
                pattern)
                {
                    var return_v = WildcardPattern.ContainsWildcardCharacters(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 55316, 55372);
                    return return_v;
                }


                bool
                f_1253_55579_55610(string
                path)
                {
                    var return_v = Path.IsPathRooted(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 55579, 55610);
                    return return_v;
                }


                int
                f_1253_56095_56146(string
                this_param, char[]
                anyOf)
                {
                    var return_v = this_param.IndexOfAny(anyOf);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 56095, 56146);
                    return return_v;
                }


                char[]
                f_1253_56462_56488()
                {
                    var return_v = Path.GetInvalidPathChars();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 56462, 56488);
                    return return_v;
                }


                int
                f_1253_56438_56489(string
                this_param, char[]
                anyOf)
                {
                    var return_v = this_param.IndexOfAny(anyOf);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 56438, 56489);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1253, 54969, 56704);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1253, 54969, 56704);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string _commandName;

        private SearchResolutionOptions _commandResolutionOptions;

        private CommandTypes _commandTypes;

        private CommandPathSearch _pathSearcher;

        private ExecutionContext _context;

        private void setupPathSearcher()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1253, 57891, 62946);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 58003, 58084) || true) && (_pathSearcher != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 58003, 58084);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 58062, 58069);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 58003, 58084);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 58586, 62935) || true) && ((_commandResolutionOptions & SearchResolutionOptions.CommandNameIsPattern) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 58586, 62935);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 58703, 58727);

                    _canDoPathLookup = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 58745, 58796);

                    _canDoPathLookupResult = CanDoPathLookupResult.Yes;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 58816, 59194);

                    _pathSearcher =
                    f_1253_58853_59193(_commandName, f_1253_58940_58991(f_1253_58940_58965(_context)), _context, acceptableCommandNames: null, useFuzzyMatch: f_1253_59123_59192(_commandResolutionOptions, SearchResolutionOptions.FuzzyMatch));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 58586, 62935);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 58586, 62935);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 59260, 59315);

                    _canDoPathLookupResult = f_1253_59285_59314(_commandName);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 59333, 62920) || true) && (_canDoPathLookupResult == CanDoPathLookupResult.Yes)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 59333, 62920);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 59430, 59454);

                        _canDoPathLookup = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 59476, 59548);

                        _commandName = f_1253_59491_59547(_commandName, Utils.Separators.PathSearchTrimEnd);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 59572, 59900);

                        _pathSearcher =
                        f_1253_59613_59899(_commandName, f_1253_59708_59759(f_1253_59708_59733(_context)), _context, f_1253_59829_59898(this, _commandName, commandDiscovery: true));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 59333, 62920);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 59333, 62920);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 59942, 62920) || true) && (_canDoPathLookupResult == CanDoPathLookupResult.PathIsRooted)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 59942, 62920);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 60048, 60072);

                            _canDoPathLookup = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 60096, 60151);

                            string
                            directory = f_1253_60115_60150(_commandName)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 60173, 60219);

                            var
                            directoryCollection = new[] { directory }
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 60243, 60428);

                            f_1253_60243_60427(
                                                CommandDiscovery.discoveryTracer, "The path is rooted, so only doing the lookup in the specified directory: {0}", directory);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 60452, 60501);

                            string
                            fileName = f_1253_60470_60500(_commandName)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 60525, 61154) || true) && (!f_1253_60530_60560(fileName))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 60525, 61154);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 60610, 60674);

                                fileName = f_1253_60621_60673(fileName, Utils.Separators.PathSearchTrimEnd);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 60700, 61008);

                                _pathSearcher =
                                f_1253_60745_61007(fileName, directoryCollection, _context, f_1253_60941_61006(this, fileName, commandDiscovery: true));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 60525, 61154);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 60525, 61154);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 61106, 61131);

                                _canDoPathLookup = false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 60525, 61154);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 59942, 62920);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 59942, 62920);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 61196, 62920) || true) && (_canDoPathLookupResult == CanDoPathLookupResult.DirectorySeparator)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 61196, 62920);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 61308, 61332);

                                _canDoPathLookup = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 61503, 61558);

                                string
                                directory = f_1253_61522_61557(_commandName)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 61580, 61617);

                                directory = f_1253_61592_61616(this, directory);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 61641, 61828);

                                f_1253_61641_61827(
                                                    CommandDiscovery.discoveryTracer, "The path is relative, so only doing the lookup in the specified directory: {0}", directory);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 61852, 62901) || true) && (directory == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 61852, 62901);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 61923, 61948);

                                    _canDoPathLookup = false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 61852, 62901);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 61852, 62901);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 62046, 62092);

                                    var
                                    directoryCollection = new[] { directory }
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 62120, 62169);

                                    string
                                    fileName = f_1253_62138_62168(_commandName)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 62197, 62878) || true) && (!f_1253_62202_62232(fileName))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 62197, 62878);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 62290, 62354);

                                        fileName = f_1253_62301_62353(fileName, Utils.Separators.PathSearchTrimEnd);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 62384, 62712);

                                        _pathSearcher =
                                        f_1253_62433_62711(fileName, directoryCollection, _context, f_1253_62645_62710(this, fileName, commandDiscovery: true));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 62197, 62878);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 62197, 62878);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 62826, 62851);

                                        _canDoPathLookup = false;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 62197, 62878);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 61852, 62901);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 61196, 62920);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 59942, 62920);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 59333, 62920);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 58586, 62935);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1253, 57891, 62946);

                System.Management.Automation.CommandDiscovery
                f_1253_58940_58965(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CommandDiscovery;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 58940, 58965);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1253_58940_58991(System.Management.Automation.CommandDiscovery
                this_param)
                {
                    var return_v = this_param.GetLookupDirectoryPaths();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 58940, 58991);
                    return return_v;
                }


                bool
                f_1253_59123_59192(System.Management.Automation.SearchResolutionOptions
                this_param, System.Management.Automation.SearchResolutionOptions
                flag)
                {
                    var return_v = this_param.HasFlag((System.Enum)flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 59123, 59192);
                    return return_v;
                }


                System.Management.Automation.CommandPathSearch
                f_1253_58853_59193(string
                commandName, System.Collections.Generic.IEnumerable<string>
                lookupPaths, System.Management.Automation.ExecutionContext
                context, System.Collections.ObjectModel.Collection<string>
                acceptableCommandNames, bool
                useFuzzyMatch)
                {
                    var return_v = new System.Management.Automation.CommandPathSearch(commandName, lookupPaths, context, acceptableCommandNames: acceptableCommandNames, useFuzzyMatch: useFuzzyMatch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 58853, 59193);
                    return return_v;
                }


                System.Management.Automation.CommandSearcher.CanDoPathLookupResult
                f_1253_59285_59314(string
                possiblePath)
                {
                    var return_v = CanDoPathLookup(possiblePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 59285, 59314);
                    return return_v;
                }


                string
                f_1253_59491_59547(string
                this_param, params char[]
                trimChars)
                {
                    var return_v = this_param.TrimEnd(trimChars);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 59491, 59547);
                    return return_v;
                }


                System.Management.Automation.CommandDiscovery
                f_1253_59708_59733(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CommandDiscovery;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 59708, 59733);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1253_59708_59759(System.Management.Automation.CommandDiscovery
                this_param)
                {
                    var return_v = this_param.GetLookupDirectoryPaths();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 59708, 59759);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1253_59829_59898(System.Management.Automation.CommandSearcher
                this_param, string
                name, bool
                commandDiscovery)
                {
                    var return_v = this_param.ConstructSearchPatternsFromName(name, commandDiscovery: commandDiscovery);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 59829, 59898);
                    return return_v;
                }


                System.Management.Automation.CommandPathSearch
                f_1253_59613_59899(string
                commandName, System.Collections.Generic.IEnumerable<string>
                lookupPaths, System.Management.Automation.ExecutionContext
                context, System.Collections.ObjectModel.Collection<string>
                acceptableCommandNames)
                {
                    var return_v = new System.Management.Automation.CommandPathSearch(commandName, lookupPaths, context, acceptableCommandNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 59613, 59899);
                    return return_v;
                }


                string?
                f_1253_60115_60150(string
                path)
                {
                    var return_v = Path.GetDirectoryName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 60115, 60150);
                    return return_v;
                }


                int
                f_1253_60243_60427(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 60243, 60427);
                    return 0;
                }


                string?
                f_1253_60470_60500(string
                path)
                {
                    var return_v = Path.GetFileName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 60470, 60500);
                    return return_v;
                }


                bool
                f_1253_60530_60560(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 60530, 60560);
                    return return_v;
                }


                string
                f_1253_60621_60673(string
                this_param, params char[]
                trimChars)
                {
                    var return_v = this_param.TrimEnd(trimChars);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 60621, 60673);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1253_60941_61006(System.Management.Automation.CommandSearcher
                this_param, string
                name, bool
                commandDiscovery)
                {
                    var return_v = this_param.ConstructSearchPatternsFromName(name, commandDiscovery: commandDiscovery);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 60941, 61006);
                    return return_v;
                }


                System.Management.Automation.CommandPathSearch
                f_1253_60745_61007(string
                commandName, string[]
                lookupPaths, System.Management.Automation.ExecutionContext
                context, System.Collections.ObjectModel.Collection<string>
                acceptableCommandNames)
                {
                    var return_v = new System.Management.Automation.CommandPathSearch(commandName, (System.Collections.Generic.IEnumerable<string>)lookupPaths, context, acceptableCommandNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 60745, 61007);
                    return return_v;
                }


                string?
                f_1253_61522_61557(string
                path)
                {
                    var return_v = Path.GetDirectoryName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 61522, 61557);
                    return return_v;
                }


                string
                f_1253_61592_61616(System.Management.Automation.CommandSearcher
                this_param, string
                path)
                {
                    var return_v = this_param.ResolvePSPath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 61592, 61616);
                    return return_v;
                }


                int
                f_1253_61641_61827(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 61641, 61827);
                    return 0;
                }


                string?
                f_1253_62138_62168(string
                path)
                {
                    var return_v = Path.GetFileName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 62138, 62168);
                    return return_v;
                }


                bool
                f_1253_62202_62232(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 62202, 62232);
                    return return_v;
                }


                string
                f_1253_62301_62353(string
                this_param, params char[]
                trimChars)
                {
                    var return_v = this_param.TrimEnd(trimChars);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 62301, 62353);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1253_62645_62710(System.Management.Automation.CommandSearcher
                this_param, string
                name, bool
                commandDiscovery)
                {
                    var return_v = this_param.ConstructSearchPatternsFromName(name, commandDiscovery: commandDiscovery);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 62645, 62710);
                    return return_v;
                }


                System.Management.Automation.CommandPathSearch
                f_1253_62433_62711(string
                commandName, string[]
                lookupPaths, System.Management.Automation.ExecutionContext
                context, System.Collections.ObjectModel.Collection<string>
                acceptableCommandNames)
                {
                    var return_v = new System.Management.Automation.CommandPathSearch(commandName, (System.Collections.Generic.IEnumerable<string>)lookupPaths, context, acceptableCommandNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 62433, 62711);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1253, 57891, 62946);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1253, 57891, 62946);
            }
        }

        public void Reset()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1253, 63099, 63992);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 63349, 63700) || true) && (_commandOrigin == CommandOrigin.Runspace)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 63349, 63700);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 63427, 63548) || true) && (f_1253_63431_63477(f_1253_63431_63471(f_1253_63431_63458(_context))) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 63427, 63548);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 63505, 63548);

                        _commandTypes &= ~CommandTypes.Application;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 63427, 63548);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 63566, 63685) || true) && (f_1253_63570_63611(f_1253_63570_63605(f_1253_63570_63597(_context))) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 63566, 63685);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 63639, 63685);

                        _commandTypes &= ~CommandTypes.ExternalScript;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 63566, 63685);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 63349, 63700);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 63716, 63812) || true) && (_pathSearcher != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1253, 63716, 63812);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 63775, 63797);

                    f_1253_63775_63796(_pathSearcher);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1253, 63716, 63812);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 63828, 63849);

                _currentMatch = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 63863, 63908);

                _currentState = SearchState.SearchingAliases;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 63922, 63944);

                _matchingAlias = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 63958, 63981);

                _matchingCmdlet = null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1253, 63099, 63992);

                System.Management.Automation.SessionStateInternal
                f_1253_63431_63458(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 63431, 63458);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1253_63431_63471(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.Applications;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 63431, 63471);
                    return return_v;
                }


                int
                f_1253_63431_63477(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 63431, 63477);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1253_63570_63597(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 63570, 63597);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1253_63570_63605(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.Scripts;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 63570, 63605);
                    return return_v;
                }


                int
                f_1253_63570_63611(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1253, 63570, 63611);
                    return return_v;
                }


                int
                f_1253_63775_63796(System.Management.Automation.CommandPathSearch
                this_param)
                {
                    this_param.Reset();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 63775, 63796);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1253, 63099, 63992);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1253, 63099, 63992);
            }
        }

        internal CommandOrigin CommandOrigin
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1253, 64065, 64095);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 64071, 64093);

                    return _commandOrigin;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1253, 64065, 64095);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1253, 64004, 64153);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1253, 64004, 64153);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1253, 64111, 64142);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1253, 64117, 64140);

                    _commandOrigin = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1253, 64111, 64142);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1253, 64004, 64153);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1253, 64004, 64153);
                }
            }
        }

        private CommandOrigin _commandOrigin;

        private IEnumerator<AliasInfo> _matchingAlias;

        private IEnumerator<CommandInfo> _matchingFunctionEnumerator;

        private CommandInfo _currentMatch;

        private bool _canDoPathLookup;

        private CanDoPathLookupResult _canDoPathLookupResult;

        private SearchState _currentState;

        private enum SearchState
        {
            // the searcher has been reset or has not been advanced since being created.
            SearchingAliases,

            // the searcher has finished alias resolution and is now searching for functions.
            SearchingFunctions,

            // the searcher has finished function resolution and is now searching for cmdlets
            SearchingCmdlets,

            // the search has finished builtin script resolution and is now searching for external commands
            StartSearchingForExternalCommands,

            // the searcher has moved to
            PowerShellPathResolution,

            // the searcher has moved to a qualified file system path
            QualifiedFileSystemPath,

            // the searcher has moved to using a CommandPathSearch object
            // for resolution
            PathSearch,

            // the searcher has moved to using a CommandPathSearch object
            // with get prepended to the command name for resolution
            GetPathSearch,

            // the searcher has moved to resolving the command as a
            // relative PowerShell path
            PowerShellRelativePath,

            // No more matches can be found
            NoMoreMatches,
        }

        static CommandSearcher()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1253, 512, 66408);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1253, 512, 66408);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1253, 512, 66408);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1253, 512, 66408);

        int
        f_1253_1776_1851(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 1776, 1851);
            return 0;
        }


        bool
        f_1253_1886_1919(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 1886, 1919);
            return return_v;
        }


        int
        f_1253_1866_1961(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 1866, 1961);
            return 0;
        }


        int
        f_1253_2190_2202(System.Management.Automation.CommandSearcher
        this_param)
        {
            this_param.Reset();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1253, 2190, 2202);
            return 0;
        }

    }

    /// <summary>
    /// Determines which types of commands should be globbed using the specified
    /// pattern. Any flag that is not specified will only match if exact.
    /// </summary>
    [Flags]
    internal enum SearchResolutionOptions
    {
        None = 0x0,
        ResolveAliasPatterns = 0x01,
        ResolveFunctionPatterns = 0x02,
        CommandNameIsPattern = 0x04,
        SearchAllScopes = 0x08,

        /// <summary>Use fuzzy matching.</summary>
        FuzzyMatch = 0x10,

        /// <summary>
        /// Enable searching for cmdlets/functions by abbreviation expansion.
        /// </summary>
        UseAbbreviationExpansion = 0x20,

        /// <summary>
        /// Enable resolving wildcard in paths.
        /// </summary>
        ResolveLiteralThenPathPatterns = 0x40
    }
}
