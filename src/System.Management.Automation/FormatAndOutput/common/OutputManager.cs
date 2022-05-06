// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Management.Automation;
using System.Management.Automation.Internal;

namespace Microsoft.PowerShell.Commands.Internal.Format
{
    internal sealed class OutputManagerInner : ImplementationCommandBase
    {
        [TraceSource("format_out_OutputManagerInner", "OutputManagerInner")]
        internal static PSTraceSource tracer;

        internal LineOutput LineOutput
        {
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1099, 1060, 1331);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 1102, 1111);
                    lock (_syncRoot)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 1153, 1165);

                        _lo = value;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 1189, 1297) || true) && (_isStopped)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1099, 1189, 1297);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 1253, 1274);

                            f_1099_1253_1273(_lo);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1099, 1189, 1297);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1099, 1060, 1331);

                    int
                    f_1099_1253_1273(Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                    this_param)
                    {
                        this_param.StopProcessing();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1099, 1253, 1273);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1099, 1005, 1342);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1099, 1005, 1342);
                }
            }
        }

        private LineOutput _lo;

        internal override void ProcessRecord()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1099, 1605, 2656);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 1668, 1700);

                PSObject
                so = f_1099_1682_1699(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 1716, 1816) || true) && (so == null || (DynAbs.Tracing.TraceSender.Expression_False(1099, 1720, 1760) || so == f_1099_1740_1760()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1099, 1716, 1816);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 1794, 1801);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1099, 1716, 1816);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 1935, 2099) || true) && (_mgr == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1099, 1935, 2099);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 1985, 2017);

                    _mgr = f_1099_1992_2016();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 2035, 2084);

                    f_1099_2035_2083(_mgr, _lo, f_1099_2056_2082(f_1099_2056_2074(this)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1099, 1935, 2099);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 2620, 2637);

                f_1099_2620_2636(
                            _mgr, so);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1099, 1605, 2656);

                System.Management.Automation.PSObject
                f_1099_1682_1699(Microsoft.PowerShell.Commands.Internal.Format.OutputManagerInner
                this_param)
                {
                    var return_v = this_param.ReadObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1099, 1682, 1699);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1099_1740_1760()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1099, 1740, 1760);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.SubPipelineManager
                f_1099_1992_2016()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.SubPipelineManager();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1099, 1992, 2016);
                    return return_v;
                }


                System.Management.Automation.PSCmdlet
                f_1099_2056_2074(Microsoft.PowerShell.Commands.Internal.Format.OutputManagerInner
                this_param)
                {
                    var return_v = this_param.OuterCmdlet();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1099, 2056, 2074);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1099_2056_2082(System.Management.Automation.PSCmdlet
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1099, 2056, 2082);
                    return return_v;
                }


                int
                f_1099_2035_2083(Microsoft.PowerShell.Commands.Internal.Format.SubPipelineManager
                this_param, Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                lineOutput, System.Management.Automation.ExecutionContext
                context)
                {
                    this_param.Initialize(lineOutput, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1099, 2035, 2083);
                    return 0;
                }


                int
                f_1099_2620_2636(Microsoft.PowerShell.Commands.Internal.Format.SubPipelineManager
                this_param, System.Management.Automation.PSObject
                so)
                {
                    this_param.Process(so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1099, 2620, 2636);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1099, 1605, 2656);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1099, 1605, 2656);
            }
        }

        internal override void EndProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1099, 2828, 3023);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 2961, 3012) || true) && (_mgr != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1099, 2961, 3012);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 2996, 3012);

                    f_1099_2996_3011(_mgr);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1099, 2961, 3012);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1099, 2828, 3023);

                int
                f_1099_2996_3011(Microsoft.PowerShell.Commands.Internal.Format.SubPipelineManager
                this_param)
                {
                    this_param.ShutDown();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1099, 2996, 3011);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1099, 2828, 3023);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1099, 2828, 3023);
            }
        }

        internal override void StopProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1099, 3035, 3309);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 3105, 3114);
                lock (_syncRoot)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 3148, 3245) || true) && (_lo != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1099, 3148, 3245);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 3205, 3226);

                        f_1099_3205_3225(_lo);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1099, 3148, 3245);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 3265, 3283);

                    _isStopped = true;
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1099, 3035, 3309);

                int
                f_1099_3205_3225(Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                this_param)
                {
                    this_param.StopProcessing();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1099, 3205, 3225);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1099, 3035, 3309);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1099, 3035, 3309);
            }
        }

        protected override void InternalDispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1099, 3431, 3655);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 3497, 3520);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InternalDispose(), 1099, 3497, 3519);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 3534, 3644) || true) && (_mgr != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1099, 3534, 3644);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 3584, 3599);

                    f_1099_3584_3598(_mgr);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 3617, 3629);

                    _mgr = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1099, 3534, 3644);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1099, 3431, 3655);

                int
                f_1099_3584_3598(Microsoft.PowerShell.Commands.Internal.Format.SubPipelineManager
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1099, 3584, 3598);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1099, 3431, 3655);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1099, 3431, 3655);
            }
        }

        private SubPipelineManager _mgr;

        private bool _isStopped;

        private object _syncRoot;

        public OutputManagerInner()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1099, 633, 4080);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 1373, 1383);
            this._lo = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 3795, 3806);
            this._mgr = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 3929, 3947);
            this._isStopped = false;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 4048, 4072);
            this._syncRoot = f_1099_4060_4072();
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1099, 633, 4080);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1099, 633, 4080);
        }


        static OutputManagerInner()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1099, 633, 4080);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 850, 937);
            tracer = f_1099_859_937("format_out_OutputManagerInner", "OutputManagerInner");
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1099, 633, 4080);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1099, 633, 4080);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1099, 633, 4080);

        static System.Management.Automation.PSTraceSource
        f_1099_859_937(string
        name, string
        description)
        {
            var return_v = PSTraceSource.GetTracer(name, description);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1099, 859, 937);
            return return_v;
        }


        object
        f_1099_4060_4072()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1099, 4060, 4072);
            return return_v;
        }

    }
    internal sealed class SubPipelineManager : IDisposable
    {
        private sealed class CommandEntry : IDisposable
        {
            internal CommandWrapper command;

            internal bool AppliesToType(string typeName)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1099, 4918, 5246);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 4995, 5198);
                        foreach (string s in f_1099_5016_5032_I(_applicableTypes))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1099, 4995, 5198);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 5074, 5179) || true) && (f_1099_5078_5140(s, typeName, StringComparison.OrdinalIgnoreCase))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1099, 5074, 5179);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 5167, 5179);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1099, 5074, 5179);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1099, 4995, 5198);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1099, 1, 204);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1099, 1, 204);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 5218, 5231);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1099, 4918, 5246);

                    bool
                    f_1099_5078_5140(string
                    a, string
                    b, System.StringComparison
                    comparisonType)
                    {
                        var return_v = string.Equals(a, b, comparisonType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1099, 5078, 5140);
                        return return_v;
                    }


                    System.Collections.Specialized.StringCollection
                    f_1099_5016_5032_I(System.Collections.Specialized.StringCollection
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1099, 5016, 5032);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1099, 4918, 5246);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1099, 4918, 5246);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public void Dispose()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1099, 5377, 5581);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 5431, 5485) || true) && (this.command == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1099, 5431, 5485);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 5478, 5485);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1099, 5431, 5485);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 5505, 5528);

                    f_1099_5505_5527(
                                    this.command);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 5546, 5566);

                    this.command = null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1099, 5377, 5581);

                    int
                    f_1099_5505_5527(Microsoft.PowerShell.Commands.Internal.Format.CommandWrapper
                    this_param)
                    {
                        this_param.Dispose();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1099, 5505, 5527);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1099, 5377, 5581);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1099, 5377, 5581);
                }
            }

            private StringCollection _applicableTypes;

            public CommandEntry()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1099, 4461, 5803);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 4666, 4696);
                this.command = f_1099_4676_4696();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 5750, 5791);
                this._applicableTypes = f_1099_5769_5791();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1099, 4461, 5803);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1099, 4461, 5803);
            }


            static CommandEntry()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1099, 4461, 5803);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1099, 4461, 5803);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1099, 4461, 5803);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1099, 4461, 5803);

            Microsoft.PowerShell.Commands.Internal.Format.CommandWrapper
            f_1099_4676_4696()
            {
                var return_v = new Microsoft.PowerShell.Commands.Internal.Format.CommandWrapper();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1099, 4676, 4696);
                return return_v;
            }


            System.Collections.Specialized.StringCollection
            f_1099_5769_5791()
            {
                var return_v = new System.Collections.Specialized.StringCollection();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1099, 5769, 5791);
                return return_v;
            }

        }

        internal void Initialize(LineOutput lineOutput, ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1099, 6120, 6297);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 6218, 6235);

                _lo = lineOutput;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 6249, 6286);

                f_1099_6249_6285(this, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1099, 6120, 6297);

                int
                f_1099_6249_6285(Microsoft.PowerShell.Commands.Internal.Format.SubPipelineManager
                this_param, System.Management.Automation.ExecutionContext
                context)
                {
                    this_param.InitializeCommandsHardWired(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1099, 6249, 6285);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1099, 6120, 6297);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1099, 6120, 6297);
            }
        }

        private void InitializeCommandsHardWired(ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1099, 6514, 7882);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 6645, 6725);

                f_1099_6645_6724(this, context, "out-lineoutput", typeof(OutLineOutputCommand));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1099, 6514, 7882);

                int
                f_1099_6645_6724(Microsoft.PowerShell.Commands.Internal.Format.SubPipelineManager
                this_param, System.Management.Automation.ExecutionContext
                context, string
                commandName, System.Type
                commandType)
                {
                    this_param.RegisterCommandDefault(context, commandName, commandType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1099, 6645, 6724);
                    return 0;
                }

                /*
                NOTE:
                This is the spot where we could add new specialized handlers for
                additional types. Adding a handler here would cause a new sub-pipeline
                to be created.

                For example, the following line would add a new handler named "out-foobar"
                to be invoked when the incoming object type is "MyNamespace.Whatever.FooBar"

                RegisterCommandForTypes (context, "out-foobar", new string[] { "MyNamespace.Whatever.FooBar" });

                And the method can be like this:
                private void RegisterCommandForTypes (ExecutionContext context, string commandName, Type commandType, string[] types)
                {
                    CommandEntry ce = new CommandEntry ();

                    ce.command.Initialize (context, commandName, commandType);
                    ce.command.AddNamedParameter ("LineOutput", this.lo);
                    for (int k = 0; k < types.Length; k++)
                    {
                        ce.AddApplicableType (types[k]);
                    }

                    this.commandEntryList.Add (ce);
                }
                */
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1099, 6514, 7882);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1099, 6514, 7882);
            }
        }

        private void RegisterCommandDefault(ExecutionContext context, string commandName, Type commandType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1099, 8240, 8587);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 8364, 8401);

                CommandEntry
                ce = f_1099_8382_8400()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 8417, 8474);

                f_1099_8417_8473(
                            ce.command, context, commandName, commandType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 8488, 8536);

                f_1099_8488_8535(ce.command, "LineOutput", _lo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 8550, 8576);

                _defaultCommandEntry = ce;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1099, 8240, 8587);

                Microsoft.PowerShell.Commands.Internal.Format.SubPipelineManager.CommandEntry
                f_1099_8382_8400()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.SubPipelineManager.CommandEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1099, 8382, 8400);
                    return return_v;
                }


                int
                f_1099_8417_8473(Microsoft.PowerShell.Commands.Internal.Format.CommandWrapper
                this_param, System.Management.Automation.ExecutionContext
                execContext, string
                nameOfCommand, System.Type
                typeOfCommand)
                {
                    this_param.Initialize(execContext, nameOfCommand, typeOfCommand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1099, 8417, 8473);
                    return 0;
                }


                int
                f_1099_8488_8535(Microsoft.PowerShell.Commands.Internal.Format.CommandWrapper
                this_param, string
                parameterName, Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                parameterValue)
                {
                    this_param.AddNamedParameter(parameterName, (object)parameterValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1099, 8488, 8535);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1099, 8240, 8587);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1099, 8240, 8587);
            }
        }

        internal void Process(PSObject so)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1099, 8769, 9113);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 8891, 8940);

                CommandEntry
                ce = f_1099_8909_8939(this, so)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 8956, 9023);

                f_1099_8956_9022(ce != null, "CommandEntry ce must not be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 9079, 9102);

                f_1099_9079_9101(
                            // delegate the processing
                            ce.command, so);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1099, 8769, 9113);

                Microsoft.PowerShell.Commands.Internal.Format.SubPipelineManager.CommandEntry
                f_1099_8909_8939(Microsoft.PowerShell.Commands.Internal.Format.SubPipelineManager
                this_param, System.Management.Automation.PSObject
                so)
                {
                    var return_v = this_param.GetActiveCommandEntry(so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1099, 8909, 8939);
                    return return_v;
                }


                int
                f_1099_8956_9022(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1099, 8956, 9022);
                    return 0;
                }


                System.Array
                f_1099_9079_9101(Microsoft.PowerShell.Commands.Internal.Format.CommandWrapper
                this_param, System.Management.Automation.PSObject
                o)
                {
                    var return_v = this_param.Process((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1099, 9079, 9101);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1099, 8769, 9113);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1099, 8769, 9113);
            }
        }

        internal void ShutDown()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1099, 9216, 9818);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 9327, 9542);
                    foreach (CommandEntry ce in f_1099_9355_9372_I(_commandEntryList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1099, 9327, 9542);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 9406, 9451);

                        f_1099_9406_9450(ce != null, "ce != null");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 9469, 9491);

                        f_1099_9469_9490(ce.command);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 9509, 9527);

                        ce.command = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1099, 9327, 9542);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1099, 1, 216);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1099, 1, 216);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 9623, 9703);

                f_1099_9623_9702(_defaultCommandEntry != null, "defaultCommandEntry != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 9717, 9757);

                f_1099_9717_9756(_defaultCommandEntry.command);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 9771, 9807);

                _defaultCommandEntry.command = null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1099, 9216, 9818);

                int
                f_1099_9406_9450(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1099, 9406, 9450);
                    return 0;
                }


                System.Array
                f_1099_9469_9490(Microsoft.PowerShell.Commands.Internal.Format.CommandWrapper
                this_param)
                {
                    var return_v = this_param.ShutDown();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1099, 9469, 9490);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.SubPipelineManager.CommandEntry>
                f_1099_9355_9372_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.SubPipelineManager.CommandEntry>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1099, 9355, 9372);
                    return return_v;
                }


                int
                f_1099_9623_9702(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1099, 9623, 9702);
                    return 0;
                }


                System.Array
                f_1099_9717_9756(Microsoft.PowerShell.Commands.Internal.Format.CommandWrapper
                this_param)
                {
                    var return_v = this_param.ShutDown();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1099, 9717, 9756);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1099, 9216, 9818);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1099, 9216, 9818);
            }
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1099, 9830, 10325);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 9938, 10108);
                    foreach (CommandEntry ce in f_1099_9966_9983_I(_commandEntryList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1099, 9938, 10108);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 10017, 10062);

                        f_1099_10017_10061(ce != null, "ce != null");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 10080, 10093);

                        f_1099_10080_10092(ce);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1099, 9938, 10108);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1099, 1, 171);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1099, 1, 171);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 10189, 10269);

                f_1099_10189_10268(_defaultCommandEntry != null, "defaultCommandEntry != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 10283, 10314);

                f_1099_10283_10313(_defaultCommandEntry);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1099, 9830, 10325);

                int
                f_1099_10017_10061(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1099, 10017, 10061);
                    return 0;
                }


                int
                f_1099_10080_10092(Microsoft.PowerShell.Commands.Internal.Format.SubPipelineManager.CommandEntry
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1099, 10080, 10092);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.SubPipelineManager.CommandEntry>
                f_1099_9966_9983_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.SubPipelineManager.CommandEntry>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1099, 9966, 9983);
                    return return_v;
                }


                int
                f_1099_10189_10268(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1099, 10189, 10268);
                    return 0;
                }


                int
                f_1099_10283_10313(Microsoft.PowerShell.Commands.Internal.Format.SubPipelineManager.CommandEntry
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1099, 10283, 10313);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1099, 9830, 10325);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1099, 9830, 10325);
            }
        }

        private CommandEntry GetActiveCommandEntry(PSObject so)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1099, 10645, 11089);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 10725, 10802);

                string
                typeName = f_1099_10743_10801(f_1099_10780_10800(so))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 10816, 10973);
                    foreach (CommandEntry ce in f_1099_10844_10861_I(_commandEntryList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1099, 10816, 10973);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 10895, 10958) || true) && (f_1099_10899_10925(ce, typeName))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1099, 10895, 10958);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 10948, 10958);

                            return ce;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1099, 10895, 10958);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1099, 10816, 10973);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1099, 1, 158);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1099, 1, 158);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 11050, 11078);

                return _defaultCommandEntry;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1099, 10645, 11089);

                System.Management.Automation.Runspaces.ConsolidatedString
                f_1099_10780_10800(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.InternalTypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1099, 10780, 10800);
                    return return_v;
                }


                string
                f_1099_10743_10801(System.Management.Automation.Runspaces.ConsolidatedString
                typeNames)
                {
                    var return_v = PSObjectHelper.PSObjectIsOfExactType((System.Collections.ObjectModel.Collection<string>)typeNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1099, 10743, 10801);
                    return return_v;
                }


                bool
                f_1099_10899_10925(Microsoft.PowerShell.Commands.Internal.Format.SubPipelineManager.CommandEntry
                this_param, string
                typeName)
                {
                    var return_v = this_param.AppliesToType(typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1099, 10899, 10925);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.SubPipelineManager.CommandEntry>
                f_1099_10844_10861_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.SubPipelineManager.CommandEntry>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1099, 10844, 10861);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1099, 10645, 11089);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1099, 10645, 11089);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private LineOutput _lo;

        private List<CommandEntry> _commandEntryList;

        private CommandEntry _defaultCommandEntry;

        public SubPipelineManager()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1099, 4271, 11544);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 11120, 11130);
            this._lo = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 11292, 11336);
            this._commandEntryList = f_1099_11312_11336();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1099, 11495, 11536);
            this._defaultCommandEntry = f_1099_11518_11536();
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1099, 4271, 11544);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1099, 4271, 11544);
        }


        static SubPipelineManager()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1099, 4271, 11544);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1099, 4271, 11544);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1099, 4271, 11544);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1099, 4271, 11544);

        System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.SubPipelineManager.CommandEntry>
        f_1099_11312_11336()
        {
            var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.SubPipelineManager.CommandEntry>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1099, 11312, 11336);
            return return_v;
        }


        Microsoft.PowerShell.Commands.Internal.Format.SubPipelineManager.CommandEntry
        f_1099_11518_11536()
        {
            var return_v = new Microsoft.PowerShell.Commands.Internal.Format.SubPipelineManager.CommandEntry();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1099, 11518, 11536);
            return return_v;
        }

    }
}
