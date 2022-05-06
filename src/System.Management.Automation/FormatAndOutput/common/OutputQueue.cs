// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Microsoft.PowerShell.Commands.Internal.Format
{
    internal sealed class OutputGroupQueue
    {
        internal OutputGroupQueue(FormattedObjectsCache.ProcessCachedGroupNotification callBack, int objectCount)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1100, 834, 1049);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 5756, 5792);
                this._queue = f_1100_5765_5792();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 6006, 6022);
                this._objectCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 6319, 6356);
                this._groupingDuration = TimeSpan.MinValue;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 6385, 6406);
                this._groupingTimer = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 6644, 6672);
                this._notificationCallBack = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 6816, 6839);
                this._formatStartData = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 6962, 6986);
                this._processingGroup = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 7093, 7116);
                this._currentObjectCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 964, 997);

                _notificationCallBack = callBack;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 1011, 1038);

                _objectCount = objectCount;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1100, 834, 1049);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1100, 834, 1049);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1100, 834, 1049);
            }
        }

        internal OutputGroupQueue(FormattedObjectsCache.ProcessCachedGroupNotification callBack, TimeSpan groupingDuration)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1100, 1377, 1612);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 5756, 5792);
                this._queue = f_1100_5765_5792();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 6006, 6022);
                this._objectCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 6319, 6356);
                this._groupingDuration = TimeSpan.MinValue;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 6385, 6406);
                this._groupingTimer = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 6644, 6672);
                this._notificationCallBack = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 6816, 6839);
                this._formatStartData = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 6962, 6986);
                this._processingGroup = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 7093, 7116);
                this._currentObjectCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 1517, 1550);

                _notificationCallBack = callBack;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 1564, 1601);

                _groupingDuration = groupingDuration;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1100, 1377, 1612);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1100, 1377, 1612);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1100, 1377, 1612);
            }
        }

        internal List<PacketInfoData> Add(PacketInfoData o)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1100, 1847, 4250);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 1923, 1966);

                FormatStartData
                fsd = o as FormatStartData
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 1980, 2148) || true) && (fsd != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1100, 1980, 2148);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 2110, 2133);

                    _formatStartData = fsd;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1100, 1980, 2148);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 2164, 2185);

                f_1100_2164_2184(this, o);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 2270, 2715) || true) && (!_processingGroup && (DynAbs.Tracing.TraceSender.Expression_True(1100, 2274, 2316) && (o is GroupStartData)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1100, 2270, 2715);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 2406, 2430);

                    _processingGroup = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 2448, 2472);

                    _currentObjectCount = 0;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 2492, 2632) || true) && (_groupingDuration > TimeSpan.MinValue)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1100, 2492, 2632);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 2575, 2613);

                        _groupingTimer = f_1100_2592_2612();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1100, 2492, 2632);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 2652, 2670);

                    f_1100_2652_2669(
                                    _queue, o);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 2688, 2700);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1100, 2270, 2715);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 2795, 3816) || true) && (_processingGroup && (DynAbs.Tracing.TraceSender.Expression_True(1100, 2799, 2937) && ((o is GroupEndData) || (DynAbs.Tracing.TraceSender.Expression_False(1100, 2837, 2936) || (_objectCount > 0) && (DynAbs.Tracing.TraceSender.Expression_True(1100, 2877, 2936) && (_currentObjectCount >= _objectCount))))) || (DynAbs.Tracing.TraceSender.Expression_False(1100, 2799, 3032) || ((_groupingTimer != null) && (DynAbs.Tracing.TraceSender.Expression_True(1100, 2959, 3031) && (f_1100_2988_3010(_groupingTimer) > _groupingDuration)))
                ))
                                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1100, 2795, 3816);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 3127, 3151);

                    _currentObjectCount = 0;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 3171, 3324) || true) && (_groupingTimer != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1100, 3171, 3324);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 3239, 3261);

                        f_1100_3239_3260(_groupingTimer);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 3283, 3305);

                        _groupingTimer = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1100, 3171, 3324);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 3401, 3419);

                    f_1100_3401_3418(
                                    // add object to queue, to be picked up
                                    _queue, o);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 3505, 3514);

                    f_1100_3505_3513(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 3532, 3557);

                    _processingGroup = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 3577, 3634);

                    List<PacketInfoData>
                    retVal = f_1100_3607_3633()
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 3654, 3767) || true) && (f_1100_3661_3673(_queue) > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1100, 3654, 3767);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 3719, 3748);

                            f_1100_3719_3747(retVal, f_1100_3730_3746(_queue));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1100, 3654, 3767);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1100, 3654, 3767);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1100, 3654, 3767);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 3787, 3801);

                    return retVal;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1100, 2795, 3816);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 3895, 4060) || true) && (_processingGroup)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1100, 3895, 4060);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 3997, 4015);

                    f_1100_3997_4014(                // we are in the caching state
                                    _queue, o);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 4033, 4045);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1100, 3895, 4060);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 4133, 4187);

                List<PacketInfoData>
                ret = f_1100_4160_4186()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 4203, 4214);

                f_1100_4203_4213(
                            ret, o);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 4228, 4239);

                return ret;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1100, 1847, 4250);

                int
                f_1100_2164_2184(Microsoft.PowerShell.Commands.Internal.Format.OutputGroupQueue
                this_param, Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData
                o)
                {
                    this_param.UpdateObjectCount(o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1100, 2164, 2184);
                    return 0;
                }


                System.Diagnostics.Stopwatch
                f_1100_2592_2612()
                {
                    var return_v = Stopwatch.StartNew();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1100, 2592, 2612);
                    return return_v;
                }


                int
                f_1100_2652_2669(System.Collections.Generic.Queue<Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData
                item)
                {
                    this_param.Enqueue(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1100, 2652, 2669);
                    return 0;
                }


                System.TimeSpan
                f_1100_2988_3010(System.Diagnostics.Stopwatch
                this_param)
                {
                    var return_v = this_param.Elapsed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1100, 2988, 3010);
                    return return_v;
                }


                int
                f_1100_3239_3260(System.Diagnostics.Stopwatch
                this_param)
                {
                    this_param.Stop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1100, 3239, 3260);
                    return 0;
                }


                int
                f_1100_3401_3418(System.Collections.Generic.Queue<Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData
                item)
                {
                    this_param.Enqueue(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1100, 3401, 3418);
                    return 0;
                }


                int
                f_1100_3505_3513(Microsoft.PowerShell.Commands.Internal.Format.OutputGroupQueue
                this_param)
                {
                    this_param.Notify();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1100, 3505, 3513);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData>
                f_1100_3607_3633()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1100, 3607, 3633);
                    return return_v;
                }


                int
                f_1100_3661_3673(System.Collections.Generic.Queue<Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1100, 3661, 3673);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData
                f_1100_3730_3746(System.Collections.Generic.Queue<Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData>
                this_param)
                {
                    var return_v = this_param.Dequeue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1100, 3730, 3746);
                    return return_v;
                }


                int
                f_1100_3719_3747(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1100, 3719, 3747);
                    return 0;
                }


                int
                f_1100_3997_4014(System.Collections.Generic.Queue<Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData
                item)
                {
                    this_param.Enqueue(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1100, 3997, 4014);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData>
                f_1100_4160_4186()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1100, 4160, 4186);
                    return return_v;
                }


                int
                f_1100_4203_4213(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1100, 4203, 4213);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1100, 1847, 4250);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1100, 1847, 4250);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void UpdateObjectCount(PacketInfoData o)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1100, 4262, 4597);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 4431, 4474);

                FormatEntryData
                fed = o as FormatEntryData
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 4490, 4548) || true) && (fed == null || (DynAbs.Tracing.TraceSender.Expression_False(1100, 4494, 4522) || fed.outOfBand))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1100, 4490, 4548);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 4541, 4548);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1100, 4490, 4548);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 4564, 4586);

                _currentObjectCount++;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1100, 4262, 4597);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1100, 4262, 4597);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1100, 4262, 4597);
            }
        }

        private void Notify()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1100, 4609, 5263);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 4655, 4714) || true) && (_notificationCallBack == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1100, 4655, 4714);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 4707, 4714);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1100, 4655, 4714);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 4854, 4917);

                List<PacketInfoData>
                validObjects = f_1100_4890_4916()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 4933, 5182);
                    foreach (PacketInfoData x in f_1100_4962_4968_I(_queue))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1100, 4933, 5182);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 5002, 5045);

                        FormatEntryData
                        fed = x as FormatEntryData
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 5063, 5127) || true) && (fed != null && (DynAbs.Tracing.TraceSender.Expression_True(1100, 5067, 5095) && fed.outOfBand))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1100, 5063, 5127);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 5118, 5127);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1100, 5063, 5127);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 5147, 5167);

                        f_1100_5147_5166(
                                        validObjects, x);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1100, 4933, 5182);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1100, 1, 250);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1100, 1, 250);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 5198, 5252);

                f_1100_5198_5251(this, _formatStartData, validObjects);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1100, 4609, 5263);

                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData>
                f_1100_4890_4916()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1100, 4890, 4916);
                    return return_v;
                }


                int
                f_1100_5147_5166(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1100, 5147, 5166);
                    return 0;
                }


                System.Collections.Generic.Queue<Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData>
                f_1100_4962_4968_I(System.Collections.Generic.Queue<Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1100, 4962, 4968);
                    return return_v;
                }


                int
                f_1100_5198_5251(Microsoft.PowerShell.Commands.Internal.Format.OutputGroupQueue
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatStartData
                formatStartData, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData>
                objects)
                {
                    this_param._notificationCallBack(formatStartData, objects);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1100, 5198, 5251);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1100, 4609, 5263);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1100, 4609, 5263);
            }
        }

        internal PacketInfoData Dequeue()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1100, 5448, 5609);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 5506, 5558) || true) && (f_1100_5510_5522(_queue) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1100, 5506, 5558);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 5546, 5558);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1100, 5506, 5558);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 5574, 5598);

                return f_1100_5581_5597(_queue);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1100, 5448, 5609);

                int
                f_1100_5510_5522(System.Collections.Generic.Queue<Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1100, 5510, 5522);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData
                f_1100_5581_5597(System.Collections.Generic.Queue<Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData>
                this_param)
                {
                    var return_v = this_param.Dequeue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1100, 5581, 5597);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1100, 5448, 5609);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1100, 5448, 5609);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Queue<PacketInfoData> _queue;

        private int _objectCount;

        private TimeSpan _groupingDuration;

        private Stopwatch _groupingTimer;

        private FormattedObjectsCache.ProcessCachedGroupNotification _notificationCallBack;

        private FormatStartData _formatStartData;

        private bool _processingGroup;

        private int _currentObjectCount;

        static OutputGroupQueue()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1100, 485, 7124);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1100, 485, 7124);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1100, 485, 7124);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1100, 485, 7124);

        System.Collections.Generic.Queue<Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData>
        f_1100_5765_5792()
        {
            var return_v = new System.Collections.Generic.Queue<Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1100, 5765, 5792);
            return return_v;
        }

    }
    internal sealed class FormattedObjectsCache
    {        /// <summary>
             /// Delegate to allow notifications when the autosize queue is about to be drained.
             /// </summary>
             /// <param name="formatStartData">Current Fs control message.</param>
             /// <param name="objects">Enumeration of PacketInfoData objects.</param>
        internal delegate void ProcessCachedGroupNotification(FormatStartData formatStartData, List<PacketInfoData> objects);

        internal FormattedObjectsCache(bool cacheFrontEnd)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1100, 7944, 8111);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 11938, 11952);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 12075, 12093);
                this._groupQueue = null;
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 8019, 8100) || true) && (cacheFrontEnd)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1100, 8019, 8100);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 8055, 8100);

                    _frontEndQueue = f_1100_8072_8099();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1100, 8019, 8100);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1100, 7944, 8111);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1100, 7944, 8111);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1100, 7944, 8111);
            }
        }

        internal void EnableGroupCaching(ProcessCachedGroupNotification callBack, int objectCount)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1100, 8445, 8668);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 8560, 8657) || true) && (callBack != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1100, 8560, 8657);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 8599, 8657);

                    _groupQueue = f_1100_8613_8656(callBack, objectCount);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1100, 8560, 8657);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1100, 8445, 8668);

                Microsoft.PowerShell.Commands.Internal.Format.OutputGroupQueue
                f_1100_8613_8656(Microsoft.PowerShell.Commands.Internal.Format.FormattedObjectsCache.ProcessCachedGroupNotification
                callBack, int
                objectCount)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.OutputGroupQueue(callBack, objectCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1100, 8613, 8656);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1100, 8445, 8668);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1100, 8445, 8668);
            }
        }

        internal void EnableGroupCaching(ProcessCachedGroupNotification callBack, TimeSpan groupingDuration)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1100, 9011, 9249);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 9136, 9238) || true) && (callBack != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1100, 9136, 9238);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 9175, 9238);

                    _groupQueue = f_1100_9189_9237(callBack, groupingDuration);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1100, 9136, 9238);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1100, 9011, 9249);

                Microsoft.PowerShell.Commands.Internal.Format.OutputGroupQueue
                f_1100_9189_9237(Microsoft.PowerShell.Commands.Internal.Format.FormattedObjectsCache.ProcessCachedGroupNotification
                callBack, System.TimeSpan
                groupingDuration)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.OutputGroupQueue(callBack, groupingDuration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1100, 9189, 9237);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1100, 9011, 9249);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1100, 9011, 9249);
            }
        }

        internal List<PacketInfoData> Add(PacketInfoData o)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1100, 9584, 10212);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 9704, 9923) || true) && (_frontEndQueue == null && (DynAbs.Tracing.TraceSender.Expression_True(1100, 9708, 9753) && _groupQueue == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1100, 9704, 9923);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 9787, 9844);

                    List<PacketInfoData>
                    retVal = f_1100_9817_9843()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 9862, 9876);

                    f_1100_9862_9875(retVal, o);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 9894, 9908);

                    return retVal;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1100, 9704, 9923);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 9986, 10117) || true) && (_frontEndQueue != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1100, 9986, 10117);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 10046, 10072);

                    f_1100_10046_10071(_frontEndQueue, o);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 10090, 10102);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1100, 9986, 10117);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 10175, 10201);

                return f_1100_10182_10200(_groupQueue, o);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1100, 9584, 10212);

                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData>
                f_1100_9817_9843()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1100, 9817, 9843);
                    return return_v;
                }


                int
                f_1100_9862_9875(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1100, 9862, 9875);
                    return 0;
                }


                int
                f_1100_10046_10071(System.Collections.Generic.Queue<Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData
                item)
                {
                    this_param.Enqueue(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1100, 10046, 10071);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData>
                f_1100_10182_10200(Microsoft.PowerShell.Commands.Internal.Format.OutputGroupQueue
                this_param, Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData
                o)
                {
                    var return_v = this_param.Add(o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1100, 10182, 10200);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1100, 9584, 10212);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1100, 9584, 10212);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal List<PacketInfoData> Drain()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1100, 10395, 11780);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 10514, 10624) || true) && (_frontEndQueue == null && (DynAbs.Tracing.TraceSender.Expression_True(1100, 10518, 10563) && _groupQueue == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1100, 10514, 10624);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 10597, 10609);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1100, 10514, 10624);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 10640, 10697);

                List<PacketInfoData>
                retVal = f_1100_10670_10696()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 10713, 11483) || true) && (_frontEndQueue != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1100, 10713, 11483);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 10773, 11056) || true) && (_groupQueue == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1100, 10773, 11056);
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 10904, 10999) || true) && (f_1100_10911_10931(_frontEndQueue) > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1100, 10904, 10999);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 10962, 10999);

                                f_1100_10962_10998(retVal, f_1100_10973_10997(_frontEndQueue));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1100, 10904, 10999);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1100, 10904, 10999);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1100, 10904, 10999);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 11023, 11037);

                        return retVal;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1100, 10773, 11056);
                    }
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 11134, 11468) || true) && (f_1100_11141_11161(_frontEndQueue) > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1100, 11134, 11468);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 11207, 11286);

                            List<PacketInfoData>
                            groupQueueOut = f_1100_11244_11285(_groupQueue, f_1100_11260_11284(_frontEndQueue))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 11310, 11449) || true) && (groupQueueOut != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1100, 11310, 11449);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 11362, 11449);
                                    foreach (PacketInfoData x in f_1100_11391_11404_I(groupQueueOut))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1100, 11362, 11449);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 11435, 11449);

                                        f_1100_11435_11448(retVal, x);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1100, 11362, 11449);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1100, 1, 88);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1100, 1, 88);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1100, 11310, 11449);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1100, 11134, 11468);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1100, 11134, 11468);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1100, 11134, 11468);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1100, 10713, 11483);
                }
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 11536, 11739) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1100, 11536, 11739);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 11581, 11624);

                        PacketInfoData
                        obj = f_1100_11602_11623(_groupQueue)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 11644, 11688) || true) && (obj == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1100, 11644, 11688);
                            DynAbs.Tracing.TraceSender.TraceBreak(1100, 11682, 11688);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1100, 11644, 11688);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 11708, 11724);

                        f_1100_11708_11723(
                                        retVal, obj);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1100, 11536, 11739);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1100, 11536, 11739);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1100, 11536, 11739);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1100, 11755, 11769);

                return retVal;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1100, 10395, 11780);

                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData>
                f_1100_10670_10696()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1100, 10670, 10696);
                    return return_v;
                }


                int
                f_1100_10911_10931(System.Collections.Generic.Queue<Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1100, 10911, 10931);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData
                f_1100_10973_10997(System.Collections.Generic.Queue<Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData>
                this_param)
                {
                    var return_v = this_param.Dequeue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1100, 10973, 10997);
                    return return_v;
                }


                int
                f_1100_10962_10998(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1100, 10962, 10998);
                    return 0;
                }


                int
                f_1100_11141_11161(System.Collections.Generic.Queue<Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1100, 11141, 11161);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData
                f_1100_11260_11284(System.Collections.Generic.Queue<Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData>
                this_param)
                {
                    var return_v = this_param.Dequeue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1100, 11260, 11284);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData>
                f_1100_11244_11285(Microsoft.PowerShell.Commands.Internal.Format.OutputGroupQueue
                this_param, Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData
                o)
                {
                    var return_v = this_param.Add(o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1100, 11244, 11285);
                    return return_v;
                }


                int
                f_1100_11435_11448(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1100, 11435, 11448);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData>
                f_1100_11391_11404_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1100, 11391, 11404);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData
                f_1100_11602_11623(Microsoft.PowerShell.Commands.Internal.Format.OutputGroupQueue
                this_param)
                {
                    var return_v = this_param.Dequeue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1100, 11602, 11623);
                    return return_v;
                }


                int
                f_1100_11708_11723(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1100, 11708, 11723);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1100, 10395, 11780);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1100, 10395, 11780);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Queue<PacketInfoData> _frontEndQueue;

        private OutputGroupQueue _groupQueue;

        static FormattedObjectsCache()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1100, 7240, 12101);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1100, 7240, 12101);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1100, 7240, 12101);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1100, 7240, 12101);

        System.Collections.Generic.Queue<Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData>
        f_1100_8072_8099()
        {
            var return_v = new System.Collections.Generic.Queue<Microsoft.PowerShell.Commands.Internal.Format.PacketInfoData>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1100, 8072, 8099);
            return return_v;
        }

    }
}

