// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Dbg = System.Management.Automation.Diagnostics;

// Warning: Events StartSteppablePipeline and RunProcessRecord are never used
// They are actually used by the event manager in some dynamically generated IL
#pragma warning disable 0067

namespace System.Management.Automation
{
    internal class ServerSteppablePipelineDriverEventArg : EventArgs
    {
        internal ServerSteppablePipelineDriver SteppableDriver;

        internal ServerSteppablePipelineDriverEventArg(ServerSteppablePipelineDriver driver)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1659, 616, 766);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 588, 603);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 725, 755);

                this.SteppableDriver = driver;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1659, 616, 766);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1659, 616, 766);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1659, 616, 766);
            }
        }

        static ServerSteppablePipelineDriverEventArg()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1659, 468, 773);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1659, 468, 773);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1659, 468, 773);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1659, 468, 773);
    }
    internal class ServerSteppablePipelineSubscriber
    {
        private object _syncObject;

        private bool _initialized;

        private PSLocalEventManager _eventManager;

        private PSEventSubscriber _startSubscriber;

        private PSEventSubscriber _processSubscriber;

        internal void SubscribeEvents(ServerSteppablePipelineDriver driver)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1659, 1253, 2213);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 1351, 1362);
                lock (_syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 1396, 2187) || true) && (!_initialized)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1659, 1396, 2187);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 1455, 1541);

                        _eventManager = (object)f_1659_1479_1517(f_1659_1479_1510(f_1659_1479_1501(driver))) as PSLocalEventManager;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 1565, 2124) || true) && (_eventManager != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1659, 1565, 2124);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 1640, 1857);

                            _startSubscriber = f_1659_1659_1856(_eventManager, this, "StartSteppablePipeline", Guid.NewGuid().ToString(), null, new PSEventReceivedEventHandler(this.HandleStartEvent), true, false, true);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 1885, 2101);

                            _processSubscriber = f_1659_1906_2100(_eventManager, this, "RunProcessRecord", Guid.NewGuid().ToString(), null, new PSEventReceivedEventHandler(this.HandleProcessRecord), true, false, true);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1659, 1565, 2124);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 2148, 2168);

                        _initialized = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1659, 1396, 2187);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1659, 1253, 2213);

                System.Management.Automation.PowerShell
                f_1659_1479_1501(System.Management.Automation.ServerSteppablePipelineDriver
                this_param)
                {
                    var return_v = this_param.LocalPowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1659, 1479, 1501);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1659_1479_1510(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1659, 1479, 1510);
                    return return_v;
                }


                System.Management.Automation.PSEventManager
                f_1659_1479_1517(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.Events;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1659, 1479, 1517);
                    return return_v;
                }


                System.Management.Automation.PSEventSubscriber
                f_1659_1659_1856(System.Management.Automation.PSLocalEventManager
                this_param, System.Management.Automation.ServerSteppablePipelineSubscriber
                source, string
                eventName, string
                sourceIdentifier, System.Management.Automation.PSObject
                data, System.Management.Automation.PSEventReceivedEventHandler
                handlerDelegate, bool
                supportEvent, bool
                forwardEvent, bool
                shouldQueueAndProcessInExecutionThread)
                {
                    var return_v = this_param.SubscribeEvent((object)source, eventName, sourceIdentifier, data, handlerDelegate, supportEvent, forwardEvent, shouldQueueAndProcessInExecutionThread);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1659, 1659, 1856);
                    return return_v;
                }


                System.Management.Automation.PSEventSubscriber
                f_1659_1906_2100(System.Management.Automation.PSLocalEventManager
                this_param, System.Management.Automation.ServerSteppablePipelineSubscriber
                source, string
                eventName, string
                sourceIdentifier, System.Management.Automation.PSObject
                data, System.Management.Automation.PSEventReceivedEventHandler
                handlerDelegate, bool
                supportEvent, bool
                forwardEvent, bool
                shouldQueueAndProcessInExecutionThread)
                {
                    var return_v = this_param.SubscribeEvent((object)source, eventName, sourceIdentifier, data, handlerDelegate, supportEvent, forwardEvent, shouldQueueAndProcessInExecutionThread);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1659, 1906, 2100);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1659, 1253, 2213);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1659, 1253, 2213);
            }
        }


        public event EventHandler<EventArgs>
