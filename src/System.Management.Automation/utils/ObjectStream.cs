// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace System.Management.Automation.Internal
{
    using System;
    using System.Threading;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Management.Automation.Runspaces;
    internal abstract class ObjectStreamBase : IDisposable
    {                /// <summary>
                     /// Event fired when data is added to the buffer.
                     /// </summary>
        internal event EventHandler
DataReady = null
;

        internal void FireDataReadyEvent(object source, EventArgs args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1027, 1262, 1396);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 1350, 1385);

                f_1027_1350_1384(DataReady, source, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1027, 1262, 1396);

                int
                f_1027_1350_1384(System.EventHandler
                eventHandler, object
                sender, System.EventArgs
                eventArgs)
                {
                    eventHandler.SafeInvoke(sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 1350, 1384);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 1262, 1396);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 1262, 1396);
            }
        }

        internal abstract int MaxCapacity { get; }

        internal virtual WaitHandle ReadHandle
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1027, 2657, 2967);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 2874, 2921);

                    throw f_1027_2880_2920();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1027, 2657, 2967);

                    System.Management.Automation.PSNotSupportedException
                    f_1027_2880_2920()
                    {
                        var return_v = PSTraceSource.NewNotSupportedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 2880, 2920);
                        return return_v;
                    }

#pragma warning restore 56503
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 2594, 2978);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 2594, 2978);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual WaitHandle WriteHandle
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1027, 3467, 3777);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 3684, 3731);

                    throw f_1027_3690_3730();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1027, 3467, 3777);

                    System.Management.Automation.PSNotSupportedException
                    f_1027_3690_3730()
                    {
                        var return_v = PSTraceSource.NewNotSupportedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 3690, 3730);
                        return return_v;
                    }

