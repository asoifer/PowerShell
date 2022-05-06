// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Runtime.InteropServices;
using System.Threading;

namespace System.Management.Automation.Internal
{
    internal abstract class ObjectReaderBase<T> : PipelineReader<T>, IDisposable
    {
        public ObjectReaderBase([In, Out] ObjectStreamBase stream)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1026, 909, 1171);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 6237, 6244);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 6679, 6708);
                this._monitorObject = f_1026_6696_6708();
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 992, 1127) || true) && (stream == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1026, 992, 1127);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 1044, 1112);

                    throw f_1026_1050_1111("stream", "stream may not be null");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1026, 992, 1127);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 1143, 1160);

                _stream = stream;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1026, 909, 1171);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1026, 909, 1171);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1026, 909, 1171);
            }
        }


        /// <summary>
        /// Event fired when objects are added to the underlying stream.
        /// </summary>
        public override event EventHandler DataReady
        {

            add
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1026, 1399, 1801);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 1441, 1455);
                    lock (_monitorObject)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 1497, 1548);

                        bool
                        firstRegistrant = (InternalDataReady == null)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 1570, 1597);

                        InternalDataReady += value;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 1619, 1767) || true) && (firstRegistrant)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1026, 1619, 1767);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 1688, 1744);

                            _stream.DataReady += new EventHandler(this.OnDataReady);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1026, 1619, 1767);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1026, 1399, 1801);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1026, 1399, 1801);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1026, 1399, 1801);
                }
            }

            remove
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1026, 1817, 2159);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 1862, 1876);
                    lock (_monitorObject)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 1918, 1945);

                        InternalDataReady -= value;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 1967, 2125) || true) && (InternalDataReady == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1026, 1967, 2125);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 2046, 2102);

                            _stream.DataReady -= new EventHandler(this.OnDataReady);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1026, 1967, 2125);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1026, 1817, 2159);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1026, 1817, 2159);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1026, 1817, 2159);
                }
            }
        }

        public event EventHandler