StartSteppablePipeline
;
        public event EventHandler<EventArgs>
RunProcessRecord
;

        private void HandleStartEvent(object sender, PSEventArgs args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1659, 2615, 4247);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 2702, 2822);

                ServerSteppablePipelineDriverEventArg
                driverArg = (object)f_1659_2760_2780(args) as ServerSteppablePipelineDriverEventArg
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 2836, 2901);

                ServerSteppablePipelineDriver
                driver = driverArg.SteppableDriver
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 2917, 2952);

                Exception
                exceptionOccurred = null
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 3004, 3506);
                    using (ExecutionContextForStepping
                    ctxt =
                    f_1659_3067_3302(f_1659_3145_3187(f_1659_3145_3167(driver)), f_1659_3214_3257(f_1659_3214_3236(driver)), f_1659_3284_3301(driver))
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 3344, 3417);

                        driver.SteppablePipeline = f_1659_3371_3416(f_1659_3371_3393(driver));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 3439, 3487);

                        f_1659_3439_3486(f_1659_3439_3463(driver), f_1659_3470_3485_M(!driver.NoInput));
                        DynAbs.Tracing.TraceSender.TraceExitUsing(1659, 3004, 3506);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 3526, 3658) || true) && (f_1659_3530_3544(driver))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1659, 3526, 3658);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 3586, 3639);

                        f_1659_3586_3638(driver, this, EventArgs.Empty);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1659, 3526, 3658);
                    }
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1659, 3687, 4081);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 4044, 4066);

                    exceptionOccurred = e;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1659, 3687, 4081);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 4097, 4236) || true) && (exceptionOccurred != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1659, 4097, 4236);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 4160, 4221);

                    f_1659_4160_4220(driver, PSInvocationState.Failed, exceptionOccurred);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1659, 4097, 4236);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1659, 2615, 4247);

                System.EventArgs
                f_1659_2760_2780(System.Management.Automation.PSEventArgs
                this_param)
                {
                    var return_v = this_param.SourceEventArgs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1659, 2760, 2780);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1659_3145_3167(System.Management.Automation.ServerSteppablePipelineDriver
                this_param)
                {
                    var return_v = this_param.LocalPowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1659, 3145, 3167);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1659_3145_3187(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.GetContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1659, 3145, 3187);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1659_3214_3236(System.Management.Automation.ServerSteppablePipelineDriver
                this_param)
                {
                    var return_v = this_param.LocalPowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1659, 3214, 3236);
                    return return_v;
                }


                System.Management.Automation.PSInformationalBuffers
                f_1659_3214_3257(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.InformationalBuffers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1659, 3214, 3257);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteHost
                f_1659_3284_3301(System.Management.Automation.ServerSteppablePipelineDriver
                this_param)
                {
                    var return_v = this_param.RemoteHost;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1659, 3284, 3301);
                    return return_v;
                }


                System.Management.Automation.ExecutionContextForStepping
                f_1659_3067_3302(System.Management.Automation.ExecutionContext
                ctxt, System.Management.Automation.PSInformationalBuffers
                newBuffers, System.Management.Automation.Remoting.ServerRemoteHost
                newHost)
                {
                    var return_v = ExecutionContextForStepping.PrepareExecutionContext(ctxt, newBuffers, (System.Management.Automation.Host.PSHost)newHost);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1659, 3067, 3302);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1659_3371_3393(System.Management.Automation.ServerSteppablePipelineDriver
                this_param)
                {
                    var return_v = this_param.LocalPowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1659, 3371, 3393);
                    return return_v;
                }


                System.Management.Automation.SteppablePipeline
                f_1659_3371_3416(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.GetSteppablePipeline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1659, 3371, 3416);
                    return return_v;
                }


                System.Management.Automation.SteppablePipeline
                f_1659_3439_3463(System.Management.Automation.ServerSteppablePipelineDriver
                this_param)
                {
                    var return_v = this_param.SteppablePipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1659, 3439, 3463);
                    return return_v;
                }


                bool
                f_1659_3470_3485_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1659, 3470, 3485);
                    return return_v;
                }


                int
                f_1659_3439_3486(System.Management.Automation.SteppablePipeline
                this_param, bool
                expectInput)
                {
                    this_param.Begin(expectInput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1659, 3439, 3486);
                    return 0;
                }


                bool
                f_1659_3530_3544(System.Management.Automation.ServerSteppablePipelineDriver
                this_param)
                {
                    var return_v = this_param.NoInput;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1659, 3530, 3544);
                    return return_v;
                }


                int
                f_1659_3586_3638(System.Management.Automation.ServerSteppablePipelineDriver
                this_param, System.Management.Automation.ServerSteppablePipelineSubscriber
                sender, System.EventArgs
                eventArgs)
                {
                    this_param.HandleInputEndReceived((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1659, 3586, 3638);
                    return 0;
                }


                int
                f_1659_4160_4220(System.Management.Automation.ServerSteppablePipelineDriver
                this_param, System.Management.Automation.PSInvocationState
                newState, System.Exception
                reason)
                {
                    this_param.SetState(newState, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1659, 4160, 4220);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1659, 2615, 4247);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1659, 2615, 4247);
            }
        }

        private void HandleProcessRecord(object sender, PSEventArgs args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1659, 4433, 10284);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 4523, 4643);

                ServerSteppablePipelineDriverEventArg
                driverArg = (object)f_1659_4581_4601(args) as ServerSteppablePipelineDriverEventArg
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 4657, 4722);

                ServerSteppablePipelineDriver
                driver = driverArg.SteppableDriver
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 4744, 4761);

                lock (f_1659_4744_4761(driver))
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 4856, 4960) || true) && (f_1659_4860_4884(driver) == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1659, 4856, 4960);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 4934, 4941);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1659, 4856, 4960);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 5046, 5140) || true) && (f_1659_5050_5072(driver))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1659, 5046, 5140);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 5114, 5121);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1659, 5046, 5140);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 5160, 5190);

                    driver.ProcessingInput = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 5208, 5230);

                    driver.Pulsed = false;
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 5261, 5291);

                bool
                shouldDoComplete = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 5305, 5340);

                Exception
                exceptionOccurred = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 5390, 7921);
                    using (ExecutionContextForStepping
                    ctxt =
                    f_1659_5449_5672(f_1659_5523_5565(f_1659_5523_5545(driver)), f_1659_5588_5631(f_1659_5588_5610(driver)), f_1659_5654_5671(driver))
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 5714, 5743);

                        bool
                        isProcessCalled = false
                        ;
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 5765, 7902) || true) && (true)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1659, 5765, 7902);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 5826, 6045) || true) && (f_1659_5830_5850(driver) != PSInvocationState.Running)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1659, 5826, 6045);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 5937, 5981);

                                    f_1659_5937_5980(driver, f_1659_5953_5973(driver), null);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 6011, 6018);

                                    return;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1659, 5826, 6045);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 6073, 6525) || true) && (!f_1659_6078_6111(f_1659_6078_6100(driver)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1659, 6073, 6525);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 6169, 6193);

                                    shouldDoComplete = true;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 6223, 6498) || true) && (f_1659_6227_6242_M(!driver.NoInput) || (DynAbs.Tracing.TraceSender.Expression_False(1659, 6227, 6261) || isProcessCalled))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1659, 6223, 6498);
                                        DynAbs.Tracing.TraceSender.TraceBreak(1659, 6461, 6467);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1659, 6223, 6498);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1659, 6073, 6525);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 6553, 6576);

                                isProcessCalled = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 6602, 6615);

                                Array
                                output
                                = default(Array);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 6641, 6976) || true) && (f_1659_6645_6659(driver))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1659, 6641, 6976);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 6717, 6761);

                                    output = f_1659_6726_6760(f_1659_6726_6750(driver));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1659, 6641, 6976);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1659, 6641, 6976);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 6875, 6949);

                                    output = f_1659_6884_6948(f_1659_6884_6908(driver), f_1659_6917_6947(f_1659_6917_6939(driver)));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1659, 6641, 6976);
                                }
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 7004, 7525);
                                    foreach (object o in f_1659_7025_7031_I(output))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1659, 7004, 7525);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 7089, 7324) || true) && (f_1659_7093_7113(driver) != PSInvocationState.Running)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1659, 7089, 7324);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 7208, 7252);

                                            f_1659_7208_7251(driver, f_1659_7224_7244(driver), null);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 7286, 7293);

                                            return;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1659, 7089, 7324);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 7423, 7498);

                                        f_1659_7423_7497(f_1659_7423_7450(driver), f_1659_7474_7496(o));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1659, 7004, 7525);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1659, 1, 522);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1659, 1, 522);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 7559, 7576);

                                lock (f_1659_7559_7576(driver))
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 7634, 7665);

                                    f_1659_7634_7664_M(driver.TotalObjectsProcessed++);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 7695, 7852) || true) && (f_1659_7699_7727(driver) >= f_1659_7731_7749(f_1659_7731_7743(driver)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1659, 7695, 7852);
                                        DynAbs.Tracing.TraceSender.TraceBreak(1659, 7815, 7821);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1659, 7695, 7852);
                                    }
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1659, 5765, 7902);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1659, 5765, 7902);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1659, 5765, 7902);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitUsing(1659, 5390, 7921);
                    }
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1659, 7950, 8039);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 8002, 8024);

                    exceptionOccurred = e;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1659, 7950, 8039);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1659, 8053, 8489);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 8099, 8116);
                    lock (f_1659_8099_8116(driver))
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 8158, 8189);

                        driver.ProcessingInput = false;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 8211, 8252);

                        f_1659_8211_8251(driver, false);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 8338, 8474) || true) && (f_1659_8342_8362(driver) == PSInvocationState.Stopping)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1659, 8338, 8474);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 8434, 8455);

                        f_1659_8434_8454(driver);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1659, 8338, 8474);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1659, 8053, 8489);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 8505, 10118) || true) && (shouldDoComplete)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1659, 8505, 10118);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 8603, 9679);
                        using (ExecutionContextForStepping
                        ctxt =
                        f_1659_8666_8901(f_1659_8744_8786(f_1659_8744_8766(driver)), f_1659_8813_8856(f_1659_8813_8835(driver)), f_1659_8883_8900(driver))
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 8951, 8997);

                            Array
                            output = f_1659_8966_8996(f_1659_8966_8990(driver))
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 9023, 9544);
                                foreach (object o in f_1659_9044_9050_I(output))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1659, 9023, 9544);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 9108, 9343) || true) && (f_1659_9112_9132(driver) != PSInvocationState.Running)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1659, 9108, 9343);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 9227, 9271);

                                        f_1659_9227_9270(driver, f_1659_9243_9263(driver), null);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 9305, 9312);

                                        return;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1659, 9108, 9343);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 9442, 9517);

                                    f_1659_9442_9516(f_1659_9442_9469(driver), f_1659_9493_9515(o));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1659, 9023, 9544);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1659, 1, 522);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1659, 1, 522);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 9572, 9623);

                            f_1659_9572_9622(
                                                    driver, PSInvocationState.Completed, null);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 9649, 9656);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitUsing(1659, 8603, 9679);
                        }
                    }
                    catch (Exception e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1659, 9716, 9817);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 9776, 9798);

                        exceptionOccurred = e;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1659, 9716, 9817);
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1659, 9835, 10103);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 9936, 10084) || true) && (f_1659_9940_9960(driver) == PSInvocationState.Stopping)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1659, 9936, 10084);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 10040, 10061);

                            f_1659_10040_10060(driver);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1659, 9936, 10084);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1659, 9835, 10103);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1659, 8505, 10118);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 10134, 10273) || true) && (exceptionOccurred != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1659, 10134, 10273);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 10197, 10258);

                    f_1659_10197_10257(driver, PSInvocationState.Failed, exceptionOccurred);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1659, 10134, 10273);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1659, 4433, 10284);

                System.EventArgs
                f_1659_4581_4601(System.Management.Automation.PSEventArgs
                this_param)
                {
                    var return_v = this_param.SourceEventArgs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1659, 4581, 4601);
                    return return_v;
                }


                object
                f_1659_4744_4761(System.Management.Automation.ServerSteppablePipelineDriver
                this_param)
                {
                    var return_v = this_param.SyncObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1659, 4744, 4761);
                    return return_v;
                }


                System.Management.Automation.SteppablePipeline
                f_1659_4860_4884(System.Management.Automation.ServerSteppablePipelineDriver
                this_param)
                {
                    var return_v = this_param.SteppablePipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1659, 4860, 4884);
                    return return_v;
                }


                bool
                f_1659_5050_5072(System.Management.Automation.ServerSteppablePipelineDriver
                this_param)
                {
                    var return_v = this_param.ProcessingInput;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1659, 5050, 5072);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1659_5523_5545(System.Management.Automation.ServerSteppablePipelineDriver
                this_param)
                {
                    var return_v = this_param.LocalPowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1659, 5523, 5545);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1659_5523_5565(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.GetContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1659, 5523, 5565);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1659_5588_5610(System.Management.Automation.ServerSteppablePipelineDriver
                this_param)
                {
                    var return_v = this_param.LocalPowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1659, 5588, 5610);
                    return return_v;
                }


                System.Management.Automation.PSInformationalBuffers
                f_1659_5588_5631(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.InformationalBuffers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1659, 5588, 5631);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteHost
                f_1659_5654_5671(System.Management.Automation.ServerSteppablePipelineDriver
                this_param)
                {
                    var return_v = this_param.RemoteHost;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1659, 5654, 5671);
                    return return_v;
                }


                System.Management.Automation.ExecutionContextForStepping
                f_1659_5449_5672(System.Management.Automation.ExecutionContext
                ctxt, System.Management.Automation.PSInformationalBuffers
                newBuffers, System.Management.Automation.Remoting.ServerRemoteHost
                newHost)
                {
                    var return_v = ExecutionContextForStepping.PrepareExecutionContext(ctxt, newBuffers, (System.Management.Automation.Host.PSHost)newHost);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1659, 5449, 5672);
                    return return_v;
                }


                System.Management.Automation.PSInvocationState
                f_1659_5830_5850(System.Management.Automation.ServerSteppablePipelineDriver
                this_param)
                {
                    var return_v = this_param.PipelineState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1659, 5830, 5850);
                    return return_v;
                }


                System.Management.Automation.PSInvocationState
                f_1659_5953_5973(System.Management.Automation.ServerSteppablePipelineDriver
                this_param)
                {
                    var return_v = this_param.PipelineState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1659, 5953, 5973);
                    return return_v;
                }


                int
                f_1659_5937_5980(System.Management.Automation.ServerSteppablePipelineDriver
                this_param, System.Management.Automation.PSInvocationState
                newState, System.Exception
                reason)
                {
                    this_param.SetState(newState, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1659, 5937, 5980);
                    return 0;
                }


                System.Collections.Generic.IEnumerator<object>
                f_1659_6078_6100(System.Management.Automation.ServerSteppablePipelineDriver
                this_param)
                {
                    var return_v = this_param.InputEnumerator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1659, 6078, 6100);
                    return return_v;
                }


                bool
                f_1659_6078_6111(System.Collections.Generic.IEnumerator<object>
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1659, 6078, 6111);
                    return return_v;
                }


                bool
                f_1659_6227_6242_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1659, 6227, 6242);
                    return return_v;
                }


                bool
                f_1659_6645_6659(System.Management.Automation.ServerSteppablePipelineDriver
                this_param)
                {
                    var return_v = this_param.NoInput;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1659, 6645, 6659);
                    return return_v;
                }


                System.Management.Automation.SteppablePipeline
                f_1659_6726_6750(System.Management.Automation.ServerSteppablePipelineDriver
                this_param)
                {
                    var return_v = this_param.SteppablePipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1659, 6726, 6750);
                    return return_v;
                }


                System.Array
                f_1659_6726_6760(System.Management.Automation.SteppablePipeline
                this_param)
                {
                    var return_v = this_param.Process();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1659, 6726, 6760);
                    return return_v;
                }


                System.Management.Automation.SteppablePipeline
                f_1659_6884_6908(System.Management.Automation.ServerSteppablePipelineDriver
                this_param)
                {
                    var return_v = this_param.SteppablePipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1659, 6884, 6908);
                    return return_v;
                }


                System.Collections.Generic.IEnumerator<object>
                f_1659_6917_6939(System.Management.Automation.ServerSteppablePipelineDriver
                this_param)
                {
                    var return_v = this_param.InputEnumerator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1659, 6917, 6939);
                    return return_v;
                }


                object
                f_1659_6917_6947(System.Collections.Generic.IEnumerator<object>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1659, 6917, 6947);
                    return return_v;
                }


                System.Array
                f_1659_6884_6948(System.Management.Automation.SteppablePipeline
                this_param, object
                input)
                {
                    var return_v = this_param.Process(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1659, 6884, 6948);
                    return return_v;
                }


                System.Management.Automation.PSInvocationState
                f_1659_7093_7113(System.Management.Automation.ServerSteppablePipelineDriver
                this_param)
                {
                    var return_v = this_param.PipelineState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1659, 7093, 7113);
                    return return_v;
                }


                System.Management.Automation.PSInvocationState
                f_1659_7224_7244(System.Management.Automation.ServerSteppablePipelineDriver
                this_param)
                {
                    var return_v = this_param.PipelineState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1659, 7224, 7244);
                    return return_v;
                }


                int
                f_1659_7208_7251(System.Management.Automation.ServerSteppablePipelineDriver
                this_param, System.Management.Automation.PSInvocationState
                newState, System.Exception
                reason)
                {
                    this_param.SetState(newState, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1659, 7208, 7251);
                    return 0;
                }


                System.Management.Automation.ServerPowerShellDataStructureHandler
                f_1659_7423_7450(System.Management.Automation.ServerSteppablePipelineDriver
                this_param)
                {
                    var return_v = this_param.DataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1659, 7423, 7450);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1659_7474_7496(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1659, 7474, 7496);
                    return return_v;
                }


                int
                f_1659_7423_7497(System.Management.Automation.ServerPowerShellDataStructureHandler
                this_param, System.Management.Automation.PSObject
                data)
                {
                    this_param.SendOutputDataToClient(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1659, 7423, 7497);
                    return 0;
                }


                System.Array
                f_1659_7025_7031_I(System.Array
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1659, 7025, 7031);
                    return return_v;
                }


                object
                f_1659_7559_7576(System.Management.Automation.ServerSteppablePipelineDriver
                this_param)
                {
                    var return_v = this_param.SyncObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1659, 7559, 7576);
                    return return_v;
                }


                int
                f_1659_7634_7664_M(int
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1659, 7634, 7664);
                    return return_v;
                }


                int
                f_1659_7699_7727(System.Management.Automation.ServerSteppablePipelineDriver
                this_param)
                {
                    var return_v = this_param.TotalObjectsProcessed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1659, 7699, 7727);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<object>
                f_1659_7731_7743(System.Management.Automation.ServerSteppablePipelineDriver
                this_param)
                {
                    var return_v = this_param.Input;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1659, 7731, 7743);
                    return return_v;
                }


                int
                f_1659_7731_7749(System.Management.Automation.PSDataCollection<object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1659, 7731, 7749);
                    return return_v;
                }


                object
                f_1659_8099_8116(System.Management.Automation.ServerSteppablePipelineDriver
                this_param)
                {
                    var return_v = this_param.SyncObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1659, 8099, 8116);
                    return return_v;
                }


                int
                f_1659_8211_8251(System.Management.Automation.ServerSteppablePipelineDriver
                this_param, bool
                complete)
                {
                    this_param.CheckAndPulseForProcessing(complete);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1659, 8211, 8251);
                    return 0;
                }


                System.Management.Automation.PSInvocationState
                f_1659_8342_8362(System.Management.Automation.ServerSteppablePipelineDriver
                this_param)
                {
                    var return_v = this_param.PipelineState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1659, 8342, 8362);
                    return return_v;
                }


                int
                f_1659_8434_8454(System.Management.Automation.ServerSteppablePipelineDriver
                this_param)
                {
                    this_param.PerformStop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1659, 8434, 8454);
                    return 0;
                }


                System.Management.Automation.PowerShell
                f_1659_8744_8766(System.Management.Automation.ServerSteppablePipelineDriver
                this_param)
                {
                    var return_v = this_param.LocalPowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1659, 8744, 8766);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1659_8744_8786(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.GetContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1659, 8744, 8786);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1659_8813_8835(System.Management.Automation.ServerSteppablePipelineDriver
                this_param)
                {
                    var return_v = this_param.LocalPowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1659, 8813, 8835);
                    return return_v;
                }


                System.Management.Automation.PSInformationalBuffers
                f_1659_8813_8856(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.InformationalBuffers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1659, 8813, 8856);
                    return return_v;
                }


                System.Management.Automation.Remoting.ServerRemoteHost
                f_1659_8883_8900(System.Management.Automation.ServerSteppablePipelineDriver
                this_param)
                {
                    var return_v = this_param.RemoteHost;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1659, 8883, 8900);
                    return return_v;
                }


                System.Management.Automation.ExecutionContextForStepping
                f_1659_8666_8901(System.Management.Automation.ExecutionContext
                ctxt, System.Management.Automation.PSInformationalBuffers
                newBuffers, System.Management.Automation.Remoting.ServerRemoteHost
                newHost)
                {
                    var return_v = ExecutionContextForStepping.PrepareExecutionContext(ctxt, newBuffers, (System.Management.Automation.Host.PSHost)newHost);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1659, 8666, 8901);
                    return return_v;
                }


                System.Management.Automation.SteppablePipeline
                f_1659_8966_8990(System.Management.Automation.ServerSteppablePipelineDriver
                this_param)
                {
                    var return_v = this_param.SteppablePipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1659, 8966, 8990);
                    return return_v;
                }


                System.Array
                f_1659_8966_8996(System.Management.Automation.SteppablePipeline
                this_param)
                {
                    var return_v = this_param.End();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1659, 8966, 8996);
                    return return_v;
                }


                System.Management.Automation.PSInvocationState
                f_1659_9112_9132(System.Management.Automation.ServerSteppablePipelineDriver
                this_param)
                {
                    var return_v = this_param.PipelineState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1659, 9112, 9132);
                    return return_v;
                }


                System.Management.Automation.PSInvocationState
                f_1659_9243_9263(System.Management.Automation.ServerSteppablePipelineDriver
                this_param)
                {
                    var return_v = this_param.PipelineState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1659, 9243, 9263);
                    return return_v;
                }


                int
                f_1659_9227_9270(System.Management.Automation.ServerSteppablePipelineDriver
                this_param, System.Management.Automation.PSInvocationState
                newState, System.Exception
                reason)
                {
                    this_param.SetState(newState, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1659, 9227, 9270);
                    return 0;
                }


                System.Management.Automation.ServerPowerShellDataStructureHandler
                f_1659_9442_9469(System.Management.Automation.ServerSteppablePipelineDriver
                this_param)
                {
                    var return_v = this_param.DataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1659, 9442, 9469);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1659_9493_9515(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1659, 9493, 9515);
                    return return_v;
                }


                int
                f_1659_9442_9516(System.Management.Automation.ServerPowerShellDataStructureHandler
                this_param, System.Management.Automation.PSObject
                data)
                {
                    this_param.SendOutputDataToClient(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1659, 9442, 9516);
                    return 0;
                }


                System.Array
                f_1659_9044_9050_I(System.Array
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1659, 9044, 9050);
                    return return_v;
                }


                int
                f_1659_9572_9622(System.Management.Automation.ServerSteppablePipelineDriver
                this_param, System.Management.Automation.PSInvocationState
                newState, System.Exception
                reason)
                {
                    this_param.SetState(newState, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1659, 9572, 9622);
                    return 0;
                }


                System.Management.Automation.PSInvocationState
                f_1659_9940_9960(System.Management.Automation.ServerSteppablePipelineDriver
                this_param)
                {
                    var return_v = this_param.PipelineState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1659, 9940, 9960);
                    return return_v;
                }


                int
                f_1659_10040_10060(System.Management.Automation.ServerSteppablePipelineDriver
                this_param)
                {
                    this_param.PerformStop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1659, 10040, 10060);
                    return 0;
                }


                int
                f_1659_10197_10257(System.Management.Automation.ServerSteppablePipelineDriver
                this_param, System.Management.Automation.PSInvocationState
                newState, System.Exception
                reason)
                {
                    this_param.SetState(newState, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1659, 10197, 10257);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1659, 4433, 10284);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1659, 4433, 10284);
            }
        }

        internal void FireStartSteppablePipeline(ServerSteppablePipelineDriver driver)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1659, 10448, 10896);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 10557, 10568);
                lock (_syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 10602, 10870) || true) && (_eventManager != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1659, 10602, 10870);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 10669, 10851);

                        f_1659_10669_10850(_eventManager, f_1659_10697_10730(_startSubscriber), this, new object[1] { f_1659_10779_10828(driver) }, null, true, false);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1659, 10602, 10870);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1659, 10448, 10896);

                string
                f_1659_10697_10730(System.Management.Automation.PSEventSubscriber
                this_param)
                {
                    var return_v = this_param.SourceIdentifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1659, 10697, 10730);
                    return return_v;
                }


                System.Management.Automation.ServerSteppablePipelineDriverEventArg
                f_1659_10779_10828(System.Management.Automation.ServerSteppablePipelineDriver
                driver)
                {
                    var return_v = new System.Management.Automation.ServerSteppablePipelineDriverEventArg(driver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1659, 10779, 10828);
                    return return_v;
                }


                System.Management.Automation.PSEventArgs
                f_1659_10669_10850(System.Management.Automation.PSLocalEventManager
                this_param, string
                sourceIdentifier, System.Management.Automation.ServerSteppablePipelineSubscriber
                sender, object[]
                args, System.Management.Automation.PSObject
                extraData, bool
                processInCurrentThread, bool
                waitForCompletionInCurrentThread)
                {
                    var return_v = this_param.GenerateEvent(sourceIdentifier, (object)sender, args, extraData, processInCurrentThread, waitForCompletionInCurrentThread);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1659, 10669, 10850);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1659, 10448, 10896);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1659, 10448, 10896);
            }
        }

        internal void FireHandleProcessRecord(ServerSteppablePipelineDriver driver)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1659, 11069, 11516);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 11175, 11186);
                lock (_syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 11220, 11490) || true) && (_eventManager != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1659, 11220, 11490);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 11287, 11471);

                        f_1659_11287_11470(_eventManager, f_1659_11315_11350(_processSubscriber), this, new object[1] { f_1659_11399_11448(driver) }, null, true, false);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1659, 11220, 11490);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1659, 11069, 11516);

                string
                f_1659_11315_11350(System.Management.Automation.PSEventSubscriber
                this_param)
                {
                    var return_v = this_param.SourceIdentifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1659, 11315, 11350);
                    return return_v;
                }


                System.Management.Automation.ServerSteppablePipelineDriverEventArg
                f_1659_11399_11448(System.Management.Automation.ServerSteppablePipelineDriver
                driver)
                {
                    var return_v = new System.Management.Automation.ServerSteppablePipelineDriverEventArg(driver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1659, 11399, 11448);
                    return return_v;
                }


                System.Management.Automation.PSEventArgs
                f_1659_11287_11470(System.Management.Automation.PSLocalEventManager
                this_param, string
                sourceIdentifier, System.Management.Automation.ServerSteppablePipelineSubscriber
                sender, object[]
                args, System.Management.Automation.PSObject
                extraData, bool
                processInCurrentThread, bool
                waitForCompletionInCurrentThread)
                {
                    var return_v = this_param.GenerateEvent(sourceIdentifier, (object)sender, args, extraData, processInCurrentThread, waitForCompletionInCurrentThread);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1659, 11287, 11470);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1659, 11069, 11516);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1659, 11069, 11516);
            }
        }

        public ServerSteppablePipelineSubscriber()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1659, 876, 11545);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 988, 1014);
            this._syncObject = f_1659_1002_1014();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 1038, 1058);
            this._initialized = false;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 1097, 1110);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 1147, 1163);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1659, 1200, 1218);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1659, 876, 11545);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1659, 876, 11545);
        }


        static ServerSteppablePipelineSubscriber()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1659, 876, 11545);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1659, 876, 11545);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1659, 876, 11545);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1659, 876, 11545);

        object
        f_1659_1002_1014()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1659, 1002, 1014);
            return return_v;
        }

    }
}
