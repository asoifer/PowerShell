// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace System.Management.Automation.Runspaces
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Threading;
    using Dbg = System.Management.Automation.Diagnostics;
    using System.Management.Automation.Internal;
    internal abstract class PipelineBase : Pipeline
    {
        protected PipelineBase(Runspace runspace, string command, bool addToHistory, bool isNested)
        : base(f_1476_1436_1444_C(runspace))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1476, 1324, 1714);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 6197, 6206);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 6732, 6741);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 7099, 7142);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 7180, 7248);
                this._pipelineStateInfo = f_1476_7201_7248(PipelineState.NotStarted);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 9270, 9314);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 15678, 15729);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 21683, 21709);
                this._performNestedCheck = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 22692, 22751);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 30042, 30101);
                this._executionEventQueue = f_1476_30065_30101();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 35372, 35441);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 35733, 35781);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 35818, 35830);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 37393, 37455);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 37712, 37759);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 38041, 38081);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 38339, 38382);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 39866, 39925);
                this.SyncRoot = f_1476_39912_39924();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 40113, 40122);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 1470, 1524);

                f_1476_1470_1523(this, runspace, command, addToHistory, isNested);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 1575, 1608);

                InputStream = f_1476_1589_1607();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 1622, 1656);

                OutputStream = f_1476_1637_1655();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 1670, 1703);

                ErrorStream = f_1476_1684_1702();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1476, 1324, 1714);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1476, 1324, 1714);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1476, 1324, 1714);
            }
        }

        protected PipelineBase(Runspace runspace,
                    CommandCollection command,
                    bool addToHistory,
                    bool isNested,
                    ObjectStreamBase inputStream,
                    ObjectStreamBase outputStream,
                    ObjectStreamBase errorStream,
                    PSInformationalBuffers infoBuffers)
        : base(f_1476_3484_3492_C(runspace), command)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1476, 3143, 4762);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 6197, 6206);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 6732, 6741);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 7099, 7142);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 7180, 7248);
                this._pipelineStateInfo = f_1476_7201_7248(PipelineState.NotStarted);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 9270, 9314);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 15678, 15729);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 21683, 21709);
                this._performNestedCheck = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 22692, 22751);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 30042, 30101);
                this._executionEventQueue = f_1476_30065_30101();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 35372, 35441);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 35733, 35781);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 35818, 35830);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 37393, 37455);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 37712, 37759);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 38041, 38081);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 38339, 38382);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 39866, 39925);
                this.SyncRoot = f_1476_39912_39924();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 40113, 40122);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 3527, 3607);

                f_1476_3527_3606(inputStream != null, "Caller Should validate inputstream parameter");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 3621, 3703);

                f_1476_3621_3702(outputStream != null, "Caller Should validate outputStream parameter");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 3717, 3797);

                f_1476_3717_3796(errorStream != null, "Caller Should validate errorStream parameter");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 3811, 3900);

                f_1476_3811_3899(infoBuffers != null, "Caller Should validate informationalBuffers parameter");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 3914, 3968);

                f_1476_3914_3967(command != null, "Command cannot be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 4219, 4263);

                f_1476_4219_4262(this, runspace, null, false, isNested);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 4277, 4543) || true) && (true == addToHistory)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1476, 4277, 4543);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 4386, 4440);

                    string
                    cmdText = f_1476_4403_4439(command)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 4458, 4482);

                    HistoryString = cmdText;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 4500, 4528);

                    AddToHistory = addToHistory;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1476, 4277, 4543);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 4594, 4620);

                InputStream = inputStream;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 4634, 4662);

                OutputStream = outputStream;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 4676, 4702);

                ErrorStream = errorStream;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 4716, 4751);

                InformationalBuffers = infoBuffers;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1476, 3143, 4762);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1476, 3143, 4762);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1476, 3143, 4762);
            }
        }

        protected PipelineBase(PipelineBase pipeline)
        : this(f_1476_5325_5342_C(f_1476_5325_5342(pipeline)), null, false, f_1476_5357_5374(pipeline))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1476, 5259, 6103);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 5470, 5596) || true) && (pipeline == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1476, 5470, 5596);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 5524, 5581);

                    throw f_1476_5530_5580("pipeline");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1476, 5470, 5596);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 5612, 5742) || true) && (pipeline._disposed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1476, 5612, 5742);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 5668, 5727);

                    throw f_1476_5674_5726("pipeline");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1476, 5612, 5742);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 5758, 5795);

                AddToHistory = f_1476_5773_5794(pipeline);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 5809, 5848);

                HistoryString = f_1476_5825_5847(pipeline);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 5862, 6092);
                    foreach (Command command in f_1476_5890_5907_I(f_1476_5890_5907(pipeline)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1476, 5862, 6092);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 5941, 5973);

                        Command
                        clone = f_1476_5957_5972(command)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 6057, 6077);

                        f_1476_6057_6076(f_1476_6057_6065(), clone);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1476, 5862, 6092);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1476, 1, 231);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1476, 1, 231);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1476, 5259, 6103);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1476, 5259, 6103);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1476, 5259, 6103);
            }
        }

        private Runspace _runspace;

        public override Runspace Runspace
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1476, 6386, 6454);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 6422, 6439);

                    return _runspace;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1476, 6386, 6454);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1476, 6328, 6465);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1476, 6328, 6465);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Runspace GetRunspace()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1476, 6623, 6707);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 6679, 6696);

                return _runspace;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1476, 6623, 6707);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1476, 6623, 6707);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1476, 6623, 6707);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool _isNested;

        public override bool IsNested
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1476, 6893, 6961);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 6929, 6946);

                    return _isNested;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1476, 6893, 6961);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1476, 6839, 6972);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1476, 6839, 6972);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsPulsePipeline { get; set; }

        private PipelineStateInfo _pipelineStateInfo;

        public override PipelineStateInfo PipelineStateInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1476, 7564, 7786);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 7606, 7614);
                    lock (f_1476_7606_7614())
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 7718, 7752);

                        return f_1476_7725_7751(_pipelineStateInfo);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1476, 7564, 7786);

                    object
                    f_1476_7606_7614()
                    {
                        var return_v = SyncRoot;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 7606, 7614);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.PipelineStateInfo
                    f_1476_7725_7751(System.Management.Automation.Runspaces.PipelineStateInfo
                    this_param)
                    {
                        var return_v = this_param.Clone();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 7725, 7751);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1476, 7488, 7797);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1476, 7488, 7797);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override PipelineWriter Input
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1476, 8052, 8135);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 8088, 8120);

                    return f_1476_8095_8119(f_1476_8095_8106());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1476, 8052, 8135);

                    System.Management.Automation.Internal.ObjectStreamBase
                    f_1476_8095_8106()
                    {
                        var return_v = InputStream;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 8095, 8106);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.PipelineWriter
                    f_1476_8095_8119(System.Management.Automation.Internal.ObjectStreamBase
                    this_param)
                    {
                        var return_v = this_param.ObjectWriter;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 8095, 8119);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1476, 7991, 8146);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1476, 7991, 8146);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override PipelineReader<PSObject> Output
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1476, 8334, 8420);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 8370, 8405);

                    return f_1476_8377_8404(f_1476_8377_8389());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1476, 8334, 8420);

                    System.Management.Automation.Internal.ObjectStreamBase
                    f_1476_8377_8389()
                    {
                        var return_v = OutputStream;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 8377, 8389);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.PipelineReader<System.Management.Automation.PSObject>
                    f_1476_8377_8404(System.Management.Automation.Internal.ObjectStreamBase
                    this_param)
                    {
                        var return_v = this_param.PSObjectReader;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 8377, 8404);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1476, 8262, 8431);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1476, 8262, 8431);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override PipelineReader<object> Error
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1476, 8863, 8947);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 8899, 8932);

                    return f_1476_8906_8931(_errorStream);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1476, 8863, 8947);

                    System.Management.Automation.Runspaces.PipelineReader<object>
                    f_1476_8906_8931(System.Management.Automation.Internal.ObjectStreamBase
                    this_param)
                    {
                        var return_v = this_param.ObjectReader;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 8906, 8931);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1476, 8794, 8958);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1476, 8794, 8958);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsChild { get; set; }

        public override void Stop()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1476, 9490, 9568);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 9542, 9557);

                f_1476_9542_9556(this, true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1476, 9490, 9568);

                int
                f_1476_9542_9556(System.Management.Automation.Runspaces.PipelineBase
                this_param, bool
                syncCall)
                {
                    this_param.CoreStop(syncCall);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 9542, 9556);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1476, 9490, 9568);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1476, 9490, 9568);
            }
        }

        public override void StopAsync()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1476, 9688, 9772);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 9745, 9761);

                f_1476_9745_9760(this, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1476, 9688, 9772);

                int
                f_1476_9745_9760(System.Management.Automation.Runspaces.PipelineBase
                this_param, bool
                syncCall)
                {
                    this_param.CoreStop(syncCall);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 9745, 9760);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1476, 9688, 9772);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1476, 9688, 9772);
            }
        }

        private void CoreStop(bool syncCall)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1476, 9990, 12465);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 10106, 10135);

                bool
                alreadyStopping = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 10155, 10163);
                lock (f_1476_10155_10163())
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 10197, 11166);

                    switch (f_1476_10205_10218())
                    {

                        case PipelineState.NotStarted:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1476, 10197, 11166);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 10316, 10357);

                            f_1476_10316_10356(this, PipelineState.Stopping);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 10383, 10423);

                            f_1476_10383_10422(this, PipelineState.Stopped);
                            DynAbs.Tracing.TraceSender.TraceBreak(1476, 10449, 10455);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1476, 10197, 11166);

                        case PipelineState.Stopped:
                        case PipelineState.Completed:
                        case PipelineState.Failed:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1476, 10197, 11166);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 10753, 10760);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1476, 10197, 11166);

                        case PipelineState.Stopping:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1476, 10197, 11166);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 10942, 10965);

                            alreadyStopping = true;
                            DynAbs.Tracing.TraceSender.TraceBreak(1476, 10991, 10997);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1476, 10197, 11166);

                        case PipelineState.Running:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1476, 10197, 11166);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 11074, 11115);

                            f_1476_11074_11114(this, PipelineState.Stopping);
                            DynAbs.Tracing.TraceSender.TraceBreak(1476, 11141, 11147);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1476, 10197, 11166);
                    }
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 11388, 11588) || true) && (alreadyStopping)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1476, 11388, 11588);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 11441, 11546) || true) && (syncCall)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1476, 11441, 11546);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 11495, 11527);

                        f_1476_11495_11526(f_1476_11495_11516());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1476, 11441, 11546);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 11566, 11573);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1476, 11388, 11588);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 11653, 11680);

                f_1476_11653_11679(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 11931, 11939);

                // A pipeline can be stoped before it is started. See NotStarted
                // case in above switch statement. This is done to allow stoping a pipeline
                // in another thread before it has been started.
                lock (f_1476_11931_11939())
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 11973, 12345) || true) && (f_1476_11977_11990() == PipelineState.Stopped)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1476, 11973, 12345);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 12319, 12326);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1476, 11973, 12345);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 12430, 12454);

                f_1476_12430_12453(this, syncCall);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1476, 9990, 12465);

                object
                f_1476_10155_10163()
                {
                    var return_v = SyncRoot;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 10155, 10163);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineState
                f_1476_10205_10218()
                {
                    var return_v = PipelineState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 10205, 10218);
                    return return_v;
                }


                int
                f_1476_10316_10356(System.Management.Automation.Runspaces.PipelineBase
                this_param, System.Management.Automation.Runspaces.PipelineState
                state)
                {
                    this_param.SetPipelineState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 10316, 10356);
                    return 0;
                }


                int
                f_1476_10383_10422(System.Management.Automation.Runspaces.PipelineBase
                this_param, System.Management.Automation.Runspaces.PipelineState
                state)
                {
                    this_param.SetPipelineState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 10383, 10422);
                    return 0;
                }


                int
                f_1476_11074_11114(System.Management.Automation.Runspaces.PipelineBase
                this_param, System.Management.Automation.Runspaces.PipelineState
                state)
                {
                    this_param.SetPipelineState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 11074, 11114);
                    return 0;
                }


                System.Threading.ManualResetEvent
                f_1476_11495_11516()
                {
                    var return_v = PipelineFinishedEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 11495, 11516);
                    return return_v;
                }


                bool
                f_1476_11495_11526(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.WaitOne();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 11495, 11526);
                    return return_v;
                }


                int
                f_1476_11653_11679(System.Management.Automation.Runspaces.PipelineBase
                this_param)
                {
                    this_param.RaisePipelineStateEvents();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 11653, 11679);
                    return 0;
                }


                object
                f_1476_11931_11939()
                {
                    var return_v = SyncRoot;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 11931, 11939);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineState
                f_1476_11977_11990()
                {
                    var return_v = PipelineState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 11977, 11990);
                    return return_v;
                }


                int
                f_1476_12430_12453(System.Management.Automation.Runspaces.PipelineBase
                this_param, bool
                syncCall)
                {
                    this_param.ImplementStop(syncCall);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 12430, 12453);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1476, 9990, 12465);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1476, 9990, 12465);
            }
        }

        protected abstract void ImplementStop(bool syncCall);

        public override Collection<PSObject> Invoke(IEnumerable input)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1476, 13499, 15178);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 13656, 13777) || true) && (_disposed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1476, 13656, 13777);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 13703, 13762);

                    throw f_1476_13709_13761("pipeline");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1476, 13656, 13777);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 13793, 13817);

                f_1476_13793_13816(this, input, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 13887, 13919);

                f_1476_13887_13918(f_1476_13887_13908());

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 13935, 14251) || true) && (f_1476_13939_13953())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1476, 13935, 14251);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 14209, 14236);

                    f_1476_14209_14235(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1476, 13935, 14251);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 14267, 14987) || true) && (f_1476_14271_14294(f_1476_14271_14288()) == PipelineState.Stopped)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1476, 14267, 14987);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 14353, 14387);

                    return f_1476_14360_14386();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1476, 14267, 14987);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1476, 14267, 14987);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 14421, 14987) || true) && (f_1476_14425_14448(f_1476_14425_14442()) == PipelineState.Failed && (DynAbs.Tracing.TraceSender.Expression_True(1476, 14425, 14508) && f_1476_14476_14500(f_1476_14476_14493()) != null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1476, 14421, 14987);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 14672, 14921) || true) && (f_1476_14676_14747(f_1476_14676_14732(f_1476_14676_14729(f_1476_14676_14709(f_1476_14676_14689(this))))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1476, 14672, 14921);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 14789, 14902);

                            f_1476_14789_14901(f_1476_14789_14835(f_1476_14789_14832(f_1476_14789_14819(f_1476_14789_14802(this)))), f_1476_14853_14866(this), f_1476_14868_14900(f_1476_14868_14892(f_1476_14868_14885())));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1476, 14672, 14921);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 14941, 14972);

                        throw f_1476_14947_14971(f_1476_14947_14964());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1476, 14421, 14987);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1476, 14267, 14987);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 15121, 15167);

                return f_1476_15128_15166(f_1476_15128_15134(), Int32.MaxValue);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1476, 13499, 15178);

                System.Management.Automation.PSObjectDisposedException
                f_1476_13709_13761(string
                objectName)
                {
                    var return_v = PSTraceSource.NewObjectDisposedException(objectName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 13709, 13761);
                    return return_v;
                }


                int
                f_1476_13793_13816(System.Management.Automation.Runspaces.PipelineBase
                this_param, System.Collections.IEnumerable
                input, bool
                syncCall)
                {
                    this_param.CoreInvoke(input, syncCall);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 13793, 13816);
                    return 0;
                }


                System.Threading.ManualResetEvent
                f_1476_13887_13908()
                {
                    var return_v = PipelineFinishedEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 13887, 13908);
                    return return_v;
                }


                bool
                f_1476_13887_13918(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.WaitOne();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 13887, 13918);
                    return return_v;
                }


                bool
                f_1476_13939_13953()
                {
                    var return_v = SyncInvokeCall;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 13939, 13953);
                    return return_v;
                }


                int
                f_1476_14209_14235(System.Management.Automation.Runspaces.PipelineBase
                this_param)
                {
                    this_param.RaisePipelineStateEvents();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 14209, 14235);
                    return 0;
                }


                System.Management.Automation.Runspaces.PipelineStateInfo
                f_1476_14271_14288()
                {
                    var return_v = PipelineStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 14271, 14288);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineState
                f_1476_14271_14294(System.Management.Automation.Runspaces.PipelineStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 14271, 14294);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1476_14360_14386()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 14360, 14386);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineStateInfo
                f_1476_14425_14442()
                {
                    var return_v = PipelineStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 14425, 14442);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineState
                f_1476_14425_14448(System.Management.Automation.Runspaces.PipelineStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 14425, 14448);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineStateInfo
                f_1476_14476_14493()
                {
                    var return_v = PipelineStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 14476, 14493);
                    return return_v;
                }


                System.Exception
                f_1476_14476_14500(System.Management.Automation.Runspaces.PipelineStateInfo
                this_param)
                {
                    var return_v = this_param.Reason;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 14476, 14500);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1476_14676_14689(System.Management.Automation.Runspaces.PipelineBase
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 14676, 14689);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1476_14676_14709(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.GetExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 14676, 14709);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1476_14676_14729(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineHostInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 14676, 14729);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostUserInterface
                f_1476_14676_14732(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 14676, 14732);
                    return return_v;
                }


                bool
                f_1476_14676_14747(System.Management.Automation.Host.PSHostUserInterface
                this_param)
                {
                    var return_v = this_param.IsTranscribing;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 14676, 14747);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1476_14789_14802(System.Management.Automation.Runspaces.PipelineBase
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 14789, 14802);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1476_14789_14819(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 14789, 14819);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1476_14789_14832(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.InternalHost;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 14789, 14832);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostUserInterface
                f_1476_14789_14835(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 14789, 14835);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1476_14853_14866(System.Management.Automation.Runspaces.PipelineBase
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 14853, 14866);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineStateInfo
                f_1476_14868_14885()
                {
                    var return_v = PipelineStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 14868, 14885);
                    return return_v;
                }


                System.Exception
                f_1476_14868_14892(System.Management.Automation.Runspaces.PipelineStateInfo
                this_param)
                {
                    var return_v = this_param.Reason;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 14868, 14892);
                    return return_v;
                }


                string
                f_1476_14868_14900(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 14868, 14900);
                    return return_v;
                }


                int
                f_1476_14789_14901(System.Management.Automation.Host.PSHostUserInterface
                this_param, System.Management.Automation.Runspaces.Runspace
                sourceRunspace, string
                resultText)
                {
                    this_param.TranscribeResult(sourceRunspace, resultText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 14789, 14901);
                    return 0;
                }


                System.Management.Automation.Runspaces.PipelineStateInfo
                f_1476_14947_14964()
                {
                    var return_v = PipelineStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 14947, 14964);
                    return return_v;
                }


                System.Exception
                f_1476_14947_14971(System.Management.Automation.Runspaces.PipelineStateInfo
                this_param)
                {
                    var return_v = this_param.Reason;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 14947, 14971);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineReader<System.Management.Automation.PSObject>
                f_1476_15128_15134()
                {
                    var return_v = Output;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 15128, 15134);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1476_15128_15166(System.Management.Automation.Runspaces.PipelineReader<System.Management.Automation.PSObject>
                this_param, int
                maxRequested)
                {
                    var return_v = this_param.NonBlockingRead(maxRequested);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 15128, 15166);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1476, 13499, 15178);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1476, 13499, 15178);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void InvokeAsync()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1476, 15417, 15511);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 15476, 15500);

                f_1476_15476_15499(this, null, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1476, 15417, 15511);

                int
                f_1476_15476_15499(System.Management.Automation.Runspaces.PipelineBase
                this_param, System.Collections.IEnumerable
                input, bool
                syncCall)
                {
                    this_param.CoreInvoke(input, syncCall);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 15476, 15499);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1476, 15417, 15511);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1476, 15417, 15511);
            }
        }

        protected bool SyncInvokeCall { get; private set; }

        private void CoreInvoke(IEnumerable input, bool syncCall)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1476, 17187, 21173);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 17275, 17283);
                lock (f_1476_17275_17283())
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 17391, 17524) || true) && (_disposed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1476, 17391, 17524);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 17446, 17505);

                        throw f_1476_17452_17504("pipeline");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1476, 17391, 17524);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 17544, 17764) || true) && (f_1476_17548_17556() == null || (DynAbs.Tracing.TraceSender.Expression_False(1476, 17548, 17587) || f_1476_17568_17582(f_1476_17568_17576()) == 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1476, 17544, 17764);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 17629, 17745);

                        throw f_1476_17635_17744(f_1476_17708_17743());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1476, 17544, 17764);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 17784, 18257) || true) && (f_1476_17788_17801() != PipelineState.NotStarted)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1476, 17784, 18257);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 17871, 18208);

                        InvalidPipelineStateException
                        e =
                        f_1476_17930_18207(f_1476_18020_18081(f_1476_18038_18080()), f_1476_18112_18125(), PipelineState.NotStarted)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 18230, 18238);

                        throw e;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1476, 17784, 18257);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 18277, 19136) || true) && (syncCall && (DynAbs.Tracing.TraceSender.Expression_True(1476, 18281, 18392) && !(f_1476_18295_18306() is PSDataCollectionStream<PSObject> || (DynAbs.Tracing.TraceSender.Expression_False(1476, 18295, 18391) || f_1476_18346_18357() is PSDataCollectionStream<object>))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1476, 18277, 19136);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 18500, 19073) || true) && (input != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1476, 18500, 19073);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 18912, 19050);
                                foreach (object temp in f_1476_18936_18941_I(input))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1476, 18912, 19050);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 18999, 19023);

                                    f_1476_18999_19022(f_1476_18999_19010(), temp);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1476, 18912, 19050);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1476, 1, 139);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1476, 1, 139);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1476, 18500, 19073);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 19097, 19117);

                        f_1476_19097_19116(f_1476_19097_19108());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1476, 18277, 19136);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 19156, 19182);

                    SyncInvokeCall = syncCall;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 19714, 19766);

                    PipelineFinishedEvent = f_1476_19738_19765(false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 20030, 20101);

                    f_1476_20030_20100(f_1476_20030_20042(), this, syncCall);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 20478, 20518);

                    f_1476_20478_20517(this, PipelineState.Running);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 20657, 20682);

                    f_1476_20657_20681(this);
                }
                catch (Exception exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1476, 20711, 21162);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 20859, 20908);

                    f_1476_20859_20907(f_1476_20859_20871(), this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 20926, 20976);

                    f_1476_20926_20975(this, PipelineState.Failed, exception);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 21141, 21147);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1476, 20711, 21162);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1476, 17187, 21173);

                object
                f_1476_17275_17283()
                {
                    var return_v = SyncRoot;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 17275, 17283);
                    return return_v;
                }


                System.Management.Automation.PSObjectDisposedException
                f_1476_17452_17504(string
                objectName)
                {
                    var return_v = PSTraceSource.NewObjectDisposedException(objectName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 17452, 17504);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandCollection
                f_1476_17548_17556()
                {
                    var return_v = Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 17548, 17556);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandCollection
                f_1476_17568_17576()
                {
                    var return_v = Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 17568, 17576);
                    return return_v;
                }


                int
                f_1476_17568_17582(System.Management.Automation.Runspaces.CommandCollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 17568, 17582);
                    return return_v;
                }


                string
                f_1476_17708_17743()
                {
                    var return_v = RunspaceStrings.NoCommandInPipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 17708, 17743);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1476_17635_17744(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 17635, 17744);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineState
                f_1476_17788_17801()
                {
                    var return_v = PipelineState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 17788, 17801);
                    return return_v;
                }


                string
                f_1476_18038_18080()
                {
                    var return_v = RunspaceStrings.PipelineReInvokeNotAllowed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 18038, 18080);
                    return return_v;
                }


                string
                f_1476_18020_18081(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 18020, 18081);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineState
                f_1476_18112_18125()
                {
                    var return_v = PipelineState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 18112, 18125);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InvalidPipelineStateException
                f_1476_17930_18207(string
                message, System.Management.Automation.Runspaces.PipelineState
                currentState, System.Management.Automation.Runspaces.PipelineState
                expectedState)
                {
                    var return_v = new System.Management.Automation.Runspaces.InvalidPipelineStateException(message, currentState, expectedState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 17930, 18207);
                    return return_v;
                }


                System.Management.Automation.Internal.ObjectStreamBase
                f_1476_18295_18306()
                {
                    var return_v = InputStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 18295, 18306);
                    return return_v;
                }


                System.Management.Automation.Internal.ObjectStreamBase
                f_1476_18346_18357()
                {
                    var return_v = InputStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 18346, 18357);
                    return return_v;
                }


                System.Management.Automation.Internal.ObjectStreamBase
                f_1476_18999_19010()
                {
                    var return_v = InputStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 18999, 19010);
                    return return_v;
                }


                int
                f_1476_18999_19022(System.Management.Automation.Internal.ObjectStreamBase
                this_param, object
                value)
                {
                    var return_v = this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 18999, 19022);
                    return return_v;
                }


                System.Collections.IEnumerable
                f_1476_18936_18941_I(System.Collections.IEnumerable
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 18936, 18941);
                    return return_v;
                }


                System.Management.Automation.Internal.ObjectStreamBase
                f_1476_19097_19108()
                {
                    var return_v = InputStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 19097, 19108);
                    return return_v;
                }


                int
                f_1476_19097_19116(System.Management.Automation.Internal.ObjectStreamBase
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 19097, 19116);
                    return 0;
                }


                System.Threading.ManualResetEvent
                f_1476_19738_19765(bool
                initialState)
                {
                    var return_v = new System.Threading.ManualResetEvent(initialState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 19738, 19765);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceBase
                f_1476_20030_20042()
                {
                    var return_v = RunspaceBase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 20030, 20042);
                    return return_v;
                }


                int
                f_1476_20030_20100(System.Management.Automation.Runspaces.RunspaceBase
                this_param, System.Management.Automation.Runspaces.PipelineBase
                pipeline, bool
                syncCall)
                {
                    this_param.DoConcurrentCheckAndAddToRunningPipelines(pipeline, syncCall);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 20030, 20100);
                    return 0;
                }


                int
                f_1476_20478_20517(System.Management.Automation.Runspaces.PipelineBase
                this_param, System.Management.Automation.Runspaces.PipelineState
                state)
                {
                    this_param.SetPipelineState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 20478, 20517);
                    return 0;
                }


                int
                f_1476_20657_20681(System.Management.Automation.Runspaces.PipelineBase
                this_param)
                {
                    this_param.StartPipelineExecution();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 20657, 20681);
                    return 0;
                }


                System.Management.Automation.Runspaces.RunspaceBase
                f_1476_20859_20871()
                {
                    var return_v = RunspaceBase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 20859, 20871);
                    return return_v;
                }


                int
                f_1476_20859_20907(System.Management.Automation.Runspaces.RunspaceBase
                this_param, System.Management.Automation.Runspaces.PipelineBase
                pipeline)
                {
                    this_param.RemoveFromRunningPipelineList(pipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 20859, 20907);
                    return 0;
                }


                int
                f_1476_20926_20975(System.Management.Automation.Runspaces.PipelineBase
                this_param, System.Management.Automation.Runspaces.PipelineState
                state, System.Exception
                reason)
                {
                    this_param.SetPipelineState(state, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 20926, 20975);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1476, 17187, 21173);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1476, 17187, 21173);
            }
        }

        internal override void InvokeAsyncAndDisconnect()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1476, 21343, 21462);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 21417, 21451);

                throw f_1476_21423_21450();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1476, 21343, 21462);

                System.NotSupportedException
                f_1476_21423_21450()
                {
                    var return_v = new System.NotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 21423, 21450);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1476, 21343, 21462);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1476, 21343, 21462);
            }
        }

        protected abstract void StartPipelineExecution();

        private bool _performNestedCheck;

        internal bool PerformNestedCheck
        {
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1476, 22149, 22228);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 22185, 22213);

                    _performNestedCheck = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1476, 22149, 22228);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1476, 22092, 22239);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1476, 22092, 22239);
                }
            }
        }

        internal Thread NestedPipelineExecutionThread { get; set; }

        internal void DoConcurrentCheck(bool syncCall, object syncObject, bool isInLock)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1476, 23751, 27498);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 23856, 23944);

                PipelineBase
                currentPipeline = (PipelineBase)f_1476_23901_23943(f_1476_23901_23913())
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 23960, 27487) || true) && (f_1476_23964_23972() == false)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1476, 23960, 27487);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 24015, 25737) || true) && (currentPipeline == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1476, 24015, 25737);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 24084, 24091);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1476, 24015, 25737);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1476, 24015, 25737);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 24318, 25571) || true) && (currentPipeline == f_1476_24341_24367(f_1476_24341_24353()) || (DynAbs.Tracing.TraceSender.Expression_False(1476, 24322, 24460) || (f_1476_24397_24421(currentPipeline) && (DynAbs.Tracing.TraceSender.Expression_True(1476, 24397, 24459) && f_1476_24425_24451(f_1476_24425_24437()) != null))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1476, 24318, 25571);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 24564, 24849) || true) && (isInLock)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1476, 24564, 24849);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 24797, 24822);

                                f_1476_24797_24821(syncObject);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1476, 24564, 24849);
                            }

                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 24937, 24977);

                                f_1476_24937_24976(f_1476_24937_24949());
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinally(1476, 25030, 25437);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 25094, 25410) || true) && (isInLock)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1476, 25094, 25410);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 25353, 25379);

                                    f_1476_25353_25378(syncObject);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1476, 25094, 25410);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitFinally(1476, 25030, 25437);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 25465, 25515);

                            f_1476_25465_25514(this, syncCall, syncObject, isInLock);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 25541, 25548);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1476, 24318, 25571);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 25595, 25718);

                        throw f_1476_25601_25717(f_1476_25674_25716());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1476, 24015, 25737);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1476, 23960, 27487);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1476, 23960, 27487);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 25803, 27472) || true) && (_performNestedCheck)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1476, 25803, 27472);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 25868, 26088) || true) && (syncCall == false)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1476, 25868, 26088);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 25939, 26065);

                            throw f_1476_25945_26064(f_1476_26022_26063());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1476, 25868, 26088);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 26112, 26938) || true) && (currentPipeline == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1476, 26112, 26938);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 26189, 26756) || true) && (f_1476_26193_26205(this))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1476, 26189, 26756);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 26623, 26644);

                                this.IsChild = false;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 26674, 26692);

                                _isNested = false;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 26722, 26729);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1476, 26189, 26756);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 26784, 26915);

                            throw f_1476_26790_26914(f_1476_26867_26913());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1476, 26112, 26938);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 26962, 27101);

                        f_1476_26962_27100(f_1476_26973_27018(currentPipeline) != null, "Current pipeline should always have NestedPipelineExecutionThread set");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 27123, 27156);

                        Thread
                        th = f_1476_27135_27155()
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 27180, 27453) || true) && (f_1476_27184_27240(f_1476_27184_27229(currentPipeline), th) == false)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1476, 27180, 27453);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 27299, 27430);

                            throw f_1476_27305_27429(f_1476_27382_27428());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1476, 27180, 27453);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1476, 25803, 27472);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1476, 23960, 27487);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1476, 23751, 27498);

                System.Management.Automation.Runspaces.RunspaceBase
                f_1476_23901_23913()
                {
                    var return_v = RunspaceBase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 23901, 23913);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Pipeline
                f_1476_23901_23943(System.Management.Automation.Runspaces.RunspaceBase
                this_param)
                {
                    var return_v = this_param.GetCurrentlyRunningPipeline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 23901, 23943);
                    return return_v;
                }


                bool
                f_1476_23964_23972()
                {
                    var return_v = IsNested;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 23964, 23972);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceBase
                f_1476_24341_24353()
                {
                    var return_v = RunspaceBase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 24341, 24353);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineBase
                f_1476_24341_24367(System.Management.Automation.Runspaces.RunspaceBase
                this_param)
                {
                    var return_v = this_param.PulsePipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 24341, 24367);
                    return return_v;
                }


                bool
                f_1476_24397_24421(System.Management.Automation.Runspaces.PipelineBase
                this_param)
                {
                    var return_v = this_param.IsNested;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 24397, 24421);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceBase
                f_1476_24425_24437()
                {
                    var return_v = RunspaceBase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 24425, 24437);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineBase
                f_1476_24425_24451(System.Management.Automation.Runspaces.RunspaceBase
                this_param)
                {
                    var return_v = this_param.PulsePipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 24425, 24451);
                    return return_v;
                }


                int
                f_1476_24797_24821(object
                obj)
                {
                    Monitor.Exit(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 24797, 24821);
                    return 0;
                }


                System.Management.Automation.Runspaces.RunspaceBase
                f_1476_24937_24949()
                {
                    var return_v = RunspaceBase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 24937, 24949);
                    return return_v;
                }


                bool
                f_1476_24937_24976(System.Management.Automation.Runspaces.RunspaceBase
                this_param)
                {
                    var return_v = this_param.WaitForFinishofPipelines();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 24937, 24976);
                    return return_v;
                }


                int
                f_1476_25353_25378(object
                obj)
                {
                    Monitor.Enter(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 25353, 25378);
                    return 0;
                }


                int
                f_1476_25465_25514(System.Management.Automation.Runspaces.PipelineBase
                this_param, bool
                syncCall, object
                syncObject, bool
                isInLock)
                {
                    this_param.DoConcurrentCheck(syncCall, syncObject, isInLock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 25465, 25514);
                    return 0;
                }


                string
                f_1476_25674_25716()
                {
                    var return_v = RunspaceStrings.ConcurrentInvokeNotAllowed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 25674, 25716);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1476_25601_25717(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 25601, 25717);
                    return return_v;
                }


                string
                f_1476_26022_26063()
                {
                    var return_v = RunspaceStrings.NestedPipelineInvokeAsync;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 26022, 26063);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1476_25945_26064(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 25945, 26064);
                    return return_v;
                }


                bool
                f_1476_26193_26205(System.Management.Automation.Runspaces.PipelineBase
                this_param)
                {
                    var return_v = this_param.IsChild;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 26193, 26205);
                    return return_v;
                }


                string
                f_1476_26867_26913()
                {
                    var return_v = RunspaceStrings.NestedPipelineNoParentPipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 26867, 26913);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1476_26790_26914(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 26790, 26914);
                    return return_v;
                }


                System.Threading.Thread
                f_1476_26973_27018(System.Management.Automation.Runspaces.PipelineBase
                this_param)
                {
                    var return_v = this_param.NestedPipelineExecutionThread;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 26973, 27018);
                    return return_v;
                }


                int
                f_1476_26962_27100(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 26962, 27100);
                    return 0;
                }


                System.Threading.Thread
                f_1476_27135_27155()
                {
                    var return_v = Thread.CurrentThread;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 27135, 27155);
                    return return_v;
                }


                System.Threading.Thread
                f_1476_27184_27229(System.Management.Automation.Runspaces.PipelineBase
                this_param)
                {
                    var return_v = this_param.NestedPipelineExecutionThread;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 27184, 27229);
                    return return_v;
                }


                bool
                f_1476_27184_27240(System.Threading.Thread
                this_param, System.Threading.Thread
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 27184, 27240);
                    return return_v;
                }


                string
                f_1476_27382_27428()
                {
                    var return_v = RunspaceStrings.NestedPipelineNoParentPipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 27382, 27428);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1476_27305_27429(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 27305, 27429);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1476, 23751, 27498);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1476, 23751, 27498);
            }
        }

        public override Collection<PSObject> Connect()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1476, 27870, 28117);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 28024, 28106);

                throw f_1476_28030_28105(f_1476_28069_28104());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1476, 27870, 28117);

                string
                f_1476_28069_28104()
                {
                    var return_v = PipelineStrings.ConnectNotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 28069, 28104);
                    return return_v;
                }


                System.Management.Automation.PSNotSupportedException
                f_1476_28030_28105(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewNotSupportedException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 28030, 28105);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1476, 27870, 28117);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1476, 27870, 28117);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void ConnectAsync()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1476, 28254, 28490);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 28397, 28479);

                throw f_1476_28403_28478(f_1476_28442_28477());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1476, 28254, 28490);

                string
                f_1476_28442_28477()
                {
                    var return_v = PipelineStrings.ConnectNotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 28442, 28477);
                    return return_v;
                }


                System.Management.Automation.PSNotSupportedException
                f_1476_28403_28478(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewNotSupportedException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 28403, 28478);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1476, 28254, 28490);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1476, 28254, 28490);
            }
        }



        /// <summary>
        /// Event raised when Pipeline's state changes.
        /// </summary>
        public override event EventHandler<PipelineStateEventArgs>