#pragma warning restore 56503
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 3403, 3788);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 3403, 3788);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal abstract bool EndOfPipeline { get; }

        internal abstract bool IsOpen { get; }

        internal abstract int Count { get; }

        internal abstract PipelineReader<object> ObjectReader { get; }

        internal abstract PipelineReader<PSObject> PSObjectReader { get; }

        internal abstract PipelineWriter ObjectWriter { get; }

        internal virtual object Read()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1027, 5974, 6087);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 6029, 6076);

                throw f_1027_6035_6075();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1027, 5974, 6087);

                System.Management.Automation.PSNotSupportedException
                f_1027_6035_6075()
                {
                    var return_v = PSTraceSource.NewNotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 6035, 6075);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 5974, 6087);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 5974, 6087);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual Collection<object> Read(int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1027, 7386, 7520);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 7462, 7509);

                throw f_1027_7468_7508();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1027, 7386, 7520);

                System.Management.Automation.PSNotSupportedException
                f_1027_7468_7508()
                {
                    var return_v = PSTraceSource.NewNotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 7468, 7508);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 7386, 7520);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 7386, 7520);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual Collection<object> ReadToEnd()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1027, 8553, 8683);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 8625, 8672);

                throw f_1027_8631_8671();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1027, 8553, 8683);

                System.Management.Automation.PSNotSupportedException
                f_1027_8631_8671()
                {
                    var return_v = PSTraceSource.NewNotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 8631, 8671);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 8553, 8683);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 8553, 8683);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual Collection<object> NonBlockingRead(int maxRequested)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1027, 9447, 9599);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 9541, 9588);

                throw f_1027_9547_9587();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1027, 9447, 9599);

                System.Management.Automation.PSNotSupportedException
                f_1027_9547_9587()
                {
                    var return_v = PSTraceSource.NewNotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 9547, 9587);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 9447, 9599);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 9447, 9599);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual object Peek()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1027, 9925, 10038);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 9980, 10027);

                throw f_1027_9986_10026();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1027, 9925, 10038);

                System.Management.Automation.PSNotSupportedException
                f_1027_9986_10026()
                {
                    var return_v = PSTraceSource.NewNotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 9986, 10026);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 9925, 10038);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 9925, 10038);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual int Write(object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1027, 10820, 10923);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 10885, 10912);

                return f_1027_10892_10911(this, value, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1027, 10820, 10923);

                int
                f_1027_10892_10911(System.Management.Automation.Internal.ObjectStreamBase
                this_param, object
                obj, bool
                enumerateCollection)
                {
                    var return_v = this_param.Write(obj, enumerateCollection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 10892, 10911);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 10820, 10923);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 10820, 10923);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual int Write(object obj, bool enumerateCollection)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1027, 11967, 12114);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 12056, 12103);

                throw f_1027_12062_12102();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1027, 11967, 12114);

                System.Management.Automation.PSNotSupportedException
                f_1027_12062_12102()
                {
                    var return_v = PSTraceSource.NewNotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 12062, 12102);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 11967, 12114);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 11967, 12114);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual void Close()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1027, 12524, 12636);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 12578, 12625);

                throw f_1027_12584_12624();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1027, 12524, 12636);

                System.Management.Automation.PSNotSupportedException
                f_1027_12584_12624()
                {
                    var return_v = PSTraceSource.NewNotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 12584, 12624);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 12524, 12636);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 12524, 12636);
            }
        }

        internal virtual void Flush()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1027, 12772, 12884);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 12826, 12873);

                throw f_1027_12832_12872();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1027, 12772, 12884);

                System.Management.Automation.PSNotSupportedException
                f_1027_12832_12872()
                {
                    var return_v = PSTraceSource.NewNotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 12832, 12872);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 12772, 12884);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 12772, 12884);
            }
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1027, 13036, 13149);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 13082, 13096);

                f_1027_13082_13095(this, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 13112, 13138);

                f_1027_13112_13137(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1027, 13036, 13149);

                int
                f_1027_13082_13095(System.Management.Automation.Internal.ObjectStreamBase
                this_param, bool
                disposing)
                {
                    this_param.Dispose(disposing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 13082, 13095);
                    return 0;
                }


                int
                f_1027_13112_13137(System.Management.Automation.Internal.ObjectStreamBase
                obj)
                {
                    GC.SuppressFinalize((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 13112, 13137);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 13036, 13149);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 13036, 13149);
            }
        }

        protected abstract void Dispose(bool disposing);

        public ObjectStreamBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1027, 745, 13418);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1027, 745, 13418);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 745, 13418);
        }


        static ObjectStreamBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1027, 745, 13418);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1027, 745, 13418);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 745, 13418);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1027, 745, 13418);
    }
    internal sealed class ObjectStream : ObjectStreamBase, IDisposable
    {
        private List<object> _objects;

        private bool _isOpen;

        private AutoResetEvent _readHandle;

        private ManualResetEvent _readWaitHandle;

        private ManualResetEvent _readClosedHandle;

        private AutoResetEvent _writeHandle;

        private ManualResetEvent _writeWaitHandle;

        private ManualResetEvent _writeClosedHandle;

        private PipelineReader<object> _reader;

        private PipelineReader<PSObject> _mshreader;

        private PipelineWriter _writer;

        private int _capacity;

        private object _monitorObject;

        private bool _disposed;

        internal ObjectStream()
        : this(f_1027_20654_20668_C(Int32.MaxValue))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1027, 20610, 20691);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1027, 20610, 20691);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 20610, 20691);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 20610, 20691);
            }
        }

        internal ObjectStream(int capacity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1027, 21308, 22362);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 16092, 16100);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 16228, 16235);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 16891, 16902);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 17055, 17070);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 17283, 17300);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 18060, 18072);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 18266, 18282);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 18495, 18513);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 18843, 18857);
                this._reader = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 19147, 19164);
                this._mshreader = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 19442, 19456);
                this._writer = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 19726, 19752);
                this._capacity = Int32.MaxValue;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 20158, 20187);
                this._monitorObject = f_1027_20175_20187();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 20325, 20342);
                this._disposed = false;
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 21368, 21536) || true) && (capacity <= 0 || (DynAbs.Tracing.TraceSender.Expression_False(1027, 21372, 21414) || capacity > Int32.MaxValue))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 21368, 21536);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 21448, 21521);

                    throw f_1027_21454_21520("capacity", capacity);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 21368, 21536);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 21638, 21659);

                _capacity = capacity;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 21744, 21784);

                _readHandle = f_1027_21758_21783(false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 21872, 21912);

                _writeHandle = f_1027_21887_21911(true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 22001, 22049);

                _readClosedHandle = f_1027_22021_22048(false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 22135, 22184);

                _writeClosedHandle = f_1027_22156_22183(false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 22254, 22284);

                _objects = f_1027_22265_22283();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 22336, 22351);

                _isOpen = true;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1027, 21308, 22362);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 21308, 22362);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 21308, 22362);
            }
        }

        internal override int MaxCapacity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1027, 23006, 23074);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 23042, 23059);

                    return _capacity;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1027, 23006, 23074);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 22948, 23085);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 22948, 23085);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override WaitHandle ReadHandle
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1027, 23711, 24587);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 23747, 23772);

                    WaitHandle
                    handle = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 23798, 23812);

                    lock (_monitorObject)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 23854, 24470) || true) && (_readWaitHandle == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 23854, 24470);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 24376, 24447);

                            _readWaitHandle = f_1027_24394_24446(f_1027_24415_24429(_objects) > 0 || (DynAbs.Tracing.TraceSender.Expression_False(1027, 24415, 24445) || !_isOpen));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 23854, 24470);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 24494, 24519);

                        handle = _readWaitHandle;
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 24558, 24572);

                    return handle;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1027, 23711, 24587);

                    int
                    f_1027_24415_24429(System.Collections.Generic.List<object>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1027, 24415, 24429);
                        return return_v;
                    }


                    System.Threading.ManualResetEvent
                    f_1027_24394_24446(bool
                    initialState)
                    {
                        var return_v = new System.Threading.ManualResetEvent(initialState);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 24394, 24446);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 23647, 24598);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 23647, 24598);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override WaitHandle WriteHandle
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1027, 25088, 25530);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 25124, 25149);

                    WaitHandle
                    handle = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 25175, 25189);

                    lock (_monitorObject)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 25231, 25412) || true) && (_writeWaitHandle == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 25231, 25412);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 25309, 25389);

                            _writeWaitHandle = f_1027_25328_25388(f_1027_25349_25363(_objects) < _capacity || (DynAbs.Tracing.TraceSender.Expression_False(1027, 25349, 25387) || !_isOpen));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 25231, 25412);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 25436, 25462);

                        handle = _writeWaitHandle;
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 25501, 25515);

                    return handle;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1027, 25088, 25530);

                    int
                    f_1027_25349_25363(System.Collections.Generic.List<object>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1027, 25349, 25363);
                        return return_v;
                    }


                    System.Threading.ManualResetEvent
                    f_1027_25328_25388(bool
                    initialState)
                    {
                        var return_v = new System.Threading.ManualResetEvent(initialState);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 25328, 25388);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 25023, 25541);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 25023, 25541);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override PipelineReader<object> ObjectReader
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1027, 25740, 26721);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 25776, 25813);

                    PipelineReader<object>
                    reader = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 25839, 25853);

                    lock (_monitorObject)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 25895, 26612) || true) && (_reader == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 25895, 26612);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 26556, 26589);

                            _reader = f_1027_26566_26588(this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 25895, 26612);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 26636, 26653);

                        reader = _reader;
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 26692, 26706);

                    return reader;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1027, 25740, 26721);

                    System.Management.Automation.Internal.ObjectReader
                    f_1027_26566_26588(System.Management.Automation.Internal.ObjectStream
                    stream)
                    {
                        var return_v = new System.Management.Automation.Internal.ObjectReader(stream);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 26566, 26588);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 25662, 26732);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 25662, 26732);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override PipelineReader<PSObject> PSObjectReader
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1027, 26937, 27931);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 26973, 27012);

                    PipelineReader<PSObject>
                    reader = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 27038, 27052);

                    lock (_monitorObject)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 27094, 27819) || true) && (_mshreader == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 27094, 27819);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 27758, 27796);

                            _mshreader = f_1027_27771_27795(this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 27094, 27819);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 27843, 27863);

                        reader = _mshreader;
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 27902, 27916);

                    return reader;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1027, 26937, 27931);

                    System.Management.Automation.Internal.PSObjectReader
                    f_1027_27771_27795(System.Management.Automation.Internal.ObjectStream
                    stream)
                    {
                        var return_v = new System.Management.Automation.Internal.PSObjectReader(stream);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 27771, 27795);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 26855, 27942);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 26855, 27942);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override PipelineWriter ObjectWriter
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1027, 28205, 28604);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 28241, 28270);

                    PipelineWriter
                    writer = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 28296, 28310);

                    lock (_monitorObject)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 28352, 28495) || true) && (_writer == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 28352, 28495);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 28421, 28472);

                            _writer = f_1027_28431_28453(this) as PipelineWriter;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 28352, 28495);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 28519, 28536);

                        writer = _writer;
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 28575, 28589);

                    return writer;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1027, 28205, 28604);

                    System.Management.Automation.Internal.ObjectWriter
                    f_1027_28431_28453(System.Management.Automation.Internal.ObjectStream
                    stream)
                    {
                        var return_v = new System.Management.Automation.Internal.ObjectWriter((System.Management.Automation.Internal.ObjectStreamBase)stream);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 28431, 28453);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 28135, 28615);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 28135, 28615);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool EndOfPipeline
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1027, 29130, 29401);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 29166, 29190);

                    bool
                    endOfStream = true
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 29216, 29230);

                    lock (_monitorObject)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 29272, 29328);

                        endOfStream = (f_1027_29287_29301(_objects) == 0 && (DynAbs.Tracing.TraceSender.Expression_True(1027, 29287, 29326) && _isOpen == false));
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 29367, 29386);

                    return endOfStream;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1027, 29130, 29401);

                    int
                    f_1027_29287_29301(System.Collections.Generic.List<object>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1027, 29287, 29301);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 29069, 29412);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 29069, 29412);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsOpen
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1027, 29991, 30378);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 30027, 30046);

                    bool
                    isOpen = true
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 30237, 30251);
                    // 2003/09/02-JonN Hitesh says that the access
                    // of a bool variable is atomic so there is no need
                    // for the lock.
                    lock (_monitorObject)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 30293, 30310);

                        isOpen = _isOpen;
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 30349, 30363);

                    return isOpen;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1027, 29991, 30378);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 29937, 30389);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 29937, 30389);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override int Count
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1027, 30558, 30780);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 30594, 30608);

                    int
                    count = 0
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 30634, 30648);

                    lock (_monitorObject)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 30690, 30713);

                        count = f_1027_30698_30712(_objects);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 30752, 30765);

                    return count;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1027, 30558, 30780);

                    int
                    f_1027_30698_30712(System.Collections.Generic.List<object>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1027, 30698, 30712);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 30506, 30791);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 30506, 30791);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool WaitRead()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1027, 31464, 32108);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 31512, 32051) || true) && (f_1027_31516_31529() == false)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 31512, 32051);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 31616, 31669);

                        WaitHandle[]
                        ha = { _readHandle, _readClosedHandle }
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 31691, 31714);

                        f_1027_31691_31713(ha);
                    }
                    catch (ObjectDisposedException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1027, 31774, 32036);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1027, 31774, 32036);
                        // Since the _readHandle must be acquired outside
                        // a lock there's a chance that it was
                        // disposed after checking EndOfPipeline
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 31512, 32051);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 32067, 32097);

                return f_1027_32074_32087() == false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1027, 31464, 32108);

                bool
                f_1027_31516_31529()
                {
                    var return_v = EndOfPipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1027, 31516, 31529);
                    return return_v;
                }


                int
                f_1027_31691_31713(System.Threading.WaitHandle[]
                waitHandles)
                {
                    var return_v = WaitHandle.WaitAny(waitHandles);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 31691, 31713);
                    return return_v;
                }


                bool
                f_1027_32074_32087()
                {
                    var return_v = EndOfPipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1027, 32074, 32087);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 31464, 32108);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 31464, 32108);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool WaitWrite()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1027, 32639, 33248);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 32688, 33207) || true) && (f_1027_32692_32698())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 32688, 33207);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 32776, 32831);

                        WaitHandle[]
                        ha = { _writeHandle, _writeClosedHandle }
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 32853, 32876);

                        f_1027_32853_32875(ha);
                    }
                    catch (ObjectDisposedException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1027, 32936, 33192);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1027, 32936, 33192);
                        // Since the _writeHandle must be acquired outside
                        // a lock there's a chance that it was
                        // disposed after checking IsOpen
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 32688, 33207);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 33223, 33237);

                return f_1027_33230_33236();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1027, 32639, 33248);

                bool
                f_1027_32692_32698()
                {
                    var return_v = IsOpen;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1027, 32692, 32698);
                    return return_v;
                }


                int
                f_1027_32853_32875(System.Threading.WaitHandle[]
                waitHandles)
                {
                    var return_v = WaitHandle.WaitAny(waitHandles);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 32853, 32875);
                    return return_v;
                }


                bool
                f_1027_33230_33236()
                {
                    var return_v = IsOpen;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1027, 33230, 33236);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 32639, 33248);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 32639, 33248);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void RaiseEvents()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1027, 33700, 37859);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 33751, 33778);

                bool
                unblockReaders = true
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 33792, 33819);

                bool
                unblockWriters = true
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 33833, 33858);

                bool
                endOfStream = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 33914, 33928);
                    lock (_monitorObject)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 34184, 34236);

                        unblockReaders = (!_isOpen || (DynAbs.Tracing.TraceSender.Expression_False(1027, 34202, 34234) || (f_1027_34215_34229(_objects) > 0)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 34258, 34318);

                        unblockWriters = (!_isOpen || (DynAbs.Tracing.TraceSender.Expression_False(1027, 34276, 34316) || (f_1027_34289_34303(_objects) < _capacity)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 34340, 34390);

                        endOfStream = (!_isOpen && (DynAbs.Tracing.TraceSender.Expression_True(1027, 34355, 34388) && (f_1027_34368_34382(_objects) == 0)));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 34788, 35377) || true) && (_readWaitHandle != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 34788, 35377);
                            try
                            {

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 34925, 35216) || true) && (unblockReaders)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 34925, 35216);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 35009, 35031);

                                    f_1027_35009_35030(_readWaitHandle);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 34925, 35216);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 34925, 35216);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 35161, 35185);

                                    f_1027_35161_35184(_readWaitHandle);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 34925, 35216);
                                }
                            }
                            catch (ObjectDisposedException)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1027, 35269, 35354);
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1027, 35269, 35354);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 34788, 35377);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 35401, 35993) || true) && (_writeWaitHandle != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 35401, 35993);
                            try
                            {

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 35539, 35832) || true) && (unblockWriters)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 35539, 35832);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 35623, 35646);

                                    f_1027_35623_35645(_writeWaitHandle);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 35539, 35832);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 35539, 35832);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 35776, 35801);

                                    f_1027_35776_35800(_writeWaitHandle);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 35539, 35832);
                                }
                            }
                            catch (ObjectDisposedException)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1027, 35885, 35970);
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1027, 35885, 35970);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 35401, 35993);
                        }
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1027, 36041, 37210);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 36338, 36609) || true) && (unblockReaders)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 36338, 36609);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 36450, 36468);

                            f_1027_36450_36467(_readHandle);
                        }
                        catch (ObjectDisposedException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1027, 36513, 36590);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1027, 36513, 36590);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 36338, 36609);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 36629, 36901) || true) && (unblockWriters)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 36629, 36901);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 36741, 36760);

                            f_1027_36741_36759(_writeHandle);
                        }
                        catch (ObjectDisposedException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1027, 36805, 36882);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1027, 36805, 36882);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 36629, 36901);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 36921, 37195) || true) && (endOfStream)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 36921, 37195);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 37030, 37054);

                            f_1027_37030_37053(_readClosedHandle);
                        }
                        catch (ObjectDisposedException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1027, 37099, 37176);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1027, 37099, 37176);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 36921, 37195);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1027, 36041, 37210);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 37321, 37430) || true) && (unblockReaders)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 37321, 37430);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 37373, 37415);

                    f_1027_37373_37414(this, this, EventArgs.Empty);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 37321, 37430);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1027, 33700, 37859);

                int
                f_1027_34215_34229(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1027, 34215, 34229);
                    return return_v;
                }


                int
                f_1027_34289_34303(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1027, 34289, 34303);
                    return return_v;
                }


                int
                f_1027_34368_34382(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1027, 34368, 34382);
                    return return_v;
                }


                bool
                f_1027_35009_35030(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.Set();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 35009, 35030);
                    return return_v;
                }


                bool
                f_1027_35161_35184(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.Reset();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 35161, 35184);
                    return return_v;
                }


                bool
                f_1027_35623_35645(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.Set();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 35623, 35645);
                    return return_v;
                }


                bool
                f_1027_35776_35800(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.Reset();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 35776, 35800);
                    return return_v;
                }


                bool
                f_1027_36450_36467(System.Threading.AutoResetEvent
                this_param)
                {
                    var return_v = this_param.Set();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 36450, 36467);
                    return return_v;
                }


                bool
                f_1027_36741_36759(System.Threading.AutoResetEvent
                this_param)
                {
                    var return_v = this_param.Set();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 36741, 36759);
                    return return_v;
                }


                bool
                f_1027_37030_37053(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.Set();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 37030, 37053);
                    return return_v;
                }


                int
                f_1027_37373_37414(System.Management.Automation.Internal.ObjectStream
                this_param, System.Management.Automation.Internal.ObjectStream
                source, System.EventArgs
                args)
                {
                    this_param.FireDataReadyEvent((object)source, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 37373, 37414);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 33700, 37859);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 33700, 37859);
            }
        }

        internal override void Flush()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1027, 38074, 38629);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 38129, 38154);

                bool
                raiseEvents = false
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 38212, 38226);
                    lock (_monitorObject)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 38268, 38425) || true) && (f_1027_38272_38286(_objects) > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 38268, 38425);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 38340, 38359);

                            raiseEvents = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 38385, 38402);

                            f_1027_38385_38401(_objects);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 38268, 38425);
                        }
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1027, 38473, 38618);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 38513, 38603) || true) && (raiseEvents)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 38513, 38603);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 38570, 38584);

                        f_1027_38570_38583(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 38513, 38603);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1027, 38473, 38618);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1027, 38074, 38629);

                int
                f_1027_38272_38286(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1027, 38272, 38286);
                    return return_v;
                }


                int
                f_1027_38385_38401(System.Collections.Generic.List<object>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 38385, 38401);
                    return 0;
                }


                int
                f_1027_38570_38583(System.Management.Automation.Internal.ObjectStream
                this_param)
                {
                    this_param.RaiseEvents();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 38570, 38583);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 38074, 38629);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 38074, 38629);
            }
        }

        internal override void Close()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1027, 38984, 39999);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 39039, 39064);

                bool
                raiseEvents = false
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 39122, 39136);
                    lock (_monitorObject)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 39356, 39501) || true) && (_isOpen)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 39356, 39501);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 39417, 39436);

                            raiseEvents = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 39462, 39478);

                            _isOpen = false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 39356, 39501);
                        }
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1027, 39549, 39988);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 39589, 39973) || true) && (raiseEvents)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 39589, 39973);
                        // RaiseEvents does not manage _writeClosedHandle
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 39769, 39794);

                            f_1027_39769_39793(_writeClosedHandle);
                        }
                        catch (ObjectDisposedException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1027, 39839, 39916);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1027, 39839, 39916);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 39940, 39954);

                        f_1027_39940_39953(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 39589, 39973);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1027, 39549, 39988);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1027, 38984, 39999);

                bool
                f_1027_39769_39793(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.Set();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 39769, 39793);
                    return return_v;
                }


                int
                f_1027_39940_39953(System.Management.Automation.Internal.ObjectStream
                this_param)
                {
                    this_param.RaiseEvents();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 39940, 39953);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 38984, 39999);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 38984, 39999);
            }
        }

        internal override object Read()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1027, 40363, 40703);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 40419, 40455);

                Collection<object>
                result = f_1027_40447_40454(this, 1)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 40469, 40556) || true) && (f_1027_40473_40485(result) == 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 40469, 40556);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 40524, 40541);

                    return f_1027_40531_40540(result, 0);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 40469, 40556);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 40572, 40648);

                f_1027_40572_40647(f_1027_40591_40603(result) == 0, "Invalid number of objects returned");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 40664, 40692);

                return f_1027_40671_40691();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1027, 40363, 40703);

                System.Collections.ObjectModel.Collection<object>
                f_1027_40447_40454(System.Management.Automation.Internal.ObjectStream
                this_param, int
                count)
                {
                    var return_v = this_param.Read(count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 40447, 40454);
                    return return_v;
                }


                int
                f_1027_40473_40485(System.Collections.ObjectModel.Collection<object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1027, 40473, 40485);
                    return return_v;
                }


                object
                f_1027_40531_40540(System.Collections.ObjectModel.Collection<object>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1027, 40531, 40540);
                    return return_v;
                }


                int
                f_1027_40591_40603(System.Collections.ObjectModel.Collection<object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1027, 40591, 40603);
                    return return_v;
                }


                int
                f_1027_40572_40647(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 40572, 40647);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1027_40671_40691()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1027, 40671, 40691);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 40363, 40703);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 40363, 40703);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override Collection<object> Read(int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1027, 42002, 44088);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 42079, 42208) || true) && (count < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 42079, 42208);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 42126, 42193);

                    throw f_1027_42132_42192("count", count);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 42079, 42208);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 42224, 42319) || true) && (count == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 42224, 42319);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 42272, 42304);

                    return f_1027_42279_42303();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 42224, 42319);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 42335, 42389);

                Collection<object>
                results = f_1027_42364_42388()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 42405, 42430);

                bool
                raiseEvents = false
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 42444, 44046) || true) && ((count > 0) && (DynAbs.Tracing.TraceSender.Expression_True(1027, 42451, 42476) && f_1027_42466_42476(this)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 42444, 44046);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 42560, 42574);
                            lock (_monitorObject)
                            {

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 42689, 42827) || true) && (f_1027_42693_42707(_objects) == 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 42689, 42827);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 42770, 42779);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 42689, 42827);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 42855, 42874);

                                raiseEvents = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 42987, 43008);

                                int
                                objectsAdded = 0
                                ;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 43034, 43295);
                                    foreach (object o in f_1027_43055_43063_I(_objects))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 43034, 43295);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 43121, 43136);

                                        f_1027_43121_43135(results, o);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 43166, 43181);

                                        objectsAdded++;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 43211, 43268) || true) && (--count <= 0)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 43211, 43268);
                                            DynAbs.Tracing.TraceSender.TraceBreak(1027, 43262, 43268);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 43211, 43268);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 43034, 43295);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1027, 1, 262);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1027, 1, 262);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 43323, 43361);

                                f_1027_43323_43360(
                                                        _objects, 0, objectsAdded);
                            }
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinally(1027, 43421, 44031);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 43910, 44012) || true) && (raiseEvents)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 43910, 44012);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 43975, 43989);

                                f_1027_43975_43988(this);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 43910, 44012);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitFinally(1027, 43421, 44031);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 42444, 44046);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1027, 42444, 44046);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1027, 42444, 44046);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 44062, 44077);

                return results;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1027, 42002, 44088);

                System.Management.Automation.PSArgumentOutOfRangeException
                f_1027_42132_42192(string
                paramName, int
                actualValue)
                {
                    var return_v = PSTraceSource.NewArgumentOutOfRangeException(paramName, (object)actualValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 42132, 42192);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<object>
                f_1027_42279_42303()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 42279, 42303);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<object>
                f_1027_42364_42388()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 42364, 42388);
                    return return_v;
                }


                bool
                f_1027_42466_42476(System.Management.Automation.Internal.ObjectStream
                this_param)
                {
                    var return_v = this_param.WaitRead();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 42466, 42476);
                    return return_v;
                }


                int
                f_1027_42693_42707(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1027, 42693, 42707);
                    return return_v;
                }


                int
                f_1027_43121_43135(System.Collections.ObjectModel.Collection<object>
                this_param, object
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 43121, 43135);
                    return 0;
                }


                System.Collections.Generic.List<object>
                f_1027_43055_43063_I(System.Collections.Generic.List<object>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 43055, 43063);
                    return return_v;
                }


                int
                f_1027_43323_43360(System.Collections.Generic.List<object>
                this_param, int
                index, int
                count)
                {
                    this_param.RemoveRange(index, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 43323, 43360);
                    return 0;
                }


                int
                f_1027_43975_43988(System.Management.Automation.Internal.ObjectStream
                this_param)
                {
                    this_param.RaiseEvents();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 43975, 43988);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 42002, 44088);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 42002, 44088);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override Collection<object> ReadToEnd()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1027, 45121, 45308);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 45269, 45297);

                return f_1027_45276_45296(this, Int32.MaxValue);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1027, 45121, 45308);

                System.Collections.ObjectModel.Collection<object>
                f_1027_45276_45296(System.Management.Automation.Internal.ObjectStream
                this_param, int
                count)
                {
                    var return_v = this_param.Read(count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 45276, 45296);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 45121, 45308);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 45121, 45308);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override Collection<object> NonBlockingRead(int maxRequested)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1027, 46072, 47601);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 46167, 46201);

                Collection<object>
                results = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 46215, 46240);

                bool
                raiseEvents = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 46256, 46358) || true) && (maxRequested == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 46256, 46358);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 46311, 46343);

                    return f_1027_46318_46342();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 46256, 46358);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 46374, 46524) || true) && (maxRequested < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 46374, 46524);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 46428, 46509);

                    throw f_1027_46434_46508("maxRequested", maxRequested);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 46374, 46524);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 46582, 46596);
                    lock (_monitorObject)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 46638, 46669);

                        int
                        readCount = f_1027_46654_46668(_objects)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 46691, 46911) || true) && (readCount > maxRequested)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 46691, 46911);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 46858, 46888);

                            readCount = (int)maxRequested;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 46691, 46911);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 46935, 47338) || true) && (readCount > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 46935, 47338);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 47002, 47037);

                            results = f_1027_47012_47036();
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 47072, 47077);
                                for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 47063, 47207) || true) && (i < readCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 47094, 47097)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 47063, 47207))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 47063, 47207);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 47155, 47180);

                                    f_1027_47155_47179(results, f_1027_47167_47178(_objects, i));
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1027, 1, 145);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1027, 1, 145);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 47235, 47254);

                            raiseEvents = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 47280, 47315);

                            f_1027_47280_47314(_objects, 0, readCount);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 46935, 47338);
                        }
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1027, 47386, 47531);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 47426, 47516) || true) && (raiseEvents)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 47426, 47516);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 47483, 47497);

                        f_1027_47483_47496(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 47426, 47516);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1027, 47386, 47531);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 47547, 47590);

                return results ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.ObjectModel.Collection<object>>(1027, 47554, 47589) ?? f_1027_47565_47589());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1027, 46072, 47601);

                System.Collections.ObjectModel.Collection<object>
                f_1027_46318_46342()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 46318, 46342);
                    return return_v;
                }


                System.Management.Automation.PSArgumentOutOfRangeException
                f_1027_46434_46508(string
                paramName, int
                actualValue)
                {
                    var return_v = PSTraceSource.NewArgumentOutOfRangeException(paramName, (object)actualValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 46434, 46508);
                    return return_v;
                }


                int
                f_1027_46654_46668(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1027, 46654, 46668);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<object>
                f_1027_47012_47036()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 47012, 47036);
                    return return_v;
                }


                object
                f_1027_47167_47178(System.Collections.Generic.List<object>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1027, 47167, 47178);
                    return return_v;
                }


                int
                f_1027_47155_47179(System.Collections.ObjectModel.Collection<object>
                this_param, object
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 47155, 47179);
                    return 0;
                }


                int
                f_1027_47280_47314(System.Collections.Generic.List<object>
                this_param, int
                index, int
                count)
                {
                    this_param.RemoveRange(index, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 47280, 47314);
                    return 0;
                }


                int
                f_1027_47483_47496(System.Management.Automation.Internal.ObjectStream
                this_param)
                {
                    this_param.RaiseEvents();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 47483, 47496);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<object>
                f_1027_47565_47589()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 47565, 47589);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 46072, 47601);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 46072, 47601);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override object Peek()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1027, 47927, 48364);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 47983, 48004);

                object
                result = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 48026, 48040);

                lock (_monitorObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 48074, 48308) || true) && (f_1027_48078_48091() || (DynAbs.Tracing.TraceSender.Expression_False(1027, 48078, 48114) || f_1027_48095_48109(_objects) == 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 48074, 48308);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 48156, 48186);

                        result = f_1027_48165_48185();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 48074, 48308);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 48074, 48308);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 48268, 48289);

                        result = f_1027_48277_48288(_objects, 0);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 48074, 48308);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 48339, 48353);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1027, 47927, 48364);

                bool
                f_1027_48078_48091()
                {
                    var return_v = EndOfPipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1027, 48078, 48091);
                    return return_v;
                }


                int
                f_1027_48095_48109(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1027, 48095, 48109);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1027_48165_48185()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1027, 48165, 48185);
                    return return_v;
                }


                object
                f_1027_48277_48288(System.Collections.Generic.List<object>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1027, 48277, 48288);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 47927, 48364);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 47927, 48364);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override int Write(object obj, bool enumerateCollection)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1027, 49476, 54932);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 49622, 49892) || true) && (obj == f_1027_49633_49653())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 49622, 49892);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 49868, 49877);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 49622, 49892);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 49908, 50197) || true) && (f_1027_49912_49919_M(!IsOpen))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 49908, 50197);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 50032, 50087);

                    string
                    message = f_1027_50049_50086()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 50105, 50156);

                    Exception
                    e = f_1027_50119_50155(message)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 50174, 50182);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 49908, 50197);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 50369, 50405);

                List<object>
                a = f_1027_50386_50404()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 50421, 50451);

                IEnumerable
                enumerable = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 50465, 50588) || true) && (enumerateCollection)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 50465, 50588);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 50522, 50573);

                    enumerable = f_1027_50535_50572(obj);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 50465, 50588);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 50604, 51510) || true) && (enumerable == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 50604, 51510);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 50645, 50656);

                    f_1027_50645_50655(a, obj);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 50604, 51510);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 50604, 51510);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 50707, 51495);
                        foreach (object o in f_1027_50728_50738_I(enumerable))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 50707, 51495);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 51127, 51443) || true) && (f_1027_51131_51151() == o)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 51127, 51443);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 51411, 51420);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 51127, 51443);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 51467, 51476);

                            f_1027_51467_51475(
                                                a, o);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 50707, 51495);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1027, 1, 789);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1027, 1, 789);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 50604, 51510);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 51526, 51549);

                int
                objectsWritten = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 51563, 51592);

                int
                objectsToWrite = f_1027_51584_51591(a)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 51608, 54883) || true) && (objectsToWrite > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 51608, 54883);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 51667, 51692);

                        bool
                        raiseEvents = false
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 51808, 51899) || true) && (f_1027_51812_51823(this) == false)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 51808, 51899);
                            DynAbs.Tracing.TraceSender.TraceBreak(1027, 51874, 51880);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 51808, 51899);
                        }

                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 51969, 51983);
                            lock (_monitorObject)
                            {

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 52033, 52201) || true) && (f_1027_52037_52044_M(!IsOpen))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 52033, 52201);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1027, 52168, 52174);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 52033, 52201);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 52491, 52534);

                                int
                                freeSpace = _capacity - f_1027_52519_52533(_objects)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 52560, 52738) || true) && (0 >= freeSpace)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 52560, 52738);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 52702, 52711);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 52560, 52738);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 52766, 52798);

                                int
                                writeCount = objectsToWrite
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 52824, 53146) || true) && (writeCount > freeSpace)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 52824, 53146);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 53096, 53119);

                                    writeCount = freeSpace;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 52824, 53146);
                                }

                                try
                                {

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 53356, 54476) || true) && (writeCount == f_1027_53374_53381(a))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 53356, 54476);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 53447, 53577);

                                        f_1027_53447_53576(objectsWritten == 0, "objectsWritten == 0");
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 53611, 53632);

                                        f_1027_53611_53631(_objects, a);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 53666, 53695);

                                        objectsWritten += writeCount;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 53729, 53758);

                                        objectsToWrite -= writeCount;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 53792, 53922);

                                        f_1027_53792_53921(objectsToWrite == 0, "objectsToWrite == 0");
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 53356, 54476);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 53356, 54476);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 54052, 54172);

                                        f_1027_54052_54171(writeCount > 0, "writeCount > 0");
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 54206, 54263);

                                        List<object>
                                        a2 = f_1027_54224_54262(a, objectsWritten, writeCount)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 54297, 54319);

                                        f_1027_54297_54318(_objects, a2);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 54353, 54382);

                                        objectsWritten += writeCount;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 54416, 54445);

                                        objectsToWrite -= writeCount;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 53356, 54476);
                                    }
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1027, 54529, 54639);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 54593, 54612);

                                    raiseEvents = true;
                                    DynAbs.Tracing.TraceSender.TraceExitFinally(1027, 54529, 54639);
                                }
                            }
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinally(1027, 54699, 54868);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 54747, 54849) || true) && (raiseEvents)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 54747, 54849);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 54812, 54826);

                                f_1027_54812_54825(this);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 54747, 54849);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitFinally(1027, 54699, 54868);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 51608, 54883);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1027, 51608, 54883);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1027, 51608, 54883);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 54899, 54921);

                return objectsWritten;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1027, 49476, 54932);

                System.Management.Automation.PSObject
                f_1027_49633_49653()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1027, 49633, 49653);
                    return return_v;
                }


                bool
                f_1027_49912_49919_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1027, 49912, 49919);
                    return return_v;
                }


                string
                f_1027_50049_50086()
                {
                    var return_v = PipelineStrings.WriteToClosedPipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1027, 50049, 50086);
                    return return_v;
                }


                System.Management.Automation.PipelineClosedException
                f_1027_50119_50155(string
                message)
                {
                    var return_v = new System.Management.Automation.PipelineClosedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 50119, 50155);
                    return return_v;
                }


                System.Collections.Generic.List<object>
                f_1027_50386_50404()
                {
                    var return_v = new System.Collections.Generic.List<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 50386, 50404);
                    return return_v;
                }


                System.Collections.IEnumerable
                f_1027_50535_50572(object
                obj)
                {
                    var return_v = LanguagePrimitives.GetEnumerable(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 50535, 50572);
                    return return_v;
                }


                int
                f_1027_50645_50655(System.Collections.Generic.List<object>
                this_param, object
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 50645, 50655);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1027_51131_51151()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1027, 51131, 51151);
                    return return_v;
                }


                int
                f_1027_51467_51475(System.Collections.Generic.List<object>
                this_param, object
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 51467, 51475);
                    return 0;
                }


                System.Collections.IEnumerable
                f_1027_50728_50738_I(System.Collections.IEnumerable
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 50728, 50738);
                    return return_v;
                }


                int
                f_1027_51584_51591(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1027, 51584, 51591);
                    return return_v;
                }


                bool
                f_1027_51812_51823(System.Management.Automation.Internal.ObjectStream
                this_param)
                {
                    var return_v = this_param.WaitWrite();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 51812, 51823);
                    return return_v;
                }


                bool
                f_1027_52037_52044_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1027, 52037, 52044);
                    return return_v;
                }


                int
                f_1027_52519_52533(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1027, 52519, 52533);
                    return return_v;
                }


                int
                f_1027_53374_53381(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1027, 53374, 53381);
                    return return_v;
                }


                int
                f_1027_53447_53576(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    System.Management.Automation.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 53447, 53576);
                    return 0;
                }


                int
                f_1027_53611_53631(System.Collections.Generic.List<object>
                this_param, System.Collections.Generic.List<object>
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<object>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 53611, 53631);
                    return 0;
                }


                int
                f_1027_53792_53921(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    System.Management.Automation.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 53792, 53921);
                    return 0;
                }


                int
                f_1027_54052_54171(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    System.Management.Automation.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 54052, 54171);
                    return 0;
                }


                System.Collections.Generic.List<object>
                f_1027_54224_54262(System.Collections.Generic.List<object>
                this_param, int
                index, int
                count)
                {
                    var return_v = this_param.GetRange(index, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 54224, 54262);
                    return return_v;
                }


                int
                f_1027_54297_54318(System.Collections.Generic.List<object>
                this_param, System.Collections.Generic.List<object>
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<object>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 54297, 54318);
                    return 0;
                }


                int
                f_1027_54812_54825(System.Management.Automation.Internal.ObjectStream
                this_param)
                {
                    this_param.RaiseEvents();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 54812, 54825);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 49476, 54932);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 49476, 54932);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void DFT_AddHandler_OnDataReady(EventHandler eventHandler)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1027, 55391, 55519);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 55482, 55508);

                DataReady += eventHandler;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1027, 55391, 55519);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 55391, 55519);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 55391, 55519);
            }
        }

        private void DFT_RemoveHandler_OnDataReady(EventHandler eventHandler)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1027, 55531, 55662);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 55625, 55651);

                DataReady -= eventHandler;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1027, 55531, 55662);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 55531, 55662);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 55531, 55662);
            }
        }

        protected override void Dispose(bool disposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1027, 55916, 57109);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 55988, 56057) || true) && (_disposed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 55988, 56057);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 56035, 56042);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 55988, 56057);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 56079, 56093);

                lock (_monitorObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 56127, 56208) || true) && (_disposed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 56127, 56208);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 56182, 56189);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 56127, 56208);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 56228, 56245);

                    _disposed = true;
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 56276, 57098) || true) && (disposing)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 56276, 57098);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 56323, 56345);

                    f_1027_56323_56344(_readHandle);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 56363, 56386);

                    f_1027_56363_56385(_writeHandle);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 56404, 56433);

                    f_1027_56404_56432(_writeClosedHandle);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 56451, 56479);

                    f_1027_56451_56478(_readClosedHandle);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 56499, 56613) || true) && (_readWaitHandle != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 56499, 56613);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 56568, 56594);

                        f_1027_56568_56593(_readWaitHandle);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 56499, 56613);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 56633, 56749) || true) && (_writeWaitHandle != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 56633, 56749);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 56703, 56730);

                        f_1027_56703_56729(_writeWaitHandle);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 56633, 56749);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 56769, 56916) || true) && (_reader != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 56769, 56916);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 56830, 56846);

                        f_1027_56830_56845(_reader);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 56868, 56897);

                        f_1027_56868_56896(f_1027_56868_56886(_reader));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 56769, 56916);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 56936, 57083) || true) && (_writer != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 56936, 57083);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 56997, 57013);

                        f_1027_56997_57012(_writer);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 57035, 57064);

                        f_1027_57035_57063(f_1027_57035_57053(_writer));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 56936, 57083);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 56276, 57098);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1027, 55916, 57109);

                int
                f_1027_56323_56344(System.Threading.AutoResetEvent
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 56323, 56344);
                    return 0;
                }


                int
                f_1027_56363_56385(System.Threading.AutoResetEvent
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 56363, 56385);
                    return 0;
                }


                int
                f_1027_56404_56432(System.Threading.ManualResetEvent
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 56404, 56432);
                    return 0;
                }


                int
                f_1027_56451_56478(System.Threading.ManualResetEvent
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 56451, 56478);
                    return 0;
                }


                int
                f_1027_56568_56593(System.Threading.ManualResetEvent
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 56568, 56593);
                    return 0;
                }


                int
                f_1027_56703_56729(System.Threading.ManualResetEvent
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 56703, 56729);
                    return 0;
                }


                int
                f_1027_56830_56845(System.Management.Automation.Runspaces.PipelineReader<object>
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 56830, 56845);
                    return 0;
                }


                System.Threading.WaitHandle
                f_1027_56868_56886(System.Management.Automation.Runspaces.PipelineReader<object>
                this_param)
                {
                    var return_v = this_param.WaitHandle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1027, 56868, 56886);
                    return return_v;
                }


                int
                f_1027_56868_56896(System.Threading.WaitHandle
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 56868, 56896);
                    return 0;
                }


                int
                f_1027_56997_57012(System.Management.Automation.Runspaces.PipelineWriter
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 56997, 57012);
                    return 0;
                }


                System.Threading.WaitHandle
                f_1027_57035_57053(System.Management.Automation.Runspaces.PipelineWriter
                this_param)
                {
                    var return_v = this_param.WaitHandle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1027, 57035, 57053);
                    return return_v;
                }


                int
                f_1027_57035_57063(System.Threading.WaitHandle
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 57035, 57063);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 55916, 57109);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 55916, 57109);
            }
        }

        static ObjectStream()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1027, 15678, 57150);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1027, 15678, 57150);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 15678, 57150);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1027, 15678, 57150);

        object
        f_1027_20175_20187()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 20175, 20187);
            return return_v;
        }


        static int
        f_1027_20654_20668_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1027, 20610, 20691);
            return return_v;
        }


        System.Management.Automation.PSArgumentOutOfRangeException
        f_1027_21454_21520(string
        paramName, int
        actualValue)
        {
            var return_v = PSTraceSource.NewArgumentOutOfRangeException(paramName, (object)actualValue);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 21454, 21520);
            return return_v;
        }


        System.Threading.AutoResetEvent
        f_1027_21758_21783(bool
        initialState)
        {
            var return_v = new System.Threading.AutoResetEvent(initialState);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 21758, 21783);
            return return_v;
        }


        System.Threading.AutoResetEvent
        f_1027_21887_21911(bool
        initialState)
        {
            var return_v = new System.Threading.AutoResetEvent(initialState);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 21887, 21911);
            return return_v;
        }


        System.Threading.ManualResetEvent
        f_1027_22021_22048(bool
        initialState)
        {
            var return_v = new System.Threading.ManualResetEvent(initialState);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 22021, 22048);
            return return_v;
        }


        System.Threading.ManualResetEvent
        f_1027_22156_22183(bool
        initialState)
        {
            var return_v = new System.Threading.ManualResetEvent(initialState);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 22156, 22183);
            return return_v;
        }


        System.Collections.Generic.List<object>
        f_1027_22265_22283()
        {
            var return_v = new System.Collections.Generic.List<object>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 22265, 22283);
            return return_v;
        }

    }
    internal sealed class PSDataCollectionStream<T> : ObjectStreamBase
    {
        private PSDataCollection<T> _objects;

        private Guid _psInstanceId;

        private bool _isOpen;

        private PipelineWriter _writer;

        private PipelineReader<object> _objectReader;

        private PipelineReader<PSObject> _psobjectReader;

        private PipelineReader<object> _objectReaderForPipeline;

        private PipelineReader<PSObject> _psobjectReaderForPipeline;

        private object _syncObject;

        private bool _disposed;

        internal PSDataCollectionStream(Guid psInstanceId, PSDataCollection<T> storeToUse)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1027, 58717, 59329);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 57681, 57689);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 57750, 57757);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 57791, 57798);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 57840, 57853);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 57897, 57912);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 57954, 57978);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 58022, 58048);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 58074, 58100);
                this._syncObject = f_1027_58088_58100();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 58124, 58141);
                this._disposed = false;
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 58824, 58954) || true) && (storeToUse == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 58824, 58954);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 58880, 58939);

                    throw f_1027_58886_58938("storeToUse");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 58824, 58954);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 58970, 58992);

                _objects = storeToUse;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 59006, 59035);

                _psInstanceId = psInstanceId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 59049, 59064);

                _isOpen = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 59191, 59211);

                f_1027_59191_59210(            // increment ref count for the store. PowerShell engine
                                               // is about to use this store.
                            storeToUse);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 59227, 59267);

                storeToUse.DataAdded += HandleDataAdded;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 59281, 59318);

                storeToUse.Completed += HandleClosed;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1027, 58717, 59329);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 58717, 59329);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 58717, 59329);
            }
        }

        internal PSDataCollection<T> ObjectStore
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1027, 59580, 59647);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 59616, 59632);

                    return _objects;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1027, 59580, 59647);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 59515, 59658);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 59515, 59658);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override int Count
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1027, 59891, 59964);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 59927, 59949);

                    return f_1027_59934_59948(_objects);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1027, 59891, 59964);

                    int
                    f_1027_59934_59948(System.Management.Automation.PSDataCollection<T>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1027, 59934, 59948);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 59839, 59975);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 59839, 59975);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool EndOfPipeline
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1027, 60131, 60391);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 60167, 60191);

                    bool
                    endOfStream = true
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 60217, 60228);

                    lock (_syncObject)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 60270, 60318);

                        endOfStream = (f_1027_60285_60299(_objects) == 0 && (DynAbs.Tracing.TraceSender.Expression_True(1027, 60285, 60316) && !_isOpen));
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 60357, 60376);

                    return endOfStream;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1027, 60131, 60391);

                    int
                    f_1027_60285_60299(System.Management.Automation.PSDataCollection<T>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1027, 60285, 60299);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 60070, 60402);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 60070, 60402);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsOpen
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1027, 60851, 61008);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 60959, 60993);

                    return _isOpen && (DynAbs.Tracing.TraceSender.Expression_True(1027, 60966, 60992) && f_1027_60977_60992(_objects));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1027, 60851, 61008);

                    bool
                    f_1027_60977_60992(System.Management.Automation.PSDataCollection<T>
                    this_param)
                    {
                        var return_v = this_param.IsOpen;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1027, 60977, 60992);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 60797, 61019);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 60797, 61019);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override int MaxCapacity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1027, 61172, 61332);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 61239, 61286);

                    throw f_1027_61245_61285();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1027, 61172, 61332);

                    System.Management.Automation.PSNotSupportedException
                    f_1027_61245_61285()
                    {
                        var return_v = PSTraceSource.NewNotSupportedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 61245, 61285);
                        return return_v;
                    }

