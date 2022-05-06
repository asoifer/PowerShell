// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Management.Automation.Remoting;

namespace System.Management.Automation
{
    internal abstract class RemoteSession
    {
        internal Guid InstanceId { get; }

        internal abstract RemotingDestination MySelf { get; }

        internal abstract void StartKeyExchange();

        internal abstract void CompleteKeyExchange();

        internal BaseSessionDataStructureHandler BaseSessionDataStructureHandler { get; set; }

        public RemoteSession()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1625, 376, 1065);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1625, 540, 587);
            this.InstanceId = f_1625_576_586();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1625, 938, 1024);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1625, 376, 1065);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1625, 376, 1065);
        }


        static RemoteSession()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1625, 376, 1065);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1625, 376, 1065);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1625, 376, 1065);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1625, 376, 1065);

        System.Guid
        f_1625_576_586()
        {
            var return_v = new System.Guid();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1625, 576, 586);
            return return_v;
        }

    }
}

