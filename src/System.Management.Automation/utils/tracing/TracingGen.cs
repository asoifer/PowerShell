// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing;

namespace System.Management.Automation.Tracing
{
    public sealed partial class Tracer : System.Management.Automation.Tracing.EtwActivity
    {
        public const byte
        LevelCritical = 1
        ;

        public const byte
        LevelError = 2
        ;

        public const byte
        LevelWarning = 3
        ;

        public const byte
        LevelInformational = 4
        ;

        public const byte
        LevelVerbose = 5
        ;

        public const long
        KeywordAll = 0xFFFFFFFF
        ;

        private static Guid providerId;

        private static EventDescriptor WriteTransferEventEvent;

        private static EventDescriptor DebugMessageEvent;

        private static EventDescriptor M3PAbortingWorkflowExecutionEvent;

        private static EventDescriptor M3PActivityExecutionFinishedEvent;

        private static EventDescriptor M3PActivityExecutionQueuedEvent;

        private static EventDescriptor M3PActivityExecutionStartedEvent;

        private static EventDescriptor M3PBeginContainerParentJobExecutionEvent;

        private static EventDescriptor M3PBeginCreateNewJobEvent;

        private static EventDescriptor M3PBeginJobLogicEvent;

        private static EventDescriptor M3PBeginProxyChildJobEventHandlerEvent;

        private static EventDescriptor M3PBeginProxyJobEventHandlerEvent;

        private static EventDescriptor M3PBeginProxyJobExecutionEvent;

        private static EventDescriptor M3PBeginRunGarbageCollectionEvent;

        private static EventDescriptor M3PBeginStartWorkflowApplicationEvent;

        private static EventDescriptor M3PBeginWorkflowExecutionEvent;

        private static EventDescriptor M3PCancellingWorkflowExecutionEvent;

        private static EventDescriptor M3PChildWorkflowJobAdditionEvent;

        private static EventDescriptor M3PEndContainerParentJobExecutionEvent;

        private static EventDescriptor M3PEndCreateNewJobEvent;

        private static EventDescriptor M3PEndJobLogicEvent;

        private static EventDescriptor M3PEndpointDisabledEvent;

        private static EventDescriptor M3PEndpointEnabledEvent;

        private static EventDescriptor M3PEndpointModifiedEvent;

        private static EventDescriptor M3PEndpointRegisteredEvent;

        private static EventDescriptor M3PEndpointUnregisteredEvent;

        private static EventDescriptor M3PEndProxyChildJobEventHandlerEvent;

        private static EventDescriptor M3PEndProxyJobEventHandlerEvent;

        private static EventDescriptor M3PEndProxyJobExecutionEvent;

        private static EventDescriptor M3PEndRunGarbageCollectionEvent;

        private static EventDescriptor M3PEndStartWorkflowApplicationEvent;

        private static EventDescriptor M3PEndWorkflowExecutionEvent;

        private static EventDescriptor M3PErrorImportingWorkflowFromXamlEvent;

        private static EventDescriptor M3PForcedWorkflowShutdownErrorEvent;

        private static EventDescriptor M3PForcedWorkflowShutdownFinishedEvent;

        private static EventDescriptor M3PForcedWorkflowShutdownStartedEvent;

        private static EventDescriptor M3PImportedWorkflowFromXamlEvent;

        private static EventDescriptor M3PImportingWorkflowFromXamlEvent;

        private static EventDescriptor M3PJobCreationCompleteEvent;

        private static EventDescriptor M3PJobErrorEvent;

        private static EventDescriptor M3PJobRemovedEvent;

        private static EventDescriptor M3PJobRemoveErrorEvent;

        private static EventDescriptor M3PJobStateChangedEvent;

        private static EventDescriptor M3PLoadingWorkflowForExecutionEvent;

        private static EventDescriptor M3POutOfProcessRunspaceStartedEvent;

        private static EventDescriptor M3PParameterSplattingWasPerformedEvent;

        private static EventDescriptor M3PParentJobCreatedEvent;

        private static EventDescriptor M3PPersistenceStoreMaxSizeReachedEvent;

        private static EventDescriptor M3PPersistingWorkflowEvent;

        private static EventDescriptor M3PProxyJobRemoteJobAssociationEvent;

        private static EventDescriptor M3PRemoveJobStartedEvent;

        private static EventDescriptor M3PRunspaceAvailabilityChangedEvent;

        private static EventDescriptor M3PRunspaceStateChangedEvent;

        private static EventDescriptor M3PTrackingGuidContainerParentJobCorrelationEvent;

        private static EventDescriptor M3PUnloadingWorkflowEvent;

        private static EventDescriptor M3PWorkflowActivityExecutionFailedEvent;

        private static EventDescriptor M3PWorkflowActivityValidatedEvent;

        private static EventDescriptor M3PWorkflowActivityValidationFailedEvent;

        private static EventDescriptor M3PWorkflowCleanupPerformedEvent;

        private static EventDescriptor M3PWorkflowDeletedFromDiskEvent;

        private static EventDescriptor M3PWorkflowEngineStartedEvent;

        private static EventDescriptor M3PWorkflowExecutionAbortedEvent;

        private static EventDescriptor M3PWorkflowExecutionCancelledEvent;

        private static EventDescriptor M3PWorkflowExecutionErrorEvent;

        private static EventDescriptor M3PWorkflowExecutionFinishedEvent;

        private static EventDescriptor M3PWorkflowExecutionStartedEvent;

        private static EventDescriptor M3PWorkflowJobCreatedEvent;

        private static EventDescriptor M3PWorkflowLoadedForExecutionEvent;

        private static EventDescriptor M3PWorkflowLoadedFromDiskEvent;

        private static EventDescriptor M3PWorkflowManagerCheckpointEvent;

        private static EventDescriptor M3PWorkflowPersistedEvent;

        private static EventDescriptor M3PWorkflowPluginRequestedToShutdownEvent;

        private static EventDescriptor M3PWorkflowPluginRestartedEvent;

        private static EventDescriptor M3PWorkflowPluginStartedEvent;

        private static EventDescriptor M3PWorkflowQuotaViolatedEvent;

        private static EventDescriptor M3PWorkflowResumedEvent;

        private static EventDescriptor M3PWorkflowResumingEvent;

        private static EventDescriptor M3PWorkflowRunspacePoolCreatedEvent;

        private static EventDescriptor M3PWorkflowStateChangedEvent;

        private static EventDescriptor M3PWorkflowUnloadedEvent;

        private static EventDescriptor M3PWorkflowValidationErrorEvent;

        private static EventDescriptor M3PWorkflowValidationFinishedEvent;

        private static EventDescriptor M3PWorkflowValidationStartedEvent;

