// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#pragma warning disable 1634, 1691

using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Management.Automation.Internal;
using System.Management.Automation.Runspaces;
using System.Reflection;
using System.Reflection.Emit;
using System.Threading;

namespace System.Management.Automation
{
    public abstract class PSEventManager
    {
        private int _nextEventId;

        protected int GetNextEventId()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 905, 993);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 960, 982);

                return _nextEventId++;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 905, 993);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 905, 993);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 905, 993);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public PSEventArgsCollection ReceivedEvents { get; }

        public abstract List<PSEventSubscriber> Subscribers { get; }

        protected abstract PSEventArgs CreateEvent(string sourceIdentifier, object sender, object[] args, PSObject extraData);

        public PSEventArgs GenerateEvent(string sourceIdentifier, object sender, object[] args, PSObject extraData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 2665, 2891);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 2797, 2880);

                return f_1272_2804_2879(this, sourceIdentifier, sender, args, extraData, false, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 2665, 2891);

                System.Management.Automation.PSEventArgs
                f_1272_2804_2879(System.Management.Automation.PSEventManager
                this_param, string
                sourceIdentifier, object
                sender, object[]
                args, System.Management.Automation.PSObject
                extraData, bool
                processInCurrentThread, bool
                waitForCompletionInCurrentThread)
                {
                    var return_v = this_param.GenerateEvent(sourceIdentifier, sender, args, extraData, processInCurrentThread, waitForCompletionInCurrentThread);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 2804, 2879);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 2665, 2891);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 2665, 2891);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public PSEventArgs GenerateEvent(string sourceIdentifier, object sender, object[] args, PSObject extraData,
                    bool processInCurrentThread, bool waitForCompletionInCurrentThread)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 3861, 4293);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 4074, 4152);

                PSEventArgs
                newEvent = f_1272_4097_4151(this, sourceIdentifier, sender, args, extraData)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 4166, 4250);

                f_1272_4166_4249(this, newEvent, processInCurrentThread, waitForCompletionInCurrentThread);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 4266, 4282);

                return newEvent;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 3861, 4293);

                System.Management.Automation.PSEventArgs
                f_1272_4097_4151(System.Management.Automation.PSEventManager
                this_param, string
                sourceIdentifier, object
                sender, object[]
                args, System.Management.Automation.PSObject
                extraData)
                {
                    var return_v = this_param.CreateEvent(sourceIdentifier, sender, args, extraData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 4097, 4151);
                    return return_v;
                }


                int
                f_1272_4166_4249(System.Management.Automation.PSEventManager
                this_param, System.Management.Automation.PSEventArgs
                newEvent, bool
                processInCurrentThread, bool
                waitForCompletionWhenInCurrentThread)
                {
                    this_param.ProcessNewEvent(newEvent, processInCurrentThread, waitForCompletionWhenInCurrentThread);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 4166, 4249);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 3861, 4293);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 3861, 4293);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal abstract void AddForwardedEvent(PSEventArgs forwardedEvent);

        [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "InCurrent")]
        protected abstract void ProcessNewEvent(PSEventArgs newEvent, bool processInCurrentThread);

        [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "InCurrent")]
        protected internal virtual void ProcessNewEvent(PSEventArgs newEvent, bool processInCurrentThread,
                                                                 bool waitForCompletionWhenInCurrentThread)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 5024, 5413);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 5366, 5402);

                throw f_1272_5372_5401();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 5024, 5413);

                System.NotImplementedException
                f_1272_5372_5401()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 5372, 5401);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 5024, 5413);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 5024, 5413);
            }
        }

        public abstract IEnumerable<PSEventSubscriber> GetEventSubscribers(string sourceIdentifier);

        [SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly")]
        public abstract PSEventSubscriber SubscribeEvent(object source, string eventName, string sourceIdentifier, PSObject data, ScriptBlock action, bool supportEvent, bool forwardEvent);

        [SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly")]
        public abstract PSEventSubscriber SubscribeEvent(object source, string eventName, string sourceIdentifier, PSObject data, ScriptBlock action, bool supportEvent, bool forwardEvent, int maxTriggerCount);

        [SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly")]
        public abstract PSEventSubscriber SubscribeEvent(object source, string eventName, string sourceIdentifier, PSObject data, PSEventReceivedEventHandler handlerDelegate, bool supportEvent, bool forwardEvent);

        [SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly")]
        public abstract PSEventSubscriber SubscribeEvent(object source, string eventName, string sourceIdentifier, PSObject data, PSEventReceivedEventHandler handlerDelegate, bool supportEvent, bool forwardEvent, int maxTriggerCount);

        [SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly")]
        internal virtual PSEventSubscriber SubscribeEvent(object source,
                    string eventName,
                    string sourceIdentifier,
                    PSObject data,
                    PSEventReceivedEventHandler handlerDelegate,
                    bool supportEvent,
                    bool forwardEvent,
                    bool shouldQueueAndProcessInExecutionThread,
                    int maxTriggerCount = 0)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 13245, 13882);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 13744, 13871);

                return f_1272_13751_13870(this, source, eventName, sourceIdentifier, data, handlerDelegate, supportEvent, forwardEvent, maxTriggerCount);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 13245, 13882);

                System.Management.Automation.PSEventSubscriber
                f_1272_13751_13870(System.Management.Automation.PSEventManager
                this_param, object
                source, string
                eventName, string
                sourceIdentifier, System.Management.Automation.PSObject
                data, System.Management.Automation.PSEventReceivedEventHandler
                handlerDelegate, bool
                supportEvent, bool
                forwardEvent, int
                maxTriggerCount)
                {
                    var return_v = this_param.SubscribeEvent(source, eventName, sourceIdentifier, data, handlerDelegate, supportEvent, forwardEvent, maxTriggerCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 13751, 13870);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 13245, 13882);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 13245, 13882);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public abstract void UnsubscribeEvent(PSEventSubscriber subscriber);

        /// <summary>
        /// This event is raised by the event manager to forward events.
        /// </summary>
        internal abstract event EventHandler<PSEventArgs>
ForwardEvent
;

        public PSEventManager()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1272, 668, 14394);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 785, 801);
            this._nextEventId = 1;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 1121, 1204);
            this.ReceivedEvents = f_1272_1176_1203();
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1272, 668, 14394);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 668, 14394);
        }


        static PSEventManager()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1272, 668, 14394);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1272, 668, 14394);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 668, 14394);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1272, 668, 14394);

        System.Management.Automation.PSEventArgsCollection
        f_1272_1176_1203()
        {
            var return_v = new System.Management.Automation.PSEventArgsCollection();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 1176, 1203);
            return return_v;
        }

    }
    internal class PSLocalEventManager : PSEventManager, IDisposable
    {
        internal PSLocalEventManager(ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1272, 14701, 15066);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 15126, 15143);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 15206, 15229);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 15267, 15279);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 15315, 15323);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 15346, 15369);
                this._nextSubscriptionId = 1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 15395, 15413);
                this._throttleLimit = 1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 15436, 15455);
                this._throttleChecks = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 15560, 15581);
                this._eventAssembly = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 15614, 15633);
                this._eventModule = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 15656, 15667);
                this._typeId = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 25918, 25931);
                this._timer = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 25955, 25980);
                this._timerInitialized = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 26004, 26026);
                this._isTimerActive = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 26370, 26397);
                this._consecutiveIdleSamples = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 52029, 52065);
                this._actionProcessingLock = f_1272_52053_52065();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 52096, 52120);
                this._processingAction = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 14780, 14846);

                _eventSubscribers = f_1272_14800_14845();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 14860, 14968);

                _engineEventSubscribers = f_1272_14886_14967(f_1272_14934_14966());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 14982, 15022);

                _actionQueue = f_1272_14997_15021();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 15036, 15055);

                _context = context;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1272, 14701, 15066);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 14701, 15066);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 14701, 15066);
            }
        }

        private Dictionary<PSEventSubscriber, Delegate> _eventSubscribers;

        private Dictionary<string, List<PSEventSubscriber>> _engineEventSubscribers;

        private Queue<EventAction> _actionQueue;

        private ExecutionContext _context;

        private int _nextSubscriptionId;

        private double _throttleLimit;

        private int _throttleChecks;

        private AssemblyBuilder _eventAssembly;

        private ModuleBuilder _eventModule;

        private int _typeId;

        public override List<PSEventSubscriber> Subscribers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 15852, 16292);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 15888, 15956);

                    List<PSEventSubscriber>
                    subscribers = f_1272_15926_15955()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 15982, 15999);

                    lock (_eventSubscribers)
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 16041, 16219);
                            foreach (PSEventSubscriber currentSubscriber in f_1272_16089_16111_I(f_1272_16089_16111(_eventSubscribers)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 16041, 16219);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 16161, 16196);

                                f_1272_16161_16195(subscribers, currentSubscriber);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 16041, 16219);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1272, 1, 179);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1272, 1, 179);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 16258, 16277);

                    return subscribers;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 15852, 16292);

                    System.Collections.Generic.List<System.Management.Automation.PSEventSubscriber>
                    f_1272_15926_15955()
                    {
                        var return_v = new System.Collections.Generic.List<System.Management.Automation.PSEventSubscriber>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 15926, 15955);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<System.Management.Automation.PSEventSubscriber, System.Delegate>.KeyCollection
                    f_1272_16089_16111(System.Collections.Generic.Dictionary<System.Management.Automation.PSEventSubscriber, System.Delegate>
                    this_param)
                    {
                        var return_v = this_param.Keys;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 16089, 16111);
                        return return_v;
                    }


                    int
                    f_1272_16161_16195(System.Collections.Generic.List<System.Management.Automation.PSEventSubscriber>
                    this_param, System.Management.Automation.PSEventSubscriber
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 16161, 16195);
                        return 0;
                    }


                    System.Collections.Generic.Dictionary<System.Management.Automation.PSEventSubscriber, System.Delegate>.KeyCollection
                    f_1272_16089_16111_I(System.Collections.Generic.Dictionary<System.Management.Automation.PSEventSubscriber, System.Delegate>.KeyCollection
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 16089, 16111);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 15776, 16303);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 15776, 16303);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        [SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly")]
        public override PSEventSubscriber SubscribeEvent(object source, string eventName, string sourceIdentifier, PSObject data, ScriptBlock action, bool supportEvent, bool forwardEvent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 17318, 17732);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 17617, 17721);

                return f_1272_17624_17720(this, source, eventName, sourceIdentifier, data, action, supportEvent, forwardEvent, 0);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 17318, 17732);

                System.Management.Automation.PSEventSubscriber
                f_1272_17624_17720(System.Management.Automation.PSLocalEventManager
                this_param, object
                source, string
                eventName, string
                sourceIdentifier, System.Management.Automation.PSObject
                data, System.Management.Automation.ScriptBlock
                action, bool
                supportEvent, bool
                forwardEvent, int
                maxTriggerCount)
                {
                    var return_v = this_param.SubscribeEvent(source, eventName, sourceIdentifier, data, action, supportEvent, forwardEvent, maxTriggerCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 17624, 17720);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 17318, 17732);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 17318, 17732);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly")]
        public override PSEventSubscriber SubscribeEvent(object source, string eventName, string sourceIdentifier, PSObject data, ScriptBlock action, bool supportEvent, bool forwardEvent, int maxTriggerCount)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 19060, 19849);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 19471, 19647);

                PSEventSubscriber
                subscriber = f_1272_19502_19646(_context, _nextSubscriptionId++, source, eventName, sourceIdentifier, action, supportEvent, forwardEvent, maxTriggerCount)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 19661, 19765);

                f_1272_19661_19764(this, subscriber, source, eventName, sourceIdentifier, data, supportEvent, forwardEvent);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 19779, 19804);

                f_1272_19779_19803(subscriber);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 19820, 19838);

                return subscriber;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 19060, 19849);

                System.Management.Automation.PSEventSubscriber
                f_1272_19502_19646(System.Management.Automation.ExecutionContext
                context, int
                id, object
                source, string
                eventName, string
                sourceIdentifier, System.Management.Automation.ScriptBlock
                action, bool
                supportEvent, bool
                forwardEvent, int
                maxTriggerCount)
                {
                    var return_v = new System.Management.Automation.PSEventSubscriber(context, id, source, eventName, sourceIdentifier, action, supportEvent, forwardEvent, maxTriggerCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 19502, 19646);
                    return return_v;
                }


                int
                f_1272_19661_19764(System.Management.Automation.PSLocalEventManager
                this_param, System.Management.Automation.PSEventSubscriber
                subscriber, object
                source, string
                eventName, string
                sourceIdentifier, System.Management.Automation.PSObject
                data, bool
                supportEvent, bool
                forwardEvent)
                {
                    this_param.ProcessNewSubscriber(subscriber, source, eventName, sourceIdentifier, data, supportEvent, forwardEvent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 19661, 19764);
                    return 0;
                }


                int
                f_1272_19779_19803(System.Management.Automation.PSEventSubscriber
                this_param)
                {
                    this_param.RegisterJob();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 19779, 19803);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 19060, 19849);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 19060, 19849);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly")]
        internal override PSEventSubscriber SubscribeEvent(object source,
                    string eventName,
                    string sourceIdentifier,
                    PSObject data,
                    PSEventReceivedEventHandler handlerDelegate,
                    bool supportEvent,
                    bool forwardEvent,
                    bool shouldQueueAndProcessInExecutionThread,
                    int maxTriggerCount = 0)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 21424, 22224);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 21924, 22078);

                PSEventSubscriber
                newSubscriber = f_1272_21958_22077(this, source, eventName, sourceIdentifier, data, handlerDelegate, supportEvent, forwardEvent, maxTriggerCount)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 22092, 22178);

                newSubscriber.ShouldProcessInExecutionThread = shouldQueueAndProcessInExecutionThread;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 22192, 22213);

                return newSubscriber;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 21424, 22224);

                System.Management.Automation.PSEventSubscriber
                f_1272_21958_22077(System.Management.Automation.PSLocalEventManager
                this_param, object
                source, string
                eventName, string
                sourceIdentifier, System.Management.Automation.PSObject
                data, System.Management.Automation.PSEventReceivedEventHandler
                handlerDelegate, bool
                supportEvent, bool
                forwardEvent, int
                maxTriggerCount)
                {
                    var return_v = this_param.SubscribeEvent(source, eventName, sourceIdentifier, data, handlerDelegate, supportEvent, forwardEvent, maxTriggerCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 21958, 22077);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 21424, 22224);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 21424, 22224);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly")]
        public override PSEventSubscriber SubscribeEvent(object source, string eventName, string sourceIdentifier, PSObject data, PSEventReceivedEventHandler handlerDelegate, bool supportEvent, bool forwardEvent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 23248, 23696);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 23572, 23685);

                return f_1272_23579_23684(this, source, eventName, sourceIdentifier, data, handlerDelegate, supportEvent, forwardEvent, 0);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 23248, 23696);

                System.Management.Automation.PSEventSubscriber
                f_1272_23579_23684(System.Management.Automation.PSLocalEventManager
                this_param, object
                source, string
                eventName, string
                sourceIdentifier, System.Management.Automation.PSObject
                data, System.Management.Automation.PSEventReceivedEventHandler
                handlerDelegate, bool
                supportEvent, bool
                forwardEvent, int
                maxTriggerCount)
                {
                    var return_v = this_param.SubscribeEvent(source, eventName, sourceIdentifier, data, handlerDelegate, supportEvent, forwardEvent, maxTriggerCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 23579, 23684);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 23248, 23696);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 23248, 23696);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly")]
        public override PSEventSubscriber SubscribeEvent(object source, string eventName, string sourceIdentifier, PSObject data, PSEventReceivedEventHandler handlerDelegate, bool supportEvent, bool forwardEvent, int maxTriggerCount)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 25033, 25856);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 25469, 25654);

                PSEventSubscriber
                subscriber = f_1272_25500_25653(_context, _nextSubscriptionId++, source, eventName, sourceIdentifier, handlerDelegate, supportEvent, forwardEvent, maxTriggerCount)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 25668, 25772);

                f_1272_25668_25771(this, subscriber, source, eventName, sourceIdentifier, data, supportEvent, forwardEvent);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 25786, 25811);

                f_1272_25786_25810(subscriber);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 25827, 25845);

                return subscriber;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 25033, 25856);

                System.Management.Automation.PSEventSubscriber
                f_1272_25500_25653(System.Management.Automation.ExecutionContext
                context, int
                id, object
                source, string
                eventName, string
                sourceIdentifier, System.Management.Automation.PSEventReceivedEventHandler
                handlerDelegate, bool
                supportEvent, bool
                forwardEvent, int
                maxTriggerCount)
                {
                    var return_v = new System.Management.Automation.PSEventSubscriber(context, id, source, eventName, sourceIdentifier, handlerDelegate, supportEvent, forwardEvent, maxTriggerCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 25500, 25653);
                    return return_v;
                }


                int
                f_1272_25668_25771(System.Management.Automation.PSLocalEventManager
                this_param, System.Management.Automation.PSEventSubscriber
                subscriber, object
                source, string
                eventName, string
                sourceIdentifier, System.Management.Automation.PSObject
                data, bool
                supportEvent, bool
                forwardEvent)
                {
                    this_param.ProcessNewSubscriber(subscriber, source, eventName, sourceIdentifier, data, supportEvent, forwardEvent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 25668, 25771);
                    return 0;
                }


                int
                f_1272_25786_25810(System.Management.Automation.PSEventSubscriber
                this_param)
                {
                    this_param.RegisterJob();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 25786, 25810);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 25033, 25856);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 25033, 25856);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Timer _timer;

        private bool _timerInitialized;

        private bool _isTimerActive;

        private int _consecutiveIdleSamples;

        private void OnElapsedEvent(object source)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 26886, 28447);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 26953, 27015);

                var
                localRunspace = f_1272_26973_26997(_context) as LocalRunspace
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 27031, 27262) || true) && (localRunspace == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 27031, 27262);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 27194, 27222);

                    _consecutiveIdleSamples = 0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 27240, 27247);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 27031, 27262);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 27278, 27502) || true) && (f_1272_27282_27325(localRunspace) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 27278, 27502);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 27367, 27393);

                    _consecutiveIdleSamples++;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 27278, 27502);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 27278, 27502);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 27459, 27487);

                    _consecutiveIdleSamples = 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 27278, 27502);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 27518, 28436) || true) && (_consecutiveIdleSamples == 4)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 27518, 28436);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 27584, 27612);

                    _consecutiveIdleSamples = 0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 27636, 27659);
                    lock (_engineEventSubscribers)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 27701, 27744);

                        List<PSEventSubscriber>
                        subscribers = null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 27766, 28322) || true) && (f_1272_27770_27844(_engineEventSubscribers, PSEngineEvent.OnIdle, out subscribers) && (DynAbs.Tracing.TraceSender.Expression_True(1272, 27770, 27869) && f_1272_27848_27865(subscribers) > 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 27766, 28322);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 28058, 28138);

                            f_1272_28058_28137(this, PSEngineEvent.OnIdle, null, new object[] { }, null, false, false);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 28164, 28178);

                            f_1272_28164_28177(this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 27766, 28322);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 27766, 28322);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 28276, 28299);

                            _isTimerActive = false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 27766, 28322);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 27518, 28436);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 27518, 28436);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 28407, 28421);

                    f_1272_28407_28420(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 27518, 28436);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 26886, 28447);

                System.Management.Automation.Runspaces.Runspace
                f_1272_26973_26997(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 26973, 26997);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Pipeline
                f_1272_27282_27325(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.GetCurrentlyRunningPipeline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 27282, 27325);
                    return return_v;
                }


                bool
                f_1272_27770_27844(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.PSEventSubscriber>>
                this_param, string
                key, out System.Collections.Generic.List<System.Management.Automation.PSEventSubscriber>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 27770, 27844);
                    return return_v;
                }


                int
                f_1272_27848_27865(System.Collections.Generic.List<System.Management.Automation.PSEventSubscriber>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 27848, 27865);
                    return return_v;
                }


                System.Management.Automation.PSEventArgs
                f_1272_28058_28137(System.Management.Automation.PSLocalEventManager
                this_param, string
                sourceIdentifier, object
                sender, object[]
                args, System.Management.Automation.PSObject
                extraData, bool
                processInCurrentThread, bool
                waitForCompletionInCurrentThread)
                {
                    var return_v = this_param.GenerateEvent(sourceIdentifier, sender, args, extraData, processInCurrentThread, waitForCompletionInCurrentThread);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 28058, 28137);
                    return return_v;
                }


                int
                f_1272_28164_28177(System.Management.Automation.PSLocalEventManager
                this_param)
                {
                    this_param.EnableTimer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 28164, 28177);
                    return 0;
                }


                int
                f_1272_28407_28420(System.Management.Automation.PSLocalEventManager
                this_param)
                {
                    this_param.EnableTimer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 28407, 28420);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 26886, 28447);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 26886, 28447);
            }
        }

        private void InitializeTimer()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 28459, 28796);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 28550, 28627);

                    _timer = f_1272_28559_28626(OnElapsedEvent, null, Timeout.Infinite, Timeout.Infinite);
                }
                catch (ObjectDisposedException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1272, 28656, 28785);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1272, 28656, 28785);
                    // The PSLocalEventManager is disposed, do nothing
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 28459, 28796);

                System.Threading.Timer
                f_1272_28559_28626(System.Threading.TimerCallback
                callback, object?
                state, int
                dueTime, int
                period)
                {
                    var return_v = new System.Threading.Timer(callback, state, dueTime, period);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 28559, 28626);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 28459, 28796);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 28459, 28796);
            }
        }

        private void EnableTimer()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 28808, 29101);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 28895, 28932);

                    f_1272_28895_28931(_timer, 100, Timeout.Infinite);
                }
                catch (ObjectDisposedException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1272, 28961, 29090);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1272, 28961, 29090);
                    // The PSLocalEventManager is disposed, do nothing
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 28808, 29101);

                bool
                f_1272_28895_28931(System.Threading.Timer
                this_param, int
                dueTime, int
                period)
                {
                    var return_v = this_param.Change(dueTime, period);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 28895, 28931);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 28808, 29101);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 28808, 29101);
            }
        }

        private static Dictionary<string, Type> s_generatedEventHandlers;

        private void ProcessNewSubscriber(PSEventSubscriber subscriber, object source, string eventName, string sourceIdentifier, PSObject data, bool supportEvent, bool forwardEvent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 29260, 36475);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 29459, 29491);

                Delegate
                handlerDelegate = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 29507, 29835) || true) && (_eventAssembly == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 29507, 29835);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 29567, 29728);

                    _eventAssembly = f_1272_29584_29727(f_1272_29644_29678("PSEventHandler"), AssemblyBuilderAccess.Run);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 29746, 29820);

                    _eventModule = f_1272_29761_29819(_eventAssembly, "PSGenericEventModule");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 29507, 29835);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 29851, 29893);

                string
                engineEventSourceIdentifier = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 29907, 29934);

                bool
                isOnIdleEvent = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 30078, 35108) || true) && (source != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 30078, 35108);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 30255, 30633) || true) && ((sourceIdentifier != null) && (DynAbs.Tracing.TraceSender.Expression_True(1272, 30259, 30390) && (f_1272_30311_30389(sourceIdentifier, "PowerShell.", StringComparison.OrdinalIgnoreCase))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 30255, 30633);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 30432, 30528);

                        string
                        errorMessage = f_1272_30454_30527(f_1272_30472_30508(), sourceIdentifier)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 30552, 30614);

                        throw f_1272_30558_30613(errorMessage, "sourceIdentifier");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 30255, 30633);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 30653, 30680);

                    EventInfo
                    eventInfo = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 30698, 30751);

                    Type
                    sourceType = source as Type ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Type>(1272, 30716, 30750) ?? f_1272_30734_30750(source))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 30833, 31012) || true) && (f_1272_30837_30872(sourceType))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 30833, 31012);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 30914, 30993);

                        throw f_1272_30920_30992(f_1272_30950_30991());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 30833, 31012);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 31087, 31207);

                    BindingFlags
                    bindingFlags = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.IgnoreCase
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 31225, 31282);

                    eventInfo = f_1272_31237_31281(sourceType, eventName, bindingFlags);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 31369, 31616) || true) && (eventInfo == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 31369, 31616);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 31432, 31520);

                        string
                        errorMessage = f_1272_31454_31519(f_1272_31472_31507(), eventName)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 31542, 31597);

                        throw f_1272_31548_31596(errorMessage, "eventName");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 31369, 31616);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 31718, 31793);

                    PropertyInfo
                    eventProperty = f_1272_31747_31792(sourceType, "EnableRaisingEvents")
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 31811, 32523) || true) && (eventProperty != null && (DynAbs.Tracing.TraceSender.Expression_True(1272, 31815, 31862) && f_1272_31840_31862(eventProperty)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 31811, 32523);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 31956, 32027);

                            object
                            targetObject = (DynAbs.Tracing.TraceSender.Conditional_F1(1272, 31978, 32010) || ((f_1272_31978_32010(f_1272_31978_32001(eventProperty)) && DynAbs.Tracing.TraceSender.Conditional_F2(1272, 32013, 32017)) || DynAbs.Tracing.TraceSender.Conditional_F3(1272, 32020, 32026))) ? null : source
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 32053, 32096);

                            f_1272_32053_32095(eventProperty, targetObject, true);
                        }
                        catch (TargetInvocationException e)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1272, 32141, 32504);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 32225, 32481) || true) && (f_1272_32229_32245(e) != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 32225, 32481);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 32311, 32334);

                                throw f_1272_32317_32333(e);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 32225, 32481);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 32225, 32481);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 32448, 32454);

                                throw;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 32225, 32481);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1272, 32141, 32504);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 31811, 32523);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 32622, 32695);

                    MethodInfo
                    invokeMethod = f_1272_32648_32694(f_1272_32648_32674(eventInfo), "Invoke")
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 33118, 33367) || true) && (f_1272_33122_33145(invokeMethod) != typeof(void))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 33118, 33367);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 33203, 33271);

                        string
                        errorMessage = f_1272_33225_33270()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 33293, 33348);

                        throw f_1272_33299_33347(errorMessage, "eventName");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 33118, 33367);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 33576, 33645);

                    string
                    eventHandlerKey = f_1272_33601_33626(f_1272_33601_33617(source)) + "|" + eventName
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 33663, 33680);

                    Type
                    handlerType
                    = default(Type);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 33706, 33730);

                    lock (s_generatedEventHandlers)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 33772, 34051) || true) && (!f_1272_33777_33847(s_generatedEventHandlers, eventHandlerKey, out handlerType))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 33772, 34051);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 33897, 33946);

                            handlerType = f_1272_33911_33945(this, invokeMethod);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 33972, 34028);

                            s_generatedEventHandlers[eventHandlerKey] = handlerType;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 33772, 34051);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 34145, 34312);

                    ConstructorInfo
                    constructor =
                    f_1272_34196_34311(handlerType, new Type[] { typeof(PSEventManager), typeof(object), typeof(string), typeof(PSObject) })
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 34330, 34421);

                    object
                    handler = f_1272_34347_34420(constructor, new object[] { this, source, sourceIdentifier, data })
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 34439, 34550);

                    MethodInfo
                    eventDelegate = f_1272_34466_34549(handlerType, "EventDelegate", BindingFlags.Public | BindingFlags.Instance)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 34568, 34652);

                    handlerDelegate = f_1272_34586_34651(eventDelegate, f_1272_34615_34641(eventInfo), handler);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 34672, 34723);

                    f_1272_34672_34722(
                                    eventInfo, source, handlerDelegate);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 30078, 35108);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 30078, 35108);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 34789, 35093) || true) && (f_1272_34793_34846(PSEngineEvent.EngineEvents, sourceIdentifier))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 34789, 35093);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 34888, 34935);

                        engineEventSourceIdentifier = sourceIdentifier;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 34957, 35074);

                        isOnIdleEvent = f_1272_34973_35073(engineEventSourceIdentifier, PSEngineEvent.OnIdle, StringComparison.OrdinalIgnoreCase);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 34789, 35093);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 30078, 35108);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 35130, 35147);

                lock (_eventSubscribers)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 35181, 35229);

                    _eventSubscribers[subscriber] = handlerDelegate;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 35247, 35354) || true) && (engineEventSourceIdentifier == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 35247, 35354);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 35328, 35335);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 35247, 35354);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 35380, 35403);

                    lock (_engineEventSubscribers)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 35445, 35626) || true) && (isOnIdleEvent && (DynAbs.Tracing.TraceSender.Expression_True(1272, 35449, 35484) && !_timerInitialized))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 35445, 35626);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 35534, 35552);

                            f_1272_35534_35551(this);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 35578, 35603);

                            _timerInitialized = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 35445, 35626);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 35650, 35693);

                        List<PSEventSubscriber>
                        subscribers = null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 35715, 36014) || true) && (!f_1272_35720_35801(_engineEventSubscribers, engineEventSourceIdentifier, out subscribers))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 35715, 36014);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 35851, 35895);

                            subscribers = f_1272_35865_35894();
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 35921, 35991);

                            f_1272_35921_35990(_engineEventSubscribers, engineEventSourceIdentifier, subscribers);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 35715, 36014);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 36038, 36066);

                        f_1272_36038_36065(
                                            subscribers, subscriber);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 36259, 36430) || true) && (isOnIdleEvent && (DynAbs.Tracing.TraceSender.Expression_True(1272, 36263, 36295) && !_isTimerActive))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 36259, 36430);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 36345, 36359);

                            f_1272_36345_36358(this);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 36385, 36407);

                            _isTimerActive = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 36259, 36430);
                        }
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 29260, 36475);

                System.Reflection.AssemblyName
                f_1272_29644_29678(string
                assemblyName)
                {
                    var return_v = new System.Reflection.AssemblyName(assemblyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 29644, 29678);
                    return return_v;
                }


                System.Reflection.Emit.AssemblyBuilder
                f_1272_29584_29727(System.Reflection.AssemblyName
                name, System.Reflection.Emit.AssemblyBuilderAccess
                access)
                {
                    var return_v = AssemblyBuilder.DefineDynamicAssembly(name, access);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 29584, 29727);
                    return return_v;
                }


                System.Reflection.Emit.ModuleBuilder
                f_1272_29761_29819(System.Reflection.Emit.AssemblyBuilder
                this_param, string
                name)
                {
                    var return_v = this_param.DefineDynamicModule(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 29761, 29819);
                    return return_v;
                }


                bool
                f_1272_30311_30389(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 30311, 30389);
                    return return_v;
                }


                string
                f_1272_30472_30508()
                {
                    var return_v = EventingResources.ReservedIdentifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 30472, 30508);
                    return return_v;
                }


                string
                f_1272_30454_30527(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 30454, 30527);
                    return return_v;
                }


                System.ArgumentException
                f_1272_30558_30613(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 30558, 30613);
                    return return_v;
                }


                System.Type
                f_1272_30734_30750(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 30734, 30750);
                    return return_v;
                }


                bool
                f_1272_30837_30872(System.Type
                type)
                {
                    var return_v = WinRTHelper.IsWinRTType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 30837, 30872);
                    return return_v;
                }


                string
                f_1272_30950_30991()
                {
                    var return_v = EventingResources.WinRTEventsNotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 30950, 30991);
                    return return_v;
                }


                System.InvalidOperationException
                f_1272_30920_30992(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 30920, 30992);
                    return return_v;
                }


                System.Reflection.EventInfo?
                f_1272_31237_31281(System.Type
                this_param, string
                name, System.Reflection.BindingFlags
                bindingAttr)
                {
                    var return_v = this_param.GetEvent(name, bindingAttr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 31237, 31281);
                    return return_v;
                }


                string
                f_1272_31472_31507()
                {
                    var return_v = EventingResources.CouldNotFindEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 31472, 31507);
                    return return_v;
                }


                string
                f_1272_31454_31519(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 31454, 31519);
                    return return_v;
                }


                System.ArgumentException
                f_1272_31548_31596(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 31548, 31596);
                    return return_v;
                }


                System.Reflection.PropertyInfo?
                f_1272_31747_31792(System.Type
                this_param, string
                name)
                {
                    var return_v = this_param.GetProperty(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 31747, 31792);
                    return return_v;
                }


                bool
                f_1272_31840_31862(System.Reflection.PropertyInfo
                this_param)
                {
                    var return_v = this_param.CanWrite;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 31840, 31862);
                    return return_v;
                }


                System.Reflection.MethodInfo
                f_1272_31978_32001(System.Reflection.PropertyInfo
                this_param)
                {
                    var return_v = this_param.SetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 31978, 32001);
                    return return_v;
                }


                bool
                f_1272_31978_32010(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 31978, 32010);
                    return return_v;
                }


                int
                f_1272_32053_32095(System.Reflection.PropertyInfo
                this_param, object
                obj, bool
                value)
                {
                    this_param.SetValue(obj, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 32053, 32095);
                    return 0;
                }


                System.Exception
                f_1272_32229_32245(System.Reflection.TargetInvocationException
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 32229, 32245);
                    return return_v;
                }


                System.Exception
                f_1272_32317_32333(System.Reflection.TargetInvocationException
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 32317, 32333);
                    return return_v;
                }


                System.Type
                f_1272_32648_32674(System.Reflection.EventInfo
                this_param)
                {
                    var return_v = this_param.EventHandlerType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 32648, 32674);
                    return return_v;
                }


                System.Reflection.MethodInfo?
                f_1272_32648_32694(System.Type
                this_param, string
                name)
                {
                    var return_v = this_param.GetMethod(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 32648, 32694);
                    return return_v;
                }


                System.Type
                f_1272_33122_33145(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 33122, 33145);
                    return return_v;
                }


                string
                f_1272_33225_33270()
                {
                    var return_v = EventingResources.NonVoidDelegateNotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 33225, 33270);
                    return return_v;
                }


                System.ArgumentException
                f_1272_33299_33347(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 33299, 33347);
                    return return_v;
                }


                System.Type
                f_1272_33601_33617(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 33601, 33617);
                    return return_v;
                }


                string
                f_1272_33601_33626(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 33601, 33626);
                    return return_v;
                }


                bool
                f_1272_33777_33847(System.Collections.Generic.Dictionary<string, System.Type>
                this_param, string
                key, out System.Type
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 33777, 33847);
                    return return_v;
                }


                System.Type
                f_1272_33911_33945(System.Management.Automation.PSLocalEventManager
                this_param, System.Reflection.MethodInfo
                invokeSignature)
                {
                    var return_v = this_param.GenerateEventHandler(invokeSignature);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 33911, 33945);
                    return return_v;
                }


                System.Reflection.ConstructorInfo?
                f_1272_34196_34311(System.Type
                this_param, System.Type[]
                types)
                {
                    var return_v = this_param.GetConstructor(types);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 34196, 34311);
                    return return_v;
                }


                object
                f_1272_34347_34420(System.Reflection.ConstructorInfo
                this_param, object[]
                parameters)
                {
                    var return_v = this_param.Invoke(parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 34347, 34420);
                    return return_v;
                }


                System.Reflection.MethodInfo?
                f_1272_34466_34549(System.Type
                this_param, string
                name, System.Reflection.BindingFlags
                bindingAttr)
                {
                    var return_v = this_param.GetMethod(name, bindingAttr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 34466, 34549);
                    return return_v;
                }


                System.Type
                f_1272_34615_34641(System.Reflection.EventInfo
                this_param)
                {
                    var return_v = this_param.EventHandlerType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 34615, 34641);
                    return return_v;
                }


                System.Delegate
                f_1272_34586_34651(System.Reflection.MethodInfo
                this_param, System.Type
                delegateType, object
                target)
                {
                    var return_v = this_param.CreateDelegate(delegateType, target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 34586, 34651);
                    return return_v;
                }


                int
                f_1272_34672_34722(System.Reflection.EventInfo
                this_param, object
                target, System.Delegate
                handler)
                {
                    this_param.AddEventHandler(target, handler);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 34672, 34722);
                    return 0;
                }


                bool
                f_1272_34793_34846(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 34793, 34846);
                    return return_v;
                }


                bool
                f_1272_34973_35073(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 34973, 35073);
                    return return_v;
                }


                int
                f_1272_35534_35551(System.Management.Automation.PSLocalEventManager
                this_param)
                {
                    this_param.InitializeTimer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 35534, 35551);
                    return 0;
                }


                bool
                f_1272_35720_35801(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.PSEventSubscriber>>
                this_param, string
                key, out System.Collections.Generic.List<System.Management.Automation.PSEventSubscriber>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 35720, 35801);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSEventSubscriber>
                f_1272_35865_35894()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.PSEventSubscriber>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 35865, 35894);
                    return return_v;
                }


                int
                f_1272_35921_35990(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.PSEventSubscriber>>
                this_param, string
                key, System.Collections.Generic.List<System.Management.Automation.PSEventSubscriber>
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 35921, 35990);
                    return 0;
                }


                int
                f_1272_36038_36065(System.Collections.Generic.List<System.Management.Automation.PSEventSubscriber>
                this_param, System.Management.Automation.PSEventSubscriber
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 36038, 36065);
                    return 0;
                }


                int
                f_1272_36345_36358(System.Management.Automation.PSLocalEventManager
                this_param)
                {
                    this_param.EnableTimer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 36345, 36358);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 29260, 36475);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 29260, 36475);
            }
        }

        public override void UnsubscribeEvent(PSEventSubscriber subscriber)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 36716, 36855);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 36808, 36844);

                f_1272_36808_36843(this, subscriber, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 36716, 36855);

                int
                f_1272_36808_36843(System.Management.Automation.PSLocalEventManager
                this_param, System.Management.Automation.PSEventSubscriber
                subscriber, bool
                skipDraining)
                {
                    this_param.UnsubscribeEvent(subscriber, skipDraining);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 36808, 36843);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 36716, 36855);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 36716, 36855);
            }
        }

        private void UnsubscribeEvent(PSEventSubscriber subscriber, bool skipDraining)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 37208, 39734);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 37311, 37428) || true) && (subscriber == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 37311, 37428);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 37367, 37413);

                    throw f_1272_37373_37412("subscriber");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 37311, 37428);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 37444, 37479);

                Delegate
                existingSubscriber = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 37499, 37516);
                lock (_eventSubscribers)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 37550, 37817) || true) && (f_1272_37554_37584(subscriber) || (DynAbs.Tracing.TraceSender.Expression_False(1272, 37554, 37654) || !f_1272_37589_37654(_eventSubscribers, subscriber, out existingSubscriber)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 37550, 37817);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 37791, 37798);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 37550, 37817);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 37837, 37875);

                    subscriber.IsBeingUnsubscribed = true;
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 37906, 38791) || true) && ((existingSubscriber != null) && (DynAbs.Tracing.TraceSender.Expression_True(1272, 37910, 37975) && (f_1272_37943_37966(subscriber) != null)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 37906, 38791);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 38061, 38186);

                    f_1272_38061_38185(                // Fire the unregistration handler
                                    subscriber, f_1272_38094_38117(subscriber), f_1272_38140_38184(subscriber));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 38206, 38233);

                    EventInfo
                    eventInfo = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 38253, 38340);

                    Type
                    sourceType = f_1272_38271_38294(subscriber) as Type ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Type>(1272, 38271, 38339) ?? f_1272_38306_38339(f_1272_38306_38329(subscriber)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 38360, 38480);

                    BindingFlags
                    bindingFlags = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.IgnoreCase
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 38498, 38566);

                    eventInfo = f_1272_38510_38565(sourceType, f_1272_38530_38550(subscriber), bindingFlags);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 38586, 38776) || true) && ((eventInfo != null) && (DynAbs.Tracing.TraceSender.Expression_True(1272, 38590, 38641) && (existingSubscriber != null)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 38586, 38776);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 38683, 38757);

                        f_1272_38683_38756(eventInfo, f_1272_38712_38735(subscriber), existingSubscriber);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 38586, 38776);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 37906, 38791);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 38953, 39117) || true) && (!skipDraining)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 38953, 39117);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 39070, 39102);

                    f_1272_39070_39101(this, subscriber);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 38953, 39117);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 39162, 39277) || true) && (f_1272_39166_39183(subscriber) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 39162, 39277);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 39225, 39262);

                    f_1272_39225_39261(f_1272_39225_39242(subscriber));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 39162, 39277);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 39299, 39316);

                lock (_eventSubscribers)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 39350, 39387);

                    f_1272_39350_39386(_eventSubscribers, subscriber);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 39405, 39708) || true) && (f_1272_39409_39473(PSEngineEvent.EngineEvents, f_1272_39445_39472(subscriber)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 39405, 39708);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 39521, 39544);
                        lock (_engineEventSubscribers)
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 39594, 39666);

                            f_1272_39594_39665(f_1272_39594_39646(_engineEventSubscribers, f_1272_39618_39645(subscriber)), subscriber);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 39405, 39708);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 37208, 39734);

                System.ArgumentNullException
                f_1272_37373_37412(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 37373, 37412);
                    return return_v;
                }


                bool
                f_1272_37554_37584(System.Management.Automation.PSEventSubscriber
                this_param)
                {
                    var return_v = this_param.IsBeingUnsubscribed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 37554, 37584);
                    return return_v;
                }


                bool
                f_1272_37589_37654(System.Collections.Generic.Dictionary<System.Management.Automation.PSEventSubscriber, System.Delegate>
                this_param, System.Management.Automation.PSEventSubscriber
                key, out System.Delegate
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 37589, 37654);
                    return return_v;
                }


                object
                f_1272_37943_37966(System.Management.Automation.PSEventSubscriber
                this_param)
                {
                    var return_v = this_param.SourceObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 37943, 37966);
                    return return_v;
                }


                object
                f_1272_38094_38117(System.Management.Automation.PSEventSubscriber
                this_param)
                {
                    var return_v = this_param.SourceObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 38094, 38117);
                    return return_v;
                }


                System.Management.Automation.PSEventUnsubscribedEventArgs
                f_1272_38140_38184(System.Management.Automation.PSEventSubscriber
                eventSubscriber)
                {
                    var return_v = new System.Management.Automation.PSEventUnsubscribedEventArgs(eventSubscriber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 38140, 38184);
                    return return_v;
                }


                int
                f_1272_38061_38185(System.Management.Automation.PSEventSubscriber
                this_param, object
                sender, System.Management.Automation.PSEventUnsubscribedEventArgs
                e)
                {
                    this_param.OnPSEventUnsubscribed(sender, e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 38061, 38185);
                    return 0;
                }


                object
                f_1272_38271_38294(System.Management.Automation.PSEventSubscriber
                this_param)
                {
                    var return_v = this_param.SourceObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 38271, 38294);
                    return return_v;
                }


                object
                f_1272_38306_38329(System.Management.Automation.PSEventSubscriber
                this_param)
                {
                    var return_v = this_param.SourceObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 38306, 38329);
                    return return_v;
                }


                System.Type
                f_1272_38306_38339(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 38306, 38339);
                    return return_v;
                }


                string
                f_1272_38530_38550(System.Management.Automation.PSEventSubscriber
                this_param)
                {
                    var return_v = this_param.EventName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 38530, 38550);
                    return return_v;
                }


                System.Reflection.EventInfo?
                f_1272_38510_38565(System.Type
                this_param, string
                name, System.Reflection.BindingFlags
                bindingAttr)
                {
                    var return_v = this_param.GetEvent(name, bindingAttr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 38510, 38565);
                    return return_v;
                }


                object
                f_1272_38712_38735(System.Management.Automation.PSEventSubscriber
                this_param)
                {
                    var return_v = this_param.SourceObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 38712, 38735);
                    return return_v;
                }


                int
                f_1272_38683_38756(System.Reflection.EventInfo
                this_param, object
                target, System.Delegate
                handler)
                {
                    this_param.RemoveEventHandler(target, handler);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 38683, 38756);
                    return 0;
                }


                int
                f_1272_39070_39101(System.Management.Automation.PSLocalEventManager
                this_param, System.Management.Automation.PSEventSubscriber
                subscriber)
                {
                    this_param.DrainPendingActions(subscriber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 39070, 39101);
                    return 0;
                }


                System.Management.Automation.PSEventJob
                f_1272_39166_39183(System.Management.Automation.PSEventSubscriber
                this_param)
                {
                    var return_v = this_param.Action;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 39166, 39183);
                    return return_v;
                }


                System.Management.Automation.PSEventJob
                f_1272_39225_39242(System.Management.Automation.PSEventSubscriber
                this_param)
                {
                    var return_v = this_param.Action;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 39225, 39242);
                    return return_v;
                }


                int
                f_1272_39225_39261(System.Management.Automation.PSEventJob
                this_param)
                {
                    this_param.NotifyJobStopped();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 39225, 39261);
                    return 0;
                }


                bool
                f_1272_39350_39386(System.Collections.Generic.Dictionary<System.Management.Automation.PSEventSubscriber, System.Delegate>
                this_param, System.Management.Automation.PSEventSubscriber
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 39350, 39386);
                    return return_v;
                }


                string
                f_1272_39445_39472(System.Management.Automation.PSEventSubscriber
                this_param)
                {
                    var return_v = this_param.SourceIdentifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 39445, 39472);
                    return return_v;
                }


                bool
                f_1272_39409_39473(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 39409, 39473);
                    return return_v;
                }


                string
                f_1272_39618_39645(System.Management.Automation.PSEventSubscriber
                this_param)
                {
                    var return_v = this_param.SourceIdentifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 39618, 39645);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSEventSubscriber>
                f_1272_39594_39646(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.PSEventSubscriber>>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 39594, 39646);
                    return return_v;
                }


                bool
                f_1272_39594_39665(System.Collections.Generic.List<System.Management.Automation.PSEventSubscriber>
                this_param, System.Management.Automation.PSEventSubscriber
                item)
                {
                    var return_v = this_param.Remove(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 39594, 39665);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 37208, 39734);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 37208, 39734);
            }
        }

        protected override PSEventArgs CreateEvent(string sourceIdentifier, object sender, object[] args, PSObject extraData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 40321, 40601);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 40463, 40590);

                return f_1272_40470_40589(null, f_1272_40492_40527(f_1272_40492_40516(_context)), f_1272_40529_40545(this), sourceIdentifier, sender, args, extraData);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 40321, 40601);

                System.Management.Automation.Runspaces.Runspace
                f_1272_40492_40516(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 40492, 40516);
                    return return_v;
                }


                System.Guid
                f_1272_40492_40527(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 40492, 40527);
                    return return_v;
                }


                int
                f_1272_40529_40545(System.Management.Automation.PSLocalEventManager
                this_param)
                {
                    var return_v = this_param.GetNextEventId();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 40529, 40545);
                    return return_v;
                }


                System.Management.Automation.PSEventArgs
                f_1272_40470_40589(string
                computerName, System.Guid
                runspaceId, int
                eventIdentifier, string
                sourceIdentifier, object
                sender, object[]
                originalArgs, System.Management.Automation.PSObject
                additionalData)
                {
                    var return_v = new System.Management.Automation.PSEventArgs(computerName, runspaceId, eventIdentifier, sourceIdentifier, sender, originalArgs, additionalData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 40470, 40589);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 40321, 40601);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 40321, 40601);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void AddForwardedEvent(PSEventArgs forwardedEvent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 40726, 40935);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 40819, 40869);

                forwardedEvent.EventIdentifier = f_1272_40852_40868(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 40885, 40924);

                f_1272_40885_40923(this, forwardedEvent, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 40726, 40935);

                int
                f_1272_40852_40868(System.Management.Automation.PSLocalEventManager
                this_param)
                {
                    var return_v = this_param.GetNextEventId();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 40852, 40868);
                    return return_v;
                }


                int
                f_1272_40885_40923(System.Management.Automation.PSLocalEventManager
                this_param, System.Management.Automation.PSEventArgs
                newEvent, bool
                processInCurrentThread)
                {
                    this_param.ProcessNewEvent(newEvent, processInCurrentThread);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 40885, 40923);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 40726, 40935);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 40726, 40935);
            }
        }

        protected override void ProcessNewEvent(PSEventArgs newEvent, bool processInCurrentThread)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 41099, 41282);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 41214, 41271);

                f_1272_41214_41270(this, newEvent, processInCurrentThread, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 41099, 41282);

                int
                f_1272_41214_41270(System.Management.Automation.PSLocalEventManager
                this_param, System.Management.Automation.PSEventArgs
                newEvent, bool
                processInCurrentThread, bool
                waitForCompletionWhenInCurrentThread)
                {
                    this_param.ProcessNewEvent(newEvent, processInCurrentThread, waitForCompletionWhenInCurrentThread);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 41214, 41270);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 41099, 41282);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 41099, 41282);
            }
        }

        protected internal override void ProcessNewEvent(PSEventArgs newEvent,
                    bool processInCurrentThread,
                    bool waitForCompletionWhenInCurrentThread)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 41446, 43715);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 41639, 43704) || true) && (processInCurrentThread)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 41639, 43704);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 41699, 41745);

                    f_1272_41699_41744(this, newEvent, true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 41763, 41821);

                    ManualResetEventSlim
                    waitHandle = f_1272_41797_41820(newEvent)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 41839, 43409) || true) && (waitHandle != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 41839, 43409);
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 43175, 43345) || true) && (waitForCompletionWhenInCurrentThread && (DynAbs.Tracing.TraceSender.Expression_True(1272, 43182, 43243) && !f_1272_43223_43243(waitHandle, 250)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 43175, 43345);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 43293, 43322);

                                f_1272_43293_43321(this);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 43175, 43345);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1272, 43175, 43345);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1272, 43175, 43345);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 43369, 43390);

                        f_1272_43369_43389(
                                            waitHandle);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 41839, 43409);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 41639, 43704);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 41639, 43704);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 43475, 43689);

                    f_1272_43475_43688(new WaitCallback(
                                        delegate (object unused)
                                        {
                                            ProcessNewEventImplementation(newEvent, false);
                                        }));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 41639, 43704);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 41446, 43715);

                int
                f_1272_41699_41744(System.Management.Automation.PSLocalEventManager
                this_param, System.Management.Automation.PSEventArgs
                newEvent, bool
                processSynchronously)
                {
                    this_param.ProcessNewEventImplementation(newEvent, processSynchronously);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 41699, 41744);
                    return 0;
                }


                System.Threading.ManualResetEventSlim
                f_1272_41797_41820(System.Management.Automation.PSEventArgs
                this_param)
                {
                    var return_v = this_param.EventProcessed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 41797, 41820);
                    return return_v;
                }


                bool
                f_1272_43223_43243(System.Threading.ManualResetEventSlim
                this_param, int
                millisecondsTimeout)
                {
                    var return_v = this_param.Wait(millisecondsTimeout);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 43223, 43243);
                    return return_v;
                }


                int
                f_1272_43293_43321(System.Management.Automation.PSLocalEventManager
                this_param)
                {
                    this_param.ProcessPendingActions();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 43293, 43321);
                    return 0;
                }


                int
                f_1272_43369_43389(System.Threading.ManualResetEventSlim
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 43369, 43389);
                    return 0;
                }


                bool
                f_1272_43475_43688(System.Threading.WaitCallback
                callBack)
                {
                    var return_v = ThreadPool.QueueUserWorkItem(callBack);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 43475, 43688);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 41446, 43715);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 41446, 43715);
            }
        }

        private void ProcessNewEventImplementation(PSEventArgs newEvent, bool processSynchronously)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 43846, 46355);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 44015, 44042);

                bool
                capturedEvent = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 44056, 44142);

                List<PSEventSubscriber>
                actionsHandledInCurrentThread = f_1272_44112_44141()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 44156, 44246);

                List<PSEventSubscriber>
                subscribersWithoutActionOrHandler = f_1272_44216_44245()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 44260, 45385);
                    foreach (PSEventSubscriber subscriber in f_1272_44301_44353_I(f_1272_44301_44353(this, f_1272_44321_44346(newEvent), true)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 44260, 45385);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 44387, 44435);

                        newEvent.ForwardEvent = f_1272_44411_44434(subscriber);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 44534, 45370) || true) && (f_1272_44538_44555(subscriber) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 44534, 45370);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 44605, 44676);

                            f_1272_44605_44675(this, f_1272_44615_44652(subscriber, newEvent), processSynchronously);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 44698, 44719);

                            capturedEvent = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 44534, 45370);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 44534, 45370);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 44761, 45370) || true) && (f_1272_44765_44791(subscriber) != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 44761, 45370);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 44841, 45174) || true) && (f_1272_44845_44886(subscriber))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 44841, 45174);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 44936, 45007);

                                    f_1272_44936_45006(this, f_1272_44946_44983(subscriber, newEvent), processSynchronously);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 44841, 45174);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 44841, 45174);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 45105, 45151);

                                    f_1272_45105_45150(actionsHandledInCurrentThread, subscriber);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 44841, 45174);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 45198, 45219);

                                capturedEvent = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 44761, 45370);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 44761, 45370);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 45301, 45351);

                                f_1272_45301_45350(subscribersWithoutActionOrHandler, subscriber);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 44761, 45370);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 44534, 45370);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 44260, 45385);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1272, 1, 1126);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1272, 1, 1126);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 45401, 45635);
                    foreach (PSEventSubscriber subscriber in f_1272_45442_45471_I(actionsHandledInCurrentThread))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 45401, 45635);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 45505, 45559);

                        f_1272_45505_45558(subscriber, f_1272_45532_45547(newEvent), newEvent);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 45577, 45620);

                        f_1272_45577_45619(this, subscriber);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 45401, 45635);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1272, 1, 235);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1272, 1, 235);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 45755, 46344) || true) && (!capturedEvent)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 45755, 46344);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 45807, 46131) || true) && (f_1272_45811_45832(newEvent))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 45807, 46131);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 45874, 45899);

                        f_1272_45874_45898(this, newEvent);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 45807, 46131);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 45807, 46131);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 45987, 46010);
                        lock (f_1272_45987_46010(f_1272_45987_46001()))
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 46060, 46089);

                            f_1272_46060_46088(f_1272_46060_46074(), newEvent);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 45807, 46131);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 46151, 46329);
                        foreach (PSEventSubscriber subscriber in f_1272_46192_46225_I(subscribersWithoutActionOrHandler))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 46151, 46329);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 46267, 46310);

                            f_1272_46267_46309(this, subscriber);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 46151, 46329);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1272, 1, 179);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1272, 1, 179);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 45755, 46344);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 43846, 46355);

                System.Collections.Generic.List<System.Management.Automation.PSEventSubscriber>
                f_1272_44112_44141()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.PSEventSubscriber>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 44112, 44141);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSEventSubscriber>
                f_1272_44216_44245()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.PSEventSubscriber>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 44216, 44245);
                    return return_v;
                }


                string
                f_1272_44321_44346(System.Management.Automation.PSEventArgs
                this_param)
                {
                    var return_v = this_param.SourceIdentifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 44321, 44346);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSEventSubscriber>
                f_1272_44301_44353(System.Management.Automation.PSLocalEventManager
                this_param, string
                sourceIdentifier, bool
                forNewEventProcessing)
                {
                    var return_v = this_param.GetEventSubscribers(sourceIdentifier, forNewEventProcessing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 44301, 44353);
                    return return_v;
                }


                bool
                f_1272_44411_44434(System.Management.Automation.PSEventSubscriber
                this_param)
                {
                    var return_v = this_param.ForwardEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 44411, 44434);
                    return return_v;
                }


                System.Management.Automation.PSEventJob
                f_1272_44538_44555(System.Management.Automation.PSEventSubscriber
                this_param)
                {
                    var return_v = this_param.Action;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 44538, 44555);
                    return return_v;
                }


                System.Management.Automation.EventAction
                f_1272_44615_44652(System.Management.Automation.PSEventSubscriber
                sender, System.Management.Automation.PSEventArgs
                args)
                {
                    var return_v = new System.Management.Automation.EventAction(sender, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 44615, 44652);
                    return return_v;
                }


                int
                f_1272_44605_44675(System.Management.Automation.PSLocalEventManager
                this_param, System.Management.Automation.EventAction
                action, bool
                processSynchronously)
                {
                    this_param.AddAction(action, processSynchronously);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 44605, 44675);
                    return 0;
                }


                System.Management.Automation.PSEventReceivedEventHandler
                f_1272_44765_44791(System.Management.Automation.PSEventSubscriber
                this_param)
                {
                    var return_v = this_param.HandlerDelegate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 44765, 44791);
                    return return_v;
                }


                bool
                f_1272_44845_44886(System.Management.Automation.PSEventSubscriber
                this_param)
                {
                    var return_v = this_param.ShouldProcessInExecutionThread;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 44845, 44886);
                    return return_v;
                }


                System.Management.Automation.EventAction
                f_1272_44946_44983(System.Management.Automation.PSEventSubscriber
                sender, System.Management.Automation.PSEventArgs
                args)
                {
                    var return_v = new System.Management.Automation.EventAction(sender, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 44946, 44983);
                    return return_v;
                }


                int
                f_1272_44936_45006(System.Management.Automation.PSLocalEventManager
                this_param, System.Management.Automation.EventAction
                action, bool
                processSynchronously)
                {
                    this_param.AddAction(action, processSynchronously);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 44936, 45006);
                    return 0;
                }


                int
                f_1272_45105_45150(System.Collections.Generic.List<System.Management.Automation.PSEventSubscriber>
                this_param, System.Management.Automation.PSEventSubscriber
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 45105, 45150);
                    return 0;
                }


                int
                f_1272_45301_45350(System.Collections.Generic.List<System.Management.Automation.PSEventSubscriber>
                this_param, System.Management.Automation.PSEventSubscriber
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 45301, 45350);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSEventSubscriber>
                f_1272_44301_44353_I(System.Collections.Generic.IEnumerable<System.Management.Automation.PSEventSubscriber>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 44301, 44353);
                    return return_v;
                }


                object
                f_1272_45532_45547(System.Management.Automation.PSEventArgs
                this_param)
                {
                    var return_v = this_param.Sender;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 45532, 45547);
                    return return_v;
                }


                int
                f_1272_45505_45558(System.Management.Automation.PSEventSubscriber
                this_param, object
                sender, System.Management.Automation.PSEventArgs
                e)
                {
                    this_param.HandlerDelegate(sender, e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 45505, 45558);
                    return 0;
                }


                int
                f_1272_45577_45619(System.Management.Automation.PSLocalEventManager
                this_param, System.Management.Automation.PSEventSubscriber
                subscriber)
                {
                    this_param.AutoUnregisterEventIfNecessary(subscriber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 45577, 45619);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.PSEventSubscriber>
                f_1272_45442_45471_I(System.Collections.Generic.List<System.Management.Automation.PSEventSubscriber>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 45442, 45471);
                    return return_v;
                }


                bool
                f_1272_45811_45832(System.Management.Automation.PSEventArgs
                this_param)
                {
                    var return_v = this_param.ForwardEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 45811, 45832);
                    return return_v;
                }


                int
                f_1272_45874_45898(System.Management.Automation.PSLocalEventManager
                this_param, System.Management.Automation.PSEventArgs
                e)
                {
                    this_param.OnForwardEvent(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 45874, 45898);
                    return 0;
                }


                System.Management.Automation.PSEventArgsCollection
                f_1272_45987_46001()
                {
                    var return_v = ReceivedEvents;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 45987, 46001);
                    return return_v;
                }


                object
                f_1272_45987_46010(System.Management.Automation.PSEventArgsCollection
                this_param)
                {
                    var return_v = this_param.SyncRoot;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 45987, 46010);
                    return return_v;
                }


                System.Management.Automation.PSEventArgsCollection
                f_1272_46060_46074()
                {
                    var return_v = ReceivedEvents;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 46060, 46074);
                    return return_v;
                }


                int
                f_1272_46060_46088(System.Management.Automation.PSEventArgsCollection
                this_param, System.Management.Automation.PSEventArgs
                eventToAdd)
                {
                    this_param.Add(eventToAdd);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 46060, 46088);
                    return 0;
                }


                int
                f_1272_46267_46309(System.Management.Automation.PSLocalEventManager
                this_param, System.Management.Automation.PSEventSubscriber
                subscriber)
                {
                    this_param.AutoUnregisterEventIfNecessary(subscriber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 46267, 46309);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.PSEventSubscriber>
                f_1272_46192_46225_I(System.Collections.Generic.List<System.Management.Automation.PSEventSubscriber>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 46192, 46225);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 43846, 46355);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 43846, 46355);
            }
        }

        private void AddAction(EventAction action, bool processSynchronously)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 46412, 47055);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 46506, 46709) || true) && (processSynchronously)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 46506, 46709);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 46638, 46694);

                    f_1272_46638_46649(action).EventProcessed = f_1272_46667_46693();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 46506, 46709);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 46731, 46786);

                lock (f_1272_46731_46786(((System.Collections.ICollection)_actionQueue)))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 46970, 46999);

                    f_1272_46970_46998(                // If the engine isn't active, pulse the pipeline.
                                                       // When the engine starts up, it will pick up the pending events
                                    _actionQueue, action);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 47030, 47044);

                f_1272_47030_47043(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 46412, 47055);

                System.Management.Automation.PSEventArgs
                f_1272_46638_46649(System.Management.Automation.EventAction
                this_param)
                {
                    var return_v = this_param.Args;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 46638, 46649);
                    return return_v;
                }


                System.Threading.ManualResetEventSlim
                f_1272_46667_46693()
                {
                    var return_v = new System.Threading.ManualResetEventSlim();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 46667, 46693);
                    return return_v;
                }


                object
                f_1272_46731_46786(System.Collections.ICollection
                this_param)
                {
                    var return_v = this_param.SyncRoot;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 46731, 46786);
                    return return_v;
                }


                int
                f_1272_46970_46998(System.Collections.Generic.Queue<System.Management.Automation.EventAction>
                this_param, System.Management.Automation.EventAction
                item)
                {
                    this_param.Enqueue(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 46970, 46998);
                    return 0;
                }


                int
                f_1272_47030_47043(System.Management.Automation.PSLocalEventManager
                this_param)
                {
                    this_param.PulseEngine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 47030, 47043);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 46412, 47055);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 46412, 47055);
            }
        }

        private void PulseEngine()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 47419, 47644);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 47506, 47556);

                    f_1272_47506_47555(((LocalRunspace)f_1272_47522_47546(_context)));
                }
                catch (ObjectDisposedException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1272, 47585, 47633);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1272, 47585, 47633);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 47419, 47644);

                System.Management.Automation.Runspaces.Runspace
                f_1272_47522_47546(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 47522, 47546);
                    return return_v;
                }


                int
                f_1272_47506_47555(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    this_param.Pulse();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 47506, 47555);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 47419, 47644);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 47419, 47644);
            }
        }

        internal void ProcessPendingActions()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 48127, 48529);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 48421, 48474) || true) && (f_1272_48425_48443(_actionQueue) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 48421, 48474);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 48467, 48474);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 48421, 48474);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 48490, 48518);

                f_1272_48490_48517(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 48127, 48529);

                int
                f_1272_48425_48443(System.Collections.Generic.Queue<System.Management.Automation.EventAction>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 48425, 48443);
                    return return_v;
                }


                int
                f_1272_48490_48517(System.Management.Automation.PSLocalEventManager
                this_param)
                {
                    this_param.ProcessPendingActionsImpl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 48490, 48517);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 48127, 48529);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 48127, 48529);
            }
        }

        private void ProcessPendingActionsImpl()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 48541, 51191);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 48651, 48703) || true) && (f_1272_48655_48677())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 48651, 48703);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 48696, 48703);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 48651, 48703);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 48761, 48782);
                    lock (_actionProcessingLock)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 48824, 48884) || true) && (f_1272_48828_48850())
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 48824, 48884);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 48877, 48884);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 48824, 48884);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 48908, 48926);

                        int
                        processed = 0
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 48948, 48966);

                        _throttleChecks++;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 48988, 49011);

                        EventAction
                        nextAction
                        = default(EventAction);
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 49035, 50161) || true) && ((_throttleLimit * _throttleChecks) >= processed)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 49035, 50161);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 49338, 49393);
                                // Now, check for (and process) pending actions.
                                // Lock the collection so that it doesn't change from
                                // beneath us.
                                lock (f_1272_49338_49393(((System.Collections.ICollection)_actionQueue)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 49451, 49487);

                                    int
                                    queueCount = f_1272_49468_49486(_actionQueue)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 49599, 49660) || true) && (queueCount == 0)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 49599, 49660);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 49653, 49660);

                                        return;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 49599, 49660);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 49692, 49728);

                                    nextAction = f_1272_49705_49727(_actionQueue);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 49783, 49823);

                                bool
                                addActionBackToActionQueue = false
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 49849, 49906);

                                f_1272_49849_49905(this, nextAction, out addActionBackToActionQueue);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 49932, 49944);

                                processed++;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 49972, 50138) || true) && (!addActionBackToActionQueue)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 49972, 50138);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 50061, 50111);

                                    f_1272_50061_50110(this, f_1272_50092_50109(nextAction));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 49972, 50138);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 49035, 50161);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1272, 49035, 50161);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1272, 49035, 50161);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 50185, 50249) || true) && (processed > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 50185, 50249);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 50229, 50249);

                            _throttleChecks = 0;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 50185, 50249);
                        }
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1272, 50297, 51180);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 50337, 51165) || true) && (f_1272_50341_50359(_actionQueue) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 50337, 51165);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 50879, 51146);

                        f_1272_50879_51145(new WaitCallback(
                                                delegate (object unused)
                                                {
                                                    System.Threading.Thread.Sleep(100);
                                                    this.PulseEngine();
                                                }));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 50337, 51165);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1272, 50297, 51180);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 48541, 51191);

                bool
                f_1272_48655_48677()
                {
                    var return_v = IsExecutingEventAction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 48655, 48677);
                    return return_v;
                }


                bool
                f_1272_48828_48850()
                {
                    var return_v = IsExecutingEventAction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 48828, 48850);
                    return return_v;
                }


                object
                f_1272_49338_49393(System.Collections.ICollection
                this_param)
                {
                    var return_v = this_param.SyncRoot;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 49338, 49393);
                    return return_v;
                }


                int
                f_1272_49468_49486(System.Collections.Generic.Queue<System.Management.Automation.EventAction>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 49468, 49486);
                    return return_v;
                }


                System.Management.Automation.EventAction
                f_1272_49705_49727(System.Collections.Generic.Queue<System.Management.Automation.EventAction>
                this_param)
                {
                    var return_v = this_param.Dequeue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 49705, 49727);
                    return return_v;
                }


                int
                f_1272_49849_49905(System.Management.Automation.PSLocalEventManager
                this_param, System.Management.Automation.EventAction
                nextAction, out bool
                addActionBack)
                {
                    this_param.InvokeAction(nextAction, out addActionBack);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 49849, 49905);
                    return 0;
                }


                System.Management.Automation.PSEventSubscriber
                f_1272_50092_50109(System.Management.Automation.EventAction
                this_param)
                {
                    var return_v = this_param.Sender;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 50092, 50109);
                    return return_v;
                }


                int
                f_1272_50061_50110(System.Management.Automation.PSLocalEventManager
                this_param, System.Management.Automation.PSEventSubscriber
                subscriber)
                {
                    this_param.AutoUnregisterEventIfNecessary(subscriber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 50061, 50110);
                    return 0;
                }


                int
                f_1272_50341_50359(System.Collections.Generic.Queue<System.Management.Automation.EventAction>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 50341, 50359);
                    return return_v;
                }


                bool
                f_1272_50879_51145(System.Threading.WaitCallback
                callBack)
                {
                    var return_v = ThreadPool.QueueUserWorkItem(callBack);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 50879, 51145);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 48541, 51191);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 48541, 51191);
            }
        }

        private void AutoUnregisterEventIfNecessary(PSEventSubscriber subscriber)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 51371, 52002);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 51469, 51499);

                bool
                removeSubscriber = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 51513, 51871) || true) && (f_1272_51517_51542(subscriber))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 51513, 51871);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 51582, 51592);
                    lock (subscriber)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 51634, 51673);

                        f_1272_51634_51672_M(subscriber.RemainingActionsToProcess--);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 51695, 51837);

                        removeSubscriber = f_1272_51714_51746(subscriber) == 0 && (DynAbs.Tracing.TraceSender.Expression_True(1272, 51714, 51836) && f_1272_51795_51831(subscriber) == 0);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 51513, 51871);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 51887, 51991) || true) && (removeSubscriber)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 51887, 51991);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 51941, 51976);

                    f_1272_51941_51975(this, subscriber, true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 51887, 51991);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 51371, 52002);

                bool
                f_1272_51517_51542(System.Management.Automation.PSEventSubscriber
                this_param)
                {
                    var return_v = this_param.AutoUnregister;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 51517, 51542);
                    return return_v;
                }


                int
                f_1272_51634_51672_M(int
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 51634, 51672);
                    return return_v;
                }


                int
                f_1272_51714_51746(System.Management.Automation.PSEventSubscriber
                this_param)
                {
                    var return_v = this_param.RemainingTriggerCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 51714, 51746);
                    return return_v;
                }


                int
                f_1272_51795_51831(System.Management.Automation.PSEventSubscriber
                this_param)
                {
                    var return_v = this_param.RemainingActionsToProcess;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 51795, 51831);
                    return return_v;
                }


                int
                f_1272_51941_51975(System.Management.Automation.PSLocalEventManager
                this_param, System.Management.Automation.PSEventSubscriber
                subscriber, bool
                skipDraining)
                {
                    this_param.UnsubscribeEvent(subscriber, skipDraining);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 51941, 51975);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 51371, 52002);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 51371, 52002);
            }
        }

        private object _actionProcessingLock;

        private EventAction _processingAction;

        internal void DrainPendingActions(PSEventSubscriber subscriber)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 52448, 54546);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 52668, 52721) || true) && (f_1272_52672_52690(_actionQueue) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 52668, 52721);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 52714, 52721);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 52668, 52721);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 52788, 52809);

                // Now, process pending actions
                lock (_actionProcessingLock)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 52849, 52904);
                    lock (f_1272_52849_52904(((System.Collections.ICollection)_actionQueue)))
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 52946, 52982);

                        int
                        queueCount = f_1272_52963_52981(_actionQueue)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 53078, 53131) || true) && (queueCount == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 53078, 53131);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 53124, 53131);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 53078, 53131);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 53155, 53184);

                        bool
                        needToScanAgain = false
                        ;
                        {
                            try
                            {
                                do

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 53208, 54501);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 53259, 53313);

                                    EventAction[]
                                    pendingActions = f_1272_53290_53312(_actionQueue)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 53339, 53360);

                                    f_1272_53339_53359(_actionQueue);
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 53388, 54453);
                                        foreach (EventAction pendingAction in f_1272_53426_53440_I(pendingActions))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 53388, 54453);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 53579, 54426) || true) && ((f_1272_53584_53604(pendingAction) == subscriber) && (DynAbs.Tracing.TraceSender.Expression_True(1272, 53583, 53692) && (pendingAction != _processingAction)))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 53579, 54426);
                                                try
                                                {
                                                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 53758, 53861) || true) && (f_1272_53765_53787())
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 53758, 53861);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 53826, 53861);

                                                        f_1272_53826_53860(100);
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 53758, 53861);
                                                    }
                                                }
                                                catch (System.Exception)
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1272, 53758, 53861);
                                                    throw;
                                                }
                                                finally
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1272, 53758, 53861);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 53897, 53937);

                                                bool
                                                addActionBackToActionQueue = false
                                                ;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 53971, 54031);

                                                f_1272_53971_54030(this, pendingAction, out addActionBackToActionQueue);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 54067, 54229) || true) && (addActionBackToActionQueue)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 54067, 54229);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 54171, 54194);

                                                    needToScanAgain = true;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 54067, 54229);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 53579, 54426);
                                            }

                                            else

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 53579, 54426);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 54359, 54395);

                                                f_1272_54359_54394(_actionQueue, pendingAction);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 53579, 54426);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 53388, 54453);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1272, 1, 1066);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(1272, 1, 1066);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 53208, 54501);
                                }
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 53208, 54501) || true) && (needToScanAgain)
                                );
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1272, 53208, 54501);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1272, 53208, 54501);
                            }
                        }
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 52448, 54546);

                int
                f_1272_52672_52690(System.Collections.Generic.Queue<System.Management.Automation.EventAction>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 52672, 52690);
                    return return_v;
                }


                object
                f_1272_52849_52904(System.Collections.ICollection
                this_param)
                {
                    var return_v = this_param.SyncRoot;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 52849, 52904);
                    return return_v;
                }


                int
                f_1272_52963_52981(System.Collections.Generic.Queue<System.Management.Automation.EventAction>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 52963, 52981);
                    return return_v;
                }


                System.Management.Automation.EventAction[]
                f_1272_53290_53312(System.Collections.Generic.Queue<System.Management.Automation.EventAction>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 53290, 53312);
                    return return_v;
                }


                int
                f_1272_53339_53359(System.Collections.Generic.Queue<System.Management.Automation.EventAction>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 53339, 53359);
                    return 0;
                }


                System.Management.Automation.PSEventSubscriber
                f_1272_53584_53604(System.Management.Automation.EventAction
                this_param)
                {
                    var return_v = this_param.Sender;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 53584, 53604);
                    return return_v;
                }


                bool
                f_1272_53765_53787()
                {
                    var return_v = IsExecutingEventAction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 53765, 53787);
                    return return_v;
                }


                int
                f_1272_53826_53860(int
                millisecondsTimeout)
                {
                    System.Threading.Thread.Sleep(millisecondsTimeout);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 53826, 53860);
                    return 0;
                }


                int
                f_1272_53971_54030(System.Management.Automation.PSLocalEventManager
                this_param, System.Management.Automation.EventAction
                nextAction, out bool
                addActionBack)
                {
                    this_param.InvokeAction(nextAction, out addActionBack);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 53971, 54030);
                    return 0;
                }


                int
                f_1272_54359_54394(System.Collections.Generic.Queue<System.Management.Automation.EventAction>
                this_param, System.Management.Automation.EventAction
                item)
                {
                    this_param.Enqueue(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 54359, 54394);
                    return 0;
                }


                System.Management.Automation.EventAction[]
                f_1272_53426_53440_I(System.Management.Automation.EventAction[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 53426, 53440);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 52448, 54546);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 52448, 54546);
            }
        }

        private void InvokeAction(EventAction nextAction, out bool addActionBack)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 54558, 57335);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 54662, 54683);
                lock (_actionProcessingLock)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 54717, 54748);

                    _processingAction = nextAction;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 54766, 54788);

                    addActionBack = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 54871, 54938);

                    SessionStateInternal
                    oldSessionState = f_1272_54910_54937(_context)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 54956, 55141) || true) && (f_1272_54960_54984(f_1272_54960_54977(nextAction)) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 54956, 55141);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 55034, 55122);

                        _context.EngineSessionState = f_1272_55064_55121(f_1272_55064_55100(f_1272_55064_55088(f_1272_55064_55081(nextAction))));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 54956, 55141);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 55161, 55208);

                    Runspace
                    oldDefault = f_1272_55183_55207()
                    ;

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 55588, 55640);

                        Runspace.DefaultRunspace = f_1272_55615_55639(_context);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 55662, 56007) || true) && (f_1272_55666_55690(f_1272_55666_55683(nextAction)) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 55662, 56007);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 55748, 55816);

                            f_1272_55748_55815(f_1272_55748_55772(f_1272_55748_55765(nextAction)), f_1272_55780_55797(nextAction), f_1272_55799_55814(nextAction));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 55662, 56007);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 55662, 56007);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 55914, 55984);

                            f_1272_55914_55983(f_1272_55914_55931(nextAction), f_1272_55948_55965(nextAction), f_1272_55967_55982(nextAction));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 55662, 56007);
                        }
                    }
                    catch (Exception e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1272, 56044, 56835);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 56174, 56816) || true) && (e is PipelineStoppedException)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 56174, 56816);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 56695, 56746);

                            f_1272_56695_56745(this, nextAction, processSynchronously: false);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 56772, 56793);

                            addActionBack = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 56174, 56816);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1272, 56044, 56835);
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1272, 56853, 57309);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 56901, 56953);

                        var
                        eventProcessed = f_1272_56922_56952(f_1272_56922_56937(nextAction))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 56975, 57113) || true) && (!addActionBack && (DynAbs.Tracing.TraceSender.Expression_True(1272, 56979, 57019) && eventProcessed != null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 56975, 57113);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 57069, 57090);

                            f_1272_57069_57089(eventProcessed);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 56975, 57113);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 57137, 57175);

                        Runspace.DefaultRunspace = oldDefault;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 57197, 57243);

                        _context.EngineSessionState = oldSessionState;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 57265, 57290);

                        _processingAction = null;
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1272, 56853, 57309);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 54558, 57335);

                System.Management.Automation.SessionStateInternal
                f_1272_54910_54937(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 54910, 54937);
                    return return_v;
                }


                System.Management.Automation.PSEventSubscriber
                f_1272_54960_54977(System.Management.Automation.EventAction
                this_param)
                {
                    var return_v = this_param.Sender;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 54960, 54977);
                    return return_v;
                }


                System.Management.Automation.PSEventJob
                f_1272_54960_54984(System.Management.Automation.PSEventSubscriber
                this_param)
                {
                    var return_v = this_param.Action;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 54960, 54984);
                    return return_v;
                }


                System.Management.Automation.PSEventSubscriber
                f_1272_55064_55081(System.Management.Automation.EventAction
                this_param)
                {
                    var return_v = this_param.Sender;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 55064, 55081);
                    return return_v;
                }


                System.Management.Automation.PSEventJob
                f_1272_55064_55088(System.Management.Automation.PSEventSubscriber
                this_param)
                {
                    var return_v = this_param.Action;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 55064, 55088);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1272_55064_55100(System.Management.Automation.PSEventJob
                this_param)
                {
                    var return_v = this_param.ScriptBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 55064, 55100);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1272_55064_55121(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.SessionStateInternal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 55064, 55121);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1272_55183_55207()
                {
                    var return_v = Runspace.DefaultRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 55183, 55207);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1272_55615_55639(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 55615, 55639);
                    return return_v;
                }


                System.Management.Automation.PSEventSubscriber
                f_1272_55666_55683(System.Management.Automation.EventAction
                this_param)
                {
                    var return_v = this_param.Sender;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 55666, 55683);
                    return return_v;
                }


                System.Management.Automation.PSEventJob
                f_1272_55666_55690(System.Management.Automation.PSEventSubscriber
                this_param)
                {
                    var return_v = this_param.Action;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 55666, 55690);
                    return return_v;
                }


                System.Management.Automation.PSEventSubscriber
                f_1272_55748_55765(System.Management.Automation.EventAction
                this_param)
                {
                    var return_v = this_param.Sender;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 55748, 55765);
                    return return_v;
                }


                System.Management.Automation.PSEventJob
                f_1272_55748_55772(System.Management.Automation.PSEventSubscriber
                this_param)
                {
                    var return_v = this_param.Action;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 55748, 55772);
                    return return_v;
                }


                System.Management.Automation.PSEventSubscriber
                f_1272_55780_55797(System.Management.Automation.EventAction
                this_param)
                {
                    var return_v = this_param.Sender;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 55780, 55797);
                    return return_v;
                }


                System.Management.Automation.PSEventArgs
                f_1272_55799_55814(System.Management.Automation.EventAction
                this_param)
                {
                    var return_v = this_param.Args;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 55799, 55814);
                    return return_v;
                }


                int
                f_1272_55748_55815(System.Management.Automation.PSEventJob
                this_param, System.Management.Automation.PSEventSubscriber
                eventSubscriber, System.Management.Automation.PSEventArgs
                eventArgs)
                {
                    this_param.Invoke(eventSubscriber, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 55748, 55815);
                    return 0;
                }


                System.Management.Automation.PSEventSubscriber
                f_1272_55914_55931(System.Management.Automation.EventAction
                this_param)
                {
                    var return_v = this_param.Sender;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 55914, 55931);
                    return return_v;
                }


                System.Management.Automation.PSEventSubscriber
                f_1272_55948_55965(System.Management.Automation.EventAction
                this_param)
                {
                    var return_v = this_param.Sender;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 55948, 55965);
                    return return_v;
                }


                System.Management.Automation.PSEventArgs
                f_1272_55967_55982(System.Management.Automation.EventAction
                this_param)
                {
                    var return_v = this_param.Args;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 55967, 55982);
                    return return_v;
                }


                int
                f_1272_55914_55983(System.Management.Automation.PSEventSubscriber
                this_param, System.Management.Automation.PSEventSubscriber
                sender, System.Management.Automation.PSEventArgs
                e)
                {
                    this_param.HandlerDelegate((object)sender, e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 55914, 55983);
                    return 0;
                }


                int
                f_1272_56695_56745(System.Management.Automation.PSLocalEventManager
                this_param, System.Management.Automation.EventAction
                action, bool
                processSynchronously)
                {
                    this_param.AddAction(action, processSynchronously: processSynchronously);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 56695, 56745);
                    return 0;
                }


                System.Management.Automation.PSEventArgs
                f_1272_56922_56937(System.Management.Automation.EventAction
                this_param)
                {
                    var return_v = this_param.Args;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 56922, 56937);
                    return return_v;
                }


                System.Threading.ManualResetEventSlim
                f_1272_56922_56952(System.Management.Automation.PSEventArgs
                this_param)
                {
                    var return_v = this_param.EventProcessed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 56922, 56952);
                    return return_v;
                }


                int
                f_1272_57069_57089(System.Threading.ManualResetEventSlim
                this_param)
                {
                    this_param.Set();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 57069, 57089);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 54558, 57335);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 54558, 57335);
            }
        }

        internal bool IsExecutingEventAction
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 57408, 57451);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 57414, 57449);

                    return (_processingAction != null);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 57408, 57451);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 57347, 57462);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 57347, 57462);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override IEnumerable<PSEventSubscriber> GetEventSubscribers(string sourceIdentifier)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 57731, 57910);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 57847, 57899);

                return f_1272_57854_57898(this, sourceIdentifier, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 57731, 57910);

                System.Collections.Generic.IEnumerable<System.Management.Automation.PSEventSubscriber>
                f_1272_57854_57898(System.Management.Automation.PSLocalEventManager
                this_param, string
                sourceIdentifier, bool
                forNewEventProcessing)
                {
                    var return_v = this_param.GetEventSubscribers(sourceIdentifier, forNewEventProcessing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 57854, 57898);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 57731, 57910);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 57731, 57910);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private IEnumerable<PSEventSubscriber> GetEventSubscribers(string sourceIdentifier, bool forNewEventProcessing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 58158, 61380);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 58294, 58370);

                List<PSEventSubscriber>
                returnedSubscribers = f_1272_58340_58369()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 58384, 58463);

                List<PSEventSubscriber>
                subscribersToBeRemoved = f_1272_58433_58462()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 58485, 58502);

                lock (_eventSubscribers)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 58536, 61051);
                        foreach (PSEventSubscriber currentSubscriber in f_1272_58584_58606_I(f_1272_58584_58606(_eventSubscribers)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 58536, 61051);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 58648, 58680);

                            bool
                            takeActionForEvent = false
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 58702, 61032) || true) && (f_1272_58706_58809(f_1272_58720_58754(currentSubscriber), sourceIdentifier, StringComparison.OrdinalIgnoreCase))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 58702, 61032);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 58859, 59711) || true) && (forNewEventProcessing)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 58859, 59711);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 59012, 59394) || true) && (f_1272_59016_59049_M(!currentSubscriber.AutoUnregister) || (DynAbs.Tracing.TraceSender.Expression_False(1272, 59016, 59096) || f_1272_59053_59092(currentSubscriber) > 0))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 59012, 59394);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 59260, 59286);

                                        takeActionForEvent = true;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 59320, 59363);

                                        f_1272_59320_59362(returnedSubscribers, currentSubscriber);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 59012, 59394);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 58859, 59711);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 58859, 59711);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 59641, 59684);

                                    f_1272_59641_59683(                            // The caller tries to get all subscribers for this event but it's NOT for the event processing purpose
                                                                returnedSubscribers, currentSubscriber);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 58859, 59711);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 59807, 61009) || true) && (forNewEventProcessing && (DynAbs.Tracing.TraceSender.Expression_True(1272, 59811, 59868) && f_1272_59836_59868(currentSubscriber)) && (DynAbs.Tracing.TraceSender.Expression_True(1272, 59811, 59915) && f_1272_59872_59911(currentSubscriber) > 0))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 59807, 61009);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 59979, 59996);
                                    lock (currentSubscriber)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 60062, 60104);

                                        f_1272_60062_60103_M(currentSubscriber.RemainingTriggerCount--);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 60371, 60548) || true) && (takeActionForEvent)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 60371, 60548);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 60467, 60513);

                                            f_1272_60467_60512_M(currentSubscriber.RemainingActionsToProcess++);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 60371, 60548);
                                        }

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 60696, 60951) || true) && (f_1272_60700_60739(currentSubscriber) == 0 && (DynAbs.Tracing.TraceSender.Expression_True(1272, 60700, 60796) && f_1272_60748_60791(currentSubscriber) == 0))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 60696, 60951);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 60870, 60916);

                                            f_1272_60870_60915(subscribersToBeRemoved, currentSubscriber);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 60696, 60951);
                                        }
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 59807, 61009);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 58702, 61032);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 58536, 61051);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1272, 1, 2516);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1272, 1, 2516);
                    }
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 61082, 61326) || true) && (f_1272_61086_61114(subscribersToBeRemoved) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 61082, 61326);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 61152, 61311);
                        foreach (PSEventSubscriber subscriber in f_1272_61193_61215_I(subscribersToBeRemoved))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 61152, 61311);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 61257, 61292);

                            f_1272_61257_61291(this, subscriber, true);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 61152, 61311);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1272, 1, 160);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1272, 1, 160);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 61082, 61326);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 61342, 61369);

                return returnedSubscribers;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 58158, 61380);

                System.Collections.Generic.List<System.Management.Automation.PSEventSubscriber>
                f_1272_58340_58369()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.PSEventSubscriber>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 58340, 58369);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSEventSubscriber>
                f_1272_58433_58462()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.PSEventSubscriber>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 58433, 58462);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.PSEventSubscriber, System.Delegate>.KeyCollection
                f_1272_58584_58606(System.Collections.Generic.Dictionary<System.Management.Automation.PSEventSubscriber, System.Delegate>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 58584, 58606);
                    return return_v;
                }


                string
                f_1272_58720_58754(System.Management.Automation.PSEventSubscriber
                this_param)
                {
                    var return_v = this_param.SourceIdentifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 58720, 58754);
                    return return_v;
                }


                bool
                f_1272_58706_58809(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 58706, 58809);
                    return return_v;
                }


                bool
                f_1272_59016_59049_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 59016, 59049);
                    return return_v;
                }


                int
                f_1272_59053_59092(System.Management.Automation.PSEventSubscriber
                this_param)
                {
                    var return_v = this_param.RemainingTriggerCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 59053, 59092);
                    return return_v;
                }


                int
                f_1272_59320_59362(System.Collections.Generic.List<System.Management.Automation.PSEventSubscriber>
                this_param, System.Management.Automation.PSEventSubscriber
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 59320, 59362);
                    return 0;
                }


                int
                f_1272_59641_59683(System.Collections.Generic.List<System.Management.Automation.PSEventSubscriber>
                this_param, System.Management.Automation.PSEventSubscriber
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 59641, 59683);
                    return 0;
                }


                bool
                f_1272_59836_59868(System.Management.Automation.PSEventSubscriber
                this_param)
                {
                    var return_v = this_param.AutoUnregister;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 59836, 59868);
                    return return_v;
                }


                int
                f_1272_59872_59911(System.Management.Automation.PSEventSubscriber
                this_param)
                {
                    var return_v = this_param.RemainingTriggerCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 59872, 59911);
                    return return_v;
                }


                int
                f_1272_60062_60103_M(int
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 60062, 60103);
                    return return_v;
                }


                int
                f_1272_60467_60512_M(int
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 60467, 60512);
                    return return_v;
                }


                int
                f_1272_60700_60739(System.Management.Automation.PSEventSubscriber
                this_param)
                {
                    var return_v = this_param.RemainingTriggerCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 60700, 60739);
                    return return_v;
                }


                int
                f_1272_60748_60791(System.Management.Automation.PSEventSubscriber
                this_param)
                {
                    var return_v = this_param.RemainingActionsToProcess;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 60748, 60791);
                    return return_v;
                }


                int
                f_1272_60870_60915(System.Collections.Generic.List<System.Management.Automation.PSEventSubscriber>
                this_param, System.Management.Automation.PSEventSubscriber
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 60870, 60915);
                    return 0;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.PSEventSubscriber, System.Delegate>.KeyCollection
                f_1272_58584_58606_I(System.Collections.Generic.Dictionary<System.Management.Automation.PSEventSubscriber, System.Delegate>.KeyCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 58584, 58606);
                    return return_v;
                }


                int
                f_1272_61086_61114(System.Collections.Generic.List<System.Management.Automation.PSEventSubscriber>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 61086, 61114);
                    return return_v;
                }


                int
                f_1272_61257_61291(System.Management.Automation.PSLocalEventManager
                this_param, System.Management.Automation.PSEventSubscriber
                subscriber, bool
                skipDraining)
                {
                    this_param.UnsubscribeEvent(subscriber, skipDraining);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 61257, 61291);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.PSEventSubscriber>
                f_1272_61193_61215_I(System.Collections.Generic.List<System.Management.Automation.PSEventSubscriber>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 61193, 61215);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 58158, 61380);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 58158, 61380);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Type GenerateEventHandler(MethodInfo invokeSignature)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 61759, 67923);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 61845, 61905);

                int
                parameterCount = f_1272_61866_61904(f_1272_61866_61897(invokeSignature))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 62106, 62247);

                TypeBuilder
                eventType =
                f_1272_62147_62246(_eventModule, "PSEventHandler_" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (_typeId).ToString(), 1272, 62191, 62198), TypeAttributes.Public, typeof(PSEventHandler))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 62261, 62271);

                _typeId++;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 62337, 62541);

                ConstructorInfo
                existingConstructor =
                f_1272_62392_62540(typeof(PSEventHandler), new Type[] { typeof(PSEventManager), typeof(object), typeof(string), typeof(PSObject) })
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 62803, 63050);

                ConstructorBuilder
                eventConstructor =
                f_1272_62858_63049(eventType, MethodAttributes.Public, CallingConventions.Standard, new Type[] { typeof(PSEventManager), typeof(object), typeof(string), typeof(PSObject) })
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 63064, 63132);

                ILGenerator
                extendedConstructor = f_1272_63098_63131(eventConstructor)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 63146, 63188);

                f_1272_63146_63187(extendedConstructor, OpCodes.Ldarg_0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 63202, 63244);

                f_1272_63202_63243(extendedConstructor, OpCodes.Ldarg_1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 63258, 63300);

                f_1272_63258_63299(extendedConstructor, OpCodes.Ldarg_2);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 63314, 63356);

                f_1272_63314_63355(extendedConstructor, OpCodes.Ldarg_3);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 63370, 63413);

                f_1272_63370_63412(extendedConstructor, OpCodes.Ldarg, 4);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 63427, 63487);

                f_1272_63427_63486(extendedConstructor, OpCodes.Call, existingConstructor);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 63501, 63539);

                f_1272_63501_63538(extendedConstructor, OpCodes.Ret);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 63651, 63700);

                Type[]
                parameterTypes = new Type[parameterCount]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 63714, 63739);

                int
                parameterCounter = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 63753, 63965);
                    foreach (ParameterInfo parameter in f_1272_63789_63820_I(f_1272_63789_63820(invokeSignature)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 63753, 63965);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 63854, 63913);

                        parameterTypes[parameterCounter] = f_1272_63889_63912(parameter);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 63931, 63950);

                        parameterCounter++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 63753, 63965);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1272, 1, 213);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1272, 1, 213);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 64061, 64244);

                MethodBuilder
                eventMethod = f_1272_64089_64243(eventType, "EventDelegate", MethodAttributes.Public, CallingConventions.Standard, f_1272_64200_64226(invokeSignature), parameterTypes)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 64344, 64365);

                parameterCounter = 1;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 64379, 64665);
                    foreach (ParameterInfo parameter in f_1272_64415_64446_I(f_1272_64415_64446(invokeSignature)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 64379, 64665);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 64480, 64613);

                        ParameterBuilder
                        builder = f_1272_64507_64612(eventMethod, parameterCounter, f_1272_64575_64595(parameter), f_1272_64597_64611(parameter))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 64631, 64650);

                        parameterCounter++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 64379, 64665);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1272, 1, 287);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1272, 1, 287);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 64681, 64739);

                ILGenerator
                methodContents = f_1272_64710_64738(eventMethod)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 64851, 64897);

                f_1272_64851_64896(
                            // Declare a local variable of the type 'object[]' at index 0, say 'object[] args'
                            methodContents, typeof(object[]));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 64913, 64965);

                f_1272_64913_64964(
                            methodContents, OpCodes.Ldc_I4, parameterCount);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 64979, 65031);

                f_1272_64979_65030(methodContents, OpCodes.Newarr, typeof(object));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 65112, 65149);

                f_1272_65112_65148(
                            // Store the new array to the local variable 'args'
                            methodContents, OpCodes.Stloc_0);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 65305, 65316);

                    // Inline, this converts into a series of setting args[n] to
                    // the argument at the same parameter index
                    for (int
        counter = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 65296, 65867) || true) && (counter <= parameterCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 65345, 65354)
        , counter++, DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 65296, 65867))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 65296, 65867);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 65388, 65425);

                        f_1272_65388_65424(methodContents, OpCodes.Ldloc_0);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 65443, 65492);

                        f_1272_65443_65491(methodContents, OpCodes.Ldc_I4, counter - 1);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 65510, 65554);

                        f_1272_65510_65553(methodContents, OpCodes.Ldarg, counter);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 65626, 65792) || true) && (f_1272_65630_65669(parameterTypes[counter - 1]))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 65626, 65792);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 65711, 65773);

                            f_1272_65711_65772(methodContents, OpCodes.Box, parameterTypes[counter - 1]);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 65626, 65792);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 65812, 65852);

                        f_1272_65812_65851(
                                        methodContents, OpCodes.Stelem_Ref);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1272, 1, 572);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1272, 1, 572);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 65921, 65958);

                f_1272_65921_65957(
                            // Gain access to "this"
                            methodContents, OpCodes.Ldarg_0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 66056, 66199);

                FieldInfo
                eventManagerField = f_1272_66086_66198(typeof(PSEventHandler), "eventManager", BindingFlags.NonPublic | BindingFlags.Instance)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 66213, 66267);

                f_1272_66213_66266(methodContents, OpCodes.Ldfld, eventManagerField);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 66341, 66378);

                f_1272_66341_66377(
                            // Then the "sourceIdentifier" private field
                            methodContents, OpCodes.Ldarg_0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 66392, 66537);

                FieldInfo
                identifierField = f_1272_66420_66536(typeof(PSEventHandler), "sourceIdentifier", BindingFlags.NonPublic | BindingFlags.Instance)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 66551, 66603);

                f_1272_66551_66602(methodContents, OpCodes.Ldfld, identifierField);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 66667, 66704);

                f_1272_66667_66703(
                            // Then the "sender" private field
                            methodContents, OpCodes.Ldarg_0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 66718, 66849);

                FieldInfo
                senderField = f_1272_66742_66848(typeof(PSEventHandler), "sender", BindingFlags.NonPublic | BindingFlags.Instance)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 66863, 66911);

                f_1272_66863_66910(methodContents, OpCodes.Ldfld, senderField);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 66986, 67023);

                f_1272_66986_67022(
                            // Then push the args variable onto the stack
                            methodContents, OpCodes.Ldloc_0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 67095, 67132);

                f_1272_67095_67131(
                            // Then push the "extraData" private field
                            methodContents, OpCodes.Ldarg_0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 67146, 67283);

                FieldInfo
                extraDataField = f_1272_67173_67282(typeof(PSEventHandler), "extraData", BindingFlags.NonPublic | BindingFlags.Instance)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 67297, 67348);

                f_1272_67297_67347(methodContents, OpCodes.Ldfld, extraDataField);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 67407, 67629);

                MethodInfo
                generateEventMethod = f_1272_67440_67628(typeof(PSEventManager), nameof(PSEventManager.GenerateEvent), new Type[] { typeof(string), typeof(object), typeof(object[]), typeof(PSObject) })
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 67645, 67704);

                f_1272_67645_67703(
                            methodContents, OpCodes.Callvirt, generateEventMethod);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 67773, 67806);

                f_1272_67773_67805(
                            // Discard the return value, and return
                            methodContents, OpCodes.Pop);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 67820, 67853);

                f_1272_67820_67852(methodContents, OpCodes.Ret);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 67869, 67912);

                return f_1272_67876_67911(f_1272_67876_67902(eventType));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 61759, 67923);

                System.Reflection.ParameterInfo[]
                f_1272_61866_61897(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.GetParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 61866, 61897);
                    return return_v;
                }


                int
                f_1272_61866_61904(System.Reflection.ParameterInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 61866, 61904);
                    return return_v;
                }


                System.Reflection.Emit.TypeBuilder
                f_1272_62147_62246(System.Reflection.Emit.ModuleBuilder
                this_param, string
                name, System.Reflection.TypeAttributes
                attr, System.Type
                parent)
                {
                    var return_v = this_param.DefineType(name, attr, parent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 62147, 62246);
                    return return_v;
                }


                System.Reflection.ConstructorInfo?
                f_1272_62392_62540(System.Type
                this_param, System.Type[]
                types)
                {
                    var return_v = this_param.GetConstructor(types);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 62392, 62540);
                    return return_v;
                }


                System.Reflection.Emit.ConstructorBuilder
                f_1272_62858_63049(System.Reflection.Emit.TypeBuilder
                this_param, System.Reflection.MethodAttributes
                attributes, System.Reflection.CallingConventions
                callingConvention, System.Type[]
                parameterTypes)
                {
                    var return_v = this_param.DefineConstructor(attributes, callingConvention, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 62858, 63049);
                    return return_v;
                }


                System.Reflection.Emit.ILGenerator
                f_1272_63098_63131(System.Reflection.Emit.ConstructorBuilder
                this_param)
                {
                    var return_v = this_param.GetILGenerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 63098, 63131);
                    return return_v;
                }


                int
                f_1272_63146_63187(System.Reflection.Emit.ILGenerator
                this_param, System.Reflection.Emit.OpCode
                opcode)
                {
                    this_param.Emit(opcode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 63146, 63187);
                    return 0;
                }


                int
                f_1272_63202_63243(System.Reflection.Emit.ILGenerator
                this_param, System.Reflection.Emit.OpCode
                opcode)
                {
                    this_param.Emit(opcode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 63202, 63243);
                    return 0;
                }


                int
                f_1272_63258_63299(System.Reflection.Emit.ILGenerator
                this_param, System.Reflection.Emit.OpCode
                opcode)
                {
                    this_param.Emit(opcode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 63258, 63299);
                    return 0;
                }


                int
                f_1272_63314_63355(System.Reflection.Emit.ILGenerator
                this_param, System.Reflection.Emit.OpCode
                opcode)
                {
                    this_param.Emit(opcode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 63314, 63355);
                    return 0;
                }


                int
                f_1272_63370_63412(System.Reflection.Emit.ILGenerator
                this_param, System.Reflection.Emit.OpCode
                opcode, int
                arg)
                {
                    this_param.Emit(opcode, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 63370, 63412);
                    return 0;
                }


                int
                f_1272_63427_63486(System.Reflection.Emit.ILGenerator
                this_param, System.Reflection.Emit.OpCode
                opcode, System.Reflection.ConstructorInfo
                con)
                {
                    this_param.Emit(opcode, con);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 63427, 63486);
                    return 0;
                }


                int
                f_1272_63501_63538(System.Reflection.Emit.ILGenerator
                this_param, System.Reflection.Emit.OpCode
                opcode)
                {
                    this_param.Emit(opcode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 63501, 63538);
                    return 0;
                }


                System.Reflection.ParameterInfo[]
                f_1272_63789_63820(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.GetParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 63789, 63820);
                    return return_v;
                }


                System.Type
                f_1272_63889_63912(System.Reflection.ParameterInfo
                this_param)
                {
                    var return_v = this_param.ParameterType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 63889, 63912);
                    return return_v;
                }


                System.Reflection.ParameterInfo[]
                f_1272_63789_63820_I(System.Reflection.ParameterInfo[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 63789, 63820);
                    return return_v;
                }


                System.Type
                f_1272_64200_64226(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 64200, 64226);
                    return return_v;
                }


                System.Reflection.Emit.MethodBuilder
                f_1272_64089_64243(System.Reflection.Emit.TypeBuilder
                this_param, string
                name, System.Reflection.MethodAttributes
                attributes, System.Reflection.CallingConventions
                callingConvention, System.Type
                returnType, System.Type[]
                parameterTypes)
                {
                    var return_v = this_param.DefineMethod(name, attributes, callingConvention, returnType, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 64089, 64243);
                    return return_v;
                }


                System.Reflection.ParameterInfo[]
                f_1272_64415_64446(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.GetParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 64415, 64446);
                    return return_v;
                }


                System.Reflection.ParameterAttributes
                f_1272_64575_64595(System.Reflection.ParameterInfo
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 64575, 64595);
                    return return_v;
                }


                string
                f_1272_64597_64611(System.Reflection.ParameterInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 64597, 64611);
                    return return_v;
                }


                System.Reflection.Emit.ParameterBuilder
                f_1272_64507_64612(System.Reflection.Emit.MethodBuilder
                this_param, int
                position, System.Reflection.ParameterAttributes
                attributes, string
                strParamName)
                {
                    var return_v = this_param.DefineParameter(position, attributes, strParamName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 64507, 64612);
                    return return_v;
                }


                System.Reflection.ParameterInfo[]
                f_1272_64415_64446_I(System.Reflection.ParameterInfo[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 64415, 64446);
                    return return_v;
                }


                System.Reflection.Emit.ILGenerator
                f_1272_64710_64738(System.Reflection.Emit.MethodBuilder
                this_param)
                {
                    var return_v = this_param.GetILGenerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 64710, 64738);
                    return return_v;
                }


                System.Reflection.Emit.LocalBuilder
                f_1272_64851_64896(System.Reflection.Emit.ILGenerator
                this_param, System.Type
                localType)
                {
                    var return_v = this_param.DeclareLocal(localType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 64851, 64896);
                    return return_v;
                }


                int
                f_1272_64913_64964(System.Reflection.Emit.ILGenerator
                this_param, System.Reflection.Emit.OpCode
                opcode, int
                arg)
                {
                    this_param.Emit(opcode, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 64913, 64964);
                    return 0;
                }


                int
                f_1272_64979_65030(System.Reflection.Emit.ILGenerator
                this_param, System.Reflection.Emit.OpCode
                opcode, System.Type
                cls)
                {
                    this_param.Emit(opcode, cls);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 64979, 65030);
                    return 0;
                }


                int
                f_1272_65112_65148(System.Reflection.Emit.ILGenerator
                this_param, System.Reflection.Emit.OpCode
                opcode)
                {
                    this_param.Emit(opcode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 65112, 65148);
                    return 0;
                }


                int
                f_1272_65388_65424(System.Reflection.Emit.ILGenerator
                this_param, System.Reflection.Emit.OpCode
                opcode)
                {
                    this_param.Emit(opcode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 65388, 65424);
                    return 0;
                }


                int
                f_1272_65443_65491(System.Reflection.Emit.ILGenerator
                this_param, System.Reflection.Emit.OpCode
                opcode, int
                arg)
                {
                    this_param.Emit(opcode, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 65443, 65491);
                    return 0;
                }


                int
                f_1272_65510_65553(System.Reflection.Emit.ILGenerator
                this_param, System.Reflection.Emit.OpCode
                opcode, int
                arg)
                {
                    this_param.Emit(opcode, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 65510, 65553);
                    return 0;
                }


                bool
                f_1272_65630_65669(System.Type
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 65630, 65669);
                    return return_v;
                }


                int
                f_1272_65711_65772(System.Reflection.Emit.ILGenerator
                this_param, System.Reflection.Emit.OpCode
                opcode, System.Type
                cls)
                {
                    this_param.Emit(opcode, cls);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 65711, 65772);
                    return 0;
                }


                int
                f_1272_65812_65851(System.Reflection.Emit.ILGenerator
                this_param, System.Reflection.Emit.OpCode
                opcode)
                {
                    this_param.Emit(opcode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 65812, 65851);
                    return 0;
                }


                int
                f_1272_65921_65957(System.Reflection.Emit.ILGenerator
                this_param, System.Reflection.Emit.OpCode
                opcode)
                {
                    this_param.Emit(opcode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 65921, 65957);
                    return 0;
                }


                System.Reflection.FieldInfo?
                f_1272_66086_66198(System.Type
                this_param, string
                name, System.Reflection.BindingFlags
                bindingAttr)
                {
                    var return_v = this_param.GetField(name, bindingAttr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 66086, 66198);
                    return return_v;
                }


                int
                f_1272_66213_66266(System.Reflection.Emit.ILGenerator
                this_param, System.Reflection.Emit.OpCode
                opcode, System.Reflection.FieldInfo
                field)
                {
                    this_param.Emit(opcode, field);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 66213, 66266);
                    return 0;
                }


                int
                f_1272_66341_66377(System.Reflection.Emit.ILGenerator
                this_param, System.Reflection.Emit.OpCode
                opcode)
                {
                    this_param.Emit(opcode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 66341, 66377);
                    return 0;
                }


                System.Reflection.FieldInfo?
                f_1272_66420_66536(System.Type
                this_param, string
                name, System.Reflection.BindingFlags
                bindingAttr)
                {
                    var return_v = this_param.GetField(name, bindingAttr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 66420, 66536);
                    return return_v;
                }


                int
                f_1272_66551_66602(System.Reflection.Emit.ILGenerator
                this_param, System.Reflection.Emit.OpCode
                opcode, System.Reflection.FieldInfo
                field)
                {
                    this_param.Emit(opcode, field);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 66551, 66602);
                    return 0;
                }


                int
                f_1272_66667_66703(System.Reflection.Emit.ILGenerator
                this_param, System.Reflection.Emit.OpCode
                opcode)
                {
                    this_param.Emit(opcode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 66667, 66703);
                    return 0;
                }


                System.Reflection.FieldInfo?
                f_1272_66742_66848(System.Type
                this_param, string
                name, System.Reflection.BindingFlags
                bindingAttr)
                {
                    var return_v = this_param.GetField(name, bindingAttr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 66742, 66848);
                    return return_v;
                }


                int
                f_1272_66863_66910(System.Reflection.Emit.ILGenerator
                this_param, System.Reflection.Emit.OpCode
                opcode, System.Reflection.FieldInfo
                field)
                {
                    this_param.Emit(opcode, field);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 66863, 66910);
                    return 0;
                }


                int
                f_1272_66986_67022(System.Reflection.Emit.ILGenerator
                this_param, System.Reflection.Emit.OpCode
                opcode)
                {
                    this_param.Emit(opcode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 66986, 67022);
                    return 0;
                }


                int
                f_1272_67095_67131(System.Reflection.Emit.ILGenerator
                this_param, System.Reflection.Emit.OpCode
                opcode)
                {
                    this_param.Emit(opcode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 67095, 67131);
                    return 0;
                }


                System.Reflection.FieldInfo?
                f_1272_67173_67282(System.Type
                this_param, string
                name, System.Reflection.BindingFlags
                bindingAttr)
                {
                    var return_v = this_param.GetField(name, bindingAttr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 67173, 67282);
                    return return_v;
                }


                int
                f_1272_67297_67347(System.Reflection.Emit.ILGenerator
                this_param, System.Reflection.Emit.OpCode
                opcode, System.Reflection.FieldInfo
                field)
                {
                    this_param.Emit(opcode, field);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 67297, 67347);
                    return 0;
                }


                System.Reflection.MethodInfo?
                f_1272_67440_67628(System.Type
                this_param, string
                name, System.Type[]
                types)
                {
                    var return_v = this_param.GetMethod(name, types);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 67440, 67628);
                    return return_v;
                }


                int
                f_1272_67645_67703(System.Reflection.Emit.ILGenerator
                this_param, System.Reflection.Emit.OpCode
                opcode, System.Reflection.MethodInfo
                meth)
                {
                    this_param.Emit(opcode, meth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 67645, 67703);
                    return 0;
                }


                int
                f_1272_67773_67805(System.Reflection.Emit.ILGenerator
                this_param, System.Reflection.Emit.OpCode
                opcode)
                {
                    this_param.Emit(opcode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 67773, 67805);
                    return 0;
                }


                int
                f_1272_67820_67852(System.Reflection.Emit.ILGenerator
                this_param, System.Reflection.Emit.OpCode
                opcode)
                {
                    this_param.Emit(opcode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 67820, 67852);
                    return 0;
                }


                System.Reflection.TypeInfo?
                f_1272_67876_67902(System.Reflection.Emit.TypeBuilder
                this_param)
                {
                    var return_v = this_param.CreateTypeInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 67876, 67902);
                    return return_v;
                }


                System.Type
                f_1272_67876_67911(System.Reflection.TypeInfo
                this_param)
                {
                    var return_v = this_param.AsType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 67876, 67911);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 61759, 67923);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 61759, 67923);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <summary>
        /// This event is raised by the event manager to forward events.
        /// </summary>
        internal override event EventHandler<PSEventArgs>
