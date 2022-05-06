// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace System.Management.Automation.Internal
{
    using System;
    using System.Threading;
    using System.Runtime.InteropServices;
    using System.Management.Automation.Runspaces;
    internal class ObjectWriter : PipelineWriter
    {
        public ObjectWriter([In, Out] ObjectStreamBase stream)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1028, 816, 1141);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1028, 6847, 6854);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1028, 895, 1004) || true) && (stream == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1028, 895, 1004);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1028, 947, 989);

                    throw f_1028_953_988("stream");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1028, 895, 1004);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1028, 1020, 1037);

                _stream = stream;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1028, 816, 1141);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1028, 816, 1141);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1028, 816, 1141);
            }
        }

        public override WaitHandle WaitHandle
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1028, 1401, 1479);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1028, 1437, 1464);

                    return f_1028_1444_1463(_stream);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1028, 1401, 1479);

                    System.Threading.WaitHandle
                    f_1028_1444_1463(System.Management.Automation.Internal.ObjectStreamBase
                    this_param)
                    {
                        var return_v = this_param.WriteHandle;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1028, 1444, 1463);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1028, 1339, 1490);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1028, 1339, 1490);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1028, 1932, 2005);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1028, 1968, 1990);

                    return f_1028_1975_1989(_stream);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1028, 1932, 2005);

                    bool
                    f_1028_1975_1989(System.Management.Automation.Internal.ObjectStreamBase
                    this_param)
                    {
                        var return_v = this_param.IsOpen;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1028, 1975, 1989);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1028, 1880, 2016);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1028, 1880, 2016);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1028, 2194, 2266);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1028, 2230, 2251);

                    return f_1028_2237_2250(_stream);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1028, 2194, 2266);

                    int
                    f_1028_2237_2250(System.Management.Automation.Internal.ObjectStreamBase
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1028, 2237, 2250);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1028, 2144, 2277);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1028, 2144, 2277);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1028, 2789, 2867);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1028, 2825, 2852);

                    return f_1028_2832_2851(_stream);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1028, 2789, 2867);

                    int
                    f_1028_2832_2851(System.Management.Automation.Internal.ObjectStreamBase
                    this_param)
                    {
                        var return_v = this_param.MaxCapacity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1028, 2832, 2851);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1028, 2733, 2878);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1028, 2733, 2878);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override void Close()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1028, 3422, 3629);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1028, 3475, 3491);

                f_1028_3475_3490(_stream);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1028, 3422, 3629);

                int
                f_1028_3475_3490(System.Management.Automation.Internal.ObjectStreamBase
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1028, 3475, 3490);
                    return 0;
                }

                // 2003/09/02-JonN I removed setting _stream
                // to null, now all of the tests for null can come out.
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1028, 3422, 3629);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1028, 3422, 3629);
            }
        }

        public override void Flush()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1028, 3937, 4017);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1028, 3990, 4006);

                f_1028_3990_4005(_stream);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1028, 3937, 4017);

                int
                f_1028_3990_4005(System.Management.Automation.Internal.ObjectStreamBase
                this_param)
                {
                    this_param.Flush();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1028, 3990, 4005);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1028, 3937, 4017);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1028, 3937, 4017);
            }
        }

        public override int Write(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1028, 4670, 4769);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1028, 4732, 4758);

                return f_1028_4739_4757(_stream, obj);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1028, 4670, 4769);

                int
                f_1028_4739_4757(System.Management.Automation.Internal.ObjectStreamBase
                this_param, object
                value)
                {
                    var return_v = this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1028, 4739, 4757);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1028, 4670, 4769);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1028, 4670, 4769);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int Write(object obj, bool enumerateCollection)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1028, 5813, 5959);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1028, 5901, 5948);

                return f_1028_5908_5947(_stream, obj, enumerateCollection);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1028, 5813, 5959);

                int
                f_1028_5908_5947(System.Management.Automation.Internal.ObjectStreamBase
                this_param, object
                obj, bool
                enumerateCollection)
                {
                    var return_v = this_param.Write(obj, enumerateCollection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1028, 5908, 5947);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1028, 5813, 5959);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1028, 5813, 5959);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ObjectStreamBase _stream;

        static ObjectWriter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1028, 486, 6899);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1028, 486, 6899);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1028, 486, 6899);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1028, 486, 6899);

        System.ArgumentNullException
        f_1028_953_988(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1028, 953, 988);
            return return_v;
        }

    }
    internal class PSDataCollectionWriter<T> : ObjectWriter
    {
        public PSDataCollectionWriter(PSDataCollectionStream<T> stream)
        : base(f_1028_7764_7770_C(stream))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1028, 7680, 7793);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1028, 7680, 7793);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1028, 7680, 7793);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1028, 7680, 7793);
            }
        }

        static PSDataCollectionWriter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1028, 7270, 7822);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1028, 7270, 7822);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1028, 7270, 7822);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1028, 7270, 7822);

        static System.Management.Automation.Internal.ObjectStreamBase
        f_1028_7764_7770_C(System.Management.Automation.Internal.ObjectStreamBase
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1028, 7680, 7793);
            return return_v;
        }

    }
}