StateChanged = null
;

        protected PipelineState PipelineState
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1476, 29035, 29118);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 29071, 29103);

                    return f_1476_29078_29102(_pipelineStateInfo);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1476, 29035, 29118);

                    System.Management.Automation.Runspaces.PipelineState
                    f_1476_29078_29102(System.Management.Automation.Runspaces.PipelineStateInfo
                    this_param)
                    {
                        var return_v = this_param.State;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 29078, 29102);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1476, 28973, 29129);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1476, 28973, 29129);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected bool IsPipelineFinished()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1476, 29303, 29549);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 29363, 29538);

                return (f_1476_29371_29384() == PipelineState.Completed || (DynAbs.Tracing.TraceSender.Expression_False(1476, 29371, 29473) || f_1476_29436_29449() == PipelineState.Failed) || (DynAbs.Tracing.TraceSender.Expression_False(1476, 29371, 29536) || f_1476_29498_29511() == PipelineState.Stopped));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1476, 29303, 29549);

                System.Management.Automation.Runspaces.PipelineState
                f_1476_29371_29384()
                {
                    var return_v = PipelineState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 29371, 29384);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineState
                f_1476_29436_29449()
                {
                    var return_v = PipelineState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 29436, 29449);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineState
                f_1476_29498_29511()
                {
                    var return_v = PipelineState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 29498, 29511);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1476, 29303, 29549);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1476, 29303, 29549);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Queue<ExecutionEventQueueItem> _executionEventQueue;
        private class ExecutionEventQueueItem
        {
            public ExecutionEventQueueItem(PipelineStateInfo pipelineStateInfo, RunspaceAvailability currentAvailability, RunspaceAvailability newAvailability)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1476, 30176, 30552);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 30593, 30610);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 30653, 30680);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 30723, 30746);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 30356, 30399);

                    this.PipelineStateInfo = pipelineStateInfo;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 30417, 30472);

                    this.CurrentRunspaceAvailability = currentAvailability;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 30490, 30537);

                    this.NewRunspaceAvailability = newAvailability;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1476, 30176, 30552);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1476, 30176, 30552);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1476, 30176, 30552);
                }
            }

            public PipelineStateInfo PipelineStateInfo;

            public RunspaceAvailability CurrentRunspaceAvailability;

            public RunspaceAvailability NewRunspaceAvailability;

            static ExecutionEventQueueItem()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1476, 30114, 30758);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1476, 30114, 30758);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1476, 30114, 30758);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1476, 30114, 30758);
        }

        protected void SetPipelineState(PipelineState state, Exception reason)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1476, 31344, 32526);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 31445, 31453);
                lock (f_1476_31445_31453())
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 31487, 32500) || true) && (state != f_1476_31500_31513())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1476, 31487, 32500);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 31555, 31613);

                        _pipelineStateInfo = f_1476_31576_31612(state, reason);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 32034, 32109);

                        RunspaceAvailability
                        previousAvailability = f_1476_32078_32108(_runspace)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 32133, 32203);

                        f_1476_32133_32202(
                                            _runspace, f_1476_32170_32194(_pipelineStateInfo), false);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 32227, 32481);

                        f_1476_32227_32480(
                                            _executionEventQueue, f_1476_32282_32479(f_1476_32340_32366(_pipelineStateInfo), previousAvailability, f_1476_32448_32478(_runspace)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1476, 31487, 32500);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1476, 31344, 32526);

                object
                f_1476_31445_31453()
                {
                    var return_v = SyncRoot;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 31445, 31453);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineState
                f_1476_31500_31513()
                {
                    var return_v = PipelineState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 31500, 31513);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineStateInfo
                f_1476_31576_31612(System.Management.Automation.Runspaces.PipelineState
                state, System.Exception
                reason)
                {
                    var return_v = new System.Management.Automation.Runspaces.PipelineStateInfo(state, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 31576, 31612);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceAvailability
                f_1476_32078_32108(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.RunspaceAvailability;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 32078, 32108);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineState
                f_1476_32170_32194(System.Management.Automation.Runspaces.PipelineStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 32170, 32194);
                    return return_v;
                }


                int
                f_1476_32133_32202(System.Management.Automation.Runspaces.Runspace
                this_param, System.Management.Automation.Runspaces.PipelineState
                pipelineState, bool
                raiseEvent)
                {
                    this_param.UpdateRunspaceAvailability(pipelineState, raiseEvent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 32133, 32202);
                    return 0;
                }


                System.Management.Automation.Runspaces.PipelineStateInfo
                f_1476_32340_32366(System.Management.Automation.Runspaces.PipelineStateInfo
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 32340, 32366);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceAvailability
                f_1476_32448_32478(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.RunspaceAvailability;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 32448, 32478);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineBase.ExecutionEventQueueItem
                f_1476_32282_32479(System.Management.Automation.Runspaces.PipelineStateInfo
                pipelineStateInfo, System.Management.Automation.Runspaces.RunspaceAvailability
                currentAvailability, System.Management.Automation.Runspaces.RunspaceAvailability
                newAvailability)
                {
                    var return_v = new System.Management.Automation.Runspaces.PipelineBase.ExecutionEventQueueItem(pipelineStateInfo, currentAvailability, newAvailability);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 32282, 32479);
                    return return_v;
                }


                int
                f_1476_32227_32480(System.Collections.Generic.Queue<System.Management.Automation.Runspaces.PipelineBase.ExecutionEventQueueItem>
                this_param, System.Management.Automation.Runspaces.PipelineBase.ExecutionEventQueueItem
                item)
                {
                    this_param.Enqueue(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 32227, 32480);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1476, 31344, 32526);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1476, 31344, 32526);
            }
        }

        protected void SetPipelineState(PipelineState state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1476, 32683, 32801);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 32760, 32790);

                f_1476_32760_32789(this, state, null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1476, 32683, 32801);

                int
                f_1476_32760_32789(System.Management.Automation.Runspaces.PipelineBase
                this_param, System.Management.Automation.Runspaces.PipelineState
                state, System.Exception
                reason)
                {
                    this_param.SetPipelineState(state, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 32760, 32789);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1476, 32683, 32801);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1476, 32683, 32801);
            }
        }

        protected void RaisePipelineStateEvents()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1476, 32919, 35200);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 32985, 33038);

                Queue<ExecutionEventQueueItem>
                tempEventQueue = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 33052, 33109);

                EventHandler<PipelineStateEventArgs>
                stateChanged = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 33123, 33178);

                bool
                runspaceHasAvailabilityChangedSubscribers = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 33200, 33208);

                lock (f_1476_33200_33208())
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 33242, 33275);

                    stateChanged = this.StateChanged;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 33293, 33381);

                    runspaceHasAvailabilityChangedSubscribers = f_1476_33337_33380(_runspace);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 33401, 33972) || true) && (stateChanged != null || (DynAbs.Tracing.TraceSender.Expression_False(1476, 33405, 33470) || runspaceHasAvailabilityChangedSubscribers))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1476, 33401, 33972);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 33512, 33550);

                        tempEventQueue = _executionEventQueue;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 33572, 33632);

                        _executionEventQueue = f_1476_33595_33631();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1476, 33401, 33972);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1476, 33401, 33972);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 33924, 33953);

                        f_1476_33924_33952(                    // Clear the events if there are no EventHandlers. This
                                                               // ensures that events do not get called for state
                                                               // changes prior to their registration.
                                            _executionEventQueue);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1476, 33401, 33972);
                    }
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 34003, 35189) || true) && (tempEventQueue != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1476, 34003, 35189);
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 34063, 35174) || true) && (f_1476_34070_34090(tempEventQueue) > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1476, 34063, 35174);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 34136, 34197);

                            ExecutionEventQueueItem
                            queueItem = f_1476_34172_34196(tempEventQueue)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 34221, 34492) || true) && (runspaceHasAvailabilityChangedSubscribers && (DynAbs.Tracing.TraceSender.Expression_True(1476, 34225, 34344) && queueItem.NewRunspaceAvailability != queueItem.CurrentRunspaceAvailability))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1476, 34221, 34492);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 34394, 34469);

                                f_1476_34394_34468(_runspace, queueItem.NewRunspaceAvailability);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1476, 34221, 34492);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 34767, 35124) || true) && (stateChanged != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1476, 34767, 35124);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 34901, 34977);

                                    f_1476_34901_34976(stateChanged, this, f_1476_34920_34975(queueItem.PipelineStateInfo));
                                }
                                catch (Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1476, 35030, 35101);
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(1476, 35030, 35101);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1476, 34767, 35124);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1476, 34063, 35174);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1476, 34063, 35174);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1476, 34063, 35174);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1476, 34003, 35189);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1476, 32919, 35200);

                object
                f_1476_33200_33208()
                {
                    var return_v = SyncRoot;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 33200, 33208);
                    return return_v;
                }


                bool
                f_1476_33337_33380(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.HasAvailabilityChangedSubscribers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 33337, 33380);
                    return return_v;
                }


                System.Collections.Generic.Queue<System.Management.Automation.Runspaces.PipelineBase.ExecutionEventQueueItem>
                f_1476_33595_33631()
                {
                    var return_v = new System.Collections.Generic.Queue<System.Management.Automation.Runspaces.PipelineBase.ExecutionEventQueueItem>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 33595, 33631);
                    return return_v;
                }


                int
                f_1476_33924_33952(System.Collections.Generic.Queue<System.Management.Automation.Runspaces.PipelineBase.ExecutionEventQueueItem>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 33924, 33952);
                    return 0;
                }


                int
                f_1476_34070_34090(System.Collections.Generic.Queue<System.Management.Automation.Runspaces.PipelineBase.ExecutionEventQueueItem>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 34070, 34090);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineBase.ExecutionEventQueueItem
                f_1476_34172_34196(System.Collections.Generic.Queue<System.Management.Automation.Runspaces.PipelineBase.ExecutionEventQueueItem>
                this_param)
                {
                    var return_v = this_param.Dequeue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 34172, 34196);
                    return return_v;
                }


                int
                f_1476_34394_34468(System.Management.Automation.Runspaces.Runspace
                this_param, System.Management.Automation.Runspaces.RunspaceAvailability
                availability)
                {
                    this_param.RaiseAvailabilityChangedEvent(availability);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 34394, 34468);
                    return 0;
                }


                System.Management.Automation.Runspaces.PipelineStateEventArgs
                f_1476_34920_34975(System.Management.Automation.Runspaces.PipelineStateInfo
                pipelineStateInfo)
                {
                    var return_v = new System.Management.Automation.Runspaces.PipelineStateEventArgs(pipelineStateInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 34920, 34975);
                    return return_v;
                }


                int
                f_1476_34901_34976(System.EventHandler<System.Management.Automation.Runspaces.PipelineStateEventArgs>
                this_param, System.Management.Automation.Runspaces.PipelineBase
                sender, System.Management.Automation.Runspaces.PipelineStateEventArgs
                e)
                {
                    this_param.Invoke((object)sender, e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 34901, 34976);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1476, 32919, 35200);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1476, 32919, 35200);
            }
        }

        internal ManualResetEvent PipelineFinishedEvent { get; private set; }

        protected ObjectStreamBase OutputStream { get; }

        private ObjectStreamBase _errorStream;

        protected ObjectStreamBase ErrorStream
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1476, 36134, 36205);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 36170, 36190);

                    return _errorStream;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1476, 36134, 36205);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1476, 36071, 36471);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1476, 36071, 36471);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            private set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1476, 36221, 36460);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 36265, 36321);

                    f_1476_36265_36320(value != null, "ErrorStream cannot be null");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 36339, 36360);

                    _errorStream = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 36378, 36445);

                    _errorStream.DataReady += new EventHandler(OnErrorStreamDataReady);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1476, 36221, 36460);

                    int
                    f_1476_36265_36320(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Dbg.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 36265, 36320);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1476, 36071, 36471);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1476, 36071, 36471);
                }
            }
        }

        private void OnErrorStreamDataReady(object sender, EventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1476, 36564, 37005);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 36652, 36994) || true) && (f_1476_36656_36674(_errorStream) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1476, 36652, 36994);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 36875, 36942);

                    _errorStream.DataReady -= new EventHandler(OnErrorStreamDataReady);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 36960, 36979);

                    f_1476_36960_36978(this, true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1476, 36652, 36994);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1476, 36564, 37005);

                int
                f_1476_36656_36674(System.Management.Automation.Internal.ObjectStreamBase
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 36656, 36674);
                    return return_v;
                }


                int
                f_1476_36960_36978(System.Management.Automation.Runspaces.PipelineBase
                this_param, bool
                status)
                {
                    this_param.SetHadErrors(status);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 36960, 36978);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1476, 36564, 37005);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1476, 36564, 37005);
            }
        }

        protected PSInformationalBuffers InformationalBuffers { get; }

        protected ObjectStreamBase InputStream { get; }

        internal bool AddToHistory { get; set; }

        internal string HistoryString { get; set; }

        private void Initialize(Runspace runspace, string command, bool addToHistory, bool isNested)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1476, 38895, 39599);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 39012, 39081);

                f_1476_39012_39080(runspace != null, "caller should validate the parameter");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 39095, 39116);

                _runspace = runspace;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 39132, 39153);

                _isNested = isNested;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 39169, 39309) || true) && (addToHistory && (DynAbs.Tracing.TraceSender.Expression_True(1476, 39173, 39204) && command == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1476, 39169, 39309);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 39238, 39294);

                    throw f_1476_39244_39293("command");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1476, 39169, 39309);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 39325, 39441) || true) && (command != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1476, 39325, 39441);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 39378, 39426);

                    f_1476_39378_39425(f_1476_39378_39386(), f_1476_39391_39424(command, true, false));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1476, 39325, 39441);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 39457, 39485);

                AddToHistory = addToHistory;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 39499, 39588) || true) && (f_1476_39503_39515())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1476, 39499, 39588);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 39549, 39573);

                    HistoryString = command;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1476, 39499, 39588);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1476, 38895, 39599);

                int
                f_1476_39012_39080(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 39012, 39080);
                    return 0;
                }


                System.Management.Automation.PSArgumentNullException
                f_1476_39244_39293(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 39244, 39293);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandCollection
                f_1476_39378_39386()
                {
                    var return_v = Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 39378, 39386);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Command
                f_1476_39391_39424(string
                command, bool
                isScript, bool
                useLocalScope)
                {
                    var return_v = new System.Management.Automation.Runspaces.Command(command, isScript, useLocalScope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 39391, 39424);
                    return return_v;
                }


                int
                f_1476_39378_39425(System.Management.Automation.Runspaces.CommandCollection
                this_param, System.Management.Automation.Runspaces.Command
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 39378, 39425);
                    return 0;
                }


                bool
                f_1476_39503_39515()
                {
                    var return_v = AddToHistory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 39503, 39515);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1476, 38895, 39599);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1476, 38895, 39599);
            }
        }

        private RunspaceBase RunspaceBase
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1476, 39669, 39750);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 39705, 39735);

                    return (RunspaceBase)f_1476_39726_39734();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1476, 39669, 39750);

                    System.Management.Automation.Runspaces.Runspace
                    f_1476_39726_39734()
                    {
                        var return_v = Runspace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 39726, 39734);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1476, 39611, 39761);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1476, 39611, 39761);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected internal object SyncRoot { get; }

        private bool _disposed;

        protected override
                void
                Dispose(bool disposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1476, 40303, 41022);
                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 40429, 40903) || true) && (_disposed == false)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1476, 40429, 40903);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 40493, 40510);

                        _disposed = true;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 40532, 40884) || true) && (disposing)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1476, 40532, 40884);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 40595, 40615);

                            f_1476_40595_40614(f_1476_40595_40606());
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 40641, 40662);

                            f_1476_40641_40661(f_1476_40641_40653());
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 40690, 40757);

                            _errorStream.DataReady -= new EventHandler(OnErrorStreamDataReady);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 40783, 40804);

                            f_1476_40783_40803(_errorStream);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 40832, 40861);

                            f_1476_40832_40860(
                                                    _executionEventQueue);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1476, 40532, 40884);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1476, 40429, 40903);
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1476, 40932, 41011);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1476, 40972, 40996);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Dispose(disposing), 1476, 40972, 40995);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1476, 40932, 41011);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1476, 40303, 41022);

                System.Management.Automation.Internal.ObjectStreamBase
                f_1476_40595_40606()
                {
                    var return_v = InputStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 40595, 40606);
                    return return_v;
                }


                int
                f_1476_40595_40614(System.Management.Automation.Internal.ObjectStreamBase
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 40595, 40614);
                    return 0;
                }


                System.Management.Automation.Internal.ObjectStreamBase
                f_1476_40641_40653()
                {
                    var return_v = OutputStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 40641, 40653);
                    return return_v;
                }


                int
                f_1476_40641_40661(System.Management.Automation.Internal.ObjectStreamBase
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 40641, 40661);
                    return 0;
                }


                int
                f_1476_40783_40803(System.Management.Automation.Internal.ObjectStreamBase
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 40783, 40803);
                    return 0;
                }


                int
                f_1476_40832_40860(System.Collections.Generic.Queue<System.Management.Automation.Runspaces.PipelineBase.ExecutionEventQueueItem>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 40832, 40860);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1476, 40303, 41022);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1476, 40303, 41022);
            }
        }

        static PipelineBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1476, 698, 41071);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1476, 698, 41071);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1476, 698, 41071);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1476, 698, 41071);

        int
        f_1476_1470_1523(System.Management.Automation.Runspaces.PipelineBase
        this_param, System.Management.Automation.Runspaces.Runspace
        runspace, string
        command, bool
        addToHistory, bool
        isNested)
        {
            this_param.Initialize(runspace, command, addToHistory, isNested);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 1470, 1523);
            return 0;
        }


        System.Management.Automation.Internal.ObjectStream
        f_1476_1589_1607()
        {
            var return_v = new System.Management.Automation.Internal.ObjectStream();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 1589, 1607);
            return return_v;
        }


        System.Management.Automation.Internal.ObjectStream
        f_1476_1637_1655()
        {
            var return_v = new System.Management.Automation.Internal.ObjectStream();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 1637, 1655);
            return return_v;
        }


        System.Management.Automation.Internal.ObjectStream
        f_1476_1684_1702()
        {
            var return_v = new System.Management.Automation.Internal.ObjectStream();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 1684, 1702);
            return return_v;
        }


        static System.Management.Automation.Runspaces.Runspace
        f_1476_1436_1444_C(System.Management.Automation.Runspaces.Runspace
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1476, 1324, 1714);
            return return_v;
        }


        int
        f_1476_3527_3606(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 3527, 3606);
            return 0;
        }


        int
        f_1476_3621_3702(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 3621, 3702);
            return 0;
        }


        int
        f_1476_3717_3796(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 3717, 3796);
            return 0;
        }


        int
        f_1476_3811_3899(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 3811, 3899);
            return 0;
        }


        int
        f_1476_3914_3967(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 3914, 3967);
            return 0;
        }


        int
        f_1476_4219_4262(System.Management.Automation.Runspaces.PipelineBase
        this_param, System.Management.Automation.Runspaces.Runspace
        runspace, string
        command, bool
        addToHistory, bool
        isNested)
        {
            this_param.Initialize(runspace, command, addToHistory, isNested);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 4219, 4262);
            return 0;
        }


        string
        f_1476_4403_4439(System.Management.Automation.Runspaces.CommandCollection
        this_param)
        {
            var return_v = this_param.GetCommandStringForHistory();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 4403, 4439);
            return return_v;
        }


        static System.Management.Automation.Runspaces.Runspace
        f_1476_3484_3492_C(System.Management.Automation.Runspaces.Runspace
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1476, 3143, 4762);
            return return_v;
        }


        static System.Management.Automation.Runspaces.Runspace
        f_1476_5325_5342(System.Management.Automation.Runspaces.PipelineBase
        this_param)
        {
            var return_v = this_param.Runspace;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 5325, 5342);
            return return_v;
        }


        static bool
        f_1476_5357_5374(System.Management.Automation.Runspaces.PipelineBase
        this_param)
        {
            var return_v = this_param.IsNested;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 5357, 5374);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1476_5530_5580(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 5530, 5580);
            return return_v;
        }


        System.Management.Automation.PSObjectDisposedException
        f_1476_5674_5726(string
        objectName)
        {
            var return_v = PSTraceSource.NewObjectDisposedException(objectName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 5674, 5726);
            return return_v;
        }


        bool
        f_1476_5773_5794(System.Management.Automation.Runspaces.PipelineBase
        this_param)
        {
            var return_v = this_param.AddToHistory;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 5773, 5794);
            return return_v;
        }


        string
        f_1476_5825_5847(System.Management.Automation.Runspaces.PipelineBase
        this_param)
        {
            var return_v = this_param.HistoryString;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 5825, 5847);
            return return_v;
        }


        System.Management.Automation.Runspaces.CommandCollection
        f_1476_5890_5907(System.Management.Automation.Runspaces.PipelineBase
        this_param)
        {
            var return_v = this_param.Commands;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 5890, 5907);
            return return_v;
        }


        System.Management.Automation.Runspaces.Command
        f_1476_5957_5972(System.Management.Automation.Runspaces.Command
        this_param)
        {
            var return_v = this_param.Clone();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 5957, 5972);
            return return_v;
        }


        System.Management.Automation.Runspaces.CommandCollection
        f_1476_6057_6065()
        {
            var return_v = Commands;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1476, 6057, 6065);
            return return_v;
        }


        int
        f_1476_6057_6076(System.Management.Automation.Runspaces.CommandCollection
        this_param, System.Management.Automation.Runspaces.Command
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 6057, 6076);
            return 0;
        }


        System.Management.Automation.Runspaces.CommandCollection
        f_1476_5890_5907_I(System.Management.Automation.Runspaces.CommandCollection
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 5890, 5907);
            return return_v;
        }


        static System.Management.Automation.Runspaces.Runspace
        f_1476_5325_5342_C(System.Management.Automation.Runspaces.Runspace
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1476, 5259, 6103);
            return return_v;
        }


        System.Management.Automation.Runspaces.PipelineStateInfo
        f_1476_7201_7248(System.Management.Automation.Runspaces.PipelineState
        state)
        {
            var return_v = new System.Management.Automation.Runspaces.PipelineStateInfo(state);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 7201, 7248);
            return return_v;
        }


        System.Collections.Generic.Queue<System.Management.Automation.Runspaces.PipelineBase.ExecutionEventQueueItem>
        f_1476_30065_30101()
        {
            var return_v = new System.Collections.Generic.Queue<System.Management.Automation.Runspaces.PipelineBase.ExecutionEventQueueItem>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 30065, 30101);
            return return_v;
        }


        object
        f_1476_39912_39924()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1476, 39912, 39924);
            return return_v;
        }

    }
}