ForwardEvent
;

        protected virtual void OnForwardEvent(PSEventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 68222, 68445);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 68299, 68343);

                EventHandler<PSEventArgs>
                eh = ForwardEvent
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 68359, 68434) || true) && (eh != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 68359, 68434);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 68407, 68419);

                    f_1272_68407_68418(eh, this, e);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 68359, 68434);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 68222, 68445);

                int
                f_1272_68407_68418(System.EventHandler<System.Management.Automation.PSEventArgs>
                this_param, System.Management.Automation.PSLocalEventManager
                sender, System.Management.Automation.PSEventArgs
                e)
                {
                    this_param.Invoke((object)sender, e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 68407, 68418);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 68222, 68445);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 68222, 68445);
            }
        }

        /// <summary>
        /// Destructor for the EventManager class.
        /// </summary>
        ~PSLocalEventManager()
        {
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 68603, 68618);

            f_1272_68603_68617(this, false);
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 68734, 68845);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 68780, 68794);

                f_1272_68780_68793(this, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 68808, 68834);

                f_1272_68808_68833(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 68734, 68845);

                int
                f_1272_68780_68793(System.Management.Automation.PSLocalEventManager
                this_param, bool
                disposing)
                {
                    this_param.Dispose(disposing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 68780, 68793);
                    return 0;
                }


                int
                f_1272_68808_68833(System.Management.Automation.PSLocalEventManager
                obj)
                {
                    GC.SuppressFinalize((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 68808, 68833);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 68734, 68845);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 68734, 68845);
            }
        }

        public void Dispose(bool disposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 69106, 69644);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 69166, 69633) || true) && (disposing)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 69166, 69633);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 69219, 69236);
                    lock (_eventSubscribers)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 69278, 69386) || true) && (_timer != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 69278, 69386);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 69346, 69363);

                            f_1272_69346_69362(_timer);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 69278, 69386);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 69410, 69599);
                            foreach (PSEventSubscriber currentSubscriber in f_1272_69458_69490_I(f_1272_69458_69490(f_1272_69458_69480(_eventSubscribers))))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 69410, 69599);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 69540, 69576);

                                f_1272_69540_69575(this, currentSubscriber);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 69410, 69599);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1272, 1, 190);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1272, 1, 190);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 69166, 69633);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 69106, 69644);

                int
                f_1272_69346_69362(System.Threading.Timer
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 69346, 69362);
                    return 0;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.PSEventSubscriber, System.Delegate>.KeyCollection
                f_1272_69458_69480(System.Collections.Generic.Dictionary<System.Management.Automation.PSEventSubscriber, System.Delegate>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 69458, 69480);
                    return return_v;
                }


                System.Management.Automation.PSEventSubscriber[]
                f_1272_69458_69490(System.Collections.Generic.Dictionary<System.Management.Automation.PSEventSubscriber, System.Delegate>.KeyCollection
                source)
                {
                    var return_v = source.ToArray<System.Management.Automation.PSEventSubscriber>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 69458, 69490);
                    return return_v;
                }


                int
                f_1272_69540_69575(System.Management.Automation.PSLocalEventManager
                this_param, System.Management.Automation.PSEventSubscriber
                subscriber)
                {
                    this_param.UnsubscribeEvent(subscriber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 69540, 69575);
                    return 0;
                }


                System.Management.Automation.PSEventSubscriber[]
                f_1272_69458_69490_I(System.Management.Automation.PSEventSubscriber[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 69458, 69490);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 69106, 69644);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 69106, 69644);
            }
        }

        static PSLocalEventManager()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1272, 14508, 69651);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 29192, 29249);
            s_generatedEventHandlers = f_1272_29219_29249();
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1272, 14508, 69651);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 14508, 69651);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1272, 14508, 69651);

        System.Collections.Generic.Dictionary<System.Management.Automation.PSEventSubscriber, System.Delegate>
        f_1272_14800_14845()
        {
            var return_v = new System.Collections.Generic.Dictionary<System.Management.Automation.PSEventSubscriber, System.Delegate>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 14800, 14845);
            return return_v;
        }


        System.StringComparer
        f_1272_14934_14966()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 14934, 14966);
            return return_v;
        }


        System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.PSEventSubscriber>>
        f_1272_14886_14967(System.StringComparer
        comparer)
        {
            var return_v = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.PSEventSubscriber>>((System.Collections.Generic.IEqualityComparer<string>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 14886, 14967);
            return return_v;
        }


        System.Collections.Generic.Queue<System.Management.Automation.EventAction>
        f_1272_14997_15021()
        {
            var return_v = new System.Collections.Generic.Queue<System.Management.Automation.EventAction>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 14997, 15021);
            return return_v;
        }


        static System.Collections.Generic.Dictionary<string, System.Type>
        f_1272_29219_29249()
        {
            var return_v = new System.Collections.Generic.Dictionary<string, System.Type>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 29219, 29249);
            return return_v;
        }


        object
        f_1272_52053_52065()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 52053, 52065);
            return return_v;
        }


        int
        f_1272_68603_68617(System.Management.Automation.PSLocalEventManager
        this_param, bool
        disposing)
        {
            this_param.Dispose(disposing);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 68603, 68617);
            return 0;
        }

    }
    internal class PSRemoteEventManager : PSEventManager
    {
        private string _computerName;

        private Guid _runspaceId;

        internal PSRemoteEventManager(string computerName, Guid runspaceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1272, 70346, 70517);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 69920, 69933);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 70438, 70467);

                _computerName = computerName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 70481, 70506);

                _runspaceId = runspaceId;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1272, 70346, 70517);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 70346, 70517);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 70346, 70517);
            }
        }

        public override List<PSEventSubscriber> Subscribers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 70701, 70831);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 70737, 70816);

                    throw f_1272_70743_70815(f_1272_70769_70814());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 70701, 70831);

                    string
                    f_1272_70769_70814()
                    {
                        var return_v = EventingResources.RemoteOperationNotSupported;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 70769, 70814);
                        return return_v;
                    }


                    System.NotSupportedException
                    f_1272_70743_70815(string
                    message)
                    {
                        var return_v = new System.NotSupportedException(message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 70743, 70815);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 70625, 70842);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 70625, 70842);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override PSEventArgs CreateEvent(string sourceIdentifier, object sender, object[] args, PSObject extraData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 71429, 71770);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 71656, 71759);

                return f_1272_71663_71758(null, _runspaceId, f_1272_71698_71714(this), sourceIdentifier, sender, args, extraData);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 71429, 71770);

                int
                f_1272_71698_71714(System.Management.Automation.PSRemoteEventManager
                this_param)
                {
                    var return_v = this_param.GetNextEventId();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 71698, 71714);
                    return return_v;
                }


                System.Management.Automation.PSEventArgs
                f_1272_71663_71758(string
                computerName, System.Guid
                runspaceId, int
                eventIdentifier, string
                sourceIdentifier, object
                sender, object[]
                originalArgs, System.Management.Automation.PSObject
                additionalData)
                {
                    var return_v = new System.Management.Automation.PSEventArgs(computerName, runspaceId, eventIdentifier, sourceIdentifier, sender, originalArgs, additionalData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 71663, 71758);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 71429, 71770);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 71429, 71770);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void AddForwardedEvent(PSEventArgs forwardedEvent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 71895, 72749);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 71988, 72038);

                forwardedEvent.EventIdentifier = f_1272_72021_72037(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 72052, 72088);

                forwardedEvent.ForwardEvent = false;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 72450, 72683) || true) && (f_1272_72454_72481(forwardedEvent) == null || (DynAbs.Tracing.TraceSender.Expression_False(1272, 72454, 72532) || f_1272_72493_72527(f_1272_72493_72520(forwardedEvent)) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 72450, 72683);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 72566, 72610);

                    forwardedEvent.ComputerName = _computerName;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 72628, 72668);

                    forwardedEvent.RunspaceId = _runspaceId;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 72450, 72683);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 72699, 72738);

                f_1272_72699_72737(this, forwardedEvent, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 71895, 72749);

                int
                f_1272_72021_72037(System.Management.Automation.PSRemoteEventManager
                this_param)
                {
                    var return_v = this_param.GetNextEventId();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 72021, 72037);
                    return return_v;
                }


                string
                f_1272_72454_72481(System.Management.Automation.PSEventArgs
                this_param)
                {
                    var return_v = this_param.ComputerName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 72454, 72481);
                    return return_v;
                }


                string
                f_1272_72493_72520(System.Management.Automation.PSEventArgs
                this_param)
                {
                    var return_v = this_param.ComputerName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 72493, 72520);
                    return return_v;
                }


                int
                f_1272_72493_72527(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 72493, 72527);
                    return return_v;
                }


                int
                f_1272_72699_72737(System.Management.Automation.PSRemoteEventManager
                this_param, System.Management.Automation.PSEventArgs
                newEvent, bool
                processInCurrentThread)
                {
                    this_param.ProcessNewEvent(newEvent, processInCurrentThread);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 72699, 72737);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 71895, 72749);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 71895, 72749);
            }
        }

        protected override void ProcessNewEvent(PSEventArgs newEvent, bool processInCurrentThread)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 72913, 73096);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 73028, 73085);

                f_1272_73028_73084(this, newEvent, processInCurrentThread, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 72913, 73096);

                int
                f_1272_73028_73084(System.Management.Automation.PSRemoteEventManager
                this_param, System.Management.Automation.PSEventArgs
                newEvent, bool
                processInCurrentThread, bool
                waitForCompletionInCurrentThread)
                {
                    this_param.ProcessNewEvent(newEvent, processInCurrentThread, waitForCompletionInCurrentThread);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 73028, 73084);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 72913, 73096);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 72913, 73096);
            }
        }

        protected internal override void ProcessNewEvent(PSEventArgs newEvent,
                    bool processInCurrentThread, bool waitForCompletionInCurrentThread)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 73260, 73747);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 73442, 73465);
                lock (f_1272_73442_73465(f_1272_73442_73456()))
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 73499, 73721) || true) && (f_1272_73503_73524(newEvent))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 73499, 73721);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 73566, 73591);

                        f_1272_73566_73590(this, newEvent);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 73499, 73721);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 73499, 73721);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 73673, 73702);

                        f_1272_73673_73701(f_1272_73673_73687(), newEvent);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 73499, 73721);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 73260, 73747);

                System.Management.Automation.PSEventArgsCollection
                f_1272_73442_73456()
                {
                    var return_v = ReceivedEvents;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 73442, 73456);
                    return return_v;
                }


                object
                f_1272_73442_73465(System.Management.Automation.PSEventArgsCollection
                this_param)
                {
                    var return_v = this_param.SyncRoot;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 73442, 73465);
                    return return_v;
                }


                bool
                f_1272_73503_73524(System.Management.Automation.PSEventArgs
                this_param)
                {
                    var return_v = this_param.ForwardEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 73503, 73524);
                    return return_v;
                }


                int
                f_1272_73566_73590(System.Management.Automation.PSRemoteEventManager
                this_param, System.Management.Automation.PSEventArgs
                e)
                {
                    this_param.OnForwardEvent(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 73566, 73590);
                    return 0;
                }


                System.Management.Automation.PSEventArgsCollection
                f_1272_73673_73687()
                {
                    var return_v = ReceivedEvents;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 73673, 73687);
                    return return_v;
                }


                int
                f_1272_73673_73701(System.Management.Automation.PSEventArgsCollection
                this_param, System.Management.Automation.PSEventArgs
                eventToAdd)
                {
                    this_param.Add(eventToAdd);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 73673, 73701);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 73260, 73747);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 73260, 73747);
            }
        }

        public override IEnumerable<PSEventSubscriber> GetEventSubscribers(string sourceIdentifier)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 74016, 74222);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 74132, 74211);

                throw f_1272_74138_74210(f_1272_74164_74209());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 74016, 74222);

                string
                f_1272_74164_74209()
                {
                    var return_v = EventingResources.RemoteOperationNotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 74164, 74209);
                    return return_v;
                }


                System.NotSupportedException
                f_1272_74138_74210(string
                message)
                {
                    var return_v = new System.NotSupportedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 74138, 74210);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 74016, 74222);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 74016, 74222);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly")]
        public override PSEventSubscriber SubscribeEvent(object source, string eventName, string sourceIdentifier, PSObject data, ScriptBlock action, bool supportEvent, bool forwardEvent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 75237, 75626);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 75536, 75615);

                throw f_1272_75542_75614(f_1272_75568_75613());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 75237, 75626);

                string
                f_1272_75568_75613()
                {
                    var return_v = EventingResources.RemoteOperationNotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 75568, 75613);
                    return return_v;
                }


                System.NotSupportedException
                f_1272_75542_75614(string
                message)
                {
                    var return_v = new System.NotSupportedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 75542, 75614);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 75237, 75626);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 75237, 75626);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly")]
        public override PSEventSubscriber SubscribeEvent(object source, string eventName, string sourceIdentifier, PSObject data, ScriptBlock action, bool supportEvent, bool forwardEvent, int maxTriggerCount)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 76954, 77364);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 77274, 77353);

                throw f_1272_77280_77352(f_1272_77306_77351());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 76954, 77364);

                string
                f_1272_77306_77351()
                {
                    var return_v = EventingResources.RemoteOperationNotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 77306, 77351);
                    return return_v;
                }


                System.NotSupportedException
                f_1272_77280_77352(string
                message)
                {
                    var return_v = new System.NotSupportedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 77280, 77352);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 76954, 77364);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 76954, 77364);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly")]
        public override PSEventSubscriber SubscribeEvent(object source, string eventName, string sourceIdentifier, PSObject data, PSEventReceivedEventHandler handlerDelegate, bool supportEvent, bool forwardEvent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 78388, 78802);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 78712, 78791);

                throw f_1272_78718_78790(f_1272_78744_78789());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 78388, 78802);

                string
                f_1272_78744_78789()
                {
                    var return_v = EventingResources.RemoteOperationNotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 78744, 78789);
                    return return_v;
                }


                System.NotSupportedException
                f_1272_78718_78790(string
                message)
                {
                    var return_v = new System.NotSupportedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 78718, 78790);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 78388, 78802);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 78388, 78802);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly")]
        public override PSEventSubscriber SubscribeEvent(object source, string eventName, string sourceIdentifier, PSObject data, PSEventReceivedEventHandler handlerDelegate, bool supportEvent, bool forwardEvent, int maxTriggerCount)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 80139, 80574);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 80484, 80563);

                throw f_1272_80490_80562(f_1272_80516_80561());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 80139, 80574);

                string
                f_1272_80516_80561()
                {
                    var return_v = EventingResources.RemoteOperationNotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 80516, 80561);
                    return return_v;
                }


                System.NotSupportedException
                f_1272_80490_80562(string
                message)
                {
                    var return_v = new System.NotSupportedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 80490, 80562);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 80139, 80574);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 80139, 80574);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void UnsubscribeEvent(PSEventSubscriber subscriber)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 80815, 80997);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 80907, 80986);

                throw f_1272_80913_80985(f_1272_80939_80984());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 80815, 80997);

                string
                f_1272_80939_80984()
                {
                    var return_v = EventingResources.RemoteOperationNotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 80939, 80984);
                    return return_v;
                }


                System.NotSupportedException
                f_1272_80913_80985(string
                message)
                {
                    var return_v = new System.NotSupportedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 80913, 80985);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 80815, 80997);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 80815, 80997);
            }
        }

        /// <summary>
        /// This event is raised by the event manager to forward events.
        /// </summary>
        internal override event EventHandler<PSEventArgs>
