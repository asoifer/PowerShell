// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Management.Automation.Internal;

namespace System.Management.Automation
{
    internal sealed class NativeCommand : InternalCommand
    {
        private NativeCommandProcessor _myCommandProcessor;

        internal NativeCommandProcessor MyCommandProcessor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1298, 494, 529);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1298, 500, 527);

                    return _myCommandProcessor;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1298, 494, 529);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1298, 419, 592);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1298, 419, 592);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1298, 545, 581);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1298, 551, 579);

                    _myCommandProcessor = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1298, 545, 581);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1298, 419, 592);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1298, 419, 592);
                }
            }
        }

        internal override void DoStopProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1298, 720, 1000);
                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1298, 822, 913) || true) && (_myCommandProcessor != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1298, 822, 913);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1298, 876, 913);

                        f_1298_876_912(_myCommandProcessor);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1298, 822, 913);
                    }
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1298, 942, 989);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1298, 942, 989);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1298, 720, 1000);

                int
                f_1298_876_912(System.Management.Automation.NativeCommandProcessor
                this_param)
                {
                    this_param.StopProcessing();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1298, 876, 912);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1298, 720, 1000);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1298, 720, 1000);
            }
        }

        public NativeCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1298, 288, 1007);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1298, 389, 408);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1298, 288, 1007);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1298, 288, 1007);
        }


        static NativeCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1298, 288, 1007);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1298, 288, 1007);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1298, 288, 1007);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1298, 288, 1007);
    }
}
