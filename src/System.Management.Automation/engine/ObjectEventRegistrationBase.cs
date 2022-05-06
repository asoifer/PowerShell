// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Management.Automation;

namespace Microsoft.PowerShell.Commands
{
    public abstract class ObjectEventRegistrationBase : PSCmdlet
    {
        [Parameter(Position = 100)]
        public string SourceIdentifier
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1303, 614, 690);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1303, 650, 675);

                    return _sourceIdentifier;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1303, 614, 690);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1303, 522, 794);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1303, 522, 794);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1303, 706, 783);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1303, 742, 768);

                    _sourceIdentifier = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1303, 706, 783);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1303, 522, 794);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1303, 522, 794);
                }
            }
        }

        private string _sourceIdentifier;

        [Parameter(Position = 101)]
        public ScriptBlock Action
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1303, 1089, 1155);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1303, 1125, 1140);

                    return _action;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1303, 1089, 1155);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1303, 1002, 1249);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1303, 1002, 1249);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1303, 1171, 1238);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1303, 1207, 1223);

                    _action = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1303, 1171, 1238);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1303, 1002, 1249);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1303, 1002, 1249);
                }
            }
        }

        private ScriptBlock _action;

        [Parameter]
        public PSObject MessageData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1303, 1518, 1589);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1303, 1554, 1574);

                    return _messageData;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1303, 1518, 1589);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1303, 1445, 1688);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1303, 1445, 1688);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1303, 1605, 1677);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1303, 1641, 1662);

                    _messageData = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1303, 1605, 1677);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1303, 1445, 1688);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1303, 1445, 1688);
                }
            }
        }

        private PSObject _messageData;

        [Parameter]
        public SwitchParameter SupportEvent
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1303, 2003, 2075);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1303, 2039, 2060);

                    return _supportEvent;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1303, 2003, 2075);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1303, 1922, 2175);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1303, 1922, 2175);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1303, 2091, 2164);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1303, 2127, 2149);

                    _supportEvent = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1303, 2091, 2164);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1303, 1922, 2175);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1303, 1922, 2175);
                }
            }
        }

        private SwitchParameter _supportEvent;

        [Parameter]
        public SwitchParameter Forward
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1303, 2550, 2617);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1303, 2586, 2602);

                    return _forward;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1303, 2550, 2617);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1303, 2474, 2712);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1303, 2474, 2712);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1303, 2633, 2701);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1303, 2669, 2686);

                    _forward = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1303, 2633, 2701);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1303, 2474, 2712);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1303, 2474, 2712);
                }
            }
        }

        private SwitchParameter _forward;

        [Parameter]
        public int MaxTriggerCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1303, 3188, 3263);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1303, 3224, 3248);

                    return _maxTriggerCount;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1303, 3188, 3263);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1303, 3116, 3383);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1303, 3116, 3383);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1303, 3279, 3372);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1303, 3315, 3357);

                    _maxTriggerCount = (DynAbs.Tracing.TraceSender.Conditional_F1(1303, 3334, 3344) || ((value <= 0 && DynAbs.Tracing.TraceSender.Conditional_F2(1303, 3347, 3348)) || DynAbs.Tracing.TraceSender.Conditional_F3(1303, 3351, 3356))) ? 0 : value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1303, 3279, 3372);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1303, 3116, 3383);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1303, 3116, 3383);
                }
            }
        }

        private int _maxTriggerCount;

        protected abstract object GetSourceObject();

        protected abstract string GetSourceObjectEventName();

        protected PSEventSubscriber NewSubscriber
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1303, 4005, 4035);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1303, 4011, 4033);

                    return _newSubscriber;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1303, 4005, 4035);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1303, 3939, 4046);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1303, 3939, 4046);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private PSEventSubscriber _newSubscriber;

        protected override void BeginProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1303, 4188, 4662);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1303, 4254, 4651) || true) && (((bool)_forward) && (DynAbs.Tracing.TraceSender.Expression_True(1303, 4258, 4295) && (_action != null)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1303, 4254, 4651);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1303, 4329, 4636);

                    f_1303_4329_4635(this, f_1303_4373_4634(f_1303_4415_4484(f_1303_4437_4483()), "ACTION_AND_FORWARD_NOT_SUPPORTED", ErrorCategory.InvalidOperation, null));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1303, 4254, 4651);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1303, 4188, 4662);

                string
                f_1303_4437_4483()
                {
                    var return_v = EventingResources.ActionAndForwardNotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1303, 4437, 4483);
                    return return_v;
                }


                System.ArgumentException
                f_1303_4415_4484(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1303, 4415, 4484);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1303_4373_4634(System.ArgumentException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1303, 4373, 4634);
                    return return_v;
                }


                int
                f_1303_4329_4635(Microsoft.PowerShell.Commands.ObjectEventRegistrationBase
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1303, 4329, 4635);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1303, 4188, 4662);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1303, 4188, 4662);
            }
        }

        protected override void EndProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1303, 4772, 7006);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1303, 4836, 4890);

                object
                inputObject = f_1303_4857_4889(f_1303_4871_4888(this))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1303, 4904, 4950);

                string
                eventName = f_1303_4923_4949(this)
                ;

                try
                {

                    if (
                    (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1303, 5002, 6309) || true) && (((inputObject != null) || (DynAbs.Tracing.TraceSender.Expression_False(1303, 5029, 5073) || (eventName != null))) && (DynAbs.Tracing.TraceSender.Expression_True(1303, 5028, 5173) && (f_1303_5100_5172(f_1303_5100_5161(f_1303_5100_5145(f_1303_5100_5106(), _sourceIdentifier))))
                    ))
                                        )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1303, 5002, 6309);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1303, 5307, 5754);

                        ErrorRecord
                        errorRecord = f_1303_5333_5753(f_1303_5375_5612(f_1303_5427_5611(f_1303_5475_5522(), f_1303_5557_5591(), _sourceIdentifier)), "SUBSCRIBER_EXISTS", ErrorCategory.InvalidArgument, inputObject)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1303, 5778, 5802);

                        f_1303_5778_5801(this, errorRecord);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1303, 5002, 6309);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1303, 5002, 6309);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1303, 5884, 6157);

                        _newSubscriber =
                        f_1303_5926_6156(f_1303_5926_5932(), inputObject, eventName, _sourceIdentifier, _messageData, _action, _supportEvent, _forward, _maxTriggerCount);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1303, 6181, 6290) || true) && ((_action != null) && (DynAbs.Tracing.TraceSender.Expression_True(1303, 6185, 6228) && (!(bool)_supportEvent)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1303, 6181, 6290);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1303, 6255, 6290);

                            f_1303_6255_6289(this, f_1303_6267_6288(_newSubscriber));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1303, 6181, 6290);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1303, 5002, 6309);
                    }
                }
                catch (ArgumentException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1303, 6338, 6655);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1303, 6398, 6596);

                    ErrorRecord
                    errorRecord = f_1303_6424_6595(e, "INVALID_REGISTRATION", ErrorCategory.InvalidArgument, inputObject)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1303, 6616, 6640);

                    f_1303_6616_6639(this, errorRecord);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1303, 6338, 6655);
                }
                catch (InvalidOperationException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1303, 6669, 6995);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1303, 6737, 6936);

                    ErrorRecord
                    errorRecord = f_1303_6763_6935(e, "INVALID_REGISTRATION", ErrorCategory.InvalidOperation, inputObject)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1303, 6956, 6980);

                    f_1303_6956_6979(this, errorRecord);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1303, 6669, 6995);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1303, 4772, 7006);

                object
                f_1303_4871_4888(Microsoft.PowerShell.Commands.ObjectEventRegistrationBase
                this_param)
                {
                    var return_v = this_param.GetSourceObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1303, 4871, 4888);
                    return return_v;
                }


                object
                f_1303_4857_4889(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1303, 4857, 4889);
                    return return_v;
                }


                string
                f_1303_4923_4949(Microsoft.PowerShell.Commands.ObjectEventRegistrationBase
                this_param)
                {
                    var return_v = this_param.GetSourceObjectEventName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1303, 4923, 4949);
                    return return_v;
                }


                System.Management.Automation.PSEventManager
                f_1303_5100_5106()
                {
                    var return_v = Events;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1303, 5100, 5106);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSEventSubscriber>
                f_1303_5100_5145(System.Management.Automation.PSEventManager
                this_param, string
                sourceIdentifier)
                {
                    var return_v = this_param.GetEventSubscribers(sourceIdentifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1303, 5100, 5145);
                    return return_v;
                }


                System.Collections.Generic.IEnumerator<System.Management.Automation.PSEventSubscriber>
                f_1303_5100_5161(System.Collections.Generic.IEnumerable<System.Management.Automation.PSEventSubscriber>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1303, 5100, 5161);
                    return return_v;
                }


                bool
                f_1303_5100_5172(System.Collections.Generic.IEnumerator<System.Management.Automation.PSEventSubscriber>
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1303, 5100, 5172);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1303_5475_5522()
                {
                    var return_v = System.Globalization.CultureInfo.CurrentCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1303, 5475, 5522);
                    return return_v;
                }


                string
                f_1303_5557_5591()
                {
                    var return_v = EventingResources.SubscriberExists;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1303, 5557, 5591);
                    return return_v;
                }


                string
                f_1303_5427_5611(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1303, 5427, 5611);
                    return return_v;
                }


                System.ArgumentException
                f_1303_5375_5612(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1303, 5375, 5612);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1303_5333_5753(System.ArgumentException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1303, 5333, 5753);
                    return return_v;
                }


                int
                f_1303_5778_5801(Microsoft.PowerShell.Commands.ObjectEventRegistrationBase
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1303, 5778, 5801);
                    return 0;
                }


                System.Management.Automation.PSEventManager
                f_1303_5926_5932()
                {
                    var return_v = Events;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1303, 5926, 5932);
                    return return_v;
                }


                System.Management.Automation.PSEventSubscriber
                f_1303_5926_6156(System.Management.Automation.PSEventManager
                this_param, object
                source, string
                eventName, string
                sourceIdentifier, System.Management.Automation.PSObject
                data, System.Management.Automation.ScriptBlock
                action, System.Management.Automation.SwitchParameter
                supportEvent, System.Management.Automation.SwitchParameter
                forwardEvent, int
                maxTriggerCount)
                {
                    var return_v = this_param.SubscribeEvent(source, eventName, sourceIdentifier, data, action, (bool)supportEvent, (bool)forwardEvent, maxTriggerCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1303, 5926, 6156);
                    return return_v;
                }


                System.Management.Automation.PSEventJob
                f_1303_6267_6288(System.Management.Automation.PSEventSubscriber
                this_param)
                {
                    var return_v = this_param.Action;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1303, 6267, 6288);
                    return return_v;
                }


                int
                f_1303_6255_6289(Microsoft.PowerShell.Commands.ObjectEventRegistrationBase
                this_param, System.Management.Automation.PSEventJob
                sendToPipeline)
                {
                    this_param.WriteObject((object)sendToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1303, 6255, 6289);
                    return 0;
                }


                System.Management.Automation.ErrorRecord
                f_1303_6424_6595(System.ArgumentException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1303, 6424, 6595);
                    return return_v;
                }


                int
                f_1303_6616_6639(Microsoft.PowerShell.Commands.ObjectEventRegistrationBase
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1303, 6616, 6639);
                    return 0;
                }


                System.Management.Automation.ErrorRecord
                f_1303_6763_6935(System.InvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1303, 6763, 6935);
                    return return_v;
                }


                int
                f_1303_6956_6979(Microsoft.PowerShell.Commands.ObjectEventRegistrationBase
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1303, 6956, 6979);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1303, 4772, 7006);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1303, 4772, 7006);
            }
        }

        public ObjectEventRegistrationBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1303, 298, 7013);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1303, 821, 866);
            this._sourceIdentifier = Guid.NewGuid().ToString();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1303, 1281, 1295);
            this._action = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1303, 1717, 1736);
            this._messageData = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1303, 2211, 2248);
            this._supportEvent = f_1303_2227_2248();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1303, 2748, 2780);
            this._forward = f_1303_2759_2780();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1303, 3407, 3427);
            this._maxTriggerCount = 0;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1303, 4084, 4098);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1303, 298, 7013);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1303, 298, 7013);
        }


        static ObjectEventRegistrationBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1303, 298, 7013);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1303, 298, 7013);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1303, 298, 7013);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1303, 298, 7013);

        System.Management.Automation.SwitchParameter
        f_1303_2227_2248()
        {
            var return_v = new System.Management.Automation.SwitchParameter();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1303, 2227, 2248);
            return return_v;
        }


        System.Management.Automation.SwitchParameter
        f_1303_2759_2780()
        {
            var return_v = new System.Management.Automation.SwitchParameter();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1303, 2759, 2780);
            return return_v;
        }

    }
}
