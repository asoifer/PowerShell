// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management.Automation.Configuration;
using System.Management.Automation.Internal;
using System.Management.Automation.Language;
using System.Management.Automation.Runspaces;
using System.Management.Automation.Security;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Principal;
using System.Text;
using System.Threading;
using Microsoft.PowerShell.Commands;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

using TypeTable = System.Management.Automation.Runspaces.TypeTable;

namespace System.Management.Automation
{
    internal static class Utils
    {
        internal static BigInteger AsBigInt(this double d)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1372, 1561, 1593);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 1564, 1593);
                return f_1372_1564_1593(f_1372_1579_1592(d));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1372, 1561, 1593);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 1561, 1593);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 1561, 1593);
            }
            throw new System.Exception("Slicer error: unreachable code");

            double
            f_1372_1579_1592(double
            a)
            {
                var return_v = Math.Round(a);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 1579, 1592);
                return return_v;
            }


            System.Numerics.BigInteger
            f_1372_1564_1593(double
            value)
            {
                var return_v = new System.Numerics.BigInteger(value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 1564, 1593);
                return return_v;
            }

        }

        internal static bool TryCast(BigInteger value, out byte b)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 1606, 1894);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 1689, 1825) || true) && (value < byte.MinValue || (DynAbs.Tracing.TraceSender.Expression_False(1372, 1693, 1739) || byte.MaxValue < value))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 1689, 1825);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 1773, 1779);

                    b = 0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 1797, 1810);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 1689, 1825);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 1841, 1857);

                b = (byte)value;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 1871, 1883);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 1606, 1894);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 1606, 1894);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 1606, 1894);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool TryCast(BigInteger value, out sbyte sb)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 1906, 2201);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 1991, 2130) || true) && (value < sbyte.MinValue || (DynAbs.Tracing.TraceSender.Expression_False(1372, 1995, 2043) || sbyte.MaxValue < value))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 1991, 2130);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 2077, 2084);

                    sb = 0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 2102, 2115);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 1991, 2130);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 2146, 2164);

                sb = (sbyte)value;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 2178, 2190);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 1906, 2201);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 1906, 2201);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 1906, 2201);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool TryCast(BigInteger value, out short s)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 2213, 2505);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 2297, 2435) || true) && (value < short.MinValue || (DynAbs.Tracing.TraceSender.Expression_False(1372, 2301, 2349) || short.MaxValue < value))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 2297, 2435);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 2383, 2389);

                    s = 0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 2407, 2420);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 2297, 2435);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 2451, 2468);

                s = (short)value;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 2482, 2494);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 2213, 2505);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 2213, 2505);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 2213, 2505);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool TryCast(BigInteger value, out ushort us)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 2517, 2816);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 2603, 2744) || true) && (value < ushort.MinValue || (DynAbs.Tracing.TraceSender.Expression_False(1372, 2607, 2657) || ushort.MaxValue < value))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 2603, 2744);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 2691, 2698);

                    us = 0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 2716, 2729);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 2603, 2744);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 2760, 2779);

                us = (ushort)value;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 2793, 2805);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 2517, 2816);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 2517, 2816);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 2517, 2816);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool TryCast(BigInteger value, out int i)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 2828, 3112);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 2910, 3044) || true) && (value < int.MinValue || (DynAbs.Tracing.TraceSender.Expression_False(1372, 2914, 2958) || int.MaxValue < value))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 2910, 3044);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 2992, 2998);

                    i = 0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 3016, 3029);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 2910, 3044);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 3060, 3075);

                i = (int)value;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 3089, 3101);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 2828, 3112);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 2828, 3112);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 2828, 3112);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool TryCast(BigInteger value, out uint u)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 3124, 3412);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 3207, 3343) || true) && (value < uint.MinValue || (DynAbs.Tracing.TraceSender.Expression_False(1372, 3211, 3257) || uint.MaxValue < value))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 3207, 3343);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 3291, 3297);

                    u = 0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 3315, 3328);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 3207, 3343);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 3359, 3375);

                u = (uint)value;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 3389, 3401);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 3124, 3412);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 3124, 3412);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 3124, 3412);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool TryCast(BigInteger value, out long l)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 3424, 3712);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 3507, 3643) || true) && (value < long.MinValue || (DynAbs.Tracing.TraceSender.Expression_False(1372, 3511, 3557) || long.MaxValue < value))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 3507, 3643);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 3591, 3597);

                    l = 0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 3615, 3628);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 3507, 3643);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 3659, 3675);

                l = (long)value;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 3689, 3701);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 3424, 3712);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 3424, 3712);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 3424, 3712);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool TryCast(BigInteger value, out ulong ul)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 3724, 4019);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 3809, 3948) || true) && (value < ulong.MinValue || (DynAbs.Tracing.TraceSender.Expression_False(1372, 3813, 3861) || ulong.MaxValue < value))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 3809, 3948);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 3895, 3902);

                    ul = 0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 3920, 3933);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 3809, 3948);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 3964, 3982);

                ul = (ulong)value;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 3996, 4008);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 3724, 4019);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 3724, 4019);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 3724, 4019);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool TryCast(BigInteger value, out decimal dm)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 4031, 4358);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 4118, 4285) || true) && (value < (BigInteger)decimal.MinValue || (DynAbs.Tracing.TraceSender.Expression_False(1372, 4122, 4198) || (BigInteger)decimal.MaxValue < value))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 4118, 4285);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 4232, 4239);

                    dm = 0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 4257, 4270);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 4118, 4285);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 4301, 4321);

                dm = (decimal)value;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 4335, 4347);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 4031, 4358);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 4031, 4358);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 4031, 4358);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool TryCast(BigInteger value, out double db)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 4370, 4693);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 4456, 4621) || true) && (value < (BigInteger)double.MinValue || (DynAbs.Tracing.TraceSender.Expression_False(1372, 4460, 4534) || (BigInteger)double.MaxValue < value))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 4456, 4621);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 4568, 4575);

                    db = 0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 4593, 4606);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 4456, 4621);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 4637, 4656);

                db = (double)value;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 4670, 4682);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 4370, 4693);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 4370, 4693);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 4370, 4693);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static BigInteger ParseBinary(ReadOnlySpan<char> digits, bool unsigned)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 5375, 9394);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 5480, 6411) || true) && (!unsigned)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 5480, 6411);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 5527, 6396) || true) && (digits[0] == '0')
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 5527, 6396);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 5589, 5605);

                        unsigned = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 5527, 6396);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 5527, 6396);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 5687, 6377);

                        switch (digits.Length)
                        {

                            case 8: // byte
                            case 16: // short
                            case 32: // int
                            case 64: // long
                            case 96: // decimal
                            case int n when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 6049, 6062) || true) && (n >= 128) && (DynAbs.Tracing.TraceSender.Expression_True(1372, 6049, 6062) || true)
                        : // BigInteger
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 5687, 6377);
                                DynAbs.Tracing.TraceSender.TraceBreak(1372, 6107, 6113);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 5687, 6377);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 5687, 6377);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 6302, 6318);

                                unsigned = true;
                                DynAbs.Tracing.TraceSender.TraceBreak(1372, 6348, 6354);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 5687, 6377);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 5527, 6396);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 5480, 6411);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 6491, 6526);

                const int
                MaxStackAllocation = 512
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 6650, 6696);

                int
                outputByteCount = (digits.Length + 7) / 8
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 6710, 6836);

                Span<byte>
                outputBytes = (DynAbs.Tracing.TraceSender.Conditional_F1(1372, 6735, 6772) || ((outputByteCount <= MaxStackAllocation && DynAbs.Tracing.TraceSender.Conditional_F2(1372, 6775, 6807)) || DynAbs.Tracing.TraceSender.Conditional_F3(1372, 6810, 6835))) ? stackalloc byte[outputByteCount] : new byte[outputByteCount]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 6850, 6895);

                int
                outputByteIndex = outputBytes.Length - 1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 7230, 7245);

                int
                byteWalker
                = default(int);
                try
                {
                    for (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 7264, 7294)
   , byteWalker = digits.Length - 1; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 7259, 8823) || true) && (byteWalker >= 7)
   ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 7313, 7328)
   , byteWalker -= 8, DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 7259, 8823))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 7259, 8823);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 8165, 8808);

                        outputBytes[outputByteIndex--] =
                                            (byte)(
                                                ((digits[byteWalker - 7] << 7)
                                                | (digits[byteWalker - 6] << 6)
                                                | (digits[byteWalker - 5] << 5)
                                                | (digits[byteWalker - 4] << 4)
                                                )
                                            | (
                                                ((digits[byteWalker - 3] << 3)
                                                | (digits[byteWalker - 2] << 2)
                                                | (digits[byteWalker - 1] << 1)
                                                | (digits[byteWalker])
                                                ) & 0b1111
                                              )
                                            );
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1372, 1, 1565);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1372, 1, 1565);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 8946, 9291) || true) && (byteWalker >= 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 8946, 9291);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 8999, 9024);

                    int
                    currentByteValue = 0
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 9051, 9056);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 9042, 9202) || true) && (i <= byteWalker)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 9075, 9078)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 9042, 9202))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 9042, 9202);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 9120, 9183);

                            currentByteValue = (currentByteValue << 1) | (digits[i] - '0');
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1372, 1, 161);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1372, 1, 161);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 9222, 9276);

                    outputBytes[outputByteIndex] = (byte)currentByteValue;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 8946, 9291);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 9307, 9383);

                return f_1372_9314_9382(outputBytes, isUnsigned: unsigned, isBigEndian: true);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 5375, 9394);

                System.Numerics.BigInteger
                f_1372_9314_9382(System.Span<byte>
                value, bool
                isUnsigned, bool
                isBigEndian)
                {
                    var return_v = new System.Numerics.BigInteger((System.ReadOnlySpan<byte>)value, isUnsigned: isUnsigned, isBigEndian: isBigEndian);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 9314, 9382);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 5375, 9394);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 5375, 9394);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int CombineHashCodes(int h1, int h2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 9456, 9584);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 9533, 9573);

                return unchecked(((h1 << 5) + h1) ^ h2);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 9456, 9584);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 9456, 9584);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 9456, 9584);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int CombineHashCodes(int h1, int h2, int h3)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 9596, 9746);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 9681, 9735);

                return f_1372_9688_9734(f_1372_9705_9729(h1, h2), h3);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 9596, 9746);

                int
                f_1372_9705_9729(int
                h1, int
                h2)
                {
                    var return_v = CombineHashCodes(h1, h2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 9705, 9729);
                    return return_v;
                }


                int
                f_1372_9688_9734(int
                h1, int
                h2)
                {
                    var return_v = CombineHashCodes(h1, h2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 9688, 9734);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 9596, 9746);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 9596, 9746);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int CombineHashCodes(int h1, int h2, int h3, int h4)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 9758, 9938);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 9851, 9927);

                return f_1372_9858_9926(f_1372_9875_9899(h1, h2), f_1372_9901_9925(h3, h4));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 9758, 9938);

                int
                f_1372_9875_9899(int
                h1, int
                h2)
                {
                    var return_v = CombineHashCodes(h1, h2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 9875, 9899);
                    return return_v;
                }


                int
                f_1372_9901_9925(int
                h1, int
                h2)
                {
                    var return_v = CombineHashCodes(h1, h2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 9901, 9925);
                    return return_v;
                }


                int
                f_1372_9858_9926(int
                h1, int
                h2)
                {
                    var return_v = CombineHashCodes(h1, h2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 9858, 9926);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 9758, 9938);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 9758, 9938);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 9950, 10124);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 10051, 10113);

                return f_1372_10058_10112(f_1372_10075_10107(h1, h2, h3, h4), h5);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 9950, 10124);

                int
                f_1372_10075_10107(int
                h1, int
                h2, int
                h3, int
                h4)
                {
                    var return_v = CombineHashCodes(h1, h2, h3, h4);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 10075, 10107);
                    return return_v;
                }


                int
                f_1372_10058_10112(int
                h1, int
                h2)
                {
                    var return_v = CombineHashCodes(h1, h2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 10058, 10112);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 9950, 10124);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 9950, 10124);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 10136, 10340);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 10245, 10329);

                return f_1372_10252_10328(f_1372_10269_10301(h1, h2, h3, h4), f_1372_10303_10327(h5, h6));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 10136, 10340);

                int
                f_1372_10269_10301(int
                h1, int
                h2, int
                h3, int
                h4)
                {
                    var return_v = CombineHashCodes(h1, h2, h3, h4);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 10269, 10301);
                    return return_v;
                }


                int
                f_1372_10303_10327(int
                h1, int
                h2)
                {
                    var return_v = CombineHashCodes(h1, h2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 10303, 10327);
                    return return_v;
                }


                int
                f_1372_10252_10328(int
                h1, int
                h2)
                {
                    var return_v = CombineHashCodes(h1, h2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 10252, 10328);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 10136, 10340);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 10136, 10340);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6, int h7)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 10352, 10568);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 10469, 10557);

                return f_1372_10476_10556(f_1372_10493_10525(h1, h2, h3, h4), f_1372_10527_10555(h5, h6, h7));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 10352, 10568);

                int
                f_1372_10493_10525(int
                h1, int
                h2, int
                h3, int
                h4)
                {
                    var return_v = CombineHashCodes(h1, h2, h3, h4);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 10493, 10525);
                    return return_v;
                }


                int
                f_1372_10527_10555(int
                h1, int
                h2, int
                h3)
                {
                    var return_v = CombineHashCodes(h1, h2, h3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 10527, 10555);
                    return return_v;
                }


                int
                f_1372_10476_10556(int
                h1, int
                h2)
                {
                    var return_v = CombineHashCodes(h1, h2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 10476, 10556);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 10352, 10568);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 10352, 10568);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6, int h7, int h8)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 10580, 10808);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 10705, 10797);

                return f_1372_10712_10796(f_1372_10729_10761(h1, h2, h3, h4), f_1372_10763_10795(h5, h6, h7, h8));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 10580, 10808);

                int
                f_1372_10729_10761(int
                h1, int
                h2, int
                h3, int
                h4)
                {
                    var return_v = CombineHashCodes(h1, h2, h3, h4);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 10729, 10761);
                    return return_v;
                }


                int
                f_1372_10763_10795(int
                h1, int
                h2, int
                h3, int
                h4)
                {
                    var return_v = CombineHashCodes(h1, h2, h3, h4);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 10763, 10795);
                    return return_v;
                }


                int
                f_1372_10712_10796(int
                h1, int
                h2)
                {
                    var return_v = CombineHashCodes(h1, h2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 10712, 10796);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 10580, 10808);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 10580, 10808);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string[] AllowedEditionValues;

        internal static void CheckKeyArg(byte[] arg, string argName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 11261, 11982);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 11346, 11971) || true) && (arg == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 11346, 11971);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 11395, 11449);

                    throw f_1372_11401_11448(argName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 11346, 11971);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 11346, 11971);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 11714, 11971) || true) && (!((f_1372_11721_11731(arg) == 16) || (DynAbs.Tracing.TraceSender.Expression_False(1372, 11720, 11784) || (f_1372_11767_11777(arg) == 24)) || (DynAbs.Tracing.TraceSender.Expression_False(1372, 11720, 11830) || (f_1372_11813_11823(arg) == 32))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 11714, 11971);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 11865, 11956);

                        throw f_1372_11871_11955(argName, f_1372_11915_11945(), argName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 11714, 11971);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 11346, 11971);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 11261, 11982);

                System.Management.Automation.PSArgumentNullException
                f_1372_11401_11448(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 11401, 11448);
                    return return_v;
                }


                int
                f_1372_11721_11731(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 11721, 11731);
                    return return_v;
                }


                int
                f_1372_11767_11777(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 11767, 11777);
                    return return_v;
                }


                int
                f_1372_11813_11823(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 11813, 11823);
                    return return_v;
                }


                string
                f_1372_11915_11945()
                {
                    var return_v = Serialization.InvalidKeyLength;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 11915, 11945);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1372_11871_11955(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 11871, 11955);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 11261, 11982);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 11261, 11982);
            }
        }

        internal static void CheckArgForNullOrEmpty(string arg, string argName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 12329, 12691);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 12425, 12680) || true) && (arg == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 12425, 12680);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 12474, 12528);

                    throw f_1372_12480_12527(argName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 12425, 12680);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 12425, 12680);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 12562, 12680) || true) && (f_1372_12566_12576(arg) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 12562, 12680);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 12615, 12665);

                        throw f_1372_12621_12664(argName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 12562, 12680);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 12425, 12680);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 12329, 12691);

                System.Management.Automation.PSArgumentNullException
                f_1372_12480_12527(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 12480, 12527);
                    return return_v;
                }


                int
                f_1372_12566_12576(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 12566, 12576);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1372_12621_12664(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 12621, 12664);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 12329, 12691);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 12329, 12691);
            }
        }

        internal static void CheckArgForNull(object arg, string argName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 13029, 13247);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 13118, 13236) || true) && (arg == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 13118, 13236);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 13167, 13221);

                    throw f_1372_13173_13220(argName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 13118, 13236);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 13029, 13247);

                System.Management.Automation.PSArgumentNullException
                f_1372_13173_13220(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 13173, 13220);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 13029, 13247);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 13029, 13247);
            }
        }

        internal static void CheckSecureStringArg(SecureString arg, string argName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 13522, 13751);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 13622, 13740) || true) && (arg == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 13622, 13740);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 13671, 13725);

                    throw f_1372_13677_13724(argName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 13622, 13740);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 13522, 13751);

                System.Management.Automation.PSArgumentNullException
                f_1372_13677_13724(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 13677, 13724);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 13522, 13751);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 13522, 13751);
            }
        }

        [ArchitectureSensitive]
        internal static string GetStringFromSecureString(SecureString ss)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 13763, 14323);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 13886, 13909);

                IntPtr
                p = IntPtr.Zero
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 13923, 13939);

                string
                s = null
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 13991, 14038);

                    p = f_1372_13995_14037(ss);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 14056, 14086);

                    s = f_1372_14060_14085(p);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1372, 14115, 14287);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 14155, 14272) || true) && (p != IntPtr.Zero)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 14155, 14272);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 14217, 14253);

                        f_1372_14217_14252(p);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 14155, 14272);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1372, 14115, 14287);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 14303, 14312);

                return s;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 13763, 14323);

                System.IntPtr
                f_1372_13995_14037(System.Security.SecureString
                s)
                {
                    var return_v = Marshal.SecureStringToCoTaskMemUnicode(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 13995, 14037);
                    return return_v;
                }


                string?
                f_1372_14060_14085(System.IntPtr
                ptr)
                {
                    var return_v = Marshal.PtrToStringUni(ptr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 14060, 14085);
                    return return_v;
                }


                int
                f_1372_14217_14252(System.IntPtr
                s)
                {
                    Marshal.ZeroFreeCoTaskMemUnicode(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 14217, 14252);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 13763, 14323);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 13763, 14323);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static TypeTable GetTypeTableFromExecutionContextTLS()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 14594, 14914);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 14682, 14764);

                ExecutionContext
                ecFromTLS = f_1372_14711_14763()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 14778, 14860) || true) && (ecFromTLS == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 14778, 14860);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 14833, 14845);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 14778, 14860);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 14876, 14903);

                return f_1372_14883_14902(ecFromTLS);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 14594, 14914);

                System.Management.Automation.ExecutionContext
                f_1372_14711_14763()
                {
                    var return_v = Runspaces.LocalPipeline.GetExecutionContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 14711, 14763);
                    return return_v;
                }


                System.Management.Automation.Runspaces.TypeTable
                f_1372_14883_14902(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.TypeTable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 14883, 14902);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 14594, 14914);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 14594, 14914);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string s_pshome;

        internal static string GetApplicationBaseFromRegistry(string shellId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 15105, 16109);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 15199, 15269);

                bool
                wantPsHome = (object)shellId == (object)DefaultPowerShellShellID
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 15283, 15352) || true) && (wantPsHome && (DynAbs.Tracing.TraceSender.Expression_True(1372, 15287, 15317) && s_pshome != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 15283, 15352);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 15336, 15352);

                    return s_pshome;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 15283, 15352);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 15368, 15523);

                string
                engineKeyPath = RegistryStrings.MonadRootKeyPath + "\\" +
                f_1372_15450_15482() + "\\" + RegistryStrings.MonadEngineKey
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 15539, 16070);
                using (RegistryKey
                engineKey = f_1372_15570_15617(Registry.LocalMachine, engineKeyPath)
                )
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 15651, 16055) || true) && (engineKey != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 15651, 16055);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 15714, 15801);

                        var
                        result = f_1372_15727_15790(engineKey, RegistryStrings.MonadEngine_ApplicationBase) as string
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 15823, 15879);

                        result = f_1372_15832_15878(result);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 15901, 15998) || true) && (wantPsHome)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 15901, 15998);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 15942, 15998);

                            f_1372_15942_15997(ref s_pshome, null, result);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 15901, 15998);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 16022, 16036);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 15651, 16055);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1372, 15539, 16070);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 16086, 16098);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 15105, 16109);

                string
                f_1372_15450_15482()
                {
                    var return_v = PSVersionInfo.RegistryVersionKey;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 15450, 15482);
                    return return_v;
                }


                Microsoft.Win32.RegistryKey
                f_1372_15570_15617(Microsoft.Win32.RegistryKey
                this_param, string
                name)
                {
                    var return_v = this_param.OpenSubKey(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 15570, 15617);
                    return return_v;
                }


                object
                f_1372_15727_15790(Microsoft.Win32.RegistryKey
                this_param, string
                name)
                {
                    var return_v = this_param.GetValue(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 15727, 15790);
                    return return_v;
                }


                string
                f_1372_15832_15878(string
                name)
                {
                    var return_v = Environment.ExpandEnvironmentVariables(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 15832, 15878);
                    return return_v;
                }


                string
                f_1372_15942_15997(ref string
                location1, string
                value, string
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 15942, 15997);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 15105, 16109);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 15105, 16109);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string s_windowsPowerShellVersion;

        internal static string GetWindowsPowerShellVersionFromRegistry()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 16411, 17424);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 16500, 16688) || true) && (!f_1372_16505_16579(InternalTestHooks.TestWindowsPowerShellVersionString))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 16500, 16688);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 16613, 16673);

                    return InternalTestHooks.TestWindowsPowerShellVersionString;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 16500, 16688);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 16704, 16825) || true) && (s_windowsPowerShellVersion != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 16704, 16825);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 16776, 16810);

                    return s_windowsPowerShellVersion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 16704, 16825);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 16841, 16996);

                string
                engineKeyPath = RegistryStrings.MonadRootKeyPath + "\\" +
                f_1372_16923_16955() + "\\" + RegistryStrings.MonadEngineKey
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 17012, 17377);
                using (RegistryKey
                engineKey = f_1372_17043_17090(Registry.LocalMachine, engineKeyPath)
                )
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 17124, 17362) || true) && (engineKey != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 17124, 17362);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 17187, 17287);

                        s_windowsPowerShellVersion = f_1372_17216_17276(engineKey, RegistryStrings.MonadEngine_MonadVersion) as string;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 17309, 17343);

                        return s_windowsPowerShellVersion;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 17124, 17362);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1372, 17012, 17377);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 17393, 17413);

                return string.Empty;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 16411, 17424);

                bool
                f_1372_16505_16579(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 16505, 16579);
                    return return_v;
                }


                string
                f_1372_16923_16955()
                {
                    var return_v = PSVersionInfo.RegistryVersionKey;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 16923, 16955);
                    return return_v;
                }


                Microsoft.Win32.RegistryKey
                f_1372_17043_17090(Microsoft.Win32.RegistryKey
                this_param, string
                name)
                {
                    var return_v = this_param.OpenSubKey(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 17043, 17090);
                    return return_v;
                }


                object
                f_1372_17216_17276(Microsoft.Win32.RegistryKey
                this_param, string
                name)
                {
                    var return_v = this_param.GetValue(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 17216, 17276);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 16411, 17424);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 16411, 17424);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string DefaultPowerShellAppBase
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1372, 17492, 17539);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 17495, 17539);
                    return f_1372_17495_17539(DefaultPowerShellShellID);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1372, 17492, 17539);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 17492, 17539);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 17492, 17539);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static string GetApplicationBase(string shellId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 17550, 17820);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 17701, 17747);

                Assembly
                assembly = f_1372_17721_17746(typeof(PSObject))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 17761, 17809);

                return f_1372_17768_17808(f_1372_17790_17807(assembly));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 17550, 17820);

                System.Reflection.Assembly
                f_1372_17721_17746(System.Type
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 17721, 17746);
                    return return_v;
                }


                string
                f_1372_17790_17807(System.Reflection.Assembly
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 17790, 17807);
                    return return_v;
                }


                string?
                f_1372_17768_17808(string
                path)
                {
                    var return_v = Path.GetDirectoryName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 17768, 17808);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 17550, 17820);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 17550, 17820);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string[] s_productFolderDirectories;

        private static string[] GetProductFolderDirectories()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 17895, 18983);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 17973, 18922) || true) && (s_productFolderDirectories == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 17973, 18922);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 18045, 18095);

                    List<string>
                    baseDirectories = f_1372_18076_18094()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 18183, 18231);

                    string
                    appBase = f_1372_18200_18230()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 18249, 18373) || true) && (!f_1372_18254_18283(appBase))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 18249, 18373);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 18325, 18354);

                        f_1372_18325_18353(baseDirectories, appBase);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 18249, 18373);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 18461, 18542);

                    f_1372_18461_18541(                // Now add the two variations of System32
                                    baseDirectories, f_1372_18481_18540(Environment.SpecialFolder.System));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 18560, 18642);

                    string
                    systemX86 = f_1372_18579_18641(Environment.SpecialFolder.SystemX86)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 18660, 18788) || true) && (!f_1372_18665_18696(systemX86))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 18660, 18788);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 18738, 18769);

                        f_1372_18738_18768(baseDirectories, systemX86);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 18660, 18788);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 18814, 18907);

                    f_1372_18814_18906(ref s_productFolderDirectories, f_1372_18874_18899(baseDirectories), null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 17973, 18922);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 18938, 18972);

                return s_productFolderDirectories;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 17895, 18983);

                System.Collections.Generic.List<string>
                f_1372_18076_18094()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 18076, 18094);
                    return return_v;
                }


                string
                f_1372_18200_18230()
                {
                    var return_v = Utils.DefaultPowerShellAppBase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 18200, 18230);
                    return return_v;
                }


                bool
                f_1372_18254_18283(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 18254, 18283);
                    return return_v;
                }


                int
                f_1372_18325_18353(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 18325, 18353);
                    return 0;
                }


                string
                f_1372_18481_18540(System.Environment.SpecialFolder
                folder)
                {
                    var return_v = Environment.GetFolderPath(folder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 18481, 18540);
                    return return_v;
                }


                int
                f_1372_18461_18541(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 18461, 18541);
                    return 0;
                }


                string
                f_1372_18579_18641(System.Environment.SpecialFolder
                folder)
                {
                    var return_v = Environment.GetFolderPath(folder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 18579, 18641);
                    return return_v;
                }


                bool
                f_1372_18665_18696(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 18665, 18696);
                    return return_v;
                }


                int
                f_1372_18738_18768(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 18738, 18768);
                    return 0;
                }


                string[]
                f_1372_18874_18899(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 18874, 18899);
                    return return_v;
                }


                string[]
                f_1372_18814_18906(ref string[]
                location1, string[]
                value, string[]
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 18814, 18906);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 17895, 18983);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 17895, 18983);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsUnderProductFolder(string filePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 19360, 19954);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 19443, 19486);

                FileInfo
                fileInfo = f_1372_19463_19485(filePath)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 19500, 19536);

                string
                filename = f_1372_19518_19535(fileInfo)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 19552, 19613);

                var
                productFolderDirectories = f_1372_19583_19612()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 19636, 19641);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 19627, 19914) || true) && (i < f_1372_19647_19678(productFolderDirectories))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 19680, 19683)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 19627, 19914))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 19627, 19914);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 19717, 19770);

                        string
                        applicationBase = productFolderDirectories[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 19788, 19899) || true) && (f_1372_19792_19864(filename, applicationBase, StringComparison.OrdinalIgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 19788, 19899);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 19887, 19899);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 19788, 19899);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1372, 1, 288);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1372, 1, 288);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 19930, 19943);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 19360, 19954);

                System.IO.FileInfo
                f_1372_19463_19485(string
                fileName)
                {
                    var return_v = new System.IO.FileInfo(fileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 19463, 19485);
                    return return_v;
                }


                string
                f_1372_19518_19535(System.IO.FileInfo
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 19518, 19535);
                    return return_v;
                }


                string[]
                f_1372_19583_19612()
                {
                    var return_v = GetProductFolderDirectories();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 19583, 19612);
                    return return_v;
                }


                int
                f_1372_19647_19678(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 19647, 19678);
                    return return_v;
                }


                bool
                f_1372_19792_19864(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 19792, 19864);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 19360, 19954);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 19360, 19954);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsRunningFromSysWOW64()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 20070, 20203);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 20139, 20192);

                return f_1372_20146_20191(f_1372_20146_20170(), "SysWOW64");
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 20070, 20203);

                string
                f_1372_20146_20170()
                {
                    var return_v = DefaultPowerShellAppBase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 20146, 20170);
                    return return_v;
                }


                bool
                f_1372_20146_20191(string
                this_param, string
                value)
                {
                    var return_v = this_param.Contains(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 20146, 20191);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 20070, 20203);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 20070, 20203);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsWinPEHost()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 20308, 21122);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 20378, 20406);

                RegistryKey
                winPEKey = null
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 20625, 20713);

                    winPEKey = f_1372_20636_20712(Registry.LocalMachine, @"System\CurrentControlSet\Control\MiniNT");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 20733, 20757);

                    return winPEKey != null;
                }
                catch (ArgumentException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1372, 20786, 20815);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1372, 20786, 20815);
                }
                catch (SecurityException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1372, 20829, 20858);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1372, 20829, 20858);
                }
                catch (ObjectDisposedException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1372, 20872, 20907);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1372, 20872, 20907);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1372, 20921, 21076);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 20961, 21061) || true) && (winPEKey != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 20961, 21061);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 21023, 21042);

                        f_1372_21023_21041(winPEKey);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 20961, 21061);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1372, 20921, 21076);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 21098, 21111);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 20308, 21122);

                Microsoft.Win32.RegistryKey
                f_1372_20636_20712(Microsoft.Win32.RegistryKey
                this_param, string
                name)
                {
                    var return_v = this_param.OpenSubKey(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 20636, 20712);
                    return return_v;
                }


                int
                f_1372_21023_21041(Microsoft.Win32.RegistryKey
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 21023, 21041);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 20308, 21122);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 20308, 21122);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string GetCurrentMajorVersion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 21529, 21688);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 21601, 21677);

                return f_1372_21608_21676(f_1372_21608_21637(f_1372_21608_21631()), f_1372_21647_21675());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 21529, 21688);

                System.Version
                f_1372_21608_21631()
                {
                    var return_v = PSVersionInfo.PSVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 21608, 21631);
                    return return_v;
                }


                int
                f_1372_21608_21637(System.Version
                this_param)
                {
                    var return_v = this_param.Major;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 21608, 21637);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1372_21647_21675()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 21647, 21675);
                    return return_v;
                }


                string
                f_1372_21608_21676(int
                this_param, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = this_param.ToString((System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 21608, 21676);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 21529, 21688);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 21529, 21688);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Version StringToVersion(string versionString)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 22135, 23104);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 22272, 22372) || true) && (f_1372_22276_22311(versionString))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 22272, 22372);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 22345, 22357);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 22272, 22372);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 22388, 22405);

                int
                dotCount = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 22419, 22701);
                    foreach (char c in f_1372_22438_22451_I(versionString))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 22419, 22701);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 22485, 22686) || true) && (c == '.')
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 22485, 22686);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 22539, 22550);

                            dotCount++;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 22572, 22667) || true) && (dotCount > 1)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 22572, 22667);
                                DynAbs.Tracing.TraceSender.TraceBreak(1372, 22638, 22644);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 22572, 22667);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 22485, 22686);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 22419, 22701);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1372, 1, 283);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1372, 1, 283);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 22815, 22903) || true) && (dotCount == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 22815, 22903);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 22866, 22888);

                    versionString += ".0";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 22815, 22903);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 22919, 22941);

                Version
                result = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 22955, 23065) || true) && (f_1372_22959_23002(versionString, out result))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 22955, 23065);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 23036, 23050);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 22955, 23065);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 23081, 23093);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 22135, 23104);

                bool
                f_1372_22276_22311(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 22276, 22311);
                    return return_v;
                }


                string
                f_1372_22438_22451_I(string
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 22438, 22451);
                    return return_v;
                }


                bool
                f_1372_22959_23002(string
                input, out System.Version
                result)
                {
                    var return_v = Version.TryParse(input, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 22959, 23002);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 22135, 23104);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 22135, 23104);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsPSVersionSupported(string ver)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 23386, 23636);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 23525, 23569);

                Version
                inputVersion = f_1372_23548_23568(ver)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 23583, 23625);

                return f_1372_23590_23624(inputVersion);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 23386, 23636);

                System.Version
                f_1372_23548_23568(string
                versionString)
                {
                    var return_v = StringToVersion(versionString);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 23548, 23568);
                    return return_v;
                }


                bool
                f_1372_23590_23624(System.Version
                checkVersion)
                {
                    var return_v = IsPSVersionSupported(checkVersion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 23590, 23624);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 23386, 23636);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 23386, 23636);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsPSVersionSupported(Version checkVersion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 23936, 24420);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 24024, 24110) || true) && (checkVersion == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 24024, 24110);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 24082, 24095);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 24024, 24110);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 24126, 24380);
                    foreach (Version compatibleVersion in f_1372_24164_24198_I(f_1372_24164_24198()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 24126, 24380);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 24232, 24365) || true) && (f_1372_24236_24254(checkVersion) == f_1372_24258_24281(compatibleVersion) && (DynAbs.Tracing.TraceSender.Expression_True(1372, 24236, 24330) && f_1372_24285_24303(checkVersion) <= f_1372_24307_24330(compatibleVersion)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 24232, 24365);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 24353, 24365);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 24232, 24365);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 24126, 24380);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1372, 1, 255);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1372, 1, 255);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 24396, 24409);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 23936, 24420);

                System.Version[]
                f_1372_24164_24198()
                {
                    var return_v = PSVersionInfo.PSCompatibleVersions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 24164, 24198);
                    return return_v;
                }


                int
                f_1372_24236_24254(System.Version
                this_param)
                {
                    var return_v = this_param.Major;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 24236, 24254);
                    return return_v;
                }


                int
                f_1372_24258_24281(System.Version
                this_param)
                {
                    var return_v = this_param.Major;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 24258, 24281);
                    return return_v;
                }


                int
                f_1372_24285_24303(System.Version
                this_param)
                {
                    var return_v = this_param.Minor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 24285, 24303);
                    return return_v;
                }


                int
                f_1372_24307_24330(System.Version
                this_param)
                {
                    var return_v = this_param.Minor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 24307, 24330);
                    return return_v;
                }


                System.Version[]
                f_1372_24164_24198_I(System.Version[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 24164, 24198);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 23936, 24420);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 23936, 24420);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsPSEditionSupported(string checkEdition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 24725, 24911);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 24812, 24900);

                return f_1372_24819_24899(f_1372_24819_24842(), checkEdition, StringComparison.OrdinalIgnoreCase);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 24725, 24911);

                string
                f_1372_24819_24842()
                {
                    var return_v = PSVersionInfo.PSEdition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 24819, 24842);
                    return return_v;
                }


                bool
                f_1372_24819_24899(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 24819, 24899);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 24725, 24911);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 24725, 24911);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsPSEditionSupported(IEnumerable<string> editions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 25264, 25693);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 25360, 25410);

                string
                currentPSEdition = f_1372_25386_25409()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 25424, 25653);
                    foreach (string edition in f_1372_25451_25459_I(editions))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 25424, 25653);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 25493, 25638) || true) && (f_1372_25497_25565(currentPSEdition, edition, StringComparison.OrdinalIgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 25493, 25638);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 25607, 25619);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 25493, 25638);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 25424, 25653);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1372, 1, 230);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1372, 1, 230);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 25669, 25682);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 25264, 25693);

                string
                f_1372_25386_25409()
                {
                    var return_v = PSVersionInfo.PSEdition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 25386, 25409);
                    return return_v;
                }


                bool
                f_1372_25497_25565(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 25497, 25565);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1372_25451_25459_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 25451, 25459);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 25264, 25693);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 25264, 25693);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsValidPSEditionValue(string editionValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 25958, 26142);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 26046, 26131);

                return f_1372_26053_26130(AllowedEditionValues, editionValue, f_1372_26097_26129());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 25958, 26142);

                System.StringComparer
                f_1372_26097_26129()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 26097, 26129);
                    return return_v;
                }


                bool
                f_1372_26053_26130(string[]
                source, string
                value, System.StringComparer
                comparer)
                {
                    var return_v = source.Contains<string>(value, (System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 26053, 26130);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 25958, 26142);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 25958, 26142);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal const string
        DefaultPowerShellShellID = "Microsoft.PowerShell"
        ;

        internal const string
        ProductNameForDirectory = "PowerShell"
        ;

        internal static string ModuleDirectory;

        internal static readonly ConfigScope[] SystemWideOnlyConfig;

        internal static readonly ConfigScope[] CurrentUserOnlyConfig;

        internal static readonly ConfigScope[] SystemWideThenCurrentUserConfig;

        internal static readonly ConfigScope[] CurrentUserThenSystemWideConfig;

        internal static T GetPolicySetting<T>(ConfigScope[] preferenceOrder) where T : PolicyBase, new()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 27325, 27895);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 27446, 27462);

                T
                policy = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 27669, 27722);

                policy = f_1372_27678_27721(preferenceOrder);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 27736, 27774) || true) && (policy != null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 27736, 27774);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 27758, 27772);

                    return policy;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 27736, 27774);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 27796, 27856);

                policy = f_1372_27805_27855(preferenceOrder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 27870, 27884);

                return policy;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 27325, 27895);

                T
                f_1372_27678_27721(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = GetPolicySettingFromGPO<T>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 27678, 27721);
                    return return_v;
                }


                T
                f_1372_27805_27855(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = GetPolicySettingFromConfigFile<T>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 27805, 27855);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 27325, 27895);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 27325, 27895);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly ConcurrentDictionary<ConfigScope, PowerShellPolicies> s_cachedPoliciesFromConfigFile;

        private static T GetPolicySettingFromConfigFile<T>(ConfigScope[] preferenceOrder) where T : PolicyBase, new()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 28230, 30806);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 28364, 30767);
                    foreach (ConfigScope scope in f_1372_28394_28409_I(preferenceOrder))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 28364, 30767);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 28443, 28471);

                        PowerShellPolicies
                        policies
                        = default(PowerShellPolicies);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 28489, 29129) || true) && (InternalTestHooks.BypassGroupPolicyCaching)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 28489, 29129);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 28577, 28643);

                            policies = f_1372_28588_28642(PowerShellConfig.Instance, scope);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 28489, 29129);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 28489, 29129);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 28685, 29129) || true) && (!f_1372_28690_28753(s_cachedPoliciesFromConfigFile, scope, out policies))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 28685, 29129);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 28900, 28930);
                                // Use lock here to reduce the contention on accessing the configuration file
                                lock (s_cachedPoliciesFromConfigFile)
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 28980, 29087);

                                    policies = f_1372_28991_29086(s_cachedPoliciesFromConfigFile, scope, PowerShellConfig.Instance.GetPowerShellPolicies);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 28685, 29129);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 28489, 29129);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 29149, 30752) || true) && (policies != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 29149, 30752);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 29211, 29236);

                            PolicyBase
                            result = null
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 29258, 30668);

                            switch (f_1372_29266_29280(typeof(T)))
                            {

                                case nameof(ScriptExecution):
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 29258, 30668);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 29389, 29423);

                                    result = f_1372_29398_29422(policies);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1372, 29453, 29459);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 29258, 30668);

                                case nameof(ScriptBlockLogging):
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 29258, 30668);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 29547, 29584);

                                    result = f_1372_29556_29583(policies);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1372, 29614, 29620);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 29258, 30668);

                                case nameof(ModuleLogging):
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 29258, 30668);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 29703, 29735);

                                    result = f_1372_29712_29734(policies);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1372, 29765, 29771);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 29258, 30668);

                                case nameof(ProtectedEventLogging):
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 29258, 30668);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 29862, 29902);

                                    result = f_1372_29871_29901(policies);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1372, 29932, 29938);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 29258, 30668);

                                case nameof(Transcription):
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 29258, 30668);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 30021, 30053);

                                    result = f_1372_30030_30052(policies);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1372, 30083, 30089);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 29258, 30668);

                                case nameof(UpdatableHelp):
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 29258, 30668);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 30172, 30204);

                                    result = f_1372_30181_30203(policies);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1372, 30234, 30240);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 29258, 30668);

                                case nameof(ConsoleSessionConfiguration):
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 29258, 30668);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 30337, 30383);

                                    result = f_1372_30346_30382(policies);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1372, 30413, 30419);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 29258, 30668);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 29258, 30668);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 30483, 30609);

                                    f_1372_30483_30608(false, "Should be unreachable code. Update this switch block when new PowerShell policy types are added.");
                                    DynAbs.Tracing.TraceSender.TraceBreak(1372, 30639, 30645);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 29258, 30668);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 30692, 30733) || true) && (result != null)
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 30692, 30733);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 30714, 30731);

                                return (T)result;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 30692, 30733);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 29149, 30752);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 28364, 30767);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1372, 1, 2404);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1372, 1, 2404);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 30783, 30795);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 28230, 30806);

                System.Management.Automation.Configuration.PowerShellPolicies
                f_1372_28588_28642(System.Management.Automation.Configuration.PowerShellConfig
                this_param, System.Management.Automation.Configuration.ConfigScope
                scope)
                {
                    var return_v = this_param.GetPowerShellPolicies(scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 28588, 28642);
                    return return_v;
                }


                bool
                f_1372_28690_28753(System.Collections.Concurrent.ConcurrentDictionary<System.Management.Automation.Configuration.ConfigScope, System.Management.Automation.Configuration.PowerShellPolicies>
                this_param, System.Management.Automation.Configuration.ConfigScope
                key, out System.Management.Automation.Configuration.PowerShellPolicies
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 28690, 28753);
                    return return_v;
                }


                System.Management.Automation.Configuration.PowerShellPolicies
                f_1372_28991_29086(System.Collections.Concurrent.ConcurrentDictionary<System.Management.Automation.Configuration.ConfigScope, System.Management.Automation.Configuration.PowerShellPolicies>
                this_param, System.Management.Automation.Configuration.ConfigScope
                key, System.Func<System.Management.Automation.Configuration.ConfigScope, System.Management.Automation.Configuration.PowerShellPolicies>
                valueFactory)
                {
                    var return_v = this_param.GetOrAdd(key, valueFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 28991, 29086);
                    return return_v;
                }


                string
                f_1372_29266_29280(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 29266, 29280);
                    return return_v;
                }


                System.Management.Automation.Configuration.ScriptExecution
                f_1372_29398_29422(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ScriptExecution;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 29398, 29422);
                    return return_v;
                }


                System.Management.Automation.Configuration.ScriptBlockLogging
                f_1372_29556_29583(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ScriptBlockLogging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 29556, 29583);
                    return return_v;
                }


                System.Management.Automation.Configuration.ModuleLogging
                f_1372_29712_29734(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ModuleLogging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 29712, 29734);
                    return return_v;
                }


                System.Management.Automation.Configuration.ProtectedEventLogging
                f_1372_29871_29901(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ProtectedEventLogging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 29871, 29901);
                    return return_v;
                }


                System.Management.Automation.Configuration.Transcription
                f_1372_30030_30052(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.Transcription;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 30030, 30052);
                    return return_v;
                }


                System.Management.Automation.Configuration.UpdatableHelp
                f_1372_30181_30203(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.UpdatableHelp;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 30181, 30203);
                    return return_v;
                }


                System.Management.Automation.Configuration.ConsoleSessionConfiguration
                f_1372_30346_30382(System.Management.Automation.Configuration.PowerShellPolicies
                this_param)
                {
                    var return_v = this_param.ConsoleSessionConfiguration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 30346, 30382);
                    return return_v;
                }


                int
                f_1372_30483_30608(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 30483, 30608);
                    return 0;
                }


                System.Management.Automation.Configuration.ConfigScope[]
                f_1372_28394_28409_I(System.Management.Automation.Configuration.ConfigScope[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 28394, 28409);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 28230, 30806);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 28230, 30806);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly Dictionary<string, string> GroupPolicyKeys;

        private static readonly Dictionary<string, string> WindowsPowershellGroupPolicyKeys;

        private const string
        PolicySettingFallbackKey = "UseWindowsPowerShellPolicySetting"
        ;

        private static readonly ConcurrentDictionary<ConfigScope, ConcurrentDictionary<string, PolicyBase>> s_cachedPoliciesFromRegistry;

        private static readonly Func<ConfigScope, ConcurrentDictionary<string, PolicyBase>> s_subCacheCreationDelegate;

        private static bool TrySetPolicySettingsFromRegistryKey(object instance, Type instanceType, RegistryKey gpoKey)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 33402, 37782);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 33538, 33627);

                var
                properties = f_1372_33555_33626(instanceType, BindingFlags.Instance | BindingFlags.Public)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 33641, 33671);

                bool
                isAnyPropertySet = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 33687, 33732);

                string[]
                valueNames = f_1372_33709_33731(gpoKey)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 33746, 33793);

                string[]
                subKeyNames = f_1372_33769_33792(gpoKey)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 33807, 33923);

                var
                valueNameSet = (DynAbs.Tracing.TraceSender.Conditional_F1(1372, 33826, 33847) || ((f_1372_33826_33843(valueNames) > 0 && DynAbs.Tracing.TraceSender.Conditional_F2(1372, 33850, 33915)) || DynAbs.Tracing.TraceSender.Conditional_F3(1372, 33918, 33922))) ? f_1372_33850_33915(valueNames, f_1372_33882_33914()) : null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 33937, 34056);

                var
                subKeyNameSet = (DynAbs.Tracing.TraceSender.Conditional_F1(1372, 33957, 33979) || ((f_1372_33957_33975(subKeyNames) > 0 && DynAbs.Tracing.TraceSender.Conditional_F2(1372, 33982, 34048)) || DynAbs.Tracing.TraceSender.Conditional_F3(1372, 34051, 34055))) ? f_1372_33982_34048(subKeyNames, f_1372_34015_34047()) : null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 34187, 37731) || true) && ((valueNameSet != null) || (DynAbs.Tracing.TraceSender.Expression_False(1372, 34191, 34240) || (subKeyNameSet != null)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 34187, 37731);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 34274, 37716);
                        foreach (var property in f_1372_34299_34309_I(properties))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 34274, 37716);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 34351, 34386);

                            string
                            settingName = f_1372_34372_34385(property)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 34408, 34439);

                            object
                            rawRegistryValue = null
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 34520, 35167) || true) && (valueNameSet != null && (DynAbs.Tracing.TraceSender.Expression_True(1372, 34524, 34582) && f_1372_34548_34582(valueNameSet, settingName)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 34520, 35167);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 34632, 34680);

                                rawRegistryValue = f_1372_34651_34679(gpoKey, settingName);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 34520, 35167);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 34520, 35167);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 34730, 35167) || true) && (subKeyNameSet != null && (DynAbs.Tracing.TraceSender.Expression_True(1372, 34734, 34794) && f_1372_34759_34794(subKeyNameSet, settingName)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 34730, 35167);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 34844, 35144);
                                    using (RegistryKey
                                    subKey = f_1372_34872_34902(gpoKey, settingName)
                                    )
                                    {

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 34960, 35117) || true) && (subKey != null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 34960, 35117);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 35044, 35086);

                                            rawRegistryValue = f_1372_35063_35085(subKey);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 34960, 35117);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitUsing(1372, 34844, 35144);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 34730, 35167);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 34520, 35167);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 35361, 37697) || true) && (rawRegistryValue != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 35361, 37697);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 35439, 35481);

                                Type
                                propertyType = f_1372_35459_35480(property)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 35507, 35535);

                                object
                                propertyValue = null
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 35563, 37369);

                                switch (propertyType)
                                {

                                    case var _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 35652, 35686) || true) && (propertyType == typeof(bool?)) && (DynAbs.Tracing.TraceSender.Expression_True(1372, 35652, 35686) || true)
                                :
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 35563, 37369);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 35721, 36237) || true) && (rawRegistryValue is int rawIntValue)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 35721, 36237);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 35834, 36202) || true) && (rawIntValue == 1)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 35834, 36202);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 35936, 35957);

                                                propertyValue = true;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 35834, 36202);
                                            }

                                            else
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 35834, 36202);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 36039, 36202) || true) && (rawIntValue == 0)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 36039, 36202);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 36141, 36163);

                                                    propertyValue = false;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 36039, 36202);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 35834, 36202);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 35721, 36237);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceBreak(1372, 36273, 36279);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 35563, 37369);

                                    case var _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 36320, 36355) || true) && (propertyType == typeof(string)) && (DynAbs.Tracing.TraceSender.Expression_True(1372, 36320, 36355) || true)
                                :
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 35563, 37369);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 36390, 36575) || true) && (rawRegistryValue is string rawStringValue)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 36390, 36575);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 36509, 36540);

                                            propertyValue = rawStringValue;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 36390, 36575);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceBreak(1372, 36611, 36617);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 35563, 37369);

                                    case var _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 36658, 36695) || true) && (propertyType == typeof(string[])) && (DynAbs.Tracing.TraceSender.Expression_True(1372, 36658, 36695) || true)
                                :
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 35563, 37369);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 36730, 37162) || true) && (rawRegistryValue is string[] rawStringArrayValue)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 36730, 37162);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 36856, 36892);

                                            propertyValue = rawStringArrayValue;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 36730, 37162);
                                        }

                                        else
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 36730, 37162);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 36966, 37162) || true) && (rawRegistryValue is string stringValue)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 36966, 37162);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 37082, 37127);

                                                propertyValue = new string[] { stringValue };
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 36966, 37162);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 36730, 37162);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceBreak(1372, 37198, 37204);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 35563, 37369);

                                    default:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 35563, 37369);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 37276, 37342);

                                        throw f_1372_37282_37341();
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 35563, 37369);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 37467, 37674) || true) && (propertyValue != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 37467, 37674);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 37550, 37593);

                                    f_1372_37550_37592(property, instance, propertyValue);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 37623, 37647);

                                    isAnyPropertySet = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 37467, 37674);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 35361, 37697);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 34274, 37716);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1372, 1, 3443);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1372, 1, 3443);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 34187, 37731);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 37747, 37771);

                return isAnyPropertySet;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 33402, 37782);

                System.Reflection.PropertyInfo[]
                f_1372_33555_33626(System.Type
                this_param, System.Reflection.BindingFlags
                bindingAttr)
                {
                    var return_v = this_param.GetProperties(bindingAttr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 33555, 33626);
                    return return_v;
                }


                string[]
                f_1372_33709_33731(Microsoft.Win32.RegistryKey
                this_param)
                {
                    var return_v = this_param.GetValueNames();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 33709, 33731);
                    return return_v;
                }


                string[]
                f_1372_33769_33792(Microsoft.Win32.RegistryKey
                this_param)
                {
                    var return_v = this_param.GetSubKeyNames();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 33769, 33792);
                    return return_v;
                }


                int
                f_1372_33826_33843(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 33826, 33843);
                    return return_v;
                }


                System.StringComparer
                f_1372_33882_33914()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 33882, 33914);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_1372_33850_33915(string[]
                collection, System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.HashSet<string>((System.Collections.Generic.IEnumerable<string>)collection, (System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 33850, 33915);
                    return return_v;
                }


                int
                f_1372_33957_33975(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 33957, 33975);
                    return return_v;
                }


                System.StringComparer
                f_1372_34015_34047()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 34015, 34047);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_1372_33982_34048(string[]
                collection, System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.HashSet<string>((System.Collections.Generic.IEnumerable<string>)collection, (System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 33982, 34048);
                    return return_v;
                }


                string
                f_1372_34372_34385(System.Reflection.PropertyInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 34372, 34385);
                    return return_v;
                }


                bool
                f_1372_34548_34582(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 34548, 34582);
                    return return_v;
                }


                object
                f_1372_34651_34679(Microsoft.Win32.RegistryKey
                this_param, string
                name)
                {
                    var return_v = this_param.GetValue(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 34651, 34679);
                    return return_v;
                }


                bool
                f_1372_34759_34794(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 34759, 34794);
                    return return_v;
                }


                Microsoft.Win32.RegistryKey
                f_1372_34872_34902(Microsoft.Win32.RegistryKey
                this_param, string
                name)
                {
                    var return_v = this_param.OpenSubKey(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 34872, 34902);
                    return return_v;
                }


                string[]
                f_1372_35063_35085(Microsoft.Win32.RegistryKey
                this_param)
                {
                    var return_v = this_param.GetValueNames();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 35063, 35085);
                    return return_v;
                }


                System.Type
                f_1372_35459_35480(System.Reflection.PropertyInfo
                this_param)
                {
                    var return_v = this_param.PropertyType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 35459, 35480);
                    return return_v;
                }


                System.Exception
                f_1372_37282_37341()
                {
                    var return_v = System.Management.Automation.Interpreter.Assert.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 37282, 37341);
                    return return_v;
                }


                int
                f_1372_37550_37592(System.Reflection.PropertyInfo
                this_param, object
                obj, object
                value)
                {
                    this_param.SetValue(obj, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 37550, 37592);
                    return 0;
                }


                System.Reflection.PropertyInfo[]
                f_1372_34299_34309_I(System.Reflection.PropertyInfo[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 34299, 34309);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 33402, 37782);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 33402, 37782);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static T GetPolicySettingFromGPOImpl<T>(ConfigScope scope) where T : PolicyBase, new()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 37955, 40425);
                string gpoKeyPath = default(string);
                string winPowershellGpoKeyPath = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 38074, 38097);

                Type
                tType = typeof(T)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 38199, 38300);

                RegistryKey
                rootKey = (DynAbs.Tracing.TraceSender.Conditional_F1(1372, 38221, 38252) || (((scope == ConfigScope.AllUsers) && DynAbs.Tracing.TraceSender.Conditional_F2(1372, 38255, 38276)) || DynAbs.Tracing.TraceSender.Conditional_F3(1372, 38279, 38299))) ? Registry.LocalMachine : Registry.CurrentUser
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 38316, 38379);

                f_1372_38316_38378(
                            GroupPolicyKeys, f_1372_38344_38354(tType), out gpoKeyPath);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 38393, 38522);

                f_1372_38393_38521(gpoKeyPath != null, f_1372_38432_38520("The GPO registry key path should be pre-defined for {0}", f_1372_38509_38519(tType)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 38538, 40414);
                using (RegistryKey
                gpoKey = f_1372_38566_38596(rootKey, gpoKeyPath)
                )
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 38706, 38742) || true) && (gpoKey == null)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 38706, 38742);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 38728, 38740);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 38706, 38742);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 38911, 38979);

                    object
                    tInstance = f_1372_38930_38978(tType, nonPublic: true)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 38997, 39027);

                    bool
                    isAnyPropertySet = false
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 39143, 40248) || true) && ((int)f_1372_39152_39196(gpoKey, PolicySettingFallbackKey, 0) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 39143, 40248);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 39243, 39324);

                        isAnyPropertySet = f_1372_39262_39323(tInstance, tType, gpoKey);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 39143, 40248);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 39143, 40248);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 39518, 39611);

                        f_1372_39518_39610(                    // when PolicySettingFallbackKey flag is set (REG_DWORD "1") use Windows PS policy reg key
                                            WindowsPowershellGroupPolicyKeys, f_1372_39563_39573(tType), out winPowershellGpoKeyPath);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 39633, 39786);

                        f_1372_39633_39785(winPowershellGpoKeyPath != null, f_1372_39685_39784("The Windows PS GPO registry key path should be pre-defined for {0}", f_1372_39773_39783(tType)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 39808, 40229);
                        using (RegistryKey
                        winPowershellGpoKey = f_1372_39849_39892(rootKey, winPowershellGpoKeyPath)
                        )
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 40037, 40086) || true) && (winPowershellGpoKey == null)
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 40037, 40086);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 40072, 40084);

                                return null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 40037, 40086);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 40112, 40206);

                            isAnyPropertySet = f_1372_40131_40205(tInstance, tType, winPowershellGpoKey);
                            DynAbs.Tracing.TraceSender.TraceExitUsing(1372, 39808, 40229);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 39143, 40248);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 40353, 40399);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1372, 40360, 40376) || ((isAnyPropertySet && DynAbs.Tracing.TraceSender.Conditional_F2(1372, 40379, 40391)) || DynAbs.Tracing.TraceSender.Conditional_F3(1372, 40394, 40398))) ? (T)tInstance : null;
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1372, 38538, 40414);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 37955, 40425);

                string
                f_1372_38344_38354(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 38344, 38354);
                    return return_v;
                }


                bool
                f_1372_38316_38378(System.Collections.Generic.Dictionary<string, string>
                this_param, string
                key, out string
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 38316, 38378);
                    return return_v;
                }


                string
                f_1372_38509_38519(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 38509, 38519);
                    return return_v;
                }


                string
                f_1372_38432_38520(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 38432, 38520);
                    return return_v;
                }


                int
                f_1372_38393_38521(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 38393, 38521);
                    return 0;
                }


                Microsoft.Win32.RegistryKey
                f_1372_38566_38596(Microsoft.Win32.RegistryKey
                this_param, string
                name)
                {
                    var return_v = this_param.OpenSubKey(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 38566, 38596);
                    return return_v;
                }


                object?
                f_1372_38930_38978(System.Type
                type, bool
                nonPublic)
                {
                    var return_v = Activator.CreateInstance(type, nonPublic: nonPublic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 38930, 38978);
                    return return_v;
                }


                object
                f_1372_39152_39196(Microsoft.Win32.RegistryKey
                this_param, string
                name, int
                defaultValue)
                {
                    var return_v = this_param.GetValue(name, (object)defaultValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 39152, 39196);
                    return return_v;
                }


                bool
                f_1372_39262_39323(object
                instance, System.Type
                instanceType, Microsoft.Win32.RegistryKey
                gpoKey)
                {
                    var return_v = TrySetPolicySettingsFromRegistryKey(instance, instanceType, gpoKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 39262, 39323);
                    return return_v;
                }


                string
                f_1372_39563_39573(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 39563, 39573);
                    return return_v;
                }


                bool
                f_1372_39518_39610(System.Collections.Generic.Dictionary<string, string>
                this_param, string
                key, out string
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 39518, 39610);
                    return return_v;
                }


                string
                f_1372_39773_39783(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 39773, 39783);
                    return return_v;
                }


                string
                f_1372_39685_39784(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 39685, 39784);
                    return return_v;
                }


                int
                f_1372_39633_39785(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 39633, 39785);
                    return 0;
                }


                Microsoft.Win32.RegistryKey
                f_1372_39849_39892(Microsoft.Win32.RegistryKey
                this_param, string
                name)
                {
                    var return_v = this_param.OpenSubKey(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 39849, 39892);
                    return return_v;
                }


                bool
                f_1372_40131_40205(object
                instance, System.Type
                instanceType, Microsoft.Win32.RegistryKey
                gpoKey)
                {
                    var return_v = TrySetPolicySettingsFromRegistryKey(instance, instanceType, gpoKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 40131, 40205);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 37955, 40425);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 37955, 40425);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static T GetPolicySettingFromGPO<T>(ConfigScope[] preferenceOrder) where T : PolicyBase, new()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 40571, 41559);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 40698, 40723);

                PolicyBase
                policy = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 40737, 40772);

                string
                policyName = f_1372_40757_40771(typeof(T))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 40788, 41520);
                    foreach (ConfigScope scope in f_1372_40818_40833_I(preferenceOrder))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 40788, 41520);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 40867, 41444) || true) && (InternalTestHooks.BypassGroupPolicyCaching)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 40867, 41444);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 40955, 41002);

                            policy = f_1372_40964_41001(scope);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 40867, 41444);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 40867, 41444);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 41084, 41180);

                            var
                            subordinateCache = f_1372_41107_41179(s_cachedPoliciesFromRegistry, scope, s_subCacheCreationDelegate)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 41202, 41425) || true) && (!f_1372_41207_41259(subordinateCache, policyName, out policy))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 41202, 41425);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 41309, 41402);

                                policy = f_1372_41318_41401(subordinateCache, policyName, key => GetPolicySettingFromGPOImpl<T>(scope));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 41202, 41425);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 40867, 41444);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 41464, 41505) || true) && (policy != null)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 41464, 41505);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 41486, 41503);

                            return (T)policy;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 41464, 41505);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 40788, 41520);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1372, 1, 733);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1372, 1, 733);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 41536, 41548);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 40571, 41559);

                string
                f_1372_40757_40771(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 40757, 40771);
                    return return_v;
                }


                T
                f_1372_40964_41001(System.Management.Automation.Configuration.ConfigScope
                scope)
                {
                    var return_v = GetPolicySettingFromGPOImpl<T>(scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 40964, 41001);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.Configuration.PolicyBase>
                f_1372_41107_41179(System.Collections.Concurrent.ConcurrentDictionary<System.Management.Automation.Configuration.ConfigScope, System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.Configuration.PolicyBase>>
                this_param, System.Management.Automation.Configuration.ConfigScope
                key, System.Func<System.Management.Automation.Configuration.ConfigScope, System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.Configuration.PolicyBase>>
                valueFactory)
                {
                    var return_v = this_param.GetOrAdd(key, valueFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 41107, 41179);
                    return return_v;
                }


                bool
                f_1372_41207_41259(System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.Configuration.PolicyBase>
                this_param, string
                key, out System.Management.Automation.Configuration.PolicyBase
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 41207, 41259);
                    return return_v;
                }


                System.Management.Automation.Configuration.PolicyBase
                f_1372_41318_41401(System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.Configuration.PolicyBase>
                this_param, string
                key, System.Func<string, System.Management.Automation.Configuration.PolicyBase>
                valueFactory)
                {
                    var return_v = this_param.GetOrAdd(key, valueFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 41318, 41401);
                    return return_v;
                }


                System.Management.Automation.Configuration.ConfigScope[]
                f_1372_40818_40833_I(System.Management.Automation.Configuration.ConfigScope[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 40818, 40833);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 40571, 41559);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 40571, 41559);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal const string
        ScheduledJobModuleName = "PSScheduledJob"
        ;

        internal static void EnsureModuleLoaded(string module, ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 41742, 43917);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 41847, 43906) || true) && (context != null && (DynAbs.Tracing.TraceSender.Expression_True(1372, 41851, 41923) && !f_1372_41871_41923(f_1372_41871_41906(context), module)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 41847, 43906);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 41957, 42051);

                    List<PSModuleInfo>
                    loadedModules = f_1372_41992_42050(f_1372_41992_42007(context), new string[] { module }, false)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 42071, 43891) || true) && ((loadedModules == null) || (DynAbs.Tracing.TraceSender.Expression_False(1372, 42075, 42128) || (f_1372_42103_42122(loadedModules) == 0)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 42071, 43891);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 42170, 42370);

                        CommandInfo
                        commandInfo = f_1372_42196_42369("Import-Module", typeof(Microsoft.PowerShell.Commands.ImportModuleCommand), null, null, context)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 42392, 42482);

                        var
                        importModuleCommand = f_1372_42418_42481(commandInfo)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 42506, 42554);

                        f_1372_42506_42553(f_1372_42506_42541(context), module);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 42578, 42599);

                        PowerShell
                        ps = null
                        ;

                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 42675, 43356);

                            ps = f_1372_42680_43355(f_1372_42680_43300(f_1372_42680_43241(f_1372_42680_43180(f_1372_42680_43091(f_1372_42680_43006(f_1372_42680_42923(f_1372_42680_42848(f_1372_42680_42789(f_1372_42680_42727(RunspaceMode.CurrentRunspace), importModuleCommand), "Name", module), "Scope", StringLiterals.Global), "ErrorAction", ActionPreference.Ignore), "WarningAction", ActionPreference.Ignore), "InformationAction", ActionPreference.Ignore), "Verbose", false), "Debug", false), "PassThru");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 43384, 43410);

                            f_1372_43384_43409(
                                                    ps);
                        }
                        catch (Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1372, 43455, 43582);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1372, 43455, 43582);
                            // Call-out to user code, catch-all OK
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinally(1372, 43604, 43872);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 43660, 43711);

                            f_1372_43660_43710(f_1372_43660_43695(context), module);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 43737, 43849) || true) && (ps != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 43737, 43849);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 43809, 43822);

                                f_1372_43809_43821(ps);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 43737, 43849);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitFinally(1372, 43604, 43872);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 42071, 43891);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 41847, 43906);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 41742, 43917);

                System.Collections.Generic.HashSet<string>
                f_1372_41871_41906(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.AutoLoadingModuleInProgress;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 41871, 41906);
                    return return_v;
                }


                bool
                f_1372_41871_41923(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 41871, 41923);
                    return return_v;
                }


                System.Management.Automation.ModuleIntrinsics
                f_1372_41992_42007(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Modules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 41992, 42007);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                f_1372_41992_42050(System.Management.Automation.ModuleIntrinsics
                this_param, string[]
                patterns, bool
                all)
                {
                    var return_v = this_param.GetModules(patterns, all);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 41992, 42050);
                    return return_v;
                }


                int
                f_1372_42103_42122(System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 42103, 42122);
                    return return_v;
                }


                System.Management.Automation.CmdletInfo
                f_1372_42196_42369(string
                name, System.Type
                implementingType, string
                helpFile, System.Management.Automation.PSSnapInInfo
                PSSnapin, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new System.Management.Automation.CmdletInfo(name, implementingType, helpFile, PSSnapin, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 42196, 42369);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Command
                f_1372_42418_42481(System.Management.Automation.CommandInfo
                commandInfo)
                {
                    var return_v = new System.Management.Automation.Runspaces.Command(commandInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 42418, 42481);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_1372_42506_42541(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.AutoLoadingModuleInProgress;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 42506, 42541);
                    return return_v;
                }


                bool
                f_1372_42506_42553(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 42506, 42553);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1372_42680_42727(System.Management.Automation.RunspaceMode
                runspace)
                {
                    var return_v = PowerShell.Create(runspace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 42680, 42727);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1372_42680_42789(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.Runspaces.Command
                command)
                {
                    var return_v = this_param.AddCommand(command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 42680, 42789);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1372_42680_42848(System.Management.Automation.PowerShell
                this_param, string
                parameterName, string
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 42680, 42848);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1372_42680_42923(System.Management.Automation.PowerShell
                this_param, string
                parameterName, string
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 42680, 42923);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1372_42680_43006(System.Management.Automation.PowerShell
                this_param, string
                parameterName, System.Management.Automation.ActionPreference
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 42680, 43006);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1372_42680_43091(System.Management.Automation.PowerShell
                this_param, string
                parameterName, System.Management.Automation.ActionPreference
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 42680, 43091);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1372_42680_43180(System.Management.Automation.PowerShell
                this_param, string
                parameterName, System.Management.Automation.ActionPreference
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 42680, 43180);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1372_42680_43241(System.Management.Automation.PowerShell
                this_param, string
                parameterName, bool
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 42680, 43241);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1372_42680_43300(System.Management.Automation.PowerShell
                this_param, string
                parameterName, bool
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 42680, 43300);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1372_42680_43355(System.Management.Automation.PowerShell
                this_param, string
                parameterName)
                {
                    var return_v = this_param.AddParameter(parameterName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 42680, 43355);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSModuleInfo>
                f_1372_43384_43409(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Invoke<System.Management.Automation.PSModuleInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 43384, 43409);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_1372_43660_43695(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.AutoLoadingModuleInProgress;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 43660, 43695);
                    return return_v;
                }


                bool
                f_1372_43660_43710(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Remove(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 43660, 43710);
                    return return_v;
                }


                int
                f_1372_43809_43821(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 43809, 43821);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 41742, 43917);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 41742, 43917);
            }
        }

        internal static List<PSModuleInfo> GetModules(string module, ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 44314, 46440);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 44701, 44788);

                List<PSModuleInfo>
                result = f_1372_44729_44787(f_1372_44729_44744(context), new string[] { module }, false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 44804, 44990);

                CommandInfo
                commandInfo = f_1372_44830_44989("Get-Module", typeof(Microsoft.PowerShell.Commands.GetModuleCommand), null, null, context)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 45004, 45091);

                var
                getModuleCommand = f_1372_45027_45090(commandInfo)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 45107, 45128);

                PowerShell
                ps = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 45178, 45669);

                    ps = f_1372_45183_45668(f_1372_45183_45612(f_1372_45183_45557(f_1372_45183_45500(f_1372_45183_45419(f_1372_45183_45340(f_1372_45183_45285(f_1372_45183_45230(RunspaceMode.CurrentRunspace), getModuleCommand), "Name", module), "ErrorAction", ActionPreference.Ignore), "WarningAction", ActionPreference.Ignore), "Verbose", false), "Debug", false), "ListAvailable");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 45689, 45752);

                    Collection<PSModuleInfo>
                    gmoOutPut = f_1372_45726_45751(ps)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 45770, 46110) || true) && (gmoOutPut != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 45770, 46110);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 45833, 46091) || true) && (result == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 45833, 46091);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 45901, 45943);

                            result = f_1372_45910_45942(gmoOutPut);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 45833, 46091);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 45833, 46091);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 46041, 46068);

                            f_1372_46041_46067(result, gmoOutPut);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 45833, 46091);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 45770, 46110);
                    }
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1372, 46139, 46242);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1372, 46139, 46242);
                    // Call-out to user code, catch-all OK
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1372, 46256, 46399);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 46296, 46384) || true) && (ps != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 46296, 46384);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 46352, 46365);

                        f_1372_46352_46364(ps);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 46296, 46384);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1372, 46256, 46399);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 46415, 46429);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 44314, 46440);

                System.Management.Automation.ModuleIntrinsics
                f_1372_44729_44744(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Modules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 44729, 44744);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                f_1372_44729_44787(System.Management.Automation.ModuleIntrinsics
                this_param, string[]
                patterns, bool
                all)
                {
                    var return_v = this_param.GetModules(patterns, all);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 44729, 44787);
                    return return_v;
                }


                System.Management.Automation.CmdletInfo
                f_1372_44830_44989(string
                name, System.Type
                implementingType, string
                helpFile, System.Management.Automation.PSSnapInInfo
                PSSnapin, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new System.Management.Automation.CmdletInfo(name, implementingType, helpFile, PSSnapin, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 44830, 44989);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Command
                f_1372_45027_45090(System.Management.Automation.CommandInfo
                commandInfo)
                {
                    var return_v = new System.Management.Automation.Runspaces.Command(commandInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 45027, 45090);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1372_45183_45230(System.Management.Automation.RunspaceMode
                runspace)
                {
                    var return_v = PowerShell.Create(runspace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 45183, 45230);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1372_45183_45285(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.Runspaces.Command
                command)
                {
                    var return_v = this_param.AddCommand(command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 45183, 45285);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1372_45183_45340(System.Management.Automation.PowerShell
                this_param, string
                parameterName, string
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 45183, 45340);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1372_45183_45419(System.Management.Automation.PowerShell
                this_param, string
                parameterName, System.Management.Automation.ActionPreference
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 45183, 45419);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1372_45183_45500(System.Management.Automation.PowerShell
                this_param, string
                parameterName, System.Management.Automation.ActionPreference
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 45183, 45500);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1372_45183_45557(System.Management.Automation.PowerShell
                this_param, string
                parameterName, bool
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 45183, 45557);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1372_45183_45612(System.Management.Automation.PowerShell
                this_param, string
                parameterName, bool
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 45183, 45612);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1372_45183_45668(System.Management.Automation.PowerShell
                this_param, string
                parameterName)
                {
                    var return_v = this_param.AddParameter(parameterName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 45183, 45668);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSModuleInfo>
                f_1372_45726_45751(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Invoke<System.Management.Automation.PSModuleInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 45726, 45751);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                f_1372_45910_45942(System.Collections.ObjectModel.Collection<System.Management.Automation.PSModuleInfo>
                source)
                {
                    var return_v = source.ToList<System.Management.Automation.PSModuleInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 45910, 45942);
                    return return_v;
                }


                int
                f_1372_46041_46067(System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                this_param, System.Collections.ObjectModel.Collection<System.Management.Automation.PSModuleInfo>
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<System.Management.Automation.PSModuleInfo>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 46041, 46067);
                    return 0;
                }


                int
                f_1372_46352_46364(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 46352, 46364);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 44314, 46440);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 44314, 46440);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static List<PSModuleInfo> GetModules(ModuleSpecification fullyQualifiedName, ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 46872, 49109);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 47284, 47376);

                List<PSModuleInfo>
                result = f_1372_47312_47375(f_1372_47312_47327(context), new[] { fullyQualifiedName }, false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 47390, 47546);

                CommandInfo
                commandInfo = f_1372_47416_47545("Get-Module", typeof(GetModuleCommand), null, null, context)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 47560, 47618);

                var
                getModuleCommand = f_1372_47583_47617(commandInfo)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 47634, 47655);

                PowerShell
                ps = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 47705, 48307);

                    ps = f_1372_47710_48306(f_1372_47710_48250(f_1372_47710_48195(f_1372_47710_48138(f_1372_47710_48053(f_1372_47710_47972(f_1372_47710_47893(f_1372_47710_47812(f_1372_47710_47757(RunspaceMode.CurrentRunspace), getModuleCommand), "FullyQualifiedName", fullyQualifiedName), "ErrorAction", ActionPreference.Ignore), "WarningAction", ActionPreference.Ignore), "InformationAction", ActionPreference.Ignore), "Verbose", false), "Debug", false), "ListAvailable");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 48327, 48390);

                    Collection<PSModuleInfo>
                    gmoOutput = f_1372_48364_48389(ps)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 48408, 48779) || true) && (gmoOutput != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 48408, 48779);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 48471, 48760) || true) && (result == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 48471, 48760);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 48539, 48567);

                            result = f_1372_48548_48566(gmoOutput);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 48471, 48760);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 48471, 48760);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 48710, 48737);

                            f_1372_48710_48736(                        // append to result
                                                    result, gmoOutput);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 48471, 48760);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 48408, 48779);
                    }
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1372, 48808, 48911);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1372, 48808, 48911);
                    // Call-out to user code, catch-all OK
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1372, 48925, 49068);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 48965, 49053) || true) && (ps != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 48965, 49053);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 49021, 49034);

                        f_1372_49021_49033(ps);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 48965, 49053);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1372, 48925, 49068);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 49084, 49098);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 46872, 49109);

                System.Management.Automation.ModuleIntrinsics
                f_1372_47312_47327(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Modules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 47312, 47327);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                f_1372_47312_47375(System.Management.Automation.ModuleIntrinsics
                this_param, Microsoft.PowerShell.Commands.ModuleSpecification[]
                fullyQualifiedName, bool
                all)
                {
                    var return_v = this_param.GetModules(fullyQualifiedName, all);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 47312, 47375);
                    return return_v;
                }


                System.Management.Automation.CmdletInfo
                f_1372_47416_47545(string
                name, System.Type
                implementingType, string
                helpFile, System.Management.Automation.PSSnapInInfo
                PSSnapin, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new System.Management.Automation.CmdletInfo(name, implementingType, helpFile, PSSnapin, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 47416, 47545);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Command
                f_1372_47583_47617(System.Management.Automation.CommandInfo
                commandInfo)
                {
                    var return_v = new System.Management.Automation.Runspaces.Command(commandInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 47583, 47617);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1372_47710_47757(System.Management.Automation.RunspaceMode
                runspace)
                {
                    var return_v = PowerShell.Create(runspace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 47710, 47757);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1372_47710_47812(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.Runspaces.Command
                command)
                {
                    var return_v = this_param.AddCommand(command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 47710, 47812);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1372_47710_47893(System.Management.Automation.PowerShell
                this_param, string
                parameterName, Microsoft.PowerShell.Commands.ModuleSpecification
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 47710, 47893);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1372_47710_47972(System.Management.Automation.PowerShell
                this_param, string
                parameterName, System.Management.Automation.ActionPreference
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 47710, 47972);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1372_47710_48053(System.Management.Automation.PowerShell
                this_param, string
                parameterName, System.Management.Automation.ActionPreference
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 47710, 48053);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1372_47710_48138(System.Management.Automation.PowerShell
                this_param, string
                parameterName, System.Management.Automation.ActionPreference
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 47710, 48138);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1372_47710_48195(System.Management.Automation.PowerShell
                this_param, string
                parameterName, bool
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 47710, 48195);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1372_47710_48250(System.Management.Automation.PowerShell
                this_param, string
                parameterName, bool
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 47710, 48250);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1372_47710_48306(System.Management.Automation.PowerShell
                this_param, string
                parameterName)
                {
                    var return_v = this_param.AddParameter(parameterName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 47710, 48306);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSModuleInfo>
                f_1372_48364_48389(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Invoke<System.Management.Automation.PSModuleInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 48364, 48389);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                f_1372_48548_48566(System.Collections.ObjectModel.Collection<System.Management.Automation.PSModuleInfo>
                source)
                {
                    var return_v = source.ToList<System.Management.Automation.PSModuleInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 48548, 48566);
                    return return_v;
                }


                int
                f_1372_48710_48736(System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                this_param, System.Collections.ObjectModel.Collection<System.Management.Automation.PSModuleInfo>
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<System.Management.Automation.PSModuleInfo>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 48710, 48736);
                    return 0;
                }


                int
                f_1372_49021_49033(System.Management.Automation.PowerShell
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 49021, 49033);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 46872, 49109);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 46872, 49109);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool TryGetWindowsCurrentIdentity(out WindowsIdentity currentIdentity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 49132, 49510);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 49278, 49325);

                    currentIdentity = f_1372_49296_49324();
                }
                catch (SecurityException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1372, 49354, 49450);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 49412, 49435);

                    currentIdentity = null;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1372, 49354, 49450);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 49466, 49499);

                return (currentIdentity != null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 49132, 49510);

                System.Security.Principal.WindowsIdentity
                f_1372_49296_49324()
                {
                    var return_v = WindowsIdentity.GetCurrent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 49296, 49324);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 49132, 49510);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 49132, 49510);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool TryGetWindowsImpersonatedIdentity(out WindowsIdentity impersonatedIdentity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 49816, 50317);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 49937, 49969);

                WindowsIdentity
                currentIdentity
                = default(WindowsIdentity);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 49983, 50235) || true) && (f_1372_49987_50036(out currentIdentity) && (DynAbs.Tracing.TraceSender.Expression_True(1372, 49987, 50117) && (f_1372_50041_50075(currentIdentity) == TokenImpersonationLevel.Impersonation)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 49983, 50235);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 50151, 50190);

                    impersonatedIdentity = currentIdentity;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 50208, 50220);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 49983, 50235);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 50251, 50279);

                impersonatedIdentity = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 50293, 50306);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 49816, 50317);

                bool
                f_1372_49987_50036(out System.Security.Principal.WindowsIdentity
                currentIdentity)
                {
                    var return_v = TryGetWindowsCurrentIdentity(out currentIdentity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 49987, 50036);
                    return return_v;
                }


                System.Security.Principal.TokenImpersonationLevel
                f_1372_50041_50075(System.Security.Principal.WindowsIdentity
                this_param)
                {
                    var return_v = this_param.ImpersonationLevel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 50041, 50075);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 49816, 50317);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 49816, 50317);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsAdministrator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 50337, 51325);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 50997, 51029);

                WindowsIdentity
                currentIdentity
                = default(WindowsIdentity);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 51043, 51277) || true) && (f_1372_51047_51096(out currentIdentity))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 51043, 51277);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 51130, 51184);

                    var
                    principal = f_1372_51146_51183(currentIdentity)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 51202, 51262);

                    return f_1372_51209_51261(principal, WindowsBuiltInRole.Administrator);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 51043, 51277);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 51293, 51306);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 50337, 51325);

                bool
                f_1372_51047_51096(out System.Security.Principal.WindowsIdentity
                currentIdentity)
                {
                    var return_v = TryGetWindowsCurrentIdentity(out currentIdentity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 51047, 51096);
                    return return_v;
                }


                System.Security.Principal.WindowsPrincipal
                f_1372_51146_51183(System.Security.Principal.WindowsIdentity
                ntIdentity)
                {
                    var return_v = new System.Security.Principal.WindowsPrincipal(ntIdentity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 51146, 51183);
                    return return_v;
                }


                bool
                f_1372_51209_51261(System.Security.Principal.WindowsPrincipal
                this_param, System.Security.Principal.WindowsBuiltInRole
                role)
                {
                    var return_v = this_param.IsInRole(role);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 51209, 51261);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 50337, 51325);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 50337, 51325);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsReservedDeviceName(string destinationPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 51337, 52603);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 51438, 51762);

                string[]
                reservedDeviceNames = { "CON", "PRN", "AUX", "CLOCK$", "NUL",
                                             "COM0", "COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9",
                                             "LPT0", "LPT1", "LPT2", "LPT3", "LPT4", "LPT5", "LPT6", "LPT7", "LPT8", "LPT9" }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 51776, 51831);

                string
                compareName = f_1372_51797_51830(destinationPath)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 51845, 51927);

                string
                noExtensionCompareName = f_1372_51877_51926(destinationPath)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 51943, 52160) || true) && (((f_1372_51949_51967(compareName) < 3) || (DynAbs.Tracing.TraceSender.Expression_False(1372, 51948, 52000) || (f_1372_51977_51995(compareName) > 6))) && (DynAbs.Tracing.TraceSender.Expression_True(1372, 51947, 52098) && ((f_1372_52024_52053(noExtensionCompareName) < 3) || (DynAbs.Tracing.TraceSender.Expression_False(1372, 52023, 52097) || (f_1372_52063_52092(noExtensionCompareName) > 6)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 51943, 52160);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 52132, 52145);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 51943, 52160);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 52176, 52557);
                    foreach (string deviceName in f_1372_52206_52225_I(reservedDeviceNames))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 52176, 52557);

                        if (
                        (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 52259, 52542) || true) && (f_1372_52285_52359(deviceName, compareName, StringComparison.OrdinalIgnoreCase) || (DynAbs.Tracing.TraceSender.Expression_False(1372, 52285, 52469) || f_1372_52384_52469(deviceName, noExtensionCompareName, StringComparison.OrdinalIgnoreCase)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 52259, 52542);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 52511, 52523);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 52259, 52542);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 52176, 52557);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1372, 1, 382);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1372, 1, 382);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 52579, 52592);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 51337, 52603);

                string?
                f_1372_51797_51830(string
                path)
                {
                    var return_v = Path.GetFileName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 51797, 51830);
                    return return_v;
                }


                string?
                f_1372_51877_51926(string
                path)
                {
                    var return_v = Path.GetFileNameWithoutExtension(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 51877, 51926);
                    return return_v;
                }


                int
                f_1372_51949_51967(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 51949, 51967);
                    return return_v;
                }


                int
                f_1372_51977_51995(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 51977, 51995);
                    return return_v;
                }


                int
                f_1372_52024_52053(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 52024, 52053);
                    return return_v;
                }


                int
                f_1372_52063_52092(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 52063, 52092);
                    return return_v;
                }


                bool
                f_1372_52285_52359(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 52285, 52359);
                    return return_v;
                }


                bool
                f_1372_52384_52469(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 52384, 52469);
                    return return_v;
                }


                string[]
                f_1372_52206_52225_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 52206, 52225);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 51337, 52603);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 51337, 52603);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool PathIsUnc(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 52615, 53250);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 52727, 52845) || true) && (f_1372_52731_52757(path) || (DynAbs.Tracing.TraceSender.Expression_False(1372, 52731, 52783) || !f_1372_52762_52783(path, '\\')))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 52727, 52845);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 52817, 52830);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 52727, 52845);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 52999, 53126) || true) && (f_1372_53003_53065(path, @"\\wsl$", StringComparison.OrdinalIgnoreCase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 52999, 53126);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 53099, 53111);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 52999, 53126);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 53142, 53150);

                Uri
                uri
                = default(Uri);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 53164, 53231);

                return f_1372_53171_53217(path, UriKind.Absolute, out uri) && (DynAbs.Tracing.TraceSender.Expression_True(1372, 53171, 53230) && f_1372_53221_53230(uri));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 52615, 53250);

                bool
                f_1372_52731_52757(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 52731, 52757);
                    return return_v;
                }


                bool
                f_1372_52762_52783(string
                this_param, char
                value)
                {
                    var return_v = this_param.StartsWith(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 52762, 52783);
                    return return_v;
                }


                bool
                f_1372_53003_53065(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 53003, 53065);
                    return return_v;
                }


                bool
                f_1372_53171_53217(string
                uriString, System.UriKind
                uriKind, out System.Uri
                result)
                {
                    var return_v = Uri.TryCreate(uriString, uriKind, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 53171, 53217);
                    return return_v;
                }


                bool
                f_1372_53221_53230(System.Uri
                this_param)
                {
                    var return_v = this_param.IsUnc;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 53221, 53230);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 52615, 53250);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 52615, 53250);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static readonly string PowerShellAssemblyStrongNameFormat;

        internal static readonly HashSet<string> PowerShellAssemblies;

        internal static bool IsPowerShellAssembly(string assemblyName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 54123, 54808);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 54210, 54768) || true) && (!f_1372_54215_54254(assemblyName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 54210, 54768);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 54343, 54593);

                    var
                    fixedName = (DynAbs.Tracing.TraceSender.Conditional_F1(1372, 54359, 54462) || ((f_1372_54359_54462(assemblyName, StringLiterals.PowerShellILAssemblyExtension, StringComparison.OrdinalIgnoreCase) && DynAbs.Tracing.TraceSender.Conditional_F2(1372, 54498, 54544)) || DynAbs.Tracing.TraceSender.Conditional_F3(1372, 54580, 54592))) ? f_1372_54498_54544(assemblyName) : assemblyName
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 54613, 54753) || true) && ((fixedName != null) && (DynAbs.Tracing.TraceSender.Expression_True(1372, 54617, 54680) && f_1372_54640_54680(PowerShellAssemblies, fixedName)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 54613, 54753);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 54722, 54734);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 54613, 54753);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 54210, 54768);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 54784, 54797);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 54123, 54808);

                bool
                f_1372_54215_54254(string
                value)
                {
                    var return_v = string.IsNullOrWhiteSpace(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 54215, 54254);
                    return return_v;
                }


                bool
                f_1372_54359_54462(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.EndsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 54359, 54462);
                    return return_v;
                }


                string?
                f_1372_54498_54544(string
                path)
                {
                    var return_v = Path.GetFileNameWithoutExtension(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 54498, 54544);
                    return return_v;
                }


                bool
                f_1372_54640_54680(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 54640, 54680);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 54123, 54808);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 54123, 54808);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string GetPowerShellAssemblyStrongName(string assemblyName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 54820, 55576);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 54920, 55529) || true) && (!f_1372_54925_54964(assemblyName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 54920, 55529);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 55053, 55268);

                    string
                    fixedName = (DynAbs.Tracing.TraceSender.Conditional_F1(1372, 55072, 55137) || ((f_1372_55072_55137(assemblyName, ".dll", StringComparison.OrdinalIgnoreCase) && DynAbs.Tracing.TraceSender.Conditional_F2(1372, 55173, 55219)) || DynAbs.Tracing.TraceSender.Conditional_F3(1372, 55255, 55267))) ? f_1372_55173_55219(assemblyName) : assemblyName
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 55288, 55514) || true) && ((fixedName != null) && (DynAbs.Tracing.TraceSender.Expression_True(1372, 55292, 55355) && f_1372_55315_55355(PowerShellAssemblies, fixedName)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 55288, 55514);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 55397, 55495);

                        return f_1372_55404_55494(f_1372_55418_55446(), PowerShellAssemblyStrongNameFormat, fixedName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 55288, 55514);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 54920, 55529);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 55545, 55565);

                return assemblyName;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 54820, 55576);

                bool
                f_1372_54925_54964(string
                value)
                {
                    var return_v = string.IsNullOrWhiteSpace(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 54925, 54964);
                    return return_v;
                }


                bool
                f_1372_55072_55137(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.EndsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 55072, 55137);
                    return return_v;
                }


                string?
                f_1372_55173_55219(string
                path)
                {
                    var return_v = Path.GetFileNameWithoutExtension(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 55173, 55219);
                    return return_v;
                }


                bool
                f_1372_55315_55355(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 55315, 55355);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1372_55418_55446()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 55418, 55446);
                    return return_v;
                }


                string
                f_1372_55404_55494(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 55404, 55494);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 54820, 55576);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 54820, 55576);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Mutex SafeWaitMutex(Mutex mutex, MutexInitializer initializer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 56018, 56714);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 56157, 56173);

                    f_1372_56157_56172(mutex);
                }
                catch (AbandonedMutexException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1372, 56202, 56674);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 56458, 56479);

                    f_1372_56458_56478(                // If the Mutex has been abandoned, then the process protecting the critical section
                                                       // is no longer valid. We need to release to continue normal operations.
                                    mutex);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 56497, 56528);

                    f_1372_56497_56527(((IDisposable)mutex));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 56603, 56625);

                    mutex = f_1372_56611_56624(initializer);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 56643, 56659);

                    f_1372_56643_56658(mutex);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1372, 56202, 56674);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 56690, 56703);

                return mutex;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 56018, 56714);

                bool
                f_1372_56157_56172(System.Threading.Mutex
                this_param)
                {
                    var return_v = this_param.WaitOne();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 56157, 56172);
                    return return_v;
                }


                int
                f_1372_56458_56478(System.Threading.Mutex
                this_param)
                {
                    this_param.ReleaseMutex();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 56458, 56478);
                    return 0;
                }


                int
                f_1372_56497_56527(System.IDisposable
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 56497, 56527);
                    return 0;
                }


                System.Threading.Mutex
                f_1372_56611_56624(System.Management.Automation.Utils.MutexInitializer
                this_param)
                {
                    var return_v = this_param.Invoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 56611, 56624);
                    return return_v;
                }


                bool
                f_1372_56643_56658(System.Threading.Mutex
                this_param)
                {
                    var return_v = this_param.WaitOne();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 56643, 56658);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 56018, 56714);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 56018, 56714);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal delegate Mutex MutexInitializer();

        internal static bool Succeeded(int hresult)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 56781, 56880);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 56849, 56869);

                return hresult >= 0;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 56781, 56880);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 56781, 56880);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 56781, 56880);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Encoding GetEncoding(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 56947, 59228);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 57021, 57130) || true) && (!f_1372_57026_57043(path))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 57021, 57130);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 57077, 57115);

                    return f_1372_57084_57114();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 57021, 57130);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 57146, 57182);

                byte[]
                initialBytes = new byte[100]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 57196, 57214);

                int
                bytesRead = 0
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 57266, 57555);
                    using (FileStream
                    stream = f_1372_57293_57322(path)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 57364, 57536);
                        using (BinaryReader
                        reader = f_1372_57393_57417(stream)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 57467, 57513);

                            bytesRead = f_1372_57479_57512(reader, initialBytes, 0, 100);
                            DynAbs.Tracing.TraceSender.TraceExitUsing(1372, 57364, 57536);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitUsing(1372, 57266, 57555);
                    }
                }
                catch (IOException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1372, 57584, 57689);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 57636, 57674);

                    return f_1372_57643_57673();
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1372, 57584, 57689);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 57750, 57773);

                string
                preamble = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 57787, 57843);

                Encoding
                foundEncoding = f_1372_57812_57842()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 57859, 58179) || true) && (bytesRead > 3)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 57859, 58179);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 57910, 58006);

                    preamble = f_1372_57921_58005("-", initialBytes[0], initialBytes[1], initialBytes[2], initialBytes[3]);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 58026, 58164) || true) && (f_1372_58030_58082(encodingMap, preamble, out foundEncoding))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 58026, 58164);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 58124, 58145);

                        return foundEncoding;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 58026, 58164);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 57859, 58179);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 58241, 58542) || true) && (bytesRead > 2)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 58241, 58542);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 58292, 58371);

                    preamble = f_1372_58303_58370("-", initialBytes[0], initialBytes[1], initialBytes[2]);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 58389, 58527) || true) && (f_1372_58393_58445(encodingMap, preamble, out foundEncoding))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 58389, 58527);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 58487, 58508);

                        return foundEncoding;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 58389, 58527);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 58241, 58542);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 58602, 58886) || true) && (bytesRead > 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 58602, 58886);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 58653, 58715);

                    preamble = f_1372_58664_58714("-", initialBytes[0], initialBytes[1]);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 58733, 58871) || true) && (f_1372_58737_58789(encodingMap, preamble, out foundEncoding))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 58733, 58871);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 58831, 58852);

                        return foundEncoding;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 58733, 58871);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 58602, 58886);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 58935, 59029);

                string
                initialBytesAsAscii = f_1372_58964_59028(f_1372_58964_58990(), initialBytes, 0, bytesRead)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 59043, 59179) || true) && (f_1372_59047_59101(initialBytesAsAscii, nonPrintableCharacters) >= 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 59043, 59179);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 59140, 59164);

                    return f_1372_59147_59163();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 59043, 59179);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 59195, 59217);

                return f_1372_59202_59216();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 56947, 59228);

                bool
                f_1372_57026_57043(string
                path)
                {
                    var return_v = File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 57026, 57043);
                    return return_v;
                }


                System.Text.Encoding
                f_1372_57084_57114()
                {
                    var return_v = ClrFacade.GetDefaultEncoding();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 57084, 57114);
                    return return_v;
                }


                System.IO.FileStream
                f_1372_57293_57322(string
                path)
                {
                    var return_v = System.IO.File.OpenRead(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 57293, 57322);
                    return return_v;
                }


                System.IO.BinaryReader
                f_1372_57393_57417(System.IO.FileStream
                input)
                {
                    var return_v = new System.IO.BinaryReader((System.IO.Stream)input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 57393, 57417);
                    return return_v;
                }


                int
                f_1372_57479_57512(System.IO.BinaryReader
                this_param, byte[]
                buffer, int
                index, int
                count)
                {
                    var return_v = this_param.Read(buffer, index, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 57479, 57512);
                    return return_v;
                }


                System.Text.Encoding
                f_1372_57643_57673()
                {
                    var return_v = ClrFacade.GetDefaultEncoding();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 57643, 57673);
                    return return_v;
                }


                System.Text.Encoding
                f_1372_57812_57842()
                {
                    var return_v = ClrFacade.GetDefaultEncoding();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 57812, 57842);
                    return return_v;
                }


                string
                f_1372_57921_58005(string
                separator, params object?[]
                values)
                {
                    var return_v = string.Join(separator, values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 57921, 58005);
                    return return_v;
                }


                bool
                f_1372_58030_58082(System.Collections.Generic.Dictionary<string, System.Text.Encoding>
                this_param, string
                key, out System.Text.Encoding
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 58030, 58082);
                    return return_v;
                }


                string
                f_1372_58303_58370(string
                separator, params object?[]
                values)
                {
                    var return_v = string.Join(separator, values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 58303, 58370);
                    return return_v;
                }


                bool
                f_1372_58393_58445(System.Collections.Generic.Dictionary<string, System.Text.Encoding>
                this_param, string
                key, out System.Text.Encoding
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 58393, 58445);
                    return return_v;
                }


                string
                f_1372_58664_58714(string
                separator, params object?[]
                values)
                {
                    var return_v = string.Join(separator, values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 58664, 58714);
                    return return_v;
                }


                bool
                f_1372_58737_58789(System.Collections.Generic.Dictionary<string, System.Text.Encoding>
                this_param, string
                key, out System.Text.Encoding
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 58737, 58789);
                    return return_v;
                }


                System.Text.Encoding
                f_1372_58964_58990()
                {
                    var return_v = System.Text.Encoding.ASCII;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 58964, 58990);
                    return return_v;
                }


                string
                f_1372_58964_59028(System.Text.Encoding
                this_param, byte[]
                bytes, int
                index, int
                count)
                {
                    var return_v = this_param.GetString(bytes, index, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 58964, 59028);
                    return return_v;
                }


                int
                f_1372_59047_59101(string
                this_param, char[]
                anyOf)
                {
                    var return_v = this_param.IndexOfAny(anyOf);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 59047, 59101);
                    return return_v;
                }


                System.Text.Encoding
                f_1372_59147_59163()
                {
                    var return_v = Encoding.Unicode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 59147, 59163);
                    return return_v;
                }


                System.Text.Encoding
                f_1372_59202_59216()
                {
                    var return_v = Encoding.ASCII;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 59202, 59216);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 56947, 59228);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 56947, 59228);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Encoding BigEndianUTF32Encoding;

        internal static Dictionary<string, Encoding> encodingMap;

        internal static char[] nonPrintableCharacters;

        internal static readonly UTF8Encoding utf8NoBom;

        internal static void QueueWorkItemWithImpersonation(
                    WindowsIdentity identityToImpersonate,
                    WaitCallback threadProc,
                    object state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 61113, 61536);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 61307, 61337);

                object[]
                args = new object[3]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 61351, 61383);

                args[0] = identityToImpersonate;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 61397, 61418);

                args[1] = threadProc;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 61432, 61448);

                args[2] = state;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 61462, 61525);

                f_1372_61462_61524(WorkItemCallback, args);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 61113, 61536);

                bool
                f_1372_61462_61524(System.Threading.WaitCallback
                callBack, object[]
                state)
                {
                    var return_v = Threading.ThreadPool.QueueUserWorkItem(callBack, (object)state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 61462, 61524);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 61113, 61536);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 61113, 61536);
            }
        }

        private static void WorkItemCallback(object callBackArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 61548, 62150);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 61630, 61671);

                object[]
                args = callBackArgs as object[]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 61685, 61752);

                WindowsIdentity
                identityToImpersonate = args[0] as WindowsIdentity
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 61766, 61814);

                WaitCallback
                callback = args[1] as WaitCallback
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 61828, 61851);

                object
                state = args[2]
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 61867, 62107) || true) && (identityToImpersonate != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 61867, 62107);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 61934, 62067);

                    f_1372_61934_62066(f_1372_61988_62021(identityToImpersonate), () => callback(state));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 62085, 62092);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 61867, 62107);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 62123, 62139);

                f_1372_62123_62138(callback, state);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 61548, 62150);

                Microsoft.Win32.SafeHandles.SafeAccessTokenHandle
                f_1372_61988_62021(System.Security.Principal.WindowsIdentity
                this_param)
                {
                    var return_v = this_param.AccessToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 61988, 62021);
                    return return_v;
                }


                int
                f_1372_61934_62066(Microsoft.Win32.SafeHandles.SafeAccessTokenHandle
                safeAccessTokenHandle, System.Action
                action)
                {
                    WindowsIdentity.RunImpersonated(safeAccessTokenHandle, action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 61934, 62066);
                    return 0;
                }


                int
                f_1372_62123_62138(System.Threading.WaitCallback
                this_param, object
                state)
                {
                    this_param.Invoke(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 62123, 62138);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 61548, 62150);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 61548, 62150);
            }
        }

        internal static string ParseCommandName(string commandName, out string moduleName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 62543, 62923);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 62650, 62705);

                var
                names = f_1372_62662_62704(commandName, Separators.Backslash, 2)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 62719, 62845) || true) && (f_1372_62723_62735(names) == 2)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 62719, 62845);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 62774, 62796);

                    moduleName = names[0];
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 62814, 62830);

                    return names[1];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 62719, 62845);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 62861, 62879);

                moduleName = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 62893, 62912);

                return commandName;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 62543, 62923);

                string[]
                f_1372_62662_62704(string
                this_param, char[]
                separator, int
                count)
                {
                    var return_v = this_param.Split(separator, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 62662, 62704);
                    return return_v;
                }


                int
                f_1372_62723_62735(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 62723, 62735);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 62543, 62923);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 62543, 62923);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ReadOnlyCollection<T> EmptyReadOnlyCollection<T>()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 62935, 63087);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 63026, 63076);

                return EmptyReadOnlyCollectionHolder<T>._instance;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 62935, 63087);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 62935, 63087);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 62935, 63087);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private static class EmptyReadOnlyCollectionHolder<T>
        {
            internal static readonly ReadOnlyCollection<T> _instance;

            static EmptyReadOnlyCollectionHolder()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1372, 63099, 63308);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 63224, 63296);
                _instance = f_1372_63253_63296(f_1372_63279_63295());
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1372, 63099, 63308);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 63099, 63308);
            }


            static T[]
            f_1372_63279_63295()
            {
                var return_v = Array.Empty<T>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 63279, 63295);
                return return_v;
            }


            static System.Collections.ObjectModel.ReadOnlyCollection<T>
            f_1372_63253_63296(T[]
            list)
            {
                var return_v = new System.Collections.ObjectModel.ReadOnlyCollection<T>((System.Collections.Generic.IList<T>)list);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 63253, 63296);
                return return_v;
            }

        }
        internal static class Separators
        {
            internal static readonly char[] Backslash;

            internal static readonly char[] Directory;

            internal static readonly char[] DirectoryOrDrive;

            internal static readonly char[] Colon;

            internal static readonly char[] Dot;

            internal static readonly char[] Pipe;

            internal static readonly char[] Comma;

            internal static readonly char[] Semicolon;

            internal static readonly char[] StarOrQuestion;

            internal static readonly char[] ColonOrBackslash;

            internal static readonly char[] PathSeparator;

            internal static readonly char[] QuoteChars;

            internal static readonly char[] Space;

            internal static readonly char[] QuotesSpaceOrTab;

            internal static readonly char[] SpaceOrTab;

            internal static readonly char[] Newline;

            internal static readonly char[] CrLf;

            internal static readonly char[] PathSearchTrimEnd;

            static Separators()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1372, 63320, 65336);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 63409, 63440);
                Backslash = new char[] { '\\' };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 63487, 63523);
                Directory = new char[] { '\\', '/' };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 63570, 63618);
                DirectoryOrDrive = new char[] { '\\', '/', ':' };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 63667, 63693);
                Colon = new char[] { ':' };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 63740, 63764);
                Dot = new char[] { '.' };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 63811, 63836);
                Pipe = new char[] { '|' };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 63883, 63909);
                Comma = new char[] { ',' };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 63956, 63986);
                Semicolon = new char[] { ';' };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 64033, 64073);
                StarOrQuestion = new char[] { '*', '?' };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 64120, 64163);
                ColonOrBackslash = new char[] { '\\', ':' };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 64210, 64259);
                PathSeparator = new char[] { Path.PathSeparator };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 64308, 64345);
                QuoteChars = new char[] { '\'', '"' };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 64392, 64418);
                Space = new char[] { ' ' };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 64465, 64519);
                QuotesSpaceOrTab = new char[] { ' ', '\t', '\'', '"' };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 64566, 64603);
                SpaceOrTab = new char[] { ' ', '\t' };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 64650, 64679);
                Newline = new char[] { '\n' };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 64726, 64758);
                CrLf = new char[] { '\r', '\n' };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 65211, 65324);
                PathSearchTrimEnd = new char[] { (char)0x9, (char)0xA, (char)0xB, (char)0xC, (char)0xD, (char)0x20, (char)0x85, (char)0xA0 };
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1372, 63320, 65336);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 63320, 65336);
            }

        }

        internal static bool IsComObject(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 66369, 66548);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 66482, 66529);

                return obj != null && (DynAbs.Tracing.TraceSender.Expression_True(1372, 66489, 66528) && f_1372_66504_66528(obj));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 66369, 66548);

                bool
                f_1372_66504_66528(object
                o)
                {
                    var return_v = Marshal.IsComObject(o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 66504, 66528);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 66369, 66548);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 66369, 66548);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static PSLanguageMode? EnforceSystemLockDownLanguageMode(ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 67034, 68311);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 67150, 67181);

                PSLanguageMode?
                oldMode = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 67197, 68269) || true) && (f_1372_67201_67239() == SystemEnforcementMode.Enforce)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 67197, 68269);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 67306, 68254);

                    switch (f_1372_67314_67334(context))
                    {

                        case PSLanguageMode.FullLanguage:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 67306, 68254);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 67435, 67466);

                            oldMode = f_1372_67445_67465(context);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 67492, 67550);

                            context.LanguageMode = PSLanguageMode.ConstrainedLanguage;
                            DynAbs.Tracing.TraceSender.TraceBreak(1372, 67576, 67582);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 67306, 68254);

                        case PSLanguageMode.RestrictedLanguage:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 67306, 68254);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 67671, 67702);

                            oldMode = f_1372_67681_67701(context);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 67728, 67777);

                            context.LanguageMode = PSLanguageMode.NoLanguage;
                            DynAbs.Tracing.TraceSender.TraceBreak(1372, 67803, 67809);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 67306, 68254);

                        case PSLanguageMode.ConstrainedLanguage:
                        case PSLanguageMode.NoLanguage:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 67306, 68254);
                            DynAbs.Tracing.TraceSender.TraceBreak(1372, 67952, 67958);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 67306, 68254);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 67306, 68254);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 68016, 68071);

                            f_1372_68016_68070(false, "Unexpected PSLanguageMode");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 68097, 68128);

                            oldMode = f_1372_68107_68127(context);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 68154, 68203);

                            context.LanguageMode = PSLanguageMode.NoLanguage;
                            DynAbs.Tracing.TraceSender.TraceBreak(1372, 68229, 68235);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 67306, 68254);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 67197, 68269);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 68285, 68300);

                return oldMode;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 67034, 68311);

                System.Management.Automation.Security.SystemEnforcementMode
                f_1372_67201_67239()
                {
                    var return_v = SystemPolicy.GetSystemLockdownPolicy();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 67201, 67239);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1372_67314_67334(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 67314, 67334);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1372_67445_67465(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 67445, 67465);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1372_67681_67701(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 67681, 67701);
                    return return_v;
                }


                int
                f_1372_68016_68070(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 68016, 68070);
                    return 0;
                }


                System.Management.Automation.PSLanguageMode
                f_1372_68107_68127(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 68107, 68127);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 67034, 68311);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 67034, 68311);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly HashSet<string> AllowedCommands;

        internal static bool TryRunAsImplicitBatch(string command, Runspace runspace)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 69275, 77156);
                System.Collections.ObjectModel.Collection<System.Management.Automation.CommandInfo> cmdInfoList = default(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandInfo>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 69377, 77116);
                using (var
                ps = f_1372_69393_69441()
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 69475, 69498);

                    ps.Runspace = runspace;

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 69562, 69608);

                        var
                        scriptBlock = f_1372_69580_69607(command)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 69630, 69685);

                        var
                        scriptBlockAst = f_1372_69651_69666(scriptBlock) as ScriptBlockAst
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 69707, 69819) || true) && (scriptBlockAst == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 69707, 69819);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 69783, 69796);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 69707, 69819);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 69908, 69923);

                        string
                        errorId
                        = default(string);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 69945, 69961);

                        string
                        errorMsg
                        = default(string);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 69983, 70049);

                        f_1372_69983_70048(scriptBlockAst, true, out errorId, out errorMsg);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 70071, 70285) || true) && (errorId != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 70071, 70285);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 70140, 70223);

                            f_1372_70140_70222(ps, f_1372_70157_70221());
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 70249, 70262);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 70071, 70285);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 70345, 70432);

                        var
                        checker = new PipelineForBatchingChecker { ScriptBeingConverted = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => scriptBlockAst, 1372, 70359, 70431) }
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 70454, 70492);

                        f_1372_70454_70491(scriptBlockAst, checker);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 70607, 70723) || true) && (f_1372_70611_70633(checker.Commands) < 2)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 70607, 70723);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 70687, 70700);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 70607, 70723);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 70847, 71022) || true) && (!f_1372_70852_70936(ps, checker.Commands, out cmdInfoList))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 70847, 71022);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 70986, 70999);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 70847, 71022);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 71148, 71167);

                        var
                        success = true
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 71189, 71218);

                        var
                        psSessionId = Guid.Empty
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 71240, 73859);
                            foreach (var cmdInfo in f_1372_71264_71275_I(cmdInfoList))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 71240, 73859);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 71379, 71479);

                                string
                                cmdName = (DynAbs.Tracing.TraceSender.Conditional_F1(1372, 71396, 71428) || (((cmdInfo is AliasInfo) && DynAbs.Tracing.TraceSender.Conditional_F2(1372, 71431, 71463)) || DynAbs.Tracing.TraceSender.Conditional_F3(1372, 71466, 71478))) ? f_1372_71431_71463(f_1372_71431_71458((AliasInfo)cmdInfo)) : f_1372_71466_71478(cmdInfo)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 71505, 71636) || true) && (f_1372_71509_71542(AllowedCommands, cmdName))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 71505, 71636);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 71600, 71609);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 71505, 71636);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 71739, 72116) || true) && (f_1372_71743_71757(cmdInfo) == null || (DynAbs.Tracing.TraceSender.Expression_False(1372, 71743, 71809) || f_1372_71769_71809(f_1372_71790_71808(cmdInfo))))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 71739, 72116);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 71867, 72007);

                                    f_1372_71867_72006(ps, f_1372_71884_72005(f_1372_71898_71924(), f_1372_71926_71990(), f_1372_71992_72004(cmdInfo)));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 72037, 72053);

                                    success = false;
                                    DynAbs.Tracing.TraceSender.TraceBreak(1372, 72083, 72089);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 71739, 72116);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 72240, 73836) || true) && (f_1372_72244_72270(f_1372_72244_72258(cmdInfo)) is System.Collections.Hashtable privateData)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 72240, 73836);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 72372, 72437);

                                    var
                                    sessionIdString = f_1372_72394_72426(privateData, "ImplicitSessionId") as string
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 72467, 72835) || true) && (f_1372_72471_72508(sessionIdString))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 72467, 72835);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 72574, 72714);

                                        f_1372_72574_72713(ps, f_1372_72591_72712(f_1372_72605_72631(), f_1372_72633_72697(), f_1372_72699_72711(cmdInfo)));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 72748, 72764);

                                        success = false;
                                        DynAbs.Tracing.TraceSender.TraceBreak(1372, 72798, 72804);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 72467, 72835);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 72867, 72909);

                                    var
                                    sessionId = f_1372_72883_72908(sessionIdString)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 72939, 73473) || true) && (psSessionId == Guid.Empty)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 72939, 73473);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 73034, 73058);

                                        psSessionId = sessionId;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 72939, 73473);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 72939, 73473);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 73124, 73473) || true) && (psSessionId != sessionId)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 73124, 73473);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 73218, 73352);

                                            f_1372_73218_73351(ps, f_1372_73235_73350(f_1372_73249_73275(), f_1372_73277_73335(), f_1372_73337_73349(cmdInfo)));
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 73386, 73402);

                                            success = false;
                                            DynAbs.Tracing.TraceSender.TraceBreak(1372, 73436, 73442);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 73124, 73473);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 72939, 73473);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 72240, 73836);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 72240, 73836);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 73587, 73727);

                                    f_1372_73587_73726(ps, f_1372_73604_73725(f_1372_73618_73644(), f_1372_73646_73710(), f_1372_73712_73724(cmdInfo)));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 73757, 73773);

                                    success = false;
                                    DynAbs.Tracing.TraceSender.TraceBreak(1372, 73803, 73809);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 72240, 73836);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 71240, 73859);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1372, 1, 2620);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1372, 1, 2620);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 73883, 76624) || true) && (success)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 73883, 76624);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 74172, 74618) || true) && (f_1372_74176_74204(checker.ValidVariables) > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 74172, 74618);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 74266, 74517);
                                    foreach (var variableName in f_1372_74295_74317_I(checker.ValidVariables))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 74266, 74517);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 74383, 74486);

                                        command = f_1372_74393_74485(command, variableName, ("Using:" + variableName), StringComparison.OrdinalIgnoreCase);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 74266, 74517);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1372, 1, 252);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1372, 1, 252);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 74549, 74591);

                                scriptBlock = f_1372_74563_74590(command);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 74172, 74618);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 74742, 74762);

                            f_1372_74742_74761(f_1372_74742_74753(ps));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 74788, 74868);

                            f_1372_74788_74867(f_1372_74788_74827(f_1372_74788_74799(ps), "Get-PSSession"), "InstanceId", psSessionId);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 74894, 74989);

                            var
                            psSession = f_1372_74910_74988(f_1372_74910_74971(ps))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 75015, 75334) || true) && (psSession == null || (DynAbs.Tracing.TraceSender.Expression_False(1372, 75019, 75068) || (f_1372_75041_75063(f_1372_75041_75057(f_1372_75041_75051(ps))) > 0)) || (DynAbs.Tracing.TraceSender.Expression_False(1372, 75019, 75130) || (f_1372_75073_75095(psSession) != RunspaceAvailability.Available)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 75015, 75334);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 75188, 75264);

                                f_1372_75188_75263(ps, f_1372_75205_75262());
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 75294, 75307);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 75015, 75334);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 75362, 75434);

                            f_1372_75362_75433(ps, f_1372_75379_75432());
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 75543, 75563);

                            f_1372_75543_75562(f_1372_75543_75554(ps));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 75589, 75792);

                            f_1372_75589_75791(f_1372_75589_75735(f_1372_75589_75696(f_1372_75589_75655(f_1372_75589_75620(ps, "Invoke-Command"), "Session", psSession), "ScriptBlock", scriptBlock), "HideComputerName", true), "Out-Default");
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 75818, 76017);
                                foreach (var cmd in f_1372_75838_75858_I(f_1372_75838_75858(f_1372_75838_75849(ps))))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 75818, 76017);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 75916, 75990);

                                    f_1372_75916_75989(cmd, PipelineResultTypes.Error, PipelineResultTypes.Output);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 75818, 76017);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1372, 1, 200);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1372, 1, 200);
                            }
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 76105, 76117);

                                f_1372_76105_76116(ps);
                            }
                            catch (Exception ex)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1372, 76170, 76561);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 76247, 76373);

                                var
                                errorRecord = f_1372_76265_76372(ex, "ImplicitRemotingBatchExecutionTerminatingError", ErrorCategory.InvalidOperation, null)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 76405, 76425);

                                f_1372_76405_76424(f_1372_76405_76416(ps));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 76455, 76534);

                                f_1372_76455_76533(f_1372_76455_76524(f_1372_76455_76483(ps, "Write-Error"), "InputObject", errorRecord));
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1372, 76170, 76561);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 76589, 76601);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 73883, 76624);
                        }
                    }
                    catch (ImplicitRemotingBatchingNotSupportedException ex)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1372, 76661, 76874);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 76758, 76855);

                        f_1372_76758_76854(ps, f_1372_76775_76853(f_1372_76789_76815(), "{0} : {1}", f_1372_76830_76840(ex), f_1372_76842_76852(ex)));
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1372, 76661, 76874);
                    }
                    catch (Exception ex)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1372, 76892, 77101);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 76953, 77082);

                        f_1372_76953_77081(ps, f_1372_76970_77080(f_1372_76984_77010(), f_1372_77012_77067(), f_1372_77069_77079(ex)));
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1372, 76892, 77101);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1372, 69377, 77116);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 77132, 77145);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 69275, 77156);

                System.Management.Automation.PowerShell
                f_1372_69393_69441()
                {
                    var return_v = System.Management.Automation.PowerShell.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 69393, 69441);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1372_69580_69607(string
                script)
                {
                    var return_v = ScriptBlock.Create(script);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 69580, 69607);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1372_69651_69666(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.Ast;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 69651, 69666);
                    return return_v;
                }


                System.Management.Automation.Language.PipelineAst
                f_1372_69983_70048(System.Management.Automation.Language.ScriptBlockAst
                this_param, bool
                allowMultiplePipelines, out string
                errorId, out string
                errorMsg)
                {
                    var return_v = this_param.GetSimplePipeline(allowMultiplePipelines, out errorId, out errorMsg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 69983, 70048);
                    return return_v;
                }


                string
                f_1372_70157_70221()
                {
                    var return_v = ParserStrings.ImplicitRemotingPipelineBatchingNotASimplePipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 70157, 70221);
                    return return_v;
                }


                int
                f_1372_70140_70222(System.Management.Automation.PowerShell
                ps, string
                msg)
                {
                    WriteVerbose(ps, msg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 70140, 70222);
                    return 0;
                }


                System.Management.Automation.Language.AstVisitAction
                f_1372_70454_70491(System.Management.Automation.Language.ScriptBlockAst
                this_param, System.Management.Automation.PipelineForBatchingChecker
                visitor)
                {
                    var return_v = this_param.InternalVisit((System.Management.Automation.Language.AstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 70454, 70491);
                    return return_v;
                }


                int
                f_1372_70611_70633(System.Collections.Generic.HashSet<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 70611, 70633);
                    return return_v;
                }


                bool
                f_1372_70852_70936(System.Management.Automation.PowerShell
                ps, System.Collections.Generic.HashSet<string>
                commandNames, out System.Collections.ObjectModel.Collection<System.Management.Automation.CommandInfo>
                cmdInfoList)
                {
                    var return_v = TryGetCommandInfoList(ps, commandNames, out cmdInfoList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 70852, 70936);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1372_71431_71458(System.Management.Automation.AliasInfo
                this_param)
                {
                    var return_v = this_param.ReferencedCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 71431, 71458);
                    return return_v;
                }


                string
                f_1372_71431_71463(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 71431, 71463);
                    return return_v;
                }


                string
                f_1372_71466_71478(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 71466, 71478);
                    return return_v;
                }


                bool
                f_1372_71509_71542(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 71509, 71542);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1372_71743_71757(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 71743, 71757);
                    return return_v;
                }


                string
                f_1372_71790_71808(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 71790, 71808);
                    return return_v;
                }


                bool
                f_1372_71769_71809(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 71769, 71809);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1372_71898_71924()
                {
                    var return_v = CultureInfo.CurrentCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 71898, 71924);
                    return return_v;
                }


                string
                f_1372_71926_71990()
                {
                    var return_v = ParserStrings.ImplicitRemotingPipelineBatchingNotImplicitCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 71926, 71990);
                    return return_v;
                }


                string
                f_1372_71992_72004(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 71992, 72004);
                    return return_v;
                }


                string
                f_1372_71884_72005(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 71884, 72005);
                    return return_v;
                }


                int
                f_1372_71867_72006(System.Management.Automation.PowerShell
                ps, string
                msg)
                {
                    WriteVerbose(ps, msg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 71867, 72006);
                    return 0;
                }


                System.Management.Automation.PSModuleInfo
                f_1372_72244_72258(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 72244, 72258);
                    return return_v;
                }


                object
                f_1372_72244_72270(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.PrivateData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 72244, 72270);
                    return return_v;
                }


                object
                f_1372_72394_72426(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 72394, 72426);
                    return return_v;
                }


                bool
                f_1372_72471_72508(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 72471, 72508);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1372_72605_72631()
                {
                    var return_v = CultureInfo.CurrentCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 72605, 72631);
                    return return_v;
                }


                string
                f_1372_72633_72697()
                {
                    var return_v = ParserStrings.ImplicitRemotingPipelineBatchingNotImplicitCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 72633, 72697);
                    return return_v;
                }


                string
                f_1372_72699_72711(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 72699, 72711);
                    return return_v;
                }


                string
                f_1372_72591_72712(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 72591, 72712);
                    return return_v;
                }


                int
                f_1372_72574_72713(System.Management.Automation.PowerShell
                ps, string
                msg)
                {
                    WriteVerbose(ps, msg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 72574, 72713);
                    return 0;
                }


                System.Guid
                f_1372_72883_72908(string
                g)
                {
                    var return_v = new System.Guid(g);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 72883, 72908);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1372_73249_73275()
                {
                    var return_v = CultureInfo.CurrentCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 73249, 73275);
                    return return_v;
                }


                string
                f_1372_73277_73335()
                {
                    var return_v = ParserStrings.ImplicitRemotingPipelineBatchingWrongSession;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 73277, 73335);
                    return return_v;
                }


                string
                f_1372_73337_73349(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 73337, 73349);
                    return return_v;
                }


                string
                f_1372_73235_73350(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 73235, 73350);
                    return return_v;
                }


                int
                f_1372_73218_73351(System.Management.Automation.PowerShell
                ps, string
                msg)
                {
                    WriteVerbose(ps, msg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 73218, 73351);
                    return 0;
                }


                System.Globalization.CultureInfo
                f_1372_73618_73644()
                {
                    var return_v = CultureInfo.CurrentCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 73618, 73644);
                    return return_v;
                }


                string
                f_1372_73646_73710()
                {
                    var return_v = ParserStrings.ImplicitRemotingPipelineBatchingNotImplicitCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 73646, 73710);
                    return return_v;
                }


                string
                f_1372_73712_73724(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 73712, 73724);
                    return return_v;
                }


                string
                f_1372_73604_73725(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 73604, 73725);
                    return return_v;
                }


                int
                f_1372_73587_73726(System.Management.Automation.PowerShell
                ps, string
                msg)
                {
                    WriteVerbose(ps, msg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 73587, 73726);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.CommandInfo>
                f_1372_71264_71275_I(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 71264, 71275);
                    return return_v;
                }


                int
                f_1372_74176_74204(System.Collections.Generic.HashSet<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 74176, 74204);
                    return return_v;
                }


                string
                f_1372_74393_74485(string
                this_param, string
                oldValue, string
                newValue, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Replace(oldValue, newValue, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 74393, 74485);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_1372_74295_74317_I(System.Collections.Generic.HashSet<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 74295, 74317);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1372_74563_74590(string
                script)
                {
                    var return_v = ScriptBlock.Create(script);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 74563, 74590);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1372_74742_74753(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 74742, 74753);
                    return return_v;
                }


                int
                f_1372_74742_74761(System.Management.Automation.PSCommand
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 74742, 74761);
                    return 0;
                }


                System.Management.Automation.PSCommand
                f_1372_74788_74799(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 74788, 74799);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1372_74788_74827(System.Management.Automation.PSCommand
                this_param, string
                command)
                {
                    var return_v = this_param.AddCommand(command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 74788, 74827);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1372_74788_74867(System.Management.Automation.PSCommand
                this_param, string
                parameterName, System.Guid
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 74788, 74867);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>
                f_1372_74910_74971(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Invoke<System.Management.Automation.Runspaces.PSSession>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 74910, 74971);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PSSession
                f_1372_74910_74988(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.PSSession>
                source)
                {
                    var return_v = source.FirstOrDefault<System.Management.Automation.Runspaces.PSSession>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 74910, 74988);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1372_75041_75051(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 75041, 75051);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                f_1372_75041_75057(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Error;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 75041, 75057);
                    return return_v;
                }


                int
                f_1372_75041_75063(System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 75041, 75063);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceAvailability
                f_1372_75073_75095(System.Management.Automation.Runspaces.PSSession
                this_param)
                {
                    var return_v = this_param.Availability;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 75073, 75095);
                    return return_v;
                }


                string
                f_1372_75205_75262()
                {
                    var return_v = ParserStrings.ImplicitRemotingPipelineBatchingNoPSSession;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 75205, 75262);
                    return return_v;
                }


                int
                f_1372_75188_75263(System.Management.Automation.PowerShell
                ps, string
                msg)
                {
                    WriteVerbose(ps, msg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 75188, 75263);
                    return 0;
                }


                string
                f_1372_75379_75432()
                {
                    var return_v = ParserStrings.ImplicitRemotingPipelineBatchingSuccess;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 75379, 75432);
                    return return_v;
                }


                int
                f_1372_75362_75433(System.Management.Automation.PowerShell
                ps, string
                msg)
                {
                    WriteVerbose(ps, msg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 75362, 75433);
                    return 0;
                }


                System.Management.Automation.PSCommand
                f_1372_75543_75554(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 75543, 75554);
                    return return_v;
                }


                int
                f_1372_75543_75562(System.Management.Automation.PSCommand
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 75543, 75562);
                    return 0;
                }


                System.Management.Automation.PowerShell
                f_1372_75589_75620(System.Management.Automation.PowerShell
                this_param, string
                cmdlet)
                {
                    var return_v = this_param.AddCommand(cmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 75589, 75620);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1372_75589_75655(System.Management.Automation.PowerShell
                this_param, string
                parameterName, System.Management.Automation.Runspaces.PSSession
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 75589, 75655);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1372_75589_75696(System.Management.Automation.PowerShell
                this_param, string
                parameterName, System.Management.Automation.ScriptBlock
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 75589, 75696);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1372_75589_75735(System.Management.Automation.PowerShell
                this_param, string
                parameterName, bool
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 75589, 75735);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1372_75589_75791(System.Management.Automation.PowerShell
                this_param, string
                cmdlet)
                {
                    var return_v = this_param.AddCommand(cmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 75589, 75791);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1372_75838_75849(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 75838, 75849);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandCollection
                f_1372_75838_75858(System.Management.Automation.PSCommand
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 75838, 75858);
                    return return_v;
                }


                int
                f_1372_75916_75989(System.Management.Automation.Runspaces.Command
                this_param, System.Management.Automation.Runspaces.PipelineResultTypes
                myResult, System.Management.Automation.Runspaces.PipelineResultTypes
                toResult)
                {
                    this_param.MergeMyResults(myResult, toResult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 75916, 75989);
                    return 0;
                }


                System.Management.Automation.Runspaces.CommandCollection
                f_1372_75838_75858_I(System.Management.Automation.Runspaces.CommandCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 75838, 75858);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1372_76105_76116(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Invoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 76105, 76116);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1372_76265_76372(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 76265, 76372);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1372_76405_76416(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 76405, 76416);
                    return return_v;
                }


                int
                f_1372_76405_76424(System.Management.Automation.PSCommand
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 76405, 76424);
                    return 0;
                }


                System.Management.Automation.PowerShell
                f_1372_76455_76483(System.Management.Automation.PowerShell
                this_param, string
                cmdlet)
                {
                    var return_v = this_param.AddCommand(cmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 76455, 76483);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1372_76455_76524(System.Management.Automation.PowerShell
                this_param, string
                parameterName, System.Management.Automation.ErrorRecord
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 76455, 76524);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1372_76455_76533(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Invoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 76455, 76533);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1372_76789_76815()
                {
                    var return_v = CultureInfo.CurrentCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 76789, 76815);
                    return return_v;
                }


                string
                f_1372_76830_76840(System.Management.Automation.ImplicitRemotingBatchingNotSupportedException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 76830, 76840);
                    return return_v;
                }


                string
                f_1372_76842_76852(System.Management.Automation.ImplicitRemotingBatchingNotSupportedException
                this_param)
                {
                    var return_v = this_param.ErrorId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 76842, 76852);
                    return return_v;
                }


                string
                f_1372_76775_76853(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 76775, 76853);
                    return return_v;
                }


                int
                f_1372_76758_76854(System.Management.Automation.PowerShell
                ps, string
                msg)
                {
                    WriteVerbose(ps, msg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 76758, 76854);
                    return 0;
                }


                System.Globalization.CultureInfo
                f_1372_76984_77010()
                {
                    var return_v = CultureInfo.CurrentCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 76984, 77010);
                    return return_v;
                }


                string
                f_1372_77012_77067()
                {
                    var return_v = ParserStrings.ImplicitRemotingPipelineBatchingException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 77012, 77067);
                    return return_v;
                }


                string
                f_1372_77069_77079(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 77069, 77079);
                    return return_v;
                }


                string
                f_1372_76970_77080(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 76970, 77080);
                    return return_v;
                }


                int
                f_1372_76953_77081(System.Management.Automation.PowerShell
                ps, string
                msg)
                {
                    WriteVerbose(ps, msg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 76953, 77081);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 69275, 77156);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 69275, 77156);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void WriteVerbose(PowerShell ps, string msg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 77168, 77366);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 77252, 77272);

                f_1372_77252_77271(f_1372_77252_77263(ps));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 77286, 77355);

                f_1372_77286_77354(f_1372_77286_77345(f_1372_77286_77316(ps, "Write-Verbose"), "Message", msg));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 77168, 77366);

                System.Management.Automation.PSCommand
                f_1372_77252_77263(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 77252, 77263);
                    return return_v;
                }


                int
                f_1372_77252_77271(System.Management.Automation.PSCommand
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 77252, 77271);
                    return 0;
                }


                System.Management.Automation.PowerShell
                f_1372_77286_77316(System.Management.Automation.PowerShell
                this_param, string
                cmdlet)
                {
                    var return_v = this_param.AddCommand(cmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 77286, 77316);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1372_77286_77345(System.Management.Automation.PowerShell
                this_param, string
                parameterName, string
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 77286, 77345);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1372_77286_77354(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Invoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 77286, 77354);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 77168, 77366);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 77168, 77366);
            }
        }

        private const string
        WhereObjectCommandAlias = "?"
        ;

        private static bool TryGetCommandInfoList(PowerShell ps, HashSet<string> commandNames, out Collection<CommandInfo> cmdInfoList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 77439, 78998);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 77591, 77717) || true) && (f_1372_77595_77613(commandNames) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 77591, 77717);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 77652, 77671);

                    cmdInfoList = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 77689, 77702);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 77591, 77717);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 77733, 77816);

                bool
                specialCaseWhereCommandAlias = f_1372_77769_77815(commandNames, WhereObjectCommandAlias)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 77830, 77956) || true) && (specialCaseWhereCommandAlias)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 77830, 77956);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 77896, 77941);

                    f_1372_77896_77940(commandNames, WhereObjectCommandAlias);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 77830, 77956);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 78161, 78181);

                f_1372_78161_78180(f_1372_78161_78172(ps));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 78195, 78278);

                f_1372_78195_78277(f_1372_78195_78232(f_1372_78195_78206(ps), "Get-Command"), "Name", f_1372_78254_78276(commandNames));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 78292, 78331);

                cmdInfoList = f_1372_78306_78330(ps);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 78345, 78437) || true) && (f_1372_78349_78371(f_1372_78349_78365(f_1372_78349_78359(ps))) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 78345, 78437);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 78409, 78422);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 78345, 78437);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 78596, 78959) || true) && (specialCaseWhereCommandAlias)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 78596, 78959);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 78662, 78788);

                    var
                    cmdInfo = f_1372_78676_78787(f_1372_78676_78731(f_1372_78676_78717(f_1372_78676_78704(f_1372_78676_78687(ps)))), WhereObjectCommandAlias, CommandTypes.Alias)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 78806, 78899) || true) && (cmdInfo == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 78806, 78899);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 78867, 78880);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 78806, 78899);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 78919, 78944);

                    f_1372_78919_78943(
                                    cmdInfoList, cmdInfo);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 78596, 78959);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 78975, 78987);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 77439, 78998);

                int
                f_1372_77595_77613(System.Collections.Generic.HashSet<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 77595, 77613);
                    return return_v;
                }


                bool
                f_1372_77769_77815(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 77769, 77815);
                    return return_v;
                }


                bool
                f_1372_77896_77940(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Remove(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 77896, 77940);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1372_78161_78172(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 78161, 78172);
                    return return_v;
                }


                int
                f_1372_78161_78180(System.Management.Automation.PSCommand
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 78161, 78180);
                    return 0;
                }


                System.Management.Automation.PSCommand
                f_1372_78195_78206(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 78195, 78206);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1372_78195_78232(System.Management.Automation.PSCommand
                this_param, string
                command)
                {
                    var return_v = this_param.AddCommand(command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 78195, 78232);
                    return return_v;
                }


                string[]
                f_1372_78254_78276(System.Collections.Generic.HashSet<string>
                source)
                {
                    var return_v = source.ToArray<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 78254, 78276);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1372_78195_78277(System.Management.Automation.PSCommand
                this_param, string
                parameterName, string[]
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 78195, 78277);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.CommandInfo>
                f_1372_78306_78330(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Invoke<System.Management.Automation.CommandInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 78306, 78330);
                    return return_v;
                }


                System.Management.Automation.PSDataStreams
                f_1372_78349_78359(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Streams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 78349, 78359);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                f_1372_78349_78365(System.Management.Automation.PSDataStreams
                this_param)
                {
                    var return_v = this_param.Error;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 78349, 78365);
                    return return_v;
                }


                int
                f_1372_78349_78371(System.Management.Automation.PSDataCollection<System.Management.Automation.ErrorRecord>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 78349, 78371);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1372_78676_78687(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 78676, 78687);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1372_78676_78704(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 78676, 78704);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1372_78676_78717(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 78676, 78717);
                    return return_v;
                }


                System.Management.Automation.CommandInvocationIntrinsics
                f_1372_78676_78731(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.InvokeCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 78676, 78731);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1372_78676_78787(System.Management.Automation.CommandInvocationIntrinsics
                this_param, string
                commandName, System.Management.Automation.CommandTypes
                type)
                {
                    var return_v = this_param.GetCommand(commandName, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 78676, 78787);
                    return return_v;
                }


                int
                f_1372_78919_78943(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandInfo>
                this_param, System.Management.Automation.CommandInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 78919, 78943);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 77439, 78998);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 77439, 78998);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static Utils()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1372, 1168, 79027);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 10934, 10978);
            AllowedEditionValues = new string[] { "Desktop", "Core" };
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 14959, 14974);
            s_pshome = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 16143, 16176);
            s_windowsPowerShellVersion = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 17856, 17882);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 26299, 26348);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 26487, 26525);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 26756, 26822);
            ModuleDirectory = f_1372_26774_26822(ProductNameForDirectory, "Modules");
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 26874, 26927);
            SystemWideOnlyConfig = new[] { ConfigScope.AllUsers };
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 26977, 27034);
            CurrentUserOnlyConfig = new[] { ConfigScope.CurrentUser };
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 27084, 27173);
            SystemWideThenCurrentUserConfig = new[] { ConfigScope.AllUsers, ConfigScope.CurrentUser };
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 27223, 27312);
            CurrentUserThenSystemWideConfig = new[] { ConfigScope.CurrentUser, ConfigScope.AllUsers };
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 27985, 28090);
            s_cachedPoliciesFromConfigFile = f_1372_28031_28090();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 30880, 31686);
            GroupPolicyKeys = new Dictionary<string, string>
        {
            {DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => nameof(ScriptExecution),1372,30898,31686),@"Software\Policies\Microsoft\PowerShellCore"},            {nameof(ScriptBlockLogging), @"Software\Policies\Microsoft\PowerShellCore\ScriptBlockLogging"},            {nameof(ModuleLogging), @"Software\Policies\Microsoft\PowerShellCore\ModuleLogging"},            {nameof(ProtectedEventLogging), @"Software\Policies\Microsoft\Windows\EventLog\ProtectedEventLogging"},            {nameof(Transcription), @"Software\Policies\Microsoft\PowerShellCore\Transcription"},            {nameof(UpdatableHelp), @"Software\Policies\Microsoft\PowerShellCore\UpdatableHelp"},            {nameof(ConsoleSessionConfiguration), @"Software\Policies\Microsoft\PowerShellCore\ConsoleSessionConfiguration"}
        };
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 31750, 32360);
            WindowsPowershellGroupPolicyKeys = new Dictionary<string, string>
        {
            { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => nameof(ScriptExecution),1372,31785,32360),@"Software\Policies\Microsoft\Windows\PowerShell" },            { nameof(ScriptBlockLogging), @"Software\Policies\Microsoft\Windows\PowerShell\ScriptBlockLogging" },            { nameof(ModuleLogging), @"Software\Policies\Microsoft\Windows\PowerShell\ModuleLogging" },            { nameof(Transcription), @"Software\Policies\Microsoft\Windows\PowerShell\Transcription" },            { nameof(UpdatableHelp), @"Software\Policies\Microsoft\Windows\PowerShell\UpdatableHelp" }        };
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 32394, 32456);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 32569, 32694);
            s_cachedPoliciesFromRegistry = f_1372_32613_32694();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 32791, 32908);
            s_subCacheCreationDelegate = key => new ConcurrentDictionary<string, PolicyBase>(StringComparer.Ordinal);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 41688, 41729);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 53294, 53416);
            PowerShellAssemblyStrongNameFormat = "{0}, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 53470, 54110);
            PowerShellAssemblies = new HashSet<string>(f_1372_53526_53558())
                {
                    DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => "microsoft.powershell.commands.diagnostics",1372,53506,54110),                    "microsoft.powershell.commands.management",                    "microsoft.powershell.commands.utility",                    "microsoft.powershell.consolehost",                    "microsoft.powershell.scheduledjob",                    "microsoft.powershell.security",                    "microsoft.wsman.management",                    "microsoft.wsman.runtime",                    "system.management.automation"
                };
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 59336, 59416);
            BigEndianUTF32Encoding = f_1372_59361_59416(bigEndian: true, byteOrderMark: true);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 59721, 60084);
            encodingMap = new Dictionary<string, Encoding>()
            {
                { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => "255-254",1372,59748,60084),f_1372_59828_59844()},                { "254-255", f_1372_59878_59903()},                { "255-254-0-0", f_1372_59941_59955()},                { "0-0-254-255", BigEndianUTF32Encoding },                { "239-187-191", f_1372_60053_60066()}            };
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 60120, 60570);
            nonPrintableCharacters = new char[]{
            (char) 0, (char) 1, (char) 2, (char) 3, (char) 4, (char) 5, (char) 6, (char) 7, (char) 8,
            (char) 11, (char) 12, (char) 14, (char) 15, (char) 16, (char) 17, (char) 18, (char) 19, (char) 20,
            (char) 21, (char) 22, (char) 23, (char) 24, (char) 25, (char) 26, (char) 28, (char) 29, (char) 30,
            (char) 31, (char) 127, (char) 129, (char) 141, (char) 143, (char) 144, (char) 157 };
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 60621, 60702);
            utf8NoBom = f_1372_60646_60702(encoderShouldEmitUTF8Identifier: false);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 68506, 68749);
            AllowedCommands = new HashSet<string>(f_1372_68544_68576())
        {
            DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => "ForEach-Object",1372,68524,68749),            "Measure-Command",            "Measure-Object",            "Sort-Object",            "Where-Object"
        };
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 77399, 77428);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1372, 1168, 79027);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 1168, 79027);
        }


        static string
        f_1372_17495_17539(string
        shellId)
        {
            var return_v = GetApplicationBase(shellId);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 17495, 17539);
            return return_v;
        }


        static string
        f_1372_26774_26822(string
        path1, string
        path2)
        {
            var return_v = Path.Combine(path1, path2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 26774, 26822);
            return return_v;
        }


        static System.Collections.Concurrent.ConcurrentDictionary<System.Management.Automation.Configuration.ConfigScope, System.Management.Automation.Configuration.PowerShellPolicies>
        f_1372_28031_28090()
        {
            var return_v = new System.Collections.Concurrent.ConcurrentDictionary<System.Management.Automation.Configuration.ConfigScope, System.Management.Automation.Configuration.PowerShellPolicies>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 28031, 28090);
            return return_v;
        }


        static System.Collections.Concurrent.ConcurrentDictionary<System.Management.Automation.Configuration.ConfigScope, System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.Configuration.PolicyBase>>
        f_1372_32613_32694()
        {
            var return_v = new System.Collections.Concurrent.ConcurrentDictionary<System.Management.Automation.Configuration.ConfigScope, System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.Configuration.PolicyBase>>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 32613, 32694);
            return return_v;
        }


        static System.StringComparer
        f_1372_53526_53558()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 53526, 53558);
            return return_v;
        }


        static System.Text.UTF32Encoding
        f_1372_59361_59416(bool
        bigEndian, bool
        byteOrderMark)
        {
            var return_v = new System.Text.UTF32Encoding(bigEndian: bigEndian, byteOrderMark: byteOrderMark);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 59361, 59416);
            return return_v;
        }


        static System.Text.Encoding
        f_1372_59828_59844()
        {
            var return_v = Encoding.Unicode;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 59828, 59844);
            return return_v;
        }


        static System.Text.Encoding
        f_1372_59878_59903()
        {
            var return_v = Encoding.BigEndianUnicode;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 59878, 59903);
            return return_v;
        }


        static System.Text.Encoding
        f_1372_59941_59955()
        {
            var return_v = Encoding.UTF32;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 59941, 59955);
            return return_v;
        }


        static System.Text.Encoding
        f_1372_60053_60066()
        {
            var return_v = Encoding.UTF8;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 60053, 60066);
            return return_v;
        }


        static System.Text.UTF8Encoding
        f_1372_60646_60702(bool
        encoderShouldEmitUTF8Identifier)
        {
            var return_v = new System.Text.UTF8Encoding(encoderShouldEmitUTF8Identifier: encoderShouldEmitUTF8Identifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 60646, 60702);
            return return_v;
        }


        static System.StringComparer
        f_1372_68544_68576()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 68544, 68576);
            return return_v;
        }

    }
    internal class PipelineForBatchingChecker : AstVisitor
    {
        internal readonly HashSet<string> ValidVariables;

        internal readonly HashSet<string> Commands;

        internal ScriptBlockAst ScriptBeingConverted { get; set; }

        public override AstVisitAction VisitVariableExpression(VariableExpressionAst variableExpressionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1372, 79590, 80264);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 79714, 80009) || true) && (!f_1372_79719_79766(f_1372_79719_79753(variableExpressionAst)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 79714, 80009);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 79800, 79994);

                    f_1372_79800_79993(f_1372_79837_79944("VariableTypeNotSupported"), variableExpressionAst);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 79714, 80009);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 80025, 80206) || true) && (f_1372_80029_80079(f_1372_80029_80063(variableExpressionAst)) != "_")
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 80025, 80206);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 80120, 80191);

                    f_1372_80120_80190(ValidVariables, f_1372_80139_80189(f_1372_80139_80173(variableExpressionAst)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 80025, 80206);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 80222, 80253);

                return AstVisitAction.Continue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1372, 79590, 80264);

                System.Management.Automation.VariablePath
                f_1372_79719_79753(System.Management.Automation.Language.VariableExpressionAst
                this_param)
                {
                    var return_v = this_param.VariablePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 79719, 79753);
                    return return_v;
                }


                bool
                f_1372_79719_79766(System.Management.Automation.VariablePath
                variablePath)
                {
                    var return_v = variablePath.IsAnyLocal();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 79719, 79766);
                    return return_v;
                }


                System.Management.Automation.ImplicitRemotingBatchingNotSupportedException
                f_1372_79837_79944(string
                errorId)
                {
                    var return_v = new System.Management.Automation.ImplicitRemotingBatchingNotSupportedException(errorId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 79837, 79944);
                    return return_v;
                }


                int
                f_1372_79800_79993(System.Management.Automation.ImplicitRemotingBatchingNotSupportedException
                ex, System.Management.Automation.Language.VariableExpressionAst
                ast)
                {
                    ThrowError(ex, (System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 79800, 79993);
                    return 0;
                }


                System.Management.Automation.VariablePath
                f_1372_80029_80063(System.Management.Automation.Language.VariableExpressionAst
                this_param)
                {
                    var return_v = this_param.VariablePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 80029, 80063);
                    return return_v;
                }


                string
                f_1372_80029_80079(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.UnqualifiedPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 80029, 80079);
                    return return_v;
                }


                System.Management.Automation.VariablePath
                f_1372_80139_80173(System.Management.Automation.Language.VariableExpressionAst
                this_param)
                {
                    var return_v = this_param.VariablePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 80139, 80173);
                    return return_v;
                }


                string
                f_1372_80139_80189(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.UnqualifiedPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 80139, 80189);
                    return return_v;
                }


                bool
                f_1372_80120_80190(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 80120, 80190);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 79590, 80264);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 79590, 80264);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override AstVisitAction VisitPipeline(PipelineAst pipelineAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1372, 80276, 81784);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 80370, 81726) || true) && (f_1372_80374_80405(f_1372_80374_80402(pipelineAst), 0) is CommandExpressionAst)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 80370, 81726);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 81352, 81711) || true) && (f_1372_81356_81387(pipelineAst) == null || (DynAbs.Tracing.TraceSender.Expression_False(1372, 81356, 81448) || f_1372_81399_81424(f_1372_81399_81417(pipelineAst)) == f_1372_81428_81448()))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 81352, 81711);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 81490, 81692);

                        f_1372_81490_81691(f_1372_81527_81652("PipelineStartingWithExpressionNotSupported"), pipelineAst);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 81352, 81711);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 80370, 81726);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 81742, 81773);

                return AstVisitAction.Continue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1372, 80276, 81784);

                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandBaseAst>
                f_1372_80374_80402(System.Management.Automation.Language.PipelineAst
                this_param)
                {
                    var return_v = this_param.PipelineElements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 80374, 80402);
                    return return_v;
                }


                System.Management.Automation.Language.CommandBaseAst
                f_1372_80374_80405(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandBaseAst>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 80374, 80405);
                    return return_v;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1372_81356_81387(System.Management.Automation.Language.PipelineAst
                this_param)
                {
                    var return_v = this_param.GetPureExpression();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 81356, 81387);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1372_81399_81417(System.Management.Automation.Language.PipelineAst
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 81399, 81417);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1372_81399_81424(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 81399, 81424);
                    return return_v;
                }


                System.Management.Automation.Language.ScriptBlockAst
                f_1372_81428_81448()
                {
                    var return_v = ScriptBeingConverted;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 81428, 81448);
                    return return_v;
                }


                System.Management.Automation.ImplicitRemotingBatchingNotSupportedException
                f_1372_81527_81652(string
                errorId)
                {
                    var return_v = new System.Management.Automation.ImplicitRemotingBatchingNotSupportedException(errorId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 81527, 81652);
                    return return_v;
                }


                int
                f_1372_81490_81691(System.Management.Automation.ImplicitRemotingBatchingNotSupportedException
                ex, System.Management.Automation.Language.PipelineAst
                ast)
                {
                    ThrowError(ex, (System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 81490, 81691);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 80276, 81784);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 80276, 81784);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override AstVisitAction VisitCommand(CommandAst commandAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1372, 81796, 83521);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 81887, 82156) || true) && (f_1372_81891_81920(commandAst) == TokenKind.Dot)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 81887, 82156);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 81971, 82141);

                    f_1372_81971_82140(f_1372_82004_82106("DotSourcingNotSupported"), commandAst);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 81887, 82156);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 82999, 83289) || true) && (f_1372_83003_83032(f_1372_83003_83029(commandAst), 0) is ScriptBlockExpressionAst)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 82999, 83289);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 83094, 83274);

                    f_1372_83094_83273(f_1372_83127_83239("ScriptBlockInvocationNotSupported"), commandAst);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 82999, 83289);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 83305, 83351);

                var
                commandName = f_1372_83323_83350(commandAst)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 83365, 83463) || true) && (commandName != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 83365, 83463);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 83422, 83448);

                    f_1372_83422_83447(Commands, commandName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 83365, 83463);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 83479, 83510);

                return AstVisitAction.Continue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1372, 81796, 83521);

                System.Management.Automation.Language.TokenKind
                f_1372_81891_81920(System.Management.Automation.Language.CommandAst
                this_param)
                {
                    var return_v = this_param.InvocationOperator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 81891, 81920);
                    return return_v;
                }


                System.Management.Automation.ImplicitRemotingBatchingNotSupportedException
                f_1372_82004_82106(string
                errorId)
                {
                    var return_v = new System.Management.Automation.ImplicitRemotingBatchingNotSupportedException(errorId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 82004, 82106);
                    return return_v;
                }


                int
                f_1372_81971_82140(System.Management.Automation.ImplicitRemotingBatchingNotSupportedException
                ex, System.Management.Automation.Language.CommandAst
                ast)
                {
                    ThrowError(ex, (System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 81971, 82140);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                f_1372_83003_83029(System.Management.Automation.Language.CommandAst
                this_param)
                {
                    var return_v = this_param.CommandElements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 83003, 83029);
                    return return_v;
                }


                System.Management.Automation.Language.CommandElementAst
                f_1372_83003_83032(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 83003, 83032);
                    return return_v;
                }


                System.Management.Automation.ImplicitRemotingBatchingNotSupportedException
                f_1372_83127_83239(string
                errorId)
                {
                    var return_v = new System.Management.Automation.ImplicitRemotingBatchingNotSupportedException(errorId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 83127, 83239);
                    return return_v;
                }


                int
                f_1372_83094_83273(System.Management.Automation.ImplicitRemotingBatchingNotSupportedException
                ex, System.Management.Automation.Language.CommandAst
                ast)
                {
                    ThrowError(ex, (System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 83094, 83273);
                    return 0;
                }


                string
                f_1372_83323_83350(System.Management.Automation.Language.CommandAst
                this_param)
                {
                    var return_v = this_param.GetCommandName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 83323, 83350);
                    return return_v;
                }


                bool
                f_1372_83422_83447(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 83422, 83447);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 81796, 83521);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 81796, 83521);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override AstVisitAction VisitMergingRedirection(MergingRedirectionAst redirectionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1372, 83533, 83991);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 83650, 83933) || true) && (f_1372_83654_83677(redirectionAst) != RedirectionStream.Output)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 83650, 83933);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 83739, 83918);

                    f_1372_83739_83917(f_1372_83772_83879("MergeRedirectionNotSupported"), redirectionAst);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 83650, 83933);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 83949, 83980);

                return AstVisitAction.Continue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1372, 83533, 83991);

                System.Management.Automation.Language.RedirectionStream
                f_1372_83654_83677(System.Management.Automation.Language.MergingRedirectionAst
                this_param)
                {
                    var return_v = this_param.ToStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 83654, 83677);
                    return return_v;
                }


                System.Management.Automation.ImplicitRemotingBatchingNotSupportedException
                f_1372_83772_83879(string
                errorId)
                {
                    var return_v = new System.Management.Automation.ImplicitRemotingBatchingNotSupportedException(errorId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 83772, 83879);
                    return return_v;
                }


                int
                f_1372_83739_83917(System.Management.Automation.ImplicitRemotingBatchingNotSupportedException
                ex, System.Management.Automation.Language.MergingRedirectionAst
                ast)
                {
                    ThrowError(ex, (System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 83739, 83917);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 83533, 83991);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 83533, 83991);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override AstVisitAction VisitFileRedirection(FileRedirectionAst redirectionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1372, 84003, 84338);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 84114, 84280);

                f_1372_84114_84279(f_1372_84143_84245("FileRedirectionNotSupported"), redirectionAst);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 84296, 84327);

                return AstVisitAction.Continue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1372, 84003, 84338);

                System.Management.Automation.ImplicitRemotingBatchingNotSupportedException
                f_1372_84143_84245(string
                errorId)
                {
                    var return_v = new System.Management.Automation.ImplicitRemotingBatchingNotSupportedException(errorId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 84143, 84245);
                    return return_v;
                }


                int
                f_1372_84114_84279(System.Management.Automation.ImplicitRemotingBatchingNotSupportedException
                ex, System.Management.Automation.Language.FileRedirectionAst
                ast)
                {
                    ThrowError(ex, (System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 84114, 84279);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 84003, 84338);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 84003, 84338);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override AstVisitAction VisitUsingExpression(UsingExpressionAst usingExpressionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1372, 84752, 85159);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 84949, 85097);

                f_1372_84949_85096(f_1372_84960_85058("UsingExpressionNotSupported"), usingExpressionAst);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 85113, 85148);

                return AstVisitAction.SkipChildren;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1372, 84752, 85159);

                System.Management.Automation.ImplicitRemotingBatchingNotSupportedException
                f_1372_84960_85058(string
                errorId)
                {
                    var return_v = new System.Management.Automation.ImplicitRemotingBatchingNotSupportedException(errorId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 84960, 85058);
                    return return_v;
                }


                int
                f_1372_84949_85096(System.Management.Automation.ImplicitRemotingBatchingNotSupportedException
                ex, System.Management.Automation.Language.UsingExpressionAst
                ast)
                {
                    ThrowError(ex, (System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 84949, 85096);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 84752, 85159);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 84752, 85159);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void ThrowError(ImplicitRemotingBatchingNotSupportedException ex, Ast ast)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 85171, 85388);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 85286, 85354);

                f_1372_85286_85353(ex, f_1372_85342_85352(ast));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 85368, 85377);

                throw ex;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 85171, 85388);

                System.Management.Automation.Language.IScriptExtent
                f_1372_85342_85352(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 85342, 85352);
                    return return_v;
                }


                int
                f_1372_85286_85353(System.Management.Automation.ImplicitRemotingBatchingNotSupportedException
                exception, System.Management.Automation.Language.IScriptExtent
                extent)
                {
                    InterpreterError.UpdateExceptionErrorRecordPosition((System.Exception)exception, extent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 85286, 85353);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 85171, 85388);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 85171, 85388);
            }
        }

        public PipelineForBatchingChecker()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1372, 79225, 85395);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 79330, 79400);
            this.ValidVariables = f_1372_79347_79400(f_1372_79367_79399());
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 79445, 79509);
            this.Commands = f_1372_79456_79509(f_1372_79476_79508());
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 79520, 79578);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1372, 79225, 85395);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 79225, 85395);
        }


        static PipelineForBatchingChecker()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1372, 79225, 85395);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1372, 79225, 85395);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 79225, 85395);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1372, 79225, 85395);

        System.StringComparer
        f_1372_79367_79399()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 79367, 79399);
            return return_v;
        }


        System.Collections.Generic.HashSet<string>
        f_1372_79347_79400(System.StringComparer
        comparer)
        {
            var return_v = new System.Collections.Generic.HashSet<string>((System.Collections.Generic.IEqualityComparer<string>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 79347, 79400);
            return return_v;
        }


        System.StringComparer
        f_1372_79476_79508()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 79476, 79508);
            return return_v;
        }


        System.Collections.Generic.HashSet<string>
        f_1372_79456_79509(System.StringComparer
        comparer)
        {
            var return_v = new System.Collections.Generic.HashSet<string>((System.Collections.Generic.IEqualityComparer<string>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 79456, 79509);
            return return_v;
        }

    }
    internal class ImplicitRemotingBatchingNotSupportedException : Exception
    {
        internal string ErrorId
        {
            get;
            private set;
        }

        internal ImplicitRemotingBatchingNotSupportedException(string errorId) : base(
        f_1372_85685_85743_C(f_1372_85685_85743()))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1372, 85593, 85798);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 85492, 85581);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 85769, 85787);

                ErrorId = errorId;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1372, 85593, 85798);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 85593, 85798);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 85593, 85798);
            }
        }

        static ImplicitRemotingBatchingNotSupportedException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1372, 85403, 85805);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1372, 85403, 85805);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 85403, 85805);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1372, 85403, 85805);

        static string
        f_1372_85685_85743()
        {
            var return_v = ParserStrings.ImplicitRemotingPipelineBatchingNotSupported;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 85685, 85743);
            return return_v;
        }


        static string
        f_1372_85685_85743_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1372, 85593, 85798);
            return return_v;
        }

    }

}

