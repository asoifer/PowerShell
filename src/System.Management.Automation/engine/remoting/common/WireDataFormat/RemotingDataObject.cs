// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.IO;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation.Remoting
{
    internal class RemoteDataObject<T>
    {
        private const int
        destinationOffset = 0
        ;

        private const int
        dataTypeOffset = 4
        ;

        private const int
        rsPoolIdOffset = 8
        ;

        private const int
        psIdOffset = 24
        ;

        private const int
        headerLength = 4 + 4 + 16 + 16
        ;

        private const int
        SessionMask = 0x00010000
        ;

        private const int
        RunspacePoolMask = 0x00021000
        ;

        private const int
        PowerShellMask = 0x00041000
        ;

        protected RemoteDataObject(RemotingDestination destination,
                    RemotingDataType dataType,
                    Guid runspacePoolId,
                    Guid powerShellId,
                    T data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1673, 1769, 2165);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 2242, 2291);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 3252, 3295);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 3403, 3427);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 1980, 2006);

                Destination = destination;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 2020, 2040);

                DataType = dataType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 2054, 2086);

                RunspacePoolId = runspacePoolId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 2100, 2128);

                PowerShellId = powerShellId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 2142, 2154);

                Data = data;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1673, 1769, 2165);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1673, 1769, 2165);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1673, 1769, 2165);
            }
        }

        internal RemotingDestination Destination { get; }

        internal RemotingTargetInterface TargetInterface
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1673, 2531, 3229);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 2567, 2590);

                    int
                    dt = (int)f_1673_2581_2589()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 2665, 2811) || true) && ((dt & PowerShellMask) == PowerShellMask)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1673, 2665, 2811);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 2750, 2792);

                        return RemotingTargetInterface.PowerShell;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1673, 2665, 2811);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 2831, 2983) || true) && ((dt & RunspacePoolMask) == RunspacePoolMask)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1673, 2831, 2983);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 2920, 2964);

                        return RemotingTargetInterface.RunspacePool;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1673, 2831, 2983);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 3003, 3140) || true) && ((dt & SessionMask) == SessionMask)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1673, 3003, 3140);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 3082, 3121);

                        return RemotingTargetInterface.Session;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1673, 3003, 3140);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 3160, 3214);

                    return RemotingTargetInterface.InvalidTargetInterface;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1673, 2531, 3229);

                    System.Management.Automation.RemotingDataType
                    f_1673_2581_2589()
                    {
                        var return_v = DataType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1673, 2581, 2589);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1673, 2458, 3240);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1673, 2458, 3240);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal RemotingDataType DataType { get; }

        internal Guid RunspacePoolId { get; }

        internal Guid PowerShellId { get; }

        internal T Data { get; }

        internal static RemoteDataObject<T> CreateFrom(RemotingDestination destination,
                    RemotingDataType dataType,
                    Guid runspacePoolId,
                    Guid powerShellId,
                    T data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1673, 3786, 4118);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 4017, 4107);

                return f_1673_4024_4106(destination, dataType, runspacePoolId, powerShellId, data);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1673, 3786, 4118);

                System.Management.Automation.Remoting.RemoteDataObject<T>
                f_1673_4024_4106(System.Management.Automation.RemotingDestination
                destination, System.Management.Automation.RemotingDataType
                dataType, System.Guid
                runspacePoolId, System.Guid
                powerShellId, T
                data)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteDataObject<T>(destination, dataType, runspacePoolId, powerShellId, data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1673, 4024, 4106);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1673, 3786, 4118);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1673, 3786, 4118);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static RemoteDataObject<T> CreateFrom(Stream serializedDataStream, Fragmentor defragmentor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1673, 4469, 6107);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 4594, 4689);

                f_1673_4594_4688(serializedDataStream != null, "cannot construct a RemoteDataObject from null data");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 4703, 4768);

                f_1673_4703_4767(defragmentor != null, "defragmentor cannot be null.");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 4784, 5237) || true) && ((f_1673_4789_4816(serializedDataStream) - f_1673_4819_4848(serializedDataStream)) < headerLength)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1673, 4784, 5237);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 4898, 5196);

                    PSRemotingTransportException
                    e =
                    f_1673_4952_5195(PSRemotingErrorId.NotEnoughHeaderForRemoteDataObject, f_1673_5064_5121(), headerLength + FragmentedRemoteObject.HeaderLength)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 5214, 5222);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1673, 4784, 5237);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 5253, 5346);

                RemotingDestination
                destination = (RemotingDestination)f_1673_5308_5345(serializedDataStream)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 5360, 5444);

                RemotingDataType
                dataType = (RemotingDataType)f_1673_5406_5443(serializedDataStream)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 5458, 5518);

                Guid
                runspacePoolId = f_1673_5480_5517(serializedDataStream)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 5532, 5590);

                Guid
                powerShellId = f_1673_5552_5589(serializedDataStream)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 5606, 5631);

                object
                actualData = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 5645, 5816) || true) && ((f_1673_5650_5677(serializedDataStream) - headerLength) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1673, 5645, 5816);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 5731, 5801);

                    actualData = f_1673_5744_5800(defragmentor, serializedDataStream);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1673, 5645, 5816);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 5832, 5976);

                T
                deserializedObject = (T)f_1673_5858_5975(actualData, typeof(T), f_1673_5927_5974())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 5992, 6096);

                return f_1673_5999_6095(destination, dataType, runspacePoolId, powerShellId, deserializedObject);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1673, 4469, 6107);

                int
                f_1673_4594_4688(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1673, 4594, 4688);
                    return 0;
                }


                int
                f_1673_4703_4767(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1673, 4703, 4767);
                    return 0;
                }


                long
                f_1673_4789_4816(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1673, 4789, 4816);
                    return return_v;
                }


                long
                f_1673_4819_4848(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1673, 4819, 4848);
                    return return_v;
                }


                string
                f_1673_5064_5121()
                {
                    var return_v = RemotingErrorIdStrings.NotEnoughHeaderForRemoteDataObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1673, 5064, 5121);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingTransportException
                f_1673_4952_5195(System.Management.Automation.Remoting.PSRemotingErrorId
                errorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingTransportException(errorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1673, 4952, 5195);
                    return return_v;
                }


                uint
                f_1673_5308_5345(System.IO.Stream
                serializedDataStream)
                {
                    var return_v = DeserializeUInt(serializedDataStream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1673, 5308, 5345);
                    return return_v;
                }


                uint
                f_1673_5406_5443(System.IO.Stream
                serializedDataStream)
                {
                    var return_v = DeserializeUInt(serializedDataStream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1673, 5406, 5443);
                    return return_v;
                }


                System.Guid
                f_1673_5480_5517(System.IO.Stream
                serializedDataStream)
                {
                    var return_v = DeserializeGuid(serializedDataStream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1673, 5480, 5517);
                    return return_v;
                }


                System.Guid
                f_1673_5552_5589(System.IO.Stream
                serializedDataStream)
                {
                    var return_v = DeserializeGuid(serializedDataStream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1673, 5552, 5589);
                    return return_v;
                }


                long
                f_1673_5650_5677(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1673, 5650, 5677);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1673_5744_5800(System.Management.Automation.Remoting.Fragmentor
                this_param, System.IO.Stream
                serializedDataStream)
                {
                    var return_v = this_param.DeserializeToPSObject(serializedDataStream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1673, 5744, 5800);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1673_5927_5974()
                {
                    var return_v = System.Globalization.CultureInfo.CurrentCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1673, 5927, 5974);
                    return return_v;
                }


                object
                f_1673_5858_5975(object
                valueToConvert, System.Type
                resultType, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = LanguagePrimitives.ConvertTo(valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1673, 5858, 5975);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteDataObject<T>
                f_1673_5999_6095(System.Management.Automation.RemotingDestination
                destination, System.Management.Automation.RemotingDataType
                dataType, System.Guid
                runspacePoolId, System.Guid
                powerShellId, T
                data)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteDataObject<T>(destination, dataType, runspacePoolId, powerShellId, data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1673, 5999, 6095);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1673, 4469, 6107);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1673, 4469, 6107);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual void Serialize(Stream streamToWriteTo, Fragmentor fragmentor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1673, 6527, 6992);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 6630, 6704);

                f_1673_6630_6703(streamToWriteTo != null, "Stream to write to cannot be null.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 6718, 6779);

                f_1673_6718_6778(fragmentor != null, "Fragmentor cannot be null.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 6793, 6826);

                f_1673_6793_6825(this, streamToWriteTo);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 6842, 6958) || true) && (f_1673_6846_6850() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1673, 6842, 6958);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 6892, 6943);

                    f_1673_6892_6942(fragmentor, f_1673_6920_6924(), streamToWriteTo);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1673, 6842, 6958);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 6974, 6981);

                return;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1673, 6527, 6992);

                int
                f_1673_6630_6703(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1673, 6630, 6703);
                    return 0;
                }


                int
                f_1673_6718_6778(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1673, 6718, 6778);
                    return 0;
                }


                int
                f_1673_6793_6825(System.Management.Automation.Remoting.RemoteDataObject<T>
                this_param, System.IO.Stream
                streamToWriteTo)
                {
                    this_param.SerializeHeader(streamToWriteTo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1673, 6793, 6825);
                    return 0;
                }


                T
                f_1673_6846_6850()
                {
                    var return_v = Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1673, 6846, 6850);
                    return return_v;
                }


                T
                f_1673_6920_6924()
                {
                    var return_v = Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1673, 6920, 6924);
                    return return_v;
                }


                int
                f_1673_6892_6942(System.Management.Automation.Remoting.Fragmentor
                this_param, T
                obj, System.IO.Stream
                streamToWriteTo)
                {
                    this_param.SerializeToBytes((object)obj, streamToWriteTo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1673, 6892, 6942);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1673, 6527, 6992);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1673, 6527, 6992);
            }
        }

        private void SerializeHeader(Stream streamToWriteTo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1673, 7344, 7931);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 7421, 7494);

                f_1673_7421_7493(streamToWriteTo != null, "stream to write to cannot be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 7548, 7598);

                f_1673_7548_7597(this, f_1673_7568_7579(), streamToWriteTo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 7648, 7695);

                f_1673_7648_7694(this, f_1673_7668_7676(), streamToWriteTo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 7749, 7796);

                f_1673_7749_7795(this, f_1673_7763_7777(), streamToWriteTo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 7852, 7897);

                f_1673_7852_7896(this, f_1673_7866_7878(), streamToWriteTo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 7913, 7920);

                return;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1673, 7344, 7931);

                int
                f_1673_7421_7493(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1673, 7421, 7493);
                    return 0;
                }


                System.Management.Automation.RemotingDestination
                f_1673_7568_7579()
                {
                    var return_v = Destination;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1673, 7568, 7579);
                    return return_v;
                }


                int
                f_1673_7548_7597(System.Management.Automation.Remoting.RemoteDataObject<T>
                this_param, System.Management.Automation.RemotingDestination
                data, System.IO.Stream
                streamToWriteTo)
                {
                    this_param.SerializeUInt((uint)data, streamToWriteTo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1673, 7548, 7597);
                    return 0;
                }


                System.Management.Automation.RemotingDataType
                f_1673_7668_7676()
                {
                    var return_v = DataType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1673, 7668, 7676);
                    return return_v;
                }


                int
                f_1673_7648_7694(System.Management.Automation.Remoting.RemoteDataObject<T>
                this_param, System.Management.Automation.RemotingDataType
                data, System.IO.Stream
                streamToWriteTo)
                {
                    this_param.SerializeUInt((uint)data, streamToWriteTo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1673, 7648, 7694);
                    return 0;
                }


                System.Guid
                f_1673_7763_7777()
                {
                    var return_v = RunspacePoolId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1673, 7763, 7777);
                    return return_v;
                }


                int
                f_1673_7749_7795(System.Management.Automation.Remoting.RemoteDataObject<T>
                this_param, System.Guid
                guid, System.IO.Stream
                streamToWriteTo)
                {
                    this_param.SerializeGuid(guid, streamToWriteTo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1673, 7749, 7795);
                    return 0;
                }


                System.Guid
                f_1673_7866_7878()
                {
                    var return_v = PowerShellId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1673, 7866, 7878);
                    return return_v;
                }


                int
                f_1673_7852_7896(System.Management.Automation.Remoting.RemoteDataObject<T>
                this_param, System.Guid
                guid, System.IO.Stream
                streamToWriteTo)
                {
                    this_param.SerializeGuid(guid, streamToWriteTo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1673, 7852, 7896);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1673, 7344, 7931);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1673, 7344, 7931);
            }
        }

        private void SerializeUInt(uint data, Stream streamToWriteTo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1673, 7943, 8485);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 8029, 8102);

                f_1673_8029_8101(streamToWriteTo != null, "stream to write to cannot be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 8118, 8146);

                byte[]
                result = new byte[4]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 8177, 8189);

                int
                idx = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 8203, 8239);

                result[idx++] = (byte)(data & 0xFF);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 8253, 8296);

                result[idx++] = (byte)((data >> 8) & 0xFF);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 8310, 8359);

                result[idx++] = (byte)((data >> (2 * 8)) & 0xFF);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 8373, 8422);

                result[idx++] = (byte)((data >> (3 * 8)) & 0xFF);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 8438, 8474);

                f_1673_8438_8473(
                            streamToWriteTo, result, 0, 4);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1673, 7943, 8485);

                int
                f_1673_8029_8101(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1673, 8029, 8101);
                    return 0;
                }


                int
                f_1673_8438_8473(System.IO.Stream
                this_param, byte[]
                buffer, int
                offset, int
                count)
                {
                    this_param.Write(buffer, offset, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1673, 8438, 8473);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1673, 7943, 8485);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1673, 7943, 8485);
            }
        }

        private static uint DeserializeUInt(Stream serializedDataStream)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1673, 8497, 9074);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 8586, 8662);

                f_1673_8586_8661(f_1673_8597_8624(serializedDataStream) >= 4, "Not enough data to get Int.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 8678, 8694);

                uint
                result = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 8708, 8769);

                result |= (((uint)(f_1673_8727_8758(serializedDataStream))) & 0xFF);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 8783, 8851);

                result |= (((uint)(f_1673_8802_8833(serializedDataStream) << 8)) & 0xFF00);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 8865, 8941);

                result |= (((uint)(f_1673_8884_8915(serializedDataStream) << (2 * 8))) & 0xFF0000);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 8955, 9033);

                result |= (((uint)(f_1673_8974_9005(serializedDataStream) << (3 * 8))) & 0xFF000000);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 9049, 9063);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1673, 8497, 9074);

                long
                f_1673_8597_8624(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1673, 8597, 8624);
                    return return_v;
                }


                int
                f_1673_8586_8661(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1673, 8586, 8661);
                    return 0;
                }


                int
                f_1673_8727_8758(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.ReadByte();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1673, 8727, 8758);
                    return return_v;
                }


                int
                f_1673_8802_8833(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.ReadByte();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1673, 8802, 8833);
                    return return_v;
                }


                int
                f_1673_8884_8915(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.ReadByte();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1673, 8884, 8915);
                    return return_v;
                }


                int
                f_1673_8974_9005(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.ReadByte();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1673, 8974, 9005);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1673, 8497, 9074);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1673, 8497, 9074);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void SerializeGuid(Guid guid, Stream streamToWriteTo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1673, 9086, 9380);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 9172, 9245);

                f_1673_9172_9244(streamToWriteTo != null, "stream to write to cannot be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 9261, 9299);

                byte[]
                guidArray = guid.ToByteArray()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 9315, 9369);

                f_1673_9315_9368(
                            streamToWriteTo, guidArray, 0, f_1673_9351_9367(guidArray));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1673, 9086, 9380);

                int
                f_1673_9172_9244(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1673, 9172, 9244);
                    return 0;
                }


                int
                f_1673_9351_9367(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1673, 9351, 9367);
                    return return_v;
                }


                int
                f_1673_9315_9368(System.IO.Stream
                this_param, byte[]
                buffer, int
                offset, int
                count)
                {
                    this_param.Write(buffer, offset, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1673, 9315, 9368);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1673, 9086, 9380);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1673, 9086, 9380);
            }
        }

        private static Guid DeserializeGuid(Stream serializedDataStream)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1673, 9392, 9831);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 9481, 9559);

                f_1673_9481_9558(f_1673_9492_9519(serializedDataStream) >= 16, "Not enough data to get Guid.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 9575, 9607);

                byte[]
                guidarray = new byte[16]
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 9649, 9656);

                    for (int
        idx = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 9640, 9777) || true) && (idx < 16)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 9668, 9673)
        , idx++, DynAbs.Tracing.TraceSender.TraceExitCondition(1673, 9640, 9777))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1673, 9640, 9777);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 9707, 9762);

                        guidarray[idx] = (byte)f_1673_9730_9761(serializedDataStream);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1673, 1, 138);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1673, 1, 138);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 9793, 9820);

                return f_1673_9800_9819(guidarray);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1673, 9392, 9831);

                long
                f_1673_9492_9519(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1673, 9492, 9519);
                    return return_v;
                }


                int
                f_1673_9481_9558(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1673, 9481, 9558);
                    return 0;
                }


                int
                f_1673_9730_9761(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.ReadByte();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1673, 9730, 9761);
                    return return_v;
                }


                System.Guid
                f_1673_9800_9819(byte[]
                b)
                {
                    var return_v = new System.Guid(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1673, 9800, 9819);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1673, 9392, 9831);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1673, 9392, 9831);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static RemoteDataObject()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1673, 450, 9860);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 554, 575);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 604, 622);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 651, 669);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 698, 713);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 742, 772);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 803, 827);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 856, 885);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 914, 941);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1673, 450, 9860);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1673, 450, 9860);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1673, 450, 9860);
    }
    internal class RemoteDataObject : RemoteDataObject<object>
    {
        private RemoteDataObject(RemotingDestination destination,
                    RemotingDataType dataType,
                    Guid runspacePoolId,
                    Guid powerShellId,
                    object data) : base(f_1673_10463_10474_C(destination), dataType, runspacePoolId, powerShellId, data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1673, 10266, 10543);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1673, 10266, 10543);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1673, 10266, 10543);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1673, 10266, 10543);
            }
        }

        internal static new RemoteDataObject CreateFrom(RemotingDestination destination,
                    RemotingDataType dataType,
                    Guid runspacePoolId,
                    Guid powerShellId,
                    object data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1673, 10869, 11221);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1673, 11106, 11210);

                return f_1673_11113_11209(destination, dataType, runspacePoolId, powerShellId, data);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1673, 10869, 11221);

                System.Management.Automation.Remoting.RemoteDataObject
                f_1673_11113_11209(System.Management.Automation.RemotingDestination
                destination, System.Management.Automation.RemotingDataType
                dataType, System.Guid
                runspacePoolId, System.Guid
                powerShellId, object
                data)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteDataObject(destination, dataType, runspacePoolId, powerShellId, data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1673, 11113, 11209);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1673, 10869, 11221);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1673, 10869, 11221);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static System.Management.Automation.RemotingDestination
        f_1673_10463_10474_C(System.Management.Automation.RemotingDestination
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1673, 10266, 10543);
            return return_v;
        }

    }
}
