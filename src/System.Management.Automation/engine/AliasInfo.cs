// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace System.Management.Automation
{
    public class AliasInfo : CommandInfo
    {
        internal AliasInfo(string name, string definition, ExecutionContext context) : base(f_1233_1290_1294_C(name), CommandTypes.Alias)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1233, 1206, 1548);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 7100, 7126);
                this._definition = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 12239, 12272);
                this._options = ScopedItemOptions.None;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 12389, 12444);
                this.Description = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 12782, 12841);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 1340, 1365);

                _definition = definition;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 1379, 1402);

                this.Context = context;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 1418, 1537) || true) && (context != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1233, 1418, 1537);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 1471, 1522);

                    this.Module = f_1233_1485_1521(f_1233_1485_1514(f_1233_1485_1505(context)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1233, 1418, 1537);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1233, 1206, 1548);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1233, 1206, 1548);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1233, 1206, 1548);
            }
        }

        internal AliasInfo(
                    string name,
                    string definition,
                    ExecutionContext context,
                    ScopedItemOptions options) : base(f_1233_2653_2657_C(name), CommandTypes.Alias)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1233, 2489, 2944);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 7100, 7126);
                this._definition = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 12239, 12272);
                this._options = ScopedItemOptions.None;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 12389, 12444);
                this.Description = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 12782, 12841);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 2703, 2728);

                _definition = definition;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 2742, 2765);

                this.Context = context;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 2779, 2798);

                _options = options;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 2814, 2933) || true) && (context != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1233, 2814, 2933);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 2867, 2918);

                    this.Module = f_1233_2881_2917(f_1233_2881_2910(f_1233_2881_2901(context)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1233, 2814, 2933);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1233, 2489, 2944);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1233, 2489, 2944);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1233, 2489, 2944);
            }
        }

        internal override HelpCategory HelpCategory
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1233, 3051, 3085);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 3057, 3083);

                    return HelpCategory.Alias;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1233, 3051, 3085);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1233, 2983, 3096);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1233, 2983, 3096);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public CommandInfo ReferencedCommand
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1233, 3320, 4321);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 3501, 3538);

                    CommandInfo
                    referencedCommand = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 3558, 4261) || true) && ((_definition != null) && (DynAbs.Tracing.TraceSender.Expression_True(1233, 3562, 3604) && (f_1233_3588_3595() != null)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1233, 3558, 4261);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 3646, 3912);

                        CommandSearcher
                        commandSearcher =
                        f_1233_3705_3911(_definition, SearchResolutionOptions.None, CommandTypes.All, f_1233_3903_3910())
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 3936, 4242) || true) && (f_1233_3940_3966(commandSearcher))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1233, 3936, 4242);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 4016, 4089);

                            System.Collections.Generic.IEnumerator<CommandInfo>
                            ie = commandSearcher
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 4115, 4146);

                            referencedCommand = f_1233_4135_4145(ie);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1233, 3936, 4242);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1233, 3558, 4261);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 4281, 4306);

                    return referencedCommand;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1233, 3320, 4321);

                    System.Management.Automation.ExecutionContext
                    f_1233_3588_3595()
                    {
                        var return_v = Context;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1233, 3588, 3595);
                        return return_v;
                    }


                    System.Management.Automation.ExecutionContext
                    f_1233_3903_3910()
                    {
                        var return_v = Context;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1233, 3903, 3910);
                        return return_v;
                    }


                    System.Management.Automation.CommandSearcher
                    f_1233_3705_3911(string
                    commandName, System.Management.Automation.SearchResolutionOptions
                    options, System.Management.Automation.CommandTypes
                    commandTypes, System.Management.Automation.ExecutionContext
                    context)
                    {
                        var return_v = new System.Management.Automation.CommandSearcher(commandName, options, commandTypes, context);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1233, 3705, 3911);
                        return return_v;
                    }


                    bool
                    f_1233_3940_3966(System.Management.Automation.CommandSearcher
                    this_param)
                    {
                        var return_v = this_param.MoveNext();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1233, 3940, 3966);
                        return return_v;
                    }


                    System.Management.Automation.CommandInfo
                    f_1233_4135_4145(System.Collections.Generic.IEnumerator<System.Management.Automation.CommandInfo>
                    this_param)
                    {
                        var return_v = this_param.Current;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1233, 4135, 4145);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1233, 3259, 4332);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1233, 3259, 4332);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public CommandInfo ResolvedCommand
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1233, 4947, 6795);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 5126, 5152);

                    CommandInfo
                    result = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 5172, 6746) || true) && (_definition != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1233, 5172, 6746);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 5237, 5287);

                        List<string>
                        cyclePrevention = f_1233_5268_5286()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 5309, 5335);

                        f_1233_5309_5334(cyclePrevention, f_1233_5329_5333());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 5359, 5401);

                        string
                        commandNameToResolve = _definition
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 5423, 5450);

                        result = f_1233_5432_5449();
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 5472, 6346) || true) && (result != null && (DynAbs.Tracing.TraceSender.Expression_True(1233, 5479, 5537) && f_1233_5497_5515(result) == CommandTypes.Alias))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1233, 5472, 6346);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 5587, 5634);

                                result = f_1233_5596_5633(((AliasInfo)result));

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 5662, 6323) || true) && (result is AliasInfo)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1233, 5662, 6323);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 5894, 6158) || true) && (f_1233_5898_6007(cyclePrevention, f_1233_5961_5972(result), f_1233_5974_6006()))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1233, 5894, 6158);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 6073, 6087);

                                        result = null;
                                        DynAbs.Tracing.TraceSender.TraceBreak(1233, 6121, 6127);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1233, 5894, 6158);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 6190, 6223);

                                    f_1233_6190_6222(
                                                                cyclePrevention, f_1233_6210_6221(result));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 6255, 6296);

                                    commandNameToResolve = f_1233_6278_6295(result);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1233, 5662, 6323);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1233, 5472, 6346);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1233, 5472, 6346);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1233, 5472, 6346);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 6370, 6727) || true) && (result == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1233, 6370, 6727);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 6659, 6704);

                            UnresolvedCommandName = commandNameToResolve;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1233, 6370, 6727);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1233, 5172, 6746);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 6766, 6780);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1233, 4947, 6795);

                    System.Collections.Generic.List<string>
                    f_1233_5268_5286()
                    {
                        var return_v = new System.Collections.Generic.List<string>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1233, 5268, 5286);
                        return return_v;
                    }


                    string
                    f_1233_5329_5333()
                    {
                        var return_v = Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1233, 5329, 5333);
                        return return_v;
                    }


                    int
                    f_1233_5309_5334(System.Collections.Generic.List<string>
                    this_param, string
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1233, 5309, 5334);
                        return 0;
                    }


                    System.Management.Automation.CommandInfo
                    f_1233_5432_5449()
                    {
                        var return_v = ReferencedCommand;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1233, 5432, 5449);
                        return return_v;
                    }


                    System.Management.Automation.CommandTypes
                    f_1233_5497_5515(System.Management.Automation.CommandInfo
                    this_param)
                    {
                        var return_v = this_param.CommandType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1233, 5497, 5515);
                        return return_v;
                    }


                    System.Management.Automation.CommandInfo
                    f_1233_5596_5633(System.Management.Automation.AliasInfo
                    this_param)
                    {
                        var return_v = this_param.ReferencedCommand;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1233, 5596, 5633);
                        return return_v;
                    }


                    string
                    f_1233_5961_5972(System.Management.Automation.CommandInfo
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1233, 5961, 5972);
                        return return_v;
                    }


                    System.StringComparer
                    f_1233_5974_6006()
                    {
                        var return_v = StringComparer.OrdinalIgnoreCase;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1233, 5974, 6006);
                        return return_v;
                    }


                    bool
                    f_1233_5898_6007(System.Collections.Generic.List<string>
                    collection, string
                    value, System.StringComparer
                    comparer)
                    {
                        var return_v = SessionStateUtilities.CollectionContainsValue((System.Collections.IEnumerable)collection, (object)value, (System.Collections.IComparer)comparer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1233, 5898, 6007);
                        return return_v;
                    }


                    string
                    f_1233_6210_6221(System.Management.Automation.CommandInfo
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1233, 6210, 6221);
                        return return_v;
                    }


                    int
                    f_1233_6190_6222(System.Collections.Generic.List<string>
                    this_param, string
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1233, 6190, 6222);
                        return 0;
                    }


                    string
                    f_1233_6278_6295(System.Management.Automation.CommandInfo
                    this_param)
                    {
                        var return_v = this_param.Definition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1233, 6278, 6295);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1233, 4888, 6806);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1233, 4888, 6806);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string Definition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1233, 6992, 7062);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 7028, 7047);

                    return _definition;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1233, 6992, 7062);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1233, 6934, 7073);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1233, 6934, 7073);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private string _definition;

        internal void SetDefinition(string definition, bool force)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1233, 7626, 8340);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 7768, 8288) || true) && ((_options & ScopedItemOptions.Constant) != 0 || (DynAbs.Tracing.TraceSender.Expression_False(1233, 7772, 7893) || (!force && (DynAbs.Tracing.TraceSender.Expression_True(1233, 7838, 7892) && (_options & ScopedItemOptions.ReadOnly) != 0))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1233, 7768, 8288);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 7927, 8245);

                    SessionStateUnauthorizedAccessException
                    e =
                    f_1233_7992_8244(f_1233_8066_8070(), SessionStateCategory.Alias, "AliasNotWritable", f_1233_8207_8243())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 8265, 8273);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1233, 7768, 8288);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 8304, 8329);

                _definition = definition;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1233, 7626, 8340);

                string
                f_1233_8066_8070()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1233, 8066, 8070);
                    return return_v;
                }


                string
                f_1233_8207_8243()
                {
                    var return_v = SessionStateStrings.AliasNotWritable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1233, 8207, 8243);
                    return return_v;
                }


                System.Management.Automation.SessionStateUnauthorizedAccessException
                f_1233_7992_8244(string
                itemName, System.Management.Automation.SessionStateCategory
                sessionStateCategory, string
                errorIdAndResourceId, string
                resourceStr)
                {
                    var return_v = new System.Management.Automation.SessionStateUnauthorizedAccessException(itemName, sessionStateCategory, errorIdAndResourceId, resourceStr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1233, 7992, 8244);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1233, 7626, 8340);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1233, 7626, 8340);
            }
        }

        public ScopedItemOptions Options
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1233, 8782, 8849);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 8818, 8834);

                    return _options;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1233, 8782, 8849);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1233, 8725, 8952);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1233, 8725, 8952);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1233, 8865, 8941);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 8901, 8926);

                    f_1233_8901_8925(this, value, false);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1233, 8865, 8941);

                    int
                    f_1233_8901_8925(System.Management.Automation.AliasInfo
                    this_param, System.Management.Automation.ScopedItemOptions
                    newOptions, bool
                    force)
                    {
                        this_param.SetOptions(newOptions, force);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1233, 8901, 8925);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1233, 8725, 8952);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1233, 8725, 8952);
                }
            }
        }

        internal void SetOptions(ScopedItemOptions newOptions, bool force)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1233, 9375, 12201);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 9606, 10047) || true) && ((_options & ScopedItemOptions.Constant) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1233, 9606, 10047);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 9688, 10004);

                    SessionStateUnauthorizedAccessException
                    e =
                    f_1233_9753_10003(f_1233_9827_9831(), SessionStateCategory.Alias, "AliasIsConstant", f_1233_9967_10002())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 10024, 10032);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1233, 9606, 10047);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 10203, 10654) || true) && (!force && (DynAbs.Tracing.TraceSender.Expression_True(1233, 10207, 10261) && (_options & ScopedItemOptions.ReadOnly) != 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1233, 10203, 10654);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 10295, 10611);

                    SessionStateUnauthorizedAccessException
                    e =
                    f_1233_10360_10610(f_1233_10434_10438(), SessionStateCategory.Alias, "AliasIsReadOnly", f_1233_10574_10609())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 10631, 10639);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1233, 10203, 10654);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 10835, 11449) || true) && ((newOptions & ScopedItemOptions.Constant) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1233, 10835, 11449);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 11070, 11406);

                    SessionStateUnauthorizedAccessException
                    e =
                    f_1233_11135_11405(f_1233_11209_11213(), SessionStateCategory.Alias, "AliasCannotBeMadeConstant", f_1233_11359_11404())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 11426, 11434);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1233, 10835, 11449);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 11465, 12152) || true) && ((newOptions & ScopedItemOptions.AllScope) == 0 && (DynAbs.Tracing.TraceSender.Expression_True(1233, 11469, 11580) && (_options & ScopedItemOptions.AllScope) != 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1233, 11465, 12152);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 11750, 12109);

                    SessionStateUnauthorizedAccessException
                    e =
                    f_1233_11815_12108(f_1233_11889_11898(this), SessionStateCategory.Alias, "AliasAllScopeOptionCannotBeRemoved", f_1233_12053_12107())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 12129, 12137);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1233, 11465, 12152);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 12168, 12190);

                _options = newOptions;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1233, 9375, 12201);

                string
                f_1233_9827_9831()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1233, 9827, 9831);
                    return return_v;
                }


                string
                f_1233_9967_10002()
                {
                    var return_v = SessionStateStrings.AliasIsConstant;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1233, 9967, 10002);
                    return return_v;
                }


                System.Management.Automation.SessionStateUnauthorizedAccessException
                f_1233_9753_10003(string
                itemName, System.Management.Automation.SessionStateCategory
                sessionStateCategory, string
                errorIdAndResourceId, string
                resourceStr)
                {
                    var return_v = new System.Management.Automation.SessionStateUnauthorizedAccessException(itemName, sessionStateCategory, errorIdAndResourceId, resourceStr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1233, 9753, 10003);
                    return return_v;
                }


                string
                f_1233_10434_10438()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1233, 10434, 10438);
                    return return_v;
                }


                string
                f_1233_10574_10609()
                {
                    var return_v = SessionStateStrings.AliasIsReadOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1233, 10574, 10609);
                    return return_v;
                }


                System.Management.Automation.SessionStateUnauthorizedAccessException
                f_1233_10360_10610(string
                itemName, System.Management.Automation.SessionStateCategory
                sessionStateCategory, string
                errorIdAndResourceId, string
                resourceStr)
                {
                    var return_v = new System.Management.Automation.SessionStateUnauthorizedAccessException(itemName, sessionStateCategory, errorIdAndResourceId, resourceStr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1233, 10360, 10610);
                    return return_v;
                }


                string
                f_1233_11209_11213()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1233, 11209, 11213);
                    return return_v;
                }


                string
                f_1233_11359_11404()
                {
                    var return_v = SessionStateStrings.AliasCannotBeMadeConstant;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1233, 11359, 11404);
                    return return_v;
                }


                System.Management.Automation.SessionStateUnauthorizedAccessException
                f_1233_11135_11405(string
                itemName, System.Management.Automation.SessionStateCategory
                sessionStateCategory, string
                errorIdAndResourceId, string
                resourceStr)
                {
                    var return_v = new System.Management.Automation.SessionStateUnauthorizedAccessException(itemName, sessionStateCategory, errorIdAndResourceId, resourceStr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1233, 11135, 11405);
                    return return_v;
                }


                string
                f_1233_11889_11898(System.Management.Automation.AliasInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1233, 11889, 11898);
                    return return_v;
                }


                string
                f_1233_12053_12107()
                {
                    var return_v = SessionStateStrings.AliasAllScopeOptionCannotBeRemoved;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1233, 12053, 12107);
                    return return_v;
                }


                System.Management.Automation.SessionStateUnauthorizedAccessException
                f_1233_11815_12108(string
                itemName, System.Management.Automation.SessionStateCategory
                sessionStateCategory, string
                errorIdAndResourceId, string
                resourceStr)
                {
                    var return_v = new System.Management.Automation.SessionStateUnauthorizedAccessException(itemName, sessionStateCategory, errorIdAndResourceId, resourceStr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1233, 11815, 12108);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1233, 9375, 12201);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1233, 9375, 12201);
            }
        }

        private ScopedItemOptions _options;

        public string Description { get; set; }

        internal string UnresolvedCommandName { get; private set; }

        public override ReadOnlyCollection<PSTypeName> OutputType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1233, 13165, 13439);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 13201, 13252);

                    CommandInfo
                    resolvedCommand = f_1233_13231_13251(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 13270, 13392) || true) && (resolvedCommand != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1233, 13270, 13392);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 13339, 13373);

                        return f_1233_13346_13372(resolvedCommand);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1233, 13270, 13392);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1233, 13412, 13424);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1233, 13165, 13439);

                    System.Management.Automation.CommandInfo
                    f_1233_13231_13251(System.Management.Automation.AliasInfo
                    this_param)
                    {
                        var return_v = this_param.ResolvedCommand;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1233, 13231, 13251);
                        return return_v;
                    }


                    System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSTypeName>
                    f_1233_13346_13372(System.Management.Automation.CommandInfo
                    this_param)
                    {
                        var return_v = this_param.OutputType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1233, 13346, 13372);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1233, 13083, 13450);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1233, 13083, 13450);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static AliasInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1233, 351, 13457);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1233, 351, 13457);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1233, 351, 13457);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1233, 351, 13457);

        System.Management.Automation.SessionState
        f_1233_1485_1505(System.Management.Automation.ExecutionContext
        this_param)
        {
            var return_v = this_param.SessionState;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1233, 1485, 1505);
            return return_v;
        }


        System.Management.Automation.SessionStateInternal
        f_1233_1485_1514(System.Management.Automation.SessionState
        this_param)
        {
            var return_v = this_param.Internal;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1233, 1485, 1514);
            return return_v;
        }


        System.Management.Automation.PSModuleInfo
        f_1233_1485_1521(System.Management.Automation.SessionStateInternal
        this_param)
        {
            var return_v = this_param.Module;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1233, 1485, 1521);
            return return_v;
        }


        static string
        f_1233_1290_1294_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1233, 1206, 1548);
            return return_v;
        }


        System.Management.Automation.SessionState
        f_1233_2881_2901(System.Management.Automation.ExecutionContext
        this_param)
        {
            var return_v = this_param.SessionState;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1233, 2881, 2901);
            return return_v;
        }


        System.Management.Automation.SessionStateInternal
        f_1233_2881_2910(System.Management.Automation.SessionState
        this_param)
        {
            var return_v = this_param.Internal;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1233, 2881, 2910);
            return return_v;
        }


        System.Management.Automation.PSModuleInfo
        f_1233_2881_2917(System.Management.Automation.SessionStateInternal
        this_param)
        {
            var return_v = this_param.Module;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1233, 2881, 2917);
            return return_v;
        }


        static string
        f_1233_2653_2657_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1233, 2489, 2944);
            return return_v;
        }

    }
}
