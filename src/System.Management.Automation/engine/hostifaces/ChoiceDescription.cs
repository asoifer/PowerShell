// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation.Host
{
    public sealed
        class ChoiceDescription
    {
        private readonly string label;

        private string helpMessage;

        public
                ChoiceDescription(string label)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1453, 1220, 1626);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1453, 704, 716);
                this.label = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1453, 742, 768);
                this.helpMessage = string.Empty;
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1453, 1348, 1580) || true) && (f_1453_1352_1379(label))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1453, 1348, 1580);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1453, 1460, 1565);

                    throw f_1453_1466_1564("label", f_1453_1510_1554(), "label");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1453, 1348, 1580);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1453, 1596, 1615);

                this.label = label;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1453, 1220, 1626);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1453, 1220, 1626);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1453, 1220, 1626);
            }
        }

        public
                ChoiceDescription(string label, string helpMessage)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1453, 2345, 3017);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1453, 704, 716);
                this.label = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1453, 742, 768);
                this.helpMessage = string.Empty;
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1453, 2493, 2725) || true) && (f_1453_2497_2524(label))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1453, 2493, 2725);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1453, 2605, 2710);

                    throw f_1453_2611_2709("label", f_1453_2655_2699(), "label");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1453, 2493, 2725);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1453, 2741, 2926) || true) && (helpMessage == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1453, 2741, 2926);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1453, 2851, 2911);

                    throw f_1453_2857_2910("helpMessage");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1453, 2741, 2926);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1453, 2942, 2961);

                this.label = label;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1453, 2975, 3006);

                this.helpMessage = helpMessage;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1453, 2345, 3017);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1453, 2345, 3017);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1453, 2345, 3017);
            }
        }

        public
                string
                Label
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1453, 3965, 4113);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1453, 4001, 4060);

                    f_1453_4001_4059(this.label != null, "label should not be null");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1453, 4080, 4098);

                    return this.label;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1453, 3965, 4113);

                    int
                    f_1453_4001_4059(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Dbg.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1453, 4001, 4059);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1453, 3903, 4124);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1453, 3903, 4124);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public
                string
                HelpMessage
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1453, 4689, 4855);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1453, 4725, 4796);

                    f_1453_4725_4795(this.helpMessage != null, "helpMessage should not be null");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1453, 4816, 4840);

                    return this.helpMessage;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1453, 4689, 4855);

                    int
                    f_1453_4725_4795(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Dbg.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1453, 4725, 4795);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1453, 4621, 5110);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1453, 4621, 5110);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1453, 4871, 5099);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1453, 4907, 5039) || true) && (value == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1453, 4907, 5039);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1453, 4966, 5020);

                        throw f_1453_4972_5019("value");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1453, 4907, 5039);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1453, 5059, 5084);

                    this.helpMessage = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1453, 4871, 5099);

                    System.Management.Automation.PSArgumentNullException
                    f_1453_4972_5019(string
                    paramName)
                    {
                        var return_v = PSTraceSource.NewArgumentNullException(paramName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1453, 4972, 5019);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1453, 4621, 5110);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1453, 4621, 5110);
                }
            }
        }

        static ChoiceDescription()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1453, 464, 5117);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1453, 464, 5117);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1453, 464, 5117);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1453, 464, 5117);

        bool
        f_1453_1352_1379(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1453, 1352, 1379);
            return return_v;
        }


        string
        f_1453_1510_1554()
        {
            var return_v = DescriptionsStrings.NullOrEmptyErrorTemplate;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1453, 1510, 1554);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1453_1466_1564(string
        paramName, string
        resourceString, params object[]
        args)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1453, 1466, 1564);
            return return_v;
        }


        bool
        f_1453_2497_2524(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1453, 2497, 2524);
            return return_v;
        }


        string
        f_1453_2655_2699()
        {
            var return_v = DescriptionsStrings.NullOrEmptyErrorTemplate;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1453, 2655, 2699);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1453_2611_2709(string
        paramName, string
        resourceString, params object[]
        args)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1453, 2611, 2709);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1453_2857_2910(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1453, 2857, 2910);
            return return_v;
        }

    }
}