InternalDataReady = null
;

        public override WaitHandle WaitHandle
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1026, 2527, 2604);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 2563, 2589);

                    return f_1026_2570_2588(_stream);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1026, 2527, 2604);

                    System.Threading.WaitHandle
                    f_1026_2570_2588(System.Management.Automation.Internal.ObjectStreamBase
                    this_param)
                    {
                        var return_v = this_param.ReadHandle;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1026, 2570, 2588);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1026, 2465, 2615);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1026, 2465, 2615);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool EndOfPipeline
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1026, 3061, 3141);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 3097, 3126);

                    return f_1026_3104_3125(_stream);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1026, 3061, 3141);

                    bool
                    f_1026_3104_3125(System.Management.Automation.Internal.ObjectStreamBase
                    this_param)
                    {
                        var return_v = this_param.EndOfPipeline;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1026, 3104, 3125);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1026, 3002, 3152);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1026, 3002, 3152);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsOpen
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1026, 3696, 3769);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 3732, 3754);

                    return f_1026_3739_3753(_stream);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1026, 3696, 3769);

                    bool
                    f_1026_3739_3753(System.Management.Automation.Internal.ObjectStreamBase
                    this_param)
                    {
                        var return_v = this_param.IsOpen;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1026, 3739, 3753);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1026, 3644, 3780);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1026, 3644, 3780);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Count
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1026, 3958, 4030);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 3994, 4015);

                    return f_1026_4001_4014(_stream);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1026, 3958, 4030);

                    int
                    f_1026_4001_4014(System.Management.Automation.Internal.ObjectStreamBase
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1026, 4001, 4014);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1026, 3908, 4041);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1026, 3908, 4041);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int MaxCapacity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1026, 4553, 4631);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 4589, 4616);

                    return f_1026_4596_4615(_stream);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1026, 4553, 4631);

                    int
                    f_1026_4596_4615(System.Management.Automation.Internal.ObjectStreamBase
                    this_param)
                    {
                        var return_v = this_param.MaxCapacity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1026, 4596, 4615);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1026, 4497, 4642);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1026, 4497, 4642);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override void Close()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1026, 5200, 5350);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 5323, 5339);

                f_1026_5323_5338(            // 2003/09/02-JonN added call to close underlying stream
                            _stream);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1026, 5200, 5350);

                int
                f_1026_5323_5338(System.Management.Automation.Internal.ObjectStreamBase
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 5323, 5338);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1026, 5200, 5350);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1026, 5200, 5350);
            }
        }

        private void OnDataReady(object sender, EventArgs args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1026, 5679, 5993);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 5941, 5982);

                f_1026_5941_5981(            // call any event handlers on this, replacing the
                                             // ObjectStream sender with 'this' since receivers
                                             // are expecting a PipelineReader<object>
                            InternalDataReady, this, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1026, 5679, 5993);

                int
                f_1026_5941_5981(System.EventHandler
                eventHandler, System.Management.Automation.Internal.ObjectReaderBase<T>
                sender, System.EventArgs
                eventArgs)
                {
                    eventHandler.SafeInvoke((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 5941, 5981);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1026, 5679, 5993);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1026, 5679, 5993);
            }
        }

        protected ObjectStreamBase _stream;

        private object _monitorObject;

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1026, 6876, 6989);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 6922, 6936);

                f_1026_6922_6935(this, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 6952, 6978);

                f_1026_6952_6977(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1026, 6876, 6989);

                int
                f_1026_6922_6935(System.Management.Automation.Internal.ObjectReaderBase<T>
                this_param, bool
                disposing)
                {
                    this_param.Dispose(disposing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 6922, 6935);
                    return 0;
                }


                int
                f_1026_6952_6977(System.Management.Automation.Internal.ObjectReaderBase<T>
                obj)
                {
                    GC.SuppressFinalize((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 6952, 6977);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1026, 6876, 6989);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1026, 6876, 6989);
            }
        }

        protected abstract void Dispose(bool disposing);

        static ObjectReaderBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1026, 548, 7258);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1026, 548, 7258);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1026, 548, 7258);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1026, 548, 7258);

        System.ArgumentNullException
        f_1026_1050_1111(string
        paramName, string
        message)
        {
            var return_v = new System.ArgumentNullException(paramName, message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 1050, 1111);
            return return_v;
        }


        object
        f_1026_6696_6708()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 6696, 6708);
            return return_v;
        }

    }
    internal class ObjectReader : ObjectReaderBase<object>
    {
        public ObjectReader([In, Out] ObjectStream stream)
        : base(f_1026_7903_7909_C(stream))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1026, 7832, 7923);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1026, 7832, 7923);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1026, 7832, 7923);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1026, 7832, 7923);
            }
        }

        public override Collection<object> Read(int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1026, 8396, 8509);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 8471, 8498);

                return f_1026_8478_8497(_stream, count);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1026, 8396, 8509);

                System.Collections.ObjectModel.Collection<object>
                f_1026_8478_8497(System.Management.Automation.Internal.ObjectStreamBase
                this_param, int
                count)
                {
                    var return_v = this_param.Read(count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 8478, 8497);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1026, 8396, 8509);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1026, 8396, 8509);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override object Read()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1026, 8756, 8843);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 8810, 8832);

                return f_1026_8817_8831(_stream);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1026, 8756, 8843);

                object
                f_1026_8817_8831(System.Management.Automation.Internal.ObjectStreamBase
                this_param)
                {
                    var return_v = this_param.Read();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 8817, 8831);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1026, 8756, 8843);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1026, 8756, 8843);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Collection<object> ReadToEnd()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1026, 9158, 9267);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 9229, 9256);

                return f_1026_9236_9255(_stream);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1026, 9158, 9267);

                System.Collections.ObjectModel.Collection<object>
                f_1026_9236_9255(System.Management.Automation.Internal.ObjectStreamBase
                this_param)
                {
                    var return_v = this_param.ReadToEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 9236, 9255);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1026, 9158, 9267);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1026, 9158, 9267);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Collection<object> NonBlockingRead()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1026, 9784, 9919);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 9861, 9908);

                return f_1026_9868_9907(_stream, Int32.MaxValue);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1026, 9784, 9919);

                System.Collections.ObjectModel.Collection<object>
                f_1026_9868_9907(System.Management.Automation.Internal.ObjectStreamBase
                this_param, int
                maxRequested)
                {
                    var return_v = this_param.NonBlockingRead(maxRequested);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 9868, 9907);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1026, 9784, 9919);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1026, 9784, 9919);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Collection<object> NonBlockingRead(int maxRequested)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1026, 10546, 10695);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 10639, 10684);

                return f_1026_10646_10683(_stream, maxRequested);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1026, 10546, 10695);

                System.Collections.ObjectModel.Collection<object>
                f_1026_10646_10683(System.Management.Automation.Internal.ObjectStreamBase
                this_param, int
                maxRequested)
                {
                    var return_v = this_param.NonBlockingRead(maxRequested);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 10646, 10683);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1026, 10546, 10695);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1026, 10546, 10695);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override object Peek()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1026, 10903, 10990);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 10957, 10979);

                return f_1026_10964_10978(_stream);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1026, 10903, 10990);

                object
                f_1026_10964_10978(System.Management.Automation.Internal.ObjectStreamBase
                this_param)
                {
                    var return_v = this_param.Peek();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 10964, 10978);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1026, 10903, 10990);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1026, 10903, 10990);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void Dispose(bool disposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1026, 11170, 11331);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 11242, 11320) || true) && (disposing)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1026, 11242, 11320);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 11289, 11305);

                    f_1026_11289_11304(_stream);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1026, 11242, 11320);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1026, 11170, 11331);

                int
                f_1026_11289_11304(System.Management.Automation.Internal.ObjectStreamBase
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 11289, 11304);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1026, 11170, 11331);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1026, 11170, 11331);
            }
        }

        static ObjectReader()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1026, 7471, 11338);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1026, 7471, 11338);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1026, 7471, 11338);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1026, 7471, 11338);

        static System.Management.Automation.Internal.ObjectStreamBase
        f_1026_7903_7909_C(System.Management.Automation.Internal.ObjectStreamBase
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1026, 7832, 7923);
            return return_v;
        }

    }
    internal class PSObjectReader : ObjectReaderBase<PSObject>
    {
        public PSObjectReader([In, Out] ObjectStream stream)
        : base(f_1026_11991_11997_C(stream))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1026, 11918, 12011);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1026, 11918, 12011);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1026, 11918, 12011);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1026, 11918, 12011);
            }
        }

        public override Collection<PSObject> Read(int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1026, 12484, 12623);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 12561, 12612);

                return f_1026_12568_12611(f_1026_12591_12610(_stream, count));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1026, 12484, 12623);

                System.Collections.ObjectModel.Collection<object>
                f_1026_12591_12610(System.Management.Automation.Internal.ObjectStreamBase
                this_param, int
                count)
                {
                    var return_v = this_param.Read(count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 12591, 12610);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1026_12568_12611(System.Collections.ObjectModel.Collection<object>
                coll)
                {
                    var return_v = MakePSObjectCollection(coll);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 12568, 12611);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1026, 12484, 12623);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1026, 12484, 12623);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override PSObject Read()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1026, 12874, 12977);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 12930, 12966);

                return f_1026_12937_12965(f_1026_12950_12964(_stream));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1026, 12874, 12977);

                object
                f_1026_12950_12964(System.Management.Automation.Internal.ObjectStreamBase
                this_param)
                {
                    var return_v = this_param.Read();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 12950, 12964);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1026_12937_12965(object
                o)
                {
                    var return_v = MakePSObject(o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 12937, 12965);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1026, 12874, 12977);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1026, 12874, 12977);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Collection<PSObject> ReadToEnd()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1026, 13292, 13427);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 13365, 13416);

                return f_1026_13372_13415(f_1026_13395_13414(_stream));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1026, 13292, 13427);

                System.Collections.ObjectModel.Collection<object>
                f_1026_13395_13414(System.Management.Automation.Internal.ObjectStreamBase
                this_param)
                {
                    var return_v = this_param.ReadToEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 13395, 13414);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1026_13372_13415(System.Collections.ObjectModel.Collection<object>
                coll)
                {
                    var return_v = MakePSObjectCollection(coll);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 13372, 13415);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1026, 13292, 13427);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1026, 13292, 13427);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Collection<PSObject> NonBlockingRead()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1026, 13944, 14105);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 14023, 14094);

                return f_1026_14030_14093(f_1026_14053_14092(_stream, Int32.MaxValue));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1026, 13944, 14105);

                System.Collections.ObjectModel.Collection<object>
                f_1026_14053_14092(System.Management.Automation.Internal.ObjectStreamBase
                this_param, int
                maxRequested)
                {
                    var return_v = this_param.NonBlockingRead(maxRequested);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 14053, 14092);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1026_14030_14093(System.Collections.ObjectModel.Collection<object>
                coll)
                {
                    var return_v = MakePSObjectCollection(coll);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 14030, 14093);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1026, 13944, 14105);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1026, 13944, 14105);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Collection<PSObject> NonBlockingRead(int maxRequested)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1026, 14732, 14907);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 14827, 14896);

                return f_1026_14834_14895(f_1026_14857_14894(_stream, maxRequested));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1026, 14732, 14907);

                System.Collections.ObjectModel.Collection<object>
                f_1026_14857_14894(System.Management.Automation.Internal.ObjectStreamBase
                this_param, int
                maxRequested)
                {
                    var return_v = this_param.NonBlockingRead(maxRequested);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 14857, 14894);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1026_14834_14895(System.Collections.ObjectModel.Collection<object>
                coll)
                {
                    var return_v = MakePSObjectCollection(coll);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 14834, 14895);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1026, 14732, 14907);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1026, 14732, 14907);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override PSObject Peek()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1026, 15119, 15222);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 15175, 15211);

                return f_1026_15182_15210(f_1026_15195_15209(_stream));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1026, 15119, 15222);

                object
                f_1026_15195_15209(System.Management.Automation.Internal.ObjectStreamBase
                this_param)
                {
                    var return_v = this_param.Peek();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 15195, 15209);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1026_15182_15210(object
                o)
                {
                    var return_v = MakePSObject(o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 15182, 15210);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1026, 15119, 15222);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1026, 15119, 15222);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void Dispose(bool disposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1026, 15402, 15563);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 15474, 15552) || true) && (disposing)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1026, 15474, 15552);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 15521, 15537);

                    f_1026_15521_15536(_stream);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1026, 15474, 15552);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1026, 15402, 15563);

                int
                f_1026_15521_15536(System.Management.Automation.Internal.ObjectStreamBase
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 15521, 15536);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1026, 15402, 15563);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1026, 15402, 15563);
            }
        }

        private static PSObject MakePSObject(object o)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1026, 15600, 15772);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 15671, 15715) || true) && (o == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1026, 15671, 15715);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 15703, 15715);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1026, 15671, 15715);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 15731, 15761);

                return f_1026_15738_15760(o);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1026, 15600, 15772);

                System.Management.Automation.PSObject
                f_1026_15738_15760(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 15738, 15760);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1026, 15600, 15772);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1026, 15600, 15772);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Collection<PSObject> MakePSObjectCollection(
                    Collection<object> coll)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1026, 16041, 16438);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 16163, 16210) || true) && (coll == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1026, 16163, 16210);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 16198, 16210);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1026, 16163, 16210);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 16224, 16281);

                Collection<PSObject>
                retval = f_1026_16254_16280()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 16295, 16397);
                    foreach (object o in f_1026_16316_16320_I(coll))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1026, 16295, 16397);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 16354, 16382);

                        f_1026_16354_16381(retval, f_1026_16365_16380(o));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1026, 16295, 16397);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1026, 1, 103);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1026, 1, 103);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 16413, 16427);

                return retval;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1026, 16041, 16438);

                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1026_16254_16280()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 16254, 16280);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1026_16365_16380(object
                o)
                {
                    var return_v = MakePSObject(o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 16365, 16380);
                    return return_v;
                }


                int
                f_1026_16354_16381(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                this_param, System.Management.Automation.PSObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 16354, 16381);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<object>
                f_1026_16316_16320_I(System.Collections.ObjectModel.Collection<object>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 16316, 16320);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1026, 16041, 16438);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1026, 16041, 16438);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PSObjectReader()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1026, 11553, 16473);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1026, 11553, 16473);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1026, 11553, 16473);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1026, 11553, 16473);

        static System.Management.Automation.Internal.ObjectStreamBase
        f_1026_11991_11997_C(System.Management.Automation.Internal.ObjectStreamBase
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1026, 11918, 12011);
            return return_v;
        }

    }
    internal class PSDataCollectionReader<DataStoreType, ReturnType>
            : ObjectReaderBase<ReturnType>
    {
        private PSDataCollectionEnumerator<DataStoreType> _enumerator;

        public PSDataCollectionReader(PSDataCollectionStream<DataStoreType> stream)
        : base(f_1026_17474_17480_C(stream))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1026, 17378, 17757);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 17042, 17053);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 17506, 17640);

                f_1026_17506_17639(f_1026_17554_17572(stream) != null, "Stream should have a valid data store");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 17654, 17746);

                _enumerator = (PSDataCollectionEnumerator<DataStoreType>)f_1026_17711_17745(f_1026_17711_17729(stream));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1026, 17378, 17757);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1026, 17378, 17757);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1026, 17378, 17757);
            }
        }

        public override Collection<ReturnType> Read(int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1026, 18016, 18140);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 18095, 18129);

                throw f_1026_18101_18128();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1026, 18016, 18140);

                System.NotSupportedException
                f_1026_18101_18128()
                {
                    var return_v = new System.NotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 18101, 18128);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1026, 18016, 18140);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1026, 18016, 18140);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ReturnType Read()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1026, 18521, 18796);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 18579, 18616);

                object
                result = f_1026_18595_18615()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 18630, 18734) || true) && (f_1026_18634_18656(_enumerator))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1026, 18630, 18734);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 18690, 18719);

                    result = f_1026_18699_18718(_enumerator);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1026, 18630, 18734);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 18750, 18785);

                return f_1026_18757_18784(this, result);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1026, 18521, 18796);

                System.Management.Automation.PSObject
                f_1026_18595_18615()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1026, 18595, 18615);
                    return return_v;
                }


                bool
                f_1026_18634_18656(System.Management.Automation.PSDataCollectionEnumerator<DataStoreType>
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 18634, 18656);
                    return return_v;
                }


                object
                f_1026_18699_18718(System.Management.Automation.PSDataCollectionEnumerator<DataStoreType>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1026, 18699, 18718);
                    return return_v;
                }


                ReturnType
                f_1026_18757_18784(System.Management.Automation.Internal.PSDataCollectionReader<DataStoreType, ReturnType>
                this_param, object
                inputObject)
                {
                    var return_v = this_param.ConvertToReturnType(inputObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 18757, 18784);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1026, 18521, 18796);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1026, 18521, 18796);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Collection<ReturnType> ReadToEnd()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1026, 18964, 19084);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 19039, 19073);

                throw f_1026_19045_19072();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1026, 18964, 19084);

                System.NotSupportedException
                f_1026_19045_19072()
                {
                    var return_v = new System.NotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 19045, 19072);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1026, 18964, 19084);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1026, 18964, 19084);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Collection<ReturnType> NonBlockingRead()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1026, 19252, 19383);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 19333, 19372);

                return f_1026_19340_19371(this, Int32.MaxValue);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1026, 19252, 19383);

                System.Collections.ObjectModel.Collection<ReturnType>
                f_1026_19340_19371(System.Management.Automation.Internal.PSDataCollectionReader<DataStoreType, ReturnType>
                this_param, int
                maxRequested)
                {
                    var return_v = this_param.NonBlockingRead(maxRequested);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 19340, 19371);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1026, 19252, 19383);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1026, 19252, 19383);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Collection<ReturnType> NonBlockingRead(int maxRequested)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1026, 19669, 20489);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 19766, 19916) || true) && (maxRequested < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1026, 19766, 19916);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 19820, 19901);

                    throw f_1026_19826_19900("maxRequested", maxRequested);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1026, 19766, 19916);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 19932, 20038) || true) && (maxRequested == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1026, 19932, 20038);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 19987, 20023);

                    return f_1026_19994_20022();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1026, 19932, 20038);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 20054, 20116);

                Collection<ReturnType>
                results = f_1026_20087_20115()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 20130, 20159);

                int
                readCount = maxRequested
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 20175, 20447) || true) && (readCount > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1026, 20175, 20447);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 20229, 20406) || true) && (f_1026_20233_20260(_enumerator, false))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1026, 20229, 20406);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 20302, 20356);

                            f_1026_20302_20355(results, f_1026_20314_20354(this, f_1026_20334_20353(_enumerator)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 20378, 20387);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1026, 20229, 20406);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1026, 20426, 20432);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1026, 20175, 20447);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1026, 20175, 20447);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1026, 20175, 20447);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 20463, 20478);

                return results;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1026, 19669, 20489);

                System.Management.Automation.PSArgumentOutOfRangeException
                f_1026_19826_19900(string
                paramName, int
                actualValue)
                {
                    var return_v = PSTraceSource.NewArgumentOutOfRangeException(paramName, (object)actualValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 19826, 19900);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<ReturnType>
                f_1026_19994_20022()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<ReturnType>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 19994, 20022);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<ReturnType>
                f_1026_20087_20115()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<ReturnType>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 20087, 20115);
                    return return_v;
                }


                bool
                f_1026_20233_20260(System.Management.Automation.PSDataCollectionEnumerator<DataStoreType>
                this_param, bool
                block)
                {
                    var return_v = this_param.MoveNext(block);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 20233, 20260);
                    return return_v;
                }


                object
                f_1026_20334_20353(System.Management.Automation.PSDataCollectionEnumerator<DataStoreType>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1026, 20334, 20353);
                    return return_v;
                }


                ReturnType
                f_1026_20314_20354(System.Management.Automation.Internal.PSDataCollectionReader<DataStoreType, ReturnType>
                this_param, object
                inputObject)
                {
                    var return_v = this_param.ConvertToReturnType(inputObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 20314, 20354);
                    return return_v;
                }


                int
                f_1026_20302_20355(System.Collections.ObjectModel.Collection<ReturnType>
                this_param, ReturnType
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 20302, 20355);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1026, 19669, 20489);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1026, 19669, 20489);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ReturnType Peek()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1026, 20624, 20727);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 20682, 20716);

                throw f_1026_20688_20715();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1026, 20624, 20727);

                System.NotSupportedException
                f_1026_20688_20715()
                {
                    var return_v = new System.NotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 20688, 20715);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1026, 20624, 20727);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1026, 20624, 20727);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void Dispose(bool disposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1026, 20907, 21068);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 20979, 21057) || true) && (disposing)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1026, 20979, 21057);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 21026, 21042);

                    f_1026_21026_21041(_stream);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1026, 20979, 21057);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1026, 20907, 21068);

                int
                f_1026_21026_21041(System.Management.Automation.Internal.ObjectStreamBase
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 21026, 21041);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1026, 20907, 21068);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1026, 20907, 21068);
            }
        }

        private ReturnType ConvertToReturnType(object inputObject)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1026, 21080, 21669);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 21163, 21200);

                Type
                resultType = typeof(ReturnType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 21214, 21454) || true) && (typeof(PSObject) == resultType || (DynAbs.Tracing.TraceSender.Expression_False(1026, 21218, 21280) || typeof(object) == resultType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1026, 21214, 21454);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 21314, 21332);

                    ReturnType
                    result
                    = default(ReturnType);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 21350, 21407);

                    f_1026_21350_21406(inputObject, out result);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 21425, 21439);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1026, 21214, 21454);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 21470, 21597);

                f_1026_21470_21596(false, "ReturnType should be either object or PSObject only");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 21611, 21658);

                throw f_1026_21617_21657();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1026, 21080, 21669);

                bool
                f_1026_21350_21406(object
                valueToConvert, out ReturnType
                result)
                {
                    var return_v = LanguagePrimitives.TryConvertTo(valueToConvert, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 21350, 21406);
                    return return_v;
                }


                int
                f_1026_21470_21596(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    System.Management.Automation.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 21470, 21596);
                    return 0;
                }


                System.Management.Automation.PSNotSupportedException
                f_1026_21617_21657()
                {
                    var return_v = PSTraceSource.NewNotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 21617, 21657);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1026, 21080, 21669);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1026, 21080, 21669);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PSDataCollectionReader()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1026, 16839, 21676);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1026, 16839, 21676);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1026, 16839, 21676);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1026, 16839, 21676);

        System.Management.Automation.PSDataCollection<DataStoreType>
        f_1026_17554_17572(System.Management.Automation.Internal.PSDataCollectionStream<DataStoreType>
        this_param)
        {
            var return_v = this_param.ObjectStore;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1026, 17554, 17572);
            return return_v;
        }


        int
        f_1026_17506_17639(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            System.Management.Automation.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 17506, 17639);
            return 0;
        }


        System.Management.Automation.PSDataCollection<DataStoreType>
        f_1026_17711_17729(System.Management.Automation.Internal.PSDataCollectionStream<DataStoreType>
        this_param)
        {
            var return_v = this_param.ObjectStore;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1026, 17711, 17729);
            return return_v;
        }


        System.Collections.Generic.IEnumerator<DataStoreType>
        f_1026_17711_17745(System.Management.Automation.PSDataCollection<DataStoreType>
        this_param)
        {
            var return_v = this_param.GetEnumerator();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 17711, 17745);
            return return_v;
        }


        static System.Management.Automation.Internal.ObjectStreamBase
        f_1026_17474_17480_C(System.Management.Automation.Internal.ObjectStreamBase
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1026, 17378, 17757);
            return return_v;
        }

    }
    internal class PSDataCollectionPipelineReader<DataStoreType, ReturnType>
            : ObjectReaderBase<ReturnType>
    {
        private PSDataCollection<DataStoreType> _datastore;

        internal PSDataCollectionPipelineReader(PSDataCollectionStream<DataStoreType> stream,
                    string computerName, Guid runspaceId)
        : base(f_1026_22739_22745_C(stream))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1026, 22582, 23042);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 22243, 22253);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 23221, 23258);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 22771, 22905);

                f_1026_22771_22904(f_1026_22819_22837(stream) != null, "Stream should have a valid data store");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 22919, 22951);

                _datastore = f_1026_22932_22950(stream);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 22965, 22993);

                ComputerName = computerName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 23007, 23031);

                RunspaceId = runspaceId;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1026, 22582, 23042);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1026, 22582, 23042);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1026, 22582, 23042);
            }
        }

        internal string ComputerName { get; }

        internal Guid RunspaceId { get; }

        public override Collection<ReturnType> Read(int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1026, 23673, 23797);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 23752, 23786);

                throw f_1026_23758_23785();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1026, 23673, 23797);

                System.NotSupportedException
                f_1026_23758_23785()
                {
                    var return_v = new System.NotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 23758, 23785);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1026, 23673, 23797);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1026, 23673, 23797);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ReturnType Read()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1026, 24178, 24795);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 24236, 24273);

                object
                result = f_1026_24252_24272()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 24287, 24733) || true) && (f_1026_24291_24307(_datastore) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1026, 24287, 24733);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 24345, 24418);

                    Collection<DataStoreType>
                    resultCollection = f_1026_24390_24417(_datastore, 1)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 24597, 24718) || true) && (f_1026_24601_24623(resultCollection) == 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1026, 24597, 24718);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 24670, 24699);

                        result = f_1026_24679_24698(resultCollection, 0);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1026, 24597, 24718);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1026, 24287, 24733);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 24749, 24784);

                return f_1026_24756_24783(this, result);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1026, 24178, 24795);

                System.Management.Automation.PSObject
                f_1026_24252_24272()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1026, 24252, 24272);
                    return return_v;
                }


                int
                f_1026_24291_24307(System.Management.Automation.PSDataCollection<DataStoreType>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1026, 24291, 24307);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<DataStoreType>
                f_1026_24390_24417(System.Management.Automation.PSDataCollection<DataStoreType>
                this_param, int
                readCount)
                {
                    var return_v = this_param.ReadAndRemove(readCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 24390, 24417);
                    return return_v;
                }


                int
                f_1026_24601_24623(System.Collections.ObjectModel.Collection<DataStoreType>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1026, 24601, 24623);
                    return return_v;
                }


                DataStoreType
                f_1026_24679_24698(System.Collections.ObjectModel.Collection<DataStoreType>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1026, 24679, 24698);
                    return return_v;
                }


                ReturnType
                f_1026_24756_24783(System.Management.Automation.Internal.PSDataCollectionPipelineReader<DataStoreType, ReturnType>
                this_param, object
                inputObject)
                {
                    var return_v = this_param.ConvertToReturnType(inputObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 24756, 24783);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1026, 24178, 24795);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1026, 24178, 24795);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Collection<ReturnType> ReadToEnd()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1026, 24963, 25083);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 25038, 25072);

                throw f_1026_25044_25071();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1026, 24963, 25083);

                System.NotSupportedException
                f_1026_25044_25071()
                {
                    var return_v = new System.NotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 25044, 25071);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1026, 24963, 25083);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1026, 24963, 25083);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Collection<ReturnType> NonBlockingRead()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1026, 25251, 25382);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 25332, 25371);

                return f_1026_25339_25370(this, Int32.MaxValue);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1026, 25251, 25382);

                System.Collections.ObjectModel.Collection<ReturnType>
                f_1026_25339_25370(System.Management.Automation.Internal.PSDataCollectionPipelineReader<DataStoreType, ReturnType>
                this_param, int
                maxRequested)
                {
                    var return_v = this_param.NonBlockingRead(maxRequested);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 25339, 25370);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1026, 25251, 25382);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1026, 25251, 25382);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Collection<ReturnType> NonBlockingRead(int maxRequested)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1026, 25668, 26528);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 25765, 25915) || true) && (maxRequested < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1026, 25765, 25915);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 25819, 25900);

                    throw f_1026_25825_25899("maxRequested", maxRequested);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1026, 25765, 25915);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 25931, 26037) || true) && (maxRequested == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1026, 25931, 26037);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 25986, 26022);

                    return f_1026_25993_26021();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1026, 25931, 26037);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 26053, 26115);

                Collection<ReturnType>
                results = f_1026_26086_26114()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 26129, 26158);

                int
                readCount = maxRequested
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 26174, 26486) || true) && (readCount > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1026, 26174, 26486);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 26228, 26445) || true) && (f_1026_26232_26248(_datastore) > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1026, 26228, 26445);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 26294, 26361);

                            f_1026_26294_26360(results, f_1026_26306_26359(this, f_1026_26326_26358((f_1026_26327_26354(_datastore, 1)), 0)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 26383, 26395);

                            readCount--;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 26417, 26426);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1026, 26228, 26445);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1026, 26465, 26471);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1026, 26174, 26486);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1026, 26174, 26486);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1026, 26174, 26486);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 26502, 26517);

                return results;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1026, 25668, 26528);

                System.Management.Automation.PSArgumentOutOfRangeException
                f_1026_25825_25899(string
                paramName, int
                actualValue)
                {
                    var return_v = PSTraceSource.NewArgumentOutOfRangeException(paramName, (object)actualValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 25825, 25899);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<ReturnType>
                f_1026_25993_26021()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<ReturnType>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 25993, 26021);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<ReturnType>
                f_1026_26086_26114()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<ReturnType>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 26086, 26114);
                    return return_v;
                }


                int
                f_1026_26232_26248(System.Management.Automation.PSDataCollection<DataStoreType>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1026, 26232, 26248);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<DataStoreType>
                f_1026_26327_26354(System.Management.Automation.PSDataCollection<DataStoreType>
                this_param, int
                readCount)
                {
                    var return_v = this_param.ReadAndRemove(readCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 26327, 26354);
                    return return_v;
                }


                DataStoreType
                f_1026_26326_26358(System.Collections.ObjectModel.Collection<DataStoreType>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1026, 26326, 26358);
                    return return_v;
                }


                ReturnType
                f_1026_26306_26359(System.Management.Automation.Internal.PSDataCollectionPipelineReader<DataStoreType, ReturnType>
                this_param, DataStoreType
                inputObject)
                {
                    var return_v = this_param.ConvertToReturnType((object)inputObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 26306, 26359);
                    return return_v;
                }


                int
                f_1026_26294_26360(System.Collections.ObjectModel.Collection<ReturnType>
                this_param, ReturnType
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 26294, 26360);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1026, 25668, 26528);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1026, 25668, 26528);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ReturnType Peek()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1026, 26663, 26766);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 26721, 26755);

                throw f_1026_26727_26754();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1026, 26663, 26766);

                System.NotSupportedException
                f_1026_26727_26754()
                {
                    var return_v = new System.NotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 26727, 26754);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1026, 26663, 26766);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1026, 26663, 26766);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ReturnType ConvertToReturnType(object inputObject)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1026, 27053, 27642);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 27136, 27173);

                Type
                resultType = typeof(ReturnType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 27187, 27427) || true) && (typeof(PSObject) == resultType || (DynAbs.Tracing.TraceSender.Expression_False(1026, 27191, 27253) || typeof(object) == resultType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1026, 27187, 27427);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 27287, 27305);

                    ReturnType
                    result
                    = default(ReturnType);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 27323, 27380);

                    f_1026_27323_27379(inputObject, out result);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 27398, 27412);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1026, 27187, 27427);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 27443, 27570);

                f_1026_27443_27569(false, "ReturnType should be either object or PSObject only");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 27584, 27631);

                throw f_1026_27590_27630();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1026, 27053, 27642);

                bool
                f_1026_27323_27379(object
                valueToConvert, out ReturnType
                result)
                {
                    var return_v = LanguagePrimitives.TryConvertTo(valueToConvert, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 27323, 27379);
                    return return_v;
                }


                int
                f_1026_27443_27569(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    System.Management.Automation.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 27443, 27569);
                    return 0;
                }


                System.Management.Automation.PSNotSupportedException
                f_1026_27590_27630()
                {
                    var return_v = PSTraceSource.NewNotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 27590, 27630);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1026, 27053, 27642);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1026, 27053, 27642);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void Dispose(bool disposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1026, 27853, 28019);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 27925, 28008) || true) && (disposing)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1026, 27925, 28008);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1026, 27972, 27993);

                    f_1026_27972_27992(_datastore);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1026, 27925, 28008);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1026, 27853, 28019);

                int
                f_1026_27972_27992(System.Management.Automation.PSDataCollection<DataStoreType>
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 27972, 27992);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1026, 27853, 28019);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1026, 27853, 28019);
            }
        }

        static PSDataCollectionPipelineReader()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1026, 22042, 28060);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1026, 22042, 28060);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1026, 22042, 28060);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1026, 22042, 28060);

        System.Management.Automation.PSDataCollection<DataStoreType>
        f_1026_22819_22837(System.Management.Automation.Internal.PSDataCollectionStream<DataStoreType>
        this_param)
        {
            var return_v = this_param.ObjectStore;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1026, 22819, 22837);
            return return_v;
        }


        int
        f_1026_22771_22904(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            System.Management.Automation.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1026, 22771, 22904);
            return 0;
        }


        System.Management.Automation.PSDataCollection<DataStoreType>
        f_1026_22932_22950(System.Management.Automation.Internal.PSDataCollectionStream<DataStoreType>
        this_param)
        {
            var return_v = this_param.ObjectStore;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1026, 22932, 22950);
            return return_v;
        }


        static System.Management.Automation.Internal.ObjectStreamBase
        f_1026_22739_22745_C(System.Management.Automation.Internal.ObjectStreamBase
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1026, 22582, 23042);
            return return_v;
        }

    }
}
