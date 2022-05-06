// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Management.Automation.Internal;

using Microsoft.Management.Infrastructure;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation.Runspaces
{
    public sealed class Command
    {
        public Command(string command)
        : this(f_1454_963_970_C(command), false, null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1454, 912, 1006);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1454, 912, 1006);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1454, 912, 1006);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1454, 912, 1006);
            }
        }

        public Command(string command, bool isScript)
        : this(f_1454_1489_1496_C(command), isScript, null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1454, 1423, 1535);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1454, 1423, 1535);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1454, 1423, 1535);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1454, 1423, 1535);
            }
        }

        public Command(string command, bool isScript, bool useLocalScope)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1454, 1990, 2371);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 4739, 4828);
                this.Parameters = f_1454_4795_4827();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 5048, 5098);
                this.CommandText = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 5246, 5287);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 5438, 5467);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 6255, 6329);
                this.CommandOrigin = CommandOrigin.Runspace;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 6941, 7009);
                this.DollarUnderbar = f_1454_6988_7008();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 7172, 7223);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 7922, 7999);
                this._mergeUnclaimedPreviousCommandResults = PipelineResultTypes.None;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 9539, 9631);
                this.MergeMyResult = PipelineResultTypes.None;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 9643, 9735);
                this.MergeToResult = PipelineResultTypes.None;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 10253, 10356);
                this.MergeInstructions = new PipelineResultTypes[MaxMergeType];
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 22568, 22582);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 2080, 2105);

                IsEndOfStatement = false;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 2119, 2243) || true) && (command == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 2119, 2243);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 2172, 2228);

                    throw f_1454_2178_2227("command");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 2119, 2243);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 2259, 2281);

                CommandText = command;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 2295, 2315);

                IsScript = isScript;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 2329, 2360);

                _useLocalScope = useLocalScope;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1454, 1990, 2371);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1454, 1990, 2371);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1454, 1990, 2371);
            }
        }

        internal Command(string command, bool isScript, bool? useLocalScope)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1454, 2383, 2767);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 4739, 4828);
                this.Parameters = f_1454_4795_4827();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 5048, 5098);
                this.CommandText = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 5246, 5287);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 5438, 5467);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 6255, 6329);
                this.CommandOrigin = CommandOrigin.Runspace;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 6941, 7009);
                this.DollarUnderbar = f_1454_6988_7008();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 7172, 7223);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 7922, 7999);
                this._mergeUnclaimedPreviousCommandResults = PipelineResultTypes.None;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 9539, 9631);
                this.MergeMyResult = PipelineResultTypes.None;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 9643, 9735);
                this.MergeToResult = PipelineResultTypes.None;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 10253, 10356);
                this.MergeInstructions = new PipelineResultTypes[MaxMergeType];
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 22568, 22582);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 2476, 2501);

                IsEndOfStatement = false;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 2515, 2639) || true) && (command == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 2515, 2639);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 2568, 2624);

                    throw f_1454_2574_2623("command");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 2515, 2639);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 2655, 2677);

                CommandText = command;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 2691, 2711);

                IsScript = isScript;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 2725, 2756);

                _useLocalScope = useLocalScope;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1454, 2383, 2767);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1454, 2383, 2767);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1454, 2383, 2767);
            }
        }

        internal Command(string command, bool isScript, bool? useLocalScope, bool mergeUnclaimedPreviousErrorResults)
        : this(f_1454_2909_2916_C(command), isScript, useLocalScope)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1454, 2779, 3160);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 2967, 3149) || true) && (mergeUnclaimedPreviousErrorResults)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 2967, 3149);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 3039, 3134);

                    _mergeUnclaimedPreviousCommandResults = PipelineResultTypes.Error | PipelineResultTypes.Output;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 2967, 3149);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1454, 2779, 3160);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1454, 2779, 3160);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1454, 2779, 3160);
            }
        }

        internal Command(CommandInfo commandInfo)
        : this(f_1454_3234_3245_C(commandInfo), false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1454, 3172, 3275);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1454, 3172, 3275);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1454, 3172, 3275);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1454, 3172, 3275);
            }
        }

        internal Command(CommandInfo commandInfo, bool isScript)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1454, 3287, 3523);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 4739, 4828);
                this.Parameters = f_1454_4795_4827();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 5048, 5098);
                this.CommandText = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 5246, 5287);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 5438, 5467);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 6255, 6329);
                this.CommandOrigin = CommandOrigin.Runspace;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 6941, 7009);
                this.DollarUnderbar = f_1454_6988_7008();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 7172, 7223);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 7922, 7999);
                this._mergeUnclaimedPreviousCommandResults = PipelineResultTypes.None;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 9539, 9631);
                this.MergeMyResult = PipelineResultTypes.None;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 9643, 9735);
                this.MergeToResult = PipelineResultTypes.None;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 10253, 10356);
                this.MergeInstructions = new PipelineResultTypes[MaxMergeType];
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 22568, 22582);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 3368, 3393);

                IsEndOfStatement = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 3407, 3433);

                CommandInfo = commandInfo;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 3447, 3478);

                CommandText = f_1454_3461_3477(f_1454_3461_3472());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 3492, 3512);

                IsScript = isScript;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1454, 3287, 3523);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1454, 3287, 3523);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1454, 3287, 3523);
            }
        }

        internal Command(Command command)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1454, 3720, 4421);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 4739, 4828);
                this.Parameters = f_1454_4795_4827();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 5048, 5098);
                this.CommandText = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 5246, 5287);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 5438, 5467);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 6255, 6329);
                this.CommandOrigin = CommandOrigin.Runspace;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 6941, 7009);
                this.DollarUnderbar = f_1454_6988_7008();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 7172, 7223);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 7922, 7999);
                this._mergeUnclaimedPreviousCommandResults = PipelineResultTypes.None;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 9539, 9631);
                this.MergeMyResult = PipelineResultTypes.None;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 9643, 9735);
                this.MergeToResult = PipelineResultTypes.None;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 10253, 10356);
                this.MergeInstructions = new PipelineResultTypes[MaxMergeType];
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 22568, 22582);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 3778, 3806);

                IsScript = f_1454_3789_3805(command);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 3820, 3860);

                _useLocalScope = command._useLocalScope;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 3874, 3908);

                CommandText = f_1454_3888_3907(command);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 3922, 3968);

                MergeInstructions = f_1454_3942_3967(command);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 3982, 4020);

                MergeMyResult = f_1454_3998_4019(command);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 4034, 4072);

                MergeToResult = f_1454_4050_4071(command);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 4086, 4172);

                _mergeUnclaimedPreviousCommandResults = command._mergeUnclaimedPreviousCommandResults;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 4186, 4230);

                IsEndOfStatement = f_1454_4205_4229(command);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 4246, 4410);
                    foreach (CommandParameter param in f_1454_4281_4299_I(f_1454_4281_4299(command)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 4246, 4410);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 4333, 4395);

                        f_1454_4333_4394(f_1454_4333_4343(), f_1454_4348_4393(f_1454_4369_4379(param), f_1454_4381_4392(param)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 4246, 4410);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1454, 1, 165);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1454, 1, 165);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1454, 3720, 4421);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1454, 3720, 4421);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1454, 3720, 4421);
            }
        }

        public CommandParameterCollection Parameters { get; }

        public string CommandText { get; }

        internal CommandInfo CommandInfo { get; }

        public bool IsScript { get; }

        public bool UseLocalScope
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1454, 5896, 5935);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 5902, 5933);

                    return _useLocalScope ?? (DynAbs.Tracing.TraceSender.Expression_Null<bool?>(1454, 5909, 5932) ?? false);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1454, 5896, 5935);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1454, 5846, 5946);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1454, 5846, 5946);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public CommandOrigin CommandOrigin { get; set; }

        internal bool? UseLocalScopeNullable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1454, 6610, 6640);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 6616, 6638);

                    return _useLocalScope;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1454, 6610, 6640);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1454, 6549, 6651);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1454, 6549, 6651);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal object DollarUnderbar { get; set; }

        public bool IsEndOfStatement { get; internal set; }

        internal Command Clone()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1454, 7524, 7609);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 7573, 7598);

                return f_1454_7580_7597(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1454, 7524, 7609);

                System.Management.Automation.Runspaces.Command
                f_1454_7580_7597(System.Management.Automation.Runspaces.Command
                command)
                {
                    var return_v = new System.Management.Automation.Runspaces.Command(command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 7580, 7597);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1454, 7524, 7609);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1454, 7524, 7609);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1454, 7739, 7827);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 7797, 7816);

                return f_1454_7804_7815();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1454, 7739, 7827);

                string
                f_1454_7804_7815()
                {
                    var return_v = CommandText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 7804, 7815);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1454, 7739, 7827);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1454, 7739, 7827);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private PipelineResultTypes _mergeUnclaimedPreviousCommandResults;

        public PipelineResultTypes MergeUnclaimedPreviousCommandResults
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1454, 8747, 8843);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 8783, 8828);

                    return _mergeUnclaimedPreviousCommandResults;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1454, 8747, 8843);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1454, 8659, 9357);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1454, 8659, 9357);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1454, 8859, 9346);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 8895, 9068) || true) && (value == PipelineResultTypes.None)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 8895, 9068);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 8974, 9020);

                        _mergeUnclaimedPreviousCommandResults = value;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 9042, 9049);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 8895, 9068);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 9088, 9265) || true) && (value != (PipelineResultTypes.Error | PipelineResultTypes.Output))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 9088, 9265);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 9199, 9246);

                        throw f_1454_9205_9245();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 9088, 9265);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 9285, 9331);

                    _mergeUnclaimedPreviousCommandResults = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1454, 8859, 9346);

                    System.Management.Automation.PSNotSupportedException
                    f_1454_9205_9245()
                    {
                        var return_v = PSTraceSource.NewNotSupportedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 9205, 9245);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1454, 8659, 9357);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1454, 8659, 9357);
                }
            }
        }

        internal PipelineResultTypes MergeMyResult { get; private set; }

        internal PipelineResultTypes MergeToResult { get; private set; }

        //
        // For V3 we allow merging from all streams except Output.
        //
        internal enum MergeType
        {
            Error = 0,
            Warning = 1,
            Verbose = 2,
            Debug = 3,
            Information = 4
        }

        internal const int
        MaxMergeType = (int)(MergeType.Information + 1)
        ;

        internal PipelineResultTypes[] MergeInstructions { get; set; }

        public void MergeMyResults(PipelineResultTypes myResult, PipelineResultTypes toResult)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1454, 11052, 13644);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 11163, 11605) || true) && (myResult == PipelineResultTypes.None && (DynAbs.Tracing.TraceSender.Expression_True(1454, 11167, 11243) && toResult == PipelineResultTypes.None))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 11163, 11605);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 11329, 11354);

                    MergeMyResult = myResult;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 11372, 11397);

                    MergeToResult = toResult;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 11426, 11431);

                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 11417, 11563) || true) && (i < MaxMergeType)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 11451, 11454)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 11417, 11563))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 11417, 11563);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 11496, 11544);

                            f_1454_11496_11513()[i] = PipelineResultTypes.None;
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1454, 1, 147);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1454, 1, 147);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 11583, 11590);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 11163, 11605);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 11658, 11880) || true) && (myResult == PipelineResultTypes.None || (DynAbs.Tracing.TraceSender.Expression_False(1454, 11662, 11740) || myResult == PipelineResultTypes.Output))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 11658, 11880);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 11774, 11865);

                    throw f_1454_11780_11864("myResult", f_1454_11827_11863());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 11658, 11880);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 11896, 12124) || true) && (myResult == PipelineResultTypes.Error && (DynAbs.Tracing.TraceSender.Expression_True(1454, 11900, 11979) && toResult != PipelineResultTypes.Output))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 11896, 12124);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 12013, 12109);

                    throw f_1454_12019_12108("toResult", f_1454_12066_12107());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 11896, 12124);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 12140, 12362) || true) && (toResult != PipelineResultTypes.Output && (DynAbs.Tracing.TraceSender.Expression_True(1454, 12144, 12222) && toResult != PipelineResultTypes.Null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 12140, 12362);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 12256, 12347);

                    throw f_1454_12262_12346("toResult", f_1454_12309_12345());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 12140, 12362);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 12426, 12584) || true) && (myResult == PipelineResultTypes.Error)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 12426, 12584);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 12501, 12526);

                    MergeMyResult = myResult;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 12544, 12569);

                    MergeToResult = toResult;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 12426, 12584);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 12649, 12829) || true) && (myResult == PipelineResultTypes.Error || (DynAbs.Tracing.TraceSender.Expression_False(1454, 12653, 12729) || myResult == PipelineResultTypes.All))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 12649, 12829);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 12763, 12814);

                    f_1454_12763_12780()[(int)MergeType.Error] = toResult;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 12649, 12829);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 12845, 13029) || true) && (myResult == PipelineResultTypes.Warning || (DynAbs.Tracing.TraceSender.Expression_False(1454, 12849, 12927) || myResult == PipelineResultTypes.All))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 12845, 13029);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 12961, 13014);

                    f_1454_12961_12978()[(int)MergeType.Warning] = toResult;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 12845, 13029);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 13045, 13229) || true) && (myResult == PipelineResultTypes.Verbose || (DynAbs.Tracing.TraceSender.Expression_False(1454, 13049, 13127) || myResult == PipelineResultTypes.All))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 13045, 13229);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 13161, 13214);

                    f_1454_13161_13178()[(int)MergeType.Verbose] = toResult;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 13045, 13229);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 13245, 13425) || true) && (myResult == PipelineResultTypes.Debug || (DynAbs.Tracing.TraceSender.Expression_False(1454, 13249, 13325) || myResult == PipelineResultTypes.All))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 13245, 13425);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 13359, 13410);

                    f_1454_13359_13376()[(int)MergeType.Debug] = toResult;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 13245, 13425);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 13441, 13633) || true) && (myResult == PipelineResultTypes.Information || (DynAbs.Tracing.TraceSender.Expression_False(1454, 13445, 13527) || myResult == PipelineResultTypes.All))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 13441, 13633);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 13561, 13618);

                    f_1454_13561_13578()[(int)MergeType.Information] = toResult;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 13441, 13633);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1454, 11052, 13644);

                System.Management.Automation.Runspaces.PipelineResultTypes[]
                f_1454_11496_11513()
                {
                    var return_v = MergeInstructions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 11496, 11513);
                    return return_v;
                }


                string
                f_1454_11827_11863()
                {
                    var return_v = RunspaceStrings.InvalidMyResultError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 11827, 11863);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1454_11780_11864(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 11780, 11864);
                    return return_v;
                }


                string
                f_1454_12066_12107()
                {
                    var return_v = RunspaceStrings.InvalidValueToResultError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 12066, 12107);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1454_12019_12108(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 12019, 12108);
                    return return_v;
                }


                string
                f_1454_12309_12345()
                {
                    var return_v = RunspaceStrings.InvalidValueToResult;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 12309, 12345);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1454_12262_12346(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 12262, 12346);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineResultTypes[]
                f_1454_12763_12780()
                {
                    var return_v = MergeInstructions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 12763, 12780);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineResultTypes[]
                f_1454_12961_12978()
                {
                    var return_v = MergeInstructions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 12961, 12978);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineResultTypes[]
                f_1454_13161_13178()
                {
                    var return_v = MergeInstructions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 13161, 13178);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineResultTypes[]
                f_1454_13359_13376()
                {
                    var return_v = MergeInstructions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 13359, 13376);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineResultTypes[]
                f_1454_13561_13578()
                {
                    var return_v = MergeInstructions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 13561, 13578);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1454, 11052, 13644);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1454, 11052, 13644);
            }
        }

        private
                void
                SetMergeSettingsOnCommandProcessor(CommandProcessorBase commandProcessor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1454, 13813, 15828);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 13942, 14019);

                f_1454_13942_14018(commandProcessor != null, "caller should validate the parameter");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 14035, 14120);

                MshCommandRuntime
                mcr = f_1454_14059_14083(commandProcessor).commandRuntime as MshCommandRuntime
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 14136, 14469) || true) && (_mergeUnclaimedPreviousCommandResults != PipelineResultTypes.None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 14136, 14469);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 14332, 14454) || true) && (mcr != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 14332, 14454);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 14389, 14435);

                        mcr.MergeUnclaimedPreviousErrorResults = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 14332, 14454);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 14136, 14469);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 14514, 14771) || true) && (f_1454_14518_14535()[(int)MergeType.Error] == PipelineResultTypes.Output)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 14514, 14771);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 14696, 14756);

                    mcr.ErrorMergeTo = MshCommandRuntime.MergeDataStream.Output;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 14514, 14771);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 14818, 14889);

                PipelineResultTypes
                toType = f_1454_14847_14864()[(int)MergeType.Warning]
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 14903, 15046) || true) && (toType != PipelineResultTypes.None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 14903, 15046);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 14975, 15031);

                    mcr.WarningOutputPipe = f_1454_14999_15030(this, toType, mcr);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 14903, 15046);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 15093, 15144);

                toType = f_1454_15102_15119()[(int)MergeType.Verbose];

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 15158, 15301) || true) && (toType != PipelineResultTypes.None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 15158, 15301);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 15230, 15286);

                    mcr.VerboseOutputPipe = f_1454_15254_15285(this, toType, mcr);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 15158, 15301);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 15346, 15395);

                toType = f_1454_15355_15372()[(int)MergeType.Debug];

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 15409, 15550) || true) && (toType != PipelineResultTypes.None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 15409, 15550);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 15481, 15535);

                    mcr.DebugOutputPipe = f_1454_15503_15534(this, toType, mcr);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 15409, 15550);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 15601, 15656);

                toType = f_1454_15610_15627()[(int)MergeType.Information];

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 15670, 15817) || true) && (toType != PipelineResultTypes.None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 15670, 15817);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 15742, 15802);

                    mcr.InformationOutputPipe = f_1454_15770_15801(this, toType, mcr);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 15670, 15817);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1454, 13813, 15828);

                int
                f_1454_13942_14018(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 13942, 14018);
                    return 0;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1454_14059_14083(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 14059, 14083);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineResultTypes[]
                f_1454_14518_14535()
                {
                    var return_v = MergeInstructions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 14518, 14535);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineResultTypes[]
                f_1454_14847_14864()
                {
                    var return_v = MergeInstructions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 14847, 14864);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1454_14999_15030(System.Management.Automation.Runspaces.Command
                this_param, System.Management.Automation.Runspaces.PipelineResultTypes
                toType, System.Management.Automation.MshCommandRuntime
                mcr)
                {
                    var return_v = this_param.GetRedirectionPipe(toType, mcr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 14999, 15030);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineResultTypes[]
                f_1454_15102_15119()
                {
                    var return_v = MergeInstructions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 15102, 15119);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1454_15254_15285(System.Management.Automation.Runspaces.Command
                this_param, System.Management.Automation.Runspaces.PipelineResultTypes
                toType, System.Management.Automation.MshCommandRuntime
                mcr)
                {
                    var return_v = this_param.GetRedirectionPipe(toType, mcr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 15254, 15285);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineResultTypes[]
                f_1454_15355_15372()
                {
                    var return_v = MergeInstructions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 15355, 15372);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1454_15503_15534(System.Management.Automation.Runspaces.Command
                this_param, System.Management.Automation.Runspaces.PipelineResultTypes
                toType, System.Management.Automation.MshCommandRuntime
                mcr)
                {
                    var return_v = this_param.GetRedirectionPipe(toType, mcr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 15503, 15534);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineResultTypes[]
                f_1454_15610_15627()
                {
                    var return_v = MergeInstructions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 15610, 15627);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1454_15770_15801(System.Management.Automation.Runspaces.Command
                this_param, System.Management.Automation.Runspaces.PipelineResultTypes
                toType, System.Management.Automation.MshCommandRuntime
                mcr)
                {
                    var return_v = this_param.GetRedirectionPipe(toType, mcr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 15770, 15801);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1454, 13813, 15828);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1454, 13813, 15828);
            }
        }

        private Pipe GetRedirectionPipe(
                    PipelineResultTypes toType,
                    MshCommandRuntime mcr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1454, 15840, 16196);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 15974, 16085) || true) && (toType == PipelineResultTypes.Output)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 15974, 16085);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 16048, 16070);

                    return f_1454_16055_16069(mcr);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 15974, 16085);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 16101, 16124);

                Pipe
                pipe = f_1454_16113_16123()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 16138, 16159);

                pipe.NullPipe = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 16173, 16185);

                return pipe;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1454, 15840, 16196);

                System.Management.Automation.Internal.Pipe
                f_1454_16055_16069(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.OutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 16055, 16069);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1454_16113_16123()
                {
                    var return_v = new System.Management.Automation.Internal.Pipe();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 16113, 16123);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1454, 15840, 16196);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1454, 15840, 16196);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal
                CommandProcessorBase
                CreateCommandProcessor
                (
                    ExecutionContext executionContext,
                    bool addToHistory,
                    CommandOrigin origin
                )
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1454, 16522, 22042);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 16753, 16829);

                f_1454_16753_16828(executionContext != null, "Caller should verify the parameters");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 16845, 16887);

                CommandProcessorBase
                commandProcessorBase
                = default(CommandProcessorBase);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 16903, 20926) || true) && (f_1454_16907_16915())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 16903, 20926);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 16949, 17313) || true) && ((f_1454_16954_16983(executionContext) == PSLanguageMode.NoLanguage) && (DynAbs.Tracing.TraceSender.Expression_True(1454, 16953, 17083) && (origin == Automation.CommandOrigin.Runspace)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 16949, 17313);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 17125, 17294);

                        throw f_1454_17131_17293(f_1454_17172_17183(), typeof(ParseException), null, "ScriptsNotAllowed", f_1454_17261_17292());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 16949, 17313);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 17333, 17427);

                    ScriptBlock
                    scriptBlock = f_1454_17359_17426(f_1454_17359_17382(executionContext), f_1454_17400_17411(), addToHistory)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 17445, 17608) || true) && (origin == Automation.CommandOrigin.Internal)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 17445, 17608);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 17534, 17589);

                        scriptBlock.LanguageMode = PSLanguageMode.FullLanguage;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 17445, 17608);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 17777, 18703);

                    switch (f_1454_17785_17809(scriptBlock))
                    {

                        case PSLanguageMode.RestrictedLanguage:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 17777, 18703);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 17916, 17971);

                            f_1454_17916_17970(scriptBlock, null, null, false);
                            DynAbs.Tracing.TraceSender.TraceBreak(1454, 17997, 18003);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 17777, 18703);

                        case PSLanguageMode.FullLanguage:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 17777, 18703);
                            DynAbs.Tracing.TraceSender.TraceBreak(1454, 18168, 18174);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 17777, 18703);

                        case PSLanguageMode.ConstrainedLanguage:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 17777, 18703);
                            DynAbs.Tracing.TraceSender.TraceBreak(1454, 18334, 18340);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 17777, 18703);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 17777, 18703);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 18452, 18550);

                            f_1454_18452_18549(false, "Invalid language mode was set when building a ScriptCommandProcessor");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 18576, 18684);

                            throw f_1454_18582_18683("Invalid language mode was set when building a ScriptCommandProcessor");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 17777, 18703);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 18723, 19717) || true) && (f_1454_18727_18756(scriptBlock))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 18723, 19717);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 18798, 18888);

                        FunctionInfo
                        functionInfo = f_1454_18826_18887(string.Empty, scriptBlock, executionContext)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 18910, 19150);

                        commandProcessorBase = f_1454_18933_19149(functionInfo, executionContext, _useLocalScope ?? (DynAbs.Tracing.TraceSender.Expression_Null<bool?>(1454, 19051, 19074) ?? false), fromScriptFile: false, sessionState: f_1454_19113_19148(executionContext));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 18723, 19717);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 18723, 19717);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 19232, 19698);

                        commandProcessorBase = f_1454_19255_19697(scriptBlock, executionContext, _useLocalScope ?? (DynAbs.Tracing.TraceSender.Expression_Null<bool?>(1454, 19390, 19413) ?? false), origin, f_1454_19571_19606(executionContext), f_1454_19682_19696());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 18723, 19717);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 16903, 20926);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 16903, 20926);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 19894, 20774) || true) && ((f_1454_19899_19922(_useLocalScope)) && (DynAbs.Tracing.TraceSender.Expression_True(1454, 19898, 19950) && (f_1454_19928_19949_M(!_useLocalScope.Value))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 19894, 20774);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 19992, 20755);

                        switch (f_1454_20000_20029(executionContext))
                        {

                            case PSLanguageMode.RestrictedLanguage:
                            case PSLanguageMode.NoLanguage:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 19992, 20755);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 20205, 20481);

                                string
                                message = f_1454_20222_20480(f_1454_20240_20279(), "UseLocalScope", f_1454_20364_20408(PSLanguageMode.RestrictedLanguage), f_1454_20443_20479(PSLanguageMode.NoLanguage))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 20511, 20547);

                                throw f_1454_20517_20546(message);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 19992, 20755);

                            case PSLanguageMode.FullLanguage:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 19992, 20755);
                                DynAbs.Tracing.TraceSender.TraceBreak(1454, 20726, 20732);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 19992, 20755);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 19894, 20774);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 20794, 20911);

                    commandProcessorBase = f_1454_20817_20910(f_1454_20817_20850(executionContext), f_1454_20874_20885(), origin, _useLocalScope);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 16903, 20926);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 20942, 20993);

                CommandParameterCollection
                parameters = f_1454_20982_20992()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 21009, 21482) || true) && (parameters != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 21009, 21482);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 21065, 21135);

                    bool
                    isNativeCommand = commandProcessorBase is NativeCommandProcessor
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 21153, 21467);
                        foreach (CommandParameter publicParameter in f_1454_21198_21208_I(parameters))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 21153, 21467);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 21250, 21373);

                            CommandParameterInternal
                            internalParameter = f_1454_21295_21372(publicParameter, isNativeCommand)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 21395, 21448);

                            f_1454_21395_21447(commandProcessorBase, internalParameter);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 21153, 21467);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1454, 1, 315);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1454, 1, 315);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 21009, 21482);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 21498, 21516);

                string
                helpTarget
                = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 21530, 21556);

                HelpCategory
                helpCategory
                = default(HelpCategory);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 21570, 21875) || true) && (f_1454_21574_21644(commandProcessorBase, out helpTarget, out helpCategory))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 21570, 21875);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 21678, 21860);

                    commandProcessorBase = f_1454_21701_21859(executionContext, helpTarget, helpCategory);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 21570, 21875);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 21930, 21987);

                f_1454_21930_21986(this, commandProcessorBase);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 22003, 22031);

                return commandProcessorBase;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1454, 16522, 22042);

                int
                f_1454_16753_16828(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 16753, 16828);
                    return 0;
                }


                bool
                f_1454_16907_16915()
                {
                    var return_v = IsScript;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 16907, 16915);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1454_16954_16983(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 16954, 16983);
                    return return_v;
                }


                string
                f_1454_17172_17183()
                {
                    var return_v = CommandText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 17172, 17183);
                    return return_v;
                }


                string
                f_1454_17261_17292()
                {
                    var return_v = ParserStrings.ScriptsNotAllowed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 17261, 17292);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1454_17131_17293(string
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException((object)targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 17131, 17293);
                    return return_v;
                }


                System.Management.Automation.AutomationEngine
                f_1454_17359_17382(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Engine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 17359, 17382);
                    return return_v;
                }


                string
                f_1454_17400_17411()
                {
                    var return_v = CommandText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 17400, 17411);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1454_17359_17426(System.Management.Automation.AutomationEngine
                this_param, string
                script, bool
                addToHistory)
                {
                    var return_v = this_param.ParseScriptBlock(script, addToHistory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 17359, 17426);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode?
                f_1454_17785_17809(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 17785, 17809);
                    return return_v;
                }


                int
                f_1454_17916_17970(System.Management.Automation.ScriptBlock
                this_param, System.Collections.Generic.IEnumerable<string>
                allowedCommands, System.Collections.Generic.IEnumerable<string>
                allowedVariables, bool
                allowEnvironmentVariables)
                {
                    this_param.CheckRestrictedLanguage(allowedCommands, allowedVariables, allowEnvironmentVariables);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 17916, 17970);
                    return 0;
                }


                int
                f_1454_18452_18549(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 18452, 18549);
                    return 0;
                }


                System.InvalidOperationException
                f_1454_18582_18683(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 18582, 18683);
                    return return_v;
                }


                bool
                f_1454_18727_18756(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.UsesCmdletBinding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 18727, 18756);
                    return return_v;
                }


                System.Management.Automation.FunctionInfo
                f_1454_18826_18887(string
                name, System.Management.Automation.ScriptBlock
                function, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new System.Management.Automation.FunctionInfo(name, function, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 18826, 18887);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1454_19113_19148(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 19113, 19148);
                    return return_v;
                }


                System.Management.Automation.CommandProcessor
                f_1454_18933_19149(System.Management.Automation.FunctionInfo
                scriptCommandInfo, System.Management.Automation.ExecutionContext
                context, bool
                useLocalScope, bool
                fromScriptFile, System.Management.Automation.SessionStateInternal
                sessionState)
                {
                    var return_v = new System.Management.Automation.CommandProcessor((System.Management.Automation.IScriptCommandInfo)scriptCommandInfo, context, useLocalScope, fromScriptFile: fromScriptFile, sessionState: sessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 18933, 19149);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1454_19571_19606(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 19571, 19606);
                    return return_v;
                }


                object
                f_1454_19682_19696()
                {
                    var return_v = DollarUnderbar;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 19682, 19696);
                    return return_v;
                }


                System.Management.Automation.DlrScriptCommandProcessor
                f_1454_19255_19697(System.Management.Automation.ScriptBlock
                scriptBlock, System.Management.Automation.ExecutionContext
                context, bool
                useNewScope, System.Management.Automation.CommandOrigin
                origin, System.Management.Automation.SessionStateInternal
                sessionState, object
                dollarUnderbar)
                {
                    var return_v = new System.Management.Automation.DlrScriptCommandProcessor(scriptBlock, context, useNewScope, origin, sessionState, dollarUnderbar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 19255, 19697);
                    return return_v;
                }


                bool
                f_1454_19899_19922(bool?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 19899, 19922);
                    return return_v;
                }


                bool
                f_1454_19928_19949_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 19928, 19949);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1454_20000_20029(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 20000, 20029);
                    return return_v;
                }


                string
                f_1454_20240_20279()
                {
                    var return_v = RunspaceStrings.UseLocalScopeNotAllowed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 20240, 20279);
                    return return_v;
                }


                string
                f_1454_20364_20408(System.Management.Automation.PSLanguageMode
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 20364, 20408);
                    return return_v;
                }


                string
                f_1454_20443_20479(System.Management.Automation.PSLanguageMode
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 20443, 20479);
                    return return_v;
                }


                string
                f_1454_20222_20480(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 20222, 20480);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1454_20517_20546(string
                message)
                {
                    var return_v = new System.Management.Automation.RuntimeException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 20517, 20546);
                    return return_v;
                }


                System.Management.Automation.CommandDiscovery
                f_1454_20817_20850(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CommandDiscovery;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 20817, 20850);
                    return return_v;
                }


                string
                f_1454_20874_20885()
                {
                    var return_v = CommandText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 20874, 20885);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1454_20817_20910(System.Management.Automation.CommandDiscovery
                this_param, string
                commandName, System.Management.Automation.CommandOrigin
                commandOrigin, bool?
                useLocalScope)
                {
                    var return_v = this_param.LookupCommandProcessor(commandName, commandOrigin, useLocalScope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 20817, 20910);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandParameterCollection
                f_1454_20982_20992()
                {
                    var return_v = Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 20982, 20992);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1454_21295_21372(System.Management.Automation.Runspaces.CommandParameter
                publicParameter, bool
                forNativeCommand)
                {
                    var return_v = CommandParameter.ToCommandParameterInternal(publicParameter, forNativeCommand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 21295, 21372);
                    return return_v;
                }


                int
                f_1454_21395_21447(System.Management.Automation.CommandProcessorBase
                this_param, System.Management.Automation.CommandParameterInternal
                parameter)
                {
                    this_param.AddParameter(parameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 21395, 21447);
                    return 0;
                }


                System.Management.Automation.Runspaces.CommandParameterCollection
                f_1454_21198_21208_I(System.Management.Automation.Runspaces.CommandParameterCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 21198, 21208);
                    return return_v;
                }


                bool
                f_1454_21574_21644(System.Management.Automation.CommandProcessorBase
                this_param, out string
                helpTarget, out System.Management.Automation.HelpCategory
                helpCategory)
                {
                    var return_v = this_param.IsHelpRequested(out helpTarget, out helpCategory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 21574, 21644);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1454_21701_21859(System.Management.Automation.ExecutionContext
                context, string
                helpTarget, System.Management.Automation.HelpCategory
                helpCategory)
                {
                    var return_v = CommandProcessorBase.CreateGetHelpCommandProcessor(context, helpTarget, helpCategory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 21701, 21859);
                    return return_v;
                }


                int
                f_1454_21930_21986(System.Management.Automation.Runspaces.Command
                this_param, System.Management.Automation.CommandProcessorBase
                commandProcessor)
                {
                    this_param.SetMergeSettingsOnCommandProcessor(commandProcessor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 21930, 21986);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1454, 16522, 22042);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1454, 16522, 22042);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool? _useLocalScope;

        internal static Command FromPSObjectForRemoting(PSObject commandAsPSObject)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1454, 23405, 26710);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 23505, 23649) || true) && (commandAsPSObject == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 23505, 23649);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 23568, 23634);

                    throw f_1454_23574_23633("commandAsPSObject");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 23505, 23649);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 23665, 23781);

                string
                commandText = f_1454_23686_23780(commandAsPSObject, RemoteDataNameStrings.CommandText)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 23795, 23901);

                bool
                isScript = f_1454_23811_23900(commandAsPSObject, RemoteDataNameStrings.IsScript)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 23915, 24049);

                bool?
                useLocalScopeNullable = f_1454_23945_24048(commandAsPSObject, RemoteDataNameStrings.UseLocalScopeNullable)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 24063, 24139);

                Command
                command = f_1454_24081_24138(commandText, isScript, useLocalScopeNullable)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 24203, 24349);

                PipelineResultTypes
                mergeMyResult = f_1454_24239_24348(commandAsPSObject, RemoteDataNameStrings.MergeMyResult)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 24363, 24509);

                PipelineResultTypes
                mergeToResult = f_1454_24399_24508(commandAsPSObject, RemoteDataNameStrings.MergeToResult)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 24523, 24576);

                f_1454_24523_24575(command, mergeMyResult, mergeToResult);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 24592, 24772);

                command.MergeUnclaimedPreviousCommandResults = f_1454_24639_24771(commandAsPSObject, RemoteDataNameStrings.MergeUnclaimedPreviousCommandResults);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 24882, 25162) || true) && (f_1454_24886_24948(f_1454_24886_24914(commandAsPSObject), RemoteDataNameStrings.MergeError) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 24882, 25162);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 24990, 25147);

                    f_1454_24990_25015(command)[(int)MergeType.Error] = f_1454_25040_25146(commandAsPSObject, RemoteDataNameStrings.MergeError);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 24882, 25162);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 25178, 25464) || true) && (f_1454_25182_25246(f_1454_25182_25210(commandAsPSObject), RemoteDataNameStrings.MergeWarning) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 25178, 25464);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 25288, 25449);

                    f_1454_25288_25313(command)[(int)MergeType.Warning] = f_1454_25340_25448(commandAsPSObject, RemoteDataNameStrings.MergeWarning);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 25178, 25464);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 25480, 25766) || true) && (f_1454_25484_25548(f_1454_25484_25512(commandAsPSObject), RemoteDataNameStrings.MergeVerbose) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 25480, 25766);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 25590, 25751);

                    f_1454_25590_25615(command)[(int)MergeType.Verbose] = f_1454_25642_25750(commandAsPSObject, RemoteDataNameStrings.MergeVerbose);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 25480, 25766);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 25782, 26062) || true) && (f_1454_25786_25848(f_1454_25786_25814(commandAsPSObject), RemoteDataNameStrings.MergeDebug) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 25782, 26062);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 25890, 26047);

                    f_1454_25890_25915(command)[(int)MergeType.Debug] = f_1454_25940_26046(commandAsPSObject, RemoteDataNameStrings.MergeDebug);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 25782, 26062);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 26078, 26376) || true) && (f_1454_26082_26150(f_1454_26082_26110(commandAsPSObject), RemoteDataNameStrings.MergeInformation) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 26078, 26376);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 26192, 26361);

                    f_1454_26192_26217(command)[(int)MergeType.Information] = f_1454_26248_26360(commandAsPSObject, RemoteDataNameStrings.MergeInformation);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 26078, 26376);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 26392, 26668);
                    foreach (PSObject parameterAsPSObject in f_1454_26433_26533_I(f_1454_26433_26533(commandAsPSObject, RemoteDataNameStrings.Parameters)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 26392, 26668);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 26567, 26653);

                        f_1454_26567_26652(f_1454_26567_26585(command), f_1454_26590_26651(parameterAsPSObject));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 26392, 26668);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1454, 1, 277);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1454, 1, 277);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 26684, 26699);

                return command;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1454, 23405, 26710);

                System.Management.Automation.PSArgumentNullException
                f_1454_23574_23633(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 23574, 23633);
                    return return_v;
                }


                string
                f_1454_23686_23780(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.GetPropertyValue<string>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 23686, 23780);
                    return return_v;
                }


                bool
                f_1454_23811_23900(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.GetPropertyValue<bool>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 23811, 23900);
                    return return_v;
                }


                bool?
                f_1454_23945_24048(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.GetPropertyValue<bool?>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 23945, 24048);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Command
                f_1454_24081_24138(string
                command, bool
                isScript, bool?
                useLocalScope)
                {
                    var return_v = new System.Management.Automation.Runspaces.Command(command, isScript, useLocalScope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 24081, 24138);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineResultTypes
                f_1454_24239_24348(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.GetPropertyValue<PipelineResultTypes>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 24239, 24348);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineResultTypes
                f_1454_24399_24508(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.GetPropertyValue<PipelineResultTypes>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 24399, 24508);
                    return return_v;
                }


                int
                f_1454_24523_24575(System.Management.Automation.Runspaces.Command
                this_param, System.Management.Automation.Runspaces.PipelineResultTypes
                myResult, System.Management.Automation.Runspaces.PipelineResultTypes
                toResult)
                {
                    this_param.MergeMyResults(myResult, toResult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 24523, 24575);
                    return 0;
                }


                System.Management.Automation.Runspaces.PipelineResultTypes
                f_1454_24639_24771(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.GetPropertyValue<PipelineResultTypes>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 24639, 24771);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1454_24886_24914(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 24886, 24914);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1454_24886_24948(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 24886, 24948);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineResultTypes[]
                f_1454_24990_25015(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.MergeInstructions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 24990, 25015);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineResultTypes
                f_1454_25040_25146(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.GetPropertyValue<PipelineResultTypes>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 25040, 25146);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1454_25182_25210(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 25182, 25210);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1454_25182_25246(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 25182, 25246);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineResultTypes[]
                f_1454_25288_25313(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.MergeInstructions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 25288, 25313);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineResultTypes
                f_1454_25340_25448(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.GetPropertyValue<PipelineResultTypes>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 25340, 25448);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1454_25484_25512(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 25484, 25512);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1454_25484_25548(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 25484, 25548);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineResultTypes[]
                f_1454_25590_25615(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.MergeInstructions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 25590, 25615);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineResultTypes
                f_1454_25642_25750(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.GetPropertyValue<PipelineResultTypes>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 25642, 25750);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1454_25786_25814(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 25786, 25814);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1454_25786_25848(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 25786, 25848);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineResultTypes[]
                f_1454_25890_25915(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.MergeInstructions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 25890, 25915);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineResultTypes
                f_1454_25940_26046(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.GetPropertyValue<PipelineResultTypes>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 25940, 26046);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1454_26082_26110(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 26082, 26110);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1454_26082_26150(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 26082, 26150);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineResultTypes[]
                f_1454_26192_26217(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.MergeInstructions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 26192, 26217);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineResultTypes
                f_1454_26248_26360(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.GetPropertyValue<PipelineResultTypes>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 26248, 26360);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSObject>
                f_1454_26433_26533(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.EnumerateListProperty<PSObject>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 26433, 26533);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandParameterCollection
                f_1454_26567_26585(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 26567, 26585);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandParameter
                f_1454_26590_26651(System.Management.Automation.PSObject
                parameterAsPSObject)
                {
                    var return_v = CommandParameter.FromPSObjectForRemoting(parameterAsPSObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 26590, 26651);
                    return return_v;
                }


                int
                f_1454_26567_26652(System.Management.Automation.Runspaces.CommandParameterCollection
                this_param, System.Management.Automation.Runspaces.CommandParameter
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 26567, 26652);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSObject>
                f_1454_26433_26533_I(System.Collections.Generic.IEnumerable<System.Management.Automation.PSObject>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 26433, 26533);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1454, 23405, 26710);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1454, 23405, 26710);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal PSObject ToPSObjectForRemoting(Version psRPVersion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1454, 27052, 32349);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 27137, 27204);

                PSObject
                commandAsPSObject = f_1454_27166_27203()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 27220, 27326);

                f_1454_27220_27325(f_1454_27220_27248(commandAsPSObject), f_1454_27253_27324(RemoteDataNameStrings.CommandText, f_1454_27307_27323(this)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 27340, 27440);

                f_1454_27340_27439(f_1454_27340_27368(commandAsPSObject), f_1454_27373_27438(RemoteDataNameStrings.IsScript, f_1454_27424_27437(this)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 27454, 27580);

                f_1454_27454_27579(f_1454_27454_27482(commandAsPSObject), f_1454_27487_27578(RemoteDataNameStrings.UseLocalScopeNullable, f_1454_27551_27577(this)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 27644, 27754);

                f_1454_27644_27753(f_1454_27644_27672(commandAsPSObject), f_1454_27677_27752(RemoteDataNameStrings.MergeMyResult, f_1454_27733_27751(this)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 27768, 27878);

                f_1454_27768_27877(f_1454_27768_27796(commandAsPSObject), f_1454_27801_27876(RemoteDataNameStrings.MergeToResult, f_1454_27857_27875(this)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 27894, 28050);

                f_1454_27894_28049(f_1454_27894_27922(commandAsPSObject), f_1454_27927_28048(RemoteDataNameStrings.MergeUnclaimedPreviousCommandResults, f_1454_28006_28047(this)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 28066, 31878) || true) && (psRPVersion != null && (DynAbs.Tracing.TraceSender.Expression_True(1454, 28070, 28166) && psRPVersion >= RemotingConstants.ProtocolVersionWin10RTM))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 28066, 31878);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 28242, 28370);

                    f_1454_28242_28369(f_1454_28242_28270(commandAsPSObject), f_1454_28275_28368(RemoteDataNameStrings.MergeError, f_1454_28328_28345()[(int)MergeType.Error]));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 28388, 28520);

                    f_1454_28388_28519(f_1454_28388_28416(commandAsPSObject), f_1454_28421_28518(RemoteDataNameStrings.MergeWarning, f_1454_28476_28493()[(int)MergeType.Warning]));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 28538, 28670);

                    f_1454_28538_28669(f_1454_28538_28566(commandAsPSObject), f_1454_28571_28668(RemoteDataNameStrings.MergeVerbose, f_1454_28626_28643()[(int)MergeType.Verbose]));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 28688, 28816);

                    f_1454_28688_28815(f_1454_28688_28716(commandAsPSObject), f_1454_28721_28814(RemoteDataNameStrings.MergeDebug, f_1454_28774_28791()[(int)MergeType.Debug]));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 28834, 28974);

                    f_1454_28834_28973(f_1454_28834_28862(commandAsPSObject), f_1454_28867_28972(RemoteDataNameStrings.MergeInformation, f_1454_28926_28943()[(int)MergeType.Information]));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 28066, 31878);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 28066, 31878);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 29008, 31878) || true) && (psRPVersion != null && (DynAbs.Tracing.TraceSender.Expression_True(1454, 29012, 29107) && psRPVersion >= RemotingConstants.ProtocolVersionWin8RTM))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 29008, 31878);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 29184, 29312);

                        f_1454_29184_29311(f_1454_29184_29212(commandAsPSObject), f_1454_29217_29310(RemoteDataNameStrings.MergeError, f_1454_29270_29287()[(int)MergeType.Error]));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 29330, 29462);

                        f_1454_29330_29461(f_1454_29330_29358(commandAsPSObject), f_1454_29363_29460(RemoteDataNameStrings.MergeWarning, f_1454_29418_29435()[(int)MergeType.Warning]));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 29480, 29612);

                        f_1454_29480_29611(f_1454_29480_29508(commandAsPSObject), f_1454_29513_29610(RemoteDataNameStrings.MergeVerbose, f_1454_29568_29585()[(int)MergeType.Verbose]));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 29630, 29758);

                        f_1454_29630_29757(f_1454_29630_29658(commandAsPSObject), f_1454_29663_29756(RemoteDataNameStrings.MergeDebug, f_1454_29716_29733()[(int)MergeType.Debug]));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 29987, 30320) || true) && ((f_1454_29992_30009()[(int)MergeType.Information] == PipelineResultTypes.Output) && (DynAbs.Tracing.TraceSender.Expression_True(1454, 29991, 30135) && (f_1454_30094_30118(f_1454_30094_30111()) != MaxMergeType)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 29987, 30320);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 30177, 30301);

                            throw f_1454_30183_30300(f_1454_30230_30299(f_1454_30248_30298()));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 29987, 30320);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 29008, 31878);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 29008, 31878);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 30594, 31863) || true) && (f_1454_30598_30622(f_1454_30598_30615()) != MaxMergeType)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 30594, 31863);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 30680, 30952) || true) && (f_1454_30684_30701()[(int)MergeType.Warning] == PipelineResultTypes.Output)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 30680, 30952);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 30805, 30929);

                                throw f_1454_30811_30928(f_1454_30862_30927(f_1454_30880_30926()));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 30680, 30952);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 30976, 31248) || true) && (f_1454_30980_30997()[(int)MergeType.Verbose] == PipelineResultTypes.Output)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 30976, 31248);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 31101, 31225);

                                throw f_1454_31107_31224(f_1454_31158_31223(f_1454_31176_31222()));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 30976, 31248);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 31272, 31540) || true) && (f_1454_31276_31293()[(int)MergeType.Debug] == PipelineResultTypes.Output)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 31272, 31540);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 31395, 31517);

                                throw f_1454_31401_31516(f_1454_31452_31515(f_1454_31470_31514()));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 31272, 31540);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 31564, 31844) || true) && (f_1454_31568_31585()[(int)MergeType.Information] == PipelineResultTypes.Output)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 31564, 31844);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 31693, 31821);

                                throw f_1454_31699_31820(f_1454_31750_31819(f_1454_31768_31818()));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 31564, 31844);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 30594, 31863);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 29008, 31878);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 28066, 31878);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 31894, 31981);

                List<PSObject>
                parametersAsListOfPSObjects = f_1454_31939_31980(f_1454_31958_31979(f_1454_31958_31973(this)))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 31995, 32165);
                    foreach (CommandParameter parameter in f_1454_32034_32049_I(f_1454_32034_32049(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 31995, 32165);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 32083, 32150);

                        f_1454_32083_32149(parametersAsListOfPSObjects, f_1454_32115_32148(parameter));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 31995, 32165);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1454, 1, 171);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1454, 1, 171);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 32181, 32297);

                f_1454_32181_32296(f_1454_32181_32209(commandAsPSObject), f_1454_32214_32295(RemoteDataNameStrings.Parameters, parametersAsListOfPSObjects));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 32313, 32338);

                return commandAsPSObject;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1454, 27052, 32349);

                System.Management.Automation.PSObject
                f_1454_27166_27203()
                {
                    var return_v = RemotingEncoder.CreateEmptyPSObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 27166, 27203);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1454_27220_27248(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 27220, 27248);
                    return return_v;
                }


                string
                f_1454_27307_27323(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.CommandText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 27307, 27323);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1454_27253_27324(string
                name, string
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 27253, 27324);
                    return return_v;
                }


                int
                f_1454_27220_27325(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 27220, 27325);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1454_27340_27368(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 27340, 27368);
                    return return_v;
                }


                bool
                f_1454_27424_27437(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.IsScript;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 27424, 27437);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1454_27373_27438(string
                name, bool
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 27373, 27438);
                    return return_v;
                }


                int
                f_1454_27340_27439(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 27340, 27439);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1454_27454_27482(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 27454, 27482);
                    return return_v;
                }


                bool?
                f_1454_27551_27577(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.UseLocalScopeNullable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 27551, 27577);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1454_27487_27578(string
                name, bool?
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 27487, 27578);
                    return return_v;
                }


                int
                f_1454_27454_27579(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 27454, 27579);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1454_27644_27672(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 27644, 27672);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineResultTypes
                f_1454_27733_27751(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.MergeMyResult;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 27733, 27751);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1454_27677_27752(string
                name, System.Management.Automation.Runspaces.PipelineResultTypes
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 27677, 27752);
                    return return_v;
                }


                int
                f_1454_27644_27753(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 27644, 27753);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1454_27768_27796(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 27768, 27796);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineResultTypes
                f_1454_27857_27875(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.MergeToResult;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 27857, 27875);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1454_27801_27876(string
                name, System.Management.Automation.Runspaces.PipelineResultTypes
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 27801, 27876);
                    return return_v;
                }


                int
                f_1454_27768_27877(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 27768, 27877);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1454_27894_27922(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 27894, 27922);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineResultTypes
                f_1454_28006_28047(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.MergeUnclaimedPreviousCommandResults;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 28006, 28047);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1454_27927_28048(string
                name, System.Management.Automation.Runspaces.PipelineResultTypes
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 27927, 28048);
                    return return_v;
                }


                int
                f_1454_27894_28049(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 27894, 28049);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1454_28242_28270(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 28242, 28270);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineResultTypes[]
                f_1454_28328_28345()
                {
                    var return_v = MergeInstructions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 28328, 28345);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1454_28275_28368(string
                name, System.Management.Automation.Runspaces.PipelineResultTypes
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 28275, 28368);
                    return return_v;
                }


                int
                f_1454_28242_28369(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 28242, 28369);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1454_28388_28416(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 28388, 28416);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineResultTypes[]
                f_1454_28476_28493()
                {
                    var return_v = MergeInstructions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 28476, 28493);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1454_28421_28518(string
                name, System.Management.Automation.Runspaces.PipelineResultTypes
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 28421, 28518);
                    return return_v;
                }


                int
                f_1454_28388_28519(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 28388, 28519);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1454_28538_28566(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 28538, 28566);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineResultTypes[]
                f_1454_28626_28643()
                {
                    var return_v = MergeInstructions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 28626, 28643);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1454_28571_28668(string
                name, System.Management.Automation.Runspaces.PipelineResultTypes
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 28571, 28668);
                    return return_v;
                }


                int
                f_1454_28538_28669(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 28538, 28669);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1454_28688_28716(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 28688, 28716);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineResultTypes[]
                f_1454_28774_28791()
                {
                    var return_v = MergeInstructions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 28774, 28791);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1454_28721_28814(string
                name, System.Management.Automation.Runspaces.PipelineResultTypes
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 28721, 28814);
                    return return_v;
                }


                int
                f_1454_28688_28815(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 28688, 28815);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1454_28834_28862(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 28834, 28862);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineResultTypes[]
                f_1454_28926_28943()
                {
                    var return_v = MergeInstructions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 28926, 28943);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1454_28867_28972(string
                name, System.Management.Automation.Runspaces.PipelineResultTypes
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 28867, 28972);
                    return return_v;
                }


                int
                f_1454_28834_28973(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 28834, 28973);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1454_29184_29212(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 29184, 29212);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineResultTypes[]
                f_1454_29270_29287()
                {
                    var return_v = MergeInstructions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 29270, 29287);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1454_29217_29310(string
                name, System.Management.Automation.Runspaces.PipelineResultTypes
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 29217, 29310);
                    return return_v;
                }


                int
                f_1454_29184_29311(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 29184, 29311);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1454_29330_29358(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 29330, 29358);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineResultTypes[]
                f_1454_29418_29435()
                {
                    var return_v = MergeInstructions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 29418, 29435);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1454_29363_29460(string
                name, System.Management.Automation.Runspaces.PipelineResultTypes
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 29363, 29460);
                    return return_v;
                }


                int
                f_1454_29330_29461(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 29330, 29461);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1454_29480_29508(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 29480, 29508);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineResultTypes[]
                f_1454_29568_29585()
                {
                    var return_v = MergeInstructions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 29568, 29585);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1454_29513_29610(string
                name, System.Management.Automation.Runspaces.PipelineResultTypes
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 29513, 29610);
                    return return_v;
                }


                int
                f_1454_29480_29611(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 29480, 29611);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1454_29630_29658(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 29630, 29658);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineResultTypes[]
                f_1454_29716_29733()
                {
                    var return_v = MergeInstructions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 29716, 29733);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1454_29663_29756(string
                name, System.Management.Automation.Runspaces.PipelineResultTypes
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 29663, 29756);
                    return return_v;
                }


                int
                f_1454_29630_29757(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 29630, 29757);
                    return 0;
                }


                System.Management.Automation.Runspaces.PipelineResultTypes[]
                f_1454_29992_30009()
                {
                    var return_v = MergeInstructions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 29992, 30009);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineResultTypes[]
                f_1454_30094_30111()
                {
                    var return_v = MergeInstructions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 30094, 30111);
                    return return_v;
                }


                int
                f_1454_30094_30118(System.Management.Automation.Runspaces.PipelineResultTypes[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 30094, 30118);
                    return return_v;
                }


                string
                f_1454_30248_30298()
                {
                    var return_v = RunspaceStrings.InformationRedirectionNotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 30248, 30298);
                    return return_v;
                }


                string
                f_1454_30230_30299(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 30230, 30299);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1454_30183_30300(string
                message)
                {
                    var return_v = new System.Management.Automation.RuntimeException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 30183, 30300);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineResultTypes[]
                f_1454_30598_30615()
                {
                    var return_v = MergeInstructions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 30598, 30615);
                    return return_v;
                }


                int
                f_1454_30598_30622(System.Management.Automation.Runspaces.PipelineResultTypes[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 30598, 30622);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineResultTypes[]
                f_1454_30684_30701()
                {
                    var return_v = MergeInstructions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 30684, 30701);
                    return return_v;
                }


                string
                f_1454_30880_30926()
                {
                    var return_v = RunspaceStrings.WarningRedirectionNotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 30880, 30926);
                    return return_v;
                }


                string
                f_1454_30862_30927(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 30862, 30927);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1454_30811_30928(string
                message)
                {
                    var return_v = new System.Management.Automation.RuntimeException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 30811, 30928);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineResultTypes[]
                f_1454_30980_30997()
                {
                    var return_v = MergeInstructions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 30980, 30997);
                    return return_v;
                }


                string
                f_1454_31176_31222()
                {
                    var return_v = RunspaceStrings.VerboseRedirectionNotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 31176, 31222);
                    return return_v;
                }


                string
                f_1454_31158_31223(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 31158, 31223);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1454_31107_31224(string
                message)
                {
                    var return_v = new System.Management.Automation.RuntimeException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 31107, 31224);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineResultTypes[]
                f_1454_31276_31293()
                {
                    var return_v = MergeInstructions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 31276, 31293);
                    return return_v;
                }


                string
                f_1454_31470_31514()
                {
                    var return_v = RunspaceStrings.DebugRedirectionNotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 31470, 31514);
                    return return_v;
                }


                string
                f_1454_31452_31515(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 31452, 31515);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1454_31401_31516(string
                message)
                {
                    var return_v = new System.Management.Automation.RuntimeException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 31401, 31516);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineResultTypes[]
                f_1454_31568_31585()
                {
                    var return_v = MergeInstructions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 31568, 31585);
                    return return_v;
                }


                string
                f_1454_31768_31818()
                {
                    var return_v = RunspaceStrings.InformationRedirectionNotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 31768, 31818);
                    return return_v;
                }


                string
                f_1454_31750_31819(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 31750, 31819);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1454_31699_31820(string
                message)
                {
                    var return_v = new System.Management.Automation.RuntimeException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 31699, 31820);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandParameterCollection
                f_1454_31958_31973(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 31958, 31973);
                    return return_v;
                }


                int
                f_1454_31958_31979(System.Management.Automation.Runspaces.CommandParameterCollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 31958, 31979);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSObject>
                f_1454_31939_31980(int
                capacity)
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.PSObject>(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 31939, 31980);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandParameterCollection
                f_1454_32034_32049(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 32034, 32049);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1454_32115_32148(System.Management.Automation.Runspaces.CommandParameter
                this_param)
                {
                    var return_v = this_param.ToPSObjectForRemoting();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 32115, 32148);
                    return return_v;
                }


                int
                f_1454_32083_32149(System.Collections.Generic.List<System.Management.Automation.PSObject>
                this_param, System.Management.Automation.PSObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 32083, 32149);
                    return 0;
                }


                System.Management.Automation.Runspaces.CommandParameterCollection
                f_1454_32034_32049_I(System.Management.Automation.Runspaces.CommandParameterCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 32034, 32049);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1454_32181_32209(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 32181, 32209);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1454_32214_32295(string
                name, System.Collections.Generic.List<System.Management.Automation.PSObject>
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 32214, 32295);
                    return return_v;
                }


                int
                f_1454_32181_32296(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 32181, 32296);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1454, 27052, 32349);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1454, 27052, 32349);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static Command()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1454, 532, 34368);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 10044, 10091);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1454, 532, 34368);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1454, 532, 34368);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1454, 532, 34368);

        static string
        f_1454_963_970_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1454, 912, 1006);
            return return_v;
        }


        static string
        f_1454_1489_1496_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1454, 1423, 1535);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1454_2178_2227(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 2178, 2227);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1454_2574_2623(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 2574, 2623);
            return return_v;
        }


        static string
        f_1454_2909_2916_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1454, 2779, 3160);
            return return_v;
        }


        static System.Management.Automation.CommandInfo
        f_1454_3234_3245_C(System.Management.Automation.CommandInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1454, 3172, 3275);
            return return_v;
        }


        System.Management.Automation.CommandInfo
        f_1454_3461_3472()
        {
            var return_v = CommandInfo;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 3461, 3472);
            return return_v;
        }


        string
        f_1454_3461_3477(System.Management.Automation.CommandInfo
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 3461, 3477);
            return return_v;
        }


        bool
        f_1454_3789_3805(System.Management.Automation.Runspaces.Command
        this_param)
        {
            var return_v = this_param.IsScript;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 3789, 3805);
            return return_v;
        }


        string
        f_1454_3888_3907(System.Management.Automation.Runspaces.Command
        this_param)
        {
            var return_v = this_param.CommandText;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 3888, 3907);
            return return_v;
        }


        System.Management.Automation.Runspaces.PipelineResultTypes[]
        f_1454_3942_3967(System.Management.Automation.Runspaces.Command
        this_param)
        {
            var return_v = this_param.MergeInstructions;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 3942, 3967);
            return return_v;
        }


        System.Management.Automation.Runspaces.PipelineResultTypes
        f_1454_3998_4019(System.Management.Automation.Runspaces.Command
        this_param)
        {
            var return_v = this_param.MergeMyResult;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 3998, 4019);
            return return_v;
        }


        System.Management.Automation.Runspaces.PipelineResultTypes
        f_1454_4050_4071(System.Management.Automation.Runspaces.Command
        this_param)
        {
            var return_v = this_param.MergeToResult;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 4050, 4071);
            return return_v;
        }


        bool
        f_1454_4205_4229(System.Management.Automation.Runspaces.Command
        this_param)
        {
            var return_v = this_param.IsEndOfStatement;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 4205, 4229);
            return return_v;
        }


        System.Management.Automation.Runspaces.CommandParameterCollection
        f_1454_4281_4299(System.Management.Automation.Runspaces.Command
        this_param)
        {
            var return_v = this_param.Parameters;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 4281, 4299);
            return return_v;
        }


        System.Management.Automation.Runspaces.CommandParameterCollection
        f_1454_4333_4343()
        {
            var return_v = Parameters;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 4333, 4343);
            return return_v;
        }


        string
        f_1454_4369_4379(System.Management.Automation.Runspaces.CommandParameter
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 4369, 4379);
            return return_v;
        }


        object
        f_1454_4381_4392(System.Management.Automation.Runspaces.CommandParameter
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 4381, 4392);
            return return_v;
        }


        System.Management.Automation.Runspaces.CommandParameter
        f_1454_4348_4393(string
        name, object
        value)
        {
            var return_v = new System.Management.Automation.Runspaces.CommandParameter(name, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 4348, 4393);
            return return_v;
        }


        int
        f_1454_4333_4394(System.Management.Automation.Runspaces.CommandParameterCollection
        this_param, System.Management.Automation.Runspaces.CommandParameter
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 4333, 4394);
            return 0;
        }


        System.Management.Automation.Runspaces.CommandParameterCollection
        f_1454_4281_4299_I(System.Management.Automation.Runspaces.CommandParameterCollection
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 4281, 4299);
            return return_v;
        }


        System.Management.Automation.Runspaces.CommandParameterCollection
        f_1454_4795_4827()
        {
            var return_v = new System.Management.Automation.Runspaces.CommandParameterCollection();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 4795, 4827);
            return return_v;
        }


        System.Management.Automation.PSObject
        f_1454_6988_7008()
        {
            var return_v = AutomationNull.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 6988, 7008);
            return return_v;
        }

    }

    /// <summary>
    /// Enum defining the types of streams coming out of a pipeline.
    /// </summary>
    [Flags]
    public enum PipelineResultTypes
    {
        /// <summary>
        /// Default streaming behavior.
        /// </summary>
        None,

        /// <summary>
        /// Success output.
        /// </summary>
        Output,

        /// <summary>
        /// Error output.
        /// </summary>
        Error,

        /// <summary>
        /// Warning information stream.
        /// </summary>
        Warning,

        /// <summary>
        /// Verbose information stream.
        /// </summary>
        Verbose,

        /// <summary>
        /// Debug information stream.
        /// </summary>
        Debug,

        /// <summary>
        /// Information information stream.
        /// </summary>
        Information,

        /// <summary>
        /// All streams.
        /// </summary>
        All,

        /// <summary>
        /// Redirect to nothing.
        /// </summary>
        Null
    }
    public sealed class CommandCollection : Collection<Command>
    {
        internal CommandCollection()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1454, 35811, 35861);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1454, 35811, 35861);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1454, 35811, 35861);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1454, 35811, 35861);
            }
        }

        public void Add(string command)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1454, 36087, 36401);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 36143, 36390) || true) && (f_1454_36147_36220(command, "out-default", StringComparison.OrdinalIgnoreCase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 36143, 36390);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 36254, 36278);

                    f_1454_36254_36277(this, command, true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 36143, 36390);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1454, 36143, 36390);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 36344, 36375);

                    f_1454_36344_36374(this, f_1454_36353_36373(command));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1454, 36143, 36390);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1454, 36087, 36401);

                bool
                f_1454_36147_36220(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 36147, 36220);
                    return return_v;
                }


                int
                f_1454_36254_36277(System.Management.Automation.Runspaces.CommandCollection
                this_param, string
                command, bool
                mergeUnclaimedPreviousCommandError)
                {
                    this_param.Add(command, mergeUnclaimedPreviousCommandError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 36254, 36277);
                    return 0;
                }


                System.Management.Automation.Runspaces.Command
                f_1454_36353_36373(string
                command)
                {
                    var return_v = new System.Management.Automation.Runspaces.Command(command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 36353, 36373);
                    return return_v;
                }


                int
                f_1454_36344_36374(System.Management.Automation.Runspaces.CommandCollection
                this_param, System.Management.Automation.Runspaces.Command
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 36344, 36374);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1454, 36087, 36401);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1454, 36087, 36401);
            }
        }

        internal void Add(string command, bool mergeUnclaimedPreviousCommandError)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1454, 36413, 36604);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 36512, 36593);

                f_1454_36512_36592(this, f_1454_36521_36591(command, false, false, mergeUnclaimedPreviousCommandError));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1454, 36413, 36604);

                System.Management.Automation.Runspaces.Command
                f_1454_36521_36591(string
                command, bool
                isScript, bool
                useLocalScope, bool
                mergeUnclaimedPreviousErrorResults)
                {
                    var return_v = new System.Management.Automation.Runspaces.Command(command, isScript, (bool?)useLocalScope, mergeUnclaimedPreviousErrorResults);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 36521, 36591);
                    return return_v;
                }


                int
                f_1454_36512_36592(System.Management.Automation.Runspaces.CommandCollection
                this_param, System.Management.Automation.Runspaces.Command
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 36512, 36592);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1454, 36413, 36604);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1454, 36413, 36604);
            }
        }

        public void AddScript(string scriptContents)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1454, 36894, 37018);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 36963, 37007);

                f_1454_36963_37006(this, f_1454_36972_37005(scriptContents, true));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1454, 36894, 37018);

                System.Management.Automation.Runspaces.Command
                f_1454_36972_37005(string
                command, bool
                isScript)
                {
                    var return_v = new System.Management.Automation.Runspaces.Command(command, isScript);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 36972, 37005);
                    return return_v;
                }


                int
                f_1454_36963_37006(System.Management.Automation.Runspaces.CommandCollection
                this_param, System.Management.Automation.Runspaces.Command
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 36963, 37006);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1454, 36894, 37018);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1454, 36894, 37018);
            }
        }

        public void AddScript(string scriptContents, bool useLocalScope)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1454, 37428, 37587);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 37517, 37576);

                f_1454_37517_37575(this, f_1454_37526_37574(scriptContents, true, useLocalScope));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1454, 37428, 37587);

                System.Management.Automation.Runspaces.Command
                f_1454_37526_37574(string
                command, bool
                isScript, bool
                useLocalScope)
                {
                    var return_v = new System.Management.Automation.Runspaces.Command(command, isScript, useLocalScope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 37526, 37574);
                    return return_v;
                }


                int
                f_1454_37517_37575(System.Management.Automation.Runspaces.CommandCollection
                this_param, System.Management.Automation.Runspaces.Command
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 37517, 37575);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1454, 37428, 37587);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1454, 37428, 37587);
            }
        }

        internal string GetCommandStringForHistory()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1454, 37835, 38113);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 37904, 38011);

                f_1454_37904_38010(f_1454_37923_37933(this) != 0, "this is called when there is at least one element in the collection");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 38025, 38056);

                Command
                firstCommand = f_1454_38048_38055(this, 0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1454, 38070, 38102);

                return f_1454_38077_38101(firstCommand);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1454, 37835, 38113);

                int
                f_1454_37923_37933(System.Management.Automation.Runspaces.CommandCollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 37923, 37933);
                    return return_v;
                }


                int
                f_1454_37904_38010(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1454, 37904, 38010);
                    return 0;
                }


                System.Management.Automation.Runspaces.Command
                f_1454_38048_38055(System.Management.Automation.Runspaces.CommandCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 38048, 38055);
                    return return_v;
                }


                string
                f_1454_38077_38101(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.CommandText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1454, 38077, 38101);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1454, 37835, 38113);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1454, 37835, 38113);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CommandCollection()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1454, 35636, 38120);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1454, 35636, 38120);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1454, 35636, 38120);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1454, 35636, 38120);
    }
}