namespace System.Management.Automation.Internal
{
    [SuppressMessage("Microsoft.MSInternal", "CA903:InternalNamespaceShouldNotContainPublicTypes", Justification = "Needed Internal use only")]
    public static class InternalTestHooks
    {
        internal static bool BypassGroupPolicyCaching;

        internal static bool ForceScriptBlockLogging;

        internal static bool UseDebugAmsiImplementation;

        internal static bool BypassAppLockerPolicyCaching;

        internal static bool BypassOnlineHelpRetrieval;

        internal static bool ForcePromptForChoiceDefaultOption;

        internal static bool TestStopComputer;

        internal static bool TestWaitStopComputer;

        internal static bool TestRenameComputer;

        internal static int TestStopComputerResults;

        internal static int TestRenameComputerResults;

        internal static bool IgnoreScriptBlockCache;

        internal static bool StopwatchIsNotHighResolution;

        internal static bool DisableGACLoading;

        internal static bool SetConsoleWidthToZero;

        internal static bool SetConsoleHeightToZero;

        internal static string TestWindowsPowerShellPSHomeLocation;

        internal static string TestWindowsPowerShellVersionString;

        internal static bool ShowMarkdownOutputBypass;

        public static void SetTestHook(string property, object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 87909, 88229);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 87995, 88102);