        static Tracer()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1060, 7261, 18195);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 496, 513);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 615, 629);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 733, 749);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 859, 881);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 985, 1001);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 1103, 1126);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 1157, 1220);
                providerId = Guid.Parse("a0c1853b-5c40-4b15-8766-3cf1c58f985a");
                unchecked
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 7343, 7450);

                    WriteTransferEventEvent = f_1060_7369_7449(0x1f05, 0x1, 0x11, 0x5, 0x14, 0x0, (long)0x4000000000000000);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 7468, 7568);

                    DebugMessageEvent = f_1060_7488_7567(0xc000, 0x1, 0x12, 0x4, 0x0, 0x0, (long)0x2000000000000000);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 7586, 7703);

                    M3PAbortingWorkflowExecutionEvent = f_1060_7622_7702(0xb038, 0x1, 0x11, 0x5, 0x14, 0x6, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 7721, 7838);

                    M3PActivityExecutionFinishedEvent = f_1060_7757_7837(0xb03f, 0x1, 0x11, 0x5, 0x14, 0x6, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 7856, 7971);

                    M3PActivityExecutionQueuedEvent = f_1060_7890_7970(0xb017, 0x1, 0x11, 0x5, 0x14, 0x6, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 7989, 8105);

                    M3PActivityExecutionStartedEvent = f_1060_8024_8104(0xb018, 0x1, 0x11, 0x5, 0x14, 0x6, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 8123, 8246);

                    M3PBeginContainerParentJobExecutionEvent = f_1060_8166_8245(0xb50c, 0x1, 0x12, 0x4, 0x0, 0x0, (long)0x2000000000000000);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 8264, 8372);

                    M3PBeginCreateNewJobEvent = f_1060_8292_8371(0xb503, 0x1, 0x12, 0x4, 0x0, 0x0, (long)0x2000000000000000);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 8390, 8494);

                    M3PBeginJobLogicEvent = f_1060_8414_8493(0xb506, 0x1, 0x12, 0x4, 0x0, 0x0, (long)0x2000000000000000);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 8512, 8633);

                    M3PBeginProxyChildJobEventHandlerEvent = f_1060_8553_8632(0xb512, 0x1, 0x12, 0x4, 0x0, 0x0, (long)0x2000000000000000);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 8651, 8767);

                    M3PBeginProxyJobEventHandlerEvent = f_1060_8687_8766(0xb510, 0x1, 0x12, 0x4, 0x0, 0x0, (long)0x2000000000000000);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 8785, 8898);

                    M3PBeginProxyJobExecutionEvent = f_1060_8818_8897(0xb50e, 0x1, 0x12, 0x4, 0x0, 0x0, (long)0x2000000000000000);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 8916, 9032);

                    M3PBeginRunGarbageCollectionEvent = f_1060_8952_9031(0xb514, 0x1, 0x12, 0x4, 0x0, 0x0, (long)0x2000000000000000);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 9050, 9170);

                    M3PBeginStartWorkflowApplicationEvent = f_1060_9090_9169(0xb501, 0x1, 0x12, 0x4, 0x0, 0x0, (long)0x2000000000000000);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 9188, 9301);

                    M3PBeginWorkflowExecutionEvent = f_1060_9221_9300(0xb508, 0x1, 0x12, 0x4, 0x0, 0x0, (long)0x2000000000000000);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 9319, 9438);

                    M3PCancellingWorkflowExecutionEvent = f_1060_9357_9437(0xb037, 0x1, 0x11, 0x5, 0x14, 0x6, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 9456, 9571);

                    M3PChildWorkflowJobAdditionEvent = f_1060_9491_9570(0xb50a, 0x1, 0x12, 0x4, 0x0, 0x0, (long)0x2000000000000000);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 9589, 9710);

                    M3PEndContainerParentJobExecutionEvent = f_1060_9630_9709(0xb50d, 0x1, 0x12, 0x4, 0x0, 0x0, (long)0x2000000000000000);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 9728, 9834);

                    M3PEndCreateNewJobEvent = f_1060_9754_9833(0xb504, 0x1, 0x12, 0x4, 0x0, 0x0, (long)0x2000000000000000);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 9852, 9954);

                    M3PEndJobLogicEvent = f_1060_9874_9953(0xb507, 0x1, 0x12, 0x4, 0x0, 0x0, (long)0x2000000000000000);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 9972, 10080);

                    M3PEndpointDisabledEvent = f_1060_9999_10079(0xb044, 0x1, 0x11, 0x5, 0x14, 0x9, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 10098, 10205);

                    M3PEndpointEnabledEvent = f_1060_10124_10204(0xb045, 0x1, 0x11, 0x5, 0x14, 0x9, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 10223, 10331);

                    M3PEndpointModifiedEvent = f_1060_10250_10330(0xb042, 0x1, 0x11, 0x5, 0x14, 0x9, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 10349, 10459);

                    M3PEndpointRegisteredEvent = f_1060_10378_10458(0xb041, 0x1, 0x11, 0x5, 0x14, 0x9, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 10477, 10589);

                    M3PEndpointUnregisteredEvent = f_1060_10508_10588(0xb043, 0x1, 0x11, 0x5, 0x14, 0x9, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 10607, 10726);

                    M3PEndProxyChildJobEventHandlerEvent = f_1060_10646_10725(0xb513, 0x1, 0x12, 0x4, 0x0, 0x0, (long)0x2000000000000000);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 10744, 10858);

                    M3PEndProxyJobEventHandlerEvent = f_1060_10778_10857(0xb511, 0x1, 0x12, 0x4, 0x0, 0x0, (long)0x2000000000000000);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 10876, 10987);

                    M3PEndProxyJobExecutionEvent = f_1060_10907_10986(0xb50f, 0x1, 0x12, 0x4, 0x0, 0x0, (long)0x2000000000000000);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 11005, 11119);

                    M3PEndRunGarbageCollectionEvent = f_1060_11039_11118(0xb515, 0x1, 0x12, 0x4, 0x0, 0x0, (long)0x2000000000000000);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 11137, 11255);

                    M3PEndStartWorkflowApplicationEvent = f_1060_11175_11254(0xb502, 0x1, 0x12, 0x4, 0x0, 0x0, (long)0x2000000000000000);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 11273, 11384);

                    M3PEndWorkflowExecutionEvent = f_1060_11304_11383(0xb509, 0x1, 0x12, 0x4, 0x0, 0x0, (long)0x2000000000000000);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 11402, 11524);

                    M3PErrorImportingWorkflowFromXamlEvent = f_1060_11443_11523(0xb01b, 0x1, 0x11, 0x5, 0x14, 0x6, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 11542, 11661);

                    M3PForcedWorkflowShutdownErrorEvent = f_1060_11580_11660(0xb03c, 0x1, 0x11, 0x5, 0x14, 0x6, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 11679, 11801);

                    M3PForcedWorkflowShutdownFinishedEvent = f_1060_11720_11800(0xb03b, 0x1, 0x11, 0x5, 0x14, 0x6, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 11819, 11940);

                    M3PForcedWorkflowShutdownStartedEvent = f_1060_11859_11939(0xb03a, 0x1, 0x11, 0x5, 0x14, 0x6, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 11958, 12074);

                    M3PImportedWorkflowFromXamlEvent = f_1060_11993_12073(0xb01a, 0x1, 0x11, 0x5, 0x14, 0x6, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 12092, 12209);

                    M3PImportingWorkflowFromXamlEvent = f_1060_12128_12208(0xb019, 0x1, 0x11, 0x5, 0x14, 0x6, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 12227, 12338);

                    M3PJobCreationCompleteEvent = f_1060_12257_12337(0xb032, 0x1, 0x11, 0x5, 0x14, 0x6, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 12356, 12456);

                    M3PJobErrorEvent = f_1060_12375_12455(0xb02e, 0x1, 0x11, 0x5, 0x14, 0x6, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 12474, 12576);

                    M3PJobRemovedEvent = f_1060_12495_12575(0xb033, 0x1, 0x11, 0x5, 0x14, 0x6, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 12594, 12700);

                    M3PJobRemoveErrorEvent = f_1060_12619_12699(0xb034, 0x1, 0x11, 0x5, 0x14, 0x6, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 12718, 12825);

                    M3PJobStateChangedEvent = f_1060_12744_12824(0xb02d, 0x1, 0x11, 0x5, 0x14, 0x6, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 12843, 12962);

                    M3PLoadingWorkflowForExecutionEvent = f_1060_12881_12961(0xb035, 0x1, 0x11, 0x5, 0x14, 0x6, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 12980, 13099);

                    M3POutOfProcessRunspaceStartedEvent = f_1060_13018_13098(0xb046, 0x1, 0x11, 0x5, 0x14, 0x6, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 13117, 13239);

                    M3PParameterSplattingWasPerformedEvent = f_1060_13158_13238(0xb047, 0x1, 0x11, 0x5, 0x14, 0x6, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 13257, 13365);

                    M3PParentJobCreatedEvent = f_1060_13284_13364(0xb031, 0x1, 0x11, 0x5, 0x14, 0x6, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 13383, 13504);

                    M3PPersistenceStoreMaxSizeReachedEvent = f_1060_13424_13503(0xb516, 0x1, 0x10, 0x3, 0x0, 0x0, (ulong)0x8000000000000000);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 13522, 13632);

                    M3PPersistingWorkflowEvent = f_1060_13551_13631(0xb03d, 0x1, 0x11, 0x5, 0x14, 0x6, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 13650, 13769);

                    M3PProxyJobRemoteJobAssociationEvent = f_1060_13689_13768(0xb50b, 0x1, 0x12, 0x4, 0x0, 0x0, (long)0x2000000000000000);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 13787, 13895);

                    M3PRemoveJobStartedEvent = f_1060_13814_13894(0xb02c, 0x1, 0x11, 0x5, 0x14, 0x6, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 13913, 14032);

                    M3PRunspaceAvailabilityChangedEvent = f_1060_13951_14031(0xb022, 0x1, 0x11, 0x5, 0x14, 0x6, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 14050, 14162);

                    M3PRunspaceStateChangedEvent = f_1060_14081_14161(0xb023, 0x1, 0x11, 0x5, 0x14, 0x6, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 14180, 14312);

                    M3PTrackingGuidContainerParentJobCorrelationEvent = f_1060_14232_14311(0xb505, 0x1, 0x12, 0x4, 0x0, 0x0, (long)0x2000000000000000);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 14330, 14439);

                    M3PUnloadingWorkflowEvent = f_1060_14358_14438(0xb039, 0x1, 0x11, 0x5, 0x14, 0x6, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 14457, 14580);

                    M3PWorkflowActivityExecutionFailedEvent = f_1060_14499_14579(0xb021, 0x1, 0x11, 0x5, 0x14, 0x6, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 14598, 14715);

                    M3PWorkflowActivityValidatedEvent = f_1060_14634_14714(0xb01f, 0x1, 0x11, 0x5, 0x14, 0x6, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 14733, 14857);

                    M3PWorkflowActivityValidationFailedEvent = f_1060_14776_14856(0xb020, 0x1, 0x11, 0x5, 0x14, 0x8, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 14875, 14991);

                    M3PWorkflowCleanupPerformedEvent = f_1060_14910_14990(0xb028, 0x1, 0x11, 0x5, 0x14, 0x6, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 15009, 15124);

                    M3PWorkflowDeletedFromDiskEvent = f_1060_15043_15123(0xb02a, 0x1, 0x11, 0x5, 0x14, 0x6, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 15142, 15255);

                    M3PWorkflowEngineStartedEvent = f_1060_15174_15254(0xb048, 0x1, 0x11, 0x5, 0x14, 0x5, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 15273, 15389);

                    M3PWorkflowExecutionAbortedEvent = f_1060_15308_15388(0xb027, 0x1, 0x11, 0x5, 0x14, 0x6, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 15407, 15525);

                    M3PWorkflowExecutionCancelledEvent = f_1060_15444_15524(0xb026, 0x1, 0x11, 0x5, 0x14, 0x6, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 15543, 15657);

                    M3PWorkflowExecutionErrorEvent = f_1060_15576_15656(0xb040, 0x1, 0x11, 0x5, 0x14, 0x6, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 15675, 15792);

                    M3PWorkflowExecutionFinishedEvent = f_1060_15711_15791(0xb036, 0x1, 0x11, 0x5, 0x14, 0x6, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 15810, 15926);

                    M3PWorkflowExecutionStartedEvent = f_1060_15845_15925(0xb008, 0x1, 0x11, 0x5, 0x14, 0x6, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 15944, 16054);

                    M3PWorkflowJobCreatedEvent = f_1060_15973_16053(0xb030, 0x1, 0x11, 0x5, 0x14, 0x6, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 16072, 16190);

                    M3PWorkflowLoadedForExecutionEvent = f_1060_16109_16189(0xb024, 0x1, 0x11, 0x5, 0x14, 0x6, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 16208, 16322);

                    M3PWorkflowLoadedFromDiskEvent = f_1060_16241_16321(0xb029, 0x1, 0x11, 0x5, 0x14, 0x6, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 16340, 16456);

                    M3PWorkflowManagerCheckpointEvent = f_1060_16376_16455(0xb049, 0x1, 0x12, 0x4, 0x0, 0x0, (long)0x2000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 16474, 16583);

                    M3PWorkflowPersistedEvent = f_1060_16502_16582(0xb03e, 0x1, 0x11, 0x5, 0x14, 0x6, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 16601, 16726);

                    M3PWorkflowPluginRequestedToShutdownEvent = f_1060_16645_16725(0xb010, 0x1, 0x11, 0x5, 0x14, 0x5, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 16744, 16859);

                    M3PWorkflowPluginRestartedEvent = f_1060_16778_16858(0xb011, 0x1, 0x11, 0x5, 0x14, 0x5, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 16877, 16990);

                    M3PWorkflowPluginStartedEvent = f_1060_16909_16989(0xb007, 0x1, 0x11, 0x5, 0x14, 0x5, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 17008, 17121);

                    M3PWorkflowQuotaViolatedEvent = f_1060_17040_17120(0xb013, 0x1, 0x11, 0x5, 0x14, 0x6, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 17139, 17246);

                    M3PWorkflowResumedEvent = f_1060_17165_17245(0xb014, 0x1, 0x11, 0x5, 0x14, 0x6, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 17264, 17372);

                    M3PWorkflowResumingEvent = f_1060_17291_17371(0xb012, 0x1, 0x11, 0x5, 0x14, 0x6, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 17390, 17509);

                    M3PWorkflowRunspacePoolCreatedEvent = f_1060_17428_17508(0xb016, 0x1, 0x11, 0x5, 0x14, 0x6, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 17527, 17639);

                    M3PWorkflowStateChangedEvent = f_1060_17558_17638(0xb009, 0x1, 0x11, 0x5, 0x14, 0x6, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 17657, 17765);

                    M3PWorkflowUnloadedEvent = f_1060_17684_17764(0xb025, 0x1, 0x11, 0x5, 0x14, 0x6, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 17783, 17898);

                    M3PWorkflowValidationErrorEvent = f_1060_17817_17897(0xb01e, 0x1, 0x11, 0x5, 0x14, 0x8, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 17916, 18034);

                    M3PWorkflowValidationFinishedEvent = f_1060_17953_18033(0xb01d, 0x1, 0x11, 0x5, 0x14, 0x8, (long)0x4000000000000200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 18052, 18169);

                    M3PWorkflowValidationStartedEvent = f_1060_18088_18168(0xb01c, 0x1, 0x11, 0x5, 0x14, 0x8, (long)0x4000000000000200);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1060, 7261, 18195);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 7261, 18195);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 7261, 18195);
            }
        }

        public Tracer() : base()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1060, 18280, 18308);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1060, 18280, 18308);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 18280, 18308);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 18280, 18308);
            }
        }

        protected override Guid ProviderId
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 18454, 18523);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 18490, 18508);

                    return providerId;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 18454, 18523);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 18395, 18534);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 18395, 18534);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override EventDescriptor TransferEvent
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 18695, 18777);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 18731, 18762);

                    return WriteTransferEventEvent;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 18695, 18777);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 18622, 18788);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 18622, 18788);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        [EtwEvent(0x1f05)]
        public void WriteTransferEvent(Guid currentActivityId, Guid parentActivityId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 18903, 19117);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 19033, 19106);

                f_1060_19033_19105(this, WriteTransferEventEvent, currentActivityId, parentActivityId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 18903, 19117);

                int
                f_1060_19033_19105(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 19033, 19105);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 18903, 19117);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 18903, 19117);
            }
        }

        [EtwEvent(0xc000)]
        public void DebugMessage(string message)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 19227, 19370);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 19320, 19359);

                f_1060_19320_19358(this, DebugMessageEvent, message);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 19227, 19370);

                int
                f_1060_19320_19358(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 19320, 19358);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 19227, 19370);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 19227, 19370);
            }
        }

        [EtwEvent(0xb038)]
        public void AbortingWorkflowExecution(Guid workflowId, string reason)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 19493, 19692);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 19615, 19681);

                f_1060_19615_19680(this, M3PAbortingWorkflowExecutionEvent, workflowId, reason);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 19493, 19692);

                int
                f_1060_19615_19680(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 19615, 19680);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 19493, 19692);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 19493, 19692);
            }
        }

        [EtwEvent(0xb03f)]
        public void ActivityExecutionFinished(string activityName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 19815, 19997);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 19926, 19986);

                f_1060_19926_19985(this, M3PActivityExecutionFinishedEvent, activityName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 19815, 19997);

                int
                f_1060_19926_19985(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 19926, 19985);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 19815, 19997);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 19815, 19997);
            }
        }

        [EtwEvent(0xb017)]
        public void ActivityExecutionQueued(Guid workflowId, string activityName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 20118, 20325);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 20244, 20314);

                f_1060_20244_20313(this, M3PActivityExecutionQueuedEvent, workflowId, activityName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 20118, 20325);

                int
                f_1060_20244_20313(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 20244, 20313);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 20118, 20325);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 20118, 20325);
            }
        }

        [EtwEvent(0xb018)]
        public void ActivityExecutionStarted(string activityName, string activityTypeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 20447, 20670);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 20582, 20659);

                f_1060_20582_20658(this, M3PActivityExecutionStartedEvent, activityName, activityTypeName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 20447, 20670);

                int
                f_1060_20582_20658(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 20582, 20658);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 20447, 20670);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 20447, 20670);
            }
        }

        [EtwEvent(0xb50c)]
        public void BeginContainerParentJobExecution(Guid containerParentJobInstanceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 20800, 21026);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 20932, 21015);

                f_1060_20932_21014(this, M3PBeginContainerParentJobExecutionEvent, containerParentJobInstanceId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 20800, 21026);

                int
                f_1060_20932_21014(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 20932, 21014);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 20800, 21026);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 20800, 21026);
            }
        }

        [EtwEvent(0xb503)]
        public void BeginCreateNewJob(Guid trackingId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 21141, 21301);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 21240, 21290);

                f_1060_21240_21289(this, M3PBeginCreateNewJobEvent, trackingId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 21141, 21301);

                int
                f_1060_21240_21289(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 21240, 21289);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 21141, 21301);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 21141, 21301);
            }
        }

        [EtwEvent(0xb506)]
        public void BeginJobLogic(Guid workflowJobJobInstanceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 21412, 21592);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 21521, 21581);

                f_1060_21521_21580(this, M3PBeginJobLogicEvent, workflowJobJobInstanceId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 21412, 21592);

                int
                f_1060_21521_21580(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 21521, 21580);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 21412, 21592);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 21412, 21592);
            }
        }

        [EtwEvent(0xb512)]
        public void BeginProxyChildJobEventHandler(Guid proxyChildJobInstanceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 21720, 21932);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 21845, 21921);

                f_1060_21845_21920(this, M3PBeginProxyChildJobEventHandlerEvent, proxyChildJobInstanceId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 21720, 21932);

                int
                f_1060_21845_21920(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 21845, 21920);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 21720, 21932);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 21720, 21932);
            }
        }

        [EtwEvent(0xb510)]
        public void BeginProxyJobEventHandler(Guid proxyJobInstanceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 22055, 22247);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 22170, 22236);

                f_1060_22170_22235(this, M3PBeginProxyJobEventHandlerEvent, proxyJobInstanceId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 22055, 22247);

                int
                f_1060_22170_22235(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 22170, 22235);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 22055, 22247);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 22055, 22247);
            }
        }

        [EtwEvent(0xb50e)]
        public void BeginProxyJobExecution(Guid proxyJobInstanceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 22367, 22553);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 22479, 22542);

                f_1060_22479_22541(this, M3PBeginProxyJobExecutionEvent, proxyJobInstanceId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 22367, 22553);

                int
                f_1060_22479_22541(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 22479, 22541);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 22367, 22553);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 22367, 22553);
            }
        }

        [EtwEvent(0xb514)]
        public void BeginRunGarbageCollection()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 22676, 22825);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 22768, 22814);

                f_1060_22768_22813(this, M3PBeginRunGarbageCollectionEvent);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 22676, 22825);

                int
                f_1060_22768_22813(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 22768, 22813);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 22676, 22825);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 22676, 22825);
            }
        }

        [EtwEvent(0xb501)]
        public void BeginStartWorkflowApplication(Guid trackingId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 22952, 23136);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 23063, 23125);

                f_1060_23063_23124(this, M3PBeginStartWorkflowApplicationEvent, trackingId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 22952, 23136);

                int
                f_1060_23063_23124(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 23063, 23124);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 22952, 23136);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 22952, 23136);
            }
        }

        [EtwEvent(0xb508)]
        public void BeginWorkflowExecution(Guid workflowJobJobInstanceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 23256, 23454);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 23374, 23443);

                f_1060_23374_23442(this, M3PBeginWorkflowExecutionEvent, workflowJobJobInstanceId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 23256, 23454);

                int
                f_1060_23374_23442(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 23374, 23442);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 23256, 23454);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 23256, 23454);
            }
        }

        [EtwEvent(0xb037)]
        public void CancellingWorkflowExecution(Guid workflowId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 23579, 23759);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 23688, 23748);

                f_1060_23688_23747(this, M3PCancellingWorkflowExecutionEvent, workflowId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 23579, 23759);

                int
                f_1060_23688_23747(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 23688, 23747);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 23579, 23759);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 23579, 23759);
            }
        }

        [EtwEvent(0xb50a)]
        public void ChildWorkflowJobAddition(Guid workflowJobInstanceId, Guid containerParentJobInstanceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 23881, 24142);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 24033, 24131);

                f_1060_24033_24130(this, M3PChildWorkflowJobAdditionEvent, workflowJobInstanceId, containerParentJobInstanceId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 23881, 24142);

                int
                f_1060_24033_24130(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 24033, 24130);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 23881, 24142);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 23881, 24142);
            }
        }

        [EtwEvent(0xb50d)]
        public void EndContainerParentJobExecution(Guid containerParentJobInstanceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 24270, 24492);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 24400, 24481);

                f_1060_24400_24480(this, M3PEndContainerParentJobExecutionEvent, containerParentJobInstanceId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 24270, 24492);

                int
                f_1060_24400_24480(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 24400, 24480);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 24270, 24492);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 24270, 24492);
            }
        }

        [EtwEvent(0xb504)]
        public void EndCreateNewJob(Guid trackingId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 24605, 24761);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 24702, 24750);

                f_1060_24702_24749(this, M3PEndCreateNewJobEvent, trackingId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 24605, 24761);

                int
                f_1060_24702_24749(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 24702, 24749);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 24605, 24761);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 24605, 24761);
            }
        }

        [EtwEvent(0xb507)]
        public void EndJobLogic(Guid workflowJobJobInstanceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 24870, 25046);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 24977, 25035);

                f_1060_24977_25034(this, M3PEndJobLogicEvent, workflowJobJobInstanceId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 24870, 25046);

                int
                f_1060_24977_25034(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 24977, 25034);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 24870, 25046);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 24870, 25046);
            }
        }

        [EtwEvent(0xb044)]
        public void EndpointDisabled(string endpointName, string disabledBy)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 25160, 25355);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 25281, 25344);

                f_1060_25281_25343(this, M3PEndpointDisabledEvent, endpointName, disabledBy);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 25160, 25355);

                int
                f_1060_25281_25343(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 25281, 25343);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 25160, 25355);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 25160, 25355);
            }
        }

        [EtwEvent(0xb045)]
        public void EndpointEnabled(string endpointName, string enabledBy)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 25468, 25659);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 25587, 25648);

                f_1060_25587_25647(this, M3PEndpointEnabledEvent, endpointName, enabledBy);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 25468, 25659);

                int
                f_1060_25587_25647(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 25587, 25647);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 25468, 25659);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 25468, 25659);
            }
        }

        [EtwEvent(0xb042)]
        public void EndpointModified(string endpointName, string modifiedBy)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 25773, 25968);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 25894, 25957);

                f_1060_25894_25956(this, M3PEndpointModifiedEvent, endpointName, modifiedBy);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 25773, 25968);

                int
                f_1060_25894_25956(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 25894, 25956);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 25773, 25968);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 25773, 25968);
            }
        }

        [EtwEvent(0xb041)]
        public void EndpointRegistered(string endpointName, string registeredBy)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 26084, 26287);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 26209, 26276);

                f_1060_26209_26275(this, M3PEndpointRegisteredEvent, endpointName, registeredBy);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 26084, 26287);

                int
                f_1060_26209_26275(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 26209, 26275);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 26084, 26287);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 26084, 26287);
            }
        }

        [EtwEvent(0xb043)]
        public void EndpointUnregistered(string endpointName, string unregisteredBy)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 26405, 26616);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 26534, 26605);

                f_1060_26534_26604(this, M3PEndpointUnregisteredEvent, endpointName, unregisteredBy);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 26405, 26616);

                int
                f_1060_26534_26604(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 26534, 26604);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 26405, 26616);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 26405, 26616);
            }
        }

        [EtwEvent(0xb513)]
        public void EndProxyChildJobEventHandler(Guid proxyChildJobInstanceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 26742, 26950);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 26865, 26939);

                f_1060_26865_26938(this, M3PEndProxyChildJobEventHandlerEvent, proxyChildJobInstanceId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 26742, 26950);

                int
                f_1060_26865_26938(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 26865, 26938);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 26742, 26950);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 26742, 26950);
            }
        }

        [EtwEvent(0xb511)]
        public void EndProxyJobEventHandler(Guid proxyJobInstanceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 27071, 27259);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 27184, 27248);

                f_1060_27184_27247(this, M3PEndProxyJobEventHandlerEvent, proxyJobInstanceId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 27071, 27259);

                int
                f_1060_27184_27247(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 27184, 27247);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 27071, 27259);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 27071, 27259);
            }
        }

        [EtwEvent(0xb50f)]
        public void EndProxyJobExecution(Guid proxyJobInstanceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 27377, 27559);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 27487, 27548);

                f_1060_27487_27547(this, M3PEndProxyJobExecutionEvent, proxyJobInstanceId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 27377, 27559);

                int
                f_1060_27487_27547(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 27487, 27547);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 27377, 27559);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 27377, 27559);
            }
        }

        [EtwEvent(0xb515)]
        public void EndRunGarbageCollection()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 27680, 27825);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 27770, 27814);

                f_1060_27770_27813(this, M3PEndRunGarbageCollectionEvent);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 27680, 27825);

                int
                f_1060_27770_27813(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 27770, 27813);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 27680, 27825);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 27680, 27825);
            }
        }

        [EtwEvent(0xb502)]
        public void EndStartWorkflowApplication(Guid trackingId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 27950, 28130);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 28059, 28119);

                f_1060_28059_28118(this, M3PEndStartWorkflowApplicationEvent, trackingId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 27950, 28130);

                int
                f_1060_28059_28118(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 28059, 28118);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 27950, 28130);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 27950, 28130);
            }
        }

        [EtwEvent(0xb509)]
        public void EndWorkflowExecution(Guid workflowJobJobInstanceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 28248, 28442);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 28364, 28431);

                f_1060_28364_28430(this, M3PEndWorkflowExecutionEvent, workflowJobJobInstanceId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 28248, 28442);

                int
                f_1060_28364_28430(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 28364, 28430);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 28248, 28442);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 28248, 28442);
            }
        }

        [EtwEvent(0xb01b)]
        public void ErrorImportingWorkflowFromXaml(Guid workflowId, string errorDescription)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 28570, 28799);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 28707, 28788);

                f_1060_28707_28787(this, M3PErrorImportingWorkflowFromXamlEvent, workflowId, errorDescription);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 28570, 28799);

                int
                f_1060_28707_28787(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 28707, 28787);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 28570, 28799);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 28570, 28799);
            }
        }

        [EtwEvent(0xb03c)]
        public void ForcedWorkflowShutdownError(Guid workflowId, string errorDescription)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 28924, 29147);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 29058, 29136);

                f_1060_29058_29135(this, M3PForcedWorkflowShutdownErrorEvent, workflowId, errorDescription);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 28924, 29147);

                int
                f_1060_29058_29135(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 29058, 29135);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 28924, 29147);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 28924, 29147);
            }
        }

        [EtwEvent(0xb03b)]
        public void ForcedWorkflowShutdownFinished(Guid workflowId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 29275, 29461);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 29387, 29450);

                f_1060_29387_29449(this, M3PForcedWorkflowShutdownFinishedEvent, workflowId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 29275, 29461);

                int
                f_1060_29387_29449(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 29387, 29449);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 29275, 29461);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 29275, 29461);
            }
        }

        [EtwEvent(0xb03a)]
        public void ForcedWorkflowShutdownStarted(Guid workflowId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 29588, 29772);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 29699, 29761);

                f_1060_29699_29760(this, M3PForcedWorkflowShutdownStartedEvent, workflowId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 29588, 29772);

                int
                f_1060_29699_29760(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 29699, 29760);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 29588, 29772);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 29588, 29772);
            }
        }

        [EtwEvent(0xb01a)]
        public void ImportedWorkflowFromXaml(Guid workflowId, string xamlFile)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 29894, 30095);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 30017, 30084);

                f_1060_30017_30083(this, M3PImportedWorkflowFromXamlEvent, workflowId, xamlFile);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 29894, 30095);

                int
                f_1060_30017_30083(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 30017, 30083);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 29894, 30095);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 29894, 30095);
            }
        }

        [EtwEvent(0xb019)]
        public void ImportingWorkflowFromXaml(Guid workflowId, string xamlFile)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 30218, 30421);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 30342, 30410);

                f_1060_30342_30409(this, M3PImportingWorkflowFromXamlEvent, workflowId, xamlFile);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 30218, 30421);

                int
                f_1060_30342_30409(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 30342, 30409);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 30218, 30421);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 30218, 30421);
            }
        }

        [EtwEvent(0xb032)]
        public void JobCreationComplete(Guid jobId, Guid workflowId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 30538, 30721);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 30651, 30710);

                f_1060_30651_30709(this, M3PJobCreationCompleteEvent, jobId, workflowId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 30538, 30721);

                int
                f_1060_30651_30709(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 30651, 30709);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 30538, 30721);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 30538, 30721);
            }
        }

        [EtwEvent(0xb02e)]
        public void JobError(int jobId, Guid workflowId, string errorDescription)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 30827, 31030);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 30953, 31019);

                f_1060_30953_31018(this, M3PJobErrorEvent, jobId, workflowId, errorDescription);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 30827, 31030);

                int
                f_1060_30953_31018(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 30953, 31018);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 30827, 31030);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 30827, 31030);
            }
        }

        [EtwEvent(0xb033)]
        public void JobRemoved(Guid parentJobId, Guid childJobId, Guid workflowId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 31138, 31344);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 31265, 31333);

                f_1060_31265_31332(this, M3PJobRemovedEvent, parentJobId, childJobId, workflowId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 31138, 31344);

                int
                f_1060_31265_31332(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 31265, 31332);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 31138, 31344);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 31138, 31344);
            }
        }

        [EtwEvent(0xb034)]
        public void JobRemoveError(Guid parentJobId, Guid childJobId, Guid workflowId, string error)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 31456, 31691);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 31601, 31680);

                f_1060_31601_31679(this, M3PJobRemoveErrorEvent, parentJobId, childJobId, workflowId, error);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 31456, 31691);

                int
                f_1060_31601_31679(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 31601, 31679);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 31456, 31691);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 31456, 31691);
            }
        }

        [EtwEvent(0xb02d)]
        public void JobStateChanged(int jobId, Guid workflowId, string newState, string oldState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 31804, 32032);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 31946, 32021);

                f_1060_31946_32020(this, M3PJobStateChangedEvent, jobId, workflowId, newState, oldState);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 31804, 32032);

                int
                f_1060_31946_32020(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 31946, 32020);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 31804, 32032);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 31804, 32032);
            }
        }

        [EtwEvent(0xb035)]
        public void LoadingWorkflowForExecution(Guid workflowId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 32157, 32337);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 32266, 32326);

                f_1060_32266_32325(this, M3PLoadingWorkflowForExecutionEvent, workflowId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 32157, 32337);

                int
                f_1060_32266_32325(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 32266, 32325);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 32157, 32337);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 32157, 32337);
            }
        }

        [EtwEvent(0xb046)]
        public void OutOfProcessRunspaceStarted(string command)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 32462, 32638);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 32570, 32627);

                f_1060_32570_32626(this, M3POutOfProcessRunspaceStartedEvent, command);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 32462, 32638);

                int
                f_1060_32570_32626(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 32570, 32626);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 32462, 32638);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 32462, 32638);
            }
        }

        [EtwEvent(0xb047)]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        public void ParameterSplattingWasPerformed(string parameters, string computers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 32766, 33076);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 32991, 33065);

                f_1060_32991_33064(this, M3PParameterSplattingWasPerformedEvent, parameters, computers);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 32766, 33076);

                int
                f_1060_32991_33064(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 32991, 33064);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 32766, 33076);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 32766, 33076);
            }
        }

        [EtwEvent(0xb031)]
        public void ParentJobCreated(Guid jobId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 33190, 33338);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 33283, 33327);

                f_1060_33283_33326(this, M3PParentJobCreatedEvent, jobId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 33190, 33338);

                int
                f_1060_33283_33326(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 33283, 33326);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 33190, 33338);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 33190, 33338);
            }
        }

        [EtwEvent(0xb516)]
        public void PersistenceStoreMaxSizeReached()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 33466, 33625);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 33563, 33614);

                f_1060_33563_33613(this, M3PPersistenceStoreMaxSizeReachedEvent);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 33466, 33625);

                int
                f_1060_33563_33613(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 33563, 33613);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 33466, 33625);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 33466, 33625);
            }
        }

        [EtwEvent(0xb03d)]
        public void PersistingWorkflow(Guid workflowId, string persistPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 33741, 33936);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 33861, 33925);

                f_1060_33861_33924(this, M3PPersistingWorkflowEvent, workflowId, persistPath);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 33741, 33936);

                int
                f_1060_33861_33924(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 33861, 33924);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 33741, 33936);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 33741, 33936);
            }
        }

        [EtwEvent(0xb50b)]
        public void ProxyJobRemoteJobAssociation(Guid proxyJobInstanceId, Guid containerParentJobInstanceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 34062, 34325);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 34215, 34314);

                f_1060_34215_34313(this, M3PProxyJobRemoteJobAssociationEvent, proxyJobInstanceId, containerParentJobInstanceId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 34062, 34325);

                int
                f_1060_34215_34313(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 34215, 34313);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 34062, 34325);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 34062, 34325);
            }
        }

        [EtwEvent(0xb02c)]
        public void RemoveJobStarted(Guid jobId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 34439, 34587);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 34532, 34576);

                f_1060_34532_34575(this, M3PRemoveJobStartedEvent, jobId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 34439, 34587);

                int
                f_1060_34532_34575(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 34532, 34575);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 34439, 34587);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 34439, 34587);
            }
        }

        [EtwEvent(0xb022)]
        public void RunspaceAvailabilityChanged(string runspaceId, string availability)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 34712, 34929);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 34844, 34918);

                f_1060_34844_34917(this, M3PRunspaceAvailabilityChangedEvent, runspaceId, availability);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 34712, 34929);

                int
                f_1060_34844_34917(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 34844, 34917);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 34712, 34929);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 34712, 34929);
            }
        }

        [EtwEvent(0xb023)]
        public void RunspaceStateChanged(string runspaceId, string newState, string oldState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 35047, 35269);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 35185, 35258);

                f_1060_35185_35257(this, M3PRunspaceStateChangedEvent, runspaceId, newState, oldState);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 35047, 35269);

                int
                f_1060_35185_35257(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 35185, 35257);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 35047, 35269);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 35047, 35269);
            }
        }

        [EtwEvent(0xb505)]
        public void TrackingGuidContainerParentJobCorrelation(Guid trackingId, Guid containerParentJobInstanceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 35408, 35681);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 35566, 35670);

                f_1060_35566_35669(this, M3PTrackingGuidContainerParentJobCorrelationEvent, trackingId, containerParentJobInstanceId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 35408, 35681);

                int
                f_1060_35566_35669(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 35566, 35669);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 35408, 35681);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 35408, 35681);
            }
        }

        [EtwEvent(0xb039)]
        public void UnloadingWorkflow(Guid workflowId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 35796, 35956);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 35895, 35945);

                f_1060_35895_35944(this, M3PUnloadingWorkflowEvent, workflowId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 35796, 35956);

                int
                f_1060_35895_35944(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 35895, 35944);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 35796, 35956);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 35796, 35956);
            }
        }

        [EtwEvent(0xb021)]
        public void WorkflowActivityExecutionFailed(Guid workflowId, string activityName, string failureDescription)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 36085, 36355);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 36246, 36344);

                f_1060_36246_36343(this, M3PWorkflowActivityExecutionFailedEvent, workflowId, activityName, failureDescription);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 36085, 36355);

                int
                f_1060_36246_36343(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 36246, 36343);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 36085, 36355);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 36085, 36355);
            }
        }

        [EtwEvent(0xb01f)]
        public void WorkflowActivityValidated(Guid workflowId, string activityDisplayName, string activityType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 36478, 36738);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 36634, 36727);

                f_1060_36634_36726(this, M3PWorkflowActivityValidatedEvent, workflowId, activityDisplayName, activityType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 36478, 36738);

                int
                f_1060_36634_36726(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 36634, 36726);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 36478, 36738);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 36478, 36738);
            }
        }

        [EtwEvent(0xb020)]
        public void WorkflowActivityValidationFailed(Guid workflowId, string activityDisplayName, string activityType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 36868, 37142);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 37031, 37131);

                f_1060_37031_37130(this, M3PWorkflowActivityValidationFailedEvent, workflowId, activityDisplayName, activityType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 36868, 37142);

                int
                f_1060_37031_37130(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 37031, 37130);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 36868, 37142);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 36868, 37142);
            }
        }

        [EtwEvent(0xb028)]
        public void WorkflowCleanupPerformed(Guid workflowId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 37264, 37438);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 37370, 37427);

                f_1060_37370_37426(this, M3PWorkflowCleanupPerformedEvent, workflowId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 37264, 37438);

                int
                f_1060_37370_37426(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 37370, 37426);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 37264, 37438);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 37264, 37438);
            }
        }

        [EtwEvent(0xb02a)]
        public void WorkflowDeletedFromDisk(Guid workflowId, string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 37559, 37750);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 37677, 37739);

                f_1060_37677_37738(this, M3PWorkflowDeletedFromDiskEvent, workflowId, path);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 37559, 37750);

                int
                f_1060_37677_37738(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 37677, 37738);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 37559, 37750);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 37559, 37750);
            }
        }

        [EtwEvent(0xb048)]
        public void WorkflowEngineStarted(string endpointName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 37869, 38043);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 37976, 38032);

                f_1060_37976_38031(this, M3PWorkflowEngineStartedEvent, endpointName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 37869, 38043);

                int
                f_1060_37976_38031(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 37976, 38031);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 37869, 38043);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 37869, 38043);
            }
        }

        [EtwEvent(0xb027)]
        public void WorkflowExecutionAborted(Guid workflowId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 38165, 38339);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 38271, 38328);

                f_1060_38271_38327(this, M3PWorkflowExecutionAbortedEvent, workflowId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 38165, 38339);

                int
                f_1060_38271_38327(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 38271, 38327);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 38165, 38339);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 38165, 38339);
            }
        }

        [EtwEvent(0xb026)]
        public void WorkflowExecutionCancelled(Guid workflowId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 38463, 38641);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 38571, 38630);

                f_1060_38571_38629(this, M3PWorkflowExecutionCancelledEvent, workflowId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 38463, 38641);

                int
                f_1060_38571_38629(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 38571, 38629);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 38463, 38641);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 38463, 38641);
            }
        }

        [EtwEvent(0xb040)]
        public void WorkflowExecutionError(Guid workflowId, string errorDescription)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 38761, 38974);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 38890, 38963);

                f_1060_38890_38962(this, M3PWorkflowExecutionErrorEvent, workflowId, errorDescription);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 38761, 38974);

                int
                f_1060_38890_38962(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 38890, 38962);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 38761, 38974);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 38761, 38974);
            }
        }

        [EtwEvent(0xb036)]
        public void WorkflowExecutionFinished(Guid workflowId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 39097, 39273);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 39204, 39262);

                f_1060_39204_39261(this, M3PWorkflowExecutionFinishedEvent, workflowId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 39097, 39273);

                int
                f_1060_39204_39261(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 39204, 39261);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 39097, 39273);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 39097, 39273);
            }
        }

        [EtwEvent(0xb008)]
        public void WorkflowExecutionStarted(Guid workflowId, string managedNodes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 39395, 39604);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 39522, 39593);

                f_1060_39522_39592(this, M3PWorkflowExecutionStartedEvent, workflowId, managedNodes);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 39395, 39604);

                int
                f_1060_39522_39592(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 39522, 39592);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 39395, 39604);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 39395, 39604);
            }
        }

        [EtwEvent(0xb030)]
        public void WorkflowJobCreated(Guid parentJobId, Guid childJobId, Guid childWorkflowId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 39720, 39952);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 39860, 39941);

                f_1060_39860_39940(this, M3PWorkflowJobCreatedEvent, parentJobId, childJobId, childWorkflowId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 39720, 39952);

                int
                f_1060_39860_39940(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 39860, 39940);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 39720, 39952);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 39720, 39952);
            }
        }

        [EtwEvent(0xb024)]
        public void WorkflowLoadedForExecution(Guid workflowId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 40076, 40254);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 40184, 40243);

                f_1060_40184_40242(this, M3PWorkflowLoadedForExecutionEvent, workflowId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 40076, 40254);

                int
                f_1060_40184_40242(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 40184, 40242);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 40076, 40254);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 40076, 40254);
            }
        }

        [EtwEvent(0xb029)]
        public void WorkflowLoadedFromDisk(Guid workflowId, string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 40374, 40563);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 40491, 40552);

                f_1060_40491_40551(this, M3PWorkflowLoadedFromDiskEvent, workflowId, path);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 40374, 40563);

                int
                f_1060_40491_40551(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 40491, 40551);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 40374, 40563);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 40374, 40563);
            }
        }

        [EtwEvent(0xb049)]
        public void WorkflowManagerCheckpoint(string checkpointPath, string configProviderId, string userName, string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 40686, 40961);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 40854, 40950);

                f_1060_40854_40949(this, M3PWorkflowManagerCheckpointEvent, checkpointPath, configProviderId, userName, path);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 40686, 40961);

                int
                f_1060_40854_40949(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 40854, 40949);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 40686, 40961);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 40686, 40961);
            }
        }

        [EtwEvent(0xb03e)]
        public void WorkflowPersisted(Guid workflowId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 41076, 41236);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 41175, 41225);

                f_1060_41175_41224(this, M3PWorkflowPersistedEvent, workflowId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 41076, 41236);

                int
                f_1060_41175_41224(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 41175, 41224);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 41076, 41236);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 41076, 41236);
            }
        }

        [EtwEvent(0xb010)]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        public void WorkflowPluginRequestedToShutdown(string endpointName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 41367, 41658);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 41579, 41647);

                f_1060_41579_41646(this, M3PWorkflowPluginRequestedToShutdownEvent, endpointName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 41367, 41658);

                int
                f_1060_41579_41646(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 41579, 41646);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 41367, 41658);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 41367, 41658);
            }
        }

        [EtwEvent(0xb011)]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        public void WorkflowPluginRestarted(string endpointName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 41779, 42050);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 41981, 42039);

                f_1060_41981_42038(this, M3PWorkflowPluginRestartedEvent, endpointName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 41779, 42050);

                int
                f_1060_41981_42038(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 41981, 42038);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 41779, 42050);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 41779, 42050);
            }
        }

        [EtwEvent(0xb007)]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        public void WorkflowPluginStarted(string endpointName, string user, string hostingMode, string protocol, string configuration)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 42169, 42552);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 42441, 42541);

                f_1060_42441_42540(this, M3PWorkflowPluginStartedEvent, endpointName, user, hostingMode, protocol, configuration);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 42169, 42552);

                int
                f_1060_42441_42540(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 42441, 42540);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 42169, 42552);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 42169, 42552);
            }
        }

        [EtwEvent(0xb013)]
        public void WorkflowQuotaViolated(string endpointName, string configName, string allowedValue, string valueInQuestion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 42671, 42952);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 42842, 42941);

                f_1060_42842_42940(this, M3PWorkflowQuotaViolatedEvent, endpointName, configName, allowedValue, valueInQuestion);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 42671, 42952);

                int
                f_1060_42842_42940(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 42842, 42940);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 42671, 42952);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 42671, 42952);
            }
        }

        [EtwEvent(0xb014)]
        public void WorkflowResumed(Guid workflowId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 43065, 43221);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 43162, 43210);

                f_1060_43162_43209(this, M3PWorkflowResumedEvent, workflowId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 43065, 43221);

                int
                f_1060_43162_43209(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 43162, 43209);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 43065, 43221);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 43065, 43221);
            }
        }

        [EtwEvent(0xb012)]
        public void WorkflowResuming(Guid workflowId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 43335, 43493);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 43433, 43482);

                f_1060_43433_43481(this, M3PWorkflowResumingEvent, workflowId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 43335, 43493);

                int
                f_1060_43433_43481(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 43433, 43481);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 43335, 43493);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 43335, 43493);
            }
        }

        [EtwEvent(0xb016)]
        public void WorkflowRunspacePoolCreated(Guid workflowId, string managedNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 43618, 43831);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 43747, 43820);

                f_1060_43747_43819(this, M3PWorkflowRunspacePoolCreatedEvent, workflowId, managedNode);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 43618, 43831);

                int
                f_1060_43747_43819(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 43747, 43819);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 43618, 43831);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 43618, 43831);
            }
        }

        [EtwEvent(0xb009)]
        public void WorkflowStateChanged(Guid workflowId, string newState, string oldState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 43949, 44169);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 44085, 44158);

                f_1060_44085_44157(this, M3PWorkflowStateChangedEvent, workflowId, newState, oldState);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 43949, 44169);

                int
                f_1060_44085_44157(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 44085, 44157);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 43949, 44169);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 43949, 44169);
            }
        }

        [EtwEvent(0xb025)]
        public void WorkflowUnloaded(Guid workflowId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 44283, 44441);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 44381, 44430);

                f_1060_44381_44429(this, M3PWorkflowUnloadedEvent, workflowId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 44283, 44441);

                int
                f_1060_44381_44429(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 44381, 44429);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 44283, 44441);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 44283, 44441);
            }
        }

        [EtwEvent(0xb01e)]
        public void WorkflowValidationError(Guid workflowId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 44562, 44734);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 44667, 44723);

                f_1060_44667_44722(this, M3PWorkflowValidationErrorEvent, workflowId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 44562, 44734);

                int
                f_1060_44667_44722(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 44667, 44722);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 44562, 44734);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 44562, 44734);
            }
        }

        [EtwEvent(0xb01d)]
        public void WorkflowValidationFinished(Guid workflowId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 44858, 45036);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 44966, 45025);

                f_1060_44966_45024(this, M3PWorkflowValidationFinishedEvent, workflowId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 44858, 45036);

                int
                f_1060_44966_45024(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 44966, 45024);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 44858, 45036);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 44858, 45036);
            }
        }

        [EtwEvent(0xb01c)]
        public void WorkflowValidationStarted(Guid workflowId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1060, 45159, 45335);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1060, 45266, 45324);

                f_1060_45266_45323(this, M3PWorkflowValidationStartedEvent, workflowId);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1060, 45159, 45335);

                int
                f_1060_45266_45323(System.Management.Automation.Tracing.Tracer
                this_param, System.Diagnostics.Eventing.EventDescriptor
                ed, params object[]
                payload)
                {
                    this_param.WriteEvent(ed, payload);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 45266, 45323);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1060, 45159, 45335);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1060, 45159, 45335);
            }
        }

        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_7369_7449(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 7369, 7449);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_7488_7567(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 7488, 7567);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_7622_7702(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 7622, 7702);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_7757_7837(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 7757, 7837);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_7890_7970(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 7890, 7970);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_8024_8104(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 8024, 8104);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_8166_8245(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 8166, 8245);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_8292_8371(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 8292, 8371);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_8414_8493(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 8414, 8493);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_8553_8632(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 8553, 8632);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_8687_8766(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 8687, 8766);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_8818_8897(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 8818, 8897);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_8952_9031(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 8952, 9031);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_9090_9169(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 9090, 9169);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_9221_9300(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 9221, 9300);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_9357_9437(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 9357, 9437);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_9491_9570(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 9491, 9570);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_9630_9709(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 9630, 9709);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_9754_9833(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 9754, 9833);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_9874_9953(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 9874, 9953);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_9999_10079(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 9999, 10079);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_10124_10204(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 10124, 10204);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_10250_10330(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 10250, 10330);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_10378_10458(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 10378, 10458);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_10508_10588(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 10508, 10588);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_10646_10725(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 10646, 10725);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_10778_10857(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 10778, 10857);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_10907_10986(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 10907, 10986);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_11039_11118(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 11039, 11118);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_11175_11254(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 11175, 11254);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_11304_11383(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 11304, 11383);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_11443_11523(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 11443, 11523);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_11580_11660(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 11580, 11660);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_11720_11800(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 11720, 11800);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_11859_11939(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 11859, 11939);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_11993_12073(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 11993, 12073);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_12128_12208(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 12128, 12208);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_12257_12337(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 12257, 12337);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_12375_12455(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 12375, 12455);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_12495_12575(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 12495, 12575);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_12619_12699(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 12619, 12699);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_12744_12824(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 12744, 12824);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_12881_12961(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 12881, 12961);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_13018_13098(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 13018, 13098);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_13158_13238(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 13158, 13238);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_13284_13364(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 13284, 13364);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_13424_13503(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, ulong
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, (long)keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 13424, 13503);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_13551_13631(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 13551, 13631);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_13689_13768(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 13689, 13768);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_13814_13894(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 13814, 13894);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_13951_14031(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 13951, 14031);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_14081_14161(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 14081, 14161);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_14232_14311(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 14232, 14311);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_14358_14438(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 14358, 14438);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_14499_14579(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 14499, 14579);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_14634_14714(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 14634, 14714);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_14776_14856(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 14776, 14856);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_14910_14990(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 14910, 14990);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_15043_15123(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 15043, 15123);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_15174_15254(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 15174, 15254);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_15308_15388(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 15308, 15388);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_15444_15524(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 15444, 15524);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_15576_15656(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 15576, 15656);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_15711_15791(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 15711, 15791);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_15845_15925(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 15845, 15925);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_15973_16053(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 15973, 16053);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_16109_16189(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 16109, 16189);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_16241_16321(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 16241, 16321);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_16376_16455(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 16376, 16455);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_16502_16582(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 16502, 16582);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_16645_16725(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 16645, 16725);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_16778_16858(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 16778, 16858);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_16909_16989(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 16909, 16989);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_17040_17120(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 17040, 17120);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_17165_17245(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 17165, 17245);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_17291_17371(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 17291, 17371);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_17428_17508(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 17428, 17508);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_17558_17638(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 17558, 17638);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_17684_17764(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 17684, 17764);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_17817_17897(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 17817, 17897);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_17953_18033(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 17953, 18033);
            return return_v;
        }


        static System.Diagnostics.Eventing.EventDescriptor
        f_1060_18088_18168(int
        id, int
        version, int
        channel, int
        level, int
        opcode, int
        task, long
        keywords)
        {
            var return_v = new System.Diagnostics.Eventing.EventDescriptor(id, (byte)version, (byte)channel, (byte)level, (byte)opcode, task, keywords);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1060, 18088, 18168);
            return return_v;
        }

    }
}

// This code was generated on 02/01/2012 19:52:32

