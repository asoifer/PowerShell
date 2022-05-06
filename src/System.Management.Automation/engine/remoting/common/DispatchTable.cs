// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Threading;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation.Remoting
{
    internal class ServerDispatchTable : DispatchTable<RemoteHostResponse>
    {
        public ServerDispatchTable()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1617, 354, 500);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1617, 354, 500);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1617, 354, 500);
        }


        static ServerDispatchTable()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1617, 354, 500);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1617, 354, 500);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1617, 354, 500);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1617, 354, 500);
    }
    internal class DispatchTable<T> where T : class
    {
        private Dictionary<long, AsyncObject<T>> _responseAsyncObjects;

        private long _nextCallId;

        internal const long
        VoidCallId = -100
        ;

        internal long CreateNewCallId()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1617, 1830, 2257);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1617, 1949, 2002);

                long
                callId = f_1617_1963_2001(ref _nextCallId)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1617, 2016, 2074);

                AsyncObject<T>
                responseAsyncObject = f_1617_2053_2073()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1617, 2094, 2115);
                lock (_responseAsyncObjects)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1617, 2149, 2201);

                    _responseAsyncObjects[callId] = responseAsyncObject;
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1617, 2232, 2246);

                return callId;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1617, 1830, 2257);

                long
                f_1617_1963_2001(ref long
                location)
                {
                    var return_v = Interlocked.Increment(ref location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1617, 1963, 2001);
                    return return_v;
                }


                System.Management.Automation.Remoting.AsyncObject<T>
                f_1617_2053_2073()
                {
                    var return_v = new System.Management.Automation.Remoting.AsyncObject<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1617, 2053, 2073);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1617, 1830, 2257);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1617, 1830, 2257);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private AsyncObject<T> GetResponseAsyncObject(long callId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1617, 2356, 2815);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1617, 2439, 2481);

                AsyncObject<T>
                responseAsyncObject = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1617, 2495, 2603);

                f_1617_2495_2602(f_1617_2506_2547(_responseAsyncObjects, callId), "Expected _responseAsyncObjects.ContainsKey(callId)");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1617, 2617, 2669);

                responseAsyncObject = f_1617_2639_2668(_responseAsyncObjects, callId);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1617, 2683, 2763);

                f_1617_2683_2762(responseAsyncObject != null, "Expected responseAsyncObject != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1617, 2777, 2804);

                return responseAsyncObject;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1617, 2356, 2815);

                bool
                f_1617_2506_2547(System.Collections.Generic.Dictionary<long, System.Management.Automation.Remoting.AsyncObject<T>>
                this_param, long
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1617, 2506, 2547);
                    return return_v;
                }


                int
                f_1617_2495_2602(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1617, 2495, 2602);
                    return 0;
                }


                System.Management.Automation.Remoting.AsyncObject<T>
                f_1617_2639_2668(System.Collections.Generic.Dictionary<long, System.Management.Automation.Remoting.AsyncObject<T>>
                this_param, long
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1617, 2639, 2668);
                    return return_v;
                }


                int
                f_1617_2683_2762(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1617, 2683, 2762);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1617, 2356, 2815);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1617, 2356, 2815);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal T GetResponse(long callId, T defaultValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1617, 3195, 4154);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1617, 3329, 3371);

                AsyncObject<T>
                responseAsyncObject = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1617, 3391, 3412);
                lock (_responseAsyncObjects)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1617, 3446, 3499);

                    responseAsyncObject = f_1617_3468_3498(this, callId);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1617, 3602, 3651);

                T
                remoteHostResponse = f_1617_3625_3650(responseAsyncObject)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1617, 3771, 3792);

                // Remove table entry to conserve memory: this table could be alive for a long time.
                lock (_responseAsyncObjects)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1617, 3826, 3863);

                    f_1617_3826_3862(_responseAsyncObjects, callId);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1617, 4002, 4101) || true) && (remoteHostResponse == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1617, 4002, 4101);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1617, 4066, 4086);

                    return defaultValue;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1617, 4002, 4101);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1617, 4117, 4143);

                return remoteHostResponse;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1617, 3195, 4154);

                System.Management.Automation.Remoting.AsyncObject<T>
                f_1617_3468_3498(System.Management.Automation.Remoting.DispatchTable<T>
                this_param, long
                callId)
                {
                    var return_v = this_param.GetResponseAsyncObject(callId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1617, 3468, 3498);
                    return return_v;
                }


                T
                f_1617_3625_3650(System.Management.Automation.Remoting.AsyncObject<T>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1617, 3625, 3650);
                    return return_v;
                }


                bool
                f_1617_3826_3862(System.Collections.Generic.Dictionary<long, System.Management.Automation.Remoting.AsyncObject<T>>
                this_param, long
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1617, 3826, 3862);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1617, 3195, 4154);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1617, 3195, 4154);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void SetResponse(long callId, T remoteHostResponse)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1617, 4240, 5020);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1617, 4325, 4403);

                f_1617_4325_4402(remoteHostResponse != null, "Expected remoteHostResponse != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1617, 4423, 4444);
                lock (_responseAsyncObjects)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1617, 4661, 4775) || true) && (!f_1617_4666_4707(_responseAsyncObjects, callId))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1617, 4661, 4775);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1617, 4749, 4756);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1617, 4661, 4775);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1617, 4861, 4929);

                    AsyncObject<T>
                    responseAsyncObject = f_1617_4898_4928(this, callId)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1617, 4947, 4994);

                    responseAsyncObject.Value = remoteHostResponse;
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1617, 4240, 5020);

                int
                f_1617_4325_4402(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1617, 4325, 4402);
                    return 0;
                }


                bool
                f_1617_4666_4707(System.Collections.Generic.Dictionary<long, System.Management.Automation.Remoting.AsyncObject<T>>
                this_param, long
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1617, 4666, 4707);
                    return return_v;
                }


                System.Management.Automation.Remoting.AsyncObject<T>
                f_1617_4898_4928(System.Management.Automation.Remoting.DispatchTable<T>
                this_param, long
                callId)
                {
                    var return_v = this_param.GetResponseAsyncObject(callId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1617, 4898, 4928);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1617, 4240, 5020);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1617, 4240, 5020);
            }
        }

        private void AbortCall(long callId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1617, 5104, 5623);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1617, 5255, 5357) || true) && (!f_1617_5260_5301(_responseAsyncObjects, callId))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1617, 5255, 5357);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1617, 5335, 5342);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1617, 5255, 5357);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1617, 5497, 5565);

                AsyncObject<T>
                responseAsyncObject = f_1617_5534_5564(this, callId)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1617, 5579, 5612);

                responseAsyncObject.Value = null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1617, 5104, 5623);

                bool
                f_1617_5260_5301(System.Collections.Generic.Dictionary<long, System.Management.Automation.Remoting.AsyncObject<T>>
                this_param, long
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1617, 5260, 5301);
                    return return_v;
                }


                System.Management.Automation.Remoting.AsyncObject<T>
                f_1617_5534_5564(System.Management.Automation.Remoting.DispatchTable<T>
                this_param, long
                callId)
                {
                    var return_v = this_param.GetResponseAsyncObject(callId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1617, 5534, 5564);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1617, 5104, 5623);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1617, 5104, 5623);
            }
        }

        private void AbortCalls(List<long> callIds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1617, 5708, 6009);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1617, 5900, 5998);
                    foreach (long callId in f_1617_5924_5931_I(callIds))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1617, 5900, 5998);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1617, 5965, 5983);

                        f_1617_5965_5982(this, callId);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1617, 5900, 5998);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1617, 1, 99);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1617, 1, 99);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1617, 5708, 6009);

                int
                f_1617_5965_5982(System.Management.Automation.Remoting.DispatchTable<T>
                this_param, long
                callId)
                {
                    this_param.AbortCall(callId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1617, 5965, 5982);
                    return 0;
                }


                System.Collections.Generic.List<long>
                f_1617_5924_5931_I(System.Collections.Generic.List<long>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1617, 5924, 5931);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1617, 5708, 6009);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1617, 5708, 6009);
            }
        }

        private List<long> GetAllCalls()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1617, 6096, 6505);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1617, 6217, 6255);

                List<long>
                callIds = f_1617_6238_6254()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1617, 6269, 6463);
                    foreach (KeyValuePair<long, AsyncObject<T>> callIdResponseAsyncObjectPair in f_1617_6346_6367_I(_responseAsyncObjects))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1617, 6269, 6463);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1617, 6401, 6448);

                        f_1617_6401_6447(callIds, callIdResponseAsyncObjectPair.Key);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1617, 6269, 6463);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1617, 1, 195);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1617, 1, 195);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1617, 6479, 6494);

                return callIds;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1617, 6096, 6505);

                System.Collections.Generic.List<long>
                f_1617_6238_6254()
                {
                    var return_v = new System.Collections.Generic.List<long>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1617, 6238, 6254);
                    return return_v;
                }


                int
                f_1617_6401_6447(System.Collections.Generic.List<long>
                this_param, long
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1617, 6401, 6447);
                    return 0;
                }


                System.Collections.Generic.Dictionary<long, System.Management.Automation.Remoting.AsyncObject<T>>
                f_1617_6346_6367_I(System.Collections.Generic.Dictionary<long, System.Management.Automation.Remoting.AsyncObject<T>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1617, 6346, 6367);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1617, 6096, 6505);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1617, 6096, 6505);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void AbortAllCalls()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1617, 6594, 6808);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1617, 6654, 6675);
                lock (_responseAsyncObjects)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1617, 6709, 6744);

                    List<long>
                    callIds = f_1617_6730_6743(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1617, 6762, 6782);

                    f_1617_6762_6781(this, callIds);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1617, 6594, 6808);

                System.Collections.Generic.List<long>
                f_1617_6730_6743(System.Management.Automation.Remoting.DispatchTable<T>
                this_param)
                {
                    var return_v = this_param.GetAllCalls();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1617, 6730, 6743);
                    return return_v;
                }


                int
                f_1617_6762_6781(System.Management.Automation.Remoting.DispatchTable<T>
                this_param, System.Collections.Generic.List<long>
                callIds)
                {
                    this_param.AbortCalls(callIds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1617, 6762, 6781);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1617, 6594, 6808);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1617, 6594, 6808);
            }
        }

        public DispatchTable()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1617, 1247, 6815);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1617, 1436, 1498);
            this._responseAsyncObjects = f_1617_1460_1498();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1617, 1598, 1613);
            this._nextCallId = 0;
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1617, 1247, 6815);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1617, 1247, 6815);
        }


        static DispatchTable()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1617, 1247, 6815);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1617, 1720, 1737);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1617, 1247, 6815);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1617, 1247, 6815);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1617, 1247, 6815);

        System.Collections.Generic.Dictionary<long, System.Management.Automation.Remoting.AsyncObject<T>>
        f_1617_1460_1498()
        {
            var return_v = new System.Collections.Generic.Dictionary<long, System.Management.Automation.Remoting.AsyncObject<T>>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1617, 1460, 1498);
            return return_v;
        }

    }
}