ForwardEvent
;

        protected virtual void OnForwardEvent(PSEventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 81296, 81519);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 81373, 81417);

                EventHandler<PSEventArgs>
                eh = ForwardEvent
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 81433, 81508) || true) && (eh != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 81433, 81508);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 81481, 81493);

                    f_1272_81481_81492(eh, this, e);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 81433, 81508);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 81296, 81519);

                int
                f_1272_81481_81492(System.EventHandler<System.Management.Automation.PSEventArgs>
                this_param, System.Management.Automation.PSRemoteEventManager
                sender, System.Management.Automation.PSEventArgs
                e)
                {
                    this_param.Invoke((object)sender, e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 81481, 81492);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 81296, 81519);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 81296, 81519);
            }
        }

        static PSRemoteEventManager()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1272, 69762, 81526);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1272, 69762, 81526);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 69762, 81526);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1272, 69762, 81526);
    }
    public sealed class PSEngineEvent
    {
        private PSEngineEvent()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1272, 81908, 81935);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1272, 81908, 81935);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 81908, 81935);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 81908, 81935);
            }
        }

        public const string
        Exiting = "PowerShell.Exiting"
        ;

        public const string
        OnIdle = "PowerShell.OnIdle"
        ;

        internal const string
        OnScriptBlockInvoke = "PowerShell.OnScriptBlockInvoke"
        ;

        internal const string
        GetCommandInfoParameterMetadata = "PowerShell.GetCommandInfoParameterMetadata"
        ;

        internal static readonly HashSet<string> EngineEvents;

        static PSEngineEvent()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1272, 81858, 82942);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 82073, 82103);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 82237, 82265);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 82398, 82452);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 82585, 82663);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 82825, 82934);
            EngineEvents = new HashSet<string>(f_1272_82860_82892()) { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => Exiting, 1272, 82840, 82934), OnIdle, OnScriptBlockInvoke };
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1272, 81858, 82942);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 81858, 82942);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1272, 81858, 82942);

        static System.StringComparer
        f_1272_82860_82892()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 82860, 82892);
            return return_v;
        }

    }
    public class PSEventSubscriber : IEquatable<PSEventSubscriber>
    {
        internal PSEventSubscriber(ExecutionContext context, int id, object source,
                    string eventName, string sourceIdentifier, bool supportEvent, bool forwardEvent, int maxTriggerCount)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1272, 83309, 84187);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 86091, 86099);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 87047, 87086);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 87211, 87246);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 87377, 87409);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 87540, 87579);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 87695, 87728);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 87846, 87913);
                this.HandlerDelegate = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 88043, 88076);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 88234, 88267);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 88416, 88474);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 88593, 88643);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 89017, 89065);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 89361, 89413);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 89545, 89592);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 83524, 83543);

                _context = context;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 83559, 83579);

                SubscriptionId = id;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 83593, 83615);

                SourceObject = source;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 83629, 83651);

                EventName = eventName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 83665, 83701);

                SourceIdentifier = sourceIdentifier;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 83715, 83743);

                SupportEvent = supportEvent;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 83757, 83785);

                ForwardEvent = forwardEvent;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 83801, 83829);

                IsBeingUnsubscribed = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 83843, 83873);

                RemainingActionsToProcess = 0;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 83889, 84176) || true) && (maxTriggerCount <= 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 83889, 84176);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 83947, 83970);

                    AutoUnregister = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 83988, 84015);

                    RemainingTriggerCount = -1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 83889, 84176);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 83889, 84176);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 84081, 84103);

                    AutoUnregister = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 84121, 84161);

                    RemainingTriggerCount = maxTriggerCount;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 83889, 84176);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1272, 83309, 84187);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 83309, 84187);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 83309, 84187);
            }
        }

        internal PSEventSubscriber(ExecutionContext context, int id, object source,
                    string eventName, string sourceIdentifier, ScriptBlock action, bool supportEvent, bool forwardEvent, int maxTriggerCount) : this(f_1272_84600_84607_C(context), id, source, eventName, sourceIdentifier, supportEvent, forwardEvent, maxTriggerCount)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1272, 84369, 85000);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 84774, 84989) || true) && (action != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 84774, 84989);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 84826, 84881);

                    ScriptBlock
                    newAction = f_1272_84850_84880(this, action)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 84899, 84974);

                    Action = f_1272_84908_84973(f_1272_84923_84937(context), this, newAction, sourceIdentifier);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 84774, 84989);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1272, 84369, 85000);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 84369, 85000);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 84369, 85000);
            }
        }

        internal void RegisterJob()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 85012, 85452);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 85157, 85441) || true) && (f_1272_85161_85174_M(!SupportEvent))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 85157, 85441);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 85208, 85426) || true) && (f_1272_85212_85223(this) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 85208, 85426);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 85273, 85359);

                        JobRepository
                        jobRepository = f_1272_85303_85358(((LocalRunspace)f_1272_85319_85343(_context)))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 85381, 85407);

                        f_1272_85381_85406(jobRepository, f_1272_85399_85405());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 85208, 85426);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 85157, 85441);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 85012, 85452);

                bool
                f_1272_85161_85174_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 85161, 85174);
                    return return_v;
                }


                System.Management.Automation.PSEventJob
                f_1272_85212_85223(System.Management.Automation.PSEventSubscriber
                this_param)
                {
                    var return_v = this_param.Action;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 85212, 85223);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1272_85319_85343(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 85319, 85343);
                    return return_v;
                }


                System.Management.Automation.JobRepository
                f_1272_85303_85358(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.JobRepository;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 85303, 85358);
                    return return_v;
                }


                System.Management.Automation.PSEventJob
                f_1272_85399_85405()
                {
                    var return_v = Action;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 85399, 85405);
                    return return_v;
                }


                int
                f_1272_85381_85406(System.Management.Automation.JobRepository
                this_param, System.Management.Automation.PSEventJob
                item)
                {
                    this_param.Add((System.Management.Automation.Job)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 85381, 85406);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 85012, 85452);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 85012, 85452);
            }
        }

        internal PSEventSubscriber(ExecutionContext context, int id, object source,
                    string eventName, string sourceIdentifier, PSEventReceivedEventHandler handlerDelegate, bool supportEvent, bool forwardEvent, int maxTriggerCount) : this(f_1272_85890_85897_C(context), id, source, eventName, sourceIdentifier, supportEvent, forwardEvent, maxTriggerCount)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1272, 85634, 86054);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 86009, 86043);

                HandlerDelegate = handlerDelegate;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1272, 85634, 86054);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 85634, 86054);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 85634, 86054);
            }
        }

        private ExecutionContext _context;

        private ScriptBlock CreateBoundScriptBlock(ScriptBlock scriptAction)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 86201, 86928);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 86294, 86388);

                ScriptBlock
                newAction = f_1272_86318_86387(f_1272_86318_86334(_context), _context, scriptAction, true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 86494, 86597);

                PSVariable
                errorVariable = f_1272_86521_86596("script:Error", f_1272_86552_86567(), ScopedItemOptions.Constant)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 86611, 86678);

                SessionStateInternal
                sessionState = f_1272_86647_86677(newAction)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 86692, 86760);

                SessionStateScope
                scriptScope = f_1272_86724_86759(sessionState, "script")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 86774, 86884);

                f_1272_86774_86883(scriptScope, f_1272_86798_86816(errorVariable), errorVariable, false, true, sessionState, CommandOrigin.Internal);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 86900, 86917);

                return newAction;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 86201, 86928);

                System.Management.Automation.ModuleIntrinsics
                f_1272_86318_86334(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Modules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 86318, 86334);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1272_86318_86387(System.Management.Automation.ModuleIntrinsics
                this_param, System.Management.Automation.ExecutionContext
                context, System.Management.Automation.ScriptBlock
                sb, bool
                linkToGlobal)
                {
                    var return_v = this_param.CreateBoundScriptBlock(context, sb, linkToGlobal);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 86318, 86387);
                    return return_v;
                }


                System.Collections.ArrayList
                f_1272_86552_86567()
                {
                    var return_v = new System.Collections.ArrayList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 86552, 86567);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1272_86521_86596(string
                name, System.Collections.ArrayList
                value, System.Management.Automation.ScopedItemOptions
                options)
                {
                    var return_v = new System.Management.Automation.PSVariable(name, (object)value, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 86521, 86596);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1272_86647_86677(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.SessionStateInternal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 86647, 86677);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1272_86724_86759(System.Management.Automation.SessionStateInternal
                this_param, string
                scopeID)
                {
                    var return_v = this_param.GetScopeByID(scopeID);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 86724, 86759);
                    return return_v;
                }


                string
                f_1272_86798_86816(System.Management.Automation.PSVariable
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 86798, 86816);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1272_86774_86883(System.Management.Automation.SessionStateScope
                this_param, string
                name, System.Management.Automation.PSVariable
                value, bool
                asValue, bool
                force, System.Management.Automation.SessionStateInternal
                sessionState, System.Management.Automation.CommandOrigin
                origin)
                {
                    var return_v = this_param.SetVariable(name, (object)value, asValue, force, sessionState, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 86774, 86883);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 86201, 86928);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 86201, 86928);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int SubscriptionId { get; set; }

        public object SourceObject { get; }

        public string EventName { get; }

        public string SourceIdentifier { get; }

        public PSEventJob Action { get; }

        public PSEventReceivedEventHandler HandlerDelegate { get; }

        public bool SupportEvent { get; }

        public bool ForwardEvent { get; }

        internal bool ShouldProcessInExecutionThread { get; set; }

        internal bool AutoUnregister { get; private set; }

        internal int RemainingTriggerCount { get; set; }

        internal int RemainingActionsToProcess { get; set; }

        internal bool IsBeingUnsubscribed { get; set; }

        /// <summary>
        /// The event generated when this event subscriber is unregistered.
        /// </summary>
        public event PSEventUnsubscribedEventHandler