#pragma warning restore 56503
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 61114, 61343);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 61114, 61343);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override PipelineReader<object> ObjectReader
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1027, 61542, 61980);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 61578, 61924) || true) && (_objectReader == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 61578, 61924);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 61651, 61662);
                        lock (_syncObject)
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 61712, 61882) || true) && (_objectReader == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 61712, 61882);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 61795, 61855);

                                _objectReader = f_1027_61811_61854(this);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 61712, 61882);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 61578, 61924);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 61944, 61965);

                    return _objectReader;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1027, 61542, 61980);

                    System.Management.Automation.Internal.PSDataCollectionReader<T, object>
                    f_1027_61811_61854(System.Management.Automation.Internal.PSDataCollectionStream<T>
                    stream)
                    {
                        var return_v = new System.Management.Automation.Internal.PSDataCollectionReader<T, object>(stream);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 61811, 61854);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 61464, 61991);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 61464, 61991);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal PipelineReader<object> GetObjectReaderForPipeline(string computerName, Guid runspaceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1027, 62523, 63109);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 62644, 63050) || true) && (_objectReaderForPipeline == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 62644, 63050);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 62720, 62731);
                    lock (_syncObject)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 62773, 63016) || true) && (_objectReaderForPipeline == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 62773, 63016);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 62859, 62993);

                            _objectReaderForPipeline =
                            f_1027_62915_62992(this, computerName, runspaceId);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 62773, 63016);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 62644, 63050);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 63066, 63098);

                return _objectReaderForPipeline;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1027, 62523, 63109);

                System.Management.Automation.Internal.PSDataCollectionPipelineReader<T, object>
                f_1027_62915_62992(System.Management.Automation.Internal.PSDataCollectionStream<T>
                stream, string
                computerName, System.Guid
                runspaceId)
                {
                    var return_v = new System.Management.Automation.Internal.PSDataCollectionPipelineReader<T, object>(stream, computerName, runspaceId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 62915, 62992);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 62523, 63109);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 62523, 63109);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override PipelineReader<PSObject> PSObjectReader
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1027, 63314, 63762);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 63350, 63704) || true) && (_psobjectReader == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 63350, 63704);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 63425, 63436);
                        lock (_syncObject)
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 63486, 63662) || true) && (_psobjectReader == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 63486, 63662);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 63571, 63635);

                                _psobjectReader = f_1027_63589_63634(this);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 63486, 63662);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 63350, 63704);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 63724, 63747);

                    return _psobjectReader;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1027, 63314, 63762);

                    System.Management.Automation.Internal.PSDataCollectionReader<T, System.Management.Automation.PSObject>
                    f_1027_63589_63634(System.Management.Automation.Internal.PSDataCollectionStream<T>
                    stream)
                    {
                        var return_v = new System.Management.Automation.Internal.PSDataCollectionReader<T, System.Management.Automation.PSObject>(stream);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 63589, 63634);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 63232, 63773);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 63232, 63773);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal PipelineReader<PSObject> GetPSObjectReaderForPipeline(string computerName, Guid runspaceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1027, 64307, 64907);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 64432, 64846) || true) && (_psobjectReaderForPipeline == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 64432, 64846);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 64510, 64521);
                    lock (_syncObject)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 64563, 64812) || true) && (_psobjectReaderForPipeline == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 64563, 64812);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 64651, 64789);

                            _psobjectReaderForPipeline =
                            f_1027_64709_64788(this, computerName, runspaceId);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 64563, 64812);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 64432, 64846);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 64862, 64896);

                return _psobjectReaderForPipeline;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1027, 64307, 64907);

                System.Management.Automation.Internal.PSDataCollectionPipelineReader<T, System.Management.Automation.PSObject>
                f_1027_64709_64788(System.Management.Automation.Internal.PSDataCollectionStream<T>
                stream, string
                computerName, System.Guid
                runspaceId)
                {
                    var return_v = new System.Management.Automation.Internal.PSDataCollectionPipelineReader<T, System.Management.Automation.PSObject>(stream, computerName, runspaceId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 64709, 64788);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 64307, 64907);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 64307, 64907);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override PipelineWriter ObjectWriter
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1027, 65231, 65655);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 65267, 65605) || true) && (_writer == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 65267, 65605);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 65334, 65345);
                        lock (_syncObject)
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 65395, 65563) || true) && (_writer == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 65395, 65563);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 65472, 65536);

                                _writer = f_1027_65482_65517(this) as PipelineWriter;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 65395, 65563);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 65267, 65605);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 65625, 65640);

                    return _writer;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1027, 65231, 65655);

                    System.Management.Automation.Internal.PSDataCollectionWriter<T>
                    f_1027_65482_65517(System.Management.Automation.Internal.PSDataCollectionStream<T>
                    stream)
                    {
                        var return_v = new System.Management.Automation.Internal.PSDataCollectionWriter<T>(stream);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 65482, 65517);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 65161, 65666);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 65161, 65666);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override WaitHandle ReadHandle
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1027, 65843, 65921);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 65879, 65906);

                    return f_1027_65886_65905(_objects);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1027, 65843, 65921);

                    System.Threading.WaitHandle
                    f_1027_65886_65905(System.Management.Automation.PSDataCollection<T>
                    this_param)
                    {
                        var return_v = this_param.WaitHandle;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1027, 65886, 65905);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 65779, 65932);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 65779, 65932);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override int Write(object obj, bool enumerateCollection)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1027, 66228, 68449);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 66374, 66565) || true) && (obj == f_1027_66385_66405())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 66374, 66565);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 66541, 66550);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 66374, 66565);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 66581, 66872) || true) && (f_1027_66585_66592_M(!IsOpen))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 66581, 66872);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 66705, 66762);

                    string
                    message = f_1027_66722_66761()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 66780, 66831);

                    Exception
                    e = f_1027_66794_66830(message)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 66849, 66857);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 66581, 66872);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 67044, 67093);

                Collection<T>
                objectsToAdd = f_1027_67073_67092()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 67109, 67139);

                IEnumerable
                enumerable = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 67153, 67276) || true) && (enumerateCollection)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 67153, 67276);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 67210, 67261);

                    enumerable = f_1027_67223_67260(obj);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 67153, 67276);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 67292, 68325) || true) && (enumerable == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 67292, 68325);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 67348, 67479);

                    f_1027_67348_67478(objectsToAdd, f_1027_67368_67477(obj, typeof(T), f_1027_67434_67476()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 67292, 68325);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 67292, 68325);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 67545, 68310);
                        foreach (object o in f_1027_67566_67576_I(enumerable))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 67545, 68310);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 67903, 68132) || true) && (f_1027_67907_67927() == o)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 67903, 68132);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 68100, 68109);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 67903, 68132);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 68156, 68291);

                            f_1027_68156_68290(
                                                objectsToAdd, f_1027_68176_68289(obj, typeof(T), f_1027_68246_68288()));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 67545, 68310);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1027, 1, 766);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1027, 1, 766);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 67292, 68325);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 68341, 68396);

                f_1027_68341_68395(
                            _objects, _psInstanceId, objectsToAdd);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 68412, 68438);

                return f_1027_68419_68437(objectsToAdd);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1027, 66228, 68449);

                System.Management.Automation.PSObject
                f_1027_66385_66405()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1027, 66385, 66405);
                    return return_v;
                }


                bool
                f_1027_66585_66592_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1027, 66585, 66592);
                    return return_v;
                }


                string
                f_1027_66722_66761()
                {
                    var return_v = PSDataBufferStrings.WriteToClosedBuffer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1027, 66722, 66761);
                    return return_v;
                }


                System.Management.Automation.PipelineClosedException
                f_1027_66794_66830(string
                message)
                {
                    var return_v = new System.Management.Automation.PipelineClosedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 66794, 66830);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<T>
                f_1027_67073_67092()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 67073, 67092);
                    return return_v;
                }


                System.Collections.IEnumerable
                f_1027_67223_67260(object
                obj)
                {
                    var return_v = LanguagePrimitives.GetEnumerable(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 67223, 67260);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1027_67434_67476()
                {
                    var return_v = Globalization.CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1027, 67434, 67476);
                    return return_v;
                }


                object
                f_1027_67368_67477(object
                valueToConvert, System.Type
                resultType, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = LanguagePrimitives.ConvertTo(valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 67368, 67477);
                    return return_v;
                }


                int
                f_1027_67348_67478(System.Collections.ObjectModel.Collection<T>
                this_param, object
                item)
                {
                    this_param.Add((T)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 67348, 67478);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1027_67907_67927()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1027, 67907, 67927);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1027_68246_68288()
                {
                    var return_v = Globalization.CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1027, 68246, 68288);
                    return return_v;
                }


                object
                f_1027_68176_68289(object
                valueToConvert, System.Type
                resultType, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = LanguagePrimitives.ConvertTo(valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 68176, 68289);
                    return return_v;
                }


                int
                f_1027_68156_68290(System.Collections.ObjectModel.Collection<T>
                this_param, object
                item)
                {
                    this_param.Add((T)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 68156, 68290);
                    return 0;
                }


                System.Collections.IEnumerable
                f_1027_67566_67576_I(System.Collections.IEnumerable
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 67566, 67576);
                    return return_v;
                }


                int
                f_1027_68341_68395(System.Management.Automation.PSDataCollection<T>
                this_param, System.Guid
                psInstanceId, System.Collections.ObjectModel.Collection<T>
                collection)
                {
                    this_param.InternalAddRange(psInstanceId, (System.Collections.ICollection)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 68341, 68395);
                    return 0;
                }


                int
                f_1027_68419_68437(System.Collections.ObjectModel.Collection<T>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1027, 68419, 68437);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 66228, 68449);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 66228, 68449);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void Close()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1027, 68822, 69784);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 68877, 68902);

                bool
                raiseEvents = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 68922, 68933);
                lock (_syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 69188, 69636) || true) && (_isOpen)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 69188, 69636);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 69395, 69419);

                        f_1027_69395_69418(                    // Decrement ref count (and other event handlers) for the store.
                                                               // PowerShell engine is done using this store.
                                            _objects);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 69441, 69479);

                        _objects.DataAdded -= HandleDataAdded;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 69501, 69536);

                        _objects.Completed -= HandleClosed;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 69560, 69579);

                        raiseEvents = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 69601, 69617);

                        _isOpen = false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 69188, 69636);
                    }
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 69667, 69773) || true) && (raiseEvents)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 69667, 69773);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 69716, 69758);

                    f_1027_69716_69757(this, this, EventArgs.Empty);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 69667, 69773);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1027, 68822, 69784);

                int
                f_1027_69395_69418(System.Management.Automation.PSDataCollection<T>
                this_param)
                {
                    this_param.DecrementRef();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 69395, 69418);
                    return 0;
                }


                int
                f_1027_69716_69757(System.Management.Automation.Internal.PSDataCollectionStream<T>
                this_param, System.Management.Automation.Internal.PSDataCollectionStream<T>
                source, System.EventArgs
                args)
                {
                    this_param.FireDataReadyEvent((object)source, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 69716, 69757);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 68822, 69784);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 68822, 69784);
            }
        }

        private void HandleClosed(object sender, EventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1027, 69980, 70077);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 70058, 70066);

                f_1027_70058_70065(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1027, 69980, 70077);

                int
                f_1027_70058_70065(System.Management.Automation.Internal.PSDataCollectionStream<T>
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 70058, 70065);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 69980, 70077);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 69980, 70077);
            }
        }

        private void HandleDataAdded(object sender, DataAddedEventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1027, 70217, 70360);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 70307, 70349);

                f_1027_70307_70348(this, this, EventArgs.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1027, 70217, 70360);

                int
                f_1027_70307_70348(System.Management.Automation.Internal.PSDataCollectionStream<T>
                this_param, System.Management.Automation.Internal.PSDataCollectionStream<T>
                source, System.EventArgs
                args)
                {
                    this_param.FireDataReadyEvent((object)source, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 70307, 70348);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 70217, 70360);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 70217, 70360);
            }
        }

        protected override void Dispose(bool disposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1027, 70600, 71477);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 70672, 70741) || true) && (_disposed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 70672, 70741);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 70719, 70726);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 70672, 70741);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 70763, 70774);

                lock (_syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 70808, 70889) || true) && (_disposed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 70808, 70889);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 70863, 70870);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 70808, 70889);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 70909, 70926);

                    _disposed = true;
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 70957, 71466) || true) && (disposing)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 70957, 71466);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 71004, 71023);

                    f_1027_71004_71022(_objects);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 71043, 71051);

                    f_1027_71043_71050(this);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 71071, 71248) || true) && (_objectReaderForPipeline != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 71071, 71248);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 71149, 71229);

                        f_1027_71149_71228(((PSDataCollectionPipelineReader<T, object>)_objectReaderForPipeline));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 71071, 71248);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 71268, 71451) || true) && (_psobjectReaderForPipeline != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1027, 71268, 71451);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1027, 71348, 71432);

                        f_1027_71348_71431(((PSDataCollectionPipelineReader<T, PSObject>)_psobjectReaderForPipeline));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 71268, 71451);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1027, 70957, 71466);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1027, 70600, 71477);

                int
                f_1027_71004_71022(System.Management.Automation.PSDataCollection<T>
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 71004, 71022);
                    return 0;
                }


                int
                f_1027_71043_71050(System.Management.Automation.Internal.PSDataCollectionStream<T>
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 71043, 71050);
                    return 0;
                }


                int
                f_1027_71149_71228(System.Management.Automation.Internal.PSDataCollectionPipelineReader<T, object>
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 71149, 71228);
                    return 0;
                }


                int
                f_1027_71348_71431(System.Management.Automation.Internal.PSDataCollectionPipelineReader<T, System.Management.Automation.PSObject>
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 71348, 71431);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1027, 70600, 71477);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 70600, 71477);
            }
        }

        static PSDataCollectionStream()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1027, 57536, 71516);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1027, 57536, 71516);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1027, 57536, 71516);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1027, 57536, 71516);

        object
        f_1027_58088_58100()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 58088, 58100);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1027_58886_58938(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 58886, 58938);
            return return_v;
        }


        int
        f_1027_59191_59210(System.Management.Automation.PSDataCollection<T>
        this_param)
        {
            this_param.AddRef();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1027, 59191, 59210);
            return 0;
        }

    }
}

