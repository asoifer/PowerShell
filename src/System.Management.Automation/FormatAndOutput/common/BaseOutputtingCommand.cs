// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Management.Automation;
using System.Management.Automation.Internal;

namespace Microsoft.PowerShell.Commands.Internal.Format
{
    internal class OutCommandInner : ImplementationCommandBase
    {
        [TraceSource("format_out_OutCommandInner", "OutCommandInner")]
        internal static PSTraceSource tracer;

        internal override void BeginProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1083, 832, 1773);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 897, 920);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.BeginProcessing(), 1083, 897, 919);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 936, 1023);

                _formatObjectDeserializer = f_1083_964_1022(f_1083_993_1021(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 1113, 1232);

                _ctxManager.contextCreation = new FormatMessagesContextManager.FormatContextCreationCallback(this.CreateOutputContext);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 1246, 1341);

                _ctxManager.fs = new FormatMessagesContextManager.FormatStartCallback(this.ProcessFormatStart);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 1355, 1446);

                _ctxManager.fe = new FormatMessagesContextManager.FormatEndCallback(this.ProcessFormatEnd);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 1460, 1553);

                _ctxManager.gs = new FormatMessagesContextManager.GroupStartCallback(this.ProcessGroupStart);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 1567, 1656);

                _ctxManager.ge = new FormatMessagesContextManager.GroupEndCallback(this.ProcessGroupEnd);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 1670, 1762);

                _ctxManager.payload = new FormatMessagesContextManager.PayloadCallback(this.ProcessPayload);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1083, 832, 1773);

                Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                f_1083_993_1021(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                this_param)
                {
                    var return_v = this_param.TerminatingErrorContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 993, 1021);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                f_1083_964_1022(Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                errorContext)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer(errorContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 964, 1022);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 832, 1773);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 832, 1773);
            }
        }

        internal override void ProcessRecord()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1083, 2063, 2787);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 2126, 2158);

                PSObject
                so = f_1083_2140_2157(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 2174, 2244) || true) && (so == null || (DynAbs.Tracing.TraceSender.Expression_False(1083, 2178, 2218) || so == f_1083_2198_2218()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 2174, 2244);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 2237, 2244);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 2174, 2244);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 2302, 2349) || true) && (f_1083_2306_2323(this, so))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 2302, 2349);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 2342, 2349);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 2302, 2349);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 2421, 2457);

                Array
                results = f_1083_2437_2456(this, so)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 2473, 2776) || true) && (results != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 2473, 2776);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 2526, 2761);
                        foreach (object r in f_1083_2547_2554_I(results))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 2526, 2761);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 2596, 2640);

                            PSObject
                            obj = f_1083_2611_2639(r)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 2664, 2699);

                            obj.IsHelpObject = f_1083_2683_2698(so);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 2723, 2742);

                            f_1083_2723_2741(this, obj);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 2526, 2761);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1083, 1, 236);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1083, 1, 236);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 2473, 2776);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1083, 2063, 2787);

                System.Management.Automation.PSObject
                f_1083_2140_2157(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                this_param)
                {
                    var return_v = this_param.ReadObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 2140, 2157);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1083_2198_2218()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 2198, 2218);
                    return return_v;
                }


                bool
                f_1083_2306_2323(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                this_param, System.Management.Automation.PSObject
                so)
                {
                    var return_v = this_param.ProcessObject(so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 2306, 2323);
                    return return_v;
                }


                System.Array
                f_1083_2437_2456(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                this_param, System.Management.Automation.PSObject
                o)
                {
                    var return_v = this_param.ApplyFormatting((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 2437, 2456);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1083_2611_2639(object
                obj)
                {
                    var return_v = PSObjectHelper.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 2611, 2639);
                    return return_v;
                }


                bool
                f_1083_2683_2698(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.IsHelpObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 2683, 2698);
                    return return_v;
                }


                bool
                f_1083_2723_2741(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                this_param, System.Management.Automation.PSObject
                so)
                {
                    var return_v = this_param.ProcessObject(so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 2723, 2741);
                    return return_v;
                }


                System.Array
                f_1083_2547_2554_I(System.Array
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 2547, 2554);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 2063, 2787);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 2063, 2787);
            }
        }

        internal override void EndProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1083, 2799, 3841);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 2862, 2883);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.EndProcessing(), 1083, 2862, 2882);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 2897, 3319) || true) && (_command != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 2897, 3319);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 3023, 3059);

                    Array
                    results = f_1083_3039_3058(_command)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 3079, 3304) || true) && (results != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 3079, 3304);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 3140, 3285);
                            foreach (object o in f_1083_3161_3168_I(results))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 3140, 3285);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 3218, 3262);

                                f_1083_3218_3261(this, f_1083_3232_3260(o));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 3140, 3285);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1083, 1, 146);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1083, 1, 146);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 3079, 3304);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 2897, 3319);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 3335, 3830) || true) && (f_1083_3339_3372(f_1083_3339_3354(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 3335, 3830);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 3527, 3615);

                    LineOutput.DoPlayBackCall
                    playBackCall = new LineOutput.DoPlayBackCall(this.DrainCache)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 3635, 3687);

                    f_1083_3635_3686(f_1083_3635_3650(this), playBackCall);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 3335, 3830);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 3335, 3830);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 3802, 3815);

                    f_1083_3802_3814(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 3335, 3830);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1083, 2799, 3841);

                System.Array
                f_1083_3039_3058(Microsoft.PowerShell.Commands.Internal.Format.CommandWrapper
                this_param)
                {
                    var return_v = this_param.ShutDown();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 3039, 3058);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1083_3232_3260(object
                obj)
                {
                    var return_v = PSObjectHelper.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 3232, 3260);
                    return return_v;
                }


                bool
                f_1083_3218_3261(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                this_param, System.Management.Automation.PSObject
                so)
                {
                    var return_v = this_param.ProcessObject(so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 3218, 3261);
                    return return_v;
                }


                System.Array
                f_1083_3161_3168_I(System.Array
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 3161, 3168);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                f_1083_3339_3354(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                this_param)
                {
                    var return_v = this_param.LineOutput;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 3339, 3354);
                    return return_v;
                }


                bool
                f_1083_3339_3372(Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                this_param)
                {
                    var return_v = this_param.RequiresBuffering;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 3339, 3372);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                f_1083_3635_3650(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                this_param)
                {
                    var return_v = this_param.LineOutput;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 3635, 3650);
                    return return_v;
                }


                int
                f_1083_3635_3686(Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                this_param, Microsoft.PowerShell.Commands.Internal.Format.LineOutput.DoPlayBackCall
                playback)
                {
                    this_param.ExecuteBufferPlayBack(playback);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 3635, 3686);
                    return 0;
                }


                int
                f_1083_3802_3814(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                this_param)
                {
                    this_param.DrainCache();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 3802, 3814);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 2799, 3841);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 2799, 3841);
            }
        }

        private void DrainCache()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1083, 3853, 4352);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 3903, 4341) || true) && (_cache != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 3903, 4341);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 4019, 4076);

                    List<PacketInfoData>
                    unprocessedObjects = f_1083_4061_4075(_cache)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 4096, 4326) || true) && (unprocessedObjects != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 4096, 4326);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 4168, 4307);
                            foreach (object obj in f_1083_4191_4209_I(unprocessedObjects))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 4168, 4307);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 4259, 4284);

                                f_1083_4259_4283(_ctxManager, obj);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 4168, 4307);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1083, 1, 140);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1083, 1, 140);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 4096, 4326);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 3903, 4341);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1083, 3853, 4352);

                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData>
                f_1083_4061_4075(Microsoft.PowerShell.Commands.Internal.Format.FormattedObjectsCache
                this_param)
                {
                    var return_v = this_param.Drain();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 4061, 4075);
                    return return_v;
                }


                int
                f_1083_4259_4283(Microsoft.PowerShell.Commands.Internal.Format.FormatMessagesContextManager
                this_param, object
                o)
                {
                    this_param.Process(o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 4259, 4283);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData>
                f_1083_4191_4209_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 4191, 4209);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 3853, 4352);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 3853, 4352);
            }
        }

        private bool ProcessObject(PSObject so)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1083, 4364, 6723);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 4428, 4481);

                object
                o = f_1083_4439_4480(_formatObjectDeserializer, so)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 4622, 4709) || true) && (f_1083_4626_4647(this, o))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 4622, 4709);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 4681, 4694);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 4622, 4709);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 4779, 4916) || true) && (_cache == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 4779, 4916);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 4831, 4901);

                    _cache = f_1083_4840_4900(f_1083_4866_4899(f_1083_4866_4881(this)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 4779, 4916);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 4996, 5047);

                FormatStartData
                formatStart = o as FormatStartData
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 5063, 6333) || true) && (formatStart != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 5063, 6333);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 5212, 6318) || true) && (formatStart.autosizeInfo != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 5212, 6318);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 5290, 5431);

                        FormattedObjectsCache.ProcessCachedGroupNotification
                        callBack = new FormattedObjectsCache.ProcessCachedGroupNotification(ProcessCachedGroup)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 5453, 5527);

                        f_1083_5453_5526(_cache, callBack, formatStart.autosizeInfo.objectCount);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 5212, 6318);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 5212, 6318);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 5729, 5799);

                        TableHeaderInfo
                        headerInfo = formatStart.shapeInfo as TableHeaderInfo
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 5821, 6299) || true) && ((headerInfo != null) && (DynAbs.Tracing.TraceSender.Expression_True(1083, 5825, 5916) && (f_1083_5875_5911(headerInfo.tableColumnInfoList) > 0)) && (DynAbs.Tracing.TraceSender.Expression_True(1083, 5825, 5991) && (f_1083_5946_5979(headerInfo.tableColumnInfoList, 0).width == 0)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 5821, 6299);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 6041, 6182);

                            FormattedObjectsCache.ProcessCachedGroupNotification
                            callBack = new FormattedObjectsCache.ProcessCachedGroupNotification(ProcessCachedGroup)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 6208, 6276);

                            f_1083_6208_6275(_cache, callBack, TimeSpan.FromMilliseconds(300));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 5821, 6299);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 5212, 6318);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 5063, 6333);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 6458, 6516);

                List<PacketInfoData>
                info = f_1083_6486_6515(_cache, o)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 6532, 6684) || true) && (info != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 6532, 6684);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 6591, 6596);
                        for (int
        k = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 6582, 6669) || true) && (k < f_1083_6602_6612(info))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 6614, 6617)
        , k++, DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 6582, 6669))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 6582, 6669);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 6640, 6669);

                            f_1083_6640_6668(_ctxManager, f_1083_6660_6667(info, k));
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1083, 1, 88);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1083, 1, 88);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 6532, 6684);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 6700, 6712);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1083, 4364, 6723);

                object
                f_1083_4439_4480(Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                this_param, System.Management.Automation.PSObject
                so)
                {
                    var return_v = this_param.Deserialize(so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 4439, 4480);
                    return return_v;
                }


                bool
                f_1083_4626_4647(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                this_param, object
                o)
                {
                    var return_v = this_param.NeedsPreprocessing(o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 4626, 4647);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                f_1083_4866_4881(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                this_param)
                {
                    var return_v = this_param.LineOutput;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 4866, 4881);
                    return return_v;
                }


                bool
                f_1083_4866_4899(Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                this_param)
                {
                    var return_v = this_param.RequiresBuffering;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 4866, 4899);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormattedObjectsCache
                f_1083_4840_4900(bool
                cacheFrontEnd)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormattedObjectsCache(cacheFrontEnd);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 4840, 4900);
                    return return_v;
                }


                int
                f_1083_5453_5526(Microsoft.PowerShell.Commands.Internal.Format.FormattedObjectsCache
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormattedObjectsCache.ProcessCachedGroupNotification
                callBack, int
                objectCount)
                {
                    this_param.EnableGroupCaching(callBack, objectCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 5453, 5526);
                    return 0;
                }


                int
                f_1083_5875_5911(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableColumnInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 5875, 5911);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TableColumnInfo
                f_1083_5946_5979(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableColumnInfo>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 5946, 5979);
                    return return_v;
                }


                int
                f_1083_6208_6275(Microsoft.PowerShell.Commands.Internal.Format.FormattedObjectsCache
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormattedObjectsCache.ProcessCachedGroupNotification
                callBack, System.TimeSpan
                groupingDuration)
                {
                    this_param.EnableGroupCaching(callBack, groupingDuration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 6208, 6275);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData>
                f_1083_6486_6515(Microsoft.PowerShell.Commands.Internal.Format.FormattedObjectsCache
                this_param, object
                o)
                {
                    var return_v = this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 6486, 6515);
                    return return_v;
                }


                int
                f_1083_6602_6612(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 6602, 6612);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData
                f_1083_6660_6667(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 6660, 6667);
                    return return_v;
                }


                int
                f_1083_6640_6668(Microsoft.PowerShell.Commands.Internal.Format.FormatMessagesContextManager
                this_param, Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData
                o)
                {
                    this_param.Process((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 6640, 6668);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 4364, 6723);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 4364, 6723);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private FormatShape ActiveFormattingShape
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1083, 6926, 7770);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 7061, 7099);

                    FormatShape
                    shape = FormatShape.Table
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 7128, 7173);

                    FormatOutputContext
                    foc = f_1083_7154_7172(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 7193, 7274) || true) && (foc == null || (DynAbs.Tracing.TraceSender.Expression_False(1083, 7197, 7238) || f_1083_7212_7220(foc).shapeInfo == null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 7193, 7274);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 7261, 7274);

                        return shape;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 7193, 7274);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 7294, 7383) || true) && (f_1083_7298_7306(foc).shapeInfo is TableHeaderInfo)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 7294, 7383);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 7358, 7383);

                        return FormatShape.Table;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 7294, 7383);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 7403, 7494) || true) && (f_1083_7407_7415(foc).shapeInfo is ListViewHeaderInfo)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 7403, 7494);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 7470, 7494);

                        return FormatShape.List;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 7403, 7494);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 7514, 7605) || true) && (f_1083_7518_7526(foc).shapeInfo is WideViewHeaderInfo)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 7514, 7605);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 7581, 7605);

                        return FormatShape.Wide;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 7514, 7605);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 7625, 7722) || true) && (f_1083_7629_7637(foc).shapeInfo is ComplexViewHeaderInfo)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 7625, 7722);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 7695, 7722);

                        return FormatShape.Complex;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 7625, 7722);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 7742, 7755);

                    return shape;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1083, 6926, 7770);

                    Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.FormatOutputContext
                    f_1083_7154_7172(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                    this_param)
                    {
                        var return_v = this_param.FormatContext;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 7154, 7172);
                        return return_v;
                    }


                    Microsoft.PowerShell.Commands.Internal.Format.FormatStartData
                    f_1083_7212_7220(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.FormatOutputContext
                    this_param)
                    {
                        var return_v = this_param.Data;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 7212, 7220);
                        return return_v;
                    }


                    Microsoft.PowerShell.Commands.Internal.Format.FormatStartData
                    f_1083_7298_7306(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.FormatOutputContext
                    this_param)
                    {
                        var return_v = this_param.Data;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 7298, 7306);
                        return return_v;
                    }


                    Microsoft.PowerShell.Commands.Internal.Format.FormatStartData
                    f_1083_7407_7415(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.FormatOutputContext
                    this_param)
                    {
                        var return_v = this_param.Data;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 7407, 7415);
                        return return_v;
                    }


                    Microsoft.PowerShell.Commands.Internal.Format.FormatStartData
                    f_1083_7518_7526(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.FormatOutputContext
                    this_param)
                    {
                        var return_v = this_param.Data;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 7518, 7526);
                        return return_v;
                    }


                    Microsoft.PowerShell.Commands.Internal.Format.FormatStartData
                    f_1083_7629_7637(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.FormatOutputContext
                    this_param)
                    {
                        var return_v = this_param.Data;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 7629, 7637);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 6860, 7781);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 6860, 7781);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override void InternalDispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1083, 7793, 8029);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 7859, 7882);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InternalDispose(), 1083, 7859, 7881);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 7896, 8018) || true) && (_command != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 7896, 8018);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 7950, 7969);

                    f_1083_7950_7968(_command);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 7987, 8003);

                    _command = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 7896, 8018);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1083, 7793, 8029);

                int
                f_1083_7950_7968(Microsoft.PowerShell.Commands.Internal.Format.CommandWrapper
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 7950, 7968);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 7793, 8029);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 7793, 8029);
            }
        }

        /// <summary>
        /// Enum describing the state for the output finite state machine.
        /// </summary>
        private enum FormattingState
        {
            /// <summary>
            /// We are in the clear state: no formatting in process.
            /// </summary>
            Reset,

            /// <summary>
            /// We received a Format Start message, but we are not inside a group.
            /// </summary>
            Formatting,

            /// <summary>
            /// We are inside a group because we received a Group Start.
            /// </summary>
            InsideGroup
        }

        private FormattingState _currentFormattingState;

        private CommandWrapper _command;

        /// <summary>
        /// Enumeration to drive the preprocessing stage.
        /// </summary>
        private enum PreprocessingState { raw, processed, error }

        private const int
        DefaultConsoleWidth = 120
        ;

        private const int
        DefaultConsoleHeight = int.MaxValue
        ;

        internal const int
        StackAllocThreshold = 120
        ;

        private bool NeedsPreprocessing(object o)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1083, 9760, 11824);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 9826, 9869);

                FormatEntryData
                fed = o as FormatEntryData
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 9883, 11748) || true) && (fed != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 9883, 11748);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 9991, 10196) || true) && (!fed.outOfBand)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 9991, 10196);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 10114, 10177);

                        f_1083_10114_10176(this, FormattingState.InsideGroup, o);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 9991, 10196);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 10216, 10229);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 9883, 11748);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 9883, 11748);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 10263, 11748) || true) && (o is FormatStartData)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 10263, 11748);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 10481, 10666) || true) && (_currentFormattingState == FormattingState.InsideGroup)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 10481, 10666);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 10581, 10602);

                            f_1083_10581_10601(this);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 10624, 10647);

                            f_1083_10624_10646(this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 10481, 10666);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 10747, 10804);

                        f_1083_10747_10803(this, FormattingState.Reset, o);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 10822, 10875);

                        _currentFormattingState = FormattingState.Formatting;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 10895, 10908);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 10263, 11748);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 10263, 11748);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 10942, 11748) || true) && (o is FormatEndData)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 10942, 11748);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 11058, 11120);

                            f_1083_11058_11119(this, FormattingState.Formatting, o);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 11138, 11186);

                            _currentFormattingState = FormattingState.Reset;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 11206, 11219);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 10942, 11748);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 10942, 11748);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 11253, 11748) || true) && (o is GroupStartData)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 11253, 11748);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 11310, 11372);

                                f_1083_11310_11371(this, FormattingState.Formatting, o);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 11390, 11444);

                                _currentFormattingState = FormattingState.InsideGroup;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 11464, 11477);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 11253, 11748);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 11253, 11748);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 11511, 11748) || true) && (o is GroupEndData)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 11511, 11748);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 11566, 11629);

                                    f_1083_11566_11628(this, FormattingState.InsideGroup, o);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 11647, 11700);

                                    _currentFormattingState = FormattingState.Formatting;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 11720, 11733);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 11511, 11748);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 11253, 11748);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 10942, 11748);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 10263, 11748);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 9883, 11748);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 11801, 11813);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1083, 9760, 11824);

                int
                f_1083_10114_10176(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                this_param, Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.FormattingState
                expectedFormattingState, object
                obj)
                {
                    this_param.ValidateCurrentFormattingState(expectedFormattingState, obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 10114, 10176);
                    return 0;
                }


                int
                f_1083_10581_10601(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                this_param)
                {
                    this_param.EndProcessing();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 10581, 10601);
                    return 0;
                }


                int
                f_1083_10624_10646(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                this_param)
                {
                    this_param.BeginProcessing();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 10624, 10646);
                    return 0;
                }


                int
                f_1083_10747_10803(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                this_param, Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.FormattingState
                expectedFormattingState, object
                obj)
                {
                    this_param.ValidateCurrentFormattingState(expectedFormattingState, obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 10747, 10803);
                    return 0;
                }


                int
                f_1083_11058_11119(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                this_param, Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.FormattingState
                expectedFormattingState, object
                obj)
                {
                    this_param.ValidateCurrentFormattingState(expectedFormattingState, obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 11058, 11119);
                    return 0;
                }


                int
                f_1083_11310_11371(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                this_param, Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.FormattingState
                expectedFormattingState, object
                obj)
                {
                    this_param.ValidateCurrentFormattingState(expectedFormattingState, obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 11310, 11371);
                    return 0;
                }


                int
                f_1083_11566_11628(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                this_param, Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.FormattingState
                expectedFormattingState, object
                obj)
                {
                    this_param.ValidateCurrentFormattingState(expectedFormattingState, obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 11566, 11628);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 9760, 11824);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 9760, 11824);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ValidateCurrentFormattingState(FormattingState expectedFormattingState, object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1083, 11836, 13816);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 12022, 13805) || true) && (_currentFormattingState != expectedFormattingState)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 12022, 13805);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 12245, 12282);

                    string
                    violatingCommand = "format-*"
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 12300, 12335);

                    StartData
                    sdObj = obj as StartData
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 12353, 13104) || true) && (sdObj != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 12353, 13104);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 12412, 13085) || true) && (sdObj.shapeInfo is WideViewHeaderInfo)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 12412, 13085);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 12503, 12536);

                            violatingCommand = "format-wide";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 12412, 13085);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 12412, 13085);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 12586, 13085) || true) && (sdObj.shapeInfo is TableHeaderInfo)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 12586, 13085);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 12674, 12708);

                                violatingCommand = "format-table";
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 12586, 13085);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 12586, 13085);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 12758, 13085) || true) && (sdObj.shapeInfo is ListViewHeaderInfo)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 12758, 13085);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 12849, 12882);

                                    violatingCommand = "format-list";
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 12758, 13085);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 12758, 13085);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 12932, 13085) || true) && (sdObj.shapeInfo is ComplexViewHeaderInfo)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 12932, 13085);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 13026, 13062);

                                        violatingCommand = "format-complex";
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 12932, 13085);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 12758, 13085);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 12586, 13085);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 12412, 13085);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 12353, 13104);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 13124, 13274);

                    string
                    msg = f_1083_13137_13273(f_1083_13155_13209(), f_1083_13232_13254(f_1083_13232_13245(obj)), violatingCommand)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 13294, 13639);

                    ErrorRecord
                    errorRecord = f_1083_13320_13638(f_1083_13386_13417(), "ConsoleLineOutputOutOfSequencePacket", ErrorCategory.InvalidData, null)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 13659, 13708);

                    errorRecord.ErrorDetails = f_1083_13686_13707(msg);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 13726, 13790);

                    f_1083_13726_13789(f_1083_13726_13754(this), errorRecord);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 12022, 13805);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1083, 11836, 13816);

                string
                f_1083_13155_13209()
                {
                    var return_v = FormatAndOut_out_xxx.OutLineOutput_OutOfSequencePacket;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 13155, 13209);
                    return return_v;
                }


                System.Type
                f_1083_13232_13245(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 13232, 13245);
                    return return_v;
                }


                string
                f_1083_13232_13254(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 13232, 13254);
                    return return_v;
                }


                string
                f_1083_13137_13273(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 13137, 13273);
                    return return_v;
                }


                System.InvalidOperationException
                f_1083_13386_13417()
                {
                    var return_v = new System.InvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 13386, 13417);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1083_13320_13638(System.InvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 13320, 13638);
                    return return_v;
                }


                System.Management.Automation.ErrorDetails
                f_1083_13686_13707(string
                message)
                {
                    var return_v = new System.Management.Automation.ErrorDetails(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 13686, 13707);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                f_1083_13726_13754(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                this_param)
                {
                    var return_v = this_param.TerminatingErrorContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 13726, 13754);
                    return return_v;
                }


                int
                f_1083_13726_13789(Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 13726, 13789);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 11836, 13816);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 11836, 13816);
            }
        }

        private Array ApplyFormatting(object o)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1083, 14096, 14429);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 14160, 14375) || true) && (_command == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 14160, 14375);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 14214, 14246);

                    _command = f_1083_14225_14245();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 14264, 14360);

                    f_1083_14264_14359(_command, f_1083_14284_14310(f_1083_14284_14302(this)), "format-default", typeof(FormatDefaultCommand));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 14160, 14375);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 14391, 14418);

                return f_1083_14398_14417(_command, o);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1083, 14096, 14429);

                Microsoft.PowerShell.Commands.Internal.Format.CommandWrapper
                f_1083_14225_14245()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.CommandWrapper();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 14225, 14245);
                    return return_v;
                }


                System.Management.Automation.PSCmdlet
                f_1083_14284_14302(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                this_param)
                {
                    var return_v = this_param.OuterCmdlet();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 14284, 14302);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1083_14284_14310(System.Management.Automation.PSCmdlet
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 14284, 14310);
                    return return_v;
                }


                int
                f_1083_14264_14359(Microsoft.PowerShell.Commands.Internal.Format.CommandWrapper
                this_param, System.Management.Automation.ExecutionContext
                execContext, string
                nameOfCommand, System.Type
                typeOfCommand)
                {
                    this_param.Initialize(execContext, nameOfCommand, typeOfCommand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 14264, 14359);
                    return 0;
                }


                System.Array
                f_1083_14398_14417(Microsoft.PowerShell.Commands.Internal.Format.CommandWrapper
                this_param, object
                o)
                {
                    var return_v = this_param.Process(o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 14398, 14417);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 14096, 14429);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 14096, 14429);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private FormatMessagesContextManager.OutputContext CreateOutputContext(
                                                FormatMessagesContextManager.OutputContext parentContext,
                                                FormatInfoData formatInfoData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1083, 14741, 16871);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 15008, 15076);

                FormatStartData
                formatStartData = formatInfoData as FormatStartData
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 15136, 15325) || true) && (formatStartData != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 15136, 15325);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 15197, 15279);

                    FormatOutputContext
                    foc = f_1083_15223_15278(parentContext, formatStartData)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 15299, 15310);

                    return foc;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 15136, 15325);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 15341, 15395);

                GroupStartData
                gsd = formatInfoData as GroupStartData
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 15479, 16832) || true) && (gsd != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 15479, 16832);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 15528, 15558);

                    GroupOutputContext
                    goc = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 15578, 16751);

                    switch (f_1083_15586_15607())
                    {

                        case FormatShape.Table:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 15578, 16751);
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 15729, 15784);

                                goc = f_1083_15735_15783(this, parentContext, gsd);
                                DynAbs.Tracing.TraceSender.TraceBreak(1083, 15814, 15820);

                                break;
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 15578, 16751);

                        case FormatShape.List:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 15578, 16751);
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 15950, 16004);

                                goc = f_1083_15956_16003(this, parentContext, gsd);
                                DynAbs.Tracing.TraceSender.TraceBreak(1083, 16034, 16040);

                                break;
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 15578, 16751);

                        case FormatShape.Wide:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 15578, 16751);
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 16170, 16224);

                                goc = f_1083_16176_16223(this, parentContext, gsd);
                                DynAbs.Tracing.TraceSender.TraceBreak(1083, 16254, 16260);

                                break;
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 15578, 16751);

                        case FormatShape.Complex:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 15578, 16751);
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 16393, 16450);

                                goc = f_1083_16399_16449(this, parentContext, gsd);
                                DynAbs.Tracing.TraceSender.TraceBreak(1083, 16480, 16486);

                                break;
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 15578, 16751);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 15578, 16751);
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 16602, 16671);

                                f_1083_16602_16670(false, "Invalid shape. This should never happen");
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(1083, 16726, 16732);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 15578, 16751);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 16771, 16788);

                    f_1083_16771_16787(
                                    goc);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 16806, 16817);

                    return goc;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 15479, 16832);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 16848, 16860);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1083, 14741, 16871);

                Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.FormatOutputContext
                f_1083_15223_15278(Microsoft.PowerShell.Commands.Internal.Format.FormatMessagesContextManager.OutputContext
                parentContext, Microsoft.PowerShell.Commands.Internal.Format.FormatStartData
                formatData)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.FormatOutputContext(parentContext, formatData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 15223, 15278);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatShape
                f_1083_15586_15607()
                {
                    var return_v = ActiveFormattingShape;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 15586, 15607);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.TableOutputContext
                f_1083_15735_15783(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                cmd, Microsoft.PowerShell.Commands.Internal.Format.FormatMessagesContextManager.OutputContext
                parentContext, Microsoft.PowerShell.Commands.Internal.Format.GroupStartData
                formatData)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.TableOutputContext(cmd, parentContext, formatData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 15735, 15783);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.ListOutputContext
                f_1083_15956_16003(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                cmd, Microsoft.PowerShell.Commands.Internal.Format.FormatMessagesContextManager.OutputContext
                parentContext, Microsoft.PowerShell.Commands.Internal.Format.GroupStartData
                formatData)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.ListOutputContext(cmd, parentContext, formatData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 15956, 16003);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.WideOutputContext
                f_1083_16176_16223(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                cmd, Microsoft.PowerShell.Commands.Internal.Format.FormatMessagesContextManager.OutputContext
                parentContext, Microsoft.PowerShell.Commands.Internal.Format.GroupStartData
                formatData)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.WideOutputContext(cmd, parentContext, formatData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 16176, 16223);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.ComplexOutputContext
                f_1083_16399_16449(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                cmd, Microsoft.PowerShell.Commands.Internal.Format.FormatMessagesContextManager.OutputContext
                parentContext, Microsoft.PowerShell.Commands.Internal.Format.GroupStartData
                formatData)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.ComplexOutputContext(cmd, parentContext, formatData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 16399, 16449);
                    return return_v;
                }


                int
                f_1083_16602_16670(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 16602, 16670);
                    return 0;
                }


                int
                f_1083_16771_16787(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.GroupOutputContext
                this_param)
                {
                    this_param.Initialize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 16771, 16787);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 14741, 16871);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 14741, 16871);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ProcessFormatStart(FormatMessagesContextManager.OutputContext c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1083, 17045, 17255);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 17204, 17244);

                f_1083_17204_17243(f_1083_17204_17219(this), string.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1083, 17045, 17255);

                Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                f_1083_17204_17219(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                this_param)
                {
                    var return_v = this_param.LineOutput;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 17204, 17219);
                    return return_v;
                }


                int
                f_1083_17204_17243(Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                this_param, string
                s)
                {
                    this_param.WriteLine(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 17204, 17243);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 17045, 17255);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 17045, 17255);
            }
        }

        private void ProcessFormatEnd(FormatEndData fe, FormatMessagesContextManager.OutputContext c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1083, 17487, 17768);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 17717, 17757);

                f_1083_17717_17756(f_1083_17717_17732(this), string.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1083, 17487, 17768);

                Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                f_1083_17717_17732(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                this_param)
                {
                    var return_v = this_param.LineOutput;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 17717, 17732);
                    return return_v;
                }


                int
                f_1083_17717_17756(Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                this_param, string
                s)
                {
                    this_param.WriteLine(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 17717, 17756);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 17487, 17768);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 17487, 17768);
            }
        }

        private void ProcessGroupStart(FormatMessagesContextManager.OutputContext c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1083, 17942, 18562);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 18099, 18146);

                GroupOutputContext
                goc = (GroupOutputContext)c
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 18162, 18518) || true) && (f_1083_18166_18174(goc).groupingEntry != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 18162, 18518);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 18230, 18258);

                    f_1083_18230_18257(_lo, string.Empty);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 18278, 18321);

                    ComplexWriter
                    writer = f_1083_18301_18320()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 18339, 18380);

                    f_1083_18339_18379(writer, _lo, f_1083_18362_18378(_lo));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 18398, 18457);

                    f_1083_18398_18456(writer, f_1083_18417_18425(goc).groupingEntry.formatValueList);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 18475, 18503);

                    f_1083_18475_18502(_lo, string.Empty);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 18162, 18518);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 18534, 18551);

                f_1083_18534_18550(
                            goc);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1083, 17942, 18562);

                Microsoft.PowerShell.Commands.Internal.Format.GroupStartData
                f_1083_18166_18174(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.GroupOutputContext
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 18166, 18174);
                    return return_v;
                }


                int
                f_1083_18230_18257(Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                this_param, string
                s)
                {
                    this_param.WriteLine(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 18230, 18257);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ComplexWriter
                f_1083_18301_18320()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ComplexWriter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 18301, 18320);
                    return return_v;
                }


                int
                f_1083_18362_18378(Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                this_param)
                {
                    var return_v = this_param.ColumnNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 18362, 18378);
                    return return_v;
                }


                int
                f_1083_18339_18379(Microsoft.PowerShell.Commands.Internal.Format.ComplexWriter
                this_param, Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                lineOutput, int
                numberOfTextColumns)
                {
                    this_param.Initialize(lineOutput, numberOfTextColumns);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 18339, 18379);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.GroupStartData
                f_1083_18417_18425(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.GroupOutputContext
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 18417, 18425);
                    return return_v;
                }


                int
                f_1083_18398_18456(Microsoft.PowerShell.Commands.Internal.Format.ComplexWriter
                this_param, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                formatValueList)
                {
                    this_param.WriteObject(formatValueList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 18398, 18456);
                    return 0;
                }


                int
                f_1083_18475_18502(Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                this_param, string
                s)
                {
                    this_param.WriteLine(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 18475, 18502);
                    return 0;
                }


                int
                f_1083_18534_18550(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.GroupOutputContext
                this_param)
                {
                    this_param.GroupStart();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 18534, 18550);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 17942, 18562);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 17942, 18562);
            }
        }

        private void ProcessGroupEnd(GroupEndData ge, FormatMessagesContextManager.OutputContext c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1083, 18794, 19053);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 18964, 19011);

                GroupOutputContext
                goc = (GroupOutputContext)c
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 19027, 19042);

                f_1083_19027_19041(
                            goc);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1083, 18794, 19053);

                int
                f_1083_19027_19041(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.GroupOutputContext
                this_param)
                {
                    this_param.GroupEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 19027, 19041);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 18794, 19053);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 18794, 19053);
            }
        }

        private void ProcessPayload(FormatEntryData fed, FormatMessagesContextManager.OutputContext c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1083, 19291, 20311);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 19474, 19584) || true) && (fed == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 19474, 19584);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 19523, 19569);

                    f_1083_19523_19568("fed");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 19474, 19584);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 19600, 19742) || true) && (fed.formatEntryInfo == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 19600, 19742);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 19665, 19727);

                    f_1083_19665_19726("fed.formatEntryInfo");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 19600, 19742);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 19758, 19803);

                WriteStreamType
                oldWSState = f_1083_19787_19802(_lo)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 19853, 19887);

                    _lo.WriteStream = fed.writeStream;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 19907, 20187) || true) && (c == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 19907, 20187);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 19962, 19991);

                        f_1083_19962_19990(this, fed);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 19907, 20187);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 19907, 20187);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 20073, 20120);

                        GroupOutputContext
                        goc = (GroupOutputContext)c
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 20144, 20168);

                        f_1083_20144_20167(
                                            goc, fed);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 19907, 20187);
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1083, 20216, 20300);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 20256, 20285);

                    _lo.WriteStream = oldWSState;
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1083, 20216, 20300);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1083, 19291, 20311);

                System.Management.Automation.PSArgumentNullException
                f_1083_19523_19568(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 19523, 19568);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1083_19665_19726(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 19665, 19726);
                    return return_v;
                }


                System.Management.Automation.WriteStreamType
                f_1083_19787_19802(Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                this_param)
                {
                    var return_v = this_param.WriteStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 19787, 19802);
                    return return_v;
                }


                int
                f_1083_19962_19990(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatEntryData
                fed)
                {
                    this_param.ProcessOutOfBandPayload(fed);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 19962, 19990);
                    return 0;
                }


                int
                f_1083_20144_20167(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.GroupOutputContext
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatEntryData
                fed)
                {
                    this_param.ProcessPayload(fed);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 20144, 20167);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 19291, 20311);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 19291, 20311);
            }
        }

        private void ProcessOutOfBandPayload(FormatEntryData fed)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1083, 20323, 22113);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 20443, 20510);

                RawTextFormatEntry
                rte = fed.formatEntryInfo as RawTextFormatEntry
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 20524, 20982) || true) && (rte != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 20524, 20982);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 20573, 20940) || true) && (fed.isHelpObject)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 20573, 20940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 20635, 20685);

                        ComplexWriter
                        complexWriter = f_1083_20665_20684()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 20709, 20757);

                        f_1083_20709_20756(
                                            complexWriter, _lo, f_1083_20739_20755(_lo));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 20779, 20815);

                        f_1083_20779_20814(complexWriter, rte.text);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 20573, 20940);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 20573, 20940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 20897, 20921);

                        f_1083_20897_20920(_lo, rte.text);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 20573, 20940);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 20960, 20967);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 20524, 20982);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 21043, 21106);

                ComplexViewEntry
                cve = fed.formatEntryInfo as ComplexViewEntry
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 21120, 21421) || true) && (cve != null && (DynAbs.Tracing.TraceSender.Expression_True(1083, 21124, 21166) && cve.formatValueList != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 21120, 21421);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 21200, 21250);

                    ComplexWriter
                    complexWriter = f_1083_21230_21249()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 21270, 21314);

                    f_1083_21270_21313(
                                    complexWriter, _lo, int.MaxValue);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 21332, 21379);

                    f_1083_21332_21378(complexWriter, cve.formatValueList);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 21399, 21406);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 21120, 21421);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 21476, 21533);

                ListViewEntry
                lve = fed.formatEntryInfo as ListViewEntry
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 21547, 22102) || true) && (lve != null && (DynAbs.Tracing.TraceSender.Expression_True(1083, 21551, 21595) && lve.listViewFieldList != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 21547, 22102);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 21629, 21670);

                    ListWriter
                    listWriter = f_1083_21653_21669()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 21690, 21718);

                    f_1083_21690_21717(
                                    _lo, string.Empty);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 21738, 21797);

                    string[]
                    properties = f_1083_21760_21796(lve)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 21815, 21885);

                    f_1083_21815_21884(listWriter, properties, f_1083_21849_21865(_lo), f_1083_21867_21883(_lo));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 21903, 21954);

                    string[]
                    values = f_1083_21921_21953(lve)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 21972, 22012);

                    f_1083_21972_22011(listWriter, values, _lo);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 22032, 22060);

                    f_1083_22032_22059(
                                    _lo, string.Empty);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 22080, 22087);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 21547, 22102);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1083, 20323, 22113);

                Microsoft.PowerShell.Commands.Internal.Format.ComplexWriter
                f_1083_20665_20684()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ComplexWriter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 20665, 20684);
                    return return_v;
                }


                int
                f_1083_20739_20755(Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                this_param)
                {
                    var return_v = this_param.ColumnNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 20739, 20755);
                    return return_v;
                }


                int
                f_1083_20709_20756(Microsoft.PowerShell.Commands.Internal.Format.ComplexWriter
                this_param, Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                lineOutput, int
                numberOfTextColumns)
                {
                    this_param.Initialize(lineOutput, numberOfTextColumns);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 20709, 20756);
                    return 0;
                }


                int
                f_1083_20779_20814(Microsoft.PowerShell.Commands.Internal.Format.ComplexWriter
                this_param, string
                s)
                {
                    this_param.WriteString(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 20779, 20814);
                    return 0;
                }


                int
                f_1083_20897_20920(Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                this_param, string
                s)
                {
                    this_param.WriteLine(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 20897, 20920);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ComplexWriter
                f_1083_21230_21249()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ComplexWriter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 21230, 21249);
                    return return_v;
                }


                int
                f_1083_21270_21313(Microsoft.PowerShell.Commands.Internal.Format.ComplexWriter
                this_param, Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                lineOutput, int
                numberOfTextColumns)
                {
                    this_param.Initialize(lineOutput, numberOfTextColumns);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 21270, 21313);
                    return 0;
                }


                int
                f_1083_21332_21378(Microsoft.PowerShell.Commands.Internal.Format.ComplexWriter
                this_param, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                formatValueList)
                {
                    this_param.WriteObject(formatValueList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 21332, 21378);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ListWriter
                f_1083_21653_21669()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ListWriter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 21653, 21669);
                    return return_v;
                }


                int
                f_1083_21690_21717(Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                this_param, string
                s)
                {
                    this_param.WriteLine(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 21690, 21717);
                    return 0;
                }


                string[]
                f_1083_21760_21796(Microsoft.PowerShell.Commands.Internal.Format.ListViewEntry
                lve)
                {
                    var return_v = ListOutputContext.GetProperties(lve);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 21760, 21796);
                    return return_v;
                }


                int
                f_1083_21849_21865(Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                this_param)
                {
                    var return_v = this_param.ColumnNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 21849, 21865);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                f_1083_21867_21883(Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                this_param)
                {
                    var return_v = this_param.DisplayCells;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 21867, 21883);
                    return return_v;
                }


                int
                f_1083_21815_21884(Microsoft.PowerShell.Commands.Internal.Format.ListWriter
                this_param, string[]
                propertyNames, int
                screenColumnWidth, Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                dc)
                {
                    this_param.Initialize(propertyNames, screenColumnWidth, dc);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 21815, 21884);
                    return 0;
                }


                string[]
                f_1083_21921_21953(Microsoft.PowerShell.Commands.Internal.Format.ListViewEntry
                lve)
                {
                    var return_v = ListOutputContext.GetValues(lve);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 21921, 21953);
                    return return_v;
                }


                int
                f_1083_21972_22011(Microsoft.PowerShell.Commands.Internal.Format.ListWriter
                this_param, string[]
                values, Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                lo)
                {
                    this_param.WriteProperties(values, lo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 21972, 22011);
                    return 0;
                }


                int
                f_1083_22032_22059(Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                this_param, string
                s)
                {
                    this_param.WriteLine(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 22032, 22059);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 20323, 22113);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 20323, 22113);
            }
        }

        private LineOutput _lo;

        internal LineOutput LineOutput
        {
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1083, 22330, 22350);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 22336, 22348);

                    _lo = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1083, 22330, 22350);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 22275, 22396);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 22275, 22396);
                }
            }
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1083, 22366, 22385);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 22372, 22383);

                    return _lo;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1083, 22366, 22385);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 22275, 22396);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 22275, 22396);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ShapeInfo ShapeInfoOnFormatContext
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1083, 22475, 22687);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 22511, 22556);

                    FormatOutputContext
                    foc = f_1083_22537_22555(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 22576, 22626) || true) && (foc == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 22576, 22626);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 22614, 22626);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 22576, 22626);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 22646, 22672);

                    return f_1083_22653_22661(foc).shapeInfo;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1083, 22475, 22687);

                    Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.FormatOutputContext
                    f_1083_22537_22555(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                    this_param)
                    {
                        var return_v = this_param.FormatContext;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 22537, 22555);
                        return return_v;
                    }


                    Microsoft.PowerShell.Commands.Internal.Format.FormatStartData
                    f_1083_22653_22661(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.FormatOutputContext
                    this_param)
                    {
                        var return_v = this_param.Data;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 22653, 22661);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 22408, 22698);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 22408, 22698);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private FormatOutputContext FormatContext
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1083, 22941, 23333);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 23025, 23061);
                        for (FormatMessagesContextManager.OutputContext
        oc = f_1083_23030_23061(_ctxManager)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 22977, 23286) || true) && (oc != null)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 23075, 23096)
        , oc = f_1083_23080_23096(oc), DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 22977, 23286))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 22977, 23286);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 23138, 23190);

                            FormatOutputContext
                            foc = oc as FormatOutputContext
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 23214, 23267) || true) && (foc != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 23214, 23267);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 23256, 23267);

                                return foc;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 23214, 23267);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1083, 1, 310);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1083, 1, 310);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 23306, 23318);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1083, 22941, 23333);

                    Microsoft.PowerShell.Commands.Internal.Format.FormatMessagesContextManager.OutputContext
                    f_1083_23030_23061(Microsoft.PowerShell.Commands.Internal.Format.FormatMessagesContextManager
                    this_param)
                    {
                        var return_v = this_param.ActiveOutputContext;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 23030, 23061);
                        return return_v;
                    }


                    Microsoft.PowerShell.Commands.Internal.Format.FormatMessagesContextManager.OutputContext
                    f_1083_23080_23096(Microsoft.PowerShell.Commands.Internal.Format.FormatMessagesContextManager.OutputContext
                    this_param)
                    {
                        var return_v = this_param.ParentContext;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 23080, 23096);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 22875, 23344);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 22875, 23344);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private FormatMessagesContextManager _ctxManager;

        private FormattedObjectsCache _cache;

        private void ProcessCachedGroup(FormatStartData formatStartData, List<PacketInfoData> objects)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1083, 23906, 24523);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 24025, 24048);

                _formattingHint = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 24064, 24131);

                TableHeaderInfo
                thi = formatStartData.shapeInfo as TableHeaderInfo
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 24147, 24276) || true) && (thi != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 24147, 24276);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 24196, 24236);

                    f_1083_24196_24235(this, thi, objects);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 24254, 24261);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 24147, 24276);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 24292, 24366);

                WideViewHeaderInfo
                wvhi = formatStartData.shapeInfo as WideViewHeaderInfo
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 24382, 24512) || true) && (wvhi != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 24382, 24512);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 24432, 24472);

                    f_1083_24432_24471(this, wvhi, objects);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 24490, 24497);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 24382, 24512);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1083, 23906, 24523);

                int
                f_1083_24196_24235(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TableHeaderInfo
                thi, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData>
                objects)
                {
                    this_param.ProcessCachedGroupOnTable(thi, objects);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 24196, 24235);
                    return 0;
                }


                int
                f_1083_24432_24471(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                this_param, Microsoft.PowerShell.Commands.Internal.Format.WideViewHeaderInfo
                wvhi, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData>
                objects)
                {
                    this_param.ProcessCachedGroupOnWide(wvhi, objects);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 24432, 24471);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 23906, 24523);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 23906, 24523);
            }
        }

        private void ProcessCachedGroupOnTable(TableHeaderInfo thi, List<PacketInfoData> objects)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1083, 24535, 26089);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 24649, 24713) || true) && (f_1083_24653_24682(thi.tableColumnInfoList) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 24649, 24713);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 24706, 24713);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 24649, 24713);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 24729, 24783);

                int[]
                widths = new int[f_1083_24752_24781(thi.tableColumnInfoList)]
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 24808, 24813);

                    for (int
        k = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 24799, 25247) || true) && (k < f_1083_24819_24848(thi.tableColumnInfoList))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 24850, 24853)
        , k++, DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 24799, 25247))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 24799, 25247);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 24887, 24935);

                        string
                        label = f_1083_24902_24928(thi.tableColumnInfoList, k).label
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 24955, 25057) || true) && (f_1083_24959_24986(label))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 24955, 25057);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 25009, 25057);

                            label = f_1083_25017_25043(thi.tableColumnInfoList, k).propertyName;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 24955, 25057);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 25077, 25232) || true) && (f_1083_25081_25108(label))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 25077, 25232);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 25131, 25145);

                            widths[k] = 0;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 25077, 25232);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 25077, 25232);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 25189, 25232);

                            widths[k] = f_1083_25201_25231(f_1083_25201_25217(_lo), label);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 25077, 25232);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1083, 1, 449);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1083, 1, 449);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 25263, 25277);

                int
                cellCount
                = default(int);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 25311, 25929);
                    foreach (PacketInfoData o in f_1083_25340_25347_I(objects))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 25311, 25929);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 25381, 25914) || true) && (o is FormatEntryData fed)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 25381, 25914);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 25451, 25508);

                            TableRowEntry
                            tre = fed.formatEntryInfo as TableRowEntry
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 25530, 25541);

                            int
                            kk = 0
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 25565, 25895);
                                foreach (FormatPropertyField fpf in f_1083_25601_25628_I(tre.formatPropertyFieldList))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 25565, 25895);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 25678, 25733);

                                    cellCount = f_1083_25690_25732(f_1083_25690_25706(_lo), fpf.propertyValue);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 25759, 25839) || true) && (widths[kk] < cellCount)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 25759, 25839);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 25816, 25839);

                                        widths[kk] = cellCount;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 25759, 25839);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 25867, 25872);

                                    kk++;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 25565, 25895);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1083, 1, 331);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1083, 1, 331);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 25381, 25914);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 25311, 25929);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1083, 1, 619);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1083, 1, 619);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 25945, 25998);

                TableFormattingHint
                hint = f_1083_25972_25997()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 26014, 26041);

                hint.columnWidths = widths;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 26055, 26078);

                _formattingHint = hint;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1083, 24535, 26089);

                int
                f_1083_24653_24682(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableColumnInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 24653, 24682);
                    return return_v;
                }


                int
                f_1083_24752_24781(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableColumnInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 24752, 24781);
                    return return_v;
                }


                int
                f_1083_24819_24848(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableColumnInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 24819, 24848);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TableColumnInfo
                f_1083_24902_24928(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableColumnInfo>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 24902, 24928);
                    return return_v;
                }


                bool
                f_1083_24959_24986(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 24959, 24986);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TableColumnInfo
                f_1083_25017_25043(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableColumnInfo>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 25017, 25043);
                    return return_v;
                }


                bool
                f_1083_25081_25108(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 25081, 25108);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                f_1083_25201_25217(Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                this_param)
                {
                    var return_v = this_param.DisplayCells;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 25201, 25217);
                    return return_v;
                }


                int
                f_1083_25201_25231(Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                this_param, string
                str)
                {
                    var return_v = this_param.Length(str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 25201, 25231);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                f_1083_25690_25706(Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                this_param)
                {
                    var return_v = this_param.DisplayCells;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 25690, 25706);
                    return return_v;
                }


                int
                f_1083_25690_25732(Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                this_param, string
                str)
                {
                    var return_v = this_param.Length(str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 25690, 25732);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatPropertyField>
                f_1083_25601_25628_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatPropertyField>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 25601, 25628);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData>
                f_1083_25340_25347_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 25340, 25347);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.TableFormattingHint
                f_1083_25972_25997()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.TableFormattingHint();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 25972, 25997);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 24535, 26089);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 24535, 26089);
            }
        }

        private void ProcessCachedGroupOnWide(WideViewHeaderInfo wvhi, List<PacketInfoData> objects)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1083, 26101, 27213);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 26218, 26344) || true) && (wvhi.columns != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 26218, 26344);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 26322, 26329);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 26218, 26344);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 26360, 26375);

                int
                maxLen = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 26389, 26403);

                int
                cellCount
                = default(int);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 26439, 27059);
                    foreach (PacketInfoData o in f_1083_26468_26475_I(objects))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 26439, 27059);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 26509, 27044) || true) && (o is FormatEntryData fed)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 26509, 27044);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 26579, 26636);

                            WideViewEntry
                            wve = fed.formatEntryInfo as WideViewEntry
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 26658, 26731);

                            FormatPropertyField
                            fpf = wve.formatPropertyField as FormatPropertyField
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 26755, 27025) || true) && (!f_1083_26760_26799(fpf.propertyValue))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 26755, 27025);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 26849, 26904);

                                cellCount = f_1083_26861_26903(f_1083_26861_26877(_lo), fpf.propertyValue);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 26930, 27002) || true) && (cellCount > maxLen)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 26930, 27002);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 26983, 27002);

                                    maxLen = cellCount;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 26930, 27002);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 26755, 27025);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 26509, 27044);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 26439, 27059);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1083, 1, 621);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1083, 1, 621);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 27075, 27126);

                WideFormattingHint
                hint = f_1083_27101_27125()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 27142, 27165);

                hint.maxWidth = maxLen;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 27179, 27202);

                _formattingHint = hint;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1083, 26101, 27213);

                bool
                f_1083_26760_26799(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 26760, 26799);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                f_1083_26861_26877(Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                this_param)
                {
                    var return_v = this_param.DisplayCells;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 26861, 26877);
                    return return_v;
                }


                int
                f_1083_26861_26903(Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                this_param, string
                str)
                {
                    var return_v = this_param.Length(str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 26861, 26903);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData>
                f_1083_26468_26475_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 26468, 26475);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.WideFormattingHint
                f_1083_27101_27125()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.WideFormattingHint();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 27101, 27125);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 26101, 27213);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 26101, 27213);
            }
        }

        private static int GetConsoleWindowWidth(int columnNumber)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1083, 27762, 28561);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 27845, 27964) || true) && (InternalTestHooks.SetConsoleWidthToZero)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 27845, 27964);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 27922, 27949);

                    return DefaultConsoleWidth;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 27845, 27964);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 27980, 28514) || true) && (columnNumber == int.MaxValue)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 27980, 28514);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 28292, 28370);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(1083, 28299, 28325) || (((f_1083_28300_28319() != 0) && DynAbs.Tracing.TraceSender.Conditional_F2(1083, 28328, 28347)) || DynAbs.Tracing.TraceSender.Conditional_F3(1083, 28350, 28369))) ? f_1083_28328_28347() : DefaultConsoleWidth;
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1083, 28407, 28499);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 28453, 28480);

                        return DefaultConsoleWidth;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1083, 28407, 28499);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 27980, 28514);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 28530, 28550);

                return columnNumber;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1083, 27762, 28561);

                int
                f_1083_28300_28319()
                {
                    var return_v = Console.WindowWidth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 28300, 28319);
                    return return_v;
                }


                int
                f_1083_28328_28347()
                {
                    var return_v = Console.WindowWidth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 28328, 28347);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 27762, 28561);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 27762, 28561);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int GetConsoleWindowHeight(int rowNumber)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1083, 28727, 29476);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 28808, 28929) || true) && (InternalTestHooks.SetConsoleHeightToZero)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 28808, 28929);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 28886, 28914);

                    return DefaultConsoleHeight;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 28808, 28929);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 28945, 29432) || true) && (rowNumber <= 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 28945, 29432);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 29207, 29287);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(1083, 29214, 29240) || (((f_1083_29215_29235() > 0) && DynAbs.Tracing.TraceSender.Conditional_F2(1083, 29243, 29263)) || DynAbs.Tracing.TraceSender.Conditional_F3(1083, 29266, 29286))) ? f_1083_29243_29263() : DefaultConsoleHeight;
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1083, 29324, 29417);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 29370, 29398);

                        return DefaultConsoleHeight;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1083, 29324, 29417);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 28945, 29432);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 29448, 29465);

                return rowNumber;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1083, 28727, 29476);

                int
                f_1083_29215_29235()
                {
                    var return_v = Console.WindowHeight;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 29215, 29235);
                    return return_v;
                }


                int
                f_1083_29243_29263()
                {
                    var return_v = Console.WindowHeight;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 29243, 29263);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 28727, 29476);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 28727, 29476);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private abstract class FormattingHint
        {
            public FormattingHint()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1083, 29589, 29648);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1083, 29589, 29648);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 29589, 29648);
            }


            static FormattingHint()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1083, 29589, 29648);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1083, 29589, 29648);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 29589, 29648);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1083, 29589, 29648);
        }
        private sealed class TableFormattingHint : FormattingHint
        {
            internal int[] columnWidths;

            public TableFormattingHint()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1083, 29743, 29871);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 29840, 29859);
                this.columnWidths = null;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1083, 29743, 29871);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 29743, 29871);
            }


            static TableFormattingHint()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1083, 29743, 29871);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1083, 29743, 29871);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 29743, 29871);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1083, 29743, 29871);
        }
        private sealed class WideFormattingHint : FormattingHint
        {
            internal int maxWidth;

            public WideFormattingHint()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1083, 29965, 30083);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 30059, 30071);
                this.maxWidth = 0;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1083, 29965, 30083);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 29965, 30083);
            }


            static WideFormattingHint()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1083, 29965, 30083);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1083, 29965, 30083);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 29965, 30083);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1083, 29965, 30083);
        }

        private FormattingHint _formattingHint;

        private FormattingHint RetrieveFormattingHint()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1083, 30440, 30620);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 30512, 30548);

                FormattingHint
                fh = _formattingHint
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 30562, 30585);

                _formattingHint = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 30599, 30609);

                return fh;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1083, 30440, 30620);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 30440, 30620);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 30440, 30620);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private FormatObjectDeserializer _formatObjectDeserializer;
        private class FormatOutputContext : FormatMessagesContextManager.OutputContext
        {
            internal FormatOutputContext(FormatMessagesContextManager.OutputContext parentContext, FormatStartData formatData)
            : base(f_1083_31338_31351_C(parentContext))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1083, 31199, 31418);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 31547, 31593);
                    this.Data = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 31385, 31403);

                    Data = formatData;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1083, 31199, 31418);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 31199, 31418);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 31199, 31418);
                }
            }

            internal FormatStartData Data { get; }

            static FormatOutputContext()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1083, 30815, 31604);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1083, 30815, 31604);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 30815, 31604);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1083, 30815, 31604);

            static Microsoft.PowerShell.Commands.Internal.Format.FormatMessagesContextManager.OutputContext
            f_1083_31338_31351_C(Microsoft.PowerShell.Commands.Internal.Format.FormatMessagesContextManager.OutputContext
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(1083, 31199, 31418);
                return return_v;
            }

        }
        private abstract class GroupOutputContext : FormatMessagesContextManager.OutputContext
        {
            internal GroupOutputContext(OutCommandInner cmd,
                                                FormatMessagesContextManager.OutputContext parentContext,
                                                GroupStartData formatData)
            : base(f_1083_32173_32186_C(parentContext))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1083, 31941, 32290);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 33447, 33492);
                    this.Data = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 33508, 33555);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 32220, 32239);

                    InnerCommand = cmd;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 32257, 32275);

                    Data = formatData;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1083, 31941, 32290);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 31941, 32290);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 31941, 32290);
                }
            }

            internal virtual void Initialize()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1083, 32477, 32515);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1083, 32477, 32515);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 32477, 32515);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 32477, 32515);
                }
            }

            internal virtual void GroupStart()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1083, 32710, 32748);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1083, 32710, 32748);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 32710, 32748);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 32710, 32748);
                }
            }

            internal virtual void GroupEnd()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1083, 32944, 32980);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1083, 32944, 32980);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 32944, 32980);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 32944, 32980);
                }
            }

            internal virtual void ProcessPayload(FormatEntryData fed)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1083, 33257, 33318);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1083, 33257, 33318);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 33257, 33318);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 33257, 33318);
                }
            }

            internal GroupStartData Data { get; }

            protected OutCommandInner InnerCommand { get; }

            static GroupOutputContext()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1083, 31716, 33566);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1083, 31716, 33566);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 31716, 33566);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1083, 31716, 33566);

            static Microsoft.PowerShell.Commands.Internal.Format.FormatMessagesContextManager.OutputContext
            f_1083_32173_32186_C(Microsoft.PowerShell.Commands.Internal.Format.FormatMessagesContextManager.OutputContext
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(1083, 31941, 32290);
                return return_v;
            }

        }
        private class TableOutputContextBase : GroupOutputContext
        {
            internal TableOutputContextBase(OutCommandInner cmd,
                            FormatMessagesContextManager.OutputContext parentContext,
                            GroupStartData formatData)
            : base(f_1083_34246_34249_C(cmd), parentContext, formatData)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1083, 34050, 34307);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 34661, 34693);
                    this._tableWriter = f_1083_34676_34693();
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1083, 34050, 34307);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 34050, 34307);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 34050, 34307);
                }
            }

            protected TableWriter Writer
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1083, 34465, 34493);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 34471, 34491);

                        return _tableWriter;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1083, 34465, 34493);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 34434, 34495);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 34434, 34495);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private TableWriter _tableWriter;

            static TableOutputContextBase()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1083, 33578, 34705);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1083, 33578, 34705);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 33578, 34705);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1083, 33578, 34705);

            static Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
            f_1083_34246_34249_C(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(1083, 34050, 34307);
                return return_v;
            }


            Microsoft.PowerShell.Commands.Internal.Format.TableWriter
            f_1083_34676_34693()
            {
                var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TableWriter();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 34676, 34693);
                return return_v;
            }

        }
        private sealed class TableOutputContext : TableOutputContextBase
        {
            private int _rowCount;

            private int _consoleHeight;

            private int _consoleWidth;

            private const int
            WhitespaceAndPagerLineCount = 2
            ;

            private bool _repeatHeader;

            internal TableOutputContext(OutCommandInner cmd,
                            FormatMessagesContextManager.OutputContext parentContext,
                            GroupStartData formatData)
            : base(f_1083_35634_35637_C(cmd), parentContext, formatData)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1083, 35442, 35969);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 34818, 34831);
                    this._rowCount = 0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 34858, 34877);
                    this._consoleHeight = -1;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 34904, 34922);
                    this._consoleWidth = -1;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 35014, 35035);
                    this._repeatHeader = false;
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 35698, 35954) || true) && (parentContext is FormatOutputContext foc)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 35698, 35954);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 35784, 35935) || true) && (f_1083_35788_35796(foc).shapeInfo is TableHeaderInfo thi)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 35784, 35935);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 35879, 35912);

                            _repeatHeader = thi.repeatHeader;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 35784, 35935);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 35698, 35954);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1083, 35442, 35969);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 35442, 35969);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 35442, 35969);
                }
            }

            internal override void Initialize()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1083, 36083, 37664);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 36151, 36249);

                    TableFormattingHint
                    tableHint = f_1083_36183_36225(f_1083_36183_36200(this)) as TableFormattingHint
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 36267, 36297);

                    int[]
                    columnWidthsHint = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 36384, 36508) || true) && (tableHint != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 36384, 36508);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 36447, 36489);

                        columnWidthsHint = tableHint.columnWidths;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 36384, 36508);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 36528, 36601);

                    _consoleHeight = f_1083_36545_36600(f_1083_36568_36599(f_1083_36568_36585(this)._lo));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 36619, 36693);

                    _consoleWidth = f_1083_36635_36692(f_1083_36657_36691(f_1083_36657_36674(this)._lo));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 36713, 36781);

                    int
                    columns = f_1083_36727_36780(f_1083_36727_36754(this).tableColumnInfoList)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 36799, 36883) || true) && (columns == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 36799, 36883);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 36857, 36864);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 36799, 36883);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 36962, 37063);

                    Span<int>
                    columnWidths = (DynAbs.Tracing.TraceSender.Conditional_F1(1083, 36987, 37017) || ((columns <= StackAllocThreshold && DynAbs.Tracing.TraceSender.Conditional_F2(1083, 37020, 37043)) || DynAbs.Tracing.TraceSender.Conditional_F3(1083, 37046, 37062))) ? stackalloc int[columns] : new int[columns]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 37081, 37179);

                    Span<int>
                    alignment = (DynAbs.Tracing.TraceSender.Conditional_F1(1083, 37103, 37133) || ((columns <= StackAllocThreshold && DynAbs.Tracing.TraceSender.Conditional_F2(1083, 37136, 37159)) || DynAbs.Tracing.TraceSender.Conditional_F3(1083, 37162, 37178))) ? stackalloc int[columns] : new int[columns]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 37199, 37209);

                    int
                    k = 0
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 37227, 37523);
                        foreach (TableColumnInfo tci in f_1083_37259_37306_I(f_1083_37259_37286(this).tableColumnInfoList))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 37227, 37523);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 37348, 37427);

                            columnWidths[k] = (DynAbs.Tracing.TraceSender.Conditional_F1(1083, 37366, 37392) || (((columnWidthsHint != null) && DynAbs.Tracing.TraceSender.Conditional_F2(1083, 37395, 37414)) || DynAbs.Tracing.TraceSender.Conditional_F3(1083, 37417, 37426))) ? columnWidthsHint[k] : tci.width;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 37449, 37478);

                            alignment[k] = tci.alignment;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 37500, 37504);

                            k++;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 37227, 37523);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1083, 1, 297);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1083, 1, 297);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 37543, 37649);

                    f_1083_37543_37648(f_1083_37543_37554(this), 0, _consoleWidth, columnWidths, alignment, f_1083_37609_37636(this).hideHeader);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1083, 36083, 37664);

                    Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                    f_1083_36183_36200(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.TableOutputContext
                    this_param)
                    {
                        var return_v = this_param.InnerCommand;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 36183, 36200);
                        return return_v;
                    }


                    Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.FormattingHint
                    f_1083_36183_36225(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                    this_param)
                    {
                        var return_v = this_param.RetrieveFormattingHint();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 36183, 36225);
                        return return_v;
                    }


                    Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                    f_1083_36568_36585(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.TableOutputContext
                    this_param)
                    {
                        var return_v = this_param.InnerCommand;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 36568, 36585);
                        return return_v;
                    }


                    int
                    f_1083_36568_36599(Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                    this_param)
                    {
                        var return_v = this_param.RowNumber;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 36568, 36599);
                        return return_v;
                    }


                    int
                    f_1083_36545_36600(int
                    rowNumber)
                    {
                        var return_v = GetConsoleWindowHeight(rowNumber);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 36545, 36600);
                        return return_v;
                    }


                    Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                    f_1083_36657_36674(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.TableOutputContext
                    this_param)
                    {
                        var return_v = this_param.InnerCommand;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 36657, 36674);
                        return return_v;
                    }


                    int
                    f_1083_36657_36691(Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                    this_param)
                    {
                        var return_v = this_param.ColumnNumber;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 36657, 36691);
                        return return_v;
                    }


                    int
                    f_1083_36635_36692(int
                    columnNumber)
                    {
                        var return_v = GetConsoleWindowWidth(columnNumber);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 36635, 36692);
                        return return_v;
                    }


                    Microsoft.PowerShell.Commands.Internal.Format.TableHeaderInfo
                    f_1083_36727_36754(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.TableOutputContext
                    this_param)
                    {
                        var return_v = this_param.CurrentTableHeaderInfo;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 36727, 36754);
                        return return_v;
                    }


                    int
                    f_1083_36727_36780(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableColumnInfo>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 36727, 36780);
                        return return_v;
                    }


                    Microsoft.PowerShell.Commands.Internal.Format.TableHeaderInfo
                    f_1083_37259_37286(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.TableOutputContext
                    this_param)
                    {
                        var return_v = this_param.CurrentTableHeaderInfo;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 37259, 37286);
                        return return_v;
                    }


                    System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableColumnInfo>
                    f_1083_37259_37306_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableColumnInfo>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 37259, 37306);
                        return return_v;
                    }


                    Microsoft.PowerShell.Commands.Internal.Format.TableWriter
                    f_1083_37543_37554(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.TableOutputContext
                    this_param)
                    {
                        var return_v = this_param.Writer;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 37543, 37554);
                        return return_v;
                    }


                    Microsoft.PowerShell.Commands.Internal.Format.TableHeaderInfo
                    f_1083_37609_37636(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.TableOutputContext
                    this_param)
                    {
                        var return_v = this_param.CurrentTableHeaderInfo;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 37609, 37636);
                        return return_v;
                    }


                    int
                    f_1083_37543_37648(Microsoft.PowerShell.Commands.Internal.Format.TableWriter
                    this_param, int
                    leftMarginIndent, int
                    screenColumns, System.Span<int>
                    columnWidths, System.Span<int>
                    alignment, bool
                    suppressHeader)
                    {
                        this_param.Initialize(leftMarginIndent, screenColumns, columnWidths, (System.ReadOnlySpan<int>)alignment, suppressHeader);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 37543, 37648);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 36083, 37664);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 36083, 37664);
                }
            }

            internal override void GroupStart()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1083, 37771, 38417);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 37839, 37907);

                    int
                    columns = f_1083_37853_37906(f_1083_37853_37880(this).tableColumnInfoList)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 37927, 38011) || true) && (columns == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 37927, 38011);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 37985, 37992);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 37927, 38011);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 38031, 38073);

                    string[]
                    properties = new string[columns]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 38091, 38101);

                    int
                    k = 0
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 38119, 38307);
                        foreach (TableColumnInfo tci in f_1083_38151_38198_I(f_1083_38151_38178(this).tableColumnInfoList))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 38119, 38307);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 38240, 38288);

                            properties[k++] = tci.label ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1083, 38258, 38287) ?? tci.propertyName);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 38119, 38307);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1083, 1, 189);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1083, 1, 189);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 38327, 38402);

                    _rowCount += f_1083_38340_38401(f_1083_38340_38351(this), properties, f_1083_38379_38396(this)._lo);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1083, 37771, 38417);

                    Microsoft.PowerShell.Commands.Internal.Format.TableHeaderInfo
                    f_1083_37853_37880(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.TableOutputContext
                    this_param)
                    {
                        var return_v = this_param.CurrentTableHeaderInfo;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 37853, 37880);
                        return return_v;
                    }


                    int
                    f_1083_37853_37906(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableColumnInfo>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 37853, 37906);
                        return return_v;
                    }


                    Microsoft.PowerShell.Commands.Internal.Format.TableHeaderInfo
                    f_1083_38151_38178(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.TableOutputContext
                    this_param)
                    {
                        var return_v = this_param.CurrentTableHeaderInfo;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 38151, 38178);
                        return return_v;
                    }


                    System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableColumnInfo>
                    f_1083_38151_38198_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableColumnInfo>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 38151, 38198);
                        return return_v;
                    }


                    Microsoft.PowerShell.Commands.Internal.Format.TableWriter
                    f_1083_38340_38351(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.TableOutputContext
                    this_param)
                    {
                        var return_v = this_param.Writer;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 38340, 38351);
                        return return_v;
                    }


                    Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                    f_1083_38379_38396(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.TableOutputContext
                    this_param)
                    {
                        var return_v = this_param.InnerCommand;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 38379, 38396);
                        return return_v;
                    }


                    int
                    f_1083_38340_38401(Microsoft.PowerShell.Commands.Internal.Format.TableWriter
                    this_param, string[]
                    values, Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                    lo)
                    {
                        var return_v = this_param.GenerateHeader(values, lo);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 38340, 38401);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 37771, 38417);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 37771, 38417);
                }
            }

            internal override void ProcessPayload(FormatEntryData fed)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1083, 38604, 40373);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 38695, 38769);

                    int
                    headerColumns = f_1083_38715_38768(f_1083_38715_38742(this).tableColumnInfoList)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 38789, 38879) || true) && (headerColumns == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 38789, 38879);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 38853, 38860);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 38789, 38879);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 38899, 39174) || true) && (_repeatHeader && (DynAbs.Tracing.TraceSender.Expression_True(1083, 38903, 38977) && _rowCount >= _consoleHeight - WhitespaceAndPagerLineCount))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 38899, 39174);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 39019, 39065);

                        f_1083_39019_39064(f_1083_39019_39036(this)._lo, string.Empty);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 39087, 39155);

                        _rowCount = f_1083_39099_39154(f_1083_39099_39110(this), null, f_1083_39132_39149(this)._lo);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 38899, 39174);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 39194, 39251);

                    TableRowEntry
                    tre = fed.formatEntryInfo as TableRowEntry
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 39372, 39416);

                    string[]
                    values = new string[headerColumns]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 39434, 39550);

                    Span<int>
                    alignment = (DynAbs.Tracing.TraceSender.Conditional_F1(1083, 39456, 39492) || ((headerColumns <= StackAllocThreshold && DynAbs.Tracing.TraceSender.Conditional_F2(1083, 39495, 39524)) || DynAbs.Tracing.TraceSender.Conditional_F3(1083, 39527, 39549))) ? stackalloc int[headerColumns] : new int[headerColumns]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 39570, 39621);

                    int
                    fieldCount = f_1083_39587_39620(tre.formatPropertyFieldList)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 39650, 39655);

                        for (int
        k = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 39641, 40175) || true) && (k < headerColumns)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 39676, 39679)
        , k++, DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 39641, 40175))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 39641, 40175);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 39721, 40156) || true) && (k < fieldCount)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 39721, 40156);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 39789, 39846);

                                values[k] = f_1083_39801_39831(tre.formatPropertyFieldList, k).propertyValue;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 39872, 39928);

                                alignment[k] = f_1083_39887_39917(tre.formatPropertyFieldList, k).alignment;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 39721, 40156);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 39721, 40156);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 40026, 40051);

                                values[k] = string.Empty;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 40077, 40111);

                                alignment[k] = TextAlignment.Left;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 39721, 40156);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1083, 1, 535);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1083, 1, 535);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 40195, 40328);

                    f_1083_40195_40327(f_1083_40195_40206(this), values, f_1083_40227_40244(this)._lo, tre.multiLine, alignment, f_1083_40276_40305(f_1083_40276_40288()._lo), generatedRows: null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 40346, 40358);

                    _rowCount++;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1083, 38604, 40373);

                    Microsoft.PowerShell.Commands.Internal.Format.TableHeaderInfo
                    f_1083_38715_38742(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.TableOutputContext
                    this_param)
                    {
                        var return_v = this_param.CurrentTableHeaderInfo;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 38715, 38742);
                        return return_v;
                    }


                    int
                    f_1083_38715_38768(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableColumnInfo>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 38715, 38768);
                        return return_v;
                    }


                    Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                    f_1083_39019_39036(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.TableOutputContext
                    this_param)
                    {
                        var return_v = this_param.InnerCommand;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 39019, 39036);
                        return return_v;
                    }


                    int
                    f_1083_39019_39064(Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                    this_param, string
                    s)
                    {
                        this_param.WriteLine(s);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 39019, 39064);
                        return 0;
                    }


                    Microsoft.PowerShell.Commands.Internal.Format.TableWriter
                    f_1083_39099_39110(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.TableOutputContext
                    this_param)
                    {
                        var return_v = this_param.Writer;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 39099, 39110);
                        return return_v;
                    }


                    Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                    f_1083_39132_39149(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.TableOutputContext
                    this_param)
                    {
                        var return_v = this_param.InnerCommand;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 39132, 39149);
                        return return_v;
                    }


                    int
                    f_1083_39099_39154(Microsoft.PowerShell.Commands.Internal.Format.TableWriter
                    this_param, string[]
                    values, Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                    lo)
                    {
                        var return_v = this_param.GenerateHeader(values, lo);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 39099, 39154);
                        return return_v;
                    }


                    int
                    f_1083_39587_39620(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatPropertyField>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 39587, 39620);
                        return return_v;
                    }


                    Microsoft.PowerShell.Commands.Internal.Format.FormatPropertyField
                    f_1083_39801_39831(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatPropertyField>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 39801, 39831);
                        return return_v;
                    }


                    Microsoft.PowerShell.Commands.Internal.Format.FormatPropertyField
                    f_1083_39887_39917(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatPropertyField>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 39887, 39917);
                        return return_v;
                    }


                    Microsoft.PowerShell.Commands.Internal.Format.TableWriter
                    f_1083_40195_40206(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.TableOutputContext
                    this_param)
                    {
                        var return_v = this_param.Writer;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 40195, 40206);
                        return return_v;
                    }


                    Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                    f_1083_40227_40244(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.TableOutputContext
                    this_param)
                    {
                        var return_v = this_param.InnerCommand;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 40227, 40244);
                        return return_v;
                    }


                    Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                    f_1083_40276_40288()
                    {
                        var return_v = InnerCommand;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 40276, 40288);
                        return return_v;
                    }


                    Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                    f_1083_40276_40305(Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                    this_param)
                    {
                        var return_v = this_param.DisplayCells;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 40276, 40305);
                        return return_v;
                    }


                    int
                    f_1083_40195_40327(Microsoft.PowerShell.Commands.Internal.Format.TableWriter
                    this_param, string[]
                    values, Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                    lo, bool
                    multiLine, System.Span<int>
                    alignment, Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                    dc, System.Collections.Generic.List<string>
                    generatedRows)
                    {
                        this_param.GenerateRow(values, lo, multiLine, (System.ReadOnlySpan<int>)alignment, dc, generatedRows: generatedRows);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 40195, 40327);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 38604, 40373);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 38604, 40373);
                }
            }

            private TableHeaderInfo CurrentTableHeaderInfo
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1083, 40468, 40598);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 40512, 40579);

                        return (TableHeaderInfo)f_1083_40536_40578(f_1083_40536_40553(this));
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1083, 40468, 40598);

                        Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                        f_1083_40536_40553(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.TableOutputContext
                        this_param)
                        {
                            var return_v = this_param.InnerCommand;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 40536, 40553);
                            return return_v;
                        }


                        Microsoft.PowerShell.Commands.Internal.Format.ShapeInfo
                        f_1083_40536_40578(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                        this_param)
                        {
                            var return_v = this_param.ShapeInfoOnFormatContext;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 40536, 40578);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 40389, 40613);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 40389, 40613);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static TableOutputContext()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1083, 34717, 40624);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 34955, 34986);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1083, 34717, 40624);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 34717, 40624);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1083, 34717, 40624);

            Microsoft.PowerShell.Commands.Internal.Format.FormatStartData
            f_1083_35788_35796(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.FormatOutputContext
            this_param)
            {
                var return_v = this_param.Data;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 35788, 35796);
                return return_v;
            }


            static Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
            f_1083_35634_35637_C(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(1083, 35442, 35969);
                return return_v;
            }

        }
        private sealed class ListOutputContext : GroupOutputContext
        {
            internal ListOutputContext(OutCommandInner cmd,
                            FormatMessagesContextManager.OutputContext parentContext,
                            GroupStartData formatData)
            : base(f_1083_41301_41304_C(cmd), parentContext, formatData)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1083, 41110, 41362);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 43800, 43818);
                    this._properties = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 43962, 43992);
                    this._listWriter = f_1083_43976_43992();
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1083, 41110, 41362);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 41110, 41362);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 41110, 41362);
                }
            }

            internal override void Initialize()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1083, 41476, 41541);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1083, 41476, 41541);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 41476, 41541);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 41476, 41541);
                }
            }

            private void InternalInitialize(ListViewEntry lve)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1083, 41557, 41809);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 41640, 41673);

                    _properties = f_1083_41654_41672(lve);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 41691, 41794);

                    f_1083_41691_41793(_listWriter, _properties, f_1083_41727_41761(f_1083_41727_41744(this)._lo), f_1083_41763_41792(f_1083_41763_41775()._lo));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1083, 41557, 41809);

                    string[]
                    f_1083_41654_41672(Microsoft.PowerShell.Commands.Internal.Format.ListViewEntry
                    lve)
                    {
                        var return_v = GetProperties(lve);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 41654, 41672);
                        return return_v;
                    }


                    Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                    f_1083_41727_41744(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.ListOutputContext
                    this_param)
                    {
                        var return_v = this_param.InnerCommand;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 41727, 41744);
                        return return_v;
                    }


                    int
                    f_1083_41727_41761(Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                    this_param)
                    {
                        var return_v = this_param.ColumnNumber;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 41727, 41761);
                        return return_v;
                    }


                    Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                    f_1083_41763_41775()
                    {
                        var return_v = InnerCommand;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 41763, 41775);
                        return return_v;
                    }


                    Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                    f_1083_41763_41792(Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                    this_param)
                    {
                        var return_v = this_param.DisplayCells;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 41763, 41792);
                        return return_v;
                    }


                    int
                    f_1083_41691_41793(Microsoft.PowerShell.Commands.Internal.Format.ListWriter
                    this_param, string[]
                    propertyNames, int
                    screenColumnWidth, Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                    dc)
                    {
                        this_param.Initialize(propertyNames, screenColumnWidth, dc);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 41691, 41793);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 41557, 41809);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 41557, 41809);
                }
            }

            internal static string[] GetProperties(ListViewEntry lve)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1083, 41825, 42358);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 41915, 41963);

                    StringCollection
                    props = f_1083_41940_41962()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 41981, 42134);
                        foreach (ListViewField lvf in f_1083_42011_42032_I(lve.listViewFieldList))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 41981, 42134);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 42074, 42115);

                            f_1083_42074_42114(props, lvf.label ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1083, 42084, 42113) ?? lvf.propertyName));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 41981, 42134);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1083, 1, 154);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1083, 1, 154);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 42154, 42209) || true) && (f_1083_42158_42169(props) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 42154, 42209);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 42197, 42209);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 42154, 42209);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 42227, 42269);

                    string[]
                    retVal = new string[f_1083_42256_42267(props)]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 42287, 42311);

                    f_1083_42287_42310(props, retVal, 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 42329, 42343);

                    return retVal;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1083, 41825, 42358);

                    System.Collections.Specialized.StringCollection
                    f_1083_41940_41962()
                    {
                        var return_v = new System.Collections.Specialized.StringCollection();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 41940, 41962);
                        return return_v;
                    }


                    int
                    f_1083_42074_42114(System.Collections.Specialized.StringCollection
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Add(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 42074, 42114);
                        return return_v;
                    }


                    System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ListViewField>
                    f_1083_42011_42032_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ListViewField>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 42011, 42032);
                        return return_v;
                    }


                    int
                    f_1083_42158_42169(System.Collections.Specialized.StringCollection
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 42158, 42169);
                        return return_v;
                    }


                    int
                    f_1083_42256_42267(System.Collections.Specialized.StringCollection
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 42256, 42267);
                        return return_v;
                    }


                    int
                    f_1083_42287_42310(System.Collections.Specialized.StringCollection
                    this_param, string[]
                    array, int
                    index)
                    {
                        this_param.CopyTo(array, index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 42287, 42310);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 41825, 42358);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 41825, 42358);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal static string[] GetValues(ListViewEntry lve)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1083, 42374, 42908);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 42460, 42507);

                    StringCollection
                    vals = f_1083_42484_42506()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 42527, 42687);
                        foreach (ListViewField lvf in f_1083_42557_42578_I(lve.listViewFieldList))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 42527, 42687);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 42620, 42668);

                            f_1083_42620_42667(vals, lvf.formatPropertyField.propertyValue);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 42527, 42687);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1083, 1, 161);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1083, 1, 161);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 42707, 42761) || true) && (f_1083_42711_42721(vals) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 42707, 42761);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 42749, 42761);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 42707, 42761);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 42779, 42820);

                    string[]
                    retVal = new string[f_1083_42808_42818(vals)]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 42838, 42861);

                    f_1083_42838_42860(vals, retVal, 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 42879, 42893);

                    return retVal;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1083, 42374, 42908);

                    System.Collections.Specialized.StringCollection
                    f_1083_42484_42506()
                    {
                        var return_v = new System.Collections.Specialized.StringCollection();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 42484, 42506);
                        return return_v;
                    }


                    int
                    f_1083_42620_42667(System.Collections.Specialized.StringCollection
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Add(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 42620, 42667);
                        return return_v;
                    }


                    System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ListViewField>
                    f_1083_42557_42578_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ListViewField>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 42557, 42578);
                        return return_v;
                    }


                    int
                    f_1083_42711_42721(System.Collections.Specialized.StringCollection
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 42711, 42721);
                        return return_v;
                    }


                    int
                    f_1083_42808_42818(System.Collections.Specialized.StringCollection
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 42808, 42818);
                        return return_v;
                    }


                    int
                    f_1083_42838_42860(System.Collections.Specialized.StringCollection
                    this_param, string[]
                    array, int
                    index)
                    {
                        this_param.CopyTo(array, index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 42838, 42860);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 42374, 42908);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 42374, 42908);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override void GroupStart()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1083, 43015, 43080);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1083, 43015, 43080);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 43015, 43080);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 43015, 43080);
                }
            }

            internal override void ProcessPayload(FormatEntryData fed)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1083, 43266, 43663);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 43357, 43414);

                    ListViewEntry
                    lve = fed.formatEntryInfo as ListViewEntry
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 43432, 43456);

                    f_1083_43432_43455(this, lve);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 43474, 43507);

                    string[]
                    values = f_1083_43492_43506(lve)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 43525, 43584);

                    f_1083_43525_43583(_listWriter, values, f_1083_43561_43578(this)._lo);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 43602, 43648);

                    f_1083_43602_43647(f_1083_43602_43619(this)._lo, string.Empty);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1083, 43266, 43663);

                    int
                    f_1083_43432_43455(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.ListOutputContext
                    this_param, Microsoft.PowerShell.Commands.Internal.Format.ListViewEntry
                    lve)
                    {
                        this_param.InternalInitialize(lve);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 43432, 43455);
                        return 0;
                    }


                    string[]
                    f_1083_43492_43506(Microsoft.PowerShell.Commands.Internal.Format.ListViewEntry
                    lve)
                    {
                        var return_v = GetValues(lve);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 43492, 43506);
                        return return_v;
                    }


                    Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                    f_1083_43561_43578(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.ListOutputContext
                    this_param)
                    {
                        var return_v = this_param.InnerCommand;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 43561, 43578);
                        return return_v;
                    }


                    int
                    f_1083_43525_43583(Microsoft.PowerShell.Commands.Internal.Format.ListWriter
                    this_param, string[]
                    values, Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                    lo)
                    {
                        this_param.WriteProperties(values, lo);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 43525, 43583);
                        return 0;
                    }


                    Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                    f_1083_43602_43619(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.ListOutputContext
                    this_param)
                    {
                        var return_v = this_param.InnerCommand;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 43602, 43619);
                        return return_v;
                    }


                    int
                    f_1083_43602_43647(Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                    this_param, string
                    s)
                    {
                        this_param.WriteLine(s);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 43602, 43647);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 43266, 43663);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 43266, 43663);
                }
            }

            private string[] _properties;

            private ListWriter _listWriter;

            static ListOutputContext()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1083, 40636, 44004);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1083, 40636, 44004);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 40636, 44004);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1083, 40636, 44004);

            static Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
            f_1083_41301_41304_C(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(1083, 41110, 41362);
                return return_v;
            }


            Microsoft.PowerShell.Commands.Internal.Format.ListWriter
            f_1083_43976_43992()
            {
                var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ListWriter();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 43976, 43992);
                return return_v;
            }

        }
        private sealed class WideOutputContext : TableOutputContextBase
        {
            internal WideOutputContext(OutCommandInner cmd,
                            FormatMessagesContextManager.OutputContext parentContext,
                            GroupStartData formatData)
            : base(f_1083_44685_44688_C(cmd), parentContext, formatData)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1083, 44494, 44746);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 44789, 44803);
                    this._buffer = null;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1083, 44494, 44746);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 44494, 44746);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 44494, 44746);
                }
            }

            private StringValuesBuffer _buffer;

            internal override void Initialize()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1083, 44918, 46623);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 45075, 45095);

                    int
                    itemsPerRow = 2
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 45173, 45264);

                    WideFormattingHint
                    hint = f_1083_45199_45241(f_1083_45199_45216(this)) as WideFormattingHint
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 45284, 45367);

                    int
                    columnsOnTheScreen = f_1083_45309_45366(f_1083_45331_45365(f_1083_45331_45348(this)._lo))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 45447, 45815) || true) && (hint != null && (DynAbs.Tracing.TraceSender.Expression_True(1083, 45451, 45484) && hint.maxWidth > 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 45447, 45815);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 45526, 45621);

                        itemsPerRow = f_1083_45540_45620(hint.maxWidth, columnsOnTheScreen);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 45447, 45815);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 45447, 45815);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 45663, 45815) || true) && (f_1083_45667_45693(this).columns > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 45663, 45815);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 45747, 45796);

                            itemsPerRow = f_1083_45761_45787(this).columns;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 45663, 45815);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 45447, 45815);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 45899, 45945);

                    _buffer = f_1083_45909_45944(itemsPerRow);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 46007, 46120);

                    Span<int>
                    columnWidths = (DynAbs.Tracing.TraceSender.Conditional_F1(1083, 46032, 46066) || ((itemsPerRow <= StackAllocThreshold && DynAbs.Tracing.TraceSender.Conditional_F2(1083, 46069, 46096)) || DynAbs.Tracing.TraceSender.Conditional_F3(1083, 46099, 46119))) ? stackalloc int[itemsPerRow] : new int[itemsPerRow]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 46138, 46248);

                    Span<int>
                    alignment = (DynAbs.Tracing.TraceSender.Conditional_F1(1083, 46160, 46194) || ((itemsPerRow <= StackAllocThreshold && DynAbs.Tracing.TraceSender.Conditional_F2(1083, 46197, 46224)) || DynAbs.Tracing.TraceSender.Conditional_F3(1083, 46227, 46247))) ? stackalloc int[itemsPerRow] : new int[itemsPerRow]
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 46277, 46282);

                        for (int
        k = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 46268, 46453) || true) && (k < itemsPerRow)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 46301, 46304)
        , k++, DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 46268, 46453))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 46268, 46453);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 46346, 46366);

                            columnWidths[k] = 0;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 46400, 46434);

                            alignment[k] = TextAlignment.Left;
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1083, 1, 186);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1083, 1, 186);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 46473, 46608);

                    f_1083_46473_46607(f_1083_46473_46484(this), 0, columnsOnTheScreen, columnWidths, alignment, false, f_1083_46551_46606(f_1083_46574_46605(f_1083_46574_46591(this)._lo)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1083, 44918, 46623);

                    Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                    f_1083_45199_45216(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.WideOutputContext
                    this_param)
                    {
                        var return_v = this_param.InnerCommand;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 45199, 45216);
                        return return_v;
                    }


                    Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.FormattingHint
                    f_1083_45199_45241(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                    this_param)
                    {
                        var return_v = this_param.RetrieveFormattingHint();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 45199, 45241);
                        return return_v;
                    }


                    Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                    f_1083_45331_45348(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.WideOutputContext
                    this_param)
                    {
                        var return_v = this_param.InnerCommand;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 45331, 45348);
                        return return_v;
                    }


                    int
                    f_1083_45331_45365(Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                    this_param)
                    {
                        var return_v = this_param.ColumnNumber;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 45331, 45365);
                        return return_v;
                    }


                    int
                    f_1083_45309_45366(int
                    columnNumber)
                    {
                        var return_v = GetConsoleWindowWidth(columnNumber);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 45309, 45366);
                        return return_v;
                    }


                    int
                    f_1083_45540_45620(int
                    stringLen, int
                    screenColumns)
                    {
                        var return_v = TableWriter.ComputeWideViewBestItemsPerRowFit(stringLen, screenColumns);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 45540, 45620);
                        return return_v;
                    }


                    Microsoft.PowerShell.Commands.Internal.Format.WideViewHeaderInfo
                    f_1083_45667_45693(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.WideOutputContext
                    this_param)
                    {
                        var return_v = this_param.CurrentWideHeaderInfo;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 45667, 45693);
                        return return_v;
                    }


                    Microsoft.PowerShell.Commands.Internal.Format.WideViewHeaderInfo
                    f_1083_45761_45787(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.WideOutputContext
                    this_param)
                    {
                        var return_v = this_param.CurrentWideHeaderInfo;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 45761, 45787);
                        return return_v;
                    }


                    Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.WideOutputContext.StringValuesBuffer
                    f_1083_45909_45944(int
                    size)
                    {
                        var return_v = new Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.WideOutputContext.StringValuesBuffer(size);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 45909, 45944);
                        return return_v;
                    }


                    Microsoft.PowerShell.Commands.Internal.Format.TableWriter
                    f_1083_46473_46484(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.WideOutputContext
                    this_param)
                    {
                        var return_v = this_param.Writer;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 46473, 46484);
                        return return_v;
                    }


                    Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                    f_1083_46574_46591(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.WideOutputContext
                    this_param)
                    {
                        var return_v = this_param.InnerCommand;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 46574, 46591);
                        return return_v;
                    }


                    int
                    f_1083_46574_46605(Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                    this_param)
                    {
                        var return_v = this_param.RowNumber;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 46574, 46605);
                        return return_v;
                    }


                    int
                    f_1083_46551_46606(int
                    rowNumber)
                    {
                        var return_v = GetConsoleWindowHeight(rowNumber);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 46551, 46606);
                        return return_v;
                    }


                    int
                    f_1083_46473_46607(Microsoft.PowerShell.Commands.Internal.Format.TableWriter
                    this_param, int
                    leftMarginIndent, int
                    screenColumns, System.Span<int>
                    columnWidths, System.Span<int>
                    alignment, bool
                    suppressHeader, int
                    screenRows)
                    {
                        this_param.Initialize(leftMarginIndent, screenColumns, columnWidths, (System.ReadOnlySpan<int>)alignment, suppressHeader, screenRows);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 46473, 46607);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 44918, 46623);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 44918, 46623);
                }
            }

            internal override void GroupStart()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1083, 46730, 46795);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1083, 46730, 46795);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 46730, 46795);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 46730, 46795);
                }
            }

            internal override void GroupEnd()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1083, 46967, 47068);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 47033, 47053);

                    f_1083_47033_47052(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1083, 46967, 47068);

                    int
                    f_1083_47033_47052(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.WideOutputContext
                    this_param)
                    {
                        this_param.WriteStringBuffer();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 47033, 47052);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 46967, 47068);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 46967, 47068);
                }
            }

            internal override void ProcessPayload(FormatEntryData fed)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1083, 47255, 47675);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 47346, 47403);

                    WideViewEntry
                    wve = fed.formatEntryInfo as WideViewEntry
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 47421, 47494);

                    FormatPropertyField
                    fpf = wve.formatPropertyField as FormatPropertyField
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 47512, 47543);

                    f_1083_47512_47542(_buffer, fpf.propertyValue);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 47561, 47660) || true) && (f_1083_47565_47579(_buffer))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 47561, 47660);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 47621, 47641);

                        f_1083_47621_47640(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 47561, 47660);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1083, 47255, 47675);

                    int
                    f_1083_47512_47542(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.WideOutputContext.StringValuesBuffer
                    this_param, string
                    s)
                    {
                        this_param.Add(s);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 47512, 47542);
                        return 0;
                    }


                    bool
                    f_1083_47565_47579(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.WideOutputContext.StringValuesBuffer
                    this_param)
                    {
                        var return_v = this_param.IsFull;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 47565, 47579);
                        return return_v;
                    }


                    int
                    f_1083_47621_47640(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.WideOutputContext
                    this_param)
                    {
                        this_param.WriteStringBuffer();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 47621, 47640);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 47255, 47675);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 47255, 47675);
                }
            }

            private WideViewHeaderInfo CurrentWideHeaderInfo
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1083, 47772, 47905);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 47816, 47886);

                        return (WideViewHeaderInfo)f_1083_47843_47885(f_1083_47843_47860(this));
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1083, 47772, 47905);

                        Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                        f_1083_47843_47860(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.WideOutputContext
                        this_param)
                        {
                            var return_v = this_param.InnerCommand;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 47843, 47860);
                            return return_v;
                        }


                        Microsoft.PowerShell.Commands.Internal.Format.ShapeInfo
                        f_1083_47843_47885(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                        this_param)
                        {
                            var return_v = this_param.ShapeInfoOnFormatContext;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 47843, 47885);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 47691, 47920);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 47691, 47920);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private void WriteStringBuffer()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1083, 47936, 48614);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 48001, 48088) || true) && (f_1083_48005_48020(_buffer))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 48001, 48088);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 48062, 48069);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 48001, 48088);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 48108, 48153);

                    string[]
                    values = new string[f_1083_48137_48151(_buffer)]
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 48180, 48185);
                        for (int
        k = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 48171, 48425) || true) && (k < f_1083_48191_48204(values))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 48206, 48209)
        , k++, DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 48171, 48425))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 48171, 48425);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 48251, 48406) || true) && (k < f_1083_48259_48279(_buffer))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 48251, 48406);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 48306, 48329);

                                values[k] = f_1083_48318_48328(_buffer, k);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 48251, 48406);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 48251, 48406);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 48381, 48406);

                                values[k] = string.Empty;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 48251, 48406);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1083, 1, 255);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1083, 1, 255);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 48445, 48565);

                    f_1083_48445_48564(f_1083_48445_48456(this), values, f_1083_48477_48494(this)._lo, false, null, f_1083_48513_48542(f_1083_48513_48525()._lo), generatedRows: null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 48583, 48599);

                    f_1083_48583_48598(_buffer);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1083, 47936, 48614);

                    bool
                    f_1083_48005_48020(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.WideOutputContext.StringValuesBuffer
                    this_param)
                    {
                        var return_v = this_param.IsEmpty;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 48005, 48020);
                        return return_v;
                    }


                    int
                    f_1083_48137_48151(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.WideOutputContext.StringValuesBuffer
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 48137, 48151);
                        return return_v;
                    }


                    int
                    f_1083_48191_48204(string[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 48191, 48204);
                        return return_v;
                    }


                    int
                    f_1083_48259_48279(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.WideOutputContext.StringValuesBuffer
                    this_param)
                    {
                        var return_v = this_param.CurrentCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 48259, 48279);
                        return return_v;
                    }


                    string
                    f_1083_48318_48328(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.WideOutputContext.StringValuesBuffer
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 48318, 48328);
                        return return_v;
                    }


                    Microsoft.PowerShell.Commands.Internal.Format.TableWriter
                    f_1083_48445_48456(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.WideOutputContext
                    this_param)
                    {
                        var return_v = this_param.Writer;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 48445, 48456);
                        return return_v;
                    }


                    Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                    f_1083_48477_48494(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.WideOutputContext
                    this_param)
                    {
                        var return_v = this_param.InnerCommand;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 48477, 48494);
                        return return_v;
                    }


                    Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                    f_1083_48513_48525()
                    {
                        var return_v = InnerCommand;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 48513, 48525);
                        return return_v;
                    }


                    Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                    f_1083_48513_48542(Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                    this_param)
                    {
                        var return_v = this_param.DisplayCells;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 48513, 48542);
                        return return_v;
                    }


                    int
                    f_1083_48445_48564(Microsoft.PowerShell.Commands.Internal.Format.TableWriter
                    this_param, string[]
                    values, Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                    lo, bool
                    multiLine, int[]
                    alignment, Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                    dc, System.Collections.Generic.List<string>
                    generatedRows)
                    {
                        this_param.GenerateRow(values, lo, multiLine, (System.ReadOnlySpan<int>)alignment, dc, generatedRows: generatedRows);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 48445, 48564);
                        return 0;
                    }


                    int
                    f_1083_48583_48598(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.WideOutputContext.StringValuesBuffer
                    this_param)
                    {
                        this_param.Reset();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 48583, 48598);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 47936, 48614);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 47936, 48614);
                }
            }
            private class StringValuesBuffer
            {
                internal StringValuesBuffer(int size)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(1083, 49084, 49235);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 51007, 51011);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 51042, 51056);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 49162, 49186);

                        _arr = new string[size];
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 49208, 49216);

                        f_1083_49208_49215(this);
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(1083, 49084, 49235);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 49084, 49235);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 49084, 49235);
                    }
                }

                internal int Length
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(1083, 49387, 49414);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 49393, 49412);

                            return f_1083_49400_49411(_arr);
                            DynAbs.Tracing.TraceSender.TraceExitMethod(1083, 49387, 49414);

                            int
                            f_1083_49400_49411(string[]
                            this_param)
                            {
                                var return_v = this_param.Length;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 49400, 49411);
                                return return_v;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 49365, 49416);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 49365, 49416);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                internal int CurrentCount
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(1083, 49597, 49627);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 49603, 49625);

                            return _lastEmptySpot;
                            DynAbs.Tracing.TraceSender.TraceExitMethod(1083, 49597, 49627);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 49569, 49629);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 49569, 49629);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                internal bool IsFull
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(1083, 49823, 49868);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 49829, 49866);

                            return _lastEmptySpot == f_1083_49854_49865(_arr);
                            DynAbs.Tracing.TraceSender.TraceExitMethod(1083, 49823, 49868);

                            int
                            f_1083_49854_49865(string[]
                            this_param)
                            {
                                var return_v = this_param.Length;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 49854, 49865);
                                return return_v;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 49762, 49887);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 49762, 49887);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                internal bool IsEmpty
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(1083, 50083, 50118);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 50089, 50116);

                            return _lastEmptySpot == 0;
                            DynAbs.Tracing.TraceSender.TraceExitMethod(1083, 50083, 50118);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 50021, 50137);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 50021, 50137);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                /// <summary>
                /// Indexer to access the k-th item in the buffer.
                /// </summary>
                internal string this[int k]
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(1083, 50318, 50341);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 50324, 50339);

                            return _arr[k];
                            DynAbs.Tracing.TraceSender.TraceExitMethod(1083, 50318, 50341);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 50318, 50341);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 50318, 50341);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                internal void Add(string s)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1083, 50534, 50648);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 50602, 50629);

                        _arr[_lastEmptySpot++] = s;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1083, 50534, 50648);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 50534, 50648);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 50534, 50648);
                    }
                }

                internal void Reset()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1083, 50770, 50970);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 50832, 50851);

                        _lastEmptySpot = 0;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 50882, 50887);
                            for (int
        k = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 50873, 50951) || true) && (k < f_1083_50893_50904(_arr))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 50906, 50909)
        , k++, DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 50873, 50951))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 50873, 50951);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 50936, 50951);

                                _arr[k] = null;
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1083, 1, 79);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1083, 1, 79);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1083, 50770, 50970);

                        int
                        f_1083_50893_50904(string[]
                        this_param)
                        {
                            var return_v = this_param.Length;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 50893, 50904);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 50770, 50970);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 50770, 50970);
                    }
                }

                private string[] _arr;

                private int _lastEmptySpot;

                static StringValuesBuffer()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1083, 48837, 51072);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1083, 48837, 51072);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 48837, 51072);
                }

                int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1083, 48837, 51072);

                int
                f_1083_49208_49215(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.WideOutputContext.StringValuesBuffer
                this_param)
                {
                    this_param.Reset();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 49208, 49215);
                    return 0;
                }

            }

            static WideOutputContext()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1083, 44016, 51083);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1083, 44016, 51083);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 44016, 51083);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1083, 44016, 51083);

            static Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
            f_1083_44685_44688_C(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(1083, 44494, 44746);
                return return_v;
            }

        }
        private sealed class ComplexOutputContext : GroupOutputContext
        {
            internal ComplexOutputContext(OutCommandInner cmd,
                            FormatMessagesContextManager.OutputContext parentContext,
                            GroupStartData formatData)
            : base(f_1083_51766_51769_C(cmd), parentContext, formatData)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1083, 51572, 51827);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 52587, 52616);
                    this._writer = f_1083_52597_52616();
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1083, 51572, 51827);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 51572, 51827);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 51572, 51827);
                }
            }

            internal override void Initialize()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1083, 51843, 52041);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 51911, 52026);

                    f_1083_51911_52025(_writer, f_1083_51930_51947(this)._lo, f_1083_51990_52024(f_1083_51990_52007(this)._lo));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1083, 51843, 52041);

                    Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                    f_1083_51930_51947(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.ComplexOutputContext
                    this_param)
                    {
                        var return_v = this_param.InnerCommand;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 51930, 51947);
                        return return_v;
                    }


                    Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
                    f_1083_51990_52007(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner.ComplexOutputContext
                    this_param)
                    {
                        var return_v = this_param.InnerCommand;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 51990, 52007);
                        return return_v;
                    }


                    int
                    f_1083_51990_52024(Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                    this_param)
                    {
                        var return_v = this_param.ColumnNumber;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1083, 51990, 52024);
                        return return_v;
                    }


                    int
                    f_1083_51911_52025(Microsoft.PowerShell.Commands.Internal.Format.ComplexWriter
                    this_param, Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                    lineOutput, int
                    numberOfTextColumns)
                    {
                        this_param.Initialize(lineOutput, numberOfTextColumns);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 51911, 52025);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 51843, 52041);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 51843, 52041);
                }
            }

            internal override void ProcessPayload(FormatEntryData fed)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1083, 52227, 52549);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 52318, 52381);

                    ComplexViewEntry
                    cve = fed.formatEntryInfo as ComplexViewEntry
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 52399, 52475) || true) && (cve == null || (DynAbs.Tracing.TraceSender.Expression_False(1083, 52403, 52445) || cve.formatValueList == null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1083, 52399, 52475);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 52468, 52475);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1083, 52399, 52475);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 52493, 52534);

                    f_1083_52493_52533(_writer, cve.formatValueList);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1083, 52227, 52549);

                    int
                    f_1083_52493_52533(Microsoft.PowerShell.Commands.Internal.Format.ComplexWriter
                    this_param, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                    formatValueList)
                    {
                        this_param.WriteObject(formatValueList);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 52493, 52533);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1083, 52227, 52549);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 52227, 52549);
                }
            }

            private ComplexWriter _writer;

            static ComplexOutputContext()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1083, 51095, 52628);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1083, 51095, 52628);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 51095, 52628);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1083, 51095, 52628);

            static Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
            f_1083_51766_51769_C(Microsoft.PowerShell.Commands.Internal.Format.OutCommandInner
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(1083, 51572, 51827);
                return return_v;
            }


            Microsoft.PowerShell.Commands.Internal.Format.ComplexWriter
            f_1083_52597_52616()
            {
                var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ComplexWriter();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 52597, 52616);
                return return_v;
            }

        }

        public OutCommandInner()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1083, 510, 52635);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 8830, 8877);
            this._currentFormattingState = FormattingState.Reset;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 9062, 9070);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 22252, 22262);
            this._lo = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 23510, 23558);
            this._ctxManager = f_1083_23524_23558();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 23601, 23614);
            this._cache = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 30270, 30292);
            this._formattingHint = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 30665, 30690);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1083, 510, 52635);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 510, 52635);
        }


        static OutCommandInner()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1083, 510, 52635);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 711, 792);
            tracer = f_1083_720_792("format_out_OutCommandInner", "OutCommandInner");
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 9276, 9301);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 9330, 9365);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1083, 9395, 9420);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1083, 510, 52635);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1083, 510, 52635);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1083, 510, 52635);

        static System.Management.Automation.PSTraceSource
        f_1083_720_792(string
        name, string
        description)
        {
            var return_v = PSTraceSource.GetTracer(name, description);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 720, 792);
            return return_v;
        }


        Microsoft.PowerShell.Commands.Internal.Format.FormatMessagesContextManager
        f_1083_23524_23558()
        {
            var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatMessagesContextManager();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1083, 23524, 23558);
            return return_v;
        }

    }
}