Unsubscribed
;

        public bool Equals(PSEventSubscriber other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 90097, 90332);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 90165, 90244) || true) && (other == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 90165, 90244);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 90216, 90229);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 90165, 90244);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 90260, 90321);

                return (f_1272_90268_90319(f_1272_90282_90296(), f_1272_90298_90318(other)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 90097, 90332);

                int
                f_1272_90282_90296()
                {
                    var return_v = SubscriptionId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 90282, 90296);
                    return return_v;
                }


                int
                f_1272_90298_90318(System.Management.Automation.PSEventSubscriber
                this_param)
                {
                    var return_v = this_param.SubscriptionId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 90298, 90318);
                    return return_v;
                }


                bool
                f_1272_90268_90319(int
                objA, int
                objB)
                {
                    var return_v = string.Equals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 90268, 90319);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 90097, 90332);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 90097, 90332);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 90471, 90562);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 90529, 90551);

                return f_1272_90536_90550();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 90471, 90562);

                int
                f_1272_90536_90550()
                {
                    var return_v = SubscriptionId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 90536, 90550);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 90471, 90562);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 90471, 90562);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void OnPSEventUnsubscribed(object sender, PSEventUnsubscribedEventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 90594, 90809);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 90701, 90798) || true) && (Unsubscribed != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 90701, 90798);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 90759, 90783);

                    f_1272_90759_90782(Unsubscribed, sender, e);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 90701, 90798);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 90594, 90809);

                int
                f_1272_90759_90782(System.Management.Automation.PSEventUnsubscribedEventHandler
                this_param, object
                sender, System.Management.Automation.PSEventUnsubscribedEventArgs
                e)
                {
                    this_param.Invoke(sender, e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 90759, 90782);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 90594, 90809);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 90594, 90809);
            }
        }

        static PSEventSubscriber()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1272, 83035, 90816);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1272, 83035, 90816);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 83035, 90816);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1272, 83035, 90816);

        System.Management.Automation.ScriptBlock
        f_1272_84850_84880(System.Management.Automation.PSEventSubscriber
        this_param, System.Management.Automation.ScriptBlock
        scriptAction)
        {
            var return_v = this_param.CreateBoundScriptBlock(scriptAction);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 84850, 84880);
            return return_v;
        }


        System.Management.Automation.PSLocalEventManager
        f_1272_84923_84937(System.Management.Automation.ExecutionContext
        this_param)
        {
            var return_v = this_param.Events;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 84923, 84937);
            return return_v;
        }


        System.Management.Automation.PSEventJob
        f_1272_84908_84973(System.Management.Automation.PSLocalEventManager
        eventManager, System.Management.Automation.PSEventSubscriber
        subscriber, System.Management.Automation.ScriptBlock
        action, string
        name)
        {
            var return_v = new System.Management.Automation.PSEventJob((System.Management.Automation.PSEventManager)eventManager, subscriber, action, name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 84908, 84973);
            return return_v;
        }


        static System.Management.Automation.ExecutionContext
        f_1272_84600_84607_C(System.Management.Automation.ExecutionContext
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1272, 84369, 85000);
            return return_v;
        }


        static System.Management.Automation.ExecutionContext
        f_1272_85890_85897_C(System.Management.Automation.ExecutionContext
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1272, 85634, 86054);
            return return_v;
        }

    }
    [SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")]
    public class PSEventHandler
    {
        public PSEventHandler()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1272, 91321, 91366);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 92631, 92643);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 92849, 92855);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 93100, 93123);
                this.sourceIdentifier = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 93359, 93375);
                this.extraData = null;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1272, 91321, 91366);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 91321, 91366);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 91321, 91366);
            }
        }

        public PSEventHandler(PSEventManager eventManager, object sender, string sourceIdentifier, PSObject extraData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1272, 92087, 92397);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 92631, 92643);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 92849, 92855);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 93100, 93123);
                this.sourceIdentifier = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 93359, 93375);
                this.extraData = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 92222, 92255);

                this.eventManager = eventManager;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 92269, 92290);

                this.sender = sender;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 92304, 92345);

                this.sourceIdentifier = sourceIdentifier;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 92359, 92386);

                this.extraData = extraData;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1272, 92087, 92397);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 92087, 92397);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 92087, 92397);
            }
        }

        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected PSEventManager eventManager;

        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected object sender;

        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected string sourceIdentifier;

        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected PSObject extraData;

        static PSEventHandler()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1272, 91072, 93383);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1272, 91072, 93383);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 91072, 93383);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1272, 91072, 93383);
    }
    public class ForwardedEventArgs : EventArgs
    {
        internal ForwardedEventArgs(PSObject serializedRemoteEventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1272, 93606, 93759);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 93901, 93951);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 93694, 93748);

                SerializedRemoteEventArgs = serializedRemoteEventArgs;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1272, 93606, 93759);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 93606, 93759);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 93606, 93759);
            }
        }

        public PSObject SerializedRemoteEventArgs { get; }

        internal static bool IsRemoteSourceEventArgs(object argument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1272, 93963, 94138);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 94049, 94127);

                return f_1272_94056_94126(argument, typeof(EventArgs));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1272, 93963, 94138);

                bool
                f_1272_94056_94126(object
                o, System.Type
                type)
                {
                    var return_v = Deserializer.IsDeserializedInstanceOfType(o, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 94056, 94126);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 93963, 94138);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 93963, 94138);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ForwardedEventArgs()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1272, 93546, 94145);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1272, 93546, 94145);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 93546, 94145);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1272, 93546, 94145);
    }
    internal class PSEventArgs<T> : EventArgs
    {
        internal T Args;

        public PSEventArgs(T args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1272, 94656, 94730);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 94503, 94507);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 94707, 94719);

                Args = args;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1272, 94656, 94730);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 94656, 94730);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 94656, 94730);
            }
        }

        static PSEventArgs()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1272, 94357, 94737);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1272, 94357, 94737);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 94357, 94737);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1272, 94357, 94737);
    }
    public class PSEventArgs : EventArgs
    {
        internal PSEventArgs(string computerName, Guid runspaceId, int eventIdentifier, string sourceIdentifier, object sender, object[] originalArgs, PSObject additionalData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1272, 95831, 97126);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 97341, 97390);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 97780, 97829);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 97944, 97973);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 98142, 98183);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 98321, 98450);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 98584, 98623);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 99023, 99059);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 99217, 99257);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 99421, 99479);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 96086, 96744) || true) && (originalArgs != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 96086, 96744);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 96144, 96729);
                        foreach (object argument in f_1272_96172_96184_I(originalArgs))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 96144, 96729);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 96226, 96276);

                            EventArgs
                            sourceEventArgs = argument as EventArgs
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 96298, 96464) || true) && (sourceEventArgs != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 96298, 96464);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 96375, 96409);

                                SourceEventArgs = sourceEventArgs;
                                DynAbs.Tracing.TraceSender.TraceBreak(1272, 96435, 96441);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 96298, 96464);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 96488, 96710) || true) && (f_1272_96492_96544(argument))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 96488, 96710);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 96594, 96655);

                                SourceEventArgs = f_1272_96612_96654((PSObject)argument);
                                DynAbs.Tracing.TraceSender.TraceBreak(1272, 96681, 96687);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 96488, 96710);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 96144, 96729);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1272, 1, 586);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1272, 1, 586);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 96086, 96744);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 96760, 96788);

                ComputerName = computerName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 96802, 96826);

                RunspaceId = runspaceId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 96840, 96874);

                EventIdentifier = eventIdentifier;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 96888, 96904);

                Sender = sender;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 96918, 96944);

                SourceArgs = originalArgs;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 96958, 96994);

                SourceIdentifier = sourceIdentifier;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 97008, 97037);

                TimeGenerated = DateTime.Now;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 97051, 97080);

                MessageData = additionalData;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 97094, 97115);

                ForwardEvent = false;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1272, 95831, 97126);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 95831, 97126);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 95831, 97126);
            }
        }

        public string ComputerName { get; internal set; }

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Runspace")]
        public Guid RunspaceId { get; internal set; }

        public int EventIdentifier { get; internal set; }

        public object Sender { get; }

        public EventArgs SourceEventArgs { get; }

        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public object[] SourceArgs { get; }

        public string SourceIdentifier { get; }

        public DateTime TimeGenerated
        {            // internal setter using during deserialization
            get; internal set;
        }

        public PSObject MessageData { get; }

        internal bool ForwardEvent { get; set; }

        internal ManualResetEventSlim EventProcessed { get; set; }

        bool
        f_1272_96492_96544(object
        argument)
        {
            var return_v = ForwardedEventArgs.IsRemoteSourceEventArgs(argument);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 96492, 96544);
            return return_v;
        }


        System.Management.Automation.ForwardedEventArgs
        f_1272_96612_96654(object
        serializedRemoteEventArgs)
        {
            var return_v = new System.Management.Automation.ForwardedEventArgs((System.Management.Automation.PSObject)serializedRemoteEventArgs);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 96612, 96654);
            return return_v;
        }


        object[]
        f_1272_96172_96184_I(object[]
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 96172, 96184);
            return return_v;
        }

    }

    /// <summary>
    /// The delegate that handles notifications of new events
    /// added to the collection.
    /// </summary>
    public delegate void PSEventReceivedEventHandler(object sender, PSEventArgs e);
    public class PSEventUnsubscribedEventArgs : EventArgs
    {
        internal PSEventUnsubscribedEventArgs(PSEventSubscriber eventSubscriber)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1272, 100143, 100285);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 100398, 100461);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 100240, 100274);

                EventSubscriber = eventSubscriber;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1272, 100143, 100285);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 100143, 100285);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 100143, 100285);
            }
        }

        public PSEventSubscriber EventSubscriber { get; internal set; }

        static PSEventUnsubscribedEventArgs()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1272, 99830, 100468);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1272, 99830, 100468);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 99830, 100468);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1272, 99830, 100468);
    }

    /// <summary>
    /// The delegate that handles notifications of the event being unsubscribed.
    /// </summary>
    public delegate void PSEventUnsubscribedEventHandler(object sender, PSEventUnsubscribedEventArgs e);
    public class PSEventArgsCollection : IEnumerable<PSEventArgs>
    {        /// <summary>
             /// The event generated when a new event is received.
             /// </summary>
        public event PSEventReceivedEventHandler
PSEventReceived
;

        private List<PSEventArgs> _eventCollection;

        internal void Add(PSEventArgs eventToAdd)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 101506, 101814);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 101572, 101689) || true) && (eventToAdd == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 101572, 101689);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 101628, 101674);

                    throw f_1272_101634_101673("eventToAdd");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 101572, 101689);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 101705, 101738);

                f_1272_101705_101737(
                            _eventCollection, eventToAdd);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 101754, 101803);

                f_1272_101754_101802(this, f_1272_101772_101789(eventToAdd), eventToAdd);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 101506, 101814);

                System.ArgumentNullException
                f_1272_101634_101673(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 101634, 101673);
                    return return_v;
                }


                int
                f_1272_101705_101737(System.Collections.Generic.List<System.Management.Automation.PSEventArgs>
                this_param, System.Management.Automation.PSEventArgs
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 101705, 101737);
                    return 0;
                }


                object
                f_1272_101772_101789(System.Management.Automation.PSEventArgs
                this_param)
                {
                    var return_v = this_param.Sender;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 101772, 101789);
                    return return_v;
                }


                int
                f_1272_101754_101802(System.Management.Automation.PSEventArgsCollection
                this_param, object
                sender, System.Management.Automation.PSEventArgs
                e)
                {
                    this_param.OnPSEventReceived(sender, e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 101754, 101802);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 101506, 101814);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 101506, 101814);
            }
        }

        public int Count
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 101984, 102065);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 102020, 102050);

                    return f_1272_102027_102049(_eventCollection);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 101984, 102065);

                    int
                    f_1272_102027_102049(System.Collections.Generic.List<System.Management.Automation.PSEventArgs>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 102027, 102049);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 101943, 102076);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 101943, 102076);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public void RemoveAt(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 102205, 102305);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 102261, 102294);

                f_1272_102261_102293(_eventCollection, index);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 102205, 102305);

                int
                f_1272_102261_102293(System.Collections.Generic.List<System.Management.Automation.PSEventArgs>
                this_param, int
                index)
                {
                    this_param.RemoveAt(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 102261, 102293);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 102205, 102305);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 102205, 102305);
            }
        }

        /// <summary>
        /// Gets an item at a specific index from the collection.
        /// </summary>
        public PSEventArgs this[int index]
        {

            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 102490, 102572);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 102526, 102557);

                    return f_1272_102533_102556(_eventCollection, index);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 102490, 102572);

                    System.Management.Automation.PSEventArgs
                    f_1272_102533_102556(System.Collections.Generic.List<System.Management.Automation.PSEventArgs>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 102533, 102556);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 102490, 102572);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 102490, 102572);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private void OnPSEventReceived(object sender, PSEventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 102595, 102861);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 102680, 102739);

                PSEventReceivedEventHandler
                eventHandler = PSEventReceived
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 102753, 102850) || true) && (eventHandler != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 102753, 102850);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 102811, 102835);

                    f_1272_102811_102834(eventHandler, sender, e);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 102753, 102850);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 102595, 102861);

                int
                f_1272_102811_102834(System.Management.Automation.PSEventReceivedEventHandler
                this_param, object
                sender, System.Management.Automation.PSEventArgs
                e)
                {
                    this_param.Invoke(sender, e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 102811, 102834);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 102595, 102861);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 102595, 102861);
            }
        }

        public IEnumerator<PSEventArgs> GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 102972, 103095);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 103044, 103084);

                return f_1272_103051_103083(_eventCollection);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 102972, 103095);

                System.Collections.Generic.List<System.Management.Automation.PSEventArgs>.Enumerator
                f_1272_103051_103083(System.Collections.Generic.List<System.Management.Automation.PSEventArgs>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 103051, 103083);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 102972, 103095);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 102972, 103095);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 103206, 103359);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 103308, 103348);

                return f_1272_103315_103347(_eventCollection);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 103206, 103359);

                System.Collections.Generic.List<System.Management.Automation.PSEventArgs>.Enumerator
                f_1272_103315_103347(System.Collections.Generic.List<System.Management.Automation.PSEventArgs>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 103315, 103347);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 103206, 103359);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 103206, 103359);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object SyncRoot { get; }

        public PSEventArgsCollection()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1272, 100842, 103535);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 101123, 101165);
            this._eventCollection = f_1272_101142_101165();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 103481, 103528);
            this.SyncRoot = f_1272_103515_103527();
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1272, 100842, 103535);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 100842, 103535);
        }


        static PSEventArgsCollection()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1272, 100842, 103535);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1272, 100842, 103535);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 100842, 103535);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1272, 100842, 103535);

        System.Collections.Generic.List<System.Management.Automation.PSEventArgs>
        f_1272_101142_101165()
        {
            var return_v = new System.Collections.Generic.List<System.Management.Automation.PSEventArgs>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 101142, 101165);
            return return_v;
        }


        object
        f_1272_103515_103527()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 103515, 103527);
            return return_v;
        }

    }
    internal class EventAction
    {
        public EventAction(PSEventSubscriber sender, PSEventArgs args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1272, 103831, 103971);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 104095, 104135);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 104266, 104298);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 103918, 103934);

                Sender = sender;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 103948, 103960);

                Args = args;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1272, 103831, 103971);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 103831, 103971);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 103831, 103971);
            }
        }

        public PSEventSubscriber Sender { get; }

        public PSEventArgs Args { get; }

        static EventAction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1272, 103788, 104305);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1272, 103788, 104305);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 103788, 104305);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1272, 103788, 104305);
    }
    public class PSEventJob : Job
    {
        public PSEventJob(PSEventManager eventManager, PSEventSubscriber subscriber, ScriptBlock action, string name) : base(f_1272_105148_105189_C((DynAbs.Tracing.TraceSender.Conditional_F1(1272, 105148, 105162) || ((action == null && DynAbs.Tracing.TraceSender.Conditional_F2(1272, 105165, 105169)) || DynAbs.Tracing.TraceSender.Conditional_F3(1272, 105172, 105189))) ? null : f_1272_105172_105189(action)), name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1272, 105018, 105586);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 105621, 105641);
                this._eventManager = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 105678, 105696);
                this._subscriber = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 105719, 105741);
                this._highestErrorIndex = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 106261, 106314);
                this.StatusMessage = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 106704, 106721);
                this._moreData = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 107076, 107117);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 105221, 105312) || true) && (eventManager == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 105221, 105312);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 105264, 105312);

                    throw f_1272_105270_105311("eventManager");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 105221, 105312);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 105326, 105413) || true) && (subscriber == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 105326, 105413);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 105367, 105413);

                    throw f_1272_105373_105412("subscriber");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 105326, 105413);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 105429, 105458);

                UsesResultsCollection = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 105472, 105493);

                ScriptBlock = action;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 105507, 105536);

                _eventManager = eventManager;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 105550, 105575);

                _subscriber = subscriber;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1272, 105018, 105586);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 105018, 105586);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 105018, 105586);
            }
        }

        private PSEventManager _eventManager;

        private PSEventSubscriber _subscriber;

        private int _highestErrorIndex;

        public PSModuleInfo Module
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 105914, 105948);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 105920, 105946);

                    return f_1272_105927_105945(f_1272_105927_105938());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 105914, 105948);

                    System.Management.Automation.ScriptBlock
                    f_1272_105927_105938()
                    {
                        var return_v = ScriptBlock;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 105927, 105938);
                        return return_v;
                    }


                    System.Management.Automation.PSModuleInfo
                    f_1272_105927_105945(System.Management.Automation.ScriptBlock
                    this_param)
                    {
                        var return_v = this_param.Module;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 105927, 105945);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 105863, 105959);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 105863, 105959);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override void StopJob()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 106041, 106151);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 106096, 106140);

                f_1272_106096_106139(_eventManager, _subscriber);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 106041, 106151);

                int
                f_1272_106096_106139(System.Management.Automation.PSEventManager
                this_param, System.Management.Automation.PSEventSubscriber
                subscriber)
                {
                    this_param.UnsubscribeEvent(subscriber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 106096, 106139);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 106041, 106151);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 106041, 106151);
            }
        }

        public override string StatusMessage { get; }

        public override bool HasMoreData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 106600, 106668);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 106636, 106653);

                    return _moreData;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 106600, 106668);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 106543, 106679);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 106543, 106679);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool _moreData;

        public override string Location
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 106889, 106952);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 106925, 106937);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 106889, 106952);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 106833, 106963);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 106833, 106963);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal ScriptBlock ScriptBlock { get; }

        internal void Invoke(PSEventSubscriber eventSubscriber, PSEventArgs eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 107432, 109670);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 107535, 107600) || true) && (f_1272_107539_107574(this, f_1272_107555_107573(f_1272_107555_107567())))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 107535, 107600);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 107593, 107600);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 107535, 107600);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 107616, 107646);

                f_1272_107616_107645(this, JobState.Running);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 107710, 107789);

                SessionState
                actionState = f_1272_107737_107788(f_1272_107737_107769(f_1272_107737_107748()))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 107899, 107962);

                f_1272_107899_107961(f_1272_107899_107921(actionState), "eventSubscriber", eventSubscriber);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 108034, 108081);

                f_1272_108034_108080(f_1272_108034_108056(actionState), "event", eventArgs);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 108139, 108194);

                f_1272_108139_108193(f_1272_108139_108161(actionState), "sender", f_1272_108176_108192(eventArgs));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 108262, 108329);

                f_1272_108262_108328(f_1272_108262_108284(actionState), "eventArgs", f_1272_108302_108327(eventArgs));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 108345, 108387);

                List<object>
                results = f_1272_108368_108386()
                ;

                // $args = $psEventArgs.SourceArgs (for PARAM statement)
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 108509, 108545);

                    Pipe
                    outputPipe = f_1272_108527_108544(results)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 108563, 109036);

                    f_1272_108563_109035(f_1272_108563_108574(), useLocalScope: false, errorHandlingBehavior: ScriptBlock.ErrorHandlingBehavior.WriteToExternalErrorPipe, dollarUnder: f_1272_108772_108792(), input: f_1272_108822_108842(), scriptThis: f_1272_108877_108897(), outputPipe: outputPipe, invocationInfo: null, args: f_1272_109014_109034(eventArgs));
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1272, 109065, 109413);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 109183, 109372) || true) && (!(e is PipelineStoppedException))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 109183, 109372);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 109261, 109302);

                        f_1272_109261_109301(this, results, actionState);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 109324, 109353);

                        f_1272_109324_109352(this, JobState.Failed);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 109183, 109372);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 109392, 109398);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1272, 109065, 109413);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 109587, 109628);

                f_1272_109587_109627(this, results, actionState);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 109642, 109659);

                _moreData = true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 107432, 109670);

                System.Management.Automation.JobStateInfo
                f_1272_107555_107567()
                {
                    var return_v = JobStateInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 107555, 107567);
                    return return_v;
                }


                System.Management.Automation.JobState
                f_1272_107555_107573(System.Management.Automation.JobStateInfo
                this_param)
                {
                    var return_v = this_param.State;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 107555, 107573);
                    return return_v;
                }


                bool
                f_1272_107539_107574(System.Management.Automation.PSEventJob
                this_param, System.Management.Automation.JobState
                state)
                {
                    var return_v = this_param.IsFinishedState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 107539, 107574);
                    return return_v;
                }


                int
                f_1272_107616_107645(System.Management.Automation.PSEventJob
                this_param, System.Management.Automation.JobState
                state)
                {
                    this_param.SetJobState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 107616, 107645);
                    return 0;
                }


                System.Management.Automation.ScriptBlock
                f_1272_107737_107748()
                {
                    var return_v = ScriptBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 107737, 107748);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1272_107737_107769(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.SessionStateInternal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 107737, 107769);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1272_107737_107788(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.PublicSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 107737, 107788);
                    return return_v;
                }


                System.Management.Automation.PSVariableIntrinsics
                f_1272_107899_107921(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.PSVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 107899, 107921);
                    return return_v;
                }


                int
                f_1272_107899_107961(System.Management.Automation.PSVariableIntrinsics
                this_param, string
                name, System.Management.Automation.PSEventSubscriber
                value)
                {
                    this_param.Set(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 107899, 107961);
                    return 0;
                }


                System.Management.Automation.PSVariableIntrinsics
                f_1272_108034_108056(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.PSVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 108034, 108056);
                    return return_v;
                }


                int
                f_1272_108034_108080(System.Management.Automation.PSVariableIntrinsics
                this_param, string
                name, System.Management.Automation.PSEventArgs
                value)
                {
                    this_param.Set(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 108034, 108080);
                    return 0;
                }


                System.Management.Automation.PSVariableIntrinsics
                f_1272_108139_108161(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.PSVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 108139, 108161);
                    return return_v;
                }


                object
                f_1272_108176_108192(System.Management.Automation.PSEventArgs
                this_param)
                {
                    var return_v = this_param.Sender;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 108176, 108192);
                    return return_v;
                }


                int
                f_1272_108139_108193(System.Management.Automation.PSVariableIntrinsics
                this_param, string
                name, object
                value)
                {
                    this_param.Set(name, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 108139, 108193);
                    return 0;
                }


                System.Management.Automation.PSVariableIntrinsics
                f_1272_108262_108284(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.PSVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 108262, 108284);
                    return return_v;
                }


                System.EventArgs
                f_1272_108302_108327(System.Management.Automation.PSEventArgs
                this_param)
                {
                    var return_v = this_param.SourceEventArgs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 108302, 108327);
                    return return_v;
                }


                int
                f_1272_108262_108328(System.Management.Automation.PSVariableIntrinsics
                this_param, string
                name, System.EventArgs
                value)
                {
                    this_param.Set(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 108262, 108328);
                    return 0;
                }


                System.Collections.Generic.List<object>
                f_1272_108368_108386()
                {
                    var return_v = new System.Collections.Generic.List<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 108368, 108386);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1272_108527_108544(System.Collections.Generic.List<object>
                resultList)
                {
                    var return_v = new System.Management.Automation.Internal.Pipe(resultList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 108527, 108544);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1272_108563_108574()
                {
                    var return_v = ScriptBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 108563, 108574);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1272_108772_108792()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 108772, 108792);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1272_108822_108842()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 108822, 108842);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1272_108877_108897()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 108877, 108897);
                    return return_v;
                }


                object[]
                f_1272_109014_109034(System.Management.Automation.PSEventArgs
                this_param)
                {
                    var return_v = this_param.SourceArgs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 109014, 109034);
                    return return_v;
                }


                int
                f_1272_108563_109035(System.Management.Automation.ScriptBlock
                this_param, bool
                useLocalScope, System.Management.Automation.ScriptBlock.ErrorHandlingBehavior
                errorHandlingBehavior, System.Management.Automation.PSObject
                dollarUnder, System.Management.Automation.PSObject
                input, System.Management.Automation.PSObject
                scriptThis, System.Management.Automation.Internal.Pipe
                outputPipe, System.Management.Automation.InvocationInfo
                invocationInfo, object[]
                args)
                {
                    this_param.InvokeWithPipe(useLocalScope: useLocalScope, errorHandlingBehavior: errorHandlingBehavior, dollarUnder: (object)dollarUnder, input: (object)input, scriptThis: (object)scriptThis, outputPipe: outputPipe, invocationInfo: invocationInfo, args: args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 108563, 109035);
                    return 0;
                }


                int
                f_1272_109261_109301(System.Management.Automation.PSEventJob
                this_param, System.Collections.Generic.List<object>
                results, System.Management.Automation.SessionState
                actionState)
                {
                    this_param.LogErrorsAndOutput(results, actionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 109261, 109301);
                    return 0;
                }


                int
                f_1272_109324_109352(System.Management.Automation.PSEventJob
                this_param, System.Management.Automation.JobState
                state)
                {
                    this_param.SetJobState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 109324, 109352);
                    return 0;
                }


                int
                f_1272_109587_109627(System.Management.Automation.PSEventJob
                this_param, System.Collections.Generic.List<object>
                results, System.Management.Automation.SessionState
                actionState)
                {
                    this_param.LogErrorsAndOutput(results, actionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 109587, 109627);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 107432, 109670);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 107432, 109670);
            }
        }

        internal void NotifyJobStopped()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 109682, 109812);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 109739, 109769);

                f_1272_109739_109768(this, JobState.Stopped);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 109783, 109801);

                _moreData = false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 109682, 109812);

                int
                f_1272_109739_109768(System.Management.Automation.PSEventJob
                this_param, System.Management.Automation.JobState
                state)
                {
                    this_param.SetJobState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 109739, 109768);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 109682, 109812);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 109682, 109812);
            }
        }

        private void LogErrorsAndOutput(List<object> results, SessionState actionState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1272, 109824, 110674);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 109979, 109984);
                    // Add the output to the job
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 109970, 110086) || true) && (i < f_1272_109990_110003(results))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 110005, 110008)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 109970, 110086))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 109970, 110086);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 110042, 110071);

                        f_1272_110042_110070(this, f_1272_110059_110069(results, i));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1272, 1, 117);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1272, 1, 117);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 110133, 110147);

                f_1272_110133_110146(f_1272_110133_110138());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 110161, 110187);

                int
                currentErrorIndex = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 110201, 110267);

                var
                errors = (ArrayList)f_1272_110225_110266(f_1272_110225_110260(f_1272_110225_110247(actionState), "error"))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 110281, 110298);

                f_1272_110281_110297(errors);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 110323, 110328);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 110314, 110663) || true) && (i < f_1272_110334_110346(errors))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 110348, 110351)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 110314, 110663))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 110314, 110663);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 110385, 110420);

                        var
                        error = (ErrorRecord)f_1272_110410_110419(errors, i)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 110438, 110608) || true) && (currentErrorIndex == _highestErrorIndex)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1272, 110438, 110608);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 110523, 110546);

                            f_1272_110523_110545(this, error);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 110568, 110589);

                            _highestErrorIndex++;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1272, 110438, 110608);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1272, 110628, 110648);

                        currentErrorIndex++;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1272, 1, 350);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1272, 1, 350);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1272, 109824, 110674);

                int
                f_1272_109990_110003(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 109990, 110003);
                    return return_v;
                }


                object
                f_1272_110059_110069(System.Collections.Generic.List<object>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 110059, 110069);
                    return return_v;
                }


                int
                f_1272_110042_110070(System.Management.Automation.PSEventJob
                this_param, object
                outputObject)
                {
                    this_param.WriteObject(outputObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 110042, 110070);
                    return 0;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                f_1272_110133_110138()
                {
                    var return_v = Error;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 110133, 110138);
                    return return_v;
                }


                int
                f_1272_110133_110146(System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 110133, 110146);
                    return 0;
                }


                System.Management.Automation.PSVariableIntrinsics
                f_1272_110225_110247(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.PSVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 110225, 110247);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1272_110225_110260(System.Management.Automation.PSVariableIntrinsics
                this_param, string
                name)
                {
                    var return_v = this_param.Get(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 110225, 110260);
                    return return_v;
                }


                object
                f_1272_110225_110266(System.Management.Automation.PSVariable
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 110225, 110266);
                    return return_v;
                }


                int
                f_1272_110281_110297(System.Collections.ArrayList
                this_param)
                {
                    this_param.Reverse();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 110281, 110297);
                    return 0;
                }


                int
                f_1272_110334_110346(System.Collections.ArrayList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 110334, 110346);
                    return return_v;
                }


                object
                f_1272_110410_110419(System.Collections.ArrayList
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1272, 110410, 110419);
                    return return_v;
                }


                int
                f_1272_110523_110545(System.Management.Automation.PSEventJob
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 110523, 110545);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1272, 109824, 110674);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 109824, 110674);
            }
        }

        static PSEventJob()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1272, 104416, 110681);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1272, 104416, 110681);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1272, 104416, 110681);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1272, 104416, 110681);

        static string
        f_1272_105172_105189(System.Management.Automation.ScriptBlock
        this_param)
        {
            var return_v = this_param.ToString();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 105172, 105189);
            return return_v;
        }


        System.ArgumentNullException
        f_1272_105270_105311(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 105270, 105311);
            return return_v;
        }


        System.ArgumentNullException
        f_1272_105373_105412(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1272, 105373, 105412);
            return return_v;
        }


        static string
        f_1272_105148_105189_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1272, 105018, 105586);
            return return_v;
        }

    }
}
