// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.IO;
using System.Management.Automation.Internal;
using System.Management.Automation.Tracing;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation.Remoting
{
    /// <summary>
    /// </summary>
    internal enum DataPriorityType : int
    {
        /// <summary>
        /// This indicate that the data will be sent without priority consideration.
        /// Large data objects will be fragmented so that each fragmented piece can
        /// fit into one message.
        /// </summary>
        Default = 0,

        /// <summary>
        /// PromptResponse may be sent with or without priority considerations.
        /// Large data objects will be fragmented so that each fragmented piece can
        /// fit into one message.
        /// </summary>
        PromptResponse = 1,
    }
    internal class PrioritySendDataCollection
    {
        private SerializedDataStream[] _dataToBeSent;

        private object[] _dataSyncObjects;

        private Fragmentor _fragmentor;

        private OnDataAvailableCallback _onDataAvailableCallback;

        private SerializedDataStream.OnDataAvailableCallback _onSendCollectionDataAvailable;

        private bool _isHandlingCallback;

        private object _readSyncObject;

        /// <summary>
        /// Callback that is called once a fragmented data is available to send.
        /// </summary>
        /// <param name="data">
        /// Fragmented object that can be sent to the remote end.
        /// </param>
        /// <param name="priorityType">
        /// Priority stream to which <paramref name="data"/> belongs to.
        /// </param>
        internal delegate void OnDataAvailableCallback(byte[] data, DataPriorityType priorityType);

        internal PrioritySendDataCollection()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1636, 2987, 3159);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 1625, 1638);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 1739, 1755);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 1873, 1884);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 2105, 2129);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 2193, 2223);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 2247, 2266);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 2292, 2322);
                this._readSyncObject = f_1636_2310_2322();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 3049, 3148);

                _onSendCollectionDataAvailable = new SerializedDataStream.OnDataAvailableCallback(OnDataAvailable);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1636, 2987, 3159);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1636, 2987, 3159);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1636, 2987, 3159);
            }
        }

        internal Fragmentor Fragmentor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1636, 3297, 3324);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 3303, 3322);

                    return _fragmentor;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1636, 3297, 3324);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1636, 3242, 4016);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1636, 3242, 4016);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1636, 3340, 4005);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 3376, 3432);

                    f_1636_3376_3431(value != null, "Fragmentor cannot be null.");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 3450, 3470);

                    _fragmentor = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 3555, 3612);

                    string[]
                    names = f_1636_3572_3611(typeof(DataPriorityType))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 3630, 3685);

                    _dataToBeSent = new SerializedDataStream[f_1636_3671_3683(names)];
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 3703, 3747);

                    _dataSyncObjects = new object[f_1636_3733_3745(names)];
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 3774, 3779);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 3765, 3990) || true) && (i < f_1636_3785_3797(names))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 3799, 3802)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1636, 3765, 3990))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1636, 3765, 3990);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 3844, 3914);

                            _dataToBeSent[i] = f_1636_3863_3913(f_1636_3888_3912(_fragmentor));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 3936, 3971);

                            _dataSyncObjects[i] = f_1636_3958_3970();
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1636, 1, 226);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1636, 1, 226);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1636, 3340, 4005);

                    int
                    f_1636_3376_3431(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Dbg.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 3376, 3431);
                        return 0;
                    }


                    string[]
                    f_1636_3572_3611(System.Type
                    enumType)
                    {
                        var return_v = Enum.GetNames(enumType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 3572, 3611);
                        return return_v;
                    }


                    int
                    f_1636_3671_3683(string[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1636, 3671, 3683);
                        return return_v;
                    }


                    int
                    f_1636_3733_3745(string[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1636, 3733, 3745);
                        return return_v;
                    }


                    int
                    f_1636_3785_3797(string[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1636, 3785, 3797);
                        return return_v;
                    }


                    int
                    f_1636_3888_3912(System.Management.Automation.Remoting.Fragmentor
                    this_param)
                    {
                        var return_v = this_param.FragmentSize;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1636, 3888, 3912);
                        return return_v;
                    }


                    System.Management.Automation.Remoting.SerializedDataStream
                    f_1636_3863_3913(int
                    fragmentSize)
                    {
                        var return_v = new System.Management.Automation.Remoting.SerializedDataStream(fragmentSize);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 3863, 3913);
                        return return_v;
                    }


                    object
                    f_1636_3958_3970()
                    {
                        var return_v = new object();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 3958, 3970);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1636, 3242, 4016);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1636, 3242, 4016);
                }
            }
        }

        internal void Add<T>(RemoteDataObject<T> data, DataPriorityType priority)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1636, 4597, 5324);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 4695, 4752);

                f_1636_4695_4751(data != null, "Cannot send null data object");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 4766, 4848);

                f_1636_4766_4847(_fragmentor != null, "Fragmentor cannot be null while adding objects");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 4862, 4938);

                f_1636_4862_4937(_dataToBeSent != null, "Serialized streams are not initialized");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 5173, 5204);

                // make sure the only one object is fragmented and added to the collection
                // at any give time. This way the order of fragment is maintained
                // in the SendDataCollection(s).
                lock (_dataSyncObjects[(int)priority])
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 5238, 5298);

                    f_1636_5238_5297(_fragmentor, data, _dataToBeSent[(int)priority]);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1636, 4597, 5324);

                int
                f_1636_4695_4751(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 4695, 4751);
                    return 0;
                }


                int
                f_1636_4766_4847(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 4766, 4847);
                    return 0;
                }


                int
                f_1636_4862_4937(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 4862, 4937);
                    return 0;
                }


                int
                f_1636_5238_5297(System.Management.Automation.Remoting.Fragmentor
                this_param, System.Management.Automation.Remoting.RemoteDataObject<T>
                obj, System.Management.Automation.Remoting.SerializedDataStream
                dataToBeSent)
                {
                    this_param.Fragment<T>(obj, dataToBeSent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 5238, 5297);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1636, 4597, 5324);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1636, 4597, 5324);
            }
        }

        internal void Add<T>(RemoteDataObject<T> data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1636, 5878, 5999);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 5949, 5988);

                f_1636_5949_5987(this, data, DataPriorityType.Default);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1636, 5878, 5999);

                int
                f_1636_5949_5987(System.Management.Automation.Remoting.PrioritySendDataCollection
                this_param, System.Management.Automation.Remoting.RemoteDataObject<T>
                data, System.Management.Automation.Remoting.DataPriorityType
                priority)
                {
                    this_param.Add<T>(data, priority);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 5949, 5987);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1636, 5878, 5999);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1636, 5878, 5999);
            }
        }

        internal void Clear()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1636, 6131, 7388);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 6461, 7377) || true) && (_dataSyncObjects != null && (DynAbs.Tracing.TraceSender.Expression_True(1636, 6465, 6514) && _dataToBeSent != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1636, 6461, 7377);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 6548, 6611);

                    int
                    promptResponseIndex = (int)DataPriorityType.PromptResponse
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 6629, 6678);

                    int
                    defaultIndex = (int)DataPriorityType.Default
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 6704, 6741);

                    lock (_dataSyncObjects[promptResponseIndex])
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 6783, 7015) || true) && (_dataToBeSent[promptResponseIndex] != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1636, 6783, 7015);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 6879, 6924);

                            f_1636_6879_6923(_dataToBeSent[promptResponseIndex]);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 6950, 6992);

                            _dataToBeSent[promptResponseIndex] = null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1636, 6783, 7015);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 7060, 7090);

                    lock (_dataSyncObjects[defaultIndex])
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 7132, 7343) || true) && (_dataToBeSent[defaultIndex] != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1636, 7132, 7343);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 7221, 7259);

                            f_1636_7221_7258(_dataToBeSent[defaultIndex]);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 7285, 7320);

                            _dataToBeSent[defaultIndex] = null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1636, 7132, 7343);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1636, 6461, 7377);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1636, 6131, 7388);

                int
                f_1636_6879_6923(System.Management.Automation.Remoting.SerializedDataStream
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 6879, 6923);
                    return 0;
                }


                int
                f_1636_7221_7258(System.Management.Automation.Remoting.SerializedDataStream
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 7221, 7258);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1636, 6131, 7388);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1636, 6131, 7388);
            }
        }

        internal byte[] ReadOrRegisterCallback(OnDataAvailableCallback callback,
                    out DataPriorityType priorityType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1636, 8756, 9884);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 8907, 8922);
                lock (_readSyncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 8956, 8996);

                    priorityType = DataPriorityType.Default;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 9093, 9114);

                    byte[]
                    result = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 9132, 9248);

                    result = f_1636_9141_9247(_dataToBeSent[(int)DataPriorityType.PromptResponse], _onSendCollectionDataAvailable);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 9266, 9313);

                    priorityType = DataPriorityType.PromptResponse;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 9333, 9583) || true) && (result == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1636, 9333, 9583);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 9393, 9502);

                        result = f_1636_9402_9501(_dataToBeSent[(int)DataPriorityType.Default], _onSendCollectionDataAvailable);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 9524, 9564);

                        priorityType = DataPriorityType.Default;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1636, 9333, 9583);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 9666, 9824) || true) && (result == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1636, 9666, 9824);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 9769, 9805);

                        _onDataAvailableCallback = callback;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1636, 9666, 9824);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 9844, 9858);

                    return result;
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1636, 8756, 9884);

                byte[]
                f_1636_9141_9247(System.Management.Automation.Remoting.SerializedDataStream
                this_param, System.Management.Automation.Remoting.SerializedDataStream.OnDataAvailableCallback
                callback)
                {
                    var return_v = this_param.ReadOrRegisterCallback(callback);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 9141, 9247);
                    return return_v;
                }


                byte[]
                f_1636_9402_9501(System.Management.Automation.Remoting.SerializedDataStream
                this_param, System.Management.Automation.Remoting.SerializedDataStream.OnDataAvailableCallback
                callback)
                {
                    var return_v = this_param.ReadOrRegisterCallback(callback);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 9402, 9501);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1636, 8756, 9884);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1636, 8756, 9884);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void OnDataAvailable(byte[] data, bool isEndFragment)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1636, 9896, 11288);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 9988, 10003);
                lock (_readSyncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 10195, 10286) || true) && (_isHandlingCallback)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1636, 10195, 10286);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 10260, 10267);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1636, 10195, 10286);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 10306, 10333);

                    _isHandlingCallback = true;
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 10364, 11233) || true) && (_onDataAvailableCallback != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1636, 10364, 11233);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 10434, 10458);

                    DataPriorityType
                    prType
                    = default(DataPriorityType);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 10541, 10618);

                    byte[]
                    result = f_1636_10557_10617(this, _onDataAvailableCallback, out prType)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 10638, 11218) || true) && (result != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1636, 10638, 11218);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 11030, 11094);

                        OnDataAvailableCallback
                        realCallback = _onDataAvailableCallback
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 11116, 11148);

                        _onDataAvailableCallback = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 11170, 11199);

                        f_1636_11170_11198(realCallback, result, prType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1636, 10638, 11218);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1636, 10364, 11233);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 11249, 11277);

                _isHandlingCallback = false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1636, 9896, 11288);

                byte[]
                f_1636_10557_10617(System.Management.Automation.Remoting.PrioritySendDataCollection
                this_param, System.Management.Automation.Remoting.PrioritySendDataCollection.OnDataAvailableCallback
                callback, out System.Management.Automation.Remoting.DataPriorityType
                priorityType)
                {
                    var return_v = this_param.ReadOrRegisterCallback(callback, out priorityType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 10557, 10617);
                    return return_v;
                }


                int
                f_1636_11170_11198(System.Management.Automation.Remoting.PrioritySendDataCollection.OnDataAvailableCallback
                this_param, byte[]
                data, System.Management.Automation.Remoting.DataPriorityType
                priorityType)
                {
                    this_param.Invoke(data, priorityType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 11170, 11198);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1636, 9896, 11288);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1636, 9896, 11288);
            }
        }

        static PrioritySendDataCollection()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1636, 1369, 11317);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1636, 1369, 11317);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1636, 1369, 11317);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1636, 1369, 11317);

        object
        f_1636_2310_2322()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 2310, 2322);
            return return_v;
        }

    }
    internal class ReceiveDataCollection : IDisposable
    {
        [TraceSourceAttribute("Transport", "Traces BaseWSManTransportManager")]
        private static PSTraceSource s_baseTracer;

        private Fragmentor _defragmentor;

        private MemoryStream _pendingDataStream;

        private MemoryStream _dataToProcessStream;

        private long _currentObjectId;

        private long _currentFrgId;

        private int? _maxReceivedObjectSize;

        private int _totalReceivedObjectSizeSoFar;

        private bool _isCreateByClientTM;

        private bool _canIgnoreOffSyncFragments;

        private object _syncObject;

        private bool _isDisposed;

        private int _numberOfThreadsProcessing;

        private int _maxNumberOfThreadsToAllowForProcessing;



        /// <summary>
        /// Callback that is called once a deserialized object is available.
        /// </summary>
        /// <param name="data">
        /// Deserialized object that can be processed.
        /// </param>
        internal delegate void OnDataAvailableCallback(RemoteDataObject<PSObject> data);

        internal ReceiveDataCollection(Fragmentor defragmentor, bool createdByClientTM)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1636, 14401, 15273);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 12013, 12026);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 12178, 12196);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 12407, 12427);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 12451, 12467);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 12491, 12504);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 12578, 12600);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 12623, 12652);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 12676, 12695);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 12886, 12920);
                this._canIgnoreOffSyncFragments = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 13055, 13066);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 13090, 13101);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 13422, 13448);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 13530, 13573);
                this._maxNumberOfThreadsToAllowForProcessing = 1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 14505, 14597);

                f_1636_14505_14596(defragmentor != null, "ReceiveDataCollection needs a defragmentor to work with");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 15084, 15124);

                _pendingDataStream = f_1636_15105_15123();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 15138, 15165);

                _syncObject = f_1636_15152_15164();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 15179, 15208);

                _defragmentor = defragmentor;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 15222, 15262);

                _isCreateByClientTM = createdByClientTM;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1636, 14401, 15273);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1636, 14401, 15273);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1636, 14401, 15273);
            }
        }

        internal int? MaximumReceivedObjectSize
        {
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1636, 15548, 15587);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 15554, 15585);

                    _maxReceivedObjectSize = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1636, 15548, 15587);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1636, 15484, 15598);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1636, 15484, 15598);
                }
            }
        }

        internal void AllowTwoThreadsToProcessRawData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1636, 15943, 16070);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 16015, 16059);

                _maxNumberOfThreadsToAllowForProcessing = 2;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1636, 15943, 16070);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1636, 15943, 16070);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1636, 15943, 16070);
            }
        }

        internal void PrepareForStreamConnect()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1636, 16591, 16700);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 16655, 16689);

                _canIgnoreOffSyncFragments = true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1636, 16591, 16700);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1636, 16591, 16700);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1636, 16591, 16700);
            }
        }

        internal void ProcessRawData(byte[] data, OnDataAvailableCallback callback)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1636, 17992, 30401);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 18092, 18145);

                f_1636_18092_18144(data != null, "Cannot process null data");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 18159, 18215);

                f_1636_18159_18214(callback != null, "Callback cannot be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 18237, 18248);

                lock (_syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 18282, 18365) || true) && (_isDisposed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1636, 18282, 18365);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 18339, 18346);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1636, 18282, 18365);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 18385, 18414);

                    _numberOfThreadsProcessing++;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 18432, 18638) || true) && (_numberOfThreadsProcessing > _maxNumberOfThreadsToAllowForProcessing)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1636, 18432, 18638);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 18546, 18619);

                        f_1636_18546_18618(false, "Multiple threads are not allowed in ProcessRawData.");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1636, 18432, 18638);
                    }
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 18705, 18752);

                    f_1636_18705_18751(_pendingDataStream, data, 0, f_1636_18739_18750(data));
                    {
                        try
                        {
                            do

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1636, 18954, 30031);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 18997, 19460) || true) && (f_1636_19001_19026(_pendingDataStream) <= FragmentedRemoteObject.HeaderLength)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1636, 18997, 19460);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 19185, 19404);

                                    f_1636_19185_19403(                        // there is not enough data to be processed.
                                                            s_baseTracer, "Not enough data to process. Data is less than header length. Data length is {0}. Header Length {1}.", f_1636_19340_19365(_pendingDataStream), FragmentedRemoteObject.HeaderLength);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 19430, 19437);

                                    return;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1636, 18997, 19460);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 19484, 19531);

                                byte[]
                                dataRead = f_1636_19502_19530(_pendingDataStream)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 19641, 19705);

                                long
                                objectId = f_1636_19657_19704(dataRead, 0)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 19727, 19909) || true) && (objectId <= 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1636, 19727, 19909);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 19794, 19886);

                                    throw f_1636_19800_19885(f_1636_19833_19884());
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1636, 19727, 19909);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 19933, 20001);

                                long
                                fragmentId = f_1636_19951_20000(dataRead, 0)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 20023, 20091);

                                bool
                                sFlag = f_1636_20036_20090(dataRead, 0)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 20113, 20179);

                                bool
                                eFlag = f_1636_20126_20178(dataRead, 0)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 20201, 20268);

                                int
                                blobLength = f_1636_20218_20267(dataRead, 0)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 20292, 20814) || true) && ((f_1636_20297_20317(s_baseTracer) & PSTraceSourceOptions.WriteLine) != PSTraceSourceOptions.None)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1636, 20292, 20814);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 20430, 20481);

                                    f_1636_20430_20480(s_baseTracer, "Object Id: {0}", objectId);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 20507, 20562);

                                    f_1636_20507_20561(s_baseTracer, "Fragment Id: {0}", fragmentId);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 20588, 20637);

                                    f_1636_20588_20636(s_baseTracer, "Start Flag: {0}", sFlag);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 20663, 20710);

                                    f_1636_20663_20709(s_baseTracer, "End Flag: {0}", eFlag);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 20736, 20791);

                                    f_1636_20736_20790(s_baseTracer, "Blob Length: {0}", blobLength);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1636, 20292, 20814);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 20838, 20868);

                                int
                                totalLengthOfFragment = 0
                                ;

                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 20944, 21026);

                                    totalLengthOfFragment = checked(FragmentedRemoteObject.HeaderLength + blobLength);
                                }
                                catch (System.OverflowException)
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1636, 21071, 21429);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 21152, 21196);

                                    f_1636_21152_21195(s_baseTracer, "Fragment too big.");
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 21222, 21241);

                                    f_1636_21222_21240(this);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 21267, 21372);

                                    PSRemotingTransportException
                                    e = f_1636_21300_21371(f_1636_21333_21370())
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 21398, 21406);

                                    throw e;
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(1636, 21071, 21429);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 21453, 21830) || true) && (f_1636_21457_21482(_pendingDataStream) < totalLengthOfFragment)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1636, 21453, 21830);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 21556, 21774);

                                    f_1636_21556_21773(s_baseTracer, "Not enough data to process packet. Data is less than expected blob length. Data length {0}. Expected Length {1}.", f_1636_21724_21749(_pendingDataStream), totalLengthOfFragment);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 21800, 21807);

                                    return;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1636, 21453, 21830);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 21918, 23558) || true) && (f_1636_21922_21953(_maxReceivedObjectSize))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1636, 21918, 23558);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 22003, 22100);

                                    _totalReceivedObjectSizeSoFar = unchecked(_totalReceivedObjectSizeSoFar + totalLengthOfFragment);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 22126, 23535) || true) && ((_totalReceivedObjectSizeSoFar < 0) || (DynAbs.Tracing.TraceSender.Expression_False(1636, 22130, 22231) || (_totalReceivedObjectSizeSoFar > f_1636_22202_22230(_maxReceivedObjectSize))))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1636, 22126, 23535);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 22289, 22487);

                                        f_1636_22289_22486(s_baseTracer, "ObjectSize > MaxReceivedObjectSize. ObjectSize is {0}. MaxReceivedObjectSize is {1}", _totalReceivedObjectSizeSoFar, _maxReceivedObjectSize);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 22517, 22555);

                                        PSRemotingTransportException
                                        e = null
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 22587, 23419) || true) && (_isCreateByClientTM)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1636, 22587, 23419);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 22676, 22967);

                                            e = f_1636_22680_22966(PSRemotingErrorId.ReceivedObjectSizeExceededMaximumClient, f_1636_22809_22871(), _totalReceivedObjectSizeSoFar, _maxReceivedObjectSize);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1636, 22587, 23419);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1636, 22587, 23419);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 23097, 23388);

                                            e = f_1636_23101_23387(PSRemotingErrorId.ReceivedObjectSizeExceededMaximumServer, f_1636_23230_23292(), _totalReceivedObjectSizeSoFar, _maxReceivedObjectSize);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1636, 22587, 23419);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 23451, 23470);

                                        f_1636_23451_23469(this);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 23500, 23508);

                                        throw e;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1636, 22126, 23535);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1636, 21918, 23558);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 23748, 23793);

                                f_1636_23748_23792(
                                                    // appears like stream doesn't have individual position marker for read and write
                                                    // since we are going to read from now...
                                                    _pendingDataStream, 0, SeekOrigin.Begin);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 23919, 23972);

                                byte[]
                                oneFragment = new byte[totalLengthOfFragment]
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 24074, 24153);

                                int
                                dataCount = f_1636_24090_24152(_pendingDataStream, oneFragment, 0, totalLengthOfFragment)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 24175, 24281);

                                f_1636_24175_24280(dataCount == totalLengthOfFragment, "Unable to read enough data from the stream. Read failed");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 24305, 24821);

                                f_1636_24305_24820(PSEventId.ReceivedRemotingFragment, PSOpcode.Receive, PSTask.None, PSKeyword.Transport | PSKeyword.UseAlwaysAnalytic, objectId, fragmentId, (DynAbs.Tracing.TraceSender.Conditional_F1(1636, 24613, 24618) || ((sFlag && DynAbs.Tracing.TraceSender.Conditional_F2(1636, 24621, 24622)) || DynAbs.Tracing.TraceSender.Conditional_F3(1636, 24625, 24626))) ? 1 : 0, (DynAbs.Tracing.TraceSender.Conditional_F1(1636, 24653, 24658) || ((eFlag && DynAbs.Tracing.TraceSender.Conditional_F2(1636, 24661, 24662)) || DynAbs.Tracing.TraceSender.Conditional_F3(1636, 24665, 24666))) ? 1 : 0, blobLength, f_1636_24738_24819(oneFragment, FragmentedRemoteObject.HeaderLength, blobLength));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 24845, 24869);

                                byte[]
                                extraData = null
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 24891, 25310) || true) && (totalLengthOfFragment < f_1636_24919_24944(_pendingDataStream))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1636, 24891, 25310);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 25093, 25165);

                                    extraData = new byte[f_1636_25114_25139(_pendingDataStream) - totalLengthOfFragment];
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 25191, 25287);

                                    f_1636_25191_25286(_pendingDataStream, extraData, 0, (f_1636_25235_25260(_pendingDataStream) - totalLengthOfFragment));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1636, 24891, 25310);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 25381, 25410);

                                f_1636_25381_25409(
                                                    // reset incoming stream.
                                                    _pendingDataStream);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 25432, 25472);

                                _pendingDataStream = f_1636_25453_25471();

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 25494, 25645) || true) && (extraData != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1636, 25494, 25645);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 25565, 25622);

                                    f_1636_25565_25621(_pendingDataStream, extraData, 0, f_1636_25604_25620(extraData));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1636, 25494, 25645);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 25669, 28389) || true) && (sFlag)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1636, 25669, 28389);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 25728, 25763);

                                    _canIgnoreOffSyncFragments = false;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 25853, 25881);

                                    _currentObjectId = objectId;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 26438, 26480);

                                    _dataToProcessStream = f_1636_26461_26479();
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1636, 25669, 28389);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1636, 25669, 28389);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 26673, 27497) || true) && (objectId != _currentObjectId)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1636, 26673, 27497);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 26763, 26817);

                                        f_1636_26763_26816(s_baseTracer, "ObjectId != CurrentObjectId");
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 26904, 26923);

                                        f_1636_26904_26922(this);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 26953, 27470) || true) && (!_canIgnoreOffSyncFragments)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1636, 26953, 27470);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 27050, 27161);

                                            PSRemotingTransportException
                                            e = f_1636_27083_27160(f_1636_27116_27159())
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 27195, 27203);

                                            throw e;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1636, 26953, 27470);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1636, 26953, 27470);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 27333, 27396);

                                            f_1636_27333_27395(s_baseTracer, "Ignoring ObjectId != CurrentObjectId");
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 27430, 27439);

                                            continue;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1636, 26953, 27470);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1636, 26673, 27497);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 27525, 28366) || true) && (fragmentId != (_currentFrgId + 1))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1636, 27525, 28366);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 27620, 27678);

                                        f_1636_27620_27677(s_baseTracer, "Fragment Id is not in sequence.");
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 27765, 27784);

                                        f_1636_27765_27783(this);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 27814, 28339) || true) && (!_canIgnoreOffSyncFragments)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1636, 27814, 28339);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 27911, 28026);

                                            PSRemotingTransportException
                                            e = f_1636_27944_28025(f_1636_27977_28024())
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 28060, 28068);

                                            throw e;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1636, 27814, 28339);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1636, 27814, 28339);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 28198, 28265);

                                            f_1636_28198_28264(s_baseTracer, "Ignoring Fragment Id is not in sequence.");
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 28299, 28308);

                                            continue;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1636, 27814, 28339);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1636, 27525, 28366);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1636, 25669, 28389);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 28498, 28525);

                                _currentFrgId = fragmentId;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 28607, 28696);

                                f_1636_28607_28695(                    // store the blob in a separate stream
                                                    _dataToProcessStream, oneFragment, FragmentedRemoteObject.HeaderLength, blobLength);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 28720, 29998) || true) && (eFlag)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1636, 28720, 29998);
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 29044, 29091);

                                        f_1636_29044_29090(                            // appears like stream doesn't individual position marker for read and write
                                                                                       // since we are going to read from now..i am resetting position to 0.
                                                                    _dataToProcessStream, 0, SeekOrigin.Begin);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 29121, 29238);

                                        RemoteDataObject<PSObject>
                                        remoteObject = f_1636_29163_29237(_dataToProcessStream, _defragmentor)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 29268, 29340);

                                        f_1636_29268_29339(s_baseTracer, "Runspace Id: {0}", f_1636_29311_29338(remoteObject));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 29370, 29442);

                                        f_1636_29370_29441(s_baseTracer, "PowerShell Id: {0}", f_1636_29415_29440(remoteObject));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 29563, 29586);

                                        f_1636_29563_29585(callback, remoteObject);
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1636, 29639, 29841);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 29795, 29814);

                                        f_1636_29795_29813(this);
                                        DynAbs.Tracing.TraceSender.TraceExitFinally(1636, 29639, 29841);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 29869, 29975) || true) && (_isDisposed)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1636, 29869, 29975);
                                        DynAbs.Tracing.TraceSender.TraceBreak(1636, 29942, 29948);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1636, 29869, 29975);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1636, 28720, 29998);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1636, 18954, 30031);
                            }
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 18954, 30031) || true) && (true)
                            );
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1636, 18954, 30031);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1636, 18954, 30031);
                        }
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1636, 30060, 30390);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 30106, 30117);
                    lock (_syncObject)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 30159, 30303) || true) && (_isDisposed && (DynAbs.Tracing.TraceSender.Expression_True(1636, 30163, 30211) && (_numberOfThreadsProcessing == 1)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1636, 30159, 30303);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 30261, 30280);

                            f_1636_30261_30279(this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1636, 30159, 30303);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 30327, 30356);

                        _numberOfThreadsProcessing--;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1636, 30060, 30390);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1636, 17992, 30401);

                int
                f_1636_18092_18144(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 18092, 18144);
                    return 0;
                }


                int
                f_1636_18159_18214(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 18159, 18214);
                    return 0;
                }


                int
                f_1636_18546_18618(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 18546, 18618);
                    return 0;
                }


                int
                f_1636_18739_18750(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1636, 18739, 18750);
                    return return_v;
                }


                int
                f_1636_18705_18751(System.IO.MemoryStream
                this_param, byte[]
                buffer, int
                offset, int
                count)
                {
                    this_param.Write(buffer, offset, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 18705, 18751);
                    return 0;
                }


                long
                f_1636_19001_19026(System.IO.MemoryStream
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1636, 19001, 19026);
                    return return_v;
                }


                long
                f_1636_19340_19365(System.IO.MemoryStream
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1636, 19340, 19365);
                    return return_v;
                }


                int
                f_1636_19185_19403(System.Management.Automation.PSTraceSource
                this_param, string
                format, long
                arg1, int
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 19185, 19403);
                    return 0;
                }


                byte[]
                f_1636_19502_19530(System.IO.MemoryStream
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 19502, 19530);
                    return return_v;
                }


                long
                f_1636_19657_19704(byte[]
                fragmentBytes, int
                startIndex)
                {
                    var return_v = FragmentedRemoteObject.GetObjectId(fragmentBytes, startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 19657, 19704);
                    return return_v;
                }


                string
                f_1636_19833_19884()
                {
                    var return_v = RemotingErrorIdStrings.ObjectIdCannotBeLessThanZero;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1636, 19833, 19884);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1636_19800_19885(string
                message)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 19800, 19885);
                    return return_v;
                }


                long
                f_1636_19951_20000(byte[]
                fragmentBytes, int
                startIndex)
                {
                    var return_v = FragmentedRemoteObject.GetFragmentId(fragmentBytes, startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 19951, 20000);
                    return return_v;
                }


                bool
                f_1636_20036_20090(byte[]
                fragmentBytes, int
                startIndex)
                {
                    var return_v = FragmentedRemoteObject.GetIsStartFragment(fragmentBytes, startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 20036, 20090);
                    return return_v;
                }


                bool
                f_1636_20126_20178(byte[]
                fragmentBytes, int
                startIndex)
                {
                    var return_v = FragmentedRemoteObject.GetIsEndFragment(fragmentBytes, startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 20126, 20178);
                    return return_v;
                }


                int
                f_1636_20218_20267(byte[]
                fragmentBytes, int
                startIndex)
                {
                    var return_v = FragmentedRemoteObject.GetBlobLength(fragmentBytes, startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 20218, 20267);
                    return return_v;
                }


                System.Management.Automation.PSTraceSourceOptions
                f_1636_20297_20317(System.Management.Automation.PSTraceSource
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1636, 20297, 20317);
                    return return_v;
                }


                int
                f_1636_20430_20480(System.Management.Automation.PSTraceSource
                this_param, string
                format, long
                arg1)
                {
                    this_param.WriteLine(format, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 20430, 20480);
                    return 0;
                }


                int
                f_1636_20507_20561(System.Management.Automation.PSTraceSource
                this_param, string
                format, long
                arg1)
                {
                    this_param.WriteLine(format, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 20507, 20561);
                    return 0;
                }


                int
                f_1636_20588_20636(System.Management.Automation.PSTraceSource
                this_param, string
                format, bool
                arg1)
                {
                    this_param.WriteLine(format, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 20588, 20636);
                    return 0;
                }


                int
                f_1636_20663_20709(System.Management.Automation.PSTraceSource
                this_param, string
                format, bool
                arg1)
                {
                    this_param.WriteLine(format, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 20663, 20709);
                    return 0;
                }


                int
                f_1636_20736_20790(System.Management.Automation.PSTraceSource
                this_param, string
                format, int
                arg1)
                {
                    this_param.WriteLine(format, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 20736, 20790);
                    return 0;
                }


                int
                f_1636_21152_21195(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 21152, 21195);
                    return 0;
                }


                int
                f_1636_21222_21240(System.Management.Automation.Remoting.ReceiveDataCollection
                this_param)
                {
                    this_param.ResetReceiveData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 21222, 21240);
                    return 0;
                }


                string
                f_1636_21333_21370()
                {
                    var return_v = RemotingErrorIdStrings.ObjectIsTooBig;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1636, 21333, 21370);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1636_21300_21371(string
                message)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 21300, 21371);
                    return return_v;
                }


                long
                f_1636_21457_21482(System.IO.MemoryStream
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1636, 21457, 21482);
                    return return_v;
                }


                long
                f_1636_21724_21749(System.IO.MemoryStream
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1636, 21724, 21749);
                    return return_v;
                }


                int
                f_1636_21556_21773(System.Management.Automation.PSTraceSource
                this_param, string
                format, long
                arg1, int
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 21556, 21773);
                    return 0;
                }


                bool
                f_1636_21922_21953(int?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1636, 21922, 21953);
                    return return_v;
                }


                int
                f_1636_22202_22230(int?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1636, 22202, 22230);
                    return return_v;
                }


                int
                f_1636_22289_22486(System.Management.Automation.PSTraceSource
                this_param, string
                format, int
                arg1, int?
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 22289, 22486);
                    return 0;
                }


                string
                f_1636_22809_22871()
                {
                    var return_v = RemotingErrorIdStrings.ReceivedObjectSizeExceededMaximumClient;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1636, 22809, 22871);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1636_22680_22966(System.Management.Automation.Remoting.PSRemotingErrorId
                errorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(errorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 22680, 22966);
                    return return_v;
                }


                string
                f_1636_23230_23292()
                {
                    var return_v = RemotingErrorIdStrings.ReceivedObjectSizeExceededMaximumServer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1636, 23230, 23292);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1636_23101_23387(System.Management.Automation.Remoting.PSRemotingErrorId
                errorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(errorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 23101, 23387);
                    return return_v;
                }


                int
                f_1636_23451_23469(System.Management.Automation.Remoting.ReceiveDataCollection
                this_param)
                {
                    this_param.ResetReceiveData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 23451, 23469);
                    return 0;
                }


                long
                f_1636_23748_23792(System.IO.MemoryStream
                this_param, int
                offset, System.IO.SeekOrigin
                loc)
                {
                    var return_v = this_param.Seek((long)offset, loc);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 23748, 23792);
                    return return_v;
                }


                int
                f_1636_24090_24152(System.IO.MemoryStream
                this_param, byte[]
                buffer, int
                offset, int
                count)
                {
                    var return_v = this_param.Read(buffer, offset, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 24090, 24152);
                    return return_v;
                }


                int
                f_1636_24175_24280(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 24175, 24280);
                    return 0;
                }


                System.Management.Automation.Internal.PSETWBinaryBlob
                f_1636_24738_24819(byte[]
                blob, int
                offset, int
                length)
                {
                    var return_v = new System.Management.Automation.Internal.PSETWBinaryBlob(blob, offset, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 24738, 24819);
                    return return_v;
                }


                int
                f_1636_24305_24820(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, long
                objectId, long
                fragmentId, int
                isStartFragment, int
                isEndFragment, int
                fragmentLength, System.Management.Automation.Internal.PSETWBinaryBlob
                fragmentData)
                {
                    PSEtwLog.LogAnalyticVerbose(id, opcode, task, keyword, objectId, fragmentId, isStartFragment, isEndFragment, (uint)fragmentLength, fragmentData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 24305, 24820);
                    return 0;
                }


                long
                f_1636_24919_24944(System.IO.MemoryStream
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1636, 24919, 24944);
                    return return_v;
                }


                long
                f_1636_25114_25139(System.IO.MemoryStream
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1636, 25114, 25139);
                    return return_v;
                }


                long
                f_1636_25235_25260(System.IO.MemoryStream
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1636, 25235, 25260);
                    return return_v;
                }


                int
                f_1636_25191_25286(System.IO.MemoryStream
                this_param, byte[]
                buffer, int
                offset, long
                count)
                {
                    var return_v = this_param.Read(buffer, offset, (int)count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 25191, 25286);
                    return return_v;
                }


                int
                f_1636_25381_25409(System.IO.MemoryStream
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 25381, 25409);
                    return 0;
                }


                System.IO.MemoryStream
                f_1636_25453_25471()
                {
                    var return_v = new System.IO.MemoryStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 25453, 25471);
                    return return_v;
                }


                int
                f_1636_25604_25620(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1636, 25604, 25620);
                    return return_v;
                }


                int
                f_1636_25565_25621(System.IO.MemoryStream
                this_param, byte[]
                buffer, int
                offset, int
                count)
                {
                    this_param.Write(buffer, offset, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 25565, 25621);
                    return 0;
                }


                System.IO.MemoryStream
                f_1636_26461_26479()
                {
                    var return_v = new System.IO.MemoryStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 26461, 26479);
                    return return_v;
                }


                int
                f_1636_26763_26816(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 26763, 26816);
                    return 0;
                }


                int
                f_1636_26904_26922(System.Management.Automation.Remoting.ReceiveDataCollection
                this_param)
                {
                    this_param.ResetReceiveData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 26904, 26922);
                    return 0;
                }


                string
                f_1636_27116_27159()
                {
                    var return_v = RemotingErrorIdStrings.ObjectIdsNotMatching;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1636, 27116, 27159);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1636_27083_27160(string
                message)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 27083, 27160);
                    return return_v;
                }


                int
                f_1636_27333_27395(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 27333, 27395);
                    return 0;
                }


                int
                f_1636_27620_27677(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 27620, 27677);
                    return 0;
                }


                int
                f_1636_27765_27783(System.Management.Automation.Remoting.ReceiveDataCollection
                this_param)
                {
                    this_param.ResetReceiveData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 27765, 27783);
                    return 0;
                }


                string
                f_1636_27977_28024()
                {
                    var return_v = RemotingErrorIdStrings.FragmentIdsNotInSequence;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1636, 27977, 28024);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1636_27944_28025(string
                message)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 27944, 28025);
                    return return_v;
                }


                int
                f_1636_28198_28264(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 28198, 28264);
                    return 0;
                }


                int
                f_1636_28607_28695(System.IO.MemoryStream
                this_param, byte[]
                buffer, int
                offset, int
                count)
                {
                    this_param.Write(buffer, offset, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 28607, 28695);
                    return 0;
                }


                long
                f_1636_29044_29090(System.IO.MemoryStream
                this_param, int
                offset, System.IO.SeekOrigin
                loc)
                {
                    var return_v = this_param.Seek((long)offset, loc);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 29044, 29090);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                f_1636_29163_29237(System.IO.MemoryStream
                serializedDataStream, System.Management.Automation.Remoting.Fragmentor
                defragmentor)
                {
                    var return_v = RemoteDataObject<PSObject>.CreateFrom((System.IO.Stream)serializedDataStream, defragmentor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 29163, 29237);
                    return return_v;
                }


                System.Guid
                f_1636_29311_29338(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.RunspacePoolId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1636, 29311, 29338);
                    return return_v;
                }


                int
                f_1636_29268_29339(System.Management.Automation.PSTraceSource
                this_param, string
                format, System.Guid
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 29268, 29339);
                    return 0;
                }


                System.Guid
                f_1636_29415_29440(System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.PowerShellId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1636, 29415, 29440);
                    return return_v;
                }


                int
                f_1636_29370_29441(System.Management.Automation.PSTraceSource
                this_param, string
                format, System.Guid
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 29370, 29441);
                    return 0;
                }


                int
                f_1636_29563_29585(System.Management.Automation.Remoting.ReceiveDataCollection.OnDataAvailableCallback
                this_param, System.Management.Automation.Remoting.RemoteDataObject<System.Management.Automation.PSObject>
                data)
                {
                    this_param.Invoke(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 29563, 29585);
                    return 0;
                }


                int
                f_1636_29795_29813(System.Management.Automation.Remoting.ReceiveDataCollection
                this_param)
                {
                    this_param.ResetReceiveData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 29795, 29813);
                    return 0;
                }


                int
                f_1636_30261_30279(System.Management.Automation.Remoting.ReceiveDataCollection
                this_param)
                {
                    this_param.ReleaseResources();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 30261, 30279);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1636, 17992, 30401);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1636, 17992, 30401);
            }
        }

        private void ResetReceiveData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1636, 30516, 30894);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 30654, 30766) || true) && (_dataToProcessStream != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1636, 30654, 30766);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 30720, 30751);

                    f_1636_30720_30750(_dataToProcessStream);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1636, 30654, 30766);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 30782, 30803);

                _currentObjectId = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 30817, 30835);

                _currentFrgId = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 30849, 30883);

                _totalReceivedObjectSizeSoFar = 0;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1636, 30516, 30894);

                int
                f_1636_30720_30750(System.IO.MemoryStream
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 30720, 30750);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1636, 30516, 30894);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1636, 30516, 30894);
            }
        }

        private void ReleaseResources()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1636, 30906, 31299);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 30962, 31114) || true) && (_pendingDataStream != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1636, 30962, 31114);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 31026, 31055);

                    f_1636_31026_31054(_pendingDataStream);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 31073, 31099);

                    _pendingDataStream = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1636, 30962, 31114);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 31130, 31288) || true) && (_dataToProcessStream != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1636, 31130, 31288);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 31196, 31227);

                    f_1636_31196_31226(_dataToProcessStream);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 31245, 31273);

                    _dataToProcessStream = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1636, 31130, 31288);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1636, 30906, 31299);

                int
                f_1636_31026_31054(System.IO.MemoryStream
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 31026, 31054);
                    return 0;
                }


                int
                f_1636_31196_31226(System.IO.MemoryStream
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 31196, 31226);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1636, 30906, 31299);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1636, 30906, 31299);
            }
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1636, 31468, 31710);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 31514, 31528);

                f_1636_31514_31527(this, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 31666, 31699);

                f_1636_31666_31698(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1636, 31468, 31710);

                int
                f_1636_31514_31527(System.Management.Automation.Remoting.ReceiveDataCollection
                this_param, bool
                isDisposing)
                {
                    this_param.Dispose(isDisposing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 31514, 31527);
                    return 0;
                }


                int
                f_1636_31666_31698(System.Management.Automation.Remoting.ReceiveDataCollection
                obj)
                {
                    System.GC.SuppressFinalize((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 31666, 31698);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1636, 31468, 31710);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1636, 31468, 31710);
            }
        }

        internal virtual void Dispose(bool isDisposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1636, 31722, 32023);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 31800, 31811);
                lock (_syncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 31845, 31864);

                    _isDisposed = true;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 31882, 31997) || true) && (_numberOfThreadsProcessing == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1636, 31882, 31997);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 31959, 31978);

                        f_1636_31959_31977(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1636, 31882, 31997);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1636, 31722, 32023);

                int
                f_1636_31959_31977(System.Management.Automation.Remoting.ReceiveDataCollection
                this_param)
                {
                    this_param.ReleaseResources();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 31959, 31977);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1636, 31722, 32023);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1636, 31722, 32023);
            }
        }

        static ReceiveDataCollection()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1636, 11563, 32052);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 11766, 11853);
            s_baseTracer = f_1636_11781_11853("Transport", "Traces BaseWSManTransportManager");
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1636, 11563, 32052);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1636, 11563, 32052);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1636, 11563, 32052);

        static System.Management.Automation.PSTraceSource
        f_1636_11781_11853(string
        name, string
        description)
        {
            var return_v = PSTraceSource.GetTracer(name, description);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 11781, 11853);
            return return_v;
        }


        int
        f_1636_14505_14596(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 14505, 14596);
            return 0;
        }


        System.IO.MemoryStream
        f_1636_15105_15123()
        {
            var return_v = new System.IO.MemoryStream();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 15105, 15123);
            return return_v;
        }


        object
        f_1636_15152_15164()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 15152, 15164);
            return return_v;
        }

    }
    internal class PriorityReceiveDataCollection : IDisposable
    {
        private Fragmentor _defragmentor;

        private ReceiveDataCollection[] _recvdData;

        private bool _isCreateByClientTM;

        internal PriorityReceiveDataCollection(Fragmentor defragmentor, bool createdByClientTM)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1636, 33031, 33568);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 32440, 32453);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 32496, 32506);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 32530, 32549);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 33143, 33172);

                _defragmentor = defragmentor;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 33186, 33243);

                string[]
                names = f_1636_33203_33242(typeof(DataPriorityType))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 33257, 33310);

                _recvdData = new ReceiveDataCollection[f_1636_33296_33308(names)];
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 33333, 33342);
                    for (int
        index = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 33324, 33501) || true) && (index < f_1636_33352_33364(names))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 33366, 33373)
        , index++, DynAbs.Tracing.TraceSender.TraceExitCondition(1636, 33324, 33501))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1636, 33324, 33501);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 33407, 33486);

                        _recvdData[index] = f_1636_33427_33485(defragmentor, createdByClientTM);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1636, 1, 178);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1636, 1, 178);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 33517, 33557);

                _isCreateByClientTM = createdByClientTM;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1636, 33031, 33568);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1636, 33031, 33568);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1636, 33031, 33568);
            }
        }

        internal int? MaximumReceivedDataSize
        {
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1636, 33825, 33942);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 33861, 33927);

                    f_1636_33861_33897(_defragmentor).MaximumAllowedMemory = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1636, 33825, 33942);

                    System.Management.Automation.DeserializationContext
                    f_1636_33861_33897(System.Management.Automation.Remoting.Fragmentor
                    this_param)
                    {
                        var return_v = this_param.DeserializationContext;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1636, 33861, 33897);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1636, 33763, 33953);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1636, 33763, 33953);
                }
            }
        }

        internal int? MaximumReceivedObjectSize
        {
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1636, 34157, 34379);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 34193, 34364);
                        foreach (ReceiveDataCollection recvdDataBuffer in f_1636_34243_34253_I(_recvdData))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1636, 34193, 34364);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 34295, 34345);

                            recvdDataBuffer.MaximumReceivedObjectSize = value;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1636, 34193, 34364);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1636, 1, 172);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1636, 1, 172);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1636, 34157, 34379);

                    System.Management.Automation.Remoting.ReceiveDataCollection[]
                    f_1636_34243_34253_I(System.Management.Automation.Remoting.ReceiveDataCollection[]
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 34243, 34253);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1636, 34093, 34390);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1636, 34093, 34390);
                }
            }
        }

        internal void PrepareForStreamConnect()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1636, 34512, 34734);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 34585, 34594);
                    for (int
        index = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 34576, 34723) || true) && (index < f_1636_34604_34621(_recvdData))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 34623, 34630)
        , index++, DynAbs.Tracing.TraceSender.TraceExitCondition(1636, 34576, 34723))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1636, 34576, 34723);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 34664, 34708);

                        f_1636_34664_34707(_recvdData[index]);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1636, 1, 148);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1636, 1, 148);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1636, 34512, 34734);

                int
                f_1636_34604_34621(System.Management.Automation.Remoting.ReceiveDataCollection[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1636, 34604, 34621);
                    return return_v;
                }


                int
                f_1636_34664_34707(System.Management.Automation.Remoting.ReceiveDataCollection
                this_param)
                {
                    this_param.PrepareForStreamConnect();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 34664, 34707);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1636, 34512, 34734);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1636, 34512, 34734);
            }
        }

        internal void AllowTwoThreadsToProcessRawData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1636, 35079, 35317);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 35160, 35169);
                    for (int
        index = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 35151, 35306) || true) && (index < f_1636_35179_35196(_recvdData))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 35198, 35205)
        , index++, DynAbs.Tracing.TraceSender.TraceExitCondition(1636, 35151, 35306))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1636, 35151, 35306);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 35239, 35291);

                        f_1636_35239_35290(_recvdData[index]);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1636, 1, 156);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1636, 1, 156);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1636, 35079, 35317);

                int
                f_1636_35179_35196(System.Management.Automation.Remoting.ReceiveDataCollection[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1636, 35179, 35196);
                    return return_v;
                }


                int
                f_1636_35239_35290(System.Management.Automation.Remoting.ReceiveDataCollection
                this_param)
                {
                    this_param.AllowTwoThreadsToProcessRawData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 35239, 35290);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1636, 35079, 35317);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1636, 35079, 35317);
            }
        }

        internal void ProcessRawData(byte[] data,
                    DataPriorityType priorityType,
                    ReceiveDataCollection.OnDataAvailableCallback callback)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1636, 36901, 38253);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 37080, 37133);

                f_1636_37080_37132(data != null, "Cannot process null data");

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 37185, 37255);

                    f_1636_37185_37254(f_1636_37185_37221(_defragmentor), f_1636_37242_37253(data));
                }
                catch (System.Xml.XmlException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1636, 37284, 38165);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 37348, 37386);

                    PSRemotingTransportException
                    e = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 37406, 38122) || true) && (_isCreateByClientTM)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1636, 37406, 38122);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 37471, 37746);

                        e = f_1636_37475_37745(PSRemotingErrorId.ReceivedDataSizeExceededMaximumClient, f_1636_37590_37650(), f_1636_37681_37744(f_1636_37681_37738(f_1636_37681_37717(_defragmentor))));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1636, 37406, 38122);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1636, 37406, 38122);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 37828, 38103);

                        e = f_1636_37832_38102(PSRemotingErrorId.ReceivedDataSizeExceededMaximumServer, f_1636_37947_38007(), f_1636_38038_38101(f_1636_38038_38095(f_1636_38038_38074(_defragmentor))));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1636, 37406, 38122);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 38142, 38150);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1636, 37284, 38165);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 38181, 38242);

                f_1636_38181_38241(
                            _recvdData[(int)priorityType], data, callback);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1636, 36901, 38253);

                int
                f_1636_37080_37132(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 37080, 37132);
                    return 0;
                }


                System.Management.Automation.DeserializationContext
                f_1636_37185_37221(System.Management.Automation.Remoting.Fragmentor
                this_param)
                {
                    var return_v = this_param.DeserializationContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1636, 37185, 37221);
                    return return_v;
                }


                int
                f_1636_37242_37253(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1636, 37242, 37253);
                    return return_v;
                }


                int
                f_1636_37185_37254(System.Management.Automation.DeserializationContext
                this_param, int
                amountOfExtraMemory)
                {
                    this_param.LogExtraMemoryUsage(amountOfExtraMemory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 37185, 37254);
                    return 0;
                }


                string
                f_1636_37590_37650()
                {
                    var return_v = RemotingErrorIdStrings.ReceivedDataSizeExceededMaximumClient;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1636, 37590, 37650);
                    return return_v;
                }


                System.Management.Automation.DeserializationContext
                f_1636_37681_37717(System.Management.Automation.Remoting.Fragmentor
                this_param)
                {
                    var return_v = this_param.DeserializationContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1636, 37681, 37717);
                    return return_v;
                }


                int?
                f_1636_37681_37738(System.Management.Automation.DeserializationContext
                this_param)
                {
                    var return_v = this_param.MaximumAllowedMemory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1636, 37681, 37738);
                    return return_v;
                }


                int
                f_1636_37681_37744(int?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1636, 37681, 37744);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1636_37475_37745(System.Management.Automation.Remoting.PSRemotingErrorId
                errorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(errorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 37475, 37745);
                    return return_v;
                }


                string
                f_1636_37947_38007()
                {
                    var return_v = RemotingErrorIdStrings.ReceivedDataSizeExceededMaximumServer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1636, 37947, 38007);
                    return return_v;
                }


                System.Management.Automation.DeserializationContext
                f_1636_38038_38074(System.Management.Automation.Remoting.Fragmentor
                this_param)
                {
                    var return_v = this_param.DeserializationContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1636, 38038, 38074);
                    return return_v;
                }


                int?
                f_1636_38038_38095(System.Management.Automation.DeserializationContext
                this_param)
                {
                    var return_v = this_param.MaximumAllowedMemory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1636, 38038, 38095);
                    return return_v;
                }


                int
                f_1636_38038_38101(int?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1636, 38038, 38101);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1636_37832_38102(System.Management.Automation.Remoting.PSRemotingErrorId
                errorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(errorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 37832, 38102);
                    return return_v;
                }


                int
                f_1636_38181_38241(System.Management.Automation.Remoting.ReceiveDataCollection
                this_param, byte[]
                data, System.Management.Automation.Remoting.ReceiveDataCollection.OnDataAvailableCallback
                callback)
                {
                    this_param.ProcessRawData(data, callback);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 38181, 38241);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1636, 36901, 38253);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1636, 36901, 38253);
            }
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1636, 38424, 38666);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 38470, 38484);

                f_1636_38470_38483(this, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 38622, 38655);

                f_1636_38622_38654(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1636, 38424, 38666);

                int
                f_1636_38470_38483(System.Management.Automation.Remoting.PriorityReceiveDataCollection
                this_param, bool
                isDisposing)
                {
                    this_param.Dispose(isDisposing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 38470, 38483);
                    return 0;
                }


                int
                f_1636_38622_38654(System.Management.Automation.Remoting.PriorityReceiveDataCollection
                obj)
                {
                    System.GC.SuppressFinalize((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 38622, 38654);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1636, 38424, 38666);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1636, 38424, 38666);
            }
        }

        internal virtual void Dispose(bool isDisposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1636, 38678, 38975);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 38750, 38964) || true) && (_recvdData != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1636, 38750, 38964);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 38815, 38824);
                        for (int
        index = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 38806, 38949) || true) && (index < f_1636_38834_38851(_recvdData))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 38853, 38860)
        , index++, DynAbs.Tracing.TraceSender.TraceExitCondition(1636, 38806, 38949))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1636, 38806, 38949);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1636, 38902, 38930);

                            f_1636_38902_38929(_recvdData[index]);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1636, 1, 144);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1636, 1, 144);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1636, 38750, 38964);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1636, 38678, 38975);

                int
                f_1636_38834_38851(System.Management.Automation.Remoting.ReceiveDataCollection[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1636, 38834, 38851);
                    return return_v;
                }


                int
                f_1636_38902_38929(System.Management.Automation.Remoting.ReceiveDataCollection
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 38902, 38929);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1636, 38678, 38975);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1636, 38678, 38975);
            }
        }

        static PriorityReceiveDataCollection()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1636, 32314, 39004);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1636, 32314, 39004);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1636, 32314, 39004);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1636, 32314, 39004);

        string[]
        f_1636_33203_33242(System.Type
        enumType)
        {
            var return_v = Enum.GetNames(enumType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 33203, 33242);
            return return_v;
        }


        int
        f_1636_33296_33308(string[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1636, 33296, 33308);
            return return_v;
        }


        int
        f_1636_33352_33364(string[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1636, 33352, 33364);
            return return_v;
        }


        System.Management.Automation.Remoting.ReceiveDataCollection
        f_1636_33427_33485(System.Management.Automation.Remoting.Fragmentor
        defragmentor, bool
        createdByClientTM)
        {
            var return_v = new System.Management.Automation.Remoting.ReceiveDataCollection(defragmentor, createdByClientTM);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1636, 33427, 33485);
            return return_v;
        }

    }

}
