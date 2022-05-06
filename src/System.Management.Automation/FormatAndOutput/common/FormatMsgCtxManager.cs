// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;

namespace Microsoft.PowerShell.Commands.Internal.Format
{
    internal class FormatMessagesContextManager
    {        // callbacks declarations
        internal delegate OutputContext FormatContextCreationCallback(OutputContext parentContext, FormatInfoData formatData);
        internal delegate void FormatStartCallback(OutputContext c);
        internal delegate void FormatEndCallback(FormatEndData fe, OutputContext c);
        internal delegate void GroupStartCallback(OutputContext c);
        internal delegate void GroupEndCallback(GroupEndData fe, OutputContext c);
        internal delegate void PayloadCallback(FormatEntryData formatEntryData, OutputContext c);

        internal FormatContextCreationCallback contextCreation;

        internal FormatStartCallback fs;

        internal FormatEndCallback fe;

        internal GroupStartCallback gs;

        internal GroupEndCallback ge;

        internal PayloadCallback payload;
        internal abstract class OutputContext
        {
            internal OutputContext(OutputContext parentContextInStack)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1087, 2087, 2230);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1087, 2496, 2541);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1087, 2178, 2215);

                    ParentContext = parentContextInStack;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1087, 2087, 2230);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1087, 2087, 2230);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1087, 2087, 2230);
                }
            }

            internal OutputContext ParentContext { get; }

            static OutputContext()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1087, 1865, 2552);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1087, 1865, 2552);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1087, 1865, 2552);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1087, 1865, 2552);
        }

        internal void Process(object o)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1087, 2811, 5374);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1087, 2867, 2915);

                PacketInfoData
                formatData = o as PacketInfoData
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1087, 2929, 2981);

                FormatEntryData
                fed = formatData as FormatEntryData
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1087, 2995, 5363) || true) && (fed != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1087, 2995, 5363);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1087, 3044, 3069);

                    OutputContext
                    ctx = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1087, 3089, 3188) || true) && (!fed.outOfBand)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1087, 3089, 3188);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1087, 3149, 3169);

                        ctx = f_1087_3155_3168(_stack);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1087, 3089, 3188);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1087, 3246, 3269);

                    f_1087_3246_3268(                //  notify for Payload
                                    this, fed, ctx);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1087, 2995, 5363);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1087, 2995, 5363);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1087, 3335, 3400);

                    bool
                    formatDataIsFormatStartData = formatData is FormatStartData
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1087, 3418, 3481);

                    bool
                    formatDataIsGroupStartData = formatData is GroupStartData
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1087, 3638, 5348) || true) && (formatDataIsFormatStartData || (DynAbs.Tracing.TraceSender.Expression_False(1087, 3642, 3699) || formatDataIsGroupStartData))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1087, 3638, 5348);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1087, 3741, 3819);

                        OutputContext
                        oc = f_1087_3760_3818(this, f_1087_3781_3805(this), formatData)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1087, 3841, 3857);

                        f_1087_3841_3856(_stack, oc);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1087, 4047, 4467) || true) && (formatDataIsFormatStartData)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1087, 4047, 4467);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1087, 4170, 4182);

                            f_1087_4170_4181(                        // notify for Fs
                                                    this, oc);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1087, 4047, 4467);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1087, 4047, 4467);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1087, 4232, 4467) || true) && (formatDataIsGroupStartData)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1087, 4232, 4467);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1087, 4432, 4444);

                                f_1087_4432_4443(                        // GroupStartData gsd = (GroupStartData) formatData;
                                                                         // notify for Gs
                                                        this, oc);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1087, 4232, 4467);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1087, 4047, 4467);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1087, 3638, 5348);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1087, 3638, 5348);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1087, 4549, 4595);

                        GroupEndData
                        ged = formatData as GroupEndData
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1087, 4617, 4667);

                        FormatEndData
                        fEndd = formatData as FormatEndData
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1087, 4689, 5329) || true) && (ged != null || (DynAbs.Tracing.TraceSender.Expression_False(1087, 4693, 4721) || fEndd != null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1087, 4689, 5329);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1087, 4771, 4804);

                            OutputContext
                            oc = f_1087_4790_4803(_stack)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1087, 4830, 5265) || true) && (fEndd != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1087, 4830, 5265);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1087, 4988, 5007);

                                f_1087_4988_5006(                            // notify for Fe, passing the Fe info, before a Pop()
                                                            this, fEndd, oc);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1087, 4830, 5265);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1087, 4830, 5265);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1087, 5065, 5265) || true) && (ged != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1087, 5065, 5265);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1087, 5221, 5238);

                                    f_1087_5221_5237(                            // notify for Fe, passing the Fe info, before a Pop()
                                                                this, ged, oc);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1087, 5065, 5265);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1087, 4830, 5265);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1087, 5293, 5306);

                            f_1087_5293_5305(
                                                    _stack);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1087, 4689, 5329);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1087, 3638, 5348);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1087, 2995, 5363);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1087, 2811, 5374);

                Microsoft.PowerShell.Commands.Internal.Format.FormatMessagesContextManager.OutputContext
                f_1087_3155_3168(System.Collections.Generic.Stack<Microsoft.PowerShell.Commands.Internal.Format.FormatMessagesContextManager.OutputContext>
                this_param)
                {
                    var return_v = this_param.Peek();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1087, 3155, 3168);
                    return return_v;
                }


                int
                f_1087_3246_3268(Microsoft.PowerShell.Commands.Internal.Format.FormatMessagesContextManager
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatEntryData
                formatEntryData, Microsoft.PowerShell.Commands.Internal.Format.FormatMessagesContextManager.OutputContext
                c)
                {
                    this_param.payload(formatEntryData, c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1087, 3246, 3268);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatMessagesContextManager.OutputContext
                f_1087_3781_3805(Microsoft.PowerShell.Commands.Internal.Format.FormatMessagesContextManager
                this_param)
                {
                    var return_v = this_param.ActiveOutputContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1087, 3781, 3805);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatMessagesContextManager.OutputContext
                f_1087_3760_3818(Microsoft.PowerShell.Commands.Internal.Format.FormatMessagesContextManager
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatMessagesContextManager.OutputContext
                parentContext, Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData
                formatData)
                {
                    var return_v = this_param.contextCreation(parentContext, (Microsoft.PowerShell.Commands.Internal.Format.FormatInfoData)formatData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1087, 3760, 3818);
                    return return_v;
                }


                int
                f_1087_3841_3856(System.Collections.Generic.Stack<Microsoft.PowerShell.Commands.Internal.Format.FormatMessagesContextManager.OutputContext>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatMessagesContextManager.OutputContext
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1087, 3841, 3856);
                    return 0;
                }


                int
                f_1087_4170_4181(Microsoft.PowerShell.Commands.Internal.Format.FormatMessagesContextManager
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatMessagesContextManager.OutputContext
                c)
                {
                    this_param.fs(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1087, 4170, 4181);
                    return 0;
                }


                int
                f_1087_4432_4443(Microsoft.PowerShell.Commands.Internal.Format.FormatMessagesContextManager
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatMessagesContextManager.OutputContext
                c)
                {
                    this_param.gs(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1087, 4432, 4443);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatMessagesContextManager.OutputContext
                f_1087_4790_4803(System.Collections.Generic.Stack<Microsoft.PowerShell.Commands.Internal.Format.FormatMessagesContextManager.OutputContext>
                this_param)
                {
                    var return_v = this_param.Peek();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1087, 4790, 4803);
                    return return_v;
                }


                int
                f_1087_4988_5006(Microsoft.PowerShell.Commands.Internal.Format.FormatMessagesContextManager
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatEndData
                fe, Microsoft.PowerShell.Commands.Internal.Format.FormatMessagesContextManager.OutputContext
                c)
                {
                    this_param.fe(fe, c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1087, 4988, 5006);
                    return 0;
                }


                int
                f_1087_5221_5237(Microsoft.PowerShell.Commands.Internal.Format.FormatMessagesContextManager
                this_param, Microsoft.PowerShell.Commands.Internal.Format.GroupEndData
                fe, Microsoft.PowerShell.Commands.Internal.Format.FormatMessagesContextManager.OutputContext
                c)
                {
                    this_param.ge(fe, c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1087, 5221, 5237);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatMessagesContextManager.OutputContext
                f_1087_5293_5305(System.Collections.Generic.Stack<Microsoft.PowerShell.Commands.Internal.Format.FormatMessagesContextManager.OutputContext>
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1087, 5293, 5305);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1087, 2811, 5374);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1087, 2811, 5374);
            }
        }

        internal OutputContext ActiveOutputContext
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1087, 5575, 5632);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1087, 5581, 5630);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1087, 5588, 5606) || (((f_1087_5589_5601(_stack) > 0) && DynAbs.Tracing.TraceSender.Conditional_F2(1087, 5609, 5622)) || DynAbs.Tracing.TraceSender.Conditional_F3(1087, 5625, 5629))) ? f_1087_5609_5622(_stack) : null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1087, 5575, 5632);

                    int
                    f_1087_5589_5601(System.Collections.Generic.Stack<Microsoft.PowerShell.Commands.Internal.Format.FormatMessagesContextManager.OutputContext>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1087, 5589, 5601);
                        return return_v;
                    }


                    Microsoft.PowerShell.Commands.Internal.Format.FormatMessagesContextManager.OutputContext
                    f_1087_5609_5622(System.Collections.Generic.Stack<Microsoft.PowerShell.Commands.Internal.Format.FormatMessagesContextManager.OutputContext>
                    this_param)
                    {
                        var return_v = this_param.Peek();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1087, 5609, 5622);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1087, 5508, 5643);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1087, 5508, 5643);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private Stack<OutputContext> _stack;

        public FormatMessagesContextManager()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1087, 711, 5821);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1087, 1414, 1436);
            this.contextCreation = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1087, 1476, 1485);
            this.fs = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1087, 1523, 1532);
            this.fe = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1087, 1571, 1580);
            this.gs = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1087, 1617, 1626);
            this.ge = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1087, 1662, 1676);
            this.payload = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1087, 5778, 5813);
            this._stack = f_1087_5787_5813();
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1087, 711, 5821);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1087, 711, 5821);
        }


        static FormatMessagesContextManager()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1087, 711, 5821);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1087, 711, 5821);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1087, 711, 5821);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1087, 711, 5821);

        System.Collections.Generic.Stack<Microsoft.PowerShell.Commands.Internal.Format.FormatMessagesContextManager.OutputContext>
        f_1087_5787_5813()
        {
            var return_v = new System.Collections.Generic.Stack<Microsoft.PowerShell.Commands.Internal.Format.FormatMessagesContextManager.OutputContext>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1087, 5787, 5813);
            return return_v;
        }

    }
}
