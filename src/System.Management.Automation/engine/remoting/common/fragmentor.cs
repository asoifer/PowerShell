// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Management.Automation.Internal;
using System.Management.Automation.Tracing;
using System.Text;
using System.Xml;

using Dbg = System.Management.Automation.Diagnostics;
using TypeTable = System.Management.Automation.Runspaces.TypeTable;

namespace System.Management.Automation.Remoting
{
    internal class FragmentedRemoteObject
    {
        private byte[] _blob;

        private int _blobLength;

        internal const byte
        SFlag = 0x1
        ;

        internal const byte
        EFlag = 0x2
        ;

        internal const int
        HeaderLength = 8 + 8 + 1 + 4
        ;

        private const int
        _objectIdOffset = 0
        ;

        private const int
        _fragmentIdOffset = 8
        ;

        private const int
        _flagsOffset = 16
        ;

        private const int
        _blobLengthOffset = 17
        ;

        private const int
        _blobOffset = 21
        ;

        internal FragmentedRemoteObject()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1618, 2916, 2971);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 1254, 1259);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 1282, 1293);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 4437, 4473);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 4619, 4657);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 4763, 4806);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 4911, 4952);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1618, 2916, 2971);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1618, 2916, 2971);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1618, 2916, 2971);
            }
        }

        internal FragmentedRemoteObject(byte[] blob, long objectId, long fragmentId,
                    bool isEndFragment)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1618, 3590, 4229);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 1254, 1259);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 1282, 1293);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 4437, 4473);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 4619, 4657);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 4763, 4806);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 4911, 4952);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 3724, 3825);

                f_1618_3724_3824((blob != null) || (DynAbs.Tracing.TraceSender.Expression_False(1618, 3735, 3771) || (f_1618_3754_3765(blob) == 0)), "Cannot create a fragment for null or empty data.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 3839, 3892);

                f_1618_3839_3891(objectId >= 0, "Object Id cannot be < 0");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 3906, 3963);

                f_1618_3906_3962(fragmentId >= 0, "Fragment Id cannot be < 0");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 3979, 3999);

                ObjectId = objectId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 4013, 4037);

                FragmentId = fragmentId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 4053, 4104);

                IsStartFragment = (DynAbs.Tracing.TraceSender.Conditional_F1(1618, 4071, 4088) || (((fragmentId == 0) && DynAbs.Tracing.TraceSender.Conditional_F2(1618, 4091, 4095)) || DynAbs.Tracing.TraceSender.Conditional_F3(1618, 4098, 4103))) ? true : false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 4118, 4148);

                IsEndFragment = isEndFragment;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 4164, 4177);

                _blob = blob;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 4191, 4218);

                _blobLength = f_1618_4205_4217(_blob);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1618, 3590, 4229);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1618, 3590, 4229);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1618, 3590, 4229);
            }
        }

        internal long ObjectId { get; set; }

        internal long FragmentId { get; set; }

        internal bool IsStartFragment { get; set; }

        internal bool IsEndFragment { get; set; }

        internal int BlobLength
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1618, 5173, 5200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 5179, 5198);

                    return _blobLength;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1618, 5173, 5200);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1618, 5125, 5376);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1618, 5125, 5376);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1618, 5216, 5365);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 5252, 5312);

                    f_1618_5252_5311(value >= 0, "BlobLength cannot be less than 0.");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 5330, 5350);

                    _blobLength = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1618, 5216, 5365);

                    int
                    f_1618_5252_5311(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Dbg.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 5252, 5311);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1618, 5125, 5376);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1618, 5125, 5376);
                }
            }
        }

        internal byte[] Blob
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1618, 5532, 5553);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 5538, 5551);

                    return _blob;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1618, 5532, 5553);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1618, 5487, 5712);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1618, 5487, 5712);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1618, 5569, 5701);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 5605, 5654);

                    f_1618_5605_5653(value != null, "Blob cannot be null");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 5672, 5686);

                    _blob = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1618, 5569, 5701);

                    int
                    f_1618_5605_5653(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Dbg.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 5605, 5653);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1618, 5487, 5712);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1618, 5487, 5712);
                }
            }
        }

        internal byte[] GetBytes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1618, 8125, 10586);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 8176, 8197);

                int
                objectIdSize = 8
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 8238, 8261);

                int
                fragmentIdSize = 8
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 8302, 8320);

                int
                flagsSize = 1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 8374, 8397);

                int
                blobLengthSize = 4
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 8439, 8529);

                int
                totalLength = objectIdSize + fragmentIdSize + flagsSize + blobLengthSize + f_1618_8518_8528()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 8545, 8583);

                byte[]
                result = new byte[totalLength]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 8599, 8611);

                int
                idx = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 8731, 8753);

                idx = _objectIdOffset;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 8767, 8820);

                result[idx++] = (byte)((f_1618_8791_8799() >> (7 * 8)) & 0x7F);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 8851, 8904);

                result[idx++] = (byte)((f_1618_8875_8883() >> (6 * 8)) & 0xFF);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 8918, 8971);

                result[idx++] = (byte)((f_1618_8942_8950() >> (5 * 8)) & 0xFF);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 8985, 9038);

                result[idx++] = (byte)((f_1618_9009_9017() >> (4 * 8)) & 0xFF);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 9052, 9105);

                result[idx++] = (byte)((f_1618_9076_9084() >> (3 * 8)) & 0xFF);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 9119, 9172);

                result[idx++] = (byte)((f_1618_9143_9151() >> (2 * 8)) & 0xFF);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 9186, 9233);

                result[idx++] = (byte)((f_1618_9210_9218() >> 8) & 0xFF);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 9247, 9287);

                result[idx++] = (byte)(f_1618_9270_9278() & 0xFF);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 9330, 9354);

                idx = _fragmentIdOffset;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 9368, 9423);

                result[idx++] = (byte)((f_1618_9392_9402() >> (7 * 8)) & 0x7F);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 9454, 9509);

                result[idx++] = (byte)((f_1618_9478_9488() >> (6 * 8)) & 0xFF);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 9523, 9578);

                result[idx++] = (byte)((f_1618_9547_9557() >> (5 * 8)) & 0xFF);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 9592, 9647);

                result[idx++] = (byte)((f_1618_9616_9626() >> (4 * 8)) & 0xFF);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 9661, 9716);

                result[idx++] = (byte)((f_1618_9685_9695() >> (3 * 8)) & 0xFF);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 9730, 9785);

                result[idx++] = (byte)((f_1618_9754_9764() >> (2 * 8)) & 0xFF);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 9799, 9848);

                result[idx++] = (byte)((f_1618_9823_9833() >> 8) & 0xFF);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 9862, 9904);

                result[idx++] = (byte)(f_1618_9885_9895() & 0xFF);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 9954, 9973);

                idx = _flagsOffset;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 9987, 10035);

                byte
                s_flag = (DynAbs.Tracing.TraceSender.Conditional_F1(1618, 10001, 10016) || ((f_1618_10001_10016() && DynAbs.Tracing.TraceSender.Conditional_F2(1618, 10019, 10024)) || DynAbs.Tracing.TraceSender.Conditional_F3(1618, 10027, 10034))) ? SFlag : (byte)0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 10049, 10095);

                byte
                e_flag = (DynAbs.Tracing.TraceSender.Conditional_F1(1618, 10063, 10076) || ((f_1618_10063_10076() && DynAbs.Tracing.TraceSender.Conditional_F2(1618, 10079, 10084)) || DynAbs.Tracing.TraceSender.Conditional_F3(1618, 10087, 10094))) ? EFlag : (byte)0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 10111, 10151);

                result[idx++] = (byte)(s_flag | e_flag);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 10194, 10218);

                idx = _blobLengthOffset;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 10232, 10287);

                result[idx++] = (byte)((f_1618_10256_10266() >> (3 * 8)) & 0xFF);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 10301, 10356);

                result[idx++] = (byte)((f_1618_10325_10335() >> (2 * 8)) & 0xFF);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 10370, 10419);

                result[idx++] = (byte)((f_1618_10394_10404() >> 8) & 0xFF);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 10433, 10475);

                result[idx++] = (byte)(f_1618_10456_10466() & 0xFF);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 10491, 10545);

                f_1618_10491_10544(_blob, 0, result, _blobOffset, f_1618_10533_10543());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 10561, 10575);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1618, 8125, 10586);

                int
                f_1618_8518_8528()
                {
                    var return_v = BlobLength;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 8518, 8528);
                    return return_v;
                }


                long
                f_1618_8791_8799()
                {
                    var return_v = ObjectId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 8791, 8799);
                    return return_v;
                }


                long
                f_1618_8875_8883()
                {
                    var return_v = ObjectId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 8875, 8883);
                    return return_v;
                }


                long
                f_1618_8942_8950()
                {
                    var return_v = ObjectId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 8942, 8950);
                    return return_v;
                }


                long
                f_1618_9009_9017()
                {
                    var return_v = ObjectId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 9009, 9017);
                    return return_v;
                }


                long
                f_1618_9076_9084()
                {
                    var return_v = ObjectId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 9076, 9084);
                    return return_v;
                }


                long
                f_1618_9143_9151()
                {
                    var return_v = ObjectId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 9143, 9151);
                    return return_v;
                }


                long
                f_1618_9210_9218()
                {
                    var return_v = ObjectId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 9210, 9218);
                    return return_v;
                }


                long
                f_1618_9270_9278()
                {
                    var return_v = ObjectId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 9270, 9278);
                    return return_v;
                }


                long
                f_1618_9392_9402()
                {
                    var return_v = FragmentId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 9392, 9402);
                    return return_v;
                }


                long
                f_1618_9478_9488()
                {
                    var return_v = FragmentId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 9478, 9488);
                    return return_v;
                }


                long
                f_1618_9547_9557()
                {
                    var return_v = FragmentId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 9547, 9557);
                    return return_v;
                }


                long
                f_1618_9616_9626()
                {
                    var return_v = FragmentId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 9616, 9626);
                    return return_v;
                }


                long
                f_1618_9685_9695()
                {
                    var return_v = FragmentId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 9685, 9695);
                    return return_v;
                }


                long
                f_1618_9754_9764()
                {
                    var return_v = FragmentId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 9754, 9764);
                    return return_v;
                }


                long
                f_1618_9823_9833()
                {
                    var return_v = FragmentId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 9823, 9833);
                    return return_v;
                }


                long
                f_1618_9885_9895()
                {
                    var return_v = FragmentId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 9885, 9895);
                    return return_v;
                }


                bool
                f_1618_10001_10016()
                {
                    var return_v = IsStartFragment;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 10001, 10016);
                    return return_v;
                }


                bool
                f_1618_10063_10076()
                {
                    var return_v = IsEndFragment;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 10063, 10076);
                    return return_v;
                }


                int
                f_1618_10256_10266()
                {
                    var return_v = BlobLength;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 10256, 10266);
                    return return_v;
                }


                int
                f_1618_10325_10335()
                {
                    var return_v = BlobLength;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 10325, 10335);
                    return return_v;
                }


                int
                f_1618_10394_10404()
                {
                    var return_v = BlobLength;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 10394, 10404);
                    return return_v;
                }


                int
                f_1618_10456_10466()
                {
                    var return_v = BlobLength;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 10456, 10466);
                    return return_v;
                }


                int
                f_1618_10533_10543()
                {
                    var return_v = BlobLength;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 10533, 10543);
                    return return_v;
                }


                int
                f_1618_10491_10544(byte[]
                sourceArray, int
                sourceIndex, byte[]
                destinationArray, int
                destinationIndex, int
                length)
                {
                    Array.Copy((System.Array)sourceArray, sourceIndex, (System.Array)destinationArray, destinationIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 10491, 10544);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1618, 8125, 10586);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1618, 8125, 10586);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static long GetObjectId(byte[] fragmentBytes, int startIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1618, 11293, 12324);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 11388, 11454);

                f_1618_11388_11453(fragmentBytes != null, "fragmentBytes cannot be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 11468, 11556);

                f_1618_11468_11555(f_1618_11479_11499(fragmentBytes) >= HeaderLength, "not enough data to decode object id");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 11570, 11588);

                long
                objectId = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 11604, 11643);

                int
                idx = startIndex + _objectIdOffset
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 11659, 11733);

                objectId = (((long)fragmentBytes[idx++]) << (7 * 8)) & 0x7F00000000000000;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 11747, 11820);

                objectId += (((long)fragmentBytes[idx++]) << (6 * 8)) & 0xFF000000000000;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 11834, 11905);

                objectId += (((long)fragmentBytes[idx++]) << (5 * 8)) & 0xFF0000000000;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 11919, 11988);

                objectId += (((long)fragmentBytes[idx++]) << (4 * 8)) & 0xFF00000000;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 12002, 12069);

                objectId += (((long)fragmentBytes[idx++]) << (3 * 8)) & 0xFF000000;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 12083, 12148);

                objectId += (((long)fragmentBytes[idx++]) << (2 * 8)) & 0xFF0000;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 12162, 12219);

                objectId += (((long)fragmentBytes[idx++]) << 8) & 0xFF00;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 12233, 12281);

                objectId += ((long)fragmentBytes[idx++]) & 0xFF;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 12297, 12313);

                return objectId;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1618, 11293, 12324);

                int
                f_1618_11388_11453(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 11388, 11453);
                    return 0;
                }


                int
                f_1618_11479_11499(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 11479, 11499);
                    return return_v;
                }


                int
                f_1618_11468_11555(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 11468, 11555);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1618, 11293, 12324);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1618, 11293, 12324);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static long GetFragmentId(byte[] fragmentBytes, int startIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1618, 12994, 14049);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 13091, 13157);

                f_1618_13091_13156(fragmentBytes != null, "fragmentBytes cannot be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 13171, 13261);

                f_1618_13171_13260(f_1618_13182_13202(fragmentBytes) >= HeaderLength, "not enough data to decode fragment id");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 13275, 13295);

                long
                fragmentId = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 13309, 13350);

                int
                idx = startIndex + _fragmentIdOffset
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 13366, 13442);

                fragmentId = (((long)fragmentBytes[idx++]) << (7 * 8)) & 0x7F00000000000000;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 13456, 13531);

                fragmentId += (((long)fragmentBytes[idx++]) << (6 * 8)) & 0xFF000000000000;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 13545, 13618);

                fragmentId += (((long)fragmentBytes[idx++]) << (5 * 8)) & 0xFF0000000000;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 13632, 13703);

                fragmentId += (((long)fragmentBytes[idx++]) << (4 * 8)) & 0xFF00000000;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 13717, 13786);

                fragmentId += (((long)fragmentBytes[idx++]) << (3 * 8)) & 0xFF000000;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 13800, 13867);

                fragmentId += (((long)fragmentBytes[idx++]) << (2 * 8)) & 0xFF0000;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 13881, 13940);

                fragmentId += (((long)fragmentBytes[idx++]) << 8) & 0xFF00;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 13954, 14004);

                fragmentId += ((long)fragmentBytes[idx++]) & 0xFF;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 14020, 14038);

                return fragmentId;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1618, 12994, 14049);

                int
                f_1618_13091_13156(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 13091, 13156);
                    return 0;
                }


                int
                f_1618_13182_13202(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 13182, 13202);
                    return return_v;
                }


                int
                f_1618_13171_13260(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 13171, 13260);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1618, 12994, 14049);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1618, 12994, 14049);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool GetIsStartFragment(byte[] fragmentBytes, int startIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1618, 14817, 15275);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 14919, 14980);

                f_1618_14919_14979(fragmentBytes != null, "fragment cannot be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 14994, 15099);

                f_1618_14994_15098(f_1618_15005_15025(fragmentBytes) >= HeaderLength, "not enough data to decode if it is a start fragment.");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 15115, 15235) || true) && ((fragmentBytes[startIndex + _flagsOffset] & SFlag) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1618, 15115, 15235);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 15208, 15220);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1618, 15115, 15235);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 15251, 15264);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1618, 14817, 15275);

                int
                f_1618_14919_14979(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 14919, 14979);
                    return 0;
                }


                int
                f_1618_15005_15025(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 15005, 15025);
                    return return_v;
                }


                int
                f_1618_14994_15098(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 14994, 15098);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1618, 14817, 15275);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1618, 14817, 15275);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool GetIsEndFragment(byte[] fragmentBytes, int startIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1618, 16045, 16500);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 16145, 16206);

                f_1618_16145_16205(fragmentBytes != null, "fragment cannot be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 16220, 16324);

                f_1618_16220_16323(f_1618_16231_16251(fragmentBytes) >= HeaderLength, "not enough data to decode if it is an end fragment.");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 16340, 16460) || true) && ((fragmentBytes[startIndex + _flagsOffset] & EFlag) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1618, 16340, 16460);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 16433, 16445);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1618, 16340, 16460);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 16476, 16489);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1618, 16045, 16500);

                int
                f_1618_16145_16205(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 16145, 16205);
                    return 0;
                }


                int
                f_1618_16231_16251(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 16231, 16251);
                    return return_v;
                }


                int
                f_1618_16220_16323(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 16220, 16323);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1618, 16045, 16500);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1618, 16045, 16500);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int GetBlobLength(byte[] fragmentBytes, int startIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1618, 17225, 17921);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 17321, 17382);

                f_1618_17321_17381(fragmentBytes != null, "fragment cannot be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 17396, 17487);

                f_1618_17396_17486(f_1618_17407_17427(fragmentBytes) >= HeaderLength, "not enough data to decode blob length.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 17503, 17522);

                int
                blobLength = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 17536, 17577);

                int
                idx = startIndex + _blobLengthOffset
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 17593, 17661);

                blobLength += (((int)fragmentBytes[idx++]) << (3 * 8)) & 0x7F000000;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 17675, 17741);

                blobLength += (((int)fragmentBytes[idx++]) << (2 * 8)) & 0xFF0000;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 17755, 17813);

                blobLength += (((int)fragmentBytes[idx++]) << 8) & 0xFF00;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 17827, 17876);

                blobLength += ((int)fragmentBytes[idx++]) & 0xFF;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 17892, 17910);

                return blobLength;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1618, 17225, 17921);

                int
                f_1618_17321_17381(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 17321, 17381);
                    return 0;
                }


                int
                f_1618_17407_17427(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 17407, 17427);
                    return return_v;
                }


                int
                f_1618_17396_17486(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 17396, 17486);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1618, 17225, 17921);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1618, 17225, 17921);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static FragmentedRemoteObject()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1618, 1185, 17928);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 1468, 1479);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 1652, 1663);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 1828, 1856);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 2017, 2036);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 2201, 2222);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 2417, 2434);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 2599, 2621);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 2774, 2790);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1618, 1185, 17928);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1618, 1185, 17928);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1618, 1185, 17928);

        int
        f_1618_3754_3765(byte[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 3754, 3765);
            return return_v;
        }


        int
        f_1618_3724_3824(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 3724, 3824);
            return 0;
        }


        int
        f_1618_3839_3891(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 3839, 3891);
            return 0;
        }


        int
        f_1618_3906_3962(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 3906, 3962);
            return 0;
        }


        int
        f_1618_4205_4217(byte[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 4205, 4217);
            return return_v;
        }

    }
    internal class SerializedDataStream : Stream, IDisposable
    {
        [TraceSourceAttribute("SerializedDataStream", "SerializedDataStream")]
        private static PSTraceSource s_trace;

        private static long s_objectIdSequenceNumber;

        private bool _isEntered;

        private FragmentedRemoteObject _currentFragment;

        private long _fragmentId;

        private int _fragmentSize;

        private object _syncObject;

        private bool _isDisposed;

        private bool _notifyOnWriteFragmentImmediately;

        private Queue<MemoryStream> _queuedStreams;

        private MemoryStream _writeStream;

        private MemoryStream _readStream;

        private int _writeOffset;

        private int _readOffSet;

        private long _length;

        /// <summary>
        /// Callback that is called once a fragmented data is available.
        /// </summary>
        /// <param name="data">
        /// Data that resulted in this callback.
        /// </param>
        /// <param name="isEndFragment">
        /// true if data represents EndFragment of an object.
        /// </param>
        internal delegate void OnDataAvailableCallback(byte[] data, bool isEndFragment);

        private OnDataAvailableCallback _onDataAvailableCallback;

        internal SerializedDataStream(int fragmentSize)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1618, 20389, 20849);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 18689, 18699);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 18741, 18757);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 18781, 18792);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 18817, 18830);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 18856, 18867);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 18891, 18902);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 18926, 18959);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 19372, 19386);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 19418, 19430);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 19462, 19473);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 19496, 19508);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 19531, 19542);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 19566, 19573);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 20061, 20085);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 38408, 38425);
                this._disposed = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 20461, 20550);

                f_1618_20461_20549(s_trace, "Creating SerializedDataStream with fragmentsize : {0}", fragmentSize);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 20564, 20635);

                f_1618_20564_20634(fragmentSize > 0, "fragmentsize should be greater than 0.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 20649, 20676);

                _syncObject = f_1618_20663_20675();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 20690, 20738);

                _currentFragment = f_1618_20709_20737();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 20752, 20795);

                _queuedStreams = f_1618_20769_20794();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 20809, 20838);

                _fragmentSize = fragmentSize;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1618, 20389, 20849);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1618, 20389, 20849);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1618, 20389, 20849);
            }
        }

        internal SerializedDataStream(int fragmentSize,
                    OnDataAvailableCallback callbackToNotify) : this(f_1618_21685_21697_C(fragmentSize))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1618, 21575, 21914);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 21723, 21903) || true) && (callbackToNotify != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1618, 21723, 21903);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 21785, 21826);

                    _notifyOnWriteFragmentImmediately = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 21844, 21888);

                    _onDataAvailableCallback = callbackToNotify;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1618, 21723, 21903);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1618, 21575, 21914);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1618, 21575, 21914);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1618, 21575, 21914);
            }
        }

        internal void Enter()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1618, 22268, 22801);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 22314, 22404);

                f_1618_22314_22403(!_isEntered, "Stream is already entered. You cannot enter into stream again.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 22418, 22436);

                _isEntered = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 22450, 22466);

                _fragmentId = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 22530, 22572);

                _currentFragment.ObjectId = f_1618_22558_22571();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 22586, 22628);

                _currentFragment.FragmentId = _fragmentId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 22642, 22682);

                _currentFragment.IsStartFragment = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 22696, 22728);

                _currentFragment.BlobLength = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 22742, 22790);

                _currentFragment.Blob = new byte[_fragmentSize];
                DynAbs.Tracing.TraceSender.TraceExitMethod(1618, 22268, 22801);

                int
                f_1618_22314_22403(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 22314, 22403);
                    return 0;
                }


                long
                f_1618_22558_22571()
                {
                    var return_v = GetObjectId();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 22558, 22571);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1618, 22268, 22801);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1618, 22268, 22801);
            }
        }

        internal void Exit()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1618, 22971, 23328);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 23016, 23035);

                _isEntered = false;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 23086, 23317) || true) && (f_1618_23090_23117(_currentFragment) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1618, 23086, 23317);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 23215, 23253);

                    _currentFragment.IsEndFragment = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 23271, 23302);

                    f_1618_23271_23301(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1618, 23086, 23317);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1618, 22971, 23328);

                int
                f_1618_23090_23117(System.Management.Automation.Remoting.FragmentedRemoteObject
                this_param)
                {
                    var return_v = this_param.BlobLength;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 23090, 23117);
                    return return_v;
                }


                int
                f_1618_23271_23301(System.Management.Automation.Remoting.SerializedDataStream
                this_param)
                {
                    this_param.WriteCurrentFragmentAndReset();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 23271, 23301);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1618, 22971, 23328);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1618, 22971, 23328);
            }
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1618, 23894, 25432);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 23983, 24055);

                f_1618_23983_24054(_isEntered, "Stream should be Entered before writing into.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 24071, 24101);

                int
                offsetToReadFrom = offset
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 24115, 24138);

                int
                amountLeft = count
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 24154, 25421) || true) && (amountLeft > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1618, 24154, 25421);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 24209, 24319);

                        int
                        dataLeftInTheFragment = _fragmentSize - FragmentedRemoteObject.HeaderLength - f_1618_24291_24318(_currentFragment)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 24337, 25406) || true) && (dataLeftInTheFragment > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1618, 24337, 25406);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 24408, 24514);

                            int
                            amountToWriteIntoFragment = (DynAbs.Tracing.TraceSender.Conditional_F1(1618, 24440, 24476) || (((amountLeft > dataLeftInTheFragment) && DynAbs.Tracing.TraceSender.Conditional_F2(1618, 24479, 24500)) || DynAbs.Tracing.TraceSender.Conditional_F3(1618, 24503, 24513))) ? dataLeftInTheFragment : amountLeft
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 24536, 24588);

                            amountLeft = amountLeft - amountToWriteIntoFragment;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 24661, 24777);

                            f_1618_24661_24776(buffer, offsetToReadFrom, f_1618_24698_24719(_currentFragment), f_1618_24721_24748(_currentFragment), amountToWriteIntoFragment);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 24799, 24856);

                            _currentFragment.BlobLength += DynAbs.Tracing.TraceSender.TraceInitialMemberAccessWrapper(() => amountToWriteIntoFragment, 1618, 24799, 24826);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 24878, 24924);

                            offsetToReadFrom += amountToWriteIntoFragment;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 25152, 25274) || true) && (amountLeft > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1618, 25152, 25274);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 25220, 25251);

                                f_1618_25220_25250(this);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1618, 25152, 25274);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1618, 24337, 25406);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1618, 24337, 25406);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 25356, 25387);

                            f_1618_25356_25386(this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1618, 24337, 25406);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1618, 24154, 25421);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1618, 24154, 25421);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1618, 24154, 25421);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1618, 23894, 25432);

                int
                f_1618_23983_24054(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 23983, 24054);
                    return 0;
                }


                int
                f_1618_24291_24318(System.Management.Automation.Remoting.FragmentedRemoteObject
                this_param)
                {
                    var return_v = this_param.BlobLength;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 24291, 24318);
                    return return_v;
                }


                byte[]
                f_1618_24698_24719(System.Management.Automation.Remoting.FragmentedRemoteObject
                this_param)
                {
                    var return_v = this_param.Blob;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 24698, 24719);
                    return return_v;
                }


                int
                f_1618_24721_24748(System.Management.Automation.Remoting.FragmentedRemoteObject
                this_param)
                {
                    var return_v = this_param.BlobLength;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 24721, 24748);
                    return return_v;
                }


                int
                f_1618_24661_24776(byte[]
                sourceArray, int
                sourceIndex, byte[]
                destinationArray, int
                destinationIndex, int
                length)
                {
                    Array.Copy((System.Array)sourceArray, sourceIndex, (System.Array)destinationArray, destinationIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 24661, 24776);
                    return 0;
                }


                int
                f_1618_25220_25250(System.Management.Automation.Remoting.SerializedDataStream
                this_param)
                {
                    this_param.WriteCurrentFragmentAndReset();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 25220, 25250);
                    return 0;
                }


                int
                f_1618_25356_25386(System.Management.Automation.Remoting.SerializedDataStream
                this_param)
                {
                    this_param.WriteCurrentFragmentAndReset();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 25356, 25386);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1618, 23894, 25432);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1618, 23894, 25432);
            }
        }

        public override void WriteByte(byte value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1618, 25583, 25841);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 25650, 25722);

                f_1618_25650_25721(_isEntered, "Stream should be Entered before writing into.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 25736, 25764);

                byte[]
                buffer = new byte[1]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 25778, 25796);

                buffer[0] = value;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 25810, 25830);

                f_1618_25810_25829(this, buffer, 0, 1);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1618, 25583, 25841);

                int
                f_1618_25650_25721(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 25650, 25721);
                    return 0;
                }


                int
                f_1618_25810_25829(System.Management.Automation.Remoting.SerializedDataStream
                this_param, byte[]
                buffer, int
                offset, int
                count)
                {
                    this_param.Write(buffer, offset, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 25810, 25829);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1618, 25583, 25841);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1618, 25583, 25841);
            }
        }

        internal byte[] ReadOrRegisterCallback(OnDataAvailableCallback callback)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1618, 26385, 26934);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 26488, 26499);
                lock (_syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 26533, 26680) || true) && (_length <= 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1618, 26533, 26680);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 26591, 26627);

                        _onDataAvailableCallback = callback;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 26649, 26661);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1618, 26533, 26680);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 26700, 26773);

                    int
                    bytesToRead = (DynAbs.Tracing.TraceSender.Conditional_F1(1618, 26718, 26741) || ((_length > _fragmentSize && DynAbs.Tracing.TraceSender.Conditional_F2(1618, 26744, 26757)) || DynAbs.Tracing.TraceSender.Conditional_F3(1618, 26760, 26772))) ? _fragmentSize : (int)_length
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 26791, 26829);

                    byte[]
                    result = new byte[bytesToRead]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 26847, 26876);

                    f_1618_26847_26875(this, result, 0, bytesToRead);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 26894, 26908);

                    return result;
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1618, 26385, 26934);

                int
                f_1618_26847_26875(System.Management.Automation.Remoting.SerializedDataStream
                this_param, byte[]
                buffer, int
                offset, int
                count)
                {
                    var return_v = this_param.Read(buffer, offset, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 26847, 26875);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1618, 26385, 26934);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1618, 26385, 26934);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal byte[] Read()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1618, 27101, 27723);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 27154, 27165);
                lock (_syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 27199, 27287) || true) && (_isDisposed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1618, 27199, 27287);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 27256, 27268);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1618, 27199, 27287);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 27307, 27380);

                    int
                    bytesToRead = (DynAbs.Tracing.TraceSender.Conditional_F1(1618, 27325, 27348) || ((_length > _fragmentSize && DynAbs.Tracing.TraceSender.Conditional_F2(1618, 27351, 27364)) || DynAbs.Tracing.TraceSender.Conditional_F3(1618, 27367, 27379))) ? _fragmentSize : (int)_length
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 27398, 27697) || true) && (bytesToRead > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1618, 27398, 27697);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 27459, 27497);

                        byte[]
                        result = new byte[bytesToRead]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 27519, 27548);

                        f_1618_27519_27547(this, result, 0, bytesToRead);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 27570, 27584);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1618, 27398, 27697);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1618, 27398, 27697);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 27666, 27678);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1618, 27398, 27697);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1618, 27101, 27723);

                int
                f_1618_27519_27547(System.Management.Automation.Remoting.SerializedDataStream
                this_param, byte[]
                buffer, int
                offset, int
                count)
                {
                    var return_v = this_param.Read(buffer, offset, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 27519, 27547);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1618, 27101, 27723);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1618, 27101, 27723);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1618, 27943, 31220);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 28030, 28059);

                int
                offSetToWriteTo = offset
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 28073, 28093);

                int
                dataWritten = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 28107, 28188);

                Collection<MemoryStream>
                memoryStreamsToDispose = f_1618_28157_28187()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 28202, 28237);

                MemoryStream
                prevReadStream = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 28259, 28270);

                lock (_syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 28678, 28763) || true) && (_isDisposed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1618, 28678, 28763);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 28735, 28744);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1618, 28678, 28763);
                    }
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 28783, 30850) || true) && (dataWritten < count)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1618, 28783, 30850);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 28851, 29871) || true) && (_readStream == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1618, 28851, 29871);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 28924, 29715) || true) && (f_1618_28928_28948(_queuedStreams) > 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1618, 28924, 29715);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 29010, 29049);

                                    _readStream = f_1618_29024_29048(_queuedStreams);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 29079, 29547) || true) && ((f_1618_29084_29104_M(!_readStream.CanRead)) || (DynAbs.Tracing.TraceSender.Expression_False(1618, 29083, 29140) || (prevReadStream == _readStream)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1618, 29079, 29547);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 29454, 29473);

                                        _readStream = null;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 29507, 29516);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1618, 29079, 29547);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1618, 28924, 29715);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1618, 28924, 29715);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 29661, 29688);

                                    _readStream = _writeStream;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1618, 28924, 29715);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 29743, 29806);

                                f_1618_29743_29805(f_1618_29754_29772(_readStream) > 0, "Not enough data to read.");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 29832, 29848);

                                _readOffSet = 0;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1618, 28851, 29871);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 29895, 29930);

                            _readStream.Position = _readOffSet;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 29952, 30028);

                            int
                            result = f_1618_29965_30027(_readStream, buffer, offSetToWriteTo, count - dataWritten)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 30050, 30141);

                            f_1618_30050_30140(s_trace, "Read {0} data from readstream: {1}", result, f_1618_30114_30139(_readStream));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 30163, 30185);

                            dataWritten += result;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 30207, 30233);

                            offSetToWriteTo += result;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 30255, 30277);

                            _readOffSet += result;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 30299, 30317);

                            _length -= result;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 30425, 30831) || true) && ((f_1618_30430_30450(_readStream) == _readOffSet) && (DynAbs.Tracing.TraceSender.Expression_True(1618, 30429, 30499) && (_readStream != _writeStream)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1618, 30425, 30831);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 30549, 30642);

                                f_1618_30549_30641(s_trace, "Adding readstream {0} to dispose collection.", f_1618_30615_30640(_readStream));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 30668, 30708);

                                f_1618_30668_30707(memoryStreamsToDispose, _readStream);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 30734, 30763);

                                prevReadStream = _readStream;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 30789, 30808);

                                _readStream = null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1618, 30425, 30831);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1618, 28783, 30850);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1618, 28783, 30850);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1618, 28783, 30850);
                    }
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 30944, 31174);
                    foreach (MemoryStream streamToDispose in f_1618_30985_31007_I(memoryStreamsToDispose))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1618, 30944, 31174);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 31041, 31115);

                        f_1618_31041_31114(s_trace, "Disposing stream: {0}", f_1618_31084_31113(streamToDispose));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 31133, 31159);

                        f_1618_31133_31158(streamToDispose);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1618, 30944, 31174);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1618, 1, 231);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1618, 1, 231);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 31190, 31209);

                return dataWritten;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1618, 27943, 31220);

                System.Collections.ObjectModel.Collection<System.IO.MemoryStream>
                f_1618_28157_28187()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.IO.MemoryStream>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 28157, 28187);
                    return return_v;
                }


                int
                f_1618_28928_28948(System.Collections.Generic.Queue<System.IO.MemoryStream>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 28928, 28948);
                    return return_v;
                }


                System.IO.MemoryStream
                f_1618_29024_29048(System.Collections.Generic.Queue<System.IO.MemoryStream>
                this_param)
                {
                    var return_v = this_param.Dequeue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 29024, 29048);
                    return return_v;
                }


                bool
                f_1618_29084_29104_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 29084, 29104);
                    return return_v;
                }


                long
                f_1618_29754_29772(System.IO.MemoryStream
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 29754, 29772);
                    return return_v;
                }


                int
                f_1618_29743_29805(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 29743, 29805);
                    return 0;
                }


                int
                f_1618_29965_30027(System.IO.MemoryStream
                this_param, byte[]
                buffer, int
                offset, int
                count)
                {
                    var return_v = this_param.Read(buffer, offset, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 29965, 30027);
                    return return_v;
                }


                int
                f_1618_30114_30139(System.IO.MemoryStream
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 30114, 30139);
                    return return_v;
                }


                int
                f_1618_30050_30140(System.Management.Automation.PSTraceSource
                this_param, string
                format, int
                arg1, int
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 30050, 30140);
                    return 0;
                }


                int
                f_1618_30430_30450(System.IO.MemoryStream
                this_param)
                {
                    var return_v = this_param.Capacity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 30430, 30450);
                    return return_v;
                }


                int
                f_1618_30615_30640(System.IO.MemoryStream
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 30615, 30640);
                    return return_v;
                }


                int
                f_1618_30549_30641(System.Management.Automation.PSTraceSource
                this_param, string
                format, int
                arg1)
                {
                    this_param.WriteLine(format, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 30549, 30641);
                    return 0;
                }


                int
                f_1618_30668_30707(System.Collections.ObjectModel.Collection<System.IO.MemoryStream>
                this_param, System.IO.MemoryStream
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 30668, 30707);
                    return 0;
                }


                int
                f_1618_31084_31113(System.IO.MemoryStream
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 31084, 31113);
                    return return_v;
                }


                int
                f_1618_31041_31114(System.Management.Automation.PSTraceSource
                this_param, string
                format, int
                arg1)
                {
                    this_param.WriteLine(format, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 31041, 31114);
                    return 0;
                }


                int
                f_1618_31133_31158(System.IO.MemoryStream
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 31133, 31158);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.IO.MemoryStream>
                f_1618_30985_31007_I(System.Collections.ObjectModel.Collection<System.IO.MemoryStream>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 30985, 31007);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1618, 27943, 31220);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1618, 27943, 31220);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void WriteCurrentFragmentAndReset()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1618, 31232, 34992);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 31342, 31889);

                f_1618_31342_31888(PSEventId.SentRemotingFragment, PSOpcode.Send, PSTask.None, PSKeyword.Transport | PSKeyword.UseAlwaysAnalytic, (f_1618_31541_31566(_currentFragment)), (f_1618_31594_31621(_currentFragment)), (DynAbs.Tracing.TraceSender.Conditional_F1(1618, 31641, 31673) || ((f_1618_31641_31673(_currentFragment) && DynAbs.Tracing.TraceSender.Conditional_F2(1618, 31676, 31677)) || DynAbs.Tracing.TraceSender.Conditional_F3(1618, 31680, 31681))) ? 1 : 0, (DynAbs.Tracing.TraceSender.Conditional_F1(1618, 31700, 31730) || ((f_1618_31700_31730(_currentFragment) && DynAbs.Tracing.TraceSender.Conditional_F2(1618, 31733, 31734)) || DynAbs.Tracing.TraceSender.Conditional_F3(1618, 31737, 31738))) ? 1 : 0, (f_1618_31766_31793(_currentFragment)), f_1618_31813_31887(f_1618_31833_31854(_currentFragment), 0, f_1618_31859_31886(_currentFragment)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 31954, 31996);

                byte[]
                data = f_1618_31968_31995(_currentFragment)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 32010, 32039);

                int
                amountLeft = f_1618_32027_32038(data)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 32053, 32078);

                int
                offSetToReadFrom = 0
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 32349, 34439) || true) && (!_notifyOnWriteFragmentImmediately)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1618, 32349, 34439);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 32427, 32438);
                    lock (_syncObject)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 32874, 32969) || true) && (_isDisposed)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1618, 32874, 32969);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 32939, 32946);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1618, 32874, 32969);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 32993, 33281) || true) && (_writeStream == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1618, 32993, 33281);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 33067, 33114);

                            _writeStream = f_1618_33082_33113(_fragmentSize);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 33140, 33215);

                            f_1618_33140_33214(s_trace, "Created write stream: {0}", f_1618_33187_33213(_writeStream));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 33241, 33258);

                            _writeOffset = 0;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1618, 32993, 33281);
                        }
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 33305, 34405) || true) && (amountLeft > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1618, 33305, 34405);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 33376, 33441);

                                int
                                dataLeftInWriteStream = f_1618_33404_33425(_writeStream) - _writeOffset
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 33467, 33781) || true) && (dataLeftInWriteStream == 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1618, 33467, 33781);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 33642, 33663);

                                    f_1618_33642_33662(this);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 33693, 33754);

                                    dataLeftInWriteStream = f_1618_33717_33738(_writeStream) - _writeOffset;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1618, 33467, 33781);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 33809, 33913);

                                int
                                amountToWriteIntoStream = (DynAbs.Tracing.TraceSender.Conditional_F1(1618, 33839, 33875) || (((amountLeft > dataLeftInWriteStream) && DynAbs.Tracing.TraceSender.Conditional_F2(1618, 33878, 33899)) || DynAbs.Tracing.TraceSender.Conditional_F3(1618, 33902, 33912))) ? dataLeftInWriteStream : amountLeft
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 33939, 33989);

                                amountLeft = amountLeft - amountToWriteIntoStream;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 34054, 34091);

                                _writeStream.Position = _writeOffset;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 34117, 34185);

                                f_1618_34117_34184(_writeStream, data, offSetToReadFrom, amountToWriteIntoStream);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 34211, 34255);

                                offSetToReadFrom += amountToWriteIntoStream;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 34281, 34321);

                                _writeOffset += amountToWriteIntoStream;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 34347, 34382);

                                _length += amountToWriteIntoStream;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1618, 33305, 34405);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1618, 33305, 34405);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1618, 33305, 34405);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1618, 32349, 34439);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 34518, 34666) || true) && (_onDataAvailableCallback != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1618, 34518, 34666);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 34588, 34651);

                    f_1618_34588_34650(this, data, f_1618_34619_34649(_currentFragment));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1618, 34518, 34666);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 34721, 34765);

                _currentFragment.FragmentId = ++_fragmentId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 34779, 34820);

                _currentFragment.IsStartFragment = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 34834, 34873);

                _currentFragment.IsEndFragment = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 34887, 34919);

                _currentFragment.BlobLength = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 34933, 34981);

                _currentFragment.Blob = new byte[_fragmentSize];
                DynAbs.Tracing.TraceSender.TraceExitMethod(1618, 31232, 34992);

                long
                f_1618_31541_31566(System.Management.Automation.Remoting.FragmentedRemoteObject
                this_param)
                {
                    var return_v = this_param.ObjectId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 31541, 31566);
                    return return_v;
                }


                long
                f_1618_31594_31621(System.Management.Automation.Remoting.FragmentedRemoteObject
                this_param)
                {
                    var return_v = this_param.FragmentId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 31594, 31621);
                    return return_v;
                }


                bool
                f_1618_31641_31673(System.Management.Automation.Remoting.FragmentedRemoteObject
                this_param)
                {
                    var return_v = this_param.IsStartFragment;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 31641, 31673);
                    return return_v;
                }


                bool
                f_1618_31700_31730(System.Management.Automation.Remoting.FragmentedRemoteObject
                this_param)
                {
                    var return_v = this_param.IsEndFragment;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 31700, 31730);
                    return return_v;
                }


                int
                f_1618_31766_31793(System.Management.Automation.Remoting.FragmentedRemoteObject
                this_param)
                {
                    var return_v = this_param.BlobLength;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 31766, 31793);
                    return return_v;
                }


                byte[]
                f_1618_31833_31854(System.Management.Automation.Remoting.FragmentedRemoteObject
                this_param)
                {
                    var return_v = this_param.Blob;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 31833, 31854);
                    return return_v;
                }


                int
                f_1618_31859_31886(System.Management.Automation.Remoting.FragmentedRemoteObject
                this_param)
                {
                    var return_v = this_param.BlobLength;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 31859, 31886);
                    return return_v;
                }


                System.Management.Automation.Internal.PSETWBinaryBlob
                f_1618_31813_31887(byte[]
                blob, int
                offset, int
                length)
                {
                    var return_v = new System.Management.Automation.Internal.PSETWBinaryBlob(blob, offset, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 31813, 31887);
                    return return_v;
                }


                int
                f_1618_31342_31888(System.Management.Automation.Internal.PSEventId
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
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 31342, 31888);
                    return 0;
                }


                byte[]
                f_1618_31968_31995(System.Management.Automation.Remoting.FragmentedRemoteObject
                this_param)
                {
                    var return_v = this_param.GetBytes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 31968, 31995);
                    return return_v;
                }


                int
                f_1618_32027_32038(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 32027, 32038);
                    return return_v;
                }


                System.IO.MemoryStream
                f_1618_33082_33113(int
                capacity)
                {
                    var return_v = new System.IO.MemoryStream(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 33082, 33113);
                    return return_v;
                }


                int
                f_1618_33187_33213(System.IO.MemoryStream
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 33187, 33213);
                    return return_v;
                }


                int
                f_1618_33140_33214(System.Management.Automation.PSTraceSource
                this_param, string
                format, int
                arg1)
                {
                    this_param.WriteLine(format, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 33140, 33214);
                    return 0;
                }


                int
                f_1618_33404_33425(System.IO.MemoryStream
                this_param)
                {
                    var return_v = this_param.Capacity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 33404, 33425);
                    return return_v;
                }


                int
                f_1618_33642_33662(System.Management.Automation.Remoting.SerializedDataStream
                this_param)
                {
                    this_param.EnqueueWriteStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 33642, 33662);
                    return 0;
                }


                int
                f_1618_33717_33738(System.IO.MemoryStream
                this_param)
                {
                    var return_v = this_param.Capacity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 33717, 33738);
                    return return_v;
                }


                int
                f_1618_34117_34184(System.IO.MemoryStream
                this_param, byte[]
                buffer, int
                offset, int
                count)
                {
                    this_param.Write(buffer, offset, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 34117, 34184);
                    return 0;
                }


                bool
                f_1618_34619_34649(System.Management.Automation.Remoting.FragmentedRemoteObject
                this_param)
                {
                    var return_v = this_param.IsEndFragment;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 34619, 34649);
                    return return_v;
                }


                int
                f_1618_34588_34650(System.Management.Automation.Remoting.SerializedDataStream
                this_param, byte[]
                data, bool
                isEndFragment)
                {
                    this_param._onDataAvailableCallback(data, isEndFragment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 34588, 34650);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1618, 31232, 34992);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1618, 31232, 34992);
            }
        }

        private void EnqueueWriteStream()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1618, 35004, 35469);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 35062, 35224);

                f_1618_35062_35223(s_trace, "Queuing write stream: {0} Length: {1} Capacity: {2}", f_1618_35152_35178(_writeStream), f_1618_35180_35199(_writeStream), f_1618_35201_35222(_writeStream));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 35238, 35275);

                f_1618_35238_35274(_queuedStreams, _writeStream);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 35291, 35338);

                _writeStream = f_1618_35306_35337(_fragmentSize);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 35352, 35369);

                _writeOffset = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 35383, 35458);

                f_1618_35383_35457(s_trace, "Created write stream: {0}", f_1618_35430_35456(_writeStream));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1618, 35004, 35469);

                int
                f_1618_35152_35178(System.IO.MemoryStream
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 35152, 35178);
                    return return_v;
                }


                long
                f_1618_35180_35199(System.IO.MemoryStream
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 35180, 35199);
                    return return_v;
                }


                int
                f_1618_35201_35222(System.IO.MemoryStream
                this_param)
                {
                    var return_v = this_param.Capacity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 35201, 35222);
                    return return_v;
                }


                int
                f_1618_35062_35223(System.Management.Automation.PSTraceSource
                this_param, string
                format, int
                arg1, long
                arg2, int
                arg3)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2, (object)arg3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 35062, 35223);
                    return 0;
                }


                int
                f_1618_35238_35274(System.Collections.Generic.Queue<System.IO.MemoryStream>
                this_param, System.IO.MemoryStream
                item)
                {
                    this_param.Enqueue(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 35238, 35274);
                    return 0;
                }


                System.IO.MemoryStream
                f_1618_35306_35337(int
                capacity)
                {
                    var return_v = new System.IO.MemoryStream(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 35306, 35337);
                    return return_v;
                }


                int
                f_1618_35430_35456(System.IO.MemoryStream
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 35430, 35456);
                    return return_v;
                }


                int
                f_1618_35383_35457(System.Management.Automation.PSTraceSource
                this_param, string
                format, int
                arg1)
                {
                    this_param.WriteLine(format, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 35383, 35457);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1618, 35004, 35469);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1618, 35004, 35469);
            }
        }

        private static long GetObjectId()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1618, 35684, 35829);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 35742, 35818);

                return f_1618_35749_35817(ref s_objectIdSequenceNumber);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1618, 35684, 35829);

                long
                f_1618_35749_35817(ref long
                location)
                {
                    var return_v = System.Threading.Interlocked.Increment(ref location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 35749, 35817);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1618, 35684, 35829);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1618, 35684, 35829);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void Dispose(bool disposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1618, 35903, 36836);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 35975, 36825) || true) && (disposing)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1618, 35975, 36825);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 36028, 36039);
                    lock (_syncObject)
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 36081, 36407);
                            foreach (MemoryStream streamToDispose in f_1618_36122_36136_I(_queuedStreams))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1618, 36081, 36407);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 36246, 36384) || true) && (f_1618_36250_36273(streamToDispose))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1618, 36246, 36384);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 36331, 36357);

                                    f_1618_36331_36356(streamToDispose);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1618, 36246, 36384);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1618, 36081, 36407);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1618, 1, 327);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1618, 1, 327);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 36431, 36576) || true) && ((_readStream != null) && (DynAbs.Tracing.TraceSender.Expression_True(1618, 36435, 36481) && (f_1618_36461_36480(_readStream))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1618, 36431, 36576);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 36531, 36553);

                            f_1618_36531_36552(_readStream);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1618, 36431, 36576);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 36600, 36748) || true) && ((_writeStream != null) && (DynAbs.Tracing.TraceSender.Expression_True(1618, 36604, 36652) && (f_1618_36631_36651(_writeStream))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1618, 36600, 36748);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 36702, 36725);

                            f_1618_36702_36724(_writeStream);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1618, 36600, 36748);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 36772, 36791);

                        _isDisposed = true;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1618, 35975, 36825);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1618, 35903, 36836);

                bool
                f_1618_36250_36273(System.IO.MemoryStream
                this_param)
                {
                    var return_v = this_param.CanRead;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 36250, 36273);
                    return return_v;
                }


                int
                f_1618_36331_36356(System.IO.MemoryStream
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 36331, 36356);
                    return 0;
                }


                System.Collections.Generic.Queue<System.IO.MemoryStream>
                f_1618_36122_36136_I(System.Collections.Generic.Queue<System.IO.MemoryStream>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 36122, 36136);
                    return return_v;
                }


                bool
                f_1618_36461_36480(System.IO.MemoryStream
                this_param)
                {
                    var return_v = this_param.CanRead;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 36461, 36480);
                    return return_v;
                }


                int
                f_1618_36531_36552(System.IO.MemoryStream
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 36531, 36552);
                    return 0;
                }


                bool
                f_1618_36631_36651(System.IO.MemoryStream
                this_param)
                {
                    var return_v = this_param.CanRead;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 36631, 36651);
                    return return_v;
                }


                int
                f_1618_36702_36724(System.IO.MemoryStream
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 36702, 36724);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1618, 35903, 36836);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1618, 35903, 36836);
            }
        }

        public override bool CanRead
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1618, 36984, 37004);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 36990, 37002);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1618, 36984, 37004);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1618, 36953, 37006);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1618, 36953, 37006);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool CanSeek
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1618, 37094, 37115);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 37100, 37113);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1618, 37094, 37115);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1618, 37063, 37117);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1618, 37063, 37117);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool CanWrite
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1618, 37206, 37226);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 37212, 37224);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1618, 37206, 37226);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1618, 37174, 37228);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1618, 37174, 37228);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override long Length
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1618, 37368, 37391);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 37374, 37389);

                    return _length;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1618, 37368, 37391);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1618, 37338, 37393);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1618, 37338, 37393);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override long Position
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1618, 37504, 37546);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 37510, 37544);

                    throw f_1618_37516_37543();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1618, 37504, 37546);

                    System.NotSupportedException
                    f_1618_37516_37543()
                    {
                        var return_v = new System.NotSupportedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 37516, 37543);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1618, 37450, 37615);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1618, 37450, 37615);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1618, 37562, 37604);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 37568, 37602);

                    throw f_1618_37574_37601();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1618, 37562, 37604);

                    System.NotSupportedException
                    f_1618_37574_37601()
                    {
                        var return_v = new System.NotSupportedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 37574, 37601);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1618, 37450, 37615);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1618, 37450, 37615);
                }
            }
        }

        public override void Flush()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1618, 37758, 37808);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1618, 37758, 37808);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1618, 37758, 37808);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1618, 37758, 37808);
            }
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1618, 37984, 38111);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 38066, 38100);

                throw f_1618_38072_38099();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1618, 37984, 38111);

                System.NotSupportedException
                f_1618_38072_38099()
                {
                    var return_v = new System.NotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 38072, 38099);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1618, 37984, 38111);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1618, 37984, 38111);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void SetLength(long value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1618, 38210, 38322);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 38277, 38311);

                throw f_1618_38283_38310();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1618, 38210, 38322);

                System.NotSupportedException
                f_1618_38283_38310()
                {
                    var return_v = new System.NotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 38283, 38310);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1618, 38210, 38322);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1618, 38210, 38322);
            }
        }

        private bool _disposed;

        public new void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1618, 38438, 38654);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 38488, 38612) || true) && (!_disposed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1618, 38488, 38612);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 38536, 38562);

                    f_1618_38536_38561(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 38580, 38597);

                    _disposed = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1618, 38488, 38612);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 38628, 38643);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Dispose(), 1618, 38628, 38642);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1618, 38438, 38654);

                int
                f_1618_38536_38561(System.Management.Automation.Remoting.SerializedDataStream
                obj)
                {
                    GC.SuppressFinalize((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 38536, 38561);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1618, 38438, 38654);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1618, 38438, 38654);
            }
        }

        static SerializedDataStream()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1618, 18250, 38683);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 18433, 18514);
            s_trace = f_1618_18443_18514("SerializedDataStream", "SerializedDataStream");
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 18581, 18609);
            s_objectIdSequenceNumber = 0;
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1618, 18250, 38683);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1618, 18250, 38683);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1618, 18250, 38683);

        static System.Management.Automation.PSTraceSource
        f_1618_18443_18514(string
        name, string
        description)
        {
            var return_v = PSTraceSource.GetTracer(name, description);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 18443, 18514);
            return return_v;
        }


        int
        f_1618_20461_20549(System.Management.Automation.PSTraceSource
        this_param, string
        format, int
        arg1)
        {
            this_param.WriteLine(format, arg1);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 20461, 20549);
            return 0;
        }


        int
        f_1618_20564_20634(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 20564, 20634);
            return 0;
        }


        object
        f_1618_20663_20675()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 20663, 20675);
            return return_v;
        }


        System.Management.Automation.Remoting.FragmentedRemoteObject
        f_1618_20709_20737()
        {
            var return_v = new System.Management.Automation.Remoting.FragmentedRemoteObject();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 20709, 20737);
            return return_v;
        }


        System.Collections.Generic.Queue<System.IO.MemoryStream>
        f_1618_20769_20794()
        {
            var return_v = new System.Collections.Generic.Queue<System.IO.MemoryStream>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 20769, 20794);
            return return_v;
        }


        static int
        f_1618_21685_21697_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1618, 21575, 21914);
            return return_v;
        }

    }
    internal class Fragmentor
    {
        private static UTF8Encoding s_utf8Encoding;

        private const int
        SerializationDepthForRemoting = 1
        ;

        private int _fragmentSize;

        private SerializationContext _serializationContext;

        internal Fragmentor(int fragmentSize, PSRemotingCryptoHelper cryptoHelper)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1618, 39864, 40439);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 39479, 39492);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 39532, 39553);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 41973, 42036);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 42572, 42614);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 39963, 40032);

                f_1618_39963_40031(fragmentSize > 0, "fragment size cannot be less than 0.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 40046, 40075);

                _fragmentSize = fragmentSize;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 40089, 40273);

                _serializationContext = f_1618_40113_40272(SerializationDepthForRemoting, SerializationOptions.RemotingOptions, cryptoHelper);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 40287, 40428);

                DeserializationContext = f_1618_40312_40427(DeserializationOptions.RemotingOptions, cryptoHelper);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1618, 39864, 40439);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1618, 39864, 40439);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1618, 39864, 40439);
            }
        }

        internal void Fragment<T>(RemoteDataObject<T> obj, SerializedDataStream dataToBeSent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1618, 41254, 41741);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 41364, 41421);

                f_1618_41364_41420(obj != null, "Cannot fragment a null object");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 41435, 41505);

                f_1618_41435_41504(dataToBeSent != null, "SendDataCollection cannot be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 41521, 41542);

                f_1618_41521_41541(
                            dataToBeSent);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 41592, 41626);

                    f_1618_41592_41625(obj, dataToBeSent, this);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1618, 41655, 41730);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 41695, 41715);

                    f_1618_41695_41714(dataToBeSent);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1618, 41655, 41730);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1618, 41254, 41741);

                int
                f_1618_41364_41420(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 41364, 41420);
                    return 0;
                }


                int
                f_1618_41435_41504(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 41435, 41504);
                    return 0;
                }


                int
                f_1618_41521_41541(System.Management.Automation.Remoting.SerializedDataStream
                this_param)
                {
                    this_param.Enter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 41521, 41541);
                    return 0;
                }


                int
                f_1618_41592_41625(System.Management.Automation.Remoting.RemoteDataObject<T>
                this_param, System.Management.Automation.Remoting.SerializedDataStream
                streamToWriteTo, System.Management.Automation.Remoting.Fragmentor
                fragmentor)
                {
                    this_param.Serialize((System.IO.Stream)streamToWriteTo, fragmentor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 41592, 41625);
                    return 0;
                }


                int
                f_1618_41695_41714(System.Management.Automation.Remoting.SerializedDataStream
                this_param)
                {
                    this_param.Exit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 41695, 41714);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1618, 41254, 41741);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1618, 41254, 41741);
            }
        }

        internal DeserializationContext DeserializationContext { get; }

        internal int FragmentSize
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1618, 42199, 42271);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 42235, 42256);

                    return _fragmentSize;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1618, 42199, 42271);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1618, 42149, 42450);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1618, 42149, 42450);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1618, 42287, 42439);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 42323, 42384);

                    f_1618_42323_42383(value > 0, "FragmentSize cannot be less than 0.");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 42402, 42424);

                    _fragmentSize = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1618, 42287, 42439);

                    int
                    f_1618_42323_42383(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Dbg.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 42323, 42383);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1618, 42149, 42450);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1618, 42149, 42450);
                }
            }
        }

        internal TypeTable TypeTable { get; set; }

        internal void SerializeToBytes(object obj, Stream streamToWriteTo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1618, 42727, 43965);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 42818, 42876);

                f_1618_42818_42875(obj != null, "Cannot serialize a null object");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 42890, 42963);

                f_1618_42890_42962(streamToWriteTo != null, "Stream to write to cannot be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 42979, 43035);

                XmlWriterSettings
                xmlSettings = f_1618_43011_43034()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 43049, 43085);

                xmlSettings.CheckCharacters = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 43099, 43126);

                xmlSettings.Indent = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 43274, 43306);

                xmlSettings.CloseOutput = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 43320, 43361);

                xmlSettings.Encoding = f_1618_43343_43360();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 43375, 43426);

                xmlSettings.NewLineHandling = NewLineHandling.None;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 43442, 43480);

                xmlSettings.OmitXmlDeclaration = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 43494, 43551);

                xmlSettings.ConformanceLevel = ConformanceLevel.Fragment;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 43567, 43931);
                using (XmlWriter
                xmlWriter = f_1618_43596_43642(streamToWriteTo, xmlSettings)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 43676, 43749);

                    Serializer
                    serializer = f_1618_43700_43748(xmlWriter, _serializationContext)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 43767, 43800);

                    serializer.TypeTable = f_1618_43790_43799();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 43818, 43844);

                    f_1618_43818_43843(serializer, obj);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 43862, 43880);

                    f_1618_43862_43879(serializer);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 43898, 43916);

                    f_1618_43898_43915(xmlWriter);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1618, 43567, 43931);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 43947, 43954);

                return;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1618, 42727, 43965);

                int
                f_1618_42818_42875(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 42818, 42875);
                    return 0;
                }


                int
                f_1618_42890_42962(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 42890, 42962);
                    return 0;
                }


                System.Xml.XmlWriterSettings
                f_1618_43011_43034()
                {
                    var return_v = new System.Xml.XmlWriterSettings();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 43011, 43034);
                    return return_v;
                }


                System.Text.Encoding
                f_1618_43343_43360()
                {
                    var return_v = UTF8Encoding.UTF8;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 43343, 43360);
                    return return_v;
                }


                System.Xml.XmlWriter
                f_1618_43596_43642(System.IO.Stream
                output, System.Xml.XmlWriterSettings
                settings)
                {
                    var return_v = XmlWriter.Create(output, settings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 43596, 43642);
                    return return_v;
                }


                System.Management.Automation.Serializer
                f_1618_43700_43748(System.Xml.XmlWriter
                writer, System.Management.Automation.SerializationContext
                context)
                {
                    var return_v = new System.Management.Automation.Serializer(writer, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 43700, 43748);
                    return return_v;
                }


                System.Management.Automation.Runspaces.TypeTable
                f_1618_43790_43799()
                {
                    var return_v = TypeTable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 43790, 43799);
                    return return_v;
                }


                int
                f_1618_43818_43843(System.Management.Automation.Serializer
                this_param, object
                source)
                {
                    this_param.Serialize(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 43818, 43843);
                    return 0;
                }


                int
                f_1618_43862_43879(System.Management.Automation.Serializer
                this_param)
                {
                    this_param.Done();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 43862, 43879);
                    return 0;
                }


                int
                f_1618_43898_43915(System.Xml.XmlWriter
                this_param)
                {
                    this_param.Flush();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 43898, 43915);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1618, 42727, 43965);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1618, 42727, 43965);
            }
        }

        internal PSObject DeserializeToPSObject(Stream serializedDataStream)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1618, 44413, 45385);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 44506, 44579);

                f_1618_44506_44578(serializedDataStream != null, "Cannot Deserialize null data");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 44593, 44671);

                f_1618_44593_44670(f_1618_44604_44631(serializedDataStream) != 0, "Cannot Deserialize empty data");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 44687, 44708);

                object
                result = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 44722, 45112);
                using (XmlReader
                xmlReader = f_1618_44751_44838(serializedDataStream, f_1618_44790_44837())
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 44872, 44952);

                    Deserializer
                    deserializer = f_1618_44900_44951(xmlReader, f_1618_44928_44950())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 44970, 45005);

                    deserializer.TypeTable = f_1618_44995_45004();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 45023, 45059);

                    result = f_1618_45032_45058(deserializer);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 45077, 45097);

                    f_1618_45077_45096(deserializer);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1618, 44722, 45112);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 45128, 45323) || true) && (result == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1618, 45128, 45323);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 45216, 45308);

                    throw f_1618_45222_45307(f_1618_45259_45306());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1618, 45128, 45323);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 45339, 45374);

                return f_1618_45346_45373(result);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1618, 44413, 45385);

                int
                f_1618_44506_44578(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 44506, 44578);
                    return 0;
                }


                long
                f_1618_44604_44631(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 44604, 44631);
                    return return_v;
                }


                int
                f_1618_44593_44670(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 44593, 44670);
                    return 0;
                }


                System.Xml.XmlReaderSettings
                f_1618_44790_44837()
                {
                    var return_v = InternalDeserializer.XmlReaderSettingsForCliXml;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 44790, 44837);
                    return return_v;
                }


                System.Xml.XmlReader
                f_1618_44751_44838(System.IO.Stream
                input, System.Xml.XmlReaderSettings
                settings)
                {
                    var return_v = XmlReader.Create(input, settings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 44751, 44838);
                    return return_v;
                }


                System.Management.Automation.DeserializationContext
                f_1618_44928_44950()
                {
                    var return_v = DeserializationContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 44928, 44950);
                    return return_v;
                }


                System.Management.Automation.Deserializer
                f_1618_44900_44951(System.Xml.XmlReader
                reader, System.Management.Automation.DeserializationContext
                context)
                {
                    var return_v = new System.Management.Automation.Deserializer(reader, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 44900, 44951);
                    return return_v;
                }


                System.Management.Automation.Runspaces.TypeTable
                f_1618_44995_45004()
                {
                    var return_v = TypeTable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 44995, 45004);
                    return return_v;
                }


                object
                f_1618_45032_45058(System.Management.Automation.Deserializer
                this_param)
                {
                    var return_v = this_param.Deserialize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 45032, 45058);
                    return return_v;
                }


                bool
                f_1618_45077_45096(System.Management.Automation.Deserializer
                this_param)
                {
                    var return_v = this_param.Done();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 45077, 45096);
                    return return_v;
                }


                string
                f_1618_45259_45306()
                {
                    var return_v = RemotingErrorIdStrings.DeserializedObjectIsNull;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1618, 45259, 45306);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1618_45222_45307(string
                message)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 45222, 45307);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1618_45346_45373(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 45346, 45373);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1618, 44413, 45385);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1618, 44413, 45385);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static Fragmentor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1618, 39135, 45392);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 39239, 39274);
            s_utf8Encoding = f_1618_39256_39274();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1618, 39401, 39434);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1618, 39135, 45392);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1618, 39135, 45392);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1618, 39135, 45392);

        static System.Text.UTF8Encoding
        f_1618_39256_39274()
        {
            var return_v = new System.Text.UTF8Encoding();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 39256, 39274);
            return return_v;
        }


        int
        f_1618_39963_40031(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 39963, 40031);
            return 0;
        }


        System.Management.Automation.SerializationContext
        f_1618_40113_40272(int
        depth, System.Management.Automation.SerializationOptions
        options, System.Management.Automation.Internal.PSRemotingCryptoHelper
        cryptoHelper)
        {
            var return_v = new System.Management.Automation.SerializationContext(depth, options, cryptoHelper);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 40113, 40272);
            return return_v;
        }


        System.Management.Automation.DeserializationContext
        f_1618_40312_40427(System.Management.Automation.DeserializationOptions
        options, System.Management.Automation.Internal.PSRemotingCryptoHelper
        cryptoHelper)
        {
            var return_v = new System.Management.Automation.DeserializationContext(options, cryptoHelper);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1618, 40312, 40427);
            return return_v;
        }

    }
}
