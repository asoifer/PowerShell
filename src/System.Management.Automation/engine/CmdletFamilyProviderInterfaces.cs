// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Management.Automation.Internal;

using Dbg = System.Management.Automation;

namespace System.Management.Automation
{
    public sealed class ProviderIntrinsics
    {
        private ProviderIntrinsics()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1241, 655, 906);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1241, 2932, 2981);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1241, 3137, 3196);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1241, 3350, 3405);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1241, 3560, 3617);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1241, 3782, 3859);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1241, 3964, 3971);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1241, 708, 895);

                f_1241_708_894(false, "This constructor should never be called. Only the constructor that takes an instance of SessionState should be called.");
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1241, 655, 906);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1241, 655, 906);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1241, 655, 906);
            }
        }

        internal ProviderIntrinsics(Cmdlet cmdlet)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1241, 1261, 1856);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1241, 2932, 2981);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1241, 3137, 3196);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1241, 3350, 3405);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1241, 3560, 3617);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1241, 3782, 3859);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1241, 3964, 3971);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1241, 1328, 1450) || true) && (cmdlet == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1241, 1328, 1450);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1241, 1380, 1435);

                    throw f_1241_1386_1434("cmdlet");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1241, 1328, 1450);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1241, 1466, 1483);

                _cmdlet = cmdlet;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1241, 1497, 1545);

                Item = f_1241_1504_1544(cmdlet);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1241, 1559, 1617);

                ChildItem = f_1241_1571_1616(cmdlet);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1241, 1631, 1685);

                Content = f_1241_1641_1684(cmdlet);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1241, 1699, 1755);

                Property = f_1241_1710_1754(cmdlet);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1241, 1769, 1845);

                SecurityDescriptor = f_1241_1790_1844(cmdlet);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1241, 1261, 1856);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1241, 1261, 1856);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1241, 1261, 1856);
            }
        }

        internal ProviderIntrinsics(SessionStateInternal sessionState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1241, 2086, 2712);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1241, 2932, 2981);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1241, 3137, 3196);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1241, 3350, 3405);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1241, 3560, 3617);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1241, 3782, 3859);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1241, 3964, 3971);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1241, 2173, 2307) || true) && (sessionState == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1241, 2173, 2307);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1241, 2231, 2292);

                    throw f_1241_2237_2291("sessionState");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1241, 2173, 2307);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1241, 2323, 2377);

                Item = f_1241_2330_2376(sessionState);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1241, 2391, 2455);

                ChildItem = f_1241_2403_2454(sessionState);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1241, 2469, 2529);

                Content = f_1241_2479_2528(sessionState);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1241, 2543, 2605);

                Property = f_1241_2554_2604(sessionState);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1241, 2619, 2701);

                SecurityDescriptor = f_1241_2640_2700(sessionState);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1241, 2086, 2712);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1241, 2086, 2712);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1241, 2086, 2712);
            }
        }

        public ItemCmdletProviderIntrinsics Item { get; }

        public ChildItemCmdletProviderIntrinsics ChildItem { get; }

        public ContentCmdletProviderIntrinsics Content { get; }

        public PropertyCmdletProviderIntrinsics Property { get; }

        public SecurityDescriptorCmdletProviderIntrinsics SecurityDescriptor { get; }

        private InternalCommand _cmdlet;

        static ProviderIntrinsics()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1241, 426, 4014);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1241, 426, 4014);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1241, 426, 4014);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1241, 426, 4014);

        int
        f_1241_708_894(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1241, 708, 894);
            return 0;
        }


        System.Management.Automation.PSArgumentNullException
        f_1241_1386_1434(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1241, 1386, 1434);
            return return_v;
        }


        System.Management.Automation.ItemCmdletProviderIntrinsics
        f_1241_1504_1544(System.Management.Automation.Cmdlet
        cmdlet)
        {
            var return_v = new System.Management.Automation.ItemCmdletProviderIntrinsics(cmdlet);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1241, 1504, 1544);
            return return_v;
        }


        System.Management.Automation.ChildItemCmdletProviderIntrinsics
        f_1241_1571_1616(System.Management.Automation.Cmdlet
        cmdlet)
        {
            var return_v = new System.Management.Automation.ChildItemCmdletProviderIntrinsics(cmdlet);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1241, 1571, 1616);
            return return_v;
        }


        System.Management.Automation.ContentCmdletProviderIntrinsics
        f_1241_1641_1684(System.Management.Automation.Cmdlet
        cmdlet)
        {
            var return_v = new System.Management.Automation.ContentCmdletProviderIntrinsics(cmdlet);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1241, 1641, 1684);
            return return_v;
        }


        System.Management.Automation.PropertyCmdletProviderIntrinsics
        f_1241_1710_1754(System.Management.Automation.Cmdlet
        cmdlet)
        {
            var return_v = new System.Management.Automation.PropertyCmdletProviderIntrinsics(cmdlet);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1241, 1710, 1754);
            return return_v;
        }


        System.Management.Automation.SecurityDescriptorCmdletProviderIntrinsics
        f_1241_1790_1844(System.Management.Automation.Cmdlet
        cmdlet)
        {
            var return_v = new System.Management.Automation.SecurityDescriptorCmdletProviderIntrinsics(cmdlet);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1241, 1790, 1844);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1241_2237_2291(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1241, 2237, 2291);
            return return_v;
        }


        System.Management.Automation.ItemCmdletProviderIntrinsics
        f_1241_2330_2376(System.Management.Automation.SessionStateInternal
        sessionState)
        {
            var return_v = new System.Management.Automation.ItemCmdletProviderIntrinsics(sessionState);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1241, 2330, 2376);
            return return_v;
        }


        System.Management.Automation.ChildItemCmdletProviderIntrinsics
        f_1241_2403_2454(System.Management.Automation.SessionStateInternal
        sessionState)
        {
            var return_v = new System.Management.Automation.ChildItemCmdletProviderIntrinsics(sessionState);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1241, 2403, 2454);
            return return_v;
        }


        System.Management.Automation.ContentCmdletProviderIntrinsics
        f_1241_2479_2528(System.Management.Automation.SessionStateInternal
        sessionState)
        {
            var return_v = new System.Management.Automation.ContentCmdletProviderIntrinsics(sessionState);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1241, 2479, 2528);
            return return_v;
        }


        System.Management.Automation.PropertyCmdletProviderIntrinsics
        f_1241_2554_2604(System.Management.Automation.SessionStateInternal
        sessionState)
        {
            var return_v = new System.Management.Automation.PropertyCmdletProviderIntrinsics(sessionState);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1241, 2554, 2604);
            return return_v;
        }


        System.Management.Automation.SecurityDescriptorCmdletProviderIntrinsics
        f_1241_2640_2700(System.Management.Automation.SessionStateInternal
        sessionState)
        {
            var return_v = new System.Management.Automation.SecurityDescriptorCmdletProviderIntrinsics(sessionState);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1241, 2640, 2700);
            return return_v;
        }

    }
}

