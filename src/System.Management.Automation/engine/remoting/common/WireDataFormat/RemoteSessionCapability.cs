// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.IO;
using System.Management.Automation.Host;
using System.Management.Automation.Internal.Host;
using System.Runtime.Serialization.Formatters.Binary;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation.Remoting
{
    internal class RemoteSessionCapability
    {
        private Version _psversion;

        private Version _serversion;

        private Version _protocolVersion;

        private RemotingDestination _remotingDestination;

        private static byte[] _timeZoneInByteFormat;

        private TimeZoneInfo _timeZone;

        internal Version ProtocolVersion
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1672, 1346, 1421);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 1382, 1406);

                    return _protocolVersion;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1672, 1346, 1421);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1672, 1289, 1524);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1672, 1289, 1524);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1672, 1437, 1513);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 1473, 1498);

                    _protocolVersion = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1672, 1437, 1513);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1672, 1289, 1524);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1672, 1289, 1524);
                }
            }
        }

        internal Version PSVersion
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1672, 1565, 1591);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 1571, 1589);

                    return _psversion;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1672, 1565, 1591);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1672, 1536, 1593);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1672, 1536, 1593);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Version SerializationVersion
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1672, 1645, 1672);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 1651, 1670);

                    return _serversion;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1672, 1645, 1672);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1672, 1605, 1674);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1672, 1605, 1674);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal RemotingDestination RemotingDestination
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1672, 1737, 1773);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 1743, 1771);

                    return _remotingDestination;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1672, 1737, 1773);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1672, 1686, 1775);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1672, 1686, 1775);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal RemoteSessionCapability(RemotingDestination remotingDestination)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1672, 1996, 2597);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 1009, 1019);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 1046, 1057);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 1084, 1100);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 1139, 1159);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 1245, 1254);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 2094, 2147);

                _protocolVersion = RemotingConstants.ProtocolVersion;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 2407, 2438);

                _psversion = f_1672_2420_2437(2, 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 2480, 2529);

                _serversion = f_1672_2494_2528();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 2543, 2586);

                _remotingDestination = remotingDestination;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1672, 1996, 2597);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1672, 1996, 2597);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1672, 1996, 2597);
            }
        }

        internal RemoteSessionCapability(RemotingDestination remotingDestination,
                    Version protocolVersion,
                    Version psVersion,
                    Version serVersion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1672, 2609, 2989);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 1009, 1019);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 1046, 1057);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 1084, 1100);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 1139, 1159);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 1245, 1254);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 2810, 2845);

                _protocolVersion = protocolVersion;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 2859, 2882);

                _psversion = psVersion;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 2896, 2921);

                _serversion = serVersion;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 2935, 2978);

                _remotingDestination = remotingDestination;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1672, 2609, 2989);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1672, 2609, 2989);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1672, 2609, 2989);
            }
        }

        internal static RemoteSessionCapability CreateClientCapability()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1672, 3087, 3250);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 3176, 3239);

                return f_1672_3183_3238(RemotingDestination.Server);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1672, 3087, 3250);

                System.Management.Automation.Remoting.RemoteSessionCapability
                f_1672_3183_3238(System.Management.Automation.RemotingDestination
                remotingDestination)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteSessionCapability(remotingDestination);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1672, 3183, 3238);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1672, 3087, 3250);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1672, 3087, 3250);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static RemoteSessionCapability CreateServerCapability()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1672, 3348, 3511);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 3437, 3500);

                return f_1672_3444_3499(RemotingDestination.Client);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1672, 3348, 3511);

                System.Management.Automation.Remoting.RemoteSessionCapability
                f_1672_3444_3499(System.Management.Automation.RemotingDestination
                remotingDestination)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteSessionCapability(remotingDestination);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1672, 3444, 3499);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1672, 3348, 3511);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1672, 3348, 3511);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static byte[] GetCurrentTimeZoneInByteFormat()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1672, 3755, 5245);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 3835, 5189) || true) && (_timeZoneInByteFormat == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1672, 3835, 5189);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 3902, 3921);

                    Exception
                    e = null
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 3983, 4033);

                        BinaryFormatter
                        formatter = f_1672_4011_4032()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 4055, 4474);
                        using (MemoryStream
                        stream = f_1672_4084_4102()
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 4152, 4200);

                            f_1672_4152_4199(formatter, stream, f_1672_4180_4198());
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 4226, 4259);

                            f_1672_4226_4258(stream, 0, SeekOrigin.Begin);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 4285, 4325);

                            byte[]
                            result = new byte[f_1672_4310_4323(stream)]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 4351, 4394);

                            f_1672_4351_4393(stream, result, 0, f_1672_4379_4392(stream));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 4420, 4451);

                            _timeZoneInByteFormat = result;
                            DynAbs.Tracing.TraceSender.TraceExitUsing(1672, 4055, 4474);
                        }
                    }
                    catch (ArgumentNullException ane)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1672, 4511, 4612);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 4585, 4593);

                        e = ane;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1672, 4511, 4612);
                    }
                    catch (System.Runtime.Serialization.SerializationException sre)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1672, 4630, 4761);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 4734, 4742);

                        e = sre;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1672, 4630, 4761);
                    }
                    catch (System.Security.SecurityException se)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1672, 4779, 4890);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 4864, 4871);

                        e = se;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1672, 4779, 4890);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 5056, 5174) || true) && (e != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1672, 5056, 5174);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 5111, 5155);

                        _timeZoneInByteFormat = f_1672_5135_5154();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1672, 5056, 5174);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1672, 3835, 5189);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 5205, 5234);

                return _timeZoneInByteFormat;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1672, 3755, 5245);

                System.Runtime.Serialization.Formatters.Binary.BinaryFormatter
                f_1672_4011_4032()
                {
                    var return_v = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1672, 4011, 4032);
                    return return_v;
                }


                System.IO.MemoryStream
                f_1672_4084_4102()
                {
                    var return_v = new System.IO.MemoryStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1672, 4084, 4102);
                    return return_v;
                }


                System.TimeZoneInfo
                f_1672_4180_4198()
                {
                    var return_v = TimeZoneInfo.Local;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1672, 4180, 4198);
                    return return_v;
                }


                int
                f_1672_4152_4199(System.Runtime.Serialization.Formatters.Binary.BinaryFormatter
                this_param, System.IO.MemoryStream
                serializationStream, System.TimeZoneInfo
                graph)
                {
                    this_param.Serialize((System.IO.Stream)serializationStream, (object)graph);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1672, 4152, 4199);
                    return 0;
                }


                long
                f_1672_4226_4258(System.IO.MemoryStream
                this_param, int
                offset, System.IO.SeekOrigin
                loc)
                {
                    var return_v = this_param.Seek((long)offset, loc);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1672, 4226, 4258);
                    return return_v;
                }


                long
                f_1672_4310_4323(System.IO.MemoryStream
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1672, 4310, 4323);
                    return return_v;
                }


                long
                f_1672_4379_4392(System.IO.MemoryStream
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1672, 4379, 4392);
                    return return_v;
                }


                int
                f_1672_4351_4393(System.IO.MemoryStream
                this_param, byte[]
                buffer, int
                offset, long
                count)
                {
                    var return_v = this_param.Read(buffer, offset, (int)count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1672, 4351, 4393);
                    return return_v;
                }


                byte[]
                f_1672_5135_5154()
                {
                    var return_v = Array.Empty<byte>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1672, 5135, 5154);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1672, 3755, 5245);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1672, 3755, 5245);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal TimeZoneInfo TimeZone
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1672, 5436, 5461);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 5442, 5459);

                    return _timeZone;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1672, 5436, 5461);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1672, 5381, 5514);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1672, 5381, 5514);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1672, 5477, 5503);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 5483, 5501);

                    _timeZone = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1672, 5477, 5503);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1672, 5381, 5514);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1672, 5381, 5514);
                }
            }
        }

        static RemoteSessionCapability()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1672, 819, 5521);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 1192, 1213);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1672, 819, 5521);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1672, 819, 5521);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1672, 819, 5521);

        System.Version
        f_1672_2420_2437(int
        major, int
        minor)
        {
            var return_v = new System.Version(major, minor);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1672, 2420, 2437);
            return return_v;
        }


        System.Version
        f_1672_2494_2528()
        {
            var return_v = PSVersionInfo.SerializationVersion;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1672, 2494, 2528);
            return return_v;
        }

    }

    /// <summary>
    /// The HostDefaultDataId enum.
    /// </summary>
    internal enum HostDefaultDataId
    {
        ForegroundColor,
        BackgroundColor,
        CursorPosition,
        WindowPosition,
        CursorSize,
        BufferSize,
        WindowSize,
        MaxWindowSize,
        MaxPhysicalWindowSize,
        WindowTitle,
    }
    internal class HostDefaultData
    {
        private Dictionary<HostDefaultDataId, object> data;

        private HostDefaultData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1672, 6399, 6511);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 6256, 6260);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 6449, 6500);

                data = f_1672_6456_6499();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1672, 6399, 6511);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1672, 6399, 6511);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1672, 6399, 6511);
            }
        }

        /// <summary>
        /// Indexer to provide clean access to data.
        /// </summary>
        internal object this[HostDefaultDataId id]
        {

            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1672, 6691, 6767);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 6727, 6752);

                    return f_1672_6734_6751(this, id);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1672, 6691, 6767);

                    object
                    f_1672_6734_6751(System.Management.Automation.Remoting.HostDefaultData
                    this_param, System.Management.Automation.Remoting.HostDefaultDataId
                    id)
                    {
                        var return_v = this_param.GetValue(id);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1672, 6734, 6751);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1672, 6691, 6767);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1672, 6691, 6767);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool HasValue(HostDefaultDataId id)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1672, 6861, 6969);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 6930, 6958);

                return f_1672_6937_6957(data, id);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1672, 6861, 6969);

                bool
                f_1672_6937_6957(System.Collections.Generic.Dictionary<System.Management.Automation.Remoting.HostDefaultDataId, object>
                this_param, System.Management.Automation.Remoting.HostDefaultDataId
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1672, 6937, 6957);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1672, 6861, 6969);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1672, 6861, 6969);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void SetValue(HostDefaultDataId id, object dataValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1672, 7052, 7171);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 7139, 7160);

                data[id] = dataValue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1672, 7052, 7171);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1672, 7052, 7171);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1672, 7052, 7171);
            }
        }

        internal object GetValue(HostDefaultDataId id)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1672, 7254, 7425);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 7325, 7339);

                object
                result
                = default(object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 7353, 7386);

                f_1672_7353_7385(data, id, out result);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 7400, 7414);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1672, 7254, 7425);

                bool
                f_1672_7353_7385(System.Collections.Generic.Dictionary<System.Management.Automation.Remoting.HostDefaultDataId, object>
                this_param, System.Management.Automation.Remoting.HostDefaultDataId
                key, out object
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1672, 7353, 7385);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1672, 7254, 7425);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1672, 7254, 7425);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static HostDefaultData Create(PSHostRawUserInterface hostRawUI)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1672, 7594, 10461);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 7691, 7773) || true) && (hostRawUI == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1672, 7691, 7773);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 7746, 7758);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1672, 7691, 7773);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 7789, 7845);

                HostDefaultData
                hostDefaultData = f_1672_7823_7844()
                ;

                // Try to get values from the host. Catch-all okay because of 3rd party call-out.

                // Set ForegroundColor.
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 8031, 8118);

                    f_1672_8031_8117(hostDefaultData, HostDefaultDataId.ForegroundColor, f_1672_8091_8116(hostRawUI));
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1672, 8147, 8194);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1672, 8147, 8194);
                }

                // Set BackgroundColor.
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 8283, 8370);

                    f_1672_8283_8369(hostDefaultData, HostDefaultDataId.BackgroundColor, f_1672_8343_8368(hostRawUI));
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1672, 8399, 8446);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1672, 8399, 8446);
                }

                // Set CursorPosition.
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 8534, 8619);

                    f_1672_8534_8618(hostDefaultData, HostDefaultDataId.CursorPosition, f_1672_8593_8617(hostRawUI));
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1672, 8648, 8695);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1672, 8648, 8695);
                }

                // Set WindowPosition.
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 8783, 8868);

                    f_1672_8783_8867(hostDefaultData, HostDefaultDataId.WindowPosition, f_1672_8842_8866(hostRawUI));
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1672, 8897, 8944);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1672, 8897, 8944);
                }

                // Set CursorSize.
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 9028, 9105);

                    f_1672_9028_9104(hostDefaultData, HostDefaultDataId.CursorSize, f_1672_9083_9103(hostRawUI));
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1672, 9134, 9181);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1672, 9134, 9181);
                }

                // Set BufferSize.
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 9265, 9342);

                    f_1672_9265_9341(hostDefaultData, HostDefaultDataId.BufferSize, f_1672_9320_9340(hostRawUI));
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1672, 9371, 9418);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1672, 9371, 9418);
                }

                // Set WindowSize.
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 9502, 9579);

                    f_1672_9502_9578(hostDefaultData, HostDefaultDataId.WindowSize, f_1672_9557_9577(hostRawUI));
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1672, 9608, 9655);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1672, 9608, 9655);
                }

                // Set MaxWindowSize.
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 9742, 9825);

                    f_1672_9742_9824(hostDefaultData, HostDefaultDataId.MaxWindowSize, f_1672_9800_9823(hostRawUI));
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1672, 9854, 9901);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1672, 9854, 9901);
                }

                // Set MaxPhysicalWindowSize.
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 9996, 10095);

                    f_1672_9996_10094(hostDefaultData, HostDefaultDataId.MaxPhysicalWindowSize, f_1672_10062_10093(hostRawUI));
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1672, 10124, 10171);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1672, 10124, 10171);
                }

                // Set WindowTitle.
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 10256, 10335);

                    f_1672_10256_10334(hostDefaultData, HostDefaultDataId.WindowTitle, f_1672_10312_10333(hostRawUI));
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1672, 10364, 10411);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1672, 10364, 10411);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 10427, 10450);

                return hostDefaultData;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1672, 7594, 10461);

                System.Management.Automation.Remoting.HostDefaultData
                f_1672_7823_7844()
                {
                    var return_v = new System.Management.Automation.Remoting.HostDefaultData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1672, 7823, 7844);
                    return return_v;
                }


                System.ConsoleColor
                f_1672_8091_8116(System.Management.Automation.Host.PSHostRawUserInterface
                this_param)
                {
                    var return_v = this_param.ForegroundColor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1672, 8091, 8116);
                    return return_v;
                }


                int
                f_1672_8031_8117(System.Management.Automation.Remoting.HostDefaultData
                this_param, System.Management.Automation.Remoting.HostDefaultDataId
                id, System.ConsoleColor
                dataValue)
                {
                    this_param.SetValue(id, (object)dataValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1672, 8031, 8117);
                    return 0;
                }


                System.ConsoleColor
                f_1672_8343_8368(System.Management.Automation.Host.PSHostRawUserInterface
                this_param)
                {
                    var return_v = this_param.BackgroundColor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1672, 8343, 8368);
                    return return_v;
                }


                int
                f_1672_8283_8369(System.Management.Automation.Remoting.HostDefaultData
                this_param, System.Management.Automation.Remoting.HostDefaultDataId
                id, System.ConsoleColor
                dataValue)
                {
                    this_param.SetValue(id, (object)dataValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1672, 8283, 8369);
                    return 0;
                }


                System.Management.Automation.Host.Coordinates
                f_1672_8593_8617(System.Management.Automation.Host.PSHostRawUserInterface
                this_param)
                {
                    var return_v = this_param.CursorPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1672, 8593, 8617);
                    return return_v;
                }


                int
                f_1672_8534_8618(System.Management.Automation.Remoting.HostDefaultData
                this_param, System.Management.Automation.Remoting.HostDefaultDataId
                id, System.Management.Automation.Host.Coordinates
                dataValue)
                {
                    this_param.SetValue(id, (object)dataValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1672, 8534, 8618);
                    return 0;
                }


                System.Management.Automation.Host.Coordinates
                f_1672_8842_8866(System.Management.Automation.Host.PSHostRawUserInterface
                this_param)
                {
                    var return_v = this_param.WindowPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1672, 8842, 8866);
                    return return_v;
                }


                int
                f_1672_8783_8867(System.Management.Automation.Remoting.HostDefaultData
                this_param, System.Management.Automation.Remoting.HostDefaultDataId
                id, System.Management.Automation.Host.Coordinates
                dataValue)
                {
                    this_param.SetValue(id, (object)dataValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1672, 8783, 8867);
                    return 0;
                }


                int
                f_1672_9083_9103(System.Management.Automation.Host.PSHostRawUserInterface
                this_param)
                {
                    var return_v = this_param.CursorSize;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1672, 9083, 9103);
                    return return_v;
                }


                int
                f_1672_9028_9104(System.Management.Automation.Remoting.HostDefaultData
                this_param, System.Management.Automation.Remoting.HostDefaultDataId
                id, int
                dataValue)
                {
                    this_param.SetValue(id, (object)dataValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1672, 9028, 9104);
                    return 0;
                }


                System.Management.Automation.Host.Size
                f_1672_9320_9340(System.Management.Automation.Host.PSHostRawUserInterface
                this_param)
                {
                    var return_v = this_param.BufferSize;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1672, 9320, 9340);
                    return return_v;
                }


                int
                f_1672_9265_9341(System.Management.Automation.Remoting.HostDefaultData
                this_param, System.Management.Automation.Remoting.HostDefaultDataId
                id, System.Management.Automation.Host.Size
                dataValue)
                {
                    this_param.SetValue(id, (object)dataValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1672, 9265, 9341);
                    return 0;
                }


                System.Management.Automation.Host.Size
                f_1672_9557_9577(System.Management.Automation.Host.PSHostRawUserInterface
                this_param)
                {
                    var return_v = this_param.WindowSize;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1672, 9557, 9577);
                    return return_v;
                }


                int
                f_1672_9502_9578(System.Management.Automation.Remoting.HostDefaultData
                this_param, System.Management.Automation.Remoting.HostDefaultDataId
                id, System.Management.Automation.Host.Size
                dataValue)
                {
                    this_param.SetValue(id, (object)dataValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1672, 9502, 9578);
                    return 0;
                }


                System.Management.Automation.Host.Size
                f_1672_9800_9823(System.Management.Automation.Host.PSHostRawUserInterface
                this_param)
                {
                    var return_v = this_param.MaxWindowSize;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1672, 9800, 9823);
                    return return_v;
                }


                int
                f_1672_9742_9824(System.Management.Automation.Remoting.HostDefaultData
                this_param, System.Management.Automation.Remoting.HostDefaultDataId
                id, System.Management.Automation.Host.Size
                dataValue)
                {
                    this_param.SetValue(id, (object)dataValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1672, 9742, 9824);
                    return 0;
                }


                System.Management.Automation.Host.Size
                f_1672_10062_10093(System.Management.Automation.Host.PSHostRawUserInterface
                this_param)
                {
                    var return_v = this_param.MaxPhysicalWindowSize;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1672, 10062, 10093);
                    return return_v;
                }


                int
                f_1672_9996_10094(System.Management.Automation.Remoting.HostDefaultData
                this_param, System.Management.Automation.Remoting.HostDefaultDataId
                id, System.Management.Automation.Host.Size
                dataValue)
                {
                    this_param.SetValue(id, (object)dataValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1672, 9996, 10094);
                    return 0;
                }


                string
                f_1672_10312_10333(System.Management.Automation.Host.PSHostRawUserInterface
                this_param)
                {
                    var return_v = this_param.WindowTitle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1672, 10312, 10333);
                    return return_v;
                }


                int
                f_1672_10256_10334(System.Management.Automation.Remoting.HostDefaultData
                this_param, System.Management.Automation.Remoting.HostDefaultDataId
                id, string
                dataValue)
                {
                    this_param.SetValue(id, (object)dataValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1672, 10256, 10334);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1672, 7594, 10461);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1672, 7594, 10461);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static HostDefaultData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1672, 5976, 10468);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1672, 5976, 10468);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1672, 5976, 10468);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1672, 5976, 10468);

        System.Collections.Generic.Dictionary<System.Management.Automation.Remoting.HostDefaultDataId, object>
        f_1672_6456_6499()
        {
            var return_v = new System.Collections.Generic.Dictionary<System.Management.Automation.Remoting.HostDefaultDataId, object>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1672, 6456, 6499);
            return return_v;
        }

    }
    internal class HostInfo
    {
        internal HostDefaultData HostDefaultData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1672, 10728, 10760);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 10734, 10758);

                    return _hostDefaultData;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1672, 10728, 10760);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1672, 10663, 10771);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1672, 10663, 10771);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsHostNull
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1672, 10906, 10933);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 10912, 10931);

                    return _isHostNull;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1672, 10906, 10933);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1672, 10857, 10944);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1672, 10857, 10944);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool _isHostUINull;

        internal bool IsHostUINull
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1672, 11200, 11272);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 11236, 11257);

                    return _isHostUINull;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1672, 11200, 11272);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1672, 11149, 11283);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1672, 11149, 11283);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool _isHostRawUINull;

        private readonly bool _isHostNull;

        private readonly HostDefaultData _hostDefaultData;

        private bool _useRunspaceHost;

        internal bool IsHostRawUINull
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1672, 11842, 11917);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 11878, 11902);

                    return _isHostRawUINull;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1672, 11842, 11917);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1672, 11788, 11928);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1672, 11788, 11928);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool UseRunspaceHost
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1672, 12073, 12105);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 12079, 12103);

                    return _useRunspaceHost;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1672, 12073, 12105);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1672, 12019, 12165);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1672, 12019, 12165);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1672, 12121, 12154);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 12127, 12152);

                    _useRunspaceHost = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1672, 12121, 12154);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1672, 12019, 12165);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1672, 12019, 12165);
                }
            }
        }

        internal HostInfo(PSHost host)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1672, 12263, 12703);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 11046, 11059);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 11389, 11405);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 11440, 11451);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 11616, 11632);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 11656, 11672);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 12383, 12462);

                f_1672_12383_12461(host, ref _isHostNull, ref _isHostUINull, ref _isHostRawUINull);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 12547, 12692) || true) && (!_isHostUINull && (DynAbs.Tracing.TraceSender.Expression_True(1672, 12551, 12586) && !_isHostRawUINull))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1672, 12547, 12692);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 12620, 12677);

                    _hostDefaultData = f_1672_12639_12676(f_1672_12662_12675(f_1672_12662_12669(host)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1672, 12547, 12692);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1672, 12263, 12703);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1672, 12263, 12703);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1672, 12263, 12703);
            }
        }

        private static void CheckHostChain(PSHost host, ref bool isHostNull, ref bool isHostUINull, ref bool isHostRawUINull)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1672, 12793, 13898);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 12969, 12987);

                isHostNull = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 13001, 13021);

                isHostUINull = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 13035, 13058);

                isHostRawUINull = true;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 13141, 13499) || true) && (host == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1672, 13141, 13499);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 13283, 13290);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1672, 13141, 13499);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1672, 13141, 13499);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 13324, 13499) || true) && (host is InternalHost)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1672, 13324, 13499);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 13443, 13484);

                        host = f_1672_13450_13483(((InternalHost)host));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1672, 13324, 13499);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1672, 13141, 13499);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 13589, 13608);

                isHostNull = false;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 13672, 13704) || true) && (f_1672_13676_13683(host) == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1672, 13672, 13704);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 13695, 13702);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1672, 13672, 13704);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 13720, 13741);

                isHostUINull = false;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 13809, 13847) || true) && (f_1672_13813_13826(f_1672_13813_13820(host)) == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1672, 13809, 13847);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 13838, 13845);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1672, 13809, 13847);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1672, 13863, 13887);

                isHostRawUINull = false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1672, 12793, 13898);

                System.Management.Automation.Host.PSHost
                f_1672_13450_13483(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.ExternalHost;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1672, 13450, 13483);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostUserInterface
                f_1672_13676_13683(System.Management.Automation.Host.PSHost
                this_param)
                {
                    var return_v = this_param.UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1672, 13676, 13683);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostUserInterface
                f_1672_13813_13820(System.Management.Automation.Host.PSHost
                this_param)
                {
                    var return_v = this_param.UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1672, 13813, 13820);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostRawUserInterface
                f_1672_13813_13826(System.Management.Automation.Host.PSHostUserInterface
                this_param)
                {
                    var return_v = this_param.RawUI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1672, 13813, 13826);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1672, 12793, 13898);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1672, 12793, 13898);
            }
        }

        static HostInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1672, 10544, 13905);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1672, 10544, 13905);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1672, 10544, 13905);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1672, 10544, 13905);

        int
        f_1672_12383_12461(System.Management.Automation.Host.PSHost
        host, ref bool
        isHostNull, ref bool
        isHostUINull, ref bool
        isHostRawUINull)
        {
            CheckHostChain(host, ref isHostNull, ref isHostUINull, ref isHostRawUINull);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1672, 12383, 12461);
            return 0;
        }


        System.Management.Automation.Host.PSHostUserInterface
        f_1672_12662_12669(System.Management.Automation.Host.PSHost
        this_param)
        {
            var return_v = this_param.UI;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1672, 12662, 12669);
            return return_v;
        }


        System.Management.Automation.Host.PSHostRawUserInterface
        f_1672_12662_12675(System.Management.Automation.Host.PSHostUserInterface
        this_param)
        {
            var return_v = this_param.RawUI;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1672, 12662, 12675);
            return return_v;
        }


        System.Management.Automation.Remoting.HostDefaultData
        f_1672_12639_12676(System.Management.Automation.Host.PSHostRawUserInterface
        hostRawUI)
        {
            var return_v = HostDefaultData.Create(hostRawUI);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1672, 12639, 12676);
            return return_v;
        }

    }
}