                var
                fieldInfo = f_1372_88011_88101(typeof(InternalTestHooks), property, BindingFlags.Static | BindingFlags.NonPublic)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 88116, 88218) || true) && (fieldInfo != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 88116, 88218);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 88171, 88203);

                    f_1372_88171_88202(fieldInfo, null, value);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 88116, 88218);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 87909, 88229);

                System.Reflection.FieldInfo?
                f_1372_88011_88101(System.Type
                this_param, string
                name, System.Reflection.BindingFlags
                bindingAttr)
                {
                    var return_v = this_param.GetField(name, bindingAttr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 88011, 88101);
                    return return_v;
                }


                int
                f_1372_88171_88202(System.Reflection.FieldInfo
                this_param, object?
                obj, object
                value)
                {
                    this_param.SetValue(obj, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 88171, 88202);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 87909, 88229);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 87909, 88229);
            }
        }

        public static bool TestImplicitRemotingBatching(string commandPipeline, System.Management.Automation.Runspaces.Runspace runspace)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1372, 88890, 89117);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 89044, 89106);

                return f_1372_89051_89105(commandPipeline, runspace);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1372, 88890, 89117);

                bool
                f_1372_89051_89105(string
                command, System.Management.Automation.Runspaces.Runspace
                runspace)
                {
                    var return_v = Utils.TryRunAsImplicitBatch(command, runspace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 89051, 89105);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 88890, 89117);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 88890, 89117);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static InternalTestHooks()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1372, 85961, 89124);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 86181, 86205);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 86237, 86260);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 86292, 86318);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 86350, 86378);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 86410, 86435);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 86467, 86500);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 86581, 86597);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 86629, 86649);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 86681, 86699);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 86730, 86753);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 86784, 86809);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 86964, 86986);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 87121, 87149);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 87181, 87198);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 87230, 87251);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 87283, 87305);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 87517, 87552);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 87724, 87758);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 87792, 87816);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1372, 85961, 89124);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 85961, 89124);
        }

    }
    internal class HistoryStack<T>
    {
        private readonly BoundedStack<T> _boundedUndoStack;

        private readonly BoundedStack<T> _boundedRedoStack;

        internal HistoryStack(uint capacity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1372, 89443, 89629);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 89352, 89369);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 89413, 89430);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 89504, 89554);

                _boundedUndoStack = f_1372_89524_89553(capacity);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 89568, 89618);

                _boundedRedoStack = f_1372_89588_89617(capacity);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1372, 89443, 89629);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 89443, 89629);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 89443, 89629);
            }
        }

        internal void Push(T item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1372, 89641, 89839);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 89692, 89721);

                f_1372_89692_89720(_boundedUndoStack, item);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 89735, 89828) || true) && (f_1372_89739_89748() >= 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 89735, 89828);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 89787, 89813);

                    f_1372_89787_89812(_boundedRedoStack);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 89735, 89828);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1372, 89641, 89839);

                int
                f_1372_89692_89720(System.Management.Automation.Internal.BoundedStack<T>
                this_param, T
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 89692, 89720);
                    return 0;
                }


                int
                f_1372_89739_89748()
                {
                    var return_v = RedoCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 89739, 89748);
                    return return_v;
                }


                int
                f_1372_89787_89812(System.Management.Automation.Internal.BoundedStack<T>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 89787, 89812);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 89641, 89839);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 89641, 89839);
            }
        }

        internal T Undo(T currentItem)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1372, 90037, 90228);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 90092, 90133);

                T
                previousItem = f_1372_90109_90132(_boundedUndoStack)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 90147, 90183);

                f_1372_90147_90182(_boundedRedoStack, currentItem);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 90197, 90217);

                return previousItem;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1372, 90037, 90228);

                T
                f_1372_90109_90132(System.Management.Automation.Internal.BoundedStack<T>
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 90109, 90132);
                    return return_v;
                }


                int
                f_1372_90147_90182(System.Management.Automation.Internal.BoundedStack<T>
                this_param, T
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 90147, 90182);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 90037, 90228);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 90037, 90228);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal T Redo(T currentItem)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1372, 90426, 90611);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 90481, 90520);

                var
                nextItem = f_1372_90496_90519(_boundedRedoStack)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 90534, 90570);

                f_1372_90534_90569(_boundedUndoStack, currentItem);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 90584, 90600);

                return nextItem;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1372, 90426, 90611);

                T
                f_1372_90496_90519(System.Management.Automation.Internal.BoundedStack<T>
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 90496, 90519);
                    return return_v;
                }


                int
                f_1372_90534_90569(System.Management.Automation.Internal.BoundedStack<T>
                this_param, T
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 90534, 90569);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 90426, 90611);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 90426, 90611);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal int UndoCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1372, 90646, 90672);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 90649, 90672);
                    return f_1372_90649_90672(_boundedUndoStack);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1372, 90646, 90672);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 90646, 90672);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 90646, 90672);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal int RedoCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1372, 90708, 90734);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 90711, 90734);
                    return f_1372_90711_90734(_boundedRedoStack);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1372, 90708, 90734);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 90708, 90734);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 90708, 90734);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static HistoryStack()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1372, 89272, 90742);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1372, 89272, 90742);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 89272, 90742);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1372, 89272, 90742);

        System.Management.Automation.Internal.BoundedStack<T>
        f_1372_89524_89553(uint
        capacity)
        {
            var return_v = new System.Management.Automation.Internal.BoundedStack<T>(capacity);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 89524, 89553);
            return return_v;
        }


        System.Management.Automation.Internal.BoundedStack<T>
        f_1372_89588_89617(uint
        capacity)
        {
            var return_v = new System.Management.Automation.Internal.BoundedStack<T>(capacity);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 89588, 89617);
            return return_v;
        }


        int
        f_1372_90649_90672(System.Management.Automation.Internal.BoundedStack<T>
        this_param)
        {
            var return_v = this_param.Count;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 90649, 90672);
            return return_v;
        }


        int
        f_1372_90711_90734(System.Management.Automation.Internal.BoundedStack<T>
        this_param)
        {
            var return_v = this_param.Count;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 90711, 90734);
            return return_v;
        }

    }
    internal class BoundedStack<T> : LinkedList<T>
    {
        private readonly uint _capacity;

        internal BoundedStack(uint capacity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1372, 91156, 91249);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 90923, 90932);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 91217, 91238);

                _capacity = capacity;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1372, 91156, 91249);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 91156, 91249);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 91156, 91249);
            }
        }

        internal void Push(T item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1372, 91373, 91564);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 91424, 91444);

                f_1372_91424_91443(this, item);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 91460, 91553) || true) && (f_1372_91464_91474(this) > _capacity)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 91460, 91553);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 91520, 91538);

                    f_1372_91520_91537(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 91460, 91553);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1372, 91373, 91564);

                System.Collections.Generic.LinkedListNode<T>
                f_1372_91424_91443(System.Management.Automation.Internal.BoundedStack<T>
                this_param, T
                value)
                {
                    var return_v = this_param.AddFirst(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 91424, 91443);
                    return return_v;
                }


                int
                f_1372_91464_91474(System.Management.Automation.Internal.BoundedStack<T>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 91464, 91474);
                    return return_v;
                }


                int
                f_1372_91520_91537(System.Management.Automation.Internal.BoundedStack<T>
                this_param)
                {
                    this_param.RemoveLast();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 91520, 91537);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 91373, 91564);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 91373, 91564);
            }
        }

        internal T Pop()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1372, 91679, 92207);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 91720, 91868) || true) && (f_1372_91724_91734(this) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 91720, 91868);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 91776, 91853);

                    throw f_1372_91782_91852(f_1372_91812_91851());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 91720, 91868);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 91884, 91912);

                var
                item = f_1372_91895_91911(f_1372_91895_91905(this))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 91962, 91981);

                    f_1372_91962_91980(this);
                }
                catch (InvalidOperationException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1372, 92010, 92168);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 92076, 92153);

                    throw f_1372_92082_92152(f_1372_92112_92151());
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1372, 92010, 92168);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 92184, 92196);

                return item;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1372, 91679, 92207);

                System.Collections.Generic.LinkedListNode<T>
                f_1372_91724_91734(System.Management.Automation.Internal.BoundedStack<T>
                this_param)
                {
                    var return_v = this_param.First;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 91724, 91734);
                    return return_v;
                }


                string
                f_1372_91812_91851()
                {
                    var return_v = SessionStateStrings.BoundedStackIsEmpty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 91812, 91851);
                    return return_v;
                }


                System.InvalidOperationException
                f_1372_91782_91852(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 91782, 91852);
                    return return_v;
                }


                System.Collections.Generic.LinkedListNode<T>
                f_1372_91895_91905(System.Management.Automation.Internal.BoundedStack<T>
                this_param)
                {
                    var return_v = this_param.First;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 91895, 91905);
                    return return_v;
                }


                T
                f_1372_91895_91911(System.Collections.Generic.LinkedListNode<T>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 91895, 91911);
                    return return_v;
                }


                int
                f_1372_91962_91980(System.Management.Automation.Internal.BoundedStack<T>
                this_param)
                {
                    this_param.RemoveFirst();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 91962, 91980);
                    return 0;
                }


                string
                f_1372_92112_92151()
                {
                    var return_v = SessionStateStrings.BoundedStackIsEmpty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 92112, 92151);
                    return return_v;
                }


                System.InvalidOperationException
                f_1372_92082_92152(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 92082, 92152);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 91679, 92207);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 91679, 92207);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static BoundedStack()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1372, 90838, 92214);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1372, 90838, 92214);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 90838, 92214);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1372, 90838, 92214);
    }
    internal sealed class ReadOnlyBag<T> : IEnumerable
    {
        private HashSet<T> _hashset;

        internal ReadOnlyBag(HashSet<T> hashset)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1372, 92495, 92723);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 92376, 92384);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 92560, 92677) || true) && (hashset == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1372, 92560, 92677);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 92613, 92662);

                    throw f_1372_92619_92661(nameof(hashset));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1372, 92560, 92677);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 92693, 92712);

                _hashset = hashset;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1372, 92495, 92723);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 92495, 92723);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 92495, 92723);
            }
        }

        public int Count
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1372, 92842, 92859);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 92845, 92859);
                    return f_1372_92845_92859(_hashset);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1372, 92842, 92859);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 92842, 92859);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 92842, 92859);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsReadOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1372, 92992, 92999);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 92995, 92999);
                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1372, 92992, 92999);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 92992, 92999);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 92992, 92999);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool Contains(T item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1372, 93136, 93162);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 93139, 93162);
                return f_1372_93139_93162(_hashset, item);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1372, 93136, 93162);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 93136, 93162);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 93136, 93162);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_1372_93139_93162(System.Collections.Generic.HashSet<T>
            this_param, T
            item)
            {
                var return_v = this_param.Contains(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 93139, 93162);
                return return_v;
            }

        }

        public IEnumerator GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1372, 93292, 93319);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 93295, 93319);
                return f_1372_93295_93319(_hashset);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1372, 93292, 93319);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1372, 93292, 93319);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 93292, 93319);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Generic.HashSet<T>.Enumerator
            f_1372_93295_93319(System.Collections.Generic.HashSet<T>
            this_param)
            {
                var return_v = this_param.GetEnumerator();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 93295, 93319);
                return return_v;
            }

        }

        internal static readonly ReadOnlyBag<T> Empty;

        static ReadOnlyBag()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1372, 92290, 93519);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1372, 93456, 93511);
            Empty = f_1372_93464_93511(f_1372_93483_93510(capacity: 0));
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1372, 92290, 93519);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1372, 92290, 93519);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1372, 92290, 93519);

        System.ArgumentNullException
        f_1372_92619_92661(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 92619, 92661);
            return return_v;
        }


        int
        f_1372_92845_92859(System.Collections.Generic.HashSet<T>
        this_param)
        {
            var return_v = this_param.Count;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1372, 92845, 92859);
            return return_v;
        }


        static System.Collections.Generic.HashSet<T>
        f_1372_93483_93510(int
        capacity)
        {
            var return_v = new System.Collections.Generic.HashSet<T>(capacity: capacity);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 93483, 93510);
            return return_v;
        }


        static System.Management.Automation.Internal.ReadOnlyBag<T>
        f_1372_93464_93511(System.Collections.Generic.HashSet<T>
        hashset)
        {
            var return_v = new System.Management.Automation.Internal.ReadOnlyBag<T>(hashset);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1372, 93464, 93511);
            return return_v;
        }

    }
}
