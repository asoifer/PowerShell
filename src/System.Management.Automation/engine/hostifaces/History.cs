// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Management.Automation;
using System.Management.Automation.Host;
using System.Management.Automation.Internal;
using System.Management.Automation.Runspaces;

using Dbg = System.Management.Automation.Diagnostics;

namespace Microsoft.PowerShell.Commands
{
    public class HistoryInfo
    {
        internal HistoryInfo(long pipelineId, string cmdline, PipelineState status, DateTime startTime, DateTime endTime)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1460, 1142, 1589);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 2273, 2309);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 2430, 2477);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 2619, 2677);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 3764, 3808);
                this.Cleared = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 4708, 4719);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 1280, 1348);

                f_1460_1280_1347(cmdline != null, "caller should validate the parameter");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 1362, 1387);

                _pipelineId = pipelineId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 1401, 1423);

                CommandLine = cmdline;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 1437, 1462);

                ExecutionStatus = status;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 1476, 1507);

                StartExecutionTime = startTime;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 1521, 1548);

                EndExecutionTime = endTime;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 1562, 1578);

                Cleared = false;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1460, 1142, 1589);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 1142, 1589);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 1142, 1589);
            }
        }

        private HistoryInfo(HistoryInfo history)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1460, 1742, 2146);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 2273, 2309);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 2430, 2477);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 2619, 2677);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 3764, 3808);
                this.Cleared = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 4708, 4719);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 1807, 1823);

                Id = f_1460_1812_1822(history);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 1837, 1871);

                _pipelineId = history._pipelineId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 1885, 1919);

                CommandLine = f_1460_1899_1918(history);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 1933, 1975);

                ExecutionStatus = f_1460_1951_1974(history);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 1989, 2037);

                StartExecutionTime = f_1460_2010_2036(history);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 2051, 2095);

                EndExecutionTime = f_1460_2070_2094(history);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 2109, 2135);

                Cleared = f_1460_2119_2134(history);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1460, 1742, 2146);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 1742, 2146);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 1742, 2146);
            }
        }

        public long Id { get; private set; }

        public string CommandLine { get; private set; }

        public PipelineState ExecutionStatus { get; private set; }

        public DateTime StartExecutionTime { get; }

        public DateTime EndExecutionTime { get; private set; }

        public TimeSpan Duration
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1460, 3221, 3261);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 3224, 3261);
                    return f_1460_3224_3240() - f_1460_3243_3261();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1460, 3221, 3261);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 3221, 3261);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 3221, 3261);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1460, 3399, 3662);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 3457, 3651) || true) && (f_1460_3461_3494(f_1460_3482_3493()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 3457, 3651);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 3528, 3551);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.ToString(), 1460, 3535, 3550);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 3457, 3651);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 3457, 3651);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 3617, 3636);

                    return f_1460_3624_3635();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 3457, 3651);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1460, 3399, 3662);

                string
                f_1460_3482_3493()
                {
                    var return_v = CommandLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 3482, 3493);
                    return return_v;
                }


                bool
                f_1460_3461_3494(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 3461, 3494);
                    return return_v;
                }


                string
                f_1460_3624_3635()
                {
                    var return_v = CommandLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 3624, 3635);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 3399, 3662);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 3399, 3662);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool Cleared { get; set; }

        internal void SetId(long id)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1460, 3957, 3967);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 3960, 3967);
                Id = id;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1460, 3957, 3967);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 3957, 3967);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 3957, 3967);
            }
        }

        internal void SetStatus(PipelineState status)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1460, 4141, 4168);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 4144, 4168);
                ExecutionStatus = status;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1460, 4141, 4168);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 4141, 4168);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 4141, 4168);
            }
        }

        internal void SetEndTime(DateTime endTime)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1460, 4341, 4370);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 4344, 4370);
                EndExecutionTime = endTime;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1460, 4341, 4370);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 4341, 4370);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 4341, 4370);
            }
        }

        internal void SetCommand(string command)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1460, 4542, 4566);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 4545, 4566);
                CommandLine = command;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1460, 4542, 4566);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 4542, 4566);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 4542, 4566);
            }
        }

        private long _pipelineId;

        public HistoryInfo Clone()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1460, 4859, 4950);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 4910, 4939);

                return f_1460_4917_4938(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1460, 4859, 4950);

                Microsoft.PowerShell.Commands.HistoryInfo
                f_1460_4917_4938(Microsoft.PowerShell.Commands.HistoryInfo
                history)
                {
                    var return_v = new Microsoft.PowerShell.Commands.HistoryInfo(history);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 4917, 4938);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 4859, 4950);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 4859, 4950);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static HistoryInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1460, 625, 4957);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1460, 625, 4957);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 625, 4957);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1460, 625, 4957);

        int
        f_1460_1280_1347(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 1280, 1347);
            return 0;
        }


        long
        f_1460_1812_1822(Microsoft.PowerShell.Commands.HistoryInfo
        this_param)
        {
            var return_v = this_param.Id;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 1812, 1822);
            return return_v;
        }


        string
        f_1460_1899_1918(Microsoft.PowerShell.Commands.HistoryInfo
        this_param)
        {
            var return_v = this_param.CommandLine;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 1899, 1918);
            return return_v;
        }


        System.Management.Automation.Runspaces.PipelineState
        f_1460_1951_1974(Microsoft.PowerShell.Commands.HistoryInfo
        this_param)
        {
            var return_v = this_param.ExecutionStatus;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 1951, 1974);
            return return_v;
        }


        System.DateTime
        f_1460_2010_2036(Microsoft.PowerShell.Commands.HistoryInfo
        this_param)
        {
            var return_v = this_param.StartExecutionTime;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 2010, 2036);
            return return_v;
        }


        System.DateTime
        f_1460_2070_2094(Microsoft.PowerShell.Commands.HistoryInfo
        this_param)
        {
            var return_v = this_param.EndExecutionTime;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 2070, 2094);
            return return_v;
        }


        bool
        f_1460_2119_2134(Microsoft.PowerShell.Commands.HistoryInfo
        this_param)
        {
            var return_v = this_param.Cleared;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 2119, 2134);
            return return_v;
        }


        System.DateTime
        f_1460_3224_3240()
        {
            var return_v = EndExecutionTime;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 3224, 3240);
            return return_v;
        }


        System.DateTime
        f_1460_3243_3261()
        {
            var return_v = StartExecutionTime;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 3243, 3261);
            return return_v;
        }

    }
    internal class History
    {
        internal const int
        DefaultHistorySize = 4096
        ;

        internal History(ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1460, 5414, 6166);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 29503, 29510);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 29624, 29633);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 29757, 29778);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 30037, 30055);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 30179, 30203);
                this._syncRoot = f_1460_30191_30203();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 5593, 5651);

                Collection<Attribute>
                attrs = f_1460_5623_5650()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 5665, 5727);

                f_1460_5665_5726(attrs, f_1460_5675_5725(1, (int)Int16.MaxValue));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 5741, 5865);

                PSVariable
                historySizeVar = f_1460_5769_5864(SpecialVariables.HistorySize, DefaultHistorySize, ScopedItemOptions.None, attrs)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 5879, 5955);

                historySizeVar.Description = f_1460_5908_5954();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 5971, 6057);

                f_1460_5971_6056(f_1460_5971_5997(context), historySizeVar, false, CommandOrigin.Internal);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 6073, 6104);

                _capacity = DefaultHistorySize;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 6118, 6155);

                _buffer = new HistoryInfo[_capacity];
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1460, 5414, 6166);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 5414, 6166);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 5414, 6166);
            }
        }

        internal long AddEntry(long pipelineId, string cmdline, PipelineState status, DateTime startTime, DateTime endTime, bool skipIfLocked)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1460, 6872, 7549);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 7031, 7193) || true) && (!f_1460_7036_7134(_syncRoot, (DynAbs.Tracing.TraceSender.Conditional_F1(1460, 7081, 7093) || ((skipIfLocked && DynAbs.Tracing.TraceSender.Conditional_F2(1460, 7096, 7097)) || DynAbs.Tracing.TraceSender.Conditional_F3(1460, 7100, 7133))) ? 0 : System.Threading.Timeout.Infinite))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 7031, 7193);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 7168, 7178);

                    return -1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 7031, 7193);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 7245, 7272);

                    f_1460_7245_7271(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 7292, 7377);

                    HistoryInfo
                    entry = f_1460_7312_7376(pipelineId, cmdline, status, startTime, endTime)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 7395, 7413);

                    return f_1460_7402_7412(this, entry);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1460, 7442, 7538);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 7482, 7523);

                    f_1460_7482_7522(_syncRoot);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1460, 7442, 7538);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1460, 6872, 7549);

                bool
                f_1460_7036_7134(object
                obj, int
                millisecondsTimeout)
                {
                    var return_v = System.Threading.Monitor.TryEnter(obj, millisecondsTimeout);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 7036, 7134);
                    return return_v;
                }


                int
                f_1460_7245_7271(Microsoft.PowerShell.Commands.History
                this_param)
                {
                    this_param.ReallocateBufferIfNeeded();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 7245, 7271);
                    return 0;
                }


                Microsoft.PowerShell.Commands.HistoryInfo
                f_1460_7312_7376(long
                pipelineId, string
                cmdline, System.Management.Automation.Runspaces.PipelineState
                status, System.DateTime
                startTime, System.DateTime
                endTime)
                {
                    var return_v = new Microsoft.PowerShell.Commands.HistoryInfo(pipelineId, cmdline, status, startTime, endTime);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 7312, 7376);
                    return return_v;
                }


                long
                f_1460_7402_7412(Microsoft.PowerShell.Commands.History
                this_param, Microsoft.PowerShell.Commands.HistoryInfo
                entry)
                {
                    var return_v = this_param.Add(entry);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 7402, 7412);
                    return return_v;
                }


                int
                f_1460_7482_7522(object
                obj)
                {
                    System.Threading.Monitor.Exit(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 7482, 7522);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 6872, 7549);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 6872, 7549);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void UpdateEntry(long id, PipelineState status, DateTime endTime, bool skipIfLocked)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1460, 8016, 8686);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 8134, 8293) || true) && (!f_1460_8139_8237(_syncRoot, (DynAbs.Tracing.TraceSender.Conditional_F1(1460, 8184, 8196) || ((skipIfLocked && DynAbs.Tracing.TraceSender.Conditional_F2(1460, 8199, 8200)) || DynAbs.Tracing.TraceSender.Conditional_F3(1460, 8203, 8236))) ? 0 : System.Threading.Timeout.Infinite))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 8134, 8293);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 8271, 8278);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 8134, 8293);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 8345, 8382);

                    HistoryInfo
                    entry = f_1460_8365_8381(this, id)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 8400, 8550) || true) && (entry != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 8400, 8550);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 8459, 8483);

                        f_1460_8459_8482(entry, status);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 8505, 8531);

                        f_1460_8505_8530(entry, endTime);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 8400, 8550);
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1460, 8579, 8675);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 8619, 8660);

                    f_1460_8619_8659(_syncRoot);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1460, 8579, 8675);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1460, 8016, 8686);

                bool
                f_1460_8139_8237(object
                obj, int
                millisecondsTimeout)
                {
                    var return_v = System.Threading.Monitor.TryEnter(obj, millisecondsTimeout);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 8139, 8237);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.HistoryInfo
                f_1460_8365_8381(Microsoft.PowerShell.Commands.History
                this_param, long
                id)
                {
                    var return_v = this_param.CoreGetEntry(id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 8365, 8381);
                    return return_v;
                }


                int
                f_1460_8459_8482(Microsoft.PowerShell.Commands.HistoryInfo
                this_param, System.Management.Automation.Runspaces.PipelineState
                status)
                {
                    this_param.SetStatus(status);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 8459, 8482);
                    return 0;
                }


                int
                f_1460_8505_8530(Microsoft.PowerShell.Commands.HistoryInfo
                this_param, System.DateTime
                endTime)
                {
                    this_param.SetEndTime(endTime);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 8505, 8530);
                    return 0;
                }


                int
                f_1460_8619_8659(object
                obj)
                {
                    System.Threading.Monitor.Exit(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 8619, 8659);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 8016, 8686);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 8016, 8686);
            }
        }

        internal HistoryInfo GetEntry(long id)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1460, 9025, 9411);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 9094, 9103);
                lock (_syncRoot)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 9137, 9164);

                    f_1460_9137_9163(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 9184, 9221);

                    HistoryInfo
                    entry = f_1460_9204_9220(this, id)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 9239, 9353) || true) && (entry != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 9239, 9353);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 9279, 9353) || true) && (f_1460_9283_9296(entry) == false)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 9279, 9353);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 9332, 9353);

                            return f_1460_9339_9352(entry);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 9279, 9353);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 9239, 9353);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 9373, 9385);

                    return null;
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1460, 9025, 9411);

                int
                f_1460_9137_9163(Microsoft.PowerShell.Commands.History
                this_param)
                {
                    this_param.ReallocateBufferIfNeeded();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 9137, 9163);
                    return 0;
                }


                Microsoft.PowerShell.Commands.HistoryInfo
                f_1460_9204_9220(Microsoft.PowerShell.Commands.History
                this_param, long
                id)
                {
                    var return_v = this_param.CoreGetEntry(id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 9204, 9220);
                    return return_v;
                }


                bool
                f_1460_9283_9296(Microsoft.PowerShell.Commands.HistoryInfo
                this_param)
                {
                    var return_v = this_param.Cleared;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 9283, 9296);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.HistoryInfo
                f_1460_9339_9352(Microsoft.PowerShell.Commands.HistoryInfo
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 9339, 9352);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 9025, 9411);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 9025, 9411);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal HistoryInfo[] GetEntries(long id, long count, SwitchParameter newest)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1460, 9682, 17713);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 9785, 9812);

                f_1460_9785_9811(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 9828, 9958) || true) && (count < -1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 9828, 9958);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 9876, 9943);

                    throw f_1460_9882_9942("count", count);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 9828, 9958);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 9974, 10107) || true) && (newest.ToString() == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 9974, 10107);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 10037, 10092);

                    throw f_1460_10043_10091("newest");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 9974, 10107);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 10123, 10250) || true) && (count == -1 || (DynAbs.Tracing.TraceSender.Expression_False(1460, 10127, 10168) || count > _countEntriesAdded) || (DynAbs.Tracing.TraceSender.Expression_False(1460, 10127, 10201) || count > _countEntriesInBuffer))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 10123, 10250);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 10220, 10250);

                    count = _countEntriesInBuffer;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 10123, 10250);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 10266, 10393) || true) && (count == 0 || (DynAbs.Tracing.TraceSender.Expression_False(1460, 10270, 10310) || _countEntriesInBuffer == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 10266, 10393);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 10344, 10378);

                    return f_1460_10351_10377();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 10266, 10393);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 10415, 10424);

                lock (_syncRoot)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 10627, 10683);

                    List<HistoryInfo>
                    entriesList = f_1460_10659_10682()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 10701, 17529) || true) && (id > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 10701, 17529);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 10753, 10774);

                        long
                        firstId
                        = default(long),
                        baseId
                        = default(long);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 10796, 10808);

                        baseId = id;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 10883, 14508) || true) && (f_1460_10887_10904_M(!newest.IsPresent))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 10883, 14508);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 11078, 11107);

                            firstId = baseId - count + 1;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 11277, 11389) || true) && (firstId < 1)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 11277, 11389);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 11350, 11362);

                                firstId = 1;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 11277, 11389);
                            }
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 11427, 11437);

                                for (long
        i = baseId
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 11417, 12181) || true) && (i >= firstId)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 11453, 11456)
        , --i, DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 11417, 12181))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 11417, 12181);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 11514, 11538) || true) && (firstId <= 1)
                                    )
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 11514, 11538);
                                        DynAbs.Tracing.TraceSender.TraceBreak(1460, 11532, 11538);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 11514, 11538);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 11657, 11706) || true) && (_buffer[f_1460_11669_11686(this, i)] == null)
                                    )
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 11657, 11706);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 11697, 11706);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 11657, 11706);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 11736, 12154) || true) && (f_1460_11740_11774(_buffer[f_1460_11748_11765(this, i)]) == true)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 11736, 12154);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 12070, 12080);

                                        firstId--;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 12114, 12123);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 11736, 12154);
                                    }
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1460, 1, 765);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1460, 1, 765);
                            }
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 12219, 12230);

                                for (long
        i = firstId
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 12209, 12701) || true) && (i <= baseId)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 12245, 12248)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 12209, 12701))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 12209, 12701);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 12464, 12592) || true) && (_buffer[f_1460_12476_12493(this, i)] == null || (DynAbs.Tracing.TraceSender.Expression_False(1460, 12468, 12548) || f_1460_12506_12540(_buffer[f_1460_12514_12531(this, i)]) == true))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 12464, 12592);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 12583, 12592);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 12464, 12592);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 12622, 12674);

                                    f_1460_12622_12673(entriesList, f_1460_12638_12672(_buffer[f_1460_12646_12663(this, i)]));
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1460, 1, 493);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1460, 1, 493);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 10883, 14508);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 10883, 14508);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 12921, 12950);

                            firstId = baseId + count - 1;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 13108, 13255) || true) && (firstId >= _countEntriesAdded)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 13108, 13255);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 13199, 13228);

                                firstId = _countEntriesAdded;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 13108, 13255);
                            }
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 13293, 13303);

                                for (long
        i = baseId
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 13283, 13965) || true) && (i <= firstId)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 13319, 13322)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 13283, 13965))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 13283, 13965);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 13380, 13421) || true) && (firstId >= _countEntriesAdded)
                                    )
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 13380, 13421);
                                        DynAbs.Tracing.TraceSender.TraceBreak(1460, 13415, 13421);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 13380, 13421);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 13540, 13589) || true) && (_buffer[f_1460_13552_13569(this, i)] == null)
                                    )
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 13540, 13589);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 13580, 13589);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 13540, 13589);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 13619, 13938) || true) && (f_1460_13623_13657(_buffer[f_1460_13631_13648(this, i)]) == true)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 13619, 13938);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 13854, 13864);

                                        firstId++;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 13898, 13907);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 13619, 13938);
                                    }
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1460, 1, 683);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1460, 1, 683);
                            }
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 14003, 14014);

                                for (long
        i = firstId
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 13993, 14485) || true) && (i >= baseId)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 14029, 14032)
        , --i, DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 13993, 14485))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 13993, 14485);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 14248, 14376) || true) && (_buffer[f_1460_14260_14277(this, i)] == null || (DynAbs.Tracing.TraceSender.Expression_False(1460, 14252, 14332) || f_1460_14290_14324(_buffer[f_1460_14298_14315(this, i)]) == true))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 14248, 14376);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 14367, 14376);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 14248, 14376);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 14406, 14458);

                                    f_1460_14406_14457(entriesList, f_1460_14422_14456(_buffer[f_1460_14430_14447(this, i)]));
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1460, 1, 493);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1460, 1, 493);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 10883, 14508);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 10701, 17529);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 10701, 17529);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 14645, 14672);

                        long
                        index
                        = default(long),
                        SmallestID = 0
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 14989, 15085) || true) && (_capacity != DefaultHistorySize)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 14989, 15085);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 15051, 15085);

                            SmallestID = f_1460_15064_15084(this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 14989, 15085);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 15107, 17510) || true) && (f_1460_15111_15128_M(!newest.IsPresent))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 15107, 17510);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 15231, 15241);

                            index = 1;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 15267, 15475) || true) && (_capacity != DefaultHistorySize)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 15267, 15475);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 15360, 15448) || true) && (_countEntriesAdded > _capacity)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 15360, 15448);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 15429, 15448);

                                    index = SmallestID;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 15360, 15448);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 15267, 15475);
                            }
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 15513, 15526);

                                for (long
        i = count - 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 15503, 16180) || true) && (i >= 0)
        ; DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 15503, 16180))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 15503, 16180);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 15593, 15631) || true) && (index > _countEntriesAdded)
                                    )
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 15593, 15631);
                                        DynAbs.Tracing.TraceSender.TraceBreak(1460, 15625, 15631);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 15593, 15631);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 15661, 16153) || true) && ((index <= 0 || (DynAbs.Tracing.TraceSender.Expression_False(1460, 15666, 15719) || f_1460_15680_15701(this, index) >= f_1460_15705_15719(_buffer))) || (DynAbs.Tracing.TraceSender.Expression_False(1460, 15665, 15805) || (f_1460_15758_15796(_buffer[f_1460_15766_15787(this, index)]) == true)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 15661, 16153);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 15871, 15879);

                                        index++;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 15880, 15889);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 15661, 16153);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 15661, 16153);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 16019, 16075);

                                        f_1460_16019_16074(entriesList, f_1460_16035_16073(_buffer[f_1460_16043_16064(this, index)]));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 16109, 16113);

                                        i--;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 16114, 16122);

                                        index++;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 15661, 16153);
                                    }
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1460, 1, 678);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1460, 1, 678);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 15107, 17510);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 15107, 17510);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 16278, 16305);

                            index = _countEntriesAdded;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 16363, 16376);

                                for (long
        i = count - 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 16353, 17487) || true) && (i >= 0)
        ; DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 16353, 17487))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 16353, 17487);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 16525, 16871) || true) && (_capacity != DefaultHistorySize)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 16525, 16871);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 16626, 16840) || true) && (_countEntriesAdded > _capacity)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 16626, 16840);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 16734, 16805) || true) && (index < SmallestID)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 16734, 16805);
                                                DynAbs.Tracing.TraceSender.TraceBreak(1460, 16799, 16805);

                                                break;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 16734, 16805);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 16626, 16840);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 16525, 16871);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 16903, 16924) || true) && (index < 1)
                                    )
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 16903, 16924);
                                        DynAbs.Tracing.TraceSender.TraceBreak(1460, 16918, 16924);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 16903, 16924);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 16954, 17460) || true) && ((index <= 0 || (DynAbs.Tracing.TraceSender.Expression_False(1460, 16959, 17012) || f_1460_16973_16994(this, index) >= f_1460_16998_17012(_buffer))) || (DynAbs.Tracing.TraceSender.Expression_False(1460, 16958, 17098) || (f_1460_17051_17089(_buffer[f_1460_17059_17080(this, index)]) == true)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 16954, 17460);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 17131, 17139);

                                        index--;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 17140, 17149);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 16954, 17460);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 16954, 17460);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 17326, 17382);

                                        f_1460_17326_17381(                                // clone the entry from the history buffer
                                                                        entriesList, f_1460_17342_17380(_buffer[f_1460_17350_17371(this, index)]));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 17416, 17420);

                                        i--;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 17421, 17429);

                                        index--;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 16954, 17460);
                                    }
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1460, 1, 1135);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1460, 1, 1135);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 15107, 17510);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 10701, 17529);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 17549, 17608);

                    HistoryInfo[]
                    entries = new HistoryInfo[f_1460_17589_17606(entriesList)]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 17626, 17654);

                    f_1460_17626_17653(entriesList, entries);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 17672, 17687);

                    return entries;
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1460, 9682, 17713);

                int
                f_1460_9785_9811(Microsoft.PowerShell.Commands.History
                this_param)
                {
                    this_param.ReallocateBufferIfNeeded();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 9785, 9811);
                    return 0;
                }


                System.Management.Automation.PSArgumentOutOfRangeException
                f_1460_9882_9942(string
                paramName, long
                actualValue)
                {
                    var return_v = PSTraceSource.NewArgumentOutOfRangeException(paramName, (object)actualValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 9882, 9942);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1460_10043_10091(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 10043, 10091);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.HistoryInfo[]
                f_1460_10351_10377()
                {
                    var return_v = Array.Empty<HistoryInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 10351, 10377);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.HistoryInfo>
                f_1460_10659_10682()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.HistoryInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 10659, 10682);
                    return return_v;
                }


                bool
                f_1460_10887_10904_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 10887, 10904);
                    return return_v;
                }


                int
                f_1460_11669_11686(Microsoft.PowerShell.Commands.History
                this_param, long
                id)
                {
                    var return_v = this_param.GetIndexFromId(id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 11669, 11686);
                    return return_v;
                }


                int
                f_1460_11748_11765(Microsoft.PowerShell.Commands.History
                this_param, long
                id)
                {
                    var return_v = this_param.GetIndexFromId(id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 11748, 11765);
                    return return_v;
                }


                bool
                f_1460_11740_11774(Microsoft.PowerShell.Commands.HistoryInfo
                this_param)
                {
                    var return_v = this_param.Cleared;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 11740, 11774);
                    return return_v;
                }


                int
                f_1460_12476_12493(Microsoft.PowerShell.Commands.History
                this_param, long
                id)
                {
                    var return_v = this_param.GetIndexFromId(id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 12476, 12493);
                    return return_v;
                }


                int
                f_1460_12514_12531(Microsoft.PowerShell.Commands.History
                this_param, long
                id)
                {
                    var return_v = this_param.GetIndexFromId(id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 12514, 12531);
                    return return_v;
                }


                bool
                f_1460_12506_12540(Microsoft.PowerShell.Commands.HistoryInfo
                this_param)
                {
                    var return_v = this_param.Cleared;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 12506, 12540);
                    return return_v;
                }


                int
                f_1460_12646_12663(Microsoft.PowerShell.Commands.History
                this_param, long
                id)
                {
                    var return_v = this_param.GetIndexFromId(id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 12646, 12663);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.HistoryInfo
                f_1460_12638_12672(Microsoft.PowerShell.Commands.HistoryInfo
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 12638, 12672);
                    return return_v;
                }


                int
                f_1460_12622_12673(System.Collections.Generic.List<Microsoft.PowerShell.Commands.HistoryInfo>
                this_param, Microsoft.PowerShell.Commands.HistoryInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 12622, 12673);
                    return 0;
                }


                int
                f_1460_13552_13569(Microsoft.PowerShell.Commands.History
                this_param, long
                id)
                {
                    var return_v = this_param.GetIndexFromId(id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 13552, 13569);
                    return return_v;
                }


                int
                f_1460_13631_13648(Microsoft.PowerShell.Commands.History
                this_param, long
                id)
                {
                    var return_v = this_param.GetIndexFromId(id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 13631, 13648);
                    return return_v;
                }


                bool
                f_1460_13623_13657(Microsoft.PowerShell.Commands.HistoryInfo
                this_param)
                {
                    var return_v = this_param.Cleared;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 13623, 13657);
                    return return_v;
                }


                int
                f_1460_14260_14277(Microsoft.PowerShell.Commands.History
                this_param, long
                id)
                {
                    var return_v = this_param.GetIndexFromId(id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 14260, 14277);
                    return return_v;
                }


                int
                f_1460_14298_14315(Microsoft.PowerShell.Commands.History
                this_param, long
                id)
                {
                    var return_v = this_param.GetIndexFromId(id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 14298, 14315);
                    return return_v;
                }


                bool
                f_1460_14290_14324(Microsoft.PowerShell.Commands.HistoryInfo
                this_param)
                {
                    var return_v = this_param.Cleared;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 14290, 14324);
                    return return_v;
                }


                int
                f_1460_14430_14447(Microsoft.PowerShell.Commands.History
                this_param, long
                id)
                {
                    var return_v = this_param.GetIndexFromId(id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 14430, 14447);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.HistoryInfo
                f_1460_14422_14456(Microsoft.PowerShell.Commands.HistoryInfo
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 14422, 14456);
                    return return_v;
                }


                int
                f_1460_14406_14457(System.Collections.Generic.List<Microsoft.PowerShell.Commands.HistoryInfo>
                this_param, Microsoft.PowerShell.Commands.HistoryInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 14406, 14457);
                    return 0;
                }


                long
                f_1460_15064_15084(Microsoft.PowerShell.Commands.History
                this_param)
                {
                    var return_v = this_param.SmallestIDinBuffer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 15064, 15084);
                    return return_v;
                }


                bool
                f_1460_15111_15128_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 15111, 15128);
                    return return_v;
                }


                int
                f_1460_15680_15701(Microsoft.PowerShell.Commands.History
                this_param, long
                id)
                {
                    var return_v = this_param.GetIndexFromId(id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 15680, 15701);
                    return return_v;
                }


                int
                f_1460_15705_15719(Microsoft.PowerShell.Commands.HistoryInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 15705, 15719);
                    return return_v;
                }


                int
                f_1460_15766_15787(Microsoft.PowerShell.Commands.History
                this_param, long
                id)
                {
                    var return_v = this_param.GetIndexFromId(id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 15766, 15787);
                    return return_v;
                }


                bool
                f_1460_15758_15796(Microsoft.PowerShell.Commands.HistoryInfo
                this_param)
                {
                    var return_v = this_param.Cleared;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 15758, 15796);
                    return return_v;
                }


                int
                f_1460_16043_16064(Microsoft.PowerShell.Commands.History
                this_param, long
                id)
                {
                    var return_v = this_param.GetIndexFromId(id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 16043, 16064);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.HistoryInfo
                f_1460_16035_16073(Microsoft.PowerShell.Commands.HistoryInfo
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 16035, 16073);
                    return return_v;
                }


                int
                f_1460_16019_16074(System.Collections.Generic.List<Microsoft.PowerShell.Commands.HistoryInfo>
                this_param, Microsoft.PowerShell.Commands.HistoryInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 16019, 16074);
                    return 0;
                }


                int
                f_1460_16973_16994(Microsoft.PowerShell.Commands.History
                this_param, long
                id)
                {
                    var return_v = this_param.GetIndexFromId(id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 16973, 16994);
                    return return_v;
                }


                int
                f_1460_16998_17012(Microsoft.PowerShell.Commands.HistoryInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 16998, 17012);
                    return return_v;
                }


                int
                f_1460_17059_17080(Microsoft.PowerShell.Commands.History
                this_param, long
                id)
                {
                    var return_v = this_param.GetIndexFromId(id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 17059, 17080);
                    return return_v;
                }


                bool
                f_1460_17051_17089(Microsoft.PowerShell.Commands.HistoryInfo
                this_param)
                {
                    var return_v = this_param.Cleared;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 17051, 17089);
                    return return_v;
                }


                int
                f_1460_17350_17371(Microsoft.PowerShell.Commands.History
                this_param, long
                id)
                {
                    var return_v = this_param.GetIndexFromId(id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 17350, 17371);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.HistoryInfo
                f_1460_17342_17380(Microsoft.PowerShell.Commands.HistoryInfo
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 17342, 17380);
                    return return_v;
                }


                int
                f_1460_17326_17381(System.Collections.Generic.List<Microsoft.PowerShell.Commands.HistoryInfo>
                this_param, Microsoft.PowerShell.Commands.HistoryInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 17326, 17381);
                    return 0;
                }


                int
                f_1460_17589_17606(System.Collections.Generic.List<Microsoft.PowerShell.Commands.HistoryInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 17589, 17606);
                    return return_v;
                }


                int
                f_1460_17626_17653(System.Collections.Generic.List<Microsoft.PowerShell.Commands.HistoryInfo>
                this_param, Microsoft.PowerShell.Commands.HistoryInfo[]
                array)
                {
                    this_param.CopyTo(array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 17626, 17653);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 9682, 17713);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 9682, 17713);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal HistoryInfo[] GetEntries(WildcardPattern wildcardpattern, long count, SwitchParameter newest)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1460, 18097, 21761);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 18230, 18239);
                lock (_syncRoot)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 18273, 18415) || true) && (count < -1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 18273, 18415);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 18329, 18396);

                        throw f_1460_18335_18395("count", count);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 18273, 18415);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 18435, 18580) || true) && (newest.ToString() == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 18435, 18580);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 18506, 18561);

                        throw f_1460_18512_18560("newest");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 18435, 18580);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 18600, 18736) || true) && (count > _countEntriesAdded || (DynAbs.Tracing.TraceSender.Expression_False(1460, 18604, 18645) || count == -1))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 18600, 18736);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 18687, 18717);

                        count = _countEntriesInBuffer;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 18600, 18736);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 18756, 18808);

                    List<HistoryInfo>
                    cmdlist = f_1460_18784_18807()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 18826, 18846);

                    long
                    SmallestID = 1
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 18965, 19057) || true) && (_capacity != DefaultHistorySize)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 18965, 19057);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 19023, 19057);

                        SmallestID = f_1460_19036_19056(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 18965, 19057);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 19075, 21585) || true) && (count != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 19075, 21585);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 19131, 21112) || true) && (f_1460_19135_19152_M(!newest.IsPresent))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 19131, 21112);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 19202, 19214);

                            long
                            id = 1
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 19240, 19445) || true) && (_capacity != DefaultHistorySize)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 19240, 19445);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 19333, 19418) || true) && (_countEntriesAdded > _capacity)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 19333, 19418);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 19402, 19418);

                                    id = SmallestID;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 19333, 19418);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 19240, 19445);
                            }
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 19483, 19488);

                                for (long
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 19473, 19966) || true) && (i <= count - 1)
        ; DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 19473, 19966))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 19473, 19966);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 19563, 19598) || true) && (id > _countEntriesAdded)
                                    )
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 19563, 19598);
                                        DynAbs.Tracing.TraceSender.TraceBreak(1460, 19592, 19598);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 19563, 19598);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 19628, 19902) || true) && (f_1460_19632_19667(_buffer[f_1460_19640_19658(this, id)]) == false && (DynAbs.Tracing.TraceSender.Expression_True(1460, 19632, 19751) && f_1460_19680_19751(wildcardpattern, f_1460_19704_19750(f_1460_19704_19743(_buffer[f_1460_19712_19730(this, id)])))))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 19628, 19902);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 19817, 19866);

                                        f_1460_19817_19865(cmdlist, f_1460_19829_19864(_buffer[f_1460_19837_19855(this, id)]));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 19867, 19871);

                                        i++;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 19628, 19902);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 19934, 19939);

                                    id++;
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1460, 1, 494);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1460, 1, 494);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 19131, 21112);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 19131, 21112);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 20064, 20093);

                            long
                            id = _countEntriesAdded
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 20129, 20134);
                                for (long
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 20119, 21089) || true) && (i <= count - 1)
        ; DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 20119, 21089))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 20119, 21089);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 20328, 20671) || true) && (_capacity != DefaultHistorySize)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 20328, 20671);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 20429, 20640) || true) && (_countEntriesAdded > _capacity)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 20429, 20640);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 20537, 20605) || true) && (id < SmallestID)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 20537, 20605);
                                                DynAbs.Tracing.TraceSender.TraceBreak(1460, 20599, 20605);

                                                break;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 20537, 20605);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 20429, 20640);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 20328, 20671);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 20703, 20721) || true) && (id < 1)
                                    )
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 20703, 20721);
                                        DynAbs.Tracing.TraceSender.TraceBreak(1460, 20715, 20721);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 20703, 20721);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 20751, 21025) || true) && (f_1460_20755_20790(_buffer[f_1460_20763_20781(this, id)]) == false && (DynAbs.Tracing.TraceSender.Expression_True(1460, 20755, 20874) && f_1460_20803_20874(wildcardpattern, f_1460_20827_20873(f_1460_20827_20866(_buffer[f_1460_20835_20853(this, id)])))))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 20751, 21025);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 20940, 20989);

                                        f_1460_20940_20988(cmdlist, f_1460_20952_20987(_buffer[f_1460_20960_20978(this, id)]));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 20990, 20994);

                                        i++;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 20751, 21025);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 21057, 21062);

                                    id--;
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1460, 1, 971);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1460, 1, 971);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 19131, 21112);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 19075, 21585);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 19075, 21585);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 21204, 21209);
                            for (long
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 21194, 21566) || true) && (i <= _countEntriesAdded)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 21236, 21239)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 21194, 21566))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 21194, 21566);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 21289, 21543) || true) && (f_1460_21293_21327(_buffer[f_1460_21301_21318(this, i)]) == false && (DynAbs.Tracing.TraceSender.Expression_True(1460, 21293, 21410) && f_1460_21340_21410(wildcardpattern, f_1460_21364_21409(f_1460_21364_21402(_buffer[f_1460_21372_21389(this, i)])))))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 21289, 21543);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 21468, 21516);

                                    f_1460_21468_21515(cmdlist, f_1460_21480_21514(_buffer[f_1460_21488_21505(this, i)]));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 21289, 21543);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1460, 1, 373);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1460, 1, 373);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 19075, 21585);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 21605, 21660);

                    HistoryInfo[]
                    entries = new HistoryInfo[f_1460_21645_21658(cmdlist)]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 21678, 21702);

                    f_1460_21678_21701(cmdlist, entries);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 21720, 21735);

                    return entries;
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1460, 18097, 21761);

                System.Management.Automation.PSArgumentOutOfRangeException
                f_1460_18335_18395(string
                paramName, long
                actualValue)
                {
                    var return_v = PSTraceSource.NewArgumentOutOfRangeException(paramName, (object)actualValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 18335, 18395);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1460_18512_18560(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 18512, 18560);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.HistoryInfo>
                f_1460_18784_18807()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.HistoryInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 18784, 18807);
                    return return_v;
                }


                long
                f_1460_19036_19056(Microsoft.PowerShell.Commands.History
                this_param)
                {
                    var return_v = this_param.SmallestIDinBuffer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 19036, 19056);
                    return return_v;
                }


                bool
                f_1460_19135_19152_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 19135, 19152);
                    return return_v;
                }


                int
                f_1460_19640_19658(Microsoft.PowerShell.Commands.History
                this_param, long
                id)
                {
                    var return_v = this_param.GetIndexFromId(id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 19640, 19658);
                    return return_v;
                }


                bool
                f_1460_19632_19667(Microsoft.PowerShell.Commands.HistoryInfo
                this_param)
                {
                    var return_v = this_param.Cleared;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 19632, 19667);
                    return return_v;
                }


                int
                f_1460_19712_19730(Microsoft.PowerShell.Commands.History
                this_param, long
                id)
                {
                    var return_v = this_param.GetIndexFromId(id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 19712, 19730);
                    return return_v;
                }


                string
                f_1460_19704_19743(Microsoft.PowerShell.Commands.HistoryInfo
                this_param)
                {
                    var return_v = this_param.CommandLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 19704, 19743);
                    return return_v;
                }


                string
                f_1460_19704_19750(string
                this_param)
                {
                    var return_v = this_param.Trim();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 19704, 19750);
                    return return_v;
                }


                bool
                f_1460_19680_19751(System.Management.Automation.WildcardPattern
                this_param, string
                input)
                {
                    var return_v = this_param.IsMatch(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 19680, 19751);
                    return return_v;
                }


                int
                f_1460_19837_19855(Microsoft.PowerShell.Commands.History
                this_param, long
                id)
                {
                    var return_v = this_param.GetIndexFromId(id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 19837, 19855);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.HistoryInfo
                f_1460_19829_19864(Microsoft.PowerShell.Commands.HistoryInfo
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 19829, 19864);
                    return return_v;
                }


                int
                f_1460_19817_19865(System.Collections.Generic.List<Microsoft.PowerShell.Commands.HistoryInfo>
                this_param, Microsoft.PowerShell.Commands.HistoryInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 19817, 19865);
                    return 0;
                }


                int
                f_1460_20763_20781(Microsoft.PowerShell.Commands.History
                this_param, long
                id)
                {
                    var return_v = this_param.GetIndexFromId(id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 20763, 20781);
                    return return_v;
                }


                bool
                f_1460_20755_20790(Microsoft.PowerShell.Commands.HistoryInfo
                this_param)
                {
                    var return_v = this_param.Cleared;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 20755, 20790);
                    return return_v;
                }


                int
                f_1460_20835_20853(Microsoft.PowerShell.Commands.History
                this_param, long
                id)
                {
                    var return_v = this_param.GetIndexFromId(id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 20835, 20853);
                    return return_v;
                }


                string
                f_1460_20827_20866(Microsoft.PowerShell.Commands.HistoryInfo
                this_param)
                {
                    var return_v = this_param.CommandLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 20827, 20866);
                    return return_v;
                }


                string
                f_1460_20827_20873(string
                this_param)
                {
                    var return_v = this_param.Trim();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 20827, 20873);
                    return return_v;
                }


                bool
                f_1460_20803_20874(System.Management.Automation.WildcardPattern
                this_param, string
                input)
                {
                    var return_v = this_param.IsMatch(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 20803, 20874);
                    return return_v;
                }


                int
                f_1460_20960_20978(Microsoft.PowerShell.Commands.History
                this_param, long
                id)
                {
                    var return_v = this_param.GetIndexFromId(id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 20960, 20978);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.HistoryInfo
                f_1460_20952_20987(Microsoft.PowerShell.Commands.HistoryInfo
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 20952, 20987);
                    return return_v;
                }


                int
                f_1460_20940_20988(System.Collections.Generic.List<Microsoft.PowerShell.Commands.HistoryInfo>
                this_param, Microsoft.PowerShell.Commands.HistoryInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 20940, 20988);
                    return 0;
                }


                int
                f_1460_21301_21318(Microsoft.PowerShell.Commands.History
                this_param, long
                id)
                {
                    var return_v = this_param.GetIndexFromId(id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 21301, 21318);
                    return return_v;
                }


                bool
                f_1460_21293_21327(Microsoft.PowerShell.Commands.HistoryInfo
                this_param)
                {
                    var return_v = this_param.Cleared;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 21293, 21327);
                    return return_v;
                }


                int
                f_1460_21372_21389(Microsoft.PowerShell.Commands.History
                this_param, long
                id)
                {
                    var return_v = this_param.GetIndexFromId(id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 21372, 21389);
                    return return_v;
                }


                string
                f_1460_21364_21402(Microsoft.PowerShell.Commands.HistoryInfo
                this_param)
                {
                    var return_v = this_param.CommandLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 21364, 21402);
                    return return_v;
                }


                string
                f_1460_21364_21409(string
                this_param)
                {
                    var return_v = this_param.Trim();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 21364, 21409);
                    return return_v;
                }


                bool
                f_1460_21340_21410(System.Management.Automation.WildcardPattern
                this_param, string
                input)
                {
                    var return_v = this_param.IsMatch(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 21340, 21410);
                    return return_v;
                }


                int
                f_1460_21488_21505(Microsoft.PowerShell.Commands.History
                this_param, long
                id)
                {
                    var return_v = this_param.GetIndexFromId(id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 21488, 21505);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.HistoryInfo
                f_1460_21480_21514(Microsoft.PowerShell.Commands.HistoryInfo
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 21480, 21514);
                    return return_v;
                }


                int
                f_1460_21468_21515(System.Collections.Generic.List<Microsoft.PowerShell.Commands.HistoryInfo>
                this_param, Microsoft.PowerShell.Commands.HistoryInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 21468, 21515);
                    return 0;
                }


                int
                f_1460_21645_21658(System.Collections.Generic.List<Microsoft.PowerShell.Commands.HistoryInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 21645, 21658);
                    return return_v;
                }


                int
                f_1460_21678_21701(System.Collections.Generic.List<Microsoft.PowerShell.Commands.HistoryInfo>
                this_param, Microsoft.PowerShell.Commands.HistoryInfo[]
                array)
                {
                    this_param.CopyTo(array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 21678, 21701);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 18097, 21761);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 18097, 21761);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void ClearEntry(long id)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1460, 21996, 22814);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 22060, 22069);
                lock (_syncRoot)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 22103, 22235) || true) && (id < 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 22103, 22235);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 22155, 22216);

                        throw f_1460_22161_22215("id", id);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 22103, 22235);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 22305, 22365) || true) && (_countEntriesInBuffer == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 22305, 22365);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 22358, 22365);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 22305, 22365);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 22446, 22541) || true) && (id > _countEntriesAdded)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 22446, 22541);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 22515, 22522);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 22446, 22541);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 22561, 22598);

                    HistoryInfo
                    entry = f_1460_22581_22597(this, id)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 22616, 22761) || true) && (entry != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 22616, 22761);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 22675, 22696);

                        entry.Cleared = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 22718, 22742);

                        _countEntriesInBuffer--;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 22616, 22761);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 22781, 22788);

                    return;
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1460, 21996, 22814);

                System.Management.Automation.PSArgumentOutOfRangeException
                f_1460_22161_22215(string
                paramName, long
                actualValue)
                {
                    var return_v = PSTraceSource.NewArgumentOutOfRangeException(paramName, (object)actualValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 22161, 22215);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.HistoryInfo
                f_1460_22581_22597(Microsoft.PowerShell.Commands.History
                this_param, long
                id)
                {
                    var return_v = this_param.CoreGetEntry(id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 22581, 22597);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 21996, 22814);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 21996, 22814);
            }
        }

        internal int Buffercapacity()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1460, 22986, 23068);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 23040, 23057);

                return _capacity;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1460, 22986, 23068);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 22986, 23068);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 22986, 23068);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private long Add(HistoryInfo entry)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1460, 23564, 24183);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 23624, 23744) || true) && (entry == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 23624, 23744);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 23675, 23729);

                    throw f_1460_23681_23728("entry");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 23624, 23744);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 23760, 23799);

                _buffer[f_1460_23768_23789(this)] = entry;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 23871, 23892);

                _countEntriesAdded++;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 23990, 24022);

                f_1460_23990_24021(
                            // Id of an entry in history is same as its number in history store.
                            entry, _countEntriesAdded);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 24096, 24130);

                f_1460_24096_24129(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 24146, 24172);

                return _countEntriesAdded;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1460, 23564, 24183);

                System.Management.Automation.PSArgumentNullException
                f_1460_23681_23728(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 23681, 23728);
                    return return_v;
                }


                int
                f_1460_23768_23789(Microsoft.PowerShell.Commands.History
                this_param)
                {
                    var return_v = this_param.GetIndexForNewEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 23768, 23789);
                    return return_v;
                }


                int
                f_1460_23990_24021(Microsoft.PowerShell.Commands.HistoryInfo
                this_param, long
                id)
                {
                    this_param.SetId(id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 23990, 24021);
                    return 0;
                }


                int
                f_1460_24096_24129(Microsoft.PowerShell.Commands.History
                this_param)
                {
                    this_param.IncrementCountOfEntriesInBuffer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 24096, 24129);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 23564, 24183);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 23564, 24183);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private HistoryInfo CoreGetEntry(long id)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1460, 24522, 25068);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 24588, 24709) || true) && (id <= 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 24588, 24709);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 24633, 24694);

                    throw f_1460_24639_24693("id", id);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 24588, 24709);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 24725, 24786) || true) && (_countEntriesInBuffer == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 24725, 24786);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 24774, 24786);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 24725, 24786);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 24800, 24888) || true) && (id > _countEntriesAdded)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 24800, 24888);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 24861, 24873);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 24800, 24888);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 24969, 25004);

                return _buffer[f_1460_24984_25002(this, id)];
                DynAbs.Tracing.TraceSender.TraceExitMethod(1460, 24522, 25068);

                System.Management.Automation.PSArgumentOutOfRangeException
                f_1460_24639_24693(string
                paramName, long
                actualValue)
                {
                    var return_v = PSTraceSource.NewArgumentOutOfRangeException(paramName, (object)actualValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 24639, 24693);
                    return return_v;
                }


                int
                f_1460_24984_25002(Microsoft.PowerShell.Commands.History
                this_param, long
                id)
                {
                    var return_v = this_param.GetIndexFromId(id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 24984, 25002);
                    return return_v;
                }

                // else
                //    return null;
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 24522, 25068);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 24522, 25068);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private long SmallestIDinBuffer()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1460, 25209, 26031);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 25267, 25282);

                long
                minID = 0
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 25296, 25347) || true) && (_buffer == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 25296, 25347);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 25334, 25347);

                    return minID;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 25296, 25347);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 25370, 25375);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 25361, 25678) || true) && (i < f_1460_25381_25395(_buffer))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 25397, 25400)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 25361, 25678))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 25361, 25678);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 25499, 25663) || true) && (_buffer[i] != null && (DynAbs.Tracing.TraceSender.Expression_True(1460, 25503, 25552) && f_1460_25525_25543(_buffer[i]) == false))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 25499, 25663);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 25594, 25616);

                            minID = f_1460_25602_25615(_buffer[i]);
                            DynAbs.Tracing.TraceSender.TraceBreak(1460, 25638, 25644);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 25499, 25663);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1460, 1, 318);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1460, 1, 318);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 25762, 25767);
                    // check for the minimum id that is not cleared
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 25753, 25991) || true) && (i < f_1460_25773_25787(_buffer))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 25789, 25792)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 25753, 25991))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 25753, 25991);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 25826, 25976) || true) && (_buffer[i] != null && (DynAbs.Tracing.TraceSender.Expression_True(1460, 25830, 25879) && f_1460_25852_25870(_buffer[i]) == false))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 25826, 25976);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 25902, 25976) || true) && (minID > f_1460_25914_25927(_buffer[i]))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 25902, 25976);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 25954, 25976);

                                minID = f_1460_25962_25975(_buffer[i]);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 25902, 25976);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 25826, 25976);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1460, 1, 239);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1460, 1, 239);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 26007, 26020);

                return minID;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1460, 25209, 26031);

                int
                f_1460_25381_25395(Microsoft.PowerShell.Commands.HistoryInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 25381, 25395);
                    return return_v;
                }


                bool
                f_1460_25525_25543(Microsoft.PowerShell.Commands.HistoryInfo
                this_param)
                {
                    var return_v = this_param.Cleared;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 25525, 25543);
                    return return_v;
                }


                long
                f_1460_25602_25615(Microsoft.PowerShell.Commands.HistoryInfo
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 25602, 25615);
                    return return_v;
                }


                int
                f_1460_25773_25787(Microsoft.PowerShell.Commands.HistoryInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 25773, 25787);
                    return return_v;
                }


                bool
                f_1460_25852_25870(Microsoft.PowerShell.Commands.HistoryInfo
                this_param)
                {
                    var return_v = this_param.Cleared;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 25852, 25870);
                    return return_v;
                }


                long
                f_1460_25914_25927(Microsoft.PowerShell.Commands.HistoryInfo
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 25914, 25927);
                    return return_v;
                }


                long
                f_1460_25962_25975(Microsoft.PowerShell.Commands.HistoryInfo
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 25962, 25975);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 25209, 26031);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 25209, 26031);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ReallocateBufferIfNeeded()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1460, 26151, 27282);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 26272, 26307);

                int
                historySize = f_1460_26290_26306(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 26323, 26377) || true) && (historySize == _capacity)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 26323, 26377);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 26370, 26377);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 26323, 26377);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 26393, 26449);

                HistoryInfo[]
                tempBuffer = new HistoryInfo[historySize]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 26532, 26576);

                int
                numberOfEntries = _countEntriesInBuffer
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 26689, 26790) || true) && (numberOfEntries < _countEntriesAdded)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 26689, 26790);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 26748, 26790);

                    numberOfEntries = (int)_countEntriesAdded;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 26689, 26790);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 26806, 26894) || true) && (_countEntriesInBuffer > historySize)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 26806, 26894);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 26864, 26894);

                    numberOfEntries = historySize;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 26806, 26894);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 26919, 26938);

                    for (int
        i = numberOfEntries
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 26910, 27142) || true) && (i > 0)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 26947, 26950)
        , --i, DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 26910, 27142))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 26910, 27142);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 26984, 27025);

                        long
                        nextId = _countEntriesAdded - i + 1
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 27045, 27127);

                        tempBuffer[f_1460_27056_27091(nextId, historySize)] = _buffer[f_1460_27103_27125(this, nextId)];
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1460, 1, 233);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1460, 1, 233);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 27158, 27198);

                _countEntriesInBuffer = numberOfEntries;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 27212, 27236);

                _capacity = historySize;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 27250, 27271);

                _buffer = tempBuffer;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1460, 26151, 27282);

                int
                f_1460_26290_26306(Microsoft.PowerShell.Commands.History
                this_param)
                {
                    var return_v = this_param.GetHistorySize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 26290, 26306);
                    return return_v;
                }


                int
                f_1460_27056_27091(long
                id, int
                capacity)
                {
                    var return_v = GetIndexFromId(id, capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 27056, 27091);
                    return return_v;
                }


                int
                f_1460_27103_27125(Microsoft.PowerShell.Commands.History
                this_param, long
                id)
                {
                    var return_v = this_param.GetIndexFromId(id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 27103, 27125);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 26151, 27282);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 26151, 27282);
            }
        }

        private int GetIndexForNewEntry()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1460, 27436, 27550);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 27494, 27539);

                return (int)(_countEntriesAdded % _capacity);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1460, 27436, 27550);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 27436, 27550);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 27436, 27550);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private int GetIndexFromId(long id)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1460, 27704, 27810);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 27764, 27799);

                return (int)((id - 1) % _capacity);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1460, 27704, 27810);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 27704, 27810);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 27704, 27810);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int GetIndexFromId(long id, int capacity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1460, 28086, 28212);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 28167, 28201);

                return (int)((id - 1) % capacity);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1460, 28086, 28212);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 28086, 28212);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 28086, 28212);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void IncrementCountOfEntriesInBuffer()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1460, 28328, 28490);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 28399, 28479) || true) && (_countEntriesInBuffer < _capacity)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 28399, 28479);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 28455, 28479);

                    _countEntriesInBuffer++;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 28399, 28479);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1460, 28328, 28490);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 28328, 28490);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 28328, 28490);
            }
        }

        private int GetHistorySize()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1460, 28625, 29401);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 28678, 28698);

                int
                historySize = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 28712, 28778);

                var
                executionContext = f_1460_28735_28777()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 28792, 28912);

                object
                obj = (DynAbs.Tracing.TraceSender.Conditional_F1(1460, 28805, 28831) || (((executionContext != null) && DynAbs.Tracing.TraceSender.Conditional_F2(1460, 28834, 28904)) || DynAbs.Tracing.TraceSender.Conditional_F3(1460, 28907, 28911))) ? f_1460_28834_28904(executionContext, SpecialVariables.HistorySizeVarPath) : null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 28926, 29237) || true) && (obj != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 28926, 29237);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 29019, 29136);

                        historySize = (int)f_1460_29038_29135(obj, typeof(int), f_1460_29085_29134());
                    }
                    catch (InvalidCastException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1460, 29173, 29222);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1460, 29173, 29222);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 28926, 29237);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 29253, 29355) || true) && (historySize <= 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 29253, 29355);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 29307, 29340);

                    historySize = DefaultHistorySize;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 29253, 29355);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 29371, 29390);

                return historySize;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1460, 28625, 29401);

                System.Management.Automation.ExecutionContext
                f_1460_28735_28777()
                {
                    var return_v = LocalPipeline.GetExecutionContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 28735, 28777);
                    return return_v;
                }


                object
                f_1460_28834_28904(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.VariablePath
                path)
                {
                    var return_v = this_param.GetVariableValue(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 28834, 28904);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1460_29085_29134()
                {
                    var return_v = System.Globalization.CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 29085, 29134);
                    return return_v;
                }


                object
                f_1460_29038_29135(object
                valueToConvert, System.Type
                resultType, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = LanguagePrimitives.ConvertTo(valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 29038, 29135);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 28625, 29401);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 28625, 29401);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private HistoryInfo[] _buffer;

        private int _capacity;

        private int _countEntriesInBuffer;

        private long _countEntriesAdded;

        private object _syncRoot;

        internal long GetNextHistoryId()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1460, 30358, 30456);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 30415, 30445);

                return _countEntriesAdded + 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1460, 30358, 30456);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 30358, 30456);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 30358, 30456);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static History()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1460, 5116, 30463);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 5256, 5281);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1460, 5116, 30463);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 5116, 30463);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1460, 5116, 30463);

        System.Collections.ObjectModel.Collection<System.Attribute>
        f_1460_5623_5650()
        {
            var return_v = new System.Collections.ObjectModel.Collection<System.Attribute>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 5623, 5650);
            return return_v;
        }


        System.Management.Automation.ValidateRangeAttribute
        f_1460_5675_5725(int
        minRange, int
        maxRange)
        {
            var return_v = new System.Management.Automation.ValidateRangeAttribute((object)minRange, (object)maxRange);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 5675, 5725);
            return return_v;
        }


        int
        f_1460_5665_5726(System.Collections.ObjectModel.Collection<System.Attribute>
        this_param, System.Management.Automation.ValidateRangeAttribute
        item)
        {
            this_param.Add((System.Attribute)item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 5665, 5726);
            return 0;
        }


        System.Management.Automation.PSVariable
        f_1460_5769_5864(string
        name, int
        value, System.Management.Automation.ScopedItemOptions
        options, System.Collections.ObjectModel.Collection<System.Attribute>
        attributes)
        {
            var return_v = new System.Management.Automation.PSVariable(name, (object)value, options, attributes);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 5769, 5864);
            return return_v;
        }


        string
        f_1460_5908_5954()
        {
            var return_v = SessionStateStrings.MaxHistoryCountDescription;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 5908, 5954);
            return return_v;
        }


        System.Management.Automation.SessionStateInternal
        f_1460_5971_5997(System.Management.Automation.ExecutionContext
        this_param)
        {
            var return_v = this_param.EngineSessionState;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 5971, 5997);
            return return_v;
        }


        object
        f_1460_5971_6056(System.Management.Automation.SessionStateInternal
        this_param, System.Management.Automation.PSVariable
        variable, bool
        force, System.Management.Automation.CommandOrigin
        origin)
        {
            var return_v = this_param.SetVariable(variable, force, origin);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 5971, 6056);
            return return_v;
        }


        object
        f_1460_30191_30203()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 30191, 30203);
            return return_v;
        }

    }
    [Cmdlet(VerbsCommon.Get, "History", HelpUri = "https://go.microsoft.com/fwlink/?LinkID=2096788")]
    [OutputType(typeof(HistoryInfo))]
    public class GetHistoryCommand : PSCmdlet
    {
        private long[] _id;

        [Parameter(Position = 0, ValueFromPipeline = true)]
        [ValidateRangeAttribute((long)1, long.MaxValue)]
        public long[] Id
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1460, 31160, 31222);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 31196, 31207);

                    return _id;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1460, 31160, 31222);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 31000, 31312);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 31000, 31312);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1460, 31238, 31301);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 31274, 31286);

                    _id = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1460, 31238, 31301);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 31000, 31312);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 31000, 31312);
                }
            }
        }

        private bool _countParameterSpecified;

        private int _count;

        [Parameter(Position = 1)]
        [ValidateRangeAttribute(0, (int)Int16.MaxValue)]
        public int Count
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1460, 31959, 32024);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 31995, 32009);

                    return _count;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1460, 31959, 32024);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 31825, 32167);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 31825, 32167);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1460, 32040, 32156);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 32076, 32108);

                    _countParameterSpecified = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 32126, 32141);

                    _count = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1460, 32040, 32156);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 31825, 32167);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 31825, 32167);
                }
            }
        }

        protected override void ProcessRecord()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1460, 32300, 35327);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 32364, 32431);

                History
                history = f_1460_32382_32430(((LocalRunspace)f_1460_32398_32421(f_1460_32398_32405())))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 32447, 35316) || true) && (_id != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 32447, 35316);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 32496, 34837) || true) && (!_countParameterSpecified)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 32496, 34837);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 32684, 33864);
                            foreach (long id in f_1460_32704_32707_I(_id))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 32684, 33864);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 32757, 32824);

                                f_1460_32757_32823(id > 0, "ValidateRangeAttribute should not allow this");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 32852, 32893);

                                HistoryInfo
                                entry = f_1460_32872_32892(history, id)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 32921, 33841) || true) && (entry != null && (DynAbs.Tracing.TraceSender.Expression_True(1460, 32925, 32956) && f_1460_32942_32950(entry) == id))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 32921, 33841);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 33014, 33033);

                                    f_1460_33014_33032(this, entry);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 32921, 33841);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 32921, 33841);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 33147, 33377);

                                    Exception
                                    ex =
                                    f_1460_33195_33376(f_1460_33289_33341(f_1460_33307_33336(), id))
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 33409, 33814);

                                    f_1460_33409_33813(this, f_1460_33484_33782(ex, "GetHistoryNoHistoryForId", ErrorCategory.ObjectNotFound, id));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 32921, 33841);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 32684, 33864);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1460, 1, 1181);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1460, 1, 1181);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 32496, 34837);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 32496, 34837);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 33906, 34837) || true) && (f_1460_33910_33920(_id) > 1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 33906, 34837);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 33966, 34168);

                            Exception
                            ex =
                            f_1460_34006_34167(f_1460_34084_34140(f_1460_34102_34139()))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 34192, 34549);

                            f_1460_34192_34548(this, f_1460_34262_34525(ex, "GetHistoryNoCountWithMultipleIds", ErrorCategory.InvalidArgument, _count));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 33906, 34837);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 33906, 34837);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 34631, 34648);

                            long
                            id = _id[0]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 34672, 34739);

                            f_1460_34672_34738(id > 0, "ValidateRangeAttribute should not allow this");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 34761, 34818);

                            f_1460_34761_34817(this, f_1460_34773_34810(history, id, _count, false), true);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 33906, 34837);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 32496, 34837);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 32447, 35316);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 32447, 35316);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 34987, 35111) || true) && (!_countParameterSpecified)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 34987, 35111);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 35058, 35092);

                        _count = f_1460_35067_35091(history);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 34987, 35111);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 35131, 35191);

                    HistoryInfo[]
                    entries = f_1460_35155_35190(history, 0, _count, true)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 35219, 35241);
                        for (long
        i = f_1460_35223_35237(entries) - 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 35209, 35301) || true) && (i >= 0)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 35251, 35254)
        , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 35209, 35301))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 35209, 35301);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 35277, 35301);

                            f_1460_35277_35300(this, entries[i]);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1460, 1, 93);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1460, 1, 93);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 32447, 35316);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1460, 32300, 35327);

                System.Management.Automation.ExecutionContext
                f_1460_32398_32405()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 32398, 32405);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1460_32398_32421(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 32398, 32421);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.History
                f_1460_32382_32430(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.History;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 32382, 32430);
                    return return_v;
                }


                int
                f_1460_32757_32823(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 32757, 32823);
                    return 0;
                }


                Microsoft.PowerShell.Commands.HistoryInfo
                f_1460_32872_32892(Microsoft.PowerShell.Commands.History
                this_param, long
                id)
                {
                    var return_v = this_param.GetEntry(id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 32872, 32892);
                    return return_v;
                }


                long
                f_1460_32942_32950(Microsoft.PowerShell.Commands.HistoryInfo
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 32942, 32950);
                    return return_v;
                }


                int
                f_1460_33014_33032(Microsoft.PowerShell.Commands.GetHistoryCommand
                this_param, Microsoft.PowerShell.Commands.HistoryInfo
                sendToPipeline)
                {
                    this_param.WriteObject((object)sendToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 33014, 33032);
                    return 0;
                }


                string
                f_1460_33307_33336()
                {
                    var return_v = HistoryStrings.NoHistoryForId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 33307, 33336);
                    return return_v;
                }


                string
                f_1460_33289_33341(string
                formatSpec, long
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 33289, 33341);
                    return return_v;
                }


                System.ArgumentException
                f_1460_33195_33376(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 33195, 33376);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1460_33484_33782(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, long
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 33484, 33782);
                    return return_v;
                }


                int
                f_1460_33409_33813(Microsoft.PowerShell.Commands.GetHistoryCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 33409, 33813);
                    return 0;
                }


                long[]
                f_1460_32704_32707_I(long[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 32704, 32707);
                    return return_v;
                }


                int
                f_1460_33910_33920(long[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 33910, 33920);
                    return return_v;
                }


                string
                f_1460_34102_34139()
                {
                    var return_v = HistoryStrings.NoCountWithMultipleIds;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 34102, 34139);
                    return return_v;
                }


                string
                f_1460_34084_34140(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 34084, 34140);
                    return return_v;
                }


                System.ArgumentException
                f_1460_34006_34167(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 34006, 34167);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1460_34262_34525(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, int
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 34262, 34525);
                    return return_v;
                }


                int
                f_1460_34192_34548(Microsoft.PowerShell.Commands.GetHistoryCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 34192, 34548);
                    return 0;
                }


                int
                f_1460_34672_34738(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 34672, 34738);
                    return 0;
                }


                Microsoft.PowerShell.Commands.HistoryInfo[]
                f_1460_34773_34810(Microsoft.PowerShell.Commands.History
                this_param, long
                id, int
                count, bool
                newest)
                {
                    var return_v = this_param.GetEntries(id, (long)count, (System.Management.Automation.SwitchParameter)newest);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 34773, 34810);
                    return return_v;
                }


                int
                f_1460_34761_34817(Microsoft.PowerShell.Commands.GetHistoryCommand
                this_param, Microsoft.PowerShell.Commands.HistoryInfo[]
                sendToPipeline, bool
                enumerateCollection)
                {
                    this_param.WriteObject((object)sendToPipeline, enumerateCollection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 34761, 34817);
                    return 0;
                }


                int
                f_1460_35067_35091(Microsoft.PowerShell.Commands.History
                this_param)
                {
                    var return_v = this_param.Buffercapacity();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 35067, 35091);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.HistoryInfo[]
                f_1460_35155_35190(Microsoft.PowerShell.Commands.History
                this_param, int
                id, int
                count, bool
                newest)
                {
                    var return_v = this_param.GetEntries((long)id, (long)count, (System.Management.Automation.SwitchParameter)newest);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 35155, 35190);
                    return return_v;
                }


                int
                f_1460_35223_35237(Microsoft.PowerShell.Commands.HistoryInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 35223, 35237);
                    return return_v;
                }


                int
                f_1460_35277_35300(Microsoft.PowerShell.Commands.GetHistoryCommand
                this_param, Microsoft.PowerShell.Commands.HistoryInfo
                sendToPipeline)
                {
                    this_param.WriteObject((object)sendToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 35277, 35300);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 32300, 35327);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 32300, 35327);
            }
        }

        public GetHistoryCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1460, 30566, 35334);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 30868, 30871);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 31427, 31451);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 31677, 31683);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1460, 30566, 35334);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 30566, 35334);
        }


        static GetHistoryCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1460, 30566, 35334);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1460, 30566, 35334);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 30566, 35334);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1460, 30566, 35334);
    }
    [Cmdlet(VerbsLifecycle.Invoke, "History", SupportsShouldProcess = true, HelpUri = "https://go.microsoft.com/fwlink/?LinkID=2096586")]
    public class InvokeHistoryCommand : PSCmdlet
    {
        private bool _multipleIdProvided;

        private string _id;

        [Parameter(Position = 0, ValueFromPipelineByPropertyName = true)]
        public string Id
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1460, 36475, 36537);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 36511, 36522);

                    return _id;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1460, 36475, 36537);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 36359, 36799);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 36359, 36799);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1460, 36553, 36788);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 36589, 36741) || true) && (_id != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 36589, 36741);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 36695, 36722);

                        _multipleIdProvided = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 36589, 36741);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 36761, 36773);

                    _id = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1460, 36553, 36788);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 36359, 36799);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 36359, 36799);
                }
            }
        }

        protected override void EndProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1460, 36959, 43656);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 37147, 37766) || true) && (_multipleIdProvided == true)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 37147, 37766);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 37212, 37410);

                    Exception
                    ex =
                    f_1460_37248_37409(f_1460_37318_37386(f_1460_37336_37385()))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 37430, 37751);

                    f_1460_37430_37750(this, f_1460_37492_37731(ex, "InvokeHistoryMultipleCommandsError", ErrorCategory.InvalidArgument, null));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 37147, 37766);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 37782, 37849);

                History
                history = f_1460_37800_37848(((LocalRunspace)f_1460_37816_37839(f_1460_37816_37823())))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 37863, 37921);

                f_1460_37863_37920(history != null, "History should be non null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 37985, 38038);

                HistoryInfo
                entry = f_1460_38005_38037(this, history)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 38113, 38224);

                LocalPipeline
                pipeline = (LocalPipeline)f_1460_38153_38223(((LocalRunspace)f_1460_38169_38192(f_1460_38169_38176())))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 38240, 38989) || true) && (f_1460_38244_38291(pipeline, entry) == false)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 38240, 38989);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 38334, 38378);

                    f_1460_38334_38377(pipeline, entry);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 38240, 38989);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 38240, 38989);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 38444, 38641);

                    Exception
                    ex =
                    f_1460_38480_38640(f_1460_38558_38617(f_1460_38576_38616()))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 38661, 38974);

                    f_1460_38661_38973(this, f_1460_38723_38954(ex, "InvokeHistoryLoopDetected", ErrorCategory.InvalidOperation, null));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 38240, 38989);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 39081, 39109);

                f_1460_39081_39108(this, entry);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 39164, 39207);

                string
                commandToInvoke = f_1460_39189_39206(entry)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 39223, 39322) || true) && (f_1460_39227_39257(this, commandToInvoke) == false)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 39223, 39322);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 39300, 39307);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 39223, 39322);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 39407, 39442);

                    f_1460_39407_39441(f_1460_39407_39414(f_1460_39407_39411()), commandToInvoke);
                }
                catch (HostException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1460, 39471, 39631);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1460, 39471, 39631);
                    // when the host is not interactive, HostException is thrown
                    // do nothing
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 39899, 43645);
                using (System.Management.Automation.PowerShell
                ps = f_1460_39951_40027(RunspaceMode.CurrentRunspace)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 40061, 40091);

                    f_1460_40061_40090(ps, commandToInvoke);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 40111, 40320);

                    EventHandler<DataAddedEventArgs>
                    debugAdded = delegate (object sender, DataAddedEventArgs e)
                    { DebugRecord record = (DebugRecord)((PSDataCollection<DebugRecord>)sender)[e.Index]; WriteDebug(record.Message); }
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 40338, 40539);

                    EventHandler<DataAddedEventArgs>
                    errorAdded = delegate (object sender, DataAddedEventArgs e)
                    { ErrorRecord record = (ErrorRecord)((PSDataCollection<ErrorRecord>)sender)[e.Index]; WriteError(record); }
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 40557, 40788);

                    EventHandler<DataAddedEventArgs>
                    informationAdded = delegate (object sender, DataAddedEventArgs e)
                    { InformationRecord record = (InformationRecord)((PSDataCollection<InformationRecord>)sender)[e.Index]; WriteInformation(record); }
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 40806, 41022);

                    EventHandler<DataAddedEventArgs>
                    progressAdded = delegate (object sender, DataAddedEventArgs e)
                    { ProgressRecord record = (ProgressRecord)((PSDataCollection<ProgressRecord>)sender)[e.Index]; WriteProgress(record); }
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 41040, 41259);

                    EventHandler<DataAddedEventArgs>
                    verboseAdded = delegate (object sender, DataAddedEventArgs e)
                    { VerboseRecord record = (VerboseRecord)((PSDataCollection<VerboseRecord>)sender)[e.Index]; WriteVerbose(record.Message); }
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 41277, 41496);

                    EventHandler<DataAddedEventArgs>
                    warningAdded = delegate (object sender, DataAddedEventArgs e)
                    { WarningRecord record = (WarningRecord)((PSDataCollection<WarningRecord>)sender)[e.Index]; WriteWarning(record.Message); }
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 41516, 41557);

                    f_1460_41516_41532(f_1460_41516_41526(ps)).DataAdded += debugAdded;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 41575, 41616);

                    f_1460_41575_41591(f_1460_41575_41585(ps)).DataAdded += errorAdded;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 41634, 41687);

                    f_1460_41634_41656(f_1460_41634_41644(ps)).DataAdded += informationAdded;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 41705, 41752);

                    f_1460_41705_41724(f_1460_41705_41715(ps)).DataAdded += progressAdded;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 41770, 41815);

                    f_1460_41770_41788(f_1460_41770_41780(ps)).DataAdded += verboseAdded;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 41833, 41878);

                    f_1460_41833_41851(f_1460_41833_41843(ps)).DataAdded += warningAdded;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 41898, 41957);

                    LocalRunspace
                    localRunspace = f_1460_41928_41939(ps) as LocalRunspace
                    ;

                    try
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 42545, 42694) || true) && (localRunspace != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 42545, 42694);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 42620, 42671);

                            localRunspace.InInternalNestedPrompt = f_1460_42659_42670(ps);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 42545, 42694);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 42718, 42761);

                        Collection<PSObject>
                        results = f_1460_42749_42760(ps)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 42783, 42904) || true) && (f_1460_42787_42800(results) > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 42783, 42904);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 42854, 42881);

                            f_1460_42854_42880(this, results, true);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 42783, 42904);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 42928, 42977);

                        f_1460_42928_42976(
                                            pipeline, entry);
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1460, 43014, 43630);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 43062, 43205) || true) && (localRunspace != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 43062, 43205);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 43137, 43182);

                            localRunspace.InInternalNestedPrompt = false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 43062, 43205);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 43229, 43270);

                        f_1460_43229_43245(f_1460_43229_43239(ps)).DataAdded -= debugAdded;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 43292, 43333);

                        f_1460_43292_43308(f_1460_43292_43302(ps)).DataAdded -= errorAdded;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 43355, 43408);

                        f_1460_43355_43377(f_1460_43355_43365(ps)).DataAdded -= informationAdded;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 43430, 43477);

                        f_1460_43430_43449(f_1460_43430_43440(ps)).DataAdded -= progressAdded;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 43499, 43544);

                        f_1460_43499_43517(f_1460_43499_43509(ps)).DataAdded -= verboseAdded;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 43566, 43611);

                        f_1460_43566_43584(f_1460_43566_43576(ps)).DataAdded -= warningAdded;
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1460, 43014, 43630);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1460, 39899, 43645);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1460, 36959, 43656);

                string
                f_1460_37336_37385()
                {
                    var return_v = HistoryStrings.InvokeHistoryMultipleCommandsError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 37336, 37385);
                    return return_v;
                }


                string
                f_1460_37318_37386(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 37318, 37386);
                    return return_v;
                }


                System.ArgumentException
                f_1460_37248_37409(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 37248, 37409);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1460_37492_37731(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 37492, 37731);
                    return return_v;
                }


                int
                f_1460_37430_37750(Microsoft.PowerShell.Commands.InvokeHistoryCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 37430, 37750);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1460_37816_37823()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 37816, 37823);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1460_37816_37839(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 37816, 37839);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.History
                f_1460_37800_37848(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.History;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 37800, 37848);
                    return return_v;
                }


                int
                f_1460_37863_37920(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 37863, 37920);
                    return 0;
                }


                Microsoft.PowerShell.Commands.HistoryInfo
                f_1460_38005_38037(Microsoft.PowerShell.Commands.InvokeHistoryCommand
                this_param, Microsoft.PowerShell.Commands.History
                history)
                {
                    var return_v = this_param.GetHistoryEntryToInvoke(history);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 38005, 38037);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1460_38169_38176()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 38169, 38176);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1460_38169_38192(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 38169, 38192);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Pipeline
                f_1460_38153_38223(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.GetCurrentlyRunningPipeline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 38153, 38223);
                    return return_v;
                }


                bool
                f_1460_38244_38291(System.Management.Automation.Runspaces.LocalPipeline
                this_param, Microsoft.PowerShell.Commands.HistoryInfo
                entry)
                {
                    var return_v = this_param.PresentInInvokeHistoryEntryList(entry);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 38244, 38291);
                    return return_v;
                }


                int
                f_1460_38334_38377(System.Management.Automation.Runspaces.LocalPipeline
                this_param, Microsoft.PowerShell.Commands.HistoryInfo
                entry)
                {
                    this_param.AddToInvokeHistoryEntryList(entry);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 38334, 38377);
                    return 0;
                }


                string
                f_1460_38576_38616()
                {
                    var return_v = HistoryStrings.InvokeHistoryLoopDetected;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 38576, 38616);
                    return return_v;
                }


                string
                f_1460_38558_38617(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 38558, 38617);
                    return return_v;
                }


                System.InvalidOperationException
                f_1460_38480_38640(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 38480, 38640);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1460_38723_38954(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 38723, 38954);
                    return return_v;
                }


                int
                f_1460_38661_38973(Microsoft.PowerShell.Commands.InvokeHistoryCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 38661, 38973);
                    return 0;
                }


                int
                f_1460_39081_39108(Microsoft.PowerShell.Commands.InvokeHistoryCommand
                this_param, Microsoft.PowerShell.Commands.HistoryInfo
                entry)
                {
                    this_param.ReplaceHistoryString(entry);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 39081, 39108);
                    return 0;
                }


                string
                f_1460_39189_39206(Microsoft.PowerShell.Commands.HistoryInfo
                this_param)
                {
                    var return_v = this_param.CommandLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 39189, 39206);
                    return return_v;
                }


                bool
                f_1460_39227_39257(Microsoft.PowerShell.Commands.InvokeHistoryCommand
                this_param, string
                target)
                {
                    var return_v = this_param.ShouldProcess(target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 39227, 39257);
                    return return_v;
                }


                System.Management.Automation.Host.PSHost
                f_1460_39407_39411()
                {
                    var return_v = Host;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 39407, 39411);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostUserInterface
                f_1460_39407_39414(System.Management.Automation.Host.PSHost
                this_param)
                {
                    var return_v = this_param.UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 39407, 39414);
                    return return_v;
                }


                int
                f_1460_39407_39441(System.Management.Automation.Host.PSHostUserInterface
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 39407, 39441);
                    return 0;
                }


                System.Management.Automation.PowerShell
                f_1460_39951_40027(System.Management.Automation.RunspaceMode
                runspace)
                {
                    var return_v = System.Management.Automation.PowerShell.Create(runspace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 39951, 40027);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1460_40061_40090(System.Management.Automation.PowerShell
                this_param, string
                script)
                {
                    var return_v = this_param.AddScript(script);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 40061, 40090);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1460_41516_41526(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 41516, 41526);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.DebugRecord>
                f_1460_41516_41532(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Debug;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 41516, 41532);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1460_41575_41585(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 41575, 41585);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                f_1460_41575_41591(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Error;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 41575, 41591);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1460_41634_41644(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 41634, 41644);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.InformationRecord>
                f_1460_41634_41656(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Information;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 41634, 41656);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1460_41705_41715(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 41705, 41715);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ProgressRecord>
                f_1460_41705_41724(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Progress;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 41705, 41724);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1460_41770_41780(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 41770, 41780);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.VerboseRecord>
                f_1460_41770_41788(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Verbose;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 41770, 41788);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1460_41833_41843(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 41833, 41843);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.WarningRecord>
                f_1460_41833_41851(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Warning;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 41833, 41851);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1460_41928_41939(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 41928, 41939);
                    return return_v;
                }


                bool
                f_1460_42659_42670(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.IsNested;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 42659, 42670);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1460_42749_42760(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Invoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 42749, 42760);
                    return return_v;
                }


                int
                f_1460_42787_42800(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 42787, 42800);
                    return return_v;
                }


                int
                f_1460_42854_42880(Microsoft.PowerShell.Commands.InvokeHistoryCommand
                this_param, System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                sendToPipeline, bool
                enumerateCollection)
                {
                    this_param.WriteObject((object)sendToPipeline, enumerateCollection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 42854, 42880);
                    return 0;
                }


                int
                f_1460_42928_42976(System.Management.Automation.Runspaces.LocalPipeline
                this_param, Microsoft.PowerShell.Commands.HistoryInfo
                entry)
                {
                    this_param.RemoveFromInvokeHistoryEntryList(entry);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 42928, 42976);
                    return 0;
                }


                System.Management.Automation.PSDataStreams
                f_1460_43229_43239(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 43229, 43239);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.DebugRecord>
                f_1460_43229_43245(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Debug;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 43229, 43245);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1460_43292_43302(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 43292, 43302);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                f_1460_43292_43308(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Error;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 43292, 43308);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1460_43355_43365(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 43355, 43365);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.InformationRecord>
                f_1460_43355_43377(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Information;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 43355, 43377);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1460_43430_43440(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 43430, 43440);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ProgressRecord>
                f_1460_43430_43449(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Progress;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 43430, 43449);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1460_43499_43509(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 43499, 43509);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.VerboseRecord>
                f_1460_43499_43517(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Verbose;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 43499, 43517);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1460_43566_43576(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 43566, 43576);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.WarningRecord>
                f_1460_43566_43584(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Warning;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 43566, 43584);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 36959, 43656);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 36959, 43656);
            }
        }

        [SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly", Justification = "It's ok to use ID in the ArgumentException")]
        private HistoryInfo GetHistoryEntryToInvoke(History history)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1460, 43780, 48672);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 44022, 44047);

                HistoryInfo
                entry = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 44158, 48632) || true) && (_id == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 44158, 48632);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 44207, 44262);

                    HistoryInfo[]
                    entries = f_1460_44231_44261(history, 0, 1, true)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 44282, 45062) || true) && (f_1460_44286_44300(entries) == 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 44282, 45062);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 44347, 44366);

                        entry = entries[0];
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 44282, 45062);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 44282, 45062);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 44448, 44659);

                        Exception
                        ex =
                        f_1460_44488_44658(f_1460_44574_44631(f_1460_44592_44630()))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 44683, 45043);

                        f_1460_44683_45042(this, f_1460_44753_45019(ex, "InvokeHistoryNoLastHistoryEntryFound", ErrorCategory.InvalidOperation, null));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 44282, 45062);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 44158, 48632);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 44158, 48632);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 45160, 45187);

                    f_1460_45160_45186(this);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 45329, 48617) || true) && (_commandLine != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 45329, 48617);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 45395, 45452);

                        HistoryInfo[]
                        entries = f_1460_45419_45451(history, 0, -1, false)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 45550, 45572);

                            // and search backwards through the entries
                            for (int
        i = f_1460_45554_45568(entries) - 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 45541, 45882) || true) && (i >= 0)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 45582, 45585)
        , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 45541, 45882))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 45541, 45882);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 45635, 45859) || true) && (f_1460_45639_45719(f_1460_45639_45661(entries[i]), _commandLine, StringComparison.CurrentCulture))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 45635, 45859);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 45777, 45796);

                                    entry = entries[i];
                                    DynAbs.Tracing.TraceSender.TraceBreak(1460, 45826, 45832);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 45635, 45859);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1460, 1, 342);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1460, 1, 342);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 45906, 46659) || true) && (entry == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 45906, 46659);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 45973, 46206);

                            Exception
                            ex =
                            f_1460_46017_46205(f_1460_46103_46174(f_1460_46121_46159(), _commandLine))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 46234, 46636);

                            f_1460_46234_46635(this, f_1460_46312_46608(ex, "InvokeHistoryNoHistoryForCommandline", ErrorCategory.ObjectNotFound, _commandLine));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 45906, 46659);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 45329, 48617);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 45329, 48617);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 46741, 48598) || true) && (_historyId <= 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 46741, 48598);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 46810, 47086);

                            Exception
                            ex =
                            f_1460_46854_47085("Id", f_1460_46989_47054(f_1460_47007_47041(), _historyId))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 47114, 47511);

                            f_1460_47114_47510(this, f_1460_47192_47483(ex, "InvokeHistoryInvalidIdGetHistory", ErrorCategory.InvalidArgument, _historyId));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 46741, 48598);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 46741, 48598);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 47687, 47724);

                            entry = f_1460_47695_47723(history, _historyId);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 47750, 48575) || true) && (entry == null || (DynAbs.Tracing.TraceSender.Expression_False(1460, 47754, 47793) || f_1460_47771_47779(entry) != _historyId))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 47750, 48575);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 47851, 48089);

                                Exception
                                ex =
                                f_1460_47899_48088(f_1460_47993_48053(f_1460_48011_48040(), _historyId))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 48121, 48548);

                                f_1460_48121_48547(this, f_1460_48207_48516(ex, "InvokeHistoryNoHistoryForId", ErrorCategory.ObjectNotFound, _historyId));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 47750, 48575);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 46741, 48598);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 45329, 48617);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 44158, 48632);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 48648, 48661);

                return entry;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1460, 43780, 48672);

                Microsoft.PowerShell.Commands.HistoryInfo[]
                f_1460_44231_44261(Microsoft.PowerShell.Commands.History
                this_param, int
                id, int
                count, bool
                newest)
                {
                    var return_v = this_param.GetEntries((long)id, (long)count, (System.Management.Automation.SwitchParameter)newest);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 44231, 44261);
                    return return_v;
                }


                int
                f_1460_44286_44300(Microsoft.PowerShell.Commands.HistoryInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 44286, 44300);
                    return return_v;
                }


                string
                f_1460_44592_44630()
                {
                    var return_v = HistoryStrings.NoLastHistoryEntryFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 44592, 44630);
                    return return_v;
                }


                string
                f_1460_44574_44631(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 44574, 44631);
                    return return_v;
                }


                System.InvalidOperationException
                f_1460_44488_44658(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 44488, 44658);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1460_44753_45019(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 44753, 45019);
                    return return_v;
                }


                int
                f_1460_44683_45042(Microsoft.PowerShell.Commands.InvokeHistoryCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 44683, 45042);
                    return 0;
                }


                int
                f_1460_45160_45186(Microsoft.PowerShell.Commands.InvokeHistoryCommand
                this_param)
                {
                    this_param.PopulateIdAndCommandLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 45160, 45186);
                    return 0;
                }


                Microsoft.PowerShell.Commands.HistoryInfo[]
                f_1460_45419_45451(Microsoft.PowerShell.Commands.History
                this_param, int
                id, int
                count, bool
                newest)
                {
                    var return_v = this_param.GetEntries((long)id, (long)count, (System.Management.Automation.SwitchParameter)newest);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 45419, 45451);
                    return return_v;
                }


                int
                f_1460_45554_45568(Microsoft.PowerShell.Commands.HistoryInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 45554, 45568);
                    return return_v;
                }


                string
                f_1460_45639_45661(Microsoft.PowerShell.Commands.HistoryInfo
                this_param)
                {
                    var return_v = this_param.CommandLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 45639, 45661);
                    return return_v;
                }


                bool
                f_1460_45639_45719(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 45639, 45719);
                    return return_v;
                }


                string
                f_1460_46121_46159()
                {
                    var return_v = HistoryStrings.NoHistoryForCommandline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 46121, 46159);
                    return return_v;
                }


                string
                f_1460_46103_46174(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 46103, 46174);
                    return return_v;
                }


                System.ArgumentException
                f_1460_46017_46205(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 46017, 46205);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1460_46312_46608(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, string
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 46312, 46608);
                    return return_v;
                }


                int
                f_1460_46234_46635(Microsoft.PowerShell.Commands.InvokeHistoryCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 46234, 46635);
                    return 0;
                }


                string
                f_1460_47007_47041()
                {
                    var return_v = HistoryStrings.InvalidIdGetHistory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 47007, 47041);
                    return return_v;
                }


                string
                f_1460_46989_47054(string
                formatSpec, long
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 46989, 47054);
                    return return_v;
                }


                System.ArgumentOutOfRangeException
                f_1460_46854_47085(string
                paramName, string
                message)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 46854, 47085);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1460_47192_47483(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, long
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 47192, 47483);
                    return return_v;
                }


                int
                f_1460_47114_47510(Microsoft.PowerShell.Commands.InvokeHistoryCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 47114, 47510);
                    return 0;
                }


                Microsoft.PowerShell.Commands.HistoryInfo
                f_1460_47695_47723(Microsoft.PowerShell.Commands.History
                this_param, long
                id)
                {
                    var return_v = this_param.GetEntry(id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 47695, 47723);
                    return return_v;
                }


                long
                f_1460_47771_47779(Microsoft.PowerShell.Commands.HistoryInfo
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 47771, 47779);
                    return return_v;
                }


                string
                f_1460_48011_48040()
                {
                    var return_v = HistoryStrings.NoHistoryForId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 48011, 48040);
                    return return_v;
                }


                string
                f_1460_47993_48053(string
                formatSpec, long
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 47993, 48053);
                    return return_v;
                }


                System.ArgumentException
                f_1460_47899_48088(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 47899, 48088);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1460_48207_48516(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, long
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 48207, 48516);
                    return return_v;
                }


                int
                f_1460_48121_48547(Microsoft.PowerShell.Commands.InvokeHistoryCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 48121, 48547);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 43780, 48672);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 43780, 48672);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private long _historyId;

        private string _commandLine;

        private void PopulateIdAndCommandLine()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1460, 49061, 49498);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 49125, 49166) || true) && (_id == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 49125, 49166);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 49159, 49166);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 49125, 49166);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 49218, 49336);

                    _historyId = (long)f_1460_49237_49335(_id, typeof(long), f_1460_49285_49334());
                }
                catch (PSInvalidCastException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1460, 49365, 49487);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 49428, 49447);

                    _commandLine = _id;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 49465, 49472);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1460, 49365, 49487);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1460, 49061, 49498);

                System.Globalization.CultureInfo
                f_1460_49285_49334()
                {
                    var return_v = System.Globalization.CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 49285, 49334);
                    return return_v;
                }


                object
                f_1460_49237_49335(string
                valueToConvert, System.Type
                resultType, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = LanguagePrimitives.ConvertTo((object)valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 49237, 49335);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 49061, 49498);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 49061, 49498);
            }
        }

        private void ReplaceHistoryString(HistoryInfo entry)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1460, 49871, 50242);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 49989, 50100);

                LocalPipeline
                pipeline = (LocalPipeline)f_1460_50029_50099(((LocalRunspace)f_1460_50045_50068(f_1460_50045_50052())))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 50114, 50231) || true) && (f_1460_50118_50139(pipeline))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 50114, 50231);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 50173, 50216);

                    pipeline.HistoryString = f_1460_50198_50215(entry);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 50114, 50231);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1460, 49871, 50242);

                System.Management.Automation.ExecutionContext
                f_1460_50045_50052()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 50045, 50052);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1460_50045_50068(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 50045, 50068);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Pipeline
                f_1460_50029_50099(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.GetCurrentlyRunningPipeline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 50029, 50099);
                    return return_v;
                }


                bool
                f_1460_50118_50139(System.Management.Automation.Runspaces.LocalPipeline
                this_param)
                {
                    var return_v = this_param.AddToHistory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 50118, 50139);
                    return return_v;
                }


                string
                f_1460_50198_50215(Microsoft.PowerShell.Commands.HistoryInfo
                this_param)
                {
                    var return_v = this_param.CommandLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 50198, 50215);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 49871, 50242);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 49871, 50242);
            }
        }

        public InvokeHistoryCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1460, 35440, 50249);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 35849, 35868);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 35894, 35897);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 48789, 48804);
            this._historyId = -1;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 48916, 48928);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1460, 35440, 50249);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 35440, 50249);
        }


        static InvokeHistoryCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1460, 35440, 50249);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1460, 35440, 50249);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 35440, 50249);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1460, 35440, 50249);
    }
    [Cmdlet(VerbsCommon.Add, "History", HelpUri = "https://go.microsoft.com/fwlink/?LinkID=2096479")]
    [OutputType(typeof(HistoryInfo))]
    public class AddHistoryCommand : PSCmdlet
    {
        [Parameter(Position = 0, ValueFromPipeline = true)]
        public PSObject[] InputObject { set; get; }

        private bool _passthru;

        [Parameter()]
        public SwitchParameter Passthru
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1460, 51100, 51125);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 51106, 51123);

                    return _passthru;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1460, 51100, 51125);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 51021, 51178);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 51021, 51178);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1460, 51141, 51167);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 51147, 51165);

                    _passthru = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1460, 51141, 51167);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 51021, 51178);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 51021, 51178);
                }
            }
        }

        protected
                override
                void BeginProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1460, 51313, 52074);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 51902, 52007);

                LocalPipeline
                lpl = (LocalPipeline)f_1460_51937_52006(((RunspaceBase)f_1460_51952_51975(f_1460_51952_51959())))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 52021, 52063);

                f_1460_52021_52062(lpl);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1460, 51313, 52074);

                System.Management.Automation.ExecutionContext
                f_1460_51952_51959()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 51952, 51959);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1460_51952_51975(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 51952, 51975);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Pipeline
                f_1460_51937_52006(System.Management.Automation.Runspaces.RunspaceBase
                this_param)
                {
                    var return_v = this_param.GetCurrentlyRunningPipeline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 51937, 52006);
                    return return_v;
                }


                int
                f_1460_52021_52062(System.Management.Automation.Runspaces.LocalPipeline
                this_param)
                {
                    this_param.AddHistoryEntryFromAddHistoryCmdlet();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 52021, 52062);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 51313, 52074);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 51313, 52074);
            }
        }

        protected
                override
                void ProcessRecord()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1460, 52174, 53543);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 52256, 52323);

                History
                history = f_1460_52274_52322(((LocalRunspace)f_1460_52290_52313(f_1460_52290_52297())))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 52337, 52395);

                f_1460_52337_52394(history != null, "History should be non null");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 52411, 53532) || true) && (f_1460_52415_52426() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 52411, 53532);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 52468, 53517);
                        foreach (PSObject input in f_1460_52495_52506_I(f_1460_52495_52506()))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 52468, 53517);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 52667, 52719);

                            HistoryInfo
                            infoToAdd = f_1460_52691_52718(this, input)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 52741, 53498) || true) && (infoToAdd != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 52741, 53498);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 52812, 53252);

                                long
                                id = f_1460_52822_53251(history, 0, f_1460_52953_52974(infoToAdd), f_1460_53013_53038(infoToAdd), f_1460_53077_53105(infoToAdd), f_1460_53144_53170(infoToAdd), false)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 53280, 53475) || true) && (f_1460_53284_53292())
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 53280, 53475);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 53350, 53395);

                                    HistoryInfo
                                    infoAdded = f_1460_53374_53394(history, id)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 53425, 53448);

                                    f_1460_53425_53447(this, infoAdded);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 53280, 53475);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 52741, 53498);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 52468, 53517);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1460, 1, 1050);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1460, 1, 1050);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 52411, 53532);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1460, 52174, 53543);

                System.Management.Automation.ExecutionContext
                f_1460_52290_52297()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 52290, 52297);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1460_52290_52313(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 52290, 52313);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.History
                f_1460_52274_52322(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.History;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 52274, 52322);
                    return return_v;
                }


                int
                f_1460_52337_52394(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 52337, 52394);
                    return 0;
                }


                System.Management.Automation.PSObject[]
                f_1460_52415_52426()
                {
                    var return_v = InputObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 52415, 52426);
                    return return_v;
                }


                System.Management.Automation.PSObject[]
                f_1460_52495_52506()
                {
                    var return_v = InputObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 52495, 52506);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.HistoryInfo
                f_1460_52691_52718(Microsoft.PowerShell.Commands.AddHistoryCommand
                this_param, System.Management.Automation.PSObject
                mshObject)
                {
                    var return_v = this_param.GetHistoryInfoObject(mshObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 52691, 52718);
                    return return_v;
                }


                string
                f_1460_52953_52974(Microsoft.PowerShell.Commands.HistoryInfo
                this_param)
                {
                    var return_v = this_param.CommandLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 52953, 52974);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineState
                f_1460_53013_53038(Microsoft.PowerShell.Commands.HistoryInfo
                this_param)
                {
                    var return_v = this_param.ExecutionStatus;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 53013, 53038);
                    return return_v;
                }


                System.DateTime
                f_1460_53077_53105(Microsoft.PowerShell.Commands.HistoryInfo
                this_param)
                {
                    var return_v = this_param.StartExecutionTime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 53077, 53105);
                    return return_v;
                }


                System.DateTime
                f_1460_53144_53170(Microsoft.PowerShell.Commands.HistoryInfo
                this_param)
                {
                    var return_v = this_param.EndExecutionTime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 53144, 53170);
                    return return_v;
                }


                long
                f_1460_52822_53251(Microsoft.PowerShell.Commands.History
                this_param, int
                pipelineId, string
                cmdline, System.Management.Automation.Runspaces.PipelineState
                status, System.DateTime
                startTime, System.DateTime
                endTime, bool
                skipIfLocked)
                {
                    var return_v = this_param.AddEntry((long)pipelineId, cmdline, status, startTime, endTime, skipIfLocked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 52822, 53251);
                    return return_v;
                }


                System.Management.Automation.SwitchParameter
                f_1460_53284_53292()
                {
                    var return_v = Passthru;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 53284, 53292);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.HistoryInfo
                f_1460_53374_53394(Microsoft.PowerShell.Commands.History
                this_param, long
                id)
                {
                    var return_v = this_param.GetEntry(id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 53374, 53394);
                    return return_v;
                }


                int
                f_1460_53425_53447(Microsoft.PowerShell.Commands.AddHistoryCommand
                this_param, Microsoft.PowerShell.Commands.HistoryInfo
                sendToPipeline)
                {
                    this_param.WriteObject((object)sendToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 53425, 53447);
                    return 0;
                }


                System.Management.Automation.PSObject[]
                f_1460_52495_52506_I(System.Management.Automation.PSObject[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 52495, 52506);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 52174, 53543);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 52174, 53543);
            }
        }

        private
                HistoryInfo
                GetHistoryInfoObject(PSObject mshObject)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1460, 53988, 58778);
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 54091, 58217);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 54126, 54214) || true) && (mshObject == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 54126, 54214);
                                DynAbs.Tracing.TraceSender.TraceBreak(1460, 54189, 54195);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 54126, 54214);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 54278, 54352);

                            string
                            commandLine = f_1460_54299_54341(mshObject, "CommandLine") as string
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 54370, 54460) || true) && (commandLine == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 54370, 54460);
                                DynAbs.Tracing.TraceSender.TraceBreak(1460, 54435, 54441);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 54370, 54460);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 54530, 54600);

                            object
                            pipelineState = f_1460_54553_54599(mshObject, "ExecutionStatus")
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 54618, 54710) || true) && (pipelineState == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 54618, 54710);
                                DynAbs.Tracing.TraceSender.TraceBreak(1460, 54685, 54691);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 54618, 54710);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 54730, 54760);

                            PipelineState
                            executionStatus
                            = default(PipelineState);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 54778, 56042) || true) && (pipelineState is PipelineState)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 54778, 56042);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 54854, 54901);

                                executionStatus = (PipelineState)pipelineState;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 54778, 56042);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 54778, 56042);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 54943, 56042) || true) && (pipelineState is PSObject)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 54943, 56042);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 55014, 55075);

                                    PSObject
                                    serializedPipelineState = pipelineState as PSObject
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 55097, 55152);

                                    object
                                    baseObject = f_1460_55117_55151(serializedPipelineState)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 55174, 55277) || true) && (!(baseObject is int))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 55174, 55277);
                                        DynAbs.Tracing.TraceSender.TraceBreak(1460, 55248, 55254);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 55174, 55277);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 55301, 55345);

                                    executionStatus = (PipelineState)baseObject;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 55367, 55534) || true) && (executionStatus < PipelineState.NotStarted || (DynAbs.Tracing.TraceSender.Expression_False(1460, 55371, 55455) || executionStatus > PipelineState.Failed))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 55367, 55534);
                                        DynAbs.Tracing.TraceSender.TraceBreak(1460, 55505, 55511);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 55367, 55534);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 54943, 56042);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 54943, 56042);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 55576, 56042) || true) && (pipelineState is string)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 55576, 56042);
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 55697, 55787);

                                            executionStatus = (PipelineState)f_1460_55730_55786(typeof(PipelineState), pipelineState);
                                        }
                                        catch (ArgumentException)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1460, 55832, 55935);
                                            DynAbs.Tracing.TraceSender.TraceBreak(1460, 55906, 55912);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCatch(1460, 55832, 55935);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 55576, 56042);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 55576, 56042);
                                        DynAbs.Tracing.TraceSender.TraceBreak(1460, 56017, 56023);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 55576, 56042);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 54943, 56042);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 54778, 56042);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 56115, 56143);

                            DateTime
                            startExecutionTime
                            = default(DateTime);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 56161, 56225);

                            object
                            temp = f_1460_56175_56224(mshObject, "StartExecutionTime")
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 56243, 56953) || true) && (temp == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 56243, 56953);
                                DynAbs.Tracing.TraceSender.TraceBreak(1460, 56301, 56307);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 56243, 56953);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 56243, 56953);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 56349, 56953) || true) && (temp is DateTime)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 56349, 56953);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 56411, 56447);

                                    startExecutionTime = (DateTime)temp;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 56349, 56953);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 56349, 56953);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 56489, 56953) || true) && (temp is string)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 56489, 56953);
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 56601, 56700);

                                            startExecutionTime = DateTime.Parse((string)temp, f_1460_56651_56698());
                                        }
                                        catch (FormatException)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1460, 56745, 56846);
                                            DynAbs.Tracing.TraceSender.TraceBreak(1460, 56817, 56823);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCatch(1460, 56745, 56846);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 56489, 56953);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 56489, 56953);
                                        DynAbs.Tracing.TraceSender.TraceBreak(1460, 56928, 56934);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 56489, 56953);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 56349, 56953);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 56243, 56953);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 57024, 57050);

                            DateTime
                            endExecutionTime
                            = default(DateTime);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 57068, 57123);

                            temp = f_1460_57075_57122(mshObject, "EndExecutionTime");

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 57141, 57847) || true) && (temp == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 57141, 57847);
                                DynAbs.Tracing.TraceSender.TraceBreak(1460, 57199, 57205);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 57141, 57847);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 57141, 57847);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 57247, 57847) || true) && (temp is DateTime)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 57247, 57847);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 57309, 57343);

                                    endExecutionTime = (DateTime)temp;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 57247, 57847);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 57247, 57847);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 57385, 57847) || true) && (temp is string)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 57385, 57847);
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 57497, 57594);

                                            endExecutionTime = DateTime.Parse((string)temp, f_1460_57545_57592());
                                        }
                                        catch (FormatException)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1460, 57639, 57740);
                                            DynAbs.Tracing.TraceSender.TraceBreak(1460, 57711, 57717);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCatch(1460, 57639, 57740);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 57385, 57847);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 57385, 57847);
                                        DynAbs.Tracing.TraceSender.TraceBreak(1460, 57822, 57828);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 57385, 57847);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 57247, 57847);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 57141, 57847);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 57867, 58187);

                            return f_1460_57874_58186(0, commandLine, executionStatus, startExecutionTime, endExecutionTime);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 54091, 58217);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 54091, 58217) || true) && (false)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1460, 54091, 58217);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1460, 54091, 58217);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 58287, 58460);

                Exception
                ex =
                f_1460_58319_58459(f_1460_58384_58440(f_1460_58402_58439()))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 58476, 58739);

                f_1460_58476_58738(this, f_1460_58519_58723(ex, "AddHistoryInvalidInput", ErrorCategory.InvalidData, mshObject));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 58755, 58767);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1460, 53988, 58778);

                object
                f_1460_54299_54341(System.Management.Automation.PSObject
                mshObject, string
                propertyName)
                {
                    var return_v = GetPropertyValue(mshObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 54299, 54341);
                    return return_v;
                }


                object
                f_1460_54553_54599(System.Management.Automation.PSObject
                mshObject, string
                propertyName)
                {
                    var return_v = GetPropertyValue(mshObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 54553, 54599);
                    return return_v;
                }


                object
                f_1460_55117_55151(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 55117, 55151);
                    return return_v;
                }


                object
                f_1460_55730_55786(System.Type
                enumType, object
                value)
                {
                    var return_v = Enum.Parse(enumType, (string)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 55730, 55786);
                    return return_v;
                }


                object
                f_1460_56175_56224(System.Management.Automation.PSObject
                mshObject, string
                propertyName)
                {
                    var return_v = GetPropertyValue(mshObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 56175, 56224);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1460_56651_56698()
                {
                    var return_v = System.Globalization.CultureInfo.CurrentCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 56651, 56698);
                    return return_v;
                }


                object
                f_1460_57075_57122(System.Management.Automation.PSObject
                mshObject, string
                propertyName)
                {
                    var return_v = GetPropertyValue(mshObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 57075, 57122);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1460_57545_57592()
                {
                    var return_v = System.Globalization.CultureInfo.CurrentCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 57545, 57592);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.HistoryInfo
                f_1460_57874_58186(int
                pipelineId, string
                cmdline, System.Management.Automation.Runspaces.PipelineState
                status, System.DateTime
                startTime, System.DateTime
                endTime)
                {
                    var return_v = new Microsoft.PowerShell.Commands.HistoryInfo((long)pipelineId, cmdline, status, startTime, endTime);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 57874, 58186);
                    return return_v;
                }


                string
                f_1460_58402_58439()
                {
                    var return_v = HistoryStrings.AddHistoryInvalidInput;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 58402, 58439);
                    return return_v;
                }


                string
                f_1460_58384_58440(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 58384, 58440);
                    return return_v;
                }


                System.IO.InvalidDataException
                f_1460_58319_58459(string
                message)
                {
                    var return_v = new System.IO.InvalidDataException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 58319, 58459);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1460_58519_58723(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.PSObject
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 58519, 58723);
                    return return_v;
                }


                int
                f_1460_58476_58738(Microsoft.PowerShell.Commands.AddHistoryCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 58476, 58738);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 53988, 58778);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 53988, 58778);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static
                object
                GetPropertyValue(PSObject mshObject, string propertyName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1460, 58820, 59125);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 58942, 59005);

                PSMemberInfo
                propertyInfo = f_1460_58970_59004(f_1460_58970_58990(mshObject), propertyName)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 59019, 59074) || true) && (propertyInfo == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 59019, 59074);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 59062, 59074);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 59019, 59074);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 59088, 59114);

                return f_1460_59095_59113(propertyInfo);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1460, 58820, 59125);

                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1460_58970_58990(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 58970, 58990);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1460_58970_59004(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 58970, 59004);
                    return return_v;
                }


                object
                f_1460_59095_59113(System.Management.Automation.PSMemberInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 59095, 59113);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 58820, 59125);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 58820, 59125);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public AddHistoryCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1460, 50352, 59132);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 50696, 50800);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 50825, 50834);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1460, 50352, 59132);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 50352, 59132);
        }


        static AddHistoryCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1460, 50352, 59132);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1460, 50352, 59132);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 50352, 59132);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1460, 50352, 59132);
    }
    [Cmdlet(VerbsCommon.Clear, "History", SupportsShouldProcess = true, DefaultParameterSetName = "IDParameter", HelpUri = "https://go.microsoft.com/fwlink/?LinkID=2096691")]
    public class ClearHistoryCommand : PSCmdlet
    {
        [Parameter(ParameterSetName = "IDParameter", Position = 0,
                   HelpMessage = "Specifies the ID of a command in the session history.Clear history clears only the specified command")]
        [ValidateRangeAttribute((int)1, int.MaxValue)]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public int[] Id
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1460, 60086, 60148);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 60122, 60133);

                    return _id;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1460, 60086, 60148);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 59697, 60238);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 59697, 60238);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1460, 60164, 60227);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 60200, 60212);

                    _id = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1460, 60164, 60227);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 59697, 60238);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 59697, 60238);
                }
            }
        }

        private int[] _id;

        [Parameter(ParameterSetName = "CommandLineParameter", HelpMessage = "Specifies the name of a command in the session history")]
        [ValidateNotNullOrEmpty()]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public string[] CommandLine
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1460, 60799, 60870);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 60835, 60855);

                    return _commandline;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1460, 60799, 60870);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 60481, 60969);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 60481, 60969);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1460, 60886, 60958);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 60922, 60943);

                    _commandline = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1460, 60886, 60958);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 60481, 60969);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 60481, 60969);
                }
            }
        }

        private string[] _commandline;

        [Parameter(Mandatory = false, Position = 1, HelpMessage = "Clears the specified number of history entries")]
        [ValidateRangeAttribute((int)1, int.MaxValue)]
        public int Count
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1460, 61435, 61500);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 61471, 61485);

                    return _count;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1460, 61435, 61500);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 61220, 61643);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 61220, 61643);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1460, 61516, 61632);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 61552, 61584);

                    _countParameterSpecified = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 61602, 61617);

                    _count = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1460, 61516, 61632);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 61220, 61643);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 61220, 61643);
                }
            }
        }

        private int _count;

        private bool _countParameterSpecified;

        [Parameter(Mandatory = false, HelpMessage = "Specifies whether new entries to be cleared or the default old ones.")]
        public SwitchParameter Newest
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1460, 62275, 62341);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 62311, 62326);

                    return _newest;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1460, 62275, 62341);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 62095, 62435);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 62095, 62435);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1460, 62357, 62424);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 62393, 62409);

                    _newest = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1460, 62357, 62424);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 62095, 62435);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 62095, 62435);
                }
            }
        }

        private SwitchParameter _newest;

        protected override void BeginProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1460, 62731, 62868);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 62797, 62857);

                _history = f_1460_62808_62856(((LocalRunspace)f_1460_62824_62847(f_1460_62824_62831())));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1460, 62731, 62868);

                System.Management.Automation.ExecutionContext
                f_1460_62824_62831()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 62824, 62831);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1460_62824_62847(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 62824, 62847);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.History
                f_1460_62808_62856(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.History;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 62808, 62856);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 62731, 62868);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 62731, 62868);
            }
        }

        protected override void ProcessRecord()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1460, 62969, 63728);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 63094, 63717);

                switch (f_1460_63102_63129(f_1460_63102_63118()))
                {

                    case "IDParameter":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 63094, 63717);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 63204, 63223);

                        f_1460_63204_63222(this);
                        DynAbs.Tracing.TraceSender.TraceBreak(1460, 63245, 63251);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 63094, 63717);

                    case "CommandLineParameter":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 63094, 63717);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 63319, 63343);

                        f_1460_63319_63342(this);
                        DynAbs.Tracing.TraceSender.TraceBreak(1460, 63365, 63371);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 63094, 63717);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 63094, 63717);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 63419, 63673);

                        f_1460_63419_63672(this, f_1460_63467_63671(f_1460_63513_63563("Invalid ParameterSet Name"), "Unable to access the session history", ErrorCategory.InvalidOperation, null));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 63695, 63702);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 63094, 63717);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1460, 62969, 63728);

                string
                f_1460_63102_63118()
                {
                    var return_v = ParameterSetName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 63102, 63118);
                    return return_v;
                }


                string
                f_1460_63102_63129(string
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 63102, 63129);
                    return return_v;
                }


                int
                f_1460_63204_63222(Microsoft.PowerShell.Commands.ClearHistoryCommand
                this_param)
                {
                    this_param.ClearHistoryByID();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 63204, 63222);
                    return 0;
                }


                int
                f_1460_63319_63342(Microsoft.PowerShell.Commands.ClearHistoryCommand
                this_param)
                {
                    this_param.ClearHistoryByCmdLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 63319, 63342);
                    return 0;
                }


                System.ArgumentException
                f_1460_63513_63563(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 63513, 63563);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1460_63467_63671(System.ArgumentException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 63467, 63671);
                    return return_v;
                }


                int
                f_1460_63419_63672(Microsoft.PowerShell.Commands.ClearHistoryCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 63419, 63672);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 62969, 63728);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 62969, 63728);
            }
        }

        private void ClearHistoryByID()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1460, 63954, 68116);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 64010, 64618) || true) && (_countParameterSpecified && (DynAbs.Tracing.TraceSender.Expression_True(1460, 64014, 64051) && f_1460_64042_64047() < 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 64010, 64618);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 64085, 64267);

                    Exception
                    ex =
                    f_1460_64120_64266(f_1460_64188_64244("HistoryStrings", "InvalidCountValue"))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 64285, 64603);

                    f_1460_64285_64602(this, f_1460_64347_64583(ex, "ClearHistoryInvalidCountValue", ErrorCategory.InvalidArgument, _count));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 64010, 64618);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 64679, 68105) || true) && (_id != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 64679, 68105);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 64782, 67311) || true) && (!_countParameterSpecified)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 64782, 67311);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 64931, 66173);
                            foreach (long id in f_1460_64951_64954_I(_id))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 64931, 66173);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 65004, 65071);

                                f_1460_65004_65070(id > 0, "ValidateRangeAttribute should not allow this");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 65097, 65139);

                                HistoryInfo
                                entry = f_1460_65117_65138(_history, id)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 65165, 66150) || true) && (entry != null && (DynAbs.Tracing.TraceSender.Expression_True(1460, 65169, 65200) && f_1460_65186_65194(entry) == id))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 65165, 66150);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 65258, 65288);

                                    f_1460_65258_65287(_history, f_1460_65278_65286(entry));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 65165, 66150);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 65165, 66150);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 65458, 65688);

                                    Exception
                                    ex =
                                    f_1460_65506_65687(f_1460_65600_65652(f_1460_65618_65647(), id))
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 65718, 66123);

                                    f_1460_65718_66122(this, f_1460_65793_66091(ex, "GetHistoryNoHistoryForId", ErrorCategory.ObjectNotFound, id));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 65165, 66150);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 64931, 66173);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1460, 1, 1243);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1460, 1, 1243);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 64782, 67311);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 64782, 67311);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 66215, 67311) || true) && (f_1460_66219_66229(_id) > 1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 66215, 67311);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 66334, 66536);

                            Exception
                            ex =
                            f_1460_66374_66535(f_1460_66452_66508(f_1460_66470_66507()))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 66560, 66917);

                            f_1460_66560_66916(this, f_1460_66630_66893(ex, "GetHistoryNoCountWithMultipleIds", ErrorCategory.InvalidArgument, _count));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 66215, 67311);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 66215, 67311);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 67117, 67134);

                            long
                            id = _id[0]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 67156, 67223);

                            f_1460_67156_67222(id > 0, "ValidateRangeAttribute should not allow this");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 67245, 67292);

                            f_1460_67245_67291(this, id, _count, null, _newest);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 66215, 67311);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 64782, 67311);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 64679, 68105);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 64679, 68105);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 67480, 68090) || true) && (_countParameterSpecified == false)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 67480, 68090);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 67559, 67641);

                        string
                        message = f_1460_67576_67640(f_1460_67594_67628(), "Warning")
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 67770, 67877) || true) && (!f_1460_67775_67797(this, message))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 67770, 67877);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 67847, 67854);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 67770, 67877);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 67901, 67943);

                        f_1460_67901_67942(this, 0, -1, null, _newest);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 67480, 68090);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 67480, 68090);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 68025, 68071);

                        f_1460_68025_68070(this, 0, _count, null, _newest);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 67480, 68090);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 64679, 68105);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1460, 63954, 68116);

                int
                f_1460_64042_64047()
                {
                    var return_v = Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 64042, 64047);
                    return return_v;
                }


                string
                f_1460_64188_64244(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 64188, 64244);
                    return return_v;
                }


                System.ArgumentException
                f_1460_64120_64266(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 64120, 64266);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1460_64347_64583(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, int
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 64347, 64583);
                    return return_v;
                }


                int
                f_1460_64285_64602(Microsoft.PowerShell.Commands.ClearHistoryCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 64285, 64602);
                    return 0;
                }


                int
                f_1460_65004_65070(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 65004, 65070);
                    return 0;
                }


                Microsoft.PowerShell.Commands.HistoryInfo
                f_1460_65117_65138(Microsoft.PowerShell.Commands.History
                this_param, long
                id)
                {
                    var return_v = this_param.GetEntry(id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 65117, 65138);
                    return return_v;
                }


                long
                f_1460_65186_65194(Microsoft.PowerShell.Commands.HistoryInfo
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 65186, 65194);
                    return return_v;
                }


                long
                f_1460_65278_65286(Microsoft.PowerShell.Commands.HistoryInfo
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 65278, 65286);
                    return return_v;
                }


                int
                f_1460_65258_65287(Microsoft.PowerShell.Commands.History
                this_param, long
                id)
                {
                    this_param.ClearEntry(id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 65258, 65287);
                    return 0;
                }


                string
                f_1460_65618_65647()
                {
                    var return_v = HistoryStrings.NoHistoryForId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 65618, 65647);
                    return return_v;
                }


                string
                f_1460_65600_65652(string
                formatSpec, long
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 65600, 65652);
                    return return_v;
                }


                System.ArgumentException
                f_1460_65506_65687(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 65506, 65687);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1460_65793_66091(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, long
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 65793, 66091);
                    return return_v;
                }


                int
                f_1460_65718_66122(Microsoft.PowerShell.Commands.ClearHistoryCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 65718, 66122);
                    return 0;
                }


                int[]
                f_1460_64951_64954_I(int[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 64951, 64954);
                    return return_v;
                }


                int
                f_1460_66219_66229(int[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 66219, 66229);
                    return return_v;
                }


                string
                f_1460_66470_66507()
                {
                    var return_v = HistoryStrings.NoCountWithMultipleIds;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 66470, 66507);
                    return return_v;
                }


                string
                f_1460_66452_66508(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 66452, 66508);
                    return return_v;
                }


                System.ArgumentException
                f_1460_66374_66535(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 66374, 66535);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1460_66630_66893(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, int
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 66630, 66893);
                    return return_v;
                }


                int
                f_1460_66560_66916(Microsoft.PowerShell.Commands.ClearHistoryCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 66560, 66916);
                    return 0;
                }


                int
                f_1460_67156_67222(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 67156, 67222);
                    return 0;
                }


                int
                f_1460_67245_67291(Microsoft.PowerShell.Commands.ClearHistoryCommand
                this_param, long
                id, int
                count, string
                cmdline, System.Management.Automation.SwitchParameter
                newest)
                {
                    this_param.ClearHistoryEntries(id, count, cmdline, newest);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 67245, 67291);
                    return 0;
                }


                string
                f_1460_67594_67628()
                {
                    var return_v = HistoryStrings.ClearHistoryWarning;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 67594, 67628);
                    return return_v;
                }


                string
                f_1460_67576_67640(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 67576, 67640);
                    return return_v;
                }


                bool
                f_1460_67775_67797(Microsoft.PowerShell.Commands.ClearHistoryCommand
                this_param, string
                target)
                {
                    var return_v = this_param.ShouldProcess(target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 67775, 67797);
                    return return_v;
                }


                int
                f_1460_67901_67942(Microsoft.PowerShell.Commands.ClearHistoryCommand
                this_param, int
                id, int
                count, string
                cmdline, System.Management.Automation.SwitchParameter
                newest)
                {
                    this_param.ClearHistoryEntries((long)id, count, cmdline, newest);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 67901, 67942);
                    return 0;
                }


                int
                f_1460_68025_68070(Microsoft.PowerShell.Commands.ClearHistoryCommand
                this_param, int
                id, int
                count, string
                cmdline, System.Management.Automation.SwitchParameter
                newest)
                {
                    this_param.ClearHistoryEntries((long)id, count, cmdline, newest);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 68025, 68070);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 63954, 68116);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 63954, 68116);
            }
        }

        private void ClearHistoryByCmdLine()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1460, 68324, 70443);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 68445, 69050) || true) && (_countParameterSpecified && (DynAbs.Tracing.TraceSender.Expression_True(1460, 68449, 68486) && f_1460_68477_68482() < 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 68445, 69050);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 68520, 68697);

                    Exception
                    ex =
                    f_1460_68555_68696(f_1460_68623_68674(f_1460_68641_68673()))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 68717, 69035);

                    f_1460_68717_69034(this, f_1460_68779_69015(ex, "ClearHistoryInvalidCountValue", ErrorCategory.InvalidArgument, _count));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 68445, 69050);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 69111, 70432) || true) && (_commandline != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 69111, 70432);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 69223, 70417) || true) && (!_countParameterSpecified)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 69223, 70417);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 69294, 69442);
                            foreach (string cmd in f_1460_69317_69329_I(_commandline))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 69294, 69442);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 69379, 69419);

                                f_1460_69379_69418(this, 0, 1, cmd, _newest);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 69294, 69442);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1460, 1, 149);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1460, 1, 149);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 69223, 70417);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 69223, 70417);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 69484, 70417) || true) && (f_1460_69488_69507(_commandline) > 1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 69484, 70417);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 69610, 69816);

                            Exception
                            ex =
                            f_1460_69650_69815(f_1460_69728_69788(f_1460_69746_69787()))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 69840, 70198);

                            f_1460_69840_70197(this, f_1460_69910_70174(ex, "NoCountWithMultipleCmdLine ", ErrorCategory.InvalidArgument, _commandline));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 69484, 70417);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 69484, 70417);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 70341, 70398);

                            f_1460_70341_70397(this, 0, _count, _commandline[0], _newest);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 69484, 70417);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 69223, 70417);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 69111, 70432);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1460, 68324, 70443);

                int
                f_1460_68477_68482()
                {
                    var return_v = Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 68477, 68482);
                    return return_v;
                }


                string
                f_1460_68641_68673()
                {
                    var return_v = HistoryStrings.InvalidCountValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 68641, 68673);
                    return return_v;
                }


                string
                f_1460_68623_68674(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 68623, 68674);
                    return return_v;
                }


                System.ArgumentException
                f_1460_68555_68696(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 68555, 68696);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1460_68779_69015(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, int
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 68779, 69015);
                    return return_v;
                }


                int
                f_1460_68717_69034(Microsoft.PowerShell.Commands.ClearHistoryCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 68717, 69034);
                    return 0;
                }


                int
                f_1460_69379_69418(Microsoft.PowerShell.Commands.ClearHistoryCommand
                this_param, int
                id, int
                count, string
                cmdline, System.Management.Automation.SwitchParameter
                newest)
                {
                    this_param.ClearHistoryEntries((long)id, count, cmdline, newest);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 69379, 69418);
                    return 0;
                }


                string[]
                f_1460_69317_69329_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 69317, 69329);
                    return return_v;
                }


                int
                f_1460_69488_69507(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 69488, 69507);
                    return return_v;
                }


                string
                f_1460_69746_69787()
                {
                    var return_v = HistoryStrings.NoCountWithMultipleCmdLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 69746, 69787);
                    return return_v;
                }


                string
                f_1460_69728_69788(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 69728, 69788);
                    return return_v;
                }


                System.ArgumentException
                f_1460_69650_69815(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 69650, 69815);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1460_69910_70174(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, string[]
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 69910, 70174);
                    return return_v;
                }


                int
                f_1460_69840_70197(Microsoft.PowerShell.Commands.ClearHistoryCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 69840, 70197);
                    return 0;
                }


                int
                f_1460_70341_70397(Microsoft.PowerShell.Commands.ClearHistoryCommand
                this_param, int
                id, int
                count, string
                cmdline, System.Management.Automation.SwitchParameter
                newest)
                {
                    this_param.ClearHistoryEntries((long)id, count, cmdline, newest);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 70341, 70397);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 68324, 70443);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 68324, 70443);
            }
        }

        private void ClearHistoryEntries(long id, int count, string cmdline, SwitchParameter newest)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1460, 70897, 73268);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 71083, 72994) || true) && (cmdline == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 71083, 72994);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 71202, 72314) || true) && (id > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 71202, 72314);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 71254, 71296);

                        HistoryInfo
                        entry = f_1460_71274_71295(_history, id)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 71318, 72063) || true) && (entry == null || (DynAbs.Tracing.TraceSender.Expression_False(1460, 71322, 71353) || f_1460_71339_71347(entry) != id))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 71318, 72063);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 71403, 71645);

                            Exception
                            ex =
                            f_1460_71454_71644(f_1460_71554_71606(f_1460_71572_71601(), id))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 71671, 72040);

                            f_1460_71671_72039(this, f_1460_71738_72012(ex, "GetHistoryNoHistoryForId", ErrorCategory.ObjectNotFound, id));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 71318, 72063);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 72087, 72137);

                        _entries = f_1460_72098_72136(_history, id, count, newest);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 71202, 72314);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 71202, 72314);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 72246, 72295);

                        _entries = f_1460_72257_72294(_history, 0, count, newest);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 71202, 72314);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 71083, 72994);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 71083, 72994);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 72428, 72519);

                    WildcardPattern
                    wildcardpattern = f_1460_72462_72518(cmdline, WildcardOptions.IgnoreCase)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 72593, 72748) || true) && (!_countParameterSpecified && (DynAbs.Tracing.TraceSender.Expression_True(1460, 72597, 72677) && f_1460_72626_72677(cmdline)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 72593, 72748);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 72719, 72729);

                        count = 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 72593, 72748);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 72916, 72979);

                    _entries = f_1460_72927_72978(_history, wildcardpattern, count, newest);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 71083, 72994);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 73051, 73234);
                    foreach (HistoryInfo entry in f_1460_73081_73089_I(_entries))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 73051, 73234);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 73123, 73219) || true) && (entry != null && (DynAbs.Tracing.TraceSender.Expression_True(1460, 73127, 73166) && f_1460_73144_73157(entry) == false))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1460, 73123, 73219);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 73189, 73219);

                            f_1460_73189_73218(_history, f_1460_73209_73217(entry));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 73123, 73219);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1460, 73051, 73234);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1460, 1, 184);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1460, 1, 184);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 73250, 73257);

                return;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1460, 70897, 73268);

                Microsoft.PowerShell.Commands.HistoryInfo
                f_1460_71274_71295(Microsoft.PowerShell.Commands.History
                this_param, long
                id)
                {
                    var return_v = this_param.GetEntry(id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 71274, 71295);
                    return return_v;
                }


                long
                f_1460_71339_71347(Microsoft.PowerShell.Commands.HistoryInfo
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 71339, 71347);
                    return return_v;
                }


                string
                f_1460_71572_71601()
                {
                    var return_v = HistoryStrings.NoHistoryForId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 71572, 71601);
                    return return_v;
                }


                string
                f_1460_71554_71606(string
                formatSpec, long
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 71554, 71606);
                    return return_v;
                }


                System.ArgumentException
                f_1460_71454_71644(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 71454, 71644);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1460_71738_72012(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, long
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 71738, 72012);
                    return return_v;
                }


                int
                f_1460_71671_72039(Microsoft.PowerShell.Commands.ClearHistoryCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 71671, 72039);
                    return 0;
                }


                Microsoft.PowerShell.Commands.HistoryInfo[]
                f_1460_72098_72136(Microsoft.PowerShell.Commands.History
                this_param, long
                id, int
                count, System.Management.Automation.SwitchParameter
                newest)
                {
                    var return_v = this_param.GetEntries(id, (long)count, newest);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 72098, 72136);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.HistoryInfo[]
                f_1460_72257_72294(Microsoft.PowerShell.Commands.History
                this_param, int
                id, int
                count, System.Management.Automation.SwitchParameter
                newest)
                {
                    var return_v = this_param.GetEntries((long)id, (long)count, newest);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 72257, 72294);
                    return return_v;
                }


                System.Management.Automation.WildcardPattern
                f_1460_72462_72518(string
                pattern, System.Management.Automation.WildcardOptions
                options)
                {
                    var return_v = WildcardPattern.Get(pattern, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 72462, 72518);
                    return return_v;
                }


                bool
                f_1460_72626_72677(string
                pattern)
                {
                    var return_v = WildcardPattern.ContainsWildcardCharacters(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 72626, 72677);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.HistoryInfo[]
                f_1460_72927_72978(Microsoft.PowerShell.Commands.History
                this_param, System.Management.Automation.WildcardPattern
                wildcardpattern, int
                count, System.Management.Automation.SwitchParameter
                newest)
                {
                    var return_v = this_param.GetEntries(wildcardpattern, (long)count, newest);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 72927, 72978);
                    return return_v;
                }


                bool
                f_1460_73144_73157(Microsoft.PowerShell.Commands.HistoryInfo
                this_param)
                {
                    var return_v = this_param.Cleared;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 73144, 73157);
                    return return_v;
                }


                long
                f_1460_73209_73217(Microsoft.PowerShell.Commands.HistoryInfo
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1460, 73209, 73217);
                    return return_v;
                }


                int
                f_1460_73189_73218(Microsoft.PowerShell.Commands.History
                this_param, long
                id)
                {
                    this_param.ClearEntry(id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 73189, 73218);
                    return 0;
                }


                Microsoft.PowerShell.Commands.HistoryInfo[]
                f_1460_73081_73089_I(Microsoft.PowerShell.Commands.HistoryInfo[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1460, 73081, 73089);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1460, 70897, 73268);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 70897, 73268);
            }
        }

        private History _history;

        private HistoryInfo[] _entries;

        public ClearHistoryCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1460, 59235, 73548);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 60349, 60352);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 61083, 61102);
            this._commandline = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 61757, 61768);
            this._count = 32;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 61919, 61951);
            this._countParameterSpecified = false;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 73369, 73377);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1460, 73502, 73510);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1460, 59235, 73548);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 59235, 73548);
        }


        static ClearHistoryCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1460, 59235, 73548);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1460, 59235, 73548);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1460, 59235, 73548);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1460, 59235, 73548);
    }
}

