// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace System.Management.Automation.Remoting.WSMan
{
    public static class WSManServerChannelEvents
    {
        /// <summary>
        /// Event raised when shutting down WSMan server.
        /// </summary>
        public static event EventHandler
ShuttingDown
;

        /// <summary>
        /// Event raised when active sessions in an endpoint are changed.
        /// </summary>
        public static event EventHandler<ActiveSessionsChangedEventArgs>
ActiveSessionsChanged
;

        internal static void RaiseShuttingDownEvent()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1660, 976, 1206);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1660, 1046, 1082);

                EventHandler
                handler = ShuttingDown
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1660, 1096, 1195) || true) && (handler != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1660, 1096, 1195);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1660, 1149, 1180);

                    f_1660_1149_1179(handler, null, EventArgs.Empty);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1660, 1096, 1195);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1660, 976, 1206);

                int
                f_1660_1149_1179(System.EventHandler
                this_param, object?
                sender, System.EventArgs
                e)
                {
                    this_param.Invoke(sender, e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1660, 1149, 1179);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1660, 976, 1206);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1660, 976, 1206);
            }
        }

        internal static void RaiseActiveSessionsChangedEvent(ActiveSessionsChangedEventArgs eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1660, 1315, 1629);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1660, 1434, 1511);

                EventHandler<ActiveSessionsChangedEventArgs>
                handler = ActiveSessionsChanged
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1660, 1525, 1618) || true) && (handler != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1660, 1525, 1618);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1660, 1578, 1603);

                    f_1660_1578_1602(handler, null, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1660, 1525, 1618);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1660, 1315, 1629);

                int
                f_1660_1578_1602(System.EventHandler<System.Management.Automation.Remoting.WSMan.ActiveSessionsChangedEventArgs>
                this_param, object?
                sender, System.Management.Automation.Remoting.WSMan.ActiveSessionsChangedEventArgs
                e)
                {
                    this_param.Invoke(sender, e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1660, 1578, 1602);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1660, 1315, 1629);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1660, 1315, 1629);
            }
        }

        static WSManServerChannelEvents()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1660, 321, 1675);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1660, 321, 1675);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1660, 321, 1675);
        }

    }
    public sealed class ActiveSessionsChangedEventArgs : EventArgs
    {
        public ActiveSessionsChangedEventArgs(int activeSessionsCount)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1660, 2043, 2183);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1660, 2276, 2373);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1660, 2130, 2172);

                ActiveSessionsCount = activeSessionsCount;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1660, 2043, 2183);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1660, 2043, 2183);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1660, 2043, 2183);
            }
        }

        public int ActiveSessionsCount
        {
            get;
            internal set;
        }

        static ActiveSessionsChangedEventArgs()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1660, 1793, 2380);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1660, 1793, 2380);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1660, 1793, 2380);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1660, 1793, 2380);
    }
}
