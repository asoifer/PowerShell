// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Management.Automation;
using System.Management.Automation.Internal;
using System.Management.Automation.Remoting;
using System.Management.Automation.Remoting.Internal;
using System.Management.Automation.Runspaces;
using System.Management.Automation.Tracing;
using System.Threading;

using Dbg = System.Management.Automation.Diagnostics;

// Stops compiler from warning about unknown warnings
#pragma warning disable 1634, 1691

namespace Microsoft.PowerShell.Commands
{
    [Cmdlet(VerbsCommunications.Receive, "Job", DefaultParameterSetName = ReceiveJobCommand.LocationParameterSet,
            HelpUri = "https://go.microsoft.com/fwlink/?LinkID=2096965", RemotingCapability = RemotingCapability.SupportedByCommand)]
    public class ReceiveJobCommand : JobCmdletBase, IDisposable
    {
        [Parameter(Position = 0,
                           Mandatory = true,
                           ValueFromPipeline = true,
                           ValueFromPipelineByPropertyName = true,
                           ParameterSetName = ReceiveJobCommand.ComputerNameParameterSet)]
        [Parameter(Position = 0,
                           Mandatory = true,
                           ValueFromPipeline = true,
                           ValueFromPipelineByPropertyName = true,
                           ParameterSetName = ReceiveJobCommand.SessionParameterSet)]
        [Parameter(Position = 0,
                           Mandatory = true,
                           ValueFromPipeline = true,
                           ValueFromPipelineByPropertyName = true,
                           ParameterSetName = ReceiveJobCommand.LocationParameterSet)]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public Job[] Job
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 3861, 3925);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 3897, 3910);

                    return _jobs;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 3861, 3925);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 2949, 4017);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 2949, 4017);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 3941, 4006);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 3977, 3991);

                    _jobs = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 3941, 4006);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 2949, 4017);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 2949, 4017);
                }
            }
        }

        private Job[] _jobs;

        [Parameter(ValueFromPipelineByPropertyName = true,
                           ParameterSetName = ReceiveJobCommand.ComputerNameParameterSet,
                           Position = 1)]
        [Alias("Cn")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [ValidateNotNullOrEmpty]
        public string[] ComputerName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 4581, 4654);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 4617, 4639);

                    return _computerNames;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 4581, 4654);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 4199, 4755);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 4199, 4755);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 4670, 4744);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 4706, 4729);

                    _computerNames = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 4670, 4744);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 4199, 4755);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 4199, 4755);
                }
            }
        }

        private string[] _computerNames;

        [Parameter(ParameterSetName = ReceiveJobCommand.LocationParameterSet,
                           Position = 1)]
        [ValidateNotNullOrEmpty]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public string[] Location
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 5307, 5376);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 5343, 5361);

                    return _locations;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 5307, 5376);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 5016, 5473);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 5016, 5473);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 5392, 5462);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 5428, 5447);

                    _locations = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 5392, 5462);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 5016, 5473);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 5016, 5473);
                }
            }
        }

        private string[] _locations;

        [Parameter(ValueFromPipelineByPropertyName = true,
                           ParameterSetName = ReceiveJobCommand.SessionParameterSet,
                           Position = 1)]
        [ValidateNotNull]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public PSSession[] Session
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 5997, 6076);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 6033, 6061);

                    return _remoteRunspaceInfos;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 5997, 6076);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 5652, 6183);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 5652, 6183);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 6092, 6172);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 6128, 6157);

                    _remoteRunspaceInfos = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 6092, 6172);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 5652, 6183);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 5652, 6183);
                }
            }
        }

        private PSSession[] _remoteRunspaceInfos;

        [Parameter()]
        public SwitchParameter Keep
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 6502, 6568);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 6538, 6553);

                    return !_flush;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 6502, 6568);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 6427, 6695);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 6427, 6695);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 6584, 6684);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 6620, 6636);

                    _flush = !value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 6654, 6669);

                    f_1604_6654_6668(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 6584, 6684);

                    int
                    f_1604_6654_6668(Microsoft.PowerShell.Commands.ReceiveJobCommand
                    this_param)
                    {
                        this_param.ValidateWait();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 6654, 6668);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 6427, 6695);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 6427, 6695);
                }
            }
        }

        private bool _flush;

        [Parameter()]
        public SwitchParameter NoRecurse
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 6873, 6941);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 6909, 6926);

                    return !_recurse;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 6873, 6941);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 6793, 7037);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 6793, 7037);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 6957, 7026);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 6993, 7011);

                    _recurse = !value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 6957, 7026);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 6793, 7037);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 6793, 7037);
                }
            }
        }

        private bool _recurse;

        [Parameter()]
        public SwitchParameter Force
        { get; set; }

        public override JobState State
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 7325, 7403);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 7361, 7388);

                    return JobState.NotStarted;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 7325, 7403);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 7270, 7414);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 7270, 7414);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Hashtable Filter
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 7530, 7550);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 7536, 7548);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 7530, 7550);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 7473, 7561);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 7473, 7561);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string[] Command
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 7677, 7740);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 7713, 7725);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 7677, 7740);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 7620, 7751);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 7620, 7751);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected const string
        LocationParameterSet = "Location"
        ;

        [Parameter()]
        public SwitchParameter Wait
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 8001, 8065);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 8037, 8050);

                    return _wait;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 8001, 8065);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 7926, 8190);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 7926, 8190);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 8081, 8179);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 8117, 8131);

                    _wait = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 8149, 8164);

                    f_1604_8149_8163(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 8081, 8179);

                    int
                    f_1604_8149_8163(Microsoft.PowerShell.Commands.ReceiveJobCommand
                    this_param)
                    {
                        this_param.ValidateWait();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 8149, 8163);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 7926, 8190);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 7926, 8190);
                }
            }
        }

        [Parameter()]
        public SwitchParameter AutoRemoveJob
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 8333, 8406);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 8369, 8391);

                    return _autoRemoveJob;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 8333, 8406);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 8249, 8507);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 8249, 8507);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 8422, 8496);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 8458, 8481);

                    _autoRemoveJob = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 8422, 8496);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 8249, 8507);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 8249, 8507);
                }
            }
        }

        [Parameter()]
        public SwitchParameter WriteEvents
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 8648, 8688);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 8654, 8686);

                    return _writeStateChangedEvents;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 8648, 8688);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 8566, 8799);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 8566, 8799);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 8704, 8788);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 8740, 8773);

                    _writeStateChangedEvents = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 8704, 8788);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 8566, 8799);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 8566, 8799);
                }
            }
        }

        [Parameter()]
        public SwitchParameter WriteJobInResults
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 8946, 8977);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 8952, 8975);

                    return _outputJobFirst;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 8946, 8977);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 8858, 9079);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 8858, 9079);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 8993, 9068);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 9029, 9053);

                    _outputJobFirst = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 8993, 9068);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 8858, 9079);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 8858, 9079);
                }
            }
        }

        private bool _autoRemoveJob;

        private bool _writeStateChangedEvents;

        private bool _wait;

        private bool _isStopping;

        private bool _isDisposed;

        private readonly ReaderWriterLockSlim _resultsReaderWriterLock;

        private readonly PowerShellTraceSource _tracer;

        private readonly ManualResetEvent _writeExistingData;

        private readonly PSDataCollection<PSStreamObject> _results;

        private bool _holdingResultsRef;

        private readonly List<Job> _jobsBeingAggregated;

        private readonly List<Guid> _jobsSpecifiedInParameters;

        private readonly object _syncObject;

        private bool _outputJobFirst;

        private OutputProcessingState _outputProcessingNotification;

        private bool _processingOutput;

        private const string
        ClassNameTrace = "ReceiveJobCommand"
        ;

        protected override void BeginProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 10279, 10485);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 10345, 10366);

                f_1604_10345_10365(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 10380, 10408);

                f_1604_10380_10407(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 10422, 10444);

                f_1604_10422_10443(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 10458, 10474);

                f_1604_10458_10473(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 10279, 10485);

                int
                f_1604_10345_10365(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param)
                {
                    this_param.ValidateAutoRemove();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 10345, 10365);
                    return 0;
                }


                int
                f_1604_10380_10407(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param)
                {
                    this_param.ValidateWriteJobInResults();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 10380, 10407);
                    return 0;
                }


                int
                f_1604_10422_10443(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param)
                {
                    this_param.ValidateWriteEvents();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 10422, 10443);
                    return 0;
                }


                int
                f_1604_10458_10473(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param)
                {
                    this_param.ValidateForce();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 10458, 10473);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 10279, 10485);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 10279, 10485);
            }
        }

        protected override void ProcessRecord()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 10633, 19217);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 10697, 10726);

                bool
                checkForRecurse = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 10740, 10780);

                List<Job>
                jobsToWrite = f_1604_10764_10779()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 10796, 16263);

                switch (f_1604_10804_10820())
                {

                    case SessionParameterSet:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 10796, 16263);
                        {
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 10928, 12216);
                                foreach (Job job in f_1604_10948_10953_I(_jobs))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 10928, 12216);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 11011, 11099);

                                    PSRemotingJob
                                    remoteJob =
                                                                            job as PSRemotingJob
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 11131, 11615) || true) && (remoteJob == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 11131, 11615);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 11218, 11296);

                                        string
                                        message = f_1604_11235_11295(this, f_1604_11246_11294())
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 11332, 11539);

                                        f_1604_11332_11538(this, f_1604_11343_11537(f_1604_11359_11389(message), "RunspaceParameterNotSupported", ErrorCategory.InvalidArgument, job));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 11575, 11584);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 11131, 11615);
                                    }
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 11741, 12189);
                                        foreach (PSSession remoteRunspaceInfo in f_1604_11782_11802_I(_remoteRunspaceInfos))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 11741, 12189);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 11932, 12003);

                                            List<Job>
                                            childJobs = f_1604_11954_12002(remoteJob, remoteRunspaceInfo)
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 12037, 12069);

                                            f_1604_12037_12068(jobsToWrite, childJobs);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 11741, 12189);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1604, 1, 449);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(1604, 1, 449);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 10928, 12216);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1604, 1, 1289);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1604, 1, 1289);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1604, 12263, 12269);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 10796, 16263);

                    case ComputerNameParameterSet:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 10796, 16263);
                        {
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 12368, 13918);
                                foreach (Job job in f_1604_12388_12393_I(_jobs))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 12368, 13918);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 12535, 12623);

                                    PSRemotingJob
                                    remoteJob =
                                                                            job as PSRemotingJob
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 12746, 13238) || true) && (remoteJob == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 12746, 13238);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 12833, 12915);

                                        string
                                        message = f_1604_12850_12914(this, f_1604_12861_12913())
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 12951, 13162);

                                        f_1604_12951_13161(this, f_1604_12962_13160(f_1604_12978_13008(message), "ComputerNameParameterNotSupported", ErrorCategory.InvalidArgument, job));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 13198, 13207);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 12746, 13238);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 13270, 13308);

                                    string[]
                                    resolvedComputernames = null
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 13338, 13402);

                                    f_1604_13338_13401(this, _computerNames, out resolvedComputernames);
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 13434, 13891);
                                        foreach (string resolvedComputerName in f_1604_13474_13495_I(resolvedComputernames))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 13434, 13891);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 13632, 13705);

                                            List<Job>
                                            childJobs = f_1604_13654_13704(remoteJob, resolvedComputerName)
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 13739, 13771);

                                            f_1604_13739_13770(jobsToWrite, childJobs);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 13434, 13891);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1604, 1, 458);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(1604, 1, 458);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 12368, 13918);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1604, 1, 1551);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1604, 1, 1551);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1604, 13965, 13971);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 10796, 16263);

                    case "Location":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 10796, 16263);
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 14056, 14962) || true) && (_locations == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 14056, 14962);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 14180, 14208);

                                f_1604_14180_14207(                            // WriteAll();
                                                            jobsToWrite, _jobs);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 14238, 14261);

                                checkForRecurse = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 14056, 14962);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 14056, 14962);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 14375, 14935);
                                    foreach (Job job in f_1604_14395_14400_I(_jobs))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 14375, 14935);
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 14466, 14904);
                                            foreach (string location in f_1604_14494_14504_I(_locations))
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 14466, 14904);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 14653, 14708);

                                                List<Job>
                                                childJobs = f_1604_14675_14707(job, location)
                                                ;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 14746, 14778);

                                                f_1604_14746_14777(jobsToWrite, childJobs);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 14466, 14904);
                                            }
                                        }
                                        catch (System.Exception)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1604, 1, 439);
                                            throw;
                                        }
                                        finally
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoop(1604, 1, 439);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 14375, 14935);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1604, 1, 561);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1604, 1, 561);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 14056, 14962);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1604, 15009, 15015);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 10796, 16263);

                    case ReceiveJobCommand.InstanceIdParameterSet:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 10796, 16263);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 15130, 15202);

                            List<Job>
                            jobs = f_1604_15147_15201(this, true, false, true, false)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 15230, 15257);

                            f_1604_15230_15256(
                                                    jobsToWrite, jobs);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 15283, 15306);

                            checkForRecurse = true;
                            // WriteResultsForJobsInCollection(jobs, true);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1604, 15426, 15432);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 10796, 16263);

                    case ReceiveJobCommand.SessionIdParameterSet:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 10796, 16263);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 15546, 15617);

                            List<Job>
                            jobs = f_1604_15563_15616(this, true, false, true, false)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 15643, 15670);

                            f_1604_15643_15669(jobsToWrite, jobs);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 15696, 15719);

                            checkForRecurse = true;
                            // WriteResultsForJobsInCollection(jobs, true);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1604, 15839, 15845);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 10796, 16263);

                    case ReceiveJobCommand.NameParameterSet:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 10796, 16263);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 15954, 16020);

                            List<Job>
                            jobs = f_1604_15971_16019(this, true, false, true, false)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 16046, 16073);

                            f_1604_16046_16072(jobsToWrite, jobs);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 16099, 16122);

                            checkForRecurse = true;
                            // WriteResultsForJobsInCollection(jobs, true);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1604, 16242, 16248);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 10796, 16263);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 16463, 19206) || true) && (_wait)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 16463, 19206);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 16506, 16533);

                    f_1604_16506_16532(_writeExistingData);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 16819, 16852);

                    f_1604_16819_16851(this, jobsToWrite);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 17064, 17203);
                        foreach (var job in f_1604_17084_17095_I(jobsToWrite))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 17064, 17203);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 17137, 17184);

                            f_1604_17137_17183(_jobsSpecifiedInParameters, f_1604_17168_17182(job));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 17064, 17203);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1604, 1, 140);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1604, 1, 140);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 17229, 17240);

                    lock (_syncObject)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 17282, 17321) || true) && (_isDisposed || (DynAbs.Tracing.TraceSender.Expression_False(1604, 17286, 17312) || _isStopping))
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 17282, 17321);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 17314, 17321);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 17282, 17321);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 17486, 17823) || true) && (!_holdingResultsRef)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 17486, 17823);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 17559, 17704);

                            f_1604_17559_17703(_tracer, ClassNameTrace, "ProcessRecord", Guid.Empty, null, "Adding Ref to results collection", null);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 17730, 17748);

                            f_1604_17730_17747(_results);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 17774, 17800);

                            _holdingResultsRef = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 17486, 17823);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 17862, 17966);

                    f_1604_17862_17965(
                                    _tracer, ClassNameTrace, "ProcessRecord", Guid.Empty, null, "BEGIN Register for jobs");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 17984, 18052);

                    f_1604_17984_18051(this, jobsToWrite, checkForRecurse, true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 18070, 18172);

                    f_1604_18070_18171(_tracer, ClassNameTrace, "ProcessRecord", Guid.Empty, null, "END Register for jobs");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 18198, 18209);

                    lock (_syncObject)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 18251, 18651) || true) && (f_1604_18255_18281(_jobsBeingAggregated) == 0 && (DynAbs.Tracing.TraceSender.Expression_True(1604, 18255, 18308) && _holdingResultsRef))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 18251, 18651);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 18358, 18525);

                            f_1604_18358_18524(_tracer, ClassNameTrace, "ProcessRecord", Guid.Empty, null, "Removing Ref to results collection", null);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 18551, 18575);

                            f_1604_18551_18574(_results);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 18601, 18628);

                            _holdingResultsRef = false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 18251, 18651);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 18690, 18800);

                    f_1604_18690_18799(
                                    _tracer, ClassNameTrace, "ProcessRecord", Guid.Empty, null, "BEGIN Write existing job data");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 18818, 18887);

                    f_1604_18818_18886(this, jobsToWrite, checkForRecurse, false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 18905, 19013);

                    f_1604_18905_19012(_tracer, ClassNameTrace, "ProcessRecord", Guid.Empty, null, "END Write existing job data");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 19031, 19056);

                    f_1604_19031_19055(_writeExistingData);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 16463, 19206);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 16463, 19206);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 19122, 19191);

                    f_1604_19122_19190(this, jobsToWrite, checkForRecurse, false);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 16463, 19206);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 10633, 19217);

                System.Collections.Generic.List<System.Management.Automation.Job>
                f_1604_10764_10779()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.Job>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 10764, 10779);
                    return return_v;
                }


                string
                f_1604_10804_10820()
                {
                    var return_v = ParameterSetName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 10804, 10820);
                    return return_v;
                }


                string
                f_1604_11246_11294()
                {
                    var return_v = RemotingErrorIdStrings.RunspaceParamNotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 11246, 11294);
                    return return_v;
                }


                string
                f_1604_11235_11295(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, string
                resourceString)
                {
                    var return_v = this_param.GetMessage(resourceString);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 11235, 11295);
                    return return_v;
                }


                System.ArgumentException
                f_1604_11359_11389(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 11359, 11389);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1604_11343_11537(System.ArgumentException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.Job
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 11343, 11537);
                    return return_v;
                }


                int
                f_1604_11332_11538(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 11332, 11538);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.Job>
                f_1604_11954_12002(System.Management.Automation.PSRemotingJob
                this_param, System.Management.Automation.Runspaces.PSSession
                runspace)
                {
                    var return_v = this_param.GetJobsForRunspace(runspace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 11954, 12002);
                    return return_v;
                }


                int
                f_1604_12037_12068(System.Collections.Generic.List<System.Management.Automation.Job>
                this_param, System.Collections.Generic.List<System.Management.Automation.Job>
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<System.Management.Automation.Job>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 12037, 12068);
                    return 0;
                }


                System.Management.Automation.Runspaces.PSSession[]
                f_1604_11782_11802_I(System.Management.Automation.Runspaces.PSSession[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 11782, 11802);
                    return return_v;
                }


                System.Management.Automation.Job[]
                f_1604_10948_10953_I(System.Management.Automation.Job[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 10948, 10953);
                    return return_v;
                }


                string
                f_1604_12861_12913()
                {
                    var return_v = RemotingErrorIdStrings.ComputerNameParamNotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 12861, 12913);
                    return return_v;
                }


                string
                f_1604_12850_12914(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, string
                resourceString)
                {
                    var return_v = this_param.GetMessage(resourceString);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 12850, 12914);
                    return return_v;
                }


                System.ArgumentException
                f_1604_12978_13008(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 12978, 13008);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1604_12962_13160(System.ArgumentException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.Job
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 12962, 13160);
                    return return_v;
                }


                int
                f_1604_12951_13161(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 12951, 13161);
                    return 0;
                }


                int
                f_1604_13338_13401(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, string[]
                computerNames, out string[]
                resolvedComputerNames)
                {
                    this_param.ResolveComputerNames(computerNames, out resolvedComputerNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 13338, 13401);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.Job>
                f_1604_13654_13704(System.Management.Automation.PSRemotingJob
                this_param, string
                computerName)
                {
                    var return_v = this_param.GetJobsForComputer(computerName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 13654, 13704);
                    return return_v;
                }


                int
                f_1604_13739_13770(System.Collections.Generic.List<System.Management.Automation.Job>
                this_param, System.Collections.Generic.List<System.Management.Automation.Job>
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<System.Management.Automation.Job>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 13739, 13770);
                    return 0;
                }


                string[]
                f_1604_13474_13495_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 13474, 13495);
                    return return_v;
                }


                System.Management.Automation.Job[]
                f_1604_12388_12393_I(System.Management.Automation.Job[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 12388, 12393);
                    return return_v;
                }


                int
                f_1604_14180_14207(System.Collections.Generic.List<System.Management.Automation.Job>
                this_param, System.Management.Automation.Job[]
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<System.Management.Automation.Job>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 14180, 14207);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.Job>
                f_1604_14675_14707(System.Management.Automation.Job
                this_param, string
                location)
                {
                    var return_v = this_param.GetJobsForLocation(location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 14675, 14707);
                    return return_v;
                }


                int
                f_1604_14746_14777(System.Collections.Generic.List<System.Management.Automation.Job>
                this_param, System.Collections.Generic.List<System.Management.Automation.Job>
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<System.Management.Automation.Job>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 14746, 14777);
                    return 0;
                }


                string[]
                f_1604_14494_14504_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 14494, 14504);
                    return return_v;
                }


                System.Management.Automation.Job[]
                f_1604_14395_14400_I(System.Management.Automation.Job[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 14395, 14400);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Job>
                f_1604_15147_15201(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, bool
                recurse, bool
                writeobject, bool
                writeErrorOnNoMatch, bool
                checkIfJobCanBeRemoved)
                {
                    var return_v = this_param.FindJobsMatchingByInstanceId(recurse, writeobject, writeErrorOnNoMatch, checkIfJobCanBeRemoved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 15147, 15201);
                    return return_v;
                }


                int
                f_1604_15230_15256(System.Collections.Generic.List<System.Management.Automation.Job>
                this_param, System.Collections.Generic.List<System.Management.Automation.Job>
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<System.Management.Automation.Job>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 15230, 15256);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.Job>
                f_1604_15563_15616(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, bool
                recurse, bool
                writeobject, bool
                writeErrorOnNoMatch, bool
                checkIfJobCanBeRemoved)
                {
                    var return_v = this_param.FindJobsMatchingBySessionId(recurse, writeobject, writeErrorOnNoMatch, checkIfJobCanBeRemoved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 15563, 15616);
                    return return_v;
                }


                int
                f_1604_15643_15669(System.Collections.Generic.List<System.Management.Automation.Job>
                this_param, System.Collections.Generic.List<System.Management.Automation.Job>
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<System.Management.Automation.Job>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 15643, 15669);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.Job>
                f_1604_15971_16019(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, bool
                recurse, bool
                writeobject, bool
                writeErrorOnNoMatch, bool
                checkIfJobCanBeRemoved)
                {
                    var return_v = this_param.FindJobsMatchingByName(recurse, writeobject, writeErrorOnNoMatch, checkIfJobCanBeRemoved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 15971, 16019);
                    return return_v;
                }


                int
                f_1604_16046_16072(System.Collections.Generic.List<System.Management.Automation.Job>
                this_param, System.Collections.Generic.List<System.Management.Automation.Job>
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<System.Management.Automation.Job>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 16046, 16072);
                    return 0;
                }


                bool
                f_1604_16506_16532(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.Reset();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 16506, 16532);
                    return return_v;
                }


                int
                f_1604_16819_16851(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, System.Collections.Generic.List<System.Management.Automation.Job>
                jobsToWrite)
                {
                    this_param.WriteJobsIfRequired((System.Collections.Generic.IEnumerable<System.Management.Automation.Job>)jobsToWrite);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 16819, 16851);
                    return 0;
                }


                System.Guid
                f_1604_17168_17182(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 17168, 17182);
                    return return_v;
                }


                int
                f_1604_17137_17183(System.Collections.Generic.List<System.Guid>
                this_param, System.Guid
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 17137, 17183);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.Job>
                f_1604_17084_17095_I(System.Collections.Generic.List<System.Management.Automation.Job>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 17084, 17095);
                    return return_v;
                }


                int
                f_1604_17559_17703(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.Job
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 17559, 17703);
                    return 0;
                }


                int
                f_1604_17730_17747(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                this_param)
                {
                    this_param.AddRef();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 17730, 17747);
                    return 0;
                }


                int
                f_1604_17862_17965(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.Job
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 17862, 17965);
                    return 0;
                }


                int
                f_1604_17984_18051(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, System.Collections.Generic.List<System.Management.Automation.Job>
                jobs, bool
                checkForRecurse, bool
                registerInsteadOfWrite)
                {
                    this_param.WriteResultsForJobsInCollection(jobs, checkForRecurse, registerInsteadOfWrite);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 17984, 18051);
                    return 0;
                }


                int
                f_1604_18070_18171(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.Job
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 18070, 18171);
                    return 0;
                }


                int
                f_1604_18255_18281(System.Collections.Generic.List<System.Management.Automation.Job>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 18255, 18281);
                    return return_v;
                }


                int
                f_1604_18358_18524(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.Job
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 18358, 18524);
                    return 0;
                }


                int
                f_1604_18551_18574(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                this_param)
                {
                    this_param.DecrementRef();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 18551, 18574);
                    return 0;
                }


                int
                f_1604_18690_18799(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.Job
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 18690, 18799);
                    return 0;
                }


                int
                f_1604_18818_18886(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, System.Collections.Generic.List<System.Management.Automation.Job>
                jobs, bool
                checkForRecurse, bool
                registerInsteadOfWrite)
                {
                    this_param.WriteResultsForJobsInCollection(jobs, checkForRecurse, registerInsteadOfWrite);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 18818, 18886);
                    return 0;
                }


                int
                f_1604_18905_19012(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.Job
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 18905, 19012);
                    return 0;
                }


                bool
                f_1604_19031_19055(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.Set();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 19031, 19055);
                    return return_v;
                }


                int
                f_1604_19122_19190(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, System.Collections.Generic.List<System.Management.Automation.Job>
                jobs, bool
                checkForRecurse, bool
                registerInsteadOfWrite)
                {
                    this_param.WriteResultsForJobsInCollection(jobs, checkForRecurse, registerInsteadOfWrite);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 19122, 19190);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 10633, 19217);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 10633, 19217);
            }
        }

        protected override void StopProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 19446, 20648);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 19511, 19644);

                f_1604_19511_19643(_tracer, ClassNameTrace, "StopProcessing", Guid.Empty, null, "Entered Stop Processing", null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 19664, 19675);
                lock (_syncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 19709, 19728);

                    _isStopping = true;
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 19759, 19784);

                f_1604_19759_19783(
                            _writeExistingData);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 19798, 19857);

                Job[]
                aggregatedJobs = new Job[f_1604_19829_19855(_jobsBeingAggregated)]
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 19882, 19887);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 19873, 20017) || true) && (i < f_1604_19893_19919(_jobsBeingAggregated))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 19921, 19924)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 19873, 20017))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 19873, 20017);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 19958, 20002);

                        aggregatedJobs[i] = f_1604_19978_20001(_jobsBeingAggregated, i);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1604, 1, 145);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1604, 1, 145);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 20033, 20149);
                    foreach (Job job in f_1604_20053_20067_I(aggregatedJobs))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 20033, 20149);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 20101, 20134);

                        f_1604_20101_20133(this, job);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 20033, 20149);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1604, 1, 117);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1604, 1, 117);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 20165, 20207);

                f_1604_20165_20206(
                            _resultsReaderWriterLock);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 20257, 20277);

                    f_1604_20257_20276(_results);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 20295, 20327);

                    f_1604_20295_20326(this, false);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1604, 20356, 20452);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 20396, 20437);

                    f_1604_20396_20436(_resultsReaderWriterLock);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1604, 20356, 20452);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 20468, 20490);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.StopProcessing(), 1604, 20468, 20489);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 20504, 20637);

                f_1604_20504_20636(_tracer, ClassNameTrace, "StopProcessing", Guid.Empty, null, "Exiting Stop Processing", null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 19446, 20648);

                int
                f_1604_19511_19643(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.Job
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 19511, 19643);
                    return 0;
                }


                bool
                f_1604_19759_19783(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.Set();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 19759, 19783);
                    return return_v;
                }


                int
                f_1604_19829_19855(System.Collections.Generic.List<System.Management.Automation.Job>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 19829, 19855);
                    return return_v;
                }


                int
                f_1604_19893_19919(System.Collections.Generic.List<System.Management.Automation.Job>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 19893, 19919);
                    return return_v;
                }


                System.Management.Automation.Job
                f_1604_19978_20001(System.Collections.Generic.List<System.Management.Automation.Job>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 19978, 20001);
                    return return_v;
                }


                int
                f_1604_20101_20133(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, System.Management.Automation.Job
                job)
                {
                    this_param.StopAggregateResultsFromJob(job);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 20101, 20133);
                    return 0;
                }


                System.Management.Automation.Job[]
                f_1604_20053_20067_I(System.Management.Automation.Job[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 20053, 20067);
                    return return_v;
                }


                int
                f_1604_20165_20206(System.Threading.ReaderWriterLockSlim
                this_param)
                {
                    this_param.EnterWriteLock();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 20165, 20206);
                    return 0;
                }


                int
                f_1604_20257_20276(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                this_param)
                {
                    this_param.Complete();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 20257, 20276);
                    return 0;
                }


                int
                f_1604_20295_20326(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, bool
                processingOutput)
                {
                    this_param.SetOutputProcessingState(processingOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 20295, 20326);
                    return 0;
                }


                int
                f_1604_20396_20436(System.Threading.ReaderWriterLockSlim
                this_param)
                {
                    this_param.ExitWriteLock();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 20396, 20436);
                    return 0;
                }


                int
                f_1604_20504_20636(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.Job
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 20504, 20636);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 19446, 20648);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 19446, 20648);
            }
        }

        protected override void EndProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 20813, 22211);
                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 20913, 22084) || true) && (_wait)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 20913, 22084);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 20964, 20983);

                        int
                        totalCount = 0
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 21005, 21448);
                            foreach (PSStreamObject result in f_1604_21039_21047_I(_results))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 21005, 21448);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 21097, 21120) || true) && (_isStopping)
                                )
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 21097, 21120);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1604, 21114, 21120);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 21097, 21120);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 21148, 21179);

                                f_1604_21148_21178(this, true);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 21205, 21248);

                                f_1604_21205_21247(result, this, true, true);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 21274, 21425) || true) && (++totalCount == f_1604_21294_21308(_results))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 21274, 21425);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 21366, 21398);

                                    f_1604_21366_21397(this, false);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 21274, 21425);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 21005, 21448);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1604, 1, 444);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1604, 1, 444);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 21472, 21498);

                        f_1604_21472_21497(
                                            _eventArgsWritten);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 20913, 22084);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 20913, 22084);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 21580, 21599);

                        int
                        totalCount = 0
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 21621, 22065);
                            foreach (PSStreamObject result in f_1604_21655_21663_I(_results))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 21621, 22065);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 21713, 21736) || true) && (_isStopping)
                                )
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 21713, 21736);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1604, 21730, 21736);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 21713, 21736);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 21764, 21795);

                                f_1604_21764_21794(this, true);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 21821, 21865);

                                f_1604_21821_21864(result, this, false, true);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 21891, 22042) || true) && (++totalCount == f_1604_21911_21925(_results))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 21891, 22042);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 21983, 22015);

                                    f_1604_21983_22014(this, false);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 21891, 22042);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 21621, 22065);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1604, 1, 445);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1604, 1, 445);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 20913, 22084);
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1604, 22113, 22200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 22153, 22185);

                    f_1604_22153_22184(this, false);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1604, 22113, 22200);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 20813, 22211);

                int
                f_1604_21148_21178(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, bool
                processingOutput)
                {
                    this_param.SetOutputProcessingState(processingOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 21148, 21178);
                    return 0;
                }


                int
                f_1604_21205_21247(System.Management.Automation.Remoting.Internal.PSStreamObject
                this_param, Microsoft.PowerShell.Commands.ReceiveJobCommand
                cmdlet, bool
                writeSourceIdentifier, bool
                overrideInquire)
                {
                    this_param.WriteStreamObject((System.Management.Automation.Cmdlet)cmdlet, writeSourceIdentifier, overrideInquire);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 21205, 21247);
                    return 0;
                }


                int
                f_1604_21294_21308(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 21294, 21308);
                    return return_v;
                }


                int
                f_1604_21366_21397(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, bool
                processingOutput)
                {
                    this_param.SetOutputProcessingState(processingOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 21366, 21397);
                    return 0;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                f_1604_21039_21047_I(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 21039, 21047);
                    return return_v;
                }


                int
                f_1604_21472_21497(System.Collections.Generic.Dictionary<System.Guid, bool>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 21472, 21497);
                    return 0;
                }


                int
                f_1604_21764_21794(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, bool
                processingOutput)
                {
                    this_param.SetOutputProcessingState(processingOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 21764, 21794);
                    return 0;
                }


                int
                f_1604_21821_21864(System.Management.Automation.Remoting.Internal.PSStreamObject
                this_param, Microsoft.PowerShell.Commands.ReceiveJobCommand
                cmdlet, bool
                writeSourceIdentifier, bool
                overrideInquire)
                {
                    this_param.WriteStreamObject((System.Management.Automation.Cmdlet)cmdlet, writeSourceIdentifier, overrideInquire);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 21821, 21864);
                    return 0;
                }


                int
                f_1604_21911_21925(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 21911, 21925);
                    return return_v;
                }


                int
                f_1604_21983_22014(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, bool
                processingOutput)
                {
                    this_param.SetOutputProcessingState(processingOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 21983, 22014);
                    return 0;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                f_1604_21655_21663_I(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 21655, 21663);
                    return return_v;
                }


                int
                f_1604_22153_22184(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, bool
                processingOutput)
                {
                    this_param.SetOutputProcessingState(processingOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 22153, 22184);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 20813, 22211);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 20813, 22211);
            }
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 22270, 22381);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 22316, 22330);

                f_1604_22316_22329(this, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 22344, 22370);

                f_1604_22344_22369(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 22270, 22381);

                int
                f_1604_22316_22329(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, bool
                disposing)
                {
                    this_param.Dispose(disposing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 22316, 22329);
                    return 0;
                }


                int
                f_1604_22344_22369(Microsoft.PowerShell.Commands.ReceiveJobCommand
                obj)
                {
                    GC.SuppressFinalize((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 22344, 22369);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 22270, 22381);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 22270, 22381);
            }
        }

        protected void Dispose(bool disposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 22486, 24617);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 22549, 24606) || true) && (disposing)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 22549, 24606);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 22596, 22620) || true) && (_isDisposed)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 22596, 22620);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 22613, 22620);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 22596, 22620);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 22644, 22655);
                    lock (_syncObject)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 22697, 22721) || true) && (_isDisposed)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 22697, 22721);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 22714, 22721);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 22697, 22721);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 22743, 22762);

                        _isDisposed = true;
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 22801, 22833);

                    f_1604_22801_22832(this, false);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 22853, 24085) || true) && (_jobsBeingAggregated != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 22853, 24085);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 22927, 24066);
                            foreach (var job in f_1604_22947_22967_I(_jobsBeingAggregated))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 22927, 24066);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 23017, 23198) || true) && (f_1604_23021_23048(job))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 23017, 23198);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 23106, 23171);

                                    f_1604_23106_23170(job, _outputProcessingNotification);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 23017, 23198);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 23226, 23973) || true) && (f_1604_23230_23255(job))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 23226, 23973);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 23313, 23351);

                                    f_1604_23313_23324(job).DataAdded -= ResultsAdded;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 23226, 23973);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 23226, 23973);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 23465, 23506);

                                    f_1604_23465_23475(job).DataAdded -= Output_DataAdded;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 23536, 23575);

                                    f_1604_23536_23545(job).DataAdded -= Error_DataAdded;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 23605, 23650);

                                    f_1604_23605_23617(job).DataAdded -= Progress_DataAdded;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 23680, 23723);

                                    f_1604_23680_23691(job).DataAdded -= Verbose_DataAdded;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 23753, 23796);

                                    f_1604_23753_23764(job).DataAdded -= Warning_DataAdded;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 23826, 23865);

                                    f_1604_23826_23835(job).DataAdded -= Debug_DataAdded;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 23895, 23946);

                                    f_1604_23895_23910(job).DataAdded -= Information_DataAdded;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 23226, 23973);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 24001, 24043);

                                job.StateChanged -= HandleJobStateChanged;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 22927, 24066);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1604, 1, 1140);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1604, 1, 1140);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 22853, 24085);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 24105, 24147);

                    f_1604_24105_24146(
                                    _resultsReaderWriterLock);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 24209, 24229);

                        f_1604_24209_24228(_results);
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1604, 24266, 24374);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 24314, 24355);

                        f_1604_24314_24354(_resultsReaderWriterLock);
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1604, 24266, 24374);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 24394, 24429);

                    f_1604_24394_24428(
                                    _resultsReaderWriterLock);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 24447, 24464);

                    f_1604_24447_24463(_results);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 24482, 24501);

                    f_1604_24482_24500(_results);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 24519, 24544);

                    f_1604_24519_24543(_writeExistingData);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 24562, 24591);

                    f_1604_24562_24590(_writeExistingData);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 22549, 24606);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 22486, 24617);

                int
                f_1604_22801_22832(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, bool
                processingOutput)
                {
                    this_param.SetOutputProcessingState(processingOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 22801, 22832);
                    return 0;
                }


                bool
                f_1604_23021_23048(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.MonitorOutputProcessing;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 23021, 23048);
                    return return_v;
                }


                int
                f_1604_23106_23170(System.Management.Automation.Job
                this_param, Microsoft.PowerShell.Commands.OutputProcessingState
                outputProcessingState)
                {
                    this_param.RemoveMonitorOutputProcessing((System.Management.Automation.IOutputProcessingState)outputProcessingState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 23106, 23170);
                    return 0;
                }


                bool
                f_1604_23230_23255(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.UsesResultsCollection;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 23230, 23255);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                f_1604_23313_23324(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Results;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 23313, 23324);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                f_1604_23465_23475(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Output;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 23465, 23475);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                f_1604_23536_23545(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Error;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 23536, 23545);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ProgressRecord>
                f_1604_23605_23617(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Progress;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 23605, 23617);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.VerboseRecord>
                f_1604_23680_23691(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Verbose;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 23680, 23691);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.WarningRecord>
                f_1604_23753_23764(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Warning;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 23753, 23764);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.DebugRecord>
                f_1604_23826_23835(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Debug;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 23826, 23835);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.InformationRecord>
                f_1604_23895_23910(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Information;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 23895, 23910);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Job>
                f_1604_22947_22967_I(System.Collections.Generic.List<System.Management.Automation.Job>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 22947, 22967);
                    return return_v;
                }


                int
                f_1604_24105_24146(System.Threading.ReaderWriterLockSlim
                this_param)
                {
                    this_param.EnterWriteLock();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 24105, 24146);
                    return 0;
                }


                int
                f_1604_24209_24228(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                this_param)
                {
                    this_param.Complete();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 24209, 24228);
                    return 0;
                }


                int
                f_1604_24314_24354(System.Threading.ReaderWriterLockSlim
                this_param)
                {
                    this_param.ExitWriteLock();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 24314, 24354);
                    return 0;
                }


                int
                f_1604_24394_24428(System.Threading.ReaderWriterLockSlim
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 24394, 24428);
                    return 0;
                }


                int
                f_1604_24447_24463(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 24447, 24463);
                    return 0;
                }


                int
                f_1604_24482_24500(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 24482, 24500);
                    return 0;
                }


                bool
                f_1604_24519_24543(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.Set();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 24519, 24543);
                    return return_v;
                }


                int
                f_1604_24562_24590(System.Threading.ManualResetEvent
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 24562, 24590);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 22486, 24617);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 22486, 24617);
            }
        }

        private static void DoUnblockJob(Job job)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1604, 24694, 25702);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 24980, 25017) || true) && (f_1604_24984_25003(f_1604_24984_24997(job)) != 0)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 24980, 25017);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 25010, 25017);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 24980, 25017);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 25190, 25254);

                PSRemotingChildJob
                remotingChildJob = job as PSRemotingChildJob
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 25268, 25691) || true) && (remotingChildJob != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 25268, 25691);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 25330, 25360);

                    f_1604_25330_25359(remotingChildJob);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 25268, 25691);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 25268, 25691);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 25636, 25676);

                    f_1604_25636_25675(                // for all other job types, simply set the job state
                                                       // to running, the handling of the parent jobs state
                                                       // should be taken care of by the job implementation
                                    job, JobState.Running, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 25268, 25691);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1604, 24694, 25702);

                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1604_24984_24997(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 24984, 24997);
                    return return_v;
                }


                int
                f_1604_24984_25003(System.Collections.Generic.IList<System.Management.Automation.Job>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 24984, 25003);
                    return return_v;
                }


                int
                f_1604_25330_25359(System.Management.Automation.PSRemotingChildJob
                this_param)
                {
                    this_param.UnblockJob();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 25330, 25359);
                    return 0;
                }


                int
                f_1604_25636_25675(System.Management.Automation.Job
                this_param, System.Management.Automation.JobState
                state, System.Exception
                reason)
                {
                    this_param.SetJobState(state, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 25636, 25675);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 24694, 25702);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 24694, 25702);
            }
        }

        private void WriteJobResults(Job job)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 25988, 31994);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 26050, 26074) || true) && (job == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 26050, 26074);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 26067, 26074);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 26050, 26074);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 26900, 27221) || true) && (f_1604_26904_26926(f_1604_26904_26920(job)) == JobState.Disconnected)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 26900, 27221);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 26985, 27049);

                    PSRemotingChildJob
                    remotingChildJob = job as PSRemotingChildJob
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 27067, 27206) || true) && (remotingChildJob != null && (DynAbs.Tracing.TraceSender.Expression_True(1604, 27071, 27138) && f_1604_27099_27138(remotingChildJob)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 27067, 27206);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 27180, 27187);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 27067, 27206);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 26900, 27221);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 27290, 27403) || true) && (f_1604_27294_27316(f_1604_27294_27310(job)) == JobState.Blocked)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 27290, 27403);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 27370, 27388);

                    f_1604_27370_27387(job);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 27290, 27403);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 27835, 31875) || true) && (!(job is Job2) && (DynAbs.Tracing.TraceSender.Expression_True(1604, 27839, 27882) && f_1604_27857_27882(job)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 27835, 31875);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 27968, 28042);

                    Collection<PSStreamObject>
                    results = f_1604_28005_28041(this, f_1604_28029_28040(job))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 28062, 28536) || true) && (_wait)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 28062, 28536);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 28113, 28285);
                            foreach (var psStreamObject in f_1604_28144_28151_I(results))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 28113, 28285);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 28201, 28262);

                                f_1604_28201_28261(psStreamObject, this, f_1604_28240_28260(f_1604_28240_28251(job)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 28113, 28285);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1604, 1, 173);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1604, 1, 173);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 28062, 28536);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 28062, 28536);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 28367, 28517);
                            foreach (var psStreamObject in f_1604_28398_28405_I(results))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 28367, 28517);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 28455, 28494);

                                f_1604_28455_28493(psStreamObject, this);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 28367, 28517);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1604, 1, 151);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1604, 1, 151);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 28062, 28536);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 27835, 31875);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 27835, 31875);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 28602, 28662);

                    Collection<PSObject>
                    output = f_1604_28632_28661(this, f_1604_28650_28660(job))
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 28682, 28833);
                        foreach (PSObject o in f_1604_28705_28711_I(output))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 28682, 28833);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 28753, 28777) || true) && (o == null)
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 28753, 28777);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 28768, 28777);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 28753, 28777);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 28799, 28814);

                            f_1604_28799_28813(this, o);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 28682, 28833);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1604, 1, 152);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1604, 1, 152);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 28853, 28924);

                    Collection<ErrorRecord>
                    errorRecords = f_1604_28892_28923(this, f_1604_28913_28922(job))
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 28944, 29387);
                        foreach (ErrorRecord e in f_1604_28970_28982_I(errorRecords))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 28944, 29387);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 29024, 29048) || true) && (e == null)
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 29024, 29048);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 29039, 29048);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 29024, 29048);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 29070, 29144);

                            MshCommandRuntime
                            mshCommandRuntime = f_1604_29108_29122() as MshCommandRuntime
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 29166, 29368) || true) && (mshCommandRuntime != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 29166, 29368);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 29245, 29281);

                                e.PreserveInvocationInfoOnce = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 29307, 29345);

                                f_1604_29307_29344(mshCommandRuntime, e, true);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 29166, 29368);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 28944, 29387);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1604, 1, 444);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1604, 1, 444);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 29407, 29471);

                    Collection<VerboseRecord>
                    verboseRecords = f_1604_29450_29470(this, f_1604_29458_29469(job))
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 29491, 29878);
                        foreach (VerboseRecord v in f_1604_29519_29533_I(verboseRecords))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 29491, 29878);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 29575, 29599) || true) && (v == null)
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 29575, 29599);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 29590, 29599);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 29575, 29599);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 29621, 29695);

                            MshCommandRuntime
                            mshCommandRuntime = f_1604_29659_29673() as MshCommandRuntime
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 29717, 29859) || true) && (mshCommandRuntime != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 29717, 29859);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 29796, 29836);

                                f_1604_29796_29835(mshCommandRuntime, v, true);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 29717, 29859);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 29491, 29878);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1604, 1, 388);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1604, 1, 388);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 29898, 29956);

                    Collection<DebugRecord>
                    debugRecords = f_1604_29937_29955(this, f_1604_29945_29954(job))
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 29976, 30357);
                        foreach (DebugRecord d in f_1604_30002_30014_I(debugRecords))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 29976, 30357);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 30056, 30080) || true) && (d == null)
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 30056, 30080);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 30071, 30080);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 30056, 30080);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 30102, 30176);

                            MshCommandRuntime
                            mshCommandRuntime = f_1604_30140_30154() as MshCommandRuntime
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 30198, 30338) || true) && (mshCommandRuntime != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 30198, 30338);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 30277, 30315);

                                f_1604_30277_30314(mshCommandRuntime, d, true);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 30198, 30338);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 29976, 30357);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1604, 1, 382);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1604, 1, 382);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 30377, 30441);

                    Collection<WarningRecord>
                    warningRecords = f_1604_30420_30440(this, f_1604_30428_30439(job))
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 30461, 30848);
                        foreach (WarningRecord w in f_1604_30489_30503_I(warningRecords))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 30461, 30848);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 30545, 30569) || true) && (w == null)
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 30545, 30569);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 30560, 30569);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 30545, 30569);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 30591, 30665);

                            MshCommandRuntime
                            mshCommandRuntime = f_1604_30629_30643() as MshCommandRuntime
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 30687, 30829) || true) && (mshCommandRuntime != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 30687, 30829);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 30766, 30806);

                                f_1604_30766_30805(mshCommandRuntime, w, true);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 30687, 30829);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 30461, 30848);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1604, 1, 388);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1604, 1, 388);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 30868, 30935);

                    Collection<ProgressRecord>
                    progressRecords = f_1604_30913_30934(this, f_1604_30921_30933(job))
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 30955, 31345);
                        foreach (ProgressRecord p in f_1604_30984_30999_I(progressRecords))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 30955, 31345);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 31041, 31065) || true) && (p == null)
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 31041, 31065);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 31056, 31065);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 31041, 31065);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 31087, 31161);

                            MshCommandRuntime
                            mshCommandRuntime = f_1604_31125_31139() as MshCommandRuntime
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 31183, 31326) || true) && (mshCommandRuntime != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 31183, 31326);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 31262, 31303);

                                f_1604_31262_31302(mshCommandRuntime, p, true);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 31183, 31326);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 30955, 31345);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1604, 1, 391);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1604, 1, 391);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 31365, 31441);

                    Collection<InformationRecord>
                    informationRecords = f_1604_31416_31440(this, f_1604_31424_31439(job))
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 31461, 31860);
                        foreach (InformationRecord p in f_1604_31493_31511_I(informationRecords))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 31461, 31860);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 31553, 31577) || true) && (p == null)
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 31553, 31577);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 31568, 31577);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 31553, 31577);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 31599, 31673);

                            MshCommandRuntime
                            mshCommandRuntime = f_1604_31637_31651() as MshCommandRuntime
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 31695, 31841) || true) && (mshCommandRuntime != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 31695, 31841);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 31774, 31818);

                                f_1604_31774_31817(mshCommandRuntime, p, true);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 31695, 31841);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 31461, 31860);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1604, 1, 400);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1604, 1, 400);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 27835, 31875);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 31891, 31945) || true) && (f_1604_31895_31917(f_1604_31895_31911(job)) != JobState.Failed)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 31891, 31945);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 31938, 31945);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 31891, 31945);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 31961, 31983);

                f_1604_31961_31982(this, job);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 25988, 31994);

                System.Management.Automation.JobStateInfo
                f_1604_26904_26920(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 26904, 26920);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1604_26904_26926(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 26904, 26926);
                    return return_v;
                }


                bool
                f_1604_27099_27138(System.Management.Automation.PSRemotingChildJob
                this_param)
                {
                    var return_v = this_param.DisconnectedAndBlocked;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 27099, 27138);
                    return return_v;
                }


                System.Management.Automation.JobStateInfo
                f_1604_27294_27310(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 27294, 27310);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1604_27294_27316(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 27294, 27316);
                    return return_v;
                }


                int
                f_1604_27370_27387(System.Management.Automation.Job
                job)
                {
                    DoUnblockJob(job);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 27370, 27387);
                    return 0;
                }


                bool
                f_1604_27857_27882(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.UsesResultsCollection;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 27857, 27882);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                f_1604_28029_28040(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Results;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 28029, 28040);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                f_1604_28005_28041(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                psDataCollection)
                {
                    var return_v = this_param.ReadAll<System.Management.Automation.Remoting.Internal.PSStreamObject>(psDataCollection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 28005, 28041);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                f_1604_28240_28251(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Results;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 28240, 28251);
                    return return_v;
                }


                System.Guid
                f_1604_28240_28260(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                this_param)
                {
                    var return_v = this_param.SourceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 28240, 28260);
                    return return_v;
                }


                int
                f_1604_28201_28261(System.Management.Automation.Remoting.Internal.PSStreamObject
                this_param, Microsoft.PowerShell.Commands.ReceiveJobCommand
                cmdlet, System.Guid
                instanceId)
                {
                    this_param.WriteStreamObject((System.Management.Automation.Cmdlet)cmdlet, instanceId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 28201, 28261);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                f_1604_28144_28151_I(System.Collections.ObjectModel.Collection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 28144, 28151);
                    return return_v;
                }


                int
                f_1604_28455_28493(System.Management.Automation.Remoting.Internal.PSStreamObject
                this_param, Microsoft.PowerShell.Commands.ReceiveJobCommand
                cmdlet)
                {
                    this_param.WriteStreamObject((System.Management.Automation.Cmdlet)cmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 28455, 28493);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                f_1604_28398_28405_I(System.Collections.ObjectModel.Collection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 28398, 28405);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                f_1604_28650_28660(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Output;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 28650, 28660);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1604_28632_28661(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                psDataCollection)
                {
                    var return_v = this_param.ReadAll<System.Management.Automation.PSObject>(psDataCollection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 28632, 28661);
                    return return_v;
                }


                int
                f_1604_28799_28813(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, System.Management.Automation.PSObject
                sendToPipeline)
                {
                    this_param.WriteObject((object)sendToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 28799, 28813);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1604_28705_28711_I(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 28705, 28711);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                f_1604_28913_28922(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Error;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 28913, 28922);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
                f_1604_28892_28923(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                psDataCollection)
                {
                    var return_v = this_param.ReadAll<System.Management.Automation.ErrorRecord>(psDataCollection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 28892, 28923);
                    return return_v;
                }


                System.Management.Automation.ICommandRuntime
                f_1604_29108_29122()
                {
                    var return_v = CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 29108, 29122);
                    return return_v;
                }


                int
                f_1604_29307_29344(System.Management.Automation.MshCommandRuntime
                this_param, System.Management.Automation.ErrorRecord
                errorRecord, bool
                overrideInquire)
                {
                    this_param.WriteError(errorRecord, overrideInquire);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 29307, 29344);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
                f_1604_28970_28982_I(System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 28970, 28982);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.VerboseRecord>
                f_1604_29458_29469(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Verbose;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 29458, 29469);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.VerboseRecord>
                f_1604_29450_29470(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, System.Management.Automation.PSDataCollection<System.Management.Automation.VerboseRecord>
                psDataCollection)
                {
                    var return_v = this_param.ReadAll<System.Management.Automation.VerboseRecord>(psDataCollection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 29450, 29470);
                    return return_v;
                }


                System.Management.Automation.ICommandRuntime
                f_1604_29659_29673()
                {
                    var return_v = CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 29659, 29673);
                    return return_v;
                }


                int
                f_1604_29796_29835(System.Management.Automation.MshCommandRuntime
                this_param, System.Management.Automation.VerboseRecord
                record, bool
                overrideInquire)
                {
                    this_param.WriteVerbose(record, overrideInquire);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 29796, 29835);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.VerboseRecord>
                f_1604_29519_29533_I(System.Collections.ObjectModel.Collection<System.Management.Automation.VerboseRecord>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 29519, 29533);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.DebugRecord>
                f_1604_29945_29954(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Debug;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 29945, 29954);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.DebugRecord>
                f_1604_29937_29955(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, System.Management.Automation.PSDataCollection<System.Management.Automation.DebugRecord>
                psDataCollection)
                {
                    var return_v = this_param.ReadAll<System.Management.Automation.DebugRecord>(psDataCollection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 29937, 29955);
                    return return_v;
                }


                System.Management.Automation.ICommandRuntime
                f_1604_30140_30154()
                {
                    var return_v = CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 30140, 30154);
                    return return_v;
                }


                int
                f_1604_30277_30314(System.Management.Automation.MshCommandRuntime
                this_param, System.Management.Automation.DebugRecord
                record, bool
                overrideInquire)
                {
                    this_param.WriteDebug(record, overrideInquire);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 30277, 30314);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.DebugRecord>
                f_1604_30002_30014_I(System.Collections.ObjectModel.Collection<System.Management.Automation.DebugRecord>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 30002, 30014);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.WarningRecord>
                f_1604_30428_30439(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Warning;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 30428, 30439);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.WarningRecord>
                f_1604_30420_30440(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, System.Management.Automation.PSDataCollection<System.Management.Automation.WarningRecord>
                psDataCollection)
                {
                    var return_v = this_param.ReadAll<System.Management.Automation.WarningRecord>(psDataCollection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 30420, 30440);
                    return return_v;
                }


                System.Management.Automation.ICommandRuntime
                f_1604_30629_30643()
                {
                    var return_v = CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 30629, 30643);
                    return return_v;
                }


                int
                f_1604_30766_30805(System.Management.Automation.MshCommandRuntime
                this_param, System.Management.Automation.WarningRecord
                record, bool
                overrideInquire)
                {
                    this_param.WriteWarning(record, overrideInquire);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 30766, 30805);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.WarningRecord>
                f_1604_30489_30503_I(System.Collections.ObjectModel.Collection<System.Management.Automation.WarningRecord>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 30489, 30503);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ProgressRecord>
                f_1604_30921_30933(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Progress;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 30921, 30933);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.ProgressRecord>
                f_1604_30913_30934(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, System.Management.Automation.PSDataCollection<System.Management.Automation.ProgressRecord>
                psDataCollection)
                {
                    var return_v = this_param.ReadAll<System.Management.Automation.ProgressRecord>(psDataCollection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 30913, 30934);
                    return return_v;
                }


                System.Management.Automation.ICommandRuntime
                f_1604_31125_31139()
                {
                    var return_v = CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 31125, 31139);
                    return return_v;
                }


                int
                f_1604_31262_31302(System.Management.Automation.MshCommandRuntime
                this_param, System.Management.Automation.ProgressRecord
                progressRecord, bool
                overrideInquire)
                {
                    this_param.WriteProgress(progressRecord, overrideInquire);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 31262, 31302);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.ProgressRecord>
                f_1604_30984_30999_I(System.Collections.ObjectModel.Collection<System.Management.Automation.ProgressRecord>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 30984, 30999);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.InformationRecord>
                f_1604_31424_31439(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Information;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 31424, 31439);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.InformationRecord>
                f_1604_31416_31440(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, System.Management.Automation.PSDataCollection<System.Management.Automation.InformationRecord>
                psDataCollection)
                {
                    var return_v = this_param.ReadAll<System.Management.Automation.InformationRecord>(psDataCollection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 31416, 31440);
                    return return_v;
                }


                System.Management.Automation.ICommandRuntime
                f_1604_31637_31651()
                {
                    var return_v = CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 31637, 31651);
                    return return_v;
                }


                int
                f_1604_31774_31817(System.Management.Automation.MshCommandRuntime
                this_param, System.Management.Automation.InformationRecord
                record, bool
                overrideInquire)
                {
                    this_param.WriteInformation(record, overrideInquire);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 31774, 31817);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.InformationRecord>
                f_1604_31493_31511_I(System.Collections.ObjectModel.Collection<System.Management.Automation.InformationRecord>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 31493, 31511);
                    return return_v;
                }


                System.Management.Automation.JobStateInfo
                f_1604_31895_31911(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 31895, 31911);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1604_31895_31917(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 31895, 31917);
                    return return_v;
                }


                int
                f_1604_31961_31982(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, System.Management.Automation.Job
                job)
                {
                    this_param.WriteReasonError(job);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 31961, 31982);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 25988, 31994);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 25988, 31994);
            }
        }

        private void WriteReasonError(Job job)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 32006, 33863);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 32163, 32216);

                PSRemotingChildJob
                child = job as PSRemotingChildJob
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 32230, 33852) || true) && (child != null && (DynAbs.Tracing.TraceSender.Expression_True(1604, 32234, 32283) && f_1604_32251_32275(child) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 32230, 33852);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 32317, 32420);

                    f_1604_32317_32419(_results, f_1604_32330_32418(PSStreamObjectType.Error, f_1604_32375_32399(child), f_1604_32401_32417(child)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 32230, 33852);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 32230, 33852);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 32454, 33852) || true) && (f_1604_32458_32481(f_1604_32458_32474(job)) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 32454, 33852);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 32523, 32570);

                        Exception
                        baseReason = f_1604_32546_32569(f_1604_32546_32562(job))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 32588, 32624);

                        Exception
                        resultReason = baseReason
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 32772, 32848);

                        JobFailedException
                        exceptionWithLocation = baseReason as JobFailedException
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 32866, 33004) || true) && (exceptionWithLocation != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 32866, 33004);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 32941, 32985);

                            resultReason = f_1604_32956_32984(exceptionWithLocation);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 32866, 33004);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 33024, 33133);

                        ErrorRecord
                        errorRecord = f_1604_33050_33132(resultReason, "JobStateFailed", ErrorCategory.InvalidResult, null)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 33284, 33729) || true) && ((exceptionWithLocation != null) && (DynAbs.Tracing.TraceSender.Expression_True(1604, 33288, 33376) && (f_1604_33324_33367(exceptionWithLocation) != null)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 33284, 33729);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 33418, 33591) || true) && (f_1604_33422_33448(errorRecord) == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 33418, 33591);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 33506, 33568);

                                f_1604_33506_33567(errorRecord, f_1604_33536_33566(null, null));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 33418, 33591);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 33615, 33710);

                            f_1604_33615_33641(errorRecord).DisplayScriptPosition = f_1604_33666_33709(exceptionWithLocation);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 33284, 33729);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 33749, 33837);

                        f_1604_33749_33836(
                                        _results, f_1604_33762_33835(PSStreamObjectType.Error, errorRecord, f_1604_33820_33834(job)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 32454, 33852);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 32230, 33852);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 32006, 33863);

                System.Management.Automation.ErrorRecord
                f_1604_32251_32275(System.Management.Automation.PSRemotingChildJob
                this_param)
                {
                    var return_v = this_param.FailureErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 32251, 32275);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1604_32375_32399(System.Management.Automation.PSRemotingChildJob
                this_param)
                {
                    var return_v = this_param.FailureErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 32375, 32399);
                    return return_v;
                }


                System.Guid
                f_1604_32401_32417(System.Management.Automation.PSRemotingChildJob
                this_param)
                {
                    var return_v = this_param.InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 32401, 32417);
                    return return_v;
                }


                System.Management.Automation.Remoting.Internal.PSStreamObject
                f_1604_32330_32418(System.Management.Automation.Remoting.Internal.PSStreamObjectType
                objectType, System.Management.Automation.ErrorRecord
                value, System.Guid
                id)
                {
                    var return_v = new System.Management.Automation.Remoting.Internal.PSStreamObject(objectType, (object)value, id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 32330, 32418);
                    return return_v;
                }


                int
                f_1604_32317_32419(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                this_param, System.Management.Automation.Remoting.Internal.PSStreamObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 32317, 32419);
                    return 0;
                }


                System.Management.Automation.JobStateInfo
                f_1604_32458_32474(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 32458, 32474);
                    return return_v;
                }


                System.Exception
                f_1604_32458_32481(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.Reason;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 32458, 32481);
                    return return_v;
                }


                System.Management.Automation.JobStateInfo
                f_1604_32546_32562(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 32546, 32562);
                    return return_v;
                }


                System.Exception
                f_1604_32546_32569(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.Reason;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 32546, 32569);
                    return return_v;
                }


                System.Exception
                f_1604_32956_32984(System.Management.Automation.JobFailedException
                this_param)
                {
                    var return_v = this_param.Reason;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 32956, 32984);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1604_33050_33132(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 33050, 33132);
                    return return_v;
                }


                System.Management.Automation.Language.ScriptExtent
                f_1604_33324_33367(System.Management.Automation.JobFailedException
                this_param)
                {
                    var return_v = this_param.DisplayScriptPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 33324, 33367);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1604_33422_33448(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 33422, 33448);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1604_33536_33566(System.Management.Automation.CommandInfo
                commandInfo, System.Management.Automation.Language.IScriptExtent
                scriptPosition)
                {
                    var return_v = new System.Management.Automation.InvocationInfo(commandInfo, scriptPosition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 33536, 33566);
                    return return_v;
                }


                int
                f_1604_33506_33567(System.Management.Automation.ErrorRecord
                this_param, System.Management.Automation.InvocationInfo
                invocationInfo)
                {
                    this_param.SetInvocationInfo(invocationInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 33506, 33567);
                    return 0;
                }


                System.Management.Automation.InvocationInfo
                f_1604_33615_33641(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 33615, 33641);
                    return return_v;
                }


                System.Management.Automation.Language.ScriptExtent
                f_1604_33666_33709(System.Management.Automation.JobFailedException
                this_param)
                {
                    var return_v = this_param.DisplayScriptPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 33666, 33709);
                    return return_v;
                }


                System.Guid
                f_1604_33820_33834(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 33820, 33834);
                    return return_v;
                }


                System.Management.Automation.Remoting.Internal.PSStreamObject
                f_1604_33762_33835(System.Management.Automation.Remoting.Internal.PSStreamObjectType
                objectType, System.Management.Automation.ErrorRecord
                value, System.Guid
                id)
                {
                    var return_v = new System.Management.Automation.Remoting.Internal.PSStreamObject(objectType, (object)value, id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 33762, 33835);
                    return return_v;
                }


                int
                f_1604_33749_33836(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                this_param, System.Management.Automation.Remoting.Internal.PSStreamObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 33749, 33836);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 32006, 33863);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 32006, 33863);
            }
        }

        private Collection<T> ReadAll<T>(PSDataCollection<T> psDataCollection)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 34135, 34637);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 34230, 34323) || true) && (_flush)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 34230, 34323);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 34274, 34308);

                    return f_1604_34281_34307(psDataCollection);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 34230, 34323);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 34339, 34381);

                T[]
                array = new T[f_1604_34357_34379(psDataCollection)]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 34395, 34429);

                f_1604_34395_34428(psDataCollection, array, 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 34443, 34490);

                Collection<T>
                collection = f_1604_34470_34489()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 34504, 34592);
                    foreach (T t in f_1604_34520_34525_I(array))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 34504, 34592);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 34559, 34577);

                        f_1604_34559_34576(collection, t);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 34504, 34592);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1604, 1, 89);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1604, 1, 89);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 34608, 34626);

                return collection;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 34135, 34637);

                System.Collections.ObjectModel.Collection<T>
                f_1604_34281_34307(System.Management.Automation.PSDataCollection<T>
                this_param)
                {
                    var return_v = this_param.ReadAll();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 34281, 34307);
                    return return_v;
                }


                int
                f_1604_34357_34379(System.Management.Automation.PSDataCollection<T>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 34357, 34379);
                    return return_v;
                }


                int
                f_1604_34395_34428(System.Management.Automation.PSDataCollection<T>
                this_param, T[]
                array, int
                arrayIndex)
                {
                    this_param.CopyTo(array, arrayIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 34395, 34428);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<T>
                f_1604_34470_34489()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 34470, 34489);
                    return return_v;
                }


                int
                f_1604_34559_34576(System.Collections.ObjectModel.Collection<T>
                this_param, T
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 34559, 34576);
                    return 0;
                }


                T[]
                f_1604_34520_34525_I(T[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 34520, 34525);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 34135, 34637);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 34135, 34637);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void WriteJobResultsRecursivelyHelper(Hashtable duplicate, Job job, bool registerInsteadOfWrite)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 35039, 36430);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 35253, 35339) || true) && (f_1604_35257_35283(duplicate, job))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 35253, 35339);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 35317, 35324);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 35253, 35339);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 35355, 35379);

                f_1604_35355_35378(
                            duplicate, job, job);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 35443, 35480);

                IList<Job>
                childJobs = f_1604_35466_35479(job)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 35496, 35657);
                    foreach (Job childjob in f_1604_35521_35530_I(childJobs))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 35496, 35657);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 35564, 35642);

                        f_1604_35564_35641(this, duplicate, childjob, registerInsteadOfWrite);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 35496, 35657);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1604, 1, 162);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1604, 1, 162);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 35673, 36419) || true) && (registerInsteadOfWrite)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 35673, 36419);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 36064, 36106);

                    _eventArgsWritten[f_1604_36082_36096(job)] = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 36180, 36209);

                    f_1604_36180_36208(this, job);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 35673, 36419);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 35673, 36419);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 36325, 36346);

                    f_1604_36325_36345(this, job);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 36364, 36404);

                    f_1604_36364_36403(this, job);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 35673, 36419);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 35039, 36430);

                bool
                f_1604_35257_35283(System.Collections.Hashtable
                this_param, System.Management.Automation.Job
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 35257, 35283);
                    return return_v;
                }


                int
                f_1604_35355_35378(System.Collections.Hashtable
                this_param, System.Management.Automation.Job
                key, System.Management.Automation.Job
                value)
                {
                    this_param.Add((object)key, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 35355, 35378);
                    return 0;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1604_35466_35479(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.ChildJobs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 35466, 35479);
                    return return_v;
                }


                int
                f_1604_35564_35641(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, System.Collections.Hashtable
                duplicate, System.Management.Automation.Job
                job, bool
                registerInsteadOfWrite)
                {
                    this_param.WriteJobResultsRecursivelyHelper(duplicate, job, registerInsteadOfWrite);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 35564, 35641);
                    return 0;
                }


                System.Collections.Generic.IList<System.Management.Automation.Job>
                f_1604_35521_35530_I(System.Collections.Generic.IList<System.Management.Automation.Job>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 35521, 35530);
                    return return_v;
                }


                System.Guid
                f_1604_36082_36096(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 36082, 36096);
                    return return_v;
                }


                int
                f_1604_36180_36208(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, System.Management.Automation.Job
                job)
                {
                    this_param.AggregateResultsFromJob(job);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 36180, 36208);
                    return 0;
                }


                int
                f_1604_36325_36345(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, System.Management.Automation.Job
                job)
                {
                    this_param.WriteJobResults(job);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 36325, 36345);
                    return 0;
                }


                int
                f_1604_36364_36403(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, System.Management.Automation.Job
                job)
                {
                    this_param.WriteJobStateInformationIfRequired(job);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 36364, 36403);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 35039, 36430);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 35039, 36430);
            }
        }

        private void WriteJobsIfRequired(IEnumerable<Job> jobsToWrite)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 36814, 37192);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 36901, 36930) || true) && (!_outputJobFirst)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 36901, 36930);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 36923, 36930);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 36901, 36930);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 36946, 37181);
                    foreach (var job in f_1604_36966_36977_I(jobsToWrite))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 36946, 37181);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 37011, 37131);

                        f_1604_37011_37130(_tracer, "ReceiveJobCommand", "WriteJobsIfRequired", Guid.Empty, job, "Writing job object as output", null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 37149, 37166);

                        f_1604_37149_37165(this, job);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 36946, 37181);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1604, 1, 236);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1604, 1, 236);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 36814, 37192);

                int
                f_1604_37011_37130(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.Job
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 37011, 37130);
                    return 0;
                }


                int
                f_1604_37149_37165(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, System.Management.Automation.Job
                sendToPipeline)
                {
                    this_param.WriteObject((object)sendToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 37149, 37165);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.Job>
                f_1604_36966_36977_I(System.Collections.Generic.IEnumerable<System.Management.Automation.Job>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 36966, 36977);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 36814, 37192);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 36814, 37192);
            }
        }

        private void AggregateResultsFromJob(Job job)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 37421, 40553);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 37491, 37619) || true) && ((f_1604_37496_37502_M(!Force) && (DynAbs.Tracing.TraceSender.Expression_True(1604, 37496, 37551) && f_1604_37506_37551(job, f_1604_37528_37550(f_1604_37528_37544(job))))) || (DynAbs.Tracing.TraceSender.Expression_False(1604, 37495, 37610) || (f_1604_37557_37562() && (DynAbs.Tracing.TraceSender.Expression_True(1604, 37557, 37609) && f_1604_37566_37609(job, f_1604_37586_37608(f_1604_37586_37602(job)))))))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 37491, 37619);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 37612, 37619);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 37491, 37619);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 37633, 37675);

                job.StateChanged += HandleJobStateChanged;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 38034, 38269) || true) && ((f_1604_38039_38045_M(!Force) && (DynAbs.Tracing.TraceSender.Expression_True(1604, 38039, 38094) && f_1604_38049_38094(job, f_1604_38071_38093(f_1604_38071_38087(job))))) || (DynAbs.Tracing.TraceSender.Expression_False(1604, 38038, 38153) || (f_1604_38100_38105() && (DynAbs.Tracing.TraceSender.Expression_True(1604, 38100, 38152) && f_1604_38109_38152(job, f_1604_38129_38151(f_1604_38129_38145(job)))))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 38034, 38269);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 38187, 38229);

                    job.StateChanged -= HandleJobStateChanged;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 38247, 38254);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 38034, 38269);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 38285, 38442);

                f_1604_38285_38441(
                            _tracer, ClassNameTrace, "AggregateResultsFromJob", Guid.Empty, job, "BEGIN Adding job for aggregation", null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 38611, 38641);

                f_1604_38611_38640(
                            // at this point, we can be sure that any job added to this
                            // collection will have a state changed event to a finished state.
                            _jobsBeingAggregated, job);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 38774, 39815) || true) && (f_1604_38778_38803(job))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 38774, 39815);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 38837, 38875);

                    f_1604_38837_38848(job).SourceId = f_1604_38860_38874(job);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 38893, 38931);

                    f_1604_38893_38904(job).DataAdded += ResultsAdded;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 38774, 39815);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 38774, 39815);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 38997, 39034);

                    f_1604_38997_39007(job).SourceId = f_1604_39019_39033(job);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 39052, 39088);

                    f_1604_39052_39061(job).SourceId = f_1604_39073_39087(job);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 39106, 39145);

                    f_1604_39106_39118(job).SourceId = f_1604_39130_39144(job);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 39163, 39201);

                    f_1604_39163_39174(job).SourceId = f_1604_39186_39200(job);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 39219, 39257);

                    f_1604_39219_39230(job).SourceId = f_1604_39242_39256(job);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 39275, 39311);

                    f_1604_39275_39284(job).SourceId = f_1604_39296_39310(job);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 39329, 39371);

                    f_1604_39329_39344(job).SourceId = f_1604_39356_39370(job);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 39391, 39432);

                    f_1604_39391_39401(job).DataAdded += Output_DataAdded;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 39450, 39489);

                    f_1604_39450_39459(job).DataAdded += Error_DataAdded;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 39507, 39552);

                    f_1604_39507_39519(job).DataAdded += Progress_DataAdded;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 39570, 39613);

                    f_1604_39570_39581(job).DataAdded += Verbose_DataAdded;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 39631, 39674);

                    f_1604_39631_39642(job).DataAdded += Warning_DataAdded;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 39692, 39731);

                    f_1604_39692_39701(job).DataAdded += Debug_DataAdded;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 39749, 39800);

                    f_1604_39749_39764(job).DataAdded += Information_DataAdded;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 38774, 39815);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 39831, 40371) || true) && (f_1604_39835_39862(job))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 39831, 40371);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 39896, 40274) || true) && (_outputProcessingNotification == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 39896, 40274);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 39985, 39996);
                        lock (_syncObject)
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 40046, 40232) || true) && (_outputProcessingNotification == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 40046, 40232);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 40145, 40205);

                                _outputProcessingNotification = f_1604_40177_40204();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 40046, 40232);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 39896, 40274);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 40294, 40356);

                    f_1604_40294_40355(
                                    job, _outputProcessingNotification);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 39831, 40371);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 40387, 40542);

                f_1604_40387_40541(
                            _tracer, ClassNameTrace, "AggregateResultsFromJob", Guid.Empty, job, "END Adding job for aggregation", null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 37421, 40553);

                bool
                f_1604_37496_37502_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 37496, 37502);
                    return return_v;
                }


                System.Management.Automation.JobStateInfo
                f_1604_37528_37544(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 37528, 37544);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1604_37528_37550(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 37528, 37550);
                    return return_v;
                }


                bool
                f_1604_37506_37551(System.Management.Automation.Job
                this_param, System.Management.Automation.JobState
                state)
                {
                    var return_v = this_param.IsPersistentState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 37506, 37551);
                    return return_v;
                }


                System.Management.Automation.SwitchParameter
                f_1604_37557_37562()
                {
                    var return_v = Force;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 37557, 37562);
                    return return_v;
                }


                System.Management.Automation.JobStateInfo
                f_1604_37586_37602(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 37586, 37602);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1604_37586_37608(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 37586, 37608);
                    return return_v;
                }


                bool
                f_1604_37566_37609(System.Management.Automation.Job
                this_param, System.Management.Automation.JobState
                state)
                {
                    var return_v = this_param.IsFinishedState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 37566, 37609);
                    return return_v;
                }


                bool
                f_1604_38039_38045_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 38039, 38045);
                    return return_v;
                }


                System.Management.Automation.JobStateInfo
                f_1604_38071_38087(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 38071, 38087);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1604_38071_38093(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 38071, 38093);
                    return return_v;
                }


                bool
                f_1604_38049_38094(System.Management.Automation.Job
                this_param, System.Management.Automation.JobState
                state)
                {
                    var return_v = this_param.IsPersistentState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 38049, 38094);
                    return return_v;
                }


                System.Management.Automation.SwitchParameter
                f_1604_38100_38105()
                {
                    var return_v = Force;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 38100, 38105);
                    return return_v;
                }


                System.Management.Automation.JobStateInfo
                f_1604_38129_38145(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 38129, 38145);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1604_38129_38151(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 38129, 38151);
                    return return_v;
                }


                bool
                f_1604_38109_38152(System.Management.Automation.Job
                this_param, System.Management.Automation.JobState
                state)
                {
                    var return_v = this_param.IsFinishedState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 38109, 38152);
                    return return_v;
                }


                int
                f_1604_38285_38441(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.Job
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 38285, 38441);
                    return 0;
                }


                int
                f_1604_38611_38640(System.Collections.Generic.List<System.Management.Automation.Job>
                this_param, System.Management.Automation.Job
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 38611, 38640);
                    return 0;
                }


                bool
                f_1604_38778_38803(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.UsesResultsCollection;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 38778, 38803);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                f_1604_38837_38848(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Results;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 38837, 38848);
                    return return_v;
                }


                System.Guid
                f_1604_38860_38874(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 38860, 38874);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                f_1604_38893_38904(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Results;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 38893, 38904);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                f_1604_38997_39007(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Output;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 38997, 39007);
                    return return_v;
                }


                System.Guid
                f_1604_39019_39033(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 39019, 39033);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                f_1604_39052_39061(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Error;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 39052, 39061);
                    return return_v;
                }


                System.Guid
                f_1604_39073_39087(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 39073, 39087);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ProgressRecord>
                f_1604_39106_39118(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Progress;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 39106, 39118);
                    return return_v;
                }


                System.Guid
                f_1604_39130_39144(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 39130, 39144);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.VerboseRecord>
                f_1604_39163_39174(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Verbose;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 39163, 39174);
                    return return_v;
                }


                System.Guid
                f_1604_39186_39200(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 39186, 39200);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.WarningRecord>
                f_1604_39219_39230(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Warning;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 39219, 39230);
                    return return_v;
                }


                System.Guid
                f_1604_39242_39256(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 39242, 39256);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.DebugRecord>
                f_1604_39275_39284(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Debug;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 39275, 39284);
                    return return_v;
                }


                System.Guid
                f_1604_39296_39310(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 39296, 39310);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.InformationRecord>
                f_1604_39329_39344(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Information;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 39329, 39344);
                    return return_v;
                }


                System.Guid
                f_1604_39356_39370(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 39356, 39370);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                f_1604_39391_39401(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Output;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 39391, 39401);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                f_1604_39450_39459(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Error;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 39450, 39459);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ProgressRecord>
                f_1604_39507_39519(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Progress;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 39507, 39519);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.VerboseRecord>
                f_1604_39570_39581(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Verbose;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 39570, 39581);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.WarningRecord>
                f_1604_39631_39642(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Warning;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 39631, 39642);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.DebugRecord>
                f_1604_39692_39701(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Debug;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 39692, 39701);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.InformationRecord>
                f_1604_39749_39764(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Information;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 39749, 39764);
                    return return_v;
                }


                bool
                f_1604_39835_39862(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.MonitorOutputProcessing;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 39835, 39862);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.OutputProcessingState
                f_1604_40177_40204()
                {
                    var return_v = new Microsoft.PowerShell.Commands.OutputProcessingState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 40177, 40204);
                    return return_v;
                }


                int
                f_1604_40294_40355(System.Management.Automation.Job
                this_param, Microsoft.PowerShell.Commands.OutputProcessingState
                outputProcessingState)
                {
                    this_param.SetMonitorOutputProcessing((System.Management.Automation.IOutputProcessingState)outputProcessingState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 40294, 40355);
                    return 0;
                }


                int
                f_1604_40387_40541(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.Job
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 40387, 40541);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 37421, 40553);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 37421, 40553);
            }
        }

        private void ResultsAdded(object sender, DataAddedEventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 40565, 41211);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 40658, 40669);
                lock (_syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 40703, 40727) || true) && (_isDisposed)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 40703, 40727);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 40720, 40727);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 40703, 40727);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 40758, 40787);

                f_1604_40758_40786(
                            _writeExistingData);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 40801, 40887);

                PSDataCollection<PSStreamObject>
                results = sender as PSDataCollection<PSStreamObject>
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 40903, 40985);

                f_1604_40903_40984(results != null, "PSDataCollection is raising an inappropriate event");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 40999, 41049);

                PSStreamObject
                record = f_1604_41023_41048(this, results, f_1604_41040_41047(e))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 41065, 41200) || true) && (record != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 41065, 41200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 41117, 41146);

                    record.Id = f_1604_41129_41145(results);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 41164, 41185);

                    f_1604_41164_41184(_results, record);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 41065, 41200);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 40565, 41211);

                bool
                f_1604_40758_40786(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.WaitOne();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 40758, 40786);
                    return return_v;
                }


                int
                f_1604_40903_40984(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 40903, 40984);
                    return 0;
                }


                int
                f_1604_41040_41047(System.Management.Automation.DataAddedEventArgs
                this_param)
                {
                    var return_v = this_param.Index;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 41040, 41047);
                    return return_v;
                }


                System.Management.Automation.Remoting.Internal.PSStreamObject
                f_1604_41023_41048(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                collection, int
                index)
                {
                    var return_v = this_param.GetData<System.Management.Automation.Remoting.Internal.PSStreamObject>(collection, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 41023, 41048);
                    return return_v;
                }


                System.Guid
                f_1604_41129_41145(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                this_param)
                {
                    var return_v = this_param.SourceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 41129, 41145);
                    return return_v;
                }


                int
                f_1604_41164_41184(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                this_param, System.Management.Automation.Remoting.Internal.PSStreamObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 41164, 41184);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 40565, 41211);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 40565, 41211);
            }
        }

        private void HandleJobStateChanged(object sender, JobStateEventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 41223, 43639);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 41318, 41342);

                Job
                job = sender as Job
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 41356, 41437);

                f_1604_41356_41436(job != null, "Job state info cannot be raised with reference to job");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 41704, 41861);

                f_1604_41704_41860(
                            // waiting for existing data to be written ensures two things
                            // 1. that no aggregation for a job is in progress
                            // 2. the state information is written in the correct order
                            //    as per the contract
                            _tracer, ClassNameTrace, "HandleJobStateChanged", Guid.Empty, job, "BEGIN wait for write existing data", null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 41875, 41967) || true) && (f_1604_41879_41899(f_1604_41879_41893(e)) != JobState.Running)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 41875, 41967);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 41938, 41967);

                    f_1604_41938_41966(_writeExistingData);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 41875, 41967);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 41983, 42138);

                f_1604_41983_42137(
                            _tracer, ClassNameTrace, "HandleJobStateChanged", Guid.Empty, job, "END wait for write existing data", null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 42160, 42171);

                lock (_syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 42205, 42517) || true) && (!f_1604_42210_42244(_jobsBeingAggregated, job))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 42205, 42517);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 42286, 42469);

                        f_1604_42286_42468(_tracer, ClassNameTrace, "HandleJobStateChanged", Guid.Empty, job, "Returning because job is not in _jobsBeingAggregated", null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 42491, 42498);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 42205, 42517);
                    }
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 42548, 42659) || true) && (f_1604_42552_42572(f_1604_42552_42566(e)) == JobState.Blocked)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 42548, 42659);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 42626, 42644);

                    f_1604_42626_42643(job);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 42548, 42659);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 42996, 43390) || true) && (!(f_1604_43002_43008_M(!Force) && (DynAbs.Tracing.TraceSender.Expression_True(1604, 43002, 43055) && f_1604_43012_43055(job, f_1604_43034_43054(f_1604_43034_43048(e))))) && (DynAbs.Tracing.TraceSender.Expression_True(1604, 43000, 43113) && !(f_1604_43062_43067() && (DynAbs.Tracing.TraceSender.Expression_True(1604, 43062, 43112) && f_1604_43071_43112(job, f_1604_43091_43111(f_1604_43091_43105(e)))))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 42996, 43390);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 43147, 43350);

                    f_1604_43147_43349(_tracer, ClassNameTrace, "HandleJobStateChanged", Guid.Empty, job, "Returning because job state does not meet wait requirements (continue aggregating)");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 43368, 43375);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 42996, 43390);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 43502, 43524);

                f_1604_43502_43523(this, job);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 43538, 43581);

                f_1604_43538_43580(this, job, e);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 43595, 43628);

                f_1604_43595_43627(this, job);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 41223, 43639);

                int
                f_1604_41356_41436(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 41356, 41436);
                    return 0;
                }


                int
                f_1604_41704_41860(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.Job
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 41704, 41860);
                    return 0;
                }


                System.Management.Automation.JobStateInfo
                f_1604_41879_41893(System.Management.Automation.JobStateEventArgs
                this_param)
                {
                    var return_v = this_param.JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 41879, 41893);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1604_41879_41899(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 41879, 41899);
                    return return_v;
                }


                bool
                f_1604_41938_41966(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.WaitOne();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 41938, 41966);
                    return return_v;
                }


                int
                f_1604_41983_42137(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.Job
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 41983, 42137);
                    return 0;
                }


                bool
                f_1604_42210_42244(System.Collections.Generic.List<System.Management.Automation.Job>
                this_param, System.Management.Automation.Job
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 42210, 42244);
                    return return_v;
                }


                int
                f_1604_42286_42468(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.Job
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 42286, 42468);
                    return 0;
                }


                System.Management.Automation.JobStateInfo
                f_1604_42552_42566(System.Management.Automation.JobStateEventArgs
                this_param)
                {
                    var return_v = this_param.JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 42552, 42566);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1604_42552_42572(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 42552, 42572);
                    return return_v;
                }


                int
                f_1604_42626_42643(System.Management.Automation.Job
                job)
                {
                    DoUnblockJob(job);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 42626, 42643);
                    return 0;
                }


                bool
                f_1604_43002_43008_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 43002, 43008);
                    return return_v;
                }


                System.Management.Automation.JobStateInfo
                f_1604_43034_43048(System.Management.Automation.JobStateEventArgs
                this_param)
                {
                    var return_v = this_param.JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 43034, 43048);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1604_43034_43054(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 43034, 43054);
                    return return_v;
                }


                bool
                f_1604_43012_43055(System.Management.Automation.Job
                this_param, System.Management.Automation.JobState
                state)
                {
                    var return_v = this_param.IsPersistentState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 43012, 43055);
                    return return_v;
                }


                System.Management.Automation.SwitchParameter
                f_1604_43062_43067()
                {
                    var return_v = Force;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 43062, 43067);
                    return return_v;
                }


                System.Management.Automation.JobStateInfo
                f_1604_43091_43105(System.Management.Automation.JobStateEventArgs
                this_param)
                {
                    var return_v = this_param.JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 43091, 43105);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1604_43091_43111(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 43091, 43111);
                    return return_v;
                }


                bool
                f_1604_43071_43112(System.Management.Automation.Job
                this_param, System.Management.Automation.JobState
                state)
                {
                    var return_v = this_param.IsFinishedState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 43071, 43112);
                    return return_v;
                }


                int
                f_1604_43147_43349(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.Job
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 43147, 43349);
                    return 0;
                }


                int
                f_1604_43502_43523(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, System.Management.Automation.Job
                job)
                {
                    this_param.WriteReasonError(job);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 43502, 43523);
                    return 0;
                }


                int
                f_1604_43538_43580(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, System.Management.Automation.Job
                job, System.Management.Automation.JobStateEventArgs
                args)
                {
                    this_param.WriteJobStateInformationIfRequired(job, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 43538, 43580);
                    return 0;
                }


                int
                f_1604_43595_43627(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, System.Management.Automation.Job
                job)
                {
                    this_param.StopAggregateResultsFromJob(job);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 43595, 43627);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 41223, 43639);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 41223, 43639);
            }
        }

        private void Progress_DataAdded(object sender, DataAddedEventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 43651, 44647);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 43750, 43761);
                lock (_syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 43795, 43819) || true) && (_isDisposed)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 43795, 43819);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 43812, 43819);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 43795, 43819);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 43850, 43879);

                f_1604_43850_43878(
                            _writeExistingData);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 43893, 43934);

                f_1604_43893_43933(_resultsReaderWriterLock);
                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 43984, 44013) || true) && (f_1604_43988_44004_M(!_results.IsOpen))
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 43984, 44013);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 44006, 44013);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 43984, 44013);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 44031, 44125);

                    PSDataCollection<ProgressRecord>
                    progressRecords = sender as PSDataCollection<ProgressRecord>
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 44143, 44241);

                    f_1604_44143_44240(progressRecords != null, "PSDataCollection is raising an inappropriate event");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 44261, 44319);

                    ProgressRecord
                    record = f_1604_44285_44318(this, progressRecords, f_1604_44310_44317(e))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 44337, 44512) || true) && (record != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 44337, 44512);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 44397, 44493);

                        f_1604_44397_44492(_results, f_1604_44410_44491(PSStreamObjectType.Progress, record, f_1604_44466_44490(progressRecords)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 44337, 44512);
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1604, 44541, 44636);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 44581, 44621);

                    f_1604_44581_44620(_resultsReaderWriterLock);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1604, 44541, 44636);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 43651, 44647);

                bool
                f_1604_43850_43878(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.WaitOne();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 43850, 43878);
                    return return_v;
                }


                int
                f_1604_43893_43933(System.Threading.ReaderWriterLockSlim
                this_param)
                {
                    this_param.EnterReadLock();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 43893, 43933);
                    return 0;
                }


                bool
                f_1604_43988_44004_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 43988, 44004);
                    return return_v;
                }


                int
                f_1604_44143_44240(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 44143, 44240);
                    return 0;
                }


                int
                f_1604_44310_44317(System.Management.Automation.DataAddedEventArgs
                this_param)
                {
                    var return_v = this_param.Index;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 44310, 44317);
                    return return_v;
                }


                System.Management.Automation.ProgressRecord
                f_1604_44285_44318(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, System.Management.Automation.PSDataCollection<System.Management.Automation.ProgressRecord>
                collection, int
                index)
                {
                    var return_v = this_param.GetData<System.Management.Automation.ProgressRecord>(collection, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 44285, 44318);
                    return return_v;
                }


                System.Guid
                f_1604_44466_44490(System.Management.Automation.PSDataCollection<System.Management.Automation.ProgressRecord>
                this_param)
                {
                    var return_v = this_param.SourceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 44466, 44490);
                    return return_v;
                }


                System.Management.Automation.Remoting.Internal.PSStreamObject
                f_1604_44410_44491(System.Management.Automation.Remoting.Internal.PSStreamObjectType
                objectType, System.Management.Automation.ProgressRecord
                value, System.Guid
                id)
                {
                    var return_v = new System.Management.Automation.Remoting.Internal.PSStreamObject(objectType, (object)value, id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 44410, 44491);
                    return return_v;
                }


                int
                f_1604_44397_44492(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                this_param, System.Management.Automation.Remoting.Internal.PSStreamObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 44397, 44492);
                    return 0;
                }


                int
                f_1604_44581_44620(System.Threading.ReaderWriterLockSlim
                this_param)
                {
                    this_param.ExitReadLock();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 44581, 44620);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 43651, 44647);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 43651, 44647);
            }
        }

        private void Error_DataAdded(object sender, DataAddedEventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 44659, 45701);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 44755, 44766);
                lock (_syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 44800, 44824) || true) && (_isDisposed)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 44800, 44824);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 44817, 44824);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 44800, 44824);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 44855, 44884);

                f_1604_44855_44883(
                            _writeExistingData);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 44898, 44939);

                f_1604_44898_44938(_resultsReaderWriterLock);
                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 44989, 45018) || true) && (f_1604_44993_45009_M(!_results.IsOpen))
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 44989, 45018);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 45011, 45018);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 44989, 45018);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 45036, 45121);

                    PSDataCollection<ErrorRecord>
                    errorRecords = sender as PSDataCollection<ErrorRecord>
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 45139, 45234);

                    f_1604_45139_45233(errorRecords != null, "PSDataCollection is raising an inappropriate event");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 45252, 45309);

                    ErrorRecord
                    errorRecord = f_1604_45278_45308(this, errorRecords, f_1604_45300_45307(e))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 45327, 45566) || true) && (errorRecord != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 45327, 45566);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 45463, 45547);

                        f_1604_45463_45546(                    // error records are already tagged, skip tagging
                                            _results, f_1604_45476_45545(PSStreamObjectType.Error, errorRecord, Guid.Empty));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 45327, 45566);
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1604, 45595, 45690);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 45635, 45675);

                    f_1604_45635_45674(_resultsReaderWriterLock);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1604, 45595, 45690);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 44659, 45701);

                bool
                f_1604_44855_44883(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.WaitOne();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 44855, 44883);
                    return return_v;
                }


                int
                f_1604_44898_44938(System.Threading.ReaderWriterLockSlim
                this_param)
                {
                    this_param.EnterReadLock();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 44898, 44938);
                    return 0;
                }


                bool
                f_1604_44993_45009_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 44993, 45009);
                    return return_v;
                }


                int
                f_1604_45139_45233(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 45139, 45233);
                    return 0;
                }


                int
                f_1604_45300_45307(System.Management.Automation.DataAddedEventArgs
                this_param)
                {
                    var return_v = this_param.Index;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 45300, 45307);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1604_45278_45308(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                collection, int
                index)
                {
                    var return_v = this_param.GetData<System.Management.Automation.ErrorRecord>(collection, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 45278, 45308);
                    return return_v;
                }


                System.Management.Automation.Remoting.Internal.PSStreamObject
                f_1604_45476_45545(System.Management.Automation.Remoting.Internal.PSStreamObjectType
                objectType, System.Management.Automation.ErrorRecord
                value, System.Guid
                id)
                {
                    var return_v = new System.Management.Automation.Remoting.Internal.PSStreamObject(objectType, (object)value, id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 45476, 45545);
                    return return_v;
                }


                int
                f_1604_45463_45546(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                this_param, System.Management.Automation.Remoting.Internal.PSStreamObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 45463, 45546);
                    return 0;
                }


                int
                f_1604_45635_45674(System.Threading.ReaderWriterLockSlim
                this_param)
                {
                    this_param.ExitReadLock();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 45635, 45674);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 44659, 45701);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 44659, 45701);
            }
        }

        private void Debug_DataAdded(object sender, DataAddedEventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 45713, 46748);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 45809, 45820);
                lock (_syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 45854, 45878) || true) && (_isDisposed)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 45854, 45878);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 45871, 45878);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 45854, 45878);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 45909, 45938);

                f_1604_45909_45937(
                            _writeExistingData);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 45952, 45993);

                f_1604_45952_45992(_resultsReaderWriterLock);
                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 46043, 46072) || true) && (f_1604_46047_46063_M(!_results.IsOpen))
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 46043, 46072);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 46065, 46072);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 46043, 46072);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 46090, 46175);

                    PSDataCollection<DebugRecord>
                    debugRecords = sender as PSDataCollection<DebugRecord>
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 46193, 46288);

                    f_1604_46193_46287(debugRecords != null, "PSDataCollection is raising an inappropriate event");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 46306, 46358);

                    DebugRecord
                    record = f_1604_46327_46357(this, debugRecords, f_1604_46349_46356(e))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 46376, 46613) || true) && (record != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 46376, 46613);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 46507, 46594);

                        f_1604_46507_46593(                    // debug records are already tagged, skip tagging
                                            _results, f_1604_46520_46592(PSStreamObjectType.Debug, f_1604_46565_46579(record), Guid.Empty));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 46376, 46613);
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1604, 46642, 46737);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 46682, 46722);

                    f_1604_46682_46721(_resultsReaderWriterLock);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1604, 46642, 46737);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 45713, 46748);

                bool
                f_1604_45909_45937(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.WaitOne();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 45909, 45937);
                    return return_v;
                }


                int
                f_1604_45952_45992(System.Threading.ReaderWriterLockSlim
                this_param)
                {
                    this_param.EnterReadLock();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 45952, 45992);
                    return 0;
                }


                bool
                f_1604_46047_46063_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 46047, 46063);
                    return return_v;
                }


                int
                f_1604_46193_46287(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 46193, 46287);
                    return 0;
                }


                int
                f_1604_46349_46356(System.Management.Automation.DataAddedEventArgs
                this_param)
                {
                    var return_v = this_param.Index;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 46349, 46356);
                    return return_v;
                }


                System.Management.Automation.DebugRecord
                f_1604_46327_46357(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, System.Management.Automation.PSDataCollection<System.Management.Automation.DebugRecord>
                collection, int
                index)
                {
                    var return_v = this_param.GetData<System.Management.Automation.DebugRecord>(collection, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 46327, 46357);
                    return return_v;
                }


                string
                f_1604_46565_46579(System.Management.Automation.DebugRecord
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 46565, 46579);
                    return return_v;
                }


                System.Management.Automation.Remoting.Internal.PSStreamObject
                f_1604_46520_46592(System.Management.Automation.Remoting.Internal.PSStreamObjectType
                objectType, string
                value, System.Guid
                id)
                {
                    var return_v = new System.Management.Automation.Remoting.Internal.PSStreamObject(objectType, (object)value, id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 46520, 46592);
                    return return_v;
                }


                int
                f_1604_46507_46593(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                this_param, System.Management.Automation.Remoting.Internal.PSStreamObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 46507, 46593);
                    return 0;
                }


                int
                f_1604_46682_46721(System.Threading.ReaderWriterLockSlim
                this_param)
                {
                    this_param.ExitReadLock();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 46682, 46721);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 45713, 46748);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 45713, 46748);
            }
        }

        private void Warning_DataAdded(object sender, DataAddedEventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 46760, 47813);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 46858, 46869);
                lock (_syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 46903, 46927) || true) && (_isDisposed)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 46903, 46927);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 46920, 46927);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 46903, 46927);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 46958, 46987);

                f_1604_46958_46986(
                            _writeExistingData);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 47001, 47042);

                f_1604_47001_47041(_resultsReaderWriterLock);
                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 47092, 47121) || true) && (f_1604_47096_47112_M(!_results.IsOpen))
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 47092, 47121);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 47114, 47121);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 47092, 47121);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 47139, 47230);

                    PSDataCollection<WarningRecord>
                    warningRecords = sender as PSDataCollection<WarningRecord>
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 47248, 47345);

                    f_1604_47248_47344(warningRecords != null, "PSDataCollection is raising an inappropriate event");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 47363, 47419);

                    WarningRecord
                    record = f_1604_47386_47418(this, warningRecords, f_1604_47410_47417(e))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 47437, 47678) || true) && (record != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 47437, 47678);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 47570, 47659);

                        f_1604_47570_47658(                    // warning records are already tagged, skip tagging
                                            _results, f_1604_47583_47657(PSStreamObjectType.Warning, f_1604_47630_47644(record), Guid.Empty));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 47437, 47678);
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1604, 47707, 47802);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 47747, 47787);

                    f_1604_47747_47786(_resultsReaderWriterLock);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1604, 47707, 47802);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 46760, 47813);

                bool
                f_1604_46958_46986(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.WaitOne();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 46958, 46986);
                    return return_v;
                }


                int
                f_1604_47001_47041(System.Threading.ReaderWriterLockSlim
                this_param)
                {
                    this_param.EnterReadLock();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 47001, 47041);
                    return 0;
                }


                bool
                f_1604_47096_47112_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 47096, 47112);
                    return return_v;
                }


                int
                f_1604_47248_47344(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 47248, 47344);
                    return 0;
                }


                int
                f_1604_47410_47417(System.Management.Automation.DataAddedEventArgs
                this_param)
                {
                    var return_v = this_param.Index;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 47410, 47417);
                    return return_v;
                }


                System.Management.Automation.WarningRecord
                f_1604_47386_47418(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, System.Management.Automation.PSDataCollection<System.Management.Automation.WarningRecord>
                collection, int
                index)
                {
                    var return_v = this_param.GetData<System.Management.Automation.WarningRecord>(collection, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 47386, 47418);
                    return return_v;
                }


                string
                f_1604_47630_47644(System.Management.Automation.WarningRecord
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 47630, 47644);
                    return return_v;
                }


                System.Management.Automation.Remoting.Internal.PSStreamObject
                f_1604_47583_47657(System.Management.Automation.Remoting.Internal.PSStreamObjectType
                objectType, string
                value, System.Guid
                id)
                {
                    var return_v = new System.Management.Automation.Remoting.Internal.PSStreamObject(objectType, (object)value, id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 47583, 47657);
                    return return_v;
                }


                int
                f_1604_47570_47658(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                this_param, System.Management.Automation.Remoting.Internal.PSStreamObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 47570, 47658);
                    return 0;
                }


                int
                f_1604_47747_47786(System.Threading.ReaderWriterLockSlim
                this_param)
                {
                    this_param.ExitReadLock();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 47747, 47786);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 46760, 47813);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 46760, 47813);
            }
        }

        private void Verbose_DataAdded(object sender, DataAddedEventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 47825, 48870);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 47923, 47934);
                lock (_syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 47968, 47992) || true) && (_isDisposed)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 47968, 47992);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 47985, 47992);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 47968, 47992);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 48023, 48052);

                f_1604_48023_48051(
                            _writeExistingData);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 48066, 48107);

                f_1604_48066_48106(_resultsReaderWriterLock);
                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 48157, 48186) || true) && (f_1604_48161_48177_M(!_results.IsOpen))
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 48157, 48186);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 48179, 48186);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 48157, 48186);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 48204, 48295);

                    PSDataCollection<VerboseRecord>
                    verboseRecords = sender as PSDataCollection<VerboseRecord>
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 48313, 48402);

                    f_1604_48313_48401(verboseRecords != null, "PSDataCollection is raising an inappropriate event");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 48420, 48476);

                    VerboseRecord
                    record = f_1604_48443_48475(this, verboseRecords, f_1604_48467_48474(e))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 48494, 48735) || true) && (record != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 48494, 48735);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 48627, 48716);

                        f_1604_48627_48715(                    // verbose records are already tagged, skip tagging
                                            _results, f_1604_48640_48714(PSStreamObjectType.Verbose, f_1604_48687_48701(record), Guid.Empty));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 48494, 48735);
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1604, 48764, 48859);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 48804, 48844);

                    f_1604_48804_48843(_resultsReaderWriterLock);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1604, 48764, 48859);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 47825, 48870);

                bool
                f_1604_48023_48051(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.WaitOne();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 48023, 48051);
                    return return_v;
                }


                int
                f_1604_48066_48106(System.Threading.ReaderWriterLockSlim
                this_param)
                {
                    this_param.EnterReadLock();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 48066, 48106);
                    return 0;
                }


                bool
                f_1604_48161_48177_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 48161, 48177);
                    return return_v;
                }


                int
                f_1604_48313_48401(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 48313, 48401);
                    return 0;
                }


                int
                f_1604_48467_48474(System.Management.Automation.DataAddedEventArgs
                this_param)
                {
                    var return_v = this_param.Index;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 48467, 48474);
                    return return_v;
                }


                System.Management.Automation.VerboseRecord
                f_1604_48443_48475(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, System.Management.Automation.PSDataCollection<System.Management.Automation.VerboseRecord>
                collection, int
                index)
                {
                    var return_v = this_param.GetData<System.Management.Automation.VerboseRecord>(collection, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 48443, 48475);
                    return return_v;
                }


                string
                f_1604_48687_48701(System.Management.Automation.VerboseRecord
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 48687, 48701);
                    return return_v;
                }


                System.Management.Automation.Remoting.Internal.PSStreamObject
                f_1604_48640_48714(System.Management.Automation.Remoting.Internal.PSStreamObjectType
                objectType, string
                value, System.Guid
                id)
                {
                    var return_v = new System.Management.Automation.Remoting.Internal.PSStreamObject(objectType, (object)value, id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 48640, 48714);
                    return return_v;
                }


                int
                f_1604_48627_48715(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                this_param, System.Management.Automation.Remoting.Internal.PSStreamObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 48627, 48715);
                    return 0;
                }


                int
                f_1604_48804_48843(System.Threading.ReaderWriterLockSlim
                this_param)
                {
                    this_param.ExitReadLock();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 48804, 48843);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 47825, 48870);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 47825, 48870);
            }
        }

        private void Information_DataAdded(object sender, DataAddedEventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 48882, 49955);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 48984, 48995);
                lock (_syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 49029, 49053) || true) && (_isDisposed)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 49029, 49053);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 49046, 49053);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 49029, 49053);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 49084, 49113);

                f_1604_49084_49112(
                            _writeExistingData);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 49127, 49168);

                f_1604_49127_49167(_resultsReaderWriterLock);
                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 49218, 49247) || true) && (f_1604_49222_49238_M(!_results.IsOpen))
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 49218, 49247);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 49240, 49247);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 49218, 49247);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 49265, 49368);

                    PSDataCollection<InformationRecord>
                    informationRecords = sender as PSDataCollection<InformationRecord>
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 49386, 49479);

                    f_1604_49386_49478(informationRecords != null, "PSDataCollection is raising an inappropriate event");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 49497, 49561);

                    InformationRecord
                    record = f_1604_49524_49560(this, informationRecords, f_1604_49552_49559(e))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 49579, 49820) || true) && (record != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 49579, 49820);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 49716, 49801);

                        f_1604_49716_49800(                    // information records are already tagged, skip tagging
                                            _results, f_1604_49729_49799(PSStreamObjectType.Information, record, Guid.Empty));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 49579, 49820);
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1604, 49849, 49944);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 49889, 49929);

                    f_1604_49889_49928(_resultsReaderWriterLock);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1604, 49849, 49944);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 48882, 49955);

                bool
                f_1604_49084_49112(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.WaitOne();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 49084, 49112);
                    return return_v;
                }


                int
                f_1604_49127_49167(System.Threading.ReaderWriterLockSlim
                this_param)
                {
                    this_param.EnterReadLock();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 49127, 49167);
                    return 0;
                }


                bool
                f_1604_49222_49238_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 49222, 49238);
                    return return_v;
                }


                int
                f_1604_49386_49478(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 49386, 49478);
                    return 0;
                }


                int
                f_1604_49552_49559(System.Management.Automation.DataAddedEventArgs
                this_param)
                {
                    var return_v = this_param.Index;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 49552, 49559);
                    return return_v;
                }


                System.Management.Automation.InformationRecord
                f_1604_49524_49560(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, System.Management.Automation.PSDataCollection<System.Management.Automation.InformationRecord>
                collection, int
                index)
                {
                    var return_v = this_param.GetData<System.Management.Automation.InformationRecord>(collection, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 49524, 49560);
                    return return_v;
                }


                System.Management.Automation.Remoting.Internal.PSStreamObject
                f_1604_49729_49799(System.Management.Automation.Remoting.Internal.PSStreamObjectType
                objectType, System.Management.Automation.InformationRecord
                value, System.Guid
                id)
                {
                    var return_v = new System.Management.Automation.Remoting.Internal.PSStreamObject(objectType, (object)value, id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 49729, 49799);
                    return return_v;
                }


                int
                f_1604_49716_49800(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                this_param, System.Management.Automation.Remoting.Internal.PSStreamObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 49716, 49800);
                    return 0;
                }


                int
                f_1604_49889_49928(System.Threading.ReaderWriterLockSlim
                this_param)
                {
                    this_param.ExitReadLock();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 49889, 49928);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 48882, 49955);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 48882, 49955);
            }
        }

        private void Output_DataAdded(object sender, DataAddedEventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 49967, 50953);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 50064, 50075);
                lock (_syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 50109, 50133) || true) && (_isDisposed)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 50109, 50133);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 50126, 50133);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 50109, 50133);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 50164, 50193);

                f_1604_50164_50192(
                            _writeExistingData);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 50207, 50248);

                f_1604_50207_50247(_resultsReaderWriterLock);
                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 50298, 50327) || true) && (f_1604_50302_50318_M(!_results.IsOpen))
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 50298, 50327);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 50320, 50327);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 50298, 50327);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 50345, 50418);

                    PSDataCollection<PSObject>
                    output = sender as PSDataCollection<PSObject>
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 50436, 50517);

                    f_1604_50436_50516(output != null, "PSDataCollection is raising an inappropriate event");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 50535, 50575);

                    PSObject
                    obj = f_1604_50550_50574(this, output, f_1604_50566_50573(e))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 50593, 50818) || true) && (obj != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 50593, 50818);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 50722, 50799);

                        f_1604_50722_50798(                    // output objects are already tagged, skip tagging
                                            _results, f_1604_50735_50797(PSStreamObjectType.Output, obj, Guid.Empty));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 50593, 50818);
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1604, 50847, 50942);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 50887, 50927);

                    f_1604_50887_50926(_resultsReaderWriterLock);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1604, 50847, 50942);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 49967, 50953);

                bool
                f_1604_50164_50192(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.WaitOne();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 50164, 50192);
                    return return_v;
                }


                int
                f_1604_50207_50247(System.Threading.ReaderWriterLockSlim
                this_param)
                {
                    this_param.EnterReadLock();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 50207, 50247);
                    return 0;
                }


                bool
                f_1604_50302_50318_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 50302, 50318);
                    return return_v;
                }


                int
                f_1604_50436_50516(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 50436, 50516);
                    return 0;
                }


                int
                f_1604_50566_50573(System.Management.Automation.DataAddedEventArgs
                this_param)
                {
                    var return_v = this_param.Index;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 50566, 50573);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1604_50550_50574(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                collection, int
                index)
                {
                    var return_v = this_param.GetData<System.Management.Automation.PSObject>(collection, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 50550, 50574);
                    return return_v;
                }


                System.Management.Automation.Remoting.Internal.PSStreamObject
                f_1604_50735_50797(System.Management.Automation.Remoting.Internal.PSStreamObjectType
                objectType, System.Management.Automation.PSObject
                value, System.Guid
                id)
                {
                    var return_v = new System.Management.Automation.Remoting.Internal.PSStreamObject(objectType, (object)value, id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 50735, 50797);
                    return return_v;
                }


                int
                f_1604_50722_50798(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                this_param, System.Management.Automation.Remoting.Internal.PSStreamObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 50722, 50798);
                    return 0;
                }


                int
                f_1604_50887_50926(System.Threading.ReaderWriterLockSlim
                this_param)
                {
                    this_param.ExitReadLock();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 50887, 50926);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 49967, 50953);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 49967, 50953);
            }
        }

        private T GetData<T>(PSDataCollection<T> collection, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 50965, 51566);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 51053, 51514) || true) && (_flush)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 51053, 51514);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 51097, 51146);

                    Collection<T>
                    data = f_1604_51118_51145(collection, 1)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 51164, 51360) || true) && (f_1604_51168_51178(data) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 51164, 51360);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 51224, 51304);

                        f_1604_51224_51303(f_1604_51235_51245(data) == 1, "DataAdded should be raised for each object added");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 51326, 51341);

                        return f_1604_51333_51340(data, 0);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 51164, 51360);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 51481, 51499);

                    return default(T);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 51053, 51514);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 51530, 51555);

                return f_1604_51537_51554(collection, index);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 50965, 51566);

                System.Collections.ObjectModel.Collection<T>
                f_1604_51118_51145(System.Management.Automation.PSDataCollection<T>
                this_param, int
                readCount)
                {
                    var return_v = this_param.ReadAndRemove(readCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 51118, 51145);
                    return return_v;
                }


                int
                f_1604_51168_51178(System.Collections.ObjectModel.Collection<T>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 51168, 51178);
                    return return_v;
                }


                int
                f_1604_51235_51245(System.Collections.ObjectModel.Collection<T>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 51235, 51245);
                    return return_v;
                }


                int
                f_1604_51224_51303(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 51224, 51303);
                    return 0;
                }


                T
                f_1604_51333_51340(System.Collections.ObjectModel.Collection<T>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 51333, 51340);
                    return return_v;
                }


                T
                f_1604_51537_51554(System.Management.Automation.PSDataCollection<T>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 51537, 51554);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 50965, 51566);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 50965, 51566);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void StopAggregateResultsFromJob(Job job)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 51578, 53224);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 51652, 51684);

                f_1604_51652_51683(this, false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 51706, 51717);

                lock (_syncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 51751, 51913);

                    f_1604_51751_51912(_tracer, ClassNameTrace, "StopAggregateResultsFromJob", Guid.Empty, job, "Removing job from aggregation", null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 51931, 51964);

                    f_1604_51931_51963(_jobsBeingAggregated, job);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 51982, 52372) || true) && (f_1604_51986_52012(_jobsBeingAggregated) == 0 && (DynAbs.Tracing.TraceSender.Expression_True(1604, 51986, 52039) && _holdingResultsRef))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 51982, 52372);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 52081, 52258);

                        f_1604_52081_52257(_tracer, ClassNameTrace, "StopAggregateResultsFromJob", Guid.Empty, null, "Removing Ref to results collection", null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 52280, 52304);

                        f_1604_52280_52303(_results);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 52326, 52353);

                        _holdingResultsRef = false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 51982, 52372);
                    }
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 52403, 52548) || true) && (f_1604_52407_52434(job))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 52403, 52548);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 52468, 52533);

                    f_1604_52468_52532(job, _outputProcessingNotification);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 52403, 52548);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 52564, 53155) || true) && (f_1604_52568_52593(job))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 52564, 53155);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 52627, 52665);

                    f_1604_52627_52638(job).DataAdded -= ResultsAdded;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 52564, 53155);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 52564, 53155);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 52731, 52772);

                    f_1604_52731_52741(job).DataAdded -= Output_DataAdded;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 52790, 52829);

                    f_1604_52790_52799(job).DataAdded -= Error_DataAdded;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 52847, 52892);

                    f_1604_52847_52859(job).DataAdded -= Progress_DataAdded;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 52910, 52953);

                    f_1604_52910_52921(job).DataAdded -= Verbose_DataAdded;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 52971, 53014);

                    f_1604_52971_52982(job).DataAdded -= Warning_DataAdded;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 53032, 53071);

                    f_1604_53032_53041(job).DataAdded -= Debug_DataAdded;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 53089, 53140);

                    f_1604_53089_53104(job).DataAdded -= Information_DataAdded;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 52564, 53155);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 53171, 53213);

                job.StateChanged -= HandleJobStateChanged;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 51578, 53224);

                int
                f_1604_51652_51683(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, bool
                processingOutput)
                {
                    this_param.SetOutputProcessingState(processingOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 51652, 51683);
                    return 0;
                }


                int
                f_1604_51751_51912(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.Job
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 51751, 51912);
                    return 0;
                }


                bool
                f_1604_51931_51963(System.Collections.Generic.List<System.Management.Automation.Job>
                this_param, System.Management.Automation.Job
                item)
                {
                    var return_v = this_param.Remove(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 51931, 51963);
                    return return_v;
                }


                int
                f_1604_51986_52012(System.Collections.Generic.List<System.Management.Automation.Job>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 51986, 52012);
                    return return_v;
                }


                int
                f_1604_52081_52257(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.Job
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 52081, 52257);
                    return 0;
                }


                int
                f_1604_52280_52303(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                this_param)
                {
                    this_param.DecrementRef();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 52280, 52303);
                    return 0;
                }


                bool
                f_1604_52407_52434(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.MonitorOutputProcessing;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 52407, 52434);
                    return return_v;
                }


                int
                f_1604_52468_52532(System.Management.Automation.Job
                this_param, Microsoft.PowerShell.Commands.OutputProcessingState
                outputProcessingState)
                {
                    this_param.RemoveMonitorOutputProcessing((System.Management.Automation.IOutputProcessingState)outputProcessingState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 52468, 52532);
                    return 0;
                }


                bool
                f_1604_52568_52593(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.UsesResultsCollection;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 52568, 52593);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                f_1604_52627_52638(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Results;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 52627, 52638);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                f_1604_52731_52741(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Output;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 52731, 52741);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                f_1604_52790_52799(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Error;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 52790, 52799);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ProgressRecord>
                f_1604_52847_52859(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Progress;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 52847, 52859);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.VerboseRecord>
                f_1604_52910_52921(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Verbose;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 52910, 52921);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.WarningRecord>
                f_1604_52971_52982(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Warning;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 52971, 52982);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.DebugRecord>
                f_1604_53032_53041(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Debug;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 53032, 53041);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.InformationRecord>
                f_1604_53089_53104(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.Information;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 53089, 53104);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 51578, 53224);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 51578, 53224);
            }
        }

        private void AutoRemoveJobIfRequired(Job job)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 53236, 54905);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 53306, 53334) || true) && (!_autoRemoveJob)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 53306, 53334);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 53327, 53334);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 53306, 53334);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 53348, 53413) || true) && (!f_1604_53353_53404(_jobsSpecifiedInParameters, f_1604_53389_53403(job)))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 53348, 53413);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 53406, 53413);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 53348, 53413);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 53427, 53484) || true) && (!f_1604_53432_53475(job, f_1604_53452_53474(f_1604_53452_53468(job))))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 53427, 53484);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 53477, 53484);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 53427, 53484);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 53651, 53876) || true) && (f_1604_53655_53670(job))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 53651, 53876);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 53704, 53861);

                    f_1604_53704_53860(_tracer, ClassNameTrace, "AutoRemoveJobIfRequired", Guid.Empty, job, "Job has data and is being removed.");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 53651, 53876);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 53892, 53916);

                Job2
                job2 = job as Job2
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 53930, 54894) || true) && (job2 != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 53930, 54894);
#pragma warning disable 56500
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 54055, 54101);

                        f_1604_54055_54100(f_1604_54055_54065(), job2, this, false, true);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 54123, 54137);

                        f_1604_54123_54136(job);
                    }
                    catch (Exception ex)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1604, 54174, 54518);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 54465, 54499);

                        f_1604_54465_54498(this, job2, ex);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1604, 54174, 54518);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 53930, 54894);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 53930, 54894);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 54659, 54685);

                        f_1604_54659_54684(f_1604_54659_54672(), job);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 54707, 54721);

                        f_1604_54707_54720(job);
                    }
                    catch (ArgumentException ex)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1604, 54758, 54879);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 54827, 54860);

                        f_1604_54827_54859(this, job, ex);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1604, 54758, 54879);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 53930, 54894);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 53236, 54905);

                System.Guid
                f_1604_53389_53403(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 53389, 53403);
                    return return_v;
                }


                bool
                f_1604_53353_53404(System.Collections.Generic.List<System.Guid>
                this_param, System.Guid
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 53353, 53404);
                    return return_v;
                }


                System.Management.Automation.JobStateInfo
                f_1604_53452_53468(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 53452, 53468);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1604_53452_53474(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 53452, 53474);
                    return return_v;
                }


                bool
                f_1604_53432_53475(System.Management.Automation.Job
                this_param, System.Management.Automation.JobState
                state)
                {
                    var return_v = this_param.IsFinishedState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 53432, 53475);
                    return return_v;
                }


                bool
                f_1604_53655_53670(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.HasMoreData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 53655, 53670);
                    return return_v;
                }


                int
                f_1604_53704_53860(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.Job
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 53704, 53860);
                    return 0;
                }


                System.Management.Automation.JobManager
                f_1604_54055_54065()
                {
                    var return_v = JobManager;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 54055, 54065);
                    return return_v;
                }


                bool
                f_1604_54055_54100(System.Management.Automation.JobManager
                this_param, System.Management.Automation.Job2
                job, Microsoft.PowerShell.Commands.ReceiveJobCommand
                cmdlet, bool
                writeErrorOnException, bool
                throwExceptions)
                {
                    var return_v = this_param.RemoveJob(job, (System.Management.Automation.Cmdlet)cmdlet, writeErrorOnException, throwExceptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 54055, 54100);
                    return return_v;
                }


                int
                f_1604_54123_54136(System.Management.Automation.Job
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 54123, 54136);
                    return 0;
                }


                int
                f_1604_54465_54498(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, System.Management.Automation.Job2
                job, System.Exception
                ex)
                {
                    this_param.AddRemoveErrorToResults((System.Management.Automation.Job)job, ex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 54465, 54498);
                    return 0;
                }


                System.Management.Automation.JobRepository
                f_1604_54659_54672()
                {
                    var return_v = JobRepository;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 54659, 54672);
                    return return_v;
                }


                int
                f_1604_54659_54684(System.Management.Automation.JobRepository
                this_param, System.Management.Automation.Job
                item)
                {
                    this_param.Remove(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 54659, 54684);
                    return 0;
                }


                int
                f_1604_54707_54720(System.Management.Automation.Job
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 54707, 54720);
                    return 0;
                }


                int
                f_1604_54827_54859(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, System.Management.Automation.Job
                job, System.ArgumentException
                ex)
                {
                    this_param.AddRemoveErrorToResults(job, (System.Exception)ex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 54827, 54859);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 53236, 54905);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 53236, 54905);
            }
        }

        private void AddRemoveErrorToResults(Job job, Exception ex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 54917, 55342);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 55001, 55125);

                var
                ex2 = f_1604_55011_55124(f_1604_55033_55119(f_1604_55080_55118()), ex)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 55139, 55245);

                var
                removeError = f_1604_55157_55244(ex2, "ReceiveJobAutoRemovalError", ErrorCategory.InvalidOperation, job)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 55259, 55331);

                f_1604_55259_55330(_results, f_1604_55272_55329(PSStreamObjectType.Error, removeError));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 54917, 55342);

                string
                f_1604_55080_55118()
                {
                    var return_v = RemotingErrorIdStrings.CannotRemoveJob;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 55080, 55118);
                    return return_v;
                }


                string
                f_1604_55033_55119(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSRemotingErrorInvariants.FormatResourceString(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 55033, 55119);
                    return return_v;
                }


                System.ArgumentException
                f_1604_55011_55124(string
                message, System.Exception
                innerException)
                {
                    var return_v = new System.ArgumentException(message, innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 55011, 55124);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1604_55157_55244(System.ArgumentException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.Job
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 55157, 55244);
                    return return_v;
                }


                System.Management.Automation.Remoting.Internal.PSStreamObject
                f_1604_55272_55329(System.Management.Automation.Remoting.Internal.PSStreamObjectType
                objectType, System.Management.Automation.ErrorRecord
                value)
                {
                    var return_v = new System.Management.Automation.Remoting.Internal.PSStreamObject(objectType, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 55272, 55329);
                    return return_v;
                }


                int
                f_1604_55259_55330(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                this_param, System.Management.Automation.Remoting.Internal.PSStreamObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 55259, 55330);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 54917, 55342);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 54917, 55342);
            }
        }

        private void WriteJobResultsRecursively(Job job, bool registerInsteadOfWrite)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 55659, 55953);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 55761, 55807);

                Hashtable
                duplicateDetector = f_1604_55791_55806()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 55821, 55902);

                f_1604_55821_55901(this, duplicateDetector, job, registerInsteadOfWrite);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 55916, 55942);

                f_1604_55916_55941(duplicateDetector);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 55659, 55953);

                System.Collections.Hashtable
                f_1604_55791_55806()
                {
                    var return_v = new System.Collections.Hashtable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 55791, 55806);
                    return return_v;
                }


                int
                f_1604_55821_55901(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, System.Collections.Hashtable
                duplicate, System.Management.Automation.Job
                job, bool
                registerInsteadOfWrite)
                {
                    this_param.WriteJobResultsRecursivelyHelper(duplicate, job, registerInsteadOfWrite);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 55821, 55901);
                    return 0;
                }


                int
                f_1604_55916_55941(System.Collections.Hashtable
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 55916, 55941);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 55659, 55953);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 55659, 55953);
            }
        }

        private void WriteResultsForJobsInCollection(List<Job> jobs, bool checkForRecurse, bool registerInsteadOfWrite)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 56164, 57366);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 56300, 57355);
                    foreach (Job job in f_1604_56320_56324_I(jobs))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 56300, 57355);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 56358, 57340) || true) && (checkForRecurse && (DynAbs.Tracing.TraceSender.Expression_True(1604, 56362, 56389) && _recurse))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 56358, 57340);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 56431, 56487);

                            f_1604_56431_56486(this, job, registerInsteadOfWrite);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 56358, 57340);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 56358, 57340);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 56569, 57321) || true) && (registerInsteadOfWrite)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 56569, 57321);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 57016, 57058);

                                _eventArgsWritten[f_1604_57034_57048(job)] = false;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 57084, 57113);

                                f_1604_57084_57112(this, job);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 56569, 57321);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 56569, 57321);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 57211, 57232);

                                f_1604_57211_57231(this, job);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 57258, 57298);

                                f_1604_57258_57297(this, job);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 56569, 57321);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 56358, 57340);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 56300, 57355);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1604, 1, 1056);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1604, 1, 1056);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 56164, 57366);

                int
                f_1604_56431_56486(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, System.Management.Automation.Job
                job, bool
                registerInsteadOfWrite)
                {
                    this_param.WriteJobResultsRecursively(job, registerInsteadOfWrite);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 56431, 56486);
                    return 0;
                }


                System.Guid
                f_1604_57034_57048(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 57034, 57048);
                    return return_v;
                }


                int
                f_1604_57084_57112(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, System.Management.Automation.Job
                job)
                {
                    this_param.AggregateResultsFromJob(job);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 57084, 57112);
                    return 0;
                }


                int
                f_1604_57211_57231(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, System.Management.Automation.Job
                job)
                {
                    this_param.WriteJobResults(job);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 57211, 57231);
                    return 0;
                }


                int
                f_1604_57258_57297(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, System.Management.Automation.Job
                job)
                {
                    this_param.WriteJobStateInformationIfRequired(job);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 57258, 57297);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.Job>
                f_1604_56320_56324_I(System.Collections.Generic.List<System.Management.Automation.Job>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 56320, 56324);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 56164, 57366);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 56164, 57366);
            }
        }

        private readonly Dictionary<Guid, bool> _eventArgsWritten;

        private void WriteJobStateInformation(Job job, JobStateEventArgs args = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 57477, 58821);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 57890, 57908);

                bool
                eventWritten
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 57922, 57986);

                f_1604_57922_57985(_eventArgsWritten, f_1604_57952_57966(job), out eventWritten);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 58002, 58279) || true) && (eventWritten)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 58002, 58279);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 58052, 58239);

                    f_1604_58052_58238(_tracer, ClassNameTrace, "WriteJobStateInformation", Guid.Empty, job, "State information already written, skipping another write", null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 58257, 58264);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 58002, 58279);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 58295, 58373);

                JobStateEventArgs
                eventArgs = args ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.JobStateEventArgs>(1604, 58325, 58372) ?? f_1604_58333_58372(f_1604_58355_58371(job)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 58387, 58428);

                _eventArgsWritten[f_1604_58405_58419(job)] = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 58444, 58572);

                f_1604_58444_58571(
                            _tracer, ClassNameTrace, "WriteJobStateInformation", Guid.Empty, job, "Writing job state changed event args", null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 58586, 58625);

                PSObject
                obj = f_1604_58601_58624(eventArgs)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 58639, 58715);

                f_1604_58639_58714(f_1604_58639_58653(obj), f_1604_58658_58713(RemotingConstants.EventObject, true));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 58729, 58810);

                f_1604_58729_58809(_results, f_1604_58742_58808(PSStreamObjectType.Output, obj, f_1604_58793_58807(job)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 57477, 58821);

                System.Guid
                f_1604_57952_57966(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 57952, 57966);
                    return return_v;
                }


                bool
                f_1604_57922_57985(System.Collections.Generic.Dictionary<System.Guid, bool>
                this_param, System.Guid
                key, out bool
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 57922, 57985);
                    return return_v;
                }


                int
                f_1604_58052_58238(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.Job
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 58052, 58238);
                    return 0;
                }


                System.Management.Automation.JobStateInfo
                f_1604_58355_58371(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 58355, 58371);
                    return return_v;
                }


                System.Management.Automation.JobStateEventArgs
                f_1604_58333_58372(System.Management.Automation.JobStateInfo
                jobStateInfo)
                {
                    var return_v = new System.Management.Automation.JobStateEventArgs(jobStateInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 58333, 58372);
                    return return_v;
                }


                System.Guid
                f_1604_58405_58419(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 58405, 58419);
                    return return_v;
                }


                int
                f_1604_58444_58571(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, System.Management.Automation.Job
                job, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, job, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 58444, 58571);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1604_58601_58624(System.Management.Automation.JobStateEventArgs
                obj)
                {
                    var return_v = new System.Management.Automation.PSObject((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 58601, 58624);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1604_58639_58653(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 58639, 58653);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1604_58658_58713(string
                name, bool
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 58658, 58713);
                    return return_v;
                }


                int
                f_1604_58639_58714(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 58639, 58714);
                    return 0;
                }


                System.Guid
                f_1604_58793_58807(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 58793, 58807);
                    return return_v;
                }


                System.Management.Automation.Remoting.Internal.PSStreamObject
                f_1604_58742_58808(System.Management.Automation.Remoting.Internal.PSStreamObjectType
                objectType, System.Management.Automation.PSObject
                value, System.Guid
                id)
                {
                    var return_v = new System.Management.Automation.Remoting.Internal.PSStreamObject(objectType, (object)value, id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 58742, 58808);
                    return return_v;
                }


                int
                f_1604_58729_58809(System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
                this_param, System.Management.Automation.Remoting.Internal.PSStreamObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 58729, 58809);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 57477, 58821);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 57477, 58821);
            }
        }

        private void WriteJobStateInformationIfRequired(Job job, JobStateEventArgs args = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 58833, 59163);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 58945, 59107) || true) && (_writeStateChangedEvents && (DynAbs.Tracing.TraceSender.Expression_True(1604, 58949, 59022) && f_1604_58977_59022(job, f_1604_58999_59021(f_1604_58999_59015(job)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 58945, 59107);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 59056, 59092);

                    f_1604_59056_59091(this, job, args);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 58945, 59107);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 59123, 59152);

                f_1604_59123_59151(this, job);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 58833, 59163);

                System.Management.Automation.JobStateInfo
                f_1604_58999_59015(System.Management.Automation.Job
                this_param)
                {
                    var return_v = this_param.JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 58999, 59015);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1604_58999_59021(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 58999, 59021);
                    return return_v;
                }


                bool
                f_1604_58977_59022(System.Management.Automation.Job
                this_param, System.Management.Automation.JobState
                state)
                {
                    var return_v = this_param.IsPersistentState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 58977, 59022);
                    return return_v;
                }


                int
                f_1604_59056_59091(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, System.Management.Automation.Job
                job, System.Management.Automation.JobStateEventArgs
                args)
                {
                    this_param.WriteJobStateInformation(job, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 59056, 59091);
                    return 0;
                }


                int
                f_1604_59123_59151(Microsoft.PowerShell.Commands.ReceiveJobCommand
                this_param, System.Management.Automation.Job
                job)
                {
                    this_param.AutoRemoveJobIfRequired(job);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 59123, 59151);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 58833, 59163);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 58833, 59163);
            }
        }

        private void ValidateWait()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 59175, 59406);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 59227, 59395) || true) && (_wait && (DynAbs.Tracing.TraceSender.Expression_True(1604, 59231, 59247) && !_flush))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 59227, 59395);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 59281, 59380);

                    throw f_1604_59287_59379(f_1604_59330_59378());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 59227, 59395);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 59175, 59406);

                string
                f_1604_59330_59378()
                {
                    var return_v = RemotingErrorIdStrings.BlockCannotBeUsedWithKeep;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 59330, 59378);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1604_59287_59379(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 59287, 59379);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 59175, 59406);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 59175, 59406);
            }
        }

        private void ValidateWriteEvents()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 59418, 59683);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 59477, 59672) || true) && (_writeStateChangedEvents && (DynAbs.Tracing.TraceSender.Expression_True(1604, 59481, 59515) && !_wait))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 59477, 59672);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 59549, 59657);

                    throw f_1604_59555_59656(f_1604_59598_59655());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 59477, 59672);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 59418, 59683);

                string
                f_1604_59598_59655()
                {
                    var return_v = RemotingErrorIdStrings.WriteEventsCannotBeUsedWithoutWait;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 59598, 59655);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1604_59555_59656(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 59555, 59656);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 59418, 59683);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 59418, 59683);
            }
        }

        private void ValidateAutoRemove()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 59695, 59948);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 59753, 59937) || true) && (_autoRemoveJob && (DynAbs.Tracing.TraceSender.Expression_True(1604, 59757, 59781) && !_wait))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 59753, 59937);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 59815, 59922);

                    throw f_1604_59821_59921(f_1604_59864_59920());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 59753, 59937);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 59695, 59948);

                string
                f_1604_59864_59920()
                {
                    var return_v = RemotingErrorIdStrings.AutoRemoveCannotBeUsedWithoutWait;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 59864, 59920);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1604_59821_59921(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 59821, 59921);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 59695, 59948);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 59695, 59948);
            }
        }

        private void ValidateForce()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 59960, 60194);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 60013, 60183) || true) && (f_1604_60017_60022() && (DynAbs.Tracing.TraceSender.Expression_True(1604, 60017, 60032) && !_wait))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 60013, 60183);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 60066, 60168);

                    throw f_1604_60072_60167(f_1604_60115_60166());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 60013, 60183);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 59960, 60194);

                System.Management.Automation.SwitchParameter
                f_1604_60017_60022()
                {
                    var return_v = Force;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 60017, 60022);
                    return return_v;
                }


                string
                f_1604_60115_60166()
                {
                    var return_v = RemotingErrorIdStrings.ForceCannotBeUsedWithoutWait;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 60115, 60166);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1604_60072_60167(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 60072, 60167);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 59960, 60194);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 59960, 60194);
            }
        }

        private void ValidateWriteJobInResults()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 60206, 60474);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 60271, 60463) || true) && (_outputJobFirst && (DynAbs.Tracing.TraceSender.Expression_True(1604, 60275, 60300) && !_wait))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 60271, 60463);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 60334, 60448);

                    throw f_1604_60340_60447(f_1604_60383_60446());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 60271, 60463);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 60206, 60474);

                string
                f_1604_60383_60446()
                {
                    var return_v = RemotingErrorIdStrings.WriteJobInResultsCannotBeUsedWithoutWait;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1604, 60383, 60446);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1604_60340_60447(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 60340, 60447);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 60206, 60474);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 60206, 60474);
            }
        }

        private void SetOutputProcessingState(bool processingOutput)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 60563, 61153);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 60648, 60666);

                bool
                stateChanged
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 60686, 60697);
                lock (_syncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 60731, 60786);

                    stateChanged = (processingOutput != _processingOutput);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 60804, 60918) || true) && (stateChanged)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 60804, 60918);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 60862, 60899);

                        _processingOutput = processingOutput;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 60804, 60918);
                    }
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 60949, 61142) || true) && (_outputProcessingNotification != null && (DynAbs.Tracing.TraceSender.Expression_True(1604, 60953, 61006) && stateChanged))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1604, 60949, 61142);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 61040, 61127);

                    f_1604_61040_61126(_outputProcessingNotification, processingOutput);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1604, 60949, 61142);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 60563, 61153);

                int
                f_1604_61040_61126(Microsoft.PowerShell.Commands.OutputProcessingState
                this_param, bool
                processingOutput)
                {
                    this_param.RaiseOutputProcessingStateChangedEvent(processingOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 61040, 61126);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 60563, 61153);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 60563, 61153);
            }
        }

        public ReceiveJobCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1604, 2463, 61182);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 4043, 4048);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 4784, 4798);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 5502, 5512);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 6215, 6235);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 6720, 6733);
            this._flush = true;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 7062, 7077);
            this._recurse = true;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 9104, 9118);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 9142, 9166);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 9190, 9195);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 9219, 9230);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 9254, 9265);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 9314, 9367);
            this._resultsReaderWriterLock = f_1604_9341_9367();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 9417, 9472);
            this._tracer = f_1604_9427_9472();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 9517, 9564);
            this._writeExistingData = f_1604_9538_9564(true);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 9625, 9674);
            this._results = f_1604_9636_9674();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 9698, 9716);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 9754, 9792);
            this._jobsBeingAggregated = f_1604_9777_9792();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 9831, 9876);
            this._jobsSpecifiedInParameters = f_1604_9860_9876();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 9911, 9937);
            this._syncObject = f_1604_9925_9937();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 9961, 9976);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 10017, 10046);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 10070, 10087);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 57418, 57466);
            this._eventArgsWritten = f_1604_57438_57466();
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1604, 2463, 61182);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 2463, 61182);
        }


        static ReceiveJobCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1604, 2463, 61182);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 7833, 7866);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 10121, 10157);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1604, 2463, 61182);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 2463, 61182);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1604, 2463, 61182);

        System.Threading.ReaderWriterLockSlim
        f_1604_9341_9367()
        {
            var return_v = new System.Threading.ReaderWriterLockSlim();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 9341, 9367);
            return return_v;
        }


        System.Management.Automation.Tracing.PowerShellTraceSource
        f_1604_9427_9472()
        {
            var return_v = PowerShellTraceSourceFactory.GetTraceSource();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 9427, 9472);
            return return_v;
        }


        System.Threading.ManualResetEvent
        f_1604_9538_9564(bool
        initialState)
        {
            var return_v = new System.Threading.ManualResetEvent(initialState);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 9538, 9564);
            return return_v;
        }


        System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>
        f_1604_9636_9674()
        {
            var return_v = new System.Management.Automation.PSDataCollection<System.Management.Automation.Remoting.Internal.PSStreamObject>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 9636, 9674);
            return return_v;
        }


        System.Collections.Generic.List<System.Management.Automation.Job>
        f_1604_9777_9792()
        {
            var return_v = new System.Collections.Generic.List<System.Management.Automation.Job>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 9777, 9792);
            return return_v;
        }


        System.Collections.Generic.List<System.Guid>
        f_1604_9860_9876()
        {
            var return_v = new System.Collections.Generic.List<System.Guid>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 9860, 9876);
            return return_v;
        }


        object
        f_1604_9925_9937()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 9925, 9937);
            return return_v;
        }


        System.Collections.Generic.Dictionary<System.Guid, bool>
        f_1604_57438_57466()
        {
            var return_v = new System.Collections.Generic.Dictionary<System.Guid, bool>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 57438, 57466);
            return return_v;
        }

    }
    internal class OutputProcessingState : IOutputProcessingState
    {
        public event EventHandler<OutputProcessingStateEventArgs>
OutputProcessingStateChanged
;

        internal void RaiseOutputProcessingStateChangedEvent(bool processingOutput)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1604, 61404, 61802);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1604, 61540, 61715);

                    f_1604_61540_61714(OutputProcessingStateChanged, this, f_1604_61661_61713(processingOutput));
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1604, 61744, 61791);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1604, 61744, 61791);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1604, 61404, 61802);

                System.Management.Automation.OutputProcessingStateEventArgs
                f_1604_61661_61713(bool
                processingOutput)
                {
                    var return_v = new System.Management.Automation.OutputProcessingStateEventArgs(processingOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 61661, 61713);
                    return return_v;
                }


                int
                f_1604_61540_61714(System.EventHandler<System.Management.Automation.OutputProcessingStateEventArgs>
                eventHandler, Microsoft.PowerShell.Commands.OutputProcessingState
                sender, System.Management.Automation.OutputProcessingStateEventArgs
                eventArgs)
                {
                    eventHandler.SafeInvoke<System.Management.Automation.OutputProcessingStateEventArgs>((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1604, 61540, 61714);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1604, 61404, 61802);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 61404, 61802);
            }
        }

        public OutputProcessingState()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1604, 61227, 61809);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1604, 61227, 61809);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 61227, 61809);
        }


        static OutputProcessingState()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1604, 61227, 61809);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1604, 61227, 61809);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1604, 61227, 61809);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1604, 61227, 61809);
    }

}
